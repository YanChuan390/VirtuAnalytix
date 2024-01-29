using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Core.PathCore;
using DG.Tweening.Plugins.Options;
using Il2CppDummyDll;
using MEC;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Scripting;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public static class MECExtensionMethods2
{
	[Token(Token = "0x2000003")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778394", Offset = "0x778394")]
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
			[Address(RVA = "0x19A4BB4", Offset = "0x19A4BB4", VA = "0x19A4BB4", Slot = "4")]
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
			[Address(RVA = "0x19A4BFC", Offset = "0x19A4BFC", VA = "0x19A4BFC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x19A49C4", Offset = "0x19A49C4", VA = "0x19A49C4")]
		[DebuggerHidden]
		public <Delay>d__0(int <>1__state)
		{
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x19A49F0", Offset = "0x19A49F0", VA = "0x19A49F0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x19A49F4", Offset = "0x19A49F4", VA = "0x19A49F4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x19A4BBC", Offset = "0x19A4BBC", VA = "0x19A4BBC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000004")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7783A4", Offset = "0x7783A4")]
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
			[Address(RVA = "0x19A4E28", Offset = "0x19A4E28", VA = "0x19A4E28", Slot = "4")]
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
			[Address(RVA = "0x19A4E70", Offset = "0x19A4E70", VA = "0x19A4E70", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x19A4C5C", Offset = "0x19A4C5C", VA = "0x19A4C5C")]
		[DebuggerHidden]
		public <Delay>d__1(int <>1__state)
		{
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x19A4C88", Offset = "0x19A4C88", VA = "0x19A4C88", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x19A4C8C", Offset = "0x19A4C8C", VA = "0x19A4C8C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x19A4E30", Offset = "0x19A4E30", VA = "0x19A4E30", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000005")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7783B4", Offset = "0x7783B4")]
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
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7783C4", Offset = "0x7783C4")]
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
			[Address(RVA = "0x19A5084", Offset = "0x19A5084", VA = "0x19A5084", Slot = "4")]
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
			[Address(RVA = "0x19A50CC", Offset = "0x19A50CC", VA = "0x19A50CC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x19A4ED0", Offset = "0x19A4ED0", VA = "0x19A4ED0")]
		[DebuggerHidden]
		public <DelayFrames>d__3(int <>1__state)
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x19A4EFC", Offset = "0x19A4EFC", VA = "0x19A4EFC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x19A4F00", Offset = "0x19A4F00", VA = "0x19A4F00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x19A508C", Offset = "0x19A508C", VA = "0x19A508C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000007")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7783D4", Offset = "0x7783D4")]
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
			[Address(RVA = "0x19A42C8", Offset = "0x19A42C8", VA = "0x19A42C8", Slot = "4")]
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
			[Address(RVA = "0x19A4310", Offset = "0x19A4310", VA = "0x19A4310", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x19A405C", Offset = "0x19A405C", VA = "0x19A405C")]
		[DebuggerHidden]
		public <CancelWith>d__4(int <>1__state)
		{
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x19A4088", Offset = "0x19A4088", VA = "0x19A4088", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x19A408C", Offset = "0x19A408C", VA = "0x19A408C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x19A42D0", Offset = "0x19A42D0", VA = "0x19A42D0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000008")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7783E4", Offset = "0x7783E4")]
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
			[Address(RVA = "0x19A461C", Offset = "0x19A461C", VA = "0x19A461C", Slot = "4")]
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
			[Address(RVA = "0x19A4664", Offset = "0x19A4664", VA = "0x19A4664", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x19A4370", Offset = "0x19A4370", VA = "0x19A4370")]
		[DebuggerHidden]
		public <CancelWith>d__5(int <>1__state)
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x19A439C", Offset = "0x19A439C", VA = "0x19A439C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x19A43A0", Offset = "0x19A43A0", VA = "0x19A43A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x19A4624", Offset = "0x19A4624", VA = "0x19A4624", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000009")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7783F4", Offset = "0x7783F4")]
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
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778404", Offset = "0x778404")]
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
			[Address(RVA = "0x19A491C", Offset = "0x19A491C", VA = "0x19A491C", Slot = "4")]
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
			[Address(RVA = "0x19A4964", Offset = "0x19A4964", VA = "0x19A4964", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x19A46C4", Offset = "0x19A46C4", VA = "0x19A46C4")]
		[DebuggerHidden]
		public <CancelWith>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x19A46F0", Offset = "0x19A46F0", VA = "0x19A46F0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x19A46F4", Offset = "0x19A46F4", VA = "0x19A46F4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x19A4924", Offset = "0x19A4924", VA = "0x19A4924", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200000B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778414", Offset = "0x778414")]
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
			[Address(RVA = "0x19A5B5C", Offset = "0x19A5B5C", VA = "0x19A5B5C", Slot = "4")]
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
			[Address(RVA = "0x19A5BA4", Offset = "0x19A5BA4", VA = "0x19A5BA4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x19A58E4", Offset = "0x19A58E4", VA = "0x19A58E4")]
		[DebuggerHidden]
		public <PauseWith>d__8(int <>1__state)
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x19A5910", Offset = "0x19A5910", VA = "0x19A5910", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x19A5914", Offset = "0x19A5914", VA = "0x19A5914", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x19A5B64", Offset = "0x19A5B64", VA = "0x19A5B64", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200000C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778424", Offset = "0x778424")]
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
			[Address(RVA = "0x19A5EBC", Offset = "0x19A5EBC", VA = "0x19A5EBC", Slot = "4")]
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
			[Address(RVA = "0x19A5F04", Offset = "0x19A5F04", VA = "0x19A5F04", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x19A5C04", Offset = "0x19A5C04", VA = "0x19A5C04")]
		[DebuggerHidden]
		public <PauseWith>d__9(int <>1__state)
		{
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x19A5C30", Offset = "0x19A5C30", VA = "0x19A5C30", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x19A5C34", Offset = "0x19A5C34", VA = "0x19A5C34", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x19A5EC4", Offset = "0x19A5EC4", VA = "0x19A5EC4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200000D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778434", Offset = "0x778434")]
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
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778444", Offset = "0x778444")]
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
			[Address(RVA = "0x19A583C", Offset = "0x19A583C", VA = "0x19A583C", Slot = "4")]
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
			[Address(RVA = "0x19A5884", Offset = "0x19A5884", VA = "0x19A5884", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x19A55E4", Offset = "0x19A55E4", VA = "0x19A55E4")]
		[DebuggerHidden]
		public <PauseWith>d__11(int <>1__state)
		{
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x19A5610", Offset = "0x19A5610", VA = "0x19A5610", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x19A5614", Offset = "0x19A5614", VA = "0x19A5614", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x19A5844", Offset = "0x19A5844", VA = "0x19A5844", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200000F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778454", Offset = "0x778454")]
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
			[Address(RVA = "0x19A553C", Offset = "0x19A553C", VA = "0x19A553C", Slot = "4")]
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
			[Address(RVA = "0x19A5584", Offset = "0x19A5584", VA = "0x19A5584", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x19A53A4", Offset = "0x19A53A4", VA = "0x19A53A4")]
		[DebuggerHidden]
		public <KillWith>d__12(int <>1__state)
		{
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x19A53D0", Offset = "0x19A53D0", VA = "0x19A53D0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x19A53D4", Offset = "0x19A53D4", VA = "0x19A53D4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x19A5544", Offset = "0x19A5544", VA = "0x19A5544", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000010")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778464", Offset = "0x778464")]
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
			[Address(RVA = "0x19A3D74", Offset = "0x19A3D74", VA = "0x19A3D74", Slot = "4")]
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
			[Address(RVA = "0x19A3DBC", Offset = "0x19A3DBC", VA = "0x19A3DBC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x19A3ACC", Offset = "0x19A3ACC", VA = "0x19A3ACC")]
		[DebuggerHidden]
		public <Append>d__13(int <>1__state)
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x19A3AF8", Offset = "0x19A3AF8", VA = "0x19A3AF8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x19A3AFC", Offset = "0x19A3AFC", VA = "0x19A3AFC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x19A3D7C", Offset = "0x19A3D7C", VA = "0x19A3D7C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000011")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778474", Offset = "0x778474")]
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
			[Address(RVA = "0x19A3FB4", Offset = "0x19A3FB4", VA = "0x19A3FB4", Slot = "4")]
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
			[Address(RVA = "0x19A3FFC", Offset = "0x19A3FFC", VA = "0x19A3FFC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x19A3E1C", Offset = "0x19A3E1C", VA = "0x19A3E1C")]
		[DebuggerHidden]
		public <Append>d__14(int <>1__state)
		{
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x19A3E48", Offset = "0x19A3E48", VA = "0x19A3E48", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x19A3E4C", Offset = "0x19A3E4C", VA = "0x19A3E4C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x19A3FBC", Offset = "0x19A3FBC", VA = "0x19A3FBC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000012")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778484", Offset = "0x778484")]
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
			[Address(RVA = "0x19A6220", Offset = "0x19A6220", VA = "0x19A6220", Slot = "4")]
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
			[Address(RVA = "0x19A6268", Offset = "0x19A6268", VA = "0x19A6268", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x19A5F64", Offset = "0x19A5F64", VA = "0x19A5F64")]
		[DebuggerHidden]
		public <Prepend>d__15(int <>1__state)
		{
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x19A5F90", Offset = "0x19A5F90", VA = "0x19A5F90", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x19A5F94", Offset = "0x19A5F94", VA = "0x19A5F94", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x19A6228", Offset = "0x19A6228", VA = "0x19A6228", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000013")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778494", Offset = "0x778494")]
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
			[Address(RVA = "0x19A6470", Offset = "0x19A6470", VA = "0x19A6470", Slot = "4")]
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
			[Address(RVA = "0x19A64B8", Offset = "0x19A64B8", VA = "0x19A64B8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x19A62C8", Offset = "0x19A62C8", VA = "0x19A62C8")]
		[DebuggerHidden]
		public <Prepend>d__16(int <>1__state)
		{
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x19A62F4", Offset = "0x19A62F4", VA = "0x19A62F4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x19A62F8", Offset = "0x19A62F8", VA = "0x19A62F8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x19A6478", Offset = "0x19A6478", VA = "0x19A6478", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000014")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7784A4", Offset = "0x7784A4")]
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
			[Address(RVA = "0x19A6E2C", Offset = "0x19A6E2C", VA = "0x19A6E2C", Slot = "4")]
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
			[Address(RVA = "0x19A6E74", Offset = "0x19A6E74", VA = "0x19A6E74", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x19A67E4", Offset = "0x19A67E4", VA = "0x19A67E4")]
		[DebuggerHidden]
		public <Superimpose>d__18(int <>1__state)
		{
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x19A6810", Offset = "0x19A6810", VA = "0x19A6810", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x19A6814", Offset = "0x19A6814", VA = "0x19A6814", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x19A6E34", Offset = "0x19A6E34", VA = "0x19A6E34", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000015")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7784B4", Offset = "0x7784B4")]
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
			[Address(RVA = "0x19A52FC", Offset = "0x19A52FC", VA = "0x19A52FC", Slot = "4")]
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
			[Address(RVA = "0x19A5344", Offset = "0x19A5344", VA = "0x19A5344", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x19A512C", Offset = "0x19A512C", VA = "0x19A512C")]
		[DebuggerHidden]
		public <Hijack>d__19(int <>1__state)
		{
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x19A5158", Offset = "0x19A5158", VA = "0x19A5158", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x19A515C", Offset = "0x19A515C", VA = "0x19A515C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x19A5304", Offset = "0x19A5304", VA = "0x19A5304", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000016")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7784C4", Offset = "0x7784C4")]
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
			[Address(RVA = "0x19A673C", Offset = "0x19A673C", VA = "0x19A673C", Slot = "4")]
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
			[Address(RVA = "0x19A6784", Offset = "0x19A6784", VA = "0x19A6784", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x19A6518", Offset = "0x19A6518", VA = "0x19A6518")]
		[DebuggerHidden]
		public <RerouteExceptions>d__20(int <>1__state)
		{
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x19A6544", Offset = "0x19A6544", VA = "0x19A6544", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x19A6548", Offset = "0x19A6548", VA = "0x19A6548", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x19A6744", Offset = "0x19A6744", VA = "0x19A6744", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x9B772C", Offset = "0x9B772C", VA = "0x9B772C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x778E4C", Offset = "0x778E4C")]
	public static IEnumerator<float> Delay(this IEnumerator<float> coroutine, float timeToDelay)
	{
		return null;
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x9B77A8", Offset = "0x9B77A8", VA = "0x9B77A8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x778EBC", Offset = "0x778EBC")]
	public static IEnumerator<float> Delay(this IEnumerator<float> coroutine, Func<bool> condition)
	{
		return null;
	}

	[Token(Token = "0x6000003")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x778F2C", Offset = "0x778F2C")]
	public static IEnumerator<float> Delay<T>(this IEnumerator<float> coroutine, T data, Func<T, bool> condition)
	{
		return null;
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x9B7820", Offset = "0x9B7820", VA = "0x9B7820")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x778F9C", Offset = "0x778F9C")]
	public static IEnumerator<float> DelayFrames(this IEnumerator<float> coroutine, int framesToDelay)
	{
		return null;
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x9B789C", Offset = "0x9B789C", VA = "0x9B789C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x77900C", Offset = "0x77900C")]
	public static IEnumerator<float> CancelWith(this IEnumerator<float> coroutine, GameObject gameObject)
	{
		return null;
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x9B7914", Offset = "0x9B7914", VA = "0x9B7914")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x77907C", Offset = "0x77907C")]
	public static IEnumerator<float> CancelWith(this IEnumerator<float> coroutine, GameObject gameObject1, GameObject gameObject2)
	{
		return null;
	}

	[Token(Token = "0x6000007")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7790EC", Offset = "0x7790EC")]
	public static IEnumerator<float> CancelWith<T>(this IEnumerator<float> coroutine, T script) where T : MonoBehaviour
	{
		return null;
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x9B7994", Offset = "0x9B7994", VA = "0x9B7994")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x77915C", Offset = "0x77915C")]
	public static IEnumerator<float> CancelWith(this IEnumerator<float> coroutine, Func<bool> condition)
	{
		return null;
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x9B7A0C", Offset = "0x9B7A0C", VA = "0x9B7A0C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7791CC", Offset = "0x7791CC")]
	public static IEnumerator<float> PauseWith(this IEnumerator<float> coroutine, GameObject gameObject)
	{
		return null;
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x9B7A84", Offset = "0x9B7A84", VA = "0x9B7A84")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x77923C", Offset = "0x77923C")]
	public static IEnumerator<float> PauseWith(this IEnumerator<float> coroutine, GameObject gameObject1, GameObject gameObject2)
	{
		return null;
	}

	[Token(Token = "0x600000B")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7792AC", Offset = "0x7792AC")]
	public static IEnumerator<float> PauseWith<T>(this IEnumerator<float> coroutine, T script) where T : MonoBehaviour
	{
		return null;
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x9B7B04", Offset = "0x9B7B04", VA = "0x9B7B04")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x77931C", Offset = "0x77931C")]
	public static IEnumerator<float> PauseWith(this IEnumerator<float> coroutine, Func<bool> condition)
	{
		return null;
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x9B7B7C", Offset = "0x9B7B7C", VA = "0x9B7B7C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x77938C", Offset = "0x77938C")]
	public static IEnumerator<float> KillWith(this IEnumerator<float> coroutine, CoroutineHandle otherCoroutine)
	{
		return null;
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x9B7BF8", Offset = "0x9B7BF8", VA = "0x9B7BF8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7793FC", Offset = "0x7793FC")]
	public static IEnumerator<float> Append(this IEnumerator<float> coroutine, IEnumerator<float> nextCoroutine)
	{
		return null;
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x9B7C70", Offset = "0x9B7C70", VA = "0x9B7C70")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x77946C", Offset = "0x77946C")]
	public static IEnumerator<float> Append(this IEnumerator<float> coroutine, Action onDone)
	{
		return null;
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x9B7CE8", Offset = "0x9B7CE8", VA = "0x9B7CE8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7794DC", Offset = "0x7794DC")]
	public static IEnumerator<float> Prepend(this IEnumerator<float> coroutine, IEnumerator<float> lastCoroutine)
	{
		return null;
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x9B7D60", Offset = "0x9B7D60", VA = "0x9B7D60")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x77954C", Offset = "0x77954C")]
	public static IEnumerator<float> Prepend(this IEnumerator<float> coroutine, Action onStart)
	{
		return null;
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x9B7DD8", Offset = "0x9B7DD8", VA = "0x9B7DD8")]
	public static IEnumerator<float> Superimpose(this IEnumerator<float> coroutineA, IEnumerator<float> coroutineB)
	{
		return null;
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x9B80C0", Offset = "0x9B80C0", VA = "0x9B80C0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7795CC", Offset = "0x7795CC")]
	public static IEnumerator<float> Superimpose(this IEnumerator<float> coroutineA, IEnumerator<float> coroutineB, Timing instance)
	{
		return null;
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x9B8140", Offset = "0x9B8140", VA = "0x9B8140")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x77963C", Offset = "0x77963C")]
	public static IEnumerator<float> Hijack(this IEnumerator<float> coroutine, Func<float, float> newReturn)
	{
		return null;
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x9B81B8", Offset = "0x9B81B8", VA = "0x9B81B8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7796AC", Offset = "0x7796AC")]
	public static IEnumerator<float> RerouteExceptions(this IEnumerator<float> coroutine, Action<Exception> exceptionHandler)
	{
		return null;
	}
}
namespace MEC
{
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
			[Address(RVA = "0x19A8BD8", Offset = "0x19A8BD8", VA = "0x19A8BD8", Slot = "4")]
			public bool Equals(ProcessIndex other)
			{
				return default(bool);
			}

			[Token(Token = "0x6000199")]
			[Address(RVA = "0x19A8C00", Offset = "0x19A8C00", VA = "0x19A8C00", Slot = "0")]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x600019A")]
			[Address(RVA = "0x19A8C94", Offset = "0x19A8C94", VA = "0x19A8C94")]
			public static bool operator ==(ProcessIndex a, ProcessIndex b)
			{
				return default(bool);
			}

			[Token(Token = "0x600019B")]
			[Address(RVA = "0x19A8CB4", Offset = "0x19A8CB4", VA = "0x19A8CB4")]
			public static bool operator !=(ProcessIndex a, ProcessIndex b)
			{
				return default(bool);
			}

			[Token(Token = "0x600019C")]
			[Address(RVA = "0x19A8CD4", Offset = "0x19A8CD4", VA = "0x19A8CD4", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Token(Token = "0x2000019")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7784D4", Offset = "0x7784D4")]
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
				[Address(RVA = "0x19A7C74", Offset = "0x19A7C74", VA = "0x19A7C74", Slot = "4")]
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
				[Address(RVA = "0x19A7CBC", Offset = "0x19A7CBC", VA = "0x19A7CBC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600019D")]
			[Address(RVA = "0x19A7BB4", Offset = "0x19A7BB4", VA = "0x19A7BB4")]
			[DebuggerHidden]
			public <_EOFPumpWatcher>d__132(int <>1__state)
			{
			}

			[Token(Token = "0x600019E")]
			[Address(RVA = "0x19A7BE0", Offset = "0x19A7BE0", VA = "0x19A7BE0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600019F")]
			[Address(RVA = "0x19A7BE4", Offset = "0x19A7BE4", VA = "0x19A7BE4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001A1")]
			[Address(RVA = "0x19A7C7C", Offset = "0x19A7C7C", VA = "0x19A7C7C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200001A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7784E4", Offset = "0x7784E4")]
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
				[Address(RVA = "0x19A7B64", Offset = "0x19A7B64", VA = "0x19A7B64", Slot = "4")]
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
				[Address(RVA = "0x19A7BAC", Offset = "0x19A7BAC", VA = "0x19A7BAC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001A3")]
			[Address(RVA = "0x19A7294", Offset = "0x19A7294", VA = "0x19A7294")]
			[DebuggerHidden]
			public <_EOFPump>d__133(int <>1__state)
			{
			}

			[Token(Token = "0x60001A4")]
			[Address(RVA = "0x19A72C0", Offset = "0x19A72C0", VA = "0x19A72C0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001A5")]
			[Address(RVA = "0x19A72C4", Offset = "0x19A72C4", VA = "0x19A72C4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001A7")]
			[Address(RVA = "0x19A7B6C", Offset = "0x19A7B6C", VA = "0x19A7B6C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200001B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7784F4", Offset = "0x7784F4")]
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
				[Address(RVA = "0x19A82FC", Offset = "0x19A82FC", VA = "0x19A82FC", Slot = "4")]
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
				[Address(RVA = "0x19A8344", Offset = "0x19A8344", VA = "0x19A8344", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001A9")]
			[Address(RVA = "0x19A7F38", Offset = "0x19A7F38", VA = "0x19A7F38")]
			[DebuggerHidden]
			public <_StartWhenDone>d__275(int <>1__state)
			{
			}

			[Token(Token = "0x60001AA")]
			[Address(RVA = "0x19A7F64", Offset = "0x19A7F64", VA = "0x19A7F64", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001AB")]
			[Address(RVA = "0x19A7FBC", Offset = "0x19A7FBC", VA = "0x19A7FBC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001AC")]
			[Address(RVA = "0x19A7F90", Offset = "0x19A7F90", VA = "0x19A7F90")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60001AE")]
			[Address(RVA = "0x19A8304", Offset = "0x19A8304", VA = "0x19A8304", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200001C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778504", Offset = "0x778504")]
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
				[Address(RVA = "0x19A8514", Offset = "0x19A8514", VA = "0x19A8514", Slot = "4")]
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
				[Address(RVA = "0x19A855C", Offset = "0x19A855C", VA = "0x19A855C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001B0")]
			[Address(RVA = "0x19A83A4", Offset = "0x19A83A4", VA = "0x19A83A4")]
			[DebuggerHidden]
			public <_StartWhenDone>d__280(int <>1__state)
			{
			}

			[Token(Token = "0x60001B1")]
			[Address(RVA = "0x19A83D0", Offset = "0x19A83D0", VA = "0x19A83D0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001B2")]
			[Address(RVA = "0x19A83D4", Offset = "0x19A83D4", VA = "0x19A83D4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001B4")]
			[Address(RVA = "0x19A851C", Offset = "0x19A851C", VA = "0x19A851C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200001D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778514", Offset = "0x778514")]
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
				[Address(RVA = "0x19A8730", Offset = "0x19A8730", VA = "0x19A8730", Slot = "4")]
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
				[Address(RVA = "0x19A8778", Offset = "0x19A8778", VA = "0x19A8778", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001B6")]
			[Address(RVA = "0x19A85BC", Offset = "0x19A85BC", VA = "0x19A85BC")]
			[DebuggerHidden]
			public <_StartWhenDone>d__282(int <>1__state)
			{
			}

			[Token(Token = "0x60001B7")]
			[Address(RVA = "0x19A85E8", Offset = "0x19A85E8", VA = "0x19A85E8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001B8")]
			[Address(RVA = "0x19A85EC", Offset = "0x19A85EC", VA = "0x19A85EC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001BA")]
			[Address(RVA = "0x19A8738", Offset = "0x19A8738", VA = "0x19A8738", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200001E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778524", Offset = "0x778524")]
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
				[Address(RVA = "0x19A896C", Offset = "0x19A896C", VA = "0x19A896C", Slot = "4")]
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
				[Address(RVA = "0x19A89B4", Offset = "0x19A89B4", VA = "0x19A89B4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001BC")]
			[Address(RVA = "0x19A87D8", Offset = "0x19A87D8", VA = "0x19A87D8")]
			[DebuggerHidden]
			public <_StartWhenDone>d__287(int <>1__state)
			{
			}

			[Token(Token = "0x60001BD")]
			[Address(RVA = "0x19A8804", Offset = "0x19A8804", VA = "0x19A8804", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001BE")]
			[Address(RVA = "0x19A8808", Offset = "0x19A8808", VA = "0x19A8808", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001C0")]
			[Address(RVA = "0x19A8974", Offset = "0x19A8974", VA = "0x19A8974", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200001F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778534", Offset = "0x778534")]
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
				[Address(RVA = "0x19A7E90", Offset = "0x19A7E90", VA = "0x19A7E90", Slot = "4")]
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
				[Address(RVA = "0x19A7ED8", Offset = "0x19A7ED8", VA = "0x19A7ED8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001C2")]
			[Address(RVA = "0x19A7D1C", Offset = "0x19A7D1C", VA = "0x19A7D1C")]
			[DebuggerHidden]
			public <_InjectDelay>d__288(int <>1__state)
			{
			}

			[Token(Token = "0x60001C3")]
			[Address(RVA = "0x19A7D48", Offset = "0x19A7D48", VA = "0x19A7D48", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001C4")]
			[Address(RVA = "0x19A7D4C", Offset = "0x19A7D4C", VA = "0x19A7D4C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001C6")]
			[Address(RVA = "0x19A7E98", Offset = "0x19A7E98", VA = "0x19A7E98", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000020")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778544", Offset = "0x778544")]
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
				[Address(RVA = "0x19A71EC", Offset = "0x19A71EC", VA = "0x19A71EC", Slot = "4")]
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
				[Address(RVA = "0x19A7234", Offset = "0x19A7234", VA = "0x19A7234", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001C8")]
			[Address(RVA = "0x19A70E8", Offset = "0x19A70E8", VA = "0x19A70E8")]
			[DebuggerHidden]
			public <_DelayedCall>d__313(int <>1__state)
			{
			}

			[Token(Token = "0x60001C9")]
			[Address(RVA = "0x19A7114", Offset = "0x19A7114", VA = "0x19A7114", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001CA")]
			[Address(RVA = "0x19A7118", Offset = "0x19A7118", VA = "0x19A7118", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001CC")]
			[Address(RVA = "0x19A71F4", Offset = "0x19A71F4", VA = "0x19A71F4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000021")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778554", Offset = "0x778554")]
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
				[Address(RVA = "0x19A8B30", Offset = "0x19A8B30", VA = "0x19A8B30", Slot = "4")]
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
				[Address(RVA = "0x19A8B78", Offset = "0x19A8B78", VA = "0x19A8B78", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001CE")]
			[Address(RVA = "0x19A8A14", Offset = "0x19A8A14", VA = "0x19A8A14")]
			[DebuggerHidden]
			public <_WatchCall>d__334(int <>1__state)
			{
			}

			[Token(Token = "0x60001CF")]
			[Address(RVA = "0x19A8A40", Offset = "0x19A8A40", VA = "0x19A8A40", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001D0")]
			[Address(RVA = "0x19A8A44", Offset = "0x19A8A44", VA = "0x19A8A44", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001D2")]
			[Address(RVA = "0x19A8B38", Offset = "0x19A8B38", VA = "0x19A8B38", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000022")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778564", Offset = "0x778564")]
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
				[Address(RVA = "0x19A7040", Offset = "0x19A7040", VA = "0x19A7040", Slot = "4")]
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
				[Address(RVA = "0x19A7088", Offset = "0x19A7088", VA = "0x19A7088", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001D4")]
			[Address(RVA = "0x19A6ED4", Offset = "0x19A6ED4", VA = "0x19A6ED4")]
			[DebuggerHidden]
			public <_CallContinuously>d__335(int <>1__state)
			{
			}

			[Token(Token = "0x60001D5")]
			[Address(RVA = "0x19A6F00", Offset = "0x19A6F00", VA = "0x19A6F00", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001D6")]
			[Address(RVA = "0x19A6F04", Offset = "0x19A6F04", VA = "0x19A6F04", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001D8")]
			[Address(RVA = "0x19A7048", Offset = "0x19A7048", VA = "0x19A7048", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000023")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778574", Offset = "0x778574")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778584", Offset = "0x778584")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x778B1C", Offset = "0x778B1C")]
		public float TimeBetweenSlowUpdateCalls;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x778B54", Offset = "0x778B54")]
		public DebugInfoType ProfilerDebugAmount;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x778B8C", Offset = "0x778B8C")]
		public bool AutoTriggerManualTimeframe;

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x778BC4", Offset = "0x778BC4")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x778BC4", Offset = "0x778BC4")]
		public int UpdateCoroutines;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x778C14", Offset = "0x778C14")]
		public int FixedUpdateCoroutines;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x778C4C", Offset = "0x778C4C")]
		public int LateUpdateCoroutines;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x778C84", Offset = "0x778C84")]
		public int SlowUpdateCoroutines;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x778CBC", Offset = "0x778CBC")]
		public int RealtimeUpdateCoroutines;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x778CF4", Offset = "0x778CF4")]
		public int EditorUpdateCoroutines;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x778D2C", Offset = "0x778D2C")]
		public int EditorSlowUpdateCoroutines;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x778D64", Offset = "0x778D64")]
		public int EndOfFrameCoroutines;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x778D9C", Offset = "0x778D9C")]
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

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778DE4", Offset = "0x778DE4")]
		private static Thread <MainThread>k__BackingField;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778DF4", Offset = "0x778DF4")]
		private CoroutineHandle <currentCoroutine>k__BackingField;

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
			[Address(RVA = "0x9B8230", Offset = "0x9B8230", VA = "0x9B8230")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700002A")]
		public static float DeltaTime
		{
			[Token(Token = "0x600008F")]
			[Address(RVA = "0x9B8298", Offset = "0x9B8298", VA = "0x9B8298")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700002B")]
		public static Thread MainThread
		{
			[Token(Token = "0x6000092")]
			[Address(RVA = "0x9B84F0", Offset = "0x9B84F0", VA = "0x9B84F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x779D7C", Offset = "0x779D7C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000093")]
			[Address(RVA = "0x9B8554", Offset = "0x9B8554", VA = "0x9B8554")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x779D8C", Offset = "0x779D8C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700002C")]
		public static CoroutineHandle CurrentCoroutine
		{
			[Token(Token = "0x6000094")]
			[Address(RVA = "0x9B85BC", Offset = "0x9B85BC", VA = "0x9B85BC")]
			get
			{
				return default(CoroutineHandle);
			}
		}

		[Token(Token = "0x1700002D")]
		public CoroutineHandle currentCoroutine
		{
			[Token(Token = "0x6000095")]
			[Address(RVA = "0x9B8760", Offset = "0x9B8760", VA = "0x9B8760")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x779D9C", Offset = "0x779D9C")]
			get
			{
				return default(CoroutineHandle);
			}
			[Token(Token = "0x6000096")]
			[Address(RVA = "0x9B8768", Offset = "0x9B8768", VA = "0x9B8768")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x779DAC", Offset = "0x779DAC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700002E")]
		public static Timing Instance
		{
			[Token(Token = "0x6000097")]
			[Address(RVA = "0x9B7E50", Offset = "0x9B7E50", VA = "0x9B7E50")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000098")]
			[Address(RVA = "0x9B89F8", Offset = "0x9B89F8", VA = "0x9B89F8")]
			set
			{
			}
		}

		[Token(Token = "0x14000001")]
		public static event Action OnPreExecute
		{
			[Token(Token = "0x6000090")]
			[Address(RVA = "0x9B8300", Offset = "0x9B8300", VA = "0x9B8300")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x779D5C", Offset = "0x779D5C")]
			add
			{
			}
			[Token(Token = "0x6000091")]
			[Address(RVA = "0x9B83F8", Offset = "0x9B83F8", VA = "0x9B83F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x779D6C", Offset = "0x779D6C")]
			remove
			{
			}
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x9B8A60", Offset = "0x9B8A60", VA = "0x9B8A60")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x9B8B38", Offset = "0x9B8B38", VA = "0x9B8B38")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x9B8FA0", Offset = "0x9B8FA0", VA = "0x9B8FA0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x9B8770", Offset = "0x9B8770", VA = "0x9B8770")]
		private void InitializeInstanceID()
		{
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x9B9070", Offset = "0x9B9070", VA = "0x9B9070")]
		private void Update()
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x9BCBF8", Offset = "0x9BCBF8", VA = "0x9BCBF8")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x9BD408", Offset = "0x9BD408", VA = "0x9BD408")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x9BAB44", Offset = "0x9BAB44", VA = "0x9BAB44")]
		public void TriggerManualTimeframeUpdate()
		{
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x9B8CA0", Offset = "0x9B8CA0", VA = "0x9B8CA0")]
		private bool OnEditorStart()
		{
			return default(bool);
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x9B8CA8", Offset = "0x9B8CA8", VA = "0x9B8CA8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x779DBC", Offset = "0x779DBC")]
		private IEnumerator<float> _EOFPumpWatcher()
		{
			return null;
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x9BDC18", Offset = "0x9BDC18", VA = "0x9BDC18")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x779E1C", Offset = "0x779E1C")]
		private IEnumerator _EOFPump()
		{
			return null;
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x9BB378", Offset = "0x9BB378", VA = "0x9BB378")]
		private void RemoveUnused()
		{
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x9BE1F8", Offset = "0x9BE1F8", VA = "0x9BE1F8")]
		private void EditorRemoveUnused()
		{
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x9B38B8", Offset = "0x9B38B8", VA = "0x9B38B8")]
		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x9B39F0", Offset = "0x9B39F0", VA = "0x9B39F0")]
		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, GameObject gameObj)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x9B3BE4", Offset = "0x9B3BE4", VA = "0x9B3BE4")]
		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, int layer)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x9B3D28", Offset = "0x9B3D28", VA = "0x9B3D28")]
		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x9B3E74", Offset = "0x9B3E74", VA = "0x9B3E74")]
		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, GameObject gameObj, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x9B407C", Offset = "0x9B407C", VA = "0x9B407C")]
		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, int layer, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x9B41C4", Offset = "0x9B41C4", VA = "0x9B41C4")]
		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, Segment segment)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x9B4310", Offset = "0x9B4310", VA = "0x9B4310")]
		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, Segment segment, GameObject gameObj)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x9B4518", Offset = "0x9B4518", VA = "0x9B4518")]
		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, Segment segment, int layer)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x9B4668", Offset = "0x9B4668", VA = "0x9B4668")]
		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, Segment segment, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x9B47C8", Offset = "0x9B47C8", VA = "0x9B47C8")]
		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, Segment segment, GameObject gameObj, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x9B49E4", Offset = "0x9B49E4", VA = "0x9B49E4")]
		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, Segment segment, int layer, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x9C14F4", Offset = "0x9C14F4", VA = "0x9C14F4")]
		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x9C1560", Offset = "0x9C1560", VA = "0x9C1560")]
		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, GameObject gameObj)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x9C1684", Offset = "0x9C1684", VA = "0x9C1684")]
		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, int layer)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x9C16FC", Offset = "0x9C16FC", VA = "0x9C16FC")]
		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x9C1774", Offset = "0x9C1774", VA = "0x9C1774")]
		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, GameObject gameObj, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x9C189C", Offset = "0x9C189C", VA = "0x9C189C")]
		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, int layer, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x9A6884", Offset = "0x9A6884", VA = "0x9A6884")]
		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, Segment segment)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x9C1918", Offset = "0x9C1918", VA = "0x9C1918")]
		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, Segment segment, GameObject gameObj)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x9C1A40", Offset = "0x9C1A40", VA = "0x9C1A40")]
		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, Segment segment, int layer)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x9C1ABC", Offset = "0x9C1ABC", VA = "0x9C1ABC")]
		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, Segment segment, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x9C1B38", Offset = "0x9C1B38", VA = "0x9C1B38")]
		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, Segment segment, GameObject gameObj, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x9C1C6C", Offset = "0x9C1C6C", VA = "0x9C1C6C")]
		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, Segment segment, int layer, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x9B4B40", Offset = "0x9B4B40", VA = "0x9B4B40")]
		public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, CoroutineHandle handle, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x9C2090", Offset = "0x9C2090", VA = "0x9C2090")]
		public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, GameObject gameObj, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x9B4E20", Offset = "0x9B4E20", VA = "0x9B4E20")]
		public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, int layer, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x9B5250", Offset = "0x9B5250", VA = "0x9B5250")]
		public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x9C2D60", Offset = "0x9C2D60", VA = "0x9C2D60")]
		public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, GameObject gameObj, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x9B56A0", Offset = "0x9B56A0", VA = "0x9B56A0")]
		public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, int layer, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x9B5D34", Offset = "0x9B5D34", VA = "0x9B5D34")]
		public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, CoroutineHandle handle, Segment segment, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x9C3080", Offset = "0x9C3080", VA = "0x9C3080")]
		public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, Segment segment, GameObject gameObj, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x9B602C", Offset = "0x9B602C", VA = "0x9B602C")]
		public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, Segment segment, int layer, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x9B6488", Offset = "0x9B6488", VA = "0x9B6488")]
		public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, Segment segment, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x9C319C", Offset = "0x9C319C", VA = "0x9C319C")]
		public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, Segment segment, GameObject gameObj, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x9B68F0", Offset = "0x9B68F0", VA = "0x9B68F0")]
		public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, Segment segment, int layer, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x9C32C8", Offset = "0x9C32C8", VA = "0x9C32C8")]
		public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, CoroutineHandle handle, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x9C3740", Offset = "0x9C3740", VA = "0x9C3740")]
		public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, GameObject gameObj, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x9C3808", Offset = "0x9C3808", VA = "0x9C3808")]
		public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, int layer, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x9B8D14", Offset = "0x9B8D14", VA = "0x9B8D14")]
		public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x9C4024", Offset = "0x9C4024", VA = "0x9C4024")]
		public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, GameObject gameObj, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x9C40FC", Offset = "0x9C40FC", VA = "0x9C40FC")]
		public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, int layer, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x9C4D4C", Offset = "0x9C4D4C", VA = "0x9C4D4C")]
		public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, Segment segment, GameObject gameObj, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x9C4E20", Offset = "0x9C4E20", VA = "0x9C4E20")]
		public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, Segment segment, int layer, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x9C50B8", Offset = "0x9C50B8", VA = "0x9C50B8")]
		public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, Segment segment, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x9C5350", Offset = "0x9C5350", VA = "0x9C5350")]
		public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, Segment segment, GameObject gameObj, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x9C543C", Offset = "0x9C543C", VA = "0x9C543C")]
		public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, Segment segment, int layer, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x9BEA38", Offset = "0x9BEA38", VA = "0x9BEA38")]
		private CoroutineHandle RunCoroutineInternal(IEnumerator<float> coroutine, Segment segment, int layer, bool layerHasValue, string tag, CoroutineHandle handle, bool prewarm)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x9C5B44", Offset = "0x9C5B44", VA = "0x9C5B44")]
		public static int KillCoroutines()
		{
			return default(int);
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x9C5C28", Offset = "0x9C5C28", VA = "0x9C5C28")]
		public int KillCoroutinesOnInstance()
		{
			return default(int);
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x9A60C8", Offset = "0x9A60C8", VA = "0x9A60C8")]
		public static int KillCoroutines(CoroutineHandle handle)
		{
			return default(int);
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x9C6038", Offset = "0x9C6038", VA = "0x9C6038")]
		public static int KillCoroutines(params CoroutineHandle[] handles)
		{
			return default(int);
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x9BA904", Offset = "0x9BA904", VA = "0x9BA904")]
		public int KillCoroutinesOnInstance(CoroutineHandle handle)
		{
			return default(int);
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x9C6238", Offset = "0x9C6238", VA = "0x9C6238")]
		public static int KillCoroutines(GameObject gameObj)
		{
			return default(int);
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x9C6344", Offset = "0x9C6344", VA = "0x9C6344")]
		public int KillCoroutinesOnInstance(GameObject gameObj)
		{
			return default(int);
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x9C2198", Offset = "0x9C2198", VA = "0x9C2198")]
		public static int KillCoroutines(int layer)
		{
			return default(int);
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x9C3A94", Offset = "0x9C3A94", VA = "0x9C3A94")]
		public int KillCoroutinesOnInstance(int layer)
		{
			return default(int);
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x9C2C68", Offset = "0x9C2C68", VA = "0x9C2C68")]
		public static int KillCoroutines(string tag)
		{
			return default(int);
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x9C3D44", Offset = "0x9C3D44", VA = "0x9C3D44")]
		public int KillCoroutinesOnInstance(string tag)
		{
			return default(int);
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x9C6488", Offset = "0x9C6488", VA = "0x9C6488")]
		public static int KillCoroutines(GameObject gameObj, string tag)
		{
			return default(int);
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x9C659C", Offset = "0x9C659C", VA = "0x9C659C")]
		public int KillCoroutinesOnInstance(GameObject gameObj, string tag)
		{
			return default(int);
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x9C2E80", Offset = "0x9C2E80", VA = "0x9C2E80")]
		public static int KillCoroutines(int layer, string tag)
		{
			return default(int);
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x9C450C", Offset = "0x9C450C", VA = "0x9C450C")]
		public int KillCoroutinesOnInstance(int layer, string tag)
		{
			return default(int);
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x9A6760", Offset = "0x9A6760", VA = "0x9A6760")]
		public static Timing GetInstance(byte ID)
		{
			return null;
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x9C65DC", Offset = "0x9C65DC", VA = "0x9C65DC")]
		public static float WaitForSeconds(float waitTime)
		{
			return default(float);
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x9C6664", Offset = "0x9C6664", VA = "0x9C6664")]
		public float WaitForSecondsOnInstance(float waitTime)
		{
			return default(float);
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x9BA60C", Offset = "0x9BA60C", VA = "0x9BA60C")]
		private bool UpdateTimeValues(Segment segment)
		{
			return default(bool);
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x9C66A8", Offset = "0x9C66A8", VA = "0x9C66A8")]
		private float GetSegmentTime(Segment segment)
		{
			return default(float);
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x9C6794", Offset = "0x9C6794", VA = "0x9C6794")]
		public static int PauseCoroutines()
		{
			return default(int);
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x9C6878", Offset = "0x9C6878", VA = "0x9C6878")]
		public int PauseCoroutinesOnInstance()
		{
			return default(int);
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x9C7B88", Offset = "0x9C7B88", VA = "0x9C7B88")]
		public int PauseCoroutinesOnInstance(CoroutineHandle handle)
		{
			return default(int);
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x9A6434", Offset = "0x9A6434", VA = "0x9A6434")]
		public static int PauseCoroutines(CoroutineHandle handle)
		{
			return default(int);
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x9C8B84", Offset = "0x9C8B84", VA = "0x9C8B84")]
		public static int PauseCoroutines(params CoroutineHandle[] handles)
		{
			return default(int);
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x9C8D14", Offset = "0x9C8D14", VA = "0x9C8D14")]
		public static int PauseCoroutines(GameObject gameObj)
		{
			return default(int);
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x9C8E0C", Offset = "0x9C8E0C", VA = "0x9C8E0C")]
		public int PauseCoroutinesOnInstance(GameObject gameObj)
		{
			return default(int);
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x9C91F8", Offset = "0x9C91F8", VA = "0x9C91F8")]
		public static int PauseCoroutines(int layer)
		{
			return default(int);
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x9C8EB8", Offset = "0x9C8EB8", VA = "0x9C8EB8")]
		public int PauseCoroutinesOnInstance(int layer)
		{
			return default(int);
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x9C92F0", Offset = "0x9C92F0", VA = "0x9C92F0")]
		public static int PauseCoroutines(string tag)
		{
			return default(int);
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x9C93E8", Offset = "0x9C93E8", VA = "0x9C93E8")]
		public int PauseCoroutinesOnInstance(string tag)
		{
			return default(int);
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x9C972C", Offset = "0x9C972C", VA = "0x9C972C")]
		public static int PauseCoroutines(GameObject gameObj, string tag)
		{
			return default(int);
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x9C9C78", Offset = "0x9C9C78", VA = "0x9C9C78")]
		public int PauseCoroutinesOnInstance(GameObject gameObj, string tag)
		{
			return default(int);
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x9C9D2C", Offset = "0x9C9D2C", VA = "0x9C9D2C")]
		public static int PauseCoroutines(int layer, string tag)
		{
			return default(int);
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x9C9840", Offset = "0x9C9840", VA = "0x9C9840")]
		public int PauseCoroutinesOnInstance(int layer, string tag)
		{
			return default(int);
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x9C9E2C", Offset = "0x9C9E2C", VA = "0x9C9E2C")]
		public static int ResumeCoroutines()
		{
			return default(int);
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x9C9F10", Offset = "0x9C9F10", VA = "0x9C9F10")]
		public int ResumeCoroutinesOnInstance()
		{
			return default(int);
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x9A652C", Offset = "0x9A652C", VA = "0x9A652C")]
		public static int ResumeCoroutines(CoroutineHandle handle)
		{
			return default(int);
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x9CA4AC", Offset = "0x9CA4AC", VA = "0x9CA4AC")]
		public static int ResumeCoroutines(params CoroutineHandle[] handles)
		{
			return default(int);
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x9C3488", Offset = "0x9C3488", VA = "0x9C3488")]
		public int ResumeCoroutinesOnInstance(CoroutineHandle handle)
		{
			return default(int);
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x9C2290", Offset = "0x9C2290", VA = "0x9C2290")]
		public int ResumeCoroutinesOnInstance(IEnumerable<CoroutineHandle> handles)
		{
			return default(int);
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x9CA63C", Offset = "0x9CA63C", VA = "0x9CA63C")]
		public static int ResumeCoroutines(GameObject gameObj)
		{
			return default(int);
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x9CAA84", Offset = "0x9CAA84", VA = "0x9CAA84")]
		public int ResumeCoroutinesOnInstance(GameObject gameObj)
		{
			return default(int);
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x9CAB30", Offset = "0x9CAB30", VA = "0x9CAB30")]
		public static int ResumeCoroutines(int layer)
		{
			return default(int);
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x9CA748", Offset = "0x9CA748", VA = "0x9CA748")]
		public int ResumeCoroutinesOnInstance(int layer)
		{
			return default(int);
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x9CAC28", Offset = "0x9CAC28", VA = "0x9CAC28")]
		public static int ResumeCoroutines(string tag)
		{
			return default(int);
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x9CAD20", Offset = "0x9CAD20", VA = "0x9CAD20")]
		public int ResumeCoroutinesOnInstance(string tag)
		{
			return default(int);
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x9CB060", Offset = "0x9CB060", VA = "0x9CB060")]
		public static int ResumeCoroutines(GameObject gameObj, string tag)
		{
			return default(int);
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x9CB174", Offset = "0x9CB174", VA = "0x9CB174")]
		public int ResumeCoroutinesOnInstance(GameObject gameObj, string tag)
		{
			return default(int);
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x9C2F80", Offset = "0x9C2F80", VA = "0x9C2F80")]
		public static int ResumeCoroutines(int layer, string tag)
		{
			return default(int);
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x9C4960", Offset = "0x9C4960", VA = "0x9C4960")]
		public int ResumeCoroutinesOnInstance(int layer, string tag)
		{
			return default(int);
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x9A4EEC", Offset = "0x9A4EEC", VA = "0x9A4EEC")]
		public static string GetTag(CoroutineHandle handle)
		{
			return null;
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x9A5038", Offset = "0x9A5038", VA = "0x9A5038")]
		public static int? GetLayer(CoroutineHandle handle)
		{
			return null;
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x9A51B4", Offset = "0x9A51B4", VA = "0x9A51B4")]
		public static string GetDebugName(CoroutineHandle handle)
		{
			return null;
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x9A5A10", Offset = "0x9A5A10", VA = "0x9A5A10")]
		public static Segment GetSegment(CoroutineHandle handle)
		{
			return default(Segment);
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x9A5410", Offset = "0x9A5410", VA = "0x9A5410")]
		public static bool SetTag(CoroutineHandle handle, string newTag, bool overwriteExisting = true)
		{
			return default(bool);
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x9A5824", Offset = "0x9A5824", VA = "0x9A5824")]
		public static bool SetLayer(CoroutineHandle handle, int newLayer, bool overwriteExisting = true)
		{
			return default(bool);
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x9A5B9C", Offset = "0x9A5B9C", VA = "0x9A5B9C")]
		public static bool SetSegment(CoroutineHandle handle, Segment newSegment)
		{
			return default(bool);
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x9CC5C4", Offset = "0x9CC5C4", VA = "0x9CC5C4")]
		public static bool RemoveTag(CoroutineHandle handle)
		{
			return default(bool);
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x9A56EC", Offset = "0x9A56EC", VA = "0x9A56EC")]
		public static bool RemoveLayer(CoroutineHandle handle)
		{
			return default(bool);
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x9A5F18", Offset = "0x9A5F18", VA = "0x9A5F18")]
		public static bool IsRunning(CoroutineHandle handle)
		{
			return default(bool);
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x9A6244", Offset = "0x9A6244", VA = "0x9A6244")]
		public static bool IsAliveAndPaused(CoroutineHandle handle)
		{
			return default(bool);
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x9C584C", Offset = "0x9C584C", VA = "0x9C584C")]
		private void AddTagOnInstance(string tag, CoroutineHandle handle)
		{
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x9C59C8", Offset = "0x9C59C8", VA = "0x9C59C8")]
		private void AddLayerOnInstance(int layer, CoroutineHandle handle)
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x9CB2F0", Offset = "0x9CB2F0", VA = "0x9CB2F0")]
		private void RemoveTagOnInstance(CoroutineHandle handle)
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x9CB488", Offset = "0x9CB488", VA = "0x9CB488")]
		private void RemoveLayerOnInstance(CoroutineHandle handle)
		{
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x9BDF3C", Offset = "0x9BDF3C", VA = "0x9BDF3C")]
		private void RemoveGraffiti(CoroutineHandle handle)
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x9CB620", Offset = "0x9CB620", VA = "0x9CB620")]
		private IEnumerator<float> CoindexExtract(ProcessIndex coindex)
		{
			return null;
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x9BDC84", Offset = "0x9BDC84", VA = "0x9BDC84")]
		private bool CoindexIsNull(ProcessIndex coindex)
		{
			return default(bool);
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x9CB228", Offset = "0x9CB228", VA = "0x9CB228")]
		private IEnumerator<float> CoindexPeek(ProcessIndex coindex)
		{
			return null;
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x9C61C8", Offset = "0x9C61C8", VA = "0x9C61C8")]
		private bool Nullify(CoroutineHandle handle)
		{
			return default(bool);
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x9C637C", Offset = "0x9C637C", VA = "0x9C637C")]
		private bool Nullify(ProcessIndex coindex)
		{
			return default(bool);
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x9C7E44", Offset = "0x9C7E44", VA = "0x9C7E44")]
		private bool SetPause(ProcessIndex coindex, bool newPausedState)
		{
			return default(bool);
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x9CB884", Offset = "0x9CB884", VA = "0x9CB884")]
		private bool SetHeld(ProcessIndex coindex, bool newHeldState)
		{
			return default(bool);
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x9CC62C", Offset = "0x9CC62C", VA = "0x9CC62C")]
		private IEnumerator<float> CreateHold(ProcessIndex coindex, IEnumerator<float> coptr)
		{
			return null;
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x9CB7B8", Offset = "0x9CB7B8", VA = "0x9CB7B8")]
		private bool CoindexIsPaused(ProcessIndex coindex)
		{
			return default(bool);
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x9CB6EC", Offset = "0x9CB6EC", VA = "0x9CB6EC")]
		private bool CoindexIsHeld(ProcessIndex coindex)
		{
			return default(bool);
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x9CD2F0", Offset = "0x9CD2F0", VA = "0x9CD2F0")]
		private void CoindexReplace(ProcessIndex coindex, IEnumerator<float> replacement)
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x9B6F6C", Offset = "0x9B6F6C", VA = "0x9B6F6C")]
		public static float WaitUntilDone(IEnumerator<float> newCoroutine)
		{
			return default(float);
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x9B706C", Offset = "0x9B706C", VA = "0x9B706C")]
		public static float WaitUntilDone(IEnumerator<float> newCoroutine, string tag)
		{
			return default(float);
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x9B7174", Offset = "0x9B7174", VA = "0x9B7174")]
		public static float WaitUntilDone(IEnumerator<float> newCoroutine, int layer)
		{
			return default(float);
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x9B7284", Offset = "0x9B7284", VA = "0x9B7284")]
		public static float WaitUntilDone(IEnumerator<float> newCoroutine, int layer, string tag)
		{
			return default(float);
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x9B739C", Offset = "0x9B739C", VA = "0x9B739C")]
		public static float WaitUntilDone(IEnumerator<float> newCoroutine, Segment segment)
		{
			return default(float);
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x9B7490", Offset = "0x9B7490", VA = "0x9B7490")]
		public static float WaitUntilDone(IEnumerator<float> newCoroutine, Segment segment, string tag)
		{
			return default(float);
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x9B758C", Offset = "0x9B758C", VA = "0x9B758C")]
		public static float WaitUntilDone(IEnumerator<float> newCoroutine, Segment segment, int layer)
		{
			return default(float);
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x9B7698", Offset = "0x9B7698", VA = "0x9B7698")]
		public static float WaitUntilDone(IEnumerator<float> newCoroutine, Segment segment, int layer, string tag)
		{
			return default(float);
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x9CD734", Offset = "0x9CD734", VA = "0x9CD734")]
		public static float WaitUntilDone(CoroutineHandle otherCoroutine)
		{
			return default(float);
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x9CD3EC", Offset = "0x9CD3EC", VA = "0x9CD3EC")]
		public static float WaitUntilDone(CoroutineHandle otherCoroutine, bool warnOnIssue)
		{
			return default(float);
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x9C1CF4", Offset = "0x9C1CF4", VA = "0x9C1CF4")]
		public static void WaitForOtherHandles(CoroutineHandle handle, CoroutineHandle otherHandle, bool warnOnIssue = true)
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x9C2450", Offset = "0x9C2450", VA = "0x9C2450")]
		public static void WaitForOtherHandles(CoroutineHandle handle, IEnumerable<CoroutineHandle> otherHandles, bool warnOnIssue = true)
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x9CD81C", Offset = "0x9CD81C", VA = "0x9CD81C")]
		private void SwapToLast(CoroutineHandle firstHandle, CoroutineHandle lastHandle)
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x9CD798", Offset = "0x9CD798", VA = "0x9CD798")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x779E7C", Offset = "0x779E7C")]
		private IEnumerator<float> _StartWhenDone(CoroutineHandle handle, IEnumerator<float> proc)
		{
			return null;
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x9BDD54", Offset = "0x9BDD54", VA = "0x9BDD54")]
		private void CloseWaitingProcess(CoroutineHandle handle)
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x9CDC38", Offset = "0x9CDC38", VA = "0x9CDC38")]
		private bool HandleIsInWaitingList(CoroutineHandle handle)
		{
			return default(bool);
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x9CDD30", Offset = "0x9CDD30", VA = "0x9CDD30")]
		private static IEnumerator<float> ReturnTmpRefForRepFunc(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			return null;
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x9CDDAC", Offset = "0x9CDDAC", VA = "0x9CDDAC")]
		public static float WaitUntilDone(AsyncOperation operation)
		{
			return default(float);
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x9CDF60", Offset = "0x9CDF60", VA = "0x9CDF60")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x779EDC", Offset = "0x779EDC")]
		private static IEnumerator<float> _StartWhenDone(AsyncOperation operation, IEnumerator<float> pausedProc)
		{
			return null;
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x9CDFD8", Offset = "0x9CDFD8", VA = "0x9CDFD8")]
		public static float WaitUntilDone(CustomYieldInstruction operation)
		{
			return default(float);
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x9CE190", Offset = "0x9CE190", VA = "0x9CE190")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x779F3C", Offset = "0x779F3C")]
		private static IEnumerator<float> _StartWhenDone(CustomYieldInstruction operation, IEnumerator<float> pausedProc)
		{
			return null;
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x9CE208", Offset = "0x9CE208", VA = "0x9CE208")]
		public static float WaitUntilTrue(Func<bool> evaluatorFunc)
		{
			return default(float);
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x9CE304", Offset = "0x9CE304", VA = "0x9CE304")]
		private static IEnumerator<float> WaitUntilTrueHelper(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			return null;
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x9CE42C", Offset = "0x9CE42C", VA = "0x9CE42C")]
		public static float WaitUntilFalse(Func<bool> evaluatorFunc)
		{
			return default(float);
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x9CE528", Offset = "0x9CE528", VA = "0x9CE528")]
		private static IEnumerator<float> WaitUntilFalseHelper(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			return null;
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x9CE3A4", Offset = "0x9CE3A4", VA = "0x9CE3A4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x779F9C", Offset = "0x779F9C")]
		private static IEnumerator<float> _StartWhenDone(Func<bool> evaluatorFunc, bool continueOn, IEnumerator<float> pausedProc)
		{
			return null;
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x9C7AFC", Offset = "0x9C7AFC", VA = "0x9C7AFC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x779FFC", Offset = "0x779FFC")]
		private IEnumerator<float> _InjectDelay(IEnumerator<float> proc, float waitTime)
		{
			return null;
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x9CE5C8", Offset = "0x9CE5C8", VA = "0x9CE5C8")]
		public bool LockCoroutine(CoroutineHandle coroutine, CoroutineHandle key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x9CE7D0", Offset = "0x9CE7D0", VA = "0x9CE7D0")]
		public bool UnlockCoroutine(CoroutineHandle coroutine, CoroutineHandle key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x9CE9CC", Offset = "0x9CE9CC", VA = "0x9CE9CC")]
		public static int LinkCoroutines(CoroutineHandle master, CoroutineHandle slave)
		{
			return default(int);
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x9CEC70", Offset = "0x9CEC70", VA = "0x9CEC70")]
		public static int UnlinkCoroutines(CoroutineHandle master, CoroutineHandle slave, bool twoWay = false)
		{
			return default(int);
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x9CF008", Offset = "0x9CF008", VA = "0x9CF008")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x77A05C", Offset = "0x77A05C")]
		public static float GetMyHandle(Action<CoroutineHandle> reciever)
		{
			return default(float);
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x9CF0DC", Offset = "0x9CF0DC", VA = "0x9CF0DC")]
		private static IEnumerator<float> GetHandleHelper(IEnumerator<float> input, CoroutineHandle handle)
		{
			return null;
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x9CF1A8", Offset = "0x9CF1A8", VA = "0x9CF1A8")]
		public static float SwitchCoroutine(Segment newSegment)
		{
			return default(float);
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x9CF27C", Offset = "0x9CF27C", VA = "0x9CF27C")]
		private static IEnumerator<float> SwitchCoroutineRepS(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			return null;
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x9CF32C", Offset = "0x9CF32C", VA = "0x9CF32C")]
		public static float SwitchCoroutine(Segment newSegment, string newTag)
		{
			return default(float);
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x9CF414", Offset = "0x9CF414", VA = "0x9CF414")]
		private static IEnumerator<float> SwitchCoroutineRepST(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			return null;
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x9CF578", Offset = "0x9CF578", VA = "0x9CF578")]
		public static float SwitchCoroutine(Segment newSegment, int newLayer)
		{
			return default(float);
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x9CF660", Offset = "0x9CF660", VA = "0x9CF660")]
		private static IEnumerator<float> SwitchCoroutineRepSL(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			return null;
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x9CF73C", Offset = "0x9CF73C", VA = "0x9CF73C")]
		public static float SwitchCoroutine(Segment newSegment, int newLayer, string newTag)
		{
			return default(float);
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x9CF830", Offset = "0x9CF830", VA = "0x9CF830")]
		private static IEnumerator<float> SwitchCoroutineRepSLT(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			return null;
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x9CF9B4", Offset = "0x9CF9B4", VA = "0x9CF9B4")]
		public static float SwitchCoroutine(string newTag)
		{
			return default(float);
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x9CFA88", Offset = "0x9CFA88", VA = "0x9CFA88")]
		private static IEnumerator<float> SwitchCoroutineRepT(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			return null;
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x9CFBA0", Offset = "0x9CFBA0", VA = "0x9CFBA0")]
		public static float SwitchCoroutine(int newLayer)
		{
			return default(float);
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x9CFC74", Offset = "0x9CFC74", VA = "0x9CFC74")]
		private static IEnumerator<float> SwitchCoroutineRepL(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			return null;
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x9CFD10", Offset = "0x9CFD10", VA = "0x9CFD10")]
		public static float SwitchCoroutine(int newLayer, string newTag)
		{
			return default(float);
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x9CFDF8", Offset = "0x9CFDF8", VA = "0x9CFDF8")]
		private static IEnumerator<float> SwitchCoroutineRepLT(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			return null;
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x9CFF34", Offset = "0x9CFF34", VA = "0x9CFF34")]
		public static CoroutineHandle CallDelayed(float delay, Action action)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x9D005C", Offset = "0x9D005C", VA = "0x9D005C")]
		public CoroutineHandle CallDelayedOnInstance(float delay, Action action)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x9D009C", Offset = "0x9D009C", VA = "0x9D009C")]
		public static CoroutineHandle CallDelayed(float delay, Action action, GameObject gameObject)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x9D0144", Offset = "0x9D0144", VA = "0x9D0144")]
		public CoroutineHandle CallDelayedOnInstance(float delay, Action action, GameObject gameObject)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x9CFFCC", Offset = "0x9CFFCC", VA = "0x9CFFCC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x77A098", Offset = "0x77A098")]
		private IEnumerator<float> _DelayedCall(float delay, Action action, GameObject cancelWith)
		{
			return null;
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x9D0188", Offset = "0x9D0188", VA = "0x9D0188")]
		public static CoroutineHandle CallDelayed(float delay, Segment segment, Action action)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x9D0230", Offset = "0x9D0230", VA = "0x9D0230")]
		public CoroutineHandle CallDelayedOnInstance(float delay, Segment segment, Action action)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x9D027C", Offset = "0x9D027C", VA = "0x9D027C")]
		public static CoroutineHandle CallDelayed(float delay, Segment segment, Action action, GameObject gameObject)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x9D032C", Offset = "0x9D032C", VA = "0x9D032C")]
		public CoroutineHandle CallDelayedOnInstance(float delay, Segment segment, Action action, GameObject gameObject)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x9D0388", Offset = "0x9D0388", VA = "0x9D0388")]
		public static CoroutineHandle CallPeriodically(float timeframe, float period, Action action, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x9D05AC", Offset = "0x9D05AC", VA = "0x9D05AC")]
		public CoroutineHandle CallPeriodicallyOnInstance(float timeframe, float period, Action action, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x9D0644", Offset = "0x9D0644", VA = "0x9D0644")]
		public static CoroutineHandle CallPeriodically(float timeframe, float period, Action action, GameObject gameObject, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x9D0750", Offset = "0x9D0750", VA = "0x9D0750")]
		public CoroutineHandle CallPeriodicallyOnInstance(float timeframe, float period, Action action, GameObject gameObject, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x9D0854", Offset = "0x9D0854", VA = "0x9D0854")]
		public static CoroutineHandle CallPeriodically(float timeframe, float period, Action action, Segment timing, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x9D0954", Offset = "0x9D0954", VA = "0x9D0954")]
		public CoroutineHandle CallPeriodicallyOnInstance(float timeframe, float period, Action action, Segment timing, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x9D0A58", Offset = "0x9D0A58", VA = "0x9D0A58")]
		public static CoroutineHandle CallPeriodically(float timeframe, float period, Action action, Segment timing, GameObject gameObject, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x9D0B78", Offset = "0x9D0B78", VA = "0x9D0B78")]
		public CoroutineHandle CallPeriodicallyOnInstance(float timeframe, float period, Action action, Segment timing, GameObject gameObject, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x9D0C88", Offset = "0x9D0C88", VA = "0x9D0C88")]
		public static CoroutineHandle CallContinuously(float timeframe, Action action, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x9D0D84", Offset = "0x9D0D84", VA = "0x9D0D84")]
		public CoroutineHandle CallContinuouslyOnInstance(float timeframe, Action action, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x9D0E70", Offset = "0x9D0E70", VA = "0x9D0E70")]
		public static CoroutineHandle CallContinuously(float timeframe, Action action, GameObject gameObject, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x9D0F78", Offset = "0x9D0F78", VA = "0x9D0F78")]
		public CoroutineHandle CallContinuouslyOnInstance(float timeframe, Action action, GameObject gameObject, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x9D1078", Offset = "0x9D1078", VA = "0x9D1078")]
		public static CoroutineHandle CallContinuously(float timeframe, Action action, Segment timing, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x9D1180", Offset = "0x9D1180", VA = "0x9D1180")]
		public CoroutineHandle CallContinuouslyOnInstance(float timeframe, Action action, Segment timing, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x9D1280", Offset = "0x9D1280", VA = "0x9D1280")]
		public static CoroutineHandle CallContinuously(float timeframe, Action action, Segment timing, GameObject gameObject, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x9D139C", Offset = "0x9D139C", VA = "0x9D139C")]
		public CoroutineHandle CallContinuouslyOnInstance(float timeframe, Action action, Segment timing, GameObject gameObject, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x9D050C", Offset = "0x9D050C", VA = "0x9D050C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x77A0F8", Offset = "0x77A0F8")]
		private IEnumerator<float> _WatchCall(float timeframe, CoroutineHandle handle, GameObject gObject, Action onDone)
		{
			return null;
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x9D047C", Offset = "0x9D047C", VA = "0x9D047C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x77A158", Offset = "0x77A158")]
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
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x77A1B8", Offset = "0x77A1B8")]
		private IEnumerator<float> _WatchCall<T>(T reference, float timeframe, CoroutineHandle handle, GameObject gObject, Action<T> onDone)
		{
			return null;
		}

		[Token(Token = "0x600017F")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x77A218", Offset = "0x77A218")]
		private IEnumerator<float> _CallContinuously<T>(T reference, float period, Action<T> action, GameObject gObject)
		{
			return null;
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x9D14A8", Offset = "0x9D14A8", VA = "0x9D14A8")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x77A278", Offset = "0x77A278")]
		public new Coroutine StartCoroutine(IEnumerator routine)
		{
			return null;
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x9D14B0", Offset = "0x9D14B0", VA = "0x9D14B0")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x77A2B4", Offset = "0x77A2B4")]
		public new Coroutine StartCoroutine(string methodName, object value)
		{
			return null;
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x9D14B8", Offset = "0x9D14B8", VA = "0x9D14B8")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x77A2F0", Offset = "0x77A2F0")]
		public new Coroutine StartCoroutine(string methodName)
		{
			return null;
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x9D14C0", Offset = "0x9D14C0", VA = "0x9D14C0")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x77A32C", Offset = "0x77A32C")]
		public new Coroutine StartCoroutine_Auto(IEnumerator routine)
		{
			return null;
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x9D14C8", Offset = "0x9D14C8", VA = "0x9D14C8")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x77A368", Offset = "0x77A368")]
		public new void StopCoroutine(string methodName)
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x9D14CC", Offset = "0x9D14CC", VA = "0x9D14CC")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x77A3A4", Offset = "0x77A3A4")]
		public new void StopCoroutine(IEnumerator routine)
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x9D14D0", Offset = "0x9D14D0", VA = "0x9D14D0")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x77A3E0", Offset = "0x77A3E0")]
		public new void StopCoroutine(Coroutine routine)
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x9D14D4", Offset = "0x9D14D4", VA = "0x9D14D4")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x77A41C", Offset = "0x77A41C")]
		public new void StopAllCoroutines()
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x9D14D8", Offset = "0x9D14D8", VA = "0x9D14D8")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x77A458", Offset = "0x77A458")]
		public new static void Destroy(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x9D14DC", Offset = "0x9D14DC", VA = "0x9D14DC")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x77A494", Offset = "0x77A494")]
		public new static void Destroy(UnityEngine.Object obj, float f)
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x9D14E0", Offset = "0x9D14E0", VA = "0x9D14E0")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x77A4D0", Offset = "0x77A4D0")]
		public new static void DestroyObject(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x9D14E4", Offset = "0x9D14E4", VA = "0x9D14E4")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x77A50C", Offset = "0x77A50C")]
		public static void DestroyObject(UnityEngine.Object obj, float f)
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x9D14E8", Offset = "0x9D14E8", VA = "0x9D14E8")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x77A548", Offset = "0x77A548")]
		public new static void DestroyImmediate(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x9D14EC", Offset = "0x9D14EC", VA = "0x9D14EC")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x77A584", Offset = "0x77A584")]
		public new static void DestroyImmediate(UnityEngine.Object obj, bool b)
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x9D14F0", Offset = "0x9D14F0", VA = "0x9D14F0")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x77A5C0", Offset = "0x77A5C0")]
		public new static void Instantiate(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x9D14F4", Offset = "0x9D14F4", VA = "0x9D14F4")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x77A5FC", Offset = "0x77A5FC")]
		public new static void Instantiate(UnityEngine.Object original, Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000190")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x77A638", Offset = "0x77A638")]
		public new static void Instantiate<T>(T original) where T : UnityEngine.Object
		{
		}

		[Token(Token = "0x6000191")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x77A674", Offset = "0x77A674")]
		public new static T FindObjectOfType<T>() where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x9D14F8", Offset = "0x9D14F8", VA = "0x9D14F8")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x77A6B0", Offset = "0x77A6B0")]
		public new static UnityEngine.Object FindObjectOfType(Type t)
		{
			return null;
		}

		[Token(Token = "0x6000193")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x77A6EC", Offset = "0x77A6EC")]
		public new static T[] FindObjectsOfType<T>() where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x9D1500", Offset = "0x9D1500", VA = "0x9D1500")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x77A728", Offset = "0x77A728")]
		public new static UnityEngine.Object[] FindObjectsOfType(Type t)
		{
			return null;
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x9D1508", Offset = "0x9D1508", VA = "0x9D1508")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x77A764", Offset = "0x77A764")]
		public new static void print(object message)
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x9D150C", Offset = "0x9D150C", VA = "0x9D150C")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778594", Offset = "0x778594")]
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
				[Address(RVA = "0x19A0604", Offset = "0x19A0604", VA = "0x19A0604", Slot = "4")]
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
				[Address(RVA = "0x19A064C", Offset = "0x19A064C", VA = "0x19A064C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001FF")]
			[Address(RVA = "0x19A056C", Offset = "0x19A056C", VA = "0x19A056C")]
			[DebuggerHidden]
			public <_OnDestroy>d__32(int <>1__state)
			{
			}

			[Token(Token = "0x6000200")]
			[Address(RVA = "0x19A0598", Offset = "0x19A0598", VA = "0x19A0598", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000201")]
			[Address(RVA = "0x19A059C", Offset = "0x19A059C", VA = "0x19A059C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000203")]
			[Address(RVA = "0x19A060C", Offset = "0x19A060C", VA = "0x19A060C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200002A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7785A4", Offset = "0x7785A4")]
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
				[Address(RVA = "0x19A0860", Offset = "0x19A0860", VA = "0x19A0860", Slot = "4")]
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
				[Address(RVA = "0x19A08A8", Offset = "0x19A08A8", VA = "0x19A08A8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000205")]
			[Address(RVA = "0x19A06AC", Offset = "0x19A06AC", VA = "0x19A06AC")]
			[DebuggerHidden]
			public <_OnDestroy>d__33(int <>1__state)
			{
			}

			[Token(Token = "0x6000206")]
			[Address(RVA = "0x19A06D8", Offset = "0x19A06D8", VA = "0x19A06D8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000207")]
			[Address(RVA = "0x19A06DC", Offset = "0x19A06DC", VA = "0x19A06DC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000209")]
			[Address(RVA = "0x19A0868", Offset = "0x19A0868", VA = "0x19A0868", Slot = "8")]
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
			[Address(RVA = "0x9A49E4", Offset = "0x9A49E4", VA = "0x9A49E4")]
			get
			{
				return default(byte);
			}
		}

		[Token(Token = "0x17000048")]
		public string Tag
		{
			[Token(Token = "0x60001EF")]
			[Address(RVA = "0x9A5334", Offset = "0x9A5334", VA = "0x9A5334")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001F0")]
			[Address(RVA = "0x9A5398", Offset = "0x9A5398", VA = "0x9A5398")]
			set
			{
			}
		}

		[Token(Token = "0x17000049")]
		public int? Layer
		{
			[Token(Token = "0x60001F1")]
			[Address(RVA = "0x9A5598", Offset = "0x9A5598", VA = "0x9A5598")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001F2")]
			[Address(RVA = "0x9A55FC", Offset = "0x9A55FC", VA = "0x9A55FC")]
			set
			{
			}
		}

		[Token(Token = "0x1700004A")]
		public Segment Segment
		{
			[Token(Token = "0x60001F3")]
			[Address(RVA = "0x9A59AC", Offset = "0x9A59AC", VA = "0x9A59AC")]
			get
			{
				return default(Segment);
			}
			[Token(Token = "0x60001F4")]
			[Address(RVA = "0x9A5B28", Offset = "0x9A5B28", VA = "0x9A5B28")]
			set
			{
			}
		}

		[Token(Token = "0x1700004B")]
		public bool IsRunning
		{
			[Token(Token = "0x60001F5")]
			[Address(RVA = "0x9A5EB4", Offset = "0x9A5EB4", VA = "0x9A5EB4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001F6")]
			[Address(RVA = "0x9A6044", Offset = "0x9A6044", VA = "0x9A6044")]
			set
			{
			}
		}

		[Token(Token = "0x1700004C")]
		public bool IsAliveAndPaused
		{
			[Token(Token = "0x60001F7")]
			[Address(RVA = "0x9A61E0", Offset = "0x9A61E0", VA = "0x9A61E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001F8")]
			[Address(RVA = "0x9A639C", Offset = "0x9A639C", VA = "0x9A639C")]
			set
			{
			}
		}

		[Token(Token = "0x1700004D")]
		public bool IsValid
		{
			[Token(Token = "0x60001F9")]
			[Address(RVA = "0x9A6624", Offset = "0x9A6624", VA = "0x9A6624")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x9A49F0", Offset = "0x9A49F0", VA = "0x9A49F0")]
		public CoroutineHandle(byte ind)
		{
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x9A4AD8", Offset = "0x9A4AD8", VA = "0x9A4AD8")]
		public CoroutineHandle(CoroutineHandle other)
		{
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x9A4AE0", Offset = "0x9A4AE0", VA = "0x9A4AE0", Slot = "4")]
		public bool Equals(CoroutineHandle other)
		{
			return default(bool);
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x9A4AF0", Offset = "0x9A4AF0", VA = "0x9A4AF0", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x9A4B74", Offset = "0x9A4B74", VA = "0x9A4B74")]
		public static bool operator ==(CoroutineHandle a, CoroutineHandle b)
		{
			return default(bool);
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x9A4B80", Offset = "0x9A4B80", VA = "0x9A4B80")]
		public static bool operator !=(CoroutineHandle a, CoroutineHandle b)
		{
			return default(bool);
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x9A4B8C", Offset = "0x9A4B8C", VA = "0x9A4B8C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x9A4B94", Offset = "0x9A4B94", VA = "0x9A4B94", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x9A6634", Offset = "0x9A6634", VA = "0x9A6634")]
		public CoroutineHandle OnDestroy(Action action, Segment segment = Segment.Update)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x9A68FC", Offset = "0x9A68FC", VA = "0x9A68FC")]
		public CoroutineHandle OnDestroy(IEnumerator<float> action, Segment segment = Segment.Update)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x9A6808", Offset = "0x9A6808", VA = "0x9A6808")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x77AB60", Offset = "0x77AB60")]
		private static IEnumerator<float> _OnDestroy(CoroutineHandle watched, Action action)
		{
			return null;
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x9A6A28", Offset = "0x9A6A28", VA = "0x9A6A28")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x77ABC0", Offset = "0x77ABC0")]
		private static IEnumerator<float> _OnDestroy(CoroutineHandle watched, IEnumerator<float> action)
		{
			return null;
		}
	}
	[Token(Token = "0x200002B")]
	public static class MECExtensionMethods1
	{
		[Token(Token = "0x600020B")]
		[Address(RVA = "0x9B3850", Offset = "0x9B3850", VA = "0x9B3850")]
		public static CoroutineHandle RunCoroutine(this IEnumerator<float> coroutine)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x9B3978", Offset = "0x9B3978", VA = "0x9B3978")]
		public static CoroutineHandle RunCoroutine(this IEnumerator<float> coroutine, GameObject gameObj)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x9B3B6C", Offset = "0x9B3B6C", VA = "0x9B3B6C")]
		public static CoroutineHandle RunCoroutine(this IEnumerator<float> coroutine, int layer)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x9B3CB0", Offset = "0x9B3CB0", VA = "0x9B3CB0")]
		public static CoroutineHandle RunCoroutine(this IEnumerator<float> coroutine, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x9B3DF4", Offset = "0x9B3DF4", VA = "0x9B3DF4")]
		public static CoroutineHandle RunCoroutine(this IEnumerator<float> coroutine, GameObject gameObj, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x9B3FFC", Offset = "0x9B3FFC", VA = "0x9B3FFC")]
		public static CoroutineHandle RunCoroutine(this IEnumerator<float> coroutine, int layer, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x9B414C", Offset = "0x9B414C", VA = "0x9B414C")]
		public static CoroutineHandle RunCoroutine(this IEnumerator<float> coroutine, Segment segment)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x9B4290", Offset = "0x9B4290", VA = "0x9B4290")]
		public static CoroutineHandle RunCoroutine(this IEnumerator<float> coroutine, Segment segment, GameObject gameObj)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x9B4498", Offset = "0x9B4498", VA = "0x9B4498")]
		public static CoroutineHandle RunCoroutine(this IEnumerator<float> coroutine, Segment segment, int layer)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x9B45E8", Offset = "0x9B45E8", VA = "0x9B45E8")]
		public static CoroutineHandle RunCoroutine(this IEnumerator<float> coroutine, Segment segment, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x9B4738", Offset = "0x9B4738", VA = "0x9B4738")]
		public static CoroutineHandle RunCoroutine(this IEnumerator<float> coroutine, Segment segment, GameObject gameObj, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x9B4954", Offset = "0x9B4954", VA = "0x9B4954")]
		public static CoroutineHandle RunCoroutine(this IEnumerator<float> coroutine, Segment segment, int layer, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x9B4AC0", Offset = "0x9B4AC0", VA = "0x9B4AC0")]
		public static CoroutineHandle RunCoroutineSingleton(this IEnumerator<float> coroutine, CoroutineHandle handle, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x9B4D18", Offset = "0x9B4D18", VA = "0x9B4D18")]
		public static CoroutineHandle RunCoroutineSingleton(this IEnumerator<float> coroutine, GameObject gameObj, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x9B5150", Offset = "0x9B5150", VA = "0x9B5150")]
		public static CoroutineHandle RunCoroutineSingleton(this IEnumerator<float> coroutine, int layer, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x9B51D0", Offset = "0x9B51D0", VA = "0x9B51D0")]
		public static CoroutineHandle RunCoroutineSingleton(this IEnumerator<float> coroutine, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x9B5580", Offset = "0x9B5580", VA = "0x9B5580")]
		public static CoroutineHandle RunCoroutineSingleton(this IEnumerator<float> coroutine, GameObject gameObj, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x9B5C14", Offset = "0x9B5C14", VA = "0x9B5C14")]
		public static CoroutineHandle RunCoroutineSingleton(this IEnumerator<float> coroutine, int layer, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x9B5CA4", Offset = "0x9B5CA4", VA = "0x9B5CA4")]
		public static CoroutineHandle RunCoroutineSingleton(this IEnumerator<float> coroutine, CoroutineHandle handle, Segment segment, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x9B5F10", Offset = "0x9B5F10", VA = "0x9B5F10")]
		public static CoroutineHandle RunCoroutineSingleton(this IEnumerator<float> coroutine, Segment segment, GameObject gameObj, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x9B6368", Offset = "0x9B6368", VA = "0x9B6368")]
		public static CoroutineHandle RunCoroutineSingleton(this IEnumerator<float> coroutine, Segment segment, int layer, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x9B63F8", Offset = "0x9B63F8", VA = "0x9B63F8")]
		public static CoroutineHandle RunCoroutineSingleton(this IEnumerator<float> coroutine, Segment segment, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x9B67C4", Offset = "0x9B67C4", VA = "0x9B67C4")]
		public static CoroutineHandle RunCoroutineSingleton(this IEnumerator<float> coroutine, Segment segment, GameObject gameObj, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x9B6E74", Offset = "0x9B6E74", VA = "0x9B6E74")]
		public static CoroutineHandle RunCoroutineSingleton(this IEnumerator<float> coroutine, Segment segment, int layer, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x9B6F0C", Offset = "0x9B6F0C", VA = "0x9B6F0C")]
		public static float WaitUntilDone(this IEnumerator<float> newCoroutine)
		{
			return default(float);
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x9B6FFC", Offset = "0x9B6FFC", VA = "0x9B6FFC")]
		public static float WaitUntilDone(this IEnumerator<float> newCoroutine, string tag)
		{
			return default(float);
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x9B7104", Offset = "0x9B7104", VA = "0x9B7104")]
		public static float WaitUntilDone(this IEnumerator<float> newCoroutine, int layer)
		{
			return default(float);
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x9B720C", Offset = "0x9B720C", VA = "0x9B720C")]
		public static float WaitUntilDone(this IEnumerator<float> newCoroutine, int layer, string tag)
		{
			return default(float);
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x9B732C", Offset = "0x9B732C", VA = "0x9B732C")]
		public static float WaitUntilDone(this IEnumerator<float> newCoroutine, Segment segment)
		{
			return default(float);
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x9B7418", Offset = "0x9B7418", VA = "0x9B7418")]
		public static float WaitUntilDone(this IEnumerator<float> newCoroutine, Segment segment, string tag)
		{
			return default(float);
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x9B7514", Offset = "0x9B7514", VA = "0x9B7514")]
		public static float WaitUntilDone(this IEnumerator<float> newCoroutine, Segment segment, int layer)
		{
			return default(float);
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x9B7610", Offset = "0x9B7610", VA = "0x9B7610")]
		public static float WaitUntilDone(this IEnumerator<float> newCoroutine, Segment segment, int layer, string tag)
		{
			return default(float);
		}
	}
}
namespace DG.Tweening
{
	[Token(Token = "0x200002C")]
	public static class DOTweenModuleAudio
	{
		[Token(Token = "0x200002D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7785D4", Offset = "0x7785D4")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x4000121")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioSource target;

			[Token(Token = "0x600023A")]
			[Address(RVA = "0x19A0BC8", Offset = "0x19A0BC8", VA = "0x19A0BC8")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x600023B")]
			[Address(RVA = "0x19A0BD0", Offset = "0x19A0BD0", VA = "0x19A0BD0")]
			internal float <DOFade>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x600023C")]
			[Address(RVA = "0x19A0BEC", Offset = "0x19A0BEC", VA = "0x19A0BEC")]
			internal void <DOFade>b__1(float x)
			{
			}
		}

		[Token(Token = "0x200002E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7785E4", Offset = "0x7785E4")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x4000122")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioSource target;

			[Token(Token = "0x600023D")]
			[Address(RVA = "0x19A0C08", Offset = "0x19A0C08", VA = "0x19A0C08")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x600023E")]
			[Address(RVA = "0x19A0C10", Offset = "0x19A0C10", VA = "0x19A0C10")]
			internal float <DOPitch>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x600023F")]
			[Address(RVA = "0x19A0C2C", Offset = "0x19A0C2C", VA = "0x19A0C2C")]
			internal void <DOPitch>b__1(float x)
			{
			}
		}

		[Token(Token = "0x200002F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7785F4", Offset = "0x7785F4")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x4000123")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioMixer target;

			[Token(Token = "0x4000124")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string floatName;

			[Token(Token = "0x6000240")]
			[Address(RVA = "0x19A0C48", Offset = "0x19A0C48", VA = "0x19A0C48")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x6000241")]
			[Address(RVA = "0x19A0C50", Offset = "0x19A0C50", VA = "0x19A0C50")]
			internal float <DOSetFloat>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x6000242")]
			[Address(RVA = "0x19A0C90", Offset = "0x19A0C90", VA = "0x19A0C90")]
			internal void <DOSetFloat>b__1(float x)
			{
			}
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x9AB2EC", Offset = "0x9AB2EC", VA = "0x9AB2EC")]
		public static TweenerCore<float, float, FloatOptions> DOFade(this AudioSource target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x9AB4AC", Offset = "0x9AB4AC", VA = "0x9AB4AC")]
		public static TweenerCore<float, float, FloatOptions> DOPitch(this AudioSource target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x9AB644", Offset = "0x9AB644", VA = "0x9AB644")]
		public static TweenerCore<float, float, FloatOptions> DOSetFloat(this AudioMixer target, string floatName, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x9AB7E0", Offset = "0x9AB7E0", VA = "0x9AB7E0")]
		public static int DOComplete(this AudioMixer target, bool withCallbacks = false)
		{
			return default(int);
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x9AB854", Offset = "0x9AB854", VA = "0x9AB854")]
		public static int DOKill(this AudioMixer target, bool complete = false)
		{
			return default(int);
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x9AB8C8", Offset = "0x9AB8C8", VA = "0x9AB8C8")]
		public static int DOFlip(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x9AB92C", Offset = "0x9AB92C", VA = "0x9AB92C")]
		public static int DOGoto(this AudioMixer target, float to, bool andPlay = false)
		{
			return default(int);
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x9AB9B0", Offset = "0x9AB9B0", VA = "0x9AB9B0")]
		public static int DOPause(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x9ABA14", Offset = "0x9ABA14", VA = "0x9ABA14")]
		public static int DOPlay(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x9ABA78", Offset = "0x9ABA78", VA = "0x9ABA78")]
		public static int DOPlayBackwards(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x9ABADC", Offset = "0x9ABADC", VA = "0x9ABADC")]
		public static int DOPlayForward(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x9ABB40", Offset = "0x9ABB40", VA = "0x9ABB40")]
		public static int DORestart(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x9ABBAC", Offset = "0x9ABBAC", VA = "0x9ABBAC")]
		public static int DORewind(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x9ABC14", Offset = "0x9ABC14", VA = "0x9ABC14")]
		public static int DOSmoothRewind(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x9ABC78", Offset = "0x9ABC78", VA = "0x9ABC78")]
		public static int DOTogglePause(this AudioMixer target)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000030")]
	public static class DOTweenModulePhysics
	{
		[Token(Token = "0x2000031")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778614", Offset = "0x778614")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x4000125")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x600024E")]
			[Address(RVA = "0x19A0CB4", Offset = "0x19A0CB4", VA = "0x19A0CB4")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x600024F")]
			[Address(RVA = "0x19A0CBC", Offset = "0x19A0CBC", VA = "0x19A0CBC")]
			internal Vector3 <DOMove>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x2000032")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778624", Offset = "0x778624")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x4000126")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x6000250")]
			[Address(RVA = "0x19A0DFC", Offset = "0x19A0DFC", VA = "0x19A0DFC")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x6000251")]
			[Address(RVA = "0x19A0E04", Offset = "0x19A0E04", VA = "0x19A0E04")]
			internal Vector3 <DOMoveX>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x2000033")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778634", Offset = "0x778634")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x4000127")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x6000252")]
			[Address(RVA = "0x19A0E20", Offset = "0x19A0E20", VA = "0x19A0E20")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x6000253")]
			[Address(RVA = "0x19A0E28", Offset = "0x19A0E28", VA = "0x19A0E28")]
			internal Vector3 <DOMoveY>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x2000034")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778644", Offset = "0x778644")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x4000128")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x6000254")]
			[Address(RVA = "0x19A0E44", Offset = "0x19A0E44", VA = "0x19A0E44")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x6000255")]
			[Address(RVA = "0x19A0E4C", Offset = "0x19A0E4C", VA = "0x19A0E4C")]
			internal Vector3 <DOMoveZ>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x2000035")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778654", Offset = "0x778654")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x4000129")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x6000256")]
			[Address(RVA = "0x19A0E68", Offset = "0x19A0E68", VA = "0x19A0E68")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x6000257")]
			[Address(RVA = "0x19A0E70", Offset = "0x19A0E70", VA = "0x19A0E70")]
			internal Quaternion <DORotate>b__0()
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x2000036")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778664", Offset = "0x778664")]
		private sealed class <>c__DisplayClass5_0
		{
			[Token(Token = "0x400012A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x6000258")]
			[Address(RVA = "0x19A0E8C", Offset = "0x19A0E8C", VA = "0x19A0E8C")]
			public <>c__DisplayClass5_0()
			{
			}

			[Token(Token = "0x6000259")]
			[Address(RVA = "0x19A0E94", Offset = "0x19A0E94", VA = "0x19A0E94")]
			internal Quaternion <DOLookAt>b__0()
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x2000037")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778674", Offset = "0x778674")]
		private sealed class <>c__DisplayClass6_0
		{
			[Token(Token = "0x400012B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x400012C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float startPosY;

			[Token(Token = "0x400012D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool offsetYSet;

			[Token(Token = "0x400012E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float offsetY;

			[Token(Token = "0x400012F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Sequence s;

			[Token(Token = "0x4000130")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Vector3 endValue;

			[Token(Token = "0x4000131")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Tween yTween;

			[Token(Token = "0x600025A")]
			[Address(RVA = "0x19A0EB0", Offset = "0x19A0EB0", VA = "0x19A0EB0")]
			public <>c__DisplayClass6_0()
			{
			}

			[Token(Token = "0x600025B")]
			[Address(RVA = "0x19A0EB8", Offset = "0x19A0EB8", VA = "0x19A0EB8")]
			internal Vector3 <DOJump>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x600025C")]
			[Address(RVA = "0x19A0ED4", Offset = "0x19A0ED4", VA = "0x19A0ED4")]
			internal void <DOJump>b__1()
			{
			}

			[Token(Token = "0x600025D")]
			[Address(RVA = "0x19A0F08", Offset = "0x19A0F08", VA = "0x19A0F08")]
			internal Vector3 <DOJump>b__2()
			{
				return default(Vector3);
			}

			[Token(Token = "0x600025E")]
			[Address(RVA = "0x19A0F24", Offset = "0x19A0F24", VA = "0x19A0F24")]
			internal Vector3 <DOJump>b__3()
			{
				return default(Vector3);
			}

			[Token(Token = "0x600025F")]
			[Address(RVA = "0x19A0F40", Offset = "0x19A0F40", VA = "0x19A0F40")]
			internal void <DOJump>b__4()
			{
			}
		}

		[Token(Token = "0x2000038")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778684", Offset = "0x778684")]
		private sealed class <>c__DisplayClass7_0
		{
			[Token(Token = "0x4000132")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x6000260")]
			[Address(RVA = "0x19A1000", Offset = "0x19A1000", VA = "0x19A1000")]
			public <>c__DisplayClass7_0()
			{
			}

			[Token(Token = "0x6000261")]
			[Address(RVA = "0x19A1008", Offset = "0x19A1008", VA = "0x19A1008")]
			internal Vector3 <DOPath>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x2000039")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778694", Offset = "0x778694")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x4000133")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform trans;

			[Token(Token = "0x4000134")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Rigidbody target;

			[Token(Token = "0x6000262")]
			[Address(RVA = "0x19A1024", Offset = "0x19A1024", VA = "0x19A1024")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x6000263")]
			[Address(RVA = "0x19A102C", Offset = "0x19A102C", VA = "0x19A102C")]
			internal Vector3 <DOLocalPath>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000264")]
			[Address(RVA = "0x19A1048", Offset = "0x19A1048", VA = "0x19A1048")]
			internal void <DOLocalPath>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x200003A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7786A4", Offset = "0x7786A4")]
		private sealed class <>c__DisplayClass9_0
		{
			[Token(Token = "0x4000135")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x6000265")]
			[Address(RVA = "0x19A1148", Offset = "0x19A1148", VA = "0x19A1148")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x6000266")]
			[Address(RVA = "0x19A1150", Offset = "0x19A1150", VA = "0x19A1150")]
			internal Vector3 <DOPath>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x200003B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7786B4", Offset = "0x7786B4")]
		private sealed class <>c__DisplayClass10_0
		{
			[Token(Token = "0x4000136")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform trans;

			[Token(Token = "0x4000137")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Rigidbody target;

			[Token(Token = "0x6000267")]
			[Address(RVA = "0x19A0CD8", Offset = "0x19A0CD8", VA = "0x19A0CD8")]
			public <>c__DisplayClass10_0()
			{
			}

			[Token(Token = "0x6000268")]
			[Address(RVA = "0x19A0CE0", Offset = "0x19A0CE0", VA = "0x19A0CE0")]
			internal Vector3 <DOLocalPath>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000269")]
			[Address(RVA = "0x19A0CFC", Offset = "0x19A0CFC", VA = "0x19A0CFC")]
			internal void <DOLocalPath>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x9A86F8", Offset = "0x9A86F8", VA = "0x9A86F8")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMove(this Rigidbody target, Vector3 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x9ABCDC", Offset = "0x9ABCDC", VA = "0x9ABCDC")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveX(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x9ABE9C", Offset = "0x9ABE9C", VA = "0x9ABE9C")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveY(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x9AC05C", Offset = "0x9AC05C", VA = "0x9AC05C")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveZ(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x9A8A88", Offset = "0x9A8A88", VA = "0x9A8A88")]
		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DORotate(this Rigidbody target, Vector3 endValue, float duration, RotateMode mode = RotateMode.Fast)
		{
			return null;
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x9AC21C", Offset = "0x9AC21C", VA = "0x9AC21C")]
		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DOLookAt(this Rigidbody target, Vector3 towards, float duration, AxisConstraint axisConstraint = AxisConstraint.None, [Optional] Vector3? up)
		{
			return null;
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x9AC460", Offset = "0x9AC460", VA = "0x9AC460")]
		public static Sequence DOJump(this Rigidbody target, Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x9AC958", Offset = "0x9AC958", VA = "0x9AC958")]
		public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x9ACBC4", Offset = "0x9ACBC4", VA = "0x9ACBC4")]
		public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x9ACE44", Offset = "0x9ACE44", VA = "0x9ACE44")]
		internal static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x9AD024", Offset = "0x9AD024", VA = "0x9AD024")]
		internal static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}
	}
	[Token(Token = "0x200003C")]
	public static class DOTweenModulePhysics2D
	{
		[Token(Token = "0x200003D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7786D4", Offset = "0x7786D4")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x4000138")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x6000271")]
			[Address(RVA = "0x19A116C", Offset = "0x19A116C", VA = "0x19A116C")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x6000272")]
			[Address(RVA = "0x19A1174", Offset = "0x19A1174", VA = "0x19A1174")]
			internal Vector2 <DOMove>b__0()
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x200003E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7786E4", Offset = "0x7786E4")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x4000139")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x6000273")]
			[Address(RVA = "0x19A1190", Offset = "0x19A1190", VA = "0x19A1190")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x6000274")]
			[Address(RVA = "0x19A1198", Offset = "0x19A1198", VA = "0x19A1198")]
			internal Vector2 <DOMoveX>b__0()
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x200003F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7786F4", Offset = "0x7786F4")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x400013A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x6000275")]
			[Address(RVA = "0x19A11B4", Offset = "0x19A11B4", VA = "0x19A11B4")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x6000276")]
			[Address(RVA = "0x19A11BC", Offset = "0x19A11BC", VA = "0x19A11BC")]
			internal Vector2 <DOMoveY>b__0()
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x2000040")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778704", Offset = "0x778704")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x400013B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x6000277")]
			[Address(RVA = "0x19A11D8", Offset = "0x19A11D8", VA = "0x19A11D8")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x6000278")]
			[Address(RVA = "0x19A11E0", Offset = "0x19A11E0", VA = "0x19A11E0")]
			internal float <DORotate>b__0()
			{
				return default(float);
			}
		}

		[Token(Token = "0x2000041")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778714", Offset = "0x778714")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x400013C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x400013D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float startPosY;

			[Token(Token = "0x400013E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool offsetYSet;

			[Token(Token = "0x400013F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float offsetY;

			[Token(Token = "0x4000140")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Sequence s;

			[Token(Token = "0x4000141")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Vector2 endValue;

			[Token(Token = "0x4000142")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Tween yTween;

			[Token(Token = "0x6000279")]
			[Address(RVA = "0x19A11FC", Offset = "0x19A11FC", VA = "0x19A11FC")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x600027A")]
			[Address(RVA = "0x19A1204", Offset = "0x19A1204", VA = "0x19A1204")]
			internal Vector2 <DOJump>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x600027B")]
			[Address(RVA = "0x19A1220", Offset = "0x19A1220", VA = "0x19A1220")]
			internal void <DOJump>b__1(Vector2 x)
			{
			}

			[Token(Token = "0x600027C")]
			[Address(RVA = "0x19A123C", Offset = "0x19A123C", VA = "0x19A123C")]
			internal void <DOJump>b__2()
			{
			}

			[Token(Token = "0x600027D")]
			[Address(RVA = "0x19A1270", Offset = "0x19A1270", VA = "0x19A1270")]
			internal Vector2 <DOJump>b__3()
			{
				return default(Vector2);
			}

			[Token(Token = "0x600027E")]
			[Address(RVA = "0x19A128C", Offset = "0x19A128C", VA = "0x19A128C")]
			internal void <DOJump>b__4(Vector2 x)
			{
			}

			[Token(Token = "0x600027F")]
			[Address(RVA = "0x19A12A8", Offset = "0x19A12A8", VA = "0x19A12A8")]
			internal void <DOJump>b__5()
			{
			}
		}

		[Token(Token = "0x2000042")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778724", Offset = "0x778724")]
		private sealed class <>c__DisplayClass5_0
		{
			[Token(Token = "0x4000143")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x6000280")]
			[Address(RVA = "0x19A1360", Offset = "0x19A1360", VA = "0x19A1360")]
			public <>c__DisplayClass5_0()
			{
			}

			[Token(Token = "0x6000281")]
			[Address(RVA = "0x19A1368", Offset = "0x19A1368", VA = "0x19A1368")]
			internal Vector3 <DOPath>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000282")]
			[Address(RVA = "0x19A1390", Offset = "0x19A1390", VA = "0x19A1390")]
			internal void <DOPath>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000043")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778734", Offset = "0x778734")]
		private sealed class <>c__DisplayClass6_0
		{
			[Token(Token = "0x4000144")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform trans;

			[Token(Token = "0x4000145")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Rigidbody2D target;

			[Token(Token = "0x6000283")]
			[Address(RVA = "0x19A13AC", Offset = "0x19A13AC", VA = "0x19A13AC")]
			public <>c__DisplayClass6_0()
			{
			}

			[Token(Token = "0x6000284")]
			[Address(RVA = "0x19A13B4", Offset = "0x19A13B4", VA = "0x19A13B4")]
			internal Vector3 <DOLocalPath>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000285")]
			[Address(RVA = "0x19A13D0", Offset = "0x19A13D0", VA = "0x19A13D0")]
			internal void <DOLocalPath>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x9A88C4", Offset = "0x9A88C4", VA = "0x9A88C4")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMove(this Rigidbody2D target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x9AD210", Offset = "0x9AD210", VA = "0x9AD210")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveX(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x9AD3CC", Offset = "0x9AD3CC", VA = "0x9AD3CC")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveY(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x9A8C50", Offset = "0x9A8C50", VA = "0x9A8C50")]
		public static TweenerCore<float, float, FloatOptions> DORotate(this Rigidbody2D target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x9AD588", Offset = "0x9AD588", VA = "0x9AD588")]
		public static Sequence DOJump(this Rigidbody2D target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x9AD9B0", Offset = "0x9AD9B0", VA = "0x9AD9B0")]
		public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody2D target, Vector2[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x9ADCA0", Offset = "0x9ADCA0", VA = "0x9ADCA0")]
		public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody2D target, Vector2[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}
	}
	[Token(Token = "0x2000044")]
	public static class DOTweenModuleSprite
	{
		[Token(Token = "0x2000045")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778754", Offset = "0x778754")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x4000146")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SpriteRenderer target;

			[Token(Token = "0x600028A")]
			[Address(RVA = "0x19A14C8", Offset = "0x19A14C8", VA = "0x19A14C8")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x600028B")]
			[Address(RVA = "0x19A14D0", Offset = "0x19A14D0", VA = "0x19A14D0")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x600028C")]
			[Address(RVA = "0x19A14EC", Offset = "0x19A14EC", VA = "0x19A14EC")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000046")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778764", Offset = "0x778764")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x4000147")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SpriteRenderer target;

			[Token(Token = "0x600028D")]
			[Address(RVA = "0x19A1508", Offset = "0x19A1508", VA = "0x19A1508")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x600028E")]
			[Address(RVA = "0x19A1510", Offset = "0x19A1510", VA = "0x19A1510")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x600028F")]
			[Address(RVA = "0x19A152C", Offset = "0x19A152C", VA = "0x19A152C")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000047")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778774", Offset = "0x778774")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x4000148")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x4000149")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SpriteRenderer target;

			[Token(Token = "0x6000290")]
			[Address(RVA = "0x19A1548", Offset = "0x19A1548", VA = "0x19A1548")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x6000291")]
			[Address(RVA = "0x19A1550", Offset = "0x19A1550", VA = "0x19A1550")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000292")]
			[Address(RVA = "0x19A155C", Offset = "0x19A155C", VA = "0x19A155C")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x9A8FA4", Offset = "0x9A8FA4", VA = "0x9A8FA4")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this SpriteRenderer target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x9A94E4", Offset = "0x9A94E4", VA = "0x9A94E4")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this SpriteRenderer target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x9ADFA8", Offset = "0x9ADFA8", VA = "0x9ADFA8")]
		public static Sequence DOGradientColor(this SpriteRenderer target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x9AE194", Offset = "0x9AE194", VA = "0x9AE194")]
		public static Tweener DOBlendableColor(this SpriteRenderer target, Color endValue, float duration)
		{
			return null;
		}
	}
	[Token(Token = "0x2000048")]
	public static class DOTweenModuleUI
	{
		[Token(Token = "0x2000049")]
		public static class Utils
		{
			[Token(Token = "0x60002BC")]
			[Address(RVA = "0x19A25F0", Offset = "0x19A25F0", VA = "0x19A25F0")]
			public static Vector2 SwitchToRectTransform(RectTransform from, RectTransform to)
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x200004A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778794", Offset = "0x778794")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x400014A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CanvasGroup target;

			[Token(Token = "0x60002BD")]
			[Address(RVA = "0x19A1608", Offset = "0x19A1608", VA = "0x19A1608")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x60002BE")]
			[Address(RVA = "0x19A1610", Offset = "0x19A1610", VA = "0x19A1610")]
			internal float <DOFade>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x60002BF")]
			[Address(RVA = "0x19A162C", Offset = "0x19A162C", VA = "0x19A162C")]
			internal void <DOFade>b__1(float x)
			{
			}
		}

		[Token(Token = "0x200004B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7787A4", Offset = "0x7787A4")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x400014B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Graphic target;

			[Token(Token = "0x60002C0")]
			[Address(RVA = "0x19A18D0", Offset = "0x19A18D0", VA = "0x19A18D0")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x60002C1")]
			[Address(RVA = "0x19A18D8", Offset = "0x19A18D8", VA = "0x19A18D8")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60002C2")]
			[Address(RVA = "0x19A18FC", Offset = "0x19A18FC", VA = "0x19A18FC")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x200004C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7787B4", Offset = "0x7787B4")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x400014C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Graphic target;

			[Token(Token = "0x60002C3")]
			[Address(RVA = "0x19A1CE4", Offset = "0x19A1CE4", VA = "0x19A1CE4")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x60002C4")]
			[Address(RVA = "0x19A1CEC", Offset = "0x19A1CEC", VA = "0x19A1CEC")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60002C5")]
			[Address(RVA = "0x19A1D10", Offset = "0x19A1D10", VA = "0x19A1D10")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x200004D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7787C4", Offset = "0x7787C4")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x400014D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Image target;

			[Token(Token = "0x60002C6")]
			[Address(RVA = "0x19A21E8", Offset = "0x19A21E8", VA = "0x19A21E8")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x60002C7")]
			[Address(RVA = "0x19A21F0", Offset = "0x19A21F0", VA = "0x19A21F0")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60002C8")]
			[Address(RVA = "0x19A2214", Offset = "0x19A2214", VA = "0x19A2214")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x200004E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7787D4", Offset = "0x7787D4")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x400014E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Image target;

			[Token(Token = "0x60002C9")]
			[Address(RVA = "0x19A2308", Offset = "0x19A2308", VA = "0x19A2308")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x60002CA")]
			[Address(RVA = "0x19A2310", Offset = "0x19A2310", VA = "0x19A2310")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60002CB")]
			[Address(RVA = "0x19A2334", Offset = "0x19A2334", VA = "0x19A2334")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x200004F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7787E4", Offset = "0x7787E4")]
		private sealed class <>c__DisplayClass5_0
		{
			[Token(Token = "0x400014F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Image target;

			[Token(Token = "0x60002CC")]
			[Address(RVA = "0x19A2358", Offset = "0x19A2358", VA = "0x19A2358")]
			public <>c__DisplayClass5_0()
			{
			}

			[Token(Token = "0x60002CD")]
			[Address(RVA = "0x19A2360", Offset = "0x19A2360", VA = "0x19A2360")]
			internal float <DOFillAmount>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x60002CE")]
			[Address(RVA = "0x19A237C", Offset = "0x19A237C", VA = "0x19A237C")]
			internal void <DOFillAmount>b__1(float x)
			{
			}
		}

		[Token(Token = "0x2000050")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7787F4", Offset = "0x7787F4")]
		private sealed class <>c__DisplayClass7_0
		{
			[Token(Token = "0x4000150")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LayoutElement target;

			[Token(Token = "0x60002CF")]
			[Address(RVA = "0x19A2398", Offset = "0x19A2398", VA = "0x19A2398")]
			public <>c__DisplayClass7_0()
			{
			}

			[Token(Token = "0x60002D0")]
			[Address(RVA = "0x19A23A0", Offset = "0x19A23A0", VA = "0x19A23A0")]
			internal Vector2 <DOFlexibleSize>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60002D1")]
			[Address(RVA = "0x19A2404", Offset = "0x19A2404", VA = "0x19A2404")]
			internal void <DOFlexibleSize>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000051")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778804", Offset = "0x778804")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x4000151")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LayoutElement target;

			[Token(Token = "0x60002D2")]
			[Address(RVA = "0x19A2460", Offset = "0x19A2460", VA = "0x19A2460")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x60002D3")]
			[Address(RVA = "0x19A2468", Offset = "0x19A2468", VA = "0x19A2468")]
			internal Vector2 <DOMinSize>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60002D4")]
			[Address(RVA = "0x19A24CC", Offset = "0x19A24CC", VA = "0x19A24CC")]
			internal void <DOMinSize>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000052")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778814", Offset = "0x778814")]
		private sealed class <>c__DisplayClass9_0
		{
			[Token(Token = "0x4000152")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LayoutElement target;

			[Token(Token = "0x60002D5")]
			[Address(RVA = "0x19A2528", Offset = "0x19A2528", VA = "0x19A2528")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x60002D6")]
			[Address(RVA = "0x19A2530", Offset = "0x19A2530", VA = "0x19A2530")]
			internal Vector2 <DOPreferredSize>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60002D7")]
			[Address(RVA = "0x19A2594", Offset = "0x19A2594", VA = "0x19A2594")]
			internal void <DOPreferredSize>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000053")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778824", Offset = "0x778824")]
		private sealed class <>c__DisplayClass10_0
		{
			[Token(Token = "0x4000153")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Outline target;

			[Token(Token = "0x60002D8")]
			[Address(RVA = "0x19A1648", Offset = "0x19A1648", VA = "0x19A1648")]
			public <>c__DisplayClass10_0()
			{
			}

			[Token(Token = "0x60002D9")]
			[Address(RVA = "0x19A1650", Offset = "0x19A1650", VA = "0x19A1650")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60002DA")]
			[Address(RVA = "0x19A1670", Offset = "0x19A1670", VA = "0x19A1670")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000054")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778834", Offset = "0x778834")]
		private sealed class <>c__DisplayClass11_0
		{
			[Token(Token = "0x4000154")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Outline target;

			[Token(Token = "0x60002DB")]
			[Address(RVA = "0x19A168C", Offset = "0x19A168C", VA = "0x19A168C")]
			public <>c__DisplayClass11_0()
			{
			}

			[Token(Token = "0x60002DC")]
			[Address(RVA = "0x19A1694", Offset = "0x19A1694", VA = "0x19A1694")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60002DD")]
			[Address(RVA = "0x19A16B4", Offset = "0x19A16B4", VA = "0x19A16B4")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000055")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778844", Offset = "0x778844")]
		private sealed class <>c__DisplayClass12_0
		{
			[Token(Token = "0x4000155")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Outline target;

			[Token(Token = "0x60002DE")]
			[Address(RVA = "0x19A16D0", Offset = "0x19A16D0", VA = "0x19A16D0")]
			public <>c__DisplayClass12_0()
			{
			}

			[Token(Token = "0x60002DF")]
			[Address(RVA = "0x19A16D8", Offset = "0x19A16D8", VA = "0x19A16D8")]
			internal Vector2 <DOScale>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60002E0")]
			[Address(RVA = "0x19A16F4", Offset = "0x19A16F4", VA = "0x19A16F4")]
			internal void <DOScale>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000056")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778854", Offset = "0x778854")]
		private sealed class <>c__DisplayClass13_0
		{
			[Token(Token = "0x4000156")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60002E1")]
			[Address(RVA = "0x19A1710", Offset = "0x19A1710", VA = "0x19A1710")]
			public <>c__DisplayClass13_0()
			{
			}

			[Token(Token = "0x60002E2")]
			[Address(RVA = "0x19A1718", Offset = "0x19A1718", VA = "0x19A1718")]
			internal Vector2 <DOAnchorPos>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60002E3")]
			[Address(RVA = "0x19A1734", Offset = "0x19A1734", VA = "0x19A1734")]
			internal void <DOAnchorPos>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000057")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778864", Offset = "0x778864")]
		private sealed class <>c__DisplayClass14_0
		{
			[Token(Token = "0x4000157")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60002E4")]
			[Address(RVA = "0x19A1750", Offset = "0x19A1750", VA = "0x19A1750")]
			public <>c__DisplayClass14_0()
			{
			}

			[Token(Token = "0x60002E5")]
			[Address(RVA = "0x19A1758", Offset = "0x19A1758", VA = "0x19A1758")]
			internal Vector2 <DOAnchorPosX>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60002E6")]
			[Address(RVA = "0x19A1774", Offset = "0x19A1774", VA = "0x19A1774")]
			internal void <DOAnchorPosX>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000058")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778874", Offset = "0x778874")]
		private sealed class <>c__DisplayClass15_0
		{
			[Token(Token = "0x4000158")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60002E7")]
			[Address(RVA = "0x19A1790", Offset = "0x19A1790", VA = "0x19A1790")]
			public <>c__DisplayClass15_0()
			{
			}

			[Token(Token = "0x60002E8")]
			[Address(RVA = "0x19A1798", Offset = "0x19A1798", VA = "0x19A1798")]
			internal Vector2 <DOAnchorPosY>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60002E9")]
			[Address(RVA = "0x19A17B4", Offset = "0x19A17B4", VA = "0x19A17B4")]
			internal void <DOAnchorPosY>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000059")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778884", Offset = "0x778884")]
		private sealed class <>c__DisplayClass16_0
		{
			[Token(Token = "0x4000159")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60002EA")]
			[Address(RVA = "0x19A17D0", Offset = "0x19A17D0", VA = "0x19A17D0")]
			public <>c__DisplayClass16_0()
			{
			}

			[Token(Token = "0x60002EB")]
			[Address(RVA = "0x19A17D8", Offset = "0x19A17D8", VA = "0x19A17D8")]
			internal Vector3 <DOAnchorPos3D>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60002EC")]
			[Address(RVA = "0x19A17F4", Offset = "0x19A17F4", VA = "0x19A17F4")]
			internal void <DOAnchorPos3D>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x200005A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778894", Offset = "0x778894")]
		private sealed class <>c__DisplayClass17_0
		{
			[Token(Token = "0x400015A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60002ED")]
			[Address(RVA = "0x19A1810", Offset = "0x19A1810", VA = "0x19A1810")]
			public <>c__DisplayClass17_0()
			{
			}

			[Token(Token = "0x60002EE")]
			[Address(RVA = "0x19A1818", Offset = "0x19A1818", VA = "0x19A1818")]
			internal Vector3 <DOAnchorPos3DX>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60002EF")]
			[Address(RVA = "0x19A1834", Offset = "0x19A1834", VA = "0x19A1834")]
			internal void <DOAnchorPos3DX>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x200005B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7788A4", Offset = "0x7788A4")]
		private sealed class <>c__DisplayClass18_0
		{
			[Token(Token = "0x400015B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60002F0")]
			[Address(RVA = "0x19A1850", Offset = "0x19A1850", VA = "0x19A1850")]
			public <>c__DisplayClass18_0()
			{
			}

			[Token(Token = "0x60002F1")]
			[Address(RVA = "0x19A1858", Offset = "0x19A1858", VA = "0x19A1858")]
			internal Vector3 <DOAnchorPos3DY>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60002F2")]
			[Address(RVA = "0x19A1874", Offset = "0x19A1874", VA = "0x19A1874")]
			internal void <DOAnchorPos3DY>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x200005C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7788B4", Offset = "0x7788B4")]
		private sealed class <>c__DisplayClass19_0
		{
			[Token(Token = "0x400015C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60002F3")]
			[Address(RVA = "0x19A1890", Offset = "0x19A1890", VA = "0x19A1890")]
			public <>c__DisplayClass19_0()
			{
			}

			[Token(Token = "0x60002F4")]
			[Address(RVA = "0x19A1898", Offset = "0x19A1898", VA = "0x19A1898")]
			internal Vector3 <DOAnchorPos3DZ>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60002F5")]
			[Address(RVA = "0x19A18B4", Offset = "0x19A18B4", VA = "0x19A18B4")]
			internal void <DOAnchorPos3DZ>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x200005D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7788C4", Offset = "0x7788C4")]
		private sealed class <>c__DisplayClass20_0
		{
			[Token(Token = "0x400015D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60002F6")]
			[Address(RVA = "0x19A1920", Offset = "0x19A1920", VA = "0x19A1920")]
			public <>c__DisplayClass20_0()
			{
			}

			[Token(Token = "0x60002F7")]
			[Address(RVA = "0x19A1928", Offset = "0x19A1928", VA = "0x19A1928")]
			internal Vector2 <DOAnchorMax>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60002F8")]
			[Address(RVA = "0x19A1944", Offset = "0x19A1944", VA = "0x19A1944")]
			internal void <DOAnchorMax>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x200005E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7788D4", Offset = "0x7788D4")]
		private sealed class <>c__DisplayClass21_0
		{
			[Token(Token = "0x400015E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60002F9")]
			[Address(RVA = "0x19A1960", Offset = "0x19A1960", VA = "0x19A1960")]
			public <>c__DisplayClass21_0()
			{
			}

			[Token(Token = "0x60002FA")]
			[Address(RVA = "0x19A1968", Offset = "0x19A1968", VA = "0x19A1968")]
			internal Vector2 <DOAnchorMin>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60002FB")]
			[Address(RVA = "0x19A1984", Offset = "0x19A1984", VA = "0x19A1984")]
			internal void <DOAnchorMin>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x200005F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7788E4", Offset = "0x7788E4")]
		private sealed class <>c__DisplayClass22_0
		{
			[Token(Token = "0x400015F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60002FC")]
			[Address(RVA = "0x19A19A0", Offset = "0x19A19A0", VA = "0x19A19A0")]
			public <>c__DisplayClass22_0()
			{
			}

			[Token(Token = "0x60002FD")]
			[Address(RVA = "0x19A19A8", Offset = "0x19A19A8", VA = "0x19A19A8")]
			internal Vector2 <DOPivot>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60002FE")]
			[Address(RVA = "0x19A19C4", Offset = "0x19A19C4", VA = "0x19A19C4")]
			internal void <DOPivot>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000060")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7788F4", Offset = "0x7788F4")]
		private sealed class <>c__DisplayClass23_0
		{
			[Token(Token = "0x4000160")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60002FF")]
			[Address(RVA = "0x19A19E0", Offset = "0x19A19E0", VA = "0x19A19E0")]
			public <>c__DisplayClass23_0()
			{
			}

			[Token(Token = "0x6000300")]
			[Address(RVA = "0x19A19E8", Offset = "0x19A19E8", VA = "0x19A19E8")]
			internal Vector2 <DOPivotX>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000301")]
			[Address(RVA = "0x19A1A04", Offset = "0x19A1A04", VA = "0x19A1A04")]
			internal void <DOPivotX>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000061")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778904", Offset = "0x778904")]
		private sealed class <>c__DisplayClass24_0
		{
			[Token(Token = "0x4000161")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000302")]
			[Address(RVA = "0x19A1A20", Offset = "0x19A1A20", VA = "0x19A1A20")]
			public <>c__DisplayClass24_0()
			{
			}

			[Token(Token = "0x6000303")]
			[Address(RVA = "0x19A1A28", Offset = "0x19A1A28", VA = "0x19A1A28")]
			internal Vector2 <DOPivotY>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000304")]
			[Address(RVA = "0x19A1A44", Offset = "0x19A1A44", VA = "0x19A1A44")]
			internal void <DOPivotY>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000062")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778914", Offset = "0x778914")]
		private sealed class <>c__DisplayClass25_0
		{
			[Token(Token = "0x4000162")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000305")]
			[Address(RVA = "0x19A1A60", Offset = "0x19A1A60", VA = "0x19A1A60")]
			public <>c__DisplayClass25_0()
			{
			}

			[Token(Token = "0x6000306")]
			[Address(RVA = "0x19A1A68", Offset = "0x19A1A68", VA = "0x19A1A68")]
			internal Vector2 <DOSizeDelta>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000307")]
			[Address(RVA = "0x19A1A84", Offset = "0x19A1A84", VA = "0x19A1A84")]
			internal void <DOSizeDelta>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000063")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778924", Offset = "0x778924")]
		private sealed class <>c__DisplayClass26_0
		{
			[Token(Token = "0x4000163")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000308")]
			[Address(RVA = "0x19A1AA0", Offset = "0x19A1AA0", VA = "0x19A1AA0")]
			public <>c__DisplayClass26_0()
			{
			}

			[Token(Token = "0x6000309")]
			[Address(RVA = "0x19A1AA8", Offset = "0x19A1AA8", VA = "0x19A1AA8")]
			internal Vector3 <DOPunchAnchorPos>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x600030A")]
			[Address(RVA = "0x19A1AD0", Offset = "0x19A1AD0", VA = "0x19A1AD0")]
			internal void <DOPunchAnchorPos>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000064")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778934", Offset = "0x778934")]
		private sealed class <>c__DisplayClass27_0
		{
			[Token(Token = "0x4000164")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x600030B")]
			[Address(RVA = "0x19A1AEC", Offset = "0x19A1AEC", VA = "0x19A1AEC")]
			public <>c__DisplayClass27_0()
			{
			}

			[Token(Token = "0x600030C")]
			[Address(RVA = "0x19A1AF4", Offset = "0x19A1AF4", VA = "0x19A1AF4")]
			internal Vector3 <DOShakeAnchorPos>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x600030D")]
			[Address(RVA = "0x19A1B1C", Offset = "0x19A1B1C", VA = "0x19A1B1C")]
			internal void <DOShakeAnchorPos>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000065")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778944", Offset = "0x778944")]
		private sealed class <>c__DisplayClass28_0
		{
			[Token(Token = "0x4000165")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x600030E")]
			[Address(RVA = "0x19A1B38", Offset = "0x19A1B38", VA = "0x19A1B38")]
			public <>c__DisplayClass28_0()
			{
			}

			[Token(Token = "0x600030F")]
			[Address(RVA = "0x19A1B40", Offset = "0x19A1B40", VA = "0x19A1B40")]
			internal Vector3 <DOShakeAnchorPos>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000310")]
			[Address(RVA = "0x19A1B68", Offset = "0x19A1B68", VA = "0x19A1B68")]
			internal void <DOShakeAnchorPos>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000066")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778954", Offset = "0x778954")]
		private sealed class <>c__DisplayClass29_0
		{
			[Token(Token = "0x4000166")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x4000167")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float startPosY;

			[Token(Token = "0x4000168")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool offsetYSet;

			[Token(Token = "0x4000169")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float offsetY;

			[Token(Token = "0x400016A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Sequence s;

			[Token(Token = "0x400016B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Vector2 endValue;

			[Token(Token = "0x6000311")]
			[Address(RVA = "0x19A1B84", Offset = "0x19A1B84", VA = "0x19A1B84")]
			public <>c__DisplayClass29_0()
			{
			}

			[Token(Token = "0x6000312")]
			[Address(RVA = "0x19A1B8C", Offset = "0x19A1B8C", VA = "0x19A1B8C")]
			internal Vector2 <DOJumpAnchorPos>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000313")]
			[Address(RVA = "0x19A1BA8", Offset = "0x19A1BA8", VA = "0x19A1BA8")]
			internal void <DOJumpAnchorPos>b__1(Vector2 x)
			{
			}

			[Token(Token = "0x6000314")]
			[Address(RVA = "0x19A1BC4", Offset = "0x19A1BC4", VA = "0x19A1BC4")]
			internal void <DOJumpAnchorPos>b__2()
			{
			}

			[Token(Token = "0x6000315")]
			[Address(RVA = "0x19A1BF8", Offset = "0x19A1BF8", VA = "0x19A1BF8")]
			internal Vector2 <DOJumpAnchorPos>b__3()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000316")]
			[Address(RVA = "0x19A1C14", Offset = "0x19A1C14", VA = "0x19A1C14")]
			internal void <DOJumpAnchorPos>b__4(Vector2 x)
			{
			}

			[Token(Token = "0x6000317")]
			[Address(RVA = "0x19A1C30", Offset = "0x19A1C30", VA = "0x19A1C30")]
			internal void <DOJumpAnchorPos>b__5()
			{
			}
		}

		[Token(Token = "0x2000067")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778964", Offset = "0x778964")]
		private sealed class <>c__DisplayClass30_0
		{
			[Token(Token = "0x400016C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ScrollRect target;

			[Token(Token = "0x6000318")]
			[Address(RVA = "0x19A1D34", Offset = "0x19A1D34", VA = "0x19A1D34")]
			public <>c__DisplayClass30_0()
			{
			}

			[Token(Token = "0x6000319")]
			[Address(RVA = "0x19A1D3C", Offset = "0x19A1D3C", VA = "0x19A1D3C")]
			internal Vector2 <DONormalizedPos>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x600031A")]
			[Address(RVA = "0x19A1D90", Offset = "0x19A1D90", VA = "0x19A1D90")]
			internal void <DONormalizedPos>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000068")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778974", Offset = "0x778974")]
		private sealed class <>c__DisplayClass31_0
		{
			[Token(Token = "0x400016D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ScrollRect target;

			[Token(Token = "0x600031B")]
			[Address(RVA = "0x19A1DDC", Offset = "0x19A1DDC", VA = "0x19A1DDC")]
			public <>c__DisplayClass31_0()
			{
			}

			[Token(Token = "0x600031C")]
			[Address(RVA = "0x19A1DE4", Offset = "0x19A1DE4", VA = "0x19A1DE4")]
			internal float <DOHorizontalNormalizedPos>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x600031D")]
			[Address(RVA = "0x19A1E00", Offset = "0x19A1E00", VA = "0x19A1E00")]
			internal void <DOHorizontalNormalizedPos>b__1(float x)
			{
			}
		}

		[Token(Token = "0x2000069")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778984", Offset = "0x778984")]
		private sealed class <>c__DisplayClass32_0
		{
			[Token(Token = "0x400016E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ScrollRect target;

			[Token(Token = "0x600031E")]
			[Address(RVA = "0x19A1E1C", Offset = "0x19A1E1C", VA = "0x19A1E1C")]
			public <>c__DisplayClass32_0()
			{
			}

			[Token(Token = "0x600031F")]
			[Address(RVA = "0x19A1E24", Offset = "0x19A1E24", VA = "0x19A1E24")]
			internal float <DOVerticalNormalizedPos>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x6000320")]
			[Address(RVA = "0x19A1E40", Offset = "0x19A1E40", VA = "0x19A1E40")]
			internal void <DOVerticalNormalizedPos>b__1(float x)
			{
			}
		}

		[Token(Token = "0x200006A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778994", Offset = "0x778994")]
		private sealed class <>c__DisplayClass33_0
		{
			[Token(Token = "0x400016F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Slider target;

			[Token(Token = "0x6000321")]
			[Address(RVA = "0x19A1E5C", Offset = "0x19A1E5C", VA = "0x19A1E5C")]
			public <>c__DisplayClass33_0()
			{
			}

			[Token(Token = "0x6000322")]
			[Address(RVA = "0x19A1E64", Offset = "0x19A1E64", VA = "0x19A1E64")]
			internal float <DOValue>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x6000323")]
			[Address(RVA = "0x19A1E88", Offset = "0x19A1E88", VA = "0x19A1E88")]
			internal void <DOValue>b__1(float x)
			{
			}
		}

		[Token(Token = "0x200006B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7789A4", Offset = "0x7789A4")]
		private sealed class <>c__DisplayClass34_0
		{
			[Token(Token = "0x4000170")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Text target;

			[Token(Token = "0x6000324")]
			[Address(RVA = "0x19A1EAC", Offset = "0x19A1EAC", VA = "0x19A1EAC")]
			public <>c__DisplayClass34_0()
			{
			}

			[Token(Token = "0x6000325")]
			[Address(RVA = "0x19A1EB4", Offset = "0x19A1EB4", VA = "0x19A1EB4")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000326")]
			[Address(RVA = "0x19A1ED8", Offset = "0x19A1ED8", VA = "0x19A1ED8")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x200006C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7789B4", Offset = "0x7789B4")]
		private sealed class <>c__DisplayClass35_0
		{
			[Token(Token = "0x4000171")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int v;

			[Token(Token = "0x4000172")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Text target;

			[Token(Token = "0x4000173")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool addThousandsSeparator;

			[Token(Token = "0x4000174")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public CultureInfo cInfo;

			[Token(Token = "0x6000327")]
			[Address(RVA = "0x19A1EFC", Offset = "0x19A1EFC", VA = "0x19A1EFC")]
			public <>c__DisplayClass35_0()
			{
			}

			[Token(Token = "0x6000328")]
			[Address(RVA = "0x19A1F04", Offset = "0x19A1F04", VA = "0x19A1F04")]
			internal int <DOCounter>b__0()
			{
				return default(int);
			}

			[Token(Token = "0x6000329")]
			[Address(RVA = "0x19A1F0C", Offset = "0x19A1F0C", VA = "0x19A1F0C")]
			internal void <DOCounter>b__1(int x)
			{
			}
		}

		[Token(Token = "0x200006D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7789C4", Offset = "0x7789C4")]
		private sealed class <>c__DisplayClass36_0
		{
			[Token(Token = "0x4000175")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Text target;

			[Token(Token = "0x600032A")]
			[Address(RVA = "0x19A1FA8", Offset = "0x19A1FA8", VA = "0x19A1FA8")]
			public <>c__DisplayClass36_0()
			{
			}

			[Token(Token = "0x600032B")]
			[Address(RVA = "0x19A1FB0", Offset = "0x19A1FB0", VA = "0x19A1FB0")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x600032C")]
			[Address(RVA = "0x19A1FD4", Offset = "0x19A1FD4", VA = "0x19A1FD4")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x200006E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7789D4", Offset = "0x7789D4")]
		private sealed class <>c__DisplayClass37_0
		{
			[Token(Token = "0x4000176")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Text target;

			[Token(Token = "0x600032D")]
			[Address(RVA = "0x19A1FF8", Offset = "0x19A1FF8", VA = "0x19A1FF8")]
			public <>c__DisplayClass37_0()
			{
			}

			[Token(Token = "0x600032E")]
			[Address(RVA = "0x19A2000", Offset = "0x19A2000", VA = "0x19A2000")]
			internal string <DOText>b__0()
			{
				return null;
			}

			[Token(Token = "0x600032F")]
			[Address(RVA = "0x19A2024", Offset = "0x19A2024", VA = "0x19A2024")]
			internal void <DOText>b__1(string x)
			{
			}
		}

		[Token(Token = "0x200006F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7789E4", Offset = "0x7789E4")]
		private sealed class <>c__DisplayClass38_0
		{
			[Token(Token = "0x4000177")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x4000178")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Graphic target;

			[Token(Token = "0x6000330")]
			[Address(RVA = "0x19A2048", Offset = "0x19A2048", VA = "0x19A2048")]
			public <>c__DisplayClass38_0()
			{
			}

			[Token(Token = "0x6000331")]
			[Address(RVA = "0x19A2050", Offset = "0x19A2050", VA = "0x19A2050")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000332")]
			[Address(RVA = "0x19A205C", Offset = "0x19A205C", VA = "0x19A205C")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000070")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7789F4", Offset = "0x7789F4")]
		private sealed class <>c__DisplayClass39_0
		{
			[Token(Token = "0x4000179")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x400017A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Image target;

			[Token(Token = "0x6000333")]
			[Address(RVA = "0x19A2118", Offset = "0x19A2118", VA = "0x19A2118")]
			public <>c__DisplayClass39_0()
			{
			}

			[Token(Token = "0x6000334")]
			[Address(RVA = "0x19A2120", Offset = "0x19A2120", VA = "0x19A2120")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000335")]
			[Address(RVA = "0x19A212C", Offset = "0x19A212C", VA = "0x19A212C")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000071")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778A04", Offset = "0x778A04")]
		private sealed class <>c__DisplayClass40_0
		{
			[Token(Token = "0x400017B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x400017C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Text target;

			[Token(Token = "0x6000336")]
			[Address(RVA = "0x19A2238", Offset = "0x19A2238", VA = "0x19A2238")]
			public <>c__DisplayClass40_0()
			{
			}

			[Token(Token = "0x6000337")]
			[Address(RVA = "0x19A2240", Offset = "0x19A2240", VA = "0x19A2240")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000338")]
			[Address(RVA = "0x19A224C", Offset = "0x19A224C", VA = "0x19A224C")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x9A99AC", Offset = "0x9A99AC", VA = "0x9A99AC")]
		public static TweenerCore<float, float, FloatOptions> DOFade(this CanvasGroup target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x9A9164", Offset = "0x9A9164", VA = "0x9A9164")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Graphic target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x9A967C", Offset = "0x9A967C", VA = "0x9A967C")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Graphic target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x9AE3E0", Offset = "0x9AE3E0", VA = "0x9AE3E0")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Image target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x9AE5A0", Offset = "0x9AE5A0", VA = "0x9AE5A0")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Image target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x9AE738", Offset = "0x9AE738", VA = "0x9AE738")]
		public static TweenerCore<float, float, FloatOptions> DOFillAmount(this Image target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x9AE8F4", Offset = "0x9AE8F4", VA = "0x9AE8F4")]
		public static Sequence DOGradientColor(this Image target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x9AEAE8", Offset = "0x9AEAE8", VA = "0x9AEAE8")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOFlexibleSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x9AECA0", Offset = "0x9AECA0", VA = "0x9AECA0")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMinSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x9AEE58", Offset = "0x9AEE58", VA = "0x9AEE58")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPreferredSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x9AF010", Offset = "0x9AF010", VA = "0x9AF010")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Outline target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x9AF1D0", Offset = "0x9AF1D0", VA = "0x9AF1D0")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Outline target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x9AF368", Offset = "0x9AF368", VA = "0x9AF368")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOScale(this Outline target, Vector2 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x9AF510", Offset = "0x9AF510", VA = "0x9AF510")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPos(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x9AF6C8", Offset = "0x9AF6C8", VA = "0x9AF6C8")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosX(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x9AF878", Offset = "0x9AF878", VA = "0x9AF878")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosY(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x9A8538", Offset = "0x9A8538", VA = "0x9A8538")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3D(this RectTransform target, Vector3 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x9AFA28", Offset = "0x9AFA28", VA = "0x9AFA28")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DX(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x9AFBDC", Offset = "0x9AFBDC", VA = "0x9AFBDC")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DY(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x9AFD90", Offset = "0x9AFD90", VA = "0x9AFD90")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DZ(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x9AFF44", Offset = "0x9AFF44", VA = "0x9AFF44")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMax(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x9B00FC", Offset = "0x9B00FC", VA = "0x9B00FC")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMin(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x9B02B4", Offset = "0x9B02B4", VA = "0x9B02B4")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivot(this RectTransform target, Vector2 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x9B045C", Offset = "0x9B045C", VA = "0x9B045C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotX(this RectTransform target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x9B0608", Offset = "0x9B0608", VA = "0x9B0608")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotY(this RectTransform target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x9A8DEC", Offset = "0x9A8DEC", VA = "0x9A8DEC")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOSizeDelta(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x9A9D88", Offset = "0x9A9D88", VA = "0x9A9D88")]
		public static Tweener DOPunchAnchorPos(this RectTransform target, Vector2 punch, float duration, int vibrato = 10, float elasticity = 1f, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x9B07B4", Offset = "0x9B07B4", VA = "0x9B07B4")]
		public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, float strength = 100f, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x9A9F50", Offset = "0x9A9F50", VA = "0x9A9F50")]
		public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, Vector2 strength, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x9B099C", Offset = "0x9B099C", VA = "0x9B099C")]
		public static Sequence DOJumpAnchorPos(this RectTransform target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x9B0DC8", Offset = "0x9B0DC8", VA = "0x9B0DC8")]
		public static Tweener DONormalizedPos(this ScrollRect target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x9B0F74", Offset = "0x9B0F74", VA = "0x9B0F74")]
		public static Tweener DOHorizontalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x9B1110", Offset = "0x9B1110", VA = "0x9B1110")]
		public static Tweener DOVerticalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x9B12AC", Offset = "0x9B12AC", VA = "0x9B12AC")]
		public static TweenerCore<float, float, FloatOptions> DOValue(this Slider target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x9A9324", Offset = "0x9A9324", VA = "0x9A9324")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Text target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x9B1454", Offset = "0x9B1454", VA = "0x9B1454")]
		public static TweenerCore<int, int, NoOptions> DOCounter(this Text target, int fromValue, int endValue, float duration, bool addThousandsSeparator = true, [Optional] CultureInfo culture)
		{
			return null;
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x9A9814", Offset = "0x9A9814", VA = "0x9A9814")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Text target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x9A9B44", Offset = "0x9A9B44", VA = "0x9A9B44")]
		public static TweenerCore<string, string, StringOptions> DOText(this Text target, string endValue, float duration, bool richTextEnabled = true, ScrambleMode scrambleMode = ScrambleMode.None, [Optional] string scrambleChars)
		{
			return null;
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x9B1658", Offset = "0x9B1658", VA = "0x9B1658")]
		public static Tweener DOBlendableColor(this Graphic target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x9B18AC", Offset = "0x9B18AC", VA = "0x9B18AC")]
		public static Tweener DOBlendableColor(this Image target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x9B1B00", Offset = "0x9B1B00", VA = "0x9B1B00")]
		public static Tweener DOBlendableColor(this Text target, Color endValue, float duration)
		{
			return null;
		}
	}
	[Token(Token = "0x2000072")]
	public static class DOTweenModuleUnityVersion
	{
		[Token(Token = "0x2000073")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778A24", Offset = "0x778A24")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x400017D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Material target;

			[Token(Token = "0x400017E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int propertyID;

			[Token(Token = "0x6000349")]
			[Address(RVA = "0x19A2834", Offset = "0x19A2834", VA = "0x19A2834")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x600034A")]
			[Address(RVA = "0x19A283C", Offset = "0x19A283C", VA = "0x19A283C")]
			internal Vector2 <DOOffset>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x600034B")]
			[Address(RVA = "0x19A2860", Offset = "0x19A2860", VA = "0x19A2860")]
			internal void <DOOffset>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000074")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778A34", Offset = "0x778A34")]
		private sealed class <>c__DisplayClass9_0
		{
			[Token(Token = "0x400017F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Material target;

			[Token(Token = "0x4000180")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int propertyID;

			[Token(Token = "0x600034C")]
			[Address(RVA = "0x19A2884", Offset = "0x19A2884", VA = "0x19A2884")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x600034D")]
			[Address(RVA = "0x19A288C", Offset = "0x19A288C", VA = "0x19A288C")]
			internal Vector2 <DOTiling>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x600034E")]
			[Address(RVA = "0x19A28B0", Offset = "0x19A28B0", VA = "0x19A28B0")]
			internal void <DOTiling>b__1(Vector2 x)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000075")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778A44", Offset = "0x778A44")]
		private struct <AsyncWaitForCompletion>d__10 : IAsyncStateMachine
		{
			[Token(Token = "0x4000181")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000182")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000183")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x4000184")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x600034F")]
			[Address(RVA = "0x19A28D4", Offset = "0x19A28D4", VA = "0x19A28D4", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000350")]
			[Address(RVA = "0x19A2B18", Offset = "0x19A2B18", VA = "0x19A2B18", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000076")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778A54", Offset = "0x778A54")]
		private struct <AsyncWaitForRewind>d__11 : IAsyncStateMachine
		{
			[Token(Token = "0x4000185")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000186")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000187")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x4000188")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x6000351")]
			[Address(RVA = "0x19A3228", Offset = "0x19A3228", VA = "0x19A3228", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000352")]
			[Address(RVA = "0x19A3490", Offset = "0x19A3490", VA = "0x19A3490", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000077")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778A64", Offset = "0x778A64")]
		private struct <AsyncWaitForKill>d__12 : IAsyncStateMachine
		{
			[Token(Token = "0x4000189")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x400018A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x400018B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x400018C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x6000353")]
			[Address(RVA = "0x19A2D7C", Offset = "0x19A2D7C", VA = "0x19A2D7C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000354")]
			[Address(RVA = "0x19A2FAC", Offset = "0x19A2FAC", VA = "0x19A2FAC", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000078")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778A74", Offset = "0x778A74")]
		private struct <AsyncWaitForElapsedLoops>d__13 : IAsyncStateMachine
		{
			[Token(Token = "0x400018D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x400018E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x400018F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x4000190")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int elapsedLoops;

			[Token(Token = "0x4000191")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x6000355")]
			[Address(RVA = "0x19A2B24", Offset = "0x19A2B24", VA = "0x19A2B24", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000356")]
			[Address(RVA = "0x19A2D70", Offset = "0x19A2D70", VA = "0x19A2D70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000079")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778A84", Offset = "0x778A84")]
		private struct <AsyncWaitForPosition>d__14 : IAsyncStateMachine
		{
			[Token(Token = "0x4000192")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000193")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000194")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x4000195")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float position;

			[Token(Token = "0x4000196")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x6000357")]
			[Address(RVA = "0x19A2FB8", Offset = "0x19A2FB8", VA = "0x19A2FB8", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000358")]
			[Address(RVA = "0x19A321C", Offset = "0x19A321C", VA = "0x19A321C", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200007A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778A94", Offset = "0x778A94")]
		private struct <AsyncWaitForStart>d__15 : IAsyncStateMachine
		{
			[Token(Token = "0x4000197")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000198")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000199")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x400019A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x6000359")]
			[Address(RVA = "0x19A349C", Offset = "0x19A349C", VA = "0x19A349C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x600035A")]
			[Address(RVA = "0x19A36D4", Offset = "0x19A36D4", VA = "0x19A36D4", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x9B1D54", Offset = "0x9B1D54", VA = "0x9B1D54")]
		public static Sequence DOGradientColor(this Material target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x9B1F44", Offset = "0x9B1F44", VA = "0x9B1F44")]
		public static Sequence DOGradientColor(this Material target, Gradient gradient, string property, float duration)
		{
			return null;
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x9B2148", Offset = "0x9B2148", VA = "0x9B2148")]
		public static CustomYieldInstruction WaitForCompletion(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x9B2208", Offset = "0x9B2208", VA = "0x9B2208")]
		public static CustomYieldInstruction WaitForRewind(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x9B22C8", Offset = "0x9B22C8", VA = "0x9B22C8")]
		public static CustomYieldInstruction WaitForKill(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x9B2388", Offset = "0x9B2388", VA = "0x9B2388")]
		public static CustomYieldInstruction WaitForElapsedLoops(this Tween t, int elapsedLoops, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x9B2458", Offset = "0x9B2458", VA = "0x9B2458")]
		public static CustomYieldInstruction WaitForPosition(this Tween t, float position, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x9B2528", Offset = "0x9B2528", VA = "0x9B2528")]
		public static CustomYieldInstruction WaitForStart(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x9B25E8", Offset = "0x9B25E8", VA = "0x9B25E8")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOOffset(this Material target, Vector2 endValue, int propertyID, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x9B2800", Offset = "0x9B2800", VA = "0x9B2800")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOTiling(this Material target, Vector2 endValue, int propertyID, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x9B2A18", Offset = "0x9B2A18", VA = "0x9B2A18")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x77B440", Offset = "0x77B440")]
		public static Task AsyncWaitForCompletion(this Tween t)
		{
			return null;
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x9B2B1C", Offset = "0x9B2B1C", VA = "0x9B2B1C")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x77B4B0", Offset = "0x77B4B0")]
		public static Task AsyncWaitForRewind(this Tween t)
		{
			return null;
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x9B2C20", Offset = "0x9B2C20", VA = "0x9B2C20")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x77B520", Offset = "0x77B520")]
		public static Task AsyncWaitForKill(this Tween t)
		{
			return null;
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x9B2D24", Offset = "0x9B2D24", VA = "0x9B2D24")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x77B590", Offset = "0x77B590")]
		public static Task AsyncWaitForElapsedLoops(this Tween t, int elapsedLoops)
		{
			return null;
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x9B2E38", Offset = "0x9B2E38", VA = "0x9B2E38")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x77B600", Offset = "0x77B600")]
		public static Task AsyncWaitForPosition(this Tween t, float position)
		{
			return null;
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x9B2F4C", Offset = "0x9B2F4C", VA = "0x9B2F4C")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x77B670", Offset = "0x77B670")]
		public static Task AsyncWaitForStart(this Tween t)
		{
			return null;
		}
	}
	[Token(Token = "0x200007B")]
	public static class DOTweenCYInstruction
	{
		[Token(Token = "0x200007C")]
		public class WaitForCompletion : CustomYieldInstruction
		{
			[Token(Token = "0x400019B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x17000052")]
			public override bool keepWaiting
			{
				[Token(Token = "0x600035B")]
				[Address(RVA = "0x19A0908", Offset = "0x19A0908", VA = "0x19A0908", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600035C")]
			[Address(RVA = "0x19A093C", Offset = "0x19A093C", VA = "0x19A093C")]
			public WaitForCompletion(Tween tween)
			{
			}
		}

		[Token(Token = "0x200007D")]
		public class WaitForRewind : CustomYieldInstruction
		{
			[Token(Token = "0x400019C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x17000053")]
			public override bool keepWaiting
			{
				[Token(Token = "0x600035D")]
				[Address(RVA = "0x19A0AD8", Offset = "0x19A0AD8", VA = "0x19A0AD8", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600035E")]
			[Address(RVA = "0x19A0B3C", Offset = "0x19A0B3C", VA = "0x19A0B3C")]
			public WaitForRewind(Tween tween)
			{
			}
		}

		[Token(Token = "0x200007E")]
		public class WaitForKill : CustomYieldInstruction
		{
			[Token(Token = "0x400019D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x17000054")]
			public override bool keepWaiting
			{
				[Token(Token = "0x600035F")]
				[Address(RVA = "0x19A09F0", Offset = "0x19A09F0", VA = "0x19A09F0", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000360")]
			[Address(RVA = "0x19A0A0C", Offset = "0x19A0A0C", VA = "0x19A0A0C")]
			public WaitForKill(Tween tween)
			{
			}
		}

		[Token(Token = "0x200007F")]
		public class WaitForElapsedLoops : CustomYieldInstruction
		{
			[Token(Token = "0x400019E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x400019F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private readonly int elapsedLoops;

			[Token(Token = "0x17000055")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6000361")]
				[Address(RVA = "0x19A0968", Offset = "0x19A0968", VA = "0x19A0968", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000362")]
			[Address(RVA = "0x19A09B4", Offset = "0x19A09B4", VA = "0x19A09B4")]
			public WaitForElapsedLoops(Tween tween, int elapsedLoops)
			{
			}
		}

		[Token(Token = "0x2000080")]
		public class WaitForPosition : CustomYieldInstruction
		{
			[Token(Token = "0x40001A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x40001A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private readonly float position;

			[Token(Token = "0x17000056")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6000363")]
				[Address(RVA = "0x19A0A38", Offset = "0x19A0A38", VA = "0x19A0A38", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000364")]
			[Address(RVA = "0x19A0A9C", Offset = "0x19A0A9C", VA = "0x19A0A9C")]
			public WaitForPosition(Tween tween, float position)
			{
			}
		}

		[Token(Token = "0x2000081")]
		public class WaitForStart : CustomYieldInstruction
		{
			[Token(Token = "0x40001A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x17000057")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6000365")]
				[Address(RVA = "0x19A0B68", Offset = "0x19A0B68", VA = "0x19A0B68", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000366")]
			[Address(RVA = "0x19A0B9C", Offset = "0x19A0B9C", VA = "0x19A0B9C")]
			public WaitForStart(Tween tween)
			{
			}
		}
	}
	[Token(Token = "0x2000082")]
	public static class DOTweenModuleUtils
	{
		[Token(Token = "0x2000083")]
		public static class Physics
		{
			[Token(Token = "0x6000369")]
			[Address(RVA = "0x19A36E0", Offset = "0x19A36E0", VA = "0x19A36E0")]
			public static void SetOrientationOnPath(PathOptions options, Tween t, Quaternion newRot, Transform trans)
			{
			}

			[Token(Token = "0x600036A")]
			[Address(RVA = "0x19A37E4", Offset = "0x19A37E4", VA = "0x19A37E4")]
			public static bool HasRigidbody2D(Component target)
			{
				return default(bool);
			}

			[Token(Token = "0x600036B")]
			[Address(RVA = "0x19A387C", Offset = "0x19A387C", VA = "0x19A387C")]
			[Preserve]
			public static bool HasRigidbody(Component target)
			{
				return default(bool);
			}

			[Token(Token = "0x600036C")]
			[Address(RVA = "0x19A3914", Offset = "0x19A3914", VA = "0x19A3914")]
			[Preserve]
			public static TweenerCore<Vector3, Path, PathOptions> CreateDOTweenPathTween(MonoBehaviour target, bool tweenRigidbody, bool isLocal, Path path, float duration, PathMode pathMode)
			{
				return null;
			}
		}

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool _initialized;

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x9B3050", Offset = "0x9B3050", VA = "0x9B3050")]
		[Preserve]
		public static void Init()
		{
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0x9B3114", Offset = "0x9B3114", VA = "0x9B3114")]
		[Preserve]
		private static void Preserver()
		{
		}
	}
	[Token(Token = "0x2000084")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x778AA4", Offset = "0x778AA4")]
	public class DOTweenAnimation : ABSAnimationComponent
	{
		[Token(Token = "0x2000085")]
		public enum AnimationType
		{
			[Token(Token = "0x40001CB")]
			None,
			[Token(Token = "0x40001CC")]
			Move,
			[Token(Token = "0x40001CD")]
			LocalMove,
			[Token(Token = "0x40001CE")]
			Rotate,
			[Token(Token = "0x40001CF")]
			LocalRotate,
			[Token(Token = "0x40001D0")]
			Scale,
			[Token(Token = "0x40001D1")]
			Color,
			[Token(Token = "0x40001D2")]
			Fade,
			[Token(Token = "0x40001D3")]
			Text,
			[Token(Token = "0x40001D4")]
			PunchPosition,
			[Token(Token = "0x40001D5")]
			PunchRotation,
			[Token(Token = "0x40001D6")]
			PunchScale,
			[Token(Token = "0x40001D7")]
			ShakePosition,
			[Token(Token = "0x40001D8")]
			ShakeRotation,
			[Token(Token = "0x40001D9")]
			ShakeScale,
			[Token(Token = "0x40001DA")]
			CameraAspect,
			[Token(Token = "0x40001DB")]
			CameraBackgroundColor,
			[Token(Token = "0x40001DC")]
			CameraFieldOfView,
			[Token(Token = "0x40001DD")]
			CameraOrthoSize,
			[Token(Token = "0x40001DE")]
			CameraPixelRect,
			[Token(Token = "0x40001DF")]
			CameraRect,
			[Token(Token = "0x40001E0")]
			UIWidthHeight
		}

		[Token(Token = "0x2000086")]
		public enum TargetType
		{
			[Token(Token = "0x40001E2")]
			Unset,
			[Token(Token = "0x40001E3")]
			Camera,
			[Token(Token = "0x40001E4")]
			CanvasGroup,
			[Token(Token = "0x40001E5")]
			Image,
			[Token(Token = "0x40001E6")]
			Light,
			[Token(Token = "0x40001E7")]
			RectTransform,
			[Token(Token = "0x40001E8")]
			Renderer,
			[Token(Token = "0x40001E9")]
			SpriteRenderer,
			[Token(Token = "0x40001EA")]
			Rigidbody,
			[Token(Token = "0x40001EB")]
			Rigidbody2D,
			[Token(Token = "0x40001EC")]
			Text,
			[Token(Token = "0x40001ED")]
			Transform,
			[Token(Token = "0x40001EE")]
			tk2dBaseSprite,
			[Token(Token = "0x40001EF")]
			tk2dTextMesh,
			[Token(Token = "0x40001F0")]
			TextMeshPro,
			[Token(Token = "0x40001F1")]
			TextMeshProUGUI
		}

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool targetIsSelf;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public GameObject targetGO;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool tweenTargetIsTargetGO;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public float delay;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public float duration;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public Ease easeType;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public AnimationCurve easeCurve;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public LoopType loopType;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public int loops;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public string id;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public bool isRelative;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
		public bool isFrom;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA2")]
		public bool isIndependentUpdate;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA3")]
		public bool autoKill;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public bool isActive;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA5")]
		public bool isValid;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Component target;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public AnimationType animationType;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public TargetType targetType;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public TargetType forcedTargetType;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public bool autoPlay;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBD")]
		public bool useTargetAsV3;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public float endValueFloat;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public Vector3 endValueV3;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Vector2 endValueV2;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public Color endValueColor;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public string endValueString;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public Rect endValueRect;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public Transform endValueTransform;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public bool optionalBool0;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		public float optionalFloat0;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public int optionalInt0;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		public RotateMode optionalRotationMode;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public ScrambleMode optionalScrambleMode;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public string optionalString;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private bool _tweenCreated;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private int _playCount;

		[Token(Token = "0x14000002")]
		public static event Action<DOTweenAnimation> OnReset
		{
			[Token(Token = "0x600036D")]
			[Address(RVA = "0x9A6B34", Offset = "0x9A6B34", VA = "0x9A6B34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B780", Offset = "0x77B780")]
			add
			{
			}
			[Token(Token = "0x600036E")]
			[Address(RVA = "0x9A6BF0", Offset = "0x9A6BF0", VA = "0x9A6BF0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B790", Offset = "0x77B790")]
			remove
			{
			}
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x9A6CAC", Offset = "0x9A6CAC", VA = "0x9A6CAC")]
		private static void Dispatch_OnReset(DOTweenAnimation anim)
		{
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x9A6D28", Offset = "0x9A6D28", VA = "0x9A6D28")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x9A8270", Offset = "0x9A8270", VA = "0x9A8270")]
		private void Start()
		{
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x9A82B4", Offset = "0x9A82B4", VA = "0x9A82B4")]
		private void Reset()
		{
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x9A82B8", Offset = "0x9A82B8", VA = "0x9A82B8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x9A6D78", Offset = "0x9A6D78", VA = "0x9A6D78")]
		public void CreateTween()
		{
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x9AA140", Offset = "0x9AA140", VA = "0x9AA140", Slot = "4")]
		public override void DOPlay()
		{
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x9AA1B8", Offset = "0x9AA1B8", VA = "0x9AA1B8", Slot = "5")]
		public override void DOPlayBackwards()
		{
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x9AA230", Offset = "0x9AA230", VA = "0x9AA230", Slot = "6")]
		public override void DOPlayForward()
		{
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x9AA2A8", Offset = "0x9AA2A8", VA = "0x9AA2A8", Slot = "7")]
		public override void DOPause()
		{
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x9AA320", Offset = "0x9AA320", VA = "0x9AA320", Slot = "8")]
		public override void DOTogglePause()
		{
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x9AA398", Offset = "0x9AA398", VA = "0x9AA398", Slot = "9")]
		public override void DORewind()
		{
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x9AA490", Offset = "0x9AA490", VA = "0x9AA490", Slot = "10")]
		public override void DORestart()
		{
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x9AA4A0", Offset = "0x9AA4A0", VA = "0x9AA4A0", Slot = "11")]
		public override void DORestart(bool fromHere)
		{
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x9AA81C", Offset = "0x9AA81C", VA = "0x9AA81C", Slot = "12")]
		public override void DOComplete()
		{
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x9AA898", Offset = "0x9AA898", VA = "0x9AA898", Slot = "13")]
		public override void DOKill()
		{
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x9AA91C", Offset = "0x9AA91C", VA = "0x9AA91C")]
		public void DOPlayById(string id)
		{
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x9AA9A4", Offset = "0x9AA9A4", VA = "0x9AA9A4")]
		public void DOPlayAllById(string id)
		{
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x9AAA08", Offset = "0x9AAA08", VA = "0x9AAA08")]
		public void DOPauseAllById(string id)
		{
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x9AAA6C", Offset = "0x9AAA6C", VA = "0x9AAA6C")]
		public void DOPlayBackwardsById(string id)
		{
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x9AAAF4", Offset = "0x9AAAF4", VA = "0x9AAAF4")]
		public void DOPlayBackwardsAllById(string id)
		{
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x9AAB58", Offset = "0x9AAB58", VA = "0x9AAB58")]
		public void DOPlayForwardById(string id)
		{
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x9AABE0", Offset = "0x9AABE0", VA = "0x9AABE0")]
		public void DOPlayForwardAllById(string id)
		{
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x9AAC44", Offset = "0x9AAC44", VA = "0x9AAC44")]
		public void DOPlayNext()
		{
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x9AAD8C", Offset = "0x9AAD8C", VA = "0x9AAD8C")]
		public void DORewindAndPlayNext()
		{
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x9AAE18", Offset = "0x9AAE18", VA = "0x9AAE18")]
		public void DORewindAllById(string id)
		{
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x9AAE94", Offset = "0x9AAE94", VA = "0x9AAE94")]
		public void DORestartById(string id)
		{
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x9AAF2C", Offset = "0x9AAF2C", VA = "0x9AAF2C")]
		public void DORestartAllById(string id)
		{
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x9AAFAC", Offset = "0x9AAFAC", VA = "0x9AAFAC")]
		public List<Tween> GetTweens()
		{
			return null;
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x9A8314", Offset = "0x9A8314", VA = "0x9A8314")]
		public static TargetType TypeToDOTargetType(Type t)
		{
			return default(TargetType);
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x9AB0B8", Offset = "0x9AB0B8", VA = "0x9AB0B8")]
		public Tween CreateEditorPreview()
		{
			return null;
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x9A82FC", Offset = "0x9A82FC", VA = "0x9A82FC")]
		private GameObject GetTweenGO()
		{
			return null;
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x9AA5B4", Offset = "0x9AA5B4", VA = "0x9AA5B4")]
		private void ReEvaluateRelativeTween()
		{
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x9AB0F4", Offset = "0x9AB0F4", VA = "0x9AB0F4")]
		public DOTweenAnimation()
		{
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x9AB2E4", Offset = "0x9AB2E4", VA = "0x9AB2E4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B7A0", Offset = "0x77B7A0")]
		private void <CreateTween>b__47_0()
		{
		}
	}
	[Token(Token = "0x2000087")]
	public static class DOTweenAnimationExtensions
	{
		[Token(Token = "0x6000392")]
		public static bool IsSameOrSubclassOf<T>(this Component t)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000088")]
	public static class DOTweenProShortcuts
	{
		[Token(Token = "0x2000089")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778AFC", Offset = "0x778AFC")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x40001F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform target;

			[Token(Token = "0x6000396")]
			[Address(RVA = "0x19A3A68", Offset = "0x19A3A68", VA = "0x19A3A68")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x6000397")]
			[Address(RVA = "0x19A3A70", Offset = "0x19A3A70", VA = "0x19A3A70")]
			internal Vector3 <DOSpiral>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000398")]
			[Address(RVA = "0x19A3A8C", Offset = "0x19A3A8C", VA = "0x19A3A8C")]
			internal void <DOSpiral>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x200008A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778B0C", Offset = "0x778B0C")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x40001F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x6000399")]
			[Address(RVA = "0x19A3AA8", Offset = "0x19A3AA8", VA = "0x19A3AA8")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x600039A")]
			[Address(RVA = "0x19A3AB0", Offset = "0x19A3AB0", VA = "0x19A3AB0")]
			internal Vector3 <DOSpiral>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x9B31C8", Offset = "0x9B31C8", VA = "0x9B31C8")]
		static DOTweenProShortcuts()
		{
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x9B3214", Offset = "0x9B3214", VA = "0x9B3214")]
		public static Tweener DOSpiral(this Transform target, float duration, [Optional] Vector3? axis, SpiralMode mode = SpiralMode.Expand, float speed = 1f, float frequency = 10f, float depth = 0f, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x9B352C", Offset = "0x9B352C", VA = "0x9B352C")]
		public static Tweener DOSpiral(this Rigidbody target, float duration, [Optional] Vector3? axis, SpiralMode mode = SpiralMode.Expand, float speed = 1f, float frequency = 10f, float depth = 0f, bool snapping = false)
		{
			return null;
		}
	}
}
