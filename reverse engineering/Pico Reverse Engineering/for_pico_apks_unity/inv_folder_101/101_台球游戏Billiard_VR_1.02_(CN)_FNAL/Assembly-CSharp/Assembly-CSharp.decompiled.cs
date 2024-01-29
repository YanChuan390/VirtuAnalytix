using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Sockets;
using System.Net.WebSockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Pico.Platform;
using Pico.Platform.Models;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Networking;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000009")]
public static class AudioManager
{
	[StructLayout(3)]
	[Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct <Init>d__6 : IAsyncStateMachine
	{
		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string[] <>7__wrap1;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int <>7__wrap2;

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string <item>5__4;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ResourceRequest <audioItem>5__5;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TaskAwaiter<VoidData> <>u__1;

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x8943C8", Offset = "0x8943C8", VA = "0x8943C8", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x894BFC", Offset = "0x894BFC", VA = "0x894BFC", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct <LoadGuideClip>d__7 : IAsyncStateMachine
	{
		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string[] nameArray;

		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string[] <>7__wrap1;

		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int <>7__wrap2;

		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string <name>5__4;

		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ResourceRequest <audioItem>5__5;

		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TaskAwaiter<VoidData> <>u__1;

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x894C08", Offset = "0x894C08", VA = "0x894C08", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x894F64", Offset = "0x894F64", VA = "0x894F64", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct <PlayAsync>d__9 : IAsyncStateMachine
	{
		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string name;

		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 pos;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int <i>5__2;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TaskAwaiter<VoidData> <>u__1;

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x894F70", Offset = "0x894F70", VA = "0x894F70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x895368", Offset = "0x895368", VA = "0x895368", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct <PlayGuideAudio>d__11 : IAsyncStateMachine
	{
		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string name;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AudioSource audioSource;

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int <i>5__2;

		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TaskAwaiter<VoidData> <>u__1;

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x895374", Offset = "0x895374", VA = "0x895374", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x895670", Offset = "0x895670", VA = "0x895670", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Dictionary<string, AudioClip> audios;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Dictionary<string, AudioClip> guideAudioClips;

	[Token(Token = "0x1700000F")]
	public static Action<AudioInfo> AudioSyncAction
	{
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x8939F4", Offset = "0x8939F4", VA = "0x8939F4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x893A4C", Offset = "0x893A4C", VA = "0x893A4C")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x893AAC", Offset = "0x893AAC", VA = "0x893AAC")]
	[AsyncStateMachine(typeof(<Init>d__6))]
	public static System.Threading.Tasks.Task Init()
	{
		return null;
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x893B80", Offset = "0x893B80", VA = "0x893B80")]
	[AsyncStateMachine(typeof(<LoadGuideClip>d__7))]
	public static System.Threading.Tasks.Task LoadGuideClip(string[] nameArray)
	{
		return null;
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x893C70", Offset = "0x893C70", VA = "0x893C70")]
	public static void UnLoadGuideClip()
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x893E54", Offset = "0x893E54", VA = "0x893E54")]
	[AsyncStateMachine(typeof(<PlayAsync>d__9))]
	public static System.Threading.Tasks.Task PlayAsync(string name, Vector3 pos, float vol = 1f, bool isSync = false)
	{
		return null;
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x893F64", Offset = "0x893F64", VA = "0x893F64")]
	public static void Play(string name, Vector3 pos, float vol = 1f, bool isSync = false)
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x8941FC", Offset = "0x8941FC", VA = "0x8941FC")]
	[AsyncStateMachine(typeof(<PlayGuideAudio>d__11))]
	public static System.Threading.Tasks.Task PlayGuideAudio(string name, AudioSource audioSource)
	{
		return null;
	}
}
[Token(Token = "0x200000E")]
public class AudioInfo
{
	[Token(Token = "0x17000010")]
	public string Name
	{
		[Token(Token = "0x600003C")]
		[Address(RVA = "0x89567C", Offset = "0x89567C", VA = "0x89567C")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600003D")]
		[Address(RVA = "0x895684", Offset = "0x895684", VA = "0x895684")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000011")]
	public float PosX
	{
		[Token(Token = "0x600003E")]
		[Address(RVA = "0x89568C", Offset = "0x89568C", VA = "0x89568C")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600003F")]
		[Address(RVA = "0x895694", Offset = "0x895694", VA = "0x895694")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000012")]
	public float PosY
	{
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x89569C", Offset = "0x89569C", VA = "0x89569C")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000041")]
		[Address(RVA = "0x8956A4", Offset = "0x8956A4", VA = "0x8956A4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000013")]
	public float PosZ
	{
		[Token(Token = "0x6000042")]
		[Address(RVA = "0x8956AC", Offset = "0x8956AC", VA = "0x8956AC")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000043")]
		[Address(RVA = "0x8956B4", Offset = "0x8956B4", VA = "0x8956B4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000014")]
	public float Vol
	{
		[Token(Token = "0x6000044")]
		[Address(RVA = "0x8956BC", Offset = "0x8956BC", VA = "0x8956BC")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x8956C4", Offset = "0x8956C4", VA = "0x8956C4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x8956CC", Offset = "0x8956CC", VA = "0x8956CC")]
	public AudioInfo()
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x8941A0", Offset = "0x8941A0", VA = "0x8941A0")]
	public AudioInfo(string name, Vector3 pos, float vol)
	{
	}
}
[Token(Token = "0x200000F")]
public class Const
{
	[Token(Token = "0x4000032")]
	public const int TransferPort = 9999;

	[Token(Token = "0x4000033")]
	public const string BaseHost = "billiards.ruidnet.com";

	[Token(Token = "0x4000034")]
	public const string BASE_URL = "https://billiards.ruidnet.com/api";

	[Token(Token = "0x4000035")]
	public const string WebClientURL = "wss://billiards.ruidnet.com/ws/main";

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x8956D4", Offset = "0x8956D4", VA = "0x8956D4")]
	public Const()
	{
	}
}
[Token(Token = "0x2000010")]
public class Controller : MonoBehaviour
{
	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public XRController LeftController;

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public XRController RightController;

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static XRController primaryController;

	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static XRController secondaryController;

	[Token(Token = "0x17000015")]
	public static XRController Left
	{
		[Token(Token = "0x6000049")]
		[Address(RVA = "0x8956DC", Offset = "0x8956DC", VA = "0x8956DC")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600004A")]
		[Address(RVA = "0x895724", Offset = "0x895724", VA = "0x895724")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000016")]
	public static XRController Right
	{
		[Token(Token = "0x600004B")]
		[Address(RVA = "0x895774", Offset = "0x895774", VA = "0x895774")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600004C")]
		[Address(RVA = "0x8957BC", Offset = "0x8957BC", VA = "0x8957BC")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000017")]
	public static XRController PrimaryController
	{
		[Token(Token = "0x600004D")]
		[Address(RVA = "0x89580C", Offset = "0x89580C", VA = "0x89580C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000018")]
	public static XRController SecondaryController
	{
		[Token(Token = "0x600004E")]
		[Address(RVA = "0x895854", Offset = "0x895854", VA = "0x895854")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x89589C", Offset = "0x89589C", VA = "0x89589C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x8959E8", Offset = "0x8959E8", VA = "0x8959E8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x8959EC", Offset = "0x8959EC", VA = "0x8959EC")]
	public void SetLeft()
	{
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x89597C", Offset = "0x89597C", VA = "0x89597C")]
	public void SetDefault()
	{
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x895A58", Offset = "0x895A58", VA = "0x895A58")]
	public Controller()
	{
	}
}
[Token(Token = "0x2000011")]
public interface BusEvent
{
}
[Token(Token = "0x2000012")]
public class EventBus
{
	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Dictionary<Type, List<object>> busDict;

	[Token(Token = "0x6000054")]
	public static void Register<T>(Action<T> action) where T : BusEvent
	{
	}

	[Token(Token = "0x6000055")]
	public static void UnRegister<T>(Action<T> action) where T : BusEvent
	{
	}

	[Token(Token = "0x6000056")]
	public static void Send<T>(T eventData) where T : BusEvent
	{
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x895A60", Offset = "0x895A60", VA = "0x895A60")]
	public EventBus()
	{
	}
}
[Token(Token = "0x2000013")]
public static class CustomYieldInstructionExtend
{
	[Token(Token = "0x6000059")]
	[Address(RVA = "0x895B00", Offset = "0x895B00", VA = "0x895B00")]
	public static CoroutineResult ToCoroutineResult(this CustomYieldInstruction task)
	{
		return null;
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x895214", Offset = "0x895214", VA = "0x895214")]
	public static TaskAwaiter<VoidData> GetAwaiter(this CustomYieldInstruction customYieldInstruction)
	{
		return default(TaskAwaiter<VoidData>);
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x894A90", Offset = "0x894A90", VA = "0x894A90")]
	public static TaskAwaiter<VoidData> GetAwaiter(this YieldInstruction yieldInstruction)
	{
		return default(TaskAwaiter<VoidData>);
	}
}
[Token(Token = "0x2000016")]
public static class Wait
{
	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static CustomYieldInstruction NextTick;
}
[Token(Token = "0x2000017")]
public static class MonoBehaviourExtend
{
	[Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class <GenerateWaitIEnumerator>d__1 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float second;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action action;

		[Token(Token = "0x17000019")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600006B")]
			[Address(RVA = "0x896130", Offset = "0x896130", VA = "0x896130", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600006D")]
			[Address(RVA = "0x896178", Offset = "0x896178", VA = "0x896178", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x895DCC", Offset = "0x895DCC", VA = "0x895DCC")]
		[DebuggerHidden]
		public <GenerateWaitIEnumerator>d__1(int <>1__state)
		{
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x896068", Offset = "0x896068", VA = "0x896068", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x89606C", Offset = "0x89606C", VA = "0x89606C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x896138", Offset = "0x896138", VA = "0x896138", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class <GenerateEndOfFrameIEnumerator>d__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Action action;

		[Token(Token = "0x1700001B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000071")]
			[Address(RVA = "0x896238", Offset = "0x896238", VA = "0x896238", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000073")]
			[Address(RVA = "0x896280", Offset = "0x896280", VA = "0x896280", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x895F34", Offset = "0x895F34", VA = "0x895F34")]
		[DebuggerHidden]
		public <GenerateEndOfFrameIEnumerator>d__4(int <>1__state)
		{
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x896180", Offset = "0x896180", VA = "0x896180", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x896184", Offset = "0x896184", VA = "0x896184", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x896240", Offset = "0x896240", VA = "0x896240", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class <GenerateNextTickIEnumerator>d__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Action action;

		[Token(Token = "0x1700001D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000077")]
			[Address(RVA = "0x8962F8", Offset = "0x8962F8", VA = "0x8962F8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000079")]
			[Address(RVA = "0x896340", Offset = "0x896340", VA = "0x896340", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x895F5C", Offset = "0x895F5C", VA = "0x895F5C")]
		[DebuggerHidden]
		public <GenerateNextTickIEnumerator>d__5(int <>1__state)
		{
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x896288", Offset = "0x896288", VA = "0x896288", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x89628C", Offset = "0x89628C", VA = "0x89628C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x896300", Offset = "0x896300", VA = "0x896300", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class <GenerateUntilIEnumerator>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Func<bool> predicate;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action action;

		[Token(Token = "0x1700001F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600007D")]
			[Address(RVA = "0x896408", Offset = "0x896408", VA = "0x896408", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000020")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600007F")]
			[Address(RVA = "0x896450", Offset = "0x896450", VA = "0x896450", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x896040", Offset = "0x896040", VA = "0x896040")]
		[DebuggerHidden]
		public <GenerateUntilIEnumerator>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x896348", Offset = "0x896348", VA = "0x896348", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x89634C", Offset = "0x89634C", VA = "0x89634C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x896410", Offset = "0x896410", VA = "0x896410", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x895D1C", Offset = "0x895D1C", VA = "0x895D1C")]
	public static void Invoke(this MonoBehaviour monoBehaviour, Action action, float second)
	{
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x895D48", Offset = "0x895D48", VA = "0x895D48")]
	[IteratorStateMachine(typeof(<GenerateWaitIEnumerator>d__1))]
	private static IEnumerator GenerateWaitIEnumerator(Action action, float second)
	{
		return null;
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x895DF4", Offset = "0x895DF4", VA = "0x895DF4")]
	public static void InvokeNextTick(this MonoBehaviour monoBehaviour, Action action)
	{
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x895E94", Offset = "0x895E94", VA = "0x895E94")]
	public static void InvokeEndOfFrame(this MonoBehaviour monoBehaviour, Action action)
	{
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x895EC0", Offset = "0x895EC0", VA = "0x895EC0")]
	[IteratorStateMachine(typeof(<GenerateEndOfFrameIEnumerator>d__4))]
	private static IEnumerator GenerateEndOfFrameIEnumerator(Action action)
	{
		return null;
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x895E20", Offset = "0x895E20", VA = "0x895E20")]
	[IteratorStateMachine(typeof(<GenerateNextTickIEnumerator>d__5))]
	private static IEnumerator GenerateNextTickIEnumerator(Action action)
	{
		return null;
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x895F84", Offset = "0x895F84", VA = "0x895F84")]
	public static void InvokeUntil(this MonoBehaviour monoBehaviour, Func<bool> predicate, Action action)
	{
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x895FB0", Offset = "0x895FB0", VA = "0x895FB0")]
	[IteratorStateMachine(typeof(<GenerateUntilIEnumerator>d__7))]
	private static IEnumerator GenerateUntilIEnumerator(Action action, Func<bool> predicate)
	{
		return null;
	}
}
[Token(Token = "0x200001C")]
public class CoroutineResult
{
	[Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class <ThenIEnumerator>d__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CoroutineResult <>4__this;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action resultAction;

		[Token(Token = "0x17000021")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600008A")]
			[Address(RVA = "0x896670", Offset = "0x896670", VA = "0x896670", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000022")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600008C")]
			[Address(RVA = "0x8966B8", Offset = "0x8966B8", VA = "0x8966B8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x8965A0", Offset = "0x8965A0", VA = "0x8965A0")]
		[DebuggerHidden]
		public <ThenIEnumerator>d__10(int <>1__state)
		{
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x8965C8", Offset = "0x8965C8", VA = "0x8965C8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x8965CC", Offset = "0x8965CC", VA = "0x8965CC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x896678", Offset = "0x896678", VA = "0x896678", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	protected static MonoBehaviour behaviour;

	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	protected YieldInstruction waitYieldInstruction;

	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	protected CustomYieldInstruction waitCustomYieldInstruction;

	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Action resultAction;

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x896458", Offset = "0x896458", VA = "0x896458")]
	public static void Init(MonoBehaviour behaviour)
	{
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x8964B0", Offset = "0x8964B0", VA = "0x8964B0")]
	protected CoroutineResult(YieldInstruction waitYieldInstruction)
	{
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x8964E0", Offset = "0x8964E0", VA = "0x8964E0")]
	protected CoroutineResult(CustomYieldInstruction waitCustomYieldInstruction)
	{
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x895C30", Offset = "0x895C30", VA = "0x895C30")]
	public CoroutineResult(YieldInstruction waitYieldInstruction, [Optional] Action resultAction)
	{
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x895B64", Offset = "0x895B64", VA = "0x895B64")]
	public CoroutineResult(CustomYieldInstruction waitCustomYieldInstruction, [Optional] Action resultAction)
	{
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x895BB0", Offset = "0x895BB0", VA = "0x895BB0")]
	public void Then(Action resultAction)
	{
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x896510", Offset = "0x896510", VA = "0x896510")]
	[IteratorStateMachine(typeof(<ThenIEnumerator>d__10))]
	private IEnumerator ThenIEnumerator(Action resultAction)
	{
		return null;
	}
}
[Token(Token = "0x200001E")]
public class CoroutineResult<T> : CoroutineResult
{
	[Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class <ThenIEnumerator>d__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <>1__state;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private object <>2__current;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CoroutineResult<T> <>4__this;

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Action<T> resultAction;

		[Token(Token = "0x17000023")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000094")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000024")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000096")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000091")]
		[DebuggerHidden]
		public <ThenIEnumerator>d__4(int <>1__state)
		{
		}

		[Token(Token = "0x6000092")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000093")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000095")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private Func<T> resultSupplier;

	[Token(Token = "0x600008D")]
	public CoroutineResult(YieldInstruction waitYieldInstruction, Func<T> resultSupplier)
	{
	}

	[Token(Token = "0x600008E")]
	public CoroutineResult(CustomYieldInstruction waitCustomYieldInstruction, Func<T> resultSupplier)
	{
	}

	[Token(Token = "0x600008F")]
	public void Then(Action<T> resultAction)
	{
	}

	[Token(Token = "0x6000090")]
	[IteratorStateMachine(typeof(CoroutineResult<>.<ThenIEnumerator>d__4))]
	private IEnumerator ThenIEnumerator(Action<T> resultAction)
	{
		return null;
	}
}
[Token(Token = "0x2000020")]
public static class NetworkStreamExtend
{
	[StructLayout(3)]
	[Token(Token = "0x2000021")]
	[CompilerGenerated]
	private struct <ReadAsync>d__0 : IAsyncStateMachine
	{
		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public NetworkStream stream;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public byte[] buffer;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int offset;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public int count;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float timeout;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private System.Threading.Tasks.Task<int> <task>5__2;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TaskAwaiter<int> <>u__1;

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x896818", Offset = "0x896818", VA = "0x896818", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x896AF8", Offset = "0x896AF8", VA = "0x896AF8", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x8966C0", Offset = "0x8966C0", VA = "0x8966C0")]
	[AsyncStateMachine(typeof(<ReadAsync>d__0))]
	public static System.Threading.Tasks.Task<int> ReadAsync(this NetworkStream stream, byte[] buffer, int offset, int count, float timeout)
	{
		return null;
	}
}
[Token(Token = "0x2000022")]
public class Promise<T>
{
	[Token(Token = "0x4000064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private Action<T> thenAction;

	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private bool isFinished;

	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private T result;

	[Token(Token = "0x600009A")]
	public Promise(Action<Action<T>> resolveAction)
	{
	}

	[Token(Token = "0x600009B")]
	public void Then(Action<T> thenAction)
	{
	}
}
[Token(Token = "0x2000023")]
public class Promise : Promise<VoidData>
{
	[Token(Token = "0x600009D")]
	[Address(RVA = "0x896B50", Offset = "0x896B50", VA = "0x896B50")]
	public Promise(Action<Action> resolve)
	{
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0x896C38", Offset = "0x896C38", VA = "0x896C38")]
	public void Then(Action thenAction)
	{
	}
}
[Token(Token = "0x2000027")]
public static class TaskExtend
{
	[Token(Token = "0x60000A5")]
	public static WaitTaskResult<T> AsyncWait<T>(this System.Threading.Tasks.Task<T> task, float second)
	{
		return null;
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x896E98", Offset = "0x896E98", VA = "0x896E98")]
	public static WaitTaskResult AsyncWait(this System.Threading.Tasks.Task task, float second)
	{
		return null;
	}

	[Token(Token = "0x60000A7")]
	public static TimedTask<T> ToTimedTask<T>(this System.Threading.Tasks.Task<T> task, float second)
	{
		return null;
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x89724C", Offset = "0x89724C", VA = "0x89724C")]
	public static TimedTask ToTimedTask(this System.Threading.Tasks.Task task, float second)
	{
		return null;
	}
}
[Token(Token = "0x200002A")]
public class TimedTask : CustomYieldInstruction
{
	[Token(Token = "0x4000070")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private System.Threading.Tasks.Task task;

	[Token(Token = "0x4000071")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private DateTime expireTime;

	[Token(Token = "0x17000025")]
	public override bool keepWaiting
	{
		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x897544", Offset = "0x897544", VA = "0x897544", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x8972BC", Offset = "0x8972BC", VA = "0x8972BC")]
	public TimedTask(System.Threading.Tasks.Task task, float waitSecond)
	{
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x8973C0", Offset = "0x8973C0", VA = "0x8973C0")]
	public TaskAwaiter<bool> GetAwaiter()
	{
		return default(TaskAwaiter<bool>);
	}
}
[Token(Token = "0x200002C")]
public class TimedTask<T> : CustomYieldInstruction
{
	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private System.Threading.Tasks.Task<T> task;

	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private DateTime expireTime;

	[Token(Token = "0x17000026")]
	public override bool keepWaiting
	{
		[Token(Token = "0x60000B8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60000B6")]
	public TimedTask(System.Threading.Tasks.Task<T> task, float waitSecond)
	{
	}

	[Token(Token = "0x60000B7")]
	public TaskAwaiter<T> GetAwaiter()
	{
		return default(TaskAwaiter<T>);
	}
}
[Token(Token = "0x200002E")]
public class CustomTask<T>
{
	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private TaskCompletionSource<T> taskSource;

	[Token(Token = "0x60000BB")]
	public CustomTask()
	{
	}

	[Token(Token = "0x60000BC")]
	public TaskAwaiter<T> GetAwaiter()
	{
		return default(TaskAwaiter<T>);
	}

	[Token(Token = "0x60000BD")]
	public void SetResult(T t)
	{
	}
}
[Token(Token = "0x200002F")]
public class WaitTask : CustomYieldInstruction
{
	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private System.Threading.Tasks.Task task;

	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private DateTime expireTime;

	[Token(Token = "0x17000027")]
	public override bool keepWaiting
	{
		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x897658", Offset = "0x897658", VA = "0x897658", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x89719C", Offset = "0x89719C", VA = "0x89719C")]
	public WaitTask(System.Threading.Tasks.Task task, float waitSecond)
	{
	}
}
[Token(Token = "0x2000030")]
public class WaitTaskResult<T>
{
	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private Action<T> thenAction;

	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private Action timeoutAction;

	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private bool isFinished;

	[Token(Token = "0x400007E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private bool isTimeout;

	[Token(Token = "0x400007F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private T result;

	[Token(Token = "0x60000C0")]
	public WaitTaskResult(Action<Action<T>> resolveAction, Action<Action> timeoutResolveAction)
	{
	}

	[Token(Token = "0x60000C1")]
	public WaitTaskResult<T> Then(Action<T> action)
	{
		return null;
	}

	[Token(Token = "0x60000C2")]
	public WaitTaskResult<T> Timeout(Action action)
	{
		return null;
	}
}
[Token(Token = "0x2000031")]
public class WaitTaskResult : WaitTaskResult<VoidData>
{
	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x8970B4", Offset = "0x8970B4", VA = "0x8970B4")]
	public WaitTaskResult(Action<Action> resolve, Action<Action> timeoutResolve)
	{
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x897704", Offset = "0x897704", VA = "0x897704")]
	public WaitTaskResult Then(Action thenAction)
	{
		return null;
	}
}
[Token(Token = "0x2000035")]
public static class TypeExtend
{
	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x89796C", Offset = "0x89796C", VA = "0x89796C")]
	public static bool IsGenericSubclassOf(this Type type, Type superType)
	{
		return default(bool);
	}
}
[Token(Token = "0x2000036")]
internal static class UriExtensions
{
	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x897B10", Offset = "0x897B10", VA = "0x897B10")]
	internal static Uri Append(this Uri uri, string param)
	{
		return null;
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x897C0C", Offset = "0x897C0C", VA = "0x897C0C")]
	internal static void AppendQuery(this UriBuilder uriBuilder, string name, string value)
	{
	}
}
[Token(Token = "0x2000037")]
public static class XRControllerExtend
{
	[Token(Token = "0x4000083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Controller controller;

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x897D70", Offset = "0x897D70", VA = "0x897D70")]
	public static void Init(Controller controller)
	{
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x897DC8", Offset = "0x897DC8", VA = "0x897DC8")]
	public static bool IsPressed(this XRController controller, InputHelpers.Button button)
	{
		return default(bool);
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0x897E64", Offset = "0x897E64", VA = "0x897E64")]
	public static Vector2 StickPos(this XRController controller)
	{
		return default(Vector2);
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x897F00", Offset = "0x897F00", VA = "0x897F00")]
	public static void Shock(this XRController controller, float amplitude, float duration)
	{
	}
}
[Token(Token = "0x2000038")]
public class GameManager : MonoBehaviour
{
	[StructLayout(3)]
	[Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct <SetMRMode>d__67 : IAsyncStateMachine
	{
		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool value;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TaskAwaiter <>u__1;

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x89D6E0", Offset = "0x89D6E0", VA = "0x89D6E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x89D908", Offset = "0x89D908", VA = "0x89D908", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct <Start>d__89 : IAsyncStateMachine
	{
		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameManager <>4__this;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TaskAwaiter<bool> <>u__1;

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x89DC60", Offset = "0x89DC60", VA = "0x89DC60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x89E4A4", Offset = "0x89E4A4", VA = "0x89E4A4", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct <AfterGanHit>d__94 : IAsyncStateMachine
	{
		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ChineseEightBallPlayer player;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameManager <>4__this;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TaskAwaiter<bool> <>u__1;

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x89E4B0", Offset = "0x89E4B0", VA = "0x89E4B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x8A056C", Offset = "0x8A056C", VA = "0x8A056C", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct <WaitAllBallStop>d__97 : IAsyncStateMachine
	{
		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameManager <>4__this;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public CancellationToken cancelToken;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TaskAwaiter<VoidData> <>u__1;

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x8A0578", Offset = "0x8A0578", VA = "0x8A0578", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x8A09E4", Offset = "0x8A09E4", VA = "0x8A09E4", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x4000084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static Vector3 BOX_POS;

	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static GameManager instance;

	[Token(Token = "0x4000086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Player Player;

	[Token(Token = "0x4000087")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject DeskCenter;

	[Token(Token = "0x4000088")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject AILevelGameObject;

	[Token(Token = "0x4000089")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject MenuObject;

	[Token(Token = "0x400008A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Text Msg;

	[Token(Token = "0x400008B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Text KeepMsg;

	[Token(Token = "0x400008C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject MsgObject;

	[Token(Token = "0x400008D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject KeepMsgObject;

	[Token(Token = "0x400008E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Guide BeginnerGuide;

	[Token(Token = "0x400008F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public GanHand GanHand;

	[Token(Token = "0x4000090")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Hand Hand;

	[Token(Token = "0x4000091")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Mark Mark;

	[Token(Token = "0x4000092")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Activation Activation;

	[Token(Token = "0x4000093")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Score Score;

	[Token(Token = "0x4000094")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public SDKManager SDKManager;

	[Token(Token = "0x4000095")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public GameObject BG;

	[Token(Token = "0x4000096")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public GameObject Loading;

	[Token(Token = "0x4000097")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private bool isRestTable;

	[Token(Token = "0x4000098")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private Vector3[] tablePos;

	[Token(Token = "0x4000099")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private float[] tableRa;

	[Token(Token = "0x400009A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private int tableIndex;

	[Token(Token = "0x400009B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	private bool isRestTablePressed;

	[Token(Token = "0x400009C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private CancellationTokenSource allBallStopToken;

	[Token(Token = "0x400009D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public CustomTask<object> CustomTask;

	[Token(Token = "0x40000A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private List<ChineseEightBall> chineseEightBallList;

	[Token(Token = "0x40000A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private ChineseEightBallPlayer[] players;

	[Token(Token = "0x40000A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private int playerIndex;

	[Token(Token = "0x40000A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
	private int teeOffIndex;

	[Token(Token = "0x40000A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public bool isFirst;

	[Token(Token = "0x40000A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE9")]
	private bool isMenuButtonPressed;

	[Token(Token = "0x40000AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEA")]
	public bool isMenuHide;

	[Token(Token = "0x40000AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static bool mrMode;

	[Token(Token = "0x17000028")]
	public static GameManager Instance
	{
		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x897FCC", Offset = "0x897FCC", VA = "0x897FCC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000029")]
	public static AILevel AILevel
	{
		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x898024", Offset = "0x898024", VA = "0x898024")]
		[CompilerGenerated]
		get
		{
			return default(AILevel);
		}
		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x89807C", Offset = "0x89807C", VA = "0x89807C")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700002A")]
	public static DefaultHand DefaultHand
	{
		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x8980D8", Offset = "0x8980D8", VA = "0x8980D8")]
		[CompilerGenerated]
		get
		{
			return default(DefaultHand);
		}
		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x898130", Offset = "0x898130", VA = "0x898130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700002B")]
	public static GameState GameState
	{
		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x89818C", Offset = "0x89818C", VA = "0x89818C")]
		[CompilerGenerated]
		get
		{
			return default(GameState);
		}
		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x8981E4", Offset = "0x8981E4", VA = "0x8981E4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700002C")]
	public static bool AlwaysVoice
	{
		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x898240", Offset = "0x898240", VA = "0x898240")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x898298", Offset = "0x898298", VA = "0x898298")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700002D")]
	public List<ChineseEightBall> ChineseEightBallList
	{
		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x8982F4", Offset = "0x8982F4", VA = "0x8982F4")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x8982FC", Offset = "0x8982FC", VA = "0x8982FC")]
		set
		{
		}
	}

	[Token(Token = "0x1700002E")]
	public static GameType GameType
	{
		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x898304", Offset = "0x898304", VA = "0x898304")]
		[CompilerGenerated]
		get
		{
			return default(GameType);
		}
		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x89835C", Offset = "0x89835C", VA = "0x89835C")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700002F")]
	public static GameMode GameMode
	{
		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x8983B8", Offset = "0x8983B8", VA = "0x8983B8")]
		[CompilerGenerated]
		get
		{
			return default(GameMode);
		}
		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x898410", Offset = "0x898410", VA = "0x898410")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000030")]
	public ChineseEightBallPlayer[] Players
	{
		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x89846C", Offset = "0x89846C", VA = "0x89846C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000031")]
	public static bool MRMode
	{
		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x898474", Offset = "0x898474", VA = "0x898474")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000032")]
	public static GameObject WhiteBall
	{
		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x8985A4", Offset = "0x8985A4", VA = "0x8985A4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000033")]
	public static float DeskHeight
	{
		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x898668", Offset = "0x898668", VA = "0x898668")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000034")]
	public static float DeskShortSide
	{
		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x898674", Offset = "0x898674", VA = "0x898674")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000035")]
	public static float DeskLongSide
	{
		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x898680", Offset = "0x898680", VA = "0x898680")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000036")]
	public Vector3 PlacementPoint
	{
		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x89868C", Offset = "0x89868C", VA = "0x89868C")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x17000037")]
	public ChineseEightBallPlayer CurPlayer
	{
		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x898774", Offset = "0x898774", VA = "0x898774")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000038")]
	private ChineseEightBallPlayer OtherPlayer
	{
		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x8987A8", Offset = "0x8987A8", VA = "0x8987A8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0x8984CC", Offset = "0x8984CC", VA = "0x8984CC")]
	[AsyncStateMachine(typeof(<SetMRMode>d__67))]
	public static System.Threading.Tasks.Task SetMRMode(bool value)
	{
		return null;
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0x8987E4", Offset = "0x8987E4", VA = "0x8987E4")]
	public void ChangePlayerIndex(int index)
	{
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0x8987EC", Offset = "0x8987EC", VA = "0x8987EC")]
	private void SwitchPlayer([Optional] string msg)
	{
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0x8989B8", Offset = "0x8989B8", VA = "0x8989B8")]
	public static void ShowMsg(string msg, bool keep = false)
	{
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0x898B90", Offset = "0x898B90", VA = "0x898B90")]
	public static void HideMsg()
	{
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0x898C0C", Offset = "0x898C0C", VA = "0x898C0C")]
	public void SelectAILevel()
	{
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0x899F3C", Offset = "0x899F3C", VA = "0x899F3C")]
	public void HideGan()
	{
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0x89A138", Offset = "0x89A138", VA = "0x89A138")]
	public void ShowGan()
	{
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0x89A334", Offset = "0x89A334", VA = "0x89A334")]
	[AsyncStateMachine(typeof(<Start>d__89))]
	private System.Threading.Tasks.Task Start()
	{
		return null;
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0x89A420", Offset = "0x89A420", VA = "0x89A420")]
	private void Application_lowMemory()
	{
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0x89A488", Offset = "0x89A488", VA = "0x89A488")]
	private void ResetBallState()
	{
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0x89A590", Offset = "0x89A590", VA = "0x89A590")]
	private void RefreshBallType(bool fullEmpty, bool halfEmpty)
	{
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0x89A644", Offset = "0x89A644", VA = "0x89A644")]
	private void NextGame()
	{
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0x89AA80", Offset = "0x89AA80", VA = "0x89AA80")]
	[AsyncStateMachine(typeof(<AfterGanHit>d__94))]
	private void AfterGanHit(ChineseEightBallPlayer player)
	{
	}

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0x89AB54", Offset = "0x89AB54", VA = "0x89AB54")]
	private void FreeBall()
	{
	}

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0x89AD44", Offset = "0x89AD44", VA = "0x89AD44")]
	private void FreeBallAfterLine()
	{
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0x89AF40", Offset = "0x89AF40", VA = "0x89AF40")]
	[AsyncStateMachine(typeof(<WaitAllBallStop>d__97))]
	public System.Threading.Tasks.Task<bool> WaitAllBallStop(CancellationToken cancelToken)
	{
		return null;
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0x89B074", Offset = "0x89B074", VA = "0x89B074")]
	private bool IsAllBallStop()
	{
		return default(bool);
	}

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0x89B17C", Offset = "0x89B17C", VA = "0x89B17C")]
	public void ResetTable()
	{
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0x89B22C", Offset = "0x89B22C", VA = "0x89B22C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000100")]
	[Address(RVA = "0x89BCE8", Offset = "0x89BCE8", VA = "0x89BCE8")]
	public bool IsMenuShow()
	{
		return default(bool);
	}

	[Token(Token = "0x6000101")]
	[Address(RVA = "0x898E54", Offset = "0x898E54", VA = "0x898E54")]
	public static void StartGame(GameType type, GameMode mode, bool resetPos = true)
	{
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0x89BD2C", Offset = "0x89BD2C", VA = "0x89BD2C")]
	private void StartGameInner()
	{
	}

	[Token(Token = "0x6000103")]
	[Address(RVA = "0x89D0C0", Offset = "0x89D0C0", VA = "0x89D0C0")]
	public GameManager()
	{
	}
}
[Token(Token = "0x200003F")]
public enum GameType
{
	[Token(Token = "0x40000CD")]
	ChinesEightBall,
	[Token(Token = "0x40000CE")]
	NineBall,
	[Token(Token = "0x40000CF")]
	Snooker
}
[Token(Token = "0x2000040")]
public enum DefaultHand
{
	[Token(Token = "0x40000D1")]
	Left,
	[Token(Token = "0x40000D2")]
	Right
}
[Token(Token = "0x2000041")]
public enum GameMode
{
	[Token(Token = "0x40000D4")]
	AI,
	[Token(Token = "0x40000D5")]
	OnlineHost,
	[Token(Token = "0x40000D6")]
	OnlineClient
}
[Token(Token = "0x2000042")]
public enum GameState
{
	[Token(Token = "0x40000D8")]
	NotStart,
	[Token(Token = "0x40000D9")]
	InProgress,
	[Token(Token = "0x40000DA")]
	FreeBall,
	[Token(Token = "0x40000DB")]
	FreeBallAfterLine,
	[Token(Token = "0x40000DC")]
	TeeOffReady,
	[Token(Token = "0x40000DD")]
	TeeOff
}
[Token(Token = "0x2000043")]
public enum BallType
{
	[Token(Token = "0x40000DF")]
	Unknow,
	[Token(Token = "0x40000E0")]
	Full,
	[Token(Token = "0x40000E1")]
	Half,
	[Token(Token = "0x40000E2")]
	Black
}
[Token(Token = "0x2000044")]
public enum AILevel
{
	[Token(Token = "0x40000E4")]
	Level1,
	[Token(Token = "0x40000E5")]
	Level2,
	[Token(Token = "0x40000E6")]
	Level3,
	[Token(Token = "0x40000E7")]
	Level4
}
[Token(Token = "0x2000045")]
public class Guide : MonoBehaviour
{
	[StructLayout(3)]
	[Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct <StartBeginnerGuide>d__24 : IAsyncStateMachine
	{
		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Guide <>4__this;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TextMeshProUGUI <msgText>5__2;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private GameObject <rightCylinder>5__3;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private GameObject <leftCylinder>5__4;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private GameObject <rightModel>5__5;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private GameObject <leftModel>5__6;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private TaskAwaiter <>u__1;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private TaskAwaiter<VoidData> <>u__2;

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x8A1D64", Offset = "0x8A1D64", VA = "0x8A1D64", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x8A4D68", Offset = "0x8A4D68", VA = "0x8A4D68", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x2000048")]
	[CompilerGenerated]
	private struct <InitBall>d__27 : IAsyncStateMachine
	{
		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Guide <>4__this;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TaskAwaiter<VoidData> <>u__1;

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x8A4D74", Offset = "0x8A4D74", VA = "0x8A4D74", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x8A6AC0", Offset = "0x8A6AC0", VA = "0x8A6AC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x40000E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject BeginnerGuidePanl;

	[Token(Token = "0x40000E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject GuideMsg;

	[Token(Token = "0x40000EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject Cube;

	[Token(Token = "0x40000EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject Tag;

	[Token(Token = "0x40000EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject Gamepad;

	[Token(Token = "0x40000ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject MarkTag;

	[Token(Token = "0x40000EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject GanTag;

	[Token(Token = "0x40000EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject ScoreTag;

	[Token(Token = "0x40000F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject BallTag;

	[Token(Token = "0x40000F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public bool IsRightTrigger;

	[Token(Token = "0x40000F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
	public bool IsLeftTrigger;

	[Token(Token = "0x40000F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
	public bool IsLeftStick;

	[Token(Token = "0x40000F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
	public bool IsLeftX;

	[Token(Token = "0x40000F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public bool IsMenu;

	[Token(Token = "0x40000F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
	public bool IsRightA;

	[Token(Token = "0x40000F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x66")]
	private bool buttonPressed;

	[Token(Token = "0x40000F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public AudioSource AudioSource;

	[Token(Token = "0x40000F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public MockGan MockGan;

	[Token(Token = "0x40000FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public CustomTask<object> CustomTask;

	[Token(Token = "0x40000FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static List<List<BallTransform>> first;

	[Token(Token = "0x40000FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static List<List<BallTransform>> last;

	[Token(Token = "0x40000FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static Guide Instance;

	[Token(Token = "0x40000FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Vector3 whiteBall;

	[Token(Token = "0x6000123")]
	[Address(RVA = "0x8A0A3C", Offset = "0x8A0A3C", VA = "0x8A0A3C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000124")]
	[Address(RVA = "0x8A0CB4", Offset = "0x8A0CB4", VA = "0x8A0CB4")]
	[AsyncStateMachine(typeof(<StartBeginnerGuide>d__24))]
	public System.Threading.Tasks.Task StartBeginnerGuide()
	{
		return null;
	}

	[Token(Token = "0x6000125")]
	[Address(RVA = "0x8A0DA4", Offset = "0x8A0DA4", VA = "0x8A0DA4")]
	private void DestroyBall()
	{
	}

	[Token(Token = "0x6000126")]
	[Address(RVA = "0x8A0FD0", Offset = "0x8A0FD0", VA = "0x8A0FD0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000127")]
	[Address(RVA = "0x8A0BFC", Offset = "0x8A0BFC", VA = "0x8A0BFC")]
	[AsyncStateMachine(typeof(<InitBall>d__27))]
	private void InitBall()
	{
	}

	[Token(Token = "0x6000128")]
	[Address(RVA = "0x8A10D4", Offset = "0x8A10D4", VA = "0x8A10D4")]
	private void ResetHand()
	{
	}

	[Token(Token = "0x6000129")]
	[Address(RVA = "0x8A1384", Offset = "0x8A1384", VA = "0x8A1384")]
	private void ResetState()
	{
	}

	[Token(Token = "0x600012A")]
	[Address(RVA = "0x8A147C", Offset = "0x8A147C", VA = "0x8A147C")]
	public Guide()
	{
	}
}
[Token(Token = "0x2000049")]
public class BallTransform
{
	[Token(Token = "0x17000039")]
	public V3 Position
	{
		[Token(Token = "0x600013A")]
		[Address(RVA = "0x8A6ACC", Offset = "0x8A6ACC", VA = "0x8A6ACC")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600013B")]
		[Address(RVA = "0x8A6AD4", Offset = "0x8A6AD4", VA = "0x8A6AD4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700003A")]
	public V3 Rotation
	{
		[Token(Token = "0x600013C")]
		[Address(RVA = "0x8A6ADC", Offset = "0x8A6ADC", VA = "0x8A6ADC")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600013D")]
		[Address(RVA = "0x8A6AE4", Offset = "0x8A6AE4", VA = "0x8A6AE4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700003B")]
	public float time
	{
		[Token(Token = "0x600013E")]
		[Address(RVA = "0x8A6AEC", Offset = "0x8A6AEC", VA = "0x8A6AEC")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600013F")]
		[Address(RVA = "0x8A6AF4", Offset = "0x8A6AF4", VA = "0x8A6AF4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0x8A6AFC", Offset = "0x8A6AFC", VA = "0x8A6AFC")]
	public BallTransform()
	{
	}
}
[Token(Token = "0x200004A")]
public class V3
{
	[Token(Token = "0x1700003C")]
	public float x
	{
		[Token(Token = "0x6000141")]
		[Address(RVA = "0x8A6B04", Offset = "0x8A6B04", VA = "0x8A6B04")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000142")]
		[Address(RVA = "0x8A6B0C", Offset = "0x8A6B0C", VA = "0x8A6B0C")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700003D")]
	public float y
	{
		[Token(Token = "0x6000143")]
		[Address(RVA = "0x8A6B14", Offset = "0x8A6B14", VA = "0x8A6B14")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000144")]
		[Address(RVA = "0x8A6B1C", Offset = "0x8A6B1C", VA = "0x8A6B1C")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700003E")]
	public float z
	{
		[Token(Token = "0x6000145")]
		[Address(RVA = "0x8A6B24", Offset = "0x8A6B24", VA = "0x8A6B24")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000146")]
		[Address(RVA = "0x8A6B2C", Offset = "0x8A6B2C", VA = "0x8A6B2C")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x6000147")]
	[Address(RVA = "0x8A6B34", Offset = "0x8A6B34", VA = "0x8A6B34")]
	public V3(Vector3 v)
	{
	}
}
[Token(Token = "0x200004B")]
public static class ImageManager
{
	[StructLayout(3)]
	[Token(Token = "0x200004C")]
	[CompilerGenerated]
	private struct <LoadGuideTexture2D>d__1 : IAsyncStateMachine
	{
		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string[] nameArray;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string <fileName>5__2;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string[] <>7__wrap2;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int <>7__wrap3;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string <name>5__5;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private ResourceRequest <imageItem>5__6;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private TaskAwaiter<VoidData> <>u__1;

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x8A6E74", Offset = "0x8A6E74", VA = "0x8A6E74", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x8A7298", Offset = "0x8A7298", VA = "0x8A7298", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x400011D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Dictionary<string, Texture2D> guideTexture2D;

	[Token(Token = "0x6000148")]
	[Address(RVA = "0x8A4C74", Offset = "0x8A4C74", VA = "0x8A4C74")]
	[AsyncStateMachine(typeof(<LoadGuideTexture2D>d__1))]
	public static System.Threading.Tasks.Task LoadGuideTexture2D(string[] nameArray)
	{
		return null;
	}

	[Token(Token = "0x6000149")]
	[Address(RVA = "0x8A6B70", Offset = "0x8A6B70", VA = "0x8A6B70")]
	public static void UnLoadGuideClip()
	{
	}

	[Token(Token = "0x600014A")]
	[Address(RVA = "0x8A6D5C", Offset = "0x8A6D5C", VA = "0x8A6D5C")]
	public static Texture2D GetGuideTexture(string name)
	{
		return null;
	}
}
[Token(Token = "0x200004D")]
public class Adjust2Worker : KeyHandlerWorker
{
	[StructLayout(3)]
	[Token(Token = "0x200004E")]
	[CompilerGenerated]
	private struct <Start>d__1 : IAsyncStateMachine
	{
		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder<string> <>t__builder;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Adjust2Worker <>4__this;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Guide <instance>5__2;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private AudioSource <audio>5__3;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float <waitTime>5__4;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float <time>5__5;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TaskAwaiter <>u__1;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TaskAwaiter<VoidData> <>u__2;

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x8A73BC", Offset = "0x8A73BC", VA = "0x8A73BC", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x8A9010", Offset = "0x8A9010", VA = "0x8A9010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x4000127")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private bool initFlg;

	[Token(Token = "0x600014E")]
	[Address(RVA = "0x8A72A4", Offset = "0x8A72A4", VA = "0x8A72A4", Slot = "4")]
	[AsyncStateMachine(typeof(<Start>d__1))]
	public override System.Threading.Tasks.Task<string> Start()
	{
		return null;
	}

	[Token(Token = "0x600014F")]
	[Address(RVA = "0x8A73B4", Offset = "0x8A73B4", VA = "0x8A73B4")]
	public Adjust2Worker()
	{
	}
}
[Token(Token = "0x200004F")]
public class AdjustWorker : KeyHandlerWorker
{
	[StructLayout(3)]
	[Token(Token = "0x2000050")]
	[CompilerGenerated]
	private struct <Start>d__1 : IAsyncStateMachine
	{
		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder<string> <>t__builder;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AdjustWorker <>4__this;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Guide <instance>5__2;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private AudioSource <audio>5__3;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float <waitTime>5__4;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float <time>5__5;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TaskAwaiter <>u__1;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TaskAwaiter<VoidData> <>u__2;

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x8A9180", Offset = "0x8A9180", VA = "0x8A9180", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x8AA8D4", Offset = "0x8AA8D4", VA = "0x8AA8D4", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x4000131")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private bool initFlg;

	[Token(Token = "0x6000152")]
	[Address(RVA = "0x8A9068", Offset = "0x8A9068", VA = "0x8A9068", Slot = "4")]
	[AsyncStateMachine(typeof(<Start>d__1))]
	public override System.Threading.Tasks.Task<string> Start()
	{
		return null;
	}

	[Token(Token = "0x6000153")]
	[Address(RVA = "0x8A9178", Offset = "0x8A9178", VA = "0x8A9178")]
	public AdjustWorker()
	{
	}
}
[Token(Token = "0x2000051")]
public class DownBallWorker : KeyHandlerWorker
{
	[StructLayout(3)]
	[Token(Token = "0x2000052")]
	[CompilerGenerated]
	private struct <Start>d__3 : IAsyncStateMachine
	{
		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder<string> <>t__builder;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DownBallWorker <>4__this;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Guide <instance>5__2;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private AudioSource <audio>5__3;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float <waitTime>5__4;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float <time>5__5;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TaskAwaiter <>u__1;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TaskAwaiter<VoidData> <>u__2;

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x8AB2B0", Offset = "0x8AB2B0", VA = "0x8AB2B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x8ABE68", Offset = "0x8ABE68", VA = "0x8ABE68", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x400013B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private bool initFlg;

	[Token(Token = "0x400013C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private float ballMoveSpeed;

	[Token(Token = "0x400013D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Vector2 lastStickPos;

	[Token(Token = "0x6000156")]
	[Address(RVA = "0x8AA92C", Offset = "0x8AA92C", VA = "0x8AA92C", Slot = "4")]
	[AsyncStateMachine(typeof(<Start>d__3))]
	public override System.Threading.Tasks.Task<string> Start()
	{
		return null;
	}

	[Token(Token = "0x6000157")]
	[Address(RVA = "0x8AAA3C", Offset = "0x8AAA3C", VA = "0x8AAA3C")]
	private void Move()
	{
	}

	[Token(Token = "0x6000158")]
	[Address(RVA = "0x8AB250", Offset = "0x8AB250", VA = "0x8AB250")]
	public DownBallWorker()
	{
	}
}
[Token(Token = "0x2000053")]
public class HitBallWorker : KeyHandlerWorker
{
	[Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class <>c__DisplayClass0_0
	{
		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool isHit;

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x8ABFBC", Offset = "0x8ABFBC", VA = "0x8ABFBC")]
		public <>c__DisplayClass0_0()
		{
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x8ABFC4", Offset = "0x8ABFC4", VA = "0x8ABFC4")]
		internal void <Start>b__0()
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x2000055")]
	[CompilerGenerated]
	private struct <Start>d__0 : IAsyncStateMachine
	{
		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder<string> <>t__builder;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private <>c__DisplayClass0_0 <>8__1;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Guide <instance>5__2;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private AudioSource <audio>5__3;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float <waitTime>5__4;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float <time>5__5;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TaskAwaiter <>u__1;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TaskAwaiter<VoidData> <>u__2;

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x8ABFD0", Offset = "0x8ABFD0", VA = "0x8ABFD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x8AC9DC", Offset = "0x8AC9DC", VA = "0x8AC9DC", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x600015B")]
	[Address(RVA = "0x8ABEC0", Offset = "0x8ABEC0", VA = "0x8ABEC0", Slot = "4")]
	[AsyncStateMachine(typeof(<Start>d__0))]
	public override System.Threading.Tasks.Task<string> Start()
	{
		return null;
	}

	[Token(Token = "0x600015C")]
	[Address(RVA = "0x8ABFB4", Offset = "0x8ABFB4", VA = "0x8ABFB4")]
	public HitBallWorker()
	{
	}
}
[Token(Token = "0x2000056")]
public class KeyHandlerManager
{
	[StructLayout(3)]
	[Token(Token = "0x2000057")]
	[CompilerGenerated]
	private struct <Start>d__0 : IAsyncStateMachine
	{
		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Dictionary<string, KeyHandlerWorker> <KeyHandler>5__2;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TaskAwaiter<string> <>u__1;

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x8ACB0C", Offset = "0x8ACB0C", VA = "0x8ACB0C", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x8AD190", Offset = "0x8AD190", VA = "0x8AD190", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x6000161")]
	[Address(RVA = "0x8ACA34", Offset = "0x8ACA34", VA = "0x8ACA34")]
	[AsyncStateMachine(typeof(<Start>d__0))]
	public static System.Threading.Tasks.Task Start()
	{
		return null;
	}

	[Token(Token = "0x6000162")]
	[Address(RVA = "0x8ACB04", Offset = "0x8ACB04", VA = "0x8ACB04")]
	public KeyHandlerManager()
	{
	}
}
[Token(Token = "0x2000058")]
public abstract class KeyHandlerWorker
{
	[Token(Token = "0x6000165")]
	public abstract System.Threading.Tasks.Task<string> Start();

	[Token(Token = "0x6000166")]
	[Address(RVA = "0x8AB2A8", Offset = "0x8AB2A8", VA = "0x8AB2A8")]
	protected KeyHandlerWorker()
	{
	}
}
[Token(Token = "0x2000059")]
public class LeftGripWorker : KeyHandlerWorker
{
	[StructLayout(3)]
	[Token(Token = "0x200005A")]
	[CompilerGenerated]
	private struct <Start>d__1 : IAsyncStateMachine
	{
		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder<string> <>t__builder;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LeftGripWorker <>4__this;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Guide <instance>5__2;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private AudioSource <audio>5__3;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float <waitTime>5__4;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float <time>5__5;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TaskAwaiter <>u__1;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TaskAwaiter<VoidData> <>u__2;

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x8AD2B4", Offset = "0x8AD2B4", VA = "0x8AD2B4", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x8ADEA4", Offset = "0x8ADEA4", VA = "0x8ADEA4", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x4000155")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private bool initFlg;

	[Token(Token = "0x6000167")]
	[Address(RVA = "0x8AD19C", Offset = "0x8AD19C", VA = "0x8AD19C", Slot = "4")]
	[AsyncStateMachine(typeof(<Start>d__1))]
	public override System.Threading.Tasks.Task<string> Start()
	{
		return null;
	}

	[Token(Token = "0x6000168")]
	[Address(RVA = "0x8AD2AC", Offset = "0x8AD2AC", VA = "0x8AD2AC")]
	public LeftGripWorker()
	{
	}
}
[Token(Token = "0x200005B")]
public class LeftPrimaryWorker : KeyHandlerWorker
{
	[StructLayout(3)]
	[Token(Token = "0x200005C")]
	[CompilerGenerated]
	private struct <Start>d__1 : IAsyncStateMachine
	{
		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder<string> <>t__builder;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LeftPrimaryWorker <>4__this;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Guide <instance>5__2;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TextMeshProUGUI <msgText>5__3;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private AudioSource <audio>5__4;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float <waitTime>5__5;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float <time>5__6;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TaskAwaiter <>u__1;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private TaskAwaiter<VoidData> <>u__2;

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x8AE010", Offset = "0x8AE010", VA = "0x8AE010", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x8AEA88", Offset = "0x8AEA88", VA = "0x8AEA88", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x400015F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private bool initFlg;

	[Token(Token = "0x600016B")]
	[Address(RVA = "0x8ADEFC", Offset = "0x8ADEFC", VA = "0x8ADEFC", Slot = "4")]
	[AsyncStateMachine(typeof(<Start>d__1))]
	public override System.Threading.Tasks.Task<string> Start()
	{
		return null;
	}

	[Token(Token = "0x600016C")]
	[Address(RVA = "0x8AD134", Offset = "0x8AD134", VA = "0x8AD134")]
	public LeftPrimaryWorker()
	{
	}
}
[Token(Token = "0x200005D")]
public class LeftStickToGripWorker : KeyHandlerWorker
{
	[StructLayout(3)]
	[Token(Token = "0x200005E")]
	[CompilerGenerated]
	private struct <Start>d__1 : IAsyncStateMachine
	{
		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder<string> <>t__builder;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LeftStickToGripWorker <>4__this;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Guide <instance>5__2;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private AudioSource <audio>5__3;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float <waitTime>5__4;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float <time>5__5;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float <nextTime>5__6;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private bool <isOk>5__7;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x45")]
		private bool <isPlay>5__8;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TaskAwaiter <>u__1;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private TaskAwaiter<VoidData> <>u__2;

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x8AEBFC", Offset = "0x8AEBFC", VA = "0x8AEBFC", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x8AF994", Offset = "0x8AF994", VA = "0x8AF994", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x400016A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private bool initFlg;

	[Token(Token = "0x600016F")]
	[Address(RVA = "0x8AEAE0", Offset = "0x8AEAE0", VA = "0x8AEAE0", Slot = "4")]
	[AsyncStateMachine(typeof(<Start>d__1))]
	public override System.Threading.Tasks.Task<string> Start()
	{
		return null;
	}

	[Token(Token = "0x6000170")]
	[Address(RVA = "0x8AEBF4", Offset = "0x8AEBF4", VA = "0x8AEBF4")]
	public LeftStickToGripWorker()
	{
	}
}
[Token(Token = "0x200005F")]
public class LeftStickToTriggerWorker : KeyHandlerWorker
{
	[StructLayout(3)]
	[Token(Token = "0x2000060")]
	[CompilerGenerated]
	private struct <Start>d__1 : IAsyncStateMachine
	{
		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder<string> <>t__builder;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LeftStickToTriggerWorker <>4__this;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Guide <instance>5__2;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private AudioSource <audio>5__3;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float <waitTime>5__4;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float <time>5__5;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float <nextTime>5__6;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private bool <isOk>5__7;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x45")]
		private bool <isPlay>5__8;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TaskAwaiter <>u__1;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private TaskAwaiter<VoidData> <>u__2;

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x8AFB08", Offset = "0x8AFB08", VA = "0x8AFB08", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x8B08A0", Offset = "0x8B08A0", VA = "0x8B08A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x4000177")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private bool initFlg;

	[Token(Token = "0x6000173")]
	[Address(RVA = "0x8AF9EC", Offset = "0x8AF9EC", VA = "0x8AF9EC", Slot = "4")]
	[AsyncStateMachine(typeof(<Start>d__1))]
	public override System.Threading.Tasks.Task<string> Start()
	{
		return null;
	}

	[Token(Token = "0x6000174")]
	[Address(RVA = "0x8AFB00", Offset = "0x8AFB00", VA = "0x8AFB00")]
	public LeftStickToTriggerWorker()
	{
	}
}
[Token(Token = "0x2000061")]
public class LeftTriggerWorker : KeyHandlerWorker
{
	[StructLayout(3)]
	[Token(Token = "0x2000062")]
	[CompilerGenerated]
	private struct <Start>d__1 : IAsyncStateMachine
	{
		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder<string> <>t__builder;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LeftTriggerWorker <>4__this;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Guide <instance>5__2;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private AudioSource <audio>5__3;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float <waitTime>5__4;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float <time>5__5;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TaskAwaiter <>u__1;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TaskAwaiter<VoidData> <>u__2;

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x8B0A10", Offset = "0x8B0A10", VA = "0x8B0A10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x8B1608", Offset = "0x8B1608", VA = "0x8B1608", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x4000184")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private bool initFlg;

	[Token(Token = "0x6000177")]
	[Address(RVA = "0x8B08F8", Offset = "0x8B08F8", VA = "0x8B08F8", Slot = "4")]
	[AsyncStateMachine(typeof(<Start>d__1))]
	public override System.Threading.Tasks.Task<string> Start()
	{
		return null;
	}

	[Token(Token = "0x6000178")]
	[Address(RVA = "0x8B0A08", Offset = "0x8B0A08", VA = "0x8B0A08")]
	public LeftTriggerWorker()
	{
	}
}
[Token(Token = "0x2000063")]
public class LockGanWorker : KeyHandlerWorker
{
	[StructLayout(3)]
	[Token(Token = "0x2000064")]
	[CompilerGenerated]
	private struct <Start>d__4 : IAsyncStateMachine
	{
		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder<string> <>t__builder;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LockGanWorker <>4__this;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Guide <instance>5__2;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private AudioSource <audio>5__3;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float <waitTime>5__4;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float <time>5__5;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TaskAwaiter <>u__1;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TaskAwaiter<VoidData> <>u__2;

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x8B1770", Offset = "0x8B1770", VA = "0x8B1770", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x8B233C", Offset = "0x8B233C", VA = "0x8B233C", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x400018E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private bool initFlg;

	[Token(Token = "0x400018F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private string prevName;

	[Token(Token = "0x4000190")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private string nextName;

	[Token(Token = "0x600017B")]
	[Address(RVA = "0x8AD13C", Offset = "0x8AD13C", VA = "0x8AD13C")]
	public LockGanWorker(string prevName, string nextName)
	{
	}

	[Token(Token = "0x600017C")]
	[Address(RVA = "0x8B1660", Offset = "0x8B1660", VA = "0x8B1660", Slot = "4")]
	[AsyncStateMachine(typeof(<Start>d__4))]
	public override System.Threading.Tasks.Task<string> Start()
	{
		return null;
	}
}
[Token(Token = "0x2000065")]
public class MenuWorker : KeyHandlerWorker
{
	[StructLayout(3)]
	[Token(Token = "0x2000067")]
	[CompilerGenerated]
	private struct <Start>d__0 : IAsyncStateMachine
	{
		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder<string> <>t__builder;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Guide <instance>5__2;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private AudioSource <audio>5__3;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <waitTime>5__4;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <time>5__5;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TaskAwaiter <>u__1;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TaskAwaiter<VoidData> <>u__2;

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x8B2694", Offset = "0x8B2694", VA = "0x8B2694", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x8B3910", Offset = "0x8B3910", VA = "0x8B3910", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x600017F")]
	[Address(RVA = "0x8B2394", Offset = "0x8B2394", VA = "0x8B2394", Slot = "4")]
	[AsyncStateMachine(typeof(<Start>d__0))]
	public override System.Threading.Tasks.Task<string> Start()
	{
		return null;
	}

	[Token(Token = "0x6000180")]
	[Address(RVA = "0x8AD188", Offset = "0x8AD188", VA = "0x8AD188")]
	public MenuWorker()
	{
	}
}
[Token(Token = "0x2000068")]
public class MockGan : MonoBehaviour
{
	[Token(Token = "0x40001A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool isActive;

	[Token(Token = "0x40001A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private Vector3 pos;

	[Token(Token = "0x40001A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Vector3 deltaVec;

	[Token(Token = "0x40001A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private Vector3 position;

	[Token(Token = "0x40001A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Vector3 velocity;

	[Token(Token = "0x6000186")]
	[Address(RVA = "0x8B3968", Offset = "0x8B3968", VA = "0x8B3968")]
	public void Active()
	{
	}

	[Token(Token = "0x6000187")]
	[Address(RVA = "0x8B22FC", Offset = "0x8B22FC", VA = "0x8B22FC")]
	public void InActive()
	{
	}

	[Token(Token = "0x6000188")]
	[Address(RVA = "0x8B3A5C", Offset = "0x8B3A5C", VA = "0x8B3A5C")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000189")]
	[Address(RVA = "0x8B3D4C", Offset = "0x8B3D4C", VA = "0x8B3D4C")]
	public MockGan()
	{
	}
}
[Token(Token = "0x2000069")]
public class MoveBallWorker : KeyHandlerWorker
{
	[StructLayout(3)]
	[Token(Token = "0x200006A")]
	[CompilerGenerated]
	private struct <Start>d__3 : IAsyncStateMachine
	{
		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder<string> <>t__builder;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MoveBallWorker <>4__this;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Guide <instance>5__2;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private AudioSource <audio>5__3;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float <waitTime>5__4;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float <time>5__5;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float <nextTime>5__6;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private bool <isOk>5__7;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TaskAwaiter <>u__1;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private TaskAwaiter<VoidData> <>u__2;

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x8B46D4", Offset = "0x8B46D4", VA = "0x8B46D4", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x8B59B8", Offset = "0x8B59B8", VA = "0x8B59B8", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x40001A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private bool initFlg;

	[Token(Token = "0x40001AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private float ballMoveSpeed;

	[Token(Token = "0x40001AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Vector2 lastStickPos;

	[Token(Token = "0x600018A")]
	[Address(RVA = "0x8B3D54", Offset = "0x8B3D54", VA = "0x8B3D54", Slot = "4")]
	[AsyncStateMachine(typeof(<Start>d__3))]
	public override System.Threading.Tasks.Task<string> Start()
	{
		return null;
	}

	[Token(Token = "0x600018B")]
	[Address(RVA = "0x8B3E68", Offset = "0x8B3E68", VA = "0x8B3E68")]
	private void Move()
	{
	}

	[Token(Token = "0x600018C")]
	[Address(RVA = "0x8B467C", Offset = "0x8B467C", VA = "0x8B467C")]
	public MoveBallWorker()
	{
	}
}
[Token(Token = "0x200006B")]
public class MoveWorker : KeyHandlerWorker
{
	[StructLayout(3)]
	[Token(Token = "0x200006C")]
	[CompilerGenerated]
	private struct <Start>d__0 : IAsyncStateMachine
	{
		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder<string> <>t__builder;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Guide <instance>5__2;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private AudioSource <audio>5__3;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <waitTime>5__4;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <time>5__5;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool <isOk>5__6;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TaskAwaiter <>u__1;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TaskAwaiter<VoidData> <>u__2;

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x8B5B04", Offset = "0x8B5B04", VA = "0x8B5B04", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x8B6B38", Offset = "0x8B6B38", VA = "0x8B6B38", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x600018F")]
	[Address(RVA = "0x8B5A10", Offset = "0x8B5A10", VA = "0x8B5A10", Slot = "4")]
	[AsyncStateMachine(typeof(<Start>d__0))]
	public override System.Threading.Tasks.Task<string> Start()
	{
		return null;
	}

	[Token(Token = "0x6000190")]
	[Address(RVA = "0x8AD180", Offset = "0x8AD180", VA = "0x8AD180")]
	public MoveWorker()
	{
	}
}
[Token(Token = "0x200006D")]
public class RightGripWorker : KeyHandlerWorker
{
	[StructLayout(3)]
	[Token(Token = "0x200006E")]
	[CompilerGenerated]
	private struct <Start>d__1 : IAsyncStateMachine
	{
		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder<string> <>t__builder;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RightGripWorker <>4__this;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Guide <instance>5__2;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private AudioSource <audio>5__3;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float <waitTime>5__4;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float <time>5__5;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TaskAwaiter <>u__1;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TaskAwaiter<VoidData> <>u__2;

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x8B6CA8", Offset = "0x8B6CA8", VA = "0x8B6CA8", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x8B7998", Offset = "0x8B7998", VA = "0x8B7998", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x40001C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private bool initFlg;

	[Token(Token = "0x6000193")]
	[Address(RVA = "0x8B6B90", Offset = "0x8B6B90", VA = "0x8B6B90", Slot = "4")]
	[AsyncStateMachine(typeof(<Start>d__1))]
	public override System.Threading.Tasks.Task<string> Start()
	{
		return null;
	}

	[Token(Token = "0x6000194")]
	[Address(RVA = "0x8B6CA0", Offset = "0x8B6CA0", VA = "0x8B6CA0")]
	public RightGripWorker()
	{
	}
}
[Token(Token = "0x200006F")]
public class RightStickToGripWorker : KeyHandlerWorker
{
	[StructLayout(3)]
	[Token(Token = "0x2000070")]
	[CompilerGenerated]
	private struct <Start>d__1 : IAsyncStateMachine
	{
		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder<string> <>t__builder;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RightStickToGripWorker <>4__this;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Guide <instance>5__2;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private AudioSource <audio>5__3;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float <waitTime>5__4;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float <time>5__5;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float <nextTime>5__6;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private bool <isOk>5__7;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x45")]
		private bool <isPlay>5__8;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TaskAwaiter <>u__1;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private TaskAwaiter<VoidData> <>u__2;

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x8B7B0C", Offset = "0x8B7B0C", VA = "0x8B7B0C", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x8B88A4", Offset = "0x8B88A4", VA = "0x8B88A4", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x40001CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private bool initFlg;

	[Token(Token = "0x6000197")]
	[Address(RVA = "0x8B79F0", Offset = "0x8B79F0", VA = "0x8B79F0", Slot = "4")]
	[AsyncStateMachine(typeof(<Start>d__1))]
	public override System.Threading.Tasks.Task<string> Start()
	{
		return null;
	}

	[Token(Token = "0x6000198")]
	[Address(RVA = "0x8B7B04", Offset = "0x8B7B04", VA = "0x8B7B04")]
	public RightStickToGripWorker()
	{
	}
}
[Token(Token = "0x2000071")]
public class RightStickToTriggerWorker : KeyHandlerWorker
{
	[StructLayout(3)]
	[Token(Token = "0x2000072")]
	[CompilerGenerated]
	private struct <Start>d__1 : IAsyncStateMachine
	{
		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder<string> <>t__builder;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RightStickToTriggerWorker <>4__this;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Guide <instance>5__2;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private AudioSource <audio>5__3;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float <waitTime>5__4;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float <time>5__5;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float <nextTime>5__6;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TaskAwaiter <>u__1;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private TaskAwaiter<VoidData> <>u__2;

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x8B8A10", Offset = "0x8B8A10", VA = "0x8B8A10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x8B9F88", Offset = "0x8B9F88", VA = "0x8B9F88", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x40001D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private bool initFlg;

	[Token(Token = "0x600019B")]
	[Address(RVA = "0x8B88FC", Offset = "0x8B88FC", VA = "0x8B88FC", Slot = "4")]
	[AsyncStateMachine(typeof(<Start>d__1))]
	public override System.Threading.Tasks.Task<string> Start()
	{
		return null;
	}

	[Token(Token = "0x600019C")]
	[Address(RVA = "0x8AD12C", Offset = "0x8AD12C", VA = "0x8AD12C")]
	public RightStickToTriggerWorker()
	{
	}
}
[Token(Token = "0x2000073")]
public class RightTriggerWorker : KeyHandlerWorker
{
	[StructLayout(3)]
	[Token(Token = "0x2000074")]
	[CompilerGenerated]
	private struct <Start>d__1 : IAsyncStateMachine
	{
		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder<string> <>t__builder;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RightTriggerWorker <>4__this;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Guide <instance>5__2;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private AudioSource <audio>5__3;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float <waitTime>5__4;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float <time>5__5;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TaskAwaiter <>u__1;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TaskAwaiter<VoidData> <>u__2;

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x8BA0F0", Offset = "0x8BA0F0", VA = "0x8BA0F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x8BAE34", Offset = "0x8BAE34", VA = "0x8BAE34", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x40001E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private bool initFlg;

	[Token(Token = "0x600019F")]
	[Address(RVA = "0x8B9FE0", Offset = "0x8B9FE0", VA = "0x8B9FE0", Slot = "4")]
	[AsyncStateMachine(typeof(<Start>d__1))]
	public override System.Threading.Tasks.Task<string> Start()
	{
		return null;
	}

	[Token(Token = "0x60001A0")]
	[Address(RVA = "0x8AD124", Offset = "0x8AD124", VA = "0x8AD124")]
	public RightTriggerWorker()
	{
	}
}
[Token(Token = "0x2000075")]
public class ScoreWorker : KeyHandlerWorker
{
	[StructLayout(3)]
	[Token(Token = "0x2000076")]
	[CompilerGenerated]
	private struct <Start>d__0 : IAsyncStateMachine
	{
		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder<string> <>t__builder;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Guide <instance>5__2;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TaskAwaiter <>u__1;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TaskAwaiter<VoidData> <>u__2;

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x8BAF88", Offset = "0x8BAF88", VA = "0x8BAF88", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x8BB580", Offset = "0x8BB580", VA = "0x8BB580", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x60001A3")]
	[Address(RVA = "0x8BAE8C", Offset = "0x8BAE8C", VA = "0x8BAE8C", Slot = "4")]
	[AsyncStateMachine(typeof(<Start>d__0))]
	public override System.Threading.Tasks.Task<string> Start()
	{
		return null;
	}

	[Token(Token = "0x60001A4")]
	[Address(RVA = "0x8BAF80", Offset = "0x8BAF80", VA = "0x8BAF80")]
	public ScoreWorker()
	{
	}
}
[Token(Token = "0x2000077")]
[RequireComponent(typeof(MeshRenderer), typeof(MeshFilter))]
public class LineTool
{
	[Token(Token = "0x60001A7")]
	[Address(RVA = "0x8BB5D8", Offset = "0x8BB5D8", VA = "0x8BB5D8")]
	public static void DrawLine(Vector3 from, Vector3 to)
	{
	}

	[Token(Token = "0x60001A8")]
	[Address(RVA = "0x8BB734", Offset = "0x8BB734", VA = "0x8BB734")]
	private static Mesh CreateMesh(float len)
	{
		return null;
	}

	[Token(Token = "0x60001A9")]
	[Address(RVA = "0x8BB880", Offset = "0x8BB880", VA = "0x8BB880")]
	private static Material CreateMaterial()
	{
		return null;
	}

	[Token(Token = "0x60001AA")]
	[Address(RVA = "0x8BB934", Offset = "0x8BB934", VA = "0x8BB934")]
	public LineTool()
	{
	}
}
[Token(Token = "0x2000078")]
[RequireComponent(typeof(MeshRenderer), typeof(MeshFilter))]
public class ColorLineTool : MonoBehaviour
{
	[Token(Token = "0x40001F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private MeshRenderer m_MeshRender;

	[Token(Token = "0x40001F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private MeshFilter m_MeshFilter;

	[Token(Token = "0x40001F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static ColorLineTool instance;

	[Token(Token = "0x1700003F")]
	public static Color Color
	{
		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x8BB93C", Offset = "0x8BB93C", VA = "0x8BB93C")]
		[CompilerGenerated]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x8BB998", Offset = "0x8BB998", VA = "0x8BB998")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x60001AD")]
	[Address(RVA = "0x8BBA14", Offset = "0x8BBA14", VA = "0x8BBA14")]
	private void Start()
	{
	}

	[Token(Token = "0x60001AE")]
	[Address(RVA = "0x8BBD3C", Offset = "0x8BBD3C", VA = "0x8BBD3C")]
	public static void DrawLine(Vector3 from, Vector3 to)
	{
	}

	[Token(Token = "0x60001AF")]
	[Address(RVA = "0x8BBF60", Offset = "0x8BBF60", VA = "0x8BBF60")]
	public static void HideLine()
	{
	}

	[Token(Token = "0x60001B0")]
	[Address(RVA = "0x8BBBC0", Offset = "0x8BBBC0", VA = "0x8BBBC0")]
	private static Mesh CreateMesh()
	{
		return null;
	}

	[Token(Token = "0x60001B1")]
	[Address(RVA = "0x8BBB28", Offset = "0x8BBB28", VA = "0x8BBB28")]
	private static Material CreateMaterial()
	{
		return null;
	}

	[Token(Token = "0x60001B2")]
	[Address(RVA = "0x8BBFE8", Offset = "0x8BBFE8", VA = "0x8BBFE8")]
	public ColorLineTool()
	{
	}
}
[Token(Token = "0x2000079")]
[RequireComponent(typeof(MeshRenderer), typeof(MeshFilter))]
public class RectangleMesh : MonoBehaviour
{
	[Token(Token = "0x40001F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private MeshRenderer m_MeshRender;

	[Token(Token = "0x40001F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private MeshFilter m_MeshFilter;

	[Token(Token = "0x40001F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float Width;

	[Token(Token = "0x40001F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float Height;

	[Token(Token = "0x40001F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Texture2D Texture;

	[Token(Token = "0x60001B4")]
	[Address(RVA = "0x8BC03C", Offset = "0x8BC03C", VA = "0x8BC03C")]
	private void Start()
	{
	}

	[Token(Token = "0x60001B5")]
	[Address(RVA = "0x8BC2EC", Offset = "0x8BC2EC", VA = "0x8BC2EC")]
	private Mesh CreateMesh()
	{
		return null;
	}

	[Token(Token = "0x60001B6")]
	[Address(RVA = "0x8BC114", Offset = "0x8BC114", VA = "0x8BC114")]
	private Material CreateMaterial()
	{
		return null;
	}

	[Token(Token = "0x60001B7")]
	[Address(RVA = "0x8BC550", Offset = "0x8BC550", VA = "0x8BC550")]
	public RectangleMesh()
	{
	}
}
[Token(Token = "0x200007A")]
[RequireComponent(typeof(MeshRenderer), typeof(MeshFilter))]
public class SphereMesh : MonoBehaviour
{
	[Token(Token = "0x40001FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private int segments;

	[Token(Token = "0x40001FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private float radius;

	[Token(Token = "0x40001FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private MeshRenderer m_MeshRender;

	[Token(Token = "0x40001FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private MeshFilter m_MeshFilter;

	[Token(Token = "0x60001B8")]
	[Address(RVA = "0x8BC558", Offset = "0x8BC558", VA = "0x8BC558")]
	private void Start()
	{
	}

	[Token(Token = "0x60001B9")]
	[Address(RVA = "0x8BC834", Offset = "0x8BC834", VA = "0x8BC834")]
	private Mesh CreateMesh()
	{
		return null;
	}

	[Token(Token = "0x60001BA")]
	[Address(RVA = "0x8BC62C", Offset = "0x8BC62C", VA = "0x8BC62C")]
	private Material CreateMaterial()
	{
		return null;
	}

	[Token(Token = "0x60001BB")]
	[Address(RVA = "0x8BCB68", Offset = "0x8BCB68", VA = "0x8BCB68")]
	public SphereMesh()
	{
	}
}
[Token(Token = "0x200007B")]
public static class ApiClient
{
	[Token(Token = "0x200007C")]
	public class EventData
	{
		[Token(Token = "0x17000041")]
		public string Event
		{
			[Token(Token = "0x60001C9")]
			[Address(RVA = "0x8BE0F0", Offset = "0x8BE0F0", VA = "0x8BE0F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001CA")]
			[Address(RVA = "0x8BE0F8", Offset = "0x8BE0F8", VA = "0x8BE0F8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x8BE100", Offset = "0x8BE100", VA = "0x8BE100")]
		public EventData()
		{
		}
	}

	[Token(Token = "0x200007D")]
	public enum Method
	{
		[Token(Token = "0x4000201")]
		GET,
		[Token(Token = "0x4000202")]
		POST,
		[Token(Token = "0x4000203")]
		DELETE
	}

	[StructLayout(3)]
	[Token(Token = "0x200007E")]
	[CompilerGenerated]
	private struct <RequestAsyncInner>d__7<T, U> : IAsyncStateMachine where T : BaseResponse<U>, new()
	{
		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string path;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Dictionary<string, string> param;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Method method;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public object body;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private UnityWebRequest <request>5__2;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private TaskAwaiter<VoidData> <>u__1;

		[Token(Token = "0x60001CC")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x60001CD")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x17000040")]
	public static string Token
	{
		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x8BDB7C", Offset = "0x8BDB7C", VA = "0x8BDB7C")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x8BDBC4", Offset = "0x8BDBC4", VA = "0x8BDBC4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x60001BE")]
	[Address(RVA = "0x8BDC1C", Offset = "0x8BDC1C", VA = "0x8BDC1C")]
	private static UnityWebRequest CreateUnityWebRequest(Uri uri, Method method, object body)
	{
		return null;
	}

	[Token(Token = "0x60001BF")]
	[Address(RVA = "0x8BDE98", Offset = "0x8BDE98", VA = "0x8BDE98")]
	public static System.Threading.Tasks.Task<BaseResponse> RequestAsync(Method method, string path, Dictionary<string, string> param, object body)
	{
		return null;
	}

	[Token(Token = "0x60001C0")]
	public static System.Threading.Tasks.Task<BaseResponse<T>> RequestAsync<T>(Method method, string path, Dictionary<string, string> param, object body)
	{
		return null;
	}

	[Token(Token = "0x60001C1")]
	[AsyncStateMachine(typeof(<RequestAsyncInner>d__7<, >))]
	private static System.Threading.Tasks.Task<T> RequestAsyncInner<T, U>(Method method, string path, Dictionary<string, string> param, object body) where T : BaseResponse<U>, new()
	{
		return null;
	}

	[Token(Token = "0x60001C2")]
	public static System.Threading.Tasks.Task<BaseResponse<T>> Get<T>(string path, [Optional] Dictionary<string, string> param)
	{
		return null;
	}

	[Token(Token = "0x60001C3")]
	[Address(RVA = "0x8BDF08", Offset = "0x8BDF08", VA = "0x8BDF08")]
	public static System.Threading.Tasks.Task<BaseResponse> Get(string path, [Optional] Dictionary<string, string> param)
	{
		return null;
	}

	[Token(Token = "0x60001C4")]
	public static System.Threading.Tasks.Task<BaseResponse<T>> Delete<T>(string path, [Optional] Dictionary<string, string> param)
	{
		return null;
	}

	[Token(Token = "0x60001C5")]
	[Address(RVA = "0x8BDF1C", Offset = "0x8BDF1C", VA = "0x8BDF1C")]
	public static System.Threading.Tasks.Task<BaseResponse> Delete(string path, [Optional] Dictionary<string, string> param)
	{
		return null;
	}

	[Token(Token = "0x60001C6")]
	public static System.Threading.Tasks.Task<BaseResponse<T>> Post<T>(string path, object body, [Optional] Dictionary<string, string> param)
	{
		return null;
	}

	[Token(Token = "0x60001C7")]
	[Address(RVA = "0x8BDF34", Offset = "0x8BDF34", VA = "0x8BDF34")]
	public static System.Threading.Tasks.Task<BaseResponse> Post(string path, object body, [Optional] Dictionary<string, string> param)
	{
		return null;
	}

	[Token(Token = "0x60001C8")]
	[Address(RVA = "0x8BDF48", Offset = "0x8BDF48", VA = "0x8BDF48")]
	public static void PostEvent(object eventData)
	{
	}
}
[Token(Token = "0x200007F")]
public class CommandSync : MonoBehaviour
{
	[Token(Token = "0x2000080")]
	public class CommandData
	{
		[Token(Token = "0x17000042")]
		public string Name
		{
			[Token(Token = "0x60001D8")]
			[Address(RVA = "0x8BF30C", Offset = "0x8BF30C", VA = "0x8BF30C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001D9")]
			[Address(RVA = "0x8BF314", Offset = "0x8BF314", VA = "0x8BF314")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000043")]
		public string Data
		{
			[Token(Token = "0x60001DA")]
			[Address(RVA = "0x8BF31C", Offset = "0x8BF31C", VA = "0x8BF31C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001DB")]
			[Address(RVA = "0x8BF324", Offset = "0x8BF324", VA = "0x8BF324")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000044")]
		public float Time
		{
			[Token(Token = "0x60001DC")]
			[Address(RVA = "0x8BF32C", Offset = "0x8BF32C", VA = "0x8BF32C")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001DD")]
			[Address(RVA = "0x8BF334", Offset = "0x8BF334", VA = "0x8BF334")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x8BF14C", Offset = "0x8BF14C", VA = "0x8BF14C")]
		public CommandData(string name, string data, float time)
		{
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x8BE764", Offset = "0x8BE764", VA = "0x8BE764")]
		public CommandData(string name, object data)
		{
		}

		[Token(Token = "0x60001E0")]
		public object GetData<T>()
		{
			return null;
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x8BE7E8", Offset = "0x8BE7E8", VA = "0x8BE7E8")]
		public byte[] ToBytes()
		{
			return null;
		}
	}

	[Token(Token = "0x400020C")]
	private const byte TYPE_FLAG = 2;

	[Token(Token = "0x400020D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static ConcurrentDictionary<string, Action<CommandData>> receiveActionList;

	[Token(Token = "0x400020E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static ConcurrentQueue<CommandData> cmdQueue;

	[Token(Token = "0x400020F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static Func<bool> preSendFinish;

	[Token(Token = "0x60001CE")]
	[Address(RVA = "0x8BE108", Offset = "0x8BE108", VA = "0x8BE108")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60001CF")]
	public static void RegisterCommand<T>(string name, Action<T> action)
	{
	}

	[Token(Token = "0x60001D0")]
	[Address(RVA = "0x8BE1C0", Offset = "0x8BE1C0", VA = "0x8BE1C0")]
	public static void RegisterCommand(string name, Action action)
	{
	}

	[Token(Token = "0x60001D1")]
	public static void RegisterCommand<T>(string name, Action<T> action, T anonymousTypeObject)
	{
	}

	[Token(Token = "0x60001D2")]
	[Address(RVA = "0x8BE304", Offset = "0x8BE304", VA = "0x8BE304")]
	private void Update()
	{
	}

	[Token(Token = "0x60001D3")]
	[Address(RVA = "0x8BE5A0", Offset = "0x8BE5A0", VA = "0x8BE5A0")]
	private static void PushCommand(CommandData data)
	{
	}

	[Token(Token = "0x60001D4")]
	[Address(RVA = "0x8BE674", Offset = "0x8BE674", VA = "0x8BE674")]
	public static void SendCommand(string name, [Optional] object data, bool realtime = false)
	{
	}

	[Token(Token = "0x60001D5")]
	[Address(RVA = "0x8BEE64", Offset = "0x8BEE64", VA = "0x8BEE64")]
	public static bool Parse(RingBuff rBuff)
	{
		return default(bool);
	}

	[Token(Token = "0x60001D6")]
	[Address(RVA = "0x8BF218", Offset = "0x8BF218", VA = "0x8BF218")]
	public CommandSync()
	{
	}
}
[Token(Token = "0x2000084")]
public static class NetClient
{
	[StructLayout(3)]
	[Token(Token = "0x2000085")]
	[CompilerGenerated]
	private struct <GetTcpClientAsync>d__0 : IAsyncStateMachine
	{
		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder<NetStream> <>t__builder;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string token;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TaskAwaiter<TcpClient> <>u__1;

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x8BFA8C", Offset = "0x8BFA8C", VA = "0x8BFA8C", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x8BFDEC", Offset = "0x8BFDEC", VA = "0x8BFDEC", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x2000087")]
	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0
	{
		[StructLayout(3)]
		[Token(Token = "0x2000088")]
		private struct <<GetNatTcpClientAsync>b__0>d : IAsyncStateMachine
		{
			[Token(Token = "0x4000226")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000227")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<TcpClient> <>t__builder;

			[Token(Token = "0x4000228")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public <>c__DisplayClass2_0 <>4__this;

			[Token(Token = "0x4000229")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int <i>5__2;

			[Token(Token = "0x400022A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private TaskAwaiter<bool> <>u__1;

			[Token(Token = "0x60001F6")]
			[Address(RVA = "0x8C0070", Offset = "0x8C0070", VA = "0x8C0070", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60001F7")]
			[Address(RVA = "0x8C0454", Offset = "0x8C0454", VA = "0x8C0454", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000089")]
		private struct <<GetNatTcpClientAsync>b__3>d : IAsyncStateMachine
		{
			[Token(Token = "0x400022B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x400022C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<TcpClient> <>t__builder;

			[Token(Token = "0x400022D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public <>c__DisplayClass2_0 <>4__this;

			[Token(Token = "0x400022E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private DateTime <stime>5__2;

			[Token(Token = "0x400022F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private List<System.Threading.Tasks.Task<TcpClient>>.Enumerator <>7__wrap2;

			[Token(Token = "0x4000230")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private System.Threading.Tasks.Task<TcpClient> <item>5__4;

			[Token(Token = "0x4000231")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private ValueTaskAwaiter <>u__1;

			[Token(Token = "0x4000232")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private TaskAwaiter<VoidData> <>u__2;

			[Token(Token = "0x60001F8")]
			[Address(RVA = "0x8C04AC", Offset = "0x8C04AC", VA = "0x8C04AC", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60001F9")]
			[Address(RVA = "0x8C0F50", Offset = "0x8C0F50", VA = "0x8C0F50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool connected;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string token;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int acceptIndex;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool taskEnd;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TcpListener tcpListener;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public TcpClient natClient;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string ip;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int port;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public List<System.Threading.Tasks.Task<TcpClient>> clientTaskList;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public int acceptCounnt;

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x8BFE44", Offset = "0x8BFE44", VA = "0x8BFE44")]
		public <>c__DisplayClass2_0()
		{
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x8BFE4C", Offset = "0x8BFE4C", VA = "0x8BFE4C")]
		[AsyncStateMachine(typeof(<<GetNatTcpClientAsync>b__0>d))]
		internal System.Threading.Tasks.Task<TcpClient> <GetNatTcpClientAsync>b__0()
		{
			return null;
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x8BFF5C", Offset = "0x8BFF5C", VA = "0x8BFF5C")]
		[AsyncStateMachine(typeof(<<GetNatTcpClientAsync>b__3>d))]
		internal System.Threading.Tasks.Task<TcpClient> <GetNatTcpClientAsync>b__3()
		{
			return null;
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x2000090")]
	[CompilerGenerated]
	private struct <GetNatTcpClientAsync>d__2 : IAsyncStateMachine
	{
		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder<TcpClient> <>t__builder;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string token;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private <>c__DisplayClass2_0 <>8__1;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TcpClient <clientServer>5__2;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TaskAwaiter <>u__1;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private MemoryStream <buffStream>5__3;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private NetworkStream <stream>5__4;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int <buffLen>5__5;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private byte[] <buff>5__6;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private ValueTaskAwaiter <>u__2;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int <>7__wrap6;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private TaskAwaiter<int> <>u__3;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private TaskAwaiter<TcpClient> <>u__4;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private List<System.Threading.Tasks.Task<TcpClient>> <confirmList>5__8;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private DateTime <stime>5__9;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private TaskAwaiter<VoidData> <>u__5;

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x8C28D0", Offset = "0x8C28D0", VA = "0x8C28D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x8C4F84", Offset = "0x8C4F84", VA = "0x8C4F84", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x2000091")]
	[CompilerGenerated]
	private struct <GetTransferTcpClient>d__3 : IAsyncStateMachine
	{
		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder<TcpClient> <>t__builder;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string token;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TcpClient <client>5__2;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private byte[] <buff>5__3;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private NetworkStream <stream>5__4;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TaskAwaiter <>u__1;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private ValueTaskAwaiter <>u__2;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private TaskAwaiter<int> <>u__3;

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x8C4FDC", Offset = "0x8C4FDC", VA = "0x8C4FDC", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x8C58E4", Offset = "0x8C58E4", VA = "0x8C58E4", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x60001E8")]
	[Address(RVA = "0x8BF360", Offset = "0x8BF360", VA = "0x8BF360")]
	[AsyncStateMachine(typeof(<GetTcpClientAsync>d__0))]
	public static System.Threading.Tasks.Task<NetStream> GetTcpClientAsync(string token)
	{
		return null;
	}

	[Token(Token = "0x60001E9")]
	private static System.Threading.Tasks.Task<T> CreateTask<T>(Func<System.Threading.Tasks.Task<T>> function)
	{
		return null;
	}

	[Token(Token = "0x60001EA")]
	[Address(RVA = "0x8BF46C", Offset = "0x8BF46C", VA = "0x8BF46C")]
	[AsyncStateMachine(typeof(<GetNatTcpClientAsync>d__2))]
	private static System.Threading.Tasks.Task<TcpClient> GetNatTcpClientAsync(string token)
	{
		return null;
	}

	[Token(Token = "0x60001EB")]
	[Address(RVA = "0x8BF584", Offset = "0x8BF584", VA = "0x8BF584")]
	[AsyncStateMachine(typeof(<GetTransferTcpClient>d__3))]
	private static System.Threading.Tasks.Task<TcpClient> GetTransferTcpClient(string token)
	{
		return null;
	}

	[Token(Token = "0x60001EC")]
	[Address(RVA = "0x8BF694", Offset = "0x8BF694", VA = "0x8BF694")]
	private static byte[] ReverseBytes(byte[] buff)
	{
		return null;
	}

	[Token(Token = "0x60001ED")]
	[Address(RVA = "0x8BF6B0", Offset = "0x8BF6B0", VA = "0x8BF6B0")]
	private static byte[] ReverseBytes(byte[] buff, int index, int len)
	{
		return null;
	}

	[Token(Token = "0x60001EE")]
	[Address(RVA = "0x8BF774", Offset = "0x8BF774", VA = "0x8BF774")]
	private static bool ReadSocketInfo(byte[] buff, int len, out string ip, out int port, out List<string> localIps, out int flag)
	{
		return default(bool);
	}
}
[Token(Token = "0x2000092")]
public static class NetManager
{
	[Token(Token = "0x2000093")]
	private class SendBuff
	{
		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool finish;

		[Token(Token = "0x17000047")]
		public byte[] Data
		{
			[Token(Token = "0x600021D")]
			[Address(RVA = "0x8C6F78", Offset = "0x8C6F78", VA = "0x8C6F78")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600021C")]
			[Address(RVA = "0x8C6F70", Offset = "0x8C6F70", VA = "0x8C6F70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000048")]
		public Func<bool> IsFinish
		{
			[Token(Token = "0x600021F")]
			[Address(RVA = "0x8C6F88", Offset = "0x8C6F88", VA = "0x8C6F88")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600021E")]
			[Address(RVA = "0x8C6F80", Offset = "0x8C6F80", VA = "0x8C6F80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x8C6880", Offset = "0x8C6880", VA = "0x8C6880")]
		public SendBuff(byte[] data)
		{
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x8C6F90", Offset = "0x8C6F90", VA = "0x8C6F90")]
		public void Finish()
		{
		}
	}

	[Token(Token = "0x2000094")]
	public class RoomCodeResult
	{
		[Token(Token = "0x17000049")]
		public string Code
		{
			[Token(Token = "0x6000223")]
			[Address(RVA = "0x8C6FA4", Offset = "0x8C6FA4", VA = "0x8C6FA4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000224")]
			[Address(RVA = "0x8C6FAC", Offset = "0x8C6FAC", VA = "0x8C6FAC")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700004A")]
		public string Token
		{
			[Token(Token = "0x6000225")]
			[Address(RVA = "0x8C6FB4", Offset = "0x8C6FB4", VA = "0x8C6FB4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000226")]
			[Address(RVA = "0x8C6FBC", Offset = "0x8C6FBC", VA = "0x8C6FBC")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x8C6FC4", Offset = "0x8C6FC4", VA = "0x8C6FC4")]
		public RoomCodeResult()
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x2000095")]
	[CompilerGenerated]
	private struct <Login>d__21 : IAsyncStateMachine
	{
		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TaskAwaiter<bool> <>u__1;

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x8C6FCC", Offset = "0x8C6FCC", VA = "0x8C6FCC", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x8C737C", Offset = "0x8C737C", VA = "0x8C737C", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x2000096")]
	[CompilerGenerated]
	private struct <GenerateRoomCode>d__22 : IAsyncStateMachine
	{
		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder<RoomCodeResult> <>t__builder;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TaskAwaiter<BaseResponse<RoomCodeResult>> <>u__1;

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x8C73D4", Offset = "0x8C73D4", VA = "0x8C73D4", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x8C7670", Offset = "0x8C7670", VA = "0x8C7670", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x2000098")]
	[CompilerGenerated]
	private struct <GetRoomToken>d__24 : IAsyncStateMachine
	{
		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder<string> <>t__builder;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string code;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TaskAwaiter<BaseResponse<string>> <>u__1;

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x8C7B64", Offset = "0x8C7B64", VA = "0x8C7B64", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x8C7E30", Offset = "0x8C7E30", VA = "0x8C7E30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x200009B")]
	[CompilerGenerated]
	private struct <ConnectByToken>d__26 : IAsyncStateMachine
	{
		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string token;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TaskAwaiter<NetStream> <>u__1;

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x8C83F4", Offset = "0x8C83F4", VA = "0x8C83F4", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x8C8760", Offset = "0x8C8760", VA = "0x8C8760", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x200009D")]
	[CompilerGenerated]
	private struct <Disconnect>d__28 : IAsyncStateMachine
	{
		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float delay;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TaskAwaiter<VoidData> <>u__1;

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x8C8840", Offset = "0x8C8840", VA = "0x8C8840", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x8C8BCC", Offset = "0x8C8BCC", VA = "0x8C8BCC", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x200009E")]
	[CompilerGenerated]
	private struct <ReceiveTaskAsync>d__30 : IAsyncStateMachine
	{
		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int <timeout>5__2;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private byte[] <buff>5__3;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private object <>7__wrap3;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int <>7__wrap4;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TaskAwaiter<int> <>u__1;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TaskAwaiter<VoidData> <>u__2;

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x8C8BD8", Offset = "0x8C8BD8", VA = "0x8C8BD8", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x8C9DE4", Offset = "0x8C9DE4", VA = "0x8C9DE4", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x200009F")]
	[CompilerGenerated]
	private struct <SendTaskAsync>d__31 : IAsyncStateMachine
	{
		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ValueTaskAwaiter <>u__1;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private SendBuff <item>5__2;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TaskAwaiter<VoidData> <>u__2;

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x8C9DF0", Offset = "0x8C9DF0", VA = "0x8C9DF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x8CAAC0", Offset = "0x8CAAC0", VA = "0x8CAAC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x4000268")]
	private const int BUFF_SIZE = 2048000;

	[Token(Token = "0x4000269")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static ConcurrentQueue<SendBuff> sendList;

	[Token(Token = "0x400026B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static NetStream netStreamOpponent;

	[Token(Token = "0x400026C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static bool isSendRunning;

	[Token(Token = "0x400026D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	private static bool runFlag;

	[Token(Token = "0x400026E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	private static bool isDisconnected;

	[Token(Token = "0x400026F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static RingBuff cacheBuf;

	[Token(Token = "0x4000270")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public static Action ErrorAction;

	[Token(Token = "0x4000271")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public static Action ReconnectedAction;

	[Token(Token = "0x4000272")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public static Action DisconnectAction;

	[Token(Token = "0x4000273")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private static SendBuff errorSendBuff;

	[Token(Token = "0x4000274")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private static string roomCode;

	[Token(Token = "0x4000275")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private static bool disconnectConfirm;

	[Token(Token = "0x17000045")]
	public static bool IsOpponentConnected
	{
		[Token(Token = "0x600020A")]
		[Address(RVA = "0x8C593C", Offset = "0x8C593C", VA = "0x8C593C")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600020B")]
		[Address(RVA = "0x8C5994", Offset = "0x8C5994", VA = "0x8C5994")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000046")]
	public static string Token
	{
		[Token(Token = "0x600020C")]
		[Address(RVA = "0x8C59F0", Offset = "0x8C59F0", VA = "0x8C59F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600020D")]
		[Address(RVA = "0x8C5A48", Offset = "0x8C5A48", VA = "0x8C5A48")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x600020E")]
	[Address(RVA = "0x8C5AA8", Offset = "0x8C5AA8", VA = "0x8C5AA8")]
	[AsyncStateMachine(typeof(<Login>d__21))]
	public static System.Threading.Tasks.Task<bool> Login()
	{
		return null;
	}

	[Token(Token = "0x600020F")]
	[Address(RVA = "0x8C5BA0", Offset = "0x8C5BA0", VA = "0x8C5BA0")]
	[AsyncStateMachine(typeof(<GenerateRoomCode>d__22))]
	public static System.Threading.Tasks.Task<RoomCodeResult> GenerateRoomCode()
	{
		return null;
	}

	[Token(Token = "0x6000210")]
	[Address(RVA = "0x8C5C90", Offset = "0x8C5C90", VA = "0x8C5C90")]
	public static WaitTaskResult WaitForRoomJoin(float timeout, CancellationToken cancellationToken)
	{
		return null;
	}

	[Token(Token = "0x6000211")]
	[Address(RVA = "0x8C61D4", Offset = "0x8C61D4", VA = "0x8C61D4")]
	[AsyncStateMachine(typeof(<GetRoomToken>d__24))]
	public static System.Threading.Tasks.Task<string> GetRoomToken(string code)
	{
		return null;
	}

	[Token(Token = "0x6000212")]
	[Address(RVA = "0x8C62E0", Offset = "0x8C62E0", VA = "0x8C62E0")]
	public static WaitTaskResult<RandomMathResponse> ConnectRandomAsync(float timeout, CancellationToken cancellationToken)
	{
		return null;
	}

	[Token(Token = "0x6000213")]
	[Address(RVA = "0x8C6658", Offset = "0x8C6658", VA = "0x8C6658")]
	[AsyncStateMachine(typeof(<ConnectByToken>d__26))]
	public static System.Threading.Tasks.Task ConnectByToken(string token)
	{
		return null;
	}

	[Token(Token = "0x6000214")]
	[Address(RVA = "0x8C6744", Offset = "0x8C6744", VA = "0x8C6744")]
	public static void DisconnectConfirm()
	{
	}

	[Token(Token = "0x6000215")]
	[Address(RVA = "0x8C67A0", Offset = "0x8C67A0", VA = "0x8C67A0")]
	[AsyncStateMachine(typeof(<Disconnect>d__28))]
	public static System.Threading.Tasks.Task Disconnect(float delay = 0f)
	{
		return null;
	}

	[Token(Token = "0x6000216")]
	[Address(RVA = "0x8BEC18", Offset = "0x8BEC18", VA = "0x8BEC18")]
	public static Func<bool> SendToOpponentAsync(byte[] data)
	{
		return null;
	}

	[Token(Token = "0x6000217")]
	[Address(RVA = "0x8C69FC", Offset = "0x8C69FC", VA = "0x8C69FC")]
	[AsyncStateMachine(typeof(<ReceiveTaskAsync>d__30))]
	private static System.Threading.Tasks.Task ReceiveTaskAsync()
	{
		return null;
	}

	[Token(Token = "0x6000218")]
	[Address(RVA = "0x8C692C", Offset = "0x8C692C", VA = "0x8C692C")]
	[AsyncStateMachine(typeof(<SendTaskAsync>d__31))]
	private static System.Threading.Tasks.Task SendTaskAsync()
	{
		return null;
	}

	[Token(Token = "0x6000219")]
	[Address(RVA = "0x8C6AD0", Offset = "0x8C6AD0", VA = "0x8C6AD0")]
	private static void OnError()
	{
	}

	[Token(Token = "0x600021A")]
	[Address(RVA = "0x8C6C88", Offset = "0x8C6C88", VA = "0x8C6C88")]
	private static void Reconnect(int retry = 0)
	{
	}
}
[Token(Token = "0x20000A1")]
public abstract class NetStream
{
	[Token(Token = "0x1700004B")]
	public virtual bool Connected
	{
		[Token(Token = "0x6000250")]
		[Address(RVA = "0x8CB524", Offset = "0x8CB524", VA = "0x8CB524", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000251")]
		[Address(RVA = "0x8CB52C", Offset = "0x8CB52C", VA = "0x8CB52C")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x6000252")]
	public abstract void Close();

	[Token(Token = "0x6000253")]
	public abstract System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, float timeout);

	[Token(Token = "0x6000254")]
	public abstract ValueTask WriteAsync(byte[] data);

	[Token(Token = "0x6000255")]
	[Address(RVA = "0x8CB538", Offset = "0x8CB538", VA = "0x8CB538")]
	protected NetStream()
	{
	}
}
[Token(Token = "0x20000A2")]
public class PicoNetStream : NetStream
{
	[StructLayout(3)]
	[Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private struct <ReadAsync>d__5 : IAsyncStateMachine
	{
		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PicoNetStream <>4__this;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public byte[] buffer;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float timeout;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TaskAwaiter<Packet> <>u__1;

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x8CB890", Offset = "0x8CB890", VA = "0x8CB890", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x8CBDD8", Offset = "0x8CBDD8", VA = "0x8CBDD8", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x40002B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private string userId;

	[Token(Token = "0x40002B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private byte[] cache;

	[Token(Token = "0x40002B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int cacheOffset;

	[Token(Token = "0x6000256")]
	[Address(RVA = "0x8CB540", Offset = "0x8CB540", VA = "0x8CB540")]
	public PicoNetStream(string userId)
	{
	}

	[Token(Token = "0x6000257")]
	[Address(RVA = "0x8CB570", Offset = "0x8CB570", VA = "0x8CB570", Slot = "5")]
	public override void Close()
	{
	}

	[Token(Token = "0x6000258")]
	[Address(RVA = "0x8CB574", Offset = "0x8CB574", VA = "0x8CB574", Slot = "6")]
	[AsyncStateMachine(typeof(<ReadAsync>d__5))]
	public override System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, float timeout)
	{
		return null;
	}

	[Token(Token = "0x6000259")]
	[Address(RVA = "0x8CB6B4", Offset = "0x8CB6B4", VA = "0x8CB6B4", Slot = "7")]
	public override ValueTask WriteAsync(byte[] data)
	{
		return default(ValueTask);
	}
}
[Token(Token = "0x20000A6")]
public class TcpClientStream : NetStream
{
	[Token(Token = "0x40002BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private TcpClient client;

	[Token(Token = "0x1700004C")]
	public override bool Connected
	{
		[Token(Token = "0x6000262")]
		[Address(RVA = "0x8CBE5C", Offset = "0x8CBE5C", VA = "0x8CBE5C", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000261")]
	[Address(RVA = "0x8BFDBC", Offset = "0x8BFDBC", VA = "0x8BFDBC")]
	public TcpClientStream(TcpClient client)
	{
	}

	[Token(Token = "0x6000263")]
	[Address(RVA = "0x8CBE78", Offset = "0x8CBE78", VA = "0x8CBE78", Slot = "5")]
	public override void Close()
	{
	}

	[Token(Token = "0x6000264")]
	[Address(RVA = "0x8CBE94", Offset = "0x8CBE94", VA = "0x8CBE94", Slot = "6")]
	public override System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, float timeout)
	{
		return null;
	}

	[Token(Token = "0x6000265")]
	[Address(RVA = "0x8CBEDC", Offset = "0x8CBEDC", VA = "0x8CBEDC", Slot = "7")]
	public override ValueTask WriteAsync(byte[] data)
	{
		return default(ValueTask);
	}
}
[Token(Token = "0x20000A7")]
public class BaseResponse<T>
{
	[Token(Token = "0x1700004D")]
	public int Code
	{
		[Token(Token = "0x6000266")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000267")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700004E")]
	public string ErrMsg
	{
		[Token(Token = "0x6000268")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000269")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700004F")]
	public T Data
	{
		[Token(Token = "0x600026A")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Token(Token = "0x600026B")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x600026C")]
	public BaseResponse()
	{
	}
}
[Token(Token = "0x20000A8")]
public class BaseResponse : BaseResponse<VoidData>
{
	[Token(Token = "0x600026D")]
	[Address(RVA = "0x8CBF6C", Offset = "0x8CBF6C", VA = "0x8CBF6C")]
	public BaseResponse()
	{
	}
}
[Token(Token = "0x20000A9")]
public class VoidData
{
	[Token(Token = "0x600026E")]
	[Address(RVA = "0x8CBFB4", Offset = "0x8CBFB4", VA = "0x8CBFB4")]
	public VoidData()
	{
	}
}
[Token(Token = "0x20000AA")]
public class TransformSync : MonoBehaviour
{
	[Token(Token = "0x20000AB")]
	public class TransformCache
	{
		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private TransformData lastTransform;

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TransformData[] buffer;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool unchanged;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int head;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int tail;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private int bufSize;

		[Token(Token = "0x17000052")]
		public bool IsEmpty
		{
			[Token(Token = "0x6000281")]
			[Address(RVA = "0x8CDD04", Offset = "0x8CDD04", VA = "0x8CDD04")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000053")]
		public int Count
		{
			[Token(Token = "0x6000282")]
			[Address(RVA = "0x8CD030", Offset = "0x8CD030", VA = "0x8CD030")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000054")]
		public string Name
		{
			[Token(Token = "0x6000283")]
			[Address(RVA = "0x8CDD14", Offset = "0x8CDD14", VA = "0x8CDD14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000284")]
			[Address(RVA = "0x8CDD1C", Offset = "0x8CDD1C", VA = "0x8CDD1C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x8CC484", Offset = "0x8CC484", VA = "0x8CC484")]
		public TransformCache(string name, int size)
		{
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x8CDD94", Offset = "0x8CDD94", VA = "0x8CDD94")]
		public byte[] ToBytes()
		{
			return null;
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x8CE614", Offset = "0x8CE614", VA = "0x8CE614")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x8CC360", Offset = "0x8CC360", VA = "0x8CC360")]
		public void ResetSize(int size)
		{
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x8CDD24", Offset = "0x8CDD24", VA = "0x8CDD24")]
		private void Init(int size)
		{
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x8CE6C4", Offset = "0x8CE6C4", VA = "0x8CE6C4")]
		public void Put(Transform transform)
		{
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x8CD1C0", Offset = "0x8CD1C0", VA = "0x8CD1C0")]
		public void Put(TransformData data)
		{
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x8CD04C", Offset = "0x8CD04C", VA = "0x8CD04C")]
		public TransformData Pop()
		{
			return null;
		}
	}

	[Token(Token = "0x20000AC")]
	public class TransformData
	{
		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static TransformData UnChanged;

		[Token(Token = "0x17000055")]
		public Vector3 Position
		{
			[Token(Token = "0x600028D")]
			[Address(RVA = "0x8CE8D4", Offset = "0x8CE8D4", VA = "0x8CE8D4")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600028E")]
			[Address(RVA = "0x8CE8E0", Offset = "0x8CE8E0", VA = "0x8CE8E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000056")]
		public Quaternion Rotation
		{
			[Token(Token = "0x600028F")]
			[Address(RVA = "0x8CE8EC", Offset = "0x8CE8EC", VA = "0x8CE8EC")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x6000290")]
			[Address(RVA = "0x8CE8F8", Offset = "0x8CE8F8", VA = "0x8CE8F8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000057")]
		public float Time
		{
			[Token(Token = "0x6000291")]
			[Address(RVA = "0x8CE904", Offset = "0x8CE904", VA = "0x8CE904")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000292")]
			[Address(RVA = "0x8CE90C", Offset = "0x8CE90C", VA = "0x8CE90C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x8CE914", Offset = "0x8CE914", VA = "0x8CE914")]
		private TransformData()
		{
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x8CD158", Offset = "0x8CD158", VA = "0x8CD158")]
		public TransformData(float time, Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x8CE874", Offset = "0x8CE874", VA = "0x8CE874")]
		public TransformData(Transform transform)
		{
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x8CE1D4", Offset = "0x8CE1D4", VA = "0x8CE1D4")]
		public byte[] ToBytes()
		{
			return null;
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x8CE7B0", Offset = "0x8CE7B0", VA = "0x8CE7B0")]
		public static bool operator ==(TransformData a, Transform b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x8CCF6C", Offset = "0x8CCF6C", VA = "0x8CCF6C")]
		public static bool operator !=(TransformData a, Transform b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x8CE91C", Offset = "0x8CE91C", VA = "0x8CE91C", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x8CEA48", Offset = "0x8CEA48", VA = "0x8CEA48", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private struct <SyncSend>d__22 : IAsyncStateMachine
	{
		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TransformCache cache;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform transform;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public CancellationToken cancellation;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TaskAwaiter<VoidData> <>u__1;

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x8CEC7C", Offset = "0x8CEC7C", VA = "0x8CEC7C", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x8CF170", Offset = "0x8CF170", VA = "0x8CF170", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private struct <SyncReceive>d__25 : IAsyncStateMachine
	{
		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TransformCache cache;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform transform;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public CancellationToken cancellation;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool <unChanged>5__2;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TransformData <lastData>5__3;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool <needPop>5__4;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private TransformData <data>5__5;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private TaskAwaiter<VoidData> <>u__1;

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x8CF17C", Offset = "0x8CF17C", VA = "0x8CF17C", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x8CF9C8", Offset = "0x8CF9C8", VA = "0x8CF9C8", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x40002C3")]
	private const byte TYPE_FLAG = 1;

	[Token(Token = "0x40002C4")]
	private const int MAX_DELAY_FRAMES = 300;

	[Token(Token = "0x40002C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static List<TransformCache> sendCacheList;

	[Token(Token = "0x40002C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Dictionary<string, TransformCache> receiveCacheList;

	[Token(Token = "0x40002C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static int cacheSize;

	[Token(Token = "0x40002C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Func<bool> preSendFinish;

	[Token(Token = "0x40002C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float lastSendTime;

	[Token(Token = "0x40002CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private static float miniFluctuate;

	[Token(Token = "0x40002CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static float maxFluctuate;

	[Token(Token = "0x40002CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private static float delayThreshold;

	[Token(Token = "0x40002CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static float currentTime;

	[Token(Token = "0x17000050")]
	public static float DeltaTime
	{
		[Token(Token = "0x600026F")]
		[Address(RVA = "0x8CBFBC", Offset = "0x8CBFBC", VA = "0x8CBFBC")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000270")]
		[Address(RVA = "0x8CC014", Offset = "0x8CC014", VA = "0x8CC014")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000051")]
	public static int CacheSize
	{
		[Token(Token = "0x6000272")]
		[Address(RVA = "0x8CC18C", Offset = "0x8CC18C", VA = "0x8CC18C")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000273")]
		[Address(RVA = "0x8CC1E4", Offset = "0x8CC1E4", VA = "0x8CC1E4")]
		set
		{
		}
	}

	[Token(Token = "0x6000271")]
	[Address(RVA = "0x8CC078", Offset = "0x8CC078", VA = "0x8CC078")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000274")]
	[Address(RVA = "0x8CC364", Offset = "0x8CC364", VA = "0x8CC364")]
	public static TransformCache CreateSend(string name)
	{
		return null;
	}

	[Token(Token = "0x6000275")]
	[Address(RVA = "0x8CC53C", Offset = "0x8CC53C", VA = "0x8CC53C")]
	public static TransformCache RegisterReceive(string name)
	{
		return null;
	}

	[Token(Token = "0x6000276")]
	[Address(RVA = "0x8CC60C", Offset = "0x8CC60C", VA = "0x8CC60C")]
	public static void SyncSend(Transform transform, TransformCache cache)
	{
	}

	[Token(Token = "0x6000277")]
	[Address(RVA = "0x8CC6A8", Offset = "0x8CC6A8", VA = "0x8CC6A8")]
	[AsyncStateMachine(typeof(<SyncSend>d__22))]
	public static void SyncSend(Transform transform, TransformCache cache, CancellationToken cancellation)
	{
	}

	[Token(Token = "0x6000278")]
	[Address(RVA = "0x8CC794", Offset = "0x8CC794", VA = "0x8CC794")]
	public static void SyncReceive(Transform transform, TransformCache cache)
	{
	}

	[Token(Token = "0x6000279")]
	[Address(RVA = "0x8CC920", Offset = "0x8CC920", VA = "0x8CC920")]
	private static bool SyncTransform(Transform transform, TransformCache cache, TransformData data, ref bool unChanged, ref TransformData lastData, bool isThreshold = false)
	{
		return default(bool);
	}

	[Token(Token = "0x600027A")]
	[Address(RVA = "0x8CC830", Offset = "0x8CC830", VA = "0x8CC830")]
	[AsyncStateMachine(typeof(<SyncReceive>d__25))]
	public static void SyncReceive(Transform transform, TransformCache cache, CancellationToken cancellation)
	{
	}

	[Token(Token = "0x600027B")]
	[Address(RVA = "0x8C9514", Offset = "0x8C9514", VA = "0x8C9514")]
	public static bool Parse(RingBuff rBuff)
	{
		return default(bool);
	}

	[Token(Token = "0x600027C")]
	[Address(RVA = "0x8CD2E4", Offset = "0x8CD2E4", VA = "0x8CD2E4")]
	private void Start()
	{
	}

	[Token(Token = "0x600027D")]
	[Address(RVA = "0x8CD2E8", Offset = "0x8CD2E8", VA = "0x8CD2E8")]
	private void Update()
	{
	}

	[Token(Token = "0x600027E")]
	[Address(RVA = "0x8CD2EC", Offset = "0x8CD2EC", VA = "0x8CD2EC")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600027F")]
	[Address(RVA = "0x8CDBE8", Offset = "0x8CDBE8", VA = "0x8CDBE8")]
	public TransformSync()
	{
	}
}
[Token(Token = "0x20000B1")]
[RequireComponent(typeof(AudioSource))]
public class VoiceSync : MonoBehaviour
{
	[Token(Token = "0x20000B2")]
	public class VoiceCache
	{
		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private float[][] buffer;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int head;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private int tail;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int bufSize;

		[Token(Token = "0x17000058")]
		public bool IsEmpty
		{
			[Token(Token = "0x60002B3")]
			[Address(RVA = "0x8D05C8", Offset = "0x8D05C8", VA = "0x8D05C8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000059")]
		public int Count
		{
			[Token(Token = "0x60002B4")]
			[Address(RVA = "0x8D05D8", Offset = "0x8D05D8", VA = "0x8D05D8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x8CFC00", Offset = "0x8CFC00", VA = "0x8CFC00")]
		public VoiceCache(int size)
		{
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x8D0E10", Offset = "0x8D0E10", VA = "0x8D0E10")]
		private float MaxVol(float[] buff)
		{
			return default(float);
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x8D0700", Offset = "0x8D0700", VA = "0x8D0700")]
		public byte[] ToBytes()
		{
			return null;
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x8D0C90", Offset = "0x8D0C90", VA = "0x8D0C90")]
		public void Clear()
		{
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x8D0F18", Offset = "0x8D0F18", VA = "0x8D0F18")]
		public void ResetSize(int size)
		{
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x8D0DA0", Offset = "0x8D0DA0", VA = "0x8D0DA0")]
		private void Init(int size)
		{
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x8CFF90", Offset = "0x8CFF90", VA = "0x8CFF90")]
		public void Put(float[] data)
		{
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x8D05F4", Offset = "0x8D05F4", VA = "0x8D05F4")]
		public float[] Pop()
		{
			return null;
		}
	}

	[Token(Token = "0x40002F0")]
	private const int MAX_DELAY_FRAMES = 200;

	[Token(Token = "0x40002F1")]
	private const byte TYPE_FLAG = 3;

	[Token(Token = "0x40002F2")]
	private const int SAMPLE_RATE = 8000;

	[Token(Token = "0x40002F3")]
	private const int SAMPLE_LEN = 10;

	[Token(Token = "0x40002F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private AudioSource audioSource;

	[Token(Token = "0x40002F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private AudioClip recordAudioClip;

	[Token(Token = "0x40002F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private AudioClip audioClip;

	[Token(Token = "0x40002F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int lastPos;

	[Token(Token = "0x40002F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private int lastReceivePos;

	[Token(Token = "0x40002F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int lastPlayPos;

	[Token(Token = "0x40002FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private bool isEmpty;

	[Token(Token = "0x40002FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
	private bool isRecording;

	[Token(Token = "0x40002FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static VoiceCache sendCache;

	[Token(Token = "0x40002FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static VoiceCache receiveCache;

	[Token(Token = "0x40002FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private float[] currentBuff;

	[Token(Token = "0x40002FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static float miniFluctuate;

	[Token(Token = "0x4000300")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private static float maxFluctuate;

	[Token(Token = "0x4000301")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static float delayThreshold;

	[Token(Token = "0x4000302")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Func<bool> preSendFinish;

	[Token(Token = "0x60002A8")]
	[Address(RVA = "0x8CFA58", Offset = "0x8CFA58", VA = "0x8CFA58")]
	private void Start()
	{
	}

	[Token(Token = "0x60002A9")]
	[Address(RVA = "0x8CFC2C", Offset = "0x8CFC2C", VA = "0x8CFC2C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60002AA")]
	[Address(RVA = "0x8CFC98", Offset = "0x8CFC98", VA = "0x8CFC98")]
	private void CheckEmpty()
	{
	}

	[Token(Token = "0x60002AB")]
	[Address(RVA = "0x8CFCFC", Offset = "0x8CFCFC", VA = "0x8CFCFC")]
	private void ClearData()
	{
	}

	[Token(Token = "0x60002AC")]
	[Address(RVA = "0x8CFD68", Offset = "0x8CFD68", VA = "0x8CFD68")]
	private bool CheckFull()
	{
		return default(bool);
	}

	[Token(Token = "0x60002AD")]
	[Address(RVA = "0x8CFE04", Offset = "0x8CFE04", VA = "0x8CFE04")]
	private void FillData()
	{
	}

	[Token(Token = "0x60002AE")]
	[Address(RVA = "0x8CFE78", Offset = "0x8CFE78", VA = "0x8CFE78")]
	private void Record()
	{
	}

	[Token(Token = "0x60002AF")]
	[Address(RVA = "0x8D00B4", Offset = "0x8D00B4", VA = "0x8D00B4")]
	private void Update()
	{
	}

	[Token(Token = "0x60002B0")]
	[Address(RVA = "0x8C9B24", Offset = "0x8C9B24", VA = "0x8C9B24")]
	public static bool Parse(RingBuff rBuff)
	{
		return default(bool);
	}

	[Token(Token = "0x60002B1")]
	[Address(RVA = "0x8D0D40", Offset = "0x8D0D40", VA = "0x8D0D40")]
	public VoiceSync()
	{
	}
}
[Token(Token = "0x20000B4")]
public abstract class AbstractProcessor<T> where T : WSBasePojo
{
	[Token(Token = "0x4000309")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static JsonSerializerSettings setting;

	[Token(Token = "0x1700005A")]
	protected abstract string _type
	{
		[Token(Token = "0x60002C1")]
		get;
	}

	[Token(Token = "0x60002C0")]
	public string Process(string json)
	{
		return null;
	}

	[Token(Token = "0x60002C2")]
	protected abstract WSBasePojo Process(T req);

	[Token(Token = "0x60002C3")]
	protected AbstractProcessor()
	{
	}
}
[Token(Token = "0x20000B5")]
public abstract class BaseCallbackProcessor<T, R> : AbstractProcessor<T> where T : WSBaseRequest where R : WSBaseResponse, new()
{
	[Token(Token = "0x60002C5")]
	protected override WSBasePojo Process(T req)
	{
		return null;
	}

	[Token(Token = "0x60002C6")]
	protected abstract void Process(T req, Action<R> res);

	[Token(Token = "0x60002C7")]
	protected BaseCallbackProcessor()
	{
	}
}
[Token(Token = "0x20000B7")]
public abstract class BaseEventProcessor<T, R> : BaseProcessor<T, R> where T : WSBaseRequest, BusEvent where R : WSBaseResponse, new()
{
	[Token(Token = "0x60002CA")]
	protected override bool Process(T req, R res)
	{
		return default(bool);
	}

	[Token(Token = "0x60002CB")]
	protected BaseEventProcessor()
	{
	}
}
[Token(Token = "0x20000B8")]
public abstract class BaseProcessor<T, R> : AbstractProcessor<T> where T : WSBaseRequest where R : WSBaseResponse, new()
{
	[Token(Token = "0x60002CC")]
	protected override WSBasePojo Process(T req)
	{
		return null;
	}

	[Token(Token = "0x60002CD")]
	protected abstract bool Process(T req, R res);

	[Token(Token = "0x60002CE")]
	protected BaseProcessor()
	{
	}
}
[Token(Token = "0x20000B9")]
public abstract class BaseWorker<T> : AbstractProcessor<T> where T : WSBaseResponse
{
	[Token(Token = "0x400030C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private TaskCompletionSource<T> task;

	[Token(Token = "0x60002CF")]
	protected override WSBasePojo Process(T res)
	{
		return null;
	}

	[Token(Token = "0x60002D0")]
	protected System.Threading.Tasks.Task<T> Send<U>(U request) where U : WSBaseRequest
	{
		return null;
	}

	[Token(Token = "0x60002D1")]
	protected BaseWorker()
	{
	}
}
[Token(Token = "0x20000BA")]
public class WebClient
{
	[Token(Token = "0x20000BB")]
	public delegate void DisconnectDelegate();

	[StructLayout(3)]
	[Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private struct <ConnectAsync>d__9 : IAsyncStateMachine
	{
		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public WebClient <>4__this;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string url;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TaskAwaiter <>u__1;

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x8D1800", Offset = "0x8D1800", VA = "0x8D1800", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x8D1B7C", Offset = "0x8D1B7C", VA = "0x8D1B7C", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x20000BD")]
	[CompilerGenerated]
	private struct <DoReceiveAsync>d__11 : IAsyncStateMachine
	{
		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public WebClient <>4__this;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int <>7__wrap1;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ArraySegment<byte> <buffer>5__3;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TaskAwaiter<VoidData> <>u__1;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private MemoryStream <ms>5__4;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private TaskAwaiter<WebSocketReceiveResult> <>u__2;

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x8D1B88", Offset = "0x8D1B88", VA = "0x8D1B88", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x8D26A0", Offset = "0x8D26A0", VA = "0x8D26A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x400030D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private ClientWebSocket webSocket;

	[Token(Token = "0x400030E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private CancellationTokenSource runningCancellationToken;

	[Token(Token = "0x400030F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private List<Func<string, string>> processorList;

	[Token(Token = "0x4000311")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static JsonSerializerSettings setting;

	[Token(Token = "0x1700005B")]
	public DisconnectDelegate OnDisconnect
	{
		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x8D0F9C", Offset = "0x8D0F9C", VA = "0x8D0F9C")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x8D0FA4", Offset = "0x8D0FA4", VA = "0x8D0FA4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x60002D4")]
	[Address(RVA = "0x8D0FAC", Offset = "0x8D0FAC", VA = "0x8D0FAC")]
	[AsyncStateMachine(typeof(<ConnectAsync>d__9))]
	public System.Threading.Tasks.Task ConnectAsync(string url)
	{
		return null;
	}

	[Token(Token = "0x60002D5")]
	[Address(RVA = "0x8D10B0", Offset = "0x8D10B0", VA = "0x8D10B0")]
	public void Close()
	{
	}

	[Token(Token = "0x60002D6")]
	[Address(RVA = "0x8D11D4", Offset = "0x8D11D4", VA = "0x8D11D4")]
	[AsyncStateMachine(typeof(<DoReceiveAsync>d__11))]
	private System.Threading.Tasks.Task DoReceiveAsync()
	{
		return null;
	}

	[Token(Token = "0x60002D7")]
	public void RegisteProcessor<T>(AbstractProcessor<T> processor) where T : WSBasePojo
	{
	}

	[Token(Token = "0x60002D8")]
	[Address(RVA = "0x8D12C8", Offset = "0x8D12C8", VA = "0x8D12C8")]
	public void RegisteProcessor(Func<string, string> processor)
	{
	}

	[Token(Token = "0x60002D9")]
	public void RemoveProcessor<T>(AbstractProcessor<T> processor) where T : WSBasePojo
	{
	}

	[Token(Token = "0x60002DA")]
	[Address(RVA = "0x8D1378", Offset = "0x8D1378", VA = "0x8D1378")]
	public void ClearProcessor()
	{
	}

	[Token(Token = "0x60002DB")]
	[Address(RVA = "0x8D13E8", Offset = "0x8D13E8", VA = "0x8D13E8")]
	public void SendAsync(string msg)
	{
	}

	[Token(Token = "0x60002DC")]
	[Address(RVA = "0x8D14C8", Offset = "0x8D14C8", VA = "0x8D14C8")]
	public void Send(object msg)
	{
	}

	[Token(Token = "0x60002DD")]
	[Address(RVA = "0x8D1570", Offset = "0x8D1570", VA = "0x8D1570")]
	public WebClient()
	{
	}
}
[Token(Token = "0x20000BE")]
public abstract class WSBasePojo
{
	[Token(Token = "0x1700005C")]
	public string _type
	{
		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x8D26AC", Offset = "0x8D26AC", VA = "0x8D26AC")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x8D26B4", Offset = "0x8D26B4", VA = "0x8D26B4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700005D")]
	public string _requestId
	{
		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x8D26BC", Offset = "0x8D26BC", VA = "0x8D26BC")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x8D26C4", Offset = "0x8D26C4", VA = "0x8D26C4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x60002EC")]
	[Address(RVA = "0x8D26CC", Offset = "0x8D26CC", VA = "0x8D26CC")]
	protected WSBasePojo()
	{
	}
}
[Token(Token = "0x20000BF")]
public class WSBaseRequest : WSBasePojo
{
	[Token(Token = "0x60002ED")]
	[Address(RVA = "0x8D26D4", Offset = "0x8D26D4", VA = "0x8D26D4")]
	public WSBaseRequest()
	{
	}
}
[Token(Token = "0x20000C0")]
public class WSBaseResponse : WSBasePojo
{
	[Token(Token = "0x1700005E")]
	public int Code
	{
		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x8D26DC", Offset = "0x8D26DC", VA = "0x8D26DC")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x8D26E4", Offset = "0x8D26E4", VA = "0x8D26E4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x60002F0")]
	[Address(RVA = "0x8D26EC", Offset = "0x8D26EC", VA = "0x8D26EC")]
	public WSBaseResponse()
	{
	}
}
[Token(Token = "0x20000C1")]
internal class HeartbeatWorker : BaseWorker<WSBaseResponse>
{
	[Token(Token = "0x1700005F")]
	protected override string _type
	{
		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x8D2770", Offset = "0x8D2770", VA = "0x8D2770", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60002F1")]
	[Address(RVA = "0x8D26F4", Offset = "0x8D26F4", VA = "0x8D26F4")]
	public void Heartbeat()
	{
	}

	[Token(Token = "0x60002F3")]
	[Address(RVA = "0x8D27B0", Offset = "0x8D27B0", VA = "0x8D27B0")]
	public HeartbeatWorker()
	{
	}
}
[Token(Token = "0x20000C2")]
public class LoginWorker : BaseWorker<LoginResponse>
{
	[Token(Token = "0x4000322")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static string token;

	[Token(Token = "0x17000060")]
	protected override string _type
	{
		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x8D27F8", Offset = "0x8D27F8", VA = "0x8D27F8", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60002F5")]
	[Address(RVA = "0x8D2838", Offset = "0x8D2838", VA = "0x8D2838")]
	public System.Threading.Tasks.Task<LoginResponse> Login(string token)
	{
		return null;
	}

	[Token(Token = "0x60002F6")]
	[Address(RVA = "0x8D28A4", Offset = "0x8D28A4", VA = "0x8D28A4")]
	public System.Threading.Tasks.Task<LoginResponse> Login()
	{
		return null;
	}

	[Token(Token = "0x60002F7")]
	[Address(RVA = "0x8D295C", Offset = "0x8D295C", VA = "0x8D295C")]
	public LoginWorker()
	{
	}
}
[Token(Token = "0x20000C3")]
public class LoginRequest : WSBaseRequest
{
	[Token(Token = "0x17000061")]
	public string Token
	{
		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x8D29A4", Offset = "0x8D29A4", VA = "0x8D29A4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x8D29AC", Offset = "0x8D29AC", VA = "0x8D29AC")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x60002FA")]
	[Address(RVA = "0x8D2954", Offset = "0x8D2954", VA = "0x8D2954")]
	public LoginRequest()
	{
	}
}
[Token(Token = "0x20000C4")]
public class LoginResponse : WSBaseResponse
{
	[Token(Token = "0x60002FB")]
	[Address(RVA = "0x8D29B4", Offset = "0x8D29B4", VA = "0x8D29B4")]
	public LoginResponse()
	{
	}
}
[Token(Token = "0x20000C5")]
public class RandomMathResponse : WSBaseResponse
{
	[Token(Token = "0x17000062")]
	public string Token
	{
		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x8D29BC", Offset = "0x8D29BC", VA = "0x8D29BC")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x8D29C4", Offset = "0x8D29C4", VA = "0x8D29C4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000063")]
	public bool Host
	{
		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x8D29CC", Offset = "0x8D29CC", VA = "0x8D29CC")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x8D29D4", Offset = "0x8D29D4", VA = "0x8D29D4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x6000300")]
	[Address(RVA = "0x8D29E0", Offset = "0x8D29E0", VA = "0x8D29E0")]
	public RandomMathResponse()
	{
	}
}
[Token(Token = "0x20000C6")]
public class ReconnectResponse : WSBaseResponse
{
	[Token(Token = "0x17000064")]
	public string Token
	{
		[Token(Token = "0x6000301")]
		[Address(RVA = "0x8D29E8", Offset = "0x8D29E8", VA = "0x8D29E8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000302")]
		[Address(RVA = "0x8D29F0", Offset = "0x8D29F0", VA = "0x8D29F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x6000303")]
	[Address(RVA = "0x8D29F8", Offset = "0x8D29F8", VA = "0x8D29F8")]
	public ReconnectResponse()
	{
	}
}
[Token(Token = "0x20000C7")]
public class RoomJoinRequest : WSBaseRequest, BusEvent
{
	[Token(Token = "0x6000304")]
	[Address(RVA = "0x8D2A00", Offset = "0x8D2A00", VA = "0x8D2A00")]
	public RoomJoinRequest()
	{
	}
}
[Token(Token = "0x20000C8")]
public class RandomMathWorker : BaseWorker<RandomMathResponse>
{
	[Token(Token = "0x17000065")]
	protected override string _type
	{
		[Token(Token = "0x6000305")]
		[Address(RVA = "0x8D2A08", Offset = "0x8D2A08", VA = "0x8D2A08", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000306")]
	[Address(RVA = "0x8C80C8", Offset = "0x8C80C8", VA = "0x8C80C8")]
	public System.Threading.Tasks.Task<RandomMathResponse> Match()
	{
		return null;
	}

	[Token(Token = "0x6000307")]
	[Address(RVA = "0x8C8080", Offset = "0x8C8080", VA = "0x8C8080")]
	public RandomMathWorker()
	{
	}
}
[Token(Token = "0x20000C9")]
public class ReconnectWorker : BaseWorker<ReconnectResponse>
{
	[Token(Token = "0x17000066")]
	protected override string _type
	{
		[Token(Token = "0x6000308")]
		[Address(RVA = "0x8D2A48", Offset = "0x8D2A48", VA = "0x8D2A48", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000309")]
	[Address(RVA = "0x8CAFD0", Offset = "0x8CAFD0", VA = "0x8CAFD0")]
	public System.Threading.Tasks.Task<ReconnectResponse> Connect()
	{
		return null;
	}

	[Token(Token = "0x600030A")]
	[Address(RVA = "0x8CAF88", Offset = "0x8CAF88", VA = "0x8CAF88")]
	public ReconnectWorker()
	{
	}
}
[Token(Token = "0x20000CA")]
public class RoomJoinProcessor : BaseEventProcessor<RoomJoinRequest, WSBaseResponse>
{
	[Token(Token = "0x17000067")]
	protected override string _type
	{
		[Token(Token = "0x600030B")]
		[Address(RVA = "0x8D2A88", Offset = "0x8D2A88", VA = "0x8D2A88", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600030C")]
	[Address(RVA = "0x8D2AC8", Offset = "0x8D2AC8", VA = "0x8D2AC8")]
	public RoomJoinProcessor()
	{
	}
}
[Token(Token = "0x20000CB")]
public class WebSocket
{
	[StructLayout(3)]
	[Token(Token = "0x20000CF")]
	[CompilerGenerated]
	private struct <Start>d__3 : IAsyncStateMachine
	{
		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder<LoginResponse> <>t__builder;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string token;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TaskAwaiter <>u__1;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TaskAwaiter<LoginResponse> <>u__2;

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x8D35C8", Offset = "0x8D35C8", VA = "0x8D35C8", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x8D3BB8", Offset = "0x8D3BB8", VA = "0x8D3BB8", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x20000D0")]
	[CompilerGenerated]
	private struct <StartHeartbeat>d__4 : IAsyncStateMachine
	{
		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TaskAwaiter<VoidData> <>u__1;

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x8D3C10", Offset = "0x8D3C10", VA = "0x8D3C10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x8D3F2C", Offset = "0x8D3F2C", VA = "0x8D3F2C", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x4000327")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static WebClient webClient;

	[Token(Token = "0x4000328")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static bool runFlag;

	[Token(Token = "0x600030D")]
	[Address(RVA = "0x8D2B10", Offset = "0x8D2B10", VA = "0x8D2B10")]
	static WebSocket()
	{
	}

	[Token(Token = "0x600030E")]
	[Address(RVA = "0x8C60C4", Offset = "0x8C60C4", VA = "0x8C60C4")]
	[AsyncStateMachine(typeof(<Start>d__3))]
	public static System.Threading.Tasks.Task<LoginResponse> Start(string token)
	{
		return null;
	}

	[Token(Token = "0x600030F")]
	[Address(RVA = "0x8D2C60", Offset = "0x8D2C60", VA = "0x8D2C60")]
	[AsyncStateMachine(typeof(<StartHeartbeat>d__4))]
	private static System.Threading.Tasks.Task StartHeartbeat()
	{
		return null;
	}

	[Token(Token = "0x6000310")]
	[Address(RVA = "0x8C779C", Offset = "0x8C779C", VA = "0x8C779C")]
	public static void Close()
	{
	}

	[Token(Token = "0x6000311")]
	public static void RegisteProcessor<T>(AbstractProcessor<T> processor) where T : WSBasePojo
	{
	}

	[Token(Token = "0x6000312")]
	public static void RemoveProcessor<T>(AbstractProcessor<T> processor) where T : WSBasePojo
	{
	}

	[Token(Token = "0x6000313")]
	[Address(RVA = "0x8D2D30", Offset = "0x8D2D30", VA = "0x8D2D30")]
	public static void Send(string msg)
	{
	}

	[Token(Token = "0x6000314")]
	[Address(RVA = "0x8D2D98", Offset = "0x8D2D98", VA = "0x8D2D98")]
	public static void Send(object msg)
	{
	}

	[Token(Token = "0x6000315")]
	[Address(RVA = "0x8D2E00", Offset = "0x8D2E00", VA = "0x8D2E00")]
	public WebSocket()
	{
	}
}
[Token(Token = "0x20000D1")]
public class Activation : MonoBehaviour
{
	[Token(Token = "0x4000339")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool isShow;

	[Token(Token = "0x400033A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private int number;

	[Token(Token = "0x400033B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int unitLength;

	[Token(Token = "0x6000321")]
	[Address(RVA = "0x8D3F38", Offset = "0x8D3F38", VA = "0x8D3F38")]
	private void Start()
	{
	}

	[Token(Token = "0x6000322")]
	[Address(RVA = "0x8D3FC0", Offset = "0x8D3FC0", VA = "0x8D3FC0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000323")]
	[Address(RVA = "0x8D3F3C", Offset = "0x8D3F3C", VA = "0x8D3F3C")]
	public void Hide()
	{
	}

	[Token(Token = "0x6000324")]
	[Address(RVA = "0x8D42EC", Offset = "0x8D42EC", VA = "0x8D42EC")]
	public void HideTip()
	{
	}

	[Token(Token = "0x6000325")]
	[Address(RVA = "0x8D432C", Offset = "0x8D432C", VA = "0x8D432C")]
	public void Show()
	{
	}

	[Token(Token = "0x6000326")]
	[Address(RVA = "0x8D43BC", Offset = "0x8D43BC", VA = "0x8D43BC")]
	public Activation()
	{
	}
}
[Token(Token = "0x20000D2")]
public class AIModel : MonoBehaviour
{
	[Token(Token = "0x400033C")]
	private const float MOVE_SPEED = 10f;

	[Token(Token = "0x400033D")]
	private const float ROTATE_SPEED = 720f;

	[Token(Token = "0x400033E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static float DELTA_POS;

	[Token(Token = "0x400033F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Action onHitAction;

	[Token(Token = "0x4000340")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Action onMoveEndAction;

	[Token(Token = "0x4000341")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Action rotateEndAction;

	[Token(Token = "0x4000342")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Vector3 moveTarget;

	[Token(Token = "0x4000343")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private Vector3 targetPoint;

	[Token(Token = "0x4000344")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Quaternion faceRotate;

	[Token(Token = "0x4000345")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Quaternion moveRotate;

	[Token(Token = "0x4000346")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private bool isMoving;

	[Token(Token = "0x4000347")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
	private bool isRotating;

	[Token(Token = "0x6000327")]
	[Address(RVA = "0x8D43CC", Offset = "0x8D43CC", VA = "0x8D43CC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000328")]
	[Address(RVA = "0x8D4524", Offset = "0x8D4524", VA = "0x8D4524")]
	private void Update()
	{
	}

	[Token(Token = "0x6000329")]
	[Address(RVA = "0x8D49AC", Offset = "0x8D49AC", VA = "0x8D49AC")]
	private void OnIdel0End()
	{
	}

	[Token(Token = "0x600032A")]
	[Address(RVA = "0x8D4A38", Offset = "0x8D4A38", VA = "0x8D4A38")]
	private void Hit()
	{
	}

	[Token(Token = "0x600032B")]
	[Address(RVA = "0x8D4860", Offset = "0x8D4860", VA = "0x8D4860")]
	private void ChangeRotate(Quaternion rotate)
	{
	}

	[Token(Token = "0x600032C")]
	[Address(RVA = "0x8D4A6C", Offset = "0x8D4A6C", VA = "0x8D4A6C")]
	public void MoveTo(Vector3 point, Vector3 face, [Optional] Action onMoveEndAction)
	{
	}

	[Token(Token = "0x600032D")]
	[Address(RVA = "0x8D4DA4", Offset = "0x8D4DA4", VA = "0x8D4DA4")]
	public void Hit(Action onHitAction)
	{
	}

	[Token(Token = "0x600032E")]
	[Address(RVA = "0x8D4E30", Offset = "0x8D4E30", VA = "0x8D4E30")]
	public AIModel()
	{
	}
}
[Token(Token = "0x20000D3")]
public class Ball : MonoBehaviour
{
	[Token(Token = "0x4000354")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private TimedCache<Ball> bounceList;

	[Token(Token = "0x17000068")]
	public Pocket Pocket
	{
		[Token(Token = "0x6000332")]
		[Address(RVA = "0x8D4EE8", Offset = "0x8D4EE8", VA = "0x8D4EE8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000333")]
		[Address(RVA = "0x8D4EF0", Offset = "0x8D4EF0", VA = "0x8D4EF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000069")]
	public bool IsActive
	{
		[Token(Token = "0x6000334")]
		[Address(RVA = "0x8D4EF8", Offset = "0x8D4EF8", VA = "0x8D4EF8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000335")]
		[Address(RVA = "0x8D4F00", Offset = "0x8D4F00", VA = "0x8D4F00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700006A")]
	public Vector3 Position
	{
		[Token(Token = "0x6000336")]
		[Address(RVA = "0x8D4F0C", Offset = "0x8D4F0C", VA = "0x8D4F0C")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000337")]
		[Address(RVA = "0x8D4F18", Offset = "0x8D4F18", VA = "0x8D4F18")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700006B")]
	public Vector3 Velocity
	{
		[Token(Token = "0x6000338")]
		[Address(RVA = "0x8D4F24", Offset = "0x8D4F24", VA = "0x8D4F24")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000339")]
		[Address(RVA = "0x8D4F30", Offset = "0x8D4F30", VA = "0x8D4F30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700006C")]
	public Vector3 LastVelocity
	{
		[Token(Token = "0x600033A")]
		[Address(RVA = "0x8D4F3C", Offset = "0x8D4F3C", VA = "0x8D4F3C")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x600033B")]
		[Address(RVA = "0x8D4F48", Offset = "0x8D4F48", VA = "0x8D4F48")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700006D")]
	public bool IsHitBorder
	{
		[Token(Token = "0x600033C")]
		[Address(RVA = "0x8D4F54", Offset = "0x8D4F54", VA = "0x8D4F54")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600033D")]
		[Address(RVA = "0x8D4F5C", Offset = "0x8D4F5C", VA = "0x8D4F5C")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700006E")]
	public Ball FirstHitBall
	{
		[Token(Token = "0x600033E")]
		[Address(RVA = "0x8D4F68", Offset = "0x8D4F68", VA = "0x8D4F68")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600033F")]
		[Address(RVA = "0x8D4F70", Offset = "0x8D4F70", VA = "0x8D4F70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700006F")]
	public bool IsOutOfBound
	{
		[Token(Token = "0x6000340")]
		[Address(RVA = "0x8D4F78", Offset = "0x8D4F78", VA = "0x8D4F78")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000341")]
		[Address(RVA = "0x8D4F80", Offset = "0x8D4F80", VA = "0x8D4F80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000070")]
	public bool IsOutOfBoundThisHit
	{
		[Token(Token = "0x6000342")]
		[Address(RVA = "0x8D4F8C", Offset = "0x8D4F8C", VA = "0x8D4F8C")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000343")]
		[Address(RVA = "0x8D4F94", Offset = "0x8D4F94", VA = "0x8D4F94")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000071")]
	public Action FallInPocketAction
	{
		[Token(Token = "0x6000344")]
		[Address(RVA = "0x8D4FA0", Offset = "0x8D4FA0", VA = "0x8D4FA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000345")]
		[Address(RVA = "0x8D4FA8", Offset = "0x8D4FA8", VA = "0x8D4FA8")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000072")]
	public Action ResetPocketAction
	{
		[Token(Token = "0x6000346")]
		[Address(RVA = "0x8D4FB0", Offset = "0x8D4FB0", VA = "0x8D4FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000347")]
		[Address(RVA = "0x8D4FB8", Offset = "0x8D4FB8", VA = "0x8D4FB8")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000073")]
	public Action OutOfBoundsAction
	{
		[Token(Token = "0x6000348")]
		[Address(RVA = "0x8D4FC0", Offset = "0x8D4FC0", VA = "0x8D4FC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000349")]
		[Address(RVA = "0x8D4FC8", Offset = "0x8D4FC8", VA = "0x8D4FC8")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000074")]
	public Vector3 FixedVelocity
	{
		[Token(Token = "0x600034A")]
		[Address(RVA = "0x8D4FD0", Offset = "0x8D4FD0", VA = "0x8D4FD0")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x17000075")]
	public bool HasBounce
	{
		[Token(Token = "0x600034B")]
		[Address(RVA = "0x8D5018", Offset = "0x8D5018", VA = "0x8D5018")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600034C")]
		[Address(RVA = "0x8D5020", Offset = "0x8D5020", VA = "0x8D5020")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000076")]
	public float Radius
	{
		[Token(Token = "0x600034D")]
		[Address(RVA = "0x8D502C", Offset = "0x8D502C", VA = "0x8D502C")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600034E")]
		[Address(RVA = "0x8D5034", Offset = "0x8D5034", VA = "0x8D5034")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000077")]
	public bool IsInPocket
	{
		[Token(Token = "0x600034F")]
		[Address(RVA = "0x8D503C", Offset = "0x8D503C", VA = "0x8D503C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000078")]
	public bool IsInPocketThisHit
	{
		[Token(Token = "0x6000352")]
		[Address(RVA = "0x8D51BC", Offset = "0x8D51BC", VA = "0x8D51BC")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000353")]
		[Address(RVA = "0x8D51C4", Offset = "0x8D51C4", VA = "0x8D51C4")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x6000350")]
	[Address(RVA = "0x8D509C", Offset = "0x8D509C", VA = "0x8D509C")]
	public void SetIsOutOfBound()
	{
	}

	[Token(Token = "0x6000351")]
	[Address(RVA = "0x8D50A8", Offset = "0x8D50A8", VA = "0x8D50A8")]
	public void SetPocket(Pocket pocket)
	{
	}

	[Token(Token = "0x6000354")]
	[Address(RVA = "0x8D51D0", Offset = "0x8D51D0", VA = "0x8D51D0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000355")]
	[Address(RVA = "0x8D51D4", Offset = "0x8D51D4", VA = "0x8D51D4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000356")]
	[Address(RVA = "0x8D525C", Offset = "0x8D525C", VA = "0x8D525C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000357")]
	[Address(RVA = "0x8D5260", Offset = "0x8D5260", VA = "0x8D5260")]
	public void SyncState(ChineseEightBallRemotePlayer.BallState state)
	{
	}

	[Token(Token = "0x6000358")]
	[Address(RVA = "0x8D529C", Offset = "0x8D529C", VA = "0x8D529C")]
	public void ResetState(bool resetPocket = false)
	{
	}

	[Token(Token = "0x6000359")]
	[Address(RVA = "0x8D5390", Offset = "0x8D5390", VA = "0x8D5390")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600035A")]
	[Address(RVA = "0x8D5474", Offset = "0x8D5474", VA = "0x8D5474")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600035B")]
	[Address(RVA = "0x8D5990", Offset = "0x8D5990", VA = "0x8D5990")]
	private void Bounce(Collision collision, Ball otherBall)
	{
	}

	[Token(Token = "0x600035C")]
	[Address(RVA = "0x8D6510", Offset = "0x8D6510", VA = "0x8D6510")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x600035D")]
	[Address(RVA = "0x8D6854", Offset = "0x8D6854", VA = "0x8D6854")]
	public void Active()
	{
	}

	[Token(Token = "0x600035E")]
	[Address(RVA = "0x8D64A0", Offset = "0x8D64A0", VA = "0x8D64A0")]
	public void ActiveRigidbody()
	{
	}

	[Token(Token = "0x600035F")]
	[Address(RVA = "0x8D6860", Offset = "0x8D6860", VA = "0x8D6860")]
	public void RefreshRigidbodyActive()
	{
	}

	[Token(Token = "0x6000360")]
	[Address(RVA = "0x8D68F4", Offset = "0x8D68F4", VA = "0x8D68F4")]
	public void InActive()
	{
	}

	[Token(Token = "0x6000361")]
	[Address(RVA = "0x8D6430", Offset = "0x8D6430", VA = "0x8D6430")]
	public void InActiveRigidbody()
	{
	}

	[Token(Token = "0x6000362")]
	[Address(RVA = "0x8D68FC", Offset = "0x8D68FC", VA = "0x8D68FC")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000363")]
	[Address(RVA = "0x8D6904", Offset = "0x8D6904", VA = "0x8D6904")]
	public Ball()
	{
	}
}
[Token(Token = "0x20000D5")]
public class Bound : MonoBehaviour
{
	[Token(Token = "0x6000368")]
	[Address(RVA = "0x8D6B14", Offset = "0x8D6B14", VA = "0x8D6B14")]
	private void Start()
	{
	}

	[Token(Token = "0x6000369")]
	[Address(RVA = "0x8D6B18", Offset = "0x8D6B18", VA = "0x8D6B18")]
	private void Update()
	{
	}

	[Token(Token = "0x600036A")]
	[Address(RVA = "0x8D6B1C", Offset = "0x8D6B1C", VA = "0x8D6B1C")]
	public Bound()
	{
	}
}
[Token(Token = "0x20000D6")]
public class ChineseEightBall : Ball
{
	[Token(Token = "0x4000359")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	public int Number;

	[Token(Token = "0x17000079")]
	public bool IsWhiteBall
	{
		[Token(Token = "0x600036B")]
		[Address(RVA = "0x8D6B24", Offset = "0x8D6B24", VA = "0x8D6B24")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700007A")]
	public bool IsBlackBall
	{
		[Token(Token = "0x600036C")]
		[Address(RVA = "0x8D6B34", Offset = "0x8D6B34", VA = "0x8D6B34")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700007B")]
	public bool IsFullColor
	{
		[Token(Token = "0x600036D")]
		[Address(RVA = "0x8D6B44", Offset = "0x8D6B44", VA = "0x8D6B44")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700007C")]
	public bool IsHalfColor
	{
		[Token(Token = "0x600036E")]
		[Address(RVA = "0x8D6B60", Offset = "0x8D6B60", VA = "0x8D6B60")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600036F")]
	[Address(RVA = "0x8D6B70", Offset = "0x8D6B70", VA = "0x8D6B70")]
	private void Start()
	{
	}

	[Token(Token = "0x6000370")]
	[Address(RVA = "0x8D6B74", Offset = "0x8D6B74", VA = "0x8D6B74")]
	private void Update()
	{
	}

	[Token(Token = "0x6000371")]
	[Address(RVA = "0x8D6B78", Offset = "0x8D6B78", VA = "0x8D6B78")]
	public ChineseEightBall()
	{
	}
}
[Token(Token = "0x20000D7")]
public class ConnectDialog : Dialog
{
	[Token(Token = "0x400035A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject CreateRoomDialog;

	[Token(Token = "0x400035B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject JoinRoomDialog;

	[Token(Token = "0x400035C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject RandomRoomDialog;

	[Token(Token = "0x400035D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private CancellationTokenSource cancellationToken;

	[Token(Token = "0x6000372")]
	[Address(RVA = "0x8D6B7C", Offset = "0x8D6B7C", VA = "0x8D6B7C")]
	public void CreateRoomClick()
	{
	}

	[Token(Token = "0x6000373")]
	[Address(RVA = "0x8D6BAC", Offset = "0x8D6BAC", VA = "0x8D6BAC")]
	public void JoinRoomClick()
	{
	}

	[Token(Token = "0x6000374")]
	[Address(RVA = "0x8D6BDC", Offset = "0x8D6BDC", VA = "0x8D6BDC")]
	public void RandomRoomClick()
	{
	}

	[Token(Token = "0x6000375")]
	[Address(RVA = "0x8D6C0C", Offset = "0x8D6C0C", VA = "0x8D6C0C", Slot = "4")]
	public override void Close()
	{
	}

	[Token(Token = "0x6000376")]
	[Address(RVA = "0x8D6CF0", Offset = "0x8D6CF0", VA = "0x8D6CF0")]
	public ConnectDialog()
	{
	}
}
[Token(Token = "0x20000D8")]
public class CreateRoomDialog : Dialog
{
	[Token(Token = "0x20000D9")]
	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_0
	{
		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public NetManager.RoomCodeResult res;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CreateRoomDialog <>4__this;

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x8D835C", Offset = "0x8D835C", VA = "0x8D835C")]
		public <>c__DisplayClass9_0()
		{
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x8D8364", Offset = "0x8D8364", VA = "0x8D8364")]
		internal void <CreateClickAsync>b__0()
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x20000DA")]
	[CompilerGenerated]
	private struct <CreateClickAsync>d__9 : IAsyncStateMachine
	{
		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CreateRoomDialog <>4__this;

		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private <>c__DisplayClass9_0 <>8__1;

		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TaskAwaiter<NetManager.RoomCodeResult> <>u__1;

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x8D84F8", Offset = "0x8D84F8", VA = "0x8D84F8", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x8D8A08", Offset = "0x8D8A08", VA = "0x8D8A08", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x400035E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject CreateObj;

	[Token(Token = "0x400035F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject CancelObj;

	[Token(Token = "0x4000360")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject Title;

	[Token(Token = "0x4000361")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject RoomNumberObj;

	[Token(Token = "0x4000362")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Text RoomNumber;

	[Token(Token = "0x4000363")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool isCreateRoom;

	[Token(Token = "0x4000364")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private CancellationTokenSource cancellationToken;

	[Token(Token = "0x6000377")]
	[Address(RVA = "0x8D6CF8", Offset = "0x8D6CF8", VA = "0x8D6CF8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000378")]
	[Address(RVA = "0x8D6D18", Offset = "0x8D6D18", VA = "0x8D6D18")]
	public void CreateClick()
	{
	}

	[Token(Token = "0x6000379")]
	[Address(RVA = "0x8D6D1C", Offset = "0x8D6D1C", VA = "0x8D6D1C")]
	[AsyncStateMachine(typeof(<CreateClickAsync>d__9))]
	private System.Threading.Tasks.Task CreateClickAsync()
	{
		return null;
	}

	[Token(Token = "0x600037A")]
	[Address(RVA = "0x8D6E0C", Offset = "0x8D6E0C", VA = "0x8D6E0C")]
	public void CancelClick()
	{
	}

	[Token(Token = "0x600037B")]
	[Address(RVA = "0x8D6E80", Offset = "0x8D6E80", VA = "0x8D6E80")]
	public void CloseClick()
	{
	}

	[Token(Token = "0x600037C")]
	[Address(RVA = "0x8D6EB0", Offset = "0x8D6EB0", VA = "0x8D6EB0", Slot = "4")]
	public override void Close()
	{
	}

	[Token(Token = "0x600037D")]
	[Address(RVA = "0x8D6EB4", Offset = "0x8D6EB4", VA = "0x8D6EB4")]
	public CreateRoomDialog()
	{
	}
}
[Token(Token = "0x20000DB")]
public class Desk : MonoBehaviour
{
	[Token(Token = "0x400036C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float Elasticity;

	[Token(Token = "0x6000385")]
	[Address(RVA = "0x8D8A14", Offset = "0x8D8A14", VA = "0x8D8A14")]
	private void Start()
	{
	}

	[Token(Token = "0x6000386")]
	[Address(RVA = "0x8D8A18", Offset = "0x8D8A18", VA = "0x8D8A18")]
	private void Update()
	{
	}

	[Token(Token = "0x6000387")]
	[Address(RVA = "0x8D8A1C", Offset = "0x8D8A1C", VA = "0x8D8A1C")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6000388")]
	[Address(RVA = "0x8D8B0C", Offset = "0x8D8B0C", VA = "0x8D8B0C")]
	public Desk()
	{
	}
}
[Token(Token = "0x20000DC")]
public class DeskBorder : MonoBehaviour
{
	[Token(Token = "0x400036D")]
	private const float DISTANCE_M = 0.08f;

	[Token(Token = "0x400036E")]
	private const float DISTANCE_S = 0.59f;

	[Token(Token = "0x400036F")]
	private const float DISTANCE_L = 1.23f;

	[Token(Token = "0x4000370")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private TimedCache<Ball> bounceList;

	[Token(Token = "0x6000389")]
	[Address(RVA = "0x8D8B20", Offset = "0x8D8B20", VA = "0x8D8B20")]
	private void Start()
	{
	}

	[Token(Token = "0x600038A")]
	[Address(RVA = "0x8D8B24", Offset = "0x8D8B24", VA = "0x8D8B24")]
	private void Update()
	{
	}

	[Token(Token = "0x600038B")]
	[Address(RVA = "0x8D8B28", Offset = "0x8D8B28", VA = "0x8D8B28")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600038C")]
	[Address(RVA = "0x8D8B80", Offset = "0x8D8B80", VA = "0x8D8B80")]
	public static BorderType GetBorderType(Vector3 point)
	{
		return default(BorderType);
	}

	[Token(Token = "0x600038D")]
	[Address(RVA = "0x8D8C88", Offset = "0x8D8C88", VA = "0x8D8C88")]
	public static BorderType GetBorderType(Vector2 point)
	{
		return default(BorderType);
	}

	[Token(Token = "0x600038E")]
	[Address(RVA = "0x8D8B88", Offset = "0x8D8B88", VA = "0x8D8B88")]
	public static BorderType GetBorderType(float x, float y)
	{
		return default(BorderType);
	}

	[Token(Token = "0x600038F")]
	[Address(RVA = "0x8D8C8C", Offset = "0x8D8C8C", VA = "0x8D8C8C")]
	private void Bounce(Collision collision, Ball ball)
	{
	}

	[Token(Token = "0x6000390")]
	[Address(RVA = "0x8D91C0", Offset = "0x8D91C0", VA = "0x8D91C0")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6000391")]
	[Address(RVA = "0x8D927C", Offset = "0x8D927C", VA = "0x8D927C")]
	public DeskBorder()
	{
	}
}
[Token(Token = "0x20000DD")]
public enum BorderType
{
	[Token(Token = "0x4000372")]
	Vertical,
	[Token(Token = "0x4000373")]
	Horizontal,
	[Token(Token = "0x4000374")]
	Pocket
}
[Token(Token = "0x20000DE")]
public class Dialog : MonoBehaviour
{
	[Token(Token = "0x6000392")]
	[Address(RVA = "0x8D9304", Offset = "0x8D9304", VA = "0x8D9304")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000393")]
	[Address(RVA = "0x8D9308", Offset = "0x8D9308", VA = "0x8D9308", Slot = "4")]
	public virtual void Close()
	{
	}

	[Token(Token = "0x6000394")]
	[Address(RVA = "0x8D93D4", Offset = "0x8D93D4", VA = "0x8D93D4")]
	public Dialog()
	{
	}
}
[Token(Token = "0x20000DF")]
public class ExitRoom : Dialog
{
	[Token(Token = "0x6000395")]
	[Address(RVA = "0x8D93DC", Offset = "0x8D93DC", VA = "0x8D93DC")]
	public void ExitClick()
	{
	}

	[Token(Token = "0x6000396")]
	[Address(RVA = "0x8D97E0", Offset = "0x8D97E0", VA = "0x8D97E0")]
	public ExitRoom()
	{
	}
}
[Token(Token = "0x20000E0")]
public class FPS : MonoBehaviour
{
	[Token(Token = "0x4000375")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private float _updateInterval;

	[Token(Token = "0x4000376")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private float _accum;

	[Token(Token = "0x4000377")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int _frames;

	[Token(Token = "0x4000378")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float _timeLeft;

	[Token(Token = "0x4000379")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private string fpsFormat;

	[Token(Token = "0x400037A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Text fpsText;

	[Token(Token = "0x6000397")]
	[Address(RVA = "0x8D97E8", Offset = "0x8D97E8", VA = "0x8D97E8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000398")]
	[Address(RVA = "0x8D97F4", Offset = "0x8D97F4", VA = "0x8D97F4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000399")]
	[Address(RVA = "0x8D984C", Offset = "0x8D984C", VA = "0x8D984C")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x600039A")]
	[Address(RVA = "0x8D98E4", Offset = "0x8D98E4", VA = "0x8D98E4")]
	private void Update()
	{
	}

	[Token(Token = "0x600039B")]
	[Address(RVA = "0x8D99FC", Offset = "0x8D99FC", VA = "0x8D99FC")]
	public FPS()
	{
	}
}
[Token(Token = "0x20000E1")]
public class Gan : MonoBehaviour
{
	[Token(Token = "0x400037B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool isAfterLine;

	[Token(Token = "0x400037C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private float firstHitTime;

	[Token(Token = "0x400037D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private TimedCache<Ball> bounceList;

	[Token(Token = "0x400037E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GanHead GanHead;

	[Token(Token = "0x400037F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GanBody GanBody;

	[Token(Token = "0x1700007D")]
	public Ball FirstHitBall
	{
		[Token(Token = "0x600039C")]
		[Address(RVA = "0x8D9A0C", Offset = "0x8D9A0C", VA = "0x8D9A0C")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600039D")]
		[Address(RVA = "0x8D9A14", Offset = "0x8D9A14", VA = "0x8D9A14")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700007E")]
	public bool DoubleHit
	{
		[Token(Token = "0x600039E")]
		[Address(RVA = "0x8D9A1C", Offset = "0x8D9A1C", VA = "0x8D9A1C")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600039F")]
		[Address(RVA = "0x8D9A24", Offset = "0x8D9A24", VA = "0x8D9A24")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700007F")]
	public bool BodyHit
	{
		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x8D9A30", Offset = "0x8D9A30", VA = "0x8D9A30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x8D9A38", Offset = "0x8D9A38", VA = "0x8D9A38")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000080")]
	public TimedCache<Ball> BounceList
	{
		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x8D9A44", Offset = "0x8D9A44", VA = "0x8D9A44")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000081")]
	public Action ActionAfterHit
	{
		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x8D9A4C", Offset = "0x8D9A4C", VA = "0x8D9A4C")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x8D9A54", Offset = "0x8D9A54", VA = "0x8D9A54")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000082")]
	public bool IsActive
	{
		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x8D9A5C", Offset = "0x8D9A5C", VA = "0x8D9A5C")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x8D9A64", Offset = "0x8D9A64", VA = "0x8D9A64")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x60003A7")]
	[Address(RVA = "0x8D9A70", Offset = "0x8D9A70", VA = "0x8D9A70")]
	private void Start()
	{
	}

	[Token(Token = "0x60003A8")]
	[Address(RVA = "0x8D9B60", Offset = "0x8D9B60", VA = "0x8D9B60")]
	private void Update()
	{
	}

	[Token(Token = "0x60003A9")]
	[Address(RVA = "0x8D9DC8", Offset = "0x8D9DC8", VA = "0x8D9DC8")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60003AA")]
	[Address(RVA = "0x8D9E20", Offset = "0x8D9E20", VA = "0x8D9E20")]
	public void Active()
	{
	}

	[Token(Token = "0x60003AB")]
	[Address(RVA = "0x8D9D2C", Offset = "0x8D9D2C", VA = "0x8D9D2C")]
	public void ActiveInner()
	{
	}

	[Token(Token = "0x60003AC")]
	[Address(RVA = "0x8D9E50", Offset = "0x8D9E50", VA = "0x8D9E50")]
	public void ActiveAfterLine()
	{
	}

	[Token(Token = "0x60003AD")]
	[Address(RVA = "0x8D9AE4", Offset = "0x8D9AE4", VA = "0x8D9AE4")]
	public void InActive()
	{
	}

	[Token(Token = "0x60003AE")]
	[Address(RVA = "0x8D9C7C", Offset = "0x8D9C7C", VA = "0x8D9C7C")]
	public void InActiveInner(bool resetAfterLine = true)
	{
	}

	[Token(Token = "0x60003AF")]
	[Address(RVA = "0x8D9E84", Offset = "0x8D9E84", VA = "0x8D9E84")]
	public Gan()
	{
	}
}
[Token(Token = "0x20000E2")]
public class GanBody : MonoBehaviour
{
	[Token(Token = "0x4000385")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private TimedCache<Ball> bounceList;

	[Token(Token = "0x4000386")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Gan gan;

	[Token(Token = "0x60003B0")]
	[Address(RVA = "0x8D9F0C", Offset = "0x8D9F0C", VA = "0x8D9F0C")]
	private void Start()
	{
	}

	[Token(Token = "0x60003B1")]
	[Address(RVA = "0x8D9B30", Offset = "0x8D9B30", VA = "0x8D9B30")]
	public void Init(TimedCache<Ball> bounceList, Gan gan)
	{
	}

	[Token(Token = "0x60003B2")]
	[Address(RVA = "0x8D9F10", Offset = "0x8D9F10", VA = "0x8D9F10")]
	private void Update()
	{
	}

	[Token(Token = "0x60003B3")]
	[Address(RVA = "0x8D9F14", Offset = "0x8D9F14", VA = "0x8D9F14")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x60003B4")]
	[Address(RVA = "0x8DA0EC", Offset = "0x8DA0EC", VA = "0x8DA0EC")]
	public GanBody()
	{
	}
}
[Token(Token = "0x20000E3")]
public class GanHand : MonoBehaviour
{
	[Token(Token = "0x20000E4")]
	private enum State
	{
		[Token(Token = "0x400038F")]
		Active,
		[Token(Token = "0x4000390")]
		InActive,
		[Token(Token = "0x4000391")]
		Activing,
		[Token(Token = "0x4000392")]
		InActiving
	}

	[Token(Token = "0x4000387")]
	private const float ROTATE_SPEED = 180f;

	[Token(Token = "0x4000388")]
	private const float MAX_SPEED = 0.18f;

	[Token(Token = "0x4000389")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Gan Gan;

	[Token(Token = "0x400038A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject GanToMenu;

	[Token(Token = "0x400038B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Hand hand;

	[Token(Token = "0x400038C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private State state;

	[Token(Token = "0x400038D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Action activeAction;

	[Token(Token = "0x17000083")]
	public Vector3 Position
	{
		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x8DA174", Offset = "0x8DA174", VA = "0x8DA174")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x60003B6")]
	[Address(RVA = "0x8DA1B0", Offset = "0x8DA1B0", VA = "0x8DA1B0")]
	private void Start()
	{
	}

	[Token(Token = "0x60003B7")]
	[Address(RVA = "0x8DA2E8", Offset = "0x8DA2E8", VA = "0x8DA2E8")]
	private void Update()
	{
	}

	[Token(Token = "0x60003B8")]
	[Address(RVA = "0x8DA704", Offset = "0x8DA704", VA = "0x8DA704")]
	public void ToggleActive()
	{
	}

	[Token(Token = "0x60003B9")]
	[Address(RVA = "0x8DA8D8", Offset = "0x8DA8D8", VA = "0x8DA8D8")]
	public void Active()
	{
	}

	[Token(Token = "0x60003BA")]
	[Address(RVA = "0x8DA820", Offset = "0x8DA820", VA = "0x8DA820")]
	public void ActiveAfterLine()
	{
	}

	[Token(Token = "0x60003BB")]
	[Address(RVA = "0x8DA9DC", Offset = "0x8DA9DC", VA = "0x8DA9DC")]
	public void InActiveAfterHit()
	{
	}

	[Token(Token = "0x60003BC")]
	[Address(RVA = "0x8DA7C8", Offset = "0x8DA7C8", VA = "0x8DA7C8")]
	public void InActive()
	{
	}

	[Token(Token = "0x60003BD")]
	[Address(RVA = "0x8DAAE8", Offset = "0x8DAAE8", VA = "0x8DAAE8")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60003BE")]
	[Address(RVA = "0x8DB08C", Offset = "0x8DB08C", VA = "0x8DB08C")]
	public void SetRight()
	{
	}

	[Token(Token = "0x60003BF")]
	[Address(RVA = "0x8DB0B8", Offset = "0x8DB0B8", VA = "0x8DB0B8")]
	public void SetLeft()
	{
	}

	[Token(Token = "0x60003C0")]
	[Address(RVA = "0x8DB120", Offset = "0x8DB120", VA = "0x8DB120")]
	public GanHand()
	{
	}
}
[Token(Token = "0x20000E6")]
public class GanHead : MonoBehaviour
{
	[Token(Token = "0x4000395")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform posTransform;

	[Token(Token = "0x4000396")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Vector3 position;

	[Token(Token = "0x4000397")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private Vector3 velocity;

	[Token(Token = "0x4000398")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private TimedCache<Ball> bounceList;

	[Token(Token = "0x4000399")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Gan gan;

	[Token(Token = "0x60003C7")]
	[Address(RVA = "0x8DB360", Offset = "0x8DB360", VA = "0x8DB360")]
	private void Start()
	{
	}

	[Token(Token = "0x60003C8")]
	[Address(RVA = "0x8D9B00", Offset = "0x8D9B00", VA = "0x8D9B00")]
	public void Init(TimedCache<Ball> bounceList, Gan gan)
	{
	}

	[Token(Token = "0x60003C9")]
	[Address(RVA = "0x8DB38C", Offset = "0x8DB38C", VA = "0x8DB38C")]
	private void Update()
	{
	}

	[Token(Token = "0x60003CA")]
	[Address(RVA = "0x8DB390", Offset = "0x8DB390", VA = "0x8DB390")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60003CB")]
	[Address(RVA = "0x8DB418", Offset = "0x8DB418", VA = "0x8DB418")]
	private Vector3 GetHitPoint(Ball ball, Vector3 vDirect)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60003CC")]
	[Address(RVA = "0x8DB6A4", Offset = "0x8DB6A4", VA = "0x8DB6A4")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x60003CD")]
	[Address(RVA = "0x8DB6A8", Offset = "0x8DB6A8", VA = "0x8DB6A8")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60003CE")]
	[Address(RVA = "0x8DC028", Offset = "0x8DC028", VA = "0x8DC028")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x60003CF")]
	[Address(RVA = "0x8DC02C", Offset = "0x8DC02C", VA = "0x8DC02C")]
	public GanHead()
	{
	}
}
[Token(Token = "0x20000E7")]
public class GuideDialog : Dialog
{
	[StructLayout(3)]
	[Token(Token = "0x20000E9")]
	[CompilerGenerated]
	private struct <OkClick>d__2 : IAsyncStateMachine
	{
		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GuideDialog <>4__this;

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TaskAwaiter <>u__1;

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x8DC69C", Offset = "0x8DC69C", VA = "0x8DC69C", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x8DCDE4", Offset = "0x8DCDE4", VA = "0x8DCDE4", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x400039A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Text Title;

	[Token(Token = "0x60003D0")]
	[Address(RVA = "0x8DC0B4", Offset = "0x8DC0B4", VA = "0x8DC0B4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60003D1")]
	[Address(RVA = "0x8DC194", Offset = "0x8DC194", VA = "0x8DC194")]
	[AsyncStateMachine(typeof(<OkClick>d__2))]
	public void OkClick()
	{
	}

	[Token(Token = "0x60003D2")]
	[Address(RVA = "0x8DC24C", Offset = "0x8DC24C", VA = "0x8DC24C")]
	public GuideDialog()
	{
	}
}
[Token(Token = "0x20000EA")]
public class Hand : MonoBehaviour
{
	[Token(Token = "0x20000EB")]
	private class PoseData
	{
		[Token(Token = "0x17000089")]
		public Transform Bone
		{
			[Token(Token = "0x60003ED")]
			[Address(RVA = "0x8DEB20", Offset = "0x8DEB20", VA = "0x8DEB20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60003EE")]
			[Address(RVA = "0x8DEB28", Offset = "0x8DEB28", VA = "0x8DEB28")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700008A")]
		public Quaternion Rotate
		{
			[Token(Token = "0x60003EF")]
			[Address(RVA = "0x8DEB30", Offset = "0x8DEB30", VA = "0x8DEB30")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x60003F0")]
			[Address(RVA = "0x8DEB3C", Offset = "0x8DEB3C", VA = "0x8DEB3C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x8DDD14", Offset = "0x8DDD14", VA = "0x8DDD14")]
		public PoseData(Transform bone, Quaternion rotate)
		{
		}
	}

	[Token(Token = "0x20000EC")]
	private enum State
	{
		[Token(Token = "0x40003B2")]
		Posed,
		[Token(Token = "0x40003B3")]
		UnPosed,
		[Token(Token = "0x40003B4")]
		Posing,
		[Token(Token = "0x40003B5")]
		UnPosing
	}

	[Token(Token = "0x40003A1")]
	private const float ROTATE_SPEED = 180f;

	[Token(Token = "0x40003A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Quaternion DELTA_ROTATE;

	[Token(Token = "0x40003A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private List<PoseData> ganPose;

	[Token(Token = "0x40003A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private List<PoseData> normalPose;

	[Token(Token = "0x40003A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private List<PoseData> targetPose;

	[Token(Token = "0x40003A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool posing;

	[Token(Token = "0x40003A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private State state;

	[Token(Token = "0x40003A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Transform posBone;

	[Token(Token = "0x40003AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private GanHand ganHand;

	[Token(Token = "0x40003AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private bool mirror;

	[Token(Token = "0x17000084")]
	public Action MakePoseAction
	{
		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x8DCDF0", Offset = "0x8DCDF0", VA = "0x8DCDF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x8DCDF8", Offset = "0x8DCDF8", VA = "0x8DCDF8")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000085")]
	public Action ResetPoseAction
	{
		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x8DCE00", Offset = "0x8DCE00", VA = "0x8DCE00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x8DCE08", Offset = "0x8DCE08", VA = "0x8DCE08")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000086")]
	public Action SetDefaultHandAction
	{
		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x8DCE10", Offset = "0x8DCE10", VA = "0x8DCE10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x8DCE18", Offset = "0x8DCE18", VA = "0x8DCE18")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000087")]
	public Action SetLeftHandAction
	{
		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x8DCE20", Offset = "0x8DCE20", VA = "0x8DCE20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x8DCE28", Offset = "0x8DCE28", VA = "0x8DCE28")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000088")]
	public Vector3 Position
	{
		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x8DA638", Offset = "0x8DA638", VA = "0x8DA638")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x60003E1")]
	[Address(RVA = "0x8DCE30", Offset = "0x8DCE30", VA = "0x8DCE30")]
	private void Start()
	{
	}

	[Token(Token = "0x60003E2")]
	[Address(RVA = "0x8DDD70", Offset = "0x8DDD70", VA = "0x8DDD70")]
	private PoseData GetPoseData(string name, int depth)
	{
		return null;
	}

	[Token(Token = "0x60003E3")]
	[Address(RVA = "0x8DDC1C", Offset = "0x8DDC1C", VA = "0x8DDC1C")]
	private Transform FindBone(string name, int depth)
	{
		return null;
	}

	[Token(Token = "0x60003E4")]
	[Address(RVA = "0x8DA990", Offset = "0x8DA990", VA = "0x8DA990")]
	public void MakePose()
	{
	}

	[Token(Token = "0x60003E5")]
	[Address(RVA = "0x8DAA9C", Offset = "0x8DAA9C", VA = "0x8DAA9C")]
	public void ResetPose()
	{
	}

	[Token(Token = "0x60003E6")]
	[Address(RVA = "0x8DDE30", Offset = "0x8DDE30", VA = "0x8DDE30")]
	private void MakePoseStep()
	{
	}

	[Token(Token = "0x60003E7")]
	[Address(RVA = "0x8DE0E8", Offset = "0x8DE0E8", VA = "0x8DE0E8")]
	public void SetRight()
	{
	}

	[Token(Token = "0x60003E8")]
	[Address(RVA = "0x8DE1CC", Offset = "0x8DE1CC", VA = "0x8DE1CC")]
	public void SetLeft()
	{
	}

	[Token(Token = "0x60003E9")]
	[Address(RVA = "0x8DE2E0", Offset = "0x8DE2E0", VA = "0x8DE2E0")]
	private void Update()
	{
	}

	[Token(Token = "0x60003EA")]
	[Address(RVA = "0x8DEA08", Offset = "0x8DEA08", VA = "0x8DEA08")]
	public Hand()
	{
	}
}
[Token(Token = "0x20000EE")]
public class JoinRoomDialog : Dialog
{
	[StructLayout(3)]
	[Token(Token = "0x20000F0")]
	[CompilerGenerated]
	private struct <JoinClickAsync>d__4 : IAsyncStateMachine
	{
		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public JoinRoomDialog <>4__this;

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TaskAwaiter<string> <>u__1;

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x8DF390", Offset = "0x8DF390", VA = "0x8DF390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x8DF83C", Offset = "0x8DF83C", VA = "0x8DF83C", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x40003B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Text RoomNumber;

	[Token(Token = "0x60003F5")]
	[Address(RVA = "0x8DEC7C", Offset = "0x8DEC7C", VA = "0x8DEC7C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60003F6")]
	[Address(RVA = "0x8DECD8", Offset = "0x8DECD8", VA = "0x8DECD8")]
	public void ButtonClick(GameObject gameObject)
	{
	}

	[Token(Token = "0x60003F7")]
	[Address(RVA = "0x8DEDC4", Offset = "0x8DEDC4", VA = "0x8DEDC4")]
	public void JoinClick()
	{
	}

	[Token(Token = "0x60003F8")]
	[Address(RVA = "0x8DEDC8", Offset = "0x8DEDC8", VA = "0x8DEDC8")]
	[AsyncStateMachine(typeof(<JoinClickAsync>d__4))]
	private System.Threading.Tasks.Task JoinClickAsync()
	{
		return null;
	}

	[Token(Token = "0x60003F9")]
	[Address(RVA = "0x8DEEB4", Offset = "0x8DEEB4", VA = "0x8DEEB4")]
	public void DeleteClick()
	{
	}

	[Token(Token = "0x60003FA")]
	[Address(RVA = "0x8DEF20", Offset = "0x8DEF20", VA = "0x8DEF20", Slot = "4")]
	public override void Close()
	{
	}

	[Token(Token = "0x60003FB")]
	[Address(RVA = "0x8DF01C", Offset = "0x8DF01C", VA = "0x8DF01C")]
	public JoinRoomDialog()
	{
	}
}
[Token(Token = "0x20000F1")]
public class Mark : MonoBehaviour
{
	[Token(Token = "0x40003BF")]
	private const float DEFAULT_DISTANCE = 1f;

	[Token(Token = "0x40003C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Player Player;

	[Token(Token = "0x40003C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject Image;

	[Token(Token = "0x40003C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject DeskCenter;

	[Token(Token = "0x40003C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Quaternion fixRotation;

	[Token(Token = "0x40003C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool hasPressed;

	[Token(Token = "0x40003C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Gan gan;

	[Token(Token = "0x1700008B")]
	private GameObject WhiteBall
	{
		[Token(Token = "0x6000402")]
		[Address(RVA = "0x8DF848", Offset = "0x8DF848", VA = "0x8DF848")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000403")]
	[Address(RVA = "0x8DF974", Offset = "0x8DF974", VA = "0x8DF974")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000404")]
	[Address(RVA = "0x8DF980", Offset = "0x8DF980", VA = "0x8DF980")]
	private void Update()
	{
	}

	[Token(Token = "0x6000405")]
	[Address(RVA = "0x8E027C", Offset = "0x8E027C", VA = "0x8E027C")]
	public Mark()
	{
	}
}
[Token(Token = "0x20000F2")]
public class Menu : MonoBehaviour
{
	[Token(Token = "0x40003C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GanHand Gan;

	[Token(Token = "0x40003C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject BG;

	[Token(Token = "0x40003C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject Mark;

	[Token(Token = "0x40003C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject ConnectObject;

	[Token(Token = "0x40003CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject SettingsObject;

	[Token(Token = "0x40003CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject SettingsDialog;

	[Token(Token = "0x40003CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject ConnectDialog;

	[Token(Token = "0x40003CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject ExitDialog;

	[Token(Token = "0x40003CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject Dialog;

	[Token(Token = "0x40003CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public GameObject HelpObject;

	[Token(Token = "0x40003D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public GameObject GuideDialog;

	[Token(Token = "0x40003D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Controller Controller;

	[Token(Token = "0x40003D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Vector3 from;

	[Token(Token = "0x40003D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private Vector3 to;

	[Token(Token = "0x40003D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public Vector3 BGLTP;

	[Token(Token = "0x40003D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	public Vector3 BGRTP;

	[Token(Token = "0x40003D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Vector3 BGLBP;

	[Token(Token = "0x40003D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	public Vector3 BGRBP;

	[Token(Token = "0x40003D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private Vector3 ConnectObjLTP;

	[Token(Token = "0x40003D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	private Vector3 ConnectObjRTP;

	[Token(Token = "0x40003DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private Vector3 ConnectObjLBP;

	[Token(Token = "0x40003DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
	private Vector3 ConnectObjRBP;

	[Token(Token = "0x40003DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private Vector3 SettingsObjLTP;

	[Token(Token = "0x40003DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
	private Vector3 SettingsObjRTP;

	[Token(Token = "0x40003DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private Vector3 SettingsObjLBP;

	[Token(Token = "0x40003DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
	private Vector3 SettingsObjRBP;

	[Token(Token = "0x40003E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private Vector3 HelpObjLTP;

	[Token(Token = "0x40003E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
	private Vector3 HelpObjRTP;

	[Token(Token = "0x40003E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private Vector3 HelpObjLBP;

	[Token(Token = "0x40003E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
	private Vector3 HelpObjRBP;

	[Token(Token = "0x40003E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private bool ButtonDown;

	[Token(Token = "0x6000406")]
	[Address(RVA = "0x8E0284", Offset = "0x8E0284", VA = "0x8E0284")]
	private void Start()
	{
	}

	[Token(Token = "0x6000407")]
	[Address(RVA = "0x8E07A8", Offset = "0x8E07A8", VA = "0x8E07A8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000408")]
	[Address(RVA = "0x8E07AC", Offset = "0x8E07AC", VA = "0x8E07AC")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000409")]
	[Address(RVA = "0x8E0DD4", Offset = "0x8E0DD4", VA = "0x8E0DD4")]
	private void GetFrom()
	{
	}

	[Token(Token = "0x600040A")]
	[Address(RVA = "0x8E0CFC", Offset = "0x8E0CFC", VA = "0x8E0CFC")]
	public bool DialogChildShow()
	{
		return default(bool);
	}

	[Token(Token = "0x600040B")]
	[Address(RVA = "0x8E0E18", Offset = "0x8E0E18", VA = "0x8E0E18")]
	private Vector3 GanVertex()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600040C")]
	[Address(RVA = "0x8E0EC0", Offset = "0x8E0EC0", VA = "0x8E0EC0")]
	public Vector3 TargetVector(Vector3 vertex, Vector3 pos)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600040D")]
	[Address(RVA = "0x8E1028", Offset = "0x8E1028", VA = "0x8E1028")]
	public void DrawLine(Color color)
	{
	}

	[Token(Token = "0x600040E")]
	[Address(RVA = "0x8E0FAC", Offset = "0x8E0FAC", VA = "0x8E0FAC")]
	private bool InSettingsObject(Vector3 vector)
	{
		return default(bool);
	}

	[Token(Token = "0x600040F")]
	[Address(RVA = "0x8E0F70", Offset = "0x8E0F70", VA = "0x8E0F70")]
	private bool InConnectObject(Vector3 vector)
	{
		return default(bool);
	}

	[Token(Token = "0x6000410")]
	[Address(RVA = "0x8E0FE8", Offset = "0x8E0FE8", VA = "0x8E0FE8")]
	private bool InHelpObject(Vector3 vector)
	{
		return default(bool);
	}

	[Token(Token = "0x6000411")]
	[Address(RVA = "0x8E0F34", Offset = "0x8E0F34", VA = "0x8E0F34")]
	private bool InBG(Vector3 vector)
	{
		return default(bool);
	}

	[Token(Token = "0x6000412")]
	[Address(RVA = "0x8E10B8", Offset = "0x8E10B8", VA = "0x8E10B8")]
	public bool InPanel(Vector3 vector, Vector3 leftTopPos, Vector3 rightTopPos, Vector3 leftBottomPos, Vector3 rightBottomPos)
	{
		return default(bool);
	}

	[Token(Token = "0x6000413")]
	[Address(RVA = "0x8E03CC", Offset = "0x8E03CC", VA = "0x8E03CC")]
	private void GetSettingsObjectPos()
	{
	}

	[Token(Token = "0x6000414")]
	[Address(RVA = "0x8E0518", Offset = "0x8E0518", VA = "0x8E0518")]
	private void GetConnectObjectPos()
	{
	}

	[Token(Token = "0x6000415")]
	[Address(RVA = "0x8E0654", Offset = "0x8E0654", VA = "0x8E0654")]
	private void GetHelpObjectPos()
	{
	}

	[Token(Token = "0x6000416")]
	[Address(RVA = "0x8E02AC", Offset = "0x8E02AC", VA = "0x8E02AC")]
	private void GetBGPos()
	{
	}

	[Token(Token = "0x6000417")]
	[Address(RVA = "0x8E10F0", Offset = "0x8E10F0", VA = "0x8E10F0")]
	public Vector3 GetGameObjectLTP(Vector3 position, float width, float height)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000418")]
	[Address(RVA = "0x8E1108", Offset = "0x8E1108", VA = "0x8E1108")]
	public Vector3 GetGameObjectRTP(Vector3 position, float width, float height)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000419")]
	[Address(RVA = "0x8E1120", Offset = "0x8E1120", VA = "0x8E1120")]
	public Vector3 GetGameObjectLBP(Vector3 position, float width, float height)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600041A")]
	[Address(RVA = "0x8E1138", Offset = "0x8E1138", VA = "0x8E1138")]
	public Vector3 GetGameObjectRBP(Vector3 position, float width, float height)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600041B")]
	[Address(RVA = "0x8E1150", Offset = "0x8E1150", VA = "0x8E1150")]
	public Vector3 GetGameObjectLTP(Vector3 position, Vector3 scale)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600041C")]
	[Address(RVA = "0x8E1168", Offset = "0x8E1168", VA = "0x8E1168")]
	public Vector3 GetGameObjectRTP(Vector3 position, Vector3 scale)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600041D")]
	[Address(RVA = "0x8E1180", Offset = "0x8E1180", VA = "0x8E1180")]
	public Vector3 GetGameObjectLBP(Vector3 position, Vector3 scale)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600041E")]
	[Address(RVA = "0x8E1198", Offset = "0x8E1198", VA = "0x8E1198")]
	public Vector3 GetGameObjectRBP(Vector3 position, Vector3 scale)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600041F")]
	[Address(RVA = "0x8E11B0", Offset = "0x8E11B0", VA = "0x8E11B0")]
	public Menu()
	{
	}
}
[Token(Token = "0x20000F3")]
[RequireComponent(typeof(Rigidbody))]
public class MenuGan : MonoBehaviour
{
	[Token(Token = "0x6000420")]
	[Address(RVA = "0x8E11B8", Offset = "0x8E11B8", VA = "0x8E11B8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000421")]
	[Address(RVA = "0x8E1214", Offset = "0x8E1214", VA = "0x8E1214")]
	private void Update()
	{
	}

	[Token(Token = "0x6000422")]
	[Address(RVA = "0x8E1218", Offset = "0x8E1218", VA = "0x8E1218")]
	public MenuGan()
	{
	}
}
[Token(Token = "0x20000F4")]
public class Player : MonoBehaviour
{
	[Token(Token = "0x40003E5")]
	public const float MAX_DISTANCE = 2.3f;

	[Token(Token = "0x40003E6")]
	public const float DEFAULT_DISTANCE = 1f;

	[Token(Token = "0x40003E7")]
	public const float MAX_HEIGHT = 0.2f;

	[Token(Token = "0x40003E8")]
	public const float MIN_HEIGHT = -0.95f;

	[Token(Token = "0x40003E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Camera Camera;

	[Token(Token = "0x40003EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject DeskCenter;

	[Token(Token = "0x40003EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float? lastCameraRotation;

	[Token(Token = "0x40003EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float distanceStep;

	[Token(Token = "0x40003ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private float heightStep;

	[Token(Token = "0x40003EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float curDistance;

	[Token(Token = "0x40003EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private bool lockByHand;

	[Token(Token = "0x40003F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Vector3 lockPos;

	[Token(Token = "0x40003F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private float lockFace;

	[Token(Token = "0x40003F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Gan gan;

	[Token(Token = "0x1700008C")]
	private GameObject WhiteBall
	{
		[Token(Token = "0x6000423")]
		[Address(RVA = "0x8E1220", Offset = "0x8E1220", VA = "0x8E1220")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700008D")]
	public Vector3 Position
	{
		[Token(Token = "0x6000426")]
		[Address(RVA = "0x8DC438", Offset = "0x8DC438", VA = "0x8DC438")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000427")]
		[Address(RVA = "0x8DC460", Offset = "0x8DC460", VA = "0x8DC460")]
		set
		{
		}
	}

	[Token(Token = "0x1700008E")]
	public Quaternion Rotation
	{
		[Token(Token = "0x600042A")]
		[Address(RVA = "0x8E1670", Offset = "0x8E1670", VA = "0x8E1670")]
		get
		{
			return default(Quaternion);
		}
	}

	[Token(Token = "0x1700008F")]
	public float Face
	{
		[Token(Token = "0x600042B")]
		[Address(RVA = "0x8E1698", Offset = "0x8E1698", VA = "0x8E1698")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600042C")]
		[Address(RVA = "0x8DC58C", Offset = "0x8DC58C", VA = "0x8DC58C")]
		set
		{
		}
	}

	[Token(Token = "0x6000424")]
	[Address(RVA = "0x8E134C", Offset = "0x8E134C", VA = "0x8E134C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000425")]
	[Address(RVA = "0x8E13F4", Offset = "0x8E13F4", VA = "0x8E13F4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000428")]
	[Address(RVA = "0x8E13F8", Offset = "0x8E13F8", VA = "0x8E13F8")]
	private void SetPosition(Vector3 value)
	{
	}

	[Token(Token = "0x6000429")]
	[Address(RVA = "0x8E15A0", Offset = "0x8E15A0", VA = "0x8E15A0")]
	public void GoBlackHome()
	{
	}

	[Token(Token = "0x600042D")]
	[Address(RVA = "0x8E16EC", Offset = "0x8E16EC", VA = "0x8E16EC")]
	private void SetFace(float value)
	{
	}

	[Token(Token = "0x600042E")]
	[Address(RVA = "0x8E1810", Offset = "0x8E1810", VA = "0x8E1810")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600042F")]
	[Address(RVA = "0x8E23E0", Offset = "0x8E23E0", VA = "0x8E23E0")]
	private void ChangeHight(float delta)
	{
	}

	[Token(Token = "0x6000430")]
	[Address(RVA = "0x8E2238", Offset = "0x8E2238", VA = "0x8E2238")]
	private void ChangeDistance(float delta)
	{
	}

	[Token(Token = "0x6000431")]
	[Address(RVA = "0x8E2460", Offset = "0x8E2460", VA = "0x8E2460")]
	private void ChangeDistanceTo(float distance)
	{
	}

	[Token(Token = "0x6000432")]
	[Address(RVA = "0x8E25E4", Offset = "0x8E25E4", VA = "0x8E25E4")]
	public void MoveToWhiteBall()
	{
	}

	[Token(Token = "0x6000433")]
	[Address(RVA = "0x8E2734", Offset = "0x8E2734", VA = "0x8E2734")]
	public void MoveToRest()
	{
	}

	[Token(Token = "0x6000434")]
	[Address(RVA = "0x8E292C", Offset = "0x8E292C", VA = "0x8E292C")]
	public void LockByHand(Vector3 pos, float face)
	{
	}

	[Token(Token = "0x6000435")]
	[Address(RVA = "0x8E2940", Offset = "0x8E2940", VA = "0x8E2940")]
	public void UnLockByHand()
	{
	}

	[Token(Token = "0x6000436")]
	[Address(RVA = "0x8E2948", Offset = "0x8E2948", VA = "0x8E2948")]
	public Player()
	{
	}
}
[Token(Token = "0x20000F6")]
public class Pocket : MonoBehaviour
{
	[Token(Token = "0x40003F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public PocketPos PocketPos;

	[Token(Token = "0x17000090")]
	public HashSet<Ball> BallList
	{
		[Token(Token = "0x6000439")]
		[Address(RVA = "0x8E2B74", Offset = "0x8E2B74", VA = "0x8E2B74")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000091")]
	public static Dictionary<PocketPos, Pocket> PocketList
	{
		[Token(Token = "0x600043A")]
		[Address(RVA = "0x8E2B7C", Offset = "0x8E2B7C", VA = "0x8E2B7C")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600043B")]
	[Address(RVA = "0x8E2BD4", Offset = "0x8E2BD4", VA = "0x8E2BD4")]
	private void Start()
	{
	}

	[Token(Token = "0x600043C")]
	[Address(RVA = "0x8E2C88", Offset = "0x8E2C88", VA = "0x8E2C88")]
	private void Update()
	{
	}

	[Token(Token = "0x600043D")]
	[Address(RVA = "0x8E2C8C", Offset = "0x8E2C8C", VA = "0x8E2C8C")]
	public Pocket()
	{
	}
}
[Token(Token = "0x20000F7")]
public enum PocketPos
{
	[Token(Token = "0x40003F9")]
	TopLeft,
	[Token(Token = "0x40003FA")]
	TopRight,
	[Token(Token = "0x40003FB")]
	MiddleLeft,
	[Token(Token = "0x40003FC")]
	MiddleRight,
	[Token(Token = "0x40003FD")]
	BottomLeft,
	[Token(Token = "0x40003FE")]
	BottomRight
}
[Token(Token = "0x20000F8")]
public class RandomRoom : Dialog
{
	[Token(Token = "0x40003FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Text Time;

	[Token(Token = "0x4000400")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private DateTime showTime;

	[Token(Token = "0x4000401")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private CancellationTokenSource cancellationToken;

	[Token(Token = "0x600043F")]
	[Address(RVA = "0x8E2DAC", Offset = "0x8E2DAC", VA = "0x8E2DAC")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000440")]
	[Address(RVA = "0x8E2E68", Offset = "0x8E2E68", VA = "0x8E2E68")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000441")]
	[Address(RVA = "0x8E304C", Offset = "0x8E304C", VA = "0x8E304C")]
	public void CloseClick()
	{
	}

	[Token(Token = "0x6000442")]
	[Address(RVA = "0x8E3128", Offset = "0x8E3128", VA = "0x8E3128")]
	private void CloseDialog()
	{
	}

	[Token(Token = "0x6000443")]
	[Address(RVA = "0x8E31F4", Offset = "0x8E31F4", VA = "0x8E31F4", Slot = "4")]
	public override void Close()
	{
	}

	[Token(Token = "0x6000444")]
	[Address(RVA = "0x8E31F8", Offset = "0x8E31F8", VA = "0x8E31F8")]
	public RandomRoom()
	{
	}
}
[Token(Token = "0x20000FA")]
public class Score : MonoBehaviour
{
	[Token(Token = "0x4000404")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TextMeshProUGUI LeftPlayerName;

	[Token(Token = "0x4000405")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TextMeshProUGUI RightPlayerName;

	[Token(Token = "0x4000406")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public TextMeshProUGUI LeftPlayerScore;

	[Token(Token = "0x4000407")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public TextMeshProUGUI RightPlayerScore;

	[Token(Token = "0x4000408")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject Small;

	[Token(Token = "0x4000409")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject Big;

	[Token(Token = "0x400040A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject Tag;

	[Token(Token = "0x400040B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject TagPos;

	[Token(Token = "0x400040C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private float TopY;

	[Token(Token = "0x400040D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private float BottomY;

	[Token(Token = "0x400040E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private int LeftScore;

	[Token(Token = "0x400040F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private int RightScore;

	[Token(Token = "0x4000410")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private bool IsShowBallScore;

	[Token(Token = "0x600044A")]
	[Address(RVA = "0x8E3798", Offset = "0x8E3798", VA = "0x8E3798")]
	private void Start()
	{
	}

	[Token(Token = "0x600044B")]
	[Address(RVA = "0x8D9760", Offset = "0x8D9760", VA = "0x8D9760")]
	public void ResetScore()
	{
	}

	[Token(Token = "0x600044C")]
	[Address(RVA = "0x8E37D4", Offset = "0x8E37D4", VA = "0x8E37D4")]
	private void Update()
	{
	}

	[Token(Token = "0x600044D")]
	[Address(RVA = "0x8E46E0", Offset = "0x8E46E0", VA = "0x8E46E0")]
	public void HideBall(string name)
	{
	}

	[Token(Token = "0x600044E")]
	[Address(RVA = "0x8E379C", Offset = "0x8E379C", VA = "0x8E379C")]
	private void HideAllBall()
	{
	}

	[Token(Token = "0x600044F")]
	[Address(RVA = "0x8E41F0", Offset = "0x8E41F0", VA = "0x8E41F0")]
	private void Show8()
	{
	}

	[Token(Token = "0x6000450")]
	[Address(RVA = "0x8E3F5C", Offset = "0x8E3F5C", VA = "0x8E3F5C")]
	public void ShowBallScore(bool isBigTop)
	{
	}

	[Token(Token = "0x6000451")]
	[Address(RVA = "0x8E4650", Offset = "0x8E4650", VA = "0x8E4650")]
	public void UpdateLeftScore(int score)
	{
	}

	[Token(Token = "0x6000452")]
	[Address(RVA = "0x8E4698", Offset = "0x8E4698", VA = "0x8E4698")]
	public void UpdateRightScore(int score)
	{
	}

	[Token(Token = "0x6000453")]
	[Address(RVA = "0x8E47E8", Offset = "0x8E47E8", VA = "0x8E47E8")]
	public Score()
	{
	}
}
[Token(Token = "0x20000FB")]
public class SettingsDialog : Dialog
{
	[StructLayout(3)]
	[Token(Token = "0x20000FC")]
	[CompilerGenerated]
	private struct <CheckMrButton>d__19 : IAsyncStateMachine
	{
		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public SettingsDialog <>4__this;

		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TaskAwaiter <>u__1;

		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TaskAwaiter<VoidData> <>u__2;

		[Token(Token = "0x600046F")]
		[Address(RVA = "0x8E6964", Offset = "0x8E6964", VA = "0x8E6964", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0x8E6CEC", Offset = "0x8E6CEC", VA = "0x8E6CEC", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x20000FD")]
	[CompilerGenerated]
	private struct <CheckMrButtonInner>d__20 : IAsyncStateMachine
	{
		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InputHelpers.Button[] buttons;

		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public SettingsDialog <>4__this;

		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private InputHelpers.Button[] <>7__wrap1;

		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int <>7__wrap2;

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TaskAwaiter<bool> <>u__1;

		[Token(Token = "0x6000471")]
		[Address(RVA = "0x8E6CF8", Offset = "0x8E6CF8", VA = "0x8E6CF8", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x8E6F84", Offset = "0x8E6F84", VA = "0x8E6F84", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x20000FE")]
	[CompilerGenerated]
	private sealed class <>c__DisplayClass21_0
	{
		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool result;

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public InputHelpers.Button button;

		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float stime;

		[Token(Token = "0x6000473")]
		[Address(RVA = "0x8E6F90", Offset = "0x8E6F90", VA = "0x8E6F90")]
		public <>c__DisplayClass21_0()
		{
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0x8E6F98", Offset = "0x8E6F98", VA = "0x8E6F98")]
		internal bool <WaitButton>b__0()
		{
			return default(bool);
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x8E7020", Offset = "0x8E7020", VA = "0x8E7020")]
		internal bool <WaitButton>b__1()
		{
			return default(bool);
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x20000FF")]
	[CompilerGenerated]
	private struct <WaitButton>d__21 : IAsyncStateMachine
	{
		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InputHelpers.Button button;

		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private <>c__DisplayClass21_0 <>8__1;

		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TaskAwaiter<VoidData> <>u__1;

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x8E7074", Offset = "0x8E7074", VA = "0x8E7074", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x8E74B4", Offset = "0x8E74B4", VA = "0x8E74B4", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x2000100")]
	[CompilerGenerated]
	private struct <SetMR>d__33 : IAsyncStateMachine
	{
		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public SettingsDialog <>4__this;

		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TaskAwaiter <>u__1;

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x8E750C", Offset = "0x8E750C", VA = "0x8E750C", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0x8E7BEC", Offset = "0x8E7BEC", VA = "0x8E7BEC", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x4000411")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject GameTypeObj;

	[Token(Token = "0x4000412")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject GameModelObj;

	[Token(Token = "0x4000413")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject DefaultHandObj;

	[Token(Token = "0x4000414")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject GameSoundObj;

	[Token(Token = "0x4000415")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject HowToPlayObj;

	[Token(Token = "0x4000416")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject MRSelect;

	[Token(Token = "0x4000417")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject DialogObj;

	[Token(Token = "0x4000418")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject GuideDialog;

	[Token(Token = "0x4000419")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject MRObj;

	[Token(Token = "0x400041A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public GameObject RestTableObj;

	[Token(Token = "0x400041B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Transform TypeSelect;

	[Token(Token = "0x400041C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Transform ModelSelect;

	[Token(Token = "0x400041D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Transform HandSelect;

	[Token(Token = "0x400041E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Transform SoundSelect;

	[Token(Token = "0x400041F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private bool curMRState;

	[Token(Token = "0x4000420")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
	private bool mrChecking;

	[Token(Token = "0x6000456")]
	[Address(RVA = "0x8E491C", Offset = "0x8E491C", VA = "0x8E491C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000457")]
	[Address(RVA = "0x8E4BB8", Offset = "0x8E4BB8", VA = "0x8E4BB8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000458")]
	[Address(RVA = "0x8E52D8", Offset = "0x8E52D8", VA = "0x8E52D8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000459")]
	[Address(RVA = "0x8E52DC", Offset = "0x8E52DC", VA = "0x8E52DC")]
	[AsyncStateMachine(typeof(<CheckMrButton>d__19))]
	private void CheckMrButton()
	{
	}

	[Token(Token = "0x600045A")]
	[Address(RVA = "0x8E5390", Offset = "0x8E5390", VA = "0x8E5390")]
	[AsyncStateMachine(typeof(<CheckMrButtonInner>d__20))]
	private System.Threading.Tasks.Task CheckMrButtonInner(InputHelpers.Button[] buttons)
	{
		return null;
	}

	[Token(Token = "0x600045B")]
	[Address(RVA = "0x8E5494", Offset = "0x8E5494", VA = "0x8E5494")]
	[AsyncStateMachine(typeof(<WaitButton>d__21))]
	private System.Threading.Tasks.Task<bool> WaitButton(InputHelpers.Button button)
	{
		return null;
	}

	[Token(Token = "0x600045C")]
	[Address(RVA = "0x8E55A0", Offset = "0x8E55A0", VA = "0x8E55A0")]
	public void SetGameType(int type)
	{
	}

	[Token(Token = "0x600045D")]
	[Address(RVA = "0x8E562C", Offset = "0x8E562C", VA = "0x8E562C")]
	public void GameModelLevel(int aILevel)
	{
	}

	[Token(Token = "0x600045E")]
	[Address(RVA = "0x8E59D0", Offset = "0x8E59D0", VA = "0x8E59D0")]
	public void HandLeft()
	{
	}

	[Token(Token = "0x600045F")]
	[Address(RVA = "0x8E5BA8", Offset = "0x8E5BA8", VA = "0x8E5BA8")]
	public void HandRight()
	{
	}

	[Token(Token = "0x6000460")]
	[Address(RVA = "0x8E5D80", Offset = "0x8E5D80", VA = "0x8E5D80")]
	public void GameSoundRealTime()
	{
	}

	[Token(Token = "0x6000461")]
	[Address(RVA = "0x8E5EA0", Offset = "0x8E5EA0", VA = "0x8E5EA0")]
	public void GameSoundPressKey()
	{
	}

	[Token(Token = "0x6000462")]
	[Address(RVA = "0x8E4D58", Offset = "0x8E4D58", VA = "0x8E4D58")]
	public void InitGameModelSelect(AILevel aILevel)
	{
	}

	[Token(Token = "0x6000463")]
	[Address(RVA = "0x8E4EEC", Offset = "0x8E4EEC", VA = "0x8E4EEC")]
	public void InitGameSoundSelect(bool alwaysVoice)
	{
	}

	[Token(Token = "0x6000464")]
	[Address(RVA = "0x8E52B8", Offset = "0x8E52B8", VA = "0x8E52B8")]
	public void InitMR(bool mrMode)
	{
	}

	[Token(Token = "0x6000465")]
	[Address(RVA = "0x8E4FF4", Offset = "0x8E4FF4", VA = "0x8E4FF4")]
	public void InitGameType(GameType gameType)
	{
	}

	[Token(Token = "0x6000466")]
	[Address(RVA = "0x8E517C", Offset = "0x8E517C", VA = "0x8E517C")]
	public void InitGameDefaultHand(DefaultHand defaultHand)
	{
	}

	[Token(Token = "0x6000467")]
	[Address(RVA = "0x8E5FBC", Offset = "0x8E5FBC", VA = "0x8E5FBC")]
	[AsyncStateMachine(typeof(<SetMR>d__33))]
	public void SetMR()
	{
	}

	[Token(Token = "0x6000468")]
	[Address(RVA = "0x8E6074", Offset = "0x8E6074", VA = "0x8E6074")]
	public void Guide()
	{
	}

	[Token(Token = "0x6000469")]
	[Address(RVA = "0x8E61D0", Offset = "0x8E61D0", VA = "0x8E61D0")]
	public void ShowConnectDialog()
	{
	}

	[Token(Token = "0x600046A")]
	[Address(RVA = "0x8E63AC", Offset = "0x8E63AC", VA = "0x8E63AC")]
	public void ShowRules()
	{
	}

	[Token(Token = "0x600046B")]
	[Address(RVA = "0x8E6508", Offset = "0x8E6508", VA = "0x8E6508")]
	public void ShowRestTable()
	{
	}

	[Token(Token = "0x600046C")]
	[Address(RVA = "0x8E65B0", Offset = "0x8E65B0", VA = "0x8E65B0")]
	public void StartGame()
	{
	}

	[Token(Token = "0x600046D")]
	[Address(RVA = "0x8E6784", Offset = "0x8E6784", VA = "0x8E6784", Slot = "4")]
	public override void Close()
	{
	}

	[Token(Token = "0x600046E")]
	[Address(RVA = "0x8E695C", Offset = "0x8E695C", VA = "0x8E695C")]
	public SettingsDialog()
	{
	}
}
[Token(Token = "0x2000101")]
public class DeviceAdapter : MonoBehaviour
{
	[Token(Token = "0x4000439")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject Qiyu;

	[Token(Token = "0x400043A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject Pico3;

	[Token(Token = "0x400043B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject Pico4;

	[Token(Token = "0x600047A")]
	[Address(RVA = "0x8E7BF8", Offset = "0x8E7BF8", VA = "0x8E7BF8")]
	private void Start()
	{
	}

	[Token(Token = "0x600047B")]
	[Address(RVA = "0x8E7C34", Offset = "0x8E7C34", VA = "0x8E7C34")]
	public DeviceAdapter()
	{
	}
}
[Token(Token = "0x2000102")]
public static class PicoTaskExtend
{
	[Token(Token = "0x600047C")]
	public static TaskAwaiter<T> GetAwaiter<T>(this Pico.Platform.Task<T> taskInstance)
	{
		return default(TaskAwaiter<T>);
	}
}
[Token(Token = "0x2000104")]
public abstract class PlatformAdapter
{
	[Token(Token = "0x2000105")]
	protected class PicoPlatformAdapter : PlatformAdapter
	{
		[StructLayout(3)]
		[Token(Token = "0x2000106")]
		[CompilerGenerated]
		private struct <Login>d__1 : IAsyncStateMachine
		{
			[Token(Token = "0x400043F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000440")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<bool> <>t__builder;

			[Token(Token = "0x4000441")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private TaskAwaiter<User> <>u__1;

			[Token(Token = "0x4000442")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private TaskAwaiter<BaseResponse<string>> <>u__2;

			[Token(Token = "0x6000486")]
			[Address(RVA = "0x8E7F28", Offset = "0x8E7F28", VA = "0x8E7F28", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000487")]
			[Address(RVA = "0x8E8324", Offset = "0x8E8324", VA = "0x8E8324", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0x8E7DD0", Offset = "0x8E7DD0", VA = "0x8E7DD0")]
		public PicoPlatformAdapter()
		{
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0x8E7E30", Offset = "0x8E7E30", VA = "0x8E7E30", Slot = "4")]
		[AsyncStateMachine(typeof(<Login>d__1))]
		public override System.Threading.Tasks.Task<bool> Login()
		{
			return null;
		}
	}

	[Token(Token = "0x2000107")]
	protected class TestPlatformAdapter : PlatformAdapter
	{
		[StructLayout(3)]
		[Token(Token = "0x2000108")]
		[CompilerGenerated]
		private struct <Login>d__1 : IAsyncStateMachine
		{
			[Token(Token = "0x4000443")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000444")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<bool> <>t__builder;

			[Token(Token = "0x4000445")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private TaskAwaiter<BaseResponse<string>> <>u__1;

			[Token(Token = "0x600048A")]
			[Address(RVA = "0x8E84CC", Offset = "0x8E84CC", VA = "0x8E84CC", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x600048B")]
			[Address(RVA = "0x8E8764", Offset = "0x8E8764", VA = "0x8E8764", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0x8E837C", Offset = "0x8E837C", VA = "0x8E837C")]
		public TestPlatformAdapter()
		{
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0x8E83D4", Offset = "0x8E83D4", VA = "0x8E83D4", Slot = "4")]
		[AsyncStateMachine(typeof(<Login>d__1))]
		public override System.Threading.Tasks.Task<bool> Login()
		{
			return null;
		}
	}

	[Token(Token = "0x400043E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static bool isInit;

	[Token(Token = "0x17000092")]
	public static PlatformAdapter Instance
	{
		[Token(Token = "0x600047F")]
		[Address(RVA = "0x8E7C3C", Offset = "0x8E7C3C", VA = "0x8E7C3C")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000480")]
		[Address(RVA = "0x8E7C94", Offset = "0x8E7C94", VA = "0x8E7C94")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x6000481")]
	[Address(RVA = "0x8E7CFC", Offset = "0x8E7CFC", VA = "0x8E7CFC")]
	static PlatformAdapter()
	{
	}

	[Token(Token = "0x6000482")]
	public abstract System.Threading.Tasks.Task<bool> Login();

	[Token(Token = "0x6000483")]
	[Address(RVA = "0x8E7E28", Offset = "0x8E7E28", VA = "0x8E7E28")]
	protected PlatformAdapter()
	{
	}
}
[Token(Token = "0x2000109")]
public class ChineseEightBallAI : ChineseEightBallPlayer
{
	[Token(Token = "0x200010A")]
	private class HitRange
	{
		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static HitRange unreachable;

		[Token(Token = "0x17000097")]
		public Angle MinAngle
		{
			[Token(Token = "0x60004BB")]
			[Address(RVA = "0x8F1F50", Offset = "0x8F1F50", VA = "0x8F1F50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60004BC")]
			[Address(RVA = "0x8F1F58", Offset = "0x8F1F58", VA = "0x8F1F58")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000098")]
		public Angle MaxAngle
		{
			[Token(Token = "0x60004BD")]
			[Address(RVA = "0x8F1F60", Offset = "0x8F1F60", VA = "0x8F1F60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60004BE")]
			[Address(RVA = "0x8F1F68", Offset = "0x8F1F68", VA = "0x8F1F68")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000099")]
		public float PocketDistance
		{
			[Token(Token = "0x60004BF")]
			[Address(RVA = "0x8F1F70", Offset = "0x8F1F70", VA = "0x8F1F70")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60004C0")]
			[Address(RVA = "0x8F1F78", Offset = "0x8F1F78", VA = "0x8F1F78")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700009A")]
		public BounceDirect BounceDirect
		{
			[Token(Token = "0x60004C1")]
			[Address(RVA = "0x8F1F80", Offset = "0x8F1F80", VA = "0x8F1F80")]
			[CompilerGenerated]
			get
			{
				return default(BounceDirect);
			}
			[Token(Token = "0x60004C2")]
			[Address(RVA = "0x8F1F88", Offset = "0x8F1F88", VA = "0x8F1F88")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700009B")]
		public bool CanHit
		{
			[Token(Token = "0x60004C3")]
			[Address(RVA = "0x8F1F90", Offset = "0x8F1F90", VA = "0x8F1F90")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004C4")]
			[Address(RVA = "0x8F1F98", Offset = "0x8F1F98", VA = "0x8F1F98")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700009C")]
		public static HitRange Unreachable
		{
			[Token(Token = "0x60004C5")]
			[Address(RVA = "0x8F1FA4", Offset = "0x8F1FA4", VA = "0x8F1FA4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x8F1AE4", Offset = "0x8F1AE4", VA = "0x8F1AE4")]
		static HitRange()
		{
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x8F1B54", Offset = "0x8F1B54", VA = "0x8F1B54")]
		private HitRange()
		{
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x8F1B5C", Offset = "0x8F1B5C", VA = "0x8F1B5C")]
		public HitRange(Angle minAngle, Angle maxAngle)
		{
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x8F1BAC", Offset = "0x8F1BAC", VA = "0x8F1BAC")]
		public HitRange(Angle minAngle, Angle maxAngle, float pocketDistance)
		{
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x8F1BD0", Offset = "0x8F1BD0", VA = "0x8F1BD0")]
		public HitRange(Angle minAngle, Angle maxAngle, BounceDirect bounceDirect)
		{
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x8F1BF4", Offset = "0x8F1BF4", VA = "0x8F1BF4")]
		public HitRange(Angle minAngle, Angle maxAngle, float pocketDistance, BounceDirect bounceDirect)
		{
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x8F1C28", Offset = "0x8F1C28", VA = "0x8F1C28")]
		public HitRange Mirror()
		{
			return null;
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x8F1DBC", Offset = "0x8F1DBC", VA = "0x8F1DBC")]
		public static HitRange operator *(HitRange a, HitRange b)
		{
			return null;
		}
	}

	[Token(Token = "0x200010B")]
	private enum BounceDirect
	{
		[Token(Token = "0x4000464")]
		None,
		[Token(Token = "0x4000465")]
		Top,
		[Token(Token = "0x4000466")]
		Bottom,
		[Token(Token = "0x4000467")]
		Left,
		[Token(Token = "0x4000468")]
		Right
	}

	[Token(Token = "0x2000112")]
	[CompilerGenerated]
	private sealed class <AvilableBallList>d__56 : IEnumerable<ChineseEightBall>, IEnumerable, IEnumerator<ChineseEightBall>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private ChineseEightBall <>2__current;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int <>l__initialThreadId;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ChineseEightBallAI <>4__this;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private IEnumerator<ChineseEightBall> <>7__wrap1;

		[Token(Token = "0x1700009D")]
		private ChineseEightBall System.Collections.Generic.IEnumerator<ChineseEightBall>.Current
		{
			[Token(Token = "0x60004E2")]
			[Address(RVA = "0x8F3BA8", Offset = "0x8F3BA8", VA = "0x8F3BA8", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60004E4")]
			[Address(RVA = "0x8F3BF0", Offset = "0x8F3BF0", VA = "0x8F3BF0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x8F2FA0", Offset = "0x8F2FA0", VA = "0x8F2FA0")]
		[DebuggerHidden]
		public <AvilableBallList>d__56(int <>1__state)
		{
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x8F2FD4", Offset = "0x8F2FD4", VA = "0x8F2FD4", Slot = "7")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x8F3028", Offset = "0x8F3028", VA = "0x8F3028", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x8F3998", Offset = "0x8F3998", VA = "0x8F3998")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x8F3A48", Offset = "0x8F3A48", VA = "0x8F3A48")]
		private void <>m__Finally2()
		{
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x8F3AF8", Offset = "0x8F3AF8", VA = "0x8F3AF8")]
		private void <>m__Finally3()
		{
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x8F3BB0", Offset = "0x8F3BB0", VA = "0x8F3BB0", Slot = "10")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x8F3BF8", Offset = "0x8F3BF8", VA = "0x8F3BF8", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<ChineseEightBall> System.Collections.Generic.IEnumerable<ChineseEightBall>.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x8F3CA4", Offset = "0x8F3CA4", VA = "0x8F3CA4", Slot = "5")]
		[DebuggerHidden]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Token(Token = "0x4000446")]
	private const float DELTA_X1 = 0.6778f;

	[Token(Token = "0x4000447")]
	private const float DELTA_Y1 = 1.2805f;

	[Token(Token = "0x4000448")]
	private const float DELTA_X2 = 0.6454f;

	[Token(Token = "0x4000449")]
	private const float DELTA_Y2 = 1.2508f;

	[Token(Token = "0x400044A")]
	private const float DELTA_X3 = 0.6249f;

	[Token(Token = "0x400044B")]
	private const float DELTA_Y3 = 1.33f;

	[Token(Token = "0x400044C")]
	private const float DELTA_X4 = 0.6018f;

	[Token(Token = "0x400044D")]
	private const float DELTA_Y4 = 1.3f;

	[Token(Token = "0x400044E")]
	private const float DELTA_X5 = 0.68f;

	[Token(Token = "0x400044F")]
	private const float DELTA_X6 = 0.65f;

	[Token(Token = "0x4000450")]
	private const float DELTA_Y5 = 0.0346f;

	[Token(Token = "0x4000451")]
	private const float DELTA_Y6 = 0.05f;

	[Token(Token = "0x4000452")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Vector3[] MODEL_POS;

	[Token(Token = "0x4000453")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Vector3[] MODEL_POS2;

	[Token(Token = "0x4000454")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Dictionary<PocketPos, Vector2[]> pocketPoints;

	[Token(Token = "0x4000455")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Dictionary<BounceDirect, float> bounceLines;

	[Token(Token = "0x4000456")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Array pocketPosList;

	[Token(Token = "0x4000457")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private IEnumerable<BounceDirect> bounceDirectList;

	[Token(Token = "0x4000458")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private bool active;

	[Token(Token = "0x4000459")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static float pointClosedDistance;

	[Token(Token = "0x400045A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private AIModel AIModel;

	[Token(Token = "0x400045B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private bool moving;

	[Token(Token = "0x17000093")]
	public override bool DoubleHit
	{
		[Token(Token = "0x600048C")]
		[Address(RVA = "0x8E87BC", Offset = "0x8E87BC", VA = "0x8E87BC", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000094")]
	public override Ball FirstHitBall
	{
		[Token(Token = "0x600048D")]
		[Address(RVA = "0x8E87C4", Offset = "0x8E87C4", VA = "0x8E87C4", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000095")]
	private AILevel AILevel
	{
		[Token(Token = "0x600048E")]
		[Address(RVA = "0x8E8818", Offset = "0x8E8818", VA = "0x8E8818")]
		get
		{
			return default(AILevel);
		}
	}

	[Token(Token = "0x17000096")]
	private Vector2 CenterPos
	{
		[Token(Token = "0x600048F")]
		[Address(RVA = "0x8E88A0", Offset = "0x8E88A0", VA = "0x8E88A0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Token(Token = "0x6000490")]
		[Address(RVA = "0x8E88A8", Offset = "0x8E88A8", VA = "0x8E88A8")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x6000491")]
	[Address(RVA = "0x8E88B0", Offset = "0x8E88B0", VA = "0x8E88B0", Slot = "14")]
	public override void ActivePlayer()
	{
	}

	[Token(Token = "0x6000492")]
	[Address(RVA = "0x8E88BC", Offset = "0x8E88BC", VA = "0x8E88BC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000493")]
	[Address(RVA = "0x8E9A94", Offset = "0x8E9A94", VA = "0x8E9A94")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000494")]
	[Address(RVA = "0x8E98CC", Offset = "0x8E98CC", VA = "0x8E98CC")]
	private void InitBounds()
	{
	}

	[Token(Token = "0x6000495")]
	[Address(RVA = "0x8E8DB4", Offset = "0x8E8DB4", VA = "0x8E8DB4")]
	private void InitPocketPoints()
	{
	}

	[Token(Token = "0x6000496")]
	[Address(RVA = "0x8E9B08", Offset = "0x8E9B08", VA = "0x8E9B08")]
	private Vector2[] GetPocketPoint(PocketPos pos)
	{
		return null;
	}

	[Token(Token = "0x6000497")]
	[Address(RVA = "0x8E9B60", Offset = "0x8E9B60", VA = "0x8E9B60")]
	private Vector2 GetMirrorPoint(Vector2 point, BounceDirect direct)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000498")]
	[Address(RVA = "0x8E9C14", Offset = "0x8E9C14", VA = "0x8E9C14")]
	private Vector3 GetMirrorPoint(Vector3 point, BounceDirect direct)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000499")]
	[Address(RVA = "0x8E9CD8", Offset = "0x8E9CD8", VA = "0x8E9CD8")]
	private void HitBall(Vector3 force, float vPos = 0f, float hPos = 0f)
	{
	}

	[Token(Token = "0x600049A")]
	[Address(RVA = "0x8EA1C4", Offset = "0x8EA1C4", VA = "0x8EA1C4")]
	private Vector3 GenerateHitPosition(Vector3 force, float vPos = 0f, float hPos = 0f)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600049B")]
	[Address(RVA = "0x8EA428", Offset = "0x8EA428", VA = "0x8EA428")]
	private Vector2 GetCanHitPoint(Vector2 fromPos, Vector2 targetPos, Angle angle)
	{
		return default(Vector2);
	}

	[Token(Token = "0x600049C")]
	[Address(RVA = "0x8EA6DC", Offset = "0x8EA6DC", VA = "0x8EA6DC")]
	private HitRange CanHit(ChineseEightBall ball, List<ChineseEightBall> liveBallList)
	{
		return null;
	}

	[Token(Token = "0x600049D")]
	[Address(RVA = "0x8EC0F4", Offset = "0x8EC0F4", VA = "0x8EC0F4")]
	private Vector2 GetBorderPoint(Vector2 point1, Vector2 point2, BounceDirect direct)
	{
		return default(Vector2);
	}

	[Token(Token = "0x600049E")]
	[Address(RVA = "0x8EC1B8", Offset = "0x8EC1B8", VA = "0x8EC1B8")]
	private HitRange CanHitByBounce(ChineseEightBall ball, List<ChineseEightBall> liveBallList, BounceDirect direct)
	{
		return null;
	}

	[Token(Token = "0x600049F")]
	[Address(RVA = "0x8EC444", Offset = "0x8EC444", VA = "0x8EC444")]
	private HitRange CanHitByPoint(ChineseEightBall ball, List<ChineseEightBall> liveBallList, Vector2 pBall, Vector2 pWhite, BounceDirect direct, bool mirrorBall = false)
	{
		return null;
	}

	[Token(Token = "0x60004A0")]
	[Address(RVA = "0x8EC0E0", Offset = "0x8EC0E0", VA = "0x8EC0E0")]
	private Angle Rotate180(Angle angle)
	{
		return null;
	}

	[Token(Token = "0x60004A1")]
	[Address(RVA = "0x8ED728", Offset = "0x8ED728", VA = "0x8ED728")]
	private void Update()
	{
	}

	[Token(Token = "0x60004A2")]
	[Address(RVA = "0x8EDFA0", Offset = "0x8EDFA0", VA = "0x8EDFA0")]
	private bool WhiteWillInPocket(ChineseEightBall ball, Vector3 point)
	{
		return default(bool);
	}

	[Token(Token = "0x60004A3")]
	[Address(RVA = "0x8EE7B8", Offset = "0x8EE7B8", VA = "0x8EE7B8")]
	private void ChooseAndHitBall()
	{
	}

	[Token(Token = "0x60004A4")]
	[Address(RVA = "0x8EBFA4", Offset = "0x8EBFA4", VA = "0x8EBFA4")]
	private Angle GetSignedAngle(Vector2 vector)
	{
		return null;
	}

	[Token(Token = "0x60004A5")]
	[Address(RVA = "0x8F04F4", Offset = "0x8F04F4", VA = "0x8F04F4")]
	private HitRange GetPocketAngle(ChineseEightBall ball, List<ChineseEightBall> liveBallList, PocketPos pocketPos, HitRange hitRange)
	{
		return null;
	}

	[Token(Token = "0x60004A6")]
	[Address(RVA = "0x8F0F80", Offset = "0x8F0F80", VA = "0x8F0F80")]
	private Vector3 GetHitPoint(ChineseEightBall ball, Angle angle)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60004A7")]
	[Address(RVA = "0x8F1094", Offset = "0x8F1094", VA = "0x8F1094")]
	private float DistanceToForce(float distance)
	{
		return default(float);
	}

	[Token(Token = "0x60004A8")]
	[Address(RVA = "0x8F10A4", Offset = "0x8F10A4", VA = "0x8F10A4")]
	private Vector3 GenerateForce(ChineseEightBall ball, Vector3 point, HitRange hitRange)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60004A9")]
	[Address(RVA = "0x8F0480", Offset = "0x8F0480", VA = "0x8F0480")]
	[IteratorStateMachine(typeof(<AvilableBallList>d__56))]
	private IEnumerable<ChineseEightBall> AvilableBallList()
	{
		return null;
	}

	[Token(Token = "0x60004AA")]
	[Address(RVA = "0x8F14B8", Offset = "0x8F14B8", VA = "0x8F14B8", Slot = "13")]
	public override void MoveToRest()
	{
	}

	[Token(Token = "0x60004AB")]
	[Address(RVA = "0x8F1604", Offset = "0x8F1604", VA = "0x8F1604")]
	public ChineseEightBallAI()
	{
	}
}
[Token(Token = "0x2000113")]
public class ChineseEightBallCRemotePlayer : ChineseEightBallRemotePlayer
{
	[Token(Token = "0x60004E7")]
	[Address(RVA = "0x8F3CA8", Offset = "0x8F3CA8", VA = "0x8F3CA8")]
	private void Start()
	{
	}

	[Token(Token = "0x60004E8")]
	[Address(RVA = "0x8F46F4", Offset = "0x8F46F4", VA = "0x8F46F4", Slot = "17")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x60004E9")]
	[Address(RVA = "0x8F4868", Offset = "0x8F4868", VA = "0x8F4868")]
	private void Update()
	{
	}

	[Token(Token = "0x60004EA")]
	[Address(RVA = "0x8F486C", Offset = "0x8F486C", VA = "0x8F486C")]
	public ChineseEightBallCRemotePlayer()
	{
	}
}
[Token(Token = "0x2000117")]
public class ChineseEightBallLocalPlayer : ChineseEightBallPlayer
{
	[Token(Token = "0x400049E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private GanHand ganHand;

	[Token(Token = "0x400049F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Gan gan;

	[Token(Token = "0x40004A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Activation activation;

	[Token(Token = "0x40004A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private bool hasActivationShow;

	[Token(Token = "0x40004A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private float ballMoveSpeed;

	[Token(Token = "0x40004A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Vector2 lastStickPos;

	[Token(Token = "0x40004A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private bool active;

	[Token(Token = "0x40004A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
	private bool primaryBtnDown;

	[Token(Token = "0x1700009F")]
	public override bool DoubleHit
	{
		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x8F57C4", Offset = "0x8F57C4", VA = "0x8F57C4", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170000A0")]
	public override Ball FirstHitBall
	{
		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x8F57E0", Offset = "0x8F57E0", VA = "0x8F57E0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000A1")]
	public override bool BodyHit
	{
		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x8F57FC", Offset = "0x8F57FC", VA = "0x8F57FC", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170000A2")]
	public Action<int> ScoreAction
	{
		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x8F5818", Offset = "0x8F5818", VA = "0x8F5818")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000500")]
		[Address(RVA = "0x8F5820", Offset = "0x8F5820", VA = "0x8F5820")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170000A3")]
	public override bool IsActive
	{
		[Token(Token = "0x6000502")]
		[Address(RVA = "0x8F5850", Offset = "0x8F5850", VA = "0x8F5850", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170000A4")]
	public override int Score
	{
		[Token(Token = "0x6000503")]
		[Address(RVA = "0x8F5858", Offset = "0x8F5858", VA = "0x8F5858", Slot = "8")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000504")]
		[Address(RVA = "0x8F5860", Offset = "0x8F5860", VA = "0x8F5860", Slot = "7")]
		set
		{
		}
	}

	[Token(Token = "0x6000501")]
	[Address(RVA = "0x8F5828", Offset = "0x8F5828", VA = "0x8F5828", Slot = "16")]
	public override void Init(List<ChineseEightBall> ballList)
	{
	}

	[Token(Token = "0x6000505")]
	[Address(RVA = "0x8F5880", Offset = "0x8F5880", VA = "0x8F5880")]
	public ChineseEightBallLocalPlayer()
	{
	}

	[Token(Token = "0x6000506")]
	[Address(RVA = "0x8F5A40", Offset = "0x8F5A40", VA = "0x8F5A40")]
	private void Update()
	{
	}

	[Token(Token = "0x6000507")]
	[Address(RVA = "0x8F6D58", Offset = "0x8F6D58", VA = "0x8F6D58")]
	private void AfterGanHit()
	{
	}

	[Token(Token = "0x6000508")]
	[Address(RVA = "0x8F6DA8", Offset = "0x8F6DA8", VA = "0x8F6DA8", Slot = "11")]
	public override void ShowMsg(string msg, bool keep = false)
	{
	}

	[Token(Token = "0x6000509")]
	[Address(RVA = "0x8F6E10", Offset = "0x8F6E10", VA = "0x8F6E10", Slot = "12")]
	public override void MoveToWhiteBall()
	{
	}

	[Token(Token = "0x600050A")]
	[Address(RVA = "0x8F6EAC", Offset = "0x8F6EAC", VA = "0x8F6EAC", Slot = "14")]
	public override void ActivePlayer()
	{
	}

	[Token(Token = "0x600050B")]
	[Address(RVA = "0x8F6EB8", Offset = "0x8F6EB8", VA = "0x8F6EB8", Slot = "13")]
	public override void MoveToRest()
	{
	}
}
[Token(Token = "0x2000118")]
public abstract class ChineseEightBallPlayer : MonoBehaviour
{
	[Token(Token = "0x40004A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private List<ChineseEightBall> ballList;

	[Token(Token = "0x170000A5")]
	public Action<ChineseEightBallPlayer> ActionAfterGanHit
	{
		[Token(Token = "0x600050C")]
		[Address(RVA = "0x8F6F54", Offset = "0x8F6F54", VA = "0x8F6F54")]
		[CompilerGenerated]
		private get
		{
			return null;
		}
		[Token(Token = "0x600050D")]
		[Address(RVA = "0x8F6F5C", Offset = "0x8F6F5C", VA = "0x8F6F5C")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170000A6")]
	public virtual bool DoubleHit
	{
		[Token(Token = "0x600050E")]
		[Address(RVA = "0x8F6F64", Offset = "0x8F6F64", VA = "0x8F6F64", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170000A7")]
	public virtual Ball FirstHitBall
	{
		[Token(Token = "0x600050F")]
		[Address(RVA = "0x8F6F6C", Offset = "0x8F6F6C", VA = "0x8F6F6C", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000A8")]
	public virtual bool BodyHit
	{
		[Token(Token = "0x6000510")]
		[Address(RVA = "0x8F6F74", Offset = "0x8F6F74", VA = "0x8F6F74", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170000A9")]
	public virtual int Score
	{
		[Token(Token = "0x6000512")]
		[Address(RVA = "0x8F6F84", Offset = "0x8F6F84", VA = "0x8F6F84", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000511")]
		[Address(RVA = "0x8F6F7C", Offset = "0x8F6F7C", VA = "0x8F6F7C", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170000AA")]
	public virtual BallType BallType
	{
		[Token(Token = "0x6000513")]
		[Address(RVA = "0x8F6F8C", Offset = "0x8F6F8C", VA = "0x8F6F8C", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return default(BallType);
		}
		[Token(Token = "0x6000514")]
		[Address(RVA = "0x8F6F94", Offset = "0x8F6F94", VA = "0x8F6F94", Slot = "10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170000AB")]
	public virtual bool IsActive
	{
		[Token(Token = "0x6000519")]
		[Address(RVA = "0x8F6FAC", Offset = "0x8F6FAC", VA = "0x8F6FAC", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170000AC")]
	protected List<ChineseEightBall> BallList
	{
		[Token(Token = "0x600051B")]
		[Address(RVA = "0x8F6FBC", Offset = "0x8F6FBC", VA = "0x8F6FBC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000515")]
	[Address(RVA = "0x8F6F9C", Offset = "0x8F6F9C", VA = "0x8F6F9C", Slot = "11")]
	public virtual void ShowMsg(string msg, bool keep = false)
	{
	}

	[Token(Token = "0x6000516")]
	[Address(RVA = "0x8F6FA0", Offset = "0x8F6FA0", VA = "0x8F6FA0", Slot = "12")]
	public virtual void MoveToWhiteBall()
	{
	}

	[Token(Token = "0x6000517")]
	[Address(RVA = "0x8F6FA4", Offset = "0x8F6FA4", VA = "0x8F6FA4", Slot = "13")]
	public virtual void MoveToRest()
	{
	}

	[Token(Token = "0x6000518")]
	[Address(RVA = "0x8F6FA8", Offset = "0x8F6FA8", VA = "0x8F6FA8", Slot = "14")]
	public virtual void ActivePlayer()
	{
	}

	[Token(Token = "0x600051A")]
	[Address(RVA = "0x8F6FB4", Offset = "0x8F6FB4", VA = "0x8F6FB4", Slot = "16")]
	public virtual void Init(List<ChineseEightBall> ballList)
	{
	}

	[Token(Token = "0x600051C")]
	[Address(RVA = "0x8F24C8", Offset = "0x8F24C8", VA = "0x8F24C8")]
	protected void AfterHit()
	{
	}

	[Token(Token = "0x600051D")]
	[Address(RVA = "0x8F69F8", Offset = "0x8F69F8", VA = "0x8F69F8")]
	public bool IsPointEmpty(Vector3 point, [Optional] Ball ball)
	{
		return default(bool);
	}

	[Token(Token = "0x600051E")]
	[Address(RVA = "0x8F5A38", Offset = "0x8F5A38", VA = "0x8F5A38")]
	protected ChineseEightBallPlayer()
	{
	}
}
[Token(Token = "0x2000119")]
[RequireComponent(typeof(RemotePlayer))]
public abstract class ChineseEightBallRemotePlayer : ChineseEightBallPlayer
{
	[Token(Token = "0x200011A")]
	protected class RemoteBall
	{
		[Token(Token = "0x170000AD")]
		public int Number
		{
			[Token(Token = "0x600052E")]
			[Address(RVA = "0x8F77F8", Offset = "0x8F77F8", VA = "0x8F77F8")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600052F")]
			[Address(RVA = "0x8F7800", Offset = "0x8F7800", VA = "0x8F7800")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000AE")]
		public PocketPos PocketPos
		{
			[Token(Token = "0x6000530")]
			[Address(RVA = "0x8F7808", Offset = "0x8F7808", VA = "0x8F7808")]
			[CompilerGenerated]
			get
			{
				return default(PocketPos);
			}
			[Token(Token = "0x6000531")]
			[Address(RVA = "0x8F7810", Offset = "0x8F7810", VA = "0x8F7810")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0x8F71A4", Offset = "0x8F71A4", VA = "0x8F71A4")]
		public RemoteBall(int number, PocketPos pocketPos)
		{
		}
	}

	[Token(Token = "0x200011B")]
	protected class AfterHitInfo
	{
		[Token(Token = "0x170000AF")]
		public int FirstHitBall
		{
			[Token(Token = "0x6000533")]
			[Address(RVA = "0x8F7818", Offset = "0x8F7818", VA = "0x8F7818")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000534")]
			[Address(RVA = "0x8F7820", Offset = "0x8F7820", VA = "0x8F7820")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000B0")]
		public bool DoubleHit
		{
			[Token(Token = "0x6000535")]
			[Address(RVA = "0x8F7828", Offset = "0x8F7828", VA = "0x8F7828")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000536")]
			[Address(RVA = "0x8F7830", Offset = "0x8F7830", VA = "0x8F7830")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000B1")]
		public bool BodyHit
		{
			[Token(Token = "0x6000537")]
			[Address(RVA = "0x8F783C", Offset = "0x8F783C", VA = "0x8F783C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000538")]
			[Address(RVA = "0x8F7844", Offset = "0x8F7844", VA = "0x8F7844")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000B2")]
		public List<BallState> BallStates
		{
			[Token(Token = "0x6000539")]
			[Address(RVA = "0x8F7850", Offset = "0x8F7850", VA = "0x8F7850")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600053A")]
			[Address(RVA = "0x8F7858", Offset = "0x8F7858", VA = "0x8F7858")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000B3")]
		public int WhiteFirstHitBall
		{
			[Token(Token = "0x600053B")]
			[Address(RVA = "0x8F7860", Offset = "0x8F7860", VA = "0x8F7860")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600053C")]
			[Address(RVA = "0x8F7868", Offset = "0x8F7868", VA = "0x8F7868")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0x8F5430", Offset = "0x8F5430", VA = "0x8F5430")]
		public AfterHitInfo()
		{
		}
	}

	[Token(Token = "0x200011C")]
	protected class ActivePlayerInfo
	{
		[Token(Token = "0x170000B4")]
		public GameState GameState
		{
			[Token(Token = "0x600053E")]
			[Address(RVA = "0x8F7870", Offset = "0x8F7870", VA = "0x8F7870")]
			[CompilerGenerated]
			get
			{
				return default(GameState);
			}
			[Token(Token = "0x600053F")]
			[Address(RVA = "0x8F7878", Offset = "0x8F7878", VA = "0x8F7878")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000B5")]
		public BallType BallType
		{
			[Token(Token = "0x6000540")]
			[Address(RVA = "0x8F7880", Offset = "0x8F7880", VA = "0x8F7880")]
			[CompilerGenerated]
			get
			{
				return default(BallType);
			}
			[Token(Token = "0x6000541")]
			[Address(RVA = "0x8F7888", Offset = "0x8F7888", VA = "0x8F7888")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000B6")]
		public List<BallState> BallStates
		{
			[Token(Token = "0x6000542")]
			[Address(RVA = "0x8F7890", Offset = "0x8F7890", VA = "0x8F7890")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000543")]
			[Address(RVA = "0x8F7898", Offset = "0x8F7898", VA = "0x8F7898")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0x8F78A0", Offset = "0x8F78A0", VA = "0x8F78A0")]
		public ActivePlayerInfo()
		{
		}
	}

	[Token(Token = "0x200011D")]
	public class BallState
	{
		[Token(Token = "0x170000B7")]
		public bool IsInPocketThisHit
		{
			[Token(Token = "0x6000545")]
			[Address(RVA = "0x8F78A8", Offset = "0x8F78A8", VA = "0x8F78A8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000546")]
			[Address(RVA = "0x8F78B0", Offset = "0x8F78B0", VA = "0x8F78B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000B8")]
		public bool IsOutOfBoundThisHit
		{
			[Token(Token = "0x6000547")]
			[Address(RVA = "0x8F78BC", Offset = "0x8F78BC", VA = "0x8F78BC")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000548")]
			[Address(RVA = "0x8F78C4", Offset = "0x8F78C4", VA = "0x8F78C4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000B9")]
		public bool IsOutOfBound
		{
			[Token(Token = "0x6000549")]
			[Address(RVA = "0x8F78D0", Offset = "0x8F78D0", VA = "0x8F78D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600054A")]
			[Address(RVA = "0x8F78D8", Offset = "0x8F78D8", VA = "0x8F78D8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000BA")]
		public bool IsHitBorder
		{
			[Token(Token = "0x600054B")]
			[Address(RVA = "0x8F78E4", Offset = "0x8F78E4", VA = "0x8F78E4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600054C")]
			[Address(RVA = "0x8F78EC", Offset = "0x8F78EC", VA = "0x8F78EC")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000BB")]
		public bool IsActive
		{
			[Token(Token = "0x600054D")]
			[Address(RVA = "0x8F78F8", Offset = "0x8F78F8", VA = "0x8F78F8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600054E")]
			[Address(RVA = "0x8F7900", Offset = "0x8F7900", VA = "0x8F7900")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0x8F790C", Offset = "0x8F790C", VA = "0x8F790C")]
		public BallState()
		{
		}
	}

	[Token(Token = "0x200011E")]
	protected class MsgInfo
	{
		[Token(Token = "0x170000BC")]
		public string Msg
		{
			[Token(Token = "0x6000550")]
			[Address(RVA = "0x8F7914", Offset = "0x8F7914", VA = "0x8F7914")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000551")]
			[Address(RVA = "0x8F791C", Offset = "0x8F791C", VA = "0x8F791C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000BD")]
		public bool Keep
		{
			[Token(Token = "0x6000552")]
			[Address(RVA = "0x8F7924", Offset = "0x8F7924", VA = "0x8F7924")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000553")]
			[Address(RVA = "0x8F792C", Offset = "0x8F792C", VA = "0x8F792C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0x8F7938", Offset = "0x8F7938", VA = "0x8F7938")]
		public MsgInfo(string msg, bool keep)
		{
		}
	}

	[Token(Token = "0x40004AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private CancellationTokenSource syncToken;

	[Token(Token = "0x600051F")]
	[Address(RVA = "0x8F46F8", Offset = "0x8F46F8", VA = "0x8F46F8", Slot = "17")]
	protected virtual void OnDestroy()
	{
	}

	[Token(Token = "0x6000520")]
	[Address(RVA = "0x8F4C38", Offset = "0x8F4C38", VA = "0x8F4C38")]
	protected Promise AcceptBallStateAndSendBallTransformSync([Optional] List<BallState> stateList)
	{
		return null;
	}

	[Token(Token = "0x6000521")]
	[Address(RVA = "0x8F48B8", Offset = "0x8F48B8", VA = "0x8F48B8")]
	protected void ReceiveBallTransformSync()
	{
	}

	[Token(Token = "0x6000522")]
	[Address(RVA = "0x8F5438", Offset = "0x8F5438", VA = "0x8F5438")]
	protected List<BallState> FetchBallStates()
	{
		return null;
	}

	[Token(Token = "0x6000523")]
	[Address(RVA = "0x8F6FCC", Offset = "0x8F6FCC", VA = "0x8F6FCC")]
	private void AcceptBallState(List<BallState> stateList)
	{
	}

	[Token(Token = "0x6000524")]
	[Address(RVA = "0x8F44C8", Offset = "0x8F44C8", VA = "0x8F44C8")]
	protected void Init()
	{
	}

	[Token(Token = "0x6000525")]
	[Address(RVA = "0x8F70A0", Offset = "0x8F70A0", VA = "0x8F70A0")]
	private void FallInPocketAction(Ball ball)
	{
	}

	[Token(Token = "0x6000526")]
	[Address(RVA = "0x8F71D0", Offset = "0x8F71D0", VA = "0x8F71D0")]
	private void OutOfBoundsAction(Ball ball)
	{
	}

	[Token(Token = "0x6000527")]
	[Address(RVA = "0x8F72C0", Offset = "0x8F72C0", VA = "0x8F72C0")]
	private void ResetPocketAction(Ball ball)
	{
	}

	[Token(Token = "0x6000528")]
	[Address(RVA = "0x8F4874", Offset = "0x8F4874", VA = "0x8F4874")]
	protected ChineseEightBallRemotePlayer()
	{
	}
}
[Token(Token = "0x2000123")]
public class ChineseEightBallSRemotePlayer : ChineseEightBallRemotePlayer
{
	[Token(Token = "0x40004CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private bool doubleHit;

	[Token(Token = "0x40004CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
	private bool bodyHit;

	[Token(Token = "0x40004CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Ball firstHitBall;

	[Token(Token = "0x40004CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private BallType hostBallType;

	[Token(Token = "0x40004D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private int playerIndex;

	[Token(Token = "0x170000BE")]
	public override bool DoubleHit
	{
		[Token(Token = "0x6000564")]
		[Address(RVA = "0x8F8024", Offset = "0x8F8024", VA = "0x8F8024", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170000BF")]
	public override bool BodyHit
	{
		[Token(Token = "0x6000565")]
		[Address(RVA = "0x8F802C", Offset = "0x8F802C", VA = "0x8F802C", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170000C0")]
	public override Ball FirstHitBall
	{
		[Token(Token = "0x6000566")]
		[Address(RVA = "0x8F8034", Offset = "0x8F8034", VA = "0x8F8034", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000C1")]
	public override BallType BallType
	{
		[Token(Token = "0x6000567")]
		[Address(RVA = "0x8F803C", Offset = "0x8F803C", VA = "0x8F803C", Slot = "9")]
		get
		{
			return default(BallType);
		}
		[Token(Token = "0x6000568")]
		[Address(RVA = "0x8F8044", Offset = "0x8F8044", VA = "0x8F8044", Slot = "10")]
		set
		{
		}
	}

	[Token(Token = "0x170000C2")]
	public override int Score
	{
		[Token(Token = "0x6000569")]
		[Address(RVA = "0x8F8100", Offset = "0x8F8100", VA = "0x8F8100", Slot = "8")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600056A")]
		[Address(RVA = "0x8F8108", Offset = "0x8F8108", VA = "0x8F8108", Slot = "7")]
		set
		{
		}
	}

	[Token(Token = "0x600056B")]
	[Address(RVA = "0x8F8298", Offset = "0x8F8298", VA = "0x8F8298")]
	private void Start()
	{
	}

	[Token(Token = "0x600056C")]
	[Address(RVA = "0x8F85E0", Offset = "0x8F85E0", VA = "0x8F85E0", Slot = "17")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x600056D")]
	[Address(RVA = "0x8F85E4", Offset = "0x8F85E4", VA = "0x8F85E4")]
	private void Update()
	{
	}

	[Token(Token = "0x600056E")]
	[Address(RVA = "0x8F8954", Offset = "0x8F8954", VA = "0x8F8954", Slot = "11")]
	public override void ShowMsg(string msg, bool keep = false)
	{
	}

	[Token(Token = "0x600056F")]
	[Address(RVA = "0x8F8A28", Offset = "0x8F8A28", VA = "0x8F8A28", Slot = "12")]
	public override void MoveToWhiteBall()
	{
	}

	[Token(Token = "0x6000570")]
	[Address(RVA = "0x8F8A98", Offset = "0x8F8A98", VA = "0x8F8A98", Slot = "14")]
	public override void ActivePlayer()
	{
	}

	[Token(Token = "0x6000571")]
	[Address(RVA = "0x8F8BDC", Offset = "0x8F8BDC", VA = "0x8F8BDC", Slot = "13")]
	public override void MoveToRest()
	{
	}

	[Token(Token = "0x6000572")]
	[Address(RVA = "0x8F8C4C", Offset = "0x8F8C4C", VA = "0x8F8C4C")]
	public ChineseEightBallSRemotePlayer()
	{
	}
}
[Token(Token = "0x2000125")]
[RequireComponent(typeof(TransformSync), typeof(CommandSync))]
public class RemotePlayer : MonoBehaviour
{
	[Token(Token = "0x40004D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Transform localHead;

	[Token(Token = "0x40004D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Transform localHand;

	[Token(Token = "0x40004D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Transform localGanHand;

	[Token(Token = "0x40004D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Transform localGan;

	[Token(Token = "0x40004D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Transform remoteHead;

	[Token(Token = "0x40004D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Transform remoteHand;

	[Token(Token = "0x40004D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Transform remoteHandParent;

	[Token(Token = "0x40004DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Transform remoteGanHand;

	[Token(Token = "0x40004DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Transform remoteGan;

	[Token(Token = "0x40004DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private bool isHide;

	[Token(Token = "0x40004DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
	private bool isPressed;

	[Token(Token = "0x600057A")]
	[Address(RVA = "0x8F9004", Offset = "0x8F9004", VA = "0x8F9004")]
	private void Start()
	{
	}

	[Token(Token = "0x600057B")]
	[Address(RVA = "0x8F9FBC", Offset = "0x8F9FBC", VA = "0x8F9FBC")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600057C")]
	[Address(RVA = "0x8FA214", Offset = "0x8FA214", VA = "0x8FA214")]
	private void Update()
	{
	}

	[Token(Token = "0x600057D")]
	[Address(RVA = "0x8FA67C", Offset = "0x8FA67C", VA = "0x8FA67C")]
	public RemotePlayer()
	{
	}
}
[Token(Token = "0x2000128")]
public class SDKManager : MonoBehaviour
{
	[StructLayout(3)]
	[Token(Token = "0x2000129")]
	[CompilerGenerated]
	private struct <setMRMode>d__7 : IAsyncStateMachine
	{
		[Token(Token = "0x40004F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x40004F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Token(Token = "0x40004F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool mrMode;

		[Token(Token = "0x6000592")]
		[Address(RVA = "0x8FB240", Offset = "0x8FB240", VA = "0x8FB240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0x8FB660", Offset = "0x8FB660", VA = "0x8FB660", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x40004EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject Qiyu;

	[Token(Token = "0x40004EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject Pico;

	[Token(Token = "0x40004ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static bool inited;

	[Token(Token = "0x40004EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
	private static bool mrMode;

	[Token(Token = "0x40004EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	private static CameraClearFlags originCameraClearFlags;

	[Token(Token = "0x40004F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Color originCameraBackground;

	[Token(Token = "0x600058E")]
	[Address(RVA = "0x8FB080", Offset = "0x8FB080", VA = "0x8FB080")]
	private void Start()
	{
	}

	[Token(Token = "0x600058F")]
	[Address(RVA = "0x8FB0F8", Offset = "0x8FB0F8", VA = "0x8FB0F8")]
	[AsyncStateMachine(typeof(<setMRMode>d__7))]
	public System.Threading.Tasks.Task setMRMode(bool mrMode)
	{
		return null;
	}

	[Token(Token = "0x6000590")]
	[Address(RVA = "0x8FB1D0", Offset = "0x8FB1D0", VA = "0x8FB1D0")]
	private void OnApplicationPause(bool pause)
	{
	}

	[Token(Token = "0x6000591")]
	[Address(RVA = "0x8FB238", Offset = "0x8FB238", VA = "0x8FB238")]
	public SDKManager()
	{
	}
}
[Token(Token = "0x200012A")]
public class Angle
{
	[Token(Token = "0x40004F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private float value;

	[Token(Token = "0x170000C3")]
	public float Value
	{
		[Token(Token = "0x600059D")]
		[Address(RVA = "0x8FBAD4", Offset = "0x8FBAD4", VA = "0x8FBAD4")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170000C4")]
	public float RadValue
	{
		[Token(Token = "0x600059E")]
		[Address(RVA = "0x8FBADC", Offset = "0x8FBADC", VA = "0x8FBADC")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6000594")]
	[Address(RVA = "0x8FB66C", Offset = "0x8FB66C", VA = "0x8FB66C")]
	private Angle(float deg)
	{
	}

	[Token(Token = "0x6000595")]
	[Address(RVA = "0x8FB6D0", Offset = "0x8FB6D0", VA = "0x8FB6D0")]
	public static Angle FromDeg(float deg)
	{
		return null;
	}

	[Token(Token = "0x6000596")]
	[Address(RVA = "0x8FB778", Offset = "0x8FB778", VA = "0x8FB778")]
	public static Angle FromRad(float rad)
	{
		return null;
	}

	[Token(Token = "0x6000597")]
	[Address(RVA = "0x8FB82C", Offset = "0x8FB82C", VA = "0x8FB82C")]
	public static Angle operator +(Angle a, float b)
	{
		return null;
	}

	[Token(Token = "0x6000598")]
	[Address(RVA = "0x8FB8E4", Offset = "0x8FB8E4", VA = "0x8FB8E4")]
	public static Angle operator -(Angle a, float b)
	{
		return null;
	}

	[Token(Token = "0x6000599")]
	[Address(RVA = "0x8FB99C", Offset = "0x8FB99C", VA = "0x8FB99C")]
	public static bool operator >(Angle a, Angle b)
	{
		return default(bool);
	}

	[Token(Token = "0x600059A")]
	[Address(RVA = "0x8FBA04", Offset = "0x8FBA04", VA = "0x8FBA04")]
	public static bool operator <(Angle a, Angle b)
	{
		return default(bool);
	}

	[Token(Token = "0x600059B")]
	[Address(RVA = "0x8FBA6C", Offset = "0x8FBA6C", VA = "0x8FBA6C")]
	public static bool operator >=(Angle a, Angle b)
	{
		return default(bool);
	}

	[Token(Token = "0x600059C")]
	[Address(RVA = "0x8FBAA0", Offset = "0x8FBAA0", VA = "0x8FBAA0")]
	public static bool operator <=(Angle a, Angle b)
	{
		return default(bool);
	}

	[Token(Token = "0x600059F")]
	[Address(RVA = "0x8F1D14", Offset = "0x8F1D14", VA = "0x8F1D14")]
	public static implicit operator Angle(float deg)
	{
		return null;
	}

	[Token(Token = "0x60005A0")]
	[Address(RVA = "0x8FBAF0", Offset = "0x8FBAF0", VA = "0x8FBAF0")]
	public static float Delta(Angle a, Angle b)
	{
		return default(float);
	}

	[Token(Token = "0x60005A1")]
	[Address(RVA = "0x8FBB30", Offset = "0x8FBB30", VA = "0x8FBB30")]
	public static Angle Min(Angle a, Angle b)
	{
		return null;
	}

	[Token(Token = "0x60005A2")]
	[Address(RVA = "0x8FBB80", Offset = "0x8FBB80", VA = "0x8FBB80")]
	public static Angle Max(Angle a, Angle b)
	{
		return null;
	}

	[Token(Token = "0x60005A3")]
	[Address(RVA = "0x8FBBD0", Offset = "0x8FBBD0", VA = "0x8FBBD0")]
	public static Angle Center(Angle from, Angle to)
	{
		return null;
	}

	[Token(Token = "0x60005A4")]
	[Address(RVA = "0x8F1F38", Offset = "0x8F1F38", VA = "0x8F1F38")]
	public static bool Between(Angle min, Angle max, Angle val)
	{
		return default(bool);
	}

	[Token(Token = "0x60005A5")]
	[Address(RVA = "0x8FBBF0", Offset = "0x8FBBF0", VA = "0x8FBBF0")]
	public static bool Between(Angle min, Angle max, float val)
	{
		return default(bool);
	}

	[Token(Token = "0x60005A6")]
	[Address(RVA = "0x8FBC74", Offset = "0x8FBC74", VA = "0x8FBC74", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Token(Token = "0x200012B")]
public class GaussianRandom
{
	[Token(Token = "0x40004F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static int iset;

	[Token(Token = "0x40004F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static double gset;

	[Token(Token = "0x40004F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static System.Random r1;

	[Token(Token = "0x40004F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static System.Random r2;

	[Token(Token = "0x60005A7")]
	[Address(RVA = "0x8FBC80", Offset = "0x8FBC80", VA = "0x8FBC80")]
	static GaussianRandom()
	{
	}

	[Token(Token = "0x60005A8")]
	[Address(RVA = "0x8FBDB0", Offset = "0x8FBDB0", VA = "0x8FBDB0")]
	public static float Next(float min, float max, float sigma, float miu = 0f)
	{
		return default(float);
	}

	[Token(Token = "0x60005A9")]
	[Address(RVA = "0x8FBE7C", Offset = "0x8FBE7C", VA = "0x8FBE7C")]
	public static double Next()
	{
		return default(double);
	}

	[Token(Token = "0x60005AA")]
	[Address(RVA = "0x8FBFFC", Offset = "0x8FBFFC", VA = "0x8FBFFC")]
	public GaussianRandom()
	{
	}
}
[Token(Token = "0x200012C")]
public class RingBuff
{
	[Token(Token = "0x40004F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private byte[] ringBuff;

	[Token(Token = "0x40004FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private int head;

	[Token(Token = "0x40004FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private int tail;

	[Token(Token = "0x40004FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int buffSize;

	[Token(Token = "0x40004FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private int markTail;

	[Token(Token = "0x170000C5")]
	public int Available
	{
		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x8FC004", Offset = "0x8FC004", VA = "0x8FC004")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60005AC")]
	[Address(RVA = "0x8FC020", Offset = "0x8FC020", VA = "0x8FC020")]
	public RingBuff(int _size)
	{
	}

	[Token(Token = "0x60005AD")]
	[Address(RVA = "0x8FC09C", Offset = "0x8FC09C", VA = "0x8FC09C")]
	public bool Write(byte[] _buff)
	{
		return default(bool);
	}

	[Token(Token = "0x60005AE")]
	[Address(RVA = "0x8FC0B4", Offset = "0x8FC0B4", VA = "0x8FC0B4")]
	public bool Write(byte[] _buff, int len)
	{
		return default(bool);
	}

	[Token(Token = "0x60005AF")]
	[Address(RVA = "0x8FC18C", Offset = "0x8FC18C", VA = "0x8FC18C")]
	public int Read(byte[] readbuff)
	{
		return default(int);
	}

	[Token(Token = "0x60005B0")]
	[Address(RVA = "0x8FC1A4", Offset = "0x8FC1A4", VA = "0x8FC1A4")]
	public int Read(byte[] readbuff, int len)
	{
		return default(int);
	}

	[Token(Token = "0x60005B1")]
	[Address(RVA = "0x8FC274", Offset = "0x8FC274", VA = "0x8FC274")]
	public void Mark()
	{
	}

	[Token(Token = "0x60005B2")]
	[Address(RVA = "0x8FC280", Offset = "0x8FC280", VA = "0x8FC280")]
	public void Reset()
	{
	}

	[Token(Token = "0x60005B3")]
	[Address(RVA = "0x8FC28C", Offset = "0x8FC28C", VA = "0x8FC28C")]
	public void Skip(int len)
	{
	}
}
[Token(Token = "0x200012D")]
public class TimedCache<T>
{
	[Token(Token = "0x40004FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private Dictionary<T, float> cacheList;

	[Token(Token = "0x60005B4")]
	public void Add(T instance)
	{
	}

	[Token(Token = "0x60005B5")]
	public bool Contains(T instance)
	{
		return default(bool);
	}

	[Token(Token = "0x60005B6")]
	public void Clear(float timeout)
	{
	}

	[Token(Token = "0x60005B7")]
	public TimedCache()
	{
	}
}
[Token(Token = "0x200012E")]
public class Tween
{
	[StructLayout(3)]
	[Token(Token = "0x200012F")]
	[CompilerGenerated]
	private struct <MoveTo>d__3 : IAsyncStateMachine
	{
		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 targetPos;

		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Tween <>4__this;

		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float time;

		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float <sTime>5__2;

		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float <delta>5__3;

		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TaskAwaiter<VoidData> <>u__1;

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x8FC424", Offset = "0x8FC424", VA = "0x8FC424", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x8FC908", Offset = "0x8FC908", VA = "0x8FC908", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x40004FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private Transform transform;

	[Token(Token = "0x4000500")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private float speed;

	[Token(Token = "0x60005B8")]
	[Address(RVA = "0x8FC2D8", Offset = "0x8FC2D8", VA = "0x8FC2D8")]
	public Tween(Transform transform)
	{
	}

	[Token(Token = "0x60005B9")]
	[Address(RVA = "0x8FC308", Offset = "0x8FC308", VA = "0x8FC308")]
	[AsyncStateMachine(typeof(<MoveTo>d__3))]
	public System.Threading.Tasks.Task MoveTo(Vector3 targetPos, float time)
	{
		return null;
	}
}
[Token(Token = "0x2000130")]
public static class ZipTool
{
	[Token(Token = "0x60005BC")]
	[Address(RVA = "0x8FC914", Offset = "0x8FC914", VA = "0x8FC914")]
	public static byte[] Zip(byte[] data)
	{
		return null;
	}

	[Token(Token = "0x60005BD")]
	[Address(RVA = "0x8FCC5C", Offset = "0x8FCC5C", VA = "0x8FCC5C")]
	public static byte[] UnZip(byte[] data)
	{
		return null;
	}
}
[Token(Token = "0x2000131")]
[RequireComponent(typeof(RectTransform))]
public abstract class UIEventBase : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000132")]
	public class ClickedEvent : UnityEvent<GameObject>
	{
		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x8FD9A8", Offset = "0x8FD9A8", VA = "0x8FD9A8")]
		public ClickedEvent()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000133")]
	public class PointerEnterEvent : UnityEvent
	{
		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x8FD9F0", Offset = "0x8FD9F0", VA = "0x8FD9F0")]
		public PointerEnterEvent()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000134")]
	public class PointerExitEvent : UnityEvent
	{
		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x8FD9F8", Offset = "0x8FD9F8", VA = "0x8FD9F8")]
		public PointerExitEvent()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000135")]
	public class PointerMoveEvent : UnityEvent<Vector3>
	{
		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x8FDA00", Offset = "0x8FDA00", VA = "0x8FDA00")]
		public PointerMoveEvent()
		{
		}
	}

	[Token(Token = "0x4000509")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Vector3 from;

	[Token(Token = "0x400050A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private Vector3 LeftTop;

	[Token(Token = "0x400050B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Vector3 RightTop;

	[Token(Token = "0x400050C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private Vector3 LeftBottom;

	[Token(Token = "0x400050D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Vector3 RightBottom;

	[Token(Token = "0x400050E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private Vector3 AB;

	[Token(Token = "0x400050F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Vector3 CD;

	[Token(Token = "0x4000510")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private Vector3 DA;

	[Token(Token = "0x4000511")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Vector3 BC;

	[Token(Token = "0x4000512")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private bool pointIn;

	[Token(Token = "0x4000513")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x85")]
	private bool buttonDown;

	[Token(Token = "0x60005BE")]
	[Address(RVA = "0x8FD000", Offset = "0x8FD000", VA = "0x8FD000", Slot = "4")]
	protected virtual void ClickHandler(GameObject gameObject)
	{
	}

	[Token(Token = "0x60005BF")]
	[Address(RVA = "0x8FD004", Offset = "0x8FD004", VA = "0x8FD004", Slot = "5")]
	protected virtual void PointerEnterHandler()
	{
	}

	[Token(Token = "0x60005C0")]
	[Address(RVA = "0x8FD008", Offset = "0x8FD008", VA = "0x8FD008", Slot = "6")]
	protected virtual void PointerExitHandler()
	{
	}

	[Token(Token = "0x60005C1")]
	[Address(RVA = "0x8FD00C", Offset = "0x8FD00C", VA = "0x8FD00C", Slot = "7")]
	protected virtual void PointerMoveHandler(Vector3 point)
	{
	}

	[Token(Token = "0x60005C2")]
	[Address(RVA = "0x8FD010", Offset = "0x8FD010", VA = "0x8FD010", Slot = "8")]
	protected virtual void OnEnable()
	{
	}

	[Token(Token = "0x60005C3")]
	[Address(RVA = "0x8FD2F4", Offset = "0x8FD2F4", VA = "0x8FD2F4")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60005C4")]
	[Address(RVA = "0x8FD464", Offset = "0x8FD464", VA = "0x8FD464")]
	private void GetFrom()
	{
	}

	[Token(Token = "0x60005C5")]
	[Address(RVA = "0x8FD528", Offset = "0x8FD528", VA = "0x8FD528")]
	private Vector3 GanVertex()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60005C6")]
	[Address(RVA = "0x8FD650", Offset = "0x8FD650", VA = "0x8FD650")]
	private Vector3 TargetVector(Vector3 vertex)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60005C7")]
	[Address(RVA = "0x8FD6C8", Offset = "0x8FD6C8", VA = "0x8FD6C8")]
	private bool IsPointIn(Vector3 point)
	{
		return default(bool);
	}

	[Token(Token = "0x60005C8")]
	[Address(RVA = "0x8FD800", Offset = "0x8FD800", VA = "0x8FD800")]
	public Vector3 GetIntersectWithLineAndPlane(Vector3 point, Vector3 direct, Vector3 planeNormal, Vector3 planePoint)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60005C9")]
	[Address(RVA = "0x8FD998", Offset = "0x8FD998", VA = "0x8FD998")]
	protected UIEventBase()
	{
	}
}
[Token(Token = "0x2000136")]
public class UIEventButton : UIEventBase
{
	[Token(Token = "0x4000514")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private UIEventPanel parentPanel;

	[Token(Token = "0x4000515")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[SerializeField]
	private ClickedEvent Click;

	[Token(Token = "0x60005CE")]
	[Address(RVA = "0x8FDA48", Offset = "0x8FDA48", VA = "0x8FDA48")]
	private void Start()
	{
	}

	[Token(Token = "0x60005CF")]
	[Address(RVA = "0x8FDAA0", Offset = "0x8FDAA0", VA = "0x8FDAA0", Slot = "4")]
	protected override void ClickHandler(GameObject gameObject)
	{
	}

	[Token(Token = "0x60005D0")]
	[Address(RVA = "0x8FDC24", Offset = "0x8FDC24", VA = "0x8FDC24", Slot = "5")]
	protected override void PointerEnterHandler()
	{
	}

	[Token(Token = "0x60005D1")]
	[Address(RVA = "0x8FDD08", Offset = "0x8FDD08", VA = "0x8FDD08", Slot = "7")]
	protected override void PointerMoveHandler(Vector3 point)
	{
	}

	[Token(Token = "0x60005D2")]
	[Address(RVA = "0x8FDDEC", Offset = "0x8FDDEC", VA = "0x8FDDEC", Slot = "6")]
	protected override void PointerExitHandler()
	{
	}

	[Token(Token = "0x60005D3")]
	[Address(RVA = "0x8FDECC", Offset = "0x8FDECC", VA = "0x8FDECC")]
	public UIEventButton()
	{
	}
}
[Token(Token = "0x2000137")]
public class UIEventHandler : UIEventBase
{
	[Token(Token = "0x4000516")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	private ClickedEvent Click;

	[Token(Token = "0x4000517")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[SerializeField]
	private PointerEnterEvent PointerEnter;

	[Token(Token = "0x4000518")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[SerializeField]
	private PointerExitEvent PointerExit;

	[Token(Token = "0x4000519")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private PointerMoveEvent PointerMove;

	[Token(Token = "0x60005D4")]
	[Address(RVA = "0x8FDF44", Offset = "0x8FDF44", VA = "0x8FDF44", Slot = "4")]
	protected override void ClickHandler(GameObject gameObject)
	{
	}

	[Token(Token = "0x60005D5")]
	[Address(RVA = "0x8FDF9C", Offset = "0x8FDF9C", VA = "0x8FDF9C", Slot = "5")]
	protected override void PointerEnterHandler()
	{
	}

	[Token(Token = "0x60005D6")]
	[Address(RVA = "0x8FDFB8", Offset = "0x8FDFB8", VA = "0x8FDFB8", Slot = "6")]
	protected override void PointerExitHandler()
	{
	}

	[Token(Token = "0x60005D7")]
	[Address(RVA = "0x8FDFD4", Offset = "0x8FDFD4", VA = "0x8FDFD4", Slot = "7")]
	protected override void PointerMoveHandler(Vector3 point)
	{
	}

	[Token(Token = "0x60005D8")]
	[Address(RVA = "0x8FE04C", Offset = "0x8FE04C", VA = "0x8FE04C")]
	public UIEventHandler()
	{
	}
}
[Token(Token = "0x2000138")]
[RequireComponent(typeof(RectTransform))]
public class UIEventPanel : UIEventBase
{
	[Token(Token = "0x400051A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static LinkedList<UIEventPanel> panelStack;

	[Token(Token = "0x170000C6")]
	public bool IsPanelEnable
	{
		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x8FDB5C", Offset = "0x8FDB5C", VA = "0x8FDB5C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170000C7")]
	public static int VisibleCount
	{
		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x8F6988", Offset = "0x8F6988", VA = "0x8F6988")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60005DA")]
	[Address(RVA = "0x8FE174", Offset = "0x8FE174", VA = "0x8FE174", Slot = "8")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x60005DB")]
	[Address(RVA = "0x8FE1FC", Offset = "0x8FE1FC", VA = "0x8FE1FC")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60005DC")]
	[Address(RVA = "0x8FE2A8", Offset = "0x8FE2A8", VA = "0x8FE2A8", Slot = "5")]
	protected override void PointerEnterHandler()
	{
	}

	[Token(Token = "0x60005DD")]
	[Address(RVA = "0x8FE334", Offset = "0x8FE334", VA = "0x8FE334", Slot = "6")]
	protected override void PointerExitHandler()
	{
	}

	[Token(Token = "0x60005DE")]
	[Address(RVA = "0x8FE384", Offset = "0x8FE384", VA = "0x8FE384", Slot = "7")]
	protected override void PointerMoveHandler(Vector3 point)
	{
	}

	[Token(Token = "0x60005E0")]
	[Address(RVA = "0x8FE4AC", Offset = "0x8FE4AC", VA = "0x8FE4AC")]
	public UIEventPanel()
	{
	}
}
