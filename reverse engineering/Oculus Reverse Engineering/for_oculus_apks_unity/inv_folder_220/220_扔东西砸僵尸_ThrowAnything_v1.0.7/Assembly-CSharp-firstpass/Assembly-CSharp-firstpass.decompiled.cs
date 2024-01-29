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
	[Token(Token = "0x2000033")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4F3EF8", Offset = "0x4F3EF8")]
	private sealed class <Delay>d__0 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float timeToDelay;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x17000013")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x60001FC")]
			[Address(RVA = "0xB295A0", Offset = "0xB295A0", VA = "0xB295A0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000014")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001FE")]
			[Address(RVA = "0xB29608", Offset = "0xB29608", VA = "0xB29608", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0xB27B8C", Offset = "0xB27B8C", VA = "0xB27B8C")]
		[DebuggerHidden]
		public <Delay>d__0(int <>1__state)
		{
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0xB293F0", Offset = "0xB293F0", VA = "0xB293F0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0xB293F4", Offset = "0xB293F4", VA = "0xB293F4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0xB295A8", Offset = "0xB295A8", VA = "0xB295A8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000034")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4F3F08", Offset = "0x4F3F08")]
	private sealed class <Delay>d__1 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Func<bool> condition;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x17000015")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x6000202")]
			[Address(RVA = "0xB297F8", Offset = "0xB297F8", VA = "0xB297F8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000016")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000204")]
			[Address(RVA = "0xB29860", Offset = "0xB29860", VA = "0xB29860", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0xB27C34", Offset = "0xB27C34", VA = "0xB27C34")]
		[DebuggerHidden]
		public <Delay>d__1(int <>1__state)
		{
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0xB2966C", Offset = "0xB2966C", VA = "0xB2966C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0xB29670", Offset = "0xB29670", VA = "0xB29670", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0xB29800", Offset = "0xB29800", VA = "0xB29800", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000035")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4F3F18", Offset = "0x4F3F18")]
	private sealed class <Delay>d__2<T> : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <>1__state;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float <>2__current;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Func<T, bool> condition;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T data;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x17000017")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x6000208")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000018")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600020A")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000205")]
		[DebuggerHidden]
		public <Delay>d__2(int <>1__state)
		{
		}

		[Token(Token = "0x6000206")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000207")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000209")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000036")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4F3F28", Offset = "0x4F3F28")]
	private sealed class <DelayFrames>d__3 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int framesToDelay;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x17000019")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x600020E")]
			[Address(RVA = "0xB29A44", Offset = "0xB29A44", VA = "0xB29A44", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700001A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000210")]
			[Address(RVA = "0xB29AAC", Offset = "0xB29AAC", VA = "0xB29AAC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0xB27CE0", Offset = "0xB27CE0", VA = "0xB27CE0")]
		[DebuggerHidden]
		public <DelayFrames>d__3(int <>1__state)
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0xB298C4", Offset = "0xB298C4", VA = "0xB298C4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0xB298C8", Offset = "0xB298C8", VA = "0xB298C8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0xB29A4C", Offset = "0xB29A4C", VA = "0xB29A4C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000037")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4F3F38", Offset = "0x4F3F38")]
	private sealed class <CancelWith>d__4 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject gameObject;

		[Token(Token = "0x1700001B")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x6000214")]
			[Address(RVA = "0xB28D18", Offset = "0xB28D18", VA = "0xB28D18", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700001C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000216")]
			[Address(RVA = "0xB28D80", Offset = "0xB28D80", VA = "0xB28D80", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0xB27D88", Offset = "0xB27D88", VA = "0xB27D88")]
		[DebuggerHidden]
		public <CancelWith>d__4(int <>1__state)
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0xB28AF4", Offset = "0xB28AF4", VA = "0xB28AF4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0xB28AF8", Offset = "0xB28AF8", VA = "0xB28AF8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0xB28D20", Offset = "0xB28D20", VA = "0xB28D20", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000038")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4F3F48", Offset = "0x4F3F48")]
	private sealed class <CancelWith>d__5 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject gameObject1;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject gameObject2;

		[Token(Token = "0x1700001D")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x600021A")]
			[Address(RVA = "0xB29048", Offset = "0xB29048", VA = "0xB29048", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700001E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600021C")]
			[Address(RVA = "0xB290B0", Offset = "0xB290B0", VA = "0xB290B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0xB27E38", Offset = "0xB27E38", VA = "0xB27E38")]
		[DebuggerHidden]
		public <CancelWith>d__5(int <>1__state)
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0xB28DE4", Offset = "0xB28DE4", VA = "0xB28DE4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0xB28DE8", Offset = "0xB28DE8", VA = "0xB28DE8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0xB29050", Offset = "0xB29050", VA = "0xB29050", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000039")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4F3F58", Offset = "0x4F3F58")]
	private sealed class <CancelWith>d__6 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Func<bool> condition;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x1700001F")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x6000220")]
			[Address(RVA = "0xB29324", Offset = "0xB29324", VA = "0xB29324", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000020")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000222")]
			[Address(RVA = "0xB2938C", Offset = "0xB2938C", VA = "0xB2938C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0xB27EE0", Offset = "0xB27EE0", VA = "0xB27EE0")]
		[DebuggerHidden]
		public <CancelWith>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0xB29114", Offset = "0xB29114", VA = "0xB29114", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0xB29118", Offset = "0xB29118", VA = "0xB29118", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0xB2932C", Offset = "0xB2932C", VA = "0xB2932C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200003A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4F3F68", Offset = "0x4F3F68")]
	private sealed class <PauseWith>d__7 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject gameObject;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x17000021")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x6000226")]
			[Address(RVA = "0xB29F98", Offset = "0xB29F98", VA = "0xB29F98", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000022")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000228")]
			[Address(RVA = "0xB2A000", Offset = "0xB2A000", VA = "0xB2A000", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0xB27F88", Offset = "0xB27F88", VA = "0xB27F88")]
		[DebuggerHidden]
		public <PauseWith>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0xB29D6C", Offset = "0xB29D6C", VA = "0xB29D6C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0xB29D70", Offset = "0xB29D70", VA = "0xB29D70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0xB29FA0", Offset = "0xB29FA0", VA = "0xB29FA0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200003B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4F3F78", Offset = "0x4F3F78")]
	private sealed class <PauseWith>d__8 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject gameObject1;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject gameObject2;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x17000023")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x600022C")]
			[Address(RVA = "0xB2A2D4", Offset = "0xB2A2D4", VA = "0xB2A2D4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000024")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600022E")]
			[Address(RVA = "0xB2A33C", Offset = "0xB2A33C", VA = "0xB2A33C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0xB28038", Offset = "0xB28038", VA = "0xB28038")]
		[DebuggerHidden]
		public <PauseWith>d__8(int <>1__state)
		{
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0xB2A064", Offset = "0xB2A064", VA = "0xB2A064", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0xB2A068", Offset = "0xB2A068", VA = "0xB2A068", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0xB2A2DC", Offset = "0xB2A2DC", VA = "0xB2A2DC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200003C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4F3F88", Offset = "0x4F3F88")]
	private sealed class <PauseWith>d__9 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Func<bool> condition;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x17000025")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x6000232")]
			[Address(RVA = "0xB2A5B0", Offset = "0xB2A5B0", VA = "0xB2A5B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000026")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000234")]
			[Address(RVA = "0xB2A618", Offset = "0xB2A618", VA = "0xB2A618", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0xB280E0", Offset = "0xB280E0", VA = "0xB280E0")]
		[DebuggerHidden]
		public <PauseWith>d__9(int <>1__state)
		{
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0xB2A3A0", Offset = "0xB2A3A0", VA = "0xB2A3A0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0xB2A3A4", Offset = "0xB2A3A4", VA = "0xB2A3A4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0xB2A5B8", Offset = "0xB2A5B8", VA = "0xB2A5B8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200003D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4F3F98", Offset = "0x4F3F98")]
	private sealed class <Append>d__10 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IEnumerator<float> nextCoroutine;

		[Token(Token = "0x17000027")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x6000238")]
			[Address(RVA = "0xB287F8", Offset = "0xB287F8", VA = "0xB287F8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000028")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600023A")]
			[Address(RVA = "0xB28860", Offset = "0xB28860", VA = "0xB28860", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0xB28188", Offset = "0xB28188", VA = "0xB28188")]
		[DebuggerHidden]
		public <Append>d__10(int <>1__state)
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0xB28584", Offset = "0xB28584", VA = "0xB28584", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0xB28588", Offset = "0xB28588", VA = "0xB28588", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0xB28800", Offset = "0xB28800", VA = "0xB28800", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200003E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4F3FA8", Offset = "0x4F3FA8")]
	private sealed class <Append>d__11 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Action onDone;

		[Token(Token = "0x17000029")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x600023E")]
			[Address(RVA = "0xB28A28", Offset = "0xB28A28", VA = "0xB28A28", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700002A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000240")]
			[Address(RVA = "0xB28A90", Offset = "0xB28A90", VA = "0xB28A90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0xB28230", Offset = "0xB28230", VA = "0xB28230")]
		[DebuggerHidden]
		public <Append>d__11(int <>1__state)
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0xB288C4", Offset = "0xB288C4", VA = "0xB288C4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0xB288C8", Offset = "0xB288C8", VA = "0xB288C8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0xB28A30", Offset = "0xB28A30", VA = "0xB28A30", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200003F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4F3FB8", Offset = "0x4F3FB8")]
	private sealed class <Prepend>d__12 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IEnumerator<float> lastCoroutine;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x1700002B")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x6000244")]
			[Address(RVA = "0xB2A904", Offset = "0xB2A904", VA = "0xB2A904", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700002C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000246")]
			[Address(RVA = "0xB2A96C", Offset = "0xB2A96C", VA = "0xB2A96C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0xB282D8", Offset = "0xB282D8", VA = "0xB282D8")]
		[DebuggerHidden]
		public <Prepend>d__12(int <>1__state)
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0xB2A67C", Offset = "0xB2A67C", VA = "0xB2A67C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0xB2A680", Offset = "0xB2A680", VA = "0xB2A680", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0xB2A90C", Offset = "0xB2A90C", VA = "0xB2A90C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000040")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4F3FC8", Offset = "0x4F3FC8")]
	private sealed class <Prepend>d__13 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Action onStart;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x1700002D")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x600024A")]
			[Address(RVA = "0xB2AB44", Offset = "0xB2AB44", VA = "0xB2AB44", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700002E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600024C")]
			[Address(RVA = "0xB2ABAC", Offset = "0xB2ABAC", VA = "0xB2ABAC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0xB28380", Offset = "0xB28380", VA = "0xB28380")]
		[DebuggerHidden]
		public <Prepend>d__13(int <>1__state)
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0xB2A9D0", Offset = "0xB2A9D0", VA = "0xB2A9D0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0xB2A9D4", Offset = "0xB2A9D4", VA = "0xB2A9D4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0xB2AB4C", Offset = "0xB2AB4C", VA = "0xB2AB4C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000041")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4F3FD8", Offset = "0x4F3FD8")]
	private sealed class <Superimpose>d__15 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IEnumerator<float> coroutineA;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Timing instance;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IEnumerator<float> coroutineB;

		[Token(Token = "0x1700002F")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x6000250")]
			[Address(RVA = "0xB2B224", Offset = "0xB2B224", VA = "0xB2B224", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000030")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000252")]
			[Address(RVA = "0xB2B28C", Offset = "0xB2B28C", VA = "0xB2B28C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0xB284B0", Offset = "0xB284B0", VA = "0xB284B0")]
		[DebuggerHidden]
		public <Superimpose>d__15(int <>1__state)
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0xB2AC10", Offset = "0xB2AC10", VA = "0xB2AC10", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0xB2AC14", Offset = "0xB2AC14", VA = "0xB2AC14", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0xB2B22C", Offset = "0xB2B22C", VA = "0xB2B22C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000042")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4F3FE8", Offset = "0x4F3FE8")]
	private sealed class <Hijack>d__16 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Func<float, float> newReturn;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x17000031")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x6000256")]
			[Address(RVA = "0xB29CA0", Offset = "0xB29CA0", VA = "0xB29CA0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000032")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000258")]
			[Address(RVA = "0xB29D08", Offset = "0xB29D08", VA = "0xB29D08", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0xB28558", Offset = "0xB28558", VA = "0xB28558")]
		[DebuggerHidden]
		public <Hijack>d__16(int <>1__state)
		{
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0xB29B10", Offset = "0xB29B10", VA = "0xB29B10", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0xB29B14", Offset = "0xB29B14", VA = "0xB29B14", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0xB29CA8", Offset = "0xB29CA8", VA = "0xB29CA8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x6000001")]
	[Address(RVA = "0xB27B0C", Offset = "0xB27B0C", VA = "0xB27B0C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x4F490C", Offset = "0x4F490C")]
	public static IEnumerator<float> Delay(this IEnumerator<float> coroutine, float timeToDelay)
	{
		return null;
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0xB27BB8", Offset = "0xB27BB8", VA = "0xB27BB8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x4F4980", Offset = "0x4F4980")]
	public static IEnumerator<float> Delay(this IEnumerator<float> coroutine, Func<bool> condition)
	{
		return null;
	}

	[Token(Token = "0x6000003")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x4F49F4", Offset = "0x4F49F4")]
	public static IEnumerator<float> Delay<T>(this IEnumerator<float> coroutine, T data, Func<T, bool> condition)
	{
		return null;
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0xB27C60", Offset = "0xB27C60", VA = "0xB27C60")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x4F4A68", Offset = "0x4F4A68")]
	public static IEnumerator<float> DelayFrames(this IEnumerator<float> coroutine, int framesToDelay)
	{
		return null;
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0xB27D0C", Offset = "0xB27D0C", VA = "0xB27D0C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x4F4ADC", Offset = "0x4F4ADC")]
	public static IEnumerator<float> CancelWith(this IEnumerator<float> coroutine, GameObject gameObject)
	{
		return null;
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0xB27DB4", Offset = "0xB27DB4", VA = "0xB27DB4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x4F4B50", Offset = "0x4F4B50")]
	public static IEnumerator<float> CancelWith(this IEnumerator<float> coroutine, GameObject gameObject1, GameObject gameObject2)
	{
		return null;
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0xB27E64", Offset = "0xB27E64", VA = "0xB27E64")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x4F4BC4", Offset = "0x4F4BC4")]
	public static IEnumerator<float> CancelWith(this IEnumerator<float> coroutine, Func<bool> condition)
	{
		return null;
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0xB27F0C", Offset = "0xB27F0C", VA = "0xB27F0C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x4F4C38", Offset = "0x4F4C38")]
	public static IEnumerator<float> PauseWith(this IEnumerator<float> coroutine, GameObject gameObject)
	{
		return null;
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0xB27FB4", Offset = "0xB27FB4", VA = "0xB27FB4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x4F4CAC", Offset = "0x4F4CAC")]
	public static IEnumerator<float> PauseWith(this IEnumerator<float> coroutine, GameObject gameObject1, GameObject gameObject2)
	{
		return null;
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0xB28064", Offset = "0xB28064", VA = "0xB28064")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x4F4D20", Offset = "0x4F4D20")]
	public static IEnumerator<float> PauseWith(this IEnumerator<float> coroutine, Func<bool> condition)
	{
		return null;
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0xB2810C", Offset = "0xB2810C", VA = "0xB2810C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x4F4D94", Offset = "0x4F4D94")]
	public static IEnumerator<float> Append(this IEnumerator<float> coroutine, IEnumerator<float> nextCoroutine)
	{
		return null;
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0xB281B4", Offset = "0xB281B4", VA = "0xB281B4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x4F4E08", Offset = "0x4F4E08")]
	public static IEnumerator<float> Append(this IEnumerator<float> coroutine, Action onDone)
	{
		return null;
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0xB2825C", Offset = "0xB2825C", VA = "0xB2825C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x4F4E7C", Offset = "0x4F4E7C")]
	public static IEnumerator<float> Prepend(this IEnumerator<float> coroutine, IEnumerator<float> lastCoroutine)
	{
		return null;
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0xB28304", Offset = "0xB28304", VA = "0xB28304")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x4F4EF0", Offset = "0x4F4EF0")]
	public static IEnumerator<float> Prepend(this IEnumerator<float> coroutine, Action onStart)
	{
		return null;
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0xB283AC", Offset = "0xB283AC", VA = "0xB283AC")]
	public static IEnumerator<float> Superimpose(this IEnumerator<float> coroutineA, IEnumerator<float> coroutineB)
	{
		return null;
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0xB2842C", Offset = "0xB2842C", VA = "0xB2842C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x4F4F74", Offset = "0x4F4F74")]
	public static IEnumerator<float> Superimpose(this IEnumerator<float> coroutineA, IEnumerator<float> coroutineB, Timing instance)
	{
		return null;
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0xB284DC", Offset = "0xB284DC", VA = "0xB284DC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x4F4FE8", Offset = "0x4F4FE8")]
	public static IEnumerator<float> Hijack(this IEnumerator<float> coroutine, Func<float, float> newReturn)
	{
		return null;
	}
}
namespace UnityStandardAssets.ImageEffects
{
	[Token(Token = "0x2000003")]
	public enum AAMode
	{
		[Token(Token = "0x4000002")]
		FXAA2,
		[Token(Token = "0x4000003")]
		FXAA3Console,
		[Token(Token = "0x4000004")]
		FXAA1PresetA,
		[Token(Token = "0x4000005")]
		FXAA1PresetB,
		[Token(Token = "0x4000006")]
		NFAA,
		[Token(Token = "0x4000007")]
		SSAA,
		[Token(Token = "0x4000008")]
		DLAA
	}
	[Token(Token = "0x2000004")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x4F1D0C", Offset = "0x4F1D0C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x4F1D0C", Offset = "0x4F1D0C")]
	public class Antialiasing : PostEffectsBase
	{
		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AAMode mode;

		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool showGeneratedNormals;

		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float offsetScale;

		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float blurRadius;

		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float edgeThresholdMin;

		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float edgeThreshold;

		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float edgeSharpness;

		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool dlaaSharp;

		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader ssaaShader;

		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material ssaa;

		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Shader dlaaShader;

		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material dlaa;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Shader nfaaShader;

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material nfaa;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Shader shaderFXAAPreset2;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Material materialFXAAPreset2;

		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Shader shaderFXAAPreset3;

		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Material materialFXAAPreset3;

		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Shader shaderFXAAII;

		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Material materialFXAAII;

		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Shader shaderFXAAIII;

		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Material materialFXAAIII;

		[Token(Token = "0x6000012")]
		[Address(RVA = "0xB2B2F0", Offset = "0xB2B2F0", VA = "0xB2B2F0")]
		public Material CurrentAAMaterial()
		{
			return null;
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0xB2B354", Offset = "0xB2B354", VA = "0xB2B354", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0xB2B7E8", Offset = "0xB2B7E8", VA = "0xB2B7E8")]
		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0xB2BD30", Offset = "0xB2BD30", VA = "0xB2BD30")]
		public Antialiasing()
		{
		}
	}
	[Token(Token = "0x2000005")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x4F1DA4", Offset = "0x4F1DA4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x4F1DA4", Offset = "0x4F1DA4")]
	public class Bloom : PostEffectsBase
	{
		[Token(Token = "0x2000043")]
		public enum LensFlareStyle
		{
			[Token(Token = "0x4000271")]
			Ghosting,
			[Token(Token = "0x4000272")]
			Anamorphic,
			[Token(Token = "0x4000273")]
			Combined
		}

		[Token(Token = "0x2000044")]
		public enum TweakMode
		{
			[Token(Token = "0x4000275")]
			Basic,
			[Token(Token = "0x4000276")]
			Complex
		}

		[Token(Token = "0x2000045")]
		public enum HDRBloomMode
		{
			[Token(Token = "0x4000278")]
			Auto,
			[Token(Token = "0x4000279")]
			On,
			[Token(Token = "0x400027A")]
			Off
		}

		[Token(Token = "0x2000046")]
		public enum BloomScreenBlendMode
		{
			[Token(Token = "0x400027C")]
			Screen,
			[Token(Token = "0x400027D")]
			Add
		}

		[Token(Token = "0x2000047")]
		public enum BloomQuality
		{
			[Token(Token = "0x400027F")]
			Cheap,
			[Token(Token = "0x4000280")]
			High
		}

		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TweakMode tweakMode;

		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public BloomScreenBlendMode screenBlendMode;

		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public HDRBloomMode hdr;

		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool doHdr;

		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float sepBlurSpread;

		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public BloomQuality quality;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float bloomIntensity;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float bloomThreshold;

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Color bloomThresholdColor;

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int bloomBlurIterations;

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public int hollywoodFlareBlurIterations;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float flareRotation;

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public LensFlareStyle lensflareMode;

		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float hollyStretchWidth;

		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float lensflareIntensity;

		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float lensflareThreshold;

		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float lensFlareSaturation;

		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Color flareColorA;

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Color flareColorB;

		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Color flareColorC;

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Color flareColorD;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Texture2D lensFlareVignetteMask;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public Shader lensFlareShader;

		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Material lensFlareMaterial;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Shader screenBlendShader;

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Material screenBlend;

		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public Shader blurAndFlaresShader;

		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Material blurAndFlaresMaterial;

		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public Shader brightPassFilterShader;

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Material brightPassFilterMaterial;

		[Token(Token = "0x6000016")]
		[Address(RVA = "0xB2BDCC", Offset = "0xB2BDCC", VA = "0xB2BDCC", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0xB2C1D0", Offset = "0xB2C1D0", VA = "0xB2C1D0")]
		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0xB2D58C", Offset = "0xB2D58C", VA = "0xB2D58C")]
		private void AddTo(float intensity_, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0xB2D38C", Offset = "0xB2D38C", VA = "0xB2D38C")]
		private void BlendFlares(RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0xB2D094", Offset = "0xB2D094", VA = "0xB2D094")]
		private void BrightFilter(float thresh, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0xB2CFB0", Offset = "0xB2CFB0", VA = "0xB2CFB0")]
		private void BrightFilter(Color threshColor, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0xB2D180", Offset = "0xB2D180", VA = "0xB2D180")]
		private void Vignette(float amount, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0xB2D654", Offset = "0xB2D654", VA = "0xB2D654")]
		public Bloom()
		{
		}
	}
	[Token(Token = "0x2000006")]
	public enum LensflareStyle34
	{
		[Token(Token = "0x400003E")]
		Ghosting,
		[Token(Token = "0x400003F")]
		Anamorphic,
		[Token(Token = "0x4000040")]
		Combined
	}
	[Token(Token = "0x2000007")]
	public enum TweakMode34
	{
		[Token(Token = "0x4000042")]
		Basic,
		[Token(Token = "0x4000043")]
		Complex
	}
	[Token(Token = "0x2000008")]
	public enum HDRBloomMode
	{
		[Token(Token = "0x4000045")]
		Auto,
		[Token(Token = "0x4000046")]
		On,
		[Token(Token = "0x4000047")]
		Off
	}
	[Token(Token = "0x2000009")]
	public enum BloomScreenBlendMode
	{
		[Token(Token = "0x4000049")]
		Screen,
		[Token(Token = "0x400004A")]
		Add
	}
	[Token(Token = "0x200000A")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x4F1E3C", Offset = "0x4F1E3C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x4F1E3C", Offset = "0x4F1E3C")]
	public class BloomAndFlares : PostEffectsBase
	{
		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TweakMode34 tweakMode;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public BloomScreenBlendMode screenBlendMode;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public HDRBloomMode hdr;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool doHdr;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float sepBlurSpread;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float useSrcAlphaAsMask;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float bloomIntensity;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float bloomThreshold;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public int bloomBlurIterations;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool lensflares;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public int hollywoodFlareBlurIterations;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public LensflareStyle34 lensflareMode;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float hollyStretchWidth;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float lensflareIntensity;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float lensflareThreshold;

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Color flareColorA;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public Color flareColorB;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public Color flareColorC;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public Color flareColorD;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Texture2D lensFlareVignetteMask;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public Shader lensFlareShader;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Material lensFlareMaterial;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public Shader vignetteShader;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Material vignetteMaterial;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Shader separableBlurShader;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Material separableBlurMaterial;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public Shader addBrightStuffOneOneShader;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Material addBrightStuffBlendOneOneMaterial;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public Shader screenBlendShader;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Material screenBlend;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public Shader hollywoodFlaresShader;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Material hollywoodFlaresMaterial;

		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public Shader brightPassFilterShader;

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Material brightPassFilterMaterial;

		[Token(Token = "0x600001E")]
		[Address(RVA = "0xB2D790", Offset = "0xB2D790", VA = "0xB2D790", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0xB2D848", Offset = "0xB2D848", VA = "0xB2D848")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0xB2E794", Offset = "0xB2E794", VA = "0xB2E794")]
		private void AddTo(float intensity_, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0xB2E5A4", Offset = "0xB2E5A4", VA = "0xB2E5A4")]
		private void BlendFlares(RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0xB2E328", Offset = "0xB2E328", VA = "0xB2E328")]
		private void BrightFilter(float thresh, float useAlphaAsMask, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0xB2E450", Offset = "0xB2E450", VA = "0xB2E450")]
		private void Vignette(float amount, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0xB2E848", Offset = "0xB2E848", VA = "0xB2E848")]
		public BloomAndFlares()
		{
		}
	}
	[Token(Token = "0x200000B")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x4F1ED4", Offset = "0x4F1ED4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x4F1ED4", Offset = "0x4F1ED4")]
	public class BloomOptimized : PostEffectsBase
	{
		[Token(Token = "0x2000048")]
		public enum Resolution
		{
			[Token(Token = "0x4000282")]
			Low,
			[Token(Token = "0x4000283")]
			High
		}

		[Token(Token = "0x2000049")]
		public enum BlurType
		{
			[Token(Token = "0x4000285")]
			Standard,
			[Token(Token = "0x4000286")]
			Sgx
		}

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4F40C8", Offset = "0x4F40C8")]
		public float threshold;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4F40E0", Offset = "0x4F40E0")]
		public float intensity;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4F40F8", Offset = "0x4F40F8")]
		public float blurSize;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Resolution resolution;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4F4110", Offset = "0x4F4110")]
		public int blurIterations;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public BlurType blurType;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Shader fastBloomShader;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Material fastBloomMaterial;

		[Token(Token = "0x6000025")]
		[Address(RVA = "0xB2E974", Offset = "0xB2E974", VA = "0xB2E974", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0xB2E9CC", Offset = "0xB2E9CC", VA = "0xB2E9CC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0xB2EA7C", Offset = "0xB2EA7C", VA = "0xB2EA7C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0xB2EE48", Offset = "0xB2EE48", VA = "0xB2EE48")]
		public BloomOptimized()
		{
		}
	}
	[Token(Token = "0x200000C")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x4F1F6C", Offset = "0x4F1F6C")]
	public class Blur : MonoBehaviour
	{
		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4F4128", Offset = "0x4F4128")]
		public int iterations;

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4F4140", Offset = "0x4F4140")]
		public float blurSpread;

		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Shader blurShader;

		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Material m_Material;

		[Token(Token = "0x17000001")]
		protected Material material
		{
			[Token(Token = "0x6000029")]
			[Address(RVA = "0xB2EE68", Offset = "0xB2EE68", VA = "0xB2EE68")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0xB2EFA0", Offset = "0xB2EFA0", VA = "0xB2EFA0")]
		protected void OnDisable()
		{
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0xB2F09C", Offset = "0xB2F09C", VA = "0xB2F09C")]
		protected void Start()
		{
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0xB2F15C", Offset = "0xB2F15C", VA = "0xB2F15C")]
		public void FourTapCone(RenderTexture source, RenderTexture dest, int iteration)
		{
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0xB2F300", Offset = "0xB2F300", VA = "0xB2F300")]
		private void DownSample4x(RenderTexture source, RenderTexture dest)
		{
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0xB2F478", Offset = "0xB2F478", VA = "0xB2F478")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0xB2F5E4", Offset = "0xB2F5E4", VA = "0xB2F5E4")]
		public Blur()
		{
		}
	}
	[Token(Token = "0x200000D")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x4F1FB8", Offset = "0x4F1FB8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x4F1FB8", Offset = "0x4F1FB8")]
	public class BlurOptimized : PostEffectsBase
	{
		[Token(Token = "0x200004A")]
		public enum BlurType
		{
			[Token(Token = "0x4000288")]
			StandardGauss,
			[Token(Token = "0x4000289")]
			SgxGauss
		}

		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4F4158", Offset = "0x4F4158")]
		public int downsample;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4F4170", Offset = "0x4F4170")]
		public float blurSize;

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4F4188", Offset = "0x4F4188")]
		public int blurIterations;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public BlurType blurType;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader blurShader;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material blurMaterial;

		[Token(Token = "0x6000031")]
		[Address(RVA = "0xB2F600", Offset = "0xB2F600", VA = "0xB2F600", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0xB2F658", Offset = "0xB2F658", VA = "0xB2F658")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0xB2F708", Offset = "0xB2F708", VA = "0xB2F708")]
		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0xB2FAAC", Offset = "0xB2FAAC", VA = "0xB2FAAC")]
		public BlurOptimized()
		{
		}
	}
	[Token(Token = "0x200000E")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x4F3050", Offset = "0x4F3050")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x4F3050", Offset = "0x4F3050")]
	public class CameraMotionBlur : PostEffectsBase
	{
		[Token(Token = "0x200004B")]
		public enum MotionBlurFilter
		{
			[Token(Token = "0x400028B")]
			CameraMotion,
			[Token(Token = "0x400028C")]
			LocalBlur,
			[Token(Token = "0x400028D")]
			Reconstruction,
			[Token(Token = "0x400028E")]
			ReconstructionDX11,
			[Token(Token = "0x400028F")]
			ReconstructionDisc
		}

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static float MAX_RADIUS;

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MotionBlurFilter filterType;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool preview;

		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 previewScale;

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float movementScale;

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float rotationScale;

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float maxVelocity;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float minVelocity;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float velocityScale;

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float softZDistance;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public int velocityDownsample;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public LayerMask excludeLayers;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private GameObject tmpCam;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Shader shader;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Shader dx11MotionBlurShader;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Shader replacementClear;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Material motionBlurMaterial;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Material dx11MotionBlurMaterial;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Texture2D noiseTexture;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float jitter;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public bool showVelocity;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public float showVelocityScale;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Matrix4x4 currentViewProjMat;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Matrix4x4[] currentStereoViewProjMat;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Matrix4x4 prevViewProjMat;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Matrix4x4[] prevStereoViewProjMat;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private int prevFrameCount;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private bool wasActive;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector3 prevFrameForward;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		private Vector3 prevFrameUp;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Vector3 prevFramePos;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private Camera _camera;

		[Token(Token = "0x6000035")]
		[Address(RVA = "0xB2FAC4", Offset = "0xB2FAC4", VA = "0xB2FAC4")]
		private void CalculateViewProjection()
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0xB2FD60", Offset = "0xB2FD60", VA = "0xB2FD60")]
		private new void Start()
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0xB2FFBC", Offset = "0xB2FFBC", VA = "0xB2FFBC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0xB3007C", Offset = "0xB3007C", VA = "0xB3007C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0xB301E0", Offset = "0xB301E0", VA = "0xB301E0", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0xB302C4", Offset = "0xB302C4", VA = "0xB302C4")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0xB2FE60", Offset = "0xB2FE60", VA = "0xB2FE60")]
		private void Remember()
		{
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0xB31C6C", Offset = "0xB31C6C", VA = "0xB31C6C")]
		private Camera GetTmpCam()
		{
			return null;
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0xB31B80", Offset = "0xB31B80", VA = "0xB31B80")]
		private void StartFrame()
		{
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0xB31C5C", Offset = "0xB31C5C", VA = "0xB31C5C")]
		private static int divRoundUp(int x, int d)
		{
			return default(int);
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0xB31FA8", Offset = "0xB31FA8", VA = "0xB31FA8")]
		public CameraMotionBlur()
		{
		}
	}
	[Token(Token = "0x200000F")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x4F30E8", Offset = "0x4F30E8")]
	public class ColorCorrectionCurves : PostEffectsBase
	{
		[Token(Token = "0x200004C")]
		public enum ColorCorrectionMode
		{
			[Token(Token = "0x4000291")]
			Simple,
			[Token(Token = "0x4000292")]
			Advanced
		}

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AnimationCurve redChannel;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve greenChannel;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve blueChannel;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool useDepthCorrection;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public AnimationCurve zCurve;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AnimationCurve depthRedChannel;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AnimationCurve depthGreenChannel;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public AnimationCurve depthBlueChannel;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Material ccMaterial;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material ccDepthMaterial;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Material selectiveCcMaterial;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Texture2D rgbChannelTex;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Texture2D rgbDepthChannelTex;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Texture2D zCurveTex;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float saturation;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public bool selectiveCc;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Color selectiveFromColor;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public Color selectiveToColor;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public ColorCorrectionMode mode;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public bool updateTextures;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public Shader colorCorrectionCurvesShader;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Shader simpleColorCorrectionCurvesShader;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public Shader colorCorrectionSelectiveShader;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool updateTexturesOnStartup;

		[Token(Token = "0x6000041")]
		[Address(RVA = "0xB320F4", Offset = "0xB320F4", VA = "0xB320F4")]
		private new void Start()
		{
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0xB32130", Offset = "0xB32130", VA = "0xB32130")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0xB32134", Offset = "0xB32134", VA = "0xB32134", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0xB32394", Offset = "0xB32394", VA = "0xB32394")]
		public void UpdateParameters()
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0xB32788", Offset = "0xB32788", VA = "0xB32788")]
		private void UpdateTextures()
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0xB3278C", Offset = "0xB3278C", VA = "0xB3278C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0xB32A88", Offset = "0xB32A88", VA = "0xB32A88")]
		public ColorCorrectionCurves()
		{
		}
	}
	[Token(Token = "0x2000010")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x4F3134", Offset = "0x4F3134")]
	public class ColorCorrectionLookup : PostEffectsBase
	{
		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Shader shader;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Material material;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Texture3D converted3DLut;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string basedOnTempTex;

		[Token(Token = "0x6000048")]
		[Address(RVA = "0xB330B8", Offset = "0xB330B8", VA = "0xB330B8", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0xB3310C", Offset = "0xB3310C", VA = "0xB3310C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0xB331B4", Offset = "0xB331B4", VA = "0xB331B4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0xB3325C", Offset = "0xB3325C", VA = "0xB3325C")]
		public void SetIdentityLut()
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0xB33458", Offset = "0xB33458", VA = "0xB33458")]
		public bool ValidDimensions(Texture2D tex2d)
		{
			return default(bool);
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0xB3354C", Offset = "0xB3354C", VA = "0xB3354C")]
		public void Convert(Texture2D temp2DTex, string path)
		{
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0xB33858", Offset = "0xB33858", VA = "0xB33858")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0xB33A44", Offset = "0xB33A44", VA = "0xB33A44")]
		public ColorCorrectionLookup()
		{
		}
	}
	[Token(Token = "0x2000011")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x4F3180", Offset = "0x4F3180")]
	public class ColorCorrectionRamp : ImageEffectBase
	{
		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Texture textureRamp;

		[Token(Token = "0x6000050")]
		[Address(RVA = "0xB33A98", Offset = "0xB33A98", VA = "0xB33A98")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0xB33C14", Offset = "0xB33C14", VA = "0xB33C14")]
		public ColorCorrectionRamp()
		{
		}
	}
	[Token(Token = "0x2000012")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x4F31CC", Offset = "0x4F31CC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x4F31CC", Offset = "0x4F31CC")]
	public class ContrastEnhance : PostEffectsBase
	{
		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4F41A0", Offset = "0x4F41A0")]
		public float intensity;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4F41B8", Offset = "0x4F41B8")]
		public float threshold;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Material separableBlurMaterial;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Material contrastCompositeMaterial;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4F41D4", Offset = "0x4F41D4")]
		public float blurSpread;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader separableBlurShader;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Shader contrastCompositeShader;

		[Token(Token = "0x6000052")]
		[Address(RVA = "0xB33C24", Offset = "0xB33C24", VA = "0xB33C24", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0xB33C94", Offset = "0xB33C94", VA = "0xB33C94")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0xB33FFC", Offset = "0xB33FFC", VA = "0xB33FFC")]
		public ContrastEnhance()
		{
		}
	}
	[Token(Token = "0x2000013")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x4F3264", Offset = "0x4F3264")]
	public class ContrastStretch : MonoBehaviour
	{
		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4F41EC", Offset = "0x4F41EC")]
		public float adaptationSpeed;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4F4208", Offset = "0x4F4208")]
		public float limitMinimum;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4F4220", Offset = "0x4F4220")]
		public float limitMaximum;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private RenderTexture[] adaptRenderTex;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int curAdaptIndex;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader shaderLum;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material m_materialLum;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader shaderReduce;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material m_materialReduce;

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Shader shaderAdapt;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material m_materialAdapt;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Shader shaderApply;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material m_materialApply;

		[Token(Token = "0x17000002")]
		protected Material materialLum
		{
			[Token(Token = "0x6000055")]
			[Address(RVA = "0xB34010", Offset = "0xB34010", VA = "0xB34010")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000003")]
		protected Material materialReduce
		{
			[Token(Token = "0x6000056")]
			[Address(RVA = "0xB340D4", Offset = "0xB340D4", VA = "0xB340D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000004")]
		protected Material materialAdapt
		{
			[Token(Token = "0x6000057")]
			[Address(RVA = "0xB34198", Offset = "0xB34198", VA = "0xB34198")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000005")]
		protected Material materialApply
		{
			[Token(Token = "0x6000058")]
			[Address(RVA = "0xB3425C", Offset = "0xB3425C", VA = "0xB3425C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0xB34320", Offset = "0xB34320", VA = "0xB34320")]
		private void Start()
		{
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0xB343B4", Offset = "0xB343B4", VA = "0xB343B4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0xB34504", Offset = "0xB34504", VA = "0xB34504")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0xB3472C", Offset = "0xB3472C", VA = "0xB3472C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0xB34988", Offset = "0xB34988", VA = "0xB34988")]
		private void CalculateAdaptation(Texture curTexture)
		{
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0xB34B98", Offset = "0xB34B98", VA = "0xB34B98")]
		public ContrastStretch()
		{
		}
	}
	[Token(Token = "0x2000014")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x4F32B0", Offset = "0x4F32B0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x4F32B0", Offset = "0x4F32B0")]
	public class CreaseShading : PostEffectsBase
	{
		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float intensity;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int softness;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float spread;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader blurShader;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material blurMaterial;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader depthFetchShader;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material depthFetchMaterial;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Shader creaseApplyShader;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material creaseApplyMaterial;

		[Token(Token = "0x600005F")]
		[Address(RVA = "0xB34C10", Offset = "0xB34C10", VA = "0xB34C10", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0xB34C88", Offset = "0xB34C88", VA = "0xB34C88")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0xB35030", Offset = "0xB35030", VA = "0xB35030")]
		public CreaseShading()
		{
		}
	}
	[Token(Token = "0x2000015")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x4F3348", Offset = "0x4F3348")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x4F3348", Offset = "0x4F3348")]
	public class DepthOfField : PostEffectsBase
	{
		[Token(Token = "0x200004D")]
		public enum BlurType
		{
			[Token(Token = "0x4000294")]
			DiscBlur,
			[Token(Token = "0x4000295")]
			DX11
		}

		[Token(Token = "0x200004E")]
		public enum BlurSampleCount
		{
			[Token(Token = "0x4000297")]
			Low,
			[Token(Token = "0x4000298")]
			Medium,
			[Token(Token = "0x4000299")]
			High
		}

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool visualizeFocus;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float focalLength;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float focalSize;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float aperture;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform focalTransform;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float maxBlurSize;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool highResolution;

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public BlurType blurType;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public BlurSampleCount blurSampleCount;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool nearBlur;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float foregroundOverlap;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Shader dofHdrShader;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material dofHdrMaterial;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Shader dx11BokehShader;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material dx11bokehMaterial;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public float dx11BokehThreshold;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public float dx11SpawnHeuristic;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Texture2D dx11BokehTexture;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float dx11BokehScale;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float dx11BokehIntensity;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float focalDistance01;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private ComputeBuffer cbDrawArgs;

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private ComputeBuffer cbPoints;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private float internalBlurWidth;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Camera cachedCamera;

		[Token(Token = "0x6000062")]
		[Address(RVA = "0xB35048", Offset = "0xB35048", VA = "0xB35048", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0xB351E8", Offset = "0xB351E8", VA = "0xB351E8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0xB35260", Offset = "0xB35260", VA = "0xB35260")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0xB35368", Offset = "0xB35368", VA = "0xB35368")]
		private void ReleaseComputeResources()
		{
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0xB350CC", Offset = "0xB350CC", VA = "0xB350CC")]
		private void CreateComputeResources()
		{
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0xB353AC", Offset = "0xB353AC", VA = "0xB353AC")]
		private float FocalDistance01(float worldDist)
		{
			return default(float);
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0xB35508", Offset = "0xB35508", VA = "0xB35508")]
		private void WriteCoc(RenderTexture fromTo, bool fgDilate)
		{
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0xB35828", Offset = "0xB35828", VA = "0xB35828")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0xB36E80", Offset = "0xB36E80", VA = "0xB36E80")]
		public DepthOfField()
		{
		}
	}
	[Token(Token = "0x2000016")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x4F33E0", Offset = "0x4F33E0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x4F33E0", Offset = "0x4F33E0")]
	public class DepthOfFieldDeprecated : PostEffectsBase
	{
		[Token(Token = "0x200004F")]
		public enum Dof34QualitySetting
		{
			[Token(Token = "0x400029B")]
			OnlyBackground = 1,
			[Token(Token = "0x400029C")]
			BackgroundAndForeground
		}

		[Token(Token = "0x2000050")]
		public enum DofResolution
		{
			[Token(Token = "0x400029E")]
			High = 2,
			[Token(Token = "0x400029F")]
			Medium,
			[Token(Token = "0x40002A0")]
			Low
		}

		[Token(Token = "0x2000051")]
		public enum DofBlurriness
		{
			[Token(Token = "0x40002A2")]
			Low = 1,
			[Token(Token = "0x40002A3")]
			High = 2,
			[Token(Token = "0x40002A4")]
			VeryHigh = 4
		}

		[Token(Token = "0x2000052")]
		public enum BokehDestination
		{
			[Token(Token = "0x40002A6")]
			Background = 1,
			[Token(Token = "0x40002A7")]
			Foreground,
			[Token(Token = "0x40002A8")]
			BackgroundAndForeground
		}

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int SMOOTH_DOWNSAMPLE_PASS;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static float BOKEH_EXTRA_BLUR;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Dof34QualitySetting quality;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public DofResolution resolution;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool simpleTweakMode;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float focalPoint;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float smoothness;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float focalZDistance;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float focalZStartCurve;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float focalZEndCurve;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float focalStartCurve;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float focalEndCurve;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float focalDistance01;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform objectFocus;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float focalSize;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public DofBlurriness bluriness;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float maxBlurSpread;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float foregroundBlurExtrude;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Shader dofBlurShader;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Material dofBlurMaterial;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Shader dofShader;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Material dofMaterial;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public bool visualize;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public BokehDestination bokehDestination;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float widthOverHeight;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private float oneOverBaseSize;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public bool bokeh;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
		public bool bokehSupport;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Shader bokehShader;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public Texture2D bokehTexture;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public float bokehScale;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public float bokehIntensity;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public float bokehThresholdContrast;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public float bokehThresholdLuminance;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public int bokehDownsample;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Material bokehMaterial;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Camera _camera;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private RenderTexture foregroundTexture;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private RenderTexture mediumRezWorkTexture;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private RenderTexture finalDefocus;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private RenderTexture lowRezWorkTexture;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private RenderTexture bokehSource;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private RenderTexture bokehSource2;

		[Token(Token = "0x600006B")]
		[Address(RVA = "0xB36ED4", Offset = "0xB36ED4", VA = "0xB36ED4")]
		private void CreateMaterials()
		{
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0xB36FA8", Offset = "0xB36FA8", VA = "0xB36FA8", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0xB370AC", Offset = "0xB370AC", VA = "0xB370AC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0xB372D8", Offset = "0xB372D8", VA = "0xB372D8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0xB37350", Offset = "0xB37350", VA = "0xB37350")]
		private float FocalDistance01(float worldDist)
		{
			return default(float);
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0xB374AC", Offset = "0xB374AC", VA = "0xB374AC")]
		private int GetDividerBasedOnQuality()
		{
			return default(int);
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0xB374D0", Offset = "0xB374D0", VA = "0xB374D0")]
		private int GetLowResolutionDividerBasedOnQuality(int baseDivider)
		{
			return default(int);
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0xB374F4", Offset = "0xB374F4", VA = "0xB374F4")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0xB382D8", Offset = "0xB382D8", VA = "0xB382D8")]
		private void Blur(RenderTexture from, RenderTexture to, DofBlurriness iterations, int blurPass, float spread)
		{
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0xB3898C", Offset = "0xB3898C", VA = "0xB3898C")]
		private void BlurFg(RenderTexture from, RenderTexture to, DofBlurriness iterations, int blurPass, float spread)
		{
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0xB38DF4", Offset = "0xB38DF4", VA = "0xB38DF4")]
		private void BlurHex(RenderTexture from, RenderTexture to, int blurPass, float spread, RenderTexture tmp)
		{
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0xB3818C", Offset = "0xB3818C", VA = "0xB3818C")]
		private void Downsample(RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0xB38574", Offset = "0xB38574", VA = "0xB38574")]
		private void AddBokeh(RenderTexture bokehInfo, RenderTexture tempTex, RenderTexture finalTarget)
		{
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0xB38C48", Offset = "0xB38C48", VA = "0xB38C48")]
		private void ReleaseTextures()
		{
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0xB37E58", Offset = "0xB37E58", VA = "0xB37E58")]
		private void AllocateTextures(bool blurForeground, RenderTexture source, int divider, int lowTexDivider)
		{
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0xB392DC", Offset = "0xB392DC", VA = "0xB392DC")]
		public DepthOfFieldDeprecated()
		{
		}
	}
	[Token(Token = "0x2000017")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x4F3478", Offset = "0x4F3478")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x4F3478", Offset = "0x4F3478")]
	public class EdgeDetection : PostEffectsBase
	{
		[Token(Token = "0x2000053")]
		public enum EdgeDetectMode
		{
			[Token(Token = "0x40002AA")]
			TriangleDepthNormals,
			[Token(Token = "0x40002AB")]
			RobertsCrossDepthNormals,
			[Token(Token = "0x40002AC")]
			SobelDepth,
			[Token(Token = "0x40002AD")]
			SobelDepthThin,
			[Token(Token = "0x40002AE")]
			TriangleLuminance
		}

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public EdgeDetectMode mode;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float sensitivityDepth;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float sensitivityNormals;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float lumThreshold;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float edgeExp;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float sampleDist;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float edgesOnly;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Color edgesOnlyBgColor;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Shader edgeDetectShader;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material edgeDetectMaterial;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private EdgeDetectMode oldMode;

		[Token(Token = "0x600007C")]
		[Address(RVA = "0xB393B4", Offset = "0xB393B4", VA = "0xB393B4", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0xB394EC", Offset = "0xB394EC", VA = "0xB394EC")]
		private new void Start()
		{
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0xB3942C", Offset = "0xB3942C", VA = "0xB3942C")]
		private void SetCameraFlag()
		{
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0xB394F8", Offset = "0xB394F8", VA = "0xB394F8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0xB394FC", Offset = "0xB394FC", VA = "0xB394FC")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0xB396E8", Offset = "0xB396E8", VA = "0xB396E8")]
		public EdgeDetection()
		{
		}
	}
	[Token(Token = "0x2000018")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x4F3510", Offset = "0x4F3510")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x4F3510", Offset = "0x4F3510")]
	public class Fisheye : PostEffectsBase
	{
		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4F4238", Offset = "0x4F4238")]
		public float strengthX;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4F4250", Offset = "0x4F4250")]
		public float strengthY;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Shader fishEyeShader;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Material fisheyeMaterial;

		[Token(Token = "0x6000082")]
		[Address(RVA = "0xB39738", Offset = "0xB39738", VA = "0xB39738", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0xB39790", Offset = "0xB39790", VA = "0xB39790")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0xB39900", Offset = "0xB39900", VA = "0xB39900")]
		public Fisheye()
		{
		}
	}
	[Token(Token = "0x2000019")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x4F35A8", Offset = "0x4F35A8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x4F35A8", Offset = "0x4F35A8")]
	internal class GlobalFog : PostEffectsBase
	{
		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4F4268", Offset = "0x4F4268")]
		public bool distanceFog;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4F42A0", Offset = "0x4F42A0")]
		public bool excludeFarPixels;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4F42D8", Offset = "0x4F42D8")]
		public bool useRadialDistance;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4F4310", Offset = "0x4F4310")]
		public bool heightFog;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4F4348", Offset = "0x4F4348")]
		public float height;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4F4380", Offset = "0x4F4380")]
		public float heightDensity;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4F439C", Offset = "0x4F439C")]
		public float startDistance;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader fogShader;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material fogMaterial;

		[Token(Token = "0x6000085")]
		[Address(RVA = "0xB39914", Offset = "0xB39914", VA = "0xB39914", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0xB3996C", Offset = "0xB3996C", VA = "0xB3996C")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0xB39FA4", Offset = "0xB39FA4", VA = "0xB39FA4")]
		public GlobalFog()
		{
		}
	}
	[Token(Token = "0x200001A")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x4F3640", Offset = "0x4F3640")]
	public class Grayscale : ImageEffectBase
	{
		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Texture textureRamp;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4F43D4", Offset = "0x4F43D4")]
		public float rampOffset;

		[Token(Token = "0x6000088")]
		[Address(RVA = "0xB39FC4", Offset = "0xB39FC4", VA = "0xB39FC4")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0xB3A0A0", Offset = "0xB3A0A0", VA = "0xB3A0A0")]
		public Grayscale()
		{
		}
	}
	[Token(Token = "0x200001B")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x4F368C", Offset = "0x4F368C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x4F368C", Offset = "0x4F368C")]
	public class ImageEffectBase : MonoBehaviour
	{
		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Shader shader;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Material m_Material;

		[Token(Token = "0x17000006")]
		protected Material material
		{
			[Token(Token = "0x600008B")]
			[Address(RVA = "0xB33B50", Offset = "0xB33B50", VA = "0xB33B50")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0xB3A0A8", Offset = "0xB3A0A8", VA = "0xB3A0A8", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0xB3A158", Offset = "0xB3A158", VA = "0xB3A158", Slot = "5")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0xB33C1C", Offset = "0xB33C1C", VA = "0xB33C1C")]
		public ImageEffectBase()
		{
		}
	}
	[Token(Token = "0x200001C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x4F3714", Offset = "0x4F3714")]
	public class ImageEffects
	{
		[Token(Token = "0x600008E")]
		[Address(RVA = "0xB3A208", Offset = "0xB3A208", VA = "0xB3A208")]
		public static void RenderDistortion(Material material, RenderTexture source, RenderTexture destination, float angle, Vector2 center, Vector2 radius)
		{
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0xB3A484", Offset = "0xB3A484", VA = "0xB3A484")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x4F507C", Offset = "0x4F507C")]
		public static void Blit(RenderTexture source, RenderTexture dest)
		{
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0xB3A4FC", Offset = "0xB3A4FC", VA = "0xB3A4FC")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x4F50B4", Offset = "0x4F50B4")]
		public static void BlitWithMaterial(Material material, RenderTexture source, RenderTexture dest)
		{
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0xB3A57C", Offset = "0xB3A57C", VA = "0xB3A57C")]
		public ImageEffects()
		{
		}
	}
	[Token(Token = "0x200001D")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x4F374C", Offset = "0x4F374C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x4F374C", Offset = "0x4F374C")]
	public class MotionBlur : ImageEffectBase
	{
		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4F43EC", Offset = "0x4F43EC")]
		public float blurAmount;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool extraBlur;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private RenderTexture accumTexture;

		[Token(Token = "0x6000092")]
		[Address(RVA = "0xB3A584", Offset = "0xB3A584", VA = "0xB3A584", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0xB3A588", Offset = "0xB3A588", VA = "0xB3A588", Slot = "5")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0xB3A5FC", Offset = "0xB3A5FC", VA = "0xB3A5FC")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0xB3A980", Offset = "0xB3A980", VA = "0xB3A980")]
		public MotionBlur()
		{
		}
	}
	[Token(Token = "0x200001E")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x4F37E4", Offset = "0x4F37E4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x4F37E4", Offset = "0x4F37E4")]
	public class NoiseAndGrain : PostEffectsBase
	{
		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float intensityMultiplier;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float generalIntensity;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float blackIntensity;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float whiteIntensity;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float midGrey;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool dx11Grain;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float softness;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool monochrome;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 intensities;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Vector3 tiling;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float monochromeTiling;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public FilterMode filterMode;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Texture2D noiseTexture;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Shader noiseShader;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Material noiseMaterial;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Shader dx11NoiseShader;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Material dx11NoiseMaterial;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static float TILE_AMOUNT;

		[Token(Token = "0x6000096")]
		[Address(RVA = "0xB3A994", Offset = "0xB3A994", VA = "0xB3A994", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0xB3AA0C", Offset = "0xB3AA0C", VA = "0xB3AA0C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0xB3B32C", Offset = "0xB3B32C", VA = "0xB3B32C")]
		private static void DrawNoiseQuadGrid(RenderTexture source, RenderTexture dest, Material fxMaterial, Texture2D noise, int passNr)
		{
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0xB3B6A8", Offset = "0xB3B6A8", VA = "0xB3B6A8")]
		public NoiseAndGrain()
		{
		}
	}
	[Token(Token = "0x200001F")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x4F387C", Offset = "0x4F387C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x4F387C", Offset = "0x4F387C")]
	public class NoiseAndScratches : MonoBehaviour
	{
		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool monochrome;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		private bool rgbFallback;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4F4408", Offset = "0x4F4408")]
		public float grainIntensityMin;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4F4420", Offset = "0x4F4420")]
		public float grainIntensityMax;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4F4438", Offset = "0x4F4438")]
		public float grainSize;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4F4458", Offset = "0x4F4458")]
		public float scratchIntensityMin;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4F4470", Offset = "0x4F4470")]
		public float scratchIntensityMax;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4F4488", Offset = "0x4F4488")]
		public float scratchFPS;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4F44A0", Offset = "0x4F44A0")]
		public float scratchJitter;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Texture grainTexture;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Texture scratchTexture;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader shaderRGB;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Shader shaderYUV;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Material m_MaterialRGB;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material m_MaterialYUV;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float scratchTimeLeft;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float scratchX;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float scratchY;

		[Token(Token = "0x17000007")]
		protected Material material
		{
			[Token(Token = "0x600009C")]
			[Address(RVA = "0xB3B8F0", Offset = "0xB3B8F0", VA = "0xB3B8F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0xB3B7B0", Offset = "0xB3B7B0", VA = "0xB3B7B0")]
		protected void Start()
		{
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0xB3BA4C", Offset = "0xB3BA4C", VA = "0xB3BA4C")]
		protected void OnDisable()
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0xB3BB50", Offset = "0xB3BB50", VA = "0xB3BB50")]
		private void SanitizeParameters()
		{
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0xB3BC8C", Offset = "0xB3BC8C", VA = "0xB3BC8C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0xB3BFD4", Offset = "0xB3BFD4", VA = "0xB3BFD4")]
		public NoiseAndScratches()
		{
		}
	}
	[Token(Token = "0x2000020")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x4F3914", Offset = "0x4F3914")]
	public class PostEffectsBase : MonoBehaviour
	{
		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected bool supportHDRTextures;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		protected bool supportDX11;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		protected bool isSupported;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<Material> createdMaterials;

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0xB2BE54", Offset = "0xB2BE54", VA = "0xB2BE54")]
		protected Material CheckShaderAndCreateMaterial(Shader s, Material m2Create)
		{
			return null;
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0xB2B538", Offset = "0xB2B538", VA = "0xB2B538")]
		protected Material CreateMaterial(Shader s, Material m2Create)
		{
			return null;
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0xB3C008", Offset = "0xB3C008", VA = "0xB3C008")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0xB3C014", Offset = "0xB3C014", VA = "0xB3C014")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0xB3C018", Offset = "0xB3C018", VA = "0xB3C018")]
		private void RemoveCreatedMaterials()
		{
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0xB3C0C8", Offset = "0xB3C0C8", VA = "0xB3C0C8")]
		protected bool CheckSupport()
		{
			return default(bool);
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0xB3C0D0", Offset = "0xB3C0D0", VA = "0xB3C0D0", Slot = "4")]
		public virtual bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0xB32124", Offset = "0xB32124", VA = "0xB32124")]
		protected void Start()
		{
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0xB2B430", Offset = "0xB2B430", VA = "0xB2B430")]
		protected bool CheckSupport(bool needDepth)
		{
			return default(bool);
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0xB30268", Offset = "0xB30268", VA = "0xB30268")]
		protected bool CheckSupport(bool needDepth, bool needHdr)
		{
			return default(bool);
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0xB3C180", Offset = "0xB3C180", VA = "0xB3C180")]
		public bool Dx11Support()
		{
			return default(bool);
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0xB2B740", Offset = "0xB2B740", VA = "0xB2B740")]
		protected void ReportAutoDisable()
		{
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0xB3C188", Offset = "0xB3C188", VA = "0xB3C188")]
		private bool CheckShader(Shader s)
		{
			return default(bool);
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0xB2B714", Offset = "0xB2B714", VA = "0xB2B714")]
		protected void NotSupported()
		{
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0xB3C388", Offset = "0xB3C388", VA = "0xB3C388")]
		protected void DrawBorder(RenderTexture dest, Material material)
		{
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0xB2BD50", Offset = "0xB2BD50", VA = "0xB2BD50")]
		public PostEffectsBase()
		{
		}
	}
	[Token(Token = "0x2000021")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x4F3988", Offset = "0x4F3988")]
	internal class PostEffectsHelper : MonoBehaviour
	{
		[Token(Token = "0x60000B1")]
		[Address(RVA = "0xB3C704", Offset = "0xB3C704", VA = "0xB3C704")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0xB3C770", Offset = "0xB3C770", VA = "0xB3C770")]
		private static void DrawLowLevelPlaneAlignedWithCamera(float dist, RenderTexture source, RenderTexture dest, Material material, Camera cameraForProjectionMatrix)
		{
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0xB3C9EC", Offset = "0xB3C9EC", VA = "0xB3C9EC")]
		private static void DrawBorder(RenderTexture dest, Material material)
		{
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0xB3CD64", Offset = "0xB3CD64", VA = "0xB3CD64")]
		private static void DrawLowLevelQuad(float x1, float x2, float y1, float y2, RenderTexture source, RenderTexture dest, Material material)
		{
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0xB3CF10", Offset = "0xB3CF10", VA = "0xB3CF10")]
		public PostEffectsHelper()
		{
		}
	}
	[Token(Token = "0x2000022")]
	internal class Quads
	{
		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Mesh[] meshes;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static int currentQuads;

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0xB3CF18", Offset = "0xB3CF18", VA = "0xB3CF18")]
		private static bool HasMeshes()
		{
			return default(bool);
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0xB37108", Offset = "0xB37108", VA = "0xB37108")]
		public static void Cleanup()
		{
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0xB3901C", Offset = "0xB3901C", VA = "0xB3901C")]
		public static Mesh[] GetMeshes(int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0xB3D03C", Offset = "0xB3D03C", VA = "0xB3D03C")]
		private static Mesh GetMesh(int triCount, int triOffset, int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0xB3D570", Offset = "0xB3D570", VA = "0xB3D570")]
		public Quads()
		{
		}
	}
	[Token(Token = "0x2000023")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x4F39FC", Offset = "0x4F39FC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x4F39FC", Offset = "0x4F39FC")]
	public class ScreenOverlay : PostEffectsBase
	{
		[Token(Token = "0x2000054")]
		public enum OverlayBlendMode
		{
			[Token(Token = "0x40002B0")]
			Additive,
			[Token(Token = "0x40002B1")]
			ScreenBlend,
			[Token(Token = "0x40002B2")]
			Multiply,
			[Token(Token = "0x40002B3")]
			Overlay,
			[Token(Token = "0x40002B4")]
			AlphaBlend
		}

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public OverlayBlendMode blendMode;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float intensity;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Texture2D texture;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader overlayShader;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material overlayMaterial;

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0xE18B80", Offset = "0xE18B80", VA = "0xE18B80", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0xE18BE4", Offset = "0xE18BE4", VA = "0xE18BE4")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0xE18D4C", Offset = "0xE18D4C", VA = "0xE18D4C")]
		public ScreenOverlay()
		{
		}
	}
	[Token(Token = "0x2000024")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x4F3A94", Offset = "0x4F3A94")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x4F3A94", Offset = "0x4F3A94")]
	internal class ScreenSpaceAmbientObscurance : PostEffectsBase
	{
		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4F44B8", Offset = "0x4F44B8")]
		public float intensity;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4F44D0", Offset = "0x4F44D0")]
		public float radius;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4F44EC", Offset = "0x4F44EC")]
		public int blurIterations;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4F4504", Offset = "0x4F4504")]
		public float blurFilterDistance;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4F451C", Offset = "0x4F451C")]
		public int downsample;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Texture2D rand;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader aoShader;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material aoMaterial;

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0xE18D60", Offset = "0xE18D60", VA = "0xE18D60", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0xE18DC4", Offset = "0xE18DC4", VA = "0xE18DC4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0xE18E6C", Offset = "0xE18E6C", VA = "0xE18E6C")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0xE19680", Offset = "0xE19680", VA = "0xE19680")]
		public ScreenSpaceAmbientObscurance()
		{
		}
	}
	[Token(Token = "0x2000025")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x4F3B2C", Offset = "0x4F3B2C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x4F3B2C", Offset = "0x4F3B2C")]
	public class ScreenSpaceAmbientOcclusion : MonoBehaviour
	{
		[Token(Token = "0x2000055")]
		public enum SSAOSamples
		{
			[Token(Token = "0x40002B6")]
			Low,
			[Token(Token = "0x40002B7")]
			Medium,
			[Token(Token = "0x40002B8")]
			High
		}

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4F4534", Offset = "0x4F4534")]
		public float m_Radius;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public SSAOSamples m_SampleCount;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4F4550", Offset = "0x4F4550")]
		public float m_OcclusionIntensity;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4F4568", Offset = "0x4F4568")]
		public int m_Blur;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4F4580", Offset = "0x4F4580")]
		public int m_Downsampling;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4F4598", Offset = "0x4F4598")]
		public float m_OcclusionAttenuation;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4F45B4", Offset = "0x4F45B4")]
		public float m_MinZ;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader m_SSAOShader;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material m_SSAOMaterial;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Texture2D m_RandomTexture;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool m_Supported;

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0xE196A0", Offset = "0xE196A0", VA = "0xE196A0")]
		private static Material CreateMaterial(Shader shader)
		{
			return null;
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0xE19750", Offset = "0xE19750", VA = "0xE19750")]
		private static void DestroyMaterial(Material mat)
		{
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0xE197EC", Offset = "0xE197EC", VA = "0xE197EC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0xE197F4", Offset = "0xE197F4", VA = "0xE197F4")]
		private void Start()
		{
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0xE19988", Offset = "0xE19988", VA = "0xE19988")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0xE198CC", Offset = "0xE198CC", VA = "0xE198CC")]
		private void CreateMaterials()
		{
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0xE199FC", Offset = "0xE199FC", VA = "0xE199FC")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0xE1A0B8", Offset = "0xE1A0B8", VA = "0xE1A0B8")]
		public ScreenSpaceAmbientOcclusion()
		{
		}
	}
	[Token(Token = "0x2000026")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x4F3BC4", Offset = "0x4F3BC4")]
	public class SepiaTone : ImageEffectBase
	{
		[Token(Token = "0x60000CB")]
		[Address(RVA = "0xE1A0EC", Offset = "0xE1A0EC", VA = "0xE1A0EC")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0xE1A180", Offset = "0xE1A180", VA = "0xE1A180")]
		public SepiaTone()
		{
		}
	}
	[Token(Token = "0x2000027")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x4F3C10", Offset = "0x4F3C10")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x4F3C10", Offset = "0x4F3C10")]
	public class SunShafts : PostEffectsBase
	{
		[Token(Token = "0x2000056")]
		public enum SunShaftsResolution
		{
			[Token(Token = "0x40002BA")]
			Low,
			[Token(Token = "0x40002BB")]
			Normal,
			[Token(Token = "0x40002BC")]
			High
		}

		[Token(Token = "0x2000057")]
		public enum ShaftsScreenBlendMode
		{
			[Token(Token = "0x40002BE")]
			Screen,
			[Token(Token = "0x40002BF")]
			Add
		}

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public SunShaftsResolution resolution;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public ShaftsScreenBlendMode screenBlendMode;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform sunTransform;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int radialBlurIterations;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Color sunColor;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public Color sunThreshold;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float sunShaftBlurRadius;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float sunShaftIntensity;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public float maxRadius;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool useDepthTexture;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Shader sunShaftsShader;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Material sunShaftsMaterial;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Shader simpleClearShader;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Material simpleClearMaterial;

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0xE1A188", Offset = "0xE1A188", VA = "0xE1A188", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0xE1A200", Offset = "0xE1A200", VA = "0xE1A200")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0xE1A9F4", Offset = "0xE1A9F4", VA = "0xE1A9F4")]
		public SunShafts()
		{
		}
	}
	[Token(Token = "0x2000028")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x4F3CA8", Offset = "0x4F3CA8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x4F3CA8", Offset = "0x4F3CA8")]
	internal class TiltShift : PostEffectsBase
	{
		[Token(Token = "0x2000058")]
		public enum TiltShiftMode
		{
			[Token(Token = "0x40002C1")]
			TiltShiftMode,
			[Token(Token = "0x40002C2")]
			IrisMode
		}

		[Token(Token = "0x2000059")]
		public enum TiltShiftQuality
		{
			[Token(Token = "0x40002C4")]
			Preview,
			[Token(Token = "0x40002C5")]
			Low,
			[Token(Token = "0x40002C6")]
			Normal,
			[Token(Token = "0x40002C7")]
			High
		}

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TiltShiftMode mode;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public TiltShiftQuality quality;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4F45D0", Offset = "0x4F45D0")]
		public float blurArea;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4F45E8", Offset = "0x4F45E8")]
		public float maxBlurSize;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4F4600", Offset = "0x4F4600")]
		public int downsample;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Shader tiltShiftShader;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Material tiltShiftMaterial;

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0xE1AA8C", Offset = "0xE1AA8C", VA = "0xE1AA8C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0xE1AAF0", Offset = "0xE1AAF0", VA = "0xE1AAF0")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0xE1AD80", Offset = "0xE1AD80", VA = "0xE1AD80")]
		public TiltShift()
		{
		}
	}
	[Token(Token = "0x2000029")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x4F3D30", Offset = "0x4F3D30")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x4F3D30", Offset = "0x4F3D30")]
	public class Tonemapping : PostEffectsBase
	{
		[Token(Token = "0x200005A")]
		public enum TonemapperType
		{
			[Token(Token = "0x40002C9")]
			SimpleReinhard,
			[Token(Token = "0x40002CA")]
			UserCurve,
			[Token(Token = "0x40002CB")]
			Hable,
			[Token(Token = "0x40002CC")]
			Photographic,
			[Token(Token = "0x40002CD")]
			OptimizedHejiDawson,
			[Token(Token = "0x40002CE")]
			AdaptiveReinhard,
			[Token(Token = "0x40002CF")]
			AdaptiveReinhardAutoWhite
		}

		[Token(Token = "0x200005B")]
		public enum AdaptiveTexSize
		{
			[Token(Token = "0x40002D1")]
			Square16 = 0x10,
			[Token(Token = "0x40002D2")]
			Square32 = 0x20,
			[Token(Token = "0x40002D3")]
			Square64 = 0x40,
			[Token(Token = "0x40002D4")]
			Square128 = 0x80,
			[Token(Token = "0x40002D5")]
			Square256 = 0x100,
			[Token(Token = "0x40002D6")]
			Square512 = 0x200,
			[Token(Token = "0x40002D7")]
			Square1024 = 0x400
		}

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TonemapperType type;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public AdaptiveTexSize adaptiveTextureSize;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve remapCurve;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Texture2D curveTex;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float exposureAdjustment;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float middleGrey;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float white;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float adaptionSpeed;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Shader tonemapper;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool validRenderTextureFormat;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material tonemapMaterial;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private RenderTexture rt;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private RenderTextureFormat rtFormat;

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0xE1AD9C", Offset = "0xE1AD9C", VA = "0xE1AD9C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0xE1AEE4", Offset = "0xE1AEE4", VA = "0xE1AEE4")]
		public float UpdateCurve()
		{
			return default(float);
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0xE1B18C", Offset = "0xE1B18C", VA = "0xE1B18C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0xE1B2E4", Offset = "0xE1B2E4", VA = "0xE1B2E4")]
		private bool CreateInternalRenderTexture()
		{
			return default(bool);
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0xE1B3D4", Offset = "0xE1B3D4", VA = "0xE1B3D4")]
		[ImageEffectTransformsToLDR]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0xE1BBE0", Offset = "0xE1BBE0", VA = "0xE1BBE0")]
		public Tonemapping()
		{
		}
	}
	[Token(Token = "0x200002A")]
	internal class Triangles
	{
		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Mesh[] meshes;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static int currentTris;

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0xE1BC10", Offset = "0xE1BC10", VA = "0xE1BC10")]
		private static bool HasMeshes()
		{
			return default(bool);
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0xE1BD4C", Offset = "0xE1BD4C", VA = "0xE1BD4C")]
		private static void Cleanup()
		{
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0xE1BF1C", Offset = "0xE1BF1C", VA = "0xE1BF1C")]
		private static Mesh[] GetMeshes(int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0xE1C1DC", Offset = "0xE1C1DC", VA = "0xE1C1DC")]
		private static Mesh GetMesh(int triCount, int triOffset, int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0xE1C60C", Offset = "0xE1C60C", VA = "0xE1C60C")]
		public Triangles()
		{
		}
	}
	[Token(Token = "0x200002B")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x4F3DC8", Offset = "0x4F3DC8")]
	public class Twirl : ImageEffectBase
	{
		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector2 radius;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4F4618", Offset = "0x4F4618")]
		public float angle;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Vector2 center;

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0xE1C618", Offset = "0xE1C618", VA = "0xE1C618")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0xE1C664", Offset = "0xE1C664", VA = "0xE1C664")]
		public Twirl()
		{
		}
	}
	[Token(Token = "0x200002C")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x4F3E14", Offset = "0x4F3E14")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x4F3E14", Offset = "0x4F3E14")]
	public class VignetteAndChromaticAberration : PostEffectsBase
	{
		[Token(Token = "0x200005C")]
		public enum AberrationMode
		{
			[Token(Token = "0x40002D9")]
			Simple,
			[Token(Token = "0x40002DA")]
			Advanced
		}

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AberrationMode mode;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float intensity;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float chromaticAberration;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float axialAberration;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float blur;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float blurSpread;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float luminanceDependency;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float blurDistance;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader vignetteShader;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Shader separableBlurShader;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Shader chromAberrationShader;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material m_VignetteMaterial;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Material m_SeparableBlurMaterial;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material m_ChromAberrationMaterial;

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0xE1C6E0", Offset = "0xE1C6E0", VA = "0xE1C6E0", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0xE1C778", Offset = "0xE1C778", VA = "0xE1C778")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0xE1CDA4", Offset = "0xE1CDA4", VA = "0xE1CDA4")]
		public VignetteAndChromaticAberration()
		{
		}
	}
	[Token(Token = "0x200002D")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x4F3EAC", Offset = "0x4F3EAC")]
	public class Vortex : ImageEffectBase
	{
		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector2 radius;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float angle;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Vector2 center;

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0xE1CDD4", Offset = "0xE1CDD4", VA = "0xE1CDD4")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0xE1CE20", Offset = "0xE1CE20", VA = "0xE1CE20")]
		public Vortex()
		{
		}
	}
}
namespace MEC
{
	[Token(Token = "0x200002E")]
	public class Timing : MonoBehaviour
	{
		[Token(Token = "0x200005D")]
		private struct ProcessIndex : IEquatable<ProcessIndex>
		{
			[Token(Token = "0x40002DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Segment seg;

			[Token(Token = "0x40002DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int i;

			[Token(Token = "0x6000259")]
			[Address(RVA = "0x56D634", Offset = "0x56D634", VA = "0x56D634", Slot = "4")]
			public bool Equals(ProcessIndex other)
			{
				return default(bool);
			}

			[Token(Token = "0x600025A")]
			[Address(RVA = "0x56D65C", Offset = "0x56D65C", VA = "0x56D65C", Slot = "0")]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x600025B")]
			[Address(RVA = "0xB27AAC", Offset = "0xB27AAC", VA = "0xB27AAC")]
			public static bool operator ==(ProcessIndex a, ProcessIndex b)
			{
				return default(bool);
			}

			[Token(Token = "0x600025C")]
			[Address(RVA = "0xB27ACC", Offset = "0xB27ACC", VA = "0xB27ACC")]
			public static bool operator !=(ProcessIndex a, ProcessIndex b)
			{
				return default(bool);
			}

			[Token(Token = "0x600025D")]
			[Address(RVA = "0x56D664", Offset = "0x56D664", VA = "0x56D664", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Token(Token = "0x200005E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4F3FF8", Offset = "0x4F3FF8")]
		private sealed class <_EOFPumpWatcher>d__116 : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40002DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private float <>2__current;

			[Token(Token = "0x40002DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Timing <>4__this;

			[Token(Token = "0x17000033")]
			private float System.Collections.Generic.IEnumerator<System.Single>.Current
			{
				[Token(Token = "0x6000261")]
				[Address(RVA = "0xB2681C", Offset = "0xB2681C", VA = "0xB2681C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x17000034")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000263")]
				[Address(RVA = "0xB26884", Offset = "0xB26884", VA = "0xB26884", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600025E")]
			[Address(RVA = "0xB26760", Offset = "0xB26760", VA = "0xB26760")]
			[DebuggerHidden]
			public <_EOFPumpWatcher>d__116(int <>1__state)
			{
			}

			[Token(Token = "0x600025F")]
			[Address(RVA = "0xB2678C", Offset = "0xB2678C", VA = "0xB2678C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000260")]
			[Address(RVA = "0xB26790", Offset = "0xB26790", VA = "0xB26790", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000262")]
			[Address(RVA = "0xB26824", Offset = "0xB26824", VA = "0xB26824", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200005F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4F4008", Offset = "0x4F4008")]
		private sealed class <_EOFPump>d__117 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40002E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40002E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Timing <>4__this;

			[Token(Token = "0x17000035")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000267")]
				[Address(RVA = "0xB266F0", Offset = "0xB266F0", VA = "0xB266F0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000036")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000269")]
				[Address(RVA = "0xB26758", Offset = "0xB26758", VA = "0xB26758", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000264")]
			[Address(RVA = "0xB26198", Offset = "0xB26198", VA = "0xB26198")]
			[DebuggerHidden]
			public <_EOFPump>d__117(int <>1__state)
			{
			}

			[Token(Token = "0x6000265")]
			[Address(RVA = "0xB261C4", Offset = "0xB261C4", VA = "0xB261C4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000266")]
			[Address(RVA = "0xB261C8", Offset = "0xB261C8", VA = "0xB261C8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000268")]
			[Address(RVA = "0xB266F8", Offset = "0xB266F8", VA = "0xB266F8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000060")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4F4018", Offset = "0x4F4018")]
		private sealed class <_StartWhenDone>d__252 : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40002E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private float <>2__current;

			[Token(Token = "0x40002E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Timing <>4__this;

			[Token(Token = "0x40002E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CoroutineHandle handle;

			[Token(Token = "0x40002E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public IEnumerator<float> proc;

			[Token(Token = "0x17000037")]
			private float System.Collections.Generic.IEnumerator<System.Single>.Current
			{
				[Token(Token = "0x600026E")]
				[Address(RVA = "0xB26EB8", Offset = "0xB26EB8", VA = "0xB26EB8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x17000038")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000270")]
				[Address(RVA = "0xB26F20", Offset = "0xB26F20", VA = "0xB26F20", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600026A")]
			[Address(RVA = "0xB26B08", Offset = "0xB26B08", VA = "0xB26B08")]
			[DebuggerHidden]
			public <_StartWhenDone>d__252(int <>1__state)
			{
			}

			[Token(Token = "0x600026B")]
			[Address(RVA = "0xB26B34", Offset = "0xB26B34", VA = "0xB26B34", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600026C")]
			[Address(RVA = "0xB26B8C", Offset = "0xB26B8C", VA = "0xB26B8C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600026D")]
			[Address(RVA = "0xB26B60", Offset = "0xB26B60", VA = "0xB26B60")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x600026F")]
			[Address(RVA = "0xB26EC0", Offset = "0xB26EC0", VA = "0xB26EC0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000061")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4F4028", Offset = "0x4F4028")]
		private sealed class <_StartWhenDone>d__258 : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40002E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private float <>2__current;

			[Token(Token = "0x40002EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public WWW wwwObject;

			[Token(Token = "0x40002EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public IEnumerator<float> pausedProc;

			[Token(Token = "0x17000039")]
			private float System.Collections.Generic.IEnumerator<System.Single>.Current
			{
				[Token(Token = "0x6000274")]
				[Address(RVA = "0xB270D0", Offset = "0xB270D0", VA = "0xB270D0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x1700003A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000276")]
				[Address(RVA = "0xB27138", Offset = "0xB27138", VA = "0xB27138", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000271")]
			[Address(RVA = "0xB26F84", Offset = "0xB26F84", VA = "0xB26F84")]
			[DebuggerHidden]
			public <_StartWhenDone>d__258(int <>1__state)
			{
			}

			[Token(Token = "0x6000272")]
			[Address(RVA = "0xB26FB0", Offset = "0xB26FB0", VA = "0xB26FB0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000273")]
			[Address(RVA = "0xB26FB4", Offset = "0xB26FB4", VA = "0xB26FB4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000275")]
			[Address(RVA = "0xB270D8", Offset = "0xB270D8", VA = "0xB270D8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000062")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4F4038", Offset = "0x4F4038")]
		private sealed class <_StartWhenDone>d__261 : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40002ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private float <>2__current;

			[Token(Token = "0x40002EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public AsyncOperation operation;

			[Token(Token = "0x40002EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public IEnumerator<float> pausedProc;

			[Token(Token = "0x1700003B")]
			private float System.Collections.Generic.IEnumerator<System.Single>.Current
			{
				[Token(Token = "0x600027A")]
				[Address(RVA = "0xB272E8", Offset = "0xB272E8", VA = "0xB272E8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x1700003C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600027C")]
				[Address(RVA = "0xB27350", Offset = "0xB27350", VA = "0xB27350", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000277")]
			[Address(RVA = "0xB2719C", Offset = "0xB2719C", VA = "0xB2719C")]
			[DebuggerHidden]
			public <_StartWhenDone>d__261(int <>1__state)
			{
			}

			[Token(Token = "0x6000278")]
			[Address(RVA = "0xB271C8", Offset = "0xB271C8", VA = "0xB271C8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000279")]
			[Address(RVA = "0xB271CC", Offset = "0xB271CC", VA = "0xB271CC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600027B")]
			[Address(RVA = "0xB272F0", Offset = "0xB272F0", VA = "0xB272F0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000063")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4F4048", Offset = "0x4F4048")]
		private sealed class <_StartWhenDone>d__264 : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40002F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private float <>2__current;

			[Token(Token = "0x40002F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public CustomYieldInstruction operation;

			[Token(Token = "0x40002F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public IEnumerator<float> pausedProc;

			[Token(Token = "0x1700003D")]
			private float System.Collections.Generic.IEnumerator<System.Single>.Current
			{
				[Token(Token = "0x6000280")]
				[Address(RVA = "0xB27504", Offset = "0xB27504", VA = "0xB27504", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x1700003E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000282")]
				[Address(RVA = "0xB2756C", Offset = "0xB2756C", VA = "0xB2756C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600027D")]
			[Address(RVA = "0xB273B4", Offset = "0xB273B4", VA = "0xB273B4")]
			[DebuggerHidden]
			public <_StartWhenDone>d__264(int <>1__state)
			{
			}

			[Token(Token = "0x600027E")]
			[Address(RVA = "0xB273E0", Offset = "0xB273E0", VA = "0xB273E0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600027F")]
			[Address(RVA = "0xB273E4", Offset = "0xB273E4", VA = "0xB273E4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000281")]
			[Address(RVA = "0xB2750C", Offset = "0xB2750C", VA = "0xB2750C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000064")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4F4058", Offset = "0x4F4058")]
		private sealed class <_StartWhenDone>d__269 : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40002F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private float <>2__current;

			[Token(Token = "0x40002F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Func<bool> evaluatorFunc;

			[Token(Token = "0x40002F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool continueOn;

			[Token(Token = "0x40002F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public IEnumerator<float> pausedProc;

			[Token(Token = "0x1700003F")]
			private float System.Collections.Generic.IEnumerator<System.Single>.Current
			{
				[Token(Token = "0x6000286")]
				[Address(RVA = "0xB27734", Offset = "0xB27734", VA = "0xB27734", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x17000040")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000288")]
				[Address(RVA = "0xB2779C", Offset = "0xB2779C", VA = "0xB2779C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000283")]
			[Address(RVA = "0xB275D0", Offset = "0xB275D0", VA = "0xB275D0")]
			[DebuggerHidden]
			public <_StartWhenDone>d__269(int <>1__state)
			{
			}

			[Token(Token = "0x6000284")]
			[Address(RVA = "0xB275FC", Offset = "0xB275FC", VA = "0xB275FC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000285")]
			[Address(RVA = "0xB27600", Offset = "0xB27600", VA = "0xB27600", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000287")]
			[Address(RVA = "0xB2773C", Offset = "0xB2773C", VA = "0xB2773C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000065")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4F4068", Offset = "0x4F4068")]
		private sealed class <_InjectDelay>d__270 : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40002FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private float <>2__current;

			[Token(Token = "0x40002FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Timing <>4__this;

			[Token(Token = "0x40002FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float waitTime;

			[Token(Token = "0x40002FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public IEnumerator<float> proc;

			[Token(Token = "0x17000041")]
			private float System.Collections.Generic.IEnumerator<System.Single>.Current
			{
				[Token(Token = "0x600028C")]
				[Address(RVA = "0xB26A3C", Offset = "0xB26A3C", VA = "0xB26A3C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x17000042")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600028E")]
				[Address(RVA = "0xB26AA4", Offset = "0xB26AA4", VA = "0xB26AA4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000289")]
			[Address(RVA = "0xB268E8", Offset = "0xB268E8", VA = "0xB268E8")]
			[DebuggerHidden]
			public <_InjectDelay>d__270(int <>1__state)
			{
			}

			[Token(Token = "0x600028A")]
			[Address(RVA = "0xB26914", Offset = "0xB26914", VA = "0xB26914", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600028B")]
			[Address(RVA = "0xB26918", Offset = "0xB26918", VA = "0xB26918", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600028D")]
			[Address(RVA = "0xB26A44", Offset = "0xB26A44", VA = "0xB26A44", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000066")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4F4078", Offset = "0x4F4078")]
		private sealed class <_DelayedCall>d__295 : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40002FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private float <>2__current;

			[Token(Token = "0x4000300")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Timing <>4__this;

			[Token(Token = "0x4000301")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float delay;

			[Token(Token = "0x4000302")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public GameObject cancelWith;

			[Token(Token = "0x4000303")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Action action;

			[Token(Token = "0x17000043")]
			private float System.Collections.Generic.IEnumerator<System.Single>.Current
			{
				[Token(Token = "0x6000292")]
				[Address(RVA = "0xB260CC", Offset = "0xB260CC", VA = "0xB260CC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x17000044")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000294")]
				[Address(RVA = "0xB26134", Offset = "0xB26134", VA = "0xB26134", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600028F")]
			[Address(RVA = "0xB25FC4", Offset = "0xB25FC4", VA = "0xB25FC4")]
			[DebuggerHidden]
			public <_DelayedCall>d__295(int <>1__state)
			{
			}

			[Token(Token = "0x6000290")]
			[Address(RVA = "0xB25FF0", Offset = "0xB25FF0", VA = "0xB25FF0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000291")]
			[Address(RVA = "0xB25FF4", Offset = "0xB25FF4", VA = "0xB25FF4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000293")]
			[Address(RVA = "0xB260D4", Offset = "0xB260D4", VA = "0xB260D4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000067")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4F4088", Offset = "0x4F4088")]
		private sealed class <_WatchCall>d__312 : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000304")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000305")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private float <>2__current;

			[Token(Token = "0x4000306")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Timing <>4__this;

			[Token(Token = "0x4000307")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float timeframe;

			[Token(Token = "0x4000308")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public CoroutineHandle handle;

			[Token(Token = "0x4000309")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action onDone;

			[Token(Token = "0x400030A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public GameObject gObject;

			[Token(Token = "0x17000045")]
			private float System.Collections.Generic.IEnumerator<System.Single>.Current
			{
				[Token(Token = "0x6000298")]
				[Address(RVA = "0xB27920", Offset = "0xB27920", VA = "0xB27920", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x17000046")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600029A")]
				[Address(RVA = "0xB27988", Offset = "0xB27988", VA = "0xB27988", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000295")]
			[Address(RVA = "0xB27800", Offset = "0xB27800", VA = "0xB27800")]
			[DebuggerHidden]
			public <_WatchCall>d__312(int <>1__state)
			{
			}

			[Token(Token = "0x6000296")]
			[Address(RVA = "0xB2782C", Offset = "0xB2782C", VA = "0xB2782C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000297")]
			[Address(RVA = "0xB27830", Offset = "0xB27830", VA = "0xB27830", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000299")]
			[Address(RVA = "0xB27928", Offset = "0xB27928", VA = "0xB27928", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000068")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4F4098", Offset = "0x4F4098")]
		private sealed class <_CallContinuously>d__313 : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400030B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400030C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private float <>2__current;

			[Token(Token = "0x400030D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Timing <>4__this;

			[Token(Token = "0x400030E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float period;

			[Token(Token = "0x400030F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public GameObject gObject;

			[Token(Token = "0x4000310")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Action action;

			[Token(Token = "0x17000047")]
			private float System.Collections.Generic.IEnumerator<System.Single>.Current
			{
				[Token(Token = "0x600029E")]
				[Address(RVA = "0xB25EF8", Offset = "0xB25EF8", VA = "0xB25EF8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x17000048")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60002A0")]
				[Address(RVA = "0xB25F60", Offset = "0xB25F60", VA = "0xB25F60", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600029B")]
			[Address(RVA = "0xB25D88", Offset = "0xB25D88", VA = "0xB25D88")]
			[DebuggerHidden]
			public <_CallContinuously>d__313(int <>1__state)
			{
			}

			[Token(Token = "0x600029C")]
			[Address(RVA = "0xB25DB4", Offset = "0xB25DB4", VA = "0xB25DB4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600029D")]
			[Address(RVA = "0xB25DB8", Offset = "0xB25DB8", VA = "0xB25DB8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600029F")]
			[Address(RVA = "0xB25F00", Offset = "0xB25F00", VA = "0xB25F00", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000069")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4F40A8", Offset = "0x4F40A8")]
		private sealed class <_WatchCall>d__330<T> : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000311")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <>1__state;

			[Token(Token = "0x4000312")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private float <>2__current;

			[Token(Token = "0x4000313")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Timing <>4__this;

			[Token(Token = "0x4000314")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float timeframe;

			[Token(Token = "0x4000315")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public CoroutineHandle handle;

			[Token(Token = "0x4000316")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<T> onDone;

			[Token(Token = "0x4000317")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public GameObject gObject;

			[Token(Token = "0x4000318")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public T reference;

			[Token(Token = "0x17000049")]
			private float System.Collections.Generic.IEnumerator<System.Single>.Current
			{
				[Token(Token = "0x60002A4")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x1700004A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60002A6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60002A1")]
			[DebuggerHidden]
			public <_WatchCall>d__330(int <>1__state)
			{
			}

			[Token(Token = "0x60002A2")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60002A3")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60002A5")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200006A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4F40B8", Offset = "0x4F40B8")]
		private sealed class <_CallContinuously>d__331<T> : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000319")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <>1__state;

			[Token(Token = "0x400031A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private float <>2__current;

			[Token(Token = "0x400031B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Timing <>4__this;

			[Token(Token = "0x400031C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float period;

			[Token(Token = "0x400031D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public GameObject gObject;

			[Token(Token = "0x400031E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<T> action;

			[Token(Token = "0x400031F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public T reference;

			[Token(Token = "0x1700004B")]
			private float System.Collections.Generic.IEnumerator<System.Single>.Current
			{
				[Token(Token = "0x60002AA")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x1700004C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60002AC")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60002A7")]
			[DebuggerHidden]
			public <_CallContinuously>d__331(int <>1__state)
			{
			}

			[Token(Token = "0x60002A8")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60002A9")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60002AB")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4F4634", Offset = "0x4F4634")]
		public float TimeBetweenSlowUpdateCalls;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4F466C", Offset = "0x4F466C")]
		public DebugInfoType ProfilerDebugAmount;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4F46A4", Offset = "0x4F46A4")]
		public bool AutoTriggerManualTimeframe;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4F46DC", Offset = "0x4F46DC")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x4F46DC", Offset = "0x4F46DC")]
		public int UpdateCoroutines;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4F472C", Offset = "0x4F472C")]
		public int FixedUpdateCoroutines;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4F4764", Offset = "0x4F4764")]
		public int LateUpdateCoroutines;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4F479C", Offset = "0x4F479C")]
		public int SlowUpdateCoroutines;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4F47D4", Offset = "0x4F47D4")]
		public int RealtimeUpdateCoroutines;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4F480C", Offset = "0x4F480C")]
		public int EditorUpdateCoroutines;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4F4844", Offset = "0x4F4844")]
		public int EditorSlowUpdateCoroutines;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4F487C", Offset = "0x4F487C")]
		public int EndOfFrameCoroutines;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4F48B4", Offset = "0x4F48B4")]
		public int ManualTimeframeCoroutines;

		[NonSerialized]
		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float localTime;

		[NonSerialized]
		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float deltaTime;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Func<float, float> SetManualTimeframeTime;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Func<IEnumerator<float>, CoroutineHandle, IEnumerator<float>> ReplacementFunction;

		[Token(Token = "0x40001C7")]
		public const float WaitForOneFrame = 0f;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4F48FC", Offset = "0x4F48FC")]
		private static Thread <MainThread>k__BackingField;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static object _tmpRef;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static int _tmpInt;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private static bool _tmpBool;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static Segment _tmpSegment;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private static CoroutineHandle _tmpHandle;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int _currentUpdateFrame;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private int _currentLateUpdateFrame;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int _currentSlowUpdateFrame;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private int _currentRealtimeUpdateFrame;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private int _currentEndOfFrameFrame;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private int _nextUpdateProcessSlot;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int _nextLateUpdateProcessSlot;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int _nextFixedUpdateProcessSlot;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int _nextSlowUpdateProcessSlot;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int _nextRealtimeUpdateProcessSlot;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int _nextEditorUpdateProcessSlot;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private int _nextEditorSlowUpdateProcessSlot;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private int _nextEndOfFrameProcessSlot;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private int _nextManualTimeframeProcessSlot;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int _lastUpdateProcessSlot;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private int _lastLateUpdateProcessSlot;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private int _lastFixedUpdateProcessSlot;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private int _lastSlowUpdateProcessSlot;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private int _lastRealtimeUpdateProcessSlot;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private int _lastEndOfFrameProcessSlot;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private int _lastManualTimeframeProcessSlot;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private float _lastUpdateTime;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private float _lastLateUpdateTime;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float _lastFixedUpdateTime;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private float _lastSlowUpdateTime;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private float _lastRealtimeUpdateTime;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float _lastEndOfFrameTime;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private float _lastManualTimeframeTime;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float _lastSlowUpdateDeltaTime;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float _lastEditorUpdateDeltaTime;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float _lastEditorSlowUpdateDeltaTime;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private float _lastManualTimeframeDeltaTime;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private ushort _framesSinceUpdate;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDA")]
		private ushort _expansions;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private byte _instanceID;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDD")]
		private bool _EOFPumpRan;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static readonly Dictionary<CoroutineHandle, HashSet<CoroutineHandle>> Links;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static readonly WaitForEndOfFrame EofWaitObject;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private readonly Dictionary<CoroutineHandle, HashSet<CoroutineHandle>> _waitingTriggers;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private readonly HashSet<CoroutineHandle> _allWaiting;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private readonly Dictionary<CoroutineHandle, ProcessIndex> _handleToIndex;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private readonly Dictionary<ProcessIndex, CoroutineHandle> _indexToHandle;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private readonly Dictionary<CoroutineHandle, string> _processTags;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private readonly Dictionary<string, HashSet<CoroutineHandle>> _taggedProcesses;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private readonly Dictionary<CoroutineHandle, int> _processLayers;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private readonly Dictionary<int, HashSet<CoroutineHandle>> _layeredProcesses;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private IEnumerator<float>[] UpdateProcesses;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private IEnumerator<float>[] LateUpdateProcesses;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private IEnumerator<float>[] FixedUpdateProcesses;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private IEnumerator<float>[] SlowUpdateProcesses;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private IEnumerator<float>[] RealtimeUpdateProcesses;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private IEnumerator<float>[] EditorUpdateProcesses;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private IEnumerator<float>[] EditorSlowUpdateProcesses;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private IEnumerator<float>[] EndOfFrameProcesses;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private IEnumerator<float>[] ManualTimeframeProcesses;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private bool[] UpdatePaused;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private bool[] LateUpdatePaused;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private bool[] FixedUpdatePaused;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private bool[] SlowUpdatePaused;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private bool[] RealtimeUpdatePaused;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private bool[] EditorUpdatePaused;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private bool[] EditorSlowUpdatePaused;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private bool[] EndOfFramePaused;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private bool[] ManualTimeframePaused;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private CoroutineHandle _eofWatcherHandle;

		[Token(Token = "0x400020F")]
		private const ushort FramesUntilMaintenance = 64;

		[Token(Token = "0x4000210")]
		private const int ProcessArrayChunkSize = 64;

		[Token(Token = "0x4000211")]
		private const int InitialBufferSizeLarge = 256;

		[Token(Token = "0x4000212")]
		private const int InitialBufferSizeMedium = 64;

		[Token(Token = "0x4000213")]
		private const int InitialBufferSizeSmall = 8;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static readonly Dictionary<byte, Timing> ActiveInstances;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static Timing _instance;

		[Token(Token = "0x17000008")]
		public static float LocalTime
		{
			[Token(Token = "0x60000E6")]
			[Address(RVA = "0xBD9068", Offset = "0xBD9068", VA = "0xBD9068")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000009")]
		public static float DeltaTime
		{
			[Token(Token = "0x60000E7")]
			[Address(RVA = "0xBD934C", Offset = "0xBD934C", VA = "0xBD934C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700000A")]
		public static Thread MainThread
		{
			[Token(Token = "0x60000EA")]
			[Address(RVA = "0xBD9598", Offset = "0xBD9598", VA = "0xBD9598")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4F513C", Offset = "0x4F513C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000EB")]
			[Address(RVA = "0xBD9600", Offset = "0xBD9600", VA = "0xBD9600")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4F514C", Offset = "0x4F514C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700000B")]
		public static Timing Instance
		{
			[Token(Token = "0x60000EC")]
			[Address(RVA = "0xBD90D4", Offset = "0xBD90D4", VA = "0xBD90D4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000ED")]
			[Address(RVA = "0xBD966C", Offset = "0xBD966C", VA = "0xBD966C")]
			set
			{
			}
		}

		[Token(Token = "0x14000001")]
		public static event Action OnPreExecute
		{
			[Token(Token = "0x60000E8")]
			[Address(RVA = "0xBD93B8", Offset = "0xBD93B8", VA = "0xBD93B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4F511C", Offset = "0x4F511C")]
			add
			{
			}
			[Token(Token = "0x60000E9")]
			[Address(RVA = "0xBD94A8", Offset = "0xBD94A8", VA = "0xBD94A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4F512C", Offset = "0x4F512C")]
			remove
			{
			}
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0xBD96D8", Offset = "0xBD96D8", VA = "0xBD96D8")]
		private void Awake()
		{
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0xBD99B0", Offset = "0xBD99B0", VA = "0xBD99B0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0xBD9AC0", Offset = "0xBD9AC0", VA = "0xBD9AC0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0xBD9DCC", Offset = "0xBD9DCC", VA = "0xBD9DCC")]
		private void Update()
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0xBDCA24", Offset = "0xBDCA24", VA = "0xBDCA24")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0xBDCEC4", Offset = "0xBDCEC4", VA = "0xBDCEC4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0xBDAF60", Offset = "0xBDAF60", VA = "0xBDAF60")]
		public void TriggerManualTimeframeUpdate()
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0xBD9B38", Offset = "0xBD9B38", VA = "0xBD9B38")]
		private bool OnEditorStart()
		{
			return default(bool);
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0xBD9B40", Offset = "0xBD9B40", VA = "0xBD9B40")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x4F515C", Offset = "0x4F515C")]
		private IEnumerator<float> _EOFPumpWatcher()
		{
			return null;
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0xBDD364", Offset = "0xBDD364", VA = "0xBDD364")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x4F51C0", Offset = "0x4F51C0")]
		private IEnumerator _EOFPump()
		{
			return null;
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0xBDB440", Offset = "0xBDB440", VA = "0xBDB440")]
		private void RemoveUnused()
		{
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0xBDD86C", Offset = "0xBDD86C", VA = "0xBDD86C")]
		private void EditorRemoveUnused()
		{
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0xBDDF9C", Offset = "0xBDDF9C", VA = "0xBDDF9C")]
		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0xBDFAF4", Offset = "0xBDFAF4", VA = "0xBDFAF4")]
		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, GameObject gameObj)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0xBDFC4C", Offset = "0xBDFC4C", VA = "0xBDFC4C")]
		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, int layer)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0xBDFD34", Offset = "0xBDFD34", VA = "0xBDFD34")]
		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0xBDFDF8", Offset = "0xBDFDF8", VA = "0xBDFDF8")]
		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, GameObject gameObj, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0xBDFF54", Offset = "0xBDFF54", VA = "0xBDFF54")]
		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, int layer, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0xBE0040", Offset = "0xBE0040", VA = "0xBE0040")]
		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, Segment segment)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0xBE0104", Offset = "0xBE0104", VA = "0xBE0104")]
		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, Segment segment, GameObject gameObj)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0xBE0260", Offset = "0xBE0260", VA = "0xBE0260")]
		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, Segment segment, int layer)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0xBE034C", Offset = "0xBE034C", VA = "0xBE034C")]
		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, Segment segment, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0xBE041C", Offset = "0xBE041C", VA = "0xBE041C")]
		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, Segment segment, GameObject gameObj, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0xBE0584", Offset = "0xBE0584", VA = "0xBE0584")]
		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, Segment segment, int layer, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0xBE067C", Offset = "0xBE067C", VA = "0xBE067C")]
		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0xBE06E4", Offset = "0xBE06E4", VA = "0xBE06E4")]
		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, GameObject gameObj)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0xBE07EC", Offset = "0xBE07EC", VA = "0xBE07EC")]
		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, int layer)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0xBE08A0", Offset = "0xBE08A0", VA = "0xBE08A0")]
		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0xBE090C", Offset = "0xBE090C", VA = "0xBE090C")]
		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, GameObject gameObj, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0xBE0A20", Offset = "0xBE0A20", VA = "0xBE0A20")]
		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, int layer, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0xBE0AE0", Offset = "0xBE0AE0", VA = "0xBE0AE0")]
		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, Segment segment)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0xBE0B4C", Offset = "0xBE0B4C", VA = "0xBE0B4C")]
		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, Segment segment, GameObject gameObj)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0xBE0C60", Offset = "0xBE0C60", VA = "0xBE0C60")]
		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, Segment segment, int layer)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0xBE0D20", Offset = "0xBE0D20", VA = "0xBE0D20")]
		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, Segment segment, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0xBE0D98", Offset = "0xBE0D98", VA = "0xBE0D98")]
		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, Segment segment, GameObject gameObj, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0xBE0EB0", Offset = "0xBE0EB0", VA = "0xBE0EB0")]
		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, Segment segment, int layer, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0xBE0F74", Offset = "0xBE0F74", VA = "0xBE0F74")]
		public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, CoroutineHandle handle, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0xBE1428", Offset = "0xBE1428", VA = "0xBE1428")]
		public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, GameObject gameObj, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0xBE1528", Offset = "0xBE1528", VA = "0xBE1528")]
		public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, int layer, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0xBE2004", Offset = "0xBE2004", VA = "0xBE2004")]
		public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0xBE238C", Offset = "0xBE238C", VA = "0xBE238C")]
		public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, GameObject gameObj, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0xBE24A4", Offset = "0xBE24A4", VA = "0xBE24A4")]
		public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, int layer, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0xBE2A94", Offset = "0xBE2A94", VA = "0xBE2A94")]
		public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, CoroutineHandle handle, Segment segment, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0xBE2C40", Offset = "0xBE2C40", VA = "0xBE2C40")]
		public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, Segment segment, GameObject gameObj, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0xBE2D54", Offset = "0xBE2D54", VA = "0xBE2D54")]
		public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, Segment segment, int layer, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0xBE3030", Offset = "0xBE3030", VA = "0xBE3030")]
		public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, Segment segment, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0xBE32D4", Offset = "0xBE32D4", VA = "0xBE32D4")]
		public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, Segment segment, GameObject gameObj, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0xBE33F8", Offset = "0xBE33F8", VA = "0xBE33F8")]
		public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, Segment segment, int layer, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0xBE3904", Offset = "0xBE3904", VA = "0xBE3904")]
		public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, CoroutineHandle handle, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0xBE3A90", Offset = "0xBE3A90", VA = "0xBE3A90")]
		public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, GameObject gameObj, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0xBE3B5C", Offset = "0xBE3B5C", VA = "0xBE3B5C")]
		public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, int layer, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0xBD9BB0", Offset = "0xBD9BB0", VA = "0xBD9BB0")]
		public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0xBE427C", Offset = "0xBE427C", VA = "0xBE427C")]
		public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, GameObject gameObj, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0xBE4358", Offset = "0xBE4358", VA = "0xBE4358")]
		public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, int layer, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0xBE4AB8", Offset = "0xBE4AB8", VA = "0xBE4AB8")]
		public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, Segment segment, GameObject gameObj, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0xBE4B90", Offset = "0xBE4B90", VA = "0xBE4B90")]
		public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, Segment segment, int layer, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0xBE4DF0", Offset = "0xBE4DF0", VA = "0xBE4DF0")]
		public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, Segment segment, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0xBE5018", Offset = "0xBE5018", VA = "0xBE5018")]
		public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, Segment segment, GameObject gameObj, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0xBE5108", Offset = "0xBE5108", VA = "0xBE5108")]
		public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, Segment segment, int layer, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0xBDE05C", Offset = "0xBDE05C", VA = "0xBDE05C")]
		private CoroutineHandle RunCoroutineInternal(IEnumerator<float> coroutine, Segment segment, int? layer, string tag, CoroutineHandle handle, bool prewarm)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0xBE5714", Offset = "0xBE5714", VA = "0xBE5714")]
		public static int KillCoroutines()
		{
			return default(int);
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0xBE57F0", Offset = "0xBE57F0", VA = "0xBE57F0")]
		public int KillCoroutinesOnInstance()
		{
			return default(int);
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0xBD8B18", Offset = "0xBD8B18", VA = "0xBD8B18")]
		public static int KillCoroutines(CoroutineHandle handle)
		{
			return default(int);
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0xBDAD70", Offset = "0xBDAD70", VA = "0xBDAD70")]
		public int KillCoroutinesOnInstance(CoroutineHandle handle)
		{
			return default(int);
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0xBE5C4C", Offset = "0xBE5C4C", VA = "0xBE5C4C")]
		public static int KillCoroutines(GameObject gameObj)
		{
			return default(int);
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0xBE5D50", Offset = "0xBE5D50", VA = "0xBE5D50")]
		public int KillCoroutinesOnInstance(GameObject gameObj)
		{
			return default(int);
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0xBE17F8", Offset = "0xBE17F8", VA = "0xBE17F8")]
		public static int KillCoroutines(int layer)
		{
			return default(int);
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0xBE3DB0", Offset = "0xBE3DB0", VA = "0xBE3DB0")]
		public int KillCoroutinesOnInstance(int layer)
		{
			return default(int);
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0xBE229C", Offset = "0xBE229C", VA = "0xBE229C")]
		public static int KillCoroutines(string tag)
		{
			return default(int);
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0xBE4004", Offset = "0xBE4004", VA = "0xBE4004")]
		public int KillCoroutinesOnInstance(string tag)
		{
			return default(int);
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0xBE5E94", Offset = "0xBE5E94", VA = "0xBE5E94")]
		public static int KillCoroutines(GameObject gameObj, string tag)
		{
			return default(int);
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0xBE5FA0", Offset = "0xBE5FA0", VA = "0xBE5FA0")]
		public int KillCoroutinesOnInstance(GameObject gameObj, string tag)
		{
			return default(int);
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0xBE299C", Offset = "0xBE299C", VA = "0xBE299C")]
		public static int KillCoroutines(int layer, string tag)
		{
			return default(int);
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0xBE46F0", Offset = "0xBE46F0", VA = "0xBE46F0")]
		public int KillCoroutinesOnInstance(int layer, string tag)
		{
			return default(int);
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0xBE5B08", Offset = "0xBE5B08", VA = "0xBE5B08")]
		public static Timing GetInstance(byte ID)
		{
			return null;
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0xBE5FE0", Offset = "0xBE5FE0", VA = "0xBE5FE0")]
		public static float WaitForSeconds(float waitTime)
		{
			return default(float);
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0xBE606C", Offset = "0xBE606C", VA = "0xBE606C")]
		public float WaitForSecondsOnInstance(float waitTime)
		{
			return default(float);
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0xBDAA74", Offset = "0xBDAA74", VA = "0xBDAA74")]
		private bool UpdateTimeValues(Segment segment)
		{
			return default(bool);
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0xBE60B0", Offset = "0xBE60B0", VA = "0xBE60B0")]
		private float GetSegmentTime(Segment segment)
		{
			return default(float);
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0xBE619C", Offset = "0xBE619C", VA = "0xBE619C")]
		public static int PauseCoroutines()
		{
			return default(int);
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0xBE6278", Offset = "0xBE6278", VA = "0xBE6278")]
		public int PauseCoroutinesOnInstance()
		{
			return default(int);
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0xBD8E28", Offset = "0xBD8E28", VA = "0xBD8E28")]
		public static int PauseCoroutines(CoroutineHandle handle)
		{
			return default(int);
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0xBE7518", Offset = "0xBE7518", VA = "0xBE7518")]
		public int PauseCoroutinesOnInstance(CoroutineHandle handle)
		{
			return default(int);
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0xBE84B0", Offset = "0xBE84B0", VA = "0xBE84B0")]
		public static int PauseCoroutines(GameObject gameObj)
		{
			return default(int);
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0xBE85A0", Offset = "0xBE85A0", VA = "0xBE85A0")]
		public int PauseCoroutinesOnInstance(GameObject gameObj)
		{
			return default(int);
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0xBE891C", Offset = "0xBE891C", VA = "0xBE891C")]
		public static int PauseCoroutines(int layer)
		{
			return default(int);
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0xBE8650", Offset = "0xBE8650", VA = "0xBE8650")]
		public int PauseCoroutinesOnInstance(int layer)
		{
			return default(int);
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0xBE8A0C", Offset = "0xBE8A0C", VA = "0xBE8A0C")]
		public static int PauseCoroutines(string tag)
		{
			return default(int);
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0xBE8AFC", Offset = "0xBE8AFC", VA = "0xBE8AFC")]
		public int PauseCoroutinesOnInstance(string tag)
		{
			return default(int);
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0xBE8DCC", Offset = "0xBE8DCC", VA = "0xBE8DCC")]
		public static int PauseCoroutines(GameObject gameObj, string tag)
		{
			return default(int);
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0xBE9278", Offset = "0xBE9278", VA = "0xBE9278")]
		public int PauseCoroutinesOnInstance(GameObject gameObj, string tag)
		{
			return default(int);
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0xBE9330", Offset = "0xBE9330", VA = "0xBE9330")]
		public static int PauseCoroutines(int layer, string tag)
		{
			return default(int);
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0xBE8ED8", Offset = "0xBE8ED8", VA = "0xBE8ED8")]
		public int PauseCoroutinesOnInstance(int layer, string tag)
		{
			return default(int);
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0xBE9428", Offset = "0xBE9428", VA = "0xBE9428")]
		public static int ResumeCoroutines()
		{
			return default(int);
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0xBE9504", Offset = "0xBE9504", VA = "0xBE9504")]
		public int ResumeCoroutinesOnInstance()
		{
			return default(int);
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0xBD8EFC", Offset = "0xBD8EFC", VA = "0xBD8EFC")]
		public static int ResumeCoroutines(CoroutineHandle handle)
		{
			return default(int);
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0xBE9DBC", Offset = "0xBE9DBC", VA = "0xBE9DBC")]
		public int ResumeCoroutinesOnInstance(CoroutineHandle handle)
		{
			return default(int);
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0xBEA034", Offset = "0xBEA034", VA = "0xBEA034")]
		public static int ResumeCoroutines(GameObject gameObj)
		{
			return default(int);
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0xBEA420", Offset = "0xBEA420", VA = "0xBEA420")]
		public int ResumeCoroutinesOnInstance(GameObject gameObj)
		{
			return default(int);
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0xBEA4D0", Offset = "0xBEA4D0", VA = "0xBEA4D0")]
		public static int ResumeCoroutines(int layer)
		{
			return default(int);
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0xBEA138", Offset = "0xBEA138", VA = "0xBEA138")]
		public int ResumeCoroutinesOnInstance(int layer)
		{
			return default(int);
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0xBEA5C0", Offset = "0xBEA5C0", VA = "0xBEA5C0")]
		public static int ResumeCoroutines(string tag)
		{
			return default(int);
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0xBEA6B0", Offset = "0xBEA6B0", VA = "0xBEA6B0")]
		public int ResumeCoroutinesOnInstance(string tag)
		{
			return default(int);
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0xBEA99C", Offset = "0xBEA99C", VA = "0xBEA99C")]
		public static int ResumeCoroutines(GameObject gameObj, string tag)
		{
			return default(int);
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0xBEAE50", Offset = "0xBEAE50", VA = "0xBEAE50")]
		public int ResumeCoroutinesOnInstance(GameObject gameObj, string tag)
		{
			return default(int);
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0xBEAF08", Offset = "0xBEAF08", VA = "0xBEAF08")]
		public static int ResumeCoroutines(int layer, string tag)
		{
			return default(int);
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0xBEAAA8", Offset = "0xBEAAA8", VA = "0xBEAAA8")]
		public int ResumeCoroutinesOnInstance(int layer, string tag)
		{
			return default(int);
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0xBD7D40", Offset = "0xBD7D40", VA = "0xBD7D40")]
		public static string GetTag(CoroutineHandle handle)
		{
			return null;
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0xBD80A0", Offset = "0xBD80A0", VA = "0xBD80A0")]
		public static int? GetLayer(CoroutineHandle handle)
		{
			return null;
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0xBD859C", Offset = "0xBD859C", VA = "0xBD859C")]
		public static Segment GetSegment(CoroutineHandle handle)
		{
			return default(Segment);
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0xBD7EDC", Offset = "0xBD7EDC", VA = "0xBD7EDC")]
		public static bool SetTag(CoroutineHandle handle, string newTag, bool overwriteExisting = true)
		{
			return default(bool);
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0xBD83D8", Offset = "0xBD83D8", VA = "0xBD83D8")]
		public static bool SetLayer(CoroutineHandle handle, int newLayer, bool overwriteExisting = true)
		{
			return default(bool);
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0xBD870C", Offset = "0xBD870C", VA = "0xBD870C")]
		public static bool SetSegment(CoroutineHandle handle, Segment newSegment)
		{
			return default(bool);
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0xBEB374", Offset = "0xBEB374", VA = "0xBEB374")]
		public static bool RemoveTag(CoroutineHandle handle)
		{
			return default(bool);
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0xBD82C0", Offset = "0xBD82C0", VA = "0xBD82C0")]
		public static bool RemoveLayer(CoroutineHandle handle)
		{
			return default(bool);
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0xBD8984", Offset = "0xBD8984", VA = "0xBD8984")]
		public static bool IsRunning(CoroutineHandle handle)
		{
			return default(bool);
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0xBD8C54", Offset = "0xBD8C54", VA = "0xBD8C54")]
		public static bool IsPaused(CoroutineHandle handle)
		{
			return default(bool);
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0xBE54A4", Offset = "0xBE54A4", VA = "0xBE54A4")]
		private void AddTagOnInstance(string tag, CoroutineHandle handle)
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0xBE55DC", Offset = "0xBE55DC", VA = "0xBE55DC")]
		private void AddLayerOnInstance(int layer, CoroutineHandle handle)
		{
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0xBEB000", Offset = "0xBEB000", VA = "0xBEB000")]
		private void RemoveTagOnInstance(CoroutineHandle handle)
		{
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0xBEB154", Offset = "0xBEB154", VA = "0xBEB154")]
		private void RemoveLayerOnInstance(CoroutineHandle handle)
		{
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0xBDD630", Offset = "0xBDD630", VA = "0xBDD630")]
		private void RemoveGraffiti(CoroutineHandle handle)
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0xBEB2A8", Offset = "0xBEB2A8", VA = "0xBEB2A8")]
		private IEnumerator<float> CoindexExtract(ProcessIndex coindex)
		{
			return null;
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0xBDD3D4", Offset = "0xBDD3D4", VA = "0xBDD3D4")]
		private bool CoindexIsNull(ProcessIndex coindex)
		{
			return default(bool);
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0xBEB4AC", Offset = "0xBEB4AC", VA = "0xBEB4AC")]
		private IEnumerator<float> CoindexPeek(ProcessIndex coindex)
		{
			return null;
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0xBE5BD8", Offset = "0xBE5BD8", VA = "0xBE5BD8")]
		private bool Nullify(CoroutineHandle handle)
		{
			return default(bool);
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0xBE5D88", Offset = "0xBE5D88", VA = "0xBE5D88")]
		private bool Nullify(ProcessIndex coindex)
		{
			return default(bool);
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0xBE776C", Offset = "0xBE776C", VA = "0xBE776C")]
		private bool SetPause(ProcessIndex coindex, bool newPausedState = true)
		{
			return default(bool);
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0xBEB574", Offset = "0xBEB574", VA = "0xBEB574")]
		private IEnumerator<float> CreatePause(ProcessIndex coindex, IEnumerator<float> coptr, bool newPausedState = true)
		{
			return null;
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0xBEB3E0", Offset = "0xBEB3E0", VA = "0xBEB3E0")]
		private bool CoindexIsPaused(ProcessIndex coindex)
		{
			return default(bool);
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0xBEC264", Offset = "0xBEC264", VA = "0xBEC264")]
		private void CoindexReplace(ProcessIndex coindex, IEnumerator<float> replacement)
		{
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0xBEC360", Offset = "0xBEC360", VA = "0xBEC360")]
		public static float WaitUntilDone(IEnumerator<float> newCoroutine)
		{
			return default(float);
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0xBEC638", Offset = "0xBEC638", VA = "0xBEC638")]
		public static float WaitUntilDone(IEnumerator<float> newCoroutine, string tag)
		{
			return default(float);
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0xBEC6B8", Offset = "0xBEC6B8", VA = "0xBEC6B8")]
		public static float WaitUntilDone(IEnumerator<float> newCoroutine, int layer)
		{
			return default(float);
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0xBEC738", Offset = "0xBEC738", VA = "0xBEC738")]
		public static float WaitUntilDone(IEnumerator<float> newCoroutine, int layer, string tag)
		{
			return default(float);
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0xBEC7C0", Offset = "0xBEC7C0", VA = "0xBEC7C0")]
		public static float WaitUntilDone(IEnumerator<float> newCoroutine, Segment segment)
		{
			return default(float);
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0xBEC840", Offset = "0xBEC840", VA = "0xBEC840")]
		public static float WaitUntilDone(IEnumerator<float> newCoroutine, Segment segment, string tag)
		{
			return default(float);
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0xBEC8C8", Offset = "0xBEC8C8", VA = "0xBEC8C8")]
		public static float WaitUntilDone(IEnumerator<float> newCoroutine, Segment segment, int layer)
		{
			return default(float);
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0xBEC950", Offset = "0xBEC950", VA = "0xBEC950")]
		public static float WaitUntilDone(IEnumerator<float> newCoroutine, Segment segment, int layer, string tag)
		{
			return default(float);
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0xBEC9E8", Offset = "0xBEC9E8", VA = "0xBEC9E8")]
		public static float WaitUntilDone(CoroutineHandle otherCoroutine)
		{
			return default(float);
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0xBEC3D0", Offset = "0xBEC3D0", VA = "0xBEC3D0")]
		public static float WaitUntilDone(CoroutineHandle otherCoroutine, bool warnOnIssue)
		{
			return default(float);
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0xBECAD8", Offset = "0xBECAD8", VA = "0xBECAD8")]
		private IEnumerator<float> WaitUntilDoneWrapper(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			return null;
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0xBE111C", Offset = "0xBE111C", VA = "0xBE111C")]
		public static void WaitForOtherHandles(CoroutineHandle handle, CoroutineHandle otherHandle, bool warnOnIssue = true)
		{
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0xBE18E8", Offset = "0xBE18E8", VA = "0xBE18E8")]
		public static void WaitForOtherHandles(CoroutineHandle handle, IEnumerable<CoroutineHandle> otherHandles, bool warnOnIssue = true)
		{
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0xBECA50", Offset = "0xBECA50", VA = "0xBECA50")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x4F5224", Offset = "0x4F5224")]
		private IEnumerator<float> _StartWhenDone(CoroutineHandle handle, IEnumerator<float> proc)
		{
			return null;
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0xBDD4A4", Offset = "0xBDD4A4", VA = "0xBDD4A4")]
		private void CloseWaitingProcess(CoroutineHandle handle)
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0xBECC3C", Offset = "0xBECC3C", VA = "0xBECC3C")]
		private bool HandleIsInWaitingList(CoroutineHandle handle)
		{
			return default(bool);
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0xBECD08", Offset = "0xBECD08", VA = "0xBECD08")]
		private static IEnumerator<float> ReturnTmpRefForRepFunc(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			return null;
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0xBECD7C", Offset = "0xBECD7C", VA = "0xBECD7C")]
		public static float WaitUntilDone(WWW wwwObject)
		{
			return default(float);
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0xBECE54", Offset = "0xBECE54", VA = "0xBECE54")]
		private static IEnumerator<float> WaitUntilDoneWwwHelper(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			return null;
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0xBECF04", Offset = "0xBECF04", VA = "0xBECF04")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x4F5288", Offset = "0x4F5288")]
		private static IEnumerator<float> _StartWhenDone(WWW wwwObject, IEnumerator<float> pausedProc)
		{
			return null;
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0xBECF80", Offset = "0xBECF80", VA = "0xBECF80")]
		public static float WaitUntilDone(AsyncOperation operation)
		{
			return default(float);
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0xBED048", Offset = "0xBED048", VA = "0xBED048")]
		private static IEnumerator<float> WaitUntilDoneAscOpHelper(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			return null;
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0xBED0F8", Offset = "0xBED0F8", VA = "0xBED0F8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x4F52EC", Offset = "0x4F52EC")]
		private static IEnumerator<float> _StartWhenDone(AsyncOperation operation, IEnumerator<float> pausedProc)
		{
			return null;
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0xBED174", Offset = "0xBED174", VA = "0xBED174")]
		public static float WaitUntilDone(CustomYieldInstruction operation)
		{
			return default(float);
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0xBED240", Offset = "0xBED240", VA = "0xBED240")]
		private static IEnumerator<float> WaitUntilDoneCustYieldHelper(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			return null;
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0xBED2F0", Offset = "0xBED2F0", VA = "0xBED2F0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x4F5350", Offset = "0x4F5350")]
		private static IEnumerator<float> _StartWhenDone(CustomYieldInstruction operation, IEnumerator<float> pausedProc)
		{
			return null;
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0xBED36C", Offset = "0xBED36C", VA = "0xBED36C")]
		public static float WaitUntilTrue(Func<bool> evaluatorFunc)
		{
			return default(float);
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0xBED43C", Offset = "0xBED43C", VA = "0xBED43C")]
		private static IEnumerator<float> WaitUntilTrueHelper(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			return null;
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0xBED560", Offset = "0xBED560", VA = "0xBED560")]
		public static float WaitUntilFalse(Func<bool> evaluatorFunc)
		{
			return default(float);
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0xBED630", Offset = "0xBED630", VA = "0xBED630")]
		private static IEnumerator<float> WaitUntilFalseHelper(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			return null;
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0xBED4D4", Offset = "0xBED4D4", VA = "0xBED4D4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x4F53B4", Offset = "0x4F53B4")]
		private static IEnumerator<float> _StartWhenDone(Func<bool> evaluatorFunc, bool continueOn, IEnumerator<float> pausedProc)
		{
			return null;
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0xBE7488", Offset = "0xBE7488", VA = "0xBE7488")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x4F5418", Offset = "0x4F5418")]
		private IEnumerator<float> _InjectDelay(IEnumerator<float> proc, float waitTime)
		{
			return null;
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0xBED6C8", Offset = "0xBED6C8", VA = "0xBED6C8")]
		public bool LockCoroutine(CoroutineHandle coroutine, CoroutineHandle key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0xBED860", Offset = "0xBED860", VA = "0xBED860")]
		public bool UnlockCoroutine(CoroutineHandle coroutine, CoroutineHandle key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0xBED9B0", Offset = "0xBED9B0", VA = "0xBED9B0")]
		public static int LinkCoroutines(CoroutineHandle master, CoroutineHandle slave)
		{
			return default(int);
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0xBEDC04", Offset = "0xBEDC04", VA = "0xBEDC04")]
		public static int UnlinkCoroutines(CoroutineHandle master, CoroutineHandle slave, bool twoWay = false)
		{
			return default(int);
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0xBEDF58", Offset = "0xBEDF58", VA = "0xBEDF58")]
		public static float GetMyHandle(Action<CoroutineHandle> reciever)
		{
			return default(float);
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0xBEE00C", Offset = "0xBEE00C", VA = "0xBEE00C")]
		private static IEnumerator<float> GetHandleHelper(IEnumerator<float> input, CoroutineHandle handle)
		{
			return null;
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0xBEE0C4", Offset = "0xBEE0C4", VA = "0xBEE0C4")]
		public static float SwitchCoroutine(Segment newSegment)
		{
			return default(float);
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0xBEE178", Offset = "0xBEE178", VA = "0xBEE178")]
		private static IEnumerator<float> SwitchCoroutineRepS(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			return null;
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0xBEE2E0", Offset = "0xBEE2E0", VA = "0xBEE2E0")]
		public static float SwitchCoroutine(Segment newSegment, string newTag)
		{
			return default(float);
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0xBEE3A8", Offset = "0xBEE3A8", VA = "0xBEE3A8")]
		private static IEnumerator<float> SwitchCoroutineRepST(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			return null;
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0xBEE518", Offset = "0xBEE518", VA = "0xBEE518")]
		public static float SwitchCoroutine(Segment newSegment, int newLayer)
		{
			return default(float);
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0xBEE5E0", Offset = "0xBEE5E0", VA = "0xBEE5E0")]
		private static IEnumerator<float> SwitchCoroutineRepSL(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			return null;
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0xBEE704", Offset = "0xBEE704", VA = "0xBEE704")]
		public static float SwitchCoroutine(Segment newSegment, int newLayer, string newTag)
		{
			return default(float);
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0xBEE7D8", Offset = "0xBEE7D8", VA = "0xBEE7D8")]
		private static IEnumerator<float> SwitchCoroutineRepSLT(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			return null;
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0xBEE8DC", Offset = "0xBEE8DC", VA = "0xBEE8DC")]
		public static float SwitchCoroutine(string newTag)
		{
			return default(float);
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0xBEE990", Offset = "0xBEE990", VA = "0xBEE990")]
		private static IEnumerator<float> SwitchCoroutineRepT(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			return null;
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0xBEEAA0", Offset = "0xBEEAA0", VA = "0xBEEAA0")]
		public static float SwitchCoroutine(int newLayer)
		{
			return default(float);
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0xBEEB54", Offset = "0xBEEB54", VA = "0xBEEB54")]
		private static IEnumerator<float> SwitchCoroutineRepL(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			return null;
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0xBEEBF4", Offset = "0xBEEBF4", VA = "0xBEEBF4")]
		public static float SwitchCoroutine(int newLayer, string newTag)
		{
			return default(float);
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0xBEECBC", Offset = "0xBEECBC", VA = "0xBEECBC")]
		private static IEnumerator<float> SwitchCoroutineRepLT(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			return null;
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0xBEEDF0", Offset = "0xBEEDF0", VA = "0xBEEDF0")]
		public static CoroutineHandle CallDelayed(float delay, Action action)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0xBEEF20", Offset = "0xBEEF20", VA = "0xBEEF20")]
		public CoroutineHandle CallDelayedOnInstance(float delay, Action action)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0xBEEF60", Offset = "0xBEEF60", VA = "0xBEEF60")]
		public static CoroutineHandle CallDelayed(float delay, Action action, GameObject gameObject)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0xBEF00C", Offset = "0xBEF00C", VA = "0xBEF00C")]
		public CoroutineHandle CallDelayedOnInstance(float delay, Action action, GameObject gameObject)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0xBEEE8C", Offset = "0xBEEE8C", VA = "0xBEEE8C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x4F547C", Offset = "0x4F547C")]
		private IEnumerator<float> _DelayedCall(float delay, Action action, GameObject cancelWith)
		{
			return null;
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0xBEF050", Offset = "0xBEF050", VA = "0xBEF050")]
		public static CoroutineHandle CallPeriodically(float timeframe, float period, Action action, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0xBEF280", Offset = "0xBEF280", VA = "0xBEF280")]
		public CoroutineHandle CallPeriodicallyOnInstance(float timeframe, float period, Action action, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0xBEF318", Offset = "0xBEF318", VA = "0xBEF318")]
		public static CoroutineHandle CallPeriodically(float timeframe, float period, Action action, GameObject gameObject, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0xBEF428", Offset = "0xBEF428", VA = "0xBEF428")]
		public CoroutineHandle CallPeriodicallyOnInstance(float timeframe, float period, Action action, GameObject gameObject, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0xBEF530", Offset = "0xBEF530", VA = "0xBEF530")]
		public static CoroutineHandle CallPeriodically(float timeframe, float period, Action action, Segment timing, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0xBEF634", Offset = "0xBEF634", VA = "0xBEF634")]
		public CoroutineHandle CallPeriodicallyOnInstance(float timeframe, float period, Action action, Segment timing, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0xBEF73C", Offset = "0xBEF73C", VA = "0xBEF73C")]
		public static CoroutineHandle CallPeriodically(float timeframe, float period, Action action, Segment timing, GameObject gameObject, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0xBEF860", Offset = "0xBEF860", VA = "0xBEF860")]
		public CoroutineHandle CallPeriodicallyOnInstance(float timeframe, float period, Action action, Segment timing, GameObject gameObject, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0xBEF974", Offset = "0xBEF974", VA = "0xBEF974")]
		public static CoroutineHandle CallContinuously(float timeframe, Action action, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0xBEFA74", Offset = "0xBEFA74", VA = "0xBEFA74")]
		public CoroutineHandle CallContinuouslyOnInstance(float timeframe, Action action, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0xBEFB64", Offset = "0xBEFB64", VA = "0xBEFB64")]
		public static CoroutineHandle CallContinuously(float timeframe, Action action, GameObject gameObject, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0xBEFC70", Offset = "0xBEFC70", VA = "0xBEFC70")]
		public CoroutineHandle CallContinuouslyOnInstance(float timeframe, Action action, GameObject gameObject, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0xBEFD74", Offset = "0xBEFD74", VA = "0xBEFD74")]
		public static CoroutineHandle CallContinuously(float timeframe, Action action, Segment timing, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0xBEFE80", Offset = "0xBEFE80", VA = "0xBEFE80")]
		public CoroutineHandle CallContinuouslyOnInstance(float timeframe, Action action, Segment timing, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0xBEFF84", Offset = "0xBEFF84", VA = "0xBEFF84")]
		public static CoroutineHandle CallContinuously(float timeframe, Action action, Segment timing, GameObject gameObject, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0xBF00A4", Offset = "0xBF00A4", VA = "0xBF00A4")]
		public CoroutineHandle CallContinuouslyOnInstance(float timeframe, Action action, Segment timing, GameObject gameObject, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0xBEF1DC", Offset = "0xBEF1DC", VA = "0xBEF1DC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x4F54E0", Offset = "0x4F54E0")]
		private IEnumerator<float> _WatchCall(float timeframe, CoroutineHandle handle, GameObject gObject, Action onDone)
		{
			return null;
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0xBEF148", Offset = "0xBEF148", VA = "0xBEF148")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x4F5544", Offset = "0x4F5544")]
		private IEnumerator<float> _CallContinuously(float period, Action action, GameObject gObject)
		{
			return null;
		}

		[Token(Token = "0x60001BC")]
		public static CoroutineHandle CallPeriodically<T>(T reference, float timeframe, float period, Action<T> action, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60001BD")]
		public CoroutineHandle CallPeriodicallyOnInstance<T>(T reference, float timeframe, float period, Action<T> action, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60001BE")]
		public static CoroutineHandle CallPeriodically<T>(T reference, float timeframe, float period, Action<T> action, GameObject gameObject, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60001BF")]
		public CoroutineHandle CallPeriodicallyOnInstance<T>(T reference, float timeframe, float period, Action<T> action, GameObject gameObject, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60001C0")]
		public static CoroutineHandle CallPeriodically<T>(T reference, float timeframe, float period, Action<T> action, Segment timing, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60001C1")]
		public CoroutineHandle CallPeriodicallyOnInstance<T>(T reference, float timeframe, float period, Action<T> action, Segment timing, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60001C2")]
		public static CoroutineHandle CallPeriodically<T>(T reference, float timeframe, float period, Action<T> action, Segment timing, GameObject gameObject, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60001C3")]
		public CoroutineHandle CallPeriodicallyOnInstance<T>(T reference, float timeframe, float period, Action<T> action, Segment timing, GameObject gameObject, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60001C4")]
		public static CoroutineHandle CallContinuously<T>(T reference, float timeframe, Action<T> action, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60001C5")]
		public CoroutineHandle CallContinuouslyOnInstance<T>(T reference, float timeframe, Action<T> action, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60001C6")]
		public static CoroutineHandle CallContinuously<T>(T reference, float timeframe, Action<T> action, GameObject gameObject, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60001C7")]
		public CoroutineHandle CallContinuouslyOnInstance<T>(T reference, float timeframe, Action<T> action, GameObject gameObject, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60001C8")]
		public static CoroutineHandle CallContinuously<T>(T reference, float timeframe, Action<T> action, Segment timing, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60001C9")]
		public CoroutineHandle CallContinuouslyOnInstance<T>(T reference, float timeframe, Action<T> action, Segment timing, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60001CA")]
		public static CoroutineHandle CallContinuously<T>(T reference, float timeframe, Action<T> action, Segment timing, GameObject gameObject, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60001CB")]
		public CoroutineHandle CallContinuouslyOnInstance<T>(T reference, float timeframe, Action<T> action, Segment timing, GameObject gameObject, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60001CC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x4F55A8", Offset = "0x4F55A8")]
		private IEnumerator<float> _WatchCall<T>(T reference, float timeframe, CoroutineHandle handle, GameObject gObject, Action<T> onDone)
		{
			return null;
		}

		[Token(Token = "0x60001CD")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x4F560C", Offset = "0x4F560C")]
		private IEnumerator<float> _CallContinuously<T>(T reference, float period, Action<T> action, GameObject gObject)
		{
			return null;
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0xBF01B4", Offset = "0xBF01B4", VA = "0xBF01B4")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x4F5670", Offset = "0x4F5670")]
		public new Coroutine StartCoroutine(IEnumerator routine)
		{
			return null;
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0xBF01BC", Offset = "0xBF01BC", VA = "0xBF01BC")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x4F56AC", Offset = "0x4F56AC")]
		public new Coroutine StartCoroutine(string methodName, object value)
		{
			return null;
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0xBF01C4", Offset = "0xBF01C4", VA = "0xBF01C4")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x4F56E8", Offset = "0x4F56E8")]
		public new Coroutine StartCoroutine(string methodName)
		{
			return null;
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0xBF01CC", Offset = "0xBF01CC", VA = "0xBF01CC")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x4F5724", Offset = "0x4F5724")]
		public new Coroutine StartCoroutine_Auto(IEnumerator routine)
		{
			return null;
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0xBF01D4", Offset = "0xBF01D4", VA = "0xBF01D4")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x4F5760", Offset = "0x4F5760")]
		public new void StopCoroutine(string methodName)
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0xBF01D8", Offset = "0xBF01D8", VA = "0xBF01D8")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x4F579C", Offset = "0x4F579C")]
		public new void StopCoroutine(IEnumerator routine)
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0xBF01DC", Offset = "0xBF01DC", VA = "0xBF01DC")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x4F57D8", Offset = "0x4F57D8")]
		public new void StopCoroutine(Coroutine routine)
		{
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0xBF01E0", Offset = "0xBF01E0", VA = "0xBF01E0")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x4F5814", Offset = "0x4F5814")]
		public new void StopAllCoroutines()
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0xBF01E4", Offset = "0xBF01E4", VA = "0xBF01E4")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x4F5850", Offset = "0x4F5850")]
		public new static void Destroy(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0xBF01E8", Offset = "0xBF01E8", VA = "0xBF01E8")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x4F588C", Offset = "0x4F588C")]
		public new static void Destroy(UnityEngine.Object obj, float f)
		{
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0xBF01EC", Offset = "0xBF01EC", VA = "0xBF01EC")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x4F58C8", Offset = "0x4F58C8")]
		public static void DestroyObject(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0xBF01F0", Offset = "0xBF01F0", VA = "0xBF01F0")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x4F5904", Offset = "0x4F5904")]
		public static void DestroyObject(UnityEngine.Object obj, float f)
		{
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0xBF01F4", Offset = "0xBF01F4", VA = "0xBF01F4")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x4F5940", Offset = "0x4F5940")]
		public new static void DestroyImmediate(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0xBF01F8", Offset = "0xBF01F8", VA = "0xBF01F8")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x4F597C", Offset = "0x4F597C")]
		public new static void DestroyImmediate(UnityEngine.Object obj, bool b)
		{
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0xBF01FC", Offset = "0xBF01FC", VA = "0xBF01FC")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x4F59B8", Offset = "0x4F59B8")]
		public new static void Instantiate(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0xBF0200", Offset = "0xBF0200", VA = "0xBF0200")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x4F59F4", Offset = "0x4F59F4")]
		public new static void Instantiate(UnityEngine.Object original, Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x60001DE")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x4F5A30", Offset = "0x4F5A30")]
		public new static void Instantiate<T>(T original) where T : UnityEngine.Object
		{
		}

		[Token(Token = "0x60001DF")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x4F5A6C", Offset = "0x4F5A6C")]
		public new static T FindObjectOfType<T>() where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0xBF0204", Offset = "0xBF0204", VA = "0xBF0204")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x4F5AA8", Offset = "0x4F5AA8")]
		public new static UnityEngine.Object FindObjectOfType(Type t)
		{
			return null;
		}

		[Token(Token = "0x60001E1")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x4F5AE4", Offset = "0x4F5AE4")]
		public new static T[] FindObjectsOfType<T>() where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0xBF020C", Offset = "0xBF020C", VA = "0xBF020C")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x4F5B20", Offset = "0x4F5B20")]
		public new static UnityEngine.Object[] FindObjectsOfType(Type t)
		{
			return null;
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0xBF0214", Offset = "0xBF0214", VA = "0xBF0214")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x4F5B5C", Offset = "0x4F5B5C")]
		public new static void print(object message)
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0xBF0218", Offset = "0xBF0218", VA = "0xBF0218")]
		public Timing()
		{
		}
	}
	[Token(Token = "0x200002F")]
	public enum Segment
	{
		[Token(Token = "0x4000217")]
		Invalid = -1,
		[Token(Token = "0x4000218")]
		Update,
		[Token(Token = "0x4000219")]
		FixedUpdate,
		[Token(Token = "0x400021A")]
		LateUpdate,
		[Token(Token = "0x400021B")]
		SlowUpdate,
		[Token(Token = "0x400021C")]
		RealtimeUpdate,
		[Token(Token = "0x400021D")]
		EditorUpdate,
		[Token(Token = "0x400021E")]
		EditorSlowUpdate,
		[Token(Token = "0x400021F")]
		EndOfFrame,
		[Token(Token = "0x4000220")]
		ManualTimeframe
	}
	[Token(Token = "0x2000030")]
	public enum DebugInfoType
	{
		[Token(Token = "0x4000222")]
		None,
		[Token(Token = "0x4000223")]
		SeperateCoroutines,
		[Token(Token = "0x4000224")]
		SeperateTags
	}
	[Token(Token = "0x2000031")]
	public enum SingletonBehavior
	{
		[Token(Token = "0x4000226")]
		Abort,
		[Token(Token = "0x4000227")]
		Overwrite,
		[Token(Token = "0x4000228")]
		Wait
	}
	[Token(Token = "0x2000032")]
	public struct CoroutineHandle : IEquatable<CoroutineHandle>
	{
		[Token(Token = "0x4000229")]
		private const byte ReservedSpace = 15;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int[] NextIndex;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly int _id;

		[Token(Token = "0x1700000C")]
		public byte Key
		{
			[Token(Token = "0x60001E6")]
			[Address(RVA = "0x56FCEC", Offset = "0x56FCEC", VA = "0x56FCEC")]
			get
			{
				return default(byte);
			}
		}

		[Token(Token = "0x1700000D")]
		public string Tag
		{
			[Token(Token = "0x60001ED")]
			[Address(RVA = "0x56FD20", Offset = "0x56FD20", VA = "0x56FD20")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001EE")]
			[Address(RVA = "0x56FD28", Offset = "0x56FD28", VA = "0x56FD28")]
			set
			{
			}
		}

		[Token(Token = "0x1700000E")]
		public int? Layer
		{
			[Token(Token = "0x60001EF")]
			[Address(RVA = "0x56FD30", Offset = "0x56FD30", VA = "0x56FD30")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001F0")]
			[Address(RVA = "0x56FD38", Offset = "0x56FD38", VA = "0x56FD38")]
			set
			{
			}
		}

		[Token(Token = "0x1700000F")]
		public Segment Segment
		{
			[Token(Token = "0x60001F1")]
			[Address(RVA = "0x56FD40", Offset = "0x56FD40", VA = "0x56FD40")]
			get
			{
				return default(Segment);
			}
			[Token(Token = "0x60001F2")]
			[Address(RVA = "0x56FD48", Offset = "0x56FD48", VA = "0x56FD48")]
			set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public bool IsRunning
		{
			[Token(Token = "0x60001F3")]
			[Address(RVA = "0x56FD50", Offset = "0x56FD50", VA = "0x56FD50")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001F4")]
			[Address(RVA = "0x56FD58", Offset = "0x56FD58", VA = "0x56FD58")]
			set
			{
			}
		}

		[Token(Token = "0x17000011")]
		public bool IsPaused
		{
			[Token(Token = "0x60001F5")]
			[Address(RVA = "0x56FD64", Offset = "0x56FD64", VA = "0x56FD64")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001F6")]
			[Address(RVA = "0x56FD6C", Offset = "0x56FD6C", VA = "0x56FD6C")]
			set
			{
			}
		}

		[Token(Token = "0x17000012")]
		public bool IsValid
		{
			[Token(Token = "0x60001F7")]
			[Address(RVA = "0x56FD78", Offset = "0x56FD78", VA = "0x56FD78")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x56FCF8", Offset = "0x56FCF8", VA = "0x56FCF8")]
		public CoroutineHandle(byte ind)
		{
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x56FD00", Offset = "0x56FD00", VA = "0x56FD00", Slot = "4")]
		public bool Equals(CoroutineHandle other)
		{
			return default(bool);
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x56FD10", Offset = "0x56FD10", VA = "0x56FD10", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0xBD7CB8", Offset = "0xBD7CB8", VA = "0xBD7CB8")]
		public static bool operator ==(CoroutineHandle a, CoroutineHandle b)
		{
			return default(bool);
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0xBD7CC4", Offset = "0xBD7CC4", VA = "0xBD7CC4")]
		public static bool operator !=(CoroutineHandle a, CoroutineHandle b)
		{
			return default(bool);
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x56FD18", Offset = "0x56FD18", VA = "0x56FD18", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
