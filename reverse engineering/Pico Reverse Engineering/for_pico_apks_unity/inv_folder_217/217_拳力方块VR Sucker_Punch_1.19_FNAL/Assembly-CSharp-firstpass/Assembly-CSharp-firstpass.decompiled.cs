using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Networking;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public static class AwaitExtensions
{
	[Token(Token = "0x2000003")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7C5B74", Offset = "0x7C5B74")]
	private sealed class <>c__DisplayClass0_0
	{
		[Token(Token = "0x4000001")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public TaskCompletionSource<int> tcs;

		[Token(Token = "0x4000002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Process process;

		[Token(Token = "0x6000003")]
		[Address(RVA = "0xF0E858", Offset = "0xF0E858", VA = "0xF0E858")]
		public <>c__DisplayClass0_0()
		{
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0xF195FC", Offset = "0xF195FC", VA = "0xF195FC")]
		internal void <GetAwaiter>b__0(object s, EventArgs e)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x2000004")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7C5B84", Offset = "0x7C5B84")]
	private struct <WrapErrors>d__1 : IAsyncStateMachine
	{
		[Token(Token = "0x4000003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Token(Token = "0x4000005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Task task;

		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TaskAwaiter <>u__1;

		[Token(Token = "0x6000005")]
		[Address(RVA = "0xF19668", Offset = "0xF19668", VA = "0xF19668", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0xF197DC", Offset = "0xF197DC", VA = "0xF197DC", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x6000001")]
	[Address(RVA = "0xF0E6B8", Offset = "0xF0E6B8", VA = "0xF0E6B8")]
	public static TaskAwaiter<int> GetAwaiter(this Process process)
	{
		return default(TaskAwaiter<int>);
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0xF0CD44", Offset = "0xF0CD44", VA = "0xF0CD44")]
	[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x7C5FE4", Offset = "0x7C5FE4")]
	public static void WrapErrors(this Task task)
	{
	}
}
[Token(Token = "0x2000005")]
public static class Awaiters
{
	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly WaitForUpdate _waitForUpdate;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static readonly WaitForFixedUpdate _waitForFixedUpdate;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static readonly WaitForEndOfFrame _waitForEndOfFrame;

	[Token(Token = "0x17000001")]
	public static WaitForUpdate NextFrame
	{
		[Token(Token = "0x6000007")]
		[Address(RVA = "0xF0E860", Offset = "0xF0E860", VA = "0xF0E860")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000002")]
	public static WaitForFixedUpdate FixedUpdate
	{
		[Token(Token = "0x6000008")]
		[Address(RVA = "0xF0E8C4", Offset = "0xF0E8C4", VA = "0xF0E8C4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000003")]
	public static WaitForEndOfFrame EndOfFrame
	{
		[Token(Token = "0x6000009")]
		[Address(RVA = "0xF0E928", Offset = "0xF0E928", VA = "0xF0E928")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0xF0E98C", Offset = "0xF0E98C", VA = "0xF0E98C")]
	public static WaitForSeconds Seconds(float seconds)
	{
		return null;
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0xF0E9F4", Offset = "0xF0E9F4", VA = "0xF0E9F4")]
	public static WaitForSecondsRealtime SecondsRealtime(float seconds)
	{
		return null;
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0xF0EA5C", Offset = "0xF0EA5C", VA = "0xF0EA5C")]
	public static WaitUntil Until(Func<bool> predicate)
	{
		return null;
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0xF0EABC", Offset = "0xF0EABC", VA = "0xF0EABC")]
	public static WaitWhile While(Func<bool> predicate)
	{
		return null;
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
			[Address(RVA = "0xF19C68", Offset = "0xF19C68", VA = "0xF19C68")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0xF15C68", Offset = "0xF15C68", VA = "0xF15C68")]
		public void GetResult()
		{
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0xF19C70", Offset = "0xF19C70", VA = "0xF19C70")]
		public void Complete(Exception e)
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0xF19CC0", Offset = "0xF19CC0", VA = "0xF19CC0", Slot = "4")]
		private void System.Runtime.CompilerServices.INotifyCompletion.OnCompleted(Action continuation)
		{
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0xF0F2B8", Offset = "0xF0F2B8", VA = "0xF0F2B8")]
		public SimpleCoroutineAwaiter()
		{
		}
	}

	[Token(Token = "0x2000009")]
	private class CoroutineWrapper<T>
	{
		[Token(Token = "0x200000A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7C5BA4", Offset = "0x7C5BA4")]
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
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7C6144", Offset = "0x7C6144")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7C5BB4", Offset = "0x7C5BB4")]
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
				[Address(RVA = "0xF1B5EC", Offset = "0xF1B5EC", VA = "0xF1B5EC", Slot = "4")]
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
				[Address(RVA = "0xF1B634", Offset = "0xF1B634", VA = "0xF1B634", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600003A")]
			[Address(RVA = "0xF19BB8", Offset = "0xF19BB8", VA = "0xF19BB8")]
			[DebuggerHidden]
			public <ReturnVoid>d__0(int <>1__state)
			{
			}

			[Token(Token = "0x600003B")]
			[Address(RVA = "0xF1B58C", Offset = "0xF1B58C", VA = "0xF1B58C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600003C")]
			[Address(RVA = "0xF1B590", Offset = "0xF1B590", VA = "0xF1B590", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600003E")]
			[Address(RVA = "0xF1B5F4", Offset = "0xF1B5F4", VA = "0xF1B5F4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200000D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7C5BC4", Offset = "0x7C5BC4")]
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
				[Address(RVA = "0xF1B34C", Offset = "0xF1B34C", VA = "0xF1B34C", Slot = "4")]
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
				[Address(RVA = "0xF1B394", Offset = "0xF1B394", VA = "0xF1B394", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000040")]
			[Address(RVA = "0xF19BE4", Offset = "0xF19BE4", VA = "0xF19BE4")]
			[DebuggerHidden]
			public <AssetBundleCreateRequest>d__1(int <>1__state)
			{
			}

			[Token(Token = "0x6000041")]
			[Address(RVA = "0xF1B2A4", Offset = "0xF1B2A4", VA = "0xF1B2A4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000042")]
			[Address(RVA = "0xF1B2A8", Offset = "0xF1B2A8", VA = "0xF1B2A8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000044")]
			[Address(RVA = "0xF1B354", Offset = "0xF1B354", VA = "0xF1B354", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200000E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7C5BD4", Offset = "0x7C5BD4")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7C5BE4", Offset = "0x7C5BE4")]
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
				[Address(RVA = "0xF1B444", Offset = "0xF1B444", VA = "0xF1B444", Slot = "4")]
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
				[Address(RVA = "0xF1B48C", Offset = "0xF1B48C", VA = "0xF1B48C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600004C")]
			[Address(RVA = "0xF19C10", Offset = "0xF19C10", VA = "0xF19C10")]
			[DebuggerHidden]
			public <AssetBundleRequest>d__3(int <>1__state)
			{
			}

			[Token(Token = "0x600004D")]
			[Address(RVA = "0xF1B39C", Offset = "0xF1B39C", VA = "0xF1B39C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600004E")]
			[Address(RVA = "0xF1B3A0", Offset = "0xF1B3A0", VA = "0xF1B3A0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000050")]
			[Address(RVA = "0xF1B44C", Offset = "0xF1B44C", VA = "0xF1B44C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000010")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7C5BF4", Offset = "0x7C5BF4")]
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
				[Address(RVA = "0xF1B53C", Offset = "0xF1B53C", VA = "0xF1B53C", Slot = "4")]
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
				[Address(RVA = "0xF1B584", Offset = "0xF1B584", VA = "0xF1B584", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000052")]
			[Address(RVA = "0xF19C3C", Offset = "0xF19C3C", VA = "0xF19C3C")]
			[DebuggerHidden]
			public <ResourceRequest>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000053")]
			[Address(RVA = "0xF1B494", Offset = "0xF1B494", VA = "0xF1B494", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000054")]
			[Address(RVA = "0xF1B498", Offset = "0xF1B498", VA = "0xF1B498", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000056")]
			[Address(RVA = "0xF1B544", Offset = "0xF1B544", VA = "0xF1B544", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0xF19A68", Offset = "0xF19A68", VA = "0xF19A68")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7C61F4", Offset = "0x7C61F4")]
		public static IEnumerator ReturnVoid(SimpleCoroutineAwaiter awaiter, object instruction)
		{
			return null;
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0xF1982C", Offset = "0xF1982C", VA = "0xF1982C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7C6254", Offset = "0x7C6254")]
		public static IEnumerator AssetBundleCreateRequest(SimpleCoroutineAwaiter<AssetBundle> awaiter, AssetBundleCreateRequest instruction)
		{
			return null;
		}

		[Token(Token = "0x6000037")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7C62B4", Offset = "0x7C62B4")]
		public static IEnumerator ReturnSelf<T>(SimpleCoroutineAwaiter<T> awaiter, T instruction)
		{
			return null;
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0xF198E8", Offset = "0xF198E8", VA = "0xF198E8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7C6314", Offset = "0x7C6314")]
		public static IEnumerator AssetBundleRequest(SimpleCoroutineAwaiter<UnityEngine.Object> awaiter, AssetBundleRequest instruction)
		{
			return null;
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0xF19B40", Offset = "0xF19B40", VA = "0xF19B40")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7C6374", Offset = "0x7C6374")]
		public static IEnumerator ResourceRequest(SimpleCoroutineAwaiter<UnityEngine.Object> awaiter, ResourceRequest instruction)
		{
			return null;
		}
	}

	[Token(Token = "0x2000011")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7C5C04", Offset = "0x7C5C04")]
	private sealed class <>c__DisplayClass8_0
	{
		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SimpleCoroutineAwaiter<UnityEngine.Object> awaiter;

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ResourceRequest instruction;

		[Token(Token = "0x6000058")]
		[Address(RVA = "0xF0EE3C", Offset = "0xF0EE3C", VA = "0xF0EE3C")]
		public <>c__DisplayClass8_0()
		{
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0xF19AFC", Offset = "0xF19AFC", VA = "0xF19AFC")]
		internal void <GetAwaiter>b__0()
		{
		}
	}

	[Token(Token = "0x2000012")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7C5C14", Offset = "0x7C5C14")]
	private sealed class <>c__DisplayClass10_0
	{
		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SimpleCoroutineAwaiter<AssetBundle> awaiter;

		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AssetBundleCreateRequest instruction;

		[Token(Token = "0x600005A")]
		[Address(RVA = "0xF0F0B0", Offset = "0xF0F0B0", VA = "0xF0F0B0")]
		public <>c__DisplayClass10_0()
		{
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0xF197E8", Offset = "0xF197E8", VA = "0xF197E8")]
		internal void <GetAwaiter>b__0()
		{
		}
	}

	[Token(Token = "0x2000013")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7C5C24", Offset = "0x7C5C24")]
	private sealed class <>c__DisplayClass11_0
	{
		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SimpleCoroutineAwaiter<UnityEngine.Object> awaiter;

		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AssetBundleRequest instruction;

		[Token(Token = "0x600005C")]
		[Address(RVA = "0xF0F1AC", Offset = "0xF0F1AC", VA = "0xF0F1AC")]
		public <>c__DisplayClass11_0()
		{
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0xF198A4", Offset = "0xF198A4", VA = "0xF198A4")]
		internal void <GetAwaiter>b__0()
		{
		}
	}

	[Token(Token = "0x2000014")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7C5C34", Offset = "0x7C5C34")]
	private sealed class <>c__DisplayClass12_0<T>
	{
		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IEnumerator<T> coroutine;

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public SimpleCoroutineAwaiter<T> awaiter;

		[Token(Token = "0x600005E")]
		public <>c__DisplayClass12_0()
		{
		}

		[Token(Token = "0x600005F")]
		internal void <GetAwaiter>b__0()
		{
		}
	}

	[Token(Token = "0x2000015")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7C5C44", Offset = "0x7C5C44")]
	private sealed class <>c__DisplayClass13_0
	{
		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IEnumerator coroutine;

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SimpleCoroutineAwaiter<object> awaiter;

		[Token(Token = "0x6000060")]
		[Address(RVA = "0xF0F2A8", Offset = "0xF0F2A8", VA = "0xF0F2A8")]
		public <>c__DisplayClass13_0()
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0xF19960", Offset = "0xF19960", VA = "0xF19960")]
		internal void <GetAwaiter>b__0()
		{
		}
	}

	[Token(Token = "0x2000016")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7C5C54", Offset = "0x7C5C54")]
	private sealed class <>c__DisplayClass14_0
	{
		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SimpleCoroutineAwaiter awaiter;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public object instruction;

		[Token(Token = "0x6000062")]
		[Address(RVA = "0xF0F2B0", Offset = "0xF0F2B0", VA = "0xF0F2B0")]
		public <>c__DisplayClass14_0()
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0xF19A24", Offset = "0xF19A24", VA = "0xF19A24")]
		internal void <GetAwaiterReturnVoid>b__0()
		{
		}
	}

	[Token(Token = "0x2000017")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7C5C64", Offset = "0x7C5C64")]
	private sealed class <>c__DisplayClass15_0<T>
	{
		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public SimpleCoroutineAwaiter<T> awaiter;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T instruction;

		[Token(Token = "0x6000064")]
		public <>c__DisplayClass15_0()
		{
		}

		[Token(Token = "0x6000065")]
		internal void <GetAwaiterReturnSelf>b__0()
		{
		}
	}

	[Token(Token = "0x2000018")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7C5C74", Offset = "0x7C5C74")]
	private sealed class <>c__DisplayClass16_0
	{
		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Action action;

		[Token(Token = "0x6000066")]
		[Address(RVA = "0xF0F2C0", Offset = "0xF0F2C0", VA = "0xF0F2C0")]
		public <>c__DisplayClass16_0()
		{
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0xF19AE0", Offset = "0xF19AE0", VA = "0xF19AE0")]
		internal void <RunOnUnityScheduler>b__0(object _)
		{
		}
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0xF0EC00", Offset = "0xF0EC00", VA = "0xF0EC00")]
	public static SimpleCoroutineAwaiter GetAwaiter(this WaitForSeconds instruction)
	{
		return null;
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0xF0ECE4", Offset = "0xF0ECE4", VA = "0xF0ECE4")]
	public static SimpleCoroutineAwaiter GetAwaiter(this WaitForUpdate instruction)
	{
		return null;
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0xF0ECE8", Offset = "0xF0ECE8", VA = "0xF0ECE8")]
	public static SimpleCoroutineAwaiter GetAwaiter(this WaitForEndOfFrame instruction)
	{
		return null;
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0xF0ECEC", Offset = "0xF0ECEC", VA = "0xF0ECEC")]
	public static SimpleCoroutineAwaiter GetAwaiter(this WaitForFixedUpdate instruction)
	{
		return null;
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0xF0ECF0", Offset = "0xF0ECF0", VA = "0xF0ECF0")]
	public static SimpleCoroutineAwaiter GetAwaiter(this WaitForSecondsRealtime instruction)
	{
		return null;
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0xF0ECF4", Offset = "0xF0ECF4", VA = "0xF0ECF4")]
	public static SimpleCoroutineAwaiter GetAwaiter(this WaitUntil instruction)
	{
		return null;
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0xF0ECF8", Offset = "0xF0ECF8", VA = "0xF0ECF8")]
	public static SimpleCoroutineAwaiter GetAwaiter(this WaitWhile instruction)
	{
		return null;
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0xF0ECFC", Offset = "0xF0ECFC", VA = "0xF0ECFC")]
	public static SimpleCoroutineAwaiter<AsyncOperation> GetAwaiter(this AsyncOperation instruction)
	{
		return null;
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0xF0ED48", Offset = "0xF0ED48", VA = "0xF0ED48")]
	public static SimpleCoroutineAwaiter<UnityEngine.Object> GetAwaiter(this ResourceRequest instruction)
	{
		return null;
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0xF0EF70", Offset = "0xF0EF70", VA = "0xF0EF70")]
	public static SimpleCoroutineAwaiter<WWW> GetAwaiter(this WWW instruction)
	{
		return null;
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0xF0EFBC", Offset = "0xF0EFBC", VA = "0xF0EFBC")]
	public static SimpleCoroutineAwaiter<AssetBundle> GetAwaiter(this AssetBundleCreateRequest instruction)
	{
		return null;
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0xF0F0B8", Offset = "0xF0F0B8", VA = "0xF0F0B8")]
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
	[Address(RVA = "0xF0F1B4", Offset = "0xF0F1B4", VA = "0xF0F1B4")]
	public static SimpleCoroutineAwaiter<object> GetAwaiter(this IEnumerator coroutine)
	{
		return null;
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0xF0EC04", Offset = "0xF0EC04", VA = "0xF0EC04")]
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
	[Address(RVA = "0xF0EE44", Offset = "0xF0EE44", VA = "0xF0EE44")]
	private static void RunOnUnityScheduler(Action action)
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0xF0F2C8", Offset = "0xF0F2C8", VA = "0xF0F2C8")]
	private static void Assert(bool condition)
	{
	}
}
[Token(Token = "0x2000019")]
public static class TaskExtensions
{
	[Token(Token = "0x200001A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7C5C94", Offset = "0x7C5C94")]
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
			[Address(RVA = "0xF1B1C0", Offset = "0xF1B1C0", VA = "0xF1B1C0", Slot = "4")]
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
			[Address(RVA = "0xF1B208", Offset = "0xF1B208", VA = "0xF1B208", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0xF15624", Offset = "0xF15624", VA = "0xF15624")]
		[DebuggerHidden]
		public <AsIEnumerator>d__0(int <>1__state)
		{
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0xF1B128", Offset = "0xF1B128", VA = "0xF1B128", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0xF1B12C", Offset = "0xF1B12C", VA = "0xF1B12C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0xF1B1C8", Offset = "0xF1B1C8", VA = "0xF1B1C8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200001B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7C5CA4", Offset = "0x7C5CA4")]
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
	[Address(RVA = "0xF155B8", Offset = "0xF155B8", VA = "0xF155B8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7C6564", Offset = "0x7C6564")]
	public static IEnumerator AsIEnumerator(this Task task)
	{
		return null;
	}

	[Token(Token = "0x6000069")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7C65D4", Offset = "0x7C65D4")]
	public static IEnumerator<T> AsIEnumerator<T>(this Task<T> task) where T : class
	{
		return null;
	}
}
[Token(Token = "0x200001C")]
public class WaitForBackgroundThread
{
	[Serializable]
	[Token(Token = "0x200001D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7C5CB4", Offset = "0x7C5CB4")]
	private sealed class <>c
	{
		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Action <>9__0_0;

		[Token(Token = "0x6000079")]
		[Address(RVA = "0xF1B298", Offset = "0xF1B298", VA = "0xF1B298")]
		public <>c()
		{
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0xF1B2A0", Offset = "0xF1B2A0", VA = "0xF1B2A0")]
		internal void <GetAwaiter>b__0_0()
		{
		}
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0xF15650", Offset = "0xF15650", VA = "0xF15650")]
	public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter GetAwaiter()
	{
		return default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0xF15778", Offset = "0xF15778", VA = "0xF15778")]
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
		[Address(RVA = "0xF15780", Offset = "0xF15780", VA = "0xF15780", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0xF0EBF8", Offset = "0xF0EBF8", VA = "0xF0EBF8")]
	public WaitForUpdate()
	{
	}
}
namespace SimpleJSON
{
	[Token(Token = "0x200001F")]
	public enum JSONNodeType
	{
		[Token(Token = "0x4000042")]
		Array = 1,
		[Token(Token = "0x4000043")]
		Object = 2,
		[Token(Token = "0x4000044")]
		String = 3,
		[Token(Token = "0x4000045")]
		Number = 4,
		[Token(Token = "0x4000046")]
		NullValue = 5,
		[Token(Token = "0x4000047")]
		Boolean = 6,
		[Token(Token = "0x4000048")]
		None = 7,
		[Token(Token = "0x4000049")]
		Custom = 255
	}
	[Token(Token = "0x2000020")]
	public enum JSONTextMode
	{
		[Token(Token = "0x400004B")]
		Compact,
		[Token(Token = "0x400004C")]
		Indent
	}
	[Token(Token = "0x2000021")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x7C5CC4", Offset = "0x7C5CC4")]
	public abstract class JSONNode
	{
		[Token(Token = "0x2000022")]
		public struct Enumerator
		{
			[Token(Token = "0x2000023")]
			private enum Type
			{
				[Token(Token = "0x4000055")]
				None,
				[Token(Token = "0x4000056")]
				Array,
				[Token(Token = "0x4000057")]
				Object
			}

			[Token(Token = "0x4000051")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Type type;

			[Token(Token = "0x4000052")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private Dictionary<string, JSONNode>.Enumerator m_Object;

			[Token(Token = "0x4000053")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private List<JSONNode>.Enumerator m_Array;

			[Token(Token = "0x17000031")]
			public bool IsValid
			{
				[Token(Token = "0x60000C6")]
				[Address(RVA = "0xF1A820", Offset = "0xF1A820", VA = "0xF1A820")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000032")]
			public KeyValuePair<string, JSONNode> Current
			{
				[Token(Token = "0x60000C9")]
				[Address(RVA = "0xF1A830", Offset = "0xF1A830", VA = "0xF1A830")]
				get
				{
					return default(KeyValuePair<string, JSONNode>);
				}
			}

			[Token(Token = "0x60000C7")]
			[Address(RVA = "0xF0FC8C", Offset = "0xF0FC8C", VA = "0xF0FC8C")]
			public Enumerator(List<JSONNode>.Enumerator aArrayEnum)
			{
			}

			[Token(Token = "0x60000C8")]
			[Address(RVA = "0xF1407C", Offset = "0xF1407C", VA = "0xF1407C")]
			public Enumerator(Dictionary<string, JSONNode>.Enumerator aDictEnum)
			{
			}

			[Token(Token = "0x60000CA")]
			[Address(RVA = "0xF1A904", Offset = "0xF1A904", VA = "0xF1A904")]
			public bool MoveNext()
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000024")]
		public struct ValueEnumerator
		{
			[Token(Token = "0x4000058")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Enumerator m_Enumerator;

			[Token(Token = "0x17000033")]
			public JSONNode Current
			{
				[Token(Token = "0x60000CE")]
				[Address(RVA = "0xF1AD58", Offset = "0xF1AD58", VA = "0xF1AD58")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000CB")]
			[Address(RVA = "0xF1ACAC", Offset = "0xF1ACAC", VA = "0xF1ACAC")]
			public ValueEnumerator(List<JSONNode>.Enumerator aArrayEnum)
			{
			}

			[Token(Token = "0x60000CC")]
			[Address(RVA = "0xF1ACF4", Offset = "0xF1ACF4", VA = "0xF1ACF4")]
			public ValueEnumerator(Dictionary<string, JSONNode>.Enumerator aDictEnum)
			{
			}

			[Token(Token = "0x60000CD")]
			[Address(RVA = "0xF1AD40", Offset = "0xF1AD40", VA = "0xF1AD40")]
			public ValueEnumerator(Enumerator aEnumerator)
			{
			}

			[Token(Token = "0x60000CF")]
			[Address(RVA = "0xF1ADA0", Offset = "0xF1ADA0", VA = "0xF1ADA0")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000D0")]
			[Address(RVA = "0xF1ADA4", Offset = "0xF1ADA4", VA = "0xF1ADA4")]
			public ValueEnumerator GetEnumerator()
			{
				return default(ValueEnumerator);
			}
		}

		[Token(Token = "0x2000025")]
		public struct KeyEnumerator
		{
			[Token(Token = "0x4000059")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Enumerator m_Enumerator;

			[Token(Token = "0x17000034")]
			public string Current
			{
				[Token(Token = "0x60000D4")]
				[Address(RVA = "0xF1AA48", Offset = "0xF1AA48", VA = "0xF1AA48")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000D1")]
			[Address(RVA = "0xF1A99C", Offset = "0xF1A99C", VA = "0xF1A99C")]
			public KeyEnumerator(List<JSONNode>.Enumerator aArrayEnum)
			{
			}

			[Token(Token = "0x60000D2")]
			[Address(RVA = "0xF1A9E4", Offset = "0xF1A9E4", VA = "0xF1A9E4")]
			public KeyEnumerator(Dictionary<string, JSONNode>.Enumerator aDictEnum)
			{
			}

			[Token(Token = "0x60000D3")]
			[Address(RVA = "0xF1AA30", Offset = "0xF1AA30", VA = "0xF1AA30")]
			public KeyEnumerator(Enumerator aEnumerator)
			{
			}

			[Token(Token = "0x60000D5")]
			[Address(RVA = "0xF1AA88", Offset = "0xF1AA88", VA = "0xF1AA88")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000D6")]
			[Address(RVA = "0xF1AA8C", Offset = "0xF1AA8C", VA = "0xF1AA8C")]
			public KeyEnumerator GetEnumerator()
			{
				return default(KeyEnumerator);
			}
		}

		[Token(Token = "0x2000026")]
		public class LinqEnumerator : IEnumerator<KeyValuePair<string, JSONNode>>, IEnumerator, IDisposable, IEnumerable<KeyValuePair<string, JSONNode>>, IEnumerable
		{
			[Token(Token = "0x400005A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private JSONNode m_Node;

			[Token(Token = "0x400005B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Enumerator m_Enumerator;

			[Token(Token = "0x17000035")]
			public KeyValuePair<string, JSONNode> Current
			{
				[Token(Token = "0x60000D8")]
				[Address(RVA = "0xF1AA9C", Offset = "0xF1AA9C", VA = "0xF1AA9C", Slot = "4")]
				get
				{
					return default(KeyValuePair<string, JSONNode>);
				}
			}

			[Token(Token = "0x17000036")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000D9")]
				[Address(RVA = "0xF1AAA4", Offset = "0xF1AAA4", VA = "0xF1AAA4", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000D7")]
			[Address(RVA = "0xF121B0", Offset = "0xF121B0", VA = "0xF121B0")]
			internal LinqEnumerator(JSONNode aNode)
			{
			}

			[Token(Token = "0x60000DA")]
			[Address(RVA = "0xF1AB0C", Offset = "0xF1AB0C", VA = "0xF1AB0C", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000DB")]
			[Address(RVA = "0xF1AB14", Offset = "0xF1AB14", VA = "0xF1AB14", Slot = "5")]
			public void Dispose()
			{
			}

			[Token(Token = "0x60000DC")]
			[Address(RVA = "0xF1AB34", Offset = "0xF1AB34", VA = "0xF1AB34", Slot = "9")]
			public IEnumerator<KeyValuePair<string, JSONNode>> GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x60000DD")]
			[Address(RVA = "0xF1AB94", Offset = "0xF1AB94", VA = "0xF1AB94", Slot = "8")]
			public void Reset()
			{
			}

			[Token(Token = "0x60000DE")]
			[Address(RVA = "0xF1AC4C", Offset = "0xF1AC4C", VA = "0xF1AC4C", Slot = "10")]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x2000027")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7C5CFC", Offset = "0x7C5CFC")]
		private sealed class <get_Children>d__43 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400005C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400005D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private JSONNode <>2__current;

			[Token(Token = "0x400005E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x17000037")]
			private JSONNode System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>.Current
			{
				[Token(Token = "0x60000E2")]
				[Address(RVA = "0xF1A000", Offset = "0xF1A000", VA = "0xF1A000", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000038")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000E4")]
				[Address(RVA = "0xF1A048", Offset = "0xF1A048", VA = "0xF1A048", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000DF")]
			[Address(RVA = "0xF11F2C", Offset = "0xF11F2C", VA = "0xF11F2C")]
			[DebuggerHidden]
			public <get_Children>d__43(int <>1__state)
			{
			}

			[Token(Token = "0x60000E0")]
			[Address(RVA = "0xF19FE4", Offset = "0xF19FE4", VA = "0xF19FE4", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000E1")]
			[Address(RVA = "0xF19FE8", Offset = "0xF19FE8", VA = "0xF19FE8", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000E3")]
			[Address(RVA = "0xF1A008", Offset = "0xF1A008", VA = "0xF1A008", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60000E5")]
			[Address(RVA = "0xF1A050", Offset = "0xF1A050", VA = "0xF1A050", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x60000E6")]
			[Address(RVA = "0xF1A0E4", Offset = "0xF1A0E4", VA = "0xF1A0E4", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x2000028")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7C5D0C", Offset = "0x7C5D0C")]
		private sealed class <get_DeepChildren>d__45 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400005F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000060")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private JSONNode <>2__current;

			[Token(Token = "0x4000061")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x4000062")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public JSONNode <>4__this;

			[Token(Token = "0x4000063")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private IEnumerator<JSONNode> <>7__wrap1;

			[Token(Token = "0x4000064")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private IEnumerator<JSONNode> <>7__wrap2;

			[Token(Token = "0x17000039")]
			private JSONNode System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>.Current
			{
				[Token(Token = "0x60000EC")]
				[Address(RVA = "0xF1A724", Offset = "0xF1A724", VA = "0xF1A724", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700003A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000EE")]
				[Address(RVA = "0xF1A76C", Offset = "0xF1A76C", VA = "0xF1A76C", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000E7")]
			[Address(RVA = "0xF11FE0", Offset = "0xF11FE0", VA = "0xF11FE0")]
			[DebuggerHidden]
			public <get_DeepChildren>d__45(int <>1__state)
			{
			}

			[Token(Token = "0x60000E8")]
			[Address(RVA = "0xF1A0E8", Offset = "0xF1A0E8", VA = "0xF1A0E8", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000E9")]
			[Address(RVA = "0xF1A2F0", Offset = "0xF1A2F0", VA = "0xF1A2F0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000EA")]
			[Address(RVA = "0xF1A234", Offset = "0xF1A234", VA = "0xF1A234")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60000EB")]
			[Address(RVA = "0xF1A178", Offset = "0xF1A178", VA = "0xF1A178")]
			private void <>m__Finally2()
			{
			}

			[Token(Token = "0x60000ED")]
			[Address(RVA = "0xF1A72C", Offset = "0xF1A72C", VA = "0xF1A72C", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60000EF")]
			[Address(RVA = "0xF1A774", Offset = "0xF1A774", VA = "0xF1A774", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x60000F0")]
			[Address(RVA = "0xF1A81C", Offset = "0xF1A81C", VA = "0xF1A81C", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool forceASCII;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		public static bool longAsString;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		public static bool allowLineComments;

		[Token(Token = "0x4000050")]
		[ThreadStatic]
		private static StringBuilder m_EscapeBuilder;

		[Token(Token = "0x17000017")]
		public abstract JSONNodeType Tag
		{
			[Token(Token = "0x600007D")]
			get;
		}

		[Token(Token = "0x17000018")]
		public virtual JSONNode Item
		{
			[Token(Token = "0x600007E")]
			[Address(RVA = "0xF11D8C", Offset = "0xF11D8C", VA = "0xF11D8C", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x600007F")]
			[Address(RVA = "0xF11D94", Offset = "0xF11D94", VA = "0xF11D94", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x17000019")]
		public virtual JSONNode Item
		{
			[Token(Token = "0x6000080")]
			[Address(RVA = "0xF11D98", Offset = "0xF11D98", VA = "0xF11D98", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000081")]
			[Address(RVA = "0xF11DA0", Offset = "0xF11DA0", VA = "0xF11DA0", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x1700001A")]
		public virtual string Value
		{
			[Token(Token = "0x6000082")]
			[Address(RVA = "0xF11DA4", Offset = "0xF11DA4", VA = "0xF11DA4", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000083")]
			[Address(RVA = "0xF11DE8", Offset = "0xF11DE8", VA = "0xF11DE8", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x1700001B")]
		public virtual int Count
		{
			[Token(Token = "0x6000084")]
			[Address(RVA = "0xF11DEC", Offset = "0xF11DEC", VA = "0xF11DEC", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700001C")]
		public virtual bool IsNumber
		{
			[Token(Token = "0x6000085")]
			[Address(RVA = "0xF11DF4", Offset = "0xF11DF4", VA = "0xF11DF4", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001D")]
		public virtual bool IsString
		{
			[Token(Token = "0x6000086")]
			[Address(RVA = "0xF11DFC", Offset = "0xF11DFC", VA = "0xF11DFC", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001E")]
		public virtual bool IsBoolean
		{
			[Token(Token = "0x6000087")]
			[Address(RVA = "0xF11E04", Offset = "0xF11E04", VA = "0xF11E04", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001F")]
		public virtual bool IsNull
		{
			[Token(Token = "0x6000088")]
			[Address(RVA = "0xF11E0C", Offset = "0xF11E0C", VA = "0xF11E0C", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000020")]
		public virtual bool IsArray
		{
			[Token(Token = "0x6000089")]
			[Address(RVA = "0xF11E14", Offset = "0xF11E14", VA = "0xF11E14", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000021")]
		public virtual bool IsObject
		{
			[Token(Token = "0x600008A")]
			[Address(RVA = "0xF11E1C", Offset = "0xF11E1C", VA = "0xF11E1C", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000022")]
		public virtual bool Inline
		{
			[Token(Token = "0x600008B")]
			[Address(RVA = "0xF11E24", Offset = "0xF11E24", VA = "0xF11E24", Slot = "18")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600008C")]
			[Address(RVA = "0xF11E2C", Offset = "0xF11E2C", VA = "0xF11E2C", Slot = "19")]
			set
			{
			}
		}

		[Token(Token = "0x17000023")]
		public virtual IEnumerable<JSONNode> Children
		{
			[Token(Token = "0x6000094")]
			[Address(RVA = "0xF11EC0", Offset = "0xF11EC0", VA = "0xF11EC0", Slot = "27")]
			[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7C66E4", Offset = "0x7C66E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000024")]
		public IEnumerable<JSONNode> DeepChildren
		{
			[Token(Token = "0x6000095")]
			[Address(RVA = "0xF11F64", Offset = "0xF11F64", VA = "0xF11F64")]
			[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7C6744", Offset = "0x7C6744")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000025")]
		public IEnumerable<KeyValuePair<string, JSONNode>> Linq
		{
			[Token(Token = "0x600009C")]
			[Address(RVA = "0xF12154", Offset = "0xF12154", VA = "0xF12154")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000026")]
		public KeyEnumerator Keys
		{
			[Token(Token = "0x600009D")]
			[Address(RVA = "0xF12280", Offset = "0xF12280", VA = "0xF12280")]
			get
			{
				return default(KeyEnumerator);
			}
		}

		[Token(Token = "0x17000027")]
		public ValueEnumerator Values
		{
			[Token(Token = "0x600009E")]
			[Address(RVA = "0xF122C8", Offset = "0xF122C8", VA = "0xF122C8")]
			get
			{
				return default(ValueEnumerator);
			}
		}

		[Token(Token = "0x17000028")]
		public virtual double AsDouble
		{
			[Token(Token = "0x600009F")]
			[Address(RVA = "0xF12310", Offset = "0xF12310", VA = "0xF12310", Slot = "33")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x60000A0")]
			[Address(RVA = "0xF123F4", Offset = "0xF123F4", VA = "0xF123F4", Slot = "34")]
			set
			{
			}
		}

		[Token(Token = "0x17000029")]
		public virtual int AsInt
		{
			[Token(Token = "0x60000A1")]
			[Address(RVA = "0xF12488", Offset = "0xF12488", VA = "0xF12488", Slot = "35")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60000A2")]
			[Address(RVA = "0xF124C0", Offset = "0xF124C0", VA = "0xF124C0", Slot = "36")]
			set
			{
			}
		}

		[Token(Token = "0x1700002A")]
		public virtual float AsFloat
		{
			[Token(Token = "0x60000A3")]
			[Address(RVA = "0xF124D8", Offset = "0xF124D8", VA = "0xF124D8", Slot = "37")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60000A4")]
			[Address(RVA = "0xF124FC", Offset = "0xF124FC", VA = "0xF124FC", Slot = "38")]
			set
			{
			}
		}

		[Token(Token = "0x1700002B")]
		public virtual bool AsBool
		{
			[Token(Token = "0x60000A5")]
			[Address(RVA = "0xF12510", Offset = "0xF12510", VA = "0xF12510", Slot = "39")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000A6")]
			[Address(RVA = "0xF125D4", Offset = "0xF125D4", VA = "0xF125D4", Slot = "40")]
			set
			{
			}
		}

		[Token(Token = "0x1700002C")]
		public virtual long AsLong
		{
			[Token(Token = "0x60000A7")]
			[Address(RVA = "0xF12658", Offset = "0xF12658", VA = "0xF12658", Slot = "41")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x60000A8")]
			[Address(RVA = "0xF12698", Offset = "0xF12698", VA = "0xF12698", Slot = "42")]
			set
			{
			}
		}

		[Token(Token = "0x1700002D")]
		public virtual ulong AsULong
		{
			[Token(Token = "0x60000A9")]
			[Address(RVA = "0xF126D8", Offset = "0xF126D8", VA = "0xF126D8", Slot = "43")]
			get
			{
				return default(ulong);
			}
			[Token(Token = "0x60000AA")]
			[Address(RVA = "0xF12718", Offset = "0xF12718", VA = "0xF12718", Slot = "44")]
			set
			{
			}
		}

		[Token(Token = "0x1700002E")]
		public virtual JSONArray AsArray
		{
			[Token(Token = "0x60000AB")]
			[Address(RVA = "0xF12758", Offset = "0xF12758", VA = "0xF12758", Slot = "45")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002F")]
		public virtual JSONObject AsObject
		{
			[Token(Token = "0x60000AC")]
			[Address(RVA = "0xF127D4", Offset = "0xF127D4", VA = "0xF127D4", Slot = "46")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000030")]
		internal static StringBuilder EscapeBuilder
		{
			[Token(Token = "0x60000C0")]
			[Address(RVA = "0xF1308C", Offset = "0xF1308C", VA = "0xF1308C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0xF11E30", Offset = "0xF11E30", VA = "0xF11E30", Slot = "20")]
		public virtual void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0xF11E34", Offset = "0xF11E34", VA = "0xF11E34", Slot = "21")]
		public virtual void Add(JSONNode aItem)
		{
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0xF11E9C", Offset = "0xF11E9C", VA = "0xF11E9C", Slot = "22")]
		public virtual JSONNode Remove(string aKey)
		{
			return null;
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0xF11EA4", Offset = "0xF11EA4", VA = "0xF11EA4", Slot = "23")]
		public virtual JSONNode Remove(int aIndex)
		{
			return null;
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0xF11EAC", Offset = "0xF11EAC", VA = "0xF11EAC", Slot = "24")]
		public virtual JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0xF11EB4", Offset = "0xF11EB4", VA = "0xF11EB4", Slot = "25")]
		public virtual void Clear()
		{
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0xF11EB8", Offset = "0xF11EB8", VA = "0xF11EB8", Slot = "26")]
		public virtual JSONNode Clone()
		{
			return null;
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0xF12018", Offset = "0xF12018", VA = "0xF12018", Slot = "28")]
		public virtual bool HasKey(string aKey)
		{
			return default(bool);
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0xF12020", Offset = "0xF12020", VA = "0xF12020", Slot = "29")]
		public virtual JSONNode GetValueOrDefault(string aKey, JSONNode aDefault)
		{
			return null;
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0xF12028", Offset = "0xF12028", VA = "0xF12028", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0xF120B8", Offset = "0xF120B8", VA = "0xF120B8", Slot = "30")]
		public virtual string ToString(int aIndent)
		{
			return null;
		}

		[Token(Token = "0x600009A")]
		internal abstract void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode);

		[Token(Token = "0x600009B")]
		public abstract Enumerator GetEnumerator();

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0xF12850", Offset = "0xF12850", VA = "0xF12850")]
		public static implicit operator JSONNode(string s)
		{
			return null;
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0xF128E8", Offset = "0xF128E8", VA = "0xF128E8")]
		public static implicit operator string(JSONNode d)
		{
			return null;
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0xF12978", Offset = "0xF12978", VA = "0xF12978")]
		public static implicit operator JSONNode(double n)
		{
			return null;
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0xF129DC", Offset = "0xF129DC", VA = "0xF129DC")]
		public static implicit operator double(JSONNode d)
		{
			return default(double);
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0xF12A70", Offset = "0xF12A70", VA = "0xF12A70")]
		public static implicit operator JSONNode(float n)
		{
			return null;
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0xF12AD4", Offset = "0xF12AD4", VA = "0xF12AD4")]
		public static implicit operator float(JSONNode d)
		{
			return default(float);
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0xF12B68", Offset = "0xF12B68", VA = "0xF12B68")]
		public static implicit operator JSONNode(int n)
		{
			return null;
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0xF12BC4", Offset = "0xF12BC4", VA = "0xF12BC4")]
		public static implicit operator int(JSONNode d)
		{
			return default(int);
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0xF12C58", Offset = "0xF12C58", VA = "0xF12C58")]
		public static implicit operator JSONNode(long n)
		{
			return null;
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0xF12D3C", Offset = "0xF12D3C", VA = "0xF12D3C")]
		public static implicit operator long(JSONNode d)
		{
			return default(long);
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0xF12DD0", Offset = "0xF12DD0", VA = "0xF12DD0")]
		public static implicit operator JSONNode(ulong n)
		{
			return null;
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0xF12EB4", Offset = "0xF12EB4", VA = "0xF12EB4")]
		public static implicit operator ulong(JSONNode d)
		{
			return default(ulong);
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0xF12F48", Offset = "0xF12F48", VA = "0xF12F48")]
		public static implicit operator JSONNode(bool b)
		{
			return null;
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0xF12FA4", Offset = "0xF12FA4", VA = "0xF12FA4")]
		public static implicit operator bool(JSONNode d)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0xF13038", Offset = "0xF13038", VA = "0xF13038")]
		public static implicit operator JSONNode(KeyValuePair<string, JSONNode> aKeyValue)
		{
			return null;
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0xF0FF0C", Offset = "0xF0FF0C", VA = "0xF0FF0C")]
		public static bool operator ==(JSONNode a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0xF107D8", Offset = "0xF107D8", VA = "0xF107D8")]
		public static bool operator !=(JSONNode a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0xF13078", Offset = "0xF13078", VA = "0xF13078", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0xF13084", Offset = "0xF13084", VA = "0xF13084", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0xF13164", Offset = "0xF13164", VA = "0xF13164")]
		internal static string Escape(string aText)
		{
			return null;
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0xF1346C", Offset = "0xF1346C", VA = "0xF1346C")]
		private static JSONNode ParseElement(string token, bool quoted)
		{
			return null;
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0xF0F384", Offset = "0xF0F384", VA = "0xF0F384")]
		public static JSONNode Parse(string aJSON)
		{
			return null;
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0xF10A88", Offset = "0xF10A88", VA = "0xF10A88")]
		protected JSONNode()
		{
		}
	}
	[Token(Token = "0x2000029")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x7C5D1C", Offset = "0x7C5D1C")]
	public class JSONArray : JSONNode
	{
		[Token(Token = "0x200002A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7C5D54", Offset = "0x7C5D54")]
		private sealed class <get_Children>d__24 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000067")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000068")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private JSONNode <>2__current;

			[Token(Token = "0x4000069")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x400006A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public JSONArray <>4__this;

			[Token(Token = "0x400006B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private List<JSONNode>.Enumerator <>7__wrap1;

			[Token(Token = "0x17000042")]
			private JSONNode System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>.Current
			{
				[Token(Token = "0x6000107")]
				[Address(RVA = "0xF19EE8", Offset = "0xF19EE8", VA = "0xF19EE8", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000043")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000109")]
				[Address(RVA = "0xF19F30", Offset = "0xF19F30", VA = "0xF19F30", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000103")]
			[Address(RVA = "0xF108D0", Offset = "0xF108D0", VA = "0xF108D0")]
			[DebuggerHidden]
			public <get_Children>d__24(int <>1__state)
			{
			}

			[Token(Token = "0x6000104")]
			[Address(RVA = "0xF19D04", Offset = "0xF19D04", VA = "0xF19D04", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000105")]
			[Address(RVA = "0xF19D74", Offset = "0xF19D74", VA = "0xF19D74", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000106")]
			[Address(RVA = "0xF19D20", Offset = "0xF19D20", VA = "0xF19D20")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000108")]
			[Address(RVA = "0xF19EF0", Offset = "0xF19EF0", VA = "0xF19EF0", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x600010A")]
			[Address(RVA = "0xF19F38", Offset = "0xF19F38", VA = "0xF19F38", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x600010B")]
			[Address(RVA = "0xF19FE0", Offset = "0xF19FE0", VA = "0xF19FE0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private List<JSONNode> m_List;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool inline;

		[Token(Token = "0x1700003B")]
		public override bool Inline
		{
			[Token(Token = "0x60000F1")]
			[Address(RVA = "0xF0FBD8", Offset = "0xF0FBD8", VA = "0xF0FBD8", Slot = "18")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000F2")]
			[Address(RVA = "0xF0FBE0", Offset = "0xF0FBE0", VA = "0xF0FBE0", Slot = "19")]
			set
			{
			}
		}

		[Token(Token = "0x1700003C")]
		public override JSONNodeType Tag
		{
			[Token(Token = "0x60000F3")]
			[Address(RVA = "0xF0FBEC", Offset = "0xF0FBEC", VA = "0xF0FBEC", Slot = "4")]
			get
			{
				return default(JSONNodeType);
			}
		}

		[Token(Token = "0x1700003D")]
		public override bool IsArray
		{
			[Token(Token = "0x60000F4")]
			[Address(RVA = "0xF0FBF4", Offset = "0xF0FBF4", VA = "0xF0FBF4", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003E")]
		public override JSONNode Item
		{
			[Token(Token = "0x60000F6")]
			[Address(RVA = "0xF0FCB4", Offset = "0xF0FCB4", VA = "0xF0FCB4", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000F7")]
			[Address(RVA = "0xF0FDE4", Offset = "0xF0FDE4", VA = "0xF0FDE4", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x1700003F")]
		public override JSONNode Item
		{
			[Token(Token = "0x60000F8")]
			[Address(RVA = "0xF10140", Offset = "0xF10140", VA = "0xF10140", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000F9")]
			[Address(RVA = "0xF1019C", Offset = "0xF1019C", VA = "0xF1019C", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x17000040")]
		public override int Count
		{
			[Token(Token = "0x60000FA")]
			[Address(RVA = "0xF10270", Offset = "0xF10270", VA = "0xF10270", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000041")]
		public override IEnumerable<JSONNode> Children
		{
			[Token(Token = "0x6000100")]
			[Address(RVA = "0xF10854", Offset = "0xF10854", VA = "0xF10854", Slot = "27")]
			[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7C6884", Offset = "0x7C6884")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0xF0FBFC", Offset = "0xF0FBFC", VA = "0xF0FBFC", Slot = "32")]
		public override Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0xF102BC", Offset = "0xF102BC", VA = "0xF102BC", Slot = "20")]
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0xF10390", Offset = "0xF10390", VA = "0xF10390", Slot = "23")]
		public override JSONNode Remove(int aIndex)
		{
			return null;
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0xF10450", Offset = "0xF10450", VA = "0xF10450", Slot = "24")]
		public override JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0xF104BC", Offset = "0xF104BC", VA = "0xF104BC", Slot = "25")]
		public override void Clear()
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0xF10510", Offset = "0xF10510", VA = "0xF10510", Slot = "26")]
		public override JSONNode Clone()
		{
			return null;
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0xF10908", Offset = "0xF10908", VA = "0xF10908", Slot = "31")]
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0xF10734", Offset = "0xF10734", VA = "0xF10734")]
		public JSONArray()
		{
		}
	}
	[Token(Token = "0x200002B")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x7C5D64", Offset = "0x7C5D64")]
	public class JSONObject : JSONNode
	{
		[Token(Token = "0x200002C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7C5D9C", Offset = "0x7C5D9C")]
		private sealed class <>c__DisplayClass21_0
		{
			[Token(Token = "0x400006E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public JSONNode aNode;

			[Token(Token = "0x6000121")]
			[Address(RVA = "0xF14A38", Offset = "0xF14A38", VA = "0xF14A38")]
			public <>c__DisplayClass21_0()
			{
			}

			[Token(Token = "0x6000122")]
			[Address(RVA = "0xF1ADB4", Offset = "0xF1ADB4", VA = "0xF1ADB4")]
			internal bool <Remove>b__0(KeyValuePair<string, JSONNode> k)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200002D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7C5DAC", Offset = "0x7C5DAC")]
		private sealed class <get_Children>d__27 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400006F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000070")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private JSONNode <>2__current;

			[Token(Token = "0x4000071")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x4000072")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public JSONObject <>4__this;

			[Token(Token = "0x4000073")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Dictionary<string, JSONNode>.Enumerator <>7__wrap1;

			[Token(Token = "0x1700004B")]
			private JSONNode System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>.Current
			{
				[Token(Token = "0x6000127")]
				[Address(RVA = "0xF1B02C", Offset = "0xF1B02C", VA = "0xF1B02C", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700004C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000129")]
				[Address(RVA = "0xF1B074", Offset = "0xF1B074", VA = "0xF1B074", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000123")]
			[Address(RVA = "0xF14D98", Offset = "0xF14D98", VA = "0xF14D98")]
			[DebuggerHidden]
			public <get_Children>d__27(int <>1__state)
			{
			}

			[Token(Token = "0x6000124")]
			[Address(RVA = "0xF1AE34", Offset = "0xF1AE34", VA = "0xF1AE34", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000125")]
			[Address(RVA = "0xF1AEA4", Offset = "0xF1AEA4", VA = "0xF1AEA4", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000126")]
			[Address(RVA = "0xF1AE50", Offset = "0xF1AE50", VA = "0xF1AE50")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000128")]
			[Address(RVA = "0xF1B034", Offset = "0xF1B034", VA = "0xF1B034", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x600012A")]
			[Address(RVA = "0xF1B07C", Offset = "0xF1B07C", VA = "0xF1B07C", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x600012B")]
			[Address(RVA = "0xF1B124", Offset = "0xF1B124", VA = "0xF1B124", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Dictionary<string, JSONNode> m_Dict;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool inline;

		[Token(Token = "0x17000044")]
		public override bool Inline
		{
			[Token(Token = "0x600010C")]
			[Address(RVA = "0xF13FC4", Offset = "0xF13FC4", VA = "0xF13FC4", Slot = "18")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600010D")]
			[Address(RVA = "0xF13FCC", Offset = "0xF13FCC", VA = "0xF13FCC", Slot = "19")]
			set
			{
			}
		}

		[Token(Token = "0x17000045")]
		public override JSONNodeType Tag
		{
			[Token(Token = "0x600010E")]
			[Address(RVA = "0xF13FD8", Offset = "0xF13FD8", VA = "0xF13FD8", Slot = "4")]
			get
			{
				return default(JSONNodeType);
			}
		}

		[Token(Token = "0x17000046")]
		public override bool IsObject
		{
			[Token(Token = "0x600010F")]
			[Address(RVA = "0xF13FE0", Offset = "0xF13FE0", VA = "0xF13FE0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000047")]
		public override JSONNode Item
		{
			[Token(Token = "0x6000111")]
			[Address(RVA = "0xF140A0", Offset = "0xF140A0", VA = "0xF140A0", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000112")]
			[Address(RVA = "0xF14170", Offset = "0xF14170", VA = "0xF14170", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x17000048")]
		public override JSONNode Item
		{
			[Token(Token = "0x6000113")]
			[Address(RVA = "0xF142B0", Offset = "0xF142B0", VA = "0xF142B0", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000114")]
			[Address(RVA = "0xF1435C", Offset = "0xF1435C", VA = "0xF1435C", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x17000049")]
		public override int Count
		{
			[Token(Token = "0x6000115")]
			[Address(RVA = "0xF144B0", Offset = "0xF144B0", VA = "0xF144B0", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700004A")]
		public override IEnumerable<JSONNode> Children
		{
			[Token(Token = "0x600011E")]
			[Address(RVA = "0xF14D1C", Offset = "0xF14D1C", VA = "0xF14D1C", Slot = "27")]
			[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7C6954", Offset = "0x7C6954")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0xF13FE8", Offset = "0xF13FE8", VA = "0xF13FE8", Slot = "32")]
		public override Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0xF14504", Offset = "0xF14504", VA = "0xF14504", Slot = "20")]
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0xF146B4", Offset = "0xF146B4", VA = "0xF146B4", Slot = "22")]
		public override JSONNode Remove(string aKey)
		{
			return null;
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0xF14784", Offset = "0xF14784", VA = "0xF14784", Slot = "23")]
		public override JSONNode Remove(int aIndex)
		{
			return null;
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0xF1486C", Offset = "0xF1486C", VA = "0xF1486C", Slot = "24")]
		public override JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0xF14A40", Offset = "0xF14A40", VA = "0xF14A40", Slot = "25")]
		public override void Clear()
		{
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0xF14A94", Offset = "0xF14A94", VA = "0xF14A94", Slot = "26")]
		public override JSONNode Clone()
		{
			return null;
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0xF14C30", Offset = "0xF14C30", VA = "0xF14C30", Slot = "28")]
		public override bool HasKey(string aKey)
		{
			return default(bool);
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0xF14C94", Offset = "0xF14C94", VA = "0xF14C94", Slot = "29")]
		public override JSONNode GetValueOrDefault(string aKey, JSONNode aDefault)
		{
			return null;
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0xF14DD0", Offset = "0xF14DD0", VA = "0xF14DD0", Slot = "31")]
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0xF11090", Offset = "0xF11090", VA = "0xF11090")]
		public JSONObject()
		{
		}
	}
	[Token(Token = "0x200002E")]
	public class JSONString : JSONNode
	{
		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string m_Data;

		[Token(Token = "0x1700004D")]
		public override JSONNodeType Tag
		{
			[Token(Token = "0x600012C")]
			[Address(RVA = "0xF150F0", Offset = "0xF150F0", VA = "0xF150F0", Slot = "4")]
			get
			{
				return default(JSONNodeType);
			}
		}

		[Token(Token = "0x1700004E")]
		public override bool IsString
		{
			[Token(Token = "0x600012D")]
			[Address(RVA = "0xF150F8", Offset = "0xF150F8", VA = "0xF150F8", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004F")]
		public override string Value
		{
			[Token(Token = "0x600012F")]
			[Address(RVA = "0xF15120", Offset = "0xF15120", VA = "0xF15120", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000130")]
			[Address(RVA = "0xF15128", Offset = "0xF15128", VA = "0xF15128", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0xF15100", Offset = "0xF15100", VA = "0xF15100", Slot = "32")]
		public override Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0xF11758", Offset = "0xF11758", VA = "0xF11758")]
		public JSONString(string aData)
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0xF15130", Offset = "0xF15130", VA = "0xF15130", Slot = "26")]
		public override JSONNode Clone()
		{
			return null;
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0xF15190", Offset = "0xF15190", VA = "0xF15190", Slot = "31")]
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0xF15244", Offset = "0xF15244", VA = "0xF15244", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0xF1536C", Offset = "0xF1536C", VA = "0xF1536C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0xF1538C", Offset = "0xF1538C", VA = "0xF1538C", Slot = "25")]
		public override void Clear()
		{
		}
	}
	[Token(Token = "0x200002F")]
	public class JSONNumber : JSONNode
	{
		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private double m_Data;

		[Token(Token = "0x17000050")]
		public override JSONNodeType Tag
		{
			[Token(Token = "0x6000137")]
			[Address(RVA = "0xF139D0", Offset = "0xF139D0", VA = "0xF139D0", Slot = "4")]
			get
			{
				return default(JSONNodeType);
			}
		}

		[Token(Token = "0x17000051")]
		public override bool IsNumber
		{
			[Token(Token = "0x6000138")]
			[Address(RVA = "0xF139D8", Offset = "0xF139D8", VA = "0xF139D8", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000052")]
		public override string Value
		{
			[Token(Token = "0x600013A")]
			[Address(RVA = "0xF13A00", Offset = "0xF13A00", VA = "0xF13A00", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x600013B")]
			[Address(RVA = "0xF13A74", Offset = "0xF13A74", VA = "0xF13A74", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x17000053")]
		public override double AsDouble
		{
			[Token(Token = "0x600013C")]
			[Address(RVA = "0xF13B40", Offset = "0xF13B40", VA = "0xF13B40", Slot = "33")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x600013D")]
			[Address(RVA = "0xF13B48", Offset = "0xF13B48", VA = "0xF13B48", Slot = "34")]
			set
			{
			}
		}

		[Token(Token = "0x17000054")]
		public override long AsLong
		{
			[Token(Token = "0x600013E")]
			[Address(RVA = "0xF13B50", Offset = "0xF13B50", VA = "0xF13B50", Slot = "41")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x600013F")]
			[Address(RVA = "0xF13B70", Offset = "0xF13B70", VA = "0xF13B70", Slot = "42")]
			set
			{
			}
		}

		[Token(Token = "0x17000055")]
		public override ulong AsULong
		{
			[Token(Token = "0x6000140")]
			[Address(RVA = "0xF13B7C", Offset = "0xF13B7C", VA = "0xF13B7C", Slot = "43")]
			get
			{
				return default(ulong);
			}
			[Token(Token = "0x6000141")]
			[Address(RVA = "0xF13B94", Offset = "0xF13B94", VA = "0xF13B94", Slot = "44")]
			set
			{
			}
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0xF139E0", Offset = "0xF139E0", VA = "0xF139E0", Slot = "32")]
		public override Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0xF11344", Offset = "0xF11344", VA = "0xF11344")]
		public JSONNumber(double aData)
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0xF13BA0", Offset = "0xF13BA0", VA = "0xF13BA0")]
		public JSONNumber(string aData)
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0xF13C24", Offset = "0xF13C24", VA = "0xF13C24", Slot = "26")]
		public override JSONNode Clone()
		{
			return null;
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0xF13C8C", Offset = "0xF13C8C", VA = "0xF13C8C", Slot = "31")]
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0xF13CCC", Offset = "0xF13CCC", VA = "0xF13CCC")]
		private static bool IsNumeric(object value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0xF13E70", Offset = "0xF13E70", VA = "0xF13E70", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0xF13FB0", Offset = "0xF13FB0", VA = "0xF13FB0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0xF13FBC", Offset = "0xF13FBC", VA = "0xF13FBC", Slot = "25")]
		public override void Clear()
		{
		}
	}
	[Token(Token = "0x2000030")]
	public class JSONBool : JSONNode
	{
		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool m_Data;

		[Token(Token = "0x17000056")]
		public override JSONNodeType Tag
		{
			[Token(Token = "0x600014A")]
			[Address(RVA = "0xF10A90", Offset = "0xF10A90", VA = "0xF10A90", Slot = "4")]
			get
			{
				return default(JSONNodeType);
			}
		}

		[Token(Token = "0x17000057")]
		public override bool IsBoolean
		{
			[Token(Token = "0x600014B")]
			[Address(RVA = "0xF10A98", Offset = "0xF10A98", VA = "0xF10A98", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000058")]
		public override string Value
		{
			[Token(Token = "0x600014D")]
			[Address(RVA = "0xF10AC0", Offset = "0xF10AC0", VA = "0xF10AC0", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x600014E")]
			[Address(RVA = "0xF10ACC", Offset = "0xF10ACC", VA = "0xF10ACC", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x17000059")]
		public override bool AsBool
		{
			[Token(Token = "0x600014F")]
			[Address(RVA = "0xF10B54", Offset = "0xF10B54", VA = "0xF10B54", Slot = "39")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000150")]
			[Address(RVA = "0xF10B5C", Offset = "0xF10B5C", VA = "0xF10B5C", Slot = "40")]
			set
			{
			}
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0xF10AA0", Offset = "0xF10AA0", VA = "0xF10AA0", Slot = "32")]
		public override Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0xF10B68", Offset = "0xF10B68", VA = "0xF10B68")]
		public JSONBool(bool aData)
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0xF10BE4", Offset = "0xF10BE4", VA = "0xF10BE4")]
		public JSONBool(string aData)
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0xF10C68", Offset = "0xF10C68", VA = "0xF10C68", Slot = "26")]
		public override JSONNode Clone()
		{
			return null;
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0xF10CC8", Offset = "0xF10CC8", VA = "0xF10CC8", Slot = "31")]
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0xF10D4C", Offset = "0xF10D4C", VA = "0xF10D4C", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0xF10DD0", Offset = "0xF10DD0", VA = "0xF10DD0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0xF10DDC", Offset = "0xF10DDC", VA = "0xF10DDC", Slot = "25")]
		public override void Clear()
		{
		}
	}
	[Token(Token = "0x2000031")]
	public class JSONNull : JSONNode
	{
		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static JSONNull m_StaticInstance;

		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static bool reuseSameInstance;

		[Token(Token = "0x1700005A")]
		public override JSONNodeType Tag
		{
			[Token(Token = "0x600015A")]
			[Address(RVA = "0xF13790", Offset = "0xF13790", VA = "0xF13790", Slot = "4")]
			get
			{
				return default(JSONNodeType);
			}
		}

		[Token(Token = "0x1700005B")]
		public override bool IsNull
		{
			[Token(Token = "0x600015B")]
			[Address(RVA = "0xF13798", Offset = "0xF13798", VA = "0xF13798", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005C")]
		public override string Value
		{
			[Token(Token = "0x600015D")]
			[Address(RVA = "0xF137C0", Offset = "0xF137C0", VA = "0xF137C0", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x600015E")]
			[Address(RVA = "0xF13804", Offset = "0xF13804", VA = "0xF13804", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x1700005D")]
		public override bool AsBool
		{
			[Token(Token = "0x600015F")]
			[Address(RVA = "0xF13808", Offset = "0xF13808", VA = "0xF13808", Slot = "39")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000160")]
			[Address(RVA = "0xF13810", Offset = "0xF13810", VA = "0xF13810", Slot = "40")]
			set
			{
			}
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0xF100A4", Offset = "0xF100A4", VA = "0xF100A4")]
		public static JSONNull CreateOrGet()
		{
			return null;
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0xF1372C", Offset = "0xF1372C", VA = "0xF1372C")]
		private JSONNull()
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0xF137A0", Offset = "0xF137A0", VA = "0xF137A0", Slot = "32")]
		public override Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0xF13814", Offset = "0xF13814", VA = "0xF13814", Slot = "26")]
		public override JSONNode Clone()
		{
			return null;
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0xF1386C", Offset = "0xF1386C", VA = "0xF1386C", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0xF13904", Offset = "0xF13904", VA = "0xF13904", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0xF1390C", Offset = "0xF1390C", VA = "0xF1390C", Slot = "31")]
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
		}
	}
	[Token(Token = "0x2000032")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x7C5DBC", Offset = "0x7C5DBC")]
	internal class JSONLazyCreator : JSONNode
	{
		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private JSONNode m_Node;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string m_Key;

		[Token(Token = "0x1700005E")]
		public override JSONNodeType Tag
		{
			[Token(Token = "0x6000166")]
			[Address(RVA = "0xF10DE4", Offset = "0xF10DE4", VA = "0xF10DE4", Slot = "4")]
			get
			{
				return default(JSONNodeType);
			}
		}

		[Token(Token = "0x1700005F")]
		public override JSONNode Item
		{
			[Token(Token = "0x600016B")]
			[Address(RVA = "0xF10E88", Offset = "0xF10E88", VA = "0xF10E88", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x600016C")]
			[Address(RVA = "0xF10EE4", Offset = "0xF10EE4", VA = "0xF10EE4", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x17000060")]
		public override JSONNode Item
		{
			[Token(Token = "0x600016D")]
			[Address(RVA = "0xF10F80", Offset = "0xF10F80", VA = "0xF10F80", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x600016E")]
			[Address(RVA = "0xF10FEC", Offset = "0xF10FEC", VA = "0xF10FEC", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x17000061")]
		public override int AsInt
		{
			[Token(Token = "0x6000175")]
			[Address(RVA = "0xF112C4", Offset = "0xF112C4", VA = "0xF112C4", Slot = "35")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000176")]
			[Address(RVA = "0xF113BC", Offset = "0xF113BC", VA = "0xF113BC", Slot = "36")]
			set
			{
			}
		}

		[Token(Token = "0x17000062")]
		public override float AsFloat
		{
			[Token(Token = "0x6000177")]
			[Address(RVA = "0xF11440", Offset = "0xF11440", VA = "0xF11440", Slot = "37")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000178")]
			[Address(RVA = "0xF114C0", Offset = "0xF114C0", VA = "0xF114C0", Slot = "38")]
			set
			{
			}
		}

		[Token(Token = "0x17000063")]
		public override double AsDouble
		{
			[Token(Token = "0x6000179")]
			[Address(RVA = "0xF11544", Offset = "0xF11544", VA = "0xF11544", Slot = "33")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x600017A")]
			[Address(RVA = "0xF115C4", Offset = "0xF115C4", VA = "0xF115C4", Slot = "34")]
			set
			{
			}
		}

		[Token(Token = "0x17000064")]
		public override long AsLong
		{
			[Token(Token = "0x600017B")]
			[Address(RVA = "0xF11648", Offset = "0xF11648", VA = "0xF11648", Slot = "41")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x600017C")]
			[Address(RVA = "0xF117D0", Offset = "0xF117D0", VA = "0xF117D0", Slot = "42")]
			set
			{
			}
		}

		[Token(Token = "0x17000065")]
		public override ulong AsULong
		{
			[Token(Token = "0x600017D")]
			[Address(RVA = "0xF11904", Offset = "0xF11904", VA = "0xF11904", Slot = "43")]
			get
			{
				return default(ulong);
			}
			[Token(Token = "0x600017E")]
			[Address(RVA = "0xF11A14", Offset = "0xF11A14", VA = "0xF11A14", Slot = "44")]
			set
			{
			}
		}

		[Token(Token = "0x17000066")]
		public override bool AsBool
		{
			[Token(Token = "0x600017F")]
			[Address(RVA = "0xF11B48", Offset = "0xF11B48", VA = "0xF11B48", Slot = "39")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000180")]
			[Address(RVA = "0xF11BC8", Offset = "0xF11BC8", VA = "0xF11BC8", Slot = "40")]
			set
			{
			}
		}

		[Token(Token = "0x17000067")]
		public override JSONArray AsArray
		{
			[Token(Token = "0x6000181")]
			[Address(RVA = "0xF11C4C", Offset = "0xF11C4C", VA = "0xF11C4C", Slot = "45")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000068")]
		public override JSONObject AsObject
		{
			[Token(Token = "0x6000182")]
			[Address(RVA = "0xF11CC0", Offset = "0xF11CC0", VA = "0xF11CC0", Slot = "46")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0xF10DEC", Offset = "0xF10DEC", VA = "0xF10DEC", Slot = "32")]
		public override Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0xF0FD6C", Offset = "0xF0FD6C", VA = "0xF0FD6C")]
		public JSONLazyCreator(JSONNode aNode)
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0xF10E0C", Offset = "0xF10E0C", VA = "0xF10E0C")]
		public JSONLazyCreator(JSONNode aNode, string aKey)
		{
		}

		[Token(Token = "0x600016A")]
		private T Set<T>(T aVal) where T : JSONNode
		{
			return null;
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0xF11134", Offset = "0xF11134", VA = "0xF11134", Slot = "21")]
		public override void Add(JSONNode aItem)
		{
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0xF111D0", Offset = "0xF111D0", VA = "0xF111D0", Slot = "20")]
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0xF11274", Offset = "0xF11274", VA = "0xF11274")]
		public static bool operator ==(JSONLazyCreator a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0xF1128C", Offset = "0xF1128C", VA = "0xF1128C")]
		public static bool operator !=(JSONLazyCreator a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0xF112A4", Offset = "0xF112A4", VA = "0xF112A4", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0xF112BC", Offset = "0xF112BC", VA = "0xF112BC", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0xF11D34", Offset = "0xF11D34", VA = "0xF11D34", Slot = "31")]
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
		}
	}
	[Token(Token = "0x2000033")]
	public static class JSON
	{
		[Token(Token = "0x6000184")]
		[Address(RVA = "0xF0F324", Offset = "0xF0F324", VA = "0xF0F324")]
		public static JSONNode Parse(string aJSON)
		{
			return null;
		}
	}
}
namespace UnityAsyncAwaitUtil
{
	[Token(Token = "0x2000034")]
	public class AsyncCoroutineRunner : MonoBehaviour
	{
		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static AsyncCoroutineRunner _instance;

		[Token(Token = "0x17000069")]
		public static AsyncCoroutineRunner Instance
		{
			[Token(Token = "0x6000185")]
			[Address(RVA = "0xF0C5D8", Offset = "0xF0C5D8", VA = "0xF0C5D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0xF0C6E4", Offset = "0xF0C6E4", VA = "0xF0C6E4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0xF0C77C", Offset = "0xF0C77C", VA = "0xF0C77C")]
		public AsyncCoroutineRunner()
		{
		}
	}
	[Token(Token = "0x2000035")]
	public static class SyncContextUtil
	{
		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7C5FA4", Offset = "0x7C5FA4")]
		private static int <UnityThreadId>k__BackingField;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7C5FB4", Offset = "0x7C5FB4")]
		private static SynchronizationContext <UnitySynchronizationContext>k__BackingField;

		[Token(Token = "0x1700006A")]
		public static int UnityThreadId
		{
			[Token(Token = "0x6000189")]
			[Address(RVA = "0xF15480", Offset = "0xF15480", VA = "0xF15480")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7C6A38", Offset = "0x7C6A38")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600018A")]
			[Address(RVA = "0xF154CC", Offset = "0xF154CC", VA = "0xF154CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7C6A48", Offset = "0x7C6A48")]
			private set
			{
			}
		}

		[Token(Token = "0x1700006B")]
		public static SynchronizationContext UnitySynchronizationContext
		{
			[Token(Token = "0x600018B")]
			[Address(RVA = "0xF1551C", Offset = "0xF1551C", VA = "0xF1551C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7C6A58", Offset = "0x7C6A58")]
			get
			{
				return null;
			}
			[Token(Token = "0x600018C")]
			[Address(RVA = "0xF15568", Offset = "0xF15568", VA = "0xF15568")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7C6A68", Offset = "0x7C6A68")]
			private set
			{
			}
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0xF153D8", Offset = "0xF153D8", VA = "0xF153D8")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x7C6A24", Offset = "0x7C6A24")]
		private static void Install()
		{
		}
	}
	[Token(Token = "0x2000036")]
	public class AsyncUtilTests : MonoBehaviour
	{
		[Token(Token = "0x2000037")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7C5DF4", Offset = "0x7C5DF4")]
		private sealed class <RunAsyncFromCoroutineTest>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000082")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000083")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000084")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AsyncUtilTests <>4__this;

			[Token(Token = "0x1700006C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60001AE")]
				[Address(RVA = "0xF1681C", Offset = "0xF1681C", VA = "0xF1681C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700006D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001B0")]
				[Address(RVA = "0xF16864", Offset = "0xF16864", VA = "0xF16864", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001AB")]
			[Address(RVA = "0xF0DAA8", Offset = "0xF0DAA8", VA = "0xF0DAA8")]
			[DebuggerHidden]
			public <RunAsyncFromCoroutineTest>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x60001AC")]
			[Address(RVA = "0xF16684", Offset = "0xF16684", VA = "0xF16684", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001AD")]
			[Address(RVA = "0xF16688", Offset = "0xF16688", VA = "0xF16688", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001AF")]
			[Address(RVA = "0xF16824", Offset = "0xF16824", VA = "0xF16824", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000038")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7C5E04", Offset = "0x7C5E04")]
		private struct <RunMultipleThreadsTestAsync>d__7 : IAsyncStateMachine
		{
			[Token(Token = "0x4000085")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000086")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000087")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AsyncUtilTests <>4__this;

			[Token(Token = "0x4000088")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private TaskAwaiter <>u__1;

			[Token(Token = "0x4000089")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2;

			[Token(Token = "0x400008A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private object <>u__3;

			[Token(Token = "0x60001B1")]
			[Address(RVA = "0xF17A24", Offset = "0xF17A24", VA = "0xF17A24", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60001B2")]
			[Address(RVA = "0xF18000", Offset = "0xF18000", VA = "0xF18000", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000039")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7C5E14", Offset = "0x7C5E14")]
		private struct <RunMultipleThreadsTestAsyncWait>d__8 : IAsyncStateMachine
		{
			[Token(Token = "0x400008B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x400008C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x400008D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AsyncUtilTests <>4__this;

			[Token(Token = "0x400008E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private object <>u__1;

			[Token(Token = "0x60001B3")]
			[Address(RVA = "0xF1800C", Offset = "0xF1800C", VA = "0xF1800C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60001B4")]
			[Address(RVA = "0xF18248", Offset = "0xF18248", VA = "0xF18248", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200003A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7C5E24", Offset = "0x7C5E24")]
		private struct <RunAsyncFromCoroutineTest2>d__10 : IAsyncStateMachine
		{
			[Token(Token = "0x400008F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000090")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000091")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private object <>u__1;

			[Token(Token = "0x60001B5")]
			[Address(RVA = "0xF16490", Offset = "0xF16490", VA = "0xF16490", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60001B6")]
			[Address(RVA = "0xF16678", Offset = "0xF16678", VA = "0xF16678", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200003B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7C5E34", Offset = "0x7C5E34")]
		private struct <RunWwwAsync>d__11 : IAsyncStateMachine
		{
			[Token(Token = "0x4000092")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000093")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000094")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private object <>u__1;

			[Token(Token = "0x60001B7")]
			[Address(RVA = "0xF18B74", Offset = "0xF18B74", VA = "0xF18B74", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60001B8")]
			[Address(RVA = "0xF18EA4", Offset = "0xF18EA4", VA = "0xF18EA4", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200003C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7C5E44", Offset = "0x7C5E44")]
		private struct <RunOpenNotepadTestAsync>d__12 : IAsyncStateMachine
		{
			[Token(Token = "0x4000095")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000096")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000097")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private TaskAwaiter<int> <>u__1;

			[Token(Token = "0x60001B9")]
			[Address(RVA = "0xF18254", Offset = "0xF18254", VA = "0xF18254", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60001BA")]
			[Address(RVA = "0xF18490", Offset = "0xF18490", VA = "0xF18490", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200003D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7C5E54", Offset = "0x7C5E54")]
		private struct <RunUnhandledExceptionTestAsync>d__13 : IAsyncStateMachine
		{
			[Token(Token = "0x4000098")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000099")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x400009A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AsyncUtilTests <>4__this;

			[Token(Token = "0x400009B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private TaskAwaiter <>u__1;

			[Token(Token = "0x60001BB")]
			[Address(RVA = "0xF189E4", Offset = "0xF189E4", VA = "0xF189E4", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60001BC")]
			[Address(RVA = "0xF18B68", Offset = "0xF18B68", VA = "0xF18B68", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200003E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7C5E64", Offset = "0x7C5E64")]
		private struct <RunTryCatchExceptionTestAsync>d__14 : IAsyncStateMachine
		{
			[Token(Token = "0x400009C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x400009D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x400009E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AsyncUtilTests <>4__this;

			[Token(Token = "0x400009F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private TaskAwaiter <>u__1;

			[Token(Token = "0x60001BD")]
			[Address(RVA = "0xF18710", Offset = "0xF18710", VA = "0xF18710", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60001BE")]
			[Address(RVA = "0xF189D8", Offset = "0xF189D8", VA = "0xF189D8", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200003F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7C5E74", Offset = "0x7C5E74")]
		private struct <NestedRunAsync>d__15 : IAsyncStateMachine
		{
			[Token(Token = "0x40000A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40000A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40000A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private object <>u__1;

			[Token(Token = "0x60001BF")]
			[Address(RVA = "0xF16270", Offset = "0xF16270", VA = "0xF16270", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60001C0")]
			[Address(RVA = "0xF16484", Offset = "0xF16484", VA = "0xF16484", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000040")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7C5E84", Offset = "0x7C5E84")]
		private struct <WaitThenThrowException>d__16 : IAsyncStateMachine
		{
			[Token(Token = "0x40000A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40000A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40000A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private object <>u__1;

			[Token(Token = "0x60001C1")]
			[Address(RVA = "0xF19264", Offset = "0xF19264", VA = "0xF19264", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60001C2")]
			[Address(RVA = "0xF19478", Offset = "0xF19478", VA = "0xF19478", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000041")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7C5E94", Offset = "0x7C5E94")]
		private struct <RunAsyncOperationAsync>d__17 : IAsyncStateMachine
		{
			[Token(Token = "0x40000A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40000A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40000A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AsyncUtilTests <>4__this;

			[Token(Token = "0x40000A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private TaskAwaiter <>u__1;

			[Token(Token = "0x60001C3")]
			[Address(RVA = "0xF1686C", Offset = "0xF1686C", VA = "0xF1686C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60001C4")]
			[Address(RVA = "0xF16A20", Offset = "0xF16A20", VA = "0xF16A20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000042")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7C5EA4", Offset = "0x7C5EA4")]
		private struct <InstantiateAssetBundleAsync>d__18 : IAsyncStateMachine
		{
			[Token(Token = "0x40000AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40000AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40000AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AsyncUtilTests <>4__this;

			[Token(Token = "0x40000AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string abUrl;

			[Token(Token = "0x40000AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string assetName;

			[Token(Token = "0x40000AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private AssetBundle <assetBundle>5__2;

			[Token(Token = "0x40000B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private TaskAwaiter<byte[]> <>u__1;

			[Token(Token = "0x40000B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private object <>u__2;

			[Token(Token = "0x60001C5")]
			[Address(RVA = "0xF15D10", Offset = "0xF15D10", VA = "0xF15D10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60001C6")]
			[Address(RVA = "0xF16264", Offset = "0xF16264", VA = "0xF16264", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000043")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7C5EB4", Offset = "0x7C5EB4")]
		private struct <DownloadRawDataAsync>d__19 : IAsyncStateMachine
		{
			[Token(Token = "0x40000B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40000B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<byte[]> <>t__builder;

			[Token(Token = "0x40000B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string url;

			[Token(Token = "0x40000B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UnityWebRequest <request>5__2;

			[Token(Token = "0x40000B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private object <>u__1;

			[Token(Token = "0x60001C7")]
			[Address(RVA = "0xF15788", Offset = "0xF15788", VA = "0xF15788", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60001C8")]
			[Address(RVA = "0xF159EC", Offset = "0xF159EC", VA = "0xF159EC", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000044")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7C5EC4", Offset = "0x7C5EC4")]
		private struct <RunIEnumeratorTryCatchExceptionAsync>d__20 : IAsyncStateMachine
		{
			[Token(Token = "0x40000B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40000B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40000B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AsyncUtilTests <>4__this;

			[Token(Token = "0x40000BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private object <>u__1;

			[Token(Token = "0x60001C9")]
			[Address(RVA = "0xF17200", Offset = "0xF17200", VA = "0xF17200", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60001CA")]
			[Address(RVA = "0xF17538", Offset = "0xF17538", VA = "0xF17538", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000045")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7C5ED4", Offset = "0x7C5ED4")]
		private struct <RunIEnumeratorUnhandledExceptionAsync>d__21 : IAsyncStateMachine
		{
			[Token(Token = "0x40000BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40000BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40000BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AsyncUtilTests <>4__this;

			[Token(Token = "0x40000BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private object <>u__1;

			[Token(Token = "0x60001CB")]
			[Address(RVA = "0xF17544", Offset = "0xF17544", VA = "0xF17544", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60001CC")]
			[Address(RVA = "0xF17738", Offset = "0xF17738", VA = "0xF17738", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x2000046")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7C5EE4", Offset = "0x7C5EE4")]
		private sealed class <WaitThenThrow>d__22 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40000C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40000C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AsyncUtilTests <>4__this;

			[Token(Token = "0x1700006E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60001D0")]
				[Address(RVA = "0xF19214", Offset = "0xF19214", VA = "0xF19214", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700006F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001D2")]
				[Address(RVA = "0xF1925C", Offset = "0xF1925C", VA = "0xF1925C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001CD")]
			[Address(RVA = "0xF0E334", Offset = "0xF0E334", VA = "0xF0E334")]
			[DebuggerHidden]
			public <WaitThenThrow>d__22(int <>1__state)
			{
			}

			[Token(Token = "0x60001CE")]
			[Address(RVA = "0xF191B0", Offset = "0xF191B0", VA = "0xF191B0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001CF")]
			[Address(RVA = "0xF191B4", Offset = "0xF191B4", VA = "0xF191B4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001D1")]
			[Address(RVA = "0xF1921C", Offset = "0xF1921C", VA = "0xF1921C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000047")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7C5EF4", Offset = "0x7C5EF4")]
		private sealed class <WaitThenThrowNested>d__23 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40000C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x17000070")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60001D6")]
				[Address(RVA = "0xF195AC", Offset = "0xF195AC", VA = "0xF195AC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000071")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001D8")]
				[Address(RVA = "0xF195F4", Offset = "0xF195F4", VA = "0xF195F4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001D3")]
			[Address(RVA = "0xF0E3BC", Offset = "0xF0E3BC", VA = "0xF0E3BC")]
			[DebuggerHidden]
			public <WaitThenThrowNested>d__23(int <>1__state)
			{
			}

			[Token(Token = "0x60001D4")]
			[Address(RVA = "0xF19484", Offset = "0xF19484", VA = "0xF19484", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001D5")]
			[Address(RVA = "0xF19488", Offset = "0xF19488", VA = "0xF19488", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001D7")]
			[Address(RVA = "0xF195B4", Offset = "0xF195B4", VA = "0xF195B4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000048")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7C5F04", Offset = "0x7C5F04")]
		private struct <RunIEnumeratorStringTestAsync>d__24 : IAsyncStateMachine
		{
			[Token(Token = "0x40000C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40000C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40000C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AsyncUtilTests <>4__this;

			[Token(Token = "0x40000C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private object <>u__1;

			[Token(Token = "0x60001D9")]
			[Address(RVA = "0xF16CB0", Offset = "0xF16CB0", VA = "0xF16CB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60001DA")]
			[Address(RVA = "0xF16F64", Offset = "0xF16F64", VA = "0xF16F64", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000049")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7C5F14", Offset = "0x7C5F14")]
		private struct <RunIEnumeratorUntypedStringTestAsync>d__25 : IAsyncStateMachine
		{
			[Token(Token = "0x40000C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40000C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40000CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AsyncUtilTests <>4__this;

			[Token(Token = "0x40000CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private object <>u__1;

			[Token(Token = "0x60001DB")]
			[Address(RVA = "0xF17744", Offset = "0xF17744", VA = "0xF17744", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60001DC")]
			[Address(RVA = "0xF17A18", Offset = "0xF17A18", VA = "0xF17A18", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200004A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7C5F24", Offset = "0x7C5F24")]
		private struct <RunIEnumeratorTestAsync>d__26 : IAsyncStateMachine
		{
			[Token(Token = "0x40000CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40000CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40000CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AsyncUtilTests <>4__this;

			[Token(Token = "0x40000CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private object <>u__1;

			[Token(Token = "0x60001DD")]
			[Address(RVA = "0xF16F70", Offset = "0xF16F70", VA = "0xF16F70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60001DE")]
			[Address(RVA = "0xF171F4", Offset = "0xF171F4", VA = "0xF171F4", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x200004B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7C5F34", Offset = "0x7C5F34")]
		private sealed class <WaitForString>d__27 : IEnumerator<string>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40000D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private string <>2__current;

			[Token(Token = "0x40000D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private float <startTime>5__2;

			[Token(Token = "0x17000072")]
			private string System.Collections.Generic.IEnumerator<System.String>.Current
			{
				[Token(Token = "0x60001E2")]
				[Address(RVA = "0xF19068", Offset = "0xF19068", VA = "0xF19068", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000073")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001E4")]
				[Address(RVA = "0xF190B0", Offset = "0xF190B0", VA = "0xF190B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001DF")]
			[Address(RVA = "0xF0E444", Offset = "0xF0E444", VA = "0xF0E444")]
			[DebuggerHidden]
			public <WaitForString>d__27(int <>1__state)
			{
			}

			[Token(Token = "0x60001E0")]
			[Address(RVA = "0xF18F94", Offset = "0xF18F94", VA = "0xF18F94", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001E1")]
			[Address(RVA = "0xF18F98", Offset = "0xF18F98", VA = "0xF18F98", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001E3")]
			[Address(RVA = "0xF19070", Offset = "0xF19070", VA = "0xF19070", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200004C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7C5F44", Offset = "0x7C5F44")]
		private sealed class <WaitForStringUntyped>d__28 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40000D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40000D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AsyncUtilTests <>4__this;

			[Token(Token = "0x17000074")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60001E8")]
				[Address(RVA = "0xF19160", Offset = "0xF19160", VA = "0xF19160", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000075")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001EA")]
				[Address(RVA = "0xF191A8", Offset = "0xF191A8", VA = "0xF191A8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001E5")]
			[Address(RVA = "0xF0E4DC", Offset = "0xF0E4DC", VA = "0xF0E4DC")]
			[DebuggerHidden]
			public <WaitForStringUntyped>d__28(int <>1__state)
			{
			}

			[Token(Token = "0x60001E6")]
			[Address(RVA = "0xF190B8", Offset = "0xF190B8", VA = "0xF190B8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001E7")]
			[Address(RVA = "0xF190BC", Offset = "0xF190BC", VA = "0xF190BC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001E9")]
			[Address(RVA = "0xF19168", Offset = "0xF19168", VA = "0xF19168", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200004D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7C5F54", Offset = "0x7C5F54")]
		private sealed class <WaitABit>d__29 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40000D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x17000076")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60001EE")]
				[Address(RVA = "0xF18F44", Offset = "0xF18F44", VA = "0xF18F44", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000077")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001F0")]
				[Address(RVA = "0xF18F8C", Offset = "0xF18F8C", VA = "0xF18F8C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001EB")]
			[Address(RVA = "0xF0E564", Offset = "0xF0E564", VA = "0xF0E564")]
			[DebuggerHidden]
			public <WaitABit>d__29(int <>1__state)
			{
			}

			[Token(Token = "0x60001EC")]
			[Address(RVA = "0xF18EB0", Offset = "0xF18EB0", VA = "0xF18EB0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001ED")]
			[Address(RVA = "0xF18EB4", Offset = "0xF18EB4", VA = "0xF18EB4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001EF")]
			[Address(RVA = "0xF18F4C", Offset = "0xF18F4C", VA = "0xF18F4C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200004E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7C5F64", Offset = "0x7C5F64")]
		private struct <RunReturnValueTestAsync>d__30 : IAsyncStateMachine
		{
			[Token(Token = "0x40000D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40000D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40000DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AsyncUtilTests <>4__this;

			[Token(Token = "0x40000DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private TaskAwaiter<string> <>u__1;

			[Token(Token = "0x60001F1")]
			[Address(RVA = "0xF1849C", Offset = "0xF1849C", VA = "0xF1849C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60001F2")]
			[Address(RVA = "0xF18704", Offset = "0xF18704", VA = "0xF18704", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200004F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7C5F74", Offset = "0x7C5F74")]
		private struct <GetValueExampleAsync>d__31 : IAsyncStateMachine
		{
			[Token(Token = "0x40000DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40000DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<string> <>t__builder;

			[Token(Token = "0x40000DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private object <>u__1;

			[Token(Token = "0x60001F3")]
			[Address(RVA = "0xF15A48", Offset = "0xF15A48", VA = "0xF15A48", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60001F4")]
			[Address(RVA = "0xF15CB4", Offset = "0xF15CB4", VA = "0xF15CB4", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000050")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7C5F84", Offset = "0x7C5F84")]
		private struct <RunAwaitSecondsTestAsync>d__32 : IAsyncStateMachine
		{
			[Token(Token = "0x40000DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40000E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40000E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private object <>u__1;

			[Token(Token = "0x60001F5")]
			[Address(RVA = "0xF16A2C", Offset = "0xF16A2C", VA = "0xF16A2C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60001F6")]
			[Address(RVA = "0xF16CA4", Offset = "0xF16CA4", VA = "0xF16CA4", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400007E")]
		private const string AssetBundleSampleUrl = "http://www.stevevermeulen.com/wp-content/uploads/2017/09/teapot.unity3d";

		[Token(Token = "0x400007F")]
		private const string AssetBundleSampleAssetName = "Teapot";

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TestButtonHandler.Settings _buttonSettings;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TestButtonHandler _buttonHandler;

		[Token(Token = "0x600018D")]
		[Address(RVA = "0xF0C784", Offset = "0xF0C784", VA = "0xF0C784")]
		public void Awake()
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0xF0C81C", Offset = "0xF0C81C", VA = "0xF0C81C")]
		public void OnGUI()
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0xF0D934", Offset = "0xF0D934", VA = "0xF0D934")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7C6A78", Offset = "0x7C6A78")]
		private IEnumerator RunAsyncFromCoroutineTest()
		{
			return null;
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0xF0D9A0", Offset = "0xF0D9A0", VA = "0xF0D9A0")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x7C6AD8", Offset = "0x7C6AD8")]
		private Task RunMultipleThreadsTestAsync()
		{
			return null;
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0xF0DAD4", Offset = "0xF0DAD4", VA = "0xF0DAD4")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x7C6B38", Offset = "0x7C6B38")]
		private Task RunMultipleThreadsTestAsyncWait()
		{
			return null;
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0xF0DBD8", Offset = "0xF0DBD8", VA = "0xF0DBD8")]
		private void PrintCurrentThreadContext([Optional] string prefix)
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0xF0DD58", Offset = "0xF0DD58", VA = "0xF0DD58")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x7C6B98", Offset = "0x7C6B98")]
		private Task RunAsyncFromCoroutineTest2()
		{
			return null;
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0xF0D830", Offset = "0xF0D830", VA = "0xF0D830")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x7C6BF8", Offset = "0x7C6BF8")]
		private Task RunWwwAsync()
		{
			return null;
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0xF0D72C", Offset = "0xF0D72C", VA = "0xF0D72C")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x7C6C58", Offset = "0x7C6C58")]
		private Task RunOpenNotepadTestAsync()
		{
			return null;
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0xF0D010", Offset = "0xF0D010", VA = "0xF0D010")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x7C6CB8", Offset = "0x7C6CB8")]
		private Task RunUnhandledExceptionTestAsync()
		{
			return null;
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0xF0CF0C", Offset = "0xF0CF0C", VA = "0xF0CF0C")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x7C6D18", Offset = "0x7C6D18")]
		private Task RunTryCatchExceptionTestAsync()
		{
			return null;
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0xF0DE5C", Offset = "0xF0DE5C", VA = "0xF0DE5C")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x7C6D78", Offset = "0x7C6D78")]
		private Task NestedRunAsync()
		{
			return null;
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0xF0DF60", Offset = "0xF0DF60", VA = "0xF0DF60")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x7C6DD8", Offset = "0x7C6DD8")]
		private Task WaitThenThrowException()
		{
			return null;
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0xF0D628", Offset = "0xF0D628", VA = "0xF0D628")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x7C6E38", Offset = "0x7C6E38")]
		private Task RunAsyncOperationAsync()
		{
			return null;
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0xF0E064", Offset = "0xF0E064", VA = "0xF0E064")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x7C6E98", Offset = "0x7C6E98")]
		private Task InstantiateAssetBundleAsync(string abUrl, string assetName)
		{
			return null;
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0xF0E188", Offset = "0xF0E188", VA = "0xF0E188")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x7C6EF8", Offset = "0x7C6EF8")]
		private Task<byte[]> DownloadRawDataAsync(string url)
		{
			return null;
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0xF0D524", Offset = "0xF0D524", VA = "0xF0D524")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x7C6F58", Offset = "0x7C6F58")]
		private Task RunIEnumeratorTryCatchExceptionAsync()
		{
			return null;
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0xF0D420", Offset = "0xF0D420", VA = "0xF0D420")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x7C6FB8", Offset = "0x7C6FB8")]
		private Task RunIEnumeratorUnhandledExceptionAsync()
		{
			return null;
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0xF0E2C8", Offset = "0xF0E2C8", VA = "0xF0E2C8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7C7018", Offset = "0x7C7018")]
		private IEnumerator WaitThenThrow()
		{
			return null;
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0xF0E360", Offset = "0xF0E360", VA = "0xF0E360")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7C7078", Offset = "0x7C7078")]
		private IEnumerator WaitThenThrowNested()
		{
			return null;
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0xF0D31C", Offset = "0xF0D31C", VA = "0xF0D31C")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x7C70D8", Offset = "0x7C70D8")]
		private Task RunIEnumeratorStringTestAsync()
		{
			return null;
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0xF0D218", Offset = "0xF0D218", VA = "0xF0D218")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x7C7138", Offset = "0x7C7138")]
		private Task RunIEnumeratorUntypedStringTestAsync()
		{
			return null;
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0xF0D114", Offset = "0xF0D114", VA = "0xF0D114")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x7C7198", Offset = "0x7C7198")]
		private Task RunIEnumeratorTestAsync()
		{
			return null;
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0xF0E3E8", Offset = "0xF0E3E8", VA = "0xF0E3E8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7C71F8", Offset = "0x7C71F8")]
		private IEnumerator<string> WaitForString()
		{
			return null;
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0xF0E470", Offset = "0xF0E470", VA = "0xF0E470")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7C7258", Offset = "0x7C7258")]
		private IEnumerator WaitForStringUntyped()
		{
			return null;
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0xF0E508", Offset = "0xF0E508", VA = "0xF0E508")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7C72B8", Offset = "0x7C72B8")]
		private IEnumerator WaitABit()
		{
			return null;
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0xF0CE08", Offset = "0xF0CE08", VA = "0xF0CE08")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x7C7318", Offset = "0x7C7318")]
		private Task RunReturnValueTestAsync()
		{
			return null;
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0xF0E590", Offset = "0xF0E590", VA = "0xF0E590")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x7C7378", Offset = "0x7C7378")]
		private Task<string> GetValueExampleAsync()
		{
			return null;
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0xF0CC40", Offset = "0xF0CC40", VA = "0xF0CC40")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x7C73D8", Offset = "0x7C73D8")]
		private Task RunAwaitSecondsTestAsync()
		{
			return null;
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0xF0E6B0", Offset = "0xF0E6B0", VA = "0xF0E6B0")]
		public AsyncUtilTests()
		{
		}
	}
	[Token(Token = "0x2000051")]
	public class TestButtonHandler
	{
		[Serializable]
		[Token(Token = "0x2000052")]
		public class Settings
		{
			[Token(Token = "0x40000E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int NumPerColumn;

			[Token(Token = "0x40000E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float VerticalMargin;

			[Token(Token = "0x40000E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float VerticalSpacing;

			[Token(Token = "0x40000E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float HorizontalSpacing;

			[Token(Token = "0x40000E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float HorizontalMargin;

			[Token(Token = "0x40000EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public float ButtonWidth;

			[Token(Token = "0x40000EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float ButtonHeight;

			[Token(Token = "0x60001FA")]
			[Address(RVA = "0xF1B210", Offset = "0xF1B210", VA = "0xF1B210")]
			public Settings()
			{
			}
		}

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Settings _settings;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int _buttonVCount;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private int _buttonHCount;

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0xF0C7F0", Offset = "0xF0C7F0", VA = "0xF0C7F0")]
		public TestButtonHandler(Settings settings)
		{
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0xF0CB3C", Offset = "0xF0CB3C", VA = "0xF0CB3C")]
		public void Restart()
		{
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0xF0CB44", Offset = "0xF0CB44", VA = "0xF0CB44")]
		public bool Display(string text)
		{
			return default(bool);
		}
	}
}
