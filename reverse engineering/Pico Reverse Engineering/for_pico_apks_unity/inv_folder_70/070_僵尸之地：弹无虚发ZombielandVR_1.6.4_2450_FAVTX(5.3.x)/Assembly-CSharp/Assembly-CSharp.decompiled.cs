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
	[FieldOffset(Offset = "0xC")]
	public float KillDelayTime;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x2C63718", Offset = "0x2C63718", VA = "0x2C63718")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x2C637B0", Offset = "0x2C637B0", VA = "0x2C637B0")]
	public KillTime()
	{
	}
}
[Token(Token = "0x2000003")]
public class PlayFX : MonoBehaviour
{
	[Token(Token = "0x2000004")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6328C8", Offset = "0x6328C8")]
	private sealed class <PlayEffect>d__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000004")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		[Token(Token = "0x4000005")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x10")]
		public PlayFX <>4__this;

		[Token(Token = "0x17000001")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000009")]
			[Address(RVA = "0x2C63A24", Offset = "0x2C63A24", VA = "0x2C63A24", Slot = "4")]
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
			[Address(RVA = "0x2C63A74", Offset = "0x2C63A74", VA = "0x2C63A74", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0x2C6386C", Offset = "0x2C6386C", VA = "0x2C6386C")]
		[DebuggerHidden]
		public <PlayEffect>d__3(int <>1__state)
		{
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0x2C63894", Offset = "0x2C63894", VA = "0x2C63894", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000008")]
		[Address(RVA = "0x2C63898", Offset = "0x2C63898", VA = "0x2C63898", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x2C63A2C", Offset = "0x2C63A2C", VA = "0x2C63A2C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0xC")]
	public Transform effectToPlay;

	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x10")]
	public Vector3 effectPos;

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x2C637C0", Offset = "0x2C637C0", VA = "0x2C637C0")]
	private void OnMouseDown()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x2C637E4", Offset = "0x2C637E4", VA = "0x2C637E4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6328D8", Offset = "0x6328D8")]
	private IEnumerator PlayEffect()
	{
		return null;
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x2C6388C", Offset = "0x2C6388C", VA = "0x2C6388C")]
	public PlayFX()
	{
	}
}
