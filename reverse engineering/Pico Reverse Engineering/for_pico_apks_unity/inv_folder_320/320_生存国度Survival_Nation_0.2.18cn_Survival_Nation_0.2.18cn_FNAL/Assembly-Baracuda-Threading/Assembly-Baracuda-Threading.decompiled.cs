using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Baracuda.Threading.Internal;
using Baracuda.Threading.Utils;
using Il2CppDummyDll;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Baracuda.Threading
{
	[Token(Token = "0x2000002")]
	[RequireComponent(typeof(DispatcherPostUpdate))]
	[DisallowMultipleComponent]
	public sealed class Dispatcher : MonoBehaviour, IDisableCallback
	{
		[StructLayout(3)]
		[Token(Token = "0x2000003")]
		[CompilerGenerated]
		private struct <TickUpdate>d__28 : IAsyncStateMachine
		{
			[Token(Token = "0x4000014")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000015")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Token(Token = "0x4000016")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public CancellationToken ct;

			[Token(Token = "0x4000017")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private TaskAwaiter <>u__1;

			[Token(Token = "0x6000051")]
			[Address(RVA = "0xB07D60", Offset = "0xB07D60", VA = "0xB07D60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000052")]
			[Address(RVA = "0xB082CC", Offset = "0xB082CC", VA = "0xB082CC", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4000001")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Thread _mainThread;

		[Token(Token = "0x4000002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static CancellationTokenSource _runtimeCts;

		[Token(Token = "0x4000003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly Queue<Action> _defaultExecutionQueue;

		[Token(Token = "0x4000004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static bool _queuedDefault;

		[Token(Token = "0x4000005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static readonly Queue<Action> _fixedUpdateExecutionQueue;

		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static bool _queuedFixed;

		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static readonly Queue<Action> _updateExecutionQueue;

		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static bool _queuedUpdate;

		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static readonly Queue<Action> _lateUpdateExecutionQueue;

		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static bool _queuedLate;

		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static readonly Queue<Action> _postUpdateExecutionQueue;

		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static bool _queuedPost;

		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static readonly Queue<Action> _tickExecutionQueue;

		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static bool _queuedTick;

		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static CancellationTokenSource _cts;

		[Token(Token = "0x4000010")]
		private const int TICK_DELAY = 50;

		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static Dispatcher _current;

		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool _throw;

		[Token(Token = "0x17000001")]
		public static CancellationToken RuntimeToken
		{
			[Token(Token = "0x6000003")]
			[Address(RVA = "0xB01D00", Offset = "0xB01D00", VA = "0xB01D00")]
			get
			{
				return default(CancellationToken);
			}
		}

		[Token(Token = "0x17000002")]
		public static Dispatcher Current
		{
			[Token(Token = "0x6000040")]
			[Address(RVA = "0xB01B8C", Offset = "0xB01B8C", VA = "0xB01B8C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000001")]
		public event Action onDisable
		{
			[Token(Token = "0x6000035")]
			[Address(RVA = "0xB06920", Offset = "0xB06920", VA = "0xB06920", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000036")]
			[Address(RVA = "0xB069BC", Offset = "0xB069BC", VA = "0xB069BC", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000001")]
		[Address(RVA = "0xB01A68", Offset = "0xB01A68", VA = "0xB01A68")]
		public static bool IsMainThread()
		{
			return default(bool);
		}

		[Token(Token = "0x6000002")]
		[Address(RVA = "0xB01B40", Offset = "0xB01B40", VA = "0xB01B40")]
		public static Dispatcher Validate()
		{
			return null;
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0xB01D64", Offset = "0xB01D64", VA = "0xB01D64")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x6000005")]
		[Address(RVA = "0xB01DB0", Offset = "0xB01DB0", VA = "0xB01DB0")]
		private static void CancelAndResetRuntimeToken()
		{
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0xB01E6C", Offset = "0xB01E6C", VA = "0xB01E6C")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		private static void DispatchAfterAssembliesLoaded()
		{
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0xB02088", Offset = "0xB02088", VA = "0xB02088")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void DispatchBeforeSceneLoad()
		{
		}

		[Token(Token = "0x6000008")]
		[Address(RVA = "0xB022A4", Offset = "0xB022A4", VA = "0xB022A4")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
		private static void DispatchAfterSceneLoad()
		{
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0xB024C0", Offset = "0xB024C0", VA = "0xB024C0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void InitTick()
		{
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0xB0250C", Offset = "0xB0250C", VA = "0xB0250C")]
		private static void InitializeTickUpdateLoop()
		{
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0xB025B8", Offset = "0xB025B8", VA = "0xB025B8")]
		private static void StopTick()
		{
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0xB02674", Offset = "0xB02674", VA = "0xB02674")]
		[AsyncStateMachine(typeof(<TickUpdate>d__28))]
		private static void TickUpdate(CancellationToken ct)
		{
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0xB0272C", Offset = "0xB0272C", VA = "0xB0272C")]
		private void Update()
		{
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0xB02AE4", Offset = "0xB02AE4", VA = "0xB02AE4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0xB02E9C", Offset = "0xB02E9C", VA = "0xB02E9C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0xB03254", Offset = "0xB03254", VA = "0xB03254")]
		internal static void PostUpdate()
		{
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000011")]
		[Address(RVA = "0xB0360C", Offset = "0xB0360C", VA = "0xB0360C")]
		private static void ReleaseDefaultQueue()
		{
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0xB037F8", Offset = "0xB037F8", VA = "0xB037F8")]
		public static void Invoke(Action action)
		{
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0xB0395C", Offset = "0xB0395C", VA = "0xB0395C")]
		public static void Invoke(Action action, ExecutionCycle cycle)
		{
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0xB04074", Offset = "0xB04074", VA = "0xB04074")]
		public static Task InvokeAsync(Action action)
		{
			return null;
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0xB04200", Offset = "0xB04200", VA = "0xB04200")]
		public static Task InvokeAsync(Action action, ExecutionCycle cycle)
		{
			return null;
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0xB0434C", Offset = "0xB0434C", VA = "0xB0434C")]
		public static Task InvokeAsync(Action action, CancellationToken ct, bool throwOnCancellation = true)
		{
			return null;
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0xB04540", Offset = "0xB04540", VA = "0xB04540")]
		public static Task InvokeAsync(Action action, ExecutionCycle cycle, CancellationToken ct, bool throwOnCancellation = true)
		{
			return null;
		}

		[Token(Token = "0x6000018")]
		public static Task<TResult> InvokeAsync<TResult>(Func<TResult> func)
		{
			return null;
		}

		[Token(Token = "0x6000019")]
		public static Task<TResult> InvokeAsync<TResult>(Func<TResult> func, ExecutionCycle cycle)
		{
			return null;
		}

		[Token(Token = "0x600001A")]
		public static Task<TResult> InvokeAsync<TResult>(Func<TResult> func, CancellationToken ct)
		{
			return null;
		}

		[Token(Token = "0x600001B")]
		public static Task<TResult> InvokeAsync<TResult>(Func<TResult> func, ExecutionCycle cycle, CancellationToken ct)
		{
			return null;
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0xB046B8", Offset = "0xB046B8", VA = "0xB046B8")]
		public static void Invoke(IEnumerator enumerator)
		{
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0xB0479C", Offset = "0xB0479C", VA = "0xB0479C")]
		public static void Invoke(IEnumerator enumerator, ExecutionCycle cycle)
		{
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0xB04890", Offset = "0xB04890", VA = "0xB04890")]
		public static void Invoke(IEnumerator enumerator, MonoBehaviour target)
		{
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0xB04990", Offset = "0xB04990", VA = "0xB04990")]
		public static void Invoke(IEnumerator enumerator, ExecutionCycle cycle, MonoBehaviour target)
		{
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0xB04A98", Offset = "0xB04A98", VA = "0xB04A98")]
		public static Task<Coroutine> InvokeAsyncAwaitStart(IEnumerator enumerator)
		{
			return null;
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0xB04BF4", Offset = "0xB04BF4", VA = "0xB04BF4")]
		public static Task<Coroutine> InvokeAsyncAwaitStart(IEnumerator enumerator, MonoBehaviour target)
		{
			return null;
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0xB04D64", Offset = "0xB04D64", VA = "0xB04D64")]
		public static Task<Coroutine> InvokeAsyncAwaitStart(IEnumerator enumerator, CancellationToken ct)
		{
			return null;
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0xB04EE4", Offset = "0xB04EE4", VA = "0xB04EE4")]
		public static Task<Coroutine> InvokeAsyncAwaitStart(IEnumerator enumerator, MonoBehaviour target, CancellationToken ct)
		{
			return null;
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0xB05080", Offset = "0xB05080", VA = "0xB05080")]
		public static Task<Coroutine> InvokeAsyncAwaitStart(IEnumerator enumerator, ExecutionCycle cycle)
		{
			return null;
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0xB051E4", Offset = "0xB051E4", VA = "0xB051E4")]
		public static Task<Coroutine> InvokeAsyncAwaitStart(IEnumerator enumerator, ExecutionCycle cycle, MonoBehaviour target)
		{
			return null;
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0xB0535C", Offset = "0xB0535C", VA = "0xB0535C")]
		public static Task<Coroutine> InvokeAsyncAwaitStart(IEnumerator enumerator, ExecutionCycle cycle, CancellationToken ct)
		{
			return null;
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0xB054EC", Offset = "0xB054EC", VA = "0xB054EC")]
		public static Task<Coroutine> InvokeAsyncAwaitStart(IEnumerator enumerator, ExecutionCycle cycle, MonoBehaviour target, CancellationToken ct)
		{
			return null;
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0xB05690", Offset = "0xB05690", VA = "0xB05690")]
		public static Task InvokeAsyncAwaitCompletion(IEnumerator enumerator, bool throwExceptions = true)
		{
			return null;
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0xB057E4", Offset = "0xB057E4", VA = "0xB057E4")]
		public static Task InvokeAsyncAwaitCompletion(IEnumerator enumerator, CancellationToken ct, bool throwExceptions = true)
		{
			return null;
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0xB0594C", Offset = "0xB0594C", VA = "0xB0594C")]
		public static Task InvokeAsyncAwaitCompletion(IEnumerator enumerator, MonoBehaviour target, bool throwExceptions = true)
		{
			return null;
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0xB05AB0", Offset = "0xB05AB0", VA = "0xB05AB0")]
		public static Task InvokeAsyncAwaitCompletion(IEnumerator enumerator, MonoBehaviour target, CancellationToken ct, bool throwExceptions = true)
		{
			return null;
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0xB05C30", Offset = "0xB05C30", VA = "0xB05C30")]
		public static Task InvokeAsyncAwaitCompletion(IEnumerator enumerator, ExecutionCycle cycle, bool throwExceptions = true)
		{
			return null;
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0xB05D94", Offset = "0xB05D94", VA = "0xB05D94")]
		public static Task InvokeAsyncAwaitCompletion(IEnumerator enumerator, ExecutionCycle cycle, CancellationToken ct, bool throwExceptions = true)
		{
			return null;
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0xB05F0C", Offset = "0xB05F0C", VA = "0xB05F0C")]
		public static Task InvokeAsyncAwaitCompletion(IEnumerator enumerator, ExecutionCycle cycle, MonoBehaviour target, bool throwExceptions = true)
		{
			return null;
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0xB06080", Offset = "0xB06080", VA = "0xB06080")]
		public static Task InvokeAsyncAwaitCompletion(IEnumerator enumerator, ExecutionCycle cycle, MonoBehaviour target, CancellationToken ct, bool throwExceptions = true)
		{
			return null;
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0xB06208", Offset = "0xB06208", VA = "0xB06208")]
		public static void CancelCoroutine(Coroutine coroutine)
		{
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0xB062EC", Offset = "0xB062EC", VA = "0xB062EC")]
		public static Task CancelCoroutineAsync(Coroutine coroutine)
		{
			return null;
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0xB06430", Offset = "0xB06430", VA = "0xB06430")]
		public static Task CancelCoroutineAsync(Coroutine coroutine, CancellationToken ct, bool throwOnCancellation = true)
		{
			return null;
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000033")]
		[Address(RVA = "0xB06598", Offset = "0xB06598", VA = "0xB06598")]
		private static void StartCoroutineInternal(IEnumerator coroutine, TaskCompletionSource tcs, CancellationToken ct, bool throwExceptions, MonoBehaviour target)
		{
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000034")]
		[Address(RVA = "0xB06790", Offset = "0xB06790", VA = "0xB06790")]
		private static void StartCoroutineInternal(IEnumerator coroutine, TaskCompletionSource tcs, CancellationToken ct, bool throwExceptions)
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0xB06A58", Offset = "0xB06A58", VA = "0xB06A58")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0xB06A8C", Offset = "0xB06A8C", VA = "0xB06A8C")]
		[Obsolete("Use InvokeAsyncAwaitStart or InvokeAsyncAwaitCompletion instead!")]
		public static Task<Coroutine> InvokeAsync(IEnumerator enumerator)
		{
			return null;
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0xB06AE0", Offset = "0xB06AE0", VA = "0xB06AE0")]
		[Obsolete("Use InvokeAsyncAwaitStart or InvokeAsyncAwaitCompletion instead!")]
		public static Task<Coroutine> InvokeAsync(IEnumerator enumerator, MonoBehaviour target)
		{
			return null;
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0xB06B44", Offset = "0xB06B44", VA = "0xB06B44")]
		[Obsolete("Use InvokeAsyncAwaitStart or InvokeAsyncAwaitCompletion instead!")]
		public static Task<Coroutine> InvokeAsync(IEnumerator enumerator, CancellationToken ct)
		{
			return null;
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0xB06BA8", Offset = "0xB06BA8", VA = "0xB06BA8")]
		[Obsolete("Use InvokeAsyncAwaitStart or InvokeAsyncAwaitCompletion instead!")]
		public static Task<Coroutine> InvokeAsync(IEnumerator enumerator, MonoBehaviour target, CancellationToken ct)
		{
			return null;
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0xB06C14", Offset = "0xB06C14", VA = "0xB06C14")]
		[Obsolete("Use InvokeAsyncAwaitStart or InvokeAsyncAwaitCompletion instead!")]
		public static Task<Coroutine> InvokeAsync(IEnumerator enumerator, ExecutionCycle cycle)
		{
			return null;
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0xB06C78", Offset = "0xB06C78", VA = "0xB06C78")]
		[Obsolete("Use InvokeAsyncAwaitStart or InvokeAsyncAwaitCompletion instead!")]
		public static Task<Coroutine> InvokeAsync(IEnumerator enumerator, ExecutionCycle cycle, MonoBehaviour target)
		{
			return null;
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0xB06CE4", Offset = "0xB06CE4", VA = "0xB06CE4")]
		[Obsolete("Use InvokeAsyncAwaitStart or InvokeAsyncAwaitCompletion instead!")]
		public static Task<Coroutine> InvokeAsync(IEnumerator enumerator, ExecutionCycle cycle, CancellationToken ct)
		{
			return null;
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0xB06D50", Offset = "0xB06D50", VA = "0xB06D50")]
		[Obsolete("Use InvokeAsyncAwaitStart or InvokeAsyncAwaitCompletion instead!")]
		public static Task<Coroutine> InvokeAsync(IEnumerator enumerator, ExecutionCycle cycle, MonoBehaviour target, CancellationToken ct)
		{
			return null;
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0xB06DCC", Offset = "0xB06DCC", VA = "0xB06DCC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0xB07000", Offset = "0xB07000", VA = "0xB07000")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0xB0715C", Offset = "0xB0715C", VA = "0xB0715C")]
		public static void Invoke(Func<Task> function)
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0xB07240", Offset = "0xB07240", VA = "0xB07240")]
		public static void Invoke(Func<Task> function, ExecutionCycle cycle)
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0xB07334", Offset = "0xB07334", VA = "0xB07334")]
		public static void Invoke(Func<CancellationToken, Task> function, CancellationToken ct, bool throwOnCancellation = true)
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0xB07444", Offset = "0xB07444", VA = "0xB07444")]
		public static void Invoke(Func<CancellationToken, Task> function, ExecutionCycle cycle, CancellationToken ct, bool throwOnCancellation = true)
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0xB07564", Offset = "0xB07564", VA = "0xB07564")]
		public static Task InvokeAsync(Func<Task> function)
		{
			return null;
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0xB076A8", Offset = "0xB076A8", VA = "0xB076A8")]
		public static Task InvokeAsync(Func<Task> function, ExecutionCycle cycle)
		{
			return null;
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0xB077F4", Offset = "0xB077F4", VA = "0xB077F4")]
		public static Task InvokeAsync(Func<CancellationToken, Task> function, CancellationToken ct, bool throwOnCancellation = true)
		{
			return null;
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0xB0795C", Offset = "0xB0795C", VA = "0xB0795C")]
		public static Task InvokeAsync(Func<CancellationToken, Task> function, ExecutionCycle cycle, CancellationToken ct, bool throwOnCancellation = true)
		{
			return null;
		}

		[Token(Token = "0x600004B")]
		public static Task<TResult> InvokeAsync<TResult>(Func<Task<TResult>> function)
		{
			return null;
		}

		[Token(Token = "0x600004C")]
		public static Task<TResult> InvokeAsync<TResult>(Func<Task<TResult>> function, ExecutionCycle cycle)
		{
			return null;
		}

		[Token(Token = "0x600004D")]
		public static Task<TResult> InvokeAsync<TResult>(Func<CancellationToken, Task<TResult>> function, CancellationToken ct)
		{
			return null;
		}

		[Token(Token = "0x600004E")]
		public static Task<TResult> InvokeAsync<TResult>(Func<CancellationToken, Task<TResult>> function, ExecutionCycle cycle, CancellationToken ct)
		{
			return null;
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0xB07AD4", Offset = "0xB07AD4", VA = "0xB07AD4")]
		public Dispatcher()
		{
		}
	}
	[Token(Token = "0x200003B")]
	public enum ExecutionCycle
	{
		[Token(Token = "0x40000C6")]
		Default = 5,
		[Token(Token = "0x40000C7")]
		Update = 1,
		[Token(Token = "0x40000C8")]
		LateUpdate = 2,
		[Token(Token = "0x40000C9")]
		PostUpdate = 3,
		[Token(Token = "0x40000CA")]
		FixedUpdate = 4,
		[Token(Token = "0x40000CB")]
		TickUpdate = 5
	}
}
namespace Baracuda.Threading.Utils
{
	[Token(Token = "0x200003C")]
	internal class TaskCompletionSource : TaskCompletionSource<Exception>
	{
		[Token(Token = "0x60000C1")]
		[Address(RVA = "0xB083E8", Offset = "0xB083E8", VA = "0xB083E8")]
		public void SetCompleted()
		{
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0xB0C390", Offset = "0xB0C390", VA = "0xB0C390")]
		public bool TrySetCompleted()
		{
			return default(bool);
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0xB041B8", Offset = "0xB041B8", VA = "0xB041B8")]
		public TaskCompletionSource()
		{
		}
	}
}
namespace Baracuda.Threading.Internal
{
	[Token(Token = "0x200003D")]
	[RequireComponent(typeof(Dispatcher))]
	public class DispatcherPostUpdate : MonoBehaviour
	{
		[Token(Token = "0x60000C4")]
		[Address(RVA = "0xB0C3DC", Offset = "0xB0C3DC", VA = "0xB0C3DC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0xB0C428", Offset = "0xB0C428", VA = "0xB0C428")]
		public DispatcherPostUpdate()
		{
		}
	}
	[Token(Token = "0x200003E")]
	public class BehaviourDisabledException : SystemException
	{
		[Token(Token = "0x60000C6")]
		[Address(RVA = "0xB0C430", Offset = "0xB0C430", VA = "0xB0C430")]
		public BehaviourDisabledException(string message)
		{
		}
	}
	[Token(Token = "0x200003F")]
	[DisallowMultipleComponent]
	public class DisableCallback : MonoBehaviour, IDisableCallback
	{
		[Token(Token = "0x14000002")]
		public event Action onDisable
		{
			[Token(Token = "0x60000C7")]
			[Address(RVA = "0xB0C438", Offset = "0xB0C438", VA = "0xB0C438", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60000C8")]
			[Address(RVA = "0xB0C4D4", Offset = "0xB0C4D4", VA = "0xB0C4D4", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0xB0C570", Offset = "0xB0C570", VA = "0xB0C570")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0xB0C5A4", Offset = "0xB0C5A4", VA = "0xB0C5A4")]
		public DisableCallback()
		{
		}
	}
	[Token(Token = "0x2000040")]
	public static class ExceptionSensitiveCoroutineHandler
	{
		[Token(Token = "0x60000CB")]
		[Address(RVA = "0xB0C5AC", Offset = "0xB0C5AC", VA = "0xB0C5AC")]
		private static IEnumerator StartCoroutineExceptionSensitiveInternal(IEnumerator enumerator, Func<Exception, bool> error, Func<bool> completed, IDisableCallback callback, CancellationToken ct)
		{
			return null;
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0xB066B0", Offset = "0xB066B0", VA = "0xB066B0")]
		public static void StartCoroutineExceptionSensitive(this MonoBehaviour target, IEnumerator enumerator, Func<Exception, bool> error, Func<bool> completed, CancellationToken ct)
		{
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0xB068E8", Offset = "0xB068E8", VA = "0xB068E8")]
		public static void StartCoroutineExceptionSensitive(this MonoBehaviour target, IEnumerator enumerator, Func<Exception, bool> error, Func<bool> completed, CancellationToken ct, IDisableCallback callback)
		{
		}
	}
	[Token(Token = "0x2000043")]
	public interface IDisableCallback
	{
		[Token(Token = "0x14000003")]
		event Action onDisable;
	}
}
