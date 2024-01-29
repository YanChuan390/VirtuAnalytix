using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using FluffyUnderware.Curvy.Controllers;
using FluffyUnderware.Curvy.Generator;
using FluffyUnderware.Curvy.Generator.Modules;
using FluffyUnderware.Curvy.ThirdParty.LibTessDotNet;
using FluffyUnderware.DevTools;
using Il2CppDummyDll;
using JetBrains.Annotations;
using MEC;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8644F8", Offset = "0x8644F8")]
internal sealed class <>f__AnonymousType0<<A>j__TPar, <B>j__TPar, <C>j__TPar, <D>j__TPar>
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x867BEC", Offset = "0x867BEC")]
	private readonly <A>j__TPar <A>i__Field;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x867C00", Offset = "0x867C00")]
	private readonly <B>j__TPar <B>i__Field;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x867C14", Offset = "0x867C14")]
	private readonly <C>j__TPar <C>i__Field;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x867C28", Offset = "0x867C28")]
	private readonly <D>j__TPar <D>i__Field;

	[Token(Token = "0x17000001")]
	public <A>j__TPar A
	{
		[Token(Token = "0x6000001")]
		get
		{
			return (<A>j__TPar)null;
		}
	}

	[Token(Token = "0x17000002")]
	public <B>j__TPar B
	{
		[Token(Token = "0x6000002")]
		get
		{
			return (<B>j__TPar)null;
		}
	}

	[Token(Token = "0x17000003")]
	public <C>j__TPar C
	{
		[Token(Token = "0x6000003")]
		get
		{
			return (<C>j__TPar)null;
		}
	}

	[Token(Token = "0x17000004")]
	public <D>j__TPar D
	{
		[Token(Token = "0x6000004")]
		get
		{
			return (<D>j__TPar)null;
		}
	}

	[Token(Token = "0x6000005")]
	[DebuggerHidden]
	public <>f__AnonymousType0(<A>j__TPar A, <B>j__TPar B, <C>j__TPar C, <D>j__TPar D)
	{
	}

	[Token(Token = "0x6000006")]
	[DebuggerHidden]
	public override bool Equals(object value)
	{
		return default(bool);
	}

	[Token(Token = "0x6000007")]
	[DebuggerHidden]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000008")]
	[DebuggerHidden]
	public override string ToString()
	{
		return null;
	}
}
[Token(Token = "0x2000003")]
[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x864508", Offset = "0x864508")]
internal sealed class <>f__AnonymousType1<<A>j__TPar, <B>j__TPar, <C>j__TPar, <D>j__TPar, <E>j__TPar>
{
	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x867C3C", Offset = "0x867C3C")]
	private readonly <A>j__TPar <A>i__Field;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x867C50", Offset = "0x867C50")]
	private readonly <B>j__TPar <B>i__Field;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x867C64", Offset = "0x867C64")]
	private readonly <C>j__TPar <C>i__Field;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x867C78", Offset = "0x867C78")]
	private readonly <D>j__TPar <D>i__Field;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x867C8C", Offset = "0x867C8C")]
	private readonly <E>j__TPar <E>i__Field;

	[Token(Token = "0x17000005")]
	public <A>j__TPar A
	{
		[Token(Token = "0x6000009")]
		get
		{
			return (<A>j__TPar)null;
		}
	}

	[Token(Token = "0x17000006")]
	public <B>j__TPar B
	{
		[Token(Token = "0x600000A")]
		get
		{
			return (<B>j__TPar)null;
		}
	}

	[Token(Token = "0x17000007")]
	public <C>j__TPar C
	{
		[Token(Token = "0x600000B")]
		get
		{
			return (<C>j__TPar)null;
		}
	}

	[Token(Token = "0x17000008")]
	public <D>j__TPar D
	{
		[Token(Token = "0x600000C")]
		get
		{
			return (<D>j__TPar)null;
		}
	}

	[Token(Token = "0x17000009")]
	public <E>j__TPar E
	{
		[Token(Token = "0x600000D")]
		get
		{
			return (<E>j__TPar)null;
		}
	}

	[Token(Token = "0x600000E")]
	[DebuggerHidden]
	public <>f__AnonymousType1(<A>j__TPar A, <B>j__TPar B, <C>j__TPar C, <D>j__TPar D, <E>j__TPar E)
	{
	}

	[Token(Token = "0x600000F")]
	[DebuggerHidden]
	public override bool Equals(object value)
	{
		return default(bool);
	}

	[Token(Token = "0x6000010")]
	[DebuggerHidden]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000011")]
	[DebuggerHidden]
	public override string ToString()
	{
		return null;
	}
}
[Token(Token = "0x2000004")]
public class AnimationHelper : MonoBehaviour
{
	[Token(Token = "0x6000012")]
	[Address(RVA = "0x139EAAC", Offset = "0x139EAAC", VA = "0x139EAAC")]
	public void Play(Animation animation)
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x139EAC8", Offset = "0x139EAC8", VA = "0x139EAC8")]
	public void RewindThenPlay(Animation animation)
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x139EB00", Offset = "0x139EB00", VA = "0x139EB00")]
	public AnimationHelper()
	{
	}
}
[Token(Token = "0x2000005")]
public class MixingAnimator : MonoBehaviour
{
	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ModifierVariableMixShapes VariableMixShapes;

	[Token(Token = "0x6000015")]
	[Address(RVA = "0xDEDEA8", Offset = "0xDEDEA8", VA = "0xDEDEA8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0xDEDF98", Offset = "0xDEDF98", VA = "0xDEDF98")]
	public MixingAnimator()
	{
	}
}
[Token(Token = "0x2000006")]
public class SinusoidalMover : MonoBehaviour
{
	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float MovementAmplitude;

	[Token(Token = "0x6000017")]
	[Address(RVA = "0xB15CDC", Offset = "0xB15CDC", VA = "0xB15CDC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0xB15DC4", Offset = "0xB15DC4", VA = "0xB15DC4")]
	public SinusoidalMover()
	{
	}
}
[Token(Token = "0x2000007")]
public class ToggleBehaviourByTrigger : MonoBehaviour
{
	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Behaviour UIElement;

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x181044C", Offset = "0x181044C", VA = "0x181044C")]
	private void OnTriggerEnter()
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x18104F4", Offset = "0x18104F4", VA = "0x18104F4")]
	public ToggleBehaviourByTrigger()
	{
	}
}
[Token(Token = "0x2000008")]
public static class MECExtensionMethods2
{
	[Token(Token = "0x2000142")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8677C4", Offset = "0x8677C4")]
	private sealed class <Delay>d__0 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400055A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400055B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x400055C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float timeToDelay;

		[Token(Token = "0x400055D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x1700027F")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x6000C02")]
			[Address(RVA = "0x18195D8", Offset = "0x18195D8", VA = "0x18195D8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000280")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000C04")]
			[Address(RVA = "0x1819640", Offset = "0x1819640", VA = "0x1819640", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000BFF")]
		[Address(RVA = "0x18193FC", Offset = "0x18193FC", VA = "0x18193FC")]
		[DebuggerHidden]
		public <Delay>d__0(int <>1__state)
		{
		}

		[Token(Token = "0x6000C00")]
		[Address(RVA = "0x1819428", Offset = "0x1819428", VA = "0x1819428", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000C01")]
		[Address(RVA = "0x181942C", Offset = "0x181942C", VA = "0x181942C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000C03")]
		[Address(RVA = "0x18195E0", Offset = "0x18195E0", VA = "0x18195E0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000143")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8677D4", Offset = "0x8677D4")]
	private sealed class <Delay>d__1 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400055E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400055F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x4000560")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Func<bool> condition;

		[Token(Token = "0x4000561")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x17000281")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x6000C08")]
			[Address(RVA = "0x181985C", Offset = "0x181985C", VA = "0x181985C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000282")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000C0A")]
			[Address(RVA = "0x18198C4", Offset = "0x18198C4", VA = "0x18198C4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000C05")]
		[Address(RVA = "0x18196A4", Offset = "0x18196A4", VA = "0x18196A4")]
		[DebuggerHidden]
		public <Delay>d__1(int <>1__state)
		{
		}

		[Token(Token = "0x6000C06")]
		[Address(RVA = "0x18196D0", Offset = "0x18196D0", VA = "0x18196D0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000C07")]
		[Address(RVA = "0x18196D4", Offset = "0x18196D4", VA = "0x18196D4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000C09")]
		[Address(RVA = "0x1819864", Offset = "0x1819864", VA = "0x1819864", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000144")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8677E4", Offset = "0x8677E4")]
	private sealed class <Delay>d__2<T> : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000562")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <>1__state;

		[Token(Token = "0x4000563")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float <>2__current;

		[Token(Token = "0x4000564")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Func<T, bool> condition;

		[Token(Token = "0x4000565")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T data;

		[Token(Token = "0x4000566")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x17000283")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x6000C0E")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000284")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000C10")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000C0B")]
		[DebuggerHidden]
		public <Delay>d__2(int <>1__state)
		{
		}

		[Token(Token = "0x6000C0C")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000C0D")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000C0F")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000145")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8677F4", Offset = "0x8677F4")]
	private sealed class <DelayFrames>d__3 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000567")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000568")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x4000569")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int framesToDelay;

		[Token(Token = "0x400056A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x17000285")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x6000C14")]
			[Address(RVA = "0x1819AD4", Offset = "0x1819AD4", VA = "0x1819AD4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000286")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000C16")]
			[Address(RVA = "0x1819B3C", Offset = "0x1819B3C", VA = "0x1819B3C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000C11")]
		[Address(RVA = "0x1819928", Offset = "0x1819928", VA = "0x1819928")]
		[DebuggerHidden]
		public <DelayFrames>d__3(int <>1__state)
		{
		}

		[Token(Token = "0x6000C12")]
		[Address(RVA = "0x1819954", Offset = "0x1819954", VA = "0x1819954", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000C13")]
		[Address(RVA = "0x1819958", Offset = "0x1819958", VA = "0x1819958", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000C15")]
		[Address(RVA = "0x1819ADC", Offset = "0x1819ADC", VA = "0x1819ADC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000146")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x867804", Offset = "0x867804")]
	private sealed class <CancelWith>d__4 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400056B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400056C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x400056D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x400056E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject gameObject;

		[Token(Token = "0x17000287")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x6000C1A")]
			[Address(RVA = "0x1818CCC", Offset = "0x1818CCC", VA = "0x1818CCC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000288")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000C1C")]
			[Address(RVA = "0x1818D34", Offset = "0x1818D34", VA = "0x1818D34", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000C17")]
		[Address(RVA = "0x1818A7C", Offset = "0x1818A7C", VA = "0x1818A7C")]
		[DebuggerHidden]
		public <CancelWith>d__4(int <>1__state)
		{
		}

		[Token(Token = "0x6000C18")]
		[Address(RVA = "0x1818AA8", Offset = "0x1818AA8", VA = "0x1818AA8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000C19")]
		[Address(RVA = "0x1818AAC", Offset = "0x1818AAC", VA = "0x1818AAC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000C1B")]
		[Address(RVA = "0x1818CD4", Offset = "0x1818CD4", VA = "0x1818CD4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000147")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x867814", Offset = "0x867814")]
	private sealed class <CancelWith>d__5 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400056F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000570")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x4000571")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x4000572")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject gameObject1;

		[Token(Token = "0x4000573")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject gameObject2;

		[Token(Token = "0x17000289")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x6000C20")]
			[Address(RVA = "0x1819028", Offset = "0x1819028", VA = "0x1819028", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700028A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000C22")]
			[Address(RVA = "0x1819090", Offset = "0x1819090", VA = "0x1819090", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000C1D")]
		[Address(RVA = "0x1818D98", Offset = "0x1818D98", VA = "0x1818D98")]
		[DebuggerHidden]
		public <CancelWith>d__5(int <>1__state)
		{
		}

		[Token(Token = "0x6000C1E")]
		[Address(RVA = "0x1818DC4", Offset = "0x1818DC4", VA = "0x1818DC4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000C1F")]
		[Address(RVA = "0x1818DC8", Offset = "0x1818DC8", VA = "0x1818DC8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000C21")]
		[Address(RVA = "0x1819030", Offset = "0x1819030", VA = "0x1819030", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000148")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x867824", Offset = "0x867824")]
	private sealed class <CancelWith>d__6<T> : IEnumerator<float>, IEnumerator, IDisposable where T : MonoBehaviour
	{
		[Token(Token = "0x4000574")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <>1__state;

		[Token(Token = "0x4000575")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float <>2__current;

		[Token(Token = "0x4000576")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T script;

		[Token(Token = "0x4000577")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x4000578")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private GameObject <myGO>5__2;

		[Token(Token = "0x1700028B")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x6000C26")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700028C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000C28")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000C23")]
		[DebuggerHidden]
		public <CancelWith>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x6000C24")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000C25")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000C27")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000149")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x867834", Offset = "0x867834")]
	private sealed class <CancelWith>d__7 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000579")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400057A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x400057B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Func<bool> condition;

		[Token(Token = "0x400057C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x1700028D")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x6000C2C")]
			[Address(RVA = "0x1819330", Offset = "0x1819330", VA = "0x1819330", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700028E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000C2E")]
			[Address(RVA = "0x1819398", Offset = "0x1819398", VA = "0x1819398", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000C29")]
		[Address(RVA = "0x18190F4", Offset = "0x18190F4", VA = "0x18190F4")]
		[DebuggerHidden]
		public <CancelWith>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x6000C2A")]
		[Address(RVA = "0x1819120", Offset = "0x1819120", VA = "0x1819120", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000C2B")]
		[Address(RVA = "0x1819124", Offset = "0x1819124", VA = "0x1819124", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000C2D")]
		[Address(RVA = "0x1819338", Offset = "0x1819338", VA = "0x1819338", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200014A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x867844", Offset = "0x867844")]
	private sealed class <PauseWith>d__8 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400057D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400057E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x400057F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject gameObject;

		[Token(Token = "0x4000580")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x1700028F")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x6000C32")]
			[Address(RVA = "0x181A5E8", Offset = "0x181A5E8", VA = "0x181A5E8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000290")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000C34")]
			[Address(RVA = "0x181A650", Offset = "0x181A650", VA = "0x181A650", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000C2F")]
		[Address(RVA = "0x181A38C", Offset = "0x181A38C", VA = "0x181A38C")]
		[DebuggerHidden]
		public <PauseWith>d__8(int <>1__state)
		{
		}

		[Token(Token = "0x6000C30")]
		[Address(RVA = "0x181A3B8", Offset = "0x181A3B8", VA = "0x181A3B8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000C31")]
		[Address(RVA = "0x181A3BC", Offset = "0x181A3BC", VA = "0x181A3BC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000C33")]
		[Address(RVA = "0x181A5F0", Offset = "0x181A5F0", VA = "0x181A5F0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200014B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x867854", Offset = "0x867854")]
	private sealed class <PauseWith>d__9 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000581")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000582")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x4000583")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject gameObject1;

		[Token(Token = "0x4000584")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject gameObject2;

		[Token(Token = "0x4000585")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x17000291")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x6000C38")]
			[Address(RVA = "0x181A950", Offset = "0x181A950", VA = "0x181A950", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000292")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000C3A")]
			[Address(RVA = "0x181A9B8", Offset = "0x181A9B8", VA = "0x181A9B8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000C35")]
		[Address(RVA = "0x181A6B4", Offset = "0x181A6B4", VA = "0x181A6B4")]
		[DebuggerHidden]
		public <PauseWith>d__9(int <>1__state)
		{
		}

		[Token(Token = "0x6000C36")]
		[Address(RVA = "0x181A6E0", Offset = "0x181A6E0", VA = "0x181A6E0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000C37")]
		[Address(RVA = "0x181A6E4", Offset = "0x181A6E4", VA = "0x181A6E4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000C39")]
		[Address(RVA = "0x181A958", Offset = "0x181A958", VA = "0x181A958", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200014C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x867864", Offset = "0x867864")]
	private sealed class <PauseWith>d__10<T> : IEnumerator<float>, IEnumerator, IDisposable where T : MonoBehaviour
	{
		[Token(Token = "0x4000586")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <>1__state;

		[Token(Token = "0x4000587")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float <>2__current;

		[Token(Token = "0x4000588")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T script;

		[Token(Token = "0x4000589")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x400058A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private GameObject <myGO>5__2;

		[Token(Token = "0x17000293")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x6000C3E")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000294")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000C40")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000C3B")]
		[DebuggerHidden]
		public <PauseWith>d__10(int <>1__state)
		{
		}

		[Token(Token = "0x6000C3C")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000C3D")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000C3F")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200014D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x867874", Offset = "0x867874")]
	private sealed class <PauseWith>d__11 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400058B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400058C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x400058D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Func<bool> condition;

		[Token(Token = "0x400058E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x17000295")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x6000C44")]
			[Address(RVA = "0x181A2C0", Offset = "0x181A2C0", VA = "0x181A2C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000296")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000C46")]
			[Address(RVA = "0x181A328", Offset = "0x181A328", VA = "0x181A328", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000C41")]
		[Address(RVA = "0x181A084", Offset = "0x181A084", VA = "0x181A084")]
		[DebuggerHidden]
		public <PauseWith>d__11(int <>1__state)
		{
		}

		[Token(Token = "0x6000C42")]
		[Address(RVA = "0x181A0B0", Offset = "0x181A0B0", VA = "0x181A0B0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000C43")]
		[Address(RVA = "0x181A0B4", Offset = "0x181A0B4", VA = "0x181A0B4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000C45")]
		[Address(RVA = "0x181A2C8", Offset = "0x181A2C8", VA = "0x181A2C8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200014E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x867884", Offset = "0x867884")]
	private sealed class <KillWith>d__12 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400058F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000590")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x4000591")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x4000592")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CoroutineHandle otherCoroutine;

		[Token(Token = "0x17000297")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x6000C4A")]
			[Address(RVA = "0x1819FB8", Offset = "0x1819FB8", VA = "0x1819FB8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000298")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000C4C")]
			[Address(RVA = "0x181A020", Offset = "0x181A020", VA = "0x181A020", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000C47")]
		[Address(RVA = "0x1819E28", Offset = "0x1819E28", VA = "0x1819E28")]
		[DebuggerHidden]
		public <KillWith>d__12(int <>1__state)
		{
		}

		[Token(Token = "0x6000C48")]
		[Address(RVA = "0x1819E54", Offset = "0x1819E54", VA = "0x1819E54", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000C49")]
		[Address(RVA = "0x1819E58", Offset = "0x1819E58", VA = "0x1819E58", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000C4B")]
		[Address(RVA = "0x1819FC0", Offset = "0x1819FC0", VA = "0x1819FC0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200014F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x867894", Offset = "0x867894")]
	private sealed class <Append>d__13 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000593")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000594")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x4000595")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x4000596")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IEnumerator<float> nextCoroutine;

		[Token(Token = "0x17000299")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x6000C50")]
			[Address(RVA = "0x1818754", Offset = "0x1818754", VA = "0x1818754", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700029A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000C52")]
			[Address(RVA = "0x18187BC", Offset = "0x18187BC", VA = "0x18187BC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000C4D")]
		[Address(RVA = "0x18184B4", Offset = "0x18184B4", VA = "0x18184B4")]
		[DebuggerHidden]
		public <Append>d__13(int <>1__state)
		{
		}

		[Token(Token = "0x6000C4E")]
		[Address(RVA = "0x18184E0", Offset = "0x18184E0", VA = "0x18184E0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000C4F")]
		[Address(RVA = "0x18184E4", Offset = "0x18184E4", VA = "0x18184E4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000C51")]
		[Address(RVA = "0x181875C", Offset = "0x181875C", VA = "0x181875C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000150")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8678A4", Offset = "0x8678A4")]
	private sealed class <Append>d__14 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000597")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000598")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x4000599")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x400059A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Action onDone;

		[Token(Token = "0x1700029B")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x6000C56")]
			[Address(RVA = "0x18189B0", Offset = "0x18189B0", VA = "0x18189B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700029C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000C58")]
			[Address(RVA = "0x1818A18", Offset = "0x1818A18", VA = "0x1818A18", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000C53")]
		[Address(RVA = "0x1818820", Offset = "0x1818820", VA = "0x1818820")]
		[DebuggerHidden]
		public <Append>d__14(int <>1__state)
		{
		}

		[Token(Token = "0x6000C54")]
		[Address(RVA = "0x181884C", Offset = "0x181884C", VA = "0x181884C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000C55")]
		[Address(RVA = "0x1818850", Offset = "0x1818850", VA = "0x1818850", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000C57")]
		[Address(RVA = "0x18189B8", Offset = "0x18189B8", VA = "0x18189B8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000151")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8678B4", Offset = "0x8678B4")]
	private sealed class <Prepend>d__15 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400059B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400059C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x400059D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IEnumerator<float> lastCoroutine;

		[Token(Token = "0x400059E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x1700029D")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x6000C5C")]
			[Address(RVA = "0x181ACD0", Offset = "0x181ACD0", VA = "0x181ACD0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700029E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000C5E")]
			[Address(RVA = "0x181AD38", Offset = "0x181AD38", VA = "0x181AD38", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000C59")]
		[Address(RVA = "0x181AA1C", Offset = "0x181AA1C", VA = "0x181AA1C")]
		[DebuggerHidden]
		public <Prepend>d__15(int <>1__state)
		{
		}

		[Token(Token = "0x6000C5A")]
		[Address(RVA = "0x181AA48", Offset = "0x181AA48", VA = "0x181AA48", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000C5B")]
		[Address(RVA = "0x181AA4C", Offset = "0x181AA4C", VA = "0x181AA4C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000C5D")]
		[Address(RVA = "0x181ACD8", Offset = "0x181ACD8", VA = "0x181ACD8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000152")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8678C4", Offset = "0x8678C4")]
	private sealed class <Prepend>d__16 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400059F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40005A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x40005A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Action onStart;

		[Token(Token = "0x40005A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x1700029F")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x6000C62")]
			[Address(RVA = "0x181AF3C", Offset = "0x181AF3C", VA = "0x181AF3C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170002A0")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000C64")]
			[Address(RVA = "0x181AFA4", Offset = "0x181AFA4", VA = "0x181AFA4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000C5F")]
		[Address(RVA = "0x181AD9C", Offset = "0x181AD9C", VA = "0x181AD9C")]
		[DebuggerHidden]
		public <Prepend>d__16(int <>1__state)
		{
		}

		[Token(Token = "0x6000C60")]
		[Address(RVA = "0x181ADC8", Offset = "0x181ADC8", VA = "0x181ADC8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000C61")]
		[Address(RVA = "0x181ADCC", Offset = "0x181ADCC", VA = "0x181ADCC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000C63")]
		[Address(RVA = "0x181AF44", Offset = "0x181AF44", VA = "0x181AF44", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000153")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8678D4", Offset = "0x8678D4")]
	private sealed class <Superimpose>d__18 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40005A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40005A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x40005A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IEnumerator<float> coroutineA;

		[Token(Token = "0x40005A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Timing instance;

		[Token(Token = "0x40005A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IEnumerator<float> coroutineB;

		[Token(Token = "0x170002A1")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x6000C68")]
			[Address(RVA = "0x181B92C", Offset = "0x181B92C", VA = "0x181B92C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170002A2")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000C6A")]
			[Address(RVA = "0x181B994", Offset = "0x181B994", VA = "0x181B994", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000C65")]
		[Address(RVA = "0x181B2EC", Offset = "0x181B2EC", VA = "0x181B2EC")]
		[DebuggerHidden]
		public <Superimpose>d__18(int <>1__state)
		{
		}

		[Token(Token = "0x6000C66")]
		[Address(RVA = "0x181B318", Offset = "0x181B318", VA = "0x181B318", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000C67")]
		[Address(RVA = "0x181B31C", Offset = "0x181B31C", VA = "0x181B31C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000C69")]
		[Address(RVA = "0x181B934", Offset = "0x181B934", VA = "0x181B934", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000154")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8678E4", Offset = "0x8678E4")]
	private sealed class <Hijack>d__19 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40005A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40005A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x40005AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Func<float, float> newReturn;

		[Token(Token = "0x40005AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x170002A3")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x6000C6E")]
			[Address(RVA = "0x1819D5C", Offset = "0x1819D5C", VA = "0x1819D5C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170002A4")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000C70")]
			[Address(RVA = "0x1819DC4", Offset = "0x1819DC4", VA = "0x1819DC4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000C6B")]
		[Address(RVA = "0x1819BA0", Offset = "0x1819BA0", VA = "0x1819BA0")]
		[DebuggerHidden]
		public <Hijack>d__19(int <>1__state)
		{
		}

		[Token(Token = "0x6000C6C")]
		[Address(RVA = "0x1819BCC", Offset = "0x1819BCC", VA = "0x1819BCC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000C6D")]
		[Address(RVA = "0x1819BD0", Offset = "0x1819BD0", VA = "0x1819BD0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000C6F")]
		[Address(RVA = "0x1819D64", Offset = "0x1819D64", VA = "0x1819D64", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000155")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8678F4", Offset = "0x8678F4")]
	private sealed class <RerouteExceptions>d__20 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40005AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40005AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x40005AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x40005AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Action<Exception> exceptionHandler;

		[Token(Token = "0x170002A5")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x6000C74")]
			[Address(RVA = "0x181B220", Offset = "0x181B220", VA = "0x181B220", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170002A6")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000C76")]
			[Address(RVA = "0x181B288", Offset = "0x181B288", VA = "0x181B288", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000C71")]
		[Address(RVA = "0x181B008", Offset = "0x181B008", VA = "0x181B008")]
		[DebuggerHidden]
		public <RerouteExceptions>d__20(int <>1__state)
		{
		}

		[Token(Token = "0x6000C72")]
		[Address(RVA = "0x181B034", Offset = "0x181B034", VA = "0x181B034", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000C73")]
		[Address(RVA = "0x181B038", Offset = "0x181B038", VA = "0x181B038", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000C75")]
		[Address(RVA = "0x181B228", Offset = "0x181B228", VA = "0x181B228", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0xDEC420", Offset = "0xDEC420", VA = "0xDEC420")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8750A4", Offset = "0x8750A4")]
	public static IEnumerator<float> Delay(this IEnumerator<float> coroutine, float timeToDelay)
	{
		return null;
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0xDEC4A0", Offset = "0xDEC4A0", VA = "0xDEC4A0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x875118", Offset = "0x875118")]
	public static IEnumerator<float> Delay(this IEnumerator<float> coroutine, Func<bool> condition)
	{
		return null;
	}

	[Token(Token = "0x600001D")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x87518C", Offset = "0x87518C")]
	public static IEnumerator<float> Delay<T>(this IEnumerator<float> coroutine, T data, Func<T, bool> condition)
	{
		return null;
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0xDEC51C", Offset = "0xDEC51C", VA = "0xDEC51C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x875200", Offset = "0x875200")]
	public static IEnumerator<float> DelayFrames(this IEnumerator<float> coroutine, int framesToDelay)
	{
		return null;
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0xDEC59C", Offset = "0xDEC59C", VA = "0xDEC59C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x875274", Offset = "0x875274")]
	public static IEnumerator<float> CancelWith(this IEnumerator<float> coroutine, GameObject gameObject)
	{
		return null;
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0xDEC618", Offset = "0xDEC618", VA = "0xDEC618")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8752E8", Offset = "0x8752E8")]
	public static IEnumerator<float> CancelWith(this IEnumerator<float> coroutine, GameObject gameObject1, GameObject gameObject2)
	{
		return null;
	}

	[Token(Token = "0x6000021")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x87535C", Offset = "0x87535C")]
	public static IEnumerator<float> CancelWith<T>(this IEnumerator<float> coroutine, T script) where T : MonoBehaviour
	{
		return null;
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0xDEC69C", Offset = "0xDEC69C", VA = "0xDEC69C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8753D0", Offset = "0x8753D0")]
	public static IEnumerator<float> CancelWith(this IEnumerator<float> coroutine, Func<bool> condition)
	{
		return null;
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0xDEC718", Offset = "0xDEC718", VA = "0xDEC718")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x875444", Offset = "0x875444")]
	public static IEnumerator<float> PauseWith(this IEnumerator<float> coroutine, GameObject gameObject)
	{
		return null;
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0xDEC794", Offset = "0xDEC794", VA = "0xDEC794")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8754B8", Offset = "0x8754B8")]
	public static IEnumerator<float> PauseWith(this IEnumerator<float> coroutine, GameObject gameObject1, GameObject gameObject2)
	{
		return null;
	}

	[Token(Token = "0x6000025")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x87552C", Offset = "0x87552C")]
	public static IEnumerator<float> PauseWith<T>(this IEnumerator<float> coroutine, T script) where T : MonoBehaviour
	{
		return null;
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0xDEC818", Offset = "0xDEC818", VA = "0xDEC818")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8755A0", Offset = "0x8755A0")]
	public static IEnumerator<float> PauseWith(this IEnumerator<float> coroutine, Func<bool> condition)
	{
		return null;
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0xDEC894", Offset = "0xDEC894", VA = "0xDEC894")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x875614", Offset = "0x875614")]
	public static IEnumerator<float> KillWith(this IEnumerator<float> coroutine, CoroutineHandle otherCoroutine)
	{
		return null;
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0xDEC914", Offset = "0xDEC914", VA = "0xDEC914")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x875688", Offset = "0x875688")]
	public static IEnumerator<float> Append(this IEnumerator<float> coroutine, IEnumerator<float> nextCoroutine)
	{
		return null;
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0xDEC990", Offset = "0xDEC990", VA = "0xDEC990")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8756FC", Offset = "0x8756FC")]
	public static IEnumerator<float> Append(this IEnumerator<float> coroutine, Action onDone)
	{
		return null;
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0xDECA0C", Offset = "0xDECA0C", VA = "0xDECA0C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x875770", Offset = "0x875770")]
	public static IEnumerator<float> Prepend(this IEnumerator<float> coroutine, IEnumerator<float> lastCoroutine)
	{
		return null;
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0xDECA88", Offset = "0xDECA88", VA = "0xDECA88")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8757E4", Offset = "0x8757E4")]
	public static IEnumerator<float> Prepend(this IEnumerator<float> coroutine, Action onStart)
	{
		return null;
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0xDECB04", Offset = "0xDECB04", VA = "0xDECB04")]
	public static IEnumerator<float> Superimpose(this IEnumerator<float> coroutineA, IEnumerator<float> coroutineB)
	{
		return null;
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0xDECB84", Offset = "0xDECB84", VA = "0xDECB84")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x875868", Offset = "0x875868")]
	public static IEnumerator<float> Superimpose(this IEnumerator<float> coroutineA, IEnumerator<float> coroutineB, Timing instance)
	{
		return null;
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0xDECC08", Offset = "0xDECC08", VA = "0xDECC08")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8758DC", Offset = "0x8758DC")]
	public static IEnumerator<float> Hijack(this IEnumerator<float> coroutine, Func<float, float> newReturn)
	{
		return null;
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0xDECC84", Offset = "0xDECC84", VA = "0xDECC84")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x875950", Offset = "0x875950")]
	public static IEnumerator<float> RerouteExceptions(this IEnumerator<float> coroutine, Action<Exception> exceptionHandler)
	{
		return null;
	}
}
namespace MEC
{
	[Token(Token = "0x2000009")]
	public class Timing : MonoBehaviour
	{
		[Token(Token = "0x2000156")]
		private struct ProcessIndex : IEquatable<ProcessIndex>
		{
			[Token(Token = "0x40005B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Segment seg;

			[Token(Token = "0x40005B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int i;

			[Token(Token = "0x6000C77")]
			[Address(RVA = "0x9E0D84", Offset = "0x9E0D84", VA = "0x9E0D84", Slot = "4")]
			public bool Equals(ProcessIndex other)
			{
				return default(bool);
			}

			[Token(Token = "0x6000C78")]
			[Address(RVA = "0x9E0DAC", Offset = "0x9E0DAC", VA = "0x9E0DAC", Slot = "0")]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6000C79")]
			[Address(RVA = "0x181DF50", Offset = "0x181DF50", VA = "0x181DF50")]
			public static bool operator ==(ProcessIndex a, ProcessIndex b)
			{
				return default(bool);
			}

			[Token(Token = "0x6000C7A")]
			[Address(RVA = "0x181DF70", Offset = "0x181DF70", VA = "0x181DF70")]
			public static bool operator !=(ProcessIndex a, ProcessIndex b)
			{
				return default(bool);
			}

			[Token(Token = "0x6000C7B")]
			[Address(RVA = "0x9E0DB4", Offset = "0x9E0DB4", VA = "0x9E0DB4", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Token(Token = "0x2000157")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x867904", Offset = "0x867904")]
		private sealed class <_EOFPumpWatcher>d__132 : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private float <>2__current;

			[Token(Token = "0x40005B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Timing <>4__this;

			[Token(Token = "0x170002A7")]
			private float System.Collections.Generic.IEnumerator<System.Single>.Current
			{
				[Token(Token = "0x6000C7F")]
				[Address(RVA = "0x181CECC", Offset = "0x181CECC", VA = "0x181CECC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x170002A8")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000C81")]
				[Address(RVA = "0x181CF34", Offset = "0x181CF34", VA = "0x181CF34", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000C7C")]
			[Address(RVA = "0x181CE0C", Offset = "0x181CE0C", VA = "0x181CE0C")]
			[DebuggerHidden]
			public <_EOFPumpWatcher>d__132(int <>1__state)
			{
			}

			[Token(Token = "0x6000C7D")]
			[Address(RVA = "0x181CE38", Offset = "0x181CE38", VA = "0x181CE38", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000C7E")]
			[Address(RVA = "0x181CE3C", Offset = "0x181CE3C", VA = "0x181CE3C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000C80")]
			[Address(RVA = "0x181CED4", Offset = "0x181CED4", VA = "0x181CED4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000158")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x867914", Offset = "0x867914")]
		private sealed class <_EOFPump>d__133 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40005B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Timing <>4__this;

			[Token(Token = "0x170002A9")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000C85")]
				[Address(RVA = "0x181CD9C", Offset = "0x181CD9C", VA = "0x181CD9C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170002AA")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000C87")]
				[Address(RVA = "0x181CE04", Offset = "0x181CE04", VA = "0x181CE04", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000C82")]
			[Address(RVA = "0x181C5BC", Offset = "0x181C5BC", VA = "0x181C5BC")]
			[DebuggerHidden]
			public <_EOFPump>d__133(int <>1__state)
			{
			}

			[Token(Token = "0x6000C83")]
			[Address(RVA = "0x181C5E8", Offset = "0x181C5E8", VA = "0x181C5E8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000C84")]
			[Address(RVA = "0x181C5EC", Offset = "0x181C5EC", VA = "0x181C5EC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000C86")]
			[Address(RVA = "0x181CDA4", Offset = "0x181CDA4", VA = "0x181CDA4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000159")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x867924", Offset = "0x867924")]
		private sealed class <_StartWhenDone>d__275 : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private float <>2__current;

			[Token(Token = "0x40005BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Timing <>4__this;

			[Token(Token = "0x40005BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CoroutineHandle handle;

			[Token(Token = "0x40005BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public IEnumerator<float> proc;

			[Token(Token = "0x170002AB")]
			private float System.Collections.Generic.IEnumerator<System.Single>.Current
			{
				[Token(Token = "0x6000C8C")]
				[Address(RVA = "0x181D568", Offset = "0x181D568", VA = "0x181D568", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x170002AC")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000C8E")]
				[Address(RVA = "0x181D5D0", Offset = "0x181D5D0", VA = "0x181D5D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000C88")]
			[Address(RVA = "0x181D1B8", Offset = "0x181D1B8", VA = "0x181D1B8")]
			[DebuggerHidden]
			public <_StartWhenDone>d__275(int <>1__state)
			{
			}

			[Token(Token = "0x6000C89")]
			[Address(RVA = "0x181D1E4", Offset = "0x181D1E4", VA = "0x181D1E4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000C8A")]
			[Address(RVA = "0x181D23C", Offset = "0x181D23C", VA = "0x181D23C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000C8B")]
			[Address(RVA = "0x181D210", Offset = "0x181D210", VA = "0x181D210")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000C8D")]
			[Address(RVA = "0x181D570", Offset = "0x181D570", VA = "0x181D570", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200015A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x867934", Offset = "0x867934")]
		private sealed class <_StartWhenDone>d__280 : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private float <>2__current;

			[Token(Token = "0x40005BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public AsyncOperation operation;

			[Token(Token = "0x40005C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public IEnumerator<float> pausedProc;

			[Token(Token = "0x170002AD")]
			private float System.Collections.Generic.IEnumerator<System.Single>.Current
			{
				[Token(Token = "0x6000C92")]
				[Address(RVA = "0x181D784", Offset = "0x181D784", VA = "0x181D784", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x170002AE")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000C94")]
				[Address(RVA = "0x181D7EC", Offset = "0x181D7EC", VA = "0x181D7EC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000C8F")]
			[Address(RVA = "0x181D634", Offset = "0x181D634", VA = "0x181D634")]
			[DebuggerHidden]
			public <_StartWhenDone>d__280(int <>1__state)
			{
			}

			[Token(Token = "0x6000C90")]
			[Address(RVA = "0x181D660", Offset = "0x181D660", VA = "0x181D660", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000C91")]
			[Address(RVA = "0x181D664", Offset = "0x181D664", VA = "0x181D664", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000C93")]
			[Address(RVA = "0x181D78C", Offset = "0x181D78C", VA = "0x181D78C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200015B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x867944", Offset = "0x867944")]
		private sealed class <_StartWhenDone>d__282 : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private float <>2__current;

			[Token(Token = "0x40005C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public CustomYieldInstruction operation;

			[Token(Token = "0x40005C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public IEnumerator<float> pausedProc;

			[Token(Token = "0x170002AF")]
			private float System.Collections.Generic.IEnumerator<System.Single>.Current
			{
				[Token(Token = "0x6000C98")]
				[Address(RVA = "0x181D9A4", Offset = "0x181D9A4", VA = "0x181D9A4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x170002B0")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000C9A")]
				[Address(RVA = "0x181DA0C", Offset = "0x181DA0C", VA = "0x181DA0C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000C95")]
			[Address(RVA = "0x181D850", Offset = "0x181D850", VA = "0x181D850")]
			[DebuggerHidden]
			public <_StartWhenDone>d__282(int <>1__state)
			{
			}

			[Token(Token = "0x6000C96")]
			[Address(RVA = "0x181D87C", Offset = "0x181D87C", VA = "0x181D87C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000C97")]
			[Address(RVA = "0x181D880", Offset = "0x181D880", VA = "0x181D880", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000C99")]
			[Address(RVA = "0x181D9AC", Offset = "0x181D9AC", VA = "0x181D9AC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200015C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x867954", Offset = "0x867954")]
		private sealed class <_StartWhenDone>d__287 : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private float <>2__current;

			[Token(Token = "0x40005C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Func<bool> evaluatorFunc;

			[Token(Token = "0x40005C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool continueOn;

			[Token(Token = "0x40005C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public IEnumerator<float> pausedProc;

			[Token(Token = "0x170002B1")]
			private float System.Collections.Generic.IEnumerator<System.Single>.Current
			{
				[Token(Token = "0x6000C9E")]
				[Address(RVA = "0x181DBD8", Offset = "0x181DBD8", VA = "0x181DBD8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x170002B2")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000CA0")]
				[Address(RVA = "0x181DC40", Offset = "0x181DC40", VA = "0x181DC40", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000C9B")]
			[Address(RVA = "0x181DA70", Offset = "0x181DA70", VA = "0x181DA70")]
			[DebuggerHidden]
			public <_StartWhenDone>d__287(int <>1__state)
			{
			}

			[Token(Token = "0x6000C9C")]
			[Address(RVA = "0x181DA9C", Offset = "0x181DA9C", VA = "0x181DA9C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000C9D")]
			[Address(RVA = "0x181DAA0", Offset = "0x181DAA0", VA = "0x181DAA0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000C9F")]
			[Address(RVA = "0x181DBE0", Offset = "0x181DBE0", VA = "0x181DBE0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200015D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x867964", Offset = "0x867964")]
		private sealed class <_InjectDelay>d__288 : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private float <>2__current;

			[Token(Token = "0x40005CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Timing <>4__this;

			[Token(Token = "0x40005CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float waitTime;

			[Token(Token = "0x40005CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public IEnumerator<float> proc;

			[Token(Token = "0x170002B3")]
			private float System.Collections.Generic.IEnumerator<System.Single>.Current
			{
				[Token(Token = "0x6000CA4")]
				[Address(RVA = "0x181D0EC", Offset = "0x181D0EC", VA = "0x181D0EC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x170002B4")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000CA6")]
				[Address(RVA = "0x181D154", Offset = "0x181D154", VA = "0x181D154", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000CA1")]
			[Address(RVA = "0x181CF98", Offset = "0x181CF98", VA = "0x181CF98")]
			[DebuggerHidden]
			public <_InjectDelay>d__288(int <>1__state)
			{
			}

			[Token(Token = "0x6000CA2")]
			[Address(RVA = "0x181CFC4", Offset = "0x181CFC4", VA = "0x181CFC4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000CA3")]
			[Address(RVA = "0x181CFC8", Offset = "0x181CFC8", VA = "0x181CFC8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000CA5")]
			[Address(RVA = "0x181D0F4", Offset = "0x181D0F4", VA = "0x181D0F4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200015E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x867974", Offset = "0x867974")]
		private sealed class <_DelayedCall>d__313 : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private float <>2__current;

			[Token(Token = "0x40005D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Timing <>4__this;

			[Token(Token = "0x40005D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float delay;

			[Token(Token = "0x40005D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public GameObject cancelWith;

			[Token(Token = "0x40005D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Action action;

			[Token(Token = "0x170002B5")]
			private float System.Collections.Generic.IEnumerator<System.Single>.Current
			{
				[Token(Token = "0x6000CAA")]
				[Address(RVA = "0x181C4F0", Offset = "0x181C4F0", VA = "0x181C4F0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x170002B6")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000CAC")]
				[Address(RVA = "0x181C558", Offset = "0x181C558", VA = "0x181C558", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000CA7")]
			[Address(RVA = "0x181C3E8", Offset = "0x181C3E8", VA = "0x181C3E8")]
			[DebuggerHidden]
			public <_DelayedCall>d__313(int <>1__state)
			{
			}

			[Token(Token = "0x6000CA8")]
			[Address(RVA = "0x181C414", Offset = "0x181C414", VA = "0x181C414", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000CA9")]
			[Address(RVA = "0x181C418", Offset = "0x181C418", VA = "0x181C418", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000CAB")]
			[Address(RVA = "0x181C4F8", Offset = "0x181C4F8", VA = "0x181C4F8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200015F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x867984", Offset = "0x867984")]
		private sealed class <_WatchCall>d__334 : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private float <>2__current;

			[Token(Token = "0x40005D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Timing <>4__this;

			[Token(Token = "0x40005D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float timeframe;

			[Token(Token = "0x40005D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public CoroutineHandle handle;

			[Token(Token = "0x40005DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action onDone;

			[Token(Token = "0x40005DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public GameObject gObject;

			[Token(Token = "0x170002B7")]
			private float System.Collections.Generic.IEnumerator<System.Single>.Current
			{
				[Token(Token = "0x6000CB0")]
				[Address(RVA = "0x181DDC4", Offset = "0x181DDC4", VA = "0x181DDC4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x170002B8")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000CB2")]
				[Address(RVA = "0x181DE2C", Offset = "0x181DE2C", VA = "0x181DE2C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000CAD")]
			[Address(RVA = "0x181DCA4", Offset = "0x181DCA4", VA = "0x181DCA4")]
			[DebuggerHidden]
			public <_WatchCall>d__334(int <>1__state)
			{
			}

			[Token(Token = "0x6000CAE")]
			[Address(RVA = "0x181DCD0", Offset = "0x181DCD0", VA = "0x181DCD0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000CAF")]
			[Address(RVA = "0x181DCD4", Offset = "0x181DCD4", VA = "0x181DCD4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000CB1")]
			[Address(RVA = "0x181DDCC", Offset = "0x181DDCC", VA = "0x181DDCC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000160")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x867994", Offset = "0x867994")]
		private sealed class <_CallContinuously>d__335 : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private float <>2__current;

			[Token(Token = "0x40005DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Timing <>4__this;

			[Token(Token = "0x40005DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float period;

			[Token(Token = "0x40005E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public GameObject gObject;

			[Token(Token = "0x40005E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Action action;

			[Token(Token = "0x170002B9")]
			private float System.Collections.Generic.IEnumerator<System.Single>.Current
			{
				[Token(Token = "0x6000CB6")]
				[Address(RVA = "0x181C31C", Offset = "0x181C31C", VA = "0x181C31C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x170002BA")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000CB8")]
				[Address(RVA = "0x181C384", Offset = "0x181C384", VA = "0x181C384", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000CB3")]
			[Address(RVA = "0x181C1AC", Offset = "0x181C1AC", VA = "0x181C1AC")]
			[DebuggerHidden]
			public <_CallContinuously>d__335(int <>1__state)
			{
			}

			[Token(Token = "0x6000CB4")]
			[Address(RVA = "0x181C1D8", Offset = "0x181C1D8", VA = "0x181C1D8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000CB5")]
			[Address(RVA = "0x181C1DC", Offset = "0x181C1DC", VA = "0x181C1DC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000CB7")]
			[Address(RVA = "0x181C324", Offset = "0x181C324", VA = "0x181C324", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000161")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8679A4", Offset = "0x8679A4")]
		private sealed class <_WatchCall>d__352<T> : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <>1__state;

			[Token(Token = "0x40005E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private float <>2__current;

			[Token(Token = "0x40005E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Timing <>4__this;

			[Token(Token = "0x40005E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float timeframe;

			[Token(Token = "0x40005E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public CoroutineHandle handle;

			[Token(Token = "0x40005E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<T> onDone;

			[Token(Token = "0x40005E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public GameObject gObject;

			[Token(Token = "0x40005E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public T reference;

			[Token(Token = "0x170002BB")]
			private float System.Collections.Generic.IEnumerator<System.Single>.Current
			{
				[Token(Token = "0x6000CBC")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x170002BC")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000CBE")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000CB9")]
			[DebuggerHidden]
			public <_WatchCall>d__352(int <>1__state)
			{
			}

			[Token(Token = "0x6000CBA")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000CBB")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000CBD")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000162")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8679B4", Offset = "0x8679B4")]
		private sealed class <_CallContinuously>d__353<T> : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <>1__state;

			[Token(Token = "0x40005EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private float <>2__current;

			[Token(Token = "0x40005EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Timing <>4__this;

			[Token(Token = "0x40005ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float period;

			[Token(Token = "0x40005EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public GameObject gObject;

			[Token(Token = "0x40005EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<T> action;

			[Token(Token = "0x40005F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public T reference;

			[Token(Token = "0x170002BD")]
			private float System.Collections.Generic.IEnumerator<System.Single>.Current
			{
				[Token(Token = "0x6000CC2")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x170002BE")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000CC4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000CBF")]
			[DebuggerHidden]
			public <_CallContinuously>d__353(int <>1__state)
			{
			}

			[Token(Token = "0x6000CC0")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000CC1")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000CC3")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x867CA0", Offset = "0x867CA0")]
		public float TimeBetweenSlowUpdateCalls;

		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x867CD8", Offset = "0x867CD8")]
		public DebugInfoType ProfilerDebugAmount;

		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x867D10", Offset = "0x867D10")]
		public bool AutoTriggerManualTimeframe;

		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x867D48", Offset = "0x867D48")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x867D48", Offset = "0x867D48")]
		public int UpdateCoroutines;

		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x867D98", Offset = "0x867D98")]
		public int FixedUpdateCoroutines;

		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x867DD0", Offset = "0x867DD0")]
		public int LateUpdateCoroutines;

		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x867E08", Offset = "0x867E08")]
		public int SlowUpdateCoroutines;

		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x867E40", Offset = "0x867E40")]
		public int RealtimeUpdateCoroutines;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x867E78", Offset = "0x867E78")]
		public int EditorUpdateCoroutines;

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x867EB0", Offset = "0x867EB0")]
		public int EditorSlowUpdateCoroutines;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x867EE8", Offset = "0x867EE8")]
		public int EndOfFrameCoroutines;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x867F20", Offset = "0x867F20")]
		public int ManualTimeframeCoroutines;

		[NonSerialized]
		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float localTime;

		[NonSerialized]
		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float deltaTime;

		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Func<float, float> SetManualTimeframeTime;

		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Func<IEnumerator<float>, CoroutineHandle, IEnumerator<float>> ReplacementFunction;

		[Token(Token = "0x400001E")]
		public const float WaitForOneFrame = float.NegativeInfinity;

		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x867F68", Offset = "0x867F68")]
		private static Thread <MainThread>k__BackingField;

		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x867F78", Offset = "0x867F78")]
		private CoroutineHandle <currentCoroutine>k__BackingField;

		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static object _tmpRef;

		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static int _tmpInt;

		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private static bool _tmpBool;

		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static Segment _tmpSegment;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private static CoroutineHandle _tmpHandle;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private int _currentUpdateFrame;

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int _currentLateUpdateFrame;

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private int _currentSlowUpdateFrame;

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private int _currentRealtimeUpdateFrame;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private int _currentEndOfFrameFrame;

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int _nextUpdateProcessSlot;

		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int _nextLateUpdateProcessSlot;

		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int _nextFixedUpdateProcessSlot;

		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int _nextSlowUpdateProcessSlot;

		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int _nextRealtimeUpdateProcessSlot;

		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private int _nextEditorUpdateProcessSlot;

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private int _nextEditorSlowUpdateProcessSlot;

		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private int _nextEndOfFrameProcessSlot;

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int _nextManualTimeframeProcessSlot;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private int _lastUpdateProcessSlot;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private int _lastLateUpdateProcessSlot;

		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private int _lastFixedUpdateProcessSlot;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private int _lastSlowUpdateProcessSlot;

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private int _lastRealtimeUpdateProcessSlot;

		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private int _lastEndOfFrameProcessSlot;

		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private int _lastManualTimeframeProcessSlot;

		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private float _lastUpdateTime;

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float _lastLateUpdateTime;

		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private float _lastFixedUpdateTime;

		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private float _lastSlowUpdateTime;

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float _lastRealtimeUpdateTime;

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private float _lastEndOfFrameTime;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float _lastManualTimeframeTime;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float _lastSlowUpdateDeltaTime;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float _lastEditorUpdateDeltaTime;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private float _lastEditorSlowUpdateDeltaTime;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private float _lastManualTimeframeDeltaTime;

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private ushort _framesSinceUpdate;

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDE")]
		private ushort _expansions;

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[SerializeField]
		[HideInInspector]
		private byte _instanceID;

		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE1")]
		private bool _EOFPumpRan;

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static readonly Dictionary<CoroutineHandle, HashSet<CoroutineHandle>> Links;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static readonly WaitForEndOfFrame EofWaitObject;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private readonly Dictionary<CoroutineHandle, HashSet<CoroutineHandle>> _waitingTriggers;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private readonly HashSet<CoroutineHandle> _allWaiting;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private readonly Dictionary<CoroutineHandle, ProcessIndex> _handleToIndex;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private readonly Dictionary<ProcessIndex, CoroutineHandle> _indexToHandle;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private readonly Dictionary<CoroutineHandle, string> _processTags;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private readonly Dictionary<string, HashSet<CoroutineHandle>> _taggedProcesses;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private readonly Dictionary<CoroutineHandle, int> _processLayers;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private readonly Dictionary<int, HashSet<CoroutineHandle>> _layeredProcesses;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private IEnumerator<float>[] UpdateProcesses;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private IEnumerator<float>[] LateUpdateProcesses;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private IEnumerator<float>[] FixedUpdateProcesses;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private IEnumerator<float>[] SlowUpdateProcesses;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private IEnumerator<float>[] RealtimeUpdateProcesses;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private IEnumerator<float>[] EditorUpdateProcesses;

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private IEnumerator<float>[] EditorSlowUpdateProcesses;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private IEnumerator<float>[] EndOfFrameProcesses;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private IEnumerator<float>[] ManualTimeframeProcesses;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private bool[] UpdatePaused;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private bool[] LateUpdatePaused;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private bool[] FixedUpdatePaused;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private bool[] SlowUpdatePaused;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private bool[] RealtimeUpdatePaused;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private bool[] EditorUpdatePaused;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private bool[] EditorSlowUpdatePaused;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private bool[] EndOfFramePaused;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private bool[] ManualTimeframePaused;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private bool[] UpdateHeld;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private bool[] LateUpdateHeld;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private bool[] FixedUpdateHeld;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private bool[] SlowUpdateHeld;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private bool[] RealtimeUpdateHeld;

		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private bool[] EditorUpdateHeld;

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private bool[] EditorSlowUpdateHeld;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private bool[] EndOfFrameHeld;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private bool[] ManualTimeframeHeld;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private CoroutineHandle _eofWatcherHandle;

		[Token(Token = "0x4000070")]
		private const ushort FramesUntilMaintenance = 64;

		[Token(Token = "0x4000071")]
		private const int ProcessArrayChunkSize = 64;

		[Token(Token = "0x4000072")]
		private const int InitialBufferSizeLarge = 256;

		[Token(Token = "0x4000073")]
		private const int InitialBufferSizeMedium = 64;

		[Token(Token = "0x4000074")]
		private const int InitialBufferSizeSmall = 8;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static Timing[] ActiveInstances;

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static Timing _instance;

		[Token(Token = "0x1700000A")]
		public static float LocalTime
		{
			[Token(Token = "0x6000030")]
			[Address(RVA = "0xB227E8", Offset = "0xB227E8", VA = "0xB227E8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700000B")]
		public static float DeltaTime
		{
			[Token(Token = "0x6000031")]
			[Address(RVA = "0xB22A8C", Offset = "0xB22A8C", VA = "0xB22A8C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700000C")]
		public static Thread MainThread
		{
			[Token(Token = "0x6000034")]
			[Address(RVA = "0xB22CD8", Offset = "0xB22CD8", VA = "0xB22CD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8759E4", Offset = "0x8759E4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000035")]
			[Address(RVA = "0xB22D40", Offset = "0xB22D40", VA = "0xB22D40")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8759F4", Offset = "0x8759F4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700000D")]
		public static CoroutineHandle CurrentCoroutine
		{
			[Token(Token = "0x6000036")]
			[Address(RVA = "0xB22DAC", Offset = "0xB22DAC", VA = "0xB22DAC")]
			get
			{
				return default(CoroutineHandle);
			}
		}

		[Token(Token = "0x1700000E")]
		public CoroutineHandle currentCoroutine
		{
			[Token(Token = "0x6000037")]
			[Address(RVA = "0xB22F60", Offset = "0xB22F60", VA = "0xB22F60")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x875A04", Offset = "0x875A04")]
			get
			{
				return default(CoroutineHandle);
			}
			[Token(Token = "0x6000038")]
			[Address(RVA = "0xB22F68", Offset = "0xB22F68", VA = "0xB22F68")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x875A14", Offset = "0x875A14")]
			private set
			{
			}
		}

		[Token(Token = "0x1700000F")]
		public static Timing Instance
		{
			[Token(Token = "0x6000039")]
			[Address(RVA = "0xB22854", Offset = "0xB22854", VA = "0xB22854")]
			get
			{
				return null;
			}
			[Token(Token = "0x600003A")]
			[Address(RVA = "0xB231C8", Offset = "0xB231C8", VA = "0xB231C8")]
			set
			{
			}
		}

		[Token(Token = "0x14000001")]
		public static event Action OnPreExecute
		{
			[Token(Token = "0x6000032")]
			[Address(RVA = "0xB22AF8", Offset = "0xB22AF8", VA = "0xB22AF8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8759C4", Offset = "0x8759C4")]
			add
			{
			}
			[Token(Token = "0x6000033")]
			[Address(RVA = "0xB22BE8", Offset = "0xB22BE8", VA = "0xB22BE8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8759D4", Offset = "0x8759D4")]
			remove
			{
			}
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0xB23234", Offset = "0xB23234", VA = "0xB23234")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0xB23304", Offset = "0xB23304", VA = "0xB23304")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0xB23740", Offset = "0xB23740", VA = "0xB23740")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0xB22F70", Offset = "0xB22F70", VA = "0xB22F70")]
		private void InitializeInstanceID()
		{
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0xB23814", Offset = "0xB23814", VA = "0xB23814")]
		private void Update()
		{
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0xB27040", Offset = "0xB27040", VA = "0xB27040")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0xB2776C", Offset = "0xB2776C", VA = "0xB2776C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0xB25114", Offset = "0xB25114", VA = "0xB25114")]
		public void TriggerManualTimeframeUpdate()
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0xB2346C", Offset = "0xB2346C", VA = "0xB2346C")]
		private bool OnEditorStart()
		{
			return default(bool);
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0xB23474", Offset = "0xB23474", VA = "0xB23474")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x875A24", Offset = "0x875A24")]
		private IEnumerator<float> _EOFPumpWatcher()
		{
			return null;
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0xB27E98", Offset = "0xB27E98", VA = "0xB27E98")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x875A88", Offset = "0x875A88")]
		private IEnumerator _EOFPump()
		{
			return null;
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0xB25864", Offset = "0xB25864", VA = "0xB25864")]
		private void RemoveUnused()
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0xB283A0", Offset = "0xB283A0", VA = "0xB283A0")]
		private void EditorRemoveUnused()
		{
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0xB28B60", Offset = "0xB28B60", VA = "0xB28B60")]
		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0xB2B5FC", Offset = "0xB2B5FC", VA = "0xB2B5FC")]
		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, GameObject gameObj)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0xB2B774", Offset = "0xB2B774", VA = "0xB2B774")]
		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, int layer)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0xB2B848", Offset = "0xB2B848", VA = "0xB2B848")]
		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0xB2B91C", Offset = "0xB2B91C", VA = "0xB2B91C")]
		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, GameObject gameObj, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0xB2BAA0", Offset = "0xB2BAA0", VA = "0xB2BAA0")]
		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, int layer, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0xB2BB78", Offset = "0xB2BB78", VA = "0xB2BB78")]
		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, Segment segment)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0xB2BC4C", Offset = "0xB2BC4C", VA = "0xB2BC4C")]
		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, Segment segment, GameObject gameObj)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0xB2BDD0", Offset = "0xB2BDD0", VA = "0xB2BDD0")]
		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, Segment segment, int layer)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0xB2BEA8", Offset = "0xB2BEA8", VA = "0xB2BEA8")]
		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, Segment segment, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0xB2BF80", Offset = "0xB2BF80", VA = "0xB2BF80")]
		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, Segment segment, GameObject gameObj, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0xB2C108", Offset = "0xB2C108", VA = "0xB2C108")]
		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, Segment segment, int layer, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0xB2C1EC", Offset = "0xB2C1EC", VA = "0xB2C1EC")]
		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0xB2C25C", Offset = "0xB2C25C", VA = "0xB2C25C")]
		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, GameObject gameObj)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0xB2C388", Offset = "0xB2C388", VA = "0xB2C388")]
		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, int layer)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0xB2C404", Offset = "0xB2C404", VA = "0xB2C404")]
		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0xB2C480", Offset = "0xB2C480", VA = "0xB2C480")]
		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, GameObject gameObj, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0xB2C5B0", Offset = "0xB2C5B0", VA = "0xB2C5B0")]
		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, int layer, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0xB2C630", Offset = "0xB2C630", VA = "0xB2C630")]
		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, Segment segment)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0xB2C6AC", Offset = "0xB2C6AC", VA = "0xB2C6AC")]
		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, Segment segment, GameObject gameObj)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0xB2C7DC", Offset = "0xB2C7DC", VA = "0xB2C7DC")]
		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, Segment segment, int layer)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0xB2C85C", Offset = "0xB2C85C", VA = "0xB2C85C")]
		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, Segment segment, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0xB2C8DC", Offset = "0xB2C8DC", VA = "0xB2C8DC")]
		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, Segment segment, GameObject gameObj, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0xB2CA18", Offset = "0xB2CA18", VA = "0xB2CA18")]
		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, Segment segment, int layer, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0xB2CAA4", Offset = "0xB2CAA4", VA = "0xB2CAA4")]
		public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, CoroutineHandle handle, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0xB2D314", Offset = "0xB2D314", VA = "0xB2D314")]
		public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, GameObject gameObj, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0xB2D414", Offset = "0xB2D414", VA = "0xB2D414")]
		public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, int layer, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0xB2E19C", Offset = "0xB2E19C", VA = "0xB2E19C")]
		public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0xB2E58C", Offset = "0xB2E58C", VA = "0xB2E58C")]
		public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, GameObject gameObj, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0xB2E6A4", Offset = "0xB2E6A4", VA = "0xB2E6A4")]
		public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, int layer, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0xB2ED84", Offset = "0xB2ED84", VA = "0xB2ED84")]
		public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, CoroutineHandle handle, Segment segment, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0xB2EF6C", Offset = "0xB2EF6C", VA = "0xB2EF6C")]
		public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, Segment segment, GameObject gameObj, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0xB2F080", Offset = "0xB2F080", VA = "0xB2F080")]
		public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, Segment segment, int layer, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0xB2F38C", Offset = "0xB2F38C", VA = "0xB2F38C")]
		public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, Segment segment, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0xB2F698", Offset = "0xB2F698", VA = "0xB2F698")]
		public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, Segment segment, GameObject gameObj, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0xB2F7BC", Offset = "0xB2F7BC", VA = "0xB2F7BC")]
		public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, Segment segment, int layer, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0xB2FCBC", Offset = "0xB2FCBC", VA = "0xB2FCBC")]
		public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, CoroutineHandle handle, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0xB300C0", Offset = "0xB300C0", VA = "0xB300C0")]
		public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, GameObject gameObj, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0xB3018C", Offset = "0xB3018C", VA = "0xB3018C")]
		public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, int layer, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0xB234E4", Offset = "0xB234E4", VA = "0xB234E4")]
		public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0xB308B4", Offset = "0xB308B4", VA = "0xB308B4")]
		public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, GameObject gameObj, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0xB30990", Offset = "0xB30990", VA = "0xB30990")]
		public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, int layer, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0xB31438", Offset = "0xB31438", VA = "0xB31438")]
		public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, Segment segment, GameObject gameObj, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0xB31510", Offset = "0xB31510", VA = "0xB31510")]
		public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, Segment segment, int layer, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0xB31778", Offset = "0xB31778", VA = "0xB31778")]
		public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, Segment segment, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0xB319E0", Offset = "0xB319E0", VA = "0xB319E0")]
		public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, Segment segment, GameObject gameObj, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0xB31AD0", Offset = "0xB31AD0", VA = "0xB31AD0")]
		public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, Segment segment, int layer, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0xB28C28", Offset = "0xB28C28", VA = "0xB28C28")]
		private CoroutineHandle RunCoroutineInternal(IEnumerator<float> coroutine, Segment segment, int layer, bool layerHasValue, string tag, CoroutineHandle handle, bool prewarm)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0xB320CC", Offset = "0xB320CC", VA = "0xB320CC")]
		public static int KillCoroutines()
		{
			return default(int);
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0xB321A8", Offset = "0xB321A8", VA = "0xB321A8")]
		public int KillCoroutinesOnInstance()
		{
			return default(int);
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0xB2CC88", Offset = "0xB2CC88", VA = "0xB2CC88")]
		public static int KillCoroutines(CoroutineHandle handle)
		{
			return default(int);
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0xB325FC", Offset = "0xB325FC", VA = "0xB325FC")]
		public static int KillCoroutines(params CoroutineHandle[] handles)
		{
			return default(int);
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0xB24F24", Offset = "0xB24F24", VA = "0xB24F24")]
		public int KillCoroutinesOnInstance(CoroutineHandle handle)
		{
			return default(int);
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0xB32824", Offset = "0xB32824", VA = "0xB32824")]
		public static int KillCoroutines(GameObject gameObj)
		{
			return default(int);
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0xB32928", Offset = "0xB32928", VA = "0xB32928")]
		public int KillCoroutinesOnInstance(GameObject gameObj)
		{
			return default(int);
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0xB2D714", Offset = "0xB2D714", VA = "0xB2D714")]
		public static int KillCoroutines(int layer)
		{
			return default(int);
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0xB303E8", Offset = "0xB303E8", VA = "0xB303E8")]
		public int KillCoroutinesOnInstance(int layer)
		{
			return default(int);
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0xB2E49C", Offset = "0xB2E49C", VA = "0xB2E49C")]
		public static int KillCoroutines(string tag)
		{
			return default(int);
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0xB3063C", Offset = "0xB3063C", VA = "0xB3063C")]
		public int KillCoroutinesOnInstance(string tag)
		{
			return default(int);
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0xB32A6C", Offset = "0xB32A6C", VA = "0xB32A6C")]
		public static int KillCoroutines(GameObject gameObj, string tag)
		{
			return default(int);
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0xB32B78", Offset = "0xB32B78", VA = "0xB32B78")]
		public int KillCoroutinesOnInstance(GameObject gameObj, string tag)
		{
			return default(int);
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0xB2EB94", Offset = "0xB2EB94", VA = "0xB2EB94")]
		public static int KillCoroutines(int layer, string tag)
		{
			return default(int);
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0xB30D1C", Offset = "0xB30D1C", VA = "0xB30D1C")]
		public int KillCoroutinesOnInstance(int layer, string tag)
		{
			return default(int);
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0xB32550", Offset = "0xB32550", VA = "0xB32550")]
		public static Timing GetInstance(byte ID)
		{
			return null;
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0xB32BB8", Offset = "0xB32BB8", VA = "0xB32BB8")]
		public static float WaitForSeconds(float waitTime)
		{
			return default(float);
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0xB32C44", Offset = "0xB32C44", VA = "0xB32C44")]
		public float WaitForSecondsOnInstance(float waitTime)
		{
			return default(float);
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0xB24C28", Offset = "0xB24C28", VA = "0xB24C28")]
		private bool UpdateTimeValues(Segment segment)
		{
			return default(bool);
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0xB32C88", Offset = "0xB32C88", VA = "0xB32C88")]
		private float GetSegmentTime(Segment segment)
		{
			return default(float);
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0xB32D74", Offset = "0xB32D74", VA = "0xB32D74")]
		public static int PauseCoroutines()
		{
			return default(int);
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0xB32E50", Offset = "0xB32E50", VA = "0xB32E50")]
		public int PauseCoroutinesOnInstance()
		{
			return default(int);
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0xB341E0", Offset = "0xB341E0", VA = "0xB341E0")]
		public int PauseCoroutinesOnInstance(CoroutineHandle handle)
		{
			return default(int);
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0xB340F0", Offset = "0xB340F0", VA = "0xB340F0")]
		public static int PauseCoroutines(CoroutineHandle handle)
		{
			return default(int);
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0xB35178", Offset = "0xB35178", VA = "0xB35178")]
		public static int PauseCoroutines(params CoroutineHandle[] handles)
		{
			return default(int);
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0xB3532C", Offset = "0xB3532C", VA = "0xB3532C")]
		public static int PauseCoroutines(GameObject gameObj)
		{
			return default(int);
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0xB3541C", Offset = "0xB3541C", VA = "0xB3541C")]
		public int PauseCoroutinesOnInstance(GameObject gameObj)
		{
			return default(int);
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0xB35798", Offset = "0xB35798", VA = "0xB35798")]
		public static int PauseCoroutines(int layer)
		{
			return default(int);
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0xB354CC", Offset = "0xB354CC", VA = "0xB354CC")]
		public int PauseCoroutinesOnInstance(int layer)
		{
			return default(int);
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0xB35888", Offset = "0xB35888", VA = "0xB35888")]
		public static int PauseCoroutines(string tag)
		{
			return default(int);
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0xB35978", Offset = "0xB35978", VA = "0xB35978")]
		public int PauseCoroutinesOnInstance(string tag)
		{
			return default(int);
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0xB35C48", Offset = "0xB35C48", VA = "0xB35C48")]
		public static int PauseCoroutines(GameObject gameObj, string tag)
		{
			return default(int);
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0xB360F4", Offset = "0xB360F4", VA = "0xB360F4")]
		public int PauseCoroutinesOnInstance(GameObject gameObj, string tag)
		{
			return default(int);
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0xB361AC", Offset = "0xB361AC", VA = "0xB361AC")]
		public static int PauseCoroutines(int layer, string tag)
		{
			return default(int);
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0xB35D54", Offset = "0xB35D54", VA = "0xB35D54")]
		public int PauseCoroutinesOnInstance(int layer, string tag)
		{
			return default(int);
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0xB362A4", Offset = "0xB362A4", VA = "0xB362A4")]
		public static int ResumeCoroutines()
		{
			return default(int);
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0xB36380", Offset = "0xB36380", VA = "0xB36380")]
		public int ResumeCoroutinesOnInstance()
		{
			return default(int);
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0xB2CECC", Offset = "0xB2CECC", VA = "0xB2CECC")]
		public static int ResumeCoroutines(CoroutineHandle handle)
		{
			return default(int);
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0xB368B4", Offset = "0xB368B4", VA = "0xB368B4")]
		public static int ResumeCoroutines(params CoroutineHandle[] handles)
		{
			return default(int);
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0xB2FE70", Offset = "0xB2FE70", VA = "0xB2FE70")]
		public int ResumeCoroutinesOnInstance(CoroutineHandle handle)
		{
			return default(int);
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0xB2D804", Offset = "0xB2D804", VA = "0xB2D804")]
		public int ResumeCoroutinesOnInstance(IEnumerable<CoroutineHandle> handles)
		{
			return default(int);
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0xB36A68", Offset = "0xB36A68", VA = "0xB36A68")]
		public static int ResumeCoroutines(GameObject gameObj)
		{
			return default(int);
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0xB36E34", Offset = "0xB36E34", VA = "0xB36E34")]
		public int ResumeCoroutinesOnInstance(GameObject gameObj)
		{
			return default(int);
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0xB36EE4", Offset = "0xB36EE4", VA = "0xB36EE4")]
		public static int ResumeCoroutines(int layer)
		{
			return default(int);
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0xB36B6C", Offset = "0xB36B6C", VA = "0xB36B6C")]
		public int ResumeCoroutinesOnInstance(int layer)
		{
			return default(int);
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0xB36FD4", Offset = "0xB36FD4", VA = "0xB36FD4")]
		public static int ResumeCoroutines(string tag)
		{
			return default(int);
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0xB370C4", Offset = "0xB370C4", VA = "0xB370C4")]
		public int ResumeCoroutinesOnInstance(string tag)
		{
			return default(int);
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0xB37390", Offset = "0xB37390", VA = "0xB37390")]
		public static int ResumeCoroutines(GameObject gameObj, string tag)
		{
			return default(int);
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0xB3749C", Offset = "0xB3749C", VA = "0xB3749C")]
		public int ResumeCoroutinesOnInstance(GameObject gameObj, string tag)
		{
			return default(int);
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0xB2EC8C", Offset = "0xB2EC8C", VA = "0xB2EC8C")]
		public static int ResumeCoroutines(int layer, string tag)
		{
			return default(int);
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0xB310E4", Offset = "0xB310E4", VA = "0xB310E4")]
		public int ResumeCoroutinesOnInstance(int layer, string tag)
		{
			return default(int);
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0xB37554", Offset = "0xB37554", VA = "0xB37554")]
		public static string GetTag(CoroutineHandle handle)
		{
			return null;
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0xB37680", Offset = "0xB37680", VA = "0xB37680")]
		public static int? GetLayer(CoroutineHandle handle)
		{
			return null;
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0xB377D0", Offset = "0xB377D0", VA = "0xB377D0")]
		public static string GetDebugName(CoroutineHandle handle)
		{
			return null;
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0xB379EC", Offset = "0xB379EC", VA = "0xB379EC")]
		public static Segment GetSegment(CoroutineHandle handle)
		{
			return default(Segment);
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0xB37AF0", Offset = "0xB37AF0", VA = "0xB37AF0")]
		public static bool SetTag(CoroutineHandle handle, string newTag, bool overwriteExisting = true)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0xB37DAC", Offset = "0xB37DAC", VA = "0xB37DAC")]
		public static bool SetLayer(CoroutineHandle handle, int newLayer, bool overwriteExisting = true)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0xB38068", Offset = "0xB38068", VA = "0xB38068")]
		public static bool SetSegment(CoroutineHandle handle, Segment newSegment)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0xB39300", Offset = "0xB39300", VA = "0xB39300")]
		public static bool RemoveTag(CoroutineHandle handle)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0xB3936C", Offset = "0xB3936C", VA = "0xB3936C")]
		public static bool RemoveLayer(CoroutineHandle handle)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0xB2CDB4", Offset = "0xB2CDB4", VA = "0xB2CDB4")]
		public static bool IsRunning(CoroutineHandle handle)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0xB39490", Offset = "0xB39490", VA = "0xB39490")]
		public static bool IsAliveAndPaused(CoroutineHandle handle)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0xB31E5C", Offset = "0xB31E5C", VA = "0xB31E5C")]
		private void AddTagOnInstance(string tag, CoroutineHandle handle)
		{
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0xB31F94", Offset = "0xB31F94", VA = "0xB31F94")]
		private void AddLayerOnInstance(int layer, CoroutineHandle handle)
		{
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0xB37C58", Offset = "0xB37C58", VA = "0xB37C58")]
		private void RemoveTagOnInstance(CoroutineHandle handle)
		{
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0xB37F14", Offset = "0xB37F14", VA = "0xB37F14")]
		private void RemoveLayerOnInstance(CoroutineHandle handle)
		{
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0xB28164", Offset = "0xB28164", VA = "0xB28164")]
		private void RemoveGraffiti(CoroutineHandle handle)
		{
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0xB38358", Offset = "0xB38358", VA = "0xB38358")]
		private IEnumerator<float> CoindexExtract(ProcessIndex coindex)
		{
			return null;
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0xB27F08", Offset = "0xB27F08", VA = "0xB27F08")]
		private bool CoindexIsNull(ProcessIndex coindex)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0xB37924", Offset = "0xB37924", VA = "0xB37924")]
		private IEnumerator<float> CoindexPeek(ProcessIndex coindex)
		{
			return null;
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0xB327B0", Offset = "0xB327B0", VA = "0xB327B0")]
		private bool Nullify(CoroutineHandle handle)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0xB32960", Offset = "0xB32960", VA = "0xB32960")]
		private bool Nullify(ProcessIndex coindex)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0xB34434", Offset = "0xB34434", VA = "0xB34434")]
		private bool SetPause(ProcessIndex coindex, bool newPausedState)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0xB385BC", Offset = "0xB385BC", VA = "0xB385BC")]
		private bool SetHeld(ProcessIndex coindex, bool newHeldState)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0xB395D0", Offset = "0xB395D0", VA = "0xB395D0")]
		private IEnumerator<float> CreateHold(ProcessIndex coindex, IEnumerator<float> coptr)
		{
			return null;
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0xB384F0", Offset = "0xB384F0", VA = "0xB384F0")]
		private bool CoindexIsPaused(ProcessIndex coindex)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0xB38424", Offset = "0xB38424", VA = "0xB38424")]
		private bool CoindexIsHeld(ProcessIndex coindex)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0xB3A298", Offset = "0xB3A298", VA = "0xB3A298")]
		private void CoindexReplace(ProcessIndex coindex, IEnumerator<float> replacement)
		{
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0xB3A394", Offset = "0xB3A394", VA = "0xB3A394")]
		public static float WaitUntilDone(IEnumerator<float> newCoroutine)
		{
			return default(float);
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0xB3A730", Offset = "0xB3A730", VA = "0xB3A730")]
		public static float WaitUntilDone(IEnumerator<float> newCoroutine, string tag)
		{
			return default(float);
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0xB3A7D0", Offset = "0xB3A7D0", VA = "0xB3A7D0")]
		public static float WaitUntilDone(IEnumerator<float> newCoroutine, int layer)
		{
			return default(float);
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0xB3A870", Offset = "0xB3A870", VA = "0xB3A870")]
		public static float WaitUntilDone(IEnumerator<float> newCoroutine, int layer, string tag)
		{
			return default(float);
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0xB3A920", Offset = "0xB3A920", VA = "0xB3A920")]
		public static float WaitUntilDone(IEnumerator<float> newCoroutine, Segment segment)
		{
			return default(float);
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0xB3A9A0", Offset = "0xB3A9A0", VA = "0xB3A9A0")]
		public static float WaitUntilDone(IEnumerator<float> newCoroutine, Segment segment, string tag)
		{
			return default(float);
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0xB3AA28", Offset = "0xB3AA28", VA = "0xB3AA28")]
		public static float WaitUntilDone(IEnumerator<float> newCoroutine, Segment segment, int layer)
		{
			return default(float);
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0xB3AAB0", Offset = "0xB3AAB0", VA = "0xB3AAB0")]
		public static float WaitUntilDone(IEnumerator<float> newCoroutine, Segment segment, int layer, string tag)
		{
			return default(float);
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0xB3AB48", Offset = "0xB3AB48", VA = "0xB3AB48")]
		public static float WaitUntilDone(CoroutineHandle otherCoroutine)
		{
			return default(float);
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0xB3A42C", Offset = "0xB3A42C", VA = "0xB3A42C")]
		public static float WaitUntilDone(CoroutineHandle otherCoroutine, bool warnOnIssue)
		{
			return default(float);
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0xB2CFBC", Offset = "0xB2CFBC", VA = "0xB2CFBC")]
		public static void WaitForOtherHandles(CoroutineHandle handle, CoroutineHandle otherHandle, bool warnOnIssue = true)
		{
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0xB2D9B0", Offset = "0xB2D9B0", VA = "0xB2D9B0")]
		public static void WaitForOtherHandles(CoroutineHandle handle, IEnumerable<CoroutineHandle> otherHandles, bool warnOnIssue = true)
		{
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0xB3AC38", Offset = "0xB3AC38", VA = "0xB3AC38")]
		private void SwapToLast(CoroutineHandle firstHandle, CoroutineHandle lastHandle)
		{
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0xB3ABB0", Offset = "0xB3ABB0", VA = "0xB3ABB0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x875AEC", Offset = "0x875AEC")]
		private IEnumerator<float> _StartWhenDone(CoroutineHandle handle, IEnumerator<float> proc)
		{
			return null;
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0xB27FD8", Offset = "0xB27FD8", VA = "0xB27FD8")]
		private void CloseWaitingProcess(CoroutineHandle handle)
		{
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0xB3AFD0", Offset = "0xB3AFD0", VA = "0xB3AFD0")]
		private bool HandleIsInWaitingList(CoroutineHandle handle)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0xB3B09C", Offset = "0xB3B09C", VA = "0xB3B09C")]
		private static IEnumerator<float> ReturnTmpRefForRepFunc(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			return null;
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0xB3B110", Offset = "0xB3B110", VA = "0xB3B110")]
		public static float WaitUntilDone(AsyncOperation operation)
		{
			return default(float);
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0xB3B2A4", Offset = "0xB3B2A4", VA = "0xB3B2A4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x875B50", Offset = "0x875B50")]
		private static IEnumerator<float> _StartWhenDone(AsyncOperation operation, IEnumerator<float> pausedProc)
		{
			return null;
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0xB3B320", Offset = "0xB3B320", VA = "0xB3B320")]
		public static float WaitUntilDone(CustomYieldInstruction operation)
		{
			return default(float);
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0xB3B4B8", Offset = "0xB3B4B8", VA = "0xB3B4B8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x875BB4", Offset = "0x875BB4")]
		private static IEnumerator<float> _StartWhenDone(CustomYieldInstruction operation, IEnumerator<float> pausedProc)
		{
			return null;
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0xB3B534", Offset = "0xB3B534", VA = "0xB3B534")]
		public static float WaitUntilTrue(Func<bool> evaluatorFunc)
		{
			return default(float);
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0xB3B604", Offset = "0xB3B604", VA = "0xB3B604")]
		private static IEnumerator<float> WaitUntilTrueHelper(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			return null;
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0xB3B728", Offset = "0xB3B728", VA = "0xB3B728")]
		public static float WaitUntilFalse(Func<bool> evaluatorFunc)
		{
			return default(float);
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0xB3B7F8", Offset = "0xB3B7F8", VA = "0xB3B7F8")]
		private static IEnumerator<float> WaitUntilFalseHelper(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			return null;
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0xB3B69C", Offset = "0xB3B69C", VA = "0xB3B69C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x875C18", Offset = "0x875C18")]
		private static IEnumerator<float> _StartWhenDone(Func<bool> evaluatorFunc, bool continueOn, IEnumerator<float> pausedProc)
		{
			return null;
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0xB34060", Offset = "0xB34060", VA = "0xB34060")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x875C7C", Offset = "0x875C7C")]
		private IEnumerator<float> _InjectDelay(IEnumerator<float> proc, float waitTime)
		{
			return null;
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0xB3B890", Offset = "0xB3B890", VA = "0xB3B890")]
		public bool LockCoroutine(CoroutineHandle coroutine, CoroutineHandle key)
		{
			return default(bool);
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0xB3BA6C", Offset = "0xB3BA6C", VA = "0xB3BA6C")]
		public bool UnlockCoroutine(CoroutineHandle coroutine, CoroutineHandle key)
		{
			return default(bool);
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0xB3BC2C", Offset = "0xB3BC2C", VA = "0xB3BC2C")]
		public static int LinkCoroutines(CoroutineHandle master, CoroutineHandle slave)
		{
			return default(int);
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0xB3BE8C", Offset = "0xB3BE8C", VA = "0xB3BE8C")]
		public static int UnlinkCoroutines(CoroutineHandle master, CoroutineHandle slave, bool twoWay = false)
		{
			return default(int);
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0xB3C1E0", Offset = "0xB3C1E0", VA = "0xB3C1E0")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x875CE0", Offset = "0x875CE0")]
		public static float GetMyHandle(Action<CoroutineHandle> reciever)
		{
			return default(float);
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0xB3C294", Offset = "0xB3C294", VA = "0xB3C294")]
		private static IEnumerator<float> GetHandleHelper(IEnumerator<float> input, CoroutineHandle handle)
		{
			return null;
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0xB3C34C", Offset = "0xB3C34C", VA = "0xB3C34C")]
		public static float SwitchCoroutine(Segment newSegment)
		{
			return default(float);
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0xB3C400", Offset = "0xB3C400", VA = "0xB3C400")]
		private static IEnumerator<float> SwitchCoroutineRepS(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			return null;
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0xB3C4C4", Offset = "0xB3C4C4", VA = "0xB3C4C4")]
		public static float SwitchCoroutine(Segment newSegment, string newTag)
		{
			return default(float);
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0xB3C58C", Offset = "0xB3C58C", VA = "0xB3C58C")]
		private static IEnumerator<float> SwitchCoroutineRepST(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			return null;
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0xB3C6F8", Offset = "0xB3C6F8", VA = "0xB3C6F8")]
		public static float SwitchCoroutine(Segment newSegment, int newLayer)
		{
			return default(float);
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0xB3C7C0", Offset = "0xB3C7C0", VA = "0xB3C7C0")]
		private static IEnumerator<float> SwitchCoroutineRepSL(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			return null;
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0xB3C8B0", Offset = "0xB3C8B0", VA = "0xB3C8B0")]
		public static float SwitchCoroutine(Segment newSegment, int newLayer, string newTag)
		{
			return default(float);
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0xB3C984", Offset = "0xB3C984", VA = "0xB3C984")]
		private static IEnumerator<float> SwitchCoroutineRepSLT(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			return null;
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0xB3CB14", Offset = "0xB3CB14", VA = "0xB3CB14")]
		public static float SwitchCoroutine(string newTag)
		{
			return default(float);
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0xB3CBC8", Offset = "0xB3CBC8", VA = "0xB3CBC8")]
		private static IEnumerator<float> SwitchCoroutineRepT(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			return null;
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0xB3CCF0", Offset = "0xB3CCF0", VA = "0xB3CCF0")]
		public static float SwitchCoroutine(int newLayer)
		{
			return default(float);
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0xB3CDA4", Offset = "0xB3CDA4", VA = "0xB3CDA4")]
		private static IEnumerator<float> SwitchCoroutineRepL(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			return null;
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0xB3CE4C", Offset = "0xB3CE4C", VA = "0xB3CE4C")]
		public static float SwitchCoroutine(int newLayer, string newTag)
		{
			return default(float);
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0xB3CF14", Offset = "0xB3CF14", VA = "0xB3CF14")]
		private static IEnumerator<float> SwitchCoroutineRepLT(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			return null;
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0xB3D060", Offset = "0xB3D060", VA = "0xB3D060")]
		public static CoroutineHandle CallDelayed(float delay, Action action)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0xB3D190", Offset = "0xB3D190", VA = "0xB3D190")]
		public CoroutineHandle CallDelayedOnInstance(float delay, Action action)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0xB3D1D0", Offset = "0xB3D1D0", VA = "0xB3D1D0")]
		public static CoroutineHandle CallDelayed(float delay, Action action, GameObject gameObject)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0xB3D27C", Offset = "0xB3D27C", VA = "0xB3D27C")]
		public CoroutineHandle CallDelayedOnInstance(float delay, Action action, GameObject gameObject)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0xB3D0FC", Offset = "0xB3D0FC", VA = "0xB3D0FC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x875D1C", Offset = "0x875D1C")]
		private IEnumerator<float> _DelayedCall(float delay, Action action, GameObject cancelWith)
		{
			return null;
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0xB3D2C0", Offset = "0xB3D2C0", VA = "0xB3D2C0")]
		public static CoroutineHandle CallDelayed(float delay, Segment segment, Action action)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0xB3D36C", Offset = "0xB3D36C", VA = "0xB3D36C")]
		public CoroutineHandle CallDelayedOnInstance(float delay, Segment segment, Action action)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0xB3D3B8", Offset = "0xB3D3B8", VA = "0xB3D3B8")]
		public static CoroutineHandle CallDelayed(float delay, Segment segment, Action action, GameObject gameObject)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0xB3D46C", Offset = "0xB3D46C", VA = "0xB3D46C")]
		public CoroutineHandle CallDelayedOnInstance(float delay, Segment segment, Action action, GameObject gameObject)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0xB3D4C8", Offset = "0xB3D4C8", VA = "0xB3D4C8")]
		public static CoroutineHandle CallPeriodically(float timeframe, float period, Action action, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0xB3D6F8", Offset = "0xB3D6F8", VA = "0xB3D6F8")]
		public CoroutineHandle CallPeriodicallyOnInstance(float timeframe, float period, Action action, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0xB3D790", Offset = "0xB3D790", VA = "0xB3D790")]
		public static CoroutineHandle CallPeriodically(float timeframe, float period, Action action, GameObject gameObject, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0xB3D8A0", Offset = "0xB3D8A0", VA = "0xB3D8A0")]
		public CoroutineHandle CallPeriodicallyOnInstance(float timeframe, float period, Action action, GameObject gameObject, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0xB3D9A8", Offset = "0xB3D9A8", VA = "0xB3D9A8")]
		public static CoroutineHandle CallPeriodically(float timeframe, float period, Action action, Segment timing, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0xB3DAAC", Offset = "0xB3DAAC", VA = "0xB3DAAC")]
		public CoroutineHandle CallPeriodicallyOnInstance(float timeframe, float period, Action action, Segment timing, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0xB3DBB4", Offset = "0xB3DBB4", VA = "0xB3DBB4")]
		public static CoroutineHandle CallPeriodically(float timeframe, float period, Action action, Segment timing, GameObject gameObject, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0xB3DCD8", Offset = "0xB3DCD8", VA = "0xB3DCD8")]
		public CoroutineHandle CallPeriodicallyOnInstance(float timeframe, float period, Action action, Segment timing, GameObject gameObject, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0xB3DDEC", Offset = "0xB3DDEC", VA = "0xB3DDEC")]
		public static CoroutineHandle CallContinuously(float timeframe, Action action, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0xB3DEEC", Offset = "0xB3DEEC", VA = "0xB3DEEC")]
		public CoroutineHandle CallContinuouslyOnInstance(float timeframe, Action action, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0xB3DFDC", Offset = "0xB3DFDC", VA = "0xB3DFDC")]
		public static CoroutineHandle CallContinuously(float timeframe, Action action, GameObject gameObject, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0xB3E0E8", Offset = "0xB3E0E8", VA = "0xB3E0E8")]
		public CoroutineHandle CallContinuouslyOnInstance(float timeframe, Action action, GameObject gameObject, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0xB3E1EC", Offset = "0xB3E1EC", VA = "0xB3E1EC")]
		public static CoroutineHandle CallContinuously(float timeframe, Action action, Segment timing, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0xB3E2F8", Offset = "0xB3E2F8", VA = "0xB3E2F8")]
		public CoroutineHandle CallContinuouslyOnInstance(float timeframe, Action action, Segment timing, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0xB3E3FC", Offset = "0xB3E3FC", VA = "0xB3E3FC")]
		public static CoroutineHandle CallContinuously(float timeframe, Action action, Segment timing, GameObject gameObject, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0xB3E51C", Offset = "0xB3E51C", VA = "0xB3E51C")]
		public CoroutineHandle CallContinuouslyOnInstance(float timeframe, Action action, Segment timing, GameObject gameObject, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0xB3D654", Offset = "0xB3D654", VA = "0xB3D654")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x875D80", Offset = "0x875D80")]
		private IEnumerator<float> _WatchCall(float timeframe, CoroutineHandle handle, GameObject gObject, Action onDone)
		{
			return null;
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0xB3D5C0", Offset = "0xB3D5C0", VA = "0xB3D5C0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x875DE4", Offset = "0x875DE4")]
		private IEnumerator<float> _CallContinuously(float period, Action action, GameObject gObject)
		{
			return null;
		}

		[Token(Token = "0x6000110")]
		public static CoroutineHandle CallPeriodically<T>(T reference, float timeframe, float period, Action<T> action, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000111")]
		public CoroutineHandle CallPeriodicallyOnInstance<T>(T reference, float timeframe, float period, Action<T> action, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000112")]
		public static CoroutineHandle CallPeriodically<T>(T reference, float timeframe, float period, Action<T> action, GameObject gameObject, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000113")]
		public CoroutineHandle CallPeriodicallyOnInstance<T>(T reference, float timeframe, float period, Action<T> action, GameObject gameObject, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000114")]
		public static CoroutineHandle CallPeriodically<T>(T reference, float timeframe, float period, Action<T> action, Segment timing, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000115")]
		public CoroutineHandle CallPeriodicallyOnInstance<T>(T reference, float timeframe, float period, Action<T> action, Segment timing, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000116")]
		public static CoroutineHandle CallPeriodically<T>(T reference, float timeframe, float period, Action<T> action, Segment timing, GameObject gameObject, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000117")]
		public CoroutineHandle CallPeriodicallyOnInstance<T>(T reference, float timeframe, float period, Action<T> action, Segment timing, GameObject gameObject, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000118")]
		public static CoroutineHandle CallContinuously<T>(T reference, float timeframe, Action<T> action, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000119")]
		public CoroutineHandle CallContinuouslyOnInstance<T>(T reference, float timeframe, Action<T> action, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600011A")]
		public static CoroutineHandle CallContinuously<T>(T reference, float timeframe, Action<T> action, GameObject gameObject, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600011B")]
		public CoroutineHandle CallContinuouslyOnInstance<T>(T reference, float timeframe, Action<T> action, GameObject gameObject, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600011C")]
		public static CoroutineHandle CallContinuously<T>(T reference, float timeframe, Action<T> action, Segment timing, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600011D")]
		public CoroutineHandle CallContinuouslyOnInstance<T>(T reference, float timeframe, Action<T> action, Segment timing, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600011E")]
		public static CoroutineHandle CallContinuously<T>(T reference, float timeframe, Action<T> action, Segment timing, GameObject gameObject, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600011F")]
		public CoroutineHandle CallContinuouslyOnInstance<T>(T reference, float timeframe, Action<T> action, Segment timing, GameObject gameObject, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000120")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x875E48", Offset = "0x875E48")]
		private IEnumerator<float> _WatchCall<T>(T reference, float timeframe, CoroutineHandle handle, GameObject gObject, Action<T> onDone)
		{
			return null;
		}

		[Token(Token = "0x6000121")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x875EAC", Offset = "0x875EAC")]
		private IEnumerator<float> _CallContinuously<T>(T reference, float period, Action<T> action, GameObject gObject)
		{
			return null;
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0xB3E62C", Offset = "0xB3E62C", VA = "0xB3E62C")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x875F10", Offset = "0x875F10")]
		public new Coroutine StartCoroutine(IEnumerator routine)
		{
			return null;
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0xB3E634", Offset = "0xB3E634", VA = "0xB3E634")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x875F4C", Offset = "0x875F4C")]
		public new Coroutine StartCoroutine(string methodName, object value)
		{
			return null;
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0xB3E63C", Offset = "0xB3E63C", VA = "0xB3E63C")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x875F88", Offset = "0x875F88")]
		public new Coroutine StartCoroutine(string methodName)
		{
			return null;
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0xB3E644", Offset = "0xB3E644", VA = "0xB3E644")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x875FC4", Offset = "0x875FC4")]
		public new Coroutine StartCoroutine_Auto(IEnumerator routine)
		{
			return null;
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0xB3E64C", Offset = "0xB3E64C", VA = "0xB3E64C")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x876000", Offset = "0x876000")]
		public new void StopCoroutine(string methodName)
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0xB3E650", Offset = "0xB3E650", VA = "0xB3E650")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x87603C", Offset = "0x87603C")]
		public new void StopCoroutine(IEnumerator routine)
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0xB3E654", Offset = "0xB3E654", VA = "0xB3E654")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x876078", Offset = "0x876078")]
		public new void StopCoroutine(Coroutine routine)
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0xB3E658", Offset = "0xB3E658", VA = "0xB3E658")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x8760B4", Offset = "0x8760B4")]
		public new void StopAllCoroutines()
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0xB3E65C", Offset = "0xB3E65C", VA = "0xB3E65C")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x8760F0", Offset = "0x8760F0")]
		public new static void Destroy(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0xB3E660", Offset = "0xB3E660", VA = "0xB3E660")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x87612C", Offset = "0x87612C")]
		public new static void Destroy(UnityEngine.Object obj, float f)
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0xB3E664", Offset = "0xB3E664", VA = "0xB3E664")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x876168", Offset = "0x876168")]
		public static void DestroyObject(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0xB3E668", Offset = "0xB3E668", VA = "0xB3E668")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x8761A4", Offset = "0x8761A4")]
		public static void DestroyObject(UnityEngine.Object obj, float f)
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0xB3E66C", Offset = "0xB3E66C", VA = "0xB3E66C")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x8761E0", Offset = "0x8761E0")]
		public new static void DestroyImmediate(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0xB3E670", Offset = "0xB3E670", VA = "0xB3E670")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x87621C", Offset = "0x87621C")]
		public new static void DestroyImmediate(UnityEngine.Object obj, bool b)
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0xB3E674", Offset = "0xB3E674", VA = "0xB3E674")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x876258", Offset = "0x876258")]
		public new static void Instantiate(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0xB3E678", Offset = "0xB3E678", VA = "0xB3E678")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x876294", Offset = "0x876294")]
		public new static void Instantiate(UnityEngine.Object original, Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000132")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x8762D0", Offset = "0x8762D0")]
		public new static void Instantiate<T>(T original) where T : UnityEngine.Object
		{
		}

		[Token(Token = "0x6000133")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x87630C", Offset = "0x87630C")]
		public new static T FindObjectOfType<T>() where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0xB3E67C", Offset = "0xB3E67C", VA = "0xB3E67C")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x876348", Offset = "0x876348")]
		public new static UnityEngine.Object FindObjectOfType(Type t)
		{
			return null;
		}

		[Token(Token = "0x6000135")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x876384", Offset = "0x876384")]
		public new static T[] FindObjectsOfType<T>() where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0xB3E684", Offset = "0xB3E684", VA = "0xB3E684")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x8763C0", Offset = "0x8763C0")]
		public new static UnityEngine.Object[] FindObjectsOfType(Type t)
		{
			return null;
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0xB3E68C", Offset = "0xB3E68C", VA = "0xB3E68C")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x8763FC", Offset = "0x8763FC")]
		public new static void print(object message)
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0xB3E690", Offset = "0xB3E690", VA = "0xB3E690")]
		public Timing()
		{
		}
	}
	[Token(Token = "0x200000A")]
	public enum Segment
	{
		[Token(Token = "0x4000078")]
		Invalid = -1,
		[Token(Token = "0x4000079")]
		Update,
		[Token(Token = "0x400007A")]
		FixedUpdate,
		[Token(Token = "0x400007B")]
		LateUpdate,
		[Token(Token = "0x400007C")]
		SlowUpdate,
		[Token(Token = "0x400007D")]
		RealtimeUpdate,
		[Token(Token = "0x400007E")]
		EditorUpdate,
		[Token(Token = "0x400007F")]
		EditorSlowUpdate,
		[Token(Token = "0x4000080")]
		EndOfFrame,
		[Token(Token = "0x4000081")]
		ManualTimeframe
	}
	[Token(Token = "0x200000B")]
	public enum DebugInfoType
	{
		[Token(Token = "0x4000083")]
		None,
		[Token(Token = "0x4000084")]
		SeperateCoroutines,
		[Token(Token = "0x4000085")]
		SeperateTags
	}
	[Token(Token = "0x200000C")]
	public enum SingletonBehavior
	{
		[Token(Token = "0x4000087")]
		Abort,
		[Token(Token = "0x4000088")]
		Overwrite,
		[Token(Token = "0x4000089")]
		Wait,
		[Token(Token = "0x400008A")]
		AbortAndUnpause
	}
	[Token(Token = "0x200000D")]
	public struct CoroutineHandle : IEquatable<CoroutineHandle>
	{
		[Token(Token = "0x2000163")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8679C4", Offset = "0x8679C4")]
		private sealed class <_OnDestroy>d__32 : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private float <>2__current;

			[Token(Token = "0x40005F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public CoroutineHandle watched;

			[Token(Token = "0x40005F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Action action;

			[Token(Token = "0x170002BF")]
			private float System.Collections.Generic.IEnumerator<System.Single>.Current
			{
				[Token(Token = "0x6000CC8")]
				[Address(RVA = "0x18160B4", Offset = "0x18160B4", VA = "0x18160B4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x170002C0")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000CCA")]
				[Address(RVA = "0x181611C", Offset = "0x181611C", VA = "0x181611C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000CC5")]
			[Address(RVA = "0x181601C", Offset = "0x181601C", VA = "0x181601C")]
			[DebuggerHidden]
			public <_OnDestroy>d__32(int <>1__state)
			{
			}

			[Token(Token = "0x6000CC6")]
			[Address(RVA = "0x1816048", Offset = "0x1816048", VA = "0x1816048", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000CC7")]
			[Address(RVA = "0x181604C", Offset = "0x181604C", VA = "0x181604C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000CC9")]
			[Address(RVA = "0x18160BC", Offset = "0x18160BC", VA = "0x18160BC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000164")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8679D4", Offset = "0x8679D4")]
		private sealed class <_OnDestroy>d__33 : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private float <>2__current;

			[Token(Token = "0x40005F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public CoroutineHandle watched;

			[Token(Token = "0x40005F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public IEnumerator<float> action;

			[Token(Token = "0x170002C1")]
			private float System.Collections.Generic.IEnumerator<System.Single>.Current
			{
				[Token(Token = "0x6000CCE")]
				[Address(RVA = "0x181632C", Offset = "0x181632C", VA = "0x181632C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x170002C2")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000CD0")]
				[Address(RVA = "0x1816394", Offset = "0x1816394", VA = "0x1816394", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000CCB")]
			[Address(RVA = "0x1816180", Offset = "0x1816180", VA = "0x1816180")]
			[DebuggerHidden]
			public <_OnDestroy>d__33(int <>1__state)
			{
			}

			[Token(Token = "0x6000CCC")]
			[Address(RVA = "0x18161AC", Offset = "0x18161AC", VA = "0x18161AC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000CCD")]
			[Address(RVA = "0x18161B0", Offset = "0x18161B0", VA = "0x18161B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000CCF")]
			[Address(RVA = "0x1816334", Offset = "0x1816334", VA = "0x1816334", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400008B")]
		private const byte ReservedSpace = 15;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int[] NextIndex;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly int _id;

		[Token(Token = "0x17000010")]
		public byte Key
		{
			[Token(Token = "0x600013A")]
			[Address(RVA = "0x9C2268", Offset = "0x9C2268", VA = "0x9C2268")]
			get
			{
				return default(byte);
			}
		}

		[Token(Token = "0x17000011")]
		public string Tag
		{
			[Token(Token = "0x6000143")]
			[Address(RVA = "0x9C22AC", Offset = "0x9C22AC", VA = "0x9C22AC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000144")]
			[Address(RVA = "0x9C22B4", Offset = "0x9C22B4", VA = "0x9C22B4")]
			set
			{
			}
		}

		[Token(Token = "0x17000012")]
		public int? Layer
		{
			[Token(Token = "0x6000145")]
			[Address(RVA = "0x9C22BC", Offset = "0x9C22BC", VA = "0x9C22BC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000146")]
			[Address(RVA = "0x9C22C4", Offset = "0x9C22C4", VA = "0x9C22C4")]
			set
			{
			}
		}

		[Token(Token = "0x17000013")]
		public Segment Segment
		{
			[Token(Token = "0x6000147")]
			[Address(RVA = "0x9C22CC", Offset = "0x9C22CC", VA = "0x9C22CC")]
			get
			{
				return default(Segment);
			}
			[Token(Token = "0x6000148")]
			[Address(RVA = "0x9C22D4", Offset = "0x9C22D4", VA = "0x9C22D4")]
			set
			{
			}
		}

		[Token(Token = "0x17000014")]
		public bool IsRunning
		{
			[Token(Token = "0x6000149")]
			[Address(RVA = "0x9C22DC", Offset = "0x9C22DC", VA = "0x9C22DC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600014A")]
			[Address(RVA = "0x9C22E4", Offset = "0x9C22E4", VA = "0x9C22E4")]
			set
			{
			}
		}

		[Token(Token = "0x17000015")]
		public bool IsAliveAndPaused
		{
			[Token(Token = "0x600014B")]
			[Address(RVA = "0x9C22F0", Offset = "0x9C22F0", VA = "0x9C22F0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600014C")]
			[Address(RVA = "0x9C22F8", Offset = "0x9C22F8", VA = "0x9C22F8")]
			set
			{
			}
		}

		[Token(Token = "0x17000016")]
		public bool IsValid
		{
			[Token(Token = "0x600014D")]
			[Address(RVA = "0x9C2304", Offset = "0x9C2304", VA = "0x9C2304")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x9C2274", Offset = "0x9C2274", VA = "0x9C2274")]
		public CoroutineHandle(byte ind)
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x9C227C", Offset = "0x9C227C", VA = "0x9C227C")]
		public CoroutineHandle(CoroutineHandle other)
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x9C2284", Offset = "0x9C2284", VA = "0x9C2284", Slot = "4")]
		public bool Equals(CoroutineHandle other)
		{
			return default(bool);
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x9C2294", Offset = "0x9C2294", VA = "0x9C2294", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x10A88D8", Offset = "0x10A88D8", VA = "0x10A88D8")]
		public static bool operator ==(CoroutineHandle a, CoroutineHandle b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x10A88E4", Offset = "0x10A88E4", VA = "0x10A88E4")]
		public static bool operator !=(CoroutineHandle a, CoroutineHandle b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x9C229C", Offset = "0x9C229C", VA = "0x9C229C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x9C22A4", Offset = "0x9C22A4", VA = "0x9C22A4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x9C2314", Offset = "0x9C2314", VA = "0x9C2314")]
		public CoroutineHandle OnDestroy(Action action, Segment segment = Segment.Update)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x9C2330", Offset = "0x9C2330", VA = "0x9C2330")]
		public CoroutineHandle OnDestroy(IEnumerator<float> action, Segment segment = Segment.Update)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x10A92C4", Offset = "0x10A92C4", VA = "0x10A92C4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x876438", Offset = "0x876438")]
		private static IEnumerator<float> _OnDestroy(CoroutineHandle watched, Action action)
		{
			return null;
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x10A9464", Offset = "0x10A9464", VA = "0x10A9464")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x87649C", Offset = "0x87649C")]
		private static IEnumerator<float> _OnDestroy(CoroutineHandle watched, IEnumerator<float> action)
		{
			return null;
		}
	}
	[Token(Token = "0x200000E")]
	public static class MECExtensionMethods1
	{
		[Token(Token = "0x6000153")]
		[Address(RVA = "0xDEB0F0", Offset = "0xDEB0F0", VA = "0xDEB0F0")]
		public static CoroutineHandle RunCoroutine(this IEnumerator<float> coroutine)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0xDEB160", Offset = "0xDEB160", VA = "0xDEB160")]
		public static CoroutineHandle RunCoroutine(this IEnumerator<float> coroutine, GameObject gameObj)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0xDEB1E0", Offset = "0xDEB1E0", VA = "0xDEB1E0")]
		public static CoroutineHandle RunCoroutine(this IEnumerator<float> coroutine, int layer)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0xDEB260", Offset = "0xDEB260", VA = "0xDEB260")]
		public static CoroutineHandle RunCoroutine(this IEnumerator<float> coroutine, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0xDEB2E0", Offset = "0xDEB2E0", VA = "0xDEB2E0")]
		public static CoroutineHandle RunCoroutine(this IEnumerator<float> coroutine, GameObject gameObj, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0xDEB368", Offset = "0xDEB368", VA = "0xDEB368")]
		public static CoroutineHandle RunCoroutine(this IEnumerator<float> coroutine, int layer, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0xDEB3F0", Offset = "0xDEB3F0", VA = "0xDEB3F0")]
		public static CoroutineHandle RunCoroutine(this IEnumerator<float> coroutine, Segment segment)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0xDEB470", Offset = "0xDEB470", VA = "0xDEB470")]
		public static CoroutineHandle RunCoroutine(this IEnumerator<float> coroutine, Segment segment, GameObject gameObj)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0xDEB4F8", Offset = "0xDEB4F8", VA = "0xDEB4F8")]
		public static CoroutineHandle RunCoroutine(this IEnumerator<float> coroutine, Segment segment, int layer)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0xDEB580", Offset = "0xDEB580", VA = "0xDEB580")]
		public static CoroutineHandle RunCoroutine(this IEnumerator<float> coroutine, Segment segment, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0xDEB608", Offset = "0xDEB608", VA = "0xDEB608")]
		public static CoroutineHandle RunCoroutine(this IEnumerator<float> coroutine, Segment segment, GameObject gameObj, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0xDEB6A0", Offset = "0xDEB6A0", VA = "0xDEB6A0")]
		public static CoroutineHandle RunCoroutine(this IEnumerator<float> coroutine, Segment segment, int layer, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0xDEB738", Offset = "0xDEB738", VA = "0xDEB738")]
		public static CoroutineHandle RunCoroutineSingleton(this IEnumerator<float> coroutine, CoroutineHandle handle, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0xDEB7C0", Offset = "0xDEB7C0", VA = "0xDEB7C0")]
		public static CoroutineHandle RunCoroutineSingleton(this IEnumerator<float> coroutine, GameObject gameObj, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0xDEB8C8", Offset = "0xDEB8C8", VA = "0xDEB8C8")]
		public static CoroutineHandle RunCoroutineSingleton(this IEnumerator<float> coroutine, int layer, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0xDEB950", Offset = "0xDEB950", VA = "0xDEB950")]
		public static CoroutineHandle RunCoroutineSingleton(this IEnumerator<float> coroutine, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0xDEB9D8", Offset = "0xDEB9D8", VA = "0xDEB9D8")]
		public static CoroutineHandle RunCoroutineSingleton(this IEnumerator<float> coroutine, GameObject gameObj, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0xDEBAF8", Offset = "0xDEBAF8", VA = "0xDEBAF8")]
		public static CoroutineHandle RunCoroutineSingleton(this IEnumerator<float> coroutine, int layer, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0xDEBB90", Offset = "0xDEBB90", VA = "0xDEBB90")]
		public static CoroutineHandle RunCoroutineSingleton(this IEnumerator<float> coroutine, CoroutineHandle handle, Segment segment, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0xDEBC28", Offset = "0xDEBC28", VA = "0xDEBC28")]
		public static CoroutineHandle RunCoroutineSingleton(this IEnumerator<float> coroutine, Segment segment, GameObject gameObj, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0xDEBD44", Offset = "0xDEBD44", VA = "0xDEBD44")]
		public static CoroutineHandle RunCoroutineSingleton(this IEnumerator<float> coroutine, Segment segment, int layer, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0xDEBDDC", Offset = "0xDEBDDC", VA = "0xDEBDDC")]
		public static CoroutineHandle RunCoroutineSingleton(this IEnumerator<float> coroutine, Segment segment, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0xDEBE74", Offset = "0xDEBE74", VA = "0xDEBE74")]
		public static CoroutineHandle RunCoroutineSingleton(this IEnumerator<float> coroutine, Segment segment, GameObject gameObj, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0xDEBFA0", Offset = "0xDEBFA0", VA = "0xDEBFA0")]
		public static CoroutineHandle RunCoroutineSingleton(this IEnumerator<float> coroutine, Segment segment, int layer, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0xDEC040", Offset = "0xDEC040", VA = "0xDEC040")]
		public static float WaitUntilDone(this IEnumerator<float> newCoroutine)
		{
			return default(float);
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0xDEC0A8", Offset = "0xDEC0A8", VA = "0xDEC0A8")]
		public static float WaitUntilDone(this IEnumerator<float> newCoroutine, string tag)
		{
			return default(float);
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0xDEC120", Offset = "0xDEC120", VA = "0xDEC120")]
		public static float WaitUntilDone(this IEnumerator<float> newCoroutine, int layer)
		{
			return default(float);
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0xDEC198", Offset = "0xDEC198", VA = "0xDEC198")]
		public static float WaitUntilDone(this IEnumerator<float> newCoroutine, int layer, string tag)
		{
			return default(float);
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0xDEC218", Offset = "0xDEC218", VA = "0xDEC218")]
		public static float WaitUntilDone(this IEnumerator<float> newCoroutine, Segment segment)
		{
			return default(float);
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0xDEC290", Offset = "0xDEC290", VA = "0xDEC290")]
		public static float WaitUntilDone(this IEnumerator<float> newCoroutine, Segment segment, string tag)
		{
			return default(float);
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0xDEC310", Offset = "0xDEC310", VA = "0xDEC310")]
		public static float WaitUntilDone(this IEnumerator<float> newCoroutine, Segment segment, int layer)
		{
			return default(float);
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0xDEC390", Offset = "0xDEC390", VA = "0xDEC390")]
		public static float WaitUntilDone(this IEnumerator<float> newCoroutine, Segment segment, int layer, string tag)
		{
			return default(float);
		}
	}
}
namespace SimpleJSON
{
	[Token(Token = "0x200000F")]
	public enum JSONBinaryTag
	{
		[Token(Token = "0x400008F")]
		Array = 1,
		[Token(Token = "0x4000090")]
		Class,
		[Token(Token = "0x4000091")]
		Value,
		[Token(Token = "0x4000092")]
		IntValue,
		[Token(Token = "0x4000093")]
		DoubleValue,
		[Token(Token = "0x4000094")]
		BoolValue,
		[Token(Token = "0x4000095")]
		FloatValue,
		[Token(Token = "0x4000096")]
		LongValue,
		[Token(Token = "0x4000097")]
		Null
	}
	[Token(Token = "0x2000010")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x864538", Offset = "0x864538")]
	public abstract class JSONNode
	{
		[Token(Token = "0x2000165")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8679E4", Offset = "0x8679E4")]
		private sealed class <get_Children>d__17 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private JSONNode <>2__current;

			[Token(Token = "0x40005FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x170002C3")]
			private JSONNode System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>.Current
			{
				[Token(Token = "0x6000CD4")]
				[Address(RVA = "0x1817C1C", Offset = "0x1817C1C", VA = "0x1817C1C", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170002C4")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000CD6")]
				[Address(RVA = "0x1817C84", Offset = "0x1817C84", VA = "0x1817C84", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000CD1")]
			[Address(RVA = "0x1817BC8", Offset = "0x1817BC8", VA = "0x1817BC8")]
			[DebuggerHidden]
			public <get_Children>d__17(int <>1__state)
			{
			}

			[Token(Token = "0x6000CD2")]
			[Address(RVA = "0x1817C00", Offset = "0x1817C00", VA = "0x1817C00", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000CD3")]
			[Address(RVA = "0x1817C04", Offset = "0x1817C04", VA = "0x1817C04", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000CD5")]
			[Address(RVA = "0x1817C24", Offset = "0x1817C24", VA = "0x1817C24", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000CD7")]
			[Address(RVA = "0x1817C8C", Offset = "0x1817C8C", VA = "0x1817C8C", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000CD8")]
			[Address(RVA = "0x1817D24", Offset = "0x1817D24", VA = "0x1817D24", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x2000166")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8679F4", Offset = "0x8679F4")]
		private sealed class <get_DeepChildren>d__19 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private JSONNode <>2__current;

			[Token(Token = "0x40005FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x40005FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public JSONNode <>4__this;

			[Token(Token = "0x4000600")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private IEnumerator<JSONNode> <>7__wrap1;

			[Token(Token = "0x4000601")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private IEnumerator<JSONNode> <>7__wrap2;

			[Token(Token = "0x170002C5")]
			private JSONNode System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>.Current
			{
				[Token(Token = "0x6000CDE")]
				[Address(RVA = "0x1818394", Offset = "0x1818394", VA = "0x1818394", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170002C6")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000CE0")]
				[Address(RVA = "0x18183FC", Offset = "0x18183FC", VA = "0x18183FC", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000CD9")]
			[Address(RVA = "0x1817D28", Offset = "0x1817D28", VA = "0x1817D28")]
			[DebuggerHidden]
			public <get_DeepChildren>d__19(int <>1__state)
			{
			}

			[Token(Token = "0x6000CDA")]
			[Address(RVA = "0x1817D60", Offset = "0x1817D60", VA = "0x1817D60", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000CDB")]
			[Address(RVA = "0x1817F70", Offset = "0x1817F70", VA = "0x1817F70", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000CDC")]
			[Address(RVA = "0x1817EB0", Offset = "0x1817EB0", VA = "0x1817EB0")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000CDD")]
			[Address(RVA = "0x1817DF0", Offset = "0x1817DF0", VA = "0x1817DF0")]
			private void <>m__Finally2()
			{
			}

			[Token(Token = "0x6000CDF")]
			[Address(RVA = "0x181839C", Offset = "0x181839C", VA = "0x181839C", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000CE1")]
			[Address(RVA = "0x1818404", Offset = "0x1818404", VA = "0x1818404", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000CE2")]
			[Address(RVA = "0x18184B0", Offset = "0x18184B0", VA = "0x18184B0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x867FC0", Offset = "0x867FC0")]
		private JSONBinaryTag <Tag>k__BackingField;

		[Token(Token = "0x17000017")]
		public virtual JSONNode Item
		{
			[Token(Token = "0x6000174")]
			[Address(RVA = "0xDE7E08", Offset = "0xDE7E08", VA = "0xDE7E08", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000175")]
			[Address(RVA = "0xDE7E10", Offset = "0xDE7E10", VA = "0xDE7E10", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x17000018")]
		public virtual JSONNode Item
		{
			[Token(Token = "0x6000176")]
			[Address(RVA = "0xDE7E14", Offset = "0xDE7E14", VA = "0xDE7E14", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000177")]
			[Address(RVA = "0xDE7E1C", Offset = "0xDE7E1C", VA = "0xDE7E1C", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x17000019")]
		public virtual string Value
		{
			[Token(Token = "0x6000178")]
			[Address(RVA = "0xDE7E20", Offset = "0xDE7E20", VA = "0xDE7E20", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000179")]
			[Address(RVA = "0xDE7E68", Offset = "0xDE7E68", VA = "0xDE7E68", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x1700001A")]
		public virtual int Count
		{
			[Token(Token = "0x600017A")]
			[Address(RVA = "0xDE7E6C", Offset = "0xDE7E6C", VA = "0xDE7E6C", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700001B")]
		public virtual IEnumerable<JSONNode> Children
		{
			[Token(Token = "0x600017F")]
			[Address(RVA = "0xDE7EF4", Offset = "0xDE7EF4", VA = "0xDE7EF4", Slot = "16")]
			[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x876700", Offset = "0x876700")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001C")]
		public IEnumerable<JSONNode> DeepChildren
		{
			[Token(Token = "0x6000180")]
			[Address(RVA = "0xDE7F54", Offset = "0xDE7F54", VA = "0xDE7F54")]
			[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x876764", Offset = "0x876764")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001D")]
		public JSONBinaryTag Tag
		{
			[Token(Token = "0x6000183")]
			[Address(RVA = "0xDE8054", Offset = "0xDE8054", VA = "0xDE8054")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8767C8", Offset = "0x8767C8")]
			get
			{
				return default(JSONBinaryTag);
			}
			[Token(Token = "0x6000184")]
			[Address(RVA = "0xDE805C", Offset = "0xDE805C", VA = "0xDE805C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8767D8", Offset = "0x8767D8")]
			set
			{
			}
		}

		[Token(Token = "0x1700001E")]
		public virtual bool IsNull
		{
			[Token(Token = "0x6000185")]
			[Address(RVA = "0xDE8064", Offset = "0xDE8064", VA = "0xDE8064", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001F")]
		public virtual int AsInt
		{
			[Token(Token = "0x6000186")]
			[Address(RVA = "0xDE8074", Offset = "0xDE8074", VA = "0xDE8074", Slot = "19")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000187")]
			[Address(RVA = "0xDE80B4", Offset = "0xDE80B4", VA = "0xDE80B4", Slot = "20")]
			set
			{
			}
		}

		[Token(Token = "0x17000020")]
		public virtual long AsLong
		{
			[Token(Token = "0x6000188")]
			[Address(RVA = "0xDE8154", Offset = "0xDE8154", VA = "0xDE8154", Slot = "21")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x6000189")]
			[Address(RVA = "0xDE8194", Offset = "0xDE8194", VA = "0xDE8194", Slot = "22")]
			set
			{
			}
		}

		[Token(Token = "0x17000021")]
		public virtual float AsFloat
		{
			[Token(Token = "0x600018A")]
			[Address(RVA = "0xDE8234", Offset = "0xDE8234", VA = "0xDE8234", Slot = "23")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600018B")]
			[Address(RVA = "0xDE82E8", Offset = "0xDE82E8", VA = "0xDE82E8", Slot = "24")]
			set
			{
			}
		}

		[Token(Token = "0x17000022")]
		public virtual double AsDouble
		{
			[Token(Token = "0x600018C")]
			[Address(RVA = "0xDE8388", Offset = "0xDE8388", VA = "0xDE8388", Slot = "25")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x600018D")]
			[Address(RVA = "0xDE8464", Offset = "0xDE8464", VA = "0xDE8464", Slot = "26")]
			set
			{
			}
		}

		[Token(Token = "0x17000023")]
		public virtual bool AsBool
		{
			[Token(Token = "0x600018E")]
			[Address(RVA = "0xDE8504", Offset = "0xDE8504", VA = "0xDE8504", Slot = "27")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600018F")]
			[Address(RVA = "0xDE85CC", Offset = "0xDE85CC", VA = "0xDE85CC", Slot = "28")]
			set
			{
			}
		}

		[Token(Token = "0x17000024")]
		public virtual JSONArray AsArray
		{
			[Token(Token = "0x6000190")]
			[Address(RVA = "0xDE8654", Offset = "0xDE8654", VA = "0xDE8654", Slot = "29")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000025")]
		public virtual JSONClass AsObject
		{
			[Token(Token = "0x6000191")]
			[Address(RVA = "0xDE86D4", Offset = "0xDE86D4", VA = "0xDE86D4", Slot = "30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0xDE7E04", Offset = "0xDE7E04", VA = "0xDE7E04", Slot = "4")]
		public virtual void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0xDE7E74", Offset = "0xDE7E74", VA = "0xDE7E74", Slot = "12")]
		public virtual void Add(JSONNode aItem)
		{
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0xDE7EDC", Offset = "0xDE7EDC", VA = "0xDE7EDC", Slot = "13")]
		public virtual JSONNode Remove(string aKey)
		{
			return null;
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0xDE7EE4", Offset = "0xDE7EE4", VA = "0xDE7EE4", Slot = "14")]
		public virtual JSONNode Remove(int aIndex)
		{
			return null;
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0xDE7EEC", Offset = "0xDE7EEC", VA = "0xDE7EEC", Slot = "15")]
		public virtual JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0xDE7FC4", Offset = "0xDE7FC4", VA = "0xDE7FC4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0xDE800C", Offset = "0xDE800C", VA = "0xDE800C", Slot = "17")]
		public virtual string ToString(string aPrefix)
		{
			return null;
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0xDE8754", Offset = "0xDE8754", VA = "0xDE8754")]
		public static implicit operator JSONNode(string s)
		{
			return null;
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0xDE87B8", Offset = "0xDE87B8", VA = "0xDE87B8")]
		public static implicit operator string(JSONNode d)
		{
			return null;
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0xDE8804", Offset = "0xDE8804", VA = "0xDE8804")]
		public static bool operator ==(JSONNode a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0xDE889C", Offset = "0xDE889C", VA = "0xDE889C")]
		public static bool operator !=(JSONNode a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0xDE88B8", Offset = "0xDE88B8", VA = "0xDE88B8", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0xDE88C4", Offset = "0xDE88C4", VA = "0xDE88C4", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0xDE88CC", Offset = "0xDE88CC", VA = "0xDE88CC")]
		internal static string Escape(string aText)
		{
			return null;
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0xDE8A9C", Offset = "0xDE8A9C", VA = "0xDE8A9C")]
		private static JSONData Numberize(string token)
		{
			return null;
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0xDE8D58", Offset = "0xDE8D58", VA = "0xDE8D58")]
		private static void AddElement(JSONNode ctx, string token, string tokenName, bool tokenIsString)
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0xDE8E9C", Offset = "0xDE8E9C", VA = "0xDE8E9C")]
		public static JSONNode Parse(string jsonString)
		{
			return null;
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0xDE966C", Offset = "0xDE966C", VA = "0xDE966C", Slot = "31")]
		public virtual void Serialize(BinaryWriter aWriter)
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0xDE9670", Offset = "0xDE9670", VA = "0xDE9670")]
		public void SaveToStream(Stream aData)
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0xDE96F0", Offset = "0xDE96F0", VA = "0xDE96F0")]
		public void SaveToCompressedStream(Stream aData)
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0xDE975C", Offset = "0xDE975C", VA = "0xDE975C")]
		public void SaveToCompressedFile(string aFileName)
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0xDE97C8", Offset = "0xDE97C8", VA = "0xDE97C8")]
		public string SaveToCompressedBase64()
		{
			return null;
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0xDE9834", Offset = "0xDE9834", VA = "0xDE9834")]
		public void SaveToFile(string aFileName)
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0xDE9988", Offset = "0xDE9988", VA = "0xDE9988")]
		public string SaveToBase64()
		{
			return null;
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0xDE9B0C", Offset = "0xDE9B0C", VA = "0xDE9B0C")]
		public static JSONNode Deserialize(BinaryReader aReader)
		{
			return null;
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0xDE9E70", Offset = "0xDE9E70", VA = "0xDE9E70")]
		public static JSONNode LoadFromCompressedFile(string aFileName)
		{
			return null;
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0xDE9EDC", Offset = "0xDE9EDC", VA = "0xDE9EDC")]
		public static JSONNode LoadFromCompressedStream(Stream aData)
		{
			return null;
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0xDE9F48", Offset = "0xDE9F48", VA = "0xDE9F48")]
		public static JSONNode LoadFromCompressedBase64(string aBase64)
		{
			return null;
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0xDE9FB4", Offset = "0xDE9FB4", VA = "0xDE9FB4")]
		public static JSONNode LoadFromStream(Stream aData)
		{
			return null;
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0xDEA0D0", Offset = "0xDEA0D0", VA = "0xDEA0D0")]
		public static JSONNode LoadFromFile(string aFileName)
		{
			return null;
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0xDEA1D8", Offset = "0xDEA1D8", VA = "0xDEA1D8")]
		public static JSONNode LoadFromBase64(string aBase64)
		{
			return null;
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0xDEA28C", Offset = "0xDEA28C", VA = "0xDEA28C")]
		protected JSONNode()
		{
		}
	}
	[Token(Token = "0x2000011")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x864570", Offset = "0x864570")]
	public class JSONArray : JSONNode, IEnumerable
	{
		[Token(Token = "0x2000167")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x867A04", Offset = "0x867A04")]
		private sealed class <get_Children>d__10 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000602")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000603")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private JSONNode <>2__current;

			[Token(Token = "0x4000604")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x4000605")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public JSONArray <>4__this;

			[Token(Token = "0x4000606")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private List<JSONNode>.Enumerator <>7__wrap1;

			[Token(Token = "0x170002C7")]
			private JSONNode System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>.Current
			{
				[Token(Token = "0x6000CE7")]
				[Address(RVA = "0x1817494", Offset = "0x1817494", VA = "0x1817494", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170002C8")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000CE9")]
				[Address(RVA = "0x18174FC", Offset = "0x18174FC", VA = "0x18174FC", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000CE3")]
			[Address(RVA = "0x1817294", Offset = "0x1817294", VA = "0x1817294")]
			[DebuggerHidden]
			public <get_Children>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x6000CE4")]
			[Address(RVA = "0x18172CC", Offset = "0x18172CC", VA = "0x18172CC", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000CE5")]
			[Address(RVA = "0x1817340", Offset = "0x1817340", VA = "0x1817340", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000CE6")]
			[Address(RVA = "0x18172E8", Offset = "0x18172E8", VA = "0x18172E8")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000CE8")]
			[Address(RVA = "0x181749C", Offset = "0x181749C", VA = "0x181749C", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000CEA")]
			[Address(RVA = "0x1817504", Offset = "0x1817504", VA = "0x1817504", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000CEB")]
			[Address(RVA = "0x18175B0", Offset = "0x18175B0", VA = "0x18175B0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x2000168")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x867A14", Offset = "0x867A14")]
		private sealed class <GetEnumerator>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000607")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000608")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000609")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public JSONArray <>4__this;

			[Token(Token = "0x400060A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private List<JSONNode>.Enumerator <>7__wrap1;

			[Token(Token = "0x170002C9")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000CF0")]
				[Address(RVA = "0x1817224", Offset = "0x1817224", VA = "0x1817224", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170002CA")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000CF2")]
				[Address(RVA = "0x181728C", Offset = "0x181728C", VA = "0x181728C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000CEC")]
			[Address(RVA = "0x1817030", Offset = "0x1817030", VA = "0x1817030")]
			[DebuggerHidden]
			public <GetEnumerator>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x6000CED")]
			[Address(RVA = "0x181705C", Offset = "0x181705C", VA = "0x181705C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000CEE")]
			[Address(RVA = "0x18170D0", Offset = "0x18170D0", VA = "0x18170D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000CEF")]
			[Address(RVA = "0x1817078", Offset = "0x1817078", VA = "0x1817078")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000CF1")]
			[Address(RVA = "0x181722C", Offset = "0x181722C", VA = "0x181722C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly List<JSONNode> _nodeList;

		[Token(Token = "0x17000026")]
		public override JSONNode Item
		{
			[Token(Token = "0x60001AB")]
			[Address(RVA = "0x145EF4C", Offset = "0x145EF4C", VA = "0x145EF4C", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001AC")]
			[Address(RVA = "0x145F020", Offset = "0x145F020", VA = "0x145F020", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x17000027")]
		public override JSONNode Item
		{
			[Token(Token = "0x60001AD")]
			[Address(RVA = "0x145F0C4", Offset = "0x145F0C4", VA = "0x145F0C4", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001AE")]
			[Address(RVA = "0x145F128", Offset = "0x145F128", VA = "0x145F128", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x17000028")]
		public override int Count
		{
			[Token(Token = "0x60001AF")]
			[Address(RVA = "0x145F190", Offset = "0x145F190", VA = "0x145F190", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000029")]
		public override IEnumerable<JSONNode> Children
		{
			[Token(Token = "0x60001B0")]
			[Address(RVA = "0x145F1E0", Offset = "0x145F1E0", VA = "0x145F1E0", Slot = "16")]
			[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8767E8", Offset = "0x8767E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x145F250", Offset = "0x145F250", VA = "0x145F250", Slot = "32")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x87684C", Offset = "0x87684C")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x145F2C0", Offset = "0x145F2C0", VA = "0x145F2C0", Slot = "4")]
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x145F328", Offset = "0x145F328", VA = "0x145F328", Slot = "14")]
		public override JSONNode Remove(int aIndex)
		{
			return null;
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x145F3D4", Offset = "0x145F3D4", VA = "0x145F3D4", Slot = "15")]
		public override JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x145F444", Offset = "0x145F444", VA = "0x145F444", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x145F5F0", Offset = "0x145F5F0", VA = "0x145F5F0", Slot = "17")]
		public override string ToString(string aPrefix)
		{
			return null;
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x145F850", Offset = "0x145F850", VA = "0x145F850", Slot = "31")]
		public override void Serialize(BinaryWriter aWriter)
		{
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x145F998", Offset = "0x145F998", VA = "0x145F998")]
		public JSONArray()
		{
		}
	}
	[Token(Token = "0x2000012")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x8645A8", Offset = "0x8645A8")]
	public class JSONClass : JSONNode, IEnumerable
	{
		[Token(Token = "0x2000169")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x867A24", Offset = "0x867A24")]
		private sealed class <get_Children>d__10 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400060B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400060C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private JSONNode <>2__current;

			[Token(Token = "0x400060D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x400060E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public JSONClass <>4__this;

			[Token(Token = "0x400060F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Dictionary<string, JSONNode>.Enumerator <>7__wrap1;

			[Token(Token = "0x170002CB")]
			private JSONNode System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>.Current
			{
				[Token(Token = "0x6000CF7")]
				[Address(RVA = "0x1817AA8", Offset = "0x1817AA8", VA = "0x1817AA8", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170002CC")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000CF9")]
				[Address(RVA = "0x1817B10", Offset = "0x1817B10", VA = "0x1817B10", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000CF3")]
			[Address(RVA = "0x18178A0", Offset = "0x18178A0", VA = "0x18178A0")]
			[DebuggerHidden]
			public <get_Children>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x6000CF4")]
			[Address(RVA = "0x18178D8", Offset = "0x18178D8", VA = "0x18178D8", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000CF5")]
			[Address(RVA = "0x181794C", Offset = "0x181794C", VA = "0x181794C", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000CF6")]
			[Address(RVA = "0x18178F4", Offset = "0x18178F4", VA = "0x18178F4")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000CF8")]
			[Address(RVA = "0x1817AB0", Offset = "0x1817AB0", VA = "0x1817AB0", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000CFA")]
			[Address(RVA = "0x1817B18", Offset = "0x1817B18", VA = "0x1817B18", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000CFB")]
			[Address(RVA = "0x1817BC4", Offset = "0x1817BC4", VA = "0x1817BC4", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x200016A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x867A34", Offset = "0x867A34")]
		private sealed class <GetEnumerator>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000610")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000611")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000612")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public JSONClass <>4__this;

			[Token(Token = "0x4000613")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Dictionary<string, JSONNode>.Enumerator <>7__wrap1;

			[Token(Token = "0x170002CD")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000D00")]
				[Address(RVA = "0x1817830", Offset = "0x1817830", VA = "0x1817830", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170002CE")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000D02")]
				[Address(RVA = "0x1817898", Offset = "0x1817898", VA = "0x1817898", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000CFC")]
			[Address(RVA = "0x1817614", Offset = "0x1817614", VA = "0x1817614")]
			[DebuggerHidden]
			public <GetEnumerator>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x6000CFD")]
			[Address(RVA = "0x1817640", Offset = "0x1817640", VA = "0x1817640", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000CFE")]
			[Address(RVA = "0x18176B4", Offset = "0x18176B4", VA = "0x18176B4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000CFF")]
			[Address(RVA = "0x181765C", Offset = "0x181765C", VA = "0x181765C")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000D01")]
			[Address(RVA = "0x1817838", Offset = "0x1817838", VA = "0x1817838", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200016B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x867A44", Offset = "0x867A44")]
		private sealed class <>c__DisplayClass15_0
		{
			[Token(Token = "0x4000614")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public JSONNode aNode;

			[Token(Token = "0x6000D03")]
			[Address(RVA = "0x18175B4", Offset = "0x18175B4", VA = "0x18175B4")]
			public <>c__DisplayClass15_0()
			{
			}

			[Token(Token = "0x6000D04")]
			[Address(RVA = "0x18175BC", Offset = "0x18175BC", VA = "0x18175BC")]
			internal bool <Remove>b__0(KeyValuePair<string, JSONNode> k)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly Dictionary<string, JSONNode> _nodeDict;

		[Token(Token = "0x1700002A")]
		public override JSONNode Item
		{
			[Token(Token = "0x60001B9")]
			[Address(RVA = "0x145FA08", Offset = "0x145FA08", VA = "0x145FA08", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001BA")]
			[Address(RVA = "0x145FAF8", Offset = "0x145FAF8", VA = "0x145FAF8", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x1700002B")]
		public override JSONNode Item
		{
			[Token(Token = "0x60001BB")]
			[Address(RVA = "0x145FBB4", Offset = "0x145FBB4", VA = "0x145FBB4", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001BC")]
			[Address(RVA = "0x145FC4C", Offset = "0x145FC4C", VA = "0x145FC4C", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x1700002C")]
		public override int Count
		{
			[Token(Token = "0x60001BD")]
			[Address(RVA = "0x145FD0C", Offset = "0x145FD0C", VA = "0x145FD0C", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700002D")]
		public override IEnumerable<JSONNode> Children
		{
			[Token(Token = "0x60001BE")]
			[Address(RVA = "0x145FD64", Offset = "0x145FD64", VA = "0x145FD64", Slot = "16")]
			[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8768B0", Offset = "0x8768B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x145FDD4", Offset = "0x145FDD4", VA = "0x145FDD4", Slot = "32")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x876914", Offset = "0x876914")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x145FE44", Offset = "0x145FE44", VA = "0x145FE44", Slot = "4")]
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x145FF70", Offset = "0x145FF70", VA = "0x145FF70", Slot = "13")]
		public override JSONNode Remove(string aKey)
		{
			return null;
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x146002C", Offset = "0x146002C", VA = "0x146002C", Slot = "14")]
		public override JSONNode Remove(int aIndex)
		{
			return null;
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x14600E8", Offset = "0x14600E8", VA = "0x14600E8", Slot = "15")]
		public override JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x146024C", Offset = "0x146024C", VA = "0x146024C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x1460478", Offset = "0x1460478", VA = "0x1460478", Slot = "17")]
		public override string ToString(string aPrefix)
		{
			return null;
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x1460740", Offset = "0x1460740", VA = "0x1460740", Slot = "31")]
		public override void Serialize(BinaryWriter aWriter)
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x14608F8", Offset = "0x14608F8", VA = "0x14608F8")]
		public JSONClass()
		{
		}
	}
	[Token(Token = "0x2000013")]
	public class JSONData : JSONNode
	{
		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string _data;

		[Token(Token = "0x1700002E")]
		public override string Value
		{
			[Token(Token = "0x60001CE")]
			[Address(RVA = "0x1460B24", Offset = "0x1460B24", VA = "0x1460B24", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001CF")]
			[Address(RVA = "0x1460B2C", Offset = "0x1460B2C", VA = "0x1460B2C", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x1460968", Offset = "0x1460968", VA = "0x1460968")]
		public JSONData(string aData)
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x14609E8", Offset = "0x14609E8", VA = "0x14609E8")]
		public JSONData(float aData)
		{
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x1460A2C", Offset = "0x1460A2C", VA = "0x1460A2C")]
		public JSONData(double aData)
		{
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x1460A70", Offset = "0x1460A70", VA = "0x1460A70")]
		public JSONData(bool aData)
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x1460AAC", Offset = "0x1460AAC", VA = "0x1460AAC")]
		public JSONData(int aData)
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x1460AE8", Offset = "0x1460AE8", VA = "0x1460AE8")]
		public JSONData(long aData)
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x1460B3C", Offset = "0x1460B3C", VA = "0x1460B3C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x1460C14", Offset = "0x1460C14", VA = "0x1460C14", Slot = "17")]
		public override string ToString(string aPrefix)
		{
			return null;
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x1460CEC", Offset = "0x1460CEC", VA = "0x1460CEC", Slot = "31")]
		public override void Serialize(BinaryWriter aWriter)
		{
		}
	}
	[Token(Token = "0x2000014")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x8645E0", Offset = "0x8645E0")]
	internal class JSONLazyCreator : JSONNode
	{
		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly string _key;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private JSONNode _node;

		[Token(Token = "0x1700002F")]
		public override JSONNode Item
		{
			[Token(Token = "0x60001D5")]
			[Address(RVA = "0x1460ECC", Offset = "0x1460ECC", VA = "0x1460ECC", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001D6")]
			[Address(RVA = "0x1460F30", Offset = "0x1460F30", VA = "0x1460F30", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x17000030")]
		public override JSONNode Item
		{
			[Token(Token = "0x60001D7")]
			[Address(RVA = "0x1461018", Offset = "0x1461018", VA = "0x1461018", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001D8")]
			[Address(RVA = "0x1461088", Offset = "0x1461088", VA = "0x1461088", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x17000031")]
		public override int AsInt
		{
			[Token(Token = "0x60001D9")]
			[Address(RVA = "0x1461118", Offset = "0x1461118", VA = "0x1461118", Slot = "19")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60001DA")]
			[Address(RVA = "0x146119C", Offset = "0x146119C", VA = "0x146119C", Slot = "20")]
			set
			{
			}
		}

		[Token(Token = "0x17000032")]
		public override long AsLong
		{
			[Token(Token = "0x60001DB")]
			[Address(RVA = "0x1461224", Offset = "0x1461224", VA = "0x1461224", Slot = "21")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x60001DC")]
			[Address(RVA = "0x14612A8", Offset = "0x14612A8", VA = "0x14612A8", Slot = "22")]
			set
			{
			}
		}

		[Token(Token = "0x17000033")]
		public override float AsFloat
		{
			[Token(Token = "0x60001DD")]
			[Address(RVA = "0x1461330", Offset = "0x1461330", VA = "0x1461330", Slot = "23")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001DE")]
			[Address(RVA = "0x14613B4", Offset = "0x14613B4", VA = "0x14613B4", Slot = "24")]
			set
			{
			}
		}

		[Token(Token = "0x17000034")]
		public override double AsDouble
		{
			[Token(Token = "0x60001DF")]
			[Address(RVA = "0x146143C", Offset = "0x146143C", VA = "0x146143C", Slot = "25")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x60001E0")]
			[Address(RVA = "0x14614C0", Offset = "0x14614C0", VA = "0x14614C0", Slot = "26")]
			set
			{
			}
		}

		[Token(Token = "0x17000035")]
		public override bool AsBool
		{
			[Token(Token = "0x60001E1")]
			[Address(RVA = "0x1461548", Offset = "0x1461548", VA = "0x1461548", Slot = "27")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001E2")]
			[Address(RVA = "0x14615CC", Offset = "0x14615CC", VA = "0x14615CC", Slot = "28")]
			set
			{
			}
		}

		[Token(Token = "0x17000036")]
		public override JSONArray AsArray
		{
			[Token(Token = "0x60001E3")]
			[Address(RVA = "0x1461654", Offset = "0x1461654", VA = "0x1461654", Slot = "29")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000037")]
		public override JSONClass AsObject
		{
			[Token(Token = "0x60001E4")]
			[Address(RVA = "0x14616BC", Offset = "0x14616BC", VA = "0x14616BC", Slot = "30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x145EFF4", Offset = "0x145EFF4", VA = "0x145EFF4")]
		public JSONLazyCreator(JSONNode aNode)
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x145FAC0", Offset = "0x145FAC0", VA = "0x145FAC0")]
		public JSONLazyCreator(JSONNode aNode, string aKey)
		{
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x1460FB8", Offset = "0x1460FB8", VA = "0x1460FB8")]
		private void Set(JSONNode aVal)
		{
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x1461724", Offset = "0x1461724", VA = "0x1461724", Slot = "12")]
		public override void Add(JSONNode aItem)
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x14617AC", Offset = "0x14617AC", VA = "0x14617AC", Slot = "4")]
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x146183C", Offset = "0x146183C", VA = "0x146183C")]
		public static bool operator ==(JSONLazyCreator a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x1461854", Offset = "0x1461854", VA = "0x1461854")]
		public static bool operator !=(JSONLazyCreator a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x146186C", Offset = "0x146186C", VA = "0x146186C", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x1461884", Offset = "0x1461884", VA = "0x1461884", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x146188C", Offset = "0x146188C", VA = "0x146188C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x14618D4", Offset = "0x14618D4", VA = "0x14618D4", Slot = "17")]
		public override string ToString(string aPrefix)
		{
			return null;
		}
	}
	[Token(Token = "0x2000015")]
	public static class JSON
	{
		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x145EF44", Offset = "0x145EF44", VA = "0x145EF44")]
		public static JSONNode Parse(string jsonString)
		{
			return null;
		}
	}
}
namespace FluffyUnderware.DevTools
{
	[Token(Token = "0x2000016")]
	public interface IDTGroupParsingAttribute
	{
		[Token(Token = "0x17000038")]
		string Path
		{
			[Token(Token = "0x60001EF")]
			get;
		}
	}
	[Token(Token = "0x2000017")]
	public interface IDTFieldParsingAttribute
	{
	}
	[Token(Token = "0x2000018")]
	public interface IDTGroupRenderAttribute
	{
	}
	[Token(Token = "0x2000019")]
	public interface IDTFieldRenderAttribute
	{
	}
	[Token(Token = "0x200001A")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x864618", Offset = "0x864618")]
	public class DTVersionAttribute : Attribute
	{
		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly string Version;

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x145A7A4", Offset = "0x145A7A4", VA = "0x145A7A4")]
		public DTVersionAttribute(string version)
		{
		}
	}
	[Token(Token = "0x200001B")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x86464C", Offset = "0x86464C")]
	public class DTAttribute : Attribute, IComparable
	{
		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x867FD0", Offset = "0x867FD0")]
		private int <TypeSort>k__BackingField;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int Sort;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool ShowBelowProperty;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int Space;

		[Token(Token = "0x17000039")]
		public int TypeSort
		{
			[Token(Token = "0x60001F1")]
			[Address(RVA = "0x14556DC", Offset = "0x14556DC", VA = "0x14556DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x876978", Offset = "0x876978")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60001F2")]
			[Address(RVA = "0x14556E4", Offset = "0x14556E4", VA = "0x14556E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x876988", Offset = "0x876988")]
			protected set
			{
			}
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x14556EC", Offset = "0x14556EC", VA = "0x14556EC", Slot = "8")]
		public virtual int CompareTo(object obj)
		{
			return default(int);
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x14557C0", Offset = "0x14557C0", VA = "0x14557C0")]
		public DTAttribute(int sortOrder, bool showBelow = false)
		{
		}
	}
	[Token(Token = "0x200001C")]
	public class GroupAttribute : DTAttribute, IDTGroupParsingAttribute, IDTGroupRenderAttribute
	{
		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x867FE0", Offset = "0x867FE0")]
		private bool <PathIsAbsolute>k__BackingField;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool Expanded;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		public bool Invisible;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string Label;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string Tooltip;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string HelpURL;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string mPath;

		[Token(Token = "0x1700003A")]
		public string Path
		{
			[Token(Token = "0x60001F5")]
			[Address(RVA = "0x145C6E8", Offset = "0x145C6E8", VA = "0x145C6E8", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001F6")]
			[Address(RVA = "0x145C6F0", Offset = "0x145C6F0", VA = "0x145C6F0")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700003B")]
		public bool PathIsAbsolute
		{
			[Token(Token = "0x60001F7")]
			[Address(RVA = "0x145C7B8", Offset = "0x145C7B8", VA = "0x145C7B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x876998", Offset = "0x876998")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001F8")]
			[Address(RVA = "0x145C7C0", Offset = "0x145C7C0", VA = "0x145C7C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8769A8", Offset = "0x8769A8")]
			private set
			{
			}
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x145C7CC", Offset = "0x145C7CC", VA = "0x145C7CC")]
		public GroupAttribute(string pathAndName)
		{
		}
	}
	[Token(Token = "0x200001D")]
	public class ActionAttribute : DTAttribute
	{
		[Token(Token = "0x200016C")]
		public enum ActionEnum
		{
			[Token(Token = "0x4000616")]
			Show,
			[Token(Token = "0x4000617")]
			Hide,
			[Token(Token = "0x4000618")]
			Enable,
			[Token(Token = "0x4000619")]
			Disable,
			[Token(Token = "0x400061A")]
			ShowInfo,
			[Token(Token = "0x400061B")]
			ShowWarning,
			[Token(Token = "0x400061C")]
			ShowError,
			[Token(Token = "0x400061D")]
			Callback
		}

		[Token(Token = "0x200016D")]
		public enum ActionPositionEnum
		{
			[Token(Token = "0x400061F")]
			Above,
			[Token(Token = "0x4000620")]
			Below
		}

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ActionEnum Action;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public ActionPositionEnum Position;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public object ActionData;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private MethodInfo mCallback;

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x139E848", Offset = "0x139E848", VA = "0x139E848")]
		protected ActionAttribute(string actionData, ActionEnum action = ActionEnum.Callback)
		{
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x139E898", Offset = "0x139E898", VA = "0x139E898")]
		public void Callback(object classInstance)
		{
		}
	}
	[Token(Token = "0x200001E")]
	public class ConditionalAttribute : ActionAttribute
	{
		[Token(Token = "0x200016E")]
		public enum OperatorEnum
		{
			[Token(Token = "0x4000622")]
			AND,
			[Token(Token = "0x4000623")]
			OR
		}

		[Token(Token = "0x200016F")]
		public class Condition
		{
			[Token(Token = "0x4000624")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string FieldName;

			[Token(Token = "0x4000625")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public FieldInfo FieldInfo;

			[Token(Token = "0x4000626")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PropertyInfo PropertyInfo;

			[Token(Token = "0x4000627")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public object CompareTo;

			[Token(Token = "0x4000628")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool CompareFalse;

			[Token(Token = "0x4000629")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public OperatorEnum Operator;

			[Token(Token = "0x400062A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public MethodInfo MethodInfo;

			[Token(Token = "0x400062B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public string MethodName;

			[Token(Token = "0x6000D05")]
			[Address(RVA = "0x1816014", Offset = "0x1816014", VA = "0x1816014")]
			public Condition()
			{
			}
		}

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Condition[] Conditions;

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x10A6F04", Offset = "0x10A6F04", VA = "0x10A6F04")]
		protected ConditionalAttribute(string fieldOrProperty, object compareTo, bool compareFalse = false)
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x10A700C", Offset = "0x10A700C", VA = "0x10A700C")]
		protected ConditionalAttribute(string fieldOrProperty, object compareTo, bool compareFalse, OperatorEnum op, string fieldOrProperty2, object compareTo2, bool compareFalse2)
		{
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x10A7190", Offset = "0x10A7190", VA = "0x10A7190")]
		protected ConditionalAttribute(string fieldOrProperty, object compareTo, bool compareFalse, OperatorEnum op, string fieldOrProperty2, object compareTo2, bool compareFalse2, string fieldOrProperty3, object compareTo3, bool compareFalse3)
		{
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x10A736C", Offset = "0x10A736C", VA = "0x10A736C")]
		protected ConditionalAttribute(string methodToQuery)
		{
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x10A745C", Offset = "0x10A745C", VA = "0x10A745C", Slot = "9")]
		public virtual bool ConditionMet(object classInstance)
		{
			return default(bool);
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x10A7528", Offset = "0x10A7528", VA = "0x10A7528")]
		private bool evaluate(Condition cond, object classInstance)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200001F")]
	public class SortOrderAttribute : DTAttribute, IDTFieldParsingAttribute
	{
		[Token(Token = "0x6000202")]
		[Address(RVA = "0xB16230", Offset = "0xB16230", VA = "0xB16230")]
		public SortOrderAttribute(int sort = 100)
		{
		}
	}
	[Token(Token = "0x2000020")]
	public class AsGroupAttribute : GroupAttribute, IDTFieldParsingAttribute, IDTFieldRenderAttribute
	{
		[Token(Token = "0x6000203")]
		[Address(RVA = "0x139EB28", Offset = "0x139EB28", VA = "0x139EB28")]
		public AsGroupAttribute([Optional] string pathAndName)
		{
		}
	}
	[Token(Token = "0x2000021")]
	public class TabAttribute : GroupAttribute
	{
		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public readonly string TabName;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public readonly string TabBarName;

		[Token(Token = "0x6000204")]
		[Address(RVA = "0xB1DA0C", Offset = "0xB1DA0C", VA = "0xB1DA0C")]
		public TabAttribute(string pathAndName)
		{
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0xB1DAA0", Offset = "0xB1DAA0", VA = "0xB1DAA0")]
		private static bool split(string pathAndName, out string path, out string tabBar, out string tabname)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000022")]
	public class SectionAttribute : GroupAttribute
	{
		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool Fixed;

		[Token(Token = "0x6000206")]
		[Address(RVA = "0xB15280", Offset = "0xB15280", VA = "0xB15280")]
		public SectionAttribute(string name, bool expanded = true, bool fix = false, int sort = 100)
		{
		}
	}
	[Token(Token = "0x2000023")]
	public class NoSectionAttribute : SectionAttribute
	{
		[Token(Token = "0x6000207")]
		[Address(RVA = "0xDF0E74", Offset = "0xDF0E74", VA = "0xDF0E74")]
		public NoSectionAttribute()
		{
		}
	}
	[Token(Token = "0x2000024")]
	public class Hide : DTAttribute, IDTFieldParsingAttribute, IDTFieldRenderAttribute
	{
		[Token(Token = "0x6000208")]
		[Address(RVA = "0x145C9CC", Offset = "0x145C9CC", VA = "0x145C9CC")]
		public Hide()
		{
		}
	}
	[Token(Token = "0x2000025")]
	public class Inline : DTAttribute, IDTFieldParsingAttribute, IDTFieldRenderAttribute
	{
		[Token(Token = "0x6000209")]
		[Address(RVA = "0x145D748", Offset = "0x145D748", VA = "0x145D748")]
		public Inline()
		{
		}
	}
	[Token(Token = "0x2000026")]
	public class ArrayExAttribute : DTAttribute, IDTFieldParsingAttribute
	{
		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool Draggable;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool ShowHeader;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		public bool ShowAdd;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x23")]
		public bool ShowDelete;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool DropTarget;

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x139EB08", Offset = "0x139EB08", VA = "0x139EB08")]
		public ArrayExAttribute()
		{
		}
	}
	[Token(Token = "0x2000027")]
	public class FieldActionAttribute : ActionAttribute, IDTFieldRenderAttribute
	{
		[Token(Token = "0x600020B")]
		[Address(RVA = "0x145B030", Offset = "0x145B030", VA = "0x145B030")]
		public FieldActionAttribute(string actionData, ActionEnum action = ActionEnum.Callback)
		{
		}
	}
	[Token(Token = "0x2000028")]
	public class GroupActionAttribute : ActionAttribute, IDTGroupRenderAttribute
	{
		[Token(Token = "0x600020C")]
		[Address(RVA = "0x145C6E0", Offset = "0x145C6E0", VA = "0x145C6E0")]
		public GroupActionAttribute(string actionData, ActionEnum action = ActionEnum.Callback)
		{
		}
	}
	[Token(Token = "0x2000029")]
	public class FieldConditionAttribute : ConditionalAttribute, IDTFieldRenderAttribute
	{
		[Token(Token = "0x600020D")]
		[Address(RVA = "0x145B038", Offset = "0x145B038", VA = "0x145B038")]
		public FieldConditionAttribute(string fieldOrProperty, object compareTo, bool compareFalse = false, ActionEnum action = ActionEnum.Show, [Optional] object actionData, ActionPositionEnum position = ActionPositionEnum.Below)
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x145B07C", Offset = "0x145B07C", VA = "0x145B07C")]
		public FieldConditionAttribute(string fieldOrProperty, object compareTo, bool compareFalse, OperatorEnum op, string fieldOrProperty2, object compareTo2, bool compareFalse2)
		{
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x145B08C", Offset = "0x145B08C", VA = "0x145B08C")]
		public FieldConditionAttribute(string fieldOrProperty, object compareTo, bool compareFalse, OperatorEnum op, string fieldOrProperty2, object compareTo2, bool compareFalse2, string fieldOrProperty3, object compareTo3, bool compareFalse3)
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x145B0B0", Offset = "0x145B0B0", VA = "0x145B0B0")]
		public FieldConditionAttribute(string methodToQuery)
		{
		}
	}
	[Token(Token = "0x200002A")]
	public class GroupConditionAttribute : ConditionalAttribute, IDTGroupRenderAttribute
	{
		[Token(Token = "0x6000211")]
		[Address(RVA = "0x145C818", Offset = "0x145C818", VA = "0x145C818")]
		public GroupConditionAttribute(string fieldOrProperty, object compareTo, bool compareFalse = false)
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x145C824", Offset = "0x145C824", VA = "0x145C824")]
		public GroupConditionAttribute(string fieldOrProperty, object compareTo, bool compareFalse, OperatorEnum op, string fieldOrProperty2, object compareTo2, bool compareFalse2)
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x145C834", Offset = "0x145C834", VA = "0x145C834")]
		public GroupConditionAttribute(string fieldOrProperty, object compareTo, bool compareFalse, OperatorEnum op, string fieldOrProperty2, object compareTo2, bool compareFalse2, string fieldOrProperty3, object compareTo3, bool compareFalse3)
		{
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x145C858", Offset = "0x145C858", VA = "0x145C858")]
		public GroupConditionAttribute(string methodToQuery)
		{
		}
	}
	[Token(Token = "0x200002B")]
	public class Couple<T1, T2>
	{
		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x867FF0", Offset = "0x867FF0")]
		private T1 <First>k__BackingField;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x868000", Offset = "0x868000")]
		private T2 <Second>k__BackingField;

		[Token(Token = "0x1700003C")]
		public T1 First
		{
			[Token(Token = "0x6000215")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8769B8", Offset = "0x8769B8")]
			get
			{
				return (T1)null;
			}
			[Token(Token = "0x6000216")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8769C8", Offset = "0x8769C8")]
			set
			{
			}
		}

		[Token(Token = "0x1700003D")]
		public T2 Second
		{
			[Token(Token = "0x6000217")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8769D8", Offset = "0x8769D8")]
			get
			{
				return (T2)null;
			}
			[Token(Token = "0x6000218")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8769E8", Offset = "0x8769E8")]
			set
			{
			}
		}

		[Token(Token = "0x6000219")]
		public Couple(T1 first, T2 second)
		{
		}
	}
	[Token(Token = "0x200002C")]
	public static class DTTween
	{
		[Token(Token = "0x2000170")]
		public enum EasingMethod
		{
			[Token(Token = "0x400062D")]
			Linear,
			[Token(Token = "0x400062E")]
			ExponentialIn,
			[Token(Token = "0x400062F")]
			ExponentialOut,
			[Token(Token = "0x4000630")]
			ExponentialInOut,
			[Token(Token = "0x4000631")]
			ExponentialOutIn,
			[Token(Token = "0x4000632")]
			CircularIn,
			[Token(Token = "0x4000633")]
			CircularOut,
			[Token(Token = "0x4000634")]
			CircularInOut,
			[Token(Token = "0x4000635")]
			CircularOutIn,
			[Token(Token = "0x4000636")]
			QuadraticIn,
			[Token(Token = "0x4000637")]
			QuadraticOut,
			[Token(Token = "0x4000638")]
			QuadraticInOut,
			[Token(Token = "0x4000639")]
			QuadraticOutIn,
			[Token(Token = "0x400063A")]
			SinusIn,
			[Token(Token = "0x400063B")]
			SinusOut,
			[Token(Token = "0x400063C")]
			SinusInOut,
			[Token(Token = "0x400063D")]
			SinusOutIn,
			[Token(Token = "0x400063E")]
			CubicIn,
			[Token(Token = "0x400063F")]
			CubicOut,
			[Token(Token = "0x4000640")]
			CubicInOut,
			[Token(Token = "0x4000641")]
			CubicOutIn,
			[Token(Token = "0x4000642")]
			QuarticIn,
			[Token(Token = "0x4000643")]
			QuarticOut,
			[Token(Token = "0x4000644")]
			QuarticInOut,
			[Token(Token = "0x4000645")]
			QuarticOutIn,
			[Token(Token = "0x4000646")]
			QuinticIn,
			[Token(Token = "0x4000647")]
			QuinticOut,
			[Token(Token = "0x4000648")]
			QuinticInOut,
			[Token(Token = "0x4000649")]
			QuinticOutIn
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x1457C10", Offset = "0x1457C10", VA = "0x1457C10")]
		public static float Ease(EasingMethod method, float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x145928C", Offset = "0x145928C", VA = "0x145928C")]
		public static float Ease(EasingMethod method, float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x1459200", Offset = "0x1459200", VA = "0x1459200")]
		public static float Linear(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x145A138", Offset = "0x145A138", VA = "0x145A138")]
		public static float Linear(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x1457D6C", Offset = "0x1457D6C", VA = "0x1457D6C")]
		public static float ExpoOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x14595C8", Offset = "0x14595C8", VA = "0x14595C8")]
		public static float ExpoOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x1457CA4", Offset = "0x1457CA4", VA = "0x1457CA4")]
		public static float ExpoIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x1459520", Offset = "0x1459520", VA = "0x1459520")]
		public static float ExpoIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x1457E30", Offset = "0x1457E30", VA = "0x1457E30")]
		public static float ExpoInOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x145966C", Offset = "0x145966C", VA = "0x145966C")]
		public static float ExpoInOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x1457F5C", Offset = "0x1457F5C", VA = "0x1457F5C")]
		public static float ExpoOutIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x1459780", Offset = "0x1459780", VA = "0x1459780")]
		public static float ExpoOutIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x14580D0", Offset = "0x14580D0", VA = "0x14580D0")]
		public static float CircOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x145985C", Offset = "0x145985C", VA = "0x145985C")]
		public static float CircOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x145801C", Offset = "0x145801C", VA = "0x145801C")]
		public static float CircIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x14597AC", Offset = "0x14597AC", VA = "0x14597AC")]
		public static float CircIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x1458184", Offset = "0x1458184", VA = "0x1458184")]
		public static float CircInOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x145990C", Offset = "0x145990C", VA = "0x145990C")]
		public static float CircInOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x145829C", Offset = "0x145829C", VA = "0x145829C")]
		public static float CircOutIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x1459A08", Offset = "0x1459A08", VA = "0x1459A08")]
		public static float CircOutIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x14583EC", Offset = "0x14583EC", VA = "0x14583EC")]
		public static float QuadOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x1459A48", Offset = "0x1459A48", VA = "0x1459A48")]
		public static float QuadOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x145835C", Offset = "0x145835C", VA = "0x145835C")]
		public static float QuadIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x1459A34", Offset = "0x1459A34", VA = "0x1459A34")]
		public static float QuadIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x1458484", Offset = "0x1458484", VA = "0x1458484")]
		public static float QuadInOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x1459A64", Offset = "0x1459A64", VA = "0x1459A64")]
		public static float QuadInOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x145859C", Offset = "0x145859C", VA = "0x145859C")]
		public static float QuadOutIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x1459B60", Offset = "0x1459B60", VA = "0x1459B60")]
		public static float QuadOutIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x14586FC", Offset = "0x14586FC", VA = "0x14586FC")]
		public static float SineOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x1459C50", Offset = "0x1459C50", VA = "0x1459C50")]
		public static float SineOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x145865C", Offset = "0x145865C", VA = "0x145865C")]
		public static float SineIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x1459BB4", Offset = "0x1459BB4", VA = "0x1459BB4")]
		public static float SineIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x1458798", Offset = "0x1458798", VA = "0x1458798")]
		public static float SineInOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x1459CE8", Offset = "0x1459CE8", VA = "0x1459CE8")]
		public static float SineInOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x14588B4", Offset = "0x14588B4", VA = "0x14588B4")]
		public static float SineOutIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x1459DEC", Offset = "0x1459DEC", VA = "0x1459DEC")]
		public static float SineOutIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x1458A08", Offset = "0x1458A08", VA = "0x1458A08")]
		public static float CubicOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x1459E30", Offset = "0x1459E30", VA = "0x1459E30")]
		public static float CubicOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x1458974", Offset = "0x1458974", VA = "0x1458974")]
		public static float CubicIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x1459E18", Offset = "0x1459E18", VA = "0x1459E18")]
		public static float CubicIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x1458AAC", Offset = "0x1458AAC", VA = "0x1458AAC")]
		public static float CubicInOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x1459E58", Offset = "0x1459E58", VA = "0x1459E58")]
		public static float CubicInOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x1458B80", Offset = "0x1458B80", VA = "0x1458B80")]
		public static float CubicOutIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x1459EAC", Offset = "0x1459EAC", VA = "0x1459EAC")]
		public static float CubicOutIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x1458CD8", Offset = "0x1458CD8", VA = "0x1458CD8")]
		public static float QuartOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x1459F28", Offset = "0x1459F28", VA = "0x1459F28")]
		public static float QuartOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x1458C40", Offset = "0x1458C40", VA = "0x1458C40")]
		public static float QuartIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x1459F0C", Offset = "0x1459F0C", VA = "0x1459F0C")]
		public static float QuartIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x1458D7C", Offset = "0x1458D7C", VA = "0x1458D7C")]
		public static float QuartInOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x1459F50", Offset = "0x1459F50", VA = "0x1459F50")]
		public static float QuartInOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x1458E54", Offset = "0x1458E54", VA = "0x1458E54")]
		public static float QuartOutIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x1459FAC", Offset = "0x1459FAC", VA = "0x1459FAC")]
		public static float QuartOutIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x1458FB0", Offset = "0x1458FB0", VA = "0x1458FB0")]
		public static float QuintOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x145A034", Offset = "0x145A034", VA = "0x145A034")]
		public static float QuintOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x1458F14", Offset = "0x1458F14", VA = "0x1458F14")]
		public static float QuintIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x145A014", Offset = "0x145A014", VA = "0x145A014")]
		public static float QuintIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x145905C", Offset = "0x145905C", VA = "0x145905C")]
		public static float QuintInOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x145A064", Offset = "0x145A064", VA = "0x145A064")]
		public static float QuintInOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x1459140", Offset = "0x1459140", VA = "0x1459140")]
		public static float QuintOutIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x145A0C8", Offset = "0x145A0C8", VA = "0x145A0C8")]
		public static float QuintOutIn(float t, float b, float c, float d)
		{
			return default(float);
		}
	}
	[Token(Token = "0x200002D")]
	public class DTObjectDump
	{
		[Token(Token = "0x40000B9")]
		private const int INDENTSPACES = 5;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string mIndent;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private StringBuilder mSB;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private object mObject;

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x1456D98", Offset = "0x1456D98", VA = "0x1456D98")]
		public DTObjectDump(object o, int indent = 0)
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x14579EC", Offset = "0x14579EC", VA = "0x14579EC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x1456F3C", Offset = "0x1456F3C", VA = "0x1456F3C")]
		private void AppendHeader(string name)
		{
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x1456FC4", Offset = "0x1456FC4", VA = "0x1456FC4")]
		private void AppendMember(MemberInfo info)
		{
		}
	}
	[Token(Token = "0x200002E")]
	public static class DTUtility
	{
		[Token(Token = "0x40000BD")]
		public const string HelpUrlBase = "https://curvyeditor.com/doclink/";

		[Token(Token = "0x1700003E")]
		public static bool IsEditorStateChange
		{
			[Token(Token = "0x600025B")]
			[Address(RVA = "0x145A150", Offset = "0x145A150", VA = "0x145A150")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x145A148", Offset = "0x145A148", VA = "0x145A148")]
		public static Material GetDefaultMaterial()
		{
			return null;
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x145A158", Offset = "0x145A158", VA = "0x145A158")]
		public static float GetHandleSize(Vector3 position)
		{
			return default(float);
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x145A2C8", Offset = "0x145A2C8", VA = "0x145A2C8")]
		public static float GetHandleSize(Vector3 position, Camera camera, Vector3 cameraPosition, Vector3 cameraZDirection, Transform cameraTransform)
		{
			return default(float);
		}

		[Token(Token = "0x600025E")]
		public static void SetPlayerPrefs<T>(string key, T value)
		{
		}

		[Token(Token = "0x600025F")]
		public static T GetPlayerPrefs<T>(string key, T defaultValue)
		{
			return (T)null;
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x145A49C", Offset = "0x145A49C", VA = "0x145A49C")]
		public static float RandomSign()
		{
			return default(float);
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x145A4C8", Offset = "0x145A4C8", VA = "0x145A4C8")]
		public static string GetHelpUrl(object forClass)
		{
			return null;
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x145A538", Offset = "0x145A538", VA = "0x145A538")]
		public static string GetHelpUrl(Type classType)
		{
			return null;
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x145A660", Offset = "0x145A660", VA = "0x145A660")]
		public static Vector3 GetCenterPosition(Vector3 fallback, params Vector3[] vectors)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000264")]
		public static T CreateGameObject<T>(Transform parent, string name) where T : MonoBehaviour
		{
			return null;
		}
	}
	[Token(Token = "0x200002F")]
	public static class DTTime
	{
		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static float _EditorDeltaTime;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static float _EditorLastTime;

		[Token(Token = "0x1700003F")]
		public static double TimeSinceStartup
		{
			[Token(Token = "0x6000265")]
			[Address(RVA = "0x1457AB8", Offset = "0x1457AB8", VA = "0x1457AB8")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000040")]
		public static float deltaTime
		{
			[Token(Token = "0x6000266")]
			[Address(RVA = "0x1457AD4", Offset = "0x1457AD4", VA = "0x1457AD4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x1457B40", Offset = "0x1457B40", VA = "0x1457B40")]
		public static void InitializeEditorTime()
		{
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x1457BA4", Offset = "0x1457BA4", VA = "0x1457BA4")]
		public static void UpdateEditorTime()
		{
		}
	}
	[Token(Token = "0x2000030")]
	public class TimeMeasure : Ring<long>
	{
		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Stopwatch mWatch;

		[Token(Token = "0x17000041")]
		public double LastTicks
		{
			[Token(Token = "0x600026D")]
			[Address(RVA = "0xB221AC", Offset = "0xB221AC", VA = "0xB221AC")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000042")]
		public double LastMS
		{
			[Token(Token = "0x600026E")]
			[Address(RVA = "0xB2221C", Offset = "0xB2221C", VA = "0xB2221C")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000043")]
		public double AverageMS
		{
			[Token(Token = "0x600026F")]
			[Address(RVA = "0xB2223C", Offset = "0xB2223C", VA = "0xB2223C")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000044")]
		public double MinimumMS
		{
			[Token(Token = "0x6000270")]
			[Address(RVA = "0xB2231C", Offset = "0xB2231C", VA = "0xB2231C")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000045")]
		public double MaximumMS
		{
			[Token(Token = "0x6000271")]
			[Address(RVA = "0xB22424", Offset = "0xB22424", VA = "0xB22424")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000046")]
		public double AverageTicks
		{
			[Token(Token = "0x6000272")]
			[Address(RVA = "0xB2252C", Offset = "0xB2252C", VA = "0xB2252C")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000047")]
		public double MinimumTicks
		{
			[Token(Token = "0x6000273")]
			[Address(RVA = "0xB225FC", Offset = "0xB225FC", VA = "0xB225FC")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000048")]
		public double MaximumTicks
		{
			[Token(Token = "0x6000274")]
			[Address(RVA = "0xB226F4", Offset = "0xB226F4", VA = "0xB226F4")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0xB2206C", Offset = "0xB2206C", VA = "0xB2206C")]
		public TimeMeasure(int size)
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0xB220EC", Offset = "0xB220EC", VA = "0xB220EC")]
		public void Start()
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0xB22108", Offset = "0xB22108", VA = "0xB22108")]
		public void Stop()
		{
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0xB22190", Offset = "0xB22190", VA = "0xB22190")]
		public void Pause()
		{
		}
	}
	[Token(Token = "0x2000031")]
	public static class DTMath
	{
		[Token(Token = "0x6000275")]
		[Address(RVA = "0x1455DA0", Offset = "0x1455DA0", VA = "0x1455DA0")]
		public static Vector3 ParallelTransportFrame(Vector3 up, Vector3 tan0, Vector3 tan1)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x1455F8C", Offset = "0x1455F8C", VA = "0x1455F8C")]
		public static Vector3 LeftTan(ref Vector3 tan, ref Vector3 up)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x145603C", Offset = "0x145603C", VA = "0x145603C")]
		public static Vector3 RightTan(ref Vector3 tan, ref Vector3 up)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x14560EC", Offset = "0x14560EC", VA = "0x14560EC")]
		public static float Repeat(float t, float length)
		{
			return default(float);
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x1456174", Offset = "0x1456174", VA = "0x1456174")]
		public static double FixNaN(double v)
		{
			return default(double);
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x14561F4", Offset = "0x14561F4", VA = "0x14561F4")]
		public static float FixNaN(float v)
		{
			return default(float);
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x1456224", Offset = "0x1456224", VA = "0x1456224")]
		public static Vector2 FixNaN(Vector2 v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x1456278", Offset = "0x1456278", VA = "0x1456278")]
		public static Vector3 FixNaN(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x1454E40", Offset = "0x1454E40", VA = "0x1454E40")]
		public static float MapValue(float min, float max, float value, float vMin = -1f, float vMax = 1f)
		{
			return default(float);
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x14562E8", Offset = "0x14562E8", VA = "0x14562E8")]
		public static float SnapPrecision(float value, int decimals)
		{
			return default(float);
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x1456370", Offset = "0x1456370", VA = "0x1456370")]
		public static Vector2 SnapPrecision(Vector2 value, int decimals)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x14563C4", Offset = "0x14563C4", VA = "0x14563C4")]
		public static Vector3 SnapPrecision(Vector3 value, int decimals)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x1450EB8", Offset = "0x1450EB8", VA = "0x1450EB8")]
		public static float LinePointDistanceSqr(Vector3 l1, Vector3 l2, Vector3 p, out float frag)
		{
			return default(float);
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x1456438", Offset = "0x1456438", VA = "0x1456438")]
		public static bool RayLineSegmentIntersection(Vector2 r0, Vector2 dir, Vector2 l1, Vector2 l2, out Vector2 hit, out float frag)
		{
			return default(bool);
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x1456580", Offset = "0x1456580", VA = "0x1456580")]
		public static bool ShortestIntersectionLine(Vector3 line1A, Vector3 line1B, Vector3 line2A, Vector3 line2B, out Vector3 resultSegmentA, out Vector3 resultSegmentB)
		{
			return default(bool);
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x14568E0", Offset = "0x14568E0", VA = "0x14568E0")]
		public static bool LineLineIntersection(Vector3 line1A, Vector3 line1B, Vector3 line2A, Vector3 line2B, out Vector3 hitPoint)
		{
			return default(bool);
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x1456A4C", Offset = "0x1456A4C", VA = "0x1456A4C")]
		public static bool LineLineIntersect(Vector2 line1A, Vector2 line1B, Vector2 line2A, Vector2 line2B, out Vector2 hitPoint, bool segmentOnly = true)
		{
			return default(bool);
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x1456BC0", Offset = "0x1456BC0", VA = "0x1456BC0")]
		public static bool PointInsideTriangle(Vector3 A, Vector3 B, Vector3 C, Vector3 p, out float ac, out float ab, bool edgesAllowed)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000032")]
	public class UnityEventEx<T0> : UnityEvent<T0>
	{
		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private object mCallerList;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private MethodInfo mCallsCount;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int mCount;

		[Token(Token = "0x6000287")]
		public void AddListenerOnce(UnityAction<T0> call)
		{
		}

		[Token(Token = "0x6000288")]
		public bool HasListeners()
		{
			return default(bool);
		}

		[Token(Token = "0x6000289")]
		public void CheckForListeners()
		{
		}

		[Token(Token = "0x600028A")]
		public UnityEventEx()
		{
		}
	}
	[Token(Token = "0x2000033")]
	public static class DTLog
	{
		[Token(Token = "0x600028B")]
		[Address(RVA = "0x1455808", Offset = "0x1455808", VA = "0x1455808")]
		public static void Log(object message)
		{
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x1455870", Offset = "0x1455870", VA = "0x1455870")]
		public static void Log(object message, UnityEngine.Object context)
		{
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x144F51C", Offset = "0x144F51C", VA = "0x144F51C")]
		public static void LogError(object message)
		{
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x14558E8", Offset = "0x14558E8", VA = "0x14558E8")]
		public static void LogError(object message, UnityEngine.Object context)
		{
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x1455960", Offset = "0x1455960", VA = "0x1455960")]
		public static void LogErrorFormat(string format, params object[] args)
		{
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x14559D8", Offset = "0x14559D8", VA = "0x14559D8")]
		public static void LogErrorFormat(UnityEngine.Object context, string format, params object[] args)
		{
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x1455A58", Offset = "0x1455A58", VA = "0x1455A58")]
		public static void LogException(Exception exception)
		{
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x1455AC0", Offset = "0x1455AC0", VA = "0x1455AC0")]
		public static void LogException(Exception exception, UnityEngine.Object context)
		{
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x1455B38", Offset = "0x1455B38", VA = "0x1455B38")]
		public static void LogFormat(string format, params object[] args)
		{
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x1455BB0", Offset = "0x1455BB0", VA = "0x1455BB0")]
		public static void LogFormat(UnityEngine.Object context, string format, params object[] args)
		{
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x14524A0", Offset = "0x14524A0", VA = "0x14524A0")]
		public static void LogWarning(object message)
		{
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x1455C30", Offset = "0x1455C30", VA = "0x1455C30")]
		public static void LogWarning(object message, UnityEngine.Object context)
		{
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x1455CA8", Offset = "0x1455CA8", VA = "0x1455CA8")]
		public static void LogWarningFormat(string format, params object[] args)
		{
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x1455D20", Offset = "0x1455D20", VA = "0x1455D20")]
		public static void LogWarningFormat(UnityEngine.Object context, string format, params object[] args)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000034")]
	public struct FloatRegion : IEquatable<FloatRegion>
	{
		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float From;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float To;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public bool SimpleValue;

		[Token(Token = "0x17000049")]
		public static FloatRegion ZeroOne
		{
			[Token(Token = "0x600029B")]
			[Address(RVA = "0x145B0D4", Offset = "0x145B0D4", VA = "0x145B0D4")]
			get
			{
				return default(FloatRegion);
			}
		}

		[Token(Token = "0x1700004A")]
		public bool Positive
		{
			[Token(Token = "0x600029E")]
			[Address(RVA = "0x9D4D70", Offset = "0x9D4D70", VA = "0x9D4D70")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004B")]
		public float Low
		{
			[Token(Token = "0x600029F")]
			[Address(RVA = "0x9D4D80", Offset = "0x9D4D80", VA = "0x9D4D80")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60002A0")]
			[Address(RVA = "0x9D4D90", Offset = "0x9D4D90", VA = "0x9D4D90")]
			set
			{
			}
		}

		[Token(Token = "0x1700004C")]
		public float High
		{
			[Token(Token = "0x60002A1")]
			[Address(RVA = "0x9D4DAC", Offset = "0x9D4DAC", VA = "0x9D4DAC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60002A2")]
			[Address(RVA = "0x9D4DBC", Offset = "0x9D4DBC", VA = "0x9D4DBC")]
			set
			{
			}
		}

		[Token(Token = "0x1700004D")]
		public float Random
		{
			[Token(Token = "0x60002A3")]
			[Address(RVA = "0x9D4DD8", Offset = "0x9D4DD8", VA = "0x9D4DD8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700004E")]
		public float Next
		{
			[Token(Token = "0x60002A4")]
			[Address(RVA = "0x9D4DE4", Offset = "0x9D4DE4", VA = "0x9D4DE4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700004F")]
		public float Length
		{
			[Token(Token = "0x60002A5")]
			[Address(RVA = "0x9D4E00", Offset = "0x9D4E00", VA = "0x9D4E00")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000050")]
		public float LengthPositive
		{
			[Token(Token = "0x60002A6")]
			[Address(RVA = "0x9D4E0C", Offset = "0x9D4E0C", VA = "0x9D4E0C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x9D4D38", Offset = "0x9D4D38", VA = "0x9D4D38")]
		public FloatRegion(float value)
		{
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x9D4D48", Offset = "0x9D4D48", VA = "0x9D4D48")]
		public FloatRegion(float A, float B)
		{
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x9D4D54", Offset = "0x9D4D54", VA = "0x9D4D54")]
		public void MakePositive()
		{
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x9D4D68", Offset = "0x9D4D68", VA = "0x9D4D68")]
		public void Clamp(float low, float high)
		{
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x9D4E24", Offset = "0x9D4E24", VA = "0x9D4E24", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x9D4E2C", Offset = "0x9D4E2C", VA = "0x9D4E2C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x9D4E68", Offset = "0x9D4E68", VA = "0x9D4E68", Slot = "4")]
		public bool Equals(FloatRegion other)
		{
			return default(bool);
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x9D4E74", Offset = "0x9D4E74", VA = "0x9D4E74", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x145B44C", Offset = "0x145B44C", VA = "0x145B44C")]
		public static FloatRegion operator +(FloatRegion a, FloatRegion b)
		{
			return default(FloatRegion);
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x145B480", Offset = "0x145B480", VA = "0x145B480")]
		public static FloatRegion operator -(FloatRegion a, FloatRegion b)
		{
			return default(FloatRegion);
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x145B4B4", Offset = "0x145B4B4", VA = "0x145B4B4")]
		public static FloatRegion operator -(FloatRegion a)
		{
			return default(FloatRegion);
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x145B4CC", Offset = "0x145B4CC", VA = "0x145B4CC")]
		public static FloatRegion operator *(FloatRegion a, float v)
		{
			return default(FloatRegion);
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x145B4F4", Offset = "0x145B4F4", VA = "0x145B4F4")]
		public static FloatRegion operator *(float v, FloatRegion a)
		{
			return default(FloatRegion);
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x145B51C", Offset = "0x145B51C", VA = "0x145B51C")]
		public static FloatRegion operator /(FloatRegion a, float v)
		{
			return default(FloatRegion);
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x145B544", Offset = "0x145B544", VA = "0x145B544")]
		public static bool operator ==(FloatRegion lhs, FloatRegion rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x145B64C", Offset = "0x145B64C", VA = "0x145B64C")]
		public static bool operator !=(FloatRegion lhs, FloatRegion rhs)
		{
			return default(bool);
		}
	}
	[Serializable]
	[Token(Token = "0x2000035")]
	public struct IntRegion : IEquatable<IntRegion>
	{
		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int From;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int To;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public bool SimpleValue;

		[Token(Token = "0x17000051")]
		public static IntRegion ZeroOne
		{
			[Token(Token = "0x60002B5")]
			[Address(RVA = "0x145EAF4", Offset = "0x145EAF4", VA = "0x145EAF4")]
			get
			{
				return default(IntRegion);
			}
		}

		[Token(Token = "0x17000052")]
		public bool Positive
		{
			[Token(Token = "0x60002B8")]
			[Address(RVA = "0x9D4EF8", Offset = "0x9D4EF8", VA = "0x9D4EF8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000053")]
		public int Low
		{
			[Token(Token = "0x60002B9")]
			[Address(RVA = "0x9D4F08", Offset = "0x9D4F08", VA = "0x9D4F08")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002BA")]
			[Address(RVA = "0x9D4F18", Offset = "0x9D4F18", VA = "0x9D4F18")]
			set
			{
			}
		}

		[Token(Token = "0x17000054")]
		public int High
		{
			[Token(Token = "0x60002BB")]
			[Address(RVA = "0x9D4F34", Offset = "0x9D4F34", VA = "0x9D4F34")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002BC")]
			[Address(RVA = "0x9D4F44", Offset = "0x9D4F44", VA = "0x9D4F44")]
			set
			{
			}
		}

		[Token(Token = "0x17000055")]
		public int Random
		{
			[Token(Token = "0x60002BD")]
			[Address(RVA = "0x9D4F60", Offset = "0x9D4F60", VA = "0x9D4F60")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000056")]
		public int Length
		{
			[Token(Token = "0x60002BE")]
			[Address(RVA = "0x9D4F70", Offset = "0x9D4F70", VA = "0x9D4F70")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000057")]
		public int LengthPositive
		{
			[Token(Token = "0x60002BF")]
			[Address(RVA = "0x9D4F7C", Offset = "0x9D4F7C", VA = "0x9D4F7C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x9D4EC0", Offset = "0x9D4EC0", VA = "0x9D4EC0")]
		public IntRegion(int value)
		{
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x9D4ED0", Offset = "0x9D4ED0", VA = "0x9D4ED0")]
		public IntRegion(int A, int B)
		{
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x9D4EDC", Offset = "0x9D4EDC", VA = "0x9D4EDC")]
		public void MakePositive()
		{
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x9D4EF0", Offset = "0x9D4EF0", VA = "0x9D4EF0")]
		public void Clamp(int low, int high)
		{
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x9D4F90", Offset = "0x9D4F90", VA = "0x9D4F90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x9D4F98", Offset = "0x9D4F98", VA = "0x9D4F98", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x9D4FD4", Offset = "0x9D4FD4", VA = "0x9D4FD4", Slot = "4")]
		public bool Equals(IntRegion other)
		{
			return default(bool);
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x9D4FE0", Offset = "0x9D4FE0", VA = "0x9D4FE0", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x145EE34", Offset = "0x145EE34", VA = "0x145EE34")]
		public static IntRegion operator +(IntRegion a, IntRegion b)
		{
			return default(IntRegion);
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x145EE50", Offset = "0x145EE50", VA = "0x145EE50")]
		public static IntRegion operator -(IntRegion a, IntRegion b)
		{
			return default(IntRegion);
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x145EE6C", Offset = "0x145EE6C", VA = "0x145EE6C")]
		public static IntRegion operator -(IntRegion a)
		{
			return default(IntRegion);
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x145EE84", Offset = "0x145EE84", VA = "0x145EE84")]
		public static IntRegion operator *(IntRegion a, int v)
		{
			return default(IntRegion);
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x145EE9C", Offset = "0x145EE9C", VA = "0x145EE9C")]
		public static IntRegion operator *(int v, IntRegion a)
		{
			return default(IntRegion);
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x145EEB8", Offset = "0x145EEB8", VA = "0x145EEB8")]
		public static IntRegion operator /(IntRegion a, int v)
		{
			return default(IntRegion);
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x145EED0", Offset = "0x145EED0", VA = "0x145EED0")]
		public static bool operator ==(IntRegion lhs, IntRegion rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x145EF08", Offset = "0x145EF08", VA = "0x145EF08")]
		public static bool operator !=(IntRegion lhs, IntRegion rhs)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000036")]
	public class WeightedRandom<T>
	{
		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private List<T> mData;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int mCurrentPosition;

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T mCurrentItem;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x868010", Offset = "0x868010")]
		private int <Seed>k__BackingField;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x868020", Offset = "0x868020")]
		private bool <RandomizeSeed>k__BackingField;

		[Token(Token = "0x17000058")]
		public int Seed
		{
			[Token(Token = "0x60002CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8769F8", Offset = "0x8769F8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002CD")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x876A08", Offset = "0x876A08")]
			set
			{
			}
		}

		[Token(Token = "0x17000059")]
		public bool RandomizeSeed
		{
			[Token(Token = "0x60002CE")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x876A18", Offset = "0x876A18")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002CF")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x876A28", Offset = "0x876A28")]
			set
			{
			}
		}

		[Token(Token = "0x1700005A")]
		private int Capacity
		{
			[Token(Token = "0x60002D0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700005B")]
		public int Size
		{
			[Token(Token = "0x60002D1")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60002D2")]
		public WeightedRandom(int initCapacity = 0)
		{
		}

		[Token(Token = "0x60002D3")]
		public WeightedRandom(int initCapacity, int seed)
		{
		}

		[Token(Token = "0x60002D4")]
		public void Add(T item, int amount)
		{
		}

		[Token(Token = "0x60002D5")]
		public T Next()
		{
			return (T)null;
		}

		[Token(Token = "0x60002D6")]
		public void Reset()
		{
		}

		[Token(Token = "0x60002D7")]
		public void Clear()
		{
		}
	}
	[Token(Token = "0x2000037")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x864684", Offset = "0x864684")]
	public class Ring<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable
	{
		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private List<T> mList;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x868030", Offset = "0x868030")]
		private int <Size>k__BackingField;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int mIndex;

		[Token(Token = "0x1700005C")]
		public int Size
		{
			[Token(Token = "0x60002D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x876A38", Offset = "0x876A38")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002D9")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x876A48", Offset = "0x876A48")]
			private set
			{
			}
		}

		[Token(Token = "0x1700005D")]
		public T Item
		{
			[Token(Token = "0x60002E0")]
			get
			{
				return (T)null;
			}
			[Token(Token = "0x60002E1")]
			set
			{
			}
		}

		[Token(Token = "0x1700005E")]
		public int Count
		{
			[Token(Token = "0x60002E5")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700005F")]
		public bool IsReadOnly
		{
			[Token(Token = "0x60002E6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60002DA")]
		public Ring(int size)
		{
		}

		[Token(Token = "0x60002DB")]
		public void Add(T item)
		{
		}

		[Token(Token = "0x60002DC")]
		public void Clear()
		{
		}

		[Token(Token = "0x60002DD")]
		public int IndexOf(T item)
		{
			return default(int);
		}

		[Token(Token = "0x60002DE")]
		public void Insert(int index, T item)
		{
		}

		[Token(Token = "0x60002DF")]
		public void RemoveAt(int index)
		{
		}

		[Token(Token = "0x60002E2")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60002E3")]
		public bool Contains(T item)
		{
			return default(bool);
		}

		[Token(Token = "0x60002E4")]
		public void CopyTo(T[] array, int arrayIndex)
		{
		}

		[Token(Token = "0x60002E7")]
		public bool Remove(T item)
		{
			return default(bool);
		}

		[Token(Token = "0x60002E8")]
		private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}
	[Token(Token = "0x2000038")]
	public class Pool<T> : IPool
	{
		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private List<T> mObjects;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x868040", Offset = "0x868040")]
		private string <Identifier>k__BackingField;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x868050", Offset = "0x868050")]
		private PoolSettings <Settings>k__BackingField;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private double mLastTime;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private double mDeltaTime;

		[Token(Token = "0x17000060")]
		public string Identifier
		{
			[Token(Token = "0x60002E9")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x876A58", Offset = "0x876A58")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002EA")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x876A68", Offset = "0x876A68")]
			set
			{
			}
		}

		[Token(Token = "0x17000061")]
		public PoolSettings Settings
		{
			[Token(Token = "0x60002EB")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x876A78", Offset = "0x876A78")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x876A88", Offset = "0x876A88")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000062")]
		public Type Type
		{
			[Token(Token = "0x60002ED")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000063")]
		public int Count
		{
			[Token(Token = "0x60002F2")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60002EE")]
		public Pool([Optional] PoolSettings settings)
		{
		}

		[Token(Token = "0x60002EF")]
		public void Update()
		{
		}

		[Token(Token = "0x60002F0")]
		public void Reset()
		{
		}

		[Token(Token = "0x60002F1")]
		public void Clear()
		{
		}

		[Token(Token = "0x60002F3")]
		public virtual T Pop([Optional] Transform parent)
		{
			return (T)null;
		}

		[Token(Token = "0x60002F4")]
		public virtual void Push(T item)
		{
		}

		[Token(Token = "0x60002F5")]
		protected virtual void sendBeforePush(T item)
		{
		}

		[Token(Token = "0x60002F6")]
		protected virtual void sendAfterPop(T item)
		{
		}

		[Token(Token = "0x60002F7")]
		protected virtual void setParent(T item, Transform parent)
		{
		}

		[Token(Token = "0x60002F8")]
		protected virtual T create()
		{
			return (T)null;
		}

		[Token(Token = "0x60002F9")]
		protected virtual void destroy(T item)
		{
		}

		[Token(Token = "0x60002FA")]
		private void log(string msg)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000039")]
	public class PoolSettings
	{
		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private bool m_Prewarm;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		[SerializeField]
		private bool m_AutoCreate;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		[SerializeField]
		private bool m_AutoEnableDisable;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[Positive]
		[SerializeField]
		private int m_MinItems;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Positive]
		[SerializeField]
		private int m_Threshold;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Positive]
		[SerializeField]
		private float m_Speed;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool Debug;

		[Token(Token = "0x17000064")]
		public bool Prewarm
		{
			[Token(Token = "0x60002FD")]
			[Address(RVA = "0xDFAA6C", Offset = "0xDFAA6C", VA = "0xDFAA6C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002FE")]
			[Address(RVA = "0xDFA884", Offset = "0xDFA884", VA = "0xDFA884")]
			set
			{
			}
		}

		[Token(Token = "0x17000065")]
		public bool AutoCreate
		{
			[Token(Token = "0x60002FF")]
			[Address(RVA = "0xDFAA74", Offset = "0xDFAA74", VA = "0xDFAA74")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000300")]
			[Address(RVA = "0xDFA8A4", Offset = "0xDFA8A4", VA = "0xDFA8A4")]
			set
			{
			}
		}

		[Token(Token = "0x17000066")]
		public bool AutoEnableDisable
		{
			[Token(Token = "0x6000301")]
			[Address(RVA = "0xDFAA7C", Offset = "0xDFAA7C", VA = "0xDFAA7C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000302")]
			[Address(RVA = "0xDFAA84", Offset = "0xDFAA84", VA = "0xDFAA84")]
			set
			{
			}
		}

		[Token(Token = "0x17000067")]
		public int MinItems
		{
			[Token(Token = "0x6000303")]
			[Address(RVA = "0xDFAAA4", Offset = "0xDFAAA4", VA = "0xDFAAA4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000304")]
			[Address(RVA = "0xDFA8C4", Offset = "0xDFA8C4", VA = "0xDFA8C4")]
			set
			{
			}
		}

		[Token(Token = "0x17000068")]
		public int Threshold
		{
			[Token(Token = "0x6000305")]
			[Address(RVA = "0xDFAAAC", Offset = "0xDFAAAC", VA = "0xDFAAAC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000306")]
			[Address(RVA = "0xDFA950", Offset = "0xDFA950", VA = "0xDFA950")]
			set
			{
			}
		}

		[Token(Token = "0x17000069")]
		public float Speed
		{
			[Token(Token = "0x6000307")]
			[Address(RVA = "0xDFAAB4", Offset = "0xDFAAB4", VA = "0xDFAAB4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000308")]
			[Address(RVA = "0xDFA9E0", Offset = "0xDFA9E0", VA = "0xDFA9E0")]
			set
			{
			}
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0xDFA86C", Offset = "0xDFA86C", VA = "0xDFA86C")]
		public PoolSettings()
		{
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0xDFA1F4", Offset = "0xDFA1F4", VA = "0xDFA1F4")]
		public PoolSettings(PoolSettings src)
		{
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0xDF9840", Offset = "0xDF9840", VA = "0xDF9840")]
		public void OnValidate()
		{
		}
	}
	[Token(Token = "0x200003A")]
	public interface IPool
	{
		[Token(Token = "0x1700006A")]
		string Identifier
		{
			[Token(Token = "0x600030A")]
			get;
			[Token(Token = "0x600030B")]
			set;
		}

		[Token(Token = "0x1700006B")]
		PoolSettings Settings
		{
			[Token(Token = "0x600030C")]
			get;
		}

		[Token(Token = "0x1700006C")]
		int Count
		{
			[Token(Token = "0x6000310")]
			get;
		}

		[Token(Token = "0x600030D")]
		void Clear();

		[Token(Token = "0x600030E")]
		void Reset();

		[Token(Token = "0x600030F")]
		void Update();
	}
	[Token(Token = "0x200003B")]
	public interface IPoolable
	{
		[Token(Token = "0x6000311")]
		void OnBeforePush();

		[Token(Token = "0x6000312")]
		void OnAfterPop();
	}
	[Token(Token = "0x200003C")]
	public enum DTMessageType
	{
		[Token(Token = "0x40000DF")]
		None,
		[Token(Token = "0x40000E0")]
		Info,
		[Token(Token = "0x40000E1")]
		Warning,
		[Token(Token = "0x40000E2")]
		Error
	}
	[Token(Token = "0x200003D")]
	public enum AttributeOptionsFlags
	{
		[Token(Token = "0x40000E4")]
		None = 0,
		[Token(Token = "0x40000E5")]
		Compact = 1,
		[Token(Token = "0x40000E6")]
		Clipboard = 128,
		[Token(Token = "0x40000E7")]
		Zero = 256,
		[Token(Token = "0x40000E8")]
		One = 512,
		[Token(Token = "0x40000E9")]
		Negate = 1024,
		[Token(Token = "0x40000EA")]
		Full = 1920,
		[Token(Token = "0x40000EB")]
		FullCompact = 1921
	}
	[Token(Token = "0x200003E")]
	public class DTPropertyAttribute : PropertyAttribute
	{
		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Label;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string Tooltip;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string Color;

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AttributeOptionsFlags Options;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int Precision;

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x1457A0C", Offset = "0x1457A0C", VA = "0x1457A0C")]
		public DTPropertyAttribute(string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x200003F")]
	public class LabelAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x6000314")]
		[Address(RVA = "0xDEB054", Offset = "0xDEB054", VA = "0xDEB054")]
		public LabelAttribute()
		{
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0xDEB0AC", Offset = "0xDEB0AC", VA = "0xDEB0AC")]
		public LabelAttribute(string label, string tooltip = "")
		{
		}
	}
	[Token(Token = "0x2000040")]
	public class ToggleButtonAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x6000316")]
		[Address(RVA = "0x18104FC", Offset = "0x18104FC", VA = "0x18104FC")]
		public ToggleButtonAttribute(string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x2000041")]
	public class LayerAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x6000317")]
		[Address(RVA = "0xDEB0B4", Offset = "0xDEB0B4", VA = "0xDEB0B4")]
		public LayerAttribute(string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x2000042")]
	public class TagAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x6000318")]
		[Address(RVA = "0xB1DC10", Offset = "0xB1DC10", VA = "0xB1DC10")]
		public TagAttribute(string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x2000043")]
	public class VectorExAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x6000319")]
		[Address(RVA = "0x1814DD8", Offset = "0x1814DD8", VA = "0x1814DD8")]
		public VectorExAttribute(string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x2000044")]
	public class AnimationCurveExAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x600031A")]
		[Address(RVA = "0x139EA80", Offset = "0x139EA80", VA = "0x139EA80")]
		public AnimationCurveExAttribute(string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x2000045")]
	public class MinAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float MinValue;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string MinFieldOrPropertyName;

		[Token(Token = "0x600031B")]
		[Address(RVA = "0xDEDE00", Offset = "0xDEDE00", VA = "0xDEDE00")]
		public MinAttribute(float value, string label = "", string tooltip = "")
		{
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0xDEDE34", Offset = "0xDEDE34", VA = "0xDEDE34")]
		public MinAttribute(string fieldOrProperty, string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x2000046")]
	public class PositiveAttribute : MinAttribute
	{
		[Token(Token = "0x600031D")]
		[Address(RVA = "0xDFAFAC", Offset = "0xDFAFAC", VA = "0xDFAFAC")]
		public PositiveAttribute()
		{
		}
	}
	[Token(Token = "0x2000047")]
	public class MaxAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float MaxValue;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string MaxFieldOrPropertyName;

		[Token(Token = "0x600031E")]
		[Address(RVA = "0xDECD00", Offset = "0xDECD00", VA = "0xDECD00")]
		public MaxAttribute(float value, string label = "", string tooltip = "")
		{
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0xDECD34", Offset = "0xDECD34", VA = "0xDECD34")]
		public MaxAttribute(string fieldOrProperty, string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x2000048")]
	public class RangeExAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float MinValue;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string MinFieldOrPropertyName;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float MaxValue;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string MaxFieldOrPropertyName;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool Slider;

		[Token(Token = "0x6000320")]
		[Address(RVA = "0xDFC058", Offset = "0xDFC058", VA = "0xDFC058")]
		public RangeExAttribute(float minValue, float maxValue, string label = "", string tooltip = "")
		{
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0xDFC09C", Offset = "0xDFC09C", VA = "0xDFC09C")]
		public RangeExAttribute(string minFieldOrProperty, float maxValue, string label = "", string tooltip = "")
		{
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0xDFC0E8", Offset = "0xDFC0E8", VA = "0xDFC0E8")]
		public RangeExAttribute(float minValue, string maxFieldOrProperty, string label = "", string tooltip = "")
		{
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0xDFC134", Offset = "0xDFC134", VA = "0xDFC134")]
		public RangeExAttribute(string minFieldOrProperty, string maxFieldOrProperty, string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x2000049")]
	public class MinMaxAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public readonly string MaxValueField;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float Min;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string MinBoundFieldOrPropertyName;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float Max;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string MaxBoundFieldOrPropertyName;

		[Token(Token = "0x6000324")]
		[Address(RVA = "0xDEDE68", Offset = "0xDEDE68", VA = "0xDEDE68")]
		public MinMaxAttribute(string maxValueField, string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x200004A")]
	public class EnumFlagAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x6000325")]
		[Address(RVA = "0x145AFB0", Offset = "0x145AFB0", VA = "0x145AFB0")]
		public EnumFlagAttribute(string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x200004B")]
	public class ObjectSelectorAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x6000326")]
		[Address(RVA = "0xDF1074", Offset = "0xDF1074", VA = "0xDF1074")]
		public ObjectSelectorAttribute(string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x200004C")]
	public class PathSelectorAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x2000171")]
		public enum DialogMode
		{
			[Token(Token = "0x400064B")]
			OpenFile,
			[Token(Token = "0x400064C")]
			OpenFolder,
			[Token(Token = "0x400064D")]
			CreateFile
		}

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public readonly DialogMode Mode;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string Title;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string Directory;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string Extension;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string DefaultName;

		[Token(Token = "0x6000327")]
		[Address(RVA = "0xDF6020", Offset = "0xDF6020", VA = "0xDF6020")]
		public PathSelectorAttribute(DialogMode mode = DialogMode.OpenFile)
		{
		}
	}
	[Token(Token = "0x200004D")]
	public class EnumSelectionGridAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x6000328")]
		[Address(RVA = "0x145AFF0", Offset = "0x145AFF0", VA = "0x145AFF0")]
		public EnumSelectionGridAttribute(string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x200004E")]
	public class DTRegionAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool RegionIsOptional;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string RegionOptionsPropertyName;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool UseSlider;

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x1457A4C", Offset = "0x1457A4C", VA = "0x1457A4C")]
		public DTRegionAttribute()
		{
		}
	}
	[Token(Token = "0x200004F")]
	public class FloatRegionAttribute : DTRegionAttribute
	{
		[Token(Token = "0x600032A")]
		[Address(RVA = "0x145B74C", Offset = "0x145B74C", VA = "0x145B74C")]
		public FloatRegionAttribute()
		{
		}
	}
	[Token(Token = "0x2000050")]
	public class IntRegionAttribute : DTRegionAttribute
	{
		[Token(Token = "0x600032B")]
		[Address(RVA = "0x145EF40", Offset = "0x145EF40", VA = "0x145EF40")]
		public IntRegionAttribute()
		{
		}
	}
	[Token(Token = "0x2000051")]
	public struct RegionOptions<T>
	{
		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string LabelFrom;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string LabelTo;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string OptionalTooltip;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public DTValueClamping ClampFrom;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public DTValueClamping ClampTo;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T FromMin;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T FromMax;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T ToMin;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T ToMax;

		[Token(Token = "0x1700006D")]
		public static RegionOptions<T> Default
		{
			[Token(Token = "0x600032C")]
			get
			{
				return default(RegionOptions<T>);
			}
		}

		[Token(Token = "0x600032D")]
		public static RegionOptions<T> MinMax(T min, T max)
		{
			return default(RegionOptions<T>);
		}
	}
	[Token(Token = "0x2000052")]
	public enum DTValueClamping
	{
		[Token(Token = "0x4000111")]
		None,
		[Token(Token = "0x4000112")]
		Min,
		[Token(Token = "0x4000113")]
		Max,
		[Token(Token = "0x4000114")]
		Range
	}
	[Token(Token = "0x2000053")]
	public class ThreadPoolWorker<T> : IDisposable
	{
		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly SimplePool<QueuedCallback> queuedCallbackPool;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly SimplePool<LoopState<T>> loopStatePool;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int _remainingWorkItems;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ManualResetEvent _done;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private WaitCallback handleWorkItemCallBack;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private WaitCallback handleLoopCallBack;

		[Token(Token = "0x600032E")]
		public ThreadPoolWorker()
		{
		}

		[Token(Token = "0x600032F")]
		public void ParralelFor(Action<T> action, List<T> list)
		{
		}

		[Token(Token = "0x6000330")]
		private bool WaitAll(int millisecondsTimeout, bool exitContext)
		{
			return default(bool);
		}

		[Token(Token = "0x6000331")]
		private void ThrowIfDisposed()
		{
		}

		[Token(Token = "0x6000332")]
		private void DoneWorkItem()
		{
		}

		[Token(Token = "0x6000333")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000334")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x876A98", Offset = "0x876A98")]
		private void <.ctor>b__6_0(object o)
		{
		}

		[Token(Token = "0x6000335")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x876AA8", Offset = "0x876AA8")]
		private void <.ctor>b__6_1(object state)
		{
		}
	}
	[Token(Token = "0x2000054")]
	internal class SimplePool<T> where T : new()
	{
		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly List<T> freeItemsBackfield;

		[Token(Token = "0x6000336")]
		public SimplePool(int preCreatedElementsCount)
		{
		}

		[Token(Token = "0x6000337")]
		public T GetItem()
		{
			return (T)null;
		}

		[Token(Token = "0x6000338")]
		public void ReleaseItem(T item)
		{
		}
	}
	[Token(Token = "0x2000055")]
	internal class QueuedCallback
	{
		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public WaitCallback Callback;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public object State;

		[Token(Token = "0x6000339")]
		[Address(RVA = "0xDFC050", Offset = "0xDFC050", VA = "0xDFC050")]
		public QueuedCallback()
		{
		}
	}
	[Token(Token = "0x2000056")]
	internal class LoopState<T>
	{
		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public short StartIndex;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public short EndIndex;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public List<T> Items;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Action<T> Action;

		[Token(Token = "0x600033A")]
		public LoopState()
		{
		}
	}
	[Token(Token = "0x2000057")]
	public class ThreadPoolWorker : IDisposable
	{
		[Serializable]
		[Token(Token = "0x2000172")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x867A54", Offset = "0x867A54")]
		private sealed class <>c__4<T>
		{
			[Token(Token = "0x400064E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c__4<T> <>9;

			[Token(Token = "0x400064F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static WaitCallback <>9__4_0;

			[Token(Token = "0x6000D07")]
			public <>c__4()
			{
			}

			[Token(Token = "0x6000D08")]
			internal void <ParralelFor>b__4_0(object state)
			{
			}
		}

		[Token(Token = "0x2000173")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x867A64", Offset = "0x867A64")]
		private sealed class <>c__DisplayClass7_0
		{
			[Token(Token = "0x4000650")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Action act;

			[Token(Token = "0x6000D09")]
			[Address(RVA = "0x181C188", Offset = "0x181C188", VA = "0x181C188")]
			public <>c__DisplayClass7_0()
			{
			}

			[Token(Token = "0x6000D0A")]
			[Address(RVA = "0x181C190", Offset = "0x181C190", VA = "0x181C190")]
			internal void <QueueWorkItem>b__0(object x)
			{
			}
		}

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _remainingWorkItems;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private ManualResetEvent _done;

		[Token(Token = "0x600033B")]
		[Address(RVA = "0xB2193C", Offset = "0xB2193C", VA = "0xB2193C")]
		public void QueueWorkItem(WaitCallback callback)
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0xB219C4", Offset = "0xB219C4", VA = "0xB219C4")]
		public void QueueWorkItem(Action act)
		{
		}

		[Token(Token = "0x600033D")]
		public void ParralelFor<T>(Action<T> action, List<T> list)
		{
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0xB21AA4", Offset = "0xB21AA4", VA = "0xB21AA4")]
		private void QueueWorkItem(QueuedCallback callback)
		{
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0xB21944", Offset = "0xB21944", VA = "0xB21944")]
		public void QueueWorkItem(WaitCallback callback, object state)
		{
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0xB219CC", Offset = "0xB219CC", VA = "0xB219CC")]
		public void QueueWorkItem(Action act, object state)
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0xB21C4C", Offset = "0xB21C4C", VA = "0xB21C4C")]
		public bool WaitAll()
		{
			return default(bool);
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0xB21D58", Offset = "0xB21D58", VA = "0xB21D58")]
		public bool WaitAll(TimeSpan timeout, bool exitContext)
		{
			return default(bool);
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0xB21C58", Offset = "0xB21C58", VA = "0xB21C58")]
		public bool WaitAll(int millisecondsTimeout, bool exitContext)
		{
			return default(bool);
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0xB21E54", Offset = "0xB21E54", VA = "0xB21E54")]
		private void HandleWorkItem(object state)
		{
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0xB21DA4", Offset = "0xB21DA4", VA = "0xB21DA4")]
		private void DoneWorkItem()
		{
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0xB21BA4", Offset = "0xB21BA4", VA = "0xB21BA4")]
		private void ThrowIfDisposed()
		{
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0xB21F44", Offset = "0xB21F44", VA = "0xB21F44", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0xB21FF8", Offset = "0xB21FF8", VA = "0xB21FF8")]
		public ThreadPoolWorker()
		{
		}
	}
	[Token(Token = "0x2000058")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x8646BC", Offset = "0x8646BC")]
	public class ComponentPool : MonoBehaviour, IPool, ISerializationCallbackReceiver
	{
		[Token(Token = "0x2000174")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x867A74", Offset = "0x867A74")]
		private sealed class <>c__DisplayClass36_0
		{
			[Token(Token = "0x4000651")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string typeName;

			[Token(Token = "0x6000D0B")]
			[Address(RVA = "0x1815FC8", Offset = "0x1815FC8", VA = "0x1815FC8")]
			public <>c__DisplayClass36_0()
			{
			}

			[Token(Token = "0x6000D0C")]
			[Address(RVA = "0x1815FD0", Offset = "0x1815FD0", VA = "0x1815FD0")]
			internal bool <OnAfterDeserialize>b__0(Type t)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[HideInInspector]
		private string m_Identifier;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Inline]
		[SerializeField]
		private PoolSettings m_Settings;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private PoolManager mManager;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<Component> mObjects;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private double mLastTime;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private double mDeltaTime;

		[Token(Token = "0x1700006E")]
		public PoolSettings Settings
		{
			[Token(Token = "0x6000349")]
			[Address(RVA = "0x10A5940", Offset = "0x10A5940", VA = "0x10A5940", Slot = "6")]
			get
			{
				return null;
			}
			[Token(Token = "0x600034A")]
			[Address(RVA = "0x10A5948", Offset = "0x10A5948", VA = "0x10A5948")]
			set
			{
			}
		}

		[Token(Token = "0x1700006F")]
		public PoolManager Manager
		{
			[Token(Token = "0x600034B")]
			[Address(RVA = "0x10A596C", Offset = "0x10A596C", VA = "0x10A596C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000070")]
		public string Identifier
		{
			[Token(Token = "0x600034C")]
			[Address(RVA = "0x10A5A04", Offset = "0x10A5A04", VA = "0x10A5A04", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600034D")]
			[Address(RVA = "0x10A5A0C", Offset = "0x10A5A0C", VA = "0x10A5A0C", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x17000071")]
		public Type Type
		{
			[Token(Token = "0x600034E")]
			[Address(RVA = "0x10A5A78", Offset = "0x10A5A78", VA = "0x10A5A78")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000072")]
		public int Count
		{
			[Token(Token = "0x600034F")]
			[Address(RVA = "0x10A5B5C", Offset = "0x10A5B5C", VA = "0x10A5B5C", Slot = "10")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x10A5BAC", Offset = "0x10A5BAC", VA = "0x10A5BAC")]
		public void Initialize(Type type, PoolSettings settings)
		{
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x10A5D90", Offset = "0x10A5D90", VA = "0x10A5D90")]
		private void Start()
		{
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x10A5DB4", Offset = "0x10A5DB4", VA = "0x10A5DB4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x10A5E50", Offset = "0x10A5E50", VA = "0x10A5E50")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x10A5E54", Offset = "0x10A5E54", VA = "0x10A5E54", Slot = "9")]
		public void Update()
		{
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x10A5C4C", Offset = "0x10A5C4C", VA = "0x10A5C4C", Slot = "8")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x10A6394", Offset = "0x10A6394", VA = "0x10A6394")]
		public void OnSceneLoaded(Scene scn, LoadSceneMode mode)
		{
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x10A6488", Offset = "0x10A6488", VA = "0x10A6488", Slot = "7")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x10A655C", Offset = "0x10A655C", VA = "0x10A655C")]
		public void Push(Component item)
		{
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x10A6854", Offset = "0x10A6854", VA = "0x10A6854")]
		public Component Pop([Optional] Transform parent)
		{
			return null;
		}

		[Token(Token = "0x600035A")]
		public T Pop<T>(Transform parent) where T : Component
		{
			return null;
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x10A623C", Offset = "0x10A623C", VA = "0x10A623C")]
		private Component create()
		{
			return null;
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x10A6180", Offset = "0x10A6180", VA = "0x10A6180")]
		private void destroy(Component item)
		{
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x10A6BCC", Offset = "0x10A6BCC", VA = "0x10A6BCC")]
		private void setParent(Component item, Transform parent)
		{
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x10A6A20", Offset = "0x10A6A20", VA = "0x10A6A20")]
		private void sendAfterPop(Component item)
		{
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x10A66AC", Offset = "0x10A66AC", VA = "0x10A66AC")]
		private void sendBeforePush(Component item)
		{
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x10A60B4", Offset = "0x10A60B4", VA = "0x10A60B4")]
		private void log(string msg)
		{
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x10A6C7C", Offset = "0x10A6C7C", VA = "0x10A6C7C", Slot = "11")]
		public void OnBeforeSerialize()
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x10A6C80", Offset = "0x10A6C80", VA = "0x10A6C80", Slot = "12")]
		public void OnAfterDeserialize()
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x10A6E94", Offset = "0x10A6E94", VA = "0x10A6E94")]
		public ComponentPool()
		{
		}
	}
	[Token(Token = "0x2000059")]
	public class DTSingleton<T> : MonoBehaviour, IDTSingleton where T : MonoBehaviour, IDTSingleton
	{
		[Serializable]
		[Token(Token = "0x2000175")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x867A84", Offset = "0x867A84")]
		private sealed class <>c
		{
			[Token(Token = "0x4000652")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000653")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static Func<UnityEngine.Object, bool> <>9__7_0;

			[Token(Token = "0x6000D0E")]
			public <>c()
			{
			}

			[Token(Token = "0x6000D0F")]
			internal bool <get_Instance>b__7_0(UnityEngine.Object o)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T _instance;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static object _lock;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool applicationIsQuitting;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool isDuplicateInstance;

		[Token(Token = "0x17000073")]
		public static bool HasInstance
		{
			[Token(Token = "0x6000364")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000074")]
		public static T Instance
		{
			[Token(Token = "0x6000365")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000366")]
		public virtual void Awake()
		{
		}

		[Token(Token = "0x6000367")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000368")]
		public virtual void MergeDoubleLoaded(IDTSingleton newInstance)
		{
		}

		[Token(Token = "0x6000369")]
		private void DestroySelf()
		{
		}

		[Token(Token = "0x600036A")]
		public DTSingleton()
		{
		}
	}
	[Token(Token = "0x200005A")]
	public interface IDTSingleton
	{
		[Token(Token = "0x600036C")]
		void MergeDoubleLoaded(IDTSingleton newInstance);
	}
	[Token(Token = "0x200005B")]
	public abstract class DTVersionedMonoBehaviour : MonoBehaviour
	{
		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[HideInInspector]
		private string m_Version;

		[Token(Token = "0x17000075")]
		public string Version
		{
			[Token(Token = "0x600036D")]
			[Address(RVA = "0x145A7D0", Offset = "0x145A7D0", VA = "0x145A7D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600036E")]
			[Address(RVA = "0x145A7D8", Offset = "0x145A7D8", VA = "0x145A7D8")]
			protected set
			{
			}
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x145A7E0", Offset = "0x145A7E0", VA = "0x145A7E0")]
		public void Destroy()
		{
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x145A894", Offset = "0x145A894", VA = "0x145A894")]
		protected DTVersionedMonoBehaviour()
		{
		}
	}
	[Token(Token = "0x200005C")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x8646F4", Offset = "0x8646F4")]
	public abstract class DuplicateEditorMesh : MonoBehaviour
	{
		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private MeshFilter mFilter;

		[Token(Token = "0x17000076")]
		public MeshFilter Filter
		{
			[Token(Token = "0x6000371")]
			[Address(RVA = "0x145AA80", Offset = "0x145AA80", VA = "0x145AA80")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x145AB18", Offset = "0x145AB18", VA = "0x145AB18", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x145AD90", Offset = "0x145AD90", VA = "0x145AD90")]
		protected DuplicateEditorMesh()
		{
		}
	}
	[Token(Token = "0x200005D")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x864768", Offset = "0x864768")]
	public class InspectorNote : MonoBehaviour
	{
		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TextAreaAttribute", RVA = "0x8681E0", Offset = "0x8681E0")]
		[SerializeField]
		private string m_Note;

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x145EADC", Offset = "0x145EADC", VA = "0x145EADC")]
		public InspectorNote()
		{
		}
	}
	[Token(Token = "0x200005E")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x8647A0", Offset = "0x8647A0")]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	public class PoolManager : MonoBehaviour
	{
		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x868220", Offset = "0x868220")]
		[SerializeField]
		private bool m_AutoCreatePools;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "AsGroupAttribute", RVA = "0x868278", Offset = "0x868278")]
		[SerializeField]
		private PoolSettings m_DefaultSettings;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8682BC", Offset = "0x8682BC")]
		private bool <IsInitialized>k__BackingField;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Dictionary<string, IPool> Pools;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Dictionary<Type, IPool> TypePools;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private IPool[] mPools;

		[Token(Token = "0x17000077")]
		public bool AutoCreatePools
		{
			[Token(Token = "0x6000375")]
			[Address(RVA = "0xDF97F0", Offset = "0xDF97F0", VA = "0xDF97F0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000376")]
			[Address(RVA = "0xDF97F8", Offset = "0xDF97F8", VA = "0xDF97F8")]
			set
			{
			}
		}

		[Token(Token = "0x17000078")]
		public PoolSettings DefaultSettings
		{
			[Token(Token = "0x6000377")]
			[Address(RVA = "0xDF9818", Offset = "0xDF9818", VA = "0xDF9818")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000378")]
			[Address(RVA = "0xDF9820", Offset = "0xDF9820", VA = "0xDF9820")]
			set
			{
			}
		}

		[Token(Token = "0x17000079")]
		public bool IsInitialized
		{
			[Token(Token = "0x6000379")]
			[Address(RVA = "0xDF9878", Offset = "0xDF9878", VA = "0xDF9878")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x876AB8", Offset = "0x876AB8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600037A")]
			[Address(RVA = "0xDF9880", Offset = "0xDF9880", VA = "0xDF9880")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x876AC8", Offset = "0x876AC8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700007A")]
		public int Count
		{
			[Token(Token = "0x600037B")]
			[Address(RVA = "0xDF988C", Offset = "0xDF988C", VA = "0xDF988C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0xDF990C", Offset = "0xDF990C", VA = "0xDF990C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0xDF9914", Offset = "0xDF9914", VA = "0xDF9914")]
		private void Update()
		{
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0xDF9AA8", Offset = "0xDF9AA8", VA = "0xDF9AA8")]
		private void Initialize()
		{
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0xDF9ED8", Offset = "0xDF9ED8", VA = "0xDF9ED8")]
		public string GetUniqueIdentifier(string ident)
		{
			return null;
		}

		[Token(Token = "0x6000380")]
		public Pool<T> GetTypePool<T>()
		{
			return null;
		}

		[Token(Token = "0x6000381")]
		public ComponentPool GetComponentPool<T>() where T : Component
		{
			return null;
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0xDF9F90", Offset = "0xDF9F90", VA = "0xDF9F90")]
		public PrefabPool GetPrefabPool(string identifier, params GameObject[] prefabs)
		{
			return null;
		}

		[Token(Token = "0x6000383")]
		public Pool<T> CreateTypePool<T>([Optional] PoolSettings settings)
		{
			return null;
		}

		[Token(Token = "0x6000384")]
		public ComponentPool CreateComponentPool<T>([Optional] PoolSettings settings) where T : Component
		{
			return null;
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0xDFA08C", Offset = "0xDFA08C", VA = "0xDFA08C")]
		public PrefabPool CreatePrefabPool(string name, [Optional] PoolSettings settings, params GameObject[] prefabs)
		{
			return null;
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0xDFA3B4", Offset = "0xDFA3B4", VA = "0xDFA3B4")]
		public List<IPool> FindPools(string identifierStartsWith)
		{
			return null;
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0xDFA524", Offset = "0xDFA524", VA = "0xDFA524")]
		public void DeletePools(string startsWith)
		{
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0xDFA5D4", Offset = "0xDFA5D4", VA = "0xDFA5D4")]
		public void DeletePool(IPool pool)
		{
		}

		[Token(Token = "0x6000389")]
		public void DeletePool<T>()
		{
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0xDFA784", Offset = "0xDFA784", VA = "0xDFA784")]
		public PoolManager()
		{
		}
	}
	[Token(Token = "0x200005F")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x8647FC", Offset = "0x8647FC")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x8647FC", Offset = "0x8647FC")]
	public class PrefabPool : MonoBehaviour, IPool
	{
		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x8682CC", Offset = "0x8682CC")]
		[SerializeField]
		private string m_Identifier;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<GameObject> m_Prefabs;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Inline]
		[SerializeField]
		private PoolSettings m_Settings;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private PoolManager mManager;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<GameObject> mObjects;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private double mLastTime;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private double mDeltaTime;

		[Token(Token = "0x1700007B")]
		public string Identifier
		{
			[Token(Token = "0x600038B")]
			[Address(RVA = "0xDFB00C", Offset = "0xDFB00C", VA = "0xDFB00C", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600038C")]
			[Address(RVA = "0xDFB014", Offset = "0xDFB014", VA = "0xDFB014", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x1700007C")]
		public List<GameObject> Prefabs
		{
			[Token(Token = "0x600038D")]
			[Address(RVA = "0xDFB108", Offset = "0xDFB108", VA = "0xDFB108")]
			get
			{
				return null;
			}
			[Token(Token = "0x600038E")]
			[Address(RVA = "0xDFB110", Offset = "0xDFB110", VA = "0xDFB110")]
			set
			{
			}
		}

		[Token(Token = "0x1700007D")]
		public PoolSettings Settings
		{
			[Token(Token = "0x600038F")]
			[Address(RVA = "0xDFB124", Offset = "0xDFB124", VA = "0xDFB124", Slot = "6")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000390")]
			[Address(RVA = "0xDFB12C", Offset = "0xDFB12C", VA = "0xDFB12C")]
			set
			{
			}
		}

		[Token(Token = "0x1700007E")]
		public PoolManager Manager
		{
			[Token(Token = "0x6000391")]
			[Address(RVA = "0xDFB070", Offset = "0xDFB070", VA = "0xDFB070")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007F")]
		public int Count
		{
			[Token(Token = "0x6000398")]
			[Address(RVA = "0xDFB518", Offset = "0xDFB518", VA = "0xDFB518", Slot = "10")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0xDFB14C", Offset = "0xDFB14C", VA = "0xDFB14C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0xDFB150", Offset = "0xDFB150", VA = "0xDFB150")]
		private void Start()
		{
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0xDFA2A8", Offset = "0xDFA2A8", VA = "0xDFA2A8")]
		public void Initialize(string ident, PoolSettings settings, params GameObject[] prefabs)
		{
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0xDFB2B8", Offset = "0xDFB2B8", VA = "0xDFB2B8", Slot = "9")]
		public void Update()
		{
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0xDFB174", Offset = "0xDFB174", VA = "0xDFB174", Slot = "8")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0xDFB858", Offset = "0xDFB858", VA = "0xDFB858", Slot = "7")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0xDFB92C", Offset = "0xDFB92C", VA = "0xDFB92C")]
		public GameObject Pop([Optional] Transform parent)
		{
			return null;
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0xDFBB4C", Offset = "0xDFBB4C", VA = "0xDFBB4C", Slot = "11")]
		public virtual void Push(GameObject item)
		{
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0xDFB69C", Offset = "0xDFB69C", VA = "0xDFB69C")]
		private GameObject create()
		{
			return null;
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0xDFB634", Offset = "0xDFB634", VA = "0xDFB634")]
		private void destroy(GameObject go)
		{
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0xDFB568", Offset = "0xDFB568", VA = "0xDFB568")]
		private void log(string msg)
		{
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0xDFBD1C", Offset = "0xDFBD1C", VA = "0xDFBD1C")]
		private void setParent(Transform item, Transform parent)
		{
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0xDFBAEC", Offset = "0xDFBAEC", VA = "0xDFBAEC")]
		private void sendAfterPop(GameObject item)
		{
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0xDFBCBC", Offset = "0xDFBCBC", VA = "0xDFBCBC")]
		private void sendBeforePush(GameObject item)
		{
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0xDFBDC0", Offset = "0xDFBDC0", VA = "0xDFBDC0")]
		public PrefabPool()
		{
		}
	}
}
namespace FluffyUnderware.DevTools.Extensions
{
	[Token(Token = "0x2000060")]
	public static class ObjectExt
	{
		[Token(Token = "0x60003A2")]
		[Address(RVA = "0xDF0F94", Offset = "0xDF0F94", VA = "0xDF0F94")]
		public static void Destroy(this UnityEngine.Object c)
		{
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0xDF0FFC", Offset = "0xDF0FFC", VA = "0xDF0FFC")]
		public static string ToDumpString(this object o)
		{
			return null;
		}
	}
	[Token(Token = "0x2000061")]
	public static class Vector2Ext
	{
		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x1814740", Offset = "0x1814740", VA = "0x1814740")]
		public static Vector2 Snap(this Vector2 v, float snapX, float snapY = -1f)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x1814798", Offset = "0x1814798", VA = "0x1814798")]
		public static float AngleSigned(this Vector2 a, Vector2 b)
		{
			return default(float);
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x181498C", Offset = "0x181498C", VA = "0x181498C")]
		public static Vector2 LeftNormal(this Vector2 v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x18149A0", Offset = "0x18149A0", VA = "0x18149A0")]
		public static Vector2 RightNormal(this Vector2 v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x18149B0", Offset = "0x18149B0", VA = "0x18149B0")]
		public static Vector2 Rotate(this Vector2 v, float degree)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x1814A60", Offset = "0x1814A60", VA = "0x1814A60")]
		public static Vector2 ToVector3(this Vector2 v)
		{
			return default(Vector2);
		}
	}
	[Token(Token = "0x2000062")]
	public static class Vector3Ext
	{
		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x1814AD4", Offset = "0x1814AD4", VA = "0x1814AD4")]
		public static float AngleSigned(this Vector3 a, Vector3 b, Vector3 normal)
		{
			return default(float);
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x1814BF8", Offset = "0x1814BF8", VA = "0x1814BF8")]
		public static Vector3 RotateAround(this Vector3 point, Vector3 origin, Quaternion rotation)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x1814CFC", Offset = "0x1814CFC", VA = "0x1814CFC")]
		public static Vector2 ToVector2(this Vector3 v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x1814D00", Offset = "0x1814D00", VA = "0x1814D00")]
		public static bool Approximately(this Vector3 v1, Vector3 v2)
		{
			return default(bool);
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x1814DBC", Offset = "0x1814DBC", VA = "0x1814DBC")]
		public static bool NotApproximately(this Vector3 v1, Vector3 v2)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000063")]
	public static class QuaternionExt
	{
		[Token(Token = "0x60003AF")]
		[Address(RVA = "0xDFBE50", Offset = "0xDFBE50", VA = "0xDFBE50")]
		public static bool SameOrientation(this Quaternion q1, Quaternion q2)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0xDFBF50", Offset = "0xDFBF50", VA = "0xDFBF50")]
		public static bool DifferentOrientation(this Quaternion q1, Quaternion q2)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000064")]
	public static class CameraExt
	{
		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Plane[] camPlanes;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Vector3 camPos;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private static Vector3 camForward;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static float fov;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private static float screenW;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static float screenH;

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x10A4500", Offset = "0x10A4500", VA = "0x10A4500")]
		public static bool BoundsInView(this Camera c, Bounds bounds)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x10A4850", Offset = "0x10A4850", VA = "0x10A4850")]
		public static bool BoundsPartiallyInView(this Camera c, Bounds bounds)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000065")]
	public static class GameObjectExt
	{
		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x145BB1C", Offset = "0x145BB1C", VA = "0x145BB1C")]
		public static GameObject DuplicateGameObject(this GameObject source, Transform newParent, bool keepPrefabReference = false)
		{
			return null;
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x145BC18", Offset = "0x145BC18", VA = "0x145BC18")]
		public static void StripComponents(this GameObject go, params Type[] toKeep)
		{
		}
	}
	[Token(Token = "0x2000066")]
	public static class ComponentExt
	{
		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x10A558C", Offset = "0x10A558C", VA = "0x10A558C")]
		public static void StripComponents(this Component c, params Type[] toKeep)
		{
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x10A5670", Offset = "0x10A5670", VA = "0x10A5670")]
		public static GameObject AddChildGameObject(this Component c, string name)
		{
			return null;
		}

		[Token(Token = "0x60003B8")]
		public static T AddChildGameObject<T>(this Component c, string name) where T : Component
		{
			return null;
		}

		[Token(Token = "0x60003B9")]
		public static T DuplicateGameObject<T>(this Component source, Transform newParent, bool keepPrefabConnection = false) where T : Component
		{
			return null;
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x10A571C", Offset = "0x10A571C", VA = "0x10A571C")]
		public static Component DuplicateGameObject(this Component source, Transform newParent, bool keepPrefabConnection = false)
		{
			return null;
		}
	}
	[Token(Token = "0x2000067")]
	public static class ColorExt
	{
		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x10A5010", Offset = "0x10A5010", VA = "0x10A5010")]
		public static string ToHtml(this Color c)
		{
			return null;
		}
	}
	[Token(Token = "0x2000068")]
	public static class EnumExt
	{
		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x145AD98", Offset = "0x145AD98", VA = "0x145AD98")]
		public static bool HasFlag(this Enum variable, params Enum[] flags)
		{
			return default(bool);
		}

		[Token(Token = "0x60003BD")]
		public static bool HasFlag<T>(this T value, T flag) where T : struct
		{
			return default(bool);
		}

		[Token(Token = "0x60003BE")]
		public static T Set<T>(this Enum value, T append)
		{
			return (T)null;
		}

		[Token(Token = "0x60003BF")]
		public static T Set<T>(this Enum value, T append, bool OnOff)
		{
			return (T)null;
		}
	}
	[Token(Token = "0x2000069")]
	public static class RectExt
	{
		[Token(Token = "0x60003C0")]
		[Address(RVA = "0xDFC180", Offset = "0xDFC180", VA = "0xDFC180")]
		public static Rect Set(this Rect rect, Vector2 pos, Vector2 size)
		{
			return default(Rect);
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0xDFC1DC", Offset = "0xDFC1DC", VA = "0xDFC1DC")]
		public static Rect SetBetween(this Rect rect, Vector2 pos, Vector2 pos2)
		{
			return default(Rect);
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0xDFC238", Offset = "0xDFC238", VA = "0xDFC238")]
		public static Rect SetPosition(this Rect rect, Vector2 pos)
		{
			return default(Rect);
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0xDFC2A4", Offset = "0xDFC2A4", VA = "0xDFC2A4")]
		public static Rect SetPosition(this Rect rect, float x, float y)
		{
			return default(Rect);
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0xDFC310", Offset = "0xDFC310", VA = "0xDFC310")]
		public static Vector2 GetSize(this Rect rect)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0xDFC35C", Offset = "0xDFC35C", VA = "0xDFC35C")]
		public static Rect SetSize(this Rect rect, Vector2 size)
		{
			return default(Rect);
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0xDFC3C8", Offset = "0xDFC3C8", VA = "0xDFC3C8")]
		public static Rect ScaleBy(this Rect rect, int pixel)
		{
			return default(Rect);
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0xDFC3D0", Offset = "0xDFC3D0", VA = "0xDFC3D0")]
		public static Rect ScaleBy(this Rect rect, int x, int y)
		{
			return default(Rect);
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0xDFC4A8", Offset = "0xDFC4A8", VA = "0xDFC4A8")]
		public static Rect ShiftBy(this Rect rect, int x, int y)
		{
			return default(Rect);
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0xDFC538", Offset = "0xDFC538", VA = "0xDFC538")]
		public static Rect Include(this Rect rect, Rect other)
		{
			return default(Rect);
		}
	}
	[Token(Token = "0x200006A")]
	public static class StringExt
	{
		[Token(Token = "0x60003CA")]
		[Address(RVA = "0xB1D214", Offset = "0xB1D214", VA = "0xB1D214")]
		public static Color ColorFromHtml(this string hexString)
		{
			return default(Color);
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0xB1D4D0", Offset = "0xB1D4D0", VA = "0xB1D4D0")]
		public static string TrimStart(this string s, string trim, StringComparison compare = StringComparison.CurrentCultureIgnoreCase)
		{
			return null;
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0xB14E88", Offset = "0xB14E88", VA = "0xB14E88")]
		public static string TrimEnd(this string s, string trim, StringComparison compare = StringComparison.CurrentCultureIgnoreCase)
		{
			return null;
		}
	}
	[Token(Token = "0x200006B")]
	public static class IEnumerableExt
	{
		[Token(Token = "0x60003CD")]
		public static void ForEach<T>(this IEnumerable<T> ie, Action<T> action)
		{
		}
	}
	[Token(Token = "0x200006C")]
	public static class ArrayExt
	{
		[Token(Token = "0x60003CE")]
		public static T[] SubArray<T>(this T[] data, int index, int length)
		{
			return null;
		}

		[Token(Token = "0x60003CF")]
		public static T[] RemoveAt<T>(this T[] source, int index)
		{
			return null;
		}

		[Token(Token = "0x60003D0")]
		public static T[] InsertAt<T>(this T[] source, int index)
		{
			return null;
		}

		[Token(Token = "0x60003D1")]
		public static T[] Swap<T>(this T[] source, int index, int with)
		{
			return null;
		}

		[Token(Token = "0x60003D2")]
		public static T[] Add<T>(this T[] source, T item)
		{
			return null;
		}

		[Token(Token = "0x60003D3")]
		public static T[] AddRange<T>(this T[] source, T[] items)
		{
			return null;
		}

		[Token(Token = "0x60003D4")]
		public static T[] RemoveDuplicates<T>(this T[] source)
		{
			return null;
		}

		[Token(Token = "0x60003D5")]
		public static int IndexOf<T>(this T[] source, T item)
		{
			return default(int);
		}

		[Token(Token = "0x60003D6")]
		public static T[] Remove<T>(this T[] source, T item)
		{
			return null;
		}
	}
	[Token(Token = "0x200006D")]
	public static class MeshFilterExt
	{
		[Token(Token = "0x60003D7")]
		[Address(RVA = "0xDECD68", Offset = "0xDECD68", VA = "0xDECD68")]
		public static Mesh PrepareNewShared(this MeshFilter m, string name = "Mesh")
		{
			return null;
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0xDECEEC", Offset = "0xDECEEC", VA = "0xDECEEC")]
		public static void CalculateTangents(this MeshFilter m)
		{
		}
	}
	[Token(Token = "0x200006E")]
	public static class TypeExt
	{
		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x18113D8", Offset = "0x18113D8", VA = "0x18113D8")]
		public static Type[] GetLoadedTypes()
		{
			return null;
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x1811828", Offset = "0x1811828", VA = "0x1811828")]
		public static IEnumerable<Assembly> GetLoadedAssemblies()
		{
			return null;
		}

		[Token(Token = "0x60003DB")]
		public static Dictionary<U, Type> GetAllTypesWithAttribute<U>(this Type type)
		{
			return null;
		}

		[Token(Token = "0x60003DC")]
		public static List<FieldInfo> GetFieldsWithAttribute<T>(this Type type, bool includeInherited = false, bool includePrivate = false) where T : Attribute
		{
			return null;
		}

		[Token(Token = "0x60003DD")]
		public static T GetCustomAttribute<T>(this Type type) where T : Attribute
		{
			return null;
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x181184C", Offset = "0x181184C", VA = "0x181184C")]
		public static MethodInfo MethodByName(this Type type, string name, bool includeInherited = false, bool includePrivate = false)
		{
			return null;
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x18119F4", Offset = "0x18119F4", VA = "0x18119F4")]
		public static FieldInfo FieldByName(this Type type, string name, bool includeInherited = false, bool includePrivate = false)
		{
			return null;
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x1811BB4", Offset = "0x1811BB4", VA = "0x1811BB4")]
		public static PropertyInfo PropertyByName(this Type type, string name, bool includeInherited = false, bool includePrivate = false)
		{
			return null;
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x1811D5C", Offset = "0x1811D5C", VA = "0x1811D5C")]
		public static FieldInfo[] GetAllFields(this Type type, bool includeInherited = false, bool includePrivate = false)
		{
			return null;
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x1811EDC", Offset = "0x1811EDC", VA = "0x1811EDC")]
		public static PropertyInfo[] GetAllProperties(this Type type, bool includeInherited = false, bool includePrivate = false)
		{
			return null;
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x181205C", Offset = "0x181205C", VA = "0x181205C")]
		public static bool IsFrameworkType(this Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x1812168", Offset = "0x1812168", VA = "0x1812168")]
		public static bool IsArrayOrList(this Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x1812250", Offset = "0x1812250", VA = "0x1812250")]
		public static Type GetEnumerableType(this Type t)
		{
			return null;
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x1812310", Offset = "0x1812310", VA = "0x1812310")]
		private static Type FindIEnumerable(Type seqType)
		{
			return null;
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x1811880", Offset = "0x1811880", VA = "0x1811880")]
		private static MethodInfo GetMethodIncludingBaseClasses(this Type type, string name, BindingFlags bindingFlags)
		{
			return null;
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x1811A30", Offset = "0x1811A30", VA = "0x1811A30")]
		private static FieldInfo GetFieldIncludingBaseClasses(this Type type, string name, BindingFlags bindingFlags)
		{
			return null;
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x1811BE8", Offset = "0x1811BE8", VA = "0x1811BE8")]
		private static PropertyInfo GetPropertyIncludingBaseClasses(this Type type, string name, BindingFlags bindingFlags)
		{
			return null;
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x1812754", Offset = "0x1812754", VA = "0x1812754")]
		public static bool Matches(this Type type, params Type[] types)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200006F")]
	public static class FieldInfoExt
	{
		[Token(Token = "0x60003EB")]
		public static T GetCustomAttribute<T>(this FieldInfo field) where T : Attribute
		{
			return null;
		}
	}
}
namespace FluffyUnderware.Curvy
{
	[Token(Token = "0x2000070")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x864984", Offset = "0x864984")]
	public class MetaCGOptions : CurvyMetadataBase
	{
		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Positive]
		[SerializeField]
		private int m_MaterialID;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private bool m_HardEdge;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Positive]
		[SerializeField]
		private float m_MaxStepDistance;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x868430", Offset = "0x868430")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x868430", Offset = "0x868430")]
		[SerializeField]
		private bool m_UVEdge;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		[Positive]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x868524", Offset = "0x868524")]
		[SerializeField]
		private bool m_ExplicitU;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x8685E8", Offset = "0x8685E8")]
		[AttributeAttribute(Name = "FieldActionAttribute", RVA = "0x8685E8", Offset = "0x8685E8")]
		[Positive]
		[SerializeField]
		private float m_FirstU;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x8686D4", Offset = "0x8686D4")]
		[Positive]
		[SerializeField]
		private float m_SecondU;

		[Token(Token = "0x17000080")]
		public int MaterialID
		{
			[Token(Token = "0x60003EC")]
			[Address(RVA = "0xDED5E0", Offset = "0xDED5E0", VA = "0xDED5E0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60003ED")]
			[Address(RVA = "0xDED5E8", Offset = "0xDED5E8", VA = "0xDED5E8")]
			set
			{
			}
		}

		[Token(Token = "0x17000081")]
		public bool HardEdge
		{
			[Token(Token = "0x60003EE")]
			[Address(RVA = "0xDED68C", Offset = "0xDED68C", VA = "0xDED68C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003EF")]
			[Address(RVA = "0xDED694", Offset = "0xDED694", VA = "0xDED694")]
			set
			{
			}
		}

		[Token(Token = "0x17000082")]
		public bool UVEdge
		{
			[Token(Token = "0x60003F0")]
			[Address(RVA = "0xDED6BC", Offset = "0xDED6BC", VA = "0xDED6BC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003F1")]
			[Address(RVA = "0xDED6C4", Offset = "0xDED6C4", VA = "0xDED6C4")]
			set
			{
			}
		}

		[Token(Token = "0x17000083")]
		public bool ExplicitU
		{
			[Token(Token = "0x60003F2")]
			[Address(RVA = "0xDED6EC", Offset = "0xDED6EC", VA = "0xDED6EC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003F3")]
			[Address(RVA = "0xDED6F4", Offset = "0xDED6F4", VA = "0xDED6F4")]
			set
			{
			}
		}

		[Token(Token = "0x17000084")]
		public float FirstU
		{
			[Token(Token = "0x60003F4")]
			[Address(RVA = "0xDED71C", Offset = "0xDED71C", VA = "0xDED71C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003F5")]
			[Address(RVA = "0xDED724", Offset = "0xDED724", VA = "0xDED724")]
			set
			{
			}
		}

		[Token(Token = "0x17000085")]
		public float SecondU
		{
			[Token(Token = "0x60003F6")]
			[Address(RVA = "0xDED740", Offset = "0xDED740", VA = "0xDED740")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003F7")]
			[Address(RVA = "0xDED748", Offset = "0xDED748", VA = "0xDED748")]
			set
			{
			}
		}

		[Token(Token = "0x17000086")]
		public float MaxStepDistance
		{
			[Token(Token = "0x60003F8")]
			[Address(RVA = "0xDED764", Offset = "0xDED764", VA = "0xDED764")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003F9")]
			[Address(RVA = "0xDED76C", Offset = "0xDED76C", VA = "0xDED76C")]
			set
			{
			}
		}

		[Token(Token = "0x17000087")]
		public bool HasDifferentMaterial
		{
			[Token(Token = "0x60003FA")]
			[Address(RVA = "0xDED810", Offset = "0xDED810", VA = "0xDED810")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000088")]
		private bool showUVEdge
		{
			[Token(Token = "0x60003FB")]
			[Address(RVA = "0xDED8C8", Offset = "0xDED8C8", VA = "0xDED8C8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000089")]
		private bool showExplicitU
		{
			[Token(Token = "0x60003FC")]
			[Address(RVA = "0xDEDA18", Offset = "0xDEDA18", VA = "0xDEDA18")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700008A")]
		private bool showFirstU
		{
			[Token(Token = "0x60003FD")]
			[Address(RVA = "0xDEDAAC", Offset = "0xDEDAAC", VA = "0xDEDAAC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700008B")]
		private bool showSecondU
		{
			[Token(Token = "0x60003FE")]
			[Address(RVA = "0xDEDB4C", Offset = "0xDEDB4C", VA = "0xDEDB4C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0xDEDB60", Offset = "0xDEDB60", VA = "0xDEDB60")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0xDEDC18", Offset = "0xDEDC18", VA = "0xDEDC18")]
		public float GetDefinedFirstU(float defaultValue)
		{
			return default(float);
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0xDEDC64", Offset = "0xDEDC64", VA = "0xDEDC64")]
		public float GetDefinedSecondU(float defaultValue)
		{
			return default(float);
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0xDEDCCC", Offset = "0xDEDCCC", VA = "0xDEDCCC")]
		public MetaCGOptions()
		{
		}
	}
	[Token(Token = "0x2000071")]
	public enum OrientationModeEnum
	{
		[Token(Token = "0x400014C")]
		None,
		[Token(Token = "0x400014D")]
		Orientation,
		[Token(Token = "0x400014E")]
		Tangent
	}
	[Token(Token = "0x2000072")]
	public enum OrientationAxisEnum
	{
		[Token(Token = "0x4000150")]
		Up,
		[Token(Token = "0x4000151")]
		Down,
		[Token(Token = "0x4000152")]
		Forward,
		[Token(Token = "0x4000153")]
		Backward,
		[Token(Token = "0x4000154")]
		Left,
		[Token(Token = "0x4000155")]
		Right
	}
	[Token(Token = "0x2000073")]
	public enum ConnectionHeadingEnum
	{
		[Token(Token = "0x4000157")]
		Minus = -1,
		[Token(Token = "0x4000158")]
		Sharp,
		[Token(Token = "0x4000159")]
		Plus,
		[Token(Token = "0x400015A")]
		Auto
	}
	[Token(Token = "0x2000074")]
	public static class ConnectionHeadingEnumMethods
	{
		[Token(Token = "0x6000403")]
		[Address(RVA = "0x10A818C", Offset = "0x10A818C", VA = "0x10A818C")]
		public static ConnectionHeadingEnum ResolveAuto(this ConnectionHeadingEnum heading, CurvySplineSegment followUp)
		{
			return default(ConnectionHeadingEnum);
		}
	}
	[Token(Token = "0x2000075")]
	public enum CurvyUpdateMethod
	{
		[Token(Token = "0x400015C")]
		Update,
		[Token(Token = "0x400015D")]
		LateUpdate,
		[Token(Token = "0x400015E")]
		FixedUpdate
	}
	[Token(Token = "0x2000076")]
	public enum CurvyRepeatingOrderEnum
	{
		[Token(Token = "0x4000160")]
		Random,
		[Token(Token = "0x4000161")]
		Row
	}
	[Token(Token = "0x2000077")]
	public enum CurvyPlane
	{
		[Token(Token = "0x4000163")]
		XY,
		[Token(Token = "0x4000164")]
		XZ,
		[Token(Token = "0x4000165")]
		YZ
	}
	[Token(Token = "0x2000078")]
	public enum CurvyPositionMode
	{
		[Token(Token = "0x4000167")]
		Relative,
		[Token(Token = "0x4000168")]
		WorldUnits
	}
	[Token(Token = "0x2000079")]
	[Flags]
	public enum CurvyBezierModeEnum
	{
		[Token(Token = "0x400016A")]
		None = 0,
		[Token(Token = "0x400016B")]
		Direction = 1,
		[Token(Token = "0x400016C")]
		Length = 2,
		[Token(Token = "0x400016D")]
		Connections = 4,
		[Token(Token = "0x400016E")]
		Combine = 8
	}
	[Token(Token = "0x200007A")]
	public enum CurvyAdvBezierModeEnum
	{
		[Token(Token = "0x4000170")]
		None = 0,
		[Token(Token = "0x4000171")]
		Direction = 1,
		[Token(Token = "0x4000172")]
		Length = 2,
		[Token(Token = "0x4000173")]
		Combine = 8
	}
	[Token(Token = "0x200007B")]
	public enum CurvyInterpolation
	{
		[Token(Token = "0x4000175")]
		Linear,
		[Token(Token = "0x4000176")]
		CatmullRom,
		[Token(Token = "0x4000177")]
		TCB,
		[Token(Token = "0x4000178")]
		Bezier
	}
	[Token(Token = "0x200007C")]
	public enum CurvyClamping
	{
		[Token(Token = "0x400017A")]
		Clamp,
		[Token(Token = "0x400017B")]
		Loop,
		[Token(Token = "0x400017C")]
		PingPong
	}
	[Token(Token = "0x200007D")]
	public enum CurvyOrientation
	{
		[Token(Token = "0x400017E")]
		None,
		[Token(Token = "0x400017F")]
		Dynamic,
		[Token(Token = "0x4000180")]
		Static
	}
	[Token(Token = "0x200007E")]
	public enum CurvyOrientationSwirl
	{
		[Token(Token = "0x4000182")]
		None,
		[Token(Token = "0x4000183")]
		Segment,
		[Token(Token = "0x4000184")]
		AnchorGroup,
		[Token(Token = "0x4000185")]
		AnchorGroupAbs
	}
	[Token(Token = "0x200007F")]
	public enum CurvySplineGizmos
	{
		[Token(Token = "0x4000187")]
		None = 0,
		[Token(Token = "0x4000188")]
		Curve = 2,
		[Token(Token = "0x4000189")]
		Approximation = 4,
		[Token(Token = "0x400018A")]
		Tangents = 8,
		[Token(Token = "0x400018B")]
		Orientation = 16,
		[Token(Token = "0x400018C")]
		Labels = 32,
		[Token(Token = "0x400018D")]
		Metadata = 64,
		[Token(Token = "0x400018E")]
		Bounds = 128,
		[Token(Token = "0x400018F")]
		All = 65535
	}
	[Token(Token = "0x2000080")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x8649DC", Offset = "0x8649DC")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x8649DC", Offset = "0x8649DC")]
	public class CurvyConnection : MonoBehaviour, ISerializationCallbackReceiver
	{
		[Token(Token = "0x2000176")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x867A94", Offset = "0x867A94")]
		private sealed class <>c__DisplayClass19_0
		{
			[Token(Token = "0x4000654")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CurvySplineSegment controlPoint;

			[Token(Token = "0x6000D10")]
			[Address(RVA = "0x18165A8", Offset = "0x18165A8", VA = "0x18165A8")]
			public <>c__DisplayClass19_0()
			{
			}

			[Token(Token = "0x6000D11")]
			[Address(RVA = "0x18165B0", Offset = "0x18165B0", VA = "0x18165B0")]
			internal bool <RemoveControlPoint>b__0(ControlPointCoordinates element)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000177")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x867AA4", Offset = "0x867AA4")]
		private sealed class <>c__DisplayClass22_0
		{
			[Token(Token = "0x4000655")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CurvySplineSegment controlPoint;

			[Token(Token = "0x6000D12")]
			[Address(RVA = "0x18165D4", Offset = "0x18165D4", VA = "0x18165D4")]
			public <>c__DisplayClass22_0()
			{
			}

			[Token(Token = "0x6000D13")]
			[Address(RVA = "0x18165DC", Offset = "0x18165DC", VA = "0x18165DC")]
			internal bool <SetSynchronisationPositionAndRotation>b__0(ControlPointCoordinates element)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000178")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x867AB4", Offset = "0x867AB4")]
		private sealed class <>c__DisplayClass23_0
		{
			[Token(Token = "0x4000656")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CurvySplineSegment controlPoint;

			[Token(Token = "0x6000D14")]
			[Address(RVA = "0x1816600", Offset = "0x1816600", VA = "0x1816600")]
			public <>c__DisplayClass23_0()
			{
			}

			[Token(Token = "0x6000D15")]
			[Address(RVA = "0x1816608", Offset = "0x1816608", VA = "0x1816608")]
			internal bool <DoUpdate>b__0(ControlPointCoordinates element)
			{
				return default(bool);
			}
		}

		[Serializable]
		[Token(Token = "0x2000179")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x867AC4", Offset = "0x867AC4")]
		private sealed class <>c
		{
			[Token(Token = "0x4000657")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000658")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Predicate<CurvySplineSegment> <>9__24_0;

			[Token(Token = "0x4000659")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Predicate<CurvySplineSegment> <>9__26_0;

			[Token(Token = "0x400065A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Predicate<CurvySplineSegment> <>9__27_0;

			[Token(Token = "0x6000D17")]
			[Address(RVA = "0x181651C", Offset = "0x181651C", VA = "0x181651C")]
			public <>c()
			{
			}

			[Token(Token = "0x6000D18")]
			[Address(RVA = "0x1816524", Offset = "0x1816524", VA = "0x1816524")]
			internal bool <OnSceneLoaded>b__24_0(CurvySplineSegment cp)
			{
				return default(bool);
			}

			[Token(Token = "0x6000D19")]
			[Address(RVA = "0x1816590", Offset = "0x1816590", VA = "0x1816590")]
			internal bool <OnBeforeSerialize>b__26_0(CurvySplineSegment cp)
			{
				return default(bool);
			}

			[Token(Token = "0x6000D1A")]
			[Address(RVA = "0x181659C", Offset = "0x181659C", VA = "0x181659C")]
			internal bool <OnAfterDeserialize>b__27_0(CurvySplineSegment cp)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Hide]
		private List<CurvySplineSegment> m_ControlPoints;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ReadOnlyCollection<CurvySplineSegment> readOnlyControlPoints;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Couple<Vector3, Quaternion> processedConnectionCoordinates;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Hide]
		private List<ControlPointCoordinates> processedControlPointsCoordinates;

		[Token(Token = "0x1700008C")]
		public ReadOnlyCollection<CurvySplineSegment> ControlPointsList
		{
			[Token(Token = "0x6000404")]
			[Address(RVA = "0x10ACE88", Offset = "0x10ACE88", VA = "0x10ACE88")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008D")]
		public int Count
		{
			[Token(Token = "0x6000405")]
			[Address(RVA = "0x10ACEF0", Offset = "0x10ACEF0", VA = "0x10ACEF0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700008E")]
		public CurvySplineSegment Item
		{
			[Token(Token = "0x6000406")]
			[Address(RVA = "0x10ACF40", Offset = "0x10ACF40", VA = "0x10ACF40")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x10ACFB8", Offset = "0x10ACFB8", VA = "0x10ACFB8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x10AD1F8", Offset = "0x10AD1F8", VA = "0x10AD1F8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x10AD294", Offset = "0x10AD294", VA = "0x10AD294")]
		private void Update()
		{
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x10AD818", Offset = "0x10AD818", VA = "0x10AD818")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x10AD850", Offset = "0x10AD850", VA = "0x10AD850")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x10AD888", Offset = "0x10AD888", VA = "0x10AD888")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x10AD9E8", Offset = "0x10AD9E8", VA = "0x10AD9E8")]
		public static CurvyConnection Create(params CurvySplineSegment[] controlPoints)
		{
			return null;
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x10ADB84", Offset = "0x10ADB84", VA = "0x10ADB84")]
		public void AddControlPoints(params CurvySplineSegment[] controlPoints)
		{
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x10ADD34", Offset = "0x10ADD34", VA = "0x10ADD34")]
		public void AutoSetFollowUp()
		{
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x10ADFC4", Offset = "0x10ADFC4", VA = "0x10ADFC4")]
		public void RemoveControlPoint(CurvySplineSegment controlPoint, bool destroySelfIfEmpty = true)
		{
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x10AE1F0", Offset = "0x10AE1F0", VA = "0x10AE1F0")]
		public void Delete()
		{
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x10AE284", Offset = "0x10AE284", VA = "0x10AE284")]
		public List<CurvySplineSegment> OtherControlPoints(CurvySplineSegment source)
		{
			return null;
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x10AE320", Offset = "0x10AE320", VA = "0x10AE320")]
		public void SetSynchronisationPositionAndRotation(Vector3 referencePosition, Quaternion referenceRotation)
		{
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x10AD2CC", Offset = "0x10AD2CC", VA = "0x10AD2CC")]
		private void DoUpdate()
		{
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x10AE67C", Offset = "0x10AE67C", VA = "0x10AE67C")]
		private void OnSceneLoaded(Scene arg0, LoadSceneMode arg1)
		{
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x10AD05C", Offset = "0x10AD05C", VA = "0x10AD05C")]
		private void ResetProcessedCoordinates()
		{
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x10AE800", Offset = "0x10AE800", VA = "0x10AE800", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x10AE8F8", Offset = "0x10AE8F8", VA = "0x10AE8F8", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x10AE9F0", Offset = "0x10AE9F0", VA = "0x10AE9F0")]
		public CurvyConnection()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000081")]
	internal class ControlPointCoordinates
	{
		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		internal CurvySplineSegment ControlPoint;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		internal Vector3 Position;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		internal Quaternion Rotation;

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x10A82D0", Offset = "0x10A82D0", VA = "0x10A82D0")]
		internal ControlPointCoordinates(CurvySplineSegment controlPoint)
		{
		}
	}
	[Token(Token = "0x2000082")]
	public class CurvyEventArgs : EventArgs
	{
		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly MonoBehaviour Sender;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly object Data;

		[Token(Token = "0x600041B")]
		[Address(RVA = "0x15B8870", Offset = "0x15B8870", VA = "0x15B8870")]
		public CurvyEventArgs(MonoBehaviour sender, object data)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000083")]
	public class CurvySplineEvent : UnityEventEx<CurvySplineEventArgs>
	{
		[Token(Token = "0x600041C")]
		[Address(RVA = "0x15C18A4", Offset = "0x15C18A4", VA = "0x15C18A4")]
		public CurvySplineEvent()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000084")]
	public class CurvyControlPointEvent : UnityEventEx<CurvyControlPointEventArgs>
	{
		[Token(Token = "0x600041D")]
		[Address(RVA = "0x10AEA88", Offset = "0x10AEA88", VA = "0x10AEA88")]
		public CurvyControlPointEvent()
		{
		}
	}
	[Token(Token = "0x2000085")]
	public class CurvyControlPointEventArgs : CurvySplineEventArgs
	{
		[Token(Token = "0x200017A")]
		public enum ModeEnum
		{
			[Token(Token = "0x400065C")]
			None,
			[Token(Token = "0x400065D")]
			AddBefore,
			[Token(Token = "0x400065E")]
			AddAfter,
			[Token(Token = "0x400065F")]
			Delete
		}

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly ModeEnum Mode;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public readonly CurvySplineSegment ControlPoint;

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x10AEAD8", Offset = "0x10AEAD8", VA = "0x10AEAD8")]
		public CurvyControlPointEventArgs(MonoBehaviour sender, CurvySpline spline, CurvySplineSegment cp, ModeEnum mode = ModeEnum.None, [Optional] object data)
		{
		}
	}
	[Token(Token = "0x2000086")]
	public class CurvySplineEventArgs : CurvyEventArgs
	{
		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly CurvySpline Spline;

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x15C18F4", Offset = "0x15C18F4", VA = "0x15C18F4")]
		public CurvySplineEventArgs(MonoBehaviour sender, CurvySpline spline, [Optional] object data)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000087")]
	public class CurvyCGEvent : UnityEventEx<CurvyCGEventArgs>
	{
		[Token(Token = "0x6000420")]
		[Address(RVA = "0x10ACA30", Offset = "0x10ACA30", VA = "0x10ACA30")]
		public CurvyCGEvent()
		{
		}
	}
	[Token(Token = "0x2000088")]
	public class CurvyCGEventArgs : EventArgs
	{
		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly MonoBehaviour Sender;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly CurvyGenerator Generator;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly CGModule Module;

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x10ACA80", Offset = "0x10ACA80", VA = "0x10ACA80")]
		public CurvyCGEventArgs(CGModule module)
		{
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x10ACB0C", Offset = "0x10ACB0C", VA = "0x10ACB0C")]
		public CurvyCGEventArgs(CurvyGenerator generator, CGModule module)
		{
		}
	}
	[Token(Token = "0x2000089")]
	public static class CurvyGizmoHelper
	{
		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Matrix4x4 Matrix;

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x15BBE8C", Offset = "0x15BBE8C", VA = "0x15BBE8C")]
		public static void SegmentCurveGizmo(CurvySplineSegment seg, Color col, float stepSize = 0.05f)
		{
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0x15BC0D0", Offset = "0x15BC0D0", VA = "0x15BC0D0")]
		public static void SegmentApproximationGizmo(CurvySplineSegment seg, Color col)
		{
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0x15BC3A8", Offset = "0x15BC3A8", VA = "0x15BC3A8")]
		public static void SegmentOrientationAnchorGizmo(CurvySplineSegment seg, Color col)
		{
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0x15BC604", Offset = "0x15BC604", VA = "0x15BC604")]
		public static void SegmentOrientationGizmo(CurvySplineSegment seg, Color col)
		{
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x15BC8A4", Offset = "0x15BC8A4", VA = "0x15BC8A4")]
		public static void SegmentTangentGizmo(CurvySplineSegment seg, Color col)
		{
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x15BCAF4", Offset = "0x15BCAF4", VA = "0x15BCAF4")]
		public static void ControlPointGizmo(CurvySplineSegment cp, bool selected, Color col)
		{
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x15BCE8C", Offset = "0x15BCE8C", VA = "0x15BCE8C")]
		public static void BoundsGizmo(CurvySplineSegment cp, Color col)
		{
		}
	}
	[Token(Token = "0x200008A")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x864A4C", Offset = "0x864A4C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x864A4C", Offset = "0x864A4C")]
	public class CurvyGlobalManager : DTSingleton<CurvyGlobalManager>
	{
		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool HideManager;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static float SceneViewResolution;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Color DefaultGizmoColor;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Color DefaultGizmoSelectionColor;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static CurvyInterpolation DefaultInterpolation;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public static float GizmoControlPointSize;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static float GizmoOrientationLength;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public static Color GizmoOrientationColor;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public static int SplineLayer;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static CurvySplineGizmos Gizmos;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private PoolManager mPoolManager;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ComponentPool mControlPointPool;

		[Token(Token = "0x1700008F")]
		public static bool ShowCurveGizmo
		{
			[Token(Token = "0x600042B")]
			[Address(RVA = "0x15BD0A4", Offset = "0x15BD0A4", VA = "0x15BD0A4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600042C")]
			[Address(RVA = "0x15BD110", Offset = "0x15BD110", VA = "0x15BD110")]
			set
			{
			}
		}

		[Token(Token = "0x17000090")]
		public static bool ShowApproximationGizmo
		{
			[Token(Token = "0x600042D")]
			[Address(RVA = "0x15BD1AC", Offset = "0x15BD1AC", VA = "0x15BD1AC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600042E")]
			[Address(RVA = "0x15BD218", Offset = "0x15BD218", VA = "0x15BD218")]
			set
			{
			}
		}

		[Token(Token = "0x17000091")]
		public static bool ShowTangentsGizmo
		{
			[Token(Token = "0x600042F")]
			[Address(RVA = "0x15BD2B4", Offset = "0x15BD2B4", VA = "0x15BD2B4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000430")]
			[Address(RVA = "0x15BD320", Offset = "0x15BD320", VA = "0x15BD320")]
			set
			{
			}
		}

		[Token(Token = "0x17000092")]
		public static bool ShowOrientationGizmo
		{
			[Token(Token = "0x6000431")]
			[Address(RVA = "0x15BD3BC", Offset = "0x15BD3BC", VA = "0x15BD3BC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000432")]
			[Address(RVA = "0x15BD428", Offset = "0x15BD428", VA = "0x15BD428")]
			set
			{
			}
		}

		[Token(Token = "0x17000093")]
		public static bool ShowLabelsGizmo
		{
			[Token(Token = "0x6000433")]
			[Address(RVA = "0x15BD4C4", Offset = "0x15BD4C4", VA = "0x15BD4C4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000434")]
			[Address(RVA = "0x15BD530", Offset = "0x15BD530", VA = "0x15BD530")]
			set
			{
			}
		}

		[Token(Token = "0x17000094")]
		public static bool ShowMetadataGizmo
		{
			[Token(Token = "0x6000435")]
			[Address(RVA = "0x15BD5CC", Offset = "0x15BD5CC", VA = "0x15BD5CC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000436")]
			[Address(RVA = "0x15BD638", Offset = "0x15BD638", VA = "0x15BD638")]
			set
			{
			}
		}

		[Token(Token = "0x17000095")]
		public static bool ShowBoundsGizmo
		{
			[Token(Token = "0x6000437")]
			[Address(RVA = "0x15BD6D4", Offset = "0x15BD6D4", VA = "0x15BD6D4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000438")]
			[Address(RVA = "0x15BD740", Offset = "0x15BD740", VA = "0x15BD740")]
			set
			{
			}
		}

		[Token(Token = "0x17000096")]
		public PoolManager PoolManager
		{
			[Token(Token = "0x6000439")]
			[Address(RVA = "0x15BD7DC", Offset = "0x15BD7DC", VA = "0x15BD7DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000097")]
		public ComponentPool ControlPointPool
		{
			[Token(Token = "0x600043A")]
			[Address(RVA = "0x15BD874", Offset = "0x15BD874", VA = "0x15BD874")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000098")]
		public CurvyConnection[] Connections
		{
			[Token(Token = "0x600043B")]
			[Address(RVA = "0x15BD87C", Offset = "0x15BD87C", VA = "0x15BD87C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0x15BD8CC", Offset = "0x15BD8CC", VA = "0x15BD8CC")]
		public CurvyConnection[] GetContainingConnections(params CurvySpline[] splines)
		{
			return null;
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0x15BE068", Offset = "0x15BE068", VA = "0x15BE068", Slot = "5")]
		public override void Awake()
		{
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0x15BE1D0", Offset = "0x15BE1D0", VA = "0x15BE1D0")]
		private void Start()
		{
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0x15BE264", Offset = "0x15BE264", VA = "0x15BE264")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x876F48", Offset = "0x876F48")]
		private static void LoadRuntimeSettings()
		{
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0x15BE4EC", Offset = "0x15BE4EC", VA = "0x15BE4EC")]
		public static void SaveRuntimeSettings()
		{
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0x15BE6D0", Offset = "0x15BE6D0", VA = "0x15BE6D0", Slot = "7")]
		public override void MergeDoubleLoaded(IDTSingleton newInstance)
		{
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0x15BE7EC", Offset = "0x15BE7EC", VA = "0x15BE7EC")]
		public CurvyGlobalManager()
		{
		}
	}
	[Token(Token = "0x200008B")]
	[ExecuteInEditMode]
	public abstract class CurvyInterpolatableMetadataBase<T> : CurvyMetadataBase
	{
		[Token(Token = "0x17000099")]
		public abstract T MetaDataValue
		{
			[Token(Token = "0x6000444")]
			get;
		}

		[Token(Token = "0x6000445")]
		public abstract T Interpolate(CurvyInterpolatableMetadataBase<T> nextMetadata, float interpolationTime);

		[Token(Token = "0x6000446")]
		protected CurvyInterpolatableMetadataBase()
		{
		}
	}
	[Token(Token = "0x200008C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x864AF4", Offset = "0x864AF4")]
	[ExecuteInEditMode]
	public abstract class CurvyMetadataBase : MonoBehaviour
	{
		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CurvySplineSegment mCP;

		[Token(Token = "0x1700009A")]
		public CurvySplineSegment ControlPoint
		{
			[Token(Token = "0x6000447")]
			[Address(RVA = "0x15BF1D8", Offset = "0x15BF1D8", VA = "0x15BF1D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009B")]
		public CurvySpline Spline
		{
			[Token(Token = "0x6000448")]
			[Address(RVA = "0x15BF1E0", Offset = "0x15BF1E0", VA = "0x15BF1E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0x15BF26C", Offset = "0x15BF26C", VA = "0x15BF26C", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x15BF2D4", Offset = "0x15BF2D4", VA = "0x15BF2D4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600044B")]
		public T GetPreviousData<T>(bool autoCreate = true, bool segmentsOnly = true, bool useFollowUp = false) where T : CurvyMetadataBase
		{
			return null;
		}

		[Token(Token = "0x600044C")]
		public T GetNextData<T>(bool autoCreate = true, bool segmentsOnly = true, bool useFollowUp = false) where T : CurvyMetadataBase
		{
			return null;
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0x15BF2F4", Offset = "0x15BF2F4", VA = "0x15BF2F4")]
		protected void NotifyModification()
		{
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0x15BF398", Offset = "0x15BF398", VA = "0x15BF398")]
		protected CurvyMetadataBase()
		{
		}
	}
	[Token(Token = "0x200008D")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x864B68", Offset = "0x864B68")]
	public class CGResourceManagerAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public readonly string ResourceName;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool ReadOnly;

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x109B8D4", Offset = "0x109B8D4", VA = "0x109B8D4")]
		public CGResourceManagerAttribute(string resourceName)
		{
		}
	}
	[Token(Token = "0x200008E")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x864BA0", Offset = "0x864BA0")]
	public sealed class CGResourceCollectionManagerAttribute : CGResourceManagerAttribute
	{
		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		public bool ShowCount;

		[Token(Token = "0x6000450")]
		[Address(RVA = "0x109B8AC", Offset = "0x109B8AC", VA = "0x109B8AC")]
		public CGResourceCollectionManagerAttribute(string resourceName)
		{
		}
	}
	[Token(Token = "0x200008F")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x864BD8", Offset = "0x864BD8")]
	public sealed class CGDataReferenceSelectorAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public readonly Type DataType;

		[Token(Token = "0x6000451")]
		[Address(RVA = "0x13AA828", Offset = "0x13AA828", VA = "0x13AA828")]
		public CGDataReferenceSelectorAttribute(Type dataType)
		{
		}
	}
	[Token(Token = "0x2000090")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x864C10", Offset = "0x864C10")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x864C10", Offset = "0x864C10")]
	public class CurvyShape : DTVersionedMonoBehaviour
	{
		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x868838", Offset = "0x868838")]
		private CurvyPlane m_Plane;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		[HideInInspector]
		private bool m_Persistent;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Dictionary<CurvyShapeInfo, Type> mShapeDefs;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private CurvySpline mSpline;

		[NonSerialized]
		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool Dirty;

		[Token(Token = "0x1700009C")]
		public CurvyPlane Plane
		{
			[Token(Token = "0x6000452")]
			[Address(RVA = "0x15BF3A0", Offset = "0x15BF3A0", VA = "0x15BF3A0")]
			get
			{
				return default(CurvyPlane);
			}
			[Token(Token = "0x6000453")]
			[Address(RVA = "0x15BF3A8", Offset = "0x15BF3A8", VA = "0x15BF3A8")]
			set
			{
			}
		}

		[Token(Token = "0x1700009D")]
		public bool Persistent
		{
			[Token(Token = "0x6000454")]
			[Address(RVA = "0x15BF3C4", Offset = "0x15BF3C4", VA = "0x15BF3C4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000455")]
			[Address(RVA = "0x15BF3CC", Offset = "0x15BF3CC", VA = "0x15BF3CC")]
			set
			{
			}
		}

		[Token(Token = "0x1700009E")]
		public CurvySpline Spline
		{
			[Token(Token = "0x6000456")]
			[Address(RVA = "0x15BF400", Offset = "0x15BF400", VA = "0x15BF400")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009F")]
		public static Dictionary<CurvyShapeInfo, Type> ShapeDefinitions
		{
			[Token(Token = "0x6000466")]
			[Address(RVA = "0x15C0A68", Offset = "0x15C0A68", VA = "0x15C0A68")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0x15BF494", Offset = "0x15BF494", VA = "0x15BF494")]
		private void Update()
		{
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0x15BF5C8", Offset = "0x15BF5C8", VA = "0x15BF5C8", Slot = "4")]
		protected virtual void Reset()
		{
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x15BF5E0", Offset = "0x15BF5E0", VA = "0x15BF5E0")]
		public void Delete()
		{
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0x15BF4D4", Offset = "0x15BF4D4", VA = "0x15BF4D4")]
		public void Refresh()
		{
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0x15BF764", Offset = "0x15BF764", VA = "0x15BF764")]
		public CurvyShape Replace(string menuName)
		{
			return null;
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0x15BFA68", Offset = "0x15BFA68", VA = "0x15BFA68")]
		protected void PrepareSpline(CurvyInterpolation interpolation, CurvyOrientation orientation = CurvyOrientation.Dynamic, int cachedensity = 50, bool closed = true)
		{
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0x15BFD58", Offset = "0x15BFD58", VA = "0x15BFD58")]
		protected void SetPosition(int no, Vector3 position)
		{
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0x15BFE00", Offset = "0x15BFE00", VA = "0x15BFE00")]
		protected void SetRotation(int no, Quaternion rotation)
		{
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0x15BFEB0", Offset = "0x15BFEB0", VA = "0x15BFEB0")]
		protected void SetBezierHandles(int no, float distanceFrag)
		{
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0x15BFEB8", Offset = "0x15BFEB8", VA = "0x15BFEB8")]
		protected void SetBezierHandles(int no, float inDistanceFrag, float outDistanceFrag)
		{
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0x15C0198", Offset = "0x15C0198", VA = "0x15C0198")]
		protected void SetBezierHandles(int no, Vector3 i, Vector3 o, Space space = Space.World)
		{
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0x15C00F4", Offset = "0x15C00F4", VA = "0x15C00F4")]
		public static void SetBezierHandles(float distanceFrag, bool setIn, bool setOut, params CurvySplineSegment[] controlPoints)
		{
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0x15C02F4", Offset = "0x15C02F4", VA = "0x15C02F4")]
		protected void SetCGHardEdges(params int[] controlPoints)
		{
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0x15C045C", Offset = "0x15C045C", VA = "0x15C045C", Slot = "5")]
		protected virtual void ApplyShape()
		{
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0x15C0460", Offset = "0x15C0460", VA = "0x15C0460")]
		protected void PrepareControlPoints(int count)
		{
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0x15C0B84", Offset = "0x15C0B84", VA = "0x15C0B84")]
		public static List<string> GetShapesMenuNames(bool only2D = false)
		{
			return null;
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0x15C0D18", Offset = "0x15C0D18", VA = "0x15C0D18")]
		public static List<string> GetShapesMenuNames(Type currentShapeType, out int currentIndex, bool only2D = false)
		{
			return null;
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0x15C0F7C", Offset = "0x15C0F7C", VA = "0x15C0F7C")]
		public static string GetShapeName(Type shapeType)
		{
			return null;
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0x15BF8D4", Offset = "0x15BF8D4", VA = "0x15BF8D4")]
		public static Type GetShapeType(string menuName)
		{
			return null;
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0x15BF648", Offset = "0x15BF648", VA = "0x15BF648")]
		private void applyPlane()
		{
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0x15C10E8", Offset = "0x15C10E8", VA = "0x15C10E8")]
		private void applyRotation(Quaternion q)
		{
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0x15C1414", Offset = "0x15C1414", VA = "0x15C1414")]
		public CurvyShape()
		{
		}
	}
	[Token(Token = "0x2000091")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x864CA8", Offset = "0x864CA8")]
	public sealed class CurvyShapeInfo : Attribute
	{
		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly string Name;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly bool Is2D;

		[Token(Token = "0x600046F")]
		[Address(RVA = "0x15C1508", Offset = "0x15C1508", VA = "0x15C1508")]
		public CurvyShapeInfo(string name, bool is2D = true)
		{
		}
	}
	[Token(Token = "0x2000092")]
	public class CurvyShape2D : CurvyShape
	{
		[Token(Token = "0x6000470")]
		[Address(RVA = "0x15C1498", Offset = "0x15C1498", VA = "0x15C1498")]
		public CurvyShape2D()
		{
		}
	}
	[Token(Token = "0x2000093")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x864CE0", Offset = "0x864CE0")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x864CE0", Offset = "0x864CE0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x864CE0", Offset = "0x864CE0")]
	[ExecuteInEditMode]
	public class CurvySpline : DTVersionedMonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200017B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x867AD4", Offset = "0x867AD4")]
		private sealed class <>c
		{
			[Token(Token = "0x4000660")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000661")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Action<CurvySplineSegment> <>9__4_0;

			[Token(Token = "0x4000662")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Action<CurvySplineSegment> <>9__290_0;

			[Token(Token = "0x6000D1C")]
			[Address(RVA = "0x18167FC", Offset = "0x18167FC", VA = "0x18167FC")]
			public <>c()
			{
			}

			[Token(Token = "0x6000D1D")]
			[Address(RVA = "0x1816804", Offset = "0x1816804", VA = "0x1816804")]
			internal void <.ctor>b__4_0(CurvySplineSegment controlPoint)
			{
			}

			[Token(Token = "0x6000D1E")]
			[Address(RVA = "0x1816820", Offset = "0x1816820", VA = "0x1816820")]
			internal void <ProcessDirtyControlPoints>b__290_0(CurvySplineSegment controlPoint)
			{
			}
		}

		[Token(Token = "0x40001B8")]
		public const string VERSION = "7.1.3";

		[Token(Token = "0x40001B9")]
		public const string APIVERSION = "710";

		[Token(Token = "0x40001BA")]
		public const string WEBROOT = "https://curvyeditor.com/";

		[Token(Token = "0x40001BB")]
		public const string DOCLINK = "https://curvyeditor.com/doclink/";

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[HideInInspector]
		private List<CurvySplineSegment> ControlPoints;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public bool ShowGizmos;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x868918", Offset = "0x868918")]
		private Action<CurvySpline> <OnGlobalCoordinatesChanged>k__BackingField;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x868928", Offset = "0x868928")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x868928", Offset = "0x868928")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x868928", Offset = "0x868928")]
		private CurvyInterpolation m_Interpolation;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8689D8", Offset = "0x8689D8")]
		[AttributeAttribute(Name = "FieldActionAttribute", RVA = "0x8689D8", Offset = "0x8689D8")]
		[SerializeField]
		private bool m_RestrictTo2D;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x868A4C", Offset = "0x868A4C")]
		private bool m_Closed;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3E")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x868A98", Offset = "0x868A98")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x868A98", Offset = "0x868A98")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x868A98", Offset = "0x868A98")]
		private bool m_AutoEndTangents;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x868B34", Offset = "0x868B34")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x868B34", Offset = "0x868B34")]
		private CurvyOrientation m_Orientation;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x868BA4", Offset = "0x868BA4")]
		[AttributeAttribute(Name = "GroupConditionAttribute", RVA = "0x868BA4", Offset = "0x868BA4")]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x868BA4", Offset = "0x868BA4")]
		[SerializeField]
		private float m_AutoHandleDistance;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x868CCC", Offset = "0x868CCC")]
		[AttributeAttribute(Name = "GroupConditionAttribute", RVA = "0x868CCC", Offset = "0x868CCC")]
		[AttributeAttribute(Name = "GroupActionAttribute", RVA = "0x868CCC", Offset = "0x868CCC")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x868CCC", Offset = "0x868CCC")]
		private float m_Tension;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x868E10", Offset = "0x868E10")]
		private float m_Continuity;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x868E5C", Offset = "0x868E5C")]
		private float m_Bias;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x868EA8", Offset = "0x868EA8")]
		[AttributeAttribute(Name = "FieldActionAttribute", RVA = "0x868EA8", Offset = "0x868EA8")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x868EA8", Offset = "0x868EA8")]
		[SerializeField]
		private Color m_GizmoColor;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x868F7C", Offset = "0x868F7C")]
		[SerializeField]
		private Color m_GizmoSelectionColor;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x868FE4", Offset = "0x868FE4")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x868FE4", Offset = "0x868FE4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x868FE4", Offset = "0x868FE4")]
		private int m_CacheDensity;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8690A0", Offset = "0x8690A0")]
		private float m_MaxPointsPerUnit;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8690EC", Offset = "0x8690EC")]
		private bool m_UsePooling;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7D")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x869138", Offset = "0x869138")]
		private bool m_UseThreading;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7E")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x869184", Offset = "0x869184")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x869184", Offset = "0x869184")]
		private bool m_CheckTransform;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private CurvyUpdateMethod m_UpdateIn;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x869204", Offset = "0x869204")]
		[AttributeAttribute(Name = "SortOrderAttribute", RVA = "0x869204", Offset = "0x869204")]
		[SerializeField]
		protected CurvySplineEvent m_OnRefresh;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x869280", Offset = "0x869280")]
		[AttributeAttribute(Name = "SortOrderAttribute", RVA = "0x869280", Offset = "0x869280")]
		[SerializeField]
		protected CurvySplineEvent m_OnAfterControlPointChanges;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x8692E8", Offset = "0x8692E8")]
		[AttributeAttribute(Name = "SortOrderAttribute", RVA = "0x8692E8", Offset = "0x8692E8")]
		[SerializeField]
		protected CurvyControlPointEvent m_OnBeforeControlPointAdd;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x869350", Offset = "0x869350")]
		[AttributeAttribute(Name = "SortOrderAttribute", RVA = "0x869350", Offset = "0x869350")]
		[SerializeField]
		protected CurvyControlPointEvent m_OnAfterControlPointAdd;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x8693B8", Offset = "0x8693B8")]
		[AttributeAttribute(Name = "SortOrderAttribute", RVA = "0x8693B8", Offset = "0x8693B8")]
		[SerializeField]
		protected CurvyControlPointEvent m_OnBeforeControlPointDelete;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private bool mIsInitialized;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB1")]
		private bool isStarted;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB2")]
		private bool sendOnRefreshEventNextUpdate;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private readonly object controlPointsRelationshipCacheLock;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private List<CurvySplineSegment> mSegments;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private ReadOnlyCollection<CurvySplineSegment> readOnlyControlPoints;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float length;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private int mCacheSize;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Bounds? mBounds;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private bool mDirtyCurve;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF5")]
		private bool mDirtyOrientation;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private HashSet<CurvySplineSegment> dirtyControlPointsMinimalSet;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private List<CurvySplineSegment> dirtyCpsExtendedList;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private bool allControlPointsAreDirty;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private ThreadPoolWorker<CurvySplineSegment> mThreadWorker;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private readonly CurvySplineEventArgs defaultSplineEventArgs;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private readonly CurvyControlPointEventArgs defaultAddAfterEventArgs;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private readonly CurvyControlPointEventArgs defaultDeleteEventArgs;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private float[] controlPointsDistances;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private readonly Action<CurvySplineSegment> refreshCurveAction;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector3 lastProcessedPosition;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		private Quaternion lastProcessedRotation;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
		private Vector3 lastProcessedScale;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private bool globalCoordinatesChangedThisFrame;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x169")]
		private bool isCpsRelationshipCacheValid;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private CurvySplineSegment firstSegment;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private CurvySplineSegment lastSegment;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private CurvySplineSegment firstVisibleControlPoint;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private CurvySplineSegment lastVisibleControlPoint;

		[Token(Token = "0x40001F2")]
		private const float MinimalMaxPointsPerUnit = 0.0001f;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly string InvalidCPErrorMessage;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private Transform cachedTransform;

		[Token(Token = "0x170000A0")]
		public CurvyInterpolation Interpolation
		{
			[Token(Token = "0x6000472")]
			[Address(RVA = "0x15C1920", Offset = "0x15C1920", VA = "0x15C1920")]
			get
			{
				return default(CurvyInterpolation);
			}
			[Token(Token = "0x6000473")]
			[Address(RVA = "0x15BFBB8", Offset = "0x15BFBB8", VA = "0x15BFBB8")]
			set
			{
			}
		}

		[Token(Token = "0x170000A1")]
		public bool RestrictTo2D
		{
			[Token(Token = "0x6000474")]
			[Address(RVA = "0x15C1C90", Offset = "0x15C1C90", VA = "0x15C1C90")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000475")]
			[Address(RVA = "0x15BFD2C", Offset = "0x15BFD2C", VA = "0x15BFD2C")]
			set
			{
			}
		}

		[Token(Token = "0x170000A2")]
		public float AutoHandleDistance
		{
			[Token(Token = "0x6000476")]
			[Address(RVA = "0x15C1C98", Offset = "0x15C1C98", VA = "0x15C1C98")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000477")]
			[Address(RVA = "0x15C1CA0", Offset = "0x15C1CA0", VA = "0x15C1CA0")]
			set
			{
			}
		}

		[Token(Token = "0x170000A3")]
		public bool Closed
		{
			[Token(Token = "0x6000478")]
			[Address(RVA = "0x15C1D44", Offset = "0x15C1D44", VA = "0x15C1D44")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000479")]
			[Address(RVA = "0x15BFCD4", Offset = "0x15BFCD4", VA = "0x15BFCD4")]
			set
			{
			}
		}

		[Token(Token = "0x170000A4")]
		public bool AutoEndTangents
		{
			[Token(Token = "0x600047A")]
			[Address(RVA = "0x15C1D4C", Offset = "0x15C1D4C", VA = "0x15C1D4C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600047B")]
			[Address(RVA = "0x15C1C10", Offset = "0x15C1C10", VA = "0x15C1C10")]
			set
			{
			}
		}

		[Token(Token = "0x170000A5")]
		public CurvyOrientation Orientation
		{
			[Token(Token = "0x600047C")]
			[Address(RVA = "0x15C1D78", Offset = "0x15C1D78", VA = "0x15C1D78")]
			get
			{
				return default(CurvyOrientation);
			}
			[Token(Token = "0x600047D")]
			[Address(RVA = "0x15BFC04", Offset = "0x15BFC04", VA = "0x15BFC04")]
			set
			{
			}
		}

		[Token(Token = "0x170000A6")]
		public CurvyUpdateMethod UpdateIn
		{
			[Token(Token = "0x600047E")]
			[Address(RVA = "0x15C1D80", Offset = "0x15C1D80", VA = "0x15C1D80")]
			get
			{
				return default(CurvyUpdateMethod);
			}
			[Token(Token = "0x600047F")]
			[Address(RVA = "0x15C1D88", Offset = "0x15C1D88", VA = "0x15C1D88")]
			set
			{
			}
		}

		[Token(Token = "0x170000A7")]
		public Color GizmoColor
		{
			[Token(Token = "0x6000480")]
			[Address(RVA = "0x15C1D9C", Offset = "0x15C1D9C", VA = "0x15C1D9C")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000481")]
			[Address(RVA = "0x15C1DA8", Offset = "0x15C1DA8", VA = "0x15C1DA8")]
			set
			{
			}
		}

		[Token(Token = "0x170000A8")]
		public Color GizmoSelectionColor
		{
			[Token(Token = "0x6000482")]
			[Address(RVA = "0x15C1E14", Offset = "0x15C1E14", VA = "0x15C1E14")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000483")]
			[Address(RVA = "0x15C1E20", Offset = "0x15C1E20", VA = "0x15C1E20")]
			set
			{
			}
		}

		[Token(Token = "0x170000A9")]
		public int CacheDensity
		{
			[Token(Token = "0x6000484")]
			[Address(RVA = "0x15C1E8C", Offset = "0x15C1E8C", VA = "0x15C1E8C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000485")]
			[Address(RVA = "0x15BFC28", Offset = "0x15BFC28", VA = "0x15BFC28")]
			set
			{
			}
		}

		[Token(Token = "0x170000AA")]
		public float MaxPointsPerUnit
		{
			[Token(Token = "0x6000486")]
			[Address(RVA = "0x15C1E94", Offset = "0x15C1E94", VA = "0x15C1E94")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000487")]
			[Address(RVA = "0x15C1E9C", Offset = "0x15C1E9C", VA = "0x15C1E9C")]
			set
			{
			}
		}

		[Token(Token = "0x170000AB")]
		public bool UsePooling
		{
			[Token(Token = "0x6000488")]
			[Address(RVA = "0x15C1F50", Offset = "0x15C1F50", VA = "0x15C1F50")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000489")]
			[Address(RVA = "0x15C1F58", Offset = "0x15C1F58", VA = "0x15C1F58")]
			set
			{
			}
		}

		[Token(Token = "0x170000AC")]
		public bool UseThreading
		{
			[Token(Token = "0x600048A")]
			[Address(RVA = "0x15C1F78", Offset = "0x15C1F78", VA = "0x15C1F78")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600048B")]
			[Address(RVA = "0x15C1F80", Offset = "0x15C1F80", VA = "0x15C1F80")]
			set
			{
			}
		}

		[Token(Token = "0x170000AD")]
		public bool CheckTransform
		{
			[Token(Token = "0x600048C")]
			[Address(RVA = "0x15C1FA0", Offset = "0x15C1FA0", VA = "0x15C1FA0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600048D")]
			[Address(RVA = "0x15C1FA8", Offset = "0x15C1FA8", VA = "0x15C1FA8")]
			set
			{
			}
		}

		[Token(Token = "0x170000AE")]
		public float Tension
		{
			[Token(Token = "0x600048E")]
			[Address(RVA = "0x15C1FD4", Offset = "0x15C1FD4", VA = "0x15C1FD4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600048F")]
			[Address(RVA = "0x15C1FDC", Offset = "0x15C1FDC", VA = "0x15C1FDC")]
			set
			{
			}
		}

		[Token(Token = "0x170000AF")]
		public float Continuity
		{
			[Token(Token = "0x6000490")]
			[Address(RVA = "0x15C1FFC", Offset = "0x15C1FFC", VA = "0x15C1FFC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000491")]
			[Address(RVA = "0x15C2004", Offset = "0x15C2004", VA = "0x15C2004")]
			set
			{
			}
		}

		[Token(Token = "0x170000B0")]
		public float Bias
		{
			[Token(Token = "0x6000492")]
			[Address(RVA = "0x15C2024", Offset = "0x15C2024", VA = "0x15C2024")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000493")]
			[Address(RVA = "0x15C202C", Offset = "0x15C202C", VA = "0x15C202C")]
			set
			{
			}
		}

		[Token(Token = "0x170000B1")]
		public bool IsInitialized
		{
			[Token(Token = "0x6000494")]
			[Address(RVA = "0x15C204C", Offset = "0x15C204C", VA = "0x15C204C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B2")]
		public Bounds Bounds
		{
			[Token(Token = "0x6000495")]
			[Address(RVA = "0x15C2054", Offset = "0x15C2054", VA = "0x15C2054")]
			get
			{
				return default(Bounds);
			}
		}

		[Token(Token = "0x170000B3")]
		public int Count
		{
			[Token(Token = "0x6000496")]
			[Address(RVA = "0x15C2278", Offset = "0x15C2278", VA = "0x15C2278")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000B4")]
		public int ControlPointCount
		{
			[Token(Token = "0x6000497")]
			[Address(RVA = "0x15C00A4", Offset = "0x15C00A4", VA = "0x15C00A4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000B5")]
		public int CacheSize
		{
			[Token(Token = "0x6000498")]
			[Address(RVA = "0x15C2404", Offset = "0x15C2404", VA = "0x15C2404")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000B6")]
		public float Length
		{
			[Token(Token = "0x6000499")]
			[Address(RVA = "0x15C24DC", Offset = "0x15C24DC", VA = "0x15C24DC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000B7")]
		public bool Dirty
		{
			[Token(Token = "0x600049A")]
			[Address(RVA = "0x15C2368", Offset = "0x15C2368", VA = "0x15C2368")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B8")]
		public CurvySplineSegment Item
		{
			[Token(Token = "0x600049B")]
			[Address(RVA = "0x15C22DC", Offset = "0x15C22DC", VA = "0x15C22DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B9")]
		public ReadOnlyCollection<CurvySplineSegment> ControlPointsList
		{
			[Token(Token = "0x600049C")]
			[Address(RVA = "0x15BE000", Offset = "0x15BE000", VA = "0x15BE000")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BA")]
		[CanBeNull]
		public CurvySplineSegment FirstVisibleControlPoint
		{
			[Token(Token = "0x600049D")]
			[Address(RVA = "0x15C25DC", Offset = "0x15C25DC", VA = "0x15C25DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BB")]
		[CanBeNull]
		public CurvySplineSegment LastVisibleControlPoint
		{
			[Token(Token = "0x600049E")]
			[Address(RVA = "0x15C0824", Offset = "0x15C0824", VA = "0x15C0824")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BC")]
		public CurvySplineSegment FirstSegment
		{
			[Token(Token = "0x600049F")]
			[Address(RVA = "0x15C2BC4", Offset = "0x15C2BC4", VA = "0x15C2BC4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BD")]
		public CurvySplineSegment LastSegment
		{
			[Token(Token = "0x60004A0")]
			[Address(RVA = "0x15C2BF8", Offset = "0x15C2BF8", VA = "0x15C2BF8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BE")]
		public bool GlobalCoordinatesChangedThisFrame
		{
			[Token(Token = "0x60004A1")]
			[Address(RVA = "0x15C2C2C", Offset = "0x15C2C2C", VA = "0x15C2C2C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000BF")]
		public Action<CurvySpline> OnGlobalCoordinatesChanged
		{
			[Token(Token = "0x60004A2")]
			[Address(RVA = "0x15C2C34", Offset = "0x15C2C34", VA = "0x15C2C34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x876F58", Offset = "0x876F58")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004A3")]
			[Address(RVA = "0x15C2C3C", Offset = "0x15C2C3C", VA = "0x15C2C3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x876F68", Offset = "0x876F68")]
			set
			{
			}
		}

		[Token(Token = "0x170000C0")]
		public CurvySplineEvent OnRefresh
		{
			[Token(Token = "0x60004A4")]
			[Address(RVA = "0x15C2C44", Offset = "0x15C2C44", VA = "0x15C2C44")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004A5")]
			[Address(RVA = "0x15C2C4C", Offset = "0x15C2C4C", VA = "0x15C2C4C")]
			set
			{
			}
		}

		[Token(Token = "0x170000C1")]
		public CurvySplineEvent OnAfterControlPointChanges
		{
			[Token(Token = "0x60004A6")]
			[Address(RVA = "0x15C2C60", Offset = "0x15C2C60", VA = "0x15C2C60")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004A7")]
			[Address(RVA = "0x15C2C68", Offset = "0x15C2C68", VA = "0x15C2C68")]
			set
			{
			}
		}

		[Token(Token = "0x170000C2")]
		public CurvyControlPointEvent OnBeforeControlPointAdd
		{
			[Token(Token = "0x60004A8")]
			[Address(RVA = "0x15C2C7C", Offset = "0x15C2C7C", VA = "0x15C2C7C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004A9")]
			[Address(RVA = "0x15C2C84", Offset = "0x15C2C84", VA = "0x15C2C84")]
			set
			{
			}
		}

		[Token(Token = "0x170000C3")]
		public CurvyControlPointEvent OnAfterControlPointAdd
		{
			[Token(Token = "0x60004AA")]
			[Address(RVA = "0x15C2C98", Offset = "0x15C2C98", VA = "0x15C2C98")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004AB")]
			[Address(RVA = "0x15C2CA0", Offset = "0x15C2CA0", VA = "0x15C2CA0")]
			set
			{
			}
		}

		[Token(Token = "0x170000C4")]
		public CurvyControlPointEvent OnBeforeControlPointDelete
		{
			[Token(Token = "0x60004AC")]
			[Address(RVA = "0x15C2CB4", Offset = "0x15C2CB4", VA = "0x15C2CB4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004AD")]
			[Address(RVA = "0x15C2CBC", Offset = "0x15C2CBC", VA = "0x15C2CBC")]
			set
			{
			}
		}

		[Token(Token = "0x170000C5")]
		private List<CurvySplineSegment> Segments
		{
			[Token(Token = "0x6000520")]
			[Address(RVA = "0x15C23D0", Offset = "0x15C23D0", VA = "0x15C23D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0x15C1548", Offset = "0x15C1548", VA = "0x15C1548")]
		public CurvySpline()
		{
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x15C2CD0", Offset = "0x15C2CD0", VA = "0x15C2CD0")]
		public static CurvySpline Create()
		{
			return null;
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x15C2E98", Offset = "0x15C2E98", VA = "0x15C2E98")]
		public static CurvySpline Create(CurvySpline takeOptionsFrom)
		{
			return null;
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x15C302C", Offset = "0x15C302C", VA = "0x15C302C")]
		public static int CalculateCacheSize(int density, float splineLength, float maxPointsPerUnit)
		{
			return default(int);
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x15C30DC", Offset = "0x15C30DC", VA = "0x15C30DC")]
		public static float CalculateSamplingPointsPerUnit(int density, float maxPointsPerUnit)
		{
			return default(float);
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x15C31CC", Offset = "0x15C31CC", VA = "0x15C31CC")]
		public static Vector3 Bezier(Vector3 T0, Vector3 P0, Vector3 P1, Vector3 T1, float f)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x15C32BC", Offset = "0x15C32BC", VA = "0x15C32BC")]
		public static Vector3 BezierTangent(Vector3 T0, Vector3 P0, Vector3 P1, Vector3 T1, float f)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x15C3430", Offset = "0x15C3430", VA = "0x15C3430")]
		public static Vector3 CatmullRom(Vector3 T0, Vector3 P0, Vector3 P1, Vector3 T1, float f)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x15C3550", Offset = "0x15C3550", VA = "0x15C3550")]
		public static Vector3 TCB(Vector3 T0, Vector3 P0, Vector3 P1, Vector3 T1, float f, float FT0, float FC0, float FB0, float FT1, float FC1, float FB1)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x15C3768", Offset = "0x15C3768", VA = "0x15C3768")]
		[NotNull]
		public static CurvySplineSegment GetFollowUpHeadingControlPoint(CurvySplineSegment followUp, ConnectionHeadingEnum headingDirection)
		{
			return null;
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x15C39B0", Offset = "0x15C39B0", VA = "0x15C39B0")]
		public Vector3 Interpolate(float tf, Space space = Space.Self)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x15C3AC8", Offset = "0x15C3AC8", VA = "0x15C3AC8")]
		public Vector3 InterpolateFast(float tf, Space space = Space.Self)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x15C3BB0", Offset = "0x15C3BB0", VA = "0x15C3BB0")]
		public Vector3 InterpolateByDistance(float distance, Space space = Space.Self)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x15C3C94", Offset = "0x15C3C94", VA = "0x15C3C94")]
		public Vector3 InterpolateByDistanceFast(float distance, Space space = Space.Self)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x15C3CC4", Offset = "0x15C3CC4", VA = "0x15C3CC4")]
		public Vector3 GetTangent(float tf, Space space = Space.Self)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x15C3DAC", Offset = "0x15C3DAC", VA = "0x15C3DAC")]
		public Vector3 GetTangent(float tf, Vector3 position, Space space = Space.Self)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x15C3EB4", Offset = "0x15C3EB4", VA = "0x15C3EB4")]
		public Vector3 GetTangentFast(float tf, Space space = Space.Self)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x15C3F9C", Offset = "0x15C3F9C", VA = "0x15C3F9C")]
		public Vector3 GetTangentByDistance(float distance, Space space = Space.Self)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x15C3FCC", Offset = "0x15C3FCC", VA = "0x15C3FCC")]
		public Vector3 GetTangentByDistanceFast(float distance, Space space = Space.Self)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x15C3FFC", Offset = "0x15C3FFC", VA = "0x15C3FFC")]
		public void InterpolateAndGetTangent(float tf, out Vector3 position, out Vector3 tangent, Space space = Space.Self)
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x15C410C", Offset = "0x15C410C", VA = "0x15C410C")]
		public void InterpolateAndGetTangentFast(float tf, out Vector3 position, out Vector3 tangent, Space space = Space.Self)
		{
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x15C421C", Offset = "0x15C421C", VA = "0x15C421C")]
		public Vector3 GetOrientationUpFast(float tf, Space space = Space.Self)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x15C4304", Offset = "0x15C4304", VA = "0x15C4304")]
		public Quaternion GetOrientationFast(float tf, bool inverse = false, Space space = Space.Self)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x15C43F4", Offset = "0x15C43F4", VA = "0x15C43F4")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x876F88", Offset = "0x876F88")]
		public Vector3 InterpolateScale(float tf)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004C5")]
		public T GetMetadata<T>(float tf) where T : CurvyMetadataBase
		{
			return null;
		}

		[Token(Token = "0x60004C6")]
		public U GetInterpolatedMetadata<T, U>(float tf) where T : CurvyInterpolatableMetadataBase<U>
		{
			return (U)null;
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x15C44AC", Offset = "0x15C44AC", VA = "0x15C44AC")]
		public float TFToDistance(float tf, CurvyClamping clamping = CurvyClamping.Clamp)
		{
			return default(float);
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x15C4580", Offset = "0x15C4580", VA = "0x15C4580")]
		public CurvySplineSegment TFToSegment(float tf, out float localF, out bool isOnSegmentStart, out bool isOnSegmentEnd, CurvyClamping clamping)
		{
			return null;
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x15C4550", Offset = "0x15C4550", VA = "0x15C4550")]
		public CurvySplineSegment TFToSegment(float tf, out float localF, CurvyClamping clamping)
		{
			return null;
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x15C4644", Offset = "0x15C4644", VA = "0x15C4644")]
		public CurvySplineSegment TFToSegment(float tf, CurvyClamping clamping)
		{
			return null;
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x15C467C", Offset = "0x15C467C", VA = "0x15C467C")]
		public CurvySplineSegment TFToSegment(float tf)
		{
			return null;
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x15C3A98", Offset = "0x15C3A98", VA = "0x15C3A98")]
		public CurvySplineSegment TFToSegment(float tf, out float localF)
		{
			return null;
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x15C46B4", Offset = "0x15C46B4", VA = "0x15C46B4")]
		public float SegmentToTF(CurvySplineSegment segment)
		{
			return default(float);
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x15C46CC", Offset = "0x15C46CC", VA = "0x15C46CC")]
		public float SegmentToTF(CurvySplineSegment segment, float localF)
		{
			return default(float);
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x15C3BE0", Offset = "0x15C3BE0", VA = "0x15C3BE0")]
		public float DistanceToTF(float distance, CurvyClamping clamping = CurvyClamping.Clamp)
		{
			return default(float);
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x15C47A0", Offset = "0x15C47A0", VA = "0x15C47A0")]
		public CurvySplineSegment DistanceToSegment(float distance, CurvyClamping clamping = CurvyClamping.Clamp)
		{
			return null;
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x15C4770", Offset = "0x15C4770", VA = "0x15C4770")]
		public CurvySplineSegment DistanceToSegment(float distance, out float localDistance, CurvyClamping clamping = CurvyClamping.Clamp)
		{
			return null;
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x15C47D8", Offset = "0x15C47D8", VA = "0x15C47D8")]
		public CurvySplineSegment DistanceToSegment(float distance, out float localDistance, out bool isOnSegmentStart, out bool isOnSegmentEnd, CurvyClamping clamping = CurvyClamping.Clamp)
		{
			return null;
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x15C4960", Offset = "0x15C4960", VA = "0x15C4960")]
		public float ClampDistance(float distance, CurvyClamping clamping)
		{
			return default(float);
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x15C499C", Offset = "0x15C499C", VA = "0x15C499C")]
		public float ClampDistance(float distance, CurvyClamping clamping, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x15C49F0", Offset = "0x15C49F0", VA = "0x15C49F0")]
		public float ClampDistance(float distance, ref int dir, CurvyClamping clamping)
		{
			return default(float);
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x15C4A34", Offset = "0x15C4A34", VA = "0x15C4A34")]
		public float ClampDistance(float distance, ref int dir, CurvyClamping clamping, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x15C4A90", Offset = "0x15C4A90", VA = "0x15C4A90")]
		public CurvySplineSegment Add()
		{
			return null;
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x15C4A9C", Offset = "0x15C4A9C", VA = "0x15C4A9C")]
		public CurvySplineSegment Add(Vector3 controlPointPosition, Space space)
		{
			return null;
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x15C4D40", Offset = "0x15C4D40", VA = "0x15C4D40")]
		public CurvySplineSegment[] Add(params Vector3[] controlPointsLocalPositions)
		{
			return null;
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x15C4E94", Offset = "0x15C4E94", VA = "0x15C4E94")]
		public CurvySplineSegment[] Add(Vector3[] controlPointsPositions, Space space)
		{
			return null;
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x15C4FEC", Offset = "0x15C4FEC", VA = "0x15C4FEC")]
		public CurvySplineSegment InsertBefore(CurvySplineSegment controlPoint, bool skipRefreshingAndEvents = false)
		{
			return null;
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x15C5178", Offset = "0x15C5178", VA = "0x15C5178")]
		public CurvySplineSegment InsertBefore([CanBeNull] CurvySplineSegment controlPoint, Vector3 position, bool skipRefreshingAndEvents = false, Space space = Space.World)
		{
			return null;
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x15C0688", Offset = "0x15C0688", VA = "0x15C0688")]
		public CurvySplineSegment InsertAfter(CurvySplineSegment controlPoint, bool skipRefreshingAndEvents = false)
		{
			return null;
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x15C4BA0", Offset = "0x15C4BA0", VA = "0x15C4BA0")]
		public CurvySplineSegment InsertAfter([CanBeNull] CurvySplineSegment controlPoint, Vector3 position, bool skipRefreshingAndEvents = false, Space space = Space.World)
		{
			return null;
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x15C56C0", Offset = "0x15C56C0", VA = "0x15C56C0")]
		public void Clear()
		{
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x15C5A5C", Offset = "0x15C5A5C", VA = "0x15C5A5C")]
		public void Delete(CurvySplineSegment controlPoint, bool skipRefreshingAndEvents = false)
		{
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x15C0858", Offset = "0x15C0858", VA = "0x15C0858")]
		public void Delete(CurvySplineSegment controlPoint, bool skipRefreshingAndEvents, bool isUndoableDeletion)
		{
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x15BEFF4", Offset = "0x15BEFF4", VA = "0x15BEFF4")]
		public Vector3[] GetApproximation(Space space = Space.Self)
		{
			return null;
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x15C5C74", Offset = "0x15C5C74", VA = "0x15C5C74")]
		public Vector3[] GetApproximation(float fromTF, float toTF, bool includeEndPoint = true, Space space = Space.Self)
		{
			return null;
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x15C620C", Offset = "0x15C620C", VA = "0x15C620C")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x876FC0", Offset = "0x876FC0")]
		public Vector3[] GetApproximationPoints(float fromTF, float toTF, bool includeEndPoint = true, Space space = Space.Self)
		{
			return null;
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x15C6214", Offset = "0x15C6214", VA = "0x15C6214")]
		public Vector3[] GetApproximationT(Space space = Space.Self)
		{
			return null;
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x15C63E8", Offset = "0x15C63E8", VA = "0x15C63E8")]
		public Vector3[] GetApproximationUpVectors(Space space = Space.Self)
		{
			return null;
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x15C65BC", Offset = "0x15C65BC", VA = "0x15C65BC")]
		public float GetNearestPointTF(Vector3 localPosition)
		{
			return default(float);
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x15C68A4", Offset = "0x15C68A4", VA = "0x15C68A4")]
		public float GetNearestPointTF(Vector3 position, Space space)
		{
			return default(float);
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x15C68E4", Offset = "0x15C68E4", VA = "0x15C68E4")]
		public float GetNearestPointTF(Vector3 localPosition, out Vector3 nearestPoint)
		{
			return default(float);
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x15C691C", Offset = "0x15C691C", VA = "0x15C691C")]
		public float GetNearestPointTF(Vector3 position, out Vector3 nearestPoint, Space space)
		{
			return default(float);
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x15C6954", Offset = "0x15C6954", VA = "0x15C6954")]
		public float GetNearestPointTF(Vector3 position, int searchStartSegmentIndex = 0, int searchEndSegmentIndex = -1, Space space = Space.Self)
		{
			return default(float);
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x15C6994", Offset = "0x15C6994", VA = "0x15C6994")]
		public float GetNearestPointTF(Vector3 position, out Vector3 nearestPoint, int searchStartSegmentIndex = 0, int searchEndSegmentIndex = -1, Space space = Space.Self)
		{
			return default(float);
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x15C65FC", Offset = "0x15C65FC", VA = "0x15C65FC")]
		public float GetNearestPointTF(Vector3 position, out Vector3 nearestPoint, [CanBeNull] out CurvySplineSegment nearestSegment, out float nearestPointLocalF, int searchStartSegmentIndex = 0, int searchEndSegmentIndex = -1, Space space = Space.Self)
		{
			return default(float);
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x15BF73C", Offset = "0x15BF73C", VA = "0x15BF73C")]
		public void Refresh()
		{
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x15BF730", Offset = "0x15BF730", VA = "0x15BF730")]
		public void SetDirtyAll()
		{
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x15C19C0", Offset = "0x15C19C0", VA = "0x15C19C0")]
		public void SetDirtyAll(SplineDirtyingType dirtyingType, bool dirtyConnectedControlPoints)
		{
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x15C78BC", Offset = "0x15C78BC", VA = "0x15C78BC")]
		public void SetDirty(CurvySplineSegment dirtyControlPoint, SplineDirtyingType dirtyingType)
		{
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x15C7DFC", Offset = "0x15C7DFC", VA = "0x15C7DFC")]
		public void SetDirtyPartial(CurvySplineSegment dirtyControlPoint, SplineDirtyingType dirtyingType)
		{
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x15C7E54", Offset = "0x15C7E54", VA = "0x15C7E54")]
		public Vector3 ToWorldPosition(Vector3 localPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x15C7E70", Offset = "0x15C7E70", VA = "0x15C7E70")]
		public Vector3 ToWorldDirection(Vector3 localDirection)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x15C7E8C", Offset = "0x15C7E8C", VA = "0x15C7E8C")]
		public Vector3 ToLocalPosition(Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x15C7EA8", Offset = "0x15C7EA8", VA = "0x15C7EA8")]
		public Vector3 ToLocalDirection(Vector3 localDirection)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x15C7EC4", Offset = "0x15C7EC4", VA = "0x15C7EC4")]
		public void SyncSplineFromHierarchy()
		{
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x15C8178", Offset = "0x15C8178", VA = "0x15C8178")]
		public bool IsPlanar(out int ignoreAxis)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x15C81F4", Offset = "0x15C81F4", VA = "0x15C81F4")]
		public bool IsPlanar(out bool xplanar, out bool yplanar, out bool zplanar)
		{
			return default(bool);
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x15C847C", Offset = "0x15C847C", VA = "0x15C847C")]
		public bool IsPlanar(CurvyPlane plane)
		{
			return default(bool);
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x15C8644", Offset = "0x15C8644", VA = "0x15C8644")]
		public void MakePlanar(CurvyPlane plane)
		{
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x15C8A90", Offset = "0x15C8A90", VA = "0x15C8A90")]
		public void MakePlanar(int axis)
		{
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x15C8C4C", Offset = "0x15C8C4C", VA = "0x15C8C4C")]
		public void Subdivide([Optional] CurvySplineSegment fromCP, [Optional] CurvySplineSegment toCP)
		{
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x15C9310", Offset = "0x15C9310", VA = "0x15C9310")]
		public void Simplify([Optional] CurvySplineSegment fromCP, [Optional] CurvySplineSegment toCP)
		{
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x15C9610", Offset = "0x15C9610", VA = "0x15C9610")]
		public void Equalize([Optional] CurvySplineSegment fromCP, [Optional] CurvySplineSegment toCP)
		{
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x15C9A78", Offset = "0x15C9A78", VA = "0x15C9A78")]
		public void Normalize()
		{
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x15C9CA4", Offset = "0x15C9CA4", VA = "0x15C9CA4")]
		public Vector3 SetPivot(float xRel = 0f, float yRel = 0f, float zRel = 0f, bool preview = false)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x15C9FA4", Offset = "0x15C9FA4", VA = "0x15C9FA4")]
		public void Flip()
		{
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x15CA298", Offset = "0x15CA298", VA = "0x15CA298")]
		public void MoveControlPoints(int startIndex, int count, CurvySplineSegment destCP)
		{
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x15CA69C", Offset = "0x15CA69C", VA = "0x15CA69C")]
		public void JoinWith(CurvySplineSegment destCP)
		{
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x15CA788", Offset = "0x15CA788", VA = "0x15CA788")]
		public CurvySpline Split(CurvySplineSegment controlPoint)
		{
			return null;
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x15CAA3C", Offset = "0x15CAA3C", VA = "0x15CAA3C")]
		public void SetFirstControlPoint(CurvySplineSegment controlPoint)
		{
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x15CABB4", Offset = "0x15CABB4", VA = "0x15CABB4")]
		public bool IsControlPointAnOrientationAnchor(CurvySplineSegment controlPoint)
		{
			return default(bool);
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x15CAD08", Offset = "0x15CAD08", VA = "0x15CAD08")]
		public bool CanControlPointHaveFollowUp(CurvySplineSegment controlPoint)
		{
			return default(bool);
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0x15C526C", Offset = "0x15C526C", VA = "0x15C526C")]
		public short GetControlPointIndex(CurvySplineSegment controlPoint)
		{
			return default(short);
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0x15CA9F8", Offset = "0x15CA9F8", VA = "0x15CA9F8")]
		public short GetSegmentIndex(CurvySplineSegment segment)
		{
			return default(short);
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0x15C3900", Offset = "0x15C3900", VA = "0x15C3900")]
		[CanBeNull]
		public CurvySplineSegment GetNextControlPoint(CurvySplineSegment controlPoint)
		{
			return null;
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0x15CAD4C", Offset = "0x15CAD4C", VA = "0x15CAD4C")]
		[CanBeNull]
		public short GetNextControlPointIndex(CurvySplineSegment controlPoint)
		{
			return default(short);
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0x15CAD90", Offset = "0x15CAD90", VA = "0x15CAD90")]
		[CanBeNull]
		public CurvySplineSegment GetNextControlPointUsingFollowUp(CurvySplineSegment controlPoint)
		{
			return null;
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x15C3850", Offset = "0x15C3850", VA = "0x15C3850")]
		[CanBeNull]
		public CurvySplineSegment GetPreviousControlPoint(CurvySplineSegment controlPoint)
		{
			return null;
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x15CAE94", Offset = "0x15CAE94", VA = "0x15CAE94")]
		[CanBeNull]
		public short GetPreviousControlPointIndex(CurvySplineSegment controlPoint)
		{
			return default(short);
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x15CAED8", Offset = "0x15CAED8", VA = "0x15CAED8")]
		[CanBeNull]
		public CurvySplineSegment GetPreviousControlPointUsingFollowUp(CurvySplineSegment controlPoint)
		{
			return null;
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x15C615C", Offset = "0x15C615C", VA = "0x15C615C")]
		[CanBeNull]
		public CurvySplineSegment GetNextSegment(CurvySplineSegment segment)
		{
			return null;
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0x15CAFDC", Offset = "0x15CAFDC", VA = "0x15CAFDC")]
		[CanBeNull]
		public CurvySplineSegment GetPreviousSegment(CurvySplineSegment segment)
		{
			return null;
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0x15C472C", Offset = "0x15C472C", VA = "0x15C472C")]
		public bool IsControlPointASegment(CurvySplineSegment controlPoint)
		{
			return default(bool);
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0x15CACC4", Offset = "0x15CACC4", VA = "0x15CACC4")]
		public bool IsControlPointVisible(CurvySplineSegment controlPoint)
		{
			return default(bool);
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0x15CB08C", Offset = "0x15CB08C", VA = "0x15CB08C")]
		public short GetControlPointOrientationAnchorIndex(CurvySplineSegment controlPoint)
		{
			return default(short);
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0x15CB0D0", Offset = "0x15CB0D0", VA = "0x15CB0D0")]
		public void SetFromString(string fieldAndValue)
		{
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0x15CB66C", Offset = "0x15CB66C", VA = "0x15CB66C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0x15CB6FC", Offset = "0x15CB6FC", VA = "0x15CB6FC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0x15C2E54", Offset = "0x15C2E54", VA = "0x15C2E54")]
		public void Start()
		{
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0x15CB784", Offset = "0x15CB784", VA = "0x15CB784")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0x15CB78C", Offset = "0x15CB78C", VA = "0x15CB78C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0x15CB8F0", Offset = "0x15CB8F0", VA = "0x15CB8F0", Slot = "4")]
		protected virtual void Reset()
		{
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0x15CBAA0", Offset = "0x15CBAA0", VA = "0x15CBAA0")]
		private void Update()
		{
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0x15CBE3C", Offset = "0x15CBE3C", VA = "0x15CBE3C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0x15CBE80", Offset = "0x15CBE80", VA = "0x15CBE80")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0x15CB744", Offset = "0x15CB744", VA = "0x15CB744")]
		private void Initialize()
		{
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0x15CBAE0", Offset = "0x15CBAE0", VA = "0x15CBAE0")]
		private void doUpdate()
		{
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0x15C1D54", Offset = "0x15C1D54", VA = "0x15C1D54")]
		private bool canHaveManualEndCP()
		{
			return default(bool);
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0x15C7914", Offset = "0x15C7914", VA = "0x15C7914")]
		private void SetDirty(CurvySplineSegment controlPoint, SplineDirtyingType dirtyingType, CurvySplineSegment previousControlPoint, CurvySplineSegment nextControlPoint, bool ignoreConnectionOfInputControlPoint)
		{
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0x15C786C", Offset = "0x15C786C", VA = "0x15C786C")]
		private void SetDirtyingFlags(SplineDirtyingType dirtyingType)
		{
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0x15CA228", Offset = "0x15CA228", VA = "0x15CA228")]
		private void ReverseControlPoints()
		{
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0x15CBF3C", Offset = "0x15CBF3C", VA = "0x15CBF3C")]
		private static short GetNextControlPointIndex(short controlPointIndex, bool isSplineClosed, int controlPointsCount)
		{
			return default(short);
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0x15CBF6C", Offset = "0x15CBF6C", VA = "0x15CBF6C")]
		private static short GetPreviousControlPointIndex(short controlPointIndex, bool isSplineClosed, int controlPointsCount)
		{
			return default(short);
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0x15CBFA0", Offset = "0x15CBFA0", VA = "0x15CBFA0")]
		private static bool IsControlPointASegment(int controlPointIndex, int controlPointCount, bool isClosed, bool notAutoEndTangentsAndIsCatmullRomOrTCB)
		{
			return default(bool);
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x15C7FCC", Offset = "0x15C7FCC", VA = "0x15C7FCC")]
		private void AddControlPoint(CurvySplineSegment item)
		{
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x15CA4F4", Offset = "0x15CA4F4", VA = "0x15CA4F4")]
		private void InsertControlPoint(int index, CurvySplineSegment item)
		{
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0x15C5A68", Offset = "0x15C5A68", VA = "0x15C5A68")]
		private void RemoveControlPoint(CurvySplineSegment item)
		{
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0x15C5914", Offset = "0x15C5914", VA = "0x15C5914")]
		private void ClearControlPoints()
		{
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0x15C1928", Offset = "0x15C1928", VA = "0x15C1928")]
		internal void InvalidateControlPointsRelationshipCacheINTERNAL()
		{
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0x15C2610", Offset = "0x15C2610", VA = "0x15C2610")]
		private void RebuildControlPointsRelationshipCache(bool fixNonCoherentControlPoints)
		{
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0x15C69CC", Offset = "0x15C69CC", VA = "0x15C69CC")]
		private void ProcessDirtyControlPoints()
		{
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0x15CC260", Offset = "0x15CC260", VA = "0x15CC260")]
		private void PrepareThreadCompatibleData()
		{
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0x15CBFD8", Offset = "0x15CBFD8", VA = "0x15CBFD8")]
		private void FillDirtyCpsExtendedList()
		{
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0x15BF38C", Offset = "0x15BF38C", VA = "0x15BF38C")]
		internal void NotifyMetaDataModification()
		{
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0x15CC424", Offset = "0x15CC424", VA = "0x15CC424")]
		private void SyncHierarchyFromSpline(bool renameControlPoints = true)
		{
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0x15CBEC4", Offset = "0x15CBEC4", VA = "0x15CBEC4")]
		private void UpdatedLastProcessedGlobalCoordinates()
		{
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0x15C52B0", Offset = "0x15C52B0", VA = "0x15C52B0")]
		private CurvySplineSegment InsertAt(CurvySplineSegment controlPoint, Vector3 position, int insertionIndex, CurvyControlPointEventArgs.ModeEnum insertionMode, bool skipRefreshingAndEvents, Space space)
		{
			return null;
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0x15C7800", Offset = "0x15C7800", VA = "0x15C7800")]
		private CurvySplineEventArgs OnRefreshEvent(CurvySplineEventArgs e)
		{
			return null;
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0x15C4B34", Offset = "0x15C4B34", VA = "0x15C4B34")]
		private CurvyControlPointEventArgs OnBeforeControlPointAddEvent(CurvyControlPointEventArgs e)
		{
			return null;
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0x15C4C68", Offset = "0x15C4C68", VA = "0x15C4C68")]
		private CurvyControlPointEventArgs OnAfterControlPointAddEvent(CurvyControlPointEventArgs e)
		{
			return null;
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0x15C58A8", Offset = "0x15C58A8", VA = "0x15C58A8")]
		private CurvyControlPointEventArgs OnBeforeControlPointDeleteEvent(CurvyControlPointEventArgs e)
		{
			return null;
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0x15C4CD4", Offset = "0x15C4CD4", VA = "0x15C4CD4")]
		private CurvySplineEventArgs OnAfterControlPointChangesEvent(CurvySplineEventArgs e)
		{
			return null;
		}
	}
	[Token(Token = "0x2000094")]
	public enum SplineDirtyingType
	{
		[Token(Token = "0x40001F6")]
		OrientationOnly,
		[Token(Token = "0x40001F7")]
		Everything
	}
	[Token(Token = "0x2000095")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x864D78", Offset = "0x864D78")]
	public class CurvySplineSegment : MonoBehaviour, IPoolable
	{
		[Token(Token = "0x200017C")]
		internal readonly struct ControlPointExtrinsicProperties : IEquatable<ControlPointExtrinsicProperties>
		{
			[Token(Token = "0x4000663")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly bool isVisible;

			[Token(Token = "0x4000664")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
			private readonly short segmentIndex;

			[Token(Token = "0x4000665")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			private readonly short controlPointIndex;

			[Token(Token = "0x4000666")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
			private readonly short nextControlPointIndex;

			[Token(Token = "0x4000667")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private readonly short previousControlPointIndex;

			[Token(Token = "0x4000668")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
			private readonly bool previousControlPointIsSegment;

			[Token(Token = "0x4000669")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB")]
			private readonly bool nextControlPointIsSegment;

			[Token(Token = "0x400066A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private readonly bool canHaveFollowUp;

			[Token(Token = "0x400066B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
			private readonly short orientationAnchorIndex;

			[Token(Token = "0x170002CF")]
			internal bool IsVisible
			{
				[Token(Token = "0x6000D1F")]
				[Address(RVA = "0x9E0C90", Offset = "0x9E0C90", VA = "0x9E0C90")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170002D0")]
			internal short SegmentIndex
			{
				[Token(Token = "0x6000D20")]
				[Address(RVA = "0x9E0C98", Offset = "0x9E0C98", VA = "0x9E0C98")]
				get
				{
					return default(short);
				}
			}

			[Token(Token = "0x170002D1")]
			internal short ControlPointIndex
			{
				[Token(Token = "0x6000D21")]
				[Address(RVA = "0x9E0CA0", Offset = "0x9E0CA0", VA = "0x9E0CA0")]
				get
				{
					return default(short);
				}
			}

			[Token(Token = "0x170002D2")]
			internal short NextControlPointIndex
			{
				[Token(Token = "0x6000D22")]
				[Address(RVA = "0x9E0CA8", Offset = "0x9E0CA8", VA = "0x9E0CA8")]
				get
				{
					return default(short);
				}
			}

			[Token(Token = "0x170002D3")]
			internal short PreviousControlPointIndex
			{
				[Token(Token = "0x6000D23")]
				[Address(RVA = "0x9E0CB0", Offset = "0x9E0CB0", VA = "0x9E0CB0")]
				get
				{
					return default(short);
				}
			}

			[Token(Token = "0x170002D4")]
			internal bool PreviousControlPointIsSegment
			{
				[Token(Token = "0x6000D24")]
				[Address(RVA = "0x9E0CB8", Offset = "0x9E0CB8", VA = "0x9E0CB8")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170002D5")]
			internal bool NextControlPointIsSegment
			{
				[Token(Token = "0x6000D25")]
				[Address(RVA = "0x9E0CC0", Offset = "0x9E0CC0", VA = "0x9E0CC0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170002D6")]
			internal bool CanHaveFollowUp
			{
				[Token(Token = "0x6000D26")]
				[Address(RVA = "0x9E0CC8", Offset = "0x9E0CC8", VA = "0x9E0CC8")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170002D7")]
			internal bool IsSegment
			{
				[Token(Token = "0x6000D27")]
				[Address(RVA = "0x9E0CD0", Offset = "0x9E0CD0", VA = "0x9E0CD0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170002D8")]
			internal short OrientationAnchorIndex
			{
				[Token(Token = "0x6000D28")]
				[Address(RVA = "0x9E0CE0", Offset = "0x9E0CE0", VA = "0x9E0CE0")]
				get
				{
					return default(short);
				}
			}

			[Token(Token = "0x6000D29")]
			[Address(RVA = "0x9E0CE8", Offset = "0x9E0CE8", VA = "0x9E0CE8")]
			internal ControlPointExtrinsicProperties(bool isVisible, short segmentIndex, short controlPointIndex, short previousControlPointIndex, short nextControlPointIndex, bool previousControlPointIsSegment, bool nextControlPointIsSegment, bool canHaveFollowUp, short orientationAnchorIndex)
			{
			}

			[Token(Token = "0x6000D2A")]
			[Address(RVA = "0x9E0D28", Offset = "0x9E0D28", VA = "0x9E0D28", Slot = "4")]
			public bool Equals(ControlPointExtrinsicProperties other)
			{
				return default(bool);
			}

			[Token(Token = "0x6000D2B")]
			[Address(RVA = "0x9E0D30", Offset = "0x9E0D30", VA = "0x9E0D30", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Token(Token = "0x6000D2C")]
			[Address(RVA = "0x9E0D38", Offset = "0x9E0D38", VA = "0x9E0D38", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6000D2D")]
			[Address(RVA = "0x1816BE8", Offset = "0x1816BE8", VA = "0x1816BE8")]
			public static bool operator ==(ControlPointExtrinsicProperties left, ControlPointExtrinsicProperties right)
			{
				return default(bool);
			}

			[Token(Token = "0x6000D2E")]
			[Address(RVA = "0x1816C18", Offset = "0x1816C18", VA = "0x1816C18")]
			public static bool operator !=(ControlPointExtrinsicProperties left, ControlPointExtrinsicProperties right)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200017D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x867AF4", Offset = "0x867AF4")]
		private sealed class <>c__DisplayClass102_0
		{
			[Token(Token = "0x400066C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public HashSet<Component> result;

			[Token(Token = "0x6000D2F")]
			[Address(RVA = "0x181683C", Offset = "0x181683C", VA = "0x181683C")]
			public <>c__DisplayClass102_0()
			{
			}

			[Token(Token = "0x6000D30")]
			[Address(RVA = "0x1816844", Offset = "0x1816844", VA = "0x1816844")]
			internal void <get_MetaDataSet>b__0(CurvyMetadataBase md)
			{
			}
		}

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Color GizmoTangentColor;

		[NonSerialized]
		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3[] Approximation;

		[NonSerialized]
		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float[] ApproximationDistances;

		[NonSerialized]
		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3[] ApproximationUp;

		[NonSerialized]
		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3[] ApproximationT;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x869420", Offset = "0x869420")]
		private float <Length>k__BackingField;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x869430", Offset = "0x869430")]
		private float <Distance>k__BackingField;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x869440", Offset = "0x869440")]
		private float <TF>k__BackingField;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x869450", Offset = "0x869450")]
		[AttributeAttribute(Name = "FieldActionAttribute", RVA = "0x869450", Offset = "0x869450")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x869450", Offset = "0x869450")]
		[SerializeField]
		private bool m_AutoBakeOrientation;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x45")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x86950C", Offset = "0x86950C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86950C", Offset = "0x86950C")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x86950C", Offset = "0x86950C")]
		[SerializeField]
		private bool m_OrientationAnchor;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x869608", Offset = "0x869608")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x869608", Offset = "0x869608")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x869608", Offset = "0x869608")]
		[SerializeField]
		private CurvyOrientationSwirl m_Swirl;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x869718", Offset = "0x869718")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x869718", Offset = "0x869718")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x869718", Offset = "0x869718")]
		[SerializeField]
		private float m_SwirlTurns;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x86986C", Offset = "0x86986C")]
		[AttributeAttribute(Name = "GroupConditionAttribute", RVA = "0x86986C", Offset = "0x86986C")]
		[SerializeField]
		private bool m_AutoHandles;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x86995C", Offset = "0x86995C")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x86995C", Offset = "0x86995C")]
		[SerializeField]
		private float m_AutoHandleDistance;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x869A58", Offset = "0x869A58")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x869A58", Offset = "0x869A58")]
		private Vector3 m_HandleIn;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x869B00", Offset = "0x869B00")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x869B00", Offset = "0x869B00")]
		private Vector3 m_HandleOut;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x869BA8", Offset = "0x869BA8")]
		[AttributeAttribute(Name = "GroupConditionAttribute", RVA = "0x869BA8", Offset = "0x869BA8")]
		[AttributeAttribute(Name = "GroupActionAttribute", RVA = "0x869BA8", Offset = "0x869BA8")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x869BA8", Offset = "0x869BA8")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x869BA8", Offset = "0x869BA8")]
		private bool m_OverrideGlobalTension;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x869D28", Offset = "0x869D28")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x869D28", Offset = "0x869D28")]
		private bool m_OverrideGlobalContinuity;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x72")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x869DB4", Offset = "0x869DB4")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x869DB4", Offset = "0x869DB4")]
		private bool m_OverrideGlobalBias;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x73")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x869E40", Offset = "0x869E40")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x869E40", Offset = "0x869E40")]
		private bool m_SynchronizeTCB;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x869EB0", Offset = "0x869EB0")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x869EB0", Offset = "0x869EB0")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x869EB0", Offset = "0x869EB0")]
		private float m_StartTension;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x869FC0", Offset = "0x869FC0")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x869FC0", Offset = "0x869FC0")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x869FC0", Offset = "0x869FC0")]
		private float m_EndTension;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x86A10C", Offset = "0x86A10C")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x86A10C", Offset = "0x86A10C")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x86A10C", Offset = "0x86A10C")]
		private float m_StartContinuity;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x86A21C", Offset = "0x86A21C")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x86A21C", Offset = "0x86A21C")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x86A21C", Offset = "0x86A21C")]
		private float m_EndContinuity;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x86A368", Offset = "0x86A368")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x86A368", Offset = "0x86A368")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x86A368", Offset = "0x86A368")]
		private float m_StartBias;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x86A478", Offset = "0x86A478")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x86A478", Offset = "0x86A478")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x86A478", Offset = "0x86A478")]
		private float m_EndBias;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		[HideInInspector]
		private CurvySplineSegment m_FollowUp;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		[HideInInspector]
		private ConnectionHeadingEnum m_FollowUpHeading;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		[SerializeField]
		[HideInInspector]
		private bool m_ConnectionSyncPosition;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9D")]
		[SerializeField]
		[HideInInspector]
		private bool m_ConnectionSyncRotation;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[HideInInspector]
		private CurvyConnection m_Connection;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private int cacheSize;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Transform cachedTransform;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3 threadSafeLocalPosition;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Vector3 threadSafeNextCpLocalPosition;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Vector3 threadSafePreviousCpLocalPosition;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Quaternion threadSafeLocalRotation;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private CurvySplineSegment cachedNextControlPoint;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private CurvySpline mSpline;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private float mStepSize;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private Bounds? mBounds;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private readonly HashSet<CurvyMetadataBase> mMetadata;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private Vector3 lastProcessedLocalPosition;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		private Quaternion lastProcessedLocalRotation;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
		private ControlPointExtrinsicProperties extrinsicPropertiesINTERNAL;

		[Token(Token = "0x170000C6")]
		public bool AutoBakeOrientation
		{
			[Token(Token = "0x600053D")]
			[Address(RVA = "0x144CD78", Offset = "0x144CD78", VA = "0x144CD78")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600053E")]
			[Address(RVA = "0x144CD80", Offset = "0x144CD80", VA = "0x144CD80")]
			set
			{
			}
		}

		[Token(Token = "0x170000C7")]
		public bool SerializedOrientationAnchor
		{
			[Token(Token = "0x600053F")]
			[Address(RVA = "0x144CDA0", Offset = "0x144CDA0", VA = "0x144CDA0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000540")]
			[Address(RVA = "0x144CDA8", Offset = "0x144CDA8", VA = "0x144CDA8")]
			set
			{
			}
		}

		[Token(Token = "0x170000C8")]
		public CurvyOrientationSwirl Swirl
		{
			[Token(Token = "0x6000541")]
			[Address(RVA = "0x144CE14", Offset = "0x144CE14", VA = "0x144CE14")]
			get
			{
				return default(CurvyOrientationSwirl);
			}
			[Token(Token = "0x6000542")]
			[Address(RVA = "0x144CE1C", Offset = "0x144CE1C", VA = "0x144CE1C")]
			set
			{
			}
		}

		[Token(Token = "0x170000C9")]
		public float SwirlTurns
		{
			[Token(Token = "0x6000543")]
			[Address(RVA = "0x144CE58", Offset = "0x144CE58", VA = "0x144CE58")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000544")]
			[Address(RVA = "0x144CE60", Offset = "0x144CE60", VA = "0x144CE60")]
			set
			{
			}
		}

		[Token(Token = "0x170000CA")]
		public Vector3 HandleIn
		{
			[Token(Token = "0x6000545")]
			[Address(RVA = "0x144CE98", Offset = "0x144CE98", VA = "0x144CE98")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000546")]
			[Address(RVA = "0x144CEA4", Offset = "0x144CEA4", VA = "0x144CEA4")]
			set
			{
			}
		}

		[Token(Token = "0x170000CB")]
		public Vector3 HandleOut
		{
			[Token(Token = "0x6000547")]
			[Address(RVA = "0x144CF8C", Offset = "0x144CF8C", VA = "0x144CF8C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000548")]
			[Address(RVA = "0x144CF98", Offset = "0x144CF98", VA = "0x144CF98")]
			set
			{
			}
		}

		[Token(Token = "0x170000CC")]
		public Vector3 HandleInPosition
		{
			[Token(Token = "0x6000549")]
			[Address(RVA = "0x144D080", Offset = "0x144D080", VA = "0x144D080")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600054A")]
			[Address(RVA = "0x144D1B8", Offset = "0x144D1B8", VA = "0x144D1B8")]
			set
			{
			}
		}

		[Token(Token = "0x170000CD")]
		public Vector3 HandleOutPosition
		{
			[Token(Token = "0x600054B")]
			[Address(RVA = "0x144D294", Offset = "0x144D294", VA = "0x144D294")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600054C")]
			[Address(RVA = "0x144D3CC", Offset = "0x144D3CC", VA = "0x144D3CC")]
			set
			{
			}
		}

		[Token(Token = "0x170000CE")]
		public bool AutoHandles
		{
			[Token(Token = "0x600054D")]
			[Address(RVA = "0x144D4A8", Offset = "0x144D4A8", VA = "0x144D4A8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600054E")]
			[Address(RVA = "0x144D4B0", Offset = "0x144D4B0", VA = "0x144D4B0")]
			set
			{
			}
		}

		[Token(Token = "0x170000CF")]
		public float AutoHandleDistance
		{
			[Token(Token = "0x600054F")]
			[Address(RVA = "0x144D65C", Offset = "0x144D65C", VA = "0x144D65C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000550")]
			[Address(RVA = "0x144D664", Offset = "0x144D664", VA = "0x144D664")]
			set
			{
			}
		}

		[Token(Token = "0x170000D0")]
		public bool SynchronizeTCB
		{
			[Token(Token = "0x6000551")]
			[Address(RVA = "0x144D720", Offset = "0x144D720", VA = "0x144D720")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000552")]
			[Address(RVA = "0x144D728", Offset = "0x144D728", VA = "0x144D728")]
			set
			{
			}
		}

		[Token(Token = "0x170000D1")]
		public bool OverrideGlobalTension
		{
			[Token(Token = "0x6000553")]
			[Address(RVA = "0x144D770", Offset = "0x144D770", VA = "0x144D770")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000554")]
			[Address(RVA = "0x144D778", Offset = "0x144D778", VA = "0x144D778")]
			set
			{
			}
		}

		[Token(Token = "0x170000D2")]
		public bool OverrideGlobalContinuity
		{
			[Token(Token = "0x6000555")]
			[Address(RVA = "0x144D7C0", Offset = "0x144D7C0", VA = "0x144D7C0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000556")]
			[Address(RVA = "0x144D7C8", Offset = "0x144D7C8", VA = "0x144D7C8")]
			set
			{
			}
		}

		[Token(Token = "0x170000D3")]
		public bool OverrideGlobalBias
		{
			[Token(Token = "0x6000557")]
			[Address(RVA = "0x144D810", Offset = "0x144D810", VA = "0x144D810")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000558")]
			[Address(RVA = "0x144D818", Offset = "0x144D818", VA = "0x144D818")]
			set
			{
			}
		}

		[Token(Token = "0x170000D4")]
		public float StartTension
		{
			[Token(Token = "0x6000559")]
			[Address(RVA = "0x144D860", Offset = "0x144D860", VA = "0x144D860")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600055A")]
			[Address(RVA = "0x144D868", Offset = "0x144D868", VA = "0x144D868")]
			set
			{
			}
		}

		[Token(Token = "0x170000D5")]
		public float StartContinuity
		{
			[Token(Token = "0x600055B")]
			[Address(RVA = "0x144D8A0", Offset = "0x144D8A0", VA = "0x144D8A0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600055C")]
			[Address(RVA = "0x144D8A8", Offset = "0x144D8A8", VA = "0x144D8A8")]
			set
			{
			}
		}

		[Token(Token = "0x170000D6")]
		public float StartBias
		{
			[Token(Token = "0x600055D")]
			[Address(RVA = "0x144D8E0", Offset = "0x144D8E0", VA = "0x144D8E0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600055E")]
			[Address(RVA = "0x144D8E8", Offset = "0x144D8E8", VA = "0x144D8E8")]
			set
			{
			}
		}

		[Token(Token = "0x170000D7")]
		public float EndTension
		{
			[Token(Token = "0x600055F")]
			[Address(RVA = "0x144D920", Offset = "0x144D920", VA = "0x144D920")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000560")]
			[Address(RVA = "0x144D928", Offset = "0x144D928", VA = "0x144D928")]
			set
			{
			}
		}

		[Token(Token = "0x170000D8")]
		public float EndContinuity
		{
			[Token(Token = "0x6000561")]
			[Address(RVA = "0x144D960", Offset = "0x144D960", VA = "0x144D960")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000562")]
			[Address(RVA = "0x144D968", Offset = "0x144D968", VA = "0x144D968")]
			set
			{
			}
		}

		[Token(Token = "0x170000D9")]
		public float EndBias
		{
			[Token(Token = "0x6000563")]
			[Address(RVA = "0x144D9A0", Offset = "0x144D9A0", VA = "0x144D9A0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000564")]
			[Address(RVA = "0x144D9A8", Offset = "0x144D9A8", VA = "0x144D9A8")]
			set
			{
			}
		}

		[Token(Token = "0x170000DA")]
		public CurvySplineSegment FollowUp
		{
			[Token(Token = "0x6000565")]
			[Address(RVA = "0x144D9E0", Offset = "0x144D9E0", VA = "0x144D9E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000566")]
			[Address(RVA = "0x144D9E8", Offset = "0x144D9E8", VA = "0x144D9E8")]
			private set
			{
			}
		}

		[Token(Token = "0x170000DB")]
		public ConnectionHeadingEnum FollowUpHeading
		{
			[Token(Token = "0x6000567")]
			[Address(RVA = "0x144DAC8", Offset = "0x144DAC8", VA = "0x144DAC8")]
			get
			{
				return default(ConnectionHeadingEnum);
			}
			[Token(Token = "0x6000568")]
			[Address(RVA = "0x144DC2C", Offset = "0x144DC2C", VA = "0x144DC2C")]
			set
			{
			}
		}

		[Token(Token = "0x170000DC")]
		public bool ConnectionSyncPosition
		{
			[Token(Token = "0x6000569")]
			[Address(RVA = "0x144DD18", Offset = "0x144DD18", VA = "0x144DD18")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600056A")]
			[Address(RVA = "0x144DD20", Offset = "0x144DD20", VA = "0x144DD20")]
			set
			{
			}
		}

		[Token(Token = "0x170000DD")]
		public bool ConnectionSyncRotation
		{
			[Token(Token = "0x600056B")]
			[Address(RVA = "0x144DD40", Offset = "0x144DD40", VA = "0x144DD40")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600056C")]
			[Address(RVA = "0x144DD48", Offset = "0x144DD48", VA = "0x144DD48")]
			set
			{
			}
		}

		[Token(Token = "0x170000DE")]
		public CurvyConnection Connection
		{
			[Token(Token = "0x600056D")]
			[Address(RVA = "0x144DD68", Offset = "0x144DD68", VA = "0x144DD68")]
			get
			{
				return null;
			}
			[Token(Token = "0x600056E")]
			[Address(RVA = "0x144DD70", Offset = "0x144DD70", VA = "0x144DD70")]
			internal set
			{
			}
		}

		[Token(Token = "0x170000DF")]
		public int CacheSize
		{
			[Token(Token = "0x600056F")]
			[Address(RVA = "0x144DF2C", Offset = "0x144DF2C", VA = "0x144DF2C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000570")]
			[Address(RVA = "0x144DF34", Offset = "0x144DF34", VA = "0x144DF34")]
			private set
			{
			}
		}

		[Token(Token = "0x170000E0")]
		public Bounds Bounds
		{
			[Token(Token = "0x6000571")]
			[Address(RVA = "0x144DF3C", Offset = "0x144DF3C", VA = "0x144DF3C")]
			get
			{
				return default(Bounds);
			}
		}

		[Token(Token = "0x170000E1")]
		public float Length
		{
			[Token(Token = "0x6000572")]
			[Address(RVA = "0x144E1CC", Offset = "0x144E1CC", VA = "0x144E1CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x877078", Offset = "0x877078")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000573")]
			[Address(RVA = "0x144E1D4", Offset = "0x144E1D4", VA = "0x144E1D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x877088", Offset = "0x877088")]
			private set
			{
			}
		}

		[Token(Token = "0x170000E2")]
		public float Distance
		{
			[Token(Token = "0x6000574")]
			[Address(RVA = "0x144E1DC", Offset = "0x144E1DC", VA = "0x144E1DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x877098", Offset = "0x877098")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000575")]
			[Address(RVA = "0x144E1E4", Offset = "0x144E1E4", VA = "0x144E1E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8770A8", Offset = "0x8770A8")]
			internal set
			{
			}
		}

		[Token(Token = "0x170000E3")]
		public float TF
		{
			[Token(Token = "0x6000576")]
			[Address(RVA = "0x144E1EC", Offset = "0x144E1EC", VA = "0x144E1EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8770B8", Offset = "0x8770B8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000577")]
			[Address(RVA = "0x144E1F4", Offset = "0x144E1F4", VA = "0x144E1F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8770C8", Offset = "0x8770C8")]
			internal set
			{
			}
		}

		[Token(Token = "0x170000E4")]
		public bool IsFirstControlPoint
		{
			[Token(Token = "0x6000578")]
			[Address(RVA = "0x144E1FC", Offset = "0x144E1FC", VA = "0x144E1FC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000E5")]
		public bool IsLastControlPoint
		{
			[Token(Token = "0x6000579")]
			[Address(RVA = "0x144E22C", Offset = "0x144E22C", VA = "0x144E22C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000E6")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x878918", Offset = "0x878918")]
		public HashSet<Component> MetaDataSet
		{
			[Token(Token = "0x600057A")]
			[Address(RVA = "0x144E284", Offset = "0x144E284", VA = "0x144E284")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E7")]
		public HashSet<CurvyMetadataBase> Metadata
		{
			[Token(Token = "0x600057B")]
			[Address(RVA = "0x144E36C", Offset = "0x144E36C", VA = "0x144E36C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E8")]
		public CurvySpline Spline
		{
			[Token(Token = "0x600057C")]
			[Address(RVA = "0x144E374", Offset = "0x144E374", VA = "0x144E374")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E9")]
		public bool HasUnprocessedLocalPosition
		{
			[Token(Token = "0x600057D")]
			[Address(RVA = "0x144E37C", Offset = "0x144E37C", VA = "0x144E37C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000EA")]
		public bool HasUnprocessedLocalOrientation
		{
			[Token(Token = "0x600057E")]
			[Address(RVA = "0x144E448", Offset = "0x144E448", VA = "0x144E448")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000EB")]
		public bool OrientatinInfluencesSpline
		{
			[Token(Token = "0x600057F")]
			[Address(RVA = "0x144E48C", Offset = "0x144E48C", VA = "0x144E48C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000EC")]
		private CurvyInterpolation interpolation
		{
			[Token(Token = "0x60005AD")]
			[Address(RVA = "0x145215C", Offset = "0x145215C", VA = "0x145215C")]
			get
			{
				return default(CurvyInterpolation);
			}
		}

		[Token(Token = "0x170000ED")]
		private bool isDynamicOrientation
		{
			[Token(Token = "0x60005AE")]
			[Address(RVA = "0x14521E8", Offset = "0x14521E8", VA = "0x14521E8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000EE")]
		private bool IsOrientationAnchorEditable
		{
			[Token(Token = "0x60005AF")]
			[Address(RVA = "0x145227C", Offset = "0x145227C", VA = "0x145227C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000EF")]
		private bool canHaveSwirl
		{
			[Token(Token = "0x60005B0")]
			[Address(RVA = "0x1452384", Offset = "0x1452384", VA = "0x1452384")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0x144E53C", Offset = "0x144E53C", VA = "0x144E53C")]
		public void SetBezierHandleIn(Vector3 position, Space space = Space.Self, CurvyBezierModeEnum mode = CurvyBezierModeEnum.None)
		{
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0x144EA14", Offset = "0x144EA14", VA = "0x144EA14")]
		public void SetBezierHandleOut(Vector3 position, Space space = Space.Self, CurvyBezierModeEnum mode = CurvyBezierModeEnum.None)
		{
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0x144EEEC", Offset = "0x144EEEC", VA = "0x144EEEC")]
		public void SetBezierHandles(float distanceFrag = -1f, bool setIn = true, bool setOut = true, bool noDirtying = false)
		{
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0x144F1E0", Offset = "0x144F1E0", VA = "0x144F1E0")]
		public void SetBezierHandles(float distanceFrag, Vector3 p, Vector3 n, bool setIn = true, bool setOut = true, bool noDirtying = false)
		{
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0x144F3CC", Offset = "0x144F3CC", VA = "0x144F3CC")]
		public void SetFollowUp(CurvySplineSegment target, ConnectionHeadingEnum heading = ConnectionHeadingEnum.Auto)
		{
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0x144F584", Offset = "0x144F584", VA = "0x144F584")]
		public void Disconnect()
		{
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0x144F58C", Offset = "0x144F58C", VA = "0x144F58C")]
		public void Disconnect(bool destroyEmptyConnection)
		{
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0x144F658", Offset = "0x144F658", VA = "0x144F658")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x8770D8", Offset = "0x8770D8")]
		public void ResetConnectionRelatedData()
		{
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0x144F6AC", Offset = "0x144F6AC", VA = "0x144F6AC")]
		public Vector3 Interpolate(float localF, Space space = Space.Self)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0x144FA74", Offset = "0x144FA74", VA = "0x144FA74")]
		public Vector3 InterpolateFast(float localF, Space space = Space.Self)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0x144FC8C", Offset = "0x144FC8C", VA = "0x144FC8C")]
		public Vector3 GetTangent(float localF, Space space = Space.Self)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0x144FD44", Offset = "0x144FD44", VA = "0x144FD44")]
		public Vector3 GetTangent(float localF, Vector3 position, Space space = Space.Self)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0x144FF18", Offset = "0x144FF18", VA = "0x144FF18")]
		public Vector3 GetTangentFast(float localF, Space space = Space.Self)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0x145008C", Offset = "0x145008C", VA = "0x145008C")]
		public void InterpolateAndGetTangent(float localF, out Vector3 position, out Vector3 tangent, Space space = Space.Self)
		{
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0x1450168", Offset = "0x1450168", VA = "0x1450168")]
		public void InterpolateAndGetTangentFast(float localF, out Vector3 position, out Vector3 tangent, Space space = Space.Self)
		{
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0x1450384", Offset = "0x1450384", VA = "0x1450384")]
		public Vector3 GetOrientationUpFast(float localF, Space space = Space.Self)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0x14504F8", Offset = "0x14504F8", VA = "0x14504F8")]
		public Quaternion GetOrientationFast(float localF, bool inverse = false, Space space = Space.Self)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0x145068C", Offset = "0x145068C", VA = "0x145068C")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x877110", Offset = "0x877110")]
		public Vector3 InterpolateScale(float localF)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0x1450838", Offset = "0x1450838", VA = "0x1450838")]
		public void ReloadMetaData()
		{
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0x1450AEC", Offset = "0x1450AEC", VA = "0x1450AEC")]
		public void RegisterMetaData(CurvyMetadataBase metaData)
		{
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0x1450B5C", Offset = "0x1450B5C", VA = "0x1450B5C")]
		public void UnregisterMetaData(CurvyMetadataBase metaData)
		{
		}

		[Token(Token = "0x6000595")]
		public T GetMetadata<T>(bool autoCreate = false) where T : CurvyMetadataBase
		{
			return null;
		}

		[Token(Token = "0x6000596")]
		public U GetInterpolatedMetadata<T, U>(float f) where T : CurvyInterpolatableMetadataBase<U>
		{
			return (U)null;
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0x1450BC4", Offset = "0x1450BC4", VA = "0x1450BC4")]
		public void DeleteMetadata()
		{
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0x1450C78", Offset = "0x1450C78", VA = "0x1450C78")]
		public float GetNearestPointF(Vector3 position, Space space = Space.Self)
		{
			return default(float);
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0x1451110", Offset = "0x1451110", VA = "0x1451110")]
		public float DistanceToLocalF(float localDistance)
		{
			return default(float);
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0x1451394", Offset = "0x1451394", VA = "0x1451394")]
		public float LocalFToDistance(float localF)
		{
			return default(float);
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0x1451444", Offset = "0x1451444", VA = "0x1451444")]
		public float LocalFToTF(float localF)
		{
			return default(float);
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0x1451464", Offset = "0x1451464", VA = "0x1451464", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0x145152C", Offset = "0x145152C", VA = "0x145152C")]
		public void BakeOrientationToTransform()
		{
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0x144FB94", Offset = "0x144FB94", VA = "0x144FB94")]
		public int getApproximationIndexINTERNAL(float localF, out float frag)
		{
			return default(int);
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0x1451800", Offset = "0x1451800", VA = "0x1451800")]
		public void LinkToSpline(CurvySpline spline)
		{
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x1451808", Offset = "0x1451808", VA = "0x1451808")]
		public void UnlinkFromSpline()
		{
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x1451810", Offset = "0x1451810", VA = "0x1451810")]
		public void SetLocalPosition(Vector3 newPosition)
		{
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x1451A14", Offset = "0x1451A14", VA = "0x1451A14")]
		public void SetPosition(Vector3 value)
		{
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x14515D0", Offset = "0x14515D0", VA = "0x14515D0")]
		public void SetLocalRotation(Quaternion value)
		{
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x1451C18", Offset = "0x1451C18", VA = "0x1451C18")]
		public void SetRotation(Quaternion value)
		{
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x1451E48", Offset = "0x1451E48", VA = "0x1451E48")]
		public static bool CanFollowUpHeadToStart([NotNull] CurvySplineSegment followUp)
		{
			return default(bool);
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x1451E80", Offset = "0x1451E80", VA = "0x1451E80")]
		public static bool CanFollowUpHeadToEnd([NotNull] CurvySplineSegment followUp)
		{
			return default(bool);
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x1451EB8", Offset = "0x1451EB8", VA = "0x1451EB8", Slot = "4")]
		public void OnBeforePush()
		{
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x1451FA8", Offset = "0x1451FA8", VA = "0x1451FA8", Slot = "5")]
		public void OnAfterPop()
		{
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x145208C", Offset = "0x145208C", VA = "0x145208C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x1452150", Offset = "0x1452150", VA = "0x1452150")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x1452154", Offset = "0x1452154", VA = "0x1452154")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x1451FAC", Offset = "0x1451FAC", VA = "0x1451FAC")]
		public void Reset()
		{
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x1452484", Offset = "0x1452484", VA = "0x1452484")]
		internal void SetExtrinsicPropertiesINTERNAL(ControlPointExtrinsicProperties value)
		{
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x1452498", Offset = "0x1452498", VA = "0x1452498")]
		internal unsafe ref ControlPointExtrinsicProperties GetExtrinsicPropertiesINTERNAL()
		{
			return ref *(ControlPointExtrinsicProperties*)null;
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x145091C", Offset = "0x145091C", VA = "0x145091C")]
		private void CheckAgainstMetaDataDuplication()
		{
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x144DE2C", Offset = "0x144DE2C", VA = "0x144DE2C")]
		private bool SetConnection(CurvyConnection newConnection)
		{
			return default(bool);
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x144DB38", Offset = "0x144DB38", VA = "0x144DB38")]
		private static ConnectionHeadingEnum GetValidateConnectionHeading(ConnectionHeadingEnum connectionHeading, [CanBeNull] CurvySplineSegment followUp)
		{
			return default(ConnectionHeadingEnum);
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x144D4FC", Offset = "0x144D4FC", VA = "0x144D4FC")]
		private bool SetAutoHandles(bool newValue)
		{
			return default(bool);
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x1451100", Offset = "0x1451100", VA = "0x1451100")]
		private float getApproximationLocalF(int idx)
		{
			return default(float);
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x1452508", Offset = "0x1452508", VA = "0x1452508")]
		internal void refreshCurveINTERNAL()
		{
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x1452B84", Offset = "0x1452B84", VA = "0x1452B84")]
		private float InterpolateBezierSegment(CurvySplineSegment nextControlPoint, int newCacheSize)
		{
			return default(float);
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x14533E8", Offset = "0x14533E8", VA = "0x14533E8")]
		private float InterpolateTCBSegment(CurvySplineSegment nextControlPoint, int newCacheSize, float splineTension, float splineContinuity, float splineBias)
		{
			return default(float);
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x1452FBC", Offset = "0x1452FBC", VA = "0x1452FBC")]
		private float InterpolateCatmullSegment(CurvySplineSegment nextControlPoint, int newCacheSize)
		{
			return default(float);
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x145395C", Offset = "0x145395C", VA = "0x145395C")]
		private float InterpolateLinearSegment(CurvySplineSegment nextControlPoint, int newCacheSize)
		{
			return default(float);
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x1453C08", Offset = "0x1453C08", VA = "0x1453C08")]
		internal void refreshOrientationNoneINTERNAL()
		{
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x1453C4C", Offset = "0x1453C4C", VA = "0x1453C4C")]
		internal void refreshOrientationStaticINTERNAL()
		{
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x14540B0", Offset = "0x14540B0", VA = "0x14540B0")]
		internal void refreshOrientationDynamicINTERNAL(Vector3 initialUp)
		{
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x14542E8", Offset = "0x14542E8", VA = "0x14542E8")]
		internal void ClearBoundsINTERNAL()
		{
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x1453DE8", Offset = "0x1453DE8", VA = "0x1453DE8")]
		internal Vector3 getOrthoUp0INTERNAL()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x1453F18", Offset = "0x1453F18", VA = "0x1453F18")]
		private Vector3 getOrthoUp1INTERNAL()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x1454308", Offset = "0x1454308", VA = "0x1454308")]
		internal void UnsetFollowUpWithoutDirtyingINTERNAL()
		{
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x1454318", Offset = "0x1454318", VA = "0x1454318")]
		internal void PrepareThreadCompatibleDataINTERNAL(bool useFollowUp)
		{
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x14545F0", Offset = "0x14545F0", VA = "0x14545F0")]
		public CurvySplineSegment()
		{
		}
	}
	[Token(Token = "0x2000096")]
	public static class CurvySplineSegmentDefaultValues
	{
		[Token(Token = "0x4000225")]
		public const CurvyOrientationSwirl Swirl = CurvyOrientationSwirl.None;

		[Token(Token = "0x4000226")]
		public const bool AutoHandles = true;

		[Token(Token = "0x4000227")]
		public const float AutoHandleDistance = 0.39f;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Vector3 HandleIn;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public static readonly Vector3 HandleOut;
	}
	[Token(Token = "0x2000097")]
	public static class CurvySplineDefaultValues
	{
		[Token(Token = "0x400022A")]
		public const bool AutoEndTangents = true;

		[Token(Token = "0x400022B")]
		public const CurvyOrientation Orientation = CurvyOrientation.Dynamic;

		[Token(Token = "0x400022C")]
		public const float AutoHandleDistance = 0.39f;

		[Token(Token = "0x400022D")]
		public const int CacheDensity = 50;

		[Token(Token = "0x400022E")]
		public const float MaxPointsPerUnit = 8f;

		[Token(Token = "0x400022F")]
		public const bool UsePooling = true;

		[Token(Token = "0x4000230")]
		public const CurvyUpdateMethod UpdateIn = CurvyUpdateMethod.Update;

		[Token(Token = "0x4000231")]
		public const bool CheckTransform = true;
	}
	[Token(Token = "0x2000098")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x864DC4", Offset = "0x864DC4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x864DC4", Offset = "0x864DC4")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x864DC4", Offset = "0x864DC4")]
	public class CurvyUISpline : CurvySpline
	{
		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x145481C", Offset = "0x145481C", VA = "0x145481C")]
		public static CurvyUISpline CreateUISpline(string gameObjectName = "Curvy UI Spline")
		{
			return null;
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x1454990", Offset = "0x1454990", VA = "0x1454990", Slot = "4")]
		protected override void Reset()
		{
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x145494C", Offset = "0x145494C", VA = "0x145494C")]
		private void SetupUISpline()
		{
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x14549B8", Offset = "0x14549B8", VA = "0x14549B8")]
		public CurvyUISpline()
		{
		}
	}
}
namespace FluffyUnderware.Curvy.ThirdParty.LibTessDotNet
{
	[Token(Token = "0x2000099")]
	internal class Dict<TValue> where TValue : class
	{
		[Token(Token = "0x200017E")]
		public class Node
		{
			[Token(Token = "0x400066D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal TValue _key;

			[Token(Token = "0x400066E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal Node _prev;

			[Token(Token = "0x400066F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal Node _next;

			[Token(Token = "0x170002D9")]
			public TValue Key
			{
				[Token(Token = "0x6000D31")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170002DA")]
			public Node Prev
			{
				[Token(Token = "0x6000D32")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170002DB")]
			public Node Next
			{
				[Token(Token = "0x6000D33")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000D34")]
			public Node()
			{
			}
		}

		[Token(Token = "0x200017F")]
		public delegate bool LessOrEqual(TValue lhs, TValue rhs);

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private LessOrEqual _leq;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Node _head;

		[Token(Token = "0x60005CC")]
		public Dict(LessOrEqual leq)
		{
		}

		[Token(Token = "0x60005CD")]
		public Node Insert(TValue key)
		{
			return null;
		}

		[Token(Token = "0x60005CE")]
		public Node InsertBefore(Node node, TValue key)
		{
			return null;
		}

		[Token(Token = "0x60005CF")]
		public Node Find(TValue key)
		{
			return null;
		}

		[Token(Token = "0x60005D0")]
		public Node Min()
		{
			return null;
		}

		[Token(Token = "0x60005D1")]
		public void Remove(Node node)
		{
		}
	}
	[Token(Token = "0x200009A")]
	internal static class Geom
	{
		[Token(Token = "0x60005D2")]
		[Address(RVA = "0x145BE00", Offset = "0x145BE00", VA = "0x145BE00")]
		public static bool IsWindingInside(WindingRule rule, int n)
		{
			return default(bool);
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x145BEDC", Offset = "0x145BEDC", VA = "0x145BEDC")]
		public static bool VertCCW(MeshUtils.Vertex u, MeshUtils.Vertex v, MeshUtils.Vertex w)
		{
			return default(bool);
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x145BF30", Offset = "0x145BF30", VA = "0x145BF30")]
		public static bool VertEq(MeshUtils.Vertex lhs, MeshUtils.Vertex rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x145BF74", Offset = "0x145BF74", VA = "0x145BF74")]
		public static bool VertLeq(MeshUtils.Vertex lhs, MeshUtils.Vertex rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x145BFC4", Offset = "0x145BFC4", VA = "0x145BFC4")]
		public static float EdgeEval(MeshUtils.Vertex u, MeshUtils.Vertex v, MeshUtils.Vertex w)
		{
			return default(float);
		}

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x145C038", Offset = "0x145C038", VA = "0x145C038")]
		public static float EdgeSign(MeshUtils.Vertex u, MeshUtils.Vertex v, MeshUtils.Vertex w)
		{
			return default(float);
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x145C09C", Offset = "0x145C09C", VA = "0x145C09C")]
		public static bool TransLeq(MeshUtils.Vertex lhs, MeshUtils.Vertex rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x145C0EC", Offset = "0x145C0EC", VA = "0x145C0EC")]
		public static float TransEval(MeshUtils.Vertex u, MeshUtils.Vertex v, MeshUtils.Vertex w)
		{
			return default(float);
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0x145C160", Offset = "0x145C160", VA = "0x145C160")]
		public static float TransSign(MeshUtils.Vertex u, MeshUtils.Vertex v, MeshUtils.Vertex w)
		{
			return default(float);
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x145C1C4", Offset = "0x145C1C4", VA = "0x145C1C4")]
		public static bool EdgeGoesLeft(MeshUtils.Edge e)
		{
			return default(bool);
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0x145C1F4", Offset = "0x145C1F4", VA = "0x145C1F4")]
		public static bool EdgeGoesRight(MeshUtils.Edge e)
		{
			return default(bool);
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x145C228", Offset = "0x145C228", VA = "0x145C228")]
		public static float VertL1dist(MeshUtils.Vertex u, MeshUtils.Vertex v)
		{
			return default(float);
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x145C2C4", Offset = "0x145C2C4", VA = "0x145C2C4")]
		public static void AddWinding(MeshUtils.Edge eDst, MeshUtils.Edge eSrc)
		{
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x145C310", Offset = "0x145C310", VA = "0x145C310")]
		public static float Interpolate(float a, float x, float b, float y)
		{
			return default(float);
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x145C36C", Offset = "0x145C36C", VA = "0x145C36C")]
		private static void Swap(ref MeshUtils.Vertex a, ref MeshUtils.Vertex b)
		{
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0x145C380", Offset = "0x145C380", VA = "0x145C380")]
		public static void EdgeIntersect(MeshUtils.Vertex o1, MeshUtils.Vertex d1, MeshUtils.Vertex o2, MeshUtils.Vertex d2, MeshUtils.Vertex v)
		{
		}
	}
	[Token(Token = "0x200009B")]
	internal class LTMesh : MeshUtils.Pooled<LTMesh>
	{
		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal MeshUtils.Vertex _vHead;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal MeshUtils.Face _fHead;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal MeshUtils.Edge _eHead;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal MeshUtils.Edge _eHeadSym;

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0xDEA294", Offset = "0xDEA294", VA = "0xDEA294")]
		public LTMesh()
		{
		}

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0xDEA37C", Offset = "0xDEA37C", VA = "0xDEA37C", Slot = "4")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0xDEA388", Offset = "0xDEA388", VA = "0xDEA388", Slot = "5")]
		public override void OnFree()
		{
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0xDEA488", Offset = "0xDEA488", VA = "0xDEA488")]
		public MeshUtils.Edge MakeEdge()
		{
			return null;
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0xDEA6C8", Offset = "0xDEA6C8", VA = "0xDEA6C8")]
		public void Splice(MeshUtils.Edge eOrg, MeshUtils.Edge eDst)
		{
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0xDEA904", Offset = "0xDEA904", VA = "0xDEA904")]
		public void Delete(MeshUtils.Edge eDel)
		{
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0xDEAAF8", Offset = "0xDEAAF8", VA = "0xDEAAF8")]
		public MeshUtils.Edge AddEdgeVertex(MeshUtils.Edge eOrg)
		{
			return null;
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0xDEAB70", Offset = "0xDEAB70", VA = "0xDEAB70")]
		public MeshUtils.Edge SplitEdge(MeshUtils.Edge eOrg)
		{
			return null;
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0xDEAC40", Offset = "0xDEAC40", VA = "0xDEAC40")]
		public MeshUtils.Edge Connect(MeshUtils.Edge eOrg, MeshUtils.Edge eDst)
		{
			return null;
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0xDEAD10", Offset = "0xDEAD10", VA = "0xDEAD10")]
		public void ZapFace(MeshUtils.Face fZap)
		{
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0xDEAE4C", Offset = "0xDEAE4C", VA = "0xDEAE4C")]
		public void MergeConvexFaces(int maxVertsPerFace)
		{
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0xDEAFB8", Offset = "0xDEAFB8", VA = "0xDEAFB8")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x877148", Offset = "0x877148")]
		public void Check()
		{
		}
	}
	[Token(Token = "0x200009C")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x864E74", Offset = "0x864E74")]
	public struct Vec3
	{
		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Vec3 Zero;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float X;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float Y;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float Z;

		[Token(Token = "0x170000F0")]
		public float Item
		{
			[Token(Token = "0x60005EE")]
			[Address(RVA = "0x9E0BBC", Offset = "0x9E0BBC", VA = "0x9E0BBC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60005EF")]
			[Address(RVA = "0x9E0BC4", Offset = "0x9E0BC4", VA = "0x9E0BC4")]
			set
			{
			}
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x1814440", Offset = "0x1814440", VA = "0x1814440")]
		public static void Sub(ref Vec3 lhs, ref Vec3 rhs, out Vec3 result)
		{
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x1814474", Offset = "0x1814474", VA = "0x1814474")]
		public static void Neg(ref Vec3 v)
		{
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x1814490", Offset = "0x1814490", VA = "0x1814490")]
		public static void Dot(ref Vec3 u, ref Vec3 v, out float dot)
		{
		}

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x18144BC", Offset = "0x18144BC", VA = "0x18144BC")]
		public static void Normalize(ref Vec3 v)
		{
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x1814574", Offset = "0x1814574", VA = "0x1814574")]
		public static int LongAxis(ref Vec3 v)
		{
			return default(int);
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x9E0BCC", Offset = "0x9E0BCC", VA = "0x9E0BCC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x200009D")]
	internal static class MeshUtils
	{
		[Token(Token = "0x2000180")]
		public abstract class Pooled<T> where T : Pooled<T>, new()
		{
			[Token(Token = "0x4000670")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static Stack<T> _stack;

			[Token(Token = "0x6000D39")]
			public abstract void Reset();

			[Token(Token = "0x6000D3A")]
			public virtual void OnFree()
			{
			}

			[Token(Token = "0x6000D3B")]
			public static T Create()
			{
				return null;
			}

			[Token(Token = "0x6000D3C")]
			public void Free()
			{
			}

			[Token(Token = "0x6000D3D")]
			protected Pooled()
			{
			}
		}

		[Token(Token = "0x2000181")]
		public class Vertex : Pooled<Vertex>
		{
			[Token(Token = "0x4000671")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal Vertex _prev;

			[Token(Token = "0x4000672")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal Vertex _next;

			[Token(Token = "0x4000673")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal Edge _anEdge;

			[Token(Token = "0x4000674")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal Vec3 _coords;

			[Token(Token = "0x4000675")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			internal float _s;

			[Token(Token = "0x4000676")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal float _t;

			[Token(Token = "0x4000677")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			internal PQHandle _pqHandle;

			[Token(Token = "0x4000678")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal int _n;

			[Token(Token = "0x4000679")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			internal object _data;

			[Token(Token = "0x6000D3E")]
			[Address(RVA = "0x181BD98", Offset = "0x181BD98", VA = "0x181BD98", Slot = "4")]
			public override void Reset()
			{
			}

			[Token(Token = "0x6000D3F")]
			[Address(RVA = "0x181BE24", Offset = "0x181BE24", VA = "0x181BE24")]
			public Vertex()
			{
			}
		}

		[Token(Token = "0x2000182")]
		public class Face : Pooled<Face>
		{
			[Token(Token = "0x400067A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal Face _prev;

			[Token(Token = "0x400067B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal Face _next;

			[Token(Token = "0x400067C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal Edge _anEdge;

			[Token(Token = "0x400067D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal Face _trail;

			[Token(Token = "0x400067E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal int _n;

			[Token(Token = "0x400067F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			internal bool _marked;

			[Token(Token = "0x4000680")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
			internal bool _inside;

			[Token(Token = "0x170002DC")]
			internal int VertsCount
			{
				[Token(Token = "0x6000D40")]
				[Address(RVA = "0x181BD04", Offset = "0x181BD04", VA = "0x181BD04")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x6000D41")]
			[Address(RVA = "0x181BD38", Offset = "0x181BD38", VA = "0x181BD38", Slot = "4")]
			public override void Reset()
			{
			}

			[Token(Token = "0x6000D42")]
			[Address(RVA = "0x181BD48", Offset = "0x181BD48", VA = "0x181BD48")]
			public Face()
			{
			}
		}

		[Token(Token = "0x2000183")]
		public struct EdgePair
		{
			[Token(Token = "0x4000681")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal Edge _e;

			[Token(Token = "0x4000682")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal Edge _eSym;

			[Token(Token = "0x6000D43")]
			[Address(RVA = "0x181BC90", Offset = "0x181BC90", VA = "0x181BC90")]
			public static EdgePair Create()
			{
				return default(EdgePair);
			}

			[Token(Token = "0x6000D44")]
			[Address(RVA = "0x9E0D7C", Offset = "0x9E0D7C", VA = "0x9E0D7C")]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x2000184")]
		public class Edge : Pooled<Edge>
		{
			[Token(Token = "0x4000683")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal EdgePair _pair;

			[Token(Token = "0x4000684")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal Edge _next;

			[Token(Token = "0x4000685")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal Edge _Sym;

			[Token(Token = "0x4000686")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal Edge _Onext;

			[Token(Token = "0x4000687")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal Edge _Lnext;

			[Token(Token = "0x4000688")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal Vertex _Org;

			[Token(Token = "0x4000689")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			internal Face _Lface;

			[Token(Token = "0x400068A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			internal Tess.ActiveRegion _activeRegion;

			[Token(Token = "0x400068B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			internal int _winding;

			[Token(Token = "0x170002DD")]
			internal Face _Rface
			{
				[Token(Token = "0x6000D45")]
				[Address(RVA = "0x181B9F8", Offset = "0x181B9F8", VA = "0x181B9F8")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000D46")]
				[Address(RVA = "0x181BA14", Offset = "0x181BA14", VA = "0x181BA14")]
				set
				{
				}
			}

			[Token(Token = "0x170002DE")]
			internal Vertex _Dst
			{
				[Token(Token = "0x6000D47")]
				[Address(RVA = "0x181BA30", Offset = "0x181BA30", VA = "0x181BA30")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000D48")]
				[Address(RVA = "0x181BA4C", Offset = "0x181BA4C", VA = "0x181BA4C")]
				set
				{
				}
			}

			[Token(Token = "0x170002DF")]
			internal Edge _Oprev
			{
				[Token(Token = "0x6000D49")]
				[Address(RVA = "0x181BA68", Offset = "0x181BA68", VA = "0x181BA68")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000D4A")]
				[Address(RVA = "0x181BA84", Offset = "0x181BA84", VA = "0x181BA84")]
				set
				{
				}
			}

			[Token(Token = "0x170002E0")]
			internal Edge _Lprev
			{
				[Token(Token = "0x6000D4B")]
				[Address(RVA = "0x181BAA0", Offset = "0x181BAA0", VA = "0x181BAA0")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000D4C")]
				[Address(RVA = "0x181BABC", Offset = "0x181BABC", VA = "0x181BABC")]
				set
				{
				}
			}

			[Token(Token = "0x170002E1")]
			internal Edge _Dprev
			{
				[Token(Token = "0x6000D4D")]
				[Address(RVA = "0x181BAD8", Offset = "0x181BAD8", VA = "0x181BAD8")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000D4E")]
				[Address(RVA = "0x181BAF4", Offset = "0x181BAF4", VA = "0x181BAF4")]
				set
				{
				}
			}

			[Token(Token = "0x170002E2")]
			internal Edge _Rprev
			{
				[Token(Token = "0x6000D4F")]
				[Address(RVA = "0x181BB10", Offset = "0x181BB10", VA = "0x181BB10")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000D50")]
				[Address(RVA = "0x181BB2C", Offset = "0x181BB2C", VA = "0x181BB2C")]
				set
				{
				}
			}

			[Token(Token = "0x170002E3")]
			internal Edge _Dnext
			{
				[Token(Token = "0x6000D51")]
				[Address(RVA = "0x181BB48", Offset = "0x181BB48", VA = "0x181BB48")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000D52")]
				[Address(RVA = "0x181BB70", Offset = "0x181BB70", VA = "0x181BB70")]
				set
				{
				}
			}

			[Token(Token = "0x170002E4")]
			internal Edge _Rnext
			{
				[Token(Token = "0x6000D53")]
				[Address(RVA = "0x181BB98", Offset = "0x181BB98", VA = "0x181BB98")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000D54")]
				[Address(RVA = "0x181BBC0", Offset = "0x181BBC0", VA = "0x181BBC0")]
				set
				{
				}
			}

			[Token(Token = "0x6000D55")]
			[Address(RVA = "0x181BBE8", Offset = "0x181BBE8", VA = "0x181BBE8")]
			internal static void EnsureFirst(ref Edge e)
			{
			}

			[Token(Token = "0x6000D56")]
			[Address(RVA = "0x181BC18", Offset = "0x181BC18", VA = "0x181BC18", Slot = "4")]
			public override void Reset()
			{
			}

			[Token(Token = "0x6000D57")]
			[Address(RVA = "0x181BC40", Offset = "0x181BC40", VA = "0x181BC40")]
			public Edge()
			{
			}
		}

		[Token(Token = "0x400023C")]
		public const int Undef = -1;

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0xDEA4DC", Offset = "0xDEA4DC", VA = "0xDEA4DC")]
		public static Edge MakeEdge(Edge eNext)
		{
			return null;
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0xDEA8B8", Offset = "0xDEA8B8", VA = "0xDEA8B8")]
		public static void Splice(Edge a, Edge b)
		{
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0xDEA584", Offset = "0xDEA584", VA = "0xDEA584")]
		public static void MakeVertex(Edge eOrig, Vertex vNext)
		{
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0xDEA620", Offset = "0xDEA620", VA = "0xDEA620")]
		public static void MakeFace(Edge eOrig, Face fNext)
		{
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0xDEAA60", Offset = "0xDEAA60", VA = "0xDEAA60")]
		public static void KillEdge(Edge eDel)
		{
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0xDEA788", Offset = "0xDEA788", VA = "0xDEA788")]
		public static void KillVertex(Vertex vDel, Vertex newOrg)
		{
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0xDEA820", Offset = "0xDEA820", VA = "0xDEA820")]
		public static void KillFace(Face fDel, Face newLFace)
		{
		}

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0xDED53C", Offset = "0xDED53C", VA = "0xDED53C")]
		public static float FaceArea(Face f)
		{
			return default(float);
		}
	}
	[Token(Token = "0x200009E")]
	internal struct PQHandle
	{
		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly int Invalid;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal int _handle;
	}
	[Token(Token = "0x200009F")]
	internal class PriorityHeap<TValue> where TValue : class
	{
		[Token(Token = "0x2000185")]
		public delegate bool LessOrEqual(TValue lhs, TValue rhs);

		[Token(Token = "0x2000186")]
		protected class HandleElem
		{
			[Token(Token = "0x400068C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal TValue _key;

			[Token(Token = "0x400068D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal int _node;

			[Token(Token = "0x6000D5C")]
			public HandleElem()
			{
			}
		}

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private LessOrEqual _leq;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int[] _nodes;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private HandleElem[] _handles;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int _size;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int _max;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int _freeList;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool _initialized;

		[Token(Token = "0x170000F1")]
		public bool Empty
		{
			[Token(Token = "0x6000600")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000601")]
		public PriorityHeap(int initialSize, LessOrEqual leq)
		{
		}

		[Token(Token = "0x6000602")]
		private void FloatDown(int curr)
		{
		}

		[Token(Token = "0x6000603")]
		private void FloatUp(int curr)
		{
		}

		[Token(Token = "0x6000604")]
		public void Init()
		{
		}

		[Token(Token = "0x6000605")]
		public PQHandle Insert(TValue value)
		{
			return default(PQHandle);
		}

		[Token(Token = "0x6000606")]
		public TValue ExtractMin()
		{
			return null;
		}

		[Token(Token = "0x6000607")]
		public TValue Minimum()
		{
			return null;
		}

		[Token(Token = "0x6000608")]
		public void Remove(PQHandle handle)
		{
		}
	}
	[Token(Token = "0x20000A0")]
	internal class PriorityQueue<TValue> where TValue : class
	{
		[Token(Token = "0x2000187")]
		private class StackItem
		{
			[Token(Token = "0x400068E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal int p;

			[Token(Token = "0x400068F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal int r;

			[Token(Token = "0x6000D5D")]
			public StackItem()
			{
			}
		}

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private PriorityHeap<TValue>.LessOrEqual _leq;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private PriorityHeap<TValue> _heap;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private TValue[] _keys;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int[] _order;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int _size;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int _max;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool _initialized;

		[Token(Token = "0x170000F2")]
		public bool Empty
		{
			[Token(Token = "0x6000609")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600060A")]
		public PriorityQueue(int initialSize, PriorityHeap<TValue>.LessOrEqual leq)
		{
		}

		[Token(Token = "0x600060B")]
		private static void Swap(ref int a, ref int b)
		{
		}

		[Token(Token = "0x600060C")]
		public void Init()
		{
		}

		[Token(Token = "0x600060D")]
		public PQHandle Insert(TValue value)
		{
			return default(PQHandle);
		}

		[Token(Token = "0x600060E")]
		public TValue ExtractMin()
		{
			return null;
		}

		[Token(Token = "0x600060F")]
		public TValue Minimum()
		{
			return null;
		}

		[Token(Token = "0x6000610")]
		public void Remove(PQHandle handle)
		{
		}
	}
	[Token(Token = "0x20000A1")]
	public class Tess
	{
		[Token(Token = "0x2000188")]
		internal class ActiveRegion
		{
			[Token(Token = "0x4000690")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal MeshUtils.Edge _eUp;

			[Token(Token = "0x4000691")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal Dict<ActiveRegion>.Node _nodeUp;

			[Token(Token = "0x4000692")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal int _windingNumber;

			[Token(Token = "0x4000693")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			internal bool _inside;

			[Token(Token = "0x4000694")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
			internal bool _sentinel;

			[Token(Token = "0x4000695")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
			internal bool _dirty;

			[Token(Token = "0x4000696")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x27")]
			internal bool _fixUpperEdge;

			[Token(Token = "0x6000D5E")]
			[Address(RVA = "0x181C180", Offset = "0x181C180", VA = "0x181C180")]
			public ActiveRegion()
			{
			}
		}

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private LTMesh _mesh;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Vec3 _normal;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vec3 _sUnit;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vec3 _tUnit;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float _bminX;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float _bminY;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float _bmaxX;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float _bmaxY;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private WindingRule _windingRule;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Dict<ActiveRegion> _dict;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private PriorityQueue<MeshUtils.Vertex> _pq;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private MeshUtils.Vertex _event;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private CombineCallback _combineCallback;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private ContourVertex[] _vertices;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int _vertexCount;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int[] _elements;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private int _elementCount;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float SUnitX;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float SUnitY;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public float SentinelCoord;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public bool NoEmptyPolygons;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x99")]
		public bool UsePooling;

		[Token(Token = "0x170000F3")]
		public Vec3 Normal
		{
			[Token(Token = "0x6000630")]
			[Address(RVA = "0xB20214", Offset = "0xB20214", VA = "0xB20214")]
			get
			{
				return default(Vec3);
			}
			[Token(Token = "0x6000631")]
			[Address(RVA = "0xB20220", Offset = "0xB20220", VA = "0xB20220")]
			set
			{
			}
		}

		[Token(Token = "0x170000F4")]
		public ContourVertex[] Vertices
		{
			[Token(Token = "0x6000632")]
			[Address(RVA = "0xB2022C", Offset = "0xB2022C", VA = "0xB2022C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F5")]
		public int VertexCount
		{
			[Token(Token = "0x6000633")]
			[Address(RVA = "0xB20234", Offset = "0xB20234", VA = "0xB20234")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000F6")]
		public int[] Elements
		{
			[Token(Token = "0x6000634")]
			[Address(RVA = "0xB2023C", Offset = "0xB2023C", VA = "0xB2023C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F7")]
		public int ElementCount
		{
			[Token(Token = "0x6000635")]
			[Address(RVA = "0xB20244", Offset = "0xB20244", VA = "0xB20244")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0xB1DC18", Offset = "0xB1DC18", VA = "0xB1DC18")]
		private ActiveRegion RegionBelow(ActiveRegion reg)
		{
			return null;
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0xB1DC44", Offset = "0xB1DC44", VA = "0xB1DC44")]
		private ActiveRegion RegionAbove(ActiveRegion reg)
		{
			return null;
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0xB1DC70", Offset = "0xB1DC70", VA = "0xB1DC70")]
		private bool EdgeLeq(ActiveRegion reg1, ActiveRegion reg2)
		{
			return default(bool);
		}

		[Token(Token = "0x6000614")]
		[Address(RVA = "0xB1DDB8", Offset = "0xB1DDB8", VA = "0xB1DDB8")]
		private void DeleteRegion(ActiveRegion reg)
		{
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0xB1DE30", Offset = "0xB1DE30", VA = "0xB1DE30")]
		private void FixUpperEdge(ActiveRegion reg, MeshUtils.Edge newEdge)
		{
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0xB1DE7C", Offset = "0xB1DE7C", VA = "0xB1DE7C")]
		private ActiveRegion TopLeftRegion(ActiveRegion reg)
		{
			return null;
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0xB1DF44", Offset = "0xB1DF44", VA = "0xB1DF44")]
		private ActiveRegion TopRightRegion(ActiveRegion reg)
		{
			return null;
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0xB1DFA8", Offset = "0xB1DFA8", VA = "0xB1DFA8")]
		private ActiveRegion AddRegionBelow(ActiveRegion regAbove, MeshUtils.Edge eNewUp)
		{
			return null;
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0xB1E05C", Offset = "0xB1E05C", VA = "0xB1E05C")]
		private void ComputeWinding(ActiveRegion reg)
		{
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0xB1E0B8", Offset = "0xB1E0B8", VA = "0xB1E0B8")]
		private void FinishRegion(ActiveRegion reg)
		{
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0xB1E0EC", Offset = "0xB1E0EC", VA = "0xB1E0EC")]
		private MeshUtils.Edge FinishLeftRegions(ActiveRegion regFirst, ActiveRegion regLast)
		{
			return null;
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0xB1E230", Offset = "0xB1E230", VA = "0xB1E230")]
		private void AddRightEdges(ActiveRegion regUp, MeshUtils.Edge eFirst, MeshUtils.Edge eLast, MeshUtils.Edge eTopLeft, bool cleanUp)
		{
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0xB1E870", Offset = "0xB1E870", VA = "0xB1E870")]
		private void SpliceMergeVertices(MeshUtils.Edge e1, MeshUtils.Edge e2)
		{
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0xB1E88C", Offset = "0xB1E88C", VA = "0xB1E88C")]
		private void VertexWeights(MeshUtils.Vertex isect, MeshUtils.Vertex org, MeshUtils.Vertex dst, out float w0, out float w1)
		{
		}

		[Token(Token = "0x600061F")]
		[Address(RVA = "0xB1E990", Offset = "0xB1E990", VA = "0xB1E990")]
		private void GetIntersectData(MeshUtils.Vertex isect, MeshUtils.Vertex orgUp, MeshUtils.Vertex dstUp, MeshUtils.Vertex orgLo, MeshUtils.Vertex dstLo)
		{
		}

		[Token(Token = "0x6000620")]
		[Address(RVA = "0xB1E420", Offset = "0xB1E420", VA = "0xB1E420")]
		private bool CheckForRightSplice(ActiveRegion regUp)
		{
			return default(bool);
		}

		[Token(Token = "0x6000621")]
		[Address(RVA = "0xB1EC0C", Offset = "0xB1EC0C", VA = "0xB1EC0C")]
		private bool CheckForLeftSplice(ActiveRegion regUp)
		{
			return default(bool);
		}

		[Token(Token = "0x6000622")]
		[Address(RVA = "0xB1EDCC", Offset = "0xB1EDCC", VA = "0xB1EDCC")]
		private bool CheckForIntersect(ActiveRegion regUp)
		{
			return default(bool);
		}

		[Token(Token = "0x6000623")]
		[Address(RVA = "0xB1E608", Offset = "0xB1E608", VA = "0xB1E608")]
		private void WalkDirtyRegions(ActiveRegion regUp)
		{
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0xB1F460", Offset = "0xB1F460", VA = "0xB1F460")]
		private void ConnectRightVertex(ActiveRegion regUp, MeshUtils.Edge eBottomLeft)
		{
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0xB1F698", Offset = "0xB1F698", VA = "0xB1F698")]
		private void ConnectLeftDegenerate(ActiveRegion regUp, MeshUtils.Vertex vEvent)
		{
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0xB1F894", Offset = "0xB1F894", VA = "0xB1F894")]
		private void ConnectLeftVertex(MeshUtils.Vertex vEvent)
		{
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0xB1F7BC", Offset = "0xB1F7BC", VA = "0xB1F7BC")]
		private void SweepEvent(MeshUtils.Vertex vEvent)
		{
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0xB1FADC", Offset = "0xB1FADC", VA = "0xB1FADC")]
		private void AddSentinel(float smin, float smax, float t)
		{
		}

		[Token(Token = "0x6000629")]
		[Address(RVA = "0xB1FBF8", Offset = "0xB1FBF8", VA = "0xB1FBF8")]
		private void InitEdgeDict()
		{
		}

		[Token(Token = "0x600062A")]
		[Address(RVA = "0xB1FCC4", Offset = "0xB1FCC4", VA = "0xB1FCC4")]
		private void DoneEdgeDict()
		{
		}

		[Token(Token = "0x600062B")]
		[Address(RVA = "0xB1FD40", Offset = "0xB1FD40", VA = "0xB1FD40")]
		private void RemoveDegenerateEdges()
		{
		}

		[Token(Token = "0x600062C")]
		[Address(RVA = "0xB1FEA0", Offset = "0xB1FEA0", VA = "0xB1FEA0")]
		private void InitPriorityQ()
		{
		}

		[Token(Token = "0x600062D")]
		[Address(RVA = "0xB2005C", Offset = "0xB2005C", VA = "0xB2005C")]
		private void DonePriorityQ()
		{
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0xB20064", Offset = "0xB20064", VA = "0xB20064")]
		private void RemoveDegenerateFaces()
		{
		}

		[Token(Token = "0x600062F")]
		[Address(RVA = "0xB20104", Offset = "0xB20104", VA = "0xB20104")]
		protected void ComputeInterior()
		{
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0xB16BA4", Offset = "0xB16BA4", VA = "0xB16BA4")]
		public Tess()
		{
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0xB2024C", Offset = "0xB2024C", VA = "0xB2024C")]
		private void ComputeNormal(ref Vec3 norm)
		{
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0xB20880", Offset = "0xB20880", VA = "0xB20880")]
		private void CheckOrientation()
		{
		}

		[Token(Token = "0x6000639")]
		[Address(RVA = "0xB2099C", Offset = "0xB2099C", VA = "0xB2099C")]
		private void ProjectPolygon()
		{
		}

		[Token(Token = "0x600063A")]
		[Address(RVA = "0xB20CA0", Offset = "0xB20CA0", VA = "0xB20CA0")]
		private void TessellateMonoRegion(MeshUtils.Face face)
		{
		}

		[Token(Token = "0x600063B")]
		[Address(RVA = "0xB20F00", Offset = "0xB20F00", VA = "0xB20F00")]
		private void TessellateInterior()
		{
		}

		[Token(Token = "0x600063C")]
		[Address(RVA = "0xB20F6C", Offset = "0xB20F6C", VA = "0xB20F6C")]
		private void DiscardExterior()
		{
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0xB20FD8", Offset = "0xB20FD8", VA = "0xB20FD8")]
		private void SetWindingNumber(int value, bool keepOnlyBoundary)
		{
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0xB210B8", Offset = "0xB210B8", VA = "0xB210B8")]
		private int GetNeighbourFace(MeshUtils.Edge edge)
		{
			return default(int);
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0xB21120", Offset = "0xB21120", VA = "0xB21120")]
		private void OutputPolymesh(ElementType elementType, int polySize)
		{
		}

		[Token(Token = "0x6000640")]
		[Address(RVA = "0xB21560", Offset = "0xB21560", VA = "0xB21560")]
		private void OutputContours()
		{
		}

		[Token(Token = "0x6000641")]
		[Address(RVA = "0xB21774", Offset = "0xB21774", VA = "0xB21774")]
		private float SignedArea(ContourVertex[] vertices)
		{
			return default(float);
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0xB21814", Offset = "0xB21814", VA = "0xB21814")]
		public void AddContour(ContourVertex[] vertices)
		{
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0xB16CF4", Offset = "0xB16CF4", VA = "0xB16CF4")]
		public void AddContour(ContourVertex[] vertices, ContourOrientation forceOrientation)
		{
		}

		[Token(Token = "0x6000644")]
		[Address(RVA = "0xB16ED4", Offset = "0xB16ED4", VA = "0xB16ED4")]
		public void Tessellate(WindingRule windingRule, ElementType elementType, int polySize)
		{
		}

		[Token(Token = "0x6000645")]
		[Address(RVA = "0xB2181C", Offset = "0xB2181C", VA = "0xB2181C")]
		public void Tessellate(WindingRule windingRule, ElementType elementType, int polySize, CombineCallback combineCallback)
		{
		}
	}
	[Token(Token = "0x20000A2")]
	public enum WindingRule
	{
		[Token(Token = "0x4000264")]
		EvenOdd,
		[Token(Token = "0x4000265")]
		NonZero,
		[Token(Token = "0x4000266")]
		Positive,
		[Token(Token = "0x4000267")]
		Negative,
		[Token(Token = "0x4000268")]
		AbsGeqTwo
	}
	[Token(Token = "0x20000A3")]
	public enum ElementType
	{
		[Token(Token = "0x400026A")]
		Polygons,
		[Token(Token = "0x400026B")]
		ConnectedPolygons,
		[Token(Token = "0x400026C")]
		BoundaryContours
	}
	[Token(Token = "0x20000A4")]
	public enum ContourOrientation
	{
		[Token(Token = "0x400026E")]
		Original,
		[Token(Token = "0x400026F")]
		Clockwise,
		[Token(Token = "0x4000270")]
		CounterClockwise
	}
	[Token(Token = "0x20000A5")]
	public struct ContourVertex
	{
		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vec3 Position;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public object Data;

		[Token(Token = "0x6000646")]
		[Address(RVA = "0x9C2108", Offset = "0x9C2108", VA = "0x9C2108", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x20000A6")]
	public delegate object CombineCallback(Vec3 position, object[] data, float[] weights);
	[Token(Token = "0x20000A7")]
	public static class LibTessVector3Extension
	{
		[Token(Token = "0x600064B")]
		[Address(RVA = "0xDEB0C0", Offset = "0xDEB0C0", VA = "0xDEB0C0")]
		public static Vec3 Vec3(this Vector3 v)
		{
			return default(Vec3);
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0xDEB0C4", Offset = "0xDEB0C4", VA = "0xDEB0C4")]
		public static ContourVertex ContourVertex(this Vector3 v)
		{
			return default(ContourVertex);
		}
	}
	[Token(Token = "0x20000A8")]
	public static class LibTessV3Extension
	{
		[Token(Token = "0x600064D")]
		[Address(RVA = "0xDEB0BC", Offset = "0xDEB0BC", VA = "0xDEB0BC")]
		public static Vector3 Vector3(this Vec3 v)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x20000A9")]
	public static class UnityLibTessUtility
	{
		[Token(Token = "0x600064E")]
		[Address(RVA = "0x1813EE8", Offset = "0x1813EE8", VA = "0x1813EE8")]
		public static ContourVertex[] ToContourVertex(Vector3[] v, bool zeroZ = false)
		{
			return null;
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0x1813FDC", Offset = "0x1813FDC", VA = "0x1813FDC")]
		public static Vector3[] FromContourVertex(ContourVertex[] v)
		{
			return null;
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0x181405C", Offset = "0x181405C", VA = "0x181405C")]
		public static void SetFromContourVertex(ref Vector3[] v3Array, ref ContourVertex[] cvArray)
		{
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0x18141A8", Offset = "0x18141A8", VA = "0x18141A8")]
		public static void SetToContourVertex(ref ContourVertex[] cvArray, ref Vector3[] v3Array)
		{
		}
	}
}
namespace FluffyUnderware.Curvy.ImportExport
{
	[Token(Token = "0x20000AA")]
	public enum CurvySerializationSpace
	{
		[Token(Token = "0x4000274")]
		Global,
		[Token(Token = "0x4000275")]
		Local
	}
	[Serializable]
	[Token(Token = "0x20000AB")]
	public class SerializedCurvySpline
	{
		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Name;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 Position;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 Rotation;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public CurvyInterpolation Interpolation;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool RestrictTo2D;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		public bool Closed;

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
		public bool AutoEndTangents;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public CurvyOrientation Orientation;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float AutoHandleDistance;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int CacheDensity;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float MaxPointsPerUnit;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool UsePooling;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		public bool UseThreading;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
		public bool CheckTransform;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public CurvyUpdateMethod UpdateIn;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public SerializedCurvySplineSegment[] ControlPoints;

		[Token(Token = "0x6000652")]
		[Address(RVA = "0xB152D0", Offset = "0xB152D0", VA = "0xB152D0")]
		public SerializedCurvySpline()
		{
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0xB15390", Offset = "0xB15390", VA = "0xB15390")]
		public SerializedCurvySpline([NotNull] CurvySpline spline, CurvySerializationSpace space)
		{
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0xB15700", Offset = "0xB15700", VA = "0xB15700")]
		public void WriteIntoSpline([NotNull] CurvySpline deserializedSpline, CurvySerializationSpace space)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000AC")]
	public class SerializedCurvySplineSegment
	{
		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 Position;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 Rotation;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool AutoBakeOrientation;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool OrientationAnchor;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public CurvyOrientationSwirl Swirl;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float SwirlTurns;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool AutoHandles;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float AutoHandleDistance;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 HandleOut;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 HandleIn;

		[Token(Token = "0x6000655")]
		[Address(RVA = "0xB15B90", Offset = "0xB15B90", VA = "0xB15B90")]
		public SerializedCurvySplineSegment()
		{
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0xB155F4", Offset = "0xB155F4", VA = "0xB155F4")]
		public SerializedCurvySplineSegment([NotNull] CurvySplineSegment segment, CurvySerializationSpace space)
		{
		}

		[Token(Token = "0x6000657")]
		[Address(RVA = "0xB159A8", Offset = "0xB159A8", VA = "0xB159A8")]
		public void WriteIntoControlPoint([NotNull] CurvySplineSegment controlPoint, CurvySerializationSpace space)
		{
		}
	}
}
namespace FluffyUnderware.Curvy.Controllers
{
	[Token(Token = "0x20000AD")]
	public abstract class ConnectedControlPointsSelector : MonoBehaviour
	{
		[Token(Token = "0x6000658")]
		public abstract CurvySplineSegment SelectConnectedControlPoint(SplineController caller, CurvyConnection connection, CurvySplineSegment currentControlPoint);

		[Token(Token = "0x6000659")]
		[Address(RVA = "0x10A8184", Offset = "0x10A8184", VA = "0x10A8184")]
		protected ConnectedControlPointsSelector()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000AE")]
	public class ControllerEvent : UnityEventEx<CurvyController>
	{
		[Token(Token = "0x600065A")]
		[Address(RVA = "0x10A86F0", Offset = "0x10A86F0", VA = "0x10A86F0")]
		public ControllerEvent()
		{
		}
	}
	[Token(Token = "0x20000AF")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x864ECC", Offset = "0x864ECC")]
	public class CurvyControllerEventArgs : CurvyEventArgs
	{
		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly CurvyController Controller;

		[Token(Token = "0x600065B")]
		[Address(RVA = "0x15B8844", Offset = "0x15B8844", VA = "0x15B8844")]
		public CurvyControllerEventArgs(MonoBehaviour sender, CurvyController controller)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B0")]
	public class CurvySplineMoveEvent : UnityEventEx<CurvySplineMoveEventArgs>
	{
		[Token(Token = "0x600065C")]
		[Address(RVA = "0x15CC484", Offset = "0x15CC484", VA = "0x15CC484")]
		public CurvySplineMoveEvent()
		{
		}
	}
	[Token(Token = "0x20000B1")]
	public class CurvySplineMoveEventArgs : CancelEventArgs
	{
		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86A6DC", Offset = "0x86A6DC")]
		private SplineController <Sender>k__BackingField;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86A6EC", Offset = "0x86A6EC")]
		private CurvySpline <Spline>k__BackingField;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86A6FC", Offset = "0x86A6FC")]
		private CurvySplineSegment <ControlPoint>k__BackingField;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86A70C", Offset = "0x86A70C")]
		private bool <WorldUnits>k__BackingField;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86A71C", Offset = "0x86A71C")]
		private MovementDirection <MovementDirection>k__BackingField;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86A72C", Offset = "0x86A72C")]
		private float <Delta>k__BackingField;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86A73C", Offset = "0x86A73C")]
		private float <Position>k__BackingField;

		[Token(Token = "0x170000F8")]
		public SplineController Sender
		{
			[Token(Token = "0x600065D")]
			[Address(RVA = "0x15CC4D4", Offset = "0x15CC4D4", VA = "0x15CC4D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8771B0", Offset = "0x8771B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600065E")]
			[Address(RVA = "0x15CC4DC", Offset = "0x15CC4DC", VA = "0x15CC4DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8771C0", Offset = "0x8771C0")]
			private set
			{
			}
		}

		[Token(Token = "0x170000F9")]
		public CurvySpline Spline
		{
			[Token(Token = "0x600065F")]
			[Address(RVA = "0x15CC4E4", Offset = "0x15CC4E4", VA = "0x15CC4E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8771D0", Offset = "0x8771D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000660")]
			[Address(RVA = "0x15CC4EC", Offset = "0x15CC4EC", VA = "0x15CC4EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8771E0", Offset = "0x8771E0")]
			private set
			{
			}
		}

		[Token(Token = "0x170000FA")]
		public CurvySplineSegment ControlPoint
		{
			[Token(Token = "0x6000661")]
			[Address(RVA = "0x15CC4F4", Offset = "0x15CC4F4", VA = "0x15CC4F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8771F0", Offset = "0x8771F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000662")]
			[Address(RVA = "0x15CC4FC", Offset = "0x15CC4FC", VA = "0x15CC4FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x877200", Offset = "0x877200")]
			private set
			{
			}
		}

		[Token(Token = "0x170000FB")]
		public bool WorldUnits
		{
			[Token(Token = "0x6000663")]
			[Address(RVA = "0x15CC504", Offset = "0x15CC504", VA = "0x15CC504")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x877210", Offset = "0x877210")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000664")]
			[Address(RVA = "0x15CC50C", Offset = "0x15CC50C", VA = "0x15CC50C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x877220", Offset = "0x877220")]
			private set
			{
			}
		}

		[Token(Token = "0x170000FC")]
		public MovementDirection MovementDirection
		{
			[Token(Token = "0x6000665")]
			[Address(RVA = "0x15CC518", Offset = "0x15CC518", VA = "0x15CC518")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x877230", Offset = "0x877230")]
			get
			{
				return default(MovementDirection);
			}
			[Token(Token = "0x6000666")]
			[Address(RVA = "0x15CC520", Offset = "0x15CC520", VA = "0x15CC520")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x877240", Offset = "0x877240")]
			private set
			{
			}
		}

		[Token(Token = "0x170000FD")]
		public float Delta
		{
			[Token(Token = "0x6000667")]
			[Address(RVA = "0x15CC528", Offset = "0x15CC528", VA = "0x15CC528")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x877250", Offset = "0x877250")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000668")]
			[Address(RVA = "0x15CC530", Offset = "0x15CC530", VA = "0x15CC530")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x877260", Offset = "0x877260")]
			private set
			{
			}
		}

		[Token(Token = "0x170000FE")]
		public float Position
		{
			[Token(Token = "0x6000669")]
			[Address(RVA = "0x15CC538", Offset = "0x15CC538", VA = "0x15CC538")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x877270", Offset = "0x877270")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600066A")]
			[Address(RVA = "0x15CC540", Offset = "0x15CC540", VA = "0x15CC540")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x877280", Offset = "0x877280")]
			private set
			{
			}
		}

		[Token(Token = "0x600066B")]
		[Address(RVA = "0x15CC548", Offset = "0x15CC548", VA = "0x15CC548")]
		public CurvySplineMoveEventArgs(SplineController sender, CurvySpline spline, CurvySplineSegment controlPoint, float position, bool usingWorldUnits, float delta, MovementDirection direction)
		{
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0x15CC5BC", Offset = "0x15CC5BC", VA = "0x15CC5BC")]
		internal void Set_INTERNAL(SplineController sender, CurvySpline spline, CurvySplineSegment controlPoint, float position, float delta, MovementDirection direction, bool usingWorldUnits)
		{
		}
	}
	[Token(Token = "0x20000B2")]
	[ExecuteInEditMode]
	public abstract class CurvyController : DTVersionedMonoBehaviour, ISerializationCallbackReceiver
	{
		[Token(Token = "0x2000189")]
		public enum MoveModeEnum
		{
			[Token(Token = "0x4000698")]
			Relative,
			[Token(Token = "0x4000699")]
			AbsolutePrecise
		}

		[Token(Token = "0x200018A")]
		public enum CurvyControllerState
		{
			[Token(Token = "0x400069B")]
			Stopped,
			[Token(Token = "0x400069C")]
			Playing,
			[Token(Token = "0x400069D")]
			Paused
		}

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x86A74C", Offset = "0x86A74C")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x86A74C", Offset = "0x86A74C")]
		public CurvyUpdateMethod UpdateIn;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x86A7D0", Offset = "0x86A7D0")]
		[SerializeField]
		private CurvyPositionMode m_PositionMode;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x86A848", Offset = "0x86A848")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x86A848", Offset = "0x86A848")]
		protected float m_Position;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x86A8F4", Offset = "0x86A8F4")]
		[SerializeField]
		private MoveModeEnum m_MoveMode;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Positive]
		[SerializeField]
		private float m_Speed;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private MovementDirection m_Direction;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CurvyClamping m_Clamping;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86A9BC", Offset = "0x86A9BC")]
		private bool m_PlayAutomatically;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x86AA08", Offset = "0x86AA08")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x86AA08", Offset = "0x86AA08")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x86AA08", Offset = "0x86AA08")]
		[SerializeField]
		private OrientationModeEnum m_OrientationMode;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x86AB48", Offset = "0x86AB48")]
		[SerializeField]
		private bool m_LockRotation;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x86ABB0", Offset = "0x86ABB0")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x86ABB0", Offset = "0x86ABB0")]
		[SerializeField]
		private OrientationAxisEnum m_OrientationAxis;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86ACE4", Offset = "0x86ACE4")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x86ACE4", Offset = "0x86ACE4")]
		[SerializeField]
		private bool m_IgnoreDirection;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "MinAttribute", RVA = "0x86AE04", Offset = "0x86AE04")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x86AE04", Offset = "0x86AE04")]
		[SerializeField]
		private float m_DampingDirection;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "MinAttribute", RVA = "0x86AF00", Offset = "0x86AF00")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x86AF00", Offset = "0x86AF00")]
		[SerializeField]
		private float m_DampingUp;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x86AFFC", Offset = "0x86AFFC")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x86AFFC", Offset = "0x86AFFC")]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x86AFFC", Offset = "0x86AFFC")]
		[SerializeField]
		private float m_OffsetAngle;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x86B14C", Offset = "0x86B14C")]
		[SerializeField]
		private float m_OffsetRadius;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x86B20C", Offset = "0x86B20C")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x86B20C", Offset = "0x86B20C")]
		[SerializeField]
		private bool m_OffsetCompensation;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x86B304", Offset = "0x86B304")]
		[SerializeField]
		protected ControllerEvent onInitialized;

		[Token(Token = "0x40002AA")]
		protected const string ControllerNotReadyMessage = "The controller is not yet ready";

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		protected CurvyControllerState State;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		protected Vector3 DirectionDampingVelocity;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		protected Vector3 UpDampingVelocity;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		protected float PrePlayPosition;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		protected MovementDirection PrePlayDirection;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		protected Quaternion LockedRotation;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86B364", Offset = "0x86B364")]
		private bool <isInitialized>k__BackingField;

		[Token(Token = "0x170000FF")]
		public ControllerEvent OnInitialized
		{
			[Token(Token = "0x600066D")]
			[Address(RVA = "0x10AEB18", Offset = "0x10AEB18", VA = "0x10AEB18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000100")]
		public CurvyPositionMode PositionMode
		{
			[Token(Token = "0x600066E")]
			[Address(RVA = "0x10AEB20", Offset = "0x10AEB20", VA = "0x10AEB20")]
			get
			{
				return default(CurvyPositionMode);
			}
			[Token(Token = "0x600066F")]
			[Address(RVA = "0x10AEB28", Offset = "0x10AEB28", VA = "0x10AEB28")]
			set
			{
			}
		}

		[Token(Token = "0x17000101")]
		public MoveModeEnum MoveMode
		{
			[Token(Token = "0x6000670")]
			[Address(RVA = "0x10AEB30", Offset = "0x10AEB30", VA = "0x10AEB30")]
			get
			{
				return default(MoveModeEnum);
			}
			[Token(Token = "0x6000671")]
			[Address(RVA = "0x10AEB38", Offset = "0x10AEB38", VA = "0x10AEB38")]
			set
			{
			}
		}

		[Token(Token = "0x17000102")]
		public bool PlayAutomatically
		{
			[Token(Token = "0x6000672")]
			[Address(RVA = "0x10AEB4C", Offset = "0x10AEB4C", VA = "0x10AEB4C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000673")]
			[Address(RVA = "0x10AEB54", Offset = "0x10AEB54", VA = "0x10AEB54")]
			set
			{
			}
		}

		[Token(Token = "0x17000103")]
		public CurvyClamping Clamping
		{
			[Token(Token = "0x6000674")]
			[Address(RVA = "0x10AEB74", Offset = "0x10AEB74", VA = "0x10AEB74")]
			get
			{
				return default(CurvyClamping);
			}
			[Token(Token = "0x6000675")]
			[Address(RVA = "0x10AEB7C", Offset = "0x10AEB7C", VA = "0x10AEB7C")]
			set
			{
			}
		}

		[Token(Token = "0x17000104")]
		public OrientationModeEnum OrientationMode
		{
			[Token(Token = "0x6000676")]
			[Address(RVA = "0x10AEB90", Offset = "0x10AEB90", VA = "0x10AEB90")]
			get
			{
				return default(OrientationModeEnum);
			}
			[Token(Token = "0x6000677")]
			[Address(RVA = "0x10AEB98", Offset = "0x10AEB98", VA = "0x10AEB98")]
			set
			{
			}
		}

		[Token(Token = "0x17000105")]
		public bool LockRotation
		{
			[Token(Token = "0x6000678")]
			[Address(RVA = "0x10AEBAC", Offset = "0x10AEBAC", VA = "0x10AEBAC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000679")]
			[Address(RVA = "0x10AEBB4", Offset = "0x10AEBB4", VA = "0x10AEBB4")]
			set
			{
			}
		}

		[Token(Token = "0x17000106")]
		public OrientationAxisEnum OrientationAxis
		{
			[Token(Token = "0x600067A")]
			[Address(RVA = "0x10AEC1C", Offset = "0x10AEC1C", VA = "0x10AEC1C")]
			get
			{
				return default(OrientationAxisEnum);
			}
			[Token(Token = "0x600067B")]
			[Address(RVA = "0x10AEC24", Offset = "0x10AEC24", VA = "0x10AEC24")]
			set
			{
			}
		}

		[Token(Token = "0x17000107")]
		public float DirectionDampingTime
		{
			[Token(Token = "0x600067C")]
			[Address(RVA = "0x10AEC38", Offset = "0x10AEC38", VA = "0x10AEC38")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600067D")]
			[Address(RVA = "0x10AEC40", Offset = "0x10AEC40", VA = "0x10AEC40")]
			set
			{
			}
		}

		[Token(Token = "0x17000108")]
		public float UpDampingTime
		{
			[Token(Token = "0x600067E")]
			[Address(RVA = "0x10AECCC", Offset = "0x10AECCC", VA = "0x10AECCC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600067F")]
			[Address(RVA = "0x10AECD4", Offset = "0x10AECD4", VA = "0x10AECD4")]
			set
			{
			}
		}

		[Token(Token = "0x17000109")]
		public bool IgnoreDirection
		{
			[Token(Token = "0x6000680")]
			[Address(RVA = "0x10AED60", Offset = "0x10AED60", VA = "0x10AED60")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000681")]
			[Address(RVA = "0x10AED68", Offset = "0x10AED68", VA = "0x10AED68")]
			set
			{
			}
		}

		[Token(Token = "0x1700010A")]
		public float OffsetAngle
		{
			[Token(Token = "0x6000682")]
			[Address(RVA = "0x10AED88", Offset = "0x10AED88", VA = "0x10AED88")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000683")]
			[Address(RVA = "0x10AED90", Offset = "0x10AED90", VA = "0x10AED90")]
			set
			{
			}
		}

		[Token(Token = "0x1700010B")]
		public float OffsetRadius
		{
			[Token(Token = "0x6000684")]
			[Address(RVA = "0x10AEDA4", Offset = "0x10AEDA4", VA = "0x10AEDA4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000685")]
			[Address(RVA = "0x10AEDAC", Offset = "0x10AEDAC", VA = "0x10AEDAC")]
			set
			{
			}
		}

		[Token(Token = "0x1700010C")]
		public bool OffsetCompensation
		{
			[Token(Token = "0x6000686")]
			[Address(RVA = "0x10AEDC0", Offset = "0x10AEDC0", VA = "0x10AEDC0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000687")]
			[Address(RVA = "0x10AEDC8", Offset = "0x10AEDC8", VA = "0x10AEDC8")]
			set
			{
			}
		}

		[Token(Token = "0x1700010D")]
		public float Speed
		{
			[Token(Token = "0x6000688")]
			[Address(RVA = "0x10AEDD4", Offset = "0x10AEDD4", VA = "0x10AEDD4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000689")]
			[Address(RVA = "0x10ACC2C", Offset = "0x10ACC2C", VA = "0x10ACC2C")]
			set
			{
			}
		}

		[Token(Token = "0x1700010E")]
		public float RelativePosition
		{
			[Token(Token = "0x600068A")]
			[Address(RVA = "0x10ACD70", Offset = "0x10ACD70", VA = "0x10ACD70")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600068B")]
			[Address(RVA = "0x10AEED0", Offset = "0x10AEED0", VA = "0x10AEED0")]
			set
			{
			}
		}

		[Token(Token = "0x1700010F")]
		public float AbsolutePosition
		{
			[Token(Token = "0x600068C")]
			[Address(RVA = "0x10AEFA0", Offset = "0x10AEFA0", VA = "0x10AEFA0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600068D")]
			[Address(RVA = "0x10AF0A4", Offset = "0x10AF0A4", VA = "0x10AF0A4")]
			set
			{
			}
		}

		[Token(Token = "0x17000110")]
		public float Position
		{
			[Token(Token = "0x600068E")]
			[Address(RVA = "0x10AF174", Offset = "0x10AF174", VA = "0x10AF174")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600068F")]
			[Address(RVA = "0x10AF208", Offset = "0x10AF208", VA = "0x10AF208")]
			set
			{
			}
		}

		[Token(Token = "0x17000111")]
		public MovementDirection MovementDirection
		{
			[Token(Token = "0x6000690")]
			[Address(RVA = "0x10AF2B4", Offset = "0x10AF2B4", VA = "0x10AF2B4")]
			get
			{
				return default(MovementDirection);
			}
			[Token(Token = "0x6000691")]
			[Address(RVA = "0x10AF2BC", Offset = "0x10AF2BC", VA = "0x10AF2BC")]
			set
			{
			}
		}

		[Token(Token = "0x17000112")]
		public CurvyControllerState PlayState
		{
			[Token(Token = "0x6000692")]
			[Address(RVA = "0x10AF2C4", Offset = "0x10AF2C4", VA = "0x10AF2C4")]
			get
			{
				return default(CurvyControllerState);
			}
		}

		[Token(Token = "0x17000113")]
		public abstract bool IsReady
		{
			[Token(Token = "0x6000693")]
			get;
		}

		[Token(Token = "0x17000114")]
		public virtual Transform Transform
		{
			[Token(Token = "0x600069B")]
			[Address(RVA = "0x10AF5D8", Offset = "0x10AF5D8", VA = "0x10AF5D8", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000115")]
		protected virtual bool ShowOrientationSection
		{
			[Token(Token = "0x60006A6")]
			[Address(RVA = "0x10B0528", Offset = "0x10B0528", VA = "0x10B0528", Slot = "25")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000116")]
		protected virtual bool ShowOffsetSection
		{
			[Token(Token = "0x60006A7")]
			[Address(RVA = "0x10B0530", Offset = "0x10B0530", VA = "0x10B0530", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000117")]
		public abstract float Length
		{
			[Token(Token = "0x60006A8")]
			get;
		}

		[Token(Token = "0x17000118")]
		protected bool isInitialized
		{
			[Token(Token = "0x60006B9")]
			[Address(RVA = "0x10B0CA8", Offset = "0x10B0CA8", VA = "0x10B0CA8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x877290", Offset = "0x877290")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006BA")]
			[Address(RVA = "0x10B0CB0", Offset = "0x10B0CB0", VA = "0x10B0CB0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8772A0", Offset = "0x8772A0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000119")]
		protected float TimeSinceLastUpdate
		{
			[Token(Token = "0x60006BB")]
			[Address(RVA = "0x10AF3F8", Offset = "0x10AF3F8", VA = "0x10AF3F8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700011A")]
		protected bool UseOffset
		{
			[Token(Token = "0x60006BC")]
			[Address(RVA = "0x10AF98C", Offset = "0x10AF98C", VA = "0x10AF98C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700011B")]
		private float maxPosition
		{
			[Token(Token = "0x60006BF")]
			[Address(RVA = "0x10B0CBC", Offset = "0x10B0CBC", VA = "0x10B0CBC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000694")]
		[Address(RVA = "0x10ACBC4", Offset = "0x10ACBC4", VA = "0x10ACBC4", Slot = "7")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x6000695")]
		[Address(RVA = "0x10AF2CC", Offset = "0x10AF2CC", VA = "0x10AF2CC", Slot = "8")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000696")]
		[Address(RVA = "0x10AF3A8", Offset = "0x10AF3A8", VA = "0x10AF3A8", Slot = "9")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x6000697")]
		[Address(RVA = "0x10AF3C4", Offset = "0x10AF3C4", VA = "0x10AF3C4", Slot = "10")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000698")]
		[Address(RVA = "0x10AF4B0", Offset = "0x10AF4B0", VA = "0x10AF4B0", Slot = "11")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x6000699")]
		[Address(RVA = "0x10AF508", Offset = "0x10AF508", VA = "0x10AF508", Slot = "12")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x600069A")]
		[Address(RVA = "0x10AF540", Offset = "0x10AF540", VA = "0x10AF540", Slot = "13")]
		protected virtual void Reset()
		{
		}

		[Token(Token = "0x600069C")]
		[Address(RVA = "0x10AF5E0", Offset = "0x10AF5E0", VA = "0x10AF5E0", Slot = "15")]
		protected virtual void InitializedApplyDeltaTime(float deltaTime)
		{
		}

		[Token(Token = "0x600069D")]
		[Address(RVA = "0x10AFBF0", Offset = "0x10AFBF0", VA = "0x10AFBF0", Slot = "16")]
		protected virtual void ComputeTargetPositionAndRotation(out Vector3 targetPosition, out Vector3 targetUp, out Vector3 targetForward)
		{
		}

		[Token(Token = "0x600069E")]
		[Address(RVA = "0x10B03E0", Offset = "0x10B03E0", VA = "0x10B03E0", Slot = "17")]
		protected virtual void Initialize()
		{
		}

		[Token(Token = "0x600069F")]
		[Address(RVA = "0x10B04C8", Offset = "0x10B04C8", VA = "0x10B04C8", Slot = "18")]
		protected virtual void Deinitialize()
		{
		}

		[Token(Token = "0x60006A0")]
		[Address(RVA = "0x10B04F8", Offset = "0x10B04F8", VA = "0x10B04F8", Slot = "19")]
		protected virtual void BindEvents()
		{
		}

		[Token(Token = "0x60006A1")]
		[Address(RVA = "0x10B04FC", Offset = "0x10B04FC", VA = "0x10B04FC", Slot = "20")]
		protected virtual void UnbindEvents()
		{
		}

		[Token(Token = "0x60006A2")]
		[Address(RVA = "0x10B0500", Offset = "0x10B0500", VA = "0x10B0500", Slot = "21")]
		protected virtual void SavePrePlayState()
		{
		}

		[Token(Token = "0x60006A3")]
		[Address(RVA = "0x10B0510", Offset = "0x10B0510", VA = "0x10B0510", Slot = "22")]
		protected virtual void RestorePrePlayState()
		{
		}

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0x10B0520", Offset = "0x10B0520", VA = "0x10B0520", Slot = "23")]
		protected virtual void UserAfterInit()
		{
		}

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x10B0524", Offset = "0x10B0524", VA = "0x10B0524", Slot = "24")]
		protected virtual void UserAfterUpdate()
		{
		}

		[Token(Token = "0x60006A9")]
		protected abstract void Advance(float speed, float deltaTime);

		[Token(Token = "0x60006AA")]
		protected abstract void SimulateAdvance(ref float tf, ref MovementDirection curyDirection, float speed, float deltaTime);

		[Token(Token = "0x60006AB")]
		protected abstract float AbsoluteToRelative(float worldUnitDistance);

		[Token(Token = "0x60006AC")]
		protected abstract float RelativeToAbsolute(float relativeDistance);

		[Token(Token = "0x60006AD")]
		protected abstract Vector3 GetInterpolatedSourcePosition(float tf);

		[Token(Token = "0x60006AE")]
		protected abstract void GetInterpolatedSourcePosition(float tf, out Vector3 interpolatedPosition, out Vector3 tangent, out Vector3 up);

		[Token(Token = "0x60006AF")]
		protected abstract Vector3 GetOrientation(float tf);

		[Token(Token = "0x60006B0")]
		protected abstract Vector3 GetTangent(float tf);

		[Token(Token = "0x60006B1")]
		[Address(RVA = "0x10AF368", Offset = "0x10AF368", VA = "0x10AF368")]
		public void Play()
		{
		}

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0x10B0540", Offset = "0x10B0540", VA = "0x10B0540")]
		public void Stop()
		{
		}

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0x10B057C", Offset = "0x10B057C", VA = "0x10B057C")]
		public void Pause()
		{
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x10B0594", Offset = "0x10B0594", VA = "0x10B0594")]
		public void Refresh()
		{
		}

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x10AF400", Offset = "0x10AF400", VA = "0x10AF400")]
		public void ApplyDeltaTime(float deltaTime)
		{
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x10B059C", Offset = "0x10B059C", VA = "0x10B059C")]
		public void TeleportTo(float newPosition)
		{
		}

		[Token(Token = "0x60006B7")]
		[Address(RVA = "0x10B0630", Offset = "0x10B0630", VA = "0x10B0630")]
		public void TeleportBy(float distance, MovementDirection direction)
		{
		}

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0x10B070C", Offset = "0x10B070C", VA = "0x10B070C")]
		public void SetFromString(string fieldAndValue)
		{
		}

		[Token(Token = "0x60006BD")]
		[Address(RVA = "0x10B02E8", Offset = "0x10B02E8", VA = "0x10B02E8")]
		protected static Vector3 ApplyOffset(Vector3 position, Vector3 tangent, Vector3 up, float offsetAngle, float offsetRadius)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006BE")]
		[Address(RVA = "0x10AEDDC", Offset = "0x10AEDDC", VA = "0x10AEDDC")]
		protected static float GetClampedPosition(float position, CurvyPositionMode positionMode, CurvyClamping clampingMode, float length)
		{
			return default(float);
		}

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0x10AF99C", Offset = "0x10AF99C", VA = "0x10AF99C")]
		protected float ComputeOffsetCompensatedSpeed(float deltaTime)
		{
			return default(float);
		}

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0x10B015C", Offset = "0x10B015C", VA = "0x10B015C")]
		private void GetOrientationNoneUpAndForward(out Vector3 targetUp, out Vector3 targetForward)
		{
		}

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0x10B0D74", Offset = "0x10B0D74", VA = "0x10B0D74", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Token(Token = "0x60006C3")]
		[Address(RVA = "0x10B0D78", Offset = "0x10B0D78", VA = "0x10B0D78", Slot = "36")]
		public virtual void OnAfterDeserialize()
		{
		}

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0x10B0E1C", Offset = "0x10B0E1C", VA = "0x10B0E1C")]
		protected CurvyController()
		{
		}
	}
	[Token(Token = "0x20000B3")]
	public enum MovementDirection
	{
		[Token(Token = "0x40002B3")]
		Forward,
		[Token(Token = "0x40002B4")]
		Backward
	}
	[Token(Token = "0x20000B4")]
	public static class MovementDirectionMethods
	{
		[Token(Token = "0x60006C5")]
		[Address(RVA = "0xDF0A90", Offset = "0xDF0A90", VA = "0xDF0A90")]
		public static MovementDirection FromInt(int value)
		{
			return default(MovementDirection);
		}

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0xDF0D64", Offset = "0xDF0D64", VA = "0xDF0D64")]
		public static MovementDirection GetOpposite(this MovementDirection value)
		{
			return default(MovementDirection);
		}

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0xDF0DEC", Offset = "0xDF0DEC", VA = "0xDF0DEC")]
		public static int ToInt(this MovementDirection direction)
		{
			return default(int);
		}
	}
	[Token(Token = "0x20000B5")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x864EFC", Offset = "0x864EFC")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x864EFC", Offset = "0x864EFC")]
	public class PathController : CurvyController
	{
		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x86B374", Offset = "0x86B374")]
		[SerializeField]
		[AttributeAttribute(Name = "CGDataReferenceSelectorAttribute", RVA = "0x86B374", Offset = "0x86B374")]
		private CGDataReference m_Path;

		[Token(Token = "0x1700011C")]
		public CGDataReference Path
		{
			[Token(Token = "0x60006C8")]
			[Address(RVA = "0xDF5A28", Offset = "0xDF5A28", VA = "0xDF5A28")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006C9")]
			[Address(RVA = "0xDF5A30", Offset = "0xDF5A30", VA = "0xDF5A30")]
			set
			{
			}
		}

		[Token(Token = "0x1700011D")]
		public CGPath PathData
		{
			[Token(Token = "0x60006CA")]
			[Address(RVA = "0xDF5A38", Offset = "0xDF5A38", VA = "0xDF5A38")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700011E")]
		public override float Length
		{
			[Token(Token = "0x60006CB")]
			[Address(RVA = "0xDF5AB0", Offset = "0xDF5AB0", VA = "0xDF5AB0", Slot = "27")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700011F")]
		public override bool IsReady
		{
			[Token(Token = "0x60006CC")]
			[Address(RVA = "0xDF5AF0", Offset = "0xDF5AF0", VA = "0xDF5AF0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0xDF5B40", Offset = "0xDF5B40", VA = "0xDF5B40", Slot = "31")]
		protected override float RelativeToAbsolute(float relativeDistance)
		{
			return default(float);
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0xDF5B9C", Offset = "0xDF5B9C", VA = "0xDF5B9C", Slot = "30")]
		protected override float AbsoluteToRelative(float worldUnitDistance)
		{
			return default(float);
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0xDF5BF8", Offset = "0xDF5BF8", VA = "0xDF5BF8", Slot = "32")]
		protected override Vector3 GetInterpolatedSourcePosition(float tf)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0xDF5C6C", Offset = "0xDF5C6C", VA = "0xDF5C6C", Slot = "33")]
		protected override void GetInterpolatedSourcePosition(float tf, out Vector3 interpolatedPosition, out Vector3 tangent, out Vector3 up)
		{
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0xDF5D44", Offset = "0xDF5D44", VA = "0xDF5D44", Slot = "35")]
		protected override Vector3 GetTangent(float tf)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0xDF5DB8", Offset = "0xDF5DB8", VA = "0xDF5DB8", Slot = "34")]
		protected override Vector3 GetOrientation(float tf)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0xDF5E2C", Offset = "0xDF5E2C", VA = "0xDF5E2C", Slot = "28")]
		protected override void Advance(float speed, float deltaTime)
		{
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0xDF5EA8", Offset = "0xDF5EA8", VA = "0xDF5EA8", Slot = "29")]
		protected override void SimulateAdvance(ref float tf, ref MovementDirection curyDirection, float speed, float deltaTime)
		{
		}

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0xDF5FB8", Offset = "0xDF5FB8", VA = "0xDF5FB8")]
		public PathController()
		{
		}
	}
	[Token(Token = "0x20000B6")]
	public enum SplineControllerConnectionBehavior
	{
		[Token(Token = "0x40002B7")]
		CurrentSpline,
		[Token(Token = "0x40002B8")]
		FollowUpSpline,
		[Token(Token = "0x40002B9")]
		RandomSpline,
		[Token(Token = "0x40002BA")]
		FollowUpOtherwiseRandom,
		[Token(Token = "0x40002BB")]
		Custom
	}
	[Token(Token = "0x20000B7")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x864F60", Offset = "0x864F60")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x864F60", Offset = "0x864F60")]
	public class SplineController : CurvyController
	{
		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x86B430", Offset = "0x86B430")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x86B430", Offset = "0x86B430")]
		[SerializeField]
		protected CurvySpline m_Spline;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86B4DC", Offset = "0x86B4DC")]
		private bool m_UseCache;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x86B528", Offset = "0x86B528")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x86B528", Offset = "0x86B528")]
		private SplineControllerConnectionBehavior connectionBehavior;

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x86B5D0", Offset = "0x86B5D0")]
		private bool allowDirectionChange;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB9")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x86B630", Offset = "0x86B630")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x86B630", Offset = "0x86B630")]
		private bool rejectCurrentSpline;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBA")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x86B71C", Offset = "0x86B71C")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x86B71C", Offset = "0x86B71C")]
		private bool rejectTooDivergentSplines;

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x86B808", Offset = "0x86B808")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86B808", Offset = "0x86B808")]
		private float maxAllowedDivergenceAngle;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x86B88C", Offset = "0x86B88C")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x86B88C", Offset = "0x86B88C")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x86B88C", Offset = "0x86B88C")]
		private ConnectedControlPointsSelector connectionCustomSelector;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x86B9C0", Offset = "0x86B9C0")]
		[SerializeField]
		protected CurvySplineMoveEvent m_OnControlPointReached;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		protected CurvySplineMoveEvent m_OnEndReached;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[SerializeField]
		protected CurvySplineMoveEvent m_OnSwitch;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86BA48", Offset = "0x86BA48")]
		private bool <IsSwitching>k__BackingField;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private CurvySpline prePlaySpline;

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private readonly CurvySplineMoveEventArgs preAllocatedEventArgs;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		protected float SwitchStartTime;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		protected float SwitchDuration;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		protected CurvySpline SwitchTarget;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		protected float TfOnSwitchTarget;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		protected MovementDirection DirectionOnSwitchTarget;

		[Token(Token = "0x40002CF")]
		private const string InvalidSegmentErrorMessage = "[Curvy] Controller {0} reached segment {1} which is invalid segment because it has a length of 0. Please fix the invalid segment to avoid issues with the controller";

		[Token(Token = "0x17000120")]
		public virtual CurvySpline Spline
		{
			[Token(Token = "0x60006D7")]
			[Address(RVA = "0xB170AC", Offset = "0xB170AC", VA = "0xB170AC", Slot = "37")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006D8")]
			[Address(RVA = "0xB170B4", Offset = "0xB170B4", VA = "0xB170B4", Slot = "38")]
			set
			{
			}
		}

		[Token(Token = "0x17000121")]
		public bool UseCache
		{
			[Token(Token = "0x60006D9")]
			[Address(RVA = "0xB170BC", Offset = "0xB170BC", VA = "0xB170BC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006DA")]
			[Address(RVA = "0xB170C4", Offset = "0xB170C4", VA = "0xB170C4")]
			set
			{
			}
		}

		[Token(Token = "0x17000122")]
		public SplineControllerConnectionBehavior ConnectionBehavior
		{
			[Token(Token = "0x60006DB")]
			[Address(RVA = "0xB170E4", Offset = "0xB170E4", VA = "0xB170E4")]
			get
			{
				return default(SplineControllerConnectionBehavior);
			}
			[Token(Token = "0x60006DC")]
			[Address(RVA = "0xB170EC", Offset = "0xB170EC", VA = "0xB170EC")]
			set
			{
			}
		}

		[Token(Token = "0x17000123")]
		public ConnectedControlPointsSelector ConnectionCustomSelector
		{
			[Token(Token = "0x60006DD")]
			[Address(RVA = "0xB170F4", Offset = "0xB170F4", VA = "0xB170F4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006DE")]
			[Address(RVA = "0xB170FC", Offset = "0xB170FC", VA = "0xB170FC")]
			set
			{
			}
		}

		[Token(Token = "0x17000124")]
		public bool AllowDirectionChange
		{
			[Token(Token = "0x60006DF")]
			[Address(RVA = "0xB17104", Offset = "0xB17104", VA = "0xB17104")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006E0")]
			[Address(RVA = "0xB1710C", Offset = "0xB1710C", VA = "0xB1710C")]
			set
			{
			}
		}

		[Token(Token = "0x17000125")]
		public bool RejectCurrentSpline
		{
			[Token(Token = "0x60006E1")]
			[Address(RVA = "0xB17118", Offset = "0xB17118", VA = "0xB17118")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006E2")]
			[Address(RVA = "0xB17120", Offset = "0xB17120", VA = "0xB17120")]
			set
			{
			}
		}

		[Token(Token = "0x17000126")]
		public bool RejectTooDivergentSplines
		{
			[Token(Token = "0x60006E3")]
			[Address(RVA = "0xB1712C", Offset = "0xB1712C", VA = "0xB1712C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006E4")]
			[Address(RVA = "0xB17134", Offset = "0xB17134", VA = "0xB17134")]
			set
			{
			}
		}

		[Token(Token = "0x17000127")]
		public float MaxAllowedDivergenceAngle
		{
			[Token(Token = "0x60006E5")]
			[Address(RVA = "0xB17140", Offset = "0xB17140", VA = "0xB17140")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60006E6")]
			[Address(RVA = "0xB17148", Offset = "0xB17148", VA = "0xB17148")]
			set
			{
			}
		}

		[Token(Token = "0x17000128")]
		public CurvySplineMoveEvent OnControlPointReached
		{
			[Token(Token = "0x60006E7")]
			[Address(RVA = "0xB17150", Offset = "0xB17150", VA = "0xB17150")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006E8")]
			[Address(RVA = "0xB17158", Offset = "0xB17158", VA = "0xB17158")]
			set
			{
			}
		}

		[Token(Token = "0x17000129")]
		public CurvySplineMoveEvent OnEndReached
		{
			[Token(Token = "0x60006E9")]
			[Address(RVA = "0xB17160", Offset = "0xB17160", VA = "0xB17160")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006EA")]
			[Address(RVA = "0xB17168", Offset = "0xB17168", VA = "0xB17168")]
			set
			{
			}
		}

		[Token(Token = "0x1700012A")]
		public CurvySplineMoveEvent OnSwitch
		{
			[Token(Token = "0x60006EB")]
			[Address(RVA = "0xB17170", Offset = "0xB17170", VA = "0xB17170")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006EC")]
			[Address(RVA = "0xB17178", Offset = "0xB17178", VA = "0xB17178")]
			set
			{
			}
		}

		[Token(Token = "0x1700012B")]
		public bool IsSwitching
		{
			[Token(Token = "0x60006ED")]
			[Address(RVA = "0xB17180", Offset = "0xB17180", VA = "0xB17180")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8772D0", Offset = "0x8772D0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006EE")]
			[Address(RVA = "0xB17188", Offset = "0xB17188", VA = "0xB17188")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8772E0", Offset = "0x8772E0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700012C")]
		public float SwitchProgress
		{
			[Token(Token = "0x60006EF")]
			[Address(RVA = "0xB17194", Offset = "0xB17194", VA = "0xB17194")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700012D")]
		public override float Length
		{
			[Token(Token = "0x60006F0")]
			[Address(RVA = "0xB17240", Offset = "0xB17240", VA = "0xB17240", Slot = "27")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700012E")]
		public override bool IsReady
		{
			[Token(Token = "0x60006F5")]
			[Address(RVA = "0xB1752C", Offset = "0xB1752C", VA = "0xB1752C", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700012F")]
		private bool ShowRandomConnectionOptions
		{
			[Token(Token = "0x600070D")]
			[Address(RVA = "0xB19378", Offset = "0xB19378", VA = "0xB19378")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0xB16F9C", Offset = "0xB16F9C", VA = "0xB16F9C")]
		public SplineController()
		{
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0xB172A0", Offset = "0xB172A0", VA = "0xB172A0", Slot = "39")]
		public virtual void SwitchTo(CurvySpline destinationSpline, float destinationTf, float duration)
		{
		}

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0xB1734C", Offset = "0xB1734C", VA = "0xB1734C")]
		public void FinishCurrentSwitch()
		{
		}

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0xB17398", Offset = "0xB17398", VA = "0xB17398")]
		public void CancelCurrentSwitch()
		{
		}

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0xB173A8", Offset = "0xB173A8", VA = "0xB173A8")]
		public static float GetAngleBetweenConnectedSplines(CurvySplineSegment before, MovementDirection movementMode, CurvySplineSegment after, bool allowMovementModeChange)
		{
			return default(float);
		}

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0xB17584", Offset = "0xB17584", VA = "0xB17584", Slot = "21")]
		protected override void SavePrePlayState()
		{
		}

		[Token(Token = "0x60006F7")]
		[Address(RVA = "0xB175BC", Offset = "0xB175BC", VA = "0xB175BC", Slot = "22")]
		protected override void RestorePrePlayState()
		{
		}

		[Token(Token = "0x60006F8")]
		[Address(RVA = "0xB175F4", Offset = "0xB175F4", VA = "0xB175F4", Slot = "31")]
		protected override float RelativeToAbsolute(float relativeDistance)
		{
			return default(float);
		}

		[Token(Token = "0x60006F9")]
		[Address(RVA = "0xB17640", Offset = "0xB17640", VA = "0xB17640", Slot = "30")]
		protected override float AbsoluteToRelative(float worldUnitDistance)
		{
			return default(float);
		}

		[Token(Token = "0x60006FA")]
		[Address(RVA = "0xB1768C", Offset = "0xB1768C", VA = "0xB1768C", Slot = "32")]
		protected override Vector3 GetInterpolatedSourcePosition(float tf)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006FB")]
		[Address(RVA = "0xB17734", Offset = "0xB17734", VA = "0xB17734", Slot = "33")]
		protected override void GetInterpolatedSourcePosition(float tf, out Vector3 interpolatedPosition, out Vector3 tangent, out Vector3 up)
		{
		}

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0xB178F8", Offset = "0xB178F8", VA = "0xB178F8", Slot = "35")]
		protected override Vector3 GetTangent(float tf)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0xB179A0", Offset = "0xB179A0", VA = "0xB179A0", Slot = "34")]
		protected override Vector3 GetOrientation(float tf)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0xB17A20", Offset = "0xB17A20", VA = "0xB17A20", Slot = "28")]
		protected override void Advance(float speed, float deltaTime)
		{
		}

		[Token(Token = "0x60006FF")]
		[Address(RVA = "0xB184D8", Offset = "0xB184D8", VA = "0xB184D8", Slot = "29")]
		protected override void SimulateAdvance(ref float tf, ref MovementDirection curyDirection, float speed, float deltaTime)
		{
		}

		[Token(Token = "0x6000700")]
		[Address(RVA = "0xB18378", Offset = "0xB18378", VA = "0xB18378")]
		private void SimulateAdvanceOnSpline(ref float tf, ref MovementDirection curyDirection, CurvySpline spline, float distance)
		{
		}

		[Token(Token = "0x6000701")]
		[Address(RVA = "0xB1853C", Offset = "0xB1853C", VA = "0xB1853C", Slot = "15")]
		protected override void InitializedApplyDeltaTime(float deltaTime)
		{
		}

		[Token(Token = "0x6000702")]
		[Address(RVA = "0xB185E8", Offset = "0xB185E8", VA = "0xB185E8", Slot = "16")]
		protected override void ComputeTargetPositionAndRotation(out Vector3 targetPosition, out Vector3 targetUp, out Vector3 targetForward)
		{
		}

		[Token(Token = "0x6000703")]
		[Address(RVA = "0xB18914", Offset = "0xB18914", VA = "0xB18914")]
		private static float MovementCompatibleGetPosition(SplineController controller, CurvyPositionMode positionMode, out CurvySplineSegment controlPoint, out bool isOnControlPoint, float clampedPosition)
		{
			return default(float);
		}

		[Token(Token = "0x6000704")]
		[Address(RVA = "0xB18AF4", Offset = "0xB18AF4", VA = "0xB18AF4")]
		private static void MovementCompatibleSetPosition(SplineController controller, CurvyPositionMode positionMode, float specialClampedPosition)
		{
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0xB17B60", Offset = "0xB17B60", VA = "0xB17B60")]
		private void EventAwareMove(float distance)
		{
		}

		[Token(Token = "0x6000706")]
		[Address(RVA = "0xB18C9C", Offset = "0xB18C9C", VA = "0xB18C9C")]
		private void HandleReachingNewControlPoint(CurvySplineSegment controlPoint, float controlPointPosition, CurvyPositionMode positionMode, float currentDelta, ref bool cancelMovement, out CurvySplineSegment postEventsControlPoint, out bool postEventsIsControllerOnControlPoint, out float postEventsControlPointPosition)
		{
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0xB191DC", Offset = "0xB191DC", VA = "0xB191DC")]
		private void InvokeEventHandler(CurvySplineMoveEvent @event, CurvySplineMoveEventArgs eventArgument, CurvyPositionMode positionMode, ref CurvySplineSegment postEventsControlPoint, ref bool postEventsIsControllerOnControlPoint, ref float postEventsControlPointPosition)
		{
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0xB18FF4", Offset = "0xB18FF4", VA = "0xB18FF4")]
		private CurvySplineSegment HandleRandomConnectionBehavior(CurvySplineSegment currentControlPoint, MovementDirection currentDirection, out MovementDirection newDirection, ReadOnlyCollection<CurvySplineSegment> connectedControlPoints)
		{
			return null;
		}

		[Token(Token = "0x6000709")]
		[Address(RVA = "0xB174E4", Offset = "0xB174E4", VA = "0xB174E4")]
		private static MovementDirection GetPostConnectionDirection(CurvySplineSegment connectedControlPoint, MovementDirection currentDirection, bool directionChangeAllowed)
		{
			return default(MovementDirection);
		}

		[Token(Token = "0x600070A")]
		[Address(RVA = "0xB18EFC", Offset = "0xB18EFC", VA = "0xB18EFC")]
		private CurvySplineSegment HandleFollowUpConnectionBehavior(CurvySplineSegment currentControlPoint, MovementDirection currentDirection, out MovementDirection newDirection)
		{
			return null;
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0xB192C4", Offset = "0xB192C4", VA = "0xB192C4")]
		private static MovementDirection HeadingToDirection(ConnectionHeadingEnum heading, CurvySplineSegment controlPoint, MovementDirection currentDirection)
		{
			return default(MovementDirection);
		}

		[Token(Token = "0x600070C")]
		[Address(RVA = "0xB18BF8", Offset = "0xB18BF8", VA = "0xB18BF8")]
		private static float GetControlPointPosition(CurvySplineSegment controlPoint, CurvyPositionMode positionMode)
		{
			return default(float);
		}
	}
	[Token(Token = "0x20000B8")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x864FC4", Offset = "0x864FC4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x864FC4", Offset = "0x864FC4")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x864FC4", Offset = "0x864FC4")]
	public class UITextSplineController : SplineController, IMeshModifier
	{
		[Token(Token = "0x200018B")]
		protected interface IGlyph
		{
			[Token(Token = "0x170002E5")]
			Vector3 Center
			{
				[Token(Token = "0x6000D5F")]
				get;
			}

			[Token(Token = "0x6000D60")]
			void Transpose(Vector3 v);

			[Token(Token = "0x6000D61")]
			void Rotate(Quaternion rotation);
		}

		[Token(Token = "0x200018C")]
		protected class GlyphQuad : IGlyph
		{
			[Token(Token = "0x400069E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UIVertex[] V;

			[Token(Token = "0x400069F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Rect Rect;

			[Token(Token = "0x170002E6")]
			public Vector3 Center
			{
				[Token(Token = "0x6000D62")]
				[Address(RVA = "0x181E298", Offset = "0x181E298", VA = "0x181E298", Slot = "4")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x6000D63")]
			[Address(RVA = "0x181E320", Offset = "0x181E320", VA = "0x181E320")]
			public void Load(List<UIVertex> verts, int index)
			{
			}

			[Token(Token = "0x6000D64")]
			[Address(RVA = "0x1813694", Offset = "0x1813694", VA = "0x1813694")]
			public void LoadTris(List<UIVertex> verts, int index)
			{
			}

			[Token(Token = "0x6000D65")]
			[Address(RVA = "0x181E53C", Offset = "0x181E53C", VA = "0x181E53C")]
			public void calcRect()
			{
			}

			[Token(Token = "0x6000D66")]
			[Address(RVA = "0x181E5B0", Offset = "0x181E5B0", VA = "0x181E5B0")]
			public void Save(List<UIVertex> verts, int index)
			{
			}

			[Token(Token = "0x6000D67")]
			[Address(RVA = "0x18138B0", Offset = "0x18138B0", VA = "0x18138B0")]
			public void Save(VertexHelper vh)
			{
			}

			[Token(Token = "0x6000D68")]
			[Address(RVA = "0x181E76C", Offset = "0x181E76C", VA = "0x181E76C", Slot = "5")]
			public void Transpose(Vector3 v)
			{
			}

			[Token(Token = "0x6000D69")]
			[Address(RVA = "0x181E868", Offset = "0x181E868", VA = "0x181E868", Slot = "6")]
			public void Rotate(Quaternion rotation)
			{
			}

			[Token(Token = "0x6000D6A")]
			[Address(RVA = "0x1813634", Offset = "0x1813634", VA = "0x1813634")]
			public GlyphQuad()
			{
			}
		}

		[Token(Token = "0x200018D")]
		protected class GlyphPlain : IGlyph
		{
			[Token(Token = "0x40006A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3[] V;

			[Token(Token = "0x40006A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Rect Rect;

			[Token(Token = "0x170002E7")]
			public Vector3 Center
			{
				[Token(Token = "0x6000D6B")]
				[Address(RVA = "0x181DFB0", Offset = "0x181DFB0", VA = "0x181DFB0", Slot = "4")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x6000D6C")]
			[Address(RVA = "0x1812C34", Offset = "0x1812C34", VA = "0x1812C34")]
			public void Load(ref Vector3[] verts, int index)
			{
			}

			[Token(Token = "0x6000D6D")]
			[Address(RVA = "0x181E038", Offset = "0x181E038", VA = "0x181E038")]
			public void calcRect()
			{
			}

			[Token(Token = "0x6000D6E")]
			[Address(RVA = "0x1813390", Offset = "0x1813390", VA = "0x1813390")]
			public void Save(ref Vector3[] verts, int index)
			{
			}

			[Token(Token = "0x6000D6F")]
			[Address(RVA = "0x181E0AC", Offset = "0x181E0AC", VA = "0x181E0AC", Slot = "5")]
			public void Transpose(Vector3 v)
			{
			}

			[Token(Token = "0x6000D70")]
			[Address(RVA = "0x181E1A8", Offset = "0x181E1A8", VA = "0x181E1A8", Slot = "6")]
			public void Rotate(Quaternion rotation)
			{
			}

			[Token(Token = "0x6000D71")]
			[Address(RVA = "0x1812BD4", Offset = "0x1812BD4", VA = "0x1812BD4")]
			public GlyphPlain()
			{
			}
		}

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x86BA58", Offset = "0x86BA58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86BA58", Offset = "0x86BA58")]
		[SerializeField]
		private bool staticOrientation;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Graphic m_Graphic;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private RectTransform mRect;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private Text mText;

		[Token(Token = "0x17000130")]
		public bool StaticOrientation
		{
			[Token(Token = "0x600070E")]
			[Address(RVA = "0x1812850", Offset = "0x1812850", VA = "0x1812850")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600070F")]
			[Address(RVA = "0x1812858", Offset = "0x1812858", VA = "0x1812858")]
			set
			{
			}
		}

		[Token(Token = "0x17000131")]
		protected override bool ShowOrientationSection
		{
			[Token(Token = "0x6000710")]
			[Address(RVA = "0x1812864", Offset = "0x1812864", VA = "0x1812864", Slot = "25")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000132")]
		protected override bool ShowOffsetSection
		{
			[Token(Token = "0x6000711")]
			[Address(RVA = "0x181286C", Offset = "0x181286C", VA = "0x181286C", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000133")]
		protected Text Text
		{
			[Token(Token = "0x6000712")]
			[Address(RVA = "0x1812874", Offset = "0x1812874", VA = "0x1812874")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000134")]
		protected RectTransform Rect
		{
			[Token(Token = "0x6000713")]
			[Address(RVA = "0x181290C", Offset = "0x181290C", VA = "0x181290C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000135")]
		protected Graphic graphic
		{
			[Token(Token = "0x6000714")]
			[Address(RVA = "0x18129A4", Offset = "0x18129A4", VA = "0x18129A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000136")]
		public override CurvySpline Spline
		{
			[Token(Token = "0x600071B")]
			[Address(RVA = "0x1813A44", Offset = "0x1813A44", VA = "0x1813A44", Slot = "37")]
			get
			{
				return null;
			}
			[Token(Token = "0x600071C")]
			[Address(RVA = "0x1813A4C", Offset = "0x1813A4C", VA = "0x1813A4C", Slot = "38")]
			set
			{
			}
		}

		[Token(Token = "0x6000715")]
		[Address(RVA = "0x1812A3C", Offset = "0x1812A3C", VA = "0x1812A3C", Slot = "15")]
		protected override void InitializedApplyDeltaTime(float deltaTime)
		{
		}

		[Token(Token = "0x6000716")]
		[Address(RVA = "0x1812A7C", Offset = "0x1812A7C", VA = "0x1812A7C", Slot = "40")]
		public void ModifyMesh(Mesh verts)
		{
		}

		[Token(Token = "0x6000717")]
		[Address(RVA = "0x18134C8", Offset = "0x18134C8", VA = "0x18134C8", Slot = "41")]
		public void ModifyMesh(VertexHelper vertexHelper)
		{
		}

		[Token(Token = "0x6000718")]
		[Address(RVA = "0x1812D6C", Offset = "0x1812D6C", VA = "0x1812D6C")]
		private void UpdateGlyph(IGlyph glyph)
		{
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0x18138D4", Offset = "0x18138D4", VA = "0x18138D4", Slot = "7")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x600071A")]
		[Address(RVA = "0x181398C", Offset = "0x181398C", VA = "0x181398C", Slot = "9")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x600071D")]
		[Address(RVA = "0x1813D2C", Offset = "0x1813D2C", VA = "0x1813D2C", Slot = "19")]
		protected override void BindEvents()
		{
		}

		[Token(Token = "0x600071E")]
		[Address(RVA = "0x1813D54", Offset = "0x1813D54", VA = "0x1813D54", Slot = "20")]
		protected override void UnbindEvents()
		{
		}

		[Token(Token = "0x600071F")]
		[Address(RVA = "0x1813C14", Offset = "0x1813C14", VA = "0x1813C14")]
		private void BindSplineRelatedEvents()
		{
		}

		[Token(Token = "0x6000720")]
		[Address(RVA = "0x1813B04", Offset = "0x1813B04", VA = "0x1813B04")]
		private void UnbindSplineRelatedEvents()
		{
		}

		[Token(Token = "0x6000721")]
		[Address(RVA = "0x1813D7C", Offset = "0x1813D7C", VA = "0x1813D7C")]
		private void OnSplineRefreshed(CurvySplineEventArgs e)
		{
		}

		[Token(Token = "0x6000722")]
		[Address(RVA = "0x1813EE0", Offset = "0x1813EE0", VA = "0x1813EE0")]
		public UITextSplineController()
		{
		}
	}
	[Token(Token = "0x20000B9")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x866070", Offset = "0x866070")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x866070", Offset = "0x866070")]
	public class VolumeController : CurvyController
	{
		[Token(Token = "0x40002D4")]
		private const float CrossPositionRangeMin = -0.5f;

		[Token(Token = "0x40002D5")]
		private const float CrossPositionRangeMax = 0.5f;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x86BAD4", Offset = "0x86BAD4")]
		[AttributeAttribute(Name = "CGDataReferenceSelectorAttribute", RVA = "0x86BAD4", Offset = "0x86BAD4")]
		[SerializeField]
		private CGDataReference m_Volume;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x86BB88", Offset = "0x86BB88")]
		[SerializeField]
		[FloatRegion]
		private FloatRegion m_CrossRange;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x86BC3C", Offset = "0x86BC3C")]
		[SerializeField]
		private float crossRelativePosition;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private CurvyClamping m_CrossClamping;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[SerializeField]
		[HideInInspector]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x86BCE4", Offset = "0x86BCE4")]
		private float m_CrossInitialPosition;

		[Token(Token = "0x17000137")]
		public CGDataReference Volume
		{
			[Token(Token = "0x6000723")]
			[Address(RVA = "0x1814E04", Offset = "0x1814E04", VA = "0x1814E04")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000724")]
			[Address(RVA = "0x1814E0C", Offset = "0x1814E0C", VA = "0x1814E0C")]
			set
			{
			}
		}

		[Token(Token = "0x17000138")]
		public CGVolume VolumeData
		{
			[Token(Token = "0x6000725")]
			[Address(RVA = "0x1814E14", Offset = "0x1814E14", VA = "0x1814E14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000139")]
		public float CrossFrom
		{
			[Token(Token = "0x6000726")]
			[Address(RVA = "0x1814E8C", Offset = "0x1814E8C", VA = "0x1814E8C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000727")]
			[Address(RVA = "0x1814E94", Offset = "0x1814E94", VA = "0x1814E94")]
			set
			{
			}
		}

		[Token(Token = "0x1700013A")]
		public float CrossTo
		{
			[Token(Token = "0x6000728")]
			[Address(RVA = "0x1814F18", Offset = "0x1814F18", VA = "0x1814F18")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000729")]
			[Address(RVA = "0x1814F20", Offset = "0x1814F20", VA = "0x1814F20")]
			set
			{
			}
		}

		[Token(Token = "0x1700013B")]
		public float CrossLength
		{
			[Token(Token = "0x600072A")]
			[Address(RVA = "0x1814FA8", Offset = "0x1814FA8", VA = "0x1814FA8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700013C")]
		public CurvyClamping CrossClamping
		{
			[Token(Token = "0x600072B")]
			[Address(RVA = "0x1814FB4", Offset = "0x1814FB4", VA = "0x1814FB4")]
			get
			{
				return default(CurvyClamping);
			}
			[Token(Token = "0x600072C")]
			[Address(RVA = "0x1814FBC", Offset = "0x1814FBC", VA = "0x1814FBC")]
			set
			{
			}
		}

		[Token(Token = "0x1700013D")]
		public float CrossRelativePosition
		{
			[Token(Token = "0x600072D")]
			[Address(RVA = "0x1814FC4", Offset = "0x1814FC4", VA = "0x1814FC4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600072E")]
			[Address(RVA = "0x1814FF0", Offset = "0x1814FF0", VA = "0x1814FF0")]
			set
			{
			}
		}

		[Token(Token = "0x1700013E")]
		public override float Length
		{
			[Token(Token = "0x600072F")]
			[Address(RVA = "0x1815020", Offset = "0x1815020", VA = "0x1815020", Slot = "27")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700013F")]
		public override bool IsReady
		{
			[Token(Token = "0x6000732")]
			[Address(RVA = "0x1815148", Offset = "0x1815148", VA = "0x1815148", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000140")]
		private RegionOptions<float> CrossRangeOptions
		{
			[Token(Token = "0x600073B")]
			[Address(RVA = "0x18156B0", Offset = "0x18156B0", VA = "0x18156B0")]
			get
			{
				return default(RegionOptions<float>);
			}
		}

		[Token(Token = "0x17000141")]
		private float MinCrossRelativePosition
		{
			[Token(Token = "0x600073C")]
			[Address(RVA = "0x1815708", Offset = "0x1815708", VA = "0x1815708")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000142")]
		private float MaxCrossRelativePosition
		{
			[Token(Token = "0x600073D")]
			[Address(RVA = "0x1815710", Offset = "0x1815710", VA = "0x1815710")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000730")]
		[Address(RVA = "0x1815060", Offset = "0x1815060", VA = "0x1815060")]
		public float CrossRelativeToAbsolute(float relativeDistance)
		{
			return default(float);
		}

		[Token(Token = "0x6000731")]
		[Address(RVA = "0x18150D4", Offset = "0x18150D4", VA = "0x18150D4")]
		public float CrossAbsoluteToRelative(float worldUnitDistance)
		{
			return default(float);
		}

		[Token(Token = "0x6000733")]
		[Address(RVA = "0x1815198", Offset = "0x1815198", VA = "0x1815198", Slot = "31")]
		protected override float RelativeToAbsolute(float relativeDistance)
		{
			return default(float);
		}

		[Token(Token = "0x6000734")]
		[Address(RVA = "0x18151F4", Offset = "0x18151F4", VA = "0x18151F4", Slot = "30")]
		protected override float AbsoluteToRelative(float worldUnitDistance)
		{
			return default(float);
		}

		[Token(Token = "0x6000735")]
		[Address(RVA = "0x1815250", Offset = "0x1815250", VA = "0x1815250", Slot = "32")]
		protected override Vector3 GetInterpolatedSourcePosition(float tf)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000736")]
		[Address(RVA = "0x18152E8", Offset = "0x18152E8", VA = "0x18152E8", Slot = "33")]
		protected override void GetInterpolatedSourcePosition(float tf, out Vector3 interpolatedPosition, out Vector3 tangent, out Vector3 up)
		{
		}

		[Token(Token = "0x6000737")]
		[Address(RVA = "0x18153EC", Offset = "0x18153EC", VA = "0x18153EC", Slot = "35")]
		protected override Vector3 GetTangent(float tf)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000738")]
		[Address(RVA = "0x1815484", Offset = "0x1815484", VA = "0x1815484", Slot = "34")]
		protected override Vector3 GetOrientation(float tf)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000739")]
		[Address(RVA = "0x181551C", Offset = "0x181551C", VA = "0x181551C", Slot = "28")]
		protected override void Advance(float speed, float deltaTime)
		{
		}

		[Token(Token = "0x600073A")]
		[Address(RVA = "0x1815598", Offset = "0x1815598", VA = "0x1815598", Slot = "29")]
		protected override void SimulateAdvance(ref float tf, ref MovementDirection curyDirection, float speed, float deltaTime)
		{
		}

		[Token(Token = "0x600073E")]
		[Address(RVA = "0x1814FDC", Offset = "0x1814FDC", VA = "0x1814FDC")]
		private float GetClampedCrossPosition(float position)
		{
			return default(float);
		}

		[Token(Token = "0x600073F")]
		[Address(RVA = "0x1815718", Offset = "0x1815718", VA = "0x1815718", Slot = "36")]
		public override void OnAfterDeserialize()
		{
		}

		[Token(Token = "0x6000740")]
		[Address(RVA = "0x1815770", Offset = "0x1815770", VA = "0x1815770")]
		public VolumeController()
		{
		}
	}
}
namespace FluffyUnderware.Curvy.Components
{
	[Token(Token = "0x20000BA")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x8660D4", Offset = "0x8660D4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8660D4", Offset = "0x8660D4")]
	public class CurvyGLRenderer : MonoBehaviour
	{
		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[ArrayEx]
		public List<GLSlotData> Splines;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Material lineMaterial;

		[Token(Token = "0x6000741")]
		[Address(RVA = "0x15B88F0", Offset = "0x15B88F0", VA = "0x15B88F0")]
		private void CreateLineMaterial()
		{
		}

		[Token(Token = "0x6000742")]
		[Address(RVA = "0x15B89F0", Offset = "0x15B89F0", VA = "0x15B89F0")]
		private void OnPostRender()
		{
		}

		[Token(Token = "0x6000743")]
		[Address(RVA = "0x15B8BCC", Offset = "0x15B8BCC", VA = "0x15B8BCC")]
		private void sanitize()
		{
		}

		[Token(Token = "0x6000744")]
		[Address(RVA = "0x15B8CFC", Offset = "0x15B8CFC", VA = "0x15B8CFC")]
		private void OnSplineRefresh(CurvySplineEventArgs e)
		{
		}

		[Token(Token = "0x6000745")]
		[Address(RVA = "0x15B8E50", Offset = "0x15B8E50", VA = "0x15B8E50")]
		private GLSlotData getSlot(CurvySpline spline)
		{
			return null;
		}

		[Token(Token = "0x6000746")]
		[Address(RVA = "0x15B8FCC", Offset = "0x15B8FCC", VA = "0x15B8FCC")]
		public void Add(CurvySpline spline)
		{
		}

		[Token(Token = "0x6000747")]
		[Address(RVA = "0x15B90A0", Offset = "0x15B90A0", VA = "0x15B90A0")]
		public void Remove(CurvySpline spline)
		{
		}

		[Token(Token = "0x6000748")]
		[Address(RVA = "0x15B91A4", Offset = "0x15B91A4", VA = "0x15B91A4")]
		public CurvyGLRenderer()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000BB")]
	public class GLSlotData
	{
		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		public CurvySpline Spline;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Color LineColor;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<Vector3[]> VertexData;

		[Token(Token = "0x6000749")]
		[Address(RVA = "0x145B750", Offset = "0x145B750", VA = "0x145B750")]
		public void GetVertexData()
		{
		}

		[Token(Token = "0x600074A")]
		[Address(RVA = "0x145B894", Offset = "0x145B894", VA = "0x145B894")]
		public void Render(Material mat)
		{
		}

		[Token(Token = "0x600074B")]
		[Address(RVA = "0x145BA7C", Offset = "0x145BA7C", VA = "0x145BA7C")]
		public GLSlotData()
		{
		}
	}
	[Token(Token = "0x20000BC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x866134", Offset = "0x866134")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x866134", Offset = "0x866134")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x866134", Offset = "0x866134")]
	public class CurvyLineRenderer : MonoBehaviour
	{
		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CurvySpline m_Spline;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private LineRenderer mRenderer;

		[Token(Token = "0x17000143")]
		public CurvySpline Spline
		{
			[Token(Token = "0x600074C")]
			[Address(RVA = "0x15BE998", Offset = "0x15BE998", VA = "0x15BE998")]
			get
			{
				return null;
			}
			[Token(Token = "0x600074D")]
			[Address(RVA = "0x15BE9A0", Offset = "0x15BE9A0", VA = "0x15BE9A0")]
			set
			{
			}
		}

		[Token(Token = "0x600074E")]
		[Address(RVA = "0x15BEE28", Offset = "0x15BEE28", VA = "0x15BEE28")]
		private void Awake()
		{
		}

		[Token(Token = "0x600074F")]
		[Address(RVA = "0x15BEF3C", Offset = "0x15BEF3C", VA = "0x15BEF3C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000750")]
		[Address(RVA = "0x15BEF98", Offset = "0x15BEF98", VA = "0x15BEF98")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000751")]
		[Address(RVA = "0x15BEF9C", Offset = "0x15BEF9C", VA = "0x15BEF9C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000752")]
		[Address(RVA = "0x15BEFA0", Offset = "0x15BEFA0", VA = "0x15BEFA0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000753")]
		[Address(RVA = "0x15BEFA4", Offset = "0x15BEFA4", VA = "0x15BEFA4")]
		private void EnforceWorldSpaceUsage()
		{
		}

		[Token(Token = "0x6000754")]
		[Address(RVA = "0x15BECEC", Offset = "0x15BECEC", VA = "0x15BECEC")]
		public void Refresh()
		{
		}

		[Token(Token = "0x6000755")]
		[Address(RVA = "0x15BF1C8", Offset = "0x15BF1C8", VA = "0x15BF1C8")]
		private void OnSplineRefresh(CurvySplineEventArgs e)
		{
		}

		[Token(Token = "0x6000756")]
		[Address(RVA = "0x15BF1CC", Offset = "0x15BF1CC", VA = "0x15BF1CC")]
		private void OnSplineCoordinatesChanged(CurvySpline spline)
		{
		}

		[Token(Token = "0x6000757")]
		[Address(RVA = "0x15BEB9C", Offset = "0x15BEB9C", VA = "0x15BEB9C")]
		private void BindEvents()
		{
		}

		[Token(Token = "0x6000758")]
		[Address(RVA = "0x15BEA4C", Offset = "0x15BEA4C", VA = "0x15BEA4C")]
		private void UnbindEvents()
		{
		}

		[Token(Token = "0x6000759")]
		[Address(RVA = "0x15BF1D0", Offset = "0x15BF1D0", VA = "0x15BF1D0")]
		public CurvyLineRenderer()
		{
		}
	}
}
namespace FluffyUnderware.Curvy.Shapes
{
	[Token(Token = "0x20000BD")]
	[AttributeAttribute(Name = "CurvyShapeInfo", RVA = "0x8661F0", Offset = "0x8661F0")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x8661F0", Offset = "0x8661F0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8661F0", Offset = "0x8661F0")]
	public class CSCircle : CurvyShape2D
	{
		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Positive]
		[SerializeField]
		private int m_Count;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float m_Radius;

		[Token(Token = "0x17000144")]
		public int Count
		{
			[Token(Token = "0x600075A")]
			[Address(RVA = "0x10A21F4", Offset = "0x10A21F4", VA = "0x10A21F4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600075B")]
			[Address(RVA = "0x10A21FC", Offset = "0x10A21FC", VA = "0x10A21FC")]
			set
			{
			}
		}

		[Token(Token = "0x17000145")]
		public float Radius
		{
			[Token(Token = "0x600075C")]
			[Address(RVA = "0x10A2290", Offset = "0x10A2290", VA = "0x10A2290")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600075D")]
			[Address(RVA = "0x10A2298", Offset = "0x10A2298", VA = "0x10A2298")]
			set
			{
			}
		}

		[Token(Token = "0x600075E")]
		[Address(RVA = "0x10A232C", Offset = "0x10A232C", VA = "0x10A232C", Slot = "4")]
		protected override void Reset()
		{
		}

		[Token(Token = "0x600075F")]
		[Address(RVA = "0x10A2364", Offset = "0x10A2364", VA = "0x10A2364", Slot = "5")]
		protected override void ApplyShape()
		{
		}

		[Token(Token = "0x6000760")]
		[Address(RVA = "0x10A24C8", Offset = "0x10A24C8", VA = "0x10A24C8")]
		public CSCircle()
		{
		}
	}
	[Token(Token = "0x20000BE")]
	[AttributeAttribute(Name = "CurvyShapeInfo", RVA = "0x8662A0", Offset = "0x8662A0")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x8662A0", Offset = "0x8662A0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8662A0", Offset = "0x8662A0")]
	public class CSPie : CSCircle
	{
		[Token(Token = "0x200018E")]
		public enum EatModeEnum
		{
			[Token(Token = "0x40006A3")]
			Left,
			[Token(Token = "0x40006A4")]
			Right,
			[Token(Token = "0x40006A5")]
			Center
		}

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86BDE0", Offset = "0x86BDE0")]
		[SerializeField]
		private float m_Roundness;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x86BE20", Offset = "0x86BE20")]
		private int m_Empty;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x86BEA0", Offset = "0x86BEA0")]
		[SerializeField]
		private EatModeEnum m_Eat;

		[Token(Token = "0x17000146")]
		public float Roundness
		{
			[Token(Token = "0x6000761")]
			[Address(RVA = "0x10A24DC", Offset = "0x10A24DC", VA = "0x10A24DC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000762")]
			[Address(RVA = "0x10A24E4", Offset = "0x10A24E4", VA = "0x10A24E4")]
			set
			{
			}
		}

		[Token(Token = "0x17000147")]
		public int Empty
		{
			[Token(Token = "0x6000763")]
			[Address(RVA = "0x10A2574", Offset = "0x10A2574", VA = "0x10A2574")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000764")]
			[Address(RVA = "0x10A257C", Offset = "0x10A257C", VA = "0x10A257C")]
			set
			{
			}
		}

		[Token(Token = "0x17000148")]
		private int maxEmpty
		{
			[Token(Token = "0x6000765")]
			[Address(RVA = "0x10A2618", Offset = "0x10A2618", VA = "0x10A2618")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000149")]
		public EatModeEnum Eat
		{
			[Token(Token = "0x6000766")]
			[Address(RVA = "0x10A2620", Offset = "0x10A2620", VA = "0x10A2620")]
			get
			{
				return default(EatModeEnum);
			}
			[Token(Token = "0x6000767")]
			[Address(RVA = "0x10A2628", Offset = "0x10A2628", VA = "0x10A2628")]
			set
			{
			}
		}

		[Token(Token = "0x6000768")]
		[Address(RVA = "0x10A2644", Offset = "0x10A2644", VA = "0x10A2644", Slot = "4")]
		protected override void Reset()
		{
		}

		[Token(Token = "0x6000769")]
		[Address(RVA = "0x10A2694", Offset = "0x10A2694", VA = "0x10A2694")]
		private Vector3 cpPosition(int i, int empty, float d)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600076A")]
		[Address(RVA = "0x10A27C0", Offset = "0x10A27C0", VA = "0x10A27C0", Slot = "5")]
		protected override void ApplyShape()
		{
		}

		[Token(Token = "0x600076B")]
		[Address(RVA = "0x10A2ED0", Offset = "0x10A2ED0", VA = "0x10A2ED0")]
		public CSPie()
		{
		}
	}
	[Token(Token = "0x20000BF")]
	[AttributeAttribute(Name = "CurvyShapeInfo", RVA = "0x866350", Offset = "0x866350")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x866350", Offset = "0x866350")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x866350", Offset = "0x866350")]
	public class CSRectangle : CurvyShape2D
	{
		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Positive]
		[SerializeField]
		private float m_Width;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Positive]
		[SerializeField]
		private float m_Height;

		[Token(Token = "0x1700014A")]
		public float Width
		{
			[Token(Token = "0x600076C")]
			[Address(RVA = "0x10A2EEC", Offset = "0x10A2EEC", VA = "0x10A2EEC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600076D")]
			[Address(RVA = "0x10A2EF4", Offset = "0x10A2EF4", VA = "0x10A2EF4")]
			set
			{
			}
		}

		[Token(Token = "0x1700014B")]
		public float Height
		{
			[Token(Token = "0x600076E")]
			[Address(RVA = "0x10A2F88", Offset = "0x10A2F88", VA = "0x10A2F88")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600076F")]
			[Address(RVA = "0x10A2F90", Offset = "0x10A2F90", VA = "0x10A2F90")]
			set
			{
			}
		}

		[Token(Token = "0x6000770")]
		[Address(RVA = "0x10A3024", Offset = "0x10A3024", VA = "0x10A3024", Slot = "4")]
		protected override void Reset()
		{
		}

		[Token(Token = "0x6000771")]
		[Address(RVA = "0x10A3068", Offset = "0x10A3068", VA = "0x10A3068", Slot = "5")]
		protected override void ApplyShape()
		{
		}

		[Token(Token = "0x6000772")]
		[Address(RVA = "0x10A3214", Offset = "0x10A3214", VA = "0x10A3214")]
		public CSRectangle()
		{
		}
	}
	[Token(Token = "0x20000C0")]
	[AttributeAttribute(Name = "CurvyShapeInfo", RVA = "0x866400", Offset = "0x866400")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x866400", Offset = "0x866400")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x866400", Offset = "0x866400")]
	public class CSRoundedRectangle : CurvyShape2D
	{
		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Positive]
		[SerializeField]
		private float m_Width;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Positive]
		[SerializeField]
		private float m_Height;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86BFCC", Offset = "0x86BFCC")]
		[SerializeField]
		private float m_Roundness;

		[Token(Token = "0x1700014C")]
		public float Width
		{
			[Token(Token = "0x6000773")]
			[Address(RVA = "0x10A3224", Offset = "0x10A3224", VA = "0x10A3224")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000774")]
			[Address(RVA = "0x10A322C", Offset = "0x10A322C", VA = "0x10A322C")]
			set
			{
			}
		}

		[Token(Token = "0x1700014D")]
		public float Height
		{
			[Token(Token = "0x6000775")]
			[Address(RVA = "0x10A32C0", Offset = "0x10A32C0", VA = "0x10A32C0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000776")]
			[Address(RVA = "0x10A32C8", Offset = "0x10A32C8", VA = "0x10A32C8")]
			set
			{
			}
		}

		[Token(Token = "0x1700014E")]
		public float Roundness
		{
			[Token(Token = "0x6000777")]
			[Address(RVA = "0x10A335C", Offset = "0x10A335C", VA = "0x10A335C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000778")]
			[Address(RVA = "0x10A3364", Offset = "0x10A3364", VA = "0x10A3364")]
			set
			{
			}
		}

		[Token(Token = "0x6000779")]
		[Address(RVA = "0x10A33F4", Offset = "0x10A33F4", VA = "0x10A33F4", Slot = "4")]
		protected override void Reset()
		{
		}

		[Token(Token = "0x600077A")]
		[Address(RVA = "0x10A3444", Offset = "0x10A3444", VA = "0x10A3444", Slot = "5")]
		protected override void ApplyShape()
		{
		}

		[Token(Token = "0x600077B")]
		[Address(RVA = "0x10A3A30", Offset = "0x10A3A30", VA = "0x10A3A30")]
		public CSRoundedRectangle()
		{
		}
	}
	[Token(Token = "0x20000C1")]
	[AttributeAttribute(Name = "CurvyShapeInfo", RVA = "0x8664B0", Offset = "0x8664B0")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x8664B0", Offset = "0x8664B0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8664B0", Offset = "0x8664B0")]
	public class CSSpiral : CurvyShape2D
	{
		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Positive]
		[SerializeField]
		private int m_Count;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Positive]
		[SerializeField]
		private float m_Circles;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Positive]
		[SerializeField]
		private float m_Radius;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x86C0F0", Offset = "0x86C0F0")]
		[SerializeField]
		private AnimationCurve m_RadiusFactor;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private AnimationCurve m_Z;

		[Token(Token = "0x1700014F")]
		public int Count
		{
			[Token(Token = "0x600077C")]
			[Address(RVA = "0x10A3A48", Offset = "0x10A3A48", VA = "0x10A3A48")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600077D")]
			[Address(RVA = "0x10A3A50", Offset = "0x10A3A50", VA = "0x10A3A50")]
			set
			{
			}
		}

		[Token(Token = "0x17000150")]
		public float Circles
		{
			[Token(Token = "0x600077E")]
			[Address(RVA = "0x10A3AE4", Offset = "0x10A3AE4", VA = "0x10A3AE4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600077F")]
			[Address(RVA = "0x10A3AEC", Offset = "0x10A3AEC", VA = "0x10A3AEC")]
			set
			{
			}
		}

		[Token(Token = "0x17000151")]
		public float Radius
		{
			[Token(Token = "0x6000780")]
			[Address(RVA = "0x10A3B80", Offset = "0x10A3B80", VA = "0x10A3B80")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000781")]
			[Address(RVA = "0x10A3B88", Offset = "0x10A3B88", VA = "0x10A3B88")]
			set
			{
			}
		}

		[Token(Token = "0x17000152")]
		public AnimationCurve RadiusFactor
		{
			[Token(Token = "0x6000782")]
			[Address(RVA = "0x10A3C1C", Offset = "0x10A3C1C", VA = "0x10A3C1C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000783")]
			[Address(RVA = "0x10A3C24", Offset = "0x10A3C24", VA = "0x10A3C24")]
			set
			{
			}
		}

		[Token(Token = "0x17000153")]
		public AnimationCurve Z
		{
			[Token(Token = "0x6000784")]
			[Address(RVA = "0x10A3C40", Offset = "0x10A3C40", VA = "0x10A3C40")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000785")]
			[Address(RVA = "0x10A3C48", Offset = "0x10A3C48", VA = "0x10A3C48")]
			set
			{
			}
		}

		[Token(Token = "0x6000786")]
		[Address(RVA = "0x10A3C64", Offset = "0x10A3C64", VA = "0x10A3C64", Slot = "4")]
		protected override void Reset()
		{
		}

		[Token(Token = "0x6000787")]
		[Address(RVA = "0x10A3D0C", Offset = "0x10A3D0C", VA = "0x10A3D0C", Slot = "5")]
		protected override void ApplyShape()
		{
		}

		[Token(Token = "0x6000788")]
		[Address(RVA = "0x10A3EBC", Offset = "0x10A3EBC", VA = "0x10A3EBC")]
		public CSSpiral()
		{
		}
	}
	[Token(Token = "0x20000C2")]
	[AttributeAttribute(Name = "CurvyShapeInfo", RVA = "0x866560", Offset = "0x866560")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x866560", Offset = "0x866560")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x866560", Offset = "0x866560")]
	public class CSStar : CurvyShape2D
	{
		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		[Positive]
		private int m_Sides;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Positive]
		private float m_OuterRadius;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x86C1DC", Offset = "0x86C1DC")]
		private float m_OuterRoundness;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Positive]
		private float m_InnerRadius;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x86C284", Offset = "0x86C284")]
		private float m_InnerRoundness;

		[Token(Token = "0x17000154")]
		public int Sides
		{
			[Token(Token = "0x6000789")]
			[Address(RVA = "0x10A3F38", Offset = "0x10A3F38", VA = "0x10A3F38")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600078A")]
			[Address(RVA = "0x10A3F40", Offset = "0x10A3F40", VA = "0x10A3F40")]
			set
			{
			}
		}

		[Token(Token = "0x17000155")]
		public float OuterRadius
		{
			[Token(Token = "0x600078B")]
			[Address(RVA = "0x10A3FD4", Offset = "0x10A3FD4", VA = "0x10A3FD4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600078C")]
			[Address(RVA = "0x10A3FDC", Offset = "0x10A3FDC", VA = "0x10A3FDC")]
			set
			{
			}
		}

		[Token(Token = "0x17000156")]
		public float OuterRoundness
		{
			[Token(Token = "0x600078D")]
			[Address(RVA = "0x10A4074", Offset = "0x10A4074", VA = "0x10A4074")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600078E")]
			[Address(RVA = "0x10A407C", Offset = "0x10A407C", VA = "0x10A407C")]
			set
			{
			}
		}

		[Token(Token = "0x17000157")]
		public float InnerRadius
		{
			[Token(Token = "0x600078F")]
			[Address(RVA = "0x10A4110", Offset = "0x10A4110", VA = "0x10A4110")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000790")]
			[Address(RVA = "0x10A4118", Offset = "0x10A4118", VA = "0x10A4118")]
			set
			{
			}
		}

		[Token(Token = "0x17000158")]
		public float InnerRoundness
		{
			[Token(Token = "0x6000791")]
			[Address(RVA = "0x10A41AC", Offset = "0x10A41AC", VA = "0x10A41AC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000792")]
			[Address(RVA = "0x10A41B4", Offset = "0x10A41B4", VA = "0x10A41B4")]
			set
			{
			}
		}

		[Token(Token = "0x6000793")]
		[Address(RVA = "0x10A4248", Offset = "0x10A4248", VA = "0x10A4248", Slot = "4")]
		protected override void Reset()
		{
		}

		[Token(Token = "0x6000794")]
		[Address(RVA = "0x10A42A4", Offset = "0x10A42A4", VA = "0x10A42A4", Slot = "5")]
		protected override void ApplyShape()
		{
		}

		[Token(Token = "0x6000795")]
		[Address(RVA = "0x10A44E4", Offset = "0x10A44E4", VA = "0x10A44E4")]
		public CSStar()
		{
		}
	}
}
namespace FluffyUnderware.Curvy.Utils
{
	[Token(Token = "0x20000C3")]
	public static class OptimizedOperators
	{
		[Token(Token = "0x6000796")]
		[Address(RVA = "0xDF535C", Offset = "0xDF535C", VA = "0xDF535C")]
		public static Vector3 Addition(this Vector3 a, Vector3 b)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000797")]
		[Address(RVA = "0xDF536C", Offset = "0xDF536C", VA = "0xDF536C")]
		public static Vector3 UnaryNegation(this Vector3 a)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000798")]
		[Address(RVA = "0xDF537C", Offset = "0xDF537C", VA = "0xDF537C")]
		public static Vector3 Subtraction(this Vector3 a, Vector3 b)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000799")]
		[Address(RVA = "0xDF538C", Offset = "0xDF538C", VA = "0xDF538C")]
		public static Vector3 Multiply(this Vector3 a, float d)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600079A")]
		[Address(RVA = "0xDF539C", Offset = "0xDF539C", VA = "0xDF539C")]
		public static Vector3 Multiply(this float d, Vector3 a)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600079B")]
		[Address(RVA = "0xDF53B0", Offset = "0xDF53B0", VA = "0xDF53B0")]
		public static Vector3 Division(this Vector3 a, float d)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600079C")]
		[Address(RVA = "0xDF53C8", Offset = "0xDF53C8", VA = "0xDF53C8")]
		public static Vector3 Normalize(this Vector3 value)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600079D")]
		[Address(RVA = "0xDF54AC", Offset = "0xDF54AC", VA = "0xDF54AC")]
		public static Vector3 LerpUnclamped(this Vector3 a, Vector3 b, float t)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x20000C4")]
	public static class CurvyUtility
	{
		[Token(Token = "0x600079E")]
		[Address(RVA = "0x1454A20", Offset = "0x1454A20", VA = "0x1454A20")]
		public static float ClampTF(float tf, CurvyClamping clamping)
		{
			return default(float);
		}

		[Token(Token = "0x600079F")]
		[Address(RVA = "0x1454B50", Offset = "0x1454B50", VA = "0x1454B50")]
		public static float ClampTF(float tf, ref int dir, CurvyClamping clamping)
		{
			return default(float);
		}

		[Token(Token = "0x60007A0")]
		[Address(RVA = "0x1454CC8", Offset = "0x1454CC8", VA = "0x1454CC8")]
		public static float ClampValue(float tf, CurvyClamping clamping, float minTF, float maxTF)
		{
			return default(float);
		}

		[Token(Token = "0x60007A1")]
		[Address(RVA = "0x1454E5C", Offset = "0x1454E5C", VA = "0x1454E5C")]
		public static float ClampDistance(float distance, CurvyClamping clamping, float length)
		{
			return default(float);
		}

		[Token(Token = "0x60007A2")]
		[Address(RVA = "0x1454FB4", Offset = "0x1454FB4", VA = "0x1454FB4")]
		public static float ClampDistance(float distance, CurvyClamping clamping, float length, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x60007A3")]
		[Address(RVA = "0x1455148", Offset = "0x1455148", VA = "0x1455148")]
		public static float ClampDistance(float distance, ref int dir, CurvyClamping clamping, float length)
		{
			return default(float);
		}

		[Token(Token = "0x60007A4")]
		[Address(RVA = "0x14552EC", Offset = "0x14552EC", VA = "0x14552EC")]
		public static float ClampDistance(float distance, ref int dir, CurvyClamping clamping, float length, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x60007A5")]
		[Address(RVA = "0x14554C8", Offset = "0x14554C8", VA = "0x14554C8")]
		public static Material GetDefaultMaterial()
		{
			return null;
		}

		[Token(Token = "0x60007A6")]
		[Address(RVA = "0x14555C4", Offset = "0x14555C4", VA = "0x14555C4")]
		public static bool Approximately(this float x, float y)
		{
			return default(bool);
		}

		[Token(Token = "0x60007A7")]
		[Address(RVA = "0x14511E0", Offset = "0x14511E0", VA = "0x14511E0")]
		public static int InterpolationSearch(float[] array, float x)
		{
			return default(int);
		}
	}
	[Token(Token = "0x20000C5")]
	public class Spline2Mesh
	{
		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<SplinePolyLine> Lines;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public WindingRule Winding;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector2 UVTiling;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector2 UVOffset;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool SuppressUVMapping;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		public bool UV2;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string MeshName;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool VertexLineOnly;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86C2F4", Offset = "0x86C2F4")]
		private string <Error>k__BackingField;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Tess mTess;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Mesh mMesh;

		[Token(Token = "0x17000159")]
		public string Error
		{
			[Token(Token = "0x60007A8")]
			[Address(RVA = "0xB16264", Offset = "0xB16264", VA = "0xB16264")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x877380", Offset = "0x877380")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007A9")]
			[Address(RVA = "0xB1626C", Offset = "0xB1626C", VA = "0xB1626C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x877390", Offset = "0x877390")]
			private set
			{
			}
		}

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0xB16274", Offset = "0xB16274", VA = "0xB16274")]
		public bool Apply(out Mesh result)
		{
			return default(bool);
		}

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0xB1675C", Offset = "0xB1675C", VA = "0xB1675C")]
		private bool triangulate()
		{
			return default(bool);
		}

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0xB16C58", Offset = "0xB16C58", VA = "0xB16C58")]
		private static bool polyLineIsValid(SplinePolyLine pl)
		{
			return default(bool);
		}

		[Token(Token = "0x60007AD")]
		[Address(RVA = "0xB16EDC", Offset = "0xB16EDC", VA = "0xB16EDC")]
		public Spline2Mesh()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000C6")]
	public class SplinePolyLine
	{
		[Token(Token = "0x200018F")]
		public enum VertexCalculation
		{
			[Token(Token = "0x40006A7")]
			ByApproximation,
			[Token(Token = "0x40006A8")]
			ByAngle
		}

		[Token(Token = "0x2000190")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x867B04", Offset = "0x867B04")]
		private sealed class <>c__DisplayClass13_0
		{
			[Token(Token = "0x40006A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<Vector3> vPos;

			[Token(Token = "0x40006AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 curPos;

			[Token(Token = "0x40006AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public List<Vector3> vTan;

			[Token(Token = "0x40006AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Vector3 curTangent;

			[Token(Token = "0x40006AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public List<float> vTF;

			[Token(Token = "0x40006AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public float angleFromLast;

			[Token(Token = "0x40006AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public float distAccu;

			[Token(Token = "0x40006B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public int linearSteps;

			[Token(Token = "0x6000D72")]
			[Address(RVA = "0x181C0CC", Offset = "0x181C0CC", VA = "0x181C0CC")]
			public <>c__DisplayClass13_0()
			{
			}

			[Token(Token = "0x6000D73")]
			[Address(RVA = "0x181C0D4", Offset = "0x181C0D4", VA = "0x181C0D4")]
			internal void <GetPolygon>b__0(float f)
			{
			}
		}

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ContourOrientation Orientation;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CurvySpline Spline;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public VertexCalculation VertexMode;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float Angle;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float Distance;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Space Space;

		[Token(Token = "0x1700015A")]
		public bool IsClosed
		{
			[Token(Token = "0x60007B1")]
			[Address(RVA = "0xB1CBC0", Offset = "0xB1CBC0", VA = "0xB1CBC0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60007AE")]
		[Address(RVA = "0xB1CAEC", Offset = "0xB1CAEC", VA = "0xB1CAEC")]
		public SplinePolyLine(CurvySpline spline)
		{
		}

		[Token(Token = "0x60007AF")]
		[Address(RVA = "0xB1CB74", Offset = "0xB1CB74", VA = "0xB1CB74")]
		public SplinePolyLine(CurvySpline spline, float angle, float distance)
		{
		}

		[Token(Token = "0x60007B0")]
		[Address(RVA = "0xB1CB1C", Offset = "0xB1CB1C", VA = "0xB1CB1C")]
		private SplinePolyLine(CurvySpline spline, VertexCalculation vertexMode, float angle, float distance, Space space = Space.World)
		{
		}

		[Token(Token = "0x60007B2")]
		[Address(RVA = "0xB16A68", Offset = "0xB16A68", VA = "0xB16A68")]
		public Vector3[] GetVertices()
		{
			return null;
		}

		[Token(Token = "0x60007B3")]
		[Address(RVA = "0xB1CC54", Offset = "0xB1CC54", VA = "0xB1CC54")]
		private static Vector3[] GetPolygon(CurvySpline spline, float fromTF, float toTF, float maxAngle, float minDistance, float maxDistance, out List<float> vertexTF, out List<Vector3> vertexTangents, bool includeEndPoint = true, float stepSize = 0.01f)
		{
			return null;
		}
	}
}
namespace FluffyUnderware.Curvy.Generator
{
	[Token(Token = "0x20000C7")]
	public abstract class SplineInputModuleBase : CGModule
	{
		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x86C304", Offset = "0x86C304")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86C304", Offset = "0x86C304")]
		private bool m_UseCache;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA5")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86C374", Offset = "0x86C374")]
		[SerializeField]
		private bool m_UseGlobalSpace;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x86C3C0", Offset = "0x86C3C0")]
		[SerializeField]
		protected CurvySplineSegment m_StartCP;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x86C40C", Offset = "0x86C40C")]
		[SerializeField]
		protected CurvySplineSegment m_EndCP;

		[Token(Token = "0x1700015B")]
		public bool UseCache
		{
			[Token(Token = "0x60007B4")]
			[Address(RVA = "0xB19484", Offset = "0xB19484", VA = "0xB19484")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007B5")]
			[Address(RVA = "0xB1948C", Offset = "0xB1948C", VA = "0xB1948C")]
			set
			{
			}
		}

		[Token(Token = "0x1700015C")]
		public CurvySplineSegment StartCP
		{
			[Token(Token = "0x60007B6")]
			[Address(RVA = "0xB194B4", Offset = "0xB194B4", VA = "0xB194B4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007B7")]
			[Address(RVA = "0xB194BC", Offset = "0xB194BC", VA = "0xB194BC")]
			set
			{
			}
		}

		[Token(Token = "0x1700015D")]
		public CurvySplineSegment EndCP
		{
			[Token(Token = "0x60007B8")]
			[Address(RVA = "0xB197D8", Offset = "0xB197D8", VA = "0xB197D8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007B9")]
			[Address(RVA = "0xB197E0", Offset = "0xB197E0", VA = "0xB197E0")]
			set
			{
			}
		}

		[Token(Token = "0x1700015E")]
		public bool UseGlobalSpace
		{
			[Token(Token = "0x60007BA")]
			[Address(RVA = "0xB1987C", Offset = "0xB1987C", VA = "0xB1987C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007BB")]
			[Address(RVA = "0xB19884", Offset = "0xB19884", VA = "0xB19884")]
			set
			{
			}
		}

		[Token(Token = "0x1700015F")]
		public override bool IsConfigured
		{
			[Token(Token = "0x60007BC")]
			[Address(RVA = "0xB19898", Offset = "0xB19898", VA = "0xB19898", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000160")]
		public override bool IsInitialized
		{
			[Token(Token = "0x60007BD")]
			[Address(RVA = "0xB19940", Offset = "0xB19940", VA = "0xB19940", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000161")]
		public bool PathIsClosed
		{
			[Token(Token = "0x60007BE")]
			[Address(RVA = "0xB19A10", Offset = "0xB19A10", VA = "0xB19A10", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000162")]
		protected abstract CurvySpline InputSpline
		{
			[Token(Token = "0x60007CE")]
			get;
			[Token(Token = "0x60007CF")]
			set;
		}

		[Token(Token = "0x60007BF")]
		[Address(RVA = "0xB19B30", Offset = "0xB19B30", VA = "0xB19B30", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0xB19B78", Offset = "0xB19B78", VA = "0xB19B78", Slot = "6")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x60007C1")]
		[Address(RVA = "0xB19D10", Offset = "0xB19D10", VA = "0xB19D10", Slot = "11")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60007C2")]
		[Address(RVA = "0xB19D90", Offset = "0xB19D90", VA = "0xB19D90")]
		private void OnSplineRefreshed(CurvySplineEventArgs e)
		{
		}

		[Token(Token = "0x60007C3")]
		[Address(RVA = "0xB19EF0", Offset = "0xB19EF0", VA = "0xB19EF0")]
		private void OnInputSplineCoordinatesChanged(CurvySpline sender)
		{
		}

		[Token(Token = "0x60007C4")]
		[Address(RVA = "0xB19EE4", Offset = "0xB19EE4", VA = "0xB19EE4")]
		private void ForceRefresh()
		{
		}

		[Token(Token = "0x60007C5")]
		[Address(RVA = "0xB1A06C", Offset = "0xB1A06C", VA = "0xB1A06C")]
		private float getPathLength(CurvySpline spline)
		{
			return default(float);
		}

		[Token(Token = "0x60007C6")]
		[Address(RVA = "0xB19A68", Offset = "0xB19A68", VA = "0xB19A68")]
		private bool getPathClosed(CurvySpline spline)
		{
			return default(bool);
		}

		[Token(Token = "0x60007C7")]
		[Address(RVA = "0xB1A180", Offset = "0xB1A180", VA = "0xB1A180")]
		protected CGData GetSplineData(CurvySpline spline, bool fullPath, CGDataRequestRasterization raster, CGDataRequestMetaCGOptions options)
		{
			return null;
		}

		[Token(Token = "0x60007C8")]
		[Address(RVA = "0xB1B894", Offset = "0xB1B894", VA = "0xB1B894")]
		private static void FillData(CGShape dataToFill, SamplePointsMaterialGroup materialGroup, List<float> sourceFs, List<float> relativeFs, bool isFullPath, List<Vector3> positions, List<Vector3> tangents, List<Vector3> normals, bool considerSplineTransform, Transform splineTransform, Transform generatorTransform)
		{
		}

		[Token(Token = "0x60007C9")]
		[Address(RVA = "0xB1B714", Offset = "0xB1B714", VA = "0xB1B714")]
		private static void AddPoint(float sourceF, float relativeF, bool isFullPath, Vector3 position, Vector3 tangent, Vector3 up, List<float> sourceFList, List<float> relativeFList, List<Vector3> positionList, List<Vector3> tangentList, List<Vector3> upList)
		{
		}

		[Token(Token = "0x60007CA")]
		[Address(RVA = "0xB1BB88", Offset = "0xB1BB88", VA = "0xB1BB88")]
		private static bool MoveByAngleExt(CurvySpline spline, bool useCache, ref float tf, float maxDistance, float maxAngle, out Vector3 pos, out Vector3 tan, float stopTF, bool loop, float stepDist)
		{
			return default(bool);
		}

		[Token(Token = "0x60007CB")]
		[Address(RVA = "0xB1BE78", Offset = "0xB1BE78", VA = "0xB1BE78")]
		private static void CalculateExtendedUV(CurvySpline spline, float startTF, float endTF, List<SamplePointUData> ext, CGShape data)
		{
		}

		[Token(Token = "0x60007CC")]
		[Address(RVA = "0xB1C660", Offset = "0xB1C660", VA = "0xB1C660")]
		private static MetaCGOptions findPreviousReferenceCPOptions(CurvySpline spline, float tf, out CurvySplineSegment cp)
		{
			return null;
		}

		[Token(Token = "0x60007CD")]
		[Address(RVA = "0xB1C7BC", Offset = "0xB1C7BC", VA = "0xB1C7BC")]
		private static MetaCGOptions findNextReferenceCPOptions(CurvySpline spline, float tf, out CurvySplineSegment cp)
		{
			return null;
		}

		[Token(Token = "0x60007D0")]
		[Address(RVA = "0xB1C958", Offset = "0xB1C958", VA = "0xB1C958", Slot = "17")]
		protected virtual void OnSplineAssigned()
		{
		}

		[Token(Token = "0x60007D1")]
		[Address(RVA = "0xB19558", Offset = "0xB19558", VA = "0xB19558")]
		protected void ValidateStartAndEndCps()
		{
		}

		[Token(Token = "0x60007D2")]
		[Address(RVA = "0xB1CAE4", Offset = "0xB1CAE4", VA = "0xB1CAE4")]
		protected SplineInputModuleBase()
		{
		}
	}
	[Token(Token = "0x20000C8")]
	public abstract class TRSModuleBase : CGModule
	{
		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		[SerializeField]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x86C474", Offset = "0x86C474")]
		private Vector3 m_Transpose;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x86C4DC", Offset = "0x86C4DC")]
		private Vector3 m_Rotation;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		[SerializeField]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x86C544", Offset = "0x86C544")]
		private Vector3 m_Scale;

		[Token(Token = "0x17000163")]
		public Vector3 Transpose
		{
			[Token(Token = "0x60007D3")]
			[Address(RVA = "0xB1D524", Offset = "0xB1D524", VA = "0xB1D524")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60007D4")]
			[Address(RVA = "0xB1D530", Offset = "0xB1D530", VA = "0xB1D530")]
			set
			{
			}
		}

		[Token(Token = "0x17000164")]
		public Vector3 Rotation
		{
			[Token(Token = "0x60007D5")]
			[Address(RVA = "0xB1D5F4", Offset = "0xB1D5F4", VA = "0xB1D5F4")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60007D6")]
			[Address(RVA = "0xB1D600", Offset = "0xB1D600", VA = "0xB1D600")]
			set
			{
			}
		}

		[Token(Token = "0x17000165")]
		public Vector3 Scale
		{
			[Token(Token = "0x60007D7")]
			[Address(RVA = "0xB1D6C4", Offset = "0xB1D6C4", VA = "0xB1D6C4")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60007D8")]
			[Address(RVA = "0xB1D6D0", Offset = "0xB1D6D0", VA = "0xB1D6D0")]
			set
			{
			}
		}

		[Token(Token = "0x17000166")]
		public Matrix4x4 Matrix
		{
			[Token(Token = "0x60007D9")]
			[Address(RVA = "0xB1D794", Offset = "0xB1D794", VA = "0xB1D794")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Token(Token = "0x60007DA")]
		[Address(RVA = "0xB1D8B4", Offset = "0xB1D8B4", VA = "0xB1D8B4", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x60007DB")]
		[Address(RVA = "0xB1D8FC", Offset = "0xB1D8FC", VA = "0xB1D8FC", Slot = "11")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60007DC")]
		[Address(RVA = "0xB1D994", Offset = "0xB1D994", VA = "0xB1D994")]
		protected TRSModuleBase()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000C9")]
	public class CGBoundsGroup : CGWeightedItem
	{
		[Token(Token = "0x2000191")]
		public enum RotationModeEnum
		{
			[Token(Token = "0x40006B2")]
			Full,
			[Token(Token = "0x40006B3")]
			Direction,
			[Token(Token = "0x40006B4")]
			Horizontal,
			[Token(Token = "0x40006B5")]
			Independent
		}

		[Token(Token = "0x2000192")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x867B14", Offset = "0x867B14")]
		private enum DistributionModeEnum
		{
			[Token(Token = "0x40006B7")]
			Parent,
			[Token(Token = "0x40006B8")]
			Self
		}

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string m_Name;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86C5BC", Offset = "0x86C5BC")]
		private bool m_KeepTogether;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		[FloatRegion]
		private FloatRegion m_SpaceBefore;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[FloatRegion]
		private FloatRegion m_SpaceAfter;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		[FloatRegion]
		private FloatRegion m_CrossBase;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86C704", Offset = "0x86C704")]
		private bool m_IgnoreModuleCrossBase;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86C750", Offset = "0x86C750")]
		private bool m_RandomizeItems;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[IntRegion]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86C79C", Offset = "0x86C79C")]
		private IntRegion m_RepeatingItems;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86C818", Offset = "0x86C818")]
		private bool m_RelativeTranslation;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[SerializeField]
		[FloatRegion]
		private FloatRegion m_TranslationX;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		[FloatRegion]
		private FloatRegion m_TranslationY;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[SerializeField]
		[FloatRegion]
		private FloatRegion m_TranslationZ;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86C948", Offset = "0x86C948")]
		private RotationModeEnum m_RotationMode;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[SerializeField]
		[FloatRegion]
		private FloatRegion m_RotationX;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		[FloatRegion]
		private FloatRegion m_RotationY;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		[SerializeField]
		[FloatRegion]
		private FloatRegion m_RotationZ;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86CA78", Offset = "0x86CA78")]
		private bool m_UniformScaling;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[SerializeField]
		[FloatRegion]
		private FloatRegion m_ScaleX;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[FloatRegion]
		private FloatRegion m_ScaleY;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[SerializeField]
		[FloatRegion]
		private FloatRegion m_ScaleZ;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private List<CGBoundsGroupItem> m_Items;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[HideInInspector]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x86CBB8", Offset = "0x86CBB8")]
		private DistributionModeEnum m_DistributionMode;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[SerializeField]
		[HideInInspector]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x86CC14", Offset = "0x86CC14")]
		[FloatRegion]
		private FloatRegion m_PositionOffset;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[SerializeField]
		[HideInInspector]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x86CCAC", Offset = "0x86CCAC")]
		[FloatRegion]
		private FloatRegion m_Height;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		[SerializeField]
		[HideInInspector]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x86CD2C", Offset = "0x86CD2C")]
		private CurvyRepeatingOrderEnum m_RepeatingOrder;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[SerializeField]
		[HideInInspector]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x86CD88", Offset = "0x86CD88")]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x86CD88", Offset = "0x86CD88")]
		private Vector3 m_RotationOffset;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		[SerializeField]
		[HideInInspector]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x86CE24", Offset = "0x86CE24")]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x86CE24", Offset = "0x86CE24")]
		private Vector3 m_RotationScatter;

		[Token(Token = "0x17000167")]
		public string Name
		{
			[Token(Token = "0x60007DD")]
			[Address(RVA = "0x13A9C90", Offset = "0x13A9C90", VA = "0x13A9C90")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007DE")]
			[Address(RVA = "0x13A9C98", Offset = "0x13A9C98", VA = "0x13A9C98")]
			set
			{
			}
		}

		[Token(Token = "0x17000168")]
		public bool KeepTogether
		{
			[Token(Token = "0x60007DF")]
			[Address(RVA = "0x13A9CCC", Offset = "0x13A9CCC", VA = "0x13A9CCC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007E0")]
			[Address(RVA = "0x13A9CD4", Offset = "0x13A9CD4", VA = "0x13A9CD4")]
			set
			{
			}
		}

		[Token(Token = "0x17000169")]
		public FloatRegion SpaceBefore
		{
			[Token(Token = "0x60007E1")]
			[Address(RVA = "0x13A9CF4", Offset = "0x13A9CF4", VA = "0x13A9CF4")]
			get
			{
				return default(FloatRegion);
			}
			[Token(Token = "0x60007E2")]
			[Address(RVA = "0x13A9D04", Offset = "0x13A9D04", VA = "0x13A9D04")]
			set
			{
			}
		}

		[Token(Token = "0x1700016A")]
		public FloatRegion SpaceAfter
		{
			[Token(Token = "0x60007E3")]
			[Address(RVA = "0x13A9D54", Offset = "0x13A9D54", VA = "0x13A9D54")]
			get
			{
				return default(FloatRegion);
			}
			[Token(Token = "0x60007E4")]
			[Address(RVA = "0x13A9D64", Offset = "0x13A9D64", VA = "0x13A9D64")]
			set
			{
			}
		}

		[Token(Token = "0x1700016B")]
		public bool RandomizeItems
		{
			[Token(Token = "0x60007E5")]
			[Address(RVA = "0x13A9DB4", Offset = "0x13A9DB4", VA = "0x13A9DB4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007E6")]
			[Address(RVA = "0x13A9DBC", Offset = "0x13A9DBC", VA = "0x13A9DBC")]
			set
			{
			}
		}

		[Token(Token = "0x1700016C")]
		public IntRegion RepeatingItems
		{
			[Token(Token = "0x60007E7")]
			[Address(RVA = "0x13A9DDC", Offset = "0x13A9DDC", VA = "0x13A9DDC")]
			get
			{
				return default(IntRegion);
			}
			[Token(Token = "0x60007E8")]
			[Address(RVA = "0x13A9DEC", Offset = "0x13A9DEC", VA = "0x13A9DEC")]
			set
			{
			}
		}

		[Token(Token = "0x1700016D")]
		public FloatRegion CrossBase
		{
			[Token(Token = "0x60007E9")]
			[Address(RVA = "0x13A9E3C", Offset = "0x13A9E3C", VA = "0x13A9E3C")]
			get
			{
				return default(FloatRegion);
			}
			[Token(Token = "0x60007EA")]
			[Address(RVA = "0x13A9E4C", Offset = "0x13A9E4C", VA = "0x13A9E4C")]
			set
			{
			}
		}

		[Token(Token = "0x1700016E")]
		public bool IgnoreModuleCrossBase
		{
			[Token(Token = "0x60007EB")]
			[Address(RVA = "0x13A9E9C", Offset = "0x13A9E9C", VA = "0x13A9E9C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007EC")]
			[Address(RVA = "0x13A9EA4", Offset = "0x13A9EA4", VA = "0x13A9EA4")]
			set
			{
			}
		}

		[Token(Token = "0x1700016F")]
		public RotationModeEnum RotationMode
		{
			[Token(Token = "0x60007ED")]
			[Address(RVA = "0x13A9EC4", Offset = "0x13A9EC4", VA = "0x13A9EC4")]
			get
			{
				return default(RotationModeEnum);
			}
			[Token(Token = "0x60007EE")]
			[Address(RVA = "0x13A9ECC", Offset = "0x13A9ECC", VA = "0x13A9ECC")]
			set
			{
			}
		}

		[Token(Token = "0x17000170")]
		public FloatRegion RotationX
		{
			[Token(Token = "0x60007EF")]
			[Address(RVA = "0x13A9EE0", Offset = "0x13A9EE0", VA = "0x13A9EE0")]
			get
			{
				return default(FloatRegion);
			}
			[Token(Token = "0x60007F0")]
			[Address(RVA = "0x13A96A8", Offset = "0x13A96A8", VA = "0x13A96A8")]
			set
			{
			}
		}

		[Token(Token = "0x17000171")]
		public FloatRegion RotationY
		{
			[Token(Token = "0x60007F1")]
			[Address(RVA = "0x13A9EF0", Offset = "0x13A9EF0", VA = "0x13A9EF0")]
			get
			{
				return default(FloatRegion);
			}
			[Token(Token = "0x60007F2")]
			[Address(RVA = "0x13A96F8", Offset = "0x13A96F8", VA = "0x13A96F8")]
			set
			{
			}
		}

		[Token(Token = "0x17000172")]
		public FloatRegion RotationZ
		{
			[Token(Token = "0x60007F3")]
			[Address(RVA = "0x13A9F00", Offset = "0x13A9F00", VA = "0x13A9F00")]
			get
			{
				return default(FloatRegion);
			}
			[Token(Token = "0x60007F4")]
			[Address(RVA = "0x13A9748", Offset = "0x13A9748", VA = "0x13A9748")]
			set
			{
			}
		}

		[Token(Token = "0x17000173")]
		public bool UniformScaling
		{
			[Token(Token = "0x60007F5")]
			[Address(RVA = "0x13A9F10", Offset = "0x13A9F10", VA = "0x13A9F10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007F6")]
			[Address(RVA = "0x13A9798", Offset = "0x13A9798", VA = "0x13A9798")]
			set
			{
			}
		}

		[Token(Token = "0x17000174")]
		public FloatRegion ScaleX
		{
			[Token(Token = "0x60007F7")]
			[Address(RVA = "0x13A9F18", Offset = "0x13A9F18", VA = "0x13A9F18")]
			get
			{
				return default(FloatRegion);
			}
			[Token(Token = "0x60007F8")]
			[Address(RVA = "0x13A97B8", Offset = "0x13A97B8", VA = "0x13A97B8")]
			set
			{
			}
		}

		[Token(Token = "0x17000175")]
		public FloatRegion ScaleY
		{
			[Token(Token = "0x60007F9")]
			[Address(RVA = "0x13A9F28", Offset = "0x13A9F28", VA = "0x13A9F28")]
			get
			{
				return default(FloatRegion);
			}
			[Token(Token = "0x60007FA")]
			[Address(RVA = "0x13A9808", Offset = "0x13A9808", VA = "0x13A9808")]
			set
			{
			}
		}

		[Token(Token = "0x17000176")]
		public FloatRegion ScaleZ
		{
			[Token(Token = "0x60007FB")]
			[Address(RVA = "0x13A9F38", Offset = "0x13A9F38", VA = "0x13A9F38")]
			get
			{
				return default(FloatRegion);
			}
			[Token(Token = "0x60007FC")]
			[Address(RVA = "0x13A9858", Offset = "0x13A9858", VA = "0x13A9858")]
			set
			{
			}
		}

		[Token(Token = "0x17000177")]
		public bool RelativeTranslation
		{
			[Token(Token = "0x60007FD")]
			[Address(RVA = "0x13A9F48", Offset = "0x13A9F48", VA = "0x13A9F48")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007FE")]
			[Address(RVA = "0x13A9598", Offset = "0x13A9598", VA = "0x13A9598")]
			set
			{
			}
		}

		[Token(Token = "0x17000178")]
		public FloatRegion TranslationX
		{
			[Token(Token = "0x60007FF")]
			[Address(RVA = "0x13A9F50", Offset = "0x13A9F50", VA = "0x13A9F50")]
			get
			{
				return default(FloatRegion);
			}
			[Token(Token = "0x6000800")]
			[Address(RVA = "0x13A95B8", Offset = "0x13A95B8", VA = "0x13A95B8")]
			set
			{
			}
		}

		[Token(Token = "0x17000179")]
		public FloatRegion TranslationY
		{
			[Token(Token = "0x6000801")]
			[Address(RVA = "0x13A9F60", Offset = "0x13A9F60", VA = "0x13A9F60")]
			get
			{
				return default(FloatRegion);
			}
			[Token(Token = "0x6000802")]
			[Address(RVA = "0x13A9608", Offset = "0x13A9608", VA = "0x13A9608")]
			set
			{
			}
		}

		[Token(Token = "0x1700017A")]
		public FloatRegion TranslationZ
		{
			[Token(Token = "0x6000803")]
			[Address(RVA = "0x13A9F70", Offset = "0x13A9F70", VA = "0x13A9F70")]
			get
			{
				return default(FloatRegion);
			}
			[Token(Token = "0x6000804")]
			[Address(RVA = "0x13A9658", Offset = "0x13A9658", VA = "0x13A9658")]
			set
			{
			}
		}

		[Token(Token = "0x1700017B")]
		public List<CGBoundsGroupItem> Items
		{
			[Token(Token = "0x6000805")]
			[Address(RVA = "0x13A9F80", Offset = "0x13A9F80", VA = "0x13A9F80")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700017C")]
		public int FirstRepeating
		{
			[Token(Token = "0x6000806")]
			[Address(RVA = "0x13A8520", Offset = "0x13A8520", VA = "0x13A8520")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000807")]
			[Address(RVA = "0x13A9F88", Offset = "0x13A9F88", VA = "0x13A9F88")]
			set
			{
			}
		}

		[Token(Token = "0x1700017D")]
		public int LastRepeating
		{
			[Token(Token = "0x6000808")]
			[Address(RVA = "0x13A8528", Offset = "0x13A8528", VA = "0x13A8528")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000809")]
			[Address(RVA = "0x13AA038", Offset = "0x13AA038", VA = "0x13AA038")]
			set
			{
			}
		}

		[Token(Token = "0x1700017E")]
		public int ItemCount
		{
			[Token(Token = "0x600080A")]
			[Address(RVA = "0x13A7790", Offset = "0x13A7790", VA = "0x13A7790")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700017F")]
		private RegionOptions<int> RepeatingGroupsOptions
		{
			[Token(Token = "0x600080D")]
			[Address(RVA = "0x13AA0EC", Offset = "0x13AA0EC", VA = "0x13AA0EC")]
			get
			{
				return default(RegionOptions<int>);
			}
		}

		[Token(Token = "0x17000180")]
		private RegionOptions<float> PositionRangeOptions
		{
			[Token(Token = "0x600080E")]
			[Address(RVA = "0x13AA190", Offset = "0x13AA190", VA = "0x13AA190")]
			get
			{
				return default(RegionOptions<float>);
			}
		}

		[Token(Token = "0x600080B")]
		[Address(RVA = "0x13A81FC", Offset = "0x13A81FC", VA = "0x13A81FC")]
		public CGBoundsGroup(string name)
		{
		}

		[Token(Token = "0x600080C")]
		[Address(RVA = "0x13A9120", Offset = "0x13A9120", VA = "0x13A9120")]
		public static void FillItemBag(WeightedRandom<int> bag, IEnumerable<CGWeightedItem> itemsWeights, int firstItem, int lastItem)
		{
		}

		[Token(Token = "0x600080F")]
		[Address(RVA = "0x13A98A8", Offset = "0x13A98A8", VA = "0x13A98A8")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x8773A0", Offset = "0x8773A0")]
		public void ConvertObsoleteData()
		{
		}
	}
	[Token(Token = "0x20000CA")]
	public enum CGYesNoAuto
	{
		[Token(Token = "0x400032A")]
		Yes,
		[Token(Token = "0x400032B")]
		No,
		[Token(Token = "0x400032C")]
		Auto
	}
	[Token(Token = "0x20000CB")]
	public enum CGReferenceMode
	{
		[Token(Token = "0x400032E")]
		Source,
		[Token(Token = "0x400032F")]
		Self
	}
	[Token(Token = "0x20000CC")]
	public enum CGKeepAspectMode
	{
		[Token(Token = "0x4000331")]
		Off,
		[Token(Token = "0x4000332")]
		ScaleU,
		[Token(Token = "0x4000333")]
		ScaleV
	}
	[Token(Token = "0x20000CD")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x866630", Offset = "0x866630")]
	public enum CGUVEnum
	{
		[Token(Token = "0x4000335")]
		U,
		[Token(Token = "0x4000336")]
		V
	}
	[Token(Token = "0x20000CE")]
	public enum CGColliderEnum
	{
		[Token(Token = "0x4000338")]
		None,
		[Token(Token = "0x4000339")]
		Mesh,
		[Token(Token = "0x400033A")]
		Box,
		[Token(Token = "0x400033B")]
		Sphere,
		[Token(Token = "0x400033C")]
		Capsule
	}
	[Serializable]
	[Token(Token = "0x20000CF")]
	public struct CGSpot : IEquatable<CGSpot>
	{
		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x86CEC0", Offset = "0x86CEC0")]
		private int m_Index;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[SerializeField]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x86CF20", Offset = "0x86CF20")]
		private Vector3 m_Position;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x86CF90", Offset = "0x86CF90")]
		private Quaternion m_Rotation;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x86D000", Offset = "0x86D000")]
		private Vector3 m_Scale;

		[Token(Token = "0x17000181")]
		public int Index
		{
			[Token(Token = "0x6000810")]
			[Address(RVA = "0x9C1EE8", Offset = "0x9C1EE8", VA = "0x9C1EE8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000182")]
		public Vector3 Position
		{
			[Token(Token = "0x6000811")]
			[Address(RVA = "0x9C1EF0", Offset = "0x9C1EF0", VA = "0x9C1EF0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000812")]
			[Address(RVA = "0x9C1EFC", Offset = "0x9C1EFC", VA = "0x9C1EFC")]
			set
			{
			}
		}

		[Token(Token = "0x17000183")]
		public Quaternion Rotation
		{
			[Token(Token = "0x6000813")]
			[Address(RVA = "0x9C1F04", Offset = "0x9C1F04", VA = "0x9C1F04")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x6000814")]
			[Address(RVA = "0x9C1F10", Offset = "0x9C1F10", VA = "0x9C1F10")]
			set
			{
			}
		}

		[Token(Token = "0x17000184")]
		public Vector3 Scale
		{
			[Token(Token = "0x6000815")]
			[Address(RVA = "0x9C1F18", Offset = "0x9C1F18", VA = "0x9C1F18")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000816")]
			[Address(RVA = "0x9C1F24", Offset = "0x9C1F24", VA = "0x9C1F24")]
			set
			{
			}
		}

		[Token(Token = "0x17000185")]
		public Matrix4x4 Matrix
		{
			[Token(Token = "0x6000817")]
			[Address(RVA = "0x9C1F2C", Offset = "0x9C1F2C", VA = "0x9C1F2C")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Token(Token = "0x6000818")]
		[Address(RVA = "0x9C1F34", Offset = "0x9C1F34", VA = "0x9C1F34")]
		public CGSpot(int index)
		{
		}

		[Token(Token = "0x6000819")]
		[Address(RVA = "0x9C1F3C", Offset = "0x9C1F3C", VA = "0x9C1F3C")]
		public CGSpot(int index, Vector3 position, Quaternion rotation, Vector3 scale)
		{
		}

		[Token(Token = "0x600081A")]
		[Address(RVA = "0x9C1F64", Offset = "0x9C1F64", VA = "0x9C1F64")]
		public void ToTransform(Transform transform)
		{
		}

		[Token(Token = "0x600081B")]
		[Address(RVA = "0x9C1F6C", Offset = "0x9C1F6C", VA = "0x9C1F6C", Slot = "4")]
		public bool Equals(CGSpot other)
		{
			return default(bool);
		}

		[Token(Token = "0x600081C")]
		[Address(RVA = "0x9C1FA4", Offset = "0x9C1FA4", VA = "0x9C1FA4", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600081D")]
		[Address(RVA = "0x9C1FAC", Offset = "0x9C1FAC", VA = "0x9C1FAC", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600081E")]
		[Address(RVA = "0x109D918", Offset = "0x109D918", VA = "0x109D918")]
		public static bool operator ==(CGSpot left, CGSpot right)
		{
			return default(bool);
		}

		[Token(Token = "0x600081F")]
		[Address(RVA = "0x109D94C", Offset = "0x109D94C", VA = "0x109D94C")]
		public static bool operator !=(CGSpot left, CGSpot right)
		{
			return default(bool);
		}
	}
	[Serializable]
	[Token(Token = "0x20000D0")]
	public class CGMaterialSettings
	{
		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool SwapUV;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public CGKeepAspectMode KeepAspect;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float UVRotation;

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector2 UVOffset;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector2 UVScale;

		[Token(Token = "0x6000820")]
		[Address(RVA = "0x13A2768", Offset = "0x13A2768", VA = "0x13A2768")]
		public CGMaterialSettings()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000D1")]
	public class CGMaterialSettingsEx : CGMaterialSettings
	{
		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int MaterialID;

		[Token(Token = "0x6000821")]
		[Address(RVA = "0x13A4130", Offset = "0x13A4130", VA = "0x13A4130")]
		public CGMaterialSettingsEx()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000D2")]
	public class CGMeshProperties
	{
		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Mesh m_Mesh;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Material[] m_Material;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x86D090", Offset = "0x86D090")]
		private Vector3 m_Translation;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x86D0F8", Offset = "0x86D0F8")]
		private Vector3 m_Rotation;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x86D160", Offset = "0x86D160")]
		private Vector3 m_Scale;

		[Token(Token = "0x17000186")]
		public Mesh Mesh
		{
			[Token(Token = "0x6000822")]
			[Address(RVA = "0x13AC0B8", Offset = "0x13AC0B8", VA = "0x13AC0B8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000823")]
			[Address(RVA = "0x13AC0C0", Offset = "0x13AC0C0", VA = "0x13AC0C0")]
			set
			{
			}
		}

		[Token(Token = "0x17000187")]
		public Material[] Material
		{
			[Token(Token = "0x6000824")]
			[Address(RVA = "0x13AC1D8", Offset = "0x13AC1D8", VA = "0x13AC1D8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000825")]
			[Address(RVA = "0x13AC1E0", Offset = "0x13AC1E0", VA = "0x13AC1E0")]
			set
			{
			}
		}

		[Token(Token = "0x17000188")]
		public Vector3 Translation
		{
			[Token(Token = "0x6000826")]
			[Address(RVA = "0x13AC1F4", Offset = "0x13AC1F4", VA = "0x13AC1F4")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000827")]
			[Address(RVA = "0x13AC200", Offset = "0x13AC200", VA = "0x13AC200")]
			set
			{
			}
		}

		[Token(Token = "0x17000189")]
		public Vector3 Rotation
		{
			[Token(Token = "0x6000828")]
			[Address(RVA = "0x13AC2B8", Offset = "0x13AC2B8", VA = "0x13AC2B8")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000829")]
			[Address(RVA = "0x13AC2C4", Offset = "0x13AC2C4", VA = "0x13AC2C4")]
			set
			{
			}
		}

		[Token(Token = "0x1700018A")]
		public Vector3 Scale
		{
			[Token(Token = "0x600082A")]
			[Address(RVA = "0x13AC37C", Offset = "0x13AC37C", VA = "0x13AC37C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600082B")]
			[Address(RVA = "0x13AC388", Offset = "0x13AC388", VA = "0x13AC388")]
			set
			{
			}
		}

		[Token(Token = "0x1700018B")]
		public Matrix4x4 Matrix
		{
			[Token(Token = "0x600082C")]
			[Address(RVA = "0x13AC440", Offset = "0x13AC440", VA = "0x13AC440")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Token(Token = "0x600082D")]
		[Address(RVA = "0x13AC560", Offset = "0x13AC560", VA = "0x13AC560")]
		public CGMeshProperties()
		{
		}

		[Token(Token = "0x600082E")]
		[Address(RVA = "0x13AC5F0", Offset = "0x13AC5F0", VA = "0x13AC5F0")]
		public CGMeshProperties(Mesh mesh)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000D3")]
	public class CGGameObjectProperties
	{
		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameObject m_Object;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x86D1D8", Offset = "0x86D1D8")]
		private Vector3 m_Translation;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x86D240", Offset = "0x86D240")]
		private Vector3 m_Rotation;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x86D2A8", Offset = "0x86D2A8")]
		private Vector3 m_Scale;

		[Token(Token = "0x1700018C")]
		public GameObject Object
		{
			[Token(Token = "0x600082F")]
			[Address(RVA = "0x13AB6EC", Offset = "0x13AB6EC", VA = "0x13AB6EC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000830")]
			[Address(RVA = "0x13AB6F4", Offset = "0x13AB6F4", VA = "0x13AB6F4")]
			set
			{
			}
		}

		[Token(Token = "0x1700018D")]
		public Vector3 Translation
		{
			[Token(Token = "0x6000831")]
			[Address(RVA = "0x13AB77C", Offset = "0x13AB77C", VA = "0x13AB77C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000832")]
			[Address(RVA = "0x13AB788", Offset = "0x13AB788", VA = "0x13AB788")]
			set
			{
			}
		}

		[Token(Token = "0x1700018E")]
		public Vector3 Rotation
		{
			[Token(Token = "0x6000833")]
			[Address(RVA = "0x13AB840", Offset = "0x13AB840", VA = "0x13AB840")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000834")]
			[Address(RVA = "0x13AB84C", Offset = "0x13AB84C", VA = "0x13AB84C")]
			set
			{
			}
		}

		[Token(Token = "0x1700018F")]
		public Vector3 Scale
		{
			[Token(Token = "0x6000835")]
			[Address(RVA = "0x13AB904", Offset = "0x13AB904", VA = "0x13AB904")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000836")]
			[Address(RVA = "0x13AB910", Offset = "0x13AB910", VA = "0x13AB910")]
			set
			{
			}
		}

		[Token(Token = "0x17000190")]
		public Matrix4x4 Matrix
		{
			[Token(Token = "0x6000837")]
			[Address(RVA = "0x13AB9C8", Offset = "0x13AB9C8", VA = "0x13AB9C8")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Token(Token = "0x6000838")]
		[Address(RVA = "0x13ABAE8", Offset = "0x13ABAE8", VA = "0x13ABAE8")]
		public CGGameObjectProperties()
		{
		}

		[Token(Token = "0x6000839")]
		[Address(RVA = "0x13ABB60", Offset = "0x13ABB60", VA = "0x13ABB60")]
		public CGGameObjectProperties(GameObject gameObject)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000D4")]
	public class CGWeightedItem
	{
		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x86D310", Offset = "0x86D310")]
		[SerializeField]
		private float m_Weight;

		[Token(Token = "0x17000191")]
		public float Weight
		{
			[Token(Token = "0x600083A")]
			[Address(RVA = "0x10A2154", Offset = "0x10A2154", VA = "0x10A2154")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600083B")]
			[Address(RVA = "0x10A215C", Offset = "0x10A215C", VA = "0x10A215C")]
			set
			{
			}
		}

		[Token(Token = "0x600083C")]
		[Address(RVA = "0x10A21E4", Offset = "0x10A21E4", VA = "0x10A21E4")]
		public CGWeightedItem()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000D5")]
	public class CGBoundsGroupItem : CGWeightedItem
	{
		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int Index;

		[Token(Token = "0x600083D")]
		[Address(RVA = "0x13A84A4", Offset = "0x13A84A4", VA = "0x13A84A4")]
		public CGBoundsGroupItem()
		{
		}
	}
	[Token(Token = "0x20000D6")]
	public struct ControlPointOption : IEquatable<ControlPointOption>
	{
		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float TF;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float Distance;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public bool Include;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int MaterialID;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool HardEdge;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float MaxStepDistance;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool UVEdge;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool UVShift;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float FirstU;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float SecondU;

		[Token(Token = "0x600083E")]
		[Address(RVA = "0x9C21DC", Offset = "0x9C21DC", VA = "0x9C21DC")]
		public ControlPointOption(float tf, float dist, bool includeAnyways, int materialID, bool hardEdge, float maxStepDistance, bool uvEdge, bool uvShift, float firstU, float secondU)
		{
		}

		[Token(Token = "0x600083F")]
		[Address(RVA = "0x9C2220", Offset = "0x9C2220", VA = "0x9C2220", Slot = "4")]
		public bool Equals(ControlPointOption other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000840")]
		[Address(RVA = "0x9C2258", Offset = "0x9C2258", VA = "0x9C2258", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000841")]
		[Address(RVA = "0x9C2260", Offset = "0x9C2260", VA = "0x9C2260", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000842")]
		[Address(RVA = "0x10A8684", Offset = "0x10A8684", VA = "0x10A8684")]
		public static bool operator ==(ControlPointOption left, ControlPointOption right)
		{
			return default(bool);
		}

		[Token(Token = "0x6000843")]
		[Address(RVA = "0x10A86B8", Offset = "0x10A86B8", VA = "0x10A86B8")]
		public static bool operator !=(ControlPointOption left, ControlPointOption right)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000D7")]
	public struct SamplePointsPatch : IEquatable<SamplePointsPatch>
	{
		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int Start;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int Count;

		[Token(Token = "0x17000192")]
		public int End
		{
			[Token(Token = "0x6000844")]
			[Address(RVA = "0x9ADD34", Offset = "0x9ADD34", VA = "0x9ADD34")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000845")]
			[Address(RVA = "0x9ADD40", Offset = "0x9ADD40", VA = "0x9ADD40")]
			set
			{
			}
		}

		[Token(Token = "0x17000193")]
		public int TriangleCount
		{
			[Token(Token = "0x6000846")]
			[Address(RVA = "0x9ADD48", Offset = "0x9ADD48", VA = "0x9ADD48")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000847")]
		[Address(RVA = "0x9ADD54", Offset = "0x9ADD54", VA = "0x9ADD54")]
		public SamplePointsPatch(int start)
		{
		}

		[Token(Token = "0x6000848")]
		[Address(RVA = "0x9ADD5C", Offset = "0x9ADD5C", VA = "0x9ADD5C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000849")]
		[Address(RVA = "0x9ADD64", Offset = "0x9ADD64", VA = "0x9ADD64", Slot = "4")]
		public bool Equals(SamplePointsPatch other)
		{
			return default(bool);
		}

		[Token(Token = "0x600084A")]
		[Address(RVA = "0x9ADD8C", Offset = "0x9ADD8C", VA = "0x9ADD8C", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600084B")]
		[Address(RVA = "0x9ADD94", Offset = "0x9ADD94", VA = "0x9ADD94", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600084C")]
		[Address(RVA = "0xB14A2C", Offset = "0xB14A2C", VA = "0xB14A2C")]
		public static bool operator ==(SamplePointsPatch left, SamplePointsPatch right)
		{
			return default(bool);
		}

		[Token(Token = "0x600084D")]
		[Address(RVA = "0xB14A4C", Offset = "0xB14A4C", VA = "0xB14A4C")]
		public static bool operator !=(SamplePointsPatch left, SamplePointsPatch right)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000D8")]
	public class SamplePointsMaterialGroup
	{
		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int MaterialID;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<SamplePointsPatch> Patches;

		[Token(Token = "0x17000194")]
		public int TriangleCount
		{
			[Token(Token = "0x600084E")]
			[Address(RVA = "0xB13F08", Offset = "0xB13F08", VA = "0xB13F08")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000195")]
		public int StartVertex
		{
			[Token(Token = "0x600084F")]
			[Address(RVA = "0xB13FC0", Offset = "0xB13FC0", VA = "0xB13FC0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000196")]
		public int EndVertex
		{
			[Token(Token = "0x6000850")]
			[Address(RVA = "0xB14024", Offset = "0xB14024", VA = "0xB14024")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000197")]
		public int VertexCount
		{
			[Token(Token = "0x6000851")]
			[Address(RVA = "0xB140A0", Offset = "0xB140A0", VA = "0xB140A0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000852")]
		[Address(RVA = "0xB140D4", Offset = "0xB140D4", VA = "0xB140D4")]
		public SamplePointsMaterialGroup(int materialID)
		{
		}

		[Token(Token = "0x6000853")]
		[Address(RVA = "0xB14158", Offset = "0xB14158", VA = "0xB14158")]
		public void GetLengths(CGVolume volume, out float worldLength, out float uLength)
		{
		}

		[Token(Token = "0x6000854")]
		[Address(RVA = "0xB14314", Offset = "0xB14314", VA = "0xB14314")]
		public SamplePointsMaterialGroup Clone()
		{
			return null;
		}
	}
	[Token(Token = "0x20000D9")]
	public struct SamplePointUData : IEquatable<SamplePointUData>
	{
		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int Vertex;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public bool UVEdge;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float FirstU;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float SecondU;

		[Token(Token = "0x6000855")]
		[Address(RVA = "0x9B4854", Offset = "0x9B4854", VA = "0x9B4854")]
		public SamplePointUData(int vt, bool uvEdge, float uv0, float uv1)
		{
		}

		[Token(Token = "0x6000856")]
		[Address(RVA = "0x9B4868", Offset = "0x9B4868", VA = "0x9B4868", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000857")]
		[Address(RVA = "0x9B4870", Offset = "0x9B4870", VA = "0x9B4870", Slot = "4")]
		public bool Equals(SamplePointUData other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000858")]
		[Address(RVA = "0x9B4878", Offset = "0x9B4878", VA = "0x9B4878", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000859")]
		[Address(RVA = "0x9B4880", Offset = "0x9B4880", VA = "0x9B4880", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600085A")]
		[Address(RVA = "0xDFD750", Offset = "0xDFD750", VA = "0xDFD750")]
		public static bool operator ==(SamplePointUData left, SamplePointUData right)
		{
			return default(bool);
		}

		[Token(Token = "0x600085B")]
		[Address(RVA = "0xDFD780", Offset = "0xDFD780", VA = "0xDFD780")]
		public static bool operator !=(SamplePointUData left, SamplePointUData right)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000DA")]
	public class SamplePointsMaterialGroupCollection : List<SamplePointsMaterialGroup>
	{
		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int MaterialID;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float AspectCorrection;

		[Token(Token = "0x17000198")]
		public int TriangleCount
		{
			[Token(Token = "0x600085C")]
			[Address(RVA = "0xB143B8", Offset = "0xB143B8", VA = "0xB143B8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600085D")]
		[Address(RVA = "0xB1445C", Offset = "0xB1445C", VA = "0xB1445C")]
		public SamplePointsMaterialGroupCollection()
		{
		}

		[Token(Token = "0x600085E")]
		[Address(RVA = "0xB144D4", Offset = "0xB144D4", VA = "0xB144D4")]
		public SamplePointsMaterialGroupCollection(int capacity)
		{
		}

		[Token(Token = "0x600085F")]
		[Address(RVA = "0xB1455C", Offset = "0xB1455C", VA = "0xB1455C")]
		public SamplePointsMaterialGroupCollection(IEnumerable<SamplePointsMaterialGroup> collection)
		{
		}

		[Token(Token = "0x6000860")]
		[Address(RVA = "0xB145E4", Offset = "0xB145E4", VA = "0xB145E4")]
		public void CalculateAspectCorrection(CGVolume volume, CGMaterialSettingsEx matSettings)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000DB")]
	public class CGDataReference
	{
		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private CGModule m_Module;

		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string m_SlotName;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private CGModuleOutputSlot mSlot;

		[Token(Token = "0x17000199")]
		public CGData[] Data
		{
			[Token(Token = "0x6000861")]
			[Address(RVA = "0x13AA428", Offset = "0x13AA428", VA = "0x13AA428")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700019A")]
		public CGModuleOutputSlot Slot
		{
			[Token(Token = "0x6000862")]
			[Address(RVA = "0x13AA4A0", Offset = "0x13AA4A0", VA = "0x13AA4A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700019B")]
		public bool HasValue
		{
			[Token(Token = "0x6000863")]
			[Address(RVA = "0x13AA6A4", Offset = "0x13AA6A4", VA = "0x13AA6A4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700019C")]
		public bool IsEmpty
		{
			[Token(Token = "0x6000864")]
			[Address(RVA = "0x13AA6D4", Offset = "0x13AA6D4", VA = "0x13AA6D4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700019D")]
		public CGModule Module
		{
			[Token(Token = "0x6000865")]
			[Address(RVA = "0x13AA6E0", Offset = "0x13AA6E0", VA = "0x13AA6E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700019E")]
		public string SlotName
		{
			[Token(Token = "0x6000866")]
			[Address(RVA = "0x13AA6E8", Offset = "0x13AA6E8", VA = "0x13AA6E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000867")]
		[Address(RVA = "0x13AA6F0", Offset = "0x13AA6F0", VA = "0x13AA6F0")]
		public CGDataReference()
		{
		}

		[Token(Token = "0x6000868")]
		[Address(RVA = "0x13AA6F8", Offset = "0x13AA6F8", VA = "0x13AA6F8")]
		public CGDataReference(CGModule module, string slotName)
		{
		}

		[Token(Token = "0x6000869")]
		[Address(RVA = "0x13AA740", Offset = "0x13AA740", VA = "0x13AA740")]
		public CGDataReference(CurvyGenerator generator, string moduleName, string slotName)
		{
		}

		[Token(Token = "0x600086A")]
		[Address(RVA = "0x13AA7CC", Offset = "0x13AA7CC", VA = "0x13AA7CC")]
		public void Clear()
		{
		}

		[Token(Token = "0x600086B")]
		public T GetData<T>() where T : CGData
		{
			return null;
		}

		[Token(Token = "0x600086C")]
		public T[] GetAllData<T>() where T : CGData
		{
			return null;
		}

		[Token(Token = "0x600086D")]
		[Address(RVA = "0x13AA734", Offset = "0x13AA734", VA = "0x13AA734")]
		public void setINTERNAL(CGModule module, string slotName)
		{
		}

		[Token(Token = "0x600086E")]
		[Address(RVA = "0x13AA788", Offset = "0x13AA788", VA = "0x13AA788")]
		public void setINTERNAL(CurvyGenerator generator, string moduleName, string slotName)
		{
		}
	}
	[Token(Token = "0x20000DC")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x866640", Offset = "0x866640")]
	public sealed class CGDataInfoAttribute : Attribute
	{
		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly Color Color;

		[Token(Token = "0x600086F")]
		[Address(RVA = "0x13AA32C", Offset = "0x13AA32C", VA = "0x13AA32C")]
		public CGDataInfoAttribute(Color color)
		{
		}

		[Token(Token = "0x6000870")]
		[Address(RVA = "0x13AA378", Offset = "0x13AA378", VA = "0x13AA378")]
		public CGDataInfoAttribute(float r, float g, float b, float a = 1f)
		{
		}

		[Token(Token = "0x6000871")]
		[Address(RVA = "0x13AA3EC", Offset = "0x13AA3EC", VA = "0x13AA3EC")]
		public CGDataInfoAttribute(string htmlColor)
		{
		}
	}
	[Token(Token = "0x20000DD")]
	public class CGData
	{
		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Name;

		[Token(Token = "0x1700019F")]
		public virtual int Count
		{
			[Token(Token = "0x6000872")]
			[Address(RVA = "0x13AA1E8", Offset = "0x13AA1E8", VA = "0x13AA1E8", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000873")]
		[Address(RVA = "0x13A1FB8", Offset = "0x13A1FB8", VA = "0x13A1FB8")]
		public static implicit operator bool(CGData a)
		{
			return default(bool);
		}

		[Token(Token = "0x6000874")]
		public virtual T Clone<T>() where T : CGData
		{
			return null;
		}

		[Token(Token = "0x6000875")]
		[Address(RVA = "0x13AA1F0", Offset = "0x13AA1F0", VA = "0x13AA1F0")]
		protected int getGenericFIndex(ref float[] FMapArray, float fValue, out float frag)
		{
			return default(int);
		}

		[Token(Token = "0x6000876")]
		[Address(RVA = "0x13A9B84", Offset = "0x13A9B84", VA = "0x13A9B84")]
		public CGData()
		{
		}
	}
	[Token(Token = "0x20000DE")]
	[AttributeAttribute(Name = "CGDataInfoAttribute", RVA = "0x866654", Offset = "0x866654")]
	public class CGShape : CGData
	{
		[Serializable]
		[Token(Token = "0x2000193")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x867B4C", Offset = "0x867B4C")]
		private sealed class <>c
		{
			[Token(Token = "0x40006B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40006BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<SamplePointsMaterialGroup, SamplePointsMaterialGroup> <>9__16_0;

			[Token(Token = "0x40006BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<SamplePointsMaterialGroup, SamplePointsMaterialGroup> <>9__18_0;

			[Token(Token = "0x6000D75")]
			[Address(RVA = "0x1815F88", Offset = "0x1815F88", VA = "0x1815F88")]
			public <>c()
			{
			}

			[Token(Token = "0x6000D76")]
			[Address(RVA = "0x1815F90", Offset = "0x1815F90", VA = "0x1815F90")]
			internal SamplePointsMaterialGroup <.ctor>b__16_0(SamplePointsMaterialGroup g)
			{
				return null;
			}

			[Token(Token = "0x6000D77")]
			[Address(RVA = "0x1815FAC", Offset = "0x1815FAC", VA = "0x1815FAC")]
			internal SamplePointsMaterialGroup <Copy>b__18_0(SamplePointsMaterialGroup g)
			{
				return null;
			}
		}

		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float[] SourceF;

		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float[] F;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3[] Position;

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3[] Normal;

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float[] Map;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public List<SamplePointsMaterialGroup> MaterialGroups;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool SourceIsManaged;

		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		public bool Closed;

		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
		public bool Seamless;

		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float Length;

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float mCacheLastF;

		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int mCacheLastIndex;

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float mCacheLastFrag;

		[Token(Token = "0x170001A0")]
		public override int Count
		{
			[Token(Token = "0x6000877")]
			[Address(RVA = "0x109C178", Offset = "0x109C178", VA = "0x109C178", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000878")]
		[Address(RVA = "0x109ACDC", Offset = "0x109ACDC", VA = "0x109ACDC")]
		public CGShape()
		{
		}

		[Token(Token = "0x6000879")]
		[Address(RVA = "0x109AE6C", Offset = "0x109AE6C", VA = "0x109AE6C")]
		public CGShape(CGShape source)
		{
		}

		[Token(Token = "0x600087A")]
		public override T Clone<T>()
		{
			return null;
		}

		[Token(Token = "0x600087B")]
		[Address(RVA = "0x109B1C8", Offset = "0x109B1C8", VA = "0x109B1C8")]
		public static void Copy(CGShape dest, CGShape source)
		{
		}

		[Token(Token = "0x600087C")]
		[Address(RVA = "0x109C194", Offset = "0x109C194", VA = "0x109C194")]
		public void Copy(CGShape source)
		{
		}

		[Token(Token = "0x600087D")]
		[Address(RVA = "0x109C198", Offset = "0x109C198", VA = "0x109C198")]
		public float DistanceToF(float distance)
		{
			return default(float);
		}

		[Token(Token = "0x600087E")]
		[Address(RVA = "0x109C224", Offset = "0x109C224", VA = "0x109C224")]
		public float FToDistance(float f)
		{
			return default(float);
		}

		[Token(Token = "0x600087F")]
		[Address(RVA = "0x109B614", Offset = "0x109B614", VA = "0x109B614")]
		public int GetFIndex(float f, out float frag)
		{
			return default(int);
		}

		[Token(Token = "0x6000880")]
		[Address(RVA = "0x109C2A4", Offset = "0x109C2A4", VA = "0x109C2A4")]
		public Vector3 InterpolatePosition(float f)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000881")]
		[Address(RVA = "0x109C350", Offset = "0x109C350", VA = "0x109C350")]
		public Vector3 InterpolateUp(float f)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000882")]
		[Address(RVA = "0x109C484", Offset = "0x109C484", VA = "0x109C484")]
		public void Interpolate(float f, out Vector3 position, out Vector3 up)
		{
		}

		[Token(Token = "0x6000883")]
		[Address(RVA = "0x109C638", Offset = "0x109C638", VA = "0x109C638")]
		public void Move(ref float f, ref int direction, float speed, CurvyClamping clamping)
		{
		}

		[Token(Token = "0x6000884")]
		[Address(RVA = "0x109C67C", Offset = "0x109C67C", VA = "0x109C67C")]
		public void MoveBy(ref float f, ref int direction, float speedDist, CurvyClamping clamping)
		{
		}

		[Token(Token = "0x6000885")]
		[Address(RVA = "0x109C6F0", Offset = "0x109C6F0", VA = "0x109C6F0", Slot = "6")]
		public virtual void Recalculate()
		{
		}

		[Token(Token = "0x6000886")]
		[Address(RVA = "0x109C9D0", Offset = "0x109C9D0", VA = "0x109C9D0")]
		public void RecalculateNormals(List<int> softEdges)
		{
		}
	}
	[Token(Token = "0x20000DF")]
	[AttributeAttribute(Name = "CGDataInfoAttribute", RVA = "0x866680", Offset = "0x866680")]
	public class CGPath : CGShape
	{
		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3[] Direction;

		[Token(Token = "0x6000887")]
		[Address(RVA = "0x109AC80", Offset = "0x109AC80", VA = "0x109AC80")]
		public CGPath()
		{
		}

		[Token(Token = "0x6000888")]
		[Address(RVA = "0x109ADBC", Offset = "0x109ADBC", VA = "0x109ADBC")]
		public CGPath(CGPath source)
		{
		}

		[Token(Token = "0x6000889")]
		public override T Clone<T>()
		{
			return null;
		}

		[Token(Token = "0x600088A")]
		[Address(RVA = "0x109B12C", Offset = "0x109B12C", VA = "0x109B12C")]
		public static void Copy(CGPath dest, CGPath source)
		{
		}

		[Token(Token = "0x600088B")]
		[Address(RVA = "0x109B404", Offset = "0x109B404", VA = "0x109B404")]
		public void Interpolate(float f, out Vector3 position, out Vector3 direction, out Vector3 up)
		{
		}

		[Token(Token = "0x600088C")]
		[Address(RVA = "0x109B684", Offset = "0x109B684", VA = "0x109B684")]
		public void Interpolate(float f, float angleF, out Vector3 pos, out Vector3 dir, out Vector3 up)
		{
		}

		[Token(Token = "0x600088D")]
		[Address(RVA = "0x109B778", Offset = "0x109B778", VA = "0x109B778")]
		public Vector3 InterpolateDirection(float f)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x20000E0")]
	[AttributeAttribute(Name = "CGDataInfoAttribute", RVA = "0x8666AC", Offset = "0x8666AC")]
	public class CGVolume : CGPath
	{
		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Vector3[] Vertex;

		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Vector3[] VertexNormal;

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public float[] CrossF;

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public float[] CrossMap;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float[] SegmentLength;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public bool CrossClosed;

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x91")]
		public bool CrossSeamless;

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public float CrossFShift;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public SamplePointsMaterialGroupCollection CrossMaterialGroups;

		[Token(Token = "0x170001A1")]
		public int CrossSize
		{
			[Token(Token = "0x600088E")]
			[Address(RVA = "0x109E6DC", Offset = "0x109E6DC", VA = "0x109E6DC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001A2")]
		public int VertexCount
		{
			[Token(Token = "0x600088F")]
			[Address(RVA = "0x10A0A00", Offset = "0x10A0A00", VA = "0x10A0A00")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000890")]
		[Address(RVA = "0x10A0A1C", Offset = "0x10A0A1C", VA = "0x10A0A1C")]
		public CGVolume()
		{
		}

		[Token(Token = "0x6000891")]
		[Address(RVA = "0x10A0AB0", Offset = "0x10A0AB0", VA = "0x10A0AB0")]
		public CGVolume(int samplePoints, CGShape crossShape)
		{
		}

		[Token(Token = "0x6000892")]
		[Address(RVA = "0x10A0C64", Offset = "0x10A0C64", VA = "0x10A0C64")]
		public CGVolume(CGPath path, CGShape crossShape)
		{
		}

		[Token(Token = "0x6000893")]
		[Address(RVA = "0x10A0E28", Offset = "0x10A0E28", VA = "0x10A0E28")]
		public CGVolume(CGVolume source)
		{
		}

		[Token(Token = "0x6000894")]
		[Address(RVA = "0x10A1000", Offset = "0x10A1000", VA = "0x10A1000")]
		public static CGVolume Get(CGVolume data, CGPath path, CGShape crossShape)
		{
			return null;
		}

		[Token(Token = "0x6000895")]
		public override T Clone<T>()
		{
			return null;
		}

		[Token(Token = "0x6000896")]
		[Address(RVA = "0x10A11C4", Offset = "0x10A11C4", VA = "0x10A11C4")]
		public void InterpolateVolume(float f, float crossF, out Vector3 pos, out Vector3 dir, out Vector3 up)
		{
		}

		[Token(Token = "0x6000897")]
		[Address(RVA = "0x10A14C8", Offset = "0x10A14C8", VA = "0x10A14C8")]
		public Vector3 InterpolateVolumePosition(float f, float crossF)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000898")]
		[Address(RVA = "0x10A16D8", Offset = "0x10A16D8", VA = "0x10A16D8")]
		public Vector3 InterpolateVolumeDirection(float f, float crossF)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000899")]
		[Address(RVA = "0x10A1878", Offset = "0x10A1878", VA = "0x10A1878")]
		public Vector3 InterpolateVolumeUp(float f, float crossF)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600089A")]
		[Address(RVA = "0x10A1AC4", Offset = "0x10A1AC4", VA = "0x10A1AC4")]
		public float GetCrossLength(float pathF)
		{
			return default(float);
		}

		[Token(Token = "0x600089B")]
		[Address(RVA = "0x10A1E88", Offset = "0x10A1E88", VA = "0x10A1E88")]
		public float CrossFToDistance(float f, float crossF, CurvyClamping crossClamping = CurvyClamping.Clamp)
		{
			return default(float);
		}

		[Token(Token = "0x600089C")]
		[Address(RVA = "0x10A1ECC", Offset = "0x10A1ECC", VA = "0x10A1ECC")]
		public float CrossDistanceToF(float f, float distance, CurvyClamping crossClamping = CurvyClamping.Clamp)
		{
			return default(float);
		}

		[Token(Token = "0x600089D")]
		[Address(RVA = "0x10A1C4C", Offset = "0x10A1C4C", VA = "0x10A1C4C")]
		public void GetSegmentIndices(float pathF, out int s0Index, out int s1Index, out float frag)
		{
		}

		[Token(Token = "0x600089E")]
		[Address(RVA = "0x10A1F14", Offset = "0x10A1F14", VA = "0x10A1F14")]
		public int GetSegmentIndex(int segment)
		{
			return default(int);
		}

		[Token(Token = "0x600089F")]
		[Address(RVA = "0x10A1F34", Offset = "0x10A1F34", VA = "0x10A1F34")]
		public int GetCrossFIndex(float crossF, out float frag)
		{
			return default(int);
		}

		[Token(Token = "0x60008A0")]
		[Address(RVA = "0x10A1FE4", Offset = "0x10A1FE4", VA = "0x10A1FE4")]
		public int GetVertexIndex(float pathF, out float pathFrag)
		{
			return default(int);
		}

		[Token(Token = "0x60008A1")]
		[Address(RVA = "0x10A1478", Offset = "0x10A1478", VA = "0x10A1478")]
		public int GetVertexIndex(float pathF, float crossF, out float pathFrag, out float crossFrag)
		{
			return default(int);
		}

		[Token(Token = "0x60008A2")]
		[Address(RVA = "0x10A2068", Offset = "0x10A2068", VA = "0x10A2068")]
		public Vector3[] GetSegmentVertices(params int[] segmentIndices)
		{
			return null;
		}

		[Token(Token = "0x60008A3")]
		[Address(RVA = "0x10A1D38", Offset = "0x10A1D38", VA = "0x10A1D38")]
		private float calcSegmentLength(int segmentIndex)
		{
			return default(float);
		}
	}
	[Token(Token = "0x20000E1")]
	[AttributeAttribute(Name = "CGDataInfoAttribute", RVA = "0x8666D4", Offset = "0x8666D4")]
	public class CGBounds : CGData
	{
		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected Bounds? mBounds;

		[Token(Token = "0x170001A3")]
		public Bounds Bounds
		{
			[Token(Token = "0x60008A4")]
			[Address(RVA = "0x13A7608", Offset = "0x13A7608", VA = "0x13A7608")]
			get
			{
				return default(Bounds);
			}
			[Token(Token = "0x60008A5")]
			[Address(RVA = "0x13A7684", Offset = "0x13A7684", VA = "0x13A7684")]
			set
			{
			}
		}

		[Token(Token = "0x170001A4")]
		public float Depth
		{
			[Token(Token = "0x60008A6")]
			[Address(RVA = "0x13A7520", Offset = "0x13A7520", VA = "0x13A7520")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60008A7")]
		[Address(RVA = "0x13A9B7C", Offset = "0x13A9B7C", VA = "0x13A9B7C")]
		public CGBounds()
		{
		}

		[Token(Token = "0x60008A8")]
		[Address(RVA = "0x13A9B8C", Offset = "0x13A9B8C", VA = "0x13A9B8C")]
		public CGBounds(Bounds bounds)
		{
		}

		[Token(Token = "0x60008A9")]
		[Address(RVA = "0x13A7568", Offset = "0x13A7568", VA = "0x13A7568")]
		public CGBounds(CGBounds source)
		{
		}

		[Token(Token = "0x60008AA")]
		[Address(RVA = "0x13A9BD8", Offset = "0x13A9BD8", VA = "0x13A9BD8", Slot = "6")]
		public virtual void RecalculateBounds()
		{
		}

		[Token(Token = "0x60008AB")]
		public override T Clone<T>()
		{
			return null;
		}

		[Token(Token = "0x60008AC")]
		[Address(RVA = "0x13A9C00", Offset = "0x13A9C00", VA = "0x13A9C00")]
		public static void Copy(CGBounds dest, CGBounds source)
		{
		}
	}
	[Token(Token = "0x20000E2")]
	public class CGVSubMesh : CGData
	{
		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int[] Triangles;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Material Material;

		[Token(Token = "0x170001A5")]
		public override int Count
		{
			[Token(Token = "0x60008AD")]
			[Address(RVA = "0x10A0878", Offset = "0x10A0878", VA = "0x10A0878", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60008AE")]
		[Address(RVA = "0x10A0330", Offset = "0x10A0330", VA = "0x10A0330")]
		public CGVSubMesh([Optional] Material material)
		{
		}

		[Token(Token = "0x60008AF")]
		[Address(RVA = "0x109ED5C", Offset = "0x109ED5C", VA = "0x109ED5C")]
		public CGVSubMesh(int[] triangles, [Optional] Material material)
		{
		}

		[Token(Token = "0x60008B0")]
		[Address(RVA = "0x10A0894", Offset = "0x10A0894", VA = "0x10A0894")]
		public CGVSubMesh(int triangleCount, [Optional] Material material)
		{
		}

		[Token(Token = "0x60008B1")]
		[Address(RVA = "0x109E924", Offset = "0x109E924", VA = "0x109E924")]
		public CGVSubMesh(CGVSubMesh source)
		{
		}

		[Token(Token = "0x60008B2")]
		public override T Clone<T>()
		{
			return null;
		}

		[Token(Token = "0x60008B3")]
		[Address(RVA = "0x10A090C", Offset = "0x10A090C", VA = "0x10A090C")]
		public static CGVSubMesh Get(CGVSubMesh data, int triangleCount, [Optional] Material material)
		{
			return null;
		}

		[Token(Token = "0x60008B4")]
		[Address(RVA = "0x10A09A4", Offset = "0x10A09A4", VA = "0x10A09A4")]
		public void ShiftIndices(int offset, int startIndex = 0)
		{
		}

		[Token(Token = "0x60008B5")]
		[Address(RVA = "0x109F8F0", Offset = "0x109F8F0", VA = "0x109F8F0")]
		public void Add(CGVSubMesh other, int shiftIndexOffset = 0)
		{
		}
	}
	[Token(Token = "0x20000E3")]
	[AttributeAttribute(Name = "CGDataInfoAttribute", RVA = "0x8666F8", Offset = "0x8666F8")]
	public class CGVMesh : CGBounds
	{
		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3[] Vertex;

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Vector2[] UV;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector2[] UV2;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Vector3[] Normal;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Vector4[] Tangents;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public CGVSubMesh[] SubMeshes;

		[Token(Token = "0x170001A6")]
		public override int Count
		{
			[Token(Token = "0x60008B6")]
			[Address(RVA = "0x109E350", Offset = "0x109E350", VA = "0x109E350", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001A7")]
		public bool HasUV
		{
			[Token(Token = "0x60008B7")]
			[Address(RVA = "0x109E36C", Offset = "0x109E36C", VA = "0x109E36C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001A8")]
		public bool HasUV2
		{
			[Token(Token = "0x60008B8")]
			[Address(RVA = "0x109E390", Offset = "0x109E390", VA = "0x109E390")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001A9")]
		public bool HasNormals
		{
			[Token(Token = "0x60008B9")]
			[Address(RVA = "0x109E3B4", Offset = "0x109E3B4", VA = "0x109E3B4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001AA")]
		public bool HasTangents
		{
			[Token(Token = "0x60008BA")]
			[Address(RVA = "0x109E3D8", Offset = "0x109E3D8", VA = "0x109E3D8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001AB")]
		public int TriangleCount
		{
			[Token(Token = "0x60008BB")]
			[Address(RVA = "0x109E3FC", Offset = "0x109E3FC", VA = "0x109E3FC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60008BC")]
		[Address(RVA = "0x109E488", Offset = "0x109E488", VA = "0x109E488")]
		public CGVMesh()
		{
		}

		[Token(Token = "0x60008BD")]
		[Address(RVA = "0x109E4A0", Offset = "0x109E4A0", VA = "0x109E4A0")]
		public CGVMesh(int vertexCount, bool addUV = false, bool addUV2 = false, bool addNormals = false, bool addTangents = false)
		{
		}

		[Token(Token = "0x60008BE")]
		[Address(RVA = "0x109E5A8", Offset = "0x109E5A8", VA = "0x109E5A8")]
		public CGVMesh(CGVolume volume)
		{
		}

		[Token(Token = "0x60008BF")]
		[Address(RVA = "0x109E604", Offset = "0x109E604", VA = "0x109E604")]
		public CGVMesh(CGVolume volume, IntRegion subset)
		{
		}

		[Token(Token = "0x60008C0")]
		[Address(RVA = "0x109E6F8", Offset = "0x109E6F8", VA = "0x109E6F8")]
		public CGVMesh(CGVMesh source)
		{
		}

		[Token(Token = "0x60008C1")]
		[Address(RVA = "0x109E9CC", Offset = "0x109E9CC", VA = "0x109E9CC")]
		public CGVMesh(CGMeshProperties meshProperties)
		{
		}

		[Token(Token = "0x60008C2")]
		[Address(RVA = "0x109EA38", Offset = "0x109EA38", VA = "0x109EA38")]
		public CGVMesh(Mesh source, Material[] materials, Matrix4x4 trsMatrix)
		{
		}

		[Token(Token = "0x60008C3")]
		public override T Clone<T>()
		{
			return null;
		}

		[Token(Token = "0x60008C4")]
		[Address(RVA = "0x109EFEC", Offset = "0x109EFEC", VA = "0x109EFEC")]
		public static CGVMesh Get(CGVMesh data, CGVolume source, bool addUV, bool reverseNormals)
		{
			return null;
		}

		[Token(Token = "0x60008C5")]
		[Address(RVA = "0x109F074", Offset = "0x109F074", VA = "0x109F074")]
		public static CGVMesh Get(CGVMesh data, CGVolume source, IntRegion subset, bool addUV, bool reverseNormals)
		{
			return null;
		}

		[Token(Token = "0x60008C6")]
		[Address(RVA = "0x109F328", Offset = "0x109F328", VA = "0x109F328")]
		public void SetSubMeshCount(int count)
		{
		}

		[Token(Token = "0x60008C7")]
		[Address(RVA = "0x109F388", Offset = "0x109F388", VA = "0x109F388")]
		public void AddSubMesh([Optional] CGVSubMesh submesh)
		{
		}

		[Token(Token = "0x60008C8")]
		[Address(RVA = "0x109F3F0", Offset = "0x109F3F0", VA = "0x109F3F0")]
		public void MergeVMesh(CGVMesh source)
		{
		}

		[Token(Token = "0x60008C9")]
		[Address(RVA = "0x109F9D8", Offset = "0x109F9D8", VA = "0x109F9D8")]
		public void MergeVMesh(CGVMesh source, Matrix4x4 matrix)
		{
		}

		[Token(Token = "0x60008CA")]
		[Address(RVA = "0x109FBD8", Offset = "0x109FBD8", VA = "0x109FBD8")]
		public void MergeVMeshes(List<CGVMesh> vMeshes, int startIndex, int endIndex)
		{
		}

		[Token(Token = "0x60008CB")]
		[Address(RVA = "0x109F530", Offset = "0x109F530", VA = "0x109F530")]
		private void MergeUVsNormalsAndTangents(CGVMesh source, int preMergeVertexCount)
		{
		}

		[Token(Token = "0x60008CC")]
		[Address(RVA = "0x109F7BC", Offset = "0x109F7BC", VA = "0x109F7BC")]
		public CGVSubMesh GetMaterialSubMesh(Material mat, bool createIfMissing = true)
		{
			return null;
		}

		[Token(Token = "0x60008CD")]
		[Address(RVA = "0x10A03A4", Offset = "0x10A03A4", VA = "0x10A03A4")]
		public Mesh AsMesh()
		{
			return null;
		}

		[Token(Token = "0x60008CE")]
		[Address(RVA = "0x10A041C", Offset = "0x10A041C", VA = "0x10A041C")]
		public void ToMesh(ref Mesh msh)
		{
		}

		[Token(Token = "0x60008CF")]
		[Address(RVA = "0x10A0558", Offset = "0x10A0558", VA = "0x10A0558")]
		public Material[] GetMaterials()
		{
			return null;
		}

		[Token(Token = "0x60008D0")]
		[Address(RVA = "0x10A063C", Offset = "0x10A063C", VA = "0x10A063C", Slot = "6")]
		public override void RecalculateBounds()
		{
		}

		[Token(Token = "0x60008D1")]
		[Address(RVA = "0x10A0850", Offset = "0x10A0850", VA = "0x10A0850")]
		public void RecalculateUV2()
		{
		}

		[Token(Token = "0x60008D2")]
		[Address(RVA = "0x109ED94", Offset = "0x109ED94", VA = "0x109ED94")]
		public void TRS(Matrix4x4 matrix)
		{
		}

		[Token(Token = "0x60008D3")]
		private void copyData<T>(ref T[] src, ref T[] dst, int currentSize, int extraSize)
		{
		}
	}
	[Token(Token = "0x20000E4")]
	[AttributeAttribute(Name = "CGDataInfoAttribute", RVA = "0x86671C", Offset = "0x86671C")]
	public class CGGameObject : CGBounds
	{
		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GameObject Object;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Vector3 Translate;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public Vector3 Rotate;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Vector3 Scale;

		[Token(Token = "0x170001AC")]
		public Matrix4x4 Matrix
		{
			[Token(Token = "0x60008D4")]
			[Address(RVA = "0x13AAD4C", Offset = "0x13AAD4C", VA = "0x13AAD4C")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Token(Token = "0x60008D5")]
		[Address(RVA = "0x13AAE6C", Offset = "0x13AAE6C", VA = "0x13AAE6C")]
		public CGGameObject()
		{
		}

		[Token(Token = "0x60008D6")]
		[Address(RVA = "0x13AAEE4", Offset = "0x13AAEE4", VA = "0x13AAEE4")]
		public CGGameObject(CGGameObjectProperties properties)
		{
		}

		[Token(Token = "0x60008D7")]
		[Address(RVA = "0x13AB058", Offset = "0x13AB058", VA = "0x13AB058")]
		public CGGameObject(GameObject obj)
		{
		}

		[Token(Token = "0x60008D8")]
		[Address(RVA = "0x13AAF2C", Offset = "0x13AAF2C", VA = "0x13AAF2C")]
		public CGGameObject(GameObject obj, Vector3 translate, Vector3 rotate, Vector3 scale)
		{
		}

		[Token(Token = "0x60008D9")]
		[Address(RVA = "0x13AB140", Offset = "0x13AB140", VA = "0x13AB140")]
		public CGGameObject(CGGameObject source)
		{
		}

		[Token(Token = "0x60008DA")]
		public override T Clone<T>()
		{
			return null;
		}

		[Token(Token = "0x60008DB")]
		[Address(RVA = "0x13AB208", Offset = "0x13AB208", VA = "0x13AB208")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x8773D8", Offset = "0x8773D8")]
		public static CGGameObject Get(CGGameObject data, GameObject obj, Vector3 translate, Vector3 rotate, Vector3 scale)
		{
			return null;
		}

		[Token(Token = "0x60008DC")]
		[Address(RVA = "0x13AB320", Offset = "0x13AB320", VA = "0x13AB320", Slot = "6")]
		public override void RecalculateBounds()
		{
		}
	}
	[Token(Token = "0x20000E5")]
	[AttributeAttribute(Name = "CGDataInfoAttribute", RVA = "0x866754", Offset = "0x866754")]
	public class CGSpots : CGData
	{
		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CGSpot[] Points;

		[Token(Token = "0x170001AD")]
		public override int Count
		{
			[Token(Token = "0x60008DD")]
			[Address(RVA = "0x109D984", Offset = "0x109D984", VA = "0x109D984", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60008DE")]
		[Address(RVA = "0x109D9A0", Offset = "0x109D9A0", VA = "0x109D9A0")]
		public CGSpots()
		{
		}

		[Token(Token = "0x60008DF")]
		[Address(RVA = "0x109DA04", Offset = "0x109DA04", VA = "0x109DA04")]
		public CGSpots(params CGSpot[] points)
		{
		}

		[Token(Token = "0x60008E0")]
		[Address(RVA = "0x109DA30", Offset = "0x109DA30", VA = "0x109DA30")]
		public CGSpots(params List<CGSpot>[] lists)
		{
		}

		[Token(Token = "0x60008E1")]
		[Address(RVA = "0x109DB64", Offset = "0x109DB64", VA = "0x109DB64")]
		public CGSpots(CGSpots source)
		{
		}

		[Token(Token = "0x60008E2")]
		public override T Clone<T>()
		{
			return null;
		}
	}
	[Token(Token = "0x20000E6")]
	public class CGDataRequestParameter
	{
		[Token(Token = "0x60008E3")]
		[Address(RVA = "0x13AAA58", Offset = "0x13AAA58", VA = "0x13AAA58")]
		public static implicit operator bool(CGDataRequestParameter a)
		{
			return default(bool);
		}

		[Token(Token = "0x60008E4")]
		[Address(RVA = "0x13AA894", Offset = "0x13AA894", VA = "0x13AA894")]
		public CGDataRequestParameter()
		{
		}
	}
	[Token(Token = "0x20000E7")]
	public class CGDataRequestMetaCGOptions : CGDataRequestParameter
	{
		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool CheckHardEdges;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public bool CheckMaterialID;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		public bool IncludeControlPoints;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13")]
		public bool CheckExtendedUV;

		[Token(Token = "0x60008E5")]
		[Address(RVA = "0x13A1FF4", Offset = "0x13A1FF4", VA = "0x13A1FF4")]
		public CGDataRequestMetaCGOptions(bool checkEdges, bool checkMaterials, bool includeCP, bool extendedUV)
		{
		}

		[Token(Token = "0x60008E6")]
		[Address(RVA = "0x13AA89C", Offset = "0x13AA89C", VA = "0x13AA89C", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60008E7")]
		[Address(RVA = "0x13AA9B0", Offset = "0x13AA9B0", VA = "0x13AA9B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Token(Token = "0x20000E8")]
	public class CGDataRequestShapeRasterization : CGDataRequestRasterization
	{
		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float[] PathF;

		[Token(Token = "0x60008E8")]
		[Address(RVA = "0x13A1FC4", Offset = "0x13A1FC4", VA = "0x13A1FC4")]
		public CGDataRequestShapeRasterization(float[] pathF, float start, float rasterizedRelativeLength, int resolution, float angle, ModeEnum mode = ModeEnum.Even)
		{
		}

		[Token(Token = "0x60008E9")]
		[Address(RVA = "0x13AAC28", Offset = "0x13AAC28", VA = "0x13AAC28", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60008EA")]
		[Address(RVA = "0x13AAD08", Offset = "0x13AAD08", VA = "0x13AAD08", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Token(Token = "0x20000E9")]
	public class CGDataRequestRasterization : CGDataRequestParameter
	{
		[Token(Token = "0x2000194")]
		public enum ModeEnum
		{
			[Token(Token = "0x40006BD")]
			Even,
			[Token(Token = "0x40006BE")]
			Optimized
		}

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float Start;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float RasterizedRelativeLength;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int Resolution;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float AngleThreshold;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ModeEnum Mode;

		[Token(Token = "0x60008EB")]
		[Address(RVA = "0x139F974", Offset = "0x139F974", VA = "0x139F974")]
		public CGDataRequestRasterization(float start, float rasterizedRelativeLength, int resolution, float angle, ModeEnum mode = ModeEnum.Even)
		{
		}

		[Token(Token = "0x60008EC")]
		[Address(RVA = "0x13AAA64", Offset = "0x13AAA64", VA = "0x13AAA64")]
		public CGDataRequestRasterization(CGDataRequestRasterization source)
		{
		}

		[Token(Token = "0x60008ED")]
		[Address(RVA = "0x13AAA8C", Offset = "0x13AAA8C", VA = "0x13AAA8C", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60008EE")]
		[Address(RVA = "0x13AAB74", Offset = "0x13AAB74", VA = "0x13AAB74", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Token(Token = "0x20000EA")]
	public interface INoProcessing
	{
	}
	[Token(Token = "0x20000EB")]
	public interface IExternalInput
	{
		[Token(Token = "0x170001AE")]
		bool SupportsIPE
		{
			[Token(Token = "0x60008EF")]
			get;
		}
	}
	[Token(Token = "0x20000EC")]
	public interface IOnRequestProcessing
	{
		[Token(Token = "0x60008F0")]
		CGData[] OnSlotDataRequest(CGModuleInputSlot requestedBy, CGModuleOutputSlot requestedSlot, params CGDataRequestParameter[] requests);
	}
	[Token(Token = "0x20000ED")]
	public interface IPathProvider
	{
		[Token(Token = "0x170001AF")]
		bool PathIsClosed
		{
			[Token(Token = "0x60008F1")]
			get;
		}
	}
	[Token(Token = "0x20000EE")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x866778", Offset = "0x866778")]
	public interface IOnRequestPath : IOnRequestProcessing, IPathProvider
	{
	}
	[Token(Token = "0x20000EF")]
	public interface ICGResourceLoader
	{
		[Token(Token = "0x60008F2")]
		Component Create(CGModule cgModule, string context);

		[Token(Token = "0x60008F3")]
		void Destroy(CGModule cgModule, Component obj, string context, bool kill);
	}
	[Token(Token = "0x20000F0")]
	public interface ICGResourceCollection
	{
		[Token(Token = "0x170001B0")]
		int Count
		{
			[Token(Token = "0x60008F4")]
			get;
		}

		[Token(Token = "0x170001B1")]
		Component[] ItemsArray
		{
			[Token(Token = "0x60008F5")]
			get;
		}
	}
	[Token(Token = "0x20000F1")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x8667B0", Offset = "0x8667B0")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x8667B0", Offset = "0x8667B0")]
	public class CGMeshResource : DuplicateEditorMesh, IPoolable
	{
		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private MeshRenderer mRenderer;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Collider mCollider;

		[Token(Token = "0x170001B2")]
		public MeshRenderer Renderer
		{
			[Token(Token = "0x60008F6")]
			[Address(RVA = "0x13AC708", Offset = "0x13AC708", VA = "0x13AC708")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001B3")]
		public Collider Collider
		{
			[Token(Token = "0x60008F7")]
			[Address(RVA = "0x13AC7A0", Offset = "0x13AC7A0", VA = "0x13AC7A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008F8")]
		[Address(RVA = "0x13AC838", Offset = "0x13AC838", VA = "0x13AC838")]
		public Mesh Prepare()
		{
			return null;
		}

		[Token(Token = "0x60008F9")]
		[Address(RVA = "0x13AC894", Offset = "0x13AC894", VA = "0x13AC894")]
		public bool ColliderMatches(CGColliderEnum type)
		{
			return default(bool);
		}

		[Token(Token = "0x60008FA")]
		[Address(RVA = "0x13ACA58", Offset = "0x13ACA58", VA = "0x13ACA58")]
		public void RemoveCollider()
		{
		}

		[Token(Token = "0x60008FB")]
		[Address(RVA = "0x13ACB40", Offset = "0x13ACB40", VA = "0x13ACB40")]
		public bool UpdateCollider(CGColliderEnum mode, bool convex, bool isTrigger, PhysicMaterial material, MeshColliderCookingOptions meshCookingOptions = MeshColliderCookingOptions.CookForFasterSimulation | MeshColliderCookingOptions.EnableMeshCleaning | MeshColliderCookingOptions.WeldColocatedVertices)
		{
			return default(bool);
		}

		[Token(Token = "0x60008FC")]
		[Address(RVA = "0x13AD264", Offset = "0x13AD264", VA = "0x13AD264", Slot = "5")]
		public void OnBeforePush()
		{
		}

		[Token(Token = "0x60008FD")]
		[Address(RVA = "0x13AD268", Offset = "0x13AD268", VA = "0x13AD268", Slot = "6")]
		public void OnAfterPop()
		{
		}

		[Token(Token = "0x60008FE")]
		[Address(RVA = "0x13AD26C", Offset = "0x13AD26C", VA = "0x13AD26C")]
		public CGMeshResource()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000F2")]
	public class CGMeshResourceCollection : ICGResourceCollection
	{
		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<CGMeshResource> Items;

		[Token(Token = "0x170001B4")]
		public int Count
		{
			[Token(Token = "0x60008FF")]
			[Address(RVA = "0x13AD274", Offset = "0x13AD274", VA = "0x13AD274", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001B5")]
		public Component[] ItemsArray
		{
			[Token(Token = "0x6000900")]
			[Address(RVA = "0x13AD2C4", Offset = "0x13AD2C4", VA = "0x13AD2C4", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000901")]
		[Address(RVA = "0x13AD31C", Offset = "0x13AD31C", VA = "0x13AD31C")]
		public CGMeshResourceCollection()
		{
		}
	}
	[Token(Token = "0x20000F3")]
	[ExecuteInEditMode]
	public abstract class CGModule : DTVersionedMonoBehaviour
	{
		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x86D3AC", Offset = "0x86D3AC")]
		[SerializeField]
		protected CurvyCGEvent m_OnBeforeRefresh;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x86D404", Offset = "0x86D404")]
		[SerializeField]
		protected CurvyCGEvent m_OnRefresh;

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[HideInInspector]
		private string m_ModuleName;

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		[HideInInspector]
		private bool m_Active;

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x86D4C0", Offset = "0x86D4C0")]
		[AttributeAttribute(Name = "GroupConditionAttribute", RVA = "0x86D4C0", Offset = "0x86D4C0")]
		[AttributeAttribute(Name = "FieldActionAttribute", RVA = "0x86D4C0", Offset = "0x86D4C0")]
		[SerializeField]
		private bool m_RandomizeSeed;

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		[HideInInspector]
		private int m_Seed;

		[NonSerialized]
		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public List<string> UIMessages;

		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private CurvyGenerator mGenerator;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[HideInInspector]
		private int m_UniqueID;

		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86D5DC", Offset = "0x86D5DC")]
		private bool <CircularReferenceError>k__BackingField;

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		internal int SortAncestors;

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[HideInInspector]
		public CGModuleProperties Properties;

		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[HideInInspector]
		public List<CGModuleLink> InputLinks;

		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[HideInInspector]
		public List<CGModuleLink> OutputLinks;

		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86D61C", Offset = "0x86D61C")]
		private Dictionary<string, CGModuleInputSlot> <InputByName>k__BackingField;

		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86D62C", Offset = "0x86D62C")]
		private Dictionary<string, CGModuleOutputSlot> <OutputByName>k__BackingField;

		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86D63C", Offset = "0x86D63C")]
		private List<CGModuleInputSlot> <Input>k__BackingField;

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86D64C", Offset = "0x86D64C")]
		private List<CGModuleOutputSlot> <Output>k__BackingField;

		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private ModuleInfoAttribute mInfo;

		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private bool mDirty;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
		private bool mInitialized;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA2")]
		private bool mStateChangeDirty;

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA3")]
		private bool mLastIsConfiguredState;

		[Token(Token = "0x170001B6")]
		public CurvyCGEvent OnBeforeRefresh
		{
			[Token(Token = "0x6000902")]
			[Address(RVA = "0x13AD688", Offset = "0x13AD688", VA = "0x13AD688")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000903")]
			[Address(RVA = "0x13AD690", Offset = "0x13AD690", VA = "0x13AD690")]
			set
			{
			}
		}

		[Token(Token = "0x170001B7")]
		public CurvyCGEvent OnRefresh
		{
			[Token(Token = "0x6000904")]
			[Address(RVA = "0x13AD6A4", Offset = "0x13AD6A4", VA = "0x13AD6A4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000905")]
			[Address(RVA = "0x13AD6AC", Offset = "0x13AD6AC", VA = "0x13AD6AC")]
			set
			{
			}
		}

		[Token(Token = "0x170001B8")]
		public string ModuleName
		{
			[Token(Token = "0x6000908")]
			[Address(RVA = "0x13AD798", Offset = "0x13AD798", VA = "0x13AD798")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000909")]
			[Address(RVA = "0x13AD7A0", Offset = "0x13AD7A0", VA = "0x13AD7A0")]
			set
			{
			}
		}

		[Token(Token = "0x170001B9")]
		public bool Active
		{
			[Token(Token = "0x600090A")]
			[Address(RVA = "0x13AD9DC", Offset = "0x13AD9DC", VA = "0x13AD9DC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600090B")]
			[Address(RVA = "0x13AD9E4", Offset = "0x13AD9E4", VA = "0x13AD9E4")]
			set
			{
			}
		}

		[Token(Token = "0x170001BA")]
		public int Seed
		{
			[Token(Token = "0x600090C")]
			[Address(RVA = "0x13ADA40", Offset = "0x13ADA40", VA = "0x13ADA40")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600090D")]
			[Address(RVA = "0x13ADA48", Offset = "0x13ADA48", VA = "0x13ADA48")]
			set
			{
			}
		}

		[Token(Token = "0x170001BB")]
		public bool RandomizeSeed
		{
			[Token(Token = "0x600090E")]
			[Address(RVA = "0x13ADA60", Offset = "0x13ADA60", VA = "0x13ADA60")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600090F")]
			[Address(RVA = "0x13ADA68", Offset = "0x13ADA68", VA = "0x13ADA68")]
			set
			{
			}
		}

		[Token(Token = "0x170001BC")]
		public CurvyGenerator Generator
		{
			[Token(Token = "0x6000910")]
			[Address(RVA = "0x13ADA88", Offset = "0x13ADA88", VA = "0x13ADA88")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001BD")]
		public int UniqueID
		{
			[Token(Token = "0x6000911")]
			[Address(RVA = "0x13ADA90", Offset = "0x13ADA90", VA = "0x13ADA90")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001BE")]
		public bool CircularReferenceError
		{
			[Token(Token = "0x6000912")]
			[Address(RVA = "0x13ADA98", Offset = "0x13ADA98", VA = "0x13ADA98")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x877410", Offset = "0x877410")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000913")]
			[Address(RVA = "0x13ADAA0", Offset = "0x13ADAA0", VA = "0x13ADAA0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x877420", Offset = "0x877420")]
			set
			{
			}
		}

		[Token(Token = "0x170001BF")]
		public Dictionary<string, CGModuleInputSlot> InputByName
		{
			[Token(Token = "0x6000914")]
			[Address(RVA = "0x13ADAAC", Offset = "0x13ADAAC", VA = "0x13ADAAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x877430", Offset = "0x877430")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000915")]
			[Address(RVA = "0x13ADAB4", Offset = "0x13ADAB4", VA = "0x13ADAB4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x877440", Offset = "0x877440")]
			private set
			{
			}
		}

		[Token(Token = "0x170001C0")]
		public Dictionary<string, CGModuleOutputSlot> OutputByName
		{
			[Token(Token = "0x6000916")]
			[Address(RVA = "0x13ADABC", Offset = "0x13ADABC", VA = "0x13ADABC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x877450", Offset = "0x877450")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000917")]
			[Address(RVA = "0x13ADAC4", Offset = "0x13ADAC4", VA = "0x13ADAC4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x877460", Offset = "0x877460")]
			private set
			{
			}
		}

		[Token(Token = "0x170001C1")]
		public List<CGModuleInputSlot> Input
		{
			[Token(Token = "0x6000918")]
			[Address(RVA = "0x13ADACC", Offset = "0x13ADACC", VA = "0x13ADACC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x877470", Offset = "0x877470")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000919")]
			[Address(RVA = "0x13ADAD4", Offset = "0x13ADAD4", VA = "0x13ADAD4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x877480", Offset = "0x877480")]
			private set
			{
			}
		}

		[Token(Token = "0x170001C2")]
		public List<CGModuleOutputSlot> Output
		{
			[Token(Token = "0x600091A")]
			[Address(RVA = "0x13ADADC", Offset = "0x13ADADC", VA = "0x13ADADC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x877490", Offset = "0x877490")]
			get
			{
				return null;
			}
			[Token(Token = "0x600091B")]
			[Address(RVA = "0x13ADAE4", Offset = "0x13ADAE4", VA = "0x13ADAE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8774A0", Offset = "0x8774A0")]
			private set
			{
			}
		}

		[Token(Token = "0x170001C3")]
		public ModuleInfoAttribute Info
		{
			[Token(Token = "0x600091C")]
			[Address(RVA = "0x13ADAEC", Offset = "0x13ADAEC", VA = "0x13ADAEC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001C4")]
		public bool Dirty
		{
			[Token(Token = "0x600091D")]
			[Address(RVA = "0x13ADC0C", Offset = "0x13ADC0C", VA = "0x13ADC0C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600091E")]
			[Address(RVA = "0x139EBF0", Offset = "0x139EBF0", VA = "0x139EBF0")]
			set
			{
			}
		}

		[Token(Token = "0x170001C5")]
		public virtual bool IsConfigured
		{
			[Token(Token = "0x6000925")]
			[Address(RVA = "0x13AF580", Offset = "0x13AF580", VA = "0x13AF580", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001C6")]
		public virtual bool IsInitialized
		{
			[Token(Token = "0x6000926")]
			[Address(RVA = "0x13AF854", Offset = "0x13AF854", VA = "0x13AF854", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000906")]
		[Address(RVA = "0x13AD6C0", Offset = "0x13AD6C0", VA = "0x13AD6C0")]
		protected CurvyCGEventArgs OnBeforeRefreshEvent(CurvyCGEventArgs e)
		{
			return null;
		}

		[Token(Token = "0x6000907")]
		[Address(RVA = "0x13AD72C", Offset = "0x13AD72C", VA = "0x13AD72C")]
		protected CurvyCGEventArgs OnRefreshEvent(CurvyCGEventArgs e)
		{
			return null;
		}

		[Token(Token = "0x600091F")]
		[Address(RVA = "0x13A2610", Offset = "0x13A2610", VA = "0x13A2610", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000920")]
		[Address(RVA = "0x139F4A8", Offset = "0x139F4A8", VA = "0x139F4A8", Slot = "5")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x6000921")]
		[Address(RVA = "0x13ADDD8", Offset = "0x13ADDD8", VA = "0x13ADDD8")]
		public void Initialize()
		{
		}

		[Token(Token = "0x6000922")]
		[Address(RVA = "0x13AE330", Offset = "0x13AE330", VA = "0x13AE330", Slot = "6")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x6000923")]
		[Address(RVA = "0x13AE334", Offset = "0x13AE334", VA = "0x13AE334", Slot = "7")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000924")]
		[Address(RVA = "0x13AF578", Offset = "0x13AF578", VA = "0x13AF578")]
		private void OnDidApplyAnimationProperties()
		{
		}

		[Token(Token = "0x6000927")]
		[Address(RVA = "0x139F91C", Offset = "0x139F91C", VA = "0x139F91C", Slot = "10")]
		public virtual void Refresh()
		{
		}

		[Token(Token = "0x6000928")]
		[Address(RVA = "0x139F5AC", Offset = "0x139F5AC", VA = "0x139F5AC", Slot = "11")]
		public virtual void Reset()
		{
		}

		[Token(Token = "0x6000929")]
		[Address(RVA = "0x13AF25C", Offset = "0x13AF25C", VA = "0x13AF25C")]
		public void ReInitializeLinkedSlots()
		{
		}

		[Token(Token = "0x600092A")]
		[Address(RVA = "0x13A61A4", Offset = "0x13A61A4", VA = "0x13A61A4", Slot = "12")]
		public virtual void OnStateChange()
		{
		}

		[Token(Token = "0x600092B")]
		[Address(RVA = "0x13AF864", Offset = "0x13AF864", VA = "0x13AF864", Slot = "13")]
		public virtual void OnTemplateCreated()
		{
		}

		[Token(Token = "0x600092C")]
		protected static T GetRequestParameter<T>(ref CGDataRequestParameter[] requests) where T : CGDataRequestParameter
		{
			return null;
		}

		[Token(Token = "0x600092D")]
		[Address(RVA = "0x13AF868", Offset = "0x13AF868", VA = "0x13AF868")]
		protected static void RemoveRequestParameter(ref CGDataRequestParameter[] requests, CGDataRequestParameter request)
		{
		}

		[Token(Token = "0x600092E")]
		[Address(RVA = "0x13AF918", Offset = "0x13AF918", VA = "0x13AF918")]
		public CGModuleLink GetOutputLink(CGModuleOutputSlot outSlot, CGModuleInputSlot inSlot)
		{
			return null;
		}

		[Token(Token = "0x600092F")]
		[Address(RVA = "0x13AF9F4", Offset = "0x13AF9F4", VA = "0x13AF9F4")]
		public List<CGModuleLink> GetOutputLinks(CGModuleOutputSlot outSlot)
		{
			return null;
		}

		[Token(Token = "0x6000930")]
		[Address(RVA = "0x13AFB08", Offset = "0x13AFB08", VA = "0x13AFB08")]
		public CGModuleLink GetInputLink(CGModuleInputSlot inSlot, CGModuleOutputSlot outSlot)
		{
			return null;
		}

		[Token(Token = "0x6000931")]
		[Address(RVA = "0x13AFB10", Offset = "0x13AFB10", VA = "0x13AFB10")]
		public List<CGModuleLink> GetInputLinks(CGModuleInputSlot inSlot)
		{
			return null;
		}

		[Token(Token = "0x6000932")]
		[Address(RVA = "0x13AF920", Offset = "0x13AF920", VA = "0x13AF920")]
		private static CGModuleLink GetLink(List<CGModuleLink> lst, CGModuleSlot source, CGModuleSlot target)
		{
			return null;
		}

		[Token(Token = "0x6000933")]
		[Address(RVA = "0x13AF9FC", Offset = "0x13AF9FC", VA = "0x13AF9FC")]
		private static List<CGModuleLink> GetLinks(List<CGModuleLink> lst, CGModuleSlot source)
		{
			return null;
		}

		[Token(Token = "0x6000934")]
		[Address(RVA = "0x13AFCD8", Offset = "0x13AFCD8", VA = "0x13AFCD8")]
		public CGModule CopyTo(CurvyGenerator targetGenerator)
		{
			return null;
		}

		[Token(Token = "0x6000935")]
		[Address(RVA = "0x13AFDF4", Offset = "0x13AFDF4", VA = "0x13AFDF4")]
		public Component AddManagedResource(string resourceName, string context = "", int index = -1)
		{
			return null;
		}

		[Token(Token = "0x6000936")]
		[Address(RVA = "0x13AEF60", Offset = "0x13AEF60", VA = "0x13AEF60")]
		public void DeleteManagedResource(string resourceName, Component res, string context = "", bool dontUsePool = false)
		{
		}

		[Token(Token = "0x6000937")]
		[Address(RVA = "0x13B01EC", Offset = "0x13B01EC", VA = "0x13B01EC")]
		public bool IsManagedResource(Component res)
		{
			return default(bool);
		}

		[Token(Token = "0x6000938")]
		[Address(RVA = "0x13AFF74", Offset = "0x13AFF74", VA = "0x13AFF74")]
		protected void RenameResource(string resourceName, Component resource, int index = -1)
		{
		}

		[Token(Token = "0x6000939")]
		[Address(RVA = "0x13B02D8", Offset = "0x13B02D8", VA = "0x13B02D8")]
		protected PrefabPool GetPrefabPool(GameObject prefab)
		{
			return null;
		}

		[Token(Token = "0x600093A")]
		[Address(RVA = "0x13B0430", Offset = "0x13B0430", VA = "0x13B0430")]
		public List<IPool> GetAllPrefabPools()
		{
			return null;
		}

		[Token(Token = "0x600093B")]
		[Address(RVA = "0x13B0500", Offset = "0x13B0500", VA = "0x13B0500")]
		public void DeleteAllPrefabPools()
		{
		}

		[Token(Token = "0x600093C")]
		[Address(RVA = "0x13B05D0", Offset = "0x13B05D0", VA = "0x13B05D0")]
		public void Delete()
		{
		}

		[Token(Token = "0x600093D")]
		[Address(RVA = "0x13B0674", Offset = "0x13B0674", VA = "0x13B0674")]
		public CGModuleInputSlot GetInputSlot(string name)
		{
			return null;
		}

		[Token(Token = "0x600093E")]
		[Address(RVA = "0x13AF03C", Offset = "0x13AF03C", VA = "0x13AF03C")]
		public List<CGModuleInputSlot> GetInputSlots([Optional] Type filterType)
		{
			return null;
		}

		[Token(Token = "0x600093F")]
		[Address(RVA = "0x13AA610", Offset = "0x13AA610", VA = "0x13AA610")]
		public CGModuleOutputSlot GetOutputSlot(string name)
		{
			return null;
		}

		[Token(Token = "0x6000940")]
		[Address(RVA = "0x13AF358", Offset = "0x13AF358", VA = "0x13AF358")]
		public List<CGModuleOutputSlot> GetOutputSlots([Optional] Type filterType)
		{
			return null;
		}

		[Token(Token = "0x6000941")]
		[Address(RVA = "0x13AEAD0", Offset = "0x13AEAD0", VA = "0x13AEAD0")]
		public bool GetManagedResources(out List<Component> components, out List<string> componentNames)
		{
			return default(bool);
		}

		[Token(Token = "0x6000942")]
		[Address(RVA = "0x13AFDC8", Offset = "0x13AFDC8", VA = "0x13AFDC8")]
		public int SetUniqueIdINTERNAL()
		{
			return default(int);
		}

		[Token(Token = "0x6000943")]
		[Address(RVA = "0x13B0708", Offset = "0x13B0708", VA = "0x13B0708")]
		internal void initializeSort()
		{
		}

		[Token(Token = "0x6000944")]
		[Address(RVA = "0x13B07F0", Offset = "0x13B07F0", VA = "0x13B07F0")]
		internal List<CGModule> decrementChilds()
		{
			return null;
		}

		[Token(Token = "0x6000945")]
		[Address(RVA = "0x13B09D0", Offset = "0x13B09D0", VA = "0x13B09D0")]
		internal void doRefresh()
		{
		}

		[Token(Token = "0x6000946")]
		[Address(RVA = "0x13ADB1C", Offset = "0x13ADB1C", VA = "0x13ADB1C")]
		internal ModuleInfoAttribute getInfo()
		{
			return null;
		}

		[Token(Token = "0x6000947")]
		[Address(RVA = "0x13B0B10", Offset = "0x13B0B10", VA = "0x13B0B10")]
		private bool usesRandom()
		{
			return default(bool);
		}

		[Token(Token = "0x6000948")]
		[Address(RVA = "0x13ADFA0", Offset = "0x13ADFA0", VA = "0x13ADFA0")]
		private void loadSlots()
		{
		}

		[Token(Token = "0x6000949")]
		[Address(RVA = "0x13B0B50", Offset = "0x13B0B50", VA = "0x13B0B50")]
		private SlotInfo getSlotInfo(FieldInfo f)
		{
			return null;
		}

		[Token(Token = "0x600094A")]
		[Address(RVA = "0x13AE924", Offset = "0x13AE924", VA = "0x13AE924")]
		private void setTreeDirtyStateChange()
		{
		}

		[Token(Token = "0x600094B")]
		[Address(RVA = "0x13ADD0C", Offset = "0x13ADD0C", VA = "0x13ADD0C")]
		private CurvyGenerator RetrieveGenerator()
		{
			return null;
		}

		[Token(Token = "0x600094C")]
		[Address(RVA = "0x13B0EF0", Offset = "0x13B0EF0", VA = "0x13B0EF0")]
		public void checkOnStateChangedINTERNAL()
		{
		}

		[Token(Token = "0x600094D")]
		[Address(RVA = "0x13AD7F8", Offset = "0x13AD7F8", VA = "0x13AD7F8")]
		public void renameManagedResourcesINTERNAL()
		{
		}

		[Token(Token = "0x600094E")]
		[Address(RVA = "0x139FBBC", Offset = "0x139FBBC", VA = "0x139FBBC")]
		protected CGModule()
		{
		}
	}
	[Token(Token = "0x20000F4")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x866848", Offset = "0x866848")]
	public sealed class ModuleInfoAttribute : Attribute, IComparable
	{
		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly string MenuName;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string ModuleName;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string Description;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool UsesRandom;

		[Token(Token = "0x600094F")]
		[Address(RVA = "0xDF0928", Offset = "0xDF0928", VA = "0xDF0928")]
		public ModuleInfoAttribute(string name)
		{
		}

		[Token(Token = "0x6000950")]
		[Address(RVA = "0xDF0954", Offset = "0xDF0954", VA = "0xDF0954", Slot = "7")]
		public int CompareTo(object obj)
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x20000F5")]
	public class CGModuleProperties
	{
		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rect Dimensions;

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float MinWidth;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float LabelWidth;

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Color BackgroundColor;

		[Token(Token = "0x6000951")]
		[Address(RVA = "0x13B0F28", Offset = "0x13B0F28", VA = "0x13B0F28")]
		public CGModuleProperties()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000F6")]
	public class CGModuleLink
	{
		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private int m_ModuleID;

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string m_SlotName;

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int m_TargetModuleID;

		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string m_TargetSlotName;

		[Token(Token = "0x170001C7")]
		public int ModuleID
		{
			[Token(Token = "0x6000952")]
			[Address(RVA = "0x13B1D94", Offset = "0x13B1D94", VA = "0x13B1D94")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001C8")]
		public string SlotName
		{
			[Token(Token = "0x6000953")]
			[Address(RVA = "0x13B1D9C", Offset = "0x13B1D9C", VA = "0x13B1D9C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001C9")]
		public int TargetModuleID
		{
			[Token(Token = "0x6000954")]
			[Address(RVA = "0x13B1DA4", Offset = "0x13B1DA4", VA = "0x13B1DA4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001CA")]
		public string TargetSlotName
		{
			[Token(Token = "0x6000955")]
			[Address(RVA = "0x13B1DAC", Offset = "0x13B1DAC", VA = "0x13B1DAC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000956")]
		[Address(RVA = "0x13B1DB4", Offset = "0x13B1DB4", VA = "0x13B1DB4")]
		public CGModuleLink(int sourceID, string sourceSlotName, int targetID, string targetSlotName)
		{
		}

		[Token(Token = "0x6000957")]
		[Address(RVA = "0x13B12B4", Offset = "0x13B12B4", VA = "0x13B12B4")]
		public CGModuleLink(CGModuleSlot source, CGModuleSlot target)
		{
		}

		[Token(Token = "0x6000958")]
		[Address(RVA = "0x13B1E64", Offset = "0x13B1E64", VA = "0x13B1E64")]
		public bool IsSame(CGModuleLink o)
		{
			return default(bool);
		}

		[Token(Token = "0x6000959")]
		[Address(RVA = "0x13AFB18", Offset = "0x13AFB18", VA = "0x13AFB18")]
		public bool IsSame(CGModuleSlot source, CGModuleSlot target)
		{
			return default(bool);
		}

		[Token(Token = "0x600095A")]
		[Address(RVA = "0x13B1EDC", Offset = "0x13B1EDC", VA = "0x13B1EDC")]
		public bool IsTo(CGModuleSlot s)
		{
			return default(bool);
		}

		[Token(Token = "0x600095B")]
		[Address(RVA = "0x13AFC34", Offset = "0x13AFC34", VA = "0x13AFC34")]
		public bool IsFrom(CGModuleSlot s)
		{
			return default(bool);
		}

		[Token(Token = "0x600095C")]
		[Address(RVA = "0x13B1F80", Offset = "0x13B1F80", VA = "0x13B1F80")]
		public bool IsUsing(CGModule module)
		{
			return default(bool);
		}

		[Token(Token = "0x600095D")]
		[Address(RVA = "0x13B1FB8", Offset = "0x13B1FB8", VA = "0x13B1FB8")]
		public bool IsBetween(CGModuleSlot one, CGModuleSlot another)
		{
			return default(bool);
		}

		[Token(Token = "0x600095E")]
		[Address(RVA = "0x13B2030", Offset = "0x13B2030", VA = "0x13B2030")]
		public void SetModuleIDIINTERNAL(int moduleID, int targetModuleID)
		{
		}

		[Token(Token = "0x600095F")]
		[Address(RVA = "0x13B12A8", Offset = "0x13B12A8", VA = "0x13B12A8")]
		public static implicit operator bool(CGModuleLink a)
		{
			return default(bool);
		}

		[Token(Token = "0x6000960")]
		[Address(RVA = "0x13B203C", Offset = "0x13B203C", VA = "0x13B203C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x20000F7")]
	public class CGModuleSlot
	{
		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86D69C", Offset = "0x86D69C")]
		private CGModule <Module>k__BackingField;

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86D6AC", Offset = "0x86D6AC")]
		private SlotInfo <Info>k__BackingField;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86D6BC", Offset = "0x86D6BC")]
		private Vector2 <Origin>k__BackingField;

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86D6CC", Offset = "0x86D6CC")]
		private Rect <DropZone>k__BackingField;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected List<CGModuleSlot> mLinkedSlots;

		[Token(Token = "0x170001CB")]
		public CGModule Module
		{
			[Token(Token = "0x6000961")]
			[Address(RVA = "0x13B2710", Offset = "0x13B2710", VA = "0x13B2710")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8774B0", Offset = "0x8774B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000962")]
			[Address(RVA = "0x13B2718", Offset = "0x13B2718", VA = "0x13B2718")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8774C0", Offset = "0x8774C0")]
			internal set
			{
			}
		}

		[Token(Token = "0x170001CC")]
		public SlotInfo Info
		{
			[Token(Token = "0x6000963")]
			[Address(RVA = "0x13B2720", Offset = "0x13B2720", VA = "0x13B2720")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8774D0", Offset = "0x8774D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000964")]
			[Address(RVA = "0x13B2728", Offset = "0x13B2728", VA = "0x13B2728")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8774E0", Offset = "0x8774E0")]
			internal set
			{
			}
		}

		[Token(Token = "0x170001CD")]
		public Vector2 Origin
		{
			[Token(Token = "0x6000965")]
			[Address(RVA = "0x13B2730", Offset = "0x13B2730", VA = "0x13B2730")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8774F0", Offset = "0x8774F0")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000966")]
			[Address(RVA = "0x13B2738", Offset = "0x13B2738", VA = "0x13B2738")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x877500", Offset = "0x877500")]
			set
			{
			}
		}

		[Token(Token = "0x170001CE")]
		public Rect DropZone
		{
			[Token(Token = "0x6000967")]
			[Address(RVA = "0x13B2740", Offset = "0x13B2740", VA = "0x13B2740")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x877510", Offset = "0x877510")]
			get
			{
				return default(Rect);
			}
			[Token(Token = "0x6000968")]
			[Address(RVA = "0x13B274C", Offset = "0x13B274C", VA = "0x13B274C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x877520", Offset = "0x877520")]
			set
			{
			}
		}

		[Token(Token = "0x170001CF")]
		public bool IsLinked
		{
			[Token(Token = "0x6000969")]
			[Address(RVA = "0x13A0AEC", Offset = "0x13A0AEC", VA = "0x13A0AEC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001D0")]
		public bool IsLinkedAndConfigured
		{
			[Token(Token = "0x600096A")]
			[Address(RVA = "0x13B2758", Offset = "0x13B2758", VA = "0x13B2758")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001D1")]
		public IOnRequestProcessing OnRequestModule
		{
			[Token(Token = "0x600096B")]
			[Address(RVA = "0x13B1B9C", Offset = "0x13B1B9C", VA = "0x13B1B9C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001D2")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x878950", Offset = "0x878950")]
		public IOnRequestPath OnRequestPathModule
		{
			[Token(Token = "0x600096C")]
			[Address(RVA = "0x13B2834", Offset = "0x13B2834", VA = "0x13B2834")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001D3")]
		public IPathProvider PathProvider
		{
			[Token(Token = "0x600096D")]
			[Address(RVA = "0x139F35C", Offset = "0x139F35C", VA = "0x139F35C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001D4")]
		public IExternalInput ExternalInput
		{
			[Token(Token = "0x600096E")]
			[Address(RVA = "0x13A098C", Offset = "0x13A098C", VA = "0x13A098C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001D5")]
		public List<CGModuleSlot> LinkedSlots
		{
			[Token(Token = "0x600096F")]
			[Address(RVA = "0x13A1F30", Offset = "0x13A1F30", VA = "0x13A1F30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001D6")]
		public int Count
		{
			[Token(Token = "0x6000970")]
			[Address(RVA = "0x13AF800", Offset = "0x13AF800", VA = "0x13AF800")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001D7")]
		public string Name
		{
			[Token(Token = "0x6000971")]
			[Address(RVA = "0x13B1E08", Offset = "0x13B1E08", VA = "0x13B1E08")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000972")]
		[Address(RVA = "0x13B0F64", Offset = "0x13B0F64", VA = "0x13B0F64")]
		public CGModuleSlot()
		{
		}

		[Token(Token = "0x6000973")]
		[Address(RVA = "0x13B14F8", Offset = "0x13B14F8", VA = "0x13B14F8")]
		public bool HasLinkTo(CGModuleSlot other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000974")]
		[Address(RVA = "0x13ADC14", Offset = "0x13ADC14", VA = "0x13ADC14")]
		public List<CGModule> GetLinkedModules()
		{
			return null;
		}

		[Token(Token = "0x6000975")]
		[Address(RVA = "0x13B1760", Offset = "0x13B1760", VA = "0x13B1760", Slot = "4")]
		public virtual void LinkTo(CGModuleSlot other)
		{
		}

		[Token(Token = "0x6000976")]
		[Address(RVA = "0x13B15B8", Offset = "0x13B15B8", VA = "0x13B15B8")]
		protected static void LinkInputAndOutput(CGModuleSlot inputSlot, CGModuleSlot outputSlot)
		{
		}

		[Token(Token = "0x6000977")]
		[Address(RVA = "0x13B19BC", Offset = "0x13B19BC", VA = "0x13B19BC", Slot = "5")]
		public virtual void UnlinkFrom(CGModuleSlot other)
		{
		}

		[Token(Token = "0x6000978")]
		[Address(RVA = "0x13B2884", Offset = "0x13B2884", VA = "0x13B2884", Slot = "6")]
		public virtual void UnlinkAll()
		{
		}

		[Token(Token = "0x6000979")]
		[Address(RVA = "0x13AF85C", Offset = "0x13AF85C", VA = "0x13AF85C")]
		public void ReInitializeLinkedSlots()
		{
		}

		[Token(Token = "0x600097A")]
		[Address(RVA = "0x13B12A4", Offset = "0x13B12A4", VA = "0x13B12A4", Slot = "7")]
		protected virtual void LoadLinkedSlots()
		{
		}

		[Token(Token = "0x600097B")]
		[Address(RVA = "0x13B2888", Offset = "0x13B2888", VA = "0x13B2888")]
		public static implicit operator bool(CGModuleSlot a)
		{
			return default(bool);
		}

		[Token(Token = "0x600097C")]
		[Address(RVA = "0x13B2894", Offset = "0x13B2894", VA = "0x13B2894", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x20000F8")]
	public class CGModuleInputSlot : CGModuleSlot
	{
		[Token(Token = "0x170001D8")]
		public InputSlotInfo InputInfo
		{
			[Token(Token = "0x600097D")]
			[Address(RVA = "0x13AF798", Offset = "0x13AF798", VA = "0x13AF798")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600097E")]
		[Address(RVA = "0x139FB54", Offset = "0x139FB54", VA = "0x139FB54")]
		public CGModuleInputSlot()
		{
		}

		[Token(Token = "0x600097F")]
		[Address(RVA = "0x13B0F6C", Offset = "0x13B0F6C", VA = "0x13B0F6C", Slot = "7")]
		protected override void LoadLinkedSlots()
		{
		}

		[Token(Token = "0x6000980")]
		[Address(RVA = "0x13B137C", Offset = "0x13B137C", VA = "0x13B137C", Slot = "6")]
		public override void UnlinkAll()
		{
		}

		[Token(Token = "0x6000981")]
		[Address(RVA = "0x13B14B0", Offset = "0x13B14B0", VA = "0x13B14B0", Slot = "4")]
		public override void LinkTo(CGModuleSlot outputSlot)
		{
		}

		[Token(Token = "0x6000982")]
		[Address(RVA = "0x13B1858", Offset = "0x13B1858", VA = "0x13B1858", Slot = "5")]
		public override void UnlinkFrom(CGModuleSlot outputSlot)
		{
		}

		[Token(Token = "0x6000983")]
		[Address(RVA = "0x139F284", Offset = "0x139F284", VA = "0x139F284")]
		public CGModuleOutputSlot SourceSlot(int index = 0)
		{
			return null;
		}

		[Token(Token = "0x6000984")]
		[Address(RVA = "0x13B1AB4", Offset = "0x13B1AB4", VA = "0x13B1AB4")]
		public bool CanLinkTo(CGModuleOutputSlot source)
		{
			return default(bool);
		}

		[Token(Token = "0x6000985")]
		[Address(RVA = "0x13B1C70", Offset = "0x13B1C70", VA = "0x13B1C70")]
		public static bool AreInputAndOutputSlotsCompatible(InputSlotInfo inputSlotInfo, bool inputSlotModuleIsOnRequest, OutputSlotInfo outputSlotInfo, bool outputSlotModuleIsOnRequest)
		{
			return default(bool);
		}

		[Token(Token = "0x6000986")]
		[Address(RVA = "0x13B1CF0", Offset = "0x13B1CF0", VA = "0x13B1CF0")]
		private CGModule SourceModule(int index)
		{
			return null;
		}

		[Token(Token = "0x6000987")]
		public T GetData<T>(params CGDataRequestParameter[] requests) where T : CGData
		{
			return null;
		}

		[Token(Token = "0x6000988")]
		public List<T> GetAllData<T>(params CGDataRequestParameter[] requests) where T : CGData
		{
			return null;
		}

		[Token(Token = "0x6000989")]
		private CGData[] GetData<T>(int slotIndex, params CGDataRequestParameter[] requests) where T : CGData
		{
			return null;
		}

		[Token(Token = "0x600098A")]
		private static CGData[] cloneData<T>(ref CGData[] source) where T : CGData
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x20000F9")]
	public class CGModuleOutputSlot : CGModuleSlot
	{
		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public CGData[] Data;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public CGDataRequestParameter[] LastRequestParameters;

		[Token(Token = "0x170001D9")]
		public OutputSlotInfo OutputInfo
		{
			[Token(Token = "0x600098B")]
			[Address(RVA = "0x13B1BEC", Offset = "0x13B1BEC", VA = "0x13B1BEC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001DA")]
		public bool HasData
		{
			[Token(Token = "0x6000990")]
			[Address(RVA = "0x13B26D0", Offset = "0x13B26D0", VA = "0x13B26D0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600098C")]
		[Address(RVA = "0x139FB5C", Offset = "0x139FB5C", VA = "0x139FB5C")]
		public CGModuleOutputSlot()
		{
		}

		[Token(Token = "0x600098D")]
		[Address(RVA = "0x13B21EC", Offset = "0x13B21EC", VA = "0x13B21EC", Slot = "7")]
		protected override void LoadLinkedSlots()
		{
		}

		[Token(Token = "0x600098E")]
		[Address(RVA = "0x13B2524", Offset = "0x13B2524", VA = "0x13B2524", Slot = "4")]
		public override void LinkTo(CGModuleSlot inputSlot)
		{
		}

		[Token(Token = "0x600098F")]
		[Address(RVA = "0x13B256C", Offset = "0x13B256C", VA = "0x13B256C", Slot = "5")]
		public override void UnlinkFrom(CGModuleSlot inputSlot)
		{
		}

		[Token(Token = "0x6000991")]
		[Address(RVA = "0x139F6D8", Offset = "0x139F6D8", VA = "0x139F6D8")]
		public void ClearData()
		{
		}

		[Token(Token = "0x6000992")]
		public void SetData<T>(List<T> data) where T : CGData
		{
		}

		[Token(Token = "0x6000993")]
		[Address(RVA = "0x139FA3C", Offset = "0x139FA3C", VA = "0x139FA3C")]
		public void SetData(params CGData[] data)
		{
		}

		[Token(Token = "0x6000994")]
		public T GetData<T>() where T : CGData
		{
			return null;
		}

		[Token(Token = "0x6000995")]
		public T[] GetAllData<T>() where T : CGData
		{
			return null;
		}
	}
	[Token(Token = "0x20000FA")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x86685C", Offset = "0x86685C")]
	public class SlotInfo : Attribute, IComparable
	{
		[Token(Token = "0x2000195")]
		public enum SlotArrayType
		{
			[Token(Token = "0x40006C0")]
			Unknown,
			[Token(Token = "0x40006C1")]
			Normal,
			[Token(Token = "0x40006C2")]
			Hidden
		}

		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly Type[] DataTypes;

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string Name;

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string displayName;

		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string Tooltip;

		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool Array;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public SlotArrayType ArrayType;

		[Token(Token = "0x170001DB")]
		public string DisplayName
		{
			[Token(Token = "0x6000996")]
			[Address(RVA = "0xB15DD4", Offset = "0xB15DD4", VA = "0xB15DD4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000997")]
			[Address(RVA = "0xB15DEC", Offset = "0xB15DEC", VA = "0xB15DEC")]
			set
			{
			}
		}

		[Token(Token = "0x6000998")]
		[Address(RVA = "0xB15DF4", Offset = "0xB15DF4", VA = "0xB15DF4")]
		protected SlotInfo(string name, params Type[] type)
		{
		}

		[Token(Token = "0x6000999")]
		[Address(RVA = "0xB15E34", Offset = "0xB15E34", VA = "0xB15E34")]
		protected SlotInfo(params Type[] type)
		{
		}

		[Token(Token = "0x600099A")]
		[Address(RVA = "0xB15E68", Offset = "0xB15E68", VA = "0xB15E68", Slot = "7")]
		public int CompareTo(object obj)
		{
			return default(int);
		}
	}
	[Token(Token = "0x20000FB")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x866870", Offset = "0x866870")]
	public sealed class InputSlotInfo : SlotInfo
	{
		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool RequestDataOnly;

		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		public bool Optional;

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
		public bool ModifiesData;

		[Token(Token = "0x600099B")]
		[Address(RVA = "0x145DE88", Offset = "0x145DE88", VA = "0x145DE88")]
		public InputSlotInfo(string name, params Type[] type)
		{
		}

		[Token(Token = "0x600099C")]
		[Address(RVA = "0x145DE90", Offset = "0x145DE90", VA = "0x145DE90")]
		public InputSlotInfo(params Type[] type)
		{
		}

		[Token(Token = "0x600099D")]
		[Address(RVA = "0x145DEA0", Offset = "0x145DEA0", VA = "0x145DEA0")]
		public bool IsValidFrom(Type outType)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000FC")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x8668A4", Offset = "0x8668A4")]
	public class OutputSlotInfo : SlotInfo
	{
		[Token(Token = "0x170001DC")]
		public Type DataType
		{
			[Token(Token = "0x600099E")]
			[Address(RVA = "0xDF54D4", Offset = "0xDF54D4", VA = "0xDF54D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600099F")]
		[Address(RVA = "0xDF5508", Offset = "0xDF5508", VA = "0xDF5508")]
		public OutputSlotInfo(Type type)
		{
		}

		[Token(Token = "0x60009A0")]
		[Address(RVA = "0xDF5514", Offset = "0xDF5514", VA = "0xDF5514")]
		public OutputSlotInfo(string name, Type type)
		{
		}
	}
	[Token(Token = "0x20000FD")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x8668D8", Offset = "0x8668D8")]
	public class ShapeOutputSlotInfo : OutputSlotInfo
	{
		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool OutputsVariableShape;

		[Token(Token = "0x60009A1")]
		[Address(RVA = "0xB15C40", Offset = "0xB15C40", VA = "0xB15C40")]
		public ShapeOutputSlotInfo()
		{
		}

		[Token(Token = "0x60009A2")]
		[Address(RVA = "0xB15C48", Offset = "0xB15C48", VA = "0xB15C48")]
		public ShapeOutputSlotInfo(string name)
		{
		}
	}
	[Token(Token = "0x20000FE")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x86690C", Offset = "0x86690C")]
	public sealed class ResourceLoaderAttribute : Attribute
	{
		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly string ResourceName;

		[Token(Token = "0x60009A3")]
		[Address(RVA = "0xDFC6A4", Offset = "0xDFC6A4", VA = "0xDFC6A4")]
		public ResourceLoaderAttribute(string resName)
		{
		}
	}
	[Token(Token = "0x20000FF")]
	public static class CGResourceHandler
	{
		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Dictionary<string, ICGResourceLoader> Loader;

		[Token(Token = "0x60009A4")]
		[Address(RVA = "0x109B940", Offset = "0x109B940", VA = "0x109B940")]
		public static Component CreateResource(CGModule module, string resName, string context)
		{
			return null;
		}

		[Token(Token = "0x60009A5")]
		[Address(RVA = "0x109BDE0", Offset = "0x109BDE0", VA = "0x109BDE0")]
		public static void DestroyResource(CGModule module, string resName, Component obj, string context, bool kill)
		{
		}

		[Token(Token = "0x60009A6")]
		[Address(RVA = "0x109BB50", Offset = "0x109BB50", VA = "0x109BB50")]
		private static void getLoaders()
		{
		}
	}
	[Token(Token = "0x2000100")]
	[AttributeAttribute(Name = "ResourceLoaderAttribute", RVA = "0x866920", Offset = "0x866920")]
	public class CGSplineResourceLoader : ICGResourceLoader
	{
		[Token(Token = "0x60009A8")]
		[Address(RVA = "0x109D0D8", Offset = "0x109D0D8", VA = "0x109D0D8", Slot = "4")]
		public Component Create(CGModule cgModule, string context)
		{
			return null;
		}

		[Token(Token = "0x60009A9")]
		[Address(RVA = "0x109D21C", Offset = "0x109D21C", VA = "0x109D21C", Slot = "5")]
		public void Destroy(CGModule cgModule, Component obj, string context, bool kill)
		{
		}

		[Token(Token = "0x60009AA")]
		[Address(RVA = "0x109D2BC", Offset = "0x109D2BC", VA = "0x109D2BC")]
		public CGSplineResourceLoader()
		{
		}
	}
	[Token(Token = "0x2000101")]
	[AttributeAttribute(Name = "ResourceLoaderAttribute", RVA = "0x866958", Offset = "0x866958")]
	public class CGShapeResourceLoader : ICGResourceLoader
	{
		[Token(Token = "0x60009AB")]
		[Address(RVA = "0x109CF18", Offset = "0x109CF18", VA = "0x109CF18", Slot = "4")]
		public Component Create(CGModule cgModule, string context)
		{
			return null;
		}

		[Token(Token = "0x60009AC")]
		[Address(RVA = "0x109D030", Offset = "0x109D030", VA = "0x109D030", Slot = "5")]
		public void Destroy(CGModule cgModule, Component obj, string context, bool kill)
		{
		}

		[Token(Token = "0x60009AD")]
		[Address(RVA = "0x109D0D0", Offset = "0x109D0D0", VA = "0x109D0D0")]
		public CGShapeResourceLoader()
		{
		}
	}
	[Token(Token = "0x2000102")]
	[AttributeAttribute(Name = "ResourceLoaderAttribute", RVA = "0x866990", Offset = "0x866990")]
	public class CGMeshResourceLoader : ICGResourceLoader
	{
		[Token(Token = "0x60009AE")]
		[Address(RVA = "0x13AD38C", Offset = "0x13AD38C", VA = "0x13AD38C", Slot = "4")]
		public Component Create(CGModule cgModule, string context)
		{
			return null;
		}

		[Token(Token = "0x60009AF")]
		[Address(RVA = "0x13AD404", Offset = "0x13AD404", VA = "0x13AD404", Slot = "5")]
		public void Destroy(CGModule cgModule, Component obj, string context, bool kill)
		{
		}

		[Token(Token = "0x60009B0")]
		[Address(RVA = "0x13AD680", Offset = "0x13AD680", VA = "0x13AD680")]
		public CGMeshResourceLoader()
		{
		}
	}
	[Token(Token = "0x2000103")]
	[AttributeAttribute(Name = "ResourceLoaderAttribute", RVA = "0x8669C8", Offset = "0x8669C8")]
	public class CGGameObjectResourceLoader : ICGResourceLoader
	{
		[Token(Token = "0x60009B1")]
		[Address(RVA = "0x13ABD30", Offset = "0x13ABD30", VA = "0x13ABD30", Slot = "4")]
		public Component Create(CGModule cgModule, string context)
		{
			return null;
		}

		[Token(Token = "0x60009B2")]
		[Address(RVA = "0x13ABE98", Offset = "0x13ABE98", VA = "0x13ABE98", Slot = "5")]
		public void Destroy(CGModule cgModule, Component obj, string context, bool kill)
		{
		}

		[Token(Token = "0x60009B3")]
		[Address(RVA = "0x13AC0B0", Offset = "0x13AC0B0", VA = "0x13AC0B0")]
		public CGGameObjectResourceLoader()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000104")]
	public class CGGameObjectResourceCollection : ICGResourceCollection
	{
		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<Transform> Items;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<string> PoolNames;

		[Token(Token = "0x170001DD")]
		public int Count
		{
			[Token(Token = "0x60009B4")]
			[Address(RVA = "0x13ABBF0", Offset = "0x13ABBF0", VA = "0x13ABBF0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001DE")]
		public Component[] ItemsArray
		{
			[Token(Token = "0x60009B5")]
			[Address(RVA = "0x13ABC40", Offset = "0x13ABC40", VA = "0x13ABC40", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60009B6")]
		[Address(RVA = "0x13ABC98", Offset = "0x13ABC98", VA = "0x13ABC98")]
		public CGGameObjectResourceCollection()
		{
		}
	}
	[Token(Token = "0x2000105")]
	public static class CGUtility
	{
		[Token(Token = "0x60009B7")]
		[Address(RVA = "0x109DB9C", Offset = "0x109DB9C", VA = "0x109DB9C")]
		public static Vector2[] CalculateUV2(Vector2[] uv)
		{
			return null;
		}

		[Token(Token = "0x60009B8")]
		[Address(RVA = "0x109DCC0", Offset = "0x109DCC0", VA = "0x109DCC0")]
		public static List<ControlPointOption> GetControlPointsWithOptions(CGDataRequestMetaCGOptions options, CurvySpline shape, float startDist, float endDist, bool optimize, out int initialMaterialID, out float initialMaxStep)
		{
			return null;
		}
	}
	[Token(Token = "0x2000106")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x866A00", Offset = "0x866A00")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x866A00", Offset = "0x866A00")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x866A00", Offset = "0x866A00")]
	public class CurvyGenerator : DTVersionedMonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000196")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x867B5C", Offset = "0x867B5C")]
		private sealed class <>c
		{
			[Token(Token = "0x40006C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40006C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<CGModule, bool> <>9__46_0;

			[Token(Token = "0x40006C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<CGModule, float> <>9__46_1;

			[Token(Token = "0x40006C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Func<CGModuleInputSlot, IEnumerable<CGModule>> <>9__65_0;

			[Token(Token = "0x40006C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static Func<CGModule, float> <>9__65_1;

			[Token(Token = "0x40006C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public static Func<CGModuleInputSlot, IEnumerable<CGModule>> <>9__66_0;

			[Token(Token = "0x6000D79")]
			[Address(RVA = "0x1816690", Offset = "0x1816690", VA = "0x1816690")]
			public <>c()
			{
			}

			[Token(Token = "0x6000D7A")]
			[Address(RVA = "0x1816698", Offset = "0x1816698", VA = "0x1816698")]
			internal bool <ReorderModules>b__46_0(CGModule m)
			{
				return default(bool);
			}

			[Token(Token = "0x6000D7B")]
			[Address(RVA = "0x18166FC", Offset = "0x18166FC", VA = "0x18166FC")]
			internal float <ReorderModules>b__46_1(CGModule m)
			{
				return default(float);
			}

			[Token(Token = "0x6000D7C")]
			[Address(RVA = "0x1816724", Offset = "0x1816724", VA = "0x1816724")]
			internal IEnumerable<CGModule> <ReorderEndpointRecursiveInputs>b__65_0(CGModuleInputSlot i)
			{
				return null;
			}

			[Token(Token = "0x6000D7D")]
			[Address(RVA = "0x1816740", Offset = "0x1816740", VA = "0x1816740")]
			internal float <ReorderEndpointRecursiveInputs>b__65_1(CGModule m)
			{
				return default(float);
			}

			[Token(Token = "0x6000D7E")]
			[Address(RVA = "0x1816768", Offset = "0x1816768", VA = "0x1816768")]
			internal IEnumerable<CGModule> <UpdateModulesRecursiveInputs>b__66_0(CGModuleInputSlot i)
			{
				return null;
			}
		}

		[Token(Token = "0x2000197")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x867B6C", Offset = "0x867B6C")]
		private sealed class <>c__DisplayClass66_0
		{
			[Token(Token = "0x40006C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Dictionary<CGModule, HashSet<CGModule>> modulesRecursiveInputs;

			[Token(Token = "0x6000D7F")]
			[Address(RVA = "0x1816784", Offset = "0x1816784", VA = "0x1816784")]
			public <>c__DisplayClass66_0()
			{
			}

			[Token(Token = "0x6000D80")]
			[Address(RVA = "0x181678C", Offset = "0x181678C", VA = "0x181678C")]
			internal IEnumerable<CGModule> <UpdateModulesRecursiveInputs>b__1(CGModule i)
			{
				return null;
			}
		}

		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86D6DC", Offset = "0x86D6DC")]
		[SerializeField]
		private bool m_ShowDebug;

		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86D728", Offset = "0x86D728")]
		[SerializeField]
		private bool m_AutoRefresh;

		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x86D774", Offset = "0x86D774")]
		[Positive]
		[SerializeField]
		private int m_RefreshDelay;

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x86D84C", Offset = "0x86D84C")]
		[Positive]
		[SerializeField]
		private int m_RefreshDelayEditor;

		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x86D924", Offset = "0x86D924")]
		[SerializeField]
		protected CurvyCGEvent m_OnRefresh;

		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[HideInInspector]
		public List<CGModule> Modules;

		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[HideInInspector]
		internal int m_LastModuleID;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86D9D4", Offset = "0x86D9D4")]
		private bool <Destroying>k__BackingField;

		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Dictionary<int, CGModule> ModulesByID;

		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool mInitialized;

		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		private bool mInitializedPhaseOne;

		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x52")]
		private bool mNeedSort;

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private double mLastUpdateTime;

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private PoolManager mPoolManager;

		[Token(Token = "0x40003E3")]
		private const int ModulesReorderingDeltaX = 50;

		[Token(Token = "0x40003E4")]
		private const int ModulesReorderingDeltaY = 20;

		[Token(Token = "0x170001DF")]
		public bool ShowDebug
		{
			[Token(Token = "0x60009B9")]
			[Address(RVA = "0x15B9214", Offset = "0x15B9214", VA = "0x15B9214")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60009BA")]
			[Address(RVA = "0x15B921C", Offset = "0x15B921C", VA = "0x15B921C")]
			set
			{
			}
		}

		[Token(Token = "0x170001E0")]
		public bool AutoRefresh
		{
			[Token(Token = "0x60009BB")]
			[Address(RVA = "0x15B923C", Offset = "0x15B923C", VA = "0x15B923C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60009BC")]
			[Address(RVA = "0x15B9244", Offset = "0x15B9244", VA = "0x15B9244")]
			set
			{
			}
		}

		[Token(Token = "0x170001E1")]
		public int RefreshDelay
		{
			[Token(Token = "0x60009BD")]
			[Address(RVA = "0x15B9264", Offset = "0x15B9264", VA = "0x15B9264")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60009BE")]
			[Address(RVA = "0x15B926C", Offset = "0x15B926C", VA = "0x15B926C")]
			set
			{
			}
		}

		[Token(Token = "0x170001E2")]
		public int RefreshDelayEditor
		{
			[Token(Token = "0x60009BF")]
			[Address(RVA = "0x15B92F8", Offset = "0x15B92F8", VA = "0x15B92F8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60009C0")]
			[Address(RVA = "0x15B9300", Offset = "0x15B9300", VA = "0x15B9300")]
			set
			{
			}
		}

		[Token(Token = "0x170001E3")]
		public PoolManager PoolManager
		{
			[Token(Token = "0x60009C1")]
			[Address(RVA = "0x15B938C", Offset = "0x15B938C", VA = "0x15B938C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001E4")]
		public CurvyCGEvent OnRefresh
		{
			[Token(Token = "0x60009C2")]
			[Address(RVA = "0x15B9424", Offset = "0x15B9424", VA = "0x15B9424")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009C3")]
			[Address(RVA = "0x15B942C", Offset = "0x15B942C", VA = "0x15B942C")]
			set
			{
			}
		}

		[Token(Token = "0x170001E5")]
		public bool IsInitialized
		{
			[Token(Token = "0x60009C4")]
			[Address(RVA = "0x15B9440", Offset = "0x15B9440", VA = "0x15B9440")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001E6")]
		public bool Destroying
		{
			[Token(Token = "0x60009C5")]
			[Address(RVA = "0x15B9448", Offset = "0x15B9448", VA = "0x15B9448")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x877530", Offset = "0x877530")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60009C6")]
			[Address(RVA = "0x15B9450", Offset = "0x15B9450", VA = "0x15B9450")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x877540", Offset = "0x877540")]
			private set
			{
			}
		}

		[Token(Token = "0x60009C7")]
		[Address(RVA = "0x15B945C", Offset = "0x15B945C", VA = "0x15B945C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60009C8")]
		[Address(RVA = "0x15B9480", Offset = "0x15B9480", VA = "0x15B9480")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60009C9")]
		[Address(RVA = "0x15B9490", Offset = "0x15B9490", VA = "0x15B9490")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60009CA")]
		[Address(RVA = "0x15B949C", Offset = "0x15B949C", VA = "0x15B949C")]
		private void Update()
		{
		}

		[Token(Token = "0x60009CB")]
		[Address(RVA = "0x15B9928", Offset = "0x15B9928", VA = "0x15B9928")]
		public static CurvyGenerator Create()
		{
			return null;
		}

		[Token(Token = "0x60009CC")]
		public T AddModule<T>() where T : CGModule
		{
			return null;
		}

		[Token(Token = "0x60009CD")]
		[Address(RVA = "0x15B9A40", Offset = "0x15B9A40", VA = "0x15B9A40")]
		public CGModule AddModule(Type type)
		{
			return null;
		}

		[Token(Token = "0x60009CE")]
		[Address(RVA = "0x15B9B90", Offset = "0x15B9B90", VA = "0x15B9B90")]
		public void ArrangeModules()
		{
		}

		[Token(Token = "0x60009CF")]
		[Address(RVA = "0x15B9E90", Offset = "0x15B9E90", VA = "0x15B9E90")]
		public void ReorderModules()
		{
		}

		[Token(Token = "0x60009D0")]
		[Address(RVA = "0x15BAA50", Offset = "0x15BAA50", VA = "0x15BAA50")]
		public void Clear()
		{
		}

		[Token(Token = "0x60009D1")]
		[Address(RVA = "0x15BAB68", Offset = "0x15BAB68", VA = "0x15BAB68")]
		public void DeleteModule(CGModule module)
		{
		}

		[Token(Token = "0x60009D2")]
		public List<T> FindModules<T>(bool includeOnRequestProcessing = false) where T : CGModule
		{
			return null;
		}

		[Token(Token = "0x60009D3")]
		[Address(RVA = "0x15BABF4", Offset = "0x15BABF4", VA = "0x15BABF4")]
		public List<CGModule> GetModules(bool includeOnRequestProcessing = false)
		{
			return null;
		}

		[Token(Token = "0x60009D4")]
		[Address(RVA = "0x15BAD44", Offset = "0x15BAD44", VA = "0x15BAD44")]
		public CGModule GetModule(int moduleID, bool includeOnRequestProcessing = false)
		{
			return null;
		}

		[Token(Token = "0x60009D5")]
		public T GetModule<T>(int moduleID, bool includeOnRequestProcessing = false) where T : CGModule
		{
			return null;
		}

		[Token(Token = "0x60009D6")]
		[Address(RVA = "0x15BADF0", Offset = "0x15BADF0", VA = "0x15BADF0")]
		public CGModule GetModule(string moduleName, bool includeOnRequestProcessing = false)
		{
			return null;
		}

		[Token(Token = "0x60009D7")]
		public T GetModule<T>(string moduleName, bool includeOnRequestProcessing = false) where T : CGModule
		{
			return null;
		}

		[Token(Token = "0x60009D8")]
		[Address(RVA = "0x15BAF30", Offset = "0x15BAF30", VA = "0x15BAF30")]
		public CGModuleOutputSlot GetModuleOutputSlot(int moduleId, string slotName)
		{
			return null;
		}

		[Token(Token = "0x60009D9")]
		[Address(RVA = "0x15BAFF0", Offset = "0x15BAFF0", VA = "0x15BAFF0")]
		public CGModuleOutputSlot GetModuleOutputSlot(string moduleName, string slotName)
		{
			return null;
		}

		[Token(Token = "0x60009DA")]
		[Address(RVA = "0x15B94B0", Offset = "0x15B94B0", VA = "0x15B94B0")]
		public void Initialize(bool force = false)
		{
		}

		[Token(Token = "0x60009DB")]
		[Address(RVA = "0x15BB0BC", Offset = "0x15BB0BC", VA = "0x15BB0BC")]
		public void Refresh(bool forceUpdate = false)
		{
		}

		[Token(Token = "0x60009DC")]
		[Address(RVA = "0x15B98A8", Offset = "0x15B98A8", VA = "0x15B98A8")]
		public void TryAutoRefresh()
		{
		}

		[Token(Token = "0x60009DD")]
		[Address(RVA = "0x15BBA84", Offset = "0x15BBA84", VA = "0x15BBA84")]
		protected CurvyCGEventArgs OnRefreshEvent(CurvyCGEventArgs e)
		{
			return null;
		}

		[Token(Token = "0x60009DE")]
		[Address(RVA = "0x15BAA54", Offset = "0x15BAA54", VA = "0x15BAA54")]
		private void clearModules()
		{
		}

		[Token(Token = "0x60009DF")]
		[Address(RVA = "0x15BBAF0", Offset = "0x15BBAF0", VA = "0x15BBAF0")]
		public string getUniqueModuleNameINTERNAL(string name)
		{
			return null;
		}

		[Token(Token = "0x60009E0")]
		[Address(RVA = "0x15BB0B0", Offset = "0x15BB0B0", VA = "0x15BB0B0")]
		internal void sortModulesINTERNAL()
		{
		}

		[Token(Token = "0x60009E1")]
		[Address(RVA = "0x15BB6F0", Offset = "0x15BB6F0", VA = "0x15BB6F0")]
		private bool doSortModules()
		{
			return default(bool);
		}

		[Token(Token = "0x60009E2")]
		[Address(RVA = "0x15BA5E0", Offset = "0x15BA5E0", VA = "0x15BA5E0")]
		private static void ReorderEndpointRecursiveInputs(CGModule endPoint, HashSet<int> reordredModuleIds, Dictionary<CGModule, HashSet<CGModule>> modulesRecursiveInputs)
		{
		}

		[Token(Token = "0x60009E3")]
		[Address(RVA = "0x15BA388", Offset = "0x15BA388", VA = "0x15BA388")]
		private static HashSet<CGModule> UpdateModulesRecursiveInputs(Dictionary<CGModule, HashSet<CGModule>> modulesRecursiveInputs, CGModule moduleToAdd)
		{
			return null;
		}

		[Token(Token = "0x60009E4")]
		[Address(RVA = "0x15BBD08", Offset = "0x15BBD08", VA = "0x15BBD08")]
		public CurvyGenerator()
		{
		}

		[Token(Token = "0x60009E5")]
		[Address(RVA = "0x15BBDDC", Offset = "0x15BBDDC", VA = "0x15BBDDC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x877550", Offset = "0x877550")]
		private bool <Initialize>b__57_0(CGModule m)
		{
			return default(bool);
		}
	}
}
namespace FluffyUnderware.Curvy.Generator.Modules
{
	[Token(Token = "0x2000107")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x866AC0", Offset = "0x866AC0")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x866AC0", Offset = "0x866AC0")]
	public class BuildRasterizedPath : CGModule, IPathProvider
	{
		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x86D9E4", Offset = "0x86D9E4")]
		public CGModuleInputSlot InPath;

		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x86DA9C", Offset = "0x86DA9C")]
		public CGModuleOutputSlot OutPath;

		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[FloatRegion]
		[SerializeField]
		private FloatRegion m_Range;

		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x86DB90", Offset = "0x86DB90")]
		private int m_Resolution;

		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private bool m_Optimize;

		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x86DC0C", Offset = "0x86DC0C")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x86DC0C", Offset = "0x86DC0C")]
		private float m_AngleTreshold;

		[Token(Token = "0x170001E7")]
		public float From
		{
			[Token(Token = "0x60009E6")]
			[Address(RVA = "0x139EB54", Offset = "0x139EB54", VA = "0x139EB54")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60009E7")]
			[Address(RVA = "0x139EB5C", Offset = "0x139EB5C", VA = "0x139EB5C")]
			set
			{
			}
		}

		[Token(Token = "0x170001E8")]
		public float To
		{
			[Token(Token = "0x60009E8")]
			[Address(RVA = "0x139EE70", Offset = "0x139EE70", VA = "0x139EE70")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60009E9")]
			[Address(RVA = "0x139EE78", Offset = "0x139EE78", VA = "0x139EE78")]
			set
			{
			}
		}

		[Token(Token = "0x170001E9")]
		public float Length
		{
			[Token(Token = "0x60009EA")]
			[Address(RVA = "0x139F038", Offset = "0x139F038", VA = "0x139F038")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60009EB")]
			[Address(RVA = "0x139F068", Offset = "0x139F068", VA = "0x139F068")]
			set
			{
			}
		}

		[Token(Token = "0x170001EA")]
		public int Resolution
		{
			[Token(Token = "0x60009EC")]
			[Address(RVA = "0x139F0B8", Offset = "0x139F0B8", VA = "0x139F0B8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60009ED")]
			[Address(RVA = "0x139F0C0", Offset = "0x139F0C0", VA = "0x139F0C0")]
			set
			{
			}
		}

		[Token(Token = "0x170001EB")]
		public bool Optimize
		{
			[Token(Token = "0x60009EE")]
			[Address(RVA = "0x139F158", Offset = "0x139F158", VA = "0x139F158")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60009EF")]
			[Address(RVA = "0x139F160", Offset = "0x139F160", VA = "0x139F160")]
			set
			{
			}
		}

		[Token(Token = "0x170001EC")]
		public float AngleThreshold
		{
			[Token(Token = "0x60009F0")]
			[Address(RVA = "0x139F184", Offset = "0x139F184", VA = "0x139F184")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60009F1")]
			[Address(RVA = "0x139F18C", Offset = "0x139F18C", VA = "0x139F18C")]
			set
			{
			}
		}

		[Token(Token = "0x170001ED")]
		public CGPath Path
		{
			[Token(Token = "0x60009F2")]
			[Address(RVA = "0x139F22C", Offset = "0x139F22C", VA = "0x139F22C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001EE")]
		public bool PathIsClosed
		{
			[Token(Token = "0x60009F3")]
			[Address(RVA = "0x139EF4C", Offset = "0x139EF4C", VA = "0x139EF4C", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001EF")]
		private RegionOptions<float> RangeOptions
		{
			[Token(Token = "0x60009F4")]
			[Address(RVA = "0x139F3AC", Offset = "0x139F3AC", VA = "0x139F3AC")]
			get
			{
				return default(RegionOptions<float>);
			}
		}

		[Token(Token = "0x60009F5")]
		[Address(RVA = "0x139F464", Offset = "0x139F464", VA = "0x139F464", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x60009F6")]
		[Address(RVA = "0x139F540", Offset = "0x139F540", VA = "0x139F540", Slot = "11")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60009F7")]
		[Address(RVA = "0x139F730", Offset = "0x139F730", VA = "0x139F730", Slot = "10")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x60009F8")]
		[Address(RVA = "0x139FAB8", Offset = "0x139FAB8", VA = "0x139FAB8")]
		public BuildRasterizedPath()
		{
		}
	}
	[Token(Token = "0x2000108")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x866B40", Offset = "0x866B40")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x866B40", Offset = "0x866B40")]
	public class BuildShapeExtrusion : CGModule, IPathProvider
	{
		[Token(Token = "0x2000198")]
		public enum ScaleModeEnum
		{
			[Token(Token = "0x40006CB")]
			Simple,
			[Token(Token = "0x40006CC")]
			Advanced
		}

		[Token(Token = "0x2000199")]
		public enum CrossShiftModeEnum
		{
			[Token(Token = "0x40006CE")]
			None,
			[Token(Token = "0x40006CF")]
			ByOrientation,
			[Token(Token = "0x40006D0")]
			Custom
		}

		[Serializable]
		[Token(Token = "0x200019A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x867B7C", Offset = "0x867B7C")]
		private sealed class <>c
		{
			[Token(Token = "0x40006D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40006D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<CGShape, int> <>9__152_0;

			[Token(Token = "0x6000D82")]
			[Address(RVA = "0x1815DF0", Offset = "0x1815DF0", VA = "0x1815DF0")]
			public <>c()
			{
			}

			[Token(Token = "0x6000D83")]
			[Address(RVA = "0x1815DF8", Offset = "0x1815DF8", VA = "0x1815DF8")]
			internal int <Refresh>b__152_0(CGShape c)
			{
				return default(int);
			}
		}

		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x86DD08", Offset = "0x86DD08")]
		public CGModuleInputSlot InPath;

		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x86DDB0", Offset = "0x86DDB0")]
		public CGModuleInputSlot InCross;

		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x86DE64", Offset = "0x86DE64")]
		public CGModuleOutputSlot OutVolume;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x86DED8", Offset = "0x86DED8")]
		public CGModuleOutputSlot OutVolumeHollow;

		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x86DF4C", Offset = "0x86DF4C")]
		[FloatRegion]
		[SerializeField]
		private FloatRegion m_Range;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x86DFCC", Offset = "0x86DFCC")]
		private int m_Resolution;

		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private bool m_Optimize;

		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x86E048", Offset = "0x86E048")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x86E048", Offset = "0x86E048")]
		private float m_AngleThreshold;

		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x86E154", Offset = "0x86E154")]
		[AttributeAttribute(Name = "FieldActionAttribute", RVA = "0x86E154", Offset = "0x86E154")]
		[FloatRegion]
		[SerializeField]
		private FloatRegion m_CrossRange;

		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x86E200", Offset = "0x86E200")]
		private int m_CrossResolution;

		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x86E280", Offset = "0x86E280")]
		private bool m_CrossOptimize;

		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x86E2E0", Offset = "0x86E2E0")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x86E2E0", Offset = "0x86E2E0")]
		private float m_CrossAngleThreshold;

		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x86E3EC", Offset = "0x86E3EC")]
		private bool m_CrossIncludeControlpoints;

		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF9")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x86E44C", Offset = "0x86E44C")]
		private bool m_CrossHardEdges;

		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFA")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x86E4AC", Offset = "0x86E4AC")]
		private bool m_CrossMaterials;

		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFB")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x86E50C", Offset = "0x86E50C")]
		private bool m_CrossExtendedUV;

		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x86E56C", Offset = "0x86E56C")]
		private CrossShiftModeEnum m_CrossShiftMode;

		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x86E5E0", Offset = "0x86E5E0")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x86E5E0", Offset = "0x86E5E0")]
		private float m_CrossShiftValue;

		[Token(Token = "0x40003FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x86E6DC", Offset = "0x86E6DC")]
		[SerializeField]
		private bool m_CrossReverseNormals;

		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x86E744", Offset = "0x86E744")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x86E744", Offset = "0x86E744")]
		[SerializeField]
		private ScaleModeEnum m_ScaleMode;

		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x86E7D0", Offset = "0x86E7D0")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x86E7D0", Offset = "0x86E7D0")]
		[SerializeField]
		private CGReferenceMode m_ScaleReference;

		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x86E8BC", Offset = "0x86E8BC")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x86E8BC", Offset = "0x86E8BC")]
		[SerializeField]
		private float m_ScaleOffset;

		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x86E9A8", Offset = "0x86E9A8")]
		private bool m_ScaleUniform;

		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[SerializeField]
		private float m_ScaleX;

		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x86EA2C", Offset = "0x86EA2C")]
		private float m_ScaleY;

		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x86EADC", Offset = "0x86EADC")]
		[AttributeAttribute(Name = "AnimationCurveExAttribute", RVA = "0x86EADC", Offset = "0x86EADC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86EADC", Offset = "0x86EADC")]
		private AnimationCurve m_ScaleCurveX;

		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x86EBEC", Offset = "0x86EBEC")]
		[AttributeAttribute(Name = "AnimationCurveExAttribute", RVA = "0x86EBEC", Offset = "0x86EBEC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86EBEC", Offset = "0x86EBEC")]
		private AnimationCurve m_ScaleCurveY;

		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x86ED40", Offset = "0x86ED40")]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x86ED40", Offset = "0x86ED40")]
		[SerializeField]
		private float m_HollowInset;

		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x86EDEC", Offset = "0x86EDEC")]
		[SerializeField]
		private bool m_HollowReverseNormals;

		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86EE54", Offset = "0x86EE54")]
		private int <PathSamples>k__BackingField;

		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86EE64", Offset = "0x86EE64")]
		private int <CrossSamples>k__BackingField;

		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86EE74", Offset = "0x86EE74")]
		private int <CrossGroups>k__BackingField;

		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86EE84", Offset = "0x86EE84")]
		private Vector3 <CrossPosition>k__BackingField;

		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86EE94", Offset = "0x86EE94")]
		private Quaternion <CrossRotation>k__BackingField;

		[Token(Token = "0x170001F0")]
		public float From
		{
			[Token(Token = "0x60009F9")]
			[Address(RVA = "0x139FD20", Offset = "0x139FD20", VA = "0x139FD20")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60009FA")]
			[Address(RVA = "0x139FD28", Offset = "0x139FD28", VA = "0x139FD28")]
			set
			{
			}
		}

		[Token(Token = "0x170001F1")]
		public float To
		{
			[Token(Token = "0x60009FB")]
			[Address(RVA = "0x139FDBC", Offset = "0x139FDBC", VA = "0x139FDBC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60009FC")]
			[Address(RVA = "0x139FDC4", Offset = "0x139FDC4", VA = "0x139FDC4")]
			set
			{
			}
		}

		[Token(Token = "0x170001F2")]
		public float Length
		{
			[Token(Token = "0x60009FD")]
			[Address(RVA = "0x139FF6C", Offset = "0x139FF6C", VA = "0x139FF6C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60009FE")]
			[Address(RVA = "0x139FF9C", Offset = "0x139FF9C", VA = "0x139FF9C")]
			set
			{
			}
		}

		[Token(Token = "0x170001F3")]
		public int Resolution
		{
			[Token(Token = "0x60009FF")]
			[Address(RVA = "0x139FFEC", Offset = "0x139FFEC", VA = "0x139FFEC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000A00")]
			[Address(RVA = "0x139FFF4", Offset = "0x139FFF4", VA = "0x139FFF4")]
			set
			{
			}
		}

		[Token(Token = "0x170001F4")]
		public bool Optimize
		{
			[Token(Token = "0x6000A01")]
			[Address(RVA = "0x13A008C", Offset = "0x13A008C", VA = "0x13A008C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A02")]
			[Address(RVA = "0x13A0094", Offset = "0x13A0094", VA = "0x13A0094")]
			set
			{
			}
		}

		[Token(Token = "0x170001F5")]
		public float AngleThreshold
		{
			[Token(Token = "0x6000A03")]
			[Address(RVA = "0x13A00B8", Offset = "0x13A00B8", VA = "0x13A00B8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000A04")]
			[Address(RVA = "0x13A00C0", Offset = "0x13A00C0", VA = "0x13A00C0")]
			set
			{
			}
		}

		[Token(Token = "0x170001F6")]
		public float CrossFrom
		{
			[Token(Token = "0x6000A05")]
			[Address(RVA = "0x13A0160", Offset = "0x13A0160", VA = "0x13A0160")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000A06")]
			[Address(RVA = "0x13A0168", Offset = "0x13A0168", VA = "0x13A0168")]
			set
			{
			}
		}

		[Token(Token = "0x170001F7")]
		public float CrossTo
		{
			[Token(Token = "0x6000A07")]
			[Address(RVA = "0x13A01FC", Offset = "0x13A01FC", VA = "0x13A01FC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000A08")]
			[Address(RVA = "0x13A0204", Offset = "0x13A0204", VA = "0x13A0204")]
			set
			{
			}
		}

		[Token(Token = "0x170001F8")]
		public float CrossLength
		{
			[Token(Token = "0x6000A09")]
			[Address(RVA = "0x13A03AC", Offset = "0x13A03AC", VA = "0x13A03AC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000A0A")]
			[Address(RVA = "0x13A03DC", Offset = "0x13A03DC", VA = "0x13A03DC")]
			set
			{
			}
		}

		[Token(Token = "0x170001F9")]
		public int CrossResolution
		{
			[Token(Token = "0x6000A0B")]
			[Address(RVA = "0x13A042C", Offset = "0x13A042C", VA = "0x13A042C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000A0C")]
			[Address(RVA = "0x13A0434", Offset = "0x13A0434", VA = "0x13A0434")]
			set
			{
			}
		}

		[Token(Token = "0x170001FA")]
		public bool CrossOptimize
		{
			[Token(Token = "0x6000A0D")]
			[Address(RVA = "0x13A04CC", Offset = "0x13A04CC", VA = "0x13A04CC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A0E")]
			[Address(RVA = "0x13A04D4", Offset = "0x13A04D4", VA = "0x13A04D4")]
			set
			{
			}
		}

		[Token(Token = "0x170001FB")]
		public float CrossAngleThreshold
		{
			[Token(Token = "0x6000A0F")]
			[Address(RVA = "0x13A04F8", Offset = "0x13A04F8", VA = "0x13A04F8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000A10")]
			[Address(RVA = "0x13A0500", Offset = "0x13A0500", VA = "0x13A0500")]
			set
			{
			}
		}

		[Token(Token = "0x170001FC")]
		public bool CrossIncludeControlPoints
		{
			[Token(Token = "0x6000A11")]
			[Address(RVA = "0x13A05A0", Offset = "0x13A05A0", VA = "0x13A05A0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A12")]
			[Address(RVA = "0x13A05A8", Offset = "0x13A05A8", VA = "0x13A05A8")]
			set
			{
			}
		}

		[Token(Token = "0x170001FD")]
		public bool CrossHardEdges
		{
			[Token(Token = "0x6000A13")]
			[Address(RVA = "0x13A05CC", Offset = "0x13A05CC", VA = "0x13A05CC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A14")]
			[Address(RVA = "0x13A05D4", Offset = "0x13A05D4", VA = "0x13A05D4")]
			set
			{
			}
		}

		[Token(Token = "0x170001FE")]
		public bool CrossMaterials
		{
			[Token(Token = "0x6000A15")]
			[Address(RVA = "0x13A05F8", Offset = "0x13A05F8", VA = "0x13A05F8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A16")]
			[Address(RVA = "0x13A0600", Offset = "0x13A0600", VA = "0x13A0600")]
			set
			{
			}
		}

		[Token(Token = "0x170001FF")]
		public bool CrossExtendedUV
		{
			[Token(Token = "0x6000A17")]
			[Address(RVA = "0x13A0624", Offset = "0x13A0624", VA = "0x13A0624")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A18")]
			[Address(RVA = "0x13A062C", Offset = "0x13A062C", VA = "0x13A062C")]
			set
			{
			}
		}

		[Token(Token = "0x17000200")]
		public CrossShiftModeEnum CrossShiftMode
		{
			[Token(Token = "0x6000A19")]
			[Address(RVA = "0x13A0650", Offset = "0x13A0650", VA = "0x13A0650")]
			get
			{
				return default(CrossShiftModeEnum);
			}
			[Token(Token = "0x6000A1A")]
			[Address(RVA = "0x13A0658", Offset = "0x13A0658", VA = "0x13A0658")]
			set
			{
			}
		}

		[Token(Token = "0x17000201")]
		public float CrossShiftValue
		{
			[Token(Token = "0x6000A1B")]
			[Address(RVA = "0x13A0670", Offset = "0x13A0670", VA = "0x13A0670")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000A1C")]
			[Address(RVA = "0x13A0678", Offset = "0x13A0678", VA = "0x13A0678")]
			set
			{
			}
		}

		[Token(Token = "0x17000202")]
		public bool CrossReverseNormals
		{
			[Token(Token = "0x6000A1D")]
			[Address(RVA = "0x13A070C", Offset = "0x13A070C", VA = "0x13A070C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A1E")]
			[Address(RVA = "0x13A0714", Offset = "0x13A0714", VA = "0x13A0714")]
			set
			{
			}
		}

		[Token(Token = "0x17000203")]
		public ScaleModeEnum ScaleMode
		{
			[Token(Token = "0x6000A1F")]
			[Address(RVA = "0x13A0738", Offset = "0x13A0738", VA = "0x13A0738")]
			get
			{
				return default(ScaleModeEnum);
			}
			[Token(Token = "0x6000A20")]
			[Address(RVA = "0x13A0740", Offset = "0x13A0740", VA = "0x13A0740")]
			set
			{
			}
		}

		[Token(Token = "0x17000204")]
		public CGReferenceMode ScaleReference
		{
			[Token(Token = "0x6000A21")]
			[Address(RVA = "0x13A0758", Offset = "0x13A0758", VA = "0x13A0758")]
			get
			{
				return default(CGReferenceMode);
			}
			[Token(Token = "0x6000A22")]
			[Address(RVA = "0x13A0760", Offset = "0x13A0760", VA = "0x13A0760")]
			set
			{
			}
		}

		[Token(Token = "0x17000205")]
		public bool ScaleUniform
		{
			[Token(Token = "0x6000A23")]
			[Address(RVA = "0x13A0778", Offset = "0x13A0778", VA = "0x13A0778")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A24")]
			[Address(RVA = "0x13A0780", Offset = "0x13A0780", VA = "0x13A0780")]
			set
			{
			}
		}

		[Token(Token = "0x17000206")]
		public float ScaleOffset
		{
			[Token(Token = "0x6000A25")]
			[Address(RVA = "0x13A07A4", Offset = "0x13A07A4", VA = "0x13A07A4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000A26")]
			[Address(RVA = "0x13A07AC", Offset = "0x13A07AC", VA = "0x13A07AC")]
			set
			{
			}
		}

		[Token(Token = "0x17000207")]
		public float ScaleX
		{
			[Token(Token = "0x6000A27")]
			[Address(RVA = "0x13A07C4", Offset = "0x13A07C4", VA = "0x13A07C4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000A28")]
			[Address(RVA = "0x13A07CC", Offset = "0x13A07CC", VA = "0x13A07CC")]
			set
			{
			}
		}

		[Token(Token = "0x17000208")]
		public float ScaleY
		{
			[Token(Token = "0x6000A29")]
			[Address(RVA = "0x13A07E4", Offset = "0x13A07E4", VA = "0x13A07E4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000A2A")]
			[Address(RVA = "0x13A07EC", Offset = "0x13A07EC", VA = "0x13A07EC")]
			set
			{
			}
		}

		[Token(Token = "0x17000209")]
		public AnimationCurve ScaleMultiplierX
		{
			[Token(Token = "0x6000A2B")]
			[Address(RVA = "0x13A0804", Offset = "0x13A0804", VA = "0x13A0804")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A2C")]
			[Address(RVA = "0x13A080C", Offset = "0x13A080C", VA = "0x13A080C")]
			set
			{
			}
		}

		[Token(Token = "0x1700020A")]
		public AnimationCurve ScaleMultiplierY
		{
			[Token(Token = "0x6000A2D")]
			[Address(RVA = "0x13A0824", Offset = "0x13A0824", VA = "0x13A0824")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A2E")]
			[Address(RVA = "0x13A082C", Offset = "0x13A082C", VA = "0x13A082C")]
			set
			{
			}
		}

		[Token(Token = "0x1700020B")]
		public float HollowInset
		{
			[Token(Token = "0x6000A2F")]
			[Address(RVA = "0x13A0844", Offset = "0x13A0844", VA = "0x13A0844")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000A30")]
			[Address(RVA = "0x13A084C", Offset = "0x13A084C", VA = "0x13A084C")]
			set
			{
			}
		}

		[Token(Token = "0x1700020C")]
		public bool HollowReverseNormals
		{
			[Token(Token = "0x6000A31")]
			[Address(RVA = "0x13A08DC", Offset = "0x13A08DC", VA = "0x13A08DC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A32")]
			[Address(RVA = "0x13A08E4", Offset = "0x13A08E4", VA = "0x13A08E4")]
			set
			{
			}
		}

		[Token(Token = "0x1700020D")]
		public int PathSamples
		{
			[Token(Token = "0x6000A33")]
			[Address(RVA = "0x13A0908", Offset = "0x13A0908", VA = "0x13A0908")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x877560", Offset = "0x877560")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000A34")]
			[Address(RVA = "0x13A0910", Offset = "0x13A0910", VA = "0x13A0910")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x877570", Offset = "0x877570")]
			private set
			{
			}
		}

		[Token(Token = "0x1700020E")]
		public int CrossSamples
		{
			[Token(Token = "0x6000A35")]
			[Address(RVA = "0x13A0918", Offset = "0x13A0918", VA = "0x13A0918")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x877580", Offset = "0x877580")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000A36")]
			[Address(RVA = "0x13A0920", Offset = "0x13A0920", VA = "0x13A0920")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x877590", Offset = "0x877590")]
			private set
			{
			}
		}

		[Token(Token = "0x1700020F")]
		public int CrossGroups
		{
			[Token(Token = "0x6000A37")]
			[Address(RVA = "0x13A0928", Offset = "0x13A0928", VA = "0x13A0928")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8775A0", Offset = "0x8775A0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000A38")]
			[Address(RVA = "0x13A0930", Offset = "0x13A0930", VA = "0x13A0930")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8775B0", Offset = "0x8775B0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000210")]
		public IExternalInput Cross
		{
			[Token(Token = "0x6000A39")]
			[Address(RVA = "0x13A0938", Offset = "0x13A0938", VA = "0x13A0938")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000211")]
		public Vector3 CrossPosition
		{
			[Token(Token = "0x6000A3A")]
			[Address(RVA = "0x13A09DC", Offset = "0x13A09DC", VA = "0x13A09DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8775C0", Offset = "0x8775C0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000A3B")]
			[Address(RVA = "0x13A09EC", Offset = "0x13A09EC", VA = "0x13A09EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8775D0", Offset = "0x8775D0")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000212")]
		public Quaternion CrossRotation
		{
			[Token(Token = "0x6000A3C")]
			[Address(RVA = "0x13A09FC", Offset = "0x13A09FC", VA = "0x13A09FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8775E0", Offset = "0x8775E0")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x6000A3D")]
			[Address(RVA = "0x13A0A10", Offset = "0x13A0A10", VA = "0x13A0A10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8775F0", Offset = "0x8775F0")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000213")]
		public bool PathIsClosed
		{
			[Token(Token = "0x6000A3E")]
			[Address(RVA = "0x13A0A24", Offset = "0x13A0A24", VA = "0x13A0A24", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000214")]
		private bool ClampPath
		{
			[Token(Token = "0x6000A3F")]
			[Address(RVA = "0x139FE80", Offset = "0x139FE80", VA = "0x139FE80")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000215")]
		private bool ClampCross
		{
			[Token(Token = "0x6000A40")]
			[Address(RVA = "0x13A02C0", Offset = "0x13A02C0", VA = "0x13A02C0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000216")]
		private RegionOptions<float> RangeOptions
		{
			[Token(Token = "0x6000A41")]
			[Address(RVA = "0x13A0B54", Offset = "0x13A0B54", VA = "0x13A0B54")]
			get
			{
				return default(RegionOptions<float>);
			}
		}

		[Token(Token = "0x17000217")]
		private RegionOptions<float> CrossRangeOptions
		{
			[Token(Token = "0x6000A42")]
			[Address(RVA = "0x13A0C0C", Offset = "0x13A0C0C", VA = "0x13A0C0C")]
			get
			{
				return default(RegionOptions<float>);
			}
		}

		[Token(Token = "0x6000A43")]
		[Address(RVA = "0x13A0CC4", Offset = "0x13A0CC4", VA = "0x13A0CC4", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000A44")]
		[Address(RVA = "0x13A0D08", Offset = "0x13A0D08", VA = "0x13A0D08", Slot = "11")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000A45")]
		[Address(RVA = "0x13A0F9C", Offset = "0x13A0F9C", VA = "0x13A0F9C", Slot = "10")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x6000A46")]
		[Address(RVA = "0x13A2108", Offset = "0x13A2108", VA = "0x13A2108")]
		public Vector3 GetScale(float f)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000A47")]
		[Address(RVA = "0x13A2058", Offset = "0x13A2058", VA = "0x13A2058")]
		private void getScaleInternal(float f, Vector3 baseScale, ref Vector3 scale)
		{
		}

		[Token(Token = "0x6000A48")]
		[Address(RVA = "0x13A21D4", Offset = "0x13A21D4", VA = "0x13A21D4")]
		public BuildShapeExtrusion()
		{
		}
	}
	[Token(Token = "0x2000109")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x866BC0", Offset = "0x866BC0")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x866BC0", Offset = "0x866BC0")]
	public class BuildVolumeCaps : CGModule
	{
		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x86EEA4", Offset = "0x86EEA4")]
		public CGModuleInputSlot InVolume;

		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x86EF34", Offset = "0x86EF34")]
		public CGModuleInputSlot InVolumeHoles;

		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x86EFE0", Offset = "0x86EFE0")]
		public CGModuleOutputSlot OutVMesh;

		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x870060", Offset = "0x870060")]
		[SerializeField]
		private CGYesNoAuto m_StartCap;

		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[SerializeField]
		private CGYesNoAuto m_EndCap;

		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x8700BC", Offset = "0x8700BC")]
		private bool m_ReverseTriOrder;

		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC9")]
		[SerializeField]
		private bool m_GenerateUV;

		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x870118", Offset = "0x870118")]
		[Inline]
		[SerializeField]
		private CGMaterialSettings m_StartMaterialSettings;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x870174", Offset = "0x870174")]
		[SerializeField]
		private Material m_StartMaterial;

		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x8701DC", Offset = "0x8701DC")]
		[SerializeField]
		private bool m_CloneStartCap;

		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "AsGroupAttribute", RVA = "0x870228", Offset = "0x870228")]
		[AttributeAttribute(Name = "GroupConditionAttribute", RVA = "0x870228", Offset = "0x870228")]
		[SerializeField]
		private CGMaterialSettings m_EndMaterialSettings;

		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x8702EC", Offset = "0x8702EC")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x8702EC", Offset = "0x8702EC")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x8702EC", Offset = "0x8702EC")]
		[SerializeField]
		private Material m_EndMaterial;

		[Token(Token = "0x17000218")]
		public bool GenerateUV
		{
			[Token(Token = "0x6000A49")]
			[Address(RVA = "0x13A231C", Offset = "0x13A231C", VA = "0x13A231C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A4A")]
			[Address(RVA = "0x13A2324", Offset = "0x13A2324", VA = "0x13A2324")]
			set
			{
			}
		}

		[Token(Token = "0x17000219")]
		public bool ReverseTriOrder
		{
			[Token(Token = "0x6000A4B")]
			[Address(RVA = "0x13A2348", Offset = "0x13A2348", VA = "0x13A2348")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A4C")]
			[Address(RVA = "0x13A2350", Offset = "0x13A2350", VA = "0x13A2350")]
			set
			{
			}
		}

		[Token(Token = "0x1700021A")]
		public CGYesNoAuto StartCap
		{
			[Token(Token = "0x6000A4D")]
			[Address(RVA = "0x13A2374", Offset = "0x13A2374", VA = "0x13A2374")]
			get
			{
				return default(CGYesNoAuto);
			}
			[Token(Token = "0x6000A4E")]
			[Address(RVA = "0x13A237C", Offset = "0x13A237C", VA = "0x13A237C")]
			set
			{
			}
		}

		[Token(Token = "0x1700021B")]
		public Material StartMaterial
		{
			[Token(Token = "0x6000A4F")]
			[Address(RVA = "0x13A2394", Offset = "0x13A2394", VA = "0x13A2394")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A50")]
			[Address(RVA = "0x13A239C", Offset = "0x13A239C", VA = "0x13A239C")]
			set
			{
			}
		}

		[Token(Token = "0x1700021C")]
		public CGMaterialSettings StartMaterialSettings
		{
			[Token(Token = "0x6000A51")]
			[Address(RVA = "0x13A242C", Offset = "0x13A242C", VA = "0x13A242C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700021D")]
		public CGYesNoAuto EndCap
		{
			[Token(Token = "0x6000A52")]
			[Address(RVA = "0x13A2434", Offset = "0x13A2434", VA = "0x13A2434")]
			get
			{
				return default(CGYesNoAuto);
			}
			[Token(Token = "0x6000A53")]
			[Address(RVA = "0x13A243C", Offset = "0x13A243C", VA = "0x13A243C")]
			set
			{
			}
		}

		[Token(Token = "0x1700021E")]
		public bool CloneStartCap
		{
			[Token(Token = "0x6000A54")]
			[Address(RVA = "0x13A2454", Offset = "0x13A2454", VA = "0x13A2454")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A55")]
			[Address(RVA = "0x13A245C", Offset = "0x13A245C", VA = "0x13A245C")]
			set
			{
			}
		}

		[Token(Token = "0x1700021F")]
		public CGMaterialSettings EndMaterialSettings
		{
			[Token(Token = "0x6000A56")]
			[Address(RVA = "0x13A2480", Offset = "0x13A2480", VA = "0x13A2480")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000220")]
		public Material EndMaterial
		{
			[Token(Token = "0x6000A57")]
			[Address(RVA = "0x13A2488", Offset = "0x13A2488", VA = "0x13A2488")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A58")]
			[Address(RVA = "0x13A2490", Offset = "0x13A2490", VA = "0x13A2490")]
			set
			{
			}
		}

		[Token(Token = "0x6000A59")]
		[Address(RVA = "0x13A2520", Offset = "0x13A2520", VA = "0x13A2520", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000A5A")]
		[Address(RVA = "0x13A2634", Offset = "0x13A2634", VA = "0x13A2634", Slot = "11")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000A5B")]
		[Address(RVA = "0x13A27E8", Offset = "0x13A27E8", VA = "0x13A27E8", Slot = "10")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x6000A5C")]
		[Address(RVA = "0x13A3368", Offset = "0x13A3368", VA = "0x13A3368")]
		private static Matrix4x4 getMatrix(CGVolume vol, int index, bool inverse)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x6000A5D")]
		[Address(RVA = "0x13A3894", Offset = "0x13A3894", VA = "0x13A3894")]
		private static void flipTris(ref int[] indices, int start, int end)
		{
		}

		[Token(Token = "0x6000A5E")]
		[Address(RVA = "0x13A3648", Offset = "0x13A3648", VA = "0x13A3648")]
		private static Vector3[] applyMatrix(Vector3[] vt, Matrix4x4 matrix, out Bounds bounds)
		{
			return null;
		}

		[Token(Token = "0x6000A5F")]
		[Address(RVA = "0x13A31DC", Offset = "0x13A31DC", VA = "0x13A31DC")]
		private static ContourVertex[] make2DSegment(CGVolume vol, int segmentIndex)
		{
			return null;
		}

		[Token(Token = "0x6000A60")]
		[Address(RVA = "0x13A391C", Offset = "0x13A391C", VA = "0x13A391C")]
		private static void applyUV(Vector3[] vts, ref Vector2[] uvArray, int index, int count, CGMaterialSettings mat, Bounds bounds)
		{
		}

		[Token(Token = "0x6000A61")]
		[Address(RVA = "0x13A3C38", Offset = "0x13A3C38", VA = "0x13A3C38")]
		public BuildVolumeCaps()
		{
		}
	}
	[Token(Token = "0x200010A")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x866C40", Offset = "0x866C40")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x866C40", Offset = "0x866C40")]
	public class BuildVolumeMesh : CGModule
	{
		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x8703F8", Offset = "0x8703F8")]
		public CGModuleInputSlot InVolume;

		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x870488", Offset = "0x870488")]
		public CGModuleOutputSlot OutVMesh;

		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x870508", Offset = "0x870508")]
		[SerializeField]
		private bool m_GenerateUV;

		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB9")]
		[SerializeField]
		private bool m_Split;

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		[Positive]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x870564", Offset = "0x870564")]
		[SerializeField]
		private float m_SplitLength;

		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "FieldActionAttribute", RVA = "0x870634", Offset = "0x870634")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x870634", Offset = "0x870634")]
		private bool m_ReverseTriOrder;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[HideInInspector]
		private List<CGMaterialSettingsEx> m_MaterialSettings;

		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[HideInInspector]
		private Material[] m_Material;

		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private List<SamplePointsMaterialGroupCollection> groupsByMatID;

		[Token(Token = "0x17000221")]
		public bool GenerateUV
		{
			[Token(Token = "0x6000A62")]
			[Address(RVA = "0x13A3D1C", Offset = "0x13A3D1C", VA = "0x13A3D1C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A63")]
			[Address(RVA = "0x13A3D24", Offset = "0x13A3D24", VA = "0x13A3D24")]
			set
			{
			}
		}

		[Token(Token = "0x17000222")]
		public bool ReverseTriOrder
		{
			[Token(Token = "0x6000A64")]
			[Address(RVA = "0x13A3D48", Offset = "0x13A3D48", VA = "0x13A3D48")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A65")]
			[Address(RVA = "0x13A3D50", Offset = "0x13A3D50", VA = "0x13A3D50")]
			set
			{
			}
		}

		[Token(Token = "0x17000223")]
		public bool Split
		{
			[Token(Token = "0x6000A66")]
			[Address(RVA = "0x13A3D74", Offset = "0x13A3D74", VA = "0x13A3D74")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A67")]
			[Address(RVA = "0x13A3D7C", Offset = "0x13A3D7C", VA = "0x13A3D7C")]
			set
			{
			}
		}

		[Token(Token = "0x17000224")]
		public float SplitLength
		{
			[Token(Token = "0x6000A68")]
			[Address(RVA = "0x13A3DA0", Offset = "0x13A3DA0", VA = "0x13A3DA0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000A69")]
			[Address(RVA = "0x13A3DA8", Offset = "0x13A3DA8", VA = "0x13A3DA8")]
			set
			{
			}
		}

		[Token(Token = "0x17000225")]
		public List<CGMaterialSettingsEx> MaterialSetttings
		{
			[Token(Token = "0x6000A6A")]
			[Address(RVA = "0x13A3E3C", Offset = "0x13A3E3C", VA = "0x13A3E3C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000226")]
		public int MaterialCount
		{
			[Token(Token = "0x6000A6B")]
			[Address(RVA = "0x13A3E44", Offset = "0x13A3E44", VA = "0x13A3E44")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000A6C")]
		[Address(RVA = "0x13A3E94", Offset = "0x13A3E94", VA = "0x13A3E94", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000A6D")]
		[Address(RVA = "0x13A3F90", Offset = "0x13A3F90", VA = "0x13A3F90", Slot = "11")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000A6E")]
		[Address(RVA = "0x13A4134", Offset = "0x13A4134", VA = "0x13A4134", Slot = "10")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x6000A6F")]
		[Address(RVA = "0x13A3ED4", Offset = "0x13A3ED4", VA = "0x13A3ED4")]
		public int AddMaterial()
		{
			return default(int);
		}

		[Token(Token = "0x6000A70")]
		[Address(RVA = "0x13A499C", Offset = "0x13A499C", VA = "0x13A499C")]
		public void RemoveMaterial(int index)
		{
		}

		[Token(Token = "0x6000A71")]
		[Address(RVA = "0x13A4AF4", Offset = "0x13A4AF4", VA = "0x13A4AF4")]
		public void SetMaterial(int index, Material mat)
		{
		}

		[Token(Token = "0x6000A72")]
		[Address(RVA = "0x13A4C64", Offset = "0x13A4C64", VA = "0x13A4C64")]
		public Material GetMaterial(int index)
		{
			return null;
		}

		[Token(Token = "0x6000A73")]
		[Address(RVA = "0x13A45A8", Offset = "0x13A45A8", VA = "0x13A45A8")]
		private void prepare(CGVolume vol)
		{
		}

		[Token(Token = "0x6000A74")]
		[Address(RVA = "0x13A45CC", Offset = "0x13A45CC", VA = "0x13A45CC")]
		private void build(CGVMesh vmesh, CGVolume vol, IntRegion subset)
		{
		}

		[Token(Token = "0x6000A75")]
		[Address(RVA = "0x13A4FE4", Offset = "0x13A4FE4", VA = "0x13A4FE4")]
		private static void prepareSubMeshes(CGVMesh vmesh, List<SamplePointsMaterialGroupCollection> groupsBySubMeshes, int extrusions, ref Material[] materials)
		{
		}

		[Token(Token = "0x6000A76")]
		[Address(RVA = "0x13A51C8", Offset = "0x13A51C8", VA = "0x13A51C8")]
		private void createMaterialGroupUV(CGVMesh vmesh, CGVolume vol, SamplePointsMaterialGroup grp, int matIndex, float grpAspectCorrection, int sample, int baseVertex)
		{
		}

		[Token(Token = "0x6000A77")]
		[Address(RVA = "0x13A5404", Offset = "0x13A5404", VA = "0x13A5404")]
		private static int createPatchTriangles(ref int[] triangles, ref int triIdx, int curVTIndex, int patchSize, int crossSize, bool reverse)
		{
			return default(int);
		}

		[Token(Token = "0x6000A78")]
		[Address(RVA = "0x13A4CC0", Offset = "0x13A4CC0", VA = "0x13A4CC0")]
		private List<SamplePointsMaterialGroupCollection> getMaterialIDGroups(CGVolume volume)
		{
			return null;
		}

		[Token(Token = "0x6000A79")]
		[Address(RVA = "0x13A4A4C", Offset = "0x13A4A4C", VA = "0x13A4A4C")]
		private bool validateMaterialIndex(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A7A")]
		[Address(RVA = "0x13A5560", Offset = "0x13A5560", VA = "0x13A5560")]
		public BuildVolumeMesh()
		{
		}
	}
	[Token(Token = "0x200010B")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x866CC0", Offset = "0x866CC0")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x866CC0", Offset = "0x866CC0")]
	public class BuildVolumeSpots : CGModule, ISerializationCallbackReceiver
	{
		[Token(Token = "0x200019B")]
		private class EndGroupData
		{
			[Token(Token = "0x40006D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x874FC4", Offset = "0x874FC4")]
			private CGBoundsGroup <BoundsGroup>k__BackingField;

			[Token(Token = "0x40006D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x874FD4", Offset = "0x874FD4")]
			private int[] <ItemIndices>k__BackingField;

			[Token(Token = "0x40006D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x874FE4", Offset = "0x874FE4")]
			private readonly float <GroupDepth>k__BackingField;

			[Token(Token = "0x40006D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x874FF4", Offset = "0x874FF4")]
			private readonly CGBounds[] <ItemBounds>k__BackingField;

			[Token(Token = "0x40006D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x875004", Offset = "0x875004")]
			private readonly float <SpaceBefore>k__BackingField;

			[Token(Token = "0x40006D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x875014", Offset = "0x875014")]
			private readonly float <SpaceAfter>k__BackingField;

			[Token(Token = "0x170002E8")]
			internal CGBoundsGroup BoundsGroup
			{
				[Token(Token = "0x6000D84")]
				[Address(RVA = "0x1815E80", Offset = "0x1815E80", VA = "0x1815E80")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x878438", Offset = "0x878438")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000D85")]
				[Address(RVA = "0x1815E88", Offset = "0x1815E88", VA = "0x1815E88")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x878448", Offset = "0x878448")]
				private set
				{
				}
			}

			[Token(Token = "0x170002E9")]
			internal int[] ItemIndices
			{
				[Token(Token = "0x6000D86")]
				[Address(RVA = "0x1815E90", Offset = "0x1815E90", VA = "0x1815E90")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x878458", Offset = "0x878458")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000D87")]
				[Address(RVA = "0x1815E98", Offset = "0x1815E98", VA = "0x1815E98")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x878468", Offset = "0x878468")]
				private set
				{
				}
			}

			[Token(Token = "0x170002EA")]
			internal float GroupDepth
			{
				[Token(Token = "0x6000D88")]
				[Address(RVA = "0x1815EA0", Offset = "0x1815EA0", VA = "0x1815EA0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x878478", Offset = "0x878478")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x170002EB")]
			internal CGBounds[] ItemBounds
			{
				[Token(Token = "0x6000D89")]
				[Address(RVA = "0x1815EA8", Offset = "0x1815EA8", VA = "0x1815EA8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x878488", Offset = "0x878488")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170002EC")]
			internal float SpaceBefore
			{
				[Token(Token = "0x6000D8A")]
				[Address(RVA = "0x1815EB0", Offset = "0x1815EB0", VA = "0x1815EB0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x878498", Offset = "0x878498")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x170002ED")]
			internal float SpaceAfter
			{
				[Token(Token = "0x6000D8B")]
				[Address(RVA = "0x1815EB8", Offset = "0x1815EB8", VA = "0x1815EB8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8784A8", Offset = "0x8784A8")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x6000D8C")]
			[Address(RVA = "0x1815EC0", Offset = "0x1815EC0", VA = "0x1815EC0")]
			public EndGroupData(CGBoundsGroup boundsGroup, int[] itemIndices, float groupDepth, CGBounds[] itemBounds, float spaceBefore, float spaceAfter)
			{
			}
		}

		[Token(Token = "0x200019C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x867B8C", Offset = "0x867B8C")]
		private sealed class <>c__DisplayClass79_0
		{
			[Token(Token = "0x40006D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public EndGroupData endGroupData;

			[Token(Token = "0x6000D8D")]
			[Address(RVA = "0x1815E18", Offset = "0x1815E18", VA = "0x1815E18")]
			public <>c__DisplayClass79_0()
			{
			}
		}

		[Token(Token = "0x200019D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x867B9C", Offset = "0x867B9C")]
		private sealed class <>c__DisplayClass79_1
		{
			[Token(Token = "0x40006DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float availableSpace;

			[Token(Token = "0x40006DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public <>c__DisplayClass79_0 CS$<>8__locals1;

			[Token(Token = "0x6000D8E")]
			[Address(RVA = "0x1815E20", Offset = "0x1815E20", VA = "0x1815E20")]
			public <>c__DisplayClass79_1()
			{
			}

			[Token(Token = "0x6000D8F")]
			[Address(RVA = "0x1815E28", Offset = "0x1815E28", VA = "0x1815E28")]
			internal bool <Refresh>b__0(CGBounds i)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x870718", Offset = "0x870718")]
		public CGModuleInputSlot InPath;

		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x8707D0", Offset = "0x8707D0")]
		public CGModuleInputSlot InBounds;

		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x870878", Offset = "0x870878")]
		public CGModuleOutputSlot OutSpots;

		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[HideInInspector]
		private bool m_WasUpgraded;

		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x870924", Offset = "0x870924")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x870924", Offset = "0x870924")]
		[FloatRegion]
		[SerializeField]
		private FloatRegion m_Range;

		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x8709CC", Offset = "0x8709CC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8709CC", Offset = "0x8709CC")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x8709CC", Offset = "0x8709CC")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x8709CC", Offset = "0x8709CC")]
		private bool m_UseVolume;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x870AB8", Offset = "0x870AB8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x870AB8", Offset = "0x870AB8")]
		private float m_CrossBase;

		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x870B4C", Offset = "0x870B4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x870B4C", Offset = "0x870B4C")]
		private AnimationCurve m_CrossCurve;

		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x870BD8", Offset = "0x870BD8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x870BD8", Offset = "0x870BD8")]
		[SerializeField]
		private bool m_Simulate;

		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE1")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x870C54", Offset = "0x870C54")]
		private bool m_UseBuggedRNG;

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x870CA0", Offset = "0x870CA0")]
		[ArrayEx]
		[SerializeField]
		private List<CGBoundsGroup> m_Groups;

		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[IntRegion]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x870D08", Offset = "0x870D08")]
		private IntRegion m_RepeatingGroups;

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		[SerializeField]
		private CurvyRepeatingOrderEnum m_RepeatingOrder;

		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x870D94", Offset = "0x870D94")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x870D94", Offset = "0x870D94")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x870D94", Offset = "0x870D94")]
		private bool m_FitEnd;

		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x870EA4", Offset = "0x870EA4")]
		private int <Count>k__BackingField;

		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public CGSpots SimulatedSpots;

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private WeightedRandom<int> mGroupBag;

		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private List<CGBounds> mBounds;

		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x870EB4", Offset = "0x870EB4")]
		private CGPath <Path>k__BackingField;

		[Token(Token = "0x17000227")]
		public FloatRegion Range
		{
			[Token(Token = "0x6000A7B")]
			[Address(RVA = "0x13A5630", Offset = "0x13A5630", VA = "0x13A5630")]
			get
			{
				return default(FloatRegion);
			}
			[Token(Token = "0x6000A7C")]
			[Address(RVA = "0x13A5640", Offset = "0x13A5640", VA = "0x13A5640")]
			set
			{
			}
		}

		[Token(Token = "0x17000228")]
		public bool UseVolume
		{
			[Token(Token = "0x6000A7D")]
			[Address(RVA = "0x13A5698", Offset = "0x13A5698", VA = "0x13A5698")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A7E")]
			[Address(RVA = "0x13A56A0", Offset = "0x13A56A0", VA = "0x13A56A0")]
			set
			{
			}
		}

		[Token(Token = "0x17000229")]
		public bool Simulate
		{
			[Token(Token = "0x6000A7F")]
			[Address(RVA = "0x13A56C4", Offset = "0x13A56C4", VA = "0x13A56C4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A80")]
			[Address(RVA = "0x13A56CC", Offset = "0x13A56CC", VA = "0x13A56CC")]
			set
			{
			}
		}

		[Token(Token = "0x1700022A")]
		public bool UseBuggedRng
		{
			[Token(Token = "0x6000A81")]
			[Address(RVA = "0x13A56F0", Offset = "0x13A56F0", VA = "0x13A56F0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A82")]
			[Address(RVA = "0x13A56F8", Offset = "0x13A56F8", VA = "0x13A56F8")]
			set
			{
			}
		}

		[Token(Token = "0x1700022B")]
		public float CrossBase
		{
			[Token(Token = "0x6000A83")]
			[Address(RVA = "0x13A571C", Offset = "0x13A571C", VA = "0x13A571C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000A84")]
			[Address(RVA = "0x13A5724", Offset = "0x13A5724", VA = "0x13A5724")]
			set
			{
			}
		}

		[Token(Token = "0x1700022C")]
		public AnimationCurve CrossCurve
		{
			[Token(Token = "0x6000A85")]
			[Address(RVA = "0x13A57B8", Offset = "0x13A57B8", VA = "0x13A57B8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A86")]
			[Address(RVA = "0x13A57C0", Offset = "0x13A57C0", VA = "0x13A57C0")]
			set
			{
			}
		}

		[Token(Token = "0x1700022D")]
		public List<CGBoundsGroup> Groups
		{
			[Token(Token = "0x6000A87")]
			[Address(RVA = "0x13A57D8", Offset = "0x13A57D8", VA = "0x13A57D8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A88")]
			[Address(RVA = "0x13A57E0", Offset = "0x13A57E0", VA = "0x13A57E0")]
			set
			{
			}
		}

		[Token(Token = "0x1700022E")]
		public CurvyRepeatingOrderEnum RepeatingOrder
		{
			[Token(Token = "0x6000A89")]
			[Address(RVA = "0x13A57F4", Offset = "0x13A57F4", VA = "0x13A57F4")]
			get
			{
				return default(CurvyRepeatingOrderEnum);
			}
			[Token(Token = "0x6000A8A")]
			[Address(RVA = "0x13A57FC", Offset = "0x13A57FC", VA = "0x13A57FC")]
			set
			{
			}
		}

		[Token(Token = "0x1700022F")]
		public int FirstRepeating
		{
			[Token(Token = "0x6000A8B")]
			[Address(RVA = "0x13A5814", Offset = "0x13A5814", VA = "0x13A5814")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000A8C")]
			[Address(RVA = "0x13A581C", Offset = "0x13A581C", VA = "0x13A581C")]
			set
			{
			}
		}

		[Token(Token = "0x17000230")]
		public int LastRepeating
		{
			[Token(Token = "0x6000A8D")]
			[Address(RVA = "0x13A5924", Offset = "0x13A5924", VA = "0x13A5924")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000A8E")]
			[Address(RVA = "0x13A592C", Offset = "0x13A592C", VA = "0x13A592C")]
			set
			{
			}
		}

		[Token(Token = "0x17000231")]
		public bool FitEnd
		{
			[Token(Token = "0x6000A8F")]
			[Address(RVA = "0x13A59E8", Offset = "0x13A59E8", VA = "0x13A59E8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A90")]
			[Address(RVA = "0x13A59F0", Offset = "0x13A59F0", VA = "0x13A59F0")]
			set
			{
			}
		}

		[Token(Token = "0x17000232")]
		public int GroupCount
		{
			[Token(Token = "0x6000A91")]
			[Address(RVA = "0x13A58D4", Offset = "0x13A58D4", VA = "0x13A58D4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000233")]
		public GUIContent[] BoundsNames
		{
			[Token(Token = "0x6000A92")]
			[Address(RVA = "0x13A5A14", Offset = "0x13A5A14", VA = "0x13A5A14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000234")]
		public int[] BoundsIndices
		{
			[Token(Token = "0x6000A93")]
			[Address(RVA = "0x13A5BF8", Offset = "0x13A5BF8", VA = "0x13A5BF8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000235")]
		public int Count
		{
			[Token(Token = "0x6000A94")]
			[Address(RVA = "0x13A5CB4", Offset = "0x13A5CB4", VA = "0x13A5CB4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x877600", Offset = "0x877600")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000A95")]
			[Address(RVA = "0x13A5CBC", Offset = "0x13A5CBC", VA = "0x13A5CBC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x877610", Offset = "0x877610")]
			private set
			{
			}
		}

		[Token(Token = "0x17000236")]
		private int lastGroupIndex
		{
			[Token(Token = "0x6000A96")]
			[Address(RVA = "0x13A5CC4", Offset = "0x13A5CC4", VA = "0x13A5CC4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000237")]
		private RegionOptions<float> RangeOptions
		{
			[Token(Token = "0x6000A97")]
			[Address(RVA = "0x13A5D40", Offset = "0x13A5D40", VA = "0x13A5D40")]
			get
			{
				return default(RegionOptions<float>);
			}
		}

		[Token(Token = "0x17000238")]
		private RegionOptions<int> RepeatingGroupsOptions
		{
			[Token(Token = "0x6000A98")]
			[Address(RVA = "0x13A5D98", Offset = "0x13A5D98", VA = "0x13A5D98")]
			get
			{
				return default(RegionOptions<int>);
			}
		}

		[Token(Token = "0x17000239")]
		private CGPath Path
		{
			[Token(Token = "0x6000A99")]
			[Address(RVA = "0x13A5E3C", Offset = "0x13A5E3C", VA = "0x13A5E3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x877620", Offset = "0x877620")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A9A")]
			[Address(RVA = "0x13A5E44", Offset = "0x13A5E44", VA = "0x13A5E44")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x877630", Offset = "0x877630")]
			set
			{
			}
		}

		[Token(Token = "0x1700023A")]
		private CGVolume Volume
		{
			[Token(Token = "0x6000A9B")]
			[Address(RVA = "0x13A5E4C", Offset = "0x13A5E4C", VA = "0x13A5E4C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700023B")]
		private float Length
		{
			[Token(Token = "0x6000A9C")]
			[Address(RVA = "0x13A5ED0", Offset = "0x13A5ED0", VA = "0x13A5ED0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700023C")]
		private bool ShowFitEnd
		{
			[Token(Token = "0x6000AAD")]
			[Address(RVA = "0x13A9244", Offset = "0x13A9244", VA = "0x13A9244")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000A9D")]
		[Address(RVA = "0x13A5F0C", Offset = "0x13A5F0C", VA = "0x13A5F0C", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000A9E")]
		[Address(RVA = "0x13A5F40", Offset = "0x13A5F40", VA = "0x13A5F40", Slot = "11")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000A9F")]
		[Address(RVA = "0x13A6160", Offset = "0x13A6160", VA = "0x13A6160", Slot = "12")]
		public override void OnStateChange()
		{
		}

		[Token(Token = "0x6000AA0")]
		[Address(RVA = "0x13A6244", Offset = "0x13A6244", VA = "0x13A6244")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000AA1")]
		[Address(RVA = "0x13A6320", Offset = "0x13A6320", VA = "0x13A6320", Slot = "10")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x6000AA2")]
		[Address(RVA = "0x13A6088", Offset = "0x13A6088", VA = "0x13A6088")]
		public CGBoundsGroup AddGroup(string name)
		{
			return null;
		}

		[Token(Token = "0x6000AA3")]
		[Address(RVA = "0x13A84AC", Offset = "0x13A84AC", VA = "0x13A84AC")]
		public void RemoveGroup(CGBoundsGroup group)
		{
		}

		[Token(Token = "0x6000AA4")]
		[Address(RVA = "0x13A7C48", Offset = "0x13A7C48", VA = "0x13A7C48")]
		private static int[] GetGroupItemIndices(CGBoundsGroup boundsGroup, WeightedRandom<int> groupItemBag)
		{
			return null;
		}

		[Token(Token = "0x6000AA5")]
		[Address(RVA = "0x13A7DEC", Offset = "0x13A7DEC", VA = "0x13A7DEC")]
		private float GetGroupDepth(int[] groupItemIndices, float spaceBefore, float spaceAfter, out CGBounds[] itemsBounds)
		{
			return default(float);
		}

		[Token(Token = "0x6000AA6")]
		[Address(RVA = "0x13A7A90", Offset = "0x13A7A90", VA = "0x13A7A90")]
		private bool AddGroupItems(int groupIndex, ref List<CGSpot> spots, float remainingLength, float startDistance, ref float currentDistance, out bool failedAddingAllItems, Dictionary<CGBoundsGroup, WeightedRandom<int>> itemsBagDictionary, int MaxSpotsCount)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AA7")]
		[Address(RVA = "0x13A7F68", Offset = "0x13A7F68", VA = "0x13A7F68")]
		private void AddGroupItems(CGBoundsGroup group, ref List<CGSpot> spots, float remainingLength, float startDistance, ref float currentDistance, out bool failedAddingAllItems, int[] itemIndices, float groupDepth, CGBounds[] itemBounds, float spaceBefore, float spaceAfter)
		{
		}

		[Token(Token = "0x6000AA8")]
		[Address(RVA = "0x13A8530", Offset = "0x13A8530", VA = "0x13A8530")]
		private CGSpot GetSpot(int itemID, CGBoundsGroup boundsGroup, CGBounds bounds, float currentDistance, float startDistance)
		{
			return default(CGSpot);
		}

		[Token(Token = "0x6000AA9")]
		[Address(RVA = "0x13A7D98", Offset = "0x13A7D98", VA = "0x13A7D98")]
		private static float GetRegionNextValue(FloatRegion floatRegion)
		{
			return default(float);
		}

		[Token(Token = "0x6000AAA")]
		[Address(RVA = "0x13A8F10", Offset = "0x13A8F10", VA = "0x13A8F10")]
		private void GetTRS(CGBoundsGroup boundsGroup, Vector3 tangent, Vector3 up, out Quaternion rotation, out Vector3 translation, out Vector3 scale)
		{
		}

		[Token(Token = "0x6000AAB")]
		[Address(RVA = "0x13A8A70", Offset = "0x13A8A70", VA = "0x13A8A70")]
		private void GetTRS630(CGBoundsGroup boundsGroup, Vector3 tangent, Vector3 up, out Quaternion rotation, out Vector3 translation, out Vector3 scale)
		{
		}

		[Token(Token = "0x6000AAC")]
		[Address(RVA = "0x13A77E0", Offset = "0x13A77E0", VA = "0x13A77E0")]
		private Dictionary<CGBoundsGroup, WeightedRandom<int>> Prepare()
		{
			return null;
		}

		[Token(Token = "0x6000AAE")]
		[Address(RVA = "0x13A92A4", Offset = "0x13A92A4", VA = "0x13A92A4", Slot = "14")]
		public void OnBeforeSerialize()
		{
		}

		[Token(Token = "0x6000AAF")]
		[Address(RVA = "0x13A92A8", Offset = "0x13A92A8", VA = "0x13A92A8", Slot = "15")]
		public void OnAfterDeserialize()
		{
		}

		[Token(Token = "0x6000AB0")]
		[Address(RVA = "0x13A9A7C", Offset = "0x13A9A7C", VA = "0x13A9A7C")]
		public BuildVolumeSpots()
		{
		}
	}
	[Token(Token = "0x200010C")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x866D48", Offset = "0x866D48")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x866D48", Offset = "0x866D48")]
	public class ConformPath : CGModule, IOnRequestPath, IOnRequestProcessing, IPathProvider
	{
		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x870EC4", Offset = "0x870EC4")]
		public CGModuleInputSlot InPath;

		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x870F7C", Offset = "0x870F7C")]
		public CGModuleOutputSlot OutPath;

		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x870FF0", Offset = "0x870FF0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x870FF0", Offset = "0x870FF0")]
		private Vector3 m_Direction;

		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87107C", Offset = "0x87107C")]
		private float m_MaxDistance;

		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8710C8", Offset = "0x8710C8")]
		private float m_Offset;

		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x871114", Offset = "0x871114")]
		private bool m_Warp;

		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x871160", Offset = "0x871160")]
		private LayerMask m_LayerMask;

		[Token(Token = "0x1700023D")]
		public Vector3 Direction
		{
			[Token(Token = "0x6000AB1")]
			[Address(RVA = "0x10A7844", Offset = "0x10A7844", VA = "0x10A7844")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000AB2")]
			[Address(RVA = "0x10A7850", Offset = "0x10A7850", VA = "0x10A7850")]
			set
			{
			}
		}

		[Token(Token = "0x1700023E")]
		public float MaxDistance
		{
			[Token(Token = "0x6000AB3")]
			[Address(RVA = "0x10A7914", Offset = "0x10A7914", VA = "0x10A7914")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000AB4")]
			[Address(RVA = "0x10A791C", Offset = "0x10A791C", VA = "0x10A791C")]
			set
			{
			}
		}

		[Token(Token = "0x1700023F")]
		public float Offset
		{
			[Token(Token = "0x6000AB5")]
			[Address(RVA = "0x10A7938", Offset = "0x10A7938", VA = "0x10A7938")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000AB6")]
			[Address(RVA = "0x10A7940", Offset = "0x10A7940", VA = "0x10A7940")]
			set
			{
			}
		}

		[Token(Token = "0x17000240")]
		public bool Warp
		{
			[Token(Token = "0x6000AB7")]
			[Address(RVA = "0x10A795C", Offset = "0x10A795C", VA = "0x10A795C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000AB8")]
			[Address(RVA = "0x10A7964", Offset = "0x10A7964", VA = "0x10A7964")]
			set
			{
			}
		}

		[Token(Token = "0x17000241")]
		public LayerMask LayerMask
		{
			[Token(Token = "0x6000AB9")]
			[Address(RVA = "0x10A798C", Offset = "0x10A798C", VA = "0x10A798C")]
			get
			{
				return default(LayerMask);
			}
			[Token(Token = "0x6000ABA")]
			[Address(RVA = "0x10A7994", Offset = "0x10A7994", VA = "0x10A7994")]
			set
			{
			}
		}

		[Token(Token = "0x17000242")]
		public bool PathIsClosed
		{
			[Token(Token = "0x6000ABD")]
			[Address(RVA = "0x10A7ADC", Offset = "0x10A7ADC", VA = "0x10A7ADC", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000ABB")]
		[Address(RVA = "0x10A79F0", Offset = "0x10A79F0", VA = "0x10A79F0", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000ABC")]
		[Address(RVA = "0x10A7A28", Offset = "0x10A7A28", VA = "0x10A7A28", Slot = "11")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000ABE")]
		[Address(RVA = "0x10A7BD0", Offset = "0x10A7BD0", VA = "0x10A7BD0", Slot = "14")]
		public CGData[] OnSlotDataRequest(CGModuleInputSlot requestedBy, CGModuleOutputSlot requestedSlot, params CGDataRequestParameter[] requests)
		{
			return null;
		}

		[Token(Token = "0x6000ABF")]
		[Address(RVA = "0x10A7D2C", Offset = "0x10A7D2C", VA = "0x10A7D2C")]
		public static CGPath Conform(Transform pathTransform, CGPath path, LayerMask layers, Vector3 projectionDirection, float offset, float rayLength, bool warp)
		{
			return null;
		}

		[Token(Token = "0x6000AC0")]
		[Address(RVA = "0x10A80F0", Offset = "0x10A80F0", VA = "0x10A80F0")]
		public ConformPath()
		{
		}
	}
	[Token(Token = "0x200010D")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x866DC8", Offset = "0x866DC8")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x866DC8", Offset = "0x866DC8")]
	public class CreateGameObject : CGModule
	{
		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x8711AC", Offset = "0x8711AC")]
		public CGModuleInputSlot InGameObjectArray;

		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x871264", Offset = "0x871264")]
		public CGModuleInputSlot InSpots;

		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[AttributeAttribute(Name = "CGResourceCollectionManagerAttribute", RVA = "0x87130C", Offset = "0x87130C")]
		private CGGameObjectResourceCollection m_Resources;

		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x871364", Offset = "0x871364")]
		[SerializeField]
		private bool m_MakeStatic;

		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[SerializeField]
		[AttributeAttribute(Name = "LayerAttribute", RVA = "0x8713B0", Offset = "0x8713B0")]
		private int m_Layer;

		[Token(Token = "0x17000243")]
		public int Layer
		{
			[Token(Token = "0x6000AC1")]
			[Address(RVA = "0x10A956C", Offset = "0x10A956C", VA = "0x10A956C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000AC2")]
			[Address(RVA = "0x10A9574", Offset = "0x10A9574", VA = "0x10A9574")]
			set
			{
			}
		}

		[Token(Token = "0x17000244")]
		public bool MakeStatic
		{
			[Token(Token = "0x6000AC3")]
			[Address(RVA = "0x10A9610", Offset = "0x10A9610", VA = "0x10A9610")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000AC4")]
			[Address(RVA = "0x10A9618", Offset = "0x10A9618", VA = "0x10A9618")]
			set
			{
			}
		}

		[Token(Token = "0x17000245")]
		public CGGameObjectResourceCollection GameObjects
		{
			[Token(Token = "0x6000AC5")]
			[Address(RVA = "0x10A9640", Offset = "0x10A9640", VA = "0x10A9640")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000246")]
		public int GameObjectCount
		{
			[Token(Token = "0x6000AC6")]
			[Address(RVA = "0x10A9648", Offset = "0x10A9648", VA = "0x10A9648")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000AC7")]
		[Address(RVA = "0x10A9664", Offset = "0x10A9664", VA = "0x10A9664", Slot = "11")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000AC8")]
		[Address(RVA = "0x10A97E4", Offset = "0x10A97E4", VA = "0x10A97E4", Slot = "7")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000AC9")]
		[Address(RVA = "0x10A9828", Offset = "0x10A9828", VA = "0x10A9828", Slot = "13")]
		public override void OnTemplateCreated()
		{
		}

		[Token(Token = "0x6000ACA")]
		[Address(RVA = "0x10A96B4", Offset = "0x10A96B4", VA = "0x10A96B4")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000ACB")]
		[Address(RVA = "0x10A982C", Offset = "0x10A982C", VA = "0x10A982C", Slot = "12")]
		public override void OnStateChange()
		{
		}

		[Token(Token = "0x6000ACC")]
		[Address(RVA = "0x10A9874", Offset = "0x10A9874", VA = "0x10A9874", Slot = "10")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x6000ACD")]
		[Address(RVA = "0x10AA008", Offset = "0x10AA008", VA = "0x10AA008")]
		public CreateGameObject()
		{
		}
	}
	[Token(Token = "0x200010E")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x866E38", Offset = "0x866E38")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x866E38", Offset = "0x866E38")]
	public class CreateMesh : CGModule
	{
		[Serializable]
		[Token(Token = "0x200019E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x867BAC", Offset = "0x867BAC")]
		private sealed class <>c
		{
			[Token(Token = "0x40006DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40006DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<CGSpots, bool> <>9__109_0;

			[Token(Token = "0x40006DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<CGSpots, IEnumerable<CGSpot>> <>9__109_1;

			[Token(Token = "0x40006DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Comparison<CGSpot> <>9__114_0;

			[Token(Token = "0x6000D91")]
			[Address(RVA = "0x181645C", Offset = "0x181645C", VA = "0x181645C")]
			public <>c()
			{
			}

			[Token(Token = "0x6000D92")]
			[Address(RVA = "0x1816464", Offset = "0x1816464", VA = "0x1816464")]
			internal bool <Refresh>b__109_0(CGSpots s)
			{
				return default(bool);
			}

			[Token(Token = "0x6000D93")]
			[Address(RVA = "0x1816470", Offset = "0x1816470", VA = "0x1816470")]
			internal IEnumerable<CGSpot> <Refresh>b__109_1(CGSpots s)
			{
				return null;
			}

			[Token(Token = "0x6000D94")]
			[Address(RVA = "0x1816488", Offset = "0x1816488", VA = "0x1816488")]
			internal int <createSpotMeshes>b__114_0(CGSpot a, CGSpot b)
			{
				return default(int);
			}
		}

		[Token(Token = "0x4000441")]
		private const string DefaultTag = "Untagged";

		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x871418", Offset = "0x871418")]
		public CGModuleInputSlot InVMeshArray;

		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x8714D0", Offset = "0x8714D0")]
		public CGModuleInputSlot InSpots;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[AttributeAttribute(Name = "CGResourceCollectionManagerAttribute", RVA = "0x87158C", Offset = "0x87158C")]
		private CGMeshResourceCollection m_MeshResources;

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x8715E4", Offset = "0x8715E4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8715E4", Offset = "0x8715E4")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x8715E4", Offset = "0x8715E4")]
		[SerializeField]
		private bool m_Combine;

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC1")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8716E8", Offset = "0x8716E8")]
		[SerializeField]
		private bool m_GroupMeshes;

		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x871734", Offset = "0x871734")]
		private CGYesNoAuto m_AddNormals;

		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x8717F0", Offset = "0x8717F0")]
		private CGYesNoAuto m_AddTangents;

		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x8718AC", Offset = "0x8718AC")]
		private bool m_AddUV2;

		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCD")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x871968", Offset = "0x871968")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x871968", Offset = "0x871968")]
		private bool m_MakeStatic;

		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x871A48", Offset = "0x871A48")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x871A48", Offset = "0x871A48")]
		[AttributeAttribute(Name = "LayerAttribute", RVA = "0x871A48", Offset = "0x871A48")]
		private int m_Layer;

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x871B60", Offset = "0x871B60")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x871B60", Offset = "0x871B60")]
		[AttributeAttribute(Name = "TagAttribute", RVA = "0x871B60", Offset = "0x871B60")]
		private string m_Tag;

		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x871C78", Offset = "0x871C78")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x871C78", Offset = "0x871C78")]
		private bool m_RendererEnabled;

		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x871D58", Offset = "0x871D58")]
		private ShadowCastingMode m_CastShadows;

		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x871E14", Offset = "0x871E14")]
		private bool m_ReceiveShadows;

		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x871ED0", Offset = "0x871ED0")]
		private LightProbeUsage m_LightProbeUsage;

		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[HideInInspector]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x871F8C", Offset = "0x871F8C")]
		private bool m_UseLightProbes;

		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x872058", Offset = "0x872058")]
		private ReflectionProbeUsage m_ReflectionProbes;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x872114", Offset = "0x872114")]
		private Transform m_AnchorOverride;

		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x8721D0", Offset = "0x8721D0")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x8721D0", Offset = "0x8721D0")]
		private CGColliderEnum m_Collider;

		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x8722B0", Offset = "0x8722B0")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x8722B0", Offset = "0x8722B0")]
		private bool m_Convex;

		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x105")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x8723CC", Offset = "0x8723CC")]
		private bool m_IsTrigger;

		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x872488", Offset = "0x872488")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x872488", Offset = "0x872488")]
		[SerializeField]
		[AttributeAttribute(Name = "EnumFlagAttribute", RVA = "0x872488", Offset = "0x872488")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x872488", Offset = "0x872488")]
		private MeshColliderCookingOptions m_CookingOptions;

		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x872600", Offset = "0x872600")]
		[SerializeField]
		private bool m_AutoUpdateColliders;

		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[SerializeField]
		private PhysicMaterial m_Material;

		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x872678", Offset = "0x872678")]
		private int <VertexCount>k__BackingField;

		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		private int mCurrentMeshCount;

		[Token(Token = "0x17000247")]
		public bool Combine
		{
			[Token(Token = "0x6000ACE")]
			[Address(RVA = "0x10AA0B0", Offset = "0x10AA0B0", VA = "0x10AA0B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000ACF")]
			[Address(RVA = "0x10AA0B8", Offset = "0x10AA0B8", VA = "0x10AA0B8")]
			set
			{
			}
		}

		[Token(Token = "0x17000248")]
		public bool GroupMeshes
		{
			[Token(Token = "0x6000AD0")]
			[Address(RVA = "0x10AA0E0", Offset = "0x10AA0E0", VA = "0x10AA0E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000AD1")]
			[Address(RVA = "0x10AA0E8", Offset = "0x10AA0E8", VA = "0x10AA0E8")]
			set
			{
			}
		}

		[Token(Token = "0x17000249")]
		public CGYesNoAuto AddNormals
		{
			[Token(Token = "0x6000AD2")]
			[Address(RVA = "0x10AA110", Offset = "0x10AA110", VA = "0x10AA110")]
			get
			{
				return default(CGYesNoAuto);
			}
			[Token(Token = "0x6000AD3")]
			[Address(RVA = "0x10AA118", Offset = "0x10AA118", VA = "0x10AA118")]
			set
			{
			}
		}

		[Token(Token = "0x1700024A")]
		public CGYesNoAuto AddTangents
		{
			[Token(Token = "0x6000AD4")]
			[Address(RVA = "0x10AA134", Offset = "0x10AA134", VA = "0x10AA134")]
			get
			{
				return default(CGYesNoAuto);
			}
			[Token(Token = "0x6000AD5")]
			[Address(RVA = "0x10AA13C", Offset = "0x10AA13C", VA = "0x10AA13C")]
			set
			{
			}
		}

		[Token(Token = "0x1700024B")]
		public bool AddUV2
		{
			[Token(Token = "0x6000AD6")]
			[Address(RVA = "0x10AA158", Offset = "0x10AA158", VA = "0x10AA158")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000AD7")]
			[Address(RVA = "0x10AA160", Offset = "0x10AA160", VA = "0x10AA160")]
			set
			{
			}
		}

		[Token(Token = "0x1700024C")]
		public int Layer
		{
			[Token(Token = "0x6000AD8")]
			[Address(RVA = "0x10AA188", Offset = "0x10AA188", VA = "0x10AA188")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000AD9")]
			[Address(RVA = "0x10AA190", Offset = "0x10AA190", VA = "0x10AA190")]
			set
			{
			}
		}

		[Token(Token = "0x1700024D")]
		public string Tag
		{
			[Token(Token = "0x6000ADA")]
			[Address(RVA = "0x10AA22C", Offset = "0x10AA22C", VA = "0x10AA22C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000ADB")]
			[Address(RVA = "0x10AA234", Offset = "0x10AA234", VA = "0x10AA234")]
			set
			{
			}
		}

		[Token(Token = "0x1700024E")]
		public bool MakeStatic
		{
			[Token(Token = "0x6000ADC")]
			[Address(RVA = "0x10AA274", Offset = "0x10AA274", VA = "0x10AA274")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000ADD")]
			[Address(RVA = "0x10AA27C", Offset = "0x10AA27C", VA = "0x10AA27C")]
			set
			{
			}
		}

		[Token(Token = "0x1700024F")]
		public bool RendererEnabled
		{
			[Token(Token = "0x6000ADE")]
			[Address(RVA = "0x10AA2A4", Offset = "0x10AA2A4", VA = "0x10AA2A4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000ADF")]
			[Address(RVA = "0x10AA2AC", Offset = "0x10AA2AC", VA = "0x10AA2AC")]
			set
			{
			}
		}

		[Token(Token = "0x17000250")]
		public ShadowCastingMode CastShadows
		{
			[Token(Token = "0x6000AE0")]
			[Address(RVA = "0x10AA2D4", Offset = "0x10AA2D4", VA = "0x10AA2D4")]
			get
			{
				return default(ShadowCastingMode);
			}
			[Token(Token = "0x6000AE1")]
			[Address(RVA = "0x10AA2DC", Offset = "0x10AA2DC", VA = "0x10AA2DC")]
			set
			{
			}
		}

		[Token(Token = "0x17000251")]
		public bool ReceiveShadows
		{
			[Token(Token = "0x6000AE2")]
			[Address(RVA = "0x10AA2F8", Offset = "0x10AA2F8", VA = "0x10AA2F8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000AE3")]
			[Address(RVA = "0x10AA300", Offset = "0x10AA300", VA = "0x10AA300")]
			set
			{
			}
		}

		[Token(Token = "0x17000252")]
		public bool UseLightProbes
		{
			[Token(Token = "0x6000AE4")]
			[Address(RVA = "0x10AA328", Offset = "0x10AA328", VA = "0x10AA328")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000AE5")]
			[Address(RVA = "0x10AA330", Offset = "0x10AA330", VA = "0x10AA330")]
			set
			{
			}
		}

		[Token(Token = "0x17000253")]
		public LightProbeUsage LightProbeUsage
		{
			[Token(Token = "0x6000AE6")]
			[Address(RVA = "0x10AA358", Offset = "0x10AA358", VA = "0x10AA358")]
			get
			{
				return default(LightProbeUsage);
			}
			[Token(Token = "0x6000AE7")]
			[Address(RVA = "0x10AA360", Offset = "0x10AA360", VA = "0x10AA360")]
			set
			{
			}
		}

		[Token(Token = "0x17000254")]
		public ReflectionProbeUsage ReflectionProbes
		{
			[Token(Token = "0x6000AE8")]
			[Address(RVA = "0x10AA37C", Offset = "0x10AA37C", VA = "0x10AA37C")]
			get
			{
				return default(ReflectionProbeUsage);
			}
			[Token(Token = "0x6000AE9")]
			[Address(RVA = "0x10AA384", Offset = "0x10AA384", VA = "0x10AA384")]
			set
			{
			}
		}

		[Token(Token = "0x17000255")]
		public Transform AnchorOverride
		{
			[Token(Token = "0x6000AEA")]
			[Address(RVA = "0x10AA3A0", Offset = "0x10AA3A0", VA = "0x10AA3A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AEB")]
			[Address(RVA = "0x10AA3A8", Offset = "0x10AA3A8", VA = "0x10AA3A8")]
			set
			{
			}
		}

		[Token(Token = "0x17000256")]
		public CGColliderEnum Collider
		{
			[Token(Token = "0x6000AEC")]
			[Address(RVA = "0x10AA43C", Offset = "0x10AA43C", VA = "0x10AA43C")]
			get
			{
				return default(CGColliderEnum);
			}
			[Token(Token = "0x6000AED")]
			[Address(RVA = "0x10AA444", Offset = "0x10AA444", VA = "0x10AA444")]
			set
			{
			}
		}

		[Token(Token = "0x17000257")]
		public bool AutoUpdateColliders
		{
			[Token(Token = "0x6000AEE")]
			[Address(RVA = "0x10AA460", Offset = "0x10AA460", VA = "0x10AA460")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000AEF")]
			[Address(RVA = "0x10AA468", Offset = "0x10AA468", VA = "0x10AA468")]
			set
			{
			}
		}

		[Token(Token = "0x17000258")]
		public bool Convex
		{
			[Token(Token = "0x6000AF0")]
			[Address(RVA = "0x10AA490", Offset = "0x10AA490", VA = "0x10AA490")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000AF1")]
			[Address(RVA = "0x10AA498", Offset = "0x10AA498", VA = "0x10AA498")]
			set
			{
			}
		}

		[Token(Token = "0x17000259")]
		public bool IsTrigger
		{
			[Token(Token = "0x6000AF2")]
			[Address(RVA = "0x10AA4C0", Offset = "0x10AA4C0", VA = "0x10AA4C0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000AF3")]
			[Address(RVA = "0x10AA4C8", Offset = "0x10AA4C8", VA = "0x10AA4C8")]
			set
			{
			}
		}

		[Token(Token = "0x1700025A")]
		public MeshColliderCookingOptions CookingOptions
		{
			[Token(Token = "0x6000AF4")]
			[Address(RVA = "0x10AA4F0", Offset = "0x10AA4F0", VA = "0x10AA4F0")]
			get
			{
				return default(MeshColliderCookingOptions);
			}
			[Token(Token = "0x6000AF5")]
			[Address(RVA = "0x10AA4F8", Offset = "0x10AA4F8", VA = "0x10AA4F8")]
			set
			{
			}
		}

		[Token(Token = "0x1700025B")]
		public PhysicMaterial Material
		{
			[Token(Token = "0x6000AF6")]
			[Address(RVA = "0x10AA514", Offset = "0x10AA514", VA = "0x10AA514")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AF7")]
			[Address(RVA = "0x10AA51C", Offset = "0x10AA51C", VA = "0x10AA51C")]
			set
			{
			}
		}

		[Token(Token = "0x1700025C")]
		public CGMeshResourceCollection Meshes
		{
			[Token(Token = "0x6000AF8")]
			[Address(RVA = "0x10AA5B0", Offset = "0x10AA5B0", VA = "0x10AA5B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700025D")]
		public int MeshCount
		{
			[Token(Token = "0x6000AF9")]
			[Address(RVA = "0x10AA5B8", Offset = "0x10AA5B8", VA = "0x10AA5B8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700025E")]
		public int VertexCount
		{
			[Token(Token = "0x6000AFA")]
			[Address(RVA = "0x10AA5D4", Offset = "0x10AA5D4", VA = "0x10AA5D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x877640", Offset = "0x877640")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000AFB")]
			[Address(RVA = "0x10AA5DC", Offset = "0x10AA5DC", VA = "0x10AA5DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x877650", Offset = "0x877650")]
			private set
			{
			}
		}

		[Token(Token = "0x1700025F")]
		private bool canGroupMeshes
		{
			[Token(Token = "0x6000AFC")]
			[Address(RVA = "0x10AA5E4", Offset = "0x10AA5E4", VA = "0x10AA5E4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000260")]
		private bool canModifyStaticFlag
		{
			[Token(Token = "0x6000AFD")]
			[Address(RVA = "0x10AA62C", Offset = "0x10AA62C", VA = "0x10AA62C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000261")]
		private bool canUpdate
		{
			[Token(Token = "0x6000AFE")]
			[Address(RVA = "0x10AA634", Offset = "0x10AA634", VA = "0x10AA634")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000262")]
		private bool EnableIsTrigger
		{
			[Token(Token = "0x6000AFF")]
			[Address(RVA = "0x10AA670", Offset = "0x10AA670", VA = "0x10AA670")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000B00")]
		[Address(RVA = "0x10AA6C8", Offset = "0x10AA6C8", VA = "0x10AA6C8", Slot = "11")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000B01")]
		[Address(RVA = "0x10AA9A4", Offset = "0x10AA9A4", VA = "0x10AA9A4", Slot = "13")]
		public override void OnTemplateCreated()
		{
		}

		[Token(Token = "0x6000B02")]
		[Address(RVA = "0x10AA988", Offset = "0x10AA988", VA = "0x10AA988")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000B03")]
		[Address(RVA = "0x10AAAD0", Offset = "0x10AAAD0", VA = "0x10AAAD0", Slot = "12")]
		public override void OnStateChange()
		{
		}

		[Token(Token = "0x6000B04")]
		[Address(RVA = "0x10AAB24", Offset = "0x10AAB24", VA = "0x10AAB24", Slot = "10")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x6000B05")]
		[Address(RVA = "0x10ABCF4", Offset = "0x10ABCF4", VA = "0x10ABCF4")]
		public GameObject SaveToScene([Optional] Transform parent)
		{
			return null;
		}

		[Token(Token = "0x6000B06")]
		[Address(RVA = "0x10ABB84", Offset = "0x10ABB84", VA = "0x10ABB84")]
		public void UpdateColliders()
		{
		}

		[Token(Token = "0x6000B07")]
		[Address(RVA = "0x10ABF00", Offset = "0x10ABF00", VA = "0x10ABF00")]
		private static GameObject SaveMeshResourceToScene(Component managedResource, Transform newParent)
		{
			return null;
		}

		[Token(Token = "0x6000B08")]
		[Address(RVA = "0x10AB7A0", Offset = "0x10AB7A0", VA = "0x10AB7A0")]
		private void createMeshes(ref List<CGVMesh> vMeshes, bool combine)
		{
		}

		[Token(Token = "0x6000B09")]
		[Address(RVA = "0x10AAF3C", Offset = "0x10AAF3C", VA = "0x10AAF3C")]
		private void createSpotMeshes(ref List<CGVMesh> vMeshes, CGSpot[] spots, bool combine)
		{
		}

		[Token(Token = "0x6000B0A")]
		[Address(RVA = "0x10AC044", Offset = "0x10AC044", VA = "0x10AC044")]
		private CGMeshResource writeVMeshToMesh(ref CGVMesh vmesh)
		{
			return null;
		}

		[Token(Token = "0x6000B0B")]
		[Address(RVA = "0x10AA9C0", Offset = "0x10AA9C0", VA = "0x10AA9C0")]
		private void removeUnusedResource()
		{
		}

		[Token(Token = "0x6000B0C")]
		[Address(RVA = "0x10AC2F0", Offset = "0x10AC2F0", VA = "0x10AC2F0")]
		private CGMeshResource getNewMesh()
		{
			return null;
		}

		[Token(Token = "0x6000B0D")]
		[Address(RVA = "0x10AC5C0", Offset = "0x10AC5C0", VA = "0x10AC5C0")]
		public CreateMesh()
		{
		}
	}
	[Token(Token = "0x200010F")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x866EA8", Offset = "0x866EA8")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x866EA8", Offset = "0x866EA8")]
	public class CreatePathLineRenderer : CGModule
	{
		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x872688", Offset = "0x872688")]
		public CGModuleInputSlot InPath;

		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private LineRenderer mLineRenderer;

		[Token(Token = "0x17000263")]
		public LineRenderer LineRenderer
		{
			[Token(Token = "0x6000B0E")]
			[Address(RVA = "0x10AC6B8", Offset = "0x10AC6B8", VA = "0x10AC6B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000B0F")]
		[Address(RVA = "0x10AC750", Offset = "0x10AC750", VA = "0x10AC750", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000B10")]
		[Address(RVA = "0x10AC870", Offset = "0x10AC870", VA = "0x10AC870", Slot = "10")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x6000B11")]
		[Address(RVA = "0x10AC778", Offset = "0x10AC778", VA = "0x10AC778")]
		private void createLR()
		{
		}

		[Token(Token = "0x6000B12")]
		[Address(RVA = "0x10AC9C8", Offset = "0x10AC9C8", VA = "0x10AC9C8")]
		public CreatePathLineRenderer()
		{
		}
	}
	[Token(Token = "0x2000110")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x866F28", Offset = "0x866F28")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x866F28", Offset = "0x866F28")]
	public class DebugRasterizedPath : CGModule
	{
		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x872730", Offset = "0x872730")]
		public CGModuleInputSlot InPath;

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8727D8", Offset = "0x8727D8")]
		public bool ShowNormals;

		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB1")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x872810", Offset = "0x872810")]
		public bool ShowOrientation;

		[Token(Token = "0x6000B13")]
		[Address(RVA = "0x145A89C", Offset = "0x145A89C", VA = "0x145A89C", Slot = "11")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000B14")]
		[Address(RVA = "0x145A8C8", Offset = "0x145A8C8", VA = "0x145A8C8")]
		public DebugRasterizedPath()
		{
		}
	}
	[Token(Token = "0x2000111")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x866FA8", Offset = "0x866FA8")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x866FA8", Offset = "0x866FA8")]
	public class DebugVMesh : CGModule
	{
		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x872848", Offset = "0x872848")]
		public CGModuleInputSlot InData;

		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x8728F0", Offset = "0x8728F0")]
		public bool ShowVertices;

		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB1")]
		public bool ShowVertexID;

		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB2")]
		public bool ShowUV;

		[Token(Token = "0x6000B15")]
		[Address(RVA = "0x145A938", Offset = "0x145A938", VA = "0x145A938", Slot = "11")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000B16")]
		[Address(RVA = "0x145A964", Offset = "0x145A964", VA = "0x145A964")]
		public DebugVMesh()
		{
		}
	}
	[Token(Token = "0x2000112")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x867018", Offset = "0x867018")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x867018", Offset = "0x867018")]
	public class DebugVolume : CGModule
	{
		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x872928", Offset = "0x872928")]
		public CGModuleInputSlot InData;

		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x8729D0", Offset = "0x8729D0")]
		public bool ShowPathSamples;

		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB1")]
		public bool ShowCrossSamples;

		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x872A08", Offset = "0x872A08")]
		[IntRegion]
		public IntRegion LimitCross;

		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public bool ShowNormals;

		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC1")]
		public bool ShowIndex;

		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC2")]
		public bool ShowMap;

		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public Color PathColor;

		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public Color VolumeColor;

		[Token(Token = "0x400046E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		public Color NormalColor;

		[Token(Token = "0x400046F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x872ACC", Offset = "0x872ACC")]
		public bool Interpolate;

		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x872B04", Offset = "0x872B04")]
		public float InterpolatePathF;

		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x872B58", Offset = "0x872B58")]
		public float InterpolateCrossF;

		[Token(Token = "0x6000B17")]
		[Address(RVA = "0x145A9CC", Offset = "0x145A9CC", VA = "0x145A9CC")]
		public DebugVolume()
		{
		}
	}
	[Token(Token = "0x2000113")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x867088", Offset = "0x867088")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x867088", Offset = "0x867088")]
	public class InputGameObject : CGModule
	{
		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x872BAC", Offset = "0x872BAC")]
		public CGModuleOutputSlot OutGameObject;

		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[ArrayEx]
		[SerializeField]
		private List<CGGameObjectProperties> m_GameObjects;

		[Token(Token = "0x17000264")]
		public List<CGGameObjectProperties> GameObjects
		{
			[Token(Token = "0x6000B18")]
			[Address(RVA = "0x145D780", Offset = "0x145D780", VA = "0x145D780")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000265")]
		public bool SupportsIPE
		{
			[Token(Token = "0x6000B19")]
			[Address(RVA = "0x145D788", Offset = "0x145D788", VA = "0x145D788")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000B1A")]
		[Address(RVA = "0x145D790", Offset = "0x145D790", VA = "0x145D790", Slot = "11")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000B1B")]
		[Address(RVA = "0x145D804", Offset = "0x145D804", VA = "0x145D804", Slot = "10")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x6000B1C")]
		[Address(RVA = "0x145D9B0", Offset = "0x145D9B0", VA = "0x145D9B0", Slot = "13")]
		public override void OnTemplateCreated()
		{
		}

		[Token(Token = "0x6000B1D")]
		[Address(RVA = "0x145DA14", Offset = "0x145DA14", VA = "0x145DA14")]
		public InputGameObject()
		{
		}
	}
	[Token(Token = "0x2000114")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x867108", Offset = "0x867108")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x867108", Offset = "0x867108")]
	public class InputMesh : CGModule, IExternalInput
	{
		[Token(Token = "0x4000474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x872C64", Offset = "0x872C64")]
		public CGModuleOutputSlot OutVMesh;

		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[ArrayEx]
		private List<CGMeshProperties> m_Meshes;

		[Token(Token = "0x17000266")]
		public List<CGMeshProperties> Meshes
		{
			[Token(Token = "0x6000B1E")]
			[Address(RVA = "0x145DAA4", Offset = "0x145DAA4", VA = "0x145DAA4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000267")]
		public bool SupportsIPE
		{
			[Token(Token = "0x6000B1F")]
			[Address(RVA = "0x145DAAC", Offset = "0x145DAAC", VA = "0x145DAAC", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000B20")]
		[Address(RVA = "0x145DAB4", Offset = "0x145DAB4", VA = "0x145DAB4", Slot = "11")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000B21")]
		[Address(RVA = "0x145DB28", Offset = "0x145DB28", VA = "0x145DB28", Slot = "10")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x6000B22")]
		[Address(RVA = "0x145DD0C", Offset = "0x145DD0C", VA = "0x145DD0C", Slot = "13")]
		public override void OnTemplateCreated()
		{
		}

		[Token(Token = "0x6000B23")]
		[Address(RVA = "0x145DD70", Offset = "0x145DD70", VA = "0x145DD70")]
		public InputMesh()
		{
		}
	}
	[Token(Token = "0x2000115")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x867188", Offset = "0x867188")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x867188", Offset = "0x867188")]
	public class InputSplinePath : SplineInputModuleBase, IExternalInput, IOnRequestPath, IOnRequestProcessing, IPathProvider
	{
		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x872D1C", Offset = "0x872D1C")]
		public CGModuleOutputSlot Path;

		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x872D90", Offset = "0x872D90")]
		[SerializeField]
		[AttributeAttribute(Name = "CGResourceManagerAttribute", RVA = "0x872D90", Offset = "0x872D90")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x872D90", Offset = "0x872D90")]
		private CurvySpline m_Spline;

		[Token(Token = "0x17000268")]
		public CurvySpline Spline
		{
			[Token(Token = "0x6000B24")]
			[Address(RVA = "0x145DFAC", Offset = "0x145DFAC", VA = "0x145DFAC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B25")]
			[Address(RVA = "0x145D088", Offset = "0x145D088", VA = "0x145D088")]
			set
			{
			}
		}

		[Token(Token = "0x17000269")]
		public bool SupportsIPE
		{
			[Token(Token = "0x6000B26")]
			[Address(RVA = "0x145DFB4", Offset = "0x145DFB4", VA = "0x145DFB4", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700026A")]
		protected override CurvySpline InputSpline
		{
			[Token(Token = "0x6000B29")]
			[Address(RVA = "0x145E208", Offset = "0x145E208", VA = "0x145E208", Slot = "15")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B2A")]
			[Address(RVA = "0x145E210", Offset = "0x145E210", VA = "0x145E210", Slot = "16")]
			set
			{
			}
		}

		[Token(Token = "0x6000B27")]
		[Address(RVA = "0x145DFBC", Offset = "0x145DFBC", VA = "0x145DFBC", Slot = "19")]
		public CGData[] OnSlotDataRequest(CGModuleInputSlot requestedBy, CGModuleOutputSlot requestedSlot, params CGDataRequestParameter[] requests)
		{
			return null;
		}

		[Token(Token = "0x6000B28")]
		[Address(RVA = "0x145E160", Offset = "0x145E160", VA = "0x145E160", Slot = "13")]
		public override void OnTemplateCreated()
		{
		}

		[Token(Token = "0x6000B2B")]
		[Address(RVA = "0x145E214", Offset = "0x145E214", VA = "0x145E214")]
		public InputSplinePath()
		{
		}
	}
	[Token(Token = "0x2000116")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x867208", Offset = "0x867208")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x867208", Offset = "0x867208")]
	public class InputSplineShape : SplineInputModuleBase, IExternalInput, IOnRequestPath, IOnRequestProcessing, IPathProvider
	{
		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x872E4C", Offset = "0x872E4C")]
		public CGModuleOutputSlot OutShape;

		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x872EC0", Offset = "0x872EC0")]
		[SerializeField]
		[AttributeAttribute(Name = "CGResourceManagerAttribute", RVA = "0x872EC0", Offset = "0x872EC0")]
		private CurvySpline m_Shape;

		[Token(Token = "0x1700026B")]
		public CurvySpline Shape
		{
			[Token(Token = "0x6000B2C")]
			[Address(RVA = "0x145E27C", Offset = "0x145E27C", VA = "0x145E27C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B2D")]
			[Address(RVA = "0x145E284", Offset = "0x145E284", VA = "0x145E284")]
			set
			{
			}
		}

		[Token(Token = "0x1700026C")]
		public bool SupportsIPE
		{
			[Token(Token = "0x6000B2E")]
			[Address(RVA = "0x145E338", Offset = "0x145E338", VA = "0x145E338", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700026D")]
		public bool FreeForm
		{
			[Token(Token = "0x6000B2F")]
			[Address(RVA = "0x145E33C", Offset = "0x145E33C", VA = "0x145E33C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000B30")]
			[Address(RVA = "0x145E418", Offset = "0x145E418", VA = "0x145E418")]
			set
			{
			}
		}

		[Token(Token = "0x1700026E")]
		protected override CurvySpline InputSpline
		{
			[Token(Token = "0x6000B34")]
			[Address(RVA = "0x145E740", Offset = "0x145E740", VA = "0x145E740", Slot = "15")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B35")]
			[Address(RVA = "0x145E748", Offset = "0x145E748", VA = "0x145E748", Slot = "16")]
			set
			{
			}
		}

		[Token(Token = "0x6000B31")]
		[Address(RVA = "0x145E564", Offset = "0x145E564", VA = "0x145E564", Slot = "19")]
		public CGData[] OnSlotDataRequest(CGModuleInputSlot requestedBy, CGModuleOutputSlot requestedSlot, params CGDataRequestParameter[] requests)
		{
			return null;
		}

		[Token(Token = "0x6000B32")]
		public T SetManagedShape<T>() where T : CurvyShape2D
		{
			return null;
		}

		[Token(Token = "0x6000B33")]
		[Address(RVA = "0x145E698", Offset = "0x145E698", VA = "0x145E698")]
		public void RemoveManagedShape()
		{
		}

		[Token(Token = "0x6000B36")]
		[Address(RVA = "0x145E74C", Offset = "0x145E74C", VA = "0x145E74C", Slot = "17")]
		protected override void OnSplineAssigned()
		{
		}

		[Token(Token = "0x6000B37")]
		[Address(RVA = "0x145E7EC", Offset = "0x145E7EC", VA = "0x145E7EC")]
		public InputSplineShape()
		{
		}
	}
	[Token(Token = "0x2000117")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x867288", Offset = "0x867288")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x867288", Offset = "0x867288")]
	public class InputSpots : CGModule
	{
		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x872F34", Offset = "0x872F34")]
		public CGModuleOutputSlot OutSpots;

		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[ArrayEx]
		[SerializeField]
		private List<CGSpot> m_Spots;

		[Token(Token = "0x1700026F")]
		public List<CGSpot> Spots
		{
			[Token(Token = "0x6000B38")]
			[Address(RVA = "0x145E854", Offset = "0x145E854", VA = "0x145E854")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B39")]
			[Address(RVA = "0x145E85C", Offset = "0x145E85C", VA = "0x145E85C")]
			set
			{
			}
		}

		[Token(Token = "0x6000B3A")]
		[Address(RVA = "0x145E878", Offset = "0x145E878", VA = "0x145E878", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000B3B")]
		[Address(RVA = "0x145E8B0", Offset = "0x145E8B0", VA = "0x145E8B0", Slot = "11")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000B3C")]
		[Address(RVA = "0x145E924", Offset = "0x145E924", VA = "0x145E924", Slot = "12")]
		public override void OnStateChange()
		{
		}

		[Token(Token = "0x6000B3D")]
		[Address(RVA = "0x145E92C", Offset = "0x145E92C", VA = "0x145E92C", Slot = "10")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x6000B3E")]
		[Address(RVA = "0x145EA4C", Offset = "0x145EA4C", VA = "0x145EA4C")]
		public InputSpots()
		{
		}
	}
	[Token(Token = "0x2000118")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x867308", Offset = "0x867308")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x867308", Offset = "0x867308")]
	public class ModifierMixPaths : CGModule, IOnRequestPath, IOnRequestProcessing, IPathProvider
	{
		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x872FE0", Offset = "0x872FE0")]
		public CGModuleInputSlot InPathA;

		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x874088", Offset = "0x874088")]
		public CGModuleInputSlot InPathB;

		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x874130", Offset = "0x874130")]
		public CGModuleOutputSlot OutPath;

		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x8741A4", Offset = "0x8741A4")]
		private float m_Mix;

		[Token(Token = "0x17000270")]
		public float Mix
		{
			[Token(Token = "0x6000B3F")]
			[Address(RVA = "0xDEDFA0", Offset = "0xDEDFA0", VA = "0xDEDFA0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000B40")]
			[Address(RVA = "0xDEDFA8", Offset = "0xDEDFA8", VA = "0xDEDFA8")]
			set
			{
			}
		}

		[Token(Token = "0x17000271")]
		public bool PathIsClosed
		{
			[Token(Token = "0x6000B41")]
			[Address(RVA = "0xDEDFC4", Offset = "0xDEDFC4", VA = "0xDEDFC4", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000B42")]
		[Address(RVA = "0xDEE150", Offset = "0xDEE150", VA = "0xDEE150", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000B43")]
		[Address(RVA = "0xDEE198", Offset = "0xDEE198", VA = "0xDEE198", Slot = "11")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000B44")]
		[Address(RVA = "0xDEE1D8", Offset = "0xDEE1D8", VA = "0xDEE1D8", Slot = "14")]
		public CGData[] OnSlotDataRequest(CGModuleInputSlot requestedBy, CGModuleOutputSlot requestedSlot, params CGDataRequestParameter[] requests)
		{
			return null;
		}

		[Token(Token = "0x6000B45")]
		[Address(RVA = "0xDEE308", Offset = "0xDEE308", VA = "0xDEE308")]
		public static CGPath MixPath(CGPath pathA, CGPath pathB, float mix, [NotNull] List<string> warningsContainer)
		{
			return null;
		}

		[Token(Token = "0x6000B46")]
		[Address(RVA = "0xDEEF5C", Offset = "0xDEEF5C", VA = "0xDEEF5C")]
		public ModifierMixPaths()
		{
		}
	}
	[Token(Token = "0x2000119")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x867388", Offset = "0x867388")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x867388", Offset = "0x867388")]
	public class ModifierMixShapes : CGModule, IOnRequestPath, IOnRequestProcessing, IPathProvider
	{
		[Serializable]
		[Token(Token = "0x200019F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x867BBC", Offset = "0x867BBC")]
		private sealed class <>c
		{
			[Token(Token = "0x40006E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40006E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<SamplePointsMaterialGroup, SamplePointsMaterialGroup> <>9__13_0;

			[Token(Token = "0x6000D96")]
			[Address(RVA = "0x181BED8", Offset = "0x181BED8", VA = "0x181BED8")]
			public <>c()
			{
			}

			[Token(Token = "0x6000D97")]
			[Address(RVA = "0x181BEE0", Offset = "0x181BEE0", VA = "0x181BEE0")]
			internal SamplePointsMaterialGroup <InterpolateShape>b__13_0(SamplePointsMaterialGroup g)
			{
				return null;
			}
		}

		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x874228", Offset = "0x874228")]
		public CGModuleInputSlot InShapeA;

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x8742D0", Offset = "0x8742D0")]
		public CGModuleInputSlot InShapeB;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x874378", Offset = "0x874378")]
		public CGModuleOutputSlot OutShape;

		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x8743EC", Offset = "0x8743EC")]
		private float m_Mix;

		[Token(Token = "0x17000272")]
		public float Mix
		{
			[Token(Token = "0x6000B47")]
			[Address(RVA = "0xDEF004", Offset = "0xDEF004", VA = "0xDEF004")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000B48")]
			[Address(RVA = "0xDEF00C", Offset = "0xDEF00C", VA = "0xDEF00C")]
			set
			{
			}
		}

		[Token(Token = "0x17000273")]
		public bool PathIsClosed
		{
			[Token(Token = "0x6000B49")]
			[Address(RVA = "0xDEF028", Offset = "0xDEF028", VA = "0xDEF028", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000B4A")]
		[Address(RVA = "0xDEF1B4", Offset = "0xDEF1B4", VA = "0xDEF1B4", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000B4B")]
		[Address(RVA = "0xDEF1FC", Offset = "0xDEF1FC", VA = "0xDEF1FC", Slot = "11")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000B4C")]
		[Address(RVA = "0xDEF23C", Offset = "0xDEF23C", VA = "0xDEF23C", Slot = "14")]
		public CGData[] OnSlotDataRequest(CGModuleInputSlot requestedBy, CGModuleOutputSlot requestedSlot, params CGDataRequestParameter[] requests)
		{
			return null;
		}

		[Token(Token = "0x6000B4D")]
		[Address(RVA = "0xDEF364", Offset = "0xDEF364", VA = "0xDEF364")]
		public static CGShape MixShapes(CGShape shapeA, CGShape shapeB, float mix, [NotNull] List<string> warningsContainer, bool ignoreWarnings = false)
		{
			return null;
		}

		[Token(Token = "0x6000B4E")]
		[Address(RVA = "0xDEE718", Offset = "0xDEE718", VA = "0xDEE718")]
		public static void InterpolateShape([NotNull] CGShape resultShape, CGShape shapeA, CGShape shapeB, float mix, [NotNull] List<string> warningsContainer, bool ignoreWarnings = false)
		{
		}

		[Token(Token = "0x6000B4F")]
		[Address(RVA = "0xDEF41C", Offset = "0xDEF41C", VA = "0xDEF41C")]
		public ModifierMixShapes()
		{
		}
	}
	[Token(Token = "0x200011A")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x867408", Offset = "0x867408")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x867408", Offset = "0x867408")]
	public class ModifierPathRelativeTranslation : CGModule, IOnRequestPath, IOnRequestProcessing, IPathProvider
	{
		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x874470", Offset = "0x874470")]
		public CGModuleInputSlot InPath;

		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x874528", Offset = "0x874528")]
		public CGModuleOutputSlot OutPath;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87459C", Offset = "0x87459C")]
		private float lateralTranslation;

		[Token(Token = "0x17000274")]
		public float LateralTranslation
		{
			[Token(Token = "0x6000B50")]
			[Address(RVA = "0xDEF4C4", Offset = "0xDEF4C4", VA = "0xDEF4C4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000B51")]
			[Address(RVA = "0xDEF4CC", Offset = "0xDEF4CC", VA = "0xDEF4CC")]
			set
			{
			}
		}

		[Token(Token = "0x17000275")]
		public bool PathIsClosed
		{
			[Token(Token = "0x6000B52")]
			[Address(RVA = "0xDEF4EC", Offset = "0xDEF4EC", VA = "0xDEF4EC", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000B53")]
		[Address(RVA = "0xDEF5E0", Offset = "0xDEF5E0", VA = "0xDEF5E0", Slot = "14")]
		public CGData[] OnSlotDataRequest(CGModuleInputSlot requestedBy, CGModuleOutputSlot requestedSlot, params CGDataRequestParameter[] requests)
		{
			return null;
		}

		[Token(Token = "0x6000B54")]
		[Address(RVA = "0xDEF840", Offset = "0xDEF840", VA = "0xDEF840", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000B55")]
		[Address(RVA = "0xDEF888", Offset = "0xDEF888", VA = "0xDEF888", Slot = "11")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000B56")]
		[Address(RVA = "0xDEF8D4", Offset = "0xDEF8D4", VA = "0xDEF8D4")]
		public ModifierPathRelativeTranslation()
		{
		}
	}
	[Token(Token = "0x200011B")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x867488", Offset = "0x867488")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x867488", Offset = "0x867488")]
	public class ModifierTRSMesh : TRSModuleBase
	{
		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x8745E8", Offset = "0x8745E8")]
		public CGModuleInputSlot InVMesh;

		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x874694", Offset = "0x874694")]
		public CGModuleOutputSlot OutVMesh;

		[Token(Token = "0x6000B57")]
		[Address(RVA = "0xDEF95C", Offset = "0xDEF95C", VA = "0xDEF95C", Slot = "10")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x6000B58")]
		[Address(RVA = "0xDEFB34", Offset = "0xDEFB34", VA = "0xDEFB34")]
		public ModifierTRSMesh()
		{
		}
	}
	[Token(Token = "0x200011C")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x867508", Offset = "0x867508")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x867508", Offset = "0x867508")]
	public class ModifierTRSPath : TRSModuleBase, IOnRequestPath, IOnRequestProcessing, IPathProvider
	{
		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x874714", Offset = "0x874714")]
		public CGModuleInputSlot InPath;

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x8747CC", Offset = "0x8747CC")]
		public CGModuleOutputSlot OutPath;

		[Token(Token = "0x17000276")]
		public bool PathIsClosed
		{
			[Token(Token = "0x6000B59")]
			[Address(RVA = "0xDEFBBC", Offset = "0xDEFBBC", VA = "0xDEFBBC", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000B5A")]
		[Address(RVA = "0xDEFCB0", Offset = "0xDEFCB0", VA = "0xDEFCB0", Slot = "14")]
		public CGData[] OnSlotDataRequest(CGModuleInputSlot requestedBy, CGModuleOutputSlot requestedSlot, params CGDataRequestParameter[] requests)
		{
			return null;
		}

		[Token(Token = "0x6000B5B")]
		[Address(RVA = "0xDEFFC0", Offset = "0xDEFFC0", VA = "0xDEFFC0")]
		public ModifierTRSPath()
		{
		}
	}
	[Token(Token = "0x200011D")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x867588", Offset = "0x867588")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x867588", Offset = "0x867588")]
	public class ModifierTRSShape : TRSModuleBase, IOnRequestPath, IOnRequestProcessing, IPathProvider
	{
		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x874840", Offset = "0x874840")]
		public CGModuleInputSlot InShape;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x8748F8", Offset = "0x8748F8")]
		public CGModuleOutputSlot OutShape;

		[Token(Token = "0x17000277")]
		public bool PathIsClosed
		{
			[Token(Token = "0x6000B5C")]
			[Address(RVA = "0xDF0048", Offset = "0xDF0048", VA = "0xDF0048", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000B5D")]
		[Address(RVA = "0xDF013C", Offset = "0xDF013C", VA = "0xDF013C", Slot = "14")]
		public CGData[] OnSlotDataRequest(CGModuleInputSlot requestedBy, CGModuleOutputSlot requestedSlot, params CGDataRequestParameter[] requests)
		{
			return null;
		}

		[Token(Token = "0x6000B5E")]
		[Address(RVA = "0xDF044C", Offset = "0xDF044C", VA = "0xDF044C")]
		public ModifierTRSShape()
		{
		}
	}
	[Token(Token = "0x200011E")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x867608", Offset = "0x867608")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x867608", Offset = "0x867608")]
	public class ModifierVariableMixShapes : CGModule, IOnRequestPath, IOnRequestProcessing, IPathProvider
	{
		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x87496C", Offset = "0x87496C")]
		public CGModuleInputSlot InShapeA;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x874A14", Offset = "0x874A14")]
		public CGModuleInputSlot InShapeB;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[HideInInspector]
		[AttributeAttribute(Name = "ShapeOutputSlotInfo", RVA = "0x874ABC", Offset = "0x874ABC")]
		public CGModuleOutputSlot OutShape;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x874B10", Offset = "0x874B10")]
		[SerializeField]
		private AnimationCurve m_MixCurve;

		[Token(Token = "0x17000278")]
		public bool PathIsClosed
		{
			[Token(Token = "0x6000B5F")]
			[Address(RVA = "0xDF04D4", Offset = "0xDF04D4", VA = "0xDF04D4", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000279")]
		public AnimationCurve MixCurve
		{
			[Token(Token = "0x6000B60")]
			[Address(RVA = "0xDF0660", Offset = "0xDF0660", VA = "0xDF0660")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B61")]
			[Address(RVA = "0xDF0668", Offset = "0xDF0668", VA = "0xDF0668")]
			set
			{
			}
		}

		[Token(Token = "0x6000B62")]
		[Address(RVA = "0xDF067C", Offset = "0xDF067C", VA = "0xDF067C", Slot = "11")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000B63")]
		[Address(RVA = "0xDF06BC", Offset = "0xDF06BC", VA = "0xDF06BC", Slot = "14")]
		public CGData[] OnSlotDataRequest(CGModuleInputSlot requestedBy, CGModuleOutputSlot requestedSlot, params CGDataRequestParameter[] requests)
		{
			return null;
		}

		[Token(Token = "0x6000B64")]
		[Address(RVA = "0xDF0864", Offset = "0xDF0864", VA = "0xDF0864")]
		public ModifierVariableMixShapes()
		{
		}
	}
	[Token(Token = "0x200011F")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x867688", Offset = "0x867688")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x867688", Offset = "0x867688")]
	public class Note : CGModule, INoProcessing
	{
		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[AttributeAttribute(Name = "TextAreaAttribute", RVA = "0x874B78", Offset = "0x874B78")]
		private string m_Note;

		[Token(Token = "0x1700027A")]
		public string NoteText
		{
			[Token(Token = "0x6000B65")]
			[Address(RVA = "0xDF0EE0", Offset = "0xDF0EE0", VA = "0xDF0EE0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B66")]
			[Address(RVA = "0xDF0EE8", Offset = "0xDF0EE8", VA = "0xDF0EE8")]
			set
			{
			}
		}

		[Token(Token = "0x6000B67")]
		[Address(RVA = "0xDF0F1C", Offset = "0xDF0F1C", VA = "0xDF0F1C", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000B68")]
		[Address(RVA = "0xDF0F64", Offset = "0xDF0F64", VA = "0xDF0F64", Slot = "11")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000B69")]
		[Address(RVA = "0xDF0F8C", Offset = "0xDF0F8C", VA = "0xDF0F8C")]
		public Note()
		{
		}
	}
}
namespace FluffyUnderware.Curvy.Examples
{
	[Token(Token = "0x2000120")]
	public class CameraLook : MonoBehaviour
	{
		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x874BB8", Offset = "0x874BB8")]
		[SerializeField]
		private float m_TurnSpeed;

		[Token(Token = "0x6000B6A")]
		[Address(RVA = "0x10A4C48", Offset = "0x10A4C48", VA = "0x10A4C48")]
		protected void Update()
		{
		}

		[Token(Token = "0x6000B6B")]
		[Address(RVA = "0x10A4D40", Offset = "0x10A4D40", VA = "0x10A4D40")]
		public CameraLook()
		{
		}
	}
	[Token(Token = "0x2000121")]
	[ExecuteInEditMode]
	public class ChaseCam : MonoBehaviour
	{
		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform LookAt;

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform MoveTo;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform RollTo;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Positive]
		public float ChaseTime;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 mVelocity;

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 mRollVelocity;

		[Token(Token = "0x6000B6C")]
		[Address(RVA = "0x10A4D50", Offset = "0x10A4D50", VA = "0x10A4D50")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000B6D")]
		[Address(RVA = "0x10A5000", Offset = "0x10A5000", VA = "0x10A5000")]
		public ChaseCam()
		{
		}
	}
	[Token(Token = "0x2000122")]
	public class CurvyCamController : SplineController
	{
		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x874C08", Offset = "0x874C08")]
		public float MinSpeed;

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		public float MaxSpeed;

		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public float Mass;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		public float Down;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public float Up;

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		public float Fric;

		[Token(Token = "0x6000B6E")]
		[Address(RVA = "0x10ACB90", Offset = "0x10ACB90", VA = "0x10ACB90", Slot = "7")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000B6F")]
		[Address(RVA = "0x10ACC40", Offset = "0x10ACC40", VA = "0x10ACC40", Slot = "28")]
		protected override void Advance(float speed, float deltaTime)
		{
		}

		[Token(Token = "0x6000B70")]
		[Address(RVA = "0x10ACE74", Offset = "0x10ACE74", VA = "0x10ACE74")]
		public CurvyCamController()
		{
		}
	}
	[Token(Token = "0x2000123")]
	public class HeightMetadata : CurvyInterpolatableMetadataBase<float>
	{
		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x874C4C", Offset = "0x874C4C")]
		private float m_Height;

		[Token(Token = "0x1700027B")]
		public override float MetaDataValue
		{
			[Token(Token = "0x6000B71")]
			[Address(RVA = "0x145C860", Offset = "0x145C860", VA = "0x145C860", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000B72")]
		[Address(RVA = "0x145C868", Offset = "0x145C868", VA = "0x145C868", Slot = "6")]
		public override float Interpolate(CurvyInterpolatableMetadataBase<float> nextMetadata, float interpolationTime)
		{
			return default(float);
		}

		[Token(Token = "0x6000B73")]
		[Address(RVA = "0x145C97C", Offset = "0x145C97C", VA = "0x145C97C")]
		public HeightMetadata()
		{
		}
	}
	[Token(Token = "0x2000124")]
	public class InfiniteTrack : MonoBehaviour
	{
		[Token(Token = "0x20001A0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x867BCC", Offset = "0x867BCC")]
		private sealed class <setup>d__22 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40006E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public InfiniteTrack <>4__this;

			[Token(Token = "0x40006E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int <i>5__2;

			[Token(Token = "0x170002EE")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000D9B")]
				[Address(RVA = "0x1816FC0", Offset = "0x1816FC0", VA = "0x1816FC0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170002EF")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000D9D")]
				[Address(RVA = "0x1817028", Offset = "0x1817028", VA = "0x1817028", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000D98")]
			[Address(RVA = "0x1816C4C", Offset = "0x1816C4C", VA = "0x1816C4C")]
			[DebuggerHidden]
			public <setup>d__22(int <>1__state)
			{
			}

			[Token(Token = "0x6000D99")]
			[Address(RVA = "0x1816C78", Offset = "0x1816C78", VA = "0x1816C78", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000D9A")]
			[Address(RVA = "0x1816C7C", Offset = "0x1816C7C", VA = "0x1816C7C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000D9C")]
			[Address(RVA = "0x1816FC8", Offset = "0x1816FC8", VA = "0x1816FC8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CurvySpline TrackSpline;

		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CurvyController Controller;

		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Material RoadMaterial;

		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Text TxtStats;

		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Positive]
		public float CurvationX;

		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Positive]
		public float CurvationY;

		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Positive]
		public float CPStepSize;

		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Positive]
		public int HeadCP;

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Positive]
		public int TailCP;

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "MinAttribute", RVA = "0x874D18", Offset = "0x874D18")]
		public int Sections;

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "MinAttribute", RVA = "0x874D70", Offset = "0x874D70")]
		public int SectionCPCount;

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int mInitState;

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool mUpdateSpline;

		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private int mUpdateIn;

		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private CurvyGenerator[] mGenerators;

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private int mCurrentGen;

		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float lastSectionEndV;

		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector3 mDir;

		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private TimeMeasure timeSpline;

		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private TimeMeasure timeCG;

		[Token(Token = "0x6000B74")]
		[Address(RVA = "0x145CA04", Offset = "0x145CA04", VA = "0x145CA04")]
		private void Start()
		{
		}

		[Token(Token = "0x6000B75")]
		[Address(RVA = "0x145CAEC", Offset = "0x145CAEC", VA = "0x145CAEC")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000B76")]
		[Address(RVA = "0x145CCDC", Offset = "0x145CCDC", VA = "0x145CCDC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x877660", Offset = "0x877660")]
		private IEnumerator setup()
		{
			return null;
		}

		[Token(Token = "0x6000B77")]
		[Address(RVA = "0x145CD4C", Offset = "0x145CD4C", VA = "0x145CD4C")]
		private CurvyGenerator buildGenerator()
		{
			return null;
		}

		[Token(Token = "0x6000B78")]
		[Address(RVA = "0x145CB70", Offset = "0x145CB70", VA = "0x145CB70")]
		private void advanceTrack()
		{
		}

		[Token(Token = "0x6000B79")]
		[Address(RVA = "0x145D3CC", Offset = "0x145D3CC", VA = "0x145D3CC")]
		private void advanceSections()
		{
		}

		[Token(Token = "0x6000B7A")]
		[Address(RVA = "0x145CA08", Offset = "0x145CA08", VA = "0x145CA08")]
		private void updateStats()
		{
		}

		[Token(Token = "0x6000B7B")]
		[Address(RVA = "0x145D464", Offset = "0x145D464", VA = "0x145D464")]
		private void updateSectionGenerator(CurvyGenerator gen, int startCP, int endCP)
		{
		}

		[Token(Token = "0x6000B7C")]
		[Address(RVA = "0x145D674", Offset = "0x145D674", VA = "0x145D674")]
		public void Track_OnControlPointReached(CurvySplineMoveEventArgs e)
		{
		}

		[Token(Token = "0x6000B7D")]
		[Address(RVA = "0x145D13C", Offset = "0x145D13C", VA = "0x145D13C")]
		private void addTrackCP()
		{
		}

		[Token(Token = "0x6000B7E")]
		[Address(RVA = "0x145D69C", Offset = "0x145D69C", VA = "0x145D69C")]
		public InfiniteTrack()
		{
		}
	}
	[Token(Token = "0x2000125")]
	public class MDJunctionControl : CurvyMetadataBase
	{
		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool UseJunction;

		[Token(Token = "0x6000B7F")]
		[Address(RVA = "0xDEB0D8", Offset = "0xDEB0D8", VA = "0xDEB0D8")]
		public void Toggle()
		{
		}

		[Token(Token = "0x6000B80")]
		[Address(RVA = "0xDEB0E8", Offset = "0xDEB0E8", VA = "0xDEB0E8")]
		public MDJunctionControl()
		{
		}
	}
	[Token(Token = "0x2000126")]
	public class MetaDataController : SplineController
	{
		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x874DC8", Offset = "0x874DC8")]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x874DC8", Offset = "0x874DC8")]
		[SerializeField]
		private float m_MaxHeight;

		[Token(Token = "0x1700027C")]
		public float MaxHeight
		{
			[Token(Token = "0x6000B81")]
			[Address(RVA = "0xDEDCD4", Offset = "0xDEDCD4", VA = "0xDEDCD4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000B82")]
			[Address(RVA = "0xDEDCDC", Offset = "0xDEDCDC", VA = "0xDEDCDC")]
			set
			{
			}
		}

		[Token(Token = "0x6000B83")]
		[Address(RVA = "0xDEDCF0", Offset = "0xDEDCF0", VA = "0xDEDCF0", Slot = "23")]
		protected override void UserAfterInit()
		{
		}

		[Token(Token = "0x6000B84")]
		[Address(RVA = "0xDEDDEC", Offset = "0xDEDDEC", VA = "0xDEDDEC", Slot = "24")]
		protected override void UserAfterUpdate()
		{
		}

		[Token(Token = "0x6000B85")]
		[Address(RVA = "0xDEDCF4", Offset = "0xDEDCF4", VA = "0xDEDCF4")]
		private void setHeight()
		{
		}

		[Token(Token = "0x6000B86")]
		[Address(RVA = "0xDEDDF0", Offset = "0xDEDDF0", VA = "0xDEDDF0")]
		public MetaDataController()
		{
		}
	}
	[Token(Token = "0x2000127")]
	public class MotorController : SplineController
	{
		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x874E6C", Offset = "0x874E6C")]
		public float MaxSpeed;

		[Token(Token = "0x6000B87")]
		[Address(RVA = "0xDF09D8", Offset = "0xDF09D8", VA = "0xDF09D8", Slot = "10")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000B88")]
		[Address(RVA = "0xDF0A98", Offset = "0xDF0A98", VA = "0xDF0A98")]
		public MotorController()
		{
		}
	}
	[Token(Token = "0x2000128")]
	[ExecuteInEditMode]
	public class MoveToNearestPoint : MonoBehaviour
	{
		[Token(Token = "0x40004B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform Lookup;

		[Token(Token = "0x40004B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CurvySpline Spline;

		[Token(Token = "0x40004B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Text StatisticsText;

		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Slider Density;

		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TimeMeasure Timer;

		[Token(Token = "0x6000B89")]
		[Address(RVA = "0xDF0AA8", Offset = "0xDF0AA8", VA = "0xDF0AA8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000B8A")]
		[Address(RVA = "0xDF0CAC", Offset = "0xDF0CAC", VA = "0xDF0CAC")]
		public void OnSliderChange()
		{
		}

		[Token(Token = "0x6000B8B")]
		[Address(RVA = "0xDF0CF8", Offset = "0xDF0CF8", VA = "0xDF0CF8")]
		public MoveToNearestPoint()
		{
		}
	}
	[Token(Token = "0x2000129")]
	public class PaintSpline : MonoBehaviour
	{
		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float StepDistance;

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SplineController Controller;

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Text InfoText;

		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private CurvySpline mSpline;

		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector2 mLastControlPointPos;

		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool mResetSpline;

		[Token(Token = "0x6000B8C")]
		[Address(RVA = "0xDF5624", Offset = "0xDF5624", VA = "0xDF5624")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000B8D")]
		[Address(RVA = "0xDF567C", Offset = "0xDF567C", VA = "0xDF567C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000B8E")]
		[Address(RVA = "0xDF58F8", Offset = "0xDF58F8", VA = "0xDF58F8")]
		private CurvySplineSegment addCP(Vector3 mousePos)
		{
			return null;
		}

		[Token(Token = "0x6000B8F")]
		[Address(RVA = "0xDF5A10", Offset = "0xDF5A10", VA = "0xDF5A10")]
		public PaintSpline()
		{
		}
	}
	[Token(Token = "0x200012A")]
	public class PerformanceAPI : MonoBehaviour
	{
		[Token(Token = "0x40004C2")]
		private const int LOOPS = 20;

		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private List<string> mTests;

		[Token(Token = "0x40004C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<string> mTestResults;

		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private CurvyInterpolation mInterpolation;

		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private CurvyOrientation mOrientation;

		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int mCacheSize;

		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int mControlPointCount;

		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int mTotalSplineLength;

		[Token(Token = "0x40004CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool mUseCache;

		[Token(Token = "0x40004CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
		private bool mUseMultiThreads;

		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int mCurrentTest;

		[Token(Token = "0x40004CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private bool mExecuting;

		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TimeMeasure Timer;

		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private MethodInfo mGUIMethod;

		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private MethodInfo mRunMethod;

		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool mInterpolate_UseDistance;

		[Token(Token = "0x40004D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private int mRefresh_Mode;

		[Token(Token = "0x6000B90")]
		[Address(RVA = "0xDF6098", Offset = "0xDF6098", VA = "0xDF6098")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000B91")]
		[Address(RVA = "0xDF6118", Offset = "0xDF6118", VA = "0xDF6118")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000B92")]
		[Address(RVA = "0xDF7B34", Offset = "0xDF7B34", VA = "0xDF7B34")]
		private void GUI_Interpolate()
		{
		}

		[Token(Token = "0x6000B93")]
		[Address(RVA = "0xDF7CC8", Offset = "0xDF7CC8", VA = "0xDF7CC8")]
		private void Test_Interpolate()
		{
		}

		[Token(Token = "0x6000B94")]
		[Address(RVA = "0xDF82A8", Offset = "0xDF82A8", VA = "0xDF82A8")]
		private void GUI_Refresh()
		{
		}

		[Token(Token = "0x6000B95")]
		[Address(RVA = "0xDF85FC", Offset = "0xDF85FC", VA = "0xDF85FC")]
		private void Work()
		{
		}

		[Token(Token = "0x6000B96")]
		[Address(RVA = "0xDF8658", Offset = "0xDF8658", VA = "0xDF8658")]
		private void work()
		{
		}

		[Token(Token = "0x6000B97")]
		[Address(RVA = "0xDF86B4", Offset = "0xDF86B4", VA = "0xDF86B4")]
		private void Test_Refresh()
		{
		}

		[Token(Token = "0x6000B98")]
		[Address(RVA = "0xDF7F68", Offset = "0xDF7F68", VA = "0xDF7F68")]
		private CurvySpline getSpline()
		{
			return null;
		}

		[Token(Token = "0x6000B99")]
		[Address(RVA = "0xDF8028", Offset = "0xDF8028", VA = "0xDF8028")]
		private void addRandomCP(ref CurvySpline spline, int count, int totalLength)
		{
		}

		[Token(Token = "0x6000B9A")]
		[Address(RVA = "0xDF88EC", Offset = "0xDF88EC", VA = "0xDF88EC")]
		private void runTest()
		{
		}

		[Token(Token = "0x6000B9B")]
		[Address(RVA = "0xDF8928", Offset = "0xDF8928", VA = "0xDF8928")]
		public PerformanceAPI()
		{
		}
	}
	[Token(Token = "0x200012B")]
	public class PerformanceDynamicSpline : MonoBehaviour
	{
		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CurvySpline mSpline;

		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CurvyGenerator Generator;

		[Token(Token = "0x40004D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Positive]
		public int UpdateInterval;

		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x874EC0", Offset = "0x874EC0")]
		public int CPCount;

		[Token(Token = "0x40004D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Positive]
		public float Radius;

		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool AlwaysClear;

		[Token(Token = "0x40004D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		public bool UpdateCG;

		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float mAngleStep;

		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float mCurrentAngle;

		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float mLastUpdateTime;

		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TimeMeasure ExecTimes;

		[Token(Token = "0x6000B9C")]
		[Address(RVA = "0xDF8A00", Offset = "0xDF8A00", VA = "0xDF8A00")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000B9D")]
		[Address(RVA = "0xDF8A58", Offset = "0xDF8A58", VA = "0xDF8A58")]
		private void Start()
		{
		}

		[Token(Token = "0x6000B9E")]
		[Address(RVA = "0xDF8C14", Offset = "0xDF8C14", VA = "0xDF8C14")]
		private void Update()
		{
		}

		[Token(Token = "0x6000B9F")]
		[Address(RVA = "0xDF8AC8", Offset = "0xDF8AC8", VA = "0xDF8AC8")]
		private void addCP()
		{
		}

		[Token(Token = "0x6000BA0")]
		[Address(RVA = "0xDF8D84", Offset = "0xDF8D84", VA = "0xDF8D84")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000BA1")]
		[Address(RVA = "0xDF9770", Offset = "0xDF9770", VA = "0xDF9770")]
		public PerformanceDynamicSpline()
		{
		}
	}
	[Token(Token = "0x200012C")]
	public class PoolTestRunner : MonoBehaviour
	{
		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CurvySpline Spline;

		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Text PoolCountInfo;

		[Token(Token = "0x6000BA2")]
		[Address(RVA = "0xDFAABC", Offset = "0xDFAABC", VA = "0xDFAABC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000BA3")]
		[Address(RVA = "0xDFABA8", Offset = "0xDFABA8", VA = "0xDFABA8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000BA4")]
		[Address(RVA = "0xDFAAC0", Offset = "0xDFAAC0", VA = "0xDFAAC0")]
		private void checkForSpline()
		{
		}

		[Token(Token = "0x6000BA5")]
		[Address(RVA = "0xDFAC90", Offset = "0xDFAC90", VA = "0xDFAC90")]
		public void AddCP()
		{
		}

		[Token(Token = "0x6000BA6")]
		[Address(RVA = "0xDFAD88", Offset = "0xDFAD88", VA = "0xDFAD88")]
		public void DeleteCP()
		{
		}

		[Token(Token = "0x6000BA7")]
		[Address(RVA = "0xDFAE84", Offset = "0xDFAE84", VA = "0xDFAE84")]
		public void ClearSpline()
		{
		}

		[Token(Token = "0x6000BA8")]
		[Address(RVA = "0xDFAF14", Offset = "0xDFAF14", VA = "0xDFAF14")]
		public void DeleteSpline()
		{
		}

		[Token(Token = "0x6000BA9")]
		[Address(RVA = "0xDFAFA4", Offset = "0xDFAFA4", VA = "0xDFAFA4")]
		public PoolTestRunner()
		{
		}
	}
	[Token(Token = "0x200012D")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x867730", Offset = "0x867730")]
	public class RigidBodySplineController : MonoBehaviour
	{
		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CurvySpline Spline;

		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SplineController CameraController;

		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float VSpeed;

		[Token(Token = "0x40004E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float HSpeed;

		[Token(Token = "0x40004E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float CenterDrag;

		[Token(Token = "0x40004E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float JumpForce;

		[Token(Token = "0x40004E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Rigidbody mRigidBody;

		[Token(Token = "0x40004E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float mTF;

		[Token(Token = "0x40004E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float velocity;

		[Token(Token = "0x6000BAA")]
		[Address(RVA = "0xDFC6D0", Offset = "0xDFC6D0", VA = "0xDFC6D0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000BAB")]
		[Address(RVA = "0xDFC728", Offset = "0xDFC728", VA = "0xDFC728")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000BAC")]
		[Address(RVA = "0xDFC834", Offset = "0xDFC834", VA = "0xDFC834")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000BAD")]
		[Address(RVA = "0xDFCBFC", Offset = "0xDFCBFC", VA = "0xDFCBFC")]
		public RigidBodySplineController()
		{
		}
	}
	[Token(Token = "0x200012E")]
	public class RunnerController : SplineController
	{
		[Token(Token = "0x20001A1")]
		private enum GuideMode
		{
			[Token(Token = "0x40006E7")]
			Guided,
			[Token(Token = "0x40006E8")]
			Jumping,
			[Token(Token = "0x40006E9")]
			FreeFall
		}

		[Token(Token = "0x20001A2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x867BDC", Offset = "0x867BDC")]
		private sealed class <Jump>d__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40006EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RunnerController <>4__this;

			[Token(Token = "0x40006ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <start>5__2;

			[Token(Token = "0x40006EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <f>5__3;

			[Token(Token = "0x170002F0")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000DA1")]
				[Address(RVA = "0x181C05C", Offset = "0x181C05C", VA = "0x181C05C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170002F1")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000DA3")]
				[Address(RVA = "0x181C0C4", Offset = "0x181C0C4", VA = "0x181C0C4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000D9E")]
			[Address(RVA = "0x181BEFC", Offset = "0x181BEFC", VA = "0x181BEFC")]
			[DebuggerHidden]
			public <Jump>d__13(int <>1__state)
			{
			}

			[Token(Token = "0x6000D9F")]
			[Address(RVA = "0x181BF28", Offset = "0x181BF28", VA = "0x181BF28", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000DA0")]
			[Address(RVA = "0x181BF2C", Offset = "0x181BF2C", VA = "0x181BF2C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000DA2")]
			[Address(RVA = "0x181C064", Offset = "0x181C064", VA = "0x181C064", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x874F30", Offset = "0x874F30")]
		public float JumpHeight;

		[Token(Token = "0x40004EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		public float JumpSpeed;

		[Token(Token = "0x40004EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public AnimationCurve JumpCurve;

		[Token(Token = "0x40004EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public float Gravity;

		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private GuideMode mMode;

		[Token(Token = "0x40004EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private float jumpHeight;

		[Token(Token = "0x40004EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private float fallingSpeed;

		[Token(Token = "0x40004F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private SplineRefMetadata mPossibleSwitchTarget;

		[Token(Token = "0x40004F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private int mSwitchInProgress;

		[Token(Token = "0x6000BAE")]
		[Address(RVA = "0xDFCC10", Offset = "0xDFCC10", VA = "0xDFCC10", Slot = "9")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x6000BAF")]
		[Address(RVA = "0xDFCC3C", Offset = "0xDFCC3C", VA = "0xDFCC3C", Slot = "15")]
		protected override void InitializedApplyDeltaTime(float deltaTime)
		{
		}

		[Token(Token = "0x6000BB0")]
		[Address(RVA = "0xDFCF40", Offset = "0xDFCF40", VA = "0xDFCF40")]
		private void Switch(int dir)
		{
		}

		[Token(Token = "0x6000BB1")]
		[Address(RVA = "0xDFCED0", Offset = "0xDFCED0", VA = "0xDFCED0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8776C4", Offset = "0x8776C4")]
		private IEnumerator Jump()
		{
			return null;
		}

		[Token(Token = "0x6000BB2")]
		[Address(RVA = "0xDFD0D4", Offset = "0xDFD0D4", VA = "0xDFD0D4")]
		public void OnCPReached(CurvySplineMoveEventArgs e)
		{
		}

		[Token(Token = "0x6000BB3")]
		[Address(RVA = "0xDFD1B4", Offset = "0xDFD1B4", VA = "0xDFD1B4")]
		public void UseFollowUpOrFall(CurvySplineMoveEventArgs e)
		{
		}

		[Token(Token = "0x6000BB4")]
		[Address(RVA = "0xDFD37C", Offset = "0xDFD37C", VA = "0xDFD37C")]
		public RunnerController()
		{
		}
	}
	[Token(Token = "0x200012F")]
	public class SceneSwitcher : MonoBehaviour
	{
		[Token(Token = "0x40004F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Text Text;

		[Token(Token = "0x40004F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Dropdown DropDown;

		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Dictionary<string, string> scenesAlternativeNames;

		[Token(Token = "0x1700027D")]
		private int CurrentLevel
		{
			[Token(Token = "0x6000BB6")]
			[Address(RVA = "0xB14D8C", Offset = "0xB14D8C", VA = "0xB14D8C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000BB7")]
			[Address(RVA = "0xB14E04", Offset = "0xB14E04", VA = "0xB14E04")]
			set
			{
			}
		}

		[Token(Token = "0x6000BB5")]
		[Address(RVA = "0xB14A6C", Offset = "0xB14A6C", VA = "0xB14A6C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000BB8")]
		[Address(RVA = "0xB14BC4", Offset = "0xB14BC4", VA = "0xB14BC4")]
		private List<string> getScenes()
		{
			return null;
		}

		[Token(Token = "0x6000BB9")]
		[Address(RVA = "0xB14EE8", Offset = "0xB14EE8", VA = "0xB14EE8")]
		private void OnValueChanged(int value)
		{
		}

		[Token(Token = "0x6000BBA")]
		[Address(RVA = "0xB14F04", Offset = "0xB14F04", VA = "0xB14F04")]
		public SceneSwitcher()
		{
		}
	}
	[Token(Token = "0x2000130")]
	public class SmoothFollow : MonoBehaviour
	{
		[Token(Token = "0x40004F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform target;

		[Token(Token = "0x40004F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float distance;

		[Token(Token = "0x40004F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float height;

		[Token(Token = "0x40004F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float rotationDamping;

		[Token(Token = "0x40004F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float heightDamping;

		[Token(Token = "0x6000BBB")]
		[Address(RVA = "0xB15F08", Offset = "0xB15F08", VA = "0xB15F08")]
		private void Start()
		{
		}

		[Token(Token = "0x6000BBC")]
		[Address(RVA = "0xB15F0C", Offset = "0xB15F0C", VA = "0xB15F0C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000BBD")]
		[Address(RVA = "0xB1621C", Offset = "0xB1621C", VA = "0xB1621C")]
		public SmoothFollow()
		{
		}
	}
	[Token(Token = "0x2000131")]
	public class SplineControllerInputRail : MonoBehaviour
	{
		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float acceleration;

		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float limit;

		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SplineController splineController;

		[Token(Token = "0x6000BBE")]
		[Address(RVA = "0xB1938C", Offset = "0xB1938C", VA = "0xB1938C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000BBF")]
		[Address(RVA = "0xB19470", Offset = "0xB19470", VA = "0xB19470")]
		public SplineControllerInputRail()
		{
		}
	}
	[Token(Token = "0x2000132")]
	public class SplineRefMetadata : CurvyMetadataBase
	{
		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public new CurvySpline Spline;

		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public CurvySplineSegment CP;

		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string Options;

		[Token(Token = "0x6000BC0")]
		[Address(RVA = "0xB1D20C", Offset = "0xB1D20C", VA = "0xB1D20C")]
		public SplineRefMetadata()
		{
		}
	}
	[Token(Token = "0x2000133")]
	[ExecuteInEditMode]
	public class TrainCarDrifter : MonoBehaviour
	{
		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float speed;

		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float wheelSpacing;

		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 bodyOffset;

		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public SplineController controllerWheelLeading;

		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public SplineController controllerWheelTrailing;

		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform trainCar;

		[Token(Token = "0x6000BC1")]
		[Address(RVA = "0x1810504", Offset = "0x1810504", VA = "0x1810504")]
		private void Start()
		{
		}

		[Token(Token = "0x6000BC2")]
		[Address(RVA = "0x1810528", Offset = "0x1810528", VA = "0x1810528")]
		private void Update()
		{
		}

		[Token(Token = "0x6000BC3")]
		[Address(RVA = "0x18109EC", Offset = "0x18109EC", VA = "0x18109EC")]
		public TrainCarDrifter()
		{
		}
	}
	[Token(Token = "0x2000134")]
	[ExecuteInEditMode]
	public class TrainCarManager : MonoBehaviour
	{
		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SplineController Waggon;

		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SplineController FrontAxis;

		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public SplineController BackAxis;

		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TrainManager mTrain;

		[Token(Token = "0x1700027E")]
		public float Position
		{
			[Token(Token = "0x6000BC4")]
			[Address(RVA = "0x1810A04", Offset = "0x1810A04", VA = "0x1810A04")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000BC5")]
			[Address(RVA = "0x1810A20", Offset = "0x1810A20", VA = "0x1810A20")]
			set
			{
			}
		}

		[Token(Token = "0x6000BC6")]
		[Address(RVA = "0x1810AD4", Offset = "0x1810AD4", VA = "0x1810AD4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000BC7")]
		[Address(RVA = "0x1810CD0", Offset = "0x1810CD0", VA = "0x1810CD0")]
		public void setup()
		{
		}

		[Token(Token = "0x6000BC8")]
		[Address(RVA = "0x1810DC4", Offset = "0x1810DC4", VA = "0x1810DC4")]
		private void setController(SplineController c, CurvySpline spline, float speed)
		{
		}

		[Token(Token = "0x6000BC9")]
		[Address(RVA = "0x1810EA0", Offset = "0x1810EA0", VA = "0x1810EA0")]
		public void OnCPReached(CurvySplineMoveEventArgs e)
		{
		}

		[Token(Token = "0x6000BCA")]
		[Address(RVA = "0x1810F68", Offset = "0x1810F68", VA = "0x1810F68")]
		public TrainCarManager()
		{
		}
	}
	[Token(Token = "0x2000135")]
	[ExecuteInEditMode]
	public class TrainManager : MonoBehaviour
	{
		[Token(Token = "0x400050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CurvySpline Spline;

		[Token(Token = "0x400050B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float Speed;

		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float Position;

		[Token(Token = "0x400050D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float CarSize;

		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float AxisDistance;

		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float CarGap;

		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float Limit;

		[Token(Token = "0x4000511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool isSetup;

		[Token(Token = "0x4000512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TrainCarManager[] Cars;

		[Token(Token = "0x6000BCB")]
		[Address(RVA = "0x1810F70", Offset = "0x1810F70", VA = "0x1810F70")]
		private void Start()
		{
		}

		[Token(Token = "0x6000BCC")]
		[Address(RVA = "0x181117C", Offset = "0x181117C", VA = "0x181117C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000BCD")]
		[Address(RVA = "0x1811184", Offset = "0x1811184", VA = "0x1811184")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000BCE")]
		[Address(RVA = "0x1810F74", Offset = "0x1810F74", VA = "0x1810F74")]
		private void setup()
		{
		}

		[Token(Token = "0x6000BCF")]
		[Address(RVA = "0x18113C4", Offset = "0x18113C4", VA = "0x18113C4")]
		public TrainManager()
		{
		}
	}
	[Token(Token = "0x2000136")]
	public class VolumeControllerInput : MonoBehaviour
	{
		[Token(Token = "0x4000513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float AngularVelocity;

		[Token(Token = "0x4000514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ParticleSystem explosionEmitter;

		[Token(Token = "0x4000515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public VolumeController volumeController;

		[Token(Token = "0x4000516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform rotatedTransform;

		[Token(Token = "0x4000517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float maxSpeed;

		[Token(Token = "0x4000518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float accelerationForward;

		[Token(Token = "0x4000519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float accelerationBackward;

		[Token(Token = "0x400051A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private bool mGameOver;

		[Token(Token = "0x6000BD0")]
		[Address(RVA = "0x1815810", Offset = "0x1815810", VA = "0x1815810")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000BD1")]
		[Address(RVA = "0x181589C", Offset = "0x181589C", VA = "0x181589C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000BD2")]
		[Address(RVA = "0x181596C", Offset = "0x181596C", VA = "0x181596C")]
		private void ResetController()
		{
		}

		[Token(Token = "0x6000BD3")]
		[Address(RVA = "0x18159D4", Offset = "0x18159D4", VA = "0x18159D4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000BD4")]
		[Address(RVA = "0x1815C9C", Offset = "0x1815C9C", VA = "0x1815C9C")]
		public void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000BD5")]
		[Address(RVA = "0x1815CA0", Offset = "0x1815CA0", VA = "0x1815CA0")]
		public void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000BD6")]
		[Address(RVA = "0x1815D3C", Offset = "0x1815D3C", VA = "0x1815D3C")]
		private void StartOver()
		{
		}

		[Token(Token = "0x6000BD7")]
		[Address(RVA = "0x1815D60", Offset = "0x1815D60", VA = "0x1815D60")]
		public VolumeControllerInput()
		{
		}

		[Token(Token = "0x6000BD8")]
		[Address(RVA = "0x1815D88", Offset = "0x1815D88", VA = "0x1815D88")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x877728", Offset = "0x877728")]
		private void <Start>b__9_0(CurvyController arg0)
		{
		}
	}
}
namespace CrazyMinnow.SALSA.OneClicks
{
	[Token(Token = "0x2000137")]
	public class OneClickBase : MonoBehaviour
	{
		[Token(Token = "0x400051B")]
		public const string RESOURCE_CLIP = "Assets/Crazy Minnow Studio/Examples/Audio/Promo-male.mp3";

		[Token(Token = "0x400051C")]
		public const string PREFAB_ALERT_TITLE = "Prefab Unpack Warning";

		[Token(Token = "0x400051D")]
		public const string PREFAB_ALERT_MSG = "Your selection is a prefab and must be unpacked to apply this setup. You can create a new prefab once the setup is complete. Do you want to proceed?";

		[Token(Token = "0x400051E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected static List<SkinnedMeshRenderer> requiredSmrs;

		[Token(Token = "0x400051F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		protected static List<OneClickConfiguration> oneClickConfigurations;

		[Token(Token = "0x4000520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected static Salsa salsa;

		[Token(Token = "0x4000521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected static Emoter emoter;

		[Token(Token = "0x4000522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected static UmaUepProxy uepProxy;

		[Token(Token = "0x4000523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected static GameObject selectedObject;

		[Token(Token = "0x4000524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected static float emphasizerTrigger;

		[Token(Token = "0x4000525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		protected static bool autoAdjustAnalysis;

		[Token(Token = "0x4000526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		protected static bool autoAdjustMicrophone;

		[Token(Token = "0x4000527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected static float audioUpdateDelay;

		[Token(Token = "0x4000528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		protected static float loCutoff;

		[Token(Token = "0x4000529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected static float hiCutoff;

		[Token(Token = "0x400052A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		protected static bool useAdvDyn;

		[Token(Token = "0x400052B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected static float advDynPrimaryBias;

		[Token(Token = "0x400052C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		protected static bool useAdvDynJitter;

		[Token(Token = "0x400052D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected static float advDynJitterAmount;

		[Token(Token = "0x400052E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		protected static float advDynJitterProb;

		[Token(Token = "0x400052F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected static float advDynSecondaryMix;

		[Token(Token = "0x4000530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		protected static float emphasisChance;

		[Token(Token = "0x4000531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected static bool useRandomEmotes;

		[Token(Token = "0x4000532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		protected static bool isChancePerEmote;

		[Token(Token = "0x4000533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		protected static int numRandomEmotesPerCycle;

		[Token(Token = "0x4000534")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		protected static float randomEmoteMinTimer;

		[Token(Token = "0x4000535")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		protected static float randomEmoteMaxTimer;

		[Token(Token = "0x4000536")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		protected static float randomChance;

		[Token(Token = "0x4000537")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		protected static bool useRandomFrac;

		[Token(Token = "0x4000538")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected static float randomFracBias;

		[Token(Token = "0x4000539")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		protected static bool useRandomHoldDuration;

		[Token(Token = "0x400053A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		protected static float randomHoldDurationMin;

		[Token(Token = "0x400053B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		protected static float randomHoldDurationMax;

		[Token(Token = "0x400053C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		protected static LerpEasings.EasingType easingType;

		[Token(Token = "0x400053D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static OneClickConfiguration currentConfiguration;

		[Token(Token = "0x6000BD9")]
		[Address(RVA = "0xDF1108", Offset = "0xDF1108", VA = "0xDF1108")]
		protected static void NewConfiguration(OneClickConfiguration.ConfigType configType)
		{
		}

		[Token(Token = "0x6000BDA")]
		[Address(RVA = "0xDF12D0", Offset = "0xDF12D0", VA = "0xDF12D0")]
		protected static void AddSmrSearch(string search)
		{
		}

		[Token(Token = "0x6000BDB")]
		[Address(RVA = "0xDF135C", Offset = "0xDF135C", VA = "0xDF135C")]
		protected static void NewExpression(string expressionName)
		{
		}

		[Token(Token = "0x6000BDC")]
		[Address(RVA = "0xDF1544", Offset = "0xDF1544", VA = "0xDF1544")]
		protected static void AddShapeComponent(string[] blendshapeNames, float durOn, float durHold, float durOff, string componentName = "", float amount = 1f, bool useRegex = false)
		{
		}

		[Token(Token = "0x6000BDD")]
		[Address(RVA = "0xDF16F8", Offset = "0xDF16F8", VA = "0xDF16F8")]
		protected static void AddUepPoseComponent(string poseName, float durOn, float durHold, float durOff, string componentName = "", float amount = 1f)
		{
		}

		[Token(Token = "0x6000BDE")]
		[Address(RVA = "0xDF1888", Offset = "0xDF1888", VA = "0xDF1888")]
		protected static void AddAnimatorComponent(string componentName, string animatorSearch, float durOn, float durHold, float durOff, int parmIndex, bool isTriggereParmBiDir = false)
		{
		}

		[Token(Token = "0x6000BDF")]
		[Address(RVA = "0xDF19BC", Offset = "0xDF19BC", VA = "0xDF19BC")]
		protected static void AddBoneComponent(string componentSearchName, TformBase maxTform, float durOn, float durHold, float durOff, string componentName = "", bool constrainPos = false, bool constrainRot = true, bool constrainScl = false)
		{
		}

		[Token(Token = "0x6000BE0")]
		[Address(RVA = "0xDF1BEC", Offset = "0xDF1BEC", VA = "0xDF1BEC")]
		protected static void AddEmoteFlags(bool isRandom, bool isEmph, bool isRepeater, float frac = 1f, bool isAlwaysEmph = false)
		{
		}

		[Token(Token = "0x6000BE1")]
		[Address(RVA = "0xDF1D38", Offset = "0xDF1D38", VA = "0xDF1D38")]
		protected static void DoOneClickiness(GameObject go, AudioClip clip)
		{
		}

		[Token(Token = "0x6000BE2")]
		[Address(RVA = "0xDF2000", Offset = "0xDF2000", VA = "0xDF2000")]
		private static bool FindSkinnedMeshRenderers(OneClickConfiguration configuration)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BE3")]
		[Address(RVA = "0xDF2848", Offset = "0xDF2848", VA = "0xDF2848")]
		private static void ConfigEmoterSettings(QueueProcessor qp)
		{
		}

		[Token(Token = "0x6000BE4")]
		[Address(RVA = "0xDF248C", Offset = "0xDF248C", VA = "0xDF248C")]
		private static void ConfigureSalsaSettings(AudioClip clip, QueueProcessor qp)
		{
		}

		[Token(Token = "0x6000BE5")]
		[Address(RVA = "0xDF3510", Offset = "0xDF3510", VA = "0xDF3510")]
		protected static void Init()
		{
		}

		[Token(Token = "0x6000BE6")]
		[Address(RVA = "0xDF2B2C", Offset = "0xDF2B2C", VA = "0xDF2B2C")]
		private static void ConfigureModuleExpressions(OneClickConfiguration configuration)
		{
		}

		[Token(Token = "0x6000BE7")]
		[Address(RVA = "0xDF35AC", Offset = "0xDF35AC", VA = "0xDF35AC")]
		private static Expression InitializeExpressionType(OneClickConfiguration configuration, int exp)
		{
			return null;
		}

		[Token(Token = "0x6000BE8")]
		[Address(RVA = "0xDF3964", Offset = "0xDF3964", VA = "0xDF3964")]
		private static int RegexFindBlendshapeName(SkinnedMeshRenderer smr, string bName)
		{
			return default(int);
		}

		[Token(Token = "0x6000BE9")]
		[Address(RVA = "0xDF3FD0", Offset = "0xDF3FD0", VA = "0xDF3FD0")]
		private static string[] GetBlendshapeNames(SkinnedMeshRenderer smr)
		{
			return null;
		}

		[Token(Token = "0x6000BEA")]
		[Address(RVA = "0xDF3D74", Offset = "0xDF3D74", VA = "0xDF3D74")]
		private static TformBase ConvertBoneToTform(Transform bone)
		{
			return default(TformBase);
		}

		[Token(Token = "0x6000BEB")]
		[Address(RVA = "0xDF3C44", Offset = "0xDF3C44", VA = "0xDF3C44")]
		private static Transform FindBone(string componentSearchName)
		{
			return null;
		}

		[Token(Token = "0x6000BEC")]
		[Address(RVA = "0xDF3EA0", Offset = "0xDF3EA0", VA = "0xDF3EA0")]
		private static Animator FindAnimator(string componentSearchName)
		{
			return null;
		}

		[Token(Token = "0x6000BED")]
		[Address(RVA = "0xDF3B58", Offset = "0xDF3B58", VA = "0xDF3B58")]
		private static void ApplyCommonSettingsToComponent(ExpressionComponent component, OneClickComponent oneClickComponent, int componentNumber)
		{
		}

		[Token(Token = "0x6000BEE")]
		[Address(RVA = "0xDF3A6C", Offset = "0xDF3A6C", VA = "0xDF3A6C")]
		private static int CreateNewComponent(int componentCount, Expression expression)
		{
			return default(int);
		}

		[Token(Token = "0x6000BEF")]
		[Address(RVA = "0xDF4100", Offset = "0xDF4100", VA = "0xDF4100")]
		public OneClickBase()
		{
		}
	}
	[Token(Token = "0x2000138")]
	public class OneClickBoxHead : OneClickBase
	{
		[Token(Token = "0x6000BF1")]
		[Address(RVA = "0xDF42AC", Offset = "0xDF42AC", VA = "0xDF42AC")]
		public static void Setup(GameObject gameObject, AudioClip clip)
		{
		}

		[Token(Token = "0x6000BF2")]
		[Address(RVA = "0xDF492C", Offset = "0xDF492C", VA = "0xDF492C")]
		public OneClickBoxHead()
		{
		}
	}
	[Token(Token = "0x2000139")]
	public class OneClickBoxHeadEyes : MonoBehaviour
	{
		[Token(Token = "0x6000BF3")]
		[Address(RVA = "0xDF4994", Offset = "0xDF4994", VA = "0xDF4994")]
		public static void Setup(GameObject go)
		{
		}

		[Token(Token = "0x6000BF4")]
		[Address(RVA = "0xDF534C", Offset = "0xDF534C", VA = "0xDF534C")]
		public OneClickBoxHeadEyes()
		{
		}
	}
	[Token(Token = "0x200013A")]
	public class OneClickComponent
	{
		[Token(Token = "0x20001A3")]
		public enum ComponentType
		{
			[Token(Token = "0x40006F0")]
			Shape,
			[Token(Token = "0x40006F1")]
			UMA,
			[Token(Token = "0x40006F2")]
			Bone,
			[Token(Token = "0x40006F3")]
			Animator
		}

		[Token(Token = "0x400053E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ComponentType type;

		[Token(Token = "0x400053F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string componentName;

		[Token(Token = "0x4000540")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float durOn;

		[Token(Token = "0x4000541")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float durHold;

		[Token(Token = "0x4000542")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float durOff;

		[Token(Token = "0x6000BF5")]
		[Address(RVA = "0xDF1100", Offset = "0xDF1100", VA = "0xDF1100")]
		public OneClickComponent()
		{
		}
	}
	[Token(Token = "0x200013B")]
	public class OneClickShapeComponent : OneClickComponent
	{
		[Token(Token = "0x4000543")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string[] blendshapeNames;

		[Token(Token = "0x4000544")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float maxAmount;

		[Token(Token = "0x4000545")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool useRegex;

		[Token(Token = "0x6000BF6")]
		[Address(RVA = "0xDF1674", Offset = "0xDF1674", VA = "0xDF1674")]
		public OneClickShapeComponent(string componentName, string[] blendshapeNames, float maxAmount, float durOn, float durHold, float durOff, ComponentType type, bool useRegex)
		{
		}
	}
	[Token(Token = "0x200013C")]
	public class OneClickBoneComponent : OneClickComponent
	{
		[Token(Token = "0x4000546")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string componentSearchName;

		[Token(Token = "0x4000547")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public TformBase max;

		[Token(Token = "0x4000548")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool usePos;

		[Token(Token = "0x4000549")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		public bool useRot;

		[Token(Token = "0x400054A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		public bool useScl;

		[Token(Token = "0x6000BF7")]
		[Address(RVA = "0xDF1B38", Offset = "0xDF1B38", VA = "0xDF1B38")]
		public OneClickBoneComponent(string componentName, string boneSearchName, TformBase max, bool usePos, bool useRot, bool useScl, float durOn, float durHold, float durOff, ComponentType type)
		{
		}
	}
	[Token(Token = "0x200013D")]
	public class OneClickUepComponent : OneClickComponent
	{
		[Token(Token = "0x400054B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string poseName;

		[Token(Token = "0x400054C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float maxAmount;

		[Token(Token = "0x6000BF8")]
		[Address(RVA = "0xDF1818", Offset = "0xDF1818", VA = "0xDF1818")]
		public OneClickUepComponent(string componentName, string poseName, float maxAmount, float durOn, float durHold, float durOff, ComponentType type)
		{
		}
	}
	[Token(Token = "0x200013E")]
	public class OneClickAnimatorComponent : OneClickComponent
	{
		[Token(Token = "0x400054D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string componentSearchName;

		[Token(Token = "0x400054E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int animationParmIndex;

		[Token(Token = "0x400054F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool isTriggerParmBiDirectional;

		[Token(Token = "0x6000BF9")]
		[Address(RVA = "0xDF107C", Offset = "0xDF107C", VA = "0xDF107C")]
		public OneClickAnimatorComponent(string componentName, string animatorSearchName, int animationParmIndex, bool isTriggerParmBiDirectional, float durOn, float durHold, float durOff, ComponentType type)
		{
		}
	}
	[Token(Token = "0x200013F")]
	public class OneClickConfiguration
	{
		[Token(Token = "0x20001A4")]
		public enum ConfigType
		{
			[Token(Token = "0x40006F5")]
			Salsa,
			[Token(Token = "0x40006F6")]
			Emoter
		}

		[Token(Token = "0x4000550")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ConfigType type;

		[Token(Token = "0x4000551")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<string> smrSearches;

		[Token(Token = "0x4000552")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<OneClickExpression> oneClickExpressions;

		[Token(Token = "0x6000BFA")]
		[Address(RVA = "0xDF11F4", Offset = "0xDF11F4", VA = "0xDF11F4")]
		public OneClickConfiguration(ConfigType type)
		{
		}
	}
	[Token(Token = "0x2000140")]
	public class OneClickExpression
	{
		[Token(Token = "0x4000553")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x4000554")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<OneClickComponent> components;

		[Token(Token = "0x6000BFB")]
		[Address(RVA = "0xDF5354", Offset = "0xDF5354", VA = "0xDF5354")]
		public OneClickExpression()
		{
		}

		[Token(Token = "0x6000BFC")]
		[Address(RVA = "0xDF14CC", Offset = "0xDF14CC", VA = "0xDF14CC")]
		public OneClickExpression(string name, List<OneClickComponent> components)
		{
		}
	}
	[Token(Token = "0x2000141")]
	public class OneClickEmoterExpression : OneClickExpression
	{
		[Token(Token = "0x4000555")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool isRandom;

		[Token(Token = "0x4000556")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool isEmphasis;

		[Token(Token = "0x4000557")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		public bool isAlwaysEmphasis;

		[Token(Token = "0x4000558")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x23")]
		public bool isRepeater;

		[Token(Token = "0x4000559")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float expressionDynamics;

		[Token(Token = "0x6000BFD")]
		[Address(RVA = "0xDF1504", Offset = "0xDF1504", VA = "0xDF1504")]
		public OneClickEmoterExpression(string name, List<OneClickComponent> components)
		{
		}

		[Token(Token = "0x6000BFE")]
		[Address(RVA = "0xDF1D10", Offset = "0xDF1D10", VA = "0xDF1D10")]
		public void SetEmoterBools(bool isRand, bool isEmph, bool isRep, float frac, bool isAlwaysEmph = false)
		{
		}
	}
}
