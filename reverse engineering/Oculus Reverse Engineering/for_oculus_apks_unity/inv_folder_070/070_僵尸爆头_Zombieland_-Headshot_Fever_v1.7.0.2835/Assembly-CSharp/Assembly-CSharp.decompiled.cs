using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using Il2CppDummyDll;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class KillTime : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x18")]
	public float KillDelayTime;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x2CFD048", Offset = "0x2CFD048", VA = "0x2CFD048")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x2CFD0D0", Offset = "0x2CFD0D0", VA = "0x2CFD0D0")]
	public KillTime()
	{
	}
}
[Token(Token = "0x2000003")]
public class PlayFX : MonoBehaviour
{
	[Token(Token = "0x2000004")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC40648", Offset = "0xC40648")]
	private sealed class <PlayEffect>d__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000004")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000005")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x20")]
		public PlayFX <>4__this;

		[Token(Token = "0x17000001")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000009")]
			[Address(RVA = "0x2CFD314", Offset = "0x2CFD314", VA = "0x2CFD314", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000002")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600000B")]
			[Address(RVA = "0x2CFD35C", Offset = "0x2CFD35C", VA = "0x2CFD35C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0x2CFD184", Offset = "0x2CFD184", VA = "0x2CFD184")]
		[DebuggerHidden]
		public <PlayEffect>d__3(int <>1__state)
		{
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0x2CFD1B8", Offset = "0x2CFD1B8", VA = "0x2CFD1B8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000008")]
		[Address(RVA = "0x2CFD1BC", Offset = "0x2CFD1BC", VA = "0x2CFD1BC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x2CFD31C", Offset = "0x2CFD31C", VA = "0x2CFD31C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x18")]
	public Transform effectToPlay;

	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x20")]
	public Vector3 effectPos;

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x2CFD0E0", Offset = "0x2CFD0E0", VA = "0x2CFD0E0")]
	private void OnMouseDown()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x2CFD10C", Offset = "0x2CFD10C", VA = "0x2CFD10C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xC40658", Offset = "0xC40658")]
	private IEnumerator PlayEffect()
	{
		return null;
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x2CFD1B0", Offset = "0x2CFD1B0", VA = "0x2CFD1B0")]
	public PlayFX()
	{
	}
}
