using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Security;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Networking;
using UnityEngine.UI;

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
		[Address(RVA = "0xE41A64", Offset = "0xE41A64", VA = "0xE41A64")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000002")]
	public static WaitForFixedUpdate FixedUpdate
	{
		[Token(Token = "0x6000002")]
		[Address(RVA = "0xE41ACC", Offset = "0xE41ACC", VA = "0xE41ACC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000003")]
	public static WaitForEndOfFrame EndOfFrame
	{
		[Token(Token = "0x6000003")]
		[Address(RVA = "0xE41B34", Offset = "0xE41B34", VA = "0xE41B34")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0xE41B9C", Offset = "0xE41B9C", VA = "0xE41B9C")]
	public static WaitForSeconds Seconds(float seconds)
	{
		return null;
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0xE41C08", Offset = "0xE41C08", VA = "0xE41C08")]
	public static WaitForSecondsRealtime SecondsRealtime(float seconds)
	{
		return null;
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0xE41C74", Offset = "0xE41C74", VA = "0xE41C74")]
	public static WaitUntil Until(Func<bool> predicate)
	{
		return null;
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0xE41CD8", Offset = "0xE41CD8", VA = "0xE41CD8")]
	public static WaitWhile While(Func<bool> predicate)
	{
		return null;
	}
}
[Token(Token = "0x2000003")]
public static class AwaitExtensions
{
	[Token(Token = "0x2000051")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x993B84", Offset = "0x993B84")]
	private sealed class <>c__DisplayClass0_0
	{
		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public TaskCompletionSource<int> tcs;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Process process;

		[Token(Token = "0x6000297")]
		[Address(RVA = "0xE41774", Offset = "0xE41774", VA = "0xE41774")]
		public <>c__DisplayClass0_0()
		{
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0xE41860", Offset = "0xE41860", VA = "0xE41860")]
		internal void <GetAwaiter>b__0(object s, EventArgs e)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x2000052")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x993B94", Offset = "0x993B94")]
	private struct <WrapErrors>d__1 : IAsyncStateMachine
	{
		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Task task;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TaskAwaiter <>u__1;

		[Token(Token = "0x6000299")]
		[Address(RVA = "0xA54CB4", Offset = "0xA54CB4", VA = "0xA54CB4", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0xA54CBC", Offset = "0xA54CBC", VA = "0xA54CBC", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0xE415F8", Offset = "0xE415F8", VA = "0xE415F8")]
	public static TaskAwaiter<int> GetAwaiter(this Process process)
	{
		return default(TaskAwaiter<int>);
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0xE4177C", Offset = "0xE4177C", VA = "0xE4177C")]
	[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x994B78", Offset = "0x994B78")]
	public static void WrapErrors(this Task task)
	{
	}
}
[Token(Token = "0x2000004")]
public static class IEnumeratorAwaitExtensions
{
	[Token(Token = "0x2000053")]
	public class SimpleCoroutineAwaiter<T> : INotifyCompletion
	{
		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool _isDone;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Exception _exception;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Action _continuation;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T _result;

		[Token(Token = "0x17000026")]
		public bool IsCompleted
		{
			[Token(Token = "0x600029B")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600029C")]
		public T GetResult()
		{
			return (T)null;
		}

		[Token(Token = "0x600029D")]
		public void Complete(T result, Exception e)
		{
		}

		[Token(Token = "0x600029E")]
		private void System.Runtime.CompilerServices.INotifyCompletion.OnCompleted(Action continuation)
		{
		}

		[Token(Token = "0x600029F")]
		public SimpleCoroutineAwaiter()
		{
		}
	}

	[Token(Token = "0x2000054")]
	public class SimpleCoroutineAwaiter : INotifyCompletion
	{
		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool _isDone;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Exception _exception;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Action _continuation;

		[Token(Token = "0x17000027")]
		public bool IsCompleted
		{
			[Token(Token = "0x60002A0")]
			[Address(RVA = "0xE430EC", Offset = "0xE430EC", VA = "0xE430EC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0xE430F4", Offset = "0xE430F4", VA = "0xE430F4")]
		public void GetResult()
		{
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0xE4301C", Offset = "0xE4301C", VA = "0xE4301C")]
		public void Complete(Exception e)
		{
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0xE43140", Offset = "0xE43140", VA = "0xE43140", Slot = "4")]
		private void System.Runtime.CompilerServices.INotifyCompletion.OnCompleted(Action continuation)
		{
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0xE42648", Offset = "0xE42648", VA = "0xE42648")]
		public SimpleCoroutineAwaiter()
		{
		}
	}

	[Token(Token = "0x2000055")]
	private class CoroutineWrapper<T>
	{
		[Token(Token = "0x20000A8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x993F34", Offset = "0x993F34")]
		private sealed class <Run>d__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000304")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <>1__state;

			[Token(Token = "0x4000305")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private object <>2__current;

			[Token(Token = "0x4000306")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public CoroutineWrapper<T> <>4__this;

			[Token(Token = "0x17000069")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60003BF")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700006A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60003C1")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003BC")]
			[DebuggerHidden]
			public <Run>d__3(int <>1__state)
			{
			}

			[Token(Token = "0x60003BD")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60003BE")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003C0")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly SimpleCoroutineAwaiter<T> _awaiter;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly Stack<IEnumerator> _processStack;

		[Token(Token = "0x60002A5")]
		public CoroutineWrapper(IEnumerator coroutine, SimpleCoroutineAwaiter<T> awaiter)
		{
		}

		[Token(Token = "0x60002A6")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x996728", Offset = "0x996728")]
		public IEnumerator Run()
		{
			return null;
		}

		[Token(Token = "0x60002A7")]
		private string GenerateObjectTraceMessage(List<Type> objTrace)
		{
			return null;
		}

		[Token(Token = "0x60002A8")]
		private static List<Type> GenerateObjectTrace(IEnumerable<IEnumerator> enumerators)
		{
			return null;
		}
	}

	[Token(Token = "0x2000056")]
	private static class InstructionWrappers
	{
		[Token(Token = "0x20000A9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x993F44", Offset = "0x993F44")]
		private sealed class <ReturnVoid>d__0 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000307")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000308")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000309")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object instruction;

			[Token(Token = "0x400030A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public SimpleCoroutineAwaiter awaiter;

			[Token(Token = "0x1700006B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60003C5")]
				[Address(RVA = "0xE43078", Offset = "0xE43078", VA = "0xE43078", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700006C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60003C7")]
				[Address(RVA = "0xE430E4", Offset = "0xE430E4", VA = "0xE430E4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003C2")]
			[Address(RVA = "0xE42B50", Offset = "0xE42B50", VA = "0xE42B50")]
			[DebuggerHidden]
			public <ReturnVoid>d__0(int <>1__state)
			{
			}

			[Token(Token = "0x60003C3")]
			[Address(RVA = "0xE42FA8", Offset = "0xE42FA8", VA = "0xE42FA8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60003C4")]
			[Address(RVA = "0xE42FAC", Offset = "0xE42FAC", VA = "0xE42FAC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003C6")]
			[Address(RVA = "0xE43080", Offset = "0xE43080", VA = "0xE43080", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000AA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x993F54", Offset = "0x993F54")]
		private sealed class <AssetBundleCreateRequest>d__1 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400030B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400030C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400030D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AssetBundleCreateRequest instruction;

			[Token(Token = "0x400030E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public SimpleCoroutineAwaiter<AssetBundle> awaiter;

			[Token(Token = "0x1700006D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60003CB")]
				[Address(RVA = "0xE42CC4", Offset = "0xE42CC4", VA = "0xE42CC4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700006E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60003CD")]
				[Address(RVA = "0xE42D30", Offset = "0xE42D30", VA = "0xE42D30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003C8")]
			[Address(RVA = "0xE42B7C", Offset = "0xE42B7C", VA = "0xE42B7C")]
			[DebuggerHidden]
			public <AssetBundleCreateRequest>d__1(int <>1__state)
			{
			}

			[Token(Token = "0x60003C9")]
			[Address(RVA = "0xE42C00", Offset = "0xE42C00", VA = "0xE42C00", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60003CA")]
			[Address(RVA = "0xE42C04", Offset = "0xE42C04", VA = "0xE42C04", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003CC")]
			[Address(RVA = "0xE42CCC", Offset = "0xE42CCC", VA = "0xE42CCC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000AB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x993F64", Offset = "0x993F64")]
		private sealed class <ReturnSelf>d__2<T> : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400030F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <>1__state;

			[Token(Token = "0x4000310")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private object <>2__current;

			[Token(Token = "0x4000311")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public T instruction;

			[Token(Token = "0x4000312")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public SimpleCoroutineAwaiter<T> awaiter;

			[Token(Token = "0x1700006F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60003D1")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000070")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60003D3")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003CE")]
			[DebuggerHidden]
			public <ReturnSelf>d__2(int <>1__state)
			{
			}

			[Token(Token = "0x60003CF")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60003D0")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003D2")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000AC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x993F74", Offset = "0x993F74")]
		private sealed class <AssetBundleRequest>d__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000313")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000314")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000315")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AssetBundleRequest instruction;

			[Token(Token = "0x4000316")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public SimpleCoroutineAwaiter<UnityEngine.Object> awaiter;

			[Token(Token = "0x17000071")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60003D7")]
				[Address(RVA = "0xE42DFC", Offset = "0xE42DFC", VA = "0xE42DFC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000072")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60003D9")]
				[Address(RVA = "0xE42E68", Offset = "0xE42E68", VA = "0xE42E68", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003D4")]
			[Address(RVA = "0xE42BA8", Offset = "0xE42BA8", VA = "0xE42BA8")]
			[DebuggerHidden]
			public <AssetBundleRequest>d__3(int <>1__state)
			{
			}

			[Token(Token = "0x60003D5")]
			[Address(RVA = "0xE42D38", Offset = "0xE42D38", VA = "0xE42D38", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60003D6")]
			[Address(RVA = "0xE42D3C", Offset = "0xE42D3C", VA = "0xE42D3C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003D8")]
			[Address(RVA = "0xE42E04", Offset = "0xE42E04", VA = "0xE42E04", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000AD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x993F84", Offset = "0x993F84")]
		private sealed class <ResourceRequest>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000317")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000318")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000319")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ResourceRequest instruction;

			[Token(Token = "0x400031A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public SimpleCoroutineAwaiter<UnityEngine.Object> awaiter;

			[Token(Token = "0x17000073")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60003DD")]
				[Address(RVA = "0xE42F34", Offset = "0xE42F34", VA = "0xE42F34", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000074")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60003DF")]
				[Address(RVA = "0xE42FA0", Offset = "0xE42FA0", VA = "0xE42FA0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003DA")]
			[Address(RVA = "0xE42BD4", Offset = "0xE42BD4", VA = "0xE42BD4")]
			[DebuggerHidden]
			public <ResourceRequest>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x60003DB")]
			[Address(RVA = "0xE42E70", Offset = "0xE42E70", VA = "0xE42E70", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60003DC")]
			[Address(RVA = "0xE42E74", Offset = "0xE42E74", VA = "0xE42E74", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003DE")]
			[Address(RVA = "0xE42F3C", Offset = "0xE42F3C", VA = "0xE42F3C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0xE429B0", Offset = "0xE429B0", VA = "0xE429B0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x99678C", Offset = "0x99678C")]
		public static IEnumerator ReturnVoid(SimpleCoroutineAwaiter awaiter, object instruction)
		{
			return null;
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0xE42728", Offset = "0xE42728", VA = "0xE42728")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9967F0", Offset = "0x9967F0")]
		public static IEnumerator AssetBundleCreateRequest(SimpleCoroutineAwaiter<AssetBundle> awaiter, AssetBundleCreateRequest instruction)
		{
			return null;
		}

		[Token(Token = "0x60002AB")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x996854", Offset = "0x996854")]
		public static IEnumerator ReturnSelf<T>(SimpleCoroutineAwaiter<T> awaiter, T instruction)
		{
			return null;
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0xE42810", Offset = "0xE42810", VA = "0xE42810")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9968B8", Offset = "0x9968B8")]
		public static IEnumerator AssetBundleRequest(SimpleCoroutineAwaiter<UnityEngine.Object> awaiter, AssetBundleRequest instruction)
		{
			return null;
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0xE42AB4", Offset = "0xE42AB4", VA = "0xE42AB4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x99691C", Offset = "0x99691C")]
		public static IEnumerator ResourceRequest(SimpleCoroutineAwaiter<UnityEngine.Object> awaiter, ResourceRequest instruction)
		{
			return null;
		}
	}

	[Token(Token = "0x2000057")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x993BA4", Offset = "0x993BA4")]
	private sealed class <>c__DisplayClass8_0
	{
		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SimpleCoroutineAwaiter<UnityEngine.Object> awaiter;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ResourceRequest instruction;

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0xE421DC", Offset = "0xE421DC", VA = "0xE421DC")]
		public <>c__DisplayClass8_0()
		{
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0xE42A68", Offset = "0xE42A68", VA = "0xE42A68")]
		internal void <GetAwaiter>b__0()
		{
		}
	}

	[Token(Token = "0x2000058")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x993BB4", Offset = "0x993BB4")]
	private sealed class <>c__DisplayClass10_0
	{
		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SimpleCoroutineAwaiter<AssetBundle> awaiter;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AssetBundleCreateRequest instruction;

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0xE42454", Offset = "0xE42454", VA = "0xE42454")]
		public <>c__DisplayClass10_0()
		{
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0xE426DC", Offset = "0xE426DC", VA = "0xE426DC")]
		internal void <GetAwaiter>b__0()
		{
		}
	}

	[Token(Token = "0x2000059")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x993BC4", Offset = "0x993BC4")]
	private sealed class <>c__DisplayClass11_0
	{
		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SimpleCoroutineAwaiter<UnityEngine.Object> awaiter;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AssetBundleRequest instruction;

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0xE4254C", Offset = "0xE4254C", VA = "0xE4254C")]
		public <>c__DisplayClass11_0()
		{
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0xE427C4", Offset = "0xE427C4", VA = "0xE427C4")]
		internal void <GetAwaiter>b__0()
		{
		}
	}

	[Token(Token = "0x200005A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x993BD4", Offset = "0x993BD4")]
	private sealed class <>c__DisplayClass12_0<T>
	{
		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IEnumerator<T> coroutine;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public SimpleCoroutineAwaiter<T> awaiter;

		[Token(Token = "0x60002B4")]
		public <>c__DisplayClass12_0()
		{
		}

		[Token(Token = "0x60002B5")]
		internal void <GetAwaiter>b__0()
		{
		}
	}

	[Token(Token = "0x200005B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x993BE4", Offset = "0x993BE4")]
	private sealed class <>c__DisplayClass13_0
	{
		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IEnumerator coroutine;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SimpleCoroutineAwaiter<object> awaiter;

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0xE42638", Offset = "0xE42638", VA = "0xE42638")]
		public <>c__DisplayClass13_0()
		{
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0xE428AC", Offset = "0xE428AC", VA = "0xE428AC")]
		internal void <GetAwaiter>b__0()
		{
		}
	}

	[Token(Token = "0x200005C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x993BF4", Offset = "0x993BF4")]
	private sealed class <>c__DisplayClass14_0
	{
		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SimpleCoroutineAwaiter awaiter;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public object instruction;

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0xE42640", Offset = "0xE42640", VA = "0xE42640")]
		public <>c__DisplayClass14_0()
		{
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0xE42964", Offset = "0xE42964", VA = "0xE42964")]
		internal void <GetAwaiterReturnVoid>b__0()
		{
		}
	}

	[Token(Token = "0x200005D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x993C04", Offset = "0x993C04")]
	private sealed class <>c__DisplayClass15_0<T>
	{
		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public SimpleCoroutineAwaiter<T> awaiter;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T instruction;

		[Token(Token = "0x60002BA")]
		public <>c__DisplayClass15_0()
		{
		}

		[Token(Token = "0x60002BB")]
		internal void <GetAwaiterReturnSelf>b__0()
		{
		}
	}

	[Token(Token = "0x200005E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x993C14", Offset = "0x993C14")]
	private sealed class <>c__DisplayClass16_0
	{
		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Action action;

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0xE42650", Offset = "0xE42650", VA = "0xE42650")]
		public <>c__DisplayClass16_0()
		{
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0xE42A4C", Offset = "0xE42A4C", VA = "0xE42A4C")]
		internal void <RunOnUnityScheduler>b__0(object _)
		{
		}
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0xE41F98", Offset = "0xE41F98", VA = "0xE41F98")]
	public static SimpleCoroutineAwaiter GetAwaiter(this WaitForSeconds instruction)
	{
		return null;
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0xE42084", Offset = "0xE42084", VA = "0xE42084")]
	public static SimpleCoroutineAwaiter GetAwaiter(this WaitForUpdate instruction)
	{
		return null;
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0xE42088", Offset = "0xE42088", VA = "0xE42088")]
	public static SimpleCoroutineAwaiter GetAwaiter(this WaitForEndOfFrame instruction)
	{
		return null;
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0xE4208C", Offset = "0xE4208C", VA = "0xE4208C")]
	public static SimpleCoroutineAwaiter GetAwaiter(this WaitForFixedUpdate instruction)
	{
		return null;
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0xE42090", Offset = "0xE42090", VA = "0xE42090")]
	public static SimpleCoroutineAwaiter GetAwaiter(this WaitForSecondsRealtime instruction)
	{
		return null;
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0xE42094", Offset = "0xE42094", VA = "0xE42094")]
	public static SimpleCoroutineAwaiter GetAwaiter(this WaitUntil instruction)
	{
		return null;
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0xE42098", Offset = "0xE42098", VA = "0xE42098")]
	public static SimpleCoroutineAwaiter GetAwaiter(this WaitWhile instruction)
	{
		return null;
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0xE4209C", Offset = "0xE4209C", VA = "0xE4209C")]
	public static SimpleCoroutineAwaiter<AsyncOperation> GetAwaiter(this AsyncOperation instruction)
	{
		return null;
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0xE420EC", Offset = "0xE420EC", VA = "0xE420EC")]
	public static SimpleCoroutineAwaiter<UnityEngine.Object> GetAwaiter(this ResourceRequest instruction)
	{
		return null;
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0xE42314", Offset = "0xE42314", VA = "0xE42314")]
	public static SimpleCoroutineAwaiter<WWW> GetAwaiter(this WWW instruction)
	{
		return null;
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0xE42364", Offset = "0xE42364", VA = "0xE42364")]
	public static SimpleCoroutineAwaiter<AssetBundle> GetAwaiter(this AssetBundleCreateRequest instruction)
	{
		return null;
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0xE4245C", Offset = "0xE4245C", VA = "0xE4245C")]
	public static SimpleCoroutineAwaiter<UnityEngine.Object> GetAwaiter(this AssetBundleRequest instruction)
	{
		return null;
	}

	[Token(Token = "0x6000017")]
	public static SimpleCoroutineAwaiter<T> GetAwaiter<T>(this IEnumerator<T> coroutine)
	{
		return null;
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0xE42554", Offset = "0xE42554", VA = "0xE42554")]
	public static SimpleCoroutineAwaiter<object> GetAwaiter(this IEnumerator coroutine)
	{
		return null;
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0xE41F9C", Offset = "0xE41F9C", VA = "0xE41F9C")]
	private static SimpleCoroutineAwaiter GetAwaiterReturnVoid(object instruction)
	{
		return null;
	}

	[Token(Token = "0x600001A")]
	private static SimpleCoroutineAwaiter<T> GetAwaiterReturnSelf<T>(T instruction)
	{
		return null;
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0xE421E4", Offset = "0xE421E4", VA = "0xE421E4")]
	private static void RunOnUnityScheduler(Action action)
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0xE42658", Offset = "0xE42658", VA = "0xE42658")]
	private static void Assert(bool condition)
	{
	}
}
[Token(Token = "0x2000005")]
public static class TaskExtensions
{
	[Token(Token = "0x200005F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x993C24", Offset = "0x993C24")]
	private sealed class <AsIEnumerator>d__0 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Task task;

		[Token(Token = "0x17000028")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002C1")]
			[Address(RVA = "0x120BD28", Offset = "0x120BD28", VA = "0x120BD28", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000029")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002C3")]
			[Address(RVA = "0x120BD94", Offset = "0x120BD94", VA = "0x120BD94", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x120BC58", Offset = "0x120BC58", VA = "0x120BC58")]
		[DebuggerHidden]
		public <AsIEnumerator>d__0(int <>1__state)
		{
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x120BC84", Offset = "0x120BC84", VA = "0x120BC84", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x120BC88", Offset = "0x120BC88", VA = "0x120BC88", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x120BD30", Offset = "0x120BD30", VA = "0x120BD30", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000060")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x993C34", Offset = "0x993C34")]
	private sealed class <AsIEnumerator>d__1<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
	{
		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <>1__state;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T <>2__current;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Task<T> task;

		[Token(Token = "0x1700002A")]
		private T System.Collections.Generic.IEnumerator<T>.Current
		{
			[Token(Token = "0x60002C7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002C9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002C4")]
		[DebuggerHidden]
		public <AsIEnumerator>d__1(int <>1__state)
		{
		}

		[Token(Token = "0x60002C5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002C6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002C8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x120BBD8", Offset = "0x120BBD8", VA = "0x120BBD8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x994CCC", Offset = "0x994CCC")]
	public static IEnumerator AsIEnumerator(this Task task)
	{
		return null;
	}

	[Token(Token = "0x600001E")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x994D40", Offset = "0x994D40")]
	public static IEnumerator<T> AsIEnumerator<T>(this Task<T> task) where T : class
	{
		return null;
	}
}
[Token(Token = "0x2000006")]
public class WaitForBackgroundThread
{
	[Serializable]
	[Token(Token = "0x2000061")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x993C44", Offset = "0x993C44")]
	private sealed class <>c
	{
		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Action <>9__0_0;

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x121E768", Offset = "0x121E768", VA = "0x121E768")]
		public <>c()
		{
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x121E770", Offset = "0x121E770", VA = "0x121E770")]
		internal void <GetAwaiter>b__0_0()
		{
		}
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x121048C", Offset = "0x121048C", VA = "0x121048C")]
	public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter GetAwaiter()
	{
		return default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x1210484", Offset = "0x1210484", VA = "0x1210484")]
	public WaitForBackgroundThread()
	{
	}
}
[Token(Token = "0x2000007")]
public class WaitForUpdate : CustomYieldInstruction
{
	[Token(Token = "0x17000004")]
	public override bool keepWaiting
	{
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x121E774", Offset = "0x121E774", VA = "0x121E774", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x121059C", Offset = "0x121059C", VA = "0x121059C")]
	public WaitForUpdate()
	{
	}
}
[Token(Token = "0x2000008")]
public static class MECExtensionMethods2
{
	[Token(Token = "0x2000062")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x993C54", Offset = "0x993C54")]
	private sealed class <CancelWith>d__0 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject gameObject;

		[Token(Token = "0x1700002C")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x60002D0")]
			[Address(RVA = "0x120B458", Offset = "0x120B458", VA = "0x120B458", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700002D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002D2")]
			[Address(RVA = "0x120B4C4", Offset = "0x120B4C4", VA = "0x120B4C4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x120B030", Offset = "0x120B030", VA = "0x120B030")]
		[DebuggerHidden]
		public <CancelWith>d__0(int <>1__state)
		{
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x120B230", Offset = "0x120B230", VA = "0x120B230", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x120B234", Offset = "0x120B234", VA = "0x120B234", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x120B460", Offset = "0x120B460", VA = "0x120B460", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000063")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x993C64", Offset = "0x993C64")]
	private sealed class <CancelWith>d__1 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject gameObject1;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject gameObject2;

		[Token(Token = "0x1700002E")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x60002D6")]
			[Address(RVA = "0x120B790", Offset = "0x120B790", VA = "0x120B790", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700002F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002D8")]
			[Address(RVA = "0x120B7FC", Offset = "0x120B7FC", VA = "0x120B7FC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x120B10C", Offset = "0x120B10C", VA = "0x120B10C")]
		[DebuggerHidden]
		public <CancelWith>d__1(int <>1__state)
		{
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x120B528", Offset = "0x120B528", VA = "0x120B528", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x120B52C", Offset = "0x120B52C", VA = "0x120B52C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x120B798", Offset = "0x120B798", VA = "0x120B798", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000064")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x993C74", Offset = "0x993C74")]
	private sealed class <CancelWith>d__2 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject gameObject1;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject gameObject2;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject gameObject3;

		[Token(Token = "0x17000030")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x60002DC")]
			[Address(RVA = "0x120BB08", Offset = "0x120BB08", VA = "0x120BB08", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000031")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002DE")]
			[Address(RVA = "0x120BB74", Offset = "0x120BB74", VA = "0x120BB74", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x120B204", Offset = "0x120B204", VA = "0x120B204")]
		[DebuggerHidden]
		public <CancelWith>d__2(int <>1__state)
		{
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x120B860", Offset = "0x120B860", VA = "0x120B860", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x120B864", Offset = "0x120B864", VA = "0x120B864", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x120BB10", Offset = "0x120BB10", VA = "0x120BB10", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x120AF94", Offset = "0x120AF94", VA = "0x120AF94")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x994DB4", Offset = "0x994DB4")]
	public static IEnumerator<float> CancelWith(this IEnumerator<float> coroutine, GameObject gameObject)
	{
		return null;
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x120B05C", Offset = "0x120B05C", VA = "0x120B05C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x994E28", Offset = "0x994E28")]
	public static IEnumerator<float> CancelWith(this IEnumerator<float> coroutine, GameObject gameObject1, GameObject gameObject2)
	{
		return null;
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x120B138", Offset = "0x120B138", VA = "0x120B138")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x994E9C", Offset = "0x994E9C")]
	public static IEnumerator<float> CancelWith(this IEnumerator<float> coroutine, GameObject gameObject1, GameObject gameObject2, GameObject gameObject3)
	{
		return null;
	}
}
[Token(Token = "0x2000009")]
public class ZMSDK : MonoBehaviour
{
	[Token(Token = "0x6000026")]
	[Address(RVA = "0x121E77C", Offset = "0x121E77C", VA = "0x121E77C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x121EA0C", Offset = "0x121EA0C", VA = "0x121EA0C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x121EA10", Offset = "0x121EA10", VA = "0x121EA10")]
	public ZMSDK()
	{
	}
}
[Token(Token = "0x200000A")]
public class AlphaButtonClickMask : MonoBehaviour, ICanvasRaycastFilter
{
	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	protected Image _image;

	[Token(Token = "0x6000029")]
	[Address(RVA = "0xE3E484", Offset = "0xE3E484", VA = "0xE3E484")]
	public void Start()
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0xE3E650", Offset = "0xE3E650", VA = "0xE3E650", Slot = "4")]
	public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
	{
		return default(bool);
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0xE3E944", Offset = "0xE3E944", VA = "0xE3E944")]
	public AlphaButtonClickMask()
	{
	}
}
[Token(Token = "0x200000B")]
public class EventSystemChecker : MonoBehaviour
{
	[Token(Token = "0x600002C")]
	[Address(RVA = "0xE41E0C", Offset = "0xE41E0C", VA = "0xE41E0C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0xE41EEC", Offset = "0xE41EEC", VA = "0xE41EEC")]
	public EventSystemChecker()
	{
	}
}
[Token(Token = "0x200000C")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x993938", Offset = "0x993938")]
public class ForcedReset : MonoBehaviour
{
	[Token(Token = "0x600002E")]
	[Address(RVA = "0xE41EF4", Offset = "0xE41EF4", VA = "0xE41EF4")]
	private void Update()
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0xE41F90", Offset = "0xE41F90", VA = "0xE41F90")]
	public ForcedReset()
	{
	}
}
namespace UnityStandardAssets.Utility
{
	[Token(Token = "0x200000D")]
	public class ActivateTrigger : MonoBehaviour
	{
		[Token(Token = "0x2000065")]
		public enum Mode
		{
			[Token(Token = "0x4000208")]
			Trigger,
			[Token(Token = "0x4000209")]
			Replace,
			[Token(Token = "0x400020A")]
			Activate,
			[Token(Token = "0x400020B")]
			Enable,
			[Token(Token = "0x400020C")]
			Animate,
			[Token(Token = "0x400020D")]
			Deactivate
		}

		[Token(Token = "0x4000005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Mode action;

		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UnityEngine.Object target;

		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject source;

		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int triggerCount;

		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool repeatTrigger;

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x1217FD8", Offset = "0x1217FD8", VA = "0x1217FD8")]
		private void DoActivateTrigger()
		{
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x1218444", Offset = "0x1218444", VA = "0x1218444")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x1218448", Offset = "0x1218448", VA = "0x1218448")]
		public ActivateTrigger()
		{
		}
	}
	[Token(Token = "0x200000E")]
	public class AutoMobileShaderSwitch : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000066")]
		public class ReplacementDefinition
		{
			[Token(Token = "0x400020E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Shader original;

			[Token(Token = "0x400020F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Shader replacement;

			[Token(Token = "0x60002DF")]
			[Address(RVA = "0x1218EA0", Offset = "0x1218EA0", VA = "0x1218EA0")]
			public ReplacementDefinition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000067")]
		public class ReplacementList
		{
			[Token(Token = "0x4000210")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ReplacementDefinition[] items;

			[Token(Token = "0x60002E0")]
			[Address(RVA = "0x1218EA8", Offset = "0x1218EA8", VA = "0x1218EA8")]
			public ReplacementList()
			{
			}
		}

		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ReplacementList m_ReplacementList;

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x1218460", Offset = "0x1218460", VA = "0x1218460")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x1218E98", Offset = "0x1218E98", VA = "0x1218E98")]
		public AutoMobileShaderSwitch()
		{
		}
	}
	[Token(Token = "0x200000F")]
	public class AutoMoveAndRotate : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000068")]
		public class Vector3andSpace
		{
			[Token(Token = "0x4000211")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 value;

			[Token(Token = "0x4000212")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Space space;

			[Token(Token = "0x60002E1")]
			[Address(RVA = "0x1219088", Offset = "0x1219088", VA = "0x1219088")]
			public Vector3andSpace()
			{
			}
		}

		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3andSpace moveUnitsPerSecond;

		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3andSpace rotateDegreesPerSecond;

		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool ignoreTimescale;

		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float m_LastRealTime;

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x1218F18", Offset = "0x1218F18", VA = "0x1218F18")]
		private void Start()
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x1218F40", Offset = "0x1218F40", VA = "0x1218F40")]
		private void Update()
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x1219080", Offset = "0x1219080", VA = "0x1219080")]
		public AutoMoveAndRotate()
		{
		}
	}
	[Token(Token = "0x2000010")]
	public class CameraRefocus
	{
		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Camera Camera;

		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 Lookatpoint;

		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform Parent;

		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 m_OrigCameraPos;

		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool m_Refocus;

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x1219098", Offset = "0x1219098", VA = "0x1219098")]
		public CameraRefocus(Camera camera, Transform parent, Vector3 origCameraPos)
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x121910C", Offset = "0x121910C", VA = "0x121910C")]
		public void ChangeCamera(Camera camera)
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x1219114", Offset = "0x1219114", VA = "0x1219114")]
		public void ChangeParent(Transform parent)
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x121911C", Offset = "0x121911C", VA = "0x121911C")]
		public void GetFocusPoint()
		{
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x121927C", Offset = "0x121927C", VA = "0x121927C")]
		public void SetFocusPoint()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000011")]
	public class CurveControlledBob
	{
		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float HorizontalBobRange;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float VerticalBobRange;

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AnimationCurve Bobcurve;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float VerticaltoHorizontalRatio;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float m_CyclePositionX;

		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float m_CyclePositionY;

		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float m_BobBaseInterval;

		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 m_OriginalCameraPosition;

		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float m_Time;

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x12192D0", Offset = "0x12192D0", VA = "0x12192D0")]
		public void Setup(Camera camera, float bobBaseInterval)
		{
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x1219378", Offset = "0x1219378", VA = "0x1219378")]
		public Vector3 DoHeadBob(float speed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x1219498", Offset = "0x1219498", VA = "0x1219498")]
		public CurveControlledBob()
		{
		}
	}
	[Token(Token = "0x2000012")]
	public class DragRigidbody : MonoBehaviour
	{
		[Token(Token = "0x2000069")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x993C84", Offset = "0x993C84")]
		private sealed class <DragObject>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000213")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000214")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000215")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DragRigidbody <>4__this;

			[Token(Token = "0x4000216")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float distance;

			[Token(Token = "0x4000217")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <oldDrag>5__2;

			[Token(Token = "0x4000218")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <oldAngularDrag>5__3;

			[Token(Token = "0x4000219")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Camera <mainCamera>5__4;

			[Token(Token = "0x17000032")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60002E5")]
				[Address(RVA = "0x1219E44", Offset = "0x1219E44", VA = "0x1219E44", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000033")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60002E7")]
				[Address(RVA = "0x1219EB0", Offset = "0x1219EB0", VA = "0x1219EB0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60002E2")]
			[Address(RVA = "0x1219BAC", Offset = "0x1219BAC", VA = "0x1219BAC")]
			[DebuggerHidden]
			public <DragObject>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x60002E3")]
			[Address(RVA = "0x1219BE0", Offset = "0x1219BE0", VA = "0x1219BE0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60002E4")]
			[Address(RVA = "0x1219BE4", Offset = "0x1219BE4", VA = "0x1219BE4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60002E6")]
			[Address(RVA = "0x1219E4C", Offset = "0x1219E4C", VA = "0x1219E4C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400001D")]
		private const float k_Spring = 50f;

		[Token(Token = "0x400001E")]
		private const float k_Damper = 5f;

		[Token(Token = "0x400001F")]
		private const float k_Drag = 10f;

		[Token(Token = "0x4000020")]
		private const float k_AngularDrag = 5f;

		[Token(Token = "0x4000021")]
		private const float k_Distance = 0.2f;

		[Token(Token = "0x4000022")]
		private const bool k_AttachToCenterOfMass = false;

		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private SpringJoint m_SpringJoint;

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x12196F0", Offset = "0x12196F0", VA = "0x12196F0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x1219B1C", Offset = "0x1219B1C", VA = "0x1219B1C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x994F10", Offset = "0x994F10")]
		private IEnumerator DragObject(float distance)
		{
			return null;
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x1219A6C", Offset = "0x1219A6C", VA = "0x1219A6C")]
		private Camera FindCamera()
		{
			return null;
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x1219BD8", Offset = "0x1219BD8", VA = "0x1219BD8")]
		public DragRigidbody()
		{
		}
	}
	[Token(Token = "0x2000013")]
	public class DynamicShadowSettings : MonoBehaviour
	{
		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Light sunLight;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float minHeight;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float minShadowDistance;

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float minShadowBias;

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float maxHeight;

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float maxShadowDistance;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float maxShadowBias;

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float adaptTime;

		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float m_SmoothHeight;

		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float m_ChangeSpeed;

		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float m_OriginalStrength;

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x1219EB8", Offset = "0x1219EB8", VA = "0x1219EB8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x1219EEC", Offset = "0x1219EEC", VA = "0x1219EEC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x121A16C", Offset = "0x121A16C", VA = "0x121A16C")]
		public DynamicShadowSettings()
		{
		}
	}
	[Token(Token = "0x2000014")]
	public class FollowTarget : MonoBehaviour
	{
		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 offset;

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x121A99C", Offset = "0x121A99C", VA = "0x121A99C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x121AA80", Offset = "0x121AA80", VA = "0x121AA80")]
		public FollowTarget()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000015")]
	public class FOVKick
	{
		[Token(Token = "0x200006A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x993C94", Offset = "0x993C94")]
		private sealed class <FOVKickUp>d__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400021A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400021B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400021C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FOVKick <>4__this;

			[Token(Token = "0x400021D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <t>5__2;

			[Token(Token = "0x17000034")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60002EB")]
				[Address(RVA = "0x121A7C0", Offset = "0x121A7C0", VA = "0x121A7C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000035")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60002ED")]
				[Address(RVA = "0x121A82C", Offset = "0x121A82C", VA = "0x121A82C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60002E8")]
			[Address(RVA = "0x121A35C", Offset = "0x121A35C", VA = "0x121A35C")]
			[DebuggerHidden]
			public <FOVKickUp>d__9(int <>1__state)
			{
			}

			[Token(Token = "0x60002E9")]
			[Address(RVA = "0x121A64C", Offset = "0x121A64C", VA = "0x121A64C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60002EA")]
			[Address(RVA = "0x121A650", Offset = "0x121A650", VA = "0x121A650", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60002EC")]
			[Address(RVA = "0x121A7C8", Offset = "0x121A7C8", VA = "0x121A7C8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200006B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x993CA4", Offset = "0x993CA4")]
		private sealed class <FOVKickDown>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400021E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400021F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000220")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FOVKick <>4__this;

			[Token(Token = "0x4000221")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <t>5__2;

			[Token(Token = "0x17000036")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60002F1")]
				[Address(RVA = "0x121A5D8", Offset = "0x121A5D8", VA = "0x121A5D8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000037")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60002F3")]
				[Address(RVA = "0x121A644", Offset = "0x121A644", VA = "0x121A644", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60002EE")]
			[Address(RVA = "0x121A408", Offset = "0x121A408", VA = "0x121A408")]
			[DebuggerHidden]
			public <FOVKickDown>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x60002EF")]
			[Address(RVA = "0x121A450", Offset = "0x121A450", VA = "0x121A450", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60002F0")]
			[Address(RVA = "0x121A454", Offset = "0x121A454", VA = "0x121A454", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60002F2")]
			[Address(RVA = "0x121A5E0", Offset = "0x121A5E0", VA = "0x121A5E0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Camera Camera;

		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public float originalFov;

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float FOVIncrease;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float TimeToIncrease;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float TimeToDecrease;

		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AnimationCurve IncreaseCurve;

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x121A1A0", Offset = "0x121A1A0", VA = "0x121A1A0")]
		public void Setup(Camera camera)
		{
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x121A1F0", Offset = "0x121A1F0", VA = "0x121A1F0")]
		private void CheckStatus(Camera camera)
		{
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x121A2D4", Offset = "0x121A2D4", VA = "0x121A2D4")]
		public void ChangeCamera(Camera camera)
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x121A2DC", Offset = "0x121A2DC", VA = "0x121A2DC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x994F74", Offset = "0x994F74")]
		public IEnumerator FOVKickUp()
		{
			return null;
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x121A388", Offset = "0x121A388", VA = "0x121A388")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x994FD8", Offset = "0x994FD8")]
		public IEnumerator FOVKickDown()
		{
			return null;
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x121A434", Offset = "0x121A434", VA = "0x121A434")]
		public FOVKick()
		{
		}
	}
	[Token(Token = "0x2000016")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x99399C", Offset = "0x99399C")]
	public class FPSCounter : MonoBehaviour
	{
		[Token(Token = "0x4000037")]
		private const float fpsMeasurePeriod = 0.5f;

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int m_FpsAccumulator;

		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float m_FpsNextPeriod;

		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int m_CurrentFps;

		[Token(Token = "0x400003B")]
		private const string display = "{0} FPS";

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Text m_Text;

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x121A834", Offset = "0x121A834", VA = "0x121A834")]
		private void Start()
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x121A8AC", Offset = "0x121A8AC", VA = "0x121A8AC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x121A994", Offset = "0x121A994", VA = "0x121A994")]
		public FPSCounter()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000017")]
	public class LerpControlledBob
	{
		[Token(Token = "0x200006C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x993CB4", Offset = "0x993CB4")]
		private sealed class <DoBobCycle>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000222")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000223")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000224")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public LerpControlledBob <>4__this;

			[Token(Token = "0x4000225")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <t>5__2;

			[Token(Token = "0x17000038")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60002F7")]
				[Address(RVA = "0x121AD9C", Offset = "0x121AD9C", VA = "0x121AD9C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000039")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60002F9")]
				[Address(RVA = "0x121AE08", Offset = "0x121AE08", VA = "0x121AE08", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60002F4")]
			[Address(RVA = "0x121AB68", Offset = "0x121AB68", VA = "0x121AB68")]
			[DebuggerHidden]
			public <DoBobCycle>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x60002F5")]
			[Address(RVA = "0x121AB9C", Offset = "0x121AB9C", VA = "0x121AB9C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60002F6")]
			[Address(RVA = "0x121ABA0", Offset = "0x121ABA0", VA = "0x121ABA0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60002F8")]
			[Address(RVA = "0x121ADA4", Offset = "0x121ADA4", VA = "0x121ADA4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float BobDuration;

		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float BobAmount;

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float m_Offset;

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x121AAE0", Offset = "0x121AAE0", VA = "0x121AAE0")]
		public float Offset()
		{
			return default(float);
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x121AAE8", Offset = "0x121AAE8", VA = "0x121AAE8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x99503C", Offset = "0x99503C")]
		public IEnumerator DoBobCycle()
		{
			return null;
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x121AB94", Offset = "0x121AB94", VA = "0x121AB94")]
		public LerpControlledBob()
		{
		}
	}
	[Token(Token = "0x2000018")]
	public class ObjectResetter : MonoBehaviour
	{
		[Token(Token = "0x200006D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x993CC4", Offset = "0x993CC4")]
		private sealed class <ResetCoroutine>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000226")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000227")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000228")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float delay;

			[Token(Token = "0x4000229")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ObjectResetter <>4__this;

			[Token(Token = "0x1700003A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60002FD")]
				[Address(RVA = "0x121B24C", Offset = "0x121B24C", VA = "0x121B24C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700003B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60002FF")]
				[Address(RVA = "0x121B2B8", Offset = "0x121B2B8", VA = "0x121B2B8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60002FA")]
			[Address(RVA = "0x121AFD0", Offset = "0x121AFD0", VA = "0x121AFD0")]
			[DebuggerHidden]
			public <ResetCoroutine>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x60002FB")]
			[Address(RVA = "0x121B004", Offset = "0x121B004", VA = "0x121B004", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60002FC")]
			[Address(RVA = "0x121B008", Offset = "0x121B008", VA = "0x121B008", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60002FE")]
			[Address(RVA = "0x121B254", Offset = "0x121B254", VA = "0x121B254", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Vector3 originalPosition;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Quaternion originalRotation;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<Transform> originalStructure;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Rigidbody Rigidbody;

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x121AE10", Offset = "0x121AE10", VA = "0x121AE10")]
		private void Start()
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x121AF14", Offset = "0x121AF14", VA = "0x121AF14")]
		public void DelayedReset(float delay)
		{
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x121AF40", Offset = "0x121AF40", VA = "0x121AF40")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9950A0", Offset = "0x9950A0")]
		public IEnumerator ResetCoroutine(float delay)
		{
			return null;
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x121AFFC", Offset = "0x121AFFC", VA = "0x121AFFC")]
		public ObjectResetter()
		{
		}
	}
	[Token(Token = "0x2000019")]
	public class ParticleSystemDestroyer : MonoBehaviour
	{
		[Token(Token = "0x200006E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x993CD4", Offset = "0x993CD4")]
		private sealed class <Start>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400022A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400022B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400022C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ParticleSystemDestroyer <>4__this;

			[Token(Token = "0x400022D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private ParticleSystem[] <systems>5__2;

			[Token(Token = "0x400022E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <stopTime>5__3;

			[Token(Token = "0x1700003C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000303")]
				[Address(RVA = "0x121B6B8", Offset = "0x121B6B8", VA = "0x121B6B8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700003D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000305")]
				[Address(RVA = "0x121B724", Offset = "0x121B724", VA = "0x121B724", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000300")]
			[Address(RVA = "0x121B340", Offset = "0x121B340", VA = "0x121B340")]
			[DebuggerHidden]
			public <Start>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000301")]
			[Address(RVA = "0x121B38C", Offset = "0x121B38C", VA = "0x121B38C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000302")]
			[Address(RVA = "0x121B390", Offset = "0x121B390", VA = "0x121B390", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000304")]
			[Address(RVA = "0x121B6C0", Offset = "0x121B6C0", VA = "0x121B6C0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float minDuration;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float maxDuration;

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float m_MaxLifetime;

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private bool m_EarlyStop;

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x121B2C0", Offset = "0x121B2C0", VA = "0x121B2C0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x995104", Offset = "0x995104")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x121B36C", Offset = "0x121B36C", VA = "0x121B36C")]
		public void Stop()
		{
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x121B378", Offset = "0x121B378", VA = "0x121B378")]
		public ParticleSystemDestroyer()
		{
		}
	}
	[Token(Token = "0x200001A")]
	public class PlatformSpecificContent : MonoBehaviour
	{
		[Token(Token = "0x200006F")]
		private enum BuildTargetGroup
		{
			[Token(Token = "0x4000230")]
			Standalone,
			[Token(Token = "0x4000231")]
			Mobile
		}

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private BuildTargetGroup m_BuildTargetGroup;

		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject[] m_Content;

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MonoBehaviour[] m_MonoBehaviours;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool m_ChildrenOfThisObject;

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x121B72C", Offset = "0x121B72C", VA = "0x121B72C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x121B730", Offset = "0x121B730", VA = "0x121B730")]
		private void CheckEnableContent()
		{
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x121B74C", Offset = "0x121B74C", VA = "0x121B74C")]
		private void EnableContent(bool enabled)
		{
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x121BAE0", Offset = "0x121BAE0", VA = "0x121BAE0")]
		public PlatformSpecificContent()
		{
		}
	}
	[Token(Token = "0x200001B")]
	public class SimpleActivatorMenu : MonoBehaviour
	{
		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GUIText camSwitchButton;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject[] objects;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int m_CurrentActiveObject;

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x121BB78", Offset = "0x121BB78", VA = "0x121BB78")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x121BBE4", Offset = "0x121BBE4", VA = "0x121BBE4")]
		public void NextCamera()
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x121BCC0", Offset = "0x121BCC0", VA = "0x121BCC0")]
		public SimpleActivatorMenu()
		{
		}
	}
	[Token(Token = "0x200001C")]
	public class SimpleMouseRotator : MonoBehaviour
	{
		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector2 rotationRange;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float rotationSpeed;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float dampingTime;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool autoZeroVerticalOnMobile;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool autoZeroHorizontalOnMobile;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		public bool relative;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector3 m_TargetAngles;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 m_FollowAngles;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector3 m_FollowVelocity;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion m_OriginalRotation;

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x121BCC8", Offset = "0x121BCC8", VA = "0x121BCC8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x121BD04", Offset = "0x121BD04", VA = "0x121BD04")]
		private void Update()
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x121C140", Offset = "0x121C140", VA = "0x121C140")]
		public SimpleMouseRotator()
		{
		}
	}
	[Token(Token = "0x200001D")]
	public class SmoothFollow : MonoBehaviour
	{
		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform target;

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float distance;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float height;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float rotationDamping;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float heightDamping;

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x121C204", Offset = "0x121C204", VA = "0x121C204")]
		private void Start()
		{
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x121C208", Offset = "0x121C208", VA = "0x121C208")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x121C540", Offset = "0x121C540", VA = "0x121C540")]
		public SmoothFollow()
		{
		}
	}
	[Token(Token = "0x200001E")]
	public class TimedObjectActivator : MonoBehaviour
	{
		[Token(Token = "0x2000070")]
		public enum Action
		{
			[Token(Token = "0x4000233")]
			Activate,
			[Token(Token = "0x4000234")]
			Deactivate,
			[Token(Token = "0x4000235")]
			Destroy,
			[Token(Token = "0x4000236")]
			ReloadLevel,
			[Token(Token = "0x4000237")]
			Call
		}

		[Serializable]
		[Token(Token = "0x2000071")]
		public class Entry
		{
			[Token(Token = "0x4000238")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public GameObject target;

			[Token(Token = "0x4000239")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Action action;

			[Token(Token = "0x400023A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float delay;

			[Token(Token = "0x6000306")]
			[Address(RVA = "0x121CD08", Offset = "0x121CD08", VA = "0x121CD08")]
			public Entry()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000072")]
		public class Entries
		{
			[Token(Token = "0x400023B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Entry[] entries;

			[Token(Token = "0x6000307")]
			[Address(RVA = "0x121C900", Offset = "0x121C900", VA = "0x121C900")]
			public Entries()
			{
			}
		}

		[Token(Token = "0x2000073")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x993CE4", Offset = "0x993CE4")]
		private sealed class <Activate>d__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400023C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400023D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400023E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Entry entry;

			[Token(Token = "0x1700003E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600030B")]
				[Address(RVA = "0x121C9E4", Offset = "0x121C9E4", VA = "0x121C9E4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700003F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600030D")]
				[Address(RVA = "0x121CA50", Offset = "0x121CA50", VA = "0x121CA50", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000308")]
			[Address(RVA = "0x121C808", Offset = "0x121C808", VA = "0x121C808")]
			[DebuggerHidden]
			public <Activate>d__5(int <>1__state)
			{
			}

			[Token(Token = "0x6000309")]
			[Address(RVA = "0x121C908", Offset = "0x121C908", VA = "0x121C908", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600030A")]
			[Address(RVA = "0x121C90C", Offset = "0x121C90C", VA = "0x121C90C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600030C")]
			[Address(RVA = "0x121C9EC", Offset = "0x121C9EC", VA = "0x121C9EC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000074")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x993CF4", Offset = "0x993CF4")]
		private sealed class <Deactivate>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400023F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000240")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000241")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Entry entry;

			[Token(Token = "0x17000040")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000311")]
				[Address(RVA = "0x121CB34", Offset = "0x121CB34", VA = "0x121CB34", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000041")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000313")]
				[Address(RVA = "0x121CBA0", Offset = "0x121CBA0", VA = "0x121CBA0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600030E")]
			[Address(RVA = "0x121C834", Offset = "0x121C834", VA = "0x121C834")]
			[DebuggerHidden]
			public <Deactivate>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x600030F")]
			[Address(RVA = "0x121CA58", Offset = "0x121CA58", VA = "0x121CA58", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000310")]
			[Address(RVA = "0x121CA5C", Offset = "0x121CA5C", VA = "0x121CA5C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000312")]
			[Address(RVA = "0x121CB3C", Offset = "0x121CB3C", VA = "0x121CB3C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000075")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x993D04", Offset = "0x993D04")]
		private sealed class <ReloadLevel>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000242")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000243")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000244")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Entry entry;

			[Token(Token = "0x17000042")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000317")]
				[Address(RVA = "0x121CC94", Offset = "0x121CC94", VA = "0x121CC94", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000043")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000319")]
				[Address(RVA = "0x121CD00", Offset = "0x121CD00", VA = "0x121CD00", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000314")]
			[Address(RVA = "0x121C860", Offset = "0x121C860", VA = "0x121C860")]
			[DebuggerHidden]
			public <ReloadLevel>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000315")]
			[Address(RVA = "0x121CBA8", Offset = "0x121CBA8", VA = "0x121CBA8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000316")]
			[Address(RVA = "0x121CBAC", Offset = "0x121CBAC", VA = "0x121CBAC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000318")]
			[Address(RVA = "0x121CC9C", Offset = "0x121CC9C", VA = "0x121CC9C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Entries entries;

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x121C554", Offset = "0x121C554", VA = "0x121C554")]
		private void Awake()
		{
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x121C688", Offset = "0x121C688", VA = "0x121C688")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x995168", Offset = "0x995168")]
		private IEnumerator Activate(Entry entry)
		{
			return null;
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x121C708", Offset = "0x121C708", VA = "0x121C708")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9951CC", Offset = "0x9951CC")]
		private IEnumerator Deactivate(Entry entry)
		{
			return null;
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x121C788", Offset = "0x121C788", VA = "0x121C788")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x995230", Offset = "0x995230")]
		private IEnumerator ReloadLevel(Entry entry)
		{
			return null;
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x121C88C", Offset = "0x121C88C", VA = "0x121C88C")]
		public TimedObjectActivator()
		{
		}
	}
	[Token(Token = "0x200001F")]
	public class TimedObjectDestructor : MonoBehaviour
	{
		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_TimeOut;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private bool m_DetachChildren;

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x121CD10", Offset = "0x121CD10", VA = "0x121CD10")]
		private void Awake()
		{
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x121CD68", Offset = "0x121CD68", VA = "0x121CD68")]
		private void DestroyNow()
		{
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x121CE08", Offset = "0x121CE08", VA = "0x121CE08")]
		public TimedObjectDestructor()
		{
		}
	}
	[Token(Token = "0x2000020")]
	public class WaypointCircuit : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000076")]
		public class WaypointList
		{
			[Token(Token = "0x4000245")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public WaypointCircuit circuit;

			[Token(Token = "0x4000246")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform[] items;

			[Token(Token = "0x600031A")]
			[Address(RVA = "0x121DCD0", Offset = "0x121DCD0", VA = "0x121DCD0")]
			public WaypointList()
			{
			}
		}

		[Token(Token = "0x2000077")]
		public struct RoutePoint
		{
			[Token(Token = "0x4000247")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 position;

			[Token(Token = "0x4000248")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 direction;

			[Token(Token = "0x600031B")]
			[Address(RVA = "0xA66A94", Offset = "0xA66A94", VA = "0xA66A94")]
			public RoutePoint(Vector3 position, Vector3 direction)
			{
			}
		}

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public WaypointList waypointList;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool smoothRoute;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int numPoints;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3[] points;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float[] distances;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float editorVisualisationSubsteps;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994074", Offset = "0x994074")]
		private float <Length>k__BackingField;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int p0n;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private int p1n;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int p2n;

		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int p3n;

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float i;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 P0;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 P1;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 P2;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 P3;

		[Token(Token = "0x17000005")]
		public float Length
		{
			[Token(Token = "0x6000071")]
			[Address(RVA = "0x121CE18", Offset = "0x121CE18", VA = "0x121CE18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x995294", Offset = "0x995294")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000072")]
			[Address(RVA = "0x121CE20", Offset = "0x121CE20", VA = "0x121CE20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9952A4", Offset = "0x9952A4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000006")]
		public Transform[] Waypoints
		{
			[Token(Token = "0x6000073")]
			[Address(RVA = "0x121CE28", Offset = "0x121CE28", VA = "0x121CE28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x121CE48", Offset = "0x121CE48", VA = "0x121CE48")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x121D1C0", Offset = "0x121D1C0", VA = "0x121D1C0")]
		public RoutePoint GetRoutePoint(float dist)
		{
			return default(RoutePoint);
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x121D2D0", Offset = "0x121D2D0", VA = "0x121D2D0")]
		public Vector3 GetRoutePosition(float dist)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x121D658", Offset = "0x121D658", VA = "0x121D658")]
		private Vector3 CatmullRom(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float i)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x121CEA8", Offset = "0x121CEA8", VA = "0x121CEA8")]
		private void CachePositionsAndDistances()
		{
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x121D9B4", Offset = "0x121D9B4", VA = "0x121D9B4")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x121DC48", Offset = "0x121DC48", VA = "0x121DC48")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x121D9BC", Offset = "0x121D9BC", VA = "0x121D9BC")]
		private void DrawGizmos(bool selected)
		{
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x121DC50", Offset = "0x121DC50", VA = "0x121DC50")]
		public WaypointCircuit()
		{
		}
	}
	[Token(Token = "0x2000021")]
	public class WaypointProgressTracker : MonoBehaviour
	{
		[Token(Token = "0x2000078")]
		public enum ProgressStyle
		{
			[Token(Token = "0x400024A")]
			SmoothAlongRoute,
			[Token(Token = "0x400024B")]
			PointToPoint
		}

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private WaypointCircuit circuit;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float lookAheadForTargetOffset;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float lookAheadForTargetFactor;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float lookAheadForSpeedOffset;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float lookAheadForSpeedFactor;

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ProgressStyle progressStyle;

		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float pointToPointThreshold;

		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9940F4", Offset = "0x9940F4")]
		private WaypointCircuit.RoutePoint <targetPoint>k__BackingField;

		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994104", Offset = "0x994104")]
		private WaypointCircuit.RoutePoint <speedPoint>k__BackingField;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994114", Offset = "0x994114")]
		private WaypointCircuit.RoutePoint <progressPoint>k__BackingField;

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform target;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float progressDistance;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private int progressNum;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 lastPosition;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private float speed;

		[Token(Token = "0x17000007")]
		public WaypointCircuit.RoutePoint targetPoint
		{
			[Token(Token = "0x600007D")]
			[Address(RVA = "0x121DD40", Offset = "0x121DD40", VA = "0x121DD40")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9952B4", Offset = "0x9952B4")]
			get
			{
				return default(WaypointCircuit.RoutePoint);
			}
			[Token(Token = "0x600007E")]
			[Address(RVA = "0x121DD54", Offset = "0x121DD54", VA = "0x121DD54")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9952C4", Offset = "0x9952C4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000008")]
		public WaypointCircuit.RoutePoint speedPoint
		{
			[Token(Token = "0x600007F")]
			[Address(RVA = "0x121DD68", Offset = "0x121DD68", VA = "0x121DD68")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9952D4", Offset = "0x9952D4")]
			get
			{
				return default(WaypointCircuit.RoutePoint);
			}
			[Token(Token = "0x6000080")]
			[Address(RVA = "0x121DD7C", Offset = "0x121DD7C", VA = "0x121DD7C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9952E4", Offset = "0x9952E4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000009")]
		public WaypointCircuit.RoutePoint progressPoint
		{
			[Token(Token = "0x6000081")]
			[Address(RVA = "0x121DD90", Offset = "0x121DD90", VA = "0x121DD90")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9952F4", Offset = "0x9952F4")]
			get
			{
				return default(WaypointCircuit.RoutePoint);
			}
			[Token(Token = "0x6000082")]
			[Address(RVA = "0x121DDA4", Offset = "0x121DDA4", VA = "0x121DDA4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x995304", Offset = "0x995304")]
			private set
			{
			}
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x121DDB8", Offset = "0x121DDB8", VA = "0x121DDB8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x121DEB4", Offset = "0x121DEB4", VA = "0x121DEB4")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x121DF98", Offset = "0x121DF98", VA = "0x121DF98")]
		private void Update()
		{
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x121E50C", Offset = "0x121E50C", VA = "0x121E50C")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x121E6E4", Offset = "0x121E6E4", VA = "0x121E6E4")]
		public WaypointProgressTracker()
		{
		}
	}
}
namespace UnityStandardAssets.CrossPlatformInput
{
	[Token(Token = "0x2000022")]
	public class AxisTouchButton : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string axisName;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float axisValue;

		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float responseSpeed;

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float returnToCentreSpeed;

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private AxisTouchButton m_PairedWith;

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private CrossPlatformInputManager.VirtualAxis m_Axis;

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x12142CC", Offset = "0x12142CC", VA = "0x12142CC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x1214598", Offset = "0x1214598", VA = "0x1214598")]
		private void FindPairedButton()
		{
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x1214730", Offset = "0x1214730", VA = "0x1214730")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x12147B0", Offset = "0x12147B0", VA = "0x12147B0", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x121489C", Offset = "0x121489C", VA = "0x121489C", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x1214948", Offset = "0x1214948", VA = "0x1214948")]
		public AxisTouchButton()
		{
		}
	}
	[Token(Token = "0x2000023")]
	public class ButtonHandler : MonoBehaviour
	{
		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string Name;

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x12149BC", Offset = "0x12149BC", VA = "0x12149BC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x12149C0", Offset = "0x12149C0", VA = "0x12149C0")]
		public void SetDownState()
		{
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x1214AA8", Offset = "0x1214AA8", VA = "0x1214AA8")]
		public void SetUpState()
		{
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x1214B90", Offset = "0x1214B90", VA = "0x1214B90")]
		public void SetAxisPositiveState()
		{
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x1214C78", Offset = "0x1214C78", VA = "0x1214C78")]
		public void SetAxisNeutralState()
		{
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x1214D60", Offset = "0x1214D60", VA = "0x1214D60")]
		public void SetAxisNegativeState()
		{
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x1214E48", Offset = "0x1214E48", VA = "0x1214E48")]
		public void Update()
		{
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x1214E4C", Offset = "0x1214E4C", VA = "0x1214E4C")]
		public ButtonHandler()
		{
		}
	}
	[Token(Token = "0x2000024")]
	public static class CrossPlatformInputManager
	{
		[Token(Token = "0x2000079")]
		public enum ActiveInputMethod
		{
			[Token(Token = "0x400024D")]
			Hardware,
			[Token(Token = "0x400024E")]
			Touch
		}

		[Token(Token = "0x200007A")]
		public class VirtualAxis
		{
			[Token(Token = "0x400024F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994B28", Offset = "0x994B28")]
			private string <name>k__BackingField;

			[Token(Token = "0x4000250")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private float m_Value;

			[Token(Token = "0x4000251")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994B38", Offset = "0x994B38")]
			private bool <matchWithInputManager>k__BackingField;

			[Token(Token = "0x17000044")]
			public string name
			{
				[Token(Token = "0x600031C")]
				[Address(RVA = "0x1215D68", Offset = "0x1215D68", VA = "0x1215D68")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x996DE0", Offset = "0x996DE0")]
				get
				{
					return null;
				}
				[Token(Token = "0x600031D")]
				[Address(RVA = "0x1215D70", Offset = "0x1215D70", VA = "0x1215D70")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x996DF0", Offset = "0x996DF0")]
				private set
				{
				}
			}

			[Token(Token = "0x17000045")]
			public bool matchWithInputManager
			{
				[Token(Token = "0x600031E")]
				[Address(RVA = "0x1215D78", Offset = "0x1215D78", VA = "0x1215D78")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x996E00", Offset = "0x996E00")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600031F")]
				[Address(RVA = "0x1215D80", Offset = "0x1215D80", VA = "0x1215D80")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x996E10", Offset = "0x996E10")]
				private set
				{
				}
			}

			[Token(Token = "0x17000046")]
			public float GetValue
			{
				[Token(Token = "0x6000324")]
				[Address(RVA = "0x1215DE0", Offset = "0x1215DE0", VA = "0x1215DE0")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x17000047")]
			public float GetValueRaw
			{
				[Token(Token = "0x6000325")]
				[Address(RVA = "0x1215DE8", Offset = "0x1215DE8", VA = "0x1215DE8")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x6000320")]
			[Address(RVA = "0x1214468", Offset = "0x1214468", VA = "0x1214468")]
			public VirtualAxis(string name)
			{
			}

			[Token(Token = "0x6000321")]
			[Address(RVA = "0x1215D8C", Offset = "0x1215D8C", VA = "0x1215D8C")]
			public VirtualAxis(string name, bool matchToInputSettings)
			{
			}

			[Token(Token = "0x6000322")]
			[Address(RVA = "0x1214748", Offset = "0x1214748", VA = "0x1214748")]
			public void Remove()
			{
			}

			[Token(Token = "0x6000323")]
			[Address(RVA = "0x1215DD8", Offset = "0x1215DD8", VA = "0x1215DD8")]
			public void Update(float value)
			{
			}
		}

		[Token(Token = "0x200007B")]
		public class VirtualButton
		{
			[Token(Token = "0x4000252")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994B48", Offset = "0x994B48")]
			private string <name>k__BackingField;

			[Token(Token = "0x4000253")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994B58", Offset = "0x994B58")]
			private bool <matchWithInputManager>k__BackingField;

			[Token(Token = "0x4000254")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private int m_LastPressedFrame;

			[Token(Token = "0x4000255")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int m_ReleasedFrame;

			[Token(Token = "0x4000256")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private bool m_Pressed;

			[Token(Token = "0x17000048")]
			public string name
			{
				[Token(Token = "0x6000326")]
				[Address(RVA = "0x1215DF0", Offset = "0x1215DF0", VA = "0x1215DF0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x996E20", Offset = "0x996E20")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000327")]
				[Address(RVA = "0x1215DF8", Offset = "0x1215DF8", VA = "0x1215DF8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x996E30", Offset = "0x996E30")]
				private set
				{
				}
			}

			[Token(Token = "0x17000049")]
			public bool matchWithInputManager
			{
				[Token(Token = "0x6000328")]
				[Address(RVA = "0x1215E00", Offset = "0x1215E00", VA = "0x1215E00")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x996E40", Offset = "0x996E40")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000329")]
				[Address(RVA = "0x1215E08", Offset = "0x1215E08", VA = "0x1215E08")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x996E50", Offset = "0x996E50")]
				private set
				{
				}
			}

			[Token(Token = "0x1700004A")]
			public bool GetButton
			{
				[Token(Token = "0x600032F")]
				[Address(RVA = "0x1215F7C", Offset = "0x1215F7C", VA = "0x1215F7C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700004B")]
			public bool GetButtonDown
			{
				[Token(Token = "0x6000330")]
				[Address(RVA = "0x1215F84", Offset = "0x1215F84", VA = "0x1215F84")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700004C")]
			public bool GetButtonUp
			{
				[Token(Token = "0x6000331")]
				[Address(RVA = "0x1215FB4", Offset = "0x1215FB4", VA = "0x1215FB4")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600032A")]
			[Address(RVA = "0x1215E14", Offset = "0x1215E14", VA = "0x1215E14")]
			public VirtualButton(string name)
			{
			}

			[Token(Token = "0x600032B")]
			[Address(RVA = "0x1215E5C", Offset = "0x1215E5C", VA = "0x1215E5C")]
			public VirtualButton(string name, bool matchToInputSettings)
			{
			}

			[Token(Token = "0x600032C")]
			[Address(RVA = "0x1215EB0", Offset = "0x1215EB0", VA = "0x1215EB0")]
			public void Pressed()
			{
			}

			[Token(Token = "0x600032D")]
			[Address(RVA = "0x1215EE8", Offset = "0x1215EE8", VA = "0x1215EE8")]
			public void Released()
			{
			}

			[Token(Token = "0x600032E")]
			[Address(RVA = "0x1215F14", Offset = "0x1215F14", VA = "0x1215F14")]
			public void Remove()
			{
			}
		}

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static VirtualInput activeInput;

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static VirtualInput s_TouchInput;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static VirtualInput s_HardwareInput;

		[Token(Token = "0x1700000A")]
		public static Vector3 mousePosition
		{
			[Token(Token = "0x60000AB")]
			[Address(RVA = "0x12159DC", Offset = "0x12159DC", VA = "0x12159DC")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x1214E54", Offset = "0x1214E54", VA = "0x1214E54")]
		static CrossPlatformInputManager()
		{
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x1214F08", Offset = "0x1214F08", VA = "0x1214F08")]
		public static void SwitchActiveInputMethod(ActiveInputMethod activeInputMethod)
		{
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x12143F0", Offset = "0x12143F0", VA = "0x12143F0")]
		public static bool AxisExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x1215028", Offset = "0x1215028", VA = "0x1215028")]
		public static bool ButtonExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x12144A8", Offset = "0x12144A8", VA = "0x12144A8")]
		public static void RegisterVirtualAxis(VirtualAxis axis)
		{
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x1215234", Offset = "0x1215234", VA = "0x1215234")]
		public static void RegisterVirtualButton(VirtualButton button)
		{
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x12153D8", Offset = "0x12153D8", VA = "0x12153D8")]
		public static void UnRegisterVirtualAxis(string name)
		{
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x121552C", Offset = "0x121552C", VA = "0x121552C")]
		public static void UnRegisterVirtualButton(string name)
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x1214520", Offset = "0x1214520", VA = "0x1214520")]
		public static VirtualAxis VirtualAxisReference(string name)
		{
			return null;
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x1212F5C", Offset = "0x1212F5C", VA = "0x1212F5C")]
		public static float GetAxis(string name)
		{
			return default(float);
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x1215760", Offset = "0x1215760", VA = "0x1215760")]
		public static float GetAxisRaw(string name)
		{
			return default(float);
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x12156D0", Offset = "0x12156D0", VA = "0x12156D0")]
		private static float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x12157C8", Offset = "0x12157C8", VA = "0x12157C8")]
		public static bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x1215848", Offset = "0x1215848", VA = "0x1215848")]
		public static bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x12158C8", Offset = "0x12158C8", VA = "0x12158C8")]
		public static bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x1214A28", Offset = "0x1214A28", VA = "0x1214A28")]
		public static void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x1214B10", Offset = "0x1214B10", VA = "0x1214B10")]
		public static void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x1214BF8", Offset = "0x1214BF8", VA = "0x1214BF8")]
		public static void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x1214DC8", Offset = "0x1214DC8", VA = "0x1214DC8")]
		public static void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x1214CE0", Offset = "0x1214CE0", VA = "0x1214CE0")]
		public static void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x1215948", Offset = "0x1215948", VA = "0x1215948")]
		public static void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x1215A58", Offset = "0x1215A58", VA = "0x1215A58")]
		public static void SetVirtualMousePositionX(float f)
		{
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x1215B58", Offset = "0x1215B58", VA = "0x1215B58")]
		public static void SetVirtualMousePositionY(float f)
		{
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x1215C64", Offset = "0x1215C64", VA = "0x1215C64")]
		public static void SetVirtualMousePositionZ(float f)
		{
		}
	}
	[Token(Token = "0x2000025")]
	public class InputAxisScrollbar : MonoBehaviour
	{
		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string axis;

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x1215FE4", Offset = "0x1215FE4", VA = "0x1215FE4")]
		private void Update()
		{
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x1215FE8", Offset = "0x1215FE8", VA = "0x1215FE8")]
		public void HandleInput(float value)
		{
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x1216068", Offset = "0x1216068", VA = "0x1216068")]
		public InputAxisScrollbar()
		{
		}
	}
	[Token(Token = "0x2000026")]
	public class Joystick : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IDragHandler
	{
		[Token(Token = "0x200007C")]
		public enum AxisOption
		{
			[Token(Token = "0x4000258")]
			Both,
			[Token(Token = "0x4000259")]
			OnlyHorizontal,
			[Token(Token = "0x400025A")]
			OnlyVertical
		}

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int MovementRange;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public AxisOption axesToUse;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string horizontalAxisName;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string verticalAxisName;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 m_StartPos;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool m_UseX;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
		private bool m_UseY;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private CrossPlatformInputManager.VirtualAxis m_HorizontalVirtualAxis;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private CrossPlatformInputManager.VirtualAxis m_VerticalVirtualAxis;

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x1216070", Offset = "0x1216070", VA = "0x1216070")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x12161EC", Offset = "0x12161EC", VA = "0x12161EC")]
		private void Start()
		{
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x1216228", Offset = "0x1216228", VA = "0x1216228")]
		private void UpdateVirtualAxes(Vector3 value)
		{
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x1216074", Offset = "0x1216074", VA = "0x1216074")]
		private void CreateVirtualAxes()
		{
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x121631C", Offset = "0x121631C", VA = "0x121631C", Slot = "6")]
		public void OnDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x12164DC", Offset = "0x12164DC", VA = "0x12164DC", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x1216524", Offset = "0x1216524", VA = "0x1216524", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x1216528", Offset = "0x1216528", VA = "0x1216528")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x1216578", Offset = "0x1216578", VA = "0x1216578")]
		public Joystick()
		{
		}
	}
	[Token(Token = "0x2000027")]
	[ExecuteInEditMode]
	public class MobileControlRig : MonoBehaviour
	{
		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x12165F8", Offset = "0x12165F8", VA = "0x12165F8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x1216608", Offset = "0x1216608", VA = "0x1216608")]
		private void Start()
		{
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x1216600", Offset = "0x1216600", VA = "0x1216600")]
		private void CheckEnableControlRig()
		{
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x12166E8", Offset = "0x12166E8", VA = "0x12166E8")]
		private void EnableControlRig(bool enabled)
		{
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x1216994", Offset = "0x1216994", VA = "0x1216994")]
		public MobileControlRig()
		{
		}
	}
	[Token(Token = "0x2000028")]
	public class TiltInput : MonoBehaviour
	{
		[Token(Token = "0x200007D")]
		public enum AxisOptions
		{
			[Token(Token = "0x400025C")]
			ForwardAxis,
			[Token(Token = "0x400025D")]
			SidewaysAxis
		}

		[Serializable]
		[Token(Token = "0x200007E")]
		public class AxisMapping
		{
			[Token(Token = "0x20000AE")]
			public enum MappingType
			{
				[Token(Token = "0x400031C")]
				NamedAxis,
				[Token(Token = "0x400031D")]
				MousePositionX,
				[Token(Token = "0x400031E")]
				MousePositionY,
				[Token(Token = "0x400031F")]
				MousePositionZ
			}

			[Token(Token = "0x400025E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public MappingType type;

			[Token(Token = "0x400025F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string axisName;

			[Token(Token = "0x6000332")]
			[Address(RVA = "0x12178BC", Offset = "0x12178BC", VA = "0x12178BC")]
			public AxisMapping()
			{
			}
		}

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AxisMapping mapping;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AxisOptions tiltAroundAxis;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float fullTiltAngle;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float centreAngleOffset;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private CrossPlatformInputManager.VirtualAxis m_SteerAxis;

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x1217524", Offset = "0x1217524", VA = "0x1217524")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x1217604", Offset = "0x1217604", VA = "0x1217604")]
		private void Update()
		{
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x1217894", Offset = "0x1217894", VA = "0x1217894")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x12178AC", Offset = "0x12178AC", VA = "0x12178AC")]
		public TiltInput()
		{
		}
	}
	[Token(Token = "0x2000029")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x993A10", Offset = "0x993A10")]
	public class TouchPad : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		[Token(Token = "0x200007F")]
		public enum AxisOption
		{
			[Token(Token = "0x4000261")]
			Both,
			[Token(Token = "0x4000262")]
			OnlyHorizontal,
			[Token(Token = "0x4000263")]
			OnlyVertical
		}

		[Token(Token = "0x2000080")]
		public enum ControlStyle
		{
			[Token(Token = "0x4000265")]
			Absolute,
			[Token(Token = "0x4000266")]
			Relative,
			[Token(Token = "0x4000267")]
			Swipe
		}

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AxisOption axesToUse;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public ControlStyle controlStyle;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string horizontalAxisName;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string verticalAxisName;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float Xsensitivity;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float Ysensitivity;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 m_StartPos;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector2 m_PreviousDelta;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 m_JoytickOutput;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool m_UseX;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		private bool m_UseY;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private CrossPlatformInputManager.VirtualAxis m_HorizontalVirtualAxis;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private CrossPlatformInputManager.VirtualAxis m_VerticalVirtualAxis;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool m_Dragging;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int m_Id;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector2 m_PreviousTouchPos;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 m_Center;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Image m_Image;

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x12178C4", Offset = "0x12178C4", VA = "0x12178C4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x1217A40", Offset = "0x1217A40", VA = "0x1217A40")]
		private void Start()
		{
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x12178C8", Offset = "0x12178C8", VA = "0x12178C8")]
		private void CreateVirtualAxes()
		{
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x1217AD0", Offset = "0x1217AD0", VA = "0x1217AD0")]
		private void UpdateVirtualAxes(Vector3 value)
		{
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x1217B40", Offset = "0x1217B40", VA = "0x1217B40", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x1217BF4", Offset = "0x1217BF4", VA = "0x1217BF4")]
		private void Update()
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x1217DCC", Offset = "0x1217DCC", VA = "0x1217DCC", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x1217E44", Offset = "0x1217E44", VA = "0x1217E44")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x1217F38", Offset = "0x1217F38", VA = "0x1217F38")]
		public TouchPad()
		{
		}
	}
	[Token(Token = "0x200002A")]
	public abstract class VirtualInput
	{
		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994124", Offset = "0x994124")]
		private Vector3 <virtualMousePosition>k__BackingField;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected Dictionary<string, CrossPlatformInputManager.VirtualAxis> m_VirtualAxes;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected Dictionary<string, CrossPlatformInputManager.VirtualButton> m_VirtualButtons;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected List<string> m_AlwaysUseVirtual;

		[Token(Token = "0x1700000B")]
		public Vector3 virtualMousePosition
		{
			[Token(Token = "0x60000CD")]
			[Address(RVA = "0x1217FC0", Offset = "0x1217FC0", VA = "0x1217FC0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x995314", Offset = "0x995314")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60000CE")]
			[Address(RVA = "0x1217FCC", Offset = "0x1217FCC", VA = "0x1217FCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x995324", Offset = "0x995324")]
			private set
			{
			}
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x1214FC0", Offset = "0x1214FC0", VA = "0x1214FC0")]
		public bool AxisExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x12150A0", Offset = "0x12150A0", VA = "0x12150A0")]
		public bool ButtonExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x1215108", Offset = "0x1215108", VA = "0x1215108")]
		public void RegisterVirtualAxis(CrossPlatformInputManager.VirtualAxis axis)
		{
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x12152AC", Offset = "0x12152AC", VA = "0x12152AC")]
		public void RegisterVirtualButton(CrossPlatformInputManager.VirtualButton button)
		{
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x1215494", Offset = "0x1215494", VA = "0x1215494")]
		public void UnRegisterVirtualAxis(string name)
		{
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x12155A4", Offset = "0x12155A4", VA = "0x12155A4")]
		public void UnRegisterVirtualButton(string name)
		{
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x121563C", Offset = "0x121563C", VA = "0x121563C")]
		public CrossPlatformInputManager.VirtualAxis VirtualAxisReference(string name)
		{
			return null;
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x1215B0C", Offset = "0x1215B0C", VA = "0x1215B0C")]
		public void SetVirtualMousePositionX(float f)
		{
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x1215C10", Offset = "0x1215C10", VA = "0x1215C10")]
		public void SetVirtualMousePositionY(float f)
		{
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x1215D18", Offset = "0x1215D18", VA = "0x1215D18")]
		public void SetVirtualMousePositionZ(float f)
		{
		}

		[Token(Token = "0x60000D9")]
		public abstract float GetAxis(string name, bool raw);

		[Token(Token = "0x60000DA")]
		public abstract bool GetButton(string name);

		[Token(Token = "0x60000DB")]
		public abstract bool GetButtonDown(string name);

		[Token(Token = "0x60000DC")]
		public abstract bool GetButtonUp(string name);

		[Token(Token = "0x60000DD")]
		public abstract void SetButtonDown(string name);

		[Token(Token = "0x60000DE")]
		public abstract void SetButtonUp(string name);

		[Token(Token = "0x60000DF")]
		public abstract void SetAxisPositive(string name);

		[Token(Token = "0x60000E0")]
		public abstract void SetAxisNegative(string name);

		[Token(Token = "0x60000E1")]
		public abstract void SetAxisZero(string name);

		[Token(Token = "0x60000E2")]
		public abstract void SetAxis(string name, float value);

		[Token(Token = "0x60000E3")]
		public abstract Vector3 MousePosition();

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x1217160", Offset = "0x1217160", VA = "0x1217160")]
		protected VirtualInput()
		{
		}
	}
}
namespace UnityStandardAssets.CrossPlatformInput.PlatformSpecific
{
	[Token(Token = "0x200002B")]
	public class MobileInput : VirtualInput
	{
		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x121699C", Offset = "0x121699C", VA = "0x121699C")]
		private void AddButton(string name)
		{
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x1216A3C", Offset = "0x1216A3C", VA = "0x1216A3C")]
		private void AddAxes(string name)
		{
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x1216AD4", Offset = "0x1216AD4", VA = "0x1216AD4", Slot = "4")]
		public override float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x1216B70", Offset = "0x1216B70", VA = "0x1216B70", Slot = "8")]
		public override void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x1216C28", Offset = "0x1216C28", VA = "0x1216C28", Slot = "9")]
		public override void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x1216CD4", Offset = "0x1216CD4", VA = "0x1216CD4", Slot = "10")]
		public override void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x1216D74", Offset = "0x1216D74", VA = "0x1216D74", Slot = "11")]
		public override void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x1216E14", Offset = "0x1216E14", VA = "0x1216E14", Slot = "12")]
		public override void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x1216EB0", Offset = "0x1216EB0", VA = "0x1216EB0", Slot = "13")]
		public override void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x1216F58", Offset = "0x1216F58", VA = "0x1216F58", Slot = "6")]
		public override bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x1217008", Offset = "0x1217008", VA = "0x1217008", Slot = "7")]
		public override bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x12170B8", Offset = "0x12170B8", VA = "0x12170B8", Slot = "5")]
		public override bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x1217154", Offset = "0x1217154", VA = "0x1217154", Slot = "14")]
		public override Vector3 MousePosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x1214F00", Offset = "0x1214F00", VA = "0x1214F00")]
		public MobileInput()
		{
		}
	}
	[Token(Token = "0x200002C")]
	public class StandaloneInput : VirtualInput
	{
		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x1217244", Offset = "0x1217244", VA = "0x1217244", Slot = "4")]
		public override float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x1217258", Offset = "0x1217258", VA = "0x1217258", Slot = "5")]
		public override bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x1217264", Offset = "0x1217264", VA = "0x1217264", Slot = "6")]
		public override bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x1217270", Offset = "0x1217270", VA = "0x1217270", Slot = "7")]
		public override bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x121727C", Offset = "0x121727C", VA = "0x121727C", Slot = "8")]
		public override void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x12172EC", Offset = "0x12172EC", VA = "0x12172EC", Slot = "9")]
		public override void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x121735C", Offset = "0x121735C", VA = "0x121735C", Slot = "10")]
		public override void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x12173CC", Offset = "0x12173CC", VA = "0x12173CC", Slot = "11")]
		public override void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x121743C", Offset = "0x121743C", VA = "0x121743C", Slot = "12")]
		public override void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x12174AC", Offset = "0x12174AC", VA = "0x12174AC", Slot = "13")]
		public override void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x121751C", Offset = "0x121751C", VA = "0x121751C", Slot = "14")]
		public override Vector3 MousePosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x1214F04", Offset = "0x1214F04", VA = "0x1214F04")]
		public StandaloneInput()
		{
		}
	}
}
namespace UnityStandardAssets.Cameras
{
	[Token(Token = "0x200002D")]
	public abstract class AbstractTargetFollower : MonoBehaviour
	{
		[Token(Token = "0x2000081")]
		public enum UpdateType
		{
			[Token(Token = "0x4000269")]
			FixedUpdate,
			[Token(Token = "0x400026A")]
			LateUpdate,
			[Token(Token = "0x400026B")]
			ManualUpdate
		}

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected Transform m_Target;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool m_AutoTargetPlayer;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private UpdateType m_UpdateType;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected Rigidbody targetRigidbody;

		[Token(Token = "0x1700000C")]
		public Transform Target
		{
			[Token(Token = "0x6000106")]
			[Address(RVA = "0x1212228", Offset = "0x1212228", VA = "0x1212228")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x1211E1C", Offset = "0x1211E1C", VA = "0x1211E1C", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x1211F9C", Offset = "0x1211F9C", VA = "0x1211F9C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x1212070", Offset = "0x1212070", VA = "0x1212070")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x1212148", Offset = "0x1212148", VA = "0x1212148")]
		public void ManualUpdate()
		{
		}

		[Token(Token = "0x6000103")]
		protected abstract void FollowTarget(float deltaTime);

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x1211EDC", Offset = "0x1211EDC", VA = "0x1211EDC")]
		public void FindAndTargetPlayer()
		{
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x1212220", Offset = "0x1212220", VA = "0x1212220", Slot = "6")]
		public virtual void SetTarget(Transform newTransform)
		{
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x1212230", Offset = "0x1212230", VA = "0x1212230")]
		protected AbstractTargetFollower()
		{
		}
	}
	[Token(Token = "0x200002E")]
	[ExecuteInEditMode]
	public class AutoCam : PivotBasedCameraRig
	{
		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float m_MoveSpeed;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float m_TurnSpeed;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float m_RollSpeed;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private bool m_FollowVelocity;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		[SerializeField]
		private bool m_FollowTilt;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float m_SpinTurnLimit;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float m_TargetVelocityLowerLimit;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float m_SmoothTurnTime;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float m_LastFlatAngle;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float m_CurrentTurnAmount;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float m_TurnSpeedVelocityChange;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Vector3 m_RollUp;

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x1212240", Offset = "0x1212240", VA = "0x1212240", Slot = "5")]
		protected override void FollowTarget(float deltaTime)
		{
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x12127C4", Offset = "0x12127C4", VA = "0x12127C4")]
		public AutoCam()
		{
		}
	}
	[Token(Token = "0x200002F")]
	public class FreeLookCam : PivotBasedCameraRig
	{
		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float m_MoveSpeed;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9941F4", Offset = "0x9941F4")]
		[SerializeField]
		private float m_TurnSpeed;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float m_TurnSmoothing;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float m_TiltMax;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float m_TiltMin;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private bool m_LockCursor;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		[SerializeField]
		private bool m_VerticalAutoReturn;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float m_LookAngle;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float m_TiltAngle;

		[Token(Token = "0x40000C8")]
		private const float k_LookDistance = 100f;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 m_PivotEulers;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Quaternion m_PivotTargetRot;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Quaternion m_TransformTargetRot;

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x1212880", Offset = "0x1212880", VA = "0x1212880", Slot = "7")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x12129DC", Offset = "0x12129DC", VA = "0x12129DC")]
		protected void Update()
		{
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x1212DD0", Offset = "0x1212DD0", VA = "0x1212DD0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x1212DF4", Offset = "0x1212DF4", VA = "0x1212DF4", Slot = "5")]
		protected override void FollowTarget(float deltaTime)
		{
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x1212A3C", Offset = "0x1212A3C", VA = "0x1212A3C")]
		private void HandleRotationMovement()
		{
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x1212FC4", Offset = "0x1212FC4", VA = "0x1212FC4")]
		public FreeLookCam()
		{
		}
	}
	[Token(Token = "0x2000030")]
	public class HandHeldCam : LookatTarget
	{
		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float m_SwaySpeed;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float m_BaseSwayAmount;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float m_TrackingSwayAmount;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9942B4", Offset = "0x9942B4")]
		[SerializeField]
		private float m_TrackingBias;

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x1212FEC", Offset = "0x1212FEC", VA = "0x1212FEC", Slot = "5")]
		protected override void FollowTarget(float deltaTime)
		{
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x1213498", Offset = "0x1213498", VA = "0x1213498")]
		public HandHeldCam()
		{
		}
	}
	[Token(Token = "0x2000031")]
	public class LookatTarget : AbstractTargetFollower
	{
		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Vector2 m_RotationRange;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float m_FollowSpeed;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Vector3 m_FollowAngles;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Quaternion m_OriginalRotation;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected Vector3 m_FollowVelocity;

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x12134D4", Offset = "0x12134D4", VA = "0x12134D4", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x121317C", Offset = "0x121317C", VA = "0x121317C", Slot = "5")]
		protected override void FollowTarget(float deltaTime)
		{
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x12134BC", Offset = "0x12134BC", VA = "0x12134BC")]
		public LookatTarget()
		{
		}
	}
	[Token(Token = "0x2000032")]
	public abstract class PivotBasedCameraRig : AbstractTargetFollower
	{
		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected Transform m_Cam;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected Transform m_Pivot;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected Vector3 m_LastTargetPosition;

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x1212940", Offset = "0x1212940", VA = "0x1212940", Slot = "7")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x1212870", Offset = "0x1212870", VA = "0x1212870")]
		protected PivotBasedCameraRig()
		{
		}
	}
	[Token(Token = "0x2000033")]
	public class ProtectCameraFromWallClip : MonoBehaviour
	{
		[Token(Token = "0x2000082")]
		public class RayHitComparer : IComparer
		{
			[Token(Token = "0x6000333")]
			[Address(RVA = "0x1213D6C", Offset = "0x1213D6C", VA = "0x1213D6C", Slot = "4")]
			public int Compare(object x, object y)
			{
				return default(int);
			}

			[Token(Token = "0x6000334")]
			[Address(RVA = "0x1213638", Offset = "0x1213638", VA = "0x1213638")]
			public RayHitComparer()
			{
			}
		}

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float clipMoveTime;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float returnTime;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float sphereCastRadius;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool visualiseInEditor;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float closestDistance;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994314", Offset = "0x994314")]
		private bool <protecting>k__BackingField;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string dontClipTag;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform m_Cam;

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Transform m_Pivot;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float m_OriginalDist;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float m_MoveVelocity;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float m_CurrentDist;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Ray m_Ray;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private RaycastHit[] m_Hits;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private RayHitComparer m_RayHitComparer;

		[Token(Token = "0x1700000D")]
		public bool protecting
		{
			[Token(Token = "0x6000117")]
			[Address(RVA = "0x1213518", Offset = "0x1213518", VA = "0x1213518")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x995334", Offset = "0x995334")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000118")]
			[Address(RVA = "0x1213520", Offset = "0x1213520", VA = "0x1213520")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x995344", Offset = "0x995344")]
			private set
			{
			}
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x121352C", Offset = "0x121352C", VA = "0x121352C")]
		private void Start()
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x1213640", Offset = "0x1213640", VA = "0x1213640")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x1213CE4", Offset = "0x1213CE4", VA = "0x1213CE4")]
		public ProtectCameraFromWallClip()
		{
		}
	}
	[Token(Token = "0x2000034")]
	public class TargetFieldOfView : AbstractTargetFollower
	{
		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_FovAdjustTime;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float m_ZoomAmountMultiplier;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool m_IncludeEffectsInSize;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float m_BoundSize;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float m_FovAdjustVelocity;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Camera m_Cam;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform m_LastTarget;

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x1213E88", Offset = "0x1213E88", VA = "0x1213E88", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x12140F0", Offset = "0x12140F0", VA = "0x12140F0", Slot = "5")]
		protected override void FollowTarget(float deltaTime)
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x1214274", Offset = "0x1214274", VA = "0x1214274", Slot = "6")]
		public override void SetTarget(Transform newTransform)
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x1213F04", Offset = "0x1213F04", VA = "0x1213F04")]
		public static float MaxBoundsExtent(Transform obj, bool includeEffects)
		{
			return default(float);
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x12142B0", Offset = "0x12142B0", VA = "0x12142B0")]
		public TargetFieldOfView()
		{
		}
	}
}
namespace Assets.Plugins.ZMSDKlib_CS
{
	[Token(Token = "0x2000035")]
	internal class HttpHelper
	{
		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly string DefaultUserAgent;

		[Token(Token = "0x6000121")]
		[Address(RVA = "0xE3E94C", Offset = "0xE3E94C", VA = "0xE3E94C")]
		private static bool CheckValidationResult(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors errors)
		{
			return default(bool);
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0xE3E954", Offset = "0xE3E954", VA = "0xE3E954")]
		public static HttpWebResponse CreatePostHttpResponse(string url, string postData, Encoding charset)
		{
			return null;
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0xE3EC94", Offset = "0xE3EC94", VA = "0xE3EC94")]
		public static string HttpPost(string url, string parm)
		{
			return null;
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0xE3ED74", Offset = "0xE3ED74", VA = "0xE3ED74")]
		public HttpHelper()
		{
		}
	}
	[Token(Token = "0x2000036")]
	internal class MD5
	{
		[Token(Token = "0x6000126")]
		[Address(RVA = "0xE3EDD8", Offset = "0xE3EDD8", VA = "0xE3EDD8")]
		public static string GetFileMD5Unsafely(string fileName)
		{
			return null;
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0xE3F008", Offset = "0xE3F008", VA = "0xE3F008")]
		public static string MD5Encrypt(string password)
		{
			return null;
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0xE3F170", Offset = "0xE3F170", VA = "0xE3F170")]
		public MD5()
		{
		}
	}
	[Token(Token = "0x2000037")]
	internal class OpenAPIHelper
	{
		[Token(Token = "0x40000EF")]
		private const string DLL = "ZamerOpenAPI";

		[PreserveSig]
		[Token(Token = "0x6000129")]
		[Address(RVA = "0xE3F178", Offset = "0xE3F178", VA = "0xE3F178")]
		private static extern bool TransferCommonParms(string appKey, string secret);

		[PreserveSig]
		[Token(Token = "0x600012A")]
		[Address(RVA = "0xE3F23C", Offset = "0xE3F23C", VA = "0xE3F23C")]
		private static extern IntPtr UploadGameProgress(uint gameId, string gameName, uint barrier, uint score, string gameStoreDt, string file);

		[PreserveSig]
		[Token(Token = "0x600012B")]
		[Address(RVA = "0xE3F330", Offset = "0xE3F330", VA = "0xE3F330")]
		private static extern IntPtr QueryGameProgress(uint gameId);

		[PreserveSig]
		[Token(Token = "0x600012C")]
		[Address(RVA = "0xE3F3CC", Offset = "0xE3F3CC", VA = "0xE3F3CC")]
		private static extern bool DownloadGameProgress(string url, string filename);

		[PreserveSig]
		[Token(Token = "0x600012D")]
		[Address(RVA = "0xE3F490", Offset = "0xE3F490", VA = "0xE3F490")]
		private static extern IntPtr SaveGameProperty(uint gameId, uint itemSpecId, string itemVal, string actionType);

		[PreserveSig]
		[Token(Token = "0x600012E")]
		[Address(RVA = "0xE3F564", Offset = "0xE3F564", VA = "0xE3F564")]
		private static extern IntPtr QueryGameProperty(uint gameId);

		[PreserveSig]
		[Token(Token = "0x600012F")]
		[Address(RVA = "0xE3F600", Offset = "0xE3F600", VA = "0xE3F600")]
		private static extern IntPtr GetOpenId();

		[PreserveSig]
		[Token(Token = "0x6000130")]
		[Address(RVA = "0xE3F68C", Offset = "0xE3F68C", VA = "0xE3F68C")]
		private static extern IntPtr GetNickname();

		[Token(Token = "0x6000131")]
		[Address(RVA = "0xE3F718", Offset = "0xE3F718", VA = "0xE3F718")]
		public static bool TransferCommonParmsAPI(string appKey, string secret)
		{
			return default(bool);
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0xE3F7A0", Offset = "0xE3F7A0", VA = "0xE3F7A0")]
		public static string UploadGameProgressAPI(uint gameId, string gameName, uint barrier, uint score, string gameStoreDt, string file)
		{
			return null;
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0xE3F8A0", Offset = "0xE3F8A0", VA = "0xE3F8A0")]
		public static string QueryGameProgressAPI(uint gameId)
		{
			return null;
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0xE3F960", Offset = "0xE3F960", VA = "0xE3F960")]
		public static bool DownloadGameProgressAPI(string url, string filename)
		{
			return default(bool);
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0xE3F9E8", Offset = "0xE3F9E8", VA = "0xE3F9E8")]
		public static string SaveGamePropertyAPI(uint gameId, uint itemSpecId, string itemVal, string actionType)
		{
			return null;
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0xE3FAD0", Offset = "0xE3FAD0", VA = "0xE3FAD0")]
		public static string QueryGamePropertyAPI(uint gameId)
		{
			return null;
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0xE3FB90", Offset = "0xE3FB90", VA = "0xE3FB90")]
		public static string GetOpenIdAPI()
		{
			return null;
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0xE3FC48", Offset = "0xE3FC48", VA = "0xE3FC48")]
		public static string GetNicknameAPI()
		{
			return null;
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0xE3FD00", Offset = "0xE3FD00", VA = "0xE3FD00")]
		public OpenAPIHelper()
		{
		}
	}
	[Token(Token = "0x2000038")]
	internal class ZMVRSDKHelper
	{
		[PreserveSig]
		[Token(Token = "0x600013A")]
		[Address(RVA = "0xE3FD08", Offset = "0xE3FD08", VA = "0xE3FD08")]
		private static extern IntPtr CheckToken(string developID, string contentID, string token);

		[PreserveSig]
		[Token(Token = "0x600013B")]
		[Address(RVA = "0xE3FDFC", Offset = "0xE3FDFC", VA = "0xE3FDFC")]
		private static extern IntPtr GetDeviceSN();

		[PreserveSig]
		[Token(Token = "0x600013C")]
		[Address(RVA = "0xE3FE84", Offset = "0xE3FE84", VA = "0xE3FE84")]
		private static extern int GetUserId();

		[PreserveSig]
		[Token(Token = "0x600013D")]
		[Address(RVA = "0xE3FF0C", Offset = "0xE3FF0C", VA = "0xE3FF0C")]
		private static extern int GetMerchantId();

		[Token(Token = "0x600013E")]
		[Address(RVA = "0xE3FF94", Offset = "0xE3FF94", VA = "0xE3FF94")]
		public static int ZMVRCheckDll(string token, string checkcode, string d_id, string c_id)
		{
			return default(int);
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0xE4131C", Offset = "0xE4131C", VA = "0xE4131C")]
		public static string ZMStartBillingThread(string token, string checkCode, string developID, string gameID)
		{
			return null;
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0xE413AC", Offset = "0xE413AC", VA = "0xE413AC")]
		public static int ZMGetUserId()
		{
			return default(int);
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0xE41468", Offset = "0xE41468", VA = "0xE41468")]
		public static int ZMGetMerchantId()
		{
			return default(int);
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0xE41524", Offset = "0xE41524", VA = "0xE41524")]
		public static string ZMGetDeviceSN()
		{
			return null;
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0xE415F0", Offset = "0xE415F0", VA = "0xE415F0")]
		public ZMVRSDKHelper()
		{
		}
	}
}
namespace MEC
{
	[Token(Token = "0x2000039")]
	public class Timing : MonoBehaviour
	{
		[Token(Token = "0x2000083")]
		private struct ProcessIndex : IEquatable<ProcessIndex>
		{
			[Token(Token = "0x400026C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Segment seg;

			[Token(Token = "0x400026D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int i;

			[Token(Token = "0x6000335")]
			[Address(RVA = "0xA668BC", Offset = "0xA668BC", VA = "0xA668BC", Slot = "4")]
			public bool Equals(ProcessIndex other)
			{
				return default(bool);
			}

			[Token(Token = "0x6000336")]
			[Address(RVA = "0xA668E4", Offset = "0xA668E4", VA = "0xA668E4", Slot = "0")]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6000337")]
			[Address(RVA = "0x120AF34", Offset = "0x120AF34", VA = "0x120AF34")]
			public static bool operator ==(ProcessIndex a, ProcessIndex b)
			{
				return default(bool);
			}

			[Token(Token = "0x6000338")]
			[Address(RVA = "0x120AF54", Offset = "0x120AF54", VA = "0x120AF54")]
			public static bool operator !=(ProcessIndex a, ProcessIndex b)
			{
				return default(bool);
			}

			[Token(Token = "0x6000339")]
			[Address(RVA = "0xA668EC", Offset = "0xA668EC", VA = "0xA668EC", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Token(Token = "0x2000084")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x993D14", Offset = "0x993D14")]
		private sealed class <_InjectDelay>d__123 : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400026E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400026F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private float <>2__current;

			[Token(Token = "0x4000270")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Timing <>4__this;

			[Token(Token = "0x4000271")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float delayTime;

			[Token(Token = "0x4000272")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public IEnumerator<float> proc;

			[Token(Token = "0x1700004D")]
			private float System.Collections.Generic.IEnumerator<System.Single>.Current
			{
				[Token(Token = "0x600033D")]
				[Address(RVA = "0x120A4A8", Offset = "0x120A4A8", VA = "0x120A4A8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x1700004E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600033F")]
				[Address(RVA = "0x120A514", Offset = "0x120A514", VA = "0x120A514", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600033A")]
			[Address(RVA = "0x120A344", Offset = "0x120A344", VA = "0x120A344")]
			[DebuggerHidden]
			public <_InjectDelay>d__123(int <>1__state)
			{
			}

			[Token(Token = "0x600033B")]
			[Address(RVA = "0x120A370", Offset = "0x120A370", VA = "0x120A370", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600033C")]
			[Address(RVA = "0x120A374", Offset = "0x120A374", VA = "0x120A374", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600033E")]
			[Address(RVA = "0x120A4B0", Offset = "0x120A4B0", VA = "0x120A4B0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000085")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x993D24", Offset = "0x993D24")]
		private sealed class <_StartWhenDone>d__131 : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000273")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000274")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private float <>2__current;

			[Token(Token = "0x4000275")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Timing <>4__this;

			[Token(Token = "0x4000276")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CoroutineHandle handle;

			[Token(Token = "0x4000277")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public IEnumerator<float> proc;

			[Token(Token = "0x1700004F")]
			private float System.Collections.Generic.IEnumerator<System.Single>.Current
			{
				[Token(Token = "0x6000344")]
				[Address(RVA = "0x120A940", Offset = "0x120A940", VA = "0x120A940", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x17000050")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000346")]
				[Address(RVA = "0x120A9AC", Offset = "0x120A9AC", VA = "0x120A9AC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000340")]
			[Address(RVA = "0x120A578", Offset = "0x120A578", VA = "0x120A578")]
			[DebuggerHidden]
			public <_StartWhenDone>d__131(int <>1__state)
			{
			}

			[Token(Token = "0x6000341")]
			[Address(RVA = "0x120A5A4", Offset = "0x120A5A4", VA = "0x120A5A4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000342")]
			[Address(RVA = "0x120A600", Offset = "0x120A600", VA = "0x120A600", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000343")]
			[Address(RVA = "0x120A5D0", Offset = "0x120A5D0", VA = "0x120A5D0")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000345")]
			[Address(RVA = "0x120A948", Offset = "0x120A948", VA = "0x120A948", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000086")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x993D34", Offset = "0x993D34")]
		private sealed class <_StartWhenDone>d__137 : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000278")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000279")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private float <>2__current;

			[Token(Token = "0x400027A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public AsyncOperation operation;

			[Token(Token = "0x400027B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public IEnumerator<float> pausedProc;

			[Token(Token = "0x17000051")]
			private float System.Collections.Generic.IEnumerator<System.Single>.Current
			{
				[Token(Token = "0x600034A")]
				[Address(RVA = "0x120AB70", Offset = "0x120AB70", VA = "0x120AB70", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x17000052")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600034C")]
				[Address(RVA = "0x120ABDC", Offset = "0x120ABDC", VA = "0x120ABDC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000347")]
			[Address(RVA = "0x120AA10", Offset = "0x120AA10", VA = "0x120AA10")]
			[DebuggerHidden]
			public <_StartWhenDone>d__137(int <>1__state)
			{
			}

			[Token(Token = "0x6000348")]
			[Address(RVA = "0x120AA3C", Offset = "0x120AA3C", VA = "0x120AA3C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000349")]
			[Address(RVA = "0x120AA40", Offset = "0x120AA40", VA = "0x120AA40", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600034B")]
			[Address(RVA = "0x120AB78", Offset = "0x120AB78", VA = "0x120AB78", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000087")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x993D44", Offset = "0x993D44")]
		private sealed class <_StartWhenDone>d__139 : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400027C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400027D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private float <>2__current;

			[Token(Token = "0x400027E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public CustomYieldInstruction operation;

			[Token(Token = "0x400027F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public IEnumerator<float> pausedProc;

			[Token(Token = "0x17000053")]
			private float System.Collections.Generic.IEnumerator<System.Single>.Current
			{
				[Token(Token = "0x6000350")]
				[Address(RVA = "0x120ADA4", Offset = "0x120ADA4", VA = "0x120ADA4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x17000054")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000352")]
				[Address(RVA = "0x120AE10", Offset = "0x120AE10", VA = "0x120AE10", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600034D")]
			[Address(RVA = "0x120AC40", Offset = "0x120AC40", VA = "0x120AC40")]
			[DebuggerHidden]
			public <_StartWhenDone>d__139(int <>1__state)
			{
			}

			[Token(Token = "0x600034E")]
			[Address(RVA = "0x120AC6C", Offset = "0x120AC6C", VA = "0x120AC6C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600034F")]
			[Address(RVA = "0x120AC70", Offset = "0x120AC70", VA = "0x120AC70", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000351")]
			[Address(RVA = "0x120ADAC", Offset = "0x120ADAC", VA = "0x120ADAC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000088")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x993D54", Offset = "0x993D54")]
		private sealed class <_DelayedCall>d__150 : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000280")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000281")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private float <>2__current;

			[Token(Token = "0x4000282")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Timing <>4__this;

			[Token(Token = "0x4000283")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float delay;

			[Token(Token = "0x4000284")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public GameObject cancelWith;

			[Token(Token = "0x4000285")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Action action;

			[Token(Token = "0x17000055")]
			private float System.Collections.Generic.IEnumerator<System.Single>.Current
			{
				[Token(Token = "0x6000356")]
				[Address(RVA = "0xE57680", Offset = "0xE57680", VA = "0xE57680", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x17000056")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000358")]
				[Address(RVA = "0xE576EC", Offset = "0xE576EC", VA = "0xE576EC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000353")]
			[Address(RVA = "0xE56ABC", Offset = "0xE56ABC", VA = "0xE56ABC")]
			[DebuggerHidden]
			public <_DelayedCall>d__150(int <>1__state)
			{
			}

			[Token(Token = "0x6000354")]
			[Address(RVA = "0xE57580", Offset = "0xE57580", VA = "0xE57580", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000355")]
			[Address(RVA = "0xE57584", Offset = "0xE57584", VA = "0xE57584", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000357")]
			[Address(RVA = "0xE57688", Offset = "0xE57688", VA = "0xE57688", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000089")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x993D64", Offset = "0x993D64")]
		private sealed class <_CallContinuously>d__159 : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000286")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000287")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private float <>2__current;

			[Token(Token = "0x4000288")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Timing <>4__this;

			[Token(Token = "0x4000289")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float period;

			[Token(Token = "0x400028A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action action;

			[Token(Token = "0x400028B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float timeframe;

			[Token(Token = "0x400028C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Action onDone;

			[Token(Token = "0x400028D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private double <startTime>5__2;

			[Token(Token = "0x17000057")]
			private float System.Collections.Generic.IEnumerator<System.Single>.Current
			{
				[Token(Token = "0x600035C")]
				[Address(RVA = "0xE574B0", Offset = "0xE574B0", VA = "0xE574B0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x17000058")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600035E")]
				[Address(RVA = "0xE5751C", Offset = "0xE5751C", VA = "0xE5751C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000359")]
			[Address(RVA = "0xE56FA8", Offset = "0xE56FA8", VA = "0xE56FA8")]
			[DebuggerHidden]
			public <_CallContinuously>d__159(int <>1__state)
			{
			}

			[Token(Token = "0x600035A")]
			[Address(RVA = "0xE573CC", Offset = "0xE573CC", VA = "0xE573CC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600035B")]
			[Address(RVA = "0xE573D0", Offset = "0xE573D0", VA = "0xE573D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600035D")]
			[Address(RVA = "0xE574B8", Offset = "0xE574B8", VA = "0xE574B8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200008A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x993D74", Offset = "0x993D74")]
		private sealed class <_CallContinuously>d__168<T> : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400028E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <>1__state;

			[Token(Token = "0x400028F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private float <>2__current;

			[Token(Token = "0x4000290")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Timing <>4__this;

			[Token(Token = "0x4000291")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float period;

			[Token(Token = "0x4000292")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<T> action;

			[Token(Token = "0x4000293")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public T reference;

			[Token(Token = "0x4000294")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float timeframe;

			[Token(Token = "0x4000295")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<T> onDone;

			[Token(Token = "0x4000296")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private double <startTime>5__2;

			[Token(Token = "0x17000059")]
			private float System.Collections.Generic.IEnumerator<System.Single>.Current
			{
				[Token(Token = "0x6000362")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x1700005A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000364")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600035F")]
			[DebuggerHidden]
			public <_CallContinuously>d__168(int <>1__state)
			{
			}

			[Token(Token = "0x6000360")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000361")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000363")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x994354", Offset = "0x994354")]
		public float TimeBetweenSlowUpdateCalls;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x99438C", Offset = "0x99438C")]
		public DebugInfoType ProfilerDebugAmount;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9943C4", Offset = "0x9943C4")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x9943C4", Offset = "0x9943C4")]
		public int UpdateCoroutines;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x994414", Offset = "0x994414")]
		public int FixedUpdateCoroutines;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x99444C", Offset = "0x99444C")]
		public int LateUpdateCoroutines;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x994484", Offset = "0x994484")]
		public int SlowUpdateCoroutines;

		[NonSerialized]
		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float localTime;

		[NonSerialized]
		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float deltaTime;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Func<IEnumerator<float>, CoroutineHandle, IEnumerator<float>> ReplacementFunction;

		[Token(Token = "0x40000FA")]
		public const float WaitForOneFrame = float.NegativeInfinity;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9944CC", Offset = "0x9944CC")]
		private static Thread <MainThread>k__BackingField;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9944DC", Offset = "0x9944DC")]
		private CoroutineHandle <currentCoroutine>k__BackingField;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static object _tmpRef;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static bool _tmpBool;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private static CoroutineHandle _tmpHandle;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int _currentUpdateFrame;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int _currentLateUpdateFrame;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private int _currentSlowUpdateFrame;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int _nextUpdateProcessSlot;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int _nextLateUpdateProcessSlot;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int _nextFixedUpdateProcessSlot;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int _nextSlowUpdateProcessSlot;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int _lastUpdateProcessSlot;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private int _lastLateUpdateProcessSlot;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int _lastFixedUpdateProcessSlot;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private int _lastSlowUpdateProcessSlot;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float _lastUpdateTime;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float _lastLateUpdateTime;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float _lastFixedUpdateTime;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float _lastSlowUpdateTime;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float _lastSlowUpdateDeltaTime;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private ushort _framesSinceUpdate;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7E")]
		private ushort _expansions;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		[HideInInspector]
		private byte _instanceID;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private readonly Dictionary<CoroutineHandle, HashSet<CoroutineHandle>> _waitingTriggers;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private readonly HashSet<CoroutineHandle> _allWaiting;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private readonly Dictionary<CoroutineHandle, ProcessIndex> _handleToIndex;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private readonly Dictionary<ProcessIndex, CoroutineHandle> _indexToHandle;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private readonly Dictionary<CoroutineHandle, string> _processTags;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private readonly Dictionary<string, HashSet<CoroutineHandle>> _taggedProcesses;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private IEnumerator<float>[] UpdateProcesses;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private IEnumerator<float>[] LateUpdateProcesses;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private IEnumerator<float>[] FixedUpdateProcesses;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private IEnumerator<float>[] SlowUpdateProcesses;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private bool[] UpdatePaused;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool[] LateUpdatePaused;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private bool[] FixedUpdatePaused;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private bool[] SlowUpdatePaused;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private bool[] UpdateHeld;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private bool[] LateUpdateHeld;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private bool[] FixedUpdateHeld;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private bool[] SlowUpdateHeld;

		[Token(Token = "0x4000125")]
		private const ushort FramesUntilMaintenance = 64;

		[Token(Token = "0x4000126")]
		private const int ProcessArrayChunkSize = 64;

		[Token(Token = "0x4000127")]
		private const int InitialBufferSizeLarge = 256;

		[Token(Token = "0x4000128")]
		private const int InitialBufferSizeMedium = 64;

		[Token(Token = "0x4000129")]
		private const int InitialBufferSizeSmall = 8;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static Timing[] ActiveInstances;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static Timing _instance;

		[Token(Token = "0x1700000E")]
		public static float LocalTime
		{
			[Token(Token = "0x6000144")]
			[Address(RVA = "0xE4CEB8", Offset = "0xE4CEB8", VA = "0xE4CEB8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700000F")]
		public static float DeltaTime
		{
			[Token(Token = "0x6000145")]
			[Address(RVA = "0xE4D170", Offset = "0xE4D170", VA = "0xE4D170")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000010")]
		public static Thread MainThread
		{
			[Token(Token = "0x6000148")]
			[Address(RVA = "0xE4D3BC", Offset = "0xE4D3BC", VA = "0xE4D3BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x995374", Offset = "0x995374")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000149")]
			[Address(RVA = "0xE4D424", Offset = "0xE4D424", VA = "0xE4D424")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x995384", Offset = "0x995384")]
			private set
			{
			}
		}

		[Token(Token = "0x17000011")]
		public static CoroutineHandle CurrentCoroutine
		{
			[Token(Token = "0x600014A")]
			[Address(RVA = "0xE4D494", Offset = "0xE4D494", VA = "0xE4D494")]
			get
			{
				return default(CoroutineHandle);
			}
		}

		[Token(Token = "0x17000012")]
		public CoroutineHandle currentCoroutine
		{
			[Token(Token = "0x600014B")]
			[Address(RVA = "0xE4D644", Offset = "0xE4D644", VA = "0xE4D644")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x995394", Offset = "0x995394")]
			get
			{
				return default(CoroutineHandle);
			}
			[Token(Token = "0x600014C")]
			[Address(RVA = "0xE4D64C", Offset = "0xE4D64C", VA = "0xE4D64C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9953A4", Offset = "0x9953A4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000013")]
		public static Timing Instance
		{
			[Token(Token = "0x600014D")]
			[Address(RVA = "0xE4CF24", Offset = "0xE4CF24", VA = "0xE4CF24")]
			get
			{
				return null;
			}
			[Token(Token = "0x600014E")]
			[Address(RVA = "0xE4D8B4", Offset = "0xE4D8B4", VA = "0xE4D8B4")]
			set
			{
			}
		}

		[Token(Token = "0x14000001")]
		public static event Action OnPreExecute
		{
			[Token(Token = "0x6000146")]
			[Address(RVA = "0xE4D1DC", Offset = "0xE4D1DC", VA = "0xE4D1DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x995354", Offset = "0x995354")]
			add
			{
			}
			[Token(Token = "0x6000147")]
			[Address(RVA = "0xE4D2CC", Offset = "0xE4D2CC", VA = "0xE4D2CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x995364", Offset = "0x995364")]
			remove
			{
			}
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0xE4D924", Offset = "0xE4D924", VA = "0xE4D924")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0xE4DA08", Offset = "0xE4DA08", VA = "0xE4DA08")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0xE4DB38", Offset = "0xE4DB38", VA = "0xE4DB38")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0xE4D654", Offset = "0xE4D654", VA = "0xE4D654")]
		private void InitializeInstanceID()
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0xE4DC28", Offset = "0xE4DC28", VA = "0xE4DC28")]
		private void Update()
		{
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0xE4FB94", Offset = "0xE4FB94", VA = "0xE4FB94")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0xE50308", Offset = "0xE50308", VA = "0xE50308")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0xE4ED04", Offset = "0xE4ED04", VA = "0xE4ED04")]
		private void RemoveUnused()
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0xE4CA14", Offset = "0xE4CA14", VA = "0xE4CA14")]
		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0xE4CB54", Offset = "0xE4CB54", VA = "0xE4CB54")]
		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0xE4CC98", Offset = "0xE4CC98", VA = "0xE4CC98")]
		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, Segment segment)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0xE4CDE4", Offset = "0xE4CDE4", VA = "0xE4CDE4")]
		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, Segment segment, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0xE52330", Offset = "0xE52330", VA = "0xE52330")]
		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0xE52394", Offset = "0xE52394", VA = "0xE52394")]
		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0xE523FC", Offset = "0xE523FC", VA = "0xE523FC")]
		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, Segment segment)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0xE52464", Offset = "0xE52464", VA = "0xE52464")]
		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, Segment segment, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0xE50E00", Offset = "0xE50E00", VA = "0xE50E00")]
		private CoroutineHandle RunCoroutineInternal(IEnumerator<float> coroutine, Segment segment, string tag, CoroutineHandle handle, bool prewarm)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0xE52618", Offset = "0xE52618", VA = "0xE52618")]
		public static int KillCoroutines()
		{
			return default(int);
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0xE526F4", Offset = "0xE526F4", VA = "0xE526F4")]
		public int KillCoroutinesOnInstance()
		{
			return default(int);
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0xE5299C", Offset = "0xE5299C", VA = "0xE5299C")]
		public static int KillCoroutines(CoroutineHandle handle)
		{
			return default(int);
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0xE4EC1C", Offset = "0xE4EC1C", VA = "0xE4EC1C")]
		public int KillCoroutinesOnInstance(CoroutineHandle handle)
		{
			return default(int);
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0xE52C1C", Offset = "0xE52C1C", VA = "0xE52C1C")]
		public static int KillCoroutines(string tag)
		{
			return default(int);
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0xE52D0C", Offset = "0xE52D0C", VA = "0xE52D0C")]
		public int KillCoroutinesOnInstance(string tag)
		{
			return default(int);
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0xE52FA4", Offset = "0xE52FA4", VA = "0xE52FA4")]
		public static int PauseCoroutines()
		{
			return default(int);
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0xE53080", Offset = "0xE53080", VA = "0xE53080")]
		public int PauseCoroutinesOnInstance()
		{
			return default(int);
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0xE53A1C", Offset = "0xE53A1C", VA = "0xE53A1C")]
		public static int PauseCoroutines(CoroutineHandle handle)
		{
			return default(int);
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0xE53B3C", Offset = "0xE53B3C", VA = "0xE53B3C")]
		public int PauseCoroutinesOnInstance(CoroutineHandle handle)
		{
			return default(int);
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0xE54298", Offset = "0xE54298", VA = "0xE54298")]
		public static int PauseCoroutines(string tag)
		{
			return default(int);
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0xE54388", Offset = "0xE54388", VA = "0xE54388")]
		public int PauseCoroutinesOnInstance(string tag)
		{
			return default(int);
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0xE544D8", Offset = "0xE544D8", VA = "0xE544D8")]
		public static int ResumeCoroutines()
		{
			return default(int);
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0xE545B4", Offset = "0xE545B4", VA = "0xE545B4")]
		public int ResumeCoroutinesOnInstance()
		{
			return default(int);
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0xE5479C", Offset = "0xE5479C", VA = "0xE5479C")]
		public static int ResumeCoroutines(CoroutineHandle handle)
		{
			return default(int);
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0xE548BC", Offset = "0xE548BC", VA = "0xE548BC")]
		public int ResumeCoroutinesOnInstance(CoroutineHandle handle)
		{
			return default(int);
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0xE5498C", Offset = "0xE5498C", VA = "0xE5498C")]
		public static int ResumeCoroutines(string tag)
		{
			return default(int);
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0xE54A7C", Offset = "0xE54A7C", VA = "0xE54A7C")]
		public int ResumeCoroutinesOnInstance(string tag)
		{
			return default(int);
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0xE4EA90", Offset = "0xE4EA90", VA = "0xE4EA90")]
		private bool UpdateTimeValues(Segment segment)
		{
			return default(bool);
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0xE538C0", Offset = "0xE538C0", VA = "0xE538C0")]
		private float GetSegmentTime(Segment segment)
		{
			return default(float);
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0xE52ABC", Offset = "0xE52ABC", VA = "0xE52ABC")]
		public static Timing GetInstance(byte ID)
		{
			return null;
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0xE524D8", Offset = "0xE524D8", VA = "0xE524D8")]
		private void AddTag(string tag, CoroutineHandle coindex)
		{
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0xE50CA4", Offset = "0xE50CA4", VA = "0xE50CA4")]
		private void RemoveTag(CoroutineHandle coindex)
		{
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0xE52EF4", Offset = "0xE52EF4", VA = "0xE52EF4")]
		private bool Nullify(ProcessIndex coindex)
		{
			return default(bool);
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0xE52B70", Offset = "0xE52B70", VA = "0xE52B70")]
		private IEnumerator<float> CoindexExtract(ProcessIndex coindex)
		{
			return null;
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0xE54BC8", Offset = "0xE54BC8", VA = "0xE54BC8")]
		private IEnumerator<float> CoindexPeek(ProcessIndex coindex)
		{
			return null;
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0xE50A7C", Offset = "0xE50A7C", VA = "0xE50A7C")]
		private bool CoindexIsNull(ProcessIndex coindex)
		{
			return default(bool);
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0xE53C10", Offset = "0xE53C10", VA = "0xE53C10")]
		private bool SetPause(ProcessIndex coindex, bool newPausedState)
		{
			return default(bool);
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0xE54C5C", Offset = "0xE54C5C", VA = "0xE54C5C")]
		private bool SetHeld(ProcessIndex coindex, bool newHeldState)
		{
			return default(bool);
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0xE53970", Offset = "0xE53970", VA = "0xE53970")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9953B4", Offset = "0x9953B4")]
		private IEnumerator<float> _InjectDelay(IEnumerator<float> proc, float delayTime)
		{
			return null;
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0xE552E4", Offset = "0xE552E4", VA = "0xE552E4")]
		private bool CoindexIsPaused(ProcessIndex coindex)
		{
			return default(bool);
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0xE5537C", Offset = "0xE5537C", VA = "0xE5537C")]
		private bool CoindexIsHeld(ProcessIndex coindex)
		{
			return default(bool);
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0xE55414", Offset = "0xE55414", VA = "0xE55414")]
		private void CoindexReplace(ProcessIndex coindex, IEnumerator<float> replacement)
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0xE554EC", Offset = "0xE554EC", VA = "0xE554EC")]
		public static float WaitForSeconds(float waitTime)
		{
			return default(float);
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0xE55578", Offset = "0xE55578", VA = "0xE55578")]
		public float WaitForSecondsOnInstance(float waitTime)
		{
			return default(float);
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0xE555BC", Offset = "0xE555BC", VA = "0xE555BC")]
		public static float WaitUntilDone(CoroutineHandle otherCoroutine)
		{
			return default(float);
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0xE55624", Offset = "0xE55624", VA = "0xE55624")]
		public static float WaitUntilDone(CoroutineHandle otherCoroutine, bool warnOnIssue)
		{
			return default(float);
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0xE558F8", Offset = "0xE558F8", VA = "0xE558F8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x995418", Offset = "0x995418")]
		private IEnumerator<float> _StartWhenDone(CoroutineHandle handle, IEnumerator<float> proc)
		{
			return null;
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0xE5599C", Offset = "0xE5599C", VA = "0xE5599C")]
		private void SwapToLast(CoroutineHandle firstHandle, CoroutineHandle lastHandle)
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0xE50B18", Offset = "0xE50B18", VA = "0xE50B18")]
		private void CloseWaitingProcess(CoroutineHandle handle)
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0xE55D20", Offset = "0xE55D20", VA = "0xE55D20")]
		private bool HandleIsInWaitingList(CoroutineHandle handle)
		{
			return default(bool);
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0xE55DEC", Offset = "0xE55DEC", VA = "0xE55DEC")]
		private static IEnumerator<float> ReturnTmpRefForRepFunc(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			return null;
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0xE55E60", Offset = "0xE55E60", VA = "0xE55E60")]
		public static float WaitUntilDone(AsyncOperation operation)
		{
			return default(float);
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0xE55FF8", Offset = "0xE55FF8", VA = "0xE55FF8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x99547C", Offset = "0x99547C")]
		private static IEnumerator<float> _StartWhenDone(AsyncOperation operation, IEnumerator<float> pausedProc)
		{
			return null;
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0xE56094", Offset = "0xE56094", VA = "0xE56094")]
		public static float WaitUntilDone(CustomYieldInstruction operation)
		{
			return default(float);
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0xE56230", Offset = "0xE56230", VA = "0xE56230")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9954E0", Offset = "0x9954E0")]
		private static IEnumerator<float> _StartWhenDone(CustomYieldInstruction operation, IEnumerator<float> pausedProc)
		{
			return null;
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0xE562CC", Offset = "0xE562CC", VA = "0xE562CC")]
		public bool LockCoroutine(CoroutineHandle coroutine, CoroutineHandle key)
		{
			return default(bool);
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0xE5648C", Offset = "0xE5648C", VA = "0xE5648C")]
		public bool UnlockCoroutine(CoroutineHandle coroutine, CoroutineHandle key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0xE56638", Offset = "0xE56638", VA = "0xE56638")]
		public static CoroutineHandle CallDelayed(float delay, Action action)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0xE56794", Offset = "0xE56794", VA = "0xE56794")]
		public CoroutineHandle CallDelayedOnInstance(float delay, Action action)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0xE567D8", Offset = "0xE567D8", VA = "0xE567D8")]
		public static CoroutineHandle CallDelayed(float delay, Action action, GameObject cancelWith)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0xE56880", Offset = "0xE56880", VA = "0xE56880")]
		public CoroutineHandle CallDelayedOnInstance(float delay, Action action, GameObject cancelWith)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0xE568C0", Offset = "0xE568C0", VA = "0xE568C0")]
		public static CoroutineHandle CallDelayed(float delay, Segment segment, Action action)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0xE5696C", Offset = "0xE5696C", VA = "0xE5696C")]
		public CoroutineHandle CallDelayedOnInstance(float delay, Segment segment, Action action)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0xE569BC", Offset = "0xE569BC", VA = "0xE569BC")]
		public static CoroutineHandle CallDelayed(float delay, Segment segment, Action action, GameObject gameObject)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0xE56A6C", Offset = "0xE56A6C", VA = "0xE56A6C")]
		public CoroutineHandle CallDelayedOnInstance(float delay, Segment segment, Action action, GameObject gameObject)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0xE566D4", Offset = "0xE566D4", VA = "0xE566D4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x995544", Offset = "0x995544")]
		private IEnumerator<float> _DelayedCall(float delay, Action action, GameObject cancelWith)
		{
			return null;
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0xE56AE8", Offset = "0xE56AE8", VA = "0xE56AE8")]
		public static CoroutineHandle CallPeriodically(float timeframe, float period, Action action, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0xE56C64", Offset = "0xE56C64", VA = "0xE56C64")]
		public CoroutineHandle CallPeriodicallyOnInstance(float timeframe, float period, Action action, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0xE56CA8", Offset = "0xE56CA8", VA = "0xE56CA8")]
		public static CoroutineHandle CallPeriodically(float timeframe, float period, Action action, Segment segment, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0xE56D60", Offset = "0xE56D60", VA = "0xE56D60")]
		public CoroutineHandle CallPeriodicallyOnInstance(float timeframe, float period, Action action, Segment segment, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0xE56DAC", Offset = "0xE56DAC", VA = "0xE56DAC")]
		public static CoroutineHandle CallContinuously(float timeframe, Action action, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0xE56E5C", Offset = "0xE56E5C", VA = "0xE56E5C")]
		public CoroutineHandle CallContinuouslyOnInstance(float timeframe, Action action, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0xE56EA4", Offset = "0xE56EA4", VA = "0xE56EA4")]
		public static CoroutineHandle CallContinuously(float timeframe, Action action, Segment timing, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0xE56F58", Offset = "0xE56F58", VA = "0xE56F58")]
		public CoroutineHandle CallContinuouslyOnInstance(float timeframe, Action action, Segment timing, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0xE56B9C", Offset = "0xE56B9C", VA = "0xE56B9C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9955A8", Offset = "0x9955A8")]
		private IEnumerator<float> _CallContinuously(float timeframe, float period, Action action, Action onDone)
		{
			return null;
		}

		[Token(Token = "0x60001A2")]
		public static CoroutineHandle CallPeriodically<T>(T reference, float timeframe, float period, Action<T> action, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60001A3")]
		public CoroutineHandle CallPeriodicallyOnInstance<T>(T reference, float timeframe, float period, Action<T> action, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60001A4")]
		public static CoroutineHandle CallPeriodically<T>(T reference, float timeframe, float period, Action<T> action, Segment timing, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60001A5")]
		public CoroutineHandle CallPeriodicallyOnInstance<T>(T reference, float timeframe, float period, Action<T> action, Segment timing, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60001A6")]
		public static CoroutineHandle CallContinuously<T>(T reference, float timeframe, Action<T> action, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60001A7")]
		public CoroutineHandle CallContinuouslyOnInstance<T>(T reference, float timeframe, Action<T> action, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60001A8")]
		public static CoroutineHandle CallContinuously<T>(T reference, float timeframe, Action<T> action, Segment timing, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60001A9")]
		public CoroutineHandle CallContinuouslyOnInstance<T>(T reference, float timeframe, Action<T> action, Segment timing, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60001AA")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x99560C", Offset = "0x99560C")]
		private IEnumerator<float> _CallContinuously<T>(T reference, float timeframe, float period, Action<T> action, [Optional] Action<T> onDone)
		{
			return null;
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0xE56FD4", Offset = "0xE56FD4", VA = "0xE56FD4")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x995670", Offset = "0x995670")]
		public new Coroutine StartCoroutine(IEnumerator routine)
		{
			return null;
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0xE56FDC", Offset = "0xE56FDC", VA = "0xE56FDC")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9956AC", Offset = "0x9956AC")]
		public new Coroutine StartCoroutine(string methodName, object value)
		{
			return null;
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0xE56FE4", Offset = "0xE56FE4", VA = "0xE56FE4")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9956E8", Offset = "0x9956E8")]
		public new Coroutine StartCoroutine(string methodName)
		{
			return null;
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0xE56FEC", Offset = "0xE56FEC", VA = "0xE56FEC")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x995724", Offset = "0x995724")]
		public new Coroutine StartCoroutine_Auto(IEnumerator routine)
		{
			return null;
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0xE56FF4", Offset = "0xE56FF4", VA = "0xE56FF4")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x995760", Offset = "0x995760")]
		public new void StopCoroutine(string methodName)
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0xE56FF8", Offset = "0xE56FF8", VA = "0xE56FF8")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x99579C", Offset = "0x99579C")]
		public new void StopCoroutine(IEnumerator routine)
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0xE56FFC", Offset = "0xE56FFC", VA = "0xE56FFC")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9957D8", Offset = "0x9957D8")]
		public new void StopCoroutine(Coroutine routine)
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0xE57000", Offset = "0xE57000", VA = "0xE57000")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x995814", Offset = "0x995814")]
		public new void StopAllCoroutines()
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0xE57004", Offset = "0xE57004", VA = "0xE57004")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x995850", Offset = "0x995850")]
		public new static void Destroy(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0xE57008", Offset = "0xE57008", VA = "0xE57008")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x99588C", Offset = "0x99588C")]
		public new static void Destroy(UnityEngine.Object obj, float f)
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0xE5700C", Offset = "0xE5700C", VA = "0xE5700C")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9958C8", Offset = "0x9958C8")]
		public new static void DestroyObject(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0xE57010", Offset = "0xE57010", VA = "0xE57010")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x995904", Offset = "0x995904")]
		public static void DestroyObject(UnityEngine.Object obj, float f)
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0xE57014", Offset = "0xE57014", VA = "0xE57014")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x995940", Offset = "0x995940")]
		public new static void DestroyImmediate(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0xE57018", Offset = "0xE57018", VA = "0xE57018")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x99597C", Offset = "0x99597C")]
		public new static void DestroyImmediate(UnityEngine.Object obj, bool b)
		{
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0xE5701C", Offset = "0xE5701C", VA = "0xE5701C")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9959B8", Offset = "0x9959B8")]
		public new static void Instantiate(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0xE57020", Offset = "0xE57020", VA = "0xE57020")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9959F4", Offset = "0x9959F4")]
		public new static void Instantiate(UnityEngine.Object original, Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x60001BB")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x995A30", Offset = "0x995A30")]
		public new static void Instantiate<T>(T original) where T : UnityEngine.Object
		{
		}

		[Token(Token = "0x60001BC")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x995A6C", Offset = "0x995A6C")]
		public new static T FindObjectOfType<T>() where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0xE57024", Offset = "0xE57024", VA = "0xE57024")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x995AA8", Offset = "0x995AA8")]
		public new static UnityEngine.Object FindObjectOfType(Type t)
		{
			return null;
		}

		[Token(Token = "0x60001BE")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x995AE4", Offset = "0x995AE4")]
		public new static T[] FindObjectsOfType<T>() where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0xE5702C", Offset = "0xE5702C", VA = "0xE5702C")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x995B20", Offset = "0x995B20")]
		public new static UnityEngine.Object[] FindObjectsOfType(Type t)
		{
			return null;
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0xE57034", Offset = "0xE57034", VA = "0xE57034")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x995B5C", Offset = "0x995B5C")]
		public new static void print(object message)
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0xE57038", Offset = "0xE57038", VA = "0xE57038")]
		public Timing()
		{
		}
	}
	[Token(Token = "0x200003A")]
	public enum Segment
	{
		[Token(Token = "0x400012D")]
		Invalid = -1,
		[Token(Token = "0x400012E")]
		Update,
		[Token(Token = "0x400012F")]
		FixedUpdate,
		[Token(Token = "0x4000130")]
		LateUpdate,
		[Token(Token = "0x4000131")]
		SlowUpdate
	}
	[Token(Token = "0x200003B")]
	public enum DebugInfoType
	{
		[Token(Token = "0x4000133")]
		None,
		[Token(Token = "0x4000134")]
		SeperateCoroutines,
		[Token(Token = "0x4000135")]
		SeperateTags
	}
	[Token(Token = "0x200003C")]
	public struct CoroutineHandle : IEquatable<CoroutineHandle>
	{
		[Token(Token = "0x4000136")]
		private const byte ReservedSpace = 15;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int[] NextIndex;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly int _id;

		[Token(Token = "0x17000014")]
		public byte Key
		{
			[Token(Token = "0x60001C3")]
			[Address(RVA = "0xA54DE4", Offset = "0xA54DE4", VA = "0xA54DE4")]
			get
			{
				return default(byte);
			}
		}

		[Token(Token = "0x17000015")]
		public bool IsValid
		{
			[Token(Token = "0x60001CA")]
			[Address(RVA = "0xA54E18", Offset = "0xA54E18", VA = "0xA54E18")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0xA54DF0", Offset = "0xA54DF0", VA = "0xA54DF0")]
		public CoroutineHandle(byte ind)
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0xA54DF8", Offset = "0xA54DF8", VA = "0xA54DF8", Slot = "4")]
		public bool Equals(CoroutineHandle other)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0xA54E08", Offset = "0xA54E08", VA = "0xA54E08", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0xE4C8E4", Offset = "0xE4C8E4", VA = "0xE4C8E4")]
		public static bool operator ==(CoroutineHandle a, CoroutineHandle b)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0xE4C8F0", Offset = "0xE4C8F0", VA = "0xE4C8F0")]
		public static bool operator !=(CoroutineHandle a, CoroutineHandle b)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0xA54E10", Offset = "0xA54E10", VA = "0xA54E10", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Token(Token = "0x200003D")]
	public static class MECExtensionMethods1
	{
		[Token(Token = "0x60001CC")]
		[Address(RVA = "0xE4C9A8", Offset = "0xE4C9A8", VA = "0xE4C9A8")]
		public static CoroutineHandle RunCoroutine(this IEnumerator<float> coroutine)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0xE4CAD8", Offset = "0xE4CAD8", VA = "0xE4CAD8")]
		public static CoroutineHandle RunCoroutine(this IEnumerator<float> coroutine, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0xE4CC1C", Offset = "0xE4CC1C", VA = "0xE4CC1C")]
		public static CoroutineHandle RunCoroutine(this IEnumerator<float> coroutine, Segment segment)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0xE4CD60", Offset = "0xE4CD60", VA = "0xE4CD60")]
		public static CoroutineHandle RunCoroutine(this IEnumerator<float> coroutine, Segment segment, string tag)
		{
			return default(CoroutineHandle);
		}
	}
}
namespace IngameDebugConsole
{
	[Token(Token = "0x200003E")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x993A94", Offset = "0x993A94")]
	public class CircularBuffer<T>
	{
		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T[] arr;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int startIndex;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994524", Offset = "0x994524")]
		private int <Count>k__BackingField;

		[Token(Token = "0x17000016")]
		public int Count
		{
			[Token(Token = "0x60001D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x995BD8", Offset = "0x995BD8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60001D1")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x995BE8", Offset = "0x995BE8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000017")]
		public T Item
		{
			[Token(Token = "0x60001D2")]
			get
			{
				return (T)null;
			}
		}

		[Token(Token = "0x60001D3")]
		public CircularBuffer(int capacity)
		{
		}

		[Token(Token = "0x60001D4")]
		public void Add(T value)
		{
		}
	}
	[Token(Token = "0x200003F")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x993ACC", Offset = "0x993ACC")]
	public class DynamicCircularBuffer<T>
	{
		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T[] arr;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int startIndex;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994534", Offset = "0x994534")]
		private int <Count>k__BackingField;

		[Token(Token = "0x17000018")]
		public int Count
		{
			[Token(Token = "0x60001D5")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x995BF8", Offset = "0x995BF8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60001D6")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x995C08", Offset = "0x995C08")]
			private set
			{
			}
		}

		[Token(Token = "0x17000019")]
		public T Item
		{
			[Token(Token = "0x60001D7")]
			get
			{
				return (T)null;
			}
			[Token(Token = "0x60001D8")]
			set
			{
			}
		}

		[Token(Token = "0x60001D9")]
		public DynamicCircularBuffer(int initialCapacity = 2)
		{
		}

		[Token(Token = "0x60001DA")]
		public void Add(T value)
		{
		}

		[Token(Token = "0x60001DB")]
		public T RemoveFirst()
		{
			return (T)null;
		}

		[Token(Token = "0x60001DC")]
		public T RemoveLast()
		{
			return (T)null;
		}
	}
	[Token(Token = "0x2000040")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x993B04", Offset = "0x993B04")]
	public class ConsoleMethodAttribute : Attribute
	{
		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string m_command;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string m_description;

		[Token(Token = "0x1700001A")]
		public string Command
		{
			[Token(Token = "0x60001DD")]
			[Address(RVA = "0xE4318C", Offset = "0xE4318C", VA = "0xE4318C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001B")]
		public string Description
		{
			[Token(Token = "0x60001DE")]
			[Address(RVA = "0xE43194", Offset = "0xE43194", VA = "0xE43194")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0xE4319C", Offset = "0xE4319C", VA = "0xE4319C")]
		public ConsoleMethodAttribute(string command, string description)
		{
		}
	}
	[Token(Token = "0x2000041")]
	public class ConsoleMethodInfo
	{
		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly MethodInfo method;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly Type[] parameterTypes;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly object instance;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly string signature;

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0xE431EC", Offset = "0xE431EC", VA = "0xE431EC")]
		public ConsoleMethodInfo(MethodInfo method, Type[] parameterTypes, object instance, string signature)
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0xE4326C", Offset = "0xE4326C", VA = "0xE4326C")]
		public bool IsValid()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000042")]
	public static class DebugLogConsole
	{
		[Token(Token = "0x200008B")]
		public delegate bool ParseFunction(string input, out object output);

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<string, ConsoleMethodInfo> methods;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly Dictionary<Type, ParseFunction> parseFunctions;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly Dictionary<Type, string> typeReadableNames;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly List<string> commandArguments;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static readonly string[] inputDelimiters;

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0xE432C8", Offset = "0xE432C8", VA = "0xE432C8")]
		static DebugLogConsole()
		{
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0xE44B34", Offset = "0xE44B34", VA = "0xE44B34")]
		public static void LogAllCommands()
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0xE44E50", Offset = "0xE44E50", VA = "0xE44E50")]
		public static void LogSystemInfo()
		{
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0xE455E0", Offset = "0xE455E0", VA = "0xE455E0")]
		private static StringBuilder AppendSysInfoIfPresent(this StringBuilder sb, string info, [Optional] string postfix)
		{
			return null;
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0xE45698", Offset = "0xE45698", VA = "0xE45698")]
		private static StringBuilder AppendSysInfoIfPresent(this StringBuilder sb, int info, [Optional] string postfix)
		{
			return null;
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0xE4573C", Offset = "0xE4573C", VA = "0xE4573C")]
		public static void AddCommandInstance(string command, string description, string methodName, object instance)
		{
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0xE45958", Offset = "0xE45958", VA = "0xE45958")]
		public static void AddCommandStatic(string command, string description, string methodName, Type ownerType)
		{
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0xE44A90", Offset = "0xE44A90", VA = "0xE44A90")]
		public static void AddCommand(string command, string description, Action method)
		{
		}

		[Token(Token = "0x60001EA")]
		public static void AddCommand<T1>(string command, string description, Action<T1> method)
		{
		}

		[Token(Token = "0x60001EB")]
		public static void AddCommand<T1>(string command, string description, Func<T1> method)
		{
		}

		[Token(Token = "0x60001EC")]
		public static void AddCommand<T1, T2>(string command, string description, Action<T1, T2> method)
		{
		}

		[Token(Token = "0x60001ED")]
		public static void AddCommand<T1, T2>(string command, string description, Func<T1, T2> method)
		{
		}

		[Token(Token = "0x60001EE")]
		public static void AddCommand<T1, T2, T3>(string command, string description, Action<T1, T2, T3> method)
		{
		}

		[Token(Token = "0x60001EF")]
		public static void AddCommand<T1, T2, T3>(string command, string description, Func<T1, T2, T3> method)
		{
		}

		[Token(Token = "0x60001F0")]
		public static void AddCommand<T1, T2, T3, T4>(string command, string description, Action<T1, T2, T3, T4> method)
		{
		}

		[Token(Token = "0x60001F1")]
		public static void AddCommand<T1, T2, T3, T4>(string command, string description, Func<T1, T2, T3, T4> method)
		{
		}

		[Token(Token = "0x60001F2")]
		public static void AddCommand<T1, T2, T3, T4, T5>(string command, string description, Func<T1, T2, T3, T4, T5> method)
		{
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0xE459E8", Offset = "0xE459E8", VA = "0xE459E8")]
		public static void AddCommand(string command, string description, Delegate method)
		{
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0xE45A8C", Offset = "0xE45A8C", VA = "0xE45A8C")]
		public static void RemoveCommand(string command)
		{
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0xE45B2C", Offset = "0xE45B2C", VA = "0xE45B2C")]
		public static string GetAutoCompleteCommand(string commandStart)
		{
			return null;
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0xE45828", Offset = "0xE45828", VA = "0xE45828")]
		private static void AddCommand(string command, string description, string methodName, Type ownerType, [Optional] object instance)
		{
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0xE4443C", Offset = "0xE4443C", VA = "0xE4443C")]
		private static void AddCommand(string command, string description, MethodInfo method, [Optional] object instance)
		{
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0xE45C80", Offset = "0xE45C80", VA = "0xE45C80")]
		public static void ExecuteCommand(string command)
		{
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0xE46640", Offset = "0xE46640", VA = "0xE46640")]
		private static int IndexOfDelimiter(char c)
		{
			return default(int);
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0xE46608", Offset = "0xE46608", VA = "0xE46608")]
		private static int IndexOfChar(string command, char c, int startIndex)
		{
			return default(int);
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0xE46B34", Offset = "0xE46B34", VA = "0xE46B34")]
		private static bool ParseString(string input, out object output)
		{
			return default(bool);
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0xE46B78", Offset = "0xE46B78", VA = "0xE46B78")]
		private static bool ParseBool(string input, out object output)
		{
			return default(bool);
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0xE46CF4", Offset = "0xE46CF4", VA = "0xE46CF4")]
		private static bool ParseInt(string input, out object output)
		{
			return default(bool);
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0xE46D8C", Offset = "0xE46D8C", VA = "0xE46D8C")]
		private static bool ParseUInt(string input, out object output)
		{
			return default(bool);
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0xE46E24", Offset = "0xE46E24", VA = "0xE46E24")]
		private static bool ParseLong(string input, out object output)
		{
			return default(bool);
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0xE46EC4", Offset = "0xE46EC4", VA = "0xE46EC4")]
		private static bool ParseULong(string input, out object output)
		{
			return default(bool);
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0xE46F64", Offset = "0xE46F64", VA = "0xE46F64")]
		private static bool ParseByte(string input, out object output)
		{
			return default(bool);
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0xE46FFC", Offset = "0xE46FFC", VA = "0xE46FFC")]
		private static bool ParseSByte(string input, out object output)
		{
			return default(bool);
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0xE47094", Offset = "0xE47094", VA = "0xE47094")]
		private static bool ParseShort(string input, out object output)
		{
			return default(bool);
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0xE4712C", Offset = "0xE4712C", VA = "0xE4712C")]
		private static bool ParseUShort(string input, out object output)
		{
			return default(bool);
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0xE471C4", Offset = "0xE471C4", VA = "0xE471C4")]
		private static bool ParseChar(string input, out object output)
		{
			return default(bool);
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0xE47274", Offset = "0xE47274", VA = "0xE47274")]
		private static bool ParseFloat(string input, out object output)
		{
			return default(bool);
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0xE4730C", Offset = "0xE4730C", VA = "0xE4730C")]
		private static bool ParseDouble(string input, out object output)
		{
			return default(bool);
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0xE473C4", Offset = "0xE473C4", VA = "0xE473C4")]
		private static bool ParseDecimal(string input, out object output)
		{
			return default(bool);
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0xE4747C", Offset = "0xE4747C", VA = "0xE4747C")]
		private static bool ParseVector2(string input, out object output)
		{
			return default(bool);
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0xE47B08", Offset = "0xE47B08", VA = "0xE47B08")]
		private static bool ParseVector3(string input, out object output)
		{
			return default(bool);
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0xE47BC0", Offset = "0xE47BC0", VA = "0xE47BC0")]
		private static bool ParseVector4(string input, out object output)
		{
			return default(bool);
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0xE47C78", Offset = "0xE47C78", VA = "0xE47C78")]
		private static bool ParseGameObject(string input, out object output)
		{
			return default(bool);
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0xE47534", Offset = "0xE47534", VA = "0xE47534")]
		private static bool CreateVectorFromInput(string input, Type vectorType, out object output)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000043")]
	public class DebugLogEntry : IEquatable<DebugLogEntry>
	{
		[Token(Token = "0x400014A")]
		private const int HASH_NOT_CALCULATED = -623218;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string logString;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string stackTrace;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string completeLog;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Sprite logTypeSpriteRepresentation;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int count;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int hashValue;

		[Token(Token = "0x600020E")]
		[Address(RVA = "0xE47D70", Offset = "0xE47D70", VA = "0xE47D70")]
		public void Initialize(string logString, string stackTrace, Sprite sprite)
		{
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0xE47DD4", Offset = "0xE47DD4", VA = "0xE47DD4", Slot = "4")]
		public bool Equals(DebugLogEntry other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0xE47E30", Offset = "0xE47E30", VA = "0xE47E30", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0xE47EAC", Offset = "0xE47EAC", VA = "0xE47EAC", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0xE47F9C", Offset = "0xE47F9C", VA = "0xE47F9C")]
		public DebugLogEntry()
		{
		}
	}
	[Token(Token = "0x2000044")]
	public struct QueuedDebugLogEntry
	{
		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public readonly string logString;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public readonly string stackTrace;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly LogType logType;

		[Token(Token = "0x6000213")]
		[Address(RVA = "0xA54D9C", Offset = "0xA54D9C", VA = "0xA54D9C")]
		public QueuedDebugLogEntry(string logString, string stackTrace, LogType logType)
		{
		}
	}
	[Token(Token = "0x2000045")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x993B4C", Offset = "0x993B4C")]
	public class DebugLogIndexList
	{
		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int[] indices;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int size;

		[Token(Token = "0x1700001C")]
		public int Count
		{
			[Token(Token = "0x6000214")]
			[Address(RVA = "0xE47FA4", Offset = "0xE47FA4", VA = "0xE47FA4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700001D")]
		public int Item
		{
			[Token(Token = "0x6000215")]
			[Address(RVA = "0xE47FAC", Offset = "0xE47FAC", VA = "0xE47FAC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0xE47FF0", Offset = "0xE47FF0", VA = "0xE47FF0")]
		public DebugLogIndexList()
		{
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0xE48068", Offset = "0xE48068", VA = "0xE48068")]
		public void Add(int index)
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0xE4812C", Offset = "0xE4812C", VA = "0xE4812C")]
		public void Clear()
		{
		}
	}
	[Token(Token = "0x2000046")]
	public class DebugLogItem : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
	{
		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform transformComponent;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image imageComponent;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text logText;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image logTypeImage;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject logCountParent;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text logCountText;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private DebugLogEntry logEntry;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int entryIndex;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private DebugLogRecycledListView manager;

		[Token(Token = "0x1700001E")]
		public RectTransform Transform
		{
			[Token(Token = "0x6000219")]
			[Address(RVA = "0xE48134", Offset = "0xE48134", VA = "0xE48134")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001F")]
		public Image Image
		{
			[Token(Token = "0x600021A")]
			[Address(RVA = "0xE4813C", Offset = "0xE4813C", VA = "0xE4813C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000020")]
		public int Index
		{
			[Token(Token = "0x600021B")]
			[Address(RVA = "0xE48144", Offset = "0xE48144", VA = "0xE48144")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0xE4814C", Offset = "0xE4814C", VA = "0xE4814C")]
		public void Initialize(DebugLogRecycledListView manager)
		{
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0xE48154", Offset = "0xE48154", VA = "0xE48154")]
		public void SetContent(DebugLogEntry logEntry, int entryIndex, bool isExpanded)
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0xE48274", Offset = "0xE48274", VA = "0xE48274")]
		public void ShowCount()
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0xE482DC", Offset = "0xE482DC", VA = "0xE482DC")]
		public void HideCount()
		{
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0xE482FC", Offset = "0xE482FC", VA = "0xE482FC", Slot = "4")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0xE4845C", Offset = "0xE4845C", VA = "0xE4845C")]
		public float CalculateExpandedHeight(string content)
		{
			return default(float);
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0xE485A8", Offset = "0xE485A8", VA = "0xE485A8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0xE485C8", Offset = "0xE485C8", VA = "0xE485C8")]
		public DebugLogItem()
		{
		}
	}
	[Token(Token = "0x2000047")]
	public class DebugLogLogcatListener : AndroidJavaProxy
	{
		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Queue<string> queuedLogs;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private AndroidJavaObject nativeObject;

		[Token(Token = "0x6000224")]
		[Address(RVA = "0xE485D0", Offset = "0xE485D0", VA = "0xE485D0")]
		public DebugLogLogcatListener()
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0xE4867C", Offset = "0xE4867C", VA = "0xE4867C", Slot = "1")]
		~DebugLogLogcatListener()
		{
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0xE487FC", Offset = "0xE487FC", VA = "0xE487FC")]
		public void Start(string arguments)
		{
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0xE486FC", Offset = "0xE486FC", VA = "0xE486FC")]
		public void Stop()
		{
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0xE489E4", Offset = "0xE489E4", VA = "0xE489E4")]
		public void OnLogReceived(string log)
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0xE48A4C", Offset = "0xE48A4C", VA = "0xE48A4C")]
		public string GetLog()
		{
			return null;
		}
	}
	[Token(Token = "0x2000048")]
	public enum DebugLogFilter
	{
		[Token(Token = "0x4000162")]
		None = 0,
		[Token(Token = "0x4000163")]
		Info = 1,
		[Token(Token = "0x4000164")]
		Warning = 2,
		[Token(Token = "0x4000165")]
		Error = 4,
		[Token(Token = "0x4000166")]
		All = 7
	}
	[Token(Token = "0x2000049")]
	public class DebugLogManager : MonoBehaviour
	{
		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DebugLogManager instance;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9945A4", Offset = "0x9945A4")]
		[SerializeField]
		[HideInInspector]
		private bool singleton;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		[HideInInspector]
		private float minimumHeight;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[HideInInspector]
		private bool enablePopup;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		[SerializeField]
		[HideInInspector]
		private bool startInPopupMode;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		[SerializeField]
		[HideInInspector]
		private bool startMinimized;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x23")]
		[SerializeField]
		[HideInInspector]
		private bool toggleWithKey;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		[HideInInspector]
		private KeyCode toggleKey;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		[HideInInspector]
		private bool clearCommandAfterExecution;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		[HideInInspector]
		private int commandHistorySize;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[HideInInspector]
		private bool receiveLogcatLogsInAndroid;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		[HideInInspector]
		private string logcatArguments;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private int maxLogLength;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x994840", Offset = "0x994840")]
		[SerializeField]
		private DebugLogItem logItemPrefab;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Sprite infoLog;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Sprite warningLog;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Sprite errorLog;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Dictionary<LogType, Sprite> logSpriteRepresentations;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Color collapseButtonNormalColor;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Color collapseButtonSelectedColor;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Color filterButtonsNormalColor;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Color filterButtonsSelectedColor;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9948FC", Offset = "0x9948FC")]
		[SerializeField]
		private RectTransform logWindowTR;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private RectTransform canvasTR;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private RectTransform logItemsContainer;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private InputField commandInputField;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private Image collapseButton;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private Image filterInfoButton;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private Image filterWarningButton;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private Image filterErrorButton;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private Text infoEntryCountText;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private Text warningEntryCountText;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[SerializeField]
		private Text errorEntryCountText;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[SerializeField]
		private GameObject snapToBottomButton;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[SerializeField]
		private CanvasGroup logWindowCanvasGroup;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[SerializeField]
		private DebugLogPopup popupManager;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[SerializeField]
		private ScrollRect logItemsScrollRect;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[SerializeField]
		private DebugLogRecycledListView recycledListView;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private int infoEntryCount;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		private int warningEntryCount;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private int errorEntryCount;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private bool isLogWindowVisible;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13D")]
		private bool screenDimensionsChanged;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13E")]
		private bool isCollapseOn;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private DebugLogFilter logFilter;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
		private bool snapToBottom;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private List<DebugLogEntry> collapsedLogEntries;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Dictionary<DebugLogEntry, int> collapsedLogEntriesMap;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private DebugLogIndexList uncollapsedLogEntriesIndices;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private DebugLogIndexList indicesOfListEntriesToShow;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private DynamicCircularBuffer<QueuedDebugLogEntry> queuedLogEntries;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private object logEntriesLock;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private List<DebugLogEntry> pooledLogEntries;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private List<DebugLogItem> pooledLogItems;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private CircularBuffer<string> commandHistory;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private int commandHistoryIndex;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private PointerEventData nullPointerEventData;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private DebugLogLogcatListener logcatListener;

		[Token(Token = "0x600022A")]
		[Address(RVA = "0xE48ABC", Offset = "0xE48ABC", VA = "0xE48ABC")]
		private void Awake()
		{
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0xE49314", Offset = "0xE49314", VA = "0xE49314")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0xE4955C", Offset = "0xE4955C", VA = "0xE4955C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0xE49714", Offset = "0xE49714", VA = "0xE49714")]
		private void Start()
		{
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0xE49870", Offset = "0xE49870", VA = "0xE49870")]
		private void OnRectTransformDimensionsChange()
		{
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0xE4987C", Offset = "0xE4987C", VA = "0xE4987C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0xE497F0", Offset = "0xE497F0", VA = "0xE497F0")]
		public void ShowLogWindow()
		{
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0xE4977C", Offset = "0xE4977C", VA = "0xE4977C")]
		public void ShowPopup()
		{
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0xE4A5CC", Offset = "0xE4A5CC", VA = "0xE4A5CC")]
		public char OnValidateCommand(string text, int charIndex, char addedChar)
		{
			return default(char);
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0xE4A208", Offset = "0xE4A208", VA = "0xE4A208")]
		private void ReceivedLog(string logString, string stackTrace, LogType logType)
		{
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0xE49CAC", Offset = "0xE49CAC", VA = "0xE49CAC")]
		private void ProcessLog(QueuedDebugLogEntry queuedLogEntry)
		{
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0xE4A9C0", Offset = "0xE4A9C0", VA = "0xE4A9C0")]
		public void SetSnapToBottom(bool snapToBottom)
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0xE4A9CC", Offset = "0xE4A9CC", VA = "0xE4A9CC")]
		public void ValidateScrollPosition()
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0xE4A9F8", Offset = "0xE4A9F8", VA = "0xE4A9F8")]
		public void HideButtonPressed()
		{
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0xE4A9FC", Offset = "0xE4A9FC", VA = "0xE4A9FC")]
		public void ClearButtonPressed()
		{
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0xE4ABBC", Offset = "0xE4ABBC", VA = "0xE4ABBC")]
		public void CollapseButtonPressed()
		{
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0xE4AFFC", Offset = "0xE4AFFC", VA = "0xE4AFFC")]
		public void FilterLogButtonPressed()
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0xE4B064", Offset = "0xE4B064", VA = "0xE4B064")]
		public void FilterWarningButtonPressed()
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0xE4B0CC", Offset = "0xE4B0CC", VA = "0xE4B0CC")]
		public void FilterErrorButtonPressed()
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0xE4B134", Offset = "0xE4B134", VA = "0xE4B134")]
		public void Resize(BaseEventData dat)
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0xE4AC5C", Offset = "0xE4AC5C", VA = "0xE4AC5C")]
		private void FilterLogs()
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0xE4B2CC", Offset = "0xE4B2CC", VA = "0xE4B2CC")]
		public string GetAllLogs()
		{
			return null;
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0xE4B494", Offset = "0xE4B494", VA = "0xE4B494")]
		private void SaveLogsToFile()
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0xE4B618", Offset = "0xE4B618", VA = "0xE4B618")]
		public void PoolLogItem(DebugLogItem logItem)
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0xE4B6A4", Offset = "0xE4B6A4", VA = "0xE4B6A4")]
		public DebugLogItem PopLogItem()
		{
			return null;
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0xE4B7AC", Offset = "0xE4B7AC", VA = "0xE4B7AC")]
		public DebugLogManager()
		{
		}
	}
	[Token(Token = "0x200004A")]
	public class DebugLogPopup : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
	{
		[Token(Token = "0x200008C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x993D84", Offset = "0x993D84")]
		private sealed class <MoveToPosAnimation>d__24 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000297")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000298")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000299")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DebugLogPopup <>4__this;

			[Token(Token = "0x400029A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 targetPos;

			[Token(Token = "0x400029B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float <modifier>5__2;

			[Token(Token = "0x400029C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Vector3 <initialPos>5__3;

			[Token(Token = "0x1700005B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600036C")]
				[Address(RVA = "0xE4C030", Offset = "0xE4C030", VA = "0xE4C030", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700005C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600036E")]
				[Address(RVA = "0xE4C09C", Offset = "0xE4C09C", VA = "0xE4C09C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000369")]
			[Address(RVA = "0xE4BD68", Offset = "0xE4BD68", VA = "0xE4BD68")]
			[DebuggerHidden]
			public <MoveToPosAnimation>d__24(int <>1__state)
			{
			}

			[Token(Token = "0x600036A")]
			[Address(RVA = "0xE4BEB8", Offset = "0xE4BEB8", VA = "0xE4BEB8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600036B")]
			[Address(RVA = "0xE4BEBC", Offset = "0xE4BEBC", VA = "0xE4BEBC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600036D")]
			[Address(RVA = "0xE4C038", Offset = "0xE4C038", VA = "0xE4C038", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private RectTransform popupTransform;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector2 halfSize;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Image backgroundImage;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private CanvasGroup canvasGroup;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private DebugLogManager debugManager;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text newInfoCountText;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text newWarningCountText;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text newErrorCountText;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Color alertColorInfo;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Color alertColorWarning;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Color alertColorError;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private int newInfoCount;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private int newWarningCount;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int newErrorCount;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Color normalColor;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool isPopupBeingDragged;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private IEnumerator moveToPosCoroutine;

		[Token(Token = "0x6000245")]
		[Address(RVA = "0xE4B804", Offset = "0xE4B804", VA = "0xE4B804")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0xE4B8FC", Offset = "0xE4B8FC", VA = "0xE4B8FC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0xE4A104", Offset = "0xE4A104", VA = "0xE4A104")]
		public void OnViewportDimensionsChanged()
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0xE4A834", Offset = "0xE4A834", VA = "0xE4A834")]
		public void NewInfoLogArrived()
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0xE4A8C4", Offset = "0xE4A8C4", VA = "0xE4A8C4")]
		public void NewWarningLogArrived()
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0xE4A94C", Offset = "0xE4A94C", VA = "0xE4A94C")]
		public void NewErrorLogArrived()
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0xE4BC00", Offset = "0xE4BC00", VA = "0xE4BC00")]
		private void Reset()
		{
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0xE4BCC4", Offset = "0xE4BCC4", VA = "0xE4BCC4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x995C38", Offset = "0x995C38")]
		private IEnumerator MoveToPosAnimation(Vector3 targetPos)
		{
			return null;
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0xE4BD94", Offset = "0xE4BD94", VA = "0xE4BD94", Slot = "4")]
		public void OnPointerClick(PointerEventData data)
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0xE4A564", Offset = "0xE4A564", VA = "0xE4A564")]
		public void Show()
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0xE4A478", Offset = "0xE4A478", VA = "0xE4A478")]
		public void Hide()
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0xE4BDB8", Offset = "0xE4BDB8", VA = "0xE4BDB8", Slot = "5")]
		public void OnBeginDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0xE4BE0C", Offset = "0xE4BE0C", VA = "0xE4BE0C", Slot = "6")]
		public void OnDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0xE4B9D0", Offset = "0xE4B9D0", VA = "0xE4B9D0", Slot = "7")]
		public void OnEndDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0xE4BEB0", Offset = "0xE4BEB0", VA = "0xE4BEB0")]
		public DebugLogPopup()
		{
		}
	}
	[Token(Token = "0x200004B")]
	public class DebugLogRecycledListView : MonoBehaviour
	{
		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform transformComponent;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform viewportTransform;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private DebugLogManager debugManager;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Color logItemNormalColor1;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Color logItemNormalColor2;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Color logItemSelectedColor;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private DebugLogManager manager;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float logItemHeight;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float _1OverLogItemHeight;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float viewportHeight;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private List<DebugLogEntry> collapsedLogEntries;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private DebugLogIndexList indicesOfEntriesToShow;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private int indexOfSelectedLogEntry;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float positionOfSelectedLogEntry;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float heightOfSelectedLogEntry;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private float deltaHeightOfSelectedLogEntry;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Dictionary<int, DebugLogItem> logItemsAtIndices;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private bool isCollapseOn;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private int currentTopIndex;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private int currentBottomIndex;

		[Token(Token = "0x17000021")]
		public float ItemHeight
		{
			[Token(Token = "0x6000254")]
			[Address(RVA = "0xE4C0A4", Offset = "0xE4C0A4", VA = "0xE4C0A4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000022")]
		public float SelectedItemHeight
		{
			[Token(Token = "0x6000255")]
			[Address(RVA = "0xE4C0AC", Offset = "0xE4C0AC", VA = "0xE4C0AC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0xE4C0B4", Offset = "0xE4C0B4", VA = "0xE4C0B4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0xE4901C", Offset = "0xE4901C", VA = "0xE4901C")]
		public void Initialize(DebugLogManager manager, List<DebugLogEntry> collapsedLogEntries, DebugLogIndexList indicesOfEntriesToShow, float logItemHeight)
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0xE4C108", Offset = "0xE4C108", VA = "0xE4C108")]
		public void SetCollapseMode(bool collapse)
		{
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0xE4831C", Offset = "0xE4831C", VA = "0xE4831C")]
		public void OnLogItemClicked(DebugLogItem item)
		{
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0xE4AB14", Offset = "0xE4AB14", VA = "0xE4AB14")]
		public void DeselectSelectedLogItem()
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0xE4A4D8", Offset = "0xE4A4D8", VA = "0xE4A4D8")]
		public void OnLogEntriesUpdated(bool updateAllVisibleItemContents)
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0xE4A7B0", Offset = "0xE4A7B0", VA = "0xE4A7B0")]
		public void OnCollapsedLogEntryAtIndexUpdated(int index)
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0xE4A0A4", Offset = "0xE4A0A4", VA = "0xE4A0A4")]
		public void OnViewportDimensionsChanged()
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0xE4C264", Offset = "0xE4C264", VA = "0xE4C264")]
		private void HardResetItems()
		{
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0xE4C190", Offset = "0xE4C190", VA = "0xE4C190")]
		private void CalculateContentHeight()
		{
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0xE49088", Offset = "0xE49088", VA = "0xE49088")]
		public void UpdateItemsInTheList(bool updateAllVisibleItemContents)
		{
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0xE4C348", Offset = "0xE4C348", VA = "0xE4C348")]
		private void CreateLogItemsBetweenIndices(int topIndex, int bottomIndex)
		{
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0xE4C4AC", Offset = "0xE4C4AC", VA = "0xE4C4AC")]
		private void CreateLogItemAtIndex(int index)
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0xE4C2A0", Offset = "0xE4C2A0", VA = "0xE4C2A0")]
		private void DestroyLogItemsBetweenIndices(int topIndex, int bottomIndex)
		{
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0xE4C394", Offset = "0xE4C394", VA = "0xE4C394")]
		private void UpdateLogItemContentsBetweenIndices(int topIndex, int bottomIndex)
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0xE4C114", Offset = "0xE4C114", VA = "0xE4C114")]
		private void ColorLogItem(DebugLogItem logItem, int index)
		{
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0xE4C59C", Offset = "0xE4C59C", VA = "0xE4C59C")]
		public DebugLogRecycledListView()
		{
		}
	}
	[Token(Token = "0x200004C")]
	public class DebugsOnScrollListener : MonoBehaviour, IScrollHandler, IEventSystemHandler, IBeginDragHandler, IEndDragHandler
	{
		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ScrollRect debugsScrollRect;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DebugLogManager debugLogManager;

		[Token(Token = "0x6000267")]
		[Address(RVA = "0xE4C62C", Offset = "0xE4C62C", VA = "0xE4C62C", Slot = "4")]
		public void OnScroll(PointerEventData data)
		{
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0xE4C698", Offset = "0xE4C698", VA = "0xE4C698", Slot = "5")]
		public void OnBeginDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0xE4C6B8", Offset = "0xE4C6B8", VA = "0xE4C6B8", Slot = "6")]
		public void OnEndDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0xE4C6F0", Offset = "0xE4C6F0", VA = "0xE4C6F0")]
		public void OnScrollbarDragStart(BaseEventData data)
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0xE4C710", Offset = "0xE4C710", VA = "0xE4C710")]
		public void OnScrollbarDragEnd(BaseEventData data)
		{
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0xE4C664", Offset = "0xE4C664", VA = "0xE4C664")]
		private bool IsScrollbarAtBottom()
		{
			return default(bool);
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0xE4C748", Offset = "0xE4C748", VA = "0xE4C748")]
		public DebugsOnScrollListener()
		{
		}
	}
}
namespace UnityAsyncAwaitUtil
{
	[Token(Token = "0x200004D")]
	public class AsyncCoroutineRunner : MonoBehaviour
	{
		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static AsyncCoroutineRunner _instance;

		[Token(Token = "0x17000023")]
		public static AsyncCoroutineRunner Instance
		{
			[Token(Token = "0x600026E")]
			[Address(RVA = "0x120BD9C", Offset = "0x120BD9C", VA = "0x120BD9C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x120BE90", Offset = "0x120BE90", VA = "0x120BE90")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x120BF2C", Offset = "0x120BF2C", VA = "0x120BF2C")]
		public AsyncCoroutineRunner()
		{
		}
	}
	[Token(Token = "0x200004E")]
	public static class SyncContextUtil
	{
		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994AF8", Offset = "0x994AF8")]
		private static int <UnityThreadId>k__BackingField;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994B08", Offset = "0x994B08")]
		private static SynchronizationContext <UnitySynchronizationContext>k__BackingField;

		[Token(Token = "0x17000024")]
		public static int UnityThreadId
		{
			[Token(Token = "0x6000272")]
			[Address(RVA = "0x1211CA8", Offset = "0x1211CA8", VA = "0x1211CA8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x995CB0", Offset = "0x995CB0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000273")]
			[Address(RVA = "0x1211CF8", Offset = "0x1211CF8", VA = "0x1211CF8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x995CC0", Offset = "0x995CC0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000025")]
		public static SynchronizationContext UnitySynchronizationContext
		{
			[Token(Token = "0x6000274")]
			[Address(RVA = "0x1211D4C", Offset = "0x1211D4C", VA = "0x1211D4C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x995CD0", Offset = "0x995CD0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000275")]
			[Address(RVA = "0x1211D9C", Offset = "0x1211D9C", VA = "0x1211D9C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x995CE0", Offset = "0x995CE0")]
			private set
			{
			}
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x1211BF0", Offset = "0x1211BF0", VA = "0x1211BF0")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x995C9C", Offset = "0x995C9C")]
		private static void Install()
		{
		}
	}
	[Token(Token = "0x200004F")]
	public class AsyncUtilTests : MonoBehaviour
	{
		[Token(Token = "0x200008D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x993D94", Offset = "0x993D94")]
		private sealed class <RunAsyncFromCoroutineTest>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400029D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400029E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400029F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AsyncUtilTests <>4__this;

			[Token(Token = "0x1700005D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000372")]
				[Address(RVA = "0x120ED9C", Offset = "0x120ED9C", VA = "0x120ED9C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700005E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000374")]
				[Address(RVA = "0x120EE08", Offset = "0x120EE08", VA = "0x120EE08", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600036F")]
			[Address(RVA = "0x120D184", Offset = "0x120D184", VA = "0x120D184")]
			[DebuggerHidden]
			public <RunAsyncFromCoroutineTest>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x6000370")]
			[Address(RVA = "0x120EC10", Offset = "0x120EC10", VA = "0x120EC10", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000371")]
			[Address(RVA = "0x120EC14", Offset = "0x120EC14", VA = "0x120EC14", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000373")]
			[Address(RVA = "0x120EDA4", Offset = "0x120EDA4", VA = "0x120EDA4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200008E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x993DA4", Offset = "0x993DA4")]
		private struct <RunMultipleThreadsTestAsync>d__7 : IAsyncStateMachine
		{
			[Token(Token = "0x40002A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40002A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40002A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AsyncUtilTests <>4__this;

			[Token(Token = "0x40002A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private TaskAwaiter <>u__1;

			[Token(Token = "0x40002A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2;

			[Token(Token = "0x40002A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private object <>u__3;

			[Token(Token = "0x6000375")]
			[Address(RVA = "0xA669F4", Offset = "0xA669F4", VA = "0xA669F4", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000376")]
			[Address(RVA = "0xA669FC", Offset = "0xA669FC", VA = "0xA669FC", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200008F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x993DB4", Offset = "0x993DB4")]
		private struct <RunMultipleThreadsTestAsyncWait>d__8 : IAsyncStateMachine
		{
			[Token(Token = "0x40002A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40002A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40002A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AsyncUtilTests <>4__this;

			[Token(Token = "0x40002A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private object <>u__1;

			[Token(Token = "0x6000377")]
			[Address(RVA = "0xA66A08", Offset = "0xA66A08", VA = "0xA66A08", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000378")]
			[Address(RVA = "0xA66A10", Offset = "0xA66A10", VA = "0xA66A10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000090")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x993DC4", Offset = "0x993DC4")]
		private struct <RunAsyncFromCoroutineTest2>d__10 : IAsyncStateMachine
		{
			[Token(Token = "0x40002AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40002AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40002AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private object <>u__1;

			[Token(Token = "0x6000379")]
			[Address(RVA = "0xA66954", Offset = "0xA66954", VA = "0xA66954", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x600037A")]
			[Address(RVA = "0xA6695C", Offset = "0xA6695C", VA = "0xA6695C", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000091")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x993DD4", Offset = "0x993DD4")]
		private struct <RunWwwAsync>d__11 : IAsyncStateMachine
		{
			[Token(Token = "0x40002AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40002AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40002AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private object <>u__1;

			[Token(Token = "0x600037B")]
			[Address(RVA = "0xA66A6C", Offset = "0xA66A6C", VA = "0xA66A6C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x600037C")]
			[Address(RVA = "0xA66A74", Offset = "0xA66A74", VA = "0xA66A74", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000092")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x993DE4", Offset = "0x993DE4")]
		private struct <RunOpenNotepadTestAsync>d__12 : IAsyncStateMachine
		{
			[Token(Token = "0x40002B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40002B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40002B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private TaskAwaiter<int> <>u__1;

			[Token(Token = "0x600037D")]
			[Address(RVA = "0xA66A1C", Offset = "0xA66A1C", VA = "0xA66A1C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x600037E")]
			[Address(RVA = "0xA66A24", Offset = "0xA66A24", VA = "0xA66A24", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000093")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x993DF4", Offset = "0x993DF4")]
		private struct <RunUnhandledExceptionTestAsync>d__13 : IAsyncStateMachine
		{
			[Token(Token = "0x40002B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40002B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40002B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AsyncUtilTests <>4__this;

			[Token(Token = "0x40002B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private TaskAwaiter <>u__1;

			[Token(Token = "0x600037F")]
			[Address(RVA = "0xA66A58", Offset = "0xA66A58", VA = "0xA66A58", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000380")]
			[Address(RVA = "0xA66A60", Offset = "0xA66A60", VA = "0xA66A60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000094")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x993E04", Offset = "0x993E04")]
		private struct <RunTryCatchExceptionTestAsync>d__14 : IAsyncStateMachine
		{
			[Token(Token = "0x40002B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40002B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40002B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AsyncUtilTests <>4__this;

			[Token(Token = "0x40002BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private TaskAwaiter <>u__1;

			[Token(Token = "0x6000381")]
			[Address(RVA = "0xA66A44", Offset = "0xA66A44", VA = "0xA66A44", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000382")]
			[Address(RVA = "0xA66A4C", Offset = "0xA66A4C", VA = "0xA66A4C", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000095")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x993E14", Offset = "0x993E14")]
		private struct <NestedRunAsync>d__15 : IAsyncStateMachine
		{
			[Token(Token = "0x40002BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40002BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40002BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private object <>u__1;

			[Token(Token = "0x6000383")]
			[Address(RVA = "0xA66940", Offset = "0xA66940", VA = "0xA66940", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000384")]
			[Address(RVA = "0xA66948", Offset = "0xA66948", VA = "0xA66948", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000096")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x993E24", Offset = "0x993E24")]
		private struct <WaitThenThrowException>d__16 : IAsyncStateMachine
		{
			[Token(Token = "0x40002BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40002BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40002C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private object <>u__1;

			[Token(Token = "0x6000385")]
			[Address(RVA = "0xA66A80", Offset = "0xA66A80", VA = "0xA66A80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000386")]
			[Address(RVA = "0xA66A88", Offset = "0xA66A88", VA = "0xA66A88", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000097")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x993E34", Offset = "0x993E34")]
		private struct <RunAsyncOperationAsync>d__17 : IAsyncStateMachine
		{
			[Token(Token = "0x40002C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40002C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40002C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AsyncUtilTests <>4__this;

			[Token(Token = "0x40002C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private TaskAwaiter <>u__1;

			[Token(Token = "0x6000387")]
			[Address(RVA = "0xA66968", Offset = "0xA66968", VA = "0xA66968", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000388")]
			[Address(RVA = "0xA66970", Offset = "0xA66970", VA = "0xA66970", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000098")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x993E44", Offset = "0x993E44")]
		private struct <InstantiateAssetBundleAsync>d__18 : IAsyncStateMachine
		{
			[Token(Token = "0x40002C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40002C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40002C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AsyncUtilTests <>4__this;

			[Token(Token = "0x40002C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string abUrl;

			[Token(Token = "0x40002C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string assetName;

			[Token(Token = "0x40002CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private AssetBundle <assetBundle>5__2;

			[Token(Token = "0x40002CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private TaskAwaiter<byte[]> <>u__1;

			[Token(Token = "0x40002CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private object <>u__2;

			[Token(Token = "0x6000389")]
			[Address(RVA = "0xA6692C", Offset = "0xA6692C", VA = "0xA6692C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x600038A")]
			[Address(RVA = "0xA66934", Offset = "0xA66934", VA = "0xA66934", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000099")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x993E54", Offset = "0x993E54")]
		private struct <DownloadRawDataAsync>d__19 : IAsyncStateMachine
		{
			[Token(Token = "0x40002CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40002CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<byte[]> <>t__builder;

			[Token(Token = "0x40002CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string url;

			[Token(Token = "0x40002D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UnityWebRequest <request>5__2;

			[Token(Token = "0x40002D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private object <>u__1;

			[Token(Token = "0x600038B")]
			[Address(RVA = "0xA6690C", Offset = "0xA6690C", VA = "0xA6690C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x600038C")]
			[Address(RVA = "0xA66914", Offset = "0xA66914", VA = "0xA66914", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200009A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x993E64", Offset = "0x993E64")]
		private struct <RunIEnumeratorTryCatchExceptionAsync>d__20 : IAsyncStateMachine
		{
			[Token(Token = "0x40002D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40002D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40002D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AsyncUtilTests <>4__this;

			[Token(Token = "0x40002D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private object <>u__1;

			[Token(Token = "0x600038D")]
			[Address(RVA = "0xA669B8", Offset = "0xA669B8", VA = "0xA669B8", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x600038E")]
			[Address(RVA = "0xA669C0", Offset = "0xA669C0", VA = "0xA669C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200009B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x993E74", Offset = "0x993E74")]
		private struct <RunIEnumeratorUnhandledExceptionAsync>d__21 : IAsyncStateMachine
		{
			[Token(Token = "0x40002D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40002D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40002D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AsyncUtilTests <>4__this;

			[Token(Token = "0x40002D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private object <>u__1;

			[Token(Token = "0x600038F")]
			[Address(RVA = "0xA669CC", Offset = "0xA669CC", VA = "0xA669CC", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000390")]
			[Address(RVA = "0xA669D4", Offset = "0xA669D4", VA = "0xA669D4", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x200009C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x993E84", Offset = "0x993E84")]
		private sealed class <WaitThenThrow>d__22 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40002DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40002DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AsyncUtilTests <>4__this;

			[Token(Token = "0x1700005F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000394")]
				[Address(RVA = "0x12117B0", Offset = "0x12117B0", VA = "0x12117B0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000060")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000396")]
				[Address(RVA = "0x121181C", Offset = "0x121181C", VA = "0x121181C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000391")]
			[Address(RVA = "0x120D9F0", Offset = "0x120D9F0", VA = "0x120D9F0")]
			[DebuggerHidden]
			public <WaitThenThrow>d__22(int <>1__state)
			{
			}

			[Token(Token = "0x6000392")]
			[Address(RVA = "0x1211738", Offset = "0x1211738", VA = "0x1211738", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000393")]
			[Address(RVA = "0x121173C", Offset = "0x121173C", VA = "0x121173C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000395")]
			[Address(RVA = "0x12117B8", Offset = "0x12117B8", VA = "0x12117B8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200009D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x993E94", Offset = "0x993E94")]
		private sealed class <WaitThenThrowNested>d__23 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40002DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x17000061")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600039A")]
				[Address(RVA = "0x1211B7C", Offset = "0x1211B7C", VA = "0x1211B7C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000062")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600039C")]
				[Address(RVA = "0x1211BE8", Offset = "0x1211BE8", VA = "0x1211BE8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000397")]
			[Address(RVA = "0x120DA7C", Offset = "0x120DA7C", VA = "0x120DA7C")]
			[DebuggerHidden]
			public <WaitThenThrowNested>d__23(int <>1__state)
			{
			}

			[Token(Token = "0x6000398")]
			[Address(RVA = "0x1211A64", Offset = "0x1211A64", VA = "0x1211A64", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000399")]
			[Address(RVA = "0x1211A68", Offset = "0x1211A68", VA = "0x1211A68", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600039B")]
			[Address(RVA = "0x1211B84", Offset = "0x1211B84", VA = "0x1211B84", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200009E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x993EA4", Offset = "0x993EA4")]
		private struct <RunIEnumeratorStringTestAsync>d__24 : IAsyncStateMachine
		{
			[Token(Token = "0x40002DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40002E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40002E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AsyncUtilTests <>4__this;

			[Token(Token = "0x40002E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private object <>u__1;

			[Token(Token = "0x600039D")]
			[Address(RVA = "0xA66990", Offset = "0xA66990", VA = "0xA66990", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x600039E")]
			[Address(RVA = "0xA66998", Offset = "0xA66998", VA = "0xA66998", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200009F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x993EB4", Offset = "0x993EB4")]
		private struct <RunIEnumeratorUntypedStringTestAsync>d__25 : IAsyncStateMachine
		{
			[Token(Token = "0x40002E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40002E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40002E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AsyncUtilTests <>4__this;

			[Token(Token = "0x40002E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private object <>u__1;

			[Token(Token = "0x600039F")]
			[Address(RVA = "0xA669E0", Offset = "0xA669E0", VA = "0xA669E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60003A0")]
			[Address(RVA = "0xA669E8", Offset = "0xA669E8", VA = "0xA669E8", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20000A0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x993EC4", Offset = "0x993EC4")]
		private struct <RunIEnumeratorTestAsync>d__26 : IAsyncStateMachine
		{
			[Token(Token = "0x40002E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40002E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40002E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AsyncUtilTests <>4__this;

			[Token(Token = "0x40002EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private object <>u__1;

			[Token(Token = "0x60003A1")]
			[Address(RVA = "0xA669A4", Offset = "0xA669A4", VA = "0xA669A4", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60003A2")]
			[Address(RVA = "0xA669AC", Offset = "0xA669AC", VA = "0xA669AC", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x20000A1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x993ED4", Offset = "0x993ED4")]
		private sealed class <WaitForString>d__27 : IEnumerator<string>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40002EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private string <>2__current;

			[Token(Token = "0x40002ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private float <startTime>5__2;

			[Token(Token = "0x17000063")]
			private string System.Collections.Generic.IEnumerator<System.String>.Current
			{
				[Token(Token = "0x60003A6")]
				[Address(RVA = "0x1211580", Offset = "0x1211580", VA = "0x1211580", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000064")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60003A8")]
				[Address(RVA = "0x12115EC", Offset = "0x12115EC", VA = "0x12115EC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003A3")]
			[Address(RVA = "0x120DB08", Offset = "0x120DB08", VA = "0x120DB08")]
			[DebuggerHidden]
			public <WaitForString>d__27(int <>1__state)
			{
			}

			[Token(Token = "0x60003A4")]
			[Address(RVA = "0x1211494", Offset = "0x1211494", VA = "0x1211494", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60003A5")]
			[Address(RVA = "0x1211498", Offset = "0x1211498", VA = "0x1211498", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003A7")]
			[Address(RVA = "0x1211588", Offset = "0x1211588", VA = "0x1211588", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000A2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x993EE4", Offset = "0x993EE4")]
		private sealed class <WaitForStringUntyped>d__28 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40002EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40002F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AsyncUtilTests <>4__this;

			[Token(Token = "0x17000065")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60003AC")]
				[Address(RVA = "0x12116C4", Offset = "0x12116C4", VA = "0x12116C4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000066")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60003AE")]
				[Address(RVA = "0x1211730", Offset = "0x1211730", VA = "0x1211730", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003A9")]
			[Address(RVA = "0x120DBB4", Offset = "0x120DBB4", VA = "0x120DBB4")]
			[DebuggerHidden]
			public <WaitForStringUntyped>d__28(int <>1__state)
			{
			}

			[Token(Token = "0x60003AA")]
			[Address(RVA = "0x12115F4", Offset = "0x12115F4", VA = "0x12115F4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60003AB")]
			[Address(RVA = "0x12115F8", Offset = "0x12115F8", VA = "0x12115F8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003AD")]
			[Address(RVA = "0x12116CC", Offset = "0x12116CC", VA = "0x12116CC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000A3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x993EF4", Offset = "0x993EF4")]
		private sealed class <WaitABit>d__29 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40002F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x17000067")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60003B2")]
				[Address(RVA = "0x1211420", Offset = "0x1211420", VA = "0x1211420", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000068")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60003B4")]
				[Address(RVA = "0x121148C", Offset = "0x121148C", VA = "0x121148C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003AF")]
			[Address(RVA = "0x120DC40", Offset = "0x120DC40", VA = "0x120DC40")]
			[DebuggerHidden]
			public <WaitABit>d__29(int <>1__state)
			{
			}

			[Token(Token = "0x60003B0")]
			[Address(RVA = "0x121137C", Offset = "0x121137C", VA = "0x121137C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60003B1")]
			[Address(RVA = "0x1211380", Offset = "0x1211380", VA = "0x1211380", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003B3")]
			[Address(RVA = "0x1211428", Offset = "0x1211428", VA = "0x1211428", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20000A4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x993F04", Offset = "0x993F04")]
		private struct <RunReturnValueTestAsync>d__30 : IAsyncStateMachine
		{
			[Token(Token = "0x40002F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40002F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40002F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AsyncUtilTests <>4__this;

			[Token(Token = "0x40002F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private TaskAwaiter<string> <>u__1;

			[Token(Token = "0x60003B5")]
			[Address(RVA = "0xA66A30", Offset = "0xA66A30", VA = "0xA66A30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60003B6")]
			[Address(RVA = "0xA66A38", Offset = "0xA66A38", VA = "0xA66A38", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20000A5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x993F14", Offset = "0x993F14")]
		private struct <GetValueExampleAsync>d__31 : IAsyncStateMachine
		{
			[Token(Token = "0x40002F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40002F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<string> <>t__builder;

			[Token(Token = "0x40002F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private object <>u__1;

			[Token(Token = "0x60003B7")]
			[Address(RVA = "0xA6691C", Offset = "0xA6691C", VA = "0xA6691C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60003B8")]
			[Address(RVA = "0xA66924", Offset = "0xA66924", VA = "0xA66924", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20000A6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x993F24", Offset = "0x993F24")]
		private struct <RunAwaitSecondsTestAsync>d__32 : IAsyncStateMachine
		{
			[Token(Token = "0x40002FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40002FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40002FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private object <>u__1;

			[Token(Token = "0x60003B9")]
			[Address(RVA = "0xA6697C", Offset = "0xA6697C", VA = "0xA6697C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60003BA")]
			[Address(RVA = "0xA66984", Offset = "0xA66984", VA = "0xA66984", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40001CB")]
		private const string AssetBundleSampleUrl = "http://www.stevevermeulen.com/wp-content/uploads/2017/09/teapot.unity3d";

		[Token(Token = "0x40001CC")]
		private const string AssetBundleSampleAssetName = "Teapot";

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TestButtonHandler.Settings _buttonSettings;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TestButtonHandler _buttonHandler;

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x120BF34", Offset = "0x120BF34", VA = "0x120BF34")]
		public void Awake()
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x120BFEC", Offset = "0x120BFEC", VA = "0x120BFEC")]
		public void OnGUI()
		{
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x120CFF8", Offset = "0x120CFF8", VA = "0x120CFF8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x995CF0", Offset = "0x995CF0")]
		private IEnumerator RunAsyncFromCoroutineTest()
		{
			return null;
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x120D078", Offset = "0x120D078", VA = "0x120D078")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x995D54", Offset = "0x995D54")]
		private Task RunMultipleThreadsTestAsync()
		{
			return null;
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x120D1B0", Offset = "0x120D1B0", VA = "0x120D1B0")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x995DB8", Offset = "0x995DB8")]
		private Task RunMultipleThreadsTestAsyncWait()
		{
			return null;
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x120D2B8", Offset = "0x120D2B8", VA = "0x120D2B8")]
		private void PrintCurrentThreadContext([Optional] string prefix)
		{
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x120D400", Offset = "0x120D400", VA = "0x120D400")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x995E1C", Offset = "0x995E1C")]
		private Task RunAsyncFromCoroutineTest2()
		{
			return null;
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x120CEFC", Offset = "0x120CEFC", VA = "0x120CEFC")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x995E80", Offset = "0x995E80")]
		private Task RunWwwAsync()
		{
			return null;
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x120CE00", Offset = "0x120CE00", VA = "0x120CE00")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x995EE4", Offset = "0x995EE4")]
		private Task RunOpenNotepadTestAsync()
		{
			return null;
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x120C6C8", Offset = "0x120C6C8", VA = "0x120C6C8")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x995F48", Offset = "0x995F48")]
		private Task RunUnhandledExceptionTestAsync()
		{
			return null;
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x120C5C0", Offset = "0x120C5C0", VA = "0x120C5C0")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x995FAC", Offset = "0x995FAC")]
		private Task RunTryCatchExceptionTestAsync()
		{
			return null;
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x120D4FC", Offset = "0x120D4FC", VA = "0x120D4FC")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x996010", Offset = "0x996010")]
		private Task NestedRunAsync()
		{
			return null;
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x120D5F8", Offset = "0x120D5F8", VA = "0x120D5F8")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x996074", Offset = "0x996074")]
		private Task WaitThenThrowException()
		{
			return null;
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x120CCF8", Offset = "0x120CCF8", VA = "0x120CCF8")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x9960D8", Offset = "0x9960D8")]
		private Task RunAsyncOperationAsync()
		{
			return null;
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x120D6F4", Offset = "0x120D6F4", VA = "0x120D6F4")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x99613C", Offset = "0x99613C")]
		private Task InstantiateAssetBundleAsync(string abUrl, string assetName)
		{
			return null;
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x120D838", Offset = "0x120D838", VA = "0x120D838")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x9961A0", Offset = "0x9961A0")]
		private Task<byte[]> DownloadRawDataAsync(string url)
		{
			return null;
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x120CBF0", Offset = "0x120CBF0", VA = "0x120CBF0")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x996204", Offset = "0x996204")]
		private Task RunIEnumeratorTryCatchExceptionAsync()
		{
			return null;
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x120CAE8", Offset = "0x120CAE8", VA = "0x120CAE8")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x996268", Offset = "0x996268")]
		private Task RunIEnumeratorUnhandledExceptionAsync()
		{
			return null;
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x120D970", Offset = "0x120D970", VA = "0x120D970")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9962CC", Offset = "0x9962CC")]
		private IEnumerator WaitThenThrow()
		{
			return null;
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x120DA1C", Offset = "0x120DA1C", VA = "0x120DA1C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x996330", Offset = "0x996330")]
		private IEnumerator WaitThenThrowNested()
		{
			return null;
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x120C9E0", Offset = "0x120C9E0", VA = "0x120C9E0")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x996394", Offset = "0x996394")]
		private Task RunIEnumeratorStringTestAsync()
		{
			return null;
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x120C8D8", Offset = "0x120C8D8", VA = "0x120C8D8")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x9963F8", Offset = "0x9963F8")]
		private Task RunIEnumeratorUntypedStringTestAsync()
		{
			return null;
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x120C7D0", Offset = "0x120C7D0", VA = "0x120C7D0")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x99645C", Offset = "0x99645C")]
		private Task RunIEnumeratorTestAsync()
		{
			return null;
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x120DAA8", Offset = "0x120DAA8", VA = "0x120DAA8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9964C0", Offset = "0x9964C0")]
		private IEnumerator<string> WaitForString()
		{
			return null;
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x120DB34", Offset = "0x120DB34", VA = "0x120DB34")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x996524", Offset = "0x996524")]
		private IEnumerator WaitForStringUntyped()
		{
			return null;
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x120DBE0", Offset = "0x120DBE0", VA = "0x120DBE0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x996588", Offset = "0x996588")]
		private IEnumerator WaitABit()
		{
			return null;
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x120C4B8", Offset = "0x120C4B8", VA = "0x120C4B8")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x9965EC", Offset = "0x9965EC")]
		private Task RunReturnValueTestAsync()
		{
			return null;
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x120DC6C", Offset = "0x120DC6C", VA = "0x120DC6C")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x996650", Offset = "0x996650")]
		private Task<string> GetValueExampleAsync()
		{
			return null;
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x120C3BC", Offset = "0x120C3BC", VA = "0x120C3BC")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x9966B4", Offset = "0x9966B4")]
		private Task RunAwaitSecondsTestAsync()
		{
			return null;
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x120DD78", Offset = "0x120DD78", VA = "0x120DD78")]
		public AsyncUtilTests()
		{
		}
	}
	[Token(Token = "0x2000050")]
	public class TestButtonHandler
	{
		[Serializable]
		[Token(Token = "0x20000A7")]
		public class Settings
		{
			[Token(Token = "0x40002FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int NumPerColumn;

			[Token(Token = "0x40002FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float VerticalMargin;

			[Token(Token = "0x40002FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float VerticalSpacing;

			[Token(Token = "0x4000300")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float HorizontalSpacing;

			[Token(Token = "0x4000301")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float HorizontalMargin;

			[Token(Token = "0x4000302")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public float ButtonWidth;

			[Token(Token = "0x4000303")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float ButtonHeight;

			[Token(Token = "0x60003BB")]
			[Address(RVA = "0x1211DF4", Offset = "0x1211DF4", VA = "0x1211DF4")]
			public Settings()
			{
			}
		}

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Settings _settings;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int _buttonVCount;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private int _buttonHCount;

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x120BFB8", Offset = "0x120BFB8", VA = "0x120BFB8")]
		public TestButtonHandler(Settings settings)
		{
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x120C2AC", Offset = "0x120C2AC", VA = "0x120C2AC")]
		public void Restart()
		{
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x120C2B4", Offset = "0x120C2B4", VA = "0x120C2B4")]
		public bool Display(string text)
		{
			return default(bool);
		}
	}
}
