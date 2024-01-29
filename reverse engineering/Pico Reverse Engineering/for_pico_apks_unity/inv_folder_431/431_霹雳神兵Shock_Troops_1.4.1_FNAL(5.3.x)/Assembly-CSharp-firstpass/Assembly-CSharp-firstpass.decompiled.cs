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
public enum ForceTubeVRChannel
{
	[Token(Token = "0x4000002")]
	all,
	[Token(Token = "0x4000003")]
	rifle,
	[Token(Token = "0x4000004")]
	rifleButt,
	[Token(Token = "0x4000005")]
	rifleBolt,
	[Token(Token = "0x4000006")]
	pistol1,
	[Token(Token = "0x4000007")]
	pistol2,
	[Token(Token = "0x4000008")]
	other,
	[Token(Token = "0x4000009")]
	vest
}
[Token(Token = "0x2000003")]
public class ForceTubeVRInterface : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000006")]
	public class FTChannel
	{
		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x18")]
		public int batteryLevel;

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x17462B0", Offset = "0x17462B0", VA = "0x17462B0")]
		public FTChannel()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000007")]
	public class FTCType
	{
		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x10")]
		public List<FTChannel> rifleButt;

		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x18")]
		public List<FTChannel> rifleBolt;

		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x20")]
		public List<FTChannel> pistol1;

		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x28")]
		public List<FTChannel> pistol2;

		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x30")]
		public List<FTChannel> other;

		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x38")]
		public List<FTChannel> vest;

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x1747244", Offset = "0x1747244", VA = "0x1747244")]
		public FTCType()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000008")]
	public class FTChannelFile
	{
		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x10")]
		public FTCType channels;

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x174724C", Offset = "0x174724C", VA = "0x174724C")]
		public FTChannelFile()
		{
		}
	}

	[Token(Token = "0x2000009")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F98C0", Offset = "0x7F98C0")]
	private sealed class <InitAndroid>d__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x20")]
		public bool pistolsFirst;

		[Token(Token = "0x17000001")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000020")]
			[Address(RVA = "0x17471D4", Offset = "0x17471D4", VA = "0x17471D4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000002")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000022")]
			[Address(RVA = "0x174723C", Offset = "0x174723C", VA = "0x174723C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x1744E94", Offset = "0x1744E94", VA = "0x1744E94")]
		[DebuggerHidden]
		public <InitAndroid>d__2(int <>1__state)
		{
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x1746EC8", Offset = "0x1746EC8", VA = "0x1746EC8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x1746ECC", Offset = "0x1746ECC", VA = "0x1746ECC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x17471DC", Offset = "0x17471DC", VA = "0x17471DC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200000A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F98D0", Offset = "0x7F98D0")]
	private sealed class <>c__DisplayClass19_0
	{
		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x10")]
		public string sName;

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x1746774", Offset = "0x1746774", VA = "0x1746774")]
		public <>c__DisplayClass19_0()
		{
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x1746DF0", Offset = "0x1746DF0", VA = "0x1746DF0")]
		internal bool <RemoveFromChannel>b__0(FTChannel x)
		{
			return default(bool);
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x1746E14", Offset = "0x1746E14", VA = "0x1746E14")]
		internal bool <RemoveFromChannel>b__1(FTChannel x)
		{
			return default(bool);
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x1746E38", Offset = "0x1746E38", VA = "0x1746E38")]
		internal bool <RemoveFromChannel>b__2(FTChannel x)
		{
			return default(bool);
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x1746E5C", Offset = "0x1746E5C", VA = "0x1746E5C")]
		internal bool <RemoveFromChannel>b__3(FTChannel x)
		{
			return default(bool);
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x1746E80", Offset = "0x1746E80", VA = "0x1746E80")]
		internal bool <RemoveFromChannel>b__4(FTChannel x)
		{
			return default(bool);
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x1746EA4", Offset = "0x1746EA4", VA = "0x1746EA4")]
		internal bool <RemoveFromChannel>b__5(FTChannel x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400000A")]
	[FieldOffset(Offset = "0x0")]
	private static AndroidJavaObject ForceTubeVRPlugin;

	[Token(Token = "0x400000B")]
	[FieldOffset(Offset = "0x8")]
	private static ForceTubeVRInterface instance;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x1744E20", Offset = "0x1744E20", VA = "0x1744E20")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7F98E0", Offset = "0x7F98E0")]
	private static IEnumerator InitAndroid(bool pistolsFirst)
	{
		return null;
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x1744EC0", Offset = "0x1744EC0", VA = "0x1744EC0")]
	public static void InitAsync(bool pistolsFirst = false)
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x1745044", Offset = "0x1745044", VA = "0x1745044")]
	public static void Kick(byte power, ForceTubeVRChannel target = ForceTubeVRChannel.rifle)
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x17451C4", Offset = "0x17451C4", VA = "0x17451C4")]
	public static void Rumble(byte power, float duration, ForceTubeVRChannel target = ForceTubeVRChannel.rifle)
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x17453BC", Offset = "0x17453BC", VA = "0x17453BC")]
	public static void Shoot(byte kickPower, byte rumblePower, float rumbleDuration, ForceTubeVRChannel target = ForceTubeVRChannel.rifle)
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x17455F4", Offset = "0x17455F4", VA = "0x17455F4")]
	public static void SetActiveResearch(bool active)
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x1745730", Offset = "0x1745730", VA = "0x1745730")]
	public static byte TempoToKickPower(float tempo)
	{
		return default(byte);
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x1745880", Offset = "0x1745880", VA = "0x1745880")]
	public static byte GetBatteryLevel()
	{
		return default(byte);
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x17459D8", Offset = "0x17459D8", VA = "0x17459D8")]
	public static string ListConnectedForceTube()
	{
		return null;
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x1745B30", Offset = "0x1745B30", VA = "0x1745B30")]
	public static string ListChannels()
	{
		return null;
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x1745C88", Offset = "0x1745C88", VA = "0x1745C88")]
	public static bool InitChannels(string sJsonChannelList)
	{
		return default(bool);
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x1745D78", Offset = "0x1745D78", VA = "0x1745D78")]
	public static bool LoadChannelJSon()
	{
		return default(bool);
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x1745ED0", Offset = "0x1745ED0", VA = "0x1745ED0")]
	public static bool SaveChannelJSon()
	{
		return default(bool);
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x1746028", Offset = "0x1746028", VA = "0x1746028")]
	public static bool AddToChannel(int nChannel, string sName)
	{
		return default(bool);
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x17462B8", Offset = "0x17462B8", VA = "0x17462B8")]
	public static bool RemoveFromChannel(int nChannel, string sName)
	{
		return default(bool);
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x174677C", Offset = "0x174677C", VA = "0x174677C")]
	public static void ClearChannel(int nChannel)
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x17468B0", Offset = "0x17468B0", VA = "0x17468B0")]
	public static void ClearAllChannel()
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x1746A00", Offset = "0x1746A00", VA = "0x1746A00")]
	public static void OpenBluetoothSettings()
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x1746B4C", Offset = "0x1746B4C", VA = "0x1746B4C")]
	public static void DisconnectAll()
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x1746C98", Offset = "0x1746C98", VA = "0x1746C98")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x1746DE4", Offset = "0x1746DE4", VA = "0x1746DE4")]
	public ForceTubeVRInterface()
	{
	}
}
[Serializable]
[Token(Token = "0x2000004")]
public class ConnectedForceTube
{
	[Token(Token = "0x400000C")]
	[FieldOffset(Offset = "0x10")]
	public List<string> Connected;

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x1744E18", Offset = "0x1744E18", VA = "0x1744E18")]
	public ConnectedForceTube()
	{
	}
}
[Token(Token = "0x2000005")]
public class buttonUpdateFT : MonoBehaviour
{
	[Token(Token = "0x400000D")]
	[FieldOffset(Offset = "0x18")]
	public Dropdown m_db_toUpdate;

	[Token(Token = "0x400000E")]
	[FieldOffset(Offset = "0x20")]
	private List<string> m_DropOptions;

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x1747254", Offset = "0x1747254", VA = "0x1747254")]
	public void PutainDeButton()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x1747414", Offset = "0x1747414", VA = "0x1747414")]
	public buttonUpdateFT()
	{
	}
}
