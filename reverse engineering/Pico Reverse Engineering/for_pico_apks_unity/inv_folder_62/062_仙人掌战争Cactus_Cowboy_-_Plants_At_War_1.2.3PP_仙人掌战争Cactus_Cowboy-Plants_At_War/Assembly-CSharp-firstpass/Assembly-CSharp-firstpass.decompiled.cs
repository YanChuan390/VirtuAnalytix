using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class ExampleScript : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x18")]
	public Text batteryText;

	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x20")]
	private bool auto;

	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x21")]
	private bool activeResearch;

	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x24")]
	private float autoTimer;

	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x28")]
	private float autoDelay;

	[Token(Token = "0x4000006")]
	[FieldOffset(Offset = "0x2C")]
	private ForceTubeVRChannel target;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x1B9E4E4", Offset = "0x1B9E4E4", VA = "0x1B9E4E4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x1B9E73C", Offset = "0x1B9E73C", VA = "0x1B9E73C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x1B9ECAC", Offset = "0x1B9ECAC", VA = "0x1B9ECAC")]
	public void Shoot()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x1B9ED68", Offset = "0x1B9ED68", VA = "0x1B9ED68")]
	public void AutoShoot()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x1B9ED78", Offset = "0x1B9ED78", VA = "0x1B9ED78")]
	public void Kick()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x1B9EFD8", Offset = "0x1B9EFD8", VA = "0x1B9EFD8")]
	public void Rumble()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x1B9F2B4", Offset = "0x1B9F2B4", VA = "0x1B9F2B4")]
	public void SetTargetChannel(int target)
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x1B9F2BC", Offset = "0x1B9F2BC", VA = "0x1B9F2BC")]
	public void SetActiveResearch()
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x1B9F500", Offset = "0x1B9F500", VA = "0x1B9F500")]
	public void OpenBluetoothSettings()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x1B9F704", Offset = "0x1B9F704", VA = "0x1B9F704")]
	public ExampleScript()
	{
	}
}
[Token(Token = "0x2000003")]
public enum ForceTubeVRChannel
{
	[Token(Token = "0x4000008")]
	all,
	[Token(Token = "0x4000009")]
	rifle,
	[Token(Token = "0x400000A")]
	rifleButt,
	[Token(Token = "0x400000B")]
	rifleBolt,
	[Token(Token = "0x400000C")]
	pistol1,
	[Token(Token = "0x400000D")]
	pistol2,
	[Token(Token = "0x400000E")]
	other,
	[Token(Token = "0x400000F")]
	vest
}
[Token(Token = "0x2000004")]
public class ForceTubeVRInterface : MonoBehaviour
{
	[Token(Token = "0x2000005")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7A7D04", Offset = "0x7A7D04")]
	private sealed class <InitAndroid>d__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x20")]
		public bool pistolsFirst;

		[Token(Token = "0x17000001")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600001A")]
			[Address(RVA = "0x1B9FE78", Offset = "0x1B9FE78", VA = "0x1B9FE78", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000002")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600001C")]
			[Address(RVA = "0x1B9FEC0", Offset = "0x1B9FEC0", VA = "0x1B9FEC0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x1B9F790", Offset = "0x1B9F790", VA = "0x1B9F790")]
		[DebuggerHidden]
		public <InitAndroid>d__2(int <>1__state)
		{
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x1B9FAA4", Offset = "0x1B9FAA4", VA = "0x1B9FAA4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x1B9FAA8", Offset = "0x1B9FAA8", VA = "0x1B9FAA8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x1B9FE80", Offset = "0x1B9FE80", VA = "0x1B9FE80", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000010")]
	[FieldOffset(Offset = "0x0")]
	private static AndroidJavaObject ForceTubeVRPlugin;

	[Token(Token = "0x4000011")]
	[FieldOffset(Offset = "0x8")]
	private static ForceTubeVRInterface instance;

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x1B9F720", Offset = "0x1B9F720", VA = "0x1B9F720")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7A7D14", Offset = "0x7A7D14")]
	private static IEnumerator InitAndroid(bool pistolsFirst)
	{
		return null;
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x1B9E58C", Offset = "0x1B9E58C", VA = "0x1B9E58C")]
	public static void InitAsync(bool pistolsFirst = false)
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x1B9EE2C", Offset = "0x1B9EE2C", VA = "0x1B9EE2C")]
	public static void Kick(byte power, ForceTubeVRChannel target = ForceTubeVRChannel.rifle)
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x1B9F090", Offset = "0x1B9F090", VA = "0x1B9F090")]
	public static void Rumble(byte power, float duration, ForceTubeVRChannel target = ForceTubeVRChannel.rifle)
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x1B9E8D0", Offset = "0x1B9E8D0", VA = "0x1B9E8D0")]
	public static void Shoot(byte kickPower, byte rumblePower, float rumbleDuration, ForceTubeVRChannel target = ForceTubeVRChannel.rifle)
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x1B9F3A4", Offset = "0x1B9F3A4", VA = "0x1B9F3A4")]
	public static void SetActiveResearch(bool active)
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x1B9F7BC", Offset = "0x1B9F7BC", VA = "0x1B9F7BC")]
	public static byte TempoToKickPower(float tempo)
	{
		return default(byte);
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x1B9EB34", Offset = "0x1B9EB34", VA = "0x1B9EB34")]
	public static byte GetBatteryLevel()
	{
		return default(byte);
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x1B9F5A4", Offset = "0x1B9F5A4", VA = "0x1B9F5A4")]
	public static void OpenBluetoothSettings()
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x1B9F938", Offset = "0x1B9F938", VA = "0x1B9F938")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x1B9FA98", Offset = "0x1B9FA98", VA = "0x1B9FA98")]
	public ForceTubeVRInterface()
	{
	}
}
