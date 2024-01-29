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
			[Address(RVA = "0xB5C550", Offset = "0xB5C550", VA = "0xB5C550", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000052")]
			[Address(RVA = "0xB5CABC", Offset = "0xB5CABC", VA = "0xB5CABC", Slot = "5")]
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
			[Address(RVA = "0xB564F0", Offset = "0xB564F0", VA = "0xB564F0")]
			get
			{
				return default(CancellationToken);
			}
		}

		[Token(Token = "0x17000002")]
		public static Dispatcher Current
		{
			[Token(Token = "0x6000040")]
			[Address(RVA = "0xB5637C", Offset = "0xB5637C", VA = "0xB5637C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000001")]
		public event Action onDisable
		{
			[Token(Token = "0x6000035")]
			[Address(RVA = "0xB5B110", Offset = "0xB5B110", VA = "0xB5B110", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000036")]
			[Address(RVA = "0xB5B1AC", Offset = "0xB5B1AC", VA = "0xB5B1AC", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000001")]
		[Address(RVA = "0xB56258", Offset = "0xB56258", VA = "0xB56258")]
		public static bool IsMainThread()
		{
			return default(bool);
		}

		[Token(Token = "0x6000002")]
		[Address(RVA = "0xB56330", Offset = "0xB56330", VA = "0xB56330")]
		public static Dispatcher Validate()
		{
			return null;
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0xB56554", Offset = "0xB56554", VA = "0xB56554")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x6000005")]
		[Address(RVA = "0xB565A0", Offset = "0xB565A0", VA = "0xB565A0")]
		private static void CancelAndResetRuntimeToken()
		{
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0xB5665C", Offset = "0xB5665C", VA = "0xB5665C")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		private static void DispatchAfterAssembliesLoaded()
		{
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0xB56878", Offset = "0xB56878", VA = "0xB56878")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void DispatchBeforeSceneLoad()
		{
		}

		[Token(Token = "0x6000008")]
		[Address(RVA = "0xB56A94", Offset = "0xB56A94", VA = "0xB56A94")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
		private static void DispatchAfterSceneLoad()
		{
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0xB56CB0", Offset = "0xB56CB0", VA = "0xB56CB0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void InitTick()
		{
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0xB56CFC", Offset = "0xB56CFC", VA = "0xB56CFC")]
		private static void InitializeTickUpdateLoop()
		{
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0xB56DA8", Offset = "0xB56DA8", VA = "0xB56DA8")]
		private static void StopTick()
		{
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0xB56E64", Offset = "0xB56E64", VA = "0xB56E64")]
		[AsyncStateMachine(typeof(<TickUpdate>d__28))]
		private static void TickUpdate(CancellationToken ct)
		{
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0xB56F1C", Offset = "0xB56F1C", VA = "0xB56F1C")]
		private void Update()
		{
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0xB572D4", Offset = "0xB572D4", VA = "0xB572D4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0xB5768C", Offset = "0xB5768C", VA = "0xB5768C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0xB57A44", Offset = "0xB57A44", VA = "0xB57A44")]
		internal static void PostUpdate()
		{
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000011")]
		[Address(RVA = "0xB57DFC", Offset = "0xB57DFC", VA = "0xB57DFC")]
		private static void ReleaseDefaultQueue()
		{
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0xB57FE8", Offset = "0xB57FE8", VA = "0xB57FE8")]
		public static void Invoke(Action action)
		{
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0xB5814C", Offset = "0xB5814C", VA = "0xB5814C")]
		public static void Invoke(Action action, ExecutionCycle cycle)
		{
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0xB58864", Offset = "0xB58864", VA = "0xB58864")]
		public static Task InvokeAsync(Action action)
		{
			return null;
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0xB589F0", Offset = "0xB589F0", VA = "0xB589F0")]
		public static Task InvokeAsync(Action action, ExecutionCycle cycle)
		{
			return null;
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0xB58B3C", Offset = "0xB58B3C", VA = "0xB58B3C")]
		public static Task InvokeAsync(Action action, CancellationToken ct, bool throwOnCancellation = true)
		{
			return null;
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0xB58D30", Offset = "0xB58D30", VA = "0xB58D30")]
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
		[Address(RVA = "0xB58EA8", Offset = "0xB58EA8", VA = "0xB58EA8")]
		public static void Invoke(IEnumerator enumerator)
		{
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0xB58F8C", Offset = "0xB58F8C", VA = "0xB58F8C")]
		public static void Invoke(IEnumerator enumerator, ExecutionCycle cycle)
		{
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0xB59080", Offset = "0xB59080", VA = "0xB59080")]
		public static void Invoke(IEnumerator enumerator, MonoBehaviour target)
		{
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0xB59180", Offset = "0xB59180", VA = "0xB59180")]
		public static void Invoke(IEnumerator enumerator, ExecutionCycle cycle, MonoBehaviour target)
		{
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0xB59288", Offset = "0xB59288", VA = "0xB59288")]
		public static Task<Coroutine> InvokeAsyncAwaitStart(IEnumerator enumerator)
		{
			return null;
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0xB593E4", Offset = "0xB593E4", VA = "0xB593E4")]
		public static Task<Coroutine> InvokeAsyncAwaitStart(IEnumerator enumerator, MonoBehaviour target)
		{
			return null;
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0xB59554", Offset = "0xB59554", VA = "0xB59554")]
		public static Task<Coroutine> InvokeAsyncAwaitStart(IEnumerator enumerator, CancellationToken ct)
		{
			return null;
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0xB596D4", Offset = "0xB596D4", VA = "0xB596D4")]
		public static Task<Coroutine> InvokeAsyncAwaitStart(IEnumerator enumerator, MonoBehaviour target, CancellationToken ct)
		{
			return null;
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0xB59870", Offset = "0xB59870", VA = "0xB59870")]
		public static Task<Coroutine> InvokeAsyncAwaitStart(IEnumerator enumerator, ExecutionCycle cycle)
		{
			return null;
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0xB599D4", Offset = "0xB599D4", VA = "0xB599D4")]
		public static Task<Coroutine> InvokeAsyncAwaitStart(IEnumerator enumerator, ExecutionCycle cycle, MonoBehaviour target)
		{
			return null;
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0xB59B4C", Offset = "0xB59B4C", VA = "0xB59B4C")]
		public static Task<Coroutine> InvokeAsyncAwaitStart(IEnumerator enumerator, ExecutionCycle cycle, CancellationToken ct)
		{
			return null;
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0xB59CDC", Offset = "0xB59CDC", VA = "0xB59CDC")]
		public static Task<Coroutine> InvokeAsyncAwaitStart(IEnumerator enumerator, ExecutionCycle cycle, MonoBehaviour target, CancellationToken ct)
		{
			return null;
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0xB59E80", Offset = "0xB59E80", VA = "0xB59E80")]
		public static Task InvokeAsyncAwaitCompletion(IEnumerator enumerator, bool throwExceptions = true)
		{
			return null;
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0xB59FD4", Offset = "0xB59FD4", VA = "0xB59FD4")]
		public static Task InvokeAsyncAwaitCompletion(IEnumerator enumerator, CancellationToken ct, bool throwExceptions = true)
		{
			return null;
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0xB5A13C", Offset = "0xB5A13C", VA = "0xB5A13C")]
		public static Task InvokeAsyncAwaitCompletion(IEnumerator enumerator, MonoBehaviour target, bool throwExceptions = true)
		{
			return null;
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0xB5A2A0", Offset = "0xB5A2A0", VA = "0xB5A2A0")]
		public static Task InvokeAsyncAwaitCompletion(IEnumerator enumerator, MonoBehaviour target, CancellationToken ct, bool throwExceptions = true)
		{
			return null;
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0xB5A420", Offset = "0xB5A420", VA = "0xB5A420")]
		public static Task InvokeAsyncAwaitCompletion(IEnumerator enumerator, ExecutionCycle cycle, bool throwExceptions = true)
		{
			return null;
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0xB5A584", Offset = "0xB5A584", VA = "0xB5A584")]
		public static Task InvokeAsyncAwaitCompletion(IEnumerator enumerator, ExecutionCycle cycle, CancellationToken ct, bool throwExceptions = true)
		{
			return null;
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0xB5A6FC", Offset = "0xB5A6FC", VA = "0xB5A6FC")]
		public static Task InvokeAsyncAwaitCompletion(IEnumerator enumerator, ExecutionCycle cycle, MonoBehaviour target, bool throwExceptions = true)
		{
			return null;
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0xB5A870", Offset = "0xB5A870", VA = "0xB5A870")]
		public static Task InvokeAsyncAwaitCompletion(IEnumerator enumerator, ExecutionCycle cycle, MonoBehaviour target, CancellationToken ct, bool throwExceptions = true)
		{
			return null;
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0xB5A9F8", Offset = "0xB5A9F8", VA = "0xB5A9F8")]
		public static void CancelCoroutine(Coroutine coroutine)
		{
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0xB5AADC", Offset = "0xB5AADC", VA = "0xB5AADC")]
		public static Task CancelCoroutineAsync(Coroutine coroutine)
		{
			return null;
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0xB5AC20", Offset = "0xB5AC20", VA = "0xB5AC20")]
		public static Task CancelCoroutineAsync(Coroutine coroutine, CancellationToken ct, bool throwOnCancellation = true)
		{
			return null;
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000033")]
		[Address(RVA = "0xB5AD88", Offset = "0xB5AD88", VA = "0xB5AD88")]
		private static void StartCoroutineInternal(IEnumerator coroutine, TaskCompletionSource tcs, CancellationToken ct, bool throwExceptions, MonoBehaviour target)
		{
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000034")]
		[Address(RVA = "0xB5AF80", Offset = "0xB5AF80", VA = "0xB5AF80")]
		private static void StartCoroutineInternal(IEnumerator coroutine, TaskCompletionSource tcs, CancellationToken ct, bool throwExceptions)
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0xB5B248", Offset = "0xB5B248", VA = "0xB5B248")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0xB5B27C", Offset = "0xB5B27C", VA = "0xB5B27C")]
		[Obsolete("Use InvokeAsyncAwaitStart or InvokeAsyncAwaitCompletion instead!")]
		public static Task<Coroutine> InvokeAsync(IEnumerator enumerator)
		{
			return null;
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0xB5B2D0", Offset = "0xB5B2D0", VA = "0xB5B2D0")]
		[Obsolete("Use InvokeAsyncAwaitStart or InvokeAsyncAwaitCompletion instead!")]
		public static Task<Coroutine> InvokeAsync(IEnumerator enumerator, MonoBehaviour target)
		{
			return null;
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0xB5B334", Offset = "0xB5B334", VA = "0xB5B334")]
		[Obsolete("Use InvokeAsyncAwaitStart or InvokeAsyncAwaitCompletion instead!")]
		public static Task<Coroutine> InvokeAsync(IEnumerator enumerator, CancellationToken ct)
		{
			return null;
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0xB5B398", Offset = "0xB5B398", VA = "0xB5B398")]
		[Obsolete("Use InvokeAsyncAwaitStart or InvokeAsyncAwaitCompletion instead!")]
		public static Task<Coroutine> InvokeAsync(IEnumerator enumerator, MonoBehaviour target, CancellationToken ct)
		{
			return null;
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0xB5B404", Offset = "0xB5B404", VA = "0xB5B404")]
		[Obsolete("Use InvokeAsyncAwaitStart or InvokeAsyncAwaitCompletion instead!")]
		public static Task<Coroutine> InvokeAsync(IEnumerator enumerator, ExecutionCycle cycle)
		{
			return null;
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0xB5B468", Offset = "0xB5B468", VA = "0xB5B468")]
		[Obsolete("Use InvokeAsyncAwaitStart or InvokeAsyncAwaitCompletion instead!")]
		public static Task<Coroutine> InvokeAsync(IEnumerator enumerator, ExecutionCycle cycle, MonoBehaviour target)
		{
			return null;
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0xB5B4D4", Offset = "0xB5B4D4", VA = "0xB5B4D4")]
		[Obsolete("Use InvokeAsyncAwaitStart or InvokeAsyncAwaitCompletion instead!")]
		public static Task<Coroutine> InvokeAsync(IEnumerator enumerator, ExecutionCycle cycle, CancellationToken ct)
		{
			return null;
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0xB5B540", Offset = "0xB5B540", VA = "0xB5B540")]
		[Obsolete("Use InvokeAsyncAwaitStart or InvokeAsyncAwaitCompletion instead!")]
		public static Task<Coroutine> InvokeAsync(IEnumerator enumerator, ExecutionCycle cycle, MonoBehaviour target, CancellationToken ct)
		{
			return null;
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0xB5B5BC", Offset = "0xB5B5BC", VA = "0xB5B5BC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0xB5B7F0", Offset = "0xB5B7F0", VA = "0xB5B7F0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0xB5B94C", Offset = "0xB5B94C", VA = "0xB5B94C")]
		public static void Invoke(Func<Task> function)
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0xB5BA30", Offset = "0xB5BA30", VA = "0xB5BA30")]
		public static void Invoke(Func<Task> function, ExecutionCycle cycle)
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0xB5BB24", Offset = "0xB5BB24", VA = "0xB5BB24")]
		public static void Invoke(Func<CancellationToken, Task> function, CancellationToken ct, bool throwOnCancellation = true)
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0xB5BC34", Offset = "0xB5BC34", VA = "0xB5BC34")]
		public static void Invoke(Func<CancellationToken, Task> function, ExecutionCycle cycle, CancellationToken ct, bool throwOnCancellation = true)
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0xB5BD54", Offset = "0xB5BD54", VA = "0xB5BD54")]
		public static Task InvokeAsync(Func<Task> function)
		{
			return null;
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0xB5BE98", Offset = "0xB5BE98", VA = "0xB5BE98")]
		public static Task InvokeAsync(Func<Task> function, ExecutionCycle cycle)
		{
			return null;
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0xB5BFE4", Offset = "0xB5BFE4", VA = "0xB5BFE4")]
		public static Task InvokeAsync(Func<CancellationToken, Task> function, CancellationToken ct, bool throwOnCancellation = true)
		{
			return null;
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0xB5C14C", Offset = "0xB5C14C", VA = "0xB5C14C")]
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
		[Address(RVA = "0xB5C2C4", Offset = "0xB5C2C4", VA = "0xB5C2C4")]
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
		[Address(RVA = "0xB5CBD8", Offset = "0xB5CBD8", VA = "0xB5CBD8")]
		public void SetCompleted()
		{
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0xB60B80", Offset = "0xB60B80", VA = "0xB60B80")]
		public bool TrySetCompleted()
		{
			return default(bool);
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0xB589A8", Offset = "0xB589A8", VA = "0xB589A8")]
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
		[Address(RVA = "0xB60BCC", Offset = "0xB60BCC", VA = "0xB60BCC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0xB60C18", Offset = "0xB60C18", VA = "0xB60C18")]
		public DispatcherPostUpdate()
		{
		}
	}
	[Token(Token = "0x200003E")]
	public class BehaviourDisabledException : SystemException
	{
		[Token(Token = "0x60000C6")]
		[Address(RVA = "0xB60C20", Offset = "0xB60C20", VA = "0xB60C20")]
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
			[Address(RVA = "0xB60C28", Offset = "0xB60C28", VA = "0xB60C28", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60000C8")]
			[Address(RVA = "0xB60CC4", Offset = "0xB60CC4", VA = "0xB60CC4", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0xB60D60", Offset = "0xB60D60", VA = "0xB60D60")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0xB60D94", Offset = "0xB60D94", VA = "0xB60D94")]
		public DisableCallback()
		{
		}
	}
	[Token(Token = "0x2000040")]
	public static class ExceptionSensitiveCoroutineHandler
	{
		[Token(Token = "0x60000CB")]
		[Address(RVA = "0xB60D9C", Offset = "0xB60D9C", VA = "0xB60D9C")]
		private static IEnumerator StartCoroutineExceptionSensitiveInternal(IEnumerator enumerator, Func<Exception, bool> error, Func<bool> completed, IDisableCallback callback, CancellationToken ct)
		{
			return null;
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0xB5AEA0", Offset = "0xB5AEA0", VA = "0xB5AEA0")]
		public static void StartCoroutineExceptionSensitive(this MonoBehaviour target, IEnumerator enumerator, Func<Exception, bool> error, Func<bool> completed, CancellationToken ct)
		{
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0xB5B0D8", Offset = "0xB5B0D8", VA = "0xB5B0D8")]
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
