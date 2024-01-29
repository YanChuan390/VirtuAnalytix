using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using FMOD;
using FMOD.Studio;
using FMODUnity;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Networking;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;
using UnityEngine.Timeline;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public static class AwaitExtensions
{
	[Token(Token = "0x2000188")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x831B24", Offset = "0x831B24")]
	private sealed class <>c__DisplayClass0_0
	{
		[Token(Token = "0x40008BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public TaskCompletionSource<int> tcs;

		[Token(Token = "0x40008BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Process process;

		[Token(Token = "0x6000C4F")]
		[Address(RVA = "0x121D790", Offset = "0x121D790", VA = "0x121D790")]
		public <>c__DisplayClass0_0()
		{
		}

		[Token(Token = "0x6000C50")]
		[Address(RVA = "0x121D858", Offset = "0x121D858", VA = "0x121D858")]
		internal void <GetAwaiter>b__0(object s, EventArgs e)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x2000189")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x831B34", Offset = "0x831B34")]
	private struct <WrapErrors>d__1 : IAsyncStateMachine
	{
		[Token(Token = "0x40008BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x40008BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Token(Token = "0x40008C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Task task;

		[Token(Token = "0x40008C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TaskAwaiter <>u__1;

		[Token(Token = "0x6000C51")]
		[Address(RVA = "0x8E43DC", Offset = "0x8E43DC", VA = "0x8E43DC", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000C52")]
		[Address(RVA = "0x8E43E4", Offset = "0x8E43E4", VA = "0x8E43E4", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x121D640", Offset = "0x121D640", VA = "0x121D640")]
	public static TaskAwaiter<int> GetAwaiter(this Process process)
	{
		return default(TaskAwaiter<int>);
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x121D798", Offset = "0x121D798", VA = "0x121D798")]
	[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x835AD4", Offset = "0x835AD4")]
	public static void WrapErrors(this Task task)
	{
	}
}
[Token(Token = "0x2000003")]
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
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x121DA48", Offset = "0x121DA48", VA = "0x121DA48")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000002")]
	public static WaitForFixedUpdate FixedUpdate
	{
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x121DAB0", Offset = "0x121DAB0", VA = "0x121DAB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000003")]
	public static WaitForEndOfFrame EndOfFrame
	{
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x121DB18", Offset = "0x121DB18", VA = "0x121DB18")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x121DB80", Offset = "0x121DB80", VA = "0x121DB80")]
	public static WaitForSeconds Seconds(float seconds)
	{
		return null;
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x121DBEC", Offset = "0x121DBEC", VA = "0x121DBEC")]
	public static WaitForSecondsRealtime SecondsRealtime(float seconds)
	{
		return null;
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x121DC58", Offset = "0x121DC58", VA = "0x121DC58")]
	public static WaitUntil Until(Func<bool> predicate)
	{
		return null;
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x121DCBC", Offset = "0x121DCBC", VA = "0x121DCBC")]
	public static WaitWhile While(Func<bool> predicate)
	{
		return null;
	}
}
[Token(Token = "0x2000004")]
public static class IEnumeratorAwaitExtensions
{
	[Token(Token = "0x200018A")]
	public class SimpleCoroutineAwaiter<T> : INotifyCompletion
	{
		[Token(Token = "0x40008C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool _isDone;

		[Token(Token = "0x40008C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Exception _exception;

		[Token(Token = "0x40008C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Action _continuation;

		[Token(Token = "0x40008C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T _result;

		[Token(Token = "0x170000CA")]
		public bool IsCompleted
		{
			[Token(Token = "0x6000C53")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000C54")]
		public T GetResult()
		{
			return (T)null;
		}

		[Token(Token = "0x6000C55")]
		public void Complete(T result, Exception e)
		{
		}

		[Token(Token = "0x6000C56")]
		private void System.Runtime.CompilerServices.INotifyCompletion.OnCompleted(Action continuation)
		{
		}

		[Token(Token = "0x6000C57")]
		public SimpleCoroutineAwaiter()
		{
		}
	}

	[Token(Token = "0x200018B")]
	public class SimpleCoroutineAwaiter : INotifyCompletion
	{
		[Token(Token = "0x40008C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool _isDone;

		[Token(Token = "0x40008C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Exception _exception;

		[Token(Token = "0x40008C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Action _continuation;

		[Token(Token = "0x170000CB")]
		public bool IsCompleted
		{
			[Token(Token = "0x6000C58")]
			[Address(RVA = "0xD02468", Offset = "0xD02468", VA = "0xD02468")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000C59")]
		[Address(RVA = "0xD02470", Offset = "0xD02470", VA = "0xD02470")]
		public void GetResult()
		{
		}

		[Token(Token = "0x6000C5A")]
		[Address(RVA = "0xD023A8", Offset = "0xD023A8", VA = "0xD023A8")]
		public void Complete(Exception e)
		{
		}

		[Token(Token = "0x6000C5B")]
		[Address(RVA = "0xD024BC", Offset = "0xD024BC", VA = "0xD024BC", Slot = "4")]
		private void System.Runtime.CompilerServices.INotifyCompletion.OnCompleted(Action continuation)
		{
		}

		[Token(Token = "0x6000C5C")]
		[Address(RVA = "0xD01AD4", Offset = "0xD01AD4", VA = "0xD01AD4")]
		public SimpleCoroutineAwaiter()
		{
		}
	}

	[Token(Token = "0x200018C")]
	private class CoroutineWrapper<T>
	{
		[Token(Token = "0x2000224")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x831E64", Offset = "0x831E64")]
		private sealed class <Run>d__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000B7C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <>1__state;

			[Token(Token = "0x4000B7D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private object <>2__current;

			[Token(Token = "0x4000B7E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public CoroutineWrapper<T> <>4__this;

			[Token(Token = "0x17000124")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000E29")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000125")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000E2B")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000E26")]
			[DebuggerHidden]
			public <Run>d__3(int <>1__state)
			{
			}

			[Token(Token = "0x6000E27")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000E28")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000E2A")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40008C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly SimpleCoroutineAwaiter<T> _awaiter;

		[Token(Token = "0x40008CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly Stack<IEnumerator> _processStack;

		[Token(Token = "0x6000C5D")]
		public CoroutineWrapper(IEnumerator coroutine, SimpleCoroutineAwaiter<T> awaiter)
		{
		}

		[Token(Token = "0x6000C5E")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x836B5C", Offset = "0x836B5C")]
		public IEnumerator Run()
		{
			return null;
		}

		[Token(Token = "0x6000C5F")]
		private string GenerateObjectTraceMessage(List<Type> objTrace)
		{
			return null;
		}

		[Token(Token = "0x6000C60")]
		private static List<Type> GenerateObjectTrace(IEnumerable<IEnumerator> enumerators)
		{
			return null;
		}
	}

	[Token(Token = "0x200018D")]
	private static class InstructionWrappers
	{
		[Token(Token = "0x2000225")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x831E74", Offset = "0x831E74")]
		private sealed class <ReturnVoid>d__0 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000B7F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000B80")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000B81")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object instruction;

			[Token(Token = "0x4000B82")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public SimpleCoroutineAwaiter awaiter;

			[Token(Token = "0x17000126")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000E2F")]
				[Address(RVA = "0xD023F8", Offset = "0xD023F8", VA = "0xD023F8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000127")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000E31")]
				[Address(RVA = "0xD02460", Offset = "0xD02460", VA = "0xD02460", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000E2C")]
			[Address(RVA = "0xD01F44", Offset = "0xD01F44", VA = "0xD01F44")]
			[DebuggerHidden]
			public <ReturnVoid>d__0(int <>1__state)
			{
			}

			[Token(Token = "0x6000E2D")]
			[Address(RVA = "0xD02348", Offset = "0xD02348", VA = "0xD02348", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000E2E")]
			[Address(RVA = "0xD0234C", Offset = "0xD0234C", VA = "0xD0234C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000E30")]
			[Address(RVA = "0xD02400", Offset = "0xD02400", VA = "0xD02400", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000226")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x831E84", Offset = "0x831E84")]
		private sealed class <AssetBundleCreateRequest>d__1 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000B83")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000B84")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000B85")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AssetBundleCreateRequest instruction;

			[Token(Token = "0x4000B86")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public SimpleCoroutineAwaiter<AssetBundle> awaiter;

			[Token(Token = "0x17000128")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000E35")]
				[Address(RVA = "0xD020A0", Offset = "0xD020A0", VA = "0xD020A0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000129")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000E37")]
				[Address(RVA = "0xD02108", Offset = "0xD02108", VA = "0xD02108", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000E32")]
			[Address(RVA = "0xD01F70", Offset = "0xD01F70", VA = "0xD01F70")]
			[DebuggerHidden]
			public <AssetBundleCreateRequest>d__1(int <>1__state)
			{
			}

			[Token(Token = "0x6000E33")]
			[Address(RVA = "0xD01FF4", Offset = "0xD01FF4", VA = "0xD01FF4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000E34")]
			[Address(RVA = "0xD01FF8", Offset = "0xD01FF8", VA = "0xD01FF8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000E36")]
			[Address(RVA = "0xD020A8", Offset = "0xD020A8", VA = "0xD020A8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000227")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x831E94", Offset = "0x831E94")]
		private sealed class <ReturnSelf>d__2<T> : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000B87")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <>1__state;

			[Token(Token = "0x4000B88")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private object <>2__current;

			[Token(Token = "0x4000B89")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public T instruction;

			[Token(Token = "0x4000B8A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public SimpleCoroutineAwaiter<T> awaiter;

			[Token(Token = "0x1700012A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000E3B")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700012B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000E3D")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000E38")]
			[DebuggerHidden]
			public <ReturnSelf>d__2(int <>1__state)
			{
			}

			[Token(Token = "0x6000E39")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000E3A")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000E3C")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000228")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x831EA4", Offset = "0x831EA4")]
		private sealed class <AssetBundleRequest>d__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000B8B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000B8C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000B8D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AssetBundleRequest instruction;

			[Token(Token = "0x4000B8E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public SimpleCoroutineAwaiter<UnityEngine.Object> awaiter;

			[Token(Token = "0x1700012C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000E41")]
				[Address(RVA = "0xD021BC", Offset = "0xD021BC", VA = "0xD021BC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700012D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000E43")]
				[Address(RVA = "0xD02224", Offset = "0xD02224", VA = "0xD02224", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000E3E")]
			[Address(RVA = "0xD01F9C", Offset = "0xD01F9C", VA = "0xD01F9C")]
			[DebuggerHidden]
			public <AssetBundleRequest>d__3(int <>1__state)
			{
			}

			[Token(Token = "0x6000E3F")]
			[Address(RVA = "0xD02110", Offset = "0xD02110", VA = "0xD02110", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000E40")]
			[Address(RVA = "0xD02114", Offset = "0xD02114", VA = "0xD02114", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000E42")]
			[Address(RVA = "0xD021C4", Offset = "0xD021C4", VA = "0xD021C4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000229")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x831EB4", Offset = "0x831EB4")]
		private sealed class <ResourceRequest>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000B8F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000B90")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000B91")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ResourceRequest instruction;

			[Token(Token = "0x4000B92")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public SimpleCoroutineAwaiter<UnityEngine.Object> awaiter;

			[Token(Token = "0x1700012E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000E47")]
				[Address(RVA = "0xD022D8", Offset = "0xD022D8", VA = "0xD022D8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700012F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000E49")]
				[Address(RVA = "0xD02340", Offset = "0xD02340", VA = "0xD02340", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000E44")]
			[Address(RVA = "0xD01FC8", Offset = "0xD01FC8", VA = "0xD01FC8")]
			[DebuggerHidden]
			public <ResourceRequest>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000E45")]
			[Address(RVA = "0xD0222C", Offset = "0xD0222C", VA = "0xD0222C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000E46")]
			[Address(RVA = "0xD02230", Offset = "0xD02230", VA = "0xD02230", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000E48")]
			[Address(RVA = "0xD022E0", Offset = "0xD022E0", VA = "0xD022E0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x6000C61")]
		[Address(RVA = "0xD01DE8", Offset = "0xD01DE8", VA = "0xD01DE8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x836BC0", Offset = "0x836BC0")]
		public static IEnumerator ReturnVoid(SimpleCoroutineAwaiter awaiter, object instruction)
		{
			return null;
		}

		[Token(Token = "0x6000C62")]
		[Address(RVA = "0xD01BAC", Offset = "0xD01BAC", VA = "0xD01BAC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x836C24", Offset = "0x836C24")]
		public static IEnumerator AssetBundleCreateRequest(SimpleCoroutineAwaiter<AssetBundle> awaiter, AssetBundleCreateRequest instruction)
		{
			return null;
		}

		[Token(Token = "0x6000C63")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x836C88", Offset = "0x836C88")]
		public static IEnumerator ReturnSelf<T>(SimpleCoroutineAwaiter<T> awaiter, T instruction)
		{
			return null;
		}

		[Token(Token = "0x6000C64")]
		[Address(RVA = "0xD01C70", Offset = "0xD01C70", VA = "0xD01C70")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x836CEC", Offset = "0x836CEC")]
		public static IEnumerator AssetBundleRequest(SimpleCoroutineAwaiter<UnityEngine.Object> awaiter, AssetBundleRequest instruction)
		{
			return null;
		}

		[Token(Token = "0x6000C65")]
		[Address(RVA = "0xD01EC8", Offset = "0xD01EC8", VA = "0xD01EC8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x836D50", Offset = "0x836D50")]
		public static IEnumerator ResourceRequest(SimpleCoroutineAwaiter<UnityEngine.Object> awaiter, ResourceRequest instruction)
		{
			return null;
		}
	}

	[Token(Token = "0x200018E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x831B44", Offset = "0x831B44")]
	private sealed class <>c__DisplayClass8_0
	{
		[Token(Token = "0x40008CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SimpleCoroutineAwaiter<UnityEngine.Object> awaiter;

		[Token(Token = "0x40008CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ResourceRequest instruction;

		[Token(Token = "0x6000C66")]
		[Address(RVA = "0xD016E8", Offset = "0xD016E8", VA = "0xD016E8")]
		public <>c__DisplayClass8_0()
		{
		}

		[Token(Token = "0x6000C67")]
		[Address(RVA = "0xD01E80", Offset = "0xD01E80", VA = "0xD01E80")]
		internal void <GetAwaiter>b__0()
		{
		}
	}

	[Token(Token = "0x200018F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x831B54", Offset = "0x831B54")]
	private sealed class <>c__DisplayClass10_0
	{
		[Token(Token = "0x40008CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SimpleCoroutineAwaiter<AssetBundle> awaiter;

		[Token(Token = "0x40008CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AssetBundleCreateRequest instruction;

		[Token(Token = "0x6000C68")]
		[Address(RVA = "0xD01924", Offset = "0xD01924", VA = "0xD01924")]
		public <>c__DisplayClass10_0()
		{
		}

		[Token(Token = "0x6000C69")]
		[Address(RVA = "0xD01B64", Offset = "0xD01B64", VA = "0xD01B64")]
		internal void <GetAwaiter>b__0()
		{
		}
	}

	[Token(Token = "0x2000190")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x831B64", Offset = "0x831B64")]
	private sealed class <>c__DisplayClass11_0
	{
		[Token(Token = "0x40008CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SimpleCoroutineAwaiter<UnityEngine.Object> awaiter;

		[Token(Token = "0x40008D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AssetBundleRequest instruction;

		[Token(Token = "0x6000C6A")]
		[Address(RVA = "0xD019F4", Offset = "0xD019F4", VA = "0xD019F4")]
		public <>c__DisplayClass11_0()
		{
		}

		[Token(Token = "0x6000C6B")]
		[Address(RVA = "0xD01C28", Offset = "0xD01C28", VA = "0xD01C28")]
		internal void <GetAwaiter>b__0()
		{
		}
	}

	[Token(Token = "0x2000191")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x831B74", Offset = "0x831B74")]
	private sealed class <>c__DisplayClass12_0<T>
	{
		[Token(Token = "0x40008D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IEnumerator<T> coroutine;

		[Token(Token = "0x40008D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public SimpleCoroutineAwaiter<T> awaiter;

		[Token(Token = "0x6000C6C")]
		public <>c__DisplayClass12_0()
		{
		}

		[Token(Token = "0x6000C6D")]
		internal void <GetAwaiter>b__0()
		{
		}
	}

	[Token(Token = "0x2000192")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x831B84", Offset = "0x831B84")]
	private sealed class <>c__DisplayClass13_0
	{
		[Token(Token = "0x40008D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IEnumerator coroutine;

		[Token(Token = "0x40008D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SimpleCoroutineAwaiter<object> awaiter;

		[Token(Token = "0x6000C6E")]
		[Address(RVA = "0xD01AC4", Offset = "0xD01AC4", VA = "0xD01AC4")]
		public <>c__DisplayClass13_0()
		{
		}

		[Token(Token = "0x6000C6F")]
		[Address(RVA = "0xD01CEC", Offset = "0xD01CEC", VA = "0xD01CEC")]
		internal void <GetAwaiter>b__0()
		{
		}
	}

	[Token(Token = "0x2000193")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x831B94", Offset = "0x831B94")]
	private sealed class <>c__DisplayClass14_0
	{
		[Token(Token = "0x40008D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SimpleCoroutineAwaiter awaiter;

		[Token(Token = "0x40008D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public object instruction;

		[Token(Token = "0x6000C70")]
		[Address(RVA = "0xD01ACC", Offset = "0xD01ACC", VA = "0xD01ACC")]
		public <>c__DisplayClass14_0()
		{
		}

		[Token(Token = "0x6000C71")]
		[Address(RVA = "0xD01DA0", Offset = "0xD01DA0", VA = "0xD01DA0")]
		internal void <GetAwaiterReturnVoid>b__0()
		{
		}
	}

	[Token(Token = "0x2000194")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x831BA4", Offset = "0x831BA4")]
	private sealed class <>c__DisplayClass15_0<T>
	{
		[Token(Token = "0x40008D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public SimpleCoroutineAwaiter<T> awaiter;

		[Token(Token = "0x40008D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T instruction;

		[Token(Token = "0x6000C72")]
		public <>c__DisplayClass15_0()
		{
		}

		[Token(Token = "0x6000C73")]
		internal void <GetAwaiterReturnSelf>b__0()
		{
		}
	}

	[Token(Token = "0x2000195")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x831BB4", Offset = "0x831BB4")]
	private sealed class <>c__DisplayClass16_0
	{
		[Token(Token = "0x40008D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Action action;

		[Token(Token = "0x6000C74")]
		[Address(RVA = "0xD01ADC", Offset = "0xD01ADC", VA = "0xD01ADC")]
		public <>c__DisplayClass16_0()
		{
		}

		[Token(Token = "0x6000C75")]
		[Address(RVA = "0xD01E64", Offset = "0xD01E64", VA = "0xD01E64")]
		internal void <RunOnUnityScheduler>b__0(object _)
		{
		}
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0xD014F4", Offset = "0xD014F4", VA = "0xD014F4")]
	public static SimpleCoroutineAwaiter GetAwaiter(this WaitForSeconds instruction)
	{
		return null;
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0xD015B8", Offset = "0xD015B8", VA = "0xD015B8")]
	public static SimpleCoroutineAwaiter GetAwaiter(this WaitForUpdate instruction)
	{
		return null;
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0xD015BC", Offset = "0xD015BC", VA = "0xD015BC")]
	public static SimpleCoroutineAwaiter GetAwaiter(this WaitForEndOfFrame instruction)
	{
		return null;
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0xD015C0", Offset = "0xD015C0", VA = "0xD015C0")]
	public static SimpleCoroutineAwaiter GetAwaiter(this WaitForFixedUpdate instruction)
	{
		return null;
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0xD015C4", Offset = "0xD015C4", VA = "0xD015C4")]
	public static SimpleCoroutineAwaiter GetAwaiter(this WaitForSecondsRealtime instruction)
	{
		return null;
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0xD015C8", Offset = "0xD015C8", VA = "0xD015C8")]
	public static SimpleCoroutineAwaiter GetAwaiter(this WaitUntil instruction)
	{
		return null;
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0xD015CC", Offset = "0xD015CC", VA = "0xD015CC")]
	public static SimpleCoroutineAwaiter GetAwaiter(this WaitWhile instruction)
	{
		return null;
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0xD015D0", Offset = "0xD015D0", VA = "0xD015D0")]
	public static SimpleCoroutineAwaiter<AsyncOperation> GetAwaiter(this AsyncOperation instruction)
	{
		return null;
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0xD01620", Offset = "0xD01620", VA = "0xD01620")]
	public static SimpleCoroutineAwaiter<UnityEngine.Object> GetAwaiter(this ResourceRequest instruction)
	{
		return null;
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0xD0180C", Offset = "0xD0180C", VA = "0xD0180C")]
	public static SimpleCoroutineAwaiter<WWW> GetAwaiter(this WWW instruction)
	{
		return null;
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0xD0185C", Offset = "0xD0185C", VA = "0xD0185C")]
	public static SimpleCoroutineAwaiter<AssetBundle> GetAwaiter(this AssetBundleCreateRequest instruction)
	{
		return null;
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0xD0192C", Offset = "0xD0192C", VA = "0xD0192C")]
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
	[Address(RVA = "0xD019FC", Offset = "0xD019FC", VA = "0xD019FC")]
	public static SimpleCoroutineAwaiter<object> GetAwaiter(this IEnumerator coroutine)
	{
		return null;
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0xD014F8", Offset = "0xD014F8", VA = "0xD014F8")]
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
	[Address(RVA = "0xD016F0", Offset = "0xD016F0", VA = "0xD016F0")]
	private static void RunOnUnityScheduler(Action action)
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0xD01AE4", Offset = "0xD01AE4", VA = "0xD01AE4")]
	private static void Assert(bool condition)
	{
	}
}
[Token(Token = "0x2000005")]
public static class TaskExtensions
{
	[Token(Token = "0x2000196")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x831BC4", Offset = "0x831BC4")]
	private sealed class <AsIEnumerator>d__0 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40008DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40008DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40008DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Task task;

		[Token(Token = "0x170000CC")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000C79")]
			[Address(RVA = "0xFBB2C0", Offset = "0xFBB2C0", VA = "0xFBB2C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CD")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000C7B")]
			[Address(RVA = "0xFBB328", Offset = "0xFBB328", VA = "0xFBB328", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000C76")]
		[Address(RVA = "0xFBB1FC", Offset = "0xFBB1FC", VA = "0xFBB1FC")]
		[DebuggerHidden]
		public <AsIEnumerator>d__0(int <>1__state)
		{
		}

		[Token(Token = "0x6000C77")]
		[Address(RVA = "0xFBB228", Offset = "0xFBB228", VA = "0xFBB228", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000C78")]
		[Address(RVA = "0xFBB22C", Offset = "0xFBB22C", VA = "0xFBB22C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000C7A")]
		[Address(RVA = "0xFBB2C8", Offset = "0xFBB2C8", VA = "0xFBB2C8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000197")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x831BD4", Offset = "0x831BD4")]
	private sealed class <AsIEnumerator>d__1<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
	{
		[Token(Token = "0x40008DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <>1__state;

		[Token(Token = "0x40008DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T <>2__current;

		[Token(Token = "0x40008DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Task<T> task;

		[Token(Token = "0x170000CE")]
		private T System.Collections.Generic.IEnumerator<T>.Current
		{
			[Token(Token = "0x6000C7F")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CF")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000C81")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000C7C")]
		[DebuggerHidden]
		public <AsIEnumerator>d__1(int <>1__state)
		{
		}

		[Token(Token = "0x6000C7D")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000C7E")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000C80")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0xFBB18C", Offset = "0xFBB18C", VA = "0xFBB18C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x835C28", Offset = "0x835C28")]
	public static IEnumerator AsIEnumerator(this Task task)
	{
		return null;
	}

	[Token(Token = "0x600001E")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x835C9C", Offset = "0x835C9C")]
	public static IEnumerator<T> AsIEnumerator<T>(this Task<T> task) where T : class
	{
		return null;
	}
}
[Token(Token = "0x2000006")]
public class WaitForBackgroundThread
{
	[Serializable]
	[Token(Token = "0x2000198")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x831BE4", Offset = "0x831BE4")]
	private sealed class <>c
	{
		[Token(Token = "0x40008E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x40008E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Action <>9__0_0;

		[Token(Token = "0x6000C83")]
		[Address(RVA = "0xFC1504", Offset = "0xFC1504", VA = "0xFC1504")]
		public <>c()
		{
		}

		[Token(Token = "0x6000C84")]
		[Address(RVA = "0xFC150C", Offset = "0xFC150C", VA = "0xFC150C")]
		internal void <GetAwaiter>b__0_0()
		{
		}
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0xFBF54C", Offset = "0xFBF54C", VA = "0xFBF54C")]
	public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter GetAwaiter()
	{
		return default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0xFBF544", Offset = "0xFBF544", VA = "0xFBF544")]
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
		[Address(RVA = "0xFC1510", Offset = "0xFC1510", VA = "0xFC1510", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0xFBF654", Offset = "0xFBF654", VA = "0xFBF654")]
	public WaitForUpdate()
	{
	}
}
[Token(Token = "0x2000008")]
public static class FmodResonanceAudio
{
	[Token(Token = "0x2000199")]
	private struct RoomProperties
	{
		[Token(Token = "0x40008E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float positionX;

		[Token(Token = "0x40008E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float positionY;

		[Token(Token = "0x40008E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float positionZ;

		[Token(Token = "0x40008E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float rotationX;

		[Token(Token = "0x40008E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float rotationY;

		[Token(Token = "0x40008E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float rotationZ;

		[Token(Token = "0x40008E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float rotationW;

		[Token(Token = "0x40008E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float dimensionsX;

		[Token(Token = "0x40008EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float dimensionsY;

		[Token(Token = "0x40008EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float dimensionsZ;

		[Token(Token = "0x40008EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public FmodResonanceAudioRoom.SurfaceMaterial materialLeft;

		[Token(Token = "0x40008ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public FmodResonanceAudioRoom.SurfaceMaterial materialRight;

		[Token(Token = "0x40008EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public FmodResonanceAudioRoom.SurfaceMaterial materialBottom;

		[Token(Token = "0x40008EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public FmodResonanceAudioRoom.SurfaceMaterial materialTop;

		[Token(Token = "0x40008F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public FmodResonanceAudioRoom.SurfaceMaterial materialFront;

		[Token(Token = "0x40008F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public FmodResonanceAudioRoom.SurfaceMaterial materialBack;

		[Token(Token = "0x40008F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float reflectionScalar;

		[Token(Token = "0x40008F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float reverbGain;

		[Token(Token = "0x40008F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float reverbTime;

		[Token(Token = "0x40008F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float reverbBrightness;
	}

	[Token(Token = "0x4000004")]
	public const float maxGainDb = 24f;

	[Token(Token = "0x4000005")]
	public const float minGainDb = -24f;

	[Token(Token = "0x4000006")]
	public const float maxReverbBrightness = 1f;

	[Token(Token = "0x4000007")]
	public const float minReverbBrightness = -1f;

	[Token(Token = "0x4000008")]
	public const float maxReverbTime = 3f;

	[Token(Token = "0x4000009")]
	public const float maxReflectivity = 2f;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly Matrix4x4 flipZ;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private static readonly string listenerPluginName;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private static readonly int roomPropertiesSize;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private static readonly int roomPropertiesIndex;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private static Bounds bounds;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private static List<FmodResonanceAudioRoom> enabledRooms;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private static VECTOR listenerPositionFmod;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private static DSP listenerPlugin;

	[Token(Token = "0x17000005")]
	private static DSP ListenerPlugin
	{
		[Token(Token = "0x6000025")]
		[Address(RVA = "0xD00510", Offset = "0xD00510", VA = "0xD00510")]
		get
		{
			return default(DSP);
		}
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0xD000B8", Offset = "0xD000B8", VA = "0xD000B8")]
	public static void UpdateAudioRoom(FmodResonanceAudioRoom room, bool roomEnabled)
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0xD006A4", Offset = "0xD006A4", VA = "0xD006A4")]
	public static bool IsListenerInsideRoom(FmodResonanceAudioRoom room)
	{
		return default(bool);
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0xD00CD0", Offset = "0xD00CD0", VA = "0xD00CD0")]
	private static float ConvertAmplitudeFromDb(float db)
	{
		return default(float);
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0xD00D48", Offset = "0xD00D48", VA = "0xD00D48")]
	private static void ConvertAudioTransformFromUnity(ref Vector3 position, ref Quaternion rotation)
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0xD005D4", Offset = "0xD005D4", VA = "0xD005D4")]
	private static byte[] GetBytes(IntPtr ptr, int length)
	{
		return null;
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0xD00344", Offset = "0xD00344", VA = "0xD00344")]
	private static RoomProperties GetRoomProperties(FmodResonanceAudioRoom room)
	{
		return default(RoomProperties);
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0xD0090C", Offset = "0xD0090C", VA = "0xD0090C")]
	private static DSP Initialize()
	{
		return default(DSP);
	}
}
[Token(Token = "0x2000009")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x830E34", Offset = "0x830E34")]
public class FmodResonanceAudioRoom : MonoBehaviour
{
	[Token(Token = "0x200019A")]
	public enum SurfaceMaterial
	{
		[Token(Token = "0x40008F7")]
		Transparent,
		[Token(Token = "0x40008F8")]
		AcousticCeilingTiles,
		[Token(Token = "0x40008F9")]
		BrickBare,
		[Token(Token = "0x40008FA")]
		BrickPainted,
		[Token(Token = "0x40008FB")]
		ConcreteBlockCoarse,
		[Token(Token = "0x40008FC")]
		ConcreteBlockPainted,
		[Token(Token = "0x40008FD")]
		CurtainHeavy,
		[Token(Token = "0x40008FE")]
		FiberglassInsulation,
		[Token(Token = "0x40008FF")]
		GlassThin,
		[Token(Token = "0x4000900")]
		GlassThick,
		[Token(Token = "0x4000901")]
		Grass,
		[Token(Token = "0x4000902")]
		LinoleumOnConcrete,
		[Token(Token = "0x4000903")]
		Marble,
		[Token(Token = "0x4000904")]
		Metal,
		[Token(Token = "0x4000905")]
		ParquetOnConcrete,
		[Token(Token = "0x4000906")]
		PlasterRough,
		[Token(Token = "0x4000907")]
		PlasterSmooth,
		[Token(Token = "0x4000908")]
		PlywoodPanel,
		[Token(Token = "0x4000909")]
		PolishedConcreteOrTile,
		[Token(Token = "0x400090A")]
		Sheetrock,
		[Token(Token = "0x400090B")]
		WaterOrIceSurface,
		[Token(Token = "0x400090C")]
		WoodCeiling,
		[Token(Token = "0x400090D")]
		WoodPanel
	}

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public SurfaceMaterial leftWall;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public SurfaceMaterial rightWall;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public SurfaceMaterial floor;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public SurfaceMaterial ceiling;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public SurfaceMaterial backWall;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public SurfaceMaterial frontWall;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float reflectivity;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float reverbGainDb;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float reverbBrightness;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float reverbTime;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Vector3 size;

	[Token(Token = "0x600002C")]
	[Address(RVA = "0xD01248", Offset = "0xD01248", VA = "0xD01248")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0xD012B8", Offset = "0xD012B8", VA = "0xD012B8")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0xD01320", Offset = "0xD01320", VA = "0xD01320")]
	private void Update()
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0xD01390", Offset = "0xD01390", VA = "0xD01390")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0xD0145C", Offset = "0xD0145C", VA = "0xD0145C")]
	public FmodResonanceAudioRoom()
	{
	}
}
[Serializable]
[Token(Token = "0x200000A")]
public class FMODEventPlayable : PlayableAsset, ITimelineClipAsset
{
	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public FMODEventPlayableBehavior template;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x831EC4", Offset = "0x831EC4")]
	private GameObject <TrackTargetObject>k__BackingField;

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float eventLength;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private FMODEventPlayableBehavior behavior;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[EventRef]
	[SerializeField]
	public string eventName;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	public STOP_MODE stopType;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	public ParamRef[] parameters;

	[NonSerialized]
	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public bool cachedParameters;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x831F2C", Offset = "0x831F2C")]
	private TimelineClip <OwningClip>k__BackingField;

	[Token(Token = "0x17000006")]
	public GameObject TrackTargetObject
	{
		[Token(Token = "0x6000031")]
		[Address(RVA = "0xCF68A0", Offset = "0xCF68A0", VA = "0xCF68A0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x835D10", Offset = "0x835D10")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000032")]
		[Address(RVA = "0xCF68A8", Offset = "0xCF68A8", VA = "0xCF68A8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x835D20", Offset = "0x835D20")]
		set
		{
		}
	}

	[Token(Token = "0x17000007")]
	public override double duration
	{
		[Token(Token = "0x6000033")]
		[Address(RVA = "0xCF68B0", Offset = "0xCF68B0", VA = "0xCF68B0", Slot = "7")]
		get
		{
			return default(double);
		}
	}

	[Token(Token = "0x17000008")]
	public ClipCaps clipCaps
	{
		[Token(Token = "0x6000034")]
		[Address(RVA = "0xCF68CC", Offset = "0xCF68CC", VA = "0xCF68CC", Slot = "9")]
		get
		{
			return default(ClipCaps);
		}
	}

	[Token(Token = "0x17000009")]
	public TimelineClip OwningClip
	{
		[Token(Token = "0x6000035")]
		[Address(RVA = "0xCF68D4", Offset = "0xCF68D4", VA = "0xCF68D4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x835D30", Offset = "0x835D30")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000036")]
		[Address(RVA = "0xCF68DC", Offset = "0xCF68DC", VA = "0xCF68DC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x835D40", Offset = "0x835D40")]
		set
		{
		}
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0xCF68E4", Offset = "0xCF68E4", VA = "0xCF68E4", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0xCF6B68", Offset = "0xCF6B68", VA = "0xCF6B68")]
	public FMODEventPlayable()
	{
	}
}
[Token(Token = "0x200000B")]
public enum STOP_MODE
{
	[Token(Token = "0x4000027")]
	AllowFadeout,
	[Token(Token = "0x4000028")]
	Immediate,
	[Token(Token = "0x4000029")]
	None
}
[Token(Token = "0x200000C")]
public class FMODEventPlayableBehavior : PlayableBehaviour
{
	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string eventName;

	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public STOP_MODE stopType;

	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ParamRef[] parameters;

	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject TrackTargetObject;

	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public TimelineClip OwningClip;

	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool isPlayheadInside;

	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private EventInstance eventInstance;

	[Token(Token = "0x6000039")]
	[Address(RVA = "0xCF6C44", Offset = "0xCF6C44", VA = "0xCF6C44")]
	protected void PlayEvent()
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0xCF73E0", Offset = "0xCF73E0", VA = "0xCF73E0")]
	public void OnEnter()
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0xCF7414", Offset = "0xCF7414", VA = "0xCF7414")]
	public void OnExit()
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0xCF681C", Offset = "0xCF681C", VA = "0xCF681C")]
	public void UpdateBehaviour(float time)
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0xCF747C", Offset = "0xCF747C", VA = "0xCF747C", Slot = "14")]
	public override void OnGraphStop(Playable playable)
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0xCF6BE4", Offset = "0xCF6BE4", VA = "0xCF6BE4")]
	public FMODEventPlayableBehavior()
	{
	}
}
[Token(Token = "0x200000D")]
[AttributeAttribute(Name = "TrackColorAttribute", RVA = "0x830E6C", Offset = "0x830E6C")]
[AttributeAttribute(Name = "TrackClipTypeAttribute", RVA = "0x830E6C", Offset = "0x830E6C")]
[AttributeAttribute(Name = "TrackBindingTypeAttribute", RVA = "0x830E6C", Offset = "0x830E6C")]
public class FMODEventTrack : TrackAsset
{
	[Token(Token = "0x600003F")]
	[Address(RVA = "0xCF7530", Offset = "0xCF7530", VA = "0xCF7530", Slot = "23")]
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0xCF7904", Offset = "0xCF7904", VA = "0xCF7904")]
	public FMODEventTrack()
	{
	}
}
[Token(Token = "0x200000E")]
public class FMODEventMixerBehaviour : PlayableBehaviour
{
	[Token(Token = "0x6000041")]
	[Address(RVA = "0xCF66A8", Offset = "0xCF66A8", VA = "0xCF66A8", Slot = "20")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0xCF6898", Offset = "0xCF6898", VA = "0xCF6898")]
	public FMODEventMixerBehaviour()
	{
	}
}
[Token(Token = "0x200000F")]
[ExecuteInEditMode]
public class ListMeshVertCount : MonoBehaviour
{
	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool includeInActive;

	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool listVertCount;

	[Token(Token = "0x6000043")]
	[Address(RVA = "0xD02500", Offset = "0xD02500", VA = "0xD02500")]
	private void Update()
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0xD02514", Offset = "0xD02514", VA = "0xD02514")]
	private void ListVertCount()
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0xD027F0", Offset = "0xD027F0", VA = "0xD027F0")]
	public ListMeshVertCount()
	{
	}
}
[Token(Token = "0x2000010")]
[ExecuteInEditMode]
public class EnableChildrenMeshRenderers : MonoBehaviour
{
	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool execute;

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x14F808C", Offset = "0x14F808C", VA = "0x14F808C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x14F80A0", Offset = "0x14F80A0", VA = "0x14F80A0")]
	private void Execute()
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x14F814C", Offset = "0x14F814C", VA = "0x14F814C")]
	public EnableChildrenMeshRenderers()
	{
	}
}
[Token(Token = "0x2000011")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x830F40", Offset = "0x830F40")]
public class EnableCameraDepthInForward : MonoBehaviour
{
	[Token(Token = "0x6000049")]
	[Address(RVA = "0x14F7FF4", Offset = "0x14F7FF4", VA = "0x14F7FF4")]
	private void Start()
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x14F7FF8", Offset = "0x14F7FF8", VA = "0x14F7FF8")]
	private void Set()
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x14F8084", Offset = "0x14F8084", VA = "0x14F8084")]
	public EnableCameraDepthInForward()
	{
	}
}
[Token(Token = "0x2000012")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x830FA4", Offset = "0x830FA4")]
public class SoftNormalsToVertexColor : MonoBehaviour
{
	[Token(Token = "0x200019B")]
	public enum Method
	{
		[Token(Token = "0x400090F")]
		Simple,
		[Token(Token = "0x4000910")]
		AngularDeviation
	}

	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Method method;

	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool generateOnAwake;

	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
	public bool generateNow;

	[Token(Token = "0x600004C")]
	[Address(RVA = "0xFBA5B8", Offset = "0xFBA5B8", VA = "0xFBA5B8")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0xFBA7A4", Offset = "0xFBA7A4", VA = "0xFBA7A4")]
	private void Awake()
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0xFBA5CC", Offset = "0xFBA5CC", VA = "0xFBA5CC")]
	private void TryGenerate()
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0xFBA7B4", Offset = "0xFBA7B4", VA = "0xFBA7B4")]
	private void Generate(Mesh m)
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0xFBB17C", Offset = "0xFBB17C", VA = "0xFBB17C")]
	public SoftNormalsToVertexColor()
	{
	}
}
[Token(Token = "0x2000013")]
public static class AnimationRecorderHelper
{
	[Token(Token = "0x6000051")]
	[Address(RVA = "0x121D500", Offset = "0x121D500", VA = "0x121D500")]
	public static string GetTransformPathName(Transform rootTransform, Transform targetTransform)
	{
		return null;
	}
}
[Token(Token = "0x2000014")]
public class MayaAnimationRecorder : MonoBehaviour
{
	[Token(Token = "0x200019C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x831BF4", Offset = "0x831BF4")]
	private sealed class <EndRecord>d__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000911")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000912")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000913")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MayaAnimationRecorder <>4__this;

		[Token(Token = "0x4000914")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int <i>5__2;

		[Token(Token = "0x170000D0")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000C88")]
			[Address(RVA = "0xD030A0", Offset = "0xD030A0", VA = "0xD030A0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D1")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000C8A")]
			[Address(RVA = "0xD03108", Offset = "0xD03108", VA = "0xD03108", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000C85")]
		[Address(RVA = "0xD02E10", Offset = "0xD02E10", VA = "0xD02E10")]
		[DebuggerHidden]
		public <EndRecord>d__27(int <>1__state)
		{
		}

		[Token(Token = "0x6000C86")]
		[Address(RVA = "0xD02F58", Offset = "0xD02F58", VA = "0xD02F58", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000C87")]
		[Address(RVA = "0xD02F5C", Offset = "0xD02F5C", VA = "0xD02F5C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000C89")]
		[Address(RVA = "0xD030A8", Offset = "0xD030A8", VA = "0xD030A8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200019D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x831C04", Offset = "0x831C04")]
	private sealed class <exportToMayaAnimation>d__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000915")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000916")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000917")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MayaAnimationRecorder <>4__this;

		[Token(Token = "0x4000918")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string <newFilePath>5__2;

		[Token(Token = "0x4000919")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private StreamWriter <writer>5__3;

		[Token(Token = "0x400091A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int <i>5__4;

		[Token(Token = "0x170000D2")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000C8E")]
			[Address(RVA = "0xD033B8", Offset = "0xD033B8", VA = "0xD033B8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D3")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000C90")]
			[Address(RVA = "0xD03420", Offset = "0xD03420", VA = "0xD03420", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000C8B")]
		[Address(RVA = "0xD02EAC", Offset = "0xD02EAC", VA = "0xD02EAC")]
		[DebuggerHidden]
		public <exportToMayaAnimation>d__28(int <>1__state)
		{
		}

		[Token(Token = "0x6000C8C")]
		[Address(RVA = "0xD03110", Offset = "0xD03110", VA = "0xD03110", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000C8D")]
		[Address(RVA = "0xD03114", Offset = "0xD03114", VA = "0xD03114", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000C8F")]
		[Address(RVA = "0xD033C0", Offset = "0xD033C0", VA = "0xD033C0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Transform[] observeObjs;

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private ObjAnimationContainer[] objAnims;

	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string saveFolderPath;

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public string saveFileName;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public string originalMaFilePath;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public KeyCode startKey;

	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public KeyCode endKey;

	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool changeTimeScale;

	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float startGameWithTimeScale;

	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float startRecordWithTimeScale;

	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public bool showLogGUI;

	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private string logMessage;

	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public bool recordLimitFrames;

	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public int recordFrames;

	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public int processPerFrame;

	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public int frameIndexToStartTransform;

	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private int objNums;

	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public int frameIndex;

	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private bool isStart;

	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x79")]
	private bool isEnd;

	[Token(Token = "0x6000052")]
	[Address(RVA = "0xD027F8", Offset = "0xD027F8", VA = "0xD027F8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0xD0282C", Offset = "0xD0282C", VA = "0xD0282C")]
	private void SettingRecordItems()
	{
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0xD02A6C", Offset = "0xD02A6C", VA = "0xD02A6C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0xD02BA0", Offset = "0xD02BA0", VA = "0xD02BA0")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0xD02AC0", Offset = "0xD02AC0", VA = "0xD02AC0")]
	public void StartRecording()
	{
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0xD02B30", Offset = "0xD02B30", VA = "0xD02B30")]
	public void StopRecording()
	{
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0xD02C98", Offset = "0xD02C98", VA = "0xD02C98")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0xD02DA0", Offset = "0xD02DA0", VA = "0xD02DA0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x835D50", Offset = "0x835D50")]
	private IEnumerator EndRecord()
	{
		return null;
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0xD02E3C", Offset = "0xD02E3C", VA = "0xD02E3C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x835DB4", Offset = "0x835DB4")]
	private IEnumerator exportToMayaAnimation()
	{
		return null;
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0xD029DC", Offset = "0xD029DC", VA = "0xD029DC")]
	private void ShowLog(string logStr)
	{
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0xD02ED8", Offset = "0xD02ED8", VA = "0xD02ED8")]
	public MayaAnimationRecorder()
	{
	}
}
[Token(Token = "0x2000015")]
public class MayaCurveConatiner
{
	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string objName;

	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string curveName;

	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string propertyName;

	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string footPropertyName;

	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private string inputPath;

	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private string tempFilePath;

	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private string finalFilePath;

	[Token(Token = "0x4000052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int animCount;

	[Token(Token = "0x4000053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private string storedData;

	[Token(Token = "0x600005D")]
	[Address(RVA = "0xD03428", Offset = "0xD03428", VA = "0xD03428")]
	public MayaCurveConatiner(string inputObjName, string inputCurveName, string inputPropertyName, string inputFootName, string filePath)
	{
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0xD034F4", Offset = "0xD034F4", VA = "0xD034F4")]
	private string compressFileName()
	{
		return null;
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0xD0354C", Offset = "0xD0354C", VA = "0xD0354C")]
	public void AddValue(int frameIndex, float inputValue)
	{
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0xD036F0", Offset = "0xD036F0", VA = "0xD036F0")]
	public void WriteIntoFile()
	{
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0xD03764", Offset = "0xD03764", VA = "0xD03764")]
	private string getHeadContent()
	{
		return null;
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0xD03B10", Offset = "0xD03B10", VA = "0xD03B10")]
	private string getFootContent()
	{
		return null;
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0xD03D7C", Offset = "0xD03D7C", VA = "0xD03D7C")]
	public void AnimFinish()
	{
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0xD03DE4", Offset = "0xD03DE4", VA = "0xD03DE4")]
	private void processFinalFile()
	{
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0xD03F3C", Offset = "0xD03F3C", VA = "0xD03F3C")]
	public string getFinalFilePath()
	{
		return null;
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0xD03FA4", Offset = "0xD03FA4", VA = "0xD03FA4")]
	public bool cleanFile()
	{
		return default(bool);
	}
}
[Token(Token = "0x2000016")]
public class ObjAnimationContainer
{
	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Transform observeObj;

	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private string objName;

	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private string filePath;

	[Token(Token = "0x4000057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool recordTranslation;

	[Token(Token = "0x4000058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	public bool recordRotation;

	[Token(Token = "0x4000059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
	public bool recordScale;

	[Token(Token = "0x400005A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private MayaCurveConatiner[] tCurves;

	[Token(Token = "0x400005B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private MayaCurveConatiner[] rCurves;

	[Token(Token = "0x400005C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private MayaCurveConatiner[] sCurves;

	[Token(Token = "0x400005D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private string objFinalFilePath;

	[Token(Token = "0x6000067")]
	[Address(RVA = "0xFB46F0", Offset = "0xFB46F0", VA = "0xFB46F0")]
	public ObjAnimationContainer(Transform inputObj, string namePath, string inputPath, bool recordT, bool recordR, bool recordS)
	{
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0xFB4C04", Offset = "0xFB4C04", VA = "0xFB4C04")]
	public void recordFrame(int frameIndex)
	{
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0xFB4EEC", Offset = "0xFB4EEC", VA = "0xFB4EEC")]
	public void WriteIntoFile()
	{
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0xFB5070", Offset = "0xFB5070", VA = "0xFB5070")]
	public void EndRecord()
	{
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0xFB51F0", Offset = "0xFB51F0", VA = "0xFB51F0")]
	public void combineCurveFiles()
	{
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0xFB54B4", Offset = "0xFB54B4", VA = "0xFB54B4")]
	public string getFinalFilePath()
	{
		return null;
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0xFB551C", Offset = "0xFB551C", VA = "0xFB551C")]
	public bool cleanFile()
	{
		return default(bool);
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0xFB4E78", Offset = "0xFB4E78", VA = "0xFB4E78")]
	private Vector3 Export2MayaTranslation(Vector3 t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0xFB4EB0", Offset = "0xFB4EB0", VA = "0xFB4EB0")]
	private Vector3 Export2MayaRotation(Vector3 r)
	{
		return default(Vector3);
	}
}
[Token(Token = "0x2000017")]
public class UnityCurveContainer
{
	[Token(Token = "0x400005E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string propertyName;

	[Token(Token = "0x400005F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AnimationCurve animCurve;

	[Token(Token = "0x6000070")]
	[Address(RVA = "0xFC0D80", Offset = "0xFC0D80", VA = "0xFC0D80")]
	public UnityCurveContainer(string _propertyName)
	{
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0xFC0E08", Offset = "0xFC0E08", VA = "0xFC0E08")]
	public void AddValue(float animTime, float animValue)
	{
	}
}
[Token(Token = "0x2000018")]
public class UnityObjectAnimation
{
	[Token(Token = "0x4000060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public UnityCurveContainer[] curves;

	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform observeGameObject;

	[Token(Token = "0x4000062")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string pathName;

	[Token(Token = "0x6000072")]
	[Address(RVA = "0xFC0E84", Offset = "0xFC0E84", VA = "0xFC0E84")]
	public UnityObjectAnimation(string hierarchyPath, Transform observeObj)
	{
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0xFC1224", Offset = "0xFC1224", VA = "0xFC1224")]
	public void AddFrame(float time)
	{
	}
}
namespace RoboRyanTron.SceneReference
{
	[Serializable]
	[Token(Token = "0x2000019")]
	public class SceneReference : ISerializationCallbackReceiver
	{
		[Token(Token = "0x200019E")]
		public class SceneLoadException : Exception
		{
			[Token(Token = "0x6000C91")]
			[Address(RVA = "0xFBA4A4", Offset = "0xFBA4A4", VA = "0xFBA4A4")]
			public SceneLoadException(string message)
			{
			}
		}

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x831F3C", Offset = "0x831F3C")]
		public string SceneName;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private int sceneIndex;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private bool sceneEnabled;

		[Token(Token = "0x6000074")]
		[Address(RVA = "0xFBA398", Offset = "0xFBA398", VA = "0xFBA398")]
		private void ValidateScene()
		{
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0xFBA51C", Offset = "0xFBA51C", VA = "0xFBA51C")]
		public void LoadScene(LoadSceneMode mode = LoadSceneMode.Single)
		{
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0xFBA5A0", Offset = "0xFBA5A0", VA = "0xFBA5A0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0xFBA5A4", Offset = "0xFBA5A4", VA = "0xFBA5A4", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0xFBA5A8", Offset = "0xFBA5A8", VA = "0xFBA5A8")]
		public SceneReference()
		{
		}
	}
}
namespace PhysSound
{
	[Token(Token = "0x200001A")]
	public abstract class PhysSoundBase : MonoBehaviour
	{
		[Token(Token = "0x6000079")]
		public abstract PhysSoundMaterial GetPhysSoundMaterial(Vector3 contactPoint);

		[Token(Token = "0x600007A")]
		[Address(RVA = "0xFB65F0", Offset = "0xFB65F0", VA = "0xFB65F0")]
		protected PhysSoundBase()
		{
		}
	}
	[Token(Token = "0x200001B")]
	public class PhysSoundMaterial : ScriptableObject
	{
		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int MaterialTypeKey;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int FallbackTypeIndex;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int FallbackTypeKey;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Range RelativeVelocityThreshold;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float PitchRandomness;

		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float SlidePitchMod;

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float SlideVolMultiplier;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float ImpactNormalBias;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float ScaleMod;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public LayerMask CollisionMask;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool UseCollisionVelocity;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x45")]
		public bool ScaleImpactVolume;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public List<PhysSoundAudioSet> AudioSets;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Dictionary<int, PhysSoundAudioSet> audioSetDic;

		[Token(Token = "0x600007B")]
		[Address(RVA = "0xFB6658", Offset = "0xFB6658", VA = "0xFB6658")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0xFB6B58", Offset = "0xFB6B58", VA = "0xFB6B58")]
		public AudioClip GetImpactAudio(GameObject otherObject, Vector3 relativeVel, Vector3 norm, Vector3 contact, int layer = -1)
		{
			return null;
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0xFB604C", Offset = "0xFB604C", VA = "0xFB604C")]
		public float GetSlideVolume(Vector3 relativeVel, Vector3 norm)
		{
			return default(float);
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0xFB6DCC", Offset = "0xFB6DCC", VA = "0xFB6DCC")]
		public float GetImpactVolume(Vector3 relativeVel, Vector3 norm)
		{
			return default(float);
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0xFB6234", Offset = "0xFB6234", VA = "0xFB6234")]
		public float GetRandomPitch()
		{
			return default(float);
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0xFB61D0", Offset = "0xFB61D0", VA = "0xFB61D0")]
		public float GetScaleModPitch(Vector3 scale)
		{
			return default(float);
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0xFB6FD0", Offset = "0xFB6FD0", VA = "0xFB6FD0")]
		public float GetScaleModVolume(Vector3 scale)
		{
			return default(float);
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0xFB7034", Offset = "0xFB7034", VA = "0xFB7034")]
		public bool HasAudioSet(int keyIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0xFB5BEC", Offset = "0xFB5BEC", VA = "0xFB5BEC")]
		public PhysSoundAudioSet GetAudioSet(int keyIndex)
		{
			return null;
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0xFB7144", Offset = "0xFB7144", VA = "0xFB7144")]
		public string[] GetFallbackAudioSets()
		{
			return null;
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0xFB5FFC", Offset = "0xFB5FFC", VA = "0xFB5FFC")]
		public bool CollideWith(GameObject g)
		{
			return default(bool);
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0xFB72AC", Offset = "0xFB72AC", VA = "0xFB72AC")]
		public PhysSoundMaterial()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200001C")]
	public class PhysSoundAudioSet
	{
		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int Key;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<AudioClip> Impacts;

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioClip Slide;

		[Token(Token = "0x6000087")]
		[Address(RVA = "0xFB64AC", Offset = "0xFB64AC", VA = "0xFB64AC")]
		public AudioClip GetImpact(float vel, bool random)
		{
			return null;
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0xFB6570", Offset = "0xFB6570", VA = "0xFB6570")]
		public bool CompareKeyIndex(int k)
		{
			return default(bool);
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0xFB6580", Offset = "0xFB6580", VA = "0xFB6580")]
		public PhysSoundAudioSet()
		{
		}
	}
	[Token(Token = "0x200001D")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x831008", Offset = "0x831008")]
	public class PhysSoundObject : PhysSoundBase
	{
		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PhysSoundMaterial SoundMaterial;

		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool AutoCreateSources;

		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool PlayClipAtPoint;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		public bool HitsTriggers;

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AudioSource ImpactAudio;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public List<PhysSoundAudioContainer> AudioContainers;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float baseImpactVol;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float baseImpactPitch;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Dictionary<int, PhysSoundAudioContainer> _audioContainersDic;

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 _prevVelocity;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private bool _setPrevVelocity;

		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 _prevPosition;

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private Vector3 _kinematicVelocity;

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion _prevRotation;

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float _kinematicAngularVelocity;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private int _lastFrame;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Rigidbody _r;

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 contactNormal;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Vector3 contactPoint;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 relativeVelocity;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private ContactPoint contactReuse;

		[Token(Token = "0x1700000A")]
		private Vector3 TotalKinematicVelocity
		{
			[Token(Token = "0x600008F")]
			[Address(RVA = "0xFB7F10", Offset = "0xFB7F10", VA = "0xFB7F10")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0xFB734C", Offset = "0xFB734C", VA = "0xFB734C")]
		private void Start()
		{
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0xFB73D4", Offset = "0xFB73D4", VA = "0xFB73D4")]
		public void Initialize()
		{
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0xFB7AA8", Offset = "0xFB7AA8", VA = "0xFB7AA8")]
		protected void DoUpdate()
		{
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0xFB7D74", Offset = "0xFB7D74", VA = "0xFB7D74")]
		public void SetEnabled(bool enable)
		{
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0xFB7F08", Offset = "0xFB7F08", VA = "0xFB7F08", Slot = "4")]
		public override PhysSoundMaterial GetPhysSoundMaterial(Vector3 contactPoint)
		{
			return null;
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0xFB7FB8", Offset = "0xFB7FB8", VA = "0xFB7FB8")]
		private void playImpactSound(GameObject otherObject, Vector3 relativeVelocity, Vector3 normal, Vector3 contactPoint)
		{
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0xFB8500", Offset = "0xFB8500", VA = "0xFB8500")]
		private void setSlideTargetVolumes(GameObject otherObject, Vector3 relativeVelocity, Vector3 normal, Vector3 contactPoint, bool exit)
		{
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0xFB8BCC", Offset = "0xFB8BCC", VA = "0xFB8BCC")]
		public void CollisionEnter(Collision c)
		{
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0xFB8D3C", Offset = "0xFB8D3C", VA = "0xFB8D3C")]
		public void CollisionStay(Collision c)
		{
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0xFB8FD0", Offset = "0xFB8FD0", VA = "0xFB8FD0")]
		public void CollisionExit(Collision c)
		{
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0xFB9164", Offset = "0xFB9164", VA = "0xFB9164")]
		public bool HasAudioContainer(int keyIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0xFB9274", Offset = "0xFB9274", VA = "0xFB9274")]
		public void AddAudioContainer(int keyIndex)
		{
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0xFB9300", Offset = "0xFB9300", VA = "0xFB9300")]
		public void RemoveAudioContainer(int keyIndex)
		{
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0xFB93CC", Offset = "0xFB93CC", VA = "0xFB93CC")]
		public PhysSoundObject()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200001E")]
	public class PhysSoundAudioContainer
	{
		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int KeyIndex;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AudioSource SlideAudio;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private PhysSoundMaterial _mat;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float _targetVolume;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float _baseVol;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float _basePitch;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float _basePitchRand;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int _lastFrame;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool _lastExit;

		[Token(Token = "0x6000099")]
		[Address(RVA = "0xFB5AAC", Offset = "0xFB5AAC", VA = "0xFB5AAC")]
		public PhysSoundAudioContainer(int k)
		{
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0xFB5AD8", Offset = "0xFB5AD8", VA = "0xFB5AD8")]
		public void Initialize(PhysSoundMaterial m)
		{
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0xFB5D00", Offset = "0xFB5D00", VA = "0xFB5D00")]
		public void StopSound()
		{
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0xFB5D94", Offset = "0xFB5D94", VA = "0xFB5D94")]
		public void SetTargetVolumeAndPitch(GameObject parentObject, GameObject otherObject, Vector3 relativeVelocity, Vector3 normal, bool exit, float mod = 1f)
		{
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0xFB6244", Offset = "0xFB6244", VA = "0xFB6244")]
		public void UpdateVolume()
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0xFB6364", Offset = "0xFB6364", VA = "0xFB6364")]
		public bool CompareKeyIndex(int k)
		{
			return default(bool);
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0xFB6374", Offset = "0xFB6374", VA = "0xFB6374")]
		public void Disable()
		{
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0xFB6418", Offset = "0xFB6418", VA = "0xFB6418")]
		public void Enable()
		{
		}
	}
	[Token(Token = "0x200001F")]
	public class PhysSoundTempAudio : MonoBehaviour
	{
		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private AudioSource audioSource;

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0xFB9444", Offset = "0xFB9444", VA = "0xFB9444")]
		public void Initialize(PhysSoundTempAudioPool pool)
		{
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0xFB9504", Offset = "0xFB9504", VA = "0xFB9504")]
		public void PlayClip(AudioClip clip, Vector3 point, AudioSource template, float volume, float pitch)
		{
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0xFB98BC", Offset = "0xFB98BC", VA = "0xFB98BC")]
		private void Update()
		{
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0xFB9984", Offset = "0xFB9984", VA = "0xFB9984")]
		public PhysSoundTempAudio()
		{
		}
	}
	[Token(Token = "0x2000020")]
	public class PhysSoundTempAudioPool : MonoBehaviour
	{
		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static int TempAudioPoolSize;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static PhysSoundTempAudioPool Instance;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private PhysSoundTempAudio[] audioSources;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int lastAvailable;

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0xFB79B4", Offset = "0xFB79B4", VA = "0xFB79B4")]
		public static void Create()
		{
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0xFB78E4", Offset = "0xFB78E4", VA = "0xFB78E4")]
		public static AudioSource GetAudioSourceCopy(AudioSource template, GameObject g)
		{
			return null;
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0xFB963C", Offset = "0xFB963C", VA = "0xFB963C")]
		public static void GetAudioSourceCopy(AudioSource template, AudioSource target)
		{
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0xFB998C", Offset = "0xFB998C", VA = "0xFB998C")]
		public void Initialize()
		{
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0xFB8388", Offset = "0xFB8388", VA = "0xFB8388")]
		public void PlayClip(AudioClip clip, Vector3 point, AudioSource template, float volume, float pitch)
		{
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0xFB9B00", Offset = "0xFB9B00", VA = "0xFB9B00")]
		public PhysSoundTempAudioPool()
		{
		}
	}
	[Token(Token = "0x2000021")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x831040", Offset = "0x831040")]
	public class PhysSoundTerrain : PhysSoundBase
	{
		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Terrain Terrain;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<PhysSoundMaterial> SoundMaterials;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Dictionary<int, PhysSoundComposition> compDic;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TerrainData terrainData;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 terrainPos;

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0xFB9B5C", Offset = "0xFB9B5C", VA = "0xFB9B5C")]
		private void Start()
		{
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0xFB9D1C", Offset = "0xFB9D1C", VA = "0xFB9D1C", Slot = "4")]
		public override PhysSoundMaterial GetPhysSoundMaterial(Vector3 contactPoint)
		{
			return null;
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0xFB8944", Offset = "0xFB8944", VA = "0xFB8944")]
		public Dictionary<int, PhysSoundComposition> GetComposition(Vector3 contactPoint)
		{
			return null;
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0xFB9EB8", Offset = "0xFB9EB8", VA = "0xFB9EB8")]
		private float[] getTextureMix(Vector3 worldPos)
		{
			return null;
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0xFB9E3C", Offset = "0xFB9E3C", VA = "0xFB9E3C")]
		private int getDominantTexture(Vector3 worldPos)
		{
			return default(int);
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0xFBA050", Offset = "0xFBA050", VA = "0xFBA050")]
		public PhysSoundTerrain()
		{
		}
	}
	[Token(Token = "0x2000022")]
	public class PhysSoundComposition
	{
		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int KeyIndex;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float Value;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int Count;

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0xFB65F8", Offset = "0xFB65F8", VA = "0xFB65F8")]
		public PhysSoundComposition(int key)
		{
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0xFB6624", Offset = "0xFB6624", VA = "0xFB6624")]
		public void Reset()
		{
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0xFB662C", Offset = "0xFB662C", VA = "0xFB662C")]
		public void Add(float val)
		{
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0xFB6648", Offset = "0xFB6648", VA = "0xFB6648")]
		public float GetAverage()
		{
			return default(float);
		}
	}
	[Token(Token = "0x2000023")]
	public class PhysSoundTypeList
	{
		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] PhysSoundTypes;

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0xFB6A84", Offset = "0xFB6A84", VA = "0xFB6A84")]
		public static string GetKey(int index)
		{
			return null;
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0xFBA0E8", Offset = "0xFBA0E8", VA = "0xFBA0E8")]
		public static bool HasKey(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0xFBA174", Offset = "0xFBA174", VA = "0xFBA174")]
		public PhysSoundTypeList()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000024")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x831078", Offset = "0x831078")]
	public class FoldoutList
	{
		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		public List<bool> foldouts;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		public bool mainFoldout;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		public Vector2 scrollPos;

		[Token(Token = "0x1700000B")]
		public bool Item
		{
			[Token(Token = "0x60000BA")]
			[Address(RVA = "0xFB5648", Offset = "0xFB5648", VA = "0xFB5648")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000BB")]
			[Address(RVA = "0xFB56C0", Offset = "0xFB56C0", VA = "0xFB56C0")]
			set
			{
			}
		}

		[Token(Token = "0x1700000C")]
		public int Count
		{
			[Token(Token = "0x60000BC")]
			[Address(RVA = "0xFB5730", Offset = "0xFB5730", VA = "0xFB5730")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0xFB5780", Offset = "0xFB5780", VA = "0xFB5780")]
		public void Add(bool value)
		{
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0xFB57E8", Offset = "0xFB57E8", VA = "0xFB57E8")]
		public void RemoveAt(int index)
		{
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0xFB5850", Offset = "0xFB5850", VA = "0xFB5850")]
		public void Reset()
		{
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0xFB58D8", Offset = "0xFB58D8", VA = "0xFB58D8")]
		public void Update(int count, bool defaultValue)
		{
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0xFB599C", Offset = "0xFB599C", VA = "0xFB599C")]
		public void Isolate(int index)
		{
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0xFB5A3C", Offset = "0xFB5A3C", VA = "0xFB5A3C")]
		public FoldoutList()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000025")]
	public struct Range
	{
		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float Min;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float Max;

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x8DEB0C", Offset = "0x8DEB0C", VA = "0x8DEB0C")]
		public Range(float min, float max)
		{
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x8DEB14", Offset = "0x8DEB14", VA = "0x8DEB14")]
		public bool isWithinRange(float f)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x8DEB38", Offset = "0x8DEB38", VA = "0x8DEB38")]
		public float Clamp(float f)
		{
			return default(float);
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x8DEB40", Offset = "0x8DEB40", VA = "0x8DEB40")]
		public float RandomInRange()
		{
			return default(float);
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x8DEB4C", Offset = "0x8DEB4C", VA = "0x8DEB4C")]
		public int RandomInRangeInteger()
		{
			return default(int);
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x8DEB74", Offset = "0x8DEB74", VA = "0x8DEB74")]
		public float Lerp(float t)
		{
			return default(float);
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x8DEB88", Offset = "0x8DEB88", VA = "0x8DEB88")]
		public float Normalize(float val)
		{
			return default(float);
		}
	}
}
namespace MeshCombineStudio
{
	[Token(Token = "0x2000026")]
	public class DisabledLODGroup : MonoBehaviour
	{
		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public MeshCombiner meshCombiner;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LODGroup lodGroup;

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x102E004", Offset = "0x102E004", VA = "0x102E004")]
		public DisabledLODGroup()
		{
		}
	}
	[Token(Token = "0x2000027")]
	[ExecuteInEditMode]
	public class FindLodGroups : MonoBehaviour
	{
		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool find;

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x102E024", Offset = "0x102E024", VA = "0x102E024")]
		private void Start()
		{
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x102E198", Offset = "0x102E198", VA = "0x102E198")]
		private void Update()
		{
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x102E028", Offset = "0x102E028", VA = "0x102E028")]
		private void FindLods()
		{
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x102E1AC", Offset = "0x102E1AC", VA = "0x102E1AC")]
		public FindLodGroups()
		{
		}
	}
	[Token(Token = "0x2000028")]
	public class LODGroupSetup : MonoBehaviour
	{
		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MeshCombiner meshCombiner;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LODGroup lodGroup;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int lodGroupParentIndex;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int lodCount;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private LODGroup[] lodGroups;

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x102E2A4", Offset = "0x102E2A4", VA = "0x102E2A4")]
		public void Init(MeshCombiner meshCombiner, int lodGroupParentIndex)
		{
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x102E364", Offset = "0x102E364", VA = "0x102E364")]
		private void GetSetup()
		{
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x102E474", Offset = "0x102E474", VA = "0x102E474")]
		public void ApplySetup()
		{
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x102E798", Offset = "0x102E798", VA = "0x102E798")]
		public void AddLODGroupsToChildren()
		{
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x102E9F4", Offset = "0x102E9F4", VA = "0x102E9F4")]
		public void RemoveLODGroupFromChildren()
		{
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x102EB10", Offset = "0x102EB10", VA = "0x102EB10")]
		public LODGroupSetup()
		{
		}
	}
	[Token(Token = "0x2000029")]
	public class CamGeometryCapture : MonoBehaviour
	{
		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ComputeShader computeDepthToArray;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Int2 resolution;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Camera cam;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform t;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public RenderTexture rtCapture;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float[] heights;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Bounds bounds;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float maxSize;

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0xD043F0", Offset = "0xD043F0", VA = "0xD043F0")]
		public void Init()
		{
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0xD044C0", Offset = "0xD044C0", VA = "0xD044C0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0xD044FC", Offset = "0xD044FC", VA = "0xD044FC")]
		private void DisposeRenderTexture(ref RenderTexture rt)
		{
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0xD044C4", Offset = "0xD044C4", VA = "0xD044C4")]
		public void DisposeRTCapture()
		{
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0xD045BC", Offset = "0xD045BC", VA = "0xD045BC")]
		public void RemoveTrianglesBelowSurface(Transform t, MeshCombineJobManager.MeshCombineJob meshCombineJob, MeshCache.SubMeshCache newMeshCache, ref byte[] vertexIsBelow)
		{
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0xD04920", Offset = "0xD04920", VA = "0xD04920")]
		public void Capture(Bounds bounds, int collisionMask, Vector3 direction, Int2 resolution)
		{
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0xD0510C", Offset = "0xD0510C", VA = "0xD0510C")]
		public void SetCamera(Vector3 direction)
		{
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0xD04D40", Offset = "0xD04D40", VA = "0xD04D40")]
		public float GetHeight(Vector3 pos)
		{
			return default(float);
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0xD05428", Offset = "0xD05428", VA = "0xD05428")]
		public CamGeometryCapture()
		{
		}
	}
	[Token(Token = "0x200002A")]
	public class CombinedLODManager : MonoBehaviour
	{
		[Token(Token = "0x200019F")]
		public enum LodMode
		{
			[Token(Token = "0x400091C")]
			Automatic,
			[Token(Token = "0x400091D")]
			DebugLod
		}

		[Token(Token = "0x20001A0")]
		public enum LodDistanceMode
		{
			[Token(Token = "0x400091F")]
			Automatic,
			[Token(Token = "0x4000920")]
			Manual
		}

		[Serializable]
		[Token(Token = "0x20001A1")]
		public class LOD
		{
			[Token(Token = "0x4000921")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform searchParent;

			[Token(Token = "0x4000922")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Sphere3 sphere;

			[Token(Token = "0x6000C92")]
			[Address(RVA = "0x102803C", Offset = "0x102803C", VA = "0x102803C")]
			public LOD()
			{
			}

			[Token(Token = "0x6000C93")]
			[Address(RVA = "0x1028F80", Offset = "0x1028F80", VA = "0x1028F80")]
			public LOD(Transform searchParent)
			{
			}
		}

		[Token(Token = "0x20001A2")]
		public class Cell : BaseOctree.Cell
		{
			[Token(Token = "0x4000923")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Cell[] cells;

			[Token(Token = "0x4000924")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private AABB3 box;

			[Token(Token = "0x6000C94")]
			[Address(RVA = "0x10289F8", Offset = "0x10289F8", VA = "0x10289F8")]
			public Cell()
			{
			}

			[Token(Token = "0x6000C95")]
			[Address(RVA = "0x1027BC0", Offset = "0x1027BC0", VA = "0x1027BC0")]
			public Cell(Vector3 position, Vector3 size, int maxLevels)
			{
			}

			[Token(Token = "0x6000C96")]
			[Address(RVA = "0x10280B0", Offset = "0x10280B0", VA = "0x10280B0")]
			public void AddMeshRenderer(MeshRenderer mr, Vector3 position, int lodLevel, int lodLevels)
			{
			}

			[Token(Token = "0x6000C97")]
			[Address(RVA = "0x1028A00", Offset = "0x1028A00", VA = "0x1028A00")]
			private void AddMeshRendererInternal(MeshRenderer mr, Vector3 position, int lodLevel, int lodLevels)
			{
			}

			[Token(Token = "0x6000C98")]
			[Address(RVA = "0x102827C", Offset = "0x102827C", VA = "0x102827C")]
			public void AutoLodInternal(LOD[] lods, float lodCulledDistance)
			{
			}

			[Token(Token = "0x6000C99")]
			[Address(RVA = "0x1028664", Offset = "0x1028664", VA = "0x1028664")]
			public void LodInternal(LOD[] lods, int lodLevel)
			{
			}

			[Token(Token = "0x6000C9A")]
			[Address(RVA = "0x102884C", Offset = "0x102884C", VA = "0x102884C")]
			public void DrawGizmos(LOD[] lods)
			{
			}

			[Token(Token = "0x6000C9B")]
			[Address(RVA = "0x1028D5C", Offset = "0x1028D5C", VA = "0x1028D5C")]
			public void DrawGizmosInternal()
			{
			}
		}

		[Token(Token = "0x20001A3")]
		public class MaxCell : Cell
		{
			[Token(Token = "0x4000925")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public List<MeshRenderer>[] mrList;

			[Token(Token = "0x4000926")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public int currentLod;

			[Token(Token = "0x6000C9C")]
			[Address(RVA = "0x1028FAC", Offset = "0x1028FAC", VA = "0x1028FAC")]
			public MaxCell()
			{
			}
		}

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool drawGizmos;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LOD[] lods;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float[] distances;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public LodDistanceMode lodDistanceMode;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public LodMode lodMode;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int showLod;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool lodCulled;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float lodCullDistance;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 octreeCenter;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Vector3 octreeSize;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public int maxLevels;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool search;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Cell octree;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Transform cameraMainT;

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x1027ADC", Offset = "0x1027ADC", VA = "0x1027ADC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x1027B14", Offset = "0x1027B14", VA = "0x1027B14")]
		private void InitOctree()
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x1027BC8", Offset = "0x1027BC8", VA = "0x1027BC8")]
		private void Start()
		{
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x1027D70", Offset = "0x1027D70", VA = "0x1027D70")]
		private void Update()
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x1027E94", Offset = "0x1027E94", VA = "0x1027E94")]
		public void UpdateLods(MeshCombiner meshCombiner, int lodAmount)
		{
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x1028044", Offset = "0x1028044", VA = "0x1028044")]
		public void UpdateDistances(MeshCombiner meshCombiner)
		{
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x1027BFC", Offset = "0x1027BFC", VA = "0x1027BFC")]
		public void Search()
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x102813C", Offset = "0x102813C", VA = "0x102813C")]
		public void ResetOctree()
		{
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x1027D98", Offset = "0x1027D98", VA = "0x1027D98")]
		public void Lod(LodMode lodMode)
		{
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x1028824", Offset = "0x1028824", VA = "0x1028824")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x1028928", Offset = "0x1028928", VA = "0x1028928")]
		public CombinedLODManager()
		{
		}
	}
	[Token(Token = "0x200002B")]
	[ExecuteInEditMode]
	public class MeshCombineJobManager : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20001A4")]
		public class JobSettings
		{
			[Token(Token = "0x4000927")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CombineJobMode combineJobMode;

			[Token(Token = "0x4000928")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public ThreadAmountMode threadAmountMode;

			[Token(Token = "0x4000929")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int combineMeshesPerFrame;

			[Token(Token = "0x400092A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool useMultiThreading;

			[Token(Token = "0x400092B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
			public bool useMainThread;

			[Token(Token = "0x400092C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int customThreadAmount;

			[Token(Token = "0x400092D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public bool showStats;

			[Token(Token = "0x6000C9D")]
			[Address(RVA = "0x103445C", Offset = "0x103445C", VA = "0x103445C")]
			public void CopySettings(JobSettings source)
			{
			}

			[Token(Token = "0x6000C9E")]
			[Address(RVA = "0x1035F00", Offset = "0x1035F00", VA = "0x1035F00")]
			public void ReportStatus()
			{
			}

			[Token(Token = "0x6000C9F")]
			[Address(RVA = "0x1035EE0", Offset = "0x1035EE0", VA = "0x1035EE0")]
			public JobSettings()
			{
			}
		}

		[Token(Token = "0x20001A5")]
		public enum CombineJobMode
		{
			[Token(Token = "0x400092F")]
			CombineAtOnce,
			[Token(Token = "0x4000930")]
			CombinePerFrame
		}

		[Token(Token = "0x20001A6")]
		public enum ThreadAmountMode
		{
			[Token(Token = "0x4000932")]
			AllThreads,
			[Token(Token = "0x4000933")]
			HalfThreads,
			[Token(Token = "0x4000934")]
			Custom
		}

		[Token(Token = "0x20001A7")]
		public enum ThreadState
		{
			[Token(Token = "0x4000936")]
			isReady,
			[Token(Token = "0x4000937")]
			isRunning,
			[Token(Token = "0x4000938")]
			hasError
		}

		[Token(Token = "0x20001A8")]
		public class MeshCombineJobsThread
		{
			[Token(Token = "0x4000939")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int threadId;

			[Token(Token = "0x400093A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public ThreadState threadState;

			[Token(Token = "0x400093B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Queue<MeshCombineJob> meshCombineJobs;

			[Token(Token = "0x6000CA0")]
			[Address(RVA = "0x1033544", Offset = "0x1033544", VA = "0x1033544")]
			public MeshCombineJobsThread(int threadId)
			{
			}

			[Token(Token = "0x6000CA1")]
			[Address(RVA = "0x1034C8C", Offset = "0x1034C8C", VA = "0x1034C8C")]
			public void ExecuteJobsThread(object state)
			{
			}
		}

		[Token(Token = "0x20001A9")]
		public class MeshCombineJob
		{
			[Token(Token = "0x400093C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public MeshCombiner meshCombiner;

			[Token(Token = "0x400093D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MeshObjectsHolder meshObjectsHolder;

			[Token(Token = "0x400093E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform parent;

			[Token(Token = "0x400093F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 position;

			[Token(Token = "0x4000940")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public int startIndex;

			[Token(Token = "0x4000941")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public int endIndex;

			[Token(Token = "0x4000942")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public bool firstMesh;

			[Token(Token = "0x4000943")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
			public bool intersectsSurface;

			[Token(Token = "0x4000944")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public int backFaceTrianglesRemoved;

			[Token(Token = "0x4000945")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public int trianglesRemoved;

			[Token(Token = "0x4000946")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public bool abort;

			[Token(Token = "0x4000947")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public string name;

			[Token(Token = "0x6000CA2")]
			[Address(RVA = "0x1034858", Offset = "0x1034858", VA = "0x1034858")]
			public MeshCombineJob(MeshCombiner meshCombiner, MeshObjectsHolder meshObjectsHolder, Transform parent, Vector3 position, int startIndex, int length, bool firstMesh, bool intersectsSurface)
			{
			}
		}

		[Token(Token = "0x20001AA")]
		public class NewMeshObject
		{
			[Token(Token = "0x4000948")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public MeshCombineJob meshCombineJob;

			[Token(Token = "0x4000949")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MeshCache.SubMeshCache newMeshCache;

			[Token(Token = "0x400094A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool allSkipped;

			[Token(Token = "0x400094B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Vector3 newPosition;

			[Token(Token = "0x400094C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private byte[] vertexIsBelow;

			[Token(Token = "0x400094D")]
			private const byte belowSurface = 1;

			[Token(Token = "0x400094E")]
			private const byte aboveSurface = 2;

			[Token(Token = "0x6000CA3")]
			[Address(RVA = "0x10360D4", Offset = "0x10360D4", VA = "0x10360D4")]
			public NewMeshObject()
			{
			}

			[Token(Token = "0x6000CA4")]
			[Address(RVA = "0x1036150", Offset = "0x1036150", VA = "0x1036150")]
			public void Combine(MeshCombineJob meshCombineJob)
			{
			}

			[Token(Token = "0x6000CA5")]
			[Address(RVA = "0x10370F4", Offset = "0x10370F4", VA = "0x10370F4")]
			private void PrintMissingArrayWarning(MeshCombiner meshCombiner, GameObject go, Mesh mesh, string text)
			{
			}

			[Token(Token = "0x6000CA6")]
			private void HasArray<T>(ref bool hasNewArray, bool hasArray, ref T[] newArray, Array array, int vertexCount, int totalVertices, bool useDefaultValue = false, [Optional] T defaultValue)
			{
			}

			[Token(Token = "0x6000CA7")]
			private void FillArray<T>(T[] array, int offset, int length, T value)
			{
			}

			[Token(Token = "0x6000CA8")]
			[Address(RVA = "0x103779C", Offset = "0x103779C", VA = "0x103779C")]
			public void RemoveTrianglesBelowSurface(Transform t, MeshCombineJob meshCombineJob)
			{
			}

			[Token(Token = "0x6000CA9")]
			[Address(RVA = "0x1037350", Offset = "0x1037350", VA = "0x1037350")]
			public void RemoveBackFaceTriangles()
			{
			}

			[Token(Token = "0x6000CAA")]
			[Address(RVA = "0x1037B3C", Offset = "0x1037B3C", VA = "0x1037B3C")]
			private void ArrangeTriangles()
			{
			}

			[Token(Token = "0x6000CAB")]
			[Address(RVA = "0x1035428", Offset = "0x1035428", VA = "0x1035428")]
			public void CreateMesh()
			{
			}
		}

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static MeshCombineJobManager instance;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public JobSettings jobSettings;

		[NonSerialized]
		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<NewMeshObject> newMeshObjectsPool;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Dictionary<Mesh, MeshCache> meshCacheDictionary;

		[NonSerialized]
		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int totalNewMeshObjects;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Queue<NewMeshObject> newMeshObjectsDone;

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Queue<NewMeshObject> newMeshObjectsDoneThread;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Queue<MeshCombineJob> meshCombineJobs;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public MeshCombineJobsThread[] meshCombineJobsThreads;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public CamGeometryCapture camGeometryCapture;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public int cores;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int threadAmount;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public int startThreadId;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public int endThreadId;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public bool abort;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private MeshCache.SubMeshCache tempMeshCache;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Ray ray;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private RaycastHit hitInfo;

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x1032F0C", Offset = "0x1032F0C", VA = "0x1032F0C")]
		public static MeshCombineJobManager CreateInstance(MeshCombiner meshCombiner, GameObject instantiatePrefab)
		{
			return null;
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x10332FC", Offset = "0x10332FC", VA = "0x10332FC")]
		public static void ResetMeshCache()
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x1033368", Offset = "0x1033368", VA = "0x1033368")]
		private void Awake()
		{
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x10333BC", Offset = "0x10333BC", VA = "0x10333BC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x1033434", Offset = "0x1033434", VA = "0x1033434")]
		public void Init()
		{
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x10335C8", Offset = "0x10335C8", VA = "0x10335C8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x10335CC", Offset = "0x10335CC", VA = "0x10335CC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x10339C0", Offset = "0x10339C0", VA = "0x10339C0")]
		private void Update()
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x10339F8", Offset = "0x10339F8", VA = "0x10339F8")]
		private void MyUpdate()
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x10330C8", Offset = "0x10330C8", VA = "0x10330C8")]
		public void SetJobMode(JobSettings newJobSettings)
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x10344A0", Offset = "0x10344A0", VA = "0x10344A0")]
		public void AddJob(MeshCombiner meshCombiner, MeshObjectsHolder meshObjectsHolder, Transform parent, Vector3 position)
		{
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x1034938", Offset = "0x1034938", VA = "0x1034938")]
		private void EnqueueJob(MeshCombiner meshCombiner, MeshCombineJob meshCombineJob)
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x10349D0", Offset = "0x10349D0", VA = "0x10349D0")]
		public int MeshIntersectsSurface(MeshCombiner meshCombiner, CachedGameObject cachedGO)
		{
			return default(int);
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x1033628", Offset = "0x1033628", VA = "0x1033628")]
		public void AbortJobs()
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x1033A7C", Offset = "0x1033A7C", VA = "0x1033A7C")]
		public void ExecuteJobs()
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x1033FFC", Offset = "0x1033FFC", VA = "0x1033FFC")]
		public void CombineMeshesDone()
		{
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x1035D0C", Offset = "0x1035D0C", VA = "0x1035D0C")]
		public MeshCombineJobManager()
		{
		}
	}
	[Token(Token = "0x200002C")]
	public class MeshCache
	{
		[Token(Token = "0x20001AB")]
		public class SubMeshCache
		{
			[Token(Token = "0x400094F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3[] vertices;

			[Token(Token = "0x4000950")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3[] normals;

			[Token(Token = "0x4000951")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector4[] tangents;

			[Token(Token = "0x4000952")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector2[] uv;

			[Token(Token = "0x4000953")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Vector2[] uv2;

			[Token(Token = "0x4000954")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Vector2[] uv3;

			[Token(Token = "0x4000955")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Vector2[] uv4;

			[Token(Token = "0x4000956")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Color32[] colors32;

			[Token(Token = "0x4000957")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public int[] triangles;

			[Token(Token = "0x4000958")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public bool hasNormals;

			[Token(Token = "0x4000959")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
			public bool hasTangents;

			[Token(Token = "0x400095A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
			public bool hasUv;

			[Token(Token = "0x400095B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5B")]
			public bool hasUv2;

			[Token(Token = "0x400095C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public bool hasUv3;

			[Token(Token = "0x400095D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
			public bool hasUv4;

			[Token(Token = "0x400095E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5E")]
			public bool hasColors;

			[Token(Token = "0x400095F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public int vertexCount;

			[Token(Token = "0x4000960")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			public int triangleCount;

			[Token(Token = "0x6000CAC")]
			[Address(RVA = "0x1032BEC", Offset = "0x1032BEC", VA = "0x1032BEC")]
			public SubMeshCache()
			{
			}

			[Token(Token = "0x6000CAD")]
			[Address(RVA = "0x1032BF4", Offset = "0x1032BF4", VA = "0x1032BF4")]
			public void CopySubMeshCache(SubMeshCache source)
			{
			}

			[Token(Token = "0x6000CAE")]
			public void CopyArray<T>(Array sourceArray, ref T[] destinationArray, int vertexCount)
			{
			}

			[Token(Token = "0x6000CAF")]
			[Address(RVA = "0x1032644", Offset = "0x1032644", VA = "0x1032644")]
			public SubMeshCache(Mesh mesh, int subMeshIndex)
			{
			}

			[Token(Token = "0x6000CB0")]
			[Address(RVA = "0x1032550", Offset = "0x1032550", VA = "0x1032550")]
			public SubMeshCache(Mesh mesh, bool assignTriangles)
			{
			}

			[Token(Token = "0x6000CB1")]
			[Address(RVA = "0x1032DC4", Offset = "0x1032DC4", VA = "0x1032DC4")]
			public void CheckHasArrays()
			{
			}

			[Token(Token = "0x6000CB2")]
			[Address(RVA = "0x1032E70", Offset = "0x1032E70", VA = "0x1032E70")]
			public void ResetHasBooleans()
			{
			}

			[Token(Token = "0x6000CB3")]
			[Address(RVA = "0x1032E80", Offset = "0x1032E80", VA = "0x1032E80")]
			public void Init(bool initTriangles = true)
			{
			}

			[Token(Token = "0x6000CB4")]
			[Address(RVA = "0x10326A0", Offset = "0x10326A0", VA = "0x10326A0")]
			public void RebuildVertexBuffer(SubMeshCache sub, bool resizeArrays)
			{
			}
		}

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Mesh mesh;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SubMeshCache[] subMeshCache;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int subMeshCount;

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x103239C", Offset = "0x103239C", VA = "0x103239C")]
		public MeshCache(Mesh mesh)
		{
		}
	}
	[Token(Token = "0x200002D")]
	public static class MeshExtensionAlloc
	{
		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x103BEA4", Offset = "0x103BEA4", VA = "0x103BEA4")]
		public static void ApplyVertices(Mesh mesh, Vector3[] vertices, int length)
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x103BF34", Offset = "0x103BF34", VA = "0x103BF34")]
		public static void ApplyNormals(Mesh mesh, Vector3[] normals, int length)
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x103BFC4", Offset = "0x103BFC4", VA = "0x103BFC4")]
		public static void ApplyTangents(Mesh mesh, Vector4[] tangents, int length)
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x103C054", Offset = "0x103C054", VA = "0x103C054")]
		public static void ApplyUvs(Mesh mesh, int channel, Vector2[] uvs, int length)
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x103C170", Offset = "0x103C170", VA = "0x103C170")]
		public static void ApplyColors32(Mesh mesh, Color32[] colors, int length)
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x103C200", Offset = "0x103C200", VA = "0x103C200")]
		public static void ApplyTriangles(Mesh mesh, int[] triangles, int length)
		{
		}
	}
	[Token(Token = "0x200002E")]
	[ExecuteInEditMode]
	public class MeshCombiner : MonoBehaviour
	{
		[Token(Token = "0x20001AC")]
		public enum ObjectType
		{
			[Token(Token = "0x4000962")]
			Normal,
			[Token(Token = "0x4000963")]
			LodGroup,
			[Token(Token = "0x4000964")]
			LodRenderer
		}

		[Token(Token = "0x20001AD")]
		public enum HandleComponent
		{
			[Token(Token = "0x4000966")]
			Disable,
			[Token(Token = "0x4000967")]
			Destroy
		}

		[Token(Token = "0x20001AE")]
		public enum ObjectCenter
		{
			[Token(Token = "0x4000969")]
			BoundsCenter,
			[Token(Token = "0x400096A")]
			TransformPosition
		}

		[Token(Token = "0x20001AF")]
		public enum BackFaceTriangleMode
		{
			[Token(Token = "0x400096C")]
			Box,
			[Token(Token = "0x400096D")]
			Direction
		}

		[Token(Token = "0x20001B0")]
		public delegate void DefaultMethod();

		[Token(Token = "0x20001B1")]
		public enum RebakeLightingMode
		{
			[Token(Token = "0x400096F")]
			CopyLightmapUvs,
			[Token(Token = "0x4000970")]
			RegenarateLightmapUvs
		}

		[Serializable]
		[Token(Token = "0x20001B2")]
		public class SearchOptions
		{
			[Token(Token = "0x200022A")]
			public enum ComponentCondition
			{
				[Token(Token = "0x4000B94")]
				And,
				[Token(Token = "0x4000B95")]
				Or
			}

			[Token(Token = "0x4000971")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public GameObject parent;

			[Token(Token = "0x4000972")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ObjectCenter objectCenter;

			[Token(Token = "0x4000973")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool useSearchBox;

			[Token(Token = "0x4000974")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Bounds searchBoxBounds;

			[Token(Token = "0x4000975")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool searchBoxSquare;

			[Token(Token = "0x4000976")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 searchBoxPivot;

			[Token(Token = "0x4000977")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 searchBoxSize;

			[Token(Token = "0x4000978")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public bool useMaxBoundsFactor;

			[Token(Token = "0x4000979")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float maxBoundsFactor;

			[Token(Token = "0x400097A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public bool useVertexInputLimit;

			[Token(Token = "0x400097B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public int vertexInputLimit;

			[Token(Token = "0x400097C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			public bool useLayerMask;

			[Token(Token = "0x400097D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public LayerMask layerMask;

			[Token(Token = "0x400097E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public bool useTag;

			[Token(Token = "0x400097F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public string tag;

			[Token(Token = "0x4000980")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public bool useNameContains;

			[Token(Token = "0x4000981")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			public List<string> nameContainList;

			[Token(Token = "0x4000982")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			public bool onlyActive;

			[Token(Token = "0x4000983")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
			public bool onlyStatic;

			[Token(Token = "0x4000984")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8A")]
			public bool useComponentsFilter;

			[Token(Token = "0x4000985")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			public ComponentCondition componentCondition;

			[Token(Token = "0x4000986")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public List<string> componentNameList;

			[Token(Token = "0x6000CB9")]
			[Address(RVA = "0x103BD94", Offset = "0x103BD94", VA = "0x103BD94")]
			public SearchOptions(GameObject parent)
			{
			}

			[Token(Token = "0x6000CBA")]
			[Address(RVA = "0x1038E08", Offset = "0x1038E08", VA = "0x1038E08")]
			public void GetSearchBoxBounds()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001B3")]
		public class LODGroupSettings
		{
			[Token(Token = "0x4000987")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LODSettings[] lodSettings;

			[Token(Token = "0x6000CBB")]
			[Address(RVA = "0x10388DC", Offset = "0x10388DC", VA = "0x10388DC")]
			public LODGroupSettings(int lodParentIndex)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001B4")]
		public class LODSettings
		{
			[Token(Token = "0x4000988")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float screenRelativeTransitionHeight;

			[Token(Token = "0x4000989")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float fadeTransitionWidth;

			[Token(Token = "0x6000CBC")]
			[Address(RVA = "0x103BD60", Offset = "0x103BD60", VA = "0x103BD60")]
			public LODSettings(float screenRelativeTransitionHeight)
			{
			}
		}

		[Token(Token = "0x20001B5")]
		public class LodParentHolder
		{
			[Token(Token = "0x400098A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public GameObject go;

			[Token(Token = "0x400098B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform t;

			[Token(Token = "0x400098C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool found;

			[Token(Token = "0x400098D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int[] lods;

			[Token(Token = "0x6000CBD")]
			[Address(RVA = "0x103AF38", Offset = "0x103AF38", VA = "0x103AF38")]
			public LodParentHolder(int lodCount)
			{
			}

			[Token(Token = "0x6000CBE")]
			[Address(RVA = "0x103A788", Offset = "0x103A788", VA = "0x103A788")]
			public void Create(MeshCombiner meshCombiner, int lodParentIndex)
			{
			}

			[Token(Token = "0x6000CBF")]
			[Address(RVA = "0x103AFA8", Offset = "0x103AFA8", VA = "0x103AFA8")]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static List<MeshCombiner> instances;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MeshCombineJobManager.JobSettings jobSettings;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LODGroupSettings[] lodGroupsSettings;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public ComputeShader computeDepthToArray;

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GameObject instantiatePrefab;

		[Token(Token = "0x40000E1")]
		public const int maxLodCount = 8;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string saveMeshesFolder;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public ObjectOctree.Cell octree;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public List<ObjectOctree.MaxCell> changedCells;

		[NonSerialized]
		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool octreeContainsObjects;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		public bool useCells;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public int cellSize;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 cellOffset;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public bool useVertexOutputLimit;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public int vertexOutputLimit;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public RebakeLightingMode rebakeLightingMode;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool copyBakedLighting;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x79")]
		public bool validCopyBakedLighting;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7A")]
		public bool rebakeLighting;

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7B")]
		public bool validRebakeLighting;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public int outputLayer;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public int outputStatic;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public float scaleInLightmap;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool addMeshColliders;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
		public bool addMeshCollidersInRange;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public Bounds addMeshCollidersBounds;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public bool makeMeshesUnreadable;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA5")]
		public bool removeTrianglesBelowSurface;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA6")]
		public bool noColliders;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public LayerMask surfaceLayerMask;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public float maxSurfaceHeight;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public bool removeOverlappingTriangles;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public GameObject overlappingCollidersGO;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public LayerMask overlapLayerMask;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public int voxelizeLayer;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public int lodGroupLayer;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public bool removeBackFaceTriangles;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public BackFaceTriangleMode backFaceTriangleMode;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public Vector3 backFaceDirection;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public Bounds backFaceBounds;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public bool twoSidedShadows;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF9")]
		public bool combineInRuntime;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFA")]
		public bool combineOnStart;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFB")]
		public bool useCombineSwapKey;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		public KeyCode combineSwapKey;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public HandleComponent originalMeshRenderers;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		public HandleComponent originalLODGroups;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public SearchOptions searchOptions;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public Vector3 oldPosition;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		public Vector3 oldScale;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public LodParentHolder[] lodParentHolders;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public List<CachedGameObject> foundObjects;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public List<CachedLodGameObject> foundLodObjects;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public List<LODGroup> foundLodGroups;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		public List<Collider> foundColliders;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		public HashSet<LODGroup> uniqueFoundLodGroups;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		public List<Mesh> unreadableMeshes;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		public HashSet<Mesh> selectImportSettingsMeshes;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		public HashSet<MeshCombineJobManager.MeshCombineJob> meshCombineJobs;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		public int totalMeshCombineJobs;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		public int mrDisabledCount;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		public bool combined;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x179")]
		public bool activeOriginal;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17A")]
		public bool combinedActive;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17B")]
		public bool drawGizmos;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		public bool drawMeshBounds;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		public int originalTotalVertices;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x184")]
		public int originalTotalTriangles;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		public int totalVertices;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
		public int totalTriangles;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		public int originalDrawCalls;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x194")]
		public int newDrawCalls;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		public int foundMaterialsCount;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
		public float combineTime;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		public FastList<MeshColliderAdd> addMeshCollidersList;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private HashSet<Transform> uniqueLodObjects;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private HashSet<Material> foundMaterials;

		[NonSerialized]
		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private MeshCombiner thisInstance;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private bool hasFoundFirstObject;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
		private Bounds bounds;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private Stopwatch stopwatch;

		[Token(Token = "0x14000001")]
		public event DefaultMethod OnCombiningReady
		{
			[Token(Token = "0x6000101")]
			[Address(RVA = "0x1037C20", Offset = "0x1037C20", VA = "0x1037C20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x835E18", Offset = "0x835E18")]
			add
			{
			}
			[Token(Token = "0x6000102")]
			[Address(RVA = "0x1037CC4", Offset = "0x1037CC4", VA = "0x1037CC4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x835E28", Offset = "0x835E28")]
			remove
			{
			}
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x1035BCC", Offset = "0x1035BCC", VA = "0x1035BCC")]
		public void AddMeshColliders()
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x1035CA8", Offset = "0x1035CA8", VA = "0x1035CA8")]
		public void ExecuteOnCombiningReady()
		{
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x1037F74", Offset = "0x1037F74", VA = "0x1037F74")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x1038000", Offset = "0x1038000", VA = "0x1038000")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x10380C4", Offset = "0x10380C4", VA = "0x10380C4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x10383A8", Offset = "0x10383A8", VA = "0x10383A8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x10385AC", Offset = "0x10385AC", VA = "0x10385AC")]
		public static MeshCombiner GetInstance(string name)
		{
			return null;
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x1038700", Offset = "0x1038700", VA = "0x1038700")]
		public void CopyJobSettingsToAllInstances()
		{
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x10381E8", Offset = "0x10381E8", VA = "0x10381E8")]
		public void InitMeshCombineJobManager()
		{
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x10387EC", Offset = "0x10387EC", VA = "0x10387EC")]
		public void CreateLodGroupsSettings()
		{
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x1038280", Offset = "0x1038280", VA = "0x1038280")]
		private void StartRuntime()
		{
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x102C080", Offset = "0x102C080", VA = "0x102C080")]
		public void DestroyCombinedObjects()
		{
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x1038BF4", Offset = "0x1038BF4", VA = "0x1038BF4")]
		private void Reset()
		{
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x1038A14", Offset = "0x1038A14", VA = "0x1038A14")]
		public void AbortAndClearMeshCombineJobs()
		{
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x1034C2C", Offset = "0x1034C2C", VA = "0x1034C2C")]
		public void ClearMeshCombineJobs()
		{
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x1038FF8", Offset = "0x1038FF8", VA = "0x1038FF8")]
		public void AddObjects(List<Transform> transforms, bool useSearchOptions, bool checkForLODGroups = true)
		{
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x102BD90", Offset = "0x102BD90", VA = "0x102BD90")]
		public void AddObjectsAutomatically()
		{
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x1039BD0", Offset = "0x1039BD0", VA = "0x1039BD0")]
		public void AddFoundObjectsToOctree()
		{
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x103A2E8", Offset = "0x103A2E8", VA = "0x103A2E8")]
		private void AddFoundMaterials(MeshRenderer mr)
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x1038D78", Offset = "0x1038D78", VA = "0x1038D78")]
		public void ResetOctree()
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x103A028", Offset = "0x103A028", VA = "0x103A028")]
		public void CalcOctreeSize(Bounds bounds)
		{
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x103A5A0", Offset = "0x103A5A0", VA = "0x103A5A0")]
		public void ApplyChanges()
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x102BE60", Offset = "0x102BE60", VA = "0x102BE60")]
		public void CombineAll()
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x1038EF8", Offset = "0x1038EF8", VA = "0x1038EF8")]
		private void InitAndResetLodParentsCount()
		{
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x1039990", Offset = "0x1039990", VA = "0x1039990")]
		public void AddObjectsFromSearchParent()
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x1039198", Offset = "0x1039198", VA = "0x1039198")]
		private void AddLodGroups(LODGroup[] lodGroups, bool useSearchOptions = true)
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x103975C", Offset = "0x103975C", VA = "0x103975C")]
		private void AddTransforms(Transform[] transforms, bool useSearchOptions = true)
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x103AFD4", Offset = "0x103AFD4", VA = "0x103AFD4")]
		private int ValidObject(Transform t, ObjectType objectType, bool useSearchOptions, ref CachedGameObject cachedGameObject)
		{
			return default(int);
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x10384E4", Offset = "0x10384E4", VA = "0x10384E4")]
		public void RestoreOriginalRenderersAndLODGroups()
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x103B68C", Offset = "0x103B68C", VA = "0x103B68C")]
		public void SwapCombine()
		{
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x103A684", Offset = "0x103A684", VA = "0x103A684")]
		private void SetOriginalCollidersActive(bool active)
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x103A900", Offset = "0x103A900", VA = "0x103A900")]
		public void ExecuteHandleObjects(bool active, HandleComponent handleOriginalObjects, HandleComponent handleOriginalLodGroups, bool includeColliders = true)
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x103B764", Offset = "0x103B764", VA = "0x103B764")]
		private void DrawGizmosCube(Bounds bounds, Color color)
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x103B87C", Offset = "0x103B87C", VA = "0x103B87C")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x1039E40", Offset = "0x1039E40", VA = "0x1039E40")]
		private void LogOctreeInfo()
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x103B9E8", Offset = "0x103B9E8", VA = "0x103B9E8")]
		public MeshCombiner()
		{
		}
	}
	[Token(Token = "0x200002F")]
	public struct MeshColliderAdd
	{
		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public GameObject go;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Mesh mesh;

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x8DF0AC", Offset = "0x8DF0AC", VA = "0x8DF0AC")]
		public MeshColliderAdd(GameObject go, Mesh mesh)
		{
		}
	}
	[Token(Token = "0x2000030")]
	[ExecuteInEditMode]
	public class ObjectSpawner : MonoBehaviour
	{
		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject[] objects;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float density;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector2 scaleRange;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 rotationRange;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector2 heightRange;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float scaleMulti;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float resolutionPerMeter;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool spawnInRuntime;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		public bool spawn;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
		public bool deleteChildren;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform t;

		[Token(Token = "0x6000129")]
		[Address(RVA = "0xFB1DA4", Offset = "0xFB1DA4", VA = "0xFB1DA4")]
		private void Awake()
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0xFB2320", Offset = "0xFB2320", VA = "0xFB2320")]
		private void Update()
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0xFB236C", Offset = "0xFB236C", VA = "0xFB236C")]
		public void DeleteChildren()
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0xFB1DF0", Offset = "0xFB1DF0", VA = "0xFB1DF0")]
		public void Spawn()
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0xFB24E0", Offset = "0xFB24E0", VA = "0xFB24E0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0xFB261C", Offset = "0xFB261C", VA = "0xFB261C")]
		public ObjectSpawner()
		{
		}
	}
	[Token(Token = "0x2000031")]
	public class RemoveGeometryBelowTerrain : MonoBehaviour
	{
		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int totalTriangles;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private int removeTriangles;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int skippedObjects;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<Transform> terrains;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public List<Transform> meshTerrains;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Bounds[] terrainBounds;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Bounds[] meshBounds;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Terrain[] terrainComponents;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Terrain[] terrainArray;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Bounds[] terrainBoundsArray;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private MeshRenderer[] mrs;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Mesh[] meshTerrainComponents;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Mesh[] meshArray;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool runOnStart;

		[Token(Token = "0x600012F")]
		[Address(RVA = "0xFB26DC", Offset = "0xFB26DC", VA = "0xFB26DC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0xFB2714", Offset = "0xFB2714", VA = "0xFB2714")]
		public void Remove(GameObject go)
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0xFB2A40", Offset = "0xFB2A40", VA = "0xFB2A40")]
		public void RemoveMesh(Transform t, Mesh mesh)
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0xFB2BE4", Offset = "0xFB2BE4", VA = "0xFB2BE4")]
		public bool IsMeshUnderTerrain(Transform t, Mesh mesh)
		{
			return default(bool);
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0xFB30C4", Offset = "0xFB30C4", VA = "0xFB30C4")]
		public void GetTerrainComponents()
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0xFB31D8", Offset = "0xFB31D8", VA = "0xFB31D8")]
		public void GetMeshRenderersAndComponents()
		{
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0xFB338C", Offset = "0xFB338C", VA = "0xFB338C")]
		public void CreateTerrainBounds()
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0xFB3640", Offset = "0xFB3640", VA = "0xFB3640")]
		public void MakeIntersectLists(Bounds bounds)
		{
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0xFB3BEC", Offset = "0xFB3BEC", VA = "0xFB3BEC")]
		public int InterectTerrain(Vector3 pos)
		{
			return default(int);
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0xFB3C94", Offset = "0xFB3C94", VA = "0xFB3C94")]
		public int InterectMesh(Vector3 pos)
		{
			return default(int);
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0xFB3D3C", Offset = "0xFB3D3C", VA = "0xFB3D3C")]
		public float GetTerrainHeight(Vector3 pos)
		{
			return default(float);
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0xFB2DB0", Offset = "0xFB2DB0", VA = "0xFB2DB0")]
		public void RemoveTriangles(Transform t, List<int> newTriangles, Vector3[] vertices)
		{
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0xFB3E38", Offset = "0xFB3E38", VA = "0xFB3E38")]
		public RemoveGeometryBelowTerrain()
		{
		}
	}
	[Token(Token = "0x2000032")]
	public class SwapCombineKey : MonoBehaviour
	{
		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static SwapCombineKey instance;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<MeshCombiner> meshCombinerList;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private MeshCombiner meshCombiner;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private GUIStyle textStyle;

		[Token(Token = "0x600013C")]
		[Address(RVA = "0xFB3ED4", Offset = "0xFB3ED4", VA = "0xFB3ED4")]
		private void Awake()
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0xFB3F60", Offset = "0xFB3F60", VA = "0xFB3F60")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0xFB3FB0", Offset = "0xFB3FB0", VA = "0xFB3FB0")]
		private void Update()
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0xFB4004", Offset = "0xFB4004", VA = "0xFB4004")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0xFB4300", Offset = "0xFB4300", VA = "0xFB4300")]
		public SwapCombineKey()
		{
		}
	}
	[Token(Token = "0x2000033")]
	public class CachedComponents : MonoBehaviour
	{
		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject go;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform t;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MeshRenderer mr;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public MeshFilter mf;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GarbageCollectMesh garbageCollectMesh;

		[Token(Token = "0x6000141")]
		[Address(RVA = "0xD042C0", Offset = "0xD042C0", VA = "0xD042C0")]
		public CachedComponents()
		{
		}
	}
	[Token(Token = "0x2000034")]
	public class Console : MonoBehaviour
	{
		[Token(Token = "0x20001B6")]
		public class LogEntry
		{
			[Token(Token = "0x400098E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string logString;

			[Token(Token = "0x400098F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string stackTrace;

			[Token(Token = "0x4000990")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public LogType logType;

			[Token(Token = "0x4000991")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public int commandType;

			[Token(Token = "0x4000992")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool unityLog;

			[Token(Token = "0x4000993")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float tStamp;

			[Token(Token = "0x4000994")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public GameObject go;

			[Token(Token = "0x4000995")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public MeshCombiner meshCombiner;

			[Token(Token = "0x6000CC0")]
			[Address(RVA = "0x1029A58", Offset = "0x1029A58", VA = "0x1029A58")]
			public LogEntry(string logString, string stackTrace, LogType logType, bool unityLog = false, int commandType = 0, [Optional] GameObject go, [Optional] MeshCombiner meshCombiner)
			{
			}
		}

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Console instance;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public KeyCode consoleKey;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool logActive;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		public bool showConsole;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E")]
		public bool showOnError;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F")]
		public bool combineAutomatic;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool showLast;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		private bool setFocus;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private GameObject selectGO;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public List<LogEntry> logs;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Rect window;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Rect inputRect;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Rect logRect;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Rect vScrollRect;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private string inputText;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float scrollPos;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private int lines;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private bool showUnityLog;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
		private bool showInputLog;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private MeshCombiner[] meshCombiners;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private MeshCombiner selectedMeshCombiner;

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x1028FB4", Offset = "0x1028FB4", VA = "0x1028FB4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x10290A4", Offset = "0x10290A4", VA = "0x10290A4")]
		private void ReportStartup()
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x1029030", Offset = "0x1029030", VA = "0x1029030")]
		private void FindMeshCombiners()
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x10292E0", Offset = "0x10292E0", VA = "0x10292E0")]
		private void ReportMeshCombiners(bool reportSelected = true)
		{
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x1029604", Offset = "0x1029604", VA = "0x1029604")]
		private void ReportMeshCombiner(MeshCombiner meshCombiner, bool foundText = false)
		{
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x10293E8", Offset = "0x10293E8", VA = "0x10293E8")]
		public int SelectMeshCombiner(string name)
		{
			return default(int);
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x1029920", Offset = "0x1029920", VA = "0x1029920")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x1029994", Offset = "0x1029994", VA = "0x1029994")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x1029A08", Offset = "0x1029A08", VA = "0x1029A08")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x1029208", Offset = "0x1029208", VA = "0x1029208")]
		public static void Log(string logString, int commandType = 0, [Optional] GameObject go, [Optional] MeshCombiner meshCombiner)
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x1029AC4", Offset = "0x1029AC4", VA = "0x1029AC4")]
		private void HandleLog(string logString, string stackTrace, LogType logType)
		{
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x1029BBC", Offset = "0x1029BBC", VA = "0x1029BBC")]
		private void Update()
		{
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x1029BA4", Offset = "0x1029BA4", VA = "0x1029BA4")]
		private void SetConsoleActive(bool active)
		{
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x1029C00", Offset = "0x1029C00", VA = "0x1029C00")]
		private void ExecuteCommand(string cmd)
		{
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x102BD30", Offset = "0x102BD30", VA = "0x102BD30")]
		private void DirSort()
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x102BBEC", Offset = "0x102BBEC", VA = "0x102BBEC")]
		private void DirSort(string name)
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x102C0DC", Offset = "0x102C0DC", VA = "0x102C0DC")]
		public void SortLog(GameObject[] gos, bool showMeshInfo = false)
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x102C7CC", Offset = "0x102C7CC", VA = "0x102C7CC")]
		private string GetMeshInfo(GameObject go, ref int meshCount)
		{
			return null;
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x102CA90", Offset = "0x102CA90", VA = "0x102CA90")]
		private void TimeStep(string cmd)
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x102CAC8", Offset = "0x102CAC8", VA = "0x102CAC8")]
		private void TimeScale(string cmd)
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x102B558", Offset = "0x102B558", VA = "0x102B558")]
		private void Clear(LogEntry log, string cmd)
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x102B86C", Offset = "0x102B86C", VA = "0x102B86C")]
		private void DirAll()
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x102A870", Offset = "0x102A870", VA = "0x102A870")]
		private void Dir()
		{
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x102AE80", Offset = "0x102AE80", VA = "0x102AE80")]
		private void Components(LogEntry log)
		{
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x102CC5C", Offset = "0x102CC5C", VA = "0x102CC5C")]
		private void ShowPath(bool showLines = true)
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x102CB00", Offset = "0x102CB00", VA = "0x102CB00")]
		private string GetPath(GameObject go)
		{
			return null;
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x102AFFC", Offset = "0x102AFFC", VA = "0x102AFFC")]
		private void CD(LogEntry log, string name)
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x102B208", Offset = "0x102B208", VA = "0x102B208")]
		public void SetActiveContains(string textContains, bool active)
		{
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x102B718", Offset = "0x102B718", VA = "0x102B718")]
		public void DirContains(string textContains)
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x102CD1C", Offset = "0x102CD1C", VA = "0x102CD1C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x102D964", Offset = "0x102D964", VA = "0x102D964")]
		private void AnimateColor(Color col, LogEntry log, float multi)
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x102DAB4", Offset = "0x102DAB4", VA = "0x102DAB4")]
		public Console()
		{
		}
	}
	[Token(Token = "0x2000035")]
	public class DirectDraw : MonoBehaviour
	{
		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private MeshRenderer[] mrs;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Mesh[] meshes;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Material[] mats;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3[] positions;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Quaternion[] rotations;

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x102DB50", Offset = "0x102DB50", VA = "0x102DB50")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x102DE00", Offset = "0x102DE00", VA = "0x102DE00")]
		private void SetMeshRenderersEnabled(bool enabled)
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x102DE7C", Offset = "0x102DE7C", VA = "0x102DE7C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x102DFFC", Offset = "0x102DFFC", VA = "0x102DFFC")]
		public DirectDraw()
		{
		}
	}
	[Token(Token = "0x2000036")]
	public class DisabledLodMeshRender : MonoBehaviour
	{
		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public MeshCombiner meshCombiner;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CachedLodGameObject cachedLodGO;

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x102E00C", Offset = "0x102E00C", VA = "0x102E00C")]
		public DisabledLodMeshRender()
		{
		}
	}
	[Token(Token = "0x2000037")]
	public class DisabledMeshRenderer : MonoBehaviour
	{
		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public MeshCombiner meshCombiner;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CachedGameObject cachedGO;

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x102E014", Offset = "0x102E014", VA = "0x102E014")]
		public DisabledMeshRenderer()
		{
		}
	}
	[Token(Token = "0x2000038")]
	public class FastListBase
	{
		[Token(Token = "0x400016F")]
		protected const int defaultCapacity = 4;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int Count;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		protected int _count;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected int arraySize;

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x102E01C", Offset = "0x102E01C", VA = "0x102E01C")]
		public FastListBase()
		{
		}
	}
	[Token(Token = "0x2000039")]
	public class FastListBase<T> : FastListBase
	{
		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T[] items;

		[Token(Token = "0x6000169")]
		protected void DoubleCapacity()
		{
		}

		[Token(Token = "0x600016A")]
		public FastListBase()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200003A")]
	public class FastList<T> : FastListBase<T>
	{
		[Token(Token = "0x600016B")]
		public FastList()
		{
		}

		[Token(Token = "0x600016C")]
		public FastList(bool reserve, int reserved)
		{
		}

		[Token(Token = "0x600016D")]
		public FastList(int capacity)
		{
		}

		[Token(Token = "0x600016E")]
		public FastList(FastList<T> list)
		{
		}

		[Token(Token = "0x600016F")]
		public FastList(T[] items)
		{
		}

		[Token(Token = "0x6000170")]
		protected void SetCapacity(int capacity)
		{
		}

		[Token(Token = "0x6000171")]
		public void SetCount(int count)
		{
		}

		[Token(Token = "0x6000172")]
		public void EnsureCount(int count)
		{
		}

		[Token(Token = "0x6000173")]
		public virtual void SetArray(T[] items)
		{
		}

		[Token(Token = "0x6000174")]
		public int AddUnique(T item)
		{
			return default(int);
		}

		[Token(Token = "0x6000175")]
		public bool Contains(T item)
		{
			return default(bool);
		}

		[Token(Token = "0x6000176")]
		public int IndexOf(T item)
		{
			return default(int);
		}

		[Token(Token = "0x6000177")]
		public T GetIndex(T item)
		{
			return (T)null;
		}

		[Token(Token = "0x6000178")]
		public virtual int Add(T item)
		{
			return default(int);
		}

		[Token(Token = "0x6000179")]
		public virtual int AddThreadSafe(T item)
		{
			return default(int);
		}

		[Token(Token = "0x600017A")]
		public virtual void Add(T item, T item2)
		{
		}

		[Token(Token = "0x600017B")]
		public virtual void Add(T item, T item2, T item3)
		{
		}

		[Token(Token = "0x600017C")]
		public virtual void Add(T item, T item2, T item3, T item4)
		{
		}

		[Token(Token = "0x600017D")]
		public virtual void Add(T item, T item2, T item3, T item4, T item5)
		{
		}

		[Token(Token = "0x600017E")]
		public virtual void Insert(int index, T item)
		{
		}

		[Token(Token = "0x600017F")]
		public virtual void AddRange(T[] arrayItems)
		{
		}

		[Token(Token = "0x6000180")]
		public virtual void AddRange(T[] arrayItems, int startIndex, int length)
		{
		}

		[Token(Token = "0x6000181")]
		public virtual void AddRange(FastList<T> list)
		{
		}

		[Token(Token = "0x6000182")]
		public virtual int GrabListThreadSafe(FastList<T> threadList, bool fastClear = false)
		{
			return default(int);
		}

		[Token(Token = "0x6000183")]
		public virtual void ChangeRange(int startIndex, T[] arrayItems)
		{
		}

		[Token(Token = "0x6000184")]
		public virtual bool Remove(T item, bool weakReference = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000185")]
		public virtual void RemoveAt(int index)
		{
		}

		[Token(Token = "0x6000186")]
		public virtual void RemoveLast()
		{
		}

		[Token(Token = "0x6000187")]
		public virtual void RemoveRange(int index, int length)
		{
		}

		[Token(Token = "0x6000188")]
		public virtual T Dequeue()
		{
			return (T)null;
		}

		[Token(Token = "0x6000189")]
		public virtual T Dequeue(int index)
		{
			return (T)null;
		}

		[Token(Token = "0x600018A")]
		public virtual void Clear()
		{
		}

		[Token(Token = "0x600018B")]
		public virtual void ClearThreadSafe()
		{
		}

		[Token(Token = "0x600018C")]
		public virtual void ClearRange(int startIndex)
		{
		}

		[Token(Token = "0x600018D")]
		public virtual void FastClear()
		{
		}

		[Token(Token = "0x600018E")]
		public virtual void FastClear(int newCount)
		{
		}

		[Token(Token = "0x600018F")]
		public virtual T[] ToArray()
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x200003B")]
	public class SortedFastList<T> : FastList<T>
	{
		[Token(Token = "0x6000190")]
		public new void RemoveAt(int index)
		{
		}

		[Token(Token = "0x6000191")]
		public new void RemoveRange(int index, int endIndex)
		{
		}

		[Token(Token = "0x6000192")]
		public SortedFastList()
		{
		}
	}
	[Token(Token = "0x200003C")]
	[ExecuteInEditMode]
	public class GarbageCollectMesh : MonoBehaviour
	{
		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Mesh mesh;

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x102E1B4", Offset = "0x102E1B4", VA = "0x102E1B4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x102E268", Offset = "0x102E268", VA = "0x102E268")]
		public GarbageCollectMesh()
		{
		}
	}
	[Token(Token = "0x200003D")]
	public class MCS_CameraController : MonoBehaviour
	{
		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float speed;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float mouseMoveSpeed;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float shiftMulti;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float controlMulti;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 oldMousePosition;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private GameObject cameraMountGO;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private GameObject cameraChildGO;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform cameraMountT;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform cameraChildT;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform t;

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x102EB18", Offset = "0x102EB18", VA = "0x102EB18")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x102EB44", Offset = "0x102EB44", VA = "0x102EB44")]
		private void CreateParents()
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x102EC74", Offset = "0x102EC74", VA = "0x102EC74")]
		private void Update()
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x102F058", Offset = "0x102F058", VA = "0x102F058")]
		public MCS_CameraController()
		{
		}
	}
	[Token(Token = "0x200003E")]
	public class MCS_FPSCounter : MonoBehaviour
	{
		[Token(Token = "0x20001B7")]
		public enum GUIType
		{
			[Token(Token = "0x4000997")]
			DisplayRunning,
			[Token(Token = "0x4000998")]
			DisplayResults,
			[Token(Token = "0x4000999")]
			DisplayNothing
		}

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static MCS_FPSCounter instance;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x832004", Offset = "0x832004")]
		public float interval;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public GUIType displayType;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector2 gradientRange;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Font fontRun;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Font fontResult;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Texture logo;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool showLogoOnResultsScreen;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public KeyCode showHideButton;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool acceptInput;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		public bool reset;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x83203C", Offset = "0x83203C")]
		public float currentFPS;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float averageFPS;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float minimumFPS;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float maximumFPS;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private int totalFrameCount;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int tempFrameCount;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private double tStamp;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private double tStampTemp;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private string currentFPSText;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private string avgFPSText;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private string minFPSText;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private string maxFSPText;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private GUIStyle bigStyle;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private GUIStyle bigStyleShadow;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private GUIStyle smallStyle;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private GUIStyle smallStyleShadow;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private GUIStyle smallStyleLabel;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private GUIStyle headerStyle;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Rect[] rectsRun;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Rect[] rectsResult;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Gradient gradient;

		[Token(Token = "0x400019F")]
		private const float line1 = 4f;

		[Token(Token = "0x40001A0")]
		private const float line2 = 30f;

		[Token(Token = "0x40001A1")]
		private const float line3 = 44f;

		[Token(Token = "0x40001A2")]
		private const float line4 = 58f;

		[Token(Token = "0x40001A3")]
		private const float labelWidth = 26f;

		[Token(Token = "0x40001A4")]
		private const float paddingH = 8f;

		[Token(Token = "0x40001A5")]
		private const float lineHeight = 22f;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private float columnRight;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private float columnLeft;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Color fontShadow;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Color label;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Color colorCurrent;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Color colorAvg;

		[Token(Token = "0x40001AC")]
		private const string resultHeader = "BENCHMARK RESULTS";

		[Token(Token = "0x40001AD")]
		private const string resultLabelAvg = "AVERAGE FPS:";

		[Token(Token = "0x40001AE")]
		private const string resultLabelMin = "MINIMUM FPS:";

		[Token(Token = "0x40001AF")]
		private const string resultLabelMax = "MAXIMUM FPS:";

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private GUIContent resultHeaderGUI;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private GUIContent reslutLabelAvgGUI;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private GUIContent avgTextGUI;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private GUIContent instructions;

		[Token(Token = "0x40001B4")]
		private const string runLabelAvg = "Avg:";

		[Token(Token = "0x40001B5")]
		private const string runLabelMin = "Min:";

		[Token(Token = "0x40001B6")]
		private const string runLabelMax = "Max:";

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Vector2 screenSize;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private GUIType oldDisplayType;

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x102F06C", Offset = "0x102F06C", VA = "0x102F06C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x102F258", Offset = "0x102F258", VA = "0x102F258")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x102F2F4", Offset = "0x102F2F4", VA = "0x102F2F4")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x102F928", Offset = "0x102F928", VA = "0x102F928")]
		private void SetRectsRun()
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x102FC9C", Offset = "0x102FC9C", VA = "0x102FC9C")]
		private void SetRectsResult()
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x10301CC", Offset = "0x10301CC", VA = "0x10301CC")]
		private void Start()
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x103043C", Offset = "0x103043C", VA = "0x103043C")]
		private void Update()
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x1030840", Offset = "0x1030840", VA = "0x1030840")]
		public void StartBenchmark()
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x103086C", Offset = "0x103086C", VA = "0x103086C")]
		public void StopBenchmark()
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x1030654", Offset = "0x1030654", VA = "0x1030654")]
		private void GetFPS()
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x1030608", Offset = "0x1030608", VA = "0x1030608")]
		public void Reset()
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x1030568", Offset = "0x1030568", VA = "0x1030568")]
		private Color EvaluateGradient(float f)
		{
			return default(Color);
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x10308DC", Offset = "0x10308DC", VA = "0x10308DC")]
		public MCS_FPSCounter()
		{
		}
	}
	[Token(Token = "0x200003F")]
	public struct AABB3
	{
		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 min;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Vector3 max;

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x8D312C", Offset = "0x8D312C", VA = "0x8D312C")]
		public AABB3(Vector3 min, Vector3 max)
		{
		}
	}
	[Token(Token = "0x2000040")]
	public struct Triangle3
	{
		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 a;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Vector3 b;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 c;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 dirAb;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 dirAc;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 dirBc;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 h1;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float ab;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float ac;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float bc;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float area;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public float h;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float ah;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float hb;

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x8DEB04", Offset = "0x8DEB04", VA = "0x8DEB04")]
		public void Calc()
		{
		}
	}
	[Token(Token = "0x2000041")]
	public struct Sphere3
	{
		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 center;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float radius;

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x8DEAF8", Offset = "0x8DEAF8", VA = "0x8DEAF8")]
		public Sphere3(Vector3 center, float radius)
		{
		}
	}
	[Token(Token = "0x2000042")]
	public struct Int2
	{
		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int x;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int y;

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x8DF05C", Offset = "0x8DF05C", VA = "0x8DF05C")]
		public Int2(int x, int y)
		{
		}
	}
	[Token(Token = "0x2000043")]
	public struct Int3
	{
		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int x;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int y;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int z;

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x8DF064", Offset = "0x8DF064", VA = "0x8DF064")]
		public Int3(int x, int y, int z)
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x102E284", Offset = "0x102E284", VA = "0x102E284")]
		public static Int3 operator +(Int3 a, Int3 b)
		{
			return default(Int3);
		}
	}
	[Token(Token = "0x2000044")]
	public static class Mathw
	{
		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly int[] bits;

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x1030B18", Offset = "0x1030B18", VA = "0x1030B18")]
		public static Vector3 Clamp(Vector3 v, float min, float max)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x1030B4C", Offset = "0x1030B4C", VA = "0x1030B4C")]
		public static Vector3 FloatToVector3(float v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x1030B88", Offset = "0x1030B88", VA = "0x1030B88")]
		public static float SinDeg(float angle)
		{
			return default(float);
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x1030BFC", Offset = "0x1030BFC", VA = "0x1030BFC")]
		public static float GetMax(Vector3 v)
		{
			return default(float);
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x1030C10", Offset = "0x1030C10", VA = "0x1030C10")]
		public static Vector3 SetMin(Vector3 v, float min)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x1030C2C", Offset = "0x1030C2C", VA = "0x1030C2C")]
		public static Vector3 Snap(Vector3 v, float snapSize)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x1030CCC", Offset = "0x1030CCC", VA = "0x1030CCC")]
		public static Vector3 Abs(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x1028CC8", Offset = "0x1028CC8", VA = "0x1028CC8")]
		public static bool IntersectAABB3Sphere3(AABB3 box, Sphere3 sphere)
		{
			return default(bool);
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x1030D24", Offset = "0x1030D24", VA = "0x1030D24")]
		public static bool IntersectAABB3Triangle3(Vector3 boxCenter, Vector3 boxHalfSize, Triangle3 triangle)
		{
			return default(bool);
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x10320A4", Offset = "0x10320A4", VA = "0x10320A4")]
		private static void GetMinMax(float x0, float x1, float x2, out float min, out float max)
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x10320F4", Offset = "0x10320F4", VA = "0x10320F4")]
		private static bool PlaneBoxOverlap(Vector3 normal, Vector3 vert, Vector3 maxBox)
		{
			return default(bool);
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x1031944", Offset = "0x1031944", VA = "0x1031944")]
		private static float Abs(float v)
		{
			return default(float);
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x1031954", Offset = "0x1031954", VA = "0x1031954")]
		private static bool AxisTest_X01(Vector3 v0, Vector3 v2, Vector3 boxHalfSize, float a, float b, float fa, float fb, out float min, out float max)
		{
			return default(bool);
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x1031E34", Offset = "0x1031E34", VA = "0x1031E34")]
		private static bool AxisTest_X2(Vector3 v0, Vector3 v1, Vector3 boxHalfSize, float a, float b, float fa, float fb, out float min, out float max)
		{
			return default(bool);
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x1031A8C", Offset = "0x1031A8C", VA = "0x1031A8C")]
		private static bool AxisTest_Y02(Vector3 v0, Vector3 v2, Vector3 boxHalfSize, float a, float b, float fa, float fb, out float min, out float max)
		{
			return default(bool);
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x1031F6C", Offset = "0x1031F6C", VA = "0x1031F6C")]
		private static bool AxisTest_Y1(Vector3 v0, Vector3 v1, Vector3 boxHalfSize, float a, float b, float fa, float fb, out float min, out float max)
		{
			return default(bool);
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x1031BC4", Offset = "0x1031BC4", VA = "0x1031BC4")]
		private static bool AxisTest_Z12(Vector3 v1, Vector3 v2, Vector3 boxHalfSize, float a, float b, float fa, float fb, out float min, out float max)
		{
			return default(bool);
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x1031CFC", Offset = "0x1031CFC", VA = "0x1031CFC")]
		private static bool AxisTest_Z0(Vector3 v0, Vector3 v1, Vector3 boxHalfSize, float a, float b, float fa, float fb, out float min, out float max)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000045")]
	public static class Methods
	{
		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x103C420", Offset = "0x103C420", VA = "0x103C420")]
		public static void SetTag(GameObject go, string tag)
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x103C4DC", Offset = "0x103C4DC", VA = "0x103C4DC")]
		public static void SetTagWhenCollider(GameObject go, string tag)
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x103C608", Offset = "0x103C608", VA = "0x103C608")]
		public static void SetTagAndLayer(GameObject go, string tag, int layer)
		{
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x103C6FC", Offset = "0x103C6FC", VA = "0x103C6FC")]
		public static void SetLayer(GameObject go, int layer)
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x103C7D4", Offset = "0x103C7D4", VA = "0x103C7D4")]
		public static bool LayerMaskContainsLayer(int layerMask, int layer)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x103C7E8", Offset = "0x103C7E8", VA = "0x103C7E8")]
		public static int GetFirstLayerInLayerMask(int layerMask)
		{
			return default(int);
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x102C658", Offset = "0x102C658", VA = "0x102C658")]
		public static bool Contains(string compare, string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C6")]
		public static T[] Search<T>([Optional] GameObject parentGO)
		{
			return null;
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x103C8A8", Offset = "0x103C8A8", VA = "0x103C8A8")]
		public static FastList<GameObject> GetAllRootGameObjects()
		{
			return null;
		}

		[Token(Token = "0x60001C8")]
		public static T[] SearchParent<T>(GameObject parentGO, bool searchInActiveGameObjects) where T : Component
		{
			return null;
		}

		[Token(Token = "0x60001C9")]
		public static T[] SearchScene<T>(Scene scene, bool searchInActiveGameObjects) where T : Component
		{
			return null;
		}

		[Token(Token = "0x60001CA")]
		public static FastList<T> SearchAllScenes<T>(bool searchInActiveGameObjects) where T : Component
		{
			return null;
		}

		[Token(Token = "0x60001CB")]
		public static T Find<T>(GameObject parentGO, string name) where T : Component
		{
			return null;
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x103C9A4", Offset = "0x103C9A4", VA = "0x103C9A4")]
		public static void SetCollidersActive(Collider[] colliders, bool active, string[] nameList)
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x103CAA0", Offset = "0x103CAA0", VA = "0x103CAA0")]
		public static void SelectChildrenWithMeshRenderer(Transform t)
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x1038B18", Offset = "0x1038B18", VA = "0x1038B18")]
		public static void DestroyChildren(Transform t)
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x103850C", Offset = "0x103850C", VA = "0x103850C")]
		public static void Destroy(GameObject go)
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x103B6D8", Offset = "0x103B6D8", VA = "0x103B6D8")]
		public static void SetChildrenActive(Transform t, bool active)
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x103A3F8", Offset = "0x103A3F8", VA = "0x103A3F8")]
		public static void SnapBoundsAndPreserveArea(ref Bounds bounds, float snapSize, Vector3 offset)
		{
		}

		[Token(Token = "0x60001D2")]
		public static void ListRemoveAt<T>(List<T> list, int index)
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x103CAA4", Offset = "0x103CAA4", VA = "0x103CAA4")]
		public static void CopyComponent(Component component, GameObject target)
		{
		}
	}
	[Token(Token = "0x2000046")]
	public class ReadMe : MonoBehaviour
	{
		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool buttonEdit;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string readme;

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0xFB26D4", Offset = "0xFB26D4", VA = "0xFB26D4")]
		public ReadMe()
		{
		}
	}
	[Token(Token = "0x2000047")]
	public static class TriangleAAB3
	{
	}
	[Token(Token = "0x2000048")]
	public class BaseOctree
	{
		[Token(Token = "0x20001B8")]
		public class Cell
		{
			[Token(Token = "0x400099A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Cell mainParent;

			[Token(Token = "0x400099B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Cell parent;

			[Token(Token = "0x400099C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool[] cellsUsed;

			[Token(Token = "0x400099D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Bounds bounds;

			[Token(Token = "0x400099E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public int cellIndex;

			[Token(Token = "0x400099F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public int cellCount;

			[Token(Token = "0x40009A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public int level;

			[Token(Token = "0x40009A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public int maxLevels;

			[Token(Token = "0x6000CC1")]
			[Address(RVA = "0xD04038", Offset = "0xD04038", VA = "0xD04038")]
			public Cell()
			{
			}

			[Token(Token = "0x6000CC2")]
			[Address(RVA = "0xD04040", Offset = "0xD04040", VA = "0xD04040")]
			public Cell(Vector3 position, Vector3 size, int maxLevels)
			{
			}

			[Token(Token = "0x6000CC3")]
			[Address(RVA = "0xD040E0", Offset = "0xD040E0", VA = "0xD040E0")]
			public Cell(Cell parent, int cellIndex, Bounds bounds)
			{
			}

			[Token(Token = "0x6000CC4")]
			[Address(RVA = "0xD04150", Offset = "0xD04150", VA = "0xD04150")]
			public void SetCell(Cell parent, int cellIndex, Bounds bounds)
			{
			}

			[Token(Token = "0x6000CC5")]
			protected int AddCell<T, U>(ref T[] cells, Vector3 position, out bool maxCellCreated) where T : Cell, new() where U : Cell, new()
			{
				return default(int);
			}

			[Token(Token = "0x6000CC6")]
			protected void AddCell<T, U>(ref T[] cells, int index, int x, int y, int z, out bool maxCellCreated) where T : Cell, new() where U : Cell, new()
			{
			}

			[Token(Token = "0x6000CC7")]
			[Address(RVA = "0xD0418C", Offset = "0xD0418C", VA = "0xD0418C")]
			public bool InsideBounds(Vector3 position)
			{
				return default(bool);
			}

			[Token(Token = "0x6000CC8")]
			[Address(RVA = "0xD042B4", Offset = "0xD042B4", VA = "0xD042B4")]
			public void Reset(ref Cell[] cells)
			{
			}
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0xD04030", Offset = "0xD04030", VA = "0xD04030")]
		public BaseOctree()
		{
		}
	}
	[Token(Token = "0x2000049")]
	public class ObjectOctree
	{
		[Token(Token = "0x20001B9")]
		public class LODParent
		{
			[Token(Token = "0x40009A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public GameObject cellGO;

			[Token(Token = "0x40009A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform cellT;

			[Token(Token = "0x40009A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public LODGroup lodGroup;

			[Token(Token = "0x40009A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public LODLevel[] lodLevels;

			[Token(Token = "0x40009A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool hasChanged;

			[Token(Token = "0x40009A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public int jobsPending;

			[Token(Token = "0x6000CC9")]
			[Address(RVA = "0xFB0A28", Offset = "0xFB0A28", VA = "0xFB0A28")]
			public LODParent(int lodCount)
			{
			}

			[Token(Token = "0x6000CCA")]
			[Address(RVA = "0xFB1ADC", Offset = "0xFB1ADC", VA = "0xFB1ADC")]
			public void AssignLODGroup(MeshCombiner meshCombiner)
			{
			}

			[Token(Token = "0x6000CCB")]
			[Address(RVA = "0xFB1C84", Offset = "0xFB1C84", VA = "0xFB1C84")]
			public void ApplyChanges(MeshCombiner meshCombiner)
			{
			}
		}

		[Token(Token = "0x20001BA")]
		public class LODLevel
		{
			[Token(Token = "0x40009A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<CachedGameObject> cachedGOs;

			[Token(Token = "0x40009A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public List<MeshObjectsHolder> meshObjectsHolders;

			[Token(Token = "0x40009AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public List<MeshObjectsHolder> changedMeshObjectsHolders;

			[Token(Token = "0x40009AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public List<MeshRenderer> newMeshRenderers;

			[Token(Token = "0x40009AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public int vertCount;

			[Token(Token = "0x40009AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public int objectCount;

			[Token(Token = "0x6000CCC")]
			[Address(RVA = "0xFB1078", Offset = "0xFB1078", VA = "0xFB1078")]
			public int GetSortMeshIndex(Material mat, bool shadowCastingModeTwoSided, int lightmapIndex)
			{
				return default(int);
			}

			[Token(Token = "0x6000CCD")]
			[Address(RVA = "0xFB19A0", Offset = "0xFB19A0", VA = "0xFB19A0")]
			public void ApplyChanges(MeshCombiner meshCombiner)
			{
			}

			[Token(Token = "0x6000CCE")]
			[Address(RVA = "0xFB1A44", Offset = "0xFB1A44", VA = "0xFB1A44")]
			public LODLevel()
			{
			}
		}

		[Token(Token = "0x20001BB")]
		public class MaxCell : Cell
		{
			[Token(Token = "0x40009AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static int maxCellCount;

			[Token(Token = "0x40009AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public LODParent[] lodParents;

			[Token(Token = "0x40009B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public List<LODParent> changedLodParents;

			[Token(Token = "0x40009B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public bool hasChanged;

			[Token(Token = "0x6000CCF")]
			[Address(RVA = "0xFB1CF0", Offset = "0xFB1CF0", VA = "0xFB1CF0")]
			public void ApplyChanges(MeshCombiner meshCombiner)
			{
			}

			[Token(Token = "0x6000CD0")]
			[Address(RVA = "0xFB1D9C", Offset = "0xFB1D9C", VA = "0xFB1D9C")]
			public MaxCell()
			{
			}
		}

		[Token(Token = "0x20001BC")]
		public class Cell : BaseOctree.Cell
		{
			[Token(Token = "0x40009B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Cell[] cells;

			[Token(Token = "0x6000CD1")]
			[Address(RVA = "0xFB0634", Offset = "0xFB0634", VA = "0xFB0634")]
			public Cell()
			{
			}

			[Token(Token = "0x6000CD2")]
			[Address(RVA = "0xFB063C", Offset = "0xFB063C", VA = "0xFB063C")]
			public Cell(Vector3 position, Vector3 size, int maxLevels)
			{
			}

			[Token(Token = "0x6000CD3")]
			[Address(RVA = "0xFB0644", Offset = "0xFB0644", VA = "0xFB0644")]
			public CachedGameObject AddObject(Vector3 position, MeshCombiner meshCombiner, CachedGameObject cachedGO, int lodParentIndex, int lodLevel, bool isChangeMode = false)
			{
				return null;
			}

			[Token(Token = "0x6000CD4")]
			[Address(RVA = "0xFB06E0", Offset = "0xFB06E0", VA = "0xFB06E0")]
			private void AddObjectInternal(MeshCombiner meshCombiner, CachedGameObject cachedGO, Vector3 position, int lodParentIndex, int lodLevel, bool isChangeMode)
			{
			}

			[Token(Token = "0x6000CD5")]
			[Address(RVA = "0xFB0E64", Offset = "0xFB0E64", VA = "0xFB0E64")]
			public void SortObjects(MeshCombiner meshCombiner)
			{
			}

			[Token(Token = "0x6000CD6")]
			[Address(RVA = "0xFB0B24", Offset = "0xFB0B24", VA = "0xFB0B24")]
			public bool SortObject(MeshCombiner meshCombiner, LODLevel lod, CachedGameObject cachedGO, bool isChangeMode = false)
			{
				return default(bool);
			}

			[Token(Token = "0x6000CD7")]
			[Address(RVA = "0xFB11B0", Offset = "0xFB11B0", VA = "0xFB11B0")]
			public void CombineMeshes(MeshCombiner meshCombiner, int lodParentIndex)
			{
			}

			[Token(Token = "0x6000CD8")]
			[Address(RVA = "0xFB15FC", Offset = "0xFB15FC", VA = "0xFB15FC")]
			public void Draw(MeshCombiner meshCombiner, bool onlyMaxLevel, bool drawLevel0)
			{
			}
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0xFB062C", Offset = "0xFB062C", VA = "0xFB062C")]
		public ObjectOctree()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004A")]
	public class MeshObjectsHolder
	{
		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Material mat;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<MeshObject> meshObjects;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ObjectOctree.LODParent lodParent;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<CachedGameObject> newCachedGOs;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int lodLevel;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public int lightmapIndex;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool shadowCastingModeTwoSided;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		public bool hasChanged;

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x103C330", Offset = "0x103C330", VA = "0x103C330")]
		public MeshObjectsHolder(CachedGameObject cachedGO, Material mat, int subMeshIndex, bool shadowCastingModeTwoSided, int lightmapIndex)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004B")]
	public class MeshObject
	{
		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CachedGameObject cachedGO;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MeshCache meshCache;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int subMeshIndex;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 position;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 scale;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Quaternion rotation;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public Vector4 lightmapScaleOffset;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public bool intersectsSurface;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public int startNewTriangleIndex;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int newTriangleCount;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool skip;

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x103C290", Offset = "0x103C290", VA = "0x103C290")]
		public MeshObject(CachedGameObject cachedGO, int subMeshIndex)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004C")]
	public class CachedGameObject
	{
		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameObject go;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform t;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MeshRenderer mr;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MeshFilter mf;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Mesh mesh;

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0xD042C8", Offset = "0xD042C8", VA = "0xD042C8")]
		public CachedGameObject(GameObject go, Transform t, MeshRenderer mr, MeshFilter mf, Mesh mesh)
		{
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0xD0431C", Offset = "0xD0431C", VA = "0xD0431C")]
		public CachedGameObject(CachedComponents cachedComponent)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004D")]
	public class CachedLodGameObject : CachedGameObject
	{
		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 center;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public int lodCount;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public int lodLevel;

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0xD04380", Offset = "0xD04380", VA = "0xD04380")]
		public CachedLodGameObject(CachedGameObject cachedGO, int lodCount, int lodLevel)
		{
		}
	}
}
namespace FMOD
{
	[Token(Token = "0x200004E")]
	public class VERSION
	{
		[Token(Token = "0x40001EE")]
		public const int number = 131076;

		[Token(Token = "0x40001EF")]
		public const string dll = "fmod";

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0xCF66A0", Offset = "0xCF66A0", VA = "0xCF66A0")]
		public VERSION()
		{
		}
	}
	[Token(Token = "0x200004F")]
	public class CONSTANTS
	{
		[Token(Token = "0x40001F0")]
		public const int MAX_CHANNEL_WIDTH = 32;

		[Token(Token = "0x40001F1")]
		public const int MAX_LISTENERS = 8;

		[Token(Token = "0x40001F2")]
		public const int REVERB_MAXINSTANCES = 4;

		[Token(Token = "0x40001F3")]
		public const int MAX_SYSTEMS = 8;

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x14F894C", Offset = "0x14F894C", VA = "0x14F894C")]
		public CONSTANTS()
		{
		}
	}
	[Token(Token = "0x2000050")]
	public enum RESULT
	{
		[Token(Token = "0x40001F5")]
		OK,
		[Token(Token = "0x40001F6")]
		ERR_BADCOMMAND,
		[Token(Token = "0x40001F7")]
		ERR_CHANNEL_ALLOC,
		[Token(Token = "0x40001F8")]
		ERR_CHANNEL_STOLEN,
		[Token(Token = "0x40001F9")]
		ERR_DMA,
		[Token(Token = "0x40001FA")]
		ERR_DSP_CONNECTION,
		[Token(Token = "0x40001FB")]
		ERR_DSP_DONTPROCESS,
		[Token(Token = "0x40001FC")]
		ERR_DSP_FORMAT,
		[Token(Token = "0x40001FD")]
		ERR_DSP_INUSE,
		[Token(Token = "0x40001FE")]
		ERR_DSP_NOTFOUND,
		[Token(Token = "0x40001FF")]
		ERR_DSP_RESERVED,
		[Token(Token = "0x4000200")]
		ERR_DSP_SILENCE,
		[Token(Token = "0x4000201")]
		ERR_DSP_TYPE,
		[Token(Token = "0x4000202")]
		ERR_FILE_BAD,
		[Token(Token = "0x4000203")]
		ERR_FILE_COULDNOTSEEK,
		[Token(Token = "0x4000204")]
		ERR_FILE_DISKEJECTED,
		[Token(Token = "0x4000205")]
		ERR_FILE_EOF,
		[Token(Token = "0x4000206")]
		ERR_FILE_ENDOFDATA,
		[Token(Token = "0x4000207")]
		ERR_FILE_NOTFOUND,
		[Token(Token = "0x4000208")]
		ERR_FORMAT,
		[Token(Token = "0x4000209")]
		ERR_HEADER_MISMATCH,
		[Token(Token = "0x400020A")]
		ERR_HTTP,
		[Token(Token = "0x400020B")]
		ERR_HTTP_ACCESS,
		[Token(Token = "0x400020C")]
		ERR_HTTP_PROXY_AUTH,
		[Token(Token = "0x400020D")]
		ERR_HTTP_SERVER_ERROR,
		[Token(Token = "0x400020E")]
		ERR_HTTP_TIMEOUT,
		[Token(Token = "0x400020F")]
		ERR_INITIALIZATION,
		[Token(Token = "0x4000210")]
		ERR_INITIALIZED,
		[Token(Token = "0x4000211")]
		ERR_INTERNAL,
		[Token(Token = "0x4000212")]
		ERR_INVALID_FLOAT,
		[Token(Token = "0x4000213")]
		ERR_INVALID_HANDLE,
		[Token(Token = "0x4000214")]
		ERR_INVALID_PARAM,
		[Token(Token = "0x4000215")]
		ERR_INVALID_POSITION,
		[Token(Token = "0x4000216")]
		ERR_INVALID_SPEAKER,
		[Token(Token = "0x4000217")]
		ERR_INVALID_SYNCPOINT,
		[Token(Token = "0x4000218")]
		ERR_INVALID_THREAD,
		[Token(Token = "0x4000219")]
		ERR_INVALID_VECTOR,
		[Token(Token = "0x400021A")]
		ERR_MAXAUDIBLE,
		[Token(Token = "0x400021B")]
		ERR_MEMORY,
		[Token(Token = "0x400021C")]
		ERR_MEMORY_CANTPOINT,
		[Token(Token = "0x400021D")]
		ERR_NEEDS3D,
		[Token(Token = "0x400021E")]
		ERR_NEEDSHARDWARE,
		[Token(Token = "0x400021F")]
		ERR_NET_CONNECT,
		[Token(Token = "0x4000220")]
		ERR_NET_SOCKET_ERROR,
		[Token(Token = "0x4000221")]
		ERR_NET_URL,
		[Token(Token = "0x4000222")]
		ERR_NET_WOULD_BLOCK,
		[Token(Token = "0x4000223")]
		ERR_NOTREADY,
		[Token(Token = "0x4000224")]
		ERR_OUTPUT_ALLOCATED,
		[Token(Token = "0x4000225")]
		ERR_OUTPUT_CREATEBUFFER,
		[Token(Token = "0x4000226")]
		ERR_OUTPUT_DRIVERCALL,
		[Token(Token = "0x4000227")]
		ERR_OUTPUT_FORMAT,
		[Token(Token = "0x4000228")]
		ERR_OUTPUT_INIT,
		[Token(Token = "0x4000229")]
		ERR_OUTPUT_NODRIVERS,
		[Token(Token = "0x400022A")]
		ERR_PLUGIN,
		[Token(Token = "0x400022B")]
		ERR_PLUGIN_MISSING,
		[Token(Token = "0x400022C")]
		ERR_PLUGIN_RESOURCE,
		[Token(Token = "0x400022D")]
		ERR_PLUGIN_VERSION,
		[Token(Token = "0x400022E")]
		ERR_RECORD,
		[Token(Token = "0x400022F")]
		ERR_REVERB_CHANNELGROUP,
		[Token(Token = "0x4000230")]
		ERR_REVERB_INSTANCE,
		[Token(Token = "0x4000231")]
		ERR_SUBSOUNDS,
		[Token(Token = "0x4000232")]
		ERR_SUBSOUND_ALLOCATED,
		[Token(Token = "0x4000233")]
		ERR_SUBSOUND_CANTMOVE,
		[Token(Token = "0x4000234")]
		ERR_TAGNOTFOUND,
		[Token(Token = "0x4000235")]
		ERR_TOOMANYCHANNELS,
		[Token(Token = "0x4000236")]
		ERR_TRUNCATED,
		[Token(Token = "0x4000237")]
		ERR_UNIMPLEMENTED,
		[Token(Token = "0x4000238")]
		ERR_UNINITIALIZED,
		[Token(Token = "0x4000239")]
		ERR_UNSUPPORTED,
		[Token(Token = "0x400023A")]
		ERR_VERSION,
		[Token(Token = "0x400023B")]
		ERR_EVENT_ALREADY_LOADED,
		[Token(Token = "0x400023C")]
		ERR_EVENT_LIVEUPDATE_BUSY,
		[Token(Token = "0x400023D")]
		ERR_EVENT_LIVEUPDATE_MISMATCH,
		[Token(Token = "0x400023E")]
		ERR_EVENT_LIVEUPDATE_TIMEOUT,
		[Token(Token = "0x400023F")]
		ERR_EVENT_NOTFOUND,
		[Token(Token = "0x4000240")]
		ERR_STUDIO_UNINITIALIZED,
		[Token(Token = "0x4000241")]
		ERR_STUDIO_NOT_LOADED,
		[Token(Token = "0x4000242")]
		ERR_INVALID_STRING,
		[Token(Token = "0x4000243")]
		ERR_ALREADY_LOCKED,
		[Token(Token = "0x4000244")]
		ERR_NOT_LOCKED,
		[Token(Token = "0x4000245")]
		ERR_RECORD_DISCONNECTED,
		[Token(Token = "0x4000246")]
		ERR_TOOMANYSAMPLES
	}
	[Token(Token = "0x2000051")]
	public enum CHANNELCONTROL_TYPE
	{
		[Token(Token = "0x4000248")]
		CHANNEL,
		[Token(Token = "0x4000249")]
		CHANNELGROUP,
		[Token(Token = "0x400024A")]
		MAX
	}
	[Token(Token = "0x2000052")]
	public struct VECTOR
	{
		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float x;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float y;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float z;
	}
	[Token(Token = "0x2000053")]
	public struct ATTRIBUTES_3D
	{
		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public VECTOR position;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public VECTOR velocity;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VECTOR forward;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public VECTOR up;
	}
	[Token(Token = "0x2000054")]
	public struct ASYNCREADINFO
	{
		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint offset;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public uint sizebytes;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int priority;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IntPtr userdata;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IntPtr buffer;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public uint bytesread;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public FILE_ASYNCDONE_FUNC done;
	}
	[Token(Token = "0x2000055")]
	public enum OUTPUTTYPE
	{
		[Token(Token = "0x400025B")]
		AUTODETECT,
		[Token(Token = "0x400025C")]
		UNKNOWN,
		[Token(Token = "0x400025D")]
		NOSOUND,
		[Token(Token = "0x400025E")]
		WAVWRITER,
		[Token(Token = "0x400025F")]
		NOSOUND_NRT,
		[Token(Token = "0x4000260")]
		WAVWRITER_NRT,
		[Token(Token = "0x4000261")]
		WASAPI,
		[Token(Token = "0x4000262")]
		ASIO,
		[Token(Token = "0x4000263")]
		PULSEAUDIO,
		[Token(Token = "0x4000264")]
		ALSA,
		[Token(Token = "0x4000265")]
		COREAUDIO,
		[Token(Token = "0x4000266")]
		AUDIOTRACK,
		[Token(Token = "0x4000267")]
		OPENSL,
		[Token(Token = "0x4000268")]
		AUDIOOUT,
		[Token(Token = "0x4000269")]
		AUDIO3D,
		[Token(Token = "0x400026A")]
		WEBAUDIO,
		[Token(Token = "0x400026B")]
		NNAUDIO,
		[Token(Token = "0x400026C")]
		WINSONIC,
		[Token(Token = "0x400026D")]
		AAUDIO,
		[Token(Token = "0x400026E")]
		MAX
	}
	[Token(Token = "0x2000056")]
	public enum DEBUG_MODE
	{
		[Token(Token = "0x4000270")]
		TTY,
		[Token(Token = "0x4000271")]
		FILE,
		[Token(Token = "0x4000272")]
		CALLBACK
	}
	[Token(Token = "0x2000057")]
	[Flags]
	public enum DEBUG_FLAGS : uint
	{
		[Token(Token = "0x4000274")]
		NONE = 0u,
		[Token(Token = "0x4000275")]
		ERROR = 1u,
		[Token(Token = "0x4000276")]
		WARNING = 2u,
		[Token(Token = "0x4000277")]
		LOG = 4u,
		[Token(Token = "0x4000278")]
		TYPE_MEMORY = 0x100u,
		[Token(Token = "0x4000279")]
		TYPE_FILE = 0x200u,
		[Token(Token = "0x400027A")]
		TYPE_CODEC = 0x400u,
		[Token(Token = "0x400027B")]
		TYPE_TRACE = 0x800u,
		[Token(Token = "0x400027C")]
		DISPLAY_TIMESTAMPS = 0x10000u,
		[Token(Token = "0x400027D")]
		DISPLAY_LINENUMBERS = 0x20000u,
		[Token(Token = "0x400027E")]
		DISPLAY_THREAD = 0x40000u
	}
	[Token(Token = "0x2000058")]
	[Flags]
	public enum MEMORY_TYPE : uint
	{
		[Token(Token = "0x4000280")]
		NORMAL = 0u,
		[Token(Token = "0x4000281")]
		STREAM_FILE = 1u,
		[Token(Token = "0x4000282")]
		STREAM_DECODE = 2u,
		[Token(Token = "0x4000283")]
		SAMPLEDATA = 4u,
		[Token(Token = "0x4000284")]
		DSP_BUFFER = 8u,
		[Token(Token = "0x4000285")]
		PLUGIN = 0x10u,
		[Token(Token = "0x4000286")]
		PERSISTENT = 0x200000u,
		[Token(Token = "0x4000287")]
		ALL = uint.MaxValue
	}
	[Token(Token = "0x2000059")]
	public enum SPEAKERMODE
	{
		[Token(Token = "0x4000289")]
		DEFAULT,
		[Token(Token = "0x400028A")]
		RAW,
		[Token(Token = "0x400028B")]
		MONO,
		[Token(Token = "0x400028C")]
		STEREO,
		[Token(Token = "0x400028D")]
		QUAD,
		[Token(Token = "0x400028E")]
		SURROUND,
		[Token(Token = "0x400028F")]
		_5POINT1,
		[Token(Token = "0x4000290")]
		_7POINT1,
		[Token(Token = "0x4000291")]
		_7POINT1POINT4,
		[Token(Token = "0x4000292")]
		MAX
	}
	[Token(Token = "0x200005A")]
	public enum SPEAKER
	{
		[Token(Token = "0x4000294")]
		NONE = -1,
		[Token(Token = "0x4000295")]
		FRONT_LEFT,
		[Token(Token = "0x4000296")]
		FRONT_RIGHT,
		[Token(Token = "0x4000297")]
		FRONT_CENTER,
		[Token(Token = "0x4000298")]
		LOW_FREQUENCY,
		[Token(Token = "0x4000299")]
		SURROUND_LEFT,
		[Token(Token = "0x400029A")]
		SURROUND_RIGHT,
		[Token(Token = "0x400029B")]
		BACK_LEFT,
		[Token(Token = "0x400029C")]
		BACK_RIGHT,
		[Token(Token = "0x400029D")]
		TOP_FRONT_LEFT,
		[Token(Token = "0x400029E")]
		TOP_FRONT_RIGHT,
		[Token(Token = "0x400029F")]
		TOP_BACK_LEFT,
		[Token(Token = "0x40002A0")]
		TOP_BACK_RIGHT,
		[Token(Token = "0x40002A1")]
		MAX
	}
	[Token(Token = "0x200005B")]
	[Flags]
	public enum CHANNELMASK : uint
	{
		[Token(Token = "0x40002A3")]
		FRONT_LEFT = 1u,
		[Token(Token = "0x40002A4")]
		FRONT_RIGHT = 2u,
		[Token(Token = "0x40002A5")]
		FRONT_CENTER = 4u,
		[Token(Token = "0x40002A6")]
		LOW_FREQUENCY = 8u,
		[Token(Token = "0x40002A7")]
		SURROUND_LEFT = 0x10u,
		[Token(Token = "0x40002A8")]
		SURROUND_RIGHT = 0x20u,
		[Token(Token = "0x40002A9")]
		BACK_LEFT = 0x40u,
		[Token(Token = "0x40002AA")]
		BACK_RIGHT = 0x80u,
		[Token(Token = "0x40002AB")]
		BACK_CENTER = 0x100u,
		[Token(Token = "0x40002AC")]
		MONO = 1u,
		[Token(Token = "0x40002AD")]
		STEREO = 3u,
		[Token(Token = "0x40002AE")]
		LRC = 7u,
		[Token(Token = "0x40002AF")]
		QUAD = 0x33u,
		[Token(Token = "0x40002B0")]
		SURROUND = 0x37u,
		[Token(Token = "0x40002B1")]
		_5POINT1 = 0x3Fu,
		[Token(Token = "0x40002B2")]
		_5POINT1_REARS = 0xCFu,
		[Token(Token = "0x40002B3")]
		_7POINT0 = 0xF7u,
		[Token(Token = "0x40002B4")]
		_7POINT1 = 0xFFu
	}
	[Token(Token = "0x200005C")]
	public enum CHANNELORDER
	{
		[Token(Token = "0x40002B6")]
		DEFAULT,
		[Token(Token = "0x40002B7")]
		WAVEFORMAT,
		[Token(Token = "0x40002B8")]
		PROTOOLS,
		[Token(Token = "0x40002B9")]
		ALLMONO,
		[Token(Token = "0x40002BA")]
		ALLSTEREO,
		[Token(Token = "0x40002BB")]
		ALSA,
		[Token(Token = "0x40002BC")]
		MAX
	}
	[Token(Token = "0x200005D")]
	public enum PLUGINTYPE
	{
		[Token(Token = "0x40002BE")]
		OUTPUT,
		[Token(Token = "0x40002BF")]
		CODEC,
		[Token(Token = "0x40002C0")]
		DSP,
		[Token(Token = "0x40002C1")]
		MAX
	}
	[Token(Token = "0x200005E")]
	public struct PLUGINLIST
	{
		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private PLUGINTYPE type;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private IntPtr description;
	}
	[Token(Token = "0x200005F")]
	[Flags]
	public enum INITFLAGS : uint
	{
		[Token(Token = "0x40002C5")]
		NORMAL = 0u,
		[Token(Token = "0x40002C6")]
		STREAM_FROM_UPDATE = 1u,
		[Token(Token = "0x40002C7")]
		MIX_FROM_UPDATE = 2u,
		[Token(Token = "0x40002C8")]
		_3D_RIGHTHANDED = 4u,
		[Token(Token = "0x40002C9")]
		CHANNEL_LOWPASS = 0x100u,
		[Token(Token = "0x40002CA")]
		CHANNEL_DISTANCEFILTER = 0x200u,
		[Token(Token = "0x40002CB")]
		PROFILE_ENABLE = 0x10000u,
		[Token(Token = "0x40002CC")]
		VOL0_BECOMES_VIRTUAL = 0x20000u,
		[Token(Token = "0x40002CD")]
		GEOMETRY_USECLOSEST = 0x40000u,
		[Token(Token = "0x40002CE")]
		PREFER_DOLBY_DOWNMIX = 0x80000u,
		[Token(Token = "0x40002CF")]
		THREAD_UNSAFE = 0x100000u,
		[Token(Token = "0x40002D0")]
		PROFILE_METER_ALL = 0x200000u
	}
	[Token(Token = "0x2000060")]
	public enum SOUND_TYPE
	{
		[Token(Token = "0x40002D2")]
		UNKNOWN,
		[Token(Token = "0x40002D3")]
		AIFF,
		[Token(Token = "0x40002D4")]
		ASF,
		[Token(Token = "0x40002D5")]
		DLS,
		[Token(Token = "0x40002D6")]
		FLAC,
		[Token(Token = "0x40002D7")]
		FSB,
		[Token(Token = "0x40002D8")]
		IT,
		[Token(Token = "0x40002D9")]
		MIDI,
		[Token(Token = "0x40002DA")]
		MOD,
		[Token(Token = "0x40002DB")]
		MPEG,
		[Token(Token = "0x40002DC")]
		OGGVORBIS,
		[Token(Token = "0x40002DD")]
		PLAYLIST,
		[Token(Token = "0x40002DE")]
		RAW,
		[Token(Token = "0x40002DF")]
		S3M,
		[Token(Token = "0x40002E0")]
		USER,
		[Token(Token = "0x40002E1")]
		WAV,
		[Token(Token = "0x40002E2")]
		XM,
		[Token(Token = "0x40002E3")]
		XMA,
		[Token(Token = "0x40002E4")]
		AUDIOQUEUE,
		[Token(Token = "0x40002E5")]
		AT9,
		[Token(Token = "0x40002E6")]
		VORBIS,
		[Token(Token = "0x40002E7")]
		MEDIA_FOUNDATION,
		[Token(Token = "0x40002E8")]
		MEDIACODEC,
		[Token(Token = "0x40002E9")]
		FADPCM,
		[Token(Token = "0x40002EA")]
		MAX
	}
	[Token(Token = "0x2000061")]
	public enum SOUND_FORMAT
	{
		[Token(Token = "0x40002EC")]
		NONE,
		[Token(Token = "0x40002ED")]
		PCM8,
		[Token(Token = "0x40002EE")]
		PCM16,
		[Token(Token = "0x40002EF")]
		PCM24,
		[Token(Token = "0x40002F0")]
		PCM32,
		[Token(Token = "0x40002F1")]
		PCMFLOAT,
		[Token(Token = "0x40002F2")]
		BITSTREAM,
		[Token(Token = "0x40002F3")]
		MAX
	}
	[Token(Token = "0x2000062")]
	[Flags]
	public enum MODE : uint
	{
		[Token(Token = "0x40002F5")]
		DEFAULT = 0u,
		[Token(Token = "0x40002F6")]
		LOOP_OFF = 1u,
		[Token(Token = "0x40002F7")]
		LOOP_NORMAL = 2u,
		[Token(Token = "0x40002F8")]
		LOOP_BIDI = 4u,
		[Token(Token = "0x40002F9")]
		_2D = 8u,
		[Token(Token = "0x40002FA")]
		_3D = 0x10u,
		[Token(Token = "0x40002FB")]
		CREATESTREAM = 0x80u,
		[Token(Token = "0x40002FC")]
		CREATESAMPLE = 0x100u,
		[Token(Token = "0x40002FD")]
		CREATECOMPRESSEDSAMPLE = 0x200u,
		[Token(Token = "0x40002FE")]
		OPENUSER = 0x400u,
		[Token(Token = "0x40002FF")]
		OPENMEMORY = 0x800u,
		[Token(Token = "0x4000300")]
		OPENMEMORY_POINT = 0x10000000u,
		[Token(Token = "0x4000301")]
		OPENRAW = 0x1000u,
		[Token(Token = "0x4000302")]
		OPENONLY = 0x2000u,
		[Token(Token = "0x4000303")]
		ACCURATETIME = 0x4000u,
		[Token(Token = "0x4000304")]
		MPEGSEARCH = 0x8000u,
		[Token(Token = "0x4000305")]
		NONBLOCKING = 0x10000u,
		[Token(Token = "0x4000306")]
		UNIQUE = 0x20000u,
		[Token(Token = "0x4000307")]
		_3D_HEADRELATIVE = 0x40000u,
		[Token(Token = "0x4000308")]
		_3D_WORLDRELATIVE = 0x80000u,
		[Token(Token = "0x4000309")]
		_3D_INVERSEROLLOFF = 0x100000u,
		[Token(Token = "0x400030A")]
		_3D_LINEARROLLOFF = 0x200000u,
		[Token(Token = "0x400030B")]
		_3D_LINEARSQUAREROLLOFF = 0x400000u,
		[Token(Token = "0x400030C")]
		_3D_INVERSETAPEREDROLLOFF = 0x800000u,
		[Token(Token = "0x400030D")]
		_3D_CUSTOMROLLOFF = 0x4000000u,
		[Token(Token = "0x400030E")]
		_3D_IGNOREGEOMETRY = 0x40000000u,
		[Token(Token = "0x400030F")]
		IGNORETAGS = 0x2000000u,
		[Token(Token = "0x4000310")]
		LOWMEM = 0x8000000u,
		[Token(Token = "0x4000311")]
		VIRTUAL_PLAYFROMSTART = 0x80000000u
	}
	[Token(Token = "0x2000063")]
	public enum OPENSTATE
	{
		[Token(Token = "0x4000313")]
		READY,
		[Token(Token = "0x4000314")]
		LOADING,
		[Token(Token = "0x4000315")]
		ERROR,
		[Token(Token = "0x4000316")]
		CONNECTING,
		[Token(Token = "0x4000317")]
		BUFFERING,
		[Token(Token = "0x4000318")]
		SEEKING,
		[Token(Token = "0x4000319")]
		PLAYING,
		[Token(Token = "0x400031A")]
		SETPOSITION,
		[Token(Token = "0x400031B")]
		MAX
	}
	[Token(Token = "0x2000064")]
	public enum SOUNDGROUP_BEHAVIOR
	{
		[Token(Token = "0x400031D")]
		BEHAVIOR_FAIL,
		[Token(Token = "0x400031E")]
		BEHAVIOR_MUTE,
		[Token(Token = "0x400031F")]
		BEHAVIOR_STEALLOWEST,
		[Token(Token = "0x4000320")]
		MAX
	}
	[Token(Token = "0x2000065")]
	public enum CHANNELCONTROL_CALLBACK_TYPE
	{
		[Token(Token = "0x4000322")]
		END,
		[Token(Token = "0x4000323")]
		VIRTUALVOICE,
		[Token(Token = "0x4000324")]
		SYNCPOINT,
		[Token(Token = "0x4000325")]
		OCCLUSION,
		[Token(Token = "0x4000326")]
		MAX
	}
	[Token(Token = "0x2000066")]
	public struct CHANNELCONTROL_DSP_INDEX
	{
		[Token(Token = "0x4000327")]
		public const int HEAD = -1;

		[Token(Token = "0x4000328")]
		public const int FADER = -2;

		[Token(Token = "0x4000329")]
		public const int TAIL = -3;
	}
	[Token(Token = "0x2000067")]
	public enum ERRORCALLBACK_INSTANCETYPE
	{
		[Token(Token = "0x400032B")]
		NONE,
		[Token(Token = "0x400032C")]
		SYSTEM,
		[Token(Token = "0x400032D")]
		CHANNEL,
		[Token(Token = "0x400032E")]
		CHANNELGROUP,
		[Token(Token = "0x400032F")]
		CHANNELCONTROL,
		[Token(Token = "0x4000330")]
		SOUND,
		[Token(Token = "0x4000331")]
		SOUNDGROUP,
		[Token(Token = "0x4000332")]
		DSP,
		[Token(Token = "0x4000333")]
		DSPCONNECTION,
		[Token(Token = "0x4000334")]
		GEOMETRY,
		[Token(Token = "0x4000335")]
		REVERB3D,
		[Token(Token = "0x4000336")]
		STUDIO_SYSTEM,
		[Token(Token = "0x4000337")]
		STUDIO_EVENTDESCRIPTION,
		[Token(Token = "0x4000338")]
		STUDIO_EVENTINSTANCE,
		[Token(Token = "0x4000339")]
		STUDIO_PARAMETERINSTANCE,
		[Token(Token = "0x400033A")]
		STUDIO_BUS,
		[Token(Token = "0x400033B")]
		STUDIO_VCA,
		[Token(Token = "0x400033C")]
		STUDIO_BANK,
		[Token(Token = "0x400033D")]
		STUDIO_COMMANDREPLAY
	}
	[Token(Token = "0x2000068")]
	public struct ERRORCALLBACK_INFO
	{
		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public RESULT result;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public ERRORCALLBACK_INSTANCETYPE instancetype;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public IntPtr instance;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public StringWrapper functionname;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public StringWrapper functionparams;
	}
	[Token(Token = "0x2000069")]
	[Flags]
	public enum SYSTEM_CALLBACK_TYPE : uint
	{
		[Token(Token = "0x4000344")]
		DEVICELISTCHANGED = 1u,
		[Token(Token = "0x4000345")]
		DEVICELOST = 2u,
		[Token(Token = "0x4000346")]
		MEMORYALLOCATIONFAILED = 4u,
		[Token(Token = "0x4000347")]
		THREADCREATED = 8u,
		[Token(Token = "0x4000348")]
		BADDSPCONNECTION = 0x10u,
		[Token(Token = "0x4000349")]
		PREMIX = 0x20u,
		[Token(Token = "0x400034A")]
		POSTMIX = 0x40u,
		[Token(Token = "0x400034B")]
		ERROR = 0x80u,
		[Token(Token = "0x400034C")]
		MIDMIX = 0x100u,
		[Token(Token = "0x400034D")]
		THREADDESTROYED = 0x200u,
		[Token(Token = "0x400034E")]
		PREUPDATE = 0x400u,
		[Token(Token = "0x400034F")]
		POSTUPDATE = 0x800u,
		[Token(Token = "0x4000350")]
		RECORDLISTCHANGED = 0x1000u,
		[Token(Token = "0x4000351")]
		ALL = uint.MaxValue
	}
	[Token(Token = "0x200006A")]
	public delegate RESULT DEBUG_CALLBACK(DEBUG_FLAGS flags, StringWrapper file, int line, StringWrapper func, StringWrapper message);
	[Token(Token = "0x200006B")]
	public delegate RESULT SYSTEM_CALLBACK(IntPtr system, SYSTEM_CALLBACK_TYPE type, IntPtr commanddata1, IntPtr commanddata2, IntPtr userdata);
	[Token(Token = "0x200006C")]
	public delegate RESULT CHANNELCONTROL_CALLBACK(IntPtr channelcontrol, CHANNELCONTROL_TYPE controltype, CHANNELCONTROL_CALLBACK_TYPE callbacktype, IntPtr commanddata1, IntPtr commanddata2);
	[Token(Token = "0x200006D")]
	public delegate RESULT SOUND_NONBLOCK_CALLBACK(IntPtr sound, RESULT result);
	[Token(Token = "0x200006E")]
	public delegate RESULT SOUND_PCMREAD_CALLBACK(IntPtr sound, IntPtr data, uint datalen);
	[Token(Token = "0x200006F")]
	public delegate RESULT SOUND_PCMSETPOS_CALLBACK(IntPtr sound, int subsound, uint position, TIMEUNIT postype);
	[Token(Token = "0x2000070")]
	public delegate RESULT FILE_OPEN_CALLBACK(StringWrapper name, ref uint filesize, ref IntPtr handle, IntPtr userdata);
	[Token(Token = "0x2000071")]
	public delegate RESULT FILE_CLOSE_CALLBACK(IntPtr handle, IntPtr userdata);
	[Token(Token = "0x2000072")]
	public delegate RESULT FILE_READ_CALLBACK(IntPtr handle, IntPtr buffer, uint sizebytes, ref uint bytesread, IntPtr userdata);
	[Token(Token = "0x2000073")]
	public delegate RESULT FILE_SEEK_CALLBACK(IntPtr handle, uint pos, IntPtr userdata);
	[Token(Token = "0x2000074")]
	public delegate RESULT FILE_ASYNCREAD_CALLBACK(IntPtr info, IntPtr userdata);
	[Token(Token = "0x2000075")]
	public delegate RESULT FILE_ASYNCCANCEL_CALLBACK(IntPtr info, IntPtr userdata);
	[Token(Token = "0x2000076")]
	public delegate RESULT FILE_ASYNCDONE_FUNC(IntPtr info, RESULT result);
	[Token(Token = "0x2000077")]
	public delegate IntPtr MEMORY_ALLOC_CALLBACK(uint size, MEMORY_TYPE type, StringWrapper sourcestr);
	[Token(Token = "0x2000078")]
	public delegate IntPtr MEMORY_REALLOC_CALLBACK(IntPtr ptr, uint size, MEMORY_TYPE type, StringWrapper sourcestr);
	[Token(Token = "0x2000079")]
	public delegate void MEMORY_FREE_CALLBACK(IntPtr ptr, MEMORY_TYPE type, StringWrapper sourcestr);
	[Token(Token = "0x200007A")]
	public delegate float CB_3D_ROLLOFF_CALLBACK(IntPtr channelcontrol, float distance);
	[Token(Token = "0x200007B")]
	public enum DSP_RESAMPLER
	{
		[Token(Token = "0x4000353")]
		DEFAULT,
		[Token(Token = "0x4000354")]
		NOINTERP,
		[Token(Token = "0x4000355")]
		LINEAR,
		[Token(Token = "0x4000356")]
		CUBIC,
		[Token(Token = "0x4000357")]
		SPLINE,
		[Token(Token = "0x4000358")]
		MAX
	}
	[Token(Token = "0x200007C")]
	public enum DSPCONNECTION_TYPE
	{
		[Token(Token = "0x400035A")]
		STANDARD,
		[Token(Token = "0x400035B")]
		SIDECHAIN,
		[Token(Token = "0x400035C")]
		SEND,
		[Token(Token = "0x400035D")]
		SEND_SIDECHAIN,
		[Token(Token = "0x400035E")]
		MAX
	}
	[Token(Token = "0x200007D")]
	public enum TAGTYPE
	{
		[Token(Token = "0x4000360")]
		UNKNOWN,
		[Token(Token = "0x4000361")]
		ID3V1,
		[Token(Token = "0x4000362")]
		ID3V2,
		[Token(Token = "0x4000363")]
		VORBISCOMMENT,
		[Token(Token = "0x4000364")]
		SHOUTCAST,
		[Token(Token = "0x4000365")]
		ICECAST,
		[Token(Token = "0x4000366")]
		ASF,
		[Token(Token = "0x4000367")]
		MIDI,
		[Token(Token = "0x4000368")]
		PLAYLIST,
		[Token(Token = "0x4000369")]
		FMOD,
		[Token(Token = "0x400036A")]
		USER,
		[Token(Token = "0x400036B")]
		MAX
	}
	[Token(Token = "0x200007E")]
	public enum TAGDATATYPE
	{
		[Token(Token = "0x400036D")]
		BINARY,
		[Token(Token = "0x400036E")]
		INT,
		[Token(Token = "0x400036F")]
		FLOAT,
		[Token(Token = "0x4000370")]
		STRING,
		[Token(Token = "0x4000371")]
		STRING_UTF16,
		[Token(Token = "0x4000372")]
		STRING_UTF16BE,
		[Token(Token = "0x4000373")]
		STRING_UTF8,
		[Token(Token = "0x4000374")]
		MAX
	}
	[Token(Token = "0x200007F")]
	public struct TAG
	{
		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public TAGTYPE type;

		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public TAGDATATYPE datatype;

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public StringWrapper name;

		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IntPtr data;

		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public uint datalen;

		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool updated;
	}
	[Token(Token = "0x2000080")]
	[Flags]
	public enum TIMEUNIT : uint
	{
		[Token(Token = "0x400037C")]
		MS = 1u,
		[Token(Token = "0x400037D")]
		PCM = 2u,
		[Token(Token = "0x400037E")]
		PCMBYTES = 4u,
		[Token(Token = "0x400037F")]
		RAWBYTES = 8u,
		[Token(Token = "0x4000380")]
		PCMFRACTION = 0x10u,
		[Token(Token = "0x4000381")]
		MODORDER = 0x100u,
		[Token(Token = "0x4000382")]
		MODROW = 0x200u,
		[Token(Token = "0x4000383")]
		MODPATTERN = 0x400u
	}
	[Token(Token = "0x2000081")]
	public struct PORT_INDEX
	{
		[Token(Token = "0x4000384")]
		public const ulong NONE = ulong.MaxValue;
	}
	[Token(Token = "0x2000082")]
	public struct CREATESOUNDEXINFO
	{
		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int cbsize;

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint length;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint fileoffset;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int numchannels;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int defaultfrequency;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public SOUND_FORMAT format;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public uint decodebuffersize;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int initialsubsound;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int numsubsounds;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IntPtr inclusionlist;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int inclusionlistnum;

		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public SOUND_PCMREAD_CALLBACK pcmreadcallback;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public SOUND_PCMSETPOS_CALLBACK pcmsetposcallback;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public SOUND_NONBLOCK_CALLBACK nonblockcallback;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public IntPtr dlsname;

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public IntPtr encryptionkey;

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public int maxpolyphony;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public IntPtr userdata;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public SOUND_TYPE suggestedsoundtype;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public FILE_OPEN_CALLBACK fileuseropen;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public FILE_CLOSE_CALLBACK fileuserclose;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public FILE_READ_CALLBACK fileuserread;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public FILE_SEEK_CALLBACK fileuserseek;

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public FILE_ASYNCREAD_CALLBACK fileuserasyncread;

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public FILE_ASYNCCANCEL_CALLBACK fileuserasynccancel;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public IntPtr fileuserdata;

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public int filebuffersize;

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public CHANNELORDER channelorder;

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public IntPtr initialsoundgroup;

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public uint initialseekposition;

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public TIMEUNIT initialseekpostype;

		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public int ignoresetfilesystem;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public uint audioqueuepolicy;

		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public uint minmidigranularity;

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public int nonblockthreadid;

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public IntPtr fsbguid;
	}
	[Token(Token = "0x2000083")]
	public struct REVERB_PROPERTIES
	{
		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float DecayTime;

		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float EarlyDelay;

		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float LateDelay;

		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float HFReference;

		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float HFDecayRatio;

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float Diffusion;

		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float Density;

		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float LowShelfFrequency;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float LowShelfGain;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float HighCut;

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float EarlyLateMix;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float WetLevel;

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x8F2880", Offset = "0x8F2880", VA = "0x8F2880")]
		public REVERB_PROPERTIES(float decayTime, float earlyDelay, float lateDelay, float hfReference, float hfDecayRatio, float diffusion, float density, float lowShelfFrequency, float lowShelfGain, float highCut, float earlyLateMix, float wetLevel)
		{
		}
	}
	[Token(Token = "0x2000084")]
	public class PRESET
	{
		[Token(Token = "0x6000223")]
		[Address(RVA = "0x150E1B8", Offset = "0x150E1B8", VA = "0x150E1B8")]
		public static REVERB_PROPERTIES OFF()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x150E208", Offset = "0x150E208", VA = "0x150E208")]
		public static REVERB_PROPERTIES GENERIC()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x150E22C", Offset = "0x150E22C", VA = "0x150E22C")]
		public static REVERB_PROPERTIES PADDEDCELL()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x150E250", Offset = "0x150E250", VA = "0x150E250")]
		public static REVERB_PROPERTIES ROOM()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x150E274", Offset = "0x150E274", VA = "0x150E274")]
		public static REVERB_PROPERTIES BATHROOM()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x150E298", Offset = "0x150E298", VA = "0x150E298")]
		public static REVERB_PROPERTIES LIVINGROOM()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x150E2BC", Offset = "0x150E2BC", VA = "0x150E2BC")]
		public static REVERB_PROPERTIES STONEROOM()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x150E2E0", Offset = "0x150E2E0", VA = "0x150E2E0")]
		public static REVERB_PROPERTIES AUDITORIUM()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x150E304", Offset = "0x150E304", VA = "0x150E304")]
		public static REVERB_PROPERTIES CONCERTHALL()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x150E328", Offset = "0x150E328", VA = "0x150E328")]
		public static REVERB_PROPERTIES CAVE()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x150E34C", Offset = "0x150E34C", VA = "0x150E34C")]
		public static REVERB_PROPERTIES ARENA()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x150E370", Offset = "0x150E370", VA = "0x150E370")]
		public static REVERB_PROPERTIES HANGAR()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x150E394", Offset = "0x150E394", VA = "0x150E394")]
		public static REVERB_PROPERTIES CARPETTEDHALLWAY()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x150E3B8", Offset = "0x150E3B8", VA = "0x150E3B8")]
		public static REVERB_PROPERTIES HALLWAY()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x150E3DC", Offset = "0x150E3DC", VA = "0x150E3DC")]
		public static REVERB_PROPERTIES STONECORRIDOR()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x150E400", Offset = "0x150E400", VA = "0x150E400")]
		public static REVERB_PROPERTIES ALLEY()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x150E424", Offset = "0x150E424", VA = "0x150E424")]
		public static REVERB_PROPERTIES FOREST()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x150E448", Offset = "0x150E448", VA = "0x150E448")]
		public static REVERB_PROPERTIES CITY()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x150E46C", Offset = "0x150E46C", VA = "0x150E46C")]
		public static REVERB_PROPERTIES MOUNTAINS()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x150E490", Offset = "0x150E490", VA = "0x150E490")]
		public static REVERB_PROPERTIES QUARRY()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x150E4B4", Offset = "0x150E4B4", VA = "0x150E4B4")]
		public static REVERB_PROPERTIES PLAIN()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x150E4D8", Offset = "0x150E4D8", VA = "0x150E4D8")]
		public static REVERB_PROPERTIES PARKINGLOT()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x150E4FC", Offset = "0x150E4FC", VA = "0x150E4FC")]
		public static REVERB_PROPERTIES SEWERPIPE()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x150E520", Offset = "0x150E520", VA = "0x150E520")]
		public static REVERB_PROPERTIES UNDERWATER()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x150E544", Offset = "0x150E544", VA = "0x150E544")]
		public PRESET()
		{
		}
	}
	[Token(Token = "0x2000085")]
	public struct ADVANCEDSETTINGS
	{
		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int cbSize;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int maxMPEGCodecs;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int maxADPCMCodecs;

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int maxXMACodecs;

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int maxVorbisCodecs;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int maxAT9Codecs;

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int maxFADPCMCodecs;

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int maxPCMCodecs;

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int ASIONumChannels;

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IntPtr ASIOChannelList;

		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IntPtr ASIOSpeakerList;

		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float vol0virtualvol;

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public uint defaultDecodeBufferSize;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ushort profilePort;

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public uint geometryMaxFadeTime;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float distanceFilterCenterFreq;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public int reverb3Dinstance;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public int DSPBufferPoolSize;

		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public uint stackSizeStream;

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public uint stackSizeNonBlocking;

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public uint stackSizeMixer;

		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public DSP_RESAMPLER resamplerMethod;

		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public uint commandQueueSize;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public uint randomSeed;
	}
	[Token(Token = "0x2000086")]
	[Flags]
	public enum DRIVER_STATE : uint
	{
		[Token(Token = "0x40003CE")]
		CONNECTED = 1u,
		[Token(Token = "0x40003CF")]
		DEFAULT = 2u
	}
	[Token(Token = "0x2000087")]
	public struct Factory
	{
		[Token(Token = "0x600023C")]
		[Address(RVA = "0x150C748", Offset = "0x150C748", VA = "0x150C748")]
		public static RESULT System_Create(out System system)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x600023D")]
		[Address(RVA = "0x150C74C", Offset = "0x150C74C", VA = "0x150C74C")]
		private static extern RESULT FMOD5_System_Create(out IntPtr system);
	}
	[Token(Token = "0x2000088")]
	public struct Memory
	{
		[Token(Token = "0x600023E")]
		[Address(RVA = "0x150E034", Offset = "0x150E034", VA = "0x150E034")]
		public static RESULT Initialize(IntPtr poolmem, int poollen, MEMORY_ALLOC_CALLBACK useralloc, MEMORY_REALLOC_CALLBACK userrealloc, MEMORY_FREE_CALLBACK userfree, MEMORY_TYPE memtypeflags = MEMORY_TYPE.ALL)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x150E118", Offset = "0x150E118", VA = "0x150E118")]
		public static RESULT GetStats(out int currentalloced, out int maxalloced, bool blocking = true)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000240")]
		[Address(RVA = "0x150E038", Offset = "0x150E038", VA = "0x150E038")]
		private static extern RESULT FMOD5_Memory_Initialize(IntPtr poolmem, int poollen, MEMORY_ALLOC_CALLBACK useralloc, MEMORY_REALLOC_CALLBACK userrealloc, MEMORY_FREE_CALLBACK userfree, MEMORY_TYPE memtypeflags);

		[PreserveSig]
		[Token(Token = "0x6000241")]
		[Address(RVA = "0x150E120", Offset = "0x150E120", VA = "0x150E120")]
		private static extern RESULT FMOD5_Memory_GetStats(out int currentalloced, out int maxalloced, bool blocking);
	}
	[Token(Token = "0x2000089")]
	public struct Debug
	{
		[Token(Token = "0x6000242")]
		[Address(RVA = "0x150A7E8", Offset = "0x150A7E8", VA = "0x150A7E8")]
		public static RESULT Initialize(DEBUG_FLAGS flags, DEBUG_MODE mode = DEBUG_MODE.TTY, [Optional] DEBUG_CALLBACK callback, [Optional] string filename)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000243")]
		[Address(RVA = "0x150ACF4", Offset = "0x150ACF4", VA = "0x150ACF4")]
		private static extern RESULT FMOD5_Debug_Initialize(DEBUG_FLAGS flags, DEBUG_MODE mode, DEBUG_CALLBACK callback, byte[] filename);
	}
	[Token(Token = "0x200008A")]
	public struct System
	{
		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x8D2CD4", Offset = "0x8D2CD4", VA = "0x8D2CD4")]
		public RESULT release()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x8D2CDC", Offset = "0x8D2CDC", VA = "0x8D2CDC")]
		public RESULT setOutput(OUTPUTTYPE output)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x8D2CE4", Offset = "0x8D2CE4", VA = "0x8D2CE4")]
		public RESULT getOutput(out OUTPUTTYPE output)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x8D2CEC", Offset = "0x8D2CEC", VA = "0x8D2CEC")]
		public RESULT getNumDrivers(out int numdrivers)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x8D2CF4", Offset = "0x8D2CF4", VA = "0x8D2CF4")]
		public RESULT getDriverInfo(int id, out string name, int namelen, out Guid guid, out int systemrate, out SPEAKERMODE speakermode, out int speakermodechannels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x8D2CFC", Offset = "0x8D2CFC", VA = "0x8D2CFC")]
		public RESULT getDriverInfo(int id, out Guid guid, out int systemrate, out SPEAKERMODE speakermode, out int speakermodechannels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x8D2D04", Offset = "0x8D2D04", VA = "0x8D2D04")]
		public RESULT setDriver(int driver)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x8D2D0C", Offset = "0x8D2D0C", VA = "0x8D2D0C")]
		public RESULT getDriver(out int driver)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x8D2D14", Offset = "0x8D2D14", VA = "0x8D2D14")]
		public RESULT setSoftwareChannels(int numsoftwarechannels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x8D2D1C", Offset = "0x8D2D1C", VA = "0x8D2D1C")]
		public RESULT getSoftwareChannels(out int numsoftwarechannels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x8D2D24", Offset = "0x8D2D24", VA = "0x8D2D24")]
		public RESULT setSoftwareFormat(int samplerate, SPEAKERMODE speakermode, int numrawspeakers)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x8D2D2C", Offset = "0x8D2D2C", VA = "0x8D2D2C")]
		public RESULT getSoftwareFormat(out int samplerate, out SPEAKERMODE speakermode, out int numrawspeakers)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x8D2D34", Offset = "0x8D2D34", VA = "0x8D2D34")]
		public RESULT setDSPBufferSize(uint bufferlength, int numbuffers)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x8D2D3C", Offset = "0x8D2D3C", VA = "0x8D2D3C")]
		public RESULT getDSPBufferSize(out uint bufferlength, out int numbuffers)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x8D2D44", Offset = "0x8D2D44", VA = "0x8D2D44")]
		public RESULT setFileSystem(FILE_OPEN_CALLBACK useropen, FILE_CLOSE_CALLBACK userclose, FILE_READ_CALLBACK userread, FILE_SEEK_CALLBACK userseek, FILE_ASYNCREAD_CALLBACK userasyncread, FILE_ASYNCCANCEL_CALLBACK userasynccancel, int blockalign)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x8D2D4C", Offset = "0x8D2D4C", VA = "0x8D2D4C")]
		public RESULT attachFileSystem(FILE_OPEN_CALLBACK useropen, FILE_CLOSE_CALLBACK userclose, FILE_READ_CALLBACK userread, FILE_SEEK_CALLBACK userseek)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x8D2D54", Offset = "0x8D2D54", VA = "0x8D2D54")]
		public RESULT setAdvancedSettings(ref ADVANCEDSETTINGS settings)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x8D2D5C", Offset = "0x8D2D5C", VA = "0x8D2D5C")]
		public RESULT getAdvancedSettings(ref ADVANCEDSETTINGS settings)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x8D2D64", Offset = "0x8D2D64", VA = "0x8D2D64")]
		public RESULT setCallback(SYSTEM_CALLBACK callback, SYSTEM_CALLBACK_TYPE callbackmask = SYSTEM_CALLBACK_TYPE.ALL)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x8D2D6C", Offset = "0x8D2D6C", VA = "0x8D2D6C")]
		public RESULT setPluginPath(string path)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x8D2D74", Offset = "0x8D2D74", VA = "0x8D2D74")]
		public RESULT loadPlugin(string filename, out uint handle, uint priority = 0u)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x8D2D7C", Offset = "0x8D2D7C", VA = "0x8D2D7C")]
		public RESULT unloadPlugin(uint handle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x8D2D84", Offset = "0x8D2D84", VA = "0x8D2D84")]
		public RESULT getNumNestedPlugins(uint handle, out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x8D2D8C", Offset = "0x8D2D8C", VA = "0x8D2D8C")]
		public RESULT getNestedPlugin(uint handle, int index, out uint nestedhandle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x8D2D94", Offset = "0x8D2D94", VA = "0x8D2D94")]
		public RESULT getNumPlugins(PLUGINTYPE plugintype, out int numplugins)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x8D2D9C", Offset = "0x8D2D9C", VA = "0x8D2D9C")]
		public RESULT getPluginHandle(PLUGINTYPE plugintype, int index, out uint handle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x8D2DA4", Offset = "0x8D2DA4", VA = "0x8D2DA4")]
		public RESULT getPluginInfo(uint handle, out PLUGINTYPE plugintype, out string name, int namelen, out uint version)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x8D2DAC", Offset = "0x8D2DAC", VA = "0x8D2DAC")]
		public RESULT getPluginInfo(uint handle, out PLUGINTYPE plugintype, out uint version)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x8D2DB4", Offset = "0x8D2DB4", VA = "0x8D2DB4")]
		public RESULT setOutputByPlugin(uint handle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x8D2DBC", Offset = "0x8D2DBC", VA = "0x8D2DBC")]
		public RESULT getOutputByPlugin(out uint handle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x8D2DC4", Offset = "0x8D2DC4", VA = "0x8D2DC4")]
		public RESULT createDSPByPlugin(uint handle, out DSP dsp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x8D2DCC", Offset = "0x8D2DCC", VA = "0x8D2DCC")]
		public RESULT getDSPInfoByPlugin(uint handle, out IntPtr description)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x8D2DD4", Offset = "0x8D2DD4", VA = "0x8D2DD4")]
		public RESULT registerDSP(ref DSP_DESCRIPTION description, out uint handle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x8D2DDC", Offset = "0x8D2DDC", VA = "0x8D2DDC")]
		public RESULT init(int maxchannels, INITFLAGS flags, IntPtr extradriverdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x8D2DE4", Offset = "0x8D2DE4", VA = "0x8D2DE4")]
		public RESULT close()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x8D2DEC", Offset = "0x8D2DEC", VA = "0x8D2DEC")]
		public RESULT update()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x8D2DF4", Offset = "0x8D2DF4", VA = "0x8D2DF4")]
		public RESULT setSpeakerPosition(SPEAKER speaker, float x, float y, bool active)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x8D2E00", Offset = "0x8D2E00", VA = "0x8D2E00")]
		public RESULT getSpeakerPosition(SPEAKER speaker, out float x, out float y, out bool active)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x8D2E08", Offset = "0x8D2E08", VA = "0x8D2E08")]
		public RESULT setStreamBufferSize(uint filebuffersize, TIMEUNIT filebuffersizetype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x8D2E10", Offset = "0x8D2E10", VA = "0x8D2E10")]
		public RESULT getStreamBufferSize(out uint filebuffersize, out TIMEUNIT filebuffersizetype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x8D2E18", Offset = "0x8D2E18", VA = "0x8D2E18")]
		public RESULT set3DSettings(float dopplerscale, float distancefactor, float rolloffscale)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x8D2E20", Offset = "0x8D2E20", VA = "0x8D2E20")]
		public RESULT get3DSettings(out float dopplerscale, out float distancefactor, out float rolloffscale)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x8D2E28", Offset = "0x8D2E28", VA = "0x8D2E28")]
		public RESULT set3DNumListeners(int numlisteners)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x8D2E30", Offset = "0x8D2E30", VA = "0x8D2E30")]
		public RESULT get3DNumListeners(out int numlisteners)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x8D2E38", Offset = "0x8D2E38", VA = "0x8D2E38")]
		public RESULT set3DListenerAttributes(int listener, ref VECTOR pos, ref VECTOR vel, ref VECTOR forward, ref VECTOR up)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x8D2E40", Offset = "0x8D2E40", VA = "0x8D2E40")]
		public RESULT get3DListenerAttributes(int listener, out VECTOR pos, out VECTOR vel, out VECTOR forward, out VECTOR up)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x8D2E48", Offset = "0x8D2E48", VA = "0x8D2E48")]
		public RESULT set3DRolloffCallback(CB_3D_ROLLOFF_CALLBACK callback)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x8D2E50", Offset = "0x8D2E50", VA = "0x8D2E50")]
		public RESULT mixerSuspend()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x8D2E58", Offset = "0x8D2E58", VA = "0x8D2E58")]
		public RESULT mixerResume()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x8D2E60", Offset = "0x8D2E60", VA = "0x8D2E60")]
		public RESULT getDefaultMixMatrix(SPEAKERMODE sourcespeakermode, SPEAKERMODE targetspeakermode, float[] matrix, int matrixhop)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x8D2E68", Offset = "0x8D2E68", VA = "0x8D2E68")]
		public RESULT getSpeakerModeChannels(SPEAKERMODE mode, out int channels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x8D2E70", Offset = "0x8D2E70", VA = "0x8D2E70")]
		public RESULT getVersion(out uint version)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x8D2E78", Offset = "0x8D2E78", VA = "0x8D2E78")]
		public RESULT getOutputHandle(out IntPtr handle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x8D2E80", Offset = "0x8D2E80", VA = "0x8D2E80")]
		public RESULT getChannelsPlaying(out int channels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x8D2E88", Offset = "0x8D2E88", VA = "0x8D2E88")]
		public RESULT getChannelsPlaying(out int channels, out int realchannels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x8D2E90", Offset = "0x8D2E90", VA = "0x8D2E90")]
		public RESULT getCPUUsage(out float dsp, out float stream, out float geometry, out float update, out float total)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x8D2E98", Offset = "0x8D2E98", VA = "0x8D2E98")]
		public RESULT getFileUsage(out long sampleBytesRead, out long streamBytesRead, out long otherBytesRead)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x8D2EA0", Offset = "0x8D2EA0", VA = "0x8D2EA0")]
		public RESULT createSound(string name, MODE mode, ref CREATESOUNDEXINFO exinfo, out Sound sound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x8D2EA8", Offset = "0x8D2EA8", VA = "0x8D2EA8")]
		public RESULT createSound(byte[] data, MODE mode, ref CREATESOUNDEXINFO exinfo, out Sound sound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x8D2EB0", Offset = "0x8D2EB0", VA = "0x8D2EB0")]
		public RESULT createSound(IntPtr name_or_data, MODE mode, ref CREATESOUNDEXINFO exinfo, out Sound sound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x8D2EB8", Offset = "0x8D2EB8", VA = "0x8D2EB8")]
		public RESULT createSound(string name, MODE mode, out Sound sound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x8D2EC0", Offset = "0x8D2EC0", VA = "0x8D2EC0")]
		public RESULT createStream(string name, MODE mode, ref CREATESOUNDEXINFO exinfo, out Sound sound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x8D2EC8", Offset = "0x8D2EC8", VA = "0x8D2EC8")]
		public RESULT createStream(byte[] data, MODE mode, ref CREATESOUNDEXINFO exinfo, out Sound sound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x8D2ED0", Offset = "0x8D2ED0", VA = "0x8D2ED0")]
		public RESULT createStream(IntPtr name_or_data, MODE mode, ref CREATESOUNDEXINFO exinfo, out Sound sound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x8D2ED8", Offset = "0x8D2ED8", VA = "0x8D2ED8")]
		public RESULT createStream(string name, MODE mode, out Sound sound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x8D2EE0", Offset = "0x8D2EE0", VA = "0x8D2EE0")]
		public RESULT createDSP(ref DSP_DESCRIPTION description, out DSP dsp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x8D2EE8", Offset = "0x8D2EE8", VA = "0x8D2EE8")]
		public RESULT createDSPByType(DSP_TYPE type, out DSP dsp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x8D2EF0", Offset = "0x8D2EF0", VA = "0x8D2EF0")]
		public RESULT createChannelGroup(string name, out ChannelGroup channelgroup)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x8D2EF8", Offset = "0x8D2EF8", VA = "0x8D2EF8")]
		public RESULT createSoundGroup(string name, out SoundGroup soundgroup)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x8D2F00", Offset = "0x8D2F00", VA = "0x8D2F00")]
		public RESULT createReverb3D(out Reverb3D reverb)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x8D2F08", Offset = "0x8D2F08", VA = "0x8D2F08")]
		public RESULT playSound(Sound sound, ChannelGroup channelgroup, bool paused, out Channel channel)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x8D2F14", Offset = "0x8D2F14", VA = "0x8D2F14")]
		public RESULT playDSP(DSP dsp, ChannelGroup channelgroup, bool paused, out Channel channel)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x8D2F20", Offset = "0x8D2F20", VA = "0x8D2F20")]
		public RESULT getChannel(int channelid, out Channel channel)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x8D2F28", Offset = "0x8D2F28", VA = "0x8D2F28")]
		public RESULT getMasterChannelGroup(out ChannelGroup channelgroup)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x8D2F30", Offset = "0x8D2F30", VA = "0x8D2F30")]
		public RESULT getMasterSoundGroup(out SoundGroup soundgroup)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x8D2F38", Offset = "0x8D2F38", VA = "0x8D2F38")]
		public RESULT attachChannelGroupToPort(uint portType, ulong portIndex, ChannelGroup channelgroup, bool passThru = false)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x8D2F44", Offset = "0x8D2F44", VA = "0x8D2F44")]
		public RESULT detachChannelGroupFromPort(ChannelGroup channelgroup)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x8D2F4C", Offset = "0x8D2F4C", VA = "0x8D2F4C")]
		public RESULT setReverbProperties(int instance, ref REVERB_PROPERTIES prop)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x8D2F54", Offset = "0x8D2F54", VA = "0x8D2F54")]
		public RESULT getReverbProperties(int instance, out REVERB_PROPERTIES prop)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x8D2F5C", Offset = "0x8D2F5C", VA = "0x8D2F5C")]
		public RESULT lockDSP()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x8D2F64", Offset = "0x8D2F64", VA = "0x8D2F64")]
		public RESULT unlockDSP()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x8D2F6C", Offset = "0x8D2F6C", VA = "0x8D2F6C")]
		public RESULT getRecordNumDrivers(out int numdrivers, out int numconnected)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x8D2F74", Offset = "0x8D2F74", VA = "0x8D2F74")]
		public RESULT getRecordDriverInfo(int id, out string name, int namelen, out Guid guid, out int systemrate, out SPEAKERMODE speakermode, out int speakermodechannels, out DRIVER_STATE state)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x8D2F84", Offset = "0x8D2F84", VA = "0x8D2F84")]
		public RESULT getRecordDriverInfo(int id, out Guid guid, out int systemrate, out SPEAKERMODE speakermode, out int speakermodechannels, out DRIVER_STATE state)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x8D2F8C", Offset = "0x8D2F8C", VA = "0x8D2F8C")]
		public RESULT getRecordPosition(int id, out uint position)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x8D2F94", Offset = "0x8D2F94", VA = "0x8D2F94")]
		public RESULT recordStart(int id, Sound sound, bool loop)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x8D2FA0", Offset = "0x8D2FA0", VA = "0x8D2FA0")]
		public RESULT recordStop(int id)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x8D2FA8", Offset = "0x8D2FA8", VA = "0x8D2FA8")]
		public RESULT isRecording(int id, out bool recording)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x8D2FB0", Offset = "0x8D2FB0", VA = "0x8D2FB0")]
		public RESULT createGeometry(int maxpolygons, int maxvertices, out Geometry geometry)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x8D2FB8", Offset = "0x8D2FB8", VA = "0x8D2FB8")]
		public RESULT setGeometrySettings(float maxworldsize)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x8D2FC0", Offset = "0x8D2FC0", VA = "0x8D2FC0")]
		public RESULT getGeometrySettings(out float maxworldsize)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x8D2FC8", Offset = "0x8D2FC8", VA = "0x8D2FC8")]
		public RESULT loadGeometry(IntPtr data, int datasize, out Geometry geometry)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x8D2FD0", Offset = "0x8D2FD0", VA = "0x8D2FD0")]
		public RESULT getGeometryOcclusion(ref VECTOR listener, ref VECTOR source, out float direct, out float reverb)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x8D2FD8", Offset = "0x8D2FD8", VA = "0x8D2FD8")]
		public RESULT setNetworkProxy(string proxy)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x8D2FE0", Offset = "0x8D2FE0", VA = "0x8D2FE0")]
		public RESULT getNetworkProxy(out string proxy, int proxylen)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x8D2FE8", Offset = "0x8D2FE8", VA = "0x8D2FE8")]
		public RESULT setNetworkTimeout(int timeout)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x8D2FF0", Offset = "0x8D2FF0", VA = "0x8D2FF0")]
		public RESULT getNetworkTimeout(out int timeout)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x8D2FF8", Offset = "0x8D2FF8", VA = "0x8D2FF8")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x8D3000", Offset = "0x8D3000", VA = "0x8D3000")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x60002A7")]
		[Address(RVA = "0xCF11B0", Offset = "0xCF11B0", VA = "0xCF11B0")]
		private static extern RESULT FMOD5_System_Release(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x60002A8")]
		[Address(RVA = "0xCF1238", Offset = "0xCF1238", VA = "0xCF1238")]
		private static extern RESULT FMOD5_System_SetOutput(IntPtr system, OUTPUTTYPE output);

		[PreserveSig]
		[Token(Token = "0x60002A9")]
		[Address(RVA = "0xCF12D0", Offset = "0xCF12D0", VA = "0xCF12D0")]
		private static extern RESULT FMOD5_System_GetOutput(IntPtr system, out OUTPUTTYPE output);

		[PreserveSig]
		[Token(Token = "0x60002AA")]
		[Address(RVA = "0xCF1368", Offset = "0xCF1368", VA = "0xCF1368")]
		private static extern RESULT FMOD5_System_GetNumDrivers(IntPtr system, out int numdrivers);

		[PreserveSig]
		[Token(Token = "0x60002AB")]
		[Address(RVA = "0xCF15EC", Offset = "0xCF15EC", VA = "0xCF15EC")]
		private static extern RESULT FMOD5_System_GetDriverInfo(IntPtr system, int id, IntPtr name, int namelen, out Guid guid, out int systemrate, out SPEAKERMODE speakermode, out int speakermodechannels);

		[PreserveSig]
		[Token(Token = "0x60002AC")]
		[Address(RVA = "0xCF1764", Offset = "0xCF1764", VA = "0xCF1764")]
		private static extern RESULT FMOD5_System_SetDriver(IntPtr system, int driver);

		[PreserveSig]
		[Token(Token = "0x60002AD")]
		[Address(RVA = "0xCF17FC", Offset = "0xCF17FC", VA = "0xCF17FC")]
		private static extern RESULT FMOD5_System_GetDriver(IntPtr system, out int driver);

		[PreserveSig]
		[Token(Token = "0x60002AE")]
		[Address(RVA = "0xCF1894", Offset = "0xCF1894", VA = "0xCF1894")]
		private static extern RESULT FMOD5_System_SetSoftwareChannels(IntPtr system, int numsoftwarechannels);

		[PreserveSig]
		[Token(Token = "0x60002AF")]
		[Address(RVA = "0xCF192C", Offset = "0xCF192C", VA = "0xCF192C")]
		private static extern RESULT FMOD5_System_GetSoftwareChannels(IntPtr system, out int numsoftwarechannels);

		[PreserveSig]
		[Token(Token = "0x60002B0")]
		[Address(RVA = "0xCF19C4", Offset = "0xCF19C4", VA = "0xCF19C4")]
		private static extern RESULT FMOD5_System_SetSoftwareFormat(IntPtr system, int samplerate, SPEAKERMODE speakermode, int numrawspeakers);

		[PreserveSig]
		[Token(Token = "0x60002B1")]
		[Address(RVA = "0xCF1A74", Offset = "0xCF1A74", VA = "0xCF1A74")]
		private static extern RESULT FMOD5_System_GetSoftwareFormat(IntPtr system, out int samplerate, out SPEAKERMODE speakermode, out int numrawspeakers);

		[PreserveSig]
		[Token(Token = "0x60002B2")]
		[Address(RVA = "0xCF1B24", Offset = "0xCF1B24", VA = "0xCF1B24")]
		private static extern RESULT FMOD5_System_SetDSPBufferSize(IntPtr system, uint bufferlength, int numbuffers);

		[PreserveSig]
		[Token(Token = "0x60002B3")]
		[Address(RVA = "0xCF1BC4", Offset = "0xCF1BC4", VA = "0xCF1BC4")]
		private static extern RESULT FMOD5_System_GetDSPBufferSize(IntPtr system, out uint bufferlength, out int numbuffers);

		[PreserveSig]
		[Token(Token = "0x60002B4")]
		[Address(RVA = "0xCF1C64", Offset = "0xCF1C64", VA = "0xCF1C64")]
		private static extern RESULT FMOD5_System_SetFileSystem(IntPtr system, FILE_OPEN_CALLBACK useropen, FILE_CLOSE_CALLBACK userclose, FILE_READ_CALLBACK userread, FILE_SEEK_CALLBACK userseek, FILE_ASYNCREAD_CALLBACK userasyncread, FILE_ASYNCCANCEL_CALLBACK userasynccancel, int blockalign);

		[PreserveSig]
		[Token(Token = "0x60002B5")]
		[Address(RVA = "0xCF1D88", Offset = "0xCF1D88", VA = "0xCF1D88")]
		private static extern RESULT FMOD5_System_AttachFileSystem(IntPtr system, FILE_OPEN_CALLBACK useropen, FILE_CLOSE_CALLBACK userclose, FILE_READ_CALLBACK userread, FILE_SEEK_CALLBACK userseek);

		[PreserveSig]
		[Token(Token = "0x60002B6")]
		[Address(RVA = "0xCF1F20", Offset = "0xCF1F20", VA = "0xCF1F20")]
		private static extern RESULT FMOD5_System_SetAdvancedSettings(IntPtr system, ref ADVANCEDSETTINGS settings);

		[PreserveSig]
		[Token(Token = "0x60002B7")]
		[Address(RVA = "0xCF206C", Offset = "0xCF206C", VA = "0xCF206C")]
		private static extern RESULT FMOD5_System_GetAdvancedSettings(IntPtr system, ref ADVANCEDSETTINGS settings);

		[PreserveSig]
		[Token(Token = "0x60002B8")]
		[Address(RVA = "0xCF2104", Offset = "0xCF2104", VA = "0xCF2104")]
		private static extern RESULT FMOD5_System_SetCallback(IntPtr system, SYSTEM_CALLBACK callback, SYSTEM_CALLBACK_TYPE callbackmask);

		[PreserveSig]
		[Token(Token = "0x60002B9")]
		[Address(RVA = "0xCF22F4", Offset = "0xCF22F4", VA = "0xCF22F4")]
		private static extern RESULT FMOD5_System_SetPluginPath(IntPtr system, byte[] path);

		[PreserveSig]
		[Token(Token = "0x60002BA")]
		[Address(RVA = "0xCF24F4", Offset = "0xCF24F4", VA = "0xCF24F4")]
		private static extern RESULT FMOD5_System_LoadPlugin(IntPtr system, byte[] filename, out uint handle, uint priority);

		[PreserveSig]
		[Token(Token = "0x60002BB")]
		[Address(RVA = "0xCF25AC", Offset = "0xCF25AC", VA = "0xCF25AC")]
		private static extern RESULT FMOD5_System_UnloadPlugin(IntPtr system, uint handle);

		[PreserveSig]
		[Token(Token = "0x60002BC")]
		[Address(RVA = "0xCF2644", Offset = "0xCF2644", VA = "0xCF2644")]
		private static extern RESULT FMOD5_System_GetNumNestedPlugins(IntPtr system, uint handle, out int count);

		[PreserveSig]
		[Token(Token = "0x60002BD")]
		[Address(RVA = "0xCF26E4", Offset = "0xCF26E4", VA = "0xCF26E4")]
		private static extern RESULT FMOD5_System_GetNestedPlugin(IntPtr system, uint handle, int index, out uint nestedhandle);

		[PreserveSig]
		[Token(Token = "0x60002BE")]
		[Address(RVA = "0xCF2794", Offset = "0xCF2794", VA = "0xCF2794")]
		private static extern RESULT FMOD5_System_GetNumPlugins(IntPtr system, PLUGINTYPE plugintype, out int numplugins);

		[PreserveSig]
		[Token(Token = "0x60002BF")]
		[Address(RVA = "0xCF2834", Offset = "0xCF2834", VA = "0xCF2834")]
		private static extern RESULT FMOD5_System_GetPluginHandle(IntPtr system, PLUGINTYPE plugintype, int index, out uint handle);

		[PreserveSig]
		[Token(Token = "0x60002C0")]
		[Address(RVA = "0xCF2AB0", Offset = "0xCF2AB0", VA = "0xCF2AB0")]
		private static extern RESULT FMOD5_System_GetPluginInfo(IntPtr system, uint handle, out PLUGINTYPE plugintype, IntPtr name, int namelen, out uint version);

		[PreserveSig]
		[Token(Token = "0x60002C1")]
		[Address(RVA = "0xCF2BEC", Offset = "0xCF2BEC", VA = "0xCF2BEC")]
		private static extern RESULT FMOD5_System_SetOutputByPlugin(IntPtr system, uint handle);

		[PreserveSig]
		[Token(Token = "0x60002C2")]
		[Address(RVA = "0xCF2C84", Offset = "0xCF2C84", VA = "0xCF2C84")]
		private static extern RESULT FMOD5_System_GetOutputByPlugin(IntPtr system, out uint handle);

		[PreserveSig]
		[Token(Token = "0x60002C3")]
		[Address(RVA = "0xCF2D1C", Offset = "0xCF2D1C", VA = "0xCF2D1C")]
		private static extern RESULT FMOD5_System_CreateDSPByPlugin(IntPtr system, uint handle, out IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x60002C4")]
		[Address(RVA = "0xCF2DBC", Offset = "0xCF2DBC", VA = "0xCF2DBC")]
		private static extern RESULT FMOD5_System_GetDSPInfoByPlugin(IntPtr system, uint handle, out IntPtr description);

		[PreserveSig]
		[Token(Token = "0x60002C5")]
		[Address(RVA = "0xCF2E5C", Offset = "0xCF2E5C", VA = "0xCF2E5C")]
		private static extern RESULT FMOD5_System_RegisterDSP(IntPtr system, ref DSP_DESCRIPTION description, out uint handle);

		[PreserveSig]
		[Token(Token = "0x60002C6")]
		[Address(RVA = "0xCF2F58", Offset = "0xCF2F58", VA = "0xCF2F58")]
		private static extern RESULT FMOD5_System_Init(IntPtr system, int maxchannels, INITFLAGS flags, IntPtr extradriverdata);

		[PreserveSig]
		[Token(Token = "0x60002C7")]
		[Address(RVA = "0xCF3008", Offset = "0xCF3008", VA = "0xCF3008")]
		private static extern RESULT FMOD5_System_Close(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x60002C8")]
		[Address(RVA = "0xCF3090", Offset = "0xCF3090", VA = "0xCF3090")]
		private static extern RESULT FMOD5_System_Update(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x60002C9")]
		[Address(RVA = "0xCF311C", Offset = "0xCF311C", VA = "0xCF311C")]
		private static extern RESULT FMOD5_System_SetSpeakerPosition(IntPtr system, SPEAKER speaker, float x, float y, bool active);

		[PreserveSig]
		[Token(Token = "0x60002CA")]
		[Address(RVA = "0xCF31D4", Offset = "0xCF31D4", VA = "0xCF31D4")]
		private static extern RESULT FMOD5_System_GetSpeakerPosition(IntPtr system, SPEAKER speaker, out float x, out float y, out bool active);

		[PreserveSig]
		[Token(Token = "0x60002CB")]
		[Address(RVA = "0xCF32A0", Offset = "0xCF32A0", VA = "0xCF32A0")]
		private static extern RESULT FMOD5_System_SetStreamBufferSize(IntPtr system, uint filebuffersize, TIMEUNIT filebuffersizetype);

		[PreserveSig]
		[Token(Token = "0x60002CC")]
		[Address(RVA = "0xCF3340", Offset = "0xCF3340", VA = "0xCF3340")]
		private static extern RESULT FMOD5_System_GetStreamBufferSize(IntPtr system, out uint filebuffersize, out TIMEUNIT filebuffersizetype);

		[PreserveSig]
		[Token(Token = "0x60002CD")]
		[Address(RVA = "0xCF33E0", Offset = "0xCF33E0", VA = "0xCF33E0")]
		private static extern RESULT FMOD5_System_Set3DSettings(IntPtr system, float dopplerscale, float distancefactor, float rolloffscale);

		[PreserveSig]
		[Token(Token = "0x60002CE")]
		[Address(RVA = "0xCF3490", Offset = "0xCF3490", VA = "0xCF3490")]
		private static extern RESULT FMOD5_System_Get3DSettings(IntPtr system, out float dopplerscale, out float distancefactor, out float rolloffscale);

		[PreserveSig]
		[Token(Token = "0x60002CF")]
		[Address(RVA = "0xCF3540", Offset = "0xCF3540", VA = "0xCF3540")]
		private static extern RESULT FMOD5_System_Set3DNumListeners(IntPtr system, int numlisteners);

		[PreserveSig]
		[Token(Token = "0x60002D0")]
		[Address(RVA = "0xCF35D8", Offset = "0xCF35D8", VA = "0xCF35D8")]
		private static extern RESULT FMOD5_System_Get3DNumListeners(IntPtr system, out int numlisteners);

		[PreserveSig]
		[Token(Token = "0x60002D1")]
		[Address(RVA = "0xCF3670", Offset = "0xCF3670", VA = "0xCF3670")]
		private static extern RESULT FMOD5_System_Set3DListenerAttributes(IntPtr system, int listener, ref VECTOR pos, ref VECTOR vel, ref VECTOR forward, ref VECTOR up);

		[PreserveSig]
		[Token(Token = "0x60002D2")]
		[Address(RVA = "0xCF3738", Offset = "0xCF3738", VA = "0xCF3738")]
		private static extern RESULT FMOD5_System_Get3DListenerAttributes(IntPtr system, int listener, out VECTOR pos, out VECTOR vel, out VECTOR forward, out VECTOR up);

		[PreserveSig]
		[Token(Token = "0x60002D3")]
		[Address(RVA = "0xCF3800", Offset = "0xCF3800", VA = "0xCF3800")]
		private static extern RESULT FMOD5_System_Set3DRolloffCallback(IntPtr system, CB_3D_ROLLOFF_CALLBACK callback);

		[PreserveSig]
		[Token(Token = "0x60002D4")]
		[Address(RVA = "0xCF38A0", Offset = "0xCF38A0", VA = "0xCF38A0")]
		private static extern RESULT FMOD5_System_MixerSuspend(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x60002D5")]
		[Address(RVA = "0xCF3928", Offset = "0xCF3928", VA = "0xCF3928")]
		private static extern RESULT FMOD5_System_MixerResume(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x60002D6")]
		[Address(RVA = "0xCF39B0", Offset = "0xCF39B0", VA = "0xCF39B0")]
		private static extern RESULT FMOD5_System_GetDefaultMixMatrix(IntPtr system, SPEAKERMODE sourcespeakermode, SPEAKERMODE targetspeakermode, float[] matrix, int matrixhop);

		[PreserveSig]
		[Token(Token = "0x60002D7")]
		[Address(RVA = "0xCF3A70", Offset = "0xCF3A70", VA = "0xCF3A70")]
		private static extern RESULT FMOD5_System_GetSpeakerModeChannels(IntPtr system, SPEAKERMODE mode, out int channels);

		[PreserveSig]
		[Token(Token = "0x60002D8")]
		[Address(RVA = "0xCF3B10", Offset = "0xCF3B10", VA = "0xCF3B10")]
		private static extern RESULT FMOD5_System_GetVersion(IntPtr system, out uint version);

		[PreserveSig]
		[Token(Token = "0x60002D9")]
		[Address(RVA = "0xCF3BA8", Offset = "0xCF3BA8", VA = "0xCF3BA8")]
		private static extern RESULT FMOD5_System_GetOutputHandle(IntPtr system, out IntPtr handle);

		[PreserveSig]
		[Token(Token = "0x60002DA")]
		[Address(RVA = "0xCF3C90", Offset = "0xCF3C90", VA = "0xCF3C90")]
		private static extern RESULT FMOD5_System_GetChannelsPlaying(IntPtr system, out int channels, IntPtr zero);

		[PreserveSig]
		[Token(Token = "0x60002DB")]
		[Address(RVA = "0xCF3D30", Offset = "0xCF3D30", VA = "0xCF3D30")]
		private static extern RESULT FMOD5_System_GetChannelsPlaying(IntPtr system, out int channels, out int realchannels);

		[PreserveSig]
		[Token(Token = "0x60002DC")]
		[Address(RVA = "0xCF3DD0", Offset = "0xCF3DD0", VA = "0xCF3DD0")]
		private static extern RESULT FMOD5_System_GetCPUUsage(IntPtr system, out float dsp, out float stream, out float geometry, out float update, out float total);

		[PreserveSig]
		[Token(Token = "0x60002DD")]
		[Address(RVA = "0xCF3E98", Offset = "0xCF3E98", VA = "0xCF3E98")]
		private static extern RESULT FMOD5_System_GetFileUsage(IntPtr system, out long sampleBytesRead, out long streamBytesRead, out long otherBytesRead);

		[PreserveSig]
		[Token(Token = "0x60002DE")]
		[Address(RVA = "0xCF40B0", Offset = "0xCF40B0", VA = "0xCF40B0")]
		private static extern RESULT FMOD5_System_CreateSound(IntPtr system, byte[] name_or_data, MODE mode, ref CREATESOUNDEXINFO exinfo, out IntPtr sound);

		[PreserveSig]
		[Token(Token = "0x60002DF")]
		[Address(RVA = "0xCF41DC", Offset = "0xCF41DC", VA = "0xCF41DC")]
		private static extern RESULT FMOD5_System_CreateSound(IntPtr system, IntPtr name_or_data, MODE mode, ref CREATESOUNDEXINFO exinfo, out IntPtr sound);

		[PreserveSig]
		[Token(Token = "0x60002E0")]
		[Address(RVA = "0xCF4544", Offset = "0xCF4544", VA = "0xCF4544")]
		private static extern RESULT FMOD5_System_CreateStream(IntPtr system, byte[] name_or_data, MODE mode, ref CREATESOUNDEXINFO exinfo, out IntPtr sound);

		[PreserveSig]
		[Token(Token = "0x60002E1")]
		[Address(RVA = "0xCF4670", Offset = "0xCF4670", VA = "0xCF4670")]
		private static extern RESULT FMOD5_System_CreateStream(IntPtr system, IntPtr name_or_data, MODE mode, ref CREATESOUNDEXINFO exinfo, out IntPtr sound);

		[PreserveSig]
		[Token(Token = "0x60002E2")]
		[Address(RVA = "0xCF4870", Offset = "0xCF4870", VA = "0xCF4870")]
		private static extern RESULT FMOD5_System_CreateDSP(IntPtr system, ref DSP_DESCRIPTION description, out IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x60002E3")]
		[Address(RVA = "0xCF4970", Offset = "0xCF4970", VA = "0xCF4970")]
		private static extern RESULT FMOD5_System_CreateDSPByType(IntPtr system, DSP_TYPE type, out IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x60002E4")]
		[Address(RVA = "0xCF4B60", Offset = "0xCF4B60", VA = "0xCF4B60")]
		private static extern RESULT FMOD5_System_CreateChannelGroup(IntPtr system, byte[] name, out IntPtr channelgroup);

		[PreserveSig]
		[Token(Token = "0x60002E5")]
		[Address(RVA = "0xCF4D58", Offset = "0xCF4D58", VA = "0xCF4D58")]
		private static extern RESULT FMOD5_System_CreateSoundGroup(IntPtr system, byte[] name, out IntPtr soundgroup);

		[PreserveSig]
		[Token(Token = "0x60002E6")]
		[Address(RVA = "0xCF4E00", Offset = "0xCF4E00", VA = "0xCF4E00")]
		private static extern RESULT FMOD5_System_CreateReverb3D(IntPtr system, out IntPtr reverb);

		[PreserveSig]
		[Token(Token = "0x60002E7")]
		[Address(RVA = "0xCF4E9C", Offset = "0xCF4E9C", VA = "0xCF4E9C")]
		private static extern RESULT FMOD5_System_PlaySound(IntPtr system, IntPtr sound, IntPtr channelgroup, bool paused, out IntPtr channel);

		[PreserveSig]
		[Token(Token = "0x60002E8")]
		[Address(RVA = "0xCF4F58", Offset = "0xCF4F58", VA = "0xCF4F58")]
		private static extern RESULT FMOD5_System_PlayDSP(IntPtr system, IntPtr dsp, IntPtr channelgroup, bool paused, out IntPtr channel);

		[PreserveSig]
		[Token(Token = "0x60002E9")]
		[Address(RVA = "0xCF5010", Offset = "0xCF5010", VA = "0xCF5010")]
		private static extern RESULT FMOD5_System_GetChannel(IntPtr system, int channelid, out IntPtr channel);

		[PreserveSig]
		[Token(Token = "0x60002EA")]
		[Address(RVA = "0xCF50B0", Offset = "0xCF50B0", VA = "0xCF50B0")]
		private static extern RESULT FMOD5_System_GetMasterChannelGroup(IntPtr system, out IntPtr channelgroup);

		[PreserveSig]
		[Token(Token = "0x60002EB")]
		[Address(RVA = "0xCF5148", Offset = "0xCF5148", VA = "0xCF5148")]
		private static extern RESULT FMOD5_System_GetMasterSoundGroup(IntPtr system, out IntPtr soundgroup);

		[PreserveSig]
		[Token(Token = "0x60002EC")]
		[Address(RVA = "0xCF51E4", Offset = "0xCF51E4", VA = "0xCF51E4")]
		private static extern RESULT FMOD5_System_AttachChannelGroupToPort(IntPtr system, uint portType, ulong portIndex, IntPtr channelgroup, bool passThru);

		[PreserveSig]
		[Token(Token = "0x60002ED")]
		[Address(RVA = "0xCF529C", Offset = "0xCF529C", VA = "0xCF529C")]
		private static extern RESULT FMOD5_System_DetachChannelGroupFromPort(IntPtr system, IntPtr channelgroup);

		[PreserveSig]
		[Token(Token = "0x60002EE")]
		[Address(RVA = "0xCF5334", Offset = "0xCF5334", VA = "0xCF5334")]
		private static extern RESULT FMOD5_System_SetReverbProperties(IntPtr system, int instance, ref REVERB_PROPERTIES prop);

		[PreserveSig]
		[Token(Token = "0x60002EF")]
		[Address(RVA = "0xCF53D4", Offset = "0xCF53D4", VA = "0xCF53D4")]
		private static extern RESULT FMOD5_System_GetReverbProperties(IntPtr system, int instance, out REVERB_PROPERTIES prop);

		[PreserveSig]
		[Token(Token = "0x60002F0")]
		[Address(RVA = "0xCF5474", Offset = "0xCF5474", VA = "0xCF5474")]
		private static extern RESULT FMOD5_System_LockDSP(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x60002F1")]
		[Address(RVA = "0xCF54FC", Offset = "0xCF54FC", VA = "0xCF54FC")]
		private static extern RESULT FMOD5_System_UnlockDSP(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x60002F2")]
		[Address(RVA = "0xCF5584", Offset = "0xCF5584", VA = "0xCF5584")]
		private static extern RESULT FMOD5_System_GetRecordNumDrivers(IntPtr system, out int numdrivers, out int numconnected);

		[PreserveSig]
		[Token(Token = "0x60002F3")]
		[Address(RVA = "0xCF5818", Offset = "0xCF5818", VA = "0xCF5818")]
		private static extern RESULT FMOD5_System_GetRecordDriverInfo(IntPtr system, int id, IntPtr name, int namelen, out Guid guid, out int systemrate, out SPEAKERMODE speakermode, out int speakermodechannels, out DRIVER_STATE state);

		[PreserveSig]
		[Token(Token = "0x60002F4")]
		[Address(RVA = "0xCF59A0", Offset = "0xCF59A0", VA = "0xCF59A0")]
		private static extern RESULT FMOD5_System_GetRecordPosition(IntPtr system, int id, out uint position);

		[PreserveSig]
		[Token(Token = "0x60002F5")]
		[Address(RVA = "0xCF5A44", Offset = "0xCF5A44", VA = "0xCF5A44")]
		private static extern RESULT FMOD5_System_RecordStart(IntPtr system, int id, IntPtr sound, bool loop);

		[PreserveSig]
		[Token(Token = "0x60002F6")]
		[Address(RVA = "0xCF5AF0", Offset = "0xCF5AF0", VA = "0xCF5AF0")]
		private static extern RESULT FMOD5_System_RecordStop(IntPtr system, int id);

		[PreserveSig]
		[Token(Token = "0x60002F7")]
		[Address(RVA = "0xCF5B88", Offset = "0xCF5B88", VA = "0xCF5B88")]
		private static extern RESULT FMOD5_System_IsRecording(IntPtr system, int id, out bool recording);

		[PreserveSig]
		[Token(Token = "0x60002F8")]
		[Address(RVA = "0xCF5C3C", Offset = "0xCF5C3C", VA = "0xCF5C3C")]
		private static extern RESULT FMOD5_System_CreateGeometry(IntPtr system, int maxpolygons, int maxvertices, out IntPtr geometry);

		[PreserveSig]
		[Token(Token = "0x60002F9")]
		[Address(RVA = "0xCF5CEC", Offset = "0xCF5CEC", VA = "0xCF5CEC")]
		private static extern RESULT FMOD5_System_SetGeometrySettings(IntPtr system, float maxworldsize);

		[PreserveSig]
		[Token(Token = "0x60002FA")]
		[Address(RVA = "0xCF5D84", Offset = "0xCF5D84", VA = "0xCF5D84")]
		private static extern RESULT FMOD5_System_GetGeometrySettings(IntPtr system, out float maxworldsize);

		[PreserveSig]
		[Token(Token = "0x60002FB")]
		[Address(RVA = "0xCF5E1C", Offset = "0xCF5E1C", VA = "0xCF5E1C")]
		private static extern RESULT FMOD5_System_LoadGeometry(IntPtr system, IntPtr data, int datasize, out IntPtr geometry);

		[PreserveSig]
		[Token(Token = "0x60002FC")]
		[Address(RVA = "0xCF5ECC", Offset = "0xCF5ECC", VA = "0xCF5ECC")]
		private static extern RESULT FMOD5_System_GetGeometryOcclusion(IntPtr system, ref VECTOR listener, ref VECTOR source, out float direct, out float reverb);

		[PreserveSig]
		[Token(Token = "0x60002FD")]
		[Address(RVA = "0xCF60CC", Offset = "0xCF60CC", VA = "0xCF60CC")]
		private static extern RESULT FMOD5_System_SetNetworkProxy(IntPtr system, byte[] proxy);

		[PreserveSig]
		[Token(Token = "0x60002FE")]
		[Address(RVA = "0xCF6318", Offset = "0xCF6318", VA = "0xCF6318")]
		private static extern RESULT FMOD5_System_GetNetworkProxy(IntPtr system, IntPtr proxy, int proxylen);

		[PreserveSig]
		[Token(Token = "0x60002FF")]
		[Address(RVA = "0xCF63B8", Offset = "0xCF63B8", VA = "0xCF63B8")]
		private static extern RESULT FMOD5_System_SetNetworkTimeout(IntPtr system, int timeout);

		[PreserveSig]
		[Token(Token = "0x6000300")]
		[Address(RVA = "0xCF6450", Offset = "0xCF6450", VA = "0xCF6450")]
		private static extern RESULT FMOD5_System_GetNetworkTimeout(IntPtr system, out int timeout);

		[PreserveSig]
		[Token(Token = "0x6000301")]
		[Address(RVA = "0xCF64E8", Offset = "0xCF64E8", VA = "0xCF64E8")]
		private static extern RESULT FMOD5_System_SetUserData(IntPtr system, IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x6000302")]
		[Address(RVA = "0xCF6580", Offset = "0xCF6580", VA = "0xCF6580")]
		private static extern RESULT FMOD5_System_GetUserData(IntPtr system, out IntPtr userdata);

		[Token(Token = "0x6000303")]
		[Address(RVA = "0x8D3008", Offset = "0x8D3008", VA = "0x8D3008")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0x8D3010", Offset = "0x8D3010", VA = "0x8D3010")]
		public void clearHandle()
		{
		}
	}
	[Token(Token = "0x200008B")]
	public struct Sound
	{
		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x6000305")]
		[Address(RVA = "0x8F29AC", Offset = "0x8F29AC", VA = "0x8F29AC")]
		public RESULT release()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0x8F29B4", Offset = "0x8F29B4", VA = "0x8F29B4")]
		public RESULT getSystemObject(out System system)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x8F29BC", Offset = "0x8F29BC", VA = "0x8F29BC")]
		public RESULT @lock(uint offset, uint length, out IntPtr ptr1, out IntPtr ptr2, out uint len1, out uint len2)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x8F29C4", Offset = "0x8F29C4", VA = "0x8F29C4")]
		public RESULT unlock(IntPtr ptr1, IntPtr ptr2, uint len1, uint len2)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x8F29CC", Offset = "0x8F29CC", VA = "0x8F29CC")]
		public RESULT setDefaults(float frequency, int priority)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x8F29D4", Offset = "0x8F29D4", VA = "0x8F29D4")]
		public RESULT getDefaults(out float frequency, out int priority)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x8F29DC", Offset = "0x8F29DC", VA = "0x8F29DC")]
		public RESULT set3DMinMaxDistance(float min, float max)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x8F29E4", Offset = "0x8F29E4", VA = "0x8F29E4")]
		public RESULT get3DMinMaxDistance(out float min, out float max)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x8F29EC", Offset = "0x8F29EC", VA = "0x8F29EC")]
		public RESULT set3DConeSettings(float insideconeangle, float outsideconeangle, float outsidevolume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x8F29F4", Offset = "0x8F29F4", VA = "0x8F29F4")]
		public RESULT get3DConeSettings(out float insideconeangle, out float outsideconeangle, out float outsidevolume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x8F29FC", Offset = "0x8F29FC", VA = "0x8F29FC")]
		public RESULT set3DCustomRolloff(ref VECTOR points, int numpoints)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x8F2A04", Offset = "0x8F2A04", VA = "0x8F2A04")]
		public RESULT get3DCustomRolloff(out IntPtr points, out int numpoints)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x8F2A0C", Offset = "0x8F2A0C", VA = "0x8F2A0C")]
		public RESULT getSubSound(int index, out Sound subsound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x8F2A14", Offset = "0x8F2A14", VA = "0x8F2A14")]
		public RESULT getSubSoundParent(out Sound parentsound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x8F2A1C", Offset = "0x8F2A1C", VA = "0x8F2A1C")]
		public RESULT getName(out string name, int namelen)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x8F2A24", Offset = "0x8F2A24", VA = "0x8F2A24")]
		public RESULT getLength(out uint length, TIMEUNIT lengthtype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x8F2A2C", Offset = "0x8F2A2C", VA = "0x8F2A2C")]
		public RESULT getFormat(out SOUND_TYPE type, out SOUND_FORMAT format, out int channels, out int bits)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x8F2A34", Offset = "0x8F2A34", VA = "0x8F2A34")]
		public RESULT getNumSubSounds(out int numsubsounds)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x8F2A3C", Offset = "0x8F2A3C", VA = "0x8F2A3C")]
		public RESULT getNumTags(out int numtags, out int numtagsupdated)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0x8F2A44", Offset = "0x8F2A44", VA = "0x8F2A44")]
		public RESULT getTag(string name, int index, out TAG tag)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0x8F2A4C", Offset = "0x8F2A4C", VA = "0x8F2A4C")]
		public RESULT getOpenState(out OPENSTATE openstate, out uint percentbuffered, out bool starving, out bool diskbusy)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x8F2A54", Offset = "0x8F2A54", VA = "0x8F2A54")]
		public RESULT readData(IntPtr buffer, uint length, out uint read)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x8F2A5C", Offset = "0x8F2A5C", VA = "0x8F2A5C")]
		public RESULT seekData(uint pcm)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x8F2A64", Offset = "0x8F2A64", VA = "0x8F2A64")]
		public RESULT setSoundGroup(SoundGroup soundgroup)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x8F2A6C", Offset = "0x8F2A6C", VA = "0x8F2A6C")]
		public RESULT getSoundGroup(out SoundGroup soundgroup)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x8F2A74", Offset = "0x8F2A74", VA = "0x8F2A74")]
		public RESULT getNumSyncPoints(out int numsyncpoints)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x8F2A7C", Offset = "0x8F2A7C", VA = "0x8F2A7C")]
		public RESULT getSyncPoint(int index, out IntPtr point)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x8F2A84", Offset = "0x8F2A84", VA = "0x8F2A84")]
		public RESULT getSyncPointInfo(IntPtr point, out string name, int namelen, out uint offset, TIMEUNIT offsettype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x8F2A8C", Offset = "0x8F2A8C", VA = "0x8F2A8C")]
		public RESULT getSyncPointInfo(IntPtr point, out uint offset, TIMEUNIT offsettype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0x8F2A94", Offset = "0x8F2A94", VA = "0x8F2A94")]
		public RESULT addSyncPoint(uint offset, TIMEUNIT offsettype, string name, out IntPtr point)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x8F2A9C", Offset = "0x8F2A9C", VA = "0x8F2A9C")]
		public RESULT deleteSyncPoint(IntPtr point)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x8F2AA4", Offset = "0x8F2AA4", VA = "0x8F2AA4")]
		public RESULT setMode(MODE mode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0x8F2AAC", Offset = "0x8F2AAC", VA = "0x8F2AAC")]
		public RESULT getMode(out MODE mode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0x8F2AB4", Offset = "0x8F2AB4", VA = "0x8F2AB4")]
		public RESULT setLoopCount(int loopcount)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0x8F2ABC", Offset = "0x8F2ABC", VA = "0x8F2ABC")]
		public RESULT getLoopCount(out int loopcount)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x8F2AC4", Offset = "0x8F2AC4", VA = "0x8F2AC4")]
		public RESULT setLoopPoints(uint loopstart, TIMEUNIT loopstarttype, uint loopend, TIMEUNIT loopendtype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x8F2ACC", Offset = "0x8F2ACC", VA = "0x8F2ACC")]
		public RESULT getLoopPoints(out uint loopstart, TIMEUNIT loopstarttype, out uint loopend, TIMEUNIT loopendtype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0x8F2AD4", Offset = "0x8F2AD4", VA = "0x8F2AD4")]
		public RESULT getMusicNumChannels(out int numchannels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x8F2ADC", Offset = "0x8F2ADC", VA = "0x8F2ADC")]
		public RESULT setMusicChannelVolume(int channel, float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0x8F2AE4", Offset = "0x8F2AE4", VA = "0x8F2AE4")]
		public RESULT getMusicChannelVolume(int channel, out float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0x8F2AEC", Offset = "0x8F2AEC", VA = "0x8F2AEC")]
		public RESULT setMusicSpeed(float speed)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0x8F2AF4", Offset = "0x8F2AF4", VA = "0x8F2AF4")]
		public RESULT getMusicSpeed(out float speed)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x8F2AFC", Offset = "0x8F2AFC", VA = "0x8F2AFC")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0x8F2B04", Offset = "0x8F2B04", VA = "0x8F2B04")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000331")]
		[Address(RVA = "0x150FA58", Offset = "0x150FA58", VA = "0x150FA58")]
		private static extern RESULT FMOD5_Sound_Release(IntPtr sound);

		[PreserveSig]
		[Token(Token = "0x6000332")]
		[Address(RVA = "0x150FAE0", Offset = "0x150FAE0", VA = "0x150FAE0")]
		private static extern RESULT FMOD5_Sound_GetSystemObject(IntPtr sound, out IntPtr system);

		[PreserveSig]
		[Token(Token = "0x6000333")]
		[Address(RVA = "0x150FB78", Offset = "0x150FB78", VA = "0x150FB78")]
		private static extern RESULT FMOD5_Sound_Lock(IntPtr sound, uint offset, uint length, out IntPtr ptr1, out IntPtr ptr2, out uint len1, out uint len2);

		[PreserveSig]
		[Token(Token = "0x6000334")]
		[Address(RVA = "0x150FC48", Offset = "0x150FC48", VA = "0x150FC48")]
		private static extern RESULT FMOD5_Sound_Unlock(IntPtr sound, IntPtr ptr1, IntPtr ptr2, uint len1, uint len2);

		[PreserveSig]
		[Token(Token = "0x6000335")]
		[Address(RVA = "0x150FD00", Offset = "0x150FD00", VA = "0x150FD00")]
		private static extern RESULT FMOD5_Sound_SetDefaults(IntPtr sound, float frequency, int priority);

		[PreserveSig]
		[Token(Token = "0x6000336")]
		[Address(RVA = "0x150FDA8", Offset = "0x150FDA8", VA = "0x150FDA8")]
		private static extern RESULT FMOD5_Sound_GetDefaults(IntPtr sound, out float frequency, out int priority);

		[PreserveSig]
		[Token(Token = "0x6000337")]
		[Address(RVA = "0x150FE48", Offset = "0x150FE48", VA = "0x150FE48")]
		private static extern RESULT FMOD5_Sound_Set3DMinMaxDistance(IntPtr sound, float min, float max);

		[PreserveSig]
		[Token(Token = "0x6000338")]
		[Address(RVA = "0x150FEE8", Offset = "0x150FEE8", VA = "0x150FEE8")]
		private static extern RESULT FMOD5_Sound_Get3DMinMaxDistance(IntPtr sound, out float min, out float max);

		[PreserveSig]
		[Token(Token = "0x6000339")]
		[Address(RVA = "0x150FF88", Offset = "0x150FF88", VA = "0x150FF88")]
		private static extern RESULT FMOD5_Sound_Set3DConeSettings(IntPtr sound, float insideconeangle, float outsideconeangle, float outsidevolume);

		[PreserveSig]
		[Token(Token = "0x600033A")]
		[Address(RVA = "0x1510038", Offset = "0x1510038", VA = "0x1510038")]
		private static extern RESULT FMOD5_Sound_Get3DConeSettings(IntPtr sound, out float insideconeangle, out float outsideconeangle, out float outsidevolume);

		[PreserveSig]
		[Token(Token = "0x600033B")]
		[Address(RVA = "0x15100E8", Offset = "0x15100E8", VA = "0x15100E8")]
		private static extern RESULT FMOD5_Sound_Set3DCustomRolloff(IntPtr sound, ref VECTOR points, int numpoints);

		[PreserveSig]
		[Token(Token = "0x600033C")]
		[Address(RVA = "0x1510188", Offset = "0x1510188", VA = "0x1510188")]
		private static extern RESULT FMOD5_Sound_Get3DCustomRolloff(IntPtr sound, out IntPtr points, out int numpoints);

		[PreserveSig]
		[Token(Token = "0x600033D")]
		[Address(RVA = "0x1510228", Offset = "0x1510228", VA = "0x1510228")]
		private static extern RESULT FMOD5_Sound_GetSubSound(IntPtr sound, int index, out IntPtr subsound);

		[PreserveSig]
		[Token(Token = "0x600033E")]
		[Address(RVA = "0x15102C8", Offset = "0x15102C8", VA = "0x15102C8")]
		private static extern RESULT FMOD5_Sound_GetSubSoundParent(IntPtr sound, out IntPtr parentsound);

		[PreserveSig]
		[Token(Token = "0x600033F")]
		[Address(RVA = "0x1510504", Offset = "0x1510504", VA = "0x1510504")]
		private static extern RESULT FMOD5_Sound_GetName(IntPtr sound, IntPtr name, int namelen);

		[PreserveSig]
		[Token(Token = "0x6000340")]
		[Address(RVA = "0x15107B4", Offset = "0x15107B4", VA = "0x15107B4")]
		private static extern RESULT FMOD5_Sound_GetLength(IntPtr sound, out uint length, TIMEUNIT lengthtype);

		[PreserveSig]
		[Token(Token = "0x6000341")]
		[Address(RVA = "0x1510854", Offset = "0x1510854", VA = "0x1510854")]
		private static extern RESULT FMOD5_Sound_GetFormat(IntPtr sound, out SOUND_TYPE type, out SOUND_FORMAT format, out int channels, out int bits);

		[PreserveSig]
		[Token(Token = "0x6000342")]
		[Address(RVA = "0x151090C", Offset = "0x151090C", VA = "0x151090C")]
		private static extern RESULT FMOD5_Sound_GetNumSubSounds(IntPtr sound, out int numsubsounds);

		[PreserveSig]
		[Token(Token = "0x6000343")]
		[Address(RVA = "0x15109A4", Offset = "0x15109A4", VA = "0x15109A4")]
		private static extern RESULT FMOD5_Sound_GetNumTags(IntPtr sound, out int numtags, out int numtagsupdated);

		[PreserveSig]
		[Token(Token = "0x6000344")]
		[Address(RVA = "0x1510B9C", Offset = "0x1510B9C", VA = "0x1510B9C")]
		private static extern RESULT FMOD5_Sound_GetTag(IntPtr sound, byte[] name, int index, out TAG tag);

		[PreserveSig]
		[Token(Token = "0x6000345")]
		[Address(RVA = "0x1510C88", Offset = "0x1510C88", VA = "0x1510C88")]
		private static extern RESULT FMOD5_Sound_GetOpenState(IntPtr sound, out OPENSTATE openstate, out uint percentbuffered, out bool starving, out bool diskbusy);

		[PreserveSig]
		[Token(Token = "0x6000346")]
		[Address(RVA = "0x1510D64", Offset = "0x1510D64", VA = "0x1510D64")]
		private static extern RESULT FMOD5_Sound_ReadData(IntPtr sound, IntPtr buffer, uint length, out uint read);

		[PreserveSig]
		[Token(Token = "0x6000347")]
		[Address(RVA = "0x1510E14", Offset = "0x1510E14", VA = "0x1510E14")]
		private static extern RESULT FMOD5_Sound_SeekData(IntPtr sound, uint pcm);

		[PreserveSig]
		[Token(Token = "0x6000348")]
		[Address(RVA = "0x1510EAC", Offset = "0x1510EAC", VA = "0x1510EAC")]
		private static extern RESULT FMOD5_Sound_SetSoundGroup(IntPtr sound, IntPtr soundgroup);

		[PreserveSig]
		[Token(Token = "0x6000349")]
		[Address(RVA = "0x1510F44", Offset = "0x1510F44", VA = "0x1510F44")]
		private static extern RESULT FMOD5_Sound_GetSoundGroup(IntPtr sound, out IntPtr soundgroup);

		[PreserveSig]
		[Token(Token = "0x600034A")]
		[Address(RVA = "0x1510FDC", Offset = "0x1510FDC", VA = "0x1510FDC")]
		private static extern RESULT FMOD5_Sound_GetNumSyncPoints(IntPtr sound, out int numsyncpoints);

		[PreserveSig]
		[Token(Token = "0x600034B")]
		[Address(RVA = "0x1511074", Offset = "0x1511074", VA = "0x1511074")]
		private static extern RESULT FMOD5_Sound_GetSyncPoint(IntPtr sound, int index, out IntPtr point);

		[PreserveSig]
		[Token(Token = "0x600034C")]
		[Address(RVA = "0x15112D8", Offset = "0x15112D8", VA = "0x15112D8")]
		private static extern RESULT FMOD5_Sound_GetSyncPointInfo(IntPtr sound, IntPtr point, IntPtr name, int namelen, out uint offset, TIMEUNIT offsettype);

		[PreserveSig]
		[Token(Token = "0x600034D")]
		[Address(RVA = "0x1511574", Offset = "0x1511574", VA = "0x1511574")]
		private static extern RESULT FMOD5_Sound_AddSyncPoint(IntPtr sound, uint offset, TIMEUNIT offsettype, byte[] name, out IntPtr point);

		[PreserveSig]
		[Token(Token = "0x600034E")]
		[Address(RVA = "0x1511634", Offset = "0x1511634", VA = "0x1511634")]
		private static extern RESULT FMOD5_Sound_DeleteSyncPoint(IntPtr sound, IntPtr point);

		[PreserveSig]
		[Token(Token = "0x600034F")]
		[Address(RVA = "0x15116CC", Offset = "0x15116CC", VA = "0x15116CC")]
		private static extern RESULT FMOD5_Sound_SetMode(IntPtr sound, MODE mode);

		[PreserveSig]
		[Token(Token = "0x6000350")]
		[Address(RVA = "0x1511764", Offset = "0x1511764", VA = "0x1511764")]
		private static extern RESULT FMOD5_Sound_GetMode(IntPtr sound, out MODE mode);

		[PreserveSig]
		[Token(Token = "0x6000351")]
		[Address(RVA = "0x15117FC", Offset = "0x15117FC", VA = "0x15117FC")]
		private static extern RESULT FMOD5_Sound_SetLoopCount(IntPtr sound, int loopcount);

		[PreserveSig]
		[Token(Token = "0x6000352")]
		[Address(RVA = "0x1511894", Offset = "0x1511894", VA = "0x1511894")]
		private static extern RESULT FMOD5_Sound_GetLoopCount(IntPtr sound, out int loopcount);

		[PreserveSig]
		[Token(Token = "0x6000353")]
		[Address(RVA = "0x151192C", Offset = "0x151192C", VA = "0x151192C")]
		private static extern RESULT FMOD5_Sound_SetLoopPoints(IntPtr sound, uint loopstart, TIMEUNIT loopstarttype, uint loopend, TIMEUNIT loopendtype);

		[PreserveSig]
		[Token(Token = "0x6000354")]
		[Address(RVA = "0x15119E4", Offset = "0x15119E4", VA = "0x15119E4")]
		private static extern RESULT FMOD5_Sound_GetLoopPoints(IntPtr sound, out uint loopstart, TIMEUNIT loopstarttype, out uint loopend, TIMEUNIT loopendtype);

		[PreserveSig]
		[Token(Token = "0x6000355")]
		[Address(RVA = "0x1511A9C", Offset = "0x1511A9C", VA = "0x1511A9C")]
		private static extern RESULT FMOD5_Sound_GetMusicNumChannels(IntPtr sound, out int numchannels);

		[PreserveSig]
		[Token(Token = "0x6000356")]
		[Address(RVA = "0x1511B34", Offset = "0x1511B34", VA = "0x1511B34")]
		private static extern RESULT FMOD5_Sound_SetMusicChannelVolume(IntPtr sound, int channel, float volume);

		[PreserveSig]
		[Token(Token = "0x6000357")]
		[Address(RVA = "0x1511BDC", Offset = "0x1511BDC", VA = "0x1511BDC")]
		private static extern RESULT FMOD5_Sound_GetMusicChannelVolume(IntPtr sound, int channel, out float volume);

		[PreserveSig]
		[Token(Token = "0x6000358")]
		[Address(RVA = "0x1511C7C", Offset = "0x1511C7C", VA = "0x1511C7C")]
		private static extern RESULT FMOD5_Sound_SetMusicSpeed(IntPtr sound, float speed);

		[PreserveSig]
		[Token(Token = "0x6000359")]
		[Address(RVA = "0x1511D14", Offset = "0x1511D14", VA = "0x1511D14")]
		private static extern RESULT FMOD5_Sound_GetMusicSpeed(IntPtr sound, out float speed);

		[PreserveSig]
		[Token(Token = "0x600035A")]
		[Address(RVA = "0x1511DAC", Offset = "0x1511DAC", VA = "0x1511DAC")]
		private static extern RESULT FMOD5_Sound_SetUserData(IntPtr sound, IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x600035B")]
		[Address(RVA = "0x1511E44", Offset = "0x1511E44", VA = "0x1511E44")]
		private static extern RESULT FMOD5_Sound_GetUserData(IntPtr sound, out IntPtr userdata);

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x8F2B0C", Offset = "0x8F2B0C", VA = "0x8F2B0C")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x8F2B14", Offset = "0x8F2B14", VA = "0x8F2B14")]
		public void clearHandle()
		{
		}
	}
	[Token(Token = "0x200008C")]
	internal interface IChannelControl
	{
		[Token(Token = "0x600035E")]
		RESULT getSystemObject(out System system);

		[Token(Token = "0x600035F")]
		RESULT stop();

		[Token(Token = "0x6000360")]
		RESULT setPaused(bool paused);

		[Token(Token = "0x6000361")]
		RESULT getPaused(out bool paused);

		[Token(Token = "0x6000362")]
		RESULT setVolume(float volume);

		[Token(Token = "0x6000363")]
		RESULT getVolume(out float volume);

		[Token(Token = "0x6000364")]
		RESULT setVolumeRamp(bool ramp);

		[Token(Token = "0x6000365")]
		RESULT getVolumeRamp(out bool ramp);

		[Token(Token = "0x6000366")]
		RESULT getAudibility(out float audibility);

		[Token(Token = "0x6000367")]
		RESULT setPitch(float pitch);

		[Token(Token = "0x6000368")]
		RESULT getPitch(out float pitch);

		[Token(Token = "0x6000369")]
		RESULT setMute(bool mute);

		[Token(Token = "0x600036A")]
		RESULT getMute(out bool mute);

		[Token(Token = "0x600036B")]
		RESULT setReverbProperties(int instance, float wet);

		[Token(Token = "0x600036C")]
		RESULT getReverbProperties(int instance, out float wet);

		[Token(Token = "0x600036D")]
		RESULT setLowPassGain(float gain);

		[Token(Token = "0x600036E")]
		RESULT getLowPassGain(out float gain);

		[Token(Token = "0x600036F")]
		RESULT setMode(MODE mode);

		[Token(Token = "0x6000370")]
		RESULT getMode(out MODE mode);

		[Token(Token = "0x6000371")]
		RESULT setCallback(CHANNELCONTROL_CALLBACK callback);

		[Token(Token = "0x6000372")]
		RESULT isPlaying(out bool isplaying);

		[Token(Token = "0x6000373")]
		RESULT setPan(float pan);

		[Token(Token = "0x6000374")]
		RESULT setMixLevelsOutput(float frontleft, float frontright, float center, float lfe, float surroundleft, float surroundright, float backleft, float backright);

		[Token(Token = "0x6000375")]
		RESULT setMixLevelsInput(float[] levels, int numlevels);

		[Token(Token = "0x6000376")]
		RESULT setMixMatrix(float[] matrix, int outchannels, int inchannels, int inchannel_hop);

		[Token(Token = "0x6000377")]
		RESULT getMixMatrix(float[] matrix, out int outchannels, out int inchannels, int inchannel_hop);

		[Token(Token = "0x6000378")]
		RESULT getDSPClock(out ulong dspclock, out ulong parentclock);

		[Token(Token = "0x6000379")]
		RESULT setDelay(ulong dspclock_start, ulong dspclock_end, bool stopchannels);

		[Token(Token = "0x600037A")]
		RESULT getDelay(out ulong dspclock_start, out ulong dspclock_end);

		[Token(Token = "0x600037B")]
		RESULT getDelay(out ulong dspclock_start, out ulong dspclock_end, out bool stopchannels);

		[Token(Token = "0x600037C")]
		RESULT addFadePoint(ulong dspclock, float volume);

		[Token(Token = "0x600037D")]
		RESULT setFadePointRamp(ulong dspclock, float volume);

		[Token(Token = "0x600037E")]
		RESULT removeFadePoints(ulong dspclock_start, ulong dspclock_end);

		[Token(Token = "0x600037F")]
		RESULT getFadePoints(ref uint numpoints, ulong[] point_dspclock, float[] point_volume);

		[Token(Token = "0x6000380")]
		RESULT getDSP(int index, out DSP dsp);

		[Token(Token = "0x6000381")]
		RESULT addDSP(int index, DSP dsp);

		[Token(Token = "0x6000382")]
		RESULT removeDSP(DSP dsp);

		[Token(Token = "0x6000383")]
		RESULT getNumDSPs(out int numdsps);

		[Token(Token = "0x6000384")]
		RESULT setDSPIndex(DSP dsp, int index);

		[Token(Token = "0x6000385")]
		RESULT getDSPIndex(DSP dsp, out int index);

		[Token(Token = "0x6000386")]
		RESULT set3DAttributes(ref VECTOR pos, ref VECTOR vel);

		[Token(Token = "0x6000387")]
		RESULT get3DAttributes(out VECTOR pos, out VECTOR vel);

		[Token(Token = "0x6000388")]
		RESULT set3DMinMaxDistance(float mindistance, float maxdistance);

		[Token(Token = "0x6000389")]
		RESULT get3DMinMaxDistance(out float mindistance, out float maxdistance);

		[Token(Token = "0x600038A")]
		RESULT set3DConeSettings(float insideconeangle, float outsideconeangle, float outsidevolume);

		[Token(Token = "0x600038B")]
		RESULT get3DConeSettings(out float insideconeangle, out float outsideconeangle, out float outsidevolume);

		[Token(Token = "0x600038C")]
		RESULT set3DConeOrientation(ref VECTOR orientation);

		[Token(Token = "0x600038D")]
		RESULT get3DConeOrientation(out VECTOR orientation);

		[Token(Token = "0x600038E")]
		RESULT set3DCustomRolloff(ref VECTOR points, int numpoints);

		[Token(Token = "0x600038F")]
		RESULT get3DCustomRolloff(out IntPtr points, out int numpoints);

		[Token(Token = "0x6000390")]
		RESULT set3DOcclusion(float directocclusion, float reverbocclusion);

		[Token(Token = "0x6000391")]
		RESULT get3DOcclusion(out float directocclusion, out float reverbocclusion);

		[Token(Token = "0x6000392")]
		RESULT set3DSpread(float angle);

		[Token(Token = "0x6000393")]
		RESULT get3DSpread(out float angle);

		[Token(Token = "0x6000394")]
		RESULT set3DLevel(float level);

		[Token(Token = "0x6000395")]
		RESULT get3DLevel(out float level);

		[Token(Token = "0x6000396")]
		RESULT set3DDopplerLevel(float level);

		[Token(Token = "0x6000397")]
		RESULT get3DDopplerLevel(out float level);

		[Token(Token = "0x6000398")]
		RESULT set3DDistanceFilter(bool custom, float customLevel, float centerFreq);

		[Token(Token = "0x6000399")]
		RESULT get3DDistanceFilter(out bool custom, out float customLevel, out float centerFreq);

		[Token(Token = "0x600039A")]
		RESULT setUserData(IntPtr userdata);

		[Token(Token = "0x600039B")]
		RESULT getUserData(out IntPtr userdata);
	}
	[Token(Token = "0x200008D")]
	public struct Channel : IChannelControl
	{
		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x8F0770", Offset = "0x8F0770", VA = "0x8F0770")]
		public RESULT setFrequency(float frequency)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x8F0778", Offset = "0x8F0778", VA = "0x8F0778")]
		public RESULT getFrequency(out float frequency)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x8F0780", Offset = "0x8F0780", VA = "0x8F0780")]
		public RESULT setPriority(int priority)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x8F0788", Offset = "0x8F0788", VA = "0x8F0788")]
		public RESULT getPriority(out int priority)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x8F0790", Offset = "0x8F0790", VA = "0x8F0790")]
		public RESULT setPosition(uint position, TIMEUNIT postype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x8F0798", Offset = "0x8F0798", VA = "0x8F0798")]
		public RESULT getPosition(out uint position, TIMEUNIT postype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x8F07A0", Offset = "0x8F07A0", VA = "0x8F07A0")]
		public RESULT setChannelGroup(ChannelGroup channelgroup)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x8F07A8", Offset = "0x8F07A8", VA = "0x8F07A8")]
		public RESULT getChannelGroup(out ChannelGroup channelgroup)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x8F07B0", Offset = "0x8F07B0", VA = "0x8F07B0")]
		public RESULT setLoopCount(int loopcount)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x8F07B8", Offset = "0x8F07B8", VA = "0x8F07B8")]
		public RESULT getLoopCount(out int loopcount)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x8F07C0", Offset = "0x8F07C0", VA = "0x8F07C0")]
		public RESULT setLoopPoints(uint loopstart, TIMEUNIT loopstarttype, uint loopend, TIMEUNIT loopendtype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x8F07C8", Offset = "0x8F07C8", VA = "0x8F07C8")]
		public RESULT getLoopPoints(out uint loopstart, TIMEUNIT loopstarttype, out uint loopend, TIMEUNIT loopendtype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x8F07D0", Offset = "0x8F07D0", VA = "0x8F07D0")]
		public RESULT isVirtual(out bool isvirtual)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x8F07D8", Offset = "0x8F07D8", VA = "0x8F07D8")]
		public RESULT getCurrentSound(out Sound sound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x8F07E0", Offset = "0x8F07E0", VA = "0x8F07E0")]
		public RESULT getIndex(out int index)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x8F07E8", Offset = "0x8F07E8", VA = "0x8F07E8", Slot = "4")]
		public RESULT getSystemObject(out System system)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x8F07F0", Offset = "0x8F07F0", VA = "0x8F07F0", Slot = "5")]
		public RESULT stop()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x8F07F8", Offset = "0x8F07F8", VA = "0x8F07F8", Slot = "6")]
		public RESULT setPaused(bool paused)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x8F0804", Offset = "0x8F0804", VA = "0x8F0804", Slot = "7")]
		public RESULT getPaused(out bool paused)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x8F080C", Offset = "0x8F080C", VA = "0x8F080C", Slot = "8")]
		public RESULT setVolume(float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x8F0814", Offset = "0x8F0814", VA = "0x8F0814", Slot = "9")]
		public RESULT getVolume(out float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x8F081C", Offset = "0x8F081C", VA = "0x8F081C", Slot = "10")]
		public RESULT setVolumeRamp(bool ramp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x8F0828", Offset = "0x8F0828", VA = "0x8F0828", Slot = "11")]
		public RESULT getVolumeRamp(out bool ramp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x8F0830", Offset = "0x8F0830", VA = "0x8F0830", Slot = "12")]
		public RESULT getAudibility(out float audibility)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x8F0838", Offset = "0x8F0838", VA = "0x8F0838", Slot = "13")]
		public RESULT setPitch(float pitch)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x8F0840", Offset = "0x8F0840", VA = "0x8F0840", Slot = "14")]
		public RESULT getPitch(out float pitch)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x8F0848", Offset = "0x8F0848", VA = "0x8F0848", Slot = "15")]
		public RESULT setMute(bool mute)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x8F0854", Offset = "0x8F0854", VA = "0x8F0854", Slot = "16")]
		public RESULT getMute(out bool mute)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x8F085C", Offset = "0x8F085C", VA = "0x8F085C", Slot = "17")]
		public RESULT setReverbProperties(int instance, float wet)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x8F0864", Offset = "0x8F0864", VA = "0x8F0864", Slot = "18")]
		public RESULT getReverbProperties(int instance, out float wet)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x8F086C", Offset = "0x8F086C", VA = "0x8F086C", Slot = "19")]
		public RESULT setLowPassGain(float gain)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x8F0874", Offset = "0x8F0874", VA = "0x8F0874", Slot = "20")]
		public RESULT getLowPassGain(out float gain)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x8F087C", Offset = "0x8F087C", VA = "0x8F087C", Slot = "21")]
		public RESULT setMode(MODE mode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x8F0884", Offset = "0x8F0884", VA = "0x8F0884", Slot = "22")]
		public RESULT getMode(out MODE mode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x8F088C", Offset = "0x8F088C", VA = "0x8F088C", Slot = "23")]
		public RESULT setCallback(CHANNELCONTROL_CALLBACK callback)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x8F0894", Offset = "0x8F0894", VA = "0x8F0894", Slot = "24")]
		public RESULT isPlaying(out bool isplaying)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x8F089C", Offset = "0x8F089C", VA = "0x8F089C", Slot = "25")]
		public RESULT setPan(float pan)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x8F08A4", Offset = "0x8F08A4", VA = "0x8F08A4", Slot = "26")]
		public RESULT setMixLevelsOutput(float frontleft, float frontright, float center, float lfe, float surroundleft, float surroundright, float backleft, float backright)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x8F08AC", Offset = "0x8F08AC", VA = "0x8F08AC", Slot = "27")]
		public RESULT setMixLevelsInput(float[] levels, int numlevels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x8F08B4", Offset = "0x8F08B4", VA = "0x8F08B4", Slot = "28")]
		public RESULT setMixMatrix(float[] matrix, int outchannels, int inchannels, int inchannel_hop = 0)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x8F08BC", Offset = "0x8F08BC", VA = "0x8F08BC", Slot = "29")]
		public RESULT getMixMatrix(float[] matrix, out int outchannels, out int inchannels, int inchannel_hop = 0)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x8F08C4", Offset = "0x8F08C4", VA = "0x8F08C4", Slot = "30")]
		public RESULT getDSPClock(out ulong dspclock, out ulong parentclock)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x8F08CC", Offset = "0x8F08CC", VA = "0x8F08CC", Slot = "31")]
		public RESULT setDelay(ulong dspclock_start, ulong dspclock_end, bool stopchannels = true)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x8F08D8", Offset = "0x8F08D8", VA = "0x8F08D8", Slot = "32")]
		public RESULT getDelay(out ulong dspclock_start, out ulong dspclock_end)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x8F08E0", Offset = "0x8F08E0", VA = "0x8F08E0", Slot = "33")]
		public RESULT getDelay(out ulong dspclock_start, out ulong dspclock_end, out bool stopchannels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x8F08E8", Offset = "0x8F08E8", VA = "0x8F08E8", Slot = "34")]
		public RESULT addFadePoint(ulong dspclock, float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x8F08F0", Offset = "0x8F08F0", VA = "0x8F08F0", Slot = "35")]
		public RESULT setFadePointRamp(ulong dspclock, float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x8F08F8", Offset = "0x8F08F8", VA = "0x8F08F8", Slot = "36")]
		public RESULT removeFadePoints(ulong dspclock_start, ulong dspclock_end)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x8F0900", Offset = "0x8F0900", VA = "0x8F0900", Slot = "37")]
		public RESULT getFadePoints(ref uint numpoints, ulong[] point_dspclock, float[] point_volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x8F0908", Offset = "0x8F0908", VA = "0x8F0908", Slot = "38")]
		public RESULT getDSP(int index, out DSP dsp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x8F0910", Offset = "0x8F0910", VA = "0x8F0910", Slot = "39")]
		public RESULT addDSP(int index, DSP dsp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x8F0918", Offset = "0x8F0918", VA = "0x8F0918", Slot = "40")]
		public RESULT removeDSP(DSP dsp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x8F0920", Offset = "0x8F0920", VA = "0x8F0920", Slot = "41")]
		public RESULT getNumDSPs(out int numdsps)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x8F0928", Offset = "0x8F0928", VA = "0x8F0928", Slot = "42")]
		public RESULT setDSPIndex(DSP dsp, int index)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x8F0930", Offset = "0x8F0930", VA = "0x8F0930", Slot = "43")]
		public RESULT getDSPIndex(DSP dsp, out int index)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x8F0938", Offset = "0x8F0938", VA = "0x8F0938", Slot = "44")]
		public RESULT set3DAttributes(ref VECTOR pos, ref VECTOR vel)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x8F0940", Offset = "0x8F0940", VA = "0x8F0940", Slot = "45")]
		public RESULT get3DAttributes(out VECTOR pos, out VECTOR vel)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x8F0948", Offset = "0x8F0948", VA = "0x8F0948", Slot = "46")]
		public RESULT set3DMinMaxDistance(float mindistance, float maxdistance)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x8F0950", Offset = "0x8F0950", VA = "0x8F0950", Slot = "47")]
		public RESULT get3DMinMaxDistance(out float mindistance, out float maxdistance)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x8F0958", Offset = "0x8F0958", VA = "0x8F0958", Slot = "48")]
		public RESULT set3DConeSettings(float insideconeangle, float outsideconeangle, float outsidevolume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x8F0960", Offset = "0x8F0960", VA = "0x8F0960", Slot = "49")]
		public RESULT get3DConeSettings(out float insideconeangle, out float outsideconeangle, out float outsidevolume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x8F0968", Offset = "0x8F0968", VA = "0x8F0968", Slot = "50")]
		public RESULT set3DConeOrientation(ref VECTOR orientation)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x8F0970", Offset = "0x8F0970", VA = "0x8F0970", Slot = "51")]
		public RESULT get3DConeOrientation(out VECTOR orientation)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x8F0978", Offset = "0x8F0978", VA = "0x8F0978", Slot = "52")]
		public RESULT set3DCustomRolloff(ref VECTOR points, int numpoints)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x8F0980", Offset = "0x8F0980", VA = "0x8F0980", Slot = "53")]
		public RESULT get3DCustomRolloff(out IntPtr points, out int numpoints)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x8F0988", Offset = "0x8F0988", VA = "0x8F0988", Slot = "54")]
		public RESULT set3DOcclusion(float directocclusion, float reverbocclusion)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x8F0990", Offset = "0x8F0990", VA = "0x8F0990", Slot = "55")]
		public RESULT get3DOcclusion(out float directocclusion, out float reverbocclusion)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x8F0998", Offset = "0x8F0998", VA = "0x8F0998", Slot = "56")]
		public RESULT set3DSpread(float angle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x8F09A0", Offset = "0x8F09A0", VA = "0x8F09A0", Slot = "57")]
		public RESULT get3DSpread(out float angle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x8F09A8", Offset = "0x8F09A8", VA = "0x8F09A8", Slot = "58")]
		public RESULT set3DLevel(float level)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x8F09B0", Offset = "0x8F09B0", VA = "0x8F09B0", Slot = "59")]
		public RESULT get3DLevel(out float level)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x8F09B8", Offset = "0x8F09B8", VA = "0x8F09B8", Slot = "60")]
		public RESULT set3DDopplerLevel(float level)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x8F09C0", Offset = "0x8F09C0", VA = "0x8F09C0", Slot = "61")]
		public RESULT get3DDopplerLevel(out float level)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x8F09C8", Offset = "0x8F09C8", VA = "0x8F09C8", Slot = "62")]
		public RESULT set3DDistanceFilter(bool custom, float customLevel, float centerFreq)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x8F09D4", Offset = "0x8F09D4", VA = "0x8F09D4", Slot = "63")]
		public RESULT get3DDistanceFilter(out bool custom, out float customLevel, out float centerFreq)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x8F09DC", Offset = "0x8F09DC", VA = "0x8F09DC", Slot = "64")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x8F09E4", Offset = "0x8F09E4", VA = "0x8F09E4", Slot = "65")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x14F895C", Offset = "0x14F895C", VA = "0x14F895C")]
		private static extern RESULT FMOD5_Channel_SetFrequency(IntPtr channel, float frequency);

		[PreserveSig]
		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x14F89F4", Offset = "0x14F89F4", VA = "0x14F89F4")]
		private static extern RESULT FMOD5_Channel_GetFrequency(IntPtr channel, out float frequency);

		[PreserveSig]
		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x14F8A8C", Offset = "0x14F8A8C", VA = "0x14F8A8C")]
		private static extern RESULT FMOD5_Channel_SetPriority(IntPtr channel, int priority);

		[PreserveSig]
		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x14F8B24", Offset = "0x14F8B24", VA = "0x14F8B24")]
		private static extern RESULT FMOD5_Channel_GetPriority(IntPtr channel, out int priority);

		[PreserveSig]
		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x14F8BBC", Offset = "0x14F8BBC", VA = "0x14F8BBC")]
		private static extern RESULT FMOD5_Channel_SetPosition(IntPtr channel, uint position, TIMEUNIT postype);

		[PreserveSig]
		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x14F8C5C", Offset = "0x14F8C5C", VA = "0x14F8C5C")]
		private static extern RESULT FMOD5_Channel_GetPosition(IntPtr channel, out uint position, TIMEUNIT postype);

		[PreserveSig]
		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x14F8CFC", Offset = "0x14F8CFC", VA = "0x14F8CFC")]
		private static extern RESULT FMOD5_Channel_SetChannelGroup(IntPtr channel, IntPtr channelgroup);

		[PreserveSig]
		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x14F8D94", Offset = "0x14F8D94", VA = "0x14F8D94")]
		private static extern RESULT FMOD5_Channel_GetChannelGroup(IntPtr channel, out IntPtr channelgroup);

		[PreserveSig]
		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x14F8E2C", Offset = "0x14F8E2C", VA = "0x14F8E2C")]
		private static extern RESULT FMOD5_Channel_SetLoopCount(IntPtr channel, int loopcount);

		[PreserveSig]
		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x14F8EC4", Offset = "0x14F8EC4", VA = "0x14F8EC4")]
		private static extern RESULT FMOD5_Channel_GetLoopCount(IntPtr channel, out int loopcount);

		[PreserveSig]
		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x14F8F5C", Offset = "0x14F8F5C", VA = "0x14F8F5C")]
		private static extern RESULT FMOD5_Channel_SetLoopPoints(IntPtr channel, uint loopstart, TIMEUNIT loopstarttype, uint loopend, TIMEUNIT loopendtype);

		[PreserveSig]
		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x14F9014", Offset = "0x14F9014", VA = "0x14F9014")]
		private static extern RESULT FMOD5_Channel_GetLoopPoints(IntPtr channel, out uint loopstart, TIMEUNIT loopstarttype, out uint loopend, TIMEUNIT loopendtype);

		[PreserveSig]
		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x14F90CC", Offset = "0x14F90CC", VA = "0x14F90CC")]
		private static extern RESULT FMOD5_Channel_IsVirtual(IntPtr channel, out bool isvirtual);

		[PreserveSig]
		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x14F9178", Offset = "0x14F9178", VA = "0x14F9178")]
		private static extern RESULT FMOD5_Channel_GetCurrentSound(IntPtr channel, out IntPtr sound);

		[PreserveSig]
		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x14F9210", Offset = "0x14F9210", VA = "0x14F9210")]
		private static extern RESULT FMOD5_Channel_GetIndex(IntPtr channel, out int index);

		[PreserveSig]
		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x14F92A8", Offset = "0x14F92A8", VA = "0x14F92A8")]
		private static extern RESULT FMOD5_Channel_GetSystemObject(IntPtr channel, out IntPtr system);

		[PreserveSig]
		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x14F9340", Offset = "0x14F9340", VA = "0x14F9340")]
		private static extern RESULT FMOD5_Channel_Stop(IntPtr channel);

		[PreserveSig]
		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x14F93CC", Offset = "0x14F93CC", VA = "0x14F93CC")]
		private static extern RESULT FMOD5_Channel_SetPaused(IntPtr channel, bool paused);

		[PreserveSig]
		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x14F9464", Offset = "0x14F9464", VA = "0x14F9464")]
		private static extern RESULT FMOD5_Channel_GetPaused(IntPtr channel, out bool paused);

		[PreserveSig]
		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x14F9510", Offset = "0x14F9510", VA = "0x14F9510")]
		private static extern RESULT FMOD5_Channel_SetVolume(IntPtr channel, float volume);

		[PreserveSig]
		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x14F95A8", Offset = "0x14F95A8", VA = "0x14F95A8")]
		private static extern RESULT FMOD5_Channel_GetVolume(IntPtr channel, out float volume);

		[PreserveSig]
		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x14F9644", Offset = "0x14F9644", VA = "0x14F9644")]
		private static extern RESULT FMOD5_Channel_SetVolumeRamp(IntPtr channel, bool ramp);

		[PreserveSig]
		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x14F96DC", Offset = "0x14F96DC", VA = "0x14F96DC")]
		private static extern RESULT FMOD5_Channel_GetVolumeRamp(IntPtr channel, out bool ramp);

		[PreserveSig]
		[Token(Token = "0x6000400")]
		[Address(RVA = "0x14F9788", Offset = "0x14F9788", VA = "0x14F9788")]
		private static extern RESULT FMOD5_Channel_GetAudibility(IntPtr channel, out float audibility);

		[PreserveSig]
		[Token(Token = "0x6000401")]
		[Address(RVA = "0x14F9820", Offset = "0x14F9820", VA = "0x14F9820")]
		private static extern RESULT FMOD5_Channel_SetPitch(IntPtr channel, float pitch);

		[PreserveSig]
		[Token(Token = "0x6000402")]
		[Address(RVA = "0x14F98B8", Offset = "0x14F98B8", VA = "0x14F98B8")]
		private static extern RESULT FMOD5_Channel_GetPitch(IntPtr channel, out float pitch);

		[PreserveSig]
		[Token(Token = "0x6000403")]
		[Address(RVA = "0x14F9954", Offset = "0x14F9954", VA = "0x14F9954")]
		private static extern RESULT FMOD5_Channel_SetMute(IntPtr channel, bool mute);

		[PreserveSig]
		[Token(Token = "0x6000404")]
		[Address(RVA = "0x14F99EC", Offset = "0x14F99EC", VA = "0x14F99EC")]
		private static extern RESULT FMOD5_Channel_GetMute(IntPtr channel, out bool mute);

		[PreserveSig]
		[Token(Token = "0x6000405")]
		[Address(RVA = "0x14F9A98", Offset = "0x14F9A98", VA = "0x14F9A98")]
		private static extern RESULT FMOD5_Channel_SetReverbProperties(IntPtr channel, int instance, float wet);

		[PreserveSig]
		[Token(Token = "0x6000406")]
		[Address(RVA = "0x14F9B40", Offset = "0x14F9B40", VA = "0x14F9B40")]
		private static extern RESULT FMOD5_Channel_GetReverbProperties(IntPtr channel, int instance, out float wet);

		[PreserveSig]
		[Token(Token = "0x6000407")]
		[Address(RVA = "0x14F9BE0", Offset = "0x14F9BE0", VA = "0x14F9BE0")]
		private static extern RESULT FMOD5_Channel_SetLowPassGain(IntPtr channel, float gain);

		[PreserveSig]
		[Token(Token = "0x6000408")]
		[Address(RVA = "0x14F9C78", Offset = "0x14F9C78", VA = "0x14F9C78")]
		private static extern RESULT FMOD5_Channel_GetLowPassGain(IntPtr channel, out float gain);

		[PreserveSig]
		[Token(Token = "0x6000409")]
		[Address(RVA = "0x14F9D10", Offset = "0x14F9D10", VA = "0x14F9D10")]
		private static extern RESULT FMOD5_Channel_SetMode(IntPtr channel, MODE mode);

		[PreserveSig]
		[Token(Token = "0x600040A")]
		[Address(RVA = "0x14F9DA8", Offset = "0x14F9DA8", VA = "0x14F9DA8")]
		private static extern RESULT FMOD5_Channel_GetMode(IntPtr channel, out MODE mode);

		[PreserveSig]
		[Token(Token = "0x600040B")]
		[Address(RVA = "0x14F9E40", Offset = "0x14F9E40", VA = "0x14F9E40")]
		private static extern RESULT FMOD5_Channel_SetCallback(IntPtr channel, CHANNELCONTROL_CALLBACK callback);

		[PreserveSig]
		[Token(Token = "0x600040C")]
		[Address(RVA = "0x14F9EE0", Offset = "0x14F9EE0", VA = "0x14F9EE0")]
		private static extern RESULT FMOD5_Channel_IsPlaying(IntPtr channel, out bool isplaying);

		[PreserveSig]
		[Token(Token = "0x600040D")]
		[Address(RVA = "0x14F9F8C", Offset = "0x14F9F8C", VA = "0x14F9F8C")]
		private static extern RESULT FMOD5_Channel_SetPan(IntPtr channel, float pan);

		[PreserveSig]
		[Token(Token = "0x600040E")]
		[Address(RVA = "0x14FA024", Offset = "0x14FA024", VA = "0x14FA024")]
		private static extern RESULT FMOD5_Channel_SetMixLevelsOutput(IntPtr channel, float frontleft, float frontright, float center, float lfe, float surroundleft, float surroundright, float backleft, float backright);

		[PreserveSig]
		[Token(Token = "0x600040F")]
		[Address(RVA = "0x14FA10C", Offset = "0x14FA10C", VA = "0x14FA10C")]
		private static extern RESULT FMOD5_Channel_SetMixLevelsInput(IntPtr channel, float[] levels, int numlevels);

		[PreserveSig]
		[Token(Token = "0x6000410")]
		[Address(RVA = "0x14FA1B4", Offset = "0x14FA1B4", VA = "0x14FA1B4")]
		private static extern RESULT FMOD5_Channel_SetMixMatrix(IntPtr channel, float[] matrix, int outchannels, int inchannels, int inchannel_hop);

		[PreserveSig]
		[Token(Token = "0x6000411")]
		[Address(RVA = "0x14FA274", Offset = "0x14FA274", VA = "0x14FA274")]
		private static extern RESULT FMOD5_Channel_GetMixMatrix(IntPtr channel, float[] matrix, out int outchannels, out int inchannels, int inchannel_hop);

		[PreserveSig]
		[Token(Token = "0x6000412")]
		[Address(RVA = "0x14FA334", Offset = "0x14FA334", VA = "0x14FA334")]
		private static extern RESULT FMOD5_Channel_GetDSPClock(IntPtr channel, out ulong dspclock, out ulong parentclock);

		[PreserveSig]
		[Token(Token = "0x6000413")]
		[Address(RVA = "0x14FA3D8", Offset = "0x14FA3D8", VA = "0x14FA3D8")]
		private static extern RESULT FMOD5_Channel_SetDelay(IntPtr channel, ulong dspclock_start, ulong dspclock_end, bool stopchannels);

		[PreserveSig]
		[Token(Token = "0x6000414")]
		[Address(RVA = "0x14FA4E0", Offset = "0x14FA4E0", VA = "0x14FA4E0")]
		private static extern RESULT FMOD5_Channel_GetDelay(IntPtr channel, out ulong dspclock_start, out ulong dspclock_end, IntPtr zero);

		[PreserveSig]
		[Token(Token = "0x6000415")]
		[Address(RVA = "0x14FA590", Offset = "0x14FA590", VA = "0x14FA590")]
		private static extern RESULT FMOD5_Channel_GetDelay(IntPtr channel, out ulong dspclock_start, out ulong dspclock_end, out bool stopchannels);

		[PreserveSig]
		[Token(Token = "0x6000416")]
		[Address(RVA = "0x14FA654", Offset = "0x14FA654", VA = "0x14FA654")]
		private static extern RESULT FMOD5_Channel_AddFadePoint(IntPtr channel, ulong dspclock, float volume);

		[PreserveSig]
		[Token(Token = "0x6000417")]
		[Address(RVA = "0x14FA6FC", Offset = "0x14FA6FC", VA = "0x14FA6FC")]
		private static extern RESULT FMOD5_Channel_SetFadePointRamp(IntPtr channel, ulong dspclock, float volume);

		[PreserveSig]
		[Token(Token = "0x6000418")]
		[Address(RVA = "0x14FA7A4", Offset = "0x14FA7A4", VA = "0x14FA7A4")]
		private static extern RESULT FMOD5_Channel_RemoveFadePoints(IntPtr channel, ulong dspclock_start, ulong dspclock_end);

		[PreserveSig]
		[Token(Token = "0x6000419")]
		[Address(RVA = "0x14FA844", Offset = "0x14FA844", VA = "0x14FA844")]
		private static extern RESULT FMOD5_Channel_GetFadePoints(IntPtr channel, ref uint numpoints, ulong[] point_dspclock, float[] point_volume);

		[PreserveSig]
		[Token(Token = "0x600041A")]
		[Address(RVA = "0x14FA904", Offset = "0x14FA904", VA = "0x14FA904")]
		private static extern RESULT FMOD5_Channel_GetDSP(IntPtr channel, int index, out IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x600041B")]
		[Address(RVA = "0x14FA9A0", Offset = "0x14FA9A0", VA = "0x14FA9A0")]
		private static extern RESULT FMOD5_Channel_AddDSP(IntPtr channel, int index, IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x600041C")]
		[Address(RVA = "0x14FAA3C", Offset = "0x14FAA3C", VA = "0x14FAA3C")]
		private static extern RESULT FMOD5_Channel_RemoveDSP(IntPtr channel, IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x600041D")]
		[Address(RVA = "0x14FAAD4", Offset = "0x14FAAD4", VA = "0x14FAAD4")]
		private static extern RESULT FMOD5_Channel_GetNumDSPs(IntPtr channel, out int numdsps);

		[PreserveSig]
		[Token(Token = "0x600041E")]
		[Address(RVA = "0x14FAB6C", Offset = "0x14FAB6C", VA = "0x14FAB6C")]
		private static extern RESULT FMOD5_Channel_SetDSPIndex(IntPtr channel, IntPtr dsp, int index);

		[PreserveSig]
		[Token(Token = "0x600041F")]
		[Address(RVA = "0x14FAC0C", Offset = "0x14FAC0C", VA = "0x14FAC0C")]
		private static extern RESULT FMOD5_Channel_GetDSPIndex(IntPtr channel, IntPtr dsp, out int index);

		[PreserveSig]
		[Token(Token = "0x6000420")]
		[Address(RVA = "0x14FACAC", Offset = "0x14FACAC", VA = "0x14FACAC")]
		private static extern RESULT FMOD5_Channel_Set3DAttributes(IntPtr channel, ref VECTOR pos, ref VECTOR vel);

		[PreserveSig]
		[Token(Token = "0x6000421")]
		[Address(RVA = "0x14FAD4C", Offset = "0x14FAD4C", VA = "0x14FAD4C")]
		private static extern RESULT FMOD5_Channel_Get3DAttributes(IntPtr channel, out VECTOR pos, out VECTOR vel);

		[PreserveSig]
		[Token(Token = "0x6000422")]
		[Address(RVA = "0x14FADEC", Offset = "0x14FADEC", VA = "0x14FADEC")]
		private static extern RESULT FMOD5_Channel_Set3DMinMaxDistance(IntPtr channel, float mindistance, float maxdistance);

		[PreserveSig]
		[Token(Token = "0x6000423")]
		[Address(RVA = "0x14FAE8C", Offset = "0x14FAE8C", VA = "0x14FAE8C")]
		private static extern RESULT FMOD5_Channel_Get3DMinMaxDistance(IntPtr channel, out float mindistance, out float maxdistance);

		[PreserveSig]
		[Token(Token = "0x6000424")]
		[Address(RVA = "0x14FAF2C", Offset = "0x14FAF2C", VA = "0x14FAF2C")]
		private static extern RESULT FMOD5_Channel_Set3DConeSettings(IntPtr channel, float insideconeangle, float outsideconeangle, float outsidevolume);

		[PreserveSig]
		[Token(Token = "0x6000425")]
		[Address(RVA = "0x14FAFDC", Offset = "0x14FAFDC", VA = "0x14FAFDC")]
		private static extern RESULT FMOD5_Channel_Get3DConeSettings(IntPtr channel, out float insideconeangle, out float outsideconeangle, out float outsidevolume);

		[PreserveSig]
		[Token(Token = "0x6000426")]
		[Address(RVA = "0x14FB08C", Offset = "0x14FB08C", VA = "0x14FB08C")]
		private static extern RESULT FMOD5_Channel_Set3DConeOrientation(IntPtr channel, ref VECTOR orientation);

		[PreserveSig]
		[Token(Token = "0x6000427")]
		[Address(RVA = "0x14FB124", Offset = "0x14FB124", VA = "0x14FB124")]
		private static extern RESULT FMOD5_Channel_Get3DConeOrientation(IntPtr channel, out VECTOR orientation);

		[PreserveSig]
		[Token(Token = "0x6000428")]
		[Address(RVA = "0x14FB1BC", Offset = "0x14FB1BC", VA = "0x14FB1BC")]
		private static extern RESULT FMOD5_Channel_Set3DCustomRolloff(IntPtr channel, ref VECTOR points, int numpoints);

		[PreserveSig]
		[Token(Token = "0x6000429")]
		[Address(RVA = "0x14FB25C", Offset = "0x14FB25C", VA = "0x14FB25C")]
		private static extern RESULT FMOD5_Channel_Get3DCustomRolloff(IntPtr channel, out IntPtr points, out int numpoints);

		[PreserveSig]
		[Token(Token = "0x600042A")]
		[Address(RVA = "0x14FB2FC", Offset = "0x14FB2FC", VA = "0x14FB2FC")]
		private static extern RESULT FMOD5_Channel_Set3DOcclusion(IntPtr channel, float directocclusion, float reverbocclusion);

		[PreserveSig]
		[Token(Token = "0x600042B")]
		[Address(RVA = "0x14FB39C", Offset = "0x14FB39C", VA = "0x14FB39C")]
		private static extern RESULT FMOD5_Channel_Get3DOcclusion(IntPtr channel, out float directocclusion, out float reverbocclusion);

		[PreserveSig]
		[Token(Token = "0x600042C")]
		[Address(RVA = "0x14FB43C", Offset = "0x14FB43C", VA = "0x14FB43C")]
		private static extern RESULT FMOD5_Channel_Set3DSpread(IntPtr channel, float angle);

		[PreserveSig]
		[Token(Token = "0x600042D")]
		[Address(RVA = "0x14FB4D4", Offset = "0x14FB4D4", VA = "0x14FB4D4")]
		private static extern RESULT FMOD5_Channel_Get3DSpread(IntPtr channel, out float angle);

		[PreserveSig]
		[Token(Token = "0x600042E")]
		[Address(RVA = "0x14FB56C", Offset = "0x14FB56C", VA = "0x14FB56C")]
		private static extern RESULT FMOD5_Channel_Set3DLevel(IntPtr channel, float level);

		[PreserveSig]
		[Token(Token = "0x600042F")]
		[Address(RVA = "0x14FB604", Offset = "0x14FB604", VA = "0x14FB604")]
		private static extern RESULT FMOD5_Channel_Get3DLevel(IntPtr channel, out float level);

		[PreserveSig]
		[Token(Token = "0x6000430")]
		[Address(RVA = "0x14FB69C", Offset = "0x14FB69C", VA = "0x14FB69C")]
		private static extern RESULT FMOD5_Channel_Set3DDopplerLevel(IntPtr channel, float level);

		[PreserveSig]
		[Token(Token = "0x6000431")]
		[Address(RVA = "0x14FB734", Offset = "0x14FB734", VA = "0x14FB734")]
		private static extern RESULT FMOD5_Channel_Get3DDopplerLevel(IntPtr channel, out float level);

		[PreserveSig]
		[Token(Token = "0x6000432")]
		[Address(RVA = "0x14FB7D0", Offset = "0x14FB7D0", VA = "0x14FB7D0")]
		private static extern RESULT FMOD5_Channel_Set3DDistanceFilter(IntPtr channel, bool custom, float customLevel, float centerFreq);

		[PreserveSig]
		[Token(Token = "0x6000433")]
		[Address(RVA = "0x14FB880", Offset = "0x14FB880", VA = "0x14FB880")]
		private static extern RESULT FMOD5_Channel_Get3DDistanceFilter(IntPtr channel, out bool custom, out float customLevel, out float centerFreq);

		[PreserveSig]
		[Token(Token = "0x6000434")]
		[Address(RVA = "0x14FB944", Offset = "0x14FB944", VA = "0x14FB944")]
		private static extern RESULT FMOD5_Channel_SetUserData(IntPtr channel, IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x6000435")]
		[Address(RVA = "0x14FB9DC", Offset = "0x14FB9DC", VA = "0x14FB9DC")]
		private static extern RESULT FMOD5_Channel_GetUserData(IntPtr channel, out IntPtr userdata);

		[Token(Token = "0x6000436")]
		[Address(RVA = "0x8F09EC", Offset = "0x8F09EC", VA = "0x8F09EC")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0x8F09F4", Offset = "0x8F09F4", VA = "0x8F09F4")]
		public void clearHandle()
		{
		}
	}
	[Token(Token = "0x200008E")]
	public struct ChannelGroup : IChannelControl
	{
		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x6000438")]
		[Address(RVA = "0x8F0A38", Offset = "0x8F0A38", VA = "0x8F0A38")]
		public RESULT release()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0x8F0A40", Offset = "0x8F0A40", VA = "0x8F0A40")]
		public RESULT addGroup(ChannelGroup group, bool propagatedspclock = true)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0x8F0A4C", Offset = "0x8F0A4C", VA = "0x8F0A4C")]
		public RESULT addGroup(ChannelGroup group, bool propagatedspclock, out DSPConnection connection)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x8F0A58", Offset = "0x8F0A58", VA = "0x8F0A58")]
		public RESULT getNumGroups(out int numgroups)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0x8F0A60", Offset = "0x8F0A60", VA = "0x8F0A60")]
		public RESULT getGroup(int index, out ChannelGroup group)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0x8F0A68", Offset = "0x8F0A68", VA = "0x8F0A68")]
		public RESULT getParentGroup(out ChannelGroup group)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0x8F0A70", Offset = "0x8F0A70", VA = "0x8F0A70")]
		public RESULT getName(out string name, int namelen)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0x8F0A78", Offset = "0x8F0A78", VA = "0x8F0A78")]
		public RESULT getNumChannels(out int numchannels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0x8F0A80", Offset = "0x8F0A80", VA = "0x8F0A80")]
		public RESULT getChannel(int index, out Channel channel)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0x8F0A88", Offset = "0x8F0A88", VA = "0x8F0A88", Slot = "4")]
		public RESULT getSystemObject(out System system)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0x8F0A90", Offset = "0x8F0A90", VA = "0x8F0A90", Slot = "5")]
		public RESULT stop()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0x8F0A98", Offset = "0x8F0A98", VA = "0x8F0A98", Slot = "6")]
		public RESULT setPaused(bool paused)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0x8F0AA4", Offset = "0x8F0AA4", VA = "0x8F0AA4", Slot = "7")]
		public RESULT getPaused(out bool paused)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0x8F0AAC", Offset = "0x8F0AAC", VA = "0x8F0AAC", Slot = "8")]
		public RESULT setVolume(float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0x8F0AB4", Offset = "0x8F0AB4", VA = "0x8F0AB4", Slot = "9")]
		public RESULT getVolume(out float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0x8F0ABC", Offset = "0x8F0ABC", VA = "0x8F0ABC", Slot = "10")]
		public RESULT setVolumeRamp(bool ramp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0x8F0AC8", Offset = "0x8F0AC8", VA = "0x8F0AC8", Slot = "11")]
		public RESULT getVolumeRamp(out bool ramp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0x8F0AD0", Offset = "0x8F0AD0", VA = "0x8F0AD0", Slot = "12")]
		public RESULT getAudibility(out float audibility)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x8F0AD8", Offset = "0x8F0AD8", VA = "0x8F0AD8", Slot = "13")]
		public RESULT setPitch(float pitch)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0x8F0AE0", Offset = "0x8F0AE0", VA = "0x8F0AE0", Slot = "14")]
		public RESULT getPitch(out float pitch)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0x8F0AE8", Offset = "0x8F0AE8", VA = "0x8F0AE8", Slot = "15")]
		public RESULT setMute(bool mute)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0x8F0AF4", Offset = "0x8F0AF4", VA = "0x8F0AF4", Slot = "16")]
		public RESULT getMute(out bool mute)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0x8F0AFC", Offset = "0x8F0AFC", VA = "0x8F0AFC", Slot = "17")]
		public RESULT setReverbProperties(int instance, float wet)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x8F0B04", Offset = "0x8F0B04", VA = "0x8F0B04", Slot = "18")]
		public RESULT getReverbProperties(int instance, out float wet)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0x8F0B0C", Offset = "0x8F0B0C", VA = "0x8F0B0C", Slot = "19")]
		public RESULT setLowPassGain(float gain)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0x8F0B14", Offset = "0x8F0B14", VA = "0x8F0B14", Slot = "20")]
		public RESULT getLowPassGain(out float gain)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0x8F0B1C", Offset = "0x8F0B1C", VA = "0x8F0B1C", Slot = "21")]
		public RESULT setMode(MODE mode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0x8F0B24", Offset = "0x8F0B24", VA = "0x8F0B24", Slot = "22")]
		public RESULT getMode(out MODE mode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0x8F0B2C", Offset = "0x8F0B2C", VA = "0x8F0B2C", Slot = "23")]
		public RESULT setCallback(CHANNELCONTROL_CALLBACK callback)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0x8F0B34", Offset = "0x8F0B34", VA = "0x8F0B34", Slot = "24")]
		public RESULT isPlaying(out bool isplaying)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0x8F0B3C", Offset = "0x8F0B3C", VA = "0x8F0B3C", Slot = "25")]
		public RESULT setPan(float pan)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0x8F0B44", Offset = "0x8F0B44", VA = "0x8F0B44", Slot = "26")]
		public RESULT setMixLevelsOutput(float frontleft, float frontright, float center, float lfe, float surroundleft, float surroundright, float backleft, float backright)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0x8F0B4C", Offset = "0x8F0B4C", VA = "0x8F0B4C", Slot = "27")]
		public RESULT setMixLevelsInput(float[] levels, int numlevels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x8F0B54", Offset = "0x8F0B54", VA = "0x8F0B54", Slot = "28")]
		public RESULT setMixMatrix(float[] matrix, int outchannels, int inchannels, int inchannel_hop)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0x8F0B5C", Offset = "0x8F0B5C", VA = "0x8F0B5C", Slot = "29")]
		public RESULT getMixMatrix(float[] matrix, out int outchannels, out int inchannels, int inchannel_hop)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0x8F0B64", Offset = "0x8F0B64", VA = "0x8F0B64", Slot = "30")]
		public RESULT getDSPClock(out ulong dspclock, out ulong parentclock)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0x8F0B6C", Offset = "0x8F0B6C", VA = "0x8F0B6C", Slot = "31")]
		public RESULT setDelay(ulong dspclock_start, ulong dspclock_end, bool stopchannels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0x8F0B78", Offset = "0x8F0B78", VA = "0x8F0B78", Slot = "32")]
		public RESULT getDelay(out ulong dspclock_start, out ulong dspclock_end)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0x8F0B80", Offset = "0x8F0B80", VA = "0x8F0B80", Slot = "33")]
		public RESULT getDelay(out ulong dspclock_start, out ulong dspclock_end, out bool stopchannels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0x8F0B88", Offset = "0x8F0B88", VA = "0x8F0B88", Slot = "34")]
		public RESULT addFadePoint(ulong dspclock, float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0x8F0B90", Offset = "0x8F0B90", VA = "0x8F0B90", Slot = "35")]
		public RESULT setFadePointRamp(ulong dspclock, float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0x8F0B98", Offset = "0x8F0B98", VA = "0x8F0B98", Slot = "36")]
		public RESULT removeFadePoints(ulong dspclock_start, ulong dspclock_end)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0x8F0BA0", Offset = "0x8F0BA0", VA = "0x8F0BA0", Slot = "37")]
		public RESULT getFadePoints(ref uint numpoints, ulong[] point_dspclock, float[] point_volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0x8F0BA8", Offset = "0x8F0BA8", VA = "0x8F0BA8", Slot = "38")]
		public RESULT getDSP(int index, out DSP dsp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0x8F0BB0", Offset = "0x8F0BB0", VA = "0x8F0BB0", Slot = "39")]
		public RESULT addDSP(int index, DSP dsp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0x8F0BB8", Offset = "0x8F0BB8", VA = "0x8F0BB8", Slot = "40")]
		public RESULT removeDSP(DSP dsp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0x8F0BC0", Offset = "0x8F0BC0", VA = "0x8F0BC0", Slot = "41")]
		public RESULT getNumDSPs(out int numdsps)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0x8F0BC8", Offset = "0x8F0BC8", VA = "0x8F0BC8", Slot = "42")]
		public RESULT setDSPIndex(DSP dsp, int index)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0x8F0BD0", Offset = "0x8F0BD0", VA = "0x8F0BD0", Slot = "43")]
		public RESULT getDSPIndex(DSP dsp, out int index)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0x8F0BD8", Offset = "0x8F0BD8", VA = "0x8F0BD8", Slot = "44")]
		public RESULT set3DAttributes(ref VECTOR pos, ref VECTOR vel)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0x8F0BE0", Offset = "0x8F0BE0", VA = "0x8F0BE0", Slot = "45")]
		public RESULT get3DAttributes(out VECTOR pos, out VECTOR vel)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0x8F0BE8", Offset = "0x8F0BE8", VA = "0x8F0BE8", Slot = "46")]
		public RESULT set3DMinMaxDistance(float mindistance, float maxdistance)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0x8F0BF0", Offset = "0x8F0BF0", VA = "0x8F0BF0", Slot = "47")]
		public RESULT get3DMinMaxDistance(out float mindistance, out float maxdistance)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0x8F0BF8", Offset = "0x8F0BF8", VA = "0x8F0BF8", Slot = "48")]
		public RESULT set3DConeSettings(float insideconeangle, float outsideconeangle, float outsidevolume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0x8F0C00", Offset = "0x8F0C00", VA = "0x8F0C00", Slot = "49")]
		public RESULT get3DConeSettings(out float insideconeangle, out float outsideconeangle, out float outsidevolume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0x8F0C08", Offset = "0x8F0C08", VA = "0x8F0C08", Slot = "50")]
		public RESULT set3DConeOrientation(ref VECTOR orientation)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0x8F0C10", Offset = "0x8F0C10", VA = "0x8F0C10", Slot = "51")]
		public RESULT get3DConeOrientation(out VECTOR orientation)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0x8F0C18", Offset = "0x8F0C18", VA = "0x8F0C18", Slot = "52")]
		public RESULT set3DCustomRolloff(ref VECTOR points, int numpoints)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x8F0C20", Offset = "0x8F0C20", VA = "0x8F0C20", Slot = "53")]
		public RESULT get3DCustomRolloff(out IntPtr points, out int numpoints)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0x8F0C28", Offset = "0x8F0C28", VA = "0x8F0C28", Slot = "54")]
		public RESULT set3DOcclusion(float directocclusion, float reverbocclusion)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0x8F0C30", Offset = "0x8F0C30", VA = "0x8F0C30", Slot = "55")]
		public RESULT get3DOcclusion(out float directocclusion, out float reverbocclusion)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x8F0C38", Offset = "0x8F0C38", VA = "0x8F0C38", Slot = "56")]
		public RESULT set3DSpread(float angle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x8F0C40", Offset = "0x8F0C40", VA = "0x8F0C40", Slot = "57")]
		public RESULT get3DSpread(out float angle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x8F0C48", Offset = "0x8F0C48", VA = "0x8F0C48", Slot = "58")]
		public RESULT set3DLevel(float level)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x8F0C50", Offset = "0x8F0C50", VA = "0x8F0C50", Slot = "59")]
		public RESULT get3DLevel(out float level)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0x8F0C58", Offset = "0x8F0C58", VA = "0x8F0C58", Slot = "60")]
		public RESULT set3DDopplerLevel(float level)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0x8F0C60", Offset = "0x8F0C60", VA = "0x8F0C60", Slot = "61")]
		public RESULT get3DDopplerLevel(out float level)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0x8F0C68", Offset = "0x8F0C68", VA = "0x8F0C68", Slot = "62")]
		public RESULT set3DDistanceFilter(bool custom, float customLevel, float centerFreq)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0x8F0C74", Offset = "0x8F0C74", VA = "0x8F0C74", Slot = "63")]
		public RESULT get3DDistanceFilter(out bool custom, out float customLevel, out float centerFreq)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0x8F0C7C", Offset = "0x8F0C7C", VA = "0x8F0C7C", Slot = "64")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0x8F0C84", Offset = "0x8F0C84", VA = "0x8F0C84", Slot = "65")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x600047F")]
		[Address(RVA = "0x14FBB04", Offset = "0x14FBB04", VA = "0x14FBB04")]
		private static extern RESULT FMOD5_ChannelGroup_Release(IntPtr channelgroup);

		[PreserveSig]
		[Token(Token = "0x6000480")]
		[Address(RVA = "0x14FBBE4", Offset = "0x14FBBE4", VA = "0x14FBBE4")]
		private static extern RESULT FMOD5_ChannelGroup_AddGroup(IntPtr channelgroup, IntPtr group, bool propagatedspclock, IntPtr zero);

		[PreserveSig]
		[Token(Token = "0x6000481")]
		[Address(RVA = "0x14FBC98", Offset = "0x14FBC98", VA = "0x14FBC98")]
		private static extern RESULT FMOD5_ChannelGroup_AddGroup(IntPtr channelgroup, IntPtr group, bool propagatedspclock, out IntPtr connection);

		[PreserveSig]
		[Token(Token = "0x6000482")]
		[Address(RVA = "0x14FBD48", Offset = "0x14FBD48", VA = "0x14FBD48")]
		private static extern RESULT FMOD5_ChannelGroup_GetNumGroups(IntPtr channelgroup, out int numgroups);

		[PreserveSig]
		[Token(Token = "0x6000483")]
		[Address(RVA = "0x14FBDE0", Offset = "0x14FBDE0", VA = "0x14FBDE0")]
		private static extern RESULT FMOD5_ChannelGroup_GetGroup(IntPtr channelgroup, int index, out IntPtr group);

		[PreserveSig]
		[Token(Token = "0x6000484")]
		[Address(RVA = "0x14FBE80", Offset = "0x14FBE80", VA = "0x14FBE80")]
		private static extern RESULT FMOD5_ChannelGroup_GetParentGroup(IntPtr channelgroup, out IntPtr group);

		[PreserveSig]
		[Token(Token = "0x6000485")]
		[Address(RVA = "0x14FC0C4", Offset = "0x14FC0C4", VA = "0x14FC0C4")]
		private static extern RESULT FMOD5_ChannelGroup_GetName(IntPtr channelgroup, IntPtr name, int namelen);

		[PreserveSig]
		[Token(Token = "0x6000486")]
		[Address(RVA = "0x14FC164", Offset = "0x14FC164", VA = "0x14FC164")]
		private static extern RESULT FMOD5_ChannelGroup_GetNumChannels(IntPtr channelgroup, out int numchannels);

		[PreserveSig]
		[Token(Token = "0x6000487")]
		[Address(RVA = "0x14FC1FC", Offset = "0x14FC1FC", VA = "0x14FC1FC")]
		private static extern RESULT FMOD5_ChannelGroup_GetChannel(IntPtr channelgroup, int index, out IntPtr channel);

		[PreserveSig]
		[Token(Token = "0x6000488")]
		[Address(RVA = "0x14FC29C", Offset = "0x14FC29C", VA = "0x14FC29C")]
		private static extern RESULT FMOD5_ChannelGroup_GetSystemObject(IntPtr channelgroup, out IntPtr system);

		[PreserveSig]
		[Token(Token = "0x6000489")]
		[Address(RVA = "0x14FC334", Offset = "0x14FC334", VA = "0x14FC334")]
		private static extern RESULT FMOD5_ChannelGroup_Stop(IntPtr channelgroup);

		[PreserveSig]
		[Token(Token = "0x600048A")]
		[Address(RVA = "0x14FC3C0", Offset = "0x14FC3C0", VA = "0x14FC3C0")]
		private static extern RESULT FMOD5_ChannelGroup_SetPaused(IntPtr channelgroup, bool paused);

		[PreserveSig]
		[Token(Token = "0x600048B")]
		[Address(RVA = "0x14FC458", Offset = "0x14FC458", VA = "0x14FC458")]
		private static extern RESULT FMOD5_ChannelGroup_GetPaused(IntPtr channelgroup, out bool paused);

		[PreserveSig]
		[Token(Token = "0x600048C")]
		[Address(RVA = "0x14FC504", Offset = "0x14FC504", VA = "0x14FC504")]
		private static extern RESULT FMOD5_ChannelGroup_SetVolume(IntPtr channelgroup, float volume);

		[PreserveSig]
		[Token(Token = "0x600048D")]
		[Address(RVA = "0x14FC59C", Offset = "0x14FC59C", VA = "0x14FC59C")]
		private static extern RESULT FMOD5_ChannelGroup_GetVolume(IntPtr channelgroup, out float volume);

		[PreserveSig]
		[Token(Token = "0x600048E")]
		[Address(RVA = "0x14FC638", Offset = "0x14FC638", VA = "0x14FC638")]
		private static extern RESULT FMOD5_ChannelGroup_SetVolumeRamp(IntPtr channelgroup, bool ramp);

		[PreserveSig]
		[Token(Token = "0x600048F")]
		[Address(RVA = "0x14FC6D0", Offset = "0x14FC6D0", VA = "0x14FC6D0")]
		private static extern RESULT FMOD5_ChannelGroup_GetVolumeRamp(IntPtr channelgroup, out bool ramp);

		[PreserveSig]
		[Token(Token = "0x6000490")]
		[Address(RVA = "0x14FC77C", Offset = "0x14FC77C", VA = "0x14FC77C")]
		private static extern RESULT FMOD5_ChannelGroup_GetAudibility(IntPtr channelgroup, out float audibility);

		[PreserveSig]
		[Token(Token = "0x6000491")]
		[Address(RVA = "0x14FC814", Offset = "0x14FC814", VA = "0x14FC814")]
		private static extern RESULT FMOD5_ChannelGroup_SetPitch(IntPtr channelgroup, float pitch);

		[PreserveSig]
		[Token(Token = "0x6000492")]
		[Address(RVA = "0x14FC8AC", Offset = "0x14FC8AC", VA = "0x14FC8AC")]
		private static extern RESULT FMOD5_ChannelGroup_GetPitch(IntPtr channelgroup, out float pitch);

		[PreserveSig]
		[Token(Token = "0x6000493")]
		[Address(RVA = "0x14FC948", Offset = "0x14FC948", VA = "0x14FC948")]
		private static extern RESULT FMOD5_ChannelGroup_SetMute(IntPtr channelgroup, bool mute);

		[PreserveSig]
		[Token(Token = "0x6000494")]
		[Address(RVA = "0x14FC9E0", Offset = "0x14FC9E0", VA = "0x14FC9E0")]
		private static extern RESULT FMOD5_ChannelGroup_GetMute(IntPtr channelgroup, out bool mute);

		[PreserveSig]
		[Token(Token = "0x6000495")]
		[Address(RVA = "0x14FCA8C", Offset = "0x14FCA8C", VA = "0x14FCA8C")]
		private static extern RESULT FMOD5_ChannelGroup_SetReverbProperties(IntPtr channelgroup, int instance, float wet);

		[PreserveSig]
		[Token(Token = "0x6000496")]
		[Address(RVA = "0x14FCB34", Offset = "0x14FCB34", VA = "0x14FCB34")]
		private static extern RESULT FMOD5_ChannelGroup_GetReverbProperties(IntPtr channelgroup, int instance, out float wet);

		[PreserveSig]
		[Token(Token = "0x6000497")]
		[Address(RVA = "0x14FCBD4", Offset = "0x14FCBD4", VA = "0x14FCBD4")]
		private static extern RESULT FMOD5_ChannelGroup_SetLowPassGain(IntPtr channelgroup, float gain);

		[PreserveSig]
		[Token(Token = "0x6000498")]
		[Address(RVA = "0x14FCC6C", Offset = "0x14FCC6C", VA = "0x14FCC6C")]
		private static extern RESULT FMOD5_ChannelGroup_GetLowPassGain(IntPtr channelgroup, out float gain);

		[PreserveSig]
		[Token(Token = "0x6000499")]
		[Address(RVA = "0x14FCD04", Offset = "0x14FCD04", VA = "0x14FCD04")]
		private static extern RESULT FMOD5_ChannelGroup_SetMode(IntPtr channelgroup, MODE mode);

		[PreserveSig]
		[Token(Token = "0x600049A")]
		[Address(RVA = "0x14FCD9C", Offset = "0x14FCD9C", VA = "0x14FCD9C")]
		private static extern RESULT FMOD5_ChannelGroup_GetMode(IntPtr channelgroup, out MODE mode);

		[PreserveSig]
		[Token(Token = "0x600049B")]
		[Address(RVA = "0x14FCE34", Offset = "0x14FCE34", VA = "0x14FCE34")]
		private static extern RESULT FMOD5_ChannelGroup_SetCallback(IntPtr channelgroup, CHANNELCONTROL_CALLBACK callback);

		[PreserveSig]
		[Token(Token = "0x600049C")]
		[Address(RVA = "0x14FCED4", Offset = "0x14FCED4", VA = "0x14FCED4")]
		private static extern RESULT FMOD5_ChannelGroup_IsPlaying(IntPtr channelgroup, out bool isplaying);

		[PreserveSig]
		[Token(Token = "0x600049D")]
		[Address(RVA = "0x14FCF80", Offset = "0x14FCF80", VA = "0x14FCF80")]
		private static extern RESULT FMOD5_ChannelGroup_SetPan(IntPtr channelgroup, float pan);

		[PreserveSig]
		[Token(Token = "0x600049E")]
		[Address(RVA = "0x14FD018", Offset = "0x14FD018", VA = "0x14FD018")]
		private static extern RESULT FMOD5_ChannelGroup_SetMixLevelsOutput(IntPtr channelgroup, float frontleft, float frontright, float center, float lfe, float surroundleft, float surroundright, float backleft, float backright);

		[PreserveSig]
		[Token(Token = "0x600049F")]
		[Address(RVA = "0x14FD100", Offset = "0x14FD100", VA = "0x14FD100")]
		private static extern RESULT FMOD5_ChannelGroup_SetMixLevelsInput(IntPtr channelgroup, float[] levels, int numlevels);

		[PreserveSig]
		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x14FD1A8", Offset = "0x14FD1A8", VA = "0x14FD1A8")]
		private static extern RESULT FMOD5_ChannelGroup_SetMixMatrix(IntPtr channelgroup, float[] matrix, int outchannels, int inchannels, int inchannel_hop);

		[PreserveSig]
		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x14FD268", Offset = "0x14FD268", VA = "0x14FD268")]
		private static extern RESULT FMOD5_ChannelGroup_GetMixMatrix(IntPtr channelgroup, float[] matrix, out int outchannels, out int inchannels, int inchannel_hop);

		[PreserveSig]
		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x14FD328", Offset = "0x14FD328", VA = "0x14FD328")]
		private static extern RESULT FMOD5_ChannelGroup_GetDSPClock(IntPtr channelgroup, out ulong dspclock, out ulong parentclock);

		[PreserveSig]
		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x14FD3CC", Offset = "0x14FD3CC", VA = "0x14FD3CC")]
		private static extern RESULT FMOD5_ChannelGroup_SetDelay(IntPtr channelgroup, ulong dspclock_start, ulong dspclock_end, bool stopchannels);

		[PreserveSig]
		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x14FD4D4", Offset = "0x14FD4D4", VA = "0x14FD4D4")]
		private static extern RESULT FMOD5_ChannelGroup_GetDelay(IntPtr channelgroup, out ulong dspclock_start, out ulong dspclock_end, IntPtr zero);

		[PreserveSig]
		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x14FD584", Offset = "0x14FD584", VA = "0x14FD584")]
		private static extern RESULT FMOD5_ChannelGroup_GetDelay(IntPtr channelgroup, out ulong dspclock_start, out ulong dspclock_end, out bool stopchannels);

		[PreserveSig]
		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x14FD648", Offset = "0x14FD648", VA = "0x14FD648")]
		private static extern RESULT FMOD5_ChannelGroup_AddFadePoint(IntPtr channelgroup, ulong dspclock, float volume);

		[PreserveSig]
		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x14FD6F0", Offset = "0x14FD6F0", VA = "0x14FD6F0")]
		private static extern RESULT FMOD5_ChannelGroup_SetFadePointRamp(IntPtr channelgroup, ulong dspclock, float volume);

		[PreserveSig]
		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x14FD798", Offset = "0x14FD798", VA = "0x14FD798")]
		private static extern RESULT FMOD5_ChannelGroup_RemoveFadePoints(IntPtr channelgroup, ulong dspclock_start, ulong dspclock_end);

		[PreserveSig]
		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x14FD838", Offset = "0x14FD838", VA = "0x14FD838")]
		private static extern RESULT FMOD5_ChannelGroup_GetFadePoints(IntPtr channelgroup, ref uint numpoints, ulong[] point_dspclock, float[] point_volume);

		[PreserveSig]
		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x14FD8F4", Offset = "0x14FD8F4", VA = "0x14FD8F4")]
		private static extern RESULT FMOD5_ChannelGroup_GetDSP(IntPtr channelgroup, int index, out IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x14FD994", Offset = "0x14FD994", VA = "0x14FD994")]
		private static extern RESULT FMOD5_ChannelGroup_AddDSP(IntPtr channelgroup, int index, IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x14FDA34", Offset = "0x14FDA34", VA = "0x14FDA34")]
		private static extern RESULT FMOD5_ChannelGroup_RemoveDSP(IntPtr channelgroup, IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x14FDACC", Offset = "0x14FDACC", VA = "0x14FDACC")]
		private static extern RESULT FMOD5_ChannelGroup_GetNumDSPs(IntPtr channelgroup, out int numdsps);

		[PreserveSig]
		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x14FDB64", Offset = "0x14FDB64", VA = "0x14FDB64")]
		private static extern RESULT FMOD5_ChannelGroup_SetDSPIndex(IntPtr channelgroup, IntPtr dsp, int index);

		[PreserveSig]
		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x14FDC04", Offset = "0x14FDC04", VA = "0x14FDC04")]
		private static extern RESULT FMOD5_ChannelGroup_GetDSPIndex(IntPtr channelgroup, IntPtr dsp, out int index);

		[PreserveSig]
		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x14FDCA4", Offset = "0x14FDCA4", VA = "0x14FDCA4")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DAttributes(IntPtr channelgroup, ref VECTOR pos, ref VECTOR vel);

		[PreserveSig]
		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x14FDD44", Offset = "0x14FDD44", VA = "0x14FDD44")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DAttributes(IntPtr channelgroup, out VECTOR pos, out VECTOR vel);

		[PreserveSig]
		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x14FDDE4", Offset = "0x14FDDE4", VA = "0x14FDDE4")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DMinMaxDistance(IntPtr channelgroup, float mindistance, float maxdistance);

		[PreserveSig]
		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x14FDE84", Offset = "0x14FDE84", VA = "0x14FDE84")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DMinMaxDistance(IntPtr channelgroup, out float mindistance, out float maxdistance);

		[PreserveSig]
		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x14FDF24", Offset = "0x14FDF24", VA = "0x14FDF24")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DConeSettings(IntPtr channelgroup, float insideconeangle, float outsideconeangle, float outsidevolume);

		[PreserveSig]
		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x14FDFD4", Offset = "0x14FDFD4", VA = "0x14FDFD4")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DConeSettings(IntPtr channelgroup, out float insideconeangle, out float outsideconeangle, out float outsidevolume);

		[PreserveSig]
		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x14FE084", Offset = "0x14FE084", VA = "0x14FE084")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DConeOrientation(IntPtr channelgroup, ref VECTOR orientation);

		[PreserveSig]
		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x14FE11C", Offset = "0x14FE11C", VA = "0x14FE11C")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DConeOrientation(IntPtr channelgroup, out VECTOR orientation);

		[PreserveSig]
		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x14FE1B4", Offset = "0x14FE1B4", VA = "0x14FE1B4")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DCustomRolloff(IntPtr channelgroup, ref VECTOR points, int numpoints);

		[PreserveSig]
		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x14FE254", Offset = "0x14FE254", VA = "0x14FE254")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DCustomRolloff(IntPtr channelgroup, out IntPtr points, out int numpoints);

		[PreserveSig]
		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x14FE2F4", Offset = "0x14FE2F4", VA = "0x14FE2F4")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DOcclusion(IntPtr channelgroup, float directocclusion, float reverbocclusion);

		[PreserveSig]
		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x14FE394", Offset = "0x14FE394", VA = "0x14FE394")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DOcclusion(IntPtr channelgroup, out float directocclusion, out float reverbocclusion);

		[PreserveSig]
		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x14FE434", Offset = "0x14FE434", VA = "0x14FE434")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DSpread(IntPtr channelgroup, float angle);

		[PreserveSig]
		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x14FE4CC", Offset = "0x14FE4CC", VA = "0x14FE4CC")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DSpread(IntPtr channelgroup, out float angle);

		[PreserveSig]
		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x14FE564", Offset = "0x14FE564", VA = "0x14FE564")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DLevel(IntPtr channelgroup, float level);

		[PreserveSig]
		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x14FE5FC", Offset = "0x14FE5FC", VA = "0x14FE5FC")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DLevel(IntPtr channelgroup, out float level);

		[PreserveSig]
		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x14FE694", Offset = "0x14FE694", VA = "0x14FE694")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DDopplerLevel(IntPtr channelgroup, float level);

		[PreserveSig]
		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x14FE72C", Offset = "0x14FE72C", VA = "0x14FE72C")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DDopplerLevel(IntPtr channelgroup, out float level);

		[PreserveSig]
		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x14FE7C8", Offset = "0x14FE7C8", VA = "0x14FE7C8")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DDistanceFilter(IntPtr channelgroup, bool custom, float customLevel, float centerFreq);

		[PreserveSig]
		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x14FE878", Offset = "0x14FE878", VA = "0x14FE878")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DDistanceFilter(IntPtr channelgroup, out bool custom, out float customLevel, out float centerFreq);

		[PreserveSig]
		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x14FE93C", Offset = "0x14FE93C", VA = "0x14FE93C")]
		private static extern RESULT FMOD5_ChannelGroup_SetUserData(IntPtr channelgroup, IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x14FE9D4", Offset = "0x14FE9D4", VA = "0x14FE9D4")]
		private static extern RESULT FMOD5_ChannelGroup_GetUserData(IntPtr channelgroup, out IntPtr userdata);

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x8F0C8C", Offset = "0x8F0C8C", VA = "0x8F0C8C")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x8F0C94", Offset = "0x8F0C94", VA = "0x8F0C94")]
		public void clearHandle()
		{
		}
	}
	[Token(Token = "0x200008F")]
	public struct SoundGroup
	{
		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x8F2B58", Offset = "0x8F2B58", VA = "0x8F2B58")]
		public RESULT release()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x8F2B60", Offset = "0x8F2B60", VA = "0x8F2B60")]
		public RESULT getSystemObject(out System system)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x8F2B68", Offset = "0x8F2B68", VA = "0x8F2B68")]
		public RESULT setMaxAudible(int maxaudible)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x8F2B70", Offset = "0x8F2B70", VA = "0x8F2B70")]
		public RESULT getMaxAudible(out int maxaudible)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x8F2B78", Offset = "0x8F2B78", VA = "0x8F2B78")]
		public RESULT setMaxAudibleBehavior(SOUNDGROUP_BEHAVIOR behavior)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x8F2B80", Offset = "0x8F2B80", VA = "0x8F2B80")]
		public RESULT getMaxAudibleBehavior(out SOUNDGROUP_BEHAVIOR behavior)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x8F2B88", Offset = "0x8F2B88", VA = "0x8F2B88")]
		public RESULT setMuteFadeSpeed(float speed)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x8F2B90", Offset = "0x8F2B90", VA = "0x8F2B90")]
		public RESULT getMuteFadeSpeed(out float speed)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x8F2B98", Offset = "0x8F2B98", VA = "0x8F2B98")]
		public RESULT setVolume(float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x8F2BA0", Offset = "0x8F2BA0", VA = "0x8F2BA0")]
		public RESULT getVolume(out float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x8F2BA8", Offset = "0x8F2BA8", VA = "0x8F2BA8")]
		public RESULT stop()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x8F2BB0", Offset = "0x8F2BB0", VA = "0x8F2BB0")]
		public RESULT getName(out string name, int namelen)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x8F2BB8", Offset = "0x8F2BB8", VA = "0x8F2BB8")]
		public RESULT getNumSounds(out int numsounds)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x8F2BC0", Offset = "0x8F2BC0", VA = "0x8F2BC0")]
		public RESULT getSound(int index, out Sound sound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x8F2BC8", Offset = "0x8F2BC8", VA = "0x8F2BC8")]
		public RESULT getNumPlaying(out int numplaying)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x8F2BD0", Offset = "0x8F2BD0", VA = "0x8F2BD0")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x8F2BD8", Offset = "0x8F2BD8", VA = "0x8F2BD8")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x1511F6C", Offset = "0x1511F6C", VA = "0x1511F6C")]
		private static extern RESULT FMOD5_SoundGroup_Release(IntPtr soundgroup);

		[PreserveSig]
		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x1511FF4", Offset = "0x1511FF4", VA = "0x1511FF4")]
		private static extern RESULT FMOD5_SoundGroup_GetSystemObject(IntPtr soundgroup, out IntPtr system);

		[PreserveSig]
		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x151208C", Offset = "0x151208C", VA = "0x151208C")]
		private static extern RESULT FMOD5_SoundGroup_SetMaxAudible(IntPtr soundgroup, int maxaudible);

		[PreserveSig]
		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x1512124", Offset = "0x1512124", VA = "0x1512124")]
		private static extern RESULT FMOD5_SoundGroup_GetMaxAudible(IntPtr soundgroup, out int maxaudible);

		[PreserveSig]
		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x15121BC", Offset = "0x15121BC", VA = "0x15121BC")]
		private static extern RESULT FMOD5_SoundGroup_SetMaxAudibleBehavior(IntPtr soundgroup, SOUNDGROUP_BEHAVIOR behavior);

		[PreserveSig]
		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x1512254", Offset = "0x1512254", VA = "0x1512254")]
		private static extern RESULT FMOD5_SoundGroup_GetMaxAudibleBehavior(IntPtr soundgroup, out SOUNDGROUP_BEHAVIOR behavior);

		[PreserveSig]
		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x15122EC", Offset = "0x15122EC", VA = "0x15122EC")]
		private static extern RESULT FMOD5_SoundGroup_SetMuteFadeSpeed(IntPtr soundgroup, float speed);

		[PreserveSig]
		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x1512384", Offset = "0x1512384", VA = "0x1512384")]
		private static extern RESULT FMOD5_SoundGroup_GetMuteFadeSpeed(IntPtr soundgroup, out float speed);

		[PreserveSig]
		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x151241C", Offset = "0x151241C", VA = "0x151241C")]
		private static extern RESULT FMOD5_SoundGroup_SetVolume(IntPtr soundgroup, float volume);

		[PreserveSig]
		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x15124B4", Offset = "0x15124B4", VA = "0x15124B4")]
		private static extern RESULT FMOD5_SoundGroup_GetVolume(IntPtr soundgroup, out float volume);

		[PreserveSig]
		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x151254C", Offset = "0x151254C", VA = "0x151254C")]
		private static extern RESULT FMOD5_SoundGroup_Stop(IntPtr soundgroup);

		[PreserveSig]
		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x1512778", Offset = "0x1512778", VA = "0x1512778")]
		private static extern RESULT FMOD5_SoundGroup_GetName(IntPtr soundgroup, IntPtr name, int namelen);

		[PreserveSig]
		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x1512818", Offset = "0x1512818", VA = "0x1512818")]
		private static extern RESULT FMOD5_SoundGroup_GetNumSounds(IntPtr soundgroup, out int numsounds);

		[PreserveSig]
		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x15128B0", Offset = "0x15128B0", VA = "0x15128B0")]
		private static extern RESULT FMOD5_SoundGroup_GetSound(IntPtr soundgroup, int index, out IntPtr sound);

		[PreserveSig]
		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x1512950", Offset = "0x1512950", VA = "0x1512950")]
		private static extern RESULT FMOD5_SoundGroup_GetNumPlaying(IntPtr soundgroup, out int numplaying);

		[PreserveSig]
		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x15129E8", Offset = "0x15129E8", VA = "0x15129E8")]
		private static extern RESULT FMOD5_SoundGroup_SetUserData(IntPtr soundgroup, IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x1512A80", Offset = "0x1512A80", VA = "0x1512A80")]
		private static extern RESULT FMOD5_SoundGroup_GetUserData(IntPtr soundgroup, out IntPtr userdata);

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x8F2BE0", Offset = "0x8F2BE0", VA = "0x8F2BE0")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x8F2BE8", Offset = "0x8F2BE8", VA = "0x8F2BE8")]
		public void clearHandle()
		{
		}
	}
	[Token(Token = "0x2000090")]
	public struct DSP
	{
		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x8F0CF8", Offset = "0x8F0CF8", VA = "0x8F0CF8")]
		public RESULT release()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x8F0D00", Offset = "0x8F0D00", VA = "0x8F0D00")]
		public RESULT getSystemObject(out System system)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x8F0D08", Offset = "0x8F0D08", VA = "0x8F0D08")]
		public RESULT addInput(DSP input)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x8F0D10", Offset = "0x8F0D10", VA = "0x8F0D10")]
		public RESULT addInput(DSP input, out DSPConnection connection, DSPCONNECTION_TYPE type = DSPCONNECTION_TYPE.STANDARD)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x8F0D18", Offset = "0x8F0D18", VA = "0x8F0D18")]
		public RESULT disconnectFrom(DSP target, DSPConnection connection)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x8F0D20", Offset = "0x8F0D20", VA = "0x8F0D20")]
		public RESULT disconnectAll(bool inputs, bool outputs)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x8F0D30", Offset = "0x8F0D30", VA = "0x8F0D30")]
		public RESULT getNumInputs(out int numinputs)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x8F0D38", Offset = "0x8F0D38", VA = "0x8F0D38")]
		public RESULT getNumOutputs(out int numoutputs)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x8F0D40", Offset = "0x8F0D40", VA = "0x8F0D40")]
		public RESULT getInput(int index, out DSP input, out DSPConnection inputconnection)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x8F0D48", Offset = "0x8F0D48", VA = "0x8F0D48")]
		public RESULT getOutput(int index, out DSP output, out DSPConnection outputconnection)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x8F0D50", Offset = "0x8F0D50", VA = "0x8F0D50")]
		public RESULT setActive(bool active)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x8F0D5C", Offset = "0x8F0D5C", VA = "0x8F0D5C")]
		public RESULT getActive(out bool active)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x8F0D64", Offset = "0x8F0D64", VA = "0x8F0D64")]
		public RESULT setBypass(bool bypass)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x8F0D70", Offset = "0x8F0D70", VA = "0x8F0D70")]
		public RESULT getBypass(out bool bypass)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x8F0D78", Offset = "0x8F0D78", VA = "0x8F0D78")]
		public RESULT setWetDryMix(float prewet, float postwet, float dry)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x8F0D80", Offset = "0x8F0D80", VA = "0x8F0D80")]
		public RESULT getWetDryMix(out float prewet, out float postwet, out float dry)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x8F0D88", Offset = "0x8F0D88", VA = "0x8F0D88")]
		public RESULT setChannelFormat(CHANNELMASK channelmask, int numchannels, SPEAKERMODE source_speakermode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x8F0D90", Offset = "0x8F0D90", VA = "0x8F0D90")]
		public RESULT getChannelFormat(out CHANNELMASK channelmask, out int numchannels, out SPEAKERMODE source_speakermode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x8F0D98", Offset = "0x8F0D98", VA = "0x8F0D98")]
		public RESULT getOutputChannelFormat(CHANNELMASK inmask, int inchannels, SPEAKERMODE inspeakermode, out CHANNELMASK outmask, out int outchannels, out SPEAKERMODE outspeakermode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x8F0DA0", Offset = "0x8F0DA0", VA = "0x8F0DA0")]
		public RESULT reset()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x8F0DA8", Offset = "0x8F0DA8", VA = "0x8F0DA8")]
		public RESULT setParameterFloat(int index, float value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x8F0DB0", Offset = "0x8F0DB0", VA = "0x8F0DB0")]
		public RESULT setParameterInt(int index, int value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x8F0DB8", Offset = "0x8F0DB8", VA = "0x8F0DB8")]
		public RESULT setParameterBool(int index, bool value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x8F0DC4", Offset = "0x8F0DC4", VA = "0x8F0DC4")]
		public RESULT setParameterData(int index, byte[] data)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x8F0DCC", Offset = "0x8F0DCC", VA = "0x8F0DCC")]
		public RESULT getParameterFloat(int index, out float value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x8F0DD4", Offset = "0x8F0DD4", VA = "0x8F0DD4")]
		public RESULT getParameterInt(int index, out int value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x8F0DDC", Offset = "0x8F0DDC", VA = "0x8F0DDC")]
		public RESULT getParameterBool(int index, out bool value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x8F0DE4", Offset = "0x8F0DE4", VA = "0x8F0DE4")]
		public RESULT getParameterData(int index, out IntPtr data, out uint length)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x8F0DEC", Offset = "0x8F0DEC", VA = "0x8F0DEC")]
		public RESULT getNumParameters(out int numparams)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0x8F0DF4", Offset = "0x8F0DF4", VA = "0x8F0DF4")]
		public RESULT getParameterInfo(int index, out DSP_PARAMETER_DESC desc)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0x8F0DFC", Offset = "0x8F0DFC", VA = "0x8F0DFC")]
		public RESULT getDataParameterIndex(int datatype, out int index)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0x8F0E04", Offset = "0x8F0E04", VA = "0x8F0E04")]
		public RESULT showConfigDialog(IntPtr hwnd, bool show)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0x8F0E10", Offset = "0x8F0E10", VA = "0x8F0E10")]
		public RESULT getInfo(out string name, out uint version, out int channels, out int configwidth, out int configheight)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0x8F0E18", Offset = "0x8F0E18", VA = "0x8F0E18")]
		public RESULT getInfo(out uint version, out int channels, out int configwidth, out int configheight)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x8F0E20", Offset = "0x8F0E20", VA = "0x8F0E20")]
		public RESULT getType(out DSP_TYPE type)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x8F0E28", Offset = "0x8F0E28", VA = "0x8F0E28")]
		public RESULT getIdle(out bool idle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x8F0E30", Offset = "0x8F0E30", VA = "0x8F0E30")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x8F0E38", Offset = "0x8F0E38", VA = "0x8F0E38")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0x8F0E40", Offset = "0x8F0E40", VA = "0x8F0E40")]
		public RESULT setMeteringEnabled(bool inputEnabled, bool outputEnabled)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0x8F0E50", Offset = "0x8F0E50", VA = "0x8F0E50")]
		public RESULT getMeteringEnabled(out bool inputEnabled, out bool outputEnabled)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0x8F0E58", Offset = "0x8F0E58", VA = "0x8F0E58")]
		public RESULT getMeteringInfo(IntPtr zero, out DSP_METERING_INFO outputInfo)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0x8F0E60", Offset = "0x8F0E60", VA = "0x8F0E60")]
		public RESULT getMeteringInfo(out DSP_METERING_INFO inputInfo, IntPtr zero)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0x8F0E68", Offset = "0x8F0E68", VA = "0x8F0E68")]
		public RESULT getMeteringInfo(out DSP_METERING_INFO inputInfo, out DSP_METERING_INFO outputInfo)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0x8F0E70", Offset = "0x8F0E70", VA = "0x8F0E70")]
		public RESULT getCPUUsage(out uint exclusive, out uint inclusive)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000518")]
		[Address(RVA = "0x14FEF24", Offset = "0x14FEF24", VA = "0x14FEF24")]
		private static extern RESULT FMOD5_DSP_Release(IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x6000519")]
		[Address(RVA = "0x14FEFAC", Offset = "0x14FEFAC", VA = "0x14FEFAC")]
		private static extern RESULT FMOD5_DSP_GetSystemObject(IntPtr dsp, out IntPtr system);

		[PreserveSig]
		[Token(Token = "0x600051A")]
		[Address(RVA = "0x14FF098", Offset = "0x14FF098", VA = "0x14FF098")]
		private static extern RESULT FMOD5_DSP_AddInput(IntPtr dsp, IntPtr input, IntPtr zero, DSPCONNECTION_TYPE type);

		[PreserveSig]
		[Token(Token = "0x600051B")]
		[Address(RVA = "0x14FF148", Offset = "0x14FF148", VA = "0x14FF148")]
		private static extern RESULT FMOD5_DSP_AddInput(IntPtr dsp, IntPtr input, out IntPtr connection, DSPCONNECTION_TYPE type);

		[PreserveSig]
		[Token(Token = "0x600051C")]
		[Address(RVA = "0x14FF1F8", Offset = "0x14FF1F8", VA = "0x14FF1F8")]
		private static extern RESULT FMOD5_DSP_DisconnectFrom(IntPtr dsp, IntPtr target, IntPtr connection);

		[PreserveSig]
		[Token(Token = "0x600051D")]
		[Address(RVA = "0x14FF29C", Offset = "0x14FF29C", VA = "0x14FF29C")]
		private static extern RESULT FMOD5_DSP_DisconnectAll(IntPtr dsp, bool inputs, bool outputs);

		[PreserveSig]
		[Token(Token = "0x600051E")]
		[Address(RVA = "0x14FF33C", Offset = "0x14FF33C", VA = "0x14FF33C")]
		private static extern RESULT FMOD5_DSP_GetNumInputs(IntPtr dsp, out int numinputs);

		[PreserveSig]
		[Token(Token = "0x600051F")]
		[Address(RVA = "0x14FF3D4", Offset = "0x14FF3D4", VA = "0x14FF3D4")]
		private static extern RESULT FMOD5_DSP_GetNumOutputs(IntPtr dsp, out int numoutputs);

		[PreserveSig]
		[Token(Token = "0x6000520")]
		[Address(RVA = "0x14FF46C", Offset = "0x14FF46C", VA = "0x14FF46C")]
		private static extern RESULT FMOD5_DSP_GetInput(IntPtr dsp, int index, out IntPtr input, out IntPtr inputconnection);

		[PreserveSig]
		[Token(Token = "0x6000521")]
		[Address(RVA = "0x14FF51C", Offset = "0x14FF51C", VA = "0x14FF51C")]
		private static extern RESULT FMOD5_DSP_GetOutput(IntPtr dsp, int index, out IntPtr output, out IntPtr outputconnection);

		[PreserveSig]
		[Token(Token = "0x6000522")]
		[Address(RVA = "0x14FF5D0", Offset = "0x14FF5D0", VA = "0x14FF5D0")]
		private static extern RESULT FMOD5_DSP_SetActive(IntPtr dsp, bool active);

		[PreserveSig]
		[Token(Token = "0x6000523")]
		[Address(RVA = "0x14FF668", Offset = "0x14FF668", VA = "0x14FF668")]
		private static extern RESULT FMOD5_DSP_GetActive(IntPtr dsp, out bool active);

		[PreserveSig]
		[Token(Token = "0x6000524")]
		[Address(RVA = "0x14FF718", Offset = "0x14FF718", VA = "0x14FF718")]
		private static extern RESULT FMOD5_DSP_SetBypass(IntPtr dsp, bool bypass);

		[PreserveSig]
		[Token(Token = "0x6000525")]
		[Address(RVA = "0x14FF7B0", Offset = "0x14FF7B0", VA = "0x14FF7B0")]
		private static extern RESULT FMOD5_DSP_GetBypass(IntPtr dsp, out bool bypass);

		[PreserveSig]
		[Token(Token = "0x6000526")]
		[Address(RVA = "0x14FF85C", Offset = "0x14FF85C", VA = "0x14FF85C")]
		private static extern RESULT FMOD5_DSP_SetWetDryMix(IntPtr dsp, float prewet, float postwet, float dry);

		[PreserveSig]
		[Token(Token = "0x6000527")]
		[Address(RVA = "0x14FF90C", Offset = "0x14FF90C", VA = "0x14FF90C")]
		private static extern RESULT FMOD5_DSP_GetWetDryMix(IntPtr dsp, out float prewet, out float postwet, out float dry);

		[PreserveSig]
		[Token(Token = "0x6000528")]
		[Address(RVA = "0x14FF9BC", Offset = "0x14FF9BC", VA = "0x14FF9BC")]
		private static extern RESULT FMOD5_DSP_SetChannelFormat(IntPtr dsp, CHANNELMASK channelmask, int numchannels, SPEAKERMODE source_speakermode);

		[PreserveSig]
		[Token(Token = "0x6000529")]
		[Address(RVA = "0x14FFA6C", Offset = "0x14FFA6C", VA = "0x14FFA6C")]
		private static extern RESULT FMOD5_DSP_GetChannelFormat(IntPtr dsp, out CHANNELMASK channelmask, out int numchannels, out SPEAKERMODE source_speakermode);

		[PreserveSig]
		[Token(Token = "0x600052A")]
		[Address(RVA = "0x14FFB1C", Offset = "0x14FFB1C", VA = "0x14FFB1C")]
		private static extern RESULT FMOD5_DSP_GetOutputChannelFormat(IntPtr dsp, CHANNELMASK inmask, int inchannels, SPEAKERMODE inspeakermode, out CHANNELMASK outmask, out int outchannels, out SPEAKERMODE outspeakermode);

		[PreserveSig]
		[Token(Token = "0x600052B")]
		[Address(RVA = "0x14FFBEC", Offset = "0x14FFBEC", VA = "0x14FFBEC")]
		private static extern RESULT FMOD5_DSP_Reset(IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x600052C")]
		[Address(RVA = "0x14FFC74", Offset = "0x14FFC74", VA = "0x14FFC74")]
		private static extern RESULT FMOD5_DSP_SetParameterFloat(IntPtr dsp, int index, float value);

		[PreserveSig]
		[Token(Token = "0x600052D")]
		[Address(RVA = "0x14FFD1C", Offset = "0x14FFD1C", VA = "0x14FFD1C")]
		private static extern RESULT FMOD5_DSP_SetParameterInt(IntPtr dsp, int index, int value);

		[PreserveSig]
		[Token(Token = "0x600052E")]
		[Address(RVA = "0x14FFDC0", Offset = "0x14FFDC0", VA = "0x14FFDC0")]
		private static extern RESULT FMOD5_DSP_SetParameterBool(IntPtr dsp, int index, bool value);

		[PreserveSig]
		[Token(Token = "0x600052F")]
		[Address(RVA = "0x14FFEFC", Offset = "0x14FFEFC", VA = "0x14FFEFC")]
		private static extern RESULT FMOD5_DSP_SetParameterData(IntPtr dsp, int index, IntPtr data, uint length);

		[PreserveSig]
		[Token(Token = "0x6000530")]
		[Address(RVA = "0x1500008", Offset = "0x1500008", VA = "0x1500008")]
		private static extern RESULT FMOD5_DSP_GetParameterFloat(IntPtr dsp, int index, out float value, IntPtr valuestr, int valuestrlen);

		[PreserveSig]
		[Token(Token = "0x6000531")]
		[Address(RVA = "0x150011C", Offset = "0x150011C", VA = "0x150011C")]
		private static extern RESULT FMOD5_DSP_GetParameterInt(IntPtr dsp, int index, out int value, IntPtr valuestr, int valuestrlen);

		[PreserveSig]
		[Token(Token = "0x6000532")]
		[Address(RVA = "0x1500230", Offset = "0x1500230", VA = "0x1500230")]
		private static extern RESULT FMOD5_DSP_GetParameterBool(IntPtr dsp, int index, out bool value, IntPtr valuestr, int valuestrlen);

		[PreserveSig]
		[Token(Token = "0x6000533")]
		[Address(RVA = "0x1500368", Offset = "0x1500368", VA = "0x1500368")]
		private static extern RESULT FMOD5_DSP_GetParameterData(IntPtr dsp, int index, out IntPtr data, out uint length, IntPtr valuestr, int valuestrlen);

		[PreserveSig]
		[Token(Token = "0x6000534")]
		[Address(RVA = "0x1500430", Offset = "0x1500430", VA = "0x1500430")]
		private static extern RESULT FMOD5_DSP_GetNumParameters(IntPtr dsp, out int numparams);

		[PreserveSig]
		[Token(Token = "0x6000535")]
		[Address(RVA = "0x15004C8", Offset = "0x15004C8", VA = "0x15004C8")]
		private static extern RESULT FMOD5_DSP_GetParameterInfo(IntPtr dsp, int index, out DSP_PARAMETER_DESC desc);

		[PreserveSig]
		[Token(Token = "0x6000536")]
		[Address(RVA = "0x15005BC", Offset = "0x15005BC", VA = "0x15005BC")]
		private static extern RESULT FMOD5_DSP_GetDataParameterIndex(IntPtr dsp, int datatype, out int index);

		[PreserveSig]
		[Token(Token = "0x6000537")]
		[Address(RVA = "0x1500660", Offset = "0x1500660", VA = "0x1500660")]
		private static extern RESULT FMOD5_DSP_ShowConfigDialog(IntPtr dsp, IntPtr hwnd, bool show);

		[PreserveSig]
		[Token(Token = "0x6000538")]
		[Address(RVA = "0x15008CC", Offset = "0x15008CC", VA = "0x15008CC")]
		private static extern RESULT FMOD5_DSP_GetInfo(IntPtr dsp, IntPtr name, out uint version, out int channels, out int configwidth, out int configheight);

		[PreserveSig]
		[Token(Token = "0x6000539")]
		[Address(RVA = "0x1500A0C", Offset = "0x1500A0C", VA = "0x1500A0C")]
		private static extern RESULT FMOD5_DSP_GetType(IntPtr dsp, out DSP_TYPE type);

		[PreserveSig]
		[Token(Token = "0x600053A")]
		[Address(RVA = "0x1500AA4", Offset = "0x1500AA4", VA = "0x1500AA4")]
		private static extern RESULT FMOD5_DSP_GetIdle(IntPtr dsp, out bool idle);

		[PreserveSig]
		[Token(Token = "0x600053B")]
		[Address(RVA = "0x1500B50", Offset = "0x1500B50", VA = "0x1500B50")]
		private static extern RESULT FMOD5_DSP_SetUserData(IntPtr dsp, IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x600053C")]
		[Address(RVA = "0x1500BE8", Offset = "0x1500BE8", VA = "0x1500BE8")]
		private static extern RESULT FMOD5_DSP_GetUserData(IntPtr dsp, out IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x600053D")]
		[Address(RVA = "0x1500C88", Offset = "0x1500C88", VA = "0x1500C88")]
		public static extern RESULT FMOD5_DSP_SetMeteringEnabled(IntPtr dsp, bool inputEnabled, bool outputEnabled);

		[PreserveSig]
		[Token(Token = "0x600053E")]
		[Address(RVA = "0x1500D28", Offset = "0x1500D28", VA = "0x1500D28")]
		public static extern RESULT FMOD5_DSP_GetMeteringEnabled(IntPtr dsp, out bool inputEnabled, out bool outputEnabled);

		[PreserveSig]
		[Token(Token = "0x600053F")]
		[Address(RVA = "0x1500DEC", Offset = "0x1500DEC", VA = "0x1500DEC")]
		public static extern RESULT FMOD5_DSP_GetMeteringInfo(IntPtr dsp, IntPtr zero, out DSP_METERING_INFO outputInfo);

		[PreserveSig]
		[Token(Token = "0x6000540")]
		[Address(RVA = "0x1500ED0", Offset = "0x1500ED0", VA = "0x1500ED0")]
		public static extern RESULT FMOD5_DSP_GetMeteringInfo(IntPtr dsp, out DSP_METERING_INFO inputInfo, IntPtr zero);

		[PreserveSig]
		[Token(Token = "0x6000541")]
		[Address(RVA = "0x1500FB4", Offset = "0x1500FB4", VA = "0x1500FB4")]
		public static extern RESULT FMOD5_DSP_GetMeteringInfo(IntPtr dsp, out DSP_METERING_INFO inputInfo, out DSP_METERING_INFO outputInfo);

		[PreserveSig]
		[Token(Token = "0x6000542")]
		[Address(RVA = "0x15010B8", Offset = "0x15010B8", VA = "0x15010B8")]
		public static extern RESULT FMOD5_DSP_GetCPUUsage(IntPtr dsp, out uint exclusive, out uint inclusive);

		[Token(Token = "0x6000543")]
		[Address(RVA = "0x8F1098", Offset = "0x8F1098", VA = "0x8F1098")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0x8F10A0", Offset = "0x8F10A0", VA = "0x8F10A0")]
		public void clearHandle()
		{
		}
	}
	[Token(Token = "0x2000091")]
	public struct DSPConnection
	{
		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x6000545")]
		[Address(RVA = "0x8F10E4", Offset = "0x8F10E4", VA = "0x8F10E4")]
		public RESULT getInput(out DSP input)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0x8F10EC", Offset = "0x8F10EC", VA = "0x8F10EC")]
		public RESULT getOutput(out DSP output)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0x8F10F4", Offset = "0x8F10F4", VA = "0x8F10F4")]
		public RESULT setMix(float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0x8F10FC", Offset = "0x8F10FC", VA = "0x8F10FC")]
		public RESULT getMix(out float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0x8F1104", Offset = "0x8F1104", VA = "0x8F1104")]
		public RESULT setMixMatrix(float[] matrix, int outchannels, int inchannels, int inchannel_hop = 0)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0x8F110C", Offset = "0x8F110C", VA = "0x8F110C")]
		public RESULT getMixMatrix(float[] matrix, out int outchannels, out int inchannels, int inchannel_hop = 0)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0x8F1114", Offset = "0x8F1114", VA = "0x8F1114")]
		public RESULT getType(out DSPCONNECTION_TYPE type)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0x8F111C", Offset = "0x8F111C", VA = "0x8F111C")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0x8F1124", Offset = "0x8F1124", VA = "0x8F1124")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x600054E")]
		[Address(RVA = "0x15011E8", Offset = "0x15011E8", VA = "0x15011E8")]
		private static extern RESULT FMOD5_DSPConnection_GetInput(IntPtr dspconnection, out IntPtr input);

		[PreserveSig]
		[Token(Token = "0x600054F")]
		[Address(RVA = "0x1501280", Offset = "0x1501280", VA = "0x1501280")]
		private static extern RESULT FMOD5_DSPConnection_GetOutput(IntPtr dspconnection, out IntPtr output);

		[PreserveSig]
		[Token(Token = "0x6000550")]
		[Address(RVA = "0x1501318", Offset = "0x1501318", VA = "0x1501318")]
		private static extern RESULT FMOD5_DSPConnection_SetMix(IntPtr dspconnection, float volume);

		[PreserveSig]
		[Token(Token = "0x6000551")]
		[Address(RVA = "0x15013B0", Offset = "0x15013B0", VA = "0x15013B0")]
		private static extern RESULT FMOD5_DSPConnection_GetMix(IntPtr dspconnection, out float volume);

		[PreserveSig]
		[Token(Token = "0x6000552")]
		[Address(RVA = "0x1501448", Offset = "0x1501448", VA = "0x1501448")]
		private static extern RESULT FMOD5_DSPConnection_SetMixMatrix(IntPtr dspconnection, float[] matrix, int outchannels, int inchannels, int inchannel_hop);

		[PreserveSig]
		[Token(Token = "0x6000553")]
		[Address(RVA = "0x1501508", Offset = "0x1501508", VA = "0x1501508")]
		private static extern RESULT FMOD5_DSPConnection_GetMixMatrix(IntPtr dspconnection, float[] matrix, out int outchannels, out int inchannels, int inchannel_hop);

		[PreserveSig]
		[Token(Token = "0x6000554")]
		[Address(RVA = "0x15015C8", Offset = "0x15015C8", VA = "0x15015C8")]
		private static extern RESULT FMOD5_DSPConnection_GetType(IntPtr dspconnection, out DSPCONNECTION_TYPE type);

		[PreserveSig]
		[Token(Token = "0x6000555")]
		[Address(RVA = "0x1501660", Offset = "0x1501660", VA = "0x1501660")]
		private static extern RESULT FMOD5_DSPConnection_SetUserData(IntPtr dspconnection, IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x6000556")]
		[Address(RVA = "0x15016F8", Offset = "0x15016F8", VA = "0x15016F8")]
		private static extern RESULT FMOD5_DSPConnection_GetUserData(IntPtr dspconnection, out IntPtr userdata);

		[Token(Token = "0x6000557")]
		[Address(RVA = "0x8F112C", Offset = "0x8F112C", VA = "0x8F112C")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0x8F1134", Offset = "0x8F1134", VA = "0x8F1134")]
		public void clearHandle()
		{
		}
	}
	[Token(Token = "0x2000092")]
	public struct Geometry
	{
		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x6000559")]
		[Address(RVA = "0x8F273C", Offset = "0x8F273C", VA = "0x8F273C")]
		public RESULT release()
		{
			return default(RESULT);
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0x8F2744", Offset = "0x8F2744", VA = "0x8F2744")]
		public RESULT addPolygon(float directocclusion, float reverbocclusion, bool doublesided, int numvertices, VECTOR[] vertices, out int polygonindex)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0x8F2750", Offset = "0x8F2750", VA = "0x8F2750")]
		public RESULT getNumPolygons(out int numpolygons)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0x8F2758", Offset = "0x8F2758", VA = "0x8F2758")]
		public RESULT getMaxPolygons(out int maxpolygons, out int maxvertices)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0x8F2760", Offset = "0x8F2760", VA = "0x8F2760")]
		public RESULT getPolygonNumVertices(int index, out int numvertices)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0x8F2768", Offset = "0x8F2768", VA = "0x8F2768")]
		public RESULT setPolygonVertex(int index, int vertexindex, ref VECTOR vertex)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x8F2770", Offset = "0x8F2770", VA = "0x8F2770")]
		public RESULT getPolygonVertex(int index, int vertexindex, out VECTOR vertex)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x8F2778", Offset = "0x8F2778", VA = "0x8F2778")]
		public RESULT setPolygonAttributes(int index, float directocclusion, float reverbocclusion, bool doublesided)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0x8F2784", Offset = "0x8F2784", VA = "0x8F2784")]
		public RESULT getPolygonAttributes(int index, out float directocclusion, out float reverbocclusion, out bool doublesided)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0x8F278C", Offset = "0x8F278C", VA = "0x8F278C")]
		public RESULT setActive(bool active)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0x8F2798", Offset = "0x8F2798", VA = "0x8F2798")]
		public RESULT getActive(out bool active)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0x8F27A0", Offset = "0x8F27A0", VA = "0x8F27A0")]
		public RESULT setRotation(ref VECTOR forward, ref VECTOR up)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0x8F27A8", Offset = "0x8F27A8", VA = "0x8F27A8")]
		public RESULT getRotation(out VECTOR forward, out VECTOR up)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0x8F27B0", Offset = "0x8F27B0", VA = "0x8F27B0")]
		public RESULT setPosition(ref VECTOR position)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0x8F27B8", Offset = "0x8F27B8", VA = "0x8F27B8")]
		public RESULT getPosition(out VECTOR position)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0x8F27C0", Offset = "0x8F27C0", VA = "0x8F27C0")]
		public RESULT setScale(ref VECTOR scale)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0x8F27C8", Offset = "0x8F27C8", VA = "0x8F27C8")]
		public RESULT getScale(out VECTOR scale)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0x8F27D0", Offset = "0x8F27D0", VA = "0x8F27D0")]
		public RESULT save(IntPtr data, out int datasize)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0x8F27D8", Offset = "0x8F27D8", VA = "0x8F27D8")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0x8F27E0", Offset = "0x8F27E0", VA = "0x8F27E0")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x600056D")]
		[Address(RVA = "0x150C7D4", Offset = "0x150C7D4", VA = "0x150C7D4")]
		private static extern RESULT FMOD5_Geometry_Release(IntPtr geometry);

		[PreserveSig]
		[Token(Token = "0x600056E")]
		[Address(RVA = "0x150C860", Offset = "0x150C860", VA = "0x150C860")]
		private static extern RESULT FMOD5_Geometry_AddPolygon(IntPtr geometry, float directocclusion, float reverbocclusion, bool doublesided, int numvertices, VECTOR[] vertices, out int polygonindex);

		[PreserveSig]
		[Token(Token = "0x600056F")]
		[Address(RVA = "0x150C938", Offset = "0x150C938", VA = "0x150C938")]
		private static extern RESULT FMOD5_Geometry_GetNumPolygons(IntPtr geometry, out int numpolygons);

		[PreserveSig]
		[Token(Token = "0x6000570")]
		[Address(RVA = "0x150C9D0", Offset = "0x150C9D0", VA = "0x150C9D0")]
		private static extern RESULT FMOD5_Geometry_GetMaxPolygons(IntPtr geometry, out int maxpolygons, out int maxvertices);

		[PreserveSig]
		[Token(Token = "0x6000571")]
		[Address(RVA = "0x150CA70", Offset = "0x150CA70", VA = "0x150CA70")]
		private static extern RESULT FMOD5_Geometry_GetPolygonNumVertices(IntPtr geometry, int index, out int numvertices);

		[PreserveSig]
		[Token(Token = "0x6000572")]
		[Address(RVA = "0x150CB10", Offset = "0x150CB10", VA = "0x150CB10")]
		private static extern RESULT FMOD5_Geometry_SetPolygonVertex(IntPtr geometry, int index, int vertexindex, ref VECTOR vertex);

		[PreserveSig]
		[Token(Token = "0x6000573")]
		[Address(RVA = "0x150CBC0", Offset = "0x150CBC0", VA = "0x150CBC0")]
		private static extern RESULT FMOD5_Geometry_GetPolygonVertex(IntPtr geometry, int index, int vertexindex, out VECTOR vertex);

		[PreserveSig]
		[Token(Token = "0x6000574")]
		[Address(RVA = "0x150CC74", Offset = "0x150CC74", VA = "0x150CC74")]
		private static extern RESULT FMOD5_Geometry_SetPolygonAttributes(IntPtr geometry, int index, float directocclusion, float reverbocclusion, bool doublesided);

		[PreserveSig]
		[Token(Token = "0x6000575")]
		[Address(RVA = "0x150CD2C", Offset = "0x150CD2C", VA = "0x150CD2C")]
		private static extern RESULT FMOD5_Geometry_GetPolygonAttributes(IntPtr geometry, int index, out float directocclusion, out float reverbocclusion, out bool doublesided);

		[PreserveSig]
		[Token(Token = "0x6000576")]
		[Address(RVA = "0x150CDFC", Offset = "0x150CDFC", VA = "0x150CDFC")]
		private static extern RESULT FMOD5_Geometry_SetActive(IntPtr geometry, bool active);

		[PreserveSig]
		[Token(Token = "0x6000577")]
		[Address(RVA = "0x150CE94", Offset = "0x150CE94", VA = "0x150CE94")]
		private static extern RESULT FMOD5_Geometry_GetActive(IntPtr geometry, out bool active);

		[PreserveSig]
		[Token(Token = "0x6000578")]
		[Address(RVA = "0x150CF40", Offset = "0x150CF40", VA = "0x150CF40")]
		private static extern RESULT FMOD5_Geometry_SetRotation(IntPtr geometry, ref VECTOR forward, ref VECTOR up);

		[PreserveSig]
		[Token(Token = "0x6000579")]
		[Address(RVA = "0x150CFE0", Offset = "0x150CFE0", VA = "0x150CFE0")]
		private static extern RESULT FMOD5_Geometry_GetRotation(IntPtr geometry, out VECTOR forward, out VECTOR up);

		[PreserveSig]
		[Token(Token = "0x600057A")]
		[Address(RVA = "0x150D080", Offset = "0x150D080", VA = "0x150D080")]
		private static extern RESULT FMOD5_Geometry_SetPosition(IntPtr geometry, ref VECTOR position);

		[PreserveSig]
		[Token(Token = "0x600057B")]
		[Address(RVA = "0x150D118", Offset = "0x150D118", VA = "0x150D118")]
		private static extern RESULT FMOD5_Geometry_GetPosition(IntPtr geometry, out VECTOR position);

		[PreserveSig]
		[Token(Token = "0x600057C")]
		[Address(RVA = "0x150D1B0", Offset = "0x150D1B0", VA = "0x150D1B0")]
		private static extern RESULT FMOD5_Geometry_SetScale(IntPtr geometry, ref VECTOR scale);

		[PreserveSig]
		[Token(Token = "0x600057D")]
		[Address(RVA = "0x150D248", Offset = "0x150D248", VA = "0x150D248")]
		private static extern RESULT FMOD5_Geometry_GetScale(IntPtr geometry, out VECTOR scale);

		[PreserveSig]
		[Token(Token = "0x600057E")]
		[Address(RVA = "0x150D2E0", Offset = "0x150D2E0", VA = "0x150D2E0")]
		private static extern RESULT FMOD5_Geometry_Save(IntPtr geometry, IntPtr data, out int datasize);

		[PreserveSig]
		[Token(Token = "0x600057F")]
		[Address(RVA = "0x150D380", Offset = "0x150D380", VA = "0x150D380")]
		private static extern RESULT FMOD5_Geometry_SetUserData(IntPtr geometry, IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x6000580")]
		[Address(RVA = "0x150D418", Offset = "0x150D418", VA = "0x150D418")]
		private static extern RESULT FMOD5_Geometry_GetUserData(IntPtr geometry, out IntPtr userdata);

		[Token(Token = "0x6000581")]
		[Address(RVA = "0x8F27E8", Offset = "0x8F27E8", VA = "0x8F27E8")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0x8F27F0", Offset = "0x8F27F0", VA = "0x8F27F0")]
		public void clearHandle()
		{
		}
	}
	[Token(Token = "0x2000093")]
	public struct Reverb3D
	{
		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x6000583")]
		[Address(RVA = "0x8F28AC", Offset = "0x8F28AC", VA = "0x8F28AC")]
		public RESULT release()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0x8F28B4", Offset = "0x8F28B4", VA = "0x8F28B4")]
		public RESULT set3DAttributes(ref VECTOR position, float mindistance, float maxdistance)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0x8F28BC", Offset = "0x8F28BC", VA = "0x8F28BC")]
		public RESULT get3DAttributes(ref VECTOR position, ref float mindistance, ref float maxdistance)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0x8F28C4", Offset = "0x8F28C4", VA = "0x8F28C4")]
		public RESULT setProperties(ref REVERB_PROPERTIES properties)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0x8F28CC", Offset = "0x8F28CC", VA = "0x8F28CC")]
		public RESULT getProperties(ref REVERB_PROPERTIES properties)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0x8F28D4", Offset = "0x8F28D4", VA = "0x8F28D4")]
		public RESULT setActive(bool active)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0x8F28E0", Offset = "0x8F28E0", VA = "0x8F28E0")]
		public RESULT getActive(out bool active)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0x8F28E8", Offset = "0x8F28E8", VA = "0x8F28E8")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0x8F28F0", Offset = "0x8F28F0", VA = "0x8F28F0")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x600058C")]
		[Address(RVA = "0x150E554", Offset = "0x150E554", VA = "0x150E554")]
		private static extern RESULT FMOD5_Reverb3D_Release(IntPtr reverb3d);

		[PreserveSig]
		[Token(Token = "0x600058D")]
		[Address(RVA = "0x150E5DC", Offset = "0x150E5DC", VA = "0x150E5DC")]
		private static extern RESULT FMOD5_Reverb3D_Set3DAttributes(IntPtr reverb3d, ref VECTOR position, float mindistance, float maxdistance);

		[PreserveSig]
		[Token(Token = "0x600058E")]
		[Address(RVA = "0x150E68C", Offset = "0x150E68C", VA = "0x150E68C")]
		private static extern RESULT FMOD5_Reverb3D_Get3DAttributes(IntPtr reverb3d, ref VECTOR position, ref float mindistance, ref float maxdistance);

		[PreserveSig]
		[Token(Token = "0x600058F")]
		[Address(RVA = "0x150E73C", Offset = "0x150E73C", VA = "0x150E73C")]
		private static extern RESULT FMOD5_Reverb3D_SetProperties(IntPtr reverb3d, ref REVERB_PROPERTIES properties);

		[PreserveSig]
		[Token(Token = "0x6000590")]
		[Address(RVA = "0x150E7D4", Offset = "0x150E7D4", VA = "0x150E7D4")]
		private static extern RESULT FMOD5_Reverb3D_GetProperties(IntPtr reverb3d, ref REVERB_PROPERTIES properties);

		[PreserveSig]
		[Token(Token = "0x6000591")]
		[Address(RVA = "0x150E870", Offset = "0x150E870", VA = "0x150E870")]
		private static extern RESULT FMOD5_Reverb3D_SetActive(IntPtr reverb3d, bool active);

		[PreserveSig]
		[Token(Token = "0x6000592")]
		[Address(RVA = "0x150E908", Offset = "0x150E908", VA = "0x150E908")]
		private static extern RESULT FMOD5_Reverb3D_GetActive(IntPtr reverb3d, out bool active);

		[PreserveSig]
		[Token(Token = "0x6000593")]
		[Address(RVA = "0x150E9B4", Offset = "0x150E9B4", VA = "0x150E9B4")]
		private static extern RESULT FMOD5_Reverb3D_SetUserData(IntPtr reverb3d, IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x6000594")]
		[Address(RVA = "0x150EA4C", Offset = "0x150EA4C", VA = "0x150EA4C")]
		private static extern RESULT FMOD5_Reverb3D_GetUserData(IntPtr reverb3d, out IntPtr userdata);

		[Token(Token = "0x6000595")]
		[Address(RVA = "0x8F28F8", Offset = "0x8F28F8", VA = "0x8F28F8")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0x8F2900", Offset = "0x8F2900", VA = "0x8F2900")]
		public void clearHandle()
		{
		}
	}
	[Token(Token = "0x2000094")]
	public struct StringWrapper
	{
		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private IntPtr nativeUtf8Ptr;

		[Token(Token = "0x6000597")]
		[Address(RVA = "0x1512E5C", Offset = "0x1512E5C", VA = "0x1512E5C")]
		public static implicit operator string(StringWrapper fstring)
		{
			return null;
		}
	}
	[Token(Token = "0x2000095")]
	internal static class StringHelper
	{
		[Token(Token = "0x20001BD")]
		public class ThreadSafeEncoding : IDisposable
		{
			[Token(Token = "0x40009B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private UTF8Encoding encoding;

			[Token(Token = "0x40009B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private byte[] encodedBuffer;

			[Token(Token = "0x40009B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private char[] decodedBuffer;

			[Token(Token = "0x40009B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private bool inUse;

			[Token(Token = "0x40009B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private GCHandle gcHandle;

			[Token(Token = "0x6000CD9")]
			[Address(RVA = "0x1512CBC", Offset = "0x1512CBC", VA = "0x1512CBC")]
			public bool InUse()
			{
				return default(bool);
			}

			[Token(Token = "0x6000CDA")]
			[Address(RVA = "0x1512C38", Offset = "0x1512C38", VA = "0x1512C38")]
			public void SetInUse()
			{
			}

			[Token(Token = "0x6000CDB")]
			[Address(RVA = "0x1512CC4", Offset = "0x1512CC4", VA = "0x1512CC4")]
			private int roundUpPowerTwo(int number)
			{
				return default(int);
			}

			[Token(Token = "0x6000CDC")]
			[Address(RVA = "0x150ABB4", Offset = "0x150ABB4", VA = "0x150ABB4")]
			public byte[] byteFromStringUTF8(string s)
			{
				return null;
			}

			[Token(Token = "0x6000CDD")]
			[Address(RVA = "0x1512CDC", Offset = "0x1512CDC", VA = "0x1512CDC")]
			public IntPtr intptrFromStringUTF8(string s)
			{
				return default(IntPtr);
			}

			[Token(Token = "0x6000CDE")]
			[Address(RVA = "0x151059C", Offset = "0x151059C", VA = "0x151059C")]
			public string stringFromNative(IntPtr nativePtr)
			{
				return null;
			}

			[Token(Token = "0x6000CDF")]
			[Address(RVA = "0x1512D68", Offset = "0x1512D68", VA = "0x1512D68", Slot = "4")]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000CE0")]
			[Address(RVA = "0x1512BA0", Offset = "0x1512BA0", VA = "0x1512BA0")]
			public ThreadSafeEncoding()
			{
			}
		}

		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<ThreadSafeEncoding> encoders;

		[Token(Token = "0x6000598")]
		[Address(RVA = "0x150A944", Offset = "0x150A944", VA = "0x150A944")]
		public static ThreadSafeEncoding GetFreeHelper()
		{
			return null;
		}
	}
	[Token(Token = "0x2000096")]
	internal static class Android
	{
		[Token(Token = "0x20001BE")]
		public struct THREADAFFINITY
		{
			[Token(Token = "0x40009B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public THREAD mixer;

			[Token(Token = "0x40009B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public THREAD stream;

			[Token(Token = "0x40009BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public THREAD nonblocking;

			[Token(Token = "0x40009BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public THREAD file;

			[Token(Token = "0x40009BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public THREAD geometry;

			[Token(Token = "0x40009BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public THREAD profiler;

			[Token(Token = "0x40009BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public THREAD studioUpdate;

			[Token(Token = "0x40009BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public THREAD studioLoadBank;

			[Token(Token = "0x40009C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public THREAD studioLoadSample;
		}

		[Token(Token = "0x20001BF")]
		[Flags]
		public enum THREAD : uint
		{
			[Token(Token = "0x40009C2")]
			DEFAULT = 0u,
			[Token(Token = "0x40009C3")]
			CORE0 = 1u,
			[Token(Token = "0x40009C4")]
			CORE1 = 2u,
			[Token(Token = "0x40009C5")]
			CORE2 = 4u,
			[Token(Token = "0x40009C6")]
			CORE3 = 8u,
			[Token(Token = "0x40009C7")]
			CORE4 = 0x10u,
			[Token(Token = "0x40009C8")]
			CORE5 = 0x20u,
			[Token(Token = "0x40009C9")]
			CORE6 = 0x40u,
			[Token(Token = "0x40009CA")]
			CORE7 = 0x80u
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0x14F8154", Offset = "0x14F8154", VA = "0x14F8154")]
		public static RESULT setThreadAffinity(ref THREADAFFINITY affinity)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x600059B")]
		[Address(RVA = "0x14F8158", Offset = "0x14F8158", VA = "0x14F8158")]
		private static extern RESULT FMOD_Android_SetThreadAffinity(ref THREADAFFINITY affinity);
	}
	[Token(Token = "0x2000097")]
	public struct DSP_BUFFER_ARRAY
	{
		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int numbuffers;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int[] buffernumchannels;

		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CHANNELMASK[] bufferchannelmask;

		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IntPtr[] buffers;

		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SPEAKERMODE speakermode;
	}
	[Token(Token = "0x2000098")]
	public enum DSP_PROCESS_OPERATION
	{
		[Token(Token = "0x40003E1")]
		PROCESS_PERFORM,
		[Token(Token = "0x40003E2")]
		PROCESS_QUERY
	}
	[Token(Token = "0x2000099")]
	public struct COMPLEX
	{
		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float real;

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float imag;
	}
	[Token(Token = "0x200009A")]
	public enum DSP_PAN_SURROUND_FLAGS
	{
		[Token(Token = "0x40003E6")]
		DEFAULT,
		[Token(Token = "0x40003E7")]
		ROTATION_NOT_BIASED
	}
	[Token(Token = "0x200009B")]
	public delegate RESULT DSP_CREATECALLBACK(ref DSP_STATE dsp_state);
	[Token(Token = "0x200009C")]
	public delegate RESULT DSP_RELEASECALLBACK(ref DSP_STATE dsp_state);
	[Token(Token = "0x200009D")]
	public delegate RESULT DSP_RESETCALLBACK(ref DSP_STATE dsp_state);
	[Token(Token = "0x200009E")]
	public delegate RESULT DSP_SETPOSITIONCALLBACK(ref DSP_STATE dsp_state, uint pos);
	[Token(Token = "0x200009F")]
	public delegate RESULT DSP_READCALLBACK(ref DSP_STATE dsp_state, IntPtr inbuffer, IntPtr outbuffer, uint length, int inchannels, ref int outchannels);
	[Token(Token = "0x20000A0")]
	public delegate RESULT DSP_SHOULDIPROCESS_CALLBACK(ref DSP_STATE dsp_state, bool inputsidle, uint length, CHANNELMASK inmask, int inchannels, SPEAKERMODE speakermode);
	[Token(Token = "0x20000A1")]
	public delegate RESULT DSP_PROCESS_CALLBACK(ref DSP_STATE dsp_state, uint length, ref DSP_BUFFER_ARRAY inbufferarray, ref DSP_BUFFER_ARRAY outbufferarray, bool inputsidle, DSP_PROCESS_OPERATION op);
	[Token(Token = "0x20000A2")]
	public delegate RESULT DSP_SETPARAM_FLOAT_CALLBACK(ref DSP_STATE dsp_state, int index, float value);
	[Token(Token = "0x20000A3")]
	public delegate RESULT DSP_SETPARAM_INT_CALLBACK(ref DSP_STATE dsp_state, int index, int value);
	[Token(Token = "0x20000A4")]
	public delegate RESULT DSP_SETPARAM_BOOL_CALLBACK(ref DSP_STATE dsp_state, int index, bool value);
	[Token(Token = "0x20000A5")]
	public delegate RESULT DSP_SETPARAM_DATA_CALLBACK(ref DSP_STATE dsp_state, int index, IntPtr data, uint length);
	[Token(Token = "0x20000A6")]
	public delegate RESULT DSP_GETPARAM_FLOAT_CALLBACK(ref DSP_STATE dsp_state, int index, ref float value, IntPtr valuestr);
	[Token(Token = "0x20000A7")]
	public delegate RESULT DSP_GETPARAM_INT_CALLBACK(ref DSP_STATE dsp_state, int index, ref int value, IntPtr valuestr);
	[Token(Token = "0x20000A8")]
	public delegate RESULT DSP_GETPARAM_BOOL_CALLBACK(ref DSP_STATE dsp_state, int index, ref bool value, IntPtr valuestr);
	[Token(Token = "0x20000A9")]
	public delegate RESULT DSP_GETPARAM_DATA_CALLBACK(ref DSP_STATE dsp_state, int index, ref IntPtr data, ref uint length, IntPtr valuestr);
	[Token(Token = "0x20000AA")]
	public delegate RESULT DSP_SYSTEM_REGISTER_CALLBACK(ref DSP_STATE dsp_state);
	[Token(Token = "0x20000AB")]
	public delegate RESULT DSP_SYSTEM_DEREGISTER_CALLBACK(ref DSP_STATE dsp_state);
	[Token(Token = "0x20000AC")]
	public delegate RESULT DSP_SYSTEM_MIX_CALLBACK(ref DSP_STATE dsp_state, int stage);
	[Token(Token = "0x20000AD")]
	public delegate IntPtr DSP_ALLOC_FUNC(uint size, MEMORY_TYPE type, StringWrapper sourcestr);
	[Token(Token = "0x20000AE")]
	public delegate IntPtr DSP_REALLOC_FUNC(IntPtr ptr, uint size, MEMORY_TYPE type, StringWrapper sourcestr);
	[Token(Token = "0x20000AF")]
	public delegate void DSP_FREE_FUNC(IntPtr ptr, MEMORY_TYPE type, StringWrapper sourcestr);
	[Token(Token = "0x20000B0")]
	public delegate void DSP_LOG_FUNC(DEBUG_FLAGS level, StringWrapper file, int line, StringWrapper function, StringWrapper format);
	[Token(Token = "0x20000B1")]
	public delegate RESULT DSP_GETSAMPLERATE_FUNC(ref DSP_STATE dsp_state, ref int rate);
	[Token(Token = "0x20000B2")]
	public delegate RESULT DSP_GETBLOCKSIZE_FUNC(ref DSP_STATE dsp_state, ref uint blocksize);
	[Token(Token = "0x20000B3")]
	public delegate RESULT DSP_GETSPEAKERMODE_FUNC(ref DSP_STATE dsp_state, ref int speakermode_mixer, ref int speakermode_output);
	[Token(Token = "0x20000B4")]
	public delegate RESULT DSP_GETCLOCK_FUNC(ref DSP_STATE dsp_state, out ulong clock, out uint offset, out uint length);
	[Token(Token = "0x20000B5")]
	public delegate RESULT DSP_GETLISTENERATTRIBUTES_FUNC(ref DSP_STATE dsp_state, ref int numlisteners, IntPtr attributes);
	[Token(Token = "0x20000B6")]
	public delegate RESULT DSP_GETUSERDATA_FUNC(ref DSP_STATE dsp_state, out IntPtr userdata);
	[Token(Token = "0x20000B7")]
	public delegate RESULT DSP_DFT_FFTREAL_FUNC(ref DSP_STATE dsp_state, int size, IntPtr signal, IntPtr dft, IntPtr window, int signalhop);
	[Token(Token = "0x20000B8")]
	public delegate RESULT DSP_DFT_IFFTREAL_FUNC(ref DSP_STATE dsp_state, int size, IntPtr dft, IntPtr signal, IntPtr window, int signalhop);
	[Token(Token = "0x20000B9")]
	public delegate RESULT DSP_PAN_SUMMONOMATRIX_FUNC(ref DSP_STATE dsp_state, int sourceSpeakerMode, float lowFrequencyGain, float overallGain, IntPtr matrix);
	[Token(Token = "0x20000BA")]
	public delegate RESULT DSP_PAN_SUMSTEREOMATRIX_FUNC(ref DSP_STATE dsp_state, int sourceSpeakerMode, float pan, float lowFrequencyGain, float overallGain, int matrixHop, IntPtr matrix);
	[Token(Token = "0x20000BB")]
	public delegate RESULT DSP_PAN_SUMSURROUNDMATRIX_FUNC(ref DSP_STATE dsp_state, int sourceSpeakerMode, int targetSpeakerMode, float direction, float extent, float rotation, float lowFrequencyGain, float overallGain, int matrixHop, IntPtr matrix, DSP_PAN_SURROUND_FLAGS flags);
	[Token(Token = "0x20000BC")]
	public delegate RESULT DSP_PAN_SUMMONOTOSURROUNDMATRIX_FUNC(ref DSP_STATE dsp_state, int targetSpeakerMode, float direction, float extent, float lowFrequencyGain, float overallGain, int matrixHop, IntPtr matrix);
	[Token(Token = "0x20000BD")]
	public delegate RESULT DSP_PAN_SUMSTEREOTOSURROUNDMATRIX_FUNC(ref DSP_STATE dsp_state, int targetSpeakerMode, float direction, float extent, float rotation, float lowFrequencyGain, float overallGain, int matrixHop, IntPtr matrix);
	[Token(Token = "0x20000BE")]
	public delegate RESULT DSP_PAN_GETROLLOFFGAIN_FUNC(ref DSP_STATE dsp_state, DSP_PAN_3D_ROLLOFF_TYPE rolloff, float distance, float mindistance, float maxdistance, out float gain);
	[Token(Token = "0x20000BF")]
	public enum DSP_TYPE
	{
		[Token(Token = "0x40003E9")]
		UNKNOWN,
		[Token(Token = "0x40003EA")]
		MIXER,
		[Token(Token = "0x40003EB")]
		OSCILLATOR,
		[Token(Token = "0x40003EC")]
		LOWPASS,
		[Token(Token = "0x40003ED")]
		ITLOWPASS,
		[Token(Token = "0x40003EE")]
		HIGHPASS,
		[Token(Token = "0x40003EF")]
		ECHO,
		[Token(Token = "0x40003F0")]
		FADER,
		[Token(Token = "0x40003F1")]
		FLANGE,
		[Token(Token = "0x40003F2")]
		DISTORTION,
		[Token(Token = "0x40003F3")]
		NORMALIZE,
		[Token(Token = "0x40003F4")]
		LIMITER,
		[Token(Token = "0x40003F5")]
		PARAMEQ,
		[Token(Token = "0x40003F6")]
		PITCHSHIFT,
		[Token(Token = "0x40003F7")]
		CHORUS,
		[Token(Token = "0x40003F8")]
		VSTPLUGIN,
		[Token(Token = "0x40003F9")]
		WINAMPPLUGIN,
		[Token(Token = "0x40003FA")]
		ITECHO,
		[Token(Token = "0x40003FB")]
		COMPRESSOR,
		[Token(Token = "0x40003FC")]
		SFXREVERB,
		[Token(Token = "0x40003FD")]
		LOWPASS_SIMPLE,
		[Token(Token = "0x40003FE")]
		DELAY,
		[Token(Token = "0x40003FF")]
		TREMOLO,
		[Token(Token = "0x4000400")]
		LADSPAPLUGIN,
		[Token(Token = "0x4000401")]
		SEND,
		[Token(Token = "0x4000402")]
		RETURN,
		[Token(Token = "0x4000403")]
		HIGHPASS_SIMPLE,
		[Token(Token = "0x4000404")]
		PAN,
		[Token(Token = "0x4000405")]
		THREE_EQ,
		[Token(Token = "0x4000406")]
		FFT,
		[Token(Token = "0x4000407")]
		LOUDNESS_METER,
		[Token(Token = "0x4000408")]
		ENVELOPEFOLLOWER,
		[Token(Token = "0x4000409")]
		CONVOLUTIONREVERB,
		[Token(Token = "0x400040A")]
		CHANNELMIX,
		[Token(Token = "0x400040B")]
		TRANSCEIVER,
		[Token(Token = "0x400040C")]
		OBJECTPAN,
		[Token(Token = "0x400040D")]
		MULTIBAND_EQ,
		[Token(Token = "0x400040E")]
		MAX
	}
	[Token(Token = "0x20000C0")]
	public enum DSP_PARAMETER_TYPE
	{
		[Token(Token = "0x4000410")]
		FLOAT,
		[Token(Token = "0x4000411")]
		INT,
		[Token(Token = "0x4000412")]
		BOOL,
		[Token(Token = "0x4000413")]
		DATA,
		[Token(Token = "0x4000414")]
		MAX
	}
	[Token(Token = "0x20000C1")]
	public enum DSP_PARAMETER_FLOAT_MAPPING_TYPE
	{
		[Token(Token = "0x4000416")]
		DSP_PARAMETER_FLOAT_MAPPING_TYPE_LINEAR,
		[Token(Token = "0x4000417")]
		DSP_PARAMETER_FLOAT_MAPPING_TYPE_AUTO,
		[Token(Token = "0x4000418")]
		DSP_PARAMETER_FLOAT_MAPPING_TYPE_PIECEWISE_LINEAR
	}
	[Token(Token = "0x20000C2")]
	public struct DSP_PARAMETER_FLOAT_MAPPING_PIECEWISE_LINEAR
	{
		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int numpoints;

		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public IntPtr pointparamvalues;

		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IntPtr pointpositions;
	}
	[Token(Token = "0x20000C3")]
	public struct DSP_PARAMETER_FLOAT_MAPPING
	{
		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public DSP_PARAMETER_FLOAT_MAPPING_TYPE type;

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public DSP_PARAMETER_FLOAT_MAPPING_PIECEWISE_LINEAR piecewiselinearmapping;
	}
	[Token(Token = "0x20000C4")]
	public struct DSP_PARAMETER_DESC_FLOAT
	{
		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float min;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float max;

		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float defaultval;

		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public DSP_PARAMETER_FLOAT_MAPPING mapping;
	}
	[Token(Token = "0x20000C5")]
	public struct DSP_PARAMETER_DESC_INT
	{
		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int min;

		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int max;

		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int defaultval;

		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public bool goestoinf;

		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IntPtr valuenames;
	}
	[Token(Token = "0x20000C6")]
	public struct DSP_PARAMETER_DESC_BOOL
	{
		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool defaultval;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public IntPtr valuenames;
	}
	[Token(Token = "0x20000C7")]
	public struct DSP_PARAMETER_DESC_DATA
	{
		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int datatype;
	}
	[StructLayout(2)]
	[Token(Token = "0x20000C8")]
	public struct DSP_PARAMETER_DESC_UNION
	{
		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public DSP_PARAMETER_DESC_FLOAT floatdesc;

		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public DSP_PARAMETER_DESC_INT intdesc;

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public DSP_PARAMETER_DESC_BOOL booldesc;

		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public DSP_PARAMETER_DESC_DATA datadesc;
	}
	[Token(Token = "0x20000C9")]
	public struct DSP_PARAMETER_DESC
	{
		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public DSP_PARAMETER_TYPE type;

		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public char[] name;

		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public char[] label;

		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string description;

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DSP_PARAMETER_DESC_UNION desc;
	}
	[Token(Token = "0x20000CA")]
	public enum DSP_PARAMETER_DATA_TYPE
	{
		[Token(Token = "0x4000434")]
		DSP_PARAMETER_DATA_TYPE_USER = 0,
		[Token(Token = "0x4000435")]
		DSP_PARAMETER_DATA_TYPE_OVERALLGAIN = -1,
		[Token(Token = "0x4000436")]
		DSP_PARAMETER_DATA_TYPE_3DATTRIBUTES = -2,
		[Token(Token = "0x4000437")]
		DSP_PARAMETER_DATA_TYPE_SIDECHAIN = -3,
		[Token(Token = "0x4000438")]
		DSP_PARAMETER_DATA_TYPE_FFT = -4,
		[Token(Token = "0x4000439")]
		DSP_PARAMETER_DATA_TYPE_3DATTRIBUTES_MULTI = -5
	}
	[Token(Token = "0x20000CB")]
	public struct DSP_PARAMETER_OVERALLGAIN
	{
		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float linear_gain;

		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float linear_gain_additive;
	}
	[Token(Token = "0x20000CC")]
	public struct DSP_PARAMETER_3DATTRIBUTES
	{
		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ATTRIBUTES_3D relative;

		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public ATTRIBUTES_3D absolute;
	}
	[Token(Token = "0x20000CD")]
	public struct DSP_PARAMETER_3DATTRIBUTES_MULTI
	{
		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int numlisteners;

		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ATTRIBUTES_3D[] relative;

		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float[] weight;

		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ATTRIBUTES_3D absolute;
	}
	[Token(Token = "0x20000CE")]
	public struct DSP_PARAMETER_SIDECHAIN
	{
		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int sidechainenable;
	}
	[Token(Token = "0x20000CF")]
	public struct DSP_PARAMETER_FFT
	{
		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int length;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int numchannels;

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private IntPtr[] spectrum_internal;

		[Token(Token = "0x1700000D")]
		public float[][] spectrum
		{
			[Token(Token = "0x600062C")]
			[Address(RVA = "0x8F203C", Offset = "0x8F203C", VA = "0x8F203C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600062D")]
		[Address(RVA = "0x8F2044", Offset = "0x8F2044", VA = "0x8F2044")]
		public void getSpectrum(ref float[][] buffer)
		{
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0x8F204C", Offset = "0x8F204C", VA = "0x8F204C")]
		public void getSpectrum(int channel, ref float[] buffer)
		{
		}
	}
	[Token(Token = "0x20000D0")]
	public struct DSP_DESCRIPTION
	{
		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint pluginsdkversion;

		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public char[] name;

		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public uint version;

		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int numinputbuffers;

		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int numoutputbuffers;

		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DSP_CREATECALLBACK create;

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public DSP_RELEASECALLBACK release;

		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public DSP_RESETCALLBACK reset;

		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public DSP_READCALLBACK read;

		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public DSP_PROCESS_CALLBACK process;

		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public DSP_SETPOSITIONCALLBACK setposition;

		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public int numparameters;

		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public IntPtr paramdesc;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public DSP_SETPARAM_FLOAT_CALLBACK setparameterfloat;

		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public DSP_SETPARAM_INT_CALLBACK setparameterint;

		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public DSP_SETPARAM_BOOL_CALLBACK setparameterbool;

		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public DSP_SETPARAM_DATA_CALLBACK setparameterdata;

		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public DSP_GETPARAM_FLOAT_CALLBACK getparameterfloat;

		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public DSP_GETPARAM_INT_CALLBACK getparameterint;

		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public DSP_GETPARAM_BOOL_CALLBACK getparameterbool;

		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public DSP_GETPARAM_DATA_CALLBACK getparameterdata;

		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public DSP_SHOULDIPROCESS_CALLBACK shouldiprocess;

		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public IntPtr userdata;

		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public DSP_SYSTEM_REGISTER_CALLBACK sys_register;

		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public DSP_SYSTEM_DEREGISTER_CALLBACK sys_deregister;

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public DSP_SYSTEM_MIX_CALLBACK sys_mix;
	}
	[Token(Token = "0x20000D1")]
	public struct DSP_STATE_DFT_FUNCTIONS
	{
		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public DSP_DFT_FFTREAL_FUNC fftreal;

		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public DSP_DFT_IFFTREAL_FUNC inversefftreal;
	}
	[Token(Token = "0x20000D2")]
	public struct DSP_STATE_PAN_FUNCTIONS
	{
		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public DSP_PAN_SUMMONOMATRIX_FUNC summonomatrix;

		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public DSP_PAN_SUMSTEREOMATRIX_FUNC sumstereomatrix;

		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public DSP_PAN_SUMSURROUNDMATRIX_FUNC sumsurroundmatrix;

		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public DSP_PAN_SUMMONOTOSURROUNDMATRIX_FUNC summonotosurroundmatrix;

		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DSP_PAN_SUMSTEREOTOSURROUNDMATRIX_FUNC sumstereotosurroundmatrix;

		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public DSP_PAN_GETROLLOFFGAIN_FUNC getrolloffgain;
	}
	[Token(Token = "0x20000D3")]
	public struct DSP_STATE_FUNCTIONS
	{
		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private DSP_ALLOC_FUNC alloc;

		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private DSP_REALLOC_FUNC realloc;

		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private DSP_FREE_FUNC free;

		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private DSP_GETSAMPLERATE_FUNC getsamplerate;

		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private DSP_GETBLOCKSIZE_FUNC getblocksize;

		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IntPtr dft;

		[Token(Token = "0x400046E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private IntPtr pan;

		[Token(Token = "0x400046F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private DSP_GETSPEAKERMODE_FUNC getspeakermode;

		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private DSP_GETCLOCK_FUNC getclock;

		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private DSP_GETLISTENERATTRIBUTES_FUNC getlistenerattributes;

		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private DSP_LOG_FUNC log;

		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private DSP_GETUSERDATA_FUNC getuserdata;
	}
	[Token(Token = "0x20000D4")]
	public struct DSP_STATE
	{
		[Token(Token = "0x4000474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr instance;

		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public IntPtr plugindata;

		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public uint channelmask;

		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int source_speakermode;

		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IntPtr sidechaindata;

		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int sidechainchannels;

		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IntPtr functions;

		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int systemobject;
	}
	[Token(Token = "0x20000D5")]
	public struct DSP_METERING_INFO
	{
		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int numsamples;

		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float[] peaklevel;

		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float[] rmslevel;

		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public short numchannels;
	}
	[Token(Token = "0x20000D6")]
	public enum DSP_OSCILLATOR
	{
		[Token(Token = "0x4000481")]
		TYPE,
		[Token(Token = "0x4000482")]
		RATE
	}
	[Token(Token = "0x20000D7")]
	public enum DSP_LOWPASS
	{
		[Token(Token = "0x4000484")]
		CUTOFF,
		[Token(Token = "0x4000485")]
		RESONANCE
	}
	[Token(Token = "0x20000D8")]
	public enum DSP_ITLOWPASS
	{
		[Token(Token = "0x4000487")]
		CUTOFF,
		[Token(Token = "0x4000488")]
		RESONANCE
	}
	[Token(Token = "0x20000D9")]
	public enum DSP_HIGHPASS
	{
		[Token(Token = "0x400048A")]
		CUTOFF,
		[Token(Token = "0x400048B")]
		RESONANCE
	}
	[Token(Token = "0x20000DA")]
	public enum DSP_ECHO
	{
		[Token(Token = "0x400048D")]
		DELAY,
		[Token(Token = "0x400048E")]
		FEEDBACK,
		[Token(Token = "0x400048F")]
		DRYLEVEL,
		[Token(Token = "0x4000490")]
		WETLEVEL
	}
	[Token(Token = "0x20000DB")]
	public enum DSP_FADER
	{
		[Token(Token = "0x4000492")]
		GAIN,
		[Token(Token = "0x4000493")]
		OVERALL_GAIN
	}
	[Token(Token = "0x20000DC")]
	public enum DSP_DELAY
	{
		[Token(Token = "0x4000495")]
		CH0,
		[Token(Token = "0x4000496")]
		CH1,
		[Token(Token = "0x4000497")]
		CH2,
		[Token(Token = "0x4000498")]
		CH3,
		[Token(Token = "0x4000499")]
		CH4,
		[Token(Token = "0x400049A")]
		CH5,
		[Token(Token = "0x400049B")]
		CH6,
		[Token(Token = "0x400049C")]
		CH7,
		[Token(Token = "0x400049D")]
		CH8,
		[Token(Token = "0x400049E")]
		CH9,
		[Token(Token = "0x400049F")]
		CH10,
		[Token(Token = "0x40004A0")]
		CH11,
		[Token(Token = "0x40004A1")]
		CH12,
		[Token(Token = "0x40004A2")]
		CH13,
		[Token(Token = "0x40004A3")]
		CH14,
		[Token(Token = "0x40004A4")]
		CH15,
		[Token(Token = "0x40004A5")]
		MAXDELAY
	}
	[Token(Token = "0x20000DD")]
	public enum DSP_FLANGE
	{
		[Token(Token = "0x40004A7")]
		MIX,
		[Token(Token = "0x40004A8")]
		DEPTH,
		[Token(Token = "0x40004A9")]
		RATE
	}
	[Token(Token = "0x20000DE")]
	public enum DSP_TREMOLO
	{
		[Token(Token = "0x40004AB")]
		FREQUENCY,
		[Token(Token = "0x40004AC")]
		DEPTH,
		[Token(Token = "0x40004AD")]
		SHAPE,
		[Token(Token = "0x40004AE")]
		SKEW,
		[Token(Token = "0x40004AF")]
		DUTY,
		[Token(Token = "0x40004B0")]
		SQUARE,
		[Token(Token = "0x40004B1")]
		PHASE,
		[Token(Token = "0x40004B2")]
		SPREAD
	}
	[Token(Token = "0x20000DF")]
	public enum DSP_DISTORTION
	{
		[Token(Token = "0x40004B4")]
		LEVEL
	}
	[Token(Token = "0x20000E0")]
	public enum DSP_NORMALIZE
	{
		[Token(Token = "0x40004B6")]
		FADETIME,
		[Token(Token = "0x40004B7")]
		THRESHHOLD,
		[Token(Token = "0x40004B8")]
		MAXAMP
	}
	[Token(Token = "0x20000E1")]
	public enum DSP_LIMITER
	{
		[Token(Token = "0x40004BA")]
		RELEASETIME,
		[Token(Token = "0x40004BB")]
		CEILING,
		[Token(Token = "0x40004BC")]
		MAXIMIZERGAIN,
		[Token(Token = "0x40004BD")]
		MODE
	}
	[Token(Token = "0x20000E2")]
	public enum DSP_PARAMEQ
	{
		[Token(Token = "0x40004BF")]
		CENTER,
		[Token(Token = "0x40004C0")]
		BANDWIDTH,
		[Token(Token = "0x40004C1")]
		GAIN
	}
	[Token(Token = "0x20000E3")]
	public enum DSP_MULTIBAND_EQ
	{
		[Token(Token = "0x40004C3")]
		A_FILTER,
		[Token(Token = "0x40004C4")]
		A_FREQUENCY,
		[Token(Token = "0x40004C5")]
		A_Q,
		[Token(Token = "0x40004C6")]
		A_GAIN,
		[Token(Token = "0x40004C7")]
		B_FILTER,
		[Token(Token = "0x40004C8")]
		B_FREQUENCY,
		[Token(Token = "0x40004C9")]
		B_Q,
		[Token(Token = "0x40004CA")]
		B_GAIN,
		[Token(Token = "0x40004CB")]
		C_FILTER,
		[Token(Token = "0x40004CC")]
		C_FREQUENCY,
		[Token(Token = "0x40004CD")]
		C_Q,
		[Token(Token = "0x40004CE")]
		C_GAIN,
		[Token(Token = "0x40004CF")]
		D_FILTER,
		[Token(Token = "0x40004D0")]
		D_FREQUENCY,
		[Token(Token = "0x40004D1")]
		D_Q,
		[Token(Token = "0x40004D2")]
		D_GAIN,
		[Token(Token = "0x40004D3")]
		E_FILTER,
		[Token(Token = "0x40004D4")]
		E_FREQUENCY,
		[Token(Token = "0x40004D5")]
		E_Q,
		[Token(Token = "0x40004D6")]
		E_GAIN
	}
	[Token(Token = "0x20000E4")]
	public enum DSP_MULTIBAND_EQ_FILTER_TYPE
	{
		[Token(Token = "0x40004D8")]
		DISABLED,
		[Token(Token = "0x40004D9")]
		LOWPASS_12DB,
		[Token(Token = "0x40004DA")]
		LOWPASS_24DB,
		[Token(Token = "0x40004DB")]
		LOWPASS_48DB,
		[Token(Token = "0x40004DC")]
		HIGHPASS_12DB,
		[Token(Token = "0x40004DD")]
		HIGHPASS_24DB,
		[Token(Token = "0x40004DE")]
		HIGHPASS_48DB,
		[Token(Token = "0x40004DF")]
		LOWSHELF,
		[Token(Token = "0x40004E0")]
		HIGHSHELF,
		[Token(Token = "0x40004E1")]
		PEAKING,
		[Token(Token = "0x40004E2")]
		BANDPASS,
		[Token(Token = "0x40004E3")]
		NOTCH,
		[Token(Token = "0x40004E4")]
		ALLPASS
	}
	[Token(Token = "0x20000E5")]
	public enum DSP_PITCHSHIFT
	{
		[Token(Token = "0x40004E6")]
		PITCH,
		[Token(Token = "0x40004E7")]
		FFTSIZE,
		[Token(Token = "0x40004E8")]
		OVERLAP,
		[Token(Token = "0x40004E9")]
		MAXCHANNELS
	}
	[Token(Token = "0x20000E6")]
	public enum DSP_CHORUS
	{
		[Token(Token = "0x40004EB")]
		MIX,
		[Token(Token = "0x40004EC")]
		RATE,
		[Token(Token = "0x40004ED")]
		DEPTH
	}
	[Token(Token = "0x20000E7")]
	public enum DSP_ITECHO
	{
		[Token(Token = "0x40004EF")]
		WETDRYMIX,
		[Token(Token = "0x40004F0")]
		FEEDBACK,
		[Token(Token = "0x40004F1")]
		LEFTDELAY,
		[Token(Token = "0x40004F2")]
		RIGHTDELAY,
		[Token(Token = "0x40004F3")]
		PANDELAY
	}
	[Token(Token = "0x20000E8")]
	public enum DSP_COMPRESSOR
	{
		[Token(Token = "0x40004F5")]
		THRESHOLD,
		[Token(Token = "0x40004F6")]
		RATIO,
		[Token(Token = "0x40004F7")]
		ATTACK,
		[Token(Token = "0x40004F8")]
		RELEASE,
		[Token(Token = "0x40004F9")]
		GAINMAKEUP,
		[Token(Token = "0x40004FA")]
		USESIDECHAIN,
		[Token(Token = "0x40004FB")]
		LINKED
	}
	[Token(Token = "0x20000E9")]
	public enum DSP_SFXREVERB
	{
		[Token(Token = "0x40004FD")]
		DECAYTIME,
		[Token(Token = "0x40004FE")]
		EARLYDELAY,
		[Token(Token = "0x40004FF")]
		LATEDELAY,
		[Token(Token = "0x4000500")]
		HFREFERENCE,
		[Token(Token = "0x4000501")]
		HFDECAYRATIO,
		[Token(Token = "0x4000502")]
		DIFFUSION,
		[Token(Token = "0x4000503")]
		DENSITY,
		[Token(Token = "0x4000504")]
		LOWSHELFFREQUENCY,
		[Token(Token = "0x4000505")]
		LOWSHELFGAIN,
		[Token(Token = "0x4000506")]
		HIGHCUT,
		[Token(Token = "0x4000507")]
		EARLYLATEMIX,
		[Token(Token = "0x4000508")]
		WETLEVEL,
		[Token(Token = "0x4000509")]
		DRYLEVEL
	}
	[Token(Token = "0x20000EA")]
	public enum DSP_LOWPASS_SIMPLE
	{
		[Token(Token = "0x400050B")]
		CUTOFF
	}
	[Token(Token = "0x20000EB")]
	public enum DSP_SEND
	{
		[Token(Token = "0x400050D")]
		RETURNID,
		[Token(Token = "0x400050E")]
		LEVEL
	}
	[Token(Token = "0x20000EC")]
	public enum DSP_RETURN
	{
		[Token(Token = "0x4000510")]
		ID,
		[Token(Token = "0x4000511")]
		INPUT_SPEAKER_MODE
	}
	[Token(Token = "0x20000ED")]
	public enum DSP_HIGHPASS_SIMPLE
	{
		[Token(Token = "0x4000513")]
		CUTOFF
	}
	[Token(Token = "0x20000EE")]
	public enum DSP_PAN_2D_STEREO_MODE_TYPE
	{
		[Token(Token = "0x4000515")]
		DISTRIBUTED,
		[Token(Token = "0x4000516")]
		DISCRETE
	}
	[Token(Token = "0x20000EF")]
	public enum DSP_PAN_MODE_TYPE
	{
		[Token(Token = "0x4000518")]
		MONO,
		[Token(Token = "0x4000519")]
		STEREO,
		[Token(Token = "0x400051A")]
		SURROUND
	}
	[Token(Token = "0x20000F0")]
	public enum DSP_PAN_3D_ROLLOFF_TYPE
	{
		[Token(Token = "0x400051C")]
		LINEARSQUARED,
		[Token(Token = "0x400051D")]
		LINEAR,
		[Token(Token = "0x400051E")]
		INVERSE,
		[Token(Token = "0x400051F")]
		INVERSETAPERED,
		[Token(Token = "0x4000520")]
		CUSTOM
	}
	[Token(Token = "0x20000F1")]
	public enum DSP_PAN_3D_EXTENT_MODE_TYPE
	{
		[Token(Token = "0x4000522")]
		AUTO,
		[Token(Token = "0x4000523")]
		USER,
		[Token(Token = "0x4000524")]
		OFF
	}
	[Token(Token = "0x20000F2")]
	public enum DSP_PAN
	{
		[Token(Token = "0x4000526")]
		MODE,
		[Token(Token = "0x4000527")]
		_2D_STEREO_POSITION,
		[Token(Token = "0x4000528")]
		_2D_DIRECTION,
		[Token(Token = "0x4000529")]
		_2D_EXTENT,
		[Token(Token = "0x400052A")]
		_2D_ROTATION,
		[Token(Token = "0x400052B")]
		_2D_LFE_LEVEL,
		[Token(Token = "0x400052C")]
		_2D_STEREO_MODE,
		[Token(Token = "0x400052D")]
		_2D_STEREO_SEPARATION,
		[Token(Token = "0x400052E")]
		_2D_STEREO_AXIS,
		[Token(Token = "0x400052F")]
		ENABLED_SPEAKERS,
		[Token(Token = "0x4000530")]
		_3D_POSITION,
		[Token(Token = "0x4000531")]
		_3D_ROLLOFF,
		[Token(Token = "0x4000532")]
		_3D_MIN_DISTANCE,
		[Token(Token = "0x4000533")]
		_3D_MAX_DISTANCE,
		[Token(Token = "0x4000534")]
		_3D_EXTENT_MODE,
		[Token(Token = "0x4000535")]
		_3D_SOUND_SIZE,
		[Token(Token = "0x4000536")]
		_3D_MIN_EXTENT,
		[Token(Token = "0x4000537")]
		_3D_PAN_BLEND,
		[Token(Token = "0x4000538")]
		LFE_UPMIX_ENABLED,
		[Token(Token = "0x4000539")]
		OVERALL_GAIN,
		[Token(Token = "0x400053A")]
		SURROUND_SPEAKER_MODE,
		[Token(Token = "0x400053B")]
		_2D_HEIGHT_BLEND
	}
	[Token(Token = "0x20000F3")]
	public enum DSP_THREE_EQ_CROSSOVERSLOPE_TYPE
	{
		[Token(Token = "0x400053D")]
		_12DB,
		[Token(Token = "0x400053E")]
		_24DB,
		[Token(Token = "0x400053F")]
		_48DB
	}
	[Token(Token = "0x20000F4")]
	public enum DSP_THREE_EQ
	{
		[Token(Token = "0x4000541")]
		LOWGAIN,
		[Token(Token = "0x4000542")]
		MIDGAIN,
		[Token(Token = "0x4000543")]
		HIGHGAIN,
		[Token(Token = "0x4000544")]
		LOWCROSSOVER,
		[Token(Token = "0x4000545")]
		HIGHCROSSOVER,
		[Token(Token = "0x4000546")]
		CROSSOVERSLOPE
	}
	[Token(Token = "0x20000F5")]
	public enum DSP_FFT_WINDOW
	{
		[Token(Token = "0x4000548")]
		RECT,
		[Token(Token = "0x4000549")]
		TRIANGLE,
		[Token(Token = "0x400054A")]
		HAMMING,
		[Token(Token = "0x400054B")]
		HANNING,
		[Token(Token = "0x400054C")]
		BLACKMAN,
		[Token(Token = "0x400054D")]
		BLACKMANHARRIS
	}
	[Token(Token = "0x20000F6")]
	public enum DSP_FFT
	{
		[Token(Token = "0x400054F")]
		WINDOWSIZE,
		[Token(Token = "0x4000550")]
		WINDOWTYPE,
		[Token(Token = "0x4000551")]
		SPECTRUMDATA,
		[Token(Token = "0x4000552")]
		DOMINANT_FREQ
	}
	[Token(Token = "0x20000F7")]
	public enum DSP_ENVELOPEFOLLOWER
	{
		[Token(Token = "0x4000554")]
		ATTACK,
		[Token(Token = "0x4000555")]
		RELEASE,
		[Token(Token = "0x4000556")]
		ENVELOPE,
		[Token(Token = "0x4000557")]
		USESIDECHAIN
	}
	[Token(Token = "0x20000F8")]
	public enum DSP_CONVOLUTION_REVERB
	{
		[Token(Token = "0x4000559")]
		IR,
		[Token(Token = "0x400055A")]
		WET,
		[Token(Token = "0x400055B")]
		DRY,
		[Token(Token = "0x400055C")]
		LINKED
	}
	[Token(Token = "0x20000F9")]
	public enum DSP_CHANNELMIX_OUTPUT
	{
		[Token(Token = "0x400055E")]
		DEFAULT,
		[Token(Token = "0x400055F")]
		ALLMONO,
		[Token(Token = "0x4000560")]
		ALLSTEREO,
		[Token(Token = "0x4000561")]
		ALLQUAD,
		[Token(Token = "0x4000562")]
		ALL5POINT1,
		[Token(Token = "0x4000563")]
		ALL7POINT1,
		[Token(Token = "0x4000564")]
		ALLLFE,
		[Token(Token = "0x4000565")]
		ALL7POINT1POINT4
	}
	[Token(Token = "0x20000FA")]
	public enum DSP_CHANNELMIX
	{
		[Token(Token = "0x4000567")]
		OUTPUTGROUPING,
		[Token(Token = "0x4000568")]
		GAIN_CH0,
		[Token(Token = "0x4000569")]
		GAIN_CH1,
		[Token(Token = "0x400056A")]
		GAIN_CH2,
		[Token(Token = "0x400056B")]
		GAIN_CH3,
		[Token(Token = "0x400056C")]
		GAIN_CH4,
		[Token(Token = "0x400056D")]
		GAIN_CH5,
		[Token(Token = "0x400056E")]
		GAIN_CH6,
		[Token(Token = "0x400056F")]
		GAIN_CH7,
		[Token(Token = "0x4000570")]
		GAIN_CH8,
		[Token(Token = "0x4000571")]
		GAIN_CH9,
		[Token(Token = "0x4000572")]
		GAIN_CH10,
		[Token(Token = "0x4000573")]
		GAIN_CH11,
		[Token(Token = "0x4000574")]
		GAIN_CH12,
		[Token(Token = "0x4000575")]
		GAIN_CH13,
		[Token(Token = "0x4000576")]
		GAIN_CH14,
		[Token(Token = "0x4000577")]
		GAIN_CH15,
		[Token(Token = "0x4000578")]
		GAIN_CH16,
		[Token(Token = "0x4000579")]
		GAIN_CH17,
		[Token(Token = "0x400057A")]
		GAIN_CH18,
		[Token(Token = "0x400057B")]
		GAIN_CH19,
		[Token(Token = "0x400057C")]
		GAIN_CH20,
		[Token(Token = "0x400057D")]
		GAIN_CH21,
		[Token(Token = "0x400057E")]
		GAIN_CH22,
		[Token(Token = "0x400057F")]
		GAIN_CH23,
		[Token(Token = "0x4000580")]
		GAIN_CH24,
		[Token(Token = "0x4000581")]
		GAIN_CH25,
		[Token(Token = "0x4000582")]
		GAIN_CH26,
		[Token(Token = "0x4000583")]
		GAIN_CH27,
		[Token(Token = "0x4000584")]
		GAIN_CH28,
		[Token(Token = "0x4000585")]
		GAIN_CH29,
		[Token(Token = "0x4000586")]
		GAIN_CH30,
		[Token(Token = "0x4000587")]
		GAIN_CH31,
		[Token(Token = "0x4000588")]
		OUTPUT_CH0,
		[Token(Token = "0x4000589")]
		OUTPUT_CH1,
		[Token(Token = "0x400058A")]
		OUTPUT_CH2,
		[Token(Token = "0x400058B")]
		OUTPUT_CH3,
		[Token(Token = "0x400058C")]
		OUTPUT_CH4,
		[Token(Token = "0x400058D")]
		OUTPUT_CH5,
		[Token(Token = "0x400058E")]
		OUTPUT_CH6,
		[Token(Token = "0x400058F")]
		OUTPUT_CH7,
		[Token(Token = "0x4000590")]
		OUTPUT_CH8,
		[Token(Token = "0x4000591")]
		OUTPUT_CH9,
		[Token(Token = "0x4000592")]
		OUTPUT_CH10,
		[Token(Token = "0x4000593")]
		OUTPUT_CH11,
		[Token(Token = "0x4000594")]
		OUTPUT_CH12,
		[Token(Token = "0x4000595")]
		OUTPUT_CH13,
		[Token(Token = "0x4000596")]
		OUTPUT_CH14,
		[Token(Token = "0x4000597")]
		OUTPUT_CH15,
		[Token(Token = "0x4000598")]
		OUTPUT_CH16,
		[Token(Token = "0x4000599")]
		OUTPUT_CH17,
		[Token(Token = "0x400059A")]
		OUTPUT_CH18,
		[Token(Token = "0x400059B")]
		OUTPUT_CH19,
		[Token(Token = "0x400059C")]
		OUTPUT_CH20,
		[Token(Token = "0x400059D")]
		OUTPUT_CH21,
		[Token(Token = "0x400059E")]
		OUTPUT_CH22,
		[Token(Token = "0x400059F")]
		OUTPUT_CH23,
		[Token(Token = "0x40005A0")]
		OUTPUT_CH24,
		[Token(Token = "0x40005A1")]
		OUTPUT_CH25,
		[Token(Token = "0x40005A2")]
		OUTPUT_CH26,
		[Token(Token = "0x40005A3")]
		OUTPUT_CH27,
		[Token(Token = "0x40005A4")]
		OUTPUT_CH28,
		[Token(Token = "0x40005A5")]
		OUTPUT_CH29,
		[Token(Token = "0x40005A6")]
		OUTPUT_CH30,
		[Token(Token = "0x40005A7")]
		OUTPUT_CH31
	}
	[Token(Token = "0x20000FB")]
	public enum DSP_TRANSCEIVER_SPEAKERMODE
	{
		[Token(Token = "0x40005A9")]
		AUTO = -1,
		[Token(Token = "0x40005AA")]
		MONO,
		[Token(Token = "0x40005AB")]
		STEREO,
		[Token(Token = "0x40005AC")]
		SURROUND
	}
	[Token(Token = "0x20000FC")]
	public enum DSP_TRANSCEIVER
	{
		[Token(Token = "0x40005AE")]
		TRANSMIT,
		[Token(Token = "0x40005AF")]
		GAIN,
		[Token(Token = "0x40005B0")]
		CHANNEL,
		[Token(Token = "0x40005B1")]
		TRANSMITSPEAKERMODE
	}
	[Token(Token = "0x20000FD")]
	public enum DSP_OBJECTPAN
	{
		[Token(Token = "0x40005B3")]
		_3D_POSITION,
		[Token(Token = "0x40005B4")]
		_3D_ROLLOFF,
		[Token(Token = "0x40005B5")]
		_3D_MIN_DISTANCE,
		[Token(Token = "0x40005B6")]
		_3D_MAX_DISTANCE,
		[Token(Token = "0x40005B7")]
		_3D_EXTENT_MODE,
		[Token(Token = "0x40005B8")]
		_3D_SOUND_SIZE,
		[Token(Token = "0x40005B9")]
		_3D_MIN_EXTENT,
		[Token(Token = "0x40005BA")]
		OVERALL_GAIN,
		[Token(Token = "0x40005BB")]
		OUTPUTGAIN
	}
	[Token(Token = "0x20000FE")]
	public class Error
	{
		[Token(Token = "0x600062F")]
		[Address(RVA = "0x150ADAC", Offset = "0x150ADAC", VA = "0x150ADAC")]
		public static string String(RESULT errcode)
		{
			return null;
		}

		[Token(Token = "0x6000630")]
		[Address(RVA = "0x150AE10", Offset = "0x150AE10", VA = "0x150AE10")]
		public Error()
		{
		}
	}
}
namespace FMOD.Studio
{
	[Token(Token = "0x20000FF")]
	public class STUDIO_VERSION
	{
		[Token(Token = "0x40005BC")]
		public const string dll = "fmodstudio";

		[Token(Token = "0x6000631")]
		[Address(RVA = "0x151A454", Offset = "0x151A454", VA = "0x151A454")]
		public STUDIO_VERSION()
		{
		}
	}
	[Token(Token = "0x2000100")]
	public enum STOP_MODE
	{
		[Token(Token = "0x40005BE")]
		ALLOWFADEOUT,
		[Token(Token = "0x40005BF")]
		IMMEDIATE
	}
	[Token(Token = "0x2000101")]
	public enum LOADING_STATE
	{
		[Token(Token = "0x40005C1")]
		UNLOADING,
		[Token(Token = "0x40005C2")]
		UNLOADED,
		[Token(Token = "0x40005C3")]
		LOADING,
		[Token(Token = "0x40005C4")]
		LOADED,
		[Token(Token = "0x40005C5")]
		ERROR
	}
	[Token(Token = "0x2000102")]
	public struct PROGRAMMER_SOUND_PROPERTIES
	{
		[Token(Token = "0x40005C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public StringWrapper name;

		[Token(Token = "0x40005C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public IntPtr sound;

		[Token(Token = "0x40005C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int subsoundIndex;
	}
	[Token(Token = "0x2000103")]
	public struct TIMELINE_MARKER_PROPERTIES
	{
		[Token(Token = "0x40005C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public StringWrapper name;

		[Token(Token = "0x40005CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int position;
	}
	[Token(Token = "0x2000104")]
	public struct TIMELINE_BEAT_PROPERTIES
	{
		[Token(Token = "0x40005CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int bar;

		[Token(Token = "0x40005CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int beat;

		[Token(Token = "0x40005CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int position;

		[Token(Token = "0x40005CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float tempo;

		[Token(Token = "0x40005CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int timesignatureupper;

		[Token(Token = "0x40005D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int timesignaturelower;
	}
	[Token(Token = "0x2000105")]
	public struct ADVANCEDSETTINGS
	{
		[Token(Token = "0x40005D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int cbsize;

		[Token(Token = "0x40005D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int commandqueuesize;

		[Token(Token = "0x40005D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int handleinitialsize;

		[Token(Token = "0x40005D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int studioupdateperiod;

		[Token(Token = "0x40005D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int idlesampledatapoolsize;

		[Token(Token = "0x40005D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int streamingscheduledelay;

		[Token(Token = "0x40005D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IntPtr encryptionkey;
	}
	[Token(Token = "0x2000106")]
	public struct CPU_USAGE
	{
		[Token(Token = "0x40005D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float dspusage;

		[Token(Token = "0x40005D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float streamusage;

		[Token(Token = "0x40005DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float geometryusage;

		[Token(Token = "0x40005DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float updateusage;

		[Token(Token = "0x40005DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float studiousage;
	}
	[Token(Token = "0x2000107")]
	public struct BUFFER_INFO
	{
		[Token(Token = "0x40005DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int currentusage;

		[Token(Token = "0x40005DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int peakusage;

		[Token(Token = "0x40005DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int capacity;

		[Token(Token = "0x40005E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int stallcount;

		[Token(Token = "0x40005E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float stalltime;
	}
	[Token(Token = "0x2000108")]
	public struct BUFFER_USAGE
	{
		[Token(Token = "0x40005E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public BUFFER_INFO studiocommandqueue;

		[Token(Token = "0x40005E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public BUFFER_INFO studiohandle;
	}
	[Token(Token = "0x2000109")]
	public struct BANK_INFO
	{
		[Token(Token = "0x40005E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int size;

		[Token(Token = "0x40005E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public IntPtr userdata;

		[Token(Token = "0x40005E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int userdatalength;

		[Token(Token = "0x40005E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FILE_OPEN_CALLBACK opencallback;

		[Token(Token = "0x40005E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FILE_CLOSE_CALLBACK closecallback;

		[Token(Token = "0x40005E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public FILE_READ_CALLBACK readcallback;

		[Token(Token = "0x40005EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public FILE_SEEK_CALLBACK seekcallback;
	}
	[Token(Token = "0x200010A")]
	[Flags]
	public enum SYSTEM_CALLBACK_TYPE : uint
	{
		[Token(Token = "0x40005EC")]
		PREUPDATE = 1u,
		[Token(Token = "0x40005ED")]
		POSTUPDATE = 2u,
		[Token(Token = "0x40005EE")]
		BANK_UNLOAD = 4u,
		[Token(Token = "0x40005EF")]
		ALL = uint.MaxValue
	}
	[Token(Token = "0x200010B")]
	public delegate RESULT SYSTEM_CALLBACK(IntPtr system, SYSTEM_CALLBACK_TYPE type, IntPtr commanddata, IntPtr userdata);
	[Token(Token = "0x200010C")]
	public enum PARAMETER_TYPE
	{
		[Token(Token = "0x40005F1")]
		GAME_CONTROLLED,
		[Token(Token = "0x40005F2")]
		AUTOMATIC_DISTANCE,
		[Token(Token = "0x40005F3")]
		AUTOMATIC_EVENT_CONE_ANGLE,
		[Token(Token = "0x40005F4")]
		AUTOMATIC_EVENT_ORIENTATION,
		[Token(Token = "0x40005F5")]
		AUTOMATIC_DIRECTION,
		[Token(Token = "0x40005F6")]
		AUTOMATIC_ELEVATION,
		[Token(Token = "0x40005F7")]
		AUTOMATIC_LISTENER_ORIENTATION,
		[Token(Token = "0x40005F8")]
		AUTOMATIC_SPEED,
		[Token(Token = "0x40005F9")]
		MAX
	}
	[Token(Token = "0x200010D")]
	[Flags]
	public enum PARAMETER_FLAGS : uint
	{
		[Token(Token = "0x40005FB")]
		READONLY = 1u,
		[Token(Token = "0x40005FC")]
		AUTOMATIC = 2u,
		[Token(Token = "0x40005FD")]
		GLOBAL = 4u
	}
	[Token(Token = "0x200010E")]
	public struct PARAMETER_ID
	{
		[Token(Token = "0x40005FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint data1;

		[Token(Token = "0x40005FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint data2;
	}
	[Token(Token = "0x200010F")]
	public struct PARAMETER_DESCRIPTION
	{
		[Token(Token = "0x4000600")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public StringWrapper name;

		[Token(Token = "0x4000601")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public PARAMETER_ID id;

		[Token(Token = "0x4000602")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float minimum;

		[Token(Token = "0x4000603")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float maximum;

		[Token(Token = "0x4000604")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float defaultvalue;

		[Token(Token = "0x4000605")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public PARAMETER_TYPE type;

		[Token(Token = "0x4000606")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PARAMETER_FLAGS flags;
	}
	[Token(Token = "0x2000110")]
	internal enum LOAD_MEMORY_MODE
	{
		[Token(Token = "0x4000608")]
		LOAD_MEMORY,
		[Token(Token = "0x4000609")]
		LOAD_MEMORY_POINT
	}
	[Token(Token = "0x2000111")]
	internal enum LOAD_MEMORY_ALIGNMENT
	{
		[Token(Token = "0x400060B")]
		VALUE = 0x20
	}
	[Token(Token = "0x2000112")]
	public struct SOUND_INFO
	{
		[Token(Token = "0x400060C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr name_or_data;

		[Token(Token = "0x400060D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public MODE mode;

		[Token(Token = "0x400060E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CREATESOUNDEXINFO exinfo;

		[Token(Token = "0x400060F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public int subsoundindex;

		[Token(Token = "0x1700000E")]
		public string name
		{
			[Token(Token = "0x6000636")]
			[Address(RVA = "0x8F34E0", Offset = "0x8F34E0", VA = "0x8F34E0")]
			get
			{
				return null;
			}
		}
	}
	[Token(Token = "0x2000113")]
	public enum USER_PROPERTY_TYPE
	{
		[Token(Token = "0x4000611")]
		INTEGER,
		[Token(Token = "0x4000612")]
		BOOLEAN,
		[Token(Token = "0x4000613")]
		FLOAT,
		[Token(Token = "0x4000614")]
		STRING
	}
	[Token(Token = "0x2000114")]
	public struct USER_PROPERTY
	{
		[Token(Token = "0x4000615")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public StringWrapper name;

		[Token(Token = "0x4000616")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public USER_PROPERTY_TYPE type;

		[Token(Token = "0x4000617")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Union_IntBoolFloatString value;

		[Token(Token = "0x6000637")]
		[Address(RVA = "0x8D2BD8", Offset = "0x8D2BD8", VA = "0x8D2BD8")]
		public int intValue()
		{
			return default(int);
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0x8D2BF0", Offset = "0x8D2BF0", VA = "0x8D2BF0")]
		public bool boolValue()
		{
			return default(bool);
		}

		[Token(Token = "0x6000639")]
		[Address(RVA = "0x8D2C14", Offset = "0x8D2C14", VA = "0x8D2C14")]
		public float floatValue()
		{
			return default(float);
		}

		[Token(Token = "0x600063A")]
		[Address(RVA = "0x8D2C30", Offset = "0x8D2C30", VA = "0x8D2C30")]
		public string stringValue()
		{
			return null;
		}
	}
	[StructLayout(2)]
	[Token(Token = "0x2000115")]
	internal struct Union_IntBoolFloatString
	{
		[Token(Token = "0x4000618")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int intvalue;

		[Token(Token = "0x4000619")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool boolvalue;

		[Token(Token = "0x400061A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float floatvalue;

		[Token(Token = "0x400061B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public StringWrapper stringvalue;
	}
	[Token(Token = "0x2000116")]
	[Flags]
	public enum INITFLAGS : uint
	{
		[Token(Token = "0x400061D")]
		NORMAL = 0u,
		[Token(Token = "0x400061E")]
		LIVEUPDATE = 1u,
		[Token(Token = "0x400061F")]
		ALLOW_MISSING_PLUGINS = 2u,
		[Token(Token = "0x4000620")]
		SYNCHRONOUS_UPDATE = 4u,
		[Token(Token = "0x4000621")]
		DEFERRED_CALLBACKS = 8u,
		[Token(Token = "0x4000622")]
		LOAD_FROM_UPDATE = 0x10u
	}
	[Token(Token = "0x2000117")]
	[Flags]
	public enum LOAD_BANK_FLAGS : uint
	{
		[Token(Token = "0x4000624")]
		NORMAL = 0u,
		[Token(Token = "0x4000625")]
		NONBLOCKING = 1u,
		[Token(Token = "0x4000626")]
		DECOMPRESS_SAMPLES = 2u,
		[Token(Token = "0x4000627")]
		UNENCRYPTED = 4u
	}
	[Token(Token = "0x2000118")]
	[Flags]
	public enum COMMANDCAPTURE_FLAGS : uint
	{
		[Token(Token = "0x4000629")]
		NORMAL = 0u,
		[Token(Token = "0x400062A")]
		FILEFLUSH = 1u,
		[Token(Token = "0x400062B")]
		SKIP_INITIAL_STATE = 2u
	}
	[Token(Token = "0x2000119")]
	[Flags]
	public enum COMMANDREPLAY_FLAGS : uint
	{
		[Token(Token = "0x400062D")]
		NORMAL = 0u,
		[Token(Token = "0x400062E")]
		SKIP_CLEANUP = 1u,
		[Token(Token = "0x400062F")]
		FAST_FORWARD = 2u,
		[Token(Token = "0x4000630")]
		SKIP_BANK_LOAD = 4u
	}
	[Token(Token = "0x200011A")]
	public enum PLAYBACK_STATE
	{
		[Token(Token = "0x4000632")]
		PLAYING,
		[Token(Token = "0x4000633")]
		SUSTAINING,
		[Token(Token = "0x4000634")]
		STOPPED,
		[Token(Token = "0x4000635")]
		STARTING,
		[Token(Token = "0x4000636")]
		STOPPING
	}
	[Token(Token = "0x200011B")]
	public enum EVENT_PROPERTY
	{
		[Token(Token = "0x4000638")]
		CHANNELPRIORITY,
		[Token(Token = "0x4000639")]
		SCHEDULE_DELAY,
		[Token(Token = "0x400063A")]
		SCHEDULE_LOOKAHEAD,
		[Token(Token = "0x400063B")]
		MINIMUM_DISTANCE,
		[Token(Token = "0x400063C")]
		MAXIMUM_DISTANCE,
		[Token(Token = "0x400063D")]
		MAX
	}
	[Token(Token = "0x200011C")]
	public struct PLUGIN_INSTANCE_PROPERTIES
	{
		[Token(Token = "0x400063E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr name;

		[Token(Token = "0x400063F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public IntPtr dsp;
	}
	[Token(Token = "0x200011D")]
	[Flags]
	public enum EVENT_CALLBACK_TYPE : uint
	{
		[Token(Token = "0x4000641")]
		CREATED = 1u,
		[Token(Token = "0x4000642")]
		DESTROYED = 2u,
		[Token(Token = "0x4000643")]
		STARTING = 4u,
		[Token(Token = "0x4000644")]
		STARTED = 8u,
		[Token(Token = "0x4000645")]
		RESTARTED = 0x10u,
		[Token(Token = "0x4000646")]
		STOPPED = 0x20u,
		[Token(Token = "0x4000647")]
		START_FAILED = 0x40u,
		[Token(Token = "0x4000648")]
		CREATE_PROGRAMMER_SOUND = 0x80u,
		[Token(Token = "0x4000649")]
		DESTROY_PROGRAMMER_SOUND = 0x100u,
		[Token(Token = "0x400064A")]
		PLUGIN_CREATED = 0x200u,
		[Token(Token = "0x400064B")]
		PLUGIN_DESTROYED = 0x400u,
		[Token(Token = "0x400064C")]
		TIMELINE_MARKER = 0x800u,
		[Token(Token = "0x400064D")]
		TIMELINE_BEAT = 0x1000u,
		[Token(Token = "0x400064E")]
		SOUND_PLAYED = 0x2000u,
		[Token(Token = "0x400064F")]
		SOUND_STOPPED = 0x4000u,
		[Token(Token = "0x4000650")]
		REAL_TO_VIRTUAL = 0x8000u,
		[Token(Token = "0x4000651")]
		VIRTUAL_TO_REAL = 0x10000u,
		[Token(Token = "0x4000652")]
		ALL = uint.MaxValue
	}
	[Token(Token = "0x200011E")]
	public delegate RESULT EVENT_CALLBACK(EVENT_CALLBACK_TYPE type, EventInstance _event, IntPtr parameters);
	[Token(Token = "0x200011F")]
	public delegate RESULT COMMANDREPLAY_FRAME_CALLBACK(CommandReplay replay, int commandindex, float currenttime, IntPtr userdata);
	[Token(Token = "0x2000120")]
	public delegate RESULT COMMANDREPLAY_LOAD_BANK_CALLBACK(CommandReplay replay, int commandindex, Guid bankguid, StringWrapper bankfilename, LOAD_BANK_FLAGS flags, out Bank bank, IntPtr userdata);
	[Token(Token = "0x2000121")]
	public delegate RESULT COMMANDREPLAY_CREATE_INSTANCE_CALLBACK(CommandReplay replay, int commandindex, EventDescription eventdescription, out EventInstance instance, IntPtr userdata);
	[Token(Token = "0x2000122")]
	public enum INSTANCETYPE
	{
		[Token(Token = "0x4000654")]
		NONE,
		[Token(Token = "0x4000655")]
		SYSTEM,
		[Token(Token = "0x4000656")]
		EVENTDESCRIPTION,
		[Token(Token = "0x4000657")]
		EVENTINSTANCE,
		[Token(Token = "0x4000658")]
		PARAMETERINSTANCE,
		[Token(Token = "0x4000659")]
		BUS,
		[Token(Token = "0x400065A")]
		VCA,
		[Token(Token = "0x400065B")]
		BANK,
		[Token(Token = "0x400065C")]
		COMMANDREPLAY
	}
	[Token(Token = "0x2000123")]
	public struct COMMAND_INFO
	{
		[Token(Token = "0x400065D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public StringWrapper commandname;

		[Token(Token = "0x400065E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int parentcommandindex;

		[Token(Token = "0x400065F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int framenumber;

		[Token(Token = "0x4000660")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float frametime;

		[Token(Token = "0x4000661")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public INSTANCETYPE instancetype;

		[Token(Token = "0x4000662")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public INSTANCETYPE outputtype;

		[Token(Token = "0x4000663")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public uint instancehandle;

		[Token(Token = "0x4000664")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public uint outputhandle;
	}
	[Token(Token = "0x2000124")]
	public struct Util
	{
		[Token(Token = "0x600064B")]
		[Address(RVA = "0xCF0998", Offset = "0xCF0998", VA = "0xCF0998")]
		public static RESULT parseID(string idString, out Guid id)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x600064C")]
		[Address(RVA = "0xCF0AE0", Offset = "0xCF0AE0", VA = "0xCF0AE0")]
		private static extern RESULT FMOD_Studio_ParseID(byte[] idString, out Guid id);
	}
	[Token(Token = "0x2000125")]
	public struct System
	{
		[Token(Token = "0x4000665")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x600064D")]
		[Address(RVA = "0x151A828", Offset = "0x151A828", VA = "0x151A828")]
		public static RESULT create(out System system)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0x8F3504", Offset = "0x8F3504", VA = "0x8F3504")]
		public RESULT setAdvancedSettings(ADVANCEDSETTINGS settings)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0x8F3530", Offset = "0x8F3530", VA = "0x8F3530")]
		public RESULT setAdvancedSettings(ADVANCEDSETTINGS settings, string encryptionKey)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0x8F355C", Offset = "0x8F355C", VA = "0x8F355C")]
		public RESULT getAdvancedSettings(out ADVANCEDSETTINGS settings)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0x8F3564", Offset = "0x8F3564", VA = "0x8F3564")]
		public RESULT initialize(int maxchannels, INITFLAGS studioflags, FMOD.INITFLAGS flags, IntPtr extradriverdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0x8F356C", Offset = "0x8F356C", VA = "0x8F356C")]
		public RESULT release()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0x8F3574", Offset = "0x8F3574", VA = "0x8F3574")]
		public RESULT update()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0x8F357C", Offset = "0x8F357C", VA = "0x8F357C")]
		public RESULT getCoreSystem(out FMOD.System coresystem)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0x8F3584", Offset = "0x8F3584", VA = "0x8F3584")]
		public RESULT getEvent(string path, out EventDescription _event)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0x8F358C", Offset = "0x8F358C", VA = "0x8F358C")]
		public RESULT getBus(string path, out Bus bus)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000657")]
		[Address(RVA = "0x8F3594", Offset = "0x8F3594", VA = "0x8F3594")]
		public RESULT getVCA(string path, out VCA vca)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000658")]
		[Address(RVA = "0x8F359C", Offset = "0x8F359C", VA = "0x8F359C")]
		public RESULT getBank(string path, out Bank bank)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0x8F35A4", Offset = "0x8F35A4", VA = "0x8F35A4")]
		public RESULT getEventByID(Guid id, out EventDescription _event)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600065A")]
		[Address(RVA = "0x8F35D0", Offset = "0x8F35D0", VA = "0x8F35D0")]
		public RESULT getBusByID(Guid id, out Bus bus)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600065B")]
		[Address(RVA = "0x8F35FC", Offset = "0x8F35FC", VA = "0x8F35FC")]
		public RESULT getVCAByID(Guid id, out VCA vca)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0x8F3628", Offset = "0x8F3628", VA = "0x8F3628")]
		public RESULT getBankByID(Guid id, out Bank bank)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0x8F3654", Offset = "0x8F3654", VA = "0x8F3654")]
		public RESULT getSoundInfo(string key, out SOUND_INFO info)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600065E")]
		[Address(RVA = "0x8F365C", Offset = "0x8F365C", VA = "0x8F365C")]
		public RESULT getParameterDescriptionByName(string name, out PARAMETER_DESCRIPTION parameter)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600065F")]
		[Address(RVA = "0x8F3664", Offset = "0x8F3664", VA = "0x8F3664")]
		public RESULT getParameterDescriptionByID(PARAMETER_ID id, out PARAMETER_DESCRIPTION parameter)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000660")]
		[Address(RVA = "0x8F366C", Offset = "0x8F366C", VA = "0x8F366C")]
		public RESULT getParameterByID(PARAMETER_ID id, out float value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000661")]
		[Address(RVA = "0x8F3694", Offset = "0x8F3694", VA = "0x8F3694")]
		public RESULT getParameterByID(PARAMETER_ID id, out float value, out float finalvalue)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000662")]
		[Address(RVA = "0x8F369C", Offset = "0x8F369C", VA = "0x8F369C")]
		public RESULT setParameterByID(PARAMETER_ID id, float value, bool ignoreseekspeed = false)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000663")]
		[Address(RVA = "0x8F36A8", Offset = "0x8F36A8", VA = "0x8F36A8")]
		public RESULT setParametersByIDs(PARAMETER_ID[] ids, float[] values, int count, bool ignoreseekspeed = false)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000664")]
		[Address(RVA = "0x8F36B4", Offset = "0x8F36B4", VA = "0x8F36B4")]
		public RESULT getParameterByName(string name, out float value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000665")]
		[Address(RVA = "0x8F36DC", Offset = "0x8F36DC", VA = "0x8F36DC")]
		public RESULT getParameterByName(string name, out float value, out float finalvalue)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000666")]
		[Address(RVA = "0x8F36E4", Offset = "0x8F36E4", VA = "0x8F36E4")]
		public RESULT setParameterByName(string name, float value, bool ignoreseekspeed = false)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000667")]
		[Address(RVA = "0x8F36F0", Offset = "0x8F36F0", VA = "0x8F36F0")]
		public RESULT lookupID(string path, out Guid id)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000668")]
		[Address(RVA = "0x8F36F8", Offset = "0x8F36F8", VA = "0x8F36F8")]
		public RESULT lookupPath(Guid id, out string path)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000669")]
		[Address(RVA = "0x8F3700", Offset = "0x8F3700", VA = "0x8F3700")]
		public RESULT getNumListeners(out int numlisteners)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600066A")]
		[Address(RVA = "0x8F3708", Offset = "0x8F3708", VA = "0x8F3708")]
		public RESULT setNumListeners(int numlisteners)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600066B")]
		[Address(RVA = "0x8F3710", Offset = "0x8F3710", VA = "0x8F3710")]
		public RESULT getListenerAttributes(int listener, out ATTRIBUTES_3D attributes)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0x8F3718", Offset = "0x8F3718", VA = "0x8F3718")]
		public RESULT setListenerAttributes(int listener, ATTRIBUTES_3D attributes)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600066D")]
		[Address(RVA = "0x8F374C", Offset = "0x8F374C", VA = "0x8F374C")]
		public RESULT getListenerWeight(int listener, out float weight)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600066E")]
		[Address(RVA = "0x8F3754", Offset = "0x8F3754", VA = "0x8F3754")]
		public RESULT setListenerWeight(int listener, float weight)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600066F")]
		[Address(RVA = "0x8F375C", Offset = "0x8F375C", VA = "0x8F375C")]
		public RESULT loadBankFile(string filename, LOAD_BANK_FLAGS flags, out Bank bank)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0x8F3764", Offset = "0x8F3764", VA = "0x8F3764")]
		public RESULT loadBankMemory(byte[] buffer, LOAD_BANK_FLAGS flags, out Bank bank)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0x8F376C", Offset = "0x8F376C", VA = "0x8F376C")]
		public RESULT loadBankCustom(BANK_INFO info, LOAD_BANK_FLAGS flags, out Bank bank)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0x8F37A8", Offset = "0x8F37A8", VA = "0x8F37A8")]
		public RESULT unloadAll()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0x8F37B0", Offset = "0x8F37B0", VA = "0x8F37B0")]
		public RESULT flushCommands()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0x8F37B8", Offset = "0x8F37B8", VA = "0x8F37B8")]
		public RESULT flushSampleLoading()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000675")]
		[Address(RVA = "0x8F37C0", Offset = "0x8F37C0", VA = "0x8F37C0")]
		public RESULT startCommandCapture(string filename, COMMANDCAPTURE_FLAGS flags)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000676")]
		[Address(RVA = "0x8F37C8", Offset = "0x8F37C8", VA = "0x8F37C8")]
		public RESULT stopCommandCapture()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000677")]
		[Address(RVA = "0x8F37D0", Offset = "0x8F37D0", VA = "0x8F37D0")]
		public RESULT loadCommandReplay(string filename, COMMANDREPLAY_FLAGS flags, out CommandReplay replay)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000678")]
		[Address(RVA = "0x8F37D8", Offset = "0x8F37D8", VA = "0x8F37D8")]
		public RESULT getBankCount(out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000679")]
		[Address(RVA = "0x8F37E0", Offset = "0x8F37E0", VA = "0x8F37E0")]
		public RESULT getBankList(out Bank[] array)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600067A")]
		[Address(RVA = "0x8F37E8", Offset = "0x8F37E8", VA = "0x8F37E8")]
		public RESULT getParameterDescriptionCount(out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600067B")]
		[Address(RVA = "0x8F37F0", Offset = "0x8F37F0", VA = "0x8F37F0")]
		public RESULT getParameterDescriptionList(out PARAMETER_DESCRIPTION[] array)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0x8F37F8", Offset = "0x8F37F8", VA = "0x8F37F8")]
		public RESULT getCPUUsage(out CPU_USAGE usage)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600067D")]
		[Address(RVA = "0x8F3800", Offset = "0x8F3800", VA = "0x8F3800")]
		public RESULT getBufferUsage(out BUFFER_USAGE usage)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0x8F3808", Offset = "0x8F3808", VA = "0x8F3808")]
		public RESULT resetBufferUsage()
		{
			return default(RESULT);
		}

		[Token(Token = "0x600067F")]
		[Address(RVA = "0x8F3810", Offset = "0x8F3810", VA = "0x8F3810")]
		public RESULT setCallback(SYSTEM_CALLBACK callback, SYSTEM_CALLBACK_TYPE callbackmask = SYSTEM_CALLBACK_TYPE.ALL)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000680")]
		[Address(RVA = "0x8F3818", Offset = "0x8F3818", VA = "0x8F3818")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000681")]
		[Address(RVA = "0x8F3820", Offset = "0x8F3820", VA = "0x8F3820")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000682")]
		[Address(RVA = "0x151A834", Offset = "0x151A834", VA = "0x151A834")]
		private static extern RESULT FMOD_Studio_System_Create(out IntPtr system, uint headerversion);

		[PreserveSig]
		[Token(Token = "0x6000683")]
		[Address(RVA = "0x151E2CC", Offset = "0x151E2CC", VA = "0x151E2CC")]
		private static extern bool FMOD_Studio_System_IsValid(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x6000684")]
		[Address(RVA = "0x151A988", Offset = "0x151A988", VA = "0x151A988")]
		private static extern RESULT FMOD_Studio_System_SetAdvancedSettings(IntPtr system, ref ADVANCEDSETTINGS settings);

		[PreserveSig]
		[Token(Token = "0x6000685")]
		[Address(RVA = "0x151AC48", Offset = "0x151AC48", VA = "0x151AC48")]
		private static extern RESULT FMOD_Studio_System_GetAdvancedSettings(IntPtr system, out ADVANCEDSETTINGS settings);

		[PreserveSig]
		[Token(Token = "0x6000686")]
		[Address(RVA = "0x151ACE0", Offset = "0x151ACE0", VA = "0x151ACE0")]
		private static extern RESULT FMOD_Studio_System_Initialize(IntPtr system, int maxchannels, INITFLAGS studioflags, FMOD.INITFLAGS flags, IntPtr extradriverdata);

		[PreserveSig]
		[Token(Token = "0x6000687")]
		[Address(RVA = "0x151AD98", Offset = "0x151AD98", VA = "0x151AD98")]
		private static extern RESULT FMOD_Studio_System_Release(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x6000688")]
		[Address(RVA = "0x151AE20", Offset = "0x151AE20", VA = "0x151AE20")]
		private static extern RESULT FMOD_Studio_System_Update(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x6000689")]
		[Address(RVA = "0x151AEA8", Offset = "0x151AEA8", VA = "0x151AEA8")]
		private static extern RESULT FMOD_Studio_System_GetCoreSystem(IntPtr system, out IntPtr coresystem);

		[PreserveSig]
		[Token(Token = "0x600068A")]
		[Address(RVA = "0x151B088", Offset = "0x151B088", VA = "0x151B088")]
		private static extern RESULT FMOD_Studio_System_GetEvent(IntPtr system, byte[] path, out IntPtr _event);

		[PreserveSig]
		[Token(Token = "0x600068B")]
		[Address(RVA = "0x151B278", Offset = "0x151B278", VA = "0x151B278")]
		private static extern RESULT FMOD_Studio_System_GetBus(IntPtr system, byte[] path, out IntPtr bus);

		[PreserveSig]
		[Token(Token = "0x600068C")]
		[Address(RVA = "0x151B468", Offset = "0x151B468", VA = "0x151B468")]
		private static extern RESULT FMOD_Studio_System_GetVCA(IntPtr system, byte[] path, out IntPtr vca);

		[PreserveSig]
		[Token(Token = "0x600068D")]
		[Address(RVA = "0x151B658", Offset = "0x151B658", VA = "0x151B658")]
		private static extern RESULT FMOD_Studio_System_GetBank(IntPtr system, byte[] path, out IntPtr bank);

		[PreserveSig]
		[Token(Token = "0x600068E")]
		[Address(RVA = "0x151B724", Offset = "0x151B724", VA = "0x151B724")]
		private static extern RESULT FMOD_Studio_System_GetEventByID(IntPtr system, ref Guid id, out IntPtr _event);

		[PreserveSig]
		[Token(Token = "0x600068F")]
		[Address(RVA = "0x151B7E8", Offset = "0x151B7E8", VA = "0x151B7E8")]
		private static extern RESULT FMOD_Studio_System_GetBusByID(IntPtr system, ref Guid id, out IntPtr bus);

		[PreserveSig]
		[Token(Token = "0x6000690")]
		[Address(RVA = "0x151B8AC", Offset = "0x151B8AC", VA = "0x151B8AC")]
		private static extern RESULT FMOD_Studio_System_GetVCAByID(IntPtr system, ref Guid id, out IntPtr vca);

		[PreserveSig]
		[Token(Token = "0x6000691")]
		[Address(RVA = "0x151B970", Offset = "0x151B970", VA = "0x151B970")]
		private static extern RESULT FMOD_Studio_System_GetBankByID(IntPtr system, ref Guid id, out IntPtr bank);

		[PreserveSig]
		[Token(Token = "0x6000692")]
		[Address(RVA = "0x151BB58", Offset = "0x151BB58", VA = "0x151BB58")]
		private static extern RESULT FMOD_Studio_System_GetSoundInfo(IntPtr system, byte[] key, out SOUND_INFO info);

		[PreserveSig]
		[Token(Token = "0x6000693")]
		[Address(RVA = "0x151BDEC", Offset = "0x151BDEC", VA = "0x151BDEC")]
		private static extern RESULT FMOD_Studio_System_GetParameterDescriptionByName(IntPtr system, byte[] name, out PARAMETER_DESCRIPTION parameter);

		[PreserveSig]
		[Token(Token = "0x6000694")]
		[Address(RVA = "0x151BE94", Offset = "0x151BE94", VA = "0x151BE94")]
		private static extern RESULT FMOD_Studio_System_GetParameterDescriptionByID(IntPtr system, PARAMETER_ID id, out PARAMETER_DESCRIPTION parameter);

		[PreserveSig]
		[Token(Token = "0x6000695")]
		[Address(RVA = "0x151BF5C", Offset = "0x151BF5C", VA = "0x151BF5C")]
		private static extern RESULT FMOD_Studio_System_GetParameterByID(IntPtr system, PARAMETER_ID id, out float value, out float finalvalue);

		[PreserveSig]
		[Token(Token = "0x6000696")]
		[Address(RVA = "0x151C010", Offset = "0x151C010", VA = "0x151C010")]
		private static extern RESULT FMOD_Studio_System_SetParameterByID(IntPtr system, PARAMETER_ID id, float value, bool ignoreseekspeed);

		[PreserveSig]
		[Token(Token = "0x6000697")]
		[Address(RVA = "0x151C0C4", Offset = "0x151C0C4", VA = "0x151C0C4")]
		private static extern RESULT FMOD_Studio_System_SetParametersByIDs(IntPtr system, PARAMETER_ID[] ids, float[] values, int count, bool ignoreseekspeed);

		[PreserveSig]
		[Token(Token = "0x6000698")]
		[Address(RVA = "0x151C308", Offset = "0x151C308", VA = "0x151C308")]
		private static extern RESULT FMOD_Studio_System_GetParameterByName(IntPtr system, byte[] name, out float value, out float finalvalue);

		[PreserveSig]
		[Token(Token = "0x6000699")]
		[Address(RVA = "0x151C518", Offset = "0x151C518", VA = "0x151C518")]
		private static extern RESULT FMOD_Studio_System_SetParameterByName(IntPtr system, byte[] name, float value, bool ignoreseekspeed);

		[PreserveSig]
		[Token(Token = "0x600069A")]
		[Address(RVA = "0x151C718", Offset = "0x151C718", VA = "0x151C718")]
		private static extern RESULT FMOD_Studio_System_LookupID(IntPtr system, byte[] path, out Guid id);

		[PreserveSig]
		[Token(Token = "0x600069B")]
		[Address(RVA = "0x151C9FC", Offset = "0x151C9FC", VA = "0x151C9FC")]
		private static extern RESULT FMOD_Studio_System_LookupPath(IntPtr system, ref Guid id, IntPtr path, int size, out int retrieved);

		[PreserveSig]
		[Token(Token = "0x600069C")]
		[Address(RVA = "0x151CAB4", Offset = "0x151CAB4", VA = "0x151CAB4")]
		private static extern RESULT FMOD_Studio_System_GetNumListeners(IntPtr system, out int numlisteners);

		[PreserveSig]
		[Token(Token = "0x600069D")]
		[Address(RVA = "0x151CB4C", Offset = "0x151CB4C", VA = "0x151CB4C")]
		private static extern RESULT FMOD_Studio_System_SetNumListeners(IntPtr system, int numlisteners);

		[PreserveSig]
		[Token(Token = "0x600069E")]
		[Address(RVA = "0x151CBE4", Offset = "0x151CBE4", VA = "0x151CBE4")]
		private static extern RESULT FMOD_Studio_System_GetListenerAttributes(IntPtr system, int listener, out ATTRIBUTES_3D attributes);

		[PreserveSig]
		[Token(Token = "0x600069F")]
		[Address(RVA = "0x151CC84", Offset = "0x151CC84", VA = "0x151CC84")]
		private static extern RESULT FMOD_Studio_System_SetListenerAttributes(IntPtr system, int listener, ref ATTRIBUTES_3D attributes);

		[PreserveSig]
		[Token(Token = "0x60006A0")]
		[Address(RVA = "0x151CD24", Offset = "0x151CD24", VA = "0x151CD24")]
		private static extern RESULT FMOD_Studio_System_GetListenerWeight(IntPtr system, int listener, out float weight);

		[PreserveSig]
		[Token(Token = "0x60006A1")]
		[Address(RVA = "0x151CDC4", Offset = "0x151CDC4", VA = "0x151CDC4")]
		private static extern RESULT FMOD_Studio_System_SetListenerWeight(IntPtr system, int listener, float weight);

		[PreserveSig]
		[Token(Token = "0x60006A2")]
		[Address(RVA = "0x151CFC4", Offset = "0x151CFC4", VA = "0x151CFC4")]
		private static extern RESULT FMOD_Studio_System_LoadBankFile(IntPtr system, byte[] filename, LOAD_BANK_FLAGS flags, out IntPtr bank);

		[PreserveSig]
		[Token(Token = "0x60006A3")]
		[Address(RVA = "0x151D104", Offset = "0x151D104", VA = "0x151D104")]
		private static extern RESULT FMOD_Studio_System_LoadBankMemory(IntPtr system, IntPtr buffer, int length, LOAD_MEMORY_MODE mode, LOAD_BANK_FLAGS flags, out IntPtr bank);

		[PreserveSig]
		[Token(Token = "0x60006A4")]
		[Address(RVA = "0x151D2A4", Offset = "0x151D2A4", VA = "0x151D2A4")]
		private static extern RESULT FMOD_Studio_System_LoadBankCustom(IntPtr system, ref BANK_INFO info, LOAD_BANK_FLAGS flags, out IntPtr bank);

		[PreserveSig]
		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x151D3B0", Offset = "0x151D3B0", VA = "0x151D3B0")]
		private static extern RESULT FMOD_Studio_System_UnloadAll(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x151D438", Offset = "0x151D438", VA = "0x151D438")]
		private static extern RESULT FMOD_Studio_System_FlushCommands(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x60006A7")]
		[Address(RVA = "0x151D4C0", Offset = "0x151D4C0", VA = "0x151D4C0")]
		private static extern RESULT FMOD_Studio_System_FlushSampleLoading(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x60006A8")]
		[Address(RVA = "0x151D690", Offset = "0x151D690", VA = "0x151D690")]
		private static extern RESULT FMOD_Studio_System_StartCommandCapture(IntPtr system, byte[] filename, COMMANDCAPTURE_FLAGS flags);

		[PreserveSig]
		[Token(Token = "0x60006A9")]
		[Address(RVA = "0x151D738", Offset = "0x151D738", VA = "0x151D738")]
		private static extern RESULT FMOD_Studio_System_StopCommandCapture(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x60006AA")]
		[Address(RVA = "0x151D918", Offset = "0x151D918", VA = "0x151D918")]
		private static extern RESULT FMOD_Studio_System_LoadCommandReplay(IntPtr system, byte[] filename, COMMANDREPLAY_FLAGS flags, out IntPtr replay);

		[PreserveSig]
		[Token(Token = "0x60006AB")]
		[Address(RVA = "0x151D9D0", Offset = "0x151D9D0", VA = "0x151D9D0")]
		private static extern RESULT FMOD_Studio_System_GetBankCount(IntPtr system, out int count);

		[PreserveSig]
		[Token(Token = "0x60006AC")]
		[Address(RVA = "0x151DBB0", Offset = "0x151DBB0", VA = "0x151DBB0")]
		private static extern RESULT FMOD_Studio_System_GetBankList(IntPtr system, IntPtr[] array, int capacity, out int count);

		[PreserveSig]
		[Token(Token = "0x60006AD")]
		[Address(RVA = "0x151DC68", Offset = "0x151DC68", VA = "0x151DC68")]
		private static extern RESULT FMOD_Studio_System_GetParameterDescriptionCount(IntPtr system, out int count);

		[PreserveSig]
		[Token(Token = "0x60006AE")]
		[Address(RVA = "0x151DDEC", Offset = "0x151DDEC", VA = "0x151DDEC")]
		private static extern RESULT FMOD_Studio_System_GetParameterDescriptionList(IntPtr system, [Out] PARAMETER_DESCRIPTION[] array, int capacity, out int count);

		[PreserveSig]
		[Token(Token = "0x60006AF")]
		[Address(RVA = "0x151DF44", Offset = "0x151DF44", VA = "0x151DF44")]
		private static extern RESULT FMOD_Studio_System_GetCPUUsage(IntPtr system, out CPU_USAGE usage);

		[PreserveSig]
		[Token(Token = "0x60006B0")]
		[Address(RVA = "0x151DFDC", Offset = "0x151DFDC", VA = "0x151DFDC")]
		private static extern RESULT FMOD_Studio_System_GetBufferUsage(IntPtr system, out BUFFER_USAGE usage);

		[PreserveSig]
		[Token(Token = "0x60006B1")]
		[Address(RVA = "0x151E074", Offset = "0x151E074", VA = "0x151E074")]
		private static extern RESULT FMOD_Studio_System_ResetBufferUsage(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x60006B2")]
		[Address(RVA = "0x151E0FC", Offset = "0x151E0FC", VA = "0x151E0FC")]
		private static extern RESULT FMOD_Studio_System_SetCallback(IntPtr system, SYSTEM_CALLBACK callback, SYSTEM_CALLBACK_TYPE callbackmask);

		[PreserveSig]
		[Token(Token = "0x60006B3")]
		[Address(RVA = "0x151E1A4", Offset = "0x151E1A4", VA = "0x151E1A4")]
		private static extern RESULT FMOD_Studio_System_GetUserData(IntPtr system, out IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x151E23C", Offset = "0x151E23C", VA = "0x151E23C")]
		private static extern RESULT FMOD_Studio_System_SetUserData(IntPtr system, IntPtr userdata);

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x8F3828", Offset = "0x8F3828", VA = "0x8F3828")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x8F3830", Offset = "0x8F3830", VA = "0x8F3830")]
		public void clearHandle()
		{
		}

		[Token(Token = "0x60006B7")]
		[Address(RVA = "0x8F3874", Offset = "0x8F3874", VA = "0x8F3874")]
		public bool isValid()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000126")]
	public struct EventDescription
	{
		[Token(Token = "0x4000666")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0x8F309C", Offset = "0x8F309C", VA = "0x8F309C")]
		public RESULT getID(out Guid id)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006B9")]
		[Address(RVA = "0x8F30A4", Offset = "0x8F30A4", VA = "0x8F30A4")]
		public RESULT getPath(out string path)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0x8F30AC", Offset = "0x8F30AC", VA = "0x8F30AC")]
		public RESULT getParameterDescriptionCount(out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006BB")]
		[Address(RVA = "0x8F30B4", Offset = "0x8F30B4", VA = "0x8F30B4")]
		public RESULT getParameterDescriptionByIndex(int index, out PARAMETER_DESCRIPTION parameter)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006BC")]
		[Address(RVA = "0x8F30BC", Offset = "0x8F30BC", VA = "0x8F30BC")]
		public RESULT getParameterDescriptionByName(string name, out PARAMETER_DESCRIPTION parameter)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006BD")]
		[Address(RVA = "0x8F30C4", Offset = "0x8F30C4", VA = "0x8F30C4")]
		public RESULT getParameterDescriptionByID(PARAMETER_ID id, out PARAMETER_DESCRIPTION parameter)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006BE")]
		[Address(RVA = "0x8F30CC", Offset = "0x8F30CC", VA = "0x8F30CC")]
		public RESULT getUserPropertyCount(out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006BF")]
		[Address(RVA = "0x8F30D4", Offset = "0x8F30D4", VA = "0x8F30D4")]
		public RESULT getUserPropertyByIndex(int index, out USER_PROPERTY property)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0x8F30DC", Offset = "0x8F30DC", VA = "0x8F30DC")]
		public RESULT getUserProperty(string name, out USER_PROPERTY property)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0x8F30E4", Offset = "0x8F30E4", VA = "0x8F30E4")]
		public RESULT getLength(out int length)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0x8F30EC", Offset = "0x8F30EC", VA = "0x8F30EC")]
		public RESULT getMinimumDistance(out float distance)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006C3")]
		[Address(RVA = "0x8F30F4", Offset = "0x8F30F4", VA = "0x8F30F4")]
		public RESULT getMaximumDistance(out float distance)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0x8F30FC", Offset = "0x8F30FC", VA = "0x8F30FC")]
		public RESULT getSoundSize(out float size)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006C5")]
		[Address(RVA = "0x8F3104", Offset = "0x8F3104", VA = "0x8F3104")]
		public RESULT isSnapshot(out bool snapshot)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0x8F310C", Offset = "0x8F310C", VA = "0x8F310C")]
		public RESULT isOneshot(out bool oneshot)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0x8F3114", Offset = "0x8F3114", VA = "0x8F3114")]
		public RESULT isStream(out bool isStream)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0x8F311C", Offset = "0x8F311C", VA = "0x8F311C")]
		public RESULT is3D(out bool is3D)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0x8F3124", Offset = "0x8F3124", VA = "0x8F3124")]
		public RESULT hasCue(out bool cue)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0x8F312C", Offset = "0x8F312C", VA = "0x8F312C")]
		public RESULT createInstance(out EventInstance instance)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0x8F3134", Offset = "0x8F3134", VA = "0x8F3134")]
		public RESULT getInstanceCount(out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0x8F313C", Offset = "0x8F313C", VA = "0x8F313C")]
		public RESULT getInstanceList(out EventInstance[] array)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0x8F3144", Offset = "0x8F3144", VA = "0x8F3144")]
		public RESULT loadSampleData()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0x8F314C", Offset = "0x8F314C", VA = "0x8F314C")]
		public RESULT unloadSampleData()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0x8F3154", Offset = "0x8F3154", VA = "0x8F3154")]
		public RESULT getSampleLoadingState(out LOADING_STATE state)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0x8F315C", Offset = "0x8F315C", VA = "0x8F315C")]
		public RESULT releaseAllInstances()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0x8F3164", Offset = "0x8F3164", VA = "0x8F3164")]
		public RESULT setCallback(EVENT_CALLBACK callback, EVENT_CALLBACK_TYPE callbackmask = EVENT_CALLBACK_TYPE.ALL)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0x8F316C", Offset = "0x8F316C", VA = "0x8F316C")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0x8F3174", Offset = "0x8F3174", VA = "0x8F3174")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x60006D4")]
		[Address(RVA = "0x1518910", Offset = "0x1518910", VA = "0x1518910")]
		private static extern bool FMOD_Studio_EventDescription_IsValid(IntPtr eventdescription);

		[PreserveSig]
		[Token(Token = "0x60006D5")]
		[Address(RVA = "0x1517124", Offset = "0x1517124", VA = "0x1517124")]
		private static extern RESULT FMOD_Studio_EventDescription_GetID(IntPtr eventdescription, out Guid id);

		[PreserveSig]
		[Token(Token = "0x60006D6")]
		[Address(RVA = "0x15173EC", Offset = "0x15173EC", VA = "0x15173EC")]
		private static extern RESULT FMOD_Studio_EventDescription_GetPath(IntPtr eventdescription, IntPtr path, int size, out int retrieved);

		[PreserveSig]
		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x151749C", Offset = "0x151749C", VA = "0x151749C")]
		private static extern RESULT FMOD_Studio_EventDescription_GetParameterDescriptionCount(IntPtr eventdescription, out int count);

		[PreserveSig]
		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x1517534", Offset = "0x1517534", VA = "0x1517534")]
		private static extern RESULT FMOD_Studio_EventDescription_GetParameterDescriptionByIndex(IntPtr eventdescription, int index, out PARAMETER_DESCRIPTION parameter);

		[PreserveSig]
		[Token(Token = "0x60006D9")]
		[Address(RVA = "0x151771C", Offset = "0x151771C", VA = "0x151771C")]
		private static extern RESULT FMOD_Studio_EventDescription_GetParameterDescriptionByName(IntPtr eventdescription, byte[] name, out PARAMETER_DESCRIPTION parameter);

		[PreserveSig]
		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x15177C4", Offset = "0x15177C4", VA = "0x15177C4")]
		private static extern RESULT FMOD_Studio_EventDescription_GetParameterDescriptionByID(IntPtr eventdescription, PARAMETER_ID id, out PARAMETER_DESCRIPTION parameter);

		[PreserveSig]
		[Token(Token = "0x60006DB")]
		[Address(RVA = "0x1517864", Offset = "0x1517864", VA = "0x1517864")]
		private static extern RESULT FMOD_Studio_EventDescription_GetUserPropertyCount(IntPtr eventdescription, out int count);

		[PreserveSig]
		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x15178FC", Offset = "0x15178FC", VA = "0x15178FC")]
		private static extern RESULT FMOD_Studio_EventDescription_GetUserPropertyByIndex(IntPtr eventdescription, int index, out USER_PROPERTY property);

		[PreserveSig]
		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x1517B30", Offset = "0x1517B30", VA = "0x1517B30")]
		private static extern RESULT FMOD_Studio_EventDescription_GetUserProperty(IntPtr eventdescription, byte[] name, out USER_PROPERTY property);

		[PreserveSig]
		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x1517C24", Offset = "0x1517C24", VA = "0x1517C24")]
		private static extern RESULT FMOD_Studio_EventDescription_GetLength(IntPtr eventdescription, out int length);

		[PreserveSig]
		[Token(Token = "0x60006DF")]
		[Address(RVA = "0x1517CBC", Offset = "0x1517CBC", VA = "0x1517CBC")]
		private static extern RESULT FMOD_Studio_EventDescription_GetMinimumDistance(IntPtr eventdescription, out float distance);

		[PreserveSig]
		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x1517D54", Offset = "0x1517D54", VA = "0x1517D54")]
		private static extern RESULT FMOD_Studio_EventDescription_GetMaximumDistance(IntPtr eventdescription, out float distance);

		[PreserveSig]
		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x1517DEC", Offset = "0x1517DEC", VA = "0x1517DEC")]
		private static extern RESULT FMOD_Studio_EventDescription_GetSoundSize(IntPtr eventdescription, out float size);

		[PreserveSig]
		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x1517E84", Offset = "0x1517E84", VA = "0x1517E84")]
		private static extern RESULT FMOD_Studio_EventDescription_IsSnapshot(IntPtr eventdescription, out bool snapshot);

		[PreserveSig]
		[Token(Token = "0x60006E3")]
		[Address(RVA = "0x1517F30", Offset = "0x1517F30", VA = "0x1517F30")]
		private static extern RESULT FMOD_Studio_EventDescription_IsOneshot(IntPtr eventdescription, out bool oneshot);

		[PreserveSig]
		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x1517FDC", Offset = "0x1517FDC", VA = "0x1517FDC")]
		private static extern RESULT FMOD_Studio_EventDescription_IsStream(IntPtr eventdescription, out bool isStream);

		[PreserveSig]
		[Token(Token = "0x60006E5")]
		[Address(RVA = "0x1518088", Offset = "0x1518088", VA = "0x1518088")]
		private static extern RESULT FMOD_Studio_EventDescription_Is3D(IntPtr eventdescription, out bool is3D);

		[PreserveSig]
		[Token(Token = "0x60006E6")]
		[Address(RVA = "0x1518134", Offset = "0x1518134", VA = "0x1518134")]
		private static extern RESULT FMOD_Studio_EventDescription_HasCue(IntPtr eventdescription, out bool cue);

		[PreserveSig]
		[Token(Token = "0x60006E7")]
		[Address(RVA = "0x15181E0", Offset = "0x15181E0", VA = "0x15181E0")]
		private static extern RESULT FMOD_Studio_EventDescription_CreateInstance(IntPtr eventdescription, out IntPtr instance);

		[PreserveSig]
		[Token(Token = "0x60006E8")]
		[Address(RVA = "0x1518278", Offset = "0x1518278", VA = "0x1518278")]
		private static extern RESULT FMOD_Studio_EventDescription_GetInstanceCount(IntPtr eventdescription, out int count);

		[PreserveSig]
		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x1518458", Offset = "0x1518458", VA = "0x1518458")]
		private static extern RESULT FMOD_Studio_EventDescription_GetInstanceList(IntPtr eventdescription, IntPtr[] array, int capacity, out int count);

		[PreserveSig]
		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x1518510", Offset = "0x1518510", VA = "0x1518510")]
		private static extern RESULT FMOD_Studio_EventDescription_LoadSampleData(IntPtr eventdescription);

		[PreserveSig]
		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x1518598", Offset = "0x1518598", VA = "0x1518598")]
		private static extern RESULT FMOD_Studio_EventDescription_UnloadSampleData(IntPtr eventdescription);

		[PreserveSig]
		[Token(Token = "0x60006EC")]
		[Address(RVA = "0x1518620", Offset = "0x1518620", VA = "0x1518620")]
		private static extern RESULT FMOD_Studio_EventDescription_GetSampleLoadingState(IntPtr eventdescription, out LOADING_STATE state);

		[PreserveSig]
		[Token(Token = "0x60006ED")]
		[Address(RVA = "0x15186B8", Offset = "0x15186B8", VA = "0x15186B8")]
		private static extern RESULT FMOD_Studio_EventDescription_ReleaseAllInstances(IntPtr eventdescription);

		[PreserveSig]
		[Token(Token = "0x60006EE")]
		[Address(RVA = "0x1518740", Offset = "0x1518740", VA = "0x1518740")]
		private static extern RESULT FMOD_Studio_EventDescription_SetCallback(IntPtr eventdescription, EVENT_CALLBACK callback, EVENT_CALLBACK_TYPE callbackmask);

		[PreserveSig]
		[Token(Token = "0x60006EF")]
		[Address(RVA = "0x15187E8", Offset = "0x15187E8", VA = "0x15187E8")]
		private static extern RESULT FMOD_Studio_EventDescription_GetUserData(IntPtr eventdescription, out IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x60006F0")]
		[Address(RVA = "0x1518880", Offset = "0x1518880", VA = "0x1518880")]
		private static extern RESULT FMOD_Studio_EventDescription_SetUserData(IntPtr eventdescription, IntPtr userdata);

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0x8F317C", Offset = "0x8F317C", VA = "0x8F317C")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0x8F3184", Offset = "0x8F3184", VA = "0x8F3184")]
		public void clearHandle()
		{
		}

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0x8F31C8", Offset = "0x8F31C8", VA = "0x8F31C8")]
		public bool isValid()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000127")]
	public struct EventInstance
	{
		[Token(Token = "0x4000667")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0x8F31D0", Offset = "0x8F31D0", VA = "0x8F31D0")]
		public RESULT getDescription(out EventDescription description)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0x8F31D8", Offset = "0x8F31D8", VA = "0x8F31D8")]
		public RESULT getVolume(out float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0x8F3200", Offset = "0x8F3200", VA = "0x8F3200")]
		public RESULT getVolume(out float volume, out float finalvolume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006F7")]
		[Address(RVA = "0x8F3208", Offset = "0x8F3208", VA = "0x8F3208")]
		public RESULT setVolume(float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006F8")]
		[Address(RVA = "0x8F3210", Offset = "0x8F3210", VA = "0x8F3210")]
		public RESULT getPitch(out float pitch)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006F9")]
		[Address(RVA = "0x8F3238", Offset = "0x8F3238", VA = "0x8F3238")]
		public RESULT getPitch(out float pitch, out float finalpitch)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006FA")]
		[Address(RVA = "0x8F3240", Offset = "0x8F3240", VA = "0x8F3240")]
		public RESULT setPitch(float pitch)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006FB")]
		[Address(RVA = "0x8F3248", Offset = "0x8F3248", VA = "0x8F3248")]
		public RESULT get3DAttributes(out ATTRIBUTES_3D attributes)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0x8F3250", Offset = "0x8F3250", VA = "0x8F3250")]
		public RESULT set3DAttributes(ATTRIBUTES_3D attributes)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0x8F3284", Offset = "0x8F3284", VA = "0x8F3284")]
		public RESULT getListenerMask(out uint mask)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0x8F328C", Offset = "0x8F328C", VA = "0x8F328C")]
		public RESULT setListenerMask(uint mask)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006FF")]
		[Address(RVA = "0x8F3294", Offset = "0x8F3294", VA = "0x8F3294")]
		public RESULT getProperty(EVENT_PROPERTY index, out float value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000700")]
		[Address(RVA = "0x8F329C", Offset = "0x8F329C", VA = "0x8F329C")]
		public RESULT setProperty(EVENT_PROPERTY index, float value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000701")]
		[Address(RVA = "0x8F32A4", Offset = "0x8F32A4", VA = "0x8F32A4")]
		public RESULT getReverbLevel(int index, out float level)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000702")]
		[Address(RVA = "0x8F32AC", Offset = "0x8F32AC", VA = "0x8F32AC")]
		public RESULT setReverbLevel(int index, float level)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000703")]
		[Address(RVA = "0x8F32B4", Offset = "0x8F32B4", VA = "0x8F32B4")]
		public RESULT getPaused(out bool paused)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000704")]
		[Address(RVA = "0x8F32BC", Offset = "0x8F32BC", VA = "0x8F32BC")]
		public RESULT setPaused(bool paused)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0x8F32C8", Offset = "0x8F32C8", VA = "0x8F32C8")]
		public RESULT start()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000706")]
		[Address(RVA = "0x8F32D0", Offset = "0x8F32D0", VA = "0x8F32D0")]
		public RESULT stop(STOP_MODE mode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0x8F32D8", Offset = "0x8F32D8", VA = "0x8F32D8")]
		public RESULT getTimelinePosition(out int position)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0x8F32E0", Offset = "0x8F32E0", VA = "0x8F32E0")]
		public RESULT setTimelinePosition(int position)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000709")]
		[Address(RVA = "0x8F32E8", Offset = "0x8F32E8", VA = "0x8F32E8")]
		public RESULT getPlaybackState(out PLAYBACK_STATE state)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600070A")]
		[Address(RVA = "0x8F32F0", Offset = "0x8F32F0", VA = "0x8F32F0")]
		public RESULT getChannelGroup(out ChannelGroup group)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0x8F32F8", Offset = "0x8F32F8", VA = "0x8F32F8")]
		public RESULT release()
		{
			return default(RESULT);
		}

		[Token(Token = "0x600070C")]
		[Address(RVA = "0x8F3300", Offset = "0x8F3300", VA = "0x8F3300")]
		public RESULT isVirtual(out bool virtualstate)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600070D")]
		[Address(RVA = "0x8F3308", Offset = "0x8F3308", VA = "0x8F3308")]
		public RESULT getParameterByID(PARAMETER_ID id, out float value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600070E")]
		[Address(RVA = "0x8F3330", Offset = "0x8F3330", VA = "0x8F3330")]
		public RESULT getParameterByID(PARAMETER_ID id, out float value, out float finalvalue)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0x8F3338", Offset = "0x8F3338", VA = "0x8F3338")]
		public RESULT setParameterByID(PARAMETER_ID id, float value, bool ignoreseekspeed = false)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0x8F3344", Offset = "0x8F3344", VA = "0x8F3344")]
		public RESULT setParametersByIDs(PARAMETER_ID[] ids, float[] values, int count, bool ignoreseekspeed = false)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0x8F3350", Offset = "0x8F3350", VA = "0x8F3350")]
		public RESULT getParameterByName(string name, out float value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000712")]
		[Address(RVA = "0x8F3378", Offset = "0x8F3378", VA = "0x8F3378")]
		public RESULT getParameterByName(string name, out float value, out float finalvalue)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000713")]
		[Address(RVA = "0x8F3380", Offset = "0x8F3380", VA = "0x8F3380")]
		public RESULT setParameterByName(string name, float value, bool ignoreseekspeed = false)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000714")]
		[Address(RVA = "0x8F338C", Offset = "0x8F338C", VA = "0x8F338C")]
		public RESULT triggerCue()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000715")]
		[Address(RVA = "0x8F3394", Offset = "0x8F3394", VA = "0x8F3394")]
		public RESULT setCallback(EVENT_CALLBACK callback, EVENT_CALLBACK_TYPE callbackmask = EVENT_CALLBACK_TYPE.ALL)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000716")]
		[Address(RVA = "0x8F339C", Offset = "0x8F339C", VA = "0x8F339C")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000717")]
		[Address(RVA = "0x8F33A4", Offset = "0x8F33A4", VA = "0x8F33A4")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000718")]
		[Address(RVA = "0x151A1A0", Offset = "0x151A1A0", VA = "0x151A1A0")]
		private static extern bool FMOD_Studio_EventInstance_IsValid(IntPtr _event);

		[PreserveSig]
		[Token(Token = "0x6000719")]
		[Address(RVA = "0x1518A68", Offset = "0x1518A68", VA = "0x1518A68")]
		private static extern RESULT FMOD_Studio_EventInstance_GetDescription(IntPtr _event, out IntPtr description);

		[PreserveSig]
		[Token(Token = "0x600071A")]
		[Address(RVA = "0x1518B28", Offset = "0x1518B28", VA = "0x1518B28")]
		private static extern RESULT FMOD_Studio_EventInstance_GetVolume(IntPtr _event, out float volume, out float finalvolume);

		[PreserveSig]
		[Token(Token = "0x600071B")]
		[Address(RVA = "0x1518BC8", Offset = "0x1518BC8", VA = "0x1518BC8")]
		private static extern RESULT FMOD_Studio_EventInstance_SetVolume(IntPtr _event, float volume);

		[PreserveSig]
		[Token(Token = "0x600071C")]
		[Address(RVA = "0x1518C88", Offset = "0x1518C88", VA = "0x1518C88")]
		private static extern RESULT FMOD_Studio_EventInstance_GetPitch(IntPtr _event, out float pitch, out float finalpitch);

		[PreserveSig]
		[Token(Token = "0x600071D")]
		[Address(RVA = "0x1518D28", Offset = "0x1518D28", VA = "0x1518D28")]
		private static extern RESULT FMOD_Studio_EventInstance_SetPitch(IntPtr _event, float pitch);

		[PreserveSig]
		[Token(Token = "0x600071E")]
		[Address(RVA = "0x1518DC0", Offset = "0x1518DC0", VA = "0x1518DC0")]
		private static extern RESULT FMOD_Studio_EventInstance_Get3DAttributes(IntPtr _event, out ATTRIBUTES_3D attributes);

		[PreserveSig]
		[Token(Token = "0x600071F")]
		[Address(RVA = "0x1518E58", Offset = "0x1518E58", VA = "0x1518E58")]
		private static extern RESULT FMOD_Studio_EventInstance_Set3DAttributes(IntPtr _event, ref ATTRIBUTES_3D attributes);

		[PreserveSig]
		[Token(Token = "0x6000720")]
		[Address(RVA = "0x1518EF0", Offset = "0x1518EF0", VA = "0x1518EF0")]
		private static extern RESULT FMOD_Studio_EventInstance_GetListenerMask(IntPtr _event, out uint mask);

		[PreserveSig]
		[Token(Token = "0x6000721")]
		[Address(RVA = "0x1518F88", Offset = "0x1518F88", VA = "0x1518F88")]
		private static extern RESULT FMOD_Studio_EventInstance_SetListenerMask(IntPtr _event, uint mask);

		[PreserveSig]
		[Token(Token = "0x6000722")]
		[Address(RVA = "0x1519020", Offset = "0x1519020", VA = "0x1519020")]
		private static extern RESULT FMOD_Studio_EventInstance_GetProperty(IntPtr _event, EVENT_PROPERTY index, out float value);

		[PreserveSig]
		[Token(Token = "0x6000723")]
		[Address(RVA = "0x15190C0", Offset = "0x15190C0", VA = "0x15190C0")]
		private static extern RESULT FMOD_Studio_EventInstance_SetProperty(IntPtr _event, EVENT_PROPERTY index, float value);

		[PreserveSig]
		[Token(Token = "0x6000724")]
		[Address(RVA = "0x1519168", Offset = "0x1519168", VA = "0x1519168")]
		private static extern RESULT FMOD_Studio_EventInstance_GetReverbLevel(IntPtr _event, int index, out float level);

		[PreserveSig]
		[Token(Token = "0x6000725")]
		[Address(RVA = "0x1519208", Offset = "0x1519208", VA = "0x1519208")]
		private static extern RESULT FMOD_Studio_EventInstance_SetReverbLevel(IntPtr _event, int index, float level);

		[PreserveSig]
		[Token(Token = "0x6000726")]
		[Address(RVA = "0x15192B0", Offset = "0x15192B0", VA = "0x15192B0")]
		private static extern RESULT FMOD_Studio_EventInstance_GetPaused(IntPtr _event, out bool paused);

		[PreserveSig]
		[Token(Token = "0x6000727")]
		[Address(RVA = "0x1519360", Offset = "0x1519360", VA = "0x1519360")]
		private static extern RESULT FMOD_Studio_EventInstance_SetPaused(IntPtr _event, bool paused);

		[PreserveSig]
		[Token(Token = "0x6000728")]
		[Address(RVA = "0x15193F8", Offset = "0x15193F8", VA = "0x15193F8")]
		private static extern RESULT FMOD_Studio_EventInstance_Start(IntPtr _event);

		[PreserveSig]
		[Token(Token = "0x6000729")]
		[Address(RVA = "0x1519480", Offset = "0x1519480", VA = "0x1519480")]
		private static extern RESULT FMOD_Studio_EventInstance_Stop(IntPtr _event, STOP_MODE mode);

		[PreserveSig]
		[Token(Token = "0x600072A")]
		[Address(RVA = "0x1519518", Offset = "0x1519518", VA = "0x1519518")]
		private static extern RESULT FMOD_Studio_EventInstance_GetTimelinePosition(IntPtr _event, out int position);

		[PreserveSig]
		[Token(Token = "0x600072B")]
		[Address(RVA = "0x15195B0", Offset = "0x15195B0", VA = "0x15195B0")]
		private static extern RESULT FMOD_Studio_EventInstance_SetTimelinePosition(IntPtr _event, int position);

		[PreserveSig]
		[Token(Token = "0x600072C")]
		[Address(RVA = "0x1519648", Offset = "0x1519648", VA = "0x1519648")]
		private static extern RESULT FMOD_Studio_EventInstance_GetPlaybackState(IntPtr _event, out PLAYBACK_STATE state);

		[PreserveSig]
		[Token(Token = "0x600072D")]
		[Address(RVA = "0x15196E0", Offset = "0x15196E0", VA = "0x15196E0")]
		private static extern RESULT FMOD_Studio_EventInstance_GetChannelGroup(IntPtr _event, out IntPtr group);

		[PreserveSig]
		[Token(Token = "0x600072E")]
		[Address(RVA = "0x1519778", Offset = "0x1519778", VA = "0x1519778")]
		private static extern RESULT FMOD_Studio_EventInstance_Release(IntPtr _event);

		[PreserveSig]
		[Token(Token = "0x600072F")]
		[Address(RVA = "0x1519800", Offset = "0x1519800", VA = "0x1519800")]
		private static extern RESULT FMOD_Studio_EventInstance_IsVirtual(IntPtr _event, out bool virtualstate);

		[PreserveSig]
		[Token(Token = "0x6000730")]
		[Address(RVA = "0x1519C80", Offset = "0x1519C80", VA = "0x1519C80")]
		private static extern RESULT FMOD_Studio_EventInstance_GetParameterByName(IntPtr _event, byte[] name, out float value, out float finalvalue);

		[PreserveSig]
		[Token(Token = "0x6000731")]
		[Address(RVA = "0x1519E90", Offset = "0x1519E90", VA = "0x1519E90")]
		private static extern RESULT FMOD_Studio_EventInstance_SetParameterByName(IntPtr _event, byte[] name, float value, bool ignoreseekspeed);

		[PreserveSig]
		[Token(Token = "0x6000732")]
		[Address(RVA = "0x15198D4", Offset = "0x15198D4", VA = "0x15198D4")]
		private static extern RESULT FMOD_Studio_EventInstance_GetParameterByID(IntPtr _event, PARAMETER_ID id, out float value, out float finalvalue);

		[PreserveSig]
		[Token(Token = "0x6000733")]
		[Address(RVA = "0x1519988", Offset = "0x1519988", VA = "0x1519988")]
		private static extern RESULT FMOD_Studio_EventInstance_SetParameterByID(IntPtr _event, PARAMETER_ID id, float value, bool ignoreseekspeed);

		[PreserveSig]
		[Token(Token = "0x6000734")]
		[Address(RVA = "0x1519A3C", Offset = "0x1519A3C", VA = "0x1519A3C")]
		private static extern RESULT FMOD_Studio_EventInstance_SetParametersByIDs(IntPtr _event, PARAMETER_ID[] ids, float[] values, int count, bool ignoreseekspeed);

		[PreserveSig]
		[Token(Token = "0x6000735")]
		[Address(RVA = "0x1519F48", Offset = "0x1519F48", VA = "0x1519F48")]
		private static extern RESULT FMOD_Studio_EventInstance_TriggerCue(IntPtr _event);

		[PreserveSig]
		[Token(Token = "0x6000736")]
		[Address(RVA = "0x1519FD0", Offset = "0x1519FD0", VA = "0x1519FD0")]
		private static extern RESULT FMOD_Studio_EventInstance_SetCallback(IntPtr _event, EVENT_CALLBACK callback, EVENT_CALLBACK_TYPE callbackmask);

		[PreserveSig]
		[Token(Token = "0x6000737")]
		[Address(RVA = "0x151A078", Offset = "0x151A078", VA = "0x151A078")]
		private static extern RESULT FMOD_Studio_EventInstance_GetUserData(IntPtr _event, out IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x6000738")]
		[Address(RVA = "0x151A110", Offset = "0x151A110", VA = "0x151A110")]
		private static extern RESULT FMOD_Studio_EventInstance_SetUserData(IntPtr _event, IntPtr userdata);

		[Token(Token = "0x6000739")]
		[Address(RVA = "0x8F33AC", Offset = "0x8F33AC", VA = "0x8F33AC")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x600073A")]
		[Address(RVA = "0x8F33B4", Offset = "0x8F33B4", VA = "0x8F33B4")]
		public void clearHandle()
		{
		}

		[Token(Token = "0x600073B")]
		[Address(RVA = "0x8F33F8", Offset = "0x8F33F8", VA = "0x8F33F8")]
		public bool isValid()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000128")]
	public struct Bus
	{
		[Token(Token = "0x4000668")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x600073C")]
		[Address(RVA = "0x8F2E38", Offset = "0x8F2E38", VA = "0x8F2E38")]
		public RESULT getID(out Guid id)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600073D")]
		[Address(RVA = "0x8F2E40", Offset = "0x8F2E40", VA = "0x8F2E40")]
		public RESULT getPath(out string path)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600073E")]
		[Address(RVA = "0x8F2E48", Offset = "0x8F2E48", VA = "0x8F2E48")]
		public RESULT getVolume(out float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600073F")]
		[Address(RVA = "0x8F2E70", Offset = "0x8F2E70", VA = "0x8F2E70")]
		public RESULT getVolume(out float volume, out float finalvolume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000740")]
		[Address(RVA = "0x8F2E78", Offset = "0x8F2E78", VA = "0x8F2E78")]
		public RESULT setVolume(float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000741")]
		[Address(RVA = "0x8F2E80", Offset = "0x8F2E80", VA = "0x8F2E80")]
		public RESULT getPaused(out bool paused)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000742")]
		[Address(RVA = "0x8F2E88", Offset = "0x8F2E88", VA = "0x8F2E88")]
		public RESULT setPaused(bool paused)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000743")]
		[Address(RVA = "0x8F2E94", Offset = "0x8F2E94", VA = "0x8F2E94")]
		public RESULT getMute(out bool mute)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000744")]
		[Address(RVA = "0x8F2E9C", Offset = "0x8F2E9C", VA = "0x8F2E9C")]
		public RESULT setMute(bool mute)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000745")]
		[Address(RVA = "0x8F2EA8", Offset = "0x8F2EA8", VA = "0x8F2EA8")]
		public RESULT stopAllEvents(STOP_MODE mode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000746")]
		[Address(RVA = "0x8F2EB0", Offset = "0x8F2EB0", VA = "0x8F2EB0")]
		public RESULT lockChannelGroup()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000747")]
		[Address(RVA = "0x8F2EB8", Offset = "0x8F2EB8", VA = "0x8F2EB8")]
		public RESULT unlockChannelGroup()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000748")]
		[Address(RVA = "0x8F2EC0", Offset = "0x8F2EC0", VA = "0x8F2EC0")]
		public RESULT getChannelGroup(out ChannelGroup group)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000749")]
		[Address(RVA = "0x1514D9C", Offset = "0x1514D9C", VA = "0x1514D9C")]
		private static extern bool FMOD_Studio_Bus_IsValid(IntPtr bus);

		[PreserveSig]
		[Token(Token = "0x600074A")]
		[Address(RVA = "0x15143FC", Offset = "0x15143FC", VA = "0x15143FC")]
		private static extern RESULT FMOD_Studio_Bus_GetID(IntPtr bus, out Guid id);

		[PreserveSig]
		[Token(Token = "0x600074B")]
		[Address(RVA = "0x15146C4", Offset = "0x15146C4", VA = "0x15146C4")]
		private static extern RESULT FMOD_Studio_Bus_GetPath(IntPtr bus, IntPtr path, int size, out int retrieved);

		[PreserveSig]
		[Token(Token = "0x600074C")]
		[Address(RVA = "0x151479C", Offset = "0x151479C", VA = "0x151479C")]
		private static extern RESULT FMOD_Studio_Bus_GetVolume(IntPtr bus, out float volume, out float finalvolume);

		[PreserveSig]
		[Token(Token = "0x600074D")]
		[Address(RVA = "0x151483C", Offset = "0x151483C", VA = "0x151483C")]
		private static extern RESULT FMOD_Studio_Bus_SetVolume(IntPtr bus, float volume);

		[PreserveSig]
		[Token(Token = "0x600074E")]
		[Address(RVA = "0x15148D4", Offset = "0x15148D4", VA = "0x15148D4")]
		private static extern RESULT FMOD_Studio_Bus_GetPaused(IntPtr bus, out bool paused);

		[PreserveSig]
		[Token(Token = "0x600074F")]
		[Address(RVA = "0x1514984", Offset = "0x1514984", VA = "0x1514984")]
		private static extern RESULT FMOD_Studio_Bus_SetPaused(IntPtr bus, bool paused);

		[PreserveSig]
		[Token(Token = "0x6000750")]
		[Address(RVA = "0x1514A1C", Offset = "0x1514A1C", VA = "0x1514A1C")]
		private static extern RESULT FMOD_Studio_Bus_GetMute(IntPtr bus, out bool mute);

		[PreserveSig]
		[Token(Token = "0x6000751")]
		[Address(RVA = "0x1514ACC", Offset = "0x1514ACC", VA = "0x1514ACC")]
		private static extern RESULT FMOD_Studio_Bus_SetMute(IntPtr bus, bool mute);

		[PreserveSig]
		[Token(Token = "0x6000752")]
		[Address(RVA = "0x1514B64", Offset = "0x1514B64", VA = "0x1514B64")]
		private static extern RESULT FMOD_Studio_Bus_StopAllEvents(IntPtr bus, STOP_MODE mode);

		[PreserveSig]
		[Token(Token = "0x6000753")]
		[Address(RVA = "0x1514BFC", Offset = "0x1514BFC", VA = "0x1514BFC")]
		private static extern RESULT FMOD_Studio_Bus_LockChannelGroup(IntPtr bus);

		[PreserveSig]
		[Token(Token = "0x6000754")]
		[Address(RVA = "0x1514C84", Offset = "0x1514C84", VA = "0x1514C84")]
		private static extern RESULT FMOD_Studio_Bus_UnlockChannelGroup(IntPtr bus);

		[PreserveSig]
		[Token(Token = "0x6000755")]
		[Address(RVA = "0x1514D0C", Offset = "0x1514D0C", VA = "0x1514D0C")]
		private static extern RESULT FMOD_Studio_Bus_GetChannelGroup(IntPtr bus, out IntPtr group);

		[Token(Token = "0x6000756")]
		[Address(RVA = "0x8F2EC8", Offset = "0x8F2EC8", VA = "0x8F2EC8")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x6000757")]
		[Address(RVA = "0x8F2ED0", Offset = "0x8F2ED0", VA = "0x8F2ED0")]
		public void clearHandle()
		{
		}

		[Token(Token = "0x6000758")]
		[Address(RVA = "0x8F2F14", Offset = "0x8F2F14", VA = "0x8F2F14")]
		public bool isValid()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000129")]
	public struct VCA
	{
		[Token(Token = "0x4000669")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x6000759")]
		[Address(RVA = "0x8D2C38", Offset = "0x8D2C38", VA = "0x8D2C38")]
		public RESULT getID(out Guid id)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600075A")]
		[Address(RVA = "0x8D2C40", Offset = "0x8D2C40", VA = "0x8D2C40")]
		public RESULT getPath(out string path)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600075B")]
		[Address(RVA = "0x8D2C48", Offset = "0x8D2C48", VA = "0x8D2C48")]
		public RESULT getVolume(out float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600075C")]
		[Address(RVA = "0x8D2C70", Offset = "0x8D2C70", VA = "0x8D2C70")]
		public RESULT getVolume(out float volume, out float finalvolume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600075D")]
		[Address(RVA = "0x8D2C78", Offset = "0x8D2C78", VA = "0x8D2C78")]
		public RESULT setVolume(float volume)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x600075E")]
		[Address(RVA = "0xCF1058", Offset = "0xCF1058", VA = "0xCF1058")]
		private static extern bool FMOD_Studio_VCA_IsValid(IntPtr vca);

		[PreserveSig]
		[Token(Token = "0x600075F")]
		[Address(RVA = "0xCF0B80", Offset = "0xCF0B80", VA = "0xCF0B80")]
		private static extern RESULT FMOD_Studio_VCA_GetID(IntPtr vca, out Guid id);

		[PreserveSig]
		[Token(Token = "0x6000760")]
		[Address(RVA = "0xCF0E50", Offset = "0xCF0E50", VA = "0xCF0E50")]
		private static extern RESULT FMOD_Studio_VCA_GetPath(IntPtr vca, IntPtr path, int size, out int retrieved);

		[PreserveSig]
		[Token(Token = "0x6000761")]
		[Address(RVA = "0xCF0F28", Offset = "0xCF0F28", VA = "0xCF0F28")]
		private static extern RESULT FMOD_Studio_VCA_GetVolume(IntPtr vca, out float volume, out float finalvolume);

		[PreserveSig]
		[Token(Token = "0x6000762")]
		[Address(RVA = "0xCF0FC8", Offset = "0xCF0FC8", VA = "0xCF0FC8")]
		private static extern RESULT FMOD_Studio_VCA_SetVolume(IntPtr vca, float volume);

		[Token(Token = "0x6000763")]
		[Address(RVA = "0x8D2C80", Offset = "0x8D2C80", VA = "0x8D2C80")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x6000764")]
		[Address(RVA = "0x8D2C88", Offset = "0x8D2C88", VA = "0x8D2C88")]
		public void clearHandle()
		{
		}

		[Token(Token = "0x6000765")]
		[Address(RVA = "0x8D2CCC", Offset = "0x8D2CCC", VA = "0x8D2CCC")]
		public bool isValid()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200012A")]
	public struct Bank
	{
		[Token(Token = "0x400066A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x6000766")]
		[Address(RVA = "0x8F2D5C", Offset = "0x8F2D5C", VA = "0x8F2D5C")]
		public RESULT getID(out Guid id)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000767")]
		[Address(RVA = "0x8F2D64", Offset = "0x8F2D64", VA = "0x8F2D64")]
		public RESULT getPath(out string path)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000768")]
		[Address(RVA = "0x8F2D6C", Offset = "0x8F2D6C", VA = "0x8F2D6C")]
		public RESULT unload()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000769")]
		[Address(RVA = "0x8F2D74", Offset = "0x8F2D74", VA = "0x8F2D74")]
		public RESULT loadSampleData()
		{
			return default(RESULT);
		}

		[Token(Token = "0x600076A")]
		[Address(RVA = "0x8F2D7C", Offset = "0x8F2D7C", VA = "0x8F2D7C")]
		public RESULT unloadSampleData()
		{
			return default(RESULT);
		}

		[Token(Token = "0x600076B")]
		[Address(RVA = "0x8F2D84", Offset = "0x8F2D84", VA = "0x8F2D84")]
		public RESULT getLoadingState(out LOADING_STATE state)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600076C")]
		[Address(RVA = "0x8F2D8C", Offset = "0x8F2D8C", VA = "0x8F2D8C")]
		public RESULT getSampleLoadingState(out LOADING_STATE state)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600076D")]
		[Address(RVA = "0x8F2D94", Offset = "0x8F2D94", VA = "0x8F2D94")]
		public RESULT getStringCount(out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600076E")]
		[Address(RVA = "0x8F2D9C", Offset = "0x8F2D9C", VA = "0x8F2D9C")]
		public RESULT getStringInfo(int index, out Guid id, out string path)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600076F")]
		[Address(RVA = "0x8F2DA4", Offset = "0x8F2DA4", VA = "0x8F2DA4")]
		public RESULT getEventCount(out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000770")]
		[Address(RVA = "0x8F2DAC", Offset = "0x8F2DAC", VA = "0x8F2DAC")]
		public RESULT getEventList(out EventDescription[] array)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000771")]
		[Address(RVA = "0x8F2DB4", Offset = "0x8F2DB4", VA = "0x8F2DB4")]
		public RESULT getBusCount(out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000772")]
		[Address(RVA = "0x8F2DBC", Offset = "0x8F2DBC", VA = "0x8F2DBC")]
		public RESULT getBusList(out Bus[] array)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000773")]
		[Address(RVA = "0x8F2DC4", Offset = "0x8F2DC4", VA = "0x8F2DC4")]
		public RESULT getVCACount(out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000774")]
		[Address(RVA = "0x8F2DCC", Offset = "0x8F2DCC", VA = "0x8F2DCC")]
		public RESULT getVCAList(out VCA[] array)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000775")]
		[Address(RVA = "0x8F2DD4", Offset = "0x8F2DD4", VA = "0x8F2DD4")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000776")]
		[Address(RVA = "0x8F2DDC", Offset = "0x8F2DDC", VA = "0x8F2DDC")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000777")]
		[Address(RVA = "0x15142A4", Offset = "0x15142A4", VA = "0x15142A4")]
		private static extern bool FMOD_Studio_Bank_IsValid(IntPtr bank);

		[PreserveSig]
		[Token(Token = "0x6000778")]
		[Address(RVA = "0x1512F94", Offset = "0x1512F94", VA = "0x1512F94")]
		private static extern RESULT FMOD_Studio_Bank_GetID(IntPtr bank, out Guid id);

		[PreserveSig]
		[Token(Token = "0x6000779")]
		[Address(RVA = "0x151325C", Offset = "0x151325C", VA = "0x151325C")]
		private static extern RESULT FMOD_Studio_Bank_GetPath(IntPtr bank, IntPtr path, int size, out int retrieved);

		[PreserveSig]
		[Token(Token = "0x600077A")]
		[Address(RVA = "0x151330C", Offset = "0x151330C", VA = "0x151330C")]
		private static extern RESULT FMOD_Studio_Bank_Unload(IntPtr bank);

		[PreserveSig]
		[Token(Token = "0x600077B")]
		[Address(RVA = "0x1513394", Offset = "0x1513394", VA = "0x1513394")]
		private static extern RESULT FMOD_Studio_Bank_LoadSampleData(IntPtr bank);

		[PreserveSig]
		[Token(Token = "0x600077C")]
		[Address(RVA = "0x151341C", Offset = "0x151341C", VA = "0x151341C")]
		private static extern RESULT FMOD_Studio_Bank_UnloadSampleData(IntPtr bank);

		[PreserveSig]
		[Token(Token = "0x600077D")]
		[Address(RVA = "0x15134A4", Offset = "0x15134A4", VA = "0x15134A4")]
		private static extern RESULT FMOD_Studio_Bank_GetLoadingState(IntPtr bank, out LOADING_STATE state);

		[PreserveSig]
		[Token(Token = "0x600077E")]
		[Address(RVA = "0x151353C", Offset = "0x151353C", VA = "0x151353C")]
		private static extern RESULT FMOD_Studio_Bank_GetSampleLoadingState(IntPtr bank, out LOADING_STATE state);

		[PreserveSig]
		[Token(Token = "0x600077F")]
		[Address(RVA = "0x15135D4", Offset = "0x15135D4", VA = "0x15135D4")]
		private static extern RESULT FMOD_Studio_Bank_GetStringCount(IntPtr bank, out int count);

		[PreserveSig]
		[Token(Token = "0x6000780")]
		[Address(RVA = "0x15138EC", Offset = "0x15138EC", VA = "0x15138EC")]
		private static extern RESULT FMOD_Studio_Bank_GetStringInfo(IntPtr bank, int index, out Guid id, IntPtr path, int size, out int retrieved);

		[PreserveSig]
		[Token(Token = "0x6000781")]
		[Address(RVA = "0x15139B4", Offset = "0x15139B4", VA = "0x15139B4")]
		private static extern RESULT FMOD_Studio_Bank_GetEventCount(IntPtr bank, out int count);

		[PreserveSig]
		[Token(Token = "0x6000782")]
		[Address(RVA = "0x1513B94", Offset = "0x1513B94", VA = "0x1513B94")]
		private static extern RESULT FMOD_Studio_Bank_GetEventList(IntPtr bank, IntPtr[] array, int capacity, out int count);

		[PreserveSig]
		[Token(Token = "0x6000783")]
		[Address(RVA = "0x1513C4C", Offset = "0x1513C4C", VA = "0x1513C4C")]
		private static extern RESULT FMOD_Studio_Bank_GetBusCount(IntPtr bank, out int count);

		[PreserveSig]
		[Token(Token = "0x6000784")]
		[Address(RVA = "0x1513E2C", Offset = "0x1513E2C", VA = "0x1513E2C")]
		private static extern RESULT FMOD_Studio_Bank_GetBusList(IntPtr bank, IntPtr[] array, int capacity, out int count);

		[PreserveSig]
		[Token(Token = "0x6000785")]
		[Address(RVA = "0x1513EE4", Offset = "0x1513EE4", VA = "0x1513EE4")]
		private static extern RESULT FMOD_Studio_Bank_GetVCACount(IntPtr bank, out int count);

		[PreserveSig]
		[Token(Token = "0x6000786")]
		[Address(RVA = "0x15140C4", Offset = "0x15140C4", VA = "0x15140C4")]
		private static extern RESULT FMOD_Studio_Bank_GetVCAList(IntPtr bank, IntPtr[] array, int capacity, out int count);

		[PreserveSig]
		[Token(Token = "0x6000787")]
		[Address(RVA = "0x151417C", Offset = "0x151417C", VA = "0x151417C")]
		private static extern RESULT FMOD_Studio_Bank_GetUserData(IntPtr bank, out IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x6000788")]
		[Address(RVA = "0x1514214", Offset = "0x1514214", VA = "0x1514214")]
		private static extern RESULT FMOD_Studio_Bank_SetUserData(IntPtr bank, IntPtr userdata);

		[Token(Token = "0x6000789")]
		[Address(RVA = "0x8F2DE4", Offset = "0x8F2DE4", VA = "0x8F2DE4")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x600078A")]
		[Address(RVA = "0x8F2DEC", Offset = "0x8F2DEC", VA = "0x8F2DEC")]
		public void clearHandle()
		{
		}

		[Token(Token = "0x600078B")]
		[Address(RVA = "0x8F2E30", Offset = "0x8F2E30", VA = "0x8F2E30")]
		public bool isValid()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200012B")]
	public struct CommandReplay
	{
		[Token(Token = "0x400066B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x600078C")]
		[Address(RVA = "0x8F2F84", Offset = "0x8F2F84", VA = "0x8F2F84")]
		public RESULT getSystem(out System system)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600078D")]
		[Address(RVA = "0x8F2F8C", Offset = "0x8F2F8C", VA = "0x8F2F8C")]
		public RESULT getLength(out float length)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600078E")]
		[Address(RVA = "0x8F2F94", Offset = "0x8F2F94", VA = "0x8F2F94")]
		public RESULT getCommandCount(out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600078F")]
		[Address(RVA = "0x8F2F9C", Offset = "0x8F2F9C", VA = "0x8F2F9C")]
		public RESULT getCommandInfo(int commandIndex, out COMMAND_INFO info)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000790")]
		[Address(RVA = "0x8F2FA4", Offset = "0x8F2FA4", VA = "0x8F2FA4")]
		public RESULT getCommandString(int commandIndex, out string buffer)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000791")]
		[Address(RVA = "0x8F2FAC", Offset = "0x8F2FAC", VA = "0x8F2FAC")]
		public RESULT getCommandAtTime(float time, out int commandIndex)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000792")]
		[Address(RVA = "0x8F2FB4", Offset = "0x8F2FB4", VA = "0x8F2FB4")]
		public RESULT setBankPath(string bankPath)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000793")]
		[Address(RVA = "0x8F2FBC", Offset = "0x8F2FBC", VA = "0x8F2FBC")]
		public RESULT start()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000794")]
		[Address(RVA = "0x8F2FC4", Offset = "0x8F2FC4", VA = "0x8F2FC4")]
		public RESULT stop()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000795")]
		[Address(RVA = "0x8F2FCC", Offset = "0x8F2FCC", VA = "0x8F2FCC")]
		public RESULT seekToTime(float time)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000796")]
		[Address(RVA = "0x8F2FD4", Offset = "0x8F2FD4", VA = "0x8F2FD4")]
		public RESULT seekToCommand(int commandIndex)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000797")]
		[Address(RVA = "0x8F2FDC", Offset = "0x8F2FDC", VA = "0x8F2FDC")]
		public RESULT getPaused(out bool paused)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000798")]
		[Address(RVA = "0x8F2FE4", Offset = "0x8F2FE4", VA = "0x8F2FE4")]
		public RESULT setPaused(bool paused)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000799")]
		[Address(RVA = "0x8F2FF0", Offset = "0x8F2FF0", VA = "0x8F2FF0")]
		public RESULT getPlaybackState(out PLAYBACK_STATE state)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600079A")]
		[Address(RVA = "0x8F2FF8", Offset = "0x8F2FF8", VA = "0x8F2FF8")]
		public RESULT getCurrentCommand(out int commandIndex, out float currentTime)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600079B")]
		[Address(RVA = "0x8F3000", Offset = "0x8F3000", VA = "0x8F3000")]
		public RESULT release()
		{
			return default(RESULT);
		}

		[Token(Token = "0x600079C")]
		[Address(RVA = "0x8F3008", Offset = "0x8F3008", VA = "0x8F3008")]
		public RESULT setFrameCallback(COMMANDREPLAY_FRAME_CALLBACK callback)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600079D")]
		[Address(RVA = "0x8F3010", Offset = "0x8F3010", VA = "0x8F3010")]
		public RESULT setLoadBankCallback(COMMANDREPLAY_LOAD_BANK_CALLBACK callback)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600079E")]
		[Address(RVA = "0x8F3018", Offset = "0x8F3018", VA = "0x8F3018")]
		public RESULT setCreateInstanceCallback(COMMANDREPLAY_CREATE_INSTANCE_CALLBACK callback)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600079F")]
		[Address(RVA = "0x8F3020", Offset = "0x8F3020", VA = "0x8F3020")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007A0")]
		[Address(RVA = "0x8F3028", Offset = "0x8F3028", VA = "0x8F3028")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x60007A1")]
		[Address(RVA = "0x1516C0C", Offset = "0x1516C0C", VA = "0x1516C0C")]
		private static extern bool FMOD_Studio_CommandReplay_IsValid(IntPtr replay);

		[PreserveSig]
		[Token(Token = "0x60007A2")]
		[Address(RVA = "0x1515BE4", Offset = "0x1515BE4", VA = "0x1515BE4")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetSystem(IntPtr replay, out IntPtr system);

		[PreserveSig]
		[Token(Token = "0x60007A3")]
		[Address(RVA = "0x1515C7C", Offset = "0x1515C7C", VA = "0x1515C7C")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetLength(IntPtr replay, out float length);

		[PreserveSig]
		[Token(Token = "0x60007A4")]
		[Address(RVA = "0x1515D14", Offset = "0x1515D14", VA = "0x1515D14")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetCommandCount(IntPtr replay, out int count);

		[PreserveSig]
		[Token(Token = "0x60007A5")]
		[Address(RVA = "0x1515DAC", Offset = "0x1515DAC", VA = "0x1515DAC")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetCommandInfo(IntPtr replay, int commandindex, out COMMAND_INFO info);

		[PreserveSig]
		[Token(Token = "0x60007A6")]
		[Address(RVA = "0x1516084", Offset = "0x1516084", VA = "0x1516084")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetCommandString(IntPtr replay, int commandIndex, IntPtr buffer, int length);

		[PreserveSig]
		[Token(Token = "0x60007A7")]
		[Address(RVA = "0x1516134", Offset = "0x1516134", VA = "0x1516134")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetCommandAtTime(IntPtr replay, float time, out int commandIndex);

		[PreserveSig]
		[Token(Token = "0x60007A8")]
		[Address(RVA = "0x151631C", Offset = "0x151631C", VA = "0x151631C")]
		private static extern RESULT FMOD_Studio_CommandReplay_SetBankPath(IntPtr replay, byte[] bankPath);

		[PreserveSig]
		[Token(Token = "0x60007A9")]
		[Address(RVA = "0x15163BC", Offset = "0x15163BC", VA = "0x15163BC")]
		private static extern RESULT FMOD_Studio_CommandReplay_Start(IntPtr replay);

		[PreserveSig]
		[Token(Token = "0x60007AA")]
		[Address(RVA = "0x1516444", Offset = "0x1516444", VA = "0x1516444")]
		private static extern RESULT FMOD_Studio_CommandReplay_Stop(IntPtr replay);

		[PreserveSig]
		[Token(Token = "0x60007AB")]
		[Address(RVA = "0x15164CC", Offset = "0x15164CC", VA = "0x15164CC")]
		private static extern RESULT FMOD_Studio_CommandReplay_SeekToTime(IntPtr replay, float time);

		[PreserveSig]
		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x1516564", Offset = "0x1516564", VA = "0x1516564")]
		private static extern RESULT FMOD_Studio_CommandReplay_SeekToCommand(IntPtr replay, int commandIndex);

		[PreserveSig]
		[Token(Token = "0x60007AD")]
		[Address(RVA = "0x15165FC", Offset = "0x15165FC", VA = "0x15165FC")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetPaused(IntPtr replay, out bool paused);

		[PreserveSig]
		[Token(Token = "0x60007AE")]
		[Address(RVA = "0x15166AC", Offset = "0x15166AC", VA = "0x15166AC")]
		private static extern RESULT FMOD_Studio_CommandReplay_SetPaused(IntPtr replay, bool paused);

		[PreserveSig]
		[Token(Token = "0x60007AF")]
		[Address(RVA = "0x1516744", Offset = "0x1516744", VA = "0x1516744")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetPlaybackState(IntPtr replay, out PLAYBACK_STATE state);

		[PreserveSig]
		[Token(Token = "0x60007B0")]
		[Address(RVA = "0x15167DC", Offset = "0x15167DC", VA = "0x15167DC")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetCurrentCommand(IntPtr replay, out int commandIndex, out float currentTime);

		[PreserveSig]
		[Token(Token = "0x60007B1")]
		[Address(RVA = "0x151687C", Offset = "0x151687C", VA = "0x151687C")]
		private static extern RESULT FMOD_Studio_CommandReplay_Release(IntPtr replay);

		[PreserveSig]
		[Token(Token = "0x60007B2")]
		[Address(RVA = "0x1516904", Offset = "0x1516904", VA = "0x1516904")]
		private static extern RESULT FMOD_Studio_CommandReplay_SetFrameCallback(IntPtr replay, COMMANDREPLAY_FRAME_CALLBACK callback);

		[PreserveSig]
		[Token(Token = "0x60007B3")]
		[Address(RVA = "0x15169A4", Offset = "0x15169A4", VA = "0x15169A4")]
		private static extern RESULT FMOD_Studio_CommandReplay_SetLoadBankCallback(IntPtr replay, COMMANDREPLAY_LOAD_BANK_CALLBACK callback);

		[PreserveSig]
		[Token(Token = "0x60007B4")]
		[Address(RVA = "0x1516A44", Offset = "0x1516A44", VA = "0x1516A44")]
		private static extern RESULT FMOD_Studio_CommandReplay_SetCreateInstanceCallback(IntPtr replay, COMMANDREPLAY_CREATE_INSTANCE_CALLBACK callback);

		[PreserveSig]
		[Token(Token = "0x60007B5")]
		[Address(RVA = "0x1516AE4", Offset = "0x1516AE4", VA = "0x1516AE4")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetUserData(IntPtr replay, out IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x60007B6")]
		[Address(RVA = "0x1516B7C", Offset = "0x1516B7C", VA = "0x1516B7C")]
		private static extern RESULT FMOD_Studio_CommandReplay_SetUserData(IntPtr replay, IntPtr userdata);

		[Token(Token = "0x60007B7")]
		[Address(RVA = "0x8F3030", Offset = "0x8F3030", VA = "0x8F3030")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x60007B8")]
		[Address(RVA = "0x8F3038", Offset = "0x8F3038", VA = "0x8F3038")]
		public void clearHandle()
		{
		}

		[Token(Token = "0x60007B9")]
		[Address(RVA = "0x8F307C", Offset = "0x8F307C", VA = "0x8F307C")]
		public bool isValid()
		{
			return default(bool);
		}
	}
}
namespace FMODUnity
{
	[Token(Token = "0x200012C")]
	public class BankRefAttribute : PropertyAttribute
	{
		[Token(Token = "0x60007BA")]
		[Address(RVA = "0xCF7B24", Offset = "0xCF7B24", VA = "0xCF7B24")]
		public BankRefAttribute()
		{
		}
	}
	[Token(Token = "0x200012D")]
	public abstract class EventHandler : MonoBehaviour
	{
		[Token(Token = "0x400066C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string CollisionTag;

		[Token(Token = "0x60007BB")]
		[Address(RVA = "0xCF7BE0", Offset = "0xCF7BE0", VA = "0xCF7BE0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60007BC")]
		[Address(RVA = "0xCF7BF0", Offset = "0xCF7BF0", VA = "0xCF7BF0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60007BD")]
		[Address(RVA = "0xCF7C00", Offset = "0xCF7C00", VA = "0xCF7C00")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x60007BE")]
		[Address(RVA = "0xCF7C68", Offset = "0xCF7C68", VA = "0xCF7C68")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x60007BF")]
		[Address(RVA = "0xCF7CD0", Offset = "0xCF7CD0", VA = "0xCF7CD0")]
		private void OnTriggerEnter2D(Collider2D other)
		{
		}

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0xCF7D38", Offset = "0xCF7D38", VA = "0xCF7D38")]
		private void OnTriggerExit2D(Collider2D other)
		{
		}

		[Token(Token = "0x60007C1")]
		[Address(RVA = "0xCF7DA0", Offset = "0xCF7DA0", VA = "0xCF7DA0")]
		private void OnCollisionEnter()
		{
		}

		[Token(Token = "0x60007C2")]
		[Address(RVA = "0xCF7DB0", Offset = "0xCF7DB0", VA = "0xCF7DB0")]
		private void OnCollisionExit()
		{
		}

		[Token(Token = "0x60007C3")]
		[Address(RVA = "0xCF7DC0", Offset = "0xCF7DC0", VA = "0xCF7DC0")]
		private void OnCollisionEnter2D()
		{
		}

		[Token(Token = "0x60007C4")]
		[Address(RVA = "0xCF7DD0", Offset = "0xCF7DD0", VA = "0xCF7DD0")]
		private void OnCollisionExit2D()
		{
		}

		[Token(Token = "0x60007C5")]
		[Address(RVA = "0xCF7DE0", Offset = "0xCF7DE0", VA = "0xCF7DE0")]
		private void OnMouseEnter()
		{
		}

		[Token(Token = "0x60007C6")]
		[Address(RVA = "0xCF7DF0", Offset = "0xCF7DF0", VA = "0xCF7DF0")]
		private void OnMouseExit()
		{
		}

		[Token(Token = "0x60007C7")]
		[Address(RVA = "0xCF7E00", Offset = "0xCF7E00", VA = "0xCF7E00")]
		private void OnMouseDown()
		{
		}

		[Token(Token = "0x60007C8")]
		[Address(RVA = "0xCF7E10", Offset = "0xCF7E10", VA = "0xCF7E10")]
		private void OnMouseUp()
		{
		}

		[Token(Token = "0x60007C9")]
		protected abstract void HandleGameEvent(EmitterGameEvent gameEvent);

		[Token(Token = "0x60007CA")]
		[Address(RVA = "0xCF7E20", Offset = "0xCF7E20", VA = "0xCF7E20")]
		protected EventHandler()
		{
		}
	}
	[Token(Token = "0x200012E")]
	public class EventRefAttribute : PropertyAttribute
	{
		[Token(Token = "0x60007CB")]
		[Address(RVA = "0xCF7FF8", Offset = "0xCF7FF8", VA = "0xCF7FF8")]
		public EventRefAttribute()
		{
		}
	}
	[Token(Token = "0x200012F")]
	public class FMODRuntimeManagerOnGUIHelper : MonoBehaviour
	{
		[Token(Token = "0x400066D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RuntimeManager TargetRuntimeManager;

		[Token(Token = "0x60007CC")]
		[Address(RVA = "0xCF8000", Offset = "0xCF8000", VA = "0xCF8000")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60007CD")]
		[Address(RVA = "0xCF8198", Offset = "0xCF8198", VA = "0xCF8198")]
		public FMODRuntimeManagerOnGUIHelper()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000130")]
	public class ParamRef
	{
		[Token(Token = "0x400066E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Name;

		[Token(Token = "0x400066F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float Value;

		[Token(Token = "0x4000670")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public PARAMETER_ID ID;

		[Token(Token = "0x60007CE")]
		[Address(RVA = "0xCF81A0", Offset = "0xCF81A0", VA = "0xCF81A0")]
		public ParamRef()
		{
		}
	}
	[Token(Token = "0x2000131")]
	public class ParamRefAttribute : PropertyAttribute
	{
		[Token(Token = "0x60007CF")]
		[Address(RVA = "0xCF81A8", Offset = "0xCF81A8", VA = "0xCF81A8")]
		public ParamRefAttribute()
		{
		}
	}
	[Token(Token = "0x2000132")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8311F0", Offset = "0x8311F0")]
	public class RuntimeManager : MonoBehaviour
	{
		[Token(Token = "0x20001C0")]
		private struct LoadedBank
		{
			[Token(Token = "0x40009CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Bank Bank;

			[Token(Token = "0x40009CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int RefCount;
		}

		[Token(Token = "0x20001C1")]
		private class GuidComparer : IEqualityComparer<Guid>
		{
			[Token(Token = "0x6000CE1")]
			[Address(RVA = "0xCFE27C", Offset = "0xCFE27C", VA = "0xCFE27C", Slot = "4")]
			private bool System.Collections.Generic.IEqualityComparer<System.Guid>.Equals(Guid x, Guid y)
			{
				return default(bool);
			}

			[Token(Token = "0x6000CE2")]
			[Address(RVA = "0xCFE2B0", Offset = "0xCFE2B0", VA = "0xCFE2B0", Slot = "5")]
			private int System.Collections.Generic.IEqualityComparer<System.Guid>.GetHashCode(Guid obj)
			{
				return default(int);
			}

			[Token(Token = "0x6000CE3")]
			[Address(RVA = "0xCFDE9C", Offset = "0xCFDE9C", VA = "0xCFDE9C")]
			public GuidComparer()
			{
			}
		}

		[Token(Token = "0x20001C2")]
		private class AttachedInstance
		{
			[Token(Token = "0x40009CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public EventInstance instance;

			[Token(Token = "0x40009CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform transform;

			[Token(Token = "0x40009CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Rigidbody rigidBody;

			[Token(Token = "0x40009D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Rigidbody2D rigidBody2D;

			[Token(Token = "0x6000CE4")]
			[Address(RVA = "0xCFB20C", Offset = "0xCFB20C", VA = "0xCFB20C")]
			public AttachedInstance()
			{
			}
		}

		[Token(Token = "0x20001C3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x831C24", Offset = "0x831C24")]
		private sealed class <>c__DisplayClass27_0
		{
			[Token(Token = "0x40009D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public EventInstance instance;

			[Token(Token = "0x6000CE5")]
			[Address(RVA = "0xCFB204", Offset = "0xCFB204", VA = "0xCFB204")]
			public <>c__DisplayClass27_0()
			{
			}

			[Token(Token = "0x6000CE6")]
			[Address(RVA = "0xCFDF2C", Offset = "0xCFDF2C", VA = "0xCFDF2C")]
			internal bool <AttachInstanceToGameObject>b__0(AttachedInstance x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20001C4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x831C34", Offset = "0x831C34")]
		private sealed class <>c__DisplayClass28_0
		{
			[Token(Token = "0x40009D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public EventInstance instance;

			[Token(Token = "0x6000CE7")]
			[Address(RVA = "0xCFB214", Offset = "0xCFB214", VA = "0xCFB214")]
			public <>c__DisplayClass28_0()
			{
			}

			[Token(Token = "0x6000CE8")]
			[Address(RVA = "0xCFDF50", Offset = "0xCFDF50", VA = "0xCFDF50")]
			internal bool <AttachInstanceToGameObject>b__0(AttachedInstance x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20001C5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x831C44", Offset = "0x831C44")]
		private sealed class <loadFromWeb>d__42 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40009D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40009D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40009D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string bankPath;

			[Token(Token = "0x40009D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public RuntimeManager <>4__this;

			[Token(Token = "0x40009D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string bankName;

			[Token(Token = "0x40009D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool loadSamples;

			[Token(Token = "0x40009D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UnityWebRequest <www>5__2;

			[Token(Token = "0x170000D4")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000CEC")]
				[Address(RVA = "0xCFE20C", Offset = "0xCFE20C", VA = "0xCFE20C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D5")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000CEE")]
				[Address(RVA = "0xCFE274", Offset = "0xCFE274", VA = "0xCFE274", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000CE9")]
			[Address(RVA = "0xCFBD0C", Offset = "0xCFBD0C", VA = "0xCFBD0C")]
			[DebuggerHidden]
			public <loadFromWeb>d__42(int <>1__state)
			{
			}

			[Token(Token = "0x6000CEA")]
			[Address(RVA = "0xCFDF74", Offset = "0xCFDF74", VA = "0xCFDF74", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000CEB")]
			[Address(RVA = "0xCFDF78", Offset = "0xCFDF78", VA = "0xCFDF78", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000CED")]
			[Address(RVA = "0xCFE214", Offset = "0xCFE214", VA = "0xCFE214", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000671")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static SystemNotInitializedException initException;

		[Token(Token = "0x4000672")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static RuntimeManager instance;

		[Token(Token = "0x4000673")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private FMODPlatform fmodPlatform;

		[Token(Token = "0x4000674")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FMOD.Studio.System studioSystem;

		[Token(Token = "0x4000675")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private FMOD.System coreSystem;

		[Token(Token = "0x4000676")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private DSP mixerHead;

		[Token(Token = "0x4000677")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private long[] cachedPointers;

		[Token(Token = "0x4000678")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Dictionary<string, LoadedBank> loadedBanks;

		[Token(Token = "0x4000679")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Dictionary<string, uint> loadedPlugins;

		[Token(Token = "0x400067A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Dictionary<Guid, EventDescription> cachedDescriptions;

		[Token(Token = "0x400067B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<AttachedInstance> attachedInstances;

		[Token(Token = "0x400067C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool listenerWarningIssued;

		[Token(Token = "0x400067D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		protected bool isOverlayEnabled;

		[Token(Token = "0x400067E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private FMODRuntimeManagerOnGUIHelper overlayDrawer;

		[Token(Token = "0x400067F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Rect windowRect;

		[Token(Token = "0x4000680")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private string lastDebugText;

		[Token(Token = "0x4000681")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float lastDebugUpdate;

		[Token(Token = "0x4000682")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static List<StudioListener> Listeners;

		[Token(Token = "0x4000683")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static int numListeners;

		[Token(Token = "0x1700000F")]
		private static RuntimeManager Instance
		{
			[Token(Token = "0x60007D1")]
			[Address(RVA = "0xCF846C", Offset = "0xCF846C", VA = "0xCF846C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000010")]
		public static FMOD.Studio.System StudioSystem
		{
			[Token(Token = "0x60007D2")]
			[Address(RVA = "0xCF6AFC", Offset = "0xCF6AFC", VA = "0xCF6AFC")]
			get
			{
				return default(FMOD.Studio.System);
			}
		}

		[Token(Token = "0x17000011")]
		public static FMOD.System CoreSystem
		{
			[Token(Token = "0x60007D3")]
			[Address(RVA = "0xCF94C4", Offset = "0xCF94C4", VA = "0xCF94C4")]
			get
			{
				return default(FMOD.System);
			}
		}

		[Token(Token = "0x17000012")]
		public static bool IsInitialized
		{
			[Token(Token = "0x60007FD")]
			[Address(RVA = "0xCFDB48", Offset = "0xCFDB48", VA = "0xCFDB48")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000013")]
		public static bool HasBanksLoaded
		{
			[Token(Token = "0x60007FE")]
			[Address(RVA = "0xCFD9FC", Offset = "0xCFD9FC", VA = "0xCFD9FC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60007D0")]
		[Address(RVA = "0xCF82A8", Offset = "0xCF82A8", VA = "0xCF82A8")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x835E38", Offset = "0x835E38")]
		private static RESULT DEBUG_CALLBACK(DEBUG_FLAGS flags, StringWrapper file, int line, StringWrapper func, StringWrapper message)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007D4")]
		[Address(RVA = "0xCF9530", Offset = "0xCF9530", VA = "0xCF9530")]
		private void CheckInitResult(RESULT result, string cause)
		{
		}

		[Token(Token = "0x60007D5")]
		[Address(RVA = "0xCF8E08", Offset = "0xCF8E08", VA = "0xCF8E08")]
		private RESULT Initialize()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007D6")]
		[Address(RVA = "0xCFA3E4", Offset = "0xCFA3E4", VA = "0xCFA3E4")]
		public static int AddListener(StudioListener listener)
		{
			return default(int);
		}

		[Token(Token = "0x60007D7")]
		[Address(RVA = "0xCFA7EC", Offset = "0xCFA7EC", VA = "0xCFA7EC")]
		public static bool RemoveListener(StudioListener listener)
		{
			return default(bool);
		}

		[Token(Token = "0x60007D8")]
		[Address(RVA = "0xCFAB10", Offset = "0xCFAB10", VA = "0xCFAB10")]
		private void Update()
		{
		}

		[Token(Token = "0x60007D9")]
		[Address(RVA = "0xCF6FC4", Offset = "0xCF6FC4", VA = "0xCF6FC4")]
		public static void AttachInstanceToGameObject(EventInstance instance, Transform transform, Rigidbody rigidBody)
		{
		}

		[Token(Token = "0x60007DA")]
		[Address(RVA = "0xCF7168", Offset = "0xCF7168", VA = "0xCF7168")]
		public static void AttachInstanceToGameObject(EventInstance instance, Transform transform, Rigidbody2D rigidBody2D)
		{
		}

		[Token(Token = "0x60007DB")]
		[Address(RVA = "0xCFB21C", Offset = "0xCFB21C", VA = "0xCFB21C")]
		public static void DetachInstanceFromGameObject(EventInstance instance)
		{
		}

		[Token(Token = "0x60007DC")]
		[Address(RVA = "0xCF808C", Offset = "0xCF808C", VA = "0xCF808C")]
		public void ExecuteOnGUI()
		{
		}

		[Token(Token = "0x60007DD")]
		[Address(RVA = "0xCFB318", Offset = "0xCFB318", VA = "0xCFB318")]
		private void Start()
		{
		}

		[Token(Token = "0x60007DE")]
		[Address(RVA = "0xCFB428", Offset = "0xCFB428", VA = "0xCFB428")]
		private void DrawDebugOverlay(int windowID)
		{
		}

		[Token(Token = "0x60007DF")]
		[Address(RVA = "0xCFB878", Offset = "0xCFB878", VA = "0xCFB878")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60007E0")]
		[Address(RVA = "0xCFB8E8", Offset = "0xCFB8E8", VA = "0xCFB8E8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60007E1")]
		[Address(RVA = "0xCFB98C", Offset = "0xCFB98C", VA = "0xCFB98C")]
		private void OnApplicationPause(bool pauseStatus)
		{
		}

		[Token(Token = "0x60007E2")]
		[Address(RVA = "0xCFBAFC", Offset = "0xCFBAFC", VA = "0xCFBAFC")]
		private void loadedBankRegister(LoadedBank loadedBank, string bankPath, string bankName, bool loadSamples, RESULT loadResult)
		{
		}

		[Token(Token = "0x60007E3")]
		[Address(RVA = "0xCFBC74", Offset = "0xCFBC74", VA = "0xCFBC74")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x835E9C", Offset = "0x835E9C")]
		private IEnumerator loadFromWeb(string bankPath, string bankName, bool loadSamples)
		{
			return null;
		}

		[Token(Token = "0x60007E4")]
		[Address(RVA = "0xCFBD38", Offset = "0xCFBD38", VA = "0xCFBD38")]
		public static void LoadBank(string bankName, bool loadSamples = false)
		{
		}

		[Token(Token = "0x60007E5")]
		[Address(RVA = "0xCFC244", Offset = "0xCFC244", VA = "0xCFC244")]
		public static void LoadBank(TextAsset asset, bool loadSamples = false)
		{
		}

		[Token(Token = "0x60007E6")]
		[Address(RVA = "0xCF9F6C", Offset = "0xCF9F6C", VA = "0xCF9F6C")]
		private void LoadBanks(Settings fmodSettings)
		{
		}

		[Token(Token = "0x60007E7")]
		[Address(RVA = "0xCFC504", Offset = "0xCFC504", VA = "0xCFC504")]
		public static void UnloadBank(string bankName)
		{
		}

		[Token(Token = "0x60007E8")]
		[Address(RVA = "0xCFC63C", Offset = "0xCFC63C", VA = "0xCFC63C")]
		public static bool AnyBankLoading()
		{
			return default(bool);
		}

		[Token(Token = "0x60007E9")]
		[Address(RVA = "0xCFC494", Offset = "0xCFC494", VA = "0xCFC494")]
		public static void WaitForAllLoads()
		{
		}

		[Token(Token = "0x60007EA")]
		[Address(RVA = "0xCFC78C", Offset = "0xCFC78C", VA = "0xCFC78C")]
		public static Guid PathToGUID(string path)
		{
			return default(Guid);
		}

		[Token(Token = "0x60007EB")]
		[Address(RVA = "0xCF6EB4", Offset = "0xCF6EB4", VA = "0xCF6EB4")]
		public static EventInstance CreateInstance(string path)
		{
			return default(EventInstance);
		}

		[Token(Token = "0x60007EC")]
		[Address(RVA = "0xCFC8B4", Offset = "0xCFC8B4", VA = "0xCFC8B4")]
		public static EventInstance CreateInstance(Guid guid)
		{
			return default(EventInstance);
		}

		[Token(Token = "0x60007ED")]
		[Address(RVA = "0xCFCB54", Offset = "0xCFCB54", VA = "0xCFCB54")]
		public static void PlayOneShot(string path, [Optional] Vector3 position)
		{
		}

		[Token(Token = "0x60007EE")]
		[Address(RVA = "0xCFCCB8", Offset = "0xCFCCB8", VA = "0xCFCCB8")]
		public static void PlayOneShot(Guid guid, [Optional] Vector3 position)
		{
		}

		[Token(Token = "0x60007EF")]
		[Address(RVA = "0xCFCD98", Offset = "0xCFCD98", VA = "0xCFCD98")]
		public static void PlayOneShotAttached(string path, GameObject gameObject)
		{
		}

		[Token(Token = "0x60007F0")]
		[Address(RVA = "0xCFCEE0", Offset = "0xCFCEE0", VA = "0xCFCEE0")]
		public static void PlayOneShotAttached(Guid guid, GameObject gameObject)
		{
		}

		[Token(Token = "0x60007F1")]
		[Address(RVA = "0xCFCFC4", Offset = "0xCFCFC4", VA = "0xCFCFC4")]
		public static EventDescription GetEventDescription(string path)
		{
			return default(EventDescription);
		}

		[Token(Token = "0x60007F2")]
		[Address(RVA = "0xCFC950", Offset = "0xCFC950", VA = "0xCFC950")]
		public static EventDescription GetEventDescription(Guid guid)
		{
			return default(EventDescription);
		}

		[Token(Token = "0x60007F3")]
		[Address(RVA = "0xCFD0D4", Offset = "0xCFD0D4", VA = "0xCFD0D4")]
		public static void SetListenerLocation(GameObject gameObject, [Optional] Rigidbody rigidBody)
		{
		}

		[Token(Token = "0x60007F4")]
		[Address(RVA = "0xCFD2AC", Offset = "0xCFD2AC", VA = "0xCFD2AC")]
		public static void SetListenerLocation(GameObject gameObject, Rigidbody2D rigidBody2D)
		{
		}

		[Token(Token = "0x60007F5")]
		[Address(RVA = "0xCFD490", Offset = "0xCFD490", VA = "0xCFD490")]
		public static void SetListenerLocation(Transform transform)
		{
		}

		[Token(Token = "0x60007F6")]
		[Address(RVA = "0xCFD5D4", Offset = "0xCFD5D4", VA = "0xCFD5D4")]
		public static void SetListenerLocation(int listenerIndex, GameObject gameObject, [Optional] Rigidbody rigidBody)
		{
		}

		[Token(Token = "0x60007F7")]
		[Address(RVA = "0xCFD680", Offset = "0xCFD680", VA = "0xCFD680")]
		public static void SetListenerLocation(int listenerIndex, GameObject gameObject, Rigidbody2D rigidBody2D)
		{
		}

		[Token(Token = "0x60007F8")]
		[Address(RVA = "0xCFD72C", Offset = "0xCFD72C", VA = "0xCFD72C")]
		public static void SetListenerLocation(int listenerIndex, Transform transform)
		{
		}

		[Token(Token = "0x60007F9")]
		[Address(RVA = "0xCFD7D0", Offset = "0xCFD7D0", VA = "0xCFD7D0")]
		public static Bus GetBus(string path)
		{
			return default(Bus);
		}

		[Token(Token = "0x60007FA")]
		[Address(RVA = "0xCFD890", Offset = "0xCFD890", VA = "0xCFD890")]
		public static VCA GetVCA(string path)
		{
			return default(VCA);
		}

		[Token(Token = "0x60007FB")]
		[Address(RVA = "0xCFBA38", Offset = "0xCFBA38", VA = "0xCFBA38")]
		public static void PauseAllEvents(bool paused)
		{
		}

		[Token(Token = "0x60007FC")]
		[Address(RVA = "0xCFDA84", Offset = "0xCFDA84", VA = "0xCFDA84")]
		public static void MuteAllEvents(bool muted)
		{
		}

		[Token(Token = "0x60007FF")]
		[Address(RVA = "0xCFDC2C", Offset = "0xCFDC2C", VA = "0xCFDC2C")]
		public static bool HasBankLoaded(string loadedBank)
		{
			return default(bool);
		}

		[Token(Token = "0x6000800")]
		[Address(RVA = "0xCF9DC8", Offset = "0xCF9DC8", VA = "0xCF9DC8")]
		private void LoadPlugins(Settings fmodSettings)
		{
		}

		[Token(Token = "0x6000801")]
		[Address(RVA = "0xCF9CB8", Offset = "0xCF9CB8", VA = "0xCF9CB8")]
		private void SetThreadAffinity()
		{
		}

		[Token(Token = "0x6000802")]
		[Address(RVA = "0xCFDD34", Offset = "0xCFDD34", VA = "0xCFDD34")]
		public RuntimeManager()
		{
		}
	}
	[Token(Token = "0x2000133")]
	public class EventNotFoundException : Exception
	{
		[Token(Token = "0x4000684")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Guid Guid;

		[Token(Token = "0x4000685")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public string Path;

		[Token(Token = "0x6000804")]
		[Address(RVA = "0xCF7E78", Offset = "0xCF7E78", VA = "0xCF7E78")]
		public EventNotFoundException(string path)
		{
		}

		[Token(Token = "0x6000805")]
		[Address(RVA = "0xCF7F24", Offset = "0xCF7F24", VA = "0xCF7F24")]
		public EventNotFoundException(Guid guid)
		{
		}
	}
	[Token(Token = "0x2000134")]
	public class BusNotFoundException : Exception
	{
		[Token(Token = "0x4000686")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public string Path;

		[Token(Token = "0x6000806")]
		[Address(RVA = "0xCF7B2C", Offset = "0xCF7B2C", VA = "0xCF7B2C")]
		public BusNotFoundException(string path)
		{
		}
	}
	[Token(Token = "0x2000135")]
	public class VCANotFoundException : Exception
	{
		[Token(Token = "0x4000687")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public string Path;

		[Token(Token = "0x6000807")]
		[Address(RVA = "0xCFD950", Offset = "0xCFD950", VA = "0xCFD950")]
		public VCANotFoundException(string path)
		{
		}
	}
	[Token(Token = "0x2000136")]
	public class BankLoadException : Exception
	{
		[Token(Token = "0x4000688")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public string Path;

		[Token(Token = "0x4000689")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public RESULT Result;

		[Token(Token = "0x6000808")]
		[Address(RVA = "0xCF796C", Offset = "0xCF796C", VA = "0xCF796C")]
		public BankLoadException(string path, RESULT result)
		{
		}

		[Token(Token = "0x6000809")]
		[Address(RVA = "0xCF7A74", Offset = "0xCF7A74", VA = "0xCF7A74")]
		public BankLoadException(string path, string error)
		{
		}
	}
	[Token(Token = "0x2000137")]
	public class SystemNotInitializedException : Exception
	{
		[Token(Token = "0x400068A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public RESULT Result;

		[Token(Token = "0x400068B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public string Location;

		[Token(Token = "0x600080A")]
		[Address(RVA = "0xCF93BC", Offset = "0xCF93BC", VA = "0xCF93BC")]
		public SystemNotInitializedException(RESULT result, string location)
		{
		}

		[Token(Token = "0x600080B")]
		[Address(RVA = "0xCF9338", Offset = "0xCF9338", VA = "0xCF9338")]
		public SystemNotInitializedException(Exception inner)
		{
		}
	}
	[Token(Token = "0x2000138")]
	public enum EmitterGameEvent
	{
		[Token(Token = "0x400068D")]
		None,
		[Token(Token = "0x400068E")]
		ObjectStart,
		[Token(Token = "0x400068F")]
		ObjectDestroy,
		[Token(Token = "0x4000690")]
		TriggerEnter,
		[Token(Token = "0x4000691")]
		TriggerExit,
		[Token(Token = "0x4000692")]
		TriggerEnter2D,
		[Token(Token = "0x4000693")]
		TriggerExit2D,
		[Token(Token = "0x4000694")]
		CollisionEnter,
		[Token(Token = "0x4000695")]
		CollisionExit,
		[Token(Token = "0x4000696")]
		CollisionEnter2D,
		[Token(Token = "0x4000697")]
		CollisionExit2D,
		[Token(Token = "0x4000698")]
		ObjectEnable,
		[Token(Token = "0x4000699")]
		ObjectDisable,
		[Token(Token = "0x400069A")]
		MouseEnter,
		[Token(Token = "0x400069B")]
		MouseExit,
		[Token(Token = "0x400069C")]
		MouseDown,
		[Token(Token = "0x400069D")]
		MouseUp
	}
	[Token(Token = "0x2000139")]
	public enum LoaderGameEvent
	{
		[Token(Token = "0x400069F")]
		None,
		[Token(Token = "0x40006A0")]
		ObjectStart,
		[Token(Token = "0x40006A1")]
		ObjectDestroy,
		[Token(Token = "0x40006A2")]
		TriggerEnter,
		[Token(Token = "0x40006A3")]
		TriggerExit,
		[Token(Token = "0x40006A4")]
		TriggerEnter2D,
		[Token(Token = "0x40006A5")]
		TriggerExit2D
	}
	[Token(Token = "0x200013A")]
	public static class RuntimeUtils
	{
		[Token(Token = "0x40006A6")]
		private const string BankExtension = ".bank";

		[Token(Token = "0x600080C")]
		[Address(RVA = "0xCFE2D8", Offset = "0xCFE2D8", VA = "0xCFE2D8")]
		public static string GetCommonPlatformPath(string path)
		{
			return null;
		}

		[Token(Token = "0x600080D")]
		[Address(RVA = "0xCFE328", Offset = "0xCFE328", VA = "0xCFE328")]
		public static VECTOR ToFMODVector(this Vector3 vec)
		{
			return default(VECTOR);
		}

		[Token(Token = "0x600080E")]
		[Address(RVA = "0xCF730C", Offset = "0xCF730C", VA = "0xCF730C")]
		public static ATTRIBUTES_3D To3DAttributes(this Vector3 pos)
		{
			return default(ATTRIBUTES_3D);
		}

		[Token(Token = "0x600080F")]
		[Address(RVA = "0xCFD528", Offset = "0xCFD528", VA = "0xCFD528")]
		public static ATTRIBUTES_3D To3DAttributes(this Transform transform)
		{
			return default(ATTRIBUTES_3D);
		}

		[Token(Token = "0x6000810")]
		[Address(RVA = "0xCFAFB0", Offset = "0xCFAFB0", VA = "0xCFAFB0")]
		public static ATTRIBUTES_3D To3DAttributes(Transform transform, [Optional] Rigidbody rigidbody)
		{
			return default(ATTRIBUTES_3D);
		}

		[Token(Token = "0x6000811")]
		[Address(RVA = "0xCFD17C", Offset = "0xCFD17C", VA = "0xCFD17C")]
		public static ATTRIBUTES_3D To3DAttributes(GameObject go, [Optional] Rigidbody rigidbody)
		{
			return default(ATTRIBUTES_3D);
		}

		[Token(Token = "0x6000812")]
		[Address(RVA = "0xCFB0D4", Offset = "0xCFB0D4", VA = "0xCFB0D4")]
		public static ATTRIBUTES_3D To3DAttributes(Transform transform, Rigidbody2D rigidbody)
		{
			return default(ATTRIBUTES_3D);
		}

		[Token(Token = "0x6000813")]
		[Address(RVA = "0xCFD354", Offset = "0xCFD354", VA = "0xCFD354")]
		public static ATTRIBUTES_3D To3DAttributes(GameObject go, Rigidbody2D rigidbody)
		{
			return default(ATTRIBUTES_3D);
		}

		[Token(Token = "0x6000814")]
		[Address(RVA = "0xCF97F4", Offset = "0xCF97F4", VA = "0xCF97F4")]
		internal static FMODPlatform GetCurrentPlatform()
		{
			return default(FMODPlatform);
		}

		[Token(Token = "0x6000815")]
		[Address(RVA = "0xCFC110", Offset = "0xCFC110", VA = "0xCFC110")]
		internal static string GetBankPath(string bankName)
		{
			return null;
		}

		[Token(Token = "0x6000816")]
		[Address(RVA = "0xCFDCB8", Offset = "0xCFDCB8", VA = "0xCFDCB8")]
		internal static string GetPluginPath(string pluginName)
		{
			return null;
		}

		[Token(Token = "0x6000817")]
		[Address(RVA = "0xCF8C80", Offset = "0xCF8C80", VA = "0xCF8C80")]
		public static void EnforceLibraryOrder()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200013B")]
	public enum FMODPlatform
	{
		[Token(Token = "0x40006A8")]
		None,
		[Token(Token = "0x40006A9")]
		PlayInEditor,
		[Token(Token = "0x40006AA")]
		Default,
		[Token(Token = "0x40006AB")]
		Desktop,
		[Token(Token = "0x40006AC")]
		Mobile,
		[Token(Token = "0x40006AD")]
		MobileHigh,
		[Token(Token = "0x40006AE")]
		MobileLow,
		[Token(Token = "0x40006AF")]
		Console,
		[Token(Token = "0x40006B0")]
		Windows,
		[Token(Token = "0x40006B1")]
		Mac,
		[Token(Token = "0x40006B2")]
		Linux,
		[Token(Token = "0x40006B3")]
		iOS,
		[Token(Token = "0x40006B4")]
		Android,
		[Token(Token = "0x40006B5")]
		Deprecated_1,
		[Token(Token = "0x40006B6")]
		XboxOne,
		[Token(Token = "0x40006B7")]
		PS4,
		[Token(Token = "0x40006B8")]
		Deprecated_2,
		[Token(Token = "0x40006B9")]
		Deprecated_3,
		[Token(Token = "0x40006BA")]
		AppleTV,
		[Token(Token = "0x40006BB")]
		UWP,
		[Token(Token = "0x40006BC")]
		Switch,
		[Token(Token = "0x40006BD")]
		WebGL,
		[Token(Token = "0x40006BE")]
		Count
	}
	[Serializable]
	[Token(Token = "0x200013C")]
	public enum ImportType
	{
		[Token(Token = "0x40006C0")]
		StreamingAssets,
		[Token(Token = "0x40006C1")]
		AssetBundle
	}
	[Serializable]
	[Token(Token = "0x200013D")]
	public enum BankLoadType
	{
		[Token(Token = "0x40006C3")]
		All,
		[Token(Token = "0x40006C4")]
		Specified,
		[Token(Token = "0x40006C5")]
		None
	}
	[Token(Token = "0x200013E")]
	public class PlatformSettingBase
	{
		[Token(Token = "0x40006C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FMODPlatform Platform;

		[Token(Token = "0x6000818")]
		[Address(RVA = "0xCF8250", Offset = "0xCF8250", VA = "0xCF8250")]
		public PlatformSettingBase()
		{
		}
	}
	[Token(Token = "0x200013F")]
	public class PlatformSetting<T> : PlatformSettingBase
	{
		[Token(Token = "0x40006C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T Value;

		[Token(Token = "0x6000819")]
		public PlatformSetting()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000140")]
	public class PlatformIntSetting : PlatformSetting<int>
	{
		[Token(Token = "0x600081A")]
		[Address(RVA = "0xCF8200", Offset = "0xCF8200", VA = "0xCF8200")]
		public PlatformIntSetting()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000141")]
	public class PlatformStringSetting : PlatformSetting<string>
	{
		[Token(Token = "0x600081B")]
		[Address(RVA = "0xCF8258", Offset = "0xCF8258", VA = "0xCF8258")]
		public PlatformStringSetting()
		{
		}
	}
	[Token(Token = "0x2000142")]
	public enum TriStateBool
	{
		[Token(Token = "0x40006C9")]
		Disabled,
		[Token(Token = "0x40006CA")]
		Enabled,
		[Token(Token = "0x40006CB")]
		Development
	}
	[Serializable]
	[Token(Token = "0x2000143")]
	public class PlatformBoolSetting : PlatformSetting<TriStateBool>
	{
		[Token(Token = "0x600081C")]
		[Address(RVA = "0xCF81B0", Offset = "0xCF81B0", VA = "0xCF81B0")]
		public PlatformBoolSetting()
		{
		}
	}
	[Token(Token = "0x2000144")]
	public class Settings : ScriptableObject
	{
		[Token(Token = "0x20001C6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x831C54", Offset = "0x831C54")]
		private sealed class <>c__DisplayClass40_0<T> where T : PlatformSettingBase
		{
			[Token(Token = "0x40009DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public FMODPlatform platform;

			[Token(Token = "0x6000CEF")]
			public <>c__DisplayClass40_0()
			{
			}

			[Token(Token = "0x6000CF0")]
			internal bool <HasSetting>b__0(T x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20001C7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x831C64", Offset = "0x831C64")]
		private sealed class <>c__DisplayClass41_0<T, U> where T : PlatformSetting<U>
		{
			[Token(Token = "0x40009DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public FMODPlatform platform;

			[Token(Token = "0x6000CF1")]
			public <>c__DisplayClass41_0()
			{
			}

			[Token(Token = "0x6000CF2")]
			internal bool <GetSetting>b__0(T x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20001C8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x831C74", Offset = "0x831C74")]
		private sealed class <>c__DisplayClass42_0<T, U> where T : PlatformSetting<U>, new()
		{
			[Token(Token = "0x40009DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public FMODPlatform platform;

			[Token(Token = "0x6000CF3")]
			public <>c__DisplayClass42_0()
			{
			}

			[Token(Token = "0x6000CF4")]
			internal bool <SetSetting>b__0(T x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20001C9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x831C84", Offset = "0x831C84")]
		private sealed class <>c__DisplayClass43_0<T> where T : PlatformSettingBase
		{
			[Token(Token = "0x40009DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public FMODPlatform platform;

			[Token(Token = "0x6000CF5")]
			public <>c__DisplayClass43_0()
			{
			}

			[Token(Token = "0x6000CF6")]
			internal bool <RemoveSetting>b__0(T x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40006CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool SwitchSettingsMigration;

		[Token(Token = "0x40006CD")]
		private const string SettingsAssetName = "FMODStudioSettings";

		[Token(Token = "0x40006CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Settings instance;

		[Token(Token = "0x40006CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[SerializeField]
		public bool HasSourceProject;

		[Token(Token = "0x40006D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		[SerializeField]
		public bool HasPlatforms;

		[Token(Token = "0x40006D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string sourceProjectPath;

		[Token(Token = "0x40006D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string SourceBankPathUnformatted;

		[Token(Token = "0x40006D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		public bool AutomaticEventLoading;

		[Token(Token = "0x40006D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		public BankLoadType BankLoadType;

		[Token(Token = "0x40006D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		public bool AutomaticSampleLoading;

		[Token(Token = "0x40006D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		public string EncryptionKey;

		[Token(Token = "0x40006D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		public ImportType ImportType;

		[Token(Token = "0x40006D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		public string TargetAssetPath;

		[Token(Token = "0x40006D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		public DEBUG_FLAGS LoggingLevel;

		[Token(Token = "0x40006DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		public List<PlatformIntSetting> SpeakerModeSettings;

		[Token(Token = "0x40006DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		public List<PlatformIntSetting> SampleRateSettings;

		[Token(Token = "0x40006DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		public List<PlatformBoolSetting> LiveUpdateSettings;

		[Token(Token = "0x40006DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		public List<PlatformBoolSetting> OverlaySettings;

		[Token(Token = "0x40006DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		public List<PlatformBoolSetting> LoggingSettings;

		[Token(Token = "0x40006DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		public List<PlatformStringSetting> BankDirectorySettings;

		[Token(Token = "0x40006E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		public List<PlatformIntSetting> VirtualChannelSettings;

		[Token(Token = "0x40006E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		public List<PlatformIntSetting> RealChannelSettings;

		[Token(Token = "0x40006E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		public List<string> Plugins;

		[Token(Token = "0x40006E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		public List<string> MasterBanks;

		[Token(Token = "0x40006E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		public List<string> Banks;

		[Token(Token = "0x40006E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		public List<string> BanksToLoad;

		[Token(Token = "0x40006E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		public ushort LiveUpdatePort;

		[Token(Token = "0x17000014")]
		public static Settings Instance
		{
			[Token(Token = "0x600081D")]
			[Address(RVA = "0xCF95E4", Offset = "0xCF95E4", VA = "0xCF95E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000015")]
		public string SourceProjectPathRelative
		{
			[Token(Token = "0x600081E")]
			[Address(RVA = "0xCFE32C", Offset = "0xCFE32C", VA = "0xCFE32C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600081F")]
			[Address(RVA = "0xCFE334", Offset = "0xCFE334", VA = "0xCFE334")]
			set
			{
			}
		}

		[Token(Token = "0x17000016")]
		public string SourceProjectPathFull
		{
			[Token(Token = "0x6000820")]
			[Address(RVA = "0xCFE35C", Offset = "0xCFE35C", VA = "0xCFE35C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000017")]
		public string SourceBankPathRelative
		{
			[Token(Token = "0x6000821")]
			[Address(RVA = "0xCFE3F0", Offset = "0xCFE3F0", VA = "0xCFE3F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000822")]
			[Address(RVA = "0xCFE3F8", Offset = "0xCFE3F8", VA = "0xCFE3F8")]
			set
			{
			}
		}

		[Token(Token = "0x17000018")]
		public string SourceBankPathFull
		{
			[Token(Token = "0x6000823")]
			[Address(RVA = "0xCFE420", Offset = "0xCFE420", VA = "0xCFE420")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000824")]
		[Address(RVA = "0xCFE4B4", Offset = "0xCFE4B4", VA = "0xCFE4B4")]
		public static FMODPlatform GetParent(FMODPlatform platform)
		{
			return default(FMODPlatform);
		}

		[Token(Token = "0x6000825")]
		public static bool HasSetting<T>(List<T> list, FMODPlatform platform) where T : PlatformSettingBase
		{
			return default(bool);
		}

		[Token(Token = "0x6000826")]
		public static U GetSetting<T, U>(List<T> list, FMODPlatform platform, U def) where T : PlatformSetting<U>
		{
			return (U)null;
		}

		[Token(Token = "0x6000827")]
		public static void SetSetting<T, U>(List<T> list, FMODPlatform platform, U value) where T : PlatformSetting<U>, new()
		{
		}

		[Token(Token = "0x6000828")]
		public static void RemoveSetting<T>(List<T> list, FMODPlatform platform) where T : PlatformSettingBase
		{
		}

		[Token(Token = "0x6000829")]
		[Address(RVA = "0xCF9D34", Offset = "0xCF9D34", VA = "0xCF9D34")]
		public bool IsLiveUpdateEnabled(FMODPlatform platform)
		{
			return default(bool);
		}

		[Token(Token = "0x600082A")]
		[Address(RVA = "0xCFB394", Offset = "0xCFB394", VA = "0xCFB394")]
		public bool IsOverlayEnabled(FMODPlatform platform)
		{
			return default(bool);
		}

		[Token(Token = "0x600082B")]
		[Address(RVA = "0xCF9B20", Offset = "0xCF9B20", VA = "0xCF9B20")]
		public int GetRealChannels(FMODPlatform platform)
		{
			return default(int);
		}

		[Token(Token = "0x600082C")]
		[Address(RVA = "0xCF9BA8", Offset = "0xCF9BA8", VA = "0xCF9BA8")]
		public int GetVirtualChannels(FMODPlatform platform)
		{
			return default(int);
		}

		[Token(Token = "0x600082D")]
		[Address(RVA = "0xCF9C30", Offset = "0xCF9C30", VA = "0xCF9C30")]
		public int GetSpeakerMode(FMODPlatform platform)
		{
			return default(int);
		}

		[Token(Token = "0x600082E")]
		[Address(RVA = "0xCF9A98", Offset = "0xCF9A98", VA = "0xCF9A98")]
		public int GetSampleRate(FMODPlatform platform)
		{
			return default(int);
		}

		[Token(Token = "0x600082F")]
		[Address(RVA = "0xCFE4D8", Offset = "0xCFE4D8", VA = "0xCFE4D8")]
		public string GetBankPlatform(FMODPlatform platform)
		{
			return null;
		}

		[Token(Token = "0x6000830")]
		[Address(RVA = "0xCFE584", Offset = "0xCFE584", VA = "0xCFE584")]
		private Settings()
		{
		}

		[Token(Token = "0x6000831")]
		[Address(RVA = "0xCFE8B0", Offset = "0xCFE8B0", VA = "0xCFE8B0")]
		private void OnEnable()
		{
		}
	}
	[Token(Token = "0x2000145")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x831238", Offset = "0x831238")]
	public class StudioBankLoader : MonoBehaviour
	{
		[Token(Token = "0x40006E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LoaderGameEvent LoadEvent;

		[Token(Token = "0x40006E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public LoaderGameEvent UnloadEvent;

		[Token(Token = "0x40006E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[BankRef]
		public List<string> Banks;

		[Token(Token = "0x40006EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string CollisionTag;

		[Token(Token = "0x40006EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool PreloadSamples;

		[Token(Token = "0x40006EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool isQuitting;

		[Token(Token = "0x6000833")]
		[Address(RVA = "0xCFEA9C", Offset = "0xCFEA9C", VA = "0xCFEA9C")]
		private void HandleGameEvent(LoaderGameEvent gameEvent)
		{
		}

		[Token(Token = "0x6000834")]
		[Address(RVA = "0xCFEE30", Offset = "0xCFEE30", VA = "0xCFEE30")]
		private void Start()
		{
		}

		[Token(Token = "0x6000835")]
		[Address(RVA = "0xCFEE58", Offset = "0xCFEE58", VA = "0xCFEE58")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x6000836")]
		[Address(RVA = "0xCFEE64", Offset = "0xCFEE64", VA = "0xCFEE64")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000837")]
		[Address(RVA = "0xCFEE78", Offset = "0xCFEE78", VA = "0xCFEE78")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000838")]
		[Address(RVA = "0xCFEED8", Offset = "0xCFEED8", VA = "0xCFEED8")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x6000839")]
		[Address(RVA = "0xCFEF38", Offset = "0xCFEF38", VA = "0xCFEF38")]
		private void OnTriggerEnter2D(Collider2D other)
		{
		}

		[Token(Token = "0x600083A")]
		[Address(RVA = "0xCFEF98", Offset = "0xCFEF98", VA = "0xCFEF98")]
		private void OnTriggerExit2D(Collider2D other)
		{
		}

		[Token(Token = "0x600083B")]
		[Address(RVA = "0xCFEAEC", Offset = "0xCFEAEC", VA = "0xCFEAEC")]
		public void Load()
		{
		}

		[Token(Token = "0x600083C")]
		[Address(RVA = "0xCFED1C", Offset = "0xCFED1C", VA = "0xCFED1C")]
		public void Unload()
		{
		}

		[Token(Token = "0x600083D")]
		[Address(RVA = "0xCFEFF8", Offset = "0xCFEFF8", VA = "0xCFEFF8")]
		public StudioBankLoader()
		{
		}
	}
	[Token(Token = "0x2000146")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x831270", Offset = "0x831270")]
	public class StudioEventEmitter : EventHandler
	{
		[Token(Token = "0x40006ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[EventRef]
		public string Event;

		[Token(Token = "0x40006EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public EmitterGameEvent PlayEvent;

		[Token(Token = "0x40006EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public EmitterGameEvent StopEvent;

		[Token(Token = "0x40006F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool AllowFadeout;

		[Token(Token = "0x40006F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool TriggerOnce;

		[Token(Token = "0x40006F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		public bool Preload;

		[Token(Token = "0x40006F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public ParamRef[] Params;

		[Token(Token = "0x40006F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool OverrideAttenuation;

		[Token(Token = "0x40006F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float OverrideMinDistance;

		[Token(Token = "0x40006F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float OverrideMaxDistance;

		[Token(Token = "0x40006F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected EventDescription eventDescription;

		[Token(Token = "0x40006F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected EventInstance instance;

		[Token(Token = "0x40006F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool hasTriggered;

		[Token(Token = "0x40006FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool isQuitting;

		[Token(Token = "0x40006FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool isOneshot;

		[Token(Token = "0x40006FC")]
		private const string SnapshotString = "snapshot";

		[Token(Token = "0x17000019")]
		public EventDescription EventDescription
		{
			[Token(Token = "0x600083E")]
			[Address(RVA = "0xCFF000", Offset = "0xCFF000", VA = "0xCFF000")]
			get
			{
				return default(EventDescription);
			}
		}

		[Token(Token = "0x1700001A")]
		public EventInstance EventInstance
		{
			[Token(Token = "0x600083F")]
			[Address(RVA = "0xCFF008", Offset = "0xCFF008", VA = "0xCFF008")]
			get
			{
				return default(EventInstance);
			}
		}

		[Token(Token = "0x6000840")]
		[Address(RVA = "0xCFF010", Offset = "0xCFF010", VA = "0xCFF010")]
		private void Start()
		{
		}

		[Token(Token = "0x6000841")]
		[Address(RVA = "0xCFF21C", Offset = "0xCFF21C", VA = "0xCFF21C")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x6000842")]
		[Address(RVA = "0xCFF228", Offset = "0xCFF228", VA = "0xCFF228")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000843")]
		[Address(RVA = "0xCFF31C", Offset = "0xCFF31C", VA = "0xCFF31C", Slot = "4")]
		protected override void HandleGameEvent(EmitterGameEvent gameEvent)
		{
		}

		[Token(Token = "0x6000844")]
		[Address(RVA = "0xCFF0F8", Offset = "0xCFF0F8", VA = "0xCFF0F8")]
		private void Lookup()
		{
		}

		[Token(Token = "0x6000845")]
		[Address(RVA = "0xCFF36C", Offset = "0xCFF36C", VA = "0xCFF36C")]
		public void Play()
		{
		}

		[Token(Token = "0x6000846")]
		[Address(RVA = "0xCFF6A0", Offset = "0xCFF6A0", VA = "0xCFF6A0")]
		public void Stop()
		{
		}

		[Token(Token = "0x6000847")]
		[Address(RVA = "0xCFF704", Offset = "0xCFF704", VA = "0xCFF704")]
		public void SetParameter(string name, float value, bool ignoreseekspeed = false)
		{
		}

		[Token(Token = "0x6000848")]
		[Address(RVA = "0xCFF774", Offset = "0xCFF774", VA = "0xCFF774")]
		public void SetParameter(PARAMETER_ID id, float value, bool ignoreseekspeed = false)
		{
		}

		[Token(Token = "0x6000849")]
		[Address(RVA = "0xCFF7E4", Offset = "0xCFF7E4", VA = "0xCFF7E4")]
		public bool IsPlaying()
		{
			return default(bool);
		}

		[Token(Token = "0x600084A")]
		[Address(RVA = "0xCFF850", Offset = "0xCFF850", VA = "0xCFF850")]
		public StudioEventEmitter()
		{
		}
	}
	[Token(Token = "0x2000147")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8312A8", Offset = "0x8312A8")]
	public class StudioGlobalParameterTrigger : EventHandler
	{
		[Token(Token = "0x40006FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[ParamRef]
		public string parameter;

		[Token(Token = "0x40006FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public EmitterGameEvent TriggerEvent;

		[Token(Token = "0x40006FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float value;

		[Token(Token = "0x4000700")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private PARAMETER_DESCRIPTION parameterDescription;

		[Token(Token = "0x1700001B")]
		public PARAMETER_DESCRIPTION ParameterDesctription
		{
			[Token(Token = "0x600084B")]
			[Address(RVA = "0xCFF8CC", Offset = "0xCFF8CC", VA = "0xCFF8CC")]
			get
			{
				return default(PARAMETER_DESCRIPTION);
			}
		}

		[Token(Token = "0x600084C")]
		[Address(RVA = "0xCFF8E0", Offset = "0xCFF8E0", VA = "0xCFF8E0")]
		private RESULT Lookup()
		{
			return default(RESULT);
		}

		[Token(Token = "0x600084D")]
		[Address(RVA = "0xCFF968", Offset = "0xCFF968", VA = "0xCFF968")]
		private void Awake()
		{
		}

		[Token(Token = "0x600084E")]
		[Address(RVA = "0xCFF9AC", Offset = "0xCFF9AC", VA = "0xCFF9AC", Slot = "4")]
		protected override void HandleGameEvent(EmitterGameEvent gameEvent)
		{
		}

		[Token(Token = "0x600084F")]
		[Address(RVA = "0xCFF9C0", Offset = "0xCFF9C0", VA = "0xCFF9C0")]
		public void TriggerParameters()
		{
		}

		[Token(Token = "0x6000850")]
		[Address(RVA = "0xCFFAD4", Offset = "0xCFFAD4", VA = "0xCFFAD4")]
		public StudioGlobalParameterTrigger()
		{
		}
	}
	[Token(Token = "0x2000148")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8312E0", Offset = "0x8312E0")]
	public class StudioListener : MonoBehaviour
	{
		[Token(Token = "0x4000701")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Rigidbody rigidBody;

		[Token(Token = "0x4000702")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Rigidbody2D rigidBody2D;

		[Token(Token = "0x4000703")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int ListenerNumber;

		[Token(Token = "0x6000851")]
		[Address(RVA = "0xCFFAD8", Offset = "0xCFFAD8", VA = "0xCFFAD8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000852")]
		[Address(RVA = "0xCFFB94", Offset = "0xCFFB94", VA = "0xCFFB94")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000853")]
		[Address(RVA = "0xCFFBF8", Offset = "0xCFFBF8", VA = "0xCFFBF8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000854")]
		[Address(RVA = "0xCFFC0C", Offset = "0xCFFC0C", VA = "0xCFFC0C")]
		private void SetListenerLocation()
		{
		}

		[Token(Token = "0x6000855")]
		[Address(RVA = "0xCFFD08", Offset = "0xCFFD08", VA = "0xCFFD08")]
		public StudioListener()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000149")]
	public class EmitterRef
	{
		[Token(Token = "0x4000704")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public StudioEventEmitter Target;

		[Token(Token = "0x4000705")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ParamRef[] Params;

		[Token(Token = "0x6000856")]
		[Address(RVA = "0xCF7BD8", Offset = "0xCF7BD8", VA = "0xCF7BD8")]
		public EmitterRef()
		{
		}
	}
	[Token(Token = "0x200014A")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x831318", Offset = "0x831318")]
	public class StudioParameterTrigger : EventHandler
	{
		[Token(Token = "0x4000706")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EmitterRef[] Emitters;

		[Token(Token = "0x4000707")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public EmitterGameEvent TriggerEvent;

		[Token(Token = "0x6000857")]
		[Address(RVA = "0xCFFD18", Offset = "0xCFFD18", VA = "0xCFFD18")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000858")]
		[Address(RVA = "0xCFFF08", Offset = "0xCFFF08", VA = "0xCFFF08", Slot = "4")]
		protected override void HandleGameEvent(EmitterGameEvent gameEvent)
		{
		}

		[Token(Token = "0x6000859")]
		[Address(RVA = "0xCFFF1C", Offset = "0xCFFF1C", VA = "0xCFFF1C")]
		public void TriggerParameters()
		{
		}

		[Token(Token = "0x600085A")]
		[Address(RVA = "0xD000B4", Offset = "0xD000B4", VA = "0xD000B4")]
		public StudioParameterTrigger()
		{
		}
	}
}
namespace Dreamteck
{
	[Token(Token = "0x200014B")]
	public static class DMath
	{
		[Token(Token = "0x600085B")]
		[Address(RVA = "0x121DDDC", Offset = "0x121DDDC", VA = "0x121DDDC")]
		public static double Sin(double a)
		{
			return default(double);
		}

		[Token(Token = "0x600085C")]
		[Address(RVA = "0x121DE48", Offset = "0x121DE48", VA = "0x121DE48")]
		public static double Cos(double a)
		{
			return default(double);
		}

		[Token(Token = "0x600085D")]
		[Address(RVA = "0x121DEB4", Offset = "0x121DEB4", VA = "0x121DEB4")]
		public static double Tan(double a)
		{
			return default(double);
		}

		[Token(Token = "0x600085E")]
		[Address(RVA = "0x121DF20", Offset = "0x121DF20", VA = "0x121DF20")]
		public static double Pow(double x, double y)
		{
			return default(double);
		}

		[Token(Token = "0x600085F")]
		[Address(RVA = "0x121DF98", Offset = "0x121DF98", VA = "0x121DF98")]
		public static double Log(double a, double newBase)
		{
			return default(double);
		}

		[Token(Token = "0x6000860")]
		[Address(RVA = "0x121E010", Offset = "0x121E010", VA = "0x121E010")]
		public static double Log10(double a)
		{
			return default(double);
		}

		[Token(Token = "0x6000861")]
		[Address(RVA = "0x121E07C", Offset = "0x121E07C", VA = "0x121E07C")]
		public static double Clamp01(double a)
		{
			return default(double);
		}

		[Token(Token = "0x6000862")]
		[Address(RVA = "0x121E09C", Offset = "0x121E09C", VA = "0x121E09C")]
		public static double Clamp(double a, double min, double max)
		{
			return default(double);
		}

		[Token(Token = "0x6000863")]
		[Address(RVA = "0x121E0B8", Offset = "0x121E0B8", VA = "0x121E0B8")]
		public static double Lerp(double a, double b, double t)
		{
			return default(double);
		}

		[Token(Token = "0x6000864")]
		[Address(RVA = "0x121E0DC", Offset = "0x121E0DC", VA = "0x121E0DC")]
		public static double InverseLerp(double a, double b, double t)
		{
			return default(double);
		}

		[Token(Token = "0x6000865")]
		[Address(RVA = "0x121E110", Offset = "0x121E110", VA = "0x121E110")]
		public static Vector3 LerpVector3(Vector3 a, Vector3 b, double t)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000866")]
		[Address(RVA = "0x121E23C", Offset = "0x121E23C", VA = "0x121E23C")]
		public static double Round(double a)
		{
			return default(double);
		}

		[Token(Token = "0x6000867")]
		[Address(RVA = "0x121E314", Offset = "0x121E314", VA = "0x121E314")]
		public static int RoundInt(double a)
		{
			return default(int);
		}

		[Token(Token = "0x6000868")]
		[Address(RVA = "0x121E3F0", Offset = "0x121E3F0", VA = "0x121E3F0")]
		public static double Ceil(double a)
		{
			return default(double);
		}

		[Token(Token = "0x6000869")]
		[Address(RVA = "0x121E45C", Offset = "0x121E45C", VA = "0x121E45C")]
		public static int CeilInt(double a)
		{
			return default(int);
		}

		[Token(Token = "0x600086A")]
		[Address(RVA = "0x121E4C8", Offset = "0x121E4C8", VA = "0x121E4C8")]
		public static double Floor(double a)
		{
			return default(double);
		}

		[Token(Token = "0x600086B")]
		[Address(RVA = "0x121E534", Offset = "0x121E534", VA = "0x121E534")]
		public static int FloorInt(double a)
		{
			return default(int);
		}

		[Token(Token = "0x600086C")]
		[Address(RVA = "0x121E5A0", Offset = "0x121E5A0", VA = "0x121E5A0")]
		public static double Move(double current, double target, double amount)
		{
			return default(double);
		}

		[Token(Token = "0x600086D")]
		[Address(RVA = "0x121E5D0", Offset = "0x121E5D0", VA = "0x121E5D0")]
		public static double Abs(double a)
		{
			return default(double);
		}
	}
	[Token(Token = "0x200014C")]
	public static class LinearAlgebraUtility
	{
		[Token(Token = "0x600086E")]
		[Address(RVA = "0x121E5E0", Offset = "0x121E5E0", VA = "0x121E5E0")]
		public static Vector3 ProjectOnLine(Vector3 fromPoint, Vector3 toPoint, Vector3 project)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600086F")]
		[Address(RVA = "0x121E7F4", Offset = "0x121E7F4", VA = "0x121E7F4")]
		public static float InverseLerp(Vector3 a, Vector3 b, Vector3 value)
		{
			return default(float);
		}
	}
	[Token(Token = "0x200014D")]
	public class MeshUtility
	{
		[Token(Token = "0x4000708")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Vector3[] tan1;

		[Token(Token = "0x4000709")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Vector3[] tan2;

		[Token(Token = "0x400070A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static Vector4[] meshTangents;

		[Token(Token = "0x6000870")]
		[Address(RVA = "0x121E924", Offset = "0x121E924", VA = "0x121E924")]
		public static int[] GeneratePlaneTriangles(int x, int z, bool flip, int startTriangleIndex = 0, int startVertex = 0)
		{
			return null;
		}

		[Token(Token = "0x6000871")]
		[Address(RVA = "0x121E9E8", Offset = "0x121E9E8", VA = "0x121E9E8")]
		public static int[] GeneratePlaneTriangles(ref int[] triangles, int x, int z, bool flip, int startTriangleIndex = 0, int startVertex = 0, bool reallocateArray = false)
		{
			return null;
		}

		[Token(Token = "0x6000872")]
		[Address(RVA = "0x121ECE8", Offset = "0x121ECE8", VA = "0x121ECE8")]
		public static void CalculateTangents(TS_Mesh mesh)
		{
		}

		[Token(Token = "0x6000873")]
		[Address(RVA = "0x121F490", Offset = "0x121F490", VA = "0x121F490")]
		public static void MakeDoublesided(Mesh input)
		{
		}

		[Token(Token = "0x6000874")]
		[Address(RVA = "0x121FF04", Offset = "0x121FF04", VA = "0x121FF04")]
		public static void MakeDoublesided(TS_Mesh input)
		{
		}

		[Token(Token = "0x6000875")]
		[Address(RVA = "0x1220858", Offset = "0x1220858", VA = "0x1220858")]
		public static void MakeDoublesidedHalf(TS_Mesh input)
		{
		}

		[Token(Token = "0x6000876")]
		[Address(RVA = "0x1220E68", Offset = "0x1220E68", VA = "0x1220E68")]
		public static void InverseTransformMesh(TS_Mesh input, TS_Transform transform)
		{
		}

		[Token(Token = "0x6000877")]
		[Address(RVA = "0x1220F58", Offset = "0x1220F58", VA = "0x1220F58")]
		public static void TransformMesh(TS_Mesh input, TS_Transform transform)
		{
		}

		[Token(Token = "0x6000878")]
		[Address(RVA = "0x1221048", Offset = "0x1221048", VA = "0x1221048")]
		public static void InverseTransformMesh(TS_Mesh input, Transform transform)
		{
		}

		[Token(Token = "0x6000879")]
		[Address(RVA = "0x1221138", Offset = "0x1221138", VA = "0x1221138")]
		public static void TransformMesh(TS_Mesh input, Transform transform)
		{
		}

		[Token(Token = "0x600087A")]
		[Address(RVA = "0x1221228", Offset = "0x1221228", VA = "0x1221228")]
		public static void InverseTransformMesh(Mesh input, Transform transform)
		{
		}

		[Token(Token = "0x600087B")]
		[Address(RVA = "0x122137C", Offset = "0x122137C", VA = "0x122137C")]
		public static void TransformMesh(Mesh input, Transform transform)
		{
		}

		[Token(Token = "0x600087C")]
		[Address(RVA = "0x1221514", Offset = "0x1221514", VA = "0x1221514")]
		public static void TransformVertices(Vector3[] vertices, Transform transform)
		{
		}

		[Token(Token = "0x600087D")]
		[Address(RVA = "0x12215A8", Offset = "0x12215A8", VA = "0x12215A8")]
		public static void InverseTransformVertices(Vector3[] vertices, Transform transform)
		{
		}

		[Token(Token = "0x600087E")]
		[Address(RVA = "0x122163C", Offset = "0x122163C", VA = "0x122163C")]
		public static void TransformNormals(Vector3[] normals, Transform transform)
		{
		}

		[Token(Token = "0x600087F")]
		[Address(RVA = "0x12216D0", Offset = "0x12216D0", VA = "0x12216D0")]
		public static void InverseTransformNormals(Vector3[] normals, Transform transform)
		{
		}

		[Token(Token = "0x6000880")]
		[Address(RVA = "0x1221764", Offset = "0x1221764", VA = "0x1221764")]
		public static string ToOBJString(Mesh mesh, Material[] materials)
		{
			return null;
		}

		[Token(Token = "0x6000881")]
		[Address(RVA = "0x122209C", Offset = "0x122209C", VA = "0x122209C")]
		public static Mesh Copy(Mesh input)
		{
			return null;
		}

		[Token(Token = "0x6000882")]
		[Address(RVA = "0x1222298", Offset = "0x1222298", VA = "0x1222298")]
		public static void Triangulate(Vector2[] points, ref int[] output)
		{
		}

		[Token(Token = "0x6000883")]
		[Address(RVA = "0x12228E8", Offset = "0x12228E8", VA = "0x12228E8")]
		public static void FlipTriangles(ref int[] triangles)
		{
		}

		[Token(Token = "0x6000884")]
		[Address(RVA = "0x1222970", Offset = "0x1222970", VA = "0x1222970")]
		public static void FlipFaces(TS_Mesh input)
		{
		}

		[Token(Token = "0x6000885")]
		[Address(RVA = "0x1222B08", Offset = "0x1222B08", VA = "0x1222B08")]
		public static void BreakMesh(Mesh input, bool keepNormals = true)
		{
		}

		[Token(Token = "0x6000886")]
		[Address(RVA = "0x1222630", Offset = "0x1222630", VA = "0x1222630")]
		private static float Area(Vector2[] points, int maxCount)
		{
			return default(float);
		}

		[Token(Token = "0x6000887")]
		[Address(RVA = "0x12226C8", Offset = "0x12226C8", VA = "0x12226C8")]
		private static bool Snip(Vector2[] points, int u, int v, int w, int n, int[] V)
		{
			return default(bool);
		}

		[Token(Token = "0x6000888")]
		[Address(RVA = "0x12234F0", Offset = "0x12234F0", VA = "0x12234F0")]
		private static bool InsideTriangle(Vector2 A, Vector2 B, Vector2 C, Vector2 P)
		{
			return default(bool);
		}

		[Token(Token = "0x6000889")]
		[Address(RVA = "0x122356C", Offset = "0x122356C", VA = "0x122356C")]
		public MeshUtility()
		{
		}
	}
	[Token(Token = "0x200014E")]
	public static class ResourceUtility
	{
		[Token(Token = "0x600088B")]
		[Address(RVA = "0x1223610", Offset = "0x1223610", VA = "0x1223610")]
		public static string FindFolder(string dir, string folderPattern)
		{
			return null;
		}

		[Token(Token = "0x600088C")]
		[Address(RVA = "0x1223A18", Offset = "0x1223A18", VA = "0x1223A18")]
		public static Texture2D LoadTexture(string dreamteckPath, string textureFileName)
		{
			return null;
		}

		[Token(Token = "0x600088D")]
		[Address(RVA = "0x1223B7C", Offset = "0x1223B7C", VA = "0x1223B7C")]
		public static Texture2D LoadTexture(string path)
		{
			return null;
		}
	}
	[Token(Token = "0x200014F")]
	public static class SceneUtility
	{
		[Token(Token = "0x600088E")]
		[Address(RVA = "0x1223C70", Offset = "0x1223C70", VA = "0x1223C70")]
		public static void GetChildrenRecursively(Transform current, ref List<Transform> transformList)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000150")]
	public class TS_Bounds
	{
		[Token(Token = "0x400070B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 center;

		[Token(Token = "0x400070C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 extents;

		[Token(Token = "0x400070D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 max;

		[Token(Token = "0x400070E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Vector3 min;

		[Token(Token = "0x400070F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Vector3 size;

		[Token(Token = "0x600088F")]
		[Address(RVA = "0x157B91C", Offset = "0x157B91C", VA = "0x157B91C")]
		public TS_Bounds()
		{
		}

		[Token(Token = "0x6000890")]
		[Address(RVA = "0x157B9D4", Offset = "0x157B9D4", VA = "0x157B9D4")]
		public TS_Bounds(Bounds bounds)
		{
		}

		[Token(Token = "0x6000891")]
		[Address(RVA = "0x157BB00", Offset = "0x157BB00", VA = "0x157BB00")]
		public TS_Bounds(Vector3 c, Vector3 s)
		{
		}

		[Token(Token = "0x6000892")]
		[Address(RVA = "0x157BC68", Offset = "0x157BC68", VA = "0x157BC68")]
		public TS_Bounds(Vector3 min, Vector3 max, Vector3 center)
		{
		}

		[Token(Token = "0x6000893")]
		[Address(RVA = "0x157BDC8", Offset = "0x157BDC8", VA = "0x157BDC8")]
		public void CreateFromMinMax(Vector3 min, Vector3 max)
		{
		}

		[Token(Token = "0x6000894")]
		[Address(RVA = "0x157BED8", Offset = "0x157BED8", VA = "0x157BED8")]
		public bool Contains(Vector3 point)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000151")]
	public class TS_Mesh
	{
		[Token(Token = "0x4000710")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3[] vertices;

		[Token(Token = "0x4000711")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3[] normals;

		[Token(Token = "0x4000712")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector4[] tangents;

		[Token(Token = "0x4000713")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Color[] colors;

		[Token(Token = "0x4000714")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector2[] uv;

		[Token(Token = "0x4000715")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector2[] uv2;

		[Token(Token = "0x4000716")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Vector2[] uv3;

		[Token(Token = "0x4000717")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector2[] uv4;

		[Token(Token = "0x4000718")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public int[] triangles;

		[Token(Token = "0x4000719")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public List<int[]> subMeshes;

		[Token(Token = "0x400071A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public TS_Bounds bounds;

		[Token(Token = "0x400071B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool hasUpdate;

		[Token(Token = "0x1700001C")]
		public int vertexCount
		{
			[Token(Token = "0x6000895")]
			[Address(RVA = "0x157BF2C", Offset = "0x157BF2C", VA = "0x157BF2C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000896")]
			[Address(RVA = "0x157BF48", Offset = "0x157BF48", VA = "0x157BF48")]
			set
			{
			}
		}

		[Token(Token = "0x6000897")]
		[Address(RVA = "0x157BF4C", Offset = "0x157BF4C", VA = "0x157BF4C")]
		public TS_Mesh()
		{
		}

		[Token(Token = "0x6000898")]
		[Address(RVA = "0x157C108", Offset = "0x157C108", VA = "0x157C108")]
		public TS_Mesh(Mesh mesh)
		{
		}

		[Token(Token = "0x6000899")]
		[Address(RVA = "0x157C470", Offset = "0x157C470", VA = "0x157C470")]
		public void Clear()
		{
		}

		[Token(Token = "0x600089A")]
		[Address(RVA = "0x157C2DC", Offset = "0x157C2DC", VA = "0x157C2DC")]
		public void CreateFromMesh(Mesh mesh)
		{
		}

		[Token(Token = "0x600089B")]
		[Address(RVA = "0x157C624", Offset = "0x157C624", VA = "0x157C624")]
		public void Combine(List<TS_Mesh> newMeshes, bool overwrite = false)
		{
		}

		[Token(Token = "0x600089C")]
		[Address(RVA = "0x157DA88", Offset = "0x157DA88", VA = "0x157DA88")]
		public void Combine(TS_Mesh newMesh)
		{
		}

		[Token(Token = "0x600089D")]
		[Address(RVA = "0x157E170", Offset = "0x157E170", VA = "0x157E170")]
		public static TS_Mesh Copy(TS_Mesh input)
		{
			return null;
		}

		[Token(Token = "0x600089E")]
		[Address(RVA = "0x157E524", Offset = "0x157E524", VA = "0x157E524")]
		public void Absorb(TS_Mesh input)
		{
		}

		[Token(Token = "0x600089F")]
		[Address(RVA = "0x157EB14", Offset = "0x157EB14", VA = "0x157EB14")]
		public void WriteMesh(ref Mesh input)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000152")]
	public class TS_Transform
	{
		[Token(Token = "0x400071C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool setPosition;

		[Token(Token = "0x400071D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		private bool setRotation;

		[Token(Token = "0x400071E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		private bool setScale;

		[Token(Token = "0x400071F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13")]
		private bool setLocalPosition;

		[Token(Token = "0x4000720")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private bool setLocalRotation;

		[Token(Token = "0x4000721")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[HideInInspector]
		private Transform _transform;

		[Token(Token = "0x4000722")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[HideInInspector]
		private float posX;

		[Token(Token = "0x4000723")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		[HideInInspector]
		private float posY;

		[Token(Token = "0x4000724")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		[HideInInspector]
		private float posZ;

		[Token(Token = "0x4000725")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		[HideInInspector]
		private float scaleX;

		[Token(Token = "0x4000726")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[HideInInspector]
		private float scaleY;

		[Token(Token = "0x4000727")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		[HideInInspector]
		private float scaleZ;

		[Token(Token = "0x4000728")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		[HideInInspector]
		private float lossyScaleX;

		[Token(Token = "0x4000729")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		[HideInInspector]
		private float lossyScaleY;

		[Token(Token = "0x400072A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[HideInInspector]
		private float lossyScaleZ;

		[Token(Token = "0x400072B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		[HideInInspector]
		private float rotX;

		[Token(Token = "0x400072C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		[HideInInspector]
		private float rotY;

		[Token(Token = "0x400072D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[SerializeField]
		[HideInInspector]
		private float rotZ;

		[Token(Token = "0x400072E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[HideInInspector]
		private float rotW;

		[Token(Token = "0x400072F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[SerializeField]
		[HideInInspector]
		private float lposX;

		[Token(Token = "0x4000730")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		[HideInInspector]
		private float lposY;

		[Token(Token = "0x4000731")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[SerializeField]
		[HideInInspector]
		private float lposZ;

		[Token(Token = "0x4000732")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		[HideInInspector]
		private float lrotX;

		[Token(Token = "0x4000733")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[SerializeField]
		[HideInInspector]
		private float lrotY;

		[Token(Token = "0x4000734")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		[HideInInspector]
		private float lrotZ;

		[Token(Token = "0x4000735")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		[HideInInspector]
		private float lrotW;

		[Token(Token = "0x1700001D")]
		public Vector3 position
		{
			[Token(Token = "0x60008A0")]
			[Address(RVA = "0x14F6F74", Offset = "0x14F6F74", VA = "0x14F6F74")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60008A1")]
			[Address(RVA = "0x14F6FE8", Offset = "0x14F6FE8", VA = "0x14F6FE8")]
			set
			{
			}
		}

		[Token(Token = "0x1700001E")]
		public Quaternion rotation
		{
			[Token(Token = "0x60008A2")]
			[Address(RVA = "0x14F7044", Offset = "0x14F7044", VA = "0x14F7044")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x60008A3")]
			[Address(RVA = "0x14F70C0", Offset = "0x14F70C0", VA = "0x14F70C0")]
			set
			{
			}
		}

		[Token(Token = "0x1700001F")]
		public Vector3 scale
		{
			[Token(Token = "0x60008A4")]
			[Address(RVA = "0x14F7128", Offset = "0x14F7128", VA = "0x14F7128")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60008A5")]
			[Address(RVA = "0x14F719C", Offset = "0x14F719C", VA = "0x14F719C")]
			set
			{
			}
		}

		[Token(Token = "0x17000020")]
		public Vector3 lossyScale
		{
			[Token(Token = "0x60008A6")]
			[Address(RVA = "0x14F71F4", Offset = "0x14F71F4", VA = "0x14F71F4")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60008A7")]
			[Address(RVA = "0x14F7268", Offset = "0x14F7268", VA = "0x14F7268")]
			set
			{
			}
		}

		[Token(Token = "0x17000021")]
		public Vector3 localPosition
		{
			[Token(Token = "0x60008A8")]
			[Address(RVA = "0x14F72C0", Offset = "0x14F72C0", VA = "0x14F72C0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60008A9")]
			[Address(RVA = "0x14F7334", Offset = "0x14F7334", VA = "0x14F7334")]
			set
			{
			}
		}

		[Token(Token = "0x17000022")]
		public Quaternion localRotation
		{
			[Token(Token = "0x60008AA")]
			[Address(RVA = "0x14F7390", Offset = "0x14F7390", VA = "0x14F7390")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x60008AB")]
			[Address(RVA = "0x14F740C", Offset = "0x14F740C", VA = "0x14F740C")]
			set
			{
			}
		}

		[Token(Token = "0x17000023")]
		public Transform transform
		{
			[Token(Token = "0x60008AC")]
			[Address(RVA = "0x14F7474", Offset = "0x14F7474", VA = "0x14F7474")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008AD")]
		[Address(RVA = "0x14F747C", Offset = "0x14F747C", VA = "0x14F747C")]
		public TS_Transform(Transform input)
		{
		}

		[Token(Token = "0x60008AE")]
		[Address(RVA = "0x14F7504", Offset = "0x14F7504", VA = "0x14F7504")]
		public void Update()
		{
		}

		[Token(Token = "0x60008AF")]
		[Address(RVA = "0x14F74F4", Offset = "0x14F74F4", VA = "0x14F74F4")]
		public void SetTransform(Transform input)
		{
		}

		[Token(Token = "0x60008B0")]
		[Address(RVA = "0x14F76E0", Offset = "0x14F76E0", VA = "0x14F76E0")]
		public bool HasChange()
		{
			return default(bool);
		}

		[Token(Token = "0x60008B1")]
		[Address(RVA = "0x14F7724", Offset = "0x14F7724", VA = "0x14F7724")]
		public bool HasPositionChange()
		{
			return default(bool);
		}

		[Token(Token = "0x60008B2")]
		[Address(RVA = "0x14F77B4", Offset = "0x14F77B4", VA = "0x14F77B4")]
		public bool HasRotationChange()
		{
			return default(bool);
		}

		[Token(Token = "0x60008B3")]
		[Address(RVA = "0x14F7864", Offset = "0x14F7864", VA = "0x14F7864")]
		public bool HasScaleChange()
		{
			return default(bool);
		}

		[Token(Token = "0x60008B4")]
		[Address(RVA = "0x14F78F4", Offset = "0x14F78F4", VA = "0x14F78F4")]
		public Vector3 TransformPoint(Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60008B5")]
		[Address(RVA = "0x14F7A64", Offset = "0x14F7A64", VA = "0x14F7A64")]
		public Vector3 TransformDirection(Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60008B6")]
		[Address(RVA = "0x14F7B38", Offset = "0x14F7B38", VA = "0x14F7B38")]
		public Vector3 InverseTransformPoint(Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60008B7")]
		[Address(RVA = "0x14F7BF4", Offset = "0x14F7BF4", VA = "0x14F7BF4")]
		public Vector3 InverseTransformDirection(Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60008B8")]
		public T GetComponent<T>()
		{
			return (T)null;
		}
	}
	[Token(Token = "0x2000153")]
	public static class TransformUtility
	{
		[Token(Token = "0x60008B9")]
		[Address(RVA = "0x14F7D18", Offset = "0x14F7D18", VA = "0x14F7D18")]
		public static Vector3 GetPosition(ref Matrix4x4 m)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60008BA")]
		[Address(RVA = "0x14F7DBC", Offset = "0x14F7DBC", VA = "0x14F7DBC")]
		public static Quaternion GetRotation(ref Matrix4x4 m)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60008BB")]
		[Address(RVA = "0x14F7ED8", Offset = "0x14F7ED8", VA = "0x14F7ED8")]
		public static Vector3 GetScale(ref Matrix4x4 m)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60008BC")]
		[Address(RVA = "0x14F7F9C", Offset = "0x14F7F9C", VA = "0x14F7F9C")]
		public static void SetPosition(ref Matrix4x4 m, ref Vector3 p)
		{
		}
	}
}
namespace Dreamteck.Splines
{
	[Token(Token = "0x2000154")]
	public class BlankUser : SplineUser
	{
		[Token(Token = "0x60008BD")]
		[Address(RVA = "0x1223ECC", Offset = "0x1223ECC", VA = "0x1223ECC")]
		private void Start()
		{
		}

		[Token(Token = "0x60008BE")]
		[Address(RVA = "0x1223ED0", Offset = "0x1223ED0", VA = "0x1223ED0", Slot = "19")]
		protected override void LateRun()
		{
		}

		[Token(Token = "0x60008BF")]
		[Address(RVA = "0x1223ED8", Offset = "0x1223ED8", VA = "0x1223ED8", Slot = "20")]
		protected override void Build()
		{
		}

		[Token(Token = "0x60008C0")]
		[Address(RVA = "0x1223EE0", Offset = "0x1223EE0", VA = "0x1223EE0", Slot = "21")]
		protected override void PostBuild()
		{
		}

		[Token(Token = "0x60008C1")]
		[Address(RVA = "0x1223EE8", Offset = "0x1223EE8", VA = "0x1223EE8")]
		public BlankUser()
		{
		}
	}
	[Token(Token = "0x2000155")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x831350", Offset = "0x831350")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x831350", Offset = "0x831350")]
	public class EdgeColliderGenerator : SplineUser
	{
		[Token(Token = "0x4000736")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[HideInInspector]
		private float _offset;

		[Token(Token = "0x4000737")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[HideInInspector]
		protected EdgeCollider2D edgeCollider;

		[Token(Token = "0x4000738")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[HideInInspector]
		protected Vector2[] vertices;

		[Token(Token = "0x4000739")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[HideInInspector]
		public float updateRate;

		[Token(Token = "0x400073A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		protected float lastUpdateTime;

		[Token(Token = "0x400073B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private bool updateCollider;

		[Token(Token = "0x17000024")]
		public float offset
		{
			[Token(Token = "0x60008C2")]
			[Address(RVA = "0x12252E8", Offset = "0x12252E8", VA = "0x12252E8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60008C3")]
			[Address(RVA = "0x12252F0", Offset = "0x12252F0", VA = "0x12252F0")]
			set
			{
			}
		}

		[Token(Token = "0x60008C4")]
		[Address(RVA = "0x1225314", Offset = "0x1225314", VA = "0x1225314", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60008C5")]
		[Address(RVA = "0x1225378", Offset = "0x1225378", VA = "0x1225378", Slot = "5")]
		protected override void Reset()
		{
		}

		[Token(Token = "0x60008C6")]
		[Address(RVA = "0x1225380", Offset = "0x1225380", VA = "0x1225380", Slot = "6")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x60008C7")]
		[Address(RVA = "0x1225388", Offset = "0x1225388", VA = "0x1225388", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x60008C8")]
		[Address(RVA = "0x1225390", Offset = "0x1225390", VA = "0x1225390", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60008C9")]
		[Address(RVA = "0x1225398", Offset = "0x1225398", VA = "0x1225398", Slot = "19")]
		protected override void LateRun()
		{
		}

		[Token(Token = "0x60008CA")]
		[Address(RVA = "0x122546C", Offset = "0x122546C", VA = "0x122546C", Slot = "20")]
		protected override void Build()
		{
		}

		[Token(Token = "0x60008CB")]
		[Address(RVA = "0x122573C", Offset = "0x122573C", VA = "0x122573C", Slot = "21")]
		protected override void PostBuild()
		{
		}

		[Token(Token = "0x60008CC")]
		[Address(RVA = "0x12258DC", Offset = "0x12258DC", VA = "0x12258DC")]
		public EdgeColliderGenerator()
		{
		}
	}
	[Token(Token = "0x2000156")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x8313D8", Offset = "0x8313D8")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x8313D8", Offset = "0x8313D8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8313D8", Offset = "0x8313D8")]
	public class ExtrudeMesh : MeshGenerator
	{
		[Token(Token = "0x20001CA")]
		public enum Axis
		{
			[Token(Token = "0x40009DF")]
			X,
			[Token(Token = "0x40009E0")]
			Y,
			[Token(Token = "0x40009E1")]
			Z
		}

		[Token(Token = "0x20001CB")]
		public enum Iteration
		{
			[Token(Token = "0x40009E3")]
			Ordered,
			[Token(Token = "0x40009E4")]
			Random
		}

		[Token(Token = "0x20001CC")]
		public enum MirrorMethod
		{
			[Token(Token = "0x40009E6")]
			None,
			[Token(Token = "0x40009E7")]
			X,
			[Token(Token = "0x40009E8")]
			Y,
			[Token(Token = "0x40009E9")]
			Z
		}

		[Token(Token = "0x20001CD")]
		public enum TileUVs
		{
			[Token(Token = "0x40009EB")]
			None,
			[Token(Token = "0x40009EC")]
			U,
			[Token(Token = "0x40009ED")]
			V,
			[Token(Token = "0x40009EE")]
			UniformU,
			[Token(Token = "0x40009EF")]
			UniformV
		}

		[Serializable]
		[Token(Token = "0x20001CE")]
		internal class ExtrudableMesh
		{
			[Serializable]
			[Token(Token = "0x200022B")]
			public class VertexGroup
			{
				[Token(Token = "0x4000B96")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public float value;

				[Token(Token = "0x4000B97")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public int[] ids;

				[Token(Token = "0x6000E4A")]
				[Address(RVA = "0x122A7C0", Offset = "0x122A7C0", VA = "0x122A7C0")]
				public VertexGroup(float val, int[] vertIds)
				{
				}

				[Token(Token = "0x6000E4B")]
				[Address(RVA = "0x122A7FC", Offset = "0x122A7FC", VA = "0x122A7FC")]
				public void AddId(int id)
				{
				}
			}

			[Serializable]
			[Token(Token = "0x200022C")]
			public class Submesh
			{
				[Token(Token = "0x4000B98")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public int[] triangles;

				[Token(Token = "0x6000E4C")]
				[Address(RVA = "0x122A8B8", Offset = "0x122A8B8", VA = "0x122A8B8")]
				public Submesh()
				{
				}

				[Token(Token = "0x6000E4D")]
				[Address(RVA = "0x1229B94", Offset = "0x1229B94", VA = "0x1229B94")]
				public Submesh(int[] input)
				{
				}
			}

			[Token(Token = "0x40009F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3[] vertices;

			[Token(Token = "0x40009F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3[] normals;

			[Token(Token = "0x40009F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector4[] tangents;

			[Token(Token = "0x40009F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Color[] colors;

			[Token(Token = "0x40009F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Vector2[] uv;

			[Token(Token = "0x40009F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public List<Submesh> subMeshes;

			[Token(Token = "0x40009F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public TS_Bounds bounds;

			[Token(Token = "0x40009F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public List<VertexGroup> vertexGroups;

			[Token(Token = "0x40009F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[SerializeField]
			private MirrorMethod _mirror;

			[Token(Token = "0x40009F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[SerializeField]
			private Axis _axis;

			[Token(Token = "0x170000D6")]
			public MirrorMethod mirror
			{
				[Token(Token = "0x6000CF7")]
				[Address(RVA = "0x1229148", Offset = "0x1229148", VA = "0x1229148")]
				get
				{
					return default(MirrorMethod);
				}
				[Token(Token = "0x6000CF8")]
				[Address(RVA = "0x1226858", Offset = "0x1226858", VA = "0x1226858")]
				set
				{
				}
			}

			[Token(Token = "0x6000CF9")]
			[Address(RVA = "0x12298E8", Offset = "0x12298E8", VA = "0x12298E8")]
			public ExtrudableMesh()
			{
			}

			[Token(Token = "0x6000CFA")]
			[Address(RVA = "0x1226B9C", Offset = "0x1226B9C", VA = "0x1226B9C")]
			public ExtrudableMesh(Mesh inputMesh, Axis axis)
			{
			}

			[Token(Token = "0x6000CFB")]
			[Address(RVA = "0x1228B80", Offset = "0x1228B80", VA = "0x1228B80")]
			public void Update(Mesh inputMesh, Axis axis)
			{
			}

			[Token(Token = "0x6000CFC")]
			[Address(RVA = "0x1229150", Offset = "0x1229150", VA = "0x1229150")]
			private void Mirror(MirrorMethod method)
			{
			}

			[Token(Token = "0x6000CFD")]
			[Address(RVA = "0x1229C2C", Offset = "0x1229C2C", VA = "0x1229C2C")]
			private void GroupVertices(Axis axis)
			{
			}

			[Token(Token = "0x6000CFE")]
			[Address(RVA = "0x122A6A4", Offset = "0x122A6A4", VA = "0x122A6A4")]
			private int FindInsertIndex(Vector3 pos, float value)
			{
				return default(int);
			}

			[Token(Token = "0x6000CFF")]
			[Address(RVA = "0x1229F90", Offset = "0x1229F90", VA = "0x1229F90")]
			private void CalculateTangents()
			{
			}
		}

		[Token(Token = "0x400073C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		[SerializeField]
		[HideInInspector]
		private Mesh _startMesh;

		[Token(Token = "0x400073D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		[SerializeField]
		[HideInInspector]
		private Mesh _endMesh;

		[Token(Token = "0x400073E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		[SerializeField]
		[HideInInspector]
		private bool _dontStretchCaps;

		[Token(Token = "0x400073F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
		[SerializeField]
		[HideInInspector]
		private TileUVs _tileUVs;

		[Token(Token = "0x4000740")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		[SerializeField]
		[HideInInspector]
		private Mesh[] _middleMeshes;

		[Token(Token = "0x4000741")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		[SerializeField]
		[HideInInspector]
		private List<ExtrudableMesh> extrudableMeshes;

		[Token(Token = "0x4000742")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		[SerializeField]
		[HideInInspector]
		private Axis _axis;

		[Token(Token = "0x4000743")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
		[SerializeField]
		[HideInInspector]
		private Iteration _iteration;

		[Token(Token = "0x4000744")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		[SerializeField]
		[HideInInspector]
		private int _randomSeed;

		[Token(Token = "0x4000745")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		[SerializeField]
		[HideInInspector]
		private int _repeat;

		[Token(Token = "0x4000746")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		[SerializeField]
		[HideInInspector]
		private double _spacing;

		[Token(Token = "0x4000747")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		[SerializeField]
		[HideInInspector]
		private Vector2 _scale;

		[Token(Token = "0x4000748")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private SplineResult lastResult;

		[Token(Token = "0x4000749")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private bool useLastResult;

		[Token(Token = "0x400074A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private List<TS_Mesh> combineMeshes;

		[Token(Token = "0x400074B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private System.Random random;

		[Token(Token = "0x400074C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private int iterations;

		[Token(Token = "0x400074D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
		private bool _hasAnyMesh;

		[Token(Token = "0x400074E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19D")]
		private bool _hasStartMesh;

		[Token(Token = "0x400074F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19E")]
		private bool _hasEndMesh;

		[Token(Token = "0x4000750")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private Matrix4x4 vertexMatrix;

		[Token(Token = "0x4000751")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private Matrix4x4 normalMatrix;

		[Token(Token = "0x17000025")]
		public Axis axis
		{
			[Token(Token = "0x60008CD")]
			[Address(RVA = "0x1225B9C", Offset = "0x1225B9C", VA = "0x1225B9C")]
			get
			{
				return default(Axis);
			}
			[Token(Token = "0x60008CE")]
			[Address(RVA = "0x1225BA4", Offset = "0x1225BA4", VA = "0x1225BA4")]
			set
			{
			}
		}

		[Token(Token = "0x17000026")]
		public Iteration iteration
		{
			[Token(Token = "0x60008CF")]
			[Address(RVA = "0x1225F18", Offset = "0x1225F18", VA = "0x1225F18")]
			get
			{
				return default(Iteration);
			}
			[Token(Token = "0x60008D0")]
			[Address(RVA = "0x1225F20", Offset = "0x1225F20", VA = "0x1225F20")]
			set
			{
			}
		}

		[Token(Token = "0x17000027")]
		public int randomSeed
		{
			[Token(Token = "0x60008D1")]
			[Address(RVA = "0x1225F64", Offset = "0x1225F64", VA = "0x1225F64")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60008D2")]
			[Address(RVA = "0x1225F6C", Offset = "0x1225F6C", VA = "0x1225F6C")]
			set
			{
			}
		}

		[Token(Token = "0x17000028")]
		public int repeat
		{
			[Token(Token = "0x60008D3")]
			[Address(RVA = "0x1225FC8", Offset = "0x1225FC8", VA = "0x1225FC8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60008D4")]
			[Address(RVA = "0x1225FD0", Offset = "0x1225FD0", VA = "0x1225FD0")]
			set
			{
			}
		}

		[Token(Token = "0x17000029")]
		public bool dontStretchCaps
		{
			[Token(Token = "0x60008D5")]
			[Address(RVA = "0x1226360", Offset = "0x1226360", VA = "0x1226360")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008D6")]
			[Address(RVA = "0x1226368", Offset = "0x1226368", VA = "0x1226368")]
			set
			{
			}
		}

		[Token(Token = "0x1700002A")]
		public TileUVs tileUVs
		{
			[Token(Token = "0x60008D7")]
			[Address(RVA = "0x1226398", Offset = "0x1226398", VA = "0x1226398")]
			get
			{
				return default(TileUVs);
			}
			[Token(Token = "0x60008D8")]
			[Address(RVA = "0x12263A0", Offset = "0x12263A0", VA = "0x12263A0")]
			set
			{
			}
		}

		[Token(Token = "0x1700002B")]
		public double spacing
		{
			[Token(Token = "0x60008D9")]
			[Address(RVA = "0x12263C4", Offset = "0x12263C4", VA = "0x12263C4")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x60008DA")]
			[Address(RVA = "0x12263CC", Offset = "0x12263CC", VA = "0x12263CC")]
			set
			{
			}
		}

		[Token(Token = "0x1700002C")]
		public Vector2 scale
		{
			[Token(Token = "0x60008DB")]
			[Address(RVA = "0x1226440", Offset = "0x1226440", VA = "0x1226440")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x60008DC")]
			[Address(RVA = "0x122644C", Offset = "0x122644C", VA = "0x122644C")]
			set
			{
			}
		}

		[Token(Token = "0x1700002D")]
		public bool hasAnyMesh
		{
			[Token(Token = "0x60008DD")]
			[Address(RVA = "0x1226514", Offset = "0x1226514", VA = "0x1226514")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60008DE")]
		[Address(RVA = "0x122651C", Offset = "0x122651C", VA = "0x122651C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60008DF")]
		[Address(RVA = "0x12266D0", Offset = "0x12266D0", VA = "0x12266D0")]
		public Mesh GetStartMesh()
		{
			return null;
		}

		[Token(Token = "0x60008E0")]
		[Address(RVA = "0x12266D8", Offset = "0x12266D8", VA = "0x12266D8")]
		public Mesh GetEndMesh()
		{
			return null;
		}

		[Token(Token = "0x60008E1")]
		[Address(RVA = "0x12266E0", Offset = "0x12266E0", VA = "0x12266E0")]
		public MirrorMethod GetStartMeshMirror()
		{
			return default(MirrorMethod);
		}

		[Token(Token = "0x60008E2")]
		[Address(RVA = "0x122674C", Offset = "0x122674C", VA = "0x122674C")]
		public MirrorMethod GetEndMeshMirror()
		{
			return default(MirrorMethod);
		}

		[Token(Token = "0x60008E3")]
		[Address(RVA = "0x12267BC", Offset = "0x12267BC", VA = "0x12267BC")]
		public void SetStartMeshMirror(MirrorMethod mirror)
		{
		}

		[Token(Token = "0x60008E4")]
		[Address(RVA = "0x122689C", Offset = "0x122689C", VA = "0x122689C")]
		public void SetEndMeshMirror(MirrorMethod mirror)
		{
		}

		[Token(Token = "0x60008E5")]
		[Address(RVA = "0x122693C", Offset = "0x122693C", VA = "0x122693C")]
		public void SetMeshMirror(int index, MirrorMethod mirror)
		{
		}

		[Token(Token = "0x60008E6")]
		[Address(RVA = "0x1226A24", Offset = "0x1226A24", VA = "0x1226A24")]
		public void SetStartMesh(Mesh inputMesh, MirrorMethod mirror = MirrorMethod.None)
		{
		}

		[Token(Token = "0x60008E7")]
		[Address(RVA = "0x1226D64", Offset = "0x1226D64", VA = "0x1226D64")]
		public void SetEndMesh(Mesh inputMesh, MirrorMethod mirror = MirrorMethod.None)
		{
		}

		[Token(Token = "0x60008E8")]
		[Address(RVA = "0x1226F00", Offset = "0x1226F00", VA = "0x1226F00")]
		public Mesh GetMesh(int index)
		{
			return null;
		}

		[Token(Token = "0x60008E9")]
		[Address(RVA = "0x1226F3C", Offset = "0x1226F3C", VA = "0x1226F3C")]
		public MirrorMethod GetMeshMirror(int index)
		{
			return default(MirrorMethod);
		}

		[Token(Token = "0x60008EA")]
		[Address(RVA = "0x1226FF8", Offset = "0x1226FF8", VA = "0x1226FF8")]
		public void SetMesh(int index, Mesh inputMesh, MirrorMethod mirror = MirrorMethod.None)
		{
		}

		[Token(Token = "0x60008EB")]
		[Address(RVA = "0x122714C", Offset = "0x122714C", VA = "0x122714C")]
		public void RemoveMesh(int index)
		{
		}

		[Token(Token = "0x60008EC")]
		[Address(RVA = "0x12272D8", Offset = "0x12272D8", VA = "0x12272D8")]
		public void AddMesh(Mesh inputMesh)
		{
		}

		[Token(Token = "0x60008ED")]
		[Address(RVA = "0x122658C", Offset = "0x122658C", VA = "0x122658C")]
		private void CheckMeshes()
		{
		}

		[Token(Token = "0x60008EE")]
		[Address(RVA = "0x122741C", Offset = "0x122741C", VA = "0x122741C")]
		public int GetMeshCount()
		{
			return default(int);
		}

		[Token(Token = "0x60008EF")]
		[Address(RVA = "0x1227438", Offset = "0x1227438", VA = "0x1227438", Slot = "29")]
		protected override void BuildMesh()
		{
		}

		[Token(Token = "0x60008F0")]
		[Address(RVA = "0x12274B4", Offset = "0x12274B4", VA = "0x12274B4")]
		private void Generate()
		{
		}

		[Token(Token = "0x60008F1")]
		[Address(RVA = "0x1227850", Offset = "0x1227850", VA = "0x1227850")]
		private int GetMeshIndex(int repeatIndex)
		{
			return default(int);
		}

		[Token(Token = "0x60008F2")]
		[Address(RVA = "0x12282F4", Offset = "0x12282F4", VA = "0x12282F4")]
		private void TRS(ExtrudableMesh source, TS_Mesh target, double percent)
		{
		}

		[Token(Token = "0x60008F3")]
		[Address(RVA = "0x1228830", Offset = "0x1228830", VA = "0x1228830")]
		private void CreateTSFromExtrudableMesh(ExtrudableMesh source, ref TS_Mesh target)
		{
		}

		[Token(Token = "0x60008F4")]
		[Address(RVA = "0x1227930", Offset = "0x1227930", VA = "0x1227930")]
		private void Stretch(ExtrudableMesh source, TS_Mesh target, double from, double to)
		{
		}

		[Token(Token = "0x60008F5")]
		[Address(RVA = "0x1225BE8", Offset = "0x1225BE8", VA = "0x1225BE8")]
		private void UpdateExtrudableMeshes()
		{
		}

		[Token(Token = "0x60008F6")]
		[Address(RVA = "0x1228DD0", Offset = "0x1228DD0", VA = "0x1228DD0")]
		private void UpdateStartExtrudeMesh()
		{
		}

		[Token(Token = "0x60008F7")]
		[Address(RVA = "0x122601C", Offset = "0x122601C", VA = "0x122601C")]
		private void UpdateEndExtrudeMesh()
		{
		}

		[Token(Token = "0x60008F8")]
		[Address(RVA = "0x1229018", Offset = "0x1229018", VA = "0x1229018")]
		public ExtrudeMesh()
		{
		}
	}
	[Token(Token = "0x2000157")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x831488", Offset = "0x831488")]
	public class LengthCalculator : SplineUser
	{
		[Serializable]
		[Token(Token = "0x20001CF")]
		public class LengthEvent
		{
			[Token(Token = "0x200022D")]
			public enum Type
			{
				[Token(Token = "0x4000B9A")]
				Growing,
				[Token(Token = "0x4000B9B")]
				Shrinking,
				[Token(Token = "0x4000B9C")]
				Both
			}

			[Token(Token = "0x40009FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool enabled;

			[Token(Token = "0x40009FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float targetLength;

			[Token(Token = "0x40009FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public SplineAction action;

			[Token(Token = "0x40009FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Type type;

			[Token(Token = "0x6000D00")]
			[Address(RVA = "0x13CEAC8", Offset = "0x13CEAC8", VA = "0x13CEAC8")]
			public LengthEvent()
			{
			}

			[Token(Token = "0x6000D01")]
			[Address(RVA = "0x13CEB40", Offset = "0x13CEB40", VA = "0x13CEB40")]
			public LengthEvent(Type t)
			{
			}

			[Token(Token = "0x6000D02")]
			[Address(RVA = "0x13CE454", Offset = "0x13CE454", VA = "0x13CE454")]
			public LengthEvent(Type t, SplineAction a)
			{
			}

			[Token(Token = "0x6000D03")]
			[Address(RVA = "0x13CE234", Offset = "0x13CE234", VA = "0x13CE234")]
			public void Check(float fromLength, float toLength)
			{
			}
		}

		[Token(Token = "0x4000752")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		public LengthEvent[] lengthEvents;

		[Token(Token = "0x4000753")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[HideInInspector]
		public float idealLength;

		[Token(Token = "0x4000754")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float _length;

		[Token(Token = "0x4000755")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private float lastLength;

		[Token(Token = "0x1700002E")]
		public float length
		{
			[Token(Token = "0x60008F9")]
			[Address(RVA = "0x13CE0E4", Offset = "0x13CE0E4", VA = "0x13CE0E4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60008FA")]
		[Address(RVA = "0x13CE0EC", Offset = "0x13CE0EC", VA = "0x13CE0EC", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60008FB")]
		[Address(RVA = "0x13CE190", Offset = "0x13CE190", VA = "0x13CE190", Slot = "20")]
		protected override void Build()
		{
		}

		[Token(Token = "0x60008FC")]
		[Address(RVA = "0x13CE2B4", Offset = "0x13CE2B4", VA = "0x13CE2B4")]
		private void AddEvent(LengthEvent lengthEvent)
		{
		}

		[Token(Token = "0x60008FD")]
		[Address(RVA = "0x13CE394", Offset = "0x13CE394", VA = "0x13CE394")]
		public void AddEvent(LengthEvent.Type t, UnityAction call, float targetLength = 0f, LengthEvent.Type type = LengthEvent.Type.Both)
		{
		}

		[Token(Token = "0x60008FE")]
		[Address(RVA = "0x13CE4E8", Offset = "0x13CE4E8", VA = "0x13CE4E8")]
		public void AddEvent(LengthEvent.Type t, UnityAction<int> call, int value, float targetLength = 0f, LengthEvent.Type type = LengthEvent.Type.Both)
		{
		}

		[Token(Token = "0x60008FF")]
		[Address(RVA = "0x13CE5B0", Offset = "0x13CE5B0", VA = "0x13CE5B0")]
		public void AddEvent(LengthEvent.Type t, UnityAction<float> call, float value, float targetLength = 0f, LengthEvent.Type type = LengthEvent.Type.Both)
		{
		}

		[Token(Token = "0x6000900")]
		[Address(RVA = "0x13CE678", Offset = "0x13CE678", VA = "0x13CE678")]
		public void AddEvent(LengthEvent.Type t, UnityAction<double> call, double value, float targetLength = 0f, LengthEvent.Type type = LengthEvent.Type.Both)
		{
		}

		[Token(Token = "0x6000901")]
		[Address(RVA = "0x13CE740", Offset = "0x13CE740", VA = "0x13CE740")]
		public void AddTrigger(LengthEvent.Type t, UnityAction<string> call, string value, float targetLength = 0f, LengthEvent.Type type = LengthEvent.Type.Both)
		{
		}

		[Token(Token = "0x6000902")]
		[Address(RVA = "0x13CE808", Offset = "0x13CE808", VA = "0x13CE808")]
		public void AddEvent(LengthEvent.Type t, UnityAction<bool> call, bool value, float targetLength = 0f, LengthEvent.Type type = LengthEvent.Type.Both)
		{
		}

		[Token(Token = "0x6000903")]
		[Address(RVA = "0x13CE8D0", Offset = "0x13CE8D0", VA = "0x13CE8D0")]
		public void AddEvent(LengthEvent.Type t, UnityAction<GameObject> call, GameObject value, float targetLength = 0f, LengthEvent.Type type = LengthEvent.Type.Both)
		{
		}

		[Token(Token = "0x6000904")]
		[Address(RVA = "0x13CE998", Offset = "0x13CE998", VA = "0x13CE998")]
		public void AddEvent(LengthEvent.Type t, UnityAction<Transform> call, Transform value, float targetLength = 0f, LengthEvent.Type type = LengthEvent.Type.Both)
		{
		}

		[Token(Token = "0x6000905")]
		[Address(RVA = "0x13CEA60", Offset = "0x13CEA60", VA = "0x13CEA60")]
		public LengthCalculator()
		{
		}
	}
	[Token(Token = "0x2000158")]
	public class MeshGenerator : SplineUser
	{
		[Token(Token = "0x20001D0")]
		public enum UVMode
		{
			[Token(Token = "0x40009FF")]
			Clip,
			[Token(Token = "0x4000A00")]
			UniformClip,
			[Token(Token = "0x4000A01")]
			Clamp,
			[Token(Token = "0x4000A02")]
			UniformClamp
		}

		[Token(Token = "0x4000756")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[HideInInspector]
		private bool _baked;

		[Token(Token = "0x4000757")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[SerializeField]
		[HideInInspector]
		private float _size;

		[Token(Token = "0x4000758")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[HideInInspector]
		private Color _color;

		[Token(Token = "0x4000759")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[HideInInspector]
		private Vector3 _offset;

		[Token(Token = "0x400075A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[SerializeField]
		[HideInInspector]
		private int _normalMethod;

		[Token(Token = "0x400075B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[HideInInspector]
		private bool _tangents;

		[Token(Token = "0x400075C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		[SerializeField]
		[HideInInspector]
		private float _rotation;

		[Token(Token = "0x400075D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[HideInInspector]
		private bool _flipFaces;

		[Token(Token = "0x400075E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD9")]
		[SerializeField]
		[HideInInspector]
		private bool _doubleSided;

		[Token(Token = "0x400075F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[SerializeField]
		[HideInInspector]
		private UVMode _uvMode;

		[Token(Token = "0x4000760")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[SerializeField]
		[HideInInspector]
		private Vector2 _uvScale;

		[Token(Token = "0x4000761")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[SerializeField]
		[HideInInspector]
		private Vector2 _uvOffset;

		[Token(Token = "0x4000762")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[SerializeField]
		[HideInInspector]
		private float _uvRotation;

		[Token(Token = "0x4000763")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[SerializeField]
		[HideInInspector]
		protected MeshCollider meshCollider;

		[Token(Token = "0x4000764")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[SerializeField]
		[HideInInspector]
		protected MeshFilter filter;

		[Token(Token = "0x4000765")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[SerializeField]
		[HideInInspector]
		protected MeshRenderer meshRenderer;

		[Token(Token = "0x4000766")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[SerializeField]
		[HideInInspector]
		protected TS_Mesh tsMesh;

		[Token(Token = "0x4000767")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[SerializeField]
		[HideInInspector]
		protected Mesh mesh;

		[Token(Token = "0x4000768")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[HideInInspector]
		public float colliderUpdateRate;

		[Token(Token = "0x4000769")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		protected bool updateCollider;

		[Token(Token = "0x400076A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		protected float lastUpdateTime;

		[Token(Token = "0x400076B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private float vDist;

		[Token(Token = "0x400076C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected static Vector2 uvs;

		[Token(Token = "0x1700002F")]
		public float size
		{
			[Token(Token = "0x6000906")]
			[Address(RVA = "0x13CEBCC", Offset = "0x13CEBCC", VA = "0x13CEBCC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000907")]
			[Address(RVA = "0x13CEBD4", Offset = "0x13CEBD4", VA = "0x13CEBD4")]
			set
			{
			}
		}

		[Token(Token = "0x17000030")]
		public Color color
		{
			[Token(Token = "0x6000908")]
			[Address(RVA = "0x13CEBF8", Offset = "0x13CEBF8", VA = "0x13CEBF8")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000909")]
			[Address(RVA = "0x13CEC04", Offset = "0x13CEC04", VA = "0x13CEC04")]
			set
			{
			}
		}

		[Token(Token = "0x17000031")]
		public Vector3 offset
		{
			[Token(Token = "0x600090A")]
			[Address(RVA = "0x13CEC80", Offset = "0x13CEC80", VA = "0x13CEC80")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600090B")]
			[Address(RVA = "0x13CEC8C", Offset = "0x13CEC8C", VA = "0x13CEC8C")]
			set
			{
			}
		}

		[Token(Token = "0x17000032")]
		public int normalMethod
		{
			[Token(Token = "0x600090C")]
			[Address(RVA = "0x13CED6C", Offset = "0x13CED6C", VA = "0x13CED6C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600090D")]
			[Address(RVA = "0x13CED74", Offset = "0x13CED74", VA = "0x13CED74")]
			set
			{
			}
		}

		[Token(Token = "0x17000033")]
		public bool calculateTangents
		{
			[Token(Token = "0x600090E")]
			[Address(RVA = "0x13CED98", Offset = "0x13CED98", VA = "0x13CED98")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600090F")]
			[Address(RVA = "0x13CEDA0", Offset = "0x13CEDA0", VA = "0x13CEDA0")]
			set
			{
			}
		}

		[Token(Token = "0x17000034")]
		public float rotation
		{
			[Token(Token = "0x6000910")]
			[Address(RVA = "0x13CEDD0", Offset = "0x13CEDD0", VA = "0x13CEDD0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000911")]
			[Address(RVA = "0x13CEDD8", Offset = "0x13CEDD8", VA = "0x13CEDD8")]
			set
			{
			}
		}

		[Token(Token = "0x17000035")]
		public bool flipFaces
		{
			[Token(Token = "0x6000912")]
			[Address(RVA = "0x13CEDFC", Offset = "0x13CEDFC", VA = "0x13CEDFC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000913")]
			[Address(RVA = "0x13CEE04", Offset = "0x13CEE04", VA = "0x13CEE04")]
			set
			{
			}
		}

		[Token(Token = "0x17000036")]
		public bool doubleSided
		{
			[Token(Token = "0x6000914")]
			[Address(RVA = "0x13CEE34", Offset = "0x13CEE34", VA = "0x13CEE34")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000915")]
			[Address(RVA = "0x13CEE3C", Offset = "0x13CEE3C", VA = "0x13CEE3C")]
			set
			{
			}
		}

		[Token(Token = "0x17000037")]
		public UVMode uvMode
		{
			[Token(Token = "0x6000916")]
			[Address(RVA = "0x13CEE6C", Offset = "0x13CEE6C", VA = "0x13CEE6C")]
			get
			{
				return default(UVMode);
			}
			[Token(Token = "0x6000917")]
			[Address(RVA = "0x13CEE74", Offset = "0x13CEE74", VA = "0x13CEE74")]
			set
			{
			}
		}

		[Token(Token = "0x17000038")]
		public Vector2 uvScale
		{
			[Token(Token = "0x6000918")]
			[Address(RVA = "0x13CEE98", Offset = "0x13CEE98", VA = "0x13CEE98")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000919")]
			[Address(RVA = "0x13CEEA0", Offset = "0x13CEEA0", VA = "0x13CEEA0")]
			set
			{
			}
		}

		[Token(Token = "0x17000039")]
		public Vector2 uvOffset
		{
			[Token(Token = "0x600091A")]
			[Address(RVA = "0x13CEF60", Offset = "0x13CEF60", VA = "0x13CEF60")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x600091B")]
			[Address(RVA = "0x13CEF68", Offset = "0x13CEF68", VA = "0x13CEF68")]
			set
			{
			}
		}

		[Token(Token = "0x1700003A")]
		public float uvRotation
		{
			[Token(Token = "0x600091C")]
			[Address(RVA = "0x13CF028", Offset = "0x13CF028", VA = "0x13CF028")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600091D")]
			[Address(RVA = "0x13CF030", Offset = "0x13CF030", VA = "0x13CF030")]
			set
			{
			}
		}

		[Token(Token = "0x1700003B")]
		public bool baked
		{
			[Token(Token = "0x600091E")]
			[Address(RVA = "0x13CF054", Offset = "0x13CF054", VA = "0x13CF054")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600091F")]
		[Address(RVA = "0x13CF05C", Offset = "0x13CF05C", VA = "0x13CF05C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000920")]
		[Address(RVA = "0x13CF148", Offset = "0x13CF148", VA = "0x13CF148", Slot = "5")]
		protected override void Reset()
		{
		}

		[Token(Token = "0x6000921")]
		[Address(RVA = "0x13CF26C", Offset = "0x13CF26C", VA = "0x13CF26C")]
		public void CloneMesh()
		{
		}

		[Token(Token = "0x6000922")]
		[Address(RVA = "0x13CF37C", Offset = "0x13CF37C", VA = "0x13CF37C", Slot = "11")]
		public override void Rebuild(bool sampleComputer)
		{
		}

		[Token(Token = "0x6000923")]
		[Address(RVA = "0x13CF394", Offset = "0x13CF394", VA = "0x13CF394", Slot = "12")]
		public override void RebuildImmediate(bool sampleComputer)
		{
		}

		[Token(Token = "0x6000924")]
		[Address(RVA = "0x13CF3AC", Offset = "0x13CF3AC", VA = "0x13CF3AC", Slot = "6")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000925")]
		[Address(RVA = "0x13CF3B4", Offset = "0x13CF3B4", VA = "0x13CF3B4", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x6000926")]
		[Address(RVA = "0x13CF3BC", Offset = "0x13CF3BC", VA = "0x13CF3BC", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000927")]
		[Address(RVA = "0x13CF4DC", Offset = "0x13CF4DC", VA = "0x13CF4DC")]
		public void UpdateCollider()
		{
		}

		[Token(Token = "0x6000928")]
		[Address(RVA = "0x13CF5C0", Offset = "0x13CF5C0", VA = "0x13CF5C0", Slot = "19")]
		protected override void LateRun()
		{
		}

		[Token(Token = "0x6000929")]
		[Address(RVA = "0x13CF6B4", Offset = "0x13CF6B4", VA = "0x13CF6B4", Slot = "20")]
		protected override void Build()
		{
		}

		[Token(Token = "0x600092A")]
		[Address(RVA = "0x13CF710", Offset = "0x13CF710", VA = "0x13CF710", Slot = "21")]
		protected override void PostBuild()
		{
		}

		[Token(Token = "0x600092B")]
		[Address(RVA = "0x13CF744", Offset = "0x13CF744", VA = "0x13CF744", Slot = "29")]
		protected virtual void BuildMesh()
		{
		}

		[Token(Token = "0x600092C")]
		[Address(RVA = "0x13CF748", Offset = "0x13CF748", VA = "0x13CF748", Slot = "30")]
		protected virtual void WriteMesh()
		{
		}

		[Token(Token = "0x600092D")]
		[Address(RVA = "0x13CF8F4", Offset = "0x13CF8F4", VA = "0x13CF8F4", Slot = "31")]
		protected virtual void AllocateMesh(int vertexCount, int trisCount)
		{
		}

		[Token(Token = "0x600092E")]
		[Address(RVA = "0x13CFA1C", Offset = "0x13CFA1C", VA = "0x13CFA1C")]
		protected void ResetUVDistance()
		{
		}

		[Token(Token = "0x600092F")]
		[Address(RVA = "0x13CFA94", Offset = "0x13CFA94", VA = "0x13CFA94")]
		protected void AddUVDistance(int sampleIndex)
		{
		}

		[Token(Token = "0x6000930")]
		[Address(RVA = "0x13CFBC4", Offset = "0x13CFBC4", VA = "0x13CFBC4")]
		protected void CalculateUVs(double percent, float u)
		{
		}

		[Token(Token = "0x6000931")]
		[Address(RVA = "0x13CFD68", Offset = "0x13CFD68", VA = "0x13CFD68")]
		public MeshGenerator()
		{
		}
	}
	[Token(Token = "0x2000159")]
	public class Node : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20001D1")]
		public class Connection
		{
			[Token(Token = "0x4000A03")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool invertTangents;

			[Token(Token = "0x4000A04")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[SerializeField]
			private int _pointIndex;

			[Token(Token = "0x4000A05")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			private SplineComputer _computer;

			[Token(Token = "0x4000A06")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			[HideInInspector]
			internal SplinePoint point;

			[Token(Token = "0x170000D7")]
			public SplineComputer computer
			{
				[Token(Token = "0x6000D04")]
				[Address(RVA = "0x13D1998", Offset = "0x13D1998", VA = "0x13D1998")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D8")]
			public int pointIndex
			{
				[Token(Token = "0x6000D05")]
				[Address(RVA = "0x13D19A0", Offset = "0x13D19A0", VA = "0x13D19A0")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x170000D9")]
			internal bool isValid
			{
				[Token(Token = "0x6000D06")]
				[Address(RVA = "0x13D0EE8", Offset = "0x13D0EE8", VA = "0x13D0EE8")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000D07")]
			[Address(RVA = "0x13D15FC", Offset = "0x13D15FC", VA = "0x13D15FC")]
			internal Connection(SplineComputer comp, int index, SplinePoint inputPoint)
			{
			}
		}

		[Token(Token = "0x20001D2")]
		public enum Type
		{
			[Token(Token = "0x4000A08")]
			Smooth,
			[Token(Token = "0x4000A09")]
			Free
		}

		[Token(Token = "0x400076D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Type type;

		[Token(Token = "0x400076E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected Connection[] connections;

		[Token(Token = "0x400076F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _transformSize;

		[Token(Token = "0x4000770")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		[SerializeField]
		private bool _transformNormals;

		[Token(Token = "0x4000771")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		[SerializeField]
		private bool _transformTangents;

		[Token(Token = "0x4000772")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TS_Transform tsTransform;

		[Token(Token = "0x1700003C")]
		public bool transformNormals
		{
			[Token(Token = "0x6000933")]
			[Address(RVA = "0x13CFEE0", Offset = "0x13CFEE0", VA = "0x13CFEE0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000934")]
			[Address(RVA = "0x13CFEE8", Offset = "0x13CFEE8", VA = "0x13CFEE8")]
			set
			{
			}
		}

		[Token(Token = "0x1700003D")]
		public bool transformSize
		{
			[Token(Token = "0x6000935")]
			[Address(RVA = "0x13D0044", Offset = "0x13D0044", VA = "0x13D0044")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000936")]
			[Address(RVA = "0x13D004C", Offset = "0x13D004C", VA = "0x13D004C")]
			set
			{
			}
		}

		[Token(Token = "0x1700003E")]
		public bool transformTangents
		{
			[Token(Token = "0x6000937")]
			[Address(RVA = "0x13D0070", Offset = "0x13D0070", VA = "0x13D0070")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000938")]
			[Address(RVA = "0x13D0078", Offset = "0x13D0078", VA = "0x13D0078")]
			set
			{
			}
		}

		[Token(Token = "0x6000939")]
		[Address(RVA = "0x13D009C", Offset = "0x13D009C", VA = "0x13D009C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600093A")]
		[Address(RVA = "0x13D011C", Offset = "0x13D011C", VA = "0x13D011C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600093B")]
		[Address(RVA = "0x13D0178", Offset = "0x13D0178", VA = "0x13D0178")]
		private void Update()
		{
		}

		[Token(Token = "0x600093C")]
		[Address(RVA = "0x13D0120", Offset = "0x13D0120", VA = "0x13D0120")]
		private void Run()
		{
		}

		[Token(Token = "0x600093D")]
		[Address(RVA = "0x13D0518", Offset = "0x13D0518", VA = "0x13D0518")]
		public SplinePoint GetPoint(int connectionIndex, bool swapTangents)
		{
			return default(SplinePoint);
		}

		[Token(Token = "0x600093E")]
		[Address(RVA = "0x13D0788", Offset = "0x13D0788", VA = "0x13D0788")]
		public void SetPoint(int connectionIndex, SplinePoint worldPoint, bool swappedTangents)
		{
		}

		[Token(Token = "0x600093F")]
		[Address(RVA = "0x13D0DCC", Offset = "0x13D0DCC", VA = "0x13D0DCC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000940")]
		[Address(RVA = "0x13D0DD0", Offset = "0x13D0DD0", VA = "0x13D0DD0")]
		public void ClearConnections()
		{
		}

		[Token(Token = "0x6000941")]
		[Address(RVA = "0x13D017C", Offset = "0x13D017C", VA = "0x13D017C")]
		public void UpdateConnectedComputers([Optional] SplineComputer excludeComputer)
		{
		}

		[Token(Token = "0x6000942")]
		[Address(RVA = "0x13D1170", Offset = "0x13D1170", VA = "0x13D1170")]
		public void UpdatePoint(SplineComputer computer, int pointIndex, SplinePoint point, bool updatePosition = true)
		{
		}

		[Token(Token = "0x6000943")]
		[Address(RVA = "0x13CFF0C", Offset = "0x13CFF0C", VA = "0x13CFF0C")]
		private void UpdatePoints()
		{
		}

		[Token(Token = "0x6000944")]
		[Address(RVA = "0x13D12D0", Offset = "0x13D12D0", VA = "0x13D12D0")]
		protected void RemoveInvalidConnections()
		{
		}

		[Token(Token = "0x6000945")]
		[Address(RVA = "0x13D1360", Offset = "0x13D1360", VA = "0x13D1360", Slot = "4")]
		public virtual void AddConnection(SplineComputer computer, int pointIndex)
		{
		}

		[Token(Token = "0x6000946")]
		[Address(RVA = "0x13D0C48", Offset = "0x13D0C48", VA = "0x13D0C48")]
		protected SplinePoint PointToLocal(SplinePoint worldPoint)
		{
			return default(SplinePoint);
		}

		[Token(Token = "0x6000947")]
		[Address(RVA = "0x13D063C", Offset = "0x13D063C", VA = "0x13D063C")]
		protected SplinePoint PointToWorld(SplinePoint localPoint)
		{
			return default(SplinePoint);
		}

		[Token(Token = "0x6000948")]
		[Address(RVA = "0x13D164C", Offset = "0x13D164C", VA = "0x13D164C", Slot = "5")]
		public virtual void RemoveConnection(SplineComputer computer, int pointIndex)
		{
		}

		[Token(Token = "0x6000949")]
		[Address(RVA = "0x13D0F88", Offset = "0x13D0F88", VA = "0x13D0F88")]
		private void RemoveConnection(int index)
		{
		}

		[Token(Token = "0x600094A")]
		[Address(RVA = "0x13D17CC", Offset = "0x13D17CC", VA = "0x13D17CC", Slot = "6")]
		public virtual bool HasConnection(SplineComputer computer, int pointIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x600094B")]
		[Address(RVA = "0x13D1920", Offset = "0x13D1920", VA = "0x13D1920")]
		public Connection[] GetConnections()
		{
			return null;
		}

		[Token(Token = "0x600094C")]
		[Address(RVA = "0x13D1928", Offset = "0x13D1928", VA = "0x13D1928")]
		public Node()
		{
		}
	}
	[Token(Token = "0x200015A")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8314C0", Offset = "0x8314C0")]
	public class ObjectBender : SplineUser
	{
		[Token(Token = "0x20001D3")]
		public enum Axis
		{
			[Token(Token = "0x4000A0B")]
			X,
			[Token(Token = "0x4000A0C")]
			Y,
			[Token(Token = "0x4000A0D")]
			Z
		}

		[Token(Token = "0x20001D4")]
		public enum NormalMode
		{
			[Token(Token = "0x4000A0F")]
			Spline,
			[Token(Token = "0x4000A10")]
			Auto,
			[Token(Token = "0x4000A11")]
			Custom
		}

		[Token(Token = "0x20001D5")]
		public enum ForwardMode
		{
			[Token(Token = "0x4000A13")]
			Spline,
			[Token(Token = "0x4000A14")]
			Custom
		}

		[Serializable]
		[Token(Token = "0x20001D6")]
		public class BendProperty
		{
			[Token(Token = "0x4000A15")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool enabled;

			[Token(Token = "0x4000A16")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public TS_Transform transform;

			[Token(Token = "0x4000A17")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool applyRotation;

			[Token(Token = "0x4000A18")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
			public bool applyScale;

			[Token(Token = "0x4000A19")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
			public bool generateLightmapUVs;

			[Token(Token = "0x4000A1A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x23")]
			[SerializeField]
			[HideInInspector]
			private bool _bendMesh;

			[Token(Token = "0x4000A1B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[SerializeField]
			[HideInInspector]
			private bool _bendSpline;

			[Token(Token = "0x4000A1C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
			[SerializeField]
			[HideInInspector]
			private bool _bendCollider;

			[Token(Token = "0x4000A1D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float colliderUpdateDue;

			[Token(Token = "0x4000A1E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float colliderUpdateRate;

			[Token(Token = "0x4000A1F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private bool updateCollider;

			[Token(Token = "0x4000A20")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public Vector3 originalPosition;

			[Token(Token = "0x4000A21")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Vector3 originalScale;

			[Token(Token = "0x4000A22")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public Quaternion originalRotation;

			[Token(Token = "0x4000A23")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Quaternion parentRotation;

			[Token(Token = "0x4000A24")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Vector3 positionPercent;

			[Token(Token = "0x4000A25")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public Vector3[] vertexPercents;

			[Token(Token = "0x4000A26")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			public Vector3[] normals;

			[Token(Token = "0x4000A27")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			public Vector3[] colliderVertexPercents;

			[Token(Token = "0x4000A28")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public Vector3[] colliderNormals;

			[Token(Token = "0x4000A29")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[SerializeField]
			[HideInInspector]
			private Mesh originalMesh;

			[Token(Token = "0x4000A2A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[SerializeField]
			[HideInInspector]
			private Mesh originalColliderMesh;

			[Token(Token = "0x4000A2B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private Spline _originalSpline;

			[Token(Token = "0x4000A2C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			[SerializeField]
			[HideInInspector]
			private Mesh destinationMesh;

			[Token(Token = "0x4000A2D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			[SerializeField]
			[HideInInspector]
			private Mesh destinationColliderMesh;

			[Token(Token = "0x4000A2E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			public Spline destinationSpline;

			[Token(Token = "0x4000A2F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			public TS_Mesh _editMesh;

			[Token(Token = "0x4000A30")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			public TS_Mesh _editColliderMesh;

			[Token(Token = "0x4000A31")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			public MeshFilter filter;

			[Token(Token = "0x4000A32")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			public MeshCollider collider;

			[Token(Token = "0x4000A33")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			public SplineComputer splineComputer;

			[Token(Token = "0x4000A34")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			public Vector3[] splinePointPercents;

			[Token(Token = "0x4000A35")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			public Vector3[] primaryTangentPercents;

			[Token(Token = "0x4000A36")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
			public Vector3[] secondaryTangentPercents;

			[Token(Token = "0x4000A37")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			[SerializeField]
			[HideInInspector]
			private bool parent;

			[Token(Token = "0x170000DA")]
			public bool isValid
			{
				[Token(Token = "0x6000D08")]
				[Address(RVA = "0x13D592C", Offset = "0x13D592C", VA = "0x13D592C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000DB")]
			public bool bendMesh
			{
				[Token(Token = "0x6000D09")]
				[Address(RVA = "0x13D59B4", Offset = "0x13D59B4", VA = "0x13D59B4")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000D0A")]
				[Address(RVA = "0x13D2F68", Offset = "0x13D2F68", VA = "0x13D2F68")]
				set
				{
				}
			}

			[Token(Token = "0x170000DC")]
			public bool bendCollider
			{
				[Token(Token = "0x6000D0B")]
				[Address(RVA = "0x13D5A50", Offset = "0x13D5A50", VA = "0x13D5A50")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000D0C")]
				[Address(RVA = "0x13D3100", Offset = "0x13D3100", VA = "0x13D3100")]
				set
				{
				}
			}

			[Token(Token = "0x170000DD")]
			public bool bendSpline
			{
				[Token(Token = "0x6000D0D")]
				[Address(RVA = "0x13D5AEC", Offset = "0x13D5AEC", VA = "0x13D5AEC")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000D0E")]
				[Address(RVA = "0x13D5AF4", Offset = "0x13D5AF4", VA = "0x13D5AF4")]
				set
				{
				}
			}

			[Token(Token = "0x170000DE")]
			public TS_Mesh editMesh
			{
				[Token(Token = "0x6000D0F")]
				[Address(RVA = "0x13D3EC8", Offset = "0x13D3EC8", VA = "0x13D3EC8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000DF")]
			public TS_Mesh editColliderMesh
			{
				[Token(Token = "0x6000D10")]
				[Address(RVA = "0x13D3FC8", Offset = "0x13D3FC8", VA = "0x13D3FC8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E0")]
			public Spline originalSpline
			{
				[Token(Token = "0x6000D11")]
				[Address(RVA = "0x13D40F4", Offset = "0x13D40F4", VA = "0x13D40F4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000D12")]
			[Address(RVA = "0x13D293C", Offset = "0x13D293C", VA = "0x13D293C")]
			public BendProperty(Transform t, bool isParent = false)
			{
			}

			[Token(Token = "0x6000D13")]
			[Address(RVA = "0x13D4318", Offset = "0x13D4318", VA = "0x13D4318")]
			public void Revert()
			{
			}

			[Token(Token = "0x6000D14")]
			[Address(RVA = "0x13D59BC", Offset = "0x13D59BC", VA = "0x13D59BC")]
			private void RevertMesh()
			{
			}

			[Token(Token = "0x6000D15")]
			[Address(RVA = "0x13D5B00", Offset = "0x13D5B00", VA = "0x13D5B00")]
			private void RevertTransform()
			{
			}

			[Token(Token = "0x6000D16")]
			[Address(RVA = "0x13D5A58", Offset = "0x13D5A58", VA = "0x13D5A58")]
			private void RevertCollider()
			{
			}

			[Token(Token = "0x6000D17")]
			[Address(RVA = "0x13D4470", Offset = "0x13D4470", VA = "0x13D4470")]
			public void Apply(bool applyTransform)
			{
			}

			[Token(Token = "0x6000D18")]
			[Address(RVA = "0x13D45FC", Offset = "0x13D45FC", VA = "0x13D45FC")]
			public void Update()
			{
			}

			[Token(Token = "0x6000D19")]
			[Address(RVA = "0x13D5B84", Offset = "0x13D5B84", VA = "0x13D5B84")]
			private void ApplyMesh()
			{
			}

			[Token(Token = "0x6000D1A")]
			[Address(RVA = "0x13D5D34", Offset = "0x13D5D34", VA = "0x13D5D34")]
			private void ApplyCollider()
			{
			}

			[Token(Token = "0x6000D1B")]
			[Address(RVA = "0x13D5D04", Offset = "0x13D5D04", VA = "0x13D5D04")]
			private void ApplySpline()
			{
			}
		}

		[Token(Token = "0x4000773")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[HideInInspector]
		private bool _bend;

		[Token(Token = "0x4000774")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[HideInInspector]
		public BendProperty[] bendProperties;

		[Token(Token = "0x4000775")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[HideInInspector]
		private TS_Bounds bounds;

		[Token(Token = "0x4000776")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[HideInInspector]
		private Axis _axis;

		[Token(Token = "0x4000777")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[SerializeField]
		[HideInInspector]
		private NormalMode _normalMode;

		[Token(Token = "0x4000778")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[HideInInspector]
		private ForwardMode _forwardMode;

		[Token(Token = "0x4000779")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[SerializeField]
		[HideInInspector]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x832FCC", Offset = "0x832FCC")]
		private Vector3 _customNormal;

		[Token(Token = "0x400077A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[HideInInspector]
		private Vector3 _customForward;

		[Token(Token = "0x400077B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private SplineResult bendResult;

		[Token(Token = "0x400077C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Matrix4x4 normalMatrix;

		[Token(Token = "0x400077D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Quaternion bendRotation;

		[Token(Token = "0x1700003F")]
		public bool bend
		{
			[Token(Token = "0x600094D")]
			[Address(RVA = "0x13D19A8", Offset = "0x13D19A8", VA = "0x13D19A8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600094E")]
			[Address(RVA = "0x13D19B0", Offset = "0x13D19B0", VA = "0x13D19B0")]
			set
			{
			}
		}

		[Token(Token = "0x17000040")]
		public Axis axis
		{
			[Token(Token = "0x600094F")]
			[Address(RVA = "0x13D1C40", Offset = "0x13D1C40", VA = "0x13D1C40")]
			get
			{
				return default(Axis);
			}
			[Token(Token = "0x6000950")]
			[Address(RVA = "0x13D1C48", Offset = "0x13D1C48", VA = "0x13D1C48")]
			set
			{
			}
		}

		[Token(Token = "0x17000041")]
		public NormalMode upMode
		{
			[Token(Token = "0x6000951")]
			[Address(RVA = "0x13D1D18", Offset = "0x13D1D18", VA = "0x13D1D18")]
			get
			{
				return default(NormalMode);
			}
			[Token(Token = "0x6000952")]
			[Address(RVA = "0x13D1D20", Offset = "0x13D1D20", VA = "0x13D1D20")]
			set
			{
			}
		}

		[Token(Token = "0x17000042")]
		public Vector3 customNormal
		{
			[Token(Token = "0x6000953")]
			[Address(RVA = "0x13D1DE8", Offset = "0x13D1DE8", VA = "0x13D1DE8")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000954")]
			[Address(RVA = "0x13D1DF4", Offset = "0x13D1DF4", VA = "0x13D1DF4")]
			set
			{
			}
		}

		[Token(Token = "0x17000043")]
		public ForwardMode forwardMode
		{
			[Token(Token = "0x6000955")]
			[Address(RVA = "0x13D1F24", Offset = "0x13D1F24", VA = "0x13D1F24")]
			get
			{
				return default(ForwardMode);
			}
			[Token(Token = "0x6000956")]
			[Address(RVA = "0x13D1F2C", Offset = "0x13D1F2C", VA = "0x13D1F2C")]
			set
			{
			}
		}

		[Token(Token = "0x17000044")]
		public Vector3 customForward
		{
			[Token(Token = "0x6000957")]
			[Address(RVA = "0x13D1FF4", Offset = "0x13D1FF4", VA = "0x13D1FF4")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000958")]
			[Address(RVA = "0x13D2000", Offset = "0x13D2000", VA = "0x13D2000")]
			set
			{
			}
		}

		[Token(Token = "0x6000959")]
		[Address(RVA = "0x13D2130", Offset = "0x13D2130", VA = "0x13D2130")]
		private void GetTransformsRecursively(Transform current, ref List<Transform> transformList)
		{
		}

		[Token(Token = "0x600095A")]
		[Address(RVA = "0x13D23A8", Offset = "0x13D23A8", VA = "0x13D23A8")]
		private void GetObjects()
		{
		}

		[Token(Token = "0x600095B")]
		[Address(RVA = "0x13D2874", Offset = "0x13D2874", VA = "0x13D2874")]
		public TS_Bounds GetBounds()
		{
			return null;
		}

		[Token(Token = "0x600095C")]
		[Address(RVA = "0x13D24CC", Offset = "0x13D24CC", VA = "0x13D24CC")]
		private void CreateProperty(ref BendProperty property, Transform t)
		{
		}

		[Token(Token = "0x600095D")]
		[Address(RVA = "0x13D325C", Offset = "0x13D325C", VA = "0x13D325C")]
		private void CalculateBounds()
		{
		}

		[Token(Token = "0x600095E")]
		[Address(RVA = "0x13D3410", Offset = "0x13D3410", VA = "0x13D3410")]
		private void CalculatePropertyBounds(ref BendProperty property)
		{
		}

		[Token(Token = "0x600095F")]
		[Address(RVA = "0x13D39D8", Offset = "0x13D39D8", VA = "0x13D39D8")]
		public void CalculatePercents(BendProperty property)
		{
		}

		[Token(Token = "0x6000960")]
		[Address(RVA = "0x13D1BD8", Offset = "0x13D1BD8", VA = "0x13D1BD8")]
		private void Revert()
		{
		}

		[Token(Token = "0x6000961")]
		[Address(RVA = "0x13D1A20", Offset = "0x13D1A20", VA = "0x13D1A20")]
		public void UpdateReferences()
		{
		}

		[Token(Token = "0x6000962")]
		[Address(RVA = "0x13D4648", Offset = "0x13D4648", VA = "0x13D4648")]
		private void GetBendResult(Vector3 percentage)
		{
		}

		[Token(Token = "0x6000963")]
		[Address(RVA = "0x13D4220", Offset = "0x13D4220", VA = "0x13D4220")]
		private Vector3 GetPercentage(Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000964")]
		[Address(RVA = "0x13D4D80", Offset = "0x13D4D80", VA = "0x13D4D80", Slot = "20")]
		protected override void Build()
		{
		}

		[Token(Token = "0x6000965")]
		[Address(RVA = "0x13D43E0", Offset = "0x13D43E0", VA = "0x13D43E0")]
		private void Bend()
		{
		}

		[Token(Token = "0x6000966")]
		[Address(RVA = "0x13D4DBC", Offset = "0x13D4DBC", VA = "0x13D4DBC")]
		public void BendObject(BendProperty p)
		{
		}

		[Token(Token = "0x6000967")]
		[Address(RVA = "0x13D546C", Offset = "0x13D546C", VA = "0x13D546C")]
		private void BendMesh(Vector3[] vertexPercents, Vector3[] originalNormals, TS_Mesh mesh, Matrix4x4 worldToLocalMatrix)
		{
		}

		[Token(Token = "0x6000968")]
		[Address(RVA = "0x13D5664", Offset = "0x13D5664", VA = "0x13D5664", Slot = "21")]
		protected override void PostBuild()
		{
		}

		[Token(Token = "0x6000969")]
		[Address(RVA = "0x13D57B8", Offset = "0x13D57B8", VA = "0x13D57B8", Slot = "19")]
		protected override void LateRun()
		{
		}

		[Token(Token = "0x600096A")]
		[Address(RVA = "0x13D5828", Offset = "0x13D5828", VA = "0x13D5828")]
		public ObjectBender()
		{
		}
	}
	[Token(Token = "0x200015B")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8314F8", Offset = "0x8314F8")]
	public class ObjectController : SplineUser
	{
		[Serializable]
		[Token(Token = "0x20001D7")]
		internal class ObjectControl
		{
			[Token(Token = "0x4000A38")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public GameObject gameObject;

			[Token(Token = "0x4000A39")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 position;

			[Token(Token = "0x4000A3A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Quaternion rotation;

			[Token(Token = "0x4000A3B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public Vector3 scale;

			[Token(Token = "0x4000A3C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public bool active;

			[Token(Token = "0x4000A3D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public Vector3 baseScale;

			[Token(Token = "0x170000E1")]
			public bool isNull
			{
				[Token(Token = "0x6000D1C")]
				[Address(RVA = "0x13D8A80", Offset = "0x13D8A80", VA = "0x13D8A80")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000E2")]
			public Transform transform
			{
				[Token(Token = "0x6000D1D")]
				[Address(RVA = "0x13D6E60", Offset = "0x13D6E60", VA = "0x13D6E60")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000D1E")]
			[Address(RVA = "0x13D7580", Offset = "0x13D7580", VA = "0x13D7580")]
			public ObjectControl(GameObject input)
			{
			}

			[Token(Token = "0x6000D1F")]
			[Address(RVA = "0x13D6EF8", Offset = "0x13D6EF8", VA = "0x13D6EF8")]
			public void Destroy()
			{
			}

			[Token(Token = "0x6000D20")]
			[Address(RVA = "0x13D6FAC", Offset = "0x13D6FAC", VA = "0x13D6FAC")]
			public void DestroyImmediate()
			{
			}

			[Token(Token = "0x6000D21")]
			[Address(RVA = "0x13D8650", Offset = "0x13D8650", VA = "0x13D8650")]
			public void Apply()
			{
			}
		}

		[Token(Token = "0x20001D8")]
		public enum ObjectMethod
		{
			[Token(Token = "0x4000A3F")]
			Instantiate,
			[Token(Token = "0x4000A40")]
			GetChildren
		}

		[Token(Token = "0x20001D9")]
		public enum Positioning
		{
			[Token(Token = "0x4000A42")]
			Stretch,
			[Token(Token = "0x4000A43")]
			Clip
		}

		[Token(Token = "0x20001DA")]
		public enum Iteration
		{
			[Token(Token = "0x4000A45")]
			Ordered,
			[Token(Token = "0x4000A46")]
			Random
		}

		[Token(Token = "0x20001DB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x831C94", Offset = "0x831C94")]
		private sealed class <InstantiateAllWithDelay>d__97 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000A47")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000A48")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000A49")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ObjectController <>4__this;

			[Token(Token = "0x4000A4A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int <i>5__2;

			[Token(Token = "0x170000E3")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000D25")]
				[Address(RVA = "0x13D8A10", Offset = "0x13D8A10", VA = "0x13D8A10", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E4")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000D27")]
				[Address(RVA = "0x13D8A78", Offset = "0x13D8A78", VA = "0x13D8A78", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000D22")]
			[Address(RVA = "0x13D7844", Offset = "0x13D7844", VA = "0x13D7844")]
			[DebuggerHidden]
			public <InstantiateAllWithDelay>d__97(int <>1__state)
			{
			}

			[Token(Token = "0x6000D23")]
			[Address(RVA = "0x13D88C8", Offset = "0x13D88C8", VA = "0x13D88C8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000D24")]
			[Address(RVA = "0x13D88CC", Offset = "0x13D88CC", VA = "0x13D88CC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000D26")]
			[Address(RVA = "0x13D8A18", Offset = "0x13D8A18", VA = "0x13D8A18", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400077E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[HideInInspector]
		public GameObject[] objects;

		[Token(Token = "0x400077F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[HideInInspector]
		private float _positionOffset;

		[Token(Token = "0x4000780")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[SerializeField]
		[HideInInspector]
		private int _spawnCount;

		[Token(Token = "0x4000781")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[HideInInspector]
		private Positioning _objectPositioning;

		[Token(Token = "0x4000782")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		[SerializeField]
		[HideInInspector]
		private Iteration _iteration;

		[Token(Token = "0x4000783")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[HideInInspector]
		private int _randomSeed;

		[Token(Token = "0x4000784")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[SerializeField]
		[HideInInspector]
		private Vector2 _randomSize;

		[Token(Token = "0x4000785")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[SerializeField]
		[HideInInspector]
		private Vector2 _offset;

		[Token(Token = "0x4000786")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		[SerializeField]
		[HideInInspector]
		private Vector3 _minRotationOffset;

		[Token(Token = "0x4000787")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[SerializeField]
		[HideInInspector]
		private Vector3 _maxRotationOffset;

		[Token(Token = "0x4000788")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		[SerializeField]
		[HideInInspector]
		private Vector3 _minScaleMultiplier;

		[Token(Token = "0x4000789")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[SerializeField]
		[HideInInspector]
		private Vector3 _maxScaleMultiplier;

		[Token(Token = "0x400078A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		[SerializeField]
		[HideInInspector]
		private bool _randomizeOffset;

		[Token(Token = "0x400078B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x105")]
		[SerializeField]
		[HideInInspector]
		private bool _useRandomOffsetRotation;

		[Token(Token = "0x400078C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x106")]
		[SerializeField]
		[HideInInspector]
		private bool _shellOffset;

		[Token(Token = "0x400078D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x107")]
		[SerializeField]
		[HideInInspector]
		private bool _randomOffset;

		[Token(Token = "0x400078E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[SerializeField]
		[HideInInspector]
		private bool _applyRotation;

		[Token(Token = "0x400078F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x109")]
		[SerializeField]
		[HideInInspector]
		private bool _applyScale;

		[Token(Token = "0x4000790")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		[SerializeField]
		[HideInInspector]
		private ObjectMethod _objectMethod;

		[Token(Token = "0x4000791")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[HideInInspector]
		public bool delayedSpawn;

		[Token(Token = "0x4000792")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		[HideInInspector]
		public float spawnDelay;

		[Token(Token = "0x4000793")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[SerializeField]
		[HideInInspector]
		private int lastChildCount;

		[Token(Token = "0x4000794")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[SerializeField]
		[HideInInspector]
		private ObjectControl[] spawned;

		[Token(Token = "0x4000795")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private SplineResult evaluateResult;

		[Token(Token = "0x4000796")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private System.Random randomizer;

		[Token(Token = "0x4000797")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private System.Random randomizer2;

		[Token(Token = "0x4000798")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private System.Random rotationRandomizer;

		[Token(Token = "0x4000799")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private System.Random scaleRandomizer;

		[Token(Token = "0x17000045")]
		public ObjectMethod objectMethod
		{
			[Token(Token = "0x600096B")]
			[Address(RVA = "0x13D5F08", Offset = "0x13D5F08", VA = "0x13D5F08")]
			get
			{
				return default(ObjectMethod);
			}
			[Token(Token = "0x600096C")]
			[Address(RVA = "0x13D5F10", Offset = "0x13D5F10", VA = "0x13D5F10")]
			set
			{
			}
		}

		[Token(Token = "0x17000046")]
		public int spawnCount
		{
			[Token(Token = "0x600096D")]
			[Address(RVA = "0x13D5FE4", Offset = "0x13D5FE4", VA = "0x13D5FE4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600096E")]
			[Address(RVA = "0x13D5FEC", Offset = "0x13D5FEC", VA = "0x13D5FEC")]
			set
			{
			}
		}

		[Token(Token = "0x17000047")]
		public Positioning objectPositioning
		{
			[Token(Token = "0x600096F")]
			[Address(RVA = "0x13D6258", Offset = "0x13D6258", VA = "0x13D6258")]
			get
			{
				return default(Positioning);
			}
			[Token(Token = "0x6000970")]
			[Address(RVA = "0x13D6260", Offset = "0x13D6260", VA = "0x13D6260")]
			set
			{
			}
		}

		[Token(Token = "0x17000048")]
		public Iteration iteration
		{
			[Token(Token = "0x6000971")]
			[Address(RVA = "0x13D6284", Offset = "0x13D6284", VA = "0x13D6284")]
			get
			{
				return default(Iteration);
			}
			[Token(Token = "0x6000972")]
			[Address(RVA = "0x13D628C", Offset = "0x13D628C", VA = "0x13D628C")]
			set
			{
			}
		}

		[Token(Token = "0x17000049")]
		public int randomSeed
		{
			[Token(Token = "0x6000973")]
			[Address(RVA = "0x13D62B0", Offset = "0x13D62B0", VA = "0x13D62B0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000974")]
			[Address(RVA = "0x13D62B8", Offset = "0x13D62B8", VA = "0x13D62B8")]
			set
			{
			}
		}

		[Token(Token = "0x1700004A")]
		public Vector2 offset
		{
			[Token(Token = "0x6000975")]
			[Address(RVA = "0x13D62DC", Offset = "0x13D62DC", VA = "0x13D62DC")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000976")]
			[Address(RVA = "0x13D62E4", Offset = "0x13D62E4", VA = "0x13D62E4")]
			set
			{
			}
		}

		[Token(Token = "0x1700004B")]
		public Vector3 minRotationOffset
		{
			[Token(Token = "0x6000977")]
			[Address(RVA = "0x13D63A4", Offset = "0x13D63A4", VA = "0x13D63A4")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000978")]
			[Address(RVA = "0x13D63B0", Offset = "0x13D63B0", VA = "0x13D63B0")]
			set
			{
			}
		}

		[Token(Token = "0x1700004C")]
		public Vector3 maxRotationOffset
		{
			[Token(Token = "0x6000979")]
			[Address(RVA = "0x13D6490", Offset = "0x13D6490", VA = "0x13D6490")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600097A")]
			[Address(RVA = "0x13D649C", Offset = "0x13D649C", VA = "0x13D649C")]
			set
			{
			}
		}

		[Token(Token = "0x1700004D")]
		public Vector3 rotationOffset
		{
			[Token(Token = "0x600097B")]
			[Address(RVA = "0x13D657C", Offset = "0x13D657C", VA = "0x13D657C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600097C")]
			[Address(RVA = "0x13D6628", Offset = "0x13D6628", VA = "0x13D6628")]
			set
			{
			}
		}

		[Token(Token = "0x1700004E")]
		public Vector3 minScaleMultiplier
		{
			[Token(Token = "0x600097D")]
			[Address(RVA = "0x13D6750", Offset = "0x13D6750", VA = "0x13D6750")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600097E")]
			[Address(RVA = "0x13D675C", Offset = "0x13D675C", VA = "0x13D675C")]
			set
			{
			}
		}

		[Token(Token = "0x1700004F")]
		public Vector3 maxScaleMultiplier
		{
			[Token(Token = "0x600097F")]
			[Address(RVA = "0x13D683C", Offset = "0x13D683C", VA = "0x13D683C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000980")]
			[Address(RVA = "0x13D6848", Offset = "0x13D6848", VA = "0x13D6848")]
			set
			{
			}
		}

		[Token(Token = "0x17000050")]
		public Vector3 scaleMultiplier
		{
			[Token(Token = "0x6000981")]
			[Address(RVA = "0x13D6928", Offset = "0x13D6928", VA = "0x13D6928")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000982")]
			[Address(RVA = "0x13D69D4", Offset = "0x13D69D4", VA = "0x13D69D4")]
			set
			{
			}
		}

		[Token(Token = "0x17000051")]
		public bool randomizeOffset
		{
			[Token(Token = "0x6000983")]
			[Address(RVA = "0x13D6AFC", Offset = "0x13D6AFC", VA = "0x13D6AFC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000984")]
			[Address(RVA = "0x13D6B04", Offset = "0x13D6B04", VA = "0x13D6B04")]
			set
			{
			}
		}

		[Token(Token = "0x17000052")]
		public bool useRandomOffsetRotation
		{
			[Token(Token = "0x6000985")]
			[Address(RVA = "0x13D6B34", Offset = "0x13D6B34", VA = "0x13D6B34")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000986")]
			[Address(RVA = "0x13D6B3C", Offset = "0x13D6B3C", VA = "0x13D6B3C")]
			set
			{
			}
		}

		[Token(Token = "0x17000053")]
		public bool shellOffset
		{
			[Token(Token = "0x6000987")]
			[Address(RVA = "0x13D6B6C", Offset = "0x13D6B6C", VA = "0x13D6B6C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000988")]
			[Address(RVA = "0x13D6B74", Offset = "0x13D6B74", VA = "0x13D6B74")]
			set
			{
			}
		}

		[Token(Token = "0x17000054")]
		public bool randomOffset
		{
			[Token(Token = "0x6000989")]
			[Address(RVA = "0x13D6BA4", Offset = "0x13D6BA4", VA = "0x13D6BA4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600098A")]
			[Address(RVA = "0x13D6BAC", Offset = "0x13D6BAC", VA = "0x13D6BAC")]
			set
			{
			}
		}

		[Token(Token = "0x17000055")]
		public bool applyRotation
		{
			[Token(Token = "0x600098B")]
			[Address(RVA = "0x13D6BDC", Offset = "0x13D6BDC", VA = "0x13D6BDC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600098C")]
			[Address(RVA = "0x13D6BE4", Offset = "0x13D6BE4", VA = "0x13D6BE4")]
			set
			{
			}
		}

		[Token(Token = "0x17000056")]
		public bool applyScale
		{
			[Token(Token = "0x600098D")]
			[Address(RVA = "0x13D6C14", Offset = "0x13D6C14", VA = "0x13D6C14")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600098E")]
			[Address(RVA = "0x13D6C1C", Offset = "0x13D6C1C", VA = "0x13D6C1C")]
			set
			{
			}
		}

		[Token(Token = "0x17000057")]
		public Vector2 randomSize
		{
			[Token(Token = "0x600098F")]
			[Address(RVA = "0x13D6C4C", Offset = "0x13D6C4C", VA = "0x13D6C4C")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000990")]
			[Address(RVA = "0x13D6C54", Offset = "0x13D6C54", VA = "0x13D6C54")]
			set
			{
			}
		}

		[Token(Token = "0x17000058")]
		public float positionOffset
		{
			[Token(Token = "0x6000991")]
			[Address(RVA = "0x13D6D14", Offset = "0x13D6D14", VA = "0x13D6D14")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000992")]
			[Address(RVA = "0x13D6D1C", Offset = "0x13D6D1C", VA = "0x13D6D1C")]
			set
			{
			}
		}

		[Token(Token = "0x6000993")]
		[Address(RVA = "0x13D6D40", Offset = "0x13D6D40", VA = "0x13D6D40")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000994")]
		[Address(RVA = "0x13D6020", Offset = "0x13D6020", VA = "0x13D6020")]
		private void Remove()
		{
		}

		[Token(Token = "0x6000995")]
		[Address(RVA = "0x13D7060", Offset = "0x13D7060", VA = "0x13D7060")]
		public void GetAll()
		{
		}

		[Token(Token = "0x6000996")]
		[Address(RVA = "0x13D5F30", Offset = "0x13D5F30", VA = "0x13D5F30")]
		public void Spawn()
		{
		}

		[Token(Token = "0x6000997")]
		[Address(RVA = "0x13D77C8", Offset = "0x13D77C8", VA = "0x13D77C8", Slot = "19")]
		protected override void LateRun()
		{
		}

		[Token(Token = "0x6000998")]
		[Address(RVA = "0x13D768C", Offset = "0x13D768C", VA = "0x13D768C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x835F30", Offset = "0x835F30")]
		private IEnumerator InstantiateAllWithDelay()
		{
			return null;
		}

		[Token(Token = "0x6000999")]
		[Address(RVA = "0x13D76FC", Offset = "0x13D76FC", VA = "0x13D76FC")]
		private void InstantiateAll()
		{
		}

		[Token(Token = "0x600099A")]
		[Address(RVA = "0x13D7870", Offset = "0x13D7870", VA = "0x13D7870")]
		private void InstantiateSingle()
		{
		}

		[Token(Token = "0x600099B")]
		[Address(RVA = "0x13D7B54", Offset = "0x13D7B54", VA = "0x13D7B54", Slot = "20")]
		protected override void Build()
		{
		}

		[Token(Token = "0x600099C")]
		[Address(RVA = "0x13D85E0", Offset = "0x13D85E0", VA = "0x13D85E0", Slot = "21")]
		protected override void PostBuild()
		{
		}

		[Token(Token = "0x600099D")]
		[Address(RVA = "0x13D873C", Offset = "0x13D873C", VA = "0x13D873C", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x600099E")]
		[Address(RVA = "0x13D8778", Offset = "0x13D8778", VA = "0x13D8778")]
		public ObjectController()
		{
		}
	}
	[Token(Token = "0x200015C")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x831530", Offset = "0x831530")]
	public class ParticleController : SplineUser
	{
		[Token(Token = "0x20001DC")]
		public enum EmitPoint
		{
			[Token(Token = "0x4000A4C")]
			Beginning,
			[Token(Token = "0x4000A4D")]
			Ending,
			[Token(Token = "0x4000A4E")]
			Random,
			[Token(Token = "0x4000A4F")]
			Ordered
		}

		[Token(Token = "0x20001DD")]
		public enum MotionType
		{
			[Token(Token = "0x4000A51")]
			None,
			[Token(Token = "0x4000A52")]
			UseParticleSystem,
			[Token(Token = "0x4000A53")]
			FollowForward,
			[Token(Token = "0x4000A54")]
			FollowBackward,
			[Token(Token = "0x4000A55")]
			ByNormal,
			[Token(Token = "0x4000A56")]
			ByNormalRandomized
		}

		[Token(Token = "0x20001DE")]
		public enum Wrap
		{
			[Token(Token = "0x4000A58")]
			Default,
			[Token(Token = "0x4000A59")]
			Loop
		}

		[Token(Token = "0x20001DF")]
		public class Particle
		{
			[Token(Token = "0x4000A5A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal Vector2 startOffset;

			[Token(Token = "0x4000A5B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal Vector2 endOffset;

			[Token(Token = "0x4000A5C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal float cycleSpeed;

			[Token(Token = "0x4000A5D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			internal float startLifetime;

			[Token(Token = "0x4000A5E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal Color startColor;

			[Token(Token = "0x4000A5F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal float remainingLifetime;

			[Token(Token = "0x4000A60")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal double startPercent;

			[Token(Token = "0x6000D28")]
			[Address(RVA = "0x13DA558", Offset = "0x13DA558", VA = "0x13DA558")]
			internal double GetSplinePercent(Wrap wrap)
			{
				return default(double);
			}

			[Token(Token = "0x6000D29")]
			[Address(RVA = "0x13DA664", Offset = "0x13DA664", VA = "0x13DA664")]
			public Particle()
			{
			}
		}

		[Token(Token = "0x400079A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		public ParticleSystem _particleSystem;

		[Token(Token = "0x400079B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[HideInInspector]
		public bool volumetric;

		[Token(Token = "0x400079C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB1")]
		[HideInInspector]
		public bool emitFromShell;

		[Token(Token = "0x400079D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[HideInInspector]
		public Vector2 scale;

		[Token(Token = "0x400079E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		[HideInInspector]
		public EmitPoint emitPoint;

		[Token(Token = "0x400079F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[HideInInspector]
		public MotionType motionType;

		[Token(Token = "0x40007A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[HideInInspector]
		public Wrap wrapMode;

		[Token(Token = "0x40007A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[HideInInspector]
		public float minCycles;

		[Token(Token = "0x40007A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[HideInInspector]
		public float maxCycles;

		[Token(Token = "0x40007A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private ParticleSystem.Particle[] particles;

		[Token(Token = "0x40007A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Particle[] controllers;

		[Token(Token = "0x40007A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private float[] lifetimes;

		[Token(Token = "0x40007A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private int particleCount;

		[Token(Token = "0x40007A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private int birthIndex;

		[Token(Token = "0x40007A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private SplineResult evaluateResult;

		[Token(Token = "0x600099F")]
		[Address(RVA = "0x13D8AF0", Offset = "0x13D8AF0", VA = "0x13D8AF0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60009A0")]
		[Address(RVA = "0x13D8B1C", Offset = "0x13D8B1C", VA = "0x13D8B1C", Slot = "19")]
		protected override void LateRun()
		{
		}

		[Token(Token = "0x60009A1")]
		[Address(RVA = "0x13DA4BC", Offset = "0x13DA4BC", VA = "0x13DA4BC", Slot = "5")]
		protected override void Reset()
		{
		}

		[Token(Token = "0x60009A2")]
		[Address(RVA = "0x13D9FFC", Offset = "0x13D9FFC", VA = "0x13D9FFC")]
		private void HandleParticle(int index)
		{
		}

		[Token(Token = "0x60009A3")]
		[Address(RVA = "0x13DA660", Offset = "0x13DA660", VA = "0x13DA660")]
		private void OnParticleDie(int index)
		{
		}

		[Token(Token = "0x60009A4")]
		[Address(RVA = "0x13D908C", Offset = "0x13D908C", VA = "0x13D908C")]
		private void OnParticleBorn(int index)
		{
		}

		[Token(Token = "0x60009A5")]
		[Address(RVA = "0x13DA6F4", Offset = "0x13DA6F4", VA = "0x13DA6F4")]
		public ParticleController()
		{
		}
	}
	[Token(Token = "0x200015D")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x83157C", Offset = "0x83157C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x83157C", Offset = "0x83157C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x83157C", Offset = "0x83157C")]
	public class PathGenerator : MeshGenerator
	{
		[Token(Token = "0x40007A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		[SerializeField]
		[HideInInspector]
		private int _slices;

		[Token(Token = "0x40007AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		[SerializeField]
		[HideInInspector]
		private bool _useShapeCurve;

		[Token(Token = "0x40007AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		[SerializeField]
		[HideInInspector]
		private AnimationCurve _shape;

		[Token(Token = "0x40007AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		[SerializeField]
		[HideInInspector]
		private AnimationCurve _lastShape;

		[Token(Token = "0x40007AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		[SerializeField]
		[HideInInspector]
		private float _shapeExposure;

		[Token(Token = "0x17000059")]
		public int slices
		{
			[Token(Token = "0x60009A6")]
			[Address(RVA = "0x13DA7E4", Offset = "0x13DA7E4", VA = "0x13DA7E4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60009A7")]
			[Address(RVA = "0x13DA7EC", Offset = "0x13DA7EC", VA = "0x13DA7EC")]
			set
			{
			}
		}

		[Token(Token = "0x1700005A")]
		public bool useShapeCurve
		{
			[Token(Token = "0x60009A8")]
			[Address(RVA = "0x13DA818", Offset = "0x13DA818", VA = "0x13DA818")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60009A9")]
			[Address(RVA = "0x13DA820", Offset = "0x13DA820", VA = "0x13DA820")]
			set
			{
			}
		}

		[Token(Token = "0x1700005B")]
		public float shapeExposure
		{
			[Token(Token = "0x60009AA")]
			[Address(RVA = "0x13DA960", Offset = "0x13DA960", VA = "0x13DA960")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60009AB")]
			[Address(RVA = "0x13DA968", Offset = "0x13DA968", VA = "0x13DA968")]
			set
			{
			}
		}

		[Token(Token = "0x1700005C")]
		public AnimationCurve shape
		{
			[Token(Token = "0x60009AC")]
			[Address(RVA = "0x13DAA2C", Offset = "0x13DAA2C", VA = "0x13DAA2C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009AD")]
			[Address(RVA = "0x13DAA34", Offset = "0x13DAA34", VA = "0x13DAA34")]
			set
			{
			}
		}

		[Token(Token = "0x60009AE")]
		[Address(RVA = "0x13DAD94", Offset = "0x13DAD94", VA = "0x13DAD94", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60009AF")]
		[Address(RVA = "0x13DADF8", Offset = "0x13DADF8", VA = "0x13DADF8", Slot = "5")]
		protected override void Reset()
		{
		}

		[Token(Token = "0x60009B0")]
		[Address(RVA = "0x13DADFC", Offset = "0x13DADFC", VA = "0x13DADFC", Slot = "29")]
		protected override void BuildMesh()
		{
		}

		[Token(Token = "0x60009B1")]
		[Address(RVA = "0x13DAEDC", Offset = "0x13DAEDC", VA = "0x13DAEDC")]
		private void GenerateVertices()
		{
		}

		[Token(Token = "0x60009B2")]
		[Address(RVA = "0x13DBE88", Offset = "0x13DBE88", VA = "0x13DBE88")]
		public PathGenerator()
		{
		}
	}
	[Token(Token = "0x200015E")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x83162C", Offset = "0x83162C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x83162C", Offset = "0x83162C")]
	public class PolygonColliderGenerator : SplineUser
	{
		[Token(Token = "0x20001E0")]
		public enum Type
		{
			[Token(Token = "0x4000A62")]
			Path,
			[Token(Token = "0x4000A63")]
			Shape
		}

		[Token(Token = "0x40007AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[HideInInspector]
		private Type _type;

		[Token(Token = "0x40007AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[SerializeField]
		[HideInInspector]
		private float _size;

		[Token(Token = "0x40007B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[HideInInspector]
		private float _offset;

		[Token(Token = "0x40007B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[HideInInspector]
		protected PolygonCollider2D polygonCollider;

		[Token(Token = "0x40007B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[HideInInspector]
		protected Vector2[] vertices;

		[Token(Token = "0x40007B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[HideInInspector]
		public float updateRate;

		[Token(Token = "0x40007B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		protected float lastUpdateTime;

		[Token(Token = "0x40007B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private bool updateCollider;

		[Token(Token = "0x1700005D")]
		public Type type
		{
			[Token(Token = "0x60009B3")]
			[Address(RVA = "0x13DBEFC", Offset = "0x13DBEFC", VA = "0x13DBEFC")]
			get
			{
				return default(Type);
			}
			[Token(Token = "0x60009B4")]
			[Address(RVA = "0x13DBF04", Offset = "0x13DBF04", VA = "0x13DBF04")]
			set
			{
			}
		}

		[Token(Token = "0x1700005E")]
		public float size
		{
			[Token(Token = "0x60009B5")]
			[Address(RVA = "0x13DBF28", Offset = "0x13DBF28", VA = "0x13DBF28")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60009B6")]
			[Address(RVA = "0x13DBF30", Offset = "0x13DBF30", VA = "0x13DBF30")]
			set
			{
			}
		}

		[Token(Token = "0x1700005F")]
		public float offset
		{
			[Token(Token = "0x60009B7")]
			[Address(RVA = "0x13DBF54", Offset = "0x13DBF54", VA = "0x13DBF54")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60009B8")]
			[Address(RVA = "0x13DBF5C", Offset = "0x13DBF5C", VA = "0x13DBF5C")]
			set
			{
			}
		}

		[Token(Token = "0x60009B9")]
		[Address(RVA = "0x13DBF80", Offset = "0x13DBF80", VA = "0x13DBF80", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60009BA")]
		[Address(RVA = "0x13DBFE4", Offset = "0x13DBFE4", VA = "0x13DBFE4", Slot = "5")]
		protected override void Reset()
		{
		}

		[Token(Token = "0x60009BB")]
		[Address(RVA = "0x13DBFEC", Offset = "0x13DBFEC", VA = "0x13DBFEC", Slot = "6")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x60009BC")]
		[Address(RVA = "0x13DBFF4", Offset = "0x13DBFF4", VA = "0x13DBFF4", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x60009BD")]
		[Address(RVA = "0x13DBFFC", Offset = "0x13DBFFC", VA = "0x13DBFFC", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60009BE")]
		[Address(RVA = "0x13DC004", Offset = "0x13DC004", VA = "0x13DC004", Slot = "19")]
		protected override void LateRun()
		{
		}

		[Token(Token = "0x60009BF")]
		[Address(RVA = "0x13DC0DC", Offset = "0x13DC0DC", VA = "0x13DC0DC", Slot = "20")]
		protected override void Build()
		{
		}

		[Token(Token = "0x60009C0")]
		[Address(RVA = "0x13DC824", Offset = "0x13DC824", VA = "0x13DC824", Slot = "21")]
		protected override void PostBuild()
		{
		}

		[Token(Token = "0x60009C1")]
		[Address(RVA = "0x13DC14C", Offset = "0x13DC14C", VA = "0x13DC14C")]
		private void GeneratePath()
		{
		}

		[Token(Token = "0x60009C2")]
		[Address(RVA = "0x13DC578", Offset = "0x13DC578", VA = "0x13DC578")]
		private void GenerateShape()
		{
		}

		[Token(Token = "0x60009C3")]
		[Address(RVA = "0x13DC9C8", Offset = "0x13DC9C8", VA = "0x13DC9C8")]
		public PolygonColliderGenerator()
		{
		}
	}
	[Token(Token = "0x200015F")]
	public delegate void EmptySplineHandler();
	[Token(Token = "0x2000160")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8316B4", Offset = "0x8316B4")]
	public class SplineComputer : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20001E1")]
		public class NodeLink
		{
			[Token(Token = "0x4000A64")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Node node;

			[Token(Token = "0x4000A65")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int pointIndex;

			[Token(Token = "0x6000D2A")]
			[Address(RVA = "0x13E9F54", Offset = "0x13E9F54", VA = "0x13E9F54")]
			public NodeLink()
			{
			}
		}

		[Token(Token = "0x20001E2")]
		public enum Space
		{
			[Token(Token = "0x4000A67")]
			World,
			[Token(Token = "0x4000A68")]
			Local
		}

		[Serializable]
		[Token(Token = "0x20001E3")]
		public class Morph
		{
			[Serializable]
			[Token(Token = "0x200022E")]
			internal class SplineMorphState
			{
				[Token(Token = "0x4000B9D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public SplinePoint[] points;

				[Token(Token = "0x4000B9E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public float percent;

				[Token(Token = "0x4000B9F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public string name;

				[Token(Token = "0x6000E4E")]
				[Address(RVA = "0x13EF314", Offset = "0x13EF314", VA = "0x13EF314")]
				public SplineMorphState()
				{
				}
			}

			[Token(Token = "0x4000A69")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[SerializeField]
			private SplineComputer computer;

			[Token(Token = "0x4000A6A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			private SplineMorphState[] morphStates;

			[Token(Token = "0x4000A6B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			internal bool initialized;

			[Token(Token = "0x6000D2B")]
			[Address(RVA = "0x13E8E78", Offset = "0x13E8E78", VA = "0x13E8E78")]
			public Morph(SplineComputer input)
			{
			}

			[Token(Token = "0x6000D2C")]
			[Address(RVA = "0x13EDB20", Offset = "0x13EDB20", VA = "0x13EDB20")]
			public void SetWeight(int index, float weight)
			{
			}

			[Token(Token = "0x6000D2D")]
			[Address(RVA = "0x13EEC88", Offset = "0x13EEC88", VA = "0x13EEC88")]
			public void SetWeight(string name, float weight)
			{
			}

			[Token(Token = "0x6000D2E")]
			[Address(RVA = "0x13EEE50", Offset = "0x13EEE50", VA = "0x13EEE50")]
			public void CaptureSnapshot(int index)
			{
			}

			[Token(Token = "0x6000D2F")]
			[Address(RVA = "0x13EEFC0", Offset = "0x13EEFC0", VA = "0x13EEFC0")]
			public void CaptureSnapshot(string name)
			{
			}

			[Token(Token = "0x6000D30")]
			[Address(RVA = "0x13EEFE8", Offset = "0x13EEFE8", VA = "0x13EEFE8")]
			public void Clear()
			{
			}

			[Token(Token = "0x6000D31")]
			[Address(RVA = "0x13EF040", Offset = "0x13EF040", VA = "0x13EF040")]
			public SplinePoint[] GetSnapshot(int index)
			{
				return null;
			}

			[Token(Token = "0x6000D32")]
			[Address(RVA = "0x13EF084", Offset = "0x13EF084", VA = "0x13EF084")]
			public SplinePoint[] GetSnapshot(string name)
			{
				return null;
			}

			[Token(Token = "0x6000D33")]
			[Address(RVA = "0x13EDF88", Offset = "0x13EDF88", VA = "0x13EDF88")]
			public float GetWeight(int index)
			{
				return default(float);
			}

			[Token(Token = "0x6000D34")]
			[Address(RVA = "0x13EF0D8", Offset = "0x13EF0D8", VA = "0x13EF0D8")]
			public float GetWeight(string name)
			{
				return default(float);
			}

			[Token(Token = "0x6000D35")]
			[Address(RVA = "0x13EF12C", Offset = "0x13EF12C", VA = "0x13EF12C")]
			public void AddChannel(string name)
			{
			}

			[Token(Token = "0x6000D36")]
			[Address(RVA = "0x13EF38C", Offset = "0x13EF38C", VA = "0x13EF38C")]
			public void RemoveChannel(string name)
			{
			}

			[Token(Token = "0x6000D37")]
			[Address(RVA = "0x13EF3B4", Offset = "0x13EF3B4", VA = "0x13EF3B4")]
			public void RemoveChannel(int index)
			{
			}

			[Token(Token = "0x6000D38")]
			[Address(RVA = "0x13EE62C", Offset = "0x13EE62C", VA = "0x13EE62C")]
			private void Update()
			{
			}

			[Token(Token = "0x6000D39")]
			[Address(RVA = "0x13EED54", Offset = "0x13EED54", VA = "0x13EED54")]
			private int GetChannelIndex(string name)
			{
				return default(int);
			}

			[Token(Token = "0x6000D3A")]
			[Address(RVA = "0x13E8F24", Offset = "0x13E8F24", VA = "0x13E8F24")]
			public int GetChannelCount()
			{
				return default(int);
			}

			[Token(Token = "0x6000D3B")]
			[Address(RVA = "0x13EDD30", Offset = "0x13EDD30", VA = "0x13EDD30")]
			public string[] GetChannelNames()
			{
				return null;
			}
		}

		[Token(Token = "0x40007B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		[SerializeField]
		private Spline spline;

		[Token(Token = "0x40007B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		[SerializeField]
		private Morph _morph;

		[Token(Token = "0x40007B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[HideInInspector]
		[SerializeField]
		private Space _space;

		[Token(Token = "0x40007B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[HideInInspector]
		[SerializeField]
		private SplineUser[] subscribers;

		[Token(Token = "0x40007BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[HideInInspector]
		[SerializeField]
		private NodeLink[] _nodeLinks;

		[Token(Token = "0x40007BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool rebuildPending;

		[Token(Token = "0x40007BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TS_Transform tsTransform;

		[Token(Token = "0x40007BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool updateRebuild;

		[Token(Token = "0x40007BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		private bool lateUpdateRebuild;

		[Token(Token = "0x40007BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private SplineUser.UpdateMethod method;

		[Token(Token = "0x17000060")]
		public Space space
		{
			[Token(Token = "0x60009C8")]
			[Address(RVA = "0x13E8C68", Offset = "0x13E8C68", VA = "0x13E8C68")]
			get
			{
				return default(Space);
			}
			[Token(Token = "0x60009C9")]
			[Address(RVA = "0x13E8C70", Offset = "0x13E8C70", VA = "0x13E8C70")]
			set
			{
			}
		}

		[Token(Token = "0x17000061")]
		public Spline.Type type
		{
			[Token(Token = "0x60009CA")]
			[Address(RVA = "0x13E8C98", Offset = "0x13E8C98", VA = "0x13E8C98")]
			get
			{
				return default(Spline.Type);
			}
			[Token(Token = "0x60009CB")]
			[Address(RVA = "0x13E8CB4", Offset = "0x13E8CB4", VA = "0x13E8CB4")]
			set
			{
			}
		}

		[Token(Token = "0x17000062")]
		public double precision
		{
			[Token(Token = "0x60009CC")]
			[Address(RVA = "0x13E8CE4", Offset = "0x13E8CE4", VA = "0x13E8CE4")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x60009CD")]
			[Address(RVA = "0x13E8D00", Offset = "0x13E8D00", VA = "0x13E8D00")]
			set
			{
			}
		}

		[Token(Token = "0x17000063")]
		public AnimationCurve customValueInterpolation
		{
			[Token(Token = "0x60009CE")]
			[Address(RVA = "0x13E8D4C", Offset = "0x13E8D4C", VA = "0x13E8D4C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009CF")]
			[Address(RVA = "0x13E8D68", Offset = "0x13E8D68", VA = "0x13E8D68")]
			set
			{
			}
		}

		[Token(Token = "0x17000064")]
		public AnimationCurve customNormalInterpolation
		{
			[Token(Token = "0x60009D0")]
			[Address(RVA = "0x13E8D8C", Offset = "0x13E8D8C", VA = "0x13E8D8C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009D1")]
			[Address(RVA = "0x13E8DA8", Offset = "0x13E8DA8", VA = "0x13E8DA8")]
			set
			{
			}
		}

		[Token(Token = "0x17000065")]
		public int iterations
		{
			[Token(Token = "0x60009D2")]
			[Address(RVA = "0x13E8DCC", Offset = "0x13E8DCC", VA = "0x13E8DCC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000066")]
		public double moveStep
		{
			[Token(Token = "0x60009D3")]
			[Address(RVA = "0x13E64FC", Offset = "0x13E64FC", VA = "0x13E64FC")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000067")]
		public bool isClosed
		{
			[Token(Token = "0x60009D4")]
			[Address(RVA = "0x13E8DE8", Offset = "0x13E8DE8", VA = "0x13E8DE8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000068")]
		public int pointCount
		{
			[Token(Token = "0x60009D5")]
			[Address(RVA = "0x13E63B0", Offset = "0x13E63B0", VA = "0x13E63B0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000069")]
		public Morph morph
		{
			[Token(Token = "0x60009D6")]
			[Address(RVA = "0x13E8E04", Offset = "0x13E8E04", VA = "0x13E8E04")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006A")]
		public NodeLink[] nodeLinks
		{
			[Token(Token = "0x60009D7")]
			[Address(RVA = "0x13E8EF4", Offset = "0x13E8EF4", VA = "0x13E8EF4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006B")]
		public bool hasMorph
		{
			[Token(Token = "0x60009D8")]
			[Address(RVA = "0x13E8EFC", Offset = "0x13E8EFC", VA = "0x13E8EFC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006C")]
		public Vector3 position
		{
			[Token(Token = "0x60009D9")]
			[Address(RVA = "0x13E8F3C", Offset = "0x13E8F3C", VA = "0x13E8F3C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700006D")]
		public Quaternion rotation
		{
			[Token(Token = "0x60009DA")]
			[Address(RVA = "0x13E8F78", Offset = "0x13E8F78", VA = "0x13E8F78")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x1700006E")]
		public Vector3 scale
		{
			[Token(Token = "0x60009DB")]
			[Address(RVA = "0x13E8FB4", Offset = "0x13E8FB4", VA = "0x13E8FB4")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700006F")]
		public int subscriberCount
		{
			[Token(Token = "0x60009DC")]
			[Address(RVA = "0x13E8FF0", Offset = "0x13E8FF0", VA = "0x13E8FF0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x14000002")]
		public event EmptySplineHandler onRebuild
		{
			[Token(Token = "0x60009DD")]
			[Address(RVA = "0x13E900C", Offset = "0x13E900C", VA = "0x13E900C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x835F94", Offset = "0x835F94")]
			add
			{
			}
			[Token(Token = "0x60009DE")]
			[Address(RVA = "0x13E90B0", Offset = "0x13E90B0", VA = "0x13E90B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x835FA4", Offset = "0x835FA4")]
			remove
			{
			}
		}

		[Token(Token = "0x60009DF")]
		[Address(RVA = "0x13E9154", Offset = "0x13E9154", VA = "0x13E9154")]
		private void Awake()
		{
		}

		[Token(Token = "0x60009E0")]
		[Address(RVA = "0x13E91D4", Offset = "0x13E91D4", VA = "0x13E91D4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60009E1")]
		[Address(RVA = "0x13E943C", Offset = "0x13E943C", VA = "0x13E943C")]
		private void Update()
		{
		}

		[Token(Token = "0x60009E2")]
		[Address(RVA = "0x13E9210", Offset = "0x13E9210", VA = "0x13E9210")]
		private void Run()
		{
		}

		[Token(Token = "0x60009E3")]
		[Address(RVA = "0x13E9630", Offset = "0x13E9630", VA = "0x13E9630")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60009E4")]
		[Address(RVA = "0x13E9614", Offset = "0x13E9614", VA = "0x13E9614")]
		public void ResampleTransform()
		{
		}

		[Token(Token = "0x60009E5")]
		[Address(RVA = "0x13E9648", Offset = "0x13E9648", VA = "0x13E9648")]
		public void Subscribe(SplineUser input)
		{
		}

		[Token(Token = "0x60009E6")]
		[Address(RVA = "0x13E9824", Offset = "0x13E9824", VA = "0x13E9824")]
		public void Unsubscribe(SplineUser input)
		{
		}

		[Token(Token = "0x60009E7")]
		[Address(RVA = "0x13E99DC", Offset = "0x13E99DC", VA = "0x13E99DC")]
		public bool IsSubscribed(SplineUser user)
		{
			return default(bool);
		}

		[Token(Token = "0x60009E8")]
		[Address(RVA = "0x13E9AB4", Offset = "0x13E9AB4", VA = "0x13E9AB4")]
		public SplineUser[] GetSubscribers()
		{
			return null;
		}

		[Token(Token = "0x60009E9")]
		[Address(RVA = "0x13E9ABC", Offset = "0x13E9ABC", VA = "0x13E9ABC")]
		public void AddNodeLink(Node node, int pointIndex)
		{
		}

		[Token(Token = "0x60009EA")]
		[Address(RVA = "0x13E9F5C", Offset = "0x13E9F5C", VA = "0x13E9F5C")]
		public void RemoveNodeLink(int pointIndex)
		{
		}

		[Token(Token = "0x60009EB")]
		[Address(RVA = "0x13EA470", Offset = "0x13EA470", VA = "0x13EA470")]
		public SplinePoint[] GetPoints(Space getSpace = Space.World)
		{
			return null;
		}

		[Token(Token = "0x60009EC")]
		[Address(RVA = "0x13EA820", Offset = "0x13EA820", VA = "0x13EA820")]
		public SplinePoint GetPoint(int index, Space getSpace = Space.World)
		{
			return default(SplinePoint);
		}

		[Token(Token = "0x60009ED")]
		[Address(RVA = "0x13EA9CC", Offset = "0x13EA9CC", VA = "0x13EA9CC")]
		public Vector3 GetPointPosition(int index, Space getSpace = Space.World)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60009EE")]
		[Address(RVA = "0x13EAA58", Offset = "0x13EAA58", VA = "0x13EAA58")]
		public Vector3 GetPointNormal(int index, Space getSpace = Space.World)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60009EF")]
		[Address(RVA = "0x13EAAE8", Offset = "0x13EAAE8", VA = "0x13EAAE8")]
		public Vector3 GetPointTangent(int index, Space getSpace = Space.World)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60009F0")]
		[Address(RVA = "0x13EAB74", Offset = "0x13EAB74", VA = "0x13EAB74")]
		public Vector3 GetPointTangent2(int index, Space getSpace = Space.World)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60009F1")]
		[Address(RVA = "0x13EAC00", Offset = "0x13EAC00", VA = "0x13EAC00")]
		public float GetPointSize(int index, Space getSpace = Space.World)
		{
			return default(float);
		}

		[Token(Token = "0x60009F2")]
		[Address(RVA = "0x13EAC48", Offset = "0x13EAC48", VA = "0x13EAC48")]
		public Color GetPointColor(int index, Space getSpace = Space.World)
		{
			return default(Color);
		}

		[Token(Token = "0x60009F3")]
		[Address(RVA = "0x13EAC94", Offset = "0x13EAC94", VA = "0x13EAC94")]
		public void SetPoints(SplinePoint[] points, Space setSpace = Space.World)
		{
		}

		[Token(Token = "0x60009F4")]
		[Address(RVA = "0x13EB654", Offset = "0x13EB654", VA = "0x13EB654")]
		public void SetPointPosition(int index, Vector3 pos, Space setSpace = Space.World)
		{
		}

		[Token(Token = "0x60009F5")]
		[Address(RVA = "0x13EB98C", Offset = "0x13EB98C", VA = "0x13EB98C")]
		public void SetPointTangents(int index, Vector3 tan1, Vector3 tan2, Space setSpace = Space.World)
		{
		}

		[Token(Token = "0x60009F6")]
		[Address(RVA = "0x13EBCB0", Offset = "0x13EBCB0", VA = "0x13EBCB0")]
		public void SetPointNormal(int index, Vector3 nrm, Space setSpace = Space.World)
		{
		}

		[Token(Token = "0x60009F7")]
		[Address(RVA = "0x13EBE68", Offset = "0x13EBE68", VA = "0x13EBE68")]
		public void SetPointSize(int index, float size)
		{
		}

		[Token(Token = "0x60009F8")]
		[Address(RVA = "0x13EBF3C", Offset = "0x13EBF3C", VA = "0x13EBF3C")]
		public void SetPointColor(int index, Color color)
		{
		}

		[Token(Token = "0x60009F9")]
		[Address(RVA = "0x13EC070", Offset = "0x13EC070", VA = "0x13EC070")]
		public void SetPoint(int index, SplinePoint point, Space setSpace = Space.World)
		{
		}

		[Token(Token = "0x60009FA")]
		[Address(RVA = "0x13EB80C", Offset = "0x13EB80C", VA = "0x13EB80C")]
		private void AppendPoints(int count)
		{
		}

		[Token(Token = "0x60009FB")]
		[Address(RVA = "0x13EC4F0", Offset = "0x13EC4F0", VA = "0x13EC4F0")]
		public double GetPointPercent(int pointIndex)
		{
			return default(double);
		}

		[Token(Token = "0x60009FC")]
		[Address(RVA = "0x13E6E90", Offset = "0x13E6E90", VA = "0x13E6E90")]
		public Vector3 EvaluatePosition(double percent)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60009FD")]
		[Address(RVA = "0x13EC524", Offset = "0x13EC524", VA = "0x13EC524")]
		public SplineResult Evaluate(double percent)
		{
			return null;
		}

		[Token(Token = "0x60009FE")]
		[Address(RVA = "0x13EC5A0", Offset = "0x13EC5A0", VA = "0x13EC5A0")]
		public SplineResult Evaluate(int pointIndex)
		{
			return null;
		}

		[Token(Token = "0x60009FF")]
		[Address(RVA = "0x13EC638", Offset = "0x13EC638", VA = "0x13EC638")]
		public void Evaluate(SplineResult result, int pointIndex)
		{
		}

		[Token(Token = "0x6000A00")]
		[Address(RVA = "0x13E6B94", Offset = "0x13E6B94", VA = "0x13E6B94")]
		public void Evaluate(SplineResult result, double percent)
		{
		}

		[Token(Token = "0x6000A01")]
		[Address(RVA = "0x13EC70C", Offset = "0x13EC70C", VA = "0x13EC70C")]
		public void Evaluate(ref SplineResult[] samples, double from = 0.0, double to = 1.0)
		{
		}

		[Token(Token = "0x6000A02")]
		[Address(RVA = "0x13EC79C", Offset = "0x13EC79C", VA = "0x13EC79C")]
		public void EvaluatePositions(ref Vector3[] positions, double from = 0.0, double to = 1.0)
		{
		}

		[Token(Token = "0x6000A03")]
		[Address(RVA = "0x13EC854", Offset = "0x13EC854", VA = "0x13EC854")]
		public double Travel(double start, float distance, Spline.Direction direction)
		{
			return default(double);
		}

		[Token(Token = "0x6000A04")]
		[Address(RVA = "0x13EC688", Offset = "0x13EC688", VA = "0x13EC688")]
		private void TransformResult(SplineResult result)
		{
		}

		[Token(Token = "0x6000A05")]
		[Address(RVA = "0x13E8C8C", Offset = "0x13E8C8C", VA = "0x13E8C8C")]
		public void Rebuild()
		{
		}

		[Token(Token = "0x6000A06")]
		[Address(RVA = "0x13ECACC", Offset = "0x13ECACC", VA = "0x13ECACC")]
		public void RebuildImmediate()
		{
		}

		[Token(Token = "0x6000A07")]
		[Address(RVA = "0x13ECCA8", Offset = "0x13ECCA8", VA = "0x13ECCA8")]
		private void RemoveSubscriber(int index)
		{
		}

		[Token(Token = "0x6000A08")]
		[Address(RVA = "0x13E927C", Offset = "0x13E927C", VA = "0x13E927C")]
		private void RebuildOnUpdate()
		{
		}

		[Token(Token = "0x6000A09")]
		[Address(RVA = "0x13ECDD4", Offset = "0x13ECDD4", VA = "0x13ECDD4")]
		public void RebuildConnectedUsers()
		{
		}

		[Token(Token = "0x6000A0A")]
		[Address(RVA = "0x13ECDD8", Offset = "0x13ECDD8", VA = "0x13ECDD8")]
		private void RebuildUser(int index)
		{
		}

		[Token(Token = "0x6000A0B")]
		[Address(RVA = "0x13E748C", Offset = "0x13E748C", VA = "0x13E748C")]
		public double Project(Vector3 point, int subdivide = 3, double from = 0.0, double to = 1.0)
		{
			return default(double);
		}

		[Token(Token = "0x6000A0C")]
		[Address(RVA = "0x13EB218", Offset = "0x13EB218", VA = "0x13EB218")]
		public void Break()
		{
		}

		[Token(Token = "0x6000A0D")]
		[Address(RVA = "0x13ECF00", Offset = "0x13ECF00", VA = "0x13ECF00")]
		public void Break(int at)
		{
		}

		[Token(Token = "0x6000A0E")]
		[Address(RVA = "0x13ECF54", Offset = "0x13ECF54", VA = "0x13ECF54")]
		public void Close()
		{
		}

		[Token(Token = "0x6000A0F")]
		[Address(RVA = "0x13ECFA0", Offset = "0x13ECFA0", VA = "0x13ECFA0")]
		public void ConvertToBezier()
		{
		}

		[Token(Token = "0x6000A10")]
		[Address(RVA = "0x13E7820", Offset = "0x13E7820", VA = "0x13E7820")]
		public float CalculateLength(double from = 0.0, double to = 1.0, double resolution = 1.0)
		{
			return default(float);
		}

		[Token(Token = "0x6000A11")]
		[Address(RVA = "0x13ECFBC", Offset = "0x13ECFBC", VA = "0x13ECFBC")]
		public bool Raycast(out RaycastHit hit, out double hitPercent, LayerMask layerMask, double resolution = 1.0, double from = 0.0, double to = 1.0, QueryTriggerInteraction hitTriggers = QueryTriggerInteraction.UseGlobal)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A12")]
		[Address(RVA = "0x13ED218", Offset = "0x13ED218", VA = "0x13ED218")]
		public bool RaycastAll(out RaycastHit[] hits, out double[] hitPercents, LayerMask layerMask, double resolution = 1.0, double from = 0.0, double to = 1.0, QueryTriggerInteraction hitTriggers = QueryTriggerInteraction.UseGlobal)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A13")]
		[Address(RVA = "0x13ED608", Offset = "0x13ED608", VA = "0x13ED608")]
		public int[] GetAvailableNodeLinksAtPosition(double percent, Spline.Direction direction)
		{
			return null;
		}

		[Token(Token = "0x6000A14")]
		[Address(RVA = "0x13ED73C", Offset = "0x13ED73C", VA = "0x13ED73C")]
		public void GetConnectedComputers(List<SplineComputer> computers, List<int> connectionIndices, List<int> connectedIndices, double percent, Spline.Direction direction, bool includeEqual)
		{
		}

		[Token(Token = "0x6000A15")]
		[Address(RVA = "0x13EDA84", Offset = "0x13EDA84", VA = "0x13EDA84")]
		public void SetMorphState(int index)
		{
		}

		[Token(Token = "0x6000A16")]
		[Address(RVA = "0x13EDBDC", Offset = "0x13EDBDC", VA = "0x13EDBDC")]
		public void SetMorphState(string morphName)
		{
		}

		[Token(Token = "0x6000A17")]
		[Address(RVA = "0x13EDE48", Offset = "0x13EDE48", VA = "0x13EDE48")]
		public void SetMorphState(int index, float percent)
		{
		}

		[Token(Token = "0x6000A18")]
		[Address(RVA = "0x13EDFCC", Offset = "0x13EDFCC", VA = "0x13EDFCC")]
		public void SetMorphState(string morphName, float percent)
		{
		}

		[Token(Token = "0x6000A19")]
		[Address(RVA = "0x13EE138", Offset = "0x13EE138", VA = "0x13EE138")]
		public void SetMorphState(float percent)
		{
		}

		[Token(Token = "0x6000A1A")]
		[Address(RVA = "0x13EE22C", Offset = "0x13EE22C", VA = "0x13EE22C")]
		public List<SplineComputer> GetConnectedComputers()
		{
			return null;
		}

		[Token(Token = "0x6000A1B")]
		[Address(RVA = "0x13EE2DC", Offset = "0x13EE2DC", VA = "0x13EE2DC")]
		private void GetConnectedComputers(ref List<SplineComputer> computers)
		{
		}

		[Token(Token = "0x6000A1C")]
		[Address(RVA = "0x13EA0E0", Offset = "0x13EA0E0", VA = "0x13EA0E0")]
		private void RemoveNodeLinkAt(int index)
		{
		}

		[Token(Token = "0x6000A1D")]
		[Address(RVA = "0x13EB8BC", Offset = "0x13EB8BC", VA = "0x13EB8BC")]
		private void SetNodeForPoint(int index, SplinePoint worldPoint)
		{
		}

		[Token(Token = "0x6000A1E")]
		[Address(RVA = "0x13EB3F8", Offset = "0x13EB3F8", VA = "0x13EB3F8")]
		private void UpdateConnectedNodes(SplinePoint[] worldPoints)
		{
		}

		[Token(Token = "0x6000A1F")]
		[Address(RVA = "0x13E9474", Offset = "0x13E9474", VA = "0x13E9474")]
		private void UpdateConnectedNodes()
		{
		}

		[Token(Token = "0x6000A20")]
		[Address(RVA = "0x13EA648", Offset = "0x13EA648", VA = "0x13EA648")]
		public Vector3 TransformPoint(Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000A21")]
		[Address(RVA = "0x13EB220", Offset = "0x13EB220", VA = "0x13EB220")]
		public Vector3 InverseTransformPoint(Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000A22")]
		[Address(RVA = "0x13EA734", Offset = "0x13EA734", VA = "0x13EA734")]
		public Vector3 TransformDirection(Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000A23")]
		[Address(RVA = "0x13EB30C", Offset = "0x13EB30C", VA = "0x13EB30C")]
		public Vector3 InverseTransformDirection(Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000A24")]
		[Address(RVA = "0x13EE588", Offset = "0x13EE588", VA = "0x13EE588")]
		public SplineComputer()
		{
		}
	}
	[Token(Token = "0x2000161")]
	public delegate void SplineReachHandler();
	[Token(Token = "0x2000162")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8316EC", Offset = "0x8316EC")]
	public class SplineFollower : SplineTracer
	{
		[Token(Token = "0x20001E4")]
		public enum FollowMode
		{
			[Token(Token = "0x4000A6D")]
			Uniform,
			[Token(Token = "0x4000A6E")]
			Time
		}

		[Token(Token = "0x20001E5")]
		public enum Wrap
		{
			[Token(Token = "0x4000A70")]
			Default,
			[Token(Token = "0x4000A71")]
			Loop,
			[Token(Token = "0x4000A72")]
			PingPong
		}

		[Token(Token = "0x40007C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[HideInInspector]
		public Wrap wrapMode;

		[Token(Token = "0x40007C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		[HideInInspector]
		public FollowMode followMode;

		[Token(Token = "0x40007C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[HideInInspector]
		public bool autoStartPosition;

		[Token(Token = "0x40007C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x121")]
		[HideInInspector]
		public bool autoFollow;

		[Token(Token = "0x40007C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		[SerializeField]
		[HideInInspector]
		private float _followSpeed;

		[Token(Token = "0x40007C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		[SerializeField]
		[HideInInspector]
		private float _followDuration;

		[Token(Token = "0x40007C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private double lastClippedPercent;

		[Token(Token = "0x40007CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private SplineResult from;

		[Token(Token = "0x40007CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private SplineResult to;

		[Token(Token = "0x40007CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private bool followStarted;

		[Token(Token = "0x17000070")]
		public float followSpeed
		{
			[Token(Token = "0x6000A29")]
			[Address(RVA = "0x13EF4FC", Offset = "0x13EF4FC", VA = "0x13EF4FC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000A2A")]
			[Address(RVA = "0x13EF504", Offset = "0x13EF504", VA = "0x13EF504")]
			set
			{
			}
		}

		[Token(Token = "0x17000071")]
		public float followDuration
		{
			[Token(Token = "0x6000A2B")]
			[Address(RVA = "0x13EF520", Offset = "0x13EF520", VA = "0x13EF520")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000A2C")]
			[Address(RVA = "0x13EF528", Offset = "0x13EF528", VA = "0x13EF528")]
			set
			{
			}
		}

		[Token(Token = "0x17000072")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x8374E4", Offset = "0x8374E4")]
		public SplineResult followResult
		{
			[Token(Token = "0x6000A2D")]
			[Address(RVA = "0x13EF544", Offset = "0x13EF544", VA = "0x13EF544")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000073")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x83751C", Offset = "0x83751C")]
		public SplineResult offsettedFollowResult
		{
			[Token(Token = "0x6000A2E")]
			[Address(RVA = "0x13EF54C", Offset = "0x13EF54C", VA = "0x13EF54C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000003")]
		public event SplineReachHandler onEndReached
		{
			[Token(Token = "0x6000A2F")]
			[Address(RVA = "0x13EF554", Offset = "0x13EF554", VA = "0x13EF554")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x835FB4", Offset = "0x835FB4")]
			add
			{
			}
			[Token(Token = "0x6000A30")]
			[Address(RVA = "0x13EF5FC", Offset = "0x13EF5FC", VA = "0x13EF5FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x835FC4", Offset = "0x835FC4")]
			remove
			{
			}
		}

		[Token(Token = "0x14000004")]
		public event SplineReachHandler onBeginningReached
		{
			[Token(Token = "0x6000A31")]
			[Address(RVA = "0x13EF6A4", Offset = "0x13EF6A4", VA = "0x13EF6A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x835FD4", Offset = "0x835FD4")]
			add
			{
			}
			[Token(Token = "0x6000A32")]
			[Address(RVA = "0x13EF74C", Offset = "0x13EF74C", VA = "0x13EF74C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x835FE4", Offset = "0x835FE4")]
			remove
			{
			}
		}

		[Token(Token = "0x6000A33")]
		[Address(RVA = "0x13EF7F4", Offset = "0x13EF7F4", VA = "0x13EF7F4", Slot = "29")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000A34")]
		[Address(RVA = "0x13EF890", Offset = "0x13EF890", VA = "0x13EF890", Slot = "19")]
		protected override void LateRun()
		{
		}

		[Token(Token = "0x6000A35")]
		[Address(RVA = "0x13EF9C4", Offset = "0x13EF9C4", VA = "0x13EF9C4", Slot = "21")]
		protected override void PostBuild()
		{
		}

		[Token(Token = "0x6000A36")]
		[Address(RVA = "0x13EF8CC", Offset = "0x13EF8CC", VA = "0x13EF8CC")]
		private void AutoFollow()
		{
		}

		[Token(Token = "0x6000A37")]
		[Address(RVA = "0x13F08E4", Offset = "0x13F08E4", VA = "0x13F08E4")]
		public void Restart(double startPosition = 0.0)
		{
		}

		[Token(Token = "0x6000A38")]
		[Address(RVA = "0x13F0930", Offset = "0x13F0930", VA = "0x13F0930", Slot = "30")]
		public override void SetPercent(double percent, bool checkTriggers = false)
		{
		}

		[Token(Token = "0x6000A39")]
		[Address(RVA = "0x13F0998", Offset = "0x13F0998", VA = "0x13F0998", Slot = "31")]
		public override void SetDistance(float distance, bool checkTriggers = false)
		{
		}

		[Token(Token = "0x6000A3A")]
		[Address(RVA = "0x13F0538", Offset = "0x13F0538", VA = "0x13F0538")]
		public void Move(double percent)
		{
		}

		[Token(Token = "0x6000A3B")]
		[Address(RVA = "0x13EFA50", Offset = "0x13EFA50", VA = "0x13EFA50")]
		public void Move(float distance)
		{
		}

		[Token(Token = "0x6000A3C")]
		[Address(RVA = "0x13F0A24", Offset = "0x13F0A24", VA = "0x13F0A24")]
		public SplineFollower()
		{
		}
	}
	[Token(Token = "0x2000163")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x831724", Offset = "0x831724")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x831724", Offset = "0x831724")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x831724", Offset = "0x831724")]
	public class SplineMesh : MeshGenerator
	{
		[Serializable]
		[Token(Token = "0x20001E6")]
		public class Channel
		{
			[Token(Token = "0x200022F")]
			public delegate float FloatHandler(double percent);

			[Token(Token = "0x2000230")]
			public delegate Vector2 Vector2Handler(double percent);

			[Token(Token = "0x2000231")]
			public delegate Vector3 Vector3Handler(double percent);

			[Token(Token = "0x2000232")]
			public delegate Quaternion QuaternionHandler(double percent);

			[Token(Token = "0x2000233")]
			public enum Type
			{
				[Token(Token = "0x4000BA1")]
				Extrude,
				[Token(Token = "0x4000BA2")]
				Place
			}

			[Token(Token = "0x2000234")]
			public enum UVOverride
			{
				[Token(Token = "0x4000BA4")]
				None,
				[Token(Token = "0x4000BA5")]
				ClampU,
				[Token(Token = "0x4000BA6")]
				ClampV,
				[Token(Token = "0x4000BA7")]
				UniformU,
				[Token(Token = "0x4000BA8")]
				UniformV
			}

			[Serializable]
			[Token(Token = "0x2000235")]
			public class MeshDefinition
			{
				[Token(Token = "0x2000237")]
				public enum MirrorMethod
				{
					[Token(Token = "0x4000BC5")]
					None,
					[Token(Token = "0x4000BC6")]
					X,
					[Token(Token = "0x4000BC7")]
					Y,
					[Token(Token = "0x4000BC8")]
					Z
				}

				[Serializable]
				[Token(Token = "0x2000238")]
				public class Submesh
				{
					[Token(Token = "0x4000BC9")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
					public int[] triangles;

					[Token(Token = "0x6000E7F")]
					[Address(RVA = "0x13F85F0", Offset = "0x13F85F0", VA = "0x13F85F0")]
					public Submesh()
					{
					}

					[Token(Token = "0x6000E80")]
					[Address(RVA = "0x13F6BB0", Offset = "0x13F6BB0", VA = "0x13F6BB0")]
					public Submesh(int[] input)
					{
					}
				}

				[Serializable]
				[Token(Token = "0x2000239")]
				public class VertexGroup
				{
					[Token(Token = "0x4000BCA")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
					public float value;

					[Token(Token = "0x4000BCB")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
					public double percent;

					[Token(Token = "0x4000BCC")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
					public int[] ids;

					[Token(Token = "0x6000E81")]
					[Address(RVA = "0x13F84F0", Offset = "0x13F84F0", VA = "0x13F84F0")]
					public VertexGroup(float val, double perc, int[] vertIds)
					{
					}

					[Token(Token = "0x6000E82")]
					[Address(RVA = "0x13F8534", Offset = "0x13F8534", VA = "0x13F8534")]
					public void AddId(int id)
					{
					}
				}

				[Token(Token = "0x4000BA9")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[SerializeField]
				[HideInInspector]
				internal Vector3[] vertices;

				[Token(Token = "0x4000BAA")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[SerializeField]
				[HideInInspector]
				internal Vector3[] normals;

				[Token(Token = "0x4000BAB")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				[SerializeField]
				[HideInInspector]
				internal Vector4[] tangents;

				[Token(Token = "0x4000BAC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				[SerializeField]
				[HideInInspector]
				internal Color[] colors;

				[Token(Token = "0x4000BAD")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
				[SerializeField]
				[HideInInspector]
				internal Vector2[] uv;

				[Token(Token = "0x4000BAE")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
				[SerializeField]
				[HideInInspector]
				internal Vector2[] uv2;

				[Token(Token = "0x4000BAF")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
				[SerializeField]
				[HideInInspector]
				internal Vector2[] uv3;

				[Token(Token = "0x4000BB0")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
				[SerializeField]
				[HideInInspector]
				internal Vector2[] uv4;

				[Token(Token = "0x4000BB1")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
				[SerializeField]
				[HideInInspector]
				internal int[] triangles;

				[Token(Token = "0x4000BB2")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
				[SerializeField]
				[HideInInspector]
				internal List<Submesh> subMeshes;

				[Token(Token = "0x4000BB3")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
				[SerializeField]
				[HideInInspector]
				internal TS_Bounds bounds;

				[Token(Token = "0x4000BB4")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
				[SerializeField]
				[HideInInspector]
				internal List<VertexGroup> vertexGroups;

				[Token(Token = "0x4000BB5")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
				[SerializeField]
				[HideInInspector]
				private Mesh _mesh;

				[Token(Token = "0x4000BB6")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
				[SerializeField]
				[HideInInspector]
				private Vector3 _rotation;

				[Token(Token = "0x4000BB7")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
				[SerializeField]
				[HideInInspector]
				private Vector2 _offset;

				[Token(Token = "0x4000BB8")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
				[SerializeField]
				[HideInInspector]
				private Vector3 _scale;

				[Token(Token = "0x4000BB9")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
				[SerializeField]
				[HideInInspector]
				private Vector2 _uvScale;

				[Token(Token = "0x4000BBA")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
				[SerializeField]
				[HideInInspector]
				private Vector2 _uvOffset;

				[Token(Token = "0x4000BBB")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
				[SerializeField]
				[HideInInspector]
				private float _uvRotation;

				[Token(Token = "0x4000BBC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
				[SerializeField]
				[HideInInspector]
				private MirrorMethod _mirror;

				[Token(Token = "0x4000BBD")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
				[SerializeField]
				[HideInInspector]
				private bool _flipFaces;

				[Token(Token = "0x4000BBE")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xB1")]
				[SerializeField]
				[HideInInspector]
				private bool _doubleSided;

				[Token(Token = "0x17000130")]
				public Mesh mesh
				{
					[Token(Token = "0x6000E5F")]
					[Address(RVA = "0x13F6680", Offset = "0x13F6680", VA = "0x13F6680")]
					get
					{
						return null;
					}
					[Token(Token = "0x6000E60")]
					[Address(RVA = "0x13F6688", Offset = "0x13F6688", VA = "0x13F6688")]
					set
					{
					}
				}

				[Token(Token = "0x17000131")]
				public Vector3 rotation
				{
					[Token(Token = "0x6000E61")]
					[Address(RVA = "0x13F6724", Offset = "0x13F6724", VA = "0x13F6724")]
					get
					{
						return default(Vector3);
					}
					[Token(Token = "0x6000E62")]
					[Address(RVA = "0x13F6730", Offset = "0x13F6730", VA = "0x13F6730")]
					set
					{
					}
				}

				[Token(Token = "0x17000132")]
				public Vector2 offset
				{
					[Token(Token = "0x6000E63")]
					[Address(RVA = "0x13F6804", Offset = "0x13F6804", VA = "0x13F6804")]
					get
					{
						return default(Vector2);
					}
					[Token(Token = "0x6000E64")]
					[Address(RVA = "0x13F680C", Offset = "0x13F680C", VA = "0x13F680C")]
					set
					{
					}
				}

				[Token(Token = "0x17000133")]
				public Vector3 scale
				{
					[Token(Token = "0x6000E65")]
					[Address(RVA = "0x13F68C0", Offset = "0x13F68C0", VA = "0x13F68C0")]
					get
					{
						return default(Vector3);
					}
					[Token(Token = "0x6000E66")]
					[Address(RVA = "0x13F68CC", Offset = "0x13F68CC", VA = "0x13F68CC")]
					set
					{
					}
				}

				[Token(Token = "0x17000134")]
				public Vector2 uvScale
				{
					[Token(Token = "0x6000E67")]
					[Address(RVA = "0x13F69A0", Offset = "0x13F69A0", VA = "0x13F69A0")]
					get
					{
						return default(Vector2);
					}
					[Token(Token = "0x6000E68")]
					[Address(RVA = "0x13F69A8", Offset = "0x13F69A8", VA = "0x13F69A8")]
					set
					{
					}
				}

				[Token(Token = "0x17000135")]
				public Vector2 uvOffset
				{
					[Token(Token = "0x6000E69")]
					[Address(RVA = "0x13F6A5C", Offset = "0x13F6A5C", VA = "0x13F6A5C")]
					get
					{
						return default(Vector2);
					}
					[Token(Token = "0x6000E6A")]
					[Address(RVA = "0x13F6A64", Offset = "0x13F6A64", VA = "0x13F6A64")]
					set
					{
					}
				}

				[Token(Token = "0x17000136")]
				public float uvRotation
				{
					[Token(Token = "0x6000E6B")]
					[Address(RVA = "0x13F6B18", Offset = "0x13F6B18", VA = "0x13F6B18")]
					get
					{
						return default(float);
					}
					[Token(Token = "0x6000E6C")]
					[Address(RVA = "0x13F6B20", Offset = "0x13F6B20", VA = "0x13F6B20")]
					set
					{
					}
				}

				[Token(Token = "0x17000137")]
				public MirrorMethod mirror
				{
					[Token(Token = "0x6000E6D")]
					[Address(RVA = "0x13F6B38", Offset = "0x13F6B38", VA = "0x13F6B38")]
					get
					{
						return default(MirrorMethod);
					}
					[Token(Token = "0x6000E6E")]
					[Address(RVA = "0x13F6B40", Offset = "0x13F6B40", VA = "0x13F6B40")]
					set
					{
					}
				}

				[Token(Token = "0x17000138")]
				public bool flipFaces
				{
					[Token(Token = "0x6000E6F")]
					[Address(RVA = "0x13F6B58", Offset = "0x13F6B58", VA = "0x13F6B58")]
					get
					{
						return default(bool);
					}
					[Token(Token = "0x6000E70")]
					[Address(RVA = "0x13F6B60", Offset = "0x13F6B60", VA = "0x13F6B60")]
					set
					{
					}
				}

				[Token(Token = "0x17000139")]
				public bool doubleSided
				{
					[Token(Token = "0x6000E71")]
					[Address(RVA = "0x13F6B84", Offset = "0x13F6B84", VA = "0x13F6B84")]
					get
					{
						return default(bool);
					}
					[Token(Token = "0x6000E72")]
					[Address(RVA = "0x13F6B8C", Offset = "0x13F6B8C", VA = "0x13F6B8C")]
					set
					{
					}
				}

				[Token(Token = "0x6000E73")]
				[Address(RVA = "0x13F4C08", Offset = "0x13F4C08", VA = "0x13F4C08")]
				internal MeshDefinition Copy()
				{
					return null;
				}

				[Token(Token = "0x6000E74")]
				[Address(RVA = "0x13F47C0", Offset = "0x13F47C0", VA = "0x13F47C0")]
				public MeshDefinition(Mesh input)
				{
				}

				[Token(Token = "0x6000E75")]
				[Address(RVA = "0x13F5DE8", Offset = "0x13F5DE8", VA = "0x13F5DE8")]
				public void Refresh()
				{
				}

				[Token(Token = "0x6000E76")]
				[Address(RVA = "0x13F7230", Offset = "0x13F7230", VA = "0x13F7230")]
				private void FlipFaces()
				{
				}

				[Token(Token = "0x6000E77")]
				[Address(RVA = "0x13F702C", Offset = "0x13F702C", VA = "0x13F702C")]
				private void DoubleSided()
				{
				}

				[Token(Token = "0x6000E78")]
				[Address(RVA = "0x13F2B80", Offset = "0x13F2B80", VA = "0x13F2B80")]
				public void Write(TS_Mesh target, int forceMaterialId = -1)
				{
				}

				[Token(Token = "0x6000E79")]
				[Address(RVA = "0x13F780C", Offset = "0x13F780C", VA = "0x13F780C")]
				private void CalculateBounds()
				{
				}

				[Token(Token = "0x6000E7A")]
				[Address(RVA = "0x13F6C48", Offset = "0x13F6C48", VA = "0x13F6C48")]
				private void Mirror()
				{
				}

				[Token(Token = "0x6000E7B")]
				[Address(RVA = "0x13F7348", Offset = "0x13F7348", VA = "0x13F7348")]
				private void TransformVertices()
				{
				}

				[Token(Token = "0x6000E7C")]
				[Address(RVA = "0x13F7968", Offset = "0x13F7968", VA = "0x13F7968")]
				private void GroupVertices()
				{
				}

				[Token(Token = "0x6000E7D")]
				[Address(RVA = "0x13F83D4", Offset = "0x13F83D4", VA = "0x13F83D4")]
				private int FindInsertIndex(Vector3 pos, float value)
				{
					return default(int);
				}

				[Token(Token = "0x6000E7E")]
				[Address(RVA = "0x13F7CC0", Offset = "0x13F7CC0", VA = "0x13F7CC0")]
				private void CalculateTangents()
				{
				}
			}

			[Token(Token = "0x4000A73")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string name;

			[Token(Token = "0x4000A74")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private System.Random iterationRandom;

			[Token(Token = "0x4000A75")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			[HideInInspector]
			private int _iterationSeed;

			[Token(Token = "0x4000A76")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[SerializeField]
			[HideInInspector]
			private int _offsetSeed;

			[Token(Token = "0x4000A77")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private System.Random offsetRandom;

			[Token(Token = "0x4000A78")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector2Handler _offsetHandler;

			[Token(Token = "0x4000A79")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[SerializeField]
			[HideInInspector]
			private int _rotationSeed;

			[Token(Token = "0x4000A7A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private System.Random rotationRandom;

			[Token(Token = "0x4000A7B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private QuaternionHandler _placeRotationHandler;

			[Token(Token = "0x4000A7C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private FloatHandler _extrudeRotationHandler;

			[Token(Token = "0x4000A7D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[SerializeField]
			[HideInInspector]
			private int _scaleSeed;

			[Token(Token = "0x4000A7E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private System.Random scaleRandom;

			[Token(Token = "0x4000A7F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private Vector3Handler _scaleHandler;

			[Token(Token = "0x4000A80")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[SerializeField]
			internal SplineMesh owner;

			[Token(Token = "0x4000A81")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[SerializeField]
			[HideInInspector]
			private List<MeshDefinition> meshes;

			[Token(Token = "0x4000A82")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[SerializeField]
			[HideInInspector]
			private double _clipFrom;

			[Token(Token = "0x4000A83")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[SerializeField]
			[HideInInspector]
			private double _clipTo;

			[Token(Token = "0x4000A84")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[SerializeField]
			[HideInInspector]
			private bool _randomOrder;

			[Token(Token = "0x4000A85")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[SerializeField]
			[HideInInspector]
			private UVOverride _overrideUVs;

			[Token(Token = "0x4000A86")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[SerializeField]
			[HideInInspector]
			private Vector2 _uvScale;

			[Token(Token = "0x4000A87")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[SerializeField]
			[HideInInspector]
			private Vector2 _uvOffset;

			[Token(Token = "0x4000A88")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[SerializeField]
			[HideInInspector]
			private bool _overrideNormal;

			[Token(Token = "0x4000A89")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			[SerializeField]
			[HideInInspector]
			private Vector3 _customNormal;

			[Token(Token = "0x4000A8A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			[SerializeField]
			[HideInInspector]
			private Type _type;

			[Token(Token = "0x4000A8B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			[SerializeField]
			[HideInInspector]
			private int _count;

			[Token(Token = "0x4000A8C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			[SerializeField]
			[HideInInspector]
			private double _spacing;

			[Token(Token = "0x4000A8D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			[SerializeField]
			[HideInInspector]
			private bool _randomRotation;

			[Token(Token = "0x4000A8E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			[SerializeField]
			[HideInInspector]
			private Vector3 _minRotation;

			[Token(Token = "0x4000A8F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			[SerializeField]
			[HideInInspector]
			private Vector3 _maxRotation;

			[Token(Token = "0x4000A90")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
			[SerializeField]
			[HideInInspector]
			private bool _randomOffset;

			[Token(Token = "0x4000A91")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			[SerializeField]
			[HideInInspector]
			private Vector2 _minOffset;

			[Token(Token = "0x4000A92")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			[SerializeField]
			[HideInInspector]
			private Vector2 _maxOffset;

			[Token(Token = "0x4000A93")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			[SerializeField]
			[HideInInspector]
			private bool _randomScale;

			[Token(Token = "0x4000A94")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF9")]
			[SerializeField]
			[HideInInspector]
			private bool _uniformRandomScale;

			[Token(Token = "0x4000A95")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
			[SerializeField]
			[HideInInspector]
			private Vector3 _minScale;

			[Token(Token = "0x4000A96")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			[SerializeField]
			[HideInInspector]
			private Vector3 _maxScale;

			[Token(Token = "0x4000A97")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
			private int iterator;

			[Token(Token = "0x4000A98")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			[SerializeField]
			[HideInInspector]
			private bool _overrideMaterialID;

			[Token(Token = "0x4000A99")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
			[SerializeField]
			[HideInInspector]
			private int _targetMaterialID;

			[Token(Token = "0x170000E5")]
			public double clipFrom
			{
				[Token(Token = "0x6000D3C")]
				[Address(RVA = "0x13F3AE4", Offset = "0x13F3AE4", VA = "0x13F3AE4")]
				get
				{
					return default(double);
				}
				[Token(Token = "0x6000D3D")]
				[Address(RVA = "0x13F3AEC", Offset = "0x13F3AEC", VA = "0x13F3AEC")]
				set
				{
				}
			}

			[Token(Token = "0x170000E6")]
			public double clipTo
			{
				[Token(Token = "0x6000D3E")]
				[Address(RVA = "0x13F3BA0", Offset = "0x13F3BA0", VA = "0x13F3BA0")]
				get
				{
					return default(double);
				}
				[Token(Token = "0x6000D3F")]
				[Address(RVA = "0x13F3BA8", Offset = "0x13F3BA8", VA = "0x13F3BA8")]
				set
				{
				}
			}

			[Token(Token = "0x170000E7")]
			public bool randomOffset
			{
				[Token(Token = "0x6000D40")]
				[Address(RVA = "0x13F3BC0", Offset = "0x13F3BC0", VA = "0x13F3BC0")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000D41")]
				[Address(RVA = "0x13F3BC8", Offset = "0x13F3BC8", VA = "0x13F3BC8")]
				set
				{
				}
			}

			[Token(Token = "0x170000E8")]
			public Vector2Handler offsetHandler
			{
				[Token(Token = "0x6000D42")]
				[Address(RVA = "0x13F3BEC", Offset = "0x13F3BEC", VA = "0x13F3BEC")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000D43")]
				[Address(RVA = "0x13F3BF4", Offset = "0x13F3BF4", VA = "0x13F3BF4")]
				set
				{
				}
			}

			[Token(Token = "0x170000E9")]
			public bool overrideMaterialID
			{
				[Token(Token = "0x6000D44")]
				[Address(RVA = "0x13F3C40", Offset = "0x13F3C40", VA = "0x13F3C40")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000D45")]
				[Address(RVA = "0x13F3C48", Offset = "0x13F3C48", VA = "0x13F3C48")]
				set
				{
				}
			}

			[Token(Token = "0x170000EA")]
			public int targetMaterialID
			{
				[Token(Token = "0x6000D46")]
				[Address(RVA = "0x13F3C6C", Offset = "0x13F3C6C", VA = "0x13F3C6C")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6000D47")]
				[Address(RVA = "0x13F3C74", Offset = "0x13F3C74", VA = "0x13F3C74")]
				set
				{
				}
			}

			[Token(Token = "0x170000EB")]
			public bool randomRotation
			{
				[Token(Token = "0x6000D48")]
				[Address(RVA = "0x13F3C8C", Offset = "0x13F3C8C", VA = "0x13F3C8C")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000D49")]
				[Address(RVA = "0x13F3C94", Offset = "0x13F3C94", VA = "0x13F3C94")]
				set
				{
				}
			}

			[Token(Token = "0x170000EC")]
			public QuaternionHandler placeRotationHandler
			{
				[Token(Token = "0x6000D4A")]
				[Address(RVA = "0x13F3CB8", Offset = "0x13F3CB8", VA = "0x13F3CB8")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000D4B")]
				[Address(RVA = "0x13F3CC0", Offset = "0x13F3CC0", VA = "0x13F3CC0")]
				set
				{
				}
			}

			[Token(Token = "0x170000ED")]
			public FloatHandler extrudeRotationHandler
			{
				[Token(Token = "0x6000D4C")]
				[Address(RVA = "0x13F3D0C", Offset = "0x13F3D0C", VA = "0x13F3D0C")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000D4D")]
				[Address(RVA = "0x13F3D14", Offset = "0x13F3D14", VA = "0x13F3D14")]
				set
				{
				}
			}

			[Token(Token = "0x170000EE")]
			public bool randomScale
			{
				[Token(Token = "0x6000D4E")]
				[Address(RVA = "0x13F3D60", Offset = "0x13F3D60", VA = "0x13F3D60")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000D4F")]
				[Address(RVA = "0x13F3D68", Offset = "0x13F3D68", VA = "0x13F3D68")]
				set
				{
				}
			}

			[Token(Token = "0x170000EF")]
			public Vector3Handler scaleHandler
			{
				[Token(Token = "0x6000D50")]
				[Address(RVA = "0x13F3D8C", Offset = "0x13F3D8C", VA = "0x13F3D8C")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000D51")]
				[Address(RVA = "0x13F3D94", Offset = "0x13F3D94", VA = "0x13F3D94")]
				set
				{
				}
			}

			[Token(Token = "0x170000F0")]
			public bool uniformRandomScale
			{
				[Token(Token = "0x6000D52")]
				[Address(RVA = "0x13F3DE0", Offset = "0x13F3DE0", VA = "0x13F3DE0")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000D53")]
				[Address(RVA = "0x13F3DE8", Offset = "0x13F3DE8", VA = "0x13F3DE8")]
				set
				{
				}
			}

			[Token(Token = "0x170000F1")]
			public int offsetSeed
			{
				[Token(Token = "0x6000D54")]
				[Address(RVA = "0x13F3E0C", Offset = "0x13F3E0C", VA = "0x13F3E0C")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6000D55")]
				[Address(RVA = "0x13F3E14", Offset = "0x13F3E14", VA = "0x13F3E14")]
				set
				{
				}
			}

			[Token(Token = "0x170000F2")]
			public int rotationSeed
			{
				[Token(Token = "0x6000D56")]
				[Address(RVA = "0x13F3E2C", Offset = "0x13F3E2C", VA = "0x13F3E2C")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6000D57")]
				[Address(RVA = "0x13F3E34", Offset = "0x13F3E34", VA = "0x13F3E34")]
				set
				{
				}
			}

			[Token(Token = "0x170000F3")]
			public int scaleSeed
			{
				[Token(Token = "0x6000D58")]
				[Address(RVA = "0x13F3E4C", Offset = "0x13F3E4C", VA = "0x13F3E4C")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6000D59")]
				[Address(RVA = "0x13F3E54", Offset = "0x13F3E54", VA = "0x13F3E54")]
				set
				{
				}
			}

			[Token(Token = "0x170000F4")]
			public double spacing
			{
				[Token(Token = "0x6000D5A")]
				[Address(RVA = "0x13F3E6C", Offset = "0x13F3E6C", VA = "0x13F3E6C")]
				get
				{
					return default(double);
				}
				[Token(Token = "0x6000D5B")]
				[Address(RVA = "0x13F3E74", Offset = "0x13F3E74", VA = "0x13F3E74")]
				set
				{
				}
			}

			[Token(Token = "0x170000F5")]
			public Vector2 minOffset
			{
				[Token(Token = "0x6000D5C")]
				[Address(RVA = "0x13F3E8C", Offset = "0x13F3E8C", VA = "0x13F3E8C")]
				get
				{
					return default(Vector2);
				}
				[Token(Token = "0x6000D5D")]
				[Address(RVA = "0x13F3E94", Offset = "0x13F3E94", VA = "0x13F3E94")]
				set
				{
				}
			}

			[Token(Token = "0x170000F6")]
			public Vector2 maxOffset
			{
				[Token(Token = "0x6000D5E")]
				[Address(RVA = "0x13F3F48", Offset = "0x13F3F48", VA = "0x13F3F48")]
				get
				{
					return default(Vector2);
				}
				[Token(Token = "0x6000D5F")]
				[Address(RVA = "0x13F3F50", Offset = "0x13F3F50", VA = "0x13F3F50")]
				set
				{
				}
			}

			[Token(Token = "0x170000F7")]
			public Vector3 minRotation
			{
				[Token(Token = "0x6000D60")]
				[Address(RVA = "0x13F4004", Offset = "0x13F4004", VA = "0x13F4004")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000D61")]
				[Address(RVA = "0x13F4010", Offset = "0x13F4010", VA = "0x13F4010")]
				set
				{
				}
			}

			[Token(Token = "0x170000F8")]
			public Vector3 maxRotation
			{
				[Token(Token = "0x6000D62")]
				[Address(RVA = "0x13F40E4", Offset = "0x13F40E4", VA = "0x13F40E4")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000D63")]
				[Address(RVA = "0x13F40F0", Offset = "0x13F40F0", VA = "0x13F40F0")]
				set
				{
				}
			}

			[Token(Token = "0x170000F9")]
			public Vector3 minScale
			{
				[Token(Token = "0x6000D64")]
				[Address(RVA = "0x13F41C4", Offset = "0x13F41C4", VA = "0x13F41C4")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000D65")]
				[Address(RVA = "0x13F41D0", Offset = "0x13F41D0", VA = "0x13F41D0")]
				set
				{
				}
			}

			[Token(Token = "0x170000FA")]
			public Vector3 maxScale
			{
				[Token(Token = "0x6000D66")]
				[Address(RVA = "0x13F42A4", Offset = "0x13F42A4", VA = "0x13F42A4")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000D67")]
				[Address(RVA = "0x13F42B4", Offset = "0x13F42B4", VA = "0x13F42B4")]
				set
				{
				}
			}

			[Token(Token = "0x170000FB")]
			public Type type
			{
				[Token(Token = "0x6000D68")]
				[Address(RVA = "0x13F4390", Offset = "0x13F4390", VA = "0x13F4390")]
				get
				{
					return default(Type);
				}
				[Token(Token = "0x6000D69")]
				[Address(RVA = "0x13F4398", Offset = "0x13F4398", VA = "0x13F4398")]
				set
				{
				}
			}

			[Token(Token = "0x170000FC")]
			public bool randomOrder
			{
				[Token(Token = "0x6000D6A")]
				[Address(RVA = "0x13F43B0", Offset = "0x13F43B0", VA = "0x13F43B0")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000D6B")]
				[Address(RVA = "0x13F43B8", Offset = "0x13F43B8", VA = "0x13F43B8")]
				set
				{
				}
			}

			[Token(Token = "0x170000FD")]
			public int randomSeed
			{
				[Token(Token = "0x6000D6C")]
				[Address(RVA = "0x13F43DC", Offset = "0x13F43DC", VA = "0x13F43DC")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6000D6D")]
				[Address(RVA = "0x13F43E4", Offset = "0x13F43E4", VA = "0x13F43E4")]
				set
				{
				}
			}

			[Token(Token = "0x170000FE")]
			public int count
			{
				[Token(Token = "0x6000D6E")]
				[Address(RVA = "0x13F4404", Offset = "0x13F4404", VA = "0x13F4404")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6000D6F")]
				[Address(RVA = "0x13F440C", Offset = "0x13F440C", VA = "0x13F440C")]
				set
				{
				}
			}

			[Token(Token = "0x170000FF")]
			public UVOverride overrideUVs
			{
				[Token(Token = "0x6000D70")]
				[Address(RVA = "0x13F442C", Offset = "0x13F442C", VA = "0x13F442C")]
				get
				{
					return default(UVOverride);
				}
				[Token(Token = "0x6000D71")]
				[Address(RVA = "0x13F4434", Offset = "0x13F4434", VA = "0x13F4434")]
				set
				{
				}
			}

			[Token(Token = "0x17000100")]
			public Vector2 uvOffset
			{
				[Token(Token = "0x6000D72")]
				[Address(RVA = "0x13F444C", Offset = "0x13F444C", VA = "0x13F444C")]
				get
				{
					return default(Vector2);
				}
				[Token(Token = "0x6000D73")]
				[Address(RVA = "0x13F4454", Offset = "0x13F4454", VA = "0x13F4454")]
				set
				{
				}
			}

			[Token(Token = "0x17000101")]
			public Vector2 uvScale
			{
				[Token(Token = "0x6000D74")]
				[Address(RVA = "0x13F4508", Offset = "0x13F4508", VA = "0x13F4508")]
				get
				{
					return default(Vector2);
				}
				[Token(Token = "0x6000D75")]
				[Address(RVA = "0x13F4510", Offset = "0x13F4510", VA = "0x13F4510")]
				set
				{
				}
			}

			[Token(Token = "0x17000102")]
			public bool overrideNormal
			{
				[Token(Token = "0x6000D76")]
				[Address(RVA = "0x13F45C4", Offset = "0x13F45C4", VA = "0x13F45C4")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000D77")]
				[Address(RVA = "0x13F45CC", Offset = "0x13F45CC", VA = "0x13F45CC")]
				set
				{
				}
			}

			[Token(Token = "0x17000103")]
			public Vector3 customNormal
			{
				[Token(Token = "0x6000D78")]
				[Address(RVA = "0x13F45F0", Offset = "0x13F45F0", VA = "0x13F45F0")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000D79")]
				[Address(RVA = "0x13F45FC", Offset = "0x13F45FC", VA = "0x13F45FC")]
				set
				{
				}
			}

			[Token(Token = "0x6000D7A")]
			[Address(RVA = "0x13F1020", Offset = "0x13F1020", VA = "0x13F1020")]
			public Channel(string n, SplineMesh parent)
			{
			}

			[Token(Token = "0x6000D7B")]
			[Address(RVA = "0x13F0E58", Offset = "0x13F0E58", VA = "0x13F0E58")]
			public Channel(string n, Mesh inputMesh, SplineMesh parent)
			{
			}

			[Token(Token = "0x6000D7C")]
			[Address(RVA = "0x13F46D0", Offset = "0x13F46D0", VA = "0x13F46D0")]
			private void Init()
			{
			}

			[Token(Token = "0x6000D7D")]
			[Address(RVA = "0x13F4A24", Offset = "0x13F4A24", VA = "0x13F4A24")]
			public void CopyTo(Channel target)
			{
			}

			[Token(Token = "0x6000D7E")]
			[Address(RVA = "0x13F1A1C", Offset = "0x13F1A1C", VA = "0x13F1A1C")]
			public int GetMeshCount()
			{
				return default(int);
			}

			[Token(Token = "0x6000D7F")]
			[Address(RVA = "0x13F505C", Offset = "0x13F505C", VA = "0x13F505C")]
			public void SwapMeshes(int a, int b)
			{
			}

			[Token(Token = "0x6000D80")]
			[Address(RVA = "0x13F517C", Offset = "0x13F517C", VA = "0x13F517C")]
			public void DuplicateMesh(int index)
			{
			}

			[Token(Token = "0x6000D81")]
			[Address(RVA = "0x13F5230", Offset = "0x13F5230", VA = "0x13F5230")]
			public MeshDefinition GetMesh(int index)
			{
				return null;
			}

			[Token(Token = "0x6000D82")]
			[Address(RVA = "0x13F52A8", Offset = "0x13F52A8", VA = "0x13F52A8")]
			public void AddMesh(Mesh input)
			{
			}

			[Token(Token = "0x6000D83")]
			[Address(RVA = "0x13F5338", Offset = "0x13F5338", VA = "0x13F5338")]
			public void RemoveMesh(int index)
			{
			}

			[Token(Token = "0x6000D84")]
			[Address(RVA = "0x13F1A6C", Offset = "0x13F1A6C", VA = "0x13F1A6C")]
			public void ResetIteration()
			{
			}

			[Token(Token = "0x6000D85")]
			[Address(RVA = "0x13F324C", Offset = "0x13F324C", VA = "0x13F324C")]
			public Vector2 NextOffset(double percent)
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000D86")]
			[Address(RVA = "0x13F337C", Offset = "0x13F337C", VA = "0x13F337C")]
			public Quaternion NextPlaceRotation(double percent)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000D87")]
			[Address(RVA = "0x13F3924", Offset = "0x13F3924", VA = "0x13F3924")]
			public float NextExtrudeRotation(double percent)
			{
				return default(float);
			}

			[Token(Token = "0x6000D88")]
			[Address(RVA = "0x13F3734", Offset = "0x13F3734", VA = "0x13F3734")]
			public Vector3 NextExtrudeScale(double percent)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000D89")]
			[Address(RVA = "0x13F3538", Offset = "0x13F3538", VA = "0x13F3538")]
			public Vector3 NextPlaceScale()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000D8A")]
			[Address(RVA = "0x13F2AB0", Offset = "0x13F2AB0", VA = "0x13F2AB0")]
			public MeshDefinition NextMesh()
			{
				return null;
			}

			[Token(Token = "0x6000D8B")]
			[Address(RVA = "0x13F3B04", Offset = "0x13F3B04", VA = "0x13F3B04")]
			internal void Rebuild()
			{
			}

			[Token(Token = "0x6000D8C")]
			[Address(RVA = "0x13F5D50", Offset = "0x13F5D50", VA = "0x13F5D50")]
			private void Refresh()
			{
			}
		}

		[Token(Token = "0x40007CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		[SerializeField]
		[HideInInspector]
		private List<Channel> channels;

		[Token(Token = "0x40007CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private SplineResult lastResult;

		[Token(Token = "0x40007CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private bool useLastResult;

		[Token(Token = "0x40007D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private List<TS_Mesh> combineMeshes;

		[Token(Token = "0x40007D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private int meshCount;

		[Token(Token = "0x40007D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
		private Matrix4x4 vertexMatrix;

		[Token(Token = "0x40007D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x194")]
		private Matrix4x4 normalMatrix;

		[Token(Token = "0x6000A3D")]
		[Address(RVA = "0x13F0AC4", Offset = "0x13F0AC4", VA = "0x13F0AC4", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000A3E")]
		[Address(RVA = "0x13F0B2C", Offset = "0x13F0B2C", VA = "0x13F0B2C", Slot = "5")]
		protected override void Reset()
		{
		}

		[Token(Token = "0x6000A3F")]
		[Address(RVA = "0x13F0C18", Offset = "0x13F0C18", VA = "0x13F0C18")]
		public void RemoveChannel(int index)
		{
		}

		[Token(Token = "0x6000A40")]
		[Address(RVA = "0x13F0C94", Offset = "0x13F0C94", VA = "0x13F0C94")]
		public void SwapChannels(int a, int b)
		{
		}

		[Token(Token = "0x6000A41")]
		[Address(RVA = "0x13F0DC0", Offset = "0x13F0DC0", VA = "0x13F0DC0")]
		public Channel AddChannel(Mesh inputMesh, string name)
		{
			return null;
		}

		[Token(Token = "0x6000A42")]
		[Address(RVA = "0x13F0B88", Offset = "0x13F0B88", VA = "0x13F0B88")]
		public Channel AddChannel(string name)
		{
			return null;
		}

		[Token(Token = "0x6000A43")]
		[Address(RVA = "0x13F1194", Offset = "0x13F1194", VA = "0x13F1194")]
		public int GetChannelCount()
		{
			return default(int);
		}

		[Token(Token = "0x6000A44")]
		[Address(RVA = "0x13F11E4", Offset = "0x13F11E4", VA = "0x13F11E4")]
		public Channel GetChannel(int index)
		{
			return null;
		}

		[Token(Token = "0x6000A45")]
		[Address(RVA = "0x13F125C", Offset = "0x13F125C", VA = "0x13F125C", Slot = "29")]
		protected override void BuildMesh()
		{
		}

		[Token(Token = "0x6000A46")]
		[Address(RVA = "0x13F12AC", Offset = "0x13F12AC", VA = "0x13F12AC")]
		private void Generate()
		{
		}

		[Token(Token = "0x6000A47")]
		[Address(RVA = "0x13F2464", Offset = "0x13F2464", VA = "0x13F2464")]
		private void Place(Channel channel, TS_Mesh target, double percent)
		{
		}

		[Token(Token = "0x6000A48")]
		[Address(RVA = "0x13F1B78", Offset = "0x13F1B78", VA = "0x13F1B78")]
		private void Stretch(Channel channel, TS_Mesh target, double from, double to)
		{
		}

		[Token(Token = "0x6000A49")]
		[Address(RVA = "0x13F3A0C", Offset = "0x13F3A0C", VA = "0x13F3A0C")]
		public SplineMesh()
		{
		}
	}
	[Token(Token = "0x2000164")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8317D4", Offset = "0x8317D4")]
	public class SplinePositioner : SplineTracer
	{
		[Token(Token = "0x20001E7")]
		public enum Mode
		{
			[Token(Token = "0x4000A9B")]
			Percent,
			[Token(Token = "0x4000A9C")]
			Distance
		}

		[Token(Token = "0x40007D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[SerializeField]
		[HideInInspector]
		private Transform _applyTransform;

		[Token(Token = "0x40007D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[SerializeField]
		[HideInInspector]
		private GameObject _targetObject;

		[Token(Token = "0x40007D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[SerializeField]
		[HideInInspector]
		private double _position;

		[Token(Token = "0x40007D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		[SerializeField]
		[HideInInspector]
		private float animPosition;

		[Token(Token = "0x40007D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		[SerializeField]
		[HideInInspector]
		private Mode _mode;

		[Token(Token = "0x17000074")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x837554", Offset = "0x837554")]
		public Transform applyTransform
		{
			[Token(Token = "0x6000A4A")]
			[Address(RVA = "0x13F96F0", Offset = "0x13F96F0", VA = "0x13F96F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A4B")]
			[Address(RVA = "0x13F97F8", Offset = "0x13F97F8", VA = "0x13F97F8")]
			set
			{
			}
		}

		[Token(Token = "0x17000075")]
		public GameObject targetObject
		{
			[Token(Token = "0x6000A4C")]
			[Address(RVA = "0x13F9710", Offset = "0x13F9710", VA = "0x13F9710")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A4D")]
			[Address(RVA = "0x13F98A0", Offset = "0x13F98A0", VA = "0x13F98A0")]
			set
			{
			}
		}

		[Token(Token = "0x17000076")]
		public double position
		{
			[Token(Token = "0x6000A4E")]
			[Address(RVA = "0x13F9954", Offset = "0x13F9954", VA = "0x13F9954")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x6000A4F")]
			[Address(RVA = "0x13F995C", Offset = "0x13F995C", VA = "0x13F995C")]
			set
			{
			}
		}

		[Token(Token = "0x17000077")]
		public Mode mode
		{
			[Token(Token = "0x6000A50")]
			[Address(RVA = "0x13F99AC", Offset = "0x13F99AC", VA = "0x13F99AC")]
			get
			{
				return default(Mode);
			}
			[Token(Token = "0x6000A51")]
			[Address(RVA = "0x13F99B4", Offset = "0x13F99B4", VA = "0x13F99B4")]
			set
			{
			}
		}

		[Token(Token = "0x17000078")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x83758C", Offset = "0x83758C")]
		public SplineResult positionResult
		{
			[Token(Token = "0x6000A52")]
			[Address(RVA = "0x13F99D8", Offset = "0x13F99D8", VA = "0x13F99D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000079")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x8375C4", Offset = "0x8375C4")]
		public SplineResult offsettedPositionResult
		{
			[Token(Token = "0x6000A53")]
			[Address(RVA = "0x13F99E0", Offset = "0x13F99E0", VA = "0x13F99E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000A54")]
		[Address(RVA = "0x13F99E8", Offset = "0x13F99E8", VA = "0x13F99E8", Slot = "10")]
		protected override void OnDidApplyAnimationProperties()
		{
		}

		[Token(Token = "0x6000A55")]
		[Address(RVA = "0x13F9A28", Offset = "0x13F9A28", VA = "0x13F9A28", Slot = "34")]
		protected override Transform GetTransform()
		{
			return null;
		}

		[Token(Token = "0x6000A56")]
		[Address(RVA = "0x13F9A48", Offset = "0x13F9A48", VA = "0x13F9A48", Slot = "32")]
		protected override Rigidbody GetRigidbody()
		{
			return null;
		}

		[Token(Token = "0x6000A57")]
		[Address(RVA = "0x13F9AA4", Offset = "0x13F9AA4", VA = "0x13F9AA4", Slot = "33")]
		protected override Rigidbody2D GetRigidbody2D()
		{
			return null;
		}

		[Token(Token = "0x6000A58")]
		[Address(RVA = "0x13F9B00", Offset = "0x13F9B00", VA = "0x13F9B00", Slot = "21")]
		protected override void PostBuild()
		{
		}

		[Token(Token = "0x6000A59")]
		[Address(RVA = "0x13F9B6C", Offset = "0x13F9B6C", VA = "0x13F9B6C", Slot = "30")]
		public override void SetPercent(double percent, bool checkTriggers = false)
		{
		}

		[Token(Token = "0x6000A5A")]
		[Address(RVA = "0x13F9BA4", Offset = "0x13F9BA4", VA = "0x13F9BA4", Slot = "31")]
		public override void SetDistance(float distance, bool checkTriggers = false)
		{
		}

		[Token(Token = "0x6000A5B")]
		[Address(RVA = "0x13F9BE0", Offset = "0x13F9BE0", VA = "0x13F9BE0")]
		public SplinePositioner()
		{
		}
	}
	[Token(Token = "0x2000165")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x83180C", Offset = "0x83180C")]
	public class SplineProjector : SplineTracer
	{
		[Token(Token = "0x20001E8")]
		public enum Mode
		{
			[Token(Token = "0x4000A9E")]
			Accurate,
			[Token(Token = "0x4000A9F")]
			Cached
		}

		[Token(Token = "0x40007D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[SerializeField]
		[HideInInspector]
		private Mode _mode;

		[Token(Token = "0x40007DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		[SerializeField]
		[HideInInspector]
		private bool _autoProject;

		[Token(Token = "0x40007DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[SerializeField]
		[HideInInspector]
		private int _subdivide;

		[Token(Token = "0x40007DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[SerializeField]
		[HideInInspector]
		private Transform _projectTarget;

		[Token(Token = "0x40007DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		[SerializeField]
		[HideInInspector]
		private Transform applyTarget;

		[Token(Token = "0x40007DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		[SerializeField]
		[HideInInspector]
		private GameObject _targetObject;

		[Token(Token = "0x40007DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		[SerializeField]
		[HideInInspector]
		private TS_Transform finalTarget;

		[Token(Token = "0x40007E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private double traceFromA;

		[Token(Token = "0x40007E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private double traceToA;

		[Token(Token = "0x40007E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private double traceFromB;

		[Token(Token = "0x40007E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		[SerializeField]
		[HideInInspector]
		public Vector2 _offset;

		[Token(Token = "0x40007E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		[SerializeField]
		[HideInInspector]
		public Vector3 _rotationOffset;

		[Token(Token = "0x1700007A")]
		public Mode mode
		{
			[Token(Token = "0x6000A5C")]
			[Address(RVA = "0x13F9BE8", Offset = "0x13F9BE8", VA = "0x13F9BE8")]
			get
			{
				return default(Mode);
			}
			[Token(Token = "0x6000A5D")]
			[Address(RVA = "0x13F9BF0", Offset = "0x13F9BF0", VA = "0x13F9BF0")]
			set
			{
			}
		}

		[Token(Token = "0x1700007B")]
		public bool autoProject
		{
			[Token(Token = "0x6000A5E")]
			[Address(RVA = "0x13F9C14", Offset = "0x13F9C14", VA = "0x13F9C14")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A5F")]
			[Address(RVA = "0x13F9C1C", Offset = "0x13F9C1C", VA = "0x13F9C1C")]
			set
			{
			}
		}

		[Token(Token = "0x1700007C")]
		public int subdivide
		{
			[Token(Token = "0x6000A60")]
			[Address(RVA = "0x13F9C50", Offset = "0x13F9C50", VA = "0x13F9C50")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000A61")]
			[Address(RVA = "0x13F9C58", Offset = "0x13F9C58", VA = "0x13F9C58")]
			set
			{
			}
		}

		[Token(Token = "0x1700007D")]
		public Transform projectTarget
		{
			[Token(Token = "0x6000A62")]
			[Address(RVA = "0x13F9C84", Offset = "0x13F9C84", VA = "0x13F9C84")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A63")]
			[Address(RVA = "0x13F9D14", Offset = "0x13F9D14", VA = "0x13F9D14")]
			set
			{
			}
		}

		[Token(Token = "0x1700007E")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x8375FC", Offset = "0x8375FC")]
		public Transform target
		{
			[Token(Token = "0x6000A64")]
			[Address(RVA = "0x13F9DE0", Offset = "0x13F9DE0", VA = "0x13F9DE0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A65")]
			[Address(RVA = "0x13F9ED0", Offset = "0x13F9ED0", VA = "0x13F9ED0")]
			set
			{
			}
		}

		[Token(Token = "0x1700007F")]
		public GameObject targetObject
		{
			[Token(Token = "0x6000A66")]
			[Address(RVA = "0x13F9E00", Offset = "0x13F9E00", VA = "0x13F9E00")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A67")]
			[Address(RVA = "0x13F9F78", Offset = "0x13F9F78", VA = "0x13F9F78")]
			set
			{
			}
		}

		[Token(Token = "0x17000080")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x837634", Offset = "0x837634")]
		public SplineResult projectResult
		{
			[Token(Token = "0x6000A68")]
			[Address(RVA = "0x13FA02C", Offset = "0x13FA02C", VA = "0x13FA02C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000005")]
		public event SplineReachHandler onEndReached
		{
			[Token(Token = "0x6000A69")]
			[Address(RVA = "0x13FA034", Offset = "0x13FA034", VA = "0x13FA034")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x835FF4", Offset = "0x835FF4")]
			add
			{
			}
			[Token(Token = "0x6000A6A")]
			[Address(RVA = "0x13FA0DC", Offset = "0x13FA0DC", VA = "0x13FA0DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x836004", Offset = "0x836004")]
			remove
			{
			}
		}

		[Token(Token = "0x14000006")]
		public event SplineReachHandler onBeginningReached
		{
			[Token(Token = "0x6000A6B")]
			[Address(RVA = "0x13FA184", Offset = "0x13FA184", VA = "0x13FA184")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x836014", Offset = "0x836014")]
			add
			{
			}
			[Token(Token = "0x6000A6C")]
			[Address(RVA = "0x13FA22C", Offset = "0x13FA22C", VA = "0x13FA22C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x836024", Offset = "0x836024")]
			remove
			{
			}
		}

		[Token(Token = "0x6000A6D")]
		[Address(RVA = "0x13FA2D4", Offset = "0x13FA2D4", VA = "0x13FA2D4", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000A6E")]
		[Address(RVA = "0x13FA3C8", Offset = "0x13FA3C8", VA = "0x13FA3C8", Slot = "34")]
		protected override Transform GetTransform()
		{
			return null;
		}

		[Token(Token = "0x6000A6F")]
		[Address(RVA = "0x13FA470", Offset = "0x13FA470", VA = "0x13FA470", Slot = "32")]
		protected override Rigidbody GetRigidbody()
		{
			return null;
		}

		[Token(Token = "0x6000A70")]
		[Address(RVA = "0x13FA51C", Offset = "0x13FA51C", VA = "0x13FA51C", Slot = "33")]
		protected override Rigidbody2D GetRigidbody2D()
		{
			return null;
		}

		[Token(Token = "0x6000A71")]
		[Address(RVA = "0x13FA2FC", Offset = "0x13FA2FC", VA = "0x13FA2FC")]
		private void GetProjectTarget()
		{
		}

		[Token(Token = "0x6000A72")]
		[Address(RVA = "0x13FA5C8", Offset = "0x13FA5C8", VA = "0x13FA5C8", Slot = "19")]
		protected override void LateRun()
		{
		}

		[Token(Token = "0x6000A73")]
		[Address(RVA = "0x13FA6A8", Offset = "0x13FA6A8", VA = "0x13FA6A8", Slot = "21")]
		protected override void PostBuild()
		{
		}

		[Token(Token = "0x6000A74")]
		[Address(RVA = "0x13FA980", Offset = "0x13FA980", VA = "0x13FA980")]
		private void CheckTriggers()
		{
		}

		[Token(Token = "0x6000A75")]
		[Address(RVA = "0x13FAA94", Offset = "0x13FAA94", VA = "0x13FAA94")]
		public void CalculateProjection()
		{
		}

		[Token(Token = "0x6000A76")]
		[Address(RVA = "0x13FA75C", Offset = "0x13FA75C", VA = "0x13FA75C")]
		private void InternalCalculateProjection()
		{
		}

		[Token(Token = "0x6000A77")]
		[Address(RVA = "0x13FAAD4", Offset = "0x13FAAD4", VA = "0x13FAAD4")]
		public SplineProjector()
		{
		}
	}
	[Token(Token = "0x2000166")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x831844", Offset = "0x831844")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x831844", Offset = "0x831844")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x831844", Offset = "0x831844")]
	[ExecuteInEditMode]
	public class SplineRenderer : MeshGenerator
	{
		[Token(Token = "0x40007E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		[HideInInspector]
		public bool autoOrient;

		[Token(Token = "0x40007E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		[HideInInspector]
		public int updateFrameInterval;

		[Token(Token = "0x40007E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private int currentFrame;

		[Token(Token = "0x40007EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		[SerializeField]
		[HideInInspector]
		private int _slices;

		[Token(Token = "0x40007EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		[SerializeField]
		[HideInInspector]
		private Vector3 vertexDirection;

		[Token(Token = "0x40007EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		private bool orthographic;

		[Token(Token = "0x40007ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14D")]
		private bool init;

		[Token(Token = "0x17000081")]
		public int slices
		{
			[Token(Token = "0x6000A78")]
			[Address(RVA = "0x1569B9C", Offset = "0x1569B9C", VA = "0x1569B9C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000A79")]
			[Address(RVA = "0x1569BA4", Offset = "0x1569BA4", VA = "0x1569BA4")]
			set
			{
			}
		}

		[Token(Token = "0x6000A7A")]
		[Address(RVA = "0x1569BD0", Offset = "0x1569BD0", VA = "0x1569BD0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000A7B")]
		[Address(RVA = "0x1569C38", Offset = "0x1569C38", VA = "0x1569C38")]
		private void Start()
		{
		}

		[Token(Token = "0x6000A7C")]
		[Address(RVA = "0x1569CDC", Offset = "0x1569CDC", VA = "0x1569CDC", Slot = "19")]
		protected override void LateRun()
		{
		}

		[Token(Token = "0x6000A7D")]
		[Address(RVA = "0x1569D00", Offset = "0x1569D00", VA = "0x1569D00", Slot = "29")]
		protected override void BuildMesh()
		{
		}

		[Token(Token = "0x6000A7E")]
		[Address(RVA = "0x156A6A0", Offset = "0x156A6A0", VA = "0x156A6A0")]
		public void RenderWithCamera(Camera cam)
		{
		}

		[Token(Token = "0x6000A7F")]
		[Address(RVA = "0x156A858", Offset = "0x156A858", VA = "0x156A858")]
		private void OnWillRenderObject()
		{
		}

		[Token(Token = "0x6000A80")]
		[Address(RVA = "0x1569DD0", Offset = "0x1569DD0", VA = "0x1569DD0")]
		public void GenerateVertices(Vector3 vertexDirection, bool orthoGraphic)
		{
		}

		[Token(Token = "0x6000A81")]
		[Address(RVA = "0x156A8D8", Offset = "0x156A8D8", VA = "0x156A8D8")]
		public SplineRenderer()
		{
		}
	}
	[Token(Token = "0x2000167")]
	public class SplineTracer : SplineUser
	{
		[Token(Token = "0x20001E9")]
		public enum PhysicsMode
		{
			[Token(Token = "0x4000AA1")]
			Transform,
			[Token(Token = "0x4000AA2")]
			Rigidbody,
			[Token(Token = "0x4000AA3")]
			Rigidbody2D
		}

		[Token(Token = "0x40007EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Trigger[] triggerInvokeQueue;

		[Token(Token = "0x40007EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private int addTriggerIndex;

		[Token(Token = "0x40007F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[HideInInspector]
		public bool applyDirectionRotation;

		[Token(Token = "0x40007F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[HideInInspector]
		protected Spline.Direction _direction;

		[Token(Token = "0x40007F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		[SerializeField]
		[HideInInspector]
		protected PhysicsMode _physicsMode;

		[Token(Token = "0x40007F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[HideInInspector]
		protected TransformModule _motion;

		[Token(Token = "0x40007F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[HideInInspector]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x833E90", Offset = "0x833E90")]
		protected SplineTrigger[] triggers_old;

		[Token(Token = "0x40007F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[HideInInspector]
		public Trigger[] triggers;

		[Token(Token = "0x40007F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[HideInInspector]
		protected CustomRotationModule _customRotations;

		[Token(Token = "0x40007F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[SerializeField]
		[HideInInspector]
		protected CustomOffsetModule _customOffsets;

		[Token(Token = "0x40007F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[SerializeField]
		[HideInInspector]
		protected Rigidbody targetRigidbody;

		[Token(Token = "0x40007F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[SerializeField]
		[HideInInspector]
		protected Rigidbody2D targetRigidbody2D;

		[Token(Token = "0x40007FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[SerializeField]
		[HideInInspector]
		protected Transform targetTransform;

		[Token(Token = "0x40007FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[SerializeField]
		[HideInInspector]
		protected SplineResult _result;

		[Token(Token = "0x40007FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private bool setPercentOnRebuild;

		[Token(Token = "0x40007FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private double targetPercentOnRebuild;

		[Token(Token = "0x17000082")]
		public PhysicsMode physicsMode
		{
			[Token(Token = "0x6000A82")]
			[Address(RVA = "0x156B4C8", Offset = "0x156B4C8", VA = "0x156B4C8")]
			get
			{
				return default(PhysicsMode);
			}
			[Token(Token = "0x6000A83")]
			[Address(RVA = "0x156B4D0", Offset = "0x156B4D0", VA = "0x156B4D0")]
			set
			{
			}
		}

		[Token(Token = "0x17000083")]
		public TransformModule motion
		{
			[Token(Token = "0x6000A84")]
			[Address(RVA = "0x156B55C", Offset = "0x156B55C", VA = "0x156B55C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000084")]
		public CustomRotationModule customRotations
		{
			[Token(Token = "0x6000A85")]
			[Address(RVA = "0x156B668", Offset = "0x156B668", VA = "0x156B668")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000085")]
		public CustomOffsetModule customOffsets
		{
			[Token(Token = "0x6000A86")]
			[Address(RVA = "0x156B6D4", Offset = "0x156B6D4", VA = "0x156B6D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000086")]
		public SplineResult result
		{
			[Token(Token = "0x6000A87")]
			[Address(RVA = "0x156B740", Offset = "0x156B740", VA = "0x156B740")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000087")]
		public SplineResult offsettedResult
		{
			[Token(Token = "0x6000A88")]
			[Address(RVA = "0x156B748", Offset = "0x156B748", VA = "0x156B748")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000088")]
		public Spline.Direction direction
		{
			[Token(Token = "0x6000A89")]
			[Address(RVA = "0x156BAD8", Offset = "0x156BAD8", VA = "0x156BAD8")]
			get
			{
				return default(Spline.Direction);
			}
			[Token(Token = "0x6000A8A")]
			[Address(RVA = "0x156BAE0", Offset = "0x156BAE0", VA = "0x156BAE0")]
			set
			{
			}
		}

		[Token(Token = "0x17000089")]
		public double clampedPercent
		{
			[Token(Token = "0x6000A8B")]
			[Address(RVA = "0x156BE08", Offset = "0x156BE08", VA = "0x156BE08")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x1700008A")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x83766C", Offset = "0x83766C")]
		public bool applyPosition
		{
			[Token(Token = "0x6000A8C")]
			[Address(RVA = "0x156BE68", Offset = "0x156BE68", VA = "0x156BE68")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A8D")]
			[Address(RVA = "0x156BED0", Offset = "0x156BED0", VA = "0x156BED0")]
			set
			{
			}
		}

		[Token(Token = "0x1700008B")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x8376A4", Offset = "0x8376A4")]
		public bool applyRotation
		{
			[Token(Token = "0x6000A8E")]
			[Address(RVA = "0x156BF1C", Offset = "0x156BF1C", VA = "0x156BF1C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A8F")]
			[Address(RVA = "0x156BF84", Offset = "0x156BF84", VA = "0x156BF84")]
			set
			{
			}
		}

		[Token(Token = "0x1700008C")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x8376DC", Offset = "0x8376DC")]
		public bool applyScale
		{
			[Token(Token = "0x6000A90")]
			[Address(RVA = "0x156BFD0", Offset = "0x156BFD0", VA = "0x156BFD0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A91")]
			[Address(RVA = "0x156C038", Offset = "0x156C038", VA = "0x156C038")]
			set
			{
			}
		}

		[Token(Token = "0x1700008D")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x837714", Offset = "0x837714")]
		public Vector2 offset
		{
			[Token(Token = "0x6000A92")]
			[Address(RVA = "0x156C084", Offset = "0x156C084", VA = "0x156C084")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000A93")]
			[Address(RVA = "0x156C0A4", Offset = "0x156C0A4", VA = "0x156C0A4")]
			set
			{
			}
		}

		[Token(Token = "0x1700008E")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x83774C", Offset = "0x83774C")]
		public Vector3 rotationOffset
		{
			[Token(Token = "0x6000A94")]
			[Address(RVA = "0x156C1D8", Offset = "0x156C1D8", VA = "0x156C1D8")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000A95")]
			[Address(RVA = "0x156C1FC", Offset = "0x156C1FC", VA = "0x156C1FC")]
			set
			{
			}
		}

		[Token(Token = "0x6000A96")]
		[Address(RVA = "0x156C360", Offset = "0x156C360", VA = "0x156C360", Slot = "29")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000A97")]
		[Address(RVA = "0x156C364", Offset = "0x156C364", VA = "0x156C364")]
		public Node GetNextNode()
		{
			return null;
		}

		[Token(Token = "0x6000A98")]
		[Address(RVA = "0x156C550", Offset = "0x156C550", VA = "0x156C550")]
		public void GetCurrentComputer(out SplineComputer comp, out double percent, out Spline.Direction dir)
		{
		}

		[Token(Token = "0x6000A99")]
		[Address(RVA = "0x156C57C", Offset = "0x156C57C", VA = "0x156C57C")]
		public void ResetTriggers()
		{
		}

		[Token(Token = "0x6000A9A")]
		[Address(RVA = "0x156C5E0", Offset = "0x156C5E0", VA = "0x156C5E0", Slot = "30")]
		public virtual void SetPercent(double percent, bool checkTriggers = false)
		{
		}

		[Token(Token = "0x6000A9B")]
		[Address(RVA = "0x156C910", Offset = "0x156C910", VA = "0x156C910", Slot = "31")]
		public virtual void SetDistance(float distance, bool checkTriggers = false)
		{
		}

		[Token(Token = "0x6000A9C")]
		[Address(RVA = "0x156CD0C", Offset = "0x156CD0C", VA = "0x156CD0C", Slot = "21")]
		protected override void PostBuild()
		{
		}

		[Token(Token = "0x6000A9D")]
		[Address(RVA = "0x156CD4C", Offset = "0x156CD4C", VA = "0x156CD4C", Slot = "13")]
		public override void EnterAddress(Node node, int pointIndex, Spline.Direction direction = Spline.Direction.Forward)
		{
		}

		[Token(Token = "0x6000A9E")]
		[Address(RVA = "0x156CEC0", Offset = "0x156CEC0", VA = "0x156CEC0", Slot = "14")]
		public override void AddComputer(SplineComputer computer, int connectionIndex, int connectedIndex, Spline.Direction direction = Spline.Direction.Forward)
		{
		}

		[Token(Token = "0x6000A9F")]
		[Address(RVA = "0x156D044", Offset = "0x156D044", VA = "0x156D044", Slot = "17")]
		public override void ExitAddress(int depth)
		{
		}

		[Token(Token = "0x6000AA0")]
		[Address(RVA = "0x156D184", Offset = "0x156D184", VA = "0x156D184", Slot = "32")]
		protected virtual Rigidbody GetRigidbody()
		{
			return null;
		}

		[Token(Token = "0x6000AA1")]
		[Address(RVA = "0x156D1D4", Offset = "0x156D1D4", VA = "0x156D1D4", Slot = "33")]
		protected virtual Rigidbody2D GetRigidbody2D()
		{
			return null;
		}

		[Token(Token = "0x6000AA2")]
		[Address(RVA = "0x156D224", Offset = "0x156D224", VA = "0x156D224", Slot = "34")]
		protected virtual Transform GetTransform()
		{
			return null;
		}

		[Token(Token = "0x6000AA3")]
		[Address(RVA = "0x156BAF8", Offset = "0x156BAF8", VA = "0x156BAF8")]
		protected void ApplyMotion()
		{
		}

		[Token(Token = "0x6000AA4")]
		[Address(RVA = "0x156C7F0", Offset = "0x156C7F0", VA = "0x156C7F0")]
		protected void CheckTriggers(double from, double to)
		{
		}

		[Token(Token = "0x6000AA5")]
		[Address(RVA = "0x156D7B4", Offset = "0x156D7B4", VA = "0x156D7B4")]
		protected void CheckTriggersClipped(double from, double to)
		{
		}

		[Token(Token = "0x6000AA6")]
		[Address(RVA = "0x156C89C", Offset = "0x156C89C", VA = "0x156C89C")]
		protected void InvokeTriggers()
		{
		}

		[Token(Token = "0x6000AA7")]
		[Address(RVA = "0x156D890", Offset = "0x156D890", VA = "0x156D890")]
		private bool MigrateTriggers()
		{
			return default(bool);
		}

		[Token(Token = "0x6000AA8")]
		[Address(RVA = "0x156B4D8", Offset = "0x156B4D8", VA = "0x156B4D8")]
		protected void RefreshTargets()
		{
		}

		[Token(Token = "0x6000AA9")]
		[Address(RVA = "0x156D6B0", Offset = "0x156D6B0", VA = "0x156D6B0")]
		private void AddTriggerToQueue(Trigger trigger)
		{
		}

		[Token(Token = "0x6000AAA")]
		[Address(RVA = "0x156DBE8", Offset = "0x156DBE8", VA = "0x156DBE8")]
		private void AddTrigger(Trigger trigger)
		{
		}

		[Token(Token = "0x6000AAB")]
		[Address(RVA = "0x156DCC8", Offset = "0x156DCC8", VA = "0x156DCC8")]
		public void AddTrigger(UnityAction call, double position = 0.0, Trigger.Type type = Trigger.Type.Double)
		{
		}

		[Token(Token = "0x6000AAC")]
		[Address(RVA = "0x156DDE8", Offset = "0x156DDE8", VA = "0x156DDE8")]
		public void AddTrigger(UnityAction<int> call, int value, double position = 0.0, Trigger.Type type = Trigger.Type.Double)
		{
		}

		[Token(Token = "0x6000AAD")]
		[Address(RVA = "0x156DF0C", Offset = "0x156DF0C", VA = "0x156DF0C")]
		public void AddTrigger(UnityAction<float> call, float value, double position = 0.0, Trigger.Type type = Trigger.Type.Double)
		{
		}

		[Token(Token = "0x6000AAE")]
		[Address(RVA = "0x156E030", Offset = "0x156E030", VA = "0x156E030")]
		public void AddTrigger(UnityAction<double> call, double value, double position = 0.0, Trigger.Type type = Trigger.Type.Double)
		{
		}

		[Token(Token = "0x6000AAF")]
		[Address(RVA = "0x156E154", Offset = "0x156E154", VA = "0x156E154")]
		public void AddTrigger(UnityAction<string> call, string value, double position = 0.0, Trigger.Type type = Trigger.Type.Double)
		{
		}

		[Token(Token = "0x6000AB0")]
		[Address(RVA = "0x156E278", Offset = "0x156E278", VA = "0x156E278")]
		public void AddTrigger(UnityAction<bool> call, bool value, double position = 0.0, Trigger.Type type = Trigger.Type.Double)
		{
		}

		[Token(Token = "0x6000AB1")]
		[Address(RVA = "0x156E39C", Offset = "0x156E39C", VA = "0x156E39C")]
		public void AddTrigger(UnityAction<GameObject> call, GameObject value, double position = 0.0, Trigger.Type type = Trigger.Type.Double)
		{
		}

		[Token(Token = "0x6000AB2")]
		[Address(RVA = "0x156E4C0", Offset = "0x156E4C0", VA = "0x156E4C0")]
		public void AddTrigger(UnityAction<Transform> call, Transform value, double position = 0.0, Trigger.Type type = Trigger.Type.Double)
		{
		}

		[Token(Token = "0x6000AB3")]
		[Address(RVA = "0x156CCC0", Offset = "0x156CCC0", VA = "0x156CCC0")]
		public void EvaluateClipped(SplineResult result, double clippedPercent)
		{
		}

		[Token(Token = "0x6000AB4")]
		[Address(RVA = "0x156E60C", Offset = "0x156E60C", VA = "0x156E60C")]
		public Vector3 EvaluatePositionClipped(double clippedPercent)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000AB5")]
		[Address(RVA = "0x156C9E0", Offset = "0x156C9E0", VA = "0x156C9E0")]
		public double TravelClipped(double start, float distance, Spline.Direction direction)
		{
			return default(double);
		}

		[Token(Token = "0x6000AB6")]
		[Address(RVA = "0x156E64C", Offset = "0x156E64C", VA = "0x156E64C")]
		public SplineResult ProjectClipped(Vector3 point)
		{
			return null;
		}

		[Token(Token = "0x6000AB7")]
		[Address(RVA = "0x156E660", Offset = "0x156E660", VA = "0x156E660")]
		public SplineTracer()
		{
		}
	}
	[Token(Token = "0x2000168")]
	public class SplineUser : MonoBehaviour
	{
		[Token(Token = "0x20001EA")]
		public enum UpdateMethod
		{
			[Token(Token = "0x4000AA5")]
			Update,
			[Token(Token = "0x4000AA6")]
			FixedUpdate,
			[Token(Token = "0x4000AA7")]
			LateUpdate
		}

		[Token(Token = "0x20001EB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x831CA4", Offset = "0x831CA4")]
		private sealed class <UpdateSubscribersRoutine>d__82 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000AA8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000AA9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000AAA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SplineUser <>4__this;

			[Token(Token = "0x17000104")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000D90")]
				[Address(RVA = "0x15740EC", Offset = "0x15740EC", VA = "0x15740EC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000105")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000D92")]
				[Address(RVA = "0x1574154", Offset = "0x1574154", VA = "0x1574154", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000D8D")]
			[Address(RVA = "0x157078C", Offset = "0x157078C", VA = "0x157078C")]
			[DebuggerHidden]
			public <UpdateSubscribersRoutine>d__82(int <>1__state)
			{
			}

			[Token(Token = "0x6000D8E")]
			[Address(RVA = "0x1574090", Offset = "0x1574090", VA = "0x1574090", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000D8F")]
			[Address(RVA = "0x1574094", Offset = "0x1574094", VA = "0x1574094", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000D91")]
			[Address(RVA = "0x15740F4", Offset = "0x15740F4", VA = "0x15740F4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40007FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public SplineAddress _address;

		[Token(Token = "0x40007FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[HideInInspector]
		private SplineUser[] subscribers;

		[Token(Token = "0x4000800")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public UpdateMethod updateMethod;

		[Token(Token = "0x4000801")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[HideInInspector]
		[SerializeField]
		private SplineUser _user;

		[Token(Token = "0x4000802")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		[HideInInspector]
		private double _resolution;

		[Token(Token = "0x4000803")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[HideInInspector]
		private double _clipTo;

		[Token(Token = "0x4000804")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		[HideInInspector]
		private double _clipFrom;

		[Token(Token = "0x4000805")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[HideInInspector]
		private bool _autoUpdate;

		[Token(Token = "0x4000806")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		[SerializeField]
		[HideInInspector]
		private bool _loopSamples;

		[Token(Token = "0x4000807")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x52")]
		[SerializeField]
		[HideInInspector]
		private bool _uniformSample;

		[Token(Token = "0x4000808")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x53")]
		[SerializeField]
		[HideInInspector]
		private bool _uniformPreserveClipRange;

		[Token(Token = "0x4000809")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		[HideInInspector]
		private SplineResult[] _samples;

		[Token(Token = "0x400080A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		[HideInInspector]
		private SplineResult[] _clippedSamples;

		[Token(Token = "0x400080B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		[HideInInspector]
		private float animClipFrom;

		[Token(Token = "0x400080C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		[HideInInspector]
		private float animClipTo;

		[Token(Token = "0x400080D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		[HideInInspector]
		private double animResolution;

		[Token(Token = "0x400080E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		[HideInInspector]
		protected bool sampleUser;

		[Token(Token = "0x400080F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x79")]
		private bool rebuild;

		[Token(Token = "0x4000810")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7A")]
		private bool sample;

		[Token(Token = "0x4000811")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7B")]
		private bool getClippedSamples;

		[Token(Token = "0x4000812")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		protected Transform trs;

		[Token(Token = "0x4000813")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[HideInInspector]
		public bool multithreaded;

		[Token(Token = "0x4000814")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
		[HideInInspector]
		public bool buildOnAwake;

		[Token(Token = "0x4000815")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8A")]
		[HideInInspector]
		public bool buildOnEnable;

		[Token(Token = "0x4000816")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Thread buildThread;

		[Token(Token = "0x4000817")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool postThread;

		[Token(Token = "0x4000818")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x99")]
		private bool threadSample;

		[Token(Token = "0x4000819")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9A")]
		private bool threadWork;

		[Token(Token = "0x400081A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9B")]
		private bool _threadWorking;

		[Token(Token = "0x400081B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private object locker;

		[Token(Token = "0x1700008F")]
		public SplineUser user
		{
			[Token(Token = "0x6000AB8")]
			[Address(RVA = "0x156E894", Offset = "0x156E894", VA = "0x156E894")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AB9")]
			[Address(RVA = "0x156E89C", Offset = "0x156E89C", VA = "0x156E89C")]
			set
			{
			}
		}

		[Token(Token = "0x17000090")]
		public SplineUser rootUser
		{
			[Token(Token = "0x6000ABA")]
			[Address(RVA = "0x156EB3C", Offset = "0x156EB3C", VA = "0x156EB3C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000091")]
		public SplineComputer computer
		{
			[Token(Token = "0x6000ABB")]
			[Address(RVA = "0x156EC54", Offset = "0x156EC54", VA = "0x156EC54")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000ABC")]
			[Address(RVA = "0x156EC74", Offset = "0x156EC74", VA = "0x156EC74")]
			set
			{
			}
		}

		[Token(Token = "0x17000092")]
		public double resolution
		{
			[Token(Token = "0x6000ABD")]
			[Address(RVA = "0x156F320", Offset = "0x156F320", VA = "0x156F320")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x6000ABE")]
			[Address(RVA = "0x156F328", Offset = "0x156F328", VA = "0x156F328")]
			set
			{
			}
		}

		[Token(Token = "0x17000093")]
		public double clipFrom
		{
			[Token(Token = "0x6000ABF")]
			[Address(RVA = "0x156F360", Offset = "0x156F360", VA = "0x156F360")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x6000AC0")]
			[Address(RVA = "0x156F368", Offset = "0x156F368", VA = "0x156F368")]
			set
			{
			}
		}

		[Token(Token = "0x17000094")]
		public double clipTo
		{
			[Token(Token = "0x6000AC1")]
			[Address(RVA = "0x156F404", Offset = "0x156F404", VA = "0x156F404")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x6000AC2")]
			[Address(RVA = "0x156F40C", Offset = "0x156F40C", VA = "0x156F40C")]
			set
			{
			}
		}

		[Token(Token = "0x17000095")]
		public bool autoUpdate
		{
			[Token(Token = "0x6000AC3")]
			[Address(RVA = "0x156F4A8", Offset = "0x156F4A8", VA = "0x156F4A8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000AC4")]
			[Address(RVA = "0x156F4B0", Offset = "0x156F4B0", VA = "0x156F4B0")]
			set
			{
			}
		}

		[Token(Token = "0x17000096")]
		public bool loopSamples
		{
			[Token(Token = "0x6000AC5")]
			[Address(RVA = "0x156F4E4", Offset = "0x156F4E4", VA = "0x156F4E4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000AC6")]
			[Address(RVA = "0x156F4EC", Offset = "0x156F4EC", VA = "0x156F4EC")]
			set
			{
			}
		}

		[Token(Token = "0x17000097")]
		public bool uniformSample
		{
			[Token(Token = "0x6000AC7")]
			[Address(RVA = "0x156F520", Offset = "0x156F520", VA = "0x156F520")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000AC8")]
			[Address(RVA = "0x156F528", Offset = "0x156F528", VA = "0x156F528")]
			set
			{
			}
		}

		[Token(Token = "0x17000098")]
		public bool uniformPreserveClipRange
		{
			[Token(Token = "0x6000AC9")]
			[Address(RVA = "0x156F558", Offset = "0x156F558", VA = "0x156F558")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000ACA")]
			[Address(RVA = "0x156F560", Offset = "0x156F560", VA = "0x156F560")]
			set
			{
			}
		}

		[Token(Token = "0x17000099")]
		public double span
		{
			[Token(Token = "0x6000ACB")]
			[Address(RVA = "0x156F590", Offset = "0x156F590", VA = "0x156F590")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x1700009A")]
		public SplineAddress address
		{
			[Token(Token = "0x6000ACC")]
			[Address(RVA = "0x156F2B0", Offset = "0x156F2B0", VA = "0x156F2B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009B")]
		public bool samplesAreLooped
		{
			[Token(Token = "0x6000ACD")]
			[Address(RVA = "0x156F5D0", Offset = "0x156F5D0", VA = "0x156F5D0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700009C")]
		public SplineResult[] samples
		{
			[Token(Token = "0x6000ACE")]
			[Address(RVA = "0x156A834", Offset = "0x156A834", VA = "0x156A834")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009D")]
		public SplineResult[] clippedSamples
		{
			[Token(Token = "0x6000ACF")]
			[Address(RVA = "0x156A654", Offset = "0x156A654", VA = "0x156A654")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009E")]
		protected bool willRebuild
		{
			[Token(Token = "0x6000AD0")]
			[Address(RVA = "0x15701D4", Offset = "0x15701D4", VA = "0x15701D4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700009F")]
		public bool threadWorking
		{
			[Token(Token = "0x6000AD1")]
			[Address(RVA = "0x15701DC", Offset = "0x15701DC", VA = "0x15701DC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000AD2")]
		[Address(RVA = "0x15701E4", Offset = "0x15701E4", VA = "0x15701E4", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000AD3")]
		[Address(RVA = "0x1570400", Offset = "0x1570400", VA = "0x1570400", Slot = "5")]
		protected virtual void Reset()
		{
		}

		[Token(Token = "0x6000AD4")]
		[Address(RVA = "0x1570404", Offset = "0x1570404", VA = "0x1570404", Slot = "6")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x6000AD5")]
		[Address(RVA = "0x15704C8", Offset = "0x15704C8", VA = "0x15704C8", Slot = "7")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x6000AD6")]
		[Address(RVA = "0x1570570", Offset = "0x1570570", VA = "0x1570570", Slot = "8")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000AD7")]
		[Address(RVA = "0x15705B8", Offset = "0x15705B8", VA = "0x15705B8", Slot = "9")]
		protected virtual void OnApplicationQuit()
		{
		}

		[Token(Token = "0x6000AD8")]
		[Address(RVA = "0x1570600", Offset = "0x1570600", VA = "0x1570600", Slot = "10")]
		protected virtual void OnDidApplyAnimationProperties()
		{
		}

		[Token(Token = "0x6000AD9")]
		[Address(RVA = "0x15706A8", Offset = "0x15706A8", VA = "0x15706A8", Slot = "11")]
		public virtual void Rebuild(bool sampleComputer)
		{
		}

		[Token(Token = "0x6000ADA")]
		[Address(RVA = "0x157071C", Offset = "0x157071C", VA = "0x157071C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x836034", Offset = "0x836034")]
		private IEnumerator UpdateSubscribersRoutine()
		{
			return null;
		}

		[Token(Token = "0x6000ADB")]
		[Address(RVA = "0x15707B8", Offset = "0x15707B8", VA = "0x15707B8", Slot = "12")]
		public virtual void RebuildImmediate(bool sampleComputer)
		{
		}

		[Token(Token = "0x6000ADC")]
		[Address(RVA = "0x157102C", Offset = "0x157102C", VA = "0x157102C")]
		public void GetClippedSamplesImmediate()
		{
		}

		[Token(Token = "0x6000ADD")]
		[Address(RVA = "0x156CE0C", Offset = "0x156CE0C", VA = "0x156CE0C", Slot = "13")]
		public virtual void EnterAddress(Node node, int connectionIndex, Spline.Direction direction = Spline.Direction.Forward)
		{
		}

		[Token(Token = "0x6000ADE")]
		[Address(RVA = "0x156CF88", Offset = "0x156CF88", VA = "0x156CF88", Slot = "14")]
		public virtual void AddComputer(SplineComputer computer, int connectionIndex, int connectedIndex, Spline.Direction direction = Spline.Direction.Forward)
		{
		}

		[Token(Token = "0x6000ADF")]
		[Address(RVA = "0x1571060", Offset = "0x1571060", VA = "0x1571060", Slot = "15")]
		public virtual void CollapseAddress()
		{
		}

		[Token(Token = "0x6000AE0")]
		[Address(RVA = "0x15710B4", Offset = "0x15710B4", VA = "0x15710B4", Slot = "16")]
		public virtual void ClearAddress()
		{
		}

		[Token(Token = "0x6000AE1")]
		[Address(RVA = "0x156D0EC", Offset = "0x156D0EC", VA = "0x156D0EC", Slot = "17")]
		public virtual void ExitAddress(int depth)
		{
		}

		[Token(Token = "0x6000AE2")]
		[Address(RVA = "0x1571138", Offset = "0x1571138", VA = "0x1571138")]
		private void Update()
		{
		}

		[Token(Token = "0x6000AE3")]
		[Address(RVA = "0x157138C", Offset = "0x157138C", VA = "0x157138C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000AE4")]
		[Address(RVA = "0x15713A0", Offset = "0x15713A0", VA = "0x15713A0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000AE5")]
		[Address(RVA = "0x1570F10", Offset = "0x1570F10", VA = "0x1570F10")]
		private void UpdateSubscribers()
		{
		}

		[Token(Token = "0x6000AE6")]
		[Address(RVA = "0x1571148", Offset = "0x1571148", VA = "0x1571148")]
		private void RunMain()
		{
		}

		[Token(Token = "0x6000AE7")]
		[Address(RVA = "0x15714E0", Offset = "0x15714E0", VA = "0x15714E0")]
		private void RunThread()
		{
		}

		[Token(Token = "0x6000AE8")]
		[Address(RVA = "0x1571764", Offset = "0x1571764", VA = "0x1571764", Slot = "18")]
		protected virtual void Run()
		{
		}

		[Token(Token = "0x6000AE9")]
		[Address(RVA = "0x1571768", Offset = "0x1571768", VA = "0x1571768", Slot = "19")]
		protected virtual void LateRun()
		{
		}

		[Token(Token = "0x6000AEA")]
		[Address(RVA = "0x157176C", Offset = "0x157176C", VA = "0x157176C", Slot = "20")]
		protected virtual void Build()
		{
		}

		[Token(Token = "0x6000AEB")]
		[Address(RVA = "0x1571770", Offset = "0x1571770", VA = "0x1571770", Slot = "21")]
		protected virtual void PostBuild()
		{
		}

		[Token(Token = "0x6000AEC")]
		[Address(RVA = "0x1571774", Offset = "0x1571774", VA = "0x1571774")]
		public void SetClipRange(double from, double to)
		{
		}

		[Token(Token = "0x6000AED")]
		[Address(RVA = "0x15708A4", Offset = "0x15708A4", VA = "0x15708A4")]
		private void SampleComputer()
		{
		}

		[Token(Token = "0x6000AEE")]
		[Address(RVA = "0x156F69C", Offset = "0x156F69C", VA = "0x156F69C")]
		private void GetClippedSamples()
		{
		}

		[Token(Token = "0x6000AEF")]
		[Address(RVA = "0x1571804", Offset = "0x1571804", VA = "0x1571804", Slot = "22")]
		public virtual SplineResult Evaluate(double percent)
		{
			return null;
		}

		[Token(Token = "0x6000AF0")]
		[Address(RVA = "0x1571DAC", Offset = "0x1571DAC", VA = "0x1571DAC", Slot = "23")]
		public virtual void Evaluate(SplineResult result, double percent)
		{
		}

		[Token(Token = "0x6000AF1")]
		[Address(RVA = "0x157232C", Offset = "0x157232C", VA = "0x157232C", Slot = "24")]
		public virtual Vector3 EvaluatePosition(double percent, bool overrideUniformClipRange = false)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000AF2")]
		[Address(RVA = "0x156BE40", Offset = "0x156BE40", VA = "0x156BE40")]
		public double ClipPercent(double percent)
		{
			return default(double);
		}

		[Token(Token = "0x6000AF3")]
		[Address(RVA = "0x1572938", Offset = "0x1572938", VA = "0x1572938")]
		public void ClipPercent(ref double percent)
		{
		}

		[Token(Token = "0x6000AF4")]
		[Address(RVA = "0x156E5E4", Offset = "0x156E5E4", VA = "0x156E5E4")]
		public double UnclipPercent(double percent)
		{
			return default(double);
		}

		[Token(Token = "0x6000AF5")]
		[Address(RVA = "0x156C6A8", Offset = "0x156C6A8", VA = "0x156C6A8")]
		public void UnclipPercent(ref double percent)
		{
		}

		[Token(Token = "0x6000AF6")]
		[Address(RVA = "0x1571D6C", Offset = "0x1571D6C", VA = "0x1571D6C")]
		public int GetSampleIndex(double percent)
		{
			return default(int);
		}

		[Token(Token = "0x6000AF7")]
		[Address(RVA = "0x1572A84", Offset = "0x1572A84", VA = "0x1572A84")]
		public int GetClippedSampleIndex(double percent)
		{
			return default(int);
		}

		[Token(Token = "0x6000AF8")]
		[Address(RVA = "0x1572AC0", Offset = "0x1572AC0", VA = "0x1572AC0", Slot = "25")]
		public virtual SplineResult Project(Vector3 point, double from = 0.0, double to = 1.0)
		{
			return null;
		}

		[Token(Token = "0x6000AF9")]
		[Address(RVA = "0x1572B74", Offset = "0x1572B74", VA = "0x1572B74", Slot = "26")]
		public virtual void Project(SplineResult result, Vector3 point, double from = 0.0, double to = 1.0)
		{
		}

		[Token(Token = "0x6000AFA")]
		[Address(RVA = "0x1573ADC", Offset = "0x1573ADC", VA = "0x1573ADC", Slot = "27")]
		public virtual double Travel(double start, float distance, Spline.Direction direction)
		{
			return default(double);
		}

		[Token(Token = "0x6000AFB")]
		[Address(RVA = "0x156F0A8", Offset = "0x156F0A8", VA = "0x156F0A8")]
		private void Subscribe(SplineUser input)
		{
		}

		[Token(Token = "0x6000AFC")]
		[Address(RVA = "0x156EED0", Offset = "0x156EED0", VA = "0x156EED0")]
		private void Unsubscribe(SplineUser input)
		{
		}

		[Token(Token = "0x6000AFD")]
		[Address(RVA = "0x1573E44", Offset = "0x1573E44", VA = "0x1573E44", Slot = "28")]
		public virtual float CalculateLength(double from = 0.0, double to = 1.0)
		{
			return default(float);
		}

		[Token(Token = "0x6000AFE")]
		[Address(RVA = "0x15713B4", Offset = "0x15713B4", VA = "0x15713B4")]
		private void RemoveSubscriber(int index)
		{
		}

		[Token(Token = "0x6000AFF")]
		[Address(RVA = "0x1570328", Offset = "0x1570328", VA = "0x1570328")]
		private bool IsSubscribed(SplineUser user)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B00")]
		[Address(RVA = "0x156E74C", Offset = "0x156E74C", VA = "0x156E74C")]
		public SplineUser()
		{
		}
	}
	[Token(Token = "0x2000169")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x831904", Offset = "0x831904")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x831904", Offset = "0x831904")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x831904", Offset = "0x831904")]
	public class SurfaceGenerator : MeshGenerator
	{
		[Token(Token = "0x400081C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		[SerializeField]
		[HideInInspector]
		private float _expand;

		[Token(Token = "0x400081D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		[SerializeField]
		[HideInInspector]
		private float _extrude;

		[Token(Token = "0x400081E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		[SerializeField]
		[HideInInspector]
		private Vector2 _sideUvScale;

		[Token(Token = "0x400081F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		[SerializeField]
		[HideInInspector]
		private Vector2 _sideUvOffset;

		[Token(Token = "0x4000820")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		[SerializeField]
		[HideInInspector]
		private SplineComputer _extrudeComputer;

		[Token(Token = "0x4000821")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		[SerializeField]
		[HideInInspector]
		private SplineResult[] extrudeResults;

		[Token(Token = "0x4000822")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		[SerializeField]
		[HideInInspector]
		private Vector3[] identityVertices;

		[Token(Token = "0x4000823")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		[SerializeField]
		[HideInInspector]
		private Vector3[] identityNormals;

		[Token(Token = "0x4000824")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		[SerializeField]
		[HideInInspector]
		private Vector2[] projectedVerts;

		[Token(Token = "0x4000825")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		[SerializeField]
		[HideInInspector]
		private int[] capTris;

		[Token(Token = "0x4000826")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		[SerializeField]
		[HideInInspector]
		private int[] wallTris;

		[Token(Token = "0x4000827")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		[SerializeField]
		[HideInInspector]
		private double _extrudeFrom;

		[Token(Token = "0x4000828")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		[SerializeField]
		[HideInInspector]
		private double _extrudeTo;

		[Token(Token = "0x4000829")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		[SerializeField]
		[HideInInspector]
		private bool _uniformUvs;

		[Token(Token = "0x170000A0")]
		public float expand
		{
			[Token(Token = "0x6000B01")]
			[Address(RVA = "0x157415C", Offset = "0x157415C", VA = "0x157415C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000B02")]
			[Address(RVA = "0x1574164", Offset = "0x1574164", VA = "0x1574164")]
			set
			{
			}
		}

		[Token(Token = "0x170000A1")]
		public float extrude
		{
			[Token(Token = "0x6000B03")]
			[Address(RVA = "0x1574188", Offset = "0x1574188", VA = "0x1574188")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000B04")]
			[Address(RVA = "0x1574190", Offset = "0x1574190", VA = "0x1574190")]
			set
			{
			}
		}

		[Token(Token = "0x170000A2")]
		public double extrudeClipFrom
		{
			[Token(Token = "0x6000B05")]
			[Address(RVA = "0x15741B4", Offset = "0x15741B4", VA = "0x15741B4")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x6000B06")]
			[Address(RVA = "0x15741BC", Offset = "0x15741BC", VA = "0x15741BC")]
			set
			{
			}
		}

		[Token(Token = "0x170000A3")]
		public double extrudeClipTo
		{
			[Token(Token = "0x6000B07")]
			[Address(RVA = "0x15741E0", Offset = "0x15741E0", VA = "0x15741E0")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x6000B08")]
			[Address(RVA = "0x15741E8", Offset = "0x15741E8", VA = "0x15741E8")]
			set
			{
			}
		}

		[Token(Token = "0x170000A4")]
		public Vector2 sideUvScale
		{
			[Token(Token = "0x6000B09")]
			[Address(RVA = "0x157420C", Offset = "0x157420C", VA = "0x157420C")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000B0A")]
			[Address(RVA = "0x1574218", Offset = "0x1574218", VA = "0x1574218")]
			set
			{
			}
		}

		[Token(Token = "0x170000A5")]
		public Vector2 sideUvOffset
		{
			[Token(Token = "0x6000B0B")]
			[Address(RVA = "0x15742E0", Offset = "0x15742E0", VA = "0x15742E0")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000B0C")]
			[Address(RVA = "0x15742EC", Offset = "0x15742EC", VA = "0x15742EC")]
			set
			{
			}
		}

		[Token(Token = "0x170000A6")]
		public SplineComputer extrudeComputer
		{
			[Token(Token = "0x6000B0D")]
			[Address(RVA = "0x15743B4", Offset = "0x15743B4", VA = "0x15743B4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B0E")]
			[Address(RVA = "0x15743BC", Offset = "0x15743BC", VA = "0x15743BC")]
			set
			{
			}
		}

		[Token(Token = "0x170000A7")]
		public bool uniformUvs
		{
			[Token(Token = "0x6000B0F")]
			[Address(RVA = "0x15744EC", Offset = "0x15744EC", VA = "0x15744EC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000B10")]
			[Address(RVA = "0x15744F4", Offset = "0x15744F4", VA = "0x15744F4")]
			set
			{
			}
		}

		[Token(Token = "0x6000B11")]
		[Address(RVA = "0x1574524", Offset = "0x1574524", VA = "0x1574524", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000B12")]
		[Address(RVA = "0x157458C", Offset = "0x157458C", VA = "0x157458C", Slot = "29")]
		protected override void BuildMesh()
		{
		}

		[Token(Token = "0x6000B13")]
		[Address(RVA = "0x15745DC", Offset = "0x15745DC", VA = "0x15745DC")]
		public void Generate()
		{
		}

		[Token(Token = "0x6000B14")]
		[Address(RVA = "0x1576884", Offset = "0x1576884", VA = "0x1576884")]
		private void GenerateCapTris(bool flip)
		{
		}

		[Token(Token = "0x6000B15")]
		[Address(RVA = "0x1576D4C", Offset = "0x1576D4C", VA = "0x1576D4C")]
		private int WriteTris(ref int[] tris, ref int[] target, int vertexOffset, int trisOffset, bool flip)
		{
			return default(int);
		}

		[Token(Token = "0x6000B16")]
		[Address(RVA = "0x15767B8", Offset = "0x15767B8", VA = "0x15767B8")]
		private bool IsClockwise(Vector2[] points2D)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B17")]
		[Address(RVA = "0x157693C", Offset = "0x157693C", VA = "0x157693C")]
		private void GetIdentityVerts(Vector3 center, Vector3 normal, bool clockwise)
		{
		}

		[Token(Token = "0x6000B18")]
		[Address(RVA = "0x1576438", Offset = "0x1576438", VA = "0x1576438")]
		private void GetProjectedVertices(Vector3[] points, Vector3 normal, Vector3 center, int count = 0)
		{
		}

		[Token(Token = "0x6000B19")]
		[Address(RVA = "0x1576F20", Offset = "0x1576F20", VA = "0x1576F20")]
		public SurfaceGenerator()
		{
		}
	}
	[Token(Token = "0x200016A")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x8319B4", Offset = "0x8319B4")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x8319B4", Offset = "0x8319B4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8319B4", Offset = "0x8319B4")]
	public class TubeGenerator : MeshGenerator
	{
		[Token(Token = "0x20001EC")]
		public enum CapMethod
		{
			[Token(Token = "0x4000AAC")]
			None,
			[Token(Token = "0x4000AAD")]
			Flat,
			[Token(Token = "0x4000AAE")]
			Round
		}

		[Token(Token = "0x400082A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		[SerializeField]
		[HideInInspector]
		private int _sides;

		[Token(Token = "0x400082B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		[SerializeField]
		[HideInInspector]
		private int _roundCapLatitude;

		[Token(Token = "0x400082C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		[SerializeField]
		[HideInInspector]
		private CapMethod _capMode;

		[Token(Token = "0x400082D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		[SerializeField]
		[HideInInspector]
		private float _integrity;

		[Token(Token = "0x400082E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		[SerializeField]
		[HideInInspector]
		private float _capUVScale;

		[Token(Token = "0x400082F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
		private int bodyVertexCount;

		[Token(Token = "0x4000830")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private int bodyTrisCount;

		[Token(Token = "0x4000831")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		private int capVertexCount;

		[Token(Token = "0x4000832")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private int capTrisCount;

		[Token(Token = "0x170000A8")]
		public int sides
		{
			[Token(Token = "0x6000B1A")]
			[Address(RVA = "0x1578994", Offset = "0x1578994", VA = "0x1578994")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000B1B")]
			[Address(RVA = "0x157899C", Offset = "0x157899C", VA = "0x157899C")]
			set
			{
			}
		}

		[Token(Token = "0x170000A9")]
		public CapMethod capMode
		{
			[Token(Token = "0x6000B1C")]
			[Address(RVA = "0x15789CC", Offset = "0x15789CC", VA = "0x15789CC")]
			get
			{
				return default(CapMethod);
			}
			[Token(Token = "0x6000B1D")]
			[Address(RVA = "0x15789D4", Offset = "0x15789D4", VA = "0x15789D4")]
			set
			{
			}
		}

		[Token(Token = "0x170000AA")]
		public int roundCapLatitude
		{
			[Token(Token = "0x6000B1E")]
			[Address(RVA = "0x15789F8", Offset = "0x15789F8", VA = "0x15789F8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000B1F")]
			[Address(RVA = "0x1578A00", Offset = "0x1578A00", VA = "0x1578A00")]
			set
			{
			}
		}

		[Token(Token = "0x170000AB")]
		public float integrity
		{
			[Token(Token = "0x6000B20")]
			[Address(RVA = "0x1578A38", Offset = "0x1578A38", VA = "0x1578A38")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000B21")]
			[Address(RVA = "0x1578A40", Offset = "0x1578A40", VA = "0x1578A40")]
			set
			{
			}
		}

		[Token(Token = "0x170000AC")]
		public float capUVScale
		{
			[Token(Token = "0x6000B22")]
			[Address(RVA = "0x1578A64", Offset = "0x1578A64", VA = "0x1578A64")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000B23")]
			[Address(RVA = "0x1578A6C", Offset = "0x1578A6C", VA = "0x1578A6C")]
			set
			{
			}
		}

		[Token(Token = "0x170000AD")]
		private bool useCap
		{
			[Token(Token = "0x6000B24")]
			[Address(RVA = "0x1578A90", Offset = "0x1578A90", VA = "0x1578A90")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000B25")]
		[Address(RVA = "0x1578C34", Offset = "0x1578C34", VA = "0x1578C34", Slot = "5")]
		protected override void Reset()
		{
		}

		[Token(Token = "0x6000B26")]
		[Address(RVA = "0x1578C3C", Offset = "0x1578C3C", VA = "0x1578C3C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000B27")]
		[Address(RVA = "0x1578CA4", Offset = "0x1578CA4", VA = "0x1578CA4", Slot = "29")]
		protected override void BuildMesh()
		{
		}

		[Token(Token = "0x6000B28")]
		[Address(RVA = "0x1578E2C", Offset = "0x1578E2C", VA = "0x1578E2C")]
		private void Generate()
		{
		}

		[Token(Token = "0x6000B29")]
		[Address(RVA = "0x1579580", Offset = "0x1579580", VA = "0x1579580")]
		private void GenerateFlatCaps()
		{
		}

		[Token(Token = "0x6000B2A")]
		[Address(RVA = "0x1579D54", Offset = "0x1579D54", VA = "0x1579D54")]
		private void GenerateRoundCaps()
		{
		}

		[Token(Token = "0x6000B2B")]
		[Address(RVA = "0x157AD98", Offset = "0x157AD98", VA = "0x157AD98")]
		public TubeGenerator()
		{
		}
	}
	[Token(Token = "0x200016B")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x831A64", Offset = "0x831A64")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x831A64", Offset = "0x831A64")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x831A64", Offset = "0x831A64")]
	public class WaveformGenerator : MeshGenerator
	{
		[Token(Token = "0x20001ED")]
		public enum Axis
		{
			[Token(Token = "0x4000AB0")]
			X,
			[Token(Token = "0x4000AB1")]
			Y,
			[Token(Token = "0x4000AB2")]
			Z
		}

		[Token(Token = "0x20001EE")]
		public enum Space
		{
			[Token(Token = "0x4000AB4")]
			World,
			[Token(Token = "0x4000AB5")]
			Local
		}

		[Token(Token = "0x20001EF")]
		public enum UVWrapMode
		{
			[Token(Token = "0x4000AB7")]
			Clamp,
			[Token(Token = "0x4000AB8")]
			UniformX,
			[Token(Token = "0x4000AB9")]
			UniformY,
			[Token(Token = "0x4000ABA")]
			Uniform
		}

		[Token(Token = "0x4000833")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		[SerializeField]
		[HideInInspector]
		private Axis _axis;

		[Token(Token = "0x4000834")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		[SerializeField]
		[HideInInspector]
		private bool _symmetry;

		[Token(Token = "0x4000835")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		[SerializeField]
		[HideInInspector]
		private UVWrapMode _uvWrapMode;

		[Token(Token = "0x4000836")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		[SerializeField]
		[HideInInspector]
		private int _slices;

		[Token(Token = "0x170000AE")]
		public Axis axis
		{
			[Token(Token = "0x6000B2C")]
			[Address(RVA = "0x157AE1C", Offset = "0x157AE1C", VA = "0x157AE1C")]
			get
			{
				return default(Axis);
			}
			[Token(Token = "0x6000B2D")]
			[Address(RVA = "0x157AE24", Offset = "0x157AE24", VA = "0x157AE24")]
			set
			{
			}
		}

		[Token(Token = "0x170000AF")]
		public bool symmetry
		{
			[Token(Token = "0x6000B2E")]
			[Address(RVA = "0x157AE48", Offset = "0x157AE48", VA = "0x157AE48")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000B2F")]
			[Address(RVA = "0x157AE50", Offset = "0x157AE50", VA = "0x157AE50")]
			set
			{
			}
		}

		[Token(Token = "0x170000B0")]
		public UVWrapMode uvWrapMode
		{
			[Token(Token = "0x6000B30")]
			[Address(RVA = "0x157AE80", Offset = "0x157AE80", VA = "0x157AE80")]
			get
			{
				return default(UVWrapMode);
			}
			[Token(Token = "0x6000B31")]
			[Address(RVA = "0x157AE88", Offset = "0x157AE88", VA = "0x157AE88")]
			set
			{
			}
		}

		[Token(Token = "0x170000B1")]
		public int slices
		{
			[Token(Token = "0x6000B32")]
			[Address(RVA = "0x157AEAC", Offset = "0x157AEAC", VA = "0x157AEAC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000B33")]
			[Address(RVA = "0x157AEB4", Offset = "0x157AEB4", VA = "0x157AEB4")]
			set
			{
			}
		}

		[Token(Token = "0x6000B34")]
		[Address(RVA = "0x157AEE0", Offset = "0x157AEE0", VA = "0x157AEE0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000B35")]
		[Address(RVA = "0x157AF48", Offset = "0x157AF48", VA = "0x157AF48", Slot = "29")]
		protected override void BuildMesh()
		{
		}

		[Token(Token = "0x6000B36")]
		[Address(RVA = "0x157B898", Offset = "0x157B898", VA = "0x157B898", Slot = "20")]
		protected override void Build()
		{
		}

		[Token(Token = "0x6000B37")]
		[Address(RVA = "0x157B8A0", Offset = "0x157B8A0", VA = "0x157B8A0", Slot = "19")]
		protected override void LateRun()
		{
		}

		[Token(Token = "0x6000B38")]
		[Address(RVA = "0x157AF70", Offset = "0x157AF70", VA = "0x157AF70")]
		private void Generate()
		{
		}

		[Token(Token = "0x6000B39")]
		[Address(RVA = "0x157B8A8", Offset = "0x157B8A8", VA = "0x157B8A8")]
		public WaveformGenerator()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200016C")]
	public class CustomOffsetModule
	{
		[Serializable]
		[Token(Token = "0x20001F0")]
		public class Key
		{
			[Token(Token = "0x4000ABB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[SerializeField]
			private Vector2 _offset;

			[Token(Token = "0x4000ABC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			private double _from;

			[Token(Token = "0x4000ABD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			private double _to;

			[Token(Token = "0x4000ABE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[SerializeField]
			private double _center;

			[Token(Token = "0x4000ABF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[SerializeField]
			private bool _loop;

			[Token(Token = "0x4000AC0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public AnimationCurve interpolation;

			[Token(Token = "0x17000106")]
			public Vector2 offset
			{
				[Token(Token = "0x6000D93")]
				[Address(RVA = "0x1224748", Offset = "0x1224748", VA = "0x1224748")]
				get
				{
					return default(Vector2);
				}
				[Token(Token = "0x6000D94")]
				[Address(RVA = "0x1224750", Offset = "0x1224750", VA = "0x1224750")]
				set
				{
				}
			}

			[Token(Token = "0x17000107")]
			public double center
			{
				[Token(Token = "0x6000D95")]
				[Address(RVA = "0x1224758", Offset = "0x1224758", VA = "0x1224758")]
				get
				{
					return default(double);
				}
				[Token(Token = "0x6000D96")]
				[Address(RVA = "0x1224760", Offset = "0x1224760", VA = "0x1224760")]
				set
				{
				}
			}

			[Token(Token = "0x17000108")]
			public double from
			{
				[Token(Token = "0x6000D97")]
				[Address(RVA = "0x122477C", Offset = "0x122477C", VA = "0x122477C")]
				get
				{
					return default(double);
				}
				[Token(Token = "0x6000D98")]
				[Address(RVA = "0x1224784", Offset = "0x1224784", VA = "0x1224784")]
				set
				{
				}
			}

			[Token(Token = "0x17000109")]
			public double to
			{
				[Token(Token = "0x6000D99")]
				[Address(RVA = "0x12247A0", Offset = "0x12247A0", VA = "0x12247A0")]
				get
				{
					return default(double);
				}
				[Token(Token = "0x6000D9A")]
				[Address(RVA = "0x12247A8", Offset = "0x12247A8", VA = "0x12247A8")]
				set
				{
				}
			}

			[Token(Token = "0x1700010A")]
			public bool loop
			{
				[Token(Token = "0x6000D9B")]
				[Address(RVA = "0x12247C4", Offset = "0x12247C4", VA = "0x12247C4")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000D9C")]
				[Address(RVA = "0x12247CC", Offset = "0x12247CC", VA = "0x12247CC")]
				set
				{
				}
			}

			[Token(Token = "0x1700010B")]
			public double position
			{
				[Token(Token = "0x6000D9D")]
				[Address(RVA = "0x12246D8", Offset = "0x12246D8", VA = "0x12246D8")]
				get
				{
					return default(double);
				}
				[Token(Token = "0x6000D9E")]
				[Address(RVA = "0x12247D8", Offset = "0x12247D8", VA = "0x12247D8")]
				set
				{
				}
			}

			[Token(Token = "0x6000D9F")]
			[Address(RVA = "0x12240C8", Offset = "0x12240C8", VA = "0x12240C8")]
			public Key(Vector2 o, double f, double t, double c)
			{
			}

			[Token(Token = "0x6000DA0")]
			[Address(RVA = "0x122472C", Offset = "0x122472C", VA = "0x122472C")]
			public float Evaluate(float t)
			{
				return default(float);
			}
		}

		[Token(Token = "0x4000837")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<Key> keys;

		[Token(Token = "0x4000838")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _blend;

		[Token(Token = "0x170000B2")]
		public float blend
		{
			[Token(Token = "0x6000B3A")]
			[Address(RVA = "0x1223EF0", Offset = "0x1223EF0", VA = "0x1223EF0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000B3B")]
			[Address(RVA = "0x1223EF8", Offset = "0x1223EF8", VA = "0x1223EF8")]
			set
			{
			}
		}

		[Token(Token = "0x6000B3C")]
		[Address(RVA = "0x1223F74", Offset = "0x1223F74", VA = "0x1223F74")]
		public CustomOffsetModule()
		{
		}

		[Token(Token = "0x6000B3D")]
		[Address(RVA = "0x1224010", Offset = "0x1224010", VA = "0x1224010")]
		public void AddKey(Vector2 offset, double f, double t, double c)
		{
		}

		[Token(Token = "0x6000B3E")]
		[Address(RVA = "0x12241C0", Offset = "0x12241C0", VA = "0x12241C0")]
		public Vector2 Evaluate(double time)
		{
			return default(Vector2);
		}
	}
	[Serializable]
	[Token(Token = "0x200016D")]
	public class CustomRotationModule
	{
		[Serializable]
		[Token(Token = "0x20001F1")]
		public class Key
		{
			[Token(Token = "0x4000AC1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[SerializeField]
			private Vector3 _rotation;

			[Token(Token = "0x4000AC2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			private double _from;

			[Token(Token = "0x4000AC3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[SerializeField]
			private double _to;

			[Token(Token = "0x4000AC4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[SerializeField]
			private double _center;

			[Token(Token = "0x4000AC5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[SerializeField]
			private bool _loop;

			[Token(Token = "0x4000AC6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public AnimationCurve interpolation;

			[Token(Token = "0x1700010C")]
			public Vector3 rotation
			{
				[Token(Token = "0x6000DA1")]
				[Address(RVA = "0x12251C0", Offset = "0x12251C0", VA = "0x12251C0")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000DA2")]
				[Address(RVA = "0x12251CC", Offset = "0x12251CC", VA = "0x12251CC")]
				set
				{
				}
			}

			[Token(Token = "0x1700010D")]
			public double center
			{
				[Token(Token = "0x6000DA3")]
				[Address(RVA = "0x12251D8", Offset = "0x12251D8", VA = "0x12251D8")]
				get
				{
					return default(double);
				}
				[Token(Token = "0x6000DA4")]
				[Address(RVA = "0x12251E0", Offset = "0x12251E0", VA = "0x12251E0")]
				set
				{
				}
			}

			[Token(Token = "0x1700010E")]
			public double from
			{
				[Token(Token = "0x6000DA5")]
				[Address(RVA = "0x12251FC", Offset = "0x12251FC", VA = "0x12251FC")]
				get
				{
					return default(double);
				}
				[Token(Token = "0x6000DA6")]
				[Address(RVA = "0x1225204", Offset = "0x1225204", VA = "0x1225204")]
				set
				{
				}
			}

			[Token(Token = "0x1700010F")]
			public double to
			{
				[Token(Token = "0x6000DA7")]
				[Address(RVA = "0x1225220", Offset = "0x1225220", VA = "0x1225220")]
				get
				{
					return default(double);
				}
				[Token(Token = "0x6000DA8")]
				[Address(RVA = "0x1225228", Offset = "0x1225228", VA = "0x1225228")]
				set
				{
				}
			}

			[Token(Token = "0x17000110")]
			public bool loop
			{
				[Token(Token = "0x6000DA9")]
				[Address(RVA = "0x1225244", Offset = "0x1225244", VA = "0x1225244")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000DAA")]
				[Address(RVA = "0x122524C", Offset = "0x122524C", VA = "0x122524C")]
				set
				{
				}
			}

			[Token(Token = "0x17000111")]
			public double position
			{
				[Token(Token = "0x6000DAB")]
				[Address(RVA = "0x1225150", Offset = "0x1225150", VA = "0x1225150")]
				get
				{
					return default(double);
				}
				[Token(Token = "0x6000DAC")]
				[Address(RVA = "0x1225258", Offset = "0x1225258", VA = "0x1225258")]
				set
				{
				}
			}

			[Token(Token = "0x6000DAD")]
			[Address(RVA = "0x1224A48", Offset = "0x1224A48", VA = "0x1224A48")]
			public Key(Vector3 r, double f, double t, double c)
			{
			}

			[Token(Token = "0x6000DAE")]
			[Address(RVA = "0x12251A4", Offset = "0x12251A4", VA = "0x12251A4")]
			public float Evaluate(float t)
			{
				return default(float);
			}
		}

		[Token(Token = "0x4000839")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<Key> keys;

		[Token(Token = "0x400083A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _blend;

		[Token(Token = "0x170000B3")]
		public float blend
		{
			[Token(Token = "0x6000B3F")]
			[Address(RVA = "0x1224868", Offset = "0x1224868", VA = "0x1224868")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000B40")]
			[Address(RVA = "0x1224870", Offset = "0x1224870", VA = "0x1224870")]
			set
			{
			}
		}

		[Token(Token = "0x6000B41")]
		[Address(RVA = "0x12248EC", Offset = "0x12248EC", VA = "0x12248EC")]
		public CustomRotationModule()
		{
		}

		[Token(Token = "0x6000B42")]
		[Address(RVA = "0x1224988", Offset = "0x1224988", VA = "0x1224988")]
		public void AddKey(Vector3 rotation, double f, double t, double c)
		{
		}

		[Token(Token = "0x6000B43")]
		[Address(RVA = "0x1224B4C", Offset = "0x1224B4C", VA = "0x1224B4C")]
		public Quaternion Evaluate(Quaternion baseRotation, double time)
		{
			return default(Quaternion);
		}
	}
	[Serializable]
	[Token(Token = "0x200016E")]
	public class ObjectSequence<T>
	{
		[Token(Token = "0x20001F2")]
		public enum Iteration
		{
			[Token(Token = "0x4000AC8")]
			Ordered,
			[Token(Token = "0x4000AC9")]
			Random
		}

		[Token(Token = "0x400083B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T startObject;

		[Token(Token = "0x400083C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T endObject;

		[Token(Token = "0x400083D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T[] objects;

		[Token(Token = "0x400083E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Iteration iteration;

		[Token(Token = "0x400083F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		[HideInInspector]
		private int _randomSeed;

		[Token(Token = "0x4000840")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		[HideInInspector]
		private int index;

		[Token(Token = "0x4000841")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		[HideInInspector]
		private System.Random randomizer;

		[Token(Token = "0x170000B4")]
		public int randomSeed
		{
			[Token(Token = "0x6000B44")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000B45")]
			set
			{
			}
		}

		[Token(Token = "0x6000B46")]
		public ObjectSequence()
		{
		}

		[Token(Token = "0x6000B47")]
		public T GetFirst()
		{
			return (T)null;
		}

		[Token(Token = "0x6000B48")]
		public T GetLast()
		{
			return (T)null;
		}

		[Token(Token = "0x6000B49")]
		public T Next()
		{
			return (T)null;
		}
	}
	[Serializable]
	[Token(Token = "0x200016F")]
	public class Spline
	{
		[Token(Token = "0x20001F3")]
		public enum Direction
		{
			[Token(Token = "0x4000ACB")]
			Forward = 1,
			[Token(Token = "0x4000ACC")]
			Backward = -1
		}

		[Token(Token = "0x20001F4")]
		public enum Type
		{
			[Token(Token = "0x4000ACE")]
			Hermite,
			[Token(Token = "0x4000ACF")]
			BSpline,
			[Token(Token = "0x4000AD0")]
			Bezier,
			[Token(Token = "0x4000AD1")]
			Linear
		}

		[Token(Token = "0x4000842")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SplinePoint[] points;

		[Token(Token = "0x4000843")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool closed;

		[Token(Token = "0x4000844")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Type type;

		[Token(Token = "0x4000845")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AnimationCurve customValueInterpolation;

		[Token(Token = "0x4000846")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AnimationCurve customNormalInterpolation;

		[Token(Token = "0x4000847")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8349C4", Offset = "0x8349C4")]
		public double precision;

		[Token(Token = "0x4000848")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3[] hermitePoints;

		[Token(Token = "0x170000B5")]
		public bool isClosed
		{
			[Token(Token = "0x6000B4A")]
			[Address(RVA = "0x13CCF90", Offset = "0x13CCF90", VA = "0x13CCF90")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000B4B")]
			[Address(RVA = "0x13DFB90", Offset = "0x13DFB90", VA = "0x13DFB90")]
			set
			{
			}
		}

		[Token(Token = "0x170000B6")]
		public double moveStep
		{
			[Token(Token = "0x6000B4C")]
			[Address(RVA = "0x13DFB94", Offset = "0x13DFB94", VA = "0x13DFB94")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x6000B4D")]
			[Address(RVA = "0x13DFC3C", Offset = "0x13DFC3C", VA = "0x13DFC3C")]
			set
			{
			}
		}

		[Token(Token = "0x170000B7")]
		public int iterations
		{
			[Token(Token = "0x6000B4E")]
			[Address(RVA = "0x13DFBDC", Offset = "0x13DFBDC", VA = "0x13DFBDC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000B4F")]
			[Address(RVA = "0x13DFC40", Offset = "0x13DFC40", VA = "0x13DFC40")]
			set
			{
			}
		}

		[Token(Token = "0x6000B50")]
		[Address(RVA = "0x13CD774", Offset = "0x13CD774", VA = "0x13CD774")]
		public Spline(Type t)
		{
		}

		[Token(Token = "0x6000B51")]
		[Address(RVA = "0x13DFC44", Offset = "0x13DFC44", VA = "0x13DFC44")]
		public Spline(Type t, double p)
		{
		}

		[Token(Token = "0x6000B52")]
		[Address(RVA = "0x13DFD08", Offset = "0x13DFD08", VA = "0x13DFD08")]
		public float CalculateLength(double from = 0.0, double to = 1.0, double resolution = 1.0)
		{
			return default(float);
		}

		[Token(Token = "0x6000B53")]
		[Address(RVA = "0x13DFF64", Offset = "0x13DFF64", VA = "0x13DFF64")]
		public double Project(Vector3 point, int subdivide = 3, double from = 0.0, double to = 1.0)
		{
			return default(double);
		}

		[Token(Token = "0x6000B54")]
		[Address(RVA = "0x13E04CC", Offset = "0x13E04CC", VA = "0x13E04CC")]
		public bool Raycast(out RaycastHit hit, out double hitPercent, LayerMask layerMask, double resolution = 1.0, double from = 0.0, double to = 1.0, QueryTriggerInteraction hitTriggers = QueryTriggerInteraction.UseGlobal)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B55")]
		[Address(RVA = "0x13E0758", Offset = "0x13E0758", VA = "0x13E0758")]
		public bool RaycastAll(out RaycastHit[] hits, out double[] hitPercents, LayerMask layerMask, double resolution = 1.0, double from = 0.0, double to = 1.0, QueryTriggerInteraction hitTriggers = QueryTriggerInteraction.UseGlobal)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B56")]
		[Address(RVA = "0x13E0B84", Offset = "0x13E0B84", VA = "0x13E0B84")]
		public double GetPointPercent(int pointIndex)
		{
			return default(double);
		}

		[Token(Token = "0x6000B57")]
		[Address(RVA = "0x13DFEA8", Offset = "0x13DFEA8", VA = "0x13DFEA8")]
		public Vector3 EvaluatePosition(double percent)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000B58")]
		[Address(RVA = "0x13E0CA8", Offset = "0x13E0CA8", VA = "0x13E0CA8")]
		public SplineResult Evaluate(double percent)
		{
			return null;
		}

		[Token(Token = "0x6000B59")]
		[Address(RVA = "0x13E1474", Offset = "0x13E1474", VA = "0x13E1474")]
		public SplineResult Evaluate(int pointIndex)
		{
			return null;
		}

		[Token(Token = "0x6000B5A")]
		[Address(RVA = "0x13E14F8", Offset = "0x13E14F8", VA = "0x13E14F8")]
		public void Evaluate(SplineResult result, int pointIndex)
		{
		}

		[Token(Token = "0x6000B5B")]
		[Address(RVA = "0x13E0D24", Offset = "0x13E0D24", VA = "0x13E0D24")]
		public void Evaluate(SplineResult result, double percent)
		{
		}

		[Token(Token = "0x6000B5C")]
		[Address(RVA = "0x13E161C", Offset = "0x13E161C", VA = "0x13E161C")]
		public void Evaluate(ref SplineResult[] samples, double from = 0.0, double to = 1.0)
		{
		}

		[Token(Token = "0x6000B5D")]
		[Address(RVA = "0x13E1820", Offset = "0x13E1820", VA = "0x13E1820")]
		public void EvaluatePositions(ref Vector3[] positions, double from = 0.0, double to = 1.0)
		{
		}

		[Token(Token = "0x6000B5E")]
		[Address(RVA = "0x13E19E0", Offset = "0x13E19E0", VA = "0x13E19E0")]
		public double Travel(double start, float distance, Direction direction)
		{
			return default(double);
		}

		[Token(Token = "0x6000B5F")]
		[Address(RVA = "0x13E0BB4", Offset = "0x13E0BB4", VA = "0x13E0BB4")]
		private void EvaluatePosition(ref Vector3 point, double percent)
		{
		}

		[Token(Token = "0x6000B60")]
		[Address(RVA = "0x13E1528", Offset = "0x13E1528", VA = "0x13E1528")]
		private void EvaluateTangent(ref Vector3 tangent, double percent)
		{
		}

		[Token(Token = "0x6000B61")]
		[Address(RVA = "0x13E022C", Offset = "0x13E022C", VA = "0x13E022C")]
		private double GetClosestPoint(int iterations, Vector3 point, double start, double end, int slices)
		{
			return default(double);
		}

		[Token(Token = "0x6000B62")]
		[Address(RVA = "0x13DF5A4", Offset = "0x13DF5A4", VA = "0x13DF5A4")]
		public void Break()
		{
		}

		[Token(Token = "0x6000B63")]
		[Address(RVA = "0x13E1DD0", Offset = "0x13E1DD0", VA = "0x13E1DD0")]
		public void Break(int at)
		{
		}

		[Token(Token = "0x6000B64")]
		[Address(RVA = "0x13CD828", Offset = "0x13CD828", VA = "0x13CD828")]
		public void Close()
		{
		}

		[Token(Token = "0x6000B65")]
		[Address(RVA = "0x13E2024", Offset = "0x13E2024", VA = "0x13E2024")]
		public void ConvertToBezier()
		{
		}

		[Token(Token = "0x6000B66")]
		[Address(RVA = "0x13E1C28", Offset = "0x13E1C28", VA = "0x13E1C28")]
		private void GetPoint(ref Vector3 point, double percent, int pointIndex)
		{
		}

		[Token(Token = "0x6000B67")]
		[Address(RVA = "0x13E1DA8", Offset = "0x13E1DA8", VA = "0x13E1DA8")]
		private void GetTangent(ref Vector3 tangent, double percent, int pointIndex)
		{
		}

		[Token(Token = "0x6000B68")]
		[Address(RVA = "0x13E34AC", Offset = "0x13E34AC", VA = "0x13E34AC")]
		private void LinearGetPoint(ref Vector3 point, double t, int i)
		{
		}

		[Token(Token = "0x6000B69")]
		[Address(RVA = "0x13E3CD4", Offset = "0x13E3CD4", VA = "0x13E3CD4")]
		private void LinearGetTangent(ref Vector3 tangent, double t, int i)
		{
		}

		[Token(Token = "0x6000B6A")]
		[Address(RVA = "0x13E2FE0", Offset = "0x13E2FE0", VA = "0x13E2FE0")]
		private void BSPGetPoint(ref Vector3 point, double time, int i)
		{
		}

		[Token(Token = "0x6000B6B")]
		[Address(RVA = "0x13E2D28", Offset = "0x13E2D28", VA = "0x13E2D28")]
		private void BezierGetPoint(ref Vector3 point, double t, int i)
		{
		}

		[Token(Token = "0x6000B6C")]
		[Address(RVA = "0x13E3950", Offset = "0x13E3950", VA = "0x13E3950")]
		private void BezierGetTangent(ref Vector3 tangent, double t, int i)
		{
		}

		[Token(Token = "0x6000B6D")]
		[Address(RVA = "0x13E2904", Offset = "0x13E2904", VA = "0x13E2904")]
		private void HermiteGetPoint(ref Vector3 point, double t, int i)
		{
		}

		[Token(Token = "0x6000B6E")]
		[Address(RVA = "0x13E3674", Offset = "0x13E3674", VA = "0x13E3674")]
		private void GetHermiteTangent(ref Vector3 direction, double t, int i)
		{
		}

		[Token(Token = "0x6000B6F")]
		[Address(RVA = "0x13E24C8", Offset = "0x13E24C8", VA = "0x13E24C8")]
		private void GetHermitePoints(int i)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000170")]
	public class SplineAddress
	{
		[Serializable]
		[Token(Token = "0x20001F5")]
		public class Element
		{
			[Token(Token = "0x4000AD2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SplineComputer computer;

			[Token(Token = "0x4000AD3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			private int _startPoint;

			[Token(Token = "0x4000AD4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[SerializeField]
			private int _endPoint;

			[Token(Token = "0x17000112")]
			public int startPoint
			{
				[Token(Token = "0x6000DAF")]
				[Address(RVA = "0x13E8C60", Offset = "0x13E8C60", VA = "0x13E8C60")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6000DB0")]
				[Address(RVA = "0x13E8360", Offset = "0x13E8360", VA = "0x13E8360")]
				set
				{
				}
			}

			[Token(Token = "0x17000113")]
			public int endPoint
			{
				[Token(Token = "0x6000DB1")]
				[Address(RVA = "0x13E8330", Offset = "0x13E8330", VA = "0x13E8330")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6000DB2")]
				[Address(RVA = "0x13E607C", Offset = "0x13E607C", VA = "0x13E607C")]
				set
				{
				}
			}

			[Token(Token = "0x17000114")]
			public double startPercent
			{
				[Token(Token = "0x6000DB3")]
				[Address(RVA = "0x13E6F84", Offset = "0x13E6F84", VA = "0x13E6F84")]
				get
				{
					return default(double);
				}
			}

			[Token(Token = "0x17000115")]
			public double endPercent
			{
				[Token(Token = "0x6000DB4")]
				[Address(RVA = "0x13E6FC4", Offset = "0x13E6FC4", VA = "0x13E6FC4")]
				get
				{
					return default(double);
				}
			}

			[Token(Token = "0x17000116")]
			public int span
			{
				[Token(Token = "0x6000DB5")]
				[Address(RVA = "0x13E6ED4", Offset = "0x13E6ED4", VA = "0x13E6ED4")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x6000DB6")]
			[Address(RVA = "0x13E606C", Offset = "0x13E606C", VA = "0x13E606C")]
			public Element()
			{
			}
		}

		[Token(Token = "0x4000849")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Element[] _elements;

		[Token(Token = "0x170000B8")]
		public int depth
		{
			[Token(Token = "0x6000B70")]
			[Address(RVA = "0x13E5F0C", Offset = "0x13E5F0C", VA = "0x13E5F0C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000B9")]
		public SplineComputer root
		{
			[Token(Token = "0x6000B71")]
			[Address(RVA = "0x13E5F24", Offset = "0x13E5F24", VA = "0x13E5F24")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B72")]
			[Address(RVA = "0x13E5F64", Offset = "0x13E5F64", VA = "0x13E5F64")]
			set
			{
			}
		}

		[Token(Token = "0x170000BA")]
		public Element[] elements
		{
			[Token(Token = "0x6000B73")]
			[Address(RVA = "0x13E629C", Offset = "0x13E629C", VA = "0x13E629C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BB")]
		public double moveStep
		{
			[Token(Token = "0x6000B74")]
			[Address(RVA = "0x13E62A4", Offset = "0x13E62A4", VA = "0x13E62A4")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x6000B75")]
		[Address(RVA = "0x13E6518", Offset = "0x13E6518", VA = "0x13E6518")]
		public SplineAddress(SplineComputer rootComp)
		{
		}

		[Token(Token = "0x6000B76")]
		[Address(RVA = "0x13E6624", Offset = "0x13E6624", VA = "0x13E6624")]
		public SplineAddress(SplineAddress copy)
		{
		}

		[Token(Token = "0x6000B77")]
		[Address(RVA = "0x13E67D8", Offset = "0x13E67D8", VA = "0x13E67D8")]
		public SplineResult Evaluate(double percent)
		{
			return null;
		}

		[Token(Token = "0x6000B78")]
		[Address(RVA = "0x13E6854", Offset = "0x13E6854", VA = "0x13E6854")]
		public void Evaluate(SplineResult result, double percent)
		{
		}

		[Token(Token = "0x6000B79")]
		[Address(RVA = "0x13E6BE8", Offset = "0x13E6BE8", VA = "0x13E6BE8")]
		public Vector3 EvaluatePosition(double percent)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000B7A")]
		[Address(RVA = "0x13E700C", Offset = "0x13E700C", VA = "0x13E700C")]
		public double Project(Vector3 point, int subdivide = 4, double from = 0.0, double to = 1.0)
		{
			return default(double);
		}

		[Token(Token = "0x6000B7B")]
		[Address(RVA = "0x13E76D8", Offset = "0x13E76D8", VA = "0x13E76D8")]
		public float CalculateLength(double from = 0.0, double to = 1.0)
		{
			return default(float);
		}

		[Token(Token = "0x6000B7C")]
		[Address(RVA = "0x13E79C4", Offset = "0x13E79C4", VA = "0x13E79C4")]
		public double Travel(double start, float distance, Spline.Direction direction, int iterations)
		{
			return default(double);
		}

		[Token(Token = "0x6000B7D")]
		[Address(RVA = "0x13E7BCC", Offset = "0x13E7BCC", VA = "0x13E7BCC")]
		public int GetElementIndex(double percent)
		{
			return default(int);
		}

		[Token(Token = "0x6000B7E")]
		[Address(RVA = "0x13E727C", Offset = "0x13E727C", VA = "0x13E727C")]
		public double PathToLocalPercent(double pathPercent, int elementIndex)
		{
			return default(double);
		}

		[Token(Token = "0x6000B7F")]
		[Address(RVA = "0x13E74EC", Offset = "0x13E74EC", VA = "0x13E74EC")]
		public double LocalToPathPercent(double localPercent, int elementIndex)
		{
			return default(double);
		}

		[Token(Token = "0x6000B80")]
		[Address(RVA = "0x13E63D8", Offset = "0x13E63D8", VA = "0x13E63D8")]
		public int GetTotalPointCount()
		{
			return default(int);
		}

		[Token(Token = "0x6000B81")]
		[Address(RVA = "0x13E6970", Offset = "0x13E6970", VA = "0x13E6970")]
		public void GetEvaluationValues(double inputPercent, out SplineComputer computer, out double percent, out Spline.Direction direction)
		{
		}

		[Token(Token = "0x6000B82")]
		[Address(RVA = "0x13E7D64", Offset = "0x13E7D64", VA = "0x13E7D64")]
		private int LocalToPathPoint(int point, int elementIndex)
		{
			return default(int);
		}

		[Token(Token = "0x6000B83")]
		[Address(RVA = "0x13E7E6C", Offset = "0x13E7E6C", VA = "0x13E7E6C")]
		private void PathToLocalPoint(int point, out int computerIndex, out int localPoint)
		{
		}

		[Token(Token = "0x6000B84")]
		[Address(RVA = "0x13E7F78", Offset = "0x13E7F78", VA = "0x13E7F78")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x836098", Offset = "0x836098")]
		public void Enter(Node node, int connectionIndex, Spline.Direction direction = Spline.Direction.Forward)
		{
		}

		[Token(Token = "0x6000B85")]
		[Address(RVA = "0x13E7F7C", Offset = "0x13E7F7C", VA = "0x13E7F7C")]
		public void AddSpline(Node node, int connectionIndex, Spline.Direction direction = Spline.Direction.Forward)
		{
		}

		[Token(Token = "0x6000B86")]
		[Address(RVA = "0x13E8540", Offset = "0x13E8540", VA = "0x13E8540")]
		public void AddSpline(SplineComputer computer, int connectionIndex, int connectedIndex, Spline.Direction direction = Spline.Direction.Forward)
		{
		}

		[Token(Token = "0x6000B87")]
		[Address(RVA = "0x13E88B0", Offset = "0x13E88B0", VA = "0x13E88B0")]
		public void Exit(int exitDepth)
		{
		}

		[Token(Token = "0x6000B88")]
		[Address(RVA = "0x13E8A24", Offset = "0x13E8A24", VA = "0x13E8A24")]
		public void Collapse()
		{
		}

		[Token(Token = "0x6000B89")]
		[Address(RVA = "0x13E8B88", Offset = "0x13E8B88", VA = "0x13E8B88")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000B8A")]
		[Address(RVA = "0x13E66F8", Offset = "0x13E66F8", VA = "0x13E66F8")]
		private void AddElement(Element element)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000171")]
	public struct SplinePoint
	{
		[Token(Token = "0x20001F6")]
		public enum Type
		{
			[Token(Token = "0x4000AD6")]
			SmoothMirrored,
			[Token(Token = "0x4000AD7")]
			Broken,
			[Token(Token = "0x4000AD8")]
			SmoothFree
		}

		[Token(Token = "0x400084A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x8349E0", Offset = "0x8349E0")]
		public Type _type;

		[Token(Token = "0x400084B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public Vector3 position;

		[Token(Token = "0x400084C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Color color;

		[Token(Token = "0x400084D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 normal;

		[Token(Token = "0x400084E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float size;

		[Token(Token = "0x400084F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 tangent;

		[Token(Token = "0x4000850")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 tangent2;

		[Token(Token = "0x170000BC")]
		public Type type
		{
			[Token(Token = "0x6000B8B")]
			[Address(RVA = "0x8EB938", Offset = "0x8EB938", VA = "0x8EB938")]
			get
			{
				return default(Type);
			}
			[Token(Token = "0x6000B8C")]
			[Address(RVA = "0x8EB940", Offset = "0x8EB940", VA = "0x8EB940")]
			set
			{
			}
		}

		[Token(Token = "0x6000B8D")]
		[Address(RVA = "0x13F8988", Offset = "0x13F8988", VA = "0x13F8988")]
		public static SplinePoint Lerp(SplinePoint a, SplinePoint b, float t)
		{
			return default(SplinePoint);
		}

		[Token(Token = "0x6000B8E")]
		[Address(RVA = "0x13F8B94", Offset = "0x13F8B94", VA = "0x13F8B94")]
		private static void GetInterpolatedTangents(SplinePoint a, SplinePoint b, float t, out Vector3 t1, out Vector3 t2)
		{
		}

		[Token(Token = "0x6000B8F")]
		[Address(RVA = "0x8EB950", Offset = "0x8EB950", VA = "0x8EB950")]
		public void SetPosition(Vector3 pos)
		{
		}

		[Token(Token = "0x6000B90")]
		[Address(RVA = "0x8EB958", Offset = "0x8EB958", VA = "0x8EB958")]
		public void SetTangentPosition(Vector3 pos)
		{
		}

		[Token(Token = "0x6000B91")]
		[Address(RVA = "0x8EB960", Offset = "0x8EB960", VA = "0x8EB960")]
		public void SetTangent2Position(Vector3 pos)
		{
		}

		[Token(Token = "0x6000B92")]
		[Address(RVA = "0x8EB968", Offset = "0x8EB968", VA = "0x8EB968")]
		public SplinePoint(Vector3 p)
		{
		}

		[Token(Token = "0x6000B93")]
		[Address(RVA = "0x8EB970", Offset = "0x8EB970", VA = "0x8EB970")]
		public SplinePoint(Vector3 p, Vector3 t)
		{
		}

		[Token(Token = "0x6000B94")]
		[Address(RVA = "0x8EB978", Offset = "0x8EB978", VA = "0x8EB978")]
		public SplinePoint(Vector3 pos, Vector3 tan, Vector3 nor, float s, Color col)
		{
		}

		[Token(Token = "0x6000B95")]
		[Address(RVA = "0x8EB9A0", Offset = "0x8EB9A0", VA = "0x8EB9A0")]
		public SplinePoint(Vector3 pos, Vector3 tan, Vector3 tan2, Vector3 nor, float s, Color col)
		{
		}

		[Token(Token = "0x6000B96")]
		[Address(RVA = "0x8EB9E0", Offset = "0x8EB9E0", VA = "0x8EB9E0")]
		public SplinePoint(SplinePoint source)
		{
		}

		[Token(Token = "0x6000B97")]
		[Address(RVA = "0x8EBA1C", Offset = "0x8EBA1C", VA = "0x8EBA1C")]
		private void SmoothMirrorTangent2()
		{
		}

		[Token(Token = "0x6000B98")]
		[Address(RVA = "0x8EBA24", Offset = "0x8EBA24", VA = "0x8EBA24")]
		private void SmoothMirrorTangent()
		{
		}

		[Token(Token = "0x6000B99")]
		[Address(RVA = "0x8EBA2C", Offset = "0x8EBA2C", VA = "0x8EBA2C")]
		private void SmoothFreeTangent2()
		{
		}

		[Token(Token = "0x6000B9A")]
		[Address(RVA = "0x8EBA34", Offset = "0x8EBA34", VA = "0x8EBA34")]
		private void SmoothFreeTangent()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000172")]
	public class SplineResult
	{
		[Token(Token = "0x4000851")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 position;

		[Token(Token = "0x4000852")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 normal;

		[Token(Token = "0x4000853")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 direction;

		[Token(Token = "0x4000854")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Color color;

		[Token(Token = "0x4000855")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float size;

		[Token(Token = "0x4000856")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public double percent;

		[Token(Token = "0x170000BD")]
		public Quaternion rotation
		{
			[Token(Token = "0x6000B9B")]
			[Address(RVA = "0x156A980", Offset = "0x156A980", VA = "0x156A980")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x170000BE")]
		public Vector3 right
		{
			[Token(Token = "0x6000B9C")]
			[Address(RVA = "0x156AB34", Offset = "0x156AB34", VA = "0x156AB34")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000B9D")]
		[Address(RVA = "0x156ACDC", Offset = "0x156ACDC", VA = "0x156ACDC")]
		public static SplineResult Lerp(SplineResult a, SplineResult b, float t)
		{
			return null;
		}

		[Token(Token = "0x6000B9E")]
		[Address(RVA = "0x156AFC4", Offset = "0x156AFC4", VA = "0x156AFC4")]
		public static SplineResult Lerp(SplineResult a, SplineResult b, double t)
		{
			return null;
		}

		[Token(Token = "0x6000B9F")]
		[Address(RVA = "0x156B04C", Offset = "0x156B04C", VA = "0x156B04C")]
		public static void Lerp(SplineResult a, SplineResult b, double t, SplineResult target)
		{
		}

		[Token(Token = "0x6000BA0")]
		[Address(RVA = "0x156AE14", Offset = "0x156AE14", VA = "0x156AE14")]
		public static void Lerp(SplineResult a, SplineResult b, float t, SplineResult target)
		{
		}

		[Token(Token = "0x6000BA1")]
		[Address(RVA = "0x156B1FC", Offset = "0x156B1FC", VA = "0x156B1FC")]
		public void Lerp(SplineResult b, double t)
		{
		}

		[Token(Token = "0x6000BA2")]
		[Address(RVA = "0x156B204", Offset = "0x156B204", VA = "0x156B204")]
		public void Lerp(SplineResult b, float t)
		{
		}

		[Token(Token = "0x6000BA3")]
		[Address(RVA = "0x156B20C", Offset = "0x156B20C", VA = "0x156B20C")]
		public void CopyFrom(SplineResult input)
		{
		}

		[Token(Token = "0x6000BA4")]
		[Address(RVA = "0x156AD64", Offset = "0x156AD64", VA = "0x156AD64")]
		public SplineResult()
		{
		}

		[Token(Token = "0x6000BA5")]
		[Address(RVA = "0x156B268", Offset = "0x156B268", VA = "0x156B268")]
		public SplineResult(Vector3 p, Vector3 n, Vector3 d, Color c, float s, double t)
		{
		}

		[Token(Token = "0x6000BA6")]
		[Address(RVA = "0x156B3B8", Offset = "0x156B3B8", VA = "0x156B3B8")]
		public SplineResult(SplineResult input)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000173")]
	public class SplineAction
	{
		[Token(Token = "0x4000857")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		public UnityEngine.Object target;

		[Token(Token = "0x4000858")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int intValue;

		[Token(Token = "0x4000859")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float floatValue;

		[Token(Token = "0x400085A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public double doubleValue;

		[Token(Token = "0x400085B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string stringValue;

		[Token(Token = "0x400085C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool boolValue;

		[Token(Token = "0x400085D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GameObject goValue;

		[Token(Token = "0x400085E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform transformValue;

		[Token(Token = "0x400085F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private UnityAction action;

		[Token(Token = "0x4000860")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private UnityAction<int> intAction;

		[Token(Token = "0x4000861")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private UnityAction<float> floatAction;

		[Token(Token = "0x4000862")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private UnityAction<double> doubleAction;

		[Token(Token = "0x4000863")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private UnityAction<string> stringAction;

		[Token(Token = "0x4000864")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private UnityAction<bool> boolAction;

		[Token(Token = "0x4000865")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private UnityAction<GameObject> goAction;

		[Token(Token = "0x4000866")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private UnityAction<Transform> transformAction;

		[Token(Token = "0x4000867")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private MethodInfo methodInfo;

		[Token(Token = "0x4000868")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private string methodName;

		[Token(Token = "0x4000869")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private int paramType;

		[Token(Token = "0x6000BA7")]
		[Address(RVA = "0x13E4E00", Offset = "0x13E4E00", VA = "0x13E4E00")]
		public SplineAction()
		{
		}

		[Token(Token = "0x6000BA8")]
		[Address(RVA = "0x13E4E58", Offset = "0x13E4E58", VA = "0x13E4E58")]
		public SplineAction(UnityAction call)
		{
		}

		[Token(Token = "0x6000BA9")]
		[Address(RVA = "0x13E4EC8", Offset = "0x13E4EC8", VA = "0x13E4EC8")]
		public SplineAction(UnityAction<int> call, int value)
		{
		}

		[Token(Token = "0x6000BAA")]
		[Address(RVA = "0x13E4F44", Offset = "0x13E4F44", VA = "0x13E4F44")]
		public SplineAction(UnityAction<float> call, float value)
		{
		}

		[Token(Token = "0x6000BAB")]
		[Address(RVA = "0x13E4FC8", Offset = "0x13E4FC8", VA = "0x13E4FC8")]
		public SplineAction(UnityAction<double> call, double value)
		{
		}

		[Token(Token = "0x6000BAC")]
		[Address(RVA = "0x13E504C", Offset = "0x13E504C", VA = "0x13E504C")]
		public SplineAction(UnityAction<string> call, string value)
		{
		}

		[Token(Token = "0x6000BAD")]
		[Address(RVA = "0x13E50C8", Offset = "0x13E50C8", VA = "0x13E50C8")]
		public SplineAction(UnityAction<bool> call, bool value)
		{
		}

		[Token(Token = "0x6000BAE")]
		[Address(RVA = "0x13E5148", Offset = "0x13E5148", VA = "0x13E5148")]
		public SplineAction(UnityAction<GameObject> call, GameObject value)
		{
		}

		[Token(Token = "0x6000BAF")]
		[Address(RVA = "0x13E51C4", Offset = "0x13E51C4", VA = "0x13E51C4")]
		public SplineAction(UnityAction<Transform> call, Transform value)
		{
		}

		[Token(Token = "0x6000BB0")]
		[Address(RVA = "0x13E5240", Offset = "0x13E5240", VA = "0x13E5240")]
		public void SetMethod(MethodInfo newMethod)
		{
		}

		[Token(Token = "0x6000BB1")]
		[Address(RVA = "0x13E5A38", Offset = "0x13E5A38", VA = "0x13E5A38")]
		private Type GetParamType()
		{
			return null;
		}

		[Token(Token = "0x6000BB2")]
		[Address(RVA = "0x13E5B70", Offset = "0x13E5B70", VA = "0x13E5B70")]
		public MethodInfo GetMethod()
		{
			return null;
		}

		[Token(Token = "0x6000BB3")]
		[Address(RVA = "0x13E564C", Offset = "0x13E564C", VA = "0x13E564C")]
		private void ConstructUnityAction()
		{
		}

		[Token(Token = "0x6000BB4")]
		[Address(RVA = "0x13E5D2C", Offset = "0x13E5D2C", VA = "0x13E5D2C")]
		public void Invoke()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000174")]
	public class SplineTrigger : ScriptableObject
	{
		[Token(Token = "0x20001F7")]
		public enum Type
		{
			[Token(Token = "0x4000ADA")]
			Double,
			[Token(Token = "0x4000ADB")]
			Forward,
			[Token(Token = "0x4000ADC")]
			Backward
		}

		[Token(Token = "0x400086A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		public Type type;

		[Token(Token = "0x400086B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x834A58", Offset = "0x834A58")]
		public double position;

		[Token(Token = "0x400086C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		public bool enabled;

		[Token(Token = "0x400086D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		public Color color;

		[Token(Token = "0x400086E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[HideInInspector]
		public SplineAction[] actions;

		[Token(Token = "0x400086F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public GameObject[] gameObjects;

		[Token(Token = "0x6000BB5")]
		[Address(RVA = "0x156E814", Offset = "0x156E814", VA = "0x156E814")]
		public SplineTrigger()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000175")]
	public class Trigger
	{
		[Token(Token = "0x20001F8")]
		public enum Type
		{
			[Token(Token = "0x4000ADE")]
			Double,
			[Token(Token = "0x4000ADF")]
			Forward,
			[Token(Token = "0x4000AE0")]
			Backward
		}

		[Token(Token = "0x4000870")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x4000871")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		public Type type;

		[Token(Token = "0x4000872")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool workOnce;

		[Token(Token = "0x4000873")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		private bool worked;

		[Token(Token = "0x4000874")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x834AD8", Offset = "0x834AD8")]
		public double position;

		[Token(Token = "0x4000875")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		public bool enabled;

		[Token(Token = "0x4000876")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		public Color color;

		[Token(Token = "0x4000877")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[HideInInspector]
		public SplineAction[] actions;

		[Token(Token = "0x4000878")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public GameObject[] gameObjects;

		[Token(Token = "0x6000BB6")]
		[Address(RVA = "0x156DD64", Offset = "0x156DD64", VA = "0x156DD64")]
		public void Create(Type t, UnityAction call)
		{
		}

		[Token(Token = "0x6000BB7")]
		[Address(RVA = "0x156DE90", Offset = "0x156DE90", VA = "0x156DE90")]
		public void Create(Type t, UnityAction<int> call, int value)
		{
		}

		[Token(Token = "0x6000BB8")]
		[Address(RVA = "0x156DFAC", Offset = "0x156DFAC", VA = "0x156DFAC")]
		public void Create(Type t, UnityAction<float> call, float value)
		{
		}

		[Token(Token = "0x6000BB9")]
		[Address(RVA = "0x156E0D0", Offset = "0x156E0D0", VA = "0x156E0D0")]
		public void Create(Type t, UnityAction<double> call, double value)
		{
		}

		[Token(Token = "0x6000BBA")]
		[Address(RVA = "0x156E1FC", Offset = "0x156E1FC", VA = "0x156E1FC")]
		public void Create(Type t, UnityAction<string> call, string value)
		{
		}

		[Token(Token = "0x6000BBB")]
		[Address(RVA = "0x156E320", Offset = "0x156E320", VA = "0x156E320")]
		public void Create(Type t, UnityAction<bool> call, bool value)
		{
		}

		[Token(Token = "0x6000BBC")]
		[Address(RVA = "0x156E568", Offset = "0x156E568", VA = "0x156E568")]
		public void Create(Type t, UnityAction<Transform> call, Transform value)
		{
		}

		[Token(Token = "0x6000BBD")]
		[Address(RVA = "0x156E444", Offset = "0x156E444", VA = "0x156E444")]
		public void Create(Type t, UnityAction<GameObject> call, GameObject value)
		{
		}

		[Token(Token = "0x6000BBE")]
		[Address(RVA = "0x1577CB8", Offset = "0x1577CB8", VA = "0x1577CB8")]
		public void Create(Type t)
		{
		}

		[Token(Token = "0x6000BBF")]
		[Address(RVA = "0x156C5D8", Offset = "0x156C5D8", VA = "0x156C5D8")]
		public void ResetWorkOnce()
		{
		}

		[Token(Token = "0x6000BC0")]
		[Address(RVA = "0x156D61C", Offset = "0x156D61C", VA = "0x156D61C")]
		public bool Check(double previousPercent, double currentPercent)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BC1")]
		[Address(RVA = "0x156D824", Offset = "0x156D824", VA = "0x156D824")]
		public void Invoke()
		{
		}

		[Token(Token = "0x6000BC2")]
		[Address(RVA = "0x1577D94", Offset = "0x1577D94", VA = "0x1577D94")]
		private void AddAction()
		{
		}

		[Token(Token = "0x6000BC3")]
		[Address(RVA = "0x1577E8C", Offset = "0x1577E8C", VA = "0x1577E8C")]
		public void AddListener(MonoBehaviour behavior, string method, object arg)
		{
		}

		[Token(Token = "0x6000BC4")]
		[Address(RVA = "0x1577D1C", Offset = "0x1577D1C", VA = "0x1577D1C")]
		public void AddAction(SplineAction action)
		{
		}

		[Token(Token = "0x6000BC5")]
		[Address(RVA = "0x156DB58", Offset = "0x156DB58", VA = "0x156DB58")]
		public Trigger()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000176")]
	public class TransformModule
	{
		[Token(Token = "0x20001F9")]
		public enum VelocityHandleMode
		{
			[Token(Token = "0x4000AE2")]
			Zero,
			[Token(Token = "0x4000AE3")]
			Preserve,
			[Token(Token = "0x4000AE4")]
			Align,
			[Token(Token = "0x4000AE5")]
			AlignRealistic
		}

		[Token(Token = "0x4000879")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		[HideInInspector]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x834B48", Offset = "0x834B48")]
		private Vector2 _offset;

		[Token(Token = "0x400087A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[HideInInspector]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x834BA4", Offset = "0x834BA4")]
		private Vector3 _rotationOffset;

		[Token(Token = "0x400087B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		[HideInInspector]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x834C00", Offset = "0x834C00")]
		private Vector3 _baseScale;

		[Token(Token = "0x400087C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public VelocityHandleMode velocityHandleMode;

		[Token(Token = "0x400087D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private SplineResult _splineResult;

		[Token(Token = "0x400087E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public CustomRotationModule customRotation;

		[Token(Token = "0x400087F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public CustomOffsetModule customOffset;

		[Token(Token = "0x4000880")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool applyPositionX;

		[Token(Token = "0x4000881")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool applyPositionY;

		[Token(Token = "0x4000882")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x52")]
		public bool applyPositionZ;

		[Token(Token = "0x4000883")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Spline.Direction direction;

		[Token(Token = "0x4000884")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool applyRotationX;

		[Token(Token = "0x4000885")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		public bool applyRotationY;

		[Token(Token = "0x4000886")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
		public bool applyRotationZ;

		[Token(Token = "0x4000887")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5B")]
		public bool applyScaleX;

		[Token(Token = "0x4000888")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public bool applyScaleY;

		[Token(Token = "0x4000889")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
		public bool applyScaleZ;

		[Token(Token = "0x400088A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[HideInInspector]
		public SplineUser targetUser;

		[Token(Token = "0x400088B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Vector3 position;

		[Token(Token = "0x400088C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private static Quaternion rotation;

		[Token(Token = "0x170000BF")]
		public Vector2 offset
		{
			[Token(Token = "0x6000BC6")]
			[Address(RVA = "0x1577050", Offset = "0x1577050", VA = "0x1577050")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000BC7")]
			[Address(RVA = "0x156C0D8", Offset = "0x156C0D8", VA = "0x156C0D8")]
			set
			{
			}
		}

		[Token(Token = "0x170000C0")]
		public Vector3 rotationOffset
		{
			[Token(Token = "0x6000BC8")]
			[Address(RVA = "0x1577058", Offset = "0x1577058", VA = "0x1577058")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000BC9")]
			[Address(RVA = "0x156C240", Offset = "0x156C240", VA = "0x156C240")]
			set
			{
			}
		}

		[Token(Token = "0x170000C1")]
		public Vector3 baseScale
		{
			[Token(Token = "0x6000BCA")]
			[Address(RVA = "0x1577064", Offset = "0x1577064", VA = "0x1577064")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000BCB")]
			[Address(RVA = "0x1577070", Offset = "0x1577070", VA = "0x1577070")]
			set
			{
			}
		}

		[Token(Token = "0x170000C2")]
		public SplineResult splineResult
		{
			[Token(Token = "0x6000BCC")]
			[Address(RVA = "0x1577190", Offset = "0x1577190", VA = "0x1577190")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BCD")]
			[Address(RVA = "0x156D22C", Offset = "0x156D22C", VA = "0x156D22C")]
			set
			{
			}
		}

		[Token(Token = "0x170000C3")]
		public bool applyPosition
		{
			[Token(Token = "0x6000BCE")]
			[Address(RVA = "0x156BEA8", Offset = "0x156BEA8", VA = "0x156BEA8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000BCF")]
			[Address(RVA = "0x156BF08", Offset = "0x156BF08", VA = "0x156BF08")]
			set
			{
			}
		}

		[Token(Token = "0x170000C4")]
		public bool applyRotation
		{
			[Token(Token = "0x6000BD0")]
			[Address(RVA = "0x156BF5C", Offset = "0x156BF5C", VA = "0x156BF5C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000BD1")]
			[Address(RVA = "0x156BFBC", Offset = "0x156BFBC", VA = "0x156BFBC")]
			set
			{
			}
		}

		[Token(Token = "0x170000C5")]
		public bool applyScale
		{
			[Token(Token = "0x6000BD2")]
			[Address(RVA = "0x156C010", Offset = "0x156C010", VA = "0x156C010")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000BD3")]
			[Address(RVA = "0x156C070", Offset = "0x156C070", VA = "0x156C070")]
			set
			{
			}
		}

		[Token(Token = "0x6000BD4")]
		[Address(RVA = "0x156D2B4", Offset = "0x156D2B4", VA = "0x156D2B4")]
		public void ApplyTransform(Transform input)
		{
		}

		[Token(Token = "0x6000BD5")]
		[Address(RVA = "0x156D338", Offset = "0x156D338", VA = "0x156D338")]
		public void ApplyRigidbody(Rigidbody input)
		{
		}

		[Token(Token = "0x6000BD6")]
		[Address(RVA = "0x156D45C", Offset = "0x156D45C", VA = "0x156D45C")]
		public void ApplyRigidbody2D(Rigidbody2D input)
		{
		}

		[Token(Token = "0x6000BD7")]
		[Address(RVA = "0x157790C", Offset = "0x157790C", VA = "0x157790C")]
		private Vector3 HandleVelocity(Vector3 velocity)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000BD8")]
		[Address(RVA = "0x15771F8", Offset = "0x15771F8", VA = "0x15771F8")]
		private Vector3 GetPosition(Vector3 inputPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000BD9")]
		[Address(RVA = "0x1577520", Offset = "0x1577520", VA = "0x1577520")]
		private Quaternion GetRotation(Quaternion inputRotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000BDA")]
		[Address(RVA = "0x15778A4", Offset = "0x15778A4", VA = "0x15778A4")]
		private Vector3 GetScale(Vector3 inputScale)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000BDB")]
		[Address(RVA = "0x156B5C4", Offset = "0x156B5C4", VA = "0x156B5C4")]
		public TransformModule()
		{
		}
	}
}
namespace Dreamteck.Splines.Primitives
{
	[Token(Token = "0x2000177")]
	public class Capsule : SplinePrimitive
	{
		[Token(Token = "0x400088D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float radius;

		[Token(Token = "0x400088E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float height;

		[Token(Token = "0x6000BDD")]
		[Address(RVA = "0x13DCA3C", Offset = "0x13DCA3C", VA = "0x13DCA3C", Slot = "4")]
		protected override void Generate()
		{
		}

		[Token(Token = "0x6000BDE")]
		[Address(RVA = "0x13DD354", Offset = "0x13DD354", VA = "0x13DD354")]
		public Capsule()
		{
		}
	}
	[Token(Token = "0x2000178")]
	public class Ellipse : SplinePrimitive
	{
		[Token(Token = "0x400088F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float xRadius;

		[Token(Token = "0x4000890")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float yRadius;

		[Token(Token = "0x6000BDF")]
		[Address(RVA = "0x13DD410", Offset = "0x13DD410", VA = "0x13DD410", Slot = "4")]
		protected override void Generate()
		{
		}

		[Token(Token = "0x6000BE0")]
		[Address(RVA = "0x13DD824", Offset = "0x13DD824", VA = "0x13DD824")]
		public Ellipse()
		{
		}
	}
	[Token(Token = "0x2000179")]
	public class Line : SplinePrimitive
	{
		[Token(Token = "0x4000891")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool mirror;

		[Token(Token = "0x4000892")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float length;

		[Token(Token = "0x4000893")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public int segments;

		[Token(Token = "0x6000BE1")]
		[Address(RVA = "0x13DD830", Offset = "0x13DD830", VA = "0x13DD830", Slot = "4")]
		protected override void Generate()
		{
		}

		[Token(Token = "0x6000BE2")]
		[Address(RVA = "0x13DDA90", Offset = "0x13DDA90", VA = "0x13DDA90")]
		public Line()
		{
		}
	}
	[Token(Token = "0x200017A")]
	public class Ngon : SplinePrimitive
	{
		[Token(Token = "0x4000894")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float radius;

		[Token(Token = "0x4000895")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public int sides;

		[Token(Token = "0x6000BE3")]
		[Address(RVA = "0x13DDAA8", Offset = "0x13DDAA8", VA = "0x13DDAA8", Slot = "4")]
		protected override void Generate()
		{
		}

		[Token(Token = "0x6000BE4")]
		[Address(RVA = "0x13DDC84", Offset = "0x13DDC84", VA = "0x13DDC84")]
		public Ngon()
		{
		}
	}
	[Token(Token = "0x200017B")]
	public class Rectangle : SplinePrimitive
	{
		[Token(Token = "0x4000896")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Vector2 size;

		[Token(Token = "0x6000BE5")]
		[Address(RVA = "0x13DDC94", Offset = "0x13DDC94", VA = "0x13DDC94", Slot = "4")]
		protected override void Generate()
		{
		}

		[Token(Token = "0x6000BE6")]
		[Address(RVA = "0x13DDFC4", Offset = "0x13DDFC4", VA = "0x13DDFC4")]
		public Rectangle()
		{
		}
	}
	[Token(Token = "0x200017C")]
	public class RoundedRectangle : SplinePrimitive
	{
		[Token(Token = "0x4000897")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Vector2 size;

		[Token(Token = "0x4000898")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float xRadius;

		[Token(Token = "0x4000899")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float yRadius;

		[Token(Token = "0x6000BE7")]
		[Address(RVA = "0x13DE034", Offset = "0x13DE034", VA = "0x13DE034", Slot = "4")]
		protected override void Generate()
		{
		}

		[Token(Token = "0x6000BE8")]
		[Address(RVA = "0x13DE98C", Offset = "0x13DE98C", VA = "0x13DE98C")]
		public RoundedRectangle()
		{
		}
	}
	[Token(Token = "0x200017D")]
	public class Spiral : SplinePrimitive
	{
		[Token(Token = "0x400089A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float startRadius;

		[Token(Token = "0x400089B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float endRadius;

		[Token(Token = "0x400089C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float stretch;

		[Token(Token = "0x400089D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public int iterations;

		[Token(Token = "0x400089E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AnimationCurve curve;

		[Token(Token = "0x6000BE9")]
		[Address(RVA = "0x13DEA04", Offset = "0x13DEA04", VA = "0x13DEA04", Slot = "4")]
		protected override void Generate()
		{
		}

		[Token(Token = "0x6000BEA")]
		[Address(RVA = "0x13DF018", Offset = "0x13DF018", VA = "0x13DF018")]
		public Spiral()
		{
		}
	}
	[Token(Token = "0x200017E")]
	public class SplinePrimitive
	{
		[Token(Token = "0x20001FA")]
		public enum Axis
		{
			[Token(Token = "0x4000AE7")]
			X,
			[Token(Token = "0x4000AE8")]
			Y,
			[Token(Token = "0x4000AE9")]
			Z,
			[Token(Token = "0x4000AEA")]
			nX,
			[Token(Token = "0x4000AEB")]
			nY,
			[Token(Token = "0x4000AEC")]
			nZ
		}

		[Token(Token = "0x400089F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected bool closed;

		[Token(Token = "0x40008A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected SplinePoint[] points;

		[Token(Token = "0x40008A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected Spline.Type type;

		[Token(Token = "0x40008A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Axis axis;

		[Token(Token = "0x40008A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 offset;

		[Token(Token = "0x40008A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Vector3 rotation;

		[Token(Token = "0x6000BEB")]
		[Address(RVA = "0x13DD1E8", Offset = "0x13DD1E8", VA = "0x13DD1E8", Slot = "4")]
		protected virtual void Generate()
		{
		}

		[Token(Token = "0x6000BEC")]
		[Address(RVA = "0x13DF090", Offset = "0x13DF090", VA = "0x13DF090")]
		public Spline GetSpline()
		{
			return null;
		}

		[Token(Token = "0x6000BED")]
		[Address(RVA = "0x13DF510", Offset = "0x13DF510", VA = "0x13DF510")]
		public void UpdateSpline(Spline spline)
		{
		}

		[Token(Token = "0x6000BEE")]
		[Address(RVA = "0x13DF5AC", Offset = "0x13DF5AC", VA = "0x13DF5AC")]
		public SplineComputer CreateSplineComputer(string name, Vector3 position, Quaternion rotation)
		{
			return null;
		}

		[Token(Token = "0x6000BEF")]
		[Address(RVA = "0x13DF714", Offset = "0x13DF714", VA = "0x13DF714")]
		public void UpdateSplineComputer(SplineComputer comp)
		{
		}

		[Token(Token = "0x6000BF0")]
		[Address(RVA = "0x13DF134", Offset = "0x13DF134", VA = "0x13DF134")]
		private void ApplyOffset()
		{
		}

		[Token(Token = "0x6000BF1")]
		[Address(RVA = "0x13DD1EC", Offset = "0x13DD1EC", VA = "0x13DD1EC")]
		protected void CreatePoints(int count, SplinePoint.Type type)
		{
		}

		[Token(Token = "0x6000BF2")]
		[Address(RVA = "0x13DF7B8", Offset = "0x13DF7B8", VA = "0x13DF7B8")]
		protected Vector3 GetNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000BF3")]
		[Address(RVA = "0x13DD364", Offset = "0x13DD364", VA = "0x13DD364")]
		public SplinePrimitive()
		{
		}
	}
	[Token(Token = "0x200017F")]
	public class Star : SplinePrimitive
	{
		[Token(Token = "0x40008A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float radius;

		[Token(Token = "0x40008A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float depth;

		[Token(Token = "0x40008A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public int sides;

		[Token(Token = "0x6000BF4")]
		[Address(RVA = "0x13DF92C", Offset = "0x13DF92C", VA = "0x13DF92C", Slot = "4")]
		protected override void Generate()
		{
		}

		[Token(Token = "0x6000BF5")]
		[Address(RVA = "0x13DFB78", Offset = "0x13DFB78", VA = "0x13DFB78")]
		public Star()
		{
		}
	}
}
namespace Dreamteck.Splines.IO
{
	[Token(Token = "0x2000180")]
	public class CSV : SplineParser
	{
		[Token(Token = "0x20001FB")]
		public enum ColumnType
		{
			[Token(Token = "0x4000AEE")]
			Position,
			[Token(Token = "0x4000AEF")]
			Tangent,
			[Token(Token = "0x4000AF0")]
			Tangent2,
			[Token(Token = "0x4000AF1")]
			Normal,
			[Token(Token = "0x4000AF2")]
			Size,
			[Token(Token = "0x4000AF3")]
			Color
		}

		[Token(Token = "0x40008A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<ColumnType> columns;

		[Token(Token = "0x6000BF6")]
		[Address(RVA = "0x122A918", Offset = "0x122A918", VA = "0x122A918")]
		public CSV(SplineComputer computer)
		{
		}

		[Token(Token = "0x6000BF7")]
		[Address(RVA = "0x122AB28", Offset = "0x122AB28", VA = "0x122AB28")]
		public CSV(string filePath, [Optional] List<ColumnType> customColumns)
		{
		}

		[Token(Token = "0x6000BF8")]
		[Address(RVA = "0x122AD74", Offset = "0x122AD74", VA = "0x122AD74")]
		private void Read(string[] lines)
		{
		}

		[Token(Token = "0x6000BF9")]
		[Address(RVA = "0x122B7F0", Offset = "0x122B7F0", VA = "0x122B7F0")]
		public SplineComputer CreateSplineComputer(Vector3 position, Quaternion rotation)
		{
			return null;
		}

		[Token(Token = "0x6000BFA")]
		[Address(RVA = "0x122B80C", Offset = "0x122B80C", VA = "0x122B80C")]
		public Spline CreateSpline()
		{
			return null;
		}

		[Token(Token = "0x6000BFB")]
		[Address(RVA = "0x122B828", Offset = "0x122B828", VA = "0x122B828")]
		public void FlatX()
		{
		}

		[Token(Token = "0x6000BFC")]
		[Address(RVA = "0x122B9AC", Offset = "0x122B9AC", VA = "0x122B9AC")]
		public void FlatY()
		{
		}

		[Token(Token = "0x6000BFD")]
		[Address(RVA = "0x122BB34", Offset = "0x122BB34", VA = "0x122BB34")]
		public void FlatZ()
		{
		}

		[Token(Token = "0x6000BFE")]
		[Address(RVA = "0x122BCFC", Offset = "0x122BCFC", VA = "0x122BCFC")]
		private void AddTitle(ref string[] content, string title)
		{
		}

		[Token(Token = "0x6000BFF")]
		[Address(RVA = "0x122BDC8", Offset = "0x122BDC8", VA = "0x122BDC8")]
		private void AddVector3Title(ref string[] content, string prefix)
		{
		}

		[Token(Token = "0x6000C00")]
		[Address(RVA = "0x122BF70", Offset = "0x122BF70", VA = "0x122BF70")]
		private void AddColorTitle(ref string[] content, string prefix)
		{
		}

		[Token(Token = "0x6000C01")]
		[Address(RVA = "0x122C174", Offset = "0x122C174", VA = "0x122C174")]
		private void AddVector3(ref string[] content, int index, Vector3 vector)
		{
		}

		[Token(Token = "0x6000C02")]
		[Address(RVA = "0x122C2C8", Offset = "0x122C2C8", VA = "0x122C2C8")]
		private void AddColor(ref string[] content, int index, Color color)
		{
		}

		[Token(Token = "0x6000C03")]
		[Address(RVA = "0x122C1C4", Offset = "0x122C1C4", VA = "0x122C1C4")]
		private void AddFloat(ref string[] content, int index, float value)
		{
		}

		[Token(Token = "0x6000C04")]
		[Address(RVA = "0x122C334", Offset = "0x122C334", VA = "0x122C334")]
		public void Write(string filePath)
		{
		}
	}
	[Token(Token = "0x2000181")]
	public class SVG : SplineParser
	{
		[Token(Token = "0x20001FC")]
		public enum Axis
		{
			[Token(Token = "0x4000AF5")]
			X,
			[Token(Token = "0x4000AF6")]
			Y,
			[Token(Token = "0x4000AF7")]
			Z
		}

		[Token(Token = "0x20001FD")]
		internal class PathSegment
		{
			[Token(Token = "0x2000236")]
			internal enum Type
			{
				[Token(Token = "0x4000BC0")]
				Cubic,
				[Token(Token = "0x4000BC1")]
				CubicShort,
				[Token(Token = "0x4000BC2")]
				Quadratic,
				[Token(Token = "0x4000BC3")]
				QuadraticShort
			}

			[Token(Token = "0x4000AF8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal Vector3 startTangent;

			[Token(Token = "0x4000AF9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			internal Vector3 endTangent;

			[Token(Token = "0x4000AFA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal Vector3 endPoint;

			[Token(Token = "0x6000DB7")]
			[Address(RVA = "0x1232B4C", Offset = "0x1232B4C", VA = "0x1232B4C")]
			internal PathSegment(Vector2 s, Vector2 e, Vector2 c)
			{
			}

			[Token(Token = "0x6000DB8")]
			[Address(RVA = "0x1232AB4", Offset = "0x1232AB4", VA = "0x1232AB4")]
			internal PathSegment()
			{
			}
		}

		[Token(Token = "0x20001FE")]
		public enum Element
		{
			[Token(Token = "0x4000AFC")]
			All,
			[Token(Token = "0x4000AFD")]
			Path,
			[Token(Token = "0x4000AFE")]
			Polygon,
			[Token(Token = "0x4000AFF")]
			Ellipse,
			[Token(Token = "0x4000B00")]
			Rectangle,
			[Token(Token = "0x4000B01")]
			Line
		}

		[Serializable]
		[Token(Token = "0x20001FF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x831CB4", Offset = "0x831CB4")]
		private sealed class <>c
		{
			[Token(Token = "0x4000B02")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000B03")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<string, bool> <>9__23_0;

			[Token(Token = "0x6000DBA")]
			[Address(RVA = "0x1232CE4", Offset = "0x1232CE4", VA = "0x1232CE4")]
			public <>c()
			{
			}

			[Token(Token = "0x6000DBB")]
			[Address(RVA = "0x1232CEC", Offset = "0x1232CEC", VA = "0x1232CEC")]
			internal bool <ReadPath>b__23_0(string t)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40008A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<SplineDefinition> paths;

		[Token(Token = "0x40008AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<SplineDefinition> polygons;

		[Token(Token = "0x40008AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<SplineDefinition> ellipses;

		[Token(Token = "0x40008AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<SplineDefinition> rectangles;

		[Token(Token = "0x40008AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private List<SplineDefinition> lines;

		[Token(Token = "0x40008AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<Transformation> transformBuffer;

		[Token(Token = "0x6000C05")]
		[Address(RVA = "0x122C800", Offset = "0x122C800", VA = "0x122C800")]
		public SVG(string filePath)
		{
		}

		[Token(Token = "0x6000C06")]
		[Address(RVA = "0x122CB88", Offset = "0x122CB88", VA = "0x122CB88")]
		public SVG(List<SplineComputer> computers)
		{
		}

		[Token(Token = "0x6000C07")]
		[Address(RVA = "0x122CEC8", Offset = "0x122CEC8", VA = "0x122CEC8")]
		public void Write(string filePath, Axis ax = Axis.Z)
		{
		}

		[Token(Token = "0x6000C08")]
		[Address(RVA = "0x122DCCC", Offset = "0x122DCCC", VA = "0x122DCCC")]
		private Vector2 MapPoint(Vector3 original, Axis ax)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000C09")]
		[Address(RVA = "0x122CB04", Offset = "0x122CB04", VA = "0x122CB04")]
		private void Read(XmlDocument doc)
		{
		}

		[Token(Token = "0x6000C0A")]
		[Address(RVA = "0x122DDB4", Offset = "0x122DDB4", VA = "0x122DDB4")]
		private void Traverse(XmlNodeList nodes)
		{
		}

		[Token(Token = "0x6000C0B")]
		[Address(RVA = "0x122F85C", Offset = "0x122F85C", VA = "0x122F85C")]
		public List<SplineComputer> CreateSplineComputers(Vector3 position, Quaternion rotation, Element elements = Element.All)
		{
			return null;
		}

		[Token(Token = "0x6000C0C")]
		[Address(RVA = "0x122FEA4", Offset = "0x122FEA4", VA = "0x122FEA4")]
		public List<Spline> CreateSplines(Element elements = Element.All)
		{
			return null;
		}

		[Token(Token = "0x6000C0D")]
		[Address(RVA = "0x122F3D4", Offset = "0x122F3D4", VA = "0x122F3D4")]
		private int ReadRectangle(XmlNode rectNode)
		{
			return default(int);
		}

		[Token(Token = "0x6000C0E")]
		[Address(RVA = "0x122F110", Offset = "0x122F110", VA = "0x122F110")]
		private int ReadLine(XmlNode lineNode)
		{
			return default(int);
		}

		[Token(Token = "0x6000C0F")]
		[Address(RVA = "0x122ED30", Offset = "0x122ED30", VA = "0x122ED30")]
		private int ReadEllipse(XmlNode ellipseNode)
		{
			return default(int);
		}

		[Token(Token = "0x6000C10")]
		[Address(RVA = "0x122EA5C", Offset = "0x122EA5C", VA = "0x122EA5C")]
		private int ReadPolygon(XmlNode polyNode, bool closed)
		{
			return default(int);
		}

		[Token(Token = "0x6000C11")]
		[Address(RVA = "0x122E2DC", Offset = "0x122E2DC", VA = "0x122E2DC")]
		private int ParseTransformation(XmlNode node)
		{
			return default(int);
		}

		[Token(Token = "0x6000C12")]
		[Address(RVA = "0x12307E4", Offset = "0x12307E4", VA = "0x12307E4")]
		private List<Transformation> ParseTransformations(string transformContent)
		{
			return null;
		}

		[Token(Token = "0x6000C13")]
		[Address(RVA = "0x122E398", Offset = "0x122E398", VA = "0x122E398")]
		private int ReadPath(XmlNode pathNode)
		{
			return default(int);
		}

		[Token(Token = "0x6000C14")]
		[Address(RVA = "0x123154C", Offset = "0x123154C", VA = "0x123154C")]
		private void PathStart(string name, string coords, bool relative)
		{
		}

		[Token(Token = "0x6000C15")]
		[Address(RVA = "0x1231714", Offset = "0x1231714", VA = "0x1231714")]
		private void PathClose()
		{
		}

		[Token(Token = "0x6000C16")]
		[Address(RVA = "0x1231734", Offset = "0x1231734", VA = "0x1231734")]
		private void PathLineTo(string coords, bool relative)
		{
		}

		[Token(Token = "0x6000C17")]
		[Address(RVA = "0x12318BC", Offset = "0x12318BC", VA = "0x12318BC")]
		private void PathHorizontalLineTo(string coords, bool relative)
		{
		}

		[Token(Token = "0x6000C18")]
		[Address(RVA = "0x1231964", Offset = "0x1231964", VA = "0x1231964")]
		private void PathVerticalLineTo(string coords, bool relative)
		{
		}

		[Token(Token = "0x6000C19")]
		[Address(RVA = "0x1231A14", Offset = "0x1231A14", VA = "0x1231A14")]
		private void PathCurveTo(string coords, PathSegment.Type type, bool relative)
		{
		}

		[Token(Token = "0x6000C1A")]
		[Address(RVA = "0x123055C", Offset = "0x123055C", VA = "0x123055C")]
		private void WriteBufferTo(List<SplineDefinition> list)
		{
		}

		[Token(Token = "0x6000C1B")]
		[Address(RVA = "0x1232304", Offset = "0x1232304", VA = "0x1232304")]
		private PathSegment[] ParsePathSegment(string coord, PathSegment.Type type)
		{
			return null;
		}

		[Token(Token = "0x6000C1C")]
		[Address(RVA = "0x122D6E4", Offset = "0x122D6E4", VA = "0x122D6E4")]
		private string EncodePath(SplineDefinition definition, Axis ax)
		{
			return null;
		}

		[Token(Token = "0x6000C1D")]
		[Address(RVA = "0x122D468", Offset = "0x122D468", VA = "0x122D468")]
		private string EncodePolygon(SplineDefinition definition, Axis ax)
		{
			return null;
		}

		[Token(Token = "0x6000C1E")]
		[Address(RVA = "0x1230424", Offset = "0x1230424", VA = "0x1230424")]
		private string GetAttributeContent(XmlNode node, string attributeName)
		{
			return null;
		}
	}
	[Token(Token = "0x2000182")]
	public class SplineParser
	{
		[Token(Token = "0x2000200")]
		internal class Transformation
		{
			[Token(Token = "0x4000B04")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			protected static Matrix4x4 matrix;

			[Token(Token = "0x6000DBC")]
			[Address(RVA = "0x13CDB38", Offset = "0x13CDB38", VA = "0x13CDB38")]
			internal static void ResetMatrix()
			{
			}

			[Token(Token = "0x6000DBD")]
			[Address(RVA = "0x13CDE14", Offset = "0x13CDE14", VA = "0x13CDE14", Slot = "4")]
			internal virtual void Push()
			{
			}

			[Token(Token = "0x6000DBE")]
			[Address(RVA = "0x13CDC64", Offset = "0x13CDC64", VA = "0x13CDC64")]
			internal static void Apply(SplinePoint[] points)
			{
			}

			[Token(Token = "0x6000DBF")]
			[Address(RVA = "0x13CCAD4", Offset = "0x13CCAD4", VA = "0x13CCAD4")]
			public Transformation()
			{
			}
		}

		[Token(Token = "0x2000201")]
		internal class Translate : Transformation
		{
			[Token(Token = "0x4000B05")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private Vector2 offset;

			[Token(Token = "0x6000DC1")]
			[Address(RVA = "0x13CDE1C", Offset = "0x13CDE1C", VA = "0x13CDE1C")]
			public Translate(Vector2 o)
			{
			}

			[Token(Token = "0x6000DC2")]
			[Address(RVA = "0x13CDEC8", Offset = "0x13CDEC8", VA = "0x13CDEC8", Slot = "4")]
			internal override void Push()
			{
			}
		}

		[Token(Token = "0x2000202")]
		internal class Rotate : Transformation
		{
			[Token(Token = "0x4000B06")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private float angle;

			[Token(Token = "0x6000DC3")]
			[Address(RVA = "0x123121C", Offset = "0x123121C", VA = "0x123121C")]
			public Rotate(float a)
			{
			}

			[Token(Token = "0x6000DC4")]
			[Address(RVA = "0x1232EE0", Offset = "0x1232EE0", VA = "0x1232EE0", Slot = "4")]
			internal override void Push()
			{
			}
		}

		[Token(Token = "0x2000203")]
		internal class Scale : Transformation
		{
			[Token(Token = "0x4000B07")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private Vector2 multiplier;

			[Token(Token = "0x6000DC5")]
			[Address(RVA = "0x1231298", Offset = "0x1231298", VA = "0x1231298")]
			public Scale(Vector2 s)
			{
			}

			[Token(Token = "0x6000DC6")]
			[Address(RVA = "0x12330E8", Offset = "0x12330E8", VA = "0x12330E8", Slot = "4")]
			internal override void Push()
			{
			}
		}

		[Token(Token = "0x2000204")]
		internal class SkewX : Transformation
		{
			[Token(Token = "0x4000B08")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private float amount;

			[Token(Token = "0x6000DC7")]
			[Address(RVA = "0x1231344", Offset = "0x1231344", VA = "0x1231344")]
			public SkewX(float a)
			{
			}

			[Token(Token = "0x6000DC8")]
			[Address(RVA = "0x12332F4", Offset = "0x12332F4", VA = "0x12332F4", Slot = "4")]
			internal override void Push()
			{
			}
		}

		[Token(Token = "0x2000205")]
		internal class SkewY : Transformation
		{
			[Token(Token = "0x4000B09")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private float amount;

			[Token(Token = "0x6000DC9")]
			[Address(RVA = "0x13CCA58", Offset = "0x13CCA58", VA = "0x13CCA58")]
			public SkewY(float a)
			{
			}

			[Token(Token = "0x6000DCA")]
			[Address(RVA = "0x13CCADC", Offset = "0x13CCADC", VA = "0x13CCADC", Slot = "4")]
			internal override void Push()
			{
			}
		}

		[Token(Token = "0x2000206")]
		internal class MatrixTransform : Transformation
		{
			[Token(Token = "0x4000B0A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private Matrix4x4 transformMatrix;

			[Token(Token = "0x6000DCB")]
			[Address(RVA = "0x12313C0", Offset = "0x12313C0", VA = "0x12313C0")]
			public MatrixTransform(float a, float b, float c, float d, float e, float f)
			{
			}

			[Token(Token = "0x6000DCC")]
			[Address(RVA = "0x1232DDC", Offset = "0x1232DDC", VA = "0x1232DDC", Slot = "4")]
			internal override void Push()
			{
			}
		}

		[Token(Token = "0x2000207")]
		internal class SplineDefinition
		{
			[Token(Token = "0x4000B0B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal string name;

			[Token(Token = "0x4000B0C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal Spline.Type type;

			[Token(Token = "0x4000B0D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal List<SplinePoint> points;

			[Token(Token = "0x4000B0E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal bool closed;

			[Token(Token = "0x4000B0F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			internal Vector3 position;

			[Token(Token = "0x4000B10")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal Vector3 tangent;

			[Token(Token = "0x4000B11")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			internal Vector3 tangent2;

			[Token(Token = "0x4000B12")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			internal Vector3 normal;

			[Token(Token = "0x4000B13")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			internal float size;

			[Token(Token = "0x4000B14")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			internal Color color;

			[Token(Token = "0x17000117")]
			internal int pointCount
			{
				[Token(Token = "0x6000DCD")]
				[Address(RVA = "0x13CCCAC", Offset = "0x13CCCAC", VA = "0x13CCCAC")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x6000DCE")]
			[Address(RVA = "0x13CCCFC", Offset = "0x13CCCFC", VA = "0x13CCCFC")]
			internal SplineDefinition(string n, Spline.Type t)
			{
			}

			[Token(Token = "0x6000DCF")]
			[Address(RVA = "0x13CCE18", Offset = "0x13CCE18", VA = "0x13CCE18")]
			internal SplineDefinition(string n, Spline spline)
			{
			}

			[Token(Token = "0x6000DD0")]
			[Address(RVA = "0x13CCFC4", Offset = "0x13CCFC4", VA = "0x13CCFC4")]
			internal SplinePoint GetLastPoint()
			{
				return default(SplinePoint);
			}

			[Token(Token = "0x6000DD1")]
			[Address(RVA = "0x13CD060", Offset = "0x13CD060", VA = "0x13CD060")]
			internal void SetLastPoint(SplinePoint point)
			{
			}

			[Token(Token = "0x6000DD2")]
			[Address(RVA = "0x13CD10C", Offset = "0x13CD10C", VA = "0x13CD10C")]
			internal void CreateClosingPoint()
			{
			}

			[Token(Token = "0x6000DD3")]
			[Address(RVA = "0x13CD1F0", Offset = "0x13CD1F0", VA = "0x13CD1F0")]
			internal void CreateSmooth()
			{
			}

			[Token(Token = "0x6000DD4")]
			[Address(RVA = "0x13CD314", Offset = "0x13CD314", VA = "0x13CD314")]
			internal void CreateBroken()
			{
			}

			[Token(Token = "0x6000DD5")]
			[Address(RVA = "0x13CD4B4", Offset = "0x13CD4B4", VA = "0x13CD4B4")]
			internal void CreateLinear()
			{
			}

			[Token(Token = "0x6000DD6")]
			[Address(RVA = "0x13CD4C8", Offset = "0x13CD4C8", VA = "0x13CD4C8")]
			internal SplineComputer CreateSplineComputer(Vector3 position, Quaternion rotation)
			{
				return null;
			}

			[Token(Token = "0x6000DD7")]
			[Address(RVA = "0x13CD6D4", Offset = "0x13CD6D4", VA = "0x13CD6D4")]
			internal Spline CreateSpline()
			{
				return null;
			}

			[Token(Token = "0x6000DD8")]
			[Address(RVA = "0x13CD8C4", Offset = "0x13CD8C4", VA = "0x13CD8C4")]
			internal void Transform(List<Transformation> trs)
			{
			}
		}

		[Token(Token = "0x40008AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected string fileName;

		[Token(Token = "0x40008B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal SplineDefinition buffer;

		[Token(Token = "0x170000C6")]
		public string name
		{
			[Token(Token = "0x6000C1F")]
			[Address(RVA = "0x1232D10", Offset = "0x1232D10", VA = "0x1232D10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000C20")]
		[Address(RVA = "0x1232000", Offset = "0x1232000", VA = "0x1232000")]
		internal Vector2[] ParseVector2(string coord)
		{
			return null;
		}

		[Token(Token = "0x6000C21")]
		[Address(RVA = "0x123220C", Offset = "0x123220C", VA = "0x123220C")]
		internal float[] ParseFloat(string coord)
		{
			return null;
		}

		[Token(Token = "0x6000C22")]
		[Address(RVA = "0x12305E0", Offset = "0x12305E0", VA = "0x12305E0")]
		internal List<float> ParseFloatArray(string content)
		{
			return null;
		}

		[Token(Token = "0x6000C23")]
		[Address(RVA = "0x1232D18", Offset = "0x1232D18", VA = "0x1232D18")]
		public bool IsWHiteSpace(string s)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C24")]
		[Address(RVA = "0x122AAD0", Offset = "0x122AAD0", VA = "0x122AAD0")]
		public SplineParser()
		{
		}
	}
}
namespace UnityAsyncAwaitUtil
{
	[Token(Token = "0x2000183")]
	public class AsyncCoroutineRunner : MonoBehaviour
	{
		[Token(Token = "0x40008B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static AsyncCoroutineRunner _instance;

		[Token(Token = "0x170000C7")]
		public static AsyncCoroutineRunner Instance
		{
			[Token(Token = "0x6000C25")]
			[Address(RVA = "0xFBB330", Offset = "0xFBB330", VA = "0xFBB330")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000C26")]
		[Address(RVA = "0xFBB410", Offset = "0xFBB410", VA = "0xFBB410")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000C27")]
		[Address(RVA = "0xFBB4AC", Offset = "0xFBB4AC", VA = "0xFBB4AC")]
		public AsyncCoroutineRunner()
		{
		}
	}
	[Token(Token = "0x2000184")]
	public static class SyncContextUtil
	{
		[Token(Token = "0x40008B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x834C6C", Offset = "0x834C6C")]
		private static int <UnityThreadId>k__BackingField;

		[Token(Token = "0x40008B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x834C7C", Offset = "0x834C7C")]
		private static SynchronizationContext <UnitySynchronizationContext>k__BackingField;

		[Token(Token = "0x170000C8")]
		public static int UnityThreadId
		{
			[Token(Token = "0x6000C29")]
			[Address(RVA = "0xFC0C10", Offset = "0xFC0C10", VA = "0xFC0C10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8360E4", Offset = "0x8360E4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000C2A")]
			[Address(RVA = "0xFC0C60", Offset = "0xFC0C60", VA = "0xFC0C60")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8360F4", Offset = "0x8360F4")]
			private set
			{
			}
		}

		[Token(Token = "0x170000C9")]
		public static SynchronizationContext UnitySynchronizationContext
		{
			[Token(Token = "0x6000C2B")]
			[Address(RVA = "0xFC0CB4", Offset = "0xFC0CB4", VA = "0xFC0CB4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x836104", Offset = "0x836104")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C2C")]
			[Address(RVA = "0xFC0D04", Offset = "0xFC0D04", VA = "0xFC0D04")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x836114", Offset = "0x836114")]
			private set
			{
			}
		}

		[Token(Token = "0x6000C28")]
		[Address(RVA = "0xFC0B60", Offset = "0xFC0B60", VA = "0xFC0B60")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x8360D0", Offset = "0x8360D0")]
		private static void Install()
		{
		}
	}
	[Token(Token = "0x2000185")]
	public class AsyncUtilTests : MonoBehaviour
	{
		[Token(Token = "0x2000208")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x831CC4", Offset = "0x831CC4")]
		private sealed class <RunAsyncFromCoroutineTest>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000B15")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000B16")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000B17")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AsyncUtilTests <>4__this;

			[Token(Token = "0x17000118")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000DDC")]
				[Address(RVA = "0xFBDFC4", Offset = "0xFBDFC4", VA = "0xFBDFC4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000119")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000DDE")]
				[Address(RVA = "0xFBE02C", Offset = "0xFBE02C", VA = "0xFBE02C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000DD9")]
			[Address(RVA = "0xFBC5B8", Offset = "0xFBC5B8", VA = "0xFBC5B8")]
			[DebuggerHidden]
			public <RunAsyncFromCoroutineTest>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x6000DDA")]
			[Address(RVA = "0xFBDE58", Offset = "0xFBDE58", VA = "0xFBDE58", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000DDB")]
			[Address(RVA = "0xFBDE5C", Offset = "0xFBDE5C", VA = "0xFBDE5C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000DDD")]
			[Address(RVA = "0xFBDFCC", Offset = "0xFBDFCC", VA = "0xFBDFCC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000209")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x831CD4", Offset = "0x831CD4")]
		private struct <RunMultipleThreadsTestAsync>d__7 : IAsyncStateMachine
		{
			[Token(Token = "0x4000B18")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000B19")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000B1A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AsyncUtilTests <>4__this;

			[Token(Token = "0x4000B1B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private TaskAwaiter <>u__1;

			[Token(Token = "0x4000B1C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2;

			[Token(Token = "0x4000B1D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private object <>u__3;

			[Token(Token = "0x6000DDF")]
			[Address(RVA = "0x8DECA8", Offset = "0x8DECA8", VA = "0x8DECA8", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000DE0")]
			[Address(RVA = "0x8DECB0", Offset = "0x8DECB0", VA = "0x8DECB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200020A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x831CE4", Offset = "0x831CE4")]
		private struct <RunMultipleThreadsTestAsyncWait>d__8 : IAsyncStateMachine
		{
			[Token(Token = "0x4000B1E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000B1F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000B20")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AsyncUtilTests <>4__this;

			[Token(Token = "0x4000B21")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private object <>u__1;

			[Token(Token = "0x6000DE1")]
			[Address(RVA = "0x8DECBC", Offset = "0x8DECBC", VA = "0x8DECBC", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000DE2")]
			[Address(RVA = "0x8DECC4", Offset = "0x8DECC4", VA = "0x8DECC4", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200020B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x831CF4", Offset = "0x831CF4")]
		private struct <RunAsyncFromCoroutineTest2>d__10 : IAsyncStateMachine
		{
			[Token(Token = "0x4000B22")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000B23")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000B24")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private object <>u__1;

			[Token(Token = "0x6000DE3")]
			[Address(RVA = "0x8DEC08", Offset = "0x8DEC08", VA = "0x8DEC08", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000DE4")]
			[Address(RVA = "0x8DEC10", Offset = "0x8DEC10", VA = "0x8DEC10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200020C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x831D04", Offset = "0x831D04")]
		private struct <RunWwwAsync>d__11 : IAsyncStateMachine
		{
			[Token(Token = "0x4000B25")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000B26")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000B27")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private object <>u__1;

			[Token(Token = "0x6000DE5")]
			[Address(RVA = "0x8DED20", Offset = "0x8DED20", VA = "0x8DED20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000DE6")]
			[Address(RVA = "0x8DED28", Offset = "0x8DED28", VA = "0x8DED28", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200020D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x831D14", Offset = "0x831D14")]
		private struct <RunOpenNotepadTestAsync>d__12 : IAsyncStateMachine
		{
			[Token(Token = "0x4000B28")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000B29")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000B2A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private TaskAwaiter<int> <>u__1;

			[Token(Token = "0x6000DE7")]
			[Address(RVA = "0x8DECD0", Offset = "0x8DECD0", VA = "0x8DECD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000DE8")]
			[Address(RVA = "0x8DECD8", Offset = "0x8DECD8", VA = "0x8DECD8", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200020E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x831D24", Offset = "0x831D24")]
		private struct <RunUnhandledExceptionTestAsync>d__13 : IAsyncStateMachine
		{
			[Token(Token = "0x4000B2B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000B2C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000B2D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AsyncUtilTests <>4__this;

			[Token(Token = "0x4000B2E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private TaskAwaiter <>u__1;

			[Token(Token = "0x6000DE9")]
			[Address(RVA = "0x8DED0C", Offset = "0x8DED0C", VA = "0x8DED0C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000DEA")]
			[Address(RVA = "0x8DED14", Offset = "0x8DED14", VA = "0x8DED14", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200020F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x831D34", Offset = "0x831D34")]
		private struct <RunTryCatchExceptionTestAsync>d__14 : IAsyncStateMachine
		{
			[Token(Token = "0x4000B2F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000B30")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000B31")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AsyncUtilTests <>4__this;

			[Token(Token = "0x4000B32")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private TaskAwaiter <>u__1;

			[Token(Token = "0x6000DEB")]
			[Address(RVA = "0x8DECF8", Offset = "0x8DECF8", VA = "0x8DECF8", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000DEC")]
			[Address(RVA = "0x8DED00", Offset = "0x8DED00", VA = "0x8DED00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000210")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x831D44", Offset = "0x831D44")]
		private struct <NestedRunAsync>d__15 : IAsyncStateMachine
		{
			[Token(Token = "0x4000B33")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000B34")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000B35")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private object <>u__1;

			[Token(Token = "0x6000DED")]
			[Address(RVA = "0x8DEBF4", Offset = "0x8DEBF4", VA = "0x8DEBF4", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000DEE")]
			[Address(RVA = "0x8DEBFC", Offset = "0x8DEBFC", VA = "0x8DEBFC", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000211")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x831D54", Offset = "0x831D54")]
		private struct <WaitThenThrowException>d__16 : IAsyncStateMachine
		{
			[Token(Token = "0x4000B36")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000B37")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000B38")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private object <>u__1;

			[Token(Token = "0x6000DEF")]
			[Address(RVA = "0x8DED34", Offset = "0x8DED34", VA = "0x8DED34", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000DF0")]
			[Address(RVA = "0x8DED3C", Offset = "0x8DED3C", VA = "0x8DED3C", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000212")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x831D64", Offset = "0x831D64")]
		private struct <RunAsyncOperationAsync>d__17 : IAsyncStateMachine
		{
			[Token(Token = "0x4000B39")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000B3A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000B3B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AsyncUtilTests <>4__this;

			[Token(Token = "0x4000B3C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private TaskAwaiter <>u__1;

			[Token(Token = "0x6000DF1")]
			[Address(RVA = "0x8DEC1C", Offset = "0x8DEC1C", VA = "0x8DEC1C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000DF2")]
			[Address(RVA = "0x8DEC24", Offset = "0x8DEC24", VA = "0x8DEC24", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000213")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x831D74", Offset = "0x831D74")]
		private struct <InstantiateAssetBundleAsync>d__18 : IAsyncStateMachine
		{
			[Token(Token = "0x4000B3D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000B3E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000B3F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AsyncUtilTests <>4__this;

			[Token(Token = "0x4000B40")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string abUrl;

			[Token(Token = "0x4000B41")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string assetName;

			[Token(Token = "0x4000B42")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private AssetBundle <assetBundle>5__2;

			[Token(Token = "0x4000B43")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private TaskAwaiter<byte[]> <>u__1;

			[Token(Token = "0x4000B44")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private object <>u__2;

			[Token(Token = "0x6000DF3")]
			[Address(RVA = "0x8DEBE0", Offset = "0x8DEBE0", VA = "0x8DEBE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000DF4")]
			[Address(RVA = "0x8DEBE8", Offset = "0x8DEBE8", VA = "0x8DEBE8", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000214")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x831D84", Offset = "0x831D84")]
		private struct <DownloadRawDataAsync>d__19 : IAsyncStateMachine
		{
			[Token(Token = "0x4000B45")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000B46")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<byte[]> <>t__builder;

			[Token(Token = "0x4000B47")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string url;

			[Token(Token = "0x4000B48")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UnityWebRequest <request>5__2;

			[Token(Token = "0x4000B49")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private object <>u__1;

			[Token(Token = "0x6000DF5")]
			[Address(RVA = "0x8DEBC0", Offset = "0x8DEBC0", VA = "0x8DEBC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000DF6")]
			[Address(RVA = "0x8DEBC8", Offset = "0x8DEBC8", VA = "0x8DEBC8", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000215")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x831D94", Offset = "0x831D94")]
		private struct <RunIEnumeratorTryCatchExceptionAsync>d__20 : IAsyncStateMachine
		{
			[Token(Token = "0x4000B4A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000B4B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000B4C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AsyncUtilTests <>4__this;

			[Token(Token = "0x4000B4D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private object <>u__1;

			[Token(Token = "0x6000DF7")]
			[Address(RVA = "0x8DEC6C", Offset = "0x8DEC6C", VA = "0x8DEC6C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000DF8")]
			[Address(RVA = "0x8DEC74", Offset = "0x8DEC74", VA = "0x8DEC74", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000216")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x831DA4", Offset = "0x831DA4")]
		private struct <RunIEnumeratorUnhandledExceptionAsync>d__21 : IAsyncStateMachine
		{
			[Token(Token = "0x4000B4E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000B4F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000B50")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AsyncUtilTests <>4__this;

			[Token(Token = "0x4000B51")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private object <>u__1;

			[Token(Token = "0x6000DF9")]
			[Address(RVA = "0x8DEC80", Offset = "0x8DEC80", VA = "0x8DEC80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000DFA")]
			[Address(RVA = "0x8DEC88", Offset = "0x8DEC88", VA = "0x8DEC88", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x2000217")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x831DB4", Offset = "0x831DB4")]
		private sealed class <WaitThenThrow>d__22 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000B52")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000B53")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000B54")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AsyncUtilTests <>4__this;

			[Token(Token = "0x1700011A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000DFE")]
				[Address(RVA = "0xFC076C", Offset = "0xFC076C", VA = "0xFC076C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700011B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000E00")]
				[Address(RVA = "0xFC07D4", Offset = "0xFC07D4", VA = "0xFC07D4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000DFB")]
			[Address(RVA = "0xFBCD8C", Offset = "0xFBCD8C", VA = "0xFBCD8C")]
			[DebuggerHidden]
			public <WaitThenThrow>d__22(int <>1__state)
			{
			}

			[Token(Token = "0x6000DFC")]
			[Address(RVA = "0xFC0708", Offset = "0xFC0708", VA = "0xFC0708", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000DFD")]
			[Address(RVA = "0xFC070C", Offset = "0xFC070C", VA = "0xFC070C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000DFF")]
			[Address(RVA = "0xFC0774", Offset = "0xFC0774", VA = "0xFC0774", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000218")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x831DC4", Offset = "0x831DC4")]
		private sealed class <WaitThenThrowNested>d__23 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000B55")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000B56")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x1700011C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000E04")]
				[Address(RVA = "0xFC0AF0", Offset = "0xFC0AF0", VA = "0xFC0AF0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700011D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000E06")]
				[Address(RVA = "0xFC0B58", Offset = "0xFC0B58", VA = "0xFC0B58", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000E01")]
			[Address(RVA = "0xFBCE18", Offset = "0xFBCE18", VA = "0xFBCE18")]
			[DebuggerHidden]
			public <WaitThenThrowNested>d__23(int <>1__state)
			{
			}

			[Token(Token = "0x6000E02")]
			[Address(RVA = "0xFC09E8", Offset = "0xFC09E8", VA = "0xFC09E8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000E03")]
			[Address(RVA = "0xFC09EC", Offset = "0xFC09EC", VA = "0xFC09EC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000E05")]
			[Address(RVA = "0xFC0AF8", Offset = "0xFC0AF8", VA = "0xFC0AF8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000219")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x831DD4", Offset = "0x831DD4")]
		private struct <RunIEnumeratorStringTestAsync>d__24 : IAsyncStateMachine
		{
			[Token(Token = "0x4000B57")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000B58")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000B59")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AsyncUtilTests <>4__this;

			[Token(Token = "0x4000B5A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private object <>u__1;

			[Token(Token = "0x6000E07")]
			[Address(RVA = "0x8DEC44", Offset = "0x8DEC44", VA = "0x8DEC44", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000E08")]
			[Address(RVA = "0x8DEC4C", Offset = "0x8DEC4C", VA = "0x8DEC4C", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200021A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x831DE4", Offset = "0x831DE4")]
		private struct <RunIEnumeratorUntypedStringTestAsync>d__25 : IAsyncStateMachine
		{
			[Token(Token = "0x4000B5B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000B5C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000B5D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AsyncUtilTests <>4__this;

			[Token(Token = "0x4000B5E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private object <>u__1;

			[Token(Token = "0x6000E09")]
			[Address(RVA = "0x8DEC94", Offset = "0x8DEC94", VA = "0x8DEC94", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000E0A")]
			[Address(RVA = "0x8DEC9C", Offset = "0x8DEC9C", VA = "0x8DEC9C", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200021B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x831DF4", Offset = "0x831DF4")]
		private struct <RunIEnumeratorTestAsync>d__26 : IAsyncStateMachine
		{
			[Token(Token = "0x4000B5F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000B60")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000B61")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AsyncUtilTests <>4__this;

			[Token(Token = "0x4000B62")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private object <>u__1;

			[Token(Token = "0x6000E0B")]
			[Address(RVA = "0x8DEC58", Offset = "0x8DEC58", VA = "0x8DEC58", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000E0C")]
			[Address(RVA = "0x8DEC60", Offset = "0x8DEC60", VA = "0x8DEC60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x200021C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x831E04", Offset = "0x831E04")]
		private sealed class <WaitForString>d__27 : IEnumerator<string>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000B63")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000B64")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private string <>2__current;

			[Token(Token = "0x4000B65")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private float <startTime>5__2;

			[Token(Token = "0x1700011E")]
			private string System.Collections.Generic.IEnumerator<System.String>.Current
			{
				[Token(Token = "0x6000E10")]
				[Address(RVA = "0xFC057C", Offset = "0xFC057C", VA = "0xFC057C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700011F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000E12")]
				[Address(RVA = "0xFC05E4", Offset = "0xFC05E4", VA = "0xFC05E4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000E0D")]
			[Address(RVA = "0xFBCEA4", Offset = "0xFBCEA4", VA = "0xFBCEA4")]
			[DebuggerHidden]
			public <WaitForString>d__27(int <>1__state)
			{
			}

			[Token(Token = "0x6000E0E")]
			[Address(RVA = "0xFC04A4", Offset = "0xFC04A4", VA = "0xFC04A4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000E0F")]
			[Address(RVA = "0xFC04A8", Offset = "0xFC04A8", VA = "0xFC04A8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000E11")]
			[Address(RVA = "0xFC0584", Offset = "0xFC0584", VA = "0xFC0584", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200021D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x831E14", Offset = "0x831E14")]
		private sealed class <WaitForStringUntyped>d__28 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000B66")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000B67")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000B68")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AsyncUtilTests <>4__this;

			[Token(Token = "0x17000120")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000E16")]
				[Address(RVA = "0xFC0698", Offset = "0xFC0698", VA = "0xFC0698", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000121")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000E18")]
				[Address(RVA = "0xFC0700", Offset = "0xFC0700", VA = "0xFC0700", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000E13")]
			[Address(RVA = "0xFBCF40", Offset = "0xFBCF40", VA = "0xFBCF40")]
			[DebuggerHidden]
			public <WaitForStringUntyped>d__28(int <>1__state)
			{
			}

			[Token(Token = "0x6000E14")]
			[Address(RVA = "0xFC05EC", Offset = "0xFC05EC", VA = "0xFC05EC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000E15")]
			[Address(RVA = "0xFC05F0", Offset = "0xFC05F0", VA = "0xFC05F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000E17")]
			[Address(RVA = "0xFC06A0", Offset = "0xFC06A0", VA = "0xFC06A0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200021E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x831E24", Offset = "0x831E24")]
		private sealed class <WaitABit>d__29 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000B69")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000B6A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x17000122")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000E1C")]
				[Address(RVA = "0xFC0434", Offset = "0xFC0434", VA = "0xFC0434", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000123")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000E1E")]
				[Address(RVA = "0xFC049C", Offset = "0xFC049C", VA = "0xFC049C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000E19")]
			[Address(RVA = "0xFBCFCC", Offset = "0xFBCFCC", VA = "0xFBCFCC")]
			[DebuggerHidden]
			public <WaitABit>d__29(int <>1__state)
			{
			}

			[Token(Token = "0x6000E1A")]
			[Address(RVA = "0xFC039C", Offset = "0xFC039C", VA = "0xFC039C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000E1B")]
			[Address(RVA = "0xFC03A0", Offset = "0xFC03A0", VA = "0xFC03A0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000E1D")]
			[Address(RVA = "0xFC043C", Offset = "0xFC043C", VA = "0xFC043C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200021F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x831E34", Offset = "0x831E34")]
		private struct <RunReturnValueTestAsync>d__30 : IAsyncStateMachine
		{
			[Token(Token = "0x4000B6B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000B6C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000B6D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AsyncUtilTests <>4__this;

			[Token(Token = "0x4000B6E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private TaskAwaiter<string> <>u__1;

			[Token(Token = "0x6000E1F")]
			[Address(RVA = "0x8DECE4", Offset = "0x8DECE4", VA = "0x8DECE4", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000E20")]
			[Address(RVA = "0x8DECEC", Offset = "0x8DECEC", VA = "0x8DECEC", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000220")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x831E44", Offset = "0x831E44")]
		private struct <GetValueExampleAsync>d__31 : IAsyncStateMachine
		{
			[Token(Token = "0x4000B6F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000B70")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<string> <>t__builder;

			[Token(Token = "0x4000B71")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private object <>u__1;

			[Token(Token = "0x6000E21")]
			[Address(RVA = "0x8DEBD0", Offset = "0x8DEBD0", VA = "0x8DEBD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000E22")]
			[Address(RVA = "0x8DEBD8", Offset = "0x8DEBD8", VA = "0x8DEBD8", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000221")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x831E54", Offset = "0x831E54")]
		private struct <RunAwaitSecondsTestAsync>d__32 : IAsyncStateMachine
		{
			[Token(Token = "0x4000B72")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000B73")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000B74")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private object <>u__1;

			[Token(Token = "0x6000E23")]
			[Address(RVA = "0x8DEC30", Offset = "0x8DEC30", VA = "0x8DEC30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000E24")]
			[Address(RVA = "0x8DEC38", Offset = "0x8DEC38", VA = "0x8DEC38", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40008B4")]
		private const string AssetBundleSampleUrl = "http://www.stevevermeulen.com/wp-content/uploads/2017/09/teapot.unity3d";

		[Token(Token = "0x40008B5")]
		private const string AssetBundleSampleAssetName = "Teapot";

		[Token(Token = "0x40008B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TestButtonHandler.Settings _buttonSettings;

		[Token(Token = "0x40008B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TestButtonHandler _buttonHandler;

		[Token(Token = "0x6000C2D")]
		[Address(RVA = "0xFBB4B4", Offset = "0xFBB4B4", VA = "0xFBB4B4")]
		public void Awake()
		{
		}

		[Token(Token = "0x6000C2E")]
		[Address(RVA = "0xFBB550", Offset = "0xFBB550", VA = "0xFBB550")]
		public void OnGUI()
		{
		}

		[Token(Token = "0x6000C2F")]
		[Address(RVA = "0xFBC454", Offset = "0xFBC454", VA = "0xFBC454")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x836124", Offset = "0x836124")]
		private IEnumerator RunAsyncFromCoroutineTest()
		{
			return null;
		}

		[Token(Token = "0x6000C30")]
		[Address(RVA = "0xFBC4C4", Offset = "0xFBC4C4", VA = "0xFBC4C4")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x836188", Offset = "0x836188")]
		private Task RunMultipleThreadsTestAsync()
		{
			return null;
		}

		[Token(Token = "0x6000C31")]
		[Address(RVA = "0xFBC5E4", Offset = "0xFBC5E4", VA = "0xFBC5E4")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x8361EC", Offset = "0x8361EC")]
		private Task RunMultipleThreadsTestAsyncWait()
		{
			return null;
		}

		[Token(Token = "0x6000C32")]
		[Address(RVA = "0xFBC6D4", Offset = "0xFBC6D4", VA = "0xFBC6D4")]
		private void PrintCurrentThreadContext([Optional] string prefix)
		{
		}

		[Token(Token = "0x6000C33")]
		[Address(RVA = "0xFBC81C", Offset = "0xFBC81C", VA = "0xFBC81C")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x836250", Offset = "0x836250")]
		private Task RunAsyncFromCoroutineTest2()
		{
			return null;
		}

		[Token(Token = "0x6000C34")]
		[Address(RVA = "0xFBC364", Offset = "0xFBC364", VA = "0xFBC364")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x8362B4", Offset = "0x8362B4")]
		private Task RunWwwAsync()
		{
			return null;
		}

		[Token(Token = "0x6000C35")]
		[Address(RVA = "0xFBC274", Offset = "0xFBC274", VA = "0xFBC274")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x836318", Offset = "0x836318")]
		private Task RunOpenNotepadTestAsync()
		{
			return null;
		}

		[Token(Token = "0x6000C36")]
		[Address(RVA = "0xFBBBE4", Offset = "0xFBBBE4", VA = "0xFBBBE4")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x83637C", Offset = "0x83637C")]
		private Task RunUnhandledExceptionTestAsync()
		{
			return null;
		}

		[Token(Token = "0x6000C37")]
		[Address(RVA = "0xFBBAF4", Offset = "0xFBBAF4", VA = "0xFBBAF4")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x8363E0", Offset = "0x8363E0")]
		private Task RunTryCatchExceptionTestAsync()
		{
			return null;
		}

		[Token(Token = "0x6000C38")]
		[Address(RVA = "0xFBC90C", Offset = "0xFBC90C", VA = "0xFBC90C")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x836444", Offset = "0x836444")]
		private Task NestedRunAsync()
		{
			return null;
		}

		[Token(Token = "0x6000C39")]
		[Address(RVA = "0xFBC9FC", Offset = "0xFBC9FC", VA = "0xFBC9FC")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x8364A8", Offset = "0x8364A8")]
		private Task WaitThenThrowException()
		{
			return null;
		}

		[Token(Token = "0x6000C3A")]
		[Address(RVA = "0xFBC184", Offset = "0xFBC184", VA = "0xFBC184")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x83650C", Offset = "0x83650C")]
		private Task RunAsyncOperationAsync()
		{
			return null;
		}

		[Token(Token = "0x6000C3B")]
		[Address(RVA = "0xFBCAEC", Offset = "0xFBCAEC", VA = "0xFBCAEC")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x836570", Offset = "0x836570")]
		private Task InstantiateAssetBundleAsync(string abUrl, string assetName)
		{
			return null;
		}

		[Token(Token = "0x6000C3C")]
		[Address(RVA = "0xFBCBFC", Offset = "0xFBCBFC", VA = "0xFBCBFC")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x8365D4", Offset = "0x8365D4")]
		private Task<byte[]> DownloadRawDataAsync(string url)
		{
			return null;
		}

		[Token(Token = "0x6000C3D")]
		[Address(RVA = "0xFBC094", Offset = "0xFBC094", VA = "0xFBC094")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x836638", Offset = "0x836638")]
		private Task RunIEnumeratorTryCatchExceptionAsync()
		{
			return null;
		}

		[Token(Token = "0x6000C3E")]
		[Address(RVA = "0xFBBFA4", Offset = "0xFBBFA4", VA = "0xFBBFA4")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x83669C", Offset = "0x83669C")]
		private Task RunIEnumeratorUnhandledExceptionAsync()
		{
			return null;
		}

		[Token(Token = "0x6000C3F")]
		[Address(RVA = "0xFBCD1C", Offset = "0xFBCD1C", VA = "0xFBCD1C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x836700", Offset = "0x836700")]
		private IEnumerator WaitThenThrow()
		{
			return null;
		}

		[Token(Token = "0x6000C40")]
		[Address(RVA = "0xFBCDB8", Offset = "0xFBCDB8", VA = "0xFBCDB8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x836764", Offset = "0x836764")]
		private IEnumerator WaitThenThrowNested()
		{
			return null;
		}

		[Token(Token = "0x6000C41")]
		[Address(RVA = "0xFBBEB4", Offset = "0xFBBEB4", VA = "0xFBBEB4")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x8367C8", Offset = "0x8367C8")]
		private Task RunIEnumeratorStringTestAsync()
		{
			return null;
		}

		[Token(Token = "0x6000C42")]
		[Address(RVA = "0xFBBDC4", Offset = "0xFBBDC4", VA = "0xFBBDC4")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x83682C", Offset = "0x83682C")]
		private Task RunIEnumeratorUntypedStringTestAsync()
		{
			return null;
		}

		[Token(Token = "0x6000C43")]
		[Address(RVA = "0xFBBCD4", Offset = "0xFBBCD4", VA = "0xFBBCD4")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x836890", Offset = "0x836890")]
		private Task RunIEnumeratorTestAsync()
		{
			return null;
		}

		[Token(Token = "0x6000C44")]
		[Address(RVA = "0xFBCE44", Offset = "0xFBCE44", VA = "0xFBCE44")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8368F4", Offset = "0x8368F4")]
		private IEnumerator<string> WaitForString()
		{
			return null;
		}

		[Token(Token = "0x6000C45")]
		[Address(RVA = "0xFBCED0", Offset = "0xFBCED0", VA = "0xFBCED0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x836958", Offset = "0x836958")]
		private IEnumerator WaitForStringUntyped()
		{
			return null;
		}

		[Token(Token = "0x6000C46")]
		[Address(RVA = "0xFBCF6C", Offset = "0xFBCF6C", VA = "0xFBCF6C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8369BC", Offset = "0x8369BC")]
		private IEnumerator WaitABit()
		{
			return null;
		}

		[Token(Token = "0x6000C47")]
		[Address(RVA = "0xFBBA04", Offset = "0xFBBA04", VA = "0xFBBA04")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x836A20", Offset = "0x836A20")]
		private Task RunReturnValueTestAsync()
		{
			return null;
		}

		[Token(Token = "0x6000C48")]
		[Address(RVA = "0xFBCFF8", Offset = "0xFBCFF8", VA = "0xFBCFF8")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x836A84", Offset = "0x836A84")]
		private Task<string> GetValueExampleAsync()
		{
			return null;
		}

		[Token(Token = "0x6000C49")]
		[Address(RVA = "0xFBB914", Offset = "0xFBB914", VA = "0xFBB914")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x836AE8", Offset = "0x836AE8")]
		private Task RunAwaitSecondsTestAsync()
		{
			return null;
		}

		[Token(Token = "0x6000C4A")]
		[Address(RVA = "0xFBD0F8", Offset = "0xFBD0F8", VA = "0xFBD0F8")]
		public AsyncUtilTests()
		{
		}
	}
	[Token(Token = "0x2000186")]
	public class TestButtonHandler
	{
		[Serializable]
		[Token(Token = "0x2000222")]
		public class Settings
		{
			[Token(Token = "0x4000B75")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int NumPerColumn;

			[Token(Token = "0x4000B76")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float VerticalMargin;

			[Token(Token = "0x4000B77")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float VerticalSpacing;

			[Token(Token = "0x4000B78")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float HorizontalSpacing;

			[Token(Token = "0x4000B79")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float HorizontalMargin;

			[Token(Token = "0x4000B7A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public float ButtonWidth;

			[Token(Token = "0x4000B7B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float ButtonHeight;

			[Token(Token = "0x6000E25")]
			[Address(RVA = "0xFC0D58", Offset = "0xFC0D58", VA = "0xFC0D58")]
			public Settings()
			{
			}
		}

		[Token(Token = "0x40008B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Settings _settings;

		[Token(Token = "0x40008B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int _buttonVCount;

		[Token(Token = "0x40008BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private int _buttonHCount;

		[Token(Token = "0x6000C4B")]
		[Address(RVA = "0xFBB524", Offset = "0xFBB524", VA = "0xFBB524")]
		public TestButtonHandler(Settings settings)
		{
		}

		[Token(Token = "0x6000C4C")]
		[Address(RVA = "0xFBB80C", Offset = "0xFBB80C", VA = "0xFBB80C")]
		public void Restart()
		{
		}

		[Token(Token = "0x6000C4D")]
		[Address(RVA = "0xFBB814", Offset = "0xFBB814", VA = "0xFBB814")]
		public bool Display(string text)
		{
			return default(bool);
		}
	}
}
