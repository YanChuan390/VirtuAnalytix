using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using Il2CppDummyDll;
using MoonSharp.Interpreter;
using MoonSharp.Interpreter.Compatibility.Frameworks;
using MoonSharp.Interpreter.CoreLib.IO;
using MoonSharp.Interpreter.DataStructs;
using MoonSharp.Interpreter.Debugging;
using MoonSharp.Interpreter.Diagnostics;
using MoonSharp.Interpreter.Diagnostics.PerformanceCounters;
using MoonSharp.Interpreter.Execution;
using MoonSharp.Interpreter.Execution.Scopes;
using MoonSharp.Interpreter.Execution.VM;
using MoonSharp.Interpreter.Interop;
using MoonSharp.Interpreter.Interop.BasicDescriptors;
using MoonSharp.Interpreter.Interop.LuaStateInterop;
using MoonSharp.Interpreter.Interop.RegistrationPolicies;
using MoonSharp.Interpreter.Loaders;
using MoonSharp.Interpreter.Platforms;
using MoonSharp.Interpreter.Tree;
using MoonSharp.Interpreter.Tree.Expressions;
using MoonSharp.Interpreter.Tree.Statements;
using MoonSharp.VsCodeDebugger.DebuggerLogic;
using MoonSharp.VsCodeDebugger.SDK;

[assembly: AssemblyVersion("0.0.0.0")]
namespace MoonSharp.Interpreter
{
	[Token(Token = "0x200000C")]
	internal static class Extension_Methods
	{
		[Token(Token = "0x6000039")]
		public static TValue GetOrDefault<TKey, TValue>(this Dictionary<TKey, TValue> dictionary, TKey key)
		{
			return (TValue)null;
		}

		[Token(Token = "0x600003A")]
		public static TValue GetOrCreate<TKey, TValue>(this Dictionary<TKey, TValue> dictionary, TKey key, Func<TValue> creator)
		{
			return (TValue)null;
		}
	}
	[Token(Token = "0x200000D")]
	public class CallbackArguments
	{
		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IList<DynValue> m_Args;

		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int m_Count;

		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private bool m_LastIsTuple;

		[Token(Token = "0x17000011")]
		public int Count
		{
			[Token(Token = "0x600003C")]
			[Address(RVA = "0xD8D128", Offset = "0xD8D128", VA = "0xD8D128")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000012")]
		public bool IsMethodCall
		{
			[Token(Token = "0x600003D")]
			[Address(RVA = "0xD8D130", Offset = "0xD8D130", VA = "0xD8D130")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600003E")]
			[Address(RVA = "0xD8D138", Offset = "0xD8D138", VA = "0xD8D138")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000013")]
		public DynValue this[int index]
		{
			[Token(Token = "0x600003F")]
			[Address(RVA = "0xD8D144", Offset = "0xD8D144", VA = "0xD8D144")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0xD8CE28", Offset = "0xD8CE28", VA = "0xD8CE28")]
		public CallbackArguments(IList<DynValue> args, bool isMethodCall)
		{
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0xD8D1E8", Offset = "0xD8D1E8", VA = "0xD8D1E8")]
		public DynValue RawGet(int index, bool translateVoids)
		{
			return null;
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0xD8D5A4", Offset = "0xD8D5A4", VA = "0xD8D5A4")]
		public DynValue[] GetArray(int skip = 0)
		{
			return null;
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0xD8D6AC", Offset = "0xD8D6AC", VA = "0xD8D6AC")]
		public DynValue AsType(int argNum, string funcName, DataType type, bool allowNil = false)
		{
			return null;
		}

		[Token(Token = "0x6000043")]
		public T AsUserData<T>(int argNum, string funcName, bool allowNil = false)
		{
			return (T)null;
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0xD8D8B0", Offset = "0xD8D8B0", VA = "0xD8D8B0")]
		public int AsInt(int argNum, string funcName)
		{
			return default(int);
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0xD8D8EC", Offset = "0xD8D8EC", VA = "0xD8D8EC")]
		public long AsLong(int argNum, string funcName)
		{
			return default(long);
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0xD8D928", Offset = "0xD8D928", VA = "0xD8D928")]
		public string AsStringUsingMeta(ScriptExecutionContext executionContext, int argNum, string funcName)
		{
			return null;
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0xD8E28C", Offset = "0xD8E28C", VA = "0xD8E28C")]
		public CallbackArguments SkipMethodCall()
		{
			return null;
		}
	}
	[Token(Token = "0x200000E")]
	public sealed class CallbackFunction : RefIdObject
	{
		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static InteropAccessMode m_DefaultAccessMode;

		[Token(Token = "0x17000014")]
		public string Name
		{
			[Token(Token = "0x6000048")]
			[Address(RVA = "0xD8E3CC", Offset = "0xD8E3CC", VA = "0xD8E3CC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000049")]
			[Address(RVA = "0xD8E3D4", Offset = "0xD8E3D4", VA = "0xD8E3D4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000015")]
		public Func<ScriptExecutionContext, CallbackArguments, DynValue> ClrCallback
		{
			[Token(Token = "0x600004A")]
			[Address(RVA = "0xD8E3DC", Offset = "0xD8E3DC", VA = "0xD8E3DC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600004B")]
			[Address(RVA = "0xD8E3E4", Offset = "0xD8E3E4", VA = "0xD8E3E4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000016")]
		public static InteropAccessMode DefaultAccessMode
		{
			[Token(Token = "0x600004E")]
			[Address(RVA = "0xD8E640", Offset = "0xD8E640", VA = "0xD8E640")]
			get
			{
				return default(InteropAccessMode);
			}
			[Token(Token = "0x600004F")]
			[Address(RVA = "0xD8E698", Offset = "0xD8E698", VA = "0xD8E698")]
			set
			{
			}
		}

		[Token(Token = "0x17000017")]
		public object AdditionalData
		{
			[Token(Token = "0x6000052")]
			[Address(RVA = "0xD8E8F0", Offset = "0xD8E8F0", VA = "0xD8E8F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000053")]
			[Address(RVA = "0xD8E8F8", Offset = "0xD8E8F8", VA = "0xD8E8F8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0xD8E3EC", Offset = "0xD8E3EC", VA = "0xD8E3EC")]
		public CallbackFunction(Func<ScriptExecutionContext, CallbackArguments, DynValue> callBack, [Optional] string name)
		{
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0xD8E474", Offset = "0xD8E474", VA = "0xD8E474")]
		public DynValue Invoke(ScriptExecutionContext executionContext, IList<DynValue> args, bool isMethodCall = false)
		{
			return null;
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0xD8E75C", Offset = "0xD8E75C", VA = "0xD8E75C")]
		public static CallbackFunction FromDelegate(Script script, Delegate del, InteropAccessMode accessMode = InteropAccessMode.Default)
		{
			return null;
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0xD8E830", Offset = "0xD8E830", VA = "0xD8E830")]
		public static CallbackFunction FromMethodInfo(Script script, MethodInfo mi, [Optional] object obj, InteropAccessMode accessMode = InteropAccessMode.Default)
		{
			return null;
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0xD8E900", Offset = "0xD8E900", VA = "0xD8E900")]
		public static bool CheckCallbackSignature(MethodInfo mi, bool requirePublicVisibility)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200000F")]
	public class Closure : RefIdObject, IScriptPrivateResource
	{
		[Token(Token = "0x2000010")]
		public enum UpvaluesType
		{
			[Token(Token = "0x400001E")]
			None,
			[Token(Token = "0x400001F")]
			Environment,
			[Token(Token = "0x4000020")]
			Closure
		}

		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static ClosureContext emptyClosure;

		[Token(Token = "0x17000018")]
		public int EntryPointByteCodeLocation
		{
			[Token(Token = "0x6000056")]
			[Address(RVA = "0xD8EB34", Offset = "0xD8EB34", VA = "0xD8EB34")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000057")]
			[Address(RVA = "0xD8EB3C", Offset = "0xD8EB3C", VA = "0xD8EB3C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000019")]
		public Script OwnerScript
		{
			[Token(Token = "0x6000058")]
			[Address(RVA = "0xD8EB44", Offset = "0xD8EB44", VA = "0xD8EB44", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000059")]
			[Address(RVA = "0xD8EB4C", Offset = "0xD8EB4C", VA = "0xD8EB4C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700001A")]
		internal ClosureContext ClosureContext
		{
			[Token(Token = "0x600005A")]
			[Address(RVA = "0xD8EB54", Offset = "0xD8EB54", VA = "0xD8EB54")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600005B")]
			[Address(RVA = "0xD8EB5C", Offset = "0xD8EB5C", VA = "0xD8EB5C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0xD8EB64", Offset = "0xD8EB64", VA = "0xD8EB64")]
		internal Closure(Script script, int idx, SymbolRef[] symbols, IEnumerable<DynValue> resolvedLocals)
		{
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0xD8EC40", Offset = "0xD8EC40", VA = "0xD8EC40")]
		public DynValue Call()
		{
			return null;
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0xD8ECD0", Offset = "0xD8ECD0", VA = "0xD8ECD0")]
		public DynValue Call(params object[] args)
		{
			return null;
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0xD8ED70", Offset = "0xD8ED70", VA = "0xD8ED70")]
		public DynValue Call(params DynValue[] args)
		{
			return null;
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0xD8ED94", Offset = "0xD8ED94", VA = "0xD8ED94")]
		public ScriptFunctionDelegate GetDelegate()
		{
			return null;
		}

		[Token(Token = "0x6000061")]
		public ScriptFunctionDelegate<T> GetDelegate<T>()
		{
			return null;
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0xD8EF38", Offset = "0xD8EF38", VA = "0xD8EF38")]
		public int GetUpvaluesCount()
		{
			return default(int);
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0xD8EF80", Offset = "0xD8EF80", VA = "0xD8EF80")]
		public string GetUpvalueName(int idx)
		{
			return null;
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0xD8EFB8", Offset = "0xD8EFB8", VA = "0xD8EFB8")]
		public DynValue GetUpvalue(int idx)
		{
			return null;
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0xD8F010", Offset = "0xD8F010", VA = "0xD8F010")]
		public UpvaluesType GetUpvaluesType()
		{
			return default(UpvaluesType);
		}
	}
	[Token(Token = "0x2000011")]
	public class Coroutine : RefIdObject, IScriptPrivateResource
	{
		[Token(Token = "0x2000012")]
		public enum CoroutineType
		{
			[Token(Token = "0x4000026")]
			Coroutine,
			[Token(Token = "0x4000027")]
			ClrCallback,
			[Token(Token = "0x4000028")]
			ClrCallbackDead
		}

		[Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class <AsTypedEnumerable>d__10 : IEnumerable<DynValue>, IEnumerable, IEnumerator<DynValue>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000029")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400002A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private DynValue <>2__current;

			[Token(Token = "0x400002B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x400002C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Coroutine <>4__this;

			[Token(Token = "0x1700001F")]
			private DynValue System.Collections.Generic.IEnumerator<MoonSharp.Interpreter.DynValue>.Current
			{
				[Token(Token = "0x6000081")]
				[Address(RVA = "0xD8FEC4", Offset = "0xD8FEC4", VA = "0xD8FEC4", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000020")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000083")]
				[Address(RVA = "0xD8FF0C", Offset = "0xD8FF0C", VA = "0xD8FF0C", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600007E")]
			[Address(RVA = "0xD8F288", Offset = "0xD8F288", VA = "0xD8F288")]
			[DebuggerHidden]
			public <AsTypedEnumerable>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x600007F")]
			[Address(RVA = "0xD8FDE8", Offset = "0xD8FDE8", VA = "0xD8FDE8", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000080")]
			[Address(RVA = "0xD8FDEC", Offset = "0xD8FDEC", VA = "0xD8FDEC", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000082")]
			[Address(RVA = "0xD8FECC", Offset = "0xD8FECC", VA = "0xD8FECC", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000084")]
			[Address(RVA = "0xD8FF14", Offset = "0xD8FF14", VA = "0xD8FF14", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<DynValue> System.Collections.Generic.IEnumerable<MoonSharp.Interpreter.DynValue>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000085")]
			[Address(RVA = "0xD8FFB8", Offset = "0xD8FFB8", VA = "0xD8FFB8", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class <AsEnumerable>d__11 : IEnumerable<object>, IEnumerable, IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400002D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400002E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400002F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x4000030")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Coroutine <>4__this;

			[Token(Token = "0x4000031")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private IEnumerator<DynValue> <>7__wrap1;

			[Token(Token = "0x17000021")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600008A")]
				[Address(RVA = "0xD90430", Offset = "0xD90430", VA = "0xD90430", Slot = "6")]
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
				[Address(RVA = "0xD90478", Offset = "0xD90478", VA = "0xD90478", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000086")]
			[Address(RVA = "0xD8F334", Offset = "0xD8F334", VA = "0xD8F334")]
			[DebuggerHidden]
			public <AsEnumerable>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x6000087")]
			[Address(RVA = "0xD8FFBC", Offset = "0xD8FFBC", VA = "0xD8FFBC", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000088")]
			[Address(RVA = "0xD8FFD8", Offset = "0xD8FFD8", VA = "0xD8FFD8", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000089")]
			[Address(RVA = "0xD90380", Offset = "0xD90380", VA = "0xD90380")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x600008B")]
			[Address(RVA = "0xD90438", Offset = "0xD90438", VA = "0xD90438", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x600008D")]
			[Address(RVA = "0xD90480", Offset = "0xD90480", VA = "0xD90480", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<object> System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x600008E")]
			[Address(RVA = "0xD90524", Offset = "0xD90524", VA = "0xD90524", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class <AsEnumerable>d__12<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000032")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <>1__state;

			[Token(Token = "0x4000033")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private T <>2__current;

			[Token(Token = "0x4000034")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <>l__initialThreadId;

			[Token(Token = "0x4000035")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Coroutine <>4__this;

			[Token(Token = "0x4000036")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private IEnumerator<DynValue> <>7__wrap1;

			[Token(Token = "0x17000023")]
			private T System.Collections.Generic.IEnumerator<T>.Current
			{
				[Token(Token = "0x6000093")]
				[DebuggerHidden]
				get
				{
					return (T)null;
				}
			}

			[Token(Token = "0x17000024")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000095")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600008F")]
			[DebuggerHidden]
			public <AsEnumerable>d__12(int <>1__state)
			{
			}

			[Token(Token = "0x6000090")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000091")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000092")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000094")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000096")]
			[DebuggerHidden]
			private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000097")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class <AsUnityCoroutine>d__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000037")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000038")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000039")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Coroutine <>4__this;

			[Token(Token = "0x400003A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private IEnumerator<DynValue> <>7__wrap1;

			[Token(Token = "0x17000025")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600009C")]
				[Address(RVA = "0xD90898", Offset = "0xD90898", VA = "0xD90898", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000026")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600009E")]
				[Address(RVA = "0xD908E0", Offset = "0xD908E0", VA = "0xD908E0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000098")]
			[Address(RVA = "0xD8F3D0", Offset = "0xD8F3D0", VA = "0xD8F3D0")]
			[DebuggerHidden]
			public <AsUnityCoroutine>d__13(int <>1__state)
			{
			}

			[Token(Token = "0x6000099")]
			[Address(RVA = "0xD90528", Offset = "0xD90528", VA = "0xD90528", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600009A")]
			[Address(RVA = "0xD90544", Offset = "0xD90544", VA = "0xD90544", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600009B")]
			[Address(RVA = "0xD907E8", Offset = "0xD907E8", VA = "0xD907E8")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x600009D")]
			[Address(RVA = "0xD908A0", Offset = "0xD908A0", VA = "0xD908A0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CallbackFunction m_ClrCallback;

		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Processor m_Processor;

		[Token(Token = "0x1700001B")]
		public CoroutineType Type
		{
			[Token(Token = "0x6000069")]
			[Address(RVA = "0xD8F128", Offset = "0xD8F128", VA = "0xD8F128")]
			[CompilerGenerated]
			get
			{
				return default(CoroutineType);
			}
			[Token(Token = "0x600006A")]
			[Address(RVA = "0xD8F130", Offset = "0xD8F130", VA = "0xD8F130")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		public CoroutineState State
		{
			[Token(Token = "0x6000078")]
			[Address(RVA = "0xD8FC98", Offset = "0xD8FC98", VA = "0xD8FC98")]
			get
			{
				return default(CoroutineState);
			}
		}

		[Token(Token = "0x1700001D")]
		public Script OwnerScript
		{
			[Token(Token = "0x600007A")]
			[Address(RVA = "0xD8FDA0", Offset = "0xD8FDA0", VA = "0xD8FDA0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600007B")]
			[Address(RVA = "0xD8FDA8", Offset = "0xD8FDA8", VA = "0xD8FDA8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700001E")]
		public long AutoYieldCounter
		{
			[Token(Token = "0x600007C")]
			[Address(RVA = "0xD8FDB0", Offset = "0xD8FDB0", VA = "0xD8FDB0")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x600007D")]
			[Address(RVA = "0xD8FDCC", Offset = "0xD8FDCC", VA = "0xD8FDCC")]
			set
			{
			}
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0xD8F138", Offset = "0xD8F138", VA = "0xD8F138")]
		internal Coroutine(CallbackFunction function)
		{
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0xD8F168", Offset = "0xD8F168", VA = "0xD8F168")]
		internal Coroutine(Processor proc)
		{
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0xD8F1A4", Offset = "0xD8F1A4", VA = "0xD8F1A4")]
		internal void MarkClrCallbackAsDead()
		{
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0xD8F210", Offset = "0xD8F210", VA = "0xD8F210")]
		[IteratorStateMachine(typeof(<AsTypedEnumerable>d__10))]
		public IEnumerable<DynValue> AsTypedEnumerable()
		{
			return null;
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0xD8F2BC", Offset = "0xD8F2BC", VA = "0xD8F2BC")]
		[IteratorStateMachine(typeof(<AsEnumerable>d__11))]
		public IEnumerable<object> AsEnumerable()
		{
			return null;
		}

		[Token(Token = "0x6000070")]
		[IteratorStateMachine(typeof(<AsEnumerable>d__12<>))]
		public IEnumerable<T> AsEnumerable<T>()
		{
			return null;
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0xD8F368", Offset = "0xD8F368", VA = "0xD8F368")]
		[IteratorStateMachine(typeof(<AsUnityCoroutine>d__13))]
		public IEnumerator AsUnityCoroutine()
		{
			return null;
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0xD8F3F8", Offset = "0xD8F3F8", VA = "0xD8F3F8")]
		public DynValue Resume(params DynValue[] args)
		{
			return null;
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0xD8F4EC", Offset = "0xD8F4EC", VA = "0xD8F4EC")]
		public DynValue Resume(ScriptExecutionContext context, params DynValue[] args)
		{
			return null;
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0xD8F918", Offset = "0xD8F918", VA = "0xD8F918")]
		public DynValue Resume()
		{
			return null;
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0xD8F96C", Offset = "0xD8F96C", VA = "0xD8F96C")]
		public DynValue Resume(ScriptExecutionContext context)
		{
			return null;
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0xD8F9D0", Offset = "0xD8F9D0", VA = "0xD8F9D0")]
		public DynValue Resume(params object[] args)
		{
			return null;
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0xD8FB54", Offset = "0xD8FB54", VA = "0xD8FB54")]
		public DynValue Resume(ScriptExecutionContext context, params object[] args)
		{
			return null;
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0xD8FCD4", Offset = "0xD8FCD4", VA = "0xD8FCD4")]
		public WatchItem[] GetStackTrace(int skip, [Optional] SourceRef entrySourceRef)
		{
			return null;
		}
	}
	[Token(Token = "0x2000017")]
	public enum CoroutineState
	{
		[Token(Token = "0x400003C")]
		Main,
		[Token(Token = "0x400003D")]
		NotStarted,
		[Token(Token = "0x400003E")]
		Suspended,
		[Token(Token = "0x400003F")]
		ForceSuspended,
		[Token(Token = "0x4000040")]
		Running,
		[Token(Token = "0x4000041")]
		Dead
	}
	[Token(Token = "0x2000018")]
	public enum DataType
	{
		[Token(Token = "0x4000043")]
		Nil,
		[Token(Token = "0x4000044")]
		Void,
		[Token(Token = "0x4000045")]
		Boolean,
		[Token(Token = "0x4000046")]
		Number,
		[Token(Token = "0x4000047")]
		String,
		[Token(Token = "0x4000048")]
		Function,
		[Token(Token = "0x4000049")]
		Table,
		[Token(Token = "0x400004A")]
		Tuple,
		[Token(Token = "0x400004B")]
		UserData,
		[Token(Token = "0x400004C")]
		Thread,
		[Token(Token = "0x400004D")]
		ClrFunction,
		[Token(Token = "0x400004E")]
		TailCallRequest,
		[Token(Token = "0x400004F")]
		YieldRequest
	}
	[Token(Token = "0x2000019")]
	public static class LuaTypeExtensions
	{
		[Token(Token = "0x4000050")]
		internal const DataType MaxMetaTypes = DataType.Table;

		[Token(Token = "0x4000051")]
		internal const DataType MaxConvertibleTypes = DataType.ClrFunction;

		[Token(Token = "0x600009F")]
		[Address(RVA = "0xD908E8", Offset = "0xD908E8", VA = "0xD908E8")]
		public static bool CanHaveTypeMetatables(this DataType type)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0xD908F4", Offset = "0xD908F4", VA = "0xD908F4")]
		public static string ToErrorTypeString(this DataType type)
		{
			return null;
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0xD90A50", Offset = "0xD90A50", VA = "0xD90A50")]
		public static string ToLuaDebuggerString(this DataType type)
		{
			return null;
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0xD90AC4", Offset = "0xD90AC4", VA = "0xD90AC4")]
		public static string ToLuaTypeString(this DataType type)
		{
			return null;
		}
	}
	[Token(Token = "0x200001A")]
	public sealed class DynValue
	{
		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int s_RefIDCounter;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int m_RefID;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private int m_HashCode;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool m_ReadOnly;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private double m_Number;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private object m_Object;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private DataType m_Type;

		[Token(Token = "0x17000027")]
		public int ReferenceID
		{
			[Token(Token = "0x60000A3")]
			[Address(RVA = "0xD90C18", Offset = "0xD90C18", VA = "0xD90C18")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000028")]
		public DataType Type
		{
			[Token(Token = "0x60000A4")]
			[Address(RVA = "0xD90C20", Offset = "0xD90C20", VA = "0xD90C20")]
			get
			{
				return default(DataType);
			}
		}

		[Token(Token = "0x17000029")]
		public Closure Function
		{
			[Token(Token = "0x60000A5")]
			[Address(RVA = "0xD90C28", Offset = "0xD90C28", VA = "0xD90C28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002A")]
		public double Number
		{
			[Token(Token = "0x60000A6")]
			[Address(RVA = "0xD90CA4", Offset = "0xD90CA4", VA = "0xD90CA4")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x1700002B")]
		public DynValue[] Tuple
		{
			[Token(Token = "0x60000A7")]
			[Address(RVA = "0xD8D0E0", Offset = "0xD8D0E0", VA = "0xD8D0E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002C")]
		public Coroutine Coroutine
		{
			[Token(Token = "0x60000A8")]
			[Address(RVA = "0xD90CAC", Offset = "0xD90CAC", VA = "0xD90CAC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002D")]
		public Table Table
		{
			[Token(Token = "0x60000A9")]
			[Address(RVA = "0xD8DB54", Offset = "0xD8DB54", VA = "0xD8DB54")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002E")]
		public bool Boolean
		{
			[Token(Token = "0x60000AA")]
			[Address(RVA = "0xD90D28", Offset = "0xD90D28", VA = "0xD90D28")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700002F")]
		public string String
		{
			[Token(Token = "0x60000AB")]
			[Address(RVA = "0xD90D38", Offset = "0xD90D38", VA = "0xD90D38")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000030")]
		public CallbackFunction Callback
		{
			[Token(Token = "0x60000AC")]
			[Address(RVA = "0xD90D98", Offset = "0xD90D98", VA = "0xD90D98")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000031")]
		public TailCallData TailCallData
		{
			[Token(Token = "0x60000AD")]
			[Address(RVA = "0xD90DF8", Offset = "0xD90DF8", VA = "0xD90DF8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000032")]
		public YieldRequest YieldRequest
		{
			[Token(Token = "0x60000AE")]
			[Address(RVA = "0xD90E74", Offset = "0xD90E74", VA = "0xD90E74")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000033")]
		public UserData UserData
		{
			[Token(Token = "0x60000AF")]
			[Address(RVA = "0xD90EF0", Offset = "0xD90EF0", VA = "0xD90EF0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000034")]
		public bool ReadOnly
		{
			[Token(Token = "0x60000B0")]
			[Address(RVA = "0xD90F6C", Offset = "0xD90F6C", VA = "0xD90F6C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000035")]
		public static DynValue Void
		{
			[Token(Token = "0x60000CA")]
			[Address(RVA = "0xD91F6C", Offset = "0xD91F6C", VA = "0xD91F6C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000CB")]
			[Address(RVA = "0xD91FC4", Offset = "0xD91FC4", VA = "0xD91FC4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000036")]
		public static DynValue Nil
		{
			[Token(Token = "0x60000CC")]
			[Address(RVA = "0xD92020", Offset = "0xD92020", VA = "0xD92020")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000CD")]
			[Address(RVA = "0xD92078", Offset = "0xD92078", VA = "0xD92078")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000037")]
		public static DynValue True
		{
			[Token(Token = "0x60000CE")]
			[Address(RVA = "0xD920D4", Offset = "0xD920D4", VA = "0xD920D4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000CF")]
			[Address(RVA = "0xD9212C", Offset = "0xD9212C", VA = "0xD9212C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000038")]
		public static DynValue False
		{
			[Token(Token = "0x60000D0")]
			[Address(RVA = "0xD92188", Offset = "0xD92188", VA = "0xD92188")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000D1")]
			[Address(RVA = "0xD921E0", Offset = "0xD921E0", VA = "0xD921E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0xD90F74", Offset = "0xD90F74", VA = "0xD90F74")]
		public static DynValue NewNil()
		{
			return null;
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0xD91040", Offset = "0xD91040", VA = "0xD91040")]
		public static DynValue NewBoolean(bool v)
		{
			return null;
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0xD910B8", Offset = "0xD910B8", VA = "0xD910B8")]
		public static DynValue NewNumber(double num)
		{
			return null;
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0xD91130", Offset = "0xD91130", VA = "0xD91130")]
		public static DynValue NewString(string str)
		{
			return null;
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0xD91198", Offset = "0xD91198", VA = "0xD91198")]
		public static DynValue NewString(StringBuilder sb)
		{
			return null;
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0xD91214", Offset = "0xD91214", VA = "0xD91214")]
		public static DynValue NewString(string format, params object[] args)
		{
			return null;
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0xD91298", Offset = "0xD91298", VA = "0xD91298")]
		public static DynValue NewCoroutine(Coroutine coroutine)
		{
			return null;
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0xD91300", Offset = "0xD91300", VA = "0xD91300")]
		public static DynValue NewClosure(Closure function)
		{
			return null;
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0xD91368", Offset = "0xD91368", VA = "0xD91368")]
		public static DynValue NewCallback(Func<ScriptExecutionContext, CallbackArguments, DynValue> callBack, [Optional] string name)
		{
			return null;
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0xD91408", Offset = "0xD91408", VA = "0xD91408")]
		public static DynValue NewCallback(CallbackFunction function)
		{
			return null;
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0xD91470", Offset = "0xD91470", VA = "0xD91470")]
		public static DynValue NewTable(Table table)
		{
			return null;
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0xD914D8", Offset = "0xD914D8", VA = "0xD914D8")]
		public static DynValue NewPrimeTable()
		{
			return null;
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0xD916CC", Offset = "0xD916CC", VA = "0xD916CC")]
		public static DynValue NewTable(Script script)
		{
			return null;
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0xD91750", Offset = "0xD91750", VA = "0xD91750")]
		public static DynValue NewTable(Script script, params DynValue[] arrayValues)
		{
			return null;
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0xD918B0", Offset = "0xD918B0", VA = "0xD918B0")]
		public static DynValue NewTailCallReq(DynValue tailFn, params DynValue[] args)
		{
			return null;
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0xD9195C", Offset = "0xD9195C", VA = "0xD9195C")]
		public static DynValue NewTailCallReq(TailCallData tailCallData)
		{
			return null;
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0xD919C4", Offset = "0xD919C4", VA = "0xD919C4")]
		public static DynValue NewYieldReq(DynValue[] args)
		{
			return null;
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0xD91A64", Offset = "0xD91A64", VA = "0xD91A64")]
		internal static DynValue NewForcedYieldReq()
		{
			return null;
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0xD91AFC", Offset = "0xD91AFC", VA = "0xD91AFC")]
		public static DynValue NewTuple(params DynValue[] values)
		{
			return null;
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0xD91B9C", Offset = "0xD91B9C", VA = "0xD91B9C")]
		public static DynValue NewTupleNested(params DynValue[] values)
		{
			return null;
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0xD91E58", Offset = "0xD91E58", VA = "0xD91E58")]
		public static DynValue NewUserData(UserData userData)
		{
			return null;
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0xD91EC0", Offset = "0xD91EC0", VA = "0xD91EC0")]
		public DynValue AsReadOnly()
		{
			return null;
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0xD91F5C", Offset = "0xD91F5C", VA = "0xD91F5C")]
		public DynValue Clone()
		{
			return null;
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0xD91ED4", Offset = "0xD91ED4", VA = "0xD91ED4")]
		public DynValue Clone(bool readOnly)
		{
			return null;
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0xD91F64", Offset = "0xD91F64", VA = "0xD91F64")]
		public DynValue CloneAsWritable()
		{
			return null;
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0xD9223C", Offset = "0xD9223C", VA = "0xD9223C")]
		static DynValue()
		{
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0xD8DF2C", Offset = "0xD8DF2C", VA = "0xD8DF2C")]
		public string ToPrintString()
		{
			return null;
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0xD924B0", Offset = "0xD924B0", VA = "0xD924B0")]
		public string ToDebugPrintString()
		{
			return null;
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0xD927B4", Offset = "0xD927B4", VA = "0xD927B4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0xD92C58", Offset = "0xD92C58", VA = "0xD92C58", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0xD92DE8", Offset = "0xD92DE8", VA = "0xD92DE8", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0xD9309C", Offset = "0xD9309C", VA = "0xD9309C")]
		public string CastToString()
		{
			return null;
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0xD93138", Offset = "0xD93138", VA = "0xD93138")]
		public double? CastToNumber()
		{
			return null;
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0xD93264", Offset = "0xD93264", VA = "0xD93264")]
		public bool CastToBool()
		{
			return default(bool);
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0xD932A0", Offset = "0xD932A0", VA = "0xD932A0")]
		public IScriptPrivateResource GetAsPrivateResource()
		{
			return null;
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0xD902A8", Offset = "0xD902A8", VA = "0xD902A8")]
		public DynValue ToScalar()
		{
			return null;
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0xD932E8", Offset = "0xD932E8", VA = "0xD932E8")]
		public void Assign(DynValue value)
		{
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0xD93368", Offset = "0xD93368", VA = "0xD93368")]
		public DynValue GetLength()
		{
			return null;
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0xD935C4", Offset = "0xD935C4", VA = "0xD935C4")]
		public bool IsNil()
		{
			return default(bool);
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0xD935D4", Offset = "0xD935D4", VA = "0xD935D4")]
		public bool IsNotNil()
		{
			return default(bool);
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0xD935E4", Offset = "0xD935E4", VA = "0xD935E4")]
		public bool IsVoid()
		{
			return default(bool);
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0xD935F4", Offset = "0xD935F4", VA = "0xD935F4")]
		public bool IsNotVoid()
		{
			return default(bool);
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0xD93604", Offset = "0xD93604", VA = "0xD93604")]
		public bool IsNilOrNan()
		{
			return default(bool);
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0xD93688", Offset = "0xD93688", VA = "0xD93688")]
		internal void AssignNumber(double num)
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0xD8FB4C", Offset = "0xD8FB4C", VA = "0xD8FB4C")]
		public static DynValue FromObject(Script script, object obj)
		{
			return null;
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0xD8F120", Offset = "0xD8F120", VA = "0xD8F120")]
		public object ToObject()
		{
			return null;
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0xD937DC", Offset = "0xD937DC", VA = "0xD937DC")]
		public object ToObject(Type desiredType)
		{
			return null;
		}

		[Token(Token = "0x60000E8")]
		public T ToObject<T>()
		{
			return (T)null;
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0xD8D6FC", Offset = "0xD8D6FC", VA = "0xD8D6FC")]
		public DynValue CheckType(string funcName, DataType desiredType, int argNum = -1, TypeValidationFlags flags = TypeValidationFlags.AutoConvert)
		{
			return null;
		}

		[Token(Token = "0x60000EA")]
		public T CheckUserDataType<T>(string funcName, int argNum = -1, TypeValidationFlags flags = TypeValidationFlags.AutoConvert)
		{
			return (T)null;
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0xD90FCC", Offset = "0xD90FCC", VA = "0xD90FCC")]
		public DynValue()
		{
		}
	}
	[Token(Token = "0x200001C")]
	public interface IScriptPrivateResource
	{
		[Token(Token = "0x17000039")]
		Script OwnerScript
		{
			[Token(Token = "0x60000F3")]
			get;
		}
	}
	[Token(Token = "0x200001D")]
	internal static class ScriptPrivateResource_Extension
	{
		[Token(Token = "0x60000F4")]
		[Address(RVA = "0xD8F480", Offset = "0xD8F480", VA = "0xD8F480")]
		public static void CheckScriptOwnership(this IScriptPrivateResource containingResource, DynValue[] values)
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0xD93AA8", Offset = "0xD93AA8", VA = "0xD93AA8")]
		public static void CheckScriptOwnership(this IScriptPrivateResource containingResource, DynValue value)
		{
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0xD93AD8", Offset = "0xD93AD8", VA = "0xD93AD8")]
		public static void CheckScriptOwnership(this IScriptPrivateResource resource, Script script)
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0xD8F598", Offset = "0xD8F598", VA = "0xD8F598")]
		public static void CheckScriptOwnership(this IScriptPrivateResource containingResource, IScriptPrivateResource itemResource)
		{
		}
	}
	[Token(Token = "0x200001E")]
	public class RefIdObject
	{
		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int s_RefIDCounter;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int m_RefID;

		[Token(Token = "0x1700003A")]
		public int ReferenceID
		{
			[Token(Token = "0x60000F8")]
			[Address(RVA = "0xD93C2C", Offset = "0xD93C2C", VA = "0xD93C2C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0xD9241C", Offset = "0xD9241C", VA = "0xD9241C")]
		public string FormatTypeString(string typeString)
		{
			return null;
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0xD8E414", Offset = "0xD8E414", VA = "0xD8E414")]
		public RefIdObject()
		{
		}
	}
	[Token(Token = "0x200001F")]
	public delegate object ScriptFunctionDelegate(params object[] args);
	[Token(Token = "0x2000020")]
	public delegate T ScriptFunctionDelegate<T>(params object[] args);
	[Token(Token = "0x2000021")]
	public class SymbolRef
	{
		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static SymbolRef s_DefaultEnv;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal SymbolRefType i_Type;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal SymbolRef i_Env;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal int i_Index;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal string i_Name;

		[Token(Token = "0x1700003B")]
		public SymbolRefType Type
		{
			[Token(Token = "0x6000103")]
			[Address(RVA = "0xD93C74", Offset = "0xD93C74", VA = "0xD93C74")]
			get
			{
				return default(SymbolRefType);
			}
		}

		[Token(Token = "0x1700003C")]
		public int Index
		{
			[Token(Token = "0x6000104")]
			[Address(RVA = "0xD93C7C", Offset = "0xD93C7C", VA = "0xD93C7C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700003D")]
		public string Name
		{
			[Token(Token = "0x6000105")]
			[Address(RVA = "0xD93C84", Offset = "0xD93C84", VA = "0xD93C84")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003E")]
		public SymbolRef Environment
		{
			[Token(Token = "0x6000106")]
			[Address(RVA = "0xD93C8C", Offset = "0xD93C8C", VA = "0xD93C8C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003F")]
		public static SymbolRef DefaultEnv
		{
			[Token(Token = "0x6000107")]
			[Address(RVA = "0xD93C94", Offset = "0xD93C94", VA = "0xD93C94")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0xD93CEC", Offset = "0xD93CEC", VA = "0xD93CEC")]
		public static SymbolRef Global(string name, SymbolRef envSymbol)
		{
			return null;
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0xD93D78", Offset = "0xD93D78", VA = "0xD93D78")]
		internal static SymbolRef Local(string name, int index)
		{
			return null;
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0xD93DF0", Offset = "0xD93DF0", VA = "0xD93DF0")]
		internal static SymbolRef Upvalue(string name, int index)
		{
			return null;
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0xD93E6C", Offset = "0xD93E6C", VA = "0xD93E6C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0xD93F94", Offset = "0xD93F94", VA = "0xD93F94")]
		internal void WriteBinary(BinaryWriter bw)
		{
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0xD93FF8", Offset = "0xD93FF8", VA = "0xD93FF8")]
		internal static SymbolRef ReadBinary(BinaryReader br)
		{
			return null;
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0xD940A4", Offset = "0xD940A4", VA = "0xD940A4")]
		internal void WriteBinaryEnv(BinaryWriter bw, Dictionary<SymbolRef, int> symbolMap)
		{
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0xD94138", Offset = "0xD94138", VA = "0xD94138")]
		internal void ReadBinaryEnv(BinaryReader br, SymbolRef[] symbolRefs)
		{
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0xD93D70", Offset = "0xD93D70", VA = "0xD93D70")]
		public SymbolRef()
		{
		}
	}
	[Token(Token = "0x2000022")]
	public enum SymbolRefType
	{
		[Token(Token = "0x400006B")]
		Local,
		[Token(Token = "0x400006C")]
		Upvalue,
		[Token(Token = "0x400006D")]
		Global,
		[Token(Token = "0x400006E")]
		DefaultEnv
	}
	[Token(Token = "0x2000023")]
	public class Table : RefIdObject, IScriptPrivateResource
	{
		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly LinkedList<TablePair> m_Values;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly LinkedListIndex<DynValue, TablePair> m_ValueMap;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly LinkedListIndex<string, TablePair> m_StringMap;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly LinkedListIndex<int, TablePair> m_ArrayMap;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly Script m_Owner;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int m_InitArray;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private int m_CachedLength;

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool m_ContainsNilEntries;

		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Table m_MetaTable;

		[Token(Token = "0x17000040")]
		public Script OwnerScript
		{
			[Token(Token = "0x6000114")]
			[Address(RVA = "0xD94394", Offset = "0xD94394", VA = "0xD94394", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000041")]
		public object this[params object[] keys]
		{
			[Token(Token = "0x6000117")]
			[Address(RVA = "0xD94494", Offset = "0xD94494", VA = "0xD94494")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000118")]
			[Address(RVA = "0xD94550", Offset = "0xD94550", VA = "0xD94550")]
			set
			{
			}
		}

		[Token(Token = "0x17000042")]
		public object this[object key]
		{
			[Token(Token = "0x6000119")]
			[Address(RVA = "0xD94630", Offset = "0xD94630", VA = "0xD94630")]
			get
			{
				return null;
			}
			[Token(Token = "0x600011A")]
			[Address(RVA = "0xD946EC", Offset = "0xD946EC", VA = "0xD946EC")]
			set
			{
			}
		}

		[Token(Token = "0x17000043")]
		public int Length
		{
			[Token(Token = "0x6000137")]
			[Address(RVA = "0xD934F0", Offset = "0xD934F0", VA = "0xD934F0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000044")]
		public Table MetaTable
		{
			[Token(Token = "0x6000139")]
			[Address(RVA = "0xD95A2C", Offset = "0xD95A2C", VA = "0xD95A2C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600013A")]
			[Address(RVA = "0xD95A34", Offset = "0xD95A34", VA = "0xD95A34")]
			set
			{
			}
		}

		[Token(Token = "0x17000045")]
		public IEnumerable<TablePair> Pairs
		{
			[Token(Token = "0x600013B")]
			[Address(RVA = "0xD95A60", Offset = "0xD95A60", VA = "0xD95A60")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000046")]
		public IEnumerable<DynValue> Keys
		{
			[Token(Token = "0x600013C")]
			[Address(RVA = "0xD95B5C", Offset = "0xD95B5C", VA = "0xD95B5C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000047")]
		public IEnumerable<DynValue> Values
		{
			[Token(Token = "0x600013D")]
			[Address(RVA = "0xD95C58", Offset = "0xD95C58", VA = "0xD95C58")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0xD91558", Offset = "0xD91558", VA = "0xD91558")]
		public Table(Script owner)
		{
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0xD917E4", Offset = "0xD917E4", VA = "0xD917E4")]
		public Table(Script owner, params DynValue[] arrayValues)
		{
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0xD9439C", Offset = "0xD9439C", VA = "0xD9439C")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0xD94464", Offset = "0xD94464", VA = "0xD94464")]
		private int GetIntegralKey(double d)
		{
			return default(int);
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0xD94894", Offset = "0xD94894", VA = "0xD94894")]
		private Table ResolveMultipleKeys(object[] keys, out object key)
		{
			return null;
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0xD94AB4", Offset = "0xD94AB4", VA = "0xD94AB4")]
		public void Append(DynValue value)
		{
		}

		[Token(Token = "0x600011D")]
		private void PerformTableSet<T>(LinkedListIndex<T, TablePair> listIndex, T key, DynValue keyDynValue, DynValue value, bool isNumber, int appendKey)
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0xD94B90", Offset = "0xD94B90", VA = "0xD94B90")]
		public void Set(string key, DynValue value)
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0xD94CD0", Offset = "0xD94CD0", VA = "0xD94CD0")]
		public void Set(int key, DynValue value)
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0xD94204", Offset = "0xD94204", VA = "0xD94204")]
		public void Set(DynValue key, DynValue value)
		{
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0xD9476C", Offset = "0xD9476C", VA = "0xD9476C")]
		public void Set(object key, DynValue value)
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0xD945D0", Offset = "0xD945D0", VA = "0xD945D0")]
		public void Set(object[] keys, DynValue value)
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0xD94DEC", Offset = "0xD94DEC", VA = "0xD94DEC")]
		public DynValue Get(string key)
		{
			return null;
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0xD94E8C", Offset = "0xD94E8C", VA = "0xD94E8C")]
		public DynValue Get(int key)
		{
			return null;
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0xD94FBC", Offset = "0xD94FBC", VA = "0xD94FBC")]
		public DynValue Get(DynValue key)
		{
			return null;
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0xD9464C", Offset = "0xD9464C", VA = "0xD9464C")]
		public DynValue Get(object key)
		{
			return null;
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0xD944B0", Offset = "0xD944B0", VA = "0xD944B0")]
		public DynValue Get(params object[] keys)
		{
			return null;
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0xD951E0", Offset = "0xD951E0", VA = "0xD951E0")]
		private static DynValue RawGetValue(LinkedListNode<TablePair> linkedListNode)
		{
			return null;
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0xD8DBD0", Offset = "0xD8DBD0", VA = "0xD8DBD0")]
		public DynValue RawGet(string key)
		{
			return null;
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0xD94F2C", Offset = "0xD94F2C", VA = "0xD94F2C")]
		public DynValue RawGet(int key)
		{
			return null;
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0xD9505C", Offset = "0xD9505C", VA = "0xD9505C")]
		public DynValue RawGet(DynValue key)
		{
			return null;
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0xD949BC", Offset = "0xD949BC", VA = "0xD949BC")]
		public DynValue RawGet(object key)
		{
			return null;
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0xD951A4", Offset = "0xD951A4", VA = "0xD951A4")]
		public DynValue RawGet(params object[] keys)
		{
			return null;
		}

		[Token(Token = "0x600012E")]
		private bool PerformTableRemove<T>(LinkedListIndex<T, TablePair> listIndex, T key, bool isNumber)
		{
			return default(bool);
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0xD95228", Offset = "0xD95228", VA = "0xD95228")]
		public bool Remove(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0xD95288", Offset = "0xD95288", VA = "0xD95288")]
		public bool Remove(int key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0xD952E8", Offset = "0xD952E8", VA = "0xD952E8")]
		public bool Remove(DynValue key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0xD953FC", Offset = "0xD953FC", VA = "0xD953FC")]
		public bool Remove(object key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0xD954E4", Offset = "0xD954E4", VA = "0xD954E4")]
		public bool Remove(params object[] keys)
		{
			return default(bool);
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0xD95524", Offset = "0xD95524", VA = "0xD95524")]
		public void CollectDeadKeys()
		{
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0xD955D0", Offset = "0xD955D0", VA = "0xD955D0")]
		public TablePair? NextKey(DynValue v)
		{
			return null;
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0xD95834", Offset = "0xD95834", VA = "0xD95834")]
		private TablePair? GetNextOf(LinkedListNode<TablePair> linkedListNode)
		{
			return null;
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0xD95970", Offset = "0xD95970", VA = "0xD95970")]
		internal void InitNextArrayKeys(DynValue val, bool lastpos)
		{
		}
	}
	[Token(Token = "0x2000025")]
	public struct TablePair
	{
		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static TablePair s_NilNode;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private DynValue key;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private DynValue value;

		[Token(Token = "0x17000048")]
		public DynValue Key
		{
			[Token(Token = "0x6000143")]
			[Address(RVA = "0xD95DE4", Offset = "0xD95DE4", VA = "0xD95DE4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000144")]
			[Address(RVA = "0xD95DEC", Offset = "0xD95DEC", VA = "0xD95DEC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000049")]
		public DynValue Value
		{
			[Token(Token = "0x6000145")]
			[Address(RVA = "0xD95DF0", Offset = "0xD95DF0", VA = "0xD95DF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000146")]
			[Address(RVA = "0xD95DF8", Offset = "0xD95DF8", VA = "0xD95DF8")]
			set
			{
			}
		}

		[Token(Token = "0x1700004A")]
		public static TablePair Nil
		{
			[Token(Token = "0x6000148")]
			[Address(RVA = "0xD95E1C", Offset = "0xD95E1C", VA = "0xD95E1C")]
			get
			{
				return default(TablePair);
			}
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0xD95DCC", Offset = "0xD95DCC", VA = "0xD95DCC")]
		public TablePair(DynValue key, DynValue val)
		{
		}
	}
	[Token(Token = "0x2000026")]
	public class TailCallData
	{
		[Token(Token = "0x1700004B")]
		public DynValue Function
		{
			[Token(Token = "0x600014A")]
			[Address(RVA = "0xD95F5C", Offset = "0xD95F5C", VA = "0xD95F5C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600014B")]
			[Address(RVA = "0xD95F64", Offset = "0xD95F64", VA = "0xD95F64")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700004C")]
		public DynValue[] Args
		{
			[Token(Token = "0x600014C")]
			[Address(RVA = "0xD95F6C", Offset = "0xD95F6C", VA = "0xD95F6C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600014D")]
			[Address(RVA = "0xD95F74", Offset = "0xD95F74", VA = "0xD95F74")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700004D")]
		public CallbackFunction Continuation
		{
			[Token(Token = "0x600014E")]
			[Address(RVA = "0xD95F7C", Offset = "0xD95F7C", VA = "0xD95F7C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600014F")]
			[Address(RVA = "0xD95F84", Offset = "0xD95F84", VA = "0xD95F84")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700004E")]
		public CallbackFunction ErrorHandler
		{
			[Token(Token = "0x6000150")]
			[Address(RVA = "0xD95F8C", Offset = "0xD95F8C", VA = "0xD95F8C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000151")]
			[Address(RVA = "0xD95F94", Offset = "0xD95F94", VA = "0xD95F94")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700004F")]
		public DynValue ErrorHandlerBeforeUnwind
		{
			[Token(Token = "0x6000152")]
			[Address(RVA = "0xD95F9C", Offset = "0xD95F9C", VA = "0xD95F9C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000153")]
			[Address(RVA = "0xD95FA4", Offset = "0xD95FA4", VA = "0xD95FA4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0xD91954", Offset = "0xD91954", VA = "0xD91954")]
		public TailCallData()
		{
		}
	}
	[Token(Token = "0x2000027")]
	[Flags]
	public enum TypeValidationFlags
	{
		[Token(Token = "0x4000085")]
		None = 0,
		[Token(Token = "0x4000086")]
		AllowNil = 1,
		[Token(Token = "0x4000087")]
		AutoConvert = 2,
		[Token(Token = "0x4000088")]
		Default = 2
	}
	[Token(Token = "0x2000028")]
	public class UserData : RefIdObject
	{
		[Token(Token = "0x17000050")]
		public DynValue UserValue
		{
			[Token(Token = "0x6000156")]
			[Address(RVA = "0xD95FB0", Offset = "0xD95FB0", VA = "0xD95FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000157")]
			[Address(RVA = "0xD95FB8", Offset = "0xD95FB8", VA = "0xD95FB8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000051")]
		public object Object
		{
			[Token(Token = "0x6000158")]
			[Address(RVA = "0xD95FC0", Offset = "0xD95FC0", VA = "0xD95FC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000159")]
			[Address(RVA = "0xD95FC8", Offset = "0xD95FC8", VA = "0xD95FC8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000052")]
		public IUserDataDescriptor Descriptor
		{
			[Token(Token = "0x600015A")]
			[Address(RVA = "0xD95FD0", Offset = "0xD95FD0", VA = "0xD95FD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600015B")]
			[Address(RVA = "0xD95FD8", Offset = "0xD95FD8", VA = "0xD95FD8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000053")]
		public static IRegistrationPolicy RegistrationPolicy
		{
			[Token(Token = "0x600016E")]
			[Address(RVA = "0xD96880", Offset = "0xD96880", VA = "0xD96880")]
			get
			{
				return null;
			}
			[Token(Token = "0x600016F")]
			[Address(RVA = "0xD960B0", Offset = "0xD960B0", VA = "0xD960B0")]
			set
			{
			}
		}

		[Token(Token = "0x17000054")]
		public static InteropAccessMode DefaultAccessMode
		{
			[Token(Token = "0x6000170")]
			[Address(RVA = "0xD96908", Offset = "0xD96908", VA = "0xD96908")]
			get
			{
				return default(InteropAccessMode);
			}
			[Token(Token = "0x6000171")]
			[Address(RVA = "0xD9613C", Offset = "0xD9613C", VA = "0xD9613C")]
			set
			{
			}
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0xD95FAC", Offset = "0xD95FAC", VA = "0xD95FAC")]
		private UserData()
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0xD95FE0", Offset = "0xD95FE0", VA = "0xD95FE0")]
		static UserData()
		{
		}

		[Token(Token = "0x600015D")]
		public static IUserDataDescriptor RegisterType<T>(InteropAccessMode accessMode = InteropAccessMode.Default, [Optional] string friendlyName)
		{
			return null;
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0xD96194", Offset = "0xD96194", VA = "0xD96194")]
		public static IUserDataDescriptor RegisterType(Type type, InteropAccessMode accessMode = InteropAccessMode.Default, [Optional] string friendlyName)
		{
			return null;
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0xD96208", Offset = "0xD96208", VA = "0xD96208")]
		public static IUserDataDescriptor RegisterProxyType(IProxyFactory proxyFactory, InteropAccessMode accessMode = InteropAccessMode.Default, [Optional] string friendlyName)
		{
			return null;
		}

		[Token(Token = "0x6000160")]
		public static IUserDataDescriptor RegisterProxyType<TProxy, TTarget>(Func<TTarget, TProxy> wrapDelegate, InteropAccessMode accessMode = InteropAccessMode.Default, [Optional] string friendlyName) where TProxy : class where TTarget : class
		{
			return null;
		}

		[Token(Token = "0x6000161")]
		public static IUserDataDescriptor RegisterType<T>(IUserDataDescriptor customDescriptor)
		{
			return null;
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0xD96278", Offset = "0xD96278", VA = "0xD96278")]
		public static IUserDataDescriptor RegisterType(Type type, IUserDataDescriptor customDescriptor)
		{
			return null;
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0xD962E8", Offset = "0xD962E8", VA = "0xD962E8")]
		public static IUserDataDescriptor RegisterType(IUserDataDescriptor customDescriptor)
		{
			return null;
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0xD963CC", Offset = "0xD963CC", VA = "0xD963CC")]
		public static void RegisterAssembly([Optional] Assembly asm, bool includeExtensionTypes = false)
		{
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0xD9644C", Offset = "0xD9644C", VA = "0xD9644C")]
		public static bool IsTypeRegistered(Type t)
		{
			return default(bool);
		}

		[Token(Token = "0x6000166")]
		public static bool IsTypeRegistered<T>()
		{
			return default(bool);
		}

		[Token(Token = "0x6000167")]
		public static void UnregisterType<T>()
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0xD964A4", Offset = "0xD964A4", VA = "0xD964A4")]
		public static void UnregisterType(Type t)
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0xD964FC", Offset = "0xD964FC", VA = "0xD964FC")]
		public static DynValue Create(object o, IUserDataDescriptor descr)
		{
			return null;
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0xD9658C", Offset = "0xD9658C", VA = "0xD9658C")]
		public static DynValue Create(object o)
		{
			return null;
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0xD96780", Offset = "0xD96780", VA = "0xD96780")]
		public static DynValue CreateStatic(IUserDataDescriptor descr)
		{
			return null;
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0xD96724", Offset = "0xD96724", VA = "0xD96724")]
		public static DynValue CreateStatic(Type t)
		{
			return null;
		}

		[Token(Token = "0x600016D")]
		public static DynValue CreateStatic<T>()
		{
			return null;
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0xD96990", Offset = "0xD96990", VA = "0xD96990")]
		public static void RegisterExtensionType(Type type, InteropAccessMode mode = InteropAccessMode.Default)
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0xD969F8", Offset = "0xD969F8", VA = "0xD969F8")]
		public static List<IOverloadableMemberDescriptor> GetExtensionMethodsByNameAndType(string name, Type extendedType)
		{
			return null;
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0xD96A60", Offset = "0xD96A60", VA = "0xD96A60")]
		public static int GetExtensionMethodsChangeVersion()
		{
			return default(int);
		}

		[Token(Token = "0x6000175")]
		public static IUserDataDescriptor GetDescriptorForType<T>(bool searchInterfaces)
		{
			return null;
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0xD96818", Offset = "0xD96818", VA = "0xD96818")]
		public static IUserDataDescriptor GetDescriptorForType(Type type, bool searchInterfaces)
		{
			return null;
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0xD966AC", Offset = "0xD966AC", VA = "0xD966AC")]
		public static IUserDataDescriptor GetDescriptorForObject(object o)
		{
			return null;
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0xD96AE8", Offset = "0xD96AE8", VA = "0xD96AE8")]
		public static Table GetDescriptionOfRegisteredTypes(bool useHistoricalData = false)
		{
			return null;
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0xD96FA8", Offset = "0xD96FA8", VA = "0xD96FA8")]
		public static IEnumerable<Type> GetRegisteredTypes(bool useHistoricalData = false)
		{
			return null;
		}
	}
	[Token(Token = "0x200002A")]
	public static class WellKnownSymbols
	{
		[Token(Token = "0x400008E")]
		public const string VARARGS = "...";

		[Token(Token = "0x400008F")]
		public const string ENV = "_ENV";
	}
	[Token(Token = "0x200002B")]
	public class YieldRequest
	{
		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public DynValue[] ReturnValues;

		[Token(Token = "0x17000055")]
		public bool Forced
		{
			[Token(Token = "0x600017D")]
			[Address(RVA = "0xD971F4", Offset = "0xD971F4", VA = "0xD971F4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600017E")]
			[Address(RVA = "0xD971FC", Offset = "0xD971FC", VA = "0xD971FC")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0xD91A5C", Offset = "0xD91A5C", VA = "0xD91A5C")]
		public YieldRequest()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002C")]
	public class DynamicExpressionException : ScriptRuntimeException
	{
		[Token(Token = "0x6000180")]
		[Address(RVA = "0xD97208", Offset = "0xD97208", VA = "0xD97208")]
		public DynamicExpressionException(string format, params object[] args)
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0xD97274", Offset = "0xD97274", VA = "0xD97274")]
		public DynamicExpressionException(string message)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002D")]
	public class InternalErrorException : InterpreterException
	{
		[Token(Token = "0x6000182")]
		[Address(RVA = "0xD972D8", Offset = "0xD972D8", VA = "0xD972D8")]
		internal InternalErrorException(string message)
		{
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0xD937D8", Offset = "0xD937D8", VA = "0xD937D8")]
		internal InternalErrorException(string format, params object[] args)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002E")]
	public class InterpreterException : Exception
	{
		[Token(Token = "0x17000056")]
		public int InstructionPtr
		{
			[Token(Token = "0x6000188")]
			[Address(RVA = "0xD974B4", Offset = "0xD974B4", VA = "0xD974B4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000189")]
			[Address(RVA = "0xD974BC", Offset = "0xD974BC", VA = "0xD974BC")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Token(Token = "0x17000057")]
		public IList<WatchItem> CallStack
		{
			[Token(Token = "0x600018A")]
			[Address(RVA = "0xD974C4", Offset = "0xD974C4", VA = "0xD974C4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600018B")]
			[Address(RVA = "0xD974CC", Offset = "0xD974CC", VA = "0xD974CC")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Token(Token = "0x17000058")]
		public string DecoratedMessage
		{
			[Token(Token = "0x600018C")]
			[Address(RVA = "0xD974D4", Offset = "0xD974D4", VA = "0xD974D4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600018D")]
			[Address(RVA = "0xD974DC", Offset = "0xD974DC", VA = "0xD974DC")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Token(Token = "0x17000059")]
		public bool DoNotDecorateMessage
		{
			[Token(Token = "0x600018E")]
			[Address(RVA = "0xD974E4", Offset = "0xD974E4", VA = "0xD974E4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600018F")]
			[Address(RVA = "0xD974EC", Offset = "0xD974EC", VA = "0xD974EC")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0xD973C8", Offset = "0xD973C8", VA = "0xD973C8")]
		protected InterpreterException(Exception ex, string message)
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0xD97438", Offset = "0xD97438", VA = "0xD97438")]
		protected InterpreterException(Exception ex)
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0xD972DC", Offset = "0xD972DC", VA = "0xD972DC")]
		protected InterpreterException(string message)
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0xD97344", Offset = "0xD97344", VA = "0xD97344")]
		protected InterpreterException(string format, params object[] args)
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0xD974F8", Offset = "0xD974F8", VA = "0xD974F8")]
		internal void DecorateMessage(Script script, SourceRef sref, int ip = -1)
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0xD9761C", Offset = "0xD9761C", VA = "0xD9761C", Slot = "13")]
		public virtual void Rethrow()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002F")]
	public class ScriptRuntimeException : InterpreterException
	{
		[Token(Token = "0x6000192")]
		[Address(RVA = "0xD97620", Offset = "0xD97620", VA = "0xD97620")]
		public ScriptRuntimeException(Exception ex)
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0xD97624", Offset = "0xD97624", VA = "0xD97624")]
		public ScriptRuntimeException(ScriptRuntimeException ex)
		{
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0xD93364", Offset = "0xD93364", VA = "0xD93364")]
		public ScriptRuntimeException(string message)
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0xD8DF28", Offset = "0xD8DF28", VA = "0xD8DF28")]
		public ScriptRuntimeException(string format, params object[] args)
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0xD97660", Offset = "0xD97660", VA = "0xD97660")]
		public static ScriptRuntimeException ArithmeticOnNonNumber(DynValue l, [Optional] DynValue r)
		{
			return null;
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0xD9781C", Offset = "0xD9781C", VA = "0xD9781C")]
		public static ScriptRuntimeException ConcatOnNonString(DynValue l, DynValue r)
		{
			return null;
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0xD9798C", Offset = "0xD9798C", VA = "0xD9798C")]
		public static ScriptRuntimeException LenOnInvalidType(DynValue r)
		{
			return null;
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0xD97A70", Offset = "0xD97A70", VA = "0xD97A70")]
		public static ScriptRuntimeException CompareInvalidType(DynValue l, DynValue r)
		{
			return null;
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0xD97C38", Offset = "0xD97C38", VA = "0xD97C38")]
		public static ScriptRuntimeException BadArgument(int argNum, string funcName, string message)
		{
			return null;
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0xD97DA0", Offset = "0xD97DA0", VA = "0xD97DA0")]
		public static ScriptRuntimeException BadArgumentUserData(int argNum, string funcName, Type expected, object got, bool allowNil)
		{
			return null;
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0xD93960", Offset = "0xD93960", VA = "0xD93960")]
		public static ScriptRuntimeException BadArgument(int argNum, string funcName, DataType expected, DataType got, bool allowNil)
		{
			return null;
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0xD9803C", Offset = "0xD9803C", VA = "0xD9803C")]
		public static ScriptRuntimeException BadArgument(int argNum, string funcName, string expected, string got, bool allowNil)
		{
			return null;
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0xD937EC", Offset = "0xD937EC", VA = "0xD937EC")]
		public static ScriptRuntimeException BadArgumentNoValue(int argNum, string funcName, DataType expected)
		{
			return null;
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0xD9823C", Offset = "0xD9823C", VA = "0xD9823C")]
		public static ScriptRuntimeException BadArgumentIndexOutOfRange(string funcName, int argNum)
		{
			return null;
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0xD98378", Offset = "0xD98378", VA = "0xD98378")]
		public static ScriptRuntimeException BadArgumentNoNegativeNumbers(int argNum, string funcName)
		{
			return null;
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0xD984B4", Offset = "0xD984B4", VA = "0xD984B4")]
		public static ScriptRuntimeException BadArgumentValueExpected(int argNum, string funcName)
		{
			return null;
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0xD985F0", Offset = "0xD985F0", VA = "0xD985F0")]
		public static ScriptRuntimeException IndexType(DynValue obj)
		{
			return null;
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0xD986D4", Offset = "0xD986D4", VA = "0xD986D4")]
		public static ScriptRuntimeException LoopInIndex()
		{
			return null;
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0xD98744", Offset = "0xD98744", VA = "0xD98744")]
		public static ScriptRuntimeException LoopInNewIndex()
		{
			return null;
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0xD987B4", Offset = "0xD987B4", VA = "0xD987B4")]
		public static ScriptRuntimeException LoopInCall()
		{
			return null;
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0xD94C60", Offset = "0xD94C60", VA = "0xD94C60")]
		public static ScriptRuntimeException TableIndexIsNil()
		{
			return null;
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0xD94D7C", Offset = "0xD94D7C", VA = "0xD94D7C")]
		public static ScriptRuntimeException TableIndexIsNaN()
		{
			return null;
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0xD98824", Offset = "0xD98824", VA = "0xD98824")]
		public static ScriptRuntimeException ConvertToNumberFailed(int stage)
		{
			return null;
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0xD98920", Offset = "0xD98920", VA = "0xD98920")]
		public static ScriptRuntimeException ConvertObjectFailed(object obj)
		{
			return null;
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0xD98A08", Offset = "0xD98A08", VA = "0xD98A08")]
		public static ScriptRuntimeException ConvertObjectFailed(DataType t)
		{
			return null;
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0xD98B2C", Offset = "0xD98B2C", VA = "0xD98B2C")]
		public static ScriptRuntimeException ConvertObjectFailed(DataType t, Type t2)
		{
			return null;
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0xD98C98", Offset = "0xD98C98", VA = "0xD98C98")]
		public static ScriptRuntimeException UserDataArgumentTypeMismatch(DataType t, Type clrType)
		{
			return null;
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0xD98E04", Offset = "0xD98E04", VA = "0xD98E04")]
		public static ScriptRuntimeException UserDataMissingField(string typename, string fieldname)
		{
			return null;
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0xD8F888", Offset = "0xD8F888", VA = "0xD8F888")]
		public static ScriptRuntimeException CannotResumeNotSuspended(CoroutineState state)
		{
			return null;
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0xD98F0C", Offset = "0xD98F0C", VA = "0xD98F0C")]
		public static ScriptRuntimeException CannotYield()
		{
			return null;
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0xD98F7C", Offset = "0xD98F7C", VA = "0xD98F7C")]
		public static ScriptRuntimeException CannotYieldMain()
		{
			return null;
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0xD98FEC", Offset = "0xD98FEC", VA = "0xD98FEC")]
		public static ScriptRuntimeException AttemptToCallNonFunc(DataType type, [Optional] string debugText)
		{
			return null;
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0xD99164", Offset = "0xD99164", VA = "0xD99164")]
		public static ScriptRuntimeException AccessInstanceMemberOnStatics(IMemberDescriptor desc)
		{
			return null;
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0xD992B0", Offset = "0xD992B0", VA = "0xD992B0")]
		public static ScriptRuntimeException AccessInstanceMemberOnStatics(IUserDataDescriptor typeDescr, IMemberDescriptor desc)
		{
			return null;
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0xD994A4", Offset = "0xD994A4", VA = "0xD994A4", Slot = "13")]
		public override void Rethrow()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000030")]
	public class SyntaxErrorException : InterpreterException
	{
		[Token(Token = "0x1700005A")]
		internal Token Token
		{
			[Token(Token = "0x60001B5")]
			[Address(RVA = "0xD9957C", Offset = "0xD9957C", VA = "0xD9957C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001B6")]
			[Address(RVA = "0xD99584", Offset = "0xD99584", VA = "0xD99584")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700005B")]
		public bool IsPrematureStreamTermination
		{
			[Token(Token = "0x60001B7")]
			[Address(RVA = "0xD9958C", Offset = "0xD9958C", VA = "0xD9958C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001B8")]
			[Address(RVA = "0xD99594", Offset = "0xD99594", VA = "0xD99594")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0xD995A0", Offset = "0xD995A0", VA = "0xD995A0")]
		internal SyntaxErrorException(Token t, string format, params object[] args)
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0xD995CC", Offset = "0xD995CC", VA = "0xD995CC")]
		internal SyntaxErrorException(Token t, string message)
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0xD995F4", Offset = "0xD995F4", VA = "0xD995F4")]
		internal SyntaxErrorException(Script script, SourceRef sref, string format, params object[] args)
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0xD99630", Offset = "0xD99630", VA = "0xD99630")]
		internal SyntaxErrorException(Script script, SourceRef sref, string message)
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0xD99668", Offset = "0xD99668", VA = "0xD99668")]
		private SyntaxErrorException(SyntaxErrorException syntaxErrorException)
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0xD996B0", Offset = "0xD996B0", VA = "0xD996B0")]
		internal void DecorateMessage(Script script)
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0xD99790", Offset = "0xD99790", VA = "0xD99790", Slot = "13")]
		public override void Rethrow()
		{
		}
	}
	[Token(Token = "0x2000031")]
	public class DynamicExpression : IScriptPrivateResource
	{
		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private DynamicExprExpression m_Exp;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private DynValue m_Constant;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly string ExpressionCode;

		[Token(Token = "0x1700005C")]
		public Script OwnerScript
		{
			[Token(Token = "0x60001C4")]
			[Address(RVA = "0xD99A2C", Offset = "0xD99A2C", VA = "0xD99A2C", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001C5")]
			[Address(RVA = "0xD99A34", Offset = "0xD99A34", VA = "0xD99A34")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0xD99868", Offset = "0xD99868", VA = "0xD99868")]
		internal DynamicExpression(Script S, string strExpr, DynamicExprExpression expr)
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0xD998A4", Offset = "0xD998A4", VA = "0xD998A4")]
		internal DynamicExpression(Script S, string strExpr, DynValue constant)
		{
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0xD998E0", Offset = "0xD998E0", VA = "0xD998E0")]
		public DynValue Evaluate([Optional] ScriptExecutionContext context)
		{
			return null;
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0xD999D8", Offset = "0xD999D8", VA = "0xD999D8")]
		public SymbolRef FindSymbol(ScriptExecutionContext context)
		{
			return null;
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0xD99A3C", Offset = "0xD99A3C", VA = "0xD99A3C")]
		public bool IsConstant()
		{
			return default(bool);
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0xD99A4C", Offset = "0xD99A4C", VA = "0xD99A4C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0xD99A6C", Offset = "0xD99A6C", VA = "0xD99A6C", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000032")]
	public class ScriptExecutionContext : IScriptPrivateResource
	{
		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Processor m_Processor;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CallbackFunction m_Callback;

		[Token(Token = "0x1700005D")]
		public bool IsDynamicExecution
		{
			[Token(Token = "0x60001CA")]
			[Address(RVA = "0xD99B50", Offset = "0xD99B50", VA = "0xD99B50")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001CB")]
			[Address(RVA = "0xD99B58", Offset = "0xD99B58", VA = "0xD99B58")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700005E")]
		public SourceRef CallingLocation
		{
			[Token(Token = "0x60001CC")]
			[Address(RVA = "0xD99B64", Offset = "0xD99B64", VA = "0xD99B64")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001CD")]
			[Address(RVA = "0xD99B6C", Offset = "0xD99B6C", VA = "0xD99B6C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700005F")]
		public object AdditionalData
		{
			[Token(Token = "0x60001CE")]
			[Address(RVA = "0xD99B74", Offset = "0xD99B74", VA = "0xD99B74")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001CF")]
			[Address(RVA = "0xD99B8C", Offset = "0xD99B8C", VA = "0xD99B8C")]
			set
			{
			}
		}

		[Token(Token = "0x17000060")]
		public Table CurrentGlobalEnv
		{
			[Token(Token = "0x60001DB")]
			[Address(RVA = "0xD9A050", Offset = "0xD9A050", VA = "0xD9A050")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000061")]
		public Script OwnerScript
		{
			[Token(Token = "0x60001DD")]
			[Address(RVA = "0xD9A13C", Offset = "0xD9A13C", VA = "0xD9A13C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0xD99B08", Offset = "0xD99B08", VA = "0xD99B08")]
		internal ScriptExecutionContext(Processor p, CallbackFunction callBackFunction, SourceRef sourceRef, bool isDynamic = false)
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0xD99BF0", Offset = "0xD99BF0", VA = "0xD99BF0")]
		public Table GetMetatable(DynValue value)
		{
			return null;
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0xD99C0C", Offset = "0xD99C0C", VA = "0xD99C0C")]
		public DynValue GetMetamethod(DynValue value, string metamethod)
		{
			return null;
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0xD99C28", Offset = "0xD99C28", VA = "0xD99C28")]
		public DynValue GetMetamethodTailCall(DynValue value, string metamethod, params DynValue[] args)
		{
			return null;
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0xD99CC8", Offset = "0xD99CC8", VA = "0xD99CC8")]
		public DynValue GetBinaryMetamethod(DynValue op1, DynValue op2, string eventName)
		{
			return null;
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0xD8DC60", Offset = "0xD8DC60", VA = "0xD8DC60")]
		public Script GetScript()
		{
			return null;
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0xD99CE4", Offset = "0xD99CE4", VA = "0xD99CE4")]
		public Coroutine GetCallingCoroutine()
		{
			return null;
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0xD99D00", Offset = "0xD99D00", VA = "0xD99D00")]
		public DynValue EmulateClassicCall(CallbackArguments args, string functionName, Func<LuaState, int> callback)
		{
			return null;
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0xD99DA8", Offset = "0xD99DA8", VA = "0xD99DA8")]
		public DynValue Call(DynValue func, params DynValue[] args)
		{
			return null;
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0xD99F54", Offset = "0xD99F54", VA = "0xD99F54")]
		public DynValue EvaluateSymbol(SymbolRef symref)
		{
			return null;
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0xD9A008", Offset = "0xD9A008", VA = "0xD9A008")]
		public DynValue EvaluateSymbolByName(string symbol)
		{
			return null;
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0xD9A034", Offset = "0xD9A034", VA = "0xD9A034")]
		public SymbolRef FindSymbolByName(string symbol)
		{
			return null;
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0xD9A0BC", Offset = "0xD9A0BC", VA = "0xD9A0BC")]
		public void PerformMessageDecorationBeforeUnwind(DynValue messageHandler, ScriptRuntimeException exception)
		{
		}
	}
	[Token(Token = "0x2000033")]
	[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event, Inherited = true, AllowMultiple = false)]
	public sealed class MoonSharpHiddenAttribute : Attribute
	{
		[Token(Token = "0x60001DE")]
		[Address(RVA = "0xD9A158", Offset = "0xD9A158", VA = "0xD9A158")]
		public MoonSharpHiddenAttribute()
		{
		}
	}
	[Token(Token = "0x2000034")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, Inherited = true, AllowMultiple = true)]
	public sealed class MoonSharpHideMemberAttribute : Attribute
	{
		[Token(Token = "0x17000062")]
		public string MemberName
		{
			[Token(Token = "0x60001DF")]
			[Address(RVA = "0xD9A160", Offset = "0xD9A160", VA = "0xD9A160")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001E0")]
			[Address(RVA = "0xD9A168", Offset = "0xD9A168", VA = "0xD9A168")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0xD9A170", Offset = "0xD9A170", VA = "0xD9A170")]
		public MoonSharpHideMemberAttribute(string memberName)
		{
		}
	}
	[Token(Token = "0x2000035")]
	[AttributeUsage(AttributeTargets.Property, Inherited = true, AllowMultiple = true)]
	public sealed class MoonSharpPropertyAttribute : Attribute
	{
		[Token(Token = "0x17000063")]
		public string Name
		{
			[Token(Token = "0x60001E2")]
			[Address(RVA = "0xD9A198", Offset = "0xD9A198", VA = "0xD9A198")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001E3")]
			[Address(RVA = "0xD9A1A0", Offset = "0xD9A1A0", VA = "0xD9A1A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0xD9A1A8", Offset = "0xD9A1A8", VA = "0xD9A1A8")]
		public MoonSharpPropertyAttribute()
		{
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0xD9A1B0", Offset = "0xD9A1B0", VA = "0xD9A1B0")]
		public MoonSharpPropertyAttribute(string name)
		{
		}
	}
	[Token(Token = "0x2000036")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, Inherited = false, AllowMultiple = false)]
	public sealed class MoonSharpUserDataAttribute : Attribute
	{
		[Token(Token = "0x17000064")]
		public InteropAccessMode AccessMode
		{
			[Token(Token = "0x60001E6")]
			[Address(RVA = "0xD9A1D8", Offset = "0xD9A1D8", VA = "0xD9A1D8")]
			[CompilerGenerated]
			get
			{
				return default(InteropAccessMode);
			}
			[Token(Token = "0x60001E7")]
			[Address(RVA = "0xD9A1E0", Offset = "0xD9A1E0", VA = "0xD9A1E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0xD9A1E8", Offset = "0xD9A1E8", VA = "0xD9A1E8")]
		public MoonSharpUserDataAttribute()
		{
		}
	}
	[Token(Token = "0x2000037")]
	[AttributeUsage(AttributeTargets.Method, Inherited = true, AllowMultiple = true)]
	public sealed class MoonSharpUserDataMetamethodAttribute : Attribute
	{
		[Token(Token = "0x17000065")]
		public string Name
		{
			[Token(Token = "0x60001E9")]
			[Address(RVA = "0xD9A208", Offset = "0xD9A208", VA = "0xD9A208")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001EA")]
			[Address(RVA = "0xD9A210", Offset = "0xD9A210", VA = "0xD9A210")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0xD9A218", Offset = "0xD9A218", VA = "0xD9A218")]
		public MoonSharpUserDataMetamethodAttribute(string name)
		{
		}
	}
	[Token(Token = "0x2000038")]
	public enum InteropAccessMode
	{
		[Token(Token = "0x40000A5")]
		Reflection,
		[Token(Token = "0x40000A6")]
		LazyOptimized,
		[Token(Token = "0x40000A7")]
		Preoptimized,
		[Token(Token = "0x40000A8")]
		BackgroundOptimized,
		[Token(Token = "0x40000A9")]
		Hardwired,
		[Token(Token = "0x40000AA")]
		HideMembers,
		[Token(Token = "0x40000AB")]
		NoReflectionAllowed,
		[Token(Token = "0x40000AC")]
		Default
	}
	[Token(Token = "0x2000039")]
	internal class AutoDescribingUserDataDescriptor : IUserDataDescriptor
	{
		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string m_FriendlyName;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Type m_Type;

		[Token(Token = "0x17000066")]
		public string Name
		{
			[Token(Token = "0x60001ED")]
			[Address(RVA = "0xD9A26C", Offset = "0xD9A26C", VA = "0xD9A26C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000067")]
		public Type Type
		{
			[Token(Token = "0x60001EE")]
			[Address(RVA = "0xD9A274", Offset = "0xD9A274", VA = "0xD9A274", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0xD9A240", Offset = "0xD9A240", VA = "0xD9A240")]
		public AutoDescribingUserDataDescriptor(Type type, string friendlyName)
		{
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0xD9A27C", Offset = "0xD9A27C", VA = "0xD9A27C", Slot = "6")]
		public DynValue Index(Script script, object obj, DynValue index, bool isDirectIndexing)
		{
			return null;
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0xD9A360", Offset = "0xD9A360", VA = "0xD9A360", Slot = "7")]
		public bool SetIndex(Script script, object obj, DynValue index, DynValue value, bool isDirectIndexing)
		{
			return default(bool);
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0xD9A450", Offset = "0xD9A450", VA = "0xD9A450", Slot = "8")]
		public string AsString(object obj)
		{
			return null;
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0xD9A470", Offset = "0xD9A470", VA = "0xD9A470", Slot = "9")]
		public DynValue MetaIndex(Script script, object obj, string metaname)
		{
			return null;
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0xD9A544", Offset = "0xD9A544", VA = "0xD9A544", Slot = "10")]
		public bool IsTypeCompatible(Type type, object obj)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200003A")]
	public static class LinqHelpers
	{
		[Token(Token = "0x60001F4")]
		public static IEnumerable<T> Convert<T>(this IEnumerable<DynValue> enumerable, DataType type)
		{
			return null;
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0xD9A5F8", Offset = "0xD9A5F8", VA = "0xD9A5F8")]
		public static IEnumerable<DynValue> OfDataType(this IEnumerable<DynValue> enumerable, DataType type)
		{
			return null;
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0xD9A6D4", Offset = "0xD9A6D4", VA = "0xD9A6D4")]
		public static IEnumerable<object> AsObjects(this IEnumerable<DynValue> enumerable)
		{
			return null;
		}

		[Token(Token = "0x60001F7")]
		public static IEnumerable<T> AsObjects<T>(this IEnumerable<DynValue> enumerable)
		{
			return null;
		}
	}
	[Token(Token = "0x2000040")]
	[Flags]
	public enum CoreModules
	{
		[Token(Token = "0x40000B8")]
		None = 0,
		[Token(Token = "0x40000B9")]
		Basic = 0x40,
		[Token(Token = "0x40000BA")]
		GlobalConsts = 1,
		[Token(Token = "0x40000BB")]
		TableIterators = 2,
		[Token(Token = "0x40000BC")]
		Metatables = 4,
		[Token(Token = "0x40000BD")]
		String = 8,
		[Token(Token = "0x40000BE")]
		LoadMethods = 0x10,
		[Token(Token = "0x40000BF")]
		Table = 0x20,
		[Token(Token = "0x40000C0")]
		ErrorHandling = 0x80,
		[Token(Token = "0x40000C1")]
		Math = 0x100,
		[Token(Token = "0x40000C2")]
		Coroutine = 0x200,
		[Token(Token = "0x40000C3")]
		Bit32 = 0x400,
		[Token(Token = "0x40000C4")]
		OS_Time = 0x800,
		[Token(Token = "0x40000C5")]
		OS_System = 0x1000,
		[Token(Token = "0x40000C6")]
		IO = 0x2000,
		[Token(Token = "0x40000C7")]
		Debug = 0x4000,
		[Token(Token = "0x40000C8")]
		Dynamic = 0x8000,
		[Token(Token = "0x40000C9")]
		Json = 0x10000,
		[Token(Token = "0x40000CA")]
		Preset_HardSandbox = 0x56B,
		[Token(Token = "0x40000CB")]
		Preset_SoftSandbox = 0x18FEF,
		[Token(Token = "0x40000CC")]
		Preset_Default = 0x1BFFF,
		[Token(Token = "0x40000CD")]
		Preset_Complete = 0x1FFFF
	}
	[Token(Token = "0x2000041")]
	internal static class CoreModules_ExtensionMethods
	{
		[Token(Token = "0x6000205")]
		[Address(RVA = "0xD9A874", Offset = "0xD9A874", VA = "0xD9A874")]
		public static bool Has(this CoreModules val, CoreModules flag)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000042")]
	public static class ModuleRegister
	{
		[Token(Token = "0x6000206")]
		[Address(RVA = "0xD9A880", Offset = "0xD9A880", VA = "0xD9A880")]
		public static Table RegisterCoreModules(this Table table, CoreModules modules)
		{
			return null;
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0xD9AC50", Offset = "0xD9AC50", VA = "0xD9AC50")]
		public static Table RegisterConstants(this Table table)
		{
			return null;
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0xD9B390", Offset = "0xD9B390", VA = "0xD9B390")]
		public static Table RegisterModuleType(this Table gtable, Type t)
		{
			return null;
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0xD9CA50", Offset = "0xD9CA50", VA = "0xD9CA50")]
		private static void RegisterScriptFieldAsConst(FieldInfo fi, object o, Table table, Type t, string name)
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0xD9C8BC", Offset = "0xD9C8BC", VA = "0xD9C8BC")]
		private static void RegisterScriptField(FieldInfo fi, object o, Table table, Type t, string name)
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0xD9C578", Offset = "0xD9C578", VA = "0xD9C578")]
		private static Table CreateModuleNamespace(Table gtable, Type t)
		{
			return null;
		}

		[Token(Token = "0x600020C")]
		public static Table RegisterModuleType<T>(this Table table)
		{
			return null;
		}
	}
	[Token(Token = "0x2000044")]
	[AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
	public sealed class MoonSharpModuleAttribute : Attribute
	{
		[Token(Token = "0x17000068")]
		public string Namespace
		{
			[Token(Token = "0x6000212")]
			[Address(RVA = "0xD9D0E4", Offset = "0xD9D0E4", VA = "0xD9D0E4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000213")]
			[Address(RVA = "0xD9D0EC", Offset = "0xD9D0EC", VA = "0xD9D0EC")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0xD9D0F4", Offset = "0xD9D0F4", VA = "0xD9D0F4")]
		public MoonSharpModuleAttribute()
		{
		}
	}
	[Token(Token = "0x2000045")]
	[AttributeUsage(AttributeTargets.Field, Inherited = false, AllowMultiple = false)]
	public sealed class MoonSharpModuleConstantAttribute : Attribute
	{
		[Token(Token = "0x17000069")]
		public string Name
		{
			[Token(Token = "0x6000215")]
			[Address(RVA = "0xD9D0FC", Offset = "0xD9D0FC", VA = "0xD9D0FC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000216")]
			[Address(RVA = "0xD9D104", Offset = "0xD9D104", VA = "0xD9D104")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0xD9D10C", Offset = "0xD9D10C", VA = "0xD9D10C")]
		public MoonSharpModuleConstantAttribute()
		{
		}
	}
	[Token(Token = "0x2000046")]
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Field, Inherited = false, AllowMultiple = false)]
	public sealed class MoonSharpModuleMethodAttribute : Attribute
	{
		[Token(Token = "0x1700006A")]
		public string Name
		{
			[Token(Token = "0x6000218")]
			[Address(RVA = "0xD9D114", Offset = "0xD9D114", VA = "0xD9D114")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000219")]
			[Address(RVA = "0xD9D11C", Offset = "0xD9D11C", VA = "0xD9D11C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0xD9D124", Offset = "0xD9D124", VA = "0xD9D124")]
		public MoonSharpModuleMethodAttribute()
		{
		}
	}
	[Token(Token = "0x2000047")]
	internal static class NamespaceDoc
	{
	}
	[Token(Token = "0x2000048")]
	public enum ColonOperatorBehaviour
	{
		[Token(Token = "0x40000D6")]
		TreatAsDot,
		[Token(Token = "0x40000D7")]
		TreatAsDotOnUserData,
		[Token(Token = "0x40000D8")]
		TreatAsColon
	}
	[Token(Token = "0x2000049")]
	public class Script : IScriptPrivateResource
	{
		[Token(Token = "0x40000D9")]
		public const string VERSION = "2.0.0.0";

		[Token(Token = "0x40000DA")]
		public const string LUA_VERSION = "5.2";

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Processor m_MainProcessor;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private ByteCode m_ByteCode;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<SourceCode> m_Sources;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Table m_GlobalTable;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private IDebugger m_Debugger;

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Table[] m_TypeMetatables;

		[Token(Token = "0x1700006B")]
		public static ScriptOptions DefaultOptions
		{
			[Token(Token = "0x600021E")]
			[Address(RVA = "0xD9D65C", Offset = "0xD9D65C", VA = "0xD9D65C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600021F")]
			[Address(RVA = "0xD9D6B4", Offset = "0xD9D6B4", VA = "0xD9D6B4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700006C")]
		public ScriptOptions Options
		{
			[Token(Token = "0x6000220")]
			[Address(RVA = "0xD9D710", Offset = "0xD9D710", VA = "0xD9D710")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000221")]
			[Address(RVA = "0xD9D718", Offset = "0xD9D718", VA = "0xD9D718")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700006D")]
		public static ScriptGlobalOptions GlobalOptions
		{
			[Token(Token = "0x6000222")]
			[Address(RVA = "0xD9D720", Offset = "0xD9D720", VA = "0xD9D720")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000223")]
			[Address(RVA = "0xD9D778", Offset = "0xD9D778", VA = "0xD9D778")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700006E")]
		public PerformanceStatistics PerformanceStats
		{
			[Token(Token = "0x6000224")]
			[Address(RVA = "0xD9D7D4", Offset = "0xD9D7D4", VA = "0xD9D7D4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000225")]
			[Address(RVA = "0xD9D7DC", Offset = "0xD9D7DC", VA = "0xD9D7DC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700006F")]
		public Table Globals
		{
			[Token(Token = "0x6000226")]
			[Address(RVA = "0xD9D7E4", Offset = "0xD9D7E4", VA = "0xD9D7E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000070")]
		public bool DebuggerEnabled
		{
			[Token(Token = "0x600023B")]
			[Address(RVA = "0xD9F1A8", Offset = "0xD9F1A8", VA = "0xD9F1A8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600023C")]
			[Address(RVA = "0xD9F1C4", Offset = "0xD9F1C4", VA = "0xD9F1C4")]
			set
			{
			}
		}

		[Token(Token = "0x17000071")]
		public int SourceCodeCount
		{
			[Token(Token = "0x600023F")]
			[Address(RVA = "0xD9F3B4", Offset = "0xD9F3B4", VA = "0xD9F3B4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000072")]
		public Table Registry
		{
			[Token(Token = "0x6000247")]
			[Address(RVA = "0xD9F89C", Offset = "0xD9F89C", VA = "0xD9F89C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000248")]
			[Address(RVA = "0xD9F8A4", Offset = "0xD9F8A4", VA = "0xD9F8A4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000073")]
		private Script MoonSharp.Interpreter.IScriptPrivateResource.OwnerScript
		{
			[Token(Token = "0x600024A")]
			[Address(RVA = "0xD9F8AC", Offset = "0xD9F8AC", VA = "0xD9F8AC", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0xD9D12C", Offset = "0xD9D12C", VA = "0xD9D12C")]
		static Script()
		{
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0xD9D3A8", Offset = "0xD9D3A8", VA = "0xD9D3A8")]
		public Script()
		{
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0xD9D3B4", Offset = "0xD9D3B4", VA = "0xD9D3B4")]
		public Script(CoreModules coreModules)
		{
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0xD9CCDC", Offset = "0xD9CCDC", VA = "0xD9CCDC")]
		public DynValue LoadFunction(string code, [Optional] Table globalTable, [Optional] string funcFriendlyName)
		{
			return null;
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0xD9D8A0", Offset = "0xD9D8A0", VA = "0xD9D8A0")]
		private void SignalByteCodeChange()
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0xD9D7EC", Offset = "0xD9D7EC", VA = "0xD9D7EC")]
		private void SignalSourceCodeChange(SourceCode source)
		{
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0xD9DD70", Offset = "0xD9DD70", VA = "0xD9DD70")]
		public DynValue LoadString(string code, [Optional] Table globalTable, [Optional] string codeFriendlyName)
		{
			return null;
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0xD9E15C", Offset = "0xD9E15C", VA = "0xD9E15C")]
		public DynValue LoadStream(Stream stream, [Optional] Table globalTable, [Optional] string codeFriendlyName)
		{
			return null;
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0xD9E5A8", Offset = "0xD9E5A8", VA = "0xD9E5A8")]
		public void Dump(DynValue function, Stream stream)
		{
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0xD9E728", Offset = "0xD9E728", VA = "0xD9E728")]
		public DynValue LoadFile(string filename, [Optional] Table globalContext, [Optional] string friendlyFilename)
		{
			return null;
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0xD9ECE4", Offset = "0xD9ECE4", VA = "0xD9ECE4")]
		public DynValue DoString(string code, [Optional] Table globalContext, [Optional] string codeFriendlyName)
		{
			return null;
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0xD9ED64", Offset = "0xD9ED64", VA = "0xD9ED64")]
		public DynValue DoStream(Stream stream, [Optional] Table globalContext, [Optional] string codeFriendlyName)
		{
			return null;
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0xD9ED80", Offset = "0xD9ED80", VA = "0xD9ED80")]
		public DynValue DoFile(string filename, [Optional] Table globalContext, [Optional] string codeFriendlyName)
		{
			return null;
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0xD9ED9C", Offset = "0xD9ED9C", VA = "0xD9ED9C")]
		public static DynValue RunFile(string filename)
		{
			return null;
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0xD9EE18", Offset = "0xD9EE18", VA = "0xD9EE18")]
		public static DynValue RunString(string code)
		{
			return null;
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0xD9DA50", Offset = "0xD9DA50", VA = "0xD9DA50")]
		private DynValue MakeClosure(int address, [Optional] Table envTable)
		{
			return null;
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0xD9ED00", Offset = "0xD9ED00", VA = "0xD9ED00")]
		public DynValue Call(DynValue function)
		{
			return null;
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0xD8DC7C", Offset = "0xD8DC7C", VA = "0xD8DC7C")]
		public DynValue Call(DynValue function, params DynValue[] args)
		{
			return null;
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0xD9EE94", Offset = "0xD9EE94", VA = "0xD9EE94")]
		public DynValue Call(DynValue function, params object[] args)
		{
			return null;
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0xD8EC5C", Offset = "0xD8EC5C", VA = "0xD8EC5C")]
		public DynValue Call(object function)
		{
			return null;
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0xD8ECF4", Offset = "0xD8ECF4", VA = "0xD8ECF4")]
		public DynValue Call(object function, params object[] args)
		{
			return null;
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0xD9EFC0", Offset = "0xD9EFC0", VA = "0xD9EFC0")]
		public DynValue CreateCoroutine(DynValue function)
		{
			return null;
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0xD9F134", Offset = "0xD9F134", VA = "0xD9F134")]
		public DynValue CreateCoroutine(object function)
		{
			return null;
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0xD9F1E4", Offset = "0xD9F1E4", VA = "0xD9F1E4")]
		public void AttachDebugger(IDebugger debugger)
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0xD9F35C", Offset = "0xD9F35C", VA = "0xD9F35C")]
		public SourceCode GetSourceCode(int sourceCodeID)
		{
			return null;
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0xD9F3FC", Offset = "0xD9F3FC", VA = "0xD9F3FC")]
		public DynValue RequireModule(string modname, [Optional] Table globalContext)
		{
			return null;
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0xD9F574", Offset = "0xD9F574", VA = "0xD9F574")]
		public Table GetTypeMetatable(DataType type)
		{
			return null;
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0xD9F5B4", Offset = "0xD9F5B4", VA = "0xD9F5B4")]
		public void SetTypeMetatable(DataType type, Table metatable)
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0xD9F6C0", Offset = "0xD9F6C0", VA = "0xD9F6C0")]
		public static void WarmUp()
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0xD9F73C", Offset = "0xD9F73C", VA = "0xD9F73C")]
		public DynamicExpression CreateDynamicExpression(string code)
		{
			return null;
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0xD9F818", Offset = "0xD9F818", VA = "0xD9F818")]
		public DynamicExpression CreateConstantDynamicExpression(string code, DynValue constant)
		{
			return null;
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0xD99958", Offset = "0xD99958", VA = "0xD99958")]
		internal ScriptExecutionContext CreateDynamicExecutionContext([Optional] CallbackFunction func)
		{
			return null;
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0xD9B158", Offset = "0xD9B158", VA = "0xD9B158")]
		public static string GetBanner([Optional] string subproduct)
		{
			return null;
		}
	}
	[Token(Token = "0x200004B")]
	public class ScriptGlobalOptions
	{
		[Token(Token = "0x17000074")]
		public CustomConvertersCollection CustomConverters
		{
			[Token(Token = "0x6000251")]
			[Address(RVA = "0xD9FB54", Offset = "0xD9FB54", VA = "0xD9FB54")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000252")]
			[Address(RVA = "0xD9FB5C", Offset = "0xD9FB5C", VA = "0xD9FB5C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000075")]
		public IPlatformAccessor Platform
		{
			[Token(Token = "0x6000253")]
			[Address(RVA = "0xD9FB64", Offset = "0xD9FB64", VA = "0xD9FB64")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000254")]
			[Address(RVA = "0xD9FB6C", Offset = "0xD9FB6C", VA = "0xD9FB6C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000076")]
		public bool RethrowExceptionNested
		{
			[Token(Token = "0x6000255")]
			[Address(RVA = "0xD9FB74", Offset = "0xD9FB74", VA = "0xD9FB74")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000256")]
			[Address(RVA = "0xD9FB7C", Offset = "0xD9FB7C", VA = "0xD9FB7C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0xD9D328", Offset = "0xD9D328", VA = "0xD9D328")]
		internal ScriptGlobalOptions()
		{
		}
	}
	[Token(Token = "0x200004C")]
	public class ScriptOptions
	{
		[Token(Token = "0x17000077")]
		public IScriptLoader ScriptLoader
		{
			[Token(Token = "0x6000259")]
			[Address(RVA = "0xD9FB88", Offset = "0xD9FB88", VA = "0xD9FB88")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600025A")]
			[Address(RVA = "0xD9FB90", Offset = "0xD9FB90", VA = "0xD9FB90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000078")]
		public Action<string> DebugPrint
		{
			[Token(Token = "0x600025B")]
			[Address(RVA = "0xD9FB98", Offset = "0xD9FB98", VA = "0xD9FB98")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600025C")]
			[Address(RVA = "0xD9FBA0", Offset = "0xD9FBA0", VA = "0xD9FBA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000079")]
		public Func<string, string> DebugInput
		{
			[Token(Token = "0x600025D")]
			[Address(RVA = "0xD9FBA8", Offset = "0xD9FBA8", VA = "0xD9FBA8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600025E")]
			[Address(RVA = "0xD9FBB0", Offset = "0xD9FBB0", VA = "0xD9FBB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700007A")]
		public bool UseLuaErrorLocations
		{
			[Token(Token = "0x600025F")]
			[Address(RVA = "0xD9FBB8", Offset = "0xD9FBB8", VA = "0xD9FBB8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000260")]
			[Address(RVA = "0xD9FBC0", Offset = "0xD9FBC0", VA = "0xD9FBC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700007B")]
		public ColonOperatorBehaviour ColonOperatorClrCallbackBehaviour
		{
			[Token(Token = "0x6000261")]
			[Address(RVA = "0xD9FBCC", Offset = "0xD9FBCC", VA = "0xD9FBCC")]
			[CompilerGenerated]
			get
			{
				return default(ColonOperatorBehaviour);
			}
			[Token(Token = "0x6000262")]
			[Address(RVA = "0xD9FBD4", Offset = "0xD9FBD4", VA = "0xD9FBD4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700007C")]
		public Stream Stdin
		{
			[Token(Token = "0x6000263")]
			[Address(RVA = "0xD9FBDC", Offset = "0xD9FBDC", VA = "0xD9FBDC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000264")]
			[Address(RVA = "0xD9FBE4", Offset = "0xD9FBE4", VA = "0xD9FBE4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700007D")]
		public Stream Stdout
		{
			[Token(Token = "0x6000265")]
			[Address(RVA = "0xD9FBEC", Offset = "0xD9FBEC", VA = "0xD9FBEC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000266")]
			[Address(RVA = "0xD9FBF4", Offset = "0xD9FBF4", VA = "0xD9FBF4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700007E")]
		public Stream Stderr
		{
			[Token(Token = "0x6000267")]
			[Address(RVA = "0xD9FBFC", Offset = "0xD9FBFC", VA = "0xD9FBFC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000268")]
			[Address(RVA = "0xD9FC04", Offset = "0xD9FC04", VA = "0xD9FC04")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700007F")]
		public int TailCallOptimizationThreshold
		{
			[Token(Token = "0x6000269")]
			[Address(RVA = "0xD9FC0C", Offset = "0xD9FC0C", VA = "0xD9FC0C")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600026A")]
			[Address(RVA = "0xD9FC14", Offset = "0xD9FC14", VA = "0xD9FC14")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000080")]
		public bool CheckThreadAccess
		{
			[Token(Token = "0x600026B")]
			[Address(RVA = "0xD9FC1C", Offset = "0xD9FC1C", VA = "0xD9FC1C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600026C")]
			[Address(RVA = "0xD9FC24", Offset = "0xD9FC24", VA = "0xD9FC24")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0xD9D3A0", Offset = "0xD9D3A0", VA = "0xD9D3A0")]
		internal ScriptOptions()
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0xD9D5F8", Offset = "0xD9D5F8", VA = "0xD9D5F8")]
		internal ScriptOptions(ScriptOptions defaults)
		{
		}
	}
}
namespace MoonSharp.Interpreter.Tree
{
	[Token(Token = "0x200004D")]
	internal abstract class Expression : NodeBase
	{
		[Token(Token = "0x600026D")]
		[Address(RVA = "0xD9FC30", Offset = "0xD9FC30", VA = "0xD9FC30")]
		public Expression(ScriptLoadingContext lcontext)
		{
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0xD9FC98", Offset = "0xD9FC98", VA = "0xD9FC98", Slot = "5")]
		public virtual string GetFriendlyDebugName()
		{
			return null;
		}

		[Token(Token = "0x600026F")]
		public abstract DynValue Eval(ScriptExecutionContext context);

		[Token(Token = "0x6000270")]
		[Address(RVA = "0xD9FCA0", Offset = "0xD9FCA0", VA = "0xD9FCA0", Slot = "7")]
		public virtual SymbolRef FindDynamic(ScriptExecutionContext context)
		{
			return null;
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0xD9FCA8", Offset = "0xD9FCA8", VA = "0xD9FCA8")]
		internal static List<Expression> ExprListAfterFirstExpr(ScriptLoadingContext lcontext, Expression expr1)
		{
			return null;
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0xD9FE88", Offset = "0xD9FE88", VA = "0xD9FE88")]
		internal static List<Expression> ExprList(ScriptLoadingContext lcontext)
		{
			return null;
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0xD9FE5C", Offset = "0xD9FE5C", VA = "0xD9FE5C")]
		internal static Expression Expr(ScriptLoadingContext lcontext)
		{
			return null;
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0xD9FFEC", Offset = "0xD9FFEC", VA = "0xD9FFEC")]
		internal static Expression SubExpr(ScriptLoadingContext lcontext, bool isPrimary)
		{
			return null;
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0xDA04A0", Offset = "0xDA04A0", VA = "0xDA04A0")]
		internal static Expression SimpleExp(ScriptLoadingContext lcontext)
		{
			return null;
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0xDA06D8", Offset = "0xDA06D8", VA = "0xDA06D8")]
		internal static Expression PrimaryExp(ScriptLoadingContext lcontext)
		{
			return null;
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0xDA0988", Offset = "0xDA0988", VA = "0xDA0988")]
		private static Expression PrefixExp(ScriptLoadingContext lcontext)
		{
			return null;
		}
	}
	[Token(Token = "0x200004E")]
	internal interface IVariable
	{
		[Token(Token = "0x6000278")]
		void CompileAssignment(ByteCode bc, int stackofs, int tupleidx);
	}
	[Token(Token = "0x200004F")]
	internal class Lexer
	{
		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Token m_Current;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string m_Code;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int m_PrevLineTo;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int m_PrevColTo;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int m_Cursor;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private int m_Line;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int m_Col;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int m_SourceId;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool m_AutoSkipComments;

		[Token(Token = "0x17000081")]
		public Token Current
		{
			[Token(Token = "0x600027A")]
			[Address(RVA = "0xD9FE64", Offset = "0xD9FE64", VA = "0xD9FE64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0xDA0DDC", Offset = "0xDA0DDC", VA = "0xDA0DDC")]
		public Lexer(int sourceID, string scriptContent, bool autoSkipComments)
		{
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0xDA0E74", Offset = "0xDA0E74", VA = "0xDA0E74")]
		private Token FetchNewToken()
		{
			return null;
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0xD9FE44", Offset = "0xD9FE44", VA = "0xD9FE44")]
		public void Next()
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0xDA1604", Offset = "0xDA1604", VA = "0xDA1604")]
		public Token PeekNext()
		{
			return null;
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0xDA1654", Offset = "0xDA1654", VA = "0xDA1654")]
		private void CursorNext()
		{
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0xDA16E4", Offset = "0xDA16E4", VA = "0xDA16E4")]
		private char CursorChar()
		{
			return default(char);
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0xDA1720", Offset = "0xDA1720", VA = "0xDA1720")]
		private char CursorCharNext()
		{
			return default(char);
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0xDA1738", Offset = "0xDA1738", VA = "0xDA1738")]
		private bool CursorMatches(string pattern)
		{
			return default(bool);
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0xDA16BC", Offset = "0xDA16BC", VA = "0xDA16BC")]
		private bool CursorNotEof()
		{
			return default(bool);
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0xDA17D0", Offset = "0xDA17D0", VA = "0xDA17D0")]
		private bool IsWhiteSpace(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0xDA1828", Offset = "0xDA1828", VA = "0xDA1828")]
		private void SkipWhiteSpace()
		{
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0xDA0EB0", Offset = "0xDA0EB0", VA = "0xDA0EB0")]
		private Token ReadToken()
		{
			return null;
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0xDA1FF0", Offset = "0xDA1FF0", VA = "0xDA1FF0")]
		private string ReadLongString(int fromLine, int fromCol, string startpattern, string subtypeforerrors)
		{
			return null;
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0xDA1A2C", Offset = "0xDA1A2C", VA = "0xDA1A2C")]
		private Token ReadNumberToken(int fromLine, int fromCol, bool leadingDot)
		{
			return null;
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0xDA1CCC", Offset = "0xDA1CCC", VA = "0xDA1CCC")]
		private Token CreateSingleCharToken(TokenType tokenType, int fromLine, int fromCol)
		{
			return null;
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0xDA1EEC", Offset = "0xDA1EEC", VA = "0xDA1EEC")]
		private Token ReadHashBang(int fromLine, int fromCol)
		{
			return null;
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0xDA1D34", Offset = "0xDA1D34", VA = "0xDA1D34")]
		private Token ReadComment(int fromLine, int fromCol)
		{
			return null;
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0xDA2470", Offset = "0xDA2470", VA = "0xDA2470")]
		private Token ReadSimpleStringToken(int fromLine, int fromCol)
		{
			return null;
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0xDA1938", Offset = "0xDA1938", VA = "0xDA1938")]
		private Token PotentiallyDoubleCharOperator(char expectedSecondChar, TokenType singleCharToken, TokenType doubleCharToken, int fromLine, int fromCol)
		{
			return null;
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0xDA2928", Offset = "0xDA2928", VA = "0xDA2928")]
		private Token CreateNameToken(string name, int fromLine, int fromCol)
		{
			return null;
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0xDA1878", Offset = "0xDA1878", VA = "0xDA1878")]
		private Token CreateToken(TokenType tokenType, int fromLine, int fromCol, [Optional] string text)
		{
			return null;
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0xDA2824", Offset = "0xDA2824", VA = "0xDA2824")]
		private string ReadNameToken()
		{
			return null;
		}
	}
	[Token(Token = "0x2000050")]
	internal static class LexerUtils
	{
		[Token(Token = "0x6000290")]
		[Address(RVA = "0xDA3B60", Offset = "0xDA3B60", VA = "0xDA3B60")]
		public static double ParseNumber(Token T)
		{
			return default(double);
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0xDA3C78", Offset = "0xDA3C78", VA = "0xDA3C78")]
		public static double ParseHexInteger(Token T)
		{
			return default(double);
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0xDA3E9C", Offset = "0xDA3E9C", VA = "0xDA3E9C")]
		public static string ReadHexProgressive(string s, ref double d, out int digits)
		{
			return null;
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0xDA40E0", Offset = "0xDA40E0", VA = "0xDA40E0")]
		public static double ParseHexFloat(Token T)
		{
			return default(double);
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0xDA3FDC", Offset = "0xDA3FDC", VA = "0xDA3FDC")]
		public static int HexDigit2Value(char c)
		{
			return default(int);
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0xDA1A18", Offset = "0xDA1A18", VA = "0xDA1A18")]
		public static bool CharIsDigit(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0xDA2A78", Offset = "0xDA2A78", VA = "0xDA2A78")]
		public static bool CharIsHexDigit(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0xDA29D0", Offset = "0xDA29D0", VA = "0xDA29D0")]
		public static string AdjustLuaLongString(string str)
		{
			return null;
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0xDA2ACC", Offset = "0xDA2ACC", VA = "0xDA2ACC")]
		public static string UnescapeLuaString(Token token, string str)
		{
			return null;
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0xDA4610", Offset = "0xDA4610", VA = "0xDA4610")]
		private static string ConvertUtf32ToChar(int i)
		{
			return null;
		}
	}
	[Token(Token = "0x2000051")]
	internal class Token
	{
		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly int SourceId;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public readonly int FromCol;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly int ToCol;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public readonly int FromLine;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly int ToLine;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public readonly int PrevCol;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly int PrevLine;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public readonly TokenType Type;

		[Token(Token = "0x17000082")]
		public string Text
		{
			[Token(Token = "0x600029A")]
			[Address(RVA = "0xDA4668", Offset = "0xDA4668", VA = "0xDA4668")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600029B")]
			[Address(RVA = "0xDA4670", Offset = "0xDA4670", VA = "0xDA4670")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0xDA3AF8", Offset = "0xDA3AF8", VA = "0xDA3AF8")]
		public Token(TokenType type, int sourceId, int fromLine, int fromCol, int toLine, int toCol, int prevLine, int prevCol)
		{
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0xDA4678", Offset = "0xDA4678", VA = "0xDA4678", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0xDA3408", Offset = "0xDA3408", VA = "0xDA3408")]
		public static TokenType? GetReservedTokenType(string reservedWord)
		{
			return null;
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0xDA4908", Offset = "0xDA4908", VA = "0xDA4908")]
		public double GetNumberValue()
		{
			return default(double);
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0xDA498C", Offset = "0xDA498C", VA = "0xDA498C")]
		public bool IsEndOfBlock()
		{
			return default(bool);
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0xDA0474", Offset = "0xDA0474", VA = "0xDA0474")]
		public bool IsUnaryOperator()
		{
			return default(bool);
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0xDA0698", Offset = "0xDA0698", VA = "0xDA0698")]
		public bool IsBinaryOperator()
		{
			return default(bool);
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0xD996F8", Offset = "0xD996F8", VA = "0xD996F8")]
		internal SourceRef GetSourceRef(bool isStepStop = true)
		{
			return null;
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0xDA49C0", Offset = "0xDA49C0", VA = "0xDA49C0")]
		internal SourceRef GetSourceRef(Token to, bool isStepStop = true)
		{
			return null;
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0xDA4A64", Offset = "0xDA4A64", VA = "0xDA4A64")]
		internal SourceRef GetSourceRefUpTo(Token to, bool isStepStop = true)
		{
			return null;
		}
	}
	[Token(Token = "0x2000052")]
	internal enum TokenType
	{
		[Token(Token = "0x4000108")]
		Eof,
		[Token(Token = "0x4000109")]
		HashBang,
		[Token(Token = "0x400010A")]
		Name,
		[Token(Token = "0x400010B")]
		And,
		[Token(Token = "0x400010C")]
		Break,
		[Token(Token = "0x400010D")]
		Do,
		[Token(Token = "0x400010E")]
		Else,
		[Token(Token = "0x400010F")]
		ElseIf,
		[Token(Token = "0x4000110")]
		End,
		[Token(Token = "0x4000111")]
		False,
		[Token(Token = "0x4000112")]
		For,
		[Token(Token = "0x4000113")]
		Function,
		[Token(Token = "0x4000114")]
		Lambda,
		[Token(Token = "0x4000115")]
		Goto,
		[Token(Token = "0x4000116")]
		If,
		[Token(Token = "0x4000117")]
		In,
		[Token(Token = "0x4000118")]
		Local,
		[Token(Token = "0x4000119")]
		Nil,
		[Token(Token = "0x400011A")]
		Not,
		[Token(Token = "0x400011B")]
		Or,
		[Token(Token = "0x400011C")]
		Repeat,
		[Token(Token = "0x400011D")]
		Return,
		[Token(Token = "0x400011E")]
		Then,
		[Token(Token = "0x400011F")]
		True,
		[Token(Token = "0x4000120")]
		Until,
		[Token(Token = "0x4000121")]
		While,
		[Token(Token = "0x4000122")]
		Op_Equal,
		[Token(Token = "0x4000123")]
		Op_Assignment,
		[Token(Token = "0x4000124")]
		Op_LessThan,
		[Token(Token = "0x4000125")]
		Op_LessThanEqual,
		[Token(Token = "0x4000126")]
		Op_GreaterThanEqual,
		[Token(Token = "0x4000127")]
		Op_GreaterThan,
		[Token(Token = "0x4000128")]
		Op_NotEqual,
		[Token(Token = "0x4000129")]
		Op_Concat,
		[Token(Token = "0x400012A")]
		VarArgs,
		[Token(Token = "0x400012B")]
		Dot,
		[Token(Token = "0x400012C")]
		Colon,
		[Token(Token = "0x400012D")]
		DoubleColon,
		[Token(Token = "0x400012E")]
		Comma,
		[Token(Token = "0x400012F")]
		Brk_Close_Curly,
		[Token(Token = "0x4000130")]
		Brk_Open_Curly,
		[Token(Token = "0x4000131")]
		Brk_Close_Round,
		[Token(Token = "0x4000132")]
		Brk_Open_Round,
		[Token(Token = "0x4000133")]
		Brk_Close_Square,
		[Token(Token = "0x4000134")]
		Brk_Open_Square,
		[Token(Token = "0x4000135")]
		Op_Len,
		[Token(Token = "0x4000136")]
		Op_Pwr,
		[Token(Token = "0x4000137")]
		Op_Mod,
		[Token(Token = "0x4000138")]
		Op_Div,
		[Token(Token = "0x4000139")]
		Op_Mul,
		[Token(Token = "0x400013A")]
		Op_MinusOrSub,
		[Token(Token = "0x400013B")]
		Op_Add,
		[Token(Token = "0x400013C")]
		Comment,
		[Token(Token = "0x400013D")]
		String,
		[Token(Token = "0x400013E")]
		String_Long,
		[Token(Token = "0x400013F")]
		Number,
		[Token(Token = "0x4000140")]
		Number_HexFloat,
		[Token(Token = "0x4000141")]
		Number_Hex,
		[Token(Token = "0x4000142")]
		SemiColon,
		[Token(Token = "0x4000143")]
		Invalid,
		[Token(Token = "0x4000144")]
		Brk_Open_Curly_Shared,
		[Token(Token = "0x4000145")]
		Op_Dollar
	}
	[Token(Token = "0x2000053")]
	internal class Loop : ILoop
	{
		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RuntimeScopeBlock Scope;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<Instruction> BreakJumps;

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0xDA4B04", Offset = "0xDA4B04", VA = "0xDA4B04", Slot = "4")]
		public void CompileBreak(ByteCode bc)
		{
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0xDA4BDC", Offset = "0xDA4BDC", VA = "0xDA4BDC", Slot = "5")]
		public bool IsBoundary()
		{
			return default(bool);
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0xDA4BE4", Offset = "0xDA4BE4", VA = "0xDA4BE4")]
		public Loop()
		{
		}
	}
	[Token(Token = "0x2000054")]
	internal class LoopBoundary : ILoop
	{
		[Token(Token = "0x60002A9")]
		[Address(RVA = "0xDA4C60", Offset = "0xDA4C60", VA = "0xDA4C60", Slot = "4")]
		public void CompileBreak(ByteCode bc)
		{
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0xDA4CAC", Offset = "0xDA4CAC", VA = "0xDA4CAC", Slot = "5")]
		public bool IsBoundary()
		{
			return default(bool);
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0xDA4CB4", Offset = "0xDA4CB4", VA = "0xDA4CB4")]
		public LoopBoundary()
		{
		}
	}
	[Token(Token = "0x2000055")]
	internal abstract class NodeBase
	{
		[Token(Token = "0x17000083")]
		public Script Script
		{
			[Token(Token = "0x60002AC")]
			[Address(RVA = "0xDA4CBC", Offset = "0xDA4CBC", VA = "0xDA4CBC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60002AD")]
			[Address(RVA = "0xDA4CC4", Offset = "0xDA4CC4", VA = "0xDA4CC4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000084")]
		protected ScriptLoadingContext LoadingContext
		{
			[Token(Token = "0x60002AE")]
			[Address(RVA = "0xDA4CCC", Offset = "0xDA4CCC", VA = "0xDA4CCC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60002AF")]
			[Address(RVA = "0xDA4CD4", Offset = "0xDA4CD4", VA = "0xDA4CD4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0xD9FC64", Offset = "0xD9FC64", VA = "0xD9FC64")]
		public NodeBase(ScriptLoadingContext lcontext)
		{
		}

		[Token(Token = "0x60002B1")]
		public abstract void Compile(ByteCode bc);

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0xDA4CDC", Offset = "0xDA4CDC", VA = "0xDA4CDC")]
		protected static Token UnexpectedTokenType(Token t)
		{
			return null;
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0xDA0B74", Offset = "0xDA0B74", VA = "0xDA0B74")]
		protected static Token CheckTokenType(ScriptLoadingContext lcontext, TokenType tokenType)
		{
			return null;
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0xDA4DA0", Offset = "0xDA4DA0", VA = "0xDA4DA0")]
		protected static Token CheckTokenType(ScriptLoadingContext lcontext, TokenType tokenType1, TokenType tokenType2)
		{
			return null;
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0xDA4E28", Offset = "0xDA4E28", VA = "0xDA4E28")]
		protected static Token CheckTokenType(ScriptLoadingContext lcontext, TokenType tokenType1, TokenType tokenType2, TokenType tokenType3)
		{
			return null;
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0xDA4EC4", Offset = "0xDA4EC4", VA = "0xDA4EC4")]
		protected static void CheckTokenTypeNotNext(ScriptLoadingContext lcontext, TokenType tokenType)
		{
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0xDA0BF0", Offset = "0xDA0BF0", VA = "0xDA0BF0")]
		protected static Token CheckMatch(ScriptLoadingContext lcontext, Token originalToken, TokenType expectedTokenType, string expectedTokenText)
		{
			return null;
		}
	}
	[Token(Token = "0x2000056")]
	internal abstract class Statement : NodeBase
	{
		[Token(Token = "0x60002B8")]
		[Address(RVA = "0xDA4F14", Offset = "0xDA4F14", VA = "0xDA4F14")]
		public Statement(ScriptLoadingContext lcontext)
		{
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0xDA4F48", Offset = "0xDA4F48", VA = "0xDA4F48")]
		protected static Statement CreateStatement(ScriptLoadingContext lcontext, out bool forceLast)
		{
			return null;
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0xDA53B8", Offset = "0xDA53B8", VA = "0xDA53B8")]
		private static Statement DispatchForLoopStatement(ScriptLoadingContext lcontext)
		{
			return null;
		}
	}
}
namespace MoonSharp.Interpreter.Tree.Statements
{
	[Token(Token = "0x2000057")]
	internal class AssignmentStatement : Statement
	{
		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<IVariable> m_LValues;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<Expression> m_RValues;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private SourceRef m_Ref;

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0xDA54B8", Offset = "0xDA54B8", VA = "0xDA54B8")]
		public AssignmentStatement(ScriptLoadingContext lcontext, Token startToken)
		{
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0xDA5A7C", Offset = "0xDA5A7C", VA = "0xDA5A7C")]
		public AssignmentStatement(ScriptLoadingContext lcontext, Expression firstExpression, Token first)
		{
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0xDA5D34", Offset = "0xDA5D34", VA = "0xDA5D34")]
		private IVariable CheckVar(ScriptLoadingContext lcontext, Expression firstExpression)
		{
			return null;
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0xDA5E60", Offset = "0xDA5E60", VA = "0xDA5E60", Slot = "4")]
		public override void Compile(ByteCode bc)
		{
		}
	}
	[Token(Token = "0x2000058")]
	internal class BreakStatement : Statement
	{
		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private SourceRef m_Ref;

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0xDA5998", Offset = "0xDA5998", VA = "0xDA5998")]
		public BreakStatement(ScriptLoadingContext lcontext)
		{
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0xDA62BC", Offset = "0xDA62BC", VA = "0xDA62BC", Slot = "4")]
		public override void Compile(ByteCode bc)
		{
		}
	}
	[Token(Token = "0x2000059")]
	internal class ChunkStatement : Statement, IClosureBuilder
	{
		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Statement m_Block;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private RuntimeScopeFrame m_StackFrame;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private SymbolRef m_Env;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private SymbolRef m_VarArgs;

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0xDA7794", Offset = "0xDA7794", VA = "0xDA7794")]
		public ChunkStatement(ScriptLoadingContext lcontext)
		{
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0xDA7AFC", Offset = "0xDA7AFC", VA = "0xDA7AFC", Slot = "4")]
		public override void Compile(ByteCode bc)
		{
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0xDA7CCC", Offset = "0xDA7CCC", VA = "0xDA7CCC", Slot = "5")]
		public SymbolRef CreateUpvalue(BuildTimeScope scope, SymbolRef symbol)
		{
			return null;
		}
	}
	[Token(Token = "0x200005A")]
	internal class CompositeStatement : Statement
	{
		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<Statement> m_Statements;

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0xDA7984", Offset = "0xDA7984", VA = "0xDA7984")]
		public CompositeStatement(ScriptLoadingContext lcontext)
		{
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0xDA7CD4", Offset = "0xDA7CD4", VA = "0xDA7CD4", Slot = "4")]
		public override void Compile(ByteCode bc)
		{
		}
	}
	[Token(Token = "0x200005B")]
	internal class EmptyStatement : Statement
	{
		[Token(Token = "0x60002C6")]
		[Address(RVA = "0xDA7E28", Offset = "0xDA7E28", VA = "0xDA7E28")]
		public EmptyStatement(ScriptLoadingContext lcontext)
		{
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0xDA7E30", Offset = "0xDA7E30", VA = "0xDA7E30", Slot = "4")]
		public override void Compile(ByteCode bc)
		{
		}
	}
	[Token(Token = "0x200005C")]
	internal class ForEachLoopStatement : Statement
	{
		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private RuntimeScopeBlock m_StackFrame;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private SymbolRef[] m_Names;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private IVariable[] m_NameExps;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Expression m_RValues;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Statement m_Block;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private SourceRef m_RefFor;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private SourceRef m_RefEnd;

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0xDA7E34", Offset = "0xDA7E34", VA = "0xDA7E34")]
		public ForEachLoopStatement(ScriptLoadingContext lcontext, Token firstNameToken, Token forToken)
		{
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0xDA83BC", Offset = "0xDA83BC", VA = "0xDA83BC", Slot = "4")]
		public override void Compile(ByteCode bc)
		{
		}
	}
	[Token(Token = "0x200005E")]
	internal class ForLoopStatement : Statement
	{
		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private RuntimeScopeBlock m_StackFrame;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Statement m_InnerBlock;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private SymbolRef m_VarName;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Expression m_Start;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Expression m_End;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Expression m_Step;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private SourceRef m_RefFor;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private SourceRef m_RefEnd;

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0xDA8910", Offset = "0xDA8910", VA = "0xDA8910")]
		public ForLoopStatement(ScriptLoadingContext lcontext, Token nameToken, Token forToken)
		{
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0xDA8C34", Offset = "0xDA8C34", VA = "0xDA8C34", Slot = "4")]
		public override void Compile(ByteCode bc)
		{
		}
	}
	[Token(Token = "0x200005F")]
	internal class FunctionCallStatement : Statement
	{
		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FunctionCallExpression m_FunctionCallExpression;

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0xDA8F98", Offset = "0xDA8F98", VA = "0xDA8F98")]
		public FunctionCallStatement(ScriptLoadingContext lcontext, FunctionCallExpression functionCallExpression)
		{
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0xDA9074", Offset = "0xDA9074", VA = "0xDA9074", Slot = "4")]
		public override void Compile(ByteCode bc)
		{
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0xDA9234", Offset = "0xDA9234", VA = "0xDA9234")]
		private void RemoveBreakpointStop(Instruction instruction)
		{
		}
	}
	[Token(Token = "0x2000060")]
	internal class FunctionDefinitionStatement : Statement
	{
		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private SymbolRef m_FuncSymbol;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private SourceRef m_SourceRef;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool m_Local;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool m_IsMethodCallingConvention;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string m_MethodName;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string m_FriendlyName;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<string> m_TableAccessors;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private FunctionDefinitionExpression m_FuncDef;

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0xDA924C", Offset = "0xDA924C", VA = "0xDA924C")]
		public FunctionDefinitionStatement(ScriptLoadingContext lcontext, bool local, Token localToken)
		{
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0xDA9698", Offset = "0xDA9698", VA = "0xDA9698", Slot = "4")]
		public override void Compile(ByteCode bc)
		{
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0xDA9C98", Offset = "0xDA9C98", VA = "0xDA9C98")]
		private int SetMethod(ByteCode bc)
		{
			return default(int);
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0xDA9E8C", Offset = "0xDA9E8C", VA = "0xDA9E8C")]
		private int SetFunction(ByteCode bc, int numPop)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000062")]
	internal class GotoStatement : Statement
	{
		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Instruction m_Jump;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int m_LabelAddress;

		[Token(Token = "0x17000085")]
		internal SourceRef SourceRef
		{
			[Token(Token = "0x60002DA")]
			[Address(RVA = "0xDA9F48", Offset = "0xDA9F48", VA = "0xDA9F48")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60002DB")]
			[Address(RVA = "0xDA9F50", Offset = "0xDA9F50", VA = "0xDA9F50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000086")]
		internal Token GotoToken
		{
			[Token(Token = "0x60002DC")]
			[Address(RVA = "0xDA9F58", Offset = "0xDA9F58", VA = "0xDA9F58")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60002DD")]
			[Address(RVA = "0xDA9F60", Offset = "0xDA9F60", VA = "0xDA9F60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000087")]
		public string Label
		{
			[Token(Token = "0x60002DE")]
			[Address(RVA = "0xDA9F68", Offset = "0xDA9F68", VA = "0xDA9F68")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60002DF")]
			[Address(RVA = "0xDA9F70", Offset = "0xDA9F70", VA = "0xDA9F70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000088")]
		internal int DefinedVarsCount
		{
			[Token(Token = "0x60002E0")]
			[Address(RVA = "0xDA9F78", Offset = "0xDA9F78", VA = "0xDA9F78")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002E1")]
			[Address(RVA = "0xDA9F80", Offset = "0xDA9F80", VA = "0xDA9F80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000089")]
		internal string LastDefinedVarName
		{
			[Token(Token = "0x60002E2")]
			[Address(RVA = "0xDA9F88", Offset = "0xDA9F88", VA = "0xDA9F88")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60002E3")]
			[Address(RVA = "0xDA9F90", Offset = "0xDA9F90", VA = "0xDA9F90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0xDA9F98", Offset = "0xDA9F98", VA = "0xDA9F98")]
		public GotoStatement(ScriptLoadingContext lcontext)
		{
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0xDAA030", Offset = "0xDAA030", VA = "0xDAA030", Slot = "4")]
		public override void Compile(ByteCode bc)
		{
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0xDAA068", Offset = "0xDAA068", VA = "0xDAA068")]
		internal void SetDefinedVars(int definedVarsCount, string lastDefinedVarsName)
		{
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0xDAA074", Offset = "0xDAA074", VA = "0xDAA074")]
		internal void SetAddress(int labelAddress)
		{
		}
	}
	[Token(Token = "0x2000063")]
	internal class IfStatement : Statement
	{
		[Token(Token = "0x2000064")]
		private class IfBlock
		{
			[Token(Token = "0x4000178")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Expression Exp;

			[Token(Token = "0x4000179")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Statement Block;

			[Token(Token = "0x400017A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RuntimeScopeBlock StackFrame;

			[Token(Token = "0x400017B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public SourceRef Source;

			[Token(Token = "0x60002EC")]
			[Address(RVA = "0xDAA5A4", Offset = "0xDAA5A4", VA = "0xDAA5A4")]
			public IfBlock()
			{
			}
		}

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<IfBlock> m_Ifs;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IfBlock m_Else;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private SourceRef m_End;

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0xDAA088", Offset = "0xDAA088", VA = "0xDAA088")]
		public IfStatement(ScriptLoadingContext lcontext)
		{
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0xDAA2B4", Offset = "0xDAA2B4", VA = "0xDAA2B4")]
		private IfBlock CreateIfBlock(ScriptLoadingContext lcontext)
		{
			return null;
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0xDAA440", Offset = "0xDAA440", VA = "0xDAA440")]
		private IfBlock CreateElseBlock(ScriptLoadingContext lcontext)
		{
			return null;
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0xDAA5AC", Offset = "0xDAA5AC", VA = "0xDAA5AC", Slot = "4")]
		public override void Compile(ByteCode bc)
		{
		}
	}
	[Token(Token = "0x2000065")]
	internal class LabelStatement : Statement
	{
		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<GotoStatement> m_Gotos;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private RuntimeScopeBlock m_StackFrame;

		[Token(Token = "0x1700008A")]
		public string Label
		{
			[Token(Token = "0x60002ED")]
			[Address(RVA = "0xDAAFDC", Offset = "0xDAAFDC", VA = "0xDAAFDC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60002EE")]
			[Address(RVA = "0xDAAFE4", Offset = "0xDAAFE4", VA = "0xDAAFE4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700008B")]
		public int Address
		{
			[Token(Token = "0x60002EF")]
			[Address(RVA = "0xDAAFEC", Offset = "0xDAAFEC", VA = "0xDAAFEC")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002F0")]
			[Address(RVA = "0xDAAFF4", Offset = "0xDAAFF4", VA = "0xDAAFF4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700008C")]
		public SourceRef SourceRef
		{
			[Token(Token = "0x60002F1")]
			[Address(RVA = "0xDAAFFC", Offset = "0xDAAFFC", VA = "0xDAAFFC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60002F2")]
			[Address(RVA = "0xDAB004", Offset = "0xDAB004", VA = "0xDAB004")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700008D")]
		public Token NameToken
		{
			[Token(Token = "0x60002F3")]
			[Address(RVA = "0xDAB00C", Offset = "0xDAB00C", VA = "0xDAB00C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60002F4")]
			[Address(RVA = "0xDAB014", Offset = "0xDAB014", VA = "0xDAB014")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700008E")]
		internal int DefinedVarsCount
		{
			[Token(Token = "0x60002F5")]
			[Address(RVA = "0xDAB01C", Offset = "0xDAB01C", VA = "0xDAB01C")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002F6")]
			[Address(RVA = "0xDAB024", Offset = "0xDAB024", VA = "0xDAB024")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700008F")]
		internal string LastDefinedVarName
		{
			[Token(Token = "0x60002F7")]
			[Address(RVA = "0xDAB02C", Offset = "0xDAB02C", VA = "0xDAB02C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60002F8")]
			[Address(RVA = "0xDAB034", Offset = "0xDAB034", VA = "0xDAB034")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0xDAB03C", Offset = "0xDAB03C", VA = "0xDAB03C")]
		public LabelStatement(ScriptLoadingContext lcontext)
		{
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0xDAB13C", Offset = "0xDAB13C", VA = "0xDAB13C")]
		internal void SetDefinedVars(int definedVarsCount, string lastDefinedVarsName)
		{
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0xDAB148", Offset = "0xDAB148", VA = "0xDAB148")]
		internal void RegisterGoto(GotoStatement gotostat)
		{
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0xDAB1F0", Offset = "0xDAB1F0", VA = "0xDAB1F0", Slot = "4")]
		public override void Compile(ByteCode bc)
		{
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0xDAB360", Offset = "0xDAB360", VA = "0xDAB360")]
		internal void SetScope(RuntimeScopeBlock runtimeScopeBlock)
		{
		}
	}
	[Token(Token = "0x2000066")]
	internal class RepeatStatement : Statement
	{
		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Expression m_Condition;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Statement m_Block;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private RuntimeScopeBlock m_StackFrame;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private SourceRef m_Repeat;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private SourceRef m_Until;

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0xDAB368", Offset = "0xDAB368", VA = "0xDAB368")]
		public RepeatStatement(ScriptLoadingContext lcontext)
		{
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0xDAB558", Offset = "0xDAB558", VA = "0xDAB558", Slot = "4")]
		public override void Compile(ByteCode bc)
		{
		}
	}
	[Token(Token = "0x2000067")]
	internal class ReturnStatement : Statement
	{
		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Expression m_Expression;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private SourceRef m_Ref;

		[Token(Token = "0x6000300")]
		[Address(RVA = "0xDAB7F0", Offset = "0xDAB7F0", VA = "0xDAB7F0")]
		public ReturnStatement(ScriptLoadingContext lcontext, Expression e, SourceRef sref)
		{
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0xDAB8CC", Offset = "0xDAB8CC", VA = "0xDAB8CC")]
		public ReturnStatement(ScriptLoadingContext lcontext)
		{
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0xDABA88", Offset = "0xDABA88", VA = "0xDABA88", Slot = "4")]
		public override void Compile(ByteCode bc)
		{
		}
	}
	[Token(Token = "0x2000068")]
	internal class ScopeBlockStatement : Statement
	{
		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Statement m_Block;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private RuntimeScopeBlock m_StackFrame;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private SourceRef m_Do;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private SourceRef m_End;

		[Token(Token = "0x6000303")]
		[Address(RVA = "0xDABC4C", Offset = "0xDABC4C", VA = "0xDABC4C")]
		public ScopeBlockStatement(ScriptLoadingContext lcontext)
		{
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0xDABE10", Offset = "0xDABE10", VA = "0xDABE10", Slot = "4")]
		public override void Compile(ByteCode bc)
		{
		}
	}
	[Token(Token = "0x2000069")]
	internal class WhileStatement : Statement
	{
		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Expression m_Condition;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Statement m_Block;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private RuntimeScopeBlock m_StackFrame;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private SourceRef m_Start;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private SourceRef m_End;

		[Token(Token = "0x6000305")]
		[Address(RVA = "0xDAC0D8", Offset = "0xDAC0D8", VA = "0xDAC0D8")]
		public WhileStatement(ScriptLoadingContext lcontext)
		{
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0xDAC2D8", Offset = "0xDAC2D8", VA = "0xDAC2D8", Slot = "4")]
		public override void Compile(ByteCode bc)
		{
		}
	}
}
namespace MoonSharp.Interpreter.Tree.Fast_Interface
{
	[Token(Token = "0x200006A")]
	internal static class Loader_Fast
	{
		[Token(Token = "0x6000307")]
		[Address(RVA = "0xDAC5A8", Offset = "0xDAC5A8", VA = "0xDAC5A8")]
		internal static DynamicExprExpression LoadDynamicExpr(Script script, SourceCode source)
		{
			return null;
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0xDAC870", Offset = "0xDAC870", VA = "0xDAC870")]
		private static ScriptLoadingContext CreateLoadingContext(Script script, SourceCode source)
		{
			return null;
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0xDAC998", Offset = "0xDAC998", VA = "0xDAC998")]
		internal static int LoadChunk(Script script, SourceCode source, ByteCode bytecode)
		{
			return default(int);
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0xDACF64", Offset = "0xDACF64", VA = "0xDACF64")]
		internal static int LoadFunction(Script script, SourceCode source, ByteCode bytecode, bool usesGlobalEnv)
		{
			return default(int);
		}
	}
}
namespace MoonSharp.Interpreter.Tree.Expressions
{
	[Token(Token = "0x200006B")]
	internal class AdjustmentExpression : Expression
	{
		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Expression expression;

		[Token(Token = "0x600030B")]
		[Address(RVA = "0xDAD81C", Offset = "0xDAD81C", VA = "0xDAD81C")]
		public AdjustmentExpression(ScriptLoadingContext lcontext, Expression exp)
		{
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0xDAD844", Offset = "0xDAD844", VA = "0xDAD844", Slot = "4")]
		public override void Compile(ByteCode bc)
		{
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0xDAD878", Offset = "0xDAD878", VA = "0xDAD878", Slot = "6")]
		public override DynValue Eval(ScriptExecutionContext context)
		{
			return null;
		}
	}
	[Token(Token = "0x200006C")]
	internal class BinaryOperatorExpression : Expression
	{
		[Token(Token = "0x200006D")]
		[Flags]
		private enum Operator
		{
			[Token(Token = "0x40001A0")]
			NotAnOperator = 0,
			[Token(Token = "0x40001A1")]
			Or = 1,
			[Token(Token = "0x40001A2")]
			And = 2,
			[Token(Token = "0x40001A3")]
			Less = 4,
			[Token(Token = "0x40001A4")]
			Greater = 8,
			[Token(Token = "0x40001A5")]
			LessOrEqual = 0x10,
			[Token(Token = "0x40001A6")]
			GreaterOrEqual = 0x20,
			[Token(Token = "0x40001A7")]
			NotEqual = 0x40,
			[Token(Token = "0x40001A8")]
			Equal = 0x80,
			[Token(Token = "0x40001A9")]
			StrConcat = 0x100,
			[Token(Token = "0x40001AA")]
			Add = 0x200,
			[Token(Token = "0x40001AB")]
			Sub = 0x400,
			[Token(Token = "0x40001AC")]
			Mul = 0x1000,
			[Token(Token = "0x40001AD")]
			Div = 0x2000,
			[Token(Token = "0x40001AE")]
			Mod = 0x4000,
			[Token(Token = "0x40001AF")]
			Power = 0x8000
		}

		[Token(Token = "0x200006E")]
		private class Node
		{
			[Token(Token = "0x40001B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Expression Expr;

			[Token(Token = "0x40001B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Operator Op;

			[Token(Token = "0x40001B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Node Prev;

			[Token(Token = "0x40001B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Node Next;

			[Token(Token = "0x600031F")]
			[Address(RVA = "0xDAD9C8", Offset = "0xDAD9C8", VA = "0xDAD9C8")]
			public Node()
			{
			}
		}

		[Token(Token = "0x200006F")]
		private class LinkedList
		{
			[Token(Token = "0x40001B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Node Nodes;

			[Token(Token = "0x40001B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Node Last;

			[Token(Token = "0x40001B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Operator OperatorMask;

			[Token(Token = "0x6000320")]
			[Address(RVA = "0xDAD900", Offset = "0xDAD900", VA = "0xDAD900")]
			public LinkedList()
			{
			}
		}

		[Token(Token = "0x4000195")]
		private const Operator POWER = Operator.Power;

		[Token(Token = "0x4000196")]
		private const Operator MUL_DIV_MOD = Operator.Mul | Operator.Div | Operator.Mod;

		[Token(Token = "0x4000197")]
		private const Operator ADD_SUB = Operator.Add | Operator.Sub;

		[Token(Token = "0x4000198")]
		private const Operator STRCAT = Operator.StrConcat;

		[Token(Token = "0x4000199")]
		private const Operator COMPARES = Operator.Less | Operator.Greater | Operator.LessOrEqual | Operator.GreaterOrEqual | Operator.NotEqual | Operator.Equal;

		[Token(Token = "0x400019A")]
		private const Operator LOGIC_AND = Operator.And;

		[Token(Token = "0x400019B")]
		private const Operator LOGIC_OR = Operator.Or;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Expression m_Exp1;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Expression m_Exp2;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Operator m_Operator;

		[Token(Token = "0x600030E")]
		[Address(RVA = "0xDAD8A4", Offset = "0xDAD8A4", VA = "0xDAD8A4")]
		public static object BeginOperatorChain()
		{
			return null;
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0xDAD908", Offset = "0xDAD908", VA = "0xDAD908")]
		public static void AddExpressionToChain(object chain, Expression exp)
		{
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0xDADA24", Offset = "0xDADA24", VA = "0xDADA24")]
		public static void AddOperatorToChain(object chain, Token op)
		{
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0xDADC4C", Offset = "0xDADC4C", VA = "0xDADC4C")]
		public static Expression CommitOperatorChain(object chain, ScriptLoadingContext lcontext)
		{
			return null;
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0xDADE08", Offset = "0xDADE08", VA = "0xDADE08")]
		public static Expression CreatePowerExpression(Expression op1, Expression op2, ScriptLoadingContext lcontext)
		{
			return null;
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0xDAD9D0", Offset = "0xDAD9D0", VA = "0xDAD9D0")]
		private static void AddNode(LinkedList list, Node node)
		{
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0xDADCD0", Offset = "0xDADCD0", VA = "0xDADCD0")]
		private static Expression CreateSubTree(LinkedList list, ScriptLoadingContext lcontext)
		{
			return null;
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0xDADFE0", Offset = "0xDADFE0", VA = "0xDADFE0")]
		private static Node PrioritizeLeftAssociative(Node nodes, ScriptLoadingContext lcontext, Operator operatorsToFind)
		{
			return null;
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0xDADEC8", Offset = "0xDADEC8", VA = "0xDADEC8")]
		private static Node PrioritizeRightAssociative(Node nodes, ScriptLoadingContext lcontext, Operator operatorsToFind)
		{
			return null;
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0xDADAEC", Offset = "0xDADAEC", VA = "0xDADAEC")]
		private static Operator ParseBinaryOperator(Token token)
		{
			return default(Operator);
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0xDADE88", Offset = "0xDADE88", VA = "0xDADE88")]
		private BinaryOperatorExpression(Expression exp1, Expression exp2, Operator op, ScriptLoadingContext lcontext)
		{
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0xDAE0EC", Offset = "0xDAE0EC", VA = "0xDAE0EC")]
		private static bool ShouldInvertBoolean(Operator op)
		{
			return default(bool);
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0xDAE114", Offset = "0xDAE114", VA = "0xDAE114")]
		private static OpCode OperatorToOpCode(Operator op)
		{
			return default(OpCode);
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0xDAE2A4", Offset = "0xDAE2A4", VA = "0xDAE2A4", Slot = "4")]
		public override void Compile(ByteCode bc)
		{
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0xDAE3C0", Offset = "0xDAE3C0", VA = "0xDAE3C0", Slot = "6")]
		public override DynValue Eval(ScriptExecutionContext context)
		{
			return null;
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0xDAE910", Offset = "0xDAE910", VA = "0xDAE910")]
		private double EvalArithmetic(DynValue v1, DynValue v2)
		{
			return default(double);
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0xDAE630", Offset = "0xDAE630", VA = "0xDAE630")]
		private bool EvalComparison(DynValue l, DynValue r, Operator op)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000070")]
	internal class DynamicExprExpression : Expression
	{
		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Expression m_Exp;

		[Token(Token = "0x6000321")]
		[Address(RVA = "0xDAC958", Offset = "0xDAC958", VA = "0xDAC958")]
		public DynamicExprExpression(Expression exp, ScriptLoadingContext lcontext)
		{
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0xDAEB58", Offset = "0xDAEB58", VA = "0xDAEB58", Slot = "6")]
		public override DynValue Eval(ScriptExecutionContext context)
		{
			return null;
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0xDAEB78", Offset = "0xDAEB78", VA = "0xDAEB78", Slot = "4")]
		public override void Compile(ByteCode bc)
		{
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0xDAEBB8", Offset = "0xDAEBB8", VA = "0xDAEBB8", Slot = "7")]
		public override SymbolRef FindDynamic(ScriptExecutionContext context)
		{
			return null;
		}
	}
	[Token(Token = "0x2000071")]
	internal class ExprListExpression : Expression
	{
		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<Expression> expressions;

		[Token(Token = "0x6000325")]
		[Address(RVA = "0xDA8390", Offset = "0xDA8390", VA = "0xDA8390")]
		public ExprListExpression(List<Expression> exps, ScriptLoadingContext lcontext)
		{
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0xDAEBD8", Offset = "0xDAEBD8", VA = "0xDAEBD8")]
		public Expression[] GetExpressions()
		{
			return null;
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0xDAEC28", Offset = "0xDAEC28", VA = "0xDAEC28", Slot = "4")]
		public override void Compile(ByteCode bc)
		{
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0xDAEDB8", Offset = "0xDAEDB8", VA = "0xDAEDB8", Slot = "6")]
		public override DynValue Eval(ScriptExecutionContext context)
		{
			return null;
		}
	}
	[Token(Token = "0x2000072")]
	internal class FunctionCallExpression : Expression
	{
		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<Expression> m_Arguments;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Expression m_Function;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string m_Name;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string m_DebugErr;

		[Token(Token = "0x17000090")]
		internal SourceRef SourceRef
		{
			[Token(Token = "0x6000329")]
			[Address(RVA = "0xDAEEA8", Offset = "0xDAEEA8", VA = "0xDAEEA8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600032A")]
			[Address(RVA = "0xDAEEB0", Offset = "0xDAEEB0", VA = "0xDAEEB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0xDAEEB8", Offset = "0xDAEEB8", VA = "0xDAEEB8")]
		public FunctionCallExpression(ScriptLoadingContext lcontext, Expression function, Token thisCallName)
		{
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0xDAF83C", Offset = "0xDAF83C", VA = "0xDAF83C", Slot = "4")]
		public override void Compile(ByteCode bc)
		{
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0xDAF9CC", Offset = "0xDAF9CC", VA = "0xDAF9CC", Slot = "6")]
		public override DynValue Eval(ScriptExecutionContext context)
		{
			return null;
		}
	}
	[Token(Token = "0x2000073")]
	internal class FunctionDefinitionExpression : Expression, IClosureBuilder
	{
		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private SymbolRef[] m_ParamNames;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Statement m_Statement;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private RuntimeScopeFrame m_StackFrame;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<SymbolRef> m_Closure;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool m_HasVarArgs;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Instruction m_ClosureInstruction;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool m_UsesGlobalEnv;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private SymbolRef m_Env;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private SourceRef m_Begin;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private SourceRef m_End;

		[Token(Token = "0x600032E")]
		[Address(RVA = "0xDAD530", Offset = "0xDAD530", VA = "0xDAD530")]
		public FunctionDefinitionExpression(ScriptLoadingContext lcontext, bool usesGlobalEnv)
		{
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0xDA9688", Offset = "0xDA9688", VA = "0xDA9688")]
		public FunctionDefinitionExpression(ScriptLoadingContext lcontext, bool pushSelfParam, bool isLambda)
		{
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0xDAFA1C", Offset = "0xDAFA1C", VA = "0xDAFA1C")]
		private FunctionDefinitionExpression(ScriptLoadingContext lcontext, bool pushSelfParam, bool usesGlobalEnv, bool isLambda)
		{
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0xDB01C0", Offset = "0xDB01C0", VA = "0xDB01C0")]
		private Statement CreateLambdaBody(ScriptLoadingContext lcontext)
		{
			return null;
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0xDB028C", Offset = "0xDB028C", VA = "0xDB028C")]
		private Statement CreateBody(ScriptLoadingContext lcontext)
		{
			return null;
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0xDAFCCC", Offset = "0xDAFCCC", VA = "0xDAFCCC")]
		private List<string> BuildParamList(ScriptLoadingContext lcontext, bool pushSelfParam, Token openBracketToken, bool isLambda)
		{
			return null;
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0xDAFFA0", Offset = "0xDAFFA0", VA = "0xDAFFA0")]
		private SymbolRef[] DefineArguments(List<string> paramnames, ScriptLoadingContext lcontext)
		{
			return null;
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0xDB0458", Offset = "0xDB0458", VA = "0xDB0458", Slot = "8")]
		public SymbolRef CreateUpvalue(BuildTimeScope scope, SymbolRef symbol)
		{
			return null;
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0xDB0604", Offset = "0xDB0604", VA = "0xDB0604", Slot = "6")]
		public override DynValue Eval(ScriptExecutionContext context)
		{
			return null;
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0xDAD540", Offset = "0xDAD540", VA = "0xDAD540")]
		public int CompileBody(ByteCode bc, string friendlyName)
		{
			return default(int);
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0xDA9A64", Offset = "0xDA9A64", VA = "0xDA9A64")]
		public int Compile(ByteCode bc, Func<int> afterDecl, string friendlyName)
		{
			return default(int);
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0xDB0654", Offset = "0xDB0654", VA = "0xDB0654", Slot = "4")]
		public override void Compile(ByteCode bc)
		{
		}
	}
	[Token(Token = "0x2000075")]
	internal class IndexExpression : Expression, IVariable
	{
		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Expression m_BaseExp;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Expression m_IndexExp;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string m_Name;

		[Token(Token = "0x600033D")]
		[Address(RVA = "0xDB07B8", Offset = "0xDB07B8", VA = "0xDB07B8")]
		public IndexExpression(Expression baseExp, Expression indexExp, ScriptLoadingContext lcontext)
		{
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0xDB07E8", Offset = "0xDB07E8", VA = "0xDB07E8")]
		public IndexExpression(Expression baseExp, string name, ScriptLoadingContext lcontext)
		{
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0xDB081C", Offset = "0xDB081C", VA = "0xDB081C", Slot = "4")]
		public override void Compile(ByteCode bc)
		{
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0xDB0988", Offset = "0xDB0988", VA = "0xDB0988", Slot = "8")]
		public void CompileAssignment(ByteCode bc, int stackofs, int tupleidx)
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0xDB0B1C", Offset = "0xDB0B1C", VA = "0xDB0B1C", Slot = "6")]
		public override DynValue Eval(ScriptExecutionContext context)
		{
			return null;
		}
	}
	[Token(Token = "0x2000076")]
	internal class LiteralExpression : Expression
	{
		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private DynValue m_Value;

		[Token(Token = "0x17000091")]
		public DynValue Value
		{
			[Token(Token = "0x6000342")]
			[Address(RVA = "0xDB0CF4", Offset = "0xDB0CF4", VA = "0xDB0CF4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0xDA8C0C", Offset = "0xDA8C0C", VA = "0xDA8C0C")]
		public LiteralExpression(ScriptLoadingContext lcontext, DynValue value)
		{
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0xDAF36C", Offset = "0xDAF36C", VA = "0xDAF36C")]
		public LiteralExpression(ScriptLoadingContext lcontext, Token t)
		{
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0xDB0CFC", Offset = "0xDB0CFC", VA = "0xDB0CFC", Slot = "4")]
		public override void Compile(ByteCode bc)
		{
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0xDB0D20", Offset = "0xDB0D20", VA = "0xDB0D20", Slot = "6")]
		public override DynValue Eval(ScriptExecutionContext context)
		{
			return null;
		}
	}
	[Token(Token = "0x2000077")]
	internal class SymbolRefExpression : Expression, IVariable
	{
		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private SymbolRef m_Ref;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string m_VarName;

		[Token(Token = "0x6000347")]
		[Address(RVA = "0xDB0D28", Offset = "0xDB0D28", VA = "0xDB0D28")]
		public SymbolRefExpression(Token T, ScriptLoadingContext lcontext)
		{
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0xDA8888", Offset = "0xDA8888", VA = "0xDA8888")]
		public SymbolRefExpression(ScriptLoadingContext lcontext, SymbolRef refr)
		{
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0xDB0E8C", Offset = "0xDB0E8C", VA = "0xDB0E8C", Slot = "4")]
		public override void Compile(ByteCode bc)
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0xDB0EB0", Offset = "0xDB0EB0", VA = "0xDB0EB0", Slot = "8")]
		public void CompileAssignment(ByteCode bc, int stackofs, int tupleidx)
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0xDB0ED4", Offset = "0xDB0ED4", VA = "0xDB0ED4", Slot = "6")]
		public override DynValue Eval(ScriptExecutionContext context)
		{
			return null;
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0xDB0EF8", Offset = "0xDB0EF8", VA = "0xDB0EF8", Slot = "7")]
		public override SymbolRef FindDynamic(ScriptExecutionContext context)
		{
			return null;
		}
	}
	[Token(Token = "0x2000078")]
	internal class TableConstructor : Expression
	{
		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool m_Shared;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<Expression> m_PositionalValues;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<KeyValuePair<Expression, Expression>> m_CtorArgs;

		[Token(Token = "0x600034D")]
		[Address(RVA = "0xDAF668", Offset = "0xDAF668", VA = "0xDAF668")]
		public TableConstructor(ScriptLoadingContext lcontext, bool shared)
		{
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0xDB1170", Offset = "0xDB1170", VA = "0xDB1170")]
		private void MapField(ScriptLoadingContext lcontext)
		{
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0xDB0F1C", Offset = "0xDB0F1C", VA = "0xDB0F1C")]
		private void StructField(ScriptLoadingContext lcontext)
		{
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0xDB10B8", Offset = "0xDB10B8", VA = "0xDB10B8")]
		private void ArrayField(ScriptLoadingContext lcontext)
		{
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0xDB12A4", Offset = "0xDB12A4", VA = "0xDB12A4", Slot = "4")]
		public override void Compile(ByteCode bc)
		{
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0xDB1500", Offset = "0xDB1500", VA = "0xDB1500", Slot = "6")]
		public override DynValue Eval(ScriptExecutionContext context)
		{
			return null;
		}
	}
	[Token(Token = "0x2000079")]
	internal class UnaryOperatorExpression : Expression
	{
		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Expression m_Exp;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string m_OpText;

		[Token(Token = "0x6000353")]
		[Address(RVA = "0xDB18AC", Offset = "0xDB18AC", VA = "0xDB18AC")]
		public UnaryOperatorExpression(ScriptLoadingContext lcontext, Expression subExpression, Token unaryOpToken)
		{
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0xDB18E4", Offset = "0xDB18E4", VA = "0xDB18E4", Slot = "4")]
		public override void Compile(ByteCode bc)
		{
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0xDB1A68", Offset = "0xDB1A68", VA = "0xDB1A68", Slot = "6")]
		public override DynValue Eval(ScriptExecutionContext context)
		{
			return null;
		}
	}
}
namespace MoonSharp.Interpreter.Serialization
{
	[Token(Token = "0x200007A")]
	public static class ObjectValueConverter
	{
		[Token(Token = "0x6000356")]
		[Address(RVA = "0xDB1CEC", Offset = "0xDB1CEC", VA = "0xDB1CEC")]
		public static DynValue SerializeObjectToDynValue(Script script, object o, [Optional] DynValue valueForNulls)
		{
			return null;
		}
	}
	[Token(Token = "0x200007B")]
	public static class SerializationExtensions
	{
		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static HashSet<string> LUAKEYWORDS;

		[Token(Token = "0x6000357")]
		[Address(RVA = "0xDB2390", Offset = "0xDB2390", VA = "0xDB2390")]
		public static string Serialize(this Table table, bool prefixReturn = false, int tabs = 0)
		{
			return null;
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0xDB2990", Offset = "0xDB2990", VA = "0xDB2990")]
		private static bool IsStringIdentifierValid(DynValue dynValue)
		{
			return default(bool);
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0xDB2B60", Offset = "0xDB2B60", VA = "0xDB2B60")]
		public static string SerializeValue(this DynValue dynValue, int tabs = 0)
		{
			return null;
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0xDB2DC8", Offset = "0xDB2DC8", VA = "0xDB2DC8")]
		private static string EscapeString(string s)
		{
			return null;
		}
	}
}
namespace MoonSharp.Interpreter.Serialization.Json
{
	[Token(Token = "0x200007C")]
	public sealed class JsonNull
	{
		[Token(Token = "0x600035C")]
		[Address(RVA = "0xDB343C", Offset = "0xDB343C", VA = "0xDB343C")]
		public static bool isNull()
		{
			return default(bool);
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0xDB3444", Offset = "0xDB3444", VA = "0xDB3444")]
		[MoonSharpHidden]
		public static bool IsJsonNull(DynValue v)
		{
			return default(bool);
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0xDB3590", Offset = "0xDB3590", VA = "0xDB3590")]
		[MoonSharpHidden]
		public static DynValue Create()
		{
			return null;
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0xDB35F4", Offset = "0xDB35F4", VA = "0xDB35F4")]
		public JsonNull()
		{
		}
	}
	[Token(Token = "0x200007D")]
	public static class JsonTableConverter
	{
		[Token(Token = "0x6000360")]
		[Address(RVA = "0xDB35FC", Offset = "0xDB35FC", VA = "0xDB35FC")]
		public static string TableToJson(this Table table)
		{
			return null;
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0xDB3670", Offset = "0xDB3670", VA = "0xDB3670")]
		private static void TableToJson(StringBuilder sb, Table table)
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0xDB3CE8", Offset = "0xDB3CE8", VA = "0xDB3CE8")]
		public static string ObjectToJson(object obj)
		{
			return null;
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0xDB3B84", Offset = "0xDB3B84", VA = "0xDB3B84")]
		private static void ValueToJson(StringBuilder sb, DynValue value)
		{
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0xDB3D1C", Offset = "0xDB3D1C", VA = "0xDB3D1C")]
		private static string EscapeString(string s)
		{
			return null;
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0xDB3B20", Offset = "0xDB3B20", VA = "0xDB3B20")]
		private static bool IsValueJsonCompatible(DynValue value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0xDB3F40", Offset = "0xDB3F40", VA = "0xDB3F40")]
		public static Table JsonToTable(string json, [Optional] Script script)
		{
			return null;
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0xDB42E4", Offset = "0xDB42E4", VA = "0xDB42E4")]
		private static void AssertToken(Lexer L, TokenType type)
		{
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0xDB4200", Offset = "0xDB4200", VA = "0xDB4200")]
		private static Table ParseJsonArray(Lexer L, Script script)
		{
			return null;
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0xDB40D4", Offset = "0xDB40D4", VA = "0xDB40D4")]
		private static Table ParseJsonObject(Lexer L, Script script)
		{
			return null;
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0xDB43EC", Offset = "0xDB43EC", VA = "0xDB43EC")]
		private static DynValue ParseJsonValue(Lexer L, Script script)
		{
			return null;
		}
	}
}
namespace MoonSharp.Interpreter.REPL
{
	[Token(Token = "0x200007E")]
	internal static class NamespaceDoc
	{
	}
	[Token(Token = "0x200007F")]
	public class ReplHistoryInterpreter : ReplInterpreter
	{
		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string[] m_History;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int m_Last;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int m_Navi;

		[Token(Token = "0x600036B")]
		[Address(RVA = "0xDB476C", Offset = "0xDB476C", VA = "0xDB476C")]
		public ReplHistoryInterpreter(Script script, int historySize)
		{
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0xDB484C", Offset = "0xDB484C", VA = "0xDB484C", Slot = "7")]
		public override DynValue Evaluate(string input)
		{
			return null;
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0xDB4D04", Offset = "0xDB4D04", VA = "0xDB4D04")]
		public string HistoryPrev()
		{
			return null;
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0xDB4D74", Offset = "0xDB4D74", VA = "0xDB4D74")]
		public string HistoryNext()
		{
			return null;
		}
	}
	[Token(Token = "0x2000080")]
	public class ReplInterpreter
	{
		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Script m_Script;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string m_CurrentCommand;

		[Token(Token = "0x17000092")]
		public bool HandleDynamicExprs
		{
			[Token(Token = "0x6000370")]
			[Address(RVA = "0xDB4DCC", Offset = "0xDB4DCC", VA = "0xDB4DCC")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000371")]
			[Address(RVA = "0xDB4DD4", Offset = "0xDB4DD4", VA = "0xDB4DD4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000093")]
		public bool HandleClassicExprsSyntax
		{
			[Token(Token = "0x6000372")]
			[Address(RVA = "0xDB4DE0", Offset = "0xDB4DE0", VA = "0xDB4DE0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000373")]
			[Address(RVA = "0xDB4DE8", Offset = "0xDB4DE8", VA = "0xDB4DE8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000094")]
		public virtual bool HasPendingCommand
		{
			[Token(Token = "0x6000374")]
			[Address(RVA = "0xDB4DF4", Offset = "0xDB4DF4", VA = "0xDB4DF4", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000095")]
		public virtual string CurrentPendingCommand
		{
			[Token(Token = "0x6000375")]
			[Address(RVA = "0xDB4E18", Offset = "0xDB4E18", VA = "0xDB4E18", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000096")]
		public virtual string ClassicPrompt
		{
			[Token(Token = "0x6000376")]
			[Address(RVA = "0xDB4E20", Offset = "0xDB4E20", VA = "0xDB4E20", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0xDB47E0", Offset = "0xDB47E0", VA = "0xDB47E0")]
		public ReplInterpreter(Script script)
		{
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0xDB48E0", Offset = "0xDB48E0", VA = "0xDB48E0", Slot = "7")]
		public virtual DynValue Evaluate(string input)
		{
			return null;
		}
	}
	[Token(Token = "0x2000081")]
	public class ReplInterpreterScriptLoader : FileSystemScriptLoader
	{
		[Token(Token = "0x6000378")]
		[Address(RVA = "0xDB4E98", Offset = "0xDB4E98", VA = "0xDB4E98")]
		public ReplInterpreterScriptLoader()
		{
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0xDB5208", Offset = "0xDB5208", VA = "0xDB5208", Slot = "10")]
		public override string ResolveModuleName(string modname, Table globalContext)
		{
			return null;
		}
	}
}
namespace MoonSharp.Interpreter.Platforms
{
	[Token(Token = "0x2000082")]
	internal static class NamespaceDoc
	{
	}
	[Token(Token = "0x2000083")]
	public interface IPlatformAccessor
	{
		[Token(Token = "0x600037A")]
		CoreModules FilterSupportedCoreModules(CoreModules module);

		[Token(Token = "0x600037B")]
		string GetEnvironmentVariable(string envvarname);

		[Token(Token = "0x600037C")]
		bool IsRunningOnAOT();

		[Token(Token = "0x600037D")]
		string GetPlatformName();

		[Token(Token = "0x600037E")]
		void DefaultPrint(string content);

		[Token(Token = "0x600037F")]
		string DefaultInput(string prompt);

		[Token(Token = "0x6000380")]
		Stream IO_OpenFile(Script script, string filename, Encoding encoding, string mode);

		[Token(Token = "0x6000381")]
		Stream IO_GetStandardStream(StandardFileType type);

		[Token(Token = "0x6000382")]
		string IO_OS_GetTempFilename();

		[Token(Token = "0x6000383")]
		void OS_ExitFast(int exitCode);

		[Token(Token = "0x6000384")]
		bool OS_FileExists(string file);

		[Token(Token = "0x6000385")]
		void OS_FileDelete(string file);

		[Token(Token = "0x6000386")]
		void OS_FileMove(string src, string dst);

		[Token(Token = "0x6000387")]
		int OS_Execute(string cmdline);
	}
	[Token(Token = "0x2000084")]
	public class LimitedPlatformAccessor : PlatformAccessorBase
	{
		[Token(Token = "0x6000388")]
		[Address(RVA = "0xDB5368", Offset = "0xDB5368", VA = "0xDB5368", Slot = "31")]
		public override string GetEnvironmentVariable(string envvarname)
		{
			return null;
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0xDB5370", Offset = "0xDB5370", VA = "0xDB5370", Slot = "30")]
		public override CoreModules FilterSupportedCoreModules(CoreModules module)
		{
			return default(CoreModules);
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0xDB5378", Offset = "0xDB5378", VA = "0xDB5378", Slot = "22")]
		public override Stream IO_OpenFile(Script script, string filename, Encoding encoding, string mode)
		{
			return null;
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0xDB53C8", Offset = "0xDB53C8", VA = "0xDB53C8", Slot = "23")]
		public override Stream IO_GetStandardStream(StandardFileType type)
		{
			return null;
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0xDB5418", Offset = "0xDB5418", VA = "0xDB5418", Slot = "24")]
		public override string IO_OS_GetTempFilename()
		{
			return null;
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0xDB5468", Offset = "0xDB5468", VA = "0xDB5468", Slot = "25")]
		public override void OS_ExitFast(int exitCode)
		{
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0xDB54B8", Offset = "0xDB54B8", VA = "0xDB54B8", Slot = "26")]
		public override bool OS_FileExists(string file)
		{
			return default(bool);
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0xDB5508", Offset = "0xDB5508", VA = "0xDB5508", Slot = "27")]
		public override void OS_FileDelete(string file)
		{
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0xDB5558", Offset = "0xDB5558", VA = "0xDB5558", Slot = "28")]
		public override void OS_FileMove(string src, string dst)
		{
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0xDB55A8", Offset = "0xDB55A8", VA = "0xDB55A8", Slot = "29")]
		public override int OS_Execute(string cmdline)
		{
			return default(int);
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0xDB55F8", Offset = "0xDB55F8", VA = "0xDB55F8", Slot = "18")]
		public override string GetPlatformNamePrefix()
		{
			return null;
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0xDB5638", Offset = "0xDB5638", VA = "0xDB5638", Slot = "19")]
		public override void DefaultPrint(string content)
		{
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0xDB563C", Offset = "0xDB563C", VA = "0xDB563C")]
		public LimitedPlatformAccessor()
		{
		}
	}
	[Token(Token = "0x2000085")]
	public abstract class PlatformAccessorBase : IPlatformAccessor
	{
		[Token(Token = "0x6000395")]
		public abstract string GetPlatformNamePrefix();

		[Token(Token = "0x6000396")]
		[Address(RVA = "0xDB564C", Offset = "0xDB564C", VA = "0xDB564C", Slot = "7")]
		public string GetPlatformName()
		{
			return null;
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0xDB59A4", Offset = "0xDB59A4", VA = "0xDB59A4")]
		private string GetUnityRuntimeName()
		{
			return null;
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0xDB5964", Offset = "0xDB5964", VA = "0xDB5964")]
		private string GetUnityPlatformName()
		{
			return null;
		}

		[Token(Token = "0x6000399")]
		public abstract void DefaultPrint(string content);

		[Token(Token = "0x600039A")]
		[Address(RVA = "0xDB59EC", Offset = "0xDB59EC", VA = "0xDB59EC", Slot = "20")]
		[Obsolete("Replace with DefaultInput(string)")]
		public virtual string DefaultInput()
		{
			return null;
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0xDB59F4", Offset = "0xDB59F4", VA = "0xDB59F4", Slot = "21")]
		public virtual string DefaultInput(string prompt)
		{
			return null;
		}

		[Token(Token = "0x600039C")]
		public abstract Stream IO_OpenFile(Script script, string filename, Encoding encoding, string mode);

		[Token(Token = "0x600039D")]
		public abstract Stream IO_GetStandardStream(StandardFileType type);

		[Token(Token = "0x600039E")]
		public abstract string IO_OS_GetTempFilename();

		[Token(Token = "0x600039F")]
		public abstract void OS_ExitFast(int exitCode);

		[Token(Token = "0x60003A0")]
		public abstract bool OS_FileExists(string file);

		[Token(Token = "0x60003A1")]
		public abstract void OS_FileDelete(string file);

		[Token(Token = "0x60003A2")]
		public abstract void OS_FileMove(string src, string dst);

		[Token(Token = "0x60003A3")]
		public abstract int OS_Execute(string cmdline);

		[Token(Token = "0x60003A4")]
		public abstract CoreModules FilterSupportedCoreModules(CoreModules module);

		[Token(Token = "0x60003A5")]
		public abstract string GetEnvironmentVariable(string envvarname);

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0xDB5A04", Offset = "0xDB5A04", VA = "0xDB5A04", Slot = "32")]
		public virtual bool IsRunningOnAOT()
		{
			return default(bool);
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0xDB5644", Offset = "0xDB5644", VA = "0xDB5644")]
		protected PlatformAccessorBase()
		{
		}
	}
	[Token(Token = "0x2000086")]
	public static class PlatformAutoDetector
	{
		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool? m_IsRunningOnAOT;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		private static bool m_AutoDetectionsDone;

		[Token(Token = "0x17000097")]
		public static bool IsRunningOnMono
		{
			[Token(Token = "0x60003A8")]
			[Address(RVA = "0xDB5A0C", Offset = "0xDB5A0C", VA = "0xDB5A0C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003A9")]
			[Address(RVA = "0xDB5A54", Offset = "0xDB5A54", VA = "0xDB5A54")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000098")]
		public static bool IsRunningOnClr4
		{
			[Token(Token = "0x60003AA")]
			[Address(RVA = "0xDB5AA0", Offset = "0xDB5AA0", VA = "0xDB5AA0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003AB")]
			[Address(RVA = "0xDB5AE8", Offset = "0xDB5AE8", VA = "0xDB5AE8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000099")]
		public static bool IsRunningOnUnity
		{
			[Token(Token = "0x60003AC")]
			[Address(RVA = "0xDB5B34", Offset = "0xDB5B34", VA = "0xDB5B34")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003AD")]
			[Address(RVA = "0xDB5B7C", Offset = "0xDB5B7C", VA = "0xDB5B7C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700009A")]
		public static bool IsPortableFramework
		{
			[Token(Token = "0x60003AE")]
			[Address(RVA = "0xDB5BC8", Offset = "0xDB5BC8", VA = "0xDB5BC8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003AF")]
			[Address(RVA = "0xDB5C10", Offset = "0xDB5C10", VA = "0xDB5C10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700009B")]
		public static bool IsUnityNative
		{
			[Token(Token = "0x60003B0")]
			[Address(RVA = "0xDB5C5C", Offset = "0xDB5C5C", VA = "0xDB5C5C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003B1")]
			[Address(RVA = "0xDB5CA4", Offset = "0xDB5CA4", VA = "0xDB5CA4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700009C")]
		public static bool IsUnityIL2CPP
		{
			[Token(Token = "0x60003B2")]
			[Address(RVA = "0xDB5CF0", Offset = "0xDB5CF0", VA = "0xDB5CF0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003B3")]
			[Address(RVA = "0xDB5D38", Offset = "0xDB5D38", VA = "0xDB5D38")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700009D")]
		public static bool IsRunningOnAOT
		{
			[Token(Token = "0x60003B4")]
			[Address(RVA = "0xDB59E4", Offset = "0xDB59E4", VA = "0xDB59E4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0xDB5D84", Offset = "0xDB5D84", VA = "0xDB5D84")]
		private static void AutoDetectPlatformFlags()
		{
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0xDB60C8", Offset = "0xDB60C8", VA = "0xDB60C8")]
		internal static IPlatformAccessor GetDefaultPlatform()
		{
			return null;
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0xDB617C", Offset = "0xDB617C", VA = "0xDB617C")]
		internal static IScriptLoader GetDefaultScriptLoader()
		{
			return null;
		}
	}
	[Token(Token = "0x2000088")]
	public enum StandardFileType
	{
		[Token(Token = "0x40001E9")]
		StdIn,
		[Token(Token = "0x40001EA")]
		StdOut,
		[Token(Token = "0x40001EB")]
		StdErr
	}
	[Token(Token = "0x2000089")]
	public class StandardPlatformAccessor : PlatformAccessorBase
	{
		[Token(Token = "0x60003BC")]
		[Address(RVA = "0xDB6504", Offset = "0xDB6504", VA = "0xDB6504")]
		public static FileAccess ParseFileAccess(string mode)
		{
			return default(FileAccess);
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0xDB6624", Offset = "0xDB6624", VA = "0xDB6624")]
		public static FileMode ParseFileMode(string mode)
		{
			return default(FileMode);
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0xDB6754", Offset = "0xDB6754", VA = "0xDB6754", Slot = "22")]
		public override Stream IO_OpenFile(Script script, string filename, Encoding encoding, string mode)
		{
			return null;
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0xDB67EC", Offset = "0xDB67EC", VA = "0xDB67EC", Slot = "31")]
		public override string GetEnvironmentVariable(string envvarname)
		{
			return null;
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0xDB67F8", Offset = "0xDB67F8", VA = "0xDB67F8", Slot = "23")]
		public override Stream IO_GetStandardStream(StandardFileType type)
		{
			return null;
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0xDB68EC", Offset = "0xDB68EC", VA = "0xDB68EC", Slot = "19")]
		public override void DefaultPrint(string content)
		{
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0xDB6944", Offset = "0xDB6944", VA = "0xDB6944", Slot = "24")]
		public override string IO_OS_GetTempFilename()
		{
			return null;
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0xDB6994", Offset = "0xDB6994", VA = "0xDB6994", Slot = "25")]
		public override void OS_ExitFast(int exitCode)
		{
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0xDB69A0", Offset = "0xDB69A0", VA = "0xDB69A0", Slot = "26")]
		public override bool OS_FileExists(string file)
		{
			return default(bool);
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0xDB69AC", Offset = "0xDB69AC", VA = "0xDB69AC", Slot = "27")]
		public override void OS_FileDelete(string file)
		{
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0xDB69B8", Offset = "0xDB69B8", VA = "0xDB69B8", Slot = "28")]
		public override void OS_FileMove(string src, string dst)
		{
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0xDB69C8", Offset = "0xDB69C8", VA = "0xDB69C8", Slot = "29")]
		public override int OS_Execute(string cmdline)
		{
			return default(int);
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0xDB6A9C", Offset = "0xDB6A9C", VA = "0xDB6A9C", Slot = "30")]
		public override CoreModules FilterSupportedCoreModules(CoreModules module)
		{
			return default(CoreModules);
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0xDB6AA4", Offset = "0xDB6AA4", VA = "0xDB6AA4", Slot = "18")]
		public override string GetPlatformNamePrefix()
		{
			return null;
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0xDB6174", Offset = "0xDB6174", VA = "0xDB6174")]
		public StandardPlatformAccessor()
		{
		}
	}
}
namespace MoonSharp.Interpreter.Loaders
{
	[Token(Token = "0x200008A")]
	public class EmbeddedResourcesScriptLoader : ScriptLoaderBase
	{
		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Assembly m_ResourceAssembly;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private HashSet<string> m_ResourceNames;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string m_Namespace;

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0xDB6AE4", Offset = "0xDB6AE4", VA = "0xDB6AE4")]
		public EmbeddedResourcesScriptLoader([Optional] Assembly resourceAssembly)
		{
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0xDB6C04", Offset = "0xDB6C04", VA = "0xDB6C04")]
		private string FileNameToResource(string file)
		{
			return null;
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0xDB6C8C", Offset = "0xDB6C8C", VA = "0xDB6C8C", Slot = "7")]
		public override bool ScriptFileExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0xDB6CF4", Offset = "0xDB6CF4", VA = "0xDB6CF4", Slot = "8")]
		public override object LoadFile(string file, Table globalContext)
		{
			return null;
		}
	}
	[Token(Token = "0x200008B")]
	public class FileSystemScriptLoader : ScriptLoaderBase
	{
		[Token(Token = "0x60003CF")]
		[Address(RVA = "0xDB6D28", Offset = "0xDB6D28", VA = "0xDB6D28", Slot = "7")]
		public override bool ScriptFileExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0xDB6D34", Offset = "0xDB6D34", VA = "0xDB6D34", Slot = "8")]
		public override object LoadFile(string file, Table globalContext)
		{
			return null;
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0xDB4FD4", Offset = "0xDB4FD4", VA = "0xDB4FD4")]
		public FileSystemScriptLoader()
		{
		}
	}
	[Token(Token = "0x200008C")]
	internal class InvalidScriptLoader : IScriptLoader
	{
		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string m_Error;

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0xDB6DA4", Offset = "0xDB6DA4", VA = "0xDB6DA4")]
		internal InvalidScriptLoader(string frameworkname)
		{
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0xDB6E10", Offset = "0xDB6E10", VA = "0xDB6E10", Slot = "4")]
		public object LoadFile(string file, Table globalContext)
		{
			return null;
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0xDB6E5C", Offset = "0xDB6E5C", VA = "0xDB6E5C", Slot = "5")]
		public string ResolveFileName(string filename, Table globalContext)
		{
			return null;
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0xDB6E64", Offset = "0xDB6E64", VA = "0xDB6E64", Slot = "6")]
		public string ResolveModuleName(string modname, Table globalContext)
		{
			return null;
		}
	}
	[Token(Token = "0x200008D")]
	public interface IScriptLoader
	{
		[Token(Token = "0x60003D6")]
		object LoadFile(string file, Table globalContext);

		[Token(Token = "0x60003D7")]
		[Obsolete("This serves almost no purpose. Kept here just to preserve backward compatibility.")]
		string ResolveFileName(string filename, Table globalContext);

		[Token(Token = "0x60003D8")]
		string ResolveModuleName(string modname, Table globalContext);
	}
	[Token(Token = "0x200008E")]
	public abstract class ScriptLoaderBase : IScriptLoader
	{
		[Token(Token = "0x1700009E")]
		public string[] ModulePaths
		{
			[Token(Token = "0x60003DD")]
			[Address(RVA = "0xDB6F98", Offset = "0xDB6F98", VA = "0xDB6F98")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60003DE")]
			[Address(RVA = "0xDB6FA0", Offset = "0xDB6FA0", VA = "0xDB6FA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700009F")]
		public bool IgnoreLuaPathGlobal
		{
			[Token(Token = "0x60003E2")]
			[Address(RVA = "0xDB7208", Offset = "0xDB7208", VA = "0xDB7208")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003E3")]
			[Address(RVA = "0xDB7210", Offset = "0xDB7210", VA = "0xDB7210")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x60003D9")]
		public abstract bool ScriptFileExists(string name);

		[Token(Token = "0x60003DA")]
		public abstract object LoadFile(string file, Table globalContext);

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0xDB6EB0", Offset = "0xDB6EB0", VA = "0xDB6EB0", Slot = "9")]
		protected virtual string ResolveModuleName(string modname, string[] paths)
		{
			return null;
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0xDB52BC", Offset = "0xDB52BC", VA = "0xDB52BC", Slot = "10")]
		public virtual string ResolveModuleName(string modname, Table globalContext)
		{
			return null;
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0xDB4FDC", Offset = "0xDB4FDC", VA = "0xDB4FDC")]
		public static string[] UnpackStringPaths(string str)
		{
			return null;
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0xDB6FA8", Offset = "0xDB6FA8", VA = "0xDB6FA8")]
		public static string[] GetDefaultEnvironmentPaths()
		{
			return null;
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0xDB7200", Offset = "0xDB7200", VA = "0xDB7200", Slot = "11")]
		public virtual string ResolveFileName(string filename, Table globalContext)
		{
			return null;
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0xDB6BFC", Offset = "0xDB6BFC", VA = "0xDB6BFC")]
		protected ScriptLoaderBase()
		{
		}
	}
	[Token(Token = "0x2000090")]
	public class UnityAssetsScriptLoader : ScriptLoaderBase
	{
		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Dictionary<string, string> m_Resources;

		[Token(Token = "0x40001F6")]
		public const string DEFAULT_PATH = "MoonSharp/Scripts";

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0xDB623C", Offset = "0xDB623C", VA = "0xDB623C")]
		public UnityAssetsScriptLoader([Optional] string assetsPath)
		{
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0xDB79F0", Offset = "0xDB79F0", VA = "0xDB79F0")]
		public UnityAssetsScriptLoader(Dictionary<string, string> scriptToCodeMap)
		{
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0xDB72C0", Offset = "0xDB72C0", VA = "0xDB72C0")]
		private void LoadResourcesWithReflection(string assetsPath)
		{
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0xDB7A80", Offset = "0xDB7A80", VA = "0xDB7A80")]
		private string GetFileName(string filename)
		{
			return null;
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0xDB7B38", Offset = "0xDB7B38", VA = "0xDB7B38", Slot = "8")]
		public override object LoadFile(string file, Table globalContext)
		{
			return null;
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0xDB7C40", Offset = "0xDB7C40", VA = "0xDB7C40", Slot = "7")]
		public override bool ScriptFileExists(string file)
		{
			return default(bool);
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0xDB7CA4", Offset = "0xDB7CA4", VA = "0xDB7CA4")]
		public string[] GetLoadedScripts()
		{
			return null;
		}
	}
	[Token(Token = "0x2000091")]
	internal static class NamespaceDoc
	{
	}
}
namespace MoonSharp.Interpreter.IO
{
	[Token(Token = "0x2000092")]
	public class BinDumpBinaryReader : BinaryReader
	{
		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<string> m_Strings;

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0xDB7D10", Offset = "0xDB7D10", VA = "0xDB7D10")]
		public BinDumpBinaryReader(Stream s)
		{
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0xDB7D9C", Offset = "0xDB7D9C", VA = "0xDB7D9C")]
		public BinDumpBinaryReader(Stream s, Encoding e)
		{
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0xDB7E30", Offset = "0xDB7E30", VA = "0xDB7E30", Slot = "15")]
		public override int ReadInt32()
		{
			return default(int);
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0xDB7E84", Offset = "0xDB7E84", VA = "0xDB7E84", Slot = "16")]
		public override uint ReadUInt32()
		{
			return default(uint);
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0xDB7ED4", Offset = "0xDB7ED4", VA = "0xDB7ED4", Slot = "22")]
		public override string ReadString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000093")]
	public class BinDumpBinaryWriter : BinaryWriter
	{
		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Dictionary<string, int> m_StringMap;

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0xDB803C", Offset = "0xDB803C", VA = "0xDB803C")]
		public BinDumpBinaryWriter(Stream s)
		{
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0xDB80EC", Offset = "0xDB80EC", VA = "0xDB80EC")]
		public BinDumpBinaryWriter(Stream s, Encoding e)
		{
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0xDB81A4", Offset = "0xDB81A4", VA = "0xDB81A4", Slot = "19")]
		public override void Write(uint value)
		{
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0xDB8238", Offset = "0xDB8238", VA = "0xDB8238", Slot = "18")]
		public override void Write(int value)
		{
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0xDB82D4", Offset = "0xDB82D4", VA = "0xDB82D4", Slot = "23")]
		public override void Write(string value)
		{
		}
	}
	[Token(Token = "0x2000094")]
	public class UndisposableStream : Stream
	{
		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Stream m_Stream;

		[Token(Token = "0x170000A0")]
		public override bool CanRead
		{
			[Token(Token = "0x60003FD")]
			[Address(RVA = "0xDB8478", Offset = "0xDB8478", VA = "0xDB8478", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A1")]
		public override bool CanSeek
		{
			[Token(Token = "0x60003FE")]
			[Address(RVA = "0xDB8498", Offset = "0xDB8498", VA = "0xDB8498", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A2")]
		public override bool CanWrite
		{
			[Token(Token = "0x60003FF")]
			[Address(RVA = "0xDB84B8", Offset = "0xDB84B8", VA = "0xDB84B8", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A3")]
		public override long Length
		{
			[Token(Token = "0x6000401")]
			[Address(RVA = "0xDB84FC", Offset = "0xDB84FC", VA = "0xDB84FC", Slot = "11")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x170000A4")]
		public override long Position
		{
			[Token(Token = "0x6000402")]
			[Address(RVA = "0xDB851C", Offset = "0xDB851C", VA = "0xDB851C", Slot = "12")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x6000403")]
			[Address(RVA = "0xDB853C", Offset = "0xDB853C", VA = "0xDB853C", Slot = "13")]
			set
			{
			}
		}

		[Token(Token = "0x170000A5")]
		public override bool CanTimeout
		{
			[Token(Token = "0x600040C")]
			[Address(RVA = "0xDB8680", Offset = "0xDB8680", VA = "0xDB8680", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A6")]
		public override int ReadTimeout
		{
			[Token(Token = "0x6000410")]
			[Address(RVA = "0xDB8704", Offset = "0xDB8704", VA = "0xDB8704", Slot = "14")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000411")]
			[Address(RVA = "0xDB8728", Offset = "0xDB8728", VA = "0xDB8728", Slot = "15")]
			set
			{
			}
		}

		[Token(Token = "0x170000A7")]
		public override int WriteTimeout
		{
			[Token(Token = "0x6000414")]
			[Address(RVA = "0xDB8790", Offset = "0xDB8790", VA = "0xDB8790", Slot = "16")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000415")]
			[Address(RVA = "0xDB87B4", Offset = "0xDB87B4", VA = "0xDB87B4", Slot = "17")]
			set
			{
			}
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0xDB8404", Offset = "0xDB8404", VA = "0xDB8404")]
		public UndisposableStream(Stream stream)
		{
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0xDB8470", Offset = "0xDB8470", VA = "0xDB8470", Slot = "20")]
		protected override void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0xDB8474", Offset = "0xDB8474", VA = "0xDB8474", Slot = "19")]
		public override void Close()
		{
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0xDB84D8", Offset = "0xDB84D8", VA = "0xDB84D8", Slot = "21")]
		public override void Flush()
		{
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0xDB8560", Offset = "0xDB8560", VA = "0xDB8560", Slot = "33")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return default(int);
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0xDB8584", Offset = "0xDB8584", VA = "0xDB8584", Slot = "31")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return default(long);
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0xDB85A8", Offset = "0xDB85A8", VA = "0xDB85A8", Slot = "32")]
		public override void SetLength(long value)
		{
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0xDB85CC", Offset = "0xDB85CC", VA = "0xDB85CC", Slot = "36")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0xDB85F0", Offset = "0xDB85F0", VA = "0xDB85F0", Slot = "23")]
		public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			return null;
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0xDB8614", Offset = "0xDB8614", VA = "0xDB8614", Slot = "27")]
		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			return null;
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0xDB8638", Offset = "0xDB8638", VA = "0xDB8638", Slot = "28")]
		public override void EndWrite(IAsyncResult asyncResult)
		{
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0xDB865C", Offset = "0xDB865C", VA = "0xDB865C", Slot = "24")]
		public override int EndRead(IAsyncResult asyncResult)
		{
			return default(int);
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0xDB86A0", Offset = "0xDB86A0", VA = "0xDB86A0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0xDB86C0", Offset = "0xDB86C0", VA = "0xDB86C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0xDB86E0", Offset = "0xDB86E0", VA = "0xDB86E0", Slot = "35")]
		public override int ReadByte()
		{
			return default(int);
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0xDB874C", Offset = "0xDB874C", VA = "0xDB874C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0xDB876C", Offset = "0xDB876C", VA = "0xDB876C", Slot = "38")]
		public override void WriteByte(byte value)
		{
		}
	}
}
namespace MoonSharp.Interpreter.Interop
{
	[Token(Token = "0x2000095")]
	[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event, Inherited = true, AllowMultiple = false)]
	public sealed class MoonSharpVisibleAttribute : Attribute
	{
		[Token(Token = "0x170000A8")]
		public bool Visible
		{
			[Token(Token = "0x6000416")]
			[Address(RVA = "0xDB87D8", Offset = "0xDB87D8", VA = "0xDB87D8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000417")]
			[Address(RVA = "0xDB87E0", Offset = "0xDB87E0", VA = "0xDB87E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0xDB87EC", Offset = "0xDB87EC", VA = "0xDB87EC")]
		public MoonSharpVisibleAttribute(bool visible)
		{
		}
	}
	[Token(Token = "0x2000096")]
	public class CustomConvertersCollection
	{
		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Dictionary<Type, Func<DynValue, object>>[] m_Script2Clr;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Dictionary<Type, Func<Script, object, DynValue>> m_Clr2Script;

		[Token(Token = "0x6000419")]
		[Address(RVA = "0xDB8818", Offset = "0xDB8818", VA = "0xDB8818")]
		internal CustomConvertersCollection()
		{
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0xDB8968", Offset = "0xDB8968", VA = "0xDB8968")]
		public void SetScriptToClrCustomConversion(DataType scriptDataType, Type clrDataType, [Optional] Func<DynValue, object> converter)
		{
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0xDB8AB0", Offset = "0xDB8AB0", VA = "0xDB8AB0")]
		public Func<DynValue, object> GetScriptToClrCustomConversion(DataType scriptDataType, Type clrDataType)
		{
			return null;
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0xDB8B44", Offset = "0xDB8B44", VA = "0xDB8B44")]
		public void SetClrToScriptCustomConversion(Type clrDataType, [Optional] Func<Script, object, DynValue> converter)
		{
		}

		[Token(Token = "0x600041D")]
		public void SetClrToScriptCustomConversion<T>([Optional] Func<Script, T, DynValue> converter)
		{
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0xDB8C18", Offset = "0xDB8C18", VA = "0xDB8C18")]
		public Func<Script, object, DynValue> GetClrToScriptCustomConversion(Type clrDataType)
		{
			return null;
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0xDB8C70", Offset = "0xDB8C70", VA = "0xDB8C70")]
		[Obsolete("This method is deprecated. Use the overloads accepting functions with a Script argument.")]
		public void SetClrToScriptCustomConversion(Type clrDataType, [Optional] Func<object, DynValue> converter)
		{
		}

		[Token(Token = "0x6000420")]
		[Obsolete("This method is deprecated. Use the overloads accepting functions with a Script argument.")]
		public void SetClrToScriptCustomConversion<T>([Optional] Func<T, DynValue> converter)
		{
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0xDB8D3C", Offset = "0xDB8D3C", VA = "0xDB8D3C")]
		public void Clear()
		{
		}
	}
	[Token(Token = "0x200009A")]
	public static class DescriptorHelpers
	{
		[Token(Token = "0x200009C")]
		[CompilerGenerated]
		private sealed class <GetAllImplementedTypes>d__10 : IEnumerable<Type>, IEnumerable, IEnumerator<Type>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000202")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000203")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Type <>2__current;

			[Token(Token = "0x4000204")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x4000205")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Type t;

			[Token(Token = "0x4000206")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Type <>3__t;

			[Token(Token = "0x4000207")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Type <ot>5__2;

			[Token(Token = "0x4000208")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Type[] <>7__wrap2;

			[Token(Token = "0x4000209")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private int <>7__wrap3;

			[Token(Token = "0x170000A9")]
			private Type System.Collections.Generic.IEnumerator<System.Type>.Current
			{
				[Token(Token = "0x600043D")]
				[Address(RVA = "0xDBA2F4", Offset = "0xDBA2F4", VA = "0xDBA2F4", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AA")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600043F")]
				[Address(RVA = "0xDBA33C", Offset = "0xDBA33C", VA = "0xDBA33C", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600043A")]
			[Address(RVA = "0xDB9B40", Offset = "0xDB9B40", VA = "0xDB9B40")]
			[DebuggerHidden]
			public <GetAllImplementedTypes>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x600043B")]
			[Address(RVA = "0xDBA0EC", Offset = "0xDBA0EC", VA = "0xDBA0EC", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600043C")]
			[Address(RVA = "0xDBA0F0", Offset = "0xDBA0F0", VA = "0xDBA0F0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600043E")]
			[Address(RVA = "0xDBA2FC", Offset = "0xDBA2FC", VA = "0xDBA2FC", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000440")]
			[Address(RVA = "0xDBA344", Offset = "0xDBA344", VA = "0xDBA344", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<Type> System.Collections.Generic.IEnumerable<System.Type>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000441")]
			[Address(RVA = "0xDBA3E8", Offset = "0xDBA3E8", VA = "0xDBA3E8", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0xDB8E10", Offset = "0xDB8E10", VA = "0xDB8E10")]
		public static bool? GetVisibilityFromAttributes(this MemberInfo mi)
		{
			return null;
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0xDB8FE4", Offset = "0xDB8FE4", VA = "0xDB8FE4")]
		public static bool IsDelegateType(this Type t)
		{
			return default(bool);
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0xDB90E0", Offset = "0xDB90E0", VA = "0xDB90E0")]
		public static string GetClrVisibility(this Type type)
		{
			return null;
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0xDB9234", Offset = "0xDB9234", VA = "0xDB9234")]
		public static string GetClrVisibility(this FieldInfo info)
		{
			return null;
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0xDB9358", Offset = "0xDB9358", VA = "0xDB9358")]
		public static string GetClrVisibility(this PropertyInfo info)
		{
			return null;
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0xDB954C", Offset = "0xDB954C", VA = "0xDB954C")]
		public static string GetClrVisibility(this MethodBase info)
		{
			return null;
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0xDB9670", Offset = "0xDB9670", VA = "0xDB9670")]
		public static bool IsPropertyInfoPublic(this PropertyInfo pi)
		{
			return default(bool);
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0xDB97DC", Offset = "0xDB97DC", VA = "0xDB97DC")]
		public static List<string> GetMetaNamesFromAttributes(this MethodInfo mi)
		{
			return null;
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0xDB6360", Offset = "0xDB6360", VA = "0xDB6360")]
		public static Type[] SafeGetTypes(this Assembly asm)
		{
			return null;
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0xDB9980", Offset = "0xDB9980", VA = "0xDB9980")]
		public static string GetConversionMethodName(this Type type)
		{
			return null;
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0xDB9AC8", Offset = "0xDB9AC8", VA = "0xDB9AC8")]
		[IteratorStateMachine(typeof(<GetAllImplementedTypes>d__10))]
		public static IEnumerable<Type> GetAllImplementedTypes(this Type t)
		{
			return null;
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0xDB9B74", Offset = "0xDB9B74", VA = "0xDB9B74")]
		public static bool IsValidSimpleIdentifier(string str)
		{
			return default(bool);
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0xDB9CA8", Offset = "0xDB9CA8", VA = "0xDB9CA8")]
		public static string ToValidSimpleIdentifier(string str)
		{
			return null;
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0xDB9E6C", Offset = "0xDB9E6C", VA = "0xDB9E6C")]
		public static string Camelify(string name)
		{
			return null;
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0xDB9F9C", Offset = "0xDB9F9C", VA = "0xDB9F9C")]
		public static string UpperFirstLetter(string name)
		{
			return null;
		}
	}
	[Token(Token = "0x200009D")]
	public interface IGeneratorUserDataDescriptor : IUserDataDescriptor
	{
		[Token(Token = "0x6000442")]
		IUserDataDescriptor Generate(Type type);
	}
	[Token(Token = "0x200009E")]
	public static class InteropRegistrationPolicy
	{
		[Token(Token = "0x170000AB")]
		public static IRegistrationPolicy Default
		{
			[Token(Token = "0x6000443")]
			[Address(RVA = "0xDBA3EC", Offset = "0xDBA3EC", VA = "0xDBA3EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AC")]
		[Obsolete("Please use InteropRegistrationPolicy.Default instead.")]
		public static IRegistrationPolicy Explicit
		{
			[Token(Token = "0x6000444")]
			[Address(RVA = "0xDBA448", Offset = "0xDBA448", VA = "0xDBA448")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AD")]
		public static IRegistrationPolicy Automatic
		{
			[Token(Token = "0x6000445")]
			[Address(RVA = "0xDBA4A4", Offset = "0xDBA4A4", VA = "0xDBA4A4")]
			get
			{
				return null;
			}
		}
	}
	[Token(Token = "0x200009F")]
	public interface IUserDataDescriptor
	{
		[Token(Token = "0x170000AE")]
		string Name
		{
			[Token(Token = "0x6000446")]
			get;
		}

		[Token(Token = "0x170000AF")]
		Type Type
		{
			[Token(Token = "0x6000447")]
			get;
		}

		[Token(Token = "0x6000448")]
		DynValue Index(Script script, object obj, DynValue index, bool isDirectIndexing);

		[Token(Token = "0x6000449")]
		bool SetIndex(Script script, object obj, DynValue index, DynValue value, bool isDirectIndexing);

		[Token(Token = "0x600044A")]
		string AsString(object obj);

		[Token(Token = "0x600044B")]
		DynValue MetaIndex(Script script, object obj, string metaname);

		[Token(Token = "0x600044C")]
		bool IsTypeCompatible(Type type, object obj);
	}
	[Token(Token = "0x20000A0")]
	public interface IUserDataMemberDescriptor
	{
		[Token(Token = "0x170000B0")]
		string Name
		{
			[Token(Token = "0x600044D")]
			get;
		}

		[Token(Token = "0x170000B1")]
		Type Type
		{
			[Token(Token = "0x600044E")]
			get;
		}

		[Token(Token = "0x170000B2")]
		UserDataMemberType MemberType
		{
			[Token(Token = "0x6000451")]
			get;
		}

		[Token(Token = "0x170000B3")]
		bool IsStatic
		{
			[Token(Token = "0x6000453")]
			get;
		}

		[Token(Token = "0x600044F")]
		DynValue GetValue(Script script, object obj);

		[Token(Token = "0x6000450")]
		bool SetValue(Script script, object obj, DynValue value);

		[Token(Token = "0x6000452")]
		void Optimize();
	}
	[Token(Token = "0x20000A1")]
	public interface IUserDataType
	{
		[Token(Token = "0x6000454")]
		DynValue Index(Script script, DynValue index, bool isDirectIndexing);

		[Token(Token = "0x6000455")]
		bool SetIndex(Script script, DynValue index, DynValue value, bool isDirectIndexing);

		[Token(Token = "0x6000456")]
		DynValue MetaIndex(Script script, string metaname);
	}
	[Token(Token = "0x20000A2")]
	public class AnonWrapper
	{
		[Token(Token = "0x6000457")]
		[Address(RVA = "0xDBA500", Offset = "0xDBA500", VA = "0xDBA500")]
		public AnonWrapper()
		{
		}
	}
	[Token(Token = "0x20000A3")]
	public class AnonWrapper<T> : AnonWrapper
	{
		[Token(Token = "0x170000B4")]
		public T Value
		{
			[Token(Token = "0x600045A")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Token(Token = "0x600045B")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000458")]
		public AnonWrapper()
		{
		}

		[Token(Token = "0x6000459")]
		public AnonWrapper(T o)
		{
		}
	}
	[Token(Token = "0x20000A4")]
	internal class EnumerableWrapper : IUserDataType
	{
		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IEnumerator m_Enumerator;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Script m_Script;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private DynValue m_Prev;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool m_HasTurnOnce;

		[Token(Token = "0x600045C")]
		[Address(RVA = "0xDBA508", Offset = "0xDBA508", VA = "0xDBA508")]
		private EnumerableWrapper(Script script, IEnumerator enumerator)
		{
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0xDBA5B8", Offset = "0xDBA5B8", VA = "0xDBA5B8")]
		public void Reset()
		{
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0xDBA670", Offset = "0xDBA670", VA = "0xDBA670")]
		private DynValue GetNext(DynValue prev)
		{
			return null;
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0xDBA834", Offset = "0xDBA834", VA = "0xDBA834")]
		private DynValue LuaIteratorCallback(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0xDBA850", Offset = "0xDBA850", VA = "0xDBA850")]
		internal static DynValue ConvertIterator(Script script, IEnumerator enumerator)
		{
			return null;
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0xDBAA40", Offset = "0xDBAA40", VA = "0xDBAA40")]
		internal static DynValue ConvertTable(Table table)
		{
			return null;
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0xDBAB00", Offset = "0xDBAB00", VA = "0xDBAB00", Slot = "4")]
		public DynValue Index(Script script, DynValue index, bool isDirectIndexing)
		{
			return null;
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0xDBADD4", Offset = "0xDBADD4", VA = "0xDBADD4", Slot = "5")]
		public bool SetIndex(Script script, DynValue index, DynValue value, bool isDirectIndexing)
		{
			return default(bool);
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0xDBADDC", Offset = "0xDBADDC", VA = "0xDBADDC", Slot = "6")]
		public DynValue MetaIndex(Script script, string metaname)
		{
			return null;
		}
	}
	[Token(Token = "0x20000A5")]
	public class PropertyTableAssigner<T> : IPropertyTableAssigner
	{
		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private PropertyTableAssigner m_InternalAssigner;

		[Token(Token = "0x6000467")]
		public PropertyTableAssigner(params string[] expectedMissingProperties)
		{
		}

		[Token(Token = "0x6000468")]
		public void AddExpectedMissingProperty(string name)
		{
		}

		[Token(Token = "0x6000469")]
		public void AssignObject(T obj, Table data)
		{
		}

		[Token(Token = "0x600046A")]
		public PropertyTableAssigner GetTypeUnsafeAssigner()
		{
			return null;
		}

		[Token(Token = "0x600046B")]
		public void SetSubassignerForType(Type propertyType, IPropertyTableAssigner assigner)
		{
		}

		[Token(Token = "0x600046C")]
		public void SetSubassigner<SubassignerType>(PropertyTableAssigner<SubassignerType> assigner)
		{
		}

		[Token(Token = "0x600046D")]
		private void MoonSharp.Interpreter.Interop.IPropertyTableAssigner.AssignObjectUnchecked(object o, Table data)
		{
		}
	}
	[Token(Token = "0x20000A6")]
	public class PropertyTableAssigner : IPropertyTableAssigner
	{
		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Type m_Type;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Dictionary<string, PropertyInfo> m_PropertyMap;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Dictionary<Type, IPropertyTableAssigner> m_SubAssigners;

		[Token(Token = "0x600046E")]
		[Address(RVA = "0xDBB038", Offset = "0xDBB038", VA = "0xDBB038")]
		public PropertyTableAssigner(Type type, params string[] expectedMissingProperties)
		{
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0xDBB704", Offset = "0xDBB704", VA = "0xDBB704")]
		public void AddExpectedMissingProperty(string name)
		{
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0xDBB760", Offset = "0xDBB760", VA = "0xDBB760")]
		private bool TryAssignProperty(object obj, string name, DynValue value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0xDBBA88", Offset = "0xDBBA88", VA = "0xDBBA88")]
		private void AssignProperty(object obj, string name, DynValue value)
		{
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0xDBBBA8", Offset = "0xDBBBA8", VA = "0xDBBBA8")]
		public void AssignObject(object obj, Table data)
		{
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0xDBC128", Offset = "0xDBC128", VA = "0xDBC128")]
		public void SetSubassignerForType(Type propertyType, IPropertyTableAssigner assigner)
		{
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0xDBC378", Offset = "0xDBC378", VA = "0xDBC378", Slot = "4")]
		private void MoonSharp.Interpreter.Interop.IPropertyTableAssigner.AssignObjectUnchecked(object obj, Table data)
		{
		}
	}
	[Token(Token = "0x20000A7")]
	public interface IPropertyTableAssigner
	{
		[Token(Token = "0x6000475")]
		void AssignObjectUnchecked(object o, Table data);
	}
	[Token(Token = "0x20000A8")]
	public class DelegateProxyFactory<TProxy, TTarget> : IProxyFactory<TProxy, TTarget>, IProxyFactory where TProxy : class where TTarget : class
	{
		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Func<TTarget, TProxy> wrapDelegate;

		[Token(Token = "0x170000B5")]
		public Type TargetType
		{
			[Token(Token = "0x6000479")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B6")]
		public Type ProxyType
		{
			[Token(Token = "0x600047A")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000476")]
		public DelegateProxyFactory(Func<TTarget, TProxy> wrapDelegate)
		{
		}

		[Token(Token = "0x6000477")]
		public TProxy CreateProxyObject(TTarget target)
		{
			return null;
		}

		[Token(Token = "0x6000478")]
		public object CreateProxyObject(object o)
		{
			return null;
		}
	}
	[Token(Token = "0x20000A9")]
	public interface IProxyFactory
	{
		[Token(Token = "0x170000B7")]
		Type TargetType
		{
			[Token(Token = "0x600047C")]
			get;
		}

		[Token(Token = "0x170000B8")]
		Type ProxyType
		{
			[Token(Token = "0x600047D")]
			get;
		}

		[Token(Token = "0x600047B")]
		object CreateProxyObject(object o);
	}
	[Token(Token = "0x20000AA")]
	public interface IProxyFactory<TProxy, TTarget> : IProxyFactory where TProxy : class where TTarget : class
	{
		[Token(Token = "0x600047E")]
		TProxy CreateProxyObject(TTarget target);
	}
	[Token(Token = "0x20000AB")]
	public enum ReflectionSpecialNameType
	{
		[Token(Token = "0x4000215")]
		IndexGetter,
		[Token(Token = "0x4000216")]
		IndexSetter,
		[Token(Token = "0x4000217")]
		ImplicitCast,
		[Token(Token = "0x4000218")]
		ExplicitCast,
		[Token(Token = "0x4000219")]
		OperatorTrue,
		[Token(Token = "0x400021A")]
		OperatorFalse,
		[Token(Token = "0x400021B")]
		PropertyGetter,
		[Token(Token = "0x400021C")]
		PropertySetter,
		[Token(Token = "0x400021D")]
		AddEvent,
		[Token(Token = "0x400021E")]
		RemoveEvent,
		[Token(Token = "0x400021F")]
		OperatorAdd,
		[Token(Token = "0x4000220")]
		OperatorAnd,
		[Token(Token = "0x4000221")]
		OperatorOr,
		[Token(Token = "0x4000222")]
		OperatorDec,
		[Token(Token = "0x4000223")]
		OperatorDiv,
		[Token(Token = "0x4000224")]
		OperatorEq,
		[Token(Token = "0x4000225")]
		OperatorXor,
		[Token(Token = "0x4000226")]
		OperatorGt,
		[Token(Token = "0x4000227")]
		OperatorGte,
		[Token(Token = "0x4000228")]
		OperatorInc,
		[Token(Token = "0x4000229")]
		OperatorNeq,
		[Token(Token = "0x400022A")]
		OperatorLt,
		[Token(Token = "0x400022B")]
		OperatorLte,
		[Token(Token = "0x400022C")]
		OperatorNot,
		[Token(Token = "0x400022D")]
		OperatorMod,
		[Token(Token = "0x400022E")]
		OperatorMul,
		[Token(Token = "0x400022F")]
		OperatorCompl,
		[Token(Token = "0x4000230")]
		OperatorSub,
		[Token(Token = "0x4000231")]
		OperatorNeg,
		[Token(Token = "0x4000232")]
		OperatorUnaryPlus
	}
	[Token(Token = "0x20000AC")]
	public struct ReflectionSpecialName
	{
		[Token(Token = "0x170000B9")]
		public ReflectionSpecialNameType Type
		{
			[Token(Token = "0x600047F")]
			[Address(RVA = "0xDBC37C", Offset = "0xDBC37C", VA = "0xDBC37C")]
			[CompilerGenerated]
			readonly get
			{
				return default(ReflectionSpecialNameType);
			}
			[Token(Token = "0x6000480")]
			[Address(RVA = "0xDBC384", Offset = "0xDBC384", VA = "0xDBC384")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000BA")]
		public string Argument
		{
			[Token(Token = "0x6000481")]
			[Address(RVA = "0xDBC38C", Offset = "0xDBC38C", VA = "0xDBC38C")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000482")]
			[Address(RVA = "0xDBC394", Offset = "0xDBC394", VA = "0xDBC394")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0xDBC39C", Offset = "0xDBC39C", VA = "0xDBC39C")]
		public ReflectionSpecialName(ReflectionSpecialNameType type, [Optional] string argument)
		{
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0xDBC3A8", Offset = "0xDBC3A8", VA = "0xDBC3A8")]
		public ReflectionSpecialName(string name)
		{
		}
	}
	[Token(Token = "0x20000AD")]
	public class CompositeUserDataDescriptor : IUserDataDescriptor
	{
		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private List<IUserDataDescriptor> m_Descriptors;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Type m_Type;

		[Token(Token = "0x170000BB")]
		public IList<IUserDataDescriptor> Descriptors
		{
			[Token(Token = "0x6000486")]
			[Address(RVA = "0xDBCDF8", Offset = "0xDBCDF8", VA = "0xDBCDF8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BC")]
		public string Name
		{
			[Token(Token = "0x6000487")]
			[Address(RVA = "0xDBCE00", Offset = "0xDBCE00", VA = "0xDBCE00", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BD")]
		public Type Type
		{
			[Token(Token = "0x6000488")]
			[Address(RVA = "0xDBCE6C", Offset = "0xDBCE6C", VA = "0xDBCE6C", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0xDBCDCC", Offset = "0xDBCDCC", VA = "0xDBCDCC")]
		public CompositeUserDataDescriptor(List<IUserDataDescriptor> descriptors, Type type)
		{
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0xDBCE74", Offset = "0xDBCE74", VA = "0xDBCE74", Slot = "6")]
		public DynValue Index(Script script, object obj, DynValue index, bool isNameIndex)
		{
			return null;
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0xDBD07C", Offset = "0xDBD07C", VA = "0xDBD07C", Slot = "7")]
		public bool SetIndex(Script script, object obj, DynValue index, DynValue value, bool isNameIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0xDBD28C", Offset = "0xDBD28C", VA = "0xDBD28C", Slot = "8")]
		public string AsString(object obj)
		{
			return null;
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0xDBD2AC", Offset = "0xDBD2AC", VA = "0xDBD2AC", Slot = "9")]
		public DynValue MetaIndex(Script script, object obj, string metaname)
		{
			return null;
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0xDBD4A0", Offset = "0xDBD4A0", VA = "0xDBD4A0", Slot = "10")]
		public bool IsTypeCompatible(Type type, object obj)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000AE")]
	public class ArrayMemberDescriptor : ObjectCallbackMemberDescriptor, IWireableDescriptor
	{
		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool m_IsSetter;

		[Token(Token = "0x600048E")]
		[Address(RVA = "0xDBD554", Offset = "0xDBD554", VA = "0xDBD554")]
		public ArrayMemberDescriptor(string name, bool isSetter, ParameterDescriptor[] indexerParams)
		{
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0xDBD680", Offset = "0xDBD680", VA = "0xDBD680")]
		public ArrayMemberDescriptor(string name, bool isSetter)
		{
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0xDBD7C0", Offset = "0xDBD7C0", VA = "0xDBD7C0", Slot = "19")]
		public void PrepareForWiring(Table t)
		{
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0xDBD9DC", Offset = "0xDBD9DC", VA = "0xDBD9DC")]
		private static int[] BuildArrayIndices(CallbackArguments args, int count)
		{
			return null;
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0xDBDAAC", Offset = "0xDBDAAC", VA = "0xDBDAAC")]
		private static object ArrayIndexerSet(object arrayObj, ScriptExecutionContext ctx, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0xDBDC14", Offset = "0xDBDC14", VA = "0xDBDC14")]
		private static object ArrayIndexerGet(object arrayObj, ScriptExecutionContext ctx, CallbackArguments args)
		{
			return null;
		}
	}
	[Token(Token = "0x20000AF")]
	public class DynValueMemberDescriptor : IMemberDescriptor, IWireableDescriptor
	{
		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private DynValue m_Value;

		[Token(Token = "0x170000BE")]
		public bool IsStatic
		{
			[Token(Token = "0x6000497")]
			[Address(RVA = "0xDBDDEC", Offset = "0xDBDDEC", VA = "0xDBDDEC", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000BF")]
		public string Name
		{
			[Token(Token = "0x6000498")]
			[Address(RVA = "0xDBDDF4", Offset = "0xDBDDF4", VA = "0xDBDDF4", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000499")]
			[Address(RVA = "0xDBDDFC", Offset = "0xDBDDFC", VA = "0xDBDDFC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000C0")]
		public MemberDescriptorAccess MemberAccess
		{
			[Token(Token = "0x600049A")]
			[Address(RVA = "0xDBDE04", Offset = "0xDBDE04", VA = "0xDBDE04", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(MemberDescriptorAccess);
			}
			[Token(Token = "0x600049B")]
			[Address(RVA = "0xDBDE0C", Offset = "0xDBDE0C", VA = "0xDBDE0C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000C1")]
		public virtual DynValue Value
		{
			[Token(Token = "0x600049C")]
			[Address(RVA = "0xDBDE14", Offset = "0xDBDE14", VA = "0xDBDE14", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0xDBDCB4", Offset = "0xDBDCB4", VA = "0xDBDCB4")]
		protected DynValueMemberDescriptor(string name, string serializedTableValue)
		{
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0xDBDD74", Offset = "0xDBDD74", VA = "0xDBDD74")]
		protected DynValueMemberDescriptor(string name)
		{
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0xDBDDA4", Offset = "0xDBDDA4", VA = "0xDBDDA4")]
		public DynValueMemberDescriptor(string name, DynValue value)
		{
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0xDBDE1C", Offset = "0xDBDE1C", VA = "0xDBDE1C", Slot = "7")]
		public DynValue GetValue(Script script, object obj)
		{
			return null;
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0xDBDE28", Offset = "0xDBDE28", VA = "0xDBDE28", Slot = "8")]
		public void SetValue(Script script, object obj, DynValue value)
		{
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0xDBDEC0", Offset = "0xDBDEC0", VA = "0xDBDEC0", Slot = "9")]
		public void PrepareForWiring(Table t)
		{
		}
	}
	[Token(Token = "0x20000B0")]
	public abstract class FunctionMemberDescriptorBase : IOverloadableMemberDescriptor, IMemberDescriptor
	{
		[Token(Token = "0x170000C2")]
		public bool IsStatic
		{
			[Token(Token = "0x60004A0")]
			[Address(RVA = "0xDBE31C", Offset = "0xDBE31C", VA = "0xDBE31C", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004A1")]
			[Address(RVA = "0xDBE324", Offset = "0xDBE324", VA = "0xDBE324")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000C3")]
		public string Name
		{
			[Token(Token = "0x60004A2")]
			[Address(RVA = "0xDBE330", Offset = "0xDBE330", VA = "0xDBE330", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60004A3")]
			[Address(RVA = "0xDBE338", Offset = "0xDBE338", VA = "0xDBE338")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000C4")]
		public string SortDiscriminant
		{
			[Token(Token = "0x60004A4")]
			[Address(RVA = "0xDBE340", Offset = "0xDBE340", VA = "0xDBE340", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60004A5")]
			[Address(RVA = "0xDBE348", Offset = "0xDBE348", VA = "0xDBE348")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000C5")]
		public ParameterDescriptor[] Parameters
		{
			[Token(Token = "0x60004A6")]
			[Address(RVA = "0xDBE350", Offset = "0xDBE350", VA = "0xDBE350", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60004A7")]
			[Address(RVA = "0xDBE358", Offset = "0xDBE358", VA = "0xDBE358")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000C6")]
		public Type ExtensionMethodType
		{
			[Token(Token = "0x60004A8")]
			[Address(RVA = "0xDBE360", Offset = "0xDBE360", VA = "0xDBE360", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60004A9")]
			[Address(RVA = "0xDBE368", Offset = "0xDBE368", VA = "0xDBE368")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000C7")]
		public Type VarArgsArrayType
		{
			[Token(Token = "0x60004AA")]
			[Address(RVA = "0xDBE370", Offset = "0xDBE370", VA = "0xDBE370", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60004AB")]
			[Address(RVA = "0xDBE378", Offset = "0xDBE378", VA = "0xDBE378")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000C8")]
		public Type VarArgsElementType
		{
			[Token(Token = "0x60004AC")]
			[Address(RVA = "0xDBE380", Offset = "0xDBE380", VA = "0xDBE380", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60004AD")]
			[Address(RVA = "0xDBE388", Offset = "0xDBE388", VA = "0xDBE388")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000C9")]
		public MemberDescriptorAccess MemberAccess
		{
			[Token(Token = "0x60004B6")]
			[Address(RVA = "0xDBF228", Offset = "0xDBF228", VA = "0xDBF228", Slot = "12")]
			get
			{
				return default(MemberDescriptorAccess);
			}
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0xDBE390", Offset = "0xDBE390", VA = "0xDBE390")]
		protected void Initialize(string funcName, bool isStatic, ParameterDescriptor[] parameters, bool isExtensionMethod)
		{
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0xDBE580", Offset = "0xDBE580", VA = "0xDBE580")]
		public Func<ScriptExecutionContext, CallbackArguments, DynValue> GetCallback(Script script, [Optional] object obj)
		{
			return null;
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0xDBE648", Offset = "0xDBE648", VA = "0xDBE648")]
		public CallbackFunction GetCallbackFunction(Script script, [Optional] object obj)
		{
			return null;
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0xDBE6DC", Offset = "0xDBE6DC", VA = "0xDBE6DC")]
		public DynValue GetCallbackAsDynValue(Script script, [Optional] object obj)
		{
			return null;
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0xDBE75C", Offset = "0xDBE75C", VA = "0xDBE75C")]
		public static DynValue CreateCallbackDynValue(Script script, MethodInfo mi, [Optional] object obj)
		{
			return null;
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0xDBE7DC", Offset = "0xDBE7DC", VA = "0xDBE7DC", Slot = "15")]
		protected virtual object[] BuildArgumentList(Script script, object obj, ScriptExecutionContext context, CallbackArguments args, out List<int> outParams)
		{
			return null;
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0xDBEFE8", Offset = "0xDBEFE8", VA = "0xDBEFE8")]
		protected static DynValue BuildReturnValue(Script script, List<int> outParams, object[] pars, object retv)
		{
			return null;
		}

		[Token(Token = "0x60004B5")]
		public abstract DynValue Execute(Script script, object obj, ScriptExecutionContext context, CallbackArguments args);

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0xDBF230", Offset = "0xDBF230", VA = "0xDBF230", Slot = "17")]
		public virtual DynValue GetValue(Script script, object obj)
		{
			return null;
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0xDBF268", Offset = "0xDBF268", VA = "0xDBF268", Slot = "18")]
		public virtual void SetValue(Script script, object obj, DynValue v)
		{
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0xDBF274", Offset = "0xDBF274", VA = "0xDBF274")]
		protected FunctionMemberDescriptorBase()
		{
		}
	}
	[Token(Token = "0x20000B3")]
	public class ObjectCallbackMemberDescriptor : FunctionMemberDescriptorBase
	{
		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Func<object, ScriptExecutionContext, CallbackArguments, object> m_CallbackFunc;

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0xDBF344", Offset = "0xDBF344", VA = "0xDBF344")]
		public ObjectCallbackMemberDescriptor(string funcName)
		{
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0xDBD73C", Offset = "0xDBD73C", VA = "0xDBD73C")]
		public ObjectCallbackMemberDescriptor(string funcName, Func<object, ScriptExecutionContext, CallbackArguments, object> callBack)
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0xDBD634", Offset = "0xDBD634", VA = "0xDBD634")]
		public ObjectCallbackMemberDescriptor(string funcName, Func<object, ScriptExecutionContext, CallbackArguments, object> callBack, ParameterDescriptor[] parameters)
		{
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0xDBF468", Offset = "0xDBF468", VA = "0xDBF468", Slot = "16")]
		public override DynValue Execute(Script script, object obj, ScriptExecutionContext context, CallbackArguments args)
		{
			return null;
		}
	}
	[Token(Token = "0x20000B5")]
	public sealed class ProxyUserDataDescriptor : IUserDataDescriptor
	{
		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IUserDataDescriptor m_ProxyDescriptor;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private IProxyFactory m_ProxyFactory;

		[Token(Token = "0x170000CA")]
		public IUserDataDescriptor InnerDescriptor
		{
			[Token(Token = "0x60004C7")]
			[Address(RVA = "0xDBF758", Offset = "0xDBF758", VA = "0xDBF758")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CB")]
		public string Name
		{
			[Token(Token = "0x60004C8")]
			[Address(RVA = "0xDBF760", Offset = "0xDBF760", VA = "0xDBF760", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60004C9")]
			[Address(RVA = "0xDBF768", Offset = "0xDBF768", VA = "0xDBF768")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000CC")]
		public Type Type
		{
			[Token(Token = "0x60004CA")]
			[Address(RVA = "0xDBF770", Offset = "0xDBF770", VA = "0xDBF770", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0xDBF64C", Offset = "0xDBF64C", VA = "0xDBF64C")]
		internal ProxyUserDataDescriptor(IProxyFactory proxyFactory, IUserDataDescriptor proxyDescriptor, [Optional] string friendlyName)
		{
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0xDBF814", Offset = "0xDBF814", VA = "0xDBF814")]
		private object Proxy(object obj)
		{
			return null;
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0xDBF8D0", Offset = "0xDBF8D0", VA = "0xDBF8D0", Slot = "6")]
		public DynValue Index(Script script, object obj, DynValue index, bool isDirectIndexing)
		{
			return null;
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0xDBF9B4", Offset = "0xDBF9B4", VA = "0xDBF9B4", Slot = "7")]
		public bool SetIndex(Script script, object obj, DynValue index, DynValue value, bool isDirectIndexing)
		{
			return default(bool);
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0xDBFAA0", Offset = "0xDBFAA0", VA = "0xDBFAA0", Slot = "8")]
		public string AsString(object obj)
		{
			return null;
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0xDBFB5C", Offset = "0xDBFB5C", VA = "0xDBFB5C", Slot = "9")]
		public DynValue MetaIndex(Script script, object obj, string metaname)
		{
			return null;
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0xDBFC30", Offset = "0xDBFC30", VA = "0xDBFC30", Slot = "10")]
		public bool IsTypeCompatible(Type type, object obj)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000B6")]
	public class EventMemberDescriptor : IMemberDescriptor
	{
		[Token(Token = "0x20000B7")]
		private delegate void EventWrapper00();

		[Token(Token = "0x20000B8")]
		private delegate void EventWrapper01(object o1);

		[Token(Token = "0x20000B9")]
		private delegate void EventWrapper02(object o1, object o2);

		[Token(Token = "0x20000BA")]
		private delegate void EventWrapper03(object o1, object o2, object o3);

		[Token(Token = "0x20000BB")]
		private delegate void EventWrapper04(object o1, object o2, object o3, object o4);

		[Token(Token = "0x20000BC")]
		private delegate void EventWrapper05(object o1, object o2, object o3, object o4, object o5);

		[Token(Token = "0x20000BD")]
		private delegate void EventWrapper06(object o1, object o2, object o3, object o4, object o5, object o6);

		[Token(Token = "0x20000BE")]
		private delegate void EventWrapper07(object o1, object o2, object o3, object o4, object o5, object o6, object o7);

		[Token(Token = "0x20000BF")]
		private delegate void EventWrapper08(object o1, object o2, object o3, object o4, object o5, object o6, object o7, object o8);

		[Token(Token = "0x20000C0")]
		private delegate void EventWrapper09(object o1, object o2, object o3, object o4, object o5, object o6, object o7, object o8, object o9);

		[Token(Token = "0x20000C1")]
		private delegate void EventWrapper10(object o1, object o2, object o3, object o4, object o5, object o6, object o7, object o8, object o9, object o10);

		[Token(Token = "0x20000C2")]
		private delegate void EventWrapper11(object o1, object o2, object o3, object o4, object o5, object o6, object o7, object o8, object o9, object o10, object o11);

		[Token(Token = "0x20000C3")]
		private delegate void EventWrapper12(object o1, object o2, object o3, object o4, object o5, object o6, object o7, object o8, object o9, object o10, object o11, object o12);

		[Token(Token = "0x20000C4")]
		private delegate void EventWrapper13(object o1, object o2, object o3, object o4, object o5, object o6, object o7, object o8, object o9, object o10, object o11, object o12, object o13);

		[Token(Token = "0x20000C5")]
		private delegate void EventWrapper14(object o1, object o2, object o3, object o4, object o5, object o6, object o7, object o8, object o9, object o10, object o11, object o12, object o13, object o14);

		[Token(Token = "0x20000C6")]
		private delegate void EventWrapper15(object o1, object o2, object o3, object o4, object o5, object o6, object o7, object o8, object o9, object o10, object o11, object o12, object o13, object o14, object o15);

		[Token(Token = "0x20000C7")]
		private delegate void EventWrapper16(object o1, object o2, object o3, object o4, object o5, object o6, object o7, object o8, object o9, object o10, object o11, object o12, object o13, object o14, object o15, object o16);

		[Token(Token = "0x400024D")]
		public const int MAX_ARGS_IN_DELEGATE = 16;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private object m_Lock;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private MultiDictionary<object, Closure> m_Callbacks;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Dictionary<object, Delegate> m_Delegates;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private MethodInfo m_Add;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private MethodInfo m_Remove;

		[Token(Token = "0x170000CD")]
		public EventInfo EventInfo
		{
			[Token(Token = "0x60004D4")]
			[Address(RVA = "0xDC06A4", Offset = "0xDC06A4", VA = "0xDC06A4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60004D5")]
			[Address(RVA = "0xDC06AC", Offset = "0xDC06AC", VA = "0xDC06AC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000CE")]
		public bool IsStatic
		{
			[Token(Token = "0x60004D6")]
			[Address(RVA = "0xDC06B4", Offset = "0xDC06B4", VA = "0xDC06B4", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004D7")]
			[Address(RVA = "0xDC06BC", Offset = "0xDC06BC", VA = "0xDC06BC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000CF")]
		public string Name
		{
			[Token(Token = "0x60004DF")]
			[Address(RVA = "0xDC1998", Offset = "0xDC1998", VA = "0xDC1998", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D0")]
		public MemberDescriptorAccess MemberAccess
		{
			[Token(Token = "0x60004E0")]
			[Address(RVA = "0xDC19B8", Offset = "0xDC19B8", VA = "0xDC19B8", Slot = "6")]
			get
			{
				return default(MemberDescriptorAccess);
			}
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0xDBFCE4", Offset = "0xDBFCE4", VA = "0xDBFCE4")]
		public static EventMemberDescriptor TryCreateIfVisible(EventInfo ei, InteropAccessMode accessMode)
		{
			return null;
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0xDBFECC", Offset = "0xDBFECC", VA = "0xDBFECC")]
		public static bool CheckEventIsCompatible(EventInfo ei, bool throwException)
		{
			return default(bool);
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0xDC045C", Offset = "0xDC045C", VA = "0xDC045C")]
		public EventMemberDescriptor(EventInfo ei, InteropAccessMode accessMode = InteropAccessMode.Default)
		{
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0xDC06C8", Offset = "0xDC06C8", VA = "0xDC06C8", Slot = "7")]
		public DynValue GetValue(Script script, object obj)
		{
			return null;
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0xDC0780", Offset = "0xDC0780", VA = "0xDC0780")]
		internal DynValue AddCallback(object o, ScriptExecutionContext context, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0xDC0A9C", Offset = "0xDC0A9C", VA = "0xDC0A9C")]
		internal DynValue RemoveCallback(object o, ScriptExecutionContext context, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0xDC09C0", Offset = "0xDC09C0", VA = "0xDC09C0")]
		private void RegisterCallback(object o)
		{
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0xDC0CDC", Offset = "0xDC0CDC", VA = "0xDC0CDC")]
		private void UnregisterCallback(object o)
		{
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0xDC0E28", Offset = "0xDC0E28", VA = "0xDC0E28")]
		private Delegate CreateDelegate(object sender)
		{
			return null;
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0xDC14D8", Offset = "0xDC14D8", VA = "0xDC14D8")]
		private void DispatchEvent(object sender, [Optional] object o01, [Optional] object o02, [Optional] object o03, [Optional] object o04, [Optional] object o05, [Optional] object o06, [Optional] object o07, [Optional] object o08, [Optional] object o09, [Optional] object o10, [Optional] object o11, [Optional] object o12, [Optional] object o13, [Optional] object o14, [Optional] object o15, [Optional] object o16)
		{
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0xDC19C0", Offset = "0xDC19C0", VA = "0xDC19C0", Slot = "8")]
		public void SetValue(Script script, object obj, DynValue v)
		{
		}
	}
	[Token(Token = "0x20000CA")]
	public class FieldMemberDescriptor : IMemberDescriptor, IOptimizableDescriptor, IWireableDescriptor
	{
		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private object m_ConstValue;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Func<object, object> m_OptimizedGetter;

		[Token(Token = "0x170000D1")]
		public FieldInfo FieldInfo
		{
			[Token(Token = "0x600053A")]
			[Address(RVA = "0xDC3C54", Offset = "0xDC3C54", VA = "0xDC3C54")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600053B")]
			[Address(RVA = "0xDC3C5C", Offset = "0xDC3C5C", VA = "0xDC3C5C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000D2")]
		public InteropAccessMode AccessMode
		{
			[Token(Token = "0x600053C")]
			[Address(RVA = "0xDC3C64", Offset = "0xDC3C64", VA = "0xDC3C64")]
			[CompilerGenerated]
			get
			{
				return default(InteropAccessMode);
			}
			[Token(Token = "0x600053D")]
			[Address(RVA = "0xDC3C6C", Offset = "0xDC3C6C", VA = "0xDC3C6C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000D3")]
		public bool IsStatic
		{
			[Token(Token = "0x600053E")]
			[Address(RVA = "0xDC3C74", Offset = "0xDC3C74", VA = "0xDC3C74", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600053F")]
			[Address(RVA = "0xDC3C7C", Offset = "0xDC3C7C", VA = "0xDC3C7C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000D4")]
		public string Name
		{
			[Token(Token = "0x6000540")]
			[Address(RVA = "0xDC3C88", Offset = "0xDC3C88", VA = "0xDC3C88", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000541")]
			[Address(RVA = "0xDC3C90", Offset = "0xDC3C90", VA = "0xDC3C90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000D5")]
		public bool IsConst
		{
			[Token(Token = "0x6000542")]
			[Address(RVA = "0xDC3C98", Offset = "0xDC3C98", VA = "0xDC3C98")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000543")]
			[Address(RVA = "0xDC3CA0", Offset = "0xDC3CA0", VA = "0xDC3CA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000D6")]
		public bool IsReadonly
		{
			[Token(Token = "0x6000544")]
			[Address(RVA = "0xDC3CAC", Offset = "0xDC3CAC", VA = "0xDC3CAC")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000545")]
			[Address(RVA = "0xDC3CB4", Offset = "0xDC3CB4", VA = "0xDC3CB4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000D7")]
		public MemberDescriptorAccess MemberAccess
		{
			[Token(Token = "0x600054B")]
			[Address(RVA = "0xDC5298", Offset = "0xDC5298", VA = "0xDC5298", Slot = "6")]
			get
			{
				return default(MemberDescriptorAccess);
			}
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0xDC3CC0", Offset = "0xDC3CC0", VA = "0xDC3CC0")]
		public static FieldMemberDescriptor TryCreateIfVisible(FieldInfo fi, InteropAccessMode accessMode)
		{
			return null;
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0xDC3D80", Offset = "0xDC3D80", VA = "0xDC3D80")]
		public FieldMemberDescriptor(FieldInfo fi, InteropAccessMode accessMode)
		{
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0xDC4428", Offset = "0xDC4428", VA = "0xDC4428", Slot = "7")]
		public DynValue GetValue(Script script, object obj)
		{
			return null;
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0xDC3F68", Offset = "0xDC3F68", VA = "0xDC3F68")]
		internal void OptimizeGetter()
		{
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0xDC494C", Offset = "0xDC494C", VA = "0xDC494C", Slot = "8")]
		public void SetValue(Script script, object obj, DynValue v)
		{
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0xDC52BC", Offset = "0xDC52BC", VA = "0xDC52BC", Slot = "9")]
		private void MoonSharp.Interpreter.Interop.BasicDescriptors.IOptimizableDescriptor.Optimize()
		{
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0xDC52CC", Offset = "0xDC52CC", VA = "0xDC52CC", Slot = "10")]
		public void PrepareForWiring(Table t)
		{
		}
	}
	[Token(Token = "0x20000CB")]
	public class MethodMemberDescriptor : FunctionMemberDescriptorBase, IOptimizableDescriptor, IWireableDescriptor
	{
		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Func<object, object[], object> m_OptimizedFunc;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Action<object, object[]> m_OptimizedAction;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool m_IsAction;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		private bool m_IsArrayCtor;

		[Token(Token = "0x170000D8")]
		public MethodBase MethodInfo
		{
			[Token(Token = "0x600054E")]
			[Address(RVA = "0xDC56B4", Offset = "0xDC56B4", VA = "0xDC56B4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600054F")]
			[Address(RVA = "0xDC56BC", Offset = "0xDC56BC", VA = "0xDC56BC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000D9")]
		public InteropAccessMode AccessMode
		{
			[Token(Token = "0x6000550")]
			[Address(RVA = "0xDC56C4", Offset = "0xDC56C4", VA = "0xDC56C4")]
			[CompilerGenerated]
			get
			{
				return default(InteropAccessMode);
			}
			[Token(Token = "0x6000551")]
			[Address(RVA = "0xDC56CC", Offset = "0xDC56CC", VA = "0xDC56CC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000DA")]
		public bool IsConstructor
		{
			[Token(Token = "0x6000552")]
			[Address(RVA = "0xDC56D4", Offset = "0xDC56D4", VA = "0xDC56D4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000553")]
			[Address(RVA = "0xDC56DC", Offset = "0xDC56DC", VA = "0xDC56DC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0xDC56E8", Offset = "0xDC56E8", VA = "0xDC56E8")]
		public MethodMemberDescriptor(MethodBase methodBase, InteropAccessMode accessMode = InteropAccessMode.Default)
		{
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0xDC623C", Offset = "0xDC623C", VA = "0xDC623C")]
		public static MethodMemberDescriptor TryCreateIfVisible(MethodBase methodBase, InteropAccessMode accessMode, bool forceVisibility = false)
		{
			return null;
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0xDC5F04", Offset = "0xDC5F04", VA = "0xDC5F04")]
		public static bool CheckMethodIsCompatible(MethodBase methodBase, bool throwException)
		{
			return default(bool);
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0xDC631C", Offset = "0xDC631C", VA = "0xDC631C", Slot = "16")]
		public override DynValue Execute(Script script, object obj, ScriptExecutionContext context, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0xDC6590", Offset = "0xDC6590", VA = "0xDC6590", Slot = "19")]
		private void MoonSharp.Interpreter.Interop.BasicDescriptors.IOptimizableDescriptor.Optimize()
		{
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0xDC6DB4", Offset = "0xDC6DB4", VA = "0xDC6DB4", Slot = "20")]
		public void PrepareForWiring(Table t)
		{
		}
	}
	[Token(Token = "0x20000CD")]
	public class OverloadedMethodMemberDescriptor : IOptimizableDescriptor, IMemberDescriptor, IWireableDescriptor
	{
		[Token(Token = "0x20000CE")]
		private class OverloadableMemberDescriptorComparer : IComparer<IOverloadableMemberDescriptor>
		{
			[Token(Token = "0x6000578")]
			[Address(RVA = "0xDC9A48", Offset = "0xDC9A48", VA = "0xDC9A48", Slot = "4")]
			public int Compare(IOverloadableMemberDescriptor x, IOverloadableMemberDescriptor y)
			{
				return default(int);
			}

			[Token(Token = "0x6000579")]
			[Address(RVA = "0xDC7CF8", Offset = "0xDC7CF8", VA = "0xDC7CF8")]
			public OverloadableMemberDescriptorComparer()
			{
			}
		}

		[Token(Token = "0x20000CF")]
		private class OverloadCacheItem
		{
			[Token(Token = "0x4000276")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool HasObject;

			[Token(Token = "0x4000277")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public IOverloadableMemberDescriptor Method;

			[Token(Token = "0x4000278")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public List<DataType> ArgsDataType;

			[Token(Token = "0x4000279")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public List<Type> ArgsUserDataType;

			[Token(Token = "0x400027A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public int HitIndexAtLastHit;

			[Token(Token = "0x600057A")]
			[Address(RVA = "0xDC8EC4", Offset = "0xDC8EC4", VA = "0xDC8EC4")]
			public OverloadCacheItem()
			{
			}
		}

		[Token(Token = "0x400026C")]
		private const int CACHE_SIZE = 5;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private List<IOverloadableMemberDescriptor> m_Overloads;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private List<IOverloadableMemberDescriptor> m_ExtOverloads;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool m_Unsorted;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private OverloadCacheItem[] m_Cache;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int m_CacheHits;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int m_ExtensionMethodVersion;

		[Token(Token = "0x170000DB")]
		public bool IgnoreExtensionMethods
		{
			[Token(Token = "0x600055F")]
			[Address(RVA = "0xDC745C", Offset = "0xDC745C", VA = "0xDC745C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000560")]
			[Address(RVA = "0xDC7464", Offset = "0xDC7464", VA = "0xDC7464")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000DC")]
		public string Name
		{
			[Token(Token = "0x6000565")]
			[Address(RVA = "0xDC76A4", Offset = "0xDC76A4", VA = "0xDC76A4", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000566")]
			[Address(RVA = "0xDC76AC", Offset = "0xDC76AC", VA = "0xDC76AC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000DD")]
		public Type DeclaringType
		{
			[Token(Token = "0x6000567")]
			[Address(RVA = "0xDC76B4", Offset = "0xDC76B4", VA = "0xDC76B4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000568")]
			[Address(RVA = "0xDC76BC", Offset = "0xDC76BC", VA = "0xDC76BC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000DE")]
		public int OverloadCount
		{
			[Token(Token = "0x600056A")]
			[Address(RVA = "0xDC7770", Offset = "0xDC7770", VA = "0xDC7770")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000DF")]
		public bool IsStatic
		{
			[Token(Token = "0x6000573")]
			[Address(RVA = "0xDC9454", Offset = "0xDC9454", VA = "0xDC9454", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000E0")]
		public MemberDescriptorAccess MemberAccess
		{
			[Token(Token = "0x6000574")]
			[Address(RVA = "0xDC9550", Offset = "0xDC9550", VA = "0xDC9550", Slot = "7")]
			get
			{
				return default(MemberDescriptorAccess);
			}
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0xDC7470", Offset = "0xDC7470", VA = "0xDC7470")]
		public OverloadedMethodMemberDescriptor(string name, Type declaringType)
		{
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0xDC7554", Offset = "0xDC7554", VA = "0xDC7554")]
		public OverloadedMethodMemberDescriptor(string name, Type declaringType, IOverloadableMemberDescriptor descriptor)
		{
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0xDC7620", Offset = "0xDC7620", VA = "0xDC7620")]
		public OverloadedMethodMemberDescriptor(string name, Type declaringType, IEnumerable<IOverloadableMemberDescriptor> descriptors)
		{
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0xDC7698", Offset = "0xDC7698", VA = "0xDC7698")]
		internal void SetExtensionMethodsSnapshot(int version, List<IOverloadableMemberDescriptor> extMethods)
		{
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0xDC76C4", Offset = "0xDC76C4", VA = "0xDC76C4")]
		public void AddOverload(IOverloadableMemberDescriptor overload)
		{
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0xDC77B8", Offset = "0xDC77B8", VA = "0xDC77B8")]
		private DynValue PerformOverloadedCall(Script script, object obj, ScriptExecutionContext context, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0xDC8A08", Offset = "0xDC8A08", VA = "0xDC8A08")]
		private void Cache(bool hasObject, CallbackArguments args, IOverloadableMemberDescriptor bestOverload)
		{
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0xDC7D00", Offset = "0xDC7D00", VA = "0xDC7D00")]
		private bool CheckMatch(bool hasObject, CallbackArguments args, OverloadCacheItem overloadCacheItem)
		{
			return default(bool);
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0xDC7F40", Offset = "0xDC7F40", VA = "0xDC7F40")]
		private int CalcScoreForOverload(ScriptExecutionContext context, CallbackArguments args, IOverloadableMemberDescriptor method, bool isExtMethod)
		{
			return default(int);
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0xDC8ECC", Offset = "0xDC8ECC", VA = "0xDC8ECC")]
		private static int CalcScoreForSingleArgument(ParameterDescriptor desc, Type parameterType, DynValue arg, bool isOptional)
		{
			return default(int);
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0xDC8F94", Offset = "0xDC8F94", VA = "0xDC8F94")]
		public Func<ScriptExecutionContext, CallbackArguments, DynValue> GetCallback(Script script, object obj)
		{
			return null;
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0xDC905C", Offset = "0xDC905C", VA = "0xDC905C", Slot = "4")]
		private void MoonSharp.Interpreter.Interop.BasicDescriptors.IOptimizableDescriptor.Optimize()
		{
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0xDC93C0", Offset = "0xDC93C0", VA = "0xDC93C0")]
		public CallbackFunction GetCallbackFunction(Script script, [Optional] object obj)
		{
			return null;
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0xDC9558", Offset = "0xDC9558", VA = "0xDC9558", Slot = "8")]
		public DynValue GetValue(Script script, object obj)
		{
			return null;
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0xDC95D8", Offset = "0xDC95D8", VA = "0xDC95D8", Slot = "9")]
		public void SetValue(Script script, object obj, DynValue value)
		{
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0xDC95E4", Offset = "0xDC95E4", VA = "0xDC95E4", Slot = "10")]
		public void PrepareForWiring(Table t)
		{
		}
	}
	[Token(Token = "0x20000D2")]
	public class PropertyMemberDescriptor : IMemberDescriptor, IOptimizableDescriptor, IWireableDescriptor
	{
		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private MethodInfo m_Getter;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private MethodInfo m_Setter;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Func<object, object> m_OptimizedGetter;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Action<object, object> m_OptimizedSetter;

		[Token(Token = "0x170000E1")]
		public PropertyInfo PropertyInfo
		{
			[Token(Token = "0x6000580")]
			[Address(RVA = "0xDC9C94", Offset = "0xDC9C94", VA = "0xDC9C94")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000581")]
			[Address(RVA = "0xDC9C9C", Offset = "0xDC9C9C", VA = "0xDC9C9C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000E2")]
		public InteropAccessMode AccessMode
		{
			[Token(Token = "0x6000582")]
			[Address(RVA = "0xDC9CA4", Offset = "0xDC9CA4", VA = "0xDC9CA4")]
			[CompilerGenerated]
			get
			{
				return default(InteropAccessMode);
			}
			[Token(Token = "0x6000583")]
			[Address(RVA = "0xDC9CAC", Offset = "0xDC9CAC", VA = "0xDC9CAC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000E3")]
		public bool IsStatic
		{
			[Token(Token = "0x6000584")]
			[Address(RVA = "0xDC9CB4", Offset = "0xDC9CB4", VA = "0xDC9CB4", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000585")]
			[Address(RVA = "0xDC9CBC", Offset = "0xDC9CBC", VA = "0xDC9CBC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000E4")]
		public string Name
		{
			[Token(Token = "0x6000586")]
			[Address(RVA = "0xDC9CC8", Offset = "0xDC9CC8", VA = "0xDC9CC8", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000587")]
			[Address(RVA = "0xDC9CD0", Offset = "0xDC9CD0", VA = "0xDC9CD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000E5")]
		public bool CanRead
		{
			[Token(Token = "0x6000588")]
			[Address(RVA = "0xDC9CD8", Offset = "0xDC9CD8", VA = "0xDC9CD8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000E6")]
		public bool CanWrite
		{
			[Token(Token = "0x6000589")]
			[Address(RVA = "0xDC9CE8", Offset = "0xDC9CE8", VA = "0xDC9CE8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000E7")]
		public MemberDescriptorAccess MemberAccess
		{
			[Token(Token = "0x6000592")]
			[Address(RVA = "0xDCB4E0", Offset = "0xDCB4E0", VA = "0xDCB4E0", Slot = "6")]
			get
			{
				return default(MemberDescriptorAccess);
			}
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0xDC9CF8", Offset = "0xDC9CF8", VA = "0xDC9CF8")]
		public static PropertyMemberDescriptor TryCreateIfVisible(PropertyInfo pi, InteropAccessMode accessMode)
		{
			return null;
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0xDC9F34", Offset = "0xDC9F34", VA = "0xDC9F34")]
		private static PropertyMemberDescriptor TryCreate(PropertyInfo pi, InteropAccessMode accessMode, MethodInfo getter, MethodInfo setter)
		{
			return null;
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0xDCA200", Offset = "0xDCA200", VA = "0xDCA200")]
		public PropertyMemberDescriptor(PropertyInfo pi, InteropAccessMode accessMode)
		{
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0xDC9FE0", Offset = "0xDC9FE0", VA = "0xDC9FE0")]
		public PropertyMemberDescriptor(PropertyInfo pi, InteropAccessMode accessMode, MethodInfo getter, MethodInfo setter)
		{
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0xDCAF60", Offset = "0xDCAF60", VA = "0xDCAF60", Slot = "7")]
		public DynValue GetValue(Script script, object obj)
		{
			return null;
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0xDCA328", Offset = "0xDCA328", VA = "0xDCA328")]
		internal void OptimizeGetter()
		{
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0xDCA7F4", Offset = "0xDCA7F4", VA = "0xDCA7F4")]
		internal void OptimizeSetter()
		{
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0xDCB0F4", Offset = "0xDCB0F4", VA = "0xDCB0F4", Slot = "8")]
		public void SetValue(Script script, object obj, DynValue v)
		{
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0xDCB528", Offset = "0xDCB528", VA = "0xDCB528", Slot = "9")]
		private void MoonSharp.Interpreter.Interop.BasicDescriptors.IOptimizableDescriptor.Optimize()
		{
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0xDCB540", Offset = "0xDCB540", VA = "0xDCB540", Slot = "10")]
		public void PrepareForWiring(Table t)
		{
		}
	}
	[Token(Token = "0x20000D3")]
	public class ValueTypeDefaultCtorMemberDescriptor : IOverloadableMemberDescriptor, IMemberDescriptor, IWireableDescriptor
	{
		[Token(Token = "0x170000E8")]
		public bool IsStatic
		{
			[Token(Token = "0x6000595")]
			[Address(RVA = "0xDCB8A8", Offset = "0xDCB8A8", VA = "0xDCB8A8", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000E9")]
		public string Name
		{
			[Token(Token = "0x6000596")]
			[Address(RVA = "0xDCB8B0", Offset = "0xDCB8B0", VA = "0xDCB8B0", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000597")]
			[Address(RVA = "0xDCB8B8", Offset = "0xDCB8B8", VA = "0xDCB8B8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000EA")]
		public Type ValueTypeDefaultCtor
		{
			[Token(Token = "0x6000598")]
			[Address(RVA = "0xDCB8C0", Offset = "0xDCB8C0", VA = "0xDCB8C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000599")]
			[Address(RVA = "0xDCB8C8", Offset = "0xDCB8C8", VA = "0xDCB8C8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000EB")]
		public ParameterDescriptor[] Parameters
		{
			[Token(Token = "0x600059A")]
			[Address(RVA = "0xDCB8D0", Offset = "0xDCB8D0", VA = "0xDCB8D0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600059B")]
			[Address(RVA = "0xDCB8D8", Offset = "0xDCB8D8", VA = "0xDCB8D8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000EC")]
		public Type ExtensionMethodType
		{
			[Token(Token = "0x600059C")]
			[Address(RVA = "0xDCB8E0", Offset = "0xDCB8E0", VA = "0xDCB8E0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000ED")]
		public Type VarArgsArrayType
		{
			[Token(Token = "0x600059D")]
			[Address(RVA = "0xDCB8E8", Offset = "0xDCB8E8", VA = "0xDCB8E8", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000EE")]
		public Type VarArgsElementType
		{
			[Token(Token = "0x600059E")]
			[Address(RVA = "0xDCB8F0", Offset = "0xDCB8F0", VA = "0xDCB8F0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000EF")]
		public string SortDiscriminant
		{
			[Token(Token = "0x60005A1")]
			[Address(RVA = "0xDCBA80", Offset = "0xDCBA80", VA = "0xDCBA80", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F0")]
		public MemberDescriptorAccess MemberAccess
		{
			[Token(Token = "0x60005A2")]
			[Address(RVA = "0xDCBAC0", Offset = "0xDCBAC0", VA = "0xDCBAC0", Slot = "12")]
			get
			{
				return default(MemberDescriptorAccess);
			}
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0xDCB8F8", Offset = "0xDCB8F8", VA = "0xDCB8F8")]
		public ValueTypeDefaultCtorMemberDescriptor(Type valueType)
		{
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0xDCBA44", Offset = "0xDCBA44", VA = "0xDCBA44", Slot = "4")]
		public DynValue Execute(Script script, object obj, ScriptExecutionContext context, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0xDCBAC8", Offset = "0xDCBAC8", VA = "0xDCBAC8", Slot = "13")]
		public DynValue GetValue(Script script, object obj)
		{
			return null;
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0xDCBB04", Offset = "0xDCBB04", VA = "0xDCBB04", Slot = "14")]
		public void SetValue(Script script, object obj, DynValue value)
		{
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0xDCBB10", Offset = "0xDCBB10", VA = "0xDCBB10", Slot = "15")]
		public void PrepareForWiring(Table t)
		{
		}
	}
	[Token(Token = "0x20000D4")]
	public class StandardEnumUserDataDescriptor : DispatchingUserDataDescriptor
	{
		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Func<object, ulong> m_EnumToULong;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Func<ulong, object> m_ULongToEnum;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Func<object, long> m_EnumToLong;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Func<long, object> m_LongToEnum;

		[Token(Token = "0x170000F1")]
		public Type UnderlyingType
		{
			[Token(Token = "0x60005A6")]
			[Address(RVA = "0xDCBC48", Offset = "0xDCBC48", VA = "0xDCBC48")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60005A7")]
			[Address(RVA = "0xDCBC50", Offset = "0xDCBC50", VA = "0xDCBC50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000F2")]
		public bool IsUnsigned
		{
			[Token(Token = "0x60005A8")]
			[Address(RVA = "0xDCBC58", Offset = "0xDCBC58", VA = "0xDCBC58")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005A9")]
			[Address(RVA = "0xDCBC60", Offset = "0xDCBC60", VA = "0xDCBC60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000F3")]
		public bool IsFlags
		{
			[Token(Token = "0x60005AA")]
			[Address(RVA = "0xDCBC6C", Offset = "0xDCBC6C", VA = "0xDCBC6C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005AB")]
			[Address(RVA = "0xDCBC74", Offset = "0xDCBC74", VA = "0xDCBC74")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0xDCBC80", Offset = "0xDCBC80", VA = "0xDCBC80")]
		public StandardEnumUserDataDescriptor(Type enumType, [Optional] string friendlyName, [Optional] string[] names, [Optional] object[] values, [Optional] Type underlyingType)
		{
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0xDCBFDC", Offset = "0xDCBFDC", VA = "0xDCBFDC")]
		private void FillMemberList(string[] names, object[] values)
		{
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0xDCC46C", Offset = "0xDCC46C", VA = "0xDCC46C")]
		private void AddEnumMethod(string name, DynValue dynValue)
		{
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0xDCC538", Offset = "0xDCC538", VA = "0xDCC538")]
		private long GetValueSigned(DynValue dv)
		{
			return default(long);
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0xDCCC94", Offset = "0xDCCC94", VA = "0xDCCC94")]
		private ulong GetValueUnsigned(DynValue dv)
		{
			return default(ulong);
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0xDCD3E8", Offset = "0xDCD3E8", VA = "0xDCD3E8")]
		private DynValue CreateValueSigned(long value)
		{
			return null;
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0xDCD478", Offset = "0xDCD478", VA = "0xDCD478")]
		private DynValue CreateValueUnsigned(ulong value)
		{
			return null;
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0xDCC644", Offset = "0xDCC644", VA = "0xDCC644")]
		private void CreateSignedConversionFunctions()
		{
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0xDCCD98", Offset = "0xDCCD98", VA = "0xDCCD98")]
		private void CreateUnsignedConversionFunctions()
		{
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0xDCD508", Offset = "0xDCD508", VA = "0xDCD508")]
		private DynValue PerformBinaryOperationS(string funcName, ScriptExecutionContext ctx, CallbackArguments args, Func<long, long, DynValue> operation)
		{
			return null;
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0xDCD624", Offset = "0xDCD624", VA = "0xDCD624")]
		private DynValue PerformBinaryOperationU(string funcName, ScriptExecutionContext ctx, CallbackArguments args, Func<ulong, ulong, DynValue> operation)
		{
			return null;
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0xDCD740", Offset = "0xDCD740", VA = "0xDCD740")]
		private DynValue PerformBinaryOperationS(string funcName, ScriptExecutionContext ctx, CallbackArguments args, Func<long, long, long> operation)
		{
			return null;
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0xDCD81C", Offset = "0xDCD81C", VA = "0xDCD81C")]
		private DynValue PerformBinaryOperationU(string funcName, ScriptExecutionContext ctx, CallbackArguments args, Func<ulong, ulong, ulong> operation)
		{
			return null;
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0xDCD8F8", Offset = "0xDCD8F8", VA = "0xDCD8F8")]
		private DynValue PerformUnaryOperationS(string funcName, ScriptExecutionContext ctx, CallbackArguments args, Func<long, long> operation)
		{
			return null;
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0xDCD9F0", Offset = "0xDCD9F0", VA = "0xDCD9F0")]
		private DynValue PerformUnaryOperationU(string funcName, ScriptExecutionContext ctx, CallbackArguments args, Func<ulong, ulong> operation)
		{
			return null;
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0xDCDAE8", Offset = "0xDCDAE8", VA = "0xDCDAE8")]
		internal DynValue Callback_Or(ScriptExecutionContext ctx, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0xDCDC98", Offset = "0xDCDC98", VA = "0xDCDC98")]
		internal DynValue Callback_And(ScriptExecutionContext ctx, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0xDCDE48", Offset = "0xDCDE48", VA = "0xDCDE48")]
		internal DynValue Callback_Xor(ScriptExecutionContext ctx, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0xDCDFF8", Offset = "0xDCDFF8", VA = "0xDCDFF8")]
		internal DynValue Callback_BwNot(ScriptExecutionContext ctx, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0xDCE1A8", Offset = "0xDCE1A8", VA = "0xDCE1A8")]
		internal DynValue Callback_HasAll(ScriptExecutionContext ctx, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0xDCE358", Offset = "0xDCE358", VA = "0xDCE358")]
		internal DynValue Callback_HasAny(ScriptExecutionContext ctx, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0xDCE508", Offset = "0xDCE508", VA = "0xDCE508", Slot = "19")]
		public override bool IsTypeCompatible(Type type, object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0xDCE59C", Offset = "0xDCE59C", VA = "0xDCE59C", Slot = "18")]
		public override DynValue MetaIndex(Script script, object obj, string metaname)
		{
			return null;
		}
	}
	[Token(Token = "0x20000D8")]
	public class StandardGenericsUserDataDescriptor : IUserDataDescriptor, IGeneratorUserDataDescriptor
	{
		[Token(Token = "0x170000F4")]
		public InteropAccessMode AccessMode
		{
			[Token(Token = "0x60005E5")]
			[Address(RVA = "0xDCEF90", Offset = "0xDCEF90", VA = "0xDCEF90")]
			[CompilerGenerated]
			get
			{
				return default(InteropAccessMode);
			}
			[Token(Token = "0x60005E6")]
			[Address(RVA = "0xDCEF98", Offset = "0xDCEF98", VA = "0xDCEF98")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000F5")]
		public string Name
		{
			[Token(Token = "0x60005E8")]
			[Address(RVA = "0xDCF08C", Offset = "0xDCF08C", VA = "0xDCF08C", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60005E9")]
			[Address(RVA = "0xDCF094", Offset = "0xDCF094", VA = "0xDCF094")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000F6")]
		public Type Type
		{
			[Token(Token = "0x60005EA")]
			[Address(RVA = "0xDCF09C", Offset = "0xDCF09C", VA = "0xDCF09C", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60005EB")]
			[Address(RVA = "0xDCF0A4", Offset = "0xDCF0A4", VA = "0xDCF0A4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0xDCEFA0", Offset = "0xDCEFA0", VA = "0xDCEFA0")]
		public StandardGenericsUserDataDescriptor(Type type, InteropAccessMode accessMode)
		{
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0xDCF0AC", Offset = "0xDCF0AC", VA = "0xDCF0AC", Slot = "6")]
		public DynValue Index(Script script, object obj, DynValue index, bool isDirectIndexing)
		{
			return null;
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0xDCF0B4", Offset = "0xDCF0B4", VA = "0xDCF0B4", Slot = "7")]
		public bool SetIndex(Script script, object obj, DynValue index, DynValue value, bool isDirectIndexing)
		{
			return default(bool);
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0xDCF0BC", Offset = "0xDCF0BC", VA = "0xDCF0BC", Slot = "8")]
		public string AsString(object obj)
		{
			return null;
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0xDCF0DC", Offset = "0xDCF0DC", VA = "0xDCF0DC", Slot = "9")]
		public DynValue MetaIndex(Script script, object obj, string metaname)
		{
			return null;
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0xDCF0E4", Offset = "0xDCF0E4", VA = "0xDCF0E4", Slot = "10")]
		public bool IsTypeCompatible(Type type, object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0xDCF198", Offset = "0xDCF198", VA = "0xDCF198", Slot = "11")]
		public IUserDataDescriptor Generate(Type type)
		{
			return null;
		}
	}
	[Token(Token = "0x20000D9")]
	public class StandardUserDataDescriptor : DispatchingUserDataDescriptor, IWireableDescriptor
	{
		[Token(Token = "0x170000F7")]
		public InteropAccessMode AccessMode
		{
			[Token(Token = "0x60005F2")]
			[Address(RVA = "0xDCF2B8", Offset = "0xDCF2B8", VA = "0xDCF2B8")]
			[CompilerGenerated]
			get
			{
				return default(InteropAccessMode);
			}
			[Token(Token = "0x60005F3")]
			[Address(RVA = "0xDCF2C0", Offset = "0xDCF2C0", VA = "0xDCF2C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0xDCF2C8", Offset = "0xDCF2C8", VA = "0xDCF2C8")]
		public StandardUserDataDescriptor(Type type, InteropAccessMode accessMode, [Optional] string friendlyName)
		{
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0xDCF494", Offset = "0xDCF494", VA = "0xDCF494")]
		private void FillMemberList()
		{
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0xDD0594", Offset = "0xDD0594", VA = "0xDD0594", Slot = "20")]
		public void PrepareForWiring(Table t)
		{
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0xDD0880", Offset = "0xDD0880", VA = "0xDD0880")]
		private void Serialize(Table t, IEnumerable<KeyValuePair<string, IMemberDescriptor>> members)
		{
		}
	}
	[Token(Token = "0x20000DB")]
	public enum UserDataMemberType
	{
		[Token(Token = "0x40002BA")]
		Constructor,
		[Token(Token = "0x40002BB")]
		Method,
		[Token(Token = "0x40002BC")]
		Property,
		[Token(Token = "0x40002BD")]
		Field,
		[Token(Token = "0x40002BE")]
		Event
	}
	[Token(Token = "0x20000DC")]
	internal static class NamespaceDoc
	{
	}
}
namespace MoonSharp.Interpreter.Interop.UserDataRegistries
{
	[Token(Token = "0x20000DD")]
	internal class ExtensionMethodsRegistry
	{
		[Token(Token = "0x20000DE")]
		private class UnresolvedGenericMethod
		{
			[Token(Token = "0x40002C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public readonly MethodInfo Method;

			[Token(Token = "0x40002C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public readonly InteropAccessMode AccessMode;

			[Token(Token = "0x40002C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public readonly HashSet<Type> AlreadyAddedTypes;

			[Token(Token = "0x6000604")]
			[Address(RVA = "0xDD158C", Offset = "0xDD158C", VA = "0xDD158C")]
			public UnresolvedGenericMethod(MethodInfo mi, InteropAccessMode mode)
			{
			}
		}

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static object s_Lock;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static MultiDictionary<string, IOverloadableMemberDescriptor> s_Registry;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static MultiDictionary<string, UnresolvedGenericMethod> s_UnresolvedGenericsRegistry;

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static int s_ExtensionMethodChangeVersion;

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0xDD0DB0", Offset = "0xDD0DB0", VA = "0xDD0DB0")]
		public static void RegisterExtensionType(Type type, InteropAccessMode mode = InteropAccessMode.Default)
		{
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0xDD1624", Offset = "0xDD1624", VA = "0xDD1624")]
		private static object FrameworkGetMethods()
		{
			return null;
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0xDD1664", Offset = "0xDD1664", VA = "0xDD1664")]
		public static IEnumerable<IOverloadableMemberDescriptor> GetExtensionMethodsByName(string name)
		{
			return null;
		}

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0xDD1804", Offset = "0xDD1804", VA = "0xDD1804")]
		public static int GetExtensionMethodsChangeVersion()
		{
			return default(int);
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0xDD185C", Offset = "0xDD185C", VA = "0xDD185C")]
		public static List<IOverloadableMemberDescriptor> GetExtensionMethodsByNameAndType(string name, Type extendedType)
		{
			return null;
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0xDD2270", Offset = "0xDD2270", VA = "0xDD2270")]
		private static MethodInfo InstantiateMethodInfo(MethodInfo mi, Type extensionType, Type genericType, Type extendedType)
		{
			return null;
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0xDD1E30", Offset = "0xDD1E30", VA = "0xDD1E30")]
		private static Type GetGenericMatch(Type extensionType, Type extendedType)
		{
			return null;
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0xDD2384", Offset = "0xDD2384", VA = "0xDD2384")]
		public ExtensionMethodsRegistry()
		{
		}
	}
	[Token(Token = "0x20000E1")]
	internal static class TypeDescriptorRegistry
	{
		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static object s_Lock;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Dictionary<Type, IUserDataDescriptor> s_TypeRegistry;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static Dictionary<Type, IUserDataDescriptor> s_TypeRegistryHistory;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static InteropAccessMode s_DefaultAccessMode;

		[Token(Token = "0x170000F8")]
		internal static InteropAccessMode DefaultAccessMode
		{
			[Token(Token = "0x600060D")]
			[Address(RVA = "0xDD3658", Offset = "0xDD3658", VA = "0xDD3658")]
			get
			{
				return default(InteropAccessMode);
			}
			[Token(Token = "0x600060E")]
			[Address(RVA = "0xDD36B0", Offset = "0xDD36B0", VA = "0xDD36B0")]
			set
			{
			}
		}

		[Token(Token = "0x170000F9")]
		public static IEnumerable<KeyValuePair<Type, IUserDataDescriptor>> RegisteredTypes
		{
			[Token(Token = "0x6000616")]
			[Address(RVA = "0xDD4FDC", Offset = "0xDD4FDC", VA = "0xDD4FDC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000FA")]
		public static IEnumerable<KeyValuePair<Type, IUserDataDescriptor>> RegisteredTypesHistory
		{
			[Token(Token = "0x6000617")]
			[Address(RVA = "0xDD5118", Offset = "0xDD5118", VA = "0xDD5118")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000FB")]
		internal static IRegistrationPolicy RegistrationPolicy
		{
			[Token(Token = "0x6000618")]
			[Address(RVA = "0xDD5254", Offset = "0xDD5254", VA = "0xDD5254")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000619")]
			[Address(RVA = "0xDD52AC", Offset = "0xDD52AC", VA = "0xDD52AC")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0xDD2700", Offset = "0xDD2700", VA = "0xDD2700")]
		internal static void RegisterAssembly([Optional] Assembly asm, bool includeExtensionTypes = false)
		{
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0xDD31A0", Offset = "0xDD31A0", VA = "0xDD31A0")]
		internal static bool IsTypeRegistered(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0xDD32F0", Offset = "0xDD32F0", VA = "0xDD32F0")]
		internal static void UnregisterType(Type t)
		{
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0xDD3760", Offset = "0xDD3760", VA = "0xDD3760")]
		internal static IUserDataDescriptor RegisterProxyType_Impl(IProxyFactory proxyFactory, InteropAccessMode accessMode, string friendlyName)
		{
			return null;
		}

		[Token(Token = "0x6000610")]
		[Address(RVA = "0xDD390C", Offset = "0xDD390C", VA = "0xDD390C")]
		internal static IUserDataDescriptor RegisterType_Impl(Type type, InteropAccessMode accessMode, string friendlyName, IUserDataDescriptor descriptor)
		{
			return null;
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0xDD34A4", Offset = "0xDD34A4", VA = "0xDD34A4")]
		private static IUserDataDescriptor PerformRegistration(Type type, IUserDataDescriptor newDescriptor, IUserDataDescriptor oldDescriptor)
		{
			return null;
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0xDD3FC0", Offset = "0xDD3FC0", VA = "0xDD3FC0")]
		internal static InteropAccessMode ResolveDefaultAccessModeForType(InteropAccessMode accessMode, Type type)
		{
			return default(InteropAccessMode);
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0xDD4290", Offset = "0xDD4290", VA = "0xDD4290")]
		internal static IUserDataDescriptor GetDescriptorForType(Type type, bool searchInterfaces)
		{
			return null;
		}

		[Token(Token = "0x6000614")]
		[Address(RVA = "0xDD4F9C", Offset = "0xDD4F9C", VA = "0xDD4F9C")]
		private static bool FrameworkIsAssignableFrom(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0xDD40F4", Offset = "0xDD40F4", VA = "0xDD40F4")]
		public static bool IsTypeBlacklisted(Type t)
		{
			return default(bool);
		}
	}
}
namespace MoonSharp.Interpreter.Interop.StandardDescriptors
{
	[Token(Token = "0x20000E4")]
	internal class EventFacade : IUserDataType
	{
		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Func<object, ScriptExecutionContext, CallbackArguments, DynValue> m_AddCallback;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Func<object, ScriptExecutionContext, CallbackArguments, DynValue> m_RemoveCallback;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private object m_Object;

		[Token(Token = "0x6000626")]
		[Address(RVA = "0xDD5A2C", Offset = "0xDD5A2C", VA = "0xDD5A2C")]
		public EventFacade(EventMemberDescriptor parent, object obj)
		{
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0xDD5B00", Offset = "0xDD5B00", VA = "0xDD5B00")]
		public EventFacade(Func<object, ScriptExecutionContext, CallbackArguments, DynValue> addCallback, Func<object, ScriptExecutionContext, CallbackArguments, DynValue> removeCallback, object obj)
		{
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0xDD5B3C", Offset = "0xDD5B3C", VA = "0xDD5B3C", Slot = "4")]
		public DynValue Index(Script script, DynValue index, bool isDirectIndexing)
		{
			return null;
		}

		[Token(Token = "0x6000629")]
		[Address(RVA = "0xDD5CD4", Offset = "0xDD5CD4", VA = "0xDD5CD4", Slot = "5")]
		public bool SetIndex(Script script, DynValue index, DynValue value, bool isDirectIndexing)
		{
			return default(bool);
		}

		[Token(Token = "0x600062A")]
		[Address(RVA = "0xDD5D24", Offset = "0xDD5D24", VA = "0xDD5D24", Slot = "6")]
		public DynValue MetaIndex(Script script, string metaname)
		{
			return null;
		}
	}
}
namespace MoonSharp.Interpreter.Interop.StandardDescriptors.HardwiredDescriptors
{
	[Token(Token = "0x20000E5")]
	public sealed class DefaultValue
	{
		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly DefaultValue Instance;

		[Token(Token = "0x600062D")]
		[Address(RVA = "0xDD5D8C", Offset = "0xDD5D8C", VA = "0xDD5D8C")]
		public DefaultValue()
		{
		}
	}
	[Token(Token = "0x20000E6")]
	public abstract class HardwiredMemberDescriptor : IMemberDescriptor
	{
		[Token(Token = "0x170000FC")]
		public Type MemberType
		{
			[Token(Token = "0x600062F")]
			[Address(RVA = "0xDD5DF8", Offset = "0xDD5DF8", VA = "0xDD5DF8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000630")]
			[Address(RVA = "0xDD5E00", Offset = "0xDD5E00", VA = "0xDD5E00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000FD")]
		public bool IsStatic
		{
			[Token(Token = "0x6000632")]
			[Address(RVA = "0xDD5E54", Offset = "0xDD5E54", VA = "0xDD5E54", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000633")]
			[Address(RVA = "0xDD5E5C", Offset = "0xDD5E5C", VA = "0xDD5E5C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000FE")]
		public string Name
		{
			[Token(Token = "0x6000634")]
			[Address(RVA = "0xDD5E68", Offset = "0xDD5E68", VA = "0xDD5E68", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000635")]
			[Address(RVA = "0xDD5E70", Offset = "0xDD5E70", VA = "0xDD5E70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000FF")]
		public MemberDescriptorAccess MemberAccess
		{
			[Token(Token = "0x6000636")]
			[Address(RVA = "0xDD5E78", Offset = "0xDD5E78", VA = "0xDD5E78", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(MemberDescriptorAccess);
			}
			[Token(Token = "0x6000637")]
			[Address(RVA = "0xDD5E80", Offset = "0xDD5E80", VA = "0xDD5E80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0xDD5E08", Offset = "0xDD5E08", VA = "0xDD5E08")]
		protected HardwiredMemberDescriptor(Type memberType, string name, bool isStatic, MemberDescriptorAccess access)
		{
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0xDD5E88", Offset = "0xDD5E88", VA = "0xDD5E88", Slot = "7")]
		public DynValue GetValue(Script script, object obj)
		{
			return null;
		}

		[Token(Token = "0x6000639")]
		[Address(RVA = "0xDD5ED4", Offset = "0xDD5ED4", VA = "0xDD5ED4", Slot = "8")]
		public void SetValue(Script script, object obj, DynValue value)
		{
		}

		[Token(Token = "0x600063A")]
		[Address(RVA = "0xDD5F3C", Offset = "0xDD5F3C", VA = "0xDD5F3C", Slot = "9")]
		protected virtual object GetValueImpl(Script script, object obj)
		{
			return null;
		}

		[Token(Token = "0x600063B")]
		[Address(RVA = "0xDD5FA4", Offset = "0xDD5FA4", VA = "0xDD5FA4", Slot = "10")]
		protected virtual void SetValueImpl(Script script, object obj, object value)
		{
		}
	}
	[Token(Token = "0x20000E7")]
	public abstract class HardwiredMethodMemberDescriptor : FunctionMemberDescriptorBase
	{
		[Token(Token = "0x600063C")]
		[Address(RVA = "0xDD600C", Offset = "0xDD600C", VA = "0xDD600C", Slot = "16")]
		public override DynValue Execute(Script script, object obj, ScriptExecutionContext context, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0xDD6108", Offset = "0xDD6108", VA = "0xDD6108")]
		private int CalcArgsCount(object[] pars)
		{
			return default(int);
		}

		[Token(Token = "0x600063E")]
		protected abstract object Invoke(Script script, object obj, object[] pars, int argscount);

		[Token(Token = "0x600063F")]
		[Address(RVA = "0xDD61CC", Offset = "0xDD61CC", VA = "0xDD61CC")]
		protected HardwiredMethodMemberDescriptor()
		{
		}
	}
	[Token(Token = "0x20000E8")]
	public abstract class HardwiredUserDataDescriptor : DispatchingUserDataDescriptor
	{
		[Token(Token = "0x6000640")]
		[Address(RVA = "0xDD61D4", Offset = "0xDD61D4", VA = "0xDD61D4")]
		protected HardwiredUserDataDescriptor(Type T)
		{
		}
	}
}
namespace MoonSharp.Interpreter.Interop.RegistrationPolicies
{
	[Token(Token = "0x20000E9")]
	public class AutomaticRegistrationPolicy : DefaultRegistrationPolicy
	{
		[Token(Token = "0x6000641")]
		[Address(RVA = "0xDD6254", Offset = "0xDD6254", VA = "0xDD6254", Slot = "6")]
		public override bool AllowTypeAutoRegistration(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0xDD625C", Offset = "0xDD625C", VA = "0xDD625C")]
		public AutomaticRegistrationPolicy()
		{
		}
	}
	[Token(Token = "0x20000EA")]
	public class DefaultRegistrationPolicy : IRegistrationPolicy
	{
		[Token(Token = "0x6000643")]
		[Address(RVA = "0xDD626C", Offset = "0xDD626C", VA = "0xDD626C", Slot = "4")]
		public IUserDataDescriptor HandleRegistration(IUserDataDescriptor newDescriptor, IUserDataDescriptor oldDescriptor)
		{
			return null;
		}

		[Token(Token = "0x6000644")]
		[Address(RVA = "0xDD6284", Offset = "0xDD6284", VA = "0xDD6284", Slot = "6")]
		public virtual bool AllowTypeAutoRegistration(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000645")]
		[Address(RVA = "0xDD6264", Offset = "0xDD6264", VA = "0xDD6264")]
		public DefaultRegistrationPolicy()
		{
		}
	}
	[Token(Token = "0x20000EB")]
	public interface IRegistrationPolicy
	{
		[Token(Token = "0x6000646")]
		IUserDataDescriptor HandleRegistration(IUserDataDescriptor newDescriptor, IUserDataDescriptor oldDescriptor);

		[Token(Token = "0x6000647")]
		bool AllowTypeAutoRegistration(Type type);
	}
	[Token(Token = "0x20000EC")]
	public class PermanentRegistrationPolicy : IRegistrationPolicy
	{
		[Token(Token = "0x6000648")]
		[Address(RVA = "0xDD628C", Offset = "0xDD628C", VA = "0xDD628C", Slot = "4")]
		public IUserDataDescriptor HandleRegistration(IUserDataDescriptor newDescriptor, IUserDataDescriptor oldDescriptor)
		{
			return null;
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0xDD6298", Offset = "0xDD6298", VA = "0xDD6298", Slot = "5")]
		public bool AllowTypeAutoRegistration(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0xDD62A0", Offset = "0xDD62A0", VA = "0xDD62A0")]
		public PermanentRegistrationPolicy()
		{
		}
	}
}
namespace MoonSharp.Interpreter.Interop.LuaStateInterop
{
	[Token(Token = "0x20000ED")]
	public class CharPtr
	{
		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public char[] chars;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int index;

		[Token(Token = "0x17000100")]
		public char this[int offset]
		{
			[Token(Token = "0x600064B")]
			[Address(RVA = "0xDD62A8", Offset = "0xDD62A8", VA = "0xDD62A8")]
			get
			{
				return default(char);
			}
			[Token(Token = "0x600064C")]
			[Address(RVA = "0xDD62E0", Offset = "0xDD62E0", VA = "0xDD62E0")]
			set
			{
			}
		}

		[Token(Token = "0x17000101")]
		public char this[uint offset]
		{
			[Token(Token = "0x600064D")]
			[Address(RVA = "0xDD6318", Offset = "0xDD6318", VA = "0xDD6318")]
			get
			{
				return default(char);
			}
			[Token(Token = "0x600064E")]
			[Address(RVA = "0xDD6380", Offset = "0xDD6380", VA = "0xDD6380")]
			set
			{
			}
		}

		[Token(Token = "0x17000102")]
		public char this[long offset]
		{
			[Token(Token = "0x600064F")]
			[Address(RVA = "0xDD63F4", Offset = "0xDD63F4", VA = "0xDD63F4")]
			get
			{
				return default(char);
			}
			[Token(Token = "0x6000650")]
			[Address(RVA = "0xDD642C", Offset = "0xDD642C", VA = "0xDD642C")]
			set
			{
			}
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0xDD6464", Offset = "0xDD6464", VA = "0xDD6464")]
		public static implicit operator CharPtr(string str)
		{
			return null;
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0xDD6544", Offset = "0xDD6544", VA = "0xDD6544")]
		public static implicit operator CharPtr(char[] chars)
		{
			return null;
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0xDD65D8", Offset = "0xDD65D8", VA = "0xDD65D8")]
		public static implicit operator CharPtr(byte[] bytes)
		{
			return null;
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0xDD66F4", Offset = "0xDD66F4", VA = "0xDD66F4")]
		public CharPtr()
		{
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0xDD64C4", Offset = "0xDD64C4", VA = "0xDD64C4")]
		public CharPtr(string str)
		{
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0xDD6714", Offset = "0xDD6714", VA = "0xDD6714")]
		public CharPtr(CharPtr ptr)
		{
		}

		[Token(Token = "0x6000657")]
		[Address(RVA = "0xDD6750", Offset = "0xDD6750", VA = "0xDD6750")]
		public CharPtr(CharPtr ptr, int index)
		{
		}

		[Token(Token = "0x6000658")]
		[Address(RVA = "0xDD65AC", Offset = "0xDD65AC", VA = "0xDD65AC")]
		public CharPtr(char[] chars)
		{
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0xDD678C", Offset = "0xDD678C", VA = "0xDD678C")]
		public CharPtr(char[] chars, int index)
		{
		}

		[Token(Token = "0x600065A")]
		[Address(RVA = "0xDD6638", Offset = "0xDD6638", VA = "0xDD6638")]
		public CharPtr(byte[] bytes)
		{
		}

		[Token(Token = "0x600065B")]
		[Address(RVA = "0xDD67BC", Offset = "0xDD67BC", VA = "0xDD67BC")]
		public CharPtr(IntPtr ptr)
		{
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0xDD681C", Offset = "0xDD681C", VA = "0xDD681C")]
		public static CharPtr operator +(CharPtr ptr, int offset)
		{
			return null;
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0xDD68A0", Offset = "0xDD68A0", VA = "0xDD68A0")]
		public static CharPtr operator -(CharPtr ptr, int offset)
		{
			return null;
		}

		[Token(Token = "0x600065E")]
		[Address(RVA = "0xDD6924", Offset = "0xDD6924", VA = "0xDD6924")]
		public static CharPtr operator +(CharPtr ptr, uint offset)
		{
			return null;
		}

		[Token(Token = "0x600065F")]
		[Address(RVA = "0xDD69A8", Offset = "0xDD69A8", VA = "0xDD69A8")]
		public static CharPtr operator -(CharPtr ptr, uint offset)
		{
			return null;
		}

		[Token(Token = "0x6000660")]
		[Address(RVA = "0xDD6A2C", Offset = "0xDD6A2C", VA = "0xDD6A2C")]
		public void inc()
		{
		}

		[Token(Token = "0x6000661")]
		[Address(RVA = "0xDD6A3C", Offset = "0xDD6A3C", VA = "0xDD6A3C")]
		public void dec()
		{
		}

		[Token(Token = "0x6000662")]
		[Address(RVA = "0xDD6A4C", Offset = "0xDD6A4C", VA = "0xDD6A4C")]
		public CharPtr next()
		{
			return null;
		}

		[Token(Token = "0x6000663")]
		[Address(RVA = "0xDD6AC8", Offset = "0xDD6AC8", VA = "0xDD6AC8")]
		public CharPtr prev()
		{
			return null;
		}

		[Token(Token = "0x6000664")]
		[Address(RVA = "0xDD6B44", Offset = "0xDD6B44", VA = "0xDD6B44")]
		public CharPtr add(int ofs)
		{
			return null;
		}

		[Token(Token = "0x6000665")]
		[Address(RVA = "0xDD6BC4", Offset = "0xDD6BC4", VA = "0xDD6BC4")]
		public CharPtr sub(int ofs)
		{
			return null;
		}

		[Token(Token = "0x6000666")]
		[Address(RVA = "0xDD6C44", Offset = "0xDD6C44", VA = "0xDD6C44")]
		public static bool operator ==(CharPtr ptr, char ch)
		{
			return default(bool);
		}

		[Token(Token = "0x6000667")]
		[Address(RVA = "0xDD6C70", Offset = "0xDD6C70", VA = "0xDD6C70")]
		public static bool operator ==(char ch, CharPtr ptr)
		{
			return default(bool);
		}

		[Token(Token = "0x6000668")]
		[Address(RVA = "0xDD6CA0", Offset = "0xDD6CA0", VA = "0xDD6CA0")]
		public static bool operator !=(CharPtr ptr, char ch)
		{
			return default(bool);
		}

		[Token(Token = "0x6000669")]
		[Address(RVA = "0xDD6CCC", Offset = "0xDD6CCC", VA = "0xDD6CCC")]
		public static bool operator !=(char ch, CharPtr ptr)
		{
			return default(bool);
		}

		[Token(Token = "0x600066A")]
		[Address(RVA = "0xDD6CFC", Offset = "0xDD6CFC", VA = "0xDD6CFC")]
		public static CharPtr operator +(CharPtr ptr1, CharPtr ptr2)
		{
			return null;
		}

		[Token(Token = "0x600066B")]
		[Address(RVA = "0xDD6E4C", Offset = "0xDD6E4C", VA = "0xDD6E4C")]
		public static int operator -(CharPtr ptr1, CharPtr ptr2)
		{
			return default(int);
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0xDD6E70", Offset = "0xDD6E70", VA = "0xDD6E70")]
		public static bool operator <(CharPtr ptr1, CharPtr ptr2)
		{
			return default(bool);
		}

		[Token(Token = "0x600066D")]
		[Address(RVA = "0xDD6E98", Offset = "0xDD6E98", VA = "0xDD6E98")]
		public static bool operator <=(CharPtr ptr1, CharPtr ptr2)
		{
			return default(bool);
		}

		[Token(Token = "0x600066E")]
		[Address(RVA = "0xDD6EC0", Offset = "0xDD6EC0", VA = "0xDD6EC0")]
		public static bool operator >(CharPtr ptr1, CharPtr ptr2)
		{
			return default(bool);
		}

		[Token(Token = "0x600066F")]
		[Address(RVA = "0xDD6EE8", Offset = "0xDD6EE8", VA = "0xDD6EE8")]
		public static bool operator >=(CharPtr ptr1, CharPtr ptr2)
		{
			return default(bool);
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0xDD6F10", Offset = "0xDD6F10", VA = "0xDD6F10")]
		public static bool operator ==(CharPtr ptr1, CharPtr ptr2)
		{
			return default(bool);
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0xDD6F54", Offset = "0xDD6F54", VA = "0xDD6F54")]
		public static bool operator !=(CharPtr ptr1, CharPtr ptr2)
		{
			return default(bool);
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0xDD6F98", Offset = "0xDD6F98", VA = "0xDD6F98", Slot = "0")]
		public override bool Equals(object o)
		{
			return default(bool);
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0xDD7050", Offset = "0xDD7050", VA = "0xDD7050", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0xDD7058", Offset = "0xDD7058", VA = "0xDD7058", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000675")]
		[Address(RVA = "0xDD7114", Offset = "0xDD7114", VA = "0xDD7114")]
		public string ToString(int length)
		{
			return null;
		}
	}
	[Token(Token = "0x20000EE")]
	public class LuaBase
	{
		[Token(Token = "0x40002E1")]
		protected const int LUA_TNONE = -1;

		[Token(Token = "0x40002E2")]
		protected const int LUA_TNIL = 0;

		[Token(Token = "0x40002E3")]
		protected const int LUA_TBOOLEAN = 1;

		[Token(Token = "0x40002E4")]
		protected const int LUA_TLIGHTUSERDATA = 2;

		[Token(Token = "0x40002E5")]
		protected const int LUA_TNUMBER = 3;

		[Token(Token = "0x40002E6")]
		protected const int LUA_TSTRING = 4;

		[Token(Token = "0x40002E7")]
		protected const int LUA_TTABLE = 5;

		[Token(Token = "0x40002E8")]
		protected const int LUA_TFUNCTION = 6;

		[Token(Token = "0x40002E9")]
		protected const int LUA_TUSERDATA = 7;

		[Token(Token = "0x40002EA")]
		protected const int LUA_TTHREAD = 8;

		[Token(Token = "0x40002EB")]
		protected const int LUA_MULTRET = -1;

		[Token(Token = "0x40002EC")]
		protected const string LUA_INTFRMLEN = "l";

		[Token(Token = "0x6000676")]
		[Address(RVA = "0xDD71DC", Offset = "0xDD71DC", VA = "0xDD71DC")]
		protected static DynValue GetArgument(LuaState L, int pos)
		{
			return null;
		}

		[Token(Token = "0x6000677")]
		[Address(RVA = "0xDD72E0", Offset = "0xDD72E0", VA = "0xDD72E0")]
		protected static DynValue ArgAsType(LuaState L, int pos, DataType type, bool allowNil = false)
		{
			return null;
		}

		[Token(Token = "0x6000678")]
		[Address(RVA = "0xDD7338", Offset = "0xDD7338", VA = "0xDD7338")]
		protected static int LuaType(LuaState L, int p)
		{
			return default(int);
		}

		[Token(Token = "0x6000679")]
		[Address(RVA = "0xDD73C4", Offset = "0xDD73C4", VA = "0xDD73C4")]
		protected static string LuaLCheckLString(LuaState L, int argNum, out uint l)
		{
			return null;
		}

		[Token(Token = "0x600067A")]
		[Address(RVA = "0xDD73FC", Offset = "0xDD73FC", VA = "0xDD73FC")]
		protected static void LuaPushInteger(LuaState L, int val)
		{
		}

		[Token(Token = "0x600067B")]
		[Address(RVA = "0xDD751C", Offset = "0xDD751C", VA = "0xDD751C")]
		protected static int LuaToBoolean(LuaState L, int p)
		{
			return default(int);
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0xDD7544", Offset = "0xDD7544", VA = "0xDD7544")]
		protected static string LuaToLString(LuaState luaState, int p, out uint l)
		{
			return null;
		}

		[Token(Token = "0x600067D")]
		[Address(RVA = "0xDD7548", Offset = "0xDD7548", VA = "0xDD7548")]
		protected static string LuaToString(LuaState luaState, int p)
		{
			return null;
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0xDD7560", Offset = "0xDD7560", VA = "0xDD7560")]
		protected static void LuaLAddValue(LuaLBuffer b)
		{
		}

		[Token(Token = "0x600067F")]
		[Address(RVA = "0xDD7624", Offset = "0xDD7624", VA = "0xDD7624")]
		protected static void LuaLAddLString(LuaLBuffer b, CharPtr s, uint p)
		{
		}

		[Token(Token = "0x6000680")]
		[Address(RVA = "0xDD765C", Offset = "0xDD765C", VA = "0xDD765C")]
		protected static void LuaLAddString(LuaLBuffer b, string s)
		{
		}

		[Token(Token = "0x6000681")]
		[Address(RVA = "0xDD769C", Offset = "0xDD769C", VA = "0xDD769C")]
		protected static int LuaLOptInteger(LuaState L, int pos, int def)
		{
			return default(int);
		}

		[Token(Token = "0x6000682")]
		[Address(RVA = "0xDD76F8", Offset = "0xDD76F8", VA = "0xDD76F8")]
		protected static int LuaLCheckInteger(LuaState L, int pos)
		{
			return default(int);
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0xDD7734", Offset = "0xDD7734", VA = "0xDD7734")]
		protected static void LuaLArgCheck(LuaState L, bool condition, int argNum, string message)
		{
		}

		[Token(Token = "0x6000684")]
		[Address(RVA = "0xDD7794", Offset = "0xDD7794", VA = "0xDD7794")]
		protected static int LuaLCheckInt(LuaState L, int argNum)
		{
			return default(int);
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0xDD7798", Offset = "0xDD7798", VA = "0xDD7798")]
		protected static int LuaGetTop(LuaState L)
		{
			return default(int);
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0xDD77F0", Offset = "0xDD77F0", VA = "0xDD77F0")]
		protected static int LuaLError(LuaState luaState, string message, params object[] args)
		{
			return default(int);
		}

		[Token(Token = "0x6000687")]
		[Address(RVA = "0xDD7844", Offset = "0xDD7844", VA = "0xDD7844")]
		protected static void LuaLAddChar(LuaLBuffer b, char p)
		{
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0xDD7864", Offset = "0xDD7864", VA = "0xDD7864")]
		protected static void LuaLBuffInit(LuaState L, LuaLBuffer b)
		{
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0xDD7868", Offset = "0xDD7868", VA = "0xDD7868")]
		protected static void LuaPushLiteral(LuaState L, string literalString)
		{
		}

		[Token(Token = "0x600068A")]
		[Address(RVA = "0xDD78E0", Offset = "0xDD78E0", VA = "0xDD78E0")]
		protected static void LuaLPushResult(LuaLBuffer b)
		{
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0xDD7918", Offset = "0xDD7918", VA = "0xDD7918")]
		protected static void LuaPushLString(LuaState L, CharPtr s, uint len)
		{
		}

		[Token(Token = "0x600068C")]
		[Address(RVA = "0xDD79AC", Offset = "0xDD79AC", VA = "0xDD79AC")]
		protected static void LuaLCheckStack(LuaState L, int n, string message)
		{
		}

		[Token(Token = "0x600068D")]
		[Address(RVA = "0xDD79B0", Offset = "0xDD79B0", VA = "0xDD79B0")]
		protected static string LUA_QL(string p)
		{
			return null;
		}

		[Token(Token = "0x600068E")]
		[Address(RVA = "0xDD7A00", Offset = "0xDD7A00", VA = "0xDD7A00")]
		protected static void LuaPushNil(LuaState L)
		{
		}

		[Token(Token = "0x600068F")]
		[Address(RVA = "0xDD7A98", Offset = "0xDD7A98", VA = "0xDD7A98")]
		protected static void LuaAssert(bool p)
		{
		}

		[Token(Token = "0x6000690")]
		[Address(RVA = "0xDD7A9C", Offset = "0xDD7A9C", VA = "0xDD7A9C")]
		protected static string LuaLTypeName(LuaState L, int p)
		{
			return null;
		}

		[Token(Token = "0x6000691")]
		[Address(RVA = "0xDD7AC0", Offset = "0xDD7AC0", VA = "0xDD7AC0")]
		protected static int LuaIsString(LuaState L, int p)
		{
			return default(int);
		}

		[Token(Token = "0x6000692")]
		[Address(RVA = "0xDD7AEC", Offset = "0xDD7AEC", VA = "0xDD7AEC")]
		protected static void LuaPop(LuaState L, int p)
		{
		}

		[Token(Token = "0x6000693")]
		[Address(RVA = "0xDD7B28", Offset = "0xDD7B28", VA = "0xDD7B28")]
		protected static void LuaGetTable(LuaState L, int p)
		{
		}

		[Token(Token = "0x6000694")]
		[Address(RVA = "0xDD7BD4", Offset = "0xDD7BD4", VA = "0xDD7BD4")]
		protected static int LuaLOptInt(LuaState L, int pos, int def)
		{
			return default(int);
		}

		[Token(Token = "0x6000695")]
		[Address(RVA = "0xDD7BD8", Offset = "0xDD7BD8", VA = "0xDD7BD8")]
		protected static CharPtr LuaLCheckString(LuaState L, int p)
		{
			return null;
		}

		[Token(Token = "0x6000696")]
		[Address(RVA = "0xDD7BF0", Offset = "0xDD7BF0", VA = "0xDD7BF0")]
		protected static string LuaLCheckStringStr(LuaState L, int p)
		{
			return null;
		}

		[Token(Token = "0x6000697")]
		[Address(RVA = "0xDD774C", Offset = "0xDD774C", VA = "0xDD774C")]
		protected static void LuaLArgError(LuaState L, int arg, string p)
		{
		}

		[Token(Token = "0x6000698")]
		[Address(RVA = "0xDD7C08", Offset = "0xDD7C08", VA = "0xDD7C08")]
		protected static double LuaLCheckNumber(LuaState L, int pos)
		{
			return default(double);
		}

		[Token(Token = "0x6000699")]
		[Address(RVA = "0xDD7C2C", Offset = "0xDD7C2C", VA = "0xDD7C2C")]
		protected static void LuaPushValue(LuaState L, int arg)
		{
		}

		[Token(Token = "0x600069A")]
		[Address(RVA = "0xDD7C50", Offset = "0xDD7C50", VA = "0xDD7C50")]
		protected static void LuaCall(LuaState L, int nargs, int nresults = -1)
		{
		}

		[Token(Token = "0x600069B")]
		[Address(RVA = "0xDD7FB4", Offset = "0xDD7FB4", VA = "0xDD7FB4")]
		protected static int memcmp(CharPtr ptr1, CharPtr ptr2, uint size)
		{
			return default(int);
		}

		[Token(Token = "0x600069C")]
		[Address(RVA = "0xDD7FB8", Offset = "0xDD7FB8", VA = "0xDD7FB8")]
		protected static int memcmp(CharPtr ptr1, CharPtr ptr2, int size)
		{
			return default(int);
		}

		[Token(Token = "0x600069D")]
		[Address(RVA = "0xDD805C", Offset = "0xDD805C", VA = "0xDD805C")]
		protected static CharPtr memchr(CharPtr ptr, char c, uint count)
		{
			return null;
		}

		[Token(Token = "0x600069E")]
		[Address(RVA = "0xDD8118", Offset = "0xDD8118", VA = "0xDD8118")]
		protected static CharPtr strpbrk(CharPtr str, CharPtr charset)
		{
			return null;
		}

		[Token(Token = "0x600069F")]
		[Address(RVA = "0xDD8238", Offset = "0xDD8238", VA = "0xDD8238")]
		protected static bool isalpha(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x60006A0")]
		[Address(RVA = "0xDD8290", Offset = "0xDD8290", VA = "0xDD8290")]
		protected static bool iscntrl(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x60006A1")]
		[Address(RVA = "0xDD82E8", Offset = "0xDD82E8", VA = "0xDD82E8")]
		protected static bool isdigit(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x60006A2")]
		[Address(RVA = "0xDD8340", Offset = "0xDD8340", VA = "0xDD8340")]
		protected static bool islower(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x60006A3")]
		[Address(RVA = "0xDD8398", Offset = "0xDD8398", VA = "0xDD8398")]
		protected static bool ispunct(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0xDD83F0", Offset = "0xDD83F0", VA = "0xDD83F0")]
		protected static bool isspace(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0xDD8418", Offset = "0xDD8418", VA = "0xDD8418")]
		protected static bool isupper(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0xDD8470", Offset = "0xDD8470", VA = "0xDD8470")]
		protected static bool isalnum(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x60006A7")]
		[Address(RVA = "0xDD84C8", Offset = "0xDD84C8", VA = "0xDD84C8")]
		protected static bool isxdigit(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x60006A8")]
		[Address(RVA = "0xDD8528", Offset = "0xDD8528", VA = "0xDD8528")]
		protected static bool isgraph(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x60006A9")]
		[Address(RVA = "0xDD85B4", Offset = "0xDD85B4", VA = "0xDD85B4")]
		protected static bool isalpha(int c)
		{
			return default(bool);
		}

		[Token(Token = "0x60006AA")]
		[Address(RVA = "0xDD860C", Offset = "0xDD860C", VA = "0xDD860C")]
		protected static bool iscntrl(int c)
		{
			return default(bool);
		}

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0xDD8664", Offset = "0xDD8664", VA = "0xDD8664")]
		protected static bool isdigit(int c)
		{
			return default(bool);
		}

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0xDD86BC", Offset = "0xDD86BC", VA = "0xDD86BC")]
		protected static bool islower(int c)
		{
			return default(bool);
		}

		[Token(Token = "0x60006AD")]
		[Address(RVA = "0xDD8714", Offset = "0xDD8714", VA = "0xDD8714")]
		protected static bool ispunct(int c)
		{
			return default(bool);
		}

		[Token(Token = "0x60006AE")]
		[Address(RVA = "0xDD8740", Offset = "0xDD8740", VA = "0xDD8740")]
		protected static bool isspace(int c)
		{
			return default(bool);
		}

		[Token(Token = "0x60006AF")]
		[Address(RVA = "0xDD8764", Offset = "0xDD8764", VA = "0xDD8764")]
		protected static bool isupper(int c)
		{
			return default(bool);
		}

		[Token(Token = "0x60006B0")]
		[Address(RVA = "0xDD87BC", Offset = "0xDD87BC", VA = "0xDD87BC")]
		protected static bool isalnum(int c)
		{
			return default(bool);
		}

		[Token(Token = "0x60006B1")]
		[Address(RVA = "0xDD8814", Offset = "0xDD8814", VA = "0xDD8814")]
		protected static bool isgraph(int c)
		{
			return default(bool);
		}

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0xDD88A0", Offset = "0xDD88A0", VA = "0xDD88A0")]
		protected static char tolower(char c)
		{
			return default(char);
		}

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0xDD88F8", Offset = "0xDD88F8", VA = "0xDD88F8")]
		protected static char toupper(char c)
		{
			return default(char);
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0xDD8950", Offset = "0xDD8950", VA = "0xDD8950")]
		protected static char tolower(int c)
		{
			return default(char);
		}

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0xDD89A8", Offset = "0xDD89A8", VA = "0xDD89A8")]
		protected static char toupper(int c)
		{
			return default(char);
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0xDD8A00", Offset = "0xDD8A00", VA = "0xDD8A00")]
		protected static CharPtr strchr(CharPtr str, char c)
		{
			return null;
		}

		[Token(Token = "0x60006B7")]
		[Address(RVA = "0xDD8AB4", Offset = "0xDD8AB4", VA = "0xDD8AB4")]
		protected static CharPtr strcpy(CharPtr dst, CharPtr src)
		{
			return null;
		}

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0xDD8B48", Offset = "0xDD8B48", VA = "0xDD8B48")]
		protected static CharPtr strncpy(CharPtr dst, CharPtr src, int length)
		{
			return null;
		}

		[Token(Token = "0x60006B9")]
		[Address(RVA = "0xDD8C14", Offset = "0xDD8C14", VA = "0xDD8C14")]
		protected static int strlen(CharPtr str)
		{
			return default(int);
		}

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0xDD8C54", Offset = "0xDD8C54", VA = "0xDD8C54")]
		public static void sprintf(CharPtr buffer, CharPtr str, params object[] argv)
		{
		}

		[Token(Token = "0x60006BB")]
		[Address(RVA = "0xDD9BF4", Offset = "0xDD9BF4", VA = "0xDD9BF4")]
		public LuaBase()
		{
		}
	}
	[Token(Token = "0x20000EF")]
	public class LuaLBuffer
	{
		[Token(Token = "0x17000103")]
		public StringBuilder StringBuilder
		{
			[Token(Token = "0x60006BC")]
			[Address(RVA = "0xDD9BFC", Offset = "0xDD9BFC", VA = "0xDD9BFC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60006BD")]
			[Address(RVA = "0xDD9C04", Offset = "0xDD9C04", VA = "0xDD9C04")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000104")]
		public LuaState LuaState
		{
			[Token(Token = "0x60006BE")]
			[Address(RVA = "0xDD9C0C", Offset = "0xDD9C0C", VA = "0xDD9C0C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60006BF")]
			[Address(RVA = "0xDD9C14", Offset = "0xDD9C14", VA = "0xDD9C14")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0xDD9C1C", Offset = "0xDD9C1C", VA = "0xDD9C1C")]
		public LuaLBuffer(LuaState l)
		{
		}
	}
	[Token(Token = "0x20000F0")]
	public class LuaState
	{
		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private List<DynValue> m_Stack;

		[Token(Token = "0x17000105")]
		public ScriptExecutionContext ExecutionContext
		{
			[Token(Token = "0x60006C1")]
			[Address(RVA = "0xDD9C94", Offset = "0xDD9C94", VA = "0xDD9C94")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60006C2")]
			[Address(RVA = "0xDD9C9C", Offset = "0xDD9C9C", VA = "0xDD9C9C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000106")]
		public string FunctionName
		{
			[Token(Token = "0x60006C3")]
			[Address(RVA = "0xDD9CA4", Offset = "0xDD9CA4", VA = "0xDD9CA4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60006C4")]
			[Address(RVA = "0xDD9CAC", Offset = "0xDD9CAC", VA = "0xDD9CAC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000107")]
		public int Count
		{
			[Token(Token = "0x60006C8")]
			[Address(RVA = "0xDD77A8", Offset = "0xDD77A8", VA = "0xDD77A8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60006C5")]
		[Address(RVA = "0xDD9CB4", Offset = "0xDD9CB4", VA = "0xDD9CB4")]
		internal LuaState(ScriptExecutionContext executionContext, CallbackArguments args, string functionName)
		{
		}

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0xDD9E04", Offset = "0xDD9E04", VA = "0xDD9E04")]
		public DynValue Top(int pos = 0)
		{
			return null;
		}

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0xDD71EC", Offset = "0xDD71EC", VA = "0xDD71EC")]
		public DynValue At(int pos)
		{
			return null;
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0xDD7474", Offset = "0xDD7474", VA = "0xDD7474")]
		public void Push(DynValue v)
		{
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0xDD75A4", Offset = "0xDD75A4", VA = "0xDD75A4")]
		public DynValue Pop()
		{
			return null;
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0xDD7E5C", Offset = "0xDD7E5C", VA = "0xDD7E5C")]
		public DynValue[] GetTopArray(int num)
		{
			return null;
		}

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0xDD9E70", Offset = "0xDD9E70", VA = "0xDD9E70")]
		public DynValue GetReturnValue(int retvals)
		{
			return null;
		}

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0xDD7F38", Offset = "0xDD7F38", VA = "0xDD7F38")]
		public void Discard(int nargs)
		{
		}
	}
	[Token(Token = "0x20000F1")]
	internal static class Tools
	{
		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static Regex r;

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0xDD9F58", Offset = "0xDD9F58", VA = "0xDD9F58")]
		public static bool IsNumericType(object o)
		{
			return default(bool);
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0xDDA0F8", Offset = "0xDDA0F8", VA = "0xDDA0F8")]
		public static bool IsPositive(object Value, bool ZeroIsPositive)
		{
			return default(bool);
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0xDDA83C", Offset = "0xDDA83C", VA = "0xDDA83C")]
		public static object ToUnsigned(object Value)
		{
			return null;
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0xDDAE48", Offset = "0xDDAE48", VA = "0xDDAE48")]
		public static object ToInteger(object Value, bool Round)
		{
			return null;
		}

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0xDDB548", Offset = "0xDDB548", VA = "0xDDB548")]
		public static long UnboxToLong(object Value, bool Round)
		{
			return default(long);
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0xDDBD6C", Offset = "0xDDBD6C", VA = "0xDDBD6C")]
		public static string ReplaceMetaChars(string input)
		{
			return null;
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0xDDBE34", Offset = "0xDDBE34", VA = "0xDDBE34")]
		private static string ReplaceMetaCharsMatch(Match m)
		{
			return null;
		}

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0xDDC1FC", Offset = "0xDDC1FC", VA = "0xDDC1FC")]
		public static void fprintf(TextWriter Destination, string Format, params object[] Parameters)
		{
		}

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0xDD8CEC", Offset = "0xDD8CEC", VA = "0xDD8CEC")]
		public static string sprintf(string Format, params object[] Parameters)
		{
			return null;
		}

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0xDDC610", Offset = "0xDDC610", VA = "0xDDC610")]
		private static string FormatOct(string NativeFormat, bool Alternate, int FieldLength, int FieldPrecision, bool Left2Right, char Padding, object Value)
		{
			return null;
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0xDDC8B8", Offset = "0xDDC8B8", VA = "0xDDC8B8")]
		private static string FormatHex(string NativeFormat, bool Alternate, int FieldLength, int FieldPrecision, bool Left2Right, char Padding, object Value)
		{
			return null;
		}

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0xDDC284", Offset = "0xDDC284", VA = "0xDDC284")]
		private static string FormatNumber(string NativeFormat, bool Alternate, int FieldLength, int FieldPrecision, bool Left2Right, bool PositiveSign, bool PositiveSpace, char Padding, object Value)
		{
			return null;
		}
	}
	[Token(Token = "0x20000F2")]
	internal static class NamespaceDoc
	{
	}
}
namespace MoonSharp.Interpreter.Interop.Converters
{
	[Token(Token = "0x20000F3")]
	internal static class ClrToScriptConversions
	{
		[Token(Token = "0x60006DB")]
		[Address(RVA = "0xDDCC34", Offset = "0xDDCC34", VA = "0xDDCC34")]
		internal static DynValue TryObjectToTrivialDynValue(Script script, object obj)
		{
			return null;
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0xDDD5BC", Offset = "0xDDD5BC", VA = "0xDDD5BC")]
		internal static DynValue TryObjectToSimpleDynValue(Script script, object obj)
		{
			return null;
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0xDC44C0", Offset = "0xDC44C0", VA = "0xDC44C0")]
		internal static DynValue ObjectToDynValue(Script script, object obj)
		{
			return null;
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0xDDDB5C", Offset = "0xDDDB5C", VA = "0xDDDB5C")]
		public static DynValue EnumerationToDynValue(Script script, object obj)
		{
			return null;
		}
	}
	[Token(Token = "0x20000F4")]
	internal static class NumericConversions
	{
		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static readonly HashSet<Type> NumericTypes;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal static readonly Type[] NumericTypesOrdered;

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0xDDDCAC", Offset = "0xDDDCAC", VA = "0xDDDCAC")]
		static NumericConversions()
		{
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0xDC4CE0", Offset = "0xDC4CE0", VA = "0xDC4CE0")]
		internal static object DoubleToType(Type type, double d)
		{
			return null;
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0xDDCF58", Offset = "0xDDCF58", VA = "0xDDCF58")]
		internal static double TypeToDouble(Type type, object d)
		{
			return default(double);
		}
	}
	[Token(Token = "0x20000F5")]
	internal static class ScriptToClrConversions
	{
		[Token(Token = "0x40002F5")]
		internal const int WEIGHT_MAX_VALUE = 100;

		[Token(Token = "0x40002F6")]
		internal const int WEIGHT_CUSTOM_CONVERTER_MATCH = 100;

		[Token(Token = "0x40002F7")]
		internal const int WEIGHT_EXACT_MATCH = 100;

		[Token(Token = "0x40002F8")]
		internal const int WEIGHT_STRING_TO_STRINGBUILDER = 99;

		[Token(Token = "0x40002F9")]
		internal const int WEIGHT_STRING_TO_CHAR = 98;

		[Token(Token = "0x40002FA")]
		internal const int WEIGHT_NIL_TO_NULLABLE = 100;

		[Token(Token = "0x40002FB")]
		internal const int WEIGHT_NIL_TO_REFTYPE = 100;

		[Token(Token = "0x40002FC")]
		internal const int WEIGHT_VOID_WITH_DEFAULT = 50;

		[Token(Token = "0x40002FD")]
		internal const int WEIGHT_VOID_WITHOUT_DEFAULT = 25;

		[Token(Token = "0x40002FE")]
		internal const int WEIGHT_NIL_WITH_DEFAULT = 25;

		[Token(Token = "0x40002FF")]
		internal const int WEIGHT_BOOL_TO_STRING = 5;

		[Token(Token = "0x4000300")]
		internal const int WEIGHT_NUMBER_TO_STRING = 50;

		[Token(Token = "0x4000301")]
		internal const int WEIGHT_NUMBER_TO_ENUM = 90;

		[Token(Token = "0x4000302")]
		internal const int WEIGHT_USERDATA_TO_STRING = 5;

		[Token(Token = "0x4000303")]
		internal const int WEIGHT_TABLE_CONVERSION = 90;

		[Token(Token = "0x4000304")]
		internal const int WEIGHT_NUMBER_DOWNCAST = 99;

		[Token(Token = "0x4000305")]
		internal const int WEIGHT_NO_MATCH = 0;

		[Token(Token = "0x4000306")]
		internal const int WEIGHT_NO_EXTRA_PARAMS_BONUS = 100;

		[Token(Token = "0x4000307")]
		internal const int WEIGHT_EXTRA_PARAMS_MALUS = 2;

		[Token(Token = "0x4000308")]
		internal const int WEIGHT_BYREF_BONUSMALUS = -10;

		[Token(Token = "0x4000309")]
		internal const int WEIGHT_VARARGS_MALUS = 1;

		[Token(Token = "0x400030A")]
		internal const int WEIGHT_VARARGS_EMPTY = 40;

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0xDDF0F4", Offset = "0xDDF0F4", VA = "0xDDF0F4")]
		internal static object DynValueToObject(DynValue value)
		{
			return null;
		}

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0xDDF440", Offset = "0xDDF440", VA = "0xDDF440")]
		internal static object DynValueToObjectOfType(DynValue value, Type desiredType, object defaultValue, bool isOptional)
		{
			return null;
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0xDE0DE4", Offset = "0xDE0DE4", VA = "0xDE0DE4")]
		internal static int DynValueToObjectOfTypeWeight(DynValue value, Type desiredType, bool isOptional)
		{
			return default(int);
		}

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0xDE1548", Offset = "0xDE1548", VA = "0xDE1548")]
		private static int GetNumericTypeWeight(Type desiredType)
		{
			return default(int);
		}
	}
	[Token(Token = "0x20000F6")]
	internal static class StringConversions
	{
		[Token(Token = "0x20000F7")]
		internal enum StringSubtype
		{
			[Token(Token = "0x400030C")]
			None,
			[Token(Token = "0x400030D")]
			String,
			[Token(Token = "0x400030E")]
			StringBuilder,
			[Token(Token = "0x400030F")]
			Char
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0xDDFDF8", Offset = "0xDDFDF8", VA = "0xDDFDF8")]
		internal static StringSubtype GetStringSubtype(Type desiredType)
		{
			return default(StringSubtype);
		}

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0xDE0CC4", Offset = "0xDE0CC4", VA = "0xDE0CC4")]
		internal static object ConvertString(StringSubtype stringSubType, string str, Type desiredType, DataType dataType)
		{
			return null;
		}
	}
	[Token(Token = "0x20000F8")]
	internal static class TableConversions
	{
		[Token(Token = "0x60006E8")]
		[Address(RVA = "0xDE1CCC", Offset = "0xDE1CCC", VA = "0xDE1CCC")]
		internal static Table ConvertIListToTable(Script script, IList list)
		{
			return null;
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0xDE1E9C", Offset = "0xDE1E9C", VA = "0xDE1E9C")]
		internal static Table ConvertIDictionaryToTable(Script script, IDictionary dict)
		{
			return null;
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0xDE1630", Offset = "0xDE1630", VA = "0xDE1630")]
		internal static bool CanConvertTableToType(Table table, Type t)
		{
			return default(bool);
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0xDDFF30", Offset = "0xDDFF30", VA = "0xDDFF30")]
		internal static object ConvertTableToType(Table table, Type t)
		{
			return null;
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0xDE24A8", Offset = "0xDE24A8", VA = "0xDE24A8")]
		internal static object ConvertTableToDictionaryOfGenericType(Type dictionaryType, Type keyType, Type valueType, Table table)
		{
			return null;
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0xDE29EC", Offset = "0xDE29EC", VA = "0xDE29EC")]
		internal static object ConvertTableToArrayOfGenericType(Type arrayType, Type itemType, Table table)
		{
			return null;
		}

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0xDE2234", Offset = "0xDE2234", VA = "0xDE2234")]
		internal static object ConvertTableToListOfGenericType(Type listType, Type itemType, Table table)
		{
			return null;
		}

		[Token(Token = "0x60006EF")]
		internal static List<T> TableToList<T>(Table table, Func<DynValue, T> converter)
		{
			return null;
		}

		[Token(Token = "0x60006F0")]
		internal static Dictionary<TK, TV> TableToDictionary<TK, TV>(Table table, Func<DynValue, TK> keyconverter, Func<DynValue, TV> valconverter)
		{
			return null;
		}
	}
}
namespace MoonSharp.Interpreter.Interop.BasicDescriptors
{
	[Token(Token = "0x20000FA")]
	public abstract class DispatchingUserDataDescriptor : IUserDataDescriptor, IOptimizableDescriptor
	{
		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int m_ExtMethodsVersion;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Dictionary<string, IMemberDescriptor> m_MetaMembers;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Dictionary<string, IMemberDescriptor> m_Members;

		[Token(Token = "0x400031C")]
		protected const string SPECIALNAME_INDEXER_GET = "get_Item";

		[Token(Token = "0x400031D")]
		protected const string SPECIALNAME_INDEXER_SET = "set_Item";

		[Token(Token = "0x400031E")]
		protected const string SPECIALNAME_CAST_EXPLICIT = "op_Explicit";

		[Token(Token = "0x400031F")]
		protected const string SPECIALNAME_CAST_IMPLICIT = "op_Implicit";

		[Token(Token = "0x17000108")]
		public string Name
		{
			[Token(Token = "0x60006FB")]
			[Address(RVA = "0xDE2DB8", Offset = "0xDE2DB8", VA = "0xDE2DB8", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60006FC")]
			[Address(RVA = "0xDE2DC0", Offset = "0xDE2DC0", VA = "0xDE2DC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000109")]
		public Type Type
		{
			[Token(Token = "0x60006FD")]
			[Address(RVA = "0xDE2DC8", Offset = "0xDE2DC8", VA = "0xDE2DC8", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60006FE")]
			[Address(RVA = "0xDE2DD0", Offset = "0xDE2DD0", VA = "0xDE2DD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700010A")]
		public string FriendlyName
		{
			[Token(Token = "0x60006FF")]
			[Address(RVA = "0xDE2DD8", Offset = "0xDE2DD8", VA = "0xDE2DD8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000700")]
			[Address(RVA = "0xDE2DE0", Offset = "0xDE2DE0", VA = "0xDE2DE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700010B")]
		public IEnumerable<string> MemberNames
		{
			[Token(Token = "0x6000705")]
			[Address(RVA = "0xDE3198", Offset = "0xDE3198", VA = "0xDE3198")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700010C")]
		public IEnumerable<KeyValuePair<string, IMemberDescriptor>> Members
		{
			[Token(Token = "0x6000706")]
			[Address(RVA = "0xDE31E8", Offset = "0xDE31E8", VA = "0xDE31E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700010D")]
		public IEnumerable<string> MetaMemberNames
		{
			[Token(Token = "0x6000709")]
			[Address(RVA = "0xDE32A0", Offset = "0xDE32A0", VA = "0xDE32A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700010E")]
		public IEnumerable<KeyValuePair<string, IMemberDescriptor>> MetaMembers
		{
			[Token(Token = "0x600070A")]
			[Address(RVA = "0xDE32F0", Offset = "0xDE32F0", VA = "0xDE32F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000701")]
		[Address(RVA = "0xDE2DE8", Offset = "0xDE2DE8", VA = "0xDE2DE8")]
		protected DispatchingUserDataDescriptor(Type type, [Optional] string friendlyName)
		{
		}

		[Token(Token = "0x6000702")]
		[Address(RVA = "0xDE2ED8", Offset = "0xDE2ED8", VA = "0xDE2ED8")]
		public void AddMetaMember(string name, IMemberDescriptor desc)
		{
		}

		[Token(Token = "0x6000703")]
		[Address(RVA = "0xDE30FC", Offset = "0xDE30FC", VA = "0xDE30FC")]
		public void AddDynValue(string name, DynValue value)
		{
		}

		[Token(Token = "0x6000704")]
		[Address(RVA = "0xDE3180", Offset = "0xDE3180", VA = "0xDE3180")]
		public void AddMember(string name, IMemberDescriptor desc)
		{
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0xDE31F0", Offset = "0xDE31F0", VA = "0xDE31F0")]
		public IMemberDescriptor FindMember(string memberName)
		{
			return null;
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0xDE3248", Offset = "0xDE3248", VA = "0xDE3248")]
		public void RemoveMember(string memberName)
		{
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0xDE32F8", Offset = "0xDE32F8", VA = "0xDE32F8")]
		public IMemberDescriptor FindMetaMember(string memberName)
		{
			return null;
		}

		[Token(Token = "0x600070C")]
		[Address(RVA = "0xDE3350", Offset = "0xDE3350", VA = "0xDE3350")]
		public void RemoveMetaMember(string memberName)
		{
		}

		[Token(Token = "0x600070D")]
		[Address(RVA = "0xDE2EF0", Offset = "0xDE2EF0", VA = "0xDE2EF0")]
		private void AddMemberTo(Dictionary<string, IMemberDescriptor> members, string name, IMemberDescriptor desc)
		{
		}

		[Token(Token = "0x600070E")]
		[Address(RVA = "0xDE33A8", Offset = "0xDE33A8", VA = "0xDE33A8", Slot = "12")]
		public virtual DynValue Index(Script script, object obj, DynValue index, bool isDirectIndexing)
		{
			return null;
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0xDE3758", Offset = "0xDE3758", VA = "0xDE3758")]
		private DynValue TryIndexOnExtMethod(Script script, object obj, string indexName)
		{
			return null;
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0xDE38FC", Offset = "0xDE38FC", VA = "0xDE38FC")]
		public bool HasMember(string exactName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0xDE3954", Offset = "0xDE3954", VA = "0xDE3954")]
		public bool HasMetaMember(string exactName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000712")]
		[Address(RVA = "0xDE39AC", Offset = "0xDE39AC", VA = "0xDE39AC", Slot = "13")]
		protected virtual DynValue TryIndex(Script script, object obj, string indexName)
		{
			return null;
		}

		[Token(Token = "0x6000713")]
		[Address(RVA = "0xDE3AB4", Offset = "0xDE3AB4", VA = "0xDE3AB4", Slot = "14")]
		public virtual bool SetIndex(Script script, object obj, DynValue index, DynValue value, bool isDirectIndexing)
		{
			return default(bool);
		}

		[Token(Token = "0x6000714")]
		[Address(RVA = "0xDE3CA8", Offset = "0xDE3CA8", VA = "0xDE3CA8", Slot = "15")]
		protected virtual bool TrySetIndex(Script script, object obj, string indexName, DynValue value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000715")]
		[Address(RVA = "0xDE3DA0", Offset = "0xDE3DA0", VA = "0xDE3DA0", Slot = "11")]
		private void MoonSharp.Interpreter.Interop.BasicDescriptors.IOptimizableDescriptor.Optimize()
		{
		}

		[Token(Token = "0x6000716")]
		[Address(RVA = "0xDE3750", Offset = "0xDE3750", VA = "0xDE3750")]
		protected static string Camelify(string name)
		{
			return null;
		}

		[Token(Token = "0x6000717")]
		[Address(RVA = "0xDE3748", Offset = "0xDE3748", VA = "0xDE3748")]
		protected static string UpperFirstLetter(string name)
		{
			return null;
		}

		[Token(Token = "0x6000718")]
		[Address(RVA = "0xDE43F8", Offset = "0xDE43F8", VA = "0xDE43F8", Slot = "16")]
		public virtual string AsString(object obj)
		{
			return null;
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0xDE4418", Offset = "0xDE4418", VA = "0xDE4418", Slot = "17")]
		protected virtual DynValue ExecuteIndexer(IMemberDescriptor mdesc, Script script, object obj, DynValue index, DynValue value)
		{
			return null;
		}

		[Token(Token = "0x600071A")]
		[Address(RVA = "0xDE4814", Offset = "0xDE4814", VA = "0xDE4814", Slot = "18")]
		public virtual DynValue MetaIndex(Script script, object obj, string metaname)
		{
			return null;
		}

		[Token(Token = "0x600071B")]
		[Address(RVA = "0xDE5478", Offset = "0xDE5478", VA = "0xDE5478")]
		private int PerformComparison(object obj, object p1, object p2)
		{
			return default(int);
		}

		[Token(Token = "0x600071C")]
		[Address(RVA = "0xDE50A8", Offset = "0xDE50A8", VA = "0xDE50A8")]
		private DynValue MultiDispatchLessThanOrEqual(Script script, object obj)
		{
			return null;
		}

		[Token(Token = "0x600071D")]
		[Address(RVA = "0xDE4F90", Offset = "0xDE4F90", VA = "0xDE4F90")]
		private DynValue MultiDispatchLessThan(Script script, object obj)
		{
			return null;
		}

		[Token(Token = "0x600071E")]
		[Address(RVA = "0xDE51C0", Offset = "0xDE51C0", VA = "0xDE51C0")]
		private DynValue TryDispatchLength(Script script, object obj)
		{
			return null;
		}

		[Token(Token = "0x600071F")]
		[Address(RVA = "0xDE4EAC", Offset = "0xDE4EAC", VA = "0xDE4EAC")]
		private DynValue MultiDispatchEqual(Script script, object obj)
		{
			return null;
		}

		[Token(Token = "0x6000720")]
		[Address(RVA = "0xDE5874", Offset = "0xDE5874", VA = "0xDE5874")]
		private bool CheckEquality(object obj, object p1, object p2)
		{
			return default(bool);
		}

		[Token(Token = "0x6000721")]
		[Address(RVA = "0xDE4DB0", Offset = "0xDE4DB0", VA = "0xDE4DB0")]
		private DynValue DispatchMetaOnMethod(Script script, object obj, string methodName)
		{
			return null;
		}

		[Token(Token = "0x6000722")]
		[Address(RVA = "0xDE52BC", Offset = "0xDE52BC", VA = "0xDE52BC")]
		private DynValue TryDispatchToNumber(Script script, object obj)
		{
			return null;
		}

		[Token(Token = "0x6000723")]
		[Address(RVA = "0xDE5394", Offset = "0xDE5394", VA = "0xDE5394")]
		private DynValue TryDispatchToBool(Script script, object obj)
		{
			return null;
		}

		[Token(Token = "0x6000724")]
		[Address(RVA = "0xDE58EC", Offset = "0xDE58EC", VA = "0xDE58EC", Slot = "19")]
		public virtual bool IsTypeCompatible(Type type, object obj)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000FE")]
	public interface IMemberDescriptor
	{
		[Token(Token = "0x1700010F")]
		bool IsStatic
		{
			[Token(Token = "0x600072B")]
			get;
		}

		[Token(Token = "0x17000110")]
		string Name
		{
			[Token(Token = "0x600072C")]
			get;
		}

		[Token(Token = "0x17000111")]
		MemberDescriptorAccess MemberAccess
		{
			[Token(Token = "0x600072D")]
			get;
		}

		[Token(Token = "0x600072E")]
		DynValue GetValue(Script script, object obj);

		[Token(Token = "0x600072F")]
		void SetValue(Script script, object obj, DynValue value);
	}
	[Token(Token = "0x20000FF")]
	public static class MemberDescriptor
	{
		[Token(Token = "0x6000730")]
		[Address(RVA = "0xDE5BFC", Offset = "0xDE5BFC", VA = "0xDE5BFC")]
		public static bool HasAllFlags(this MemberDescriptorAccess access, MemberDescriptorAccess flag)
		{
			return default(bool);
		}

		[Token(Token = "0x6000731")]
		[Address(RVA = "0xDE5630", Offset = "0xDE5630", VA = "0xDE5630")]
		public static bool CanRead(this IMemberDescriptor desc)
		{
			return default(bool);
		}

		[Token(Token = "0x6000732")]
		[Address(RVA = "0xDE5C08", Offset = "0xDE5C08", VA = "0xDE5C08")]
		public static bool CanWrite(this IMemberDescriptor desc)
		{
			return default(bool);
		}

		[Token(Token = "0x6000733")]
		[Address(RVA = "0xDE56D8", Offset = "0xDE56D8", VA = "0xDE56D8")]
		public static bool CanExecute(this IMemberDescriptor desc)
		{
			return default(bool);
		}

		[Token(Token = "0x6000734")]
		[Address(RVA = "0xDE5780", Offset = "0xDE5780", VA = "0xDE5780")]
		public static DynValue GetGetterCallbackAsDynValue(this IMemberDescriptor desc, Script script, object obj)
		{
			return null;
		}

		[Token(Token = "0x6000735")]
		[Address(RVA = "0xDE3694", Offset = "0xDE3694", VA = "0xDE3694")]
		public static IMemberDescriptor WithAccessOrNull(this IMemberDescriptor desc, MemberDescriptorAccess access)
		{
			return null;
		}

		[Token(Token = "0x6000736")]
		[Address(RVA = "0xDE5CB8", Offset = "0xDE5CB8", VA = "0xDE5CB8")]
		public static void CheckAccess(this IMemberDescriptor desc, MemberDescriptorAccess access, object obj)
		{
		}
	}
	[Token(Token = "0x2000101")]
	public interface IOptimizableDescriptor
	{
		[Token(Token = "0x6000739")]
		void Optimize();
	}
	[Token(Token = "0x2000102")]
	public interface IOverloadableMemberDescriptor : IMemberDescriptor
	{
		[Token(Token = "0x17000112")]
		Type ExtensionMethodType
		{
			[Token(Token = "0x600073B")]
			get;
		}

		[Token(Token = "0x17000113")]
		ParameterDescriptor[] Parameters
		{
			[Token(Token = "0x600073C")]
			get;
		}

		[Token(Token = "0x17000114")]
		Type VarArgsArrayType
		{
			[Token(Token = "0x600073D")]
			get;
		}

		[Token(Token = "0x17000115")]
		Type VarArgsElementType
		{
			[Token(Token = "0x600073E")]
			get;
		}

		[Token(Token = "0x17000116")]
		string SortDiscriminant
		{
			[Token(Token = "0x600073F")]
			get;
		}

		[Token(Token = "0x600073A")]
		DynValue Execute(Script script, object obj, ScriptExecutionContext context, CallbackArguments args);
	}
	[Token(Token = "0x2000103")]
	[Flags]
	public enum MemberDescriptorAccess
	{
		[Token(Token = "0x400032D")]
		CanRead = 1,
		[Token(Token = "0x400032E")]
		CanWrite = 2,
		[Token(Token = "0x400032F")]
		CanExecute = 4
	}
	[Token(Token = "0x2000104")]
	public sealed class ParameterDescriptor : IWireableDescriptor
	{
		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Type m_OriginalType;

		[Token(Token = "0x17000117")]
		public string Name
		{
			[Token(Token = "0x6000740")]
			[Address(RVA = "0xDE6028", Offset = "0xDE6028", VA = "0xDE6028")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000741")]
			[Address(RVA = "0xDE6030", Offset = "0xDE6030", VA = "0xDE6030")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000118")]
		public Type Type
		{
			[Token(Token = "0x6000742")]
			[Address(RVA = "0xDE6038", Offset = "0xDE6038", VA = "0xDE6038")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000743")]
			[Address(RVA = "0xDE6040", Offset = "0xDE6040", VA = "0xDE6040")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000119")]
		public bool HasDefaultValue
		{
			[Token(Token = "0x6000744")]
			[Address(RVA = "0xDE6048", Offset = "0xDE6048", VA = "0xDE6048")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000745")]
			[Address(RVA = "0xDE6050", Offset = "0xDE6050", VA = "0xDE6050")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700011A")]
		public object DefaultValue
		{
			[Token(Token = "0x6000746")]
			[Address(RVA = "0xDE605C", Offset = "0xDE605C", VA = "0xDE605C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000747")]
			[Address(RVA = "0xDE6064", Offset = "0xDE6064", VA = "0xDE6064")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700011B")]
		public bool IsOut
		{
			[Token(Token = "0x6000748")]
			[Address(RVA = "0xDE606C", Offset = "0xDE606C", VA = "0xDE606C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000749")]
			[Address(RVA = "0xDE6074", Offset = "0xDE6074", VA = "0xDE6074")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700011C")]
		public bool IsRef
		{
			[Token(Token = "0x600074A")]
			[Address(RVA = "0xDE6080", Offset = "0xDE6080", VA = "0xDE6080")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600074B")]
			[Address(RVA = "0xDE6088", Offset = "0xDE6088", VA = "0xDE6088")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700011D")]
		public bool IsVarArgs
		{
			[Token(Token = "0x600074C")]
			[Address(RVA = "0xDE6094", Offset = "0xDE6094", VA = "0xDE6094")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600074D")]
			[Address(RVA = "0xDE609C", Offset = "0xDE609C", VA = "0xDE609C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700011E")]
		public bool HasBeenRestricted
		{
			[Token(Token = "0x600074E")]
			[Address(RVA = "0xDE60A8", Offset = "0xDE60A8", VA = "0xDE60A8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700011F")]
		public Type OriginalType
		{
			[Token(Token = "0x600074F")]
			[Address(RVA = "0xDE6108", Offset = "0xDE6108", VA = "0xDE6108")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000750")]
		[Address(RVA = "0xDE6120", Offset = "0xDE6120", VA = "0xDE6120")]
		public ParameterDescriptor(string name, Type type, bool hasDefaultValue = false, [Optional] object defaultValue, bool isOut = false, bool isRef = false, bool isVarArgs = false)
		{
		}

		[Token(Token = "0x6000751")]
		[Address(RVA = "0xDE619C", Offset = "0xDE619C", VA = "0xDE619C")]
		public ParameterDescriptor(string name, Type type, bool hasDefaultValue, object defaultValue, bool isOut, bool isRef, bool isVarArgs, Type typeRestriction)
		{
		}

		[Token(Token = "0x6000752")]
		[Address(RVA = "0xDE63E8", Offset = "0xDE63E8", VA = "0xDE63E8")]
		public ParameterDescriptor(ParameterInfo pi)
		{
		}

		[Token(Token = "0x6000753")]
		[Address(RVA = "0xDE65F8", Offset = "0xDE65F8", VA = "0xDE65F8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000754")]
		[Address(RVA = "0xDE6298", Offset = "0xDE6298", VA = "0xDE6298")]
		public void RestrictType(Type type)
		{
		}

		[Token(Token = "0x6000755")]
		[Address(RVA = "0xDE66A4", Offset = "0xDE66A4", VA = "0xDE66A4", Slot = "4")]
		public void PrepareForWiring(Table table)
		{
		}
	}
	[Token(Token = "0x2000105")]
	public interface IWireableDescriptor
	{
		[Token(Token = "0x6000756")]
		void PrepareForWiring(Table t);
	}
}
namespace MoonSharp.Interpreter.Execution
{
	[Token(Token = "0x2000106")]
	[Flags]
	internal enum InstructionFieldUsage
	{
		[Token(Token = "0x4000339")]
		None = 0,
		[Token(Token = "0x400033A")]
		Symbol = 1,
		[Token(Token = "0x400033B")]
		SymbolList = 2,
		[Token(Token = "0x400033C")]
		Name = 4,
		[Token(Token = "0x400033D")]
		Value = 8,
		[Token(Token = "0x400033E")]
		NumVal = 0x10,
		[Token(Token = "0x400033F")]
		NumVal2 = 0x20,
		[Token(Token = "0x4000340")]
		NumValAsCodeAddress = 0x8010
	}
	[Token(Token = "0x2000107")]
	internal static class InstructionFieldUsage_Extensions
	{
		[Token(Token = "0x6000757")]
		[Address(RVA = "0xDE69D0", Offset = "0xDE69D0", VA = "0xDE69D0")]
		internal static InstructionFieldUsage GetFieldUsage(this OpCode op)
		{
			return default(InstructionFieldUsage);
		}
	}
	[Token(Token = "0x2000108")]
	internal class BuildTimeScope
	{
		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private List<BuildTimeScopeFrame> m_Frames;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private List<IClosureBuilder> m_ClosureBuilders;

		[Token(Token = "0x6000758")]
		[Address(RVA = "0xDE6A70", Offset = "0xDE6A70", VA = "0xDE6A70")]
		public void PushFunction(IClosureBuilder closureBuilder, bool hasVarArgs)
		{
		}

		[Token(Token = "0x6000759")]
		[Address(RVA = "0xDE6BCC", Offset = "0xDE6BCC", VA = "0xDE6BCC")]
		public void PushBlock()
		{
		}

		[Token(Token = "0x600075A")]
		[Address(RVA = "0xDE6C24", Offset = "0xDE6C24", VA = "0xDE6C24")]
		public RuntimeScopeBlock PopBlock()
		{
			return null;
		}

		[Token(Token = "0x600075B")]
		[Address(RVA = "0xDE6C7C", Offset = "0xDE6C7C", VA = "0xDE6C7C")]
		public RuntimeScopeFrame PopFunction()
		{
			return null;
		}

		[Token(Token = "0x600075C")]
		[Address(RVA = "0xDE6D54", Offset = "0xDE6D54", VA = "0xDE6D54")]
		public SymbolRef Find(string name)
		{
			return null;
		}

		[Token(Token = "0x600075D")]
		[Address(RVA = "0xDE6FD8", Offset = "0xDE6FD8", VA = "0xDE6FD8")]
		public SymbolRef CreateGlobalReference(string name)
		{
			return null;
		}

		[Token(Token = "0x600075E")]
		[Address(RVA = "0xDE70C8", Offset = "0xDE70C8", VA = "0xDE70C8")]
		public void ForceEnvUpValue()
		{
		}

		[Token(Token = "0x600075F")]
		[Address(RVA = "0xDE6E70", Offset = "0xDE6E70", VA = "0xDE6E70")]
		private SymbolRef CreateUpValue(BuildTimeScope buildTimeScope, SymbolRef symb, int closuredFrame, int currentFrame)
		{
			return null;
		}

		[Token(Token = "0x6000760")]
		[Address(RVA = "0xDE7110", Offset = "0xDE7110", VA = "0xDE7110")]
		public SymbolRef DefineLocal(string name)
		{
			return null;
		}

		[Token(Token = "0x6000761")]
		[Address(RVA = "0xDE7178", Offset = "0xDE7178", VA = "0xDE7178")]
		public SymbolRef TryDefineLocal(string name)
		{
			return null;
		}

		[Token(Token = "0x6000762")]
		[Address(RVA = "0xDE71E0", Offset = "0xDE71E0", VA = "0xDE71E0")]
		public bool CurrentFunctionHasVarArgs()
		{
			return default(bool);
		}

		[Token(Token = "0x6000763")]
		[Address(RVA = "0xDE7238", Offset = "0xDE7238", VA = "0xDE7238")]
		internal void DefineLabel(LabelStatement label)
		{
		}

		[Token(Token = "0x6000764")]
		[Address(RVA = "0xDE72A0", Offset = "0xDE72A0", VA = "0xDE72A0")]
		internal void RegisterGoto(GotoStatement gotostat)
		{
		}

		[Token(Token = "0x6000765")]
		[Address(RVA = "0xDE7308", Offset = "0xDE7308", VA = "0xDE7308")]
		public BuildTimeScope()
		{
		}
	}
	[Token(Token = "0x2000109")]
	internal class ClosureContext : List<DynValue>
	{
		[Token(Token = "0x17000120")]
		public string[] Symbols
		{
			[Token(Token = "0x6000766")]
			[Address(RVA = "0xDE73C8", Offset = "0xDE73C8", VA = "0xDE73C8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000767")]
			[Address(RVA = "0xDE73D0", Offset = "0xDE73D0", VA = "0xDE73D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000768")]
		[Address(RVA = "0xDE73D8", Offset = "0xDE73D8", VA = "0xDE73D8")]
		internal ClosureContext(SymbolRef[] symbols, IEnumerable<DynValue> values)
		{
		}

		[Token(Token = "0x6000769")]
		[Address(RVA = "0xDE757C", Offset = "0xDE757C", VA = "0xDE757C")]
		internal ClosureContext()
		{
		}
	}
	[Token(Token = "0x200010B")]
	internal interface IClosureBuilder
	{
		[Token(Token = "0x600076D")]
		SymbolRef CreateUpvalue(BuildTimeScope scope, SymbolRef symbol);
	}
	[Token(Token = "0x200010C")]
	internal interface ILoop
	{
		[Token(Token = "0x600076E")]
		void CompileBreak(ByteCode bc);

		[Token(Token = "0x600076F")]
		bool IsBoundary();
	}
	[Token(Token = "0x200010D")]
	internal class LoopTracker
	{
		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FastStack<ILoop> Loops;

		[Token(Token = "0x6000770")]
		[Address(RVA = "0xDE7694", Offset = "0xDE7694", VA = "0xDE7694")]
		public LoopTracker()
		{
		}
	}
	[Token(Token = "0x200010E")]
	internal class RuntimeScopeBlock
	{
		[Token(Token = "0x17000121")]
		public int From
		{
			[Token(Token = "0x6000771")]
			[Address(RVA = "0xDE7714", Offset = "0xDE7714", VA = "0xDE7714")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000772")]
			[Address(RVA = "0xDE771C", Offset = "0xDE771C", VA = "0xDE771C")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Token(Token = "0x17000122")]
		public int To
		{
			[Token(Token = "0x6000773")]
			[Address(RVA = "0xDE7724", Offset = "0xDE7724", VA = "0xDE7724")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000774")]
			[Address(RVA = "0xDE772C", Offset = "0xDE772C", VA = "0xDE772C")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Token(Token = "0x17000123")]
		public int ToInclusive
		{
			[Token(Token = "0x6000775")]
			[Address(RVA = "0xDE7734", Offset = "0xDE7734", VA = "0xDE7734")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000776")]
			[Address(RVA = "0xDE773C", Offset = "0xDE773C", VA = "0xDE773C")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Token(Token = "0x6000777")]
		[Address(RVA = "0xDE7744", Offset = "0xDE7744", VA = "0xDE7744", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000778")]
		[Address(RVA = "0xDE7808", Offset = "0xDE7808", VA = "0xDE7808")]
		public RuntimeScopeBlock()
		{
		}
	}
	[Token(Token = "0x200010F")]
	internal class RuntimeScopeFrame
	{
		[Token(Token = "0x17000124")]
		public List<SymbolRef> DebugSymbols
		{
			[Token(Token = "0x6000779")]
			[Address(RVA = "0xDE7810", Offset = "0xDE7810", VA = "0xDE7810")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600077A")]
			[Address(RVA = "0xDE7818", Offset = "0xDE7818", VA = "0xDE7818")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000125")]
		public int Count
		{
			[Token(Token = "0x600077B")]
			[Address(RVA = "0xDE7820", Offset = "0xDE7820", VA = "0xDE7820")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000126")]
		public int ToFirstBlock
		{
			[Token(Token = "0x600077C")]
			[Address(RVA = "0xDE7868", Offset = "0xDE7868", VA = "0xDE7868")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600077D")]
			[Address(RVA = "0xDE7870", Offset = "0xDE7870", VA = "0xDE7870")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Token(Token = "0x600077E")]
		[Address(RVA = "0xDE7878", Offset = "0xDE7878", VA = "0xDE7878")]
		public RuntimeScopeFrame()
		{
		}

		[Token(Token = "0x600077F")]
		[Address(RVA = "0xDE78F8", Offset = "0xDE78F8", VA = "0xDE78F8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000110")]
	internal class ScriptLoadingContext
	{
		[Token(Token = "0x17000127")]
		public Script Script
		{
			[Token(Token = "0x6000780")]
			[Address(RVA = "0xDE7984", Offset = "0xDE7984", VA = "0xDE7984")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000781")]
			[Address(RVA = "0xDE798C", Offset = "0xDE798C", VA = "0xDE798C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000128")]
		public BuildTimeScope Scope
		{
			[Token(Token = "0x6000782")]
			[Address(RVA = "0xDE7994", Offset = "0xDE7994", VA = "0xDE7994")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000783")]
			[Address(RVA = "0xDE799C", Offset = "0xDE799C", VA = "0xDE799C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000129")]
		public SourceCode Source
		{
			[Token(Token = "0x6000784")]
			[Address(RVA = "0xDE79A4", Offset = "0xDE79A4", VA = "0xDE79A4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000785")]
			[Address(RVA = "0xDE79AC", Offset = "0xDE79AC", VA = "0xDE79AC")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700012A")]
		public bool Anonymous
		{
			[Token(Token = "0x6000786")]
			[Address(RVA = "0xDE79B4", Offset = "0xDE79B4", VA = "0xDE79B4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000787")]
			[Address(RVA = "0xDE79BC", Offset = "0xDE79BC", VA = "0xDE79BC")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700012B")]
		public bool IsDynamicExpression
		{
			[Token(Token = "0x6000788")]
			[Address(RVA = "0xDE79C8", Offset = "0xDE79C8", VA = "0xDE79C8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000789")]
			[Address(RVA = "0xDE79D0", Offset = "0xDE79D0", VA = "0xDE79D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700012C")]
		public Lexer Lexer
		{
			[Token(Token = "0x600078A")]
			[Address(RVA = "0xDE79DC", Offset = "0xDE79DC", VA = "0xDE79DC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600078B")]
			[Address(RVA = "0xDE79E4", Offset = "0xDE79E4", VA = "0xDE79E4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x600078C")]
		[Address(RVA = "0xDE79EC", Offset = "0xDE79EC", VA = "0xDE79EC")]
		public ScriptLoadingContext(Script s)
		{
		}
	}
}
namespace MoonSharp.Interpreter.Execution.VM
{
	[Token(Token = "0x2000111")]
	internal class ByteCode : RefIdObject
	{
		[Token(Token = "0x2000112")]
		private class SourceCodeStackGuard : IDisposable
		{
			[Token(Token = "0x4000357")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private ByteCode m_Bc;

			[Token(Token = "0x60007BA")]
			[Address(RVA = "0xDE7B94", Offset = "0xDE7B94", VA = "0xDE7B94")]
			public SourceCodeStackGuard(SourceRef sref, ByteCode bc)
			{
			}

			[Token(Token = "0x60007BB")]
			[Address(RVA = "0xDE9664", Offset = "0xDE9664", VA = "0xDE9664", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<Instruction> Code;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<SourceRef> m_SourceRefStack;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private SourceRef m_CurrentSourceRef;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal LoopTracker LoopTracker;

		[Token(Token = "0x1700012D")]
		public Script Script
		{
			[Token(Token = "0x600078D")]
			[Address(RVA = "0xDE7A14", Offset = "0xDE7A14", VA = "0xDE7A14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600078E")]
			[Address(RVA = "0xDE7A1C", Offset = "0xDE7A1C", VA = "0xDE7A1C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600078F")]
		[Address(RVA = "0xDE7A24", Offset = "0xDE7A24", VA = "0xDE7A24")]
		public ByteCode(Script script)
		{
		}

		[Token(Token = "0x6000790")]
		[Address(RVA = "0xDE7B24", Offset = "0xDE7B24", VA = "0xDE7B24")]
		public IDisposable EnterSource(SourceRef sref)
		{
			return null;
		}

		[Token(Token = "0x6000791")]
		[Address(RVA = "0xDE7BD0", Offset = "0xDE7BD0", VA = "0xDE7BD0")]
		public void PushSourceRef(SourceRef sref)
		{
		}

		[Token(Token = "0x6000792")]
		[Address(RVA = "0xDE7C78", Offset = "0xDE7C78", VA = "0xDE7C78")]
		public void PopSourceRef()
		{
		}

		[Token(Token = "0x6000793")]
		[Address(RVA = "0xDE7D1C", Offset = "0xDE7D1C", VA = "0xDE7D1C")]
		public void Dump(string file)
		{
		}

		[Token(Token = "0x6000794")]
		[Address(RVA = "0xDE7EC8", Offset = "0xDE7EC8", VA = "0xDE7EC8")]
		public int GetJumpPointForNextInstruction()
		{
			return default(int);
		}

		[Token(Token = "0x6000795")]
		[Address(RVA = "0xDE7F10", Offset = "0xDE7F10", VA = "0xDE7F10")]
		public int GetJumpPointForLastInstruction()
		{
			return default(int);
		}

		[Token(Token = "0x6000796")]
		[Address(RVA = "0xDE7F5C", Offset = "0xDE7F5C", VA = "0xDE7F5C")]
		public Instruction GetLastInstruction()
		{
			return null;
		}

		[Token(Token = "0x6000797")]
		[Address(RVA = "0xDE7FC0", Offset = "0xDE7FC0", VA = "0xDE7FC0")]
		private Instruction AppendInstruction(Instruction c)
		{
			return null;
		}

		[Token(Token = "0x6000798")]
		[Address(RVA = "0xDE8068", Offset = "0xDE8068", VA = "0xDE8068")]
		public Instruction Emit_Nop(string comment)
		{
			return null;
		}

		[Token(Token = "0x6000799")]
		[Address(RVA = "0xDE8110", Offset = "0xDE8110", VA = "0xDE8110")]
		public Instruction Emit_Invalid(string type)
		{
			return null;
		}

		[Token(Token = "0x600079A")]
		[Address(RVA = "0xDE8194", Offset = "0xDE8194", VA = "0xDE8194")]
		public Instruction Emit_Pop(int num = 1)
		{
			return null;
		}

		[Token(Token = "0x600079B")]
		[Address(RVA = "0xDE8218", Offset = "0xDE8218", VA = "0xDE8218")]
		public void Emit_Call(int argCount, string debugName)
		{
		}

		[Token(Token = "0x600079C")]
		[Address(RVA = "0xDE82A4", Offset = "0xDE82A4", VA = "0xDE82A4")]
		public void Emit_ThisCall(int argCount, string debugName)
		{
		}

		[Token(Token = "0x600079D")]
		[Address(RVA = "0xDE8330", Offset = "0xDE8330", VA = "0xDE8330")]
		public Instruction Emit_Literal(DynValue value)
		{
			return null;
		}

		[Token(Token = "0x600079E")]
		[Address(RVA = "0xDE83B4", Offset = "0xDE83B4", VA = "0xDE83B4")]
		public Instruction Emit_Jump(OpCode jumpOpCode, int idx, int optPar = 0)
		{
			return null;
		}

		[Token(Token = "0x600079F")]
		[Address(RVA = "0xDE8444", Offset = "0xDE8444", VA = "0xDE8444")]
		public Instruction Emit_MkTuple(int cnt)
		{
			return null;
		}

		[Token(Token = "0x60007A0")]
		[Address(RVA = "0xDE84C8", Offset = "0xDE84C8", VA = "0xDE84C8")]
		public Instruction Emit_Operator(OpCode opcode)
		{
			return null;
		}

		[Token(Token = "0x60007A1")]
		[Address(RVA = "0xDE85B8", Offset = "0xDE85B8", VA = "0xDE85B8")]
		[Conditional("EMIT_DEBUG_OPS")]
		public void Emit_Debug(string str)
		{
		}

		[Token(Token = "0x60007A2")]
		[Address(RVA = "0xDE868C", Offset = "0xDE868C", VA = "0xDE868C")]
		public Instruction Emit_Enter(RuntimeScopeBlock runtimeScopeBlock)
		{
			return null;
		}

		[Token(Token = "0x60007A3")]
		[Address(RVA = "0xDE8720", Offset = "0xDE8720", VA = "0xDE8720")]
		public Instruction Emit_Leave(RuntimeScopeBlock runtimeScopeBlock)
		{
			return null;
		}

		[Token(Token = "0x60007A4")]
		[Address(RVA = "0xDE87AC", Offset = "0xDE87AC", VA = "0xDE87AC")]
		public Instruction Emit_Exit(RuntimeScopeBlock runtimeScopeBlock)
		{
			return null;
		}

		[Token(Token = "0x60007A5")]
		[Address(RVA = "0xDE8840", Offset = "0xDE8840", VA = "0xDE8840")]
		public Instruction Emit_Clean(RuntimeScopeBlock runtimeScopeBlock)
		{
			return null;
		}

		[Token(Token = "0x60007A6")]
		[Address(RVA = "0xDE88D8", Offset = "0xDE88D8", VA = "0xDE88D8")]
		public Instruction Emit_Closure(SymbolRef[] symbols, int jmpnum)
		{
			return null;
		}

		[Token(Token = "0x60007A7")]
		[Address(RVA = "0xDE8964", Offset = "0xDE8964", VA = "0xDE8964")]
		public Instruction Emit_Args(params SymbolRef[] symbols)
		{
			return null;
		}

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0xDE89E8", Offset = "0xDE89E8", VA = "0xDE89E8")]
		public Instruction Emit_Ret(int retvals)
		{
			return null;
		}

		[Token(Token = "0x60007A9")]
		[Address(RVA = "0xDE8A6C", Offset = "0xDE8A6C", VA = "0xDE8A6C")]
		public Instruction Emit_ToNum(int stage = 0)
		{
			return null;
		}

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0xDE8AF0", Offset = "0xDE8AF0", VA = "0xDE8AF0")]
		public Instruction Emit_Incr(int i)
		{
			return null;
		}

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0xDE8B74", Offset = "0xDE8B74", VA = "0xDE8B74")]
		public Instruction Emit_NewTable(bool shared)
		{
			return null;
		}

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0xDE8BFC", Offset = "0xDE8BFC", VA = "0xDE8BFC")]
		public Instruction Emit_IterPrep()
		{
			return null;
		}

		[Token(Token = "0x60007AD")]
		[Address(RVA = "0xDE8C70", Offset = "0xDE8C70", VA = "0xDE8C70")]
		public Instruction Emit_ExpTuple(int stackOffset)
		{
			return null;
		}

		[Token(Token = "0x60007AE")]
		[Address(RVA = "0xDE8CF4", Offset = "0xDE8CF4", VA = "0xDE8CF4")]
		public Instruction Emit_IterUpd()
		{
			return null;
		}

		[Token(Token = "0x60007AF")]
		[Address(RVA = "0xDE8D68", Offset = "0xDE8D68", VA = "0xDE8D68")]
		public Instruction Emit_Meta(string funcName, OpCodeMetadataType metaType, [Optional] DynValue value)
		{
			return null;
		}

		[Token(Token = "0x60007B0")]
		[Address(RVA = "0xDE8E00", Offset = "0xDE8E00", VA = "0xDE8E00")]
		public Instruction Emit_BeginFn(RuntimeScopeFrame stackFrame)
		{
			return null;
		}

		[Token(Token = "0x60007B1")]
		[Address(RVA = "0xDE8EC0", Offset = "0xDE8EC0", VA = "0xDE8EC0")]
		public Instruction Emit_Scalar()
		{
			return null;
		}

		[Token(Token = "0x60007B2")]
		[Address(RVA = "0xDE8F34", Offset = "0xDE8F34", VA = "0xDE8F34")]
		public int Emit_Load(SymbolRef sym)
		{
			return default(int);
		}

		[Token(Token = "0x60007B3")]
		[Address(RVA = "0xDE9104", Offset = "0xDE9104", VA = "0xDE9104")]
		public int Emit_Store(SymbolRef sym, int stackofs, int tupleidx)
		{
			return default(int);
		}

		[Token(Token = "0x60007B4")]
		[Address(RVA = "0xDE92F0", Offset = "0xDE92F0", VA = "0xDE92F0")]
		public Instruction Emit_TblInitN()
		{
			return null;
		}

		[Token(Token = "0x60007B5")]
		[Address(RVA = "0xDE9364", Offset = "0xDE9364", VA = "0xDE9364")]
		public Instruction Emit_TblInitI(bool lastpos)
		{
			return null;
		}

		[Token(Token = "0x60007B6")]
		[Address(RVA = "0xDE93EC", Offset = "0xDE93EC", VA = "0xDE93EC")]
		public Instruction Emit_Index([Optional] DynValue index, bool isNameIndex = false, bool isExpList = false)
		{
			return null;
		}

		[Token(Token = "0x60007B7")]
		[Address(RVA = "0xDE9498", Offset = "0xDE9498", VA = "0xDE9498")]
		public Instruction Emit_IndexSet(int stackofs, int tupleidx, [Optional] DynValue index, bool isNameIndex = false, bool isExpList = false)
		{
			return null;
		}

		[Token(Token = "0x60007B8")]
		[Address(RVA = "0xDE9558", Offset = "0xDE9558", VA = "0xDE9558")]
		public Instruction Emit_Copy(int numval)
		{
			return null;
		}

		[Token(Token = "0x60007B9")]
		[Address(RVA = "0xDE95DC", Offset = "0xDE95DC", VA = "0xDE95DC")]
		public Instruction Emit_Swap(int p1, int p2)
		{
			return null;
		}
	}
	[Token(Token = "0x2000113")]
	internal class CallStackItem
	{
		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int Debug_EntryPoint;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SymbolRef[] Debug_Symbols;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SourceRef CallingSourceRef;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public CallbackFunction ClrFunction;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public CallbackFunction Continuation;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public CallbackFunction ErrorHandler;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public DynValue ErrorHandlerBeforeUnwind;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public int BasePointer;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public int ReturnAddress;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public DynValue[] LocalScope;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public ClosureContext ClosureScope;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public CallStackItemFlags Flags;

		[Token(Token = "0x60007BC")]
		[Address(RVA = "0xDE967C", Offset = "0xDE967C", VA = "0xDE967C")]
		public CallStackItem()
		{
		}
	}
	[Token(Token = "0x2000114")]
	[Flags]
	internal enum CallStackItemFlags
	{
		[Token(Token = "0x4000365")]
		None = 0,
		[Token(Token = "0x4000366")]
		EntryPoint = 1,
		[Token(Token = "0x4000367")]
		ResumeEntryPoint = 3,
		[Token(Token = "0x4000368")]
		CallEntryPoint = 5,
		[Token(Token = "0x4000369")]
		TailCall = 0x10,
		[Token(Token = "0x400036A")]
		MethodCall = 0x20
	}
	[Token(Token = "0x2000115")]
	internal sealed class ExecutionState
	{
		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FastStack<DynValue> ValueStack;

		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FastStack<CallStackItem> ExecutionStack;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int InstructionPtr;

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public CoroutineState State;

		[Token(Token = "0x60007BD")]
		[Address(RVA = "0xDE9684", Offset = "0xDE9684", VA = "0xDE9684")]
		public ExecutionState()
		{
		}
	}
	[Token(Token = "0x2000116")]
	internal class Instruction
	{
		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal OpCode OpCode;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal SymbolRef Symbol;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal SymbolRef[] SymbolList;

		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal string Name;

		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal DynValue Value;

		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal int NumVal;

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		internal int NumVal2;

		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		internal SourceRef SourceCodeRef;

		[Token(Token = "0x60007BE")]
		[Address(RVA = "0xDE80E8", Offset = "0xDE80E8", VA = "0xDE80E8")]
		internal Instruction(SourceRef sourceref)
		{
		}

		[Token(Token = "0x60007BF")]
		[Address(RVA = "0xDE9754", Offset = "0xDE9754", VA = "0xDE9754", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0xDE9B08", Offset = "0xDE9B08", VA = "0xDE9B08")]
		private string PurifyFromNewLines(DynValue Value)
		{
			return null;
		}

		[Token(Token = "0x60007C1")]
		[Address(RVA = "0xDE9A7C", Offset = "0xDE9A7C", VA = "0xDE9A7C")]
		private string GenSpaces()
		{
			return null;
		}

		[Token(Token = "0x60007C2")]
		[Address(RVA = "0xDE9B94", Offset = "0xDE9B94", VA = "0xDE9B94")]
		internal void WriteBinary(BinaryWriter wr, int baseAddress, Dictionary<SymbolRef, int> symbolMap)
		{
		}

		[Token(Token = "0x60007C3")]
		[Address(RVA = "0xDE9EBC", Offset = "0xDE9EBC", VA = "0xDE9EBC")]
		private static void WriteSymbol(BinaryWriter wr, SymbolRef symbolRef, Dictionary<SymbolRef, int> symbolMap)
		{
		}

		[Token(Token = "0x60007C4")]
		[Address(RVA = "0xDE9F48", Offset = "0xDE9F48", VA = "0xDE9F48")]
		private static SymbolRef ReadSymbol(BinaryReader rd, SymbolRef[] deserializedSymbols)
		{
			return null;
		}

		[Token(Token = "0x60007C5")]
		[Address(RVA = "0xDE9F98", Offset = "0xDE9F98", VA = "0xDE9F98")]
		internal static Instruction ReadBinary(SourceRef chunkRef, BinaryReader rd, int baseAddress, Table envTable, SymbolRef[] deserializedSymbols)
		{
			return null;
		}

		[Token(Token = "0x60007C6")]
		[Address(RVA = "0xDEA1AC", Offset = "0xDEA1AC", VA = "0xDEA1AC")]
		private static DynValue ReadValue(BinaryReader rd, Table envTable)
		{
			return null;
		}

		[Token(Token = "0x60007C7")]
		[Address(RVA = "0xDE9D44", Offset = "0xDE9D44", VA = "0xDE9D44")]
		private void DumpValue(BinaryWriter wr, DynValue value)
		{
		}

		[Token(Token = "0x60007C8")]
		[Address(RVA = "0xDEA428", Offset = "0xDEA428", VA = "0xDEA428")]
		internal void GetSymbolReferences(out SymbolRef[] symbolList, out SymbolRef symbol)
		{
		}
	}
	[Token(Token = "0x2000118")]
	internal enum OpCode
	{
		[Token(Token = "0x400037A")]
		Nop,
		[Token(Token = "0x400037B")]
		Debug,
		[Token(Token = "0x400037C")]
		Pop,
		[Token(Token = "0x400037D")]
		Copy,
		[Token(Token = "0x400037E")]
		Swap,
		[Token(Token = "0x400037F")]
		Literal,
		[Token(Token = "0x4000380")]
		Closure,
		[Token(Token = "0x4000381")]
		NewTable,
		[Token(Token = "0x4000382")]
		TblInitN,
		[Token(Token = "0x4000383")]
		TblInitI,
		[Token(Token = "0x4000384")]
		StoreLcl,
		[Token(Token = "0x4000385")]
		Local,
		[Token(Token = "0x4000386")]
		StoreUpv,
		[Token(Token = "0x4000387")]
		Upvalue,
		[Token(Token = "0x4000388")]
		IndexSet,
		[Token(Token = "0x4000389")]
		Index,
		[Token(Token = "0x400038A")]
		IndexSetN,
		[Token(Token = "0x400038B")]
		IndexN,
		[Token(Token = "0x400038C")]
		IndexSetL,
		[Token(Token = "0x400038D")]
		IndexL,
		[Token(Token = "0x400038E")]
		Clean,
		[Token(Token = "0x400038F")]
		Meta,
		[Token(Token = "0x4000390")]
		BeginFn,
		[Token(Token = "0x4000391")]
		Args,
		[Token(Token = "0x4000392")]
		Call,
		[Token(Token = "0x4000393")]
		ThisCall,
		[Token(Token = "0x4000394")]
		Ret,
		[Token(Token = "0x4000395")]
		Jump,
		[Token(Token = "0x4000396")]
		Jf,
		[Token(Token = "0x4000397")]
		JNil,
		[Token(Token = "0x4000398")]
		JFor,
		[Token(Token = "0x4000399")]
		JtOrPop,
		[Token(Token = "0x400039A")]
		JfOrPop,
		[Token(Token = "0x400039B")]
		Concat,
		[Token(Token = "0x400039C")]
		LessEq,
		[Token(Token = "0x400039D")]
		Less,
		[Token(Token = "0x400039E")]
		Eq,
		[Token(Token = "0x400039F")]
		Add,
		[Token(Token = "0x40003A0")]
		Sub,
		[Token(Token = "0x40003A1")]
		Mul,
		[Token(Token = "0x40003A2")]
		Div,
		[Token(Token = "0x40003A3")]
		Mod,
		[Token(Token = "0x40003A4")]
		Not,
		[Token(Token = "0x40003A5")]
		Len,
		[Token(Token = "0x40003A6")]
		Neg,
		[Token(Token = "0x40003A7")]
		Power,
		[Token(Token = "0x40003A8")]
		CNot,
		[Token(Token = "0x40003A9")]
		MkTuple,
		[Token(Token = "0x40003AA")]
		Scalar,
		[Token(Token = "0x40003AB")]
		Incr,
		[Token(Token = "0x40003AC")]
		ToNum,
		[Token(Token = "0x40003AD")]
		ToBool,
		[Token(Token = "0x40003AE")]
		ExpTuple,
		[Token(Token = "0x40003AF")]
		IterPrep,
		[Token(Token = "0x40003B0")]
		IterUpd,
		[Token(Token = "0x40003B1")]
		Invalid
	}
	[Token(Token = "0x2000119")]
	public enum OpCodeMetadataType
	{
		[Token(Token = "0x40003B3")]
		ChunkEntrypoint,
		[Token(Token = "0x40003B4")]
		FunctionEntrypoint
	}
	[Token(Token = "0x200011A")]
	internal sealed class Processor
	{
		[Token(Token = "0x200011B")]
		private class DebugContext
		{
			[Token(Token = "0x40003C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool DebuggerEnabled;

			[Token(Token = "0x40003C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public IDebugger DebuggerAttached;

			[Token(Token = "0x40003C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DebuggerAction.ActionType DebuggerCurrentAction;

			[Token(Token = "0x40003CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public int DebuggerCurrentActionTarget;

			[Token(Token = "0x40003CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public SourceRef LastHlRef;

			[Token(Token = "0x40003CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public int ExStackDepthAtStep;

			[Token(Token = "0x40003CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public List<SourceRef> BreakPoints;

			[Token(Token = "0x40003CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public bool LineBasedBreakPoints;

			[Token(Token = "0x600082D")]
			[Address(RVA = "0xDF63C0", Offset = "0xDF63C0", VA = "0xDF63C0")]
			public DebugContext()
			{
			}
		}

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private ByteCode m_RootChunk;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private FastStack<DynValue> m_ValueStack;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FastStack<CallStackItem> m_ExecutionStack;

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<Processor> m_CoroutinesStack;

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Table m_GlobalTable;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Script m_Script;

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Processor m_Parent;

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private CoroutineState m_State;

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool m_CanYield;

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int m_SavedInstructionPtr;

		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private DebugContext m_Debug;

		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int m_OwningThreadID;

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private int m_ExecutionNesting;

		[Token(Token = "0x40003C2")]
		private const ulong DUMP_CHUNK_MAGIC = 1877195438928383261uL;

		[Token(Token = "0x40003C3")]
		private const int DUMP_CHUNK_VERSION = 336;

		[Token(Token = "0x40003C5")]
		private const int YIELD_SPECIAL_TRAP = -99;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		internal long AutoYieldCounter;

		[Token(Token = "0x1700012E")]
		public CoroutineState State
		{
			[Token(Token = "0x60007D9")]
			[Address(RVA = "0xDED9C4", Offset = "0xDED9C4", VA = "0xDED9C4")]
			get
			{
				return default(CoroutineState);
			}
		}

		[Token(Token = "0x1700012F")]
		public Coroutine AssociatedCoroutine
		{
			[Token(Token = "0x60007DA")]
			[Address(RVA = "0xDED9CC", Offset = "0xDED9CC", VA = "0xDED9CC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60007DB")]
			[Address(RVA = "0xDED9D4", Offset = "0xDED9D4", VA = "0xDED9D4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000130")]
		internal bool DebuggerEnabled
		{
			[Token(Token = "0x60007DF")]
			[Address(RVA = "0xDEDE5C", Offset = "0xDEDE5C", VA = "0xDEDE5C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007E0")]
			[Address(RVA = "0xDEDE78", Offset = "0xDEDE78", VA = "0xDEDE78")]
			set
			{
			}
		}

		[Token(Token = "0x60007CC")]
		[Address(RVA = "0xDEA4FC", Offset = "0xDEA4FC", VA = "0xDEA4FC")]
		public Processor(Script script, Table globalContext, ByteCode byteCode)
		{
		}

		[Token(Token = "0x60007CD")]
		[Address(RVA = "0xDEA6D4", Offset = "0xDEA6D4", VA = "0xDEA6D4")]
		private Processor(Processor parentProcessor)
		{
		}

		[Token(Token = "0x60007CE")]
		[Address(RVA = "0xDEA7E4", Offset = "0xDEA7E4", VA = "0xDEA7E4")]
		public DynValue Call(DynValue function, DynValue[] args)
		{
			return null;
		}

		[Token(Token = "0x60007CF")]
		[Address(RVA = "0xDEAC40", Offset = "0xDEAC40", VA = "0xDEAC40")]
		private int PushClrToScriptStackFrame(CallStackItemFlags flags, DynValue function, DynValue[] args)
		{
			return default(int);
		}

		[Token(Token = "0x60007D0")]
		[Address(RVA = "0xDEC600", Offset = "0xDEC600", VA = "0xDEC600")]
		private void LeaveProcessor()
		{
		}

		[Token(Token = "0x60007D1")]
		[Address(RVA = "0xDEC718", Offset = "0xDEC718", VA = "0xDEC718")]
		private int GetThreadId()
		{
			return default(int);
		}

		[Token(Token = "0x60007D2")]
		[Address(RVA = "0xDEAAB4", Offset = "0xDEAAB4", VA = "0xDEAAB4")]
		private void EnterProcessor()
		{
		}

		[Token(Token = "0x60007D3")]
		[Address(RVA = "0xDEC738", Offset = "0xDEC738", VA = "0xDEC738")]
		internal SourceRef GetCoroutineSuspendedLocation()
		{
			return null;
		}

		[Token(Token = "0x60007D4")]
		[Address(RVA = "0xDEC7D0", Offset = "0xDEC7D0", VA = "0xDEC7D0")]
		internal static bool IsDumpStream(Stream stream)
		{
			return default(bool);
		}

		[Token(Token = "0x60007D5")]
		[Address(RVA = "0xDEC9F0", Offset = "0xDEC9F0", VA = "0xDEC9F0")]
		internal int Dump(Stream stream, int baseAddress, bool hasUpvalues)
		{
			return default(int);
		}

		[Token(Token = "0x60007D6")]
		[Address(RVA = "0xDED29C", Offset = "0xDED29C", VA = "0xDED29C")]
		private void AddSymbolToMap(Dictionary<SymbolRef, int> symbolMap, SymbolRef s)
		{
		}

		[Token(Token = "0x60007D7")]
		[Address(RVA = "0xDED34C", Offset = "0xDED34C", VA = "0xDED34C")]
		internal int Undump(Stream stream, int sourceID, Table envTable, out bool hasUpvalues)
		{
			return default(int);
		}

		[Token(Token = "0x60007D8")]
		[Address(RVA = "0xDED8C8", Offset = "0xDED8C8", VA = "0xDED8C8")]
		public DynValue Coroutine_Create(Closure closure)
		{
			return null;
		}

		[Token(Token = "0x60007DC")]
		[Address(RVA = "0xDED9DC", Offset = "0xDED9DC", VA = "0xDED9DC")]
		public DynValue Coroutine_Resume(DynValue[] args)
		{
			return null;
		}

		[Token(Token = "0x60007DD")]
		[Address(RVA = "0xDED208", Offset = "0xDED208", VA = "0xDED208")]
		internal Instruction FindMeta(ref int baseAddress)
		{
			return null;
		}

		[Token(Token = "0x60007DE")]
		[Address(RVA = "0xDEDD00", Offset = "0xDEDD00", VA = "0xDEDD00")]
		internal void AttachDebugger(IDebugger debugger)
		{
		}

		[Token(Token = "0x60007E1")]
		[Address(RVA = "0xDEDE98", Offset = "0xDEDE98", VA = "0xDEDE98")]
		private void ListenDebugger(Instruction instr, int instructionPtr)
		{
		}

		[Token(Token = "0x60007E2")]
		[Address(RVA = "0xDEEBC0", Offset = "0xDEEBC0", VA = "0xDEEBC0")]
		private void ResetBreakPoints(DebuggerAction action)
		{
		}

		[Token(Token = "0x60007E3")]
		[Address(RVA = "0xDEEC64", Offset = "0xDEEC64", VA = "0xDEEC64")]
		internal HashSet<int> ResetBreakPoints(SourceCode src, HashSet<int> lines)
		{
			return null;
		}

		[Token(Token = "0x60007E4")]
		[Address(RVA = "0xDEE708", Offset = "0xDEE708", VA = "0xDEE708")]
		private bool ToggleBreakPoint(DebuggerAction action, bool? state)
		{
			return default(bool);
		}

		[Token(Token = "0x60007E5")]
		[Address(RVA = "0xDEE2CC", Offset = "0xDEE2CC", VA = "0xDEE2CC")]
		private void RefreshDebugger(bool hard, int instructionPtr)
		{
		}

		[Token(Token = "0x60007E6")]
		[Address(RVA = "0xDEF5D8", Offset = "0xDEF5D8", VA = "0xDEF5D8")]
		private List<WatchItem> Debugger_RefreshThreads(ScriptExecutionContext context)
		{
			return null;
		}

		[Token(Token = "0x60007E7")]
		[Address(RVA = "0xDEF218", Offset = "0xDEF218", VA = "0xDEF218")]
		private List<WatchItem> Debugger_RefreshVStack()
		{
			return null;
		}

		[Token(Token = "0x60007E8")]
		[Address(RVA = "0xDEF124", Offset = "0xDEF124", VA = "0xDEF124")]
		private List<WatchItem> Debugger_RefreshWatches(ScriptExecutionContext context, List<DynamicExpression> watchList)
		{
			return null;
		}

		[Token(Token = "0x60007E9")]
		[Address(RVA = "0xDEF3D0", Offset = "0xDEF3D0", VA = "0xDEF3D0")]
		private List<WatchItem> Debugger_RefreshLocals(ScriptExecutionContext context)
		{
			return null;
		}

		[Token(Token = "0x60007EA")]
		[Address(RVA = "0xDEF6FC", Offset = "0xDEF6FC", VA = "0xDEF6FC")]
		private WatchItem Debugger_RefreshWatch(ScriptExecutionContext context, DynamicExpression dynExpr)
		{
			return null;
		}

		[Token(Token = "0x60007EB")]
		[Address(RVA = "0xDEEE70", Offset = "0xDEEE70", VA = "0xDEEE70")]
		internal List<WatchItem> Debugger_GetCallStack(SourceRef startingRef)
		{
			return null;
		}

		[Token(Token = "0x60007EC")]
		[Address(RVA = "0xDEC740", Offset = "0xDEC740", VA = "0xDEC740")]
		private SourceRef GetCurrentSourceRef(int instructionPtr)
		{
			return null;
		}

		[Token(Token = "0x60007ED")]
		[Address(RVA = "0xDEF8AC", Offset = "0xDEF8AC", VA = "0xDEF8AC")]
		private void FillDebugData(InterpreterException ex, int ip)
		{
		}

		[Token(Token = "0x60007EE")]
		[Address(RVA = "0xDEF92C", Offset = "0xDEF92C", VA = "0xDEF92C")]
		internal Table GetMetatable(DynValue value)
		{
			return null;
		}

		[Token(Token = "0x60007EF")]
		[Address(RVA = "0xDEF9A4", Offset = "0xDEF9A4", VA = "0xDEF9A4")]
		internal DynValue GetBinaryMetamethod(DynValue op1, DynValue op2, string eventName)
		{
			return null;
		}

		[Token(Token = "0x60007F0")]
		[Address(RVA = "0xDEFBCC", Offset = "0xDEFBCC", VA = "0xDEFBCC")]
		internal DynValue GetMetamethod(DynValue value, string metamethod)
		{
			return null;
		}

		[Token(Token = "0x60007F1")]
		[Address(RVA = "0xDEFCF4", Offset = "0xDEFCF4", VA = "0xDEFCF4")]
		internal DynValue GetMetamethodRaw(DynValue value, string metamethod)
		{
			return null;
		}

		[Token(Token = "0x60007F2")]
		[Address(RVA = "0xDEFD38", Offset = "0xDEFD38", VA = "0xDEFD38")]
		internal Script GetScript()
		{
			return null;
		}

		[Token(Token = "0x60007F3")]
		[Address(RVA = "0xDEAE68", Offset = "0xDEAE68", VA = "0xDEAE68")]
		private DynValue Processing_Loop(int instructionPtr)
		{
			return null;
		}

		[Token(Token = "0x60007F4")]
		[Address(RVA = "0xDF467C", Offset = "0xDF467C", VA = "0xDF467C")]
		internal string PerformMessageDecorationBeforeUnwind(DynValue messageHandler, string decoratedMessage, SourceRef sourceRef)
		{
			return null;
		}

		[Token(Token = "0x60007F5")]
		[Address(RVA = "0xDF4A10", Offset = "0xDF4A10", VA = "0xDF4A10")]
		private void AssignLocal(SymbolRef symref, DynValue value)
		{
		}

		[Token(Token = "0x60007F6")]
		[Address(RVA = "0xDF3AE8", Offset = "0xDF3AE8", VA = "0xDF3AE8")]
		private void ExecStoreLcl(Instruction i)
		{
		}

		[Token(Token = "0x60007F7")]
		[Address(RVA = "0xDF39BC", Offset = "0xDF39BC", VA = "0xDF39BC")]
		private void ExecStoreUpv(Instruction i)
		{
		}

		[Token(Token = "0x60007F8")]
		[Address(RVA = "0xDEFD40", Offset = "0xDEFD40", VA = "0xDEFD40")]
		private void ExecSwap(Instruction i)
		{
		}

		[Token(Token = "0x60007F9")]
		[Address(RVA = "0xDF4B1C", Offset = "0xDF4B1C", VA = "0xDF4B1C")]
		private DynValue GetStoreValue(Instruction i)
		{
			return null;
		}

		[Token(Token = "0x60007FA")]
		[Address(RVA = "0xDF22E8", Offset = "0xDF22E8", VA = "0xDF22E8")]
		private void ExecClosure(Instruction i)
		{
		}

		[Token(Token = "0x60007FB")]
		[Address(RVA = "0xDF4C18", Offset = "0xDF4C18", VA = "0xDF4C18")]
		private DynValue GetUpvalueSymbol(SymbolRef s)
		{
			return null;
		}

		[Token(Token = "0x60007FC")]
		[Address(RVA = "0xDF210C", Offset = "0xDF210C", VA = "0xDF210C")]
		private void ExecMkTuple(Instruction i)
		{
		}

		[Token(Token = "0x60007FD")]
		[Address(RVA = "0xDF2DA8", Offset = "0xDF2DA8", VA = "0xDF2DA8")]
		private void ExecToNum(Instruction i)
		{
		}

		[Token(Token = "0x60007FE")]
		[Address(RVA = "0xDF37DC", Offset = "0xDF37DC", VA = "0xDF37DC")]
		private void ExecIterUpd(Instruction i)
		{
		}

		[Token(Token = "0x60007FF")]
		[Address(RVA = "0xDF389C", Offset = "0xDF389C", VA = "0xDF389C")]
		private void ExecExpTuple(Instruction i)
		{
		}

		[Token(Token = "0x6000800")]
		[Address(RVA = "0xDF2FD0", Offset = "0xDF2FD0", VA = "0xDF2FD0")]
		private void ExecIterPrep(Instruction i)
		{
		}

		[Token(Token = "0x6000801")]
		[Address(RVA = "0xDF2EF4", Offset = "0xDF2EF4", VA = "0xDF2EF4")]
		private int ExecJFor(Instruction i, int instructionPtr)
		{
			return default(int);
		}

		[Token(Token = "0x6000802")]
		[Address(RVA = "0xDF2C98", Offset = "0xDF2C98", VA = "0xDF2C98")]
		private void ExecIncr(Instruction i)
		{
		}

		[Token(Token = "0x6000803")]
		[Address(RVA = "0xDF1E30", Offset = "0xDF1E30", VA = "0xDF1E30")]
		private void ExecCNot(Instruction i)
		{
		}

		[Token(Token = "0x6000804")]
		[Address(RVA = "0xDF1D60", Offset = "0xDF1D60", VA = "0xDF1D60")]
		private void ExecNot(Instruction i)
		{
		}

		[Token(Token = "0x6000805")]
		[Address(RVA = "0xDF2468", Offset = "0xDF2468", VA = "0xDF2468")]
		private void ExecBeginFn(Instruction i)
		{
		}

		[Token(Token = "0x6000806")]
		[Address(RVA = "0xDF4984", Offset = "0xDF4984", VA = "0xDF4984")]
		private CallStackItem PopToBasePointer()
		{
			return null;
		}

		[Token(Token = "0x6000807")]
		[Address(RVA = "0xDF4D44", Offset = "0xDF4D44", VA = "0xDF4D44")]
		private int PopExecStackAndCheckVStack(int vstackguard)
		{
			return default(int);
		}

		[Token(Token = "0x6000808")]
		[Address(RVA = "0xDF4DFC", Offset = "0xDF4DFC", VA = "0xDF4DFC")]
		private IList<DynValue> CreateArgsListForFunctionCall(int numargs, int offsFromTop)
		{
			return null;
		}

		[Token(Token = "0x6000809")]
		[Address(RVA = "0xDF2504", Offset = "0xDF2504", VA = "0xDF2504")]
		private void ExecArgs(Instruction I)
		{
		}

		[Token(Token = "0x600080A")]
		[Address(RVA = "0xDF16E4", Offset = "0xDF16E4", VA = "0xDF16E4")]
		private int Internal_ExecCall(int argsCount, int instructionPtr, [Optional] CallbackFunction handler, [Optional] CallbackFunction continuation, bool thisCall = false, [Optional] string debugText, [Optional] DynValue unwindHandler)
		{
			return default(int);
		}

		[Token(Token = "0x600080B")]
		[Address(RVA = "0xDF50C8", Offset = "0xDF50C8", VA = "0xDF50C8")]
		private int PerformTCO(int instructionPtr, int argsCount)
		{
			return default(int);
		}

		[Token(Token = "0x600080C")]
		[Address(RVA = "0xDF2960", Offset = "0xDF2960", VA = "0xDF2960")]
		private int ExecRet(Instruction i)
		{
			return default(int);
		}

		[Token(Token = "0x600080D")]
		[Address(RVA = "0xDF526C", Offset = "0xDF526C", VA = "0xDF526C")]
		private int Internal_CheckForTailRequests(Instruction i, int instructionPtr)
		{
			return default(int);
		}

		[Token(Token = "0x600080E")]
		[Address(RVA = "0xDF2078", Offset = "0xDF2078", VA = "0xDF2078")]
		private int JumpBool(Instruction i, bool expectedValueForJump, int instructionPtr)
		{
			return default(int);
		}

		[Token(Token = "0x600080F")]
		[Address(RVA = "0xDF1FB0", Offset = "0xDF1FB0", VA = "0xDF1FB0")]
		private int ExecShortCircuitingOperator(Instruction i, int instructionPtr)
		{
			return default(int);
		}

		[Token(Token = "0x6000810")]
		[Address(RVA = "0xDEFE08", Offset = "0xDEFE08", VA = "0xDEFE08")]
		private int ExecAdd(Instruction i, int instructionPtr)
		{
			return default(int);
		}

		[Token(Token = "0x6000811")]
		[Address(RVA = "0xDF0318", Offset = "0xDF0318", VA = "0xDF0318")]
		private int ExecSub(Instruction i, int instructionPtr)
		{
			return default(int);
		}

		[Token(Token = "0x6000812")]
		[Address(RVA = "0xDF0508", Offset = "0xDF0508", VA = "0xDF0508")]
		private int ExecMul(Instruction i, int instructionPtr)
		{
			return default(int);
		}

		[Token(Token = "0x6000813")]
		[Address(RVA = "0xDF08E8", Offset = "0xDF08E8", VA = "0xDF08E8")]
		private int ExecMod(Instruction i, int instructionPtr)
		{
			return default(int);
		}

		[Token(Token = "0x6000814")]
		[Address(RVA = "0xDF06F8", Offset = "0xDF06F8", VA = "0xDF06F8")]
		private int ExecDiv(Instruction i, int instructionPtr)
		{
			return default(int);
		}

		[Token(Token = "0x6000815")]
		[Address(RVA = "0xDF0B28", Offset = "0xDF0B28", VA = "0xDF0B28")]
		private int ExecPower(Instruction i, int instructionPtr)
		{
			return default(int);
		}

		[Token(Token = "0x6000816")]
		[Address(RVA = "0xDF0194", Offset = "0xDF0194", VA = "0xDF0194")]
		private int ExecNeg(Instruction i, int instructionPtr)
		{
			return default(int);
		}

		[Token(Token = "0x6000817")]
		[Address(RVA = "0xDF0D50", Offset = "0xDF0D50", VA = "0xDF0D50")]
		private int ExecEq(Instruction i, int instructionPtr)
		{
			return default(int);
		}

		[Token(Token = "0x6000818")]
		[Address(RVA = "0xDF1368", Offset = "0xDF1368", VA = "0xDF1368")]
		private int ExecLess(Instruction i, int instructionPtr)
		{
			return default(int);
		}

		[Token(Token = "0x6000819")]
		[Address(RVA = "0xDF1008", Offset = "0xDF1008", VA = "0xDF1008")]
		private int ExecLessEq(Instruction i, int instructionPtr)
		{
			return default(int);
		}

		[Token(Token = "0x600081A")]
		[Address(RVA = "0xDF1564", Offset = "0xDF1564", VA = "0xDF1564")]
		private int ExecLen(Instruction i, int instructionPtr)
		{
			return default(int);
		}

		[Token(Token = "0x600081B")]
		[Address(RVA = "0xDEFFF8", Offset = "0xDEFFF8", VA = "0xDEFFF8")]
		private int ExecConcat(Instruction i, int instructionPtr)
		{
			return default(int);
		}

		[Token(Token = "0x600081C")]
		[Address(RVA = "0xDF3C88", Offset = "0xDF3C88", VA = "0xDF3C88")]
		private void ExecTblInitI(Instruction i)
		{
		}

		[Token(Token = "0x600081D")]
		[Address(RVA = "0xDF3B1C", Offset = "0xDF3B1C", VA = "0xDF3B1C")]
		private void ExecTblInitN(Instruction i)
		{
		}

		[Token(Token = "0x600081E")]
		[Address(RVA = "0xDF425C", Offset = "0xDF425C", VA = "0xDF425C")]
		private int ExecIndexSet(Instruction i, int instructionPtr)
		{
			return default(int);
		}

		[Token(Token = "0x600081F")]
		[Address(RVA = "0xDF3DD4", Offset = "0xDF3DD4", VA = "0xDF3DD4")]
		private int ExecIndex(Instruction i, int instructionPtr)
		{
			return default(int);
		}

		[Token(Token = "0x6000820")]
		[Address(RVA = "0xDF2254", Offset = "0xDF2254", VA = "0xDF2254")]
		private void ClearBlockData(Instruction I)
		{
		}

		[Token(Token = "0x6000821")]
		[Address(RVA = "0xDF5684", Offset = "0xDF5684", VA = "0xDF5684")]
		public DynValue GetGenericSymbol(SymbolRef symref)
		{
			return null;
		}

		[Token(Token = "0x6000822")]
		[Address(RVA = "0xDF58A8", Offset = "0xDF58A8", VA = "0xDF58A8")]
		private DynValue GetGlobalSymbol(DynValue dynValue, string name)
		{
			return null;
		}

		[Token(Token = "0x6000823")]
		[Address(RVA = "0xDF5A08", Offset = "0xDF5A08", VA = "0xDF5A08")]
		private void SetGlobalSymbol(DynValue dynValue, string name, DynValue value)
		{
		}

		[Token(Token = "0x6000824")]
		[Address(RVA = "0xDF5B58", Offset = "0xDF5B58", VA = "0xDF5B58")]
		public void AssignGenericSymbol(SymbolRef symref, DynValue value)
		{
		}

		[Token(Token = "0x6000825")]
		[Address(RVA = "0xDF5964", Offset = "0xDF5964", VA = "0xDF5964")]
		private CallStackItem GetTopNonClrFunction()
		{
			return null;
		}

		[Token(Token = "0x6000826")]
		[Address(RVA = "0xDF5E68", Offset = "0xDF5E68", VA = "0xDF5E68")]
		public SymbolRef FindSymbolByName(string name)
		{
			return null;
		}

		[Token(Token = "0x6000827")]
		[Address(RVA = "0xDEBE3C", Offset = "0xDEBE3C", VA = "0xDEBE3C")]
		private DynValue[] Internal_AdjustTuple(IList<DynValue> values)
		{
			return null;
		}

		[Token(Token = "0x6000828")]
		[Address(RVA = "0xDF54D4", Offset = "0xDF54D4", VA = "0xDF54D4")]
		private int Internal_InvokeUnaryMetaMethod(DynValue op1, string eventName, int instructionPtr)
		{
			return default(int);
		}

		[Token(Token = "0x6000829")]
		[Address(RVA = "0xDF53C8", Offset = "0xDF53C8", VA = "0xDF53C8")]
		private int Internal_InvokeBinaryMetaMethod(DynValue l, DynValue r, string eventName, int instructionPtr, [Optional] DynValue extraPush)
		{
			return default(int);
		}

		[Token(Token = "0x600082A")]
		[Address(RVA = "0xDF60A4", Offset = "0xDF60A4", VA = "0xDF60A4")]
		private DynValue[] StackTopToArray(int items, bool pop)
		{
			return null;
		}

		[Token(Token = "0x600082B")]
		[Address(RVA = "0xDF6234", Offset = "0xDF6234", VA = "0xDF6234")]
		private DynValue[] StackTopToArrayReverse(int items, bool pop)
		{
			return null;
		}
	}
}
namespace MoonSharp.Interpreter.Execution.Scopes
{
	[Token(Token = "0x200011E")]
	internal class BuildTimeScopeBlock
	{
		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Dictionary<string, SymbolRef> m_DefinedNames;

		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<GotoStatement> m_PendingGotos;

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Dictionary<string, LabelStatement> m_LocalLabels;

		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string m_LastDefinedName;

		[Token(Token = "0x17000131")]
		internal BuildTimeScopeBlock Parent
		{
			[Token(Token = "0x6000833")]
			[Address(RVA = "0xDF65B8", Offset = "0xDF65B8", VA = "0xDF65B8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000834")]
			[Address(RVA = "0xDF65C0", Offset = "0xDF65C0", VA = "0xDF65C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000132")]
		internal List<BuildTimeScopeBlock> ChildNodes
		{
			[Token(Token = "0x6000835")]
			[Address(RVA = "0xDF65C8", Offset = "0xDF65C8", VA = "0xDF65C8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000836")]
			[Address(RVA = "0xDF65D0", Offset = "0xDF65D0", VA = "0xDF65D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000133")]
		internal RuntimeScopeBlock ScopeBlock
		{
			[Token(Token = "0x6000837")]
			[Address(RVA = "0xDF65D8", Offset = "0xDF65D8", VA = "0xDF65D8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000838")]
			[Address(RVA = "0xDF65E0", Offset = "0xDF65E0", VA = "0xDF65E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000839")]
		[Address(RVA = "0xDF65E8", Offset = "0xDF65E8", VA = "0xDF65E8")]
		internal void Rename(string name)
		{
		}

		[Token(Token = "0x600083A")]
		[Address(RVA = "0xDF6718", Offset = "0xDF6718", VA = "0xDF6718")]
		internal BuildTimeScopeBlock(BuildTimeScopeBlock parent)
		{
		}

		[Token(Token = "0x600083B")]
		[Address(RVA = "0xDF681C", Offset = "0xDF681C", VA = "0xDF681C")]
		internal BuildTimeScopeBlock AddChild()
		{
			return null;
		}

		[Token(Token = "0x600083C")]
		[Address(RVA = "0xDF68EC", Offset = "0xDF68EC", VA = "0xDF68EC")]
		internal SymbolRef Find(string name)
		{
			return null;
		}

		[Token(Token = "0x600083D")]
		[Address(RVA = "0xDF6944", Offset = "0xDF6944", VA = "0xDF6944")]
		internal SymbolRef Define(string name)
		{
			return null;
		}

		[Token(Token = "0x600083E")]
		[Address(RVA = "0xDF69F0", Offset = "0xDF69F0", VA = "0xDF69F0")]
		internal int ResolveLRefs(BuildTimeScopeFrame buildTimeScopeFrame)
		{
			return default(int);
		}

		[Token(Token = "0x600083F")]
		[Address(RVA = "0xDF6F70", Offset = "0xDF6F70", VA = "0xDF6F70")]
		internal void DefineLabel(LabelStatement label)
		{
		}

		[Token(Token = "0x6000840")]
		[Address(RVA = "0xDF71C4", Offset = "0xDF71C4", VA = "0xDF71C4")]
		internal void RegisterGoto(GotoStatement gotostat)
		{
		}

		[Token(Token = "0x6000841")]
		[Address(RVA = "0xDF72E8", Offset = "0xDF72E8", VA = "0xDF72E8")]
		internal void ResolveGotos()
		{
		}
	}
	[Token(Token = "0x200011F")]
	internal class BuildTimeScopeFrame
	{
		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private BuildTimeScopeBlock m_ScopeTreeRoot;

		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private BuildTimeScopeBlock m_ScopeTreeHead;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private RuntimeScopeFrame m_ScopeFrame;

		[Token(Token = "0x17000134")]
		public bool HasVarArgs
		{
			[Token(Token = "0x6000842")]
			[Address(RVA = "0xDF77B0", Offset = "0xDF77B0", VA = "0xDF77B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000843")]
			[Address(RVA = "0xDF77B8", Offset = "0xDF77B8", VA = "0xDF77B8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000844")]
		[Address(RVA = "0xDF77C4", Offset = "0xDF77C4", VA = "0xDF77C4")]
		internal BuildTimeScopeFrame(bool hasVarArgs)
		{
		}

		[Token(Token = "0x6000845")]
		[Address(RVA = "0xDF7874", Offset = "0xDF7874", VA = "0xDF7874")]
		internal void PushBlock()
		{
		}

		[Token(Token = "0x6000846")]
		[Address(RVA = "0xDF7898", Offset = "0xDF7898", VA = "0xDF7898")]
		internal RuntimeScopeBlock PopBlock()
		{
			return null;
		}

		[Token(Token = "0x6000847")]
		[Address(RVA = "0xDF7928", Offset = "0xDF7928", VA = "0xDF7928")]
		internal RuntimeScopeFrame GetRuntimeFrameData()
		{
			return null;
		}

		[Token(Token = "0x6000848")]
		[Address(RVA = "0xDF79AC", Offset = "0xDF79AC", VA = "0xDF79AC")]
		internal SymbolRef Find(string name)
		{
			return null;
		}

		[Token(Token = "0x6000849")]
		[Address(RVA = "0xDF79E8", Offset = "0xDF79E8", VA = "0xDF79E8")]
		internal SymbolRef DefineLocal(string name)
		{
			return null;
		}

		[Token(Token = "0x600084A")]
		[Address(RVA = "0xDF7A00", Offset = "0xDF7A00", VA = "0xDF7A00")]
		internal SymbolRef TryDefineLocal(string name)
		{
			return null;
		}

		[Token(Token = "0x600084B")]
		[Address(RVA = "0xDF7A4C", Offset = "0xDF7A4C", VA = "0xDF7A4C")]
		internal void ResolveLRefs()
		{
		}

		[Token(Token = "0x600084C")]
		[Address(RVA = "0xDF6E54", Offset = "0xDF6E54", VA = "0xDF6E54")]
		internal int AllocVar(SymbolRef var)
		{
			return default(int);
		}

		[Token(Token = "0x600084D")]
		[Address(RVA = "0xDF6F20", Offset = "0xDF6F20", VA = "0xDF6F20")]
		internal int GetPosForNextVar()
		{
			return default(int);
		}

		[Token(Token = "0x600084E")]
		[Address(RVA = "0xDF7A78", Offset = "0xDF7A78", VA = "0xDF7A78")]
		internal void DefineLabel(LabelStatement label)
		{
		}

		[Token(Token = "0x600084F")]
		[Address(RVA = "0xDF7A90", Offset = "0xDF7A90", VA = "0xDF7A90")]
		internal void RegisterGoto(GotoStatement gotostat)
		{
		}
	}
}
namespace MoonSharp.Interpreter.Diagnostics
{
	[Token(Token = "0x2000120")]
	public enum PerformanceCounter
	{
		[Token(Token = "0x40003DF")]
		AstCreation,
		[Token(Token = "0x40003E0")]
		Compilation,
		[Token(Token = "0x40003E1")]
		Execution,
		[Token(Token = "0x40003E2")]
		AdaptersCompilation,
		[Token(Token = "0x40003E3")]
		LastValue
	}
	[Token(Token = "0x2000121")]
	public enum PerformanceCounterType
	{
		[Token(Token = "0x40003E5")]
		MemoryBytes,
		[Token(Token = "0x40003E6")]
		TimeMilliseconds
	}
	[Token(Token = "0x2000122")]
	public class PerformanceResult
	{
		[Token(Token = "0x17000135")]
		public string Name
		{
			[Token(Token = "0x6000850")]
			[Address(RVA = "0xDF7AA8", Offset = "0xDF7AA8", VA = "0xDF7AA8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000851")]
			[Address(RVA = "0xDF7AB0", Offset = "0xDF7AB0", VA = "0xDF7AB0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Token(Token = "0x17000136")]
		public long Counter
		{
			[Token(Token = "0x6000852")]
			[Address(RVA = "0xDF7AB8", Offset = "0xDF7AB8", VA = "0xDF7AB8")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Token(Token = "0x6000853")]
			[Address(RVA = "0xDF7AC0", Offset = "0xDF7AC0", VA = "0xDF7AC0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Token(Token = "0x17000137")]
		public int Instances
		{
			[Token(Token = "0x6000854")]
			[Address(RVA = "0xDF7AC8", Offset = "0xDF7AC8", VA = "0xDF7AC8")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000855")]
			[Address(RVA = "0xDF7AD0", Offset = "0xDF7AD0", VA = "0xDF7AD0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Token(Token = "0x17000138")]
		public bool Global
		{
			[Token(Token = "0x6000856")]
			[Address(RVA = "0xDF7AD8", Offset = "0xDF7AD8", VA = "0xDF7AD8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000857")]
			[Address(RVA = "0xDF7AE0", Offset = "0xDF7AE0", VA = "0xDF7AE0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Token(Token = "0x17000139")]
		public PerformanceCounterType Type
		{
			[Token(Token = "0x6000858")]
			[Address(RVA = "0xDF7AEC", Offset = "0xDF7AEC", VA = "0xDF7AEC")]
			[CompilerGenerated]
			get
			{
				return default(PerformanceCounterType);
			}
			[Token(Token = "0x6000859")]
			[Address(RVA = "0xDF7AF4", Offset = "0xDF7AF4", VA = "0xDF7AF4")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Token(Token = "0x600085A")]
		[Address(RVA = "0xDF7AFC", Offset = "0xDF7AFC", VA = "0xDF7AFC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600085B")]
		[Address(RVA = "0xDF7D08", Offset = "0xDF7D08", VA = "0xDF7D08")]
		public static string PerformanceCounterTypeToString(PerformanceCounterType Type)
		{
			return null;
		}

		[Token(Token = "0x600085C")]
		[Address(RVA = "0xDF7DFC", Offset = "0xDF7DFC", VA = "0xDF7DFC")]
		public PerformanceResult()
		{
		}
	}
	[Token(Token = "0x2000123")]
	public class PerformanceStatistics
	{
		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IPerformanceStopwatch[] m_Stopwatches;

		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static IPerformanceStopwatch[] m_GlobalStopwatches;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool m_Enabled;

		[Token(Token = "0x1700013A")]
		public bool Enabled
		{
			[Token(Token = "0x600085D")]
			[Address(RVA = "0xDF7E04", Offset = "0xDF7E04", VA = "0xDF7E04")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600085E")]
			[Address(RVA = "0xDF7E0C", Offset = "0xDF7E0C", VA = "0xDF7E0C")]
			set
			{
			}
		}

		[Token(Token = "0x600085F")]
		[Address(RVA = "0xDF80D4", Offset = "0xDF80D4", VA = "0xDF80D4")]
		public PerformanceResult GetPerformanceCounterResult(PerformanceCounter pc)
		{
			return null;
		}

		[Token(Token = "0x6000860")]
		[Address(RVA = "0xDF81A8", Offset = "0xDF81A8", VA = "0xDF81A8")]
		internal IDisposable StartStopwatch(PerformanceCounter pc)
		{
			return null;
		}

		[Token(Token = "0x6000861")]
		[Address(RVA = "0xDF8278", Offset = "0xDF8278", VA = "0xDF8278")]
		internal static IDisposable StartGlobalStopwatch(PerformanceCounter pc)
		{
			return null;
		}

		[Token(Token = "0x6000862")]
		[Address(RVA = "0xDF8370", Offset = "0xDF8370", VA = "0xDF8370")]
		public string GetPerformanceLog()
		{
			return null;
		}

		[Token(Token = "0x6000863")]
		[Address(RVA = "0xDF8414", Offset = "0xDF8414", VA = "0xDF8414")]
		public PerformanceStatistics()
		{
		}
	}
	[Token(Token = "0x2000124")]
	internal static class NamespaceDoc
	{
	}
}
namespace MoonSharp.Interpreter.Diagnostics.PerformanceCounters
{
	[Token(Token = "0x2000125")]
	internal class DummyPerformanceStopwatch : IPerformanceStopwatch, IDisposable
	{
		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static DummyPerformanceStopwatch Instance;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private PerformanceResult m_Result;

		[Token(Token = "0x6000865")]
		[Address(RVA = "0xDF84D4", Offset = "0xDF84D4", VA = "0xDF84D4")]
		private DummyPerformanceStopwatch()
		{
		}

		[Token(Token = "0x6000866")]
		[Address(RVA = "0xDF856C", Offset = "0xDF856C", VA = "0xDF856C", Slot = "4")]
		public IDisposable Start()
		{
			return null;
		}

		[Token(Token = "0x6000867")]
		[Address(RVA = "0xDF8570", Offset = "0xDF8570", VA = "0xDF8570", Slot = "5")]
		public PerformanceResult GetResult()
		{
			return null;
		}

		[Token(Token = "0x6000868")]
		[Address(RVA = "0xDF8578", Offset = "0xDF8578", VA = "0xDF8578", Slot = "6")]
		public void Dispose()
		{
		}
	}
	[Token(Token = "0x2000126")]
	internal class GlobalPerformanceStopwatch : IPerformanceStopwatch
	{
		[Token(Token = "0x2000127")]
		private class GlobalPerformanceStopwatch_StopwatchObject : IDisposable
		{
			[Token(Token = "0x40003F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private Stopwatch m_Stopwatch;

			[Token(Token = "0x40003F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private GlobalPerformanceStopwatch m_Parent;

			[Token(Token = "0x600086E")]
			[Address(RVA = "0xDF8680", Offset = "0xDF8680", VA = "0xDF8680")]
			public GlobalPerformanceStopwatch_StopwatchObject(GlobalPerformanceStopwatch parent)
			{
			}

			[Token(Token = "0x600086F")]
			[Address(RVA = "0xDF87B4", Offset = "0xDF87B4", VA = "0xDF87B4", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int m_Count;

		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private long m_Elapsed;

		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private PerformanceCounter m_Counter;

		[Token(Token = "0x600086A")]
		[Address(RVA = "0xDF8030", Offset = "0xDF8030", VA = "0xDF8030")]
		public GlobalPerformanceStopwatch(PerformanceCounter perfcounter)
		{
		}

		[Token(Token = "0x600086B")]
		[Address(RVA = "0xDF85DC", Offset = "0xDF85DC", VA = "0xDF85DC")]
		private void SignalStopwatchTerminated(Stopwatch sw)
		{
		}

		[Token(Token = "0x600086C")]
		[Address(RVA = "0xDF8620", Offset = "0xDF8620", VA = "0xDF8620", Slot = "4")]
		public IDisposable Start()
		{
			return null;
		}

		[Token(Token = "0x600086D")]
		[Address(RVA = "0xDF86F8", Offset = "0xDF86F8", VA = "0xDF86F8", Slot = "5")]
		public PerformanceResult GetResult()
		{
			return null;
		}
	}
	[Token(Token = "0x2000128")]
	internal interface IPerformanceStopwatch
	{
		[Token(Token = "0x6000870")]
		IDisposable Start();

		[Token(Token = "0x6000871")]
		PerformanceResult GetResult();
	}
	[Token(Token = "0x2000129")]
	internal class PerformanceStopwatch : IDisposable, IPerformanceStopwatch
	{
		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Stopwatch m_Stopwatch;

		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int m_Count;

		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private int m_Reentrant;

		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private PerformanceCounter m_Counter;

		[Token(Token = "0x6000872")]
		[Address(RVA = "0xDF8058", Offset = "0xDF8058", VA = "0xDF8058")]
		public PerformanceStopwatch(PerformanceCounter perfcounter)
		{
		}

		[Token(Token = "0x6000873")]
		[Address(RVA = "0xDF87E4", Offset = "0xDF87E4", VA = "0xDF87E4", Slot = "5")]
		public IDisposable Start()
		{
			return null;
		}

		[Token(Token = "0x6000874")]
		[Address(RVA = "0xDF882C", Offset = "0xDF882C", VA = "0xDF882C", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000875")]
		[Address(RVA = "0xDF8860", Offset = "0xDF8860", VA = "0xDF8860", Slot = "6")]
		public PerformanceResult GetResult()
		{
			return null;
		}
	}
}
namespace MoonSharp.Interpreter.Debugging
{
	[Token(Token = "0x200012A")]
	public class DebuggerAction
	{
		[Token(Token = "0x200012B")]
		public enum ActionType
		{
			[Token(Token = "0x4000401")]
			ByteCodeStepIn,
			[Token(Token = "0x4000402")]
			ByteCodeStepOver,
			[Token(Token = "0x4000403")]
			ByteCodeStepOut,
			[Token(Token = "0x4000404")]
			StepIn,
			[Token(Token = "0x4000405")]
			StepOver,
			[Token(Token = "0x4000406")]
			StepOut,
			[Token(Token = "0x4000407")]
			Run,
			[Token(Token = "0x4000408")]
			ToggleBreakpoint,
			[Token(Token = "0x4000409")]
			SetBreakpoint,
			[Token(Token = "0x400040A")]
			ClearBreakpoint,
			[Token(Token = "0x400040B")]
			ResetBreakpoints,
			[Token(Token = "0x400040C")]
			Refresh,
			[Token(Token = "0x400040D")]
			HardRefresh,
			[Token(Token = "0x400040E")]
			None
		}

		[Token(Token = "0x1700013B")]
		public ActionType Action
		{
			[Token(Token = "0x6000876")]
			[Address(RVA = "0xDF8928", Offset = "0xDF8928", VA = "0xDF8928")]
			[CompilerGenerated]
			get
			{
				return default(ActionType);
			}
			[Token(Token = "0x6000877")]
			[Address(RVA = "0xDF8930", Offset = "0xDF8930", VA = "0xDF8930")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700013C")]
		public DateTime TimeStampUTC
		{
			[Token(Token = "0x6000878")]
			[Address(RVA = "0xDF8938", Offset = "0xDF8938", VA = "0xDF8938")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x6000879")]
			[Address(RVA = "0xDF8940", Offset = "0xDF8940", VA = "0xDF8940")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700013D")]
		public int SourceID
		{
			[Token(Token = "0x600087A")]
			[Address(RVA = "0xDF8948", Offset = "0xDF8948", VA = "0xDF8948")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600087B")]
			[Address(RVA = "0xDF8950", Offset = "0xDF8950", VA = "0xDF8950")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700013E")]
		public int SourceLine
		{
			[Token(Token = "0x600087C")]
			[Address(RVA = "0xDF8958", Offset = "0xDF8958", VA = "0xDF8958")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600087D")]
			[Address(RVA = "0xDF8960", Offset = "0xDF8960", VA = "0xDF8960")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700013F")]
		public int SourceCol
		{
			[Token(Token = "0x600087E")]
			[Address(RVA = "0xDF8968", Offset = "0xDF8968", VA = "0xDF8968")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600087F")]
			[Address(RVA = "0xDF8970", Offset = "0xDF8970", VA = "0xDF8970")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000140")]
		public int[] Lines
		{
			[Token(Token = "0x6000880")]
			[Address(RVA = "0xDF8978", Offset = "0xDF8978", VA = "0xDF8978")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000881")]
			[Address(RVA = "0xDF8980", Offset = "0xDF8980", VA = "0xDF8980")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000141")]
		public TimeSpan Age
		{
			[Token(Token = "0x6000883")]
			[Address(RVA = "0xDF89F0", Offset = "0xDF89F0", VA = "0xDF89F0")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Token(Token = "0x6000882")]
		[Address(RVA = "0xDF8988", Offset = "0xDF8988", VA = "0xDF8988")]
		public DebuggerAction()
		{
		}

		[Token(Token = "0x6000884")]
		[Address(RVA = "0xDF8A50", Offset = "0xDF8A50", VA = "0xDF8A50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x200012C")]
	[Flags]
	public enum DebuggerCaps
	{
		[Token(Token = "0x4000410")]
		CanDebugSourceCode = 1,
		[Token(Token = "0x4000411")]
		CanDebugByteCode = 2,
		[Token(Token = "0x4000412")]
		HasLineBasedBreakpoints = 4
	}
	[Token(Token = "0x200012D")]
	public sealed class DebugService : IScriptPrivateResource
	{
		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Processor m_Processor;

		[Token(Token = "0x17000142")]
		public Script OwnerScript
		{
			[Token(Token = "0x6000886")]
			[Address(RVA = "0xDF8C6C", Offset = "0xDF8C6C", VA = "0xDF8C6C", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000887")]
			[Address(RVA = "0xDF8C74", Offset = "0xDF8C74", VA = "0xDF8C74")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000885")]
		[Address(RVA = "0xDF8C40", Offset = "0xDF8C40", VA = "0xDF8C40")]
		internal DebugService(Script script, Processor processor)
		{
		}

		[Token(Token = "0x6000888")]
		[Address(RVA = "0xDF8C7C", Offset = "0xDF8C7C", VA = "0xDF8C7C")]
		public HashSet<int> ResetBreakPoints(SourceCode src, HashSet<int> lines)
		{
			return null;
		}
	}
	[Token(Token = "0x200012E")]
	public interface IDebugger
	{
		[Token(Token = "0x6000889")]
		DebuggerCaps GetDebuggerCaps();

		[Token(Token = "0x600088A")]
		void SetDebugService(DebugService debugService);

		[Token(Token = "0x600088B")]
		void SetSourceCode(SourceCode sourceCode);

		[Token(Token = "0x600088C")]
		void SetByteCode(string[] byteCode);

		[Token(Token = "0x600088D")]
		bool IsPauseRequested();

		[Token(Token = "0x600088E")]
		bool SignalRuntimeException(ScriptRuntimeException ex);

		[Token(Token = "0x600088F")]
		DebuggerAction GetAction(int ip, SourceRef sourceref);

		[Token(Token = "0x6000890")]
		void SignalExecutionEnded();

		[Token(Token = "0x6000891")]
		void Update(WatchType watchType, IEnumerable<WatchItem> items);

		[Token(Token = "0x6000892")]
		List<DynamicExpression> GetWatchItems();

		[Token(Token = "0x6000893")]
		void RefreshBreakpoints(IEnumerable<SourceRef> refs);
	}
	[Token(Token = "0x200012F")]
	public class SourceCode : IScriptPrivateResource
	{
		[Token(Token = "0x17000143")]
		public string Name
		{
			[Token(Token = "0x6000894")]
			[Address(RVA = "0xDF8C98", Offset = "0xDF8C98", VA = "0xDF8C98")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000895")]
			[Address(RVA = "0xDF8CA0", Offset = "0xDF8CA0", VA = "0xDF8CA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000144")]
		public string Code
		{
			[Token(Token = "0x6000896")]
			[Address(RVA = "0xDF8CA8", Offset = "0xDF8CA8", VA = "0xDF8CA8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000897")]
			[Address(RVA = "0xDF8CB0", Offset = "0xDF8CB0", VA = "0xDF8CB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000145")]
		public string[] Lines
		{
			[Token(Token = "0x6000898")]
			[Address(RVA = "0xDF8CB8", Offset = "0xDF8CB8", VA = "0xDF8CB8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000899")]
			[Address(RVA = "0xDF8CC0", Offset = "0xDF8CC0", VA = "0xDF8CC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000146")]
		public Script OwnerScript
		{
			[Token(Token = "0x600089A")]
			[Address(RVA = "0xDF8CC8", Offset = "0xDF8CC8", VA = "0xDF8CC8", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600089B")]
			[Address(RVA = "0xDF8CD0", Offset = "0xDF8CD0", VA = "0xDF8CD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000147")]
		public int SourceID
		{
			[Token(Token = "0x600089C")]
			[Address(RVA = "0xDF8CD8", Offset = "0xDF8CD8", VA = "0xDF8CD8")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600089D")]
			[Address(RVA = "0xDF8CE0", Offset = "0xDF8CE0", VA = "0xDF8CE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000148")]
		internal List<SourceRef> Refs
		{
			[Token(Token = "0x600089E")]
			[Address(RVA = "0xDF8CE8", Offset = "0xDF8CE8", VA = "0xDF8CE8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600089F")]
			[Address(RVA = "0xDF8CF0", Offset = "0xDF8CF0", VA = "0xDF8CF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60008A0")]
		[Address(RVA = "0xDF8CF8", Offset = "0xDF8CF8", VA = "0xDF8CF8")]
		internal SourceCode(string name, string code, int sourceID, Script ownerScript)
		{
		}

		[Token(Token = "0x60008A1")]
		[Address(RVA = "0xDF8ED8", Offset = "0xDF8ED8", VA = "0xDF8ED8")]
		public string GetCodeSnippet(SourceRef sourceCodeRef)
		{
			return null;
		}

		[Token(Token = "0x60008A2")]
		[Address(RVA = "0xDF9100", Offset = "0xDF9100", VA = "0xDF9100")]
		private int AdjustStrIndex(string str, int loc)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000130")]
	public class SourceRef
	{
		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool Breakpoint;

		[Token(Token = "0x17000149")]
		public bool IsClrLocation
		{
			[Token(Token = "0x60008A3")]
			[Address(RVA = "0xDF9178", Offset = "0xDF9178", VA = "0xDF9178")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008A4")]
			[Address(RVA = "0xDF9180", Offset = "0xDF9180", VA = "0xDF9180")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700014A")]
		public int SourceIdx
		{
			[Token(Token = "0x60008A5")]
			[Address(RVA = "0xDF918C", Offset = "0xDF918C", VA = "0xDF918C")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60008A6")]
			[Address(RVA = "0xDF9194", Offset = "0xDF9194", VA = "0xDF9194")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700014B")]
		public int FromChar
		{
			[Token(Token = "0x60008A7")]
			[Address(RVA = "0xDF919C", Offset = "0xDF919C", VA = "0xDF919C")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60008A8")]
			[Address(RVA = "0xDF91A4", Offset = "0xDF91A4", VA = "0xDF91A4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700014C")]
		public int ToChar
		{
			[Token(Token = "0x60008A9")]
			[Address(RVA = "0xDF91AC", Offset = "0xDF91AC", VA = "0xDF91AC")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60008AA")]
			[Address(RVA = "0xDF91B4", Offset = "0xDF91B4", VA = "0xDF91B4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700014D")]
		public int FromLine
		{
			[Token(Token = "0x60008AB")]
			[Address(RVA = "0xDF91BC", Offset = "0xDF91BC", VA = "0xDF91BC")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60008AC")]
			[Address(RVA = "0xDF91C4", Offset = "0xDF91C4", VA = "0xDF91C4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700014E")]
		public int ToLine
		{
			[Token(Token = "0x60008AD")]
			[Address(RVA = "0xDF91CC", Offset = "0xDF91CC", VA = "0xDF91CC")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60008AE")]
			[Address(RVA = "0xDF91D4", Offset = "0xDF91D4", VA = "0xDF91D4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700014F")]
		public bool IsStepStop
		{
			[Token(Token = "0x60008AF")]
			[Address(RVA = "0xDF91DC", Offset = "0xDF91DC", VA = "0xDF91DC")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008B0")]
			[Address(RVA = "0xDF91E4", Offset = "0xDF91E4", VA = "0xDF91E4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000150")]
		public bool CannotBreakpoint
		{
			[Token(Token = "0x60008B1")]
			[Address(RVA = "0xDF91F0", Offset = "0xDF91F0", VA = "0xDF91F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008B2")]
			[Address(RVA = "0xDF91F8", Offset = "0xDF91F8", VA = "0xDF91F8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60008B3")]
		[Address(RVA = "0xDF9204", Offset = "0xDF9204", VA = "0xDF9204")]
		internal static SourceRef GetClrLocation()
		{
			return null;
		}

		[Token(Token = "0x60008B4")]
		[Address(RVA = "0xDF92D0", Offset = "0xDF92D0", VA = "0xDF92D0")]
		public SourceRef(SourceRef src, bool isStepStop)
		{
		}

		[Token(Token = "0x60008B5")]
		[Address(RVA = "0xDF9274", Offset = "0xDF9274", VA = "0xDF9274")]
		public SourceRef(int sourceIdx, int from, int to, int fromline, int toline, bool isStepStop)
		{
		}

		[Token(Token = "0x60008B6")]
		[Address(RVA = "0xDF9318", Offset = "0xDF9318", VA = "0xDF9318", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60008B7")]
		[Address(RVA = "0xDF9578", Offset = "0xDF9578", VA = "0xDF9578")]
		internal int GetLocationDistance(int sourceIdx, int line, int col)
		{
			return default(int);
		}

		[Token(Token = "0x60008B8")]
		[Address(RVA = "0xDF968C", Offset = "0xDF968C", VA = "0xDF968C")]
		public bool IncludesLocation(int sourceIdx, int line, int col)
		{
			return default(bool);
		}

		[Token(Token = "0x60008B9")]
		[Address(RVA = "0xDF9704", Offset = "0xDF9704", VA = "0xDF9704")]
		public SourceRef SetNoBreakPoint()
		{
			return null;
		}

		[Token(Token = "0x60008BA")]
		[Address(RVA = "0xDF9710", Offset = "0xDF9710", VA = "0xDF9710")]
		public string FormatLocation(Script script, bool forceClassicFormat = false)
		{
			return null;
		}
	}
	[Token(Token = "0x2000131")]
	public class WatchItem
	{
		[Token(Token = "0x17000151")]
		public int Address
		{
			[Token(Token = "0x60008BB")]
			[Address(RVA = "0xDF9C14", Offset = "0xDF9C14", VA = "0xDF9C14")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60008BC")]
			[Address(RVA = "0xDF9C1C", Offset = "0xDF9C1C", VA = "0xDF9C1C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000152")]
		public int BasePtr
		{
			[Token(Token = "0x60008BD")]
			[Address(RVA = "0xDF9C24", Offset = "0xDF9C24", VA = "0xDF9C24")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60008BE")]
			[Address(RVA = "0xDF9C2C", Offset = "0xDF9C2C", VA = "0xDF9C2C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000153")]
		public int RetAddress
		{
			[Token(Token = "0x60008BF")]
			[Address(RVA = "0xDF9C34", Offset = "0xDF9C34", VA = "0xDF9C34")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60008C0")]
			[Address(RVA = "0xDF9C3C", Offset = "0xDF9C3C", VA = "0xDF9C3C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000154")]
		public string Name
		{
			[Token(Token = "0x60008C1")]
			[Address(RVA = "0xDF9C44", Offset = "0xDF9C44", VA = "0xDF9C44")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60008C2")]
			[Address(RVA = "0xDF9C4C", Offset = "0xDF9C4C", VA = "0xDF9C4C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000155")]
		public DynValue Value
		{
			[Token(Token = "0x60008C3")]
			[Address(RVA = "0xDF9C54", Offset = "0xDF9C54", VA = "0xDF9C54")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60008C4")]
			[Address(RVA = "0xDF9C5C", Offset = "0xDF9C5C", VA = "0xDF9C5C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000156")]
		public SymbolRef LValue
		{
			[Token(Token = "0x60008C5")]
			[Address(RVA = "0xDF9C64", Offset = "0xDF9C64", VA = "0xDF9C64")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60008C6")]
			[Address(RVA = "0xDF9C6C", Offset = "0xDF9C6C", VA = "0xDF9C6C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000157")]
		public bool IsError
		{
			[Token(Token = "0x60008C7")]
			[Address(RVA = "0xDF9C74", Offset = "0xDF9C74", VA = "0xDF9C74")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008C8")]
			[Address(RVA = "0xDF9C7C", Offset = "0xDF9C7C", VA = "0xDF9C7C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000158")]
		public SourceRef Location
		{
			[Token(Token = "0x60008C9")]
			[Address(RVA = "0xDF9C88", Offset = "0xDF9C88", VA = "0xDF9C88")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60008CA")]
			[Address(RVA = "0xDF9C90", Offset = "0xDF9C90", VA = "0xDF9C90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x60008CB")]
		[Address(RVA = "0xDF9C98", Offset = "0xDF9C98", VA = "0xDF9C98", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60008CC")]
		[Address(RVA = "0xDF6580", Offset = "0xDF6580", VA = "0xDF6580")]
		public WatchItem()
		{
		}
	}
	[Token(Token = "0x2000132")]
	public enum WatchType
	{
		[Token(Token = "0x400042D")]
		Watches,
		[Token(Token = "0x400042E")]
		VStack,
		[Token(Token = "0x400042F")]
		CallStack,
		[Token(Token = "0x4000430")]
		Coroutines,
		[Token(Token = "0x4000431")]
		Locals,
		[Token(Token = "0x4000432")]
		Threads,
		[Token(Token = "0x4000433")]
		MaxValue
	}
	[Token(Token = "0x2000133")]
	internal static class NamespaceDoc
	{
	}
}
namespace MoonSharp.Interpreter.DataStructs
{
	[Token(Token = "0x2000134")]
	internal class FastStack<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable
	{
		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T[] m_Storage;

		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int m_HeadIdx;

		[Token(Token = "0x17000159")]
		public T this[int index]
		{
			[Token(Token = "0x60008CE")]
			get
			{
				return (T)null;
			}
			[Token(Token = "0x60008CF")]
			set
			{
			}
		}

		[Token(Token = "0x1700015A")]
		public int Count
		{
			[Token(Token = "0x60008DA")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700015B")]
		private T System.Collections.Generic.IList<T>.Item
		{
			[Token(Token = "0x60008DE")]
			get
			{
				return (T)null;
			}
			[Token(Token = "0x60008DF")]
			set
			{
			}
		}

		[Token(Token = "0x1700015C")]
		private int System.Collections.Generic.ICollection<T>.Count
		{
			[Token(Token = "0x60008E4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700015D")]
		private bool System.Collections.Generic.ICollection<T>.IsReadOnly
		{
			[Token(Token = "0x60008E5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60008CD")]
		public FastStack(int maxCapacity)
		{
		}

		[Token(Token = "0x60008D0")]
		public T Push(T item)
		{
			return (T)null;
		}

		[Token(Token = "0x60008D1")]
		public void Expand(int size)
		{
		}

		[Token(Token = "0x60008D2")]
		private void Zero(int from, int to)
		{
		}

		[Token(Token = "0x60008D3")]
		private void Zero(int index)
		{
		}

		[Token(Token = "0x60008D4")]
		public T Peek(int idxofs = 0)
		{
			return (T)null;
		}

		[Token(Token = "0x60008D5")]
		public void Set(int idxofs, T item)
		{
		}

		[Token(Token = "0x60008D6")]
		public void CropAtCount(int p)
		{
		}

		[Token(Token = "0x60008D7")]
		public void RemoveLast(int cnt = 1)
		{
		}

		[Token(Token = "0x60008D8")]
		public T Pop()
		{
			return (T)null;
		}

		[Token(Token = "0x60008D9")]
		public void Clear()
		{
		}

		[Token(Token = "0x60008DB")]
		private int System.Collections.Generic.IList<T>.IndexOf(T item)
		{
			return default(int);
		}

		[Token(Token = "0x60008DC")]
		private void System.Collections.Generic.IList<T>.Insert(int index, T item)
		{
		}

		[Token(Token = "0x60008DD")]
		private void System.Collections.Generic.IList<T>.RemoveAt(int index)
		{
		}

		[Token(Token = "0x60008E0")]
		private void System.Collections.Generic.ICollection<T>.Add(T item)
		{
		}

		[Token(Token = "0x60008E1")]
		private void System.Collections.Generic.ICollection<T>.Clear()
		{
		}

		[Token(Token = "0x60008E2")]
		private bool System.Collections.Generic.ICollection<T>.Contains(T item)
		{
			return default(bool);
		}

		[Token(Token = "0x60008E3")]
		private void System.Collections.Generic.ICollection<T>.CopyTo(T[] array, int arrayIndex)
		{
		}

		[Token(Token = "0x60008E6")]
		private bool System.Collections.Generic.ICollection<T>.Remove(T item)
		{
			return default(bool);
		}

		[Token(Token = "0x60008E7")]
		private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60008E8")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
	[Token(Token = "0x2000135")]
	internal class FastStackDynamic<T> : List<T>
	{
		[Token(Token = "0x60008E9")]
		public FastStackDynamic(int startingCapacity)
		{
		}

		[Token(Token = "0x60008EA")]
		public void Set(int idxofs, T item)
		{
		}

		[Token(Token = "0x60008EB")]
		public T Push(T item)
		{
			return (T)null;
		}

		[Token(Token = "0x60008EC")]
		public void Expand(int size)
		{
		}

		[Token(Token = "0x60008ED")]
		public void Zero(int index)
		{
		}

		[Token(Token = "0x60008EE")]
		public T Peek(int idxofs = 0)
		{
			return (T)null;
		}

		[Token(Token = "0x60008EF")]
		public void CropAtCount(int p)
		{
		}

		[Token(Token = "0x60008F0")]
		public void RemoveLast(int cnt = 1)
		{
		}

		[Token(Token = "0x60008F1")]
		public T Pop()
		{
			return (T)null;
		}
	}
	[Token(Token = "0x2000136")]
	internal class LinkedListIndex<TKey, TValue>
	{
		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private LinkedList<TValue> m_LinkedList;

		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Dictionary<TKey, LinkedListNode<TValue>> m_Map;

		[Token(Token = "0x60008F2")]
		public LinkedListIndex(LinkedList<TValue> linkedList)
		{
		}

		[Token(Token = "0x60008F3")]
		public LinkedListNode<TValue> Find(TKey key)
		{
			return null;
		}

		[Token(Token = "0x60008F4")]
		public TValue Set(TKey key, TValue value)
		{
			return (TValue)null;
		}

		[Token(Token = "0x60008F5")]
		public void Add(TKey key, TValue value)
		{
		}

		[Token(Token = "0x60008F6")]
		public bool Remove(TKey key)
		{
			return default(bool);
		}

		[Token(Token = "0x60008F7")]
		public bool ContainsKey(TKey key)
		{
			return default(bool);
		}

		[Token(Token = "0x60008F8")]
		public void Clear()
		{
		}
	}
	[Token(Token = "0x2000137")]
	internal class MultiDictionary<K, V>
	{
		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Dictionary<K, List<V>> m_Map;

		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private V[] m_DefaultRet;

		[Token(Token = "0x1700015E")]
		public IEnumerable<K> Keys
		{
			[Token(Token = "0x60008FE")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008F9")]
		public MultiDictionary()
		{
		}

		[Token(Token = "0x60008FA")]
		public MultiDictionary(IEqualityComparer<K> eqComparer)
		{
		}

		[Token(Token = "0x60008FB")]
		public bool Add(K key, V value)
		{
			return default(bool);
		}

		[Token(Token = "0x60008FC")]
		public IEnumerable<V> Find(K key)
		{
			return null;
		}

		[Token(Token = "0x60008FD")]
		public bool ContainsKey(K key)
		{
			return default(bool);
		}

		[Token(Token = "0x60008FF")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000900")]
		public void Remove(K key)
		{
		}

		[Token(Token = "0x6000901")]
		public bool RemoveValue(K key, V value)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000138")]
	internal class ReferenceEqualityComparer : IEqualityComparer<object>
	{
		[Token(Token = "0x6000902")]
		[Address(RVA = "0xDF9EEC", Offset = "0xDF9EEC", VA = "0xDF9EEC", Slot = "4")]
		private bool System.Collections.Generic.IEqualityComparer<System.Object>.Equals(object x, object y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000903")]
		[Address(RVA = "0xDF9EF8", Offset = "0xDF9EF8", VA = "0xDF9EF8", Slot = "5")]
		private int System.Collections.Generic.IEqualityComparer<System.Object>.GetHashCode(object obj)
		{
			return default(int);
		}

		[Token(Token = "0x6000904")]
		[Address(RVA = "0xDF9F18", Offset = "0xDF9F18", VA = "0xDF9F18")]
		public ReferenceEqualityComparer()
		{
		}
	}
	[Token(Token = "0x2000139")]
	internal class Slice<T> : IEnumerable<T>, IEnumerable, IList<T>, ICollection<T>
	{
		[Token(Token = "0x200013A")]
		[CompilerGenerated]
		private sealed class <GetEnumerator>d__15 : IEnumerator<T>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400043E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <>1__state;

			[Token(Token = "0x400043F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private T <>2__current;

			[Token(Token = "0x4000440")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Slice<T> <>4__this;

			[Token(Token = "0x4000441")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <i>5__2;

			[Token(Token = "0x17000164")]
			private T System.Collections.Generic.IEnumerator<T>.Current
			{
				[Token(Token = "0x600091C")]
				[DebuggerHidden]
				get
				{
					return (T)null;
				}
			}

			[Token(Token = "0x17000165")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600091E")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000919")]
			[DebuggerHidden]
			public <GetEnumerator>d__15(int <>1__state)
			{
			}

			[Token(Token = "0x600091A")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600091B")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600091D")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200013B")]
		[CompilerGenerated]
		private sealed class <System-Collections-IEnumerable-GetEnumerator>d__16 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000442")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <>1__state;

			[Token(Token = "0x4000443")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private object <>2__current;

			[Token(Token = "0x4000444")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Slice<T> <>4__this;

			[Token(Token = "0x4000445")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <i>5__2;

			[Token(Token = "0x17000166")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000922")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000167")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000924")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600091F")]
			[DebuggerHidden]
			public <System-Collections-IEnumerable-GetEnumerator>d__16(int <>1__state)
			{
			}

			[Token(Token = "0x6000920")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000921")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000923")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private IList<T> m_SourceList;

		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int m_From;

		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int m_Length;

		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool m_Reversed;

		[Token(Token = "0x1700015F")]
		public T this[int index]
		{
			[Token(Token = "0x6000906")]
			get
			{
				return (T)null;
			}
			[Token(Token = "0x6000907")]
			set
			{
			}
		}

		[Token(Token = "0x17000160")]
		public int From
		{
			[Token(Token = "0x6000908")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000161")]
		public int Count
		{
			[Token(Token = "0x6000909")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000162")]
		public bool Reversed
		{
			[Token(Token = "0x600090A")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000163")]
		public bool IsReadOnly
		{
			[Token(Token = "0x6000917")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000905")]
		public Slice(IList<T> list, int from, int length, bool reversed)
		{
		}

		[Token(Token = "0x600090B")]
		private int CalcRealIndex(int index)
		{
			return default(int);
		}

		[Token(Token = "0x600090C")]
		[IteratorStateMachine(typeof(Slice<>.<GetEnumerator>d__15))]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x600090D")]
		[IteratorStateMachine(typeof(Slice<>.<System-Collections-IEnumerable-GetEnumerator>d__16))]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x600090E")]
		public T[] ToArray()
		{
			return null;
		}

		[Token(Token = "0x600090F")]
		public List<T> ToList()
		{
			return null;
		}

		[Token(Token = "0x6000910")]
		public int IndexOf(T item)
		{
			return default(int);
		}

		[Token(Token = "0x6000911")]
		public void Insert(int index, T item)
		{
		}

		[Token(Token = "0x6000912")]
		public void RemoveAt(int index)
		{
		}

		[Token(Token = "0x6000913")]
		public void Add(T item)
		{
		}

		[Token(Token = "0x6000914")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000915")]
		public bool Contains(T item)
		{
			return default(bool);
		}

		[Token(Token = "0x6000916")]
		public void CopyTo(T[] array, int arrayIndex)
		{
		}

		[Token(Token = "0x6000918")]
		public bool Remove(T item)
		{
			return default(bool);
		}
	}
}
namespace MoonSharp.Interpreter.CoreLib
{
	[Token(Token = "0x200013C")]
	[MoonSharpModule]
	public class BasicModule
	{
		[Token(Token = "0x6000925")]
		[Address(RVA = "0xDF9F20", Offset = "0xDF9F20", VA = "0xDF9F20")]
		[MoonSharpModuleMethod]
		public static DynValue type(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000926")]
		[Address(RVA = "0xDF9FEC", Offset = "0xDF9FEC", VA = "0xDF9FEC")]
		[MoonSharpModuleMethod]
		public static DynValue assert(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000927")]
		[Address(RVA = "0xDFA158", Offset = "0xDFA158", VA = "0xDFA158")]
		[MoonSharpModuleMethod]
		public static DynValue collectgarbage(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000928")]
		[Address(RVA = "0xDFA290", Offset = "0xDFA290", VA = "0xDFA290")]
		[MoonSharpModuleMethod]
		public static DynValue error(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000929")]
		[Address(RVA = "0xDFA324", Offset = "0xDFA324", VA = "0xDFA324")]
		[MoonSharpModuleMethod]
		public static DynValue tostring(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x600092A")]
		[Address(RVA = "0xDFA550", Offset = "0xDFA550", VA = "0xDFA550")]
		private static DynValue __tostring_continuation(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x600092B")]
		[Address(RVA = "0xDFA5F0", Offset = "0xDFA5F0", VA = "0xDFA5F0")]
		[MoonSharpModuleMethod]
		public static DynValue select(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x600092C")]
		[Address(RVA = "0xDFA968", Offset = "0xDFA968", VA = "0xDFA968")]
		[MoonSharpModuleMethod]
		public static DynValue tonumber(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x600092D")]
		[Address(RVA = "0xDFAD94", Offset = "0xDFAD94", VA = "0xDFAD94")]
		[MoonSharpModuleMethod]
		public static DynValue print(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x600092E")]
		[Address(RVA = "0xDFAF38", Offset = "0xDFAF38", VA = "0xDFAF38")]
		public BasicModule()
		{
		}
	}
	[Token(Token = "0x200013D")]
	[MoonSharpModule(Namespace = "bit32")]
	public class Bit32Module
	{
		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly uint[] MASKS;

		[Token(Token = "0x600092F")]
		[Address(RVA = "0xDFAF40", Offset = "0xDFAF40", VA = "0xDFAF40")]
		private static uint ToUInt32(DynValue v)
		{
			return default(uint);
		}

		[Token(Token = "0x6000930")]
		[Address(RVA = "0xDFAFD8", Offset = "0xDFAFD8", VA = "0xDFAFD8")]
		private static int ToInt32(DynValue v)
		{
			return default(int);
		}

		[Token(Token = "0x6000931")]
		[Address(RVA = "0xDFB078", Offset = "0xDFB078", VA = "0xDFB078")]
		private static uint NBitMask(int bits)
		{
			return default(uint);
		}

		[Token(Token = "0x6000932")]
		[Address(RVA = "0xDFB124", Offset = "0xDFB124", VA = "0xDFB124")]
		public static uint Bitwise(string funcName, CallbackArguments args, Func<uint, uint, uint> accumFunc)
		{
			return default(uint);
		}

		[Token(Token = "0x6000933")]
		[Address(RVA = "0xDFB244", Offset = "0xDFB244", VA = "0xDFB244")]
		[MoonSharpModuleMethod]
		public static DynValue extract(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000934")]
		[Address(RVA = "0xDFB5F8", Offset = "0xDFB5F8", VA = "0xDFB5F8")]
		[MoonSharpModuleMethod]
		public static DynValue replace(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000935")]
		[Address(RVA = "0xDFB3F0", Offset = "0xDFB3F0", VA = "0xDFB3F0")]
		private static void ValidatePosWidth(string func, int argPos, int pos, int width)
		{
		}

		[Token(Token = "0x6000936")]
		[Address(RVA = "0xDFB7CC", Offset = "0xDFB7CC", VA = "0xDFB7CC")]
		[MoonSharpModuleMethod]
		public static DynValue arshift(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000937")]
		[Address(RVA = "0xDFB8E4", Offset = "0xDFB8E4", VA = "0xDFB8E4")]
		[MoonSharpModuleMethod]
		public static DynValue rshift(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000938")]
		[Address(RVA = "0xDFB9FC", Offset = "0xDFB9FC", VA = "0xDFB9FC")]
		[MoonSharpModuleMethod]
		public static DynValue lshift(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000939")]
		[Address(RVA = "0xDFBB14", Offset = "0xDFBB14", VA = "0xDFBB14")]
		[MoonSharpModuleMethod]
		public static DynValue band(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x600093A")]
		[Address(RVA = "0xDFBC6C", Offset = "0xDFBC6C", VA = "0xDFBC6C")]
		[MoonSharpModuleMethod]
		public static DynValue btest(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x600093B")]
		[Address(RVA = "0xDFBDC8", Offset = "0xDFBDC8", VA = "0xDFBDC8")]
		[MoonSharpModuleMethod]
		public static DynValue bor(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x600093C")]
		[Address(RVA = "0xDFBF20", Offset = "0xDFBF20", VA = "0xDFBF20")]
		[MoonSharpModuleMethod]
		public static DynValue bnot(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x600093D")]
		[Address(RVA = "0xDFBFF0", Offset = "0xDFBFF0", VA = "0xDFBFF0")]
		[MoonSharpModuleMethod]
		public static DynValue bxor(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x600093E")]
		[Address(RVA = "0xDFC148", Offset = "0xDFC148", VA = "0xDFC148")]
		[MoonSharpModuleMethod]
		public static DynValue lrotate(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x600093F")]
		[Address(RVA = "0xDFC250", Offset = "0xDFC250", VA = "0xDFC250")]
		[MoonSharpModuleMethod]
		public static DynValue rrotate(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000940")]
		[Address(RVA = "0xDFC358", Offset = "0xDFC358", VA = "0xDFC358")]
		public Bit32Module()
		{
		}
	}
	[Token(Token = "0x200013F")]
	[MoonSharpModule(Namespace = "coroutine")]
	public class CoroutineModule
	{
		[Token(Token = "0x6000948")]
		[Address(RVA = "0xDFC480", Offset = "0xDFC480", VA = "0xDFC480")]
		[MoonSharpModuleMethod]
		public static DynValue create(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000949")]
		[Address(RVA = "0xDFC55C", Offset = "0xDFC55C", VA = "0xDFC55C")]
		[MoonSharpModuleMethod]
		public static DynValue wrap(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x600094A")]
		[Address(RVA = "0xDFC6B0", Offset = "0xDFC6B0", VA = "0xDFC6B0")]
		public static DynValue __wrap_wrapper(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x600094B")]
		[Address(RVA = "0xDFC750", Offset = "0xDFC750", VA = "0xDFC750")]
		[MoonSharpModuleMethod]
		public static DynValue resume(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x600094C")]
		[Address(RVA = "0xDFCCBC", Offset = "0xDFCCBC", VA = "0xDFCCBC")]
		[MoonSharpModuleMethod]
		public static DynValue yield(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x600094D")]
		[Address(RVA = "0xDFCD34", Offset = "0xDFCD34", VA = "0xDFCD34")]
		[MoonSharpModuleMethod]
		public static DynValue running(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x600094E")]
		[Address(RVA = "0xDFCE64", Offset = "0xDFCE64", VA = "0xDFCE64")]
		[MoonSharpModuleMethod]
		public static DynValue status(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x600094F")]
		[Address(RVA = "0xDFD0A4", Offset = "0xDFD0A4", VA = "0xDFD0A4")]
		public CoroutineModule()
		{
		}
	}
	[Token(Token = "0x2000140")]
	[MoonSharpModule(Namespace = "debug")]
	public class DebugModule
	{
		[Token(Token = "0x6000950")]
		[Address(RVA = "0xDFD0AC", Offset = "0xDFD0AC", VA = "0xDFD0AC")]
		[MoonSharpModuleMethod]
		public static DynValue debug(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000951")]
		[Address(RVA = "0xDFD3D8", Offset = "0xDFD3D8", VA = "0xDFD3D8")]
		[MoonSharpModuleMethod]
		public static DynValue getuservalue(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000952")]
		[Address(RVA = "0xDFD4A0", Offset = "0xDFD4A0", VA = "0xDFD4A0")]
		[MoonSharpModuleMethod]
		public static DynValue setuservalue(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000953")]
		[Address(RVA = "0xDFD544", Offset = "0xDFD544", VA = "0xDFD544")]
		[MoonSharpModuleMethod]
		public static DynValue getregistry(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000954")]
		[Address(RVA = "0xDFD5BC", Offset = "0xDFD5BC", VA = "0xDFD5BC")]
		[MoonSharpModuleMethod]
		public static DynValue getmetatable(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000955")]
		[Address(RVA = "0xDFD6F4", Offset = "0xDFD6F4", VA = "0xDFD6F4")]
		[MoonSharpModuleMethod]
		public static DynValue setmetatable(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000956")]
		[Address(RVA = "0xDFD8B0", Offset = "0xDFD8B0", VA = "0xDFD8B0")]
		[MoonSharpModuleMethod]
		public static DynValue getupvalue(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000957")]
		[Address(RVA = "0xDFDB10", Offset = "0xDFDB10", VA = "0xDFDB10")]
		[MoonSharpModuleMethod]
		public static DynValue upvalueid(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000958")]
		[Address(RVA = "0xDFDCC4", Offset = "0xDFDCC4", VA = "0xDFDCC4")]
		[MoonSharpModuleMethod]
		public static DynValue setupvalue(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000959")]
		[Address(RVA = "0xDFDEB8", Offset = "0xDFDEB8", VA = "0xDFDEB8")]
		[MoonSharpModuleMethod]
		public static DynValue upvaluejoin(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x600095A")]
		[Address(RVA = "0xDFE108", Offset = "0xDFE108", VA = "0xDFE108")]
		[MoonSharpModuleMethod]
		public static DynValue traceback(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x600095B")]
		[Address(RVA = "0xDFE4AC", Offset = "0xDFE4AC", VA = "0xDFE4AC")]
		public DebugModule()
		{
		}
	}
	[Token(Token = "0x2000141")]
	[MoonSharpModule(Namespace = "dynamic")]
	public class DynamicModule
	{
		[Token(Token = "0x2000142")]
		private class DynamicExprWrapper
		{
			[Token(Token = "0x400044C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public DynamicExpression Expr;

			[Token(Token = "0x6000960")]
			[Address(RVA = "0xDFE9BC", Offset = "0xDFE9BC", VA = "0xDFE9BC")]
			public DynamicExprWrapper()
			{
			}
		}

		[Token(Token = "0x600095C")]
		[Address(RVA = "0xDFE4B4", Offset = "0xDFE4B4", VA = "0xDFE4B4")]
		public static void MoonSharpInit(Table globalTable, Table stringTable)
		{
		}

		[Token(Token = "0x600095D")]
		[Address(RVA = "0xDFE520", Offset = "0xDFE520", VA = "0xDFE520")]
		[MoonSharpModuleMethod]
		public static DynValue eval(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x600095E")]
		[Address(RVA = "0xDFE7CC", Offset = "0xDFE7CC", VA = "0xDFE7CC")]
		[MoonSharpModuleMethod]
		public static DynValue prepare(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x600095F")]
		[Address(RVA = "0xDFE9C4", Offset = "0xDFE9C4", VA = "0xDFE9C4")]
		public DynamicModule()
		{
		}
	}
	[Token(Token = "0x2000143")]
	[MoonSharpModule]
	public class ErrorHandlingModule
	{
		[Token(Token = "0x6000961")]
		[Address(RVA = "0xDFE9CC", Offset = "0xDFE9CC", VA = "0xDFE9CC")]
		[MoonSharpModuleMethod]
		public static DynValue pcall(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000962")]
		[Address(RVA = "0xDFEA28", Offset = "0xDFEA28", VA = "0xDFEA28")]
		private static DynValue SetErrorHandlerStrategy(string funcName, ScriptExecutionContext executionContext, CallbackArguments args, DynValue handlerBeforeUnwind)
		{
			return null;
		}

		[Token(Token = "0x6000963")]
		[Address(RVA = "0xDFF370", Offset = "0xDFF370", VA = "0xDFF370")]
		private static DynValue MakeReturnTuple(bool retstatus, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000964")]
		[Address(RVA = "0xDFF4BC", Offset = "0xDFF4BC", VA = "0xDFF4BC")]
		public static DynValue pcall_continuation(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000965")]
		[Address(RVA = "0xDFF4C4", Offset = "0xDFF4C4", VA = "0xDFF4C4")]
		public static DynValue pcall_onerror(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000966")]
		[Address(RVA = "0xDFF4CC", Offset = "0xDFF4CC", VA = "0xDFF4CC")]
		[MoonSharpModuleMethod]
		public static DynValue xpcall(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000967")]
		[Address(RVA = "0xDFF6DC", Offset = "0xDFF6DC", VA = "0xDFF6DC")]
		public ErrorHandlingModule()
		{
		}
	}
	[Token(Token = "0x2000144")]
	[MoonSharpModule(Namespace = "io")]
	public class IoModule
	{
		[Token(Token = "0x6000968")]
		[Address(RVA = "0xDFF6E4", Offset = "0xDFF6E4", VA = "0xDFF6E4")]
		public static void MoonSharpInit(Table globalTable, Table ioTable)
		{
		}

		[Token(Token = "0x6000969")]
		[Address(RVA = "0xDFFB0C", Offset = "0xDFFB0C", VA = "0xDFFB0C")]
		private static DynValue __index_callback(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x600096A")]
		[Address(RVA = "0xDFFC88", Offset = "0xDFFC88", VA = "0xDFFC88")]
		private static DynValue GetStandardFile(Script S, StandardFileType file)
		{
			return null;
		}

		[Token(Token = "0x600096B")]
		[Address(RVA = "0xDFF908", Offset = "0xDFF908", VA = "0xDFF908")]
		private static void SetStandardFile(Script S, StandardFileType file, Stream optionsStream)
		{
		}

		[Token(Token = "0x600096C")]
		[Address(RVA = "0xDFFD38", Offset = "0xDFFD38", VA = "0xDFFD38")]
		private static FileUserDataBase GetDefaultFile(ScriptExecutionContext executionContext, StandardFileType file)
		{
			return null;
		}

		[Token(Token = "0x600096D")]
		[Address(RVA = "0xDFFEC0", Offset = "0xDFFEC0", VA = "0xDFFEC0")]
		private static void SetDefaultFile(ScriptExecutionContext executionContext, StandardFileType file, FileUserDataBase fileHandle)
		{
		}

		[Token(Token = "0x600096E")]
		[Address(RVA = "0xDFFEF4", Offset = "0xDFFEF4", VA = "0xDFFEF4")]
		internal static void SetDefaultFile(Script script, StandardFileType file, FileUserDataBase fileHandle)
		{
		}

		[Token(Token = "0x600096F")]
		[Address(RVA = "0xDFFFEC", Offset = "0xDFFFEC", VA = "0xDFFFEC")]
		public static void SetDefaultFile(Script script, StandardFileType file, Stream stream)
		{
		}

		[Token(Token = "0x6000970")]
		[Address(RVA = "0xE00034", Offset = "0xE00034", VA = "0xE00034")]
		[MoonSharpModuleMethod]
		public static DynValue close(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000971")]
		[Address(RVA = "0xE000CC", Offset = "0xE000CC", VA = "0xE000CC")]
		[MoonSharpModuleMethod]
		public static DynValue flush(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000972")]
		[Address(RVA = "0xE001C4", Offset = "0xE001C4", VA = "0xE001C4")]
		[MoonSharpModuleMethod]
		public static DynValue input(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000973")]
		[Address(RVA = "0xE003AC", Offset = "0xE003AC", VA = "0xE003AC")]
		[MoonSharpModuleMethod]
		public static DynValue output(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000974")]
		[Address(RVA = "0xE001CC", Offset = "0xE001CC", VA = "0xE001CC")]
		private static DynValue HandleDefaultStreamSetter(ScriptExecutionContext executionContext, CallbackArguments args, StandardFileType defaultFiles)
		{
			return null;
		}

		[Token(Token = "0x6000975")]
		[Address(RVA = "0xE003B4", Offset = "0xE003B4", VA = "0xE003B4")]
		private static Encoding GetUTF8Encoding()
		{
			return null;
		}

		[Token(Token = "0x6000976")]
		[Address(RVA = "0xE004B0", Offset = "0xE004B0", VA = "0xE004B0")]
		[MoonSharpModuleMethod]
		public static DynValue lines(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000977")]
		[Address(RVA = "0xE00D70", Offset = "0xE00D70", VA = "0xE00D70")]
		[MoonSharpModuleMethod]
		public static DynValue open(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000978")]
		[Address(RVA = "0xE00CC4", Offset = "0xE00CC4", VA = "0xE00CC4")]
		public static string IoExceptionToLuaMessage(Exception ex, string filename)
		{
			return null;
		}

		[Token(Token = "0x6000979")]
		[Address(RVA = "0xE01368", Offset = "0xE01368", VA = "0xE01368")]
		[MoonSharpModuleMethod]
		public static DynValue type(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x600097A")]
		[Address(RVA = "0xE014E8", Offset = "0xE014E8", VA = "0xE014E8")]
		[MoonSharpModuleMethod]
		public static DynValue read(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x600097B")]
		[Address(RVA = "0xE01520", Offset = "0xE01520", VA = "0xE01520")]
		[MoonSharpModuleMethod]
		public static DynValue write(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x600097C")]
		[Address(RVA = "0xE01558", Offset = "0xE01558", VA = "0xE01558")]
		[MoonSharpModuleMethod]
		public static DynValue tmpfile(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x600097D")]
		[Address(RVA = "0xE00414", Offset = "0xE00414", VA = "0xE00414")]
		private static FileUserDataBase Open(ScriptExecutionContext executionContext, string filename, Encoding encoding, string mode)
		{
			return null;
		}

		[Token(Token = "0x600097E")]
		[Address(RVA = "0xE016D0", Offset = "0xE016D0", VA = "0xE016D0")]
		public IoModule()
		{
		}
	}
	[Token(Token = "0x2000146")]
	[MoonSharpModule(Namespace = "json")]
	public class JsonModule
	{
		[Token(Token = "0x6000982")]
		[Address(RVA = "0xE0174C", Offset = "0xE0174C", VA = "0xE0174C")]
		[MoonSharpModuleMethod]
		public static DynValue parse(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000983")]
		[Address(RVA = "0xE018E8", Offset = "0xE018E8", VA = "0xE018E8")]
		[MoonSharpModuleMethod]
		public static DynValue serialize(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000984")]
		[Address(RVA = "0xE01A58", Offset = "0xE01A58", VA = "0xE01A58")]
		[MoonSharpModuleMethod]
		public static DynValue isnull(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000985")]
		[Address(RVA = "0xE01AF4", Offset = "0xE01AF4", VA = "0xE01AF4")]
		[MoonSharpModuleMethod]
		public static DynValue @null(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000986")]
		[Address(RVA = "0xE01AFC", Offset = "0xE01AFC", VA = "0xE01AFC")]
		public JsonModule()
		{
		}
	}
	[Token(Token = "0x2000147")]
	[MoonSharpModule]
	public class LoadModule
	{
		[Token(Token = "0x400044F")]
		[MoonSharpModuleMethod]
		public const string require = "\nfunction(modulename)\n\tif (package == nil) then package = { }; end\n\tif (package.loaded == nil) then package.loaded = { }; end\n\n\tlocal m = package.loaded[modulename];\n\n\tif (m ~= nil) then\n\t\treturn m;\n\tend\n\n\tlocal func = __require_clr_impl(modulename);\n\n\tlocal res = func(modulename);\n\n\tif (res == nil) then\n\t\tres = true;\n\tend\n\n\tpackage.loaded[modulename] = res;\n\n\treturn res;\nend";

		[Token(Token = "0x6000987")]
		[Address(RVA = "0xE01B04", Offset = "0xE01B04", VA = "0xE01B04")]
		public static void MoonSharpInit(Table globalTable, Table ioTable)
		{
		}

		[Token(Token = "0x6000988")]
		[Address(RVA = "0xE01CE8", Offset = "0xE01CE8", VA = "0xE01CE8")]
		[MoonSharpModuleMethod]
		public static DynValue load(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000989")]
		[Address(RVA = "0xE022A4", Offset = "0xE022A4", VA = "0xE022A4")]
		[MoonSharpModuleMethod]
		public static DynValue loadsafe(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x600098A")]
		[Address(RVA = "0xE01CF0", Offset = "0xE01CF0", VA = "0xE01CF0")]
		public static DynValue load_impl(ScriptExecutionContext executionContext, CallbackArguments args, Table defaultEnv)
		{
			return null;
		}

		[Token(Token = "0x600098B")]
		[Address(RVA = "0xE0233C", Offset = "0xE0233C", VA = "0xE0233C")]
		[MoonSharpModuleMethod]
		public static DynValue loadfile(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x600098C")]
		[Address(RVA = "0xE02624", Offset = "0xE02624", VA = "0xE02624")]
		[MoonSharpModuleMethod]
		public static DynValue loadfilesafe(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x600098D")]
		[Address(RVA = "0xE02344", Offset = "0xE02344", VA = "0xE02344")]
		private static DynValue loadfile_impl(ScriptExecutionContext executionContext, CallbackArguments args, Table defaultEnv)
		{
			return null;
		}

		[Token(Token = "0x600098E")]
		[Address(RVA = "0xE022D0", Offset = "0xE022D0", VA = "0xE022D0")]
		private static Table GetSafeDefaultEnv(ScriptExecutionContext executionContext)
		{
			return null;
		}

		[Token(Token = "0x600098F")]
		[Address(RVA = "0xE02650", Offset = "0xE02650", VA = "0xE02650")]
		[MoonSharpModuleMethod]
		public static DynValue dofile(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000990")]
		[Address(RVA = "0xE02860", Offset = "0xE02860", VA = "0xE02860")]
		[MoonSharpModuleMethod]
		public static DynValue __require_clr_impl(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000991")]
		[Address(RVA = "0xE028FC", Offset = "0xE028FC", VA = "0xE028FC")]
		public LoadModule()
		{
		}
	}
	[Token(Token = "0x2000148")]
	[MoonSharpModule(Namespace = "math")]
	public class MathModule
	{
		[Token(Token = "0x4000450")]
		[MoonSharpModuleConstant]
		public const double pi = Math.PI;

		[Token(Token = "0x4000451")]
		[MoonSharpModuleConstant]
		public const double huge = double.MaxValue;

		[Token(Token = "0x6000992")]
		[Address(RVA = "0xE02904", Offset = "0xE02904", VA = "0xE02904")]
		private static Random GetRandom(Script s)
		{
			return null;
		}

		[Token(Token = "0x6000993")]
		[Address(RVA = "0xE029C8", Offset = "0xE029C8", VA = "0xE029C8")]
		private static void SetRandom(Script s, Random random)
		{
		}

		[Token(Token = "0x6000994")]
		[Address(RVA = "0xE02AA4", Offset = "0xE02AA4", VA = "0xE02AA4")]
		public static void MoonSharpInit(Table globalTable, Table ioTable)
		{
		}

		[Token(Token = "0x6000995")]
		[Address(RVA = "0xE02B10", Offset = "0xE02B10", VA = "0xE02B10")]
		private static DynValue exec1(CallbackArguments args, string funcName, Func<double, double> func)
		{
			return null;
		}

		[Token(Token = "0x6000996")]
		[Address(RVA = "0xE02BC4", Offset = "0xE02BC4", VA = "0xE02BC4")]
		private static DynValue exec2(CallbackArguments args, string funcName, Func<double, double, double> func)
		{
			return null;
		}

		[Token(Token = "0x6000997")]
		[Address(RVA = "0xE02CA0", Offset = "0xE02CA0", VA = "0xE02CA0")]
		private static DynValue exec2n(CallbackArguments args, string funcName, double defVal, Func<double, double, double> func)
		{
			return null;
		}

		[Token(Token = "0x6000998")]
		[Address(RVA = "0xE02D9C", Offset = "0xE02D9C", VA = "0xE02D9C")]
		private static DynValue execaccum(CallbackArguments args, string funcName, Func<double, double, double> func)
		{
			return null;
		}

		[Token(Token = "0x6000999")]
		[Address(RVA = "0xE02F20", Offset = "0xE02F20", VA = "0xE02F20")]
		[MoonSharpModuleMethod]
		public static DynValue abs(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x600099A")]
		[Address(RVA = "0xE0301C", Offset = "0xE0301C", VA = "0xE0301C")]
		[MoonSharpModuleMethod]
		public static DynValue acos(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x600099B")]
		[Address(RVA = "0xE03118", Offset = "0xE03118", VA = "0xE03118")]
		[MoonSharpModuleMethod]
		public static DynValue asin(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x600099C")]
		[Address(RVA = "0xE03214", Offset = "0xE03214", VA = "0xE03214")]
		[MoonSharpModuleMethod]
		public static DynValue atan(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x600099D")]
		[Address(RVA = "0xE03310", Offset = "0xE03310", VA = "0xE03310")]
		[MoonSharpModuleMethod]
		public static DynValue atan2(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x600099E")]
		[Address(RVA = "0xE0340C", Offset = "0xE0340C", VA = "0xE0340C")]
		[MoonSharpModuleMethod]
		public static DynValue ceil(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x600099F")]
		[Address(RVA = "0xE03508", Offset = "0xE03508", VA = "0xE03508")]
		[MoonSharpModuleMethod]
		public static DynValue cos(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009A0")]
		[Address(RVA = "0xE03604", Offset = "0xE03604", VA = "0xE03604")]
		[MoonSharpModuleMethod]
		public static DynValue cosh(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009A1")]
		[Address(RVA = "0xE03700", Offset = "0xE03700", VA = "0xE03700")]
		[MoonSharpModuleMethod]
		public static DynValue deg(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009A2")]
		[Address(RVA = "0xE037FC", Offset = "0xE037FC", VA = "0xE037FC")]
		[MoonSharpModuleMethod]
		public static DynValue exp(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009A3")]
		[Address(RVA = "0xE038F8", Offset = "0xE038F8", VA = "0xE038F8")]
		[MoonSharpModuleMethod]
		public static DynValue floor(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009A4")]
		[Address(RVA = "0xE039F4", Offset = "0xE039F4", VA = "0xE039F4")]
		[MoonSharpModuleMethod]
		public static DynValue fmod(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009A5")]
		[Address(RVA = "0xE03AF0", Offset = "0xE03AF0", VA = "0xE03AF0")]
		[MoonSharpModuleMethod]
		public static DynValue frexp(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009A6")]
		[Address(RVA = "0xE03D44", Offset = "0xE03D44", VA = "0xE03D44")]
		[MoonSharpModuleMethod]
		public static DynValue ldexp(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009A7")]
		[Address(RVA = "0xE03E40", Offset = "0xE03E40", VA = "0xE03E40")]
		[MoonSharpModuleMethod]
		public static DynValue log(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009A8")]
		[Address(RVA = "0xE03F44", Offset = "0xE03F44", VA = "0xE03F44")]
		[MoonSharpModuleMethod]
		public static DynValue max(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009A9")]
		[Address(RVA = "0xE04040", Offset = "0xE04040", VA = "0xE04040")]
		[MoonSharpModuleMethod]
		public static DynValue min(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009AA")]
		[Address(RVA = "0xE0413C", Offset = "0xE0413C", VA = "0xE0413C")]
		[MoonSharpModuleMethod]
		public static DynValue modf(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009AB")]
		[Address(RVA = "0xE042B8", Offset = "0xE042B8", VA = "0xE042B8")]
		[MoonSharpModuleMethod]
		public static DynValue pow(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009AC")]
		[Address(RVA = "0xE043B4", Offset = "0xE043B4", VA = "0xE043B4")]
		[MoonSharpModuleMethod]
		public static DynValue rad(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009AD")]
		[Address(RVA = "0xE044B0", Offset = "0xE044B0", VA = "0xE044B0")]
		[MoonSharpModuleMethod]
		public static DynValue random(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009AE")]
		[Address(RVA = "0xE04658", Offset = "0xE04658", VA = "0xE04658")]
		[MoonSharpModuleMethod]
		public static DynValue randomseed(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009AF")]
		[Address(RVA = "0xE04798", Offset = "0xE04798", VA = "0xE04798")]
		[MoonSharpModuleMethod]
		public static DynValue sin(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009B0")]
		[Address(RVA = "0xE04894", Offset = "0xE04894", VA = "0xE04894")]
		[MoonSharpModuleMethod]
		public static DynValue sinh(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009B1")]
		[Address(RVA = "0xE04990", Offset = "0xE04990", VA = "0xE04990")]
		[MoonSharpModuleMethod]
		public static DynValue sqrt(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009B2")]
		[Address(RVA = "0xE04A8C", Offset = "0xE04A8C", VA = "0xE04A8C")]
		[MoonSharpModuleMethod]
		public static DynValue tan(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009B3")]
		[Address(RVA = "0xE04B88", Offset = "0xE04B88", VA = "0xE04B88")]
		[MoonSharpModuleMethod]
		public static DynValue tanh(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009B4")]
		[Address(RVA = "0xE04C84", Offset = "0xE04C84", VA = "0xE04C84")]
		public MathModule()
		{
		}
	}
	[Token(Token = "0x200014A")]
	[MoonSharpModule]
	public class MetaTableModule
	{
		[Token(Token = "0x60009CE")]
		[Address(RVA = "0xE05514", Offset = "0xE05514", VA = "0xE05514")]
		[MoonSharpModuleMethod]
		public static DynValue setmetatable(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009CF")]
		[Address(RVA = "0xE05658", Offset = "0xE05658", VA = "0xE05658")]
		[MoonSharpModuleMethod]
		public static DynValue getmetatable(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009D0")]
		[Address(RVA = "0xE057C8", Offset = "0xE057C8", VA = "0xE057C8")]
		[MoonSharpModuleMethod]
		public static DynValue rawget(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009D1")]
		[Address(RVA = "0xE05860", Offset = "0xE05860", VA = "0xE05860")]
		[MoonSharpModuleMethod]
		public static DynValue rawset(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009D2")]
		[Address(RVA = "0xE05924", Offset = "0xE05924", VA = "0xE05924")]
		[MoonSharpModuleMethod]
		public static DynValue rawequal(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009D3")]
		[Address(RVA = "0xE059C8", Offset = "0xE059C8", VA = "0xE059C8")]
		[MoonSharpModuleMethod]
		public static DynValue rawlen(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009D4")]
		[Address(RVA = "0xE05AC4", Offset = "0xE05AC4", VA = "0xE05AC4")]
		public MetaTableModule()
		{
		}
	}
	[Token(Token = "0x200014B")]
	[MoonSharpModule(Namespace = "os")]
	public class OsSystemModule
	{
		[Token(Token = "0x60009D5")]
		[Address(RVA = "0xE05ACC", Offset = "0xE05ACC", VA = "0xE05ACC")]
		[MoonSharpModuleMethod]
		public static DynValue execute(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009D6")]
		[Address(RVA = "0xE05EC8", Offset = "0xE05EC8", VA = "0xE05EC8")]
		[MoonSharpModuleMethod]
		public static DynValue exit(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009D7")]
		[Address(RVA = "0xE06014", Offset = "0xE06014", VA = "0xE06014")]
		[MoonSharpModuleMethod]
		public static DynValue getenv(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009D8")]
		[Address(RVA = "0xE061F8", Offset = "0xE061F8", VA = "0xE061F8")]
		[MoonSharpModuleMethod]
		public static DynValue remove(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009D9")]
		[Address(RVA = "0xE06830", Offset = "0xE06830", VA = "0xE06830")]
		[MoonSharpModuleMethod]
		public static DynValue rename(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009DA")]
		[Address(RVA = "0xE06EA4", Offset = "0xE06EA4", VA = "0xE06EA4")]
		[MoonSharpModuleMethod]
		public static DynValue setlocale(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009DB")]
		[Address(RVA = "0xE06F0C", Offset = "0xE06F0C", VA = "0xE06F0C")]
		[MoonSharpModuleMethod]
		public static DynValue tmpname(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009DC")]
		[Address(RVA = "0xE07048", Offset = "0xE07048", VA = "0xE07048")]
		public OsSystemModule()
		{
		}
	}
	[Token(Token = "0x200014C")]
	[MoonSharpModule(Namespace = "os")]
	public class OsTimeModule
	{
		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DateTime Time0;

		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DateTime Epoch;

		[Token(Token = "0x60009DD")]
		[Address(RVA = "0xE07050", Offset = "0xE07050", VA = "0xE07050")]
		private static DynValue GetUnixTime(DateTime dateTime, [Optional] DateTime? epoch)
		{
			return null;
		}

		[Token(Token = "0x60009DE")]
		[Address(RVA = "0xE071B0", Offset = "0xE071B0", VA = "0xE071B0")]
		private static DateTime FromUnixTime(double unixtime)
		{
			return default(DateTime);
		}

		[Token(Token = "0x60009DF")]
		[Address(RVA = "0xE0727C", Offset = "0xE0727C", VA = "0xE0727C")]
		[MoonSharpModuleMethod]
		public static DynValue clock(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009E0")]
		[Address(RVA = "0xE07340", Offset = "0xE07340", VA = "0xE07340")]
		[MoonSharpModuleMethod]
		public static DynValue difftime(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009E1")]
		[Address(RVA = "0xE07430", Offset = "0xE07430", VA = "0xE07430")]
		[MoonSharpModuleMethod]
		public static DynValue time(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009E2")]
		[Address(RVA = "0xE0753C", Offset = "0xE0753C", VA = "0xE0753C")]
		private static DateTime ParseTimeTable(Table t)
		{
			return default(DateTime);
		}

		[Token(Token = "0x60009E3")]
		[Address(RVA = "0xE077E4", Offset = "0xE077E4", VA = "0xE077E4")]
		private static int? GetTimeTableField(Table t, string key)
		{
			return null;
		}

		[Token(Token = "0x60009E4")]
		[Address(RVA = "0xE078C8", Offset = "0xE078C8", VA = "0xE078C8")]
		[MoonSharpModuleMethod]
		public static DynValue date(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009E5")]
		[Address(RVA = "0xE07E80", Offset = "0xE07E80", VA = "0xE07E80")]
		private static string StrFTime(string format, DateTime d)
		{
			return null;
		}

		[Token(Token = "0x60009E6")]
		[Address(RVA = "0xE0864C", Offset = "0xE0864C", VA = "0xE0864C")]
		public OsTimeModule()
		{
		}
	}
	[Token(Token = "0x200014D")]
	[MoonSharpModule(Namespace = "string")]
	public class StringModule
	{
		[Token(Token = "0x400046C")]
		public const string BASE64_DUMP_HEADER = "MoonSharp_dump_b64::";

		[Token(Token = "0x60009E8")]
		[Address(RVA = "0xE08708", Offset = "0xE08708", VA = "0xE08708")]
		public static void MoonSharpInit(Table globalTable, Table stringTable)
		{
		}

		[Token(Token = "0x60009E9")]
		[Address(RVA = "0xE087F0", Offset = "0xE087F0", VA = "0xE087F0")]
		[MoonSharpModuleMethod]
		public static DynValue dump(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009EA")]
		[Address(RVA = "0xE08B9C", Offset = "0xE08B9C", VA = "0xE08B9C")]
		[MoonSharpModuleMethod]
		public static DynValue @char(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009EB")]
		[Address(RVA = "0xE08D64", Offset = "0xE08D64", VA = "0xE08D64")]
		[MoonSharpModuleMethod]
		public static DynValue @byte(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009EC")]
		[Address(RVA = "0xE09064", Offset = "0xE09064", VA = "0xE09064")]
		[MoonSharpModuleMethod]
		public static DynValue unicode(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009ED")]
		[Address(RVA = "0xE091D4", Offset = "0xE091D4", VA = "0xE091D4")]
		private static int Unicode2Ascii(int i)
		{
			return default(int);
		}

		[Token(Token = "0x60009EE")]
		[Address(RVA = "0xE08ED4", Offset = "0xE08ED4", VA = "0xE08ED4")]
		private static DynValue PerformByteLike(DynValue vs, DynValue vi, DynValue vj, Func<int, int> filter)
		{
			return null;
		}

		[Token(Token = "0x60009EF")]
		[Address(RVA = "0xE093B8", Offset = "0xE093B8", VA = "0xE093B8")]
		private static int? AdjustIndex(string s, DynValue vi, int defval)
		{
			return null;
		}

		[Token(Token = "0x60009F0")]
		[Address(RVA = "0xE09508", Offset = "0xE09508", VA = "0xE09508")]
		[MoonSharpModuleMethod]
		public static DynValue len(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009F1")]
		[Address(RVA = "0xE095B0", Offset = "0xE095B0", VA = "0xE095B0")]
		[MoonSharpModuleMethod]
		public static DynValue match(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009F2")]
		[Address(RVA = "0xE09660", Offset = "0xE09660", VA = "0xE09660")]
		[MoonSharpModuleMethod]
		public static DynValue gmatch(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009F3")]
		[Address(RVA = "0xE09710", Offset = "0xE09710", VA = "0xE09710")]
		[MoonSharpModuleMethod]
		public static DynValue gsub(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009F4")]
		[Address(RVA = "0xE097C0", Offset = "0xE097C0", VA = "0xE097C0")]
		[MoonSharpModuleMethod]
		public static DynValue find(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009F5")]
		[Address(RVA = "0xE09870", Offset = "0xE09870", VA = "0xE09870")]
		[MoonSharpModuleMethod]
		public static DynValue lower(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009F6")]
		[Address(RVA = "0xE09920", Offset = "0xE09920", VA = "0xE09920")]
		[MoonSharpModuleMethod]
		public static DynValue upper(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009F7")]
		[Address(RVA = "0xE099D0", Offset = "0xE099D0", VA = "0xE099D0")]
		[MoonSharpModuleMethod]
		public static DynValue rep(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009F8")]
		[Address(RVA = "0xE09BFC", Offset = "0xE09BFC", VA = "0xE09BFC")]
		[MoonSharpModuleMethod]
		public static DynValue format(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009F9")]
		[Address(RVA = "0xE09CAC", Offset = "0xE09CAC", VA = "0xE09CAC")]
		[MoonSharpModuleMethod]
		public static DynValue reverse(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009FA")]
		[Address(RVA = "0xE09DD4", Offset = "0xE09DD4", VA = "0xE09DD4")]
		[MoonSharpModuleMethod]
		public static DynValue sub(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009FB")]
		[Address(RVA = "0xE09F18", Offset = "0xE09F18", VA = "0xE09F18")]
		[MoonSharpModuleMethod]
		public static DynValue startsWith(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009FC")]
		[Address(RVA = "0xE0A084", Offset = "0xE0A084", VA = "0xE0A084")]
		[MoonSharpModuleMethod]
		public static DynValue endsWith(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009FD")]
		[Address(RVA = "0xE0A1F0", Offset = "0xE0A1F0", VA = "0xE0A1F0")]
		[MoonSharpModuleMethod]
		public static DynValue contains(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009FE")]
		[Address(RVA = "0xE0A35C", Offset = "0xE0A35C", VA = "0xE0A35C")]
		public StringModule()
		{
		}
	}
	[Token(Token = "0x200014F")]
	[MoonSharpModule]
	public class TableIteratorsModule
	{
		[Token(Token = "0x6000A03")]
		[Address(RVA = "0xE0A3E8", Offset = "0xE0A3E8", VA = "0xE0A3E8")]
		[MoonSharpModuleMethod]
		public static DynValue ipairs(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000A04")]
		[Address(RVA = "0xE0A5D8", Offset = "0xE0A5D8", VA = "0xE0A5D8")]
		[MoonSharpModuleMethod]
		public static DynValue pairs(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000A05")]
		[Address(RVA = "0xE0A790", Offset = "0xE0A790", VA = "0xE0A790")]
		[MoonSharpModuleMethod]
		public static DynValue next(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000A06")]
		[Address(RVA = "0xE0A998", Offset = "0xE0A998", VA = "0xE0A998")]
		public static DynValue __next_i(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000A07")]
		[Address(RVA = "0xE0AB84", Offset = "0xE0AB84", VA = "0xE0AB84")]
		public TableIteratorsModule()
		{
		}
	}
	[Token(Token = "0x2000150")]
	[MoonSharpModule(Namespace = "table")]
	public class TableModule
	{
		[Token(Token = "0x6000A08")]
		[Address(RVA = "0xE0AB8C", Offset = "0xE0AB8C", VA = "0xE0AB8C")]
		[MoonSharpModuleMethod]
		public static DynValue unpack(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000A09")]
		[Address(RVA = "0xE0AF74", Offset = "0xE0AF74", VA = "0xE0AF74")]
		[MoonSharpModuleMethod]
		public static DynValue pack(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000A0A")]
		[Address(RVA = "0xE0B0C4", Offset = "0xE0B0C4", VA = "0xE0B0C4")]
		[MoonSharpModuleMethod]
		public static DynValue sort(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000A0B")]
		[Address(RVA = "0xE0B48C", Offset = "0xE0B48C", VA = "0xE0B48C")]
		private static int SortComparer(ScriptExecutionContext executionContext, DynValue a, DynValue b, DynValue lt)
		{
			return default(int);
		}

		[Token(Token = "0x6000A0C")]
		[Address(RVA = "0xE0B740", Offset = "0xE0B740", VA = "0xE0B740")]
		private static int LuaComparerToClrComparer(DynValue dynValue1, DynValue dynValue2)
		{
			return default(int);
		}

		[Token(Token = "0x6000A0D")]
		[Address(RVA = "0xE0B7F8", Offset = "0xE0B7F8", VA = "0xE0B7F8")]
		[MoonSharpModuleMethod]
		public static DynValue insert(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000A0E")]
		[Address(RVA = "0xE0BA48", Offset = "0xE0BA48", VA = "0xE0BA48")]
		[MoonSharpModuleMethod]
		public static DynValue remove(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000A0F")]
		[Address(RVA = "0xE0BCA8", Offset = "0xE0BCA8", VA = "0xE0BCA8")]
		[MoonSharpModuleMethod]
		public static DynValue concat(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000A10")]
		[Address(RVA = "0xE0ADA8", Offset = "0xE0ADA8", VA = "0xE0ADA8")]
		private static int GetTableLength(ScriptExecutionContext executionContext, DynValue vlist)
		{
			return default(int);
		}

		[Token(Token = "0x6000A11")]
		[Address(RVA = "0xE0C068", Offset = "0xE0C068", VA = "0xE0C068")]
		public TableModule()
		{
		}
	}
	[Token(Token = "0x2000152")]
	[MoonSharpModule]
	public class TableModule_Globals
	{
		[Token(Token = "0x6000A14")]
		[Address(RVA = "0xE0C07C", Offset = "0xE0C07C", VA = "0xE0C07C")]
		[MoonSharpModuleMethod]
		public static DynValue unpack(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000A15")]
		[Address(RVA = "0xE0C080", Offset = "0xE0C080", VA = "0xE0C080")]
		[MoonSharpModuleMethod]
		public static DynValue pack(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000A16")]
		[Address(RVA = "0xE0C084", Offset = "0xE0C084", VA = "0xE0C084")]
		public TableModule_Globals()
		{
		}
	}
	[Token(Token = "0x2000153")]
	internal static class NamespaceDoc
	{
	}
}
namespace MoonSharp.Interpreter.CoreLib.StringLib
{
	[Token(Token = "0x2000154")]
	internal class KopiLua_StringLib : LuaBase
	{
		[Token(Token = "0x2000155")]
		public class MatchState
		{
			[Token(Token = "0x2000156")]
			public class capture_
			{
				[Token(Token = "0x4000481")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public CharPtr init;

				[Token(Token = "0x4000482")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public int len;

				[Token(Token = "0x6000A3A")]
				[Address(RVA = "0xE101B8", Offset = "0xE101B8", VA = "0xE101B8")]
				public capture_()
				{
				}
			}

			[Token(Token = "0x400047B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int matchdepth;

			[Token(Token = "0x400047C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public CharPtr src_init;

			[Token(Token = "0x400047D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CharPtr src_end;

			[Token(Token = "0x400047E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public LuaState L;

			[Token(Token = "0x400047F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public int level;

			[Token(Token = "0x4000480")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public capture_[] capture;

			[Token(Token = "0x6000A39")]
			[Address(RVA = "0xE0E32C", Offset = "0xE0E32C", VA = "0xE0E32C")]
			public MatchState()
			{
			}
		}

		[Token(Token = "0x2000157")]
		private class GMatchAuxData
		{
			[Token(Token = "0x4000483")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CharPtr S;

			[Token(Token = "0x4000484")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public CharPtr P;

			[Token(Token = "0x4000485")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public uint LS;

			[Token(Token = "0x4000486")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public uint POS;

			[Token(Token = "0x6000A3B")]
			[Address(RVA = "0xE0E978", Offset = "0xE0E978", VA = "0xE0E978")]
			public GMatchAuxData()
			{
			}
		}

		[Token(Token = "0x4000472")]
		public const int LUA_MAXCAPTURES = 32;

		[Token(Token = "0x4000473")]
		public const int CAP_UNFINISHED = -1;

		[Token(Token = "0x4000474")]
		public const int CAP_POSITION = -2;

		[Token(Token = "0x4000475")]
		public const int MAXCCALLS = 200;

		[Token(Token = "0x4000476")]
		public const char L_ESC = '%';

		[Token(Token = "0x4000477")]
		public const string SPECIALS = "^$*+?.([%-";

		[Token(Token = "0x4000478")]
		public const int MAX_ITEM = 512;

		[Token(Token = "0x4000479")]
		public const string FLAGS = "-+ #0";

		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly int MAX_FORMAT;

		[Token(Token = "0x6000A17")]
		[Address(RVA = "0xE0C08C", Offset = "0xE0C08C", VA = "0xE0C08C")]
		private static int posrelat(int pos, uint len)
		{
			return default(int);
		}

		[Token(Token = "0x6000A18")]
		[Address(RVA = "0xE0C0A0", Offset = "0xE0C0A0", VA = "0xE0C0A0")]
		private static int check_capture(MatchState ms, int l)
		{
			return default(int);
		}

		[Token(Token = "0x6000A19")]
		[Address(RVA = "0xE0C1DC", Offset = "0xE0C1DC", VA = "0xE0C1DC")]
		private static int capture_to_close(MatchState ms)
		{
			return default(int);
		}

		[Token(Token = "0x6000A1A")]
		[Address(RVA = "0xE0C2D0", Offset = "0xE0C2D0", VA = "0xE0C2D0")]
		private static CharPtr classend(MatchState ms, CharPtr p)
		{
			return null;
		}

		[Token(Token = "0x6000A1B")]
		[Address(RVA = "0xE0C620", Offset = "0xE0C620", VA = "0xE0C620")]
		private static int match_class(char c, char cl)
		{
			return default(int);
		}

		[Token(Token = "0x6000A1C")]
		[Address(RVA = "0xE0C740", Offset = "0xE0C740", VA = "0xE0C740")]
		private static int matchbracketclass(int c, CharPtr p, CharPtr ec)
		{
			return default(int);
		}

		[Token(Token = "0x6000A1D")]
		[Address(RVA = "0xE0C924", Offset = "0xE0C924", VA = "0xE0C924")]
		private static int singlematch(int c, CharPtr p, CharPtr ep)
		{
			return default(int);
		}

		[Token(Token = "0x6000A1E")]
		[Address(RVA = "0xE0CA4C", Offset = "0xE0CA4C", VA = "0xE0CA4C")]
		private static CharPtr matchbalance(MatchState ms, CharPtr s, CharPtr p)
		{
			return null;
		}

		[Token(Token = "0x6000A1F")]
		[Address(RVA = "0xE0CC40", Offset = "0xE0CC40", VA = "0xE0CC40")]
		private static CharPtr max_expand(MatchState ms, CharPtr s, CharPtr p, CharPtr ep)
		{
			return null;
		}

		[Token(Token = "0x6000A20")]
		[Address(RVA = "0xE0D678", Offset = "0xE0D678", VA = "0xE0D678")]
		private static CharPtr min_expand(MatchState ms, CharPtr s, CharPtr p, CharPtr ep)
		{
			return null;
		}

		[Token(Token = "0x6000A21")]
		[Address(RVA = "0xE0D798", Offset = "0xE0D798", VA = "0xE0D798")]
		private static CharPtr start_capture(MatchState ms, CharPtr s, CharPtr p, int what)
		{
			return null;
		}

		[Token(Token = "0x6000A22")]
		[Address(RVA = "0xE0D904", Offset = "0xE0D904", VA = "0xE0D904")]
		private static CharPtr end_capture(MatchState ms, CharPtr s, CharPtr p)
		{
			return null;
		}

		[Token(Token = "0x6000A23")]
		[Address(RVA = "0xE0DA0C", Offset = "0xE0DA0C", VA = "0xE0DA0C")]
		private static CharPtr match_capture(MatchState ms, CharPtr s, int l)
		{
			return null;
		}

		[Token(Token = "0x6000A24")]
		[Address(RVA = "0xE0CDA4", Offset = "0xE0CDA4", VA = "0xE0CDA4")]
		private static CharPtr match(MatchState ms, CharPtr s, CharPtr p)
		{
			return null;
		}

		[Token(Token = "0x6000A25")]
		[Address(RVA = "0xE0DB20", Offset = "0xE0DB20", VA = "0xE0DB20")]
		private static CharPtr lmemfind(CharPtr s1, uint l1, CharPtr s2, uint l2)
		{
			return null;
		}

		[Token(Token = "0x6000A26")]
		[Address(RVA = "0xE0DC18", Offset = "0xE0DC18", VA = "0xE0DC18")]
		private static void push_onecapture(MatchState ms, int i, CharPtr s, CharPtr e)
		{
		}

		[Token(Token = "0x6000A27")]
		[Address(RVA = "0xE0DE2C", Offset = "0xE0DE2C", VA = "0xE0DE2C")]
		private static int push_captures(MatchState ms, CharPtr s, CharPtr e)
		{
			return default(int);
		}

		[Token(Token = "0x6000A28")]
		[Address(RVA = "0xE0DF1C", Offset = "0xE0DF1C", VA = "0xE0DF1C")]
		private static int str_find_aux(LuaState L, int find)
		{
			return default(int);
		}

		[Token(Token = "0x6000A29")]
		[Address(RVA = "0xE0E410", Offset = "0xE0E410", VA = "0xE0E410")]
		public static int str_find(LuaState L)
		{
			return default(int);
		}

		[Token(Token = "0x6000A2A")]
		[Address(RVA = "0xE0E468", Offset = "0xE0E468", VA = "0xE0E468")]
		public static int str_match(LuaState L)
		{
			return default(int);
		}

		[Token(Token = "0x6000A2B")]
		[Address(RVA = "0xE0E4C0", Offset = "0xE0E4C0", VA = "0xE0E4C0")]
		private static int gmatch_aux(LuaState L, GMatchAuxData auxdata)
		{
			return default(int);
		}

		[Token(Token = "0x6000A2C")]
		[Address(RVA = "0xE0E660", Offset = "0xE0E660", VA = "0xE0E660")]
		private static DynValue gmatch_aux_2(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000A2D")]
		[Address(RVA = "0xE0E748", Offset = "0xE0E748", VA = "0xE0E748")]
		public static int str_gmatch(LuaState L)
		{
			return default(int);
		}

		[Token(Token = "0x6000A2E")]
		[Address(RVA = "0xE0E980", Offset = "0xE0E980", VA = "0xE0E980")]
		private static int gfind_nodef(LuaState L)
		{
			return default(int);
		}

		[Token(Token = "0x6000A2F")]
		[Address(RVA = "0xE0EA9C", Offset = "0xE0EA9C", VA = "0xE0EA9C")]
		private static void add_s(MatchState ms, LuaLBuffer b, CharPtr s, CharPtr e)
		{
		}

		[Token(Token = "0x6000A30")]
		[Address(RVA = "0xE0ECD8", Offset = "0xE0ECD8", VA = "0xE0ECD8")]
		private static void add_value(MatchState ms, LuaLBuffer b, CharPtr s, CharPtr e)
		{
		}

		[Token(Token = "0x6000A31")]
		[Address(RVA = "0xE0EF1C", Offset = "0xE0EF1C", VA = "0xE0EF1C")]
		public static int str_gsub(LuaState L)
		{
			return default(int);
		}

		[Token(Token = "0x6000A32")]
		[Address(RVA = "0xE0F26C", Offset = "0xE0F26C", VA = "0xE0F26C")]
		private static void addquoted(LuaState L, LuaLBuffer b, int arg)
		{
		}

		[Token(Token = "0x6000A33")]
		[Address(RVA = "0xE0F518", Offset = "0xE0F518", VA = "0xE0F518")]
		private static CharPtr scanformat(LuaState L, CharPtr strfrmt, CharPtr form)
		{
			return null;
		}

		[Token(Token = "0x6000A34")]
		[Address(RVA = "0xE0F898", Offset = "0xE0F898", VA = "0xE0F898")]
		private static void addintlen(CharPtr form)
		{
		}

		[Token(Token = "0x6000A35")]
		[Address(RVA = "0xE0F99C", Offset = "0xE0F99C", VA = "0xE0F99C")]
		public static int str_format(LuaState L)
		{
			return default(int);
		}

		[Token(Token = "0x6000A36")]
		[Address(RVA = "0xE0E2C0", Offset = "0xE0E2C0", VA = "0xE0E2C0")]
		private static string PatchPattern(string charPtr)
		{
			return null;
		}

		[Token(Token = "0x6000A37")]
		[Address(RVA = "0xE1011C", Offset = "0xE1011C", VA = "0xE1011C")]
		public KopiLua_StringLib()
		{
		}
	}
	[Token(Token = "0x2000159")]
	internal class StringRange
	{
		[Token(Token = "0x17000168")]
		public int Start
		{
			[Token(Token = "0x6000A3E")]
			[Address(RVA = "0xE1028C", Offset = "0xE1028C", VA = "0xE1028C")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000A3F")]
			[Address(RVA = "0xE10294", Offset = "0xE10294", VA = "0xE10294")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000169")]
		public int End
		{
			[Token(Token = "0x6000A40")]
			[Address(RVA = "0xE1029C", Offset = "0xE1029C", VA = "0xE1029C")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000A41")]
			[Address(RVA = "0xE102A4", Offset = "0xE102A4", VA = "0xE102A4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000A42")]
		[Address(RVA = "0xE102AC", Offset = "0xE102AC", VA = "0xE102AC")]
		public StringRange()
		{
		}

		[Token(Token = "0x6000A43")]
		[Address(RVA = "0xE102C8", Offset = "0xE102C8", VA = "0xE102C8")]
		public StringRange(int start, int end)
		{
		}

		[Token(Token = "0x6000A44")]
		[Address(RVA = "0xE091E4", Offset = "0xE091E4", VA = "0xE091E4")]
		public static StringRange FromLuaRange(DynValue start, DynValue end, [Optional] int? defaultEnd)
		{
			return null;
		}

		[Token(Token = "0x6000A45")]
		[Address(RVA = "0xE092EC", Offset = "0xE092EC", VA = "0xE092EC")]
		public string ApplyToString(string value)
		{
			return null;
		}

		[Token(Token = "0x6000A46")]
		[Address(RVA = "0xE102F4", Offset = "0xE102F4", VA = "0xE102F4")]
		public int Length()
		{
			return default(int);
		}
	}
}
namespace MoonSharp.Interpreter.CoreLib.IO
{
	[Token(Token = "0x200015A")]
	internal class BinaryEncoding : Encoding
	{
		[Token(Token = "0x6000A47")]
		[Address(RVA = "0xE10304", Offset = "0xE10304", VA = "0xE10304")]
		public BinaryEncoding()
		{
		}

		[Token(Token = "0x6000A48")]
		[Address(RVA = "0xE1030C", Offset = "0xE1030C", VA = "0xE1030C", Slot = "13")]
		public override int GetByteCount(char[] chars, int index, int count)
		{
			return default(int);
		}

		[Token(Token = "0x6000A49")]
		[Address(RVA = "0xE10314", Offset = "0xE10314", VA = "0xE10314", Slot = "18")]
		public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex)
		{
			return default(int);
		}

		[Token(Token = "0x6000A4A")]
		[Address(RVA = "0xE10388", Offset = "0xE10388", VA = "0xE10388", Slot = "23")]
		public override int GetCharCount(byte[] bytes, int index, int count)
		{
			return default(int);
		}

		[Token(Token = "0x6000A4B")]
		[Address(RVA = "0xE10390", Offset = "0xE10390", VA = "0xE10390", Slot = "27")]
		public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex)
		{
			return default(int);
		}

		[Token(Token = "0x6000A4C")]
		[Address(RVA = "0xE10404", Offset = "0xE10404", VA = "0xE10404", Slot = "34")]
		public override int GetMaxByteCount(int charCount)
		{
			return default(int);
		}

		[Token(Token = "0x6000A4D")]
		[Address(RVA = "0xE1040C", Offset = "0xE1040C", VA = "0xE1040C", Slot = "35")]
		public override int GetMaxCharCount(int byteCount)
		{
			return default(int);
		}
	}
	[Token(Token = "0x200015B")]
	internal class FileUserData : StreamFileUserDataBase
	{
		[Token(Token = "0x6000A4E")]
		[Address(RVA = "0xE10414", Offset = "0xE10414", VA = "0xE10414")]
		public FileUserData(Script script, string filename, Encoding encoding, string mode)
		{
		}
	}
	[Token(Token = "0x200015C")]
	internal abstract class FileUserDataBase : RefIdObject
	{
		[Token(Token = "0x6000A4F")]
		[Address(RVA = "0xE1061C", Offset = "0xE1061C", VA = "0xE1061C")]
		public DynValue lines(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000A50")]
		[Address(RVA = "0xE10860", Offset = "0xE10860", VA = "0xE10860")]
		public DynValue read(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000A51")]
		[Address(RVA = "0xE1107C", Offset = "0xE1107C", VA = "0xE1107C")]
		public DynValue write(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000A52")]
		[Address(RVA = "0xE11320", Offset = "0xE11320", VA = "0xE11320")]
		public DynValue close(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000A53")]
		[Address(RVA = "0xE10EFC", Offset = "0xE10EFC", VA = "0xE10EFC")]
		private double? ReadNumber()
		{
			return null;
		}

		[Token(Token = "0x6000A54")]
		[Address(RVA = "0xE11694", Offset = "0xE11694", VA = "0xE11694")]
		private bool IsNumericChar(char c, string numAsFar)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A55")]
		protected abstract bool Eof();

		[Token(Token = "0x6000A56")]
		protected abstract string ReadLine();

		[Token(Token = "0x6000A57")]
		protected abstract string ReadBuffer(int p);

		[Token(Token = "0x6000A58")]
		protected abstract string ReadToEnd();

		[Token(Token = "0x6000A59")]
		protected abstract char Peek();

		[Token(Token = "0x6000A5A")]
		protected abstract void Write(string value);

		[Token(Token = "0x6000A5B")]
		protected internal abstract bool isopen();

		[Token(Token = "0x6000A5C")]
		protected abstract string Close();

		[Token(Token = "0x6000A5D")]
		public abstract bool flush();

		[Token(Token = "0x6000A5E")]
		public abstract long seek(string whence, long offset);

		[Token(Token = "0x6000A5F")]
		public abstract bool setvbuf(string mode);

		[Token(Token = "0x6000A60")]
		[Address(RVA = "0xE11898", Offset = "0xE11898", VA = "0xE11898", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000A61")]
		[Address(RVA = "0xE11944", Offset = "0xE11944", VA = "0xE11944")]
		protected FileUserDataBase()
		{
		}
	}
	[Token(Token = "0x200015E")]
	internal class StandardIOFileUserDataBase : StreamFileUserDataBase
	{
		[Token(Token = "0x6000A65")]
		[Address(RVA = "0xE119C0", Offset = "0xE119C0", VA = "0xE119C0", Slot = "11")]
		protected override string Close()
		{
			return null;
		}

		[Token(Token = "0x6000A66")]
		[Address(RVA = "0xE11A00", Offset = "0xE11A00", VA = "0xE11A00")]
		public static StandardIOFileUserDataBase CreateInputStream(Stream stream)
		{
			return null;
		}

		[Token(Token = "0x6000A67")]
		[Address(RVA = "0xE11AA0", Offset = "0xE11AA0", VA = "0xE11AA0")]
		public static StandardIOFileUserDataBase CreateOutputStream(Stream stream)
		{
			return null;
		}

		[Token(Token = "0x6000A68")]
		[Address(RVA = "0xE11A98", Offset = "0xE11A98", VA = "0xE11A98")]
		public StandardIOFileUserDataBase()
		{
		}
	}
	[Token(Token = "0x200015F")]
	internal abstract class StreamFileUserDataBase : FileUserDataBase
	{
		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected Stream m_Stream;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected StreamReader m_Reader;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected StreamWriter m_Writer;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected bool m_Closed;

		[Token(Token = "0x6000A69")]
		[Address(RVA = "0xE10610", Offset = "0xE10610", VA = "0xE10610")]
		protected void Initialize(Stream stream, StreamReader reader, StreamWriter writer)
		{
		}

		[Token(Token = "0x6000A6A")]
		[Address(RVA = "0xE11B38", Offset = "0xE11B38", VA = "0xE11B38")]
		private void CheckFileIsNotClosed()
		{
		}

		[Token(Token = "0x6000A6B")]
		[Address(RVA = "0xE11B98", Offset = "0xE11B98", VA = "0xE11B98", Slot = "4")]
		protected override bool Eof()
		{
			return default(bool);
		}

		[Token(Token = "0x6000A6C")]
		[Address(RVA = "0xE11BC0", Offset = "0xE11BC0", VA = "0xE11BC0", Slot = "5")]
		protected override string ReadLine()
		{
			return null;
		}

		[Token(Token = "0x6000A6D")]
		[Address(RVA = "0xE11BEC", Offset = "0xE11BEC", VA = "0xE11BEC", Slot = "7")]
		protected override string ReadToEnd()
		{
			return null;
		}

		[Token(Token = "0x6000A6E")]
		[Address(RVA = "0xE11C18", Offset = "0xE11C18", VA = "0xE11C18", Slot = "6")]
		protected override string ReadBuffer(int p)
		{
			return null;
		}

		[Token(Token = "0x6000A6F")]
		[Address(RVA = "0xE11CBC", Offset = "0xE11CBC", VA = "0xE11CBC", Slot = "8")]
		protected override char Peek()
		{
			return default(char);
		}

		[Token(Token = "0x6000A70")]
		[Address(RVA = "0xE11CE8", Offset = "0xE11CE8", VA = "0xE11CE8", Slot = "9")]
		protected override void Write(string value)
		{
		}

		[Token(Token = "0x6000A71")]
		[Address(RVA = "0xE11D24", Offset = "0xE11D24", VA = "0xE11D24", Slot = "11")]
		protected override string Close()
		{
			return null;
		}

		[Token(Token = "0x6000A72")]
		[Address(RVA = "0xE11D78", Offset = "0xE11D78", VA = "0xE11D78", Slot = "12")]
		public override bool flush()
		{
			return default(bool);
		}

		[Token(Token = "0x6000A73")]
		[Address(RVA = "0xE11DA4", Offset = "0xE11DA4", VA = "0xE11DA4", Slot = "13")]
		public override long seek(string whence, long offset)
		{
			return default(long);
		}

		[Token(Token = "0x6000A74")]
		[Address(RVA = "0xE11F3C", Offset = "0xE11F3C", VA = "0xE11F3C", Slot = "14")]
		public override bool setvbuf(string mode)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A75")]
		[Address(RVA = "0xE11FEC", Offset = "0xE11FEC", VA = "0xE11FEC", Slot = "10")]
		protected internal override bool isopen()
		{
			return default(bool);
		}

		[Token(Token = "0x6000A76")]
		[Address(RVA = "0xE10608", Offset = "0xE10608", VA = "0xE10608")]
		protected StreamFileUserDataBase()
		{
		}
	}
	[Token(Token = "0x2000160")]
	internal static class NamespaceDoc
	{
	}
}
namespace MoonSharp.Interpreter.Compatibility
{
	[Token(Token = "0x2000161")]
	public static class Framework
	{
		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static FrameworkCurrent s_FrameworkCurrent;

		[Token(Token = "0x1700016A")]
		public static FrameworkBase Do
		{
			[Token(Token = "0x6000A77")]
			[Address(RVA = "0xE11FFC", Offset = "0xE11FFC", VA = "0xE11FFC")]
			get
			{
				return null;
			}
		}
	}
}
namespace MoonSharp.Interpreter.Compatibility.Frameworks
{
	[Token(Token = "0x2000162")]
	public abstract class FrameworkBase
	{
		[Token(Token = "0x6000A79")]
		public abstract bool StringContainsChar(string str, char chr);

		[Token(Token = "0x6000A7A")]
		public abstract bool IsValueType(Type t);

		[Token(Token = "0x6000A7B")]
		public abstract Assembly GetAssembly(Type t);

		[Token(Token = "0x6000A7C")]
		public abstract Type GetBaseType(Type t);

		[Token(Token = "0x6000A7D")]
		public abstract bool IsGenericType(Type t);

		[Token(Token = "0x6000A7E")]
		public abstract bool IsGenericTypeDefinition(Type t);

		[Token(Token = "0x6000A7F")]
		public abstract bool IsEnum(Type t);

		[Token(Token = "0x6000A80")]
		public abstract bool IsNestedPublic(Type t);

		[Token(Token = "0x6000A81")]
		public abstract bool IsAbstract(Type t);

		[Token(Token = "0x6000A82")]
		public abstract bool IsInterface(Type t);

		[Token(Token = "0x6000A83")]
		public abstract Attribute[] GetCustomAttributes(Type t, bool inherit);

		[Token(Token = "0x6000A84")]
		public abstract Attribute[] GetCustomAttributes(Type t, Type at, bool inherit);

		[Token(Token = "0x6000A85")]
		public abstract Type[] GetInterfaces(Type t);

		[Token(Token = "0x6000A86")]
		public abstract bool IsInstanceOfType(Type t, object o);

		[Token(Token = "0x6000A87")]
		public abstract MethodInfo GetAddMethod(EventInfo ei);

		[Token(Token = "0x6000A88")]
		public abstract MethodInfo GetRemoveMethod(EventInfo ei);

		[Token(Token = "0x6000A89")]
		public abstract MethodInfo GetGetMethod(PropertyInfo pi);

		[Token(Token = "0x6000A8A")]
		public abstract MethodInfo GetSetMethod(PropertyInfo pi);

		[Token(Token = "0x6000A8B")]
		public abstract Type GetInterface(Type type, string name);

		[Token(Token = "0x6000A8C")]
		public abstract PropertyInfo[] GetProperties(Type type);

		[Token(Token = "0x6000A8D")]
		public abstract PropertyInfo GetProperty(Type type, string name);

		[Token(Token = "0x6000A8E")]
		public abstract Type[] GetNestedTypes(Type type);

		[Token(Token = "0x6000A8F")]
		public abstract EventInfo[] GetEvents(Type type);

		[Token(Token = "0x6000A90")]
		public abstract ConstructorInfo[] GetConstructors(Type type);

		[Token(Token = "0x6000A91")]
		public abstract Type[] GetAssemblyTypes(Assembly asm);

		[Token(Token = "0x6000A92")]
		public abstract MethodInfo[] GetMethods(Type type);

		[Token(Token = "0x6000A93")]
		public abstract FieldInfo[] GetFields(Type t);

		[Token(Token = "0x6000A94")]
		public abstract MethodInfo GetMethod(Type type, string name);

		[Token(Token = "0x6000A95")]
		public abstract Type[] GetGenericArguments(Type t);

		[Token(Token = "0x6000A96")]
		public abstract bool IsAssignableFrom(Type current, Type toCompare);

		[Token(Token = "0x6000A97")]
		public abstract bool IsDbNull(object o);

		[Token(Token = "0x6000A98")]
		public abstract MethodInfo GetMethod(Type resourcesType, string v, Type[] type);

		[Token(Token = "0x6000A99")]
		[Address(RVA = "0xE120EC", Offset = "0xE120EC", VA = "0xE120EC")]
		protected FrameworkBase()
		{
		}
	}
	[Token(Token = "0x2000163")]
	internal abstract class FrameworkClrBase : FrameworkReflectionBase
	{
		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private BindingFlags BINDINGFLAGS_MEMBER;

		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private BindingFlags BINDINGFLAGS_INNERCLASS;

		[Token(Token = "0x6000A9A")]
		[Address(RVA = "0xE120F4", Offset = "0xE120F4", VA = "0xE120F4", Slot = "36")]
		public override Type GetTypeInfoFromType(Type t)
		{
			return null;
		}

		[Token(Token = "0x6000A9B")]
		[Address(RVA = "0xE120FC", Offset = "0xE120FC", VA = "0xE120FC", Slot = "18")]
		public override MethodInfo GetAddMethod(EventInfo ei)
		{
			return null;
		}

		[Token(Token = "0x6000A9C")]
		[Address(RVA = "0xE12124", Offset = "0xE12124", VA = "0xE12124", Slot = "27")]
		public override ConstructorInfo[] GetConstructors(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000A9D")]
		[Address(RVA = "0xE12150", Offset = "0xE12150", VA = "0xE12150", Slot = "26")]
		public override EventInfo[] GetEvents(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000A9E")]
		[Address(RVA = "0xE1217C", Offset = "0xE1217C", VA = "0xE1217C", Slot = "30")]
		public override FieldInfo[] GetFields(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000A9F")]
		[Address(RVA = "0xE121A8", Offset = "0xE121A8", VA = "0xE121A8", Slot = "32")]
		public override Type[] GetGenericArguments(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000AA0")]
		[Address(RVA = "0xE121CC", Offset = "0xE121CC", VA = "0xE121CC", Slot = "20")]
		public override MethodInfo GetGetMethod(PropertyInfo pi)
		{
			return null;
		}

		[Token(Token = "0x6000AA1")]
		[Address(RVA = "0xE121F4", Offset = "0xE121F4", VA = "0xE121F4", Slot = "16")]
		public override Type[] GetInterfaces(Type t)
		{
			return null;
		}

		[Token(Token = "0x6000AA2")]
		[Address(RVA = "0xE12218", Offset = "0xE12218", VA = "0xE12218", Slot = "31")]
		public override MethodInfo GetMethod(Type type, string name)
		{
			return null;
		}

		[Token(Token = "0x6000AA3")]
		[Address(RVA = "0xE12234", Offset = "0xE12234", VA = "0xE12234", Slot = "29")]
		public override MethodInfo[] GetMethods(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000AA4")]
		[Address(RVA = "0xE12260", Offset = "0xE12260", VA = "0xE12260", Slot = "25")]
		public override Type[] GetNestedTypes(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000AA5")]
		[Address(RVA = "0xE1228C", Offset = "0xE1228C", VA = "0xE1228C", Slot = "23")]
		public override PropertyInfo[] GetProperties(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000AA6")]
		[Address(RVA = "0xE122B8", Offset = "0xE122B8", VA = "0xE122B8", Slot = "24")]
		public override PropertyInfo GetProperty(Type type, string name)
		{
			return null;
		}

		[Token(Token = "0x6000AA7")]
		[Address(RVA = "0xE122D4", Offset = "0xE122D4", VA = "0xE122D4", Slot = "19")]
		public override MethodInfo GetRemoveMethod(EventInfo ei)
		{
			return null;
		}

		[Token(Token = "0x6000AA8")]
		[Address(RVA = "0xE122FC", Offset = "0xE122FC", VA = "0xE122FC", Slot = "21")]
		public override MethodInfo GetSetMethod(PropertyInfo pi)
		{
			return null;
		}

		[Token(Token = "0x6000AA9")]
		[Address(RVA = "0xE12324", Offset = "0xE12324", VA = "0xE12324", Slot = "33")]
		public override bool IsAssignableFrom(Type current, Type toCompare)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AAA")]
		[Address(RVA = "0xE12350", Offset = "0xE12350", VA = "0xE12350", Slot = "17")]
		public override bool IsInstanceOfType(Type t, object o)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AAB")]
		[Address(RVA = "0xE1237C", Offset = "0xE1237C", VA = "0xE1237C", Slot = "35")]
		public override MethodInfo GetMethod(Type resourcesType, string name, Type[] types)
		{
			return null;
		}

		[Token(Token = "0x6000AAC")]
		[Address(RVA = "0xE1239C", Offset = "0xE1239C", VA = "0xE1239C", Slot = "28")]
		public override Type[] GetAssemblyTypes(Assembly asm)
		{
			return null;
		}

		[Token(Token = "0x6000AAD")]
		[Address(RVA = "0xE123C0", Offset = "0xE123C0", VA = "0xE123C0")]
		protected FrameworkClrBase()
		{
		}
	}
	[Token(Token = "0x2000164")]
	internal abstract class FrameworkReflectionBase : FrameworkBase
	{
		[Token(Token = "0x6000AAE")]
		public abstract Type GetTypeInfoFromType(Type t);

		[Token(Token = "0x6000AAF")]
		[Address(RVA = "0xE123DC", Offset = "0xE123DC", VA = "0xE123DC", Slot = "6")]
		public override Assembly GetAssembly(Type t)
		{
			return null;
		}

		[Token(Token = "0x6000AB0")]
		[Address(RVA = "0xE1240C", Offset = "0xE1240C", VA = "0xE1240C", Slot = "7")]
		public override Type GetBaseType(Type t)
		{
			return null;
		}

		[Token(Token = "0x6000AB1")]
		[Address(RVA = "0xE1243C", Offset = "0xE1243C", VA = "0xE1243C", Slot = "5")]
		public override bool IsValueType(Type t)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AB2")]
		[Address(RVA = "0xE12464", Offset = "0xE12464", VA = "0xE12464", Slot = "13")]
		public override bool IsInterface(Type t)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AB3")]
		[Address(RVA = "0xE1248C", Offset = "0xE1248C", VA = "0xE1248C", Slot = "11")]
		public override bool IsNestedPublic(Type t)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AB4")]
		[Address(RVA = "0xE124B4", Offset = "0xE124B4", VA = "0xE124B4", Slot = "12")]
		public override bool IsAbstract(Type t)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AB5")]
		[Address(RVA = "0xE124DC", Offset = "0xE124DC", VA = "0xE124DC", Slot = "10")]
		public override bool IsEnum(Type t)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AB6")]
		[Address(RVA = "0xE1250C", Offset = "0xE1250C", VA = "0xE1250C", Slot = "9")]
		public override bool IsGenericTypeDefinition(Type t)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AB7")]
		[Address(RVA = "0xE1253C", Offset = "0xE1253C", VA = "0xE1253C", Slot = "8")]
		public override bool IsGenericType(Type t)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AB8")]
		[Address(RVA = "0xE1256C", Offset = "0xE1256C", VA = "0xE1256C", Slot = "14")]
		public override Attribute[] GetCustomAttributes(Type t, bool inherit)
		{
			return null;
		}

		[Token(Token = "0x6000AB9")]
		[Address(RVA = "0xE12610", Offset = "0xE12610", VA = "0xE12610", Slot = "15")]
		public override Attribute[] GetCustomAttributes(Type t, Type at, bool inherit)
		{
			return null;
		}

		[Token(Token = "0x6000ABA")]
		[Address(RVA = "0xE123D4", Offset = "0xE123D4", VA = "0xE123D4")]
		protected FrameworkReflectionBase()
		{
		}
	}
	[Token(Token = "0x2000165")]
	internal class FrameworkCurrent : FrameworkClrBase
	{
		[Token(Token = "0x6000ABB")]
		[Address(RVA = "0xE126BC", Offset = "0xE126BC", VA = "0xE126BC", Slot = "34")]
		public override bool IsDbNull(object o)
		{
			return default(bool);
		}

		[Token(Token = "0x6000ABC")]
		[Address(RVA = "0xE12728", Offset = "0xE12728", VA = "0xE12728", Slot = "4")]
		public override bool StringContainsChar(string str, char chr)
		{
			return default(bool);
		}

		[Token(Token = "0x6000ABD")]
		[Address(RVA = "0xE12744", Offset = "0xE12744", VA = "0xE12744", Slot = "22")]
		public override Type GetInterface(Type type, string name)
		{
			return null;
		}

		[Token(Token = "0x6000ABE")]
		[Address(RVA = "0xE120D8", Offset = "0xE120D8", VA = "0xE120D8")]
		public FrameworkCurrent()
		{
		}
	}
}
namespace MoonSharp.Interpreter.CodeAnalysis
{
	[Token(Token = "0x2000166")]
	internal class AstNode
	{
		[Token(Token = "0x6000ABF")]
		[Address(RVA = "0xE12760", Offset = "0xE12760", VA = "0xE12760")]
		public AstNode()
		{
		}
	}
}
namespace MoonSharp.VsCodeDebugger
{
	[Token(Token = "0x2000167")]
	public class MoonSharpVsCodeDebugServer : IDisposable
	{
		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private object m_Lock;

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private List<AsyncDebugger> m_DebuggerList;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private AsyncDebugger m_Current;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ManualResetEvent m_StopEvent;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool m_Started;

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int m_Port;

		[Token(Token = "0x1700016B")]
		public int? CurrentId
		{
			[Token(Token = "0x6000AC4")]
			[Address(RVA = "0xE1343C", Offset = "0xE1343C", VA = "0xE1343C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AC5")]
			[Address(RVA = "0xE1354C", Offset = "0xE1354C", VA = "0xE1354C")]
			set
			{
			}
		}

		[Token(Token = "0x1700016C")]
		public Script Current
		{
			[Token(Token = "0x6000AC6")]
			[Address(RVA = "0xE1375C", Offset = "0xE1375C", VA = "0xE1375C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AC7")]
			[Address(RVA = "0xE1382C", Offset = "0xE1382C", VA = "0xE1382C")]
			set
			{
			}
		}

		[Token(Token = "0x1700016D")]
		public Action<string> Logger
		{
			[Token(Token = "0x6000AC9")]
			[Address(RVA = "0xE13F04", Offset = "0xE13F04", VA = "0xE13F04")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000ACA")]
			[Address(RVA = "0xE13F0C", Offset = "0xE13F0C", VA = "0xE13F0C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000AC0")]
		[Address(RVA = "0xE12768", Offset = "0xE12768", VA = "0xE12768")]
		public MoonSharpVsCodeDebugServer(int port = 41912)
		{
		}

		[Token(Token = "0x6000AC1")]
		[Address(RVA = "0xE1285C", Offset = "0xE1285C", VA = "0xE1285C")]
		[Obsolete("Use the constructor taking only a port, and the 'Attach' method instead.")]
		public MoonSharpVsCodeDebugServer(Script script, int port, [Optional] Func<SourceCode, string> sourceFinder)
		{
		}

		[Token(Token = "0x6000AC2")]
		[Address(RVA = "0xE12DE4", Offset = "0xE12DE4", VA = "0xE12DE4")]
		public void AttachToScript(Script script, string name, [Optional] Func<SourceCode, string> sourceFinder)
		{
		}

		[Token(Token = "0x6000AC3")]
		[Address(RVA = "0xE1318C", Offset = "0xE1318C", VA = "0xE1318C")]
		public IEnumerable<KeyValuePair<int, string>> GetAttachedDebuggersByIdAndName()
		{
			return null;
		}

		[Token(Token = "0x6000AC8")]
		[Address(RVA = "0xE13A30", Offset = "0xE13A30", VA = "0xE13A30")]
		public void Detach(Script script)
		{
		}

		[Token(Token = "0x6000ACB")]
		[Address(RVA = "0xE13F14", Offset = "0xE13F14", VA = "0xE13F14")]
		[Obsolete("Use the Attach method instead.")]
		public IDebugger GetDebugger()
		{
			return null;
		}

		[Token(Token = "0x6000ACC")]
		[Address(RVA = "0xE13FD4", Offset = "0xE13FD4", VA = "0xE13FD4", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000ACD")]
		[Address(RVA = "0xE13FF0", Offset = "0xE13FF0", VA = "0xE13FF0")]
		public MoonSharpVsCodeDebugServer Start()
		{
			return null;
		}

		[Token(Token = "0x6000ACE")]
		[Address(RVA = "0xE143E8", Offset = "0xE143E8", VA = "0xE143E8")]
		private void ListenThread(TcpListener serverSocket)
		{
		}

		[Token(Token = "0x6000ACF")]
		[Address(RVA = "0xE14894", Offset = "0xE14894", VA = "0xE14894")]
		private void RunSession(string sessionId, NetworkStream stream)
		{
		}

		[Token(Token = "0x6000AD0")]
		[Address(RVA = "0xE14854", Offset = "0xE14854", VA = "0xE14854")]
		private void Log(string format, params object[] args)
		{
		}

		[Token(Token = "0x6000AD1")]
		[Address(RVA = "0xE142DC", Offset = "0xE142DC", VA = "0xE142DC")]
		private static void SpawnThread(string name, Action threadProc)
		{
		}
	}
}
namespace MoonSharp.VsCodeDebugger.SDK
{
	[Token(Token = "0x2000170")]
	public class Message
	{
		[Token(Token = "0x1700016E")]
		public int id
		{
			[Token(Token = "0x6000AE6")]
			[Address(RVA = "0xE151DC", Offset = "0xE151DC", VA = "0xE151DC")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000AE7")]
			[Address(RVA = "0xE151E4", Offset = "0xE151E4", VA = "0xE151E4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700016F")]
		public string format
		{
			[Token(Token = "0x6000AE8")]
			[Address(RVA = "0xE151EC", Offset = "0xE151EC", VA = "0xE151EC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AE9")]
			[Address(RVA = "0xE151F4", Offset = "0xE151F4", VA = "0xE151F4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000170")]
		public object variables
		{
			[Token(Token = "0x6000AEA")]
			[Address(RVA = "0xE151FC", Offset = "0xE151FC", VA = "0xE151FC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AEB")]
			[Address(RVA = "0xE15204", Offset = "0xE15204", VA = "0xE15204")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000171")]
		public object showUser
		{
			[Token(Token = "0x6000AEC")]
			[Address(RVA = "0xE1520C", Offset = "0xE1520C", VA = "0xE1520C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AED")]
			[Address(RVA = "0xE15214", Offset = "0xE15214", VA = "0xE15214")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000172")]
		public object sendTelemetry
		{
			[Token(Token = "0x6000AEE")]
			[Address(RVA = "0xE1521C", Offset = "0xE1521C", VA = "0xE1521C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AEF")]
			[Address(RVA = "0xE15224", Offset = "0xE15224", VA = "0xE15224")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000AF0")]
		[Address(RVA = "0xE1522C", Offset = "0xE1522C", VA = "0xE1522C")]
		public Message(int id, string format, [Optional] object variables, bool user = true, bool telemetry = false)
		{
		}
	}
	[Token(Token = "0x2000171")]
	public class StackFrame
	{
		[Token(Token = "0x17000173")]
		public int id
		{
			[Token(Token = "0x6000AF1")]
			[Address(RVA = "0xE152D4", Offset = "0xE152D4", VA = "0xE152D4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000AF2")]
			[Address(RVA = "0xE152DC", Offset = "0xE152DC", VA = "0xE152DC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000174")]
		public Source source
		{
			[Token(Token = "0x6000AF3")]
			[Address(RVA = "0xE152E4", Offset = "0xE152E4", VA = "0xE152E4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AF4")]
			[Address(RVA = "0xE152EC", Offset = "0xE152EC", VA = "0xE152EC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000175")]
		public int line
		{
			[Token(Token = "0x6000AF5")]
			[Address(RVA = "0xE152F4", Offset = "0xE152F4", VA = "0xE152F4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000AF6")]
			[Address(RVA = "0xE152FC", Offset = "0xE152FC", VA = "0xE152FC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000176")]
		public int column
		{
			[Token(Token = "0x6000AF7")]
			[Address(RVA = "0xE15304", Offset = "0xE15304", VA = "0xE15304")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000AF8")]
			[Address(RVA = "0xE1530C", Offset = "0xE1530C", VA = "0xE1530C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000177")]
		public string name
		{
			[Token(Token = "0x6000AF9")]
			[Address(RVA = "0xE15314", Offset = "0xE15314", VA = "0xE15314")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AFA")]
			[Address(RVA = "0xE1531C", Offset = "0xE1531C", VA = "0xE1531C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000178")]
		public int? endLine
		{
			[Token(Token = "0x6000AFB")]
			[Address(RVA = "0xE15324", Offset = "0xE15324", VA = "0xE15324")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AFC")]
			[Address(RVA = "0xE1532C", Offset = "0xE1532C", VA = "0xE1532C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000179")]
		public int? endColumn
		{
			[Token(Token = "0x6000AFD")]
			[Address(RVA = "0xE15334", Offset = "0xE15334", VA = "0xE15334")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AFE")]
			[Address(RVA = "0xE1533C", Offset = "0xE1533C", VA = "0xE1533C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000AFF")]
		[Address(RVA = "0xE15344", Offset = "0xE15344", VA = "0xE15344")]
		public StackFrame(int id, string name, Source source, int line, int column = 0, [Optional] int? endLine, [Optional] int? endColumn)
		{
		}
	}
	[Token(Token = "0x2000172")]
	public class Scope
	{
		[Token(Token = "0x1700017A")]
		public string name
		{
			[Token(Token = "0x6000B00")]
			[Address(RVA = "0xE153AC", Offset = "0xE153AC", VA = "0xE153AC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B01")]
			[Address(RVA = "0xE153B4", Offset = "0xE153B4", VA = "0xE153B4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700017B")]
		public int variablesReference
		{
			[Token(Token = "0x6000B02")]
			[Address(RVA = "0xE153BC", Offset = "0xE153BC", VA = "0xE153BC")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000B03")]
			[Address(RVA = "0xE153C4", Offset = "0xE153C4", VA = "0xE153C4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700017C")]
		public bool expensive
		{
			[Token(Token = "0x6000B04")]
			[Address(RVA = "0xE153CC", Offset = "0xE153CC", VA = "0xE153CC")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000B05")]
			[Address(RVA = "0xE153D4", Offset = "0xE153D4", VA = "0xE153D4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000B06")]
		[Address(RVA = "0xE153E0", Offset = "0xE153E0", VA = "0xE153E0")]
		public Scope(string name, int variablesReference, bool expensive = false)
		{
		}
	}
	[Token(Token = "0x2000173")]
	public class Variable
	{
		[Token(Token = "0x1700017D")]
		public string name
		{
			[Token(Token = "0x6000B07")]
			[Address(RVA = "0xE15424", Offset = "0xE15424", VA = "0xE15424")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B08")]
			[Address(RVA = "0xE1542C", Offset = "0xE1542C", VA = "0xE1542C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700017E")]
		public string value
		{
			[Token(Token = "0x6000B09")]
			[Address(RVA = "0xE15434", Offset = "0xE15434", VA = "0xE15434")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B0A")]
			[Address(RVA = "0xE1543C", Offset = "0xE1543C", VA = "0xE1543C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700017F")]
		public int variablesReference
		{
			[Token(Token = "0x6000B0B")]
			[Address(RVA = "0xE15444", Offset = "0xE15444", VA = "0xE15444")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000B0C")]
			[Address(RVA = "0xE1544C", Offset = "0xE1544C", VA = "0xE1544C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000B0D")]
		[Address(RVA = "0xE15454", Offset = "0xE15454", VA = "0xE15454")]
		public Variable(string name, string value, int variablesReference = 0)
		{
		}
	}
	[Token(Token = "0x2000174")]
	public class Thread
	{
		[Token(Token = "0x17000180")]
		public int id
		{
			[Token(Token = "0x6000B0E")]
			[Address(RVA = "0xE15490", Offset = "0xE15490", VA = "0xE15490")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000B0F")]
			[Address(RVA = "0xE15498", Offset = "0xE15498", VA = "0xE15498")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000181")]
		public string name
		{
			[Token(Token = "0x6000B10")]
			[Address(RVA = "0xE154A0", Offset = "0xE154A0", VA = "0xE154A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B11")]
			[Address(RVA = "0xE154A8", Offset = "0xE154A8", VA = "0xE154A8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000B12")]
		[Address(RVA = "0xE154B0", Offset = "0xE154B0", VA = "0xE154B0")]
		public Thread(int id, string name)
		{
		}
	}
	[Token(Token = "0x2000175")]
	public class Source
	{
		[Token(Token = "0x17000182")]
		public string name
		{
			[Token(Token = "0x6000B13")]
			[Address(RVA = "0xE15560", Offset = "0xE15560", VA = "0xE15560")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B14")]
			[Address(RVA = "0xE15568", Offset = "0xE15568", VA = "0xE15568")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000183")]
		public string path
		{
			[Token(Token = "0x6000B15")]
			[Address(RVA = "0xE15570", Offset = "0xE15570", VA = "0xE15570")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B16")]
			[Address(RVA = "0xE15578", Offset = "0xE15578", VA = "0xE15578")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000184")]
		public int sourceReference
		{
			[Token(Token = "0x6000B17")]
			[Address(RVA = "0xE15580", Offset = "0xE15580", VA = "0xE15580")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000B18")]
			[Address(RVA = "0xE15588", Offset = "0xE15588", VA = "0xE15588")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000B19")]
		[Address(RVA = "0xE15590", Offset = "0xE15590", VA = "0xE15590")]
		public Source(string name, string path, int sourceReference = 0)
		{
		}

		[Token(Token = "0x6000B1A")]
		[Address(RVA = "0xE155CC", Offset = "0xE155CC", VA = "0xE155CC")]
		public Source(string path, int sourceReference = 0)
		{
		}
	}
	[Token(Token = "0x2000176")]
	public class Breakpoint
	{
		[Token(Token = "0x17000185")]
		public bool verified
		{
			[Token(Token = "0x6000B1B")]
			[Address(RVA = "0xE1564C", Offset = "0xE1564C", VA = "0xE1564C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000B1C")]
			[Address(RVA = "0xE15654", Offset = "0xE15654", VA = "0xE15654")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000186")]
		public int line
		{
			[Token(Token = "0x6000B1D")]
			[Address(RVA = "0xE15660", Offset = "0xE15660", VA = "0xE15660")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000B1E")]
			[Address(RVA = "0xE15668", Offset = "0xE15668", VA = "0xE15668")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000B1F")]
		[Address(RVA = "0xE15670", Offset = "0xE15670", VA = "0xE15670")]
		public Breakpoint(bool verified, int line)
		{
		}
	}
	[Token(Token = "0x2000177")]
	public class InitializedEvent : Event
	{
		[Token(Token = "0x6000B20")]
		[Address(RVA = "0xE156A4", Offset = "0xE156A4", VA = "0xE156A4")]
		public InitializedEvent()
		{
		}
	}
	[Token(Token = "0x2000178")]
	public class StoppedEvent : Event
	{
		[Token(Token = "0x6000B21")]
		[Address(RVA = "0xE15758", Offset = "0xE15758", VA = "0xE15758")]
		public StoppedEvent(int tid, string reasn, [Optional] string txt)
		{
		}
	}
	[Token(Token = "0x2000179")]
	public class ExitedEvent : Event
	{
		[Token(Token = "0x6000B22")]
		[Address(RVA = "0xE15810", Offset = "0xE15810", VA = "0xE15810")]
		public ExitedEvent(int exCode)
		{
		}
	}
	[Token(Token = "0x200017A")]
	public class TerminatedEvent : Event
	{
		[Token(Token = "0x6000B23")]
		[Address(RVA = "0xE158B0", Offset = "0xE158B0", VA = "0xE158B0")]
		public TerminatedEvent()
		{
		}
	}
	[Token(Token = "0x200017B")]
	public class ThreadEvent : Event
	{
		[Token(Token = "0x6000B24")]
		[Address(RVA = "0xE158FC", Offset = "0xE158FC", VA = "0xE158FC")]
		public ThreadEvent(string reasn, int tid)
		{
		}
	}
	[Token(Token = "0x200017C")]
	public class OutputEvent : Event
	{
		[Token(Token = "0x6000B25")]
		[Address(RVA = "0xE159A4", Offset = "0xE159A4", VA = "0xE159A4")]
		public OutputEvent(string cat, string outpt)
		{
		}
	}
	[Token(Token = "0x200017D")]
	public class Capabilities : ResponseBody
	{
		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool supportsConfigurationDoneRequest;

		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public bool supportsFunctionBreakpoints;

		[Token(Token = "0x40004C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		public bool supportsConditionalBreakpoints;

		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13")]
		public bool supportsEvaluateForHovers;

		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public object[] exceptionBreakpointFilters;

		[Token(Token = "0x6000B26")]
		[Address(RVA = "0xE15A4C", Offset = "0xE15A4C", VA = "0xE15A4C")]
		public Capabilities()
		{
		}
	}
	[Token(Token = "0x200017E")]
	public class ErrorResponseBody : ResponseBody
	{
		[Token(Token = "0x17000187")]
		public Message error
		{
			[Token(Token = "0x6000B27")]
			[Address(RVA = "0xE15A5C", Offset = "0xE15A5C", VA = "0xE15A5C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B28")]
			[Address(RVA = "0xE15A64", Offset = "0xE15A64", VA = "0xE15A64")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000B29")]
		[Address(RVA = "0xE15A6C", Offset = "0xE15A6C", VA = "0xE15A6C")]
		public ErrorResponseBody(Message error)
		{
		}
	}
	[Token(Token = "0x200017F")]
	public class StackTraceResponseBody : ResponseBody
	{
		[Token(Token = "0x17000188")]
		public StackFrame[] stackFrames
		{
			[Token(Token = "0x6000B2A")]
			[Address(RVA = "0xE15A94", Offset = "0xE15A94", VA = "0xE15A94")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B2B")]
			[Address(RVA = "0xE15A9C", Offset = "0xE15A9C", VA = "0xE15A9C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000B2C")]
		[Address(RVA = "0xE15AA4", Offset = "0xE15AA4", VA = "0xE15AA4")]
		public StackTraceResponseBody([Optional] List<StackFrame> frames)
		{
		}
	}
	[Token(Token = "0x2000180")]
	public class ScopesResponseBody : ResponseBody
	{
		[Token(Token = "0x17000189")]
		public Scope[] scopes
		{
			[Token(Token = "0x6000B2D")]
			[Address(RVA = "0xE15B2C", Offset = "0xE15B2C", VA = "0xE15B2C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B2E")]
			[Address(RVA = "0xE15B34", Offset = "0xE15B34", VA = "0xE15B34")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000B2F")]
		[Address(RVA = "0xE15B3C", Offset = "0xE15B3C", VA = "0xE15B3C")]
		public ScopesResponseBody([Optional] List<Scope> scps)
		{
		}
	}
	[Token(Token = "0x2000181")]
	public class VariablesResponseBody : ResponseBody
	{
		[Token(Token = "0x1700018A")]
		public Variable[] variables
		{
			[Token(Token = "0x6000B30")]
			[Address(RVA = "0xE15BC4", Offset = "0xE15BC4", VA = "0xE15BC4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B31")]
			[Address(RVA = "0xE15BCC", Offset = "0xE15BCC", VA = "0xE15BCC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000B32")]
		[Address(RVA = "0xE15BD4", Offset = "0xE15BD4", VA = "0xE15BD4")]
		public VariablesResponseBody([Optional] List<Variable> vars)
		{
		}
	}
	[Token(Token = "0x2000182")]
	public class ThreadsResponseBody : ResponseBody
	{
		[Token(Token = "0x1700018B")]
		public Thread[] threads
		{
			[Token(Token = "0x6000B33")]
			[Address(RVA = "0xE15C5C", Offset = "0xE15C5C", VA = "0xE15C5C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B34")]
			[Address(RVA = "0xE15C64", Offset = "0xE15C64", VA = "0xE15C64")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000B35")]
		[Address(RVA = "0xE15C6C", Offset = "0xE15C6C", VA = "0xE15C6C")]
		public ThreadsResponseBody([Optional] List<Thread> vars)
		{
		}
	}
	[Token(Token = "0x2000183")]
	public class EvaluateResponseBody : ResponseBody
	{
		[Token(Token = "0x1700018C")]
		public string result
		{
			[Token(Token = "0x6000B36")]
			[Address(RVA = "0xE15CF4", Offset = "0xE15CF4", VA = "0xE15CF4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B37")]
			[Address(RVA = "0xE15CFC", Offset = "0xE15CFC", VA = "0xE15CFC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700018D")]
		public string type
		{
			[Token(Token = "0x6000B38")]
			[Address(RVA = "0xE15D04", Offset = "0xE15D04", VA = "0xE15D04")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B39")]
			[Address(RVA = "0xE15D0C", Offset = "0xE15D0C", VA = "0xE15D0C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700018E")]
		public int variablesReference
		{
			[Token(Token = "0x6000B3A")]
			[Address(RVA = "0xE15D14", Offset = "0xE15D14", VA = "0xE15D14")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000B3B")]
			[Address(RVA = "0xE15D1C", Offset = "0xE15D1C", VA = "0xE15D1C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000B3C")]
		[Address(RVA = "0xE15D24", Offset = "0xE15D24", VA = "0xE15D24")]
		public EvaluateResponseBody(string value, int reff = 0)
		{
		}
	}
	[Token(Token = "0x2000184")]
	public class SetBreakpointsResponseBody : ResponseBody
	{
		[Token(Token = "0x1700018F")]
		public Breakpoint[] breakpoints
		{
			[Token(Token = "0x6000B3D")]
			[Address(RVA = "0xE15D54", Offset = "0xE15D54", VA = "0xE15D54")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B3E")]
			[Address(RVA = "0xE15D5C", Offset = "0xE15D5C", VA = "0xE15D5C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000B3F")]
		[Address(RVA = "0xE15D64", Offset = "0xE15D64", VA = "0xE15D64")]
		public SetBreakpointsResponseBody([Optional] List<Breakpoint> bpts)
		{
		}
	}
	[Token(Token = "0x2000185")]
	public abstract class DebugSession : ProtocolServer
	{
		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		private bool _debuggerLinesStartAt1;

		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E")]
		private bool _debuggerPathsAreURI;

		[Token(Token = "0x40004D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F")]
		private bool _clientLinesStartAt1;

		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool _clientPathsAreURI;

		[Token(Token = "0x6000B40")]
		[Address(RVA = "0xE15DEC", Offset = "0xE15DEC", VA = "0xE15DEC")]
		public DebugSession(bool debuggerLinesStartAt1, bool debuggerPathsAreURI = false)
		{
		}

		[Token(Token = "0x6000B41")]
		[Address(RVA = "0xE15EDC", Offset = "0xE15EDC", VA = "0xE15EDC")]
		public void SendResponse(Response response, [Optional] ResponseBody body)
		{
		}

		[Token(Token = "0x6000B42")]
		[Address(RVA = "0xE16254", Offset = "0xE16254", VA = "0xE16254")]
		public void SendErrorResponse(Response response, int id, string format, [Optional] object arguments, bool user = true, bool telemetry = false)
		{
		}

		[Token(Token = "0x6000B43")]
		[Address(RVA = "0xE164D8", Offset = "0xE164D8", VA = "0xE164D8", Slot = "4")]
		protected override void DispatchRequest(string command, Table args, Response response)
		{
		}

		[Token(Token = "0x6000B44")]
		public abstract void Initialize(Response response, Table args);

		[Token(Token = "0x6000B45")]
		public abstract void Launch(Response response, Table arguments);

		[Token(Token = "0x6000B46")]
		public abstract void Attach(Response response, Table arguments);

		[Token(Token = "0x6000B47")]
		public abstract void Disconnect(Response response, Table arguments);

		[Token(Token = "0x6000B48")]
		[Address(RVA = "0xE1704C", Offset = "0xE1704C", VA = "0xE1704C", Slot = "9")]
		public virtual void SetFunctionBreakpoints(Response response, Table arguments)
		{
		}

		[Token(Token = "0x6000B49")]
		[Address(RVA = "0xE17050", Offset = "0xE17050", VA = "0xE17050", Slot = "10")]
		public virtual void SetExceptionBreakpoints(Response response, Table arguments)
		{
		}

		[Token(Token = "0x6000B4A")]
		public abstract void SetBreakpoints(Response response, Table arguments);

		[Token(Token = "0x6000B4B")]
		public abstract void Continue(Response response, Table arguments);

		[Token(Token = "0x6000B4C")]
		public abstract void Next(Response response, Table arguments);

		[Token(Token = "0x6000B4D")]
		public abstract void StepIn(Response response, Table arguments);

		[Token(Token = "0x6000B4E")]
		public abstract void StepOut(Response response, Table arguments);

		[Token(Token = "0x6000B4F")]
		public abstract void Pause(Response response, Table arguments);

		[Token(Token = "0x6000B50")]
		public abstract void StackTrace(Response response, Table arguments);

		[Token(Token = "0x6000B51")]
		public abstract void Scopes(Response response, Table arguments);

		[Token(Token = "0x6000B52")]
		public abstract void Variables(Response response, Table arguments);

		[Token(Token = "0x6000B53")]
		[Address(RVA = "0xE17054", Offset = "0xE17054", VA = "0xE17054", Slot = "20")]
		public virtual void Source(Response response, Table arguments)
		{
		}

		[Token(Token = "0x6000B54")]
		public abstract void Threads(Response response, Table arguments);

		[Token(Token = "0x6000B55")]
		public abstract void Evaluate(Response response, Table arguments);

		[Token(Token = "0x6000B56")]
		[Address(RVA = "0xE170BC", Offset = "0xE170BC", VA = "0xE170BC")]
		protected int ConvertDebuggerLineToClient(int line)
		{
			return default(int);
		}

		[Token(Token = "0x6000B57")]
		[Address(RVA = "0xE170DC", Offset = "0xE170DC", VA = "0xE170DC")]
		protected int ConvertClientLineToDebugger(int line)
		{
			return default(int);
		}

		[Token(Token = "0x6000B58")]
		[Address(RVA = "0xE170FC", Offset = "0xE170FC", VA = "0xE170FC")]
		protected string ConvertDebuggerPathToClient(string path)
		{
			return null;
		}

		[Token(Token = "0x6000B59")]
		[Address(RVA = "0xE17238", Offset = "0xE17238", VA = "0xE17238")]
		protected string ConvertClientPathToDebugger(string clientPath)
		{
			return null;
		}
	}
	[Token(Token = "0x2000186")]
	public class ProtocolMessage
	{
		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int seq;

		[Token(Token = "0x17000190")]
		public string type
		{
			[Token(Token = "0x6000B5A")]
			[Address(RVA = "0xE173B4", Offset = "0xE173B4", VA = "0xE173B4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B5B")]
			[Address(RVA = "0xE173BC", Offset = "0xE173BC", VA = "0xE173BC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000B5C")]
		[Address(RVA = "0xE173C4", Offset = "0xE173C4", VA = "0xE173C4")]
		public ProtocolMessage(string typ)
		{
		}

		[Token(Token = "0x6000B5D")]
		[Address(RVA = "0xE173EC", Offset = "0xE173EC", VA = "0xE173EC")]
		public ProtocolMessage(string typ, int sq)
		{
		}
	}
	[Token(Token = "0x2000187")]
	public class Request : ProtocolMessage
	{
		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string command;

		[Token(Token = "0x40004D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Table arguments;

		[Token(Token = "0x6000B5E")]
		[Address(RVA = "0xE1741C", Offset = "0xE1741C", VA = "0xE1741C")]
		public Request(int id, string cmd, Table arg)
		{
		}
	}
	[Token(Token = "0x2000188")]
	public class ResponseBody
	{
		[Token(Token = "0x6000B5F")]
		[Address(RVA = "0xE15A54", Offset = "0xE15A54", VA = "0xE15A54")]
		public ResponseBody()
		{
		}
	}
	[Token(Token = "0x2000189")]
	public class Response : ProtocolMessage
	{
		[Token(Token = "0x17000191")]
		public bool success
		{
			[Token(Token = "0x6000B60")]
			[Address(RVA = "0xE17494", Offset = "0xE17494", VA = "0xE17494")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000B61")]
			[Address(RVA = "0xE1749C", Offset = "0xE1749C", VA = "0xE1749C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000192")]
		public string message
		{
			[Token(Token = "0x6000B62")]
			[Address(RVA = "0xE174A8", Offset = "0xE174A8", VA = "0xE174A8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B63")]
			[Address(RVA = "0xE174B0", Offset = "0xE174B0", VA = "0xE174B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000193")]
		public int request_seq
		{
			[Token(Token = "0x6000B64")]
			[Address(RVA = "0xE174B8", Offset = "0xE174B8", VA = "0xE174B8")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000B65")]
			[Address(RVA = "0xE174C0", Offset = "0xE174C0", VA = "0xE174C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000194")]
		public string command
		{
			[Token(Token = "0x6000B66")]
			[Address(RVA = "0xE174C8", Offset = "0xE174C8", VA = "0xE174C8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B67")]
			[Address(RVA = "0xE174D0", Offset = "0xE174D0", VA = "0xE174D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000195")]
		public ResponseBody body
		{
			[Token(Token = "0x6000B68")]
			[Address(RVA = "0xE174D8", Offset = "0xE174D8", VA = "0xE174D8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B69")]
			[Address(RVA = "0xE174E0", Offset = "0xE174E0", VA = "0xE174E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000B6A")]
		[Address(RVA = "0xE174E8", Offset = "0xE174E8", VA = "0xE174E8")]
		public Response(Table req)
		{
		}

		[Token(Token = "0x6000B6B")]
		[Address(RVA = "0xE15F00", Offset = "0xE15F00", VA = "0xE15F00")]
		public void SetBody(ResponseBody bdy)
		{
		}

		[Token(Token = "0x6000B6C")]
		[Address(RVA = "0xE164C8", Offset = "0xE164C8", VA = "0xE164C8")]
		public void SetErrorBody(string msg, [Optional] ResponseBody bdy)
		{
		}
	}
	[Token(Token = "0x200018A")]
	public class Event : ProtocolMessage
	{
		[Token(Token = "0x17000196")]
		public string @event
		{
			[Token(Token = "0x6000B6D")]
			[Address(RVA = "0xE175E8", Offset = "0xE175E8", VA = "0xE175E8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B6E")]
			[Address(RVA = "0xE175F0", Offset = "0xE175F0", VA = "0xE175F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000197")]
		public object body
		{
			[Token(Token = "0x6000B6F")]
			[Address(RVA = "0xE175F8", Offset = "0xE175F8", VA = "0xE175F8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B70")]
			[Address(RVA = "0xE17600", Offset = "0xE17600", VA = "0xE17600")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000B71")]
		[Address(RVA = "0xE156F0", Offset = "0xE156F0", VA = "0xE156F0")]
		public Event(string type, [Optional] object bdy)
		{
		}
	}
	[Token(Token = "0x200018B")]
	public abstract class ProtocolServer
	{
		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool TRACE;

		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public bool TRACE_RESPONSE;

		[Token(Token = "0x40004E1")]
		protected const int BUFFER_SIZE = 4096;

		[Token(Token = "0x40004E2")]
		protected const string TWO_CRLF = "\r\n\r\n";

		[Token(Token = "0x40004E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected static readonly Regex CONTENT_LENGTH_MATCHER;

		[Token(Token = "0x40004E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		protected static readonly Encoding Encoding;

		[Token(Token = "0x40004E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private int _sequenceNumber;

		[Token(Token = "0x40004E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Stream _outputStream;

		[Token(Token = "0x40004E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ByteBuffer _rawData;

		[Token(Token = "0x40004E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int _bodyLength;

		[Token(Token = "0x40004E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private bool _stopRequested;

		[Token(Token = "0x6000B72")]
		[Address(RVA = "0xE15E64", Offset = "0xE15E64", VA = "0xE15E64")]
		public ProtocolServer()
		{
		}

		[Token(Token = "0x6000B73")]
		[Address(RVA = "0xE14B30", Offset = "0xE14B30", VA = "0xE14B30")]
		public void ProcessLoop(Stream inputStream, Stream outputStream)
		{
		}

		[Token(Token = "0x6000B74")]
		[Address(RVA = "0xE17040", Offset = "0xE17040", VA = "0xE17040")]
		public void Stop()
		{
		}

		[Token(Token = "0x6000B75")]
		[Address(RVA = "0xE17950", Offset = "0xE17950", VA = "0xE17950")]
		public void SendEvent(Event e)
		{
		}

		[Token(Token = "0x6000B76")]
		protected abstract void DispatchRequest(string command, Table args, Response response);

		[Token(Token = "0x6000B77")]
		[Address(RVA = "0xE17720", Offset = "0xE17720", VA = "0xE17720")]
		private void ProcessData()
		{
		}

		[Token(Token = "0x6000B78")]
		[Address(RVA = "0xE17A3C", Offset = "0xE17A3C", VA = "0xE17A3C")]
		private void Dispatch(string req)
		{
		}

		[Token(Token = "0x6000B79")]
		[Address(RVA = "0xE15F10", Offset = "0xE15F10", VA = "0xE15F10")]
		protected void SendMessage(ProtocolMessage message)
		{
		}

		[Token(Token = "0x6000B7A")]
		[Address(RVA = "0xE17D58", Offset = "0xE17D58", VA = "0xE17D58")]
		private static byte[] ConvertToBytes(ProtocolMessage request)
		{
			return null;
		}
	}
	[Token(Token = "0x200018C")]
	internal class ByteBuffer
	{
		[Token(Token = "0x40004EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private byte[] _buffer;

		[Token(Token = "0x17000198")]
		public int Length
		{
			[Token(Token = "0x6000B7D")]
			[Address(RVA = "0xE17954", Offset = "0xE17954", VA = "0xE17954")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000B7C")]
		[Address(RVA = "0xE17608", Offset = "0xE17608", VA = "0xE17608")]
		public ByteBuffer()
		{
		}

		[Token(Token = "0x6000B7E")]
		[Address(RVA = "0xE17D2C", Offset = "0xE17D2C", VA = "0xE17D2C")]
		public string GetString(Encoding enc)
		{
			return null;
		}

		[Token(Token = "0x6000B7F")]
		[Address(RVA = "0xE17664", Offset = "0xE17664", VA = "0xE17664")]
		public void Append(byte[] b, int length)
		{
		}

		[Token(Token = "0x6000B80")]
		[Address(RVA = "0xE17970", Offset = "0xE17970", VA = "0xE17970")]
		public byte[] RemoveFirst(int n)
		{
			return null;
		}
	}
	[Token(Token = "0x200018D")]
	internal class Utilities
	{
		[Token(Token = "0x40004EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Regex VARIABLE;

		[Token(Token = "0x6000B81")]
		[Address(RVA = "0xE16380", Offset = "0xE16380", VA = "0xE16380")]
		public static string ExpandVariables(string format, object variables, bool underscoredOnly = true)
		{
			return null;
		}

		[Token(Token = "0x6000B82")]
		[Address(RVA = "0xE17FA0", Offset = "0xE17FA0", VA = "0xE17FA0")]
		public static string MakeRelativePath(string dirPath, string absPath)
		{
			return null;
		}

		[Token(Token = "0x6000B83")]
		[Address(RVA = "0xE18060", Offset = "0xE18060", VA = "0xE18060")]
		public Utilities()
		{
		}
	}
}
namespace MoonSharp.VsCodeDebugger.DebuggerLogic
{
	[Token(Token = "0x200018F")]
	internal class AsyncDebugger : IDebugger
	{
		[Token(Token = "0x40004EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static object s_AsyncDebuggerIdLock;

		[Token(Token = "0x40004F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static int s_AsyncDebuggerIdCounter;

		[Token(Token = "0x40004F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private object m_Lock;

		[Token(Token = "0x40004F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private IAsyncDebuggerClient m_Client__;

		[Token(Token = "0x40004F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private DebuggerAction m_PendingAction;

		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<WatchItem>[] m_WatchItems;

		[Token(Token = "0x40004F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Dictionary<int, SourceCode> m_SourcesMap;

		[Token(Token = "0x40004F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Dictionary<int, string> m_SourcesOverride;

		[Token(Token = "0x40004F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Func<SourceCode, string> m_SourceFinder;

		[Token(Token = "0x17000199")]
		public DebugService DebugService
		{
			[Token(Token = "0x6000B87")]
			[Address(RVA = "0xE182D8", Offset = "0xE182D8", VA = "0xE182D8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B88")]
			[Address(RVA = "0xE182E0", Offset = "0xE182E0", VA = "0xE182E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700019A")]
		public Regex ErrorRegex
		{
			[Token(Token = "0x6000B89")]
			[Address(RVA = "0xE182E8", Offset = "0xE182E8", VA = "0xE182E8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B8A")]
			[Address(RVA = "0xE182F0", Offset = "0xE182F0", VA = "0xE182F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700019B")]
		public Script Script
		{
			[Token(Token = "0x6000B8B")]
			[Address(RVA = "0xE182F8", Offset = "0xE182F8", VA = "0xE182F8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B8C")]
			[Address(RVA = "0xE18300", Offset = "0xE18300", VA = "0xE18300")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700019C")]
		public bool PauseRequested
		{
			[Token(Token = "0x6000B8D")]
			[Address(RVA = "0xE18308", Offset = "0xE18308", VA = "0xE18308")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000B8E")]
			[Address(RVA = "0xE18310", Offset = "0xE18310", VA = "0xE18310")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700019D")]
		public string Name
		{
			[Token(Token = "0x6000B8F")]
			[Address(RVA = "0xE1831C", Offset = "0xE1831C", VA = "0xE1831C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B90")]
			[Address(RVA = "0xE18324", Offset = "0xE18324", VA = "0xE18324")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700019E")]
		public int Id
		{
			[Token(Token = "0x6000B91")]
			[Address(RVA = "0xE1832C", Offset = "0xE1832C", VA = "0xE1832C")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000B92")]
			[Address(RVA = "0xE18334", Offset = "0xE18334", VA = "0xE18334")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700019F")]
		public IAsyncDebuggerClient Client
		{
			[Token(Token = "0x6000B94")]
			[Address(RVA = "0xE1833C", Offset = "0xE1833C", VA = "0xE1833C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B95")]
			[Address(RVA = "0xE13CD4", Offset = "0xE13CD4", VA = "0xE13CD4")]
			set
			{
			}
		}

		[Token(Token = "0x6000B93")]
		[Address(RVA = "0xE12ACC", Offset = "0xE12ACC", VA = "0xE12ACC")]
		public AsyncDebugger(Script script, Func<SourceCode, string> sourceFinder, string name)
		{
		}

		[Token(Token = "0x6000B96")]
		[Address(RVA = "0xE18344", Offset = "0xE18344", VA = "0xE18344", Slot = "10")]
		private DebuggerAction MoonSharp.Interpreter.Debugging.IDebugger.GetAction(int ip, SourceRef sourceref)
		{
			return null;
		}

		[Token(Token = "0x6000B97")]
		[Address(RVA = "0xE185E4", Offset = "0xE185E4", VA = "0xE185E4")]
		public void QueueAction(DebuggerAction action)
		{
		}

		[Token(Token = "0x6000B98")]
		[Address(RVA = "0xE185D8", Offset = "0xE185D8", VA = "0xE185D8")]
		private void Sleep(int v)
		{
		}

		[Token(Token = "0x6000B99")]
		[Address(RVA = "0xE186E4", Offset = "0xE186E4", VA = "0xE186E4")]
		private DynamicExpression CreateDynExpr(string code)
		{
			return null;
		}

		[Token(Token = "0x6000B9A")]
		[Address(RVA = "0xE187F0", Offset = "0xE187F0", VA = "0xE187F0", Slot = "13")]
		private List<DynamicExpression> MoonSharp.Interpreter.Debugging.IDebugger.GetWatchItems()
		{
			return null;
		}

		[Token(Token = "0x6000B9B")]
		[Address(RVA = "0xE18860", Offset = "0xE18860", VA = "0xE18860", Slot = "8")]
		private bool MoonSharp.Interpreter.Debugging.IDebugger.IsPauseRequested()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B9C")]
		[Address(RVA = "0xE18868", Offset = "0xE18868", VA = "0xE18868", Slot = "14")]
		private void MoonSharp.Interpreter.Debugging.IDebugger.RefreshBreakpoints(IEnumerable<SourceRef> refs)
		{
		}

		[Token(Token = "0x6000B9D")]
		[Address(RVA = "0xE1886C", Offset = "0xE1886C", VA = "0xE1886C", Slot = "7")]
		private void MoonSharp.Interpreter.Debugging.IDebugger.SetByteCode(string[] byteCode)
		{
		}

		[Token(Token = "0x6000B9E")]
		[Address(RVA = "0xE18870", Offset = "0xE18870", VA = "0xE18870", Slot = "6")]
		private void MoonSharp.Interpreter.Debugging.IDebugger.SetSourceCode(SourceCode sourceCode)
		{
		}

		[Token(Token = "0x6000B9F")]
		[Address(RVA = "0xE18BD4", Offset = "0xE18BD4", VA = "0xE18BD4")]
		private string GetFooterForTempFile()
		{
			return null;
		}

		[Token(Token = "0x6000BA0")]
		[Address(RVA = "0xE18C14", Offset = "0xE18C14", VA = "0xE18C14")]
		public string GetSourceFile(int sourceId)
		{
			return null;
		}

		[Token(Token = "0x6000BA1")]
		[Address(RVA = "0xE18D08", Offset = "0xE18D08", VA = "0xE18D08")]
		public bool IsSourceOverride(int sourceId)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BA2")]
		[Address(RVA = "0xE18D60", Offset = "0xE18D60", VA = "0xE18D60", Slot = "11")]
		private void MoonSharp.Interpreter.Debugging.IDebugger.SignalExecutionEnded()
		{
		}

		[Token(Token = "0x6000BA3")]
		[Address(RVA = "0xE18EA4", Offset = "0xE18EA4", VA = "0xE18EA4", Slot = "9")]
		private bool MoonSharp.Interpreter.Debugging.IDebugger.SignalRuntimeException(ScriptRuntimeException ex)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BA4")]
		[Address(RVA = "0xE19058", Offset = "0xE19058", VA = "0xE19058", Slot = "12")]
		private void MoonSharp.Interpreter.Debugging.IDebugger.Update(WatchType watchType, IEnumerable<WatchItem> items)
		{
		}

		[Token(Token = "0x6000BA5")]
		[Address(RVA = "0xE19230", Offset = "0xE19230", VA = "0xE19230")]
		public List<WatchItem> GetWatches(WatchType watchType)
		{
			return null;
		}

		[Token(Token = "0x6000BA6")]
		[Address(RVA = "0xE19260", Offset = "0xE19260", VA = "0xE19260")]
		public SourceCode GetSource(int id)
		{
			return null;
		}

		[Token(Token = "0x6000BA7")]
		[Address(RVA = "0xE192F4", Offset = "0xE192F4", VA = "0xE192F4")]
		public SourceCode FindSourceByName(string path)
		{
			return null;
		}

		[Token(Token = "0x6000BA8")]
		[Address(RVA = "0xE19610", Offset = "0xE19610", VA = "0xE19610", Slot = "5")]
		private void MoonSharp.Interpreter.Debugging.IDebugger.SetDebugService(DebugService debugService)
		{
		}

		[Token(Token = "0x6000BA9")]
		[Address(RVA = "0xE19618", Offset = "0xE19618", VA = "0xE19618")]
		public DynValue Evaluate(string expression)
		{
			return null;
		}

		[Token(Token = "0x6000BAA")]
		[Address(RVA = "0xE19638", Offset = "0xE19638", VA = "0xE19638", Slot = "4")]
		private DebuggerCaps MoonSharp.Interpreter.Debugging.IDebugger.GetDebuggerCaps()
		{
			return default(DebuggerCaps);
		}
	}
	[Token(Token = "0x2000191")]
	internal class EmptyDebugSession : DebugSession
	{
		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private MoonSharpVsCodeDebugServer m_Server;

		[Token(Token = "0x6000BAE")]
		[Address(RVA = "0xE14B04", Offset = "0xE14B04", VA = "0xE14B04")]
		internal EmptyDebugSession(MoonSharpVsCodeDebugServer server)
		{
		}

		[Token(Token = "0x6000BAF")]
		[Address(RVA = "0xE19708", Offset = "0xE19708", VA = "0xE19708", Slot = "5")]
		public override void Initialize(Response response, Table args)
		{
		}

		[Token(Token = "0x6000BB0")]
		[Address(RVA = "0xE19B60", Offset = "0xE19B60", VA = "0xE19B60")]
		private void SendList()
		{
		}

		[Token(Token = "0x6000BB1")]
		[Address(RVA = "0xE1A15C", Offset = "0xE1A15C", VA = "0xE1A15C", Slot = "7")]
		public override void Attach(Response response, Table arguments)
		{
		}

		[Token(Token = "0x6000BB2")]
		[Address(RVA = "0xE1A160", Offset = "0xE1A160", VA = "0xE1A160", Slot = "12")]
		public override void Continue(Response response, Table arguments)
		{
		}

		[Token(Token = "0x6000BB3")]
		[Address(RVA = "0xE1A188", Offset = "0xE1A188", VA = "0xE1A188", Slot = "8")]
		public override void Disconnect(Response response, Table arguments)
		{
		}

		[Token(Token = "0x6000BB4")]
		[Address(RVA = "0xE1A18C", Offset = "0xE1A18C", VA = "0xE1A18C")]
		private static string getString(Table args, string property, [Optional] string dflt)
		{
			return null;
		}

		[Token(Token = "0x6000BB5")]
		[Address(RVA = "0xE1A22C", Offset = "0xE1A22C", VA = "0xE1A22C", Slot = "22")]
		public override void Evaluate(Response response, Table args)
		{
		}

		[Token(Token = "0x6000BB6")]
		[Address(RVA = "0xE1A31C", Offset = "0xE1A31C", VA = "0xE1A31C")]
		private void ExecuteRepl(string cmd)
		{
		}

		[Token(Token = "0x6000BB7")]
		[Address(RVA = "0xE1A508", Offset = "0xE1A508", VA = "0xE1A508", Slot = "6")]
		public override void Launch(Response response, Table arguments)
		{
		}

		[Token(Token = "0x6000BB8")]
		[Address(RVA = "0xE1A50C", Offset = "0xE1A50C", VA = "0xE1A50C", Slot = "13")]
		public override void Next(Response response, Table arguments)
		{
		}

		[Token(Token = "0x6000BB9")]
		[Address(RVA = "0xE1A534", Offset = "0xE1A534", VA = "0xE1A534", Slot = "16")]
		public override void Pause(Response response, Table arguments)
		{
		}

		[Token(Token = "0x6000BBA")]
		[Address(RVA = "0xE1A55C", Offset = "0xE1A55C", VA = "0xE1A55C", Slot = "18")]
		public override void Scopes(Response response, Table arguments)
		{
		}

		[Token(Token = "0x6000BBB")]
		[Address(RVA = "0xE1A560", Offset = "0xE1A560", VA = "0xE1A560", Slot = "11")]
		public override void SetBreakpoints(Response response, Table args)
		{
		}

		[Token(Token = "0x6000BBC")]
		[Address(RVA = "0xE1A564", Offset = "0xE1A564", VA = "0xE1A564", Slot = "17")]
		public override void StackTrace(Response response, Table args)
		{
		}

		[Token(Token = "0x6000BBD")]
		[Address(RVA = "0xE1A568", Offset = "0xE1A568", VA = "0xE1A568", Slot = "14")]
		public override void StepIn(Response response, Table arguments)
		{
		}

		[Token(Token = "0x6000BBE")]
		[Address(RVA = "0xE1A590", Offset = "0xE1A590", VA = "0xE1A590", Slot = "15")]
		public override void StepOut(Response response, Table arguments)
		{
		}

		[Token(Token = "0x6000BBF")]
		[Address(RVA = "0xE1A5B8", Offset = "0xE1A5B8", VA = "0xE1A5B8", Slot = "21")]
		public override void Threads(Response response, Table arguments)
		{
		}

		[Token(Token = "0x6000BC0")]
		[Address(RVA = "0xE1A71C", Offset = "0xE1A71C", VA = "0xE1A71C", Slot = "19")]
		public override void Variables(Response response, Table arguments)
		{
		}

		[Token(Token = "0x6000BC1")]
		[Address(RVA = "0xE19A94", Offset = "0xE19A94", VA = "0xE19A94")]
		private void SendText(string msg, params object[] args)
		{
		}

		[Token(Token = "0x6000BC2")]
		[Address(RVA = "0xE1A434", Offset = "0xE1A434", VA = "0xE1A434")]
		public void Unbind()
		{
		}
	}
	[Token(Token = "0x2000192")]
	internal interface IAsyncDebuggerClient
	{
		[Token(Token = "0x6000BC3")]
		void SendStopEvent();

		[Token(Token = "0x6000BC4")]
		void OnWatchesUpdated(WatchType watchType);

		[Token(Token = "0x6000BC5")]
		void OnSourceCodeChanged(int sourceID);

		[Token(Token = "0x6000BC6")]
		void OnExecutionEnded();

		[Token(Token = "0x6000BC7")]
		void OnException(ScriptRuntimeException ex);

		[Token(Token = "0x6000BC8")]
		void Unbind();
	}
	[Token(Token = "0x2000193")]
	internal class MoonSharpDebugSession : DebugSession, IAsyncDebuggerClient
	{
		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private AsyncDebugger m_Debug;

		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private MoonSharpVsCodeDebugServer m_Server;

		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<DynValue> m_Variables;

		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool m_NotifyExecutionEnd;

		[Token(Token = "0x4000504")]
		private const int SCOPE_LOCALS = 65536;

		[Token(Token = "0x4000505")]
		private const int SCOPE_SELF = 65537;

		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private readonly SourceRef DefaultSourceRef;

		[Token(Token = "0x6000BC9")]
		[Address(RVA = "0xE14A24", Offset = "0xE14A24", VA = "0xE14A24")]
		internal MoonSharpDebugSession(MoonSharpVsCodeDebugServer server, AsyncDebugger debugger)
		{
		}

		[Token(Token = "0x6000BCA")]
		[Address(RVA = "0xE1A720", Offset = "0xE1A720", VA = "0xE1A720", Slot = "5")]
		public override void Initialize(Response response, Table args)
		{
		}

		[Token(Token = "0x6000BCB")]
		[Address(RVA = "0xE1ABE8", Offset = "0xE1ABE8", VA = "0xE1ABE8", Slot = "7")]
		public override void Attach(Response response, Table arguments)
		{
		}

		[Token(Token = "0x6000BCC")]
		[Address(RVA = "0xE1ABEC", Offset = "0xE1ABEC", VA = "0xE1ABEC", Slot = "12")]
		public override void Continue(Response response, Table arguments)
		{
		}

		[Token(Token = "0x6000BCD")]
		[Address(RVA = "0xE1AC78", Offset = "0xE1AC78", VA = "0xE1AC78", Slot = "8")]
		public override void Disconnect(Response response, Table arguments)
		{
		}

		[Token(Token = "0x6000BCE")]
		[Address(RVA = "0xE1ACB0", Offset = "0xE1ACB0", VA = "0xE1ACB0")]
		private static string getString(Table args, string property, [Optional] string dflt)
		{
			return null;
		}

		[Token(Token = "0x6000BCF")]
		[Address(RVA = "0xE1AD50", Offset = "0xE1AD50", VA = "0xE1AD50", Slot = "22")]
		public override void Evaluate(Response response, Table args)
		{
		}

		[Token(Token = "0x6000BD0")]
		[Address(RVA = "0xE1B14C", Offset = "0xE1B14C", VA = "0xE1B14C")]
		private void ExecuteRepl(string cmd)
		{
		}

		[Token(Token = "0x6000BD1")]
		[Address(RVA = "0xE1C28C", Offset = "0xE1C28C", VA = "0xE1C28C", Slot = "6")]
		public override void Launch(Response response, Table arguments)
		{
		}

		[Token(Token = "0x6000BD2")]
		[Address(RVA = "0xE1C290", Offset = "0xE1C290", VA = "0xE1C290", Slot = "13")]
		public override void Next(Response response, Table arguments)
		{
		}

		[Token(Token = "0x6000BD3")]
		[Address(RVA = "0xE1C31C", Offset = "0xE1C31C", VA = "0xE1C31C")]
		private StoppedEvent CreateStoppedEvent(string reason, [Optional] string text)
		{
			return null;
		}

		[Token(Token = "0x6000BD4")]
		[Address(RVA = "0xE1C390", Offset = "0xE1C390", VA = "0xE1C390", Slot = "16")]
		public override void Pause(Response response, Table arguments)
		{
		}

		[Token(Token = "0x6000BD5")]
		[Address(RVA = "0xE1C450", Offset = "0xE1C450", VA = "0xE1C450", Slot = "18")]
		public override void Scopes(Response response, Table arguments)
		{
		}

		[Token(Token = "0x6000BD6")]
		[Address(RVA = "0xE1C664", Offset = "0xE1C664", VA = "0xE1C664", Slot = "11")]
		public override void SetBreakpoints(Response response, Table args)
		{
		}

		[Token(Token = "0x6000BD7")]
		[Address(RVA = "0xE1CBD4", Offset = "0xE1CBD4", VA = "0xE1CBD4", Slot = "17")]
		public override void StackTrace(Response response, Table args)
		{
		}

		[Token(Token = "0x6000BD8")]
		[Address(RVA = "0xE1B0BC", Offset = "0xE1B0BC", VA = "0xE1B0BC")]
		private int getInt(Table args, string propName, int defaultValue)
		{
			return default(int);
		}

		[Token(Token = "0x6000BD9")]
		[Address(RVA = "0xE1D274", Offset = "0xE1D274", VA = "0xE1D274", Slot = "14")]
		public override void StepIn(Response response, Table arguments)
		{
		}

		[Token(Token = "0x6000BDA")]
		[Address(RVA = "0xE1D300", Offset = "0xE1D300", VA = "0xE1D300", Slot = "15")]
		public override void StepOut(Response response, Table arguments)
		{
		}

		[Token(Token = "0x6000BDB")]
		[Address(RVA = "0xE1D38C", Offset = "0xE1D38C", VA = "0xE1D38C", Slot = "21")]
		public override void Threads(Response response, Table arguments)
		{
		}

		[Token(Token = "0x6000BDC")]
		[Address(RVA = "0xE1D4F0", Offset = "0xE1D4F0", VA = "0xE1D4F0", Slot = "19")]
		public override void Variables(Response response, Table arguments)
		{
		}

		[Token(Token = "0x6000BDD")]
		[Address(RVA = "0xE1EF30", Offset = "0xE1EF30", VA = "0xE1EF30", Slot = "23")]
		private void MoonSharp.VsCodeDebugger.DebuggerLogic.IAsyncDebuggerClient.SendStopEvent()
		{
		}

		[Token(Token = "0x6000BDE")]
		[Address(RVA = "0xE1EF84", Offset = "0xE1EF84", VA = "0xE1EF84", Slot = "24")]
		private void MoonSharp.VsCodeDebugger.DebuggerLogic.IAsyncDebuggerClient.OnWatchesUpdated(WatchType watchType)
		{
		}

		[Token(Token = "0x6000BDF")]
		[Address(RVA = "0xE1F000", Offset = "0xE1F000", VA = "0xE1F000", Slot = "25")]
		private void MoonSharp.VsCodeDebugger.DebuggerLogic.IAsyncDebuggerClient.OnSourceCodeChanged(int sourceID)
		{
		}

		[Token(Token = "0x6000BE0")]
		[Address(RVA = "0xE1F194", Offset = "0xE1F194", VA = "0xE1F194", Slot = "26")]
		public void OnExecutionEnded()
		{
		}

		[Token(Token = "0x6000BE1")]
		[Address(RVA = "0xE1AB1C", Offset = "0xE1AB1C", VA = "0xE1AB1C")]
		private void SendText(string msg, params object[] args)
		{
		}

		[Token(Token = "0x6000BE2")]
		[Address(RVA = "0xE1F244", Offset = "0xE1F244", VA = "0xE1F244", Slot = "27")]
		public void OnException(ScriptRuntimeException ex)
		{
		}

		[Token(Token = "0x6000BE3")]
		[Address(RVA = "0xE1C158", Offset = "0xE1C158", VA = "0xE1C158", Slot = "28")]
		public void Unbind()
		{
		}
	}
	[Token(Token = "0x2000194")]
	internal static class VariableInspector
	{
		[Token(Token = "0x6000BE5")]
		[Address(RVA = "0xE1D984", Offset = "0xE1D984", VA = "0xE1D984")]
		internal static void InspectVariable(DynValue v, List<Variable> variables)
		{
		}
	}
}
