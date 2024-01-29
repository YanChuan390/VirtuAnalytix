using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Core.PathCore;
using DG.Tweening.Plugins.Options;
using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Audio;
using UnityEngine.Events;
using UnityEngine.Networking;
using UnityEngine.Playables;
using UnityEngine.Scripting;
using UnityEngine.Serialization;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public static class Awaiters
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly WaitForUpdate _waitForUpdate;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static readonly WaitForFixedUpdate _waitForFixedUpdate;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static readonly WaitForEndOfFrame _waitForEndOfFrame;

	[Token(Token = "0x17000001")]
	public static WaitForUpdate NextFrame
	{
		[Token(Token = "0x6000001")]
		[Address(RVA = "0xF46840", Offset = "0xF46840", VA = "0xF46840")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000002")]
	public static WaitForFixedUpdate FixedUpdate
	{
		[Token(Token = "0x6000002")]
		[Address(RVA = "0xF46898", Offset = "0xF46898", VA = "0xF46898")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000003")]
	public static WaitForEndOfFrame EndOfFrame
	{
		[Token(Token = "0x6000003")]
		[Address(RVA = "0xF468F0", Offset = "0xF468F0", VA = "0xF468F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0xF46948", Offset = "0xF46948", VA = "0xF46948")]
	public static WaitForSeconds Seconds(float seconds)
	{
		return null;
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0xF469B4", Offset = "0xF469B4", VA = "0xF469B4")]
	public static WaitForSecondsRealtime SecondsRealtime(float seconds)
	{
		return null;
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0xF46A20", Offset = "0xF46A20", VA = "0xF46A20")]
	public static WaitUntil Until(Func<bool> predicate)
	{
		return null;
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0xF46A84", Offset = "0xF46A84", VA = "0xF46A84")]
	public static WaitWhile While(Func<bool> predicate)
	{
		return null;
	}
}
[Token(Token = "0x2000003")]
public static class AwaitExtensions
{
	[StructLayout(3)]
	[Token(Token = "0x2000005")]
	[CompilerGenerated]
	private struct <WrapErrors>d__1 : IAsyncStateMachine
	{
		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Task task;

		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TaskAwaiter <>u__1;

		[Token(Token = "0x600000D")]
		[Address(RVA = "0xF46EE0", Offset = "0xF46EE0", VA = "0xF46EE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0xF47058", Offset = "0xF47058", VA = "0xF47058", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0xF46BF4", Offset = "0xF46BF4", VA = "0xF46BF4")]
	public static TaskAwaiter<int> GetAwaiter(this Process process)
	{
		return default(TaskAwaiter<int>);
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0xF46DC0", Offset = "0xF46DC0", VA = "0xF46DC0")]
	[AsyncStateMachine(typeof(<WrapErrors>d__1))]
	public static void WrapErrors(this Task task)
	{
	}
}
[Token(Token = "0x2000006")]
public static class IEnumeratorAwaitExtensions
{
	[Token(Token = "0x2000007")]
	public class SimpleCoroutineAwaiter<T> : INotifyCompletion
	{
		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool _isDone;

		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Exception _exception;

		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Action _continuation;

		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T _result;

		[Token(Token = "0x17000004")]
		public bool IsCompleted
		{
			[Token(Token = "0x6000021")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000022")]
		public T GetResult()
		{
			return (T)null;
		}

		[Token(Token = "0x6000023")]
		public void Complete(T result, Exception e)
		{
		}

		[Token(Token = "0x6000024")]
		private void System.Runtime.CompilerServices.INotifyCompletion.OnCompleted(Action continuation)
		{
		}

		[Token(Token = "0x6000025")]
		public SimpleCoroutineAwaiter()
		{
		}
	}

	[Token(Token = "0x2000008")]
	public class SimpleCoroutineAwaiter : INotifyCompletion
	{
		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool _isDone;

		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Exception _exception;

		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Action _continuation;

		[Token(Token = "0x17000005")]
		public bool IsCompleted
		{
			[Token(Token = "0x6000026")]
			[Address(RVA = "0xF47820", Offset = "0xF47820", VA = "0xF47820")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0xF47828", Offset = "0xF47828", VA = "0xF47828")]
		public void GetResult()
		{
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0xF47864", Offset = "0xF47864", VA = "0xF47864")]
		public void Complete(Exception e)
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0xF478BC", Offset = "0xF478BC", VA = "0xF478BC", Slot = "4")]
		private void System.Runtime.CompilerServices.INotifyCompletion.OnCompleted(Action continuation)
		{
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0xF477B8", Offset = "0xF477B8", VA = "0xF477B8")]
		public SimpleCoroutineAwaiter()
		{
		}
	}

	[Token(Token = "0x2000009")]
	private class CoroutineWrapper<T>
	{
		[Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class <Run>d__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000013")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <>1__state;

			[Token(Token = "0x4000014")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private object <>2__current;

			[Token(Token = "0x4000015")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public CoroutineWrapper<T> <>4__this;

			[Token(Token = "0x17000006")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000032")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000007")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000034")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600002F")]
			[DebuggerHidden]
			public <Run>d__3(int <>1__state)
			{
			}

			[Token(Token = "0x6000030")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000031")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000033")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly SimpleCoroutineAwaiter<T> _awaiter;

		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly Stack<IEnumerator> _processStack;

		[Token(Token = "0x600002B")]
		public CoroutineWrapper(IEnumerator coroutine, SimpleCoroutineAwaiter<T> awaiter)
		{
		}

		[Token(Token = "0x600002C")]
		[IteratorStateMachine(typeof(CoroutineWrapper<>.<Run>d__3))]
		public IEnumerator Run()
		{
			return null;
		}

		[Token(Token = "0x600002D")]
		private string GenerateObjectTraceMessage(List<Type> objTrace)
		{
			return null;
		}

		[Token(Token = "0x600002E")]
		private static List<Type> GenerateObjectTrace(IEnumerable<IEnumerator> enumerators)
		{
			return null;
		}
	}

	[Token(Token = "0x200000B")]
	private static class InstructionWrappers
	{
		[Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class <ReturnVoid>d__0 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000016")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000017")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000018")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object instruction;

			[Token(Token = "0x4000019")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public SimpleCoroutineAwaiter awaiter;

			[Token(Token = "0x17000008")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600003D")]
				[Address(RVA = "0xF47C4C", Offset = "0xF47C4C", VA = "0xF47C4C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000009")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600003F")]
				[Address(RVA = "0xF47C94", Offset = "0xF47C94", VA = "0xF47C94", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600003A")]
			[Address(RVA = "0xF47994", Offset = "0xF47994", VA = "0xF47994")]
			[DebuggerHidden]
			public <ReturnVoid>d__0(int <>1__state)
			{
			}

			[Token(Token = "0x600003B")]
			[Address(RVA = "0xF47BE4", Offset = "0xF47BE4", VA = "0xF47BE4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600003C")]
			[Address(RVA = "0xF47BE8", Offset = "0xF47BE8", VA = "0xF47BE8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600003E")]
			[Address(RVA = "0xF47C54", Offset = "0xF47C54", VA = "0xF47C54", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class <AssetBundleCreateRequest>d__1 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400001A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400001B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400001C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AssetBundleCreateRequest instruction;

			[Token(Token = "0x400001D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public SimpleCoroutineAwaiter<AssetBundle> awaiter;

			[Token(Token = "0x1700000A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000043")]
				[Address(RVA = "0xF47D50", Offset = "0xF47D50", VA = "0xF47D50", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700000B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000045")]
				[Address(RVA = "0xF47D98", Offset = "0xF47D98", VA = "0xF47D98", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000040")]
			[Address(RVA = "0xF47A4C", Offset = "0xF47A4C", VA = "0xF47A4C")]
			[DebuggerHidden]
			public <AssetBundleCreateRequest>d__1(int <>1__state)
			{
			}

			[Token(Token = "0x6000041")]
			[Address(RVA = "0xF47C9C", Offset = "0xF47C9C", VA = "0xF47C9C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000042")]
			[Address(RVA = "0xF47CA0", Offset = "0xF47CA0", VA = "0xF47CA0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000044")]
			[Address(RVA = "0xF47D58", Offset = "0xF47D58", VA = "0xF47D58", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class <ReturnSelf>d__2<T> : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400001E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <>1__state;

			[Token(Token = "0x400001F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private object <>2__current;

			[Token(Token = "0x4000020")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public T instruction;

			[Token(Token = "0x4000021")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public SimpleCoroutineAwaiter<T> awaiter;

			[Token(Token = "0x1700000C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000049")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700000D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600004B")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000046")]
			[DebuggerHidden]
			public <ReturnSelf>d__2(int <>1__state)
			{
			}

			[Token(Token = "0x6000047")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000048")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600004A")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class <AssetBundleRequest>d__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000022")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000023")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000024")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AssetBundleRequest instruction;

			[Token(Token = "0x4000025")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public SimpleCoroutineAwaiter<UnityEngine.Object> awaiter;

			[Token(Token = "0x1700000E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600004F")]
				[Address(RVA = "0xF47E54", Offset = "0xF47E54", VA = "0xF47E54", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700000F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000051")]
				[Address(RVA = "0xF47E9C", Offset = "0xF47E9C", VA = "0xF47E9C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600004C")]
			[Address(RVA = "0xF47B04", Offset = "0xF47B04", VA = "0xF47B04")]
			[DebuggerHidden]
			public <AssetBundleRequest>d__3(int <>1__state)
			{
			}

			[Token(Token = "0x600004D")]
			[Address(RVA = "0xF47DA0", Offset = "0xF47DA0", VA = "0xF47DA0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600004E")]
			[Address(RVA = "0xF47DA4", Offset = "0xF47DA4", VA = "0xF47DA4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000050")]
			[Address(RVA = "0xF47E5C", Offset = "0xF47E5C", VA = "0xF47E5C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class <ResourceRequest>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000026")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000027")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000028")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ResourceRequest instruction;

			[Token(Token = "0x4000029")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public SimpleCoroutineAwaiter<UnityEngine.Object> awaiter;

			[Token(Token = "0x17000010")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000055")]
				[Address(RVA = "0xF47F58", Offset = "0xF47F58", VA = "0xF47F58", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000011")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000057")]
				[Address(RVA = "0xF47FA0", Offset = "0xF47FA0", VA = "0xF47FA0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000052")]
			[Address(RVA = "0xF47BBC", Offset = "0xF47BBC", VA = "0xF47BBC")]
			[DebuggerHidden]
			public <ResourceRequest>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000053")]
			[Address(RVA = "0xF47EA4", Offset = "0xF47EA4", VA = "0xF47EA4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000054")]
			[Address(RVA = "0xF47EA8", Offset = "0xF47EA8", VA = "0xF47EA8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000056")]
			[Address(RVA = "0xF47F60", Offset = "0xF47F60", VA = "0xF47F60", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0xF47904", Offset = "0xF47904", VA = "0xF47904")]
		[IteratorStateMachine(typeof(<ReturnVoid>d__0))]
		public static IEnumerator ReturnVoid(SimpleCoroutineAwaiter awaiter, object instruction)
		{
			return null;
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0xF479BC", Offset = "0xF479BC", VA = "0xF479BC")]
		[IteratorStateMachine(typeof(<AssetBundleCreateRequest>d__1))]
		public static IEnumerator AssetBundleCreateRequest(SimpleCoroutineAwaiter<AssetBundle> awaiter, AssetBundleCreateRequest instruction)
		{
			return null;
		}

		[Token(Token = "0x6000037")]
		[IteratorStateMachine(typeof(<ReturnSelf>d__2<>))]
		public static IEnumerator ReturnSelf<T>(SimpleCoroutineAwaiter<T> awaiter, T instruction)
		{
			return null;
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0xF47A74", Offset = "0xF47A74", VA = "0xF47A74")]
		[IteratorStateMachine(typeof(<AssetBundleRequest>d__3))]
		public static IEnumerator AssetBundleRequest(SimpleCoroutineAwaiter<UnityEngine.Object> awaiter, AssetBundleRequest instruction)
		{
			return null;
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0xF47B2C", Offset = "0xF47B2C", VA = "0xF47B2C")]
		[IteratorStateMachine(typeof(<ResourceRequest>d__4))]
		public static IEnumerator ResourceRequest(SimpleCoroutineAwaiter<UnityEngine.Object> awaiter, ResourceRequest instruction)
		{
			return null;
		}
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0xF47064", Offset = "0xF47064", VA = "0xF47064")]
	public static SimpleCoroutineAwaiter GetAwaiter(this WaitForSeconds instruction)
	{
		return null;
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0xF47164", Offset = "0xF47164", VA = "0xF47164")]
	public static SimpleCoroutineAwaiter GetAwaiter(this WaitForUpdate instruction)
	{
		return null;
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0xF47168", Offset = "0xF47168", VA = "0xF47168")]
	public static SimpleCoroutineAwaiter GetAwaiter(this WaitForEndOfFrame instruction)
	{
		return null;
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0xF4716C", Offset = "0xF4716C", VA = "0xF4716C")]
	public static SimpleCoroutineAwaiter GetAwaiter(this WaitForFixedUpdate instruction)
	{
		return null;
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0xF47170", Offset = "0xF47170", VA = "0xF47170")]
	public static SimpleCoroutineAwaiter GetAwaiter(this WaitForSecondsRealtime instruction)
	{
		return null;
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0xF47174", Offset = "0xF47174", VA = "0xF47174")]
	public static SimpleCoroutineAwaiter GetAwaiter(this WaitUntil instruction)
	{
		return null;
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0xF47178", Offset = "0xF47178", VA = "0xF47178")]
	public static SimpleCoroutineAwaiter GetAwaiter(this WaitWhile instruction)
	{
		return null;
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0xF4717C", Offset = "0xF4717C", VA = "0xF4717C")]
	public static SimpleCoroutineAwaiter<AsyncOperation> GetAwaiter(this AsyncOperation instruction)
	{
		return null;
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0xF471C4", Offset = "0xF471C4", VA = "0xF471C4")]
	public static SimpleCoroutineAwaiter<UnityEngine.Object> GetAwaiter(this ResourceRequest instruction)
	{
		return null;
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0xF47420", Offset = "0xF47420", VA = "0xF47420")]
	public static SimpleCoroutineAwaiter<WWW> GetAwaiter(this WWW instruction)
	{
		return null;
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0xF47468", Offset = "0xF47468", VA = "0xF47468")]
	public static SimpleCoroutineAwaiter<AssetBundle> GetAwaiter(this AssetBundleCreateRequest instruction)
	{
		return null;
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0xF47580", Offset = "0xF47580", VA = "0xF47580")]
	public static SimpleCoroutineAwaiter<UnityEngine.Object> GetAwaiter(this AssetBundleRequest instruction)
	{
		return null;
	}

	[Token(Token = "0x600001B")]
	public static SimpleCoroutineAwaiter<T> GetAwaiter<T>(this IEnumerator<T> coroutine)
	{
		return null;
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0xF47698", Offset = "0xF47698", VA = "0xF47698")]
	public static SimpleCoroutineAwaiter<object> GetAwaiter(this IEnumerator coroutine)
	{
		return null;
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0xF47068", Offset = "0xF47068", VA = "0xF47068")]
	private static SimpleCoroutineAwaiter GetAwaiterReturnVoid(object instruction)
	{
		return null;
	}

	[Token(Token = "0x600001E")]
	private static SimpleCoroutineAwaiter<T> GetAwaiterReturnSelf<T>(T instruction)
	{
		return null;
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0xF472DC", Offset = "0xF472DC", VA = "0xF472DC")]
	private static void RunOnUnityScheduler(Action action)
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0xF477C8", Offset = "0xF477C8", VA = "0xF477C8")]
	private static void Assert(bool condition)
	{
	}
}
[Token(Token = "0x2000019")]
public static class TaskExtensions
{
	[Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class <AsIEnumerator>d__0 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Task task;

		[Token(Token = "0x17000012")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600006D")]
			[Address(RVA = "0xF482B4", Offset = "0xF482B4", VA = "0xF482B4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000013")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600006F")]
			[Address(RVA = "0xF482FC", Offset = "0xF482FC", VA = "0xF482FC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0xF481F4", Offset = "0xF481F4", VA = "0xF481F4")]
		[DebuggerHidden]
		public <AsIEnumerator>d__0(int <>1__state)
		{
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0xF4821C", Offset = "0xF4821C", VA = "0xF4821C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0xF48220", Offset = "0xF48220", VA = "0xF48220", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0xF482BC", Offset = "0xF482BC", VA = "0xF482BC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class <AsIEnumerator>d__1<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
	{
		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <>1__state;

		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T <>2__current;

		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Task<T> task;

		[Token(Token = "0x17000014")]
		private T System.Collections.Generic.IEnumerator<T>.Current
		{
			[Token(Token = "0x6000073")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000015")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000075")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000070")]
		[DebuggerHidden]
		public <AsIEnumerator>d__1(int <>1__state)
		{
		}

		[Token(Token = "0x6000071")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000072")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000074")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0xF48180", Offset = "0xF48180", VA = "0xF48180")]
	[IteratorStateMachine(typeof(<AsIEnumerator>d__0))]
	public static IEnumerator AsIEnumerator(this Task task)
	{
		return null;
	}

	[Token(Token = "0x6000069")]
	[IteratorStateMachine(typeof(<AsIEnumerator>d__1<>))]
	public static IEnumerator<T> AsIEnumerator<T>(this Task<T> task) where T : class
	{
		return null;
	}
}
[Token(Token = "0x200001C")]
public class WaitForBackgroundThread
{
	[Token(Token = "0x6000076")]
	[Address(RVA = "0xF48304", Offset = "0xF48304", VA = "0xF48304")]
	public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter GetAwaiter()
	{
		return default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0xF48414", Offset = "0xF48414", VA = "0xF48414")]
	public WaitForBackgroundThread()
	{
	}
}
[Token(Token = "0x200001E")]
public class WaitForUpdate : CustomYieldInstruction
{
	[Token(Token = "0x17000016")]
	public override bool keepWaiting
	{
		[Token(Token = "0x600007B")]
		[Address(RVA = "0xF48498", Offset = "0xF48498", VA = "0xF48498", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0xF46BEC", Offset = "0xF46BEC", VA = "0xF46BEC")]
	public WaitForUpdate()
	{
	}
}
[Token(Token = "0x200001F")]
public class lzip
{
	[Token(Token = "0x2000020")]
	public class inMemory
	{
		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IntPtr pointer;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IntPtr zf;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IntPtr memStruct;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IntPtr fileStruct;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int[] info;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int lastResult;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool isClosed;

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0xF5579C", Offset = "0xF5579C", VA = "0xF5579C")]
		public int size()
		{
			return default(int);
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0xF557C4", Offset = "0xF557C4", VA = "0xF557C4")]
		public byte[] getZipBuffer()
		{
			return null;
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0xF52AD0", Offset = "0xF52AD0", VA = "0xF52AD0")]
		public inMemory()
		{
		}
	}

	[Token(Token = "0x2000021")]
	public struct zipInfo
	{
		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public short VersionMadeBy;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		public short MinimumVersionToExtract;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public short BitFlag;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
		public short CompressionMethod;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public short FileLastModificationTime;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
		public short FileLastModificationDate;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int CRC;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int CompressedSize;

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int UncompressedSize;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public short DiskNumberWhereFileStarts;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public short InternalFileAttributes;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int ExternalFileAttributes;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int RelativeOffsetOfLocalFileHeader;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int AbsoluteOffsetOfLocalFileHeaderStore;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string filename;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string extraField;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string fileComment;
	}

	[Token(Token = "0x4000041")]
	private const string libname = "zipw";

	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static List<string> ninfo;

	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static List<ulong> uinfo;

	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static List<ulong> cinfo;

	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static List<ulong> localOffset;

	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public static int zipFiles;

	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public static int zipFolders;

	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public static ulong totalCompressedSize;

	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public static ulong totalUncompressedSize;

	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public static List<zipInfo> zinfo;

	[PreserveSig]
	[Token(Token = "0x600007D")]
	[Address(RVA = "0xF484A0", Offset = "0xF484A0", VA = "0xF484A0")]
	internal static extern int zsetPermissions(string filePath, string _user, string _group, string _other);

	[PreserveSig]
	[Token(Token = "0x600007E")]
	[Address(RVA = "0xF48594", Offset = "0xF48594", VA = "0xF48594")]
	internal static extern bool zipValidateFile(string zipArchive, IntPtr FileBuffer, int fileBufferLength);

	[PreserveSig]
	[Token(Token = "0x600007F")]
	[Address(RVA = "0xF48644", Offset = "0xF48644", VA = "0xF48644")]
	internal static extern int zipGetTotalFiles(string zipArchive, IntPtr FileBuffer, int fileBufferLength);

	[PreserveSig]
	[Token(Token = "0x6000080")]
	[Address(RVA = "0xF486F0", Offset = "0xF486F0", VA = "0xF486F0")]
	internal static extern int zipGetTotalEntries(string zipArchive, IntPtr FileBuffer, int fileBufferLength);

	[PreserveSig]
	[Token(Token = "0x6000081")]
	[Address(RVA = "0xF4879C", Offset = "0xF4879C", VA = "0xF4879C")]
	internal static extern int zipGetInfoA(string zipArchive, IntPtr total, IntPtr FileBuffer, int fileBufferLength);

	[PreserveSig]
	[Token(Token = "0x6000082")]
	[Address(RVA = "0xF48850", Offset = "0xF48850", VA = "0xF48850")]
	internal static extern IntPtr zipGetInfo(string zipArchive, int size, IntPtr unc, IntPtr comp, IntPtr offs, IntPtr FileBuffer, int fileBufferLength);

	[PreserveSig]
	[Token(Token = "0x6000083")]
	[Address(RVA = "0xF4892C", Offset = "0xF4892C", VA = "0xF4892C")]
	internal static extern void releaseBuffer(IntPtr buffer);

	[PreserveSig]
	[Token(Token = "0x6000084")]
	[Address(RVA = "0xF489A8", Offset = "0xF489A8", VA = "0xF489A8")]
	internal static extern ulong zipGetEntrySize(string zipArchive, string entry, IntPtr FileBuffer, int fileBufferLength);

	[PreserveSig]
	[Token(Token = "0x6000085")]
	[Address(RVA = "0xF48A74", Offset = "0xF48A74", VA = "0xF48A74")]
	internal static extern bool zipEntryExists(string zipArchive, string entry, IntPtr FileBuffer, int fileBufferLength);

	[PreserveSig]
	[Token(Token = "0x6000086")]
	[Address(RVA = "0xF48B44", Offset = "0xF48B44", VA = "0xF48B44")]
	internal static extern int zipCD(int levelOfCompression, string zipArchive, string inFilePath, string fileName, string comment, string password, bool useBz2, int diskSize, IntPtr bprog);

	[PreserveSig]
	[Token(Token = "0x6000087")]
	[Address(RVA = "0xF48C8C", Offset = "0xF48C8C", VA = "0xF48C8C")]
	internal static extern int zipCDList(int levelOfCompression, string zipArchive, IntPtr filename, int arrayLength, IntPtr prog, IntPtr filenameForced, string password, bool useBz2, int diskSize, IntPtr bprog);

	[PreserveSig]
	[Token(Token = "0x6000088")]
	[Address(RVA = "0xF48DA0", Offset = "0xF48DA0", VA = "0xF48DA0")]
	internal static extern bool zipBuf2File(int levelOfCompression, string zipArchive, string arc_filename, IntPtr buffer, int bufferSize, string comment, string password, bool useBz2);

	[PreserveSig]
	[Token(Token = "0x6000089")]
	[Address(RVA = "0xF48EC8", Offset = "0xF48EC8", VA = "0xF48EC8")]
	internal static extern int zipDeleteFile(string zipArchive, string arc_filename, string tempArchive);

	[PreserveSig]
	[Token(Token = "0x600008A")]
	[Address(RVA = "0xF48FA0", Offset = "0xF48FA0", VA = "0xF48FA0")]
	internal static extern int zipEntry2Buffer(string zipArchive, string entry, IntPtr buffer, int bufferSize, IntPtr FileBuffer, int fileBufferLength, string password);

	[PreserveSig]
	[Token(Token = "0x600008B")]
	[Address(RVA = "0xF490A8", Offset = "0xF490A8", VA = "0xF490A8")]
	internal static extern IntPtr zipCompressBuffer(IntPtr source, int sourceLen, int levelOfCompression, ref int v);

	[PreserveSig]
	[Token(Token = "0x600008C")]
	[Address(RVA = "0xF49144", Offset = "0xF49144", VA = "0xF49144")]
	internal static extern IntPtr zipDecompressBuffer(IntPtr source, int sourceLen, ref int v);

	[PreserveSig]
	[Token(Token = "0x600008D")]
	[Address(RVA = "0xF491D8", Offset = "0xF491D8", VA = "0xF491D8")]
	internal static extern int zipEX(string zipArchive, string outPath, IntPtr progress, IntPtr FileBuffer, int fileBufferLength, IntPtr proc, string password);

	[PreserveSig]
	[Token(Token = "0x600008E")]
	[Address(RVA = "0xF492E0", Offset = "0xF492E0", VA = "0xF492E0")]
	internal static extern int zipEntry(string zipArchive, string arc_filename, string outpath, IntPtr FileBuffer, int fileBufferLength, IntPtr proc, string password);

	[PreserveSig]
	[Token(Token = "0x600008F")]
	[Address(RVA = "0xF493FC", Offset = "0xF493FC", VA = "0xF493FC")]
	internal static extern uint getEntryDateTime(string zipArchive, string arc_filename, IntPtr FileBuffer, int fileBufferLength);

	[PreserveSig]
	[Token(Token = "0x6000090")]
	[Address(RVA = "0xF494C8", Offset = "0xF494C8", VA = "0xF494C8")]
	internal static extern int freeMemStruct(IntPtr buffer);

	[PreserveSig]
	[Token(Token = "0x6000091")]
	[Address(RVA = "0xF49544", Offset = "0xF49544", VA = "0xF49544")]
	internal static extern IntPtr zipCDMem(IntPtr info, IntPtr pnt, int levelOfCompression, IntPtr source, int sourceLen, string fileName, string comment, string password, bool useBz2);

	[PreserveSig]
	[Token(Token = "0x6000092")]
	[Address(RVA = "0xF49668", Offset = "0xF49668", VA = "0xF49668")]
	internal static extern IntPtr initMemStruct();

	[PreserveSig]
	[Token(Token = "0x6000093")]
	[Address(RVA = "0xF496D0", Offset = "0xF496D0", VA = "0xF496D0")]
	internal static extern IntPtr initFileStruct();

	[PreserveSig]
	[Token(Token = "0x6000094")]
	[Address(RVA = "0xF49738", Offset = "0xF49738", VA = "0xF49738")]
	internal static extern int freeMemZ(IntPtr pointer);

	[PreserveSig]
	[Token(Token = "0x6000095")]
	[Address(RVA = "0xF497B0", Offset = "0xF497B0", VA = "0xF497B0")]
	internal static extern int freeFileZ(IntPtr pointer);

	[PreserveSig]
	[Token(Token = "0x6000096")]
	[Address(RVA = "0xF4982C", Offset = "0xF4982C", VA = "0xF4982C")]
	internal static extern IntPtr zipCDMemStart(IntPtr info, IntPtr pnt, IntPtr fileStruct, IntPtr memStruct);

	[PreserveSig]
	[Token(Token = "0x6000097")]
	[Address(RVA = "0xF498C8", Offset = "0xF498C8", VA = "0xF498C8")]
	internal static extern int zipCDMemAdd(IntPtr zf, int levelOfCompression, IntPtr source, int sourceLen, string fileName, string comment, string password, bool useBz2);

	[PreserveSig]
	[Token(Token = "0x6000098")]
	[Address(RVA = "0xF499D8", Offset = "0xF499D8", VA = "0xF499D8")]
	internal static extern IntPtr zipCDMemClose(IntPtr zf, IntPtr memStruct, IntPtr info, int err);

	[PreserveSig]
	[Token(Token = "0x6000099")]
	[Address(RVA = "0xF49A74", Offset = "0xF49A74", VA = "0xF49A74")]
	internal static extern int zipGzip(IntPtr source, int sourceLen, IntPtr outBuffer, int levelOfCompression, bool addHeader, bool addFooter);

	[PreserveSig]
	[Token(Token = "0x600009A")]
	[Address(RVA = "0xF49B28", Offset = "0xF49B28", VA = "0xF49B28")]
	internal static extern int zipUnGzip(IntPtr source, int sourceLen, IntPtr outBuffer, int outLen, bool hasHeader, bool hasFooter);

	[PreserveSig]
	[Token(Token = "0x600009B")]
	[Address(RVA = "0xF49BDC", Offset = "0xF49BDC", VA = "0xF49BDC")]
	internal static extern int zipUnGzip2(IntPtr source, int sourceLen, IntPtr outBuffer, int outLen);

	[PreserveSig]
	[Token(Token = "0x600009C")]
	[Address(RVA = "0xF49C78", Offset = "0xF49C78", VA = "0xF49C78")]
	internal static extern int gzip_File(string inFile, string outFile, int level, IntPtr progress, bool addHeader);

	[PreserveSig]
	[Token(Token = "0x600009D")]
	[Address(RVA = "0xF49D54", Offset = "0xF49D54", VA = "0xF49D54")]
	internal static extern int ungzip_File(string inFile, string outFile, IntPtr progress);

	[PreserveSig]
	[Token(Token = "0x600009E")]
	[Address(RVA = "0xF49E18", Offset = "0xF49E18", VA = "0xF49E18")]
	public static extern void setCancel();

	[PreserveSig]
	[Token(Token = "0x600009F")]
	[Address(RVA = "0xF49E7C", Offset = "0xF49E7C", VA = "0xF49E7C")]
	internal static extern int readTarA(string zipArchive, IntPtr total);

	[PreserveSig]
	[Token(Token = "0x60000A0")]
	[Address(RVA = "0xF49F18", Offset = "0xF49F18", VA = "0xF49F18")]
	internal static extern IntPtr readTar(string zipArchive, int size, IntPtr unc);

	[PreserveSig]
	[Token(Token = "0x60000A1")]
	[Address(RVA = "0xF49FC4", Offset = "0xF49FC4", VA = "0xF49FC4")]
	internal static extern int createTar(string outFile, IntPtr filePath, IntPtr filename, int arrayLength, IntPtr prog, IntPtr bprog);

	[PreserveSig]
	[Token(Token = "0x60000A2")]
	[Address(RVA = "0xF4A090", Offset = "0xF4A090", VA = "0xF4A090")]
	internal static extern int extractTar(string inFile, string outDir, string entry, IntPtr prog, IntPtr bprog, bool fullPaths);

	[PreserveSig]
	[Token(Token = "0x60000A3")]
	[Address(RVA = "0xF4A188", Offset = "0xF4A188", VA = "0xF4A188")]
	internal static extern int bz2(bool decompress, int level, string inFile, string outFile, IntPtr byteProgress);

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0xF4A264", Offset = "0xF4A264", VA = "0xF4A264")]
	internal static GCHandle gcA(object o)
	{
		return default(GCHandle);
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0xF4A270", Offset = "0xF4A270", VA = "0xF4A270")]
	public static int setFilePermissions(string filePath, string _user, string _group, string _other)
	{
		return default(int);
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0xF4A2EC", Offset = "0xF4A2EC", VA = "0xF4A2EC")]
	public static int getTotalFiles(string zipArchive, [Optional] byte[] FileBuffer)
	{
		return default(int);
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0xF4A3DC", Offset = "0xF4A3DC", VA = "0xF4A3DC")]
	public static int getTotalEntries(string zipArchive, [Optional] byte[] FileBuffer)
	{
		return default(int);
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0xF4A4CC", Offset = "0xF4A4CC", VA = "0xF4A4CC")]
	public static int getEntryIndex(string entry)
	{
		return default(int);
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0xF4A5FC", Offset = "0xF4A5FC", VA = "0xF4A5FC")]
	public static ulong getFileInfo(string zipArchive, [Optional] byte[] FileBuffer)
	{
		return default(ulong);
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0xF4AE2C", Offset = "0xF4AE2C", VA = "0xF4AE2C")]
	public static ulong getEntrySize(string zipArchive, string entry, [Optional] byte[] FileBuffer)
	{
		return default(ulong);
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0xF4AF28", Offset = "0xF4AF28", VA = "0xF4AF28")]
	public static bool entryExists(string zipArchive, string entry, [Optional] byte[] FileBuffer)
	{
		return default(bool);
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0xF4B024", Offset = "0xF4B024", VA = "0xF4B024")]
	public static bool buffer2File(int levelOfCompression, string zipArchive, string arc_filename, byte[] buffer, bool append = false, [Optional] string comment, [Optional] string password, bool useBz2 = false)
	{
		return default(bool);
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0xF4B19C", Offset = "0xF4B19C", VA = "0xF4B19C")]
	public static int delete_entry(string zipArchive, string arc_filename)
	{
		return default(int);
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0xF4B280", Offset = "0xF4B280", VA = "0xF4B280")]
	public static int replace_entry(string zipArchive, string arc_filename, string newFilePath, int level = 9, [Optional] string comment, [Optional] string password, bool useBz2 = false)
	{
		return default(int);
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0xF4B3C8", Offset = "0xF4B3C8", VA = "0xF4B3C8")]
	public static int replace_entry(string zipArchive, string arc_filename, byte[] newFileBuffer, int level = 9, [Optional] string password, bool useBz2 = false)
	{
		return default(int);
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0xF4B4A4", Offset = "0xF4B4A4", VA = "0xF4B4A4")]
	public static int extract_entry(string zipArchive, string arc_filename, string outpath, [Optional] byte[] FileBuffer, [Optional] ulong[] proc, [Optional] string password)
	{
		return default(int);
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0xF4B708", Offset = "0xF4B708", VA = "0xF4B708")]
	public static int decompress_File(string zipArchive, [Optional] string outPath, [Optional] int[] progress, [Optional] byte[] FileBuffer, [Optional] ulong[] proc, [Optional] string password)
	{
		return default(int);
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0xF4B9F8", Offset = "0xF4B9F8", VA = "0xF4B9F8")]
	public static int compress_File(int levelOfCompression, string zipArchive, string inFilePath, bool append = false, string fileName = "", [Optional] string comment, [Optional] string password, bool useBz2 = false, int diskSize = 0, [Optional] ulong[] byteProgress)
	{
		return default(int);
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0xF4BC30", Offset = "0xF4BC30", VA = "0xF4BC30")]
	public static int compress_File_List(int levelOfCompression, string zipArchive, string[] inFilePath, [Optional] int[] progress, bool append = false, [Optional] string[] fileName, [Optional] string password, bool useBz2 = false, int diskSize = 0, [Optional] ulong[] byteProgress)
	{
		return default(int);
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0xF4C38C", Offset = "0xF4C38C", VA = "0xF4C38C")]
	public static int compressDir(string sourceDir, int levelOfCompression, [Optional] string zipArchive, bool includeRoot = false, [Optional] int[] progress, [Optional] string password, bool useBz2 = false, int diskSize = 0, bool append = false, [Optional] ulong[] byteProgress)
	{
		return default(int);
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0xF4BFE4", Offset = "0xF4BFE4", VA = "0xF4BFE4")]
	private static void fillPointers(string outFile, string[] fileName, string[] inFilePath, ref IntPtr[] fp, ref IntPtr[] np)
	{
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0xF4C6D8", Offset = "0xF4C6D8", VA = "0xF4C6D8")]
	private static void fillLists(string fdir, bool includeRoot, ref List<string> inFilePath, ref List<string> fileName)
	{
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0xF4C678", Offset = "0xF4C678", VA = "0xF4C678")]
	public static int getAllFiles(string dir)
	{
		return default(int);
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0xF4C9C0", Offset = "0xF4C9C0", VA = "0xF4C9C0")]
	public static long getFileSize(string file)
	{
		return default(long);
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0xF4CA4C", Offset = "0xF4CA4C", VA = "0xF4CA4C")]
	public static ulong getDirSize(string dir)
	{
		return default(ulong);
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0xF4CB58", Offset = "0xF4CB58", VA = "0xF4CB58")]
	public static int tarExtract(string inFile, [Optional] string outPath, [Optional] int[] progress, [Optional] ulong[] byteProgress)
	{
		return default(int);
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0xF4CCE4", Offset = "0xF4CCE4", VA = "0xF4CCE4")]
	public static int tarExtractEntry(string inFile, string entry, [Optional] string outPath, bool fullPaths = true, [Optional] ulong[] byteProgress)
	{
		return default(int);
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0xF4CF08", Offset = "0xF4CF08", VA = "0xF4CF08")]
	public static int tarDir(string sourceDir, [Optional] string outFile, bool includeRoot = false, [Optional] int[] progress, [Optional] ulong[] byteProgress)
	{
		return default(int);
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0xF4D1B0", Offset = "0xF4D1B0", VA = "0xF4D1B0")]
	public static int tarList(string outFile, string[] inFilePath, [Optional] string[] fileName, [Optional] int[] progress, [Optional] ulong[] byteProgress)
	{
		return default(int);
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0xF4D494", Offset = "0xF4D494", VA = "0xF4D494")]
	public static ulong getTarInfo(string tarArchive)
	{
		return default(ulong);
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0xF4D944", Offset = "0xF4D944", VA = "0xF4D944")]
	public static DateTime entryDateTime(string zipArchive, string entry, [Optional] byte[] FileBuffer)
	{
		return default(DateTime);
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0xF4DB24", Offset = "0xF4DB24", VA = "0xF4DB24")]
	public static void free_inmemory(inMemory t)
	{
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0xF4DD28", Offset = "0xF4DD28", VA = "0xF4DD28")]
	public static bool inMemoryZipStart(inMemory t)
	{
		return default(bool);
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0xF4E040", Offset = "0xF4E040", VA = "0xF4E040")]
	public static int inMemoryZipAdd(inMemory t, int levelOfCompression, byte[] buffer, string fileName, [Optional] string comment, [Optional] string password, bool useBz2 = false)
	{
		return default(int);
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0xF4DEDC", Offset = "0xF4DEDC", VA = "0xF4DEDC")]
	public static IntPtr inMemoryZipClose(inMemory t)
	{
		return default(IntPtr);
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0xF4E220", Offset = "0xF4E220", VA = "0xF4E220")]
	public static IntPtr compress_Buf2Mem(inMemory t, int levelOfCompression, byte[] buffer, string fileName, [Optional] string comment, [Optional] string password, bool useBz2 = false)
	{
		return default(IntPtr);
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0xF4E458", Offset = "0xF4E458", VA = "0xF4E458")]
	public static int decompress_Mem2File(inMemory t, string outPath, [Optional] int[] progress, [Optional] ulong[] proc, [Optional] string password)
	{
		return default(int);
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0xF4E6D4", Offset = "0xF4E6D4", VA = "0xF4E6D4")]
	public static int entry2BufferMem(inMemory t, string entry, ref byte[] buffer, [Optional] string password)
	{
		return default(int);
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0xF4E8C4", Offset = "0xF4E8C4", VA = "0xF4E8C4")]
	public static byte[] entry2BufferMem(inMemory t, string entry, [Optional] string password)
	{
		return null;
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0xF4EA74", Offset = "0xF4EA74", VA = "0xF4EA74")]
	public static int entry2FixedBufferMem(inMemory t, string entry, ref byte[] fixedBuffer, [Optional] string password)
	{
		return default(int);
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0xF4EC24", Offset = "0xF4EC24", VA = "0xF4EC24")]
	public static ulong getFileInfoMem(inMemory t)
	{
		return default(ulong);
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0xF4F358", Offset = "0xF4F358", VA = "0xF4F358")]
	public static int entry2Buffer(string zipArchive, string entry, ref byte[] buffer, [Optional] byte[] FileBuffer, [Optional] string password)
	{
		return default(int);
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0xF4F5D8", Offset = "0xF4F5D8", VA = "0xF4F5D8")]
	public static int entry2FixedBuffer(string zipArchive, string entry, ref byte[] fixedBuffer, [Optional] byte[] FileBuffer, [Optional] string password)
	{
		return default(int);
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0xF4F854", Offset = "0xF4F854", VA = "0xF4F854")]
	public static byte[] entry2Buffer(string zipArchive, string entry, [Optional] byte[] FileBuffer, [Optional] string password)
	{
		return null;
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0xF4FAD4", Offset = "0xF4FAD4", VA = "0xF4FAD4")]
	public static Task<byte[]> entry2BufferAsync(string zipArchive, string entry, [Optional] byte[] FileBuffer, [Optional] string password)
	{
		return null;
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0xF4FD9C", Offset = "0xF4FD9C", VA = "0xF4FD9C")]
	public static bool validateFile(string zipArchive, [Optional] byte[] FileBuffer)
	{
		return default(bool);
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0xF4FE8C", Offset = "0xF4FE8C", VA = "0xF4FE8C")]
	public static bool getZipInfo(string fileName)
	{
		return default(bool);
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0xF50CC0", Offset = "0xF50CC0", VA = "0xF50CC0")]
	public static bool getZipInfoMerged(string fileName, ref int pos, ref int size, bool getCentralDirectory = false)
	{
		return default(bool);
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0xF51124", Offset = "0xF51124", VA = "0xF51124")]
	public static bool getZipInfoMerged(byte[] buffer, ref int pos, ref int size, bool getCentralDirectory = false)
	{
		return default(bool);
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0xF51578", Offset = "0xF51578", VA = "0xF51578")]
	public static bool getZipInfoMerged(byte[] buffer)
	{
		return default(bool);
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0xF502E8", Offset = "0xF502E8", VA = "0xF502E8")]
	private static bool findPK(BinaryReader reader)
	{
		return default(bool);
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0xF50490", Offset = "0xF50490", VA = "0xF50490")]
	private static int findEnd(BinaryReader reader, ref int pos, ref int size)
	{
		return default(int);
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0xF50788", Offset = "0xF50788", VA = "0xF50788")]
	private static void getCentralDir(BinaryReader reader, int count)
	{
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0xF519C4", Offset = "0xF519C4", VA = "0xF519C4")]
	public static byte[] getMergedZip(string filePath, ref int position, ref int siz)
	{
		return null;
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0xF51D84", Offset = "0xF51D84", VA = "0xF51D84")]
	public static byte[] getMergedZip(string filePath)
	{
		return null;
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0xF52130", Offset = "0xF52130", VA = "0xF52130")]
	public static byte[] getMergedZip(byte[] buffer, ref int position, ref int siz)
	{
		return null;
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0xF524F8", Offset = "0xF524F8", VA = "0xF524F8")]
	public static byte[] getMergedZip(byte[] buffer)
	{
		return null;
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0xF528AC", Offset = "0xF528AC", VA = "0xF528AC")]
	public static int decompressZipMerged(string file, string outPath, [Optional] int[] progress, [Optional] ulong[] proc, [Optional] string password)
	{
		return default(int);
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0xF52B6C", Offset = "0xF52B6C", VA = "0xF52B6C")]
	public static int decompressZipMerged(byte[] buffer, string outPath, [Optional] int[] progress, [Optional] ulong[] proc, [Optional] string password)
	{
		return default(int);
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0xF52D88", Offset = "0xF52D88", VA = "0xF52D88")]
	private static void writeFile(byte[] tb, string entry, string outPath, string overrideEntryName, ref int res)
	{
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0xF52EC4", Offset = "0xF52EC4", VA = "0xF52EC4")]
	public static int entry2FileMerged(string file, string entry, string outPath, [Optional] string overrideEntryName, [Optional] string password)
	{
		return default(int);
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0xF530E0", Offset = "0xF530E0", VA = "0xF530E0")]
	public static int entry2FileMerged(byte[] buffer, string entry, string outPath, [Optional] string overrideEntryName, [Optional] string password)
	{
		return default(int);
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0xF532FC", Offset = "0xF532FC", VA = "0xF532FC")]
	public static byte[] entry2BufferMerged(string file, string entry, [Optional] string password)
	{
		return null;
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0xF534AC", Offset = "0xF534AC", VA = "0xF534AC")]
	public static int entry2BufferMerged(string file, string entry, ref byte[] refBuffer, [Optional] string password)
	{
		return default(int);
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0xF53664", Offset = "0xF53664", VA = "0xF53664")]
	public static int entry2FixedBufferMerged(string file, string entry, ref byte[] fixedBuffer, [Optional] string password)
	{
		return default(int);
	}

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0xF5381C", Offset = "0xF5381C", VA = "0xF5381C")]
	public static byte[] entry2BufferMerged(byte[] buffer, string entry, [Optional] string password)
	{
		return null;
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0xF539B8", Offset = "0xF539B8", VA = "0xF539B8")]
	public static int entry2BufferMerged(byte[] buffer, string entry, ref byte[] refBuffer, [Optional] string password)
	{
		return default(int);
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0xF53B68", Offset = "0xF53B68", VA = "0xF53B68")]
	public static int entry2FixedBufferMerged(byte[] buffer, string entry, ref byte[] fixedBuffer, [Optional] string password)
	{
		return default(int);
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0xF53D18", Offset = "0xF53D18", VA = "0xF53D18")]
	public static bool compressBuffer(byte[] source, ref byte[] outBuffer, int levelOfCompression)
	{
		return default(bool);
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0xF53EC8", Offset = "0xF53EC8", VA = "0xF53EC8")]
	public static int compressBufferFixed(byte[] source, ref byte[] outBuffer, int levelOfCompression, bool safe = true)
	{
		return default(int);
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0xF54080", Offset = "0xF54080", VA = "0xF54080")]
	public static byte[] compressBuffer(byte[] source, int levelOfCompression)
	{
		return null;
	}

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0xF5422C", Offset = "0xF5422C", VA = "0xF5422C")]
	public static bool decompressBuffer(byte[] source, ref byte[] outBuffer)
	{
		return default(bool);
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0xF543C4", Offset = "0xF543C4", VA = "0xF543C4")]
	public static int decompressBufferFixed(byte[] source, ref byte[] outBuffer, bool safe = true)
	{
		return default(int);
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0xF5455C", Offset = "0xF5455C", VA = "0xF5455C")]
	public static byte[] decompressBuffer(byte[] source)
	{
		return null;
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0xF546F0", Offset = "0xF546F0", VA = "0xF546F0")]
	public static int gzip(byte[] source, byte[] outBuffer, int level, bool addHeader = true, bool addFooter = true, bool overrideDateTimeWithLength = false)
	{
		return default(int);
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0xF5489C", Offset = "0xF5489C", VA = "0xF5489C")]
	public static int gzipUncompressedSize(byte[] source)
	{
		return default(int);
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0xF54910", Offset = "0xF54910", VA = "0xF54910")]
	public static int gzipCompressedSize(byte[] source, int offset = 0)
	{
		return default(int);
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0xF54A0C", Offset = "0xF54A0C", VA = "0xF54A0C")]
	public static int findGzStart(byte[] buffer)
	{
		return default(int);
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0xF54AAC", Offset = "0xF54AAC", VA = "0xF54AAC")]
	public static int unGzip(byte[] source, byte[] outBuffer, bool hasHeader = true, bool hasFooter = true)
	{
		return default(int);
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0xF54BA8", Offset = "0xF54BA8", VA = "0xF54BA8")]
	public static int unGzip2(byte[] source, byte[] outBuffer)
	{
		return default(int);
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0xF54C8C", Offset = "0xF54C8C", VA = "0xF54C8C")]
	public static int unGzip2Merged(byte[] source, int offset, int bufferLength, byte[] outBuffer)
	{
		return default(int);
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0xF54DAC", Offset = "0xF54DAC", VA = "0xF54DAC")]
	public static int gzipFile(string inFile, [Optional] string outFile, int level = 9, [Optional] ulong[] progress, bool addHeader = true)
	{
		return default(int);
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0xF54FAC", Offset = "0xF54FAC", VA = "0xF54FAC")]
	public static int ungzipFile(string inFile, [Optional] string outFile, [Optional] ulong[] progress)
	{
		return default(int);
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0xF55200", Offset = "0xF55200", VA = "0xF55200")]
	public static int bz2Create(string inFile, [Optional] string outFile, int level = 9, [Optional] ulong[] byteProgress)
	{
		return default(int);
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0xF553E4", Offset = "0xF553E4", VA = "0xF553E4")]
	public static int bz2Decompress(string inFile, [Optional] string outFile, [Optional] ulong[] byteProgress)
	{
		return default(int);
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0xF55648", Offset = "0xF55648", VA = "0xF55648")]
	public lzip()
	{
	}
}
namespace RootMotion
{
	[Token(Token = "0x2000022")]
	[AddComponentMenu("Scripts/RootMotion/Baker")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page3.html")]
	public abstract class Baker : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000023")]
		public enum Mode
		{
			[Token(Token = "0x4000076")]
			AnimationClips,
			[Token(Token = "0x4000077")]
			AnimationStates,
			[Token(Token = "0x4000078")]
			PlayableDirector,
			[Token(Token = "0x4000079")]
			Realtime
		}

		[Token(Token = "0x2000024")]
		public delegate void BakerDelegate(AnimationClip clip, float time);

		[Serializable]
		[Token(Token = "0x2000025")]
		public class ClipSettings
		{
			[Serializable]
			[Token(Token = "0x2000026")]
			public enum BasedUponRotation
			{
				[Token(Token = "0x4000087")]
				Original,
				[Token(Token = "0x4000088")]
				BodyOrientation
			}

			[Serializable]
			[Token(Token = "0x2000027")]
			public enum BasedUponY
			{
				[Token(Token = "0x400008A")]
				Original,
				[Token(Token = "0x400008B")]
				CenterOfMass,
				[Token(Token = "0x400008C")]
				Feet
			}

			[Serializable]
			[Token(Token = "0x2000028")]
			public enum BasedUponXZ
			{
				[Token(Token = "0x400008E")]
				Original,
				[Token(Token = "0x400008F")]
				CenterOfMass
			}

			[Token(Token = "0x400007A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool loopTime;

			[Token(Token = "0x400007B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
			public bool loopBlend;

			[Token(Token = "0x400007C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float cycleOffset;

			[Token(Token = "0x400007D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool loopBlendOrientation;

			[Token(Token = "0x400007E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public BasedUponRotation basedUponRotation;

			[Token(Token = "0x400007F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float orientationOffsetY;

			[Token(Token = "0x4000080")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public bool loopBlendPositionY;

			[Token(Token = "0x4000081")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public BasedUponY basedUponY;

			[Token(Token = "0x4000082")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float level;

			[Token(Token = "0x4000083")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool loopBlendPositionXZ;

			[Token(Token = "0x4000084")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public BasedUponXZ basedUponXZ;

			[Token(Token = "0x4000085")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool mirror;

			[Token(Token = "0x6000112")]
			[Address(RVA = "0xF55CD4", Offset = "0xF55CD4", VA = "0xF55CD4")]
			public ClipSettings()
			{
			}
		}

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("In AnimationClips, AnimationStates or PlayableDirector mode - the frame rate at which the animation clip will be sampled. In Realtime mode - the frame rate at which the pose will be sampled. With the latter, the frame rate is not guaranteed if the player is not able to reach it.")]
		[Range(1f, 90f)]
		public int frameRate;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("Maximum allowed error for keyframe reduction.")]
		[Range(0f, 0.1f)]
		public float keyReductionError;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("AnimationClips mode can be used to bake a batch of AnimationClips directly without the need of setting up an AnimatorController. AnimationStates mode is useful for when you need to set up a more complex rig with layers and AvatarMasks in Mecanim. PlayableDirector mode bakes a Timeline. Realtime mode is for continuous baking of gameplay, ragdoll phsysics or PuppetMaster dynamics.")]
		public Mode mode;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("AnimationClips to bake.")]
		public AnimationClip[] animationClips;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The name of the AnimationStates to bake (must be on the base layer) in the Animator above (Right-click on this component header and select 'Find Animation States' to have Baker fill those in automatically, required that state names match with the names of the clips used in them).")]
		public string[] animationStates;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The folder to save the baked AnimationClips to.")]
		public string saveToFolder;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("String that will be added to each clip or animation state name for the saved clip. For example if your animation state/clip names were 'Idle' and 'Walk', then with '_Baked' as Append Name, the Baker will create 'Idle_Baked' and 'Walk_Baked' animation clips.")]
		public string appendName;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Name of the created AnimationClip file.")]
		public string saveName;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[HideInInspector]
		public Animator animator;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[HideInInspector]
		public PlayableDirector director;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public BakerDelegate OnStartClip;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public BakerDelegate OnUpdateClip;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[Tooltip("If enabled, baked clips will have the same AnimationClipSettings as the clips used for baking. If disabled, clip settings from below will be applied to all the baked clips.")]
		public bool inheritClipSettings;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Tooltip("AnimationClipSettings applied to the baked animation clip.")]
		public ClipSettings clipSettings;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		protected bool addLoopFrame;

		[Token(Token = "0x17000017")]
		public bool isBaking
		{
			[Token(Token = "0x60000FF")]
			[Address(RVA = "0xF559D8", Offset = "0xF559D8", VA = "0xF559D8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000100")]
			[Address(RVA = "0xF559E0", Offset = "0xF559E0", VA = "0xF559E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000018")]
		public float bakingProgress
		{
			[Token(Token = "0x6000101")]
			[Address(RVA = "0xF559EC", Offset = "0xF559EC", VA = "0xF559EC")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000102")]
			[Address(RVA = "0xF559F4", Offset = "0xF559F4", VA = "0xF559F4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000019")]
		protected float clipLength
		{
			[Token(Token = "0x6000108")]
			[Address(RVA = "0xF559FC", Offset = "0xF559FC", VA = "0xF559FC")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000109")]
			[Address(RVA = "0xF55A04", Offset = "0xF55A04", VA = "0xF55A04")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0xF558C8", Offset = "0xF558C8", VA = "0xF558C8")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0xF5590C", Offset = "0xF5590C", VA = "0xF5590C")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0xF55950", Offset = "0xF55950", VA = "0xF55950")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0xF55994", Offset = "0xF55994", VA = "0xF55994")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000103")]
		protected abstract Transform GetCharacterRoot();

		[Token(Token = "0x6000104")]
		protected abstract void OnStartBaking();

		[Token(Token = "0x6000105")]
		protected abstract void OnSetLoopFrame(float time);

		[Token(Token = "0x6000106")]
		protected abstract void OnSetCurves(ref AnimationClip clip);

		[Token(Token = "0x6000107")]
		protected abstract void OnSetKeyframes(float time, bool lastFrame);

		[Token(Token = "0x600010A")]
		[Address(RVA = "0xF55A0C", Offset = "0xF55A0C", VA = "0xF55A0C")]
		public void BakeClip()
		{
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0xF55A10", Offset = "0xF55A10", VA = "0xF55A10")]
		public void StartBaking()
		{
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0xF55A14", Offset = "0xF55A14", VA = "0xF55A14")]
		public void StopBaking()
		{
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0xF55A18", Offset = "0xF55A18", VA = "0xF55A18")]
		protected Baker()
		{
		}
	}
	[Token(Token = "0x2000029")]
	public class GenericBaker : Baker
	{
		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8D")]
		[Tooltip("If true, produced AnimationClips will be marked as Legacy and usable with the Legacy animation system.")]
		public bool markAsLegacy;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[Tooltip("Root Transform of the hierarchy to bake.")]
		public Transform root;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[Tooltip("Root Node used for root motion.")]
		public Transform rootNode;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[Tooltip("List of Transforms to ignore, rotation curves will not be baked for these Transforms.")]
		public Transform[] ignoreList;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[Tooltip("LocalPosition curves will be baked for these Transforms only. If you are baking a character, the pelvis bone should be added to this array.")]
		public Transform[] bakePositionList;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private BakerTransform[] children;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private BakerTransform rootChild;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int rootChildIndex;

		[Token(Token = "0x6000113")]
		[Address(RVA = "0xF55CDC", Offset = "0xF55CDC", VA = "0xF55CDC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0xF56120", Offset = "0xF56120", VA = "0xF56120", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0xF56128", Offset = "0xF56128", VA = "0xF56128", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0xF56364", Offset = "0xF56364", VA = "0xF56364", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0xF565C8", Offset = "0xF565C8", VA = "0xF565C8", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0xF568E0", Offset = "0xF568E0", VA = "0xF568E0", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0xF55F08", Offset = "0xF55F08", VA = "0xF55F08")]
		private bool IsIgnored(Transform t)
		{
			return default(bool);
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0xF55FC0", Offset = "0xF55FC0", VA = "0xF55FC0")]
		private bool BakePosition(Transform t)
		{
			return default(bool);
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0xF56B40", Offset = "0xF56B40", VA = "0xF56B40")]
		public GenericBaker()
		{
		}
	}
	[Token(Token = "0x200002A")]
	public class TQ
	{
		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 t;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion q;

		[Token(Token = "0x600011C")]
		[Address(RVA = "0xF56BA8", Offset = "0xF56BA8", VA = "0xF56BA8")]
		public TQ()
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0xF56BB0", Offset = "0xF56BB0", VA = "0xF56BB0")]
		public TQ(Vector3 translation, Quaternion rotation)
		{
		}
	}
	[Token(Token = "0x200002B")]
	public class AvatarUtility
	{
		[Token(Token = "0x600011E")]
		[Address(RVA = "0xF56C14", Offset = "0xF56C14", VA = "0xF56C14")]
		public static Quaternion GetPostRotation(Avatar avatar, AvatarIKGoal avatarIKGoal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0xF56E70", Offset = "0xF56E70", VA = "0xF56E70")]
		public static TQ GetIKGoalTQ(Avatar avatar, float humanScale, AvatarIKGoal avatarIKGoal, TQ bodyPositionRotation, TQ boneTQ)
		{
			return null;
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0xF574E0", Offset = "0xF574E0", VA = "0xF574E0")]
		public static TQ WorldSpaceIKGoalToBone(TQ goalTQ, Avatar avatar, AvatarIKGoal avatarIKGoal)
		{
			return null;
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0xF579A8", Offset = "0xF579A8", VA = "0xF579A8")]
		public static TQ GetWorldSpaceIKGoal(BakerHumanoidQT ikQT, BakerHumanoidQT rootQT, float time, float humanScale)
		{
			return null;
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0xF56E50", Offset = "0xF56E50", VA = "0xF56E50")]
		public static HumanBodyBones HumanIDFromAvatarIKGoal(AvatarIKGoal avatarIKGoal)
		{
			return default(HumanBodyBones);
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0xF57B94", Offset = "0xF57B94", VA = "0xF57B94")]
		public AvatarUtility()
		{
		}
	}
	[Token(Token = "0x200002C")]
	public static class BakerUtilities
	{
		[Token(Token = "0x6000124")]
		[Address(RVA = "0xF57B9C", Offset = "0xF57B9C", VA = "0xF57B9C")]
		public static void ReduceKeyframes(AnimationCurve curve, float maxError)
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0xF57BD4", Offset = "0xF57BD4", VA = "0xF57BD4")]
		public static Keyframe[] GetReducedKeyframes(AnimationCurve curve, float maxError)
		{
			return null;
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0xF57F98", Offset = "0xF57F98", VA = "0xF57F98")]
		public static void SetLoopFrame(float time, AnimationCurve curve)
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0xF58178", Offset = "0xF58178", VA = "0xF58178")]
		public static void SetTangentMode(AnimationCurve curve)
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0xF5817C", Offset = "0xF5817C", VA = "0xF5817C")]
		public static Quaternion EnsureQuaternionContinuity(Quaternion lastQ, Quaternion q)
		{
			return default(Quaternion);
		}
	}
	[Serializable]
	[Token(Token = "0x200002D")]
	public class BakerHumanoidQT
	{
		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Transform transform;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string Qx;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string Qy;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string Qz;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string Qw;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string Tx;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string Ty;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private string Tz;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AnimationCurve rotX;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AnimationCurve rotY;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public AnimationCurve rotZ;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public AnimationCurve rotW;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public AnimationCurve posX;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public AnimationCurve posY;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public AnimationCurve posZ;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private AvatarIKGoal goal;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Quaternion lastQ;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private bool lastQSet;

		[Token(Token = "0x6000129")]
		[Address(RVA = "0xF58310", Offset = "0xF58310", VA = "0xF58310")]
		public BakerHumanoidQT(string name)
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0xF58674", Offset = "0xF58674", VA = "0xF58674")]
		public BakerHumanoidQT(Transform transform, AvatarIKGoal goal, string name)
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0xF5885C", Offset = "0xF5885C", VA = "0xF5885C")]
		public Quaternion EvaluateRotation(float time)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0xF588EC", Offset = "0xF588EC", VA = "0xF588EC")]
		public Vector3 EvaluatePosition(float time)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0xF57ACC", Offset = "0xF57ACC", VA = "0xF57ACC")]
		public TQ Evaluate(float time)
		{
			return null;
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0xF58960", Offset = "0xF58960", VA = "0xF58960")]
		public void GetCurvesFromClip(AnimationClip clip, Animator animator)
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0xF584DC", Offset = "0xF584DC", VA = "0xF584DC")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0xF58964", Offset = "0xF58964", VA = "0xF58964")]
		public void SetIKKeyframes(float time, Avatar avatar, Transform root, float humanScale, Vector3 bodyPosition, Quaternion bodyRotation)
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0xF58CF4", Offset = "0xF58CF4", VA = "0xF58CF4")]
		public void SetKeyframes(float time, Vector3 pos, Quaternion rot)
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0xF58DE4", Offset = "0xF58DE4", VA = "0xF58DE4")]
		public void MoveLastKeyframes(float time)
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0xF58EC8", Offset = "0xF58EC8", VA = "0xF58EC8")]
		public void SetLoopFrame(float time)
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0xF58F30", Offset = "0xF58F30", VA = "0xF58F30")]
		public void SetRootLoopFrame(float time)
		{
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0xF58E4C", Offset = "0xF58E4C", VA = "0xF58E4C")]
		private void MoveLastKeyframe(float time, AnimationCurve curve)
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0xF58F34", Offset = "0xF58F34", VA = "0xF58F34")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0xF58FDC", Offset = "0xF58FDC", VA = "0xF58FDC")]
		public void SetCurves(ref AnimationClip clip, float maxError, float lengthMlp)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002E")]
	public class BakerMuscle
	{
		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AnimationCurve curve;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int muscleIndex;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string propertyName;

		[Token(Token = "0x6000138")]
		[Address(RVA = "0xF592C8", Offset = "0xF592C8", VA = "0xF592C8")]
		public BakerMuscle(int muscleIndex)
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0xF59338", Offset = "0xF59338", VA = "0xF59338")]
		private string MuscleNameToPropertyName(string n)
		{
			return null;
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0xF59DD4", Offset = "0xF59DD4", VA = "0xF59DD4")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0xF59E7C", Offset = "0xF59E7C", VA = "0xF59E7C")]
		public void SetCurves(ref AnimationClip clip, float maxError, float lengthMlp)
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0xF59D6C", Offset = "0xF59D6C", VA = "0xF59D6C")]
		public void Reset()
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0xF59F70", Offset = "0xF59F70", VA = "0xF59F70")]
		public void SetKeyframe(float time, float[] muscles)
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0xF59FAC", Offset = "0xF59FAC", VA = "0xF59FAC")]
		public void SetLoopFrame(float time)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002F")]
	public class BakerTransform
	{
		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AnimationCurve posX;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AnimationCurve posY;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AnimationCurve posZ;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve rotX;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve rotY;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AnimationCurve rotZ;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public AnimationCurve rotW;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private string relativePath;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool recordPosition;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 relativePosition;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool isRootNode;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Quaternion relativeRotation;

		[Token(Token = "0x600013F")]
		[Address(RVA = "0xF56078", Offset = "0xF56078", VA = "0xF56078")]
		public BakerTransform(Transform transform, Transform root, bool recordPosition, bool isRootNode)
		{
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0xF56350", Offset = "0xF56350", VA = "0xF56350")]
		public void SetRelativeSpace(Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0xF5662C", Offset = "0xF5662C", VA = "0xF5662C")]
		public void SetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0xF59FB4", Offset = "0xF59FB4", VA = "0xF59FB4")]
		private void AddRootMotionCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0xF561F8", Offset = "0xF561F8", VA = "0xF561F8")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0xF5A23C", Offset = "0xF5A23C", VA = "0xF5A23C")]
		public void ReduceKeyframes(float maxError)
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0xF5694C", Offset = "0xF5694C", VA = "0xF5694C")]
		public void SetKeyframes(float time)
		{
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0xF563D0", Offset = "0xF563D0", VA = "0xF563D0")]
		public void AddLoopFrame(float time)
		{
		}
	}
	[Token(Token = "0x2000030")]
	public class HumanoidBaker : Baker
	{
		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8D")]
		[Tooltip("Should the hand IK curves be added to the animation? Disable this if the original hand positions are not important when using the clip on another character via Humanoid retargeting.")]
		public bool bakeHandIK;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[Tooltip("Max keyframe reduction error for the Root.Q/T, LeftFoot IK and RightFoot IK channels. Having a larger error value for 'Key Reduction Error' and a smaller one for this enables you to optimize clip data size without the floating feet effect by enabling 'Foot IK' in the Animator.")]
		[Range(0f, 0.1f)]
		public float IKKeyReductionError;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		[Tooltip("Frame rate divider for the muscle curves. If you have 'Frame Rate' set to 30, and this value set to 3, the muscle curves will be baked at 10 fps. Only the Root Q/T and Hand and Foot IK curves will be baked at 30. This enables you to optimize clip data size without the floating feet effect by enabling 'Foot IK' in the Animator.")]
		[Range(1f, 9f)]
		public int muscleFrameRateDiv;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private BakerMuscle[] bakerMuscles;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private BakerHumanoidQT rootQT;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private BakerHumanoidQT leftFootQT;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private BakerHumanoidQT rightFootQT;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private BakerHumanoidQT leftHandQT;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private BakerHumanoidQT rightHandQT;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float[] muscles;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private HumanPose pose;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private HumanPoseHandler handler;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private Vector3 bodyPosition;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private Quaternion bodyRotation;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		private int mN;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Quaternion lastBodyRotation;

		[Token(Token = "0x6000147")]
		[Address(RVA = "0xF5A2A4", Offset = "0xF5A2A4", VA = "0xF5A2A4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0xF5A804", Offset = "0xF5A804", VA = "0xF5A804", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0xF5A820", Offset = "0xF5A820", VA = "0xF5A820", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0xF5A8F8", Offset = "0xF5A8F8", VA = "0xF5A8F8", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0xF5A9B4", Offset = "0xF5A9B4", VA = "0xF5A9B4", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0xF5AB54", Offset = "0xF5AB54", VA = "0xF5AB54", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0xF5AE78", Offset = "0xF5AE78", VA = "0xF5AE78")]
		private void UpdateHumanPose()
		{
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0xF5AF58", Offset = "0xF5AF58", VA = "0xF5AF58")]
		public HumanoidBaker()
		{
		}
	}
	[Token(Token = "0x2000031")]
	public class CameraController : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000032")]
		public enum UpdateMode
		{
			[Token(Token = "0x40000F3")]
			Update,
			[Token(Token = "0x40000F4")]
			FixedUpdate,
			[Token(Token = "0x40000F5")]
			LateUpdate,
			[Token(Token = "0x40000F6")]
			FixedLateUpdate
		}

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform rotationSpace;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UpdateMode updateMode;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool lockCursor;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		[Header("Position")]
		public bool smoothFollow;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 offset;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float followSpeed;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Header("Rotation")]
		public float rotationSensitivity;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float yMinLimit;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float yMaxLimit;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool rotateAlways;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
		public bool rotateOnLeftButton;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4E")]
		public bool rotateOnRightButton;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4F")]
		public bool rotateOnMiddleButton;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Header("Distance")]
		public float distance;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float minDistance;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float maxDistance;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float zoomSpeed;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float zoomSensitivity;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[Header("Blocking")]
		public LayerMask blockingLayers;

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float blockingRadius;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float blockingSmoothTime;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float blockingOriginOffset;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[Range(0f, 1f)]
		public float blockedOffset;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 targetDistance;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 position;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Quaternion rotation;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Vector3 smoothPosition;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Camera cam;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool fixedFrame;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private float fixedDeltaTime;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Quaternion r;

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Vector3 lastUp;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private float blockedDistance;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private float blockedDistanceV;

		[Token(Token = "0x1700001A")]
		public float x
		{
			[Token(Token = "0x600014F")]
			[Address(RVA = "0xF5B008", Offset = "0xF5B008", VA = "0xF5B008")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000150")]
			[Address(RVA = "0xF5B010", Offset = "0xF5B010", VA = "0xF5B010")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700001B")]
		public float y
		{
			[Token(Token = "0x6000151")]
			[Address(RVA = "0xF5B018", Offset = "0xF5B018", VA = "0xF5B018")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000152")]
			[Address(RVA = "0xF5B020", Offset = "0xF5B020", VA = "0xF5B020")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		public float distanceTarget
		{
			[Token(Token = "0x6000153")]
			[Address(RVA = "0xF5B028", Offset = "0xF5B028", VA = "0xF5B028")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000154")]
			[Address(RVA = "0xF5B030", Offset = "0xF5B030", VA = "0xF5B030")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700001D")]
		private float zoomAdd
		{
			[Token(Token = "0x600015E")]
			[Address(RVA = "0xF5BA98", Offset = "0xF5BA98", VA = "0xF5BA98")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0xF5B038", Offset = "0xF5B038", VA = "0xF5B038")]
		public void SetAngles(Quaternion rotation)
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0xF5B070", Offset = "0xF5B070", VA = "0xF5B070")]
		public void SetAngles(float yaw, float pitch)
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0xF5B078", Offset = "0xF5B078", VA = "0xF5B078", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0xF5B1B0", Offset = "0xF5B1B0", VA = "0xF5B1B0", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0xF5B1F8", Offset = "0xF5B1F8", VA = "0xF5B1F8", Slot = "6")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0xF5B250", Offset = "0xF5B250", VA = "0xF5B250", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0xF5B2A8", Offset = "0xF5B2A8", VA = "0xF5B2A8")]
		public void UpdateInput()
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0xF5B1DC", Offset = "0xF5B1DC", VA = "0xF5B1DC")]
		public void UpdateTransform()
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0xF5B434", Offset = "0xF5B434", VA = "0xF5B434")]
		public void UpdateTransform(float deltaTime)
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0xF5BA5C", Offset = "0xF5BA5C", VA = "0xF5BA5C")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0xF5BB04", Offset = "0xF5BB04", VA = "0xF5BB04")]
		public CameraController()
		{
		}
	}
	[Token(Token = "0x2000033")]
	public class CameraControllerFPS : MonoBehaviour
	{
		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float rotationSensitivity;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float yMinLimit;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float yMaxLimit;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float x;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float y;

		[Token(Token = "0x6000161")]
		[Address(RVA = "0xF5BBCC", Offset = "0xF5BBCC", VA = "0xF5BBCC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0xF5BBF8", Offset = "0xF5BBF8", VA = "0xF5BBF8")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0xF5BE1C", Offset = "0xF5BE1C", VA = "0xF5BE1C")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0xF5BE58", Offset = "0xF5BE58", VA = "0xF5BE58")]
		public CameraControllerFPS()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000034")]
	public enum Axis
	{
		[Token(Token = "0x40000FD")]
		X,
		[Token(Token = "0x40000FE")]
		Y,
		[Token(Token = "0x40000FF")]
		Z
	}
	[Token(Token = "0x2000035")]
	public class AxisTools
	{
		[Token(Token = "0x6000165")]
		[Address(RVA = "0xF5BE74", Offset = "0xF5BE74", VA = "0xF5BE74")]
		public static Vector3 ToVector3(Axis axis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0xF5BF54", Offset = "0xF5BF54", VA = "0xF5BF54")]
		public static Axis ToAxis(Vector3 v)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0xF5BF8C", Offset = "0xF5BF8C", VA = "0xF5BF8C")]
		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0xF5C0D4", Offset = "0xF5C0D4", VA = "0xF5C0D4")]
		public static Axis GetAxisToDirection(Transform t, Vector3 direction)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0xF5C088", Offset = "0xF5C088", VA = "0xF5C088")]
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0xF5C1D0", Offset = "0xF5C1D0", VA = "0xF5C1D0")]
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0xF5C214", Offset = "0xF5C214", VA = "0xF5C214")]
		public static Vector3 GetAxisVectorToDirection(Quaternion r, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0xF5C4D4", Offset = "0xF5C4D4", VA = "0xF5C4D4")]
		public AxisTools()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000036")]
	public class BipedLimbOrientations
	{
		[Serializable]
		[Token(Token = "0x2000037")]
		public class LimbOrientation
		{
			[Token(Token = "0x4000104")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 upperBoneForwardAxis;

			[Token(Token = "0x4000105")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 lowerBoneForwardAxis;

			[Token(Token = "0x4000106")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 lastBoneLeftAxis;

			[Token(Token = "0x6000170")]
			[Address(RVA = "0xF5C808", Offset = "0xF5C808", VA = "0xF5C808")]
			public LimbOrientation(Vector3 upperBoneForwardAxis, Vector3 lowerBoneForwardAxis, Vector3 lastBoneLeftAxis)
			{
			}
		}

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LimbOrientation leftArm;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LimbOrientation rightArm;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LimbOrientation leftLeg;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LimbOrientation rightLeg;

		[Token(Token = "0x1700001E")]
		public static BipedLimbOrientations UMA
		{
			[Token(Token = "0x600016E")]
			[Address(RVA = "0xF5C550", Offset = "0xF5C550", VA = "0xF5C550")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001F")]
		public static BipedLimbOrientations MaxBiped
		{
			[Token(Token = "0x600016F")]
			[Address(RVA = "0xF5C87C", Offset = "0xF5C87C", VA = "0xF5C87C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0xF5C4DC", Offset = "0xF5C4DC", VA = "0xF5C4DC")]
		public BipedLimbOrientations(LimbOrientation leftArm, LimbOrientation rightArm, LimbOrientation leftLeg, LimbOrientation rightLeg)
		{
		}
	}
	[Token(Token = "0x2000038")]
	public static class BipedNaming
	{
		[Serializable]
		[Token(Token = "0x2000039")]
		public enum BoneType
		{
			[Token(Token = "0x400011A")]
			Unassigned,
			[Token(Token = "0x400011B")]
			Spine,
			[Token(Token = "0x400011C")]
			Head,
			[Token(Token = "0x400011D")]
			Arm,
			[Token(Token = "0x400011E")]
			Leg,
			[Token(Token = "0x400011F")]
			Tail,
			[Token(Token = "0x4000120")]
			Eye
		}

		[Serializable]
		[Token(Token = "0x200003A")]
		public enum BoneSide
		{
			[Token(Token = "0x4000122")]
			Center,
			[Token(Token = "0x4000123")]
			Left,
			[Token(Token = "0x4000124")]
			Right
		}

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] typeLeft;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string[] typeRight;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static string[] typeSpine;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static string[] typeHead;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static string[] typeArm;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static string[] typeLeg;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static string[] typeTail;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static string[] typeEye;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static string[] typeExclude;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static string[] typeExcludeSpine;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static string[] typeExcludeHead;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static string[] typeExcludeArm;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static string[] typeExcludeLeg;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static string[] typeExcludeTail;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static string[] typeExcludeEye;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static string[] pelvis;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static string[] hand;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public static string[] foot;

		[Token(Token = "0x6000171")]
		[Address(RVA = "0xF5CB34", Offset = "0xF5CB34", VA = "0xF5CB34")]
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0xF5CE00", Offset = "0xF5CE00", VA = "0xF5CE00")]
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0xF5D03C", Offset = "0xF5D03C", VA = "0xF5D03C")]
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0xF5D0B0", Offset = "0xF5D0B0", VA = "0xF5D0B0")]
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0xF5D144", Offset = "0xF5D144", VA = "0xF5D144")]
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0xF5CCE8", Offset = "0xF5CCE8", VA = "0xF5CCE8")]
		public static BoneType GetBoneType(string boneName)
		{
			return default(BoneType);
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0xF5CFB4", Offset = "0xF5CFB4", VA = "0xF5CFB4")]
		public static BoneSide GetBoneSide(string boneName)
		{
			return default(BoneSide);
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0xF5D87C", Offset = "0xF5D87C", VA = "0xF5D87C")]
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0xF5D6D4", Offset = "0xF5D6D4", VA = "0xF5D6D4")]
		private static bool isLeft(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0xF5D7A8", Offset = "0xF5D7A8", VA = "0xF5D7A8")]
		private static bool isRight(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0xF5D32C", Offset = "0xF5D32C", VA = "0xF5D32C")]
		private static bool isSpine(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0xF5D3C8", Offset = "0xF5D3C8", VA = "0xF5D3C8")]
		private static bool isHead(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0xF5D464", Offset = "0xF5D464", VA = "0xF5D464")]
		private static bool isArm(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0xF5D500", Offset = "0xF5D500", VA = "0xF5D500")]
		private static bool isLeg(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0xF5D59C", Offset = "0xF5D59C", VA = "0xF5D59C")]
		private static bool isTail(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0xF5D638", Offset = "0xF5D638", VA = "0xF5D638")]
		private static bool isEye(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0xF5DA64", Offset = "0xF5DA64", VA = "0xF5DA64")]
		private static bool isTypeExclude(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0xF5D258", Offset = "0xF5D258", VA = "0xF5D258")]
		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0xF5D9E0", Offset = "0xF5D9E0", VA = "0xF5D9E0")]
		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0xF5DAC4", Offset = "0xF5DAC4", VA = "0xF5DAC4")]
		private static bool matchesLastLetter(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0xF5DB84", Offset = "0xF5DB84", VA = "0xF5DB84")]
		private static bool LastLetterIs(string boneName, string letter)
		{
			return default(bool);
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0xF5D96C", Offset = "0xF5D96C", VA = "0xF5D96C")]
		private static string firstLetter(string boneName)
		{
			return null;
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0xF5D8FC", Offset = "0xF5D8FC", VA = "0xF5D8FC")]
		private static string lastLetter(string boneName)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x200003B")]
	public class BipedReferences
	{
		[Token(Token = "0x200003C")]
		public struct AutoDetectParams
		{
			[Token(Token = "0x4000136")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool legsParentInSpine;

			[Token(Token = "0x4000137")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public bool includeEyes;

			[Token(Token = "0x17000022")]
			public static AutoDetectParams Default
			{
				[Token(Token = "0x60001A2")]
				[Address(RVA = "0xF64E5C", Offset = "0xF64E5C", VA = "0xF64E5C")]
				get
				{
					return default(AutoDetectParams);
				}
			}

			[Token(Token = "0x60001A1")]
			[Address(RVA = "0xF64E48", Offset = "0xF64E48", VA = "0xF64E48")]
			public AutoDetectParams(bool legsParentInSpine, bool includeEyes)
			{
			}
		}

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform root;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform pelvis;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform leftThigh;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftCalf;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftFoot;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform rightThigh;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform rightCalf;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform rightFoot;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform leftUpperArm;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform leftForearm;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform leftHand;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform rightUpperArm;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform rightForearm;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform rightHand;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform head;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] spine;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Transform[] eyes;

		[Token(Token = "0x17000020")]
		public virtual bool isFilled
		{
			[Token(Token = "0x6000189")]
			[Address(RVA = "0xF60974", Offset = "0xF60974", VA = "0xF60974", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000021")]
		public bool isEmpty
		{
			[Token(Token = "0x600018A")]
			[Address(RVA = "0xF60CD0", Offset = "0xF60CD0", VA = "0xF60CD0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0xF60CE0", Offset = "0xF60CE0", VA = "0xF60CE0", Slot = "5")]
		public virtual bool IsEmpty(bool includeRoot)
		{
			return default(bool);
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0xF6106C", Offset = "0xF6106C", VA = "0xF6106C", Slot = "6")]
		public virtual bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0xF613FC", Offset = "0xF613FC", VA = "0xF613FC")]
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0xF61B28", Offset = "0xF61B28", VA = "0xF61B28")]
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0xF61698", Offset = "0xF61698", VA = "0xF61698")]
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0xF62308", Offset = "0xF62308", VA = "0xF62308")]
		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0xF623F4", Offset = "0xF623F4", VA = "0xF623F4")]
		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0xF62940", Offset = "0xF62940", VA = "0xF62940")]
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			return default(bool);
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0xF62748", Offset = "0xF62748", VA = "0xF62748")]
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0xF625F4", Offset = "0xF625F4", VA = "0xF625F4")]
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0xF62490", Offset = "0xF62490", VA = "0xF62490")]
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0xF62840", Offset = "0xF62840", VA = "0xF62840")]
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0xF62A24", Offset = "0xF62A24", VA = "0xF62A24")]
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0xF635E0", Offset = "0xF635E0", VA = "0xF635E0")]
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0xF6307C", Offset = "0xF6307C", VA = "0xF6307C")]
		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0xF6392C", Offset = "0xF6392C", VA = "0xF6392C")]
		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0xF633E4", Offset = "0xF633E4", VA = "0xF633E4")]
		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0xF63934", Offset = "0xF63934", VA = "0xF63934")]
		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0xF6393C", Offset = "0xF6393C", VA = "0xF6393C")]
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0xF63AFC", Offset = "0xF63AFC", VA = "0xF63AFC")]
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0xF63DE0", Offset = "0xF63DE0", VA = "0xF63DE0")]
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0xF61618", Offset = "0xF61618", VA = "0xF61618")]
		public BipedReferences()
		{
		}
	}
	[Token(Token = "0x200003D")]
	public class Comments : MonoBehaviour
	{
		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Multiline]
		public string text;

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0xF64E64", Offset = "0xF64E64", VA = "0xF64E64")]
		public Comments()
		{
		}
	}
	[Token(Token = "0x200003E")]
	public class DemoGUIMessage : MonoBehaviour
	{
		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string text;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color color;

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0xF64E6C", Offset = "0xF64E6C", VA = "0xF64E6C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0xF64F64", Offset = "0xF64F64", VA = "0xF64F64")]
		public DemoGUIMessage()
		{
		}
	}
	[Token(Token = "0x200003F")]
	public class Hierarchy
	{
		[Token(Token = "0x60001A6")]
		[Address(RVA = "0xF64F74", Offset = "0xF64F74", VA = "0xF64F74")]
		public static bool HierarchyIsValid(Transform[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0xF65128", Offset = "0xF65128", VA = "0xF65128")]
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects)
		{
			return null;
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0xF64FF8", Offset = "0xF64FF8", VA = "0xF64FF8")]
		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0xF65234", Offset = "0xF65234", VA = "0xF65234")]
		public static bool ContainsChild(Transform transform, Transform child)
		{
			return default(bool);
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0xF65344", Offset = "0xF65344", VA = "0xF65344")]
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0xF6558C", Offset = "0xF6558C", VA = "0xF6558C")]
		public static Transform GetAncestor(Transform transform, int minChildCount)
		{
			return null;
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0xF65680", Offset = "0xF65680", VA = "0xF65680")]
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			return null;
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0xF657D0", Offset = "0xF657D0", VA = "0xF657D0")]
		public static Transform GetFirstCommonAncestor(Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0xF65B3C", Offset = "0xF65B3C", VA = "0xF65B3C")]
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0xF65934", Offset = "0xF65934", VA = "0xF65934")]
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms)
		{
			return default(bool);
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0xF65CC4", Offset = "0xF65CC4", VA = "0xF65CC4")]
		public Hierarchy()
		{
		}
	}
	[Token(Token = "0x2000040")]
	public class InspectorComment : PropertyAttribute
	{
		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string color;

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0xF65CCC", Offset = "0xF65CCC", VA = "0xF65CCC")]
		public InspectorComment(string name)
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0xF65D54", Offset = "0xF65D54", VA = "0xF65D54")]
		public InspectorComment(string name, string color)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000041")]
	public enum InterpolationMode
	{
		[Token(Token = "0x400013E")]
		None,
		[Token(Token = "0x400013F")]
		InOutCubic,
		[Token(Token = "0x4000140")]
		InOutQuintic,
		[Token(Token = "0x4000141")]
		InOutSine,
		[Token(Token = "0x4000142")]
		InQuintic,
		[Token(Token = "0x4000143")]
		InQuartic,
		[Token(Token = "0x4000144")]
		InCubic,
		[Token(Token = "0x4000145")]
		InQuadratic,
		[Token(Token = "0x4000146")]
		InElastic,
		[Token(Token = "0x4000147")]
		InElasticSmall,
		[Token(Token = "0x4000148")]
		InElasticBig,
		[Token(Token = "0x4000149")]
		InSine,
		[Token(Token = "0x400014A")]
		InBack,
		[Token(Token = "0x400014B")]
		OutQuintic,
		[Token(Token = "0x400014C")]
		OutQuartic,
		[Token(Token = "0x400014D")]
		OutCubic,
		[Token(Token = "0x400014E")]
		OutInCubic,
		[Token(Token = "0x400014F")]
		OutInQuartic,
		[Token(Token = "0x4000150")]
		OutElastic,
		[Token(Token = "0x4000151")]
		OutElasticSmall,
		[Token(Token = "0x4000152")]
		OutElasticBig,
		[Token(Token = "0x4000153")]
		OutSine,
		[Token(Token = "0x4000154")]
		OutBack,
		[Token(Token = "0x4000155")]
		OutBackCubic,
		[Token(Token = "0x4000156")]
		OutBackQuartic,
		[Token(Token = "0x4000157")]
		BackInCubic,
		[Token(Token = "0x4000158")]
		BackInQuartic
	}
	[Token(Token = "0x2000042")]
	public class Interp
	{
		[Token(Token = "0x60001B3")]
		[Address(RVA = "0xF65DE0", Offset = "0xF65DE0", VA = "0xF65DE0")]
		public static float Float(float t, InterpolationMode mode)
		{
			return default(float);
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0xF66768", Offset = "0xF66768", VA = "0xF66768")]
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, InterpolationMode mode)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0xF667D8", Offset = "0xF667D8", VA = "0xF667D8")]
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed)
		{
			return default(float);
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0xF661E0", Offset = "0xF661E0", VA = "0xF661E0")]
		private static float None(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0xF661EC", Offset = "0xF661EC", VA = "0xF661EC")]
		private static float InOutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0xF66210", Offset = "0xF66210", VA = "0xF66210")]
		private static float InOutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0xF6624C", Offset = "0xF6624C", VA = "0xF6624C")]
		private static float InQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0xF66264", Offset = "0xF66264", VA = "0xF66264")]
		private static float InQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0xF66278", Offset = "0xF66278", VA = "0xF66278")]
		private static float InCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0xF6628C", Offset = "0xF6628C", VA = "0xF6628C")]
		private static float InQuadratic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0xF6629C", Offset = "0xF6629C", VA = "0xF6629C")]
		private static float OutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0xF662E4", Offset = "0xF662E4", VA = "0xF662E4")]
		private static float OutQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0xF6631C", Offset = "0xF6631C", VA = "0xF6631C")]
		private static float OutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0xF66344", Offset = "0xF66344", VA = "0xF66344")]
		private static float OutInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0xF66848", Offset = "0xF66848", VA = "0xF66848")]
		private static float OutInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0xF66378", Offset = "0xF66378", VA = "0xF66378")]
		private static float BackInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0xF663A0", Offset = "0xF663A0", VA = "0xF663A0")]
		private static float BackInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0xF663D0", Offset = "0xF663D0", VA = "0xF663D0")]
		private static float OutBackCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0xF66404", Offset = "0xF66404", VA = "0xF66404")]
		private static float OutBackQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0xF66448", Offset = "0xF66448", VA = "0xF66448")]
		private static float OutElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0xF664AC", Offset = "0xF664AC", VA = "0xF664AC")]
		private static float OutElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0xF66510", Offset = "0xF66510", VA = "0xF66510")]
		private static float InElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0xF66564", Offset = "0xF66564", VA = "0xF66564")]
		private static float InElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0xF665B8", Offset = "0xF665B8", VA = "0xF665B8")]
		private static float InSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0xF665F0", Offset = "0xF665F0", VA = "0xF665F0")]
		private static float OutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0xF66624", Offset = "0xF66624", VA = "0xF66624")]
		private static float InOutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0xF6687C", Offset = "0xF6687C", VA = "0xF6687C")]
		private static float InElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0xF66668", Offset = "0xF66668", VA = "0xF66668")]
		private static float OutElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0xF666F8", Offset = "0xF666F8", VA = "0xF666F8")]
		private static float InBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0xF66728", Offset = "0xF66728", VA = "0xF66728")]
		private static float OutBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0xF6690C", Offset = "0xF6690C", VA = "0xF6690C")]
		public Interp()
		{
		}
	}
	[Token(Token = "0x2000043")]
	public static class LayerMaskExtensions
	{
		[Token(Token = "0x60001D2")]
		[Address(RVA = "0xF66914", Offset = "0xF66914", VA = "0xF66914")]
		public static bool Contains(LayerMask mask, int layer)
		{
			return default(bool);
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0xF66960", Offset = "0xF66960", VA = "0xF66960")]
		public static LayerMask Create(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0xF66A1C", Offset = "0xF66A1C", VA = "0xF66A1C")]
		public static LayerMask Create(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0xF66974", Offset = "0xF66974", VA = "0xF66974")]
		public static LayerMask NamesToMask(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0xF66A30", Offset = "0xF66A30", VA = "0xF66A30")]
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0xF66AC0", Offset = "0xF66AC0", VA = "0xF66AC0")]
		public static LayerMask Inverse(this LayerMask original)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0xF66AE8", Offset = "0xF66AE8", VA = "0xF66AE8")]
		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0xF66B34", Offset = "0xF66B34", VA = "0xF66B34")]
		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0xF66B9C", Offset = "0xF66B9C", VA = "0xF66B9C")]
		public static string[] MaskToNames(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0xF66CF8", Offset = "0xF66CF8", VA = "0xF66CF8")]
		public static int[] MaskToNumbers(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0xF66E30", Offset = "0xF66E30", VA = "0xF66E30")]
		public static string MaskToString(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0xF66E88", Offset = "0xF66E88", VA = "0xF66E88")]
		public static string MaskToString(this LayerMask original, string delimiter)
		{
			return null;
		}
	}
	[Token(Token = "0x2000044")]
	public abstract class LazySingleton<T> : MonoBehaviour where T : LazySingleton<T>
	{
		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T sInstance;

		[Token(Token = "0x17000023")]
		public static bool hasInstance
		{
			[Token(Token = "0x60001DE")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000024")]
		public static T instance
		{
			[Token(Token = "0x60001DF")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001E0")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60001E1")]
		protected LazySingleton()
		{
		}
	}
	[Token(Token = "0x2000045")]
	public enum ShowIfMode
	{
		[Token(Token = "0x400015B")]
		Disabled,
		[Token(Token = "0x400015C")]
		Hidden
	}
	[Token(Token = "0x2000046")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true)]
	public class ShowIfAttribute : PropertyAttribute
	{
		[Token(Token = "0x17000025")]
		public string propName
		{
			[Token(Token = "0x60001E2")]
			[Address(RVA = "0xF66EAC", Offset = "0xF66EAC", VA = "0xF66EAC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001E3")]
			[Address(RVA = "0xF66EB4", Offset = "0xF66EB4", VA = "0xF66EB4")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x17000026")]
		public object propValue
		{
			[Token(Token = "0x60001E4")]
			[Address(RVA = "0xF66EBC", Offset = "0xF66EBC", VA = "0xF66EBC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001E5")]
			[Address(RVA = "0xF66EC4", Offset = "0xF66EC4", VA = "0xF66EC4")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x17000027")]
		public object otherPropValue
		{
			[Token(Token = "0x60001E6")]
			[Address(RVA = "0xF66ECC", Offset = "0xF66ECC", VA = "0xF66ECC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001E7")]
			[Address(RVA = "0xF66ED4", Offset = "0xF66ED4", VA = "0xF66ED4")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x17000028")]
		public bool indent
		{
			[Token(Token = "0x60001E8")]
			[Address(RVA = "0xF66EDC", Offset = "0xF66EDC", VA = "0xF66EDC")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001E9")]
			[Address(RVA = "0xF66EE4", Offset = "0xF66EE4", VA = "0xF66EE4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000029")]
		public ShowIfMode mode
		{
			[Token(Token = "0x60001EA")]
			[Address(RVA = "0xF66EF0", Offset = "0xF66EF0", VA = "0xF66EF0")]
			[CompilerGenerated]
			get
			{
				return default(ShowIfMode);
			}
			[Token(Token = "0x60001EB")]
			[Address(RVA = "0xF66EF8", Offset = "0xF66EF8", VA = "0xF66EF8")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0xF66F00", Offset = "0xF66F00", VA = "0xF66F00")]
		public ShowIfAttribute(string propertyName, [Optional] object propertyValue, [Optional] object otherPropertyValue, bool indent = false, ShowIfMode mode = ShowIfMode.Hidden)
		{
		}
	}
	[Token(Token = "0x2000047")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true)]
	public class ShowRangeIfAttribute : ShowIfAttribute
	{
		[Token(Token = "0x1700002A")]
		public float min
		{
			[Token(Token = "0x60001ED")]
			[Address(RVA = "0xF66F80", Offset = "0xF66F80", VA = "0xF66F80")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001EE")]
			[Address(RVA = "0xF66F88", Offset = "0xF66F88", VA = "0xF66F88")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700002B")]
		public float max
		{
			[Token(Token = "0x60001EF")]
			[Address(RVA = "0xF66F90", Offset = "0xF66F90", VA = "0xF66F90")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001F0")]
			[Address(RVA = "0xF66F98", Offset = "0xF66F98", VA = "0xF66F98")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0xF66FA0", Offset = "0xF66FA0", VA = "0xF66FA0")]
		public ShowRangeIfAttribute(float min, float max, string propertyName, [Optional] object propertyValue, [Optional] object otherPropertyValue, bool indent = false, ShowIfMode mode = ShowIfMode.Hidden)
		{
		}
	}
	[Token(Token = "0x2000048")]
	public class ShowLargeHeaderIf : ShowIfAttribute
	{
		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string name;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string color;

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0xF66FCC", Offset = "0xF66FCC", VA = "0xF66FCC")]
		public ShowLargeHeaderIf(string name, string propertyName, [Optional] object propertyValue, [Optional] object otherPropertyValue, bool indent = false, ShowIfMode mode = ShowIfMode.Hidden)
		{
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0xF67088", Offset = "0xF67088", VA = "0xF67088")]
		public ShowLargeHeaderIf(string name, string color, string propertyName, [Optional] object propertyValue, [Optional] object otherPropertyValue, bool indent = false, ShowIfMode mode = ShowIfMode.Hidden)
		{
		}
	}
	[Token(Token = "0x2000049")]
	public class LargeHeader : PropertyAttribute
	{
		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string color;

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0xF67150", Offset = "0xF67150", VA = "0xF67150")]
		public LargeHeader(string name)
		{
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0xF671D8", Offset = "0xF671D8", VA = "0xF671D8")]
		public LargeHeader(string name, string color)
		{
		}
	}
	[Token(Token = "0x200004A")]
	public static class QuaTools
	{
		[Token(Token = "0x60001F6")]
		[Address(RVA = "0xF67264", Offset = "0xF67264", VA = "0xF67264")]
		public static float GetYaw(Quaternion space, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0xF672BC", Offset = "0xF672BC", VA = "0xF672BC")]
		public static float GetPitch(Quaternion space, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0xF673EC", Offset = "0xF673EC", VA = "0xF673EC")]
		public static float GetBank(Quaternion space, Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0xF6756C", Offset = "0xF6756C", VA = "0xF6756C")]
		public static float GetYaw(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0xF67648", Offset = "0xF67648", VA = "0xF67648")]
		public static float GetPitch(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0xF67724", Offset = "0xF67724", VA = "0xF67724")]
		public static float GetBank(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0xF6793C", Offset = "0xF6793C", VA = "0xF6793C")]
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0xF67988", Offset = "0xF67988", VA = "0xF67988")]
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0xF679D4", Offset = "0xF679D4", VA = "0xF679D4")]
		public static Quaternion LinearBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0xF67AD8", Offset = "0xF67AD8", VA = "0xF67AD8")]
		public static Quaternion SphericalBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0xF67BDC", Offset = "0xF67BDC", VA = "0xF67BDC")]
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0xF67CF0", Offset = "0xF67CF0", VA = "0xF67CF0")]
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0xF67D98", Offset = "0xF67D98", VA = "0xF67D98")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0xF67EA4", Offset = "0xF67EA4", VA = "0xF67EA4")]
		public static Vector3 GetAxis(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0xF6800C", Offset = "0xF6800C", VA = "0xF6800C")]
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0xF681F0", Offset = "0xF681F0", VA = "0xF681F0")]
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing)
		{
			return default(float);
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0xF682C0", Offset = "0xF682C0", VA = "0xF682C0")]
		public static Quaternion MatchRotation(Quaternion targetRotation, Vector3 targetAxis1, Vector3 targetAxis2, Vector3 axis1, Vector3 axis2)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0xF68444", Offset = "0xF68444", VA = "0xF68444")]
		public static Vector3 ToBiPolar(Vector3 euler)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0xF68550", Offset = "0xF68550", VA = "0xF68550")]
		public static float ToBiPolar(float angle)
		{
			return default(float);
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0xF685A8", Offset = "0xF685A8", VA = "0xF685A8")]
		public static Quaternion MirrorYZ(Quaternion r, Quaternion space)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0xF687CC", Offset = "0xF687CC", VA = "0xF687CC")]
		public static Quaternion MirrorYZ(Quaternion r)
		{
			return default(Quaternion);
		}
	}
	[Token(Token = "0x200004B")]
	public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
	{
		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T sInstance;

		[Token(Token = "0x1700002C")]
		public static T instance
		{
			[Token(Token = "0x600020B")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600020C")]
		public static void Clear()
		{
		}

		[Token(Token = "0x600020D")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x600020E")]
		protected Singleton()
		{
		}
	}
	[Token(Token = "0x200004C")]
	public class SolverManager : MonoBehaviour
	{
		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("If true, will fix all the Transforms used by the solver to their initial state in each Update. This prevents potential problems with unanimated bones and animator culling with a small cost of performance. Not recommended for CCD and FABRIK solvers.")]
		public bool fixTransforms;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Animation legacy;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool updateFrame;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool componentInitiated;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		private bool skipSolverUpdate;

		[Token(Token = "0x1700002D")]
		private bool animatePhysics
		{
			[Token(Token = "0x6000215")]
			[Address(RVA = "0xF689F0", Offset = "0xF689F0", VA = "0xF689F0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700002E")]
		private bool isAnimated
		{
			[Token(Token = "0x6000219")]
			[Address(RVA = "0xF68CEC", Offset = "0xF68CEC", VA = "0xF68CEC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0xF688D4", Offset = "0xF688D4", VA = "0xF688D4")]
		public void Disable()
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0xF68968", Offset = "0xF68968", VA = "0xF68968", Slot = "4")]
		protected virtual void InitiateSolver()
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0xF6896C", Offset = "0xF6896C", VA = "0xF6896C", Slot = "5")]
		protected virtual void UpdateSolver()
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0xF68970", Offset = "0xF68970", VA = "0xF68970", Slot = "6")]
		protected virtual void FixTransforms()
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0xF68974", Offset = "0xF68974", VA = "0xF68974")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0xF689EC", Offset = "0xF689EC", VA = "0xF689EC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0xF6899C", Offset = "0xF6899C", VA = "0xF6899C")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0xF68CB0", Offset = "0xF68CB0", VA = "0xF68CB0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0xF68ABC", Offset = "0xF68ABC", VA = "0xF68ABC")]
		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0xF68D84", Offset = "0xF68D84", VA = "0xF68D84")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0xF68DD0", Offset = "0xF68DD0", VA = "0xF68DD0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0xF68E1C", Offset = "0xF68E1C", VA = "0xF68E1C")]
		public void UpdateSolverExternal()
		{
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0xF68E54", Offset = "0xF68E54", VA = "0xF68E54")]
		public SolverManager()
		{
		}
	}
	[Token(Token = "0x200004D")]
	public class TriggerEventBroadcaster : MonoBehaviour
	{
		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject target;

		[Token(Token = "0x600021E")]
		[Address(RVA = "0xF68E64", Offset = "0xF68E64", VA = "0xF68E64")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0xF68F18", Offset = "0xF68F18", VA = "0xF68F18")]
		private void OnTriggerStay(Collider collider)
		{
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0xF68FCC", Offset = "0xF68FCC", VA = "0xF68FCC")]
		private void OnTriggerExit(Collider collider)
		{
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0xF69080", Offset = "0xF69080", VA = "0xF69080")]
		public TriggerEventBroadcaster()
		{
		}
	}
	[Token(Token = "0x200004E")]
	public static class V2Tools
	{
		[Token(Token = "0x6000222")]
		[Address(RVA = "0xF69088", Offset = "0xF69088", VA = "0xF69088")]
		public static Vector2 XZ(Vector3 v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0xF69090", Offset = "0xF69090", VA = "0xF69090")]
		public static float DeltaAngle(Vector2 dir1, Vector2 dir2)
		{
			return default(float);
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0xF69120", Offset = "0xF69120", VA = "0xF69120")]
		public static float DeltaAngleXZ(Vector3 dir1, Vector3 dir2)
		{
			return default(float);
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0xF691B4", Offset = "0xF691B4", VA = "0xF691B4")]
		public static bool LineCircleIntersect(Vector2 p1, Vector2 p2, Vector2 c, float r)
		{
			return default(bool);
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0xF69264", Offset = "0xF69264", VA = "0xF69264")]
		public static bool RayCircleIntersect(Vector2 p1, Vector2 dir, Vector2 c, float r)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200004F")]
	public static class V3Tools
	{
		[Token(Token = "0x6000227")]
		[Address(RVA = "0xF692C0", Offset = "0xF692C0", VA = "0xF692C0")]
		public static float GetYaw(Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0xF692E0", Offset = "0xF692E0", VA = "0xF692E0")]
		public static float GetPitch(Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0xF693B4", Offset = "0xF693B4", VA = "0xF693B4")]
		public static float GetBank(Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0xF6946C", Offset = "0xF6946C", VA = "0xF6946C")]
		public static float GetYaw(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0xF694C8", Offset = "0xF694C8", VA = "0xF694C8")]
		public static float GetPitch(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0xF69524", Offset = "0xF69524", VA = "0xF69524")]
		public static float GetBank(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0xF6963C", Offset = "0xF6963C", VA = "0xF6963C")]
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0xF69698", Offset = "0xF69698", VA = "0xF69698")]
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0xF696D0", Offset = "0xF696D0", VA = "0xF696D0")]
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0xF698A0", Offset = "0xF698A0", VA = "0xF698A0")]
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0xF69AA4", Offset = "0xF69AA4", VA = "0xF69AA4")]
		public static Vector3 Flatten(Vector3 v, Vector3 normal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0xF69C1C", Offset = "0xF69C1C", VA = "0xF69C1C")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0xF69E4C", Offset = "0xF69E4C", VA = "0xF69E4C")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0xF6A09C", Offset = "0xF6A09C", VA = "0xF6A09C")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0xF6A2F4", Offset = "0xF6A2F4", VA = "0xF6A2F4")]
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0xF6A4A0", Offset = "0xF6A4A0", VA = "0xF6A4A0")]
		public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0xF6A698", Offset = "0xF6A698", VA = "0xF6A698")]
		public static Vector3 TransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0xF6A714", Offset = "0xF6A714", VA = "0xF6A714")]
		public static Vector3 InverseTransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0xF6A7A4", Offset = "0xF6A7A4", VA = "0xF6A7A4")]
		public static Vector3 InverseTransformPoint(Vector3 tPos, Quaternion tRot, Vector3 tScale, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0xF6A83C", Offset = "0xF6A83C", VA = "0xF6A83C")]
		public static Vector3 TransformPoint(Vector3 tPos, Quaternion tRot, Vector3 tScale, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0xF6A82C", Offset = "0xF6A82C", VA = "0xF6A82C")]
		public static Vector3 Div(Vector3 v1, Vector3 v2)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x2000050")]
	public static class Warning
	{
		[Token(Token = "0x2000051")]
		public delegate void Logger(string message);

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool logged;

		[Token(Token = "0x600023C")]
		[Address(RVA = "0xF6A8B8", Offset = "0xF6A8B8", VA = "0xF6A8B8")]
		public static void Log(string message, Logger logger, bool logInEditMode = false)
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0xF6A950", Offset = "0xF6A950", VA = "0xF6A950")]
		public static void Log(string message, Transform context, bool logInEditMode = false)
		{
		}
	}
}
namespace RootMotion.FinalIK
{
	[Token(Token = "0x2000052")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page4.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Biped IK")]
	public class BipedIK : SolverManager
	{
		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public BipedIKSolvers solvers;

		[Token(Token = "0x6000242")]
		[Address(RVA = "0xF6AB28", Offset = "0xF6AB28", VA = "0xF6AB28")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0xF6AB6C", Offset = "0xF6AB6C", VA = "0xF6AB6C")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0xF6ABB0", Offset = "0xF6ABB0", VA = "0xF6ABB0")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0xF6ABF4", Offset = "0xF6ABF4", VA = "0xF6ABF4")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0xF6AC38", Offset = "0xF6AC38", VA = "0xF6AC38")]
		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0xF6ACD0", Offset = "0xF6ACD0", VA = "0xF6ACD0")]
		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0xF6ACEC", Offset = "0xF6ACEC", VA = "0xF6ACEC")]
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0xF6AD18", Offset = "0xF6AD18", VA = "0xF6AD18")]
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0xF6AD44", Offset = "0xF6AD44", VA = "0xF6AD44")]
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition)
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0xF6AD80", Offset = "0xF6AD80", VA = "0xF6AD80")]
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation)
		{
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0xF6ADC0", Offset = "0xF6ADC0", VA = "0xF6ADC0")]
		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0xF6ADE0", Offset = "0xF6ADE0", VA = "0xF6ADE0")]
		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0xF6AE00", Offset = "0xF6AE00", VA = "0xF6AE00")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes)
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0xF6AE24", Offset = "0xF6AE24", VA = "0xF6AE24")]
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0xF6AE4C", Offset = "0xF6AE4C", VA = "0xF6AE4C")]
		public void SetSpinePosition(Vector3 spinePosition)
		{
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0xF6AE74", Offset = "0xF6AE74", VA = "0xF6AE74")]
		public void SetSpineWeight(float weight)
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0xF6AC54", Offset = "0xF6AC54", VA = "0xF6AC54")]
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal)
		{
			return null;
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0xF6AE98", Offset = "0xF6AE98", VA = "0xF6AE98")]
		public void InitiateBipedIK()
		{
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0xF6AEA4", Offset = "0xF6AEA4", VA = "0xF6AEA4")]
		public void UpdateBipedIK()
		{
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0xF6AEB0", Offset = "0xF6AEB0", VA = "0xF6AEB0")]
		public void SetToDefaults()
		{
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0xF6B164", Offset = "0xF6B164", VA = "0xF6B164", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0xF6B200", Offset = "0xF6B200", VA = "0xF6B200", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0xF6B528", Offset = "0xF6B528", VA = "0xF6B528", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0xF6B994", Offset = "0xF6B994", VA = "0xF6B994")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0xF6B9B8", Offset = "0xF6B9B8", VA = "0xF6B9B8")]
		public BipedIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000053")]
	public class BipedIKSolvers
	{
		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IKSolverLimb leftFoot;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IKSolverLimb rightFoot;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IKSolverLimb leftHand;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IKSolverLimb rightHand;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolverFABRIK spine;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt lookAt;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverAim aim;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Constraints pelvis;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IKSolverLimb[] _limbs;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private IKSolver[] _ikSolvers;

		[Token(Token = "0x1700002F")]
		public IKSolverLimb[] limbs
		{
			[Token(Token = "0x600025B")]
			[Address(RVA = "0xF6AFEC", Offset = "0xF6AFEC", VA = "0xF6AFEC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000030")]
		public IKSolver[] ikSolvers
		{
			[Token(Token = "0x600025C")]
			[Address(RVA = "0xF6BC58", Offset = "0xF6BC58", VA = "0xF6BC58")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0xF6B3B4", Offset = "0xF6B3B4", VA = "0xF6B3B4")]
		public void AssignReferences(BipedReferences references)
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0xF6BA6C", Offset = "0xF6BA6C", VA = "0xF6BA6C")]
		public BipedIKSolvers()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000054")]
	public abstract class Constraint
	{
		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float weight;

		[Token(Token = "0x17000031")]
		public bool isValid
		{
			[Token(Token = "0x600025F")]
			[Address(RVA = "0xF6BE80", Offset = "0xF6BE80", VA = "0xF6BE80")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000260")]
		public abstract void UpdateConstraint();

		[Token(Token = "0x6000261")]
		[Address(RVA = "0xF6BEE0", Offset = "0xF6BEE0", VA = "0xF6BEE0")]
		protected Constraint()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000055")]
	public class ConstraintPosition : Constraint
	{
		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 position;

		[Token(Token = "0x6000262")]
		[Address(RVA = "0xF6BEE8", Offset = "0xF6BEE8", VA = "0xF6BEE8", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0xF6BF80", Offset = "0xF6BF80", VA = "0xF6BF80")]
		public ConstraintPosition()
		{
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0xF6BF88", Offset = "0xF6BF88", VA = "0xF6BF88")]
		public ConstraintPosition(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000056")]
	public class ConstraintPositionOffset : Constraint
	{
		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 offset;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 defaultLocalPosition;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 lastLocalPosition;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool initiated;

		[Token(Token = "0x17000032")]
		private bool positionChanged
		{
			[Token(Token = "0x6000268")]
			[Address(RVA = "0xF6C0BC", Offset = "0xF6C0BC", VA = "0xF6C0BC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0xF6BFB8", Offset = "0xF6BFB8", VA = "0xF6BFB8", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0xF6C118", Offset = "0xF6C118", VA = "0xF6C118")]
		public ConstraintPositionOffset()
		{
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0xF6C120", Offset = "0xF6C120", VA = "0xF6C120")]
		public ConstraintPositionOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000057")]
	public class ConstraintRotation : Constraint
	{
		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion rotation;

		[Token(Token = "0x6000269")]
		[Address(RVA = "0xF6C150", Offset = "0xF6C150", VA = "0xF6C150", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0xF6C1CC", Offset = "0xF6C1CC", VA = "0xF6C1CC")]
		public ConstraintRotation()
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0xF6C1D4", Offset = "0xF6C1D4", VA = "0xF6C1D4")]
		public ConstraintRotation(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000058")]
	public class ConstraintRotationOffset : Constraint
	{
		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion offset;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastLocalRotation;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Quaternion defaultTargetLocalRotation;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool initiated;

		[Token(Token = "0x17000033")]
		private bool rotationChanged
		{
			[Token(Token = "0x600026F")]
			[Address(RVA = "0xF6C308", Offset = "0xF6C308", VA = "0xF6C308")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0xF6C204", Offset = "0xF6C204", VA = "0xF6C204", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0xF6C360", Offset = "0xF6C360", VA = "0xF6C360")]
		public ConstraintRotationOffset()
		{
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0xF6C368", Offset = "0xF6C368", VA = "0xF6C368")]
		public ConstraintRotationOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000059")]
	public class Constraints
	{
		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 positionOffset;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 position;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 1f)]
		public float positionWeight;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 rotationOffset;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rotation;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Range(0f, 1f)]
		public float rotationWeight;

		[Token(Token = "0x6000270")]
		[Address(RVA = "0xF6C398", Offset = "0xF6C398", VA = "0xF6C398")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0xF6B4D4", Offset = "0xF6B4D4", VA = "0xF6B4D4")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0xF6B69C", Offset = "0xF6B69C", VA = "0xF6B69C")]
		public void Update()
		{
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0xF6BE78", Offset = "0xF6BE78", VA = "0xF6BE78")]
		public Constraints()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005A")]
	public class Finger
	{
		[Serializable]
		[Token(Token = "0x200005B")]
		public enum DOF
		{
			[Token(Token = "0x40001A6")]
			One,
			[Token(Token = "0x40001A7")]
			Three
		}

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Tooltip("Master Weight for the finger.")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[Range(0f, 1f)]
		[Tooltip("The weight of rotating the finger tip and bending the finger to the target.")]
		public float rotationWeight;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Rotational degrees of freedom. When set to 'One' the fingers will be able to be rotated only around a single axis. When 3, all 3 axes are free to rotate around.")]
		public DOF rotationDOF;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("If enabled, keeps bone1 twist angle fixed relative to bone2.")]
		public bool fixBone1Twist;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The first bone of the finger.")]
		public Transform bone1;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The second bone of the finger.")]
		public Transform bone2;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The (optional) third bone of the finger. This can be ignored for thumbs.")]
		public Transform bone3;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The fingertip object. If your character doesn't have tip bones, you can create an empty GameObject and parent it to the last bone in the finger. Place it to the tip of the finger.")]
		public Transform tip;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The IK target (optional, can use IKPosition and IKRotation directly).")]
		public Transform target;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IKSolverLimb solver;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion bone3RelativeToTarget;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 bone3DefaultLocalPosition;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Quaternion bone3DefaultLocalRotation;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 bone1Axis;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 tipAxis;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Vector3 bone1TwistAxis;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 defaultBendNormal;

		[Token(Token = "0x17000034")]
		public bool initiated
		{
			[Token(Token = "0x6000274")]
			[Address(RVA = "0xF6C3F8", Offset = "0xF6C3F8", VA = "0xF6C3F8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000275")]
			[Address(RVA = "0xF6C400", Offset = "0xF6C400", VA = "0xF6C400")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000035")]
		public Vector3 IKPosition
		{
			[Token(Token = "0x6000276")]
			[Address(RVA = "0xF6C40C", Offset = "0xF6C40C", VA = "0xF6C40C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000277")]
			[Address(RVA = "0xF6C42C", Offset = "0xF6C42C", VA = "0xF6C42C")]
			set
			{
			}
		}

		[Token(Token = "0x17000036")]
		public Quaternion IKRotation
		{
			[Token(Token = "0x6000278")]
			[Address(RVA = "0xF6C44C", Offset = "0xF6C44C", VA = "0xF6C44C")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x6000279")]
			[Address(RVA = "0xF6C46C", Offset = "0xF6C46C", VA = "0xF6C46C")]
			set
			{
			}
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0xF6C48C", Offset = "0xF6C48C", VA = "0xF6C48C")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0xF6C584", Offset = "0xF6C584", VA = "0xF6C584")]
		public void Initiate(Transform hand, int index)
		{
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0xF6CC08", Offset = "0xF6CC08", VA = "0xF6CC08")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0xF6CCD4", Offset = "0xF6CCD4", VA = "0xF6CCD4")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0xF6CD8C", Offset = "0xF6CD8C", VA = "0xF6CD8C")]
		public void Update(float masterWeight)
		{
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0xF6D32C", Offset = "0xF6D32C", VA = "0xF6D32C")]
		public Finger()
		{
		}
	}
	[Token(Token = "0x200005C")]
	public class FingerRig : SolverManager
	{
		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Tooltip("The master weight for all fingers.")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Finger[] fingers;

		[Token(Token = "0x17000037")]
		public bool initiated
		{
			[Token(Token = "0x6000280")]
			[Address(RVA = "0xF6D33C", Offset = "0xF6D33C", VA = "0xF6D33C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000281")]
			[Address(RVA = "0xF6D344", Offset = "0xF6D344", VA = "0xF6D344")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0xF6D350", Offset = "0xF6D350", VA = "0xF6D350")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0xF6D3C4", Offset = "0xF6D3C4", VA = "0xF6D3C4")]
		[ContextMenu("Auto-detect")]
		public void AutoDetect()
		{
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0xF6D73C", Offset = "0xF6D73C", VA = "0xF6D73C")]
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, [Optional] Transform target)
		{
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0xF6D8F4", Offset = "0xF6D8F4", VA = "0xF6D8F4")]
		public void RemoveFinger(int index)
		{
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0xF6D64C", Offset = "0xF6D64C", VA = "0xF6D64C")]
		private void AddChildrenRecursive(Transform parent, ref Transform[] array)
		{
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0xF6DA70", Offset = "0xF6DA70", VA = "0xF6DA70", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0xF6DB18", Offset = "0xF6DB18", VA = "0xF6DB18")]
		public void UpdateFingerSolvers()
		{
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0xF6DB7C", Offset = "0xF6DB7C", VA = "0xF6DB7C")]
		public void FixFingerTransforms()
		{
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0xF6DBE4", Offset = "0xF6DBE4", VA = "0xF6DBE4")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0xF6DC40", Offset = "0xF6DC40", VA = "0xF6DC40", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0xF6DC44", Offset = "0xF6DC44", VA = "0xF6DC44", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0xF6DC58", Offset = "0xF6DC58", VA = "0xF6DC58")]
		public FingerRig()
		{
		}
	}
	[Token(Token = "0x200005D")]
	public abstract class Grounder : MonoBehaviour
	{
		[Token(Token = "0x200005E")]
		public delegate void GrounderDelegate();

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The master weight. Use this to fade in/out the grounding effect.")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The Grounding solver. Not to confuse with IK solvers.")]
		public Grounding solver;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GrounderDelegate OnPreGrounder;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GrounderDelegate OnPostGrounder;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GrounderDelegate OnPostIK;

		[Token(Token = "0x17000038")]
		public bool initiated
		{
			[Token(Token = "0x600028F")]
			[Address(RVA = "0xF6DCCC", Offset = "0xF6DCCC", VA = "0xF6DCCC")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000290")]
			[Address(RVA = "0xF6DCD4", Offset = "0xF6DCD4", VA = "0xF6DCD4")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x600028E")]
		public abstract void ResetPosition();

		[Token(Token = "0x6000291")]
		[Address(RVA = "0xF6DCE0", Offset = "0xF6DCE0", VA = "0xF6DCE0")]
		protected Vector3 GetSpineOffsetTarget()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0xF6DF90", Offset = "0xF6DF90", VA = "0xF6DF90")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0xF6DDA4", Offset = "0xF6DDA4", VA = "0xF6DDA4")]
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0xF6DFB4", Offset = "0xF6DFB4", VA = "0xF6DFB4")]
		private Vector3 GetLegSpineTangent(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000295")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x6000296")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x6000297")]
		[Address(RVA = "0xF6E128", Offset = "0xF6E128", VA = "0xF6E128")]
		protected Grounder()
		{
		}
	}
	[Token(Token = "0x200005F")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder Biped")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page9.html")]
	public class GrounderBipedIK : Grounder
	{
		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("The BipedIK componet.")]
		public BipedIK ik;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("The amount of spine bending towards upward slopes.")]
		public float spineBend;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Tooltip("The interpolation speed of spine bending.")]
		public float spineSpeed;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] feet;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Quaternion[] footRotations;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 spineOffset;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float lastWeight;

		[Token(Token = "0x600029C")]
		[Address(RVA = "0xF6E42C", Offset = "0xF6E42C", VA = "0xF6E42C", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0xF6E470", Offset = "0xF6E470", VA = "0xF6E470", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0xF6E4B4", Offset = "0xF6E4B4", VA = "0xF6E4B4", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0xF6E594", Offset = "0xF6E594", VA = "0xF6E594")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0xF6E634", Offset = "0xF6E634", VA = "0xF6E634")]
		private void Update()
		{
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0xF6E688", Offset = "0xF6E688", VA = "0xF6E688")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0xF6ECA4", Offset = "0xF6ECA4", VA = "0xF6ECA4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0xF6ECE4", Offset = "0xF6ECE4", VA = "0xF6ECE4")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0xF6F358", Offset = "0xF6F358", VA = "0xF6F358")]
		private void SetLegIK(IKSolverLimb limb, int index)
		{
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0xF6F480", Offset = "0xF6F480", VA = "0xF6F480")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0xF6F67C", Offset = "0xF6F67C", VA = "0xF6F67C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0xF6F854", Offset = "0xF6F854", VA = "0xF6F854")]
		public GrounderBipedIK()
		{
		}
	}
	[Token(Token = "0x2000060")]
	[HelpURL("https://www.youtube.com/watch?v=9MiZiaJorws&index=6&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder Full Body Biped")]
	public class GrounderFBBIK : Grounder
	{
		[Serializable]
		[Token(Token = "0x2000061")]
		public class SpineEffector
		{
			[Token(Token = "0x40001C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The type of the effector.")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x40001C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("The weight of horizontal bend offset towards the slope.")]
			public float horizontalWeight;

			[Token(Token = "0x40001C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The vertical bend offset weight.")]
			public float verticalWeight;

			[Token(Token = "0x60002B7")]
			[Address(RVA = "0xF706E8", Offset = "0xF706E8", VA = "0xF706E8")]
			public SpineEffector()
			{
			}

			[Token(Token = "0x60002B8")]
			[Address(RVA = "0xF706F8", Offset = "0xF706F8", VA = "0xF706F8")]
			public SpineEffector(FullBodyBipedEffector effectorType, float horizontalWeight, float verticalWeight)
			{
			}
		}

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Reference to the FBBIK componet.")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("The amount of spine bending towards upward slopes.")]
		public float spineBend;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Tooltip("The interpolation speed of spine bending.")]
		public float spineSpeed;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public SpineEffector[] spine;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform[] feet;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 spineOffset;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private bool firstSolve;

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0xF6F8F8", Offset = "0xF6F8F8", VA = "0xF6F8F8")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0xF6F93C", Offset = "0xF6F93C", VA = "0xF6F93C", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0xF6F980", Offset = "0xF6F980", VA = "0xF6F980", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0xF6F9C4", Offset = "0xF6F9C4", VA = "0xF6F9C4", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0xF6FA2C", Offset = "0xF6FA2C", VA = "0xF6FA2C")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0xF6FAB4", Offset = "0xF6FAB4", VA = "0xF6FAB4")]
		private void Update()
		{
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0xF6FDF4", Offset = "0xF6FDF4", VA = "0xF6FDF4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0xF6FE00", Offset = "0xF6FE00", VA = "0xF6FE00")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0xF6FB10", Offset = "0xF6FB10", VA = "0xF6FB10")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0xF6FE0C", Offset = "0xF6FE0C", VA = "0xF6FE0C")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0xF7017C", Offset = "0xF7017C", VA = "0xF7017C")]
		private void SetLegIK(IKEffector effector, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0xF70300", Offset = "0xF70300", VA = "0xF70300")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0xF70460", Offset = "0xF70460", VA = "0xF70460")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0xF7047C", Offset = "0xF7047C", VA = "0xF7047C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0xF70644", Offset = "0xF70644", VA = "0xF70644")]
		public GrounderFBBIK()
		{
		}
	}
	[Token(Token = "0x2000062")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder IK")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page9.html")]
	public class GrounderIK : Grounder
	{
		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public IK[] legs;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("The pelvis transform. Common ancestor of all the legs.")]
		public Transform pelvis;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("The root Transform of the character, with the rigidbody and the collider.")]
		public Transform characterRoot;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Tooltip("The weight of rotating the character root to the ground normal (range: 0 - 1).")]
		[Range(0f, 1f)]
		public float rootRotationWeight;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[Tooltip("The speed of rotating the character root to the ground normal (range: 0 - inf).")]
		public float rootRotationSpeed;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Tooltip("The maximum angle of root rotation (range: 0 - 90).")]
		public float maxRootRotationAngle;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Transform[] feet;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Quaternion[] footRotations;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private int solvedFeet;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private bool solved;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private float lastWeight;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Rigidbody characterRootRigidbody;

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0xF7073C", Offset = "0xF7073C", VA = "0xF7073C", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0xF70780", Offset = "0xF70780", VA = "0xF70780", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0xF707C4", Offset = "0xF707C4", VA = "0xF707C4", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0xF709B4", Offset = "0xF709B4", VA = "0xF709B4")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0xF70BD0", Offset = "0xF70BD0", VA = "0xF70BD0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0xF70CB0", Offset = "0xF70CB0", VA = "0xF70CB0")]
		private void Update()
		{
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0xF7139C", Offset = "0xF7139C", VA = "0xF7139C")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0xF71854", Offset = "0xF71854", VA = "0xF71854")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0xF71A00", Offset = "0xF71A00", VA = "0xF71A00")]
		private void SetLegIK(int index)
		{
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0xF71D88", Offset = "0xF71D88", VA = "0xF71D88")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0xF71F8C", Offset = "0xF71F8C", VA = "0xF71F8C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0xF721B4", Offset = "0xF721B4", VA = "0xF721B4")]
		public GrounderIK()
		{
		}
	}
	[Token(Token = "0x2000063")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder Quadruped")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page9.html")]
	public class GrounderQuadruped : Grounder
	{
		[Token(Token = "0x2000064")]
		public struct Foot
		{
			[Token(Token = "0x40001EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IKSolver solver;

			[Token(Token = "0x40001F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Transform transform;

			[Token(Token = "0x40001F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Quaternion rotation;

			[Token(Token = "0x40001F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Grounding.Leg leg;

			[Token(Token = "0x60002D7")]
			[Address(RVA = "0xF72EF8", Offset = "0xF72EF8", VA = "0xF72EF8")]
			public Foot(IKSolver solver, Transform transform)
			{
			}
		}

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("The Grounding solver for the forelegs.")]
		public Grounding forelegSolver;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("The weight of rotating the character root to the ground angle (range: 0 - 1).")]
		[Range(0f, 1f)]
		public float rootRotationWeight;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Range(-90f, 0f)]
		[Tooltip("The maximum angle of rotating the quadruped downwards (going downhill, range: -90 - 0).")]
		public float minRootRotation;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("The maximum angle of rotating the quadruped upwards (going uphill, range: 0 - 90).")]
		[Range(0f, 90f)]
		public float maxRootRotation;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Tooltip("The speed of interpolating the character root rotation (range: 0 - inf).")]
		public float rootRotationSpeed;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Tooltip("The maximum IK offset for the legs (range: 0 - inf).")]
		public float maxLegOffset;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[Tooltip("The maximum IK offset for the forelegs (range: 0 - inf).")]
		public float maxForeLegOffset;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Tooltip("The weight of maintaining the head's rotation as it was before solving the Grounding (range: 0 - 1).")]
		[Range(0f, 1f)]
		public float maintainHeadRotationWeight;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Tooltip("The root Transform of the character, with the rigidbody and the collider.")]
		public Transform characterRoot;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[Tooltip("The pelvis transform. Common ancestor of both legs and the spine.")]
		public Transform pelvis;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Tooltip("The last bone in the spine that is the common parent for both forelegs.")]
		public Transform lastSpineBone;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[Tooltip("The head (optional, if you intend to maintain its rotation).")]
		public Transform head;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IK[] legs;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public IK[] forelegs;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[HideInInspector]
		public Vector3 gravity;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Foot[] feet;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion animatedPelvisLocalRotation;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Quaternion animatedHeadLocalRotation;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Quaternion solvedPelvisLocalRotation;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private Quaternion solvedHeadLocalRotation;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private int solvedFeet;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private bool solved;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private float angle;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Transform forefeetRoot;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private Quaternion headRotation;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private float lastWeight;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Rigidbody characterRootRigidbody;

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0xF72258", Offset = "0xF72258", VA = "0xF72258", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0xF7229C", Offset = "0xF7229C", VA = "0xF7229C", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0xF722E0", Offset = "0xF722E0", VA = "0xF722E0", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0xF7245C", Offset = "0xF7245C", VA = "0xF7245C")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0xF72560", Offset = "0xF72560", VA = "0xF72560")]
		private bool IsReadyToInitiateLegs(IK[] ikComponents)
		{
			return default(bool);
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0xF72754", Offset = "0xF72754", VA = "0xF72754")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0xF727B8", Offset = "0xF727B8", VA = "0xF727B8")]
		private void Update()
		{
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0xF72810", Offset = "0xF72810", VA = "0xF72810")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0xF72B5C", Offset = "0xF72B5C", VA = "0xF72B5C")]
		private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset)
		{
			return null;
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0xF72F58", Offset = "0xF72F58", VA = "0xF72F58")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0xF72FE8", Offset = "0xF72FE8", VA = "0xF72FE8")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0xF73438", Offset = "0xF73438", VA = "0xF73438")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0xF73AFC", Offset = "0xF73AFC", VA = "0xF73AFC")]
		private void UpdateForefeetRoot()
		{
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0xF73DB4", Offset = "0xF73DB4", VA = "0xF73DB4")]
		private void SetFootIK(Foot foot, float maxOffset)
		{
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0xF73EE8", Offset = "0xF73EE8", VA = "0xF73EE8")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0xF741E0", Offset = "0xF741E0", VA = "0xF741E0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0xF74210", Offset = "0xF74210", VA = "0xF74210")]
		private void DestroyLegs(IK[] ikComponents)
		{
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0xF74430", Offset = "0xF74430", VA = "0xF74430")]
		public GrounderQuadruped()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000065")]
	public class Grounding
	{
		[Serializable]
		[Token(Token = "0x2000066")]
		public enum Quality
		{
			[Token(Token = "0x400020F")]
			Fastest,
			[Token(Token = "0x4000210")]
			Simple,
			[Token(Token = "0x4000211")]
			Best
		}

		[Token(Token = "0x2000067")]
		public delegate bool OnRaycastDelegate(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction);

		[Token(Token = "0x2000068")]
		public delegate bool OnCapsuleCastDelegate(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction);

		[Token(Token = "0x2000069")]
		public delegate bool OnSphereCastDelegate(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction);

		[Token(Token = "0x200006A")]
		public class Leg
		{
			[Token(Token = "0x4000214")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Quaternion rotationOffset;

			[Token(Token = "0x400021A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public bool invertFootCenter;

			[Token(Token = "0x400021D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private Grounding grounding;

			[Token(Token = "0x400021E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private float lastTime;

			[Token(Token = "0x400021F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private float deltaTime;

			[Token(Token = "0x4000220")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private Vector3 lastPosition;

			[Token(Token = "0x4000221")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			private Quaternion toHitNormal;

			[Token(Token = "0x4000222")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
			private Quaternion r;

			[Token(Token = "0x4000223")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			private Vector3 up;

			[Token(Token = "0x4000224")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private bool doOverrideFootPosition;

			[Token(Token = "0x4000225")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
			private Vector3 overrideFootPosition;

			[Token(Token = "0x4000226")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			private Vector3 transformPosition;

			[Token(Token = "0x17000041")]
			public bool isGrounded
			{
				[Token(Token = "0x60002FC")]
				[Address(RVA = "0xF76314", Offset = "0xF76314", VA = "0xF76314")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60002FD")]
				[Address(RVA = "0xF7631C", Offset = "0xF7631C", VA = "0xF7631C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000042")]
			public Vector3 IKPosition
			{
				[Token(Token = "0x60002FE")]
				[Address(RVA = "0xF76328", Offset = "0xF76328", VA = "0xF76328")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60002FF")]
				[Address(RVA = "0xF76334", Offset = "0xF76334", VA = "0xF76334")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000043")]
			public bool initiated
			{
				[Token(Token = "0x6000300")]
				[Address(RVA = "0xF76340", Offset = "0xF76340", VA = "0xF76340")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000301")]
				[Address(RVA = "0xF76348", Offset = "0xF76348", VA = "0xF76348")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000044")]
			public float heightFromGround
			{
				[Token(Token = "0x6000302")]
				[Address(RVA = "0xF76354", Offset = "0xF76354", VA = "0xF76354")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000303")]
				[Address(RVA = "0xF7635C", Offset = "0xF7635C", VA = "0xF7635C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000045")]
			public Vector3 velocity
			{
				[Token(Token = "0x6000304")]
				[Address(RVA = "0xF76364", Offset = "0xF76364", VA = "0xF76364")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000305")]
				[Address(RVA = "0xF76370", Offset = "0xF76370", VA = "0xF76370")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000046")]
			public Transform transform
			{
				[Token(Token = "0x6000306")]
				[Address(RVA = "0xF7637C", Offset = "0xF7637C", VA = "0xF7637C")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000307")]
				[Address(RVA = "0xF76384", Offset = "0xF76384", VA = "0xF76384")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000047")]
			public float IKOffset
			{
				[Token(Token = "0x6000308")]
				[Address(RVA = "0xF7638C", Offset = "0xF7638C", VA = "0xF7638C")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000309")]
				[Address(RVA = "0xF76394", Offset = "0xF76394", VA = "0xF76394")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000048")]
			public RaycastHit heelHit
			{
				[Token(Token = "0x600030A")]
				[Address(RVA = "0xF7639C", Offset = "0xF7639C", VA = "0xF7639C")]
				[CompilerGenerated]
				get
				{
					return default(RaycastHit);
				}
				[Token(Token = "0x600030B")]
				[Address(RVA = "0xF763B4", Offset = "0xF763B4", VA = "0xF763B4")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000049")]
			public RaycastHit capsuleHit
			{
				[Token(Token = "0x600030C")]
				[Address(RVA = "0xF763D4", Offset = "0xF763D4", VA = "0xF763D4")]
				[CompilerGenerated]
				get
				{
					return default(RaycastHit);
				}
				[Token(Token = "0x600030D")]
				[Address(RVA = "0xF763EC", Offset = "0xF763EC", VA = "0xF763EC")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700004A")]
			public RaycastHit GetHitPoint
			{
				[Token(Token = "0x600030E")]
				[Address(RVA = "0xF7640C", Offset = "0xF7640C", VA = "0xF7640C")]
				get
				{
					return default(RaycastHit);
				}
			}

			[Token(Token = "0x1700004B")]
			public float stepHeightFromGround
			{
				[Token(Token = "0x6000314")]
				[Address(RVA = "0xF76CC4", Offset = "0xF76CC4", VA = "0xF76CC4")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x1700004C")]
			private float rootYOffset
			{
				[Token(Token = "0x600031D")]
				[Address(RVA = "0xF76E14", Offset = "0xF76E14", VA = "0xF76E14")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x600030F")]
			[Address(RVA = "0xF76454", Offset = "0xF76454", VA = "0xF76454")]
			public void SetFootPosition(Vector3 position)
			{
			}

			[Token(Token = "0x6000310")]
			[Address(RVA = "0xF74A28", Offset = "0xF74A28", VA = "0xF74A28")]
			public void Initiate(Grounding grounding, Transform transform)
			{
			}

			[Token(Token = "0x6000311")]
			[Address(RVA = "0xF76468", Offset = "0xF76468", VA = "0xF76468")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x6000312")]
			[Address(RVA = "0xF757A4", Offset = "0xF757A4", VA = "0xF757A4")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000313")]
			[Address(RVA = "0xF74B38", Offset = "0xF74B38", VA = "0xF74B38")]
			public void Process()
			{
			}

			[Token(Token = "0x6000315")]
			[Address(RVA = "0xF768F0", Offset = "0xF768F0", VA = "0xF768F0")]
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x6000316")]
			[Address(RVA = "0xF764A8", Offset = "0xF764A8", VA = "0xF764A8")]
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x6000317")]
			[Address(RVA = "0xF76D58", Offset = "0xF76D58", VA = "0xF76D58")]
			private Vector3 RotateNormal(Vector3 normal)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000318")]
			[Address(RVA = "0xF7675C", Offset = "0xF7675C", VA = "0xF7675C")]
			private void SetFootToPoint(Vector3 normal, Vector3 point)
			{
			}

			[Token(Token = "0x6000319")]
			[Address(RVA = "0xF767DC", Offset = "0xF767DC", VA = "0xF767DC")]
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint)
			{
			}

			[Token(Token = "0x600031A")]
			[Address(RVA = "0xF76DC4", Offset = "0xF76DC4", VA = "0xF76DC4")]
			private float GetHeightFromGround(Vector3 hitPoint)
			{
				return default(float);
			}

			[Token(Token = "0x600031B")]
			[Address(RVA = "0xF76CF8", Offset = "0xF76CF8", VA = "0xF76CF8")]
			private void RotateFoot()
			{
			}

			[Token(Token = "0x600031C")]
			[Address(RVA = "0xF76EA0", Offset = "0xF76EA0", VA = "0xF76EA0")]
			private Quaternion GetRotationOffsetTarget()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x600031E")]
			[Address(RVA = "0xF74988", Offset = "0xF74988", VA = "0xF74988")]
			public Leg()
			{
			}
		}

		[Token(Token = "0x200006B")]
		public class Pelvis
		{
			[Token(Token = "0x4000229")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Grounding grounding;

			[Token(Token = "0x400022A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Vector3 lastRootPosition;

			[Token(Token = "0x400022B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float damperF;

			[Token(Token = "0x400022C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private bool initiated;

			[Token(Token = "0x400022D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float lastTime;

			[Token(Token = "0x1700004D")]
			public Vector3 IKOffset
			{
				[Token(Token = "0x600031F")]
				[Address(RVA = "0xF77050", Offset = "0xF77050", VA = "0xF77050")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000320")]
				[Address(RVA = "0xF7705C", Offset = "0xF7705C", VA = "0xF7705C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700004E")]
			public float heightOffset
			{
				[Token(Token = "0x6000321")]
				[Address(RVA = "0xF77068", Offset = "0xF77068", VA = "0xF77068")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000322")]
				[Address(RVA = "0xF77070", Offset = "0xF77070", VA = "0xF77070")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x6000323")]
			[Address(RVA = "0xF74B00", Offset = "0xF74B00", VA = "0xF74B00")]
			public void Initiate(Grounding grounding)
			{
			}

			[Token(Token = "0x6000324")]
			[Address(RVA = "0xF75710", Offset = "0xF75710", VA = "0xF75710")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000325")]
			[Address(RVA = "0xF77078", Offset = "0xF77078", VA = "0xF77078")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x6000326")]
			[Address(RVA = "0xF754F0", Offset = "0xF754F0", VA = "0xF754F0")]
			public void Process(float lowestOffset, float highestOffset, bool isGrounded)
			{
			}

			[Token(Token = "0x6000327")]
			[Address(RVA = "0xF74A20", Offset = "0xF74A20", VA = "0xF74A20")]
			public Pelvis()
			{
			}
		}

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Tooltip("Layers to ground the character to. Make sure to exclude the layer of the character controller.")]
		public LayerMask layers;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[Tooltip("Max step height. Maximum vertical distance of Grounding from the root of the character.")]
		public float maxStep;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The height offset of the root.")]
		public float heightOffset;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("The speed of moving the feet up/down.")]
		public float footSpeed;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("CapsuleCast radius. Should match approximately with the size of the feet.")]
		public float footRadius;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("Offset of the foot center along character forward axis.")]
		[HideInInspector]
		public float footCenterOffset;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Amount of velocity based prediction of the foot positions.")]
		public float prediction;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Range(0f, 1f)]
		[Tooltip("Weight of rotating the feet to the ground normal offset.")]
		public float footRotationWeight;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Speed of slerping the feet to their grounded rotations.")]
		public float footRotationSpeed;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Range(0f, 90f)]
		[Tooltip("Max Foot Rotation Angle. Max angular offset from the foot's rotation.")]
		public float maxFootRotationAngle;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("If true, solver will rotate with the character root so the character can be grounded for example to spherical planets. For performance reasons leave this off unless needed.")]
		public bool rotateSolver;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("The speed of moving the character up/down.")]
		public float pelvisSpeed;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Used for smoothing out vertical pelvis movement (range 0 - 1).")]
		[Range(0f, 1f)]
		public float pelvisDamper;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Tooltip("The weight of lowering the pelvis to the lowest foot.")]
		public float lowerPelvisWeight;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("The weight of lifting the pelvis to the highest foot. This is useful when you don't want the feet to go too high relative to the body when crouching.")]
		public float liftPelvisWeight;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("The radius of the spherecast from the root that determines whether the character root is grounded.")]
		public float rootSphereCastRadius;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("If false, keeps the foot that is over a ledge at the root level. If true, lowers the overstepping foot and body by the 'Max Step' value.")]
		public bool overstepFallsDown;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Tooltip("The raycasting quality. Fastest is a single raycast per foot, Simple is three raycasts, Best is one raycast and a capsule cast per foot.")]
		public Quality quality;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public OnRaycastDelegate Raycast;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public OnCapsuleCastDelegate CapsuleCast;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public OnSphereCastDelegate SphereCast;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool initiated;

		[Token(Token = "0x17000039")]
		public Leg[] legs
		{
			[Token(Token = "0x60002D8")]
			[Address(RVA = "0xF74534", Offset = "0xF74534", VA = "0xF74534")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60002D9")]
			[Address(RVA = "0xF7453C", Offset = "0xF7453C", VA = "0xF7453C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700003A")]
		public Pelvis pelvis
		{
			[Token(Token = "0x60002DA")]
			[Address(RVA = "0xF74544", Offset = "0xF74544", VA = "0xF74544")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60002DB")]
			[Address(RVA = "0xF7454C", Offset = "0xF7454C", VA = "0xF7454C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700003B")]
		public bool isGrounded
		{
			[Token(Token = "0x60002DC")]
			[Address(RVA = "0xF74554", Offset = "0xF74554", VA = "0xF74554")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002DD")]
			[Address(RVA = "0xF7455C", Offset = "0xF7455C", VA = "0xF7455C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700003C")]
		public Transform root
		{
			[Token(Token = "0x60002DE")]
			[Address(RVA = "0xF74568", Offset = "0xF74568", VA = "0xF74568")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60002DF")]
			[Address(RVA = "0xF74570", Offset = "0xF74570", VA = "0xF74570")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700003D")]
		public RaycastHit rootHit
		{
			[Token(Token = "0x60002E0")]
			[Address(RVA = "0xF74578", Offset = "0xF74578", VA = "0xF74578")]
			[CompilerGenerated]
			get
			{
				return default(RaycastHit);
			}
			[Token(Token = "0x60002E1")]
			[Address(RVA = "0xF74590", Offset = "0xF74590", VA = "0xF74590")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700003E")]
		public bool rootGrounded
		{
			[Token(Token = "0x60002E2")]
			[Address(RVA = "0xF745B0", Offset = "0xF745B0", VA = "0xF745B0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003F")]
		public Vector3 up
		{
			[Token(Token = "0x60002EA")]
			[Address(RVA = "0xF6F418", Offset = "0xF6F418", VA = "0xF6F418")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000040")]
		private bool useRootRotation
		{
			[Token(Token = "0x60002ED")]
			[Address(RVA = "0xF75838", Offset = "0xF75838", VA = "0xF75838")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0xF745F8", Offset = "0xF745F8", VA = "0xF745F8")]
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f)
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0xF74880", Offset = "0xF74880", VA = "0xF74880")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0xF6E9E4", Offset = "0xF6E9E4", VA = "0xF6E9E4")]
		public void Initiate(Transform root, Transform[] feet)
		{
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0xF6F15C", Offset = "0xF6F15C", VA = "0xF6F15C")]
		public void Update()
		{
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0xF71224", Offset = "0xF71224", VA = "0xF71224")]
		public Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0xF6E51C", Offset = "0xF6E51C", VA = "0xF6E51C")]
		public void Reset()
		{
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0xF74B24", Offset = "0xF74B24", VA = "0xF74B24")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0xF758EC", Offset = "0xF758EC", VA = "0xF758EC")]
		public float GetVerticalOffset(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0xF75970", Offset = "0xF75970", VA = "0xF75970")]
		public Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0xF75AC4", Offset = "0xF75AC4", VA = "0xF75AC4")]
		public Vector3 GetFootCenterOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0xF6E1A0", Offset = "0xF6E1A0", VA = "0xF6E1A0")]
		public Grounding()
		{
		}
	}
	[Token(Token = "0x200006C")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Aim IK")]
	[HelpURL("https://www.youtube.com/watch?v=wT8fViZpLmQ&index=3&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	public class AimIK : IK
	{
		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverAim solver;

		[Token(Token = "0x6000328")]
		[Address(RVA = "0xF770CC", Offset = "0xF770CC", VA = "0xF770CC", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0xF77110", Offset = "0xF77110", VA = "0xF77110", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0xF77154", Offset = "0xF77154", VA = "0xF77154")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0xF77198", Offset = "0xF77198", VA = "0xF77198")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0xF771DC", Offset = "0xF771DC", VA = "0xF771DC")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0xF77220", Offset = "0xF77220", VA = "0xF77220", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0xF77228", Offset = "0xF77228", VA = "0xF77228")]
		public AimIK()
		{
		}
	}
	[Token(Token = "0x200006D")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Arm IK")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page2.html")]
	public class ArmIK : IK
	{
		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverArm solver;

		[Token(Token = "0x600032F")]
		[Address(RVA = "0xF7729C", Offset = "0xF7729C", VA = "0xF7729C", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0xF772E0", Offset = "0xF772E0", VA = "0xF772E0", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0xF77324", Offset = "0xF77324", VA = "0xF77324")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0xF77368", Offset = "0xF77368", VA = "0xF77368")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0xF773AC", Offset = "0xF773AC", VA = "0xF773AC", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0xF773B4", Offset = "0xF773B4", VA = "0xF773B4")]
		public ArmIK()
		{
		}
	}
	[Token(Token = "0x200006E")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/CCD IK")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page5.html")]
	public class CCDIK : IK
	{
		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverCCD solver;

		[Token(Token = "0x6000335")]
		[Address(RVA = "0xF77428", Offset = "0xF77428", VA = "0xF77428", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0xF7746C", Offset = "0xF7746C", VA = "0xF7746C", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0xF774B0", Offset = "0xF774B0", VA = "0xF774B0")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0xF774F4", Offset = "0xF774F4", VA = "0xF774F4")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0xF77538", Offset = "0xF77538", VA = "0xF77538", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0xF77540", Offset = "0xF77540", VA = "0xF77540")]
		public CCDIK()
		{
		}
	}
	[Token(Token = "0x200006F")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page6.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/FABRIK")]
	public class FABRIK : IK
	{
		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIK solver;

		[Token(Token = "0x600033B")]
		[Address(RVA = "0xF785B4", Offset = "0xF785B4", VA = "0xF785B4", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0xF785F8", Offset = "0xF785F8", VA = "0xF785F8", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0xF7863C", Offset = "0xF7863C", VA = "0xF7863C")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0xF78680", Offset = "0xF78680", VA = "0xF78680")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0xF786C4", Offset = "0xF786C4", VA = "0xF786C4", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0xF786CC", Offset = "0xF786CC", VA = "0xF786CC")]
		public FABRIK()
		{
		}
	}
	[Token(Token = "0x2000070")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page7.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/FABRIK Root")]
	public class FABRIKRoot : IK
	{
		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIKRoot solver;

		[Token(Token = "0x6000341")]
		[Address(RVA = "0xF78748", Offset = "0xF78748", VA = "0xF78748", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0xF7878C", Offset = "0xF7878C", VA = "0xF7878C", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0xF787D0", Offset = "0xF787D0", VA = "0xF787D0")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0xF78814", Offset = "0xF78814", VA = "0xF78814")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0xF78858", Offset = "0xF78858", VA = "0xF78858", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0xF78860", Offset = "0xF78860", VA = "0xF78860")]
		public FABRIKRoot()
		{
		}
	}
	[Token(Token = "0x2000071")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Full Body Biped IK")]
	[HelpURL("https://www.youtube.com/watch?v=7__IafZGwvI&index=1&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	public class FullBodyBipedIK : IK
	{
		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverFullBodyBiped solver;

		[Token(Token = "0x6000347")]
		[Address(RVA = "0xF788D4", Offset = "0xF788D4", VA = "0xF788D4", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0xF78918", Offset = "0xF78918", VA = "0xF78918", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0xF7895C", Offset = "0xF7895C", VA = "0xF7895C")]
		[ContextMenu("TUTORIAL VIDEO (SETUP)")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0xF789A0", Offset = "0xF789A0", VA = "0xF789A0")]
		[ContextMenu("TUTORIAL VIDEO (INSPECTOR)")]
		private void OpenInspectorTutorial()
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0xF789E4", Offset = "0xF789E4", VA = "0xF789E4")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0xF78A28", Offset = "0xF78A28", VA = "0xF78A28")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0xF78A6C", Offset = "0xF78A6C", VA = "0xF78A6C")]
		public void SetReferences(BipedReferences references, Transform rootNode)
		{
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0xF78AAC", Offset = "0xF78AAC", VA = "0xF78AAC", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0xF78AB4", Offset = "0xF78AB4", VA = "0xF78AB4")]
		public bool ReferencesError(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0xF78C84", Offset = "0xF78C84", VA = "0xF78C84")]
		public bool ReferencesWarning(ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0xF79140", Offset = "0xF79140", VA = "0xF79140")]
		[ContextMenu("Reinitiate")]
		private void Reinitiate()
		{
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0xF79160", Offset = "0xF79160", VA = "0xF79160")]
		[ContextMenu("Auto-detect References")]
		private void AutoDetectReferences()
		{
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0xF79250", Offset = "0xF79250", VA = "0xF79250")]
		public FullBodyBipedIK()
		{
		}
	}
	[Token(Token = "0x2000072")]
	public abstract class IK : SolverManager
	{
		[Token(Token = "0x6000354")]
		public abstract IKSolver GetIKSolver();

		[Token(Token = "0x6000355")]
		[Address(RVA = "0xF79300", Offset = "0xF79300", VA = "0xF79300", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0xF793E4", Offset = "0xF793E4", VA = "0xF793E4", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0xF795D4", Offset = "0xF795D4", VA = "0xF795D4", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000358")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x6000359")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x600035A")]
		[Address(RVA = "0xF78740", Offset = "0xF78740", VA = "0xF78740")]
		protected IK()
		{
		}
	}
	[Token(Token = "0x2000073")]
	public class IKExecutionOrder : MonoBehaviour
	{
		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The IK components, assign in the order in which you wish to update them.")]
		public IK[] IKComponents;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Optional. Assign it if you are using 'Animate Physics' as the Update Mode.")]
		public Animator animator;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool fixedFrame;

		[Token(Token = "0x1700004F")]
		private bool animatePhysics
		{
			[Token(Token = "0x600035B")]
			[Address(RVA = "0xF79624", Offset = "0xF79624", VA = "0xF79624")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0xF796B0", Offset = "0xF796B0", VA = "0xF796B0")]
		private void Start()
		{
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0xF79714", Offset = "0xF79714", VA = "0xF79714")]
		private void Update()
		{
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0xF797B4", Offset = "0xF797B4", VA = "0xF797B4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0xF797E0", Offset = "0xF797E0", VA = "0xF797E0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0xF79738", Offset = "0xF79738", VA = "0xF79738")]
		private void FixTransforms()
		{
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0xF79860", Offset = "0xF79860", VA = "0xF79860")]
		public IKExecutionOrder()
		{
		}
	}
	[Token(Token = "0x2000074")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Leg IK")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page11.html")]
	public class LegIK : IK
	{
		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLeg solver;

		[Token(Token = "0x6000362")]
		[Address(RVA = "0xF79868", Offset = "0xF79868", VA = "0xF79868", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0xF798AC", Offset = "0xF798AC", VA = "0xF798AC", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0xF798F0", Offset = "0xF798F0", VA = "0xF798F0")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0xF79934", Offset = "0xF79934", VA = "0xF79934")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0xF79978", Offset = "0xF79978", VA = "0xF79978", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0xF79980", Offset = "0xF79980", VA = "0xF79980")]
		public LegIK()
		{
		}
	}
	[Token(Token = "0x2000075")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page12.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Limb IK")]
	public class LimbIK : IK
	{
		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLimb solver;

		[Token(Token = "0x6000368")]
		[Address(RVA = "0xF799F4", Offset = "0xF799F4", VA = "0xF799F4", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0xF79A38", Offset = "0xF79A38", VA = "0xF79A38", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0xF79A7C", Offset = "0xF79A7C", VA = "0xF79A7C")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0xF79AC0", Offset = "0xF79AC0", VA = "0xF79AC0")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0xF79B04", Offset = "0xF79B04", VA = "0xF79B04", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0xF79B0C", Offset = "0xF79B0C", VA = "0xF79B0C")]
		public LimbIK()
		{
		}
	}
	[Token(Token = "0x2000076")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page13.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Look At IK")]
	public class LookAtIK : IK
	{
		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt solver;

		[Token(Token = "0x600036E")]
		[Address(RVA = "0xF79B80", Offset = "0xF79B80", VA = "0xF79B80", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0xF79BC4", Offset = "0xF79BC4", VA = "0xF79BC4", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0xF79C08", Offset = "0xF79C08", VA = "0xF79C08")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0xF79C4C", Offset = "0xF79C4C", VA = "0xF79C4C")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0xF79C90", Offset = "0xF79C90", VA = "0xF79C90", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0xF79C98", Offset = "0xF79C98", VA = "0xF79C98")]
		public LookAtIK()
		{
		}
	}
	[Token(Token = "0x2000077")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page15.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Trigonometric IK")]
	public class TrigonometricIK : IK
	{
		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverTrigonometric solver;

		[Token(Token = "0x6000374")]
		[Address(RVA = "0xF79D0C", Offset = "0xF79D0C", VA = "0xF79D0C", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0xF79D50", Offset = "0xF79D50", VA = "0xF79D50", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0xF79D94", Offset = "0xF79D94", VA = "0xF79D94")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0xF79DD8", Offset = "0xF79DD8", VA = "0xF79DD8")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0xF79E1C", Offset = "0xF79E1C", VA = "0xF79E1C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0xF79E24", Offset = "0xF79E24", VA = "0xF79E24")]
		public TrigonometricIK()
		{
		}
	}
	[Token(Token = "0x2000078")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/VR IK")]
	public class VRIK : IK
	{
		[Serializable]
		[Token(Token = "0x2000079")]
		public class References
		{
			[Token(Token = "0x400023E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform root;

			[Token(Token = "0x400023F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[LargeHeader("Spine")]
			public Transform pelvis;

			[Token(Token = "0x4000240")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform spine;

			[Token(Token = "0x4000241")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Optional")]
			public Transform chest;

			[Token(Token = "0x4000242")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("Optional")]
			public Transform neck;

			[Token(Token = "0x4000243")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Transform head;

			[Token(Token = "0x4000244")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[LargeHeader("Left Arm")]
			[Tooltip("Optional")]
			public Transform leftShoulder;

			[Token(Token = "0x4000245")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[Tooltip("VRIK also supports armless characters.If you do not wish to use arms, leave all arm references empty.")]
			public Transform leftUpperArm;

			[Token(Token = "0x4000246")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("VRIK also supports armless characters.If you do not wish to use arms, leave all arm references empty.")]
			public Transform leftForearm;

			[Token(Token = "0x4000247")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Tooltip("VRIK also supports armless characters.If you do not wish to use arms, leave all arm references empty.")]
			public Transform leftHand;

			[Token(Token = "0x4000248")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[Tooltip("Optional")]
			[LargeHeader("Right Arm")]
			public Transform rightShoulder;

			[Token(Token = "0x4000249")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[Tooltip("VRIK also supports armless characters.If you do not wish to use arms, leave all arm references empty.")]
			public Transform rightUpperArm;

			[Token(Token = "0x400024A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[Tooltip("VRIK also supports armless characters.If you do not wish to use arms, leave all arm references empty.")]
			public Transform rightForearm;

			[Token(Token = "0x400024B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[Tooltip("VRIK also supports armless characters.If you do not wish to use arms, leave all arm references empty.")]
			public Transform rightHand;

			[Token(Token = "0x400024C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			[LargeHeader("Left Leg")]
			public Transform leftThigh;

			[Token(Token = "0x400024D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform leftCalf;

			[Token(Token = "0x400024E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform leftFoot;

			[Token(Token = "0x400024F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[Tooltip("Optional")]
			public Transform leftToes;

			[Token(Token = "0x4000250")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			[LargeHeader("Right Leg")]
			public Transform rightThigh;

			[Token(Token = "0x4000251")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform rightCalf;

			[Token(Token = "0x4000252")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform rightFoot;

			[Token(Token = "0x4000253")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			[Tooltip("Optional")]
			public Transform rightToes;

			[Token(Token = "0x17000050")]
			public bool isFilled
			{
				[Token(Token = "0x6000386")]
				[Address(RVA = "0xF7A874", Offset = "0xF7A874", VA = "0xF7A874")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000051")]
			public bool isEmpty
			{
				[Token(Token = "0x6000387")]
				[Address(RVA = "0xF7A4B8", Offset = "0xF7A4B8", VA = "0xF7A4B8")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000383")]
			[Address(RVA = "0xF7AFB0", Offset = "0xF7AFB0", VA = "0xF7AFB0")]
			public References()
			{
			}

			[Token(Token = "0x6000384")]
			[Address(RVA = "0xF7AFB8", Offset = "0xF7AFB8", VA = "0xF7AFB8")]
			public References(BipedReferences b)
			{
			}

			[Token(Token = "0x6000385")]
			[Address(RVA = "0xF7B1A8", Offset = "0xF7B1A8", VA = "0xF7B1A8")]
			public Transform[] GetTransforms()
			{
				return null;
			}

			[Token(Token = "0x6000388")]
			[Address(RVA = "0xF79F80", Offset = "0xF79F80", VA = "0xF79F80")]
			public static bool AutoDetectReferences(Transform root, out References references)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Bone mapping. Right-click on the component header and select 'Auto-detect References' of fill in manually if not a Humanoid character. Chest, neck, shoulder and toe bones are optional. VRIK also supports legless characters. If you do not wish to use legs, leave all leg references empty.")]
		[ContextMenuItem("Auto-detect References", "AutoDetectReferences")]
		public References references;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The VRIK solver.")]
		public IKSolverVR solver;

		[Token(Token = "0x600037A")]
		[Address(RVA = "0xF79E98", Offset = "0xF79E98", VA = "0xF79E98", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0xF79EDC", Offset = "0xF79EDC", VA = "0xF79EDC", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0xF79F20", Offset = "0xF79F20", VA = "0xF79F20")]
		[ContextMenu("TUTORIAL VIDEO (STEAMVR SETUP)")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0xF79F64", Offset = "0xF79F64", VA = "0xF79F64")]
		[ContextMenu("Auto-detect References")]
		public void AutoDetectReferences()
		{
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0xF7A41C", Offset = "0xF7A41C", VA = "0xF7A41C")]
		[ContextMenu("Guess Hand Orientations")]
		public void GuessHandOrientations()
		{
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0xF7A444", Offset = "0xF7A444", VA = "0xF7A444", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0xF7A44C", Offset = "0xF7A44C", VA = "0xF7A44C", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0xF7AD70", Offset = "0xF7AD70", VA = "0xF7AD70", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0xF7AF00", Offset = "0xF7AF00", VA = "0xF7AF00")]
		public VRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200007A")]
	public class FABRIKChain
	{
		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FABRIK ik;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float pull;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Range(0f, 1f)]
		public float pin;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int[] children;

		[Token(Token = "0x6000389")]
		[Address(RVA = "0xF7B6EC", Offset = "0xF7B6EC", VA = "0xF7B6EC")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0xF7B7BC", Offset = "0xF7B7BC", VA = "0xF7B7BC")]
		public void Initiate()
		{
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0xF7B7DC", Offset = "0xF7B7DC", VA = "0xF7B7DC")]
		public void Stage1(FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0xF7BA30", Offset = "0xF7BA30", VA = "0xF7BA30")]
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0xF7B89C", Offset = "0xF7B89C", VA = "0xF7B89C")]
		private Vector3 GetCentroid(FABRIKChain[] chain)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0xF7BB14", Offset = "0xF7BB14", VA = "0xF7BB14")]
		public FABRIKChain()
		{
		}
	}
	[Token(Token = "0x200007B")]
	public class FBBIKArmBending : MonoBehaviour
	{
		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 bendDirectionOffsetLeft;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 bendDirectionOffsetRight;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 characterSpaceBendOffsetLeft;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 characterSpaceBendOffsetRight;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion leftHandTargetRotation;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Quaternion rightHandTargetRotation;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool initiated;

		[Token(Token = "0x600038F")]
		[Address(RVA = "0xF7BB80", Offset = "0xF7BB80", VA = "0xF7BB80")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0xF7C0F8", Offset = "0xF7C0F8", VA = "0xF7C0F8")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0xF7C28C", Offset = "0xF7C28C", VA = "0xF7C28C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0xF7C3B4", Offset = "0xF7C3B4", VA = "0xF7C3B4")]
		public FBBIKArmBending()
		{
		}
	}
	[Token(Token = "0x200007C")]
	public class FBBIKHeadEffector : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200007D")]
		public class BendBone
		{
			[Token(Token = "0x400028E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Assign spine and/or neck bones.")]
			public Transform transform;

			[Token(Token = "0x400028F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Range(0f, 1f)]
			[Tooltip("The weight of rotating this bone.")]
			public float weight;

			[Token(Token = "0x4000290")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x60003A1")]
			[Address(RVA = "0xF7F718", Offset = "0xF7F718", VA = "0xF7F718")]
			public BendBone()
			{
			}

			[Token(Token = "0x60003A2")]
			[Address(RVA = "0xF7F778", Offset = "0xF7F778", VA = "0xF7F778")]
			public BendBone(Transform transform, float weight)
			{
			}

			[Token(Token = "0x60003A3")]
			[Address(RVA = "0xF7CD6C", Offset = "0xF7CD6C", VA = "0xF7CD6C")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60003A4")]
			[Address(RVA = "0xF7D13C", Offset = "0xF7D13C", VA = "0xF7D13C")]
			public void FixTransforms()
			{
			}
		}

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Reference to the FBBIK component.")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[LargeHeader("Position")]
		[Tooltip("Master weight for positioning the head.")]
		[Range(0f, 1f)]
		public float positionWeight;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Range(0f, 1f)]
		[Tooltip("The weight of moving the body along with the head")]
		public float bodyWeight;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Range(0f, 1f)]
		[Tooltip("The weight of moving the thighs along with the head")]
		public float thighWeight;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("If false, hands will not pull the head away if they are too far. Disabling this will improve performance significantly.")]
		public bool handsPullBody;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[LargeHeader("Rotation")]
		[Tooltip("The weight of rotating the head bone after solving")]
		[Range(0f, 1f)]
		public float rotationWeight;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Range(0f, 1f)]
		[Tooltip("Clamping the rotation of the body")]
		public float bodyClampWeight;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Clamping the rotation of the head")]
		[Range(0f, 1f)]
		public float headClampWeight;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("The master weight of bending/twisting the spine to the rotation of the head effector. This is similar to CCD, but uses the rotation of the head effector not the position.")]
		[Range(0f, 1f)]
		public float bendWeight;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The bones to use for bending.")]
		public BendBone[] bendBones;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Optional. The master weight of the CCD (Cyclic Coordinate Descent) IK effect that bends the spine towards the head effector before FBBIK solves.")]
		[Range(0f, 1f)]
		[LargeHeader("CCD")]
		public float CCDWeight;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("The weight of rolling the bones in towards the target")]
		[Range(0f, 1f)]
		public float roll;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("Smoothing the CCD effect.")]
		[Range(0f, 1000f)]
		public float damper;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("Bones to use for the CCD pass. Assign spine and/or neck bones.")]
		public Transform[] CCDBones;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Range(0f, 1f)]
		[Tooltip("Stretching the spine/neck to help reach the target. This is useful for making sure the head stays locked relative to the VR headset. NB! Stretching is done after FBBIK has solved so if you have the hand effectors pinned and spine bones included in the 'Stretch Bones', the hands might become offset from their target positions.")]
		[LargeHeader("Stretching")]
		public float postStretchWeight;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[Tooltip("Stretch magnitude limit.")]
		public float maxStretch;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Tooltip("If > 0, dampers the stretching effect.")]
		public float stretchDamper;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[Tooltip("If true, will fix head position to this Transform no matter what. Good for making sure the head will not budge away from the VR headset")]
		public bool fixHead;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Tooltip("Bones to use for stretching. The more bones you add, the less noticable the effect.")]
		public Transform[] stretchBones;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[LargeHeader("Chest Direction")]
		public Vector3 chestDirection;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[Range(0f, 1f)]
		public float chestDirectionWeight;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] chestBones;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IKSolver.UpdateDelegate OnPostHeadEffectorFK;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 offset;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 headToBody;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 shoulderCenterToHead;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Vector3 headToLeftThigh;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Vector3 headToRightThigh;

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 leftShoulderPos;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Vector3 rightShoulderPos;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private float shoulderDist;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private float leftShoulderDist;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private float rightShoulderDist;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion chestRotation;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Quaternion headRotationRelativeToRoot;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Quaternion[] ccdDefaultLocalRotations;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 headLocalPosition;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private Quaternion headLocalRotation;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector3[] stretchLocalPositions;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Quaternion[] stretchLocalRotations;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Vector3[] chestLocalPositions;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Quaternion[] chestLocalRotations;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private int bendBonesCount;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private int ccdBonesCount;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private int stretchBonesCount;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private int chestBonesCount;

		[Token(Token = "0x6000393")]
		[Address(RVA = "0xF7C3BC", Offset = "0xF7C3BC", VA = "0xF7C3BC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0xF7C8BC", Offset = "0xF7C8BC", VA = "0xF7C8BC")]
		private void OnStoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0xF7CD98", Offset = "0xF7CD98", VA = "0xF7CD98")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0xF7D164", Offset = "0xF7D164", VA = "0xF7D164")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0xF7DA60", Offset = "0xF7DA60", VA = "0xF7DA60")]
		private void SpineBend()
		{
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0xF7DE58", Offset = "0xF7DE58", VA = "0xF7DE58")]
		private void CCDPass()
		{
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0xF7E268", Offset = "0xF7E268", VA = "0xF7E268")]
		private void Iterate(int iteration)
		{
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0xF7EBE0", Offset = "0xF7EBE0", VA = "0xF7EBE0")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0xF7D7A4", Offset = "0xF7D7A4", VA = "0xF7D7A4")]
		private void ChestDirection()
		{
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0xF7EE1C", Offset = "0xF7EE1C", VA = "0xF7EE1C")]
		private void PostStretching()
		{
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0xF7EB00", Offset = "0xF7EB00", VA = "0xF7EB00")]
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset)
		{
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0xF7EA00", Offset = "0xF7EA00", VA = "0xF7EA00")]
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance)
		{
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0xF7F17C", Offset = "0xF7F17C", VA = "0xF7F17C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0xF7F504", Offset = "0xF7F504", VA = "0xF7F504")]
		public FBBIKHeadEffector()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200007E")]
	public class FBIKChain
	{
		[Serializable]
		[Token(Token = "0x200007F")]
		public class ChildConstraint
		{
			[Token(Token = "0x40002A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float pushElasticity;

			[Token(Token = "0x40002A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float pullElasticity;

			[Token(Token = "0x40002AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Transform bone1;

			[Token(Token = "0x40002AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Transform bone2;

			[Token(Token = "0x40002AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float crossFade;

			[Token(Token = "0x40002AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float inverseCrossFade;

			[Token(Token = "0x40002B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int chain1Index;

			[Token(Token = "0x40002B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private int chain2Index;

			[Token(Token = "0x17000052")]
			public float nominalDistance
			{
				[Token(Token = "0x60003B9")]
				[Address(RVA = "0xF828B4", Offset = "0xF828B4", VA = "0xF828B4")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60003BA")]
				[Address(RVA = "0xF828BC", Offset = "0xF828BC", VA = "0xF828BC")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000053")]
			public bool isRigid
			{
				[Token(Token = "0x60003BB")]
				[Address(RVA = "0xF828C4", Offset = "0xF828C4", VA = "0xF828C4")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60003BC")]
				[Address(RVA = "0xF828CC", Offset = "0xF828CC", VA = "0xF828CC")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x60003BD")]
			[Address(RVA = "0xF828D8", Offset = "0xF828D8", VA = "0xF828D8")]
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f, float pullElasticity = 0f)
			{
			}

			[Token(Token = "0x60003BE")]
			[Address(RVA = "0xF80588", Offset = "0xF80588", VA = "0xF80588")]
			public void Initiate(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60003BF")]
			[Address(RVA = "0xF80C6C", Offset = "0xF80C6C", VA = "0xF80C6C")]
			public void OnPreSolve(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60003C0")]
			[Address(RVA = "0xF82678", Offset = "0xF82678", VA = "0xF82678")]
			public void Solve(IKSolverFullBody solver)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000080")]
		public enum Smoothing
		{
			[Token(Token = "0x40002B3")]
			None,
			[Token(Token = "0x40002B4")]
			Exponential,
			[Token(Token = "0x40002B5")]
			Cubic
		}

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Range(0f, 1f)]
		public float pin;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[Range(0f, 1f)]
		public float pull;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float push;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Range(-1f, 1f)]
		public float pushParent;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		public float reach;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Smoothing reachSmoothing;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Smoothing pushSmoothing;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolver.Node[] nodes;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int[] children;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ChildConstraint[] childConstraints;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public IKConstraintBend bendConstraint;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float rootLength;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private bool initiated;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float length;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float distance;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private IKSolver.Point p;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float reachForce;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float pullParentSum;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float[] crossFades;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float sqrMag1;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private float sqrMag2;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float sqrMagDif;

		[Token(Token = "0x40002A7")]
		private const float maxLimbLength = 0.99999f;

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0xF7F800", Offset = "0xF7F800", VA = "0xF7F800")]
		public FBIKChain()
		{
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0xF7F998", Offset = "0xF7F998", VA = "0xF7F998")]
		public FBIKChain(float pin, float pull, params Transform[] nodeTransforms)
		{
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0xF7FB08", Offset = "0xF7FB08", VA = "0xF7FB08")]
		public void SetNodes(params Transform[] boneTransforms)
		{
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0xF7FC6C", Offset = "0xF7FC6C", VA = "0xF7FC6C")]
		public int GetNodeIndex(Transform boneTransform)
		{
			return default(int);
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0xF7FD28", Offset = "0xF7FD28", VA = "0xF7FD28")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0xF7FE44", Offset = "0xF7FE44", VA = "0xF7FE44")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0xF80888", Offset = "0xF80888", VA = "0xF80888")]
		public void ReadPose(IKSolverFullBody solver, bool fullBody)
		{
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0xF7FFC0", Offset = "0xF7FFC0", VA = "0xF7FFC0")]
		private void CalculateBoneLengths(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0xF80E50", Offset = "0xF80E50", VA = "0xF80E50")]
		public void Reach(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0xF810E4", Offset = "0xF810E4", VA = "0xF810E4")]
		public Vector3 Push(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0xF813B4", Offset = "0xF813B4", VA = "0xF813B4")]
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false)
		{
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0xF81D7C", Offset = "0xF81D7C", VA = "0xF81D7C")]
		public void Stage1(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0xF82274", Offset = "0xF82274", VA = "0xF82274")]
		public void Stage2(IKSolverFullBody solver, Vector3 position)
		{
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0xF82474", Offset = "0xF82474", VA = "0xF82474")]
		public void SolveConstraintSystems(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0xF82160", Offset = "0xF82160", VA = "0xF82160")]
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0xF81C1C", Offset = "0xF81C1C", VA = "0xF81C1C")]
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0xF820FC", Offset = "0xF820FC", VA = "0xF820FC")]
		private void SolveChildConstraints(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0xF82550", Offset = "0xF82550", VA = "0xF82550")]
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance)
		{
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0xF82028", Offset = "0xF82028", VA = "0xF82028")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0xF82378", Offset = "0xF82378", VA = "0xF82378")]
		private void BackwardReach(Vector3 position)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000081")]
	public class IKConstraintBend
	{
		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone1;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone2;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone3;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bendGoal;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 direction;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Quaternion rotationOffset;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Vector3 defaultLocalDirection;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Vector3 defaultChildDirection;

		[NonSerialized]
		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float clampF;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private int chainIndex1;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int nodeIndex1;

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int chainIndex2;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int nodeIndex2;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int chainIndex3;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int nodeIndex3;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x85")]
		private bool limbOrientationsSet;

		[Token(Token = "0x17000054")]
		public bool initiated
		{
			[Token(Token = "0x60003C2")]
			[Address(RVA = "0xF82B0C", Offset = "0xF82B0C", VA = "0xF82B0C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003C3")]
			[Address(RVA = "0xF82B14", Offset = "0xF82B14", VA = "0xF82B14")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0xF82934", Offset = "0xF82934", VA = "0xF82934")]
		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0xF7F92C", Offset = "0xF7F92C", VA = "0xF7F92C")]
		public IKConstraintBend()
		{
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0xF82B20", Offset = "0xF82B20", VA = "0xF82B20")]
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0xF805DC", Offset = "0xF805DC", VA = "0xF805DC")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0xF80620", Offset = "0xF80620", VA = "0xF80620")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0xF82CFC", Offset = "0xF82CFC", VA = "0xF82CFC")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last)
		{
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0xF83050", Offset = "0xF83050", VA = "0xF83050")]
		public void LimitBend(float solverWeight, float positionWeight)
		{
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0xF815EC", Offset = "0xF815EC", VA = "0xF815EC")]
		public Vector3 GetDir(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0xF82BB4", Offset = "0xF82BB4", VA = "0xF82BB4")]
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0xF82C58", Offset = "0xF82C58", VA = "0xF82C58")]
		private Vector3 OrthoToBone1(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x2000082")]
	public class IKEffector
	{
		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		public float positionWeight;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Range(0f, 1f)]
		public float rotationWeight;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 position;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Quaternion rotation;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 positionOffset;

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool effectChildNodes;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Range(0f, 1f)]
		public float maintainRelativePositionWeight;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform[] childBones;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform planeBone1;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform planeBone2;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform planeBone3;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Quaternion planeRotationOffset;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float posW;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float rotW;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3[] localPositions;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool usePlaneNodes;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Quaternion animatedPlaneRotation;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Vector3 animatedPosition;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private bool firstUpdate;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int chainIndex;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int nodeIndex;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private int plane1ChainIndex;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private int plane1NodeIndex;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private int plane2ChainIndex;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private int plane2NodeIndex;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private int plane3ChainIndex;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private int plane3NodeIndex;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private int[] childChainIndexes;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private int[] childNodeIndexes;

		[Token(Token = "0x17000055")]
		public bool isEndEffector
		{
			[Token(Token = "0x60003CE")]
			[Address(RVA = "0xF83418", Offset = "0xF83418", VA = "0xF83418")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003CF")]
			[Address(RVA = "0xF83420", Offset = "0xF83420", VA = "0xF83420")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0xF7F120", Offset = "0xF7F120", VA = "0xF7F120")]
		public IKSolver.Node GetNode(IKSolverFullBody solver)
		{
			return null;
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0xF8342C", Offset = "0xF8342C", VA = "0xF8342C")]
		public void PinToBone(float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0xF834B0", Offset = "0xF834B0", VA = "0xF834B0")]
		public IKEffector()
		{
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0xF83680", Offset = "0xF83680", VA = "0xF83680")]
		public IKEffector(Transform bone, Transform[] childBones)
		{
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0xF8388C", Offset = "0xF8388C", VA = "0xF8388C")]
		public bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0xF83B94", Offset = "0xF83B94", VA = "0xF83B94")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0xF83E6C", Offset = "0xF83E6C", VA = "0xF83E6C")]
		public void ResetOffset(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0xF83F8C", Offset = "0xF83F8C", VA = "0xF83F8C")]
		public void SetToTarget()
		{
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0xF84028", Offset = "0xF84028", VA = "0xF84028")]
		public void OnPreSolve(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0xF846DC", Offset = "0xF846DC", VA = "0xF846DC")]
		public void OnPostWrite()
		{
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0xF84734", Offset = "0xF84734", VA = "0xF84734")]
		private Quaternion GetPlaneRotation(IKSolverFullBody solver)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0xF84908", Offset = "0xF84908", VA = "0xF84908")]
		public void Update(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0xF84B64", Offset = "0xF84B64", VA = "0xF84B64")]
		private Vector3 GetPosition(IKSolverFullBody solver, out Quaternion planeRotationOffset)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x2000083")]
	public class IKMapping
	{
		[Serializable]
		[Token(Token = "0x2000084")]
		public class BoneMap
		{
			[Token(Token = "0x40002E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x40002E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int chainIndex;

			[Token(Token = "0x40002EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int nodeIndex;

			[Token(Token = "0x40002EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x40002EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x40002ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 localSwingAxis;

			[Token(Token = "0x40002EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 localTwistAxis;

			[Token(Token = "0x40002EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 planePosition;

			[Token(Token = "0x40002F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 ikPosition;

			[Token(Token = "0x40002F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion defaultLocalTargetRotation;

			[Token(Token = "0x40002F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			private Quaternion maintainRotation;

			[Token(Token = "0x40002F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			public float length;

			[Token(Token = "0x40002F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public Quaternion animatedRotation;

			[Token(Token = "0x40002F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private Transform planeBone1;

			[Token(Token = "0x40002F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private Transform planeBone2;

			[Token(Token = "0x40002F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private Transform planeBone3;

			[Token(Token = "0x40002F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private int plane1ChainIndex;

			[Token(Token = "0x40002F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private int plane1NodeIndex;

			[Token(Token = "0x40002FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private int plane2ChainIndex;

			[Token(Token = "0x40002FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			private int plane2NodeIndex;

			[Token(Token = "0x40002FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			private int plane3ChainIndex;

			[Token(Token = "0x40002FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			private int plane3NodeIndex;

			[Token(Token = "0x17000056")]
			public Vector3 swingDirection
			{
				[Token(Token = "0x60003E2")]
				[Address(RVA = "0xF850D4", Offset = "0xF850D4", VA = "0xF850D4")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000057")]
			public bool isNodeBone
			{
				[Token(Token = "0x60003E5")]
				[Address(RVA = "0xF8518C", Offset = "0xF8518C", VA = "0xF8518C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000058")]
			private Quaternion lastAnimatedTargetRotation
			{
				[Token(Token = "0x60003F9")]
				[Address(RVA = "0xF85578", Offset = "0xF85578", VA = "0xF85578")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x60003E1")]
			[Address(RVA = "0xF85090", Offset = "0xF85090", VA = "0xF85090")]
			public void Initiate(Transform transform, IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60003E3")]
			[Address(RVA = "0xF85104", Offset = "0xF85104", VA = "0xF85104")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60003E4")]
			[Address(RVA = "0xF85148", Offset = "0xF85148", VA = "0xF85148")]
			public void FixTransform(bool position)
			{
			}

			[Token(Token = "0x60003E6")]
			[Address(RVA = "0xF8519C", Offset = "0xF8519C", VA = "0xF8519C")]
			public void SetLength(BoneMap nextBone)
			{
			}

			[Token(Token = "0x60003E7")]
			[Address(RVA = "0xF85270", Offset = "0xF85270", VA = "0xF85270")]
			public void SetLocalSwingAxis(BoneMap swingTarget)
			{
			}

			[Token(Token = "0x60003E8")]
			[Address(RVA = "0xF85278", Offset = "0xF85278", VA = "0xF85278")]
			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2)
			{
			}

			[Token(Token = "0x60003E9")]
			[Address(RVA = "0xF85344", Offset = "0xF85344", VA = "0xF85344")]
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection)
			{
			}

			[Token(Token = "0x60003EA")]
			[Address(RVA = "0xF853B0", Offset = "0xF853B0", VA = "0xF853B0")]
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3)
			{
			}

			[Token(Token = "0x60003EB")]
			[Address(RVA = "0xF85468", Offset = "0xF85468", VA = "0xF85468")]
			public void UpdatePlane(bool rotation, bool position)
			{
			}

			[Token(Token = "0x60003EC")]
			[Address(RVA = "0xF856E0", Offset = "0xF856E0", VA = "0xF856E0")]
			public void SetIKPosition()
			{
			}

			[Token(Token = "0x60003ED")]
			[Address(RVA = "0xF8570C", Offset = "0xF8570C", VA = "0xF8570C")]
			public void MaintainRotation()
			{
			}

			[Token(Token = "0x60003EE")]
			[Address(RVA = "0xF85738", Offset = "0xF85738", VA = "0xF85738")]
			public void SetToIKPosition()
			{
			}

			[Token(Token = "0x60003EF")]
			[Address(RVA = "0xF85760", Offset = "0xF85760", VA = "0xF85760")]
			public void FixToNode(IKSolverFullBody solver, float weight, [Optional] IKSolver.Node fixNode)
			{
			}

			[Token(Token = "0x60003F0")]
			[Address(RVA = "0xF85824", Offset = "0xF85824", VA = "0xF85824")]
			public Vector3 GetPlanePosition(IKSolverFullBody solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60003F1")]
			[Address(RVA = "0xF859B8", Offset = "0xF859B8", VA = "0xF859B8")]
			public void PositionToPlane(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60003F2")]
			[Address(RVA = "0xF859DC", Offset = "0xF859DC", VA = "0xF859DC")]
			public void RotateToPlane(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x60003F3")]
			[Address(RVA = "0xF85AFC", Offset = "0xF85AFC", VA = "0xF85AFC")]
			public void Swing(Vector3 swingTarget, float weight)
			{
			}

			[Token(Token = "0x60003F4")]
			[Address(RVA = "0xF85B60", Offset = "0xF85B60", VA = "0xF85B60")]
			public void Swing(Vector3 pos1, Vector3 pos2, float weight)
			{
			}

			[Token(Token = "0x60003F5")]
			[Address(RVA = "0xF85CE0", Offset = "0xF85CE0", VA = "0xF85CE0")]
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight)
			{
			}

			[Token(Token = "0x60003F6")]
			[Address(RVA = "0xF85E60", Offset = "0xF85E60", VA = "0xF85E60")]
			public void RotateToMaintain(float weight)
			{
			}

			[Token(Token = "0x60003F7")]
			[Address(RVA = "0xF85EDC", Offset = "0xF85EDC", VA = "0xF85EDC")]
			public void RotateToEffector(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x60003F8")]
			[Address(RVA = "0xF8589C", Offset = "0xF8589C", VA = "0xF8589C")]
			private Quaternion GetTargetRotation(IKSolverFullBody solver)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60003FA")]
			[Address(RVA = "0xF86004", Offset = "0xF86004", VA = "0xF86004")]
			public BoneMap()
			{
			}
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0xF84E20", Offset = "0xF84E20", VA = "0xF84E20", Slot = "4")]
		public virtual bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0xF84E28", Offset = "0xF84E28", VA = "0xF84E28", Slot = "5")]
		public virtual void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0xF84E2C", Offset = "0xF84E2C", VA = "0xF84E2C")]
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, [Optional] Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0xF84F74", Offset = "0xF84F74", VA = "0xF84F74")]
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0xF85088", Offset = "0xF85088", VA = "0xF85088")]
		public IKMapping()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000085")]
	public class IKMappingBone : IKMapping
	{
		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float maintainRotationWeight;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private BoneMap boneMap;

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0xF86020", Offset = "0xF86020", VA = "0xF86020", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0xF860C8", Offset = "0xF860C8", VA = "0xF860C8")]
		public IKMappingBone()
		{
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0xF86158", Offset = "0xF86158", VA = "0xF86158")]
		public IKMappingBone(Transform bone)
		{
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0xF86204", Offset = "0xF86204", VA = "0xF86204")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0xF8621C", Offset = "0xF8621C", VA = "0xF8621C")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0xF86238", Offset = "0xF86238", VA = "0xF86238", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0xF862E0", Offset = "0xF862E0", VA = "0xF862E0")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0xF862F8", Offset = "0xF862F8", VA = "0xF862F8")]
		public void WritePose(float solverWeight)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000086")]
	public class IKMappingLimb : IKMapping
	{
		[Serializable]
		[Token(Token = "0x2000087")]
		public enum BoneMapType
		{
			[Token(Token = "0x400030D")]
			Parent,
			[Token(Token = "0x400030E")]
			Bone1,
			[Token(Token = "0x400030F")]
			Bone2,
			[Token(Token = "0x4000310")]
			Bone3
		}

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform parentBone;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone1;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone2;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bone3;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Range(0f, 1f)]
		public float maintainRotationWeight;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Range(0f, 1f)]
		public float weight;

		[NonSerialized]
		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool updatePlaneRotations;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private BoneMap boneMapParent;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap boneMap1;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap boneMap2;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private BoneMap boneMap3;

		[Token(Token = "0x6000403")]
		[Address(RVA = "0xF8631C", Offset = "0xF8631C", VA = "0xF8631C", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0xF86390", Offset = "0xF86390", VA = "0xF86390")]
		public BoneMap GetBoneMap(BoneMapType boneMap)
		{
			return null;
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0xF86458", Offset = "0xF86458", VA = "0xF86458")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower)
		{
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0xF86710", Offset = "0xF86710", VA = "0xF86710")]
		public IKMappingLimb()
		{
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0xF8685C", Offset = "0xF8685C", VA = "0xF8685C")]
		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0xF869E0", Offset = "0xF869E0", VA = "0xF869E0")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0xF86A40", Offset = "0xF86A40", VA = "0xF86A40")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0xF86AD8", Offset = "0xF86AD8", VA = "0xF86AD8")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0xF86B80", Offset = "0xF86B80", VA = "0xF86B80", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0xF86E34", Offset = "0xF86E34", VA = "0xF86E34")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0xF86E94", Offset = "0xF86E94", VA = "0xF86E94")]
		public void WritePose(IKSolverFullBody solver, bool fullBody)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000088")]
	public class IKMappingSpine : IKMapping
	{
		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform[] spineBones;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform leftUpperArmBone;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform rightUpperArmBone;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftThighBone;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform rightThighBone;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(1f, 3f)]
		public int iterations;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Range(0f, 1f)]
		public float twistWeight;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int rootNodeIndex;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap[] spine;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap leftUpperArm;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private BoneMap rightUpperArm;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private BoneMap leftThigh;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private BoneMap rightThigh;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool useFABRIK;

		[Token(Token = "0x600040E")]
		[Address(RVA = "0xF86FDC", Offset = "0xF86FDC", VA = "0xF86FDC", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0xF87308", Offset = "0xF87308", VA = "0xF87308")]
		public IKMappingSpine()
		{
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0xF87480", Offset = "0xF87480", VA = "0xF87480")]
		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0xF87638", Offset = "0xF87638", VA = "0xF87638")]
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0xF876AC", Offset = "0xF876AC", VA = "0xF876AC")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0xF87708", Offset = "0xF87708", VA = "0xF87708")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0xF87780", Offset = "0xF87780", VA = "0xF87780", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0xF87DF8", Offset = "0xF87DF8", VA = "0xF87DF8")]
		private bool UseFABRIK()
		{
			return default(bool);
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0xF87E30", Offset = "0xF87E30", VA = "0xF87E30")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0xF88094", Offset = "0xF88094", VA = "0xF88094")]
		public void WritePose(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0xF883BC", Offset = "0xF883BC", VA = "0xF883BC")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0xF8849C", Offset = "0xF8849C", VA = "0xF8849C")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0xF88550", Offset = "0xF88550", VA = "0xF88550")]
		private void MapToSolverPositions(IKSolverFullBody solver)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000089")]
	public abstract class IKSolver
	{
		[Serializable]
		[Token(Token = "0x200008A")]
		public class Point
		{
			[Token(Token = "0x4000329")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x400032A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Range(0f, 1f)]
			public float weight;

			[Token(Token = "0x400032B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 solverPosition;

			[Token(Token = "0x400032C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Quaternion solverRotation;

			[Token(Token = "0x400032D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x400032E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x6000431")]
			[Address(RVA = "0xF88C40", Offset = "0xF88C40", VA = "0xF88C40")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000432")]
			[Address(RVA = "0xF88C84", Offset = "0xF88C84", VA = "0xF88C84")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x6000433")]
			[Address(RVA = "0xF88D64", Offset = "0xF88D64", VA = "0xF88D64")]
			public void UpdateSolverPosition()
			{
			}

			[Token(Token = "0x6000434")]
			[Address(RVA = "0xF88D90", Offset = "0xF88D90", VA = "0xF88D90")]
			public void UpdateSolverLocalPosition()
			{
			}

			[Token(Token = "0x6000435")]
			[Address(RVA = "0xF88DBC", Offset = "0xF88DBC", VA = "0xF88DBC")]
			public void UpdateSolverState()
			{
			}

			[Token(Token = "0x6000436")]
			[Address(RVA = "0xF88E00", Offset = "0xF88E00", VA = "0xF88E00")]
			public void UpdateSolverLocalState()
			{
			}

			[Token(Token = "0x6000437")]
			[Address(RVA = "0xF88E44", Offset = "0xF88E44", VA = "0xF88E44")]
			public Point()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200008B")]
		public class Bone : Point
		{
			[Token(Token = "0x400032F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x4000330")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float sqrMag;

			[Token(Token = "0x4000331")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 axis;

			[Token(Token = "0x4000332")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private RotationLimit _rotationLimit;

			[Token(Token = "0x4000333")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private bool isLimited;

			[Token(Token = "0x1700005A")]
			public RotationLimit rotationLimit
			{
				[Token(Token = "0x6000438")]
				[Address(RVA = "0xF88EA4", Offset = "0xF88EA4", VA = "0xF88EA4")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000439")]
				[Address(RVA = "0xF88F94", Offset = "0xF88F94", VA = "0xF88F94")]
				set
				{
				}
			}

			[Token(Token = "0x600043A")]
			[Address(RVA = "0xF89018", Offset = "0xF89018", VA = "0xF89018")]
			public void Swing(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600043B")]
			[Address(RVA = "0xF89284", Offset = "0xF89284", VA = "0xF89284")]
			public static void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600043C")]
			[Address(RVA = "0xF89540", Offset = "0xF89540", VA = "0xF89540")]
			public void Swing2D(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600043D")]
			[Address(RVA = "0xF89734", Offset = "0xF89734", VA = "0xF89734")]
			public void SetToSolverPosition()
			{
			}

			[Token(Token = "0x600043E")]
			[Address(RVA = "0xF8975C", Offset = "0xF8975C", VA = "0xF8975C")]
			public Bone()
			{
			}

			[Token(Token = "0x600043F")]
			[Address(RVA = "0xF897C8", Offset = "0xF897C8", VA = "0xF897C8")]
			public Bone(Transform transform)
			{
			}

			[Token(Token = "0x6000440")]
			[Address(RVA = "0xF89848", Offset = "0xF89848", VA = "0xF89848")]
			public Bone(Transform transform, float weight)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200008C")]
		public class Node : Point
		{
			[Token(Token = "0x4000334")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x4000335")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float effectorPositionWeight;

			[Token(Token = "0x4000336")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public float effectorRotationWeight;

			[Token(Token = "0x4000337")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 offset;

			[Token(Token = "0x6000441")]
			[Address(RVA = "0xF898DC", Offset = "0xF898DC", VA = "0xF898DC")]
			public Node()
			{
			}

			[Token(Token = "0x6000442")]
			[Address(RVA = "0xF7FC40", Offset = "0xF7FC40", VA = "0xF7FC40")]
			public Node(Transform transform)
			{
			}

			[Token(Token = "0x6000443")]
			[Address(RVA = "0xF898E0", Offset = "0xF898E0", VA = "0xF898E0")]
			public Node(Transform transform, float weight)
			{
			}
		}

		[Token(Token = "0x200008D")]
		public delegate void UpdateDelegate();

		[Token(Token = "0x200008E")]
		public delegate void IterationDelegate(int i);

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[HideInInspector]
		public bool executedInEditor;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[HideInInspector]
		public Vector3 IKPosition;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		[Tooltip("The positional or the master weight of the solver.")]
		public float IKPositionWeight;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UpdateDelegate OnPreInitiate;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UpdateDelegate OnPostInitiate;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public UpdateDelegate OnPreUpdate;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public UpdateDelegate OnPostUpdate;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected bool firstInitiation;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[HideInInspector]
		protected Transform root;

		[Token(Token = "0x17000059")]
		public bool initiated
		{
			[Token(Token = "0x6000424")]
			[Address(RVA = "0xF8884C", Offset = "0xF8884C", VA = "0xF8884C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000425")]
			[Address(RVA = "0xF88854", Offset = "0xF88854", VA = "0xF88854")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0xF88794", Offset = "0xF88794", VA = "0xF88794")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x600041C")]
		public abstract bool IsValid(ref string message);

		[Token(Token = "0x600041D")]
		[Address(RVA = "0xF79450", Offset = "0xF79450", VA = "0xF79450")]
		public void Initiate(Transform root)
		{
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0xF79374", Offset = "0xF79374", VA = "0xF79374")]
		public void Update()
		{
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0xF88808", Offset = "0xF88808", VA = "0xF88808", Slot = "5")]
		public virtual Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0xF88814", Offset = "0xF88814", VA = "0xF88814")]
		public void SetIKPosition(Vector3 position)
		{
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0xF88820", Offset = "0xF88820", VA = "0xF88820")]
		public float GetIKPositionWeight()
		{
			return default(float);
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0xF88828", Offset = "0xF88828", VA = "0xF88828")]
		public void SetIKPositionWeight(float weight)
		{
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0xF88844", Offset = "0xF88844", VA = "0xF88844")]
		public Transform GetRoot()
		{
			return null;
		}

		[Token(Token = "0x6000426")]
		public abstract Point[] GetPoints();

		[Token(Token = "0x6000427")]
		public abstract Point GetPoint(Transform transform);

		[Token(Token = "0x6000428")]
		public abstract void FixTransforms();

		[Token(Token = "0x6000429")]
		public abstract void StoreDefaultLocalState();

		[Token(Token = "0x600042A")]
		protected abstract void OnInitiate();

		[Token(Token = "0x600042B")]
		protected abstract void OnUpdate();

		[Token(Token = "0x600042C")]
		[Address(RVA = "0xF88860", Offset = "0xF88860", VA = "0xF88860")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0xF88878", Offset = "0xF88878", VA = "0xF88878")]
		public static Transform ContainsDuplicateBone(Bone[] bones)
		{
			return null;
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0xF8899C", Offset = "0xF8899C", VA = "0xF8899C")]
		public static bool HierarchyIsValid(Bone[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0xF88A34", Offset = "0xF88A34", VA = "0xF88A34")]
		protected static float PreSolveBones(ref Bone[] bones)
		{
			return default(float);
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0xF88C28", Offset = "0xF88C28", VA = "0xF88C28")]
		protected IKSolver()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200008F")]
	public class IKSolverAim : IKSolverHeuristic
	{
		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform transform;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 axis;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public Vector3 poleAxis;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Vector3 polePosition;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[Range(0f, 1f)]
		public float poleWeight;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform poleTarget;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[Range(0f, 1f)]
		public float clampWeight;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[Range(0f, 2f)]
		public int clampSmoothing;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float step;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 clampedIKPosition;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private RotationLimit transformLimit;

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Transform lastTransform;

		[Token(Token = "0x1700005B")]
		public Vector3 transformAxis
		{
			[Token(Token = "0x600044D")]
			[Address(RVA = "0xF89B3C", Offset = "0xF89B3C", VA = "0xF89B3C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700005C")]
		public Vector3 transformPoleAxis
		{
			[Token(Token = "0x600044E")]
			[Address(RVA = "0xF89B6C", Offset = "0xF89B6C", VA = "0xF89B6C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700005D")]
		protected override int minBones
		{
			[Token(Token = "0x6000451")]
			[Address(RVA = "0xF8A7BC", Offset = "0xF8A7BC", VA = "0xF8A7BC", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700005E")]
		protected override Vector3 localDirection
		{
			[Token(Token = "0x6000455")]
			[Address(RVA = "0xF8ACFC", Offset = "0xF8ACFC", VA = "0xF8ACFC", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0xF89A04", Offset = "0xF89A04", VA = "0xF89A04")]
		public float GetAngle()
		{
			return default(float);
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0xF89B9C", Offset = "0xF89B9C", VA = "0xF89B9C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0xF89E28", Offset = "0xF89E28", VA = "0xF89E28", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0xF8A714", Offset = "0xF8A714", VA = "0xF8A714")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0xF8A3B0", Offset = "0xF8A3B0", VA = "0xF8A3B0")]
		private Vector3 GetClampedIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0xF8A7C4", Offset = "0xF8A7C4", VA = "0xF8A7C4")]
		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight)
		{
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0xF8AD5C", Offset = "0xF8AD5C", VA = "0xF8AD5C")]
		public IKSolverAim()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000090")]
	public class IKSolverArm : IKSolver
	{
		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Range(0f, 1f)]
		public float IKRotationWeight;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Quaternion IKRotation;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Point chest;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Point shoulder;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Point upperArm;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Point forearm;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Point hand;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public bool isLeft;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public IKSolverVR.Arm arm;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3[] positions;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Quaternion[] rotations;

		[Token(Token = "0x6000457")]
		[Address(RVA = "0xF8AE00", Offset = "0xF8AE00", VA = "0xF8AE00", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0xF8B1A4", Offset = "0xF8B1A4", VA = "0xF8B1A4")]
		public bool SetChain(Transform chest, Transform shoulder, Transform upperArm, Transform forearm, Transform hand, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0xF8B258", Offset = "0xF8B258", VA = "0xF8B258", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0xF8B3D8", Offset = "0xF8B3D8", VA = "0xF8B3D8", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0xF8B538", Offset = "0xF8B538", VA = "0xF8B538", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0xF8B588", Offset = "0xF8B588", VA = "0xF8B588", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0xF8B5E8", Offset = "0xF8B5E8", VA = "0xF8B5E8", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0xF8B948", Offset = "0xF8B948", VA = "0xF8B948", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0xF8B968", Offset = "0xF8B968", VA = "0xF8B968")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0xF8B640", Offset = "0xF8B640", VA = "0xF8B640")]
		private void Read()
		{
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0xF8B9D0", Offset = "0xF8B9D0", VA = "0xF8B9D0")]
		private void Write()
		{
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0xF8BB48", Offset = "0xF8BB48", VA = "0xF8BB48")]
		public IKSolverArm()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000091")]
	public class IKSolverCCD : IKSolverHeuristic
	{
		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x6000463")]
		[Address(RVA = "0xF8BD40", Offset = "0xF8BD40", VA = "0xF8BD40")]
		public void FadeOutBoneWeights()
		{
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0xF8BDB0", Offset = "0xF8BDB0", VA = "0xF8BDB0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0xF8C2B0", Offset = "0xF8C2B0", VA = "0xF8C2B0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0xF8C990", Offset = "0xF8C990", VA = "0xF8C990")]
		protected void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0xF8D030", Offset = "0xF8D030", VA = "0xF8D030")]
		public IKSolverCCD()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000092")]
	public class IKSolverFABRIK : IKSolverHeuristic
	{
		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool[] limitedBones;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3[] solverLocalPositions;

		[Token(Token = "0x1700005F")]
		protected override bool boneLengthCanBeZero
		{
			[Token(Token = "0x600046D")]
			[Address(RVA = "0xF8E084", Offset = "0xF8E084", VA = "0xF8E084", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0xF8D0A8", Offset = "0xF8D0A8", VA = "0xF8D0A8")]
		public void SolveForward(Vector3 position)
		{
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0xF8D684", Offset = "0xF8D684", VA = "0xF8D684")]
		public void SolveBackward(Vector3 position)
		{
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0xF8D7B0", Offset = "0xF8D7B0", VA = "0xF8D7B0", Slot = "5")]
		public override Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0xF8D838", Offset = "0xF8D838", VA = "0xF8D838", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0xF8DD4C", Offset = "0xF8DD4C", VA = "0xF8DD4C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0xF8E08C", Offset = "0xF8E08C", VA = "0xF8E08C")]
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0xF8D17C", Offset = "0xF8D17C", VA = "0xF8D17C")]
		private void OnPreSolve()
		{
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0xF8D768", Offset = "0xF8D768", VA = "0xF8D768")]
		private void OnPostSolve()
		{
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0xF8E03C", Offset = "0xF8E03C", VA = "0xF8E03C")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0xF8D518", Offset = "0xF8D518", VA = "0xF8D518")]
		private void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0xF8E740", Offset = "0xF8E740", VA = "0xF8E740")]
		private void SolverMove(int index, Vector3 offset)
		{
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0xF8E7A8", Offset = "0xF8E7A8", VA = "0xF8E7A8")]
		private void SolverRotate(int index, Quaternion rotation, bool recursive)
		{
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0xF8E878", Offset = "0xF8E878", VA = "0xF8E878")]
		private void SolverRotateChildren(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0xF8E940", Offset = "0xF8E940", VA = "0xF8E940")]
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0xF8DAC4", Offset = "0xF8DAC4", VA = "0xF8DAC4")]
		private Quaternion GetParentSolverRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0xF8DC08", Offset = "0xF8DC08", VA = "0xF8DC08")]
		private Vector3 GetParentSolverPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0xF8EA30", Offset = "0xF8EA30", VA = "0xF8EA30")]
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0xF8E32C", Offset = "0xF8E32C", VA = "0xF8E32C")]
		private void LimitForward(int rotateBone, int limitBone)
		{
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0xF8D758", Offset = "0xF8D758", VA = "0xF8D758")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0xF8F0A8", Offset = "0xF8F0A8", VA = "0xF8F0A8")]
		private void BackwardReachUnlimited(Vector3 position)
		{
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0xF8EBF4", Offset = "0xF8EBF4", VA = "0xF8EBF4")]
		private void BackwardReachLimited(Vector3 position)
		{
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0xF8E1A8", Offset = "0xF8E1A8", VA = "0xF8E1A8")]
		private void MapToSolverPositions()
		{
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0xF8E27C", Offset = "0xF8E27C", VA = "0xF8E27C")]
		private void MapToSolverPositionsLimited()
		{
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0xF8F160", Offset = "0xF8F160", VA = "0xF8F160")]
		public IKSolverFABRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000093")]
	public class IKSolverFABRIKRoot : IKSolver
	{
		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int iterations;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Range(0f, 1f)]
		public float rootPin;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FABRIKChain[] chains;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool zeroWeightApplied;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] isRoot;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 rootDefaultPosition;

		[Token(Token = "0x6000481")]
		[Address(RVA = "0xF8F1F8", Offset = "0xF8F1F8", VA = "0xF8F1F8", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0xF8F8BC", Offset = "0xF8F8BC", VA = "0xF8F8BC", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0xF8F948", Offset = "0xF8F948", VA = "0xF8F948", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0xF8F9DC", Offset = "0xF8F9DC", VA = "0xF8F9DC", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0xF8FAD4", Offset = "0xF8FAD4", VA = "0xF8FAD4")]
		private bool IsRoot(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0xF8FB64", Offset = "0xF8FB64", VA = "0xF8FB64", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0xF8FF64", Offset = "0xF8FF64", VA = "0xF8FF64", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0xF9015C", Offset = "0xF9015C", VA = "0xF9015C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0xF90004", Offset = "0xF90004", VA = "0xF90004")]
		private void AddPointsToArray(ref Point[] array, FABRIKChain chain)
		{
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0xF8FD3C", Offset = "0xF8FD3C", VA = "0xF8FD3C")]
		private Vector3 GetCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0xF901E0", Offset = "0xF901E0", VA = "0xF901E0")]
		public IKSolverFABRIKRoot()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000094")]
	public class IKSolverFullBody : IKSolver
	{
		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Range(0f, 10f)]
		public int iterations;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FBIKChain[] chain;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public IKEffector[] effectors;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public IKMappingSpine spineMapping;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public IKMappingBone[] boneMappings;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public IKMappingLimb[] limbMappings;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool FABRIKPass;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public UpdateDelegate OnPreRead;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public UpdateDelegate OnPreSolve;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public IterationDelegate OnPostIteration;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public UpdateDelegate OnPreBend;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public UpdateDelegate OnPostSolve;

		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public UpdateDelegate OnStoreDefaultLocalState;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public UpdateDelegate OnFixTransforms;

		[Token(Token = "0x600048C")]
		[Address(RVA = "0xF9024C", Offset = "0xF9024C", VA = "0xF9024C")]
		public IKEffector GetEffector(Transform t)
		{
			return null;
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0xF90328", Offset = "0xF90328", VA = "0xF90328")]
		public FBIKChain GetChain(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0xF90370", Offset = "0xF90370", VA = "0xF90370")]
		public int GetChainIndex(Transform transform)
		{
			return default(int);
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0xF90484", Offset = "0xF90484", VA = "0xF90484")]
		public Node GetNode(int chainIndex, int nodeIndex)
		{
			return null;
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0xF904D4", Offset = "0xF904D4", VA = "0xF904D4")]
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex)
		{
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0xF90548", Offset = "0xF90548", VA = "0xF90548", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0xF906E8", Offset = "0xF906E8", VA = "0xF906E8", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0xF90844", Offset = "0xF90844", VA = "0xF90844", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0xF90A48", Offset = "0xF90A48", VA = "0xF90A48", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0xF90B1C", Offset = "0xF90B1C", VA = "0xF90B1C", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0xF90C04", Offset = "0xF90C04", VA = "0xF90C04", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0xF90D64", Offset = "0xF90D64", VA = "0xF90D64", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0xF90F00", Offset = "0xF90F00", VA = "0xF90F00", Slot = "12")]
		protected virtual void ReadPose()
		{
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0xF91138", Offset = "0xF91138", VA = "0xF91138", Slot = "13")]
		protected virtual void Solve()
		{
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0xF91418", Offset = "0xF91418", VA = "0xF91418", Slot = "14")]
		protected virtual void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0xF91450", Offset = "0xF91450", VA = "0xF91450", Slot = "15")]
		protected virtual void WritePose()
		{
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0xF91534", Offset = "0xF91534", VA = "0xF91534")]
		public IKSolverFullBody()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000095")]
	public enum FullBodyBipedEffector
	{
		[Token(Token = "0x400036A")]
		Body,
		[Token(Token = "0x400036B")]
		LeftShoulder,
		[Token(Token = "0x400036C")]
		RightShoulder,
		[Token(Token = "0x400036D")]
		LeftThigh,
		[Token(Token = "0x400036E")]
		RightThigh,
		[Token(Token = "0x400036F")]
		LeftHand,
		[Token(Token = "0x4000370")]
		RightHand,
		[Token(Token = "0x4000371")]
		LeftFoot,
		[Token(Token = "0x4000372")]
		RightFoot
	}
	[Serializable]
	[Token(Token = "0x2000096")]
	public enum FullBodyBipedChain
	{
		[Token(Token = "0x4000374")]
		LeftArm,
		[Token(Token = "0x4000375")]
		RightArm,
		[Token(Token = "0x4000376")]
		LeftLeg,
		[Token(Token = "0x4000377")]
		RightLeg
	}
	[Serializable]
	[Token(Token = "0x2000097")]
	public class IKSolverFullBodyBiped : IKSolverFullBody
	{
		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Transform rootNode;

		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[Range(0f, 1f)]
		public float spineStiffness;

		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[Range(-1f, 1f)]
		public float pullBodyVertical;

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[Range(-1f, 1f)]
		public float pullBodyHorizontal;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Vector3 offset;

		[Token(Token = "0x17000060")]
		public IKEffector bodyEffector
		{
			[Token(Token = "0x600049D")]
			[Address(RVA = "0xF91680", Offset = "0xF91680", VA = "0xF91680")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000061")]
		public IKEffector leftShoulderEffector
		{
			[Token(Token = "0x600049E")]
			[Address(RVA = "0xF917C0", Offset = "0xF917C0", VA = "0xF917C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000062")]
		public IKEffector rightShoulderEffector
		{
			[Token(Token = "0x600049F")]
			[Address(RVA = "0xF917C8", Offset = "0xF917C8", VA = "0xF917C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000063")]
		public IKEffector leftThighEffector
		{
			[Token(Token = "0x60004A0")]
			[Address(RVA = "0xF917D0", Offset = "0xF917D0", VA = "0xF917D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000064")]
		public IKEffector rightThighEffector
		{
			[Token(Token = "0x60004A1")]
			[Address(RVA = "0xF917D8", Offset = "0xF917D8", VA = "0xF917D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000065")]
		public IKEffector leftHandEffector
		{
			[Token(Token = "0x60004A2")]
			[Address(RVA = "0xF917E0", Offset = "0xF917E0", VA = "0xF917E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000066")]
		public IKEffector rightHandEffector
		{
			[Token(Token = "0x60004A3")]
			[Address(RVA = "0xF917E8", Offset = "0xF917E8", VA = "0xF917E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000067")]
		public IKEffector leftFootEffector
		{
			[Token(Token = "0x60004A4")]
			[Address(RVA = "0xF917F0", Offset = "0xF917F0", VA = "0xF917F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000068")]
		public IKEffector rightFootEffector
		{
			[Token(Token = "0x60004A5")]
			[Address(RVA = "0xF917F8", Offset = "0xF917F8", VA = "0xF917F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000069")]
		public FBIKChain leftArmChain
		{
			[Token(Token = "0x60004A6")]
			[Address(RVA = "0xF91800", Offset = "0xF91800", VA = "0xF91800")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006A")]
		public FBIKChain rightArmChain
		{
			[Token(Token = "0x60004A7")]
			[Address(RVA = "0xF9182C", Offset = "0xF9182C", VA = "0xF9182C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006B")]
		public FBIKChain leftLegChain
		{
			[Token(Token = "0x60004A8")]
			[Address(RVA = "0xF91858", Offset = "0xF91858", VA = "0xF91858")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006C")]
		public FBIKChain rightLegChain
		{
			[Token(Token = "0x60004A9")]
			[Address(RVA = "0xF91884", Offset = "0xF91884", VA = "0xF91884")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006D")]
		public IKMappingLimb leftArmMapping
		{
			[Token(Token = "0x60004AA")]
			[Address(RVA = "0xF918B0", Offset = "0xF918B0", VA = "0xF918B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006E")]
		public IKMappingLimb rightArmMapping
		{
			[Token(Token = "0x60004AB")]
			[Address(RVA = "0xF918D8", Offset = "0xF918D8", VA = "0xF918D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006F")]
		public IKMappingLimb leftLegMapping
		{
			[Token(Token = "0x60004AC")]
			[Address(RVA = "0xF91904", Offset = "0xF91904", VA = "0xF91904")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000070")]
		public IKMappingLimb rightLegMapping
		{
			[Token(Token = "0x60004AD")]
			[Address(RVA = "0xF91930", Offset = "0xF91930", VA = "0xF91930")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000071")]
		public IKMappingBone headMapping
		{
			[Token(Token = "0x60004AE")]
			[Address(RVA = "0xF9195C", Offset = "0xF9195C", VA = "0xF9195C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000072")]
		public Vector3 pullBodyOffset
		{
			[Token(Token = "0x60004BE")]
			[Address(RVA = "0xF93B98", Offset = "0xF93B98", VA = "0xF93B98")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60004BF")]
			[Address(RVA = "0xF93BA4", Offset = "0xF93BA4", VA = "0xF93BA4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0xF91984", Offset = "0xF91984", VA = "0xF91984")]
		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f)
		{
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0xF91A84", Offset = "0xF91A84", VA = "0xF91A84")]
		public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0xF919D4", Offset = "0xF919D4", VA = "0xF919D4")]
		public FBIKChain GetChain(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0xF91AFC", Offset = "0xF91AFC", VA = "0xF91AFC")]
		public FBIKChain GetChain(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0xF91688", Offset = "0xF91688", VA = "0xF91688")]
		public IKEffector GetEffector(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0xF91BC4", Offset = "0xF91BC4", VA = "0xF91BC4")]
		public IKEffector GetEndEffector(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0xF91C74", Offset = "0xF91C74", VA = "0xF91C74")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0xF91D20", Offset = "0xF91D20", VA = "0xF91D20")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0xF91DCC", Offset = "0xF91DCC", VA = "0xF91DCC")]
		public IKMappingSpine GetSpineMapping()
		{
			return null;
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0xF91DD4", Offset = "0xF91DD4", VA = "0xF91DD4")]
		public IKMappingBone GetHeadMapping()
		{
			return null;
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0xF91DFC", Offset = "0xF91DFC", VA = "0xF91DFC")]
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb)
		{
			return null;
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0xF91EBC", Offset = "0xF91EBC", VA = "0xF91EBC", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0xF92050", Offset = "0xF92050", VA = "0xF92050")]
		public void SetToReferences(BipedReferences references, [Optional] Transform rootNode)
		{
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0xF93490", Offset = "0xF93490", VA = "0xF93490")]
		public static Transform DetectRootNodeBone(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0xF93A40", Offset = "0xF93A40", VA = "0xF93A40")]
		public void SetLimbOrientations(BipedLimbOrientations o)
		{
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0xF93A9C", Offset = "0xF93A9C", VA = "0xF93A9C")]
		private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation)
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0xF938E0", Offset = "0xF938E0", VA = "0xF938E0")]
		private static Transform GetLeftClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0xF93990", Offset = "0xF93990", VA = "0xF93990")]
		private static Transform GetRightClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0xF93BB0", Offset = "0xF93BB0", VA = "0xF93BB0")]
		private static bool Contains(Transform[] array, Transform transform)
		{
			return default(bool);
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0xF93C74", Offset = "0xF93C74", VA = "0xF93C74", Slot = "12")]
		protected override void ReadPose()
		{
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0xF93D44", Offset = "0xF93D44", VA = "0xF93D44")]
		private void PullBody()
		{
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0xF93E60", Offset = "0xF93E60", VA = "0xF93E60")]
		private Vector3 GetBodyOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0xF93FF0", Offset = "0xF93FF0", VA = "0xF93FF0")]
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0xF94168", Offset = "0xF94168", VA = "0xF94168", Slot = "14")]
		protected override void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0xF943C8", Offset = "0xF943C8", VA = "0xF943C8", Slot = "15")]
		protected override void WritePose()
		{
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0xF94440", Offset = "0xF94440", VA = "0xF94440")]
		public IKSolverFullBodyBiped()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000098")]
	public class IKSolverHeuristic : IKSolver
	{
		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float tolerance;

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int maxIterations;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool useRotationLimits;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		public bool XY;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Bone[] bones;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Vector3 lastLocalDirection;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		protected float chainLength;

		[Token(Token = "0x17000073")]
		protected virtual int minBones
		{
			[Token(Token = "0x60004D2")]
			[Address(RVA = "0xF94CE0", Offset = "0xF94CE0", VA = "0xF94CE0", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000074")]
		protected virtual bool boneLengthCanBeZero
		{
			[Token(Token = "0x60004D3")]
			[Address(RVA = "0xF94CE8", Offset = "0xF94CE8", VA = "0xF94CE8", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000075")]
		protected virtual bool allowCommonParent
		{
			[Token(Token = "0x60004D4")]
			[Address(RVA = "0xF94CF0", Offset = "0xF94CF0", VA = "0xF94CF0", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000076")]
		protected virtual Vector3 localDirection
		{
			[Token(Token = "0x60004D8")]
			[Address(RVA = "0xF94D00", Offset = "0xF94D00", VA = "0xF94D00", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000077")]
		protected float positionOffset
		{
			[Token(Token = "0x60004D9")]
			[Address(RVA = "0xF8C948", Offset = "0xF8C948", VA = "0xF8C948")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0xF9444C", Offset = "0xF9444C", VA = "0xF9444C")]
		public bool SetChain(Transform[] hierarchy, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0xF945FC", Offset = "0xF945FC", VA = "0xF945FC")]
		public void AddBone(Transform bone)
		{
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0xF94748", Offset = "0xF94748", VA = "0xF94748", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0xF947A8", Offset = "0xF947A8", VA = "0xF947A8", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0xF9481C", Offset = "0xF9481C", VA = "0xF9481C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0xF94BFC", Offset = "0xF94BFC", VA = "0xF94BFC", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0xF94C04", Offset = "0xF94C04", VA = "0xF94C04", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0xF94CF8", Offset = "0xF94CF8", VA = "0xF94CF8", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0xF94CFC", Offset = "0xF94CFC", VA = "0xF94CFC", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0xF8BE1C", Offset = "0xF8BE1C", VA = "0xF8BE1C")]
		protected void InitiateBones()
		{
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0xF8C590", Offset = "0xF8C590", VA = "0xF8C590")]
		protected Vector3 GetSingularityOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0xF94DBC", Offset = "0xF94DBC", VA = "0xF94DBC")]
		private bool SingularityDetected()
		{
			return default(bool);
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0xF8D034", Offset = "0xF8D034", VA = "0xF8D034")]
		public IKSolverHeuristic()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000099")]
	public class IKSolverLeg : IKSolver
	{
		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Range(0f, 1f)]
		public float IKRotationWeight;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Quaternion IKRotation;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Point pelvis;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Point thigh;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Point calf;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Point foot;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Point toe;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public IKSolverVR.Leg leg;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 heelOffset;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3[] positions;

		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Quaternion[] rotations;

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0xF95050", Offset = "0xF95050", VA = "0xF95050", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0xF953F4", Offset = "0xF953F4", VA = "0xF953F4")]
		public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0xF954A8", Offset = "0xF954A8", VA = "0xF954A8", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0xF95628", Offset = "0xF95628", VA = "0xF95628", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0xF95788", Offset = "0xF95788", VA = "0xF95788", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0xF957D8", Offset = "0xF957D8", VA = "0xF957D8", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0xF95838", Offset = "0xF95838", VA = "0xF95838", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0xF95B98", Offset = "0xF95B98", VA = "0xF95B98", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0xF95BB8", Offset = "0xF95BB8", VA = "0xF95BB8")]
		private void Solve()
		{
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0xF95890", Offset = "0xF95890", VA = "0xF95890")]
		private void Read()
		{
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0xF95C48", Offset = "0xF95C48", VA = "0xF95C48")]
		private void Write()
		{
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0xF95DC0", Offset = "0xF95DC0", VA = "0xF95DC0")]
		public IKSolverLeg()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200009A")]
	public class IKSolverLimb : IKSolverTrigonometric
	{
		[Serializable]
		[Token(Token = "0x200009B")]
		public enum BendModifier
		{
			[Token(Token = "0x40003A2")]
			Animation,
			[Token(Token = "0x40003A3")]
			Target,
			[Token(Token = "0x40003A4")]
			Parent,
			[Token(Token = "0x40003A5")]
			Arm,
			[Token(Token = "0x40003A6")]
			Goal
		}

		[Serializable]
		[Token(Token = "0x200009C")]
		public struct AxisDirection
		{
			[Token(Token = "0x40003A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 direction;

			[Token(Token = "0x40003A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 axis;

			[Token(Token = "0x40003A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float dot;

			[Token(Token = "0x60004F3")]
			[Address(RVA = "0xF973F8", Offset = "0xF973F8", VA = "0xF973F8")]
			public AxisDirection(Vector3 direction, Vector3 axis)
			{
			}
		}

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public AvatarIKGoal goal;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public BendModifier bendModifier;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[Range(0f, 1f)]
		public float maintainRotationWeight;

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[Range(0f, 1f)]
		public float bendModifierWeight;

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform bendGoal;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool maintainBendFor1Frame;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC1")]
		private bool maintainRotationFor1Frame;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion defaultRootRotation;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Quaternion parentDefaultRotation;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Quaternion bone3RotationBeforeSolve;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private Quaternion maintainRotation;

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private Quaternion bone3DefaultRotation;

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private Vector3 _bendNormal;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 animationNormal;

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private AxisDirection[] axisDirectionsLeft;

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private AxisDirection[] axisDirectionsRight;

		[Token(Token = "0x17000078")]
		private AxisDirection[] axisDirections
		{
			[Token(Token = "0x60004F0")]
			[Address(RVA = "0xF973DC", Offset = "0xF973DC", VA = "0xF973DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0xF95FB8", Offset = "0xF95FB8", VA = "0xF95FB8")]
		public void MaintainRotation()
		{
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0xF95FFC", Offset = "0xF95FFC", VA = "0xF95FFC")]
		public void MaintainBend()
		{
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0xF96068", Offset = "0xF96068", VA = "0xF96068", Slot = "12")]
		protected override void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0xF965B0", Offset = "0xF965B0", VA = "0xF965B0", Slot = "13")]
		protected override void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0xF970CC", Offset = "0xF970CC", VA = "0xF970CC", Slot = "14")]
		protected override void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0xF97174", Offset = "0xF97174", VA = "0xF97174")]
		public IKSolverLimb()
		{
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0xF97344", Offset = "0xF97344", VA = "0xF97344")]
		public IKSolverLimb(AvatarIKGoal goal)
		{
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0xF963C4", Offset = "0xF963C4", VA = "0xF963C4")]
		private void StoreAxisDirections(ref AxisDirection[] axisDirections)
		{
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0xF9666C", Offset = "0xF9666C", VA = "0xF9666C")]
		private Vector3 GetModifiedBendNormal()
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x200009D")]
	public class IKSolverLookAt : IKSolver
	{
		[Serializable]
		[Token(Token = "0x200009E")]
		public class LookAtBone : Bone
		{
			[Token(Token = "0x40003BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			public Vector3 baseForwardOffsetEuler;

			[Token(Token = "0x1700007F")]
			public Vector3 forward
			{
				[Token(Token = "0x6000513")]
				[Address(RVA = "0xF9929C", Offset = "0xF9929C", VA = "0xF9929C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x600050F")]
			[Address(RVA = "0xF9994C", Offset = "0xF9994C", VA = "0xF9994C")]
			public LookAtBone()
			{
			}

			[Token(Token = "0x6000510")]
			[Address(RVA = "0xF983B8", Offset = "0xF983B8", VA = "0xF983B8")]
			public LookAtBone(Transform transform)
			{
			}

			[Token(Token = "0x6000511")]
			[Address(RVA = "0xF986AC", Offset = "0xF986AC", VA = "0xF986AC")]
			public void Initiate(Transform root)
			{
			}

			[Token(Token = "0x6000512")]
			[Address(RVA = "0xF995E4", Offset = "0xF995E4", VA = "0xF995E4")]
			public void LookAt(Vector3 direction, float weight)
			{
			}
		}

		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public LookAtBone[] spine;

		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public LookAtBone head;

		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public LookAtBone[] eyes;

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[Range(0f, 1f)]
		public float bodyWeight;

		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[Range(0f, 1f)]
		public float headWeight;

		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Range(0f, 1f)]
		public float eyesWeight;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[Range(0f, 1f)]
		public float clampWeight;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[Range(0f, 1f)]
		public float clampWeightHead;

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[Range(0f, 1f)]
		public float clampWeightEyes;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[Range(0f, 2f)]
		public int clampSmoothing;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public AnimationCurve spineWeightCurve;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 spineTargetOffset;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		protected Vector3[] spineForwards;

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		protected Vector3[] headForwards;

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		protected Vector3[] eyeForward;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private bool isDirty;

		[Token(Token = "0x17000079")]
		protected bool spineIsValid
		{
			[Token(Token = "0x6000503")]
			[Address(RVA = "0xF97B3C", Offset = "0xF97B3C", VA = "0xF97B3C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700007A")]
		protected bool spineIsEmpty
		{
			[Token(Token = "0x6000504")]
			[Address(RVA = "0xF97CE4", Offset = "0xF97CE4", VA = "0xF97CE4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700007B")]
		protected bool headIsValid
		{
			[Token(Token = "0x6000506")]
			[Address(RVA = "0xF97C08", Offset = "0xF97C08", VA = "0xF97C08")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700007C")]
		protected bool headIsEmpty
		{
			[Token(Token = "0x6000507")]
			[Address(RVA = "0xF97D08", Offset = "0xF97D08", VA = "0xF97D08")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700007D")]
		protected bool eyesIsValid
		{
			[Token(Token = "0x6000509")]
			[Address(RVA = "0xF97C18", Offset = "0xF97C18", VA = "0xF97C18")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700007E")]
		protected bool eyesIsEmpty
		{
			[Token(Token = "0x600050A")]
			[Address(RVA = "0xF97D74", Offset = "0xF97D74", VA = "0xF97D74")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0xF97594", Offset = "0xF97594", VA = "0xF97594")]
		public void SetLookAtWeight(float weight)
		{
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0xF975B0", Offset = "0xF975B0", VA = "0xF975B0")]
		public void SetLookAtWeight(float weight, float bodyWeight)
		{
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0xF975DC", Offset = "0xF975DC", VA = "0xF975DC")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
		{
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0xF97614", Offset = "0xF97614", VA = "0xF97614")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
		{
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0xF9765C", Offset = "0xF9765C", VA = "0xF9765C")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
		{
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0xF976B4", Offset = "0xF976B4", VA = "0xF976B4")]
		public void SetLookAtWeight(float weight, float bodyWeight = 0f, float headWeight = 1f, float eyesWeight = 0.5f, float clampWeight = 0.5f, float clampWeightHead = 0.5f, float clampWeightEyes = 0.3f)
		{
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0xF97724", Offset = "0xF97724", VA = "0xF97724", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0xF9783C", Offset = "0xF9783C", VA = "0xF9783C")]
		public void SetDirty()
		{
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0xF97848", Offset = "0xF97848", VA = "0xF97848", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0xF97978", Offset = "0xF97978", VA = "0xF97978", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0xF97D98", Offset = "0xF97D98", VA = "0xF97D98", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0xF97FEC", Offset = "0xF97FEC", VA = "0xF97FEC", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0xF9814C", Offset = "0xF9814C", VA = "0xF9814C")]
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0xF983E8", Offset = "0xF983E8", VA = "0xF983E8", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0xF98798", Offset = "0xF98798", VA = "0xF98798", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0xF9885C", Offset = "0xF9885C", VA = "0xF9885C")]
		protected void SolveSpine()
		{
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0xF98A78", Offset = "0xF98A78", VA = "0xF98A78")]
		protected void SolveHead()
		{
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0xF98DC0", Offset = "0xF98DC0", VA = "0xF98DC0")]
		protected void SolveEyes()
		{
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0xF992CC", Offset = "0xF992CC", VA = "0xF992CC")]
		protected Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp)
		{
			return null;
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0xF98214", Offset = "0xF98214", VA = "0xF98214")]
		protected void SetBones(Transform[] array, ref LookAtBone[] bones)
		{
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0xF996EC", Offset = "0xF996EC", VA = "0xF996EC")]
		public IKSolverLookAt()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200009F")]
	public class IKSolverTrigonometric : IKSolver
	{
		[Serializable]
		[Token(Token = "0x20000A0")]
		public class TrigonometricBone : Bone
		{
			[Token(Token = "0x40003C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private Quaternion targetToLocalSpace;

			[Token(Token = "0x40003C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Vector3 defaultLocalBendNormal;

			[Token(Token = "0x600052B")]
			[Address(RVA = "0xF9AC74", Offset = "0xF9AC74", VA = "0xF9AC74")]
			public void Initiate(Vector3 childPosition, Vector3 bendNormal)
			{
			}

			[Token(Token = "0x600052C")]
			[Address(RVA = "0xF9B51C", Offset = "0xF9B51C", VA = "0xF9B51C")]
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x600052D")]
			[Address(RVA = "0xF96038", Offset = "0xF96038", VA = "0xF96038")]
			public Vector3 GetBendNormalFromCurrentRotation()
			{
				return default(Vector3);
			}

			[Token(Token = "0x600052E")]
			[Address(RVA = "0xF9B5B8", Offset = "0xF9B5B8", VA = "0xF9B5B8")]
			public TrigonometricBone()
			{
			}
		}

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Range(0f, 1f)]
		public float IKRotationWeight;

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Quaternion IKRotation;

		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public Vector3 bendNormal;

		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public TrigonometricBone bone1;

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public TrigonometricBone bone2;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public TrigonometricBone bone3;

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		protected Vector3 weightIKPosition;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		protected bool directHierarchy;

		[Token(Token = "0x6000514")]
		[Address(RVA = "0xF99954", Offset = "0xF99954", VA = "0xF99954")]
		public void SetBendGoalPosition(Vector3 goalPosition, float weight)
		{
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0xF99AE8", Offset = "0xF99AE8", VA = "0xF99AE8")]
		public void SetBendPlaneToCurrent()
		{
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0xF99C68", Offset = "0xF99C68", VA = "0xF99C68")]
		public void SetIKRotation(Quaternion rotation)
		{
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0xF99C74", Offset = "0xF99C74", VA = "0xF99C74")]
		public void SetIKRotationWeight(float weight)
		{
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0xF99C90", Offset = "0xF99C90", VA = "0xF99C90")]
		public Quaternion GetIKRotation()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0xF99C9C", Offset = "0xF99C9C", VA = "0xF99C9C")]
		public float GetIKRotationWeight()
		{
			return default(float);
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0xF99CA4", Offset = "0xF99CA4", VA = "0xF99CA4", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0xF99DB4", Offset = "0xF99DB4", VA = "0xF99DB4", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0xF99EAC", Offset = "0xF99EAC", VA = "0xF99EAC", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0xF99EEC", Offset = "0xF99EEC", VA = "0xF99EEC", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0xF99F3C", Offset = "0xF99F3C", VA = "0xF99F3C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0xF9A310", Offset = "0xF9A310", VA = "0xF9A310")]
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0xF9A38C", Offset = "0xF9A38C", VA = "0xF9A38C")]
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0xF9A880", Offset = "0xF9A880", VA = "0xF9A880")]
		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0xF9A9D8", Offset = "0xF9A9D8", VA = "0xF9A9D8", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0xF9AB84", Offset = "0xF9AB84", VA = "0xF9AB84")]
		private bool IsDirectHierarchy()
		{
			return default(bool);
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0xF9AB04", Offset = "0xF9AB04", VA = "0xF9AB04")]
		public void InitiateBones()
		{
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0xF9AD64", Offset = "0xF9AD64", VA = "0xF9AD64", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0xF9B5AC", Offset = "0xF9B5AC", VA = "0xF9B5AC", Slot = "12")]
		protected virtual void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0xF9B5B0", Offset = "0xF9B5B0", VA = "0xF9B5B0", Slot = "13")]
		protected virtual void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0xF9B5B4", Offset = "0xF9B5B4", VA = "0xF9B5B4", Slot = "14")]
		protected virtual void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0xF9B35C", Offset = "0xF9B35C", VA = "0xF9B35C")]
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0xF971F8", Offset = "0xF971F8", VA = "0xF971F8")]
		public IKSolverTrigonometric()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000A1")]
	public class IKSolverVR : IKSolver
	{
		[Serializable]
		[Token(Token = "0x20000A2")]
		public class Arm : BodyPart
		{
			[Serializable]
			[Token(Token = "0x20000A3")]
			public enum ShoulderRotationMode
			{
				[Token(Token = "0x400040D")]
				YawPitch,
				[Token(Token = "0x400040E")]
				FromTo
			}

			[Token(Token = "0x40003EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[Tooltip("The hand target. This should not be the hand controller itself, but a child GameObject parented to it so you could adjust its position/rotation to match the orientation of the hand bone. The best practice for setup would be to move the hand controller to the avatar's hand as it it was held by the avatar, duplicate the avatar's hand bone and parent it to the hand controller. Then assign the duplicate to this slot.")]
			[LargeHeader("Hand")]
			public Transform target;

			[Token(Token = "0x40003F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("Positional weight of the hand target. Note that if you have nulled the target, the hand will still be pulled to the last position of the target until you set this value to 0.")]
			[Range(0f, 1f)]
			public float positionWeight;

			[Token(Token = "0x40003F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[Tooltip("Rotational weight of the hand target. Note that if you have nulled the target, the hand will still be rotated to the last rotation of the target until you set this value to 0.")]
			[Range(0f, 1f)]
			public float rotationWeight;

			[Token(Token = "0x40003F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Range(0f, 1f)]
			[Tooltip("The weight of shoulder rotation")]
			[LargeHeader("Shoulder")]
			public float shoulderRotationWeight;

			[Token(Token = "0x40003F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[ShowIf("shoulderRotationWeight", 0f, float.PositiveInfinity, false, ShowIfMode.Hidden)]
			[Tooltip("Different techniques for shoulder bone rotation.")]
			public ShoulderRotationMode shoulderRotationMode;

			[Token(Token = "0x40003F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[Tooltip("The weight of twisting the shoulders backwards when arms are lifted up.")]
			[ShowRangeIf(0f, 1f, "shoulderRotationWeight", 0f, float.PositiveInfinity, false, ShowIfMode.Hidden)]
			public float shoulderTwistWeight;

			[Token(Token = "0x40003F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[ShowIf("shoulderRotationWeight", 0f, float.PositiveInfinity, false, ShowIfMode.Hidden)]
			[Tooltip("Tweak this value to adjust shoulder rotation around the yaw (up) axis.")]
			public float shoulderYawOffset;

			[Token(Token = "0x40003F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[Tooltip("Tweak this value to adjust shoulder rotation around the pitch (forward) axis.")]
			[ShowIf("shoulderRotationWeight", 0f, float.PositiveInfinity, false, ShowIfMode.Hidden)]
			public float shoulderPitchOffset;

			[Token(Token = "0x40003F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[LargeHeader("Bending")]
			[Tooltip("The elbow will be bent towards this Transform if 'Bend Goal Weight' > 0.")]
			public Transform bendGoal;

			[Token(Token = "0x40003F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[Range(0f, 1f)]
			[Tooltip("If greater than 0, will bend the elbow towards the 'Bend Goal' Transform.")]
			public float bendGoalWeight;

			[Token(Token = "0x40003F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[Tooltip("Angular offset of the elbow bending direction.")]
			[Range(-180f, 180f)]
			public float swivelOffset;

			[Token(Token = "0x40003FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[Tooltip("Local axis of the hand bone that points from the wrist towards the palm. Used for defining hand bone orientation. If you have copied VRIK component from another avatar that has different bone orientations, right-click on VRIK header and select 'Guess Hand Orientations' from the context menu.")]
			public Vector3 wristToPalmAxis;

			[Token(Token = "0x40003FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[Tooltip("Local axis of the hand bone that points from the palm towards the thumb. Used for defining hand bone orientation. If you have copied VRIK component from another avatar that has different bone orientations, right-click on VRIK header and select 'Guess Hand Orientations' from the context menu.")]
			public Vector3 palmToThumbAxis;

			[Token(Token = "0x40003FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[LargeHeader("Stretching")]
			[Tooltip("Use this to make the arm shorter/longer. Works by displacement of hand and forearm localPosition.")]
			[Range(0.01f, 2f)]
			public float armLengthMlp;

			[Token(Token = "0x40003FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[Tooltip("'Time' represents (target distance / arm length) and 'value' represents the amount of stretching. So value at time 1 represents stretching amount at the point where distance to the target is equal to arm length. Value at time 2 represents stretching amount at the point where distance to the target is double the arm length. Linear stretching would be achieved with a linear curve going up by 45 degrees. Increase the range of stretching by moving the last key up and right by the same amount. Smoothing in the curve can help reduce elbow snapping (start stretching the arm slightly before target distance reaches arm length). To get a good optimal value for this curve, please go to the 'VRIK (Basic)' demo scene and copy the stretch curve over from the Pilot character.")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Token(Token = "0x40003FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x40003FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x4000400")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			[HideInInspector]
			public Vector3 bendDirection;

			[NonSerialized]
			[Token(Token = "0x4000401")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			[HideInInspector]
			public Vector3 handPositionOffset;

			[Token(Token = "0x4000404")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private bool hasShoulder;

			[Token(Token = "0x4000405")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
			private Vector3 chestForwardAxis;

			[Token(Token = "0x4000406")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			private Vector3 chestUpAxis;

			[Token(Token = "0x4000407")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
			private Quaternion chestRotation;

			[Token(Token = "0x4000408")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
			private Vector3 chestForward;

			[Token(Token = "0x4000409")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
			private Vector3 chestUp;

			[Token(Token = "0x400040A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
			private Quaternion forearmRelToUpperArm;

			[Token(Token = "0x400040B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
			private Vector3 upperArmBendAxis;

			[Token(Token = "0x17000082")]
			public Vector3 position
			{
				[Token(Token = "0x600054D")]
				[Address(RVA = "0xF9F8E0", Offset = "0xF9F8E0", VA = "0xF9F8E0")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600054E")]
				[Address(RVA = "0xF9F8EC", Offset = "0xF9F8EC", VA = "0xF9F8EC")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000083")]
			public Quaternion rotation
			{
				[Token(Token = "0x600054F")]
				[Address(RVA = "0xF9F8F8", Offset = "0xF9F8F8", VA = "0xF9F8F8")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000550")]
				[Address(RVA = "0xF9F904", Offset = "0xF9F904", VA = "0xF9F904")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000084")]
			private VirtualBone shoulder
			{
				[Token(Token = "0x6000551")]
				[Address(RVA = "0xF9F910", Offset = "0xF9F910", VA = "0xF9F910")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000085")]
			private VirtualBone upperArm
			{
				[Token(Token = "0x6000552")]
				[Address(RVA = "0xF9F938", Offset = "0xF9F938", VA = "0xF9F938")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000086")]
			private VirtualBone forearm
			{
				[Token(Token = "0x6000553")]
				[Address(RVA = "0xF9F96C", Offset = "0xF9F96C", VA = "0xF9F96C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000087")]
			private VirtualBone hand
			{
				[Token(Token = "0x6000554")]
				[Address(RVA = "0xF9F9AC", Offset = "0xF9F9AC", VA = "0xF9F9AC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000555")]
			[Address(RVA = "0xF9F9EC", Offset = "0xF9F9EC", VA = "0xF9F9EC", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000556")]
			[Address(RVA = "0xFA0408", Offset = "0xFA0408", VA = "0xFA0408", Slot = "5")]
			public override void PreSolve(float scale)
			{
			}

			[Token(Token = "0x6000557")]
			[Address(RVA = "0xFA06B4", Offset = "0xFA06B4", VA = "0xFA06B4", Slot = "7")]
			public override void ApplyOffsets(float scale)
			{
			}

			[Token(Token = "0x6000558")]
			[Address(RVA = "0xFA06D8", Offset = "0xFA06D8", VA = "0xFA06D8")]
			private void Stretching()
			{
			}

			[Token(Token = "0x6000559")]
			[Address(RVA = "0xFA0A28", Offset = "0xFA0A28", VA = "0xFA0A28")]
			public void Solve(bool isLeft)
			{
			}

			[Token(Token = "0x600055A")]
			[Address(RVA = "0xFA2C6C", Offset = "0xFA2C6C", VA = "0xFA2C6C", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x600055B")]
			[Address(RVA = "0xFA2CC4", Offset = "0xFA2CC4", VA = "0xFA2CC4", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x600055C")]
			[Address(RVA = "0xFA2020", Offset = "0xFA2020", VA = "0xFA2020")]
			private float DamperValue(float value, float min, float max, float weight = 1f)
			{
				return default(float);
			}

			[Token(Token = "0x600055D")]
			[Address(RVA = "0xFA2228", Offset = "0xFA2228", VA = "0xFA2228")]
			private Vector3 GetBendNormal(Vector3 dir)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600055E")]
			[Address(RVA = "0xFA2ED0", Offset = "0xFA2ED0", VA = "0xFA2ED0")]
			private void Visualize(VirtualBone bone1, VirtualBone bone2, VirtualBone bone3, Color color)
			{
			}

			[Token(Token = "0x600055F")]
			[Address(RVA = "0xFA2FE8", Offset = "0xFA2FE8", VA = "0xFA2FE8")]
			public Arm()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000A4")]
		public abstract class BodyPart
		{
			[Token(Token = "0x4000411")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public VirtualBone[] bones;

			[Token(Token = "0x4000412")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			protected bool initiated;

			[Token(Token = "0x4000413")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			protected Vector3 rootPosition;

			[Token(Token = "0x4000414")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			protected Quaternion rootRotation;

			[Token(Token = "0x4000415")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			protected int index;

			[Token(Token = "0x4000416")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			protected int LOD;

			[Token(Token = "0x17000088")]
			public float sqrMag
			{
				[Token(Token = "0x6000565")]
				[Address(RVA = "0xFA3238", Offset = "0xFA3238", VA = "0xFA3238")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000566")]
				[Address(RVA = "0xFA3240", Offset = "0xFA3240", VA = "0xFA3240")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000089")]
			public float mag
			{
				[Token(Token = "0x6000567")]
				[Address(RVA = "0xFA3248", Offset = "0xFA3248", VA = "0xFA3248")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000568")]
				[Address(RVA = "0xFA3250", Offset = "0xFA3250", VA = "0xFA3250")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x6000560")]
			protected abstract void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index);

			[Token(Token = "0x6000561")]
			public abstract void PreSolve(float scale);

			[Token(Token = "0x6000562")]
			public abstract void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations);

			[Token(Token = "0x6000563")]
			public abstract void ApplyOffsets(float scale);

			[Token(Token = "0x6000564")]
			public abstract void ResetOffsets();

			[Token(Token = "0x6000569")]
			[Address(RVA = "0xFA3258", Offset = "0xFA3258", VA = "0xFA3258")]
			public void SetLOD(int LOD)
			{
			}

			[Token(Token = "0x600056A")]
			[Address(RVA = "0xFA3260", Offset = "0xFA3260", VA = "0xFA3260")]
			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x600056B")]
			[Address(RVA = "0xFA347C", Offset = "0xFA347C", VA = "0xFA347C")]
			public void MovePosition(Vector3 position)
			{
			}

			[Token(Token = "0x600056C")]
			[Address(RVA = "0xFA3504", Offset = "0xFA3504", VA = "0xFA3504")]
			public void MoveRotation(Quaternion rotation)
			{
			}

			[Token(Token = "0x600056D")]
			[Address(RVA = "0xFA3708", Offset = "0xFA3708", VA = "0xFA3708")]
			public void Translate(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x600056E")]
			[Address(RVA = "0xFA3750", Offset = "0xFA3750", VA = "0xFA3750")]
			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot)
			{
			}

			[Token(Token = "0x600056F")]
			[Address(RVA = "0xFA2B08", Offset = "0xFA2B08", VA = "0xFA2B08")]
			public void RotateTo(VirtualBone bone, Quaternion rotation, float weight = 1f)
			{
			}

			[Token(Token = "0x6000570")]
			[Address(RVA = "0xFA3874", Offset = "0xFA3874", VA = "0xFA3874")]
			public void Visualize(Color color)
			{
			}

			[Token(Token = "0x6000571")]
			[Address(RVA = "0xFA3998", Offset = "0xFA3998", VA = "0xFA3998")]
			public void Visualize()
			{
			}

			[Token(Token = "0x6000572")]
			[Address(RVA = "0xFA3194", Offset = "0xFA3194", VA = "0xFA3194")]
			protected BodyPart()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000A5")]
		public class Footstep
		{
			[Token(Token = "0x4000417")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float stepSpeed;

			[Token(Token = "0x4000418")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 characterSpaceOffset;

			[Token(Token = "0x4000419")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 position;

			[Token(Token = "0x400041A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion rotation;

			[Token(Token = "0x400041B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Quaternion stepToRootRot;

			[Token(Token = "0x400041C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public bool isSupportLeg;

			[Token(Token = "0x400041D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
			public bool relaxFlag;

			[Token(Token = "0x400041F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 stepFrom;

			[Token(Token = "0x4000420")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 stepTo;

			[Token(Token = "0x4000421")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion stepFromRot;

			[Token(Token = "0x4000422")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			public Quaternion stepToRot;

			[Token(Token = "0x4000423")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			private Quaternion footRelativeToRoot;

			[Token(Token = "0x4000424")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			private float supportLegW;

			[Token(Token = "0x4000425")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private float supportLegWV;

			[Token(Token = "0x1700008A")]
			public bool isStepping
			{
				[Token(Token = "0x6000573")]
				[Address(RVA = "0xFA39AC", Offset = "0xFA39AC", VA = "0xFA39AC")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700008B")]
			public float stepProgress
			{
				[Token(Token = "0x6000574")]
				[Address(RVA = "0xFA39C0", Offset = "0xFA39C0", VA = "0xFA39C0")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000575")]
				[Address(RVA = "0xFA39C8", Offset = "0xFA39C8", VA = "0xFA39C8")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x6000576")]
			[Address(RVA = "0xFA39D0", Offset = "0xFA39D0", VA = "0xFA39D0")]
			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset)
			{
			}

			[Token(Token = "0x6000577")]
			[Address(RVA = "0xFA3B94", Offset = "0xFA3B94", VA = "0xFA3B94")]
			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation)
			{
			}

			[Token(Token = "0x6000578")]
			[Address(RVA = "0xFA3BDC", Offset = "0xFA3BDC", VA = "0xFA3BDC")]
			public void StepTo(Vector3 p, Quaternion rootRotation, float stepThreshold)
			{
			}

			[Token(Token = "0x6000579")]
			[Address(RVA = "0xFA3E20", Offset = "0xFA3E20", VA = "0xFA3E20")]
			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed, float deltaTime)
			{
			}

			[Token(Token = "0x600057A")]
			[Address(RVA = "0xFA3FC0", Offset = "0xFA3FC0", VA = "0xFA3FC0")]
			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed, float deltaTime)
			{
			}

			[Token(Token = "0x600057B")]
			[Address(RVA = "0xFA41B8", Offset = "0xFA41B8", VA = "0xFA41B8")]
			public void Update(InterpolationMode interpolation, UnityEvent onStep, float deltaTime)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000A6")]
		public class Leg : BodyPart
		{
			[Token(Token = "0x4000426")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[LargeHeader("Foot/Toe")]
			[Tooltip("The foot/toe target. This should not be the foot tracker itself, but a child GameObject parented to it so you could adjust its position/rotation to match the orientation of the foot/toe bone. If a toe bone is assigned in the References, the solver will match the toe bone to this target. If no toe bone assigned, foot bone will be used instead.")]
			public Transform target;

			[Token(Token = "0x4000427")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("Positional weight of the toe/foot target. Note that if you have nulled the target, the foot will still be pulled to the last position of the target until you set this value to 0.")]
			[Range(0f, 1f)]
			public float positionWeight;

			[Token(Token = "0x4000428")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[Tooltip("Rotational weight of the toe/foot target. Note that if you have nulled the target, the foot will still be rotated to the last rotation of the target until you set this value to 0.")]
			[Range(0f, 1f)]
			public float rotationWeight;

			[Token(Token = "0x4000429")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Tooltip("The knee will be bent towards this Transform if 'Bend Goal Weight' > 0.")]
			[LargeHeader("Bending")]
			public Transform bendGoal;

			[Token(Token = "0x400042A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[Range(0f, 1f)]
			[Tooltip("If greater than 0, will bend the knee towards the 'Bend Goal' Transform.")]
			public float bendGoalWeight;

			[Token(Token = "0x400042B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[Tooltip("Angular offset of knee bending direction.")]
			[Range(-180f, 180f)]
			public float swivelOffset;

			[Token(Token = "0x400042C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[Tooltip("If 0, the bend plane will be locked to the rotation of the pelvis and rotating the foot will have no effect on the knee direction. If 1, to the target rotation of the leg so that the knee will bend towards the forward axis of the foot. Values in between will be slerped between the two.")]
			[Range(0f, 1f)]
			public float bendToTargetWeight;

			[Token(Token = "0x400042D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[LargeHeader("Stretching")]
			[Tooltip("Use this to make the leg shorter/longer. Works by displacement of foot and calf localPosition.")]
			[Range(0.01f, 2f)]
			public float legLengthMlp;

			[Token(Token = "0x400042E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[Tooltip("Evaluates stretching of the leg by target distance relative to leg length. Value at time 1 represents stretching amount at the point where distance to the target is equal to leg length. Value at time 1 represents stretching amount at the point where distance to the target is double the leg length. Value represents the amount of stretching. Linear stretching would be achieved with a linear curve going up by 45 degrees. Increase the range of stretching by moving the last key up and right at the same amount. Smoothing in the curve can help reduce knee snapping (start stretching the arm slightly before target distance reaches leg length). To get a good optimal value for this curve, please go to the 'VRIK (Basic)' demo scene and copy the stretch curve over from the Pilot character.")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Token(Token = "0x400042F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x4000430")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x4000431")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[HideInInspector]
			public Vector3 footPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000432")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[HideInInspector]
			public Vector3 heelPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000433")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			[HideInInspector]
			public Quaternion footRotationOffset;

			[NonSerialized]
			[Token(Token = "0x4000434")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			[HideInInspector]
			public float currentMag;

			[Token(Token = "0x4000435")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			[HideInInspector]
			public bool useAnimatedBendNormal;

			[Token(Token = "0x400043A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			private Vector3 footPosition;

			[Token(Token = "0x400043B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
			private Quaternion footRotation;

			[Token(Token = "0x400043C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
			private Vector3 bendNormal;

			[Token(Token = "0x400043D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			private Quaternion calfRelToThigh;

			[Token(Token = "0x400043E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
			private Quaternion thighRelToFoot;

			[Token(Token = "0x1700008C")]
			public Vector3 position
			{
				[Token(Token = "0x600057C")]
				[Address(RVA = "0xFA4328", Offset = "0xFA4328", VA = "0xFA4328")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600057D")]
				[Address(RVA = "0xFA4334", Offset = "0xFA4334", VA = "0xFA4334")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700008D")]
			public Quaternion rotation
			{
				[Token(Token = "0x600057E")]
				[Address(RVA = "0xFA4340", Offset = "0xFA4340", VA = "0xFA4340")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x600057F")]
				[Address(RVA = "0xFA434C", Offset = "0xFA434C", VA = "0xFA434C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700008E")]
			public bool hasToes
			{
				[Token(Token = "0x6000580")]
				[Address(RVA = "0xFA4358", Offset = "0xFA4358", VA = "0xFA4358")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000581")]
				[Address(RVA = "0xFA4360", Offset = "0xFA4360", VA = "0xFA4360")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700008F")]
			public VirtualBone thigh
			{
				[Token(Token = "0x6000582")]
				[Address(RVA = "0xFA436C", Offset = "0xFA436C", VA = "0xFA436C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000090")]
			private VirtualBone calf
			{
				[Token(Token = "0x6000583")]
				[Address(RVA = "0xFA4394", Offset = "0xFA4394", VA = "0xFA4394")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000091")]
			private VirtualBone foot
			{
				[Token(Token = "0x6000584")]
				[Address(RVA = "0xFA43C0", Offset = "0xFA43C0", VA = "0xFA43C0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000092")]
			private VirtualBone toes
			{
				[Token(Token = "0x6000585")]
				[Address(RVA = "0xFA43EC", Offset = "0xFA43EC", VA = "0xFA43EC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000093")]
			public VirtualBone lastBone
			{
				[Token(Token = "0x6000586")]
				[Address(RVA = "0xFA4418", Offset = "0xFA4418", VA = "0xFA4418")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000094")]
			public Vector3 thighRelativeToPelvis
			{
				[Token(Token = "0x6000587")]
				[Address(RVA = "0xFA444C", Offset = "0xFA444C", VA = "0xFA444C")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000588")]
				[Address(RVA = "0xFA4458", Offset = "0xFA4458", VA = "0xFA4458")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000095")]
			public Vector3 bendNormalRelToPelvis
			{
				[Token(Token = "0x6000589")]
				[Address(RVA = "0xFA4464", Offset = "0xFA4464", VA = "0xFA4464")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600058A")]
				[Address(RVA = "0xFA4474", Offset = "0xFA4474", VA = "0xFA4474")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x17000096")]
			public Vector3 bendNormalRelToTarget
			{
				[Token(Token = "0x600058B")]
				[Address(RVA = "0xFA4484", Offset = "0xFA4484", VA = "0xFA4484")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600058C")]
				[Address(RVA = "0xFA4494", Offset = "0xFA4494", VA = "0xFA4494")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x600058D")]
			[Address(RVA = "0xFA44A4", Offset = "0xFA44A4", VA = "0xFA44A4", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x600058E")]
			[Address(RVA = "0xFA4A14", Offset = "0xFA4A14", VA = "0xFA4A14", Slot = "5")]
			public override void PreSolve(float scale)
			{
			}

			[Token(Token = "0x600058F")]
			[Address(RVA = "0xFA5244", Offset = "0xFA5244", VA = "0xFA5244", Slot = "7")]
			public override void ApplyOffsets(float scale)
			{
			}

			[Token(Token = "0x6000590")]
			[Address(RVA = "0xFA51F4", Offset = "0xFA51F4", VA = "0xFA51F4")]
			private void ApplyPositionOffset(Vector3 offset, float weight)
			{
			}

			[Token(Token = "0x6000591")]
			[Address(RVA = "0xFA4FA8", Offset = "0xFA4FA8", VA = "0xFA4FA8")]
			private void ApplyRotationOffset(Quaternion offset, float weight)
			{
			}

			[Token(Token = "0x6000592")]
			[Address(RVA = "0xFA5720", Offset = "0xFA5720", VA = "0xFA5720")]
			public void Solve(bool stretch)
			{
			}

			[Token(Token = "0x6000593")]
			[Address(RVA = "0xFA5CFC", Offset = "0xFA5CFC", VA = "0xFA5CFC")]
			private void FixTwistRotations()
			{
			}

			[Token(Token = "0x6000594")]
			[Address(RVA = "0xFA5964", Offset = "0xFA5964", VA = "0xFA5964")]
			private void Stretching()
			{
			}

			[Token(Token = "0x6000595")]
			[Address(RVA = "0xFA6154", Offset = "0xFA6154", VA = "0xFA6154", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000596")]
			[Address(RVA = "0xFA635C", Offset = "0xFA635C", VA = "0xFA635C", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000597")]
			[Address(RVA = "0xFA643C", Offset = "0xFA643C", VA = "0xFA643C")]
			public Leg()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000A7")]
		public class Locomotion
		{
			[Serializable]
			[Token(Token = "0x20000A8")]
			public enum Mode
			{
				[Token(Token = "0x4000487")]
				Procedural,
				[Token(Token = "0x4000488")]
				Animated
			}

			[Token(Token = "0x4000441")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Procedural (legacy) or animated locomotion.")]
			public Mode mode;

			[Token(Token = "0x4000442")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Range(0f, 1f)]
			[Tooltip("Used for blending in/out of procedural/animated locomotion.")]
			public float weight;

			[Token(Token = "0x4000443")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Start moving (horizontal distance to HMD + HMD velocity) threshold.")]
			[ShowIf("mode", Mode.Animated, null, false, ShowIfMode.Hidden)]
			public float moveThreshold;

			[Token(Token = "0x4000444")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[ShowLargeHeaderIf("Animation", "mode", Mode.Animated, null, false, ShowIfMode.Hidden)]
			[SerializeField]
			private byte animationHeader;

			[Token(Token = "0x4000445")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Minimum locomotion animation speed.")]
			[ShowRangeIf(0.1f, 1f, "mode", Mode.Animated, null, false, ShowIfMode.Hidden)]
			public float minAnimationSpeed;

			[Token(Token = "0x4000446")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[Tooltip("Maximum locomotion animation speed.")]
			[ShowRangeIf(1f, 10f, "mode", Mode.Animated, null, false, ShowIfMode.Hidden)]
			public float maxAnimationSpeed;

			[Token(Token = "0x4000447")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Smoothing time for Vector3.SmoothDamping 'VRIK_Horizontal' and 'VRIK_Vertical' parameters. Larger values make animation smoother, but less responsive.")]
			[ShowRangeIf(0.05f, 0.2f, "mode", Mode.Animated, null, false, ShowIfMode.Hidden)]
			public float animationSmoothTime;

			[Token(Token = "0x4000448")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[ShowLargeHeaderIf("Root Position", "mode", Mode.Animated, null, false, ShowIfMode.Hidden)]
			[SerializeField]
			private byte rootPositionHeader;

			[Token(Token = "0x4000449")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("X and Z standing offset from the horizontal position of the HMD.")]
			[ShowIf("mode", Mode.Animated, null, false, ShowIfMode.Hidden)]
			public Vector2 standOffset;

			[Token(Token = "0x400044A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[Tooltip("Lerp root towards the horizontal position of the HMD with this speed while moving.")]
			[ShowRangeIf(0f, 50f, "mode", Mode.Animated, null, false, ShowIfMode.Hidden)]
			public float rootLerpSpeedWhileMoving;

			[Token(Token = "0x400044B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			[Tooltip("Lerp root towards the horizontal position of the HMD with this speed while in transition from locomotion to idle state.")]
			[ShowRangeIf(0f, 50f, "mode", Mode.Animated, null, false, ShowIfMode.Hidden)]
			public float rootLerpSpeedWhileStopping;

			[Token(Token = "0x400044C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[Tooltip("Lerp root towards the horizontal position of the HMD with this speed while turning on spot.")]
			[ShowRangeIf(0f, 50f, "mode", Mode.Animated, null, false, ShowIfMode.Hidden)]
			public float rootLerpSpeedWhileTurning;

			[Token(Token = "0x400044D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[Tooltip("Max horizontal distance from the root to the HMD.")]
			[ShowIf("mode", Mode.Animated, null, false, ShowIfMode.Hidden)]
			public float maxRootOffset;

			[Token(Token = "0x400044E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[SerializeField]
			[ShowLargeHeaderIf("Root Rotation", "mode", Mode.Animated, null, false, ShowIfMode.Hidden)]
			private byte rootRotationHeader;

			[Token(Token = "0x400044F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			[Tooltip("Max root angle from head forward while moving (ik.solver.spine.maxRootAngle).")]
			[ShowRangeIf(0f, 180f, "mode", Mode.Animated, null, false, ShowIfMode.Hidden)]
			public float maxRootAngleMoving;

			[Token(Token = "0x4000450")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("Max root angle from head forward while standing (ik.solver.spine.maxRootAngle.")]
			[ShowRangeIf(0f, 180f, "mode", Mode.Animated, null, false, ShowIfMode.Hidden)]
			public float maxRootAngleStanding;

			[Token(Token = "0x4000451")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[HideInInspector]
			[SerializeField]
			public float stepLengthMlp;

			[Token(Token = "0x4000452")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Animator animator;

			[Token(Token = "0x4000453")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Vector3 velocityLocal;

			[Token(Token = "0x4000454")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			private Vector3 velocityLocalV;

			[Token(Token = "0x4000455")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private Vector3 lastCorrection;

			[Token(Token = "0x4000456")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Vector3 lastHeadTargetPos;

			[Token(Token = "0x4000457")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private Vector3 lastSpeedRootPos;

			[Token(Token = "0x4000458")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			private Vector3 lastEndRootPos;

			[Token(Token = "0x4000459")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private float rootLerpSpeed;

			[Token(Token = "0x400045A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			private float rootVelocityV;

			[Token(Token = "0x400045B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private float animSpeed;

			[Token(Token = "0x400045C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			private float animSpeedV;

			[Token(Token = "0x400045D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private float stopMoveTimer;

			[Token(Token = "0x400045E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private float turn;

			[Token(Token = "0x400045F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private float maxRootAngleV;

			[Token(Token = "0x4000460")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			private float currentAnimationSmoothTime;

			[Token(Token = "0x4000461")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			private bool isMoving;

			[Token(Token = "0x4000462")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC9")]
			private bool firstFrame;

			[Token(Token = "0x4000463")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static int VRIK_Horizontal;

			[Token(Token = "0x4000464")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			private static int VRIK_Vertical;

			[Token(Token = "0x4000465")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static int VRIK_IsMoving;

			[Token(Token = "0x4000466")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private static int VRIK_Speed;

			[Token(Token = "0x4000467")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static int VRIK_Turn;

			[Token(Token = "0x4000468")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private static bool isHashed;

			[Token(Token = "0x4000469")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			private float lastVelLocalMag;

			[Token(Token = "0x400046A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			[Tooltip("Tries to maintain this distance between the legs.")]
			[ShowIf("mode", Mode.Procedural, null, false, ShowIfMode.Hidden)]
			public float footDistance;

			[Token(Token = "0x400046B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
			[Tooltip("Makes a step only if step target position is at least this far from the current footstep or the foot does not reach the current footstep anymore or footstep angle is past the 'Angle Threshold'.")]
			[ShowIf("mode", Mode.Procedural, null, false, ShowIfMode.Hidden)]
			public float stepThreshold;

			[Token(Token = "0x400046C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			[ShowIf("mode", Mode.Procedural, null, false, ShowIfMode.Hidden)]
			[Tooltip("Makes a step only if step target position is at least 'Step Threshold' far from the current footstep or the foot does not reach the current footstep anymore or footstep angle is past this value.")]
			public float angleThreshold;

			[Token(Token = "0x400046D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
			[ShowIf("mode", Mode.Procedural, null, false, ShowIfMode.Hidden)]
			[Tooltip("Multiplies angle of the center of mass - center of pressure vector. Larger value makes the character step sooner if losing balance.")]
			public float comAngleMlp;

			[Token(Token = "0x400046E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			[Tooltip("Maximum magnitude of head/hand target velocity used in prediction.")]
			[ShowIf("mode", Mode.Procedural, null, false, ShowIfMode.Hidden)]
			public float maxVelocity;

			[Token(Token = "0x400046F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
			[Tooltip("The amount of head/hand target velocity prediction.")]
			[ShowIf("mode", Mode.Procedural, null, false, ShowIfMode.Hidden)]
			public float velocityFactor;

			[Token(Token = "0x4000470")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			[ShowRangeIf(0.9f, 1f, "mode", Mode.Procedural, null, false, ShowIfMode.Hidden)]
			[Tooltip("How much can a leg be extended before it is forced to step to another position? 1 means fully stretched.")]
			public float maxLegStretch;

			[Token(Token = "0x4000471")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			[ShowIf("mode", Mode.Procedural, null, false, ShowIfMode.Hidden)]
			[Tooltip("The speed of lerping the root of the character towards the horizontal mid-point of the footsteps.")]
			public float rootSpeed;

			[Token(Token = "0x4000472")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			[ShowIf("mode", Mode.Procedural, null, false, ShowIfMode.Hidden)]
			[Tooltip("The speed of moving a foot to the next position.")]
			public float stepSpeed;

			[Token(Token = "0x4000473")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			[Tooltip("The height of the foot by normalized step progress (0 - 1).")]
			[ShowIf("mode", Mode.Procedural, null, false, ShowIfMode.Hidden)]
			public AnimationCurve stepHeight;

			[Token(Token = "0x4000474")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
			[Tooltip("Reduce this value if locomotion makes the head bob too much.")]
			[ShowIf("mode", Mode.Procedural, null, false, ShowIfMode.Hidden)]
			public float maxBodyYOffset;

			[Token(Token = "0x4000475")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			[Tooltip("The height offset of the heel by normalized step progress (0 - 1).")]
			[ShowIf("mode", Mode.Procedural, null, false, ShowIfMode.Hidden)]
			public AnimationCurve heelHeight;

			[Token(Token = "0x4000476")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
			[Tooltip("Rotates the foot while the leg is not stepping to relax the twist rotation of the leg if ideal rotation is past this angle.")]
			[ShowRangeIf(0f, 180f, "mode", Mode.Procedural, null, false, ShowIfMode.Hidden)]
			public float relaxLegTwistMinAngle;

			[Token(Token = "0x4000477")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
			[ShowIf("mode", Mode.Procedural, null, false, ShowIfMode.Hidden)]
			[Tooltip("The speed of rotating the foot while the leg is not stepping to relax the twist rotation of the leg.")]
			public float relaxLegTwistSpeed;

			[Token(Token = "0x4000478")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			[Tooltip("Interpolation mode of the step.")]
			[ShowIf("mode", Mode.Procedural, null, false, ShowIfMode.Hidden)]
			public InterpolationMode stepInterpolation;

			[Token(Token = "0x4000479")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
			[Tooltip("Offset for the approximated center of mass.")]
			[ShowIf("mode", Mode.Procedural, null, false, ShowIfMode.Hidden)]
			public Vector3 offset;

			[Token(Token = "0x400047A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
			[HideInInspector]
			public bool blockingEnabled;

			[Token(Token = "0x400047B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
			[HideInInspector]
			public LayerMask blockingLayers;

			[Token(Token = "0x400047C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
			[HideInInspector]
			public float raycastRadius;

			[Token(Token = "0x400047D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
			[HideInInspector]
			public float raycastHeight;

			[Token(Token = "0x400047E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
			[HideInInspector]
			[SerializeField]
			public UnityEvent onLeftFootstep;

			[Token(Token = "0x400047F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
			[SerializeField]
			[HideInInspector]
			public UnityEvent onRightFootstep;

			[Token(Token = "0x4000481")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
			private Footstep[] footsteps;

			[Token(Token = "0x4000482")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
			private Vector3 lastComPosition;

			[Token(Token = "0x4000483")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
			private Vector3 comVelocity;

			[Token(Token = "0x4000484")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
			private int leftFootIndex;

			[Token(Token = "0x4000485")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
			private int rightFootIndex;

			[Token(Token = "0x17000097")]
			public Vector3 centerOfMass
			{
				[Token(Token = "0x60005A3")]
				[Address(RVA = "0xFA8174", Offset = "0xFA8174", VA = "0xFA8174")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60005A4")]
				[Address(RVA = "0xFA8184", Offset = "0xFA8184", VA = "0xFA8184")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000098")]
			public Vector3 leftFootstepPosition
			{
				[Token(Token = "0x60005AB")]
				[Address(RVA = "0xFA9A54", Offset = "0xFA9A54", VA = "0xFA9A54")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000099")]
			public Vector3 rightFootstepPosition
			{
				[Token(Token = "0x60005AC")]
				[Address(RVA = "0xFA9A88", Offset = "0xFA9A88", VA = "0xFA9A88")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700009A")]
			public Quaternion leftFootstepRotation
			{
				[Token(Token = "0x60005AD")]
				[Address(RVA = "0xFA9AC0", Offset = "0xFA9AC0", VA = "0xFA9AC0")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x1700009B")]
			public Quaternion rightFootstepRotation
			{
				[Token(Token = "0x60005AE")]
				[Address(RVA = "0xFA9AF4", Offset = "0xFA9AF4", VA = "0xFA9AF4")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x6000598")]
			[Address(RVA = "0xFA6524", Offset = "0xFA6524", VA = "0xFA6524")]
			public void Initiate(Animator animator, Vector3[] positions, Quaternion[] rotations, bool hasToes, float scale)
			{
			}

			[Token(Token = "0x6000599")]
			[Address(RVA = "0xFA696C", Offset = "0xFA696C", VA = "0xFA696C")]
			public void Reset(Vector3[] positions, Quaternion[] rotations)
			{
			}

			[Token(Token = "0x600059A")]
			[Address(RVA = "0xFA6DC8", Offset = "0xFA6DC8", VA = "0xFA6DC8")]
			public void Relax()
			{
			}

			[Token(Token = "0x600059B")]
			[Address(RVA = "0xFA6E18", Offset = "0xFA6E18", VA = "0xFA6E18")]
			public void AddDeltaRotation(Quaternion delta, Vector3 pivot)
			{
			}

			[Token(Token = "0x600059C")]
			[Address(RVA = "0xFA7360", Offset = "0xFA7360", VA = "0xFA7360")]
			public void AddDeltaPosition(Vector3 delta)
			{
			}

			[Token(Token = "0x600059D")]
			[Address(RVA = "0xFA6890", Offset = "0xFA6890", VA = "0xFA6890")]
			public void Initiate_Animated(Animator animator, Vector3[] positions)
			{
			}

			[Token(Token = "0x600059E")]
			[Address(RVA = "0xFA74A8", Offset = "0xFA74A8", VA = "0xFA74A8")]
			private void ResetParams(Vector3[] positions)
			{
			}

			[Token(Token = "0x600059F")]
			[Address(RVA = "0xFA6B80", Offset = "0xFA6B80", VA = "0xFA6B80")]
			public void Reset_Animated(Vector3[] positions)
			{
			}

			[Token(Token = "0x60005A0")]
			[Address(RVA = "0xFA7258", Offset = "0xFA7258", VA = "0xFA7258")]
			private void AddDeltaRotation_Animated(Quaternion delta, Vector3 pivot)
			{
			}

			[Token(Token = "0x60005A1")]
			[Address(RVA = "0xFA7458", Offset = "0xFA7458", VA = "0xFA7458")]
			private void AddDeltaPosition_Animated(Vector3 delta)
			{
			}

			[Token(Token = "0x60005A2")]
			[Address(RVA = "0xFA7560", Offset = "0xFA7560", VA = "0xFA7560")]
			public void Solve_Animated(IKSolverVR solver, float scale, float deltaTime)
			{
			}

			[Token(Token = "0x60005A5")]
			[Address(RVA = "0xFA6564", Offset = "0xFA6564", VA = "0xFA6564")]
			private void Initiate_Procedural(Vector3[] positions, Quaternion[] rotations, bool hasToes, float scale)
			{
			}

			[Token(Token = "0x60005A6")]
			[Address(RVA = "0xFA6994", Offset = "0xFA6994", VA = "0xFA6994")]
			private void Reset_Procedural(Vector3[] positions, Quaternion[] rotations)
			{
			}

			[Token(Token = "0x60005A7")]
			[Address(RVA = "0xFA6DCC", Offset = "0xFA6DCC", VA = "0xFA6DCC")]
			private void Relax_Procedural()
			{
			}

			[Token(Token = "0x60005A8")]
			[Address(RVA = "0xFA6E88", Offset = "0xFA6E88", VA = "0xFA6E88")]
			private void AddDeltaRotation_Procedural(Quaternion delta, Vector3 pivot)
			{
			}

			[Token(Token = "0x60005A9")]
			[Address(RVA = "0xFA73A0", Offset = "0xFA73A0", VA = "0xFA73A0")]
			private void AddDeltaPosition_Procedural(Vector3 delta)
			{
			}

			[Token(Token = "0x60005AA")]
			[Address(RVA = "0xFA8194", Offset = "0xFA8194", VA = "0xFA8194")]
			public void Solve_Procedural(VirtualBone rootBone, Spine spine, Leg leftLeg, Leg rightLeg, Arm leftArm, Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset, float scale, float deltaTime)
			{
			}

			[Token(Token = "0x60005AF")]
			[Address(RVA = "0xFA9680", Offset = "0xFA9680", VA = "0xFA9680")]
			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition)
			{
				return default(bool);
			}

			[Token(Token = "0x60005B0")]
			[Address(RVA = "0xFA9838", Offset = "0xFA9838", VA = "0xFA9838")]
			private bool CanStep()
			{
				return default(bool);
			}

			[Token(Token = "0x60005B1")]
			[Address(RVA = "0xFA98A4", Offset = "0xFA98A4", VA = "0xFA98A4")]
			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius)
			{
				return default(bool);
			}

			[Token(Token = "0x60005B2")]
			[Address(RVA = "0xFA9B2C", Offset = "0xFA9B2C", VA = "0xFA9B2C")]
			public Locomotion()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000A9")]
		public class Spine : BodyPart
		{
			[Token(Token = "0x4000489")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[LargeHeader("Head")]
			[Tooltip("The head target. This should not be the camera Transform itself, but a child GameObject parented to it so you could adjust its position/rotation  to match the orientation of the head bone. The best practice for setup would be to move the camera to the avatar's eyes, duplicate the avatar's head bone and parent it to the camera. Then assign the duplicate to this slot.")]
			public Transform headTarget;

			[Token(Token = "0x400048A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Range(0f, 1f)]
			[Tooltip("Positional weight of the head target. Note that if you have nulled the headTarget, the head will still be pulled to the last position of the headTarget until you set this value to 0.")]
			public float positionWeight;

			[Token(Token = "0x400048B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[Range(0f, 1f)]
			[Tooltip("Rotational weight of the head target. Note that if you have nulled the headTarget, the head will still be rotated to the last rotation of the headTarget until you set this value to 0.")]
			public float rotationWeight;

			[Token(Token = "0x400048C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Range(0f, 1f)]
			[Tooltip("Clamps head rotation. Value of 0.5 allows 90 degrees of rotation for the head relative to the headTarget. Value of 0 allows 180 degrees and value of 1 means head rotation will be locked to the target.")]
			public float headClampWeight;

			[Token(Token = "0x400048D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[Tooltip("Minimum height of the head from the root of the character.")]
			public float minHeadHeight;

			[Token(Token = "0x400048E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[Tooltip("Allows for more natural locomotion animation for 3rd person networked avatars by inheriting vertical head bob motion from the animation while head target height is close to head bone height.")]
			[Range(0f, 1f)]
			public float useAnimatedHeadHeightWeight;

			[Token(Token = "0x400048F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[Tooltip("If abs(head target height - head bone height) < this value, will use head bone height as head target Y.")]
			[ShowIf("useAnimatedHeadHeightWeight", 0f, float.PositiveInfinity, false, ShowIfMode.Hidden)]
			public float useAnimatedHeadHeightRange;

			[Token(Token = "0x4000490")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[Tooltip("Falloff range for the 'Use Animated Head Height Range' effect above. If head target height from head bone height is greater than useAnimatedHeadHeightRange + animatedHeadHeightBlend, then the head will be vertically locked to the head target again.")]
			[ShowIf("useAnimatedHeadHeightWeight", 0f, float.PositiveInfinity, false, ShowIfMode.Hidden)]
			public float animatedHeadHeightBlend;

			[Token(Token = "0x4000491")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[LargeHeader("Pelvis")]
			[Tooltip("The pelvis target (optional), useful for seated rigs or if you had an additional tracker on the backpack or belt are. The best practice for setup would be to duplicate the avatar's pelvis bone and parenting it to the pelvis tracker. Then assign the duplicate to this slot.")]
			public Transform pelvisTarget;

			[Token(Token = "0x4000492")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[Range(0f, 1f)]
			[Tooltip("Positional weight of the pelvis target. Note that if you have nulled the pelvisTarget, the pelvis will still be pulled to the last position of the pelvisTarget until you set this value to 0.")]
			public float pelvisPositionWeight;

			[Token(Token = "0x4000493")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[Tooltip("Rotational weight of the pelvis target. Note that if you have nulled the pelvisTarget, the pelvis will still be rotated to the last rotation of the pelvisTarget until you set this value to 0.")]
			[Range(0f, 1f)]
			public float pelvisRotationWeight;

			[Token(Token = "0x4000494")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[Tooltip("How much will the pelvis maintain its animated position?")]
			[Range(0f, 1f)]
			public float maintainPelvisPosition;

			[Token(Token = "0x4000495")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[LargeHeader("Chest")]
			[Tooltip("If 'Chest Goal Weight' is greater than 0, the chest will be turned towards this Transform.")]
			public Transform chestGoal;

			[Token(Token = "0x4000496")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[Tooltip("Weight of turning the chest towards the 'Chest Goal'.")]
			[Range(0f, 1f)]
			public float chestGoalWeight;

			[Token(Token = "0x4000497")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[Tooltip("Clamps chest rotation. Value of 0.5 allows 90 degrees of rotation for the chest relative to the head. Value of 0 allows 180 degrees and value of 1 means the chest will be locked relative to the head.")]
			[Range(0f, 1f)]
			public float chestClampWeight;

			[Token(Token = "0x4000498")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[Range(0f, 1f)]
			[Tooltip("The amount of rotation applied to the chest based on hand positions.")]
			public float rotateChestByHands;

			[Token(Token = "0x4000499")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[LargeHeader("Spine")]
			[Range(0f, 1f)]
			[Tooltip("Determines how much the body will follow the position of the head.")]
			public float bodyPosStiffness;

			[Token(Token = "0x400049A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[Tooltip("Determines how much the body will follow the rotation of the head.")]
			[Range(0f, 1f)]
			public float bodyRotStiffness;

			[Token(Token = "0x400049B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			[Tooltip("Determines how much the chest will rotate to the rotation of the head.")]
			[FormerlySerializedAs("chestRotationWeight")]
			[Range(0f, 1f)]
			public float neckStiffness;

			[Token(Token = "0x400049C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[Tooltip("Moves the body horizontally along -character.forward axis by that value when the player is crouching.")]
			public float moveBodyBackWhenCrouching;

			[Token(Token = "0x400049D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			[LargeHeader("Root Rotation")]
			[Tooltip("Will automatically rotate the root of the character if the head target has turned past this angle.")]
			[Range(0f, 180f)]
			public float maxRootAngle;

			[Token(Token = "0x400049E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			[Range(-180f, 180f)]
			[Tooltip("Angular offset for root heading. Adjust this value to turn the root relative to the HMD around the vertical axis. Usefulf for fighting or shooting games where you would sometimes want the avatar to stand at an angled stance.")]
			public float rootHeadingOffset;

			[NonSerialized]
			[Token(Token = "0x400049F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			[HideInInspector]
			public Vector3 IKPositionHead;

			[NonSerialized]
			[Token(Token = "0x40004A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			[HideInInspector]
			public Quaternion IKRotationHead;

			[NonSerialized]
			[Token(Token = "0x40004A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			[HideInInspector]
			public Vector3 IKPositionPelvis;

			[NonSerialized]
			[Token(Token = "0x40004A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
			[HideInInspector]
			public Quaternion IKRotationPelvis;

			[NonSerialized]
			[Token(Token = "0x40004A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			[HideInInspector]
			public Vector3 goalPositionChest;

			[NonSerialized]
			[Token(Token = "0x40004A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			[HideInInspector]
			public Vector3 pelvisPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40004A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
			[HideInInspector]
			public Vector3 chestPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40004A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
			[HideInInspector]
			public Vector3 headPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40004A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
			[HideInInspector]
			public Quaternion pelvisRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40004A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
			[HideInInspector]
			public Quaternion chestRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40004A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
			[HideInInspector]
			public Quaternion headRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40004AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
			[HideInInspector]
			public Vector3 faceDirection;

			[NonSerialized]
			[Token(Token = "0x40004AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
			[HideInInspector]
			internal Vector3 headPosition;

			[Token(Token = "0x40004AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x184")]
			private Quaternion headRotation;

			[Token(Token = "0x40004AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x194")]
			private Quaternion pelvisRotation;

			[Token(Token = "0x40004B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
			private Quaternion anchorRelativeToPelvis;

			[Token(Token = "0x40004B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1B4")]
			private Quaternion pelvisRelativeRotation;

			[Token(Token = "0x40004B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
			private Quaternion chestRelativeRotation;

			[Token(Token = "0x40004B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
			private Vector3 headDeltaPosition;

			[Token(Token = "0x40004B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
			private Quaternion pelvisDeltaRotation;

			[Token(Token = "0x40004B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
			private Quaternion chestTargetRotation;

			[Token(Token = "0x40004B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
			private int pelvisIndex;

			[Token(Token = "0x40004B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x204")]
			private int spineIndex;

			[Token(Token = "0x40004B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
			private int chestIndex;

			[Token(Token = "0x40004B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20C")]
			private int neckIndex;

			[Token(Token = "0x40004BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
			private int headIndex;

			[Token(Token = "0x40004BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x214")]
			private float length;

			[Token(Token = "0x40004BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
			private bool hasChest;

			[Token(Token = "0x40004BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x219")]
			private bool hasNeck;

			[Token(Token = "0x40004BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x21A")]
			private bool hasLegs;

			[Token(Token = "0x40004BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x21C")]
			private float headHeight;

			[Token(Token = "0x40004C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
			private float sizeMlp;

			[Token(Token = "0x40004C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x224")]
			private Vector3 chestForward;

			[Token(Token = "0x1700009C")]
			internal VirtualBone pelvis
			{
				[Token(Token = "0x60005B3")]
				[Address(RVA = "0xFA9618", Offset = "0xFA9618", VA = "0xFA9618")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700009D")]
			internal VirtualBone firstSpineBone
			{
				[Token(Token = "0x60005B4")]
				[Address(RVA = "0xFA9CA0", Offset = "0xFA9CA0", VA = "0xFA9CA0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700009E")]
			internal VirtualBone chest
			{
				[Token(Token = "0x60005B5")]
				[Address(RVA = "0xFA9CD4", Offset = "0xFA9CD4", VA = "0xFA9CD4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700009F")]
			internal VirtualBone head
			{
				[Token(Token = "0x60005B6")]
				[Address(RVA = "0xFA964C", Offset = "0xFA964C", VA = "0xFA964C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A0")]
			private VirtualBone neck
			{
				[Token(Token = "0x60005B7")]
				[Address(RVA = "0xFA9D1C", Offset = "0xFA9D1C", VA = "0xFA9D1C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A1")]
			internal Quaternion anchorRotation
			{
				[Token(Token = "0x60005B8")]
				[Address(RVA = "0xFA9D50", Offset = "0xFA9D50", VA = "0xFA9D50")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x60005B9")]
				[Address(RVA = "0xFA9D64", Offset = "0xFA9D64", VA = "0xFA9D64")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000A2")]
			internal Quaternion anchorRelativeToHead
			{
				[Token(Token = "0x60005BA")]
				[Address(RVA = "0xFA9D78", Offset = "0xFA9D78", VA = "0xFA9D78")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x60005BB")]
				[Address(RVA = "0xFA9D8C", Offset = "0xFA9D8C", VA = "0xFA9D8C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x60005BC")]
			[Address(RVA = "0xFA9DA0", Offset = "0xFA9DA0", VA = "0xFA9DA0", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x60005BD")]
			[Address(RVA = "0xFAAA40", Offset = "0xFAAA40", VA = "0xFAAA40", Slot = "5")]
			public override void PreSolve(float scale)
			{
			}

			[Token(Token = "0x60005BE")]
			[Address(RVA = "0xFAAE4C", Offset = "0xFAAE4C", VA = "0xFAAE4C", Slot = "7")]
			public override void ApplyOffsets(float scale)
			{
			}

			[Token(Token = "0x60005BF")]
			[Address(RVA = "0xFAB5F0", Offset = "0xFAB5F0", VA = "0xFAB5F0")]
			private void CalculateChestTargetRotation(VirtualBone rootBone, Arm[] arms)
			{
			}

			[Token(Token = "0x60005C0")]
			[Address(RVA = "0xFABC48", Offset = "0xFABC48", VA = "0xFABC48")]
			public void Solve(Animator animator, VirtualBone rootBone, Leg[] legs, Arm[] arms, float scale)
			{
			}

			[Token(Token = "0x60005C1")]
			[Address(RVA = "0xFAC680", Offset = "0xFAC680", VA = "0xFAC680")]
			private void FABRIKPass(Vector3 animatedPelvisPos, Vector3 rootUp, float weight)
			{
			}

			[Token(Token = "0x60005C2")]
			[Address(RVA = "0xFACE28", Offset = "0xFACE28", VA = "0xFACE28")]
			private void SolvePelvis()
			{
			}

			[Token(Token = "0x60005C3")]
			[Address(RVA = "0xFAD408", Offset = "0xFAD408", VA = "0xFAD408", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x60005C4")]
			[Address(RVA = "0xFAD5D8", Offset = "0xFAD5D8", VA = "0xFAD5D8", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x60005C5")]
			[Address(RVA = "0xFAB850", Offset = "0xFAB850", VA = "0xFAB850")]
			private void AdjustChestByHands(ref Quaternion chestTargetRotation, Arm[] arms)
			{
			}

			[Token(Token = "0x60005C6")]
			[Address(RVA = "0xFACB54", Offset = "0xFACB54", VA = "0xFACB54")]
			public void InverseTranslateToHead(Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w)
			{
			}

			[Token(Token = "0x60005C7")]
			[Address(RVA = "0xFAC264", Offset = "0xFAC264", VA = "0xFAC264")]
			private void TranslatePelvis(Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation, float scale)
			{
			}

			[Token(Token = "0x60005C8")]
			[Address(RVA = "0xFAD6AC", Offset = "0xFAD6AC", VA = "0xFAD6AC")]
			private Vector3 LimitPelvisPosition(Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60005C9")]
			[Address(RVA = "0xFACC2C", Offset = "0xFACC2C", VA = "0xFACC2C")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x60005CA")]
			[Address(RVA = "0xFAC8E4", Offset = "0xFAC8E4", VA = "0xFAC8E4")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x60005CB")]
			[Address(RVA = "0xFAD950", Offset = "0xFAD950", VA = "0xFAD950")]
			public Spine()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000AA")]
		public enum PositionOffset
		{
			[Token(Token = "0x40004C3")]
			Pelvis,
			[Token(Token = "0x40004C4")]
			Chest,
			[Token(Token = "0x40004C5")]
			Head,
			[Token(Token = "0x40004C6")]
			LeftHand,
			[Token(Token = "0x40004C7")]
			RightHand,
			[Token(Token = "0x40004C8")]
			LeftFoot,
			[Token(Token = "0x40004C9")]
			RightFoot,
			[Token(Token = "0x40004CA")]
			LeftHeel,
			[Token(Token = "0x40004CB")]
			RightHeel
		}

		[Serializable]
		[Token(Token = "0x20000AB")]
		public enum RotationOffset
		{
			[Token(Token = "0x40004CD")]
			Pelvis,
			[Token(Token = "0x40004CE")]
			Chest,
			[Token(Token = "0x40004CF")]
			Head
		}

		[Serializable]
		[Token(Token = "0x20000AC")]
		public class VirtualBone
		{
			[Token(Token = "0x40004D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 readPosition;

			[Token(Token = "0x40004D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Quaternion readRotation;

			[Token(Token = "0x40004D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 solverPosition;

			[Token(Token = "0x40004D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Quaternion solverRotation;

			[Token(Token = "0x40004D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public float length;

			[Token(Token = "0x40004D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public float sqrMag;

			[Token(Token = "0x40004D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Vector3 axis;

			[Token(Token = "0x60005CC")]
			[Address(RVA = "0xFA0378", Offset = "0xFA0378", VA = "0xFA0378")]
			public VirtualBone(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x60005CD")]
			[Address(RVA = "0xFA03E8", Offset = "0xFA03E8", VA = "0xFA03E8")]
			public void Read(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x60005CE")]
			[Address(RVA = "0xFADA80", Offset = "0xFADA80", VA = "0xFADA80")]
			public static void SwingRotation(VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x60005CF")]
			[Address(RVA = "0xFA331C", Offset = "0xFA331C", VA = "0xFA331C")]
			public static float PreSolve(ref VirtualBone[] bones)
			{
				return default(float);
			}

			[Token(Token = "0x60005D0")]
			[Address(RVA = "0xFA3598", Offset = "0xFA3598", VA = "0xFA3598")]
			public static void RotateAroundPoint(VirtualBone[] bones, int index, Vector3 point, Quaternion rotation)
			{
			}

			[Token(Token = "0x60005D1")]
			[Address(RVA = "0xFADC80", Offset = "0xFADC80", VA = "0xFADC80")]
			public static void RotateBy(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x60005D2")]
			[Address(RVA = "0xFA20A0", Offset = "0xFA20A0", VA = "0xFA20A0")]
			public static void RotateBy(VirtualBone[] bones, Quaternion rotation)
			{
			}

			[Token(Token = "0x60005D3")]
			[Address(RVA = "0xFADE28", Offset = "0xFADE28", VA = "0xFADE28")]
			public static void RotateTo(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x60005D4")]
			[Address(RVA = "0xFA2724", Offset = "0xFA2724", VA = "0xFA2724")]
			public static void SolveTrigonometric(VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight)
			{
			}

			[Token(Token = "0x60005D5")]
			[Address(RVA = "0xFADECC", Offset = "0xFADECC", VA = "0xFADECC")]
			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60005D6")]
			[Address(RVA = "0xFAD03C", Offset = "0xFAD03C", VA = "0xFAD03C")]
			public static void SolveFABRIK(VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length, Vector3 startOffset)
			{
			}

			[Token(Token = "0x60005D7")]
			[Address(RVA = "0xFAE024", Offset = "0xFAE024", VA = "0xFAE024")]
			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60005D8")]
			[Address(RVA = "0xFAE138", Offset = "0xFAE138", VA = "0xFAE138")]
			public static void SolveCCD(VirtualBone[] bones, Vector3 targetPosition, float weight, int iterations)
			{
			}
		}

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform[] solverTransforms;

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool hasChest;

		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		private bool hasNeck;

		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A")]
		private bool hasShoulders;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6B")]
		private bool hasToes;

		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool hasLegs;

		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6D")]
		private bool hasArms;

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector3[] readPositions;

		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Quaternion[] readRotations;

		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3[] solvedPositions;

		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Quaternion[] solvedRotations;

		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Vector3 rootV;

		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Vector3 rootVelocity;

		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3 bodyOffset;

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private int supportLegIndex;

		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private int lastLOD;

		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float lastLocomotionWeight;

		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[Range(0f, 2f)]
		[Tooltip("LOD 0: Full quality solving. LOD 1: Shoulder solving, stretching plant feet disabled, spine solving quality reduced. This provides about 30% of performance gain. LOD 2: Culled, but updating root position and rotation if locomotion is enabled.")]
		public int LOD;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		[Tooltip("Scale of the character. Value of 1 means normal adult human size.")]
		public float scale;

		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[Tooltip("If true, will keep the toes planted even if head target is out of reach, so this can cause the camera to exit the head if it is too high for the model to reach. Enabling this increases the cost of the solver as the legs will have to be solved multiple times.")]
		public bool plantFeet;

		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[Tooltip("The spine solver.")]
		public Spine spine;

		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[Tooltip("The left arm solver.")]
		public Arm leftArm;

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[Tooltip("The right arm solver.")]
		public Arm rightArm;

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[Tooltip("The left leg solver.")]
		public Leg leftLeg;

		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[Tooltip("The right leg solver.")]
		public Leg rightLeg;

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[Tooltip("Procedural leg shuffling for stationary VR games. Not designed for roomscale and thumbstick locomotion. For those it would be better to use a strafing locomotion blend tree to make the character follow the horizontal direction towards the HMD by root motion or script.")]
		public Locomotion locomotion;

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Leg[] legs;

		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Arm[] arms;

		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private Vector3 headPosition;

		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		private Vector3 headDeltaPosition;

		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector3 raycastOriginPelvis;

		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		private Vector3 lastOffset;

		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Vector3 debugPos1;

		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private Vector3 debugPos2;

		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private Vector3 debugPos3;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		private Vector3 debugPos4;

		[Token(Token = "0x17000080")]
		public Animator animator
		{
			[Token(Token = "0x600052F")]
			[Address(RVA = "0xF9B5C0", Offset = "0xF9B5C0", VA = "0xF9B5C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000530")]
			[Address(RVA = "0xF9B5C8", Offset = "0xF9B5C8", VA = "0xF9B5C8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000081")]
		[HideInInspector]
		public VirtualBone rootBone
		{
			[Token(Token = "0x6000548")]
			[Address(RVA = "0xF9F5D4", Offset = "0xF9F5D4", VA = "0xF9F5D4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000549")]
			[Address(RVA = "0xF9F5DC", Offset = "0xF9F5DC", VA = "0xF9F5DC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0xF9B5D0", Offset = "0xF9B5D0", VA = "0xF9B5D0")]
		public void SetToReferences(VRIK.References references)
		{
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0xF9BA9C", Offset = "0xF9BA9C", VA = "0xF9BA9C")]
		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero)
		{
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0xF9B930", Offset = "0xF9B930", VA = "0xF9B930")]
		public void DefaultAnimationCurves()
		{
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0xF9BEB0", Offset = "0xF9BEB0", VA = "0xF9BEB0")]
		public void AddPositionOffset(PositionOffset positionOffset, Vector3 value)
		{
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0xF9BFF8", Offset = "0xF9BFF8", VA = "0xF9BFF8")]
		public void AddRotationOffset(RotationOffset rotationOffset, Vector3 value)
		{
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0xF9C038", Offset = "0xF9C038", VA = "0xF9C038")]
		public void AddRotationOffset(RotationOffset rotationOffset, Quaternion value)
		{
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0xF9C15C", Offset = "0xF9C15C", VA = "0xF9C15C")]
		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot)
		{
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0xF9C238", Offset = "0xF9C238", VA = "0xF9C238")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0xF9CA3C", Offset = "0xF9CA3C", VA = "0xF9CA3C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0xF9CB90", Offset = "0xF9CB90", VA = "0xF9CB90", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0xF9CD7C", Offset = "0xF9CD7C", VA = "0xF9CD7C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0xF9CDEC", Offset = "0xF9CDEC", VA = "0xF9CDEC", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0xF9CE5C", Offset = "0xF9CE5C", VA = "0xF9CE5C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0xF9D064", Offset = "0xF9D064", VA = "0xF9D064")]
		private Vector3 GetNormal(Transform[] transforms)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0xF9BD9C", Offset = "0xF9BD9C", VA = "0xF9BD9C")]
		private static Keyframe[] GetSineKeyframes(float mag)
		{
			return null;
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0xF9C354", Offset = "0xF9C354", VA = "0xF9C354")]
		private void UpdateSolverTransforms()
		{
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0xF9D2D4", Offset = "0xF9D2D4", VA = "0xF9D2D4", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0xF9D318", Offset = "0xF9D318", VA = "0xF9D318", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0xF9EA28", Offset = "0xF9EA28", VA = "0xF9EA28")]
		private void WriteTransforms()
		{
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0xF9C4A4", Offset = "0xF9C4A4", VA = "0xF9C4A4")]
		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, bool hasArms)
		{
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0xF9D734", Offset = "0xF9D734", VA = "0xF9D734")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0xF9EE7C", Offset = "0xF9EE7C", VA = "0xF9EE7C")]
		private Vector3 GetPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0xF9EEB8", Offset = "0xF9EEB8", VA = "0xF9EEB8")]
		private Quaternion GetRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0xF9E8E4", Offset = "0xF9E8E4", VA = "0xF9E8E4")]
		private void Write()
		{
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0xF9EEF0", Offset = "0xF9EEF0", VA = "0xF9EEF0")]
		private Vector3 GetPelvisOffset(float deltaTime)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0xF9F5E4", Offset = "0xF9F5E4", VA = "0xF9F5E4")]
		public IKSolverVR()
		{
		}
	}
	[Token(Token = "0x20000AD")]
	public class TwistRelaxer : MonoBehaviour
	{
		[Token(Token = "0x40004D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IK ik;

		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("If using multiple solvers, add them in inverse hierarchical order - first forearm roll bone, then forearm bone and upper arm bone.")]
		public TwistSolver[] twistSolvers;

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0xFAE2EC", Offset = "0xFAE2EC", VA = "0xFAE2EC")]
		public void Start()
		{
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0xFAEA28", Offset = "0xFAEA28", VA = "0xFAEA28")]
		private void Update()
		{
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0xFAEB94", Offset = "0xFAEB94", VA = "0xFAEB94")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0xFAF128", Offset = "0xFAF128", VA = "0xFAF128")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0xFAF1D8", Offset = "0xFAF1D8", VA = "0xFAF1D8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0xFAF310", Offset = "0xFAF310", VA = "0xFAF310")]
		public TwistRelaxer()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000AE")]
	public class TwistSolver
	{
		[Token(Token = "0x40004D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Tooltip("The transform that this solver operates on.")]
		public Transform transform;

		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("If this is the forearm roll bone, the parent should be the forearm bone. If null, will be found automatically.")]
		public Transform parent;

		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("If this is the forearm roll bone, the child should be the hand bone. If null, will attempt to find automatically. Assign the hand manually if the hand bone is not a child of the roll bone.")]
		public Transform[] children;

		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The weight of relaxing the twist of this Transform")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("If 0.5, this Transform will be twisted half way from parent to child. If 1, the twist angle will be locked to the child and will rotate with along with it.")]
		[Range(0f, 1f)]
		public float parentChildCrossfade;

		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Range(-180f, 180f)]
		[Tooltip("Rotation offset around the twist axis.")]
		public float twistAngleOffset;

		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 twistAxis;

		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 axis;

		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 axisRelativeToParentDefault;

		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 axisRelativeToChildDefault;

		[Token(Token = "0x40004E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Quaternion[] childRotations;

		[Token(Token = "0x40004E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool inititated;

		[Token(Token = "0x40004E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x40004E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Quaternion[] defaultChildLocalRotations;

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0xFAF374", Offset = "0xFAF374", VA = "0xFAF374")]
		public TwistSolver()
		{
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0xFAE4D4", Offset = "0xFAE4D4", VA = "0xFAE4D4")]
		public void Initiate()
		{
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0xFAEAE8", Offset = "0xFAEAE8", VA = "0xFAEAE8")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0xFAEC44", Offset = "0xFAEC44", VA = "0xFAEC44")]
		public void Relax()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000AF")]
	public class InteractionEffector
	{
		[Token(Token = "0x40004EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Poser poser;

		[Token(Token = "0x40004EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IKEffector effector;

		[Token(Token = "0x40004EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float timer;

		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float length;

		[Token(Token = "0x40004EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float weight;

		[Token(Token = "0x40004EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float fadeInSpeed;

		[Token(Token = "0x40004F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float defaultPositionWeight;

		[Token(Token = "0x40004F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float defaultRotationWeight;

		[Token(Token = "0x40004F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float defaultPull;

		[Token(Token = "0x40004F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float defaultReach;

		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float defaultPush;

		[Token(Token = "0x40004F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float defaultPushParent;

		[Token(Token = "0x40004F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float defaultBendGoalWeight;

		[Token(Token = "0x40004F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float resetTimer;

		[Token(Token = "0x40004F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool positionWeightUsed;

		[Token(Token = "0x40004F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool rotationWeightUsed;

		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool pullUsed;

		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool reachUsed;

		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool pushUsed;

		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
		private bool pushParentUsed;

		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x66")]
		private bool bendGoalWeightUsed;

		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x67")]
		private bool pickedUp;

		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool defaults;

		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		private bool pickUpOnPostFBBIK;

		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 pausePositionRelative;

		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Quaternion pauseRotationRelative;

		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private InteractionTarget interactionTarget;

		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Transform target;

		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private List<bool> triggered;

		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x400050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private bool started;

		[Token(Token = "0x170000A3")]
		public FullBodyBipedEffector effectorType
		{
			[Token(Token = "0x60005E3")]
			[Address(RVA = "0xFAF4A4", Offset = "0xFAF4A4", VA = "0xFAF4A4")]
			[CompilerGenerated]
			get
			{
				return default(FullBodyBipedEffector);
			}
			[Token(Token = "0x60005E4")]
			[Address(RVA = "0xFAF4AC", Offset = "0xFAF4AC", VA = "0xFAF4AC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000A4")]
		public bool isPaused
		{
			[Token(Token = "0x60005E5")]
			[Address(RVA = "0xFAF4B4", Offset = "0xFAF4B4", VA = "0xFAF4B4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005E6")]
			[Address(RVA = "0xFAF4BC", Offset = "0xFAF4BC", VA = "0xFAF4BC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000A5")]
		public InteractionObject interactionObject
		{
			[Token(Token = "0x60005E7")]
			[Address(RVA = "0xFAF4C8", Offset = "0xFAF4C8", VA = "0xFAF4C8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60005E8")]
			[Address(RVA = "0xFAF4D0", Offset = "0xFAF4D0", VA = "0xFAF4D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000A6")]
		public bool inInteraction
		{
			[Token(Token = "0x60005E9")]
			[Address(RVA = "0xFAF4D8", Offset = "0xFAF4D8", VA = "0xFAF4D8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A7")]
		public float progress
		{
			[Token(Token = "0x60005F3")]
			[Address(RVA = "0xFB1070", Offset = "0xFB1070", VA = "0xFB1070")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0xFAF538", Offset = "0xFAF538", VA = "0xFAF538")]
		public InteractionEffector(FullBodyBipedEffector effectorType)
		{
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0xFAF5D4", Offset = "0xFAF5D4", VA = "0xFAF5D4")]
		public void Initiate(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0xFAF68C", Offset = "0xFAF68C", VA = "0xFAF68C")]
		private void StoreDefaults()
		{
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0xFAF7F8", Offset = "0xFAF7F8", VA = "0xFAF7F8")]
		public bool ResetToDefaults(float speed, float deltaTime)
		{
			return default(bool);
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0xFAFBD0", Offset = "0xFAFBD0", VA = "0xFAFBD0")]
		public bool Pause()
		{
			return default(bool);
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0xFAFCF0", Offset = "0xFAFCF0", VA = "0xFAFCF0")]
		public bool Resume()
		{
			return default(bool);
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0xFAFD44", Offset = "0xFAFD44", VA = "0xFAFD44")]
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0xFAFE60", Offset = "0xFAFE60", VA = "0xFAFE60")]
		public bool Start(InteractionObject interactionObject, InteractionTarget interactionTarget, float fadeInTime, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0xFB0310", Offset = "0xFB0310", VA = "0xFB0310")]
		public void Update(Transform root, float speed, float deltaTime)
		{
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0xFB0A60", Offset = "0xFB0A60", VA = "0xFB0A60")]
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause)
		{
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0xFB0C84", Offset = "0xFB0C84", VA = "0xFB0C84")]
		private void PickUp(Transform root)
		{
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0xFB0F54", Offset = "0xFB0F54", VA = "0xFB0F54")]
		public bool Stop()
		{
			return default(bool);
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0xFB10A0", Offset = "0xFB10A0", VA = "0xFB10A0")]
		public void OnPostFBBIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B0")]
	public class InteractionLookAt
	{
		[Token(Token = "0x400050B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Tooltip("(Optional) reference to the LookAtIK component that will be used to make the character look at the objects that it is interacting with.")]
		public LookAtIK ik;

		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Interpolation speed of the LookAtIK target.")]
		public float lerpSpeed;

		[Token(Token = "0x400050D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("Interpolation speed of the LookAtIK weight.")]
		public float weightSpeed;

		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public bool isPaused;

		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform lookAtTarget;

		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float stopLookTime;

		[Token(Token = "0x4000511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float weight;

		[Token(Token = "0x4000512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool firstFBBIKSolve;

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0xFB1370", Offset = "0xFB1370", VA = "0xFB1370")]
		public void Look(Transform target, float time)
		{
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0xFB148C", Offset = "0xFB148C", VA = "0xFB148C")]
		public void OnFixTransforms()
		{
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0xFB1524", Offset = "0xFB1524", VA = "0xFB1524")]
		public void Update()
		{
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0xFB172C", Offset = "0xFB172C", VA = "0xFB172C")]
		public void SolveSpine()
		{
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0xFB17D4", Offset = "0xFB17D4", VA = "0xFB17D4")]
		public void SolveHead()
		{
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0xFB1880", Offset = "0xFB1880", VA = "0xFB1880")]
		public InteractionLookAt()
		{
		}
	}
	[Token(Token = "0x20000B1")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction Object")]
	[HelpURL("https://www.youtube.com/watch?v=r5jiZnsDH3M")]
	public class InteractionObject : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000B2")]
		public class InteractionEvent
		{
			[Token(Token = "0x400051C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The time of the event since interaction start.")]
			public float time;

			[Token(Token = "0x400051D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("If true, the interaction will be paused on this event. The interaction can be resumed by InteractionSystem.ResumeInteraction() or InteractionSystem.ResumeAll;")]
			public bool pause;

			[Token(Token = "0x400051E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
			[Tooltip("If true, the object will be parented to the effector bone on this event. Note that picking up like this can be done by only a single effector at a time. If you wish to pick up an object with both hands, see the Interaction PickUp2Handed demo scene.")]
			public bool pickUp;

			[Token(Token = "0x400051F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The animations called on this event.")]
			public AnimatorEvent[] animations;

			[Token(Token = "0x4000520")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("The messages sent on this event using GameObject.SendMessage().")]
			public Message[] messages;

			[Token(Token = "0x4000521")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("The UnityEvent to invoke on this event.")]
			public UnityEvent unityEvent;

			[Token(Token = "0x600061A")]
			[Address(RVA = "0xFB2E58", Offset = "0xFB2E58", VA = "0xFB2E58")]
			public void Activate(Transform t)
			{
			}

			[Token(Token = "0x600061B")]
			[Address(RVA = "0xFB30F0", Offset = "0xFB30F0", VA = "0xFB30F0")]
			public InteractionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000B3")]
		public class Message
		{
			[Token(Token = "0x4000522")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The name of the function called.")]
			public string function;

			[Token(Token = "0x4000523")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The recipient game object.")]
			public GameObject recipient;

			[Token(Token = "0x4000524")]
			private const string empty = "";

			[Token(Token = "0x600061C")]
			[Address(RVA = "0xFB2FF8", Offset = "0xFB2FF8", VA = "0xFB2FF8")]
			public void Send(Transform t)
			{
			}

			[Token(Token = "0x600061D")]
			[Address(RVA = "0xFB30F8", Offset = "0xFB30F8", VA = "0xFB30F8")]
			public Message()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000B4")]
		public class AnimatorEvent
		{
			[Token(Token = "0x4000525")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The Animator component that will receive the AnimatorEvents.")]
			public Animator animator;

			[Token(Token = "0x4000526")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The Animation component that will receive the AnimatorEvents (Legacy).")]
			public Animation animation;

			[Token(Token = "0x4000527")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("The name of the animation state.")]
			public string animationState;

			[Token(Token = "0x4000528")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("The crossfading time.")]
			public float crossfadeTime;

			[Token(Token = "0x4000529")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("The layer of the animation state (if using Legacy, the animation state will be forced to this layer).")]
			public int layer;

			[Token(Token = "0x400052A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("Should the animation always start from 0 normalized time?")]
			public bool resetNormalizedTime;

			[Token(Token = "0x400052B")]
			private const string empty = "";

			[Token(Token = "0x600061E")]
			[Address(RVA = "0xFB2F1C", Offset = "0xFB2F1C", VA = "0xFB2F1C")]
			public void Activate(bool pickUp)
			{
			}

			[Token(Token = "0x600061F")]
			[Address(RVA = "0xFB3100", Offset = "0xFB3100", VA = "0xFB3100")]
			private void Activate(Animator animator)
			{
			}

			[Token(Token = "0x6000620")]
			[Address(RVA = "0xFB31B0", Offset = "0xFB31B0", VA = "0xFB31B0")]
			private void Activate(Animation animation)
			{
			}

			[Token(Token = "0x6000621")]
			[Address(RVA = "0xFB3288", Offset = "0xFB3288", VA = "0xFB3288")]
			public AnimatorEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000B5")]
		public class WeightCurve
		{
			[Serializable]
			[Token(Token = "0x20000B6")]
			public enum Type
			{
				[Token(Token = "0x400052F")]
				PositionWeight,
				[Token(Token = "0x4000530")]
				RotationWeight,
				[Token(Token = "0x4000531")]
				PositionOffsetX,
				[Token(Token = "0x4000532")]
				PositionOffsetY,
				[Token(Token = "0x4000533")]
				PositionOffsetZ,
				[Token(Token = "0x4000534")]
				Pull,
				[Token(Token = "0x4000535")]
				Reach,
				[Token(Token = "0x4000536")]
				RotateBoneWeight,
				[Token(Token = "0x4000537")]
				Push,
				[Token(Token = "0x4000538")]
				PushParent,
				[Token(Token = "0x4000539")]
				PoserWeight,
				[Token(Token = "0x400053A")]
				BendGoalWeight
			}

			[Token(Token = "0x400052C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The type of the curve (InteractionObject.WeightCurve.Type).")]
			public Type type;

			[Token(Token = "0x400052D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The weight curve.")]
			public AnimationCurve curve;

			[Token(Token = "0x6000622")]
			[Address(RVA = "0xFB2584", Offset = "0xFB2584", VA = "0xFB2584")]
			public float GetValue(float timer)
			{
				return default(float);
			}

			[Token(Token = "0x6000623")]
			[Address(RVA = "0xFB329C", Offset = "0xFB329C", VA = "0xFB329C")]
			public WeightCurve()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000B7")]
		public class Multiplier
		{
			[Token(Token = "0x400053B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The curve type to multiply.")]
			public WeightCurve.Type curve;

			[Token(Token = "0x400053C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("The multiplier of the curve's value.")]
			public float multiplier;

			[Token(Token = "0x400053D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The resulting value will be applied to this channel.")]
			public WeightCurve.Type result;

			[Token(Token = "0x6000624")]
			[Address(RVA = "0xFB2B58", Offset = "0xFB2B58", VA = "0xFB2B58")]
			public float GetValue(WeightCurve weightCurve, float timer)
			{
				return default(float);
			}

			[Token(Token = "0x6000625")]
			[Address(RVA = "0xFB32A4", Offset = "0xFB32A4", VA = "0xFB32A4")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x4000513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("If the Interaction System has a 'Look At' LookAtIK component assigned, will use it to make the character look at the specified Transform. If unassigned, will look at this GameObject.")]
		public Transform otherLookAtTarget;

		[Token(Token = "0x4000514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The root Transform of the InteractionTargets. If null, will use this GameObject. GetComponentsInChildren<InteractionTarget>() will be used at initiation to find all InteractionTargets associated with this InteractionObject.")]
		public Transform otherTargetsRoot;

		[Token(Token = "0x4000515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("If assigned, all PositionOffset channels will be applied in the rotation space of this Transform. If not, they will be in the rotation space of the character.")]
		public Transform positionOffsetSpace;

		[Token(Token = "0x4000516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public WeightCurve[] weightCurves;

		[Token(Token = "0x4000517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Multiplier[] multipliers;

		[Token(Token = "0x4000518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionEvent[] events;

		[Token(Token = "0x400051B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private InteractionTarget[] targets;

		[Token(Token = "0x170000A8")]
		public float length
		{
			[Token(Token = "0x6000606")]
			[Address(RVA = "0xFB1AB4", Offset = "0xFB1AB4", VA = "0xFB1AB4")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000607")]
			[Address(RVA = "0xFB1ABC", Offset = "0xFB1ABC", VA = "0xFB1ABC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000A9")]
		public InteractionSystem lastUsedInteractionSystem
		{
			[Token(Token = "0x6000608")]
			[Address(RVA = "0xFB1AC4", Offset = "0xFB1AC4", VA = "0xFB1AC4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000609")]
			[Address(RVA = "0xFB1ACC", Offset = "0xFB1ACC", VA = "0xFB1ACC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000AA")]
		public Transform lookAtTarget
		{
			[Token(Token = "0x600060B")]
			[Address(RVA = "0xFB1D0C", Offset = "0xFB1D0C", VA = "0xFB1D0C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AB")]
		public Transform targetsRoot
		{
			[Token(Token = "0x6000613")]
			[Address(RVA = "0xFB1C8C", Offset = "0xFB1C8C", VA = "0xFB1C8C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0xFB1894", Offset = "0xFB1894", VA = "0xFB1894")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0xFB18D8", Offset = "0xFB18D8", VA = "0xFB18D8")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0xFB191C", Offset = "0xFB191C", VA = "0xFB191C")]
		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0xFB1960", Offset = "0xFB1960", VA = "0xFB1960")]
		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0xFB19A4", Offset = "0xFB19A4", VA = "0xFB19A4")]
		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x6000603")]
		[Address(RVA = "0xFB19E8", Offset = "0xFB19E8", VA = "0xFB19E8")]
		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0xFB1A2C", Offset = "0xFB1A2C", VA = "0xFB1A2C")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0xFB1A70", Offset = "0xFB1A70", VA = "0xFB1A70")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0xFB1AD4", Offset = "0xFB1AD4", VA = "0xFB1AD4")]
		public void Initiate()
		{
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0xFB1D8C", Offset = "0xFB1D8C", VA = "0xFB1D8C")]
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem)
		{
			return null;
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0xFB1EDC", Offset = "0xFB1EDC", VA = "0xFB1EDC")]
		public bool CurveUsed(WeightCurve.Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x600060E")]
		[Address(RVA = "0xFB1F70", Offset = "0xFB1F70", VA = "0xFB1F70")]
		public InteractionTarget[] GetTargets()
		{
			return null;
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0xFB1F78", Offset = "0xFB1F78", VA = "0xFB1F78")]
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag)
		{
			return null;
		}

		[Token(Token = "0x6000610")]
		[Address(RVA = "0xFB2110", Offset = "0xFB2110", VA = "0xFB2110")]
		public void OnStartInteraction(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0xFB2118", Offset = "0xFB2118", VA = "0xFB2118")]
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight)
		{
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0xFB2B88", Offset = "0xFB2B88", VA = "0xFB2B88")]
		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer)
		{
			return default(float);
		}

		[Token(Token = "0x6000614")]
		[Address(RVA = "0xFB2D94", Offset = "0xFB2D94", VA = "0xFB2D94")]
		private void Start()
		{
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0xFB25A0", Offset = "0xFB25A0", VA = "0xFB25A0")]
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight)
		{
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0xFB20AC", Offset = "0xFB20AC", VA = "0xFB20AC")]
		private Transform GetTarget(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0xFB2AFC", Offset = "0xFB2AFC", VA = "0xFB2AFC")]
		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0xFB2D98", Offset = "0xFB2D98", VA = "0xFB2D98")]
		private int GetMultiplierIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0xFB2DF4", Offset = "0xFB2DF4", VA = "0xFB2DF4")]
		public InteractionObject()
		{
		}
	}
	[Token(Token = "0x20000B8")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction System")]
	[HelpURL("https://www.youtube.com/watch?v=r5jiZnsDH3M")]
	public class InteractionSystem : MonoBehaviour
	{
		[Token(Token = "0x20000B9")]
		public delegate void InteractionDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject);

		[Token(Token = "0x20000BA")]
		public delegate void InteractionEventDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent);

		[Token(Token = "0x400053E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("If not empty, only the targets with the specified tag will be used by this Interaction System.")]
		public string targetTag;

		[Token(Token = "0x400053F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The fade in time of the interaction.")]
		public float fadeInTime;

		[Token(Token = "0x4000540")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("The master speed for all interactions.")]
		public float speed;

		[Token(Token = "0x4000541")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("If > 0, lerps all the FBBIK channels used by the Interaction System back to their default or initial values when not in interaction.")]
		public float resetToDefaultsSpeed;

		[Token(Token = "0x4000542")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The collider that registers OnTriggerEnter and OnTriggerExit events with InteractionTriggers.")]
		[Header("Triggering")]
		[FormerlySerializedAs("collider")]
		public Collider characterCollider;

		[Token(Token = "0x4000543")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Will be used by Interaction Triggers that need the camera's position. Assign the first person view character camera.")]
		[FormerlySerializedAs("camera")]
		public Transform FPSCamera;

		[Token(Token = "0x4000544")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The layers that will be raycasted from the camera (along camera.forward). All InteractionTrigger look at target colliders should be included.")]
		public LayerMask camRaycastLayers;

		[Token(Token = "0x4000545")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Tooltip("Max distance of raycasting from the camera.")]
		public float camRaycastDistance;

		[Token(Token = "0x4000547")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<InteractionTrigger> inContact;

		[Token(Token = "0x4000548")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<int> bestRangeIndexes;

		[Token(Token = "0x4000549")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public InteractionDelegate OnInteractionStart;

		[Token(Token = "0x400054A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public InteractionDelegate OnInteractionPause;

		[Token(Token = "0x400054B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public InteractionDelegate OnInteractionPickUp;

		[Token(Token = "0x400054C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public InteractionDelegate OnInteractionResume;

		[Token(Token = "0x400054D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public InteractionDelegate OnInteractionStop;

		[Token(Token = "0x400054E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public InteractionEventDelegate OnInteractionEvent;

		[Token(Token = "0x400054F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public RaycastHit raycastHit;

		[Token(Token = "0x4000550")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Space(10f)]
		[Tooltip("Reference to the FBBIK component.")]
		private FullBodyBipedIK fullBody;

		[Token(Token = "0x4000551")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[Tooltip("Handles looking at the interactions.")]
		public InteractionLookAt lookAt;

		[Token(Token = "0x4000552")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private InteractionEffector[] interactionEffectors;

		[Token(Token = "0x4000554")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Collider lastCollider;

		[Token(Token = "0x4000555")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Collider c;

		[Token(Token = "0x4000556")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private float lastTime;

		[Token(Token = "0x170000AC")]
		public bool inInteraction
		{
			[Token(Token = "0x600062E")]
			[Address(RVA = "0xFB34D4", Offset = "0xFB34D4", VA = "0xFB34D4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000AD")]
		public FullBodyBipedIK ik
		{
			[Token(Token = "0x6000649")]
			[Address(RVA = "0xFB5080", Offset = "0xFB5080", VA = "0xFB5080")]
			get
			{
				return null;
			}
			[Token(Token = "0x600064A")]
			[Address(RVA = "0xFB5088", Offset = "0xFB5088", VA = "0xFB5088")]
			set
			{
			}
		}

		[Token(Token = "0x170000AE")]
		public List<InteractionTrigger> triggersInRange
		{
			[Token(Token = "0x600064B")]
			[Address(RVA = "0xFB5090", Offset = "0xFB5090", VA = "0xFB5090")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600064C")]
			[Address(RVA = "0xFB5098", Offset = "0xFB5098", VA = "0xFB5098")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000AF")]
		public bool initiated
		{
			[Token(Token = "0x600064D")]
			[Address(RVA = "0xFB50A0", Offset = "0xFB50A0", VA = "0xFB50A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600064E")]
			[Address(RVA = "0xFB50A8", Offset = "0xFB50A8", VA = "0xFB50A8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0xFB32B4", Offset = "0xFB32B4", VA = "0xFB32B4")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0xFB32F8", Offset = "0xFB32F8", VA = "0xFB32F8")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0xFB333C", Offset = "0xFB333C", VA = "0xFB333C")]
		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x6000629")]
		[Address(RVA = "0xFB3380", Offset = "0xFB3380", VA = "0xFB3380")]
		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x600062A")]
		[Address(RVA = "0xFB33C4", Offset = "0xFB33C4", VA = "0xFB33C4")]
		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x600062B")]
		[Address(RVA = "0xFB3408", Offset = "0xFB3408", VA = "0xFB3408")]
		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x600062C")]
		[Address(RVA = "0xFB344C", Offset = "0xFB344C", VA = "0xFB344C")]
		[ContextMenu("Support")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600062D")]
		[Address(RVA = "0xFB3490", Offset = "0xFB3490", VA = "0xFB3490")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600062F")]
		[Address(RVA = "0xFB3650", Offset = "0xFB3650", VA = "0xFB3650")]
		public bool IsInInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000630")]
		[Address(RVA = "0xFB370C", Offset = "0xFB370C", VA = "0xFB370C")]
		public bool IsPaused(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0xFB37C8", Offset = "0xFB37C8", VA = "0xFB37C8")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0xFB3864", Offset = "0xFB3864", VA = "0xFB3864")]
		public bool IsInSync()
		{
			return default(bool);
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0xFB394C", Offset = "0xFB394C", VA = "0xFB394C")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0xFB3A48", Offset = "0xFB3A48", VA = "0xFB3A48")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionTarget target, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0xFB3B54", Offset = "0xFB3B54", VA = "0xFB3B54")]
		public bool PauseInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0xFB3BDC", Offset = "0xFB3BDC", VA = "0xFB3BDC")]
		public bool ResumeInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0xFB3C64", Offset = "0xFB3C64", VA = "0xFB3C64")]
		public bool StopInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0xFB3CEC", Offset = "0xFB3CEC", VA = "0xFB3CEC")]
		public void PauseAll()
		{
		}

		[Token(Token = "0x6000639")]
		[Address(RVA = "0xFB3D58", Offset = "0xFB3D58", VA = "0xFB3D58")]
		public void ResumeAll()
		{
		}

		[Token(Token = "0x600063A")]
		[Address(RVA = "0xFB3DC4", Offset = "0xFB3DC4", VA = "0xFB3DC4")]
		public void StopAll()
		{
		}

		[Token(Token = "0x600063B")]
		[Address(RVA = "0xFB3E24", Offset = "0xFB3E24", VA = "0xFB3E24")]
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x600063C")]
		[Address(RVA = "0xFB3EA4", Offset = "0xFB3EA4", VA = "0xFB3EA4")]
		public float GetProgress(FullBodyBipedEffector effectorType)
		{
			return default(float);
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0xFB3F2C", Offset = "0xFB3F2C", VA = "0xFB3F2C")]
		public float GetMinActiveProgress()
		{
			return default(float);
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0xFB3FE4", Offset = "0xFB3FE4", VA = "0xFB3FE4")]
		public bool TriggerInteraction(int index, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0xFB4274", Offset = "0xFB4274", VA = "0xFB4274")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject)
		{
			return default(bool);
		}

		[Token(Token = "0x6000640")]
		[Address(RVA = "0xFB4448", Offset = "0xFB4448", VA = "0xFB4448")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget)
		{
			return default(bool);
		}

		[Token(Token = "0x6000641")]
		[Address(RVA = "0xFB46B8", Offset = "0xFB46B8", VA = "0xFB46B8")]
		public InteractionTrigger.Range GetClosestInteractionRange()
		{
			return null;
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0xFB4944", Offset = "0xFB4944", VA = "0xFB4944")]
		public InteractionObject GetClosestInteractionObjectInRange()
		{
			return null;
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0xFB497C", Offset = "0xFB497C", VA = "0xFB497C")]
		public InteractionTarget GetClosestInteractionTargetInRange()
		{
			return null;
		}

		[Token(Token = "0x6000644")]
		[Address(RVA = "0xFB49DC", Offset = "0xFB49DC", VA = "0xFB49DC")]
		public InteractionObject[] GetClosestInteractionObjectsInRange()
		{
			return null;
		}

		[Token(Token = "0x6000645")]
		[Address(RVA = "0xFB4B08", Offset = "0xFB4B08", VA = "0xFB4B08")]
		public InteractionTarget[] GetClosestInteractionTargetsInRange()
		{
			return null;
		}

		[Token(Token = "0x6000646")]
		[Address(RVA = "0xFB4CEC", Offset = "0xFB4CEC", VA = "0xFB4CEC")]
		public bool TriggerEffectorsReady(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000647")]
		[Address(RVA = "0xFB4F60", Offset = "0xFB4F60", VA = "0xFB4F60")]
		public InteractionTrigger.Range GetTriggerRange(int index)
		{
			return null;
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0xFB47A0", Offset = "0xFB47A0", VA = "0xFB47A0")]
		public int GetClosestTriggerIndex()
		{
			return default(int);
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0xFB50B4", Offset = "0xFB50B4", VA = "0xFB50B4")]
		public void Start()
		{
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0xFB59DC", Offset = "0xFB59DC", VA = "0xFB59DC")]
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0xFB59FC", Offset = "0xFB59FC", VA = "0xFB59FC")]
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0xFB5A18", Offset = "0xFB5A18", VA = "0xFB5A18")]
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0xFB5A34", Offset = "0xFB5A34", VA = "0xFB5A34")]
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0xFB5A88", Offset = "0xFB5A88", VA = "0xFB5A88")]
		public void OnTriggerEnter(Collider c)
		{
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0xFB5C0C", Offset = "0xFB5C0C", VA = "0xFB5C0C")]
		public void OnTriggerExit(Collider c)
		{
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0xFB5D08", Offset = "0xFB5D08", VA = "0xFB5D08")]
		private bool ContactIsInRange(int index, out int bestRangeIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x6000657")]
		[Address(RVA = "0xFB6064", Offset = "0xFB6064", VA = "0xFB6064")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000658")]
		[Address(RVA = "0xFB617C", Offset = "0xFB617C", VA = "0xFB617C")]
		public void Update()
		{
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0xFB6440", Offset = "0xFB6440", VA = "0xFB6440")]
		private void Raycasting()
		{
		}

		[Token(Token = "0x600065A")]
		[Address(RVA = "0xFB577C", Offset = "0xFB577C", VA = "0xFB577C")]
		private void UpdateTriggerEventBroadcasting()
		{
		}

		[Token(Token = "0x600065B")]
		[Address(RVA = "0xFB6570", Offset = "0xFB6570", VA = "0xFB6570")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0xFB658C", Offset = "0xFB658C", VA = "0xFB658C")]
		private void UpdateEffectors()
		{
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0xFB66D0", Offset = "0xFB66D0", VA = "0xFB66D0")]
		private void OnPreFBBIK()
		{
		}

		[Token(Token = "0x600065E")]
		[Address(RVA = "0xFB6758", Offset = "0xFB6758", VA = "0xFB6758")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x600065F")]
		[Address(RVA = "0xFB681C", Offset = "0xFB681C", VA = "0xFB681C")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000660")]
		[Address(RVA = "0xFB6834", Offset = "0xFB6834", VA = "0xFB6834")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000661")]
		[Address(RVA = "0xFB3570", Offset = "0xFB3570", VA = "0xFB3570")]
		private bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x6000662")]
		[Address(RVA = "0xFB4160", Offset = "0xFB4160", VA = "0xFB4160")]
		private bool TriggerIndexIsValid(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000663")]
		[Address(RVA = "0xFB6CAC", Offset = "0xFB6CAC", VA = "0xFB6CAC")]
		public InteractionSystem()
		{
		}
	}
	[Token(Token = "0x20000BB")]
	[HelpURL("https://www.youtube.com/watch?v=r5jiZnsDH3M")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction Target")]
	public class InteractionTarget : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000BC")]
		public enum RotationMode
		{
			[Token(Token = "0x4000564")]
			TwoDOF,
			[Token(Token = "0x4000565")]
			ThreeDOF
		}

		[Serializable]
		[Token(Token = "0x20000BD")]
		public class Multiplier
		{
			[Token(Token = "0x4000566")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The curve type (InteractionObject.WeightCurve.Type).")]
			public InteractionObject.WeightCurve.Type curve;

			[Token(Token = "0x4000567")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("Multiplier of the curve's value.")]
			public float multiplier;

			[Token(Token = "0x6000678")]
			[Address(RVA = "0xFB7CC0", Offset = "0xFB7CC0", VA = "0xFB7CC0")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x4000557")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The type of the FBBIK effector.")]
		public FullBodyBipedEffector effectorType;

		[Token(Token = "0x4000558")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("InteractionObject weight curve multipliers for this effector target.")]
		public Multiplier[] multipliers;

		[Token(Token = "0x4000559")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The interaction speed multiplier for this effector. This can be used to make interactions faster/slower for specific effectors.")]
		public float interactionSpeedMlp;

		[Token(Token = "0x400055A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The pivot to twist/swing this interaction target about. For symmetric objects that can be interacted with from a certain angular range.")]
		public Transform pivot;

		[Token(Token = "0x400055B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("2 or 3 degrees of freedom to match this InteractionTarget's rotation to the effector bone rotation.")]
		public RotationMode rotationMode;

		[Token(Token = "0x400055C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("The axis of twisting the interaction target (blue line).")]
		public Vector3 twistAxis;

		[Token(Token = "0x400055D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("The weight of twisting the interaction target towards the effector bone in the start of the interaction.")]
		public float twistWeight;

		[Token(Token = "0x400055E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("The weight of swinging the interaction target towards the effector bone in the start of the interaction. Swing is defined as a 3-DOF rotation around any axis, while twist is only around the twist axis.")]
		public float swingWeight;

		[Token(Token = "0x400055F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Range(0f, 1f)]
		[Tooltip("The weight of rotating this InteractionTarget to the effector bone in the start of the interaction (and during if 'Rotate Once' is disabled")]
		public float threeDOFWeight;

		[Token(Token = "0x4000560")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Tooltip("If true, will twist/swing around the pivot only once at the start of the interaction. If false, will continue rotating throuout the whole interaction.")]
		public bool rotateOnce;

		[Token(Token = "0x4000561")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x4000562")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform lastPivot;

		[Token(Token = "0x600066C")]
		[Address(RVA = "0xFB7358", Offset = "0xFB7358", VA = "0xFB7358")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600066D")]
		[Address(RVA = "0xFB739C", Offset = "0xFB739C", VA = "0xFB739C")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600066E")]
		[Address(RVA = "0xFB73E0", Offset = "0xFB73E0", VA = "0xFB73E0")]
		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x600066F")]
		[Address(RVA = "0xFB7424", Offset = "0xFB7424", VA = "0xFB7424")]
		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0xFB7468", Offset = "0xFB7468", VA = "0xFB7468")]
		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0xFB74AC", Offset = "0xFB74AC", VA = "0xFB74AC")]
		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0xFB74F0", Offset = "0xFB74F0", VA = "0xFB74F0")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0xFB7534", Offset = "0xFB7534", VA = "0xFB7534")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0xFB2520", Offset = "0xFB2520", VA = "0xFB2520")]
		public float GetValue(InteractionObject.WeightCurve.Type curveType)
		{
			return default(float);
		}

		[Token(Token = "0x6000675")]
		[Address(RVA = "0xFB7578", Offset = "0xFB7578", VA = "0xFB7578")]
		public void ResetRotation()
		{
		}

		[Token(Token = "0x6000676")]
		[Address(RVA = "0xFB7604", Offset = "0xFB7604", VA = "0xFB7604")]
		public void RotateTo(Transform bone)
		{
		}

		[Token(Token = "0x6000677")]
		[Address(RVA = "0xFB7C4C", Offset = "0xFB7C4C", VA = "0xFB7C4C")]
		public InteractionTarget()
		{
		}
	}
	[Token(Token = "0x20000BE")]
	[HelpURL("https://www.youtube.com/watch?v=-TDZpNjt2mk&index=15&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction Trigger")]
	public class InteractionTrigger : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000BF")]
		public class CharacterPosition
		{
			[Token(Token = "0x4000569")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("If false, will not care where the character stands, as long as it is in contact with the trigger collider.")]
			public bool use;

			[Token(Token = "0x400056A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("The offset of the character's position relative to the trigger in XZ plane. Y position of the character is unlimited as long as it is contact with the collider.")]
			public Vector2 offset;

			[Token(Token = "0x400056B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[Range(-180f, 180f)]
			[Tooltip("Angle offset from the default forward direction.")]
			public float angleOffset;

			[Token(Token = "0x400056C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Max angular offset of the character's forward from the direction of this trigger.")]
			[Range(0f, 180f)]
			public float maxAngle;

			[Token(Token = "0x400056D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[Tooltip("Max offset of the character's position from this range's center.")]
			public float radius;

			[Token(Token = "0x400056E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("If true, will rotate the trigger around its Y axis relative to the position of the character, so the object can be interacted with from all sides.")]
			public bool orbit;

			[Token(Token = "0x400056F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
			[Tooltip("Fixes the Y axis of the trigger to Vector3.up. This makes the trigger symmetrical relative to the object. For example a gun will be able to be picked up from the same direction relative to the barrel no matter which side the gun is resting on.")]
			public bool fixYAxis;

			[Token(Token = "0x170000B0")]
			public Vector3 offset3D
			{
				[Token(Token = "0x6000680")]
				[Address(RVA = "0xFB7F30", Offset = "0xFB7F30", VA = "0xFB7F30")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000B1")]
			public Vector3 direction3D
			{
				[Token(Token = "0x6000681")]
				[Address(RVA = "0xFB7F3C", Offset = "0xFB7F3C", VA = "0xFB7F3C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x6000682")]
			[Address(RVA = "0xFB7FFC", Offset = "0xFB7FFC", VA = "0xFB7FFC")]
			public bool IsInRange(Transform character, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x6000683")]
			[Address(RVA = "0xFB8760", Offset = "0xFB8760", VA = "0xFB8760")]
			public CharacterPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000C0")]
		public class CameraPosition
		{
			[Token(Token = "0x4000570")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("What the camera should be looking at to trigger the interaction? If null, this camera position will not be used.")]
			public Collider lookAtTarget;

			[Token(Token = "0x4000571")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The direction from the lookAtTarget towards the camera (in lookAtTarget's space).")]
			public Vector3 direction;

			[Token(Token = "0x4000572")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[Tooltip("Max distance from the lookAtTarget to the camera.")]
			public float maxDistance;

			[Token(Token = "0x4000573")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Max angle between the direction and the direction towards the camera.")]
			[Range(0f, 180f)]
			public float maxAngle;

			[Token(Token = "0x4000574")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("Fixes the Y axis of the trigger to Vector3.up. This makes the trigger symmetrical relative to the object.")]
			public bool fixYAxis;

			[Token(Token = "0x6000684")]
			[Address(RVA = "0xFB8774", Offset = "0xFB8774", VA = "0xFB8774")]
			public Quaternion GetRotation()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000685")]
			[Address(RVA = "0xFB88EC", Offset = "0xFB88EC", VA = "0xFB88EC")]
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x6000686")]
			[Address(RVA = "0xFB8BF4", Offset = "0xFB8BF4", VA = "0xFB8BF4")]
			public CameraPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000C1")]
		public class Range
		{
			[Serializable]
			[Token(Token = "0x20000C2")]
			public class Interaction
			{
				[Token(Token = "0x400057A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("The InteractionObject to interact with.")]
				public InteractionObject interactionObject;

				[Token(Token = "0x400057B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[Tooltip("The effectors to interact with.")]
				public FullBodyBipedEffector[] effectors;

				[Token(Token = "0x6000689")]
				[Address(RVA = "0xFB8C78", Offset = "0xFB8C78", VA = "0xFB8C78")]
				public Interaction()
				{
				}
			}

			[Token(Token = "0x4000575")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[HideInInspector]
			public string name;

			[Token(Token = "0x4000576")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public bool show;

			[Token(Token = "0x4000577")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("The range for the character's position and rotation.")]
			public CharacterPosition characterPosition;

			[Token(Token = "0x4000578")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("The range for the character camera's position and rotation.")]
			public CameraPosition cameraPosition;

			[Token(Token = "0x4000579")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("Definitions of the interactions associated with this range.")]
			public Interaction[] interactions;

			[Token(Token = "0x6000687")]
			[Address(RVA = "0xFB7E1C", Offset = "0xFB7E1C", VA = "0xFB7E1C")]
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError)
			{
				return default(bool);
			}

			[Token(Token = "0x6000688")]
			[Address(RVA = "0xFB8C68", Offset = "0xFB8C68", VA = "0xFB8C68")]
			public Range()
			{
			}
		}

		[Token(Token = "0x4000568")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The valid ranges of the character's and/or its camera's position for triggering interaction when the character is in contact with the collider of this trigger.")]
		public Range[] ranges;

		[Token(Token = "0x6000679")]
		[Address(RVA = "0xFB7CC8", Offset = "0xFB7CC8", VA = "0xFB7CC8")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600067A")]
		[Address(RVA = "0xFB7D0C", Offset = "0xFB7D0C", VA = "0xFB7D0C")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600067B")]
		[Address(RVA = "0xFB7D50", Offset = "0xFB7D50", VA = "0xFB7D50")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0xFB7D94", Offset = "0xFB7D94", VA = "0xFB7D94")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600067D")]
		[Address(RVA = "0xFB7DD8", Offset = "0xFB7DD8", VA = "0xFB7DD8")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0xFB5EB0", Offset = "0xFB5EB0", VA = "0xFB5EB0")]
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit)
		{
			return default(int);
		}

		[Token(Token = "0x600067F")]
		[Address(RVA = "0xFB7ECC", Offset = "0xFB7ECC", VA = "0xFB7ECC")]
		public InteractionTrigger()
		{
		}
	}
	[Token(Token = "0x20000C3")]
	public class GenericPoser : Poser
	{
		[Serializable]
		[Token(Token = "0x20000C4")]
		public class Map
		{
			[Token(Token = "0x400057D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform bone;

			[Token(Token = "0x400057E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform target;

			[Token(Token = "0x400057F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Vector3 defaultLocalPosition;

			[Token(Token = "0x4000580")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x6000691")]
			[Address(RVA = "0xFB8F78", Offset = "0xFB8F78", VA = "0xFB8F78")]
			public Map(Transform bone, Transform target)
			{
			}

			[Token(Token = "0x6000692")]
			[Address(RVA = "0xFB92D0", Offset = "0xFB92D0", VA = "0xFB92D0")]
			public void StoreDefaultState()
			{
			}

			[Token(Token = "0x6000693")]
			[Address(RVA = "0xFB9290", Offset = "0xFB9290", VA = "0xFB9290")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x6000694")]
			[Address(RVA = "0xFB9114", Offset = "0xFB9114", VA = "0xFB9114")]
			public void Update(float localRotationWeight, float localPositionWeight)
			{
			}
		}

		[Token(Token = "0x400057C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Map[] maps;

		[Token(Token = "0x600068A")]
		[Address(RVA = "0xFB8C80", Offset = "0xFB8C80", VA = "0xFB8C80", Slot = "7")]
		[ContextMenu("Auto-Mapping")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0xFB9020", Offset = "0xFB9020", VA = "0xFB9020", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x600068C")]
		[Address(RVA = "0xFB9024", Offset = "0xFB9024", VA = "0xFB9024", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x600068D")]
		[Address(RVA = "0xFB9234", Offset = "0xFB9234", VA = "0xFB9234", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x600068E")]
		[Address(RVA = "0xFB8FC4", Offset = "0xFB8FC4", VA = "0xFB8FC4")]
		private void StoreDefaultState()
		{
		}

		[Token(Token = "0x600068F")]
		[Address(RVA = "0xFB8EE4", Offset = "0xFB8EE4", VA = "0xFB8EE4")]
		private Transform GetTargetNamed(string tName, Transform[] array)
		{
			return null;
		}

		[Token(Token = "0x6000690")]
		[Address(RVA = "0xFB9314", Offset = "0xFB9314", VA = "0xFB9314")]
		public GenericPoser()
		{
		}
	}
	[Token(Token = "0x20000C5")]
	public class HandPoser : Poser
	{
		[Token(Token = "0x4000581")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected Transform[] children;

		[Token(Token = "0x4000582")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform _poseRoot;

		[Token(Token = "0x4000583")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform[] poseChildren;

		[Token(Token = "0x4000584")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x4000585")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x6000695")]
		[Address(RVA = "0xFB9334", Offset = "0xFB9334", VA = "0xFB9334", Slot = "7")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x6000696")]
		[Address(RVA = "0xFB9404", Offset = "0xFB9404", VA = "0xFB9404", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x6000697")]
		[Address(RVA = "0xFB95DC", Offset = "0xFB95DC", VA = "0xFB95DC", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x6000698")]
		[Address(RVA = "0xFB96C4", Offset = "0xFB96C4", VA = "0xFB96C4", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x6000699")]
		[Address(RVA = "0xFB9464", Offset = "0xFB9464", VA = "0xFB9464")]
		protected void StoreDefaultState()
		{
		}

		[Token(Token = "0x600069A")]
		[Address(RVA = "0xFB99F4", Offset = "0xFB99F4", VA = "0xFB99F4")]
		public HandPoser()
		{
		}
	}
	[Token(Token = "0x20000C6")]
	public abstract class Poser : SolverManager
	{
		[Token(Token = "0x4000586")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform poseRoot;

		[Token(Token = "0x4000587")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x4000588")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Range(0f, 1f)]
		public float localRotationWeight;

		[Token(Token = "0x4000589")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Range(0f, 1f)]
		public float localPositionWeight;

		[Token(Token = "0x400058A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool initiated;

		[Token(Token = "0x600069B")]
		public abstract void AutoMapping();

		[Token(Token = "0x600069C")]
		[Address(RVA = "0xFB9A04", Offset = "0xFB9A04", VA = "0xFB9A04")]
		public void UpdateManual()
		{
		}

		[Token(Token = "0x600069D")]
		protected abstract void InitiatePoser();

		[Token(Token = "0x600069E")]
		protected abstract void UpdatePoser();

		[Token(Token = "0x600069F")]
		protected abstract void FixPoserTransforms();

		[Token(Token = "0x60006A0")]
		[Address(RVA = "0xFB9A10", Offset = "0xFB9A10", VA = "0xFB9A10", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x60006A1")]
		[Address(RVA = "0xFB9A54", Offset = "0xFB9A54", VA = "0xFB9A54", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60006A2")]
		[Address(RVA = "0xFB9A80", Offset = "0xFB9A80", VA = "0xFB9A80", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x60006A3")]
		[Address(RVA = "0xFB9324", Offset = "0xFB9324", VA = "0xFB9324")]
		protected Poser()
		{
		}
	}
	[Token(Token = "0x20000C7")]
	public class RagdollUtility : MonoBehaviour
	{
		[Token(Token = "0x20000C8")]
		public class Rigidbone
		{
			[Token(Token = "0x400059B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody r;

			[Token(Token = "0x400059C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform t;

			[Token(Token = "0x400059D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Collider collider;

			[Token(Token = "0x400059E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Joint joint;

			[Token(Token = "0x400059F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Rigidbody c;

			[Token(Token = "0x40005A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool updateAnchor;

			[Token(Token = "0x40005A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 deltaPosition;

			[Token(Token = "0x40005A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Quaternion deltaRotation;

			[Token(Token = "0x40005A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float deltaTime;

			[Token(Token = "0x40005A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 lastPosition;

			[Token(Token = "0x40005A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Quaternion lastRotation;

			[Token(Token = "0x60006B6")]
			[Address(RVA = "0xFBA0F0", Offset = "0xFBA0F0", VA = "0xFBA0F0")]
			public Rigidbone(Rigidbody r)
			{
			}

			[Token(Token = "0x60006B7")]
			[Address(RVA = "0xFBAC9C", Offset = "0xFBAC9C", VA = "0xFBAC9C")]
			public void RecordVelocity()
			{
			}

			[Token(Token = "0x60006B8")]
			[Address(RVA = "0xFBAA5C", Offset = "0xFBAA5C", VA = "0xFBAA5C")]
			public void WakeUp(float velocityWeight, float angularVelocityWeight)
			{
			}
		}

		[Token(Token = "0x20000C9")]
		public class Child
		{
			[Token(Token = "0x40005A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform t;

			[Token(Token = "0x40005A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 localPosition;

			[Token(Token = "0x40005A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Quaternion localRotation;

			[Token(Token = "0x60006B9")]
			[Address(RVA = "0xFBA298", Offset = "0xFBA298", VA = "0xFBA298")]
			public Child(Transform transform)
			{
			}

			[Token(Token = "0x60006BA")]
			[Address(RVA = "0xFBADB4", Offset = "0xFBADB4", VA = "0xFBADB4")]
			public void FixTransform(float weight)
			{
			}

			[Token(Token = "0x60006BB")]
			[Address(RVA = "0xFBAD70", Offset = "0xFBAD70", VA = "0xFBAD70")]
			public void StoreLocalState()
			{
			}
		}

		[Token(Token = "0x20000CA")]
		[CompilerGenerated]
		private sealed class <DisableRagdollSmooth>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40005AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RagdollUtility <>4__this;

			[Token(Token = "0x170000B4")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60006BF")]
				[Address(RVA = "0xFBB320", Offset = "0xFBB320", VA = "0xFBB320", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B5")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006C1")]
				[Address(RVA = "0xFBB368", Offset = "0xFBB368", VA = "0xFBB368", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006BC")]
			[Address(RVA = "0xFBA304", Offset = "0xFBA304", VA = "0xFBA304")]
			[DebuggerHidden]
			public <DisableRagdollSmooth>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x60006BD")]
			[Address(RVA = "0xFBB130", Offset = "0xFBB130", VA = "0xFBB130", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006BE")]
			[Address(RVA = "0xFBB134", Offset = "0xFBB134", VA = "0xFBB134", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006C0")]
			[Address(RVA = "0xFBB328", Offset = "0xFBB328", VA = "0xFBB328", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400058B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("If you have multiple IK components, then this should be the one that solves last each frame.")]
		public IK ik;

		[Token(Token = "0x400058C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("How long does it take to blend from ragdoll to animation?")]
		public float ragdollToAnimationTime;

		[Token(Token = "0x400058D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("If true, IK can be used on top of physical ragdoll simulation.")]
		public bool applyIkOnRagdoll;

		[Token(Token = "0x400058E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("How much velocity transfer from animation to ragdoll?")]
		public float applyVelocity;

		[Token(Token = "0x400058F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("How much angular velocity to transfer from animation to ragdoll?")]
		public float applyAngularVelocity;

		[Token(Token = "0x4000590")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Animator animator;

		[Token(Token = "0x4000591")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Rigidbone[] rigidbones;

		[Token(Token = "0x4000592")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Child[] children;

		[Token(Token = "0x4000593")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool enableRagdollFlag;

		[Token(Token = "0x4000594")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private AnimatorUpdateMode animatorUpdateMode;

		[Token(Token = "0x4000595")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IK[] allIKComponents;

		[Token(Token = "0x4000596")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool[] fixTransforms;

		[Token(Token = "0x4000597")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float ragdollWeight;

		[Token(Token = "0x4000598")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float ragdollWeightV;

		[Token(Token = "0x4000599")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool fixedFrame;

		[Token(Token = "0x400059A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] disabledIKComponents;

		[Token(Token = "0x170000B2")]
		private bool isRagdoll
		{
			[Token(Token = "0x60006AF")]
			[Address(RVA = "0xFB9AC4", Offset = "0xFB9AC4", VA = "0xFB9AC4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B3")]
		private bool ikUsed
		{
			[Token(Token = "0x60006B1")]
			[Address(RVA = "0xFBA690", Offset = "0xFBA690", VA = "0xFBA690")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0xFB9A98", Offset = "0xFB9A98", VA = "0xFB9A98")]
		public void EnableRagdoll()
		{
		}

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0xFB9B28", Offset = "0xFB9B28", VA = "0xFB9B28")]
		public void DisableRagdoll()
		{
		}

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0xFB9C40", Offset = "0xFB9C40", VA = "0xFB9C40")]
		public void Start()
		{
		}

		[Token(Token = "0x60006A7")]
		[Address(RVA = "0xFB9BCC", Offset = "0xFB9BCC", VA = "0xFB9BCC")]
		[IteratorStateMachine(typeof(<DisableRagdollSmooth>d__21))]
		private IEnumerator DisableRagdollSmooth()
		{
			return null;
		}

		[Token(Token = "0x60006A8")]
		[Address(RVA = "0xFBA32C", Offset = "0xFBA32C", VA = "0xFBA32C")]
		private void Update()
		{
		}

		[Token(Token = "0x60006A9")]
		[Address(RVA = "0xFBA554", Offset = "0xFBA554", VA = "0xFBA554")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60006AA")]
		[Address(RVA = "0xFBA5F4", Offset = "0xFBA5F4", VA = "0xFBA5F4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0xFBA7E4", Offset = "0xFBA7E4", VA = "0xFBA7E4")]
		private void AfterLastIK()
		{
		}

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0xFBA664", Offset = "0xFBA664", VA = "0xFBA664")]
		private void AfterAnimation()
		{
		}

		[Token(Token = "0x60006AD")]
		[Address(RVA = "0xFBA7B0", Offset = "0xFBA7B0", VA = "0xFBA7B0")]
		private void OnFinalPose()
		{
		}

		[Token(Token = "0x60006AE")]
		[Address(RVA = "0xFBA864", Offset = "0xFBA864", VA = "0xFBA864")]
		private void RagdollEnabler()
		{
		}

		[Token(Token = "0x60006B0")]
		[Address(RVA = "0xFBA808", Offset = "0xFBA808", VA = "0xFBA808")]
		private void RecordVelocities()
		{
		}

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0xFB9B70", Offset = "0xFB9B70", VA = "0xFB9B70")]
		private void StoreLocalState()
		{
		}

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0xFBA588", Offset = "0xFBA588", VA = "0xFBA588")]
		private void FixTransforms(float weight)
		{
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0xFBAEC4", Offset = "0xFBAEC4", VA = "0xFBAEC4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0xFBAFFC", Offset = "0xFBAFFC", VA = "0xFBAFFC")]
		public RagdollUtility()
		{
		}
	}
	[Token(Token = "0x20000CB")]
	public abstract class RotationLimit : MonoBehaviour
	{
		[Token(Token = "0x40005AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 axis;

		[Token(Token = "0x40005AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[HideInInspector]
		public Quaternion defaultLocalRotation;

		[Token(Token = "0x40005AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		private bool initiated;

		[Token(Token = "0x40005B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
		private bool applicationQuit;

		[Token(Token = "0x40005B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x37")]
		private bool defaultLocalRotationSet;

		[Token(Token = "0x170000B6")]
		public Vector3 secondaryAxis
		{
			[Token(Token = "0x60006C7")]
			[Address(RVA = "0xFBB7D4", Offset = "0xFBB7D4", VA = "0xFBB7D4")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000B7")]
		public Vector3 crossAxis
		{
			[Token(Token = "0x60006C8")]
			[Address(RVA = "0xFBB7E0", Offset = "0xFBB7E0", VA = "0xFBB7E0")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000B8")]
		public bool defaultLocalRotationOverride
		{
			[Token(Token = "0x60006C9")]
			[Address(RVA = "0xFBB810", Offset = "0xFBB810", VA = "0xFBB810")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006CA")]
			[Address(RVA = "0xFBB818", Offset = "0xFBB818", VA = "0xFBB818")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0xFBB370", Offset = "0xFBB370", VA = "0xFBB370")]
		public void SetDefaultLocalRotation()
		{
		}

		[Token(Token = "0x60006C3")]
		[Address(RVA = "0xFBB3AC", Offset = "0xFBB3AC", VA = "0xFBB3AC")]
		public void SetDefaultLocalRotation(Quaternion localRotation)
		{
		}

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0xFBB3C4", Offset = "0xFBB3C4", VA = "0xFBB3C4")]
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60006C5")]
		[Address(RVA = "0xFBB744", Offset = "0xFBB744", VA = "0xFBB744")]
		public bool Apply()
		{
			return default(bool);
		}

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0xFBB7A8", Offset = "0xFBB7A8", VA = "0xFBB7A8")]
		public void Disable()
		{
		}

		[Token(Token = "0x60006CB")]
		protected abstract Quaternion LimitRotation(Quaternion rotation);

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0xFBB648", Offset = "0xFBB648", VA = "0xFBB648")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0xFBB824", Offset = "0xFBB824", VA = "0xFBB824")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0xFBB828", Offset = "0xFBB828", VA = "0xFBB828")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0xFBB850", Offset = "0xFBB850", VA = "0xFBB850")]
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0xFBB924", Offset = "0xFBB924", VA = "0xFBB924")]
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0xFBBB7C", Offset = "0xFBBB7C", VA = "0xFBBB7C")]
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal)
		{
			return default(float);
		}

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0xFBBCD0", Offset = "0xFBBCD0", VA = "0xFBBCD0")]
		protected RotationLimit()
		{
		}
	}
	[Token(Token = "0x20000CC")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page14.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Angle")]
	public class RotationLimitAngle : RotationLimit
	{
		[Token(Token = "0x40005B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 180f)]
		public float limit;

		[Token(Token = "0x40005B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Range(0f, 180f)]
		public float twistLimit;

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0xFBBD30", Offset = "0xFBBD30", VA = "0xFBBD30")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0xFBBD74", Offset = "0xFBBD74", VA = "0xFBBD74")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0xFBBDB8", Offset = "0xFBBDB8", VA = "0xFBBDB8")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0xFBBDFC", Offset = "0xFBBDFC", VA = "0xFBBDFC")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0xFBBE40", Offset = "0xFBBE40", VA = "0xFBBE40", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0xFBBE78", Offset = "0xFBBE78", VA = "0xFBBE78")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0xFBC19C", Offset = "0xFBC19C", VA = "0xFBC19C")]
		public RotationLimitAngle()
		{
		}
	}
	[Token(Token = "0x20000CD")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page14.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Hinge")]
	public class RotationLimitHinge : RotationLimit
	{
		[Token(Token = "0x40005B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool useLimits;

		[Token(Token = "0x40005B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float min;

		[Token(Token = "0x40005B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float max;

		[Token(Token = "0x40005B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[HideInInspector]
		public float zeroAxisDisplayOffset;

		[Token(Token = "0x40005B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float lastAngle;

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0xFBC1AC", Offset = "0xFBC1AC", VA = "0xFBC1AC")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0xFBC1F0", Offset = "0xFBC1F0", VA = "0xFBC1F0")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0xFBC234", Offset = "0xFBC234", VA = "0xFBC234")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0xFBC278", Offset = "0xFBC278", VA = "0xFBC278")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0xFBC2BC", Offset = "0xFBC2BC", VA = "0xFBC2BC", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0xFBC2C0", Offset = "0xFBC2C0", VA = "0xFBC2C0")]
		private Quaternion LimitHinge(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0xFBC4E0", Offset = "0xFBC4E0", VA = "0xFBC4E0")]
		public RotationLimitHinge()
		{
		}
	}
	[Token(Token = "0x20000CE")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page14.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Polygonal")]
	public class RotationLimitPolygonal : RotationLimit
	{
		[Serializable]
		[Token(Token = "0x20000CF")]
		public class ReachCone
		{
			[Token(Token = "0x40005BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3[] tetrahedron;

			[Token(Token = "0x40005BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float volume;

			[Token(Token = "0x40005C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 S;

			[Token(Token = "0x40005C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 B;

			[Token(Token = "0x170000B9")]
			public Vector3 o
			{
				[Token(Token = "0x60006F1")]
				[Address(RVA = "0xFBE38C", Offset = "0xFBE38C", VA = "0xFBE38C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000BA")]
			public Vector3 a
			{
				[Token(Token = "0x60006F2")]
				[Address(RVA = "0xFBE3B8", Offset = "0xFBE3B8", VA = "0xFBE3B8")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000BB")]
			public Vector3 b
			{
				[Token(Token = "0x60006F3")]
				[Address(RVA = "0xFBE3E8", Offset = "0xFBE3E8", VA = "0xFBE3E8")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000BC")]
			public Vector3 c
			{
				[Token(Token = "0x60006F4")]
				[Address(RVA = "0xFBE418", Offset = "0xFBE418", VA = "0xFBE418")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000BD")]
			public bool isValid
			{
				[Token(Token = "0x60006F6")]
				[Address(RVA = "0xFBD8B4", Offset = "0xFBD8B4", VA = "0xFBD8B4")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60006F5")]
			[Address(RVA = "0xFBDD58", Offset = "0xFBDD58", VA = "0xFBDD58")]
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c)
			{
			}

			[Token(Token = "0x60006F7")]
			[Address(RVA = "0xFBDED0", Offset = "0xFBDED0", VA = "0xFBDED0")]
			public void Calculate()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000D0")]
		public class LimitPoint
		{
			[Token(Token = "0x40005C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 point;

			[Token(Token = "0x40005C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float tangentWeight;

			[Token(Token = "0x60006F8")]
			[Address(RVA = "0xFBD8C4", Offset = "0xFBD8C4", VA = "0xFBD8C4")]
			public LimitPoint()
			{
			}
		}

		[Token(Token = "0x40005B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 180f)]
		public float twistLimit;

		[Token(Token = "0x40005BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Range(0f, 3f)]
		public int smoothIterations;

		[Token(Token = "0x40005BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public LimitPoint[] points;

		[Token(Token = "0x40005BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[HideInInspector]
		public Vector3[] P;

		[Token(Token = "0x40005BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[HideInInspector]
		public ReachCone[] reachCones;

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0xFBC4F8", Offset = "0xFBC4F8", VA = "0xFBC4F8")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0xFBC53C", Offset = "0xFBC53C", VA = "0xFBC53C")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0xFBC580", Offset = "0xFBC580", VA = "0xFBC580")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0xFBC5C4", Offset = "0xFBC5C4", VA = "0xFBC5C4")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0xFBC608", Offset = "0xFBC608", VA = "0xFBC608")]
		public void SetLimitPoints(LimitPoint[] points)
		{
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0xFBCCEC", Offset = "0xFBCCEC", VA = "0xFBCCEC", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0xFBCD74", Offset = "0xFBCD74", VA = "0xFBCD74")]
		private void Start()
		{
		}

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0xFBD3C0", Offset = "0xFBD3C0", VA = "0xFBD3C0")]
		public void ResetToDefault()
		{
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0xFBC6A0", Offset = "0xFBC6A0", VA = "0xFBC6A0")]
		public void BuildReachCones()
		{
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0xFBD928", Offset = "0xFBD928", VA = "0xFBD928")]
		private Vector3[] SmoothPoints()
		{
			return null;
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0xFBE144", Offset = "0xFBE144", VA = "0xFBE144")]
		private float GetScalar(int k)
		{
			return default(float);
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0xFBE18C", Offset = "0xFBE18C", VA = "0xFBE18C")]
		private Vector3 PointToTangentPlane(Vector3 p, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0xFBE1EC", Offset = "0xFBE1EC", VA = "0xFBE1EC")]
		private Vector3 TangentPointToSphere(Vector3 q, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0xFBD11C", Offset = "0xFBD11C", VA = "0xFBD11C")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0xFBE258", Offset = "0xFBE258", VA = "0xFBE258")]
		private int GetReachCone(Vector3 L)
		{
			return default(int);
		}

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0xFBE324", Offset = "0xFBE324", VA = "0xFBE324")]
		public RotationLimitPolygonal()
		{
		}
	}
	[Token(Token = "0x20000D1")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Spline")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page14.html")]
	public class RotationLimitSpline : RotationLimit
	{
		[Token(Token = "0x40005C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 180f)]
		public float twistLimit;

		[Token(Token = "0x40005C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public AnimationCurve spline;

		[Token(Token = "0x60006F9")]
		[Address(RVA = "0xFBE448", Offset = "0xFBE448", VA = "0xFBE448")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60006FA")]
		[Address(RVA = "0xFBE48C", Offset = "0xFBE48C", VA = "0xFBE48C")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60006FB")]
		[Address(RVA = "0xFBE4D0", Offset = "0xFBE4D0", VA = "0xFBE4D0")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0xFBE514", Offset = "0xFBE514", VA = "0xFBE514")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0xFBE558", Offset = "0xFBE558", VA = "0xFBE558")]
		public void SetSpline(Keyframe[] keyframes)
		{
		}

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0xFBE574", Offset = "0xFBE574", VA = "0xFBE574", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60006FF")]
		[Address(RVA = "0xFBE5AC", Offset = "0xFBE5AC", VA = "0xFBE5AC")]
		public Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000700")]
		[Address(RVA = "0xFBE958", Offset = "0xFBE958", VA = "0xFBE958")]
		public RotationLimitSpline()
		{
		}
	}
	[Token(Token = "0x20000D2")]
	public class AimController : MonoBehaviour
	{
		[Token(Token = "0x20000D3")]
		[CompilerGenerated]
		private sealed class <TurnToTarget>d__37 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40005E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AimController <>4__this;

			[Token(Token = "0x170000BF")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600070B")]
				[Address(RVA = "0xFBF95C", Offset = "0xFBF95C", VA = "0xFBF95C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C0")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600070D")]
				[Address(RVA = "0xFBF9A4", Offset = "0xFBF9A4", VA = "0xFBF9A4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000708")]
			[Address(RVA = "0xFBF75C", Offset = "0xFBF75C", VA = "0xFBF75C")]
			[DebuggerHidden]
			public <TurnToTarget>d__37(int <>1__state)
			{
			}

			[Token(Token = "0x6000709")]
			[Address(RVA = "0xFBF868", Offset = "0xFBF868", VA = "0xFBF868", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600070A")]
			[Address(RVA = "0xFBF86C", Offset = "0xFBF86C", VA = "0xFBF86C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600070C")]
			[Address(RVA = "0xFBF964", Offset = "0xFBF964", VA = "0xFBF964", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40005C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Reference to the AimIK component.")]
		public AimIK ik;

		[Token(Token = "0x40005C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Master weight of the IK solver.")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x40005C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Header("Target Smoothing")]
		[Tooltip("The target to aim at. Do not use the Target transform that is assigned to AimIK. Set to null if you wish to stop aiming.")]
		public Transform target;

		[Token(Token = "0x40005C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The time it takes to switch targets.")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x40005CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Tooltip("The time it takes to blend in/out of AimIK weight.")]
		public float weightSmoothTime;

		[Token(Token = "0x40005CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Header("Turning Towards The Target")]
		[Tooltip("Enables smooth turning towards the target according to the parameters under this header.")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x40005CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("Speed of turning towards the target using Vector3.RotateTowards.")]
		public float maxRadiansDelta;

		[Token(Token = "0x40005CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Speed of moving towards the target using Vector3.RotateTowards.")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x40005CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Tooltip("Speed of slerping towards the target.")]
		public float slerpSpeed;

		[Token(Token = "0x40005CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Smoothing time for turning towards the yaw and pitch of the target using Mathf.SmoothDampAngle. Value of 0 means smooth damping is disabled.")]
		public float smoothDampTime;

		[Token(Token = "0x40005D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("The position of the pivot that the aim target is rotated around relative to the root of the character.")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x40005D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("Minimum distance of aiming from the first bone. Keeps the solver from failing if the target is too close.")]
		public float minDistance;

		[Token(Token = "0x40005D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Tooltip("Offset applied to the target in world space. Convenient for scripting aiming inaccuracy.")]
		public Vector3 offset;

		[Token(Token = "0x40005D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Tooltip("Character root will be rotate around the Y axis to keep root forward within this angle from the aiming direction.")]
		[Header("RootRotation")]
		[Range(0f, 180f)]
		public float maxRootAngle;

		[Token(Token = "0x40005D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[Tooltip("If enabled, aligns the root forward to target direction after 'Max Root Angle' has been exceeded.")]
		public bool turnToTarget;

		[Token(Token = "0x40005D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Tooltip("The time of turning towards the target direction if 'Max Root Angle has been exceeded and 'Turn To Target' is enabled.")]
		public float turnToTargetTime;

		[Token(Token = "0x40005D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[Tooltip("If true, AimIK will consider whatever the current direction of the weapon to be the forward aiming direction and work additively on top of that. This enables you to use recoil and reloading animations seamlessly with AimIK. Adjust the Vector3 value below if the weapon is not aiming perfectly forward in the aiming animation clip.")]
		[Header("Mode")]
		public bool useAnimatedAimDirection;

		[Token(Token = "0x40005D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[Tooltip("The direction of the animated weapon aiming in character space. Tweak this value to adjust the aiming. 'Use Animated Aim Direction' must be enabled for this property to work.")]
		public Vector3 animatedAimDirection;

		[Token(Token = "0x40005D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Transform lastTarget;

		[Token(Token = "0x40005D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float switchWeight;

		[Token(Token = "0x40005DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private float switchWeightV;

		[Token(Token = "0x40005DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float weightV;

		[Token(Token = "0x40005DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Vector3 lastPosition;

		[Token(Token = "0x40005DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 dir;

		[Token(Token = "0x40005DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private bool lastSmoothTowardsTarget;

		[Token(Token = "0x40005DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB5")]
		private bool turningToTarget;

		[Token(Token = "0x40005E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private float turnToTargetMlp;

		[Token(Token = "0x40005E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private float turnToTargetMlpV;

		[Token(Token = "0x40005E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float yawV;

		[Token(Token = "0x40005E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private float pitchV;

		[Token(Token = "0x40005E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float dirMagV;

		[Token(Token = "0x170000BE")]
		private Vector3 pivot
		{
			[Token(Token = "0x6000703")]
			[Address(RVA = "0xFBE9E4", Offset = "0xFBE9E4", VA = "0xFBE9E4")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000701")]
		[Address(RVA = "0xFBE964", Offset = "0xFBE964", VA = "0xFBE964")]
		private void Start()
		{
		}

		[Token(Token = "0x6000702")]
		[Address(RVA = "0xFBEA68", Offset = "0xFBEA68", VA = "0xFBEA68")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000704")]
		[Address(RVA = "0xFBF2C0", Offset = "0xFBF2C0", VA = "0xFBF2C0")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0xFBF444", Offset = "0xFBF444", VA = "0xFBF444")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x6000706")]
		[Address(RVA = "0xFBF6E8", Offset = "0xFBF6E8", VA = "0xFBF6E8")]
		[IteratorStateMachine(typeof(<TurnToTarget>d__37))]
		private IEnumerator TurnToTarget()
		{
			return null;
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0xFBF784", Offset = "0xFBF784", VA = "0xFBF784")]
		public AimController()
		{
		}
	}
	[Token(Token = "0x20000D4")]
	public class AimPoser : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000D5")]
		public class Pose
		{
			[Token(Token = "0x40005EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool visualize;

			[Token(Token = "0x40005EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string name;

			[Token(Token = "0x40005EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 direction;

			[Token(Token = "0x40005ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float yaw;

			[Token(Token = "0x40005EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float pitch;

			[Token(Token = "0x40005EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float angleBuffer;

			[Token(Token = "0x6000711")]
			[Address(RVA = "0xFBFA7C", Offset = "0xFBFA7C", VA = "0xFBFA7C")]
			public bool IsInDirection(Vector3 d)
			{
				return default(bool);
			}

			[Token(Token = "0x6000712")]
			[Address(RVA = "0xFBFFF8", Offset = "0xFBFFF8", VA = "0xFBFFF8")]
			public void SetAngleBuffer(float value)
			{
			}

			[Token(Token = "0x6000713")]
			[Address(RVA = "0xFC0000", Offset = "0xFC0000", VA = "0xFC0000")]
			public Pose()
			{
			}
		}

		[Token(Token = "0x40005E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float angleBuffer;

		[Token(Token = "0x40005E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Pose[] poses;

		[Token(Token = "0x600070E")]
		[Address(RVA = "0xFBF9AC", Offset = "0xFBF9AC", VA = "0xFBF9AC")]
		public Pose GetPose(Vector3 localDirection)
		{
			return null;
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0xFBFF2C", Offset = "0xFBFF2C", VA = "0xFBFF2C")]
		public void SetPoseActive(Pose pose)
		{
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0xFBFF8C", Offset = "0xFBFF8C", VA = "0xFBFF8C")]
		public AimPoser()
		{
		}
	}
	[Token(Token = "0x20000D6")]
	public class Amplifier : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000D7")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x20000D8")]
			public class EffectorLink
			{
				[Token(Token = "0x40005FA")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("Type of the FBBIK effector to use")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40005FB")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("Weight of using this effector")]
				public float weight;

				[Token(Token = "0x6000719")]
				[Address(RVA = "0xFC048C", Offset = "0xFC048C", VA = "0xFC048C")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40005F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The Transform that's motion we are reading.")]
			public Transform transform;

			[Token(Token = "0x40005F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Amplify the 'transform's' position relative to this Transform.")]
			public Transform relativeTo;

			[Token(Token = "0x40005F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Linking the body to effectors. One Body can be used to offset more than one effector.")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x40005F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Amplification magnitude along the up axis of the character.")]
			public float verticalWeight;

			[Token(Token = "0x40005F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("Amplification magnitude along the horizontal axes of the character.")]
			public float horizontalWeight;

			[Token(Token = "0x40005F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("Speed of the amplifier. 0 means instant.")]
			public float speed;

			[Token(Token = "0x40005F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private Vector3 lastRelativePos;

			[Token(Token = "0x40005F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Vector3 smoothDelta;

			[Token(Token = "0x40005F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private bool firstUpdate;

			[Token(Token = "0x6000716")]
			[Address(RVA = "0xFC014C", Offset = "0xFC014C", VA = "0xFC014C")]
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime)
			{
			}

			[Token(Token = "0x6000717")]
			[Address(RVA = "0xFC0464", Offset = "0xFC0464", VA = "0xFC0464")]
			private static Vector3 Multiply(Vector3 v1, Vector3 v2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000718")]
			[Address(RVA = "0xFC0474", Offset = "0xFC0474", VA = "0xFC0474")]
			public Body()
			{
			}
		}

		[Token(Token = "0x40005F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The amplified bodies.")]
		public Body[] bodies;

		[Token(Token = "0x6000714")]
		[Address(RVA = "0xFC001C", Offset = "0xFC001C", VA = "0xFC001C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000715")]
		[Address(RVA = "0xFC045C", Offset = "0xFC045C", VA = "0xFC045C")]
		public Amplifier()
		{
		}
	}
	[Token(Token = "0x20000D9")]
	public class BodyTilt : OffsetModifier
	{
		[Token(Token = "0x40005FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("Speed of tilting")]
		public float tiltSpeed;

		[Token(Token = "0x40005FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Sensitivity of tilting")]
		public float tiltSensitivity;

		[Token(Token = "0x40005FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The OffsetPose components")]
		public OffsetPose poseLeft;

		[Token(Token = "0x40005FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The OffsetPose components")]
		public OffsetPose poseRight;

		[Token(Token = "0x4000600")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float tiltAngle;

		[Token(Token = "0x4000601")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 lastForward;

		[Token(Token = "0x600071A")]
		[Address(RVA = "0xFC0494", Offset = "0xFC0494", VA = "0xFC0494", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600071B")]
		[Address(RVA = "0xFC04D0", Offset = "0xFC04D0", VA = "0xFC04D0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600071C")]
		[Address(RVA = "0xFC06BC", Offset = "0xFC06BC", VA = "0xFC06BC")]
		public BodyTilt()
		{
		}
	}
	[Token(Token = "0x20000DA")]
	public class CCDBendGoal : MonoBehaviour
	{
		[Token(Token = "0x4000602")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CCDIK ik;

		[Token(Token = "0x4000603")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x600071D")]
		[Address(RVA = "0xFC06D0", Offset = "0xFC06D0", VA = "0xFC06D0")]
		private void Start()
		{
		}

		[Token(Token = "0x600071E")]
		[Address(RVA = "0xFC07B0", Offset = "0xFC07B0", VA = "0xFC07B0")]
		private void BeforeIK()
		{
		}

		[Token(Token = "0x600071F")]
		[Address(RVA = "0xFC0A44", Offset = "0xFC0A44", VA = "0xFC0A44")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000720")]
		[Address(RVA = "0xFC0B70", Offset = "0xFC0B70", VA = "0xFC0B70")]
		public CCDBendGoal()
		{
		}
	}
	[Token(Token = "0x20000DB")]
	[ExecuteInEditMode]
	public class EditorIK : MonoBehaviour
	{
		[Token(Token = "0x4000604")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("If slot assigned, will update Animator before IK.")]
		public Animator animator;

		[Token(Token = "0x4000605")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Create/Final IK/Editor IK Pose")]
		public EditorIKPose defaultPose;

		[Token(Token = "0x4000606")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public Transform[] bones;

		[Token(Token = "0x170000C1")]
		public IK ik
		{
			[Token(Token = "0x6000721")]
			[Address(RVA = "0xFC0B80", Offset = "0xFC0B80", VA = "0xFC0B80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000722")]
			[Address(RVA = "0xFC0B88", Offset = "0xFC0B88", VA = "0xFC0B88")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000723")]
		[Address(RVA = "0xFC0B90", Offset = "0xFC0B90", VA = "0xFC0B90")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000724")]
		[Address(RVA = "0xFC0D30", Offset = "0xFC0D30", VA = "0xFC0D30")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000725")]
		[Address(RVA = "0xFC0F8C", Offset = "0xFC0F8C", VA = "0xFC0F8C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000726")]
		[Address(RVA = "0xFC10C8", Offset = "0xFC10C8", VA = "0xFC10C8")]
		public void StoreDefaultPose()
		{
		}

		[Token(Token = "0x6000727")]
		[Address(RVA = "0xFC12A8", Offset = "0xFC12A8", VA = "0xFC12A8")]
		public bool Initiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000728")]
		[Address(RVA = "0xFC14BC", Offset = "0xFC14BC", VA = "0xFC14BC")]
		public void Update()
		{
		}

		[Token(Token = "0x6000729")]
		[Address(RVA = "0xFC1740", Offset = "0xFC1740", VA = "0xFC1740")]
		public EditorIK()
		{
		}
	}
	[Token(Token = "0x20000DC")]
	[CreateAssetMenu(fileName = "Editor IK Pose", menuName = "Final IK/Editor IK Pose", order = 1)]
	public class EditorIKPose : ScriptableObject
	{
		[Token(Token = "0x4000608")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3[] localPositions;

		[Token(Token = "0x4000609")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Quaternion[] localRotations;

		[Token(Token = "0x170000C2")]
		public bool poseStored
		{
			[Token(Token = "0x600072A")]
			[Address(RVA = "0xFC0E0C", Offset = "0xFC0E0C", VA = "0xFC0E0C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600072B")]
		[Address(RVA = "0xFC1144", Offset = "0xFC1144", VA = "0xFC1144")]
		public void Store(Transform[] T)
		{
		}

		[Token(Token = "0x600072C")]
		[Address(RVA = "0xFC0E30", Offset = "0xFC0E30", VA = "0xFC0E30")]
		public bool Restore(Transform[] T)
		{
			return default(bool);
		}

		[Token(Token = "0x600072D")]
		[Address(RVA = "0xFC17A4", Offset = "0xFC17A4", VA = "0xFC17A4")]
		public EditorIKPose()
		{
		}
	}
	[Token(Token = "0x20000DD")]
	public class HitReaction : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000DE")]
		public abstract class HitPoint
		{
			[Token(Token = "0x400060C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Just for visual clarity, not used at all")]
			public string name;

			[Token(Token = "0x400060D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Linking this hit point to a collider")]
			public Collider collider;

			[Token(Token = "0x400060E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Only used if this hit point gets hit when already processing another hit")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x4000612")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float length;

			[Token(Token = "0x4000613")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float crossFadeSpeed;

			[Token(Token = "0x4000614")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private float lastTime;

			[Token(Token = "0x170000C4")]
			public bool inProgress
			{
				[Token(Token = "0x6000732")]
				[Address(RVA = "0xFC18DC", Offset = "0xFC18DC", VA = "0xFC18DC")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000C5")]
			protected float crossFader
			{
				[Token(Token = "0x6000733")]
				[Address(RVA = "0xFC1CBC", Offset = "0xFC1CBC", VA = "0xFC1CBC")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000734")]
				[Address(RVA = "0xFC1CC4", Offset = "0xFC1CC4", VA = "0xFC1CC4")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000C6")]
			protected float timer
			{
				[Token(Token = "0x6000735")]
				[Address(RVA = "0xFC1CCC", Offset = "0xFC1CCC", VA = "0xFC1CCC")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000736")]
				[Address(RVA = "0xFC1CD4", Offset = "0xFC1CD4", VA = "0xFC1CD4")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000C7")]
			protected Vector3 force
			{
				[Token(Token = "0x6000737")]
				[Address(RVA = "0xFC1CDC", Offset = "0xFC1CDC", VA = "0xFC1CDC")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000738")]
				[Address(RVA = "0xFC1CE8", Offset = "0xFC1CE8", VA = "0xFC1CE8")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x6000739")]
			[Address(RVA = "0xFC1CF4", Offset = "0xFC1CF4", VA = "0xFC1CF4", Slot = "4")]
			public virtual void Hit(Vector3 force, Vector3 point)
			{
			}

			[Token(Token = "0x600073A")]
			[Address(RVA = "0xFC19B0", Offset = "0xFC19B0", VA = "0xFC19B0")]
			public void Apply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x600073B")]
			protected abstract float GetLength();

			[Token(Token = "0x600073C")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x600073D")]
			protected abstract void OnApply(IKSolverFullBodyBiped solver, float weight);

			[Token(Token = "0x600073E")]
			[Address(RVA = "0xFC1E00", Offset = "0xFC1E00", VA = "0xFC1E00")]
			protected HitPoint()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000DF")]
		public class HitPointEffector : HitPoint
		{
			[Serializable]
			[Token(Token = "0x20000E0")]
			public class EffectorLink
			{
				[Token(Token = "0x4000618")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("The FBBIK effector type")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000619")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("The weight of this effector (could also be negative)")]
				public float weight;

				[Token(Token = "0x400061A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x400061B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x6000743")]
				[Address(RVA = "0xFC2134", Offset = "0xFC2134", VA = "0xFC2134")]
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x6000744")]
				[Address(RVA = "0xFC1F90", Offset = "0xFC1F90", VA = "0xFC1F90")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000745")]
				[Address(RVA = "0xFC21E4", Offset = "0xFC21E4", VA = "0xFC21E4")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000615")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[Tooltip("Offset magnitude in the direction of the hit force")]
			public AnimationCurve offsetInForceDirection;

			[Token(Token = "0x4000616")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("Offset magnitude in the direction of character.up")]
			public AnimationCurve offsetInUpDirection;

			[Token(Token = "0x4000617")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Tooltip("Linking this offset to the FBBIK effectors")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x600073F")]
			[Address(RVA = "0xFC1E14", Offset = "0xFC1E14", VA = "0xFC1E14", Slot = "5")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x6000740")]
			[Address(RVA = "0xFC1F30", Offset = "0xFC1F30", VA = "0xFC1F30", Slot = "6")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000741")]
			[Address(RVA = "0xFC1FA4", Offset = "0xFC1FA4", VA = "0xFC1FA4", Slot = "7")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000742")]
			[Address(RVA = "0xFC21D0", Offset = "0xFC21D0", VA = "0xFC21D0")]
			public HitPointEffector()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000E1")]
		public class HitPointBone : HitPoint
		{
			[Serializable]
			[Token(Token = "0x20000E2")]
			public class BoneLink
			{
				[Token(Token = "0x4000620")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("Reference to the bone that this hit point rotates")]
				public Transform bone;

				[Token(Token = "0x4000621")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[Tooltip("Weight of rotating the bone")]
				[Range(0f, 1f)]
				public float weight;

				[Token(Token = "0x4000622")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				private Quaternion lastValue;

				[Token(Token = "0x4000623")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
				private Quaternion current;

				[Token(Token = "0x600074B")]
				[Address(RVA = "0xFC251C", Offset = "0xFC251C", VA = "0xFC251C")]
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x600074C")]
				[Address(RVA = "0xFC2450", Offset = "0xFC2450", VA = "0xFC2450")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x600074D")]
				[Address(RVA = "0xFC26BC", Offset = "0xFC26BC", VA = "0xFC26BC")]
				public BoneLink()
				{
				}
			}

			[Token(Token = "0x400061C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[Tooltip("The angle to rotate the bone around its rigidbody's world center of mass")]
			public AnimationCurve aroundCenterOfMass;

			[Token(Token = "0x400061D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("Linking this hit point to bone(s)")]
			public BoneLink[] boneLinks;

			[Token(Token = "0x400061E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Rigidbody rigidbody;

			[Token(Token = "0x400061F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Vector3 comAxis;

			[Token(Token = "0x6000746")]
			[Address(RVA = "0xFC21EC", Offset = "0xFC21EC", VA = "0xFC21EC", Slot = "4")]
			public override void Hit(Vector3 force, Vector3 point)
			{
			}

			[Token(Token = "0x6000747")]
			[Address(RVA = "0xFC236C", Offset = "0xFC236C", VA = "0xFC236C", Slot = "5")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x6000748")]
			[Address(RVA = "0xFC23F8", Offset = "0xFC23F8", VA = "0xFC23F8", Slot = "6")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000749")]
			[Address(RVA = "0xFC245C", Offset = "0xFC245C", VA = "0xFC245C", Slot = "7")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x600074A")]
			[Address(RVA = "0xFC26A8", Offset = "0xFC26A8", VA = "0xFC26A8")]
			public HitPointBone()
			{
			}
		}

		[Token(Token = "0x400060A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Hit points for the FBBIK effectors")]
		public HitPointEffector[] effectorHitPoints;

		[Token(Token = "0x400060B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip(" Hit points for bones without an effector, such as the head")]
		public HitPointBone[] boneHitPoints;

		[Token(Token = "0x170000C3")]
		public bool inProgress
		{
			[Token(Token = "0x600072E")]
			[Address(RVA = "0xFC1840", Offset = "0xFC1840", VA = "0xFC1840")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600072F")]
		[Address(RVA = "0xFC18F0", Offset = "0xFC18F0", VA = "0xFC18F0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000730")]
		[Address(RVA = "0xFC1A88", Offset = "0xFC1A88", VA = "0xFC1A88")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x6000731")]
		[Address(RVA = "0xFC1CB4", Offset = "0xFC1CB4", VA = "0xFC1CB4")]
		public HitReaction()
		{
		}
	}
	[Token(Token = "0x20000E3")]
	public class HitReactionVRIK : OffsetModifierVRIK
	{
		[Serializable]
		[Token(Token = "0x20000E4")]
		public abstract class Offset
		{
			[Token(Token = "0x4000627")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Just for visual clarity, not used at all")]
			public string name;

			[Token(Token = "0x4000628")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Linking this hit point to a collider")]
			public Collider collider;

			[Token(Token = "0x4000629")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Only used if this hit point gets hit when already processing another hit")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x400062D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float length;

			[Token(Token = "0x400062E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float crossFadeSpeed;

			[Token(Token = "0x400062F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private float lastTime;

			[Token(Token = "0x170000C8")]
			protected float crossFader
			{
				[Token(Token = "0x6000751")]
				[Address(RVA = "0xFC2AF4", Offset = "0xFC2AF4", VA = "0xFC2AF4")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000752")]
				[Address(RVA = "0xFC2AFC", Offset = "0xFC2AFC", VA = "0xFC2AFC")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000C9")]
			protected float timer
			{
				[Token(Token = "0x6000753")]
				[Address(RVA = "0xFC2B04", Offset = "0xFC2B04", VA = "0xFC2B04")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000754")]
				[Address(RVA = "0xFC2B0C", Offset = "0xFC2B0C", VA = "0xFC2B0C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000CA")]
			protected Vector3 force
			{
				[Token(Token = "0x6000755")]
				[Address(RVA = "0xFC2B14", Offset = "0xFC2B14", VA = "0xFC2B14")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000756")]
				[Address(RVA = "0xFC2B20", Offset = "0xFC2B20", VA = "0xFC2B20")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x6000757")]
			[Address(RVA = "0xFC2B2C", Offset = "0xFC2B2C", VA = "0xFC2B2C", Slot = "4")]
			public virtual void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
			}

			[Token(Token = "0x6000758")]
			[Address(RVA = "0xFC27D8", Offset = "0xFC27D8", VA = "0xFC27D8")]
			public void Apply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000759")]
			protected abstract float GetLength(AnimationCurve[] curves);

			[Token(Token = "0x600075A")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x600075B")]
			protected abstract void OnApply(VRIK ik, AnimationCurve[] curves, float weight);

			[Token(Token = "0x600075C")]
			[Address(RVA = "0xFC2C40", Offset = "0xFC2C40", VA = "0xFC2C40")]
			protected Offset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000E5")]
		public class PositionOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x20000E6")]
			public class PositionOffsetLink
			{
				[Token(Token = "0x4000633")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("The FBBIK effector type")]
				public IKSolverVR.PositionOffset positionOffset;

				[Token(Token = "0x4000634")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("The weight of this effector (could also be negative)")]
				public float weight;

				[Token(Token = "0x4000635")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x4000636")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x6000761")]
				[Address(RVA = "0xFC3024", Offset = "0xFC3024", VA = "0xFC3024")]
				public void Apply(VRIK ik, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x6000762")]
				[Address(RVA = "0xFC2E48", Offset = "0xFC2E48", VA = "0xFC2E48")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000763")]
				[Address(RVA = "0xFC30B8", Offset = "0xFC30B8", VA = "0xFC30B8")]
				public PositionOffsetLink()
				{
				}
			}

			[Token(Token = "0x4000630")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[Tooltip("Offset magnitude in the direction of the hit force")]
			public int forceDirCurveIndex;

			[Token(Token = "0x4000631")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[Tooltip("Offset magnitude in the direction of character.up")]
			public int upDirCurveIndex;

			[Token(Token = "0x4000632")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("Linking this offset to the VRIK position offsets")]
			public PositionOffsetLink[] offsetLinks;

			[Token(Token = "0x600075D")]
			[Address(RVA = "0xFC2C54", Offset = "0xFC2C54", VA = "0xFC2C54", Slot = "5")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x600075E")]
			[Address(RVA = "0xFC2DE8", Offset = "0xFC2DE8", VA = "0xFC2DE8", Slot = "6")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x600075F")]
			[Address(RVA = "0xFC2E5C", Offset = "0xFC2E5C", VA = "0xFC2E5C", Slot = "7")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000760")]
			[Address(RVA = "0xFC309C", Offset = "0xFC309C", VA = "0xFC309C")]
			public PositionOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000E7")]
		public class RotationOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x20000E8")]
			public class RotationOffsetLink
			{
				[Token(Token = "0x400063B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("Reference to the bone that this hit point rotates")]
				public IKSolverVR.RotationOffset rotationOffset;

				[Token(Token = "0x400063C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("Weight of rotating the bone")]
				[Range(0f, 1f)]
				public float weight;

				[Token(Token = "0x400063D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Quaternion lastValue;

				[Token(Token = "0x400063E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private Quaternion current;

				[Token(Token = "0x6000769")]
				[Address(RVA = "0xFC35AC", Offset = "0xFC35AC", VA = "0xFC35AC")]
				public void Apply(VRIK ik, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x600076A")]
				[Address(RVA = "0xFC3378", Offset = "0xFC3378", VA = "0xFC3378")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x600076B")]
				[Address(RVA = "0xFC36C8", Offset = "0xFC36C8", VA = "0xFC36C8")]
				public RotationOffsetLink()
				{
				}
			}

			[Token(Token = "0x4000637")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[Tooltip("The angle to rotate the bone around its rigidbody's world center of mass")]
			public int curveIndex;

			[Token(Token = "0x4000638")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[Tooltip("Linking this hit point to bone(s)")]
			public RotationOffsetLink[] offsetLinks;

			[Token(Token = "0x4000639")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private Rigidbody rigidbody;

			[Token(Token = "0x400063A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Vector3 comAxis;

			[Token(Token = "0x6000764")]
			[Address(RVA = "0xFC30C0", Offset = "0xFC30C0", VA = "0xFC30C0", Slot = "4")]
			public override void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
			}

			[Token(Token = "0x6000765")]
			[Address(RVA = "0xFC3248", Offset = "0xFC3248", VA = "0xFC3248", Slot = "5")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x6000766")]
			[Address(RVA = "0xFC3320", Offset = "0xFC3320", VA = "0xFC3320", Slot = "6")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000767")]
			[Address(RVA = "0xFC3384", Offset = "0xFC3384", VA = "0xFC3384", Slot = "7")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000768")]
			[Address(RVA = "0xFC36B4", Offset = "0xFC36B4", VA = "0xFC36B4")]
			public RotationOffset()
			{
			}
		}

		[Token(Token = "0x4000624")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve[] offsetCurves;

		[Token(Token = "0x4000625")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Hit points for the FBBIK effectors")]
		public PositionOffset[] positionOffsets;

		[Token(Token = "0x4000626")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip(" Hit points for bones without an effector, such as the head")]
		public RotationOffset[] rotationOffsets;

		[Token(Token = "0x600074E")]
		[Address(RVA = "0xFC2720", Offset = "0xFC2720", VA = "0xFC2720", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600074F")]
		[Address(RVA = "0xFC28B8", Offset = "0xFC28B8", VA = "0xFC28B8")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x6000750")]
		[Address(RVA = "0xFC2AEC", Offset = "0xFC2AEC", VA = "0xFC2AEC")]
		public HitReactionVRIK()
		{
		}
	}
	[Token(Token = "0x20000E9")]
	public class Inertia : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000EA")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x20000EB")]
			public class EffectorLink
			{
				[Token(Token = "0x400064C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("Type of the FBBIK effector to use")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400064D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("Weight of using this effector")]
				public float weight;

				[Token(Token = "0x6000772")]
				[Address(RVA = "0xFC3BE4", Offset = "0xFC3BE4", VA = "0xFC3BE4")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000641")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The Transform to follow, can be any bone of the character")]
			public Transform transform;

			[Token(Token = "0x4000642")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Linking the body to effectors. One Body can be used to offset more than one effector")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000643")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("The speed to follow the Transform")]
			public float speed;

			[Token(Token = "0x4000644")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[Tooltip("The acceleration, smaller values means lazyer following")]
			public float acceleration;

			[Token(Token = "0x4000645")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Range(0f, 1f)]
			[Tooltip("Matching target velocity")]
			public float matchVelocity;

			[Token(Token = "0x4000646")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("gravity applied to the Body")]
			public float gravity;

			[Token(Token = "0x4000647")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 delta;

			[Token(Token = "0x4000648")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lazyPoint;

			[Token(Token = "0x4000649")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 direction;

			[Token(Token = "0x400064A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 lastPosition;

			[Token(Token = "0x400064B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private bool firstUpdate;

			[Token(Token = "0x600076F")]
			[Address(RVA = "0xFC3798", Offset = "0xFC3798", VA = "0xFC3798")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000770")]
			[Address(RVA = "0xFC391C", Offset = "0xFC391C", VA = "0xFC391C")]
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime)
			{
			}

			[Token(Token = "0x6000771")]
			[Address(RVA = "0xFC3BC8", Offset = "0xFC3BC8", VA = "0xFC3BC8")]
			public Body()
			{
			}
		}

		[Token(Token = "0x400063F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The array of Bodies")]
		public Body[] bodies;

		[Token(Token = "0x4000640")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The array of OffsetLimits")]
		public OffsetLimits[] limits;

		[Token(Token = "0x600076C")]
		[Address(RVA = "0xFC372C", Offset = "0xFC372C", VA = "0xFC372C")]
		public void ResetBodies()
		{
		}

		[Token(Token = "0x600076D")]
		[Address(RVA = "0xFC3874", Offset = "0xFC3874", VA = "0xFC3874", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600076E")]
		[Address(RVA = "0xFC3BC0", Offset = "0xFC3BC0", VA = "0xFC3BC0")]
		public Inertia()
		{
		}
	}
	[Token(Token = "0x20000EC")]
	public class LookAtController : MonoBehaviour
	{
		[Token(Token = "0x400064E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LookAtIK ik;

		[Token(Token = "0x400064F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Header("Target Smoothing")]
		[Tooltip("The target to look at. Do not use the Target transform that is assigned to LookAtIK. Set to null if you wish to stop looking.")]
		public Transform target;

		[Token(Token = "0x4000650")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x4000651")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 offset;

		[Token(Token = "0x4000652")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The time it takes to switch targets.")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x4000653")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("The time it takes to blend in/out of LookAtIK weight.")]
		public float weightSmoothTime;

		[Token(Token = "0x4000654")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Enables smooth turning towards the target according to the parameters under this header.")]
		[Header("Turning Towards The Target")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x4000655")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Tooltip("Speed of turning towards the target using Vector3.RotateTowards.")]
		public float maxRadiansDelta;

		[Token(Token = "0x4000656")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Speed of moving towards the target using Vector3.RotateTowards.")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x4000657")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("Speed of slerping towards the target.")]
		public float slerpSpeed;

		[Token(Token = "0x4000658")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("The position of the pivot that the look at target is rotated around relative to the root of the character.")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x4000659")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Tooltip("Minimum distance of looking from the first bone. Keeps the solver from failing if the target is too close.")]
		public float minDistance;

		[Token(Token = "0x400065A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Header("RootRotation")]
		[Tooltip("Character root will be rotate around the Y axis to keep root forward within this angle from the look direction.")]
		[Range(0f, 180f)]
		public float maxRootAngle;

		[Token(Token = "0x400065B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform lastTarget;

		[Token(Token = "0x400065C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float switchWeight;

		[Token(Token = "0x400065D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float switchWeightV;

		[Token(Token = "0x400065E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float weightV;

		[Token(Token = "0x400065F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000660")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 dir;

		[Token(Token = "0x4000661")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool lastSmoothTowardsTarget;

		[Token(Token = "0x170000CB")]
		private Vector3 pivot
		{
			[Token(Token = "0x6000775")]
			[Address(RVA = "0xFC3C54", Offset = "0xFC3C54", VA = "0xFC3C54")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000773")]
		[Address(RVA = "0xFC3BEC", Offset = "0xFC3BEC", VA = "0xFC3BEC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000774")]
		[Address(RVA = "0xFC3CD8", Offset = "0xFC3CD8", VA = "0xFC3CD8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000776")]
		[Address(RVA = "0xFC41E0", Offset = "0xFC41E0", VA = "0xFC41E0")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x6000777")]
		[Address(RVA = "0xFC4364", Offset = "0xFC4364", VA = "0xFC4364")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x6000778")]
		[Address(RVA = "0xFC45B0", Offset = "0xFC45B0", VA = "0xFC45B0")]
		public LookAtController()
		{
		}
	}
	[Token(Token = "0x20000ED")]
	public abstract class OffsetModifier : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000EE")]
		public class OffsetLimits
		{
			[Token(Token = "0x4000665")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The effector type (this is just an enum)")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x4000666")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("Spring force, if zero then this is a hard limit, if not, offset can exceed the limit.")]
			public float spring;

			[Token(Token = "0x4000667")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Which axes to limit the offset on?")]
			public bool x;

			[Token(Token = "0x4000668")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			[Tooltip("Which axes to limit the offset on?")]
			public bool y;

			[Token(Token = "0x4000669")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
			[Tooltip("Which axes to limit the offset on?")]
			public bool z;

			[Token(Token = "0x400066A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[Tooltip("The limits")]
			public float minX;

			[Token(Token = "0x400066B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("The limits")]
			public float maxX;

			[Token(Token = "0x400066C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[Tooltip("The limits")]
			public float minY;

			[Token(Token = "0x400066D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("The limits")]
			public float maxY;

			[Token(Token = "0x400066E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("The limits")]
			public float minZ;

			[Token(Token = "0x400066F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("The limits")]
			public float maxZ;

			[Token(Token = "0x6000781")]
			[Address(RVA = "0xFC48A0", Offset = "0xFC48A0", VA = "0xFC48A0")]
			public void Apply(IKEffector e, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x6000782")]
			[Address(RVA = "0xFC4B40", Offset = "0xFC4B40", VA = "0xFC4B40")]
			private float SpringAxis(float value, float min, float max)
			{
				return default(float);
			}

			[Token(Token = "0x6000783")]
			[Address(RVA = "0xFC4BB0", Offset = "0xFC4BB0", VA = "0xFC4BB0")]
			private float Spring(float value, float limit, bool negative)
			{
				return default(float);
			}

			[Token(Token = "0x6000784")]
			[Address(RVA = "0xFC4BF8", Offset = "0xFC4BF8", VA = "0xFC4BF8")]
			public OffsetLimits()
			{
			}
		}

		[Token(Token = "0x20000EF")]
		[CompilerGenerated]
		private sealed class <Initiate>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000670")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000671")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000672")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifier <>4__this;

			[Token(Token = "0x170000CD")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000788")]
				[Address(RVA = "0xFC4D74", Offset = "0xFC4D74", VA = "0xFC4D74", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CE")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600078A")]
				[Address(RVA = "0xFC4DBC", Offset = "0xFC4DBC", VA = "0xFC4DBC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000785")]
			[Address(RVA = "0xFC46FC", Offset = "0xFC46FC", VA = "0xFC46FC")]
			[DebuggerHidden]
			public <Initiate>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x6000786")]
			[Address(RVA = "0xFC4C00", Offset = "0xFC4C00", VA = "0xFC4C00", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000787")]
			[Address(RVA = "0xFC4C04", Offset = "0xFC4C04", VA = "0xFC4C04", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000789")]
			[Address(RVA = "0xFC4D7C", Offset = "0xFC4D7C", VA = "0xFC4D7C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000662")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The master weight")]
		public float weight;

		[Token(Token = "0x4000663")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Reference to the FBBIK component")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000664")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected float lastTime;

		[Token(Token = "0x170000CC")]
		protected float deltaTime
		{
			[Token(Token = "0x6000779")]
			[Address(RVA = "0xFC4648", Offset = "0xFC4648", VA = "0xFC4648")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600077A")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x600077B")]
		[Address(RVA = "0xFC4668", Offset = "0xFC4668", VA = "0xFC4668", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600077C")]
		[Address(RVA = "0xFC4688", Offset = "0xFC4688", VA = "0xFC4688")]
		[IteratorStateMachine(typeof(<Initiate>d__8))]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x600077D")]
		[Address(RVA = "0xFC4724", Offset = "0xFC4724", VA = "0xFC4724")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x600077E")]
		[Address(RVA = "0xFC47F8", Offset = "0xFC47F8", VA = "0xFC47F8")]
		protected void ApplyLimits(OffsetLimits[] limits)
		{
		}

		[Token(Token = "0x600077F")]
		[Address(RVA = "0xFC4A04", Offset = "0xFC4A04", VA = "0xFC4A04", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000780")]
		[Address(RVA = "0xFC4B30", Offset = "0xFC4B30", VA = "0xFC4B30")]
		protected OffsetModifier()
		{
		}
	}
	[Token(Token = "0x20000F0")]
	public abstract class OffsetModifierVRIK : MonoBehaviour
	{
		[Token(Token = "0x20000F1")]
		[CompilerGenerated]
		private sealed class <Initiate>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000676")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000677")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000678")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifierVRIK <>4__this;

			[Token(Token = "0x170000D0")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000795")]
				[Address(RVA = "0xFC5224", Offset = "0xFC5224", VA = "0xFC5224", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D1")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000797")]
				[Address(RVA = "0xFC526C", Offset = "0xFC526C", VA = "0xFC526C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000792")]
			[Address(RVA = "0xFC4E78", Offset = "0xFC4E78", VA = "0xFC4E78")]
			[DebuggerHidden]
			public <Initiate>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000793")]
			[Address(RVA = "0xFC50B0", Offset = "0xFC50B0", VA = "0xFC50B0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000794")]
			[Address(RVA = "0xFC50B4", Offset = "0xFC50B4", VA = "0xFC50B4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000796")]
			[Address(RVA = "0xFC522C", Offset = "0xFC522C", VA = "0xFC522C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000673")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The master weight")]
		public float weight;

		[Token(Token = "0x4000674")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Reference to the VRIK component")]
		public VRIK ik;

		[Token(Token = "0x4000675")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float lastTime;

		[Token(Token = "0x170000CF")]
		protected float deltaTime
		{
			[Token(Token = "0x600078B")]
			[Address(RVA = "0xFC4DC4", Offset = "0xFC4DC4", VA = "0xFC4DC4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600078C")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x600078D")]
		[Address(RVA = "0xFC4DE4", Offset = "0xFC4DE4", VA = "0xFC4DE4", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600078E")]
		[Address(RVA = "0xFC4E04", Offset = "0xFC4E04", VA = "0xFC4E04")]
		[IteratorStateMachine(typeof(<Initiate>d__7))]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x600078F")]
		[Address(RVA = "0xFC4EA0", Offset = "0xFC4EA0", VA = "0xFC4EA0")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x6000790")]
		[Address(RVA = "0xFC4F74", Offset = "0xFC4F74", VA = "0xFC4F74", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000791")]
		[Address(RVA = "0xFC50A0", Offset = "0xFC50A0", VA = "0xFC50A0")]
		protected OffsetModifierVRIK()
		{
		}
	}
	[Token(Token = "0x20000F2")]
	public class OffsetPose : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000F3")]
		public class EffectorLink
		{
			[Token(Token = "0x400067A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x400067B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 offset;

			[Token(Token = "0x400067C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 pin;

			[Token(Token = "0x400067D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 pinWeight;

			[Token(Token = "0x600079B")]
			[Address(RVA = "0xFC5328", Offset = "0xFC5328", VA = "0xFC5328")]
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
			{
			}

			[Token(Token = "0x600079C")]
			[Address(RVA = "0xFC5680", Offset = "0xFC5680", VA = "0xFC5680")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x4000679")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x6000798")]
		[Address(RVA = "0xFC5274", Offset = "0xFC5274", VA = "0xFC5274")]
		public void Apply(IKSolverFullBodyBiped solver, float weight)
		{
		}

		[Token(Token = "0x6000799")]
		[Address(RVA = "0xFC5578", Offset = "0xFC5578", VA = "0xFC5578")]
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
		{
		}

		[Token(Token = "0x600079A")]
		[Address(RVA = "0xFC561C", Offset = "0xFC561C", VA = "0xFC561C")]
		public OffsetPose()
		{
		}
	}
	[Token(Token = "0x20000F4")]
	public class PenetrationAvoidance : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000F5")]
		public class Avoider
		{
			[Serializable]
			[Token(Token = "0x20000F6")]
			public class EffectorLink
			{
				[Token(Token = "0x4000689")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("Effector to apply the offset to.")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400068A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("Multiplier of the offset value, can be negative.")]
				public float weight;

				[Token(Token = "0x60007A3")]
				[Address(RVA = "0xFC5CD4", Offset = "0xFC5CD4", VA = "0xFC5CD4")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x400067F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Bones to start the raycast from. Multiple raycasts can be used by assigning more than 1 bone.")]
			public Transform[] raycastFrom;

			[Token(Token = "0x4000680")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The Transform to raycast towards. Usually the body part that you want to keep from penetrating.")]
			public Transform raycastTo;

			[Token(Token = "0x4000681")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Range(0f, 1f)]
			[Tooltip("If 0, will use simple raycasting, if > 0, will use sphere casting (better, but slower).")]
			public float raycastRadius;

			[Token(Token = "0x4000682")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Linking this to FBBIK effectors.")]
			public EffectorLink[] effectors;

			[Token(Token = "0x4000683")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("The time of smooth interpolation of the offset value to avoid penetration.")]
			public float smoothTimeIn;

			[Token(Token = "0x4000684")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[Tooltip("The time of smooth interpolation of the offset value blending out of penetration avoidance.")]
			public float smoothTimeOut;

			[Token(Token = "0x4000685")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[Tooltip("Layers to keep penetrating from.")]
			public LayerMask layers;

			[Token(Token = "0x4000686")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 offset;

			[Token(Token = "0x4000687")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 offsetTarget;

			[Token(Token = "0x4000688")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 offsetV;

			[Token(Token = "0x600079F")]
			[Address(RVA = "0xFC56F8", Offset = "0xFC56F8", VA = "0xFC56F8")]
			public void Solve(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x60007A0")]
			[Address(RVA = "0xFC5898", Offset = "0xFC5898", VA = "0xFC5898")]
			private Vector3 GetOffsetTarget(IKSolverFullBodyBiped solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60007A1")]
			[Address(RVA = "0xFC59A0", Offset = "0xFC59A0", VA = "0xFC59A0")]
			private Vector3 Raycast(Vector3 from, Vector3 to)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60007A2")]
			[Address(RVA = "0xFC5CC0", Offset = "0xFC5CC0", VA = "0xFC5CC0")]
			public Avoider()
			{
			}
		}

		[Token(Token = "0x400067E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Definitions of penetration avoidances.")]
		public Avoider[] avoiders;

		[Token(Token = "0x600079D")]
		[Address(RVA = "0xFC5688", Offset = "0xFC5688", VA = "0xFC5688", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600079E")]
		[Address(RVA = "0xFC5888", Offset = "0xFC5888", VA = "0xFC5888")]
		public PenetrationAvoidance()
		{
		}
	}
	[Token(Token = "0x20000F7")]
	public class Recoil : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000F8")]
		public class RecoilOffset
		{
			[Serializable]
			[Token(Token = "0x20000F9")]
			public class EffectorLink
			{
				[Token(Token = "0x40006A9")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("Type of the FBBIK effector to use")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40006AA")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("Weight of using this effector")]
				public float weight;

				[Token(Token = "0x60007B3")]
				[Address(RVA = "0xFC71B4", Offset = "0xFC71B4", VA = "0xFC71B4")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40006A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Offset vector for the associated effector when doing recoil.")]
			public Vector3 offset;

			[Token(Token = "0x40006A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[Tooltip("When firing before the last recoil has faded, how much of the current recoil offset will be maintained?")]
			[Range(0f, 1f)]
			public float additivity;

			[Token(Token = "0x40006A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Max additive recoil for automatic fire.")]
			public float maxAdditiveOffsetMag;

			[Token(Token = "0x40006A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Linking this recoil offset to FBBIK effectors.")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x40006A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 additiveOffset;

			[Token(Token = "0x40006A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lastOffset;

			[Token(Token = "0x60007B0")]
			[Address(RVA = "0xFC5E78", Offset = "0xFC5E78", VA = "0xFC5E78")]
			public void Start()
			{
			}

			[Token(Token = "0x60007B1")]
			[Address(RVA = "0xFC6A34", Offset = "0xFC6A34", VA = "0xFC6A34")]
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft)
			{
			}

			[Token(Token = "0x60007B2")]
			[Address(RVA = "0xFC71A0", Offset = "0xFC71A0", VA = "0xFC71A0")]
			public RecoilOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000FA")]
		public enum Handedness
		{
			[Token(Token = "0x40006AC")]
			Right,
			[Token(Token = "0x40006AD")]
			Left
		}

		[Token(Token = "0x400068B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Reference to the AimIK component. Optional, only used to getting the aiming direction.")]
		public AimIK aimIK;

		[Token(Token = "0x400068C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Optional head AimIK solver. This solver should only use neck and head bones and have the head as Aim Transform")]
		public AimIK headIK;

		[Token(Token = "0x400068D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Set this true if you are using IKExecutionOrder.cs or a custom script to force AimIK solve after FBBIK.")]
		public bool aimIKSolvedLast;

		[Token(Token = "0x400068E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Tooltip("Which hand is holding the weapon?")]
		public Handedness handedness;

		[Token(Token = "0x400068F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Check for 2-handed weapons.")]
		public bool twoHanded;

		[Token(Token = "0x4000690")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("Weight curve for the recoil offsets. Recoil procedure is as long as this curve.")]
		public AnimationCurve recoilWeight;

		[Token(Token = "0x4000691")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("How much is the magnitude randomized each time Recoil is called?")]
		public float magnitudeRandom;

		[Token(Token = "0x4000692")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Tooltip("How much is the rotation randomized each time Recoil is called?")]
		public Vector3 rotationRandom;

		[Token(Token = "0x4000693")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Tooltip("Rotating the primary hand bone for the recoil (in local space).")]
		public Vector3 handRotationOffset;

		[Token(Token = "0x4000694")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[Tooltip("Time of blending in another recoil when doing automatic fire.")]
		public float blendTime;

		[Token(Token = "0x4000695")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[Space(10f)]
		[Tooltip("FBBIK effector position offsets for the recoil (in aiming direction space).")]
		public RecoilOffset[] offsets;

		[Token(Token = "0x4000696")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[HideInInspector]
		public Quaternion rotationOffset;

		[Token(Token = "0x4000697")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float magnitudeMlp;

		[Token(Token = "0x4000698")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private float endTime;

		[Token(Token = "0x4000699")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Quaternion handRotation;

		[Token(Token = "0x400069A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Quaternion secondaryHandRelativeRotation;

		[Token(Token = "0x400069B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Quaternion randomRotation;

		[Token(Token = "0x400069C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float length;

		[Token(Token = "0x400069D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private bool initiated;

		[Token(Token = "0x400069E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float blendWeight;

		[Token(Token = "0x400069F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private float w;

		[Token(Token = "0x40006A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Quaternion primaryHandRotation;

		[Token(Token = "0x40006A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private bool handRotationsSet;

		[Token(Token = "0x40006A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private Vector3 aimIKAxis;

		[Token(Token = "0x170000D2")]
		public bool isFinished
		{
			[Token(Token = "0x60007A4")]
			[Address(RVA = "0xFC5CDC", Offset = "0xFC5CDC", VA = "0xFC5CDC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000D3")]
		private IKEffector primaryHandEffector
		{
			[Token(Token = "0x60007AA")]
			[Address(RVA = "0xFC6C38", Offset = "0xFC6C38", VA = "0xFC6C38")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D4")]
		private IKEffector secondaryHandEffector
		{
			[Token(Token = "0x60007AB")]
			[Address(RVA = "0xFC6C74", Offset = "0xFC6C74", VA = "0xFC6C74")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D5")]
		private Transform primaryHand
		{
			[Token(Token = "0x60007AC")]
			[Address(RVA = "0xFC6C00", Offset = "0xFC6C00", VA = "0xFC6C00")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D6")]
		private Transform secondaryHand
		{
			[Token(Token = "0x60007AD")]
			[Address(RVA = "0xFC6C1C", Offset = "0xFC6C1C", VA = "0xFC6C1C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007A5")]
		[Address(RVA = "0xFC5D00", Offset = "0xFC5D00", VA = "0xFC5D00")]
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation)
		{
		}

		[Token(Token = "0x60007A6")]
		[Address(RVA = "0xFC5D2C", Offset = "0xFC5D2C", VA = "0xFC5D2C")]
		public void Fire(float magnitude)
		{
		}

		[Token(Token = "0x60007A7")]
		[Address(RVA = "0xFC5F4C", Offset = "0xFC5F4C", VA = "0xFC5F4C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0xFC6CB0", Offset = "0xFC6CB0", VA = "0xFC6CB0")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x60007A9")]
		[Address(RVA = "0xFC6E38", Offset = "0xFC6E38", VA = "0xFC6E38")]
		private void AfterAimIK()
		{
		}

		[Token(Token = "0x60007AE")]
		[Address(RVA = "0xFC6F10", Offset = "0xFC6F10", VA = "0xFC6F10", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60007AF")]
		[Address(RVA = "0xFC7114", Offset = "0xFC7114", VA = "0xFC7114")]
		public Recoil()
		{
		}
	}
	[Token(Token = "0x20000FB")]
	public class ShoulderRotator : MonoBehaviour
	{
		[Token(Token = "0x40006AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Weight of shoulder rotation")]
		public float weight;

		[Token(Token = "0x40006AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("The greater the offset, the sooner the shoulder will start rotating")]
		public float offset;

		[Token(Token = "0x40006B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40006B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool skip;

		[Token(Token = "0x60007B4")]
		[Address(RVA = "0xFC71BC", Offset = "0xFC71BC", VA = "0xFC71BC")]
		private void Start()
		{
		}

		[Token(Token = "0x60007B5")]
		[Address(RVA = "0xFC72D0", Offset = "0xFC72D0", VA = "0xFC72D0")]
		private void RotateShoulders()
		{
		}

		[Token(Token = "0x60007B6")]
		[Address(RVA = "0xFC73AC", Offset = "0xFC73AC", VA = "0xFC73AC")]
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset)
		{
		}

		[Token(Token = "0x60007B7")]
		[Address(RVA = "0xFC77B0", Offset = "0xFC77B0", VA = "0xFC77B0")]
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x60007B8")]
		[Address(RVA = "0xFC77E4", Offset = "0xFC77E4", VA = "0xFC77E4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60007B9")]
		[Address(RVA = "0xFC7910", Offset = "0xFC7910", VA = "0xFC7910")]
		public ShoulderRotator()
		{
		}
	}
	[Token(Token = "0x20000FC")]
	public static class VRIKCalibrator
	{
		[Serializable]
		[Token(Token = "0x20000FD")]
		public class Settings
		{
			[Token(Token = "0x40006B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Multiplies character scale")]
			public float scaleMlp;

			[Token(Token = "0x40006B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("Local axis of the HMD facing forward.")]
			public Vector3 headTrackerForward;

			[Token(Token = "0x40006B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Local axis of the HMD facing up.")]
			public Vector3 headTrackerUp;

			[Token(Token = "0x40006B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("Local axis of the hand trackers pointing from the wrist towards the palm.")]
			public Vector3 handTrackerForward;

			[Token(Token = "0x40006B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[Tooltip("Local axis of the hand trackers pointing in the direction of the surface normal of the back of the hand.")]
			public Vector3 handTrackerUp;

			[Token(Token = "0x40006B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[Tooltip("Local axis of the foot trackers towards the player's forward direction.")]
			public Vector3 footTrackerForward;

			[Token(Token = "0x40006B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("Local axis of the foot tracker towards the up direction.")]
			public Vector3 footTrackerUp;

			[Token(Token = "0x40006B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[Space(10f)]
			[Tooltip("Offset of the head bone from the HMD in (headTrackerForward, headTrackerUp) space relative to the head tracker.")]
			public Vector3 headOffset;

			[Token(Token = "0x40006BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[Tooltip("Offset of the hand bones from the hand trackers in (handTrackerForward, handTrackerUp) space relative to the hand trackers.")]
			public Vector3 handOffset;

			[Token(Token = "0x40006BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[Tooltip("Forward offset of the foot bones from the foot trackers.")]
			public float footForwardOffset;

			[Token(Token = "0x40006BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[Tooltip("Inward offset of the foot bones from the foot trackers.")]
			public float footInwardOffset;

			[Token(Token = "0x40006BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[Range(-180f, 180f)]
			[Tooltip("Used for adjusting foot heading relative to the foot trackers.")]
			public float footHeadingOffset;

			[Token(Token = "0x40006BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[Range(0f, 1f)]
			public float pelvisPositionWeight;

			[Token(Token = "0x40006BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[Range(0f, 1f)]
			public float pelvisRotationWeight;

			[Token(Token = "0x60007C9")]
			[Address(RVA = "0xFCBB00", Offset = "0xFCBB00", VA = "0xFCBB00")]
			public Settings()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000FE")]
		public class CalibrationData
		{
			[Serializable]
			[Token(Token = "0x20000FF")]
			public class Target
			{
				[Token(Token = "0x40006CC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public bool used;

				[Token(Token = "0x40006CD")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				public Vector3 localPosition;

				[Token(Token = "0x40006CE")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public Quaternion localRotation;

				[Token(Token = "0x60007CB")]
				[Address(RVA = "0xFC9664", Offset = "0xFC9664", VA = "0xFC9664")]
				public Target(Transform t)
				{
				}

				[Token(Token = "0x60007CC")]
				[Address(RVA = "0xFCA0C4", Offset = "0xFCA0C4", VA = "0xFCA0C4")]
				public void SetTo(Transform t)
				{
				}
			}

			[Token(Token = "0x40006C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float scale;

			[Token(Token = "0x40006C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Target head;

			[Token(Token = "0x40006C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Target leftHand;

			[Token(Token = "0x40006C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Target rightHand;

			[Token(Token = "0x40006C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Target pelvis;

			[Token(Token = "0x40006C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Target leftFoot;

			[Token(Token = "0x40006C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Target rightFoot;

			[Token(Token = "0x40006C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Target leftLegGoal;

			[Token(Token = "0x40006C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Target rightLegGoal;

			[Token(Token = "0x40006C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Vector3 pelvisTargetRight;

			[Token(Token = "0x40006CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			public float pelvisPositionWeight;

			[Token(Token = "0x40006CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public float pelvisRotationWeight;

			[Token(Token = "0x60007CA")]
			[Address(RVA = "0xFC8D68", Offset = "0xFC8D68", VA = "0xFC8D68")]
			public CalibrationData()
			{
			}
		}

		[Token(Token = "0x60007BA")]
		[Address(RVA = "0xFC7924", Offset = "0xFC7924", VA = "0xFC7924")]
		public static void RecalibrateScale(VRIK ik, CalibrationData data, Settings settings)
		{
		}

		[Token(Token = "0x60007BB")]
		[Address(RVA = "0xFC793C", Offset = "0xFC793C", VA = "0xFC793C")]
		public static void RecalibrateScale(VRIK ik, CalibrationData data, float scaleMlp)
		{
		}

		[Token(Token = "0x60007BC")]
		[Address(RVA = "0xFC7A64", Offset = "0xFC7A64", VA = "0xFC7A64")]
		private static void CalibrateScale(VRIK ik, Settings settings)
		{
		}

		[Token(Token = "0x60007BD")]
		[Address(RVA = "0xFC7984", Offset = "0xFC7984", VA = "0xFC7984")]
		private static void CalibrateScale(VRIK ik, float scaleMlp = 1f)
		{
		}

		[Token(Token = "0x60007BE")]
		[Address(RVA = "0xFC7A7C", Offset = "0xFC7A7C", VA = "0xFC7A7C")]
		public static CalibrationData Calibrate(VRIK ik, Settings settings, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
			return null;
		}

		[Token(Token = "0x60007BF")]
		[Address(RVA = "0xFC8D70", Offset = "0xFC8D70", VA = "0xFC8D70")]
		private static void CalibrateLeg(Settings settings, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0xFC9718", Offset = "0xFC9718", VA = "0xFC9718")]
		public static void Calibrate(VRIK ik, CalibrationData data, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
		}

		[Token(Token = "0x60007C1")]
		[Address(RVA = "0xFCA120", Offset = "0xFCA120", VA = "0xFCA120")]
		private static void CalibrateLeg(CalibrationData data, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Token(Token = "0x60007C2")]
		[Address(RVA = "0xFCA550", Offset = "0xFCA550", VA = "0xFCA550")]
		public static CalibrationData Calibrate(VRIK ik, Transform centerEyeAnchor, Transform leftHandAnchor, Transform rightHandAnchor, Vector3 centerEyePositionOffset, Vector3 centerEyeRotationOffset, Vector3 handPositionOffset, Vector3 handRotationOffset, float scaleMlp = 1f)
		{
			return null;
		}

		[Token(Token = "0x60007C3")]
		[Address(RVA = "0xFCA784", Offset = "0xFCA784", VA = "0xFCA784")]
		public static void CalibrateHead(VRIK ik, Transform centerEyeAnchor, Vector3 anchorPositionOffset, Vector3 anchorRotationOffset)
		{
		}

		[Token(Token = "0x60007C4")]
		[Address(RVA = "0xFCAF30", Offset = "0xFCAF30", VA = "0xFCAF30")]
		public static void CalibrateBody(VRIK ik, Transform pelvisTracker, Vector3 trackerPositionOffset, Vector3 trackerRotationOffset)
		{
		}

		[Token(Token = "0x60007C5")]
		[Address(RVA = "0xFCAD18", Offset = "0xFCAD18", VA = "0xFCAD18")]
		public static void CalibrateHands(VRIK ik, Transform leftHandAnchor, Transform rightHandAnchor, Vector3 anchorPositionOffset, Vector3 anchorRotationOffset)
		{
		}

		[Token(Token = "0x60007C6")]
		[Address(RVA = "0xFCB1E4", Offset = "0xFCB1E4", VA = "0xFCB1E4")]
		private static void CalibrateHand(VRIK ik, Transform anchor, Vector3 positionOffset, Vector3 rotationOffset, bool isLeft)
		{
		}

		[Token(Token = "0x60007C7")]
		[Address(RVA = "0xFCB6D4", Offset = "0xFCB6D4", VA = "0xFCB6D4")]
		public static Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007C8")]
		[Address(RVA = "0xFCB7B8", Offset = "0xFCB7B8", VA = "0xFCB7B8")]
		public static Vector3 GuessPalmToThumbAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x2000100")]
	public class VRIKLODController : MonoBehaviour
	{
		[Token(Token = "0x40006CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Renderer LODRenderer;

		[Token(Token = "0x40006D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float LODDistance;

		[Token(Token = "0x40006D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool allowCulled;

		[Token(Token = "0x40006D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private VRIK ik;

		[Token(Token = "0x60007CD")]
		[Address(RVA = "0xFCBC94", Offset = "0xFCBC94", VA = "0xFCBC94")]
		private void Start()
		{
		}

		[Token(Token = "0x60007CE")]
		[Address(RVA = "0xFCBCEC", Offset = "0xFCBCEC", VA = "0xFCBCEC")]
		private void Update()
		{
		}

		[Token(Token = "0x60007CF")]
		[Address(RVA = "0xFCBD14", Offset = "0xFCBD14", VA = "0xFCBD14")]
		private int GetLODLevel()
		{
			return default(int);
		}

		[Token(Token = "0x60007D0")]
		[Address(RVA = "0xFCBE34", Offset = "0xFCBE34", VA = "0xFCBE34")]
		public VRIKLODController()
		{
		}
	}
	[Token(Token = "0x2000101")]
	public class VRIKRootController : MonoBehaviour
	{
		[Token(Token = "0x40006D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform pelvisTarget;

		[Token(Token = "0x40006D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform leftFootTarget;

		[Token(Token = "0x40006D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform rightFootTarget;

		[Token(Token = "0x40006D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private VRIK ik;

		[Token(Token = "0x170000D7")]
		public Vector3 pelvisTargetRight
		{
			[Token(Token = "0x60007D1")]
			[Address(RVA = "0xFCBE4C", Offset = "0xFCBE4C", VA = "0xFCBE4C")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60007D2")]
			[Address(RVA = "0xFCBE58", Offset = "0xFCBE58", VA = "0xFCBE58")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60007D3")]
		[Address(RVA = "0xFCBE64", Offset = "0xFCBE64", VA = "0xFCBE64")]
		private void Awake()
		{
		}

		[Token(Token = "0x60007D4")]
		[Address(RVA = "0xFC9450", Offset = "0xFC9450", VA = "0xFC9450")]
		public void Calibrate()
		{
		}

		[Token(Token = "0x60007D5")]
		[Address(RVA = "0xFCA3B0", Offset = "0xFCA3B0", VA = "0xFCA3B0")]
		public void Calibrate(VRIKCalibrator.CalibrationData data)
		{
		}

		[Token(Token = "0x60007D6")]
		[Address(RVA = "0xFCBF80", Offset = "0xFCBF80", VA = "0xFCBF80")]
		private void OnPreUpdate()
		{
		}

		[Token(Token = "0x60007D7")]
		[Address(RVA = "0xFCC348", Offset = "0xFCC348", VA = "0xFCC348")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60007D8")]
		[Address(RVA = "0xFCC474", Offset = "0xFCC474", VA = "0xFCC474")]
		public VRIKRootController()
		{
		}
	}
}
namespace RootMotion.Demos
{
	[Token(Token = "0x2000102")]
	public class FKOffset : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000103")]
		public class Offset
		{
			[Token(Token = "0x40006DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[HideInInspector]
			public string name;

			[Token(Token = "0x40006DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public HumanBodyBones bone;

			[Token(Token = "0x40006DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 rotationOffset;

			[Token(Token = "0x40006DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Transform t;

			[Token(Token = "0x60007DD")]
			[Address(RVA = "0xFCC538", Offset = "0xFCC538", VA = "0xFCC538")]
			public void Apply(Animator animator)
			{
			}

			[Token(Token = "0x60007DE")]
			[Address(RVA = "0xFCC7B4", Offset = "0xFCC7B4", VA = "0xFCC7B4")]
			public Offset()
			{
			}
		}

		[Token(Token = "0x40006D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Offset[] offsets;

		[Token(Token = "0x40006D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x60007D9")]
		[Address(RVA = "0xFCC47C", Offset = "0xFCC47C", VA = "0xFCC47C")]
		private void Start()
		{
		}

		[Token(Token = "0x60007DA")]
		[Address(RVA = "0xFCC4D4", Offset = "0xFCC4D4", VA = "0xFCC4D4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007DB")]
		[Address(RVA = "0xFCC6E8", Offset = "0xFCC6E8", VA = "0xFCC6E8")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60007DC")]
		[Address(RVA = "0xFCC7AC", Offset = "0xFCC7AC", VA = "0xFCC7AC")]
		public FKOffset()
		{
		}
	}
	[Token(Token = "0x2000104")]
	public class AimBoxing : MonoBehaviour
	{
		[Token(Token = "0x40006DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aimIK;

		[Token(Token = "0x40006DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform pin;

		[Token(Token = "0x60007DF")]
		[Address(RVA = "0xFCC7BC", Offset = "0xFCC7BC", VA = "0xFCC7BC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007E0")]
		[Address(RVA = "0xFCC83C", Offset = "0xFCC83C", VA = "0xFCC83C")]
		public AimBoxing()
		{
		}
	}
	[Token(Token = "0x2000105")]
	public class AimSwing : MonoBehaviour
	{
		[Token(Token = "0x40006E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK ik;

		[Token(Token = "0x40006E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The direction in which the weapon is aimed in animation (in character space). Tweak this value to adjust the aiming.")]
		public Vector3 animatedAimDirection;

		[Token(Token = "0x60007E1")]
		[Address(RVA = "0xFCC844", Offset = "0xFCC844", VA = "0xFCC844")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007E2")]
		[Address(RVA = "0xFCC8B0", Offset = "0xFCC8B0", VA = "0xFCC8B0")]
		public AimSwing()
		{
		}
	}
	[Token(Token = "0x2000106")]
	public class SecondHandOnGun : MonoBehaviour
	{
		[Token(Token = "0x40006E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aim;

		[Token(Token = "0x40006E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LimbIK leftArmIK;

		[Token(Token = "0x40006E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftHand;

		[Token(Token = "0x40006E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform rightHand;

		[Token(Token = "0x40006E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GrounderFBBIK grounder;

		[Token(Token = "0x40006E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Vector3 leftHandPositionOffset;

		[Token(Token = "0x40006E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public Vector3 leftHandRotationOffset;

		[Token(Token = "0x40006E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 leftHandPosRelToRight;

		[Token(Token = "0x40006EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private Quaternion leftHandRotRelToRight;

		[Token(Token = "0x60007E3")]
		[Address(RVA = "0xFCC910", Offset = "0xFCC910", VA = "0xFCC910")]
		private void Start()
		{
		}

		[Token(Token = "0x60007E4")]
		[Address(RVA = "0xFCC9C8", Offset = "0xFCC9C8", VA = "0xFCC9C8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007E5")]
		[Address(RVA = "0xFCCCF4", Offset = "0xFCCCF4", VA = "0xFCCCF4")]
		public SecondHandOnGun()
		{
		}
	}
	[Token(Token = "0x2000107")]
	public class SimpleAimingSystem : MonoBehaviour
	{
		[Token(Token = "0x40006EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("AimPoser is a tool that returns an animation name based on direction.")]
		public AimPoser aimPoser;

		[Token(Token = "0x40006EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Reference to the AimIK component.")]
		public AimIK aim;

		[Token(Token = "0x40006ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Reference to the LookAt component (only used for the head in this instance).")]
		public LookAtIK lookAt;

		[Token(Token = "0x40006EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Reference to the Animator component.")]
		public Animator animator;

		[Token(Token = "0x40006EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Time of cross-fading from pose to pose.")]
		public float crossfadeTime;

		[Token(Token = "0x40006F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("Will keep the aim target at a distance.")]
		public float minAimDistance;

		[Token(Token = "0x40006F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private AimPoser.Pose aimPose;

		[Token(Token = "0x40006F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private AimPoser.Pose lastPose;

		[Token(Token = "0x60007E6")]
		[Address(RVA = "0xFCCCFC", Offset = "0xFCCCFC", VA = "0xFCCCFC")]
		private void Start()
		{
		}

		[Token(Token = "0x60007E7")]
		[Address(RVA = "0xFCCD34", Offset = "0xFCCD34", VA = "0xFCCD34")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007E8")]
		[Address(RVA = "0xFCCDE0", Offset = "0xFCCDE0", VA = "0xFCCDE0")]
		private void Pose()
		{
		}

		[Token(Token = "0x60007E9")]
		[Address(RVA = "0xFCCF48", Offset = "0xFCCF48", VA = "0xFCCF48")]
		private void LimitAimTarget()
		{
		}

		[Token(Token = "0x60007EA")]
		[Address(RVA = "0xFCD104", Offset = "0xFCD104", VA = "0xFCD104")]
		private void DirectCrossFade(string state, float target)
		{
		}

		[Token(Token = "0x60007EB")]
		[Address(RVA = "0xFCD194", Offset = "0xFCD194", VA = "0xFCD194")]
		public SimpleAimingSystem()
		{
		}
	}
	[Token(Token = "0x2000108")]
	public class TerrainOffset : MonoBehaviour
	{
		[Token(Token = "0x40006F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aimIK;

		[Token(Token = "0x40006F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 raycastOffset;

		[Token(Token = "0x40006F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public LayerMask raycastLayers;

		[Token(Token = "0x40006F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float min;

		[Token(Token = "0x40006F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float max;

		[Token(Token = "0x40006F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float lerpSpeed;

		[Token(Token = "0x40006F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private RaycastHit hit;

		[Token(Token = "0x40006FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 offset;

		[Token(Token = "0x60007EC")]
		[Address(RVA = "0xFCD1A8", Offset = "0xFCD1A8", VA = "0xFCD1A8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007ED")]
		[Address(RVA = "0xFCD314", Offset = "0xFCD314", VA = "0xFCD314")]
		private Vector3 GetGroundHeightOffset(Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007EE")]
		[Address(RVA = "0xFCD510", Offset = "0xFCD510", VA = "0xFCD510")]
		public TerrainOffset()
		{
		}
	}
	[Token(Token = "0x2000109")]
	public class BipedIKvsAnimatorIK : MonoBehaviour
	{
		[Token(Token = "0x40006FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[LargeHeader("References")]
		public Animator animator;

		[Token(Token = "0x40006FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BipedIK bipedIK;

		[Token(Token = "0x40006FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[LargeHeader("Look At")]
		public Transform lookAtTargetBiped;

		[Token(Token = "0x40006FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform lookAtTargetAnimator;

		[Token(Token = "0x40006FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 1f)]
		public float lookAtWeight;

		[Token(Token = "0x4000700")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Range(0f, 1f)]
		public float lookAtBodyWeight;

		[Token(Token = "0x4000701")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Range(0f, 1f)]
		public float lookAtHeadWeight;

		[Token(Token = "0x4000702")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Range(0f, 1f)]
		public float lookAtEyesWeight;

		[Token(Token = "0x4000703")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Range(0f, 1f)]
		public float lookAtClampWeight;

		[Token(Token = "0x4000704")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Range(0f, 1f)]
		public float lookAtClampWeightHead;

		[Token(Token = "0x4000705")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Range(0f, 1f)]
		public float lookAtClampWeightEyes;

		[Token(Token = "0x4000706")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[LargeHeader("Foot")]
		public Transform footTargetBiped;

		[Token(Token = "0x4000707")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform footTargetAnimator;

		[Token(Token = "0x4000708")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Range(0f, 1f)]
		public float footPositionWeight;

		[Token(Token = "0x4000709")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[Range(0f, 1f)]
		public float footRotationWeight;

		[Token(Token = "0x400070A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[LargeHeader("Hand")]
		public Transform handTargetBiped;

		[Token(Token = "0x400070B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform handTargetAnimator;

		[Token(Token = "0x400070C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Range(0f, 1f)]
		public float handPositionWeight;

		[Token(Token = "0x400070D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[Range(0f, 1f)]
		public float handRotationWeight;

		[Token(Token = "0x60007EF")]
		[Address(RVA = "0xFCD540", Offset = "0xFCD540", VA = "0xFCD540")]
		private void OnAnimatorIK(int layer)
		{
		}

		[Token(Token = "0x60007F0")]
		[Address(RVA = "0xFCD96C", Offset = "0xFCD96C", VA = "0xFCD96C")]
		public BipedIKvsAnimatorIK()
		{
		}
	}
	[Token(Token = "0x200010A")]
	public class MechSpider : MonoBehaviour
	{
		[Token(Token = "0x400070E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LayerMask raycastLayers;

		[Token(Token = "0x400070F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float scale;

		[Token(Token = "0x4000710")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform body;

		[Token(Token = "0x4000711")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MechSpiderLeg[] legs;

		[Token(Token = "0x4000712")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float legRotationWeight;

		[Token(Token = "0x4000713")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float rootPositionSpeed;

		[Token(Token = "0x4000714")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float rootRotationSpeed;

		[Token(Token = "0x4000715")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float breatheSpeed;

		[Token(Token = "0x4000716")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float breatheMagnitude;

		[Token(Token = "0x4000717")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float height;

		[Token(Token = "0x4000718")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float minHeight;

		[Token(Token = "0x4000719")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float raycastHeight;

		[Token(Token = "0x400071A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float raycastDistance;

		[Token(Token = "0x400071C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 lastPosition;

		[Token(Token = "0x400071D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 defaultBodyLocalPosition;

		[Token(Token = "0x400071E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float sine;

		[Token(Token = "0x400071F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private RaycastHit rootHit;

		[Token(Token = "0x170000D8")]
		public Vector3 velocity
		{
			[Token(Token = "0x60007F1")]
			[Address(RVA = "0xFCD98C", Offset = "0xFCD98C", VA = "0xFCD98C")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60007F2")]
			[Address(RVA = "0xFCD998", Offset = "0xFCD998", VA = "0xFCD998")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60007F3")]
		[Address(RVA = "0xFCD9A4", Offset = "0xFCD9A4", VA = "0xFCD9A4")]
		private void Start()
		{
		}

		[Token(Token = "0x60007F4")]
		[Address(RVA = "0xFCD9D4", Offset = "0xFCD9D4", VA = "0xFCD9D4")]
		private void Update()
		{
		}

		[Token(Token = "0x60007F5")]
		[Address(RVA = "0xFCE358", Offset = "0xFCE358", VA = "0xFCE358")]
		private Vector3 GetLegCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007F6")]
		[Address(RVA = "0xFCE0D4", Offset = "0xFCE0D4", VA = "0xFCE0D4")]
		private Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007F7")]
		[Address(RVA = "0xFCE468", Offset = "0xFCE468", VA = "0xFCE468")]
		public MechSpider()
		{
		}
	}
	[Token(Token = "0x200010B")]
	public class MechSpiderController : MonoBehaviour
	{
		[Token(Token = "0x4000720")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpider mechSpider;

		[Token(Token = "0x4000721")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform cameraTransform;

		[Token(Token = "0x4000722")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float speed;

		[Token(Token = "0x4000723")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float turnSpeed;

		[Token(Token = "0x170000D9")]
		public Vector3 inputVector
		{
			[Token(Token = "0x60007F8")]
			[Address(RVA = "0xFCE494", Offset = "0xFCE494", VA = "0xFCE494")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60007F9")]
		[Address(RVA = "0xFCE514", Offset = "0xFCE514", VA = "0xFCE514")]
		private void Update()
		{
		}

		[Token(Token = "0x60007FA")]
		[Address(RVA = "0xFCE858", Offset = "0xFCE858", VA = "0xFCE858")]
		public MechSpiderController()
		{
		}
	}
	[Token(Token = "0x200010C")]
	public class MechSpiderLeg : MonoBehaviour
	{
		[Token(Token = "0x200010D")]
		[CompilerGenerated]
		private sealed class <Step>d__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400073A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400073B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400073C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MechSpiderLeg <>4__this;

			[Token(Token = "0x400073D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 stepStartPosition;

			[Token(Token = "0x400073E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public Vector3 targetPosition;

			[Token(Token = "0x170000DC")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000809")]
				[Address(RVA = "0xFCF8B0", Offset = "0xFCF8B0", VA = "0xFCF8B0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000DD")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600080B")]
				[Address(RVA = "0xFCF8F8", Offset = "0xFCF8F8", VA = "0xFCF8F8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000806")]
			[Address(RVA = "0xFCF548", Offset = "0xFCF548", VA = "0xFCF548")]
			[DebuggerHidden]
			public <Step>d__33(int <>1__state)
			{
			}

			[Token(Token = "0x6000807")]
			[Address(RVA = "0xFCF600", Offset = "0xFCF600", VA = "0xFCF600", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000808")]
			[Address(RVA = "0xFCF604", Offset = "0xFCF604", VA = "0xFCF604", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600080A")]
			[Address(RVA = "0xFCF8B8", Offset = "0xFCF8B8", VA = "0xFCF8B8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000724")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpider mechSpider;

		[Token(Token = "0x4000725")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MechSpiderLeg unSync;

		[Token(Token = "0x4000726")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 offset;

		[Token(Token = "0x4000727")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float minDelay;

		[Token(Token = "0x4000728")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float maxOffset;

		[Token(Token = "0x4000729")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float stepSpeed;

		[Token(Token = "0x400072A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float footHeight;

		[Token(Token = "0x400072B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float velocityPrediction;

		[Token(Token = "0x400072C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float raycastFocus;

		[Token(Token = "0x400072D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AnimationCurve yOffset;

		[Token(Token = "0x400072E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform foot;

		[Token(Token = "0x400072F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 footUpAxis;

		[Token(Token = "0x4000730")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float footRotationSpeed;

		[Token(Token = "0x4000731")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public ParticleSystem sand;

		[Token(Token = "0x4000732")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private IK ik;

		[Token(Token = "0x4000733")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float stepProgress;

		[Token(Token = "0x4000734")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float lastStepTime;

		[Token(Token = "0x4000735")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 defaultPosition;

		[Token(Token = "0x4000736")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private RaycastHit hit;

		[Token(Token = "0x4000737")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Quaternion lastFootLocalRotation;

		[Token(Token = "0x4000738")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Vector3 smoothHitNormal;

		[Token(Token = "0x4000739")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Vector3 lastStepPosition;

		[Token(Token = "0x170000DA")]
		public bool isStepping
		{
			[Token(Token = "0x60007FB")]
			[Address(RVA = "0xFCE86C", Offset = "0xFCE86C", VA = "0xFCE86C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000DB")]
		public Vector3 position
		{
			[Token(Token = "0x60007FC")]
			[Address(RVA = "0xFCE438", Offset = "0xFCE438", VA = "0xFCE438")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60007FD")]
			[Address(RVA = "0xFCE880", Offset = "0xFCE880", VA = "0xFCE880")]
			set
			{
			}
		}

		[Token(Token = "0x60007FE")]
		[Address(RVA = "0xFCE8CC", Offset = "0xFCE8CC", VA = "0xFCE8CC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60007FF")]
		[Address(RVA = "0xFCEB4C", Offset = "0xFCEB4C", VA = "0xFCEB4C")]
		private void AfterIK()
		{
		}

		[Token(Token = "0x6000800")]
		[Address(RVA = "0xFCED24", Offset = "0xFCED24", VA = "0xFCED24")]
		private void Start()
		{
		}

		[Token(Token = "0x6000801")]
		[Address(RVA = "0xFCEF48", Offset = "0xFCEF48", VA = "0xFCEF48")]
		private Vector3 GetStepTarget(out bool stepFound, float focus, float distance)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000802")]
		[Address(RVA = "0xFCF1A8", Offset = "0xFCF1A8", VA = "0xFCF1A8")]
		private void UpdatePosition(float distance)
		{
		}

		[Token(Token = "0x6000803")]
		[Address(RVA = "0xFCF310", Offset = "0xFCF310", VA = "0xFCF310")]
		private void Update()
		{
		}

		[Token(Token = "0x6000804")]
		[Address(RVA = "0xFCEE98", Offset = "0xFCEE98", VA = "0xFCEE98")]
		[IteratorStateMachine(typeof(<Step>d__33))]
		private IEnumerator Step(Vector3 stepStartPosition, Vector3 targetPosition)
		{
			return null;
		}

		[Token(Token = "0x6000805")]
		[Address(RVA = "0xFCF570", Offset = "0xFCF570", VA = "0xFCF570")]
		public MechSpiderLeg()
		{
		}
	}
	[Token(Token = "0x200010E")]
	public class MechSpiderParticles : MonoBehaviour
	{
		[Token(Token = "0x400073F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpiderController mechSpiderController;

		[Token(Token = "0x4000740")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ParticleSystem particles;

		[Token(Token = "0x600080C")]
		[Address(RVA = "0xFCF900", Offset = "0xFCF900", VA = "0xFCF900")]
		private void Start()
		{
		}

		[Token(Token = "0x600080D")]
		[Address(RVA = "0xFCF9DC", Offset = "0xFCF9DC", VA = "0xFCF9DC")]
		private void Update()
		{
		}

		[Token(Token = "0x600080E")]
		[Address(RVA = "0xFCFC50", Offset = "0xFCFC50", VA = "0xFCFC50")]
		public MechSpiderParticles()
		{
		}
	}
	[Token(Token = "0x200010F")]
	public class AnimationWarping : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000110")]
		public struct Warp
		{
			[Token(Token = "0x4000745")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[Tooltip("Layer of the 'Animation State' in the Animator.")]
			public int animationLayer;

			[Token(Token = "0x4000746")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[Tooltip("Name of the state in the Animator to warp.")]
			public string animationState;

			[Token(Token = "0x4000747")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Warping weight by normalized time of the animation state.")]
			public AnimationCurve weightCurve;

			[Token(Token = "0x4000748")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Animated point to warp from. This should be in character space so keep this Transform parented to the root of the character.")]
			public Transform warpFrom;

			[Token(Token = "0x4000749")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("World space point to warp to.")]
			public Transform warpTo;

			[Token(Token = "0x400074A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Which FBBIK effector to use?")]
			public FullBodyBipedEffector effector;
		}

		[Serializable]
		[Token(Token = "0x2000111")]
		public enum EffectorMode
		{
			[Token(Token = "0x400074C")]
			PositionOffset,
			[Token(Token = "0x400074D")]
			Position
		}

		[Token(Token = "0x4000741")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Reference to the Animator component to use")]
		public Animator animator;

		[Token(Token = "0x4000742")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Using effector.positionOffset or effector.position with effector.positionWeight? The former will enable you to use effector.position for other things, the latter will weigh in the effectors, hence using Reach and Pull in the process.")]
		public EffectorMode effectorMode;

		[Token(Token = "0x4000743")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Space(10f)]
		[Tooltip("The array of warps, can have multiple simultaneous warps.")]
		public Warp[] warps;

		[Token(Token = "0x4000744")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private EffectorMode lastMode;

		[Token(Token = "0x600080F")]
		[Address(RVA = "0xFCFC58", Offset = "0xFCFC58", VA = "0xFCFC58", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000810")]
		[Address(RVA = "0xFCFC84", Offset = "0xFCFC84", VA = "0xFCFC84")]
		public float GetWarpWeight(int warpIndex)
		{
			return default(float);
		}

		[Token(Token = "0x6000811")]
		[Address(RVA = "0xFCFE9C", Offset = "0xFCFE9C", VA = "0xFCFE9C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000812")]
		[Address(RVA = "0xFD0154", Offset = "0xFD0154", VA = "0xFD0154")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000813")]
		[Address(RVA = "0xFD01E8", Offset = "0xFD01E8", VA = "0xFD01E8")]
		public AnimationWarping()
		{
		}
	}
	[Token(Token = "0x2000112")]
	public class AnimatorController3rdPerson : MonoBehaviour
	{
		[Token(Token = "0x400074E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float rotateSpeed;

		[Token(Token = "0x400074F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float blendSpeed;

		[Token(Token = "0x4000750")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float maxAngle;

		[Token(Token = "0x4000751")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float moveSpeed;

		[Token(Token = "0x4000752")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float rootMotionWeight;

		[Token(Token = "0x4000753")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected Animator animator;

		[Token(Token = "0x4000754")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected Vector3 moveBlend;

		[Token(Token = "0x4000755")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		protected Vector3 moveInput;

		[Token(Token = "0x4000756")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected Vector3 velocity;

		[Token(Token = "0x6000814")]
		[Address(RVA = "0xFD01F8", Offset = "0xFD01F8", VA = "0xFD01F8", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000815")]
		[Address(RVA = "0xFD0250", Offset = "0xFD0250", VA = "0xFD0250")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x6000816")]
		[Address(RVA = "0xFD0458", Offset = "0xFD0458", VA = "0xFD0458", Slot = "5")]
		public virtual void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x6000817")]
		[Address(RVA = "0xFD0680", Offset = "0xFD0680", VA = "0xFD0680")]
		public AnimatorController3rdPerson()
		{
		}
	}
	[Token(Token = "0x2000113")]
	public class AnimatorController3rdPersonIK : AnimatorController3rdPerson
	{
		[Token(Token = "0x4000757")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Range(0f, 1f)]
		public float headLookWeight;

		[Token(Token = "0x4000758")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 gunHoldOffset;

		[Token(Token = "0x4000759")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 leftHandOffset;

		[Token(Token = "0x400075A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Recoil recoil;

		[Token(Token = "0x400075B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private AimIK aim;

		[Token(Token = "0x400075C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x400075D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 headLookAxis;

		[Token(Token = "0x400075E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Vector3 leftHandPosRelToRightHand;

		[Token(Token = "0x400075F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Quaternion leftHandRotRelToRightHand;

		[Token(Token = "0x4000760")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3 aimTarget;

		[Token(Token = "0x4000761")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion rightHandRotation;

		[Token(Token = "0x6000818")]
		[Address(RVA = "0xFD0694", Offset = "0xFD0694", VA = "0xFD0694", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000819")]
		[Address(RVA = "0xFD0868", Offset = "0xFD0868", VA = "0xFD0868", Slot = "5")]
		public override void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x600081A")]
		[Address(RVA = "0xFD08D8", Offset = "0xFD08D8", VA = "0xFD08D8")]
		private void Read()
		{
		}

		[Token(Token = "0x600081B")]
		[Address(RVA = "0xFD0A10", Offset = "0xFD0A10", VA = "0xFD0A10")]
		private void AimIK()
		{
		}

		[Token(Token = "0x600081C")]
		[Address(RVA = "0xFD0A6C", Offset = "0xFD0A6C", VA = "0xFD0A6C")]
		private void FBBIK()
		{
		}

		[Token(Token = "0x600081D")]
		[Address(RVA = "0xFD10D4", Offset = "0xFD10D4", VA = "0xFD10D4")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x600081E")]
		[Address(RVA = "0xFD0EE8", Offset = "0xFD0EE8", VA = "0xFD0EE8")]
		private void HeadLookAt(Vector3 lookAtTarget)
		{
		}

		[Token(Token = "0x600081F")]
		[Address(RVA = "0xFD1378", Offset = "0xFD1378", VA = "0xFD1378")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000820")]
		[Address(RVA = "0xFD14A4", Offset = "0xFD14A4", VA = "0xFD14A4")]
		public AnimatorController3rdPersonIK()
		{
		}
	}
	[Token(Token = "0x2000114")]
	public class CharacterAnimationThirdPersonIK : CharacterAnimationThirdPerson
	{
		[Token(Token = "0x4000762")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x6000821")]
		[Address(RVA = "0xFD14C0", Offset = "0xFD14C0", VA = "0xFD14C0", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000822")]
		[Address(RVA = "0xFD1524", Offset = "0xFD1524", VA = "0xFD1524", Slot = "7")]
		protected override void LateUpdate()
		{
		}

		[Token(Token = "0x6000823")]
		[Address(RVA = "0xFD1860", Offset = "0xFD1860", VA = "0xFD1860")]
		private void RotateEffector(IKEffector effector, Quaternion rotation, float mlp)
		{
		}

		[Token(Token = "0x6000824")]
		[Address(RVA = "0xFD1950", Offset = "0xFD1950", VA = "0xFD1950")]
		public CharacterAnimationThirdPersonIK()
		{
		}
	}
	[Token(Token = "0x2000115")]
	public class CharacterController3rdPerson : MonoBehaviour
	{
		[Token(Token = "0x4000763")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CameraController cam;

		[Token(Token = "0x4000764")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private AnimatorController3rdPerson animatorController;

		[Token(Token = "0x170000DE")]
		private static Vector3 inputVector
		{
			[Token(Token = "0x6000827")]
			[Address(RVA = "0xFD1BB8", Offset = "0xFD1BB8", VA = "0xFD1BB8")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000DF")]
		private static Vector3 inputVectorRaw
		{
			[Token(Token = "0x6000828")]
			[Address(RVA = "0xFD1C38", Offset = "0xFD1C38", VA = "0xFD1C38")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000825")]
		[Address(RVA = "0xFD1958", Offset = "0xFD1958", VA = "0xFD1958")]
		private void Start()
		{
		}

		[Token(Token = "0x6000826")]
		[Address(RVA = "0xFD19C8", Offset = "0xFD19C8", VA = "0xFD19C8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000829")]
		[Address(RVA = "0xFD1CB8", Offset = "0xFD1CB8", VA = "0xFD1CB8")]
		public CharacterController3rdPerson()
		{
		}
	}
	[Token(Token = "0x2000116")]
	public class EffectorOffset : OffsetModifier
	{
		[Token(Token = "0x4000765")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Range(0f, 1f)]
		public float handsMaintainRelativePositionWeight;

		[Token(Token = "0x4000766")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 bodyOffset;

		[Token(Token = "0x4000767")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 leftShoulderOffset;

		[Token(Token = "0x4000768")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rightShoulderOffset;

		[Token(Token = "0x4000769")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Vector3 leftThighOffset;

		[Token(Token = "0x400076A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 rightThighOffset;

		[Token(Token = "0x400076B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 leftHandOffset;

		[Token(Token = "0x400076C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Vector3 rightHandOffset;

		[Token(Token = "0x400076D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public Vector3 leftFootOffset;

		[Token(Token = "0x400076E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 rightFootOffset;

		[Token(Token = "0x600082A")]
		[Address(RVA = "0xFD1CC0", Offset = "0xFD1CC0", VA = "0xFD1CC0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600082B")]
		[Address(RVA = "0xFD211C", Offset = "0xFD211C", VA = "0xFD211C")]
		public EffectorOffset()
		{
		}
	}
	[Token(Token = "0x2000117")]
	public class ExplosionDemo : MonoBehaviour
	{
		[Token(Token = "0x400076F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SimpleLocomotion character;

		[Token(Token = "0x4000770")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float forceMlp;

		[Token(Token = "0x4000771")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float upForce;

		[Token(Token = "0x4000772")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float weightFalloffSpeed;

		[Token(Token = "0x4000773")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve weightFalloff;

		[Token(Token = "0x4000774")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve explosionForceByDistance;

		[Token(Token = "0x4000775")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AnimationCurve scale;

		[Token(Token = "0x4000776")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float weight;

		[Token(Token = "0x4000777")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 defaultScale;

		[Token(Token = "0x4000778")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Rigidbody r;

		[Token(Token = "0x4000779")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x600082C")]
		[Address(RVA = "0xFD212C", Offset = "0xFD212C", VA = "0xFD212C")]
		private void Start()
		{
		}

		[Token(Token = "0x600082D")]
		[Address(RVA = "0xFD21E4", Offset = "0xFD21E4", VA = "0xFD21E4")]
		private void Update()
		{
		}

		[Token(Token = "0x600082E")]
		[Address(RVA = "0xFD2640", Offset = "0xFD2640", VA = "0xFD2640")]
		private void SetEffectorWeights(float w)
		{
		}

		[Token(Token = "0x600082F")]
		[Address(RVA = "0xFD26E0", Offset = "0xFD26E0", VA = "0xFD26E0")]
		public ExplosionDemo()
		{
		}
	}
	[Token(Token = "0x2000118")]
	public class FBBIKSettings : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000119")]
		public class Limb
		{
			[Token(Token = "0x4000782")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FBIKChain.Smoothing reachSmoothing;

			[Token(Token = "0x4000783")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float maintainRelativePositionWeight;

			[Token(Token = "0x4000784")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float mappingWeight;

			[Token(Token = "0x6000834")]
			[Address(RVA = "0xFD2874", Offset = "0xFD2874", VA = "0xFD2874")]
			public void Apply(FullBodyBipedChain chain, IKSolverFullBodyBiped solver)
			{
			}

			[Token(Token = "0x6000835")]
			[Address(RVA = "0xFD2998", Offset = "0xFD2998", VA = "0xFD2998")]
			public Limb()
			{
			}
		}

		[Token(Token = "0x400077A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400077B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool disableAfterStart;

		[Token(Token = "0x400077C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Limb leftArm;

		[Token(Token = "0x400077D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Limb rightArm;

		[Token(Token = "0x400077E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Limb leftLeg;

		[Token(Token = "0x400077F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Limb rightLeg;

		[Token(Token = "0x4000780")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float rootPin;

		[Token(Token = "0x4000781")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool bodyEffectChildNodes;

		[Token(Token = "0x6000830")]
		[Address(RVA = "0xFD2750", Offset = "0xFD2750", VA = "0xFD2750")]
		public void UpdateSettings()
		{
		}

		[Token(Token = "0x6000831")]
		[Address(RVA = "0xFD28EC", Offset = "0xFD28EC", VA = "0xFD28EC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000832")]
		[Address(RVA = "0xFD2984", Offset = "0xFD2984", VA = "0xFD2984")]
		private void Update()
		{
		}

		[Token(Token = "0x6000833")]
		[Address(RVA = "0xFD2988", Offset = "0xFD2988", VA = "0xFD2988")]
		public FBBIKSettings()
		{
		}
	}
	[Token(Token = "0x200011A")]
	public class FBIKBendGoal : MonoBehaviour
	{
		[Token(Token = "0x4000785")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000786")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FullBodyBipedChain chain;

		[Token(Token = "0x4000787")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float weight;

		[Token(Token = "0x6000836")]
		[Address(RVA = "0xFD29A8", Offset = "0xFD29A8", VA = "0xFD29A8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000837")]
		[Address(RVA = "0xFD2A10", Offset = "0xFD2A10", VA = "0xFD2A10")]
		private void Update()
		{
		}

		[Token(Token = "0x6000838")]
		[Address(RVA = "0xFD2AE4", Offset = "0xFD2AE4", VA = "0xFD2AE4")]
		public FBIKBendGoal()
		{
		}
	}
	[Token(Token = "0x200011B")]
	public class FBIKBoxing : MonoBehaviour
	{
		[Token(Token = "0x4000788")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The target we want to hit")]
		public Transform target;

		[Token(Token = "0x4000789")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The pin Transform is used to reference the exact hit point in the animation (used by AimIK to aim the upper body to follow the target).In Legacy and Generic modes you can just create and position a reference point in your animating software and include it in the FBX. Then in Unity if you added a GameObject with the exact same name under the character's root, it would be animated to the required position.In Humanoid mode however, Mecanim loses track of any Transform that does not belong to the avatar, so in this case the pin point has to be manually set inside the Unity Editor.")]
		public Transform pin;

		[Token(Token = "0x400078A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The Full Body Biped IK component")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400078B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The Aim IK component. Aim IK is ust used for following the target slightly with the body.")]
		public AimIK aim;

		[Token(Token = "0x400078C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The master weight")]
		public float weight;

		[Token(Token = "0x400078D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("The effector type of the punching hand")]
		public FullBodyBipedEffector effector;

		[Token(Token = "0x400078E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Weight of aiming the body to follow the target")]
		public AnimationCurve aimWeight;

		[Token(Token = "0x400078F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Animator animator;

		[Token(Token = "0x6000839")]
		[Address(RVA = "0xFD2AEC", Offset = "0xFD2AEC", VA = "0xFD2AEC")]
		private void Start()
		{
		}

		[Token(Token = "0x600083A")]
		[Address(RVA = "0xFD2B44", Offset = "0xFD2B44", VA = "0xFD2B44")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600083B")]
		[Address(RVA = "0xFD2CDC", Offset = "0xFD2CDC", VA = "0xFD2CDC")]
		public FBIKBoxing()
		{
		}
	}
	[Token(Token = "0x200011C")]
	public class FBIKHandsOnProp : MonoBehaviour
	{
		[Token(Token = "0x4000790")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000791")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool leftHanded;

		[Token(Token = "0x600083C")]
		[Address(RVA = "0xFD2CE4", Offset = "0xFD2CE4", VA = "0xFD2CE4")]
		private void Awake()
		{
		}

		[Token(Token = "0x600083D")]
		[Address(RVA = "0xFD2DC4", Offset = "0xFD2DC4", VA = "0xFD2DC4")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x600083E")]
		[Address(RVA = "0xFD2E50", Offset = "0xFD2E50", VA = "0xFD2E50")]
		private void HandsOnProp(IKEffector mainHand, IKEffector otherHand)
		{
		}

		[Token(Token = "0x600083F")]
		[Address(RVA = "0xFD3324", Offset = "0xFD3324", VA = "0xFD3324")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000840")]
		[Address(RVA = "0xFD3450", Offset = "0xFD3450", VA = "0xFD3450")]
		public FBIKHandsOnProp()
		{
		}
	}
	[Token(Token = "0x200011D")]
	public class FPSAiming : MonoBehaviour
	{
		[Token(Token = "0x4000792")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float aimWeight;

		[Token(Token = "0x4000793")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Range(0f, 1f)]
		public float sightWeight;

		[Token(Token = "0x4000794")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 180f)]
		public float maxAngle;

		[Token(Token = "0x4000795")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 aimOffset;

		[Token(Token = "0x4000796")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool animatePhysics;

		[Token(Token = "0x4000797")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform gun;

		[Token(Token = "0x4000798")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform gunTarget;

		[Token(Token = "0x4000799")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400079A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AimIK gunAim;

		[Token(Token = "0x400079B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AimIK headAim;

		[Token(Token = "0x400079C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public CameraControllerFPS cam;

		[Token(Token = "0x400079D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Recoil recoil;

		[Token(Token = "0x400079E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Range(0f, 1f)]
		public float cameraRecoilWeight;

		[Token(Token = "0x400079F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Vector3 gunTargetDefaultLocalPosition;

		[Token(Token = "0x40007A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 gunTargetDefaultLocalRotation;

		[Token(Token = "0x40007A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Vector3 camDefaultLocalPosition;

		[Token(Token = "0x40007A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 camRelativeToGunTarget;

		[Token(Token = "0x40007A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool updateFrame;

		[Token(Token = "0x6000841")]
		[Address(RVA = "0xFD3458", Offset = "0xFD3458", VA = "0xFD3458")]
		private void Start()
		{
		}

		[Token(Token = "0x6000842")]
		[Address(RVA = "0xFD35F4", Offset = "0xFD35F4", VA = "0xFD35F4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000843")]
		[Address(RVA = "0xFD3600", Offset = "0xFD3600", VA = "0xFD3600")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000844")]
		[Address(RVA = "0xFD38C0", Offset = "0xFD38C0", VA = "0xFD38C0")]
		private void Aiming()
		{
		}

		[Token(Token = "0x6000845")]
		[Address(RVA = "0xFD3B5C", Offset = "0xFD3B5C", VA = "0xFD3B5C")]
		private void LookDownTheSight()
		{
		}

		[Token(Token = "0x6000846")]
		[Address(RVA = "0xFD36C4", Offset = "0xFD36C4", VA = "0xFD36C4")]
		private void RotateCharacter()
		{
		}

		[Token(Token = "0x6000847")]
		[Address(RVA = "0xFD4824", Offset = "0xFD4824", VA = "0xFD4824")]
		public FPSAiming()
		{
		}
	}
	[Token(Token = "0x200011E")]
	public class FPSCharacter : MonoBehaviour
	{
		[Token(Token = "0x40007A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float walkSpeed;

		[Token(Token = "0x40007A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float sVel;

		[Token(Token = "0x40007A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x40007A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private FPSAiming FPSAiming;

		[Token(Token = "0x6000848")]
		[Address(RVA = "0xFD4844", Offset = "0xFD4844", VA = "0xFD4844")]
		private void Start()
		{
		}

		[Token(Token = "0x6000849")]
		[Address(RVA = "0xFD48D4", Offset = "0xFD48D4", VA = "0xFD48D4")]
		private void Update()
		{
		}

		[Token(Token = "0x600084A")]
		[Address(RVA = "0xFD49D0", Offset = "0xFD49D0", VA = "0xFD49D0")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600084B")]
		[Address(RVA = "0xFD4A7C", Offset = "0xFD4A7C", VA = "0xFD4A7C")]
		public FPSCharacter()
		{
		}
	}
	[Token(Token = "0x200011F")]
	public class HitReactionTrigger : MonoBehaviour
	{
		[Token(Token = "0x40007A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public HitReaction hitReaction;

		[Token(Token = "0x40007A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float hitForce;

		[Token(Token = "0x40007AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string colliderName;

		[Token(Token = "0x600084C")]
		[Address(RVA = "0xFD4A8C", Offset = "0xFD4A8C", VA = "0xFD4A8C")]
		private void Update()
		{
		}

		[Token(Token = "0x600084D")]
		[Address(RVA = "0xFD4BDC", Offset = "0xFD4BDC", VA = "0xFD4BDC")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600084E")]
		[Address(RVA = "0xFD4D40", Offset = "0xFD4D40", VA = "0xFD4D40")]
		public HitReactionTrigger()
		{
		}
	}
	[Token(Token = "0x2000120")]
	public class HoldingHands : MonoBehaviour
	{
		[Token(Token = "0x40007AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK rightHandChar;

		[Token(Token = "0x40007AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FullBodyBipedIK leftHandChar;

		[Token(Token = "0x40007AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform rightHandTarget;

		[Token(Token = "0x40007AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftHandTarget;

		[Token(Token = "0x40007AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float crossFade;

		[Token(Token = "0x40007B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float speed;

		[Token(Token = "0x40007B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Quaternion rightHandRotation;

		[Token(Token = "0x40007B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion leftHandRotation;

		[Token(Token = "0x600084F")]
		[Address(RVA = "0xFD4D50", Offset = "0xFD4D50", VA = "0xFD4D50")]
		private void Start()
		{
		}

		[Token(Token = "0x6000850")]
		[Address(RVA = "0xFD4F1C", Offset = "0xFD4F1C", VA = "0xFD4F1C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000851")]
		[Address(RVA = "0xFD532C", Offset = "0xFD532C", VA = "0xFD532C")]
		public HoldingHands()
		{
		}
	}
	[Token(Token = "0x2000121")]
	public class InteractionC2CDemo : MonoBehaviour
	{
		[Token(Token = "0x40007B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem character1;

		[Token(Token = "0x40007B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractionSystem character2;

		[Token(Token = "0x40007B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject handShake;

		[Token(Token = "0x6000852")]
		[Address(RVA = "0xFD533C", Offset = "0xFD533C", VA = "0xFD533C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000853")]
		[Address(RVA = "0xFD5424", Offset = "0xFD5424", VA = "0xFD5424")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000854")]
		[Address(RVA = "0xFD5510", Offset = "0xFD5510", VA = "0xFD5510")]
		public InteractionC2CDemo()
		{
		}
	}
	[Token(Token = "0x2000122")]
	public class InteractionDemo : MonoBehaviour
	{
		[Token(Token = "0x40007B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x40007B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool interrupt;

		[Token(Token = "0x40007B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject ball;

		[Token(Token = "0x40007B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public InteractionObject benchMain;

		[Token(Token = "0x40007BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public InteractionObject benchHands;

		[Token(Token = "0x40007BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionObject button;

		[Token(Token = "0x40007BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public InteractionObject cigarette;

		[Token(Token = "0x40007BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public InteractionObject door;

		[Token(Token = "0x40007BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool isSitting;

		[Token(Token = "0x6000855")]
		[Address(RVA = "0xFD5518", Offset = "0xFD5518", VA = "0xFD5518")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000856")]
		[Address(RVA = "0xFD5A18", Offset = "0xFD5A18", VA = "0xFD5A18")]
		public InteractionDemo()
		{
		}
	}
	[Token(Token = "0x2000123")]
	public class InteractionSystemTestGUI : MonoBehaviour
	{
		[Token(Token = "0x40007BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The object to interact to")]
		public InteractionObject interactionObject;

		[Token(Token = "0x40007C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The effectors to interact with")]
		public FullBodyBipedEffector[] effectors;

		[Token(Token = "0x40007C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x6000857")]
		[Address(RVA = "0xFD5A20", Offset = "0xFD5A20", VA = "0xFD5A20")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000858")]
		[Address(RVA = "0xFD5A78", Offset = "0xFD5A78", VA = "0xFD5A78")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000859")]
		[Address(RVA = "0xFD5D24", Offset = "0xFD5D24", VA = "0xFD5D24")]
		public InteractionSystemTestGUI()
		{
		}
	}
	[Token(Token = "0x2000124")]
	public class KissingRig : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000125")]
		public class Partner
		{
			[Token(Token = "0x40007C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedIK ik;

			[Token(Token = "0x40007C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform mouth;

			[Token(Token = "0x40007C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform mouthTarget;

			[Token(Token = "0x40007C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform touchTargetLeftHand;

			[Token(Token = "0x40007CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Transform touchTargetRightHand;

			[Token(Token = "0x40007CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float bodyWeightHorizontal;

			[Token(Token = "0x40007CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float bodyWeightVertical;

			[Token(Token = "0x40007CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public float neckRotationWeight;

			[Token(Token = "0x40007CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public float headTiltAngle;

			[Token(Token = "0x40007CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 headTiltAxis;

			[Token(Token = "0x40007D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Quaternion neckRotation;

			[Token(Token = "0x170000E0")]
			private Transform neck
			{
				[Token(Token = "0x600085F")]
				[Address(RVA = "0xFD7540", Offset = "0xFD7540", VA = "0xFD7540")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600085D")]
			[Address(RVA = "0xFD6DD0", Offset = "0xFD6DD0", VA = "0xFD6DD0")]
			public void Initiate()
			{
			}

			[Token(Token = "0x600085E")]
			[Address(RVA = "0xFD6DF0", Offset = "0xFD6DF0", VA = "0xFD6DF0")]
			public void Update(float weight)
			{
			}

			[Token(Token = "0x6000860")]
			[Address(RVA = "0xFD73D8", Offset = "0xFD73D8", VA = "0xFD73D8")]
			private void InverseTransformEffector(FullBodyBipedEffector effector, Transform target, Vector3 targetPosition, float weight)
			{
			}

			[Token(Token = "0x6000861")]
			[Address(RVA = "0xFD758C", Offset = "0xFD758C", VA = "0xFD758C")]
			public Partner()
			{
			}
		}

		[Token(Token = "0x40007C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Partner partner1;

		[Token(Token = "0x40007C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Partner partner2;

		[Token(Token = "0x40007C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float weight;

		[Token(Token = "0x40007C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int iterations;

		[Token(Token = "0x600085A")]
		[Address(RVA = "0xFD5D2C", Offset = "0xFD5D2C", VA = "0xFD5D2C")]
		private void Start()
		{
		}

		[Token(Token = "0x600085B")]
		[Address(RVA = "0xFD5D5C", Offset = "0xFD5D5C", VA = "0xFD5D5C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600085C")]
		[Address(RVA = "0xFD5DC0", Offset = "0xFD5DC0", VA = "0xFD5DC0")]
		public KissingRig()
		{
		}
	}
	[Token(Token = "0x2000126")]
	public class MotionAbsorb : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000127")]
		public enum Mode
		{
			[Token(Token = "0x40007D9")]
			Position,
			[Token(Token = "0x40007DA")]
			PositionOffset
		}

		[Serializable]
		[Token(Token = "0x2000128")]
		public class Absorber
		{
			[Token(Token = "0x40007DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The type of effector (hand, foot, shoulder...) - this is just an enum")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x40007DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("How much should motion be absorbed on this effector")]
			public float weight;

			[Token(Token = "0x40007DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Vector3 position;

			[Token(Token = "0x40007DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private Quaternion rotation;

			[Token(Token = "0x40007DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private IKEffector e;

			[Token(Token = "0x6000868")]
			[Address(RVA = "0xFD7718", Offset = "0xFD7718", VA = "0xFD7718")]
			public void SetToBone(IKSolverFullBodyBiped solver, Mode mode)
			{
			}

			[Token(Token = "0x6000869")]
			[Address(RVA = "0xFD7900", Offset = "0xFD7900", VA = "0xFD7900")]
			public void UpdateEffectorWeights(float w)
			{
			}

			[Token(Token = "0x600086A")]
			[Address(RVA = "0xFD7924", Offset = "0xFD7924", VA = "0xFD7924")]
			public void SetPosition(float w)
			{
			}

			[Token(Token = "0x600086B")]
			[Address(RVA = "0xFD7A34", Offset = "0xFD7A34", VA = "0xFD7A34")]
			public void SetRotation(float w)
			{
			}

			[Token(Token = "0x600086C")]
			[Address(RVA = "0xFD7BEC", Offset = "0xFD7BEC", VA = "0xFD7BEC")]
			public Absorber()
			{
			}
		}

		[Token(Token = "0x40007D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("Use either effector position, position weight, rotation, rotationWeight or positionOffset and rotating the bone directly.")]
		public Mode mode;

		[Token(Token = "0x40007D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Array containing the absorbers")]
		public Absorber[] absorbers;

		[Token(Token = "0x40007D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Weight falloff curve (how fast will the effect reduce after impact)")]
		public AnimationCurve falloff;

		[Token(Token = "0x40007D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("How fast will the impact fade away. (if 1, effect lasts for 1 second)")]
		public float falloffSpeed;

		[Token(Token = "0x40007D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float timer;

		[Token(Token = "0x40007D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float w;

		[Token(Token = "0x40007D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Mode initialMode;

		[Token(Token = "0x6000862")]
		[Address(RVA = "0xFD75A0", Offset = "0xFD75A0", VA = "0xFD75A0", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000863")]
		[Address(RVA = "0xFD7698", Offset = "0xFD7698", VA = "0xFD7698")]
		private void OnCollisionEnter(Collision c)
		{
		}

		[Token(Token = "0x6000864")]
		[Address(RVA = "0xFD77F4", Offset = "0xFD77F4", VA = "0xFD77F4", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000865")]
		[Address(RVA = "0xFD79B8", Offset = "0xFD79B8", VA = "0xFD79B8")]
		private void AfterIK()
		{
		}

		[Token(Token = "0x6000866")]
		[Address(RVA = "0xFD7AA4", Offset = "0xFD7AA4", VA = "0xFD7AA4", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000867")]
		[Address(RVA = "0xFD7BDC", Offset = "0xFD7BDC", VA = "0xFD7BDC")]
		public MotionAbsorb()
		{
		}
	}
	[Token(Token = "0x2000129")]
	public class MotionAbsorbCharacter : MonoBehaviour
	{
		[Token(Token = "0x40007E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Animator animator;

		[Token(Token = "0x40007E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MotionAbsorb motionAbsorb;

		[Token(Token = "0x40007E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform cube;

		[Token(Token = "0x40007E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float cubeRandomPosition;

		[Token(Token = "0x40007E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve motionAbsorbWeight;

		[Token(Token = "0x40007E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 cubeDefaultPosition;

		[Token(Token = "0x40007E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private AnimatorStateInfo info;

		[Token(Token = "0x40007E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Rigidbody cubeRigidbody;

		[Token(Token = "0x600086D")]
		[Address(RVA = "0xFD7C4C", Offset = "0xFD7C4C", VA = "0xFD7C4C")]
		private void Start()
		{
		}

		[Token(Token = "0x600086E")]
		[Address(RVA = "0xFD7CC4", Offset = "0xFD7CC4", VA = "0xFD7CC4")]
		private void Update()
		{
		}

		[Token(Token = "0x600086F")]
		[Address(RVA = "0xFD7D94", Offset = "0xFD7D94", VA = "0xFD7D94")]
		private void SwingStart()
		{
		}

		[Token(Token = "0x6000870")]
		[Address(RVA = "0xFD7EDC", Offset = "0xFD7EDC", VA = "0xFD7EDC")]
		public MotionAbsorbCharacter()
		{
		}
	}
	[Token(Token = "0x200012A")]
	public class OffsetEffector : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x200012B")]
		public class EffectorLink
		{
			[Token(Token = "0x40007EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x40007ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float weightMultiplier;

			[Token(Token = "0x40007EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public Vector3 localPosition;

			[Token(Token = "0x6000875")]
			[Address(RVA = "0xFD8464", Offset = "0xFD8464", VA = "0xFD8464")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x40007E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Optional. Assign the bone Transform that is closest to this OffsetEffector to be able to call OffsetEffector.Anchor() in LateUpdate to match its position and rotation to animation.")]
		public Transform anchor;

		[Token(Token = "0x40007E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x40007EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 posRelToAnchor;

		[Token(Token = "0x40007EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion rotRelToAnchor;

		[Token(Token = "0x6000871")]
		[Address(RVA = "0xFD7EF0", Offset = "0xFD7EF0", VA = "0xFD7EF0", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000872")]
		[Address(RVA = "0xFD8138", Offset = "0xFD8138", VA = "0xFD8138", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000873")]
		[Address(RVA = "0xFD82B0", Offset = "0xFD82B0", VA = "0xFD82B0")]
		public void Anchor()
		{
		}

		[Token(Token = "0x6000874")]
		[Address(RVA = "0xFD840C", Offset = "0xFD840C", VA = "0xFD840C")]
		public OffsetEffector()
		{
		}
	}
	[Token(Token = "0x200012C")]
	public class PendulumExample : MonoBehaviour
	{
		[Token(Token = "0x40007EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		[Tooltip("The master weight of this script.")]
		public float weight;

		[Token(Token = "0x40007F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("Multiplier for the distance of the root to the target.")]
		public float hangingDistanceMlp;

		[Token(Token = "0x40007F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Where does the root of the character land when weight is blended out?")]
		[HideInInspector]
		public Vector3 rootTargetPosition;

		[Token(Token = "0x40007F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("How is the root of the character rotated when weight is blended out?")]
		[HideInInspector]
		public Quaternion rootTargetRotation;

		[Token(Token = "0x40007F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform target;

		[Token(Token = "0x40007F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform leftHandTarget;

		[Token(Token = "0x40007F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform rightHandTarget;

		[Token(Token = "0x40007F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform leftFootTarget;

		[Token(Token = "0x40007F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform rightFootTarget;

		[Token(Token = "0x40007F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform pelvisTarget;

		[Token(Token = "0x40007F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform bodyTarget;

		[Token(Token = "0x40007FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform headTarget;

		[Token(Token = "0x40007FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Vector3 pelvisDownAxis;

		[Token(Token = "0x40007FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40007FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Quaternion rootRelativeToPelvis;

		[Token(Token = "0x40007FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 pelvisToRoot;

		[Token(Token = "0x40007FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float lastWeight;

		[Token(Token = "0x6000876")]
		[Address(RVA = "0xFD8474", Offset = "0xFD8474", VA = "0xFD8474")]
		private void Start()
		{
		}

		[Token(Token = "0x6000877")]
		[Address(RVA = "0xFD8788", Offset = "0xFD8788", VA = "0xFD8788")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000878")]
		[Address(RVA = "0xFD8F84", Offset = "0xFD8F84", VA = "0xFD8F84")]
		public PendulumExample()
		{
		}
	}
	[Token(Token = "0x200012D")]
	public abstract class PickUp2Handed : MonoBehaviour
	{
		[Token(Token = "0x4000800")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int GUIspace;

		[Token(Token = "0x4000801")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x4000802")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject obj;

		[Token(Token = "0x4000803")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform pivot;

		[Token(Token = "0x4000804")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform holdPoint;

		[Token(Token = "0x4000805")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float pickUpTime;

		[Token(Token = "0x4000806")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float holdWeight;

		[Token(Token = "0x4000807")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float holdWeightVel;

		[Token(Token = "0x4000808")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x4000809")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x170000E1")]
		private bool holding
		{
			[Token(Token = "0x6000880")]
			[Address(RVA = "0xFD937C", Offset = "0xFD937C", VA = "0xFD937C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000E2")]
		private bool holdingLeft
		{
			[Token(Token = "0x6000881")]
			[Address(RVA = "0xFD944C", Offset = "0xFD944C", VA = "0xFD944C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000E3")]
		private bool holdingRight
		{
			[Token(Token = "0x6000882")]
			[Address(RVA = "0xFD93A4", Offset = "0xFD93A4", VA = "0xFD93A4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000879")]
		[Address(RVA = "0xFD8FF0", Offset = "0xFD8FF0", VA = "0xFD8FF0")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600087A")]
		protected abstract void RotatePivot();

		[Token(Token = "0x600087B")]
		[Address(RVA = "0xFD94F4", Offset = "0xFD94F4", VA = "0xFD94F4")]
		private void Start()
		{
		}

		[Token(Token = "0x600087C")]
		[Address(RVA = "0xFD96E4", Offset = "0xFD96E4", VA = "0xFD96E4")]
		private void OnPause(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600087D")]
		[Address(RVA = "0xFD9854", Offset = "0xFD9854", VA = "0xFD9854")]
		private void OnStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600087E")]
		[Address(RVA = "0xFD9924", Offset = "0xFD9924", VA = "0xFD9924")]
		private void OnDrop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600087F")]
		[Address(RVA = "0xFD9A50", Offset = "0xFD9A50", VA = "0xFD9A50")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000883")]
		[Address(RVA = "0xFD9BD0", Offset = "0xFD9BD0", VA = "0xFD9BD0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000884")]
		[Address(RVA = "0xFD9E0C", Offset = "0xFD9E0C", VA = "0xFD9E0C")]
		protected PickUp2Handed()
		{
		}
	}
	[Token(Token = "0x200012E")]
	public class PickUpBox : PickUp2Handed
	{
		[Token(Token = "0x6000885")]
		[Address(RVA = "0xFD9E20", Offset = "0xFD9E20", VA = "0xFD9E20", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x6000886")]
		[Address(RVA = "0xFDA000", Offset = "0xFDA000", VA = "0xFDA000")]
		public PickUpBox()
		{
		}
	}
	[Token(Token = "0x200012F")]
	public class PickUpSphere : PickUp2Handed
	{
		[Token(Token = "0x6000887")]
		[Address(RVA = "0xFDA014", Offset = "0xFDA014", VA = "0xFDA014", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x6000888")]
		[Address(RVA = "0xFDA128", Offset = "0xFDA128", VA = "0xFDA128")]
		public PickUpSphere()
		{
		}
	}
	[Token(Token = "0x2000130")]
	public class RagdollUtilityDemo : MonoBehaviour
	{
		[Token(Token = "0x400080A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RagdollUtility ragdollUtility;

		[Token(Token = "0x400080B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform root;

		[Token(Token = "0x400080C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Rigidbody pelvis;

		[Token(Token = "0x6000889")]
		[Address(RVA = "0xFDA13C", Offset = "0xFDA13C", VA = "0xFDA13C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600088A")]
		[Address(RVA = "0xFDA1D4", Offset = "0xFDA1D4", VA = "0xFDA1D4")]
		private void Update()
		{
		}

		[Token(Token = "0x600088B")]
		[Address(RVA = "0xFDA2EC", Offset = "0xFDA2EC", VA = "0xFDA2EC")]
		public RagdollUtilityDemo()
		{
		}
	}
	[Token(Token = "0x2000131")]
	public class RecoilTest : MonoBehaviour
	{
		[Token(Token = "0x400080D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float magnitude;

		[Token(Token = "0x400080E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Recoil recoil;

		[Token(Token = "0x600088C")]
		[Address(RVA = "0xFDA2F4", Offset = "0xFDA2F4", VA = "0xFDA2F4")]
		private void Start()
		{
		}

		[Token(Token = "0x600088D")]
		[Address(RVA = "0xFDA34C", Offset = "0xFDA34C", VA = "0xFDA34C")]
		private void Update()
		{
		}

		[Token(Token = "0x600088E")]
		[Address(RVA = "0xFDA398", Offset = "0xFDA398", VA = "0xFDA398")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600088F")]
		[Address(RVA = "0xFDA430", Offset = "0xFDA430", VA = "0xFDA430")]
		public RecoilTest()
		{
		}
	}
	[Token(Token = "0x2000132")]
	public class ResetInteractionObject : MonoBehaviour
	{
		[Token(Token = "0x2000133")]
		[CompilerGenerated]
		private sealed class <ResetObject>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000814")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000815")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000816")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float resetTime;

			[Token(Token = "0x4000817")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ResetInteractionObject <>4__this;

			[Token(Token = "0x170000E4")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000897")]
				[Address(RVA = "0xFDA7C0", Offset = "0xFDA7C0", VA = "0xFDA7C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E5")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000899")]
				[Address(RVA = "0xFDA808", Offset = "0xFDA808", VA = "0xFDA808", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000894")]
			[Address(RVA = "0xFDA5DC", Offset = "0xFDA5DC", VA = "0xFDA5DC")]
			[DebuggerHidden]
			public <ResetObject>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000895")]
			[Address(RVA = "0xFDA614", Offset = "0xFDA614", VA = "0xFDA614", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000896")]
			[Address(RVA = "0xFDA618", Offset = "0xFDA618", VA = "0xFDA618", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000898")]
			[Address(RVA = "0xFDA7C8", Offset = "0xFDA7C8", VA = "0xFDA7C8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400080F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float resetDelay;

		[Token(Token = "0x4000810")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Vector3 defaultPosition;

		[Token(Token = "0x4000811")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Quaternion defaultRotation;

		[Token(Token = "0x4000812")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform defaultParent;

		[Token(Token = "0x4000813")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Rigidbody r;

		[Token(Token = "0x6000890")]
		[Address(RVA = "0xFDA440", Offset = "0xFDA440", VA = "0xFDA440")]
		private void Start()
		{
		}

		[Token(Token = "0x6000891")]
		[Address(RVA = "0xFDA504", Offset = "0xFDA504", VA = "0xFDA504")]
		private void OnPickUp(Transform t)
		{
		}

		[Token(Token = "0x6000892")]
		[Address(RVA = "0xFDA558", Offset = "0xFDA558", VA = "0xFDA558")]
		[IteratorStateMachine(typeof(<ResetObject>d__7))]
		private IEnumerator ResetObject(float resetTime)
		{
			return null;
		}

		[Token(Token = "0x6000893")]
		[Address(RVA = "0xFDA604", Offset = "0xFDA604", VA = "0xFDA604")]
		public ResetInteractionObject()
		{
		}
	}
	[Token(Token = "0x2000134")]
	public class SoccerDemo : MonoBehaviour
	{
		[Token(Token = "0x2000135")]
		[CompilerGenerated]
		private sealed class <ResetDelayed>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400081B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400081C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400081D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SoccerDemo <>4__this;

			[Token(Token = "0x170000E6")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60008A0")]
				[Address(RVA = "0xFDAAAC", Offset = "0xFDAAAC", VA = "0xFDAAAC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E7")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60008A2")]
				[Address(RVA = "0xFDAAF4", Offset = "0xFDAAF4", VA = "0xFDAAF4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600089D")]
			[Address(RVA = "0xFDA938", Offset = "0xFDA938", VA = "0xFDA938")]
			[DebuggerHidden]
			public <ResetDelayed>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x600089E")]
			[Address(RVA = "0xFDA968", Offset = "0xFDA968", VA = "0xFDA968", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600089F")]
			[Address(RVA = "0xFDA96C", Offset = "0xFDA96C", VA = "0xFDA96C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008A1")]
			[Address(RVA = "0xFDAAB4", Offset = "0xFDAAB4", VA = "0xFDAAB4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000818")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Animator animator;

		[Token(Token = "0x4000819")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 defaultPosition;

		[Token(Token = "0x400081A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x600089A")]
		[Address(RVA = "0xFDA810", Offset = "0xFDA810", VA = "0xFDA810")]
		private void Start()
		{
		}

		[Token(Token = "0x600089B")]
		[Address(RVA = "0xFDA8C4", Offset = "0xFDA8C4", VA = "0xFDA8C4")]
		[IteratorStateMachine(typeof(<ResetDelayed>d__4))]
		private IEnumerator ResetDelayed()
		{
			return null;
		}

		[Token(Token = "0x600089C")]
		[Address(RVA = "0xFDA960", Offset = "0xFDA960", VA = "0xFDA960")]
		public SoccerDemo()
		{
		}
	}
	[Token(Token = "0x2000136")]
	public class TouchWalls : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000137")]
		public class EffectorLink
		{
			[Token(Token = "0x4000820")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool enabled;

			[Token(Token = "0x4000821")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x4000822")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public InteractionObject interactionObject;

			[Token(Token = "0x4000823")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform spherecastFrom;

			[Token(Token = "0x4000824")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float spherecastRadius;

			[Token(Token = "0x4000825")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float minDistance;

			[Token(Token = "0x4000826")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float distanceMlp;

			[Token(Token = "0x4000827")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public LayerMask touchLayers;

			[Token(Token = "0x4000828")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float lerpSpeed;

			[Token(Token = "0x4000829")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float minSwitchTime;

			[Token(Token = "0x400082A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public float releaseDistance;

			[Token(Token = "0x400082B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public bool sliding;

			[Token(Token = "0x400082C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 raycastDirectionLocal;

			[Token(Token = "0x400082D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private float raycastDistance;

			[Token(Token = "0x400082E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private bool inTouch;

			[Token(Token = "0x400082F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			private RaycastHit hit;

			[Token(Token = "0x4000830")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private Vector3 targetPosition;

			[Token(Token = "0x4000831")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			private Quaternion targetRotation;

			[Token(Token = "0x4000832")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			private bool initiated;

			[Token(Token = "0x4000833")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private float nextSwitchTime;

			[Token(Token = "0x4000834")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			private float speedF;

			[Token(Token = "0x60008A7")]
			[Address(RVA = "0xFDAB60", Offset = "0xFDAB60", VA = "0xFDAB60")]
			public void Initiate(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x60008A8")]
			[Address(RVA = "0xFDB734", Offset = "0xFDB734", VA = "0xFDB734")]
			private bool FindWalls(Vector3 direction)
			{
				return default(bool);
			}

			[Token(Token = "0x60008A9")]
			[Address(RVA = "0xFDAF68", Offset = "0xFDAF68", VA = "0xFDAF68")]
			public void Update(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x60008AA")]
			[Address(RVA = "0xFDB81C", Offset = "0xFDB81C", VA = "0xFDB81C")]
			private void StopTouch(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x60008AB")]
			[Address(RVA = "0xFDB900", Offset = "0xFDB900", VA = "0xFDB900")]
			private void OnInteractionStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x60008AC")]
			[Address(RVA = "0xFDB98C", Offset = "0xFDB98C", VA = "0xFDB98C")]
			private void OnInteractionResume(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x60008AD")]
			[Address(RVA = "0xFDBA14", Offset = "0xFDBA14", VA = "0xFDBA14")]
			private void OnInteractionStop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x60008AE")]
			[Address(RVA = "0xFDB520", Offset = "0xFDB520", VA = "0xFDB520")]
			public void Destroy(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x60008AF")]
			[Address(RVA = "0xFDBA9C", Offset = "0xFDBA9C", VA = "0xFDBA9C")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x400081E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x400081F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x60008A3")]
		[Address(RVA = "0xFDAAFC", Offset = "0xFDAAFC", VA = "0xFDAAFC")]
		private void Start()
		{
		}

		[Token(Token = "0x60008A4")]
		[Address(RVA = "0xFDAF08", Offset = "0xFDAF08", VA = "0xFDAF08")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60008A5")]
		[Address(RVA = "0xFDB470", Offset = "0xFDB470", VA = "0xFDB470")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60008A6")]
		[Address(RVA = "0xFDB72C", Offset = "0xFDB72C", VA = "0xFDB72C")]
		public TouchWalls()
		{
		}
	}
	[Token(Token = "0x2000138")]
	public class TransferMotion : MonoBehaviour
	{
		[Token(Token = "0x4000835")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The Transform to transfer motion to.")]
		public Transform to;

		[Token(Token = "0x4000836")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The amount of motion to transfer.")]
		[Range(0f, 1f)]
		public float transferMotion;

		[Token(Token = "0x4000837")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 lastPosition;

		[Token(Token = "0x60008B0")]
		[Address(RVA = "0xFDBAD8", Offset = "0xFDBAD8", VA = "0xFDBAD8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60008B1")]
		[Address(RVA = "0xFDBB08", Offset = "0xFDBB08", VA = "0xFDBB08")]
		private void Update()
		{
		}

		[Token(Token = "0x60008B2")]
		[Address(RVA = "0xFDBBB8", Offset = "0xFDBBB8", VA = "0xFDBBB8")]
		public TransferMotion()
		{
		}
	}
	[Token(Token = "0x2000139")]
	public class TwoHandedProp : MonoBehaviour
	{
		[Token(Token = "0x4000838")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x4000839")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The left hand target parented to the right hand.")]
		public Transform leftHandTarget;

		[Token(Token = "0x400083A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Left hand poser (poses fingers to match the left hand target).")]
		public Poser leftHandPoser;

		[Token(Token = "0x400083B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Range(0f, 1f)]
		[Tooltip("The weight of pinning the left hand to the prop.")]
		public float leftHandWeight;

		[Token(Token = "0x400083C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x400083D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 targetPosRelativeToRight;

		[Token(Token = "0x400083E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion targetRotRelativeToRight;

		[Token(Token = "0x60008B3")]
		[Address(RVA = "0xFDBBCC", Offset = "0xFDBBCC", VA = "0xFDBBCC")]
		private void Start()
		{
		}

		[Token(Token = "0x60008B4")]
		[Address(RVA = "0xFDBD9C", Offset = "0xFDBD9C", VA = "0xFDBD9C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60008B5")]
		[Address(RVA = "0xFDC094", Offset = "0xFDC094", VA = "0xFDC094")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x60008B6")]
		[Address(RVA = "0xFDC234", Offset = "0xFDC234", VA = "0xFDC234")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60008B7")]
		[Address(RVA = "0xFDC360", Offset = "0xFDC360", VA = "0xFDC360")]
		public TwoHandedProp()
		{
		}
	}
	[Token(Token = "0x200013A")]
	public class UserControlInteractions : UserControlThirdPerson
	{
		[Token(Token = "0x400083F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public CharacterThirdPerson character;

		[Token(Token = "0x4000840")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x4000841")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool disableInputInInteraction;

		[Token(Token = "0x4000842")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float enableInputAtProgress;

		[Token(Token = "0x60008B8")]
		[Address(RVA = "0xFDC374", Offset = "0xFDC374", VA = "0xFDC374", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60008B9")]
		[Address(RVA = "0xFDC7CC", Offset = "0xFDC7CC", VA = "0xFDC7CC")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60008BA")]
		[Address(RVA = "0xFDC994", Offset = "0xFDC994", VA = "0xFDC994")]
		public UserControlInteractions()
		{
		}
	}
	[Token(Token = "0x200013B")]
	public class GrounderDemo : MonoBehaviour
	{
		[Token(Token = "0x4000843")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject[] characters;

		[Token(Token = "0x60008BB")]
		[Address(RVA = "0xFDC9C8", Offset = "0xFDC9C8", VA = "0xFDC9C8")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60008BC")]
		[Address(RVA = "0xFDCBD0", Offset = "0xFDCBD0", VA = "0xFDCBD0")]
		public void Activate(int index)
		{
		}

		[Token(Token = "0x60008BD")]
		[Address(RVA = "0xFDCC3C", Offset = "0xFDCC3C", VA = "0xFDCC3C")]
		public GrounderDemo()
		{
		}
	}
	[Token(Token = "0x200013C")]
	public class PlatformRotator : MonoBehaviour
	{
		[Token(Token = "0x200013D")]
		[CompilerGenerated]
		private sealed class <SwitchRotation>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000850")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000851")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000852")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PlatformRotator <>4__this;

			[Token(Token = "0x170000E8")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60008C7")]
				[Address(RVA = "0xFDD3AC", Offset = "0xFDD3AC", VA = "0xFDD3AC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E9")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60008C9")]
				[Address(RVA = "0xFDD3F4", Offset = "0xFDD3F4", VA = "0xFDD3F4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008C4")]
			[Address(RVA = "0xFDD034", Offset = "0xFDD034", VA = "0xFDD034")]
			[DebuggerHidden]
			public <SwitchRotation>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x60008C5")]
			[Address(RVA = "0xFDD224", Offset = "0xFDD224", VA = "0xFDD224", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008C6")]
			[Address(RVA = "0xFDD228", Offset = "0xFDD228", VA = "0xFDD228", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008C8")]
			[Address(RVA = "0xFDD3B4", Offset = "0xFDD3B4", VA = "0xFDD3B4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000844")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float maxAngle;

		[Token(Token = "0x4000845")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float switchRotationTime;

		[Token(Token = "0x4000846")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float random;

		[Token(Token = "0x4000847")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float rotationSpeed;

		[Token(Token = "0x4000848")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 movePosition;

		[Token(Token = "0x4000849")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float moveSpeed;

		[Token(Token = "0x400084A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int characterLayer;

		[Token(Token = "0x400084B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x400084C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion targetRotation;

		[Token(Token = "0x400084D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 targetPosition;

		[Token(Token = "0x400084E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 velocity;

		[Token(Token = "0x400084F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Rigidbody r;

		[Token(Token = "0x60008BE")]
		[Address(RVA = "0xFDCC44", Offset = "0xFDCC44", VA = "0xFDCC44")]
		private void Start()
		{
		}

		[Token(Token = "0x60008BF")]
		[Address(RVA = "0xFDCD80", Offset = "0xFDCD80", VA = "0xFDCD80")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60008C0")]
		[Address(RVA = "0xFDCD0C", Offset = "0xFDCD0C", VA = "0xFDCD0C")]
		[IteratorStateMachine(typeof(<SwitchRotation>d__14))]
		private IEnumerator SwitchRotation()
		{
			return null;
		}

		[Token(Token = "0x60008C1")]
		[Address(RVA = "0xFDD05C", Offset = "0xFDD05C", VA = "0xFDD05C")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x60008C2")]
		[Address(RVA = "0xFDD134", Offset = "0xFDD134", VA = "0xFDD134")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x60008C3")]
		[Address(RVA = "0xFDD208", Offset = "0xFDD208", VA = "0xFDD208")]
		public PlatformRotator()
		{
		}
	}
	[Token(Token = "0x200013E")]
	public class BendGoal : MonoBehaviour
	{
		[Token(Token = "0x4000853")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LimbIK limbIK;

		[Token(Token = "0x4000854")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x60008CA")]
		[Address(RVA = "0xFDD3FC", Offset = "0xFDD3FC", VA = "0xFDD3FC")]
		private void Start()
		{
		}

		[Token(Token = "0x60008CB")]
		[Address(RVA = "0xFDD464", Offset = "0xFDD464", VA = "0xFDD464")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60008CC")]
		[Address(RVA = "0xFDD510", Offset = "0xFDD510", VA = "0xFDD510")]
		public BendGoal()
		{
		}
	}
	[Token(Token = "0x200013F")]
	public class Turret : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000140")]
		public class Part
		{
			[Token(Token = "0x4000857")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x4000858")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private RotationLimit rotationLimit;

			[Token(Token = "0x60008CF")]
			[Address(RVA = "0xFDD584", Offset = "0xFDD584", VA = "0xFDD584")]
			public void AimAt(Transform target)
			{
			}

			[Token(Token = "0x60008D0")]
			[Address(RVA = "0xFDD6C0", Offset = "0xFDD6C0", VA = "0xFDD6C0")]
			public Part()
			{
			}
		}

		[Token(Token = "0x4000855")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000856")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Part[] parts;

		[Token(Token = "0x60008CD")]
		[Address(RVA = "0xFDD520", Offset = "0xFDD520", VA = "0xFDD520")]
		private void Update()
		{
		}

		[Token(Token = "0x60008CE")]
		[Address(RVA = "0xFDD6B8", Offset = "0xFDD6B8", VA = "0xFDD6B8")]
		public Turret()
		{
		}
	}
	[Token(Token = "0x2000141")]
	public class HitReactionVRIKTrigger : MonoBehaviour
	{
		[Token(Token = "0x4000859")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public HitReactionVRIK hitReaction;

		[Token(Token = "0x400085A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float hitForce;

		[Token(Token = "0x400085B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string colliderName;

		[Token(Token = "0x60008D1")]
		[Address(RVA = "0xFDD6C8", Offset = "0xFDD6C8", VA = "0xFDD6C8")]
		private void Update()
		{
		}

		[Token(Token = "0x60008D2")]
		[Address(RVA = "0xFDD818", Offset = "0xFDD818", VA = "0xFDD818")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60008D3")]
		[Address(RVA = "0xFDD97C", Offset = "0xFDD97C", VA = "0xFDD97C")]
		public HitReactionVRIKTrigger()
		{
		}
	}
	[Token(Token = "0x2000142")]
	public class VRController : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000143")]
		public enum InputMode
		{
			[Token(Token = "0x4000866")]
			Input,
			[Token(Token = "0x4000867")]
			WASDOnly
		}

		[Token(Token = "0x400085C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InputMode inputMode;

		[Token(Token = "0x400085D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public VRIK ik;

		[Token(Token = "0x400085E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform centerEyeAnchor;

		[Token(Token = "0x400085F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float walkSpeed;

		[Token(Token = "0x4000860")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float runSpeed;

		[Token(Token = "0x4000861")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float walkForwardSpeedMlp;

		[Token(Token = "0x4000862")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float runForwardSpeedMlp;

		[Token(Token = "0x4000863")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 smoothInput;

		[Token(Token = "0x4000864")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 smoothInputV;

		[Token(Token = "0x60008D4")]
		[Address(RVA = "0xFDD98C", Offset = "0xFDD98C", VA = "0xFDD98C")]
		private void Update()
		{
		}

		[Token(Token = "0x60008D5")]
		[Address(RVA = "0xFDDB80", Offset = "0xFDDB80", VA = "0xFDDB80")]
		private Vector3 GetInput()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60008D6")]
		[Address(RVA = "0xFDDEC8", Offset = "0xFDDEC8", VA = "0xFDDEC8")]
		public VRController()
		{
		}
	}
	[Token(Token = "0x2000144")]
	public class VRIKCalibrationBasic : MonoBehaviour
	{
		[Token(Token = "0x4000868")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The VRIK component.")]
		public VRIK ik;

		[Token(Token = "0x4000869")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("HMD.")]
		[Header("Head")]
		public Transform centerEyeAnchor;

		[Token(Token = "0x400086A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Position offset of the camera from the head bone (root space).")]
		public Vector3 headAnchorPositionOffset;

		[Token(Token = "0x400086B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Tooltip("Rotation offset of the camera from the head bone (root space).")]
		public Vector3 headAnchorRotationOffset;

		[Token(Token = "0x400086C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Header("Hands")]
		[Tooltip("Left Hand Controller")]
		public Transform leftHandAnchor;

		[Token(Token = "0x400086D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Right Hand Controller")]
		public Transform rightHandAnchor;

		[Token(Token = "0x400086E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("Position offset of the hand controller from the hand bone (controller space).")]
		public Vector3 handAnchorPositionOffset;

		[Token(Token = "0x400086F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Tooltip("Rotation offset of the hand controller from the hand bone (controller space).")]
		public Vector3 handAnchorRotationOffset;

		[Token(Token = "0x4000870")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Header("Scale")]
		[Tooltip("Multiplies the scale of the root.")]
		public float scaleMlp;

		[Token(Token = "0x4000871")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Header("Data stored by Calibration")]
		public VRIKCalibrator.CalibrationData data;

		[Token(Token = "0x60008D7")]
		[Address(RVA = "0xFDDEDC", Offset = "0xFDDEDC", VA = "0xFDDEDC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60008D8")]
		[Address(RVA = "0xFDE070", Offset = "0xFDE070", VA = "0xFDE070")]
		public VRIKCalibrationBasic()
		{
		}
	}
	[Token(Token = "0x2000145")]
	public class VRIKCalibrationController : MonoBehaviour
	{
		[Token(Token = "0x4000872")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Reference to the VRIK component on the avatar.")]
		public VRIK ik;

		[Token(Token = "0x4000873")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The settings for VRIK calibration.")]
		public VRIKCalibrator.Settings settings;

		[Token(Token = "0x4000874")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The HMD.")]
		public Transform headTracker;

		[Token(Token = "0x4000875")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("(Optional) A tracker placed anywhere on the body of the player, preferrably close to the pelvis, on the belt area.")]
		public Transform bodyTracker;

		[Token(Token = "0x4000876")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("(Optional) A tracker or hand controller device placed anywhere on or in the player's left hand.")]
		public Transform leftHandTracker;

		[Token(Token = "0x4000877")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("(Optional) A tracker or hand controller device placed anywhere on or in the player's right hand.")]
		public Transform rightHandTracker;

		[Token(Token = "0x4000878")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("(Optional) A tracker placed anywhere on the ankle or toes of the player's left leg.")]
		public Transform leftFootTracker;

		[Token(Token = "0x4000879")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("(Optional) A tracker placed anywhere on the ankle or toes of the player's right leg.")]
		public Transform rightFootTracker;

		[Token(Token = "0x400087A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Header("Data stored by Calibration")]
		public VRIKCalibrator.CalibrationData data;

		[Token(Token = "0x60008D9")]
		[Address(RVA = "0xFDE0EC", Offset = "0xFDE0EC", VA = "0xFDE0EC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60008DA")]
		[Address(RVA = "0xFDE250", Offset = "0xFDE250", VA = "0xFDE250")]
		public VRIKCalibrationController()
		{
		}
	}
	[Token(Token = "0x2000146")]
	public class VRIKPlatform : MonoBehaviour
	{
		[Token(Token = "0x400087B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VRIK ik;

		[Token(Token = "0x400087C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 lastPosition;

		[Token(Token = "0x400087D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion lastRotation;

		[Token(Token = "0x60008DB")]
		[Address(RVA = "0xFDE2C4", Offset = "0xFDE2C4", VA = "0xFDE2C4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60008DC")]
		[Address(RVA = "0xFDE314", Offset = "0xFDE314", VA = "0xFDE314")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60008DD")]
		[Address(RVA = "0xFDE4EC", Offset = "0xFDE4EC", VA = "0xFDE4EC")]
		public VRIKPlatform()
		{
		}
	}
	[Token(Token = "0x2000147")]
	public class VRIKPlatformController : MonoBehaviour
	{
		[Token(Token = "0x400087E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VRIK ik;

		[Token(Token = "0x400087F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform trackingSpace;

		[Token(Token = "0x4000880")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform platform;

		[Token(Token = "0x4000881")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool moveToPlatform;

		[Token(Token = "0x4000882")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform lastPlatform;

		[Token(Token = "0x4000883")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000884")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastRotation;

		[Token(Token = "0x60008DE")]
		[Address(RVA = "0xFDE544", Offset = "0xFDE544", VA = "0xFDE544")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60008DF")]
		[Address(RVA = "0xFDEA74", Offset = "0xFDEA74", VA = "0xFDEA74")]
		public VRIKPlatformController()
		{
		}
	}
	[Token(Token = "0x2000148")]
	public abstract class CharacterAnimationBase : MonoBehaviour
	{
		[Token(Token = "0x4000885")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool smoothFollow;

		[Token(Token = "0x4000886")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float smoothFollowSpeed;

		[Token(Token = "0x4000887")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected bool animatePhysics;

		[Token(Token = "0x4000888")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000889")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 localPosition;

		[Token(Token = "0x400088A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion localRotation;

		[Token(Token = "0x400088B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastRotation;

		[Token(Token = "0x170000EA")]
		public virtual bool animationGrounded
		{
			[Token(Token = "0x60008E1")]
			[Address(RVA = "0xFDEAF0", Offset = "0xFDEAF0", VA = "0xFDEAF0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60008E0")]
		[Address(RVA = "0xFDEAD0", Offset = "0xFDEAD0", VA = "0xFDEAD0", Slot = "4")]
		public virtual Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60008E2")]
		[Address(RVA = "0xFDEAF8", Offset = "0xFDEAF8", VA = "0xFDEAF8")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x60008E3")]
		[Address(RVA = "0xFDEB58", Offset = "0xFDEB58", VA = "0xFDEB58", Slot = "6")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60008E4")]
		[Address(RVA = "0xFDECDC", Offset = "0xFDECDC", VA = "0xFDECDC", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x60008E5")]
		[Address(RVA = "0xFDEF58", Offset = "0xFDEF58", VA = "0xFDEF58", Slot = "8")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x60008E6")]
		[Address(RVA = "0xFDECEC", Offset = "0xFDECEC", VA = "0xFDECEC")]
		private void SmoothFollow()
		{
		}

		[Token(Token = "0x60008E7")]
		[Address(RVA = "0xFDEF68", Offset = "0xFDEF68", VA = "0xFDEF68")]
		protected CharacterAnimationBase()
		{
		}
	}
	[Token(Token = "0x2000149")]
	public class CharacterAnimationSimple : CharacterAnimationBase
	{
		[Token(Token = "0x400088C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public CharacterThirdPerson characterController;

		[Token(Token = "0x400088D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float pivotOffset;

		[Token(Token = "0x400088E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public AnimationCurve moveSpeed;

		[Token(Token = "0x400088F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Animator animator;

		[Token(Token = "0x60008E8")]
		[Address(RVA = "0xFDEF80", Offset = "0xFDEF80", VA = "0xFDEF80", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60008E9")]
		[Address(RVA = "0xFDEFE0", Offset = "0xFDEFE0", VA = "0xFDEFE0", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60008EA")]
		[Address(RVA = "0xFDF070", Offset = "0xFDF070", VA = "0xFDF070")]
		private void Update()
		{
		}

		[Token(Token = "0x60008EB")]
		[Address(RVA = "0xFDF194", Offset = "0xFDF194", VA = "0xFDF194")]
		public CharacterAnimationSimple()
		{
		}
	}
	[Token(Token = "0x200014A")]
	public class CharacterAnimationThirdPerson : CharacterAnimationBase
	{
		[Token(Token = "0x4000890")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public CharacterThirdPerson characterController;

		[Token(Token = "0x4000891")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float turnSensitivity;

		[Token(Token = "0x4000892")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float turnSpeed;

		[Token(Token = "0x4000893")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float runCycleLegOffset;

		[Token(Token = "0x4000894")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[SerializeField]
		[Range(0.1f, 3f)]
		private float animSpeedMultiplier;

		[Token(Token = "0x4000895")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Animator animator;

		[Token(Token = "0x4000896")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 lastForward;

		[Token(Token = "0x4000897")]
		private const string groundedDirectional = "Grounded Directional";

		[Token(Token = "0x4000898")]
		private const string groundedStrafe = "Grounded Strafe";

		[Token(Token = "0x4000899")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float deltaAngle;

		[Token(Token = "0x400089A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float jumpLeg;

		[Token(Token = "0x400089B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool lastJump;

		[Token(Token = "0x170000EB")]
		public override bool animationGrounded
		{
			[Token(Token = "0x60008EE")]
			[Address(RVA = "0xFDF250", Offset = "0xFDF250", VA = "0xFDF250", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60008EC")]
		[Address(RVA = "0xFDF1AC", Offset = "0xFDF1AC", VA = "0xFDF1AC", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60008ED")]
		[Address(RVA = "0xFDF234", Offset = "0xFDF234", VA = "0xFDF234", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60008EF")]
		[Address(RVA = "0xFDF344", Offset = "0xFDF344", VA = "0xFDF344", Slot = "9")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60008F0")]
		[Address(RVA = "0xFDF734", Offset = "0xFDF734", VA = "0xFDF734")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60008F1")]
		[Address(RVA = "0xFDF978", Offset = "0xFDF978", VA = "0xFDF978")]
		public CharacterAnimationThirdPerson()
		{
		}
	}
	[Token(Token = "0x200014B")]
	public abstract class CharacterBase : MonoBehaviour
	{
		[Token(Token = "0x400089C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("If specified, will use the direction from the character to this Transform as the gravity vector instead of Physics.gravity. Physics.gravity.magnitude will be used as the magnitude of the gravity vector.")]
		[Header("Base Parameters")]
		public Transform gravityTarget;

		[Token(Token = "0x400089D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Multiplies gravity applied to the character even if 'Individual Gravity' is unchecked.")]
		public float gravityMultiplier;

		[Token(Token = "0x400089E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float airborneThreshold;

		[Token(Token = "0x400089F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float slopeStartAngle;

		[Token(Token = "0x40008A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float slopeEndAngle;

		[Token(Token = "0x40008A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float spherecastRadius;

		[Token(Token = "0x40008A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public LayerMask groundLayers;

		[Token(Token = "0x40008A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private PhysicMaterial zeroFrictionMaterial;

		[Token(Token = "0x40008A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private PhysicMaterial highFrictionMaterial;

		[Token(Token = "0x40008A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected Rigidbody r;

		[Token(Token = "0x40008A6")]
		protected const float half = 0.5f;

		[Token(Token = "0x40008A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected float originalHeight;

		[Token(Token = "0x40008A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		protected Vector3 originalCenter;

		[Token(Token = "0x40008A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected CapsuleCollider capsule;

		[Token(Token = "0x60008F2")]
		public abstract void Move(Vector3 deltaPosition, Quaternion deltaRotation);

		[Token(Token = "0x60008F3")]
		[Address(RVA = "0xFDF99C", Offset = "0xFDF99C", VA = "0xFDF99C")]
		protected Vector3 GetGravity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60008F4")]
		[Address(RVA = "0xFDFB88", Offset = "0xFDFB88", VA = "0xFDFB88", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60008F5")]
		[Address(RVA = "0xFDFDB4", Offset = "0xFDFDB4", VA = "0xFDFDB4", Slot = "6")]
		protected virtual RaycastHit GetSpherecastHit()
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x60008F6")]
		[Address(RVA = "0xFDFF54", Offset = "0xFDFF54", VA = "0xFDFF54")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x60008F7")]
		[Address(RVA = "0xFDFFB4", Offset = "0xFDFFB4", VA = "0xFDFFB4")]
		protected void RigidbodyRotateAround(Vector3 point, Vector3 axis, float angle)
		{
		}

		[Token(Token = "0x60008F8")]
		[Address(RVA = "0xFE0118", Offset = "0xFE0118", VA = "0xFE0118")]
		protected void ScaleCapsule(float mlp)
		{
		}

		[Token(Token = "0x60008F9")]
		[Address(RVA = "0xFE031C", Offset = "0xFE031C", VA = "0xFE031C")]
		protected void HighFriction()
		{
		}

		[Token(Token = "0x60008FA")]
		[Address(RVA = "0xFE0340", Offset = "0xFE0340", VA = "0xFE0340")]
		protected void ZeroFriction()
		{
		}

		[Token(Token = "0x60008FB")]
		[Address(RVA = "0xFE0364", Offset = "0xFE0364", VA = "0xFE0364")]
		protected float GetSlopeDamper(Vector3 velocity, Vector3 groundNormal)
		{
			return default(float);
		}

		[Token(Token = "0x60008FC")]
		[Address(RVA = "0xFE04B0", Offset = "0xFE04B0", VA = "0xFE04B0")]
		protected CharacterBase()
		{
		}
	}
	[Token(Token = "0x200014C")]
	public class CharacterThirdPerson : CharacterBase
	{
		[Serializable]
		[Token(Token = "0x200014D")]
		public enum MoveMode
		{
			[Token(Token = "0x40008E5")]
			Directional,
			[Token(Token = "0x40008E6")]
			Strafe
		}

		[Token(Token = "0x200014E")]
		public struct AnimState
		{
			[Token(Token = "0x40008E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 moveDirection;

			[Token(Token = "0x40008E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public bool jump;

			[Token(Token = "0x40008E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
			public bool crouch;

			[Token(Token = "0x40008EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
			public bool onGround;

			[Token(Token = "0x40008EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF")]
			public bool isStrafing;

			[Token(Token = "0x40008EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float yVelocity;

			[Token(Token = "0x40008ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public bool doubleJump;
		}

		[Token(Token = "0x200014F")]
		[CompilerGenerated]
		private sealed class <JumpSmooth>d__79 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40008EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40008EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40008F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CharacterThirdPerson <>4__this;

			[Token(Token = "0x40008F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 jumpVelocity;

			[Token(Token = "0x40008F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private int <steps>5__2;

			[Token(Token = "0x40008F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int <stepsToTake>5__3;

			[Token(Token = "0x170000EE")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000914")]
				[Address(RVA = "0xFE2FCC", Offset = "0xFE2FCC", VA = "0xFE2FCC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000EF")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000916")]
				[Address(RVA = "0xFE3014", Offset = "0xFE3014", VA = "0xFE3014", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000911")]
			[Address(RVA = "0xFE2D8C", Offset = "0xFE2D8C", VA = "0xFE2D8C")]
			[DebuggerHidden]
			public <JumpSmooth>d__79(int <>1__state)
			{
			}

			[Token(Token = "0x6000912")]
			[Address(RVA = "0xFE2EC8", Offset = "0xFE2EC8", VA = "0xFE2EC8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000913")]
			[Address(RVA = "0xFE2ECC", Offset = "0xFE2ECC", VA = "0xFE2ECC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000915")]
			[Address(RVA = "0xFE2FD4", Offset = "0xFE2FD4", VA = "0xFE2FD4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40008AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Header("References")]
		public CharacterAnimationBase characterAnimation;

		[Token(Token = "0x40008AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public UserControlThirdPerson userControl;

		[Token(Token = "0x40008AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public CameraController cam;

		[Token(Token = "0x40008AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Header("Movement")]
		public MoveMode moveMode;

		[Token(Token = "0x40008AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public bool smoothPhysics;

		[Token(Token = "0x40008AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float smoothAccelerationTime;

		[Token(Token = "0x40008B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float linearAccelerationSpeed;

		[Token(Token = "0x40008B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float platformFriction;

		[Token(Token = "0x40008B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public float groundStickyEffect;

		[Token(Token = "0x40008B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float maxVerticalVelocityOnGround;

		[Token(Token = "0x40008B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public float velocityToGroundTangentWeight;

		[Token(Token = "0x40008B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[Header("Rotation")]
		public bool lookInCameraDirection;

		[Token(Token = "0x40008B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float turnSpeed;

		[Token(Token = "0x40008B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float stationaryTurnSpeedMlp;

		[Token(Token = "0x40008B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[Header("Jumping and Falling")]
		public bool smoothJump;

		[Token(Token = "0x40008B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public float airSpeed;

		[Token(Token = "0x40008BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public float airControl;

		[Token(Token = "0x40008BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public float jumpPower;

		[Token(Token = "0x40008BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public float jumpRepeatDelayTime;

		[Token(Token = "0x40008BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public bool doubleJumpEnabled;

		[Token(Token = "0x40008BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public float doubleJumpPowerMlp;

		[Token(Token = "0x40008BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[Header("Wall Running")]
		public LayerMask wallRunLayers;

		[Token(Token = "0x40008C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public float wallRunMaxLength;

		[Token(Token = "0x40008C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public float wallRunMinMoveMag;

		[Token(Token = "0x40008C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public float wallRunMinVelocityY;

		[Token(Token = "0x40008C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public float wallRunRotationSpeed;

		[Token(Token = "0x40008C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		public float wallRunMaxRotationAngle;

		[Token(Token = "0x40008C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public float wallRunWeightSpeed;

		[Token(Token = "0x40008C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[Header("Crouching")]
		public float crouchCapsuleScaleMlp;

		[Token(Token = "0x40008C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		public AnimState animState;

		[Token(Token = "0x40008CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		protected Vector3 moveDirection;

		[Token(Token = "0x40008CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Animator animator;

		[Token(Token = "0x40008CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Vector3 normal;

		[Token(Token = "0x40008CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private Vector3 platformVelocity;

		[Token(Token = "0x40008CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Vector3 platformAngularVelocity;

		[Token(Token = "0x40008CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private RaycastHit hit;

		[Token(Token = "0x40008D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private float jumpLeg;

		[Token(Token = "0x40008D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private float jumpEndTime;

		[Token(Token = "0x40008D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private float forwardMlp;

		[Token(Token = "0x40008D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		private float groundDistance;

		[Token(Token = "0x40008D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private float lastAirTime;

		[Token(Token = "0x40008D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		private float stickyForce;

		[Token(Token = "0x40008D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private Vector3 wallNormal;

		[Token(Token = "0x40008D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
		private Vector3 moveDirectionVelocity;

		[Token(Token = "0x40008D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private float wallRunWeight;

		[Token(Token = "0x40008D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
		private float lastWallRunWeight;

		[Token(Token = "0x40008DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private float fixedDeltaTime;

		[Token(Token = "0x40008DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
		private Vector3 fixedDeltaPosition;

		[Token(Token = "0x40008DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private Quaternion fixedDeltaRotation;

		[Token(Token = "0x40008DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private bool fixedFrame;

		[Token(Token = "0x40008DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
		private float wallRunEndTime;

		[Token(Token = "0x40008DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private Vector3 gravity;

		[Token(Token = "0x40008E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
		private Vector3 verticalVelocity;

		[Token(Token = "0x40008E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private float velocityY;

		[Token(Token = "0x40008E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
		private bool doubleJumped;

		[Token(Token = "0x40008E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E5")]
		private bool jumpReleased;

		[Token(Token = "0x170000EC")]
		public bool fullRootMotion
		{
			[Token(Token = "0x60008FD")]
			[Address(RVA = "0xFE04D0", Offset = "0xFE04D0", VA = "0xFE04D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008FE")]
			[Address(RVA = "0xFE04D8", Offset = "0xFE04D8", VA = "0xFE04D8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000ED")]
		public bool onGround
		{
			[Token(Token = "0x60008FF")]
			[Address(RVA = "0xFE04E4", Offset = "0xFE04E4", VA = "0xFE04E4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000900")]
			[Address(RVA = "0xFE04EC", Offset = "0xFE04EC", VA = "0xFE04EC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000901")]
		[Address(RVA = "0xFE04F8", Offset = "0xFE04F8", VA = "0xFE04F8", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000902")]
		[Address(RVA = "0xFE06E4", Offset = "0xFE06E4", VA = "0xFE06E4")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x6000903")]
		[Address(RVA = "0xFE0768", Offset = "0xFE0768", VA = "0xFE0768", Slot = "4")]
		public override void Move(Vector3 deltaPosition, Quaternion deltaRotation)
		{
		}

		[Token(Token = "0x6000904")]
		[Address(RVA = "0xFE087C", Offset = "0xFE087C", VA = "0xFE087C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000905")]
		[Address(RVA = "0xFE1910", Offset = "0xFE1910", VA = "0xFE1910", Slot = "7")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000906")]
		[Address(RVA = "0xFE1DA0", Offset = "0xFE1DA0", VA = "0xFE1DA0", Slot = "8")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x6000907")]
		[Address(RVA = "0xFE0F70", Offset = "0xFE0F70", VA = "0xFE0F70")]
		private void MoveFixed(Vector3 deltaPosition)
		{
		}

		[Token(Token = "0x6000908")]
		[Address(RVA = "0xFE1E78", Offset = "0xFE1E78", VA = "0xFE1E78")]
		private void WallRun()
		{
		}

		[Token(Token = "0x6000909")]
		[Address(RVA = "0xFE2500", Offset = "0xFE2500", VA = "0xFE2500")]
		private bool CanWallRun()
		{
			return default(bool);
		}

		[Token(Token = "0x600090A")]
		[Address(RVA = "0xFE199C", Offset = "0xFE199C", VA = "0xFE199C")]
		private Vector3 GetMoveDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600090B")]
		[Address(RVA = "0xFE25F8", Offset = "0xFE25F8", VA = "0xFE25F8", Slot = "9")]
		protected virtual void Rotate()
		{
		}

		[Token(Token = "0x600090C")]
		[Address(RVA = "0xFE2A78", Offset = "0xFE2A78", VA = "0xFE2A78")]
		private Vector3 GetForwardDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600090D")]
		[Address(RVA = "0xFE2BA0", Offset = "0xFE2BA0", VA = "0xFE2BA0", Slot = "10")]
		protected virtual bool Jump()
		{
			return default(bool);
		}

		[Token(Token = "0x600090E")]
		[Address(RVA = "0xFE2CF4", Offset = "0xFE2CF4", VA = "0xFE2CF4")]
		[IteratorStateMachine(typeof(<JumpSmooth>d__79))]
		private IEnumerator JumpSmooth(Vector3 jumpVelocity)
		{
			return null;
		}

		[Token(Token = "0x600090F")]
		[Address(RVA = "0xFE13A4", Offset = "0xFE13A4", VA = "0xFE13A4")]
		private void GroundCheck()
		{
		}

		[Token(Token = "0x6000910")]
		[Address(RVA = "0xFE2DB4", Offset = "0xFE2DB4", VA = "0xFE2DB4")]
		public CharacterThirdPerson()
		{
		}
	}
	[Token(Token = "0x2000150")]
	public class SimpleLocomotion : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000151")]
		public enum RotationMode
		{
			[Token(Token = "0x4000902")]
			Smooth,
			[Token(Token = "0x4000903")]
			Linear
		}

		[Token(Token = "0x40008F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The component that updates the camera.")]
		public CameraController cameraController;

		[Token(Token = "0x40008F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Acceleration of movement.")]
		public float accelerationTime;

		[Token(Token = "0x40008F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("Turning speed.")]
		public float turnTime;

		[Token(Token = "0x40008F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("If true, will run on left shift, if not will walk on left shift.")]
		public bool walkByDefault;

		[Token(Token = "0x40008F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("Smooth or linear rotation.")]
		public RotationMode rotationMode;

		[Token(Token = "0x40008F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Procedural motion speed (if not using root motion).")]
		public float moveSpeed;

		[Token(Token = "0x40008FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Animator animator;

		[Token(Token = "0x40008FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float speed;

		[Token(Token = "0x40008FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float angleVel;

		[Token(Token = "0x40008FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float speedVel;

		[Token(Token = "0x40008FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 linearTargetDirection;

		[Token(Token = "0x4000900")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private CharacterController characterController;

		[Token(Token = "0x170000F0")]
		public bool isGrounded
		{
			[Token(Token = "0x6000917")]
			[Address(RVA = "0xFE301C", Offset = "0xFE301C", VA = "0xFE301C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000918")]
			[Address(RVA = "0xFE3024", Offset = "0xFE3024", VA = "0xFE3024")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000919")]
		[Address(RVA = "0xFE3030", Offset = "0xFE3030", VA = "0xFE3030")]
		private void Start()
		{
		}

		[Token(Token = "0x600091A")]
		[Address(RVA = "0xFE30D8", Offset = "0xFE30D8", VA = "0xFE30D8")]
		private void Update()
		{
		}

		[Token(Token = "0x600091B")]
		[Address(RVA = "0xFE36F0", Offset = "0xFE36F0", VA = "0xFE36F0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600091C")]
		[Address(RVA = "0xFE3120", Offset = "0xFE3120", VA = "0xFE3120")]
		private void Rotate()
		{
		}

		[Token(Token = "0x600091D")]
		[Address(RVA = "0xFE3488", Offset = "0xFE3488", VA = "0xFE3488")]
		private void Move()
		{
		}

		[Token(Token = "0x600091E")]
		[Address(RVA = "0xFE3720", Offset = "0xFE3720", VA = "0xFE3720")]
		private Vector3 GetInputVector()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600091F")]
		[Address(RVA = "0xFE37B8", Offset = "0xFE37B8", VA = "0xFE37B8")]
		private Vector3 GetInputVectorRaw()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000920")]
		[Address(RVA = "0xFE3838", Offset = "0xFE3838", VA = "0xFE3838")]
		public SimpleLocomotion()
		{
		}
	}
	[Token(Token = "0x2000152")]
	public class UserControlAI : UserControlThirdPerson
	{
		[Token(Token = "0x4000904")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform moveTarget;

		[Token(Token = "0x4000905")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float stoppingDistance;

		[Token(Token = "0x4000906")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float stoppingThreshold;

		[Token(Token = "0x4000907")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Navigator navigator;

		[Token(Token = "0x6000921")]
		[Address(RVA = "0xFE3860", Offset = "0xFE3860", VA = "0xFE3860", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000922")]
		[Address(RVA = "0xFE39A8", Offset = "0xFE39A8", VA = "0xFE39A8", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000923")]
		[Address(RVA = "0xFE4020", Offset = "0xFE4020", VA = "0xFE4020")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000924")]
		[Address(RVA = "0xFE420C", Offset = "0xFE420C", VA = "0xFE420C")]
		public UserControlAI()
		{
		}
	}
	[Token(Token = "0x2000153")]
	public class UserControlThirdPerson : MonoBehaviour
	{
		[Token(Token = "0x2000154")]
		public struct State
		{
			[Token(Token = "0x400090D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 move;

			[Token(Token = "0x400090E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 lookPos;

			[Token(Token = "0x400090F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool crouch;

			[Token(Token = "0x4000910")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			public bool jump;

			[Token(Token = "0x4000911")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int actionIndex;
		}

		[Token(Token = "0x4000908")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool walkByDefault;

		[Token(Token = "0x4000909")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool canCrouch;

		[Token(Token = "0x400090A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool canJump;

		[Token(Token = "0x400090B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public State state;

		[Token(Token = "0x400090C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected Transform cam;

		[Token(Token = "0x6000925")]
		[Address(RVA = "0xFE389C", Offset = "0xFE389C", VA = "0xFE389C", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000926")]
		[Address(RVA = "0xFDC488", Offset = "0xFDC488", VA = "0xFDC488", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000927")]
		[Address(RVA = "0xFDC9B8", Offset = "0xFDC9B8", VA = "0xFDC9B8")]
		public UserControlThirdPerson()
		{
		}
	}
	[Token(Token = "0x2000155")]
	public class ApplicationQuit : MonoBehaviour
	{
		[Token(Token = "0x6000928")]
		[Address(RVA = "0xFE4228", Offset = "0xFE4228", VA = "0xFE4228")]
		private void Update()
		{
		}

		[Token(Token = "0x6000929")]
		[Address(RVA = "0xFE4260", Offset = "0xFE4260", VA = "0xFE4260")]
		public ApplicationQuit()
		{
		}
	}
	[Token(Token = "0x2000156")]
	public class SlowMo : MonoBehaviour
	{
		[Token(Token = "0x4000912")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public KeyCode[] keyCodes;

		[Token(Token = "0x4000913")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool mouse0;

		[Token(Token = "0x4000914")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool mouse1;

		[Token(Token = "0x4000915")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float slowMoTimeScale;

		[Token(Token = "0x600092A")]
		[Address(RVA = "0xFE4268", Offset = "0xFE4268", VA = "0xFE4268")]
		private void Update()
		{
		}

		[Token(Token = "0x600092B")]
		[Address(RVA = "0xFE4290", Offset = "0xFE4290", VA = "0xFE4290")]
		private bool IsSlowMotion()
		{
			return default(bool);
		}

		[Token(Token = "0x600092C")]
		[Address(RVA = "0xFE4334", Offset = "0xFE4334", VA = "0xFE4334")]
		public SlowMo()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000157")]
	public class Navigator
	{
		[Token(Token = "0x2000158")]
		public enum State
		{
			[Token(Token = "0x4000925")]
			Idle,
			[Token(Token = "0x4000926")]
			Seeking,
			[Token(Token = "0x4000927")]
			OnPath
		}

		[Token(Token = "0x4000916")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Tooltip("Should this Navigator be actively seeking a path.")]
		public bool activeTargetSeeking;

		[Token(Token = "0x4000917")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[Tooltip("Increase this value if the character starts running in a circle, not able to reach the corner because of a too large turning radius.")]
		public float cornerRadius;

		[Token(Token = "0x4000918")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Recalculate path if target position has moved by this distance from the position it was at when the path was originally calculated")]
		public float recalculateOnPathDistance;

		[Token(Token = "0x4000919")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("Sample within this distance from sourcePosition.")]
		public float maxSampleDistance;

		[Token(Token = "0x400091A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Interval of updating the path")]
		public float nextPathInterval;

		[Token(Token = "0x400091D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform transform;

		[Token(Token = "0x400091E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int cornerIndex;

		[Token(Token = "0x400091F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3[] corners;

		[Token(Token = "0x4000920")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private NavMeshPath path;

		[Token(Token = "0x4000921")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 lastTargetPosition;

		[Token(Token = "0x4000922")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool initiated;

		[Token(Token = "0x4000923")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float nextPathTime;

		[Token(Token = "0x170000F1")]
		public Vector3 normalizedDeltaPosition
		{
			[Token(Token = "0x600092D")]
			[Address(RVA = "0xFE4348", Offset = "0xFE4348", VA = "0xFE4348")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600092E")]
			[Address(RVA = "0xFE4354", Offset = "0xFE4354", VA = "0xFE4354")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000F2")]
		public State state
		{
			[Token(Token = "0x600092F")]
			[Address(RVA = "0xFE4360", Offset = "0xFE4360", VA = "0xFE4360")]
			[CompilerGenerated]
			get
			{
				return default(State);
			}
			[Token(Token = "0x6000930")]
			[Address(RVA = "0xFE4368", Offset = "0xFE4368", VA = "0xFE4368")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000931")]
		[Address(RVA = "0xFE38D0", Offset = "0xFE38D0", VA = "0xFE38D0")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x6000932")]
		[Address(RVA = "0xFE3BC8", Offset = "0xFE3BC8", VA = "0xFE3BC8")]
		public void Update(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000933")]
		[Address(RVA = "0xFE4448", Offset = "0xFE4448", VA = "0xFE4448")]
		private void CalculatePath(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000934")]
		[Address(RVA = "0xFE44AC", Offset = "0xFE44AC", VA = "0xFE44AC")]
		private bool Find(Vector3 targetPosition)
		{
			return default(bool);
		}

		[Token(Token = "0x6000935")]
		[Address(RVA = "0xFE4370", Offset = "0xFE4370", VA = "0xFE4370")]
		private void Stop()
		{
		}

		[Token(Token = "0x6000936")]
		[Address(RVA = "0xFE43CC", Offset = "0xFE43CC", VA = "0xFE43CC")]
		private float HorDistance(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x6000937")]
		[Address(RVA = "0xFE4048", Offset = "0xFE4048", VA = "0xFE4048")]
		public void Visualize()
		{
		}

		[Token(Token = "0x6000938")]
		[Address(RVA = "0xFE45E0", Offset = "0xFE45E0", VA = "0xFE45E0")]
		public Navigator()
		{
		}
	}
}
namespace DG.Tweening
{
	[Token(Token = "0x2000159")]
	public static class DOTweenModuleAudio
	{
		[Token(Token = "0x6000939")]
		[Address(RVA = "0xFE4650", Offset = "0xFE4650", VA = "0xFE4650")]
		public static TweenerCore<float, float, FloatOptions> DOFade(this AudioSource target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600093A")]
		[Address(RVA = "0xFE4804", Offset = "0xFE4804", VA = "0xFE4804")]
		public static TweenerCore<float, float, FloatOptions> DOPitch(this AudioSource target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600093B")]
		[Address(RVA = "0xFE4990", Offset = "0xFE4990", VA = "0xFE4990")]
		public static TweenerCore<float, float, FloatOptions> DOSetFloat(this AudioMixer target, string floatName, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600093C")]
		[Address(RVA = "0xFE4B30", Offset = "0xFE4B30", VA = "0xFE4B30")]
		public static int DOComplete(this AudioMixer target, bool withCallbacks = false)
		{
			return default(int);
		}

		[Token(Token = "0x600093D")]
		[Address(RVA = "0xFE4B98", Offset = "0xFE4B98", VA = "0xFE4B98")]
		public static TweenerCore<float, float, FloatOptions> DOVolume(this AudioSource target, float endVolume, float duration)
		{
			return null;
		}

		[Token(Token = "0x600093E")]
		[Address(RVA = "0xFE4CEC", Offset = "0xFE4CEC", VA = "0xFE4CEC")]
		public static int DOKill(this AudioMixer target, bool complete = false)
		{
			return default(int);
		}

		[Token(Token = "0x600093F")]
		[Address(RVA = "0xFE4D54", Offset = "0xFE4D54", VA = "0xFE4D54")]
		public static int DOFlip(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000940")]
		[Address(RVA = "0xFE4DAC", Offset = "0xFE4DAC", VA = "0xFE4DAC")]
		public static int DOGoto(this AudioMixer target, float to, bool andPlay = false)
		{
			return default(int);
		}

		[Token(Token = "0x6000941")]
		[Address(RVA = "0xFE4E24", Offset = "0xFE4E24", VA = "0xFE4E24")]
		public static int DOPause(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000942")]
		[Address(RVA = "0xFE4E7C", Offset = "0xFE4E7C", VA = "0xFE4E7C")]
		public static int DOPlay(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000943")]
		[Address(RVA = "0xFE4ED4", Offset = "0xFE4ED4", VA = "0xFE4ED4")]
		public static int DOPlayBackwards(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000944")]
		[Address(RVA = "0xFE4F2C", Offset = "0xFE4F2C", VA = "0xFE4F2C")]
		public static int DOPlayForward(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000945")]
		[Address(RVA = "0xFE4F84", Offset = "0xFE4F84", VA = "0xFE4F84")]
		public static int DORestart(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000946")]
		[Address(RVA = "0xFE4FE4", Offset = "0xFE4FE4", VA = "0xFE4FE4")]
		public static int DORewind(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000947")]
		[Address(RVA = "0xFE5040", Offset = "0xFE5040", VA = "0xFE5040")]
		public static int DOSmoothRewind(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000948")]
		[Address(RVA = "0xFE5098", Offset = "0xFE5098", VA = "0xFE5098")]
		public static int DOTogglePause(this AudioMixer target)
		{
			return default(int);
		}
	}
	[Token(Token = "0x200015E")]
	public static class DOTweenModuleSprite
	{
		[Token(Token = "0x6000955")]
		[Address(RVA = "0xFE51F0", Offset = "0xFE51F0", VA = "0xFE51F0")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this SpriteRenderer target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000956")]
		[Address(RVA = "0xFE53A4", Offset = "0xFE53A4", VA = "0xFE53A4")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this SpriteRenderer target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000957")]
		[Address(RVA = "0xFE5530", Offset = "0xFE5530", VA = "0xFE5530")]
		public static Sequence DOGradientColor(this SpriteRenderer target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000958")]
		[Address(RVA = "0xFE570C", Offset = "0xFE570C", VA = "0xFE570C")]
		public static Tweener DOBlendableColor(this SpriteRenderer target, Color endValue, float duration)
		{
			return null;
		}
	}
	[Token(Token = "0x2000162")]
	public static class DOTweenModuleUnityVersion
	{
		[StructLayout(3)]
		[Token(Token = "0x2000165")]
		[CompilerGenerated]
		private struct <AsyncWaitForCompletion>d__10 : IAsyncStateMachine
		{
			[Token(Token = "0x4000935")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000936")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000937")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x4000938")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x6000978")]
			[Address(RVA = "0xFE6E38", Offset = "0xFE6E38", VA = "0xFE6E38", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000979")]
			[Address(RVA = "0xFE7070", Offset = "0xFE7070", VA = "0xFE7070", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000166")]
		[CompilerGenerated]
		private struct <AsyncWaitForRewind>d__11 : IAsyncStateMachine
		{
			[Token(Token = "0x4000939")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x400093A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x400093B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x400093C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x600097A")]
			[Address(RVA = "0xFE707C", Offset = "0xFE707C", VA = "0xFE707C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x600097B")]
			[Address(RVA = "0xFE72D8", Offset = "0xFE72D8", VA = "0xFE72D8", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000167")]
		[CompilerGenerated]
		private struct <AsyncWaitForKill>d__12 : IAsyncStateMachine
		{
			[Token(Token = "0x400093D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x400093E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x400093F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x4000940")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x600097C")]
			[Address(RVA = "0xFE72E4", Offset = "0xFE72E4", VA = "0xFE72E4", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x600097D")]
			[Address(RVA = "0xFE7508", Offset = "0xFE7508", VA = "0xFE7508", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000168")]
		[CompilerGenerated]
		private struct <AsyncWaitForElapsedLoops>d__13 : IAsyncStateMachine
		{
			[Token(Token = "0x4000941")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000942")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000943")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x4000944")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int elapsedLoops;

			[Token(Token = "0x4000945")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x600097E")]
			[Address(RVA = "0xFE7514", Offset = "0xFE7514", VA = "0xFE7514", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x600097F")]
			[Address(RVA = "0xFE7754", Offset = "0xFE7754", VA = "0xFE7754", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000169")]
		[CompilerGenerated]
		private struct <AsyncWaitForPosition>d__14 : IAsyncStateMachine
		{
			[Token(Token = "0x4000946")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000947")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000948")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x4000949")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float position;

			[Token(Token = "0x400094A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x6000980")]
			[Address(RVA = "0xFE7760", Offset = "0xFE7760", VA = "0xFE7760", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000981")]
			[Address(RVA = "0xFE79B8", Offset = "0xFE79B8", VA = "0xFE79B8", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200016A")]
		[CompilerGenerated]
		private struct <AsyncWaitForStart>d__15 : IAsyncStateMachine
		{
			[Token(Token = "0x400094B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x400094C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x400094D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x400094E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x6000982")]
			[Address(RVA = "0xFE79C4", Offset = "0xFE79C4", VA = "0xFE79C4", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000983")]
			[Address(RVA = "0xFE7BF0", Offset = "0xFE7BF0", VA = "0xFE7BF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x6000962")]
		[Address(RVA = "0xFE5A04", Offset = "0xFE5A04", VA = "0xFE5A04")]
		public static Sequence DOGradientColor(this Material target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000963")]
		[Address(RVA = "0xFE5BE4", Offset = "0xFE5BE4", VA = "0xFE5BE4")]
		public static Sequence DOGradientColor(this Material target, Gradient gradient, string property, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000964")]
		[Address(RVA = "0xFE5DD0", Offset = "0xFE5DD0", VA = "0xFE5DD0")]
		public static CustomYieldInstruction WaitForCompletion(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000965")]
		[Address(RVA = "0xFE5ECC", Offset = "0xFE5ECC", VA = "0xFE5ECC")]
		public static CustomYieldInstruction WaitForRewind(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000966")]
		[Address(RVA = "0xFE5FC8", Offset = "0xFE5FC8", VA = "0xFE5FC8")]
		public static CustomYieldInstruction WaitForKill(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000967")]
		[Address(RVA = "0xFE60C4", Offset = "0xFE60C4", VA = "0xFE60C4")]
		public static CustomYieldInstruction WaitForElapsedLoops(this Tween t, int elapsedLoops, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000968")]
		[Address(RVA = "0xFE61D4", Offset = "0xFE61D4", VA = "0xFE61D4")]
		public static CustomYieldInstruction WaitForPosition(this Tween t, float position, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000969")]
		[Address(RVA = "0xFE62F4", Offset = "0xFE62F4", VA = "0xFE62F4")]
		public static CustomYieldInstruction WaitForStart(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x600096A")]
		[Address(RVA = "0xFE63F0", Offset = "0xFE63F0", VA = "0xFE63F0")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOOffset(this Material target, Vector2 endValue, int propertyID, float duration)
		{
			return null;
		}

		[Token(Token = "0x600096B")]
		[Address(RVA = "0xFE65FC", Offset = "0xFE65FC", VA = "0xFE65FC")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOTiling(this Material target, Vector2 endValue, int propertyID, float duration)
		{
			return null;
		}

		[Token(Token = "0x600096C")]
		[Address(RVA = "0xFE6808", Offset = "0xFE6808", VA = "0xFE6808")]
		[AsyncStateMachine(typeof(<AsyncWaitForCompletion>d__10))]
		public static Task AsyncWaitForCompletion(this Tween t)
		{
			return null;
		}

		[Token(Token = "0x600096D")]
		[Address(RVA = "0xFE68F4", Offset = "0xFE68F4", VA = "0xFE68F4")]
		[AsyncStateMachine(typeof(<AsyncWaitForRewind>d__11))]
		public static Task AsyncWaitForRewind(this Tween t)
		{
			return null;
		}

		[Token(Token = "0x600096E")]
		[Address(RVA = "0xFE69E0", Offset = "0xFE69E0", VA = "0xFE69E0")]
		[AsyncStateMachine(typeof(<AsyncWaitForKill>d__12))]
		public static Task AsyncWaitForKill(this Tween t)
		{
			return null;
		}

		[Token(Token = "0x600096F")]
		[Address(RVA = "0xFE6ACC", Offset = "0xFE6ACC", VA = "0xFE6ACC")]
		[AsyncStateMachine(typeof(<AsyncWaitForElapsedLoops>d__13))]
		public static Task AsyncWaitForElapsedLoops(this Tween t, int elapsedLoops)
		{
			return null;
		}

		[Token(Token = "0x6000970")]
		[Address(RVA = "0xFE6BC0", Offset = "0xFE6BC0", VA = "0xFE6BC0")]
		[AsyncStateMachine(typeof(<AsyncWaitForPosition>d__14))]
		public static Task AsyncWaitForPosition(this Tween t, float position)
		{
			return null;
		}

		[Token(Token = "0x6000971")]
		[Address(RVA = "0xFE6CBC", Offset = "0xFE6CBC", VA = "0xFE6CBC")]
		[AsyncStateMachine(typeof(<AsyncWaitForStart>d__15))]
		public static Task AsyncWaitForStart(this Tween t)
		{
			return null;
		}
	}
	[Token(Token = "0x200016B")]
	public static class DOTweenCYInstruction
	{
		[Token(Token = "0x200016C")]
		public class WaitForCompletion : CustomYieldInstruction
		{
			[Token(Token = "0x400094F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x170000F3")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6000984")]
				[Address(RVA = "0xFE7BFC", Offset = "0xFE7BFC", VA = "0xFE7BFC", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000985")]
			[Address(RVA = "0xFE5E9C", Offset = "0xFE5E9C", VA = "0xFE5E9C")]
			public WaitForCompletion(Tween tween)
			{
			}
		}

		[Token(Token = "0x200016D")]
		public class WaitForRewind : CustomYieldInstruction
		{
			[Token(Token = "0x4000950")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x170000F4")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6000986")]
				[Address(RVA = "0xFE7C2C", Offset = "0xFE7C2C", VA = "0xFE7C2C", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000987")]
			[Address(RVA = "0xFE5F98", Offset = "0xFE5F98", VA = "0xFE5F98")]
			public WaitForRewind(Tween tween)
			{
			}
		}

		[Token(Token = "0x200016E")]
		public class WaitForKill : CustomYieldInstruction
		{
			[Token(Token = "0x4000951")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x170000F5")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6000988")]
				[Address(RVA = "0xFE7C8C", Offset = "0xFE7C8C", VA = "0xFE7C8C", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000989")]
			[Address(RVA = "0xFE6094", Offset = "0xFE6094", VA = "0xFE6094")]
			public WaitForKill(Tween tween)
			{
			}
		}

		[Token(Token = "0x200016F")]
		public class WaitForElapsedLoops : CustomYieldInstruction
		{
			[Token(Token = "0x4000952")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x4000953")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private readonly int elapsedLoops;

			[Token(Token = "0x170000F6")]
			public override bool keepWaiting
			{
				[Token(Token = "0x600098A")]
				[Address(RVA = "0xFE7CA8", Offset = "0xFE7CA8", VA = "0xFE7CA8", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600098B")]
			[Address(RVA = "0xFE6198", Offset = "0xFE6198", VA = "0xFE6198")]
			public WaitForElapsedLoops(Tween tween, int elapsedLoops)
			{
			}
		}

		[Token(Token = "0x2000170")]
		public class WaitForPosition : CustomYieldInstruction
		{
			[Token(Token = "0x4000954")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x4000955")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private readonly float position;

			[Token(Token = "0x170000F7")]
			public override bool keepWaiting
			{
				[Token(Token = "0x600098C")]
				[Address(RVA = "0xFE7CE8", Offset = "0xFE7CE8", VA = "0xFE7CE8", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600098D")]
			[Address(RVA = "0xFE62B0", Offset = "0xFE62B0", VA = "0xFE62B0")]
			public WaitForPosition(Tween tween, float position)
			{
			}
		}

		[Token(Token = "0x2000171")]
		public class WaitForStart : CustomYieldInstruction
		{
			[Token(Token = "0x4000956")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x170000F8")]
			public override bool keepWaiting
			{
				[Token(Token = "0x600098E")]
				[Address(RVA = "0xFE7D40", Offset = "0xFE7D40", VA = "0xFE7D40", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600098F")]
			[Address(RVA = "0xFE63C0", Offset = "0xFE63C0", VA = "0xFE63C0")]
			public WaitForStart(Tween tween)
			{
			}
		}
	}
	[Token(Token = "0x2000172")]
	public static class DOTweenModuleUtils
	{
		[Token(Token = "0x2000173")]
		public static class Physics
		{
			[Token(Token = "0x6000992")]
			[Address(RVA = "0xFE7ED0", Offset = "0xFE7ED0", VA = "0xFE7ED0")]
			public static void SetOrientationOnPath(PathOptions options, Tween t, Quaternion newRot, Transform trans)
			{
			}

			[Token(Token = "0x6000993")]
			[Address(RVA = "0xFE7EE8", Offset = "0xFE7EE8", VA = "0xFE7EE8")]
			public static bool HasRigidbody2D(Component target)
			{
				return default(bool);
			}

			[Token(Token = "0x6000994")]
			[Address(RVA = "0xFE7EF0", Offset = "0xFE7EF0", VA = "0xFE7EF0")]
			[Preserve]
			public static bool HasRigidbody(Component target)
			{
				return default(bool);
			}

			[Token(Token = "0x6000995")]
			[Address(RVA = "0xFE7EF8", Offset = "0xFE7EF8", VA = "0xFE7EF8")]
			[Preserve]
			public static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> CreateDOTweenPathTween(MonoBehaviour target, bool tweenRigidbody, bool isLocal, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, PathMode pathMode)
			{
				return null;
			}
		}

		[Token(Token = "0x4000957")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool _initialized;

		[Token(Token = "0x6000990")]
		[Address(RVA = "0xFE7D74", Offset = "0xFE7D74", VA = "0xFE7D74")]
		[Preserve]
		public static void Init()
		{
		}

		[Token(Token = "0x6000991")]
		[Address(RVA = "0xFE7E28", Offset = "0xFE7E28", VA = "0xFE7E28")]
		[Preserve]
		private static void Preserver()
		{
		}
	}
}
namespace Beebyte.Obfuscator
{
	[Token(Token = "0x2000174")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
	public class DoNotFakeAttribute : Attribute
	{
		[Token(Token = "0x6000996")]
		[Address(RVA = "0xFE7F58", Offset = "0xFE7F58", VA = "0xFE7F58")]
		public DoNotFakeAttribute()
		{
		}
	}
	[Token(Token = "0x2000175")]
	public enum MessageCode
	{
		[Token(Token = "0x4000959")]
		UnityReflectionMethodNotFound
	}
	[Token(Token = "0x2000176")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Constructor | AttributeTargets.Method)]
	public class ObfuscateLiteralsAttribute : Attribute
	{
		[Token(Token = "0x6000997")]
		[Address(RVA = "0xFE7F60", Offset = "0xFE7F60", VA = "0xFE7F60")]
		public ObfuscateLiteralsAttribute()
		{
		}
	}
	[Token(Token = "0x2000177")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface | AttributeTargets.Delegate)]
	public class RenameAttribute : Attribute
	{
		[Token(Token = "0x400095A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly string target;

		[Token(Token = "0x6000998")]
		[Address(RVA = "0xFE7F68", Offset = "0xFE7F68", VA = "0xFE7F68")]
		private RenameAttribute()
		{
		}

		[Token(Token = "0x6000999")]
		[Address(RVA = "0xFE7F70", Offset = "0xFE7F70", VA = "0xFE7F70")]
		public RenameAttribute(string target)
		{
		}

		[Token(Token = "0x600099A")]
		[Address(RVA = "0xFE7FA0", Offset = "0xFE7FA0", VA = "0xFE7FA0")]
		public string GetTarget()
		{
			return null;
		}
	}
	[Token(Token = "0x2000178")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Delegate)]
	public class ReplaceLiteralsWithNameAttribute : Attribute
	{
		[Token(Token = "0x600099B")]
		[Address(RVA = "0xFE7FA8", Offset = "0xFE7FA8", VA = "0xFE7FA8")]
		public ReplaceLiteralsWithNameAttribute()
		{
		}
	}
	[Token(Token = "0x2000179")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate)]
	public class SkipAttribute : Attribute
	{
		[Token(Token = "0x600099C")]
		[Address(RVA = "0xFE7FB0", Offset = "0xFE7FB0", VA = "0xFE7FB0")]
		public SkipAttribute()
		{
		}
	}
	[Token(Token = "0x200017A")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate)]
	public class SkipRenameAttribute : Attribute
	{
		[Token(Token = "0x600099D")]
		[Address(RVA = "0xFE7FB8", Offset = "0xFE7FB8", VA = "0xFE7FB8")]
		public SkipRenameAttribute()
		{
		}
	}
	[Token(Token = "0x200017B")]
	[AttributeUsage(AttributeTargets.Method)]
	public class SuppressLogAttribute : Attribute
	{
		[Token(Token = "0x400095B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly MessageCode _messageCode;

		[Token(Token = "0x600099E")]
		[Address(RVA = "0xFE7FC0", Offset = "0xFE7FC0", VA = "0xFE7FC0")]
		private SuppressLogAttribute()
		{
		}

		[Token(Token = "0x600099F")]
		[Address(RVA = "0xFE7FC8", Offset = "0xFE7FC8", VA = "0xFE7FC8")]
		public SuppressLogAttribute(MessageCode messageCode)
		{
		}
	}
}
namespace UnityAsyncAwaitUtil
{
	[Token(Token = "0x200017C")]
	public class AsyncCoroutineRunner : MonoBehaviour
	{
		[Token(Token = "0x400095C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static AsyncCoroutineRunner _instance;

		[Token(Token = "0x170000F9")]
		public static AsyncCoroutineRunner Instance
		{
			[Token(Token = "0x60009A0")]
			[Address(RVA = "0xFE7FF0", Offset = "0xFE7FF0", VA = "0xFE7FF0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60009A1")]
		[Address(RVA = "0xFE8100", Offset = "0xFE8100", VA = "0xFE8100")]
		private void Awake()
		{
		}

		[Token(Token = "0x60009A2")]
		[Address(RVA = "0xFE818C", Offset = "0xFE818C", VA = "0xFE818C")]
		public AsyncCoroutineRunner()
		{
		}
	}
	[Token(Token = "0x200017D")]
	public static class SyncContextUtil
	{
		[Token(Token = "0x170000FA")]
		public static int UnityThreadId
		{
			[Token(Token = "0x60009A4")]
			[Address(RVA = "0xFE8238", Offset = "0xFE8238", VA = "0xFE8238")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60009A5")]
			[Address(RVA = "0xFE8280", Offset = "0xFE8280", VA = "0xFE8280")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000FB")]
		public static SynchronizationContext UnitySynchronizationContext
		{
			[Token(Token = "0x60009A6")]
			[Address(RVA = "0xFE82CC", Offset = "0xFE82CC", VA = "0xFE82CC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60009A7")]
			[Address(RVA = "0xFE8314", Offset = "0xFE8314", VA = "0xFE8314")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60009A3")]
		[Address(RVA = "0xFE8194", Offset = "0xFE8194", VA = "0xFE8194")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void Install()
		{
		}
	}
	[Token(Token = "0x200017E")]
	public class AsyncUtilTests : MonoBehaviour
	{
		[Token(Token = "0x200017F")]
		[CompilerGenerated]
		private sealed class <RunAsyncFromCoroutineTest>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000963")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000964")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000965")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AsyncUtilTests <>4__this;

			[Token(Token = "0x170000FC")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60009C9")]
				[Address(RVA = "0xFEAF40", Offset = "0xFEAF40", VA = "0xFEAF40", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000FD")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009CB")]
				[Address(RVA = "0xFEAF88", Offset = "0xFEAF88", VA = "0xFEAF88", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009C6")]
			[Address(RVA = "0xFEAD84", Offset = "0xFEAD84", VA = "0xFEAD84")]
			[DebuggerHidden]
			public <RunAsyncFromCoroutineTest>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x60009C7")]
			[Address(RVA = "0xFEADAC", Offset = "0xFEADAC", VA = "0xFEADAC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60009C8")]
			[Address(RVA = "0xFEADB0", Offset = "0xFEADB0", VA = "0xFEADB0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009CA")]
			[Address(RVA = "0xFEAF48", Offset = "0xFEAF48", VA = "0xFEAF48", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000180")]
		[CompilerGenerated]
		private struct <RunMultipleThreadsTestAsync>d__7 : IAsyncStateMachine
		{
			[Token(Token = "0x4000966")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000967")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000968")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AsyncUtilTests <>4__this;

			[Token(Token = "0x4000969")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private TaskAwaiter <>u__1;

			[Token(Token = "0x400096A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2;

			[Token(Token = "0x400096B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private object <>u__3;

			[Token(Token = "0x60009CC")]
			[Address(RVA = "0xFEAF90", Offset = "0xFEAF90", VA = "0xFEAF90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60009CD")]
			[Address(RVA = "0xFEB5CC", Offset = "0xFEB5CC", VA = "0xFEB5CC", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000181")]
		[CompilerGenerated]
		private struct <RunMultipleThreadsTestAsyncWait>d__8 : IAsyncStateMachine
		{
			[Token(Token = "0x400096C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x400096D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x400096E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AsyncUtilTests <>4__this;

			[Token(Token = "0x400096F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private object <>u__1;

			[Token(Token = "0x60009CE")]
			[Address(RVA = "0xFEB5D8", Offset = "0xFEB5D8", VA = "0xFEB5D8", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60009CF")]
			[Address(RVA = "0xFEB854", Offset = "0xFEB854", VA = "0xFEB854", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000182")]
		[CompilerGenerated]
		private struct <RunAsyncFromCoroutineTest2>d__10 : IAsyncStateMachine
		{
			[Token(Token = "0x4000970")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000971")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000972")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private object <>u__1;

			[Token(Token = "0x60009D0")]
			[Address(RVA = "0xFEB860", Offset = "0xFEB860", VA = "0xFEB860", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60009D1")]
			[Address(RVA = "0xFEBA70", Offset = "0xFEBA70", VA = "0xFEBA70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000183")]
		[CompilerGenerated]
		private struct <RunWwwAsync>d__11 : IAsyncStateMachine
		{
			[Token(Token = "0x4000973")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000974")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000975")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private object <>u__1;

			[Token(Token = "0x60009D2")]
			[Address(RVA = "0xFEBA7C", Offset = "0xFEBA7C", VA = "0xFEBA7C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60009D3")]
			[Address(RVA = "0xFEBDC0", Offset = "0xFEBDC0", VA = "0xFEBDC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000184")]
		[CompilerGenerated]
		private struct <RunOpenNotepadTestAsync>d__12 : IAsyncStateMachine
		{
			[Token(Token = "0x4000976")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000977")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000978")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private TaskAwaiter<int> <>u__1;

			[Token(Token = "0x60009D4")]
			[Address(RVA = "0xFEBDCC", Offset = "0xFEBDCC", VA = "0xFEBDCC", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60009D5")]
			[Address(RVA = "0xFEBFF8", Offset = "0xFEBFF8", VA = "0xFEBFF8", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000185")]
		[CompilerGenerated]
		private struct <RunUnhandledExceptionTestAsync>d__13 : IAsyncStateMachine
		{
			[Token(Token = "0x4000979")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x400097A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x400097B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AsyncUtilTests <>4__this;

			[Token(Token = "0x400097C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private TaskAwaiter <>u__1;

			[Token(Token = "0x60009D6")]
			[Address(RVA = "0xFEC004", Offset = "0xFEC004", VA = "0xFEC004", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60009D7")]
			[Address(RVA = "0xFEC190", Offset = "0xFEC190", VA = "0xFEC190", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000186")]
		[CompilerGenerated]
		private struct <RunTryCatchExceptionTestAsync>d__14 : IAsyncStateMachine
		{
			[Token(Token = "0x400097D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x400097E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x400097F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AsyncUtilTests <>4__this;

			[Token(Token = "0x4000980")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private TaskAwaiter <>u__1;

			[Token(Token = "0x60009D8")]
			[Address(RVA = "0xFEC19C", Offset = "0xFEC19C", VA = "0xFEC19C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60009D9")]
			[Address(RVA = "0xFEC418", Offset = "0xFEC418", VA = "0xFEC418", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000187")]
		[CompilerGenerated]
		private struct <NestedRunAsync>d__15 : IAsyncStateMachine
		{
			[Token(Token = "0x4000981")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000982")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000983")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private object <>u__1;

			[Token(Token = "0x60009DA")]
			[Address(RVA = "0xFEC424", Offset = "0xFEC424", VA = "0xFEC424", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60009DB")]
			[Address(RVA = "0xFEC674", Offset = "0xFEC674", VA = "0xFEC674", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000188")]
		[CompilerGenerated]
		private struct <WaitThenThrowException>d__16 : IAsyncStateMachine
		{
			[Token(Token = "0x4000984")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000985")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000986")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private object <>u__1;

			[Token(Token = "0x60009DC")]
			[Address(RVA = "0xFEC680", Offset = "0xFEC680", VA = "0xFEC680", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60009DD")]
			[Address(RVA = "0xFEC8D0", Offset = "0xFEC8D0", VA = "0xFEC8D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000189")]
		[CompilerGenerated]
		private struct <RunAsyncOperationAsync>d__17 : IAsyncStateMachine
		{
			[Token(Token = "0x4000987")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000988")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000989")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AsyncUtilTests <>4__this;

			[Token(Token = "0x400098A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private TaskAwaiter <>u__1;

			[Token(Token = "0x60009DE")]
			[Address(RVA = "0xFEC8DC", Offset = "0xFEC8DC", VA = "0xFEC8DC", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60009DF")]
			[Address(RVA = "0xFECA98", Offset = "0xFECA98", VA = "0xFECA98", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200018A")]
		[CompilerGenerated]
		private struct <InstantiateAssetBundleAsync>d__18 : IAsyncStateMachine
		{
			[Token(Token = "0x400098B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x400098C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x400098D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AsyncUtilTests <>4__this;

			[Token(Token = "0x400098E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string abUrl;

			[Token(Token = "0x400098F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string assetName;

			[Token(Token = "0x4000990")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private AssetBundle <assetBundle>5__2;

			[Token(Token = "0x4000991")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private TaskAwaiter<byte[]> <>u__1;

			[Token(Token = "0x4000992")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private object <>u__2;

			[Token(Token = "0x60009E0")]
			[Address(RVA = "0xFECAA4", Offset = "0xFECAA4", VA = "0xFECAA4", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60009E1")]
			[Address(RVA = "0xFED06C", Offset = "0xFED06C", VA = "0xFED06C", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200018B")]
		[CompilerGenerated]
		private struct <DownloadRawDataAsync>d__19 : IAsyncStateMachine
		{
			[Token(Token = "0x4000993")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000994")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<byte[]> <>t__builder;

			[Token(Token = "0x4000995")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string url;

			[Token(Token = "0x4000996")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UnityWebRequest <request>5__2;

			[Token(Token = "0x4000997")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private object <>u__1;

			[Token(Token = "0x60009E2")]
			[Address(RVA = "0xFED078", Offset = "0xFED078", VA = "0xFED078", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60009E3")]
			[Address(RVA = "0xFED334", Offset = "0xFED334", VA = "0xFED334", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200018C")]
		[CompilerGenerated]
		private struct <RunIEnumeratorTryCatchExceptionAsync>d__20 : IAsyncStateMachine
		{
			[Token(Token = "0x4000998")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000999")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x400099A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AsyncUtilTests <>4__this;

			[Token(Token = "0x400099B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private object <>u__1;

			[Token(Token = "0x60009E4")]
			[Address(RVA = "0xFED38C", Offset = "0xFED38C", VA = "0xFED38C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60009E5")]
			[Address(RVA = "0xFED68C", Offset = "0xFED68C", VA = "0xFED68C", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200018D")]
		[CompilerGenerated]
		private struct <RunIEnumeratorUnhandledExceptionAsync>d__21 : IAsyncStateMachine
		{
			[Token(Token = "0x400099C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x400099D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x400099E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AsyncUtilTests <>4__this;

			[Token(Token = "0x400099F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private object <>u__1;

			[Token(Token = "0x60009E6")]
			[Address(RVA = "0xFED698", Offset = "0xFED698", VA = "0xFED698", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60009E7")]
			[Address(RVA = "0xFED8A8", Offset = "0xFED8A8", VA = "0xFED8A8", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x200018E")]
		[CompilerGenerated]
		private sealed class <WaitThenThrow>d__22 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40009A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40009A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40009A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AsyncUtilTests <>4__this;

			[Token(Token = "0x170000FE")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60009EB")]
				[Address(RVA = "0xFED944", Offset = "0xFED944", VA = "0xFED944", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000FF")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009ED")]
				[Address(RVA = "0xFED98C", Offset = "0xFED98C", VA = "0xFED98C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009E8")]
			[Address(RVA = "0xFED8B4", Offset = "0xFED8B4", VA = "0xFED8B4")]
			[DebuggerHidden]
			public <WaitThenThrow>d__22(int <>1__state)
			{
			}

			[Token(Token = "0x60009E9")]
			[Address(RVA = "0xFED8DC", Offset = "0xFED8DC", VA = "0xFED8DC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60009EA")]
			[Address(RVA = "0xFED8E0", Offset = "0xFED8E0", VA = "0xFED8E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009EC")]
			[Address(RVA = "0xFED94C", Offset = "0xFED94C", VA = "0xFED94C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200018F")]
		[CompilerGenerated]
		private sealed class <WaitThenThrowNested>d__23 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40009A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40009A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x17000100")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60009F1")]
				[Address(RVA = "0xFEDAF0", Offset = "0xFEDAF0", VA = "0xFEDAF0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000101")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009F3")]
				[Address(RVA = "0xFEDB38", Offset = "0xFEDB38", VA = "0xFEDB38", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009EE")]
			[Address(RVA = "0xFED994", Offset = "0xFED994", VA = "0xFED994")]
			[DebuggerHidden]
			public <WaitThenThrowNested>d__23(int <>1__state)
			{
			}

			[Token(Token = "0x60009EF")]
			[Address(RVA = "0xFED9BC", Offset = "0xFED9BC", VA = "0xFED9BC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60009F0")]
			[Address(RVA = "0xFED9C0", Offset = "0xFED9C0", VA = "0xFED9C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009F2")]
			[Address(RVA = "0xFEDAF8", Offset = "0xFEDAF8", VA = "0xFEDAF8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000190")]
		[CompilerGenerated]
		private struct <RunIEnumeratorStringTestAsync>d__24 : IAsyncStateMachine
		{
			[Token(Token = "0x40009A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40009A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40009A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AsyncUtilTests <>4__this;

			[Token(Token = "0x40009A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private object <>u__1;

			[Token(Token = "0x60009F4")]
			[Address(RVA = "0xFEDB40", Offset = "0xFEDB40", VA = "0xFEDB40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60009F5")]
			[Address(RVA = "0xFEDE00", Offset = "0xFEDE00", VA = "0xFEDE00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000191")]
		[CompilerGenerated]
		private struct <RunIEnumeratorUntypedStringTestAsync>d__25 : IAsyncStateMachine
		{
			[Token(Token = "0x40009A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40009AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40009AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AsyncUtilTests <>4__this;

			[Token(Token = "0x40009AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private object <>u__1;

			[Token(Token = "0x60009F6")]
			[Address(RVA = "0xFEDE0C", Offset = "0xFEDE0C", VA = "0xFEDE0C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60009F7")]
			[Address(RVA = "0xFEE0EC", Offset = "0xFEE0EC", VA = "0xFEE0EC", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000192")]
		[CompilerGenerated]
		private struct <RunIEnumeratorTestAsync>d__26 : IAsyncStateMachine
		{
			[Token(Token = "0x40009AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40009AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40009AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AsyncUtilTests <>4__this;

			[Token(Token = "0x40009B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private object <>u__1;

			[Token(Token = "0x60009F8")]
			[Address(RVA = "0xFEE0F8", Offset = "0xFEE0F8", VA = "0xFEE0F8", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60009F9")]
			[Address(RVA = "0xFEE38C", Offset = "0xFEE38C", VA = "0xFEE38C", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x2000193")]
		[CompilerGenerated]
		private sealed class <WaitForString>d__27 : IEnumerator<string>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40009B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40009B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private string <>2__current;

			[Token(Token = "0x40009B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private float <startTime>5__2;

			[Token(Token = "0x17000102")]
			private string System.Collections.Generic.IEnumerator<System.String>.Current
			{
				[Token(Token = "0x60009FD")]
				[Address(RVA = "0xFEE49C", Offset = "0xFEE49C", VA = "0xFEE49C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000103")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009FF")]
				[Address(RVA = "0xFEE4E4", Offset = "0xFEE4E4", VA = "0xFEE4E4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009FA")]
			[Address(RVA = "0xFEE398", Offset = "0xFEE398", VA = "0xFEE398")]
			[DebuggerHidden]
			public <WaitForString>d__27(int <>1__state)
			{
			}

			[Token(Token = "0x60009FB")]
			[Address(RVA = "0xFEE3C0", Offset = "0xFEE3C0", VA = "0xFEE3C0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60009FC")]
			[Address(RVA = "0xFEE3C4", Offset = "0xFEE3C4", VA = "0xFEE3C4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009FE")]
			[Address(RVA = "0xFEE4A4", Offset = "0xFEE4A4", VA = "0xFEE4A4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000194")]
		[CompilerGenerated]
		private sealed class <WaitForStringUntyped>d__28 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40009B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40009B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40009B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AsyncUtilTests <>4__this;

			[Token(Token = "0x17000104")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A03")]
				[Address(RVA = "0xFEE5D8", Offset = "0xFEE5D8", VA = "0xFEE5D8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000105")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A05")]
				[Address(RVA = "0xFEE620", Offset = "0xFEE620", VA = "0xFEE620", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A00")]
			[Address(RVA = "0xFEE4EC", Offset = "0xFEE4EC", VA = "0xFEE4EC")]
			[DebuggerHidden]
			public <WaitForStringUntyped>d__28(int <>1__state)
			{
			}

			[Token(Token = "0x6000A01")]
			[Address(RVA = "0xFEE514", Offset = "0xFEE514", VA = "0xFEE514", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A02")]
			[Address(RVA = "0xFEE518", Offset = "0xFEE518", VA = "0xFEE518", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A04")]
			[Address(RVA = "0xFEE5E0", Offset = "0xFEE5E0", VA = "0xFEE5E0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000195")]
		[CompilerGenerated]
		private sealed class <WaitABit>d__29 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40009B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40009B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x17000106")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A09")]
				[Address(RVA = "0xFEE6F4", Offset = "0xFEE6F4", VA = "0xFEE6F4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000107")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A0B")]
				[Address(RVA = "0xFEE73C", Offset = "0xFEE73C", VA = "0xFEE73C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A06")]
			[Address(RVA = "0xFEE628", Offset = "0xFEE628", VA = "0xFEE628")]
			[DebuggerHidden]
			public <WaitABit>d__29(int <>1__state)
			{
			}

			[Token(Token = "0x6000A07")]
			[Address(RVA = "0xFEE650", Offset = "0xFEE650", VA = "0xFEE650", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A08")]
			[Address(RVA = "0xFEE654", Offset = "0xFEE654", VA = "0xFEE654", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A0A")]
			[Address(RVA = "0xFEE6FC", Offset = "0xFEE6FC", VA = "0xFEE6FC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000196")]
		[CompilerGenerated]
		private struct <RunReturnValueTestAsync>d__30 : IAsyncStateMachine
		{
			[Token(Token = "0x40009B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40009BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40009BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AsyncUtilTests <>4__this;

			[Token(Token = "0x40009BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private object <>u__1;

			[Token(Token = "0x40009BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private TaskAwaiter<string> <>u__2;

			[Token(Token = "0x6000A0C")]
			[Address(RVA = "0xFEE744", Offset = "0xFEE744", VA = "0xFEE744", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000A0D")]
			[Address(RVA = "0xFEEB30", Offset = "0xFEEB30", VA = "0xFEEB30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000197")]
		[CompilerGenerated]
		private struct <GetValueExampleAsync>d__31 : IAsyncStateMachine
		{
			[Token(Token = "0x40009BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40009BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<string> <>t__builder;

			[Token(Token = "0x40009C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private object <>u__1;

			[Token(Token = "0x6000A0E")]
			[Address(RVA = "0xFEEB3C", Offset = "0xFEEB3C", VA = "0xFEEB3C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000A0F")]
			[Address(RVA = "0xFEED84", Offset = "0xFEED84", VA = "0xFEED84", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000198")]
		[CompilerGenerated]
		private struct <RunAwaitSecondsTestAsync>d__32 : IAsyncStateMachine
		{
			[Token(Token = "0x40009C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40009C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40009C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private object <>u__1;

			[Token(Token = "0x6000A10")]
			[Address(RVA = "0xFEEDDC", Offset = "0xFEEDDC", VA = "0xFEEDDC", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000A11")]
			[Address(RVA = "0xFEF06C", Offset = "0xFEF06C", VA = "0xFEF06C", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400095F")]
		private const string AssetBundleSampleUrl = "http://www.stevevermeulen.com/wp-content/uploads/2017/09/teapot.unity3d";

		[Token(Token = "0x4000960")]
		private const string AssetBundleSampleAssetName = "Teapot";

		[Token(Token = "0x4000961")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TestButtonHandler.Settings _buttonSettings;

		[Token(Token = "0x4000962")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TestButtonHandler _buttonHandler;

		[Token(Token = "0x60009A8")]
		[Address(RVA = "0xFE8364", Offset = "0xFE8364", VA = "0xFE8364")]
		public void Awake()
		{
		}

		[Token(Token = "0x60009A9")]
		[Address(RVA = "0xFE83D4", Offset = "0xFE83D4", VA = "0xFE83D4")]
		public void OnGUI()
		{
		}

		[Token(Token = "0x60009AA")]
		[Address(RVA = "0xFE9220", Offset = "0xFE9220", VA = "0xFE9220")]
		[IteratorStateMachine(typeof(<RunAsyncFromCoroutineTest>d__6))]
		private IEnumerator RunAsyncFromCoroutineTest()
		{
			return null;
		}

		[Token(Token = "0x60009AB")]
		[Address(RVA = "0xFE9294", Offset = "0xFE9294", VA = "0xFE9294")]
		[AsyncStateMachine(typeof(<RunMultipleThreadsTestAsync>d__7))]
		private Task RunMultipleThreadsTestAsync()
		{
			return null;
		}

		[Token(Token = "0x60009AC")]
		[Address(RVA = "0xFE9384", Offset = "0xFE9384", VA = "0xFE9384")]
		[AsyncStateMachine(typeof(<RunMultipleThreadsTestAsyncWait>d__8))]
		private Task RunMultipleThreadsTestAsyncWait()
		{
			return null;
		}

		[Token(Token = "0x60009AD")]
		[Address(RVA = "0xFE9470", Offset = "0xFE9470", VA = "0xFE9470")]
		private void PrintCurrentThreadContext([Optional] string prefix)
		{
		}

		[Token(Token = "0x60009AE")]
		[Address(RVA = "0xFE95E4", Offset = "0xFE95E4", VA = "0xFE95E4")]
		[AsyncStateMachine(typeof(<RunAsyncFromCoroutineTest2>d__10))]
		private Task RunAsyncFromCoroutineTest2()
		{
			return null;
		}

		[Token(Token = "0x60009AF")]
		[Address(RVA = "0xFE9150", Offset = "0xFE9150", VA = "0xFE9150")]
		[AsyncStateMachine(typeof(<RunWwwAsync>d__11))]
		private Task RunWwwAsync()
		{
			return null;
		}

		[Token(Token = "0x60009B0")]
		[Address(RVA = "0xFE9080", Offset = "0xFE9080", VA = "0xFE9080")]
		[AsyncStateMachine(typeof(<RunOpenNotepadTestAsync>d__12))]
		private Task RunOpenNotepadTestAsync()
		{
			return null;
		}

		[Token(Token = "0x60009B1")]
		[Address(RVA = "0xFE8A0C", Offset = "0xFE8A0C", VA = "0xFE8A0C")]
		[AsyncStateMachine(typeof(<RunUnhandledExceptionTestAsync>d__13))]
		private Task RunUnhandledExceptionTestAsync()
		{
			return null;
		}

		[Token(Token = "0x60009B2")]
		[Address(RVA = "0xFE8920", Offset = "0xFE8920", VA = "0xFE8920")]
		[AsyncStateMachine(typeof(<RunTryCatchExceptionTestAsync>d__14))]
		private Task RunTryCatchExceptionTestAsync()
		{
			return null;
		}

		[Token(Token = "0x60009B3")]
		[Address(RVA = "0xFE96B4", Offset = "0xFE96B4", VA = "0xFE96B4")]
		[AsyncStateMachine(typeof(<NestedRunAsync>d__15))]
		private Task NestedRunAsync()
		{
			return null;
		}

		[Token(Token = "0x60009B4")]
		[Address(RVA = "0xFE9784", Offset = "0xFE9784", VA = "0xFE9784")]
		[AsyncStateMachine(typeof(<WaitThenThrowException>d__16))]
		private Task WaitThenThrowException()
		{
			return null;
		}

		[Token(Token = "0x60009B5")]
		[Address(RVA = "0xFE8F94", Offset = "0xFE8F94", VA = "0xFE8F94")]
		[AsyncStateMachine(typeof(<RunAsyncOperationAsync>d__17))]
		private Task RunAsyncOperationAsync()
		{
			return null;
		}

		[Token(Token = "0x60009B6")]
		[Address(RVA = "0xFE9854", Offset = "0xFE9854", VA = "0xFE9854")]
		[AsyncStateMachine(typeof(<InstantiateAssetBundleAsync>d__18))]
		private Task InstantiateAssetBundleAsync(string abUrl, string assetName)
		{
			return null;
		}

		[Token(Token = "0x60009B7")]
		[Address(RVA = "0xFE9974", Offset = "0xFE9974", VA = "0xFE9974")]
		[AsyncStateMachine(typeof(<DownloadRawDataAsync>d__19))]
		private Task<byte[]> DownloadRawDataAsync(string url)
		{
			return null;
		}

		[Token(Token = "0x60009B8")]
		[Address(RVA = "0xFE8EA8", Offset = "0xFE8EA8", VA = "0xFE8EA8")]
		[AsyncStateMachine(typeof(<RunIEnumeratorTryCatchExceptionAsync>d__20))]
		private Task RunIEnumeratorTryCatchExceptionAsync()
		{
			return null;
		}

		[Token(Token = "0x60009B9")]
		[Address(RVA = "0xFE8DBC", Offset = "0xFE8DBC", VA = "0xFE8DBC")]
		[AsyncStateMachine(typeof(<RunIEnumeratorUnhandledExceptionAsync>d__21))]
		private Task RunIEnumeratorUnhandledExceptionAsync()
		{
			return null;
		}

		[Token(Token = "0x60009BA")]
		[Address(RVA = "0xFE9A84", Offset = "0xFE9A84", VA = "0xFE9A84")]
		[IteratorStateMachine(typeof(<WaitThenThrow>d__22))]
		private IEnumerator WaitThenThrow()
		{
			return null;
		}

		[Token(Token = "0x60009BB")]
		[Address(RVA = "0xFE9AF8", Offset = "0xFE9AF8", VA = "0xFE9AF8")]
		[IteratorStateMachine(typeof(<WaitThenThrowNested>d__23))]
		private IEnumerator WaitThenThrowNested()
		{
			return null;
		}

		[Token(Token = "0x60009BC")]
		[Address(RVA = "0xFE8CD0", Offset = "0xFE8CD0", VA = "0xFE8CD0")]
		[AsyncStateMachine(typeof(<RunIEnumeratorStringTestAsync>d__24))]
		private Task RunIEnumeratorStringTestAsync()
		{
			return null;
		}

		[Token(Token = "0x60009BD")]
		[Address(RVA = "0xFE8BE4", Offset = "0xFE8BE4", VA = "0xFE8BE4")]
		[AsyncStateMachine(typeof(<RunIEnumeratorUntypedStringTestAsync>d__25))]
		private Task RunIEnumeratorUntypedStringTestAsync()
		{
			return null;
		}

		[Token(Token = "0x60009BE")]
		[Address(RVA = "0xFE8AF8", Offset = "0xFE8AF8", VA = "0xFE8AF8")]
		[AsyncStateMachine(typeof(<RunIEnumeratorTestAsync>d__26))]
		private Task RunIEnumeratorTestAsync()
		{
			return null;
		}

		[Token(Token = "0x60009BF")]
		[Address(RVA = "0xFE9B58", Offset = "0xFE9B58", VA = "0xFE9B58")]
		[IteratorStateMachine(typeof(<WaitForString>d__27))]
		private IEnumerator<string> WaitForString()
		{
			return null;
		}

		[Token(Token = "0x60009C0")]
		[Address(RVA = "0xFE9BB8", Offset = "0xFE9BB8", VA = "0xFE9BB8")]
		[IteratorStateMachine(typeof(<WaitForStringUntyped>d__28))]
		private IEnumerator WaitForStringUntyped()
		{
			return null;
		}

		[Token(Token = "0x60009C1")]
		[Address(RVA = "0xFE9C2C", Offset = "0xFE9C2C", VA = "0xFE9C2C")]
		[IteratorStateMachine(typeof(<WaitABit>d__29))]
		private IEnumerator WaitABit()
		{
			return null;
		}

		[Token(Token = "0x60009C2")]
		[Address(RVA = "0xFE8830", Offset = "0xFE8830", VA = "0xFE8830")]
		[AsyncStateMachine(typeof(<RunReturnValueTestAsync>d__30))]
		private Task RunReturnValueTestAsync()
		{
			return null;
		}

		[Token(Token = "0x60009C3")]
		[Address(RVA = "0xFE9C8C", Offset = "0xFE9C8C", VA = "0xFE9C8C")]
		[AsyncStateMachine(typeof(<GetValueExampleAsync>d__31))]
		private Task<string> GetValueExampleAsync()
		{
			return null;
		}

		[Token(Token = "0x60009C4")]
		[Address(RVA = "0xFE8760", Offset = "0xFE8760", VA = "0xFE8760")]
		[AsyncStateMachine(typeof(<RunAwaitSecondsTestAsync>d__32))]
		private Task RunAwaitSecondsTestAsync()
		{
			return null;
		}

		[Token(Token = "0x60009C5")]
		[Address(RVA = "0xFE9D7C", Offset = "0xFE9D7C", VA = "0xFE9D7C")]
		public AsyncUtilTests()
		{
		}
	}
	[Token(Token = "0x2000199")]
	public class TestButtonHandler
	{
		[Serializable]
		[Token(Token = "0x200019A")]
		public class Settings
		{
			[Token(Token = "0x40009C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int NumPerColumn;

			[Token(Token = "0x40009C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float VerticalMargin;

			[Token(Token = "0x40009C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float VerticalSpacing;

			[Token(Token = "0x40009CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float HorizontalSpacing;

			[Token(Token = "0x40009CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float HorizontalMargin;

			[Token(Token = "0x40009CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public float ButtonWidth;

			[Token(Token = "0x40009CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float ButtonHeight;

			[Token(Token = "0x6000A15")]
			[Address(RVA = "0xFEF198", Offset = "0xFEF198", VA = "0xFEF198")]
			public Settings()
			{
			}
		}

		[Token(Token = "0x40009C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Settings _settings;

		[Token(Token = "0x40009C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int _buttonVCount;

		[Token(Token = "0x40009C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private int _buttonHCount;

		[Token(Token = "0x6000A12")]
		[Address(RVA = "0xFEF078", Offset = "0xFEF078", VA = "0xFEF078")]
		public TestButtonHandler(Settings settings)
		{
		}

		[Token(Token = "0x6000A13")]
		[Address(RVA = "0xFEF0A8", Offset = "0xFEF0A8", VA = "0xFEF0A8")]
		public void Restart()
		{
		}

		[Token(Token = "0x6000A14")]
		[Address(RVA = "0xFEF0B0", Offset = "0xFEF0B0", VA = "0xFEF0B0")]
		public bool Display(string text)
		{
			return default(bool);
		}
	}
}
