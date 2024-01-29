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
			[Address(RVA = "0xD14438", Offset = "0xD14438", VA = "0xD14438")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000012")]
		public bool IsMethodCall
		{
			[Token(Token = "0x600003D")]
			[Address(RVA = "0xD14440", Offset = "0xD14440", VA = "0xD14440")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600003E")]
			[Address(RVA = "0xD14448", Offset = "0xD14448", VA = "0xD14448")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000013")]
		public DynValue this[int index]
		{
			[Token(Token = "0x600003F")]
			[Address(RVA = "0xD14454", Offset = "0xD14454", VA = "0xD14454")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0xD14138", Offset = "0xD14138", VA = "0xD14138")]
		public CallbackArguments(IList<DynValue> args, bool isMethodCall)
		{
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0xD144F8", Offset = "0xD144F8", VA = "0xD144F8")]
		public DynValue RawGet(int index, bool translateVoids)
		{
			return null;
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0xD148B4", Offset = "0xD148B4", VA = "0xD148B4")]
		public DynValue[] GetArray(int skip = 0)
		{
			return null;
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0xD149BC", Offset = "0xD149BC", VA = "0xD149BC")]
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
		[Address(RVA = "0xD14BC0", Offset = "0xD14BC0", VA = "0xD14BC0")]
		public int AsInt(int argNum, string funcName)
		{
			return default(int);
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0xD14BFC", Offset = "0xD14BFC", VA = "0xD14BFC")]
		public long AsLong(int argNum, string funcName)
		{
			return default(long);
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0xD14C38", Offset = "0xD14C38", VA = "0xD14C38")]
		public string AsStringUsingMeta(ScriptExecutionContext executionContext, int argNum, string funcName)
		{
			return null;
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0xD1559C", Offset = "0xD1559C", VA = "0xD1559C")]
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
			[Address(RVA = "0xD156DC", Offset = "0xD156DC", VA = "0xD156DC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000049")]
			[Address(RVA = "0xD156E4", Offset = "0xD156E4", VA = "0xD156E4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000015")]
		public Func<ScriptExecutionContext, CallbackArguments, DynValue> ClrCallback
		{
			[Token(Token = "0x600004A")]
			[Address(RVA = "0xD156EC", Offset = "0xD156EC", VA = "0xD156EC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600004B")]
			[Address(RVA = "0xD156F4", Offset = "0xD156F4", VA = "0xD156F4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000016")]
		public static InteropAccessMode DefaultAccessMode
		{
			[Token(Token = "0x600004E")]
			[Address(RVA = "0xD15950", Offset = "0xD15950", VA = "0xD15950")]
			get
			{
				return default(InteropAccessMode);
			}
			[Token(Token = "0x600004F")]
			[Address(RVA = "0xD159A8", Offset = "0xD159A8", VA = "0xD159A8")]
			set
			{
			}
		}

		[Token(Token = "0x17000017")]
		public object AdditionalData
		{
			[Token(Token = "0x6000052")]
			[Address(RVA = "0xD15C00", Offset = "0xD15C00", VA = "0xD15C00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000053")]
			[Address(RVA = "0xD15C08", Offset = "0xD15C08", VA = "0xD15C08")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0xD156FC", Offset = "0xD156FC", VA = "0xD156FC")]
		public CallbackFunction(Func<ScriptExecutionContext, CallbackArguments, DynValue> callBack, [Optional] string name)
		{
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0xD15784", Offset = "0xD15784", VA = "0xD15784")]
		public DynValue Invoke(ScriptExecutionContext executionContext, IList<DynValue> args, bool isMethodCall = false)
		{
			return null;
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0xD15A6C", Offset = "0xD15A6C", VA = "0xD15A6C")]
		public static CallbackFunction FromDelegate(Script script, Delegate del, InteropAccessMode accessMode = InteropAccessMode.Default)
		{
			return null;
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0xD15B40", Offset = "0xD15B40", VA = "0xD15B40")]
		public static CallbackFunction FromMethodInfo(Script script, MethodInfo mi, [Optional] object obj, InteropAccessMode accessMode = InteropAccessMode.Default)
		{
			return null;
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0xD15C10", Offset = "0xD15C10", VA = "0xD15C10")]
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
			[Address(RVA = "0xD15E44", Offset = "0xD15E44", VA = "0xD15E44")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000057")]
			[Address(RVA = "0xD15E4C", Offset = "0xD15E4C", VA = "0xD15E4C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000019")]
		public Script OwnerScript
		{
			[Token(Token = "0x6000058")]
			[Address(RVA = "0xD15E54", Offset = "0xD15E54", VA = "0xD15E54", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000059")]
			[Address(RVA = "0xD15E5C", Offset = "0xD15E5C", VA = "0xD15E5C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700001A")]
		internal ClosureContext ClosureContext
		{
			[Token(Token = "0x600005A")]
			[Address(RVA = "0xD15E64", Offset = "0xD15E64", VA = "0xD15E64")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600005B")]
			[Address(RVA = "0xD15E6C", Offset = "0xD15E6C", VA = "0xD15E6C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0xD15E74", Offset = "0xD15E74", VA = "0xD15E74")]
		internal Closure(Script script, int idx, SymbolRef[] symbols, IEnumerable<DynValue> resolvedLocals)
		{
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0xD15F50", Offset = "0xD15F50", VA = "0xD15F50")]
		public DynValue Call()
		{
			return null;
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0xD15FE0", Offset = "0xD15FE0", VA = "0xD15FE0")]
		public DynValue Call(params object[] args)
		{
			return null;
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0xD16080", Offset = "0xD16080", VA = "0xD16080")]
		public DynValue Call(params DynValue[] args)
		{
			return null;
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0xD160A4", Offset = "0xD160A4", VA = "0xD160A4")]
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
		[Address(RVA = "0xD16248", Offset = "0xD16248", VA = "0xD16248")]
		public int GetUpvaluesCount()
		{
			return default(int);
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0xD16290", Offset = "0xD16290", VA = "0xD16290")]
		public string GetUpvalueName(int idx)
		{
			return null;
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0xD162C8", Offset = "0xD162C8", VA = "0xD162C8")]
		public DynValue GetUpvalue(int idx)
		{
			return null;
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0xD16320", Offset = "0xD16320", VA = "0xD16320")]
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
				[Address(RVA = "0xD171D4", Offset = "0xD171D4", VA = "0xD171D4", Slot = "6")]
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
				[Address(RVA = "0xD1721C", Offset = "0xD1721C", VA = "0xD1721C", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600007E")]
			[Address(RVA = "0xD16598", Offset = "0xD16598", VA = "0xD16598")]
			[DebuggerHidden]
			public <AsTypedEnumerable>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x600007F")]
			[Address(RVA = "0xD170F8", Offset = "0xD170F8", VA = "0xD170F8", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000080")]
			[Address(RVA = "0xD170FC", Offset = "0xD170FC", VA = "0xD170FC", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000082")]
			[Address(RVA = "0xD171DC", Offset = "0xD171DC", VA = "0xD171DC", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000084")]
			[Address(RVA = "0xD17224", Offset = "0xD17224", VA = "0xD17224", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<DynValue> System.Collections.Generic.IEnumerable<MoonSharp.Interpreter.DynValue>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000085")]
			[Address(RVA = "0xD172C8", Offset = "0xD172C8", VA = "0xD172C8", Slot = "5")]
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
				[Address(RVA = "0xD17740", Offset = "0xD17740", VA = "0xD17740", Slot = "6")]
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
				[Address(RVA = "0xD17788", Offset = "0xD17788", VA = "0xD17788", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000086")]
			[Address(RVA = "0xD16644", Offset = "0xD16644", VA = "0xD16644")]
			[DebuggerHidden]
			public <AsEnumerable>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x6000087")]
			[Address(RVA = "0xD172CC", Offset = "0xD172CC", VA = "0xD172CC", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000088")]
			[Address(RVA = "0xD172E8", Offset = "0xD172E8", VA = "0xD172E8", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000089")]
			[Address(RVA = "0xD17690", Offset = "0xD17690", VA = "0xD17690")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x600008B")]
			[Address(RVA = "0xD17748", Offset = "0xD17748", VA = "0xD17748", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x600008D")]
			[Address(RVA = "0xD17790", Offset = "0xD17790", VA = "0xD17790", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<object> System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x600008E")]
			[Address(RVA = "0xD17834", Offset = "0xD17834", VA = "0xD17834", Slot = "5")]
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
				[Address(RVA = "0xD17BA8", Offset = "0xD17BA8", VA = "0xD17BA8", Slot = "4")]
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
				[Address(RVA = "0xD17BF0", Offset = "0xD17BF0", VA = "0xD17BF0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000098")]
			[Address(RVA = "0xD166E0", Offset = "0xD166E0", VA = "0xD166E0")]
			[DebuggerHidden]
			public <AsUnityCoroutine>d__13(int <>1__state)
			{
			}

			[Token(Token = "0x6000099")]
			[Address(RVA = "0xD17838", Offset = "0xD17838", VA = "0xD17838", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600009A")]
			[Address(RVA = "0xD17854", Offset = "0xD17854", VA = "0xD17854", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600009B")]
			[Address(RVA = "0xD17AF8", Offset = "0xD17AF8", VA = "0xD17AF8")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x600009D")]
			[Address(RVA = "0xD17BB0", Offset = "0xD17BB0", VA = "0xD17BB0", Slot = "8")]
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
			[Address(RVA = "0xD16438", Offset = "0xD16438", VA = "0xD16438")]
			[CompilerGenerated]
			get
			{
				return default(CoroutineType);
			}
			[Token(Token = "0x600006A")]
			[Address(RVA = "0xD16440", Offset = "0xD16440", VA = "0xD16440")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		public CoroutineState State
		{
			[Token(Token = "0x6000078")]
			[Address(RVA = "0xD16FA8", Offset = "0xD16FA8", VA = "0xD16FA8")]
			get
			{
				return default(CoroutineState);
			}
		}

		[Token(Token = "0x1700001D")]
		public Script OwnerScript
		{
			[Token(Token = "0x600007A")]
			[Address(RVA = "0xD170B0", Offset = "0xD170B0", VA = "0xD170B0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600007B")]
			[Address(RVA = "0xD170B8", Offset = "0xD170B8", VA = "0xD170B8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700001E")]
		public long AutoYieldCounter
		{
			[Token(Token = "0x600007C")]
			[Address(RVA = "0xD170C0", Offset = "0xD170C0", VA = "0xD170C0")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x600007D")]
			[Address(RVA = "0xD170DC", Offset = "0xD170DC", VA = "0xD170DC")]
			set
			{
			}
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0xD16448", Offset = "0xD16448", VA = "0xD16448")]
		internal Coroutine(CallbackFunction function)
		{
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0xD16478", Offset = "0xD16478", VA = "0xD16478")]
		internal Coroutine(Processor proc)
		{
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0xD164B4", Offset = "0xD164B4", VA = "0xD164B4")]
		internal void MarkClrCallbackAsDead()
		{
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0xD16520", Offset = "0xD16520", VA = "0xD16520")]
		[IteratorStateMachine(typeof(<AsTypedEnumerable>d__10))]
		public IEnumerable<DynValue> AsTypedEnumerable()
		{
			return null;
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0xD165CC", Offset = "0xD165CC", VA = "0xD165CC")]
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
		[Address(RVA = "0xD16678", Offset = "0xD16678", VA = "0xD16678")]
		[IteratorStateMachine(typeof(<AsUnityCoroutine>d__13))]
		public IEnumerator AsUnityCoroutine()
		{
			return null;
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0xD16708", Offset = "0xD16708", VA = "0xD16708")]
		public DynValue Resume(params DynValue[] args)
		{
			return null;
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0xD167FC", Offset = "0xD167FC", VA = "0xD167FC")]
		public DynValue Resume(ScriptExecutionContext context, params DynValue[] args)
		{
			return null;
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0xD16C28", Offset = "0xD16C28", VA = "0xD16C28")]
		public DynValue Resume()
		{
			return null;
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0xD16C7C", Offset = "0xD16C7C", VA = "0xD16C7C")]
		public DynValue Resume(ScriptExecutionContext context)
		{
			return null;
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0xD16CE0", Offset = "0xD16CE0", VA = "0xD16CE0")]
		public DynValue Resume(params object[] args)
		{
			return null;
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0xD16E64", Offset = "0xD16E64", VA = "0xD16E64")]
		public DynValue Resume(ScriptExecutionContext context, params object[] args)
		{
			return null;
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0xD16FE4", Offset = "0xD16FE4", VA = "0xD16FE4")]
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
		[Address(RVA = "0xD17BF8", Offset = "0xD17BF8", VA = "0xD17BF8")]
		public static bool CanHaveTypeMetatables(this DataType type)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0xD17C04", Offset = "0xD17C04", VA = "0xD17C04")]
		public static string ToErrorTypeString(this DataType type)
		{
			return null;
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0xD17D60", Offset = "0xD17D60", VA = "0xD17D60")]
		public static string ToLuaDebuggerString(this DataType type)
		{
			return null;
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0xD17DD4", Offset = "0xD17DD4", VA = "0xD17DD4")]
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
			[Address(RVA = "0xD17F28", Offset = "0xD17F28", VA = "0xD17F28")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000028")]
		public DataType Type
		{
			[Token(Token = "0x60000A4")]
			[Address(RVA = "0xD17F30", Offset = "0xD17F30", VA = "0xD17F30")]
			get
			{
				return default(DataType);
			}
		}

		[Token(Token = "0x17000029")]
		public Closure Function
		{
			[Token(Token = "0x60000A5")]
			[Address(RVA = "0xD17F38", Offset = "0xD17F38", VA = "0xD17F38")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002A")]
		public double Number
		{
			[Token(Token = "0x60000A6")]
			[Address(RVA = "0xD17FB4", Offset = "0xD17FB4", VA = "0xD17FB4")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x1700002B")]
		public DynValue[] Tuple
		{
			[Token(Token = "0x60000A7")]
			[Address(RVA = "0xD143F0", Offset = "0xD143F0", VA = "0xD143F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002C")]
		public Coroutine Coroutine
		{
			[Token(Token = "0x60000A8")]
			[Address(RVA = "0xD17FBC", Offset = "0xD17FBC", VA = "0xD17FBC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002D")]
		public Table Table
		{
			[Token(Token = "0x60000A9")]
			[Address(RVA = "0xD14E64", Offset = "0xD14E64", VA = "0xD14E64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002E")]
		public bool Boolean
		{
			[Token(Token = "0x60000AA")]
			[Address(RVA = "0xD18038", Offset = "0xD18038", VA = "0xD18038")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700002F")]
		public string String
		{
			[Token(Token = "0x60000AB")]
			[Address(RVA = "0xD18048", Offset = "0xD18048", VA = "0xD18048")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000030")]
		public CallbackFunction Callback
		{
			[Token(Token = "0x60000AC")]
			[Address(RVA = "0xD180A8", Offset = "0xD180A8", VA = "0xD180A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000031")]
		public TailCallData TailCallData
		{
			[Token(Token = "0x60000AD")]
			[Address(RVA = "0xD18108", Offset = "0xD18108", VA = "0xD18108")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000032")]
		public YieldRequest YieldRequest
		{
			[Token(Token = "0x60000AE")]
			[Address(RVA = "0xD18184", Offset = "0xD18184", VA = "0xD18184")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000033")]
		public UserData UserData
		{
			[Token(Token = "0x60000AF")]
			[Address(RVA = "0xD18200", Offset = "0xD18200", VA = "0xD18200")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000034")]
		public bool ReadOnly
		{
			[Token(Token = "0x60000B0")]
			[Address(RVA = "0xD1827C", Offset = "0xD1827C", VA = "0xD1827C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000035")]
		public static DynValue Void
		{
			[Token(Token = "0x60000CA")]
			[Address(RVA = "0xD1927C", Offset = "0xD1927C", VA = "0xD1927C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000CB")]
			[Address(RVA = "0xD192D4", Offset = "0xD192D4", VA = "0xD192D4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000036")]
		public static DynValue Nil
		{
			[Token(Token = "0x60000CC")]
			[Address(RVA = "0xD19330", Offset = "0xD19330", VA = "0xD19330")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000CD")]
			[Address(RVA = "0xD19388", Offset = "0xD19388", VA = "0xD19388")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000037")]
		public static DynValue True
		{
			[Token(Token = "0x60000CE")]
			[Address(RVA = "0xD193E4", Offset = "0xD193E4", VA = "0xD193E4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000CF")]
			[Address(RVA = "0xD1943C", Offset = "0xD1943C", VA = "0xD1943C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000038")]
		public static DynValue False
		{
			[Token(Token = "0x60000D0")]
			[Address(RVA = "0xD19498", Offset = "0xD19498", VA = "0xD19498")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000D1")]
			[Address(RVA = "0xD194F0", Offset = "0xD194F0", VA = "0xD194F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0xD18284", Offset = "0xD18284", VA = "0xD18284")]
		public static DynValue NewNil()
		{
			return null;
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0xD18350", Offset = "0xD18350", VA = "0xD18350")]
		public static DynValue NewBoolean(bool v)
		{
			return null;
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0xD183C8", Offset = "0xD183C8", VA = "0xD183C8")]
		public static DynValue NewNumber(double num)
		{
			return null;
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0xD18440", Offset = "0xD18440", VA = "0xD18440")]
		public static DynValue NewString(string str)
		{
			return null;
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0xD184A8", Offset = "0xD184A8", VA = "0xD184A8")]
		public static DynValue NewString(StringBuilder sb)
		{
			return null;
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0xD18524", Offset = "0xD18524", VA = "0xD18524")]
		public static DynValue NewString(string format, params object[] args)
		{
			return null;
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0xD185A8", Offset = "0xD185A8", VA = "0xD185A8")]
		public static DynValue NewCoroutine(Coroutine coroutine)
		{
			return null;
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0xD18610", Offset = "0xD18610", VA = "0xD18610")]
		public static DynValue NewClosure(Closure function)
		{
			return null;
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0xD18678", Offset = "0xD18678", VA = "0xD18678")]
		public static DynValue NewCallback(Func<ScriptExecutionContext, CallbackArguments, DynValue> callBack, [Optional] string name)
		{
			return null;
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0xD18718", Offset = "0xD18718", VA = "0xD18718")]
		public static DynValue NewCallback(CallbackFunction function)
		{
			return null;
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0xD18780", Offset = "0xD18780", VA = "0xD18780")]
		public static DynValue NewTable(Table table)
		{
			return null;
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0xD187E8", Offset = "0xD187E8", VA = "0xD187E8")]
		public static DynValue NewPrimeTable()
		{
			return null;
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0xD189DC", Offset = "0xD189DC", VA = "0xD189DC")]
		public static DynValue NewTable(Script script)
		{
			return null;
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0xD18A60", Offset = "0xD18A60", VA = "0xD18A60")]
		public static DynValue NewTable(Script script, params DynValue[] arrayValues)
		{
			return null;
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0xD18BC0", Offset = "0xD18BC0", VA = "0xD18BC0")]
		public static DynValue NewTailCallReq(DynValue tailFn, params DynValue[] args)
		{
			return null;
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0xD18C6C", Offset = "0xD18C6C", VA = "0xD18C6C")]
		public static DynValue NewTailCallReq(TailCallData tailCallData)
		{
			return null;
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0xD18CD4", Offset = "0xD18CD4", VA = "0xD18CD4")]
		public static DynValue NewYieldReq(DynValue[] args)
		{
			return null;
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0xD18D74", Offset = "0xD18D74", VA = "0xD18D74")]
		internal static DynValue NewForcedYieldReq()
		{
			return null;
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0xD18E0C", Offset = "0xD18E0C", VA = "0xD18E0C")]
		public static DynValue NewTuple(params DynValue[] values)
		{
			return null;
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0xD18EAC", Offset = "0xD18EAC", VA = "0xD18EAC")]
		public static DynValue NewTupleNested(params DynValue[] values)
		{
			return null;
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0xD19168", Offset = "0xD19168", VA = "0xD19168")]
		public static DynValue NewUserData(UserData userData)
		{
			return null;
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0xD191D0", Offset = "0xD191D0", VA = "0xD191D0")]
		public DynValue AsReadOnly()
		{
			return null;
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0xD1926C", Offset = "0xD1926C", VA = "0xD1926C")]
		public DynValue Clone()
		{
			return null;
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0xD191E4", Offset = "0xD191E4", VA = "0xD191E4")]
		public DynValue Clone(bool readOnly)
		{
			return null;
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0xD19274", Offset = "0xD19274", VA = "0xD19274")]
		public DynValue CloneAsWritable()
		{
			return null;
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0xD1954C", Offset = "0xD1954C", VA = "0xD1954C")]
		static DynValue()
		{
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0xD1523C", Offset = "0xD1523C", VA = "0xD1523C")]
		public string ToPrintString()
		{
			return null;
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0xD197C0", Offset = "0xD197C0", VA = "0xD197C0")]
		public string ToDebugPrintString()
		{
			return null;
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0xD19AC4", Offset = "0xD19AC4", VA = "0xD19AC4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0xD19F68", Offset = "0xD19F68", VA = "0xD19F68", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0xD1A0F8", Offset = "0xD1A0F8", VA = "0xD1A0F8", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0xD1A3AC", Offset = "0xD1A3AC", VA = "0xD1A3AC")]
		public string CastToString()
		{
			return null;
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0xD1A448", Offset = "0xD1A448", VA = "0xD1A448")]
		public double? CastToNumber()
		{
			return null;
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0xD1A574", Offset = "0xD1A574", VA = "0xD1A574")]
		public bool CastToBool()
		{
			return default(bool);
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0xD1A5B0", Offset = "0xD1A5B0", VA = "0xD1A5B0")]
		public IScriptPrivateResource GetAsPrivateResource()
		{
			return null;
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0xD175B8", Offset = "0xD175B8", VA = "0xD175B8")]
		public DynValue ToScalar()
		{
			return null;
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0xD1A5F8", Offset = "0xD1A5F8", VA = "0xD1A5F8")]
		public void Assign(DynValue value)
		{
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0xD1A678", Offset = "0xD1A678", VA = "0xD1A678")]
		public DynValue GetLength()
		{
			return null;
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0xD1A8D4", Offset = "0xD1A8D4", VA = "0xD1A8D4")]
		public bool IsNil()
		{
			return default(bool);
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0xD1A8E4", Offset = "0xD1A8E4", VA = "0xD1A8E4")]
		public bool IsNotNil()
		{
			return default(bool);
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0xD1A8F4", Offset = "0xD1A8F4", VA = "0xD1A8F4")]
		public bool IsVoid()
		{
			return default(bool);
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0xD1A904", Offset = "0xD1A904", VA = "0xD1A904")]
		public bool IsNotVoid()
		{
			return default(bool);
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0xD1A914", Offset = "0xD1A914", VA = "0xD1A914")]
		public bool IsNilOrNan()
		{
			return default(bool);
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0xD1A998", Offset = "0xD1A998", VA = "0xD1A998")]
		internal void AssignNumber(double num)
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0xD16E5C", Offset = "0xD16E5C", VA = "0xD16E5C")]
		public static DynValue FromObject(Script script, object obj)
		{
			return null;
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0xD16430", Offset = "0xD16430", VA = "0xD16430")]
		public object ToObject()
		{
			return null;
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0xD1AAEC", Offset = "0xD1AAEC", VA = "0xD1AAEC")]
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
		[Address(RVA = "0xD14A0C", Offset = "0xD14A0C", VA = "0xD14A0C")]
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
		[Address(RVA = "0xD182DC", Offset = "0xD182DC", VA = "0xD182DC")]
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
		[Address(RVA = "0xD16790", Offset = "0xD16790", VA = "0xD16790")]
		public static void CheckScriptOwnership(this IScriptPrivateResource containingResource, DynValue[] values)
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0xD1ADB8", Offset = "0xD1ADB8", VA = "0xD1ADB8")]
		public static void CheckScriptOwnership(this IScriptPrivateResource containingResource, DynValue value)
		{
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0xD1ADE8", Offset = "0xD1ADE8", VA = "0xD1ADE8")]
		public static void CheckScriptOwnership(this IScriptPrivateResource resource, Script script)
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0xD168A8", Offset = "0xD168A8", VA = "0xD168A8")]
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
			[Address(RVA = "0xD1AF3C", Offset = "0xD1AF3C", VA = "0xD1AF3C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0xD1972C", Offset = "0xD1972C", VA = "0xD1972C")]
		public string FormatTypeString(string typeString)
		{
			return null;
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0xD15724", Offset = "0xD15724", VA = "0xD15724")]
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
			[Address(RVA = "0xD1AF84", Offset = "0xD1AF84", VA = "0xD1AF84")]
			get
			{
				return default(SymbolRefType);
			}
		}

		[Token(Token = "0x1700003C")]
		public int Index
		{
			[Token(Token = "0x6000104")]
			[Address(RVA = "0xD1AF8C", Offset = "0xD1AF8C", VA = "0xD1AF8C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700003D")]
		public string Name
		{
			[Token(Token = "0x6000105")]
			[Address(RVA = "0xD1AF94", Offset = "0xD1AF94", VA = "0xD1AF94")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003E")]
		public SymbolRef Environment
		{
			[Token(Token = "0x6000106")]
			[Address(RVA = "0xD1AF9C", Offset = "0xD1AF9C", VA = "0xD1AF9C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003F")]
		public static SymbolRef DefaultEnv
		{
			[Token(Token = "0x6000107")]
			[Address(RVA = "0xD1AFA4", Offset = "0xD1AFA4", VA = "0xD1AFA4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0xD1AFFC", Offset = "0xD1AFFC", VA = "0xD1AFFC")]
		public static SymbolRef Global(string name, SymbolRef envSymbol)
		{
			return null;
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0xD1B088", Offset = "0xD1B088", VA = "0xD1B088")]
		internal static SymbolRef Local(string name, int index)
		{
			return null;
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0xD1B100", Offset = "0xD1B100", VA = "0xD1B100")]
		internal static SymbolRef Upvalue(string name, int index)
		{
			return null;
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0xD1B17C", Offset = "0xD1B17C", VA = "0xD1B17C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0xD1B2A4", Offset = "0xD1B2A4", VA = "0xD1B2A4")]
		internal void WriteBinary(BinaryWriter bw)
		{
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0xD1B308", Offset = "0xD1B308", VA = "0xD1B308")]
		internal static SymbolRef ReadBinary(BinaryReader br)
		{
			return null;
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0xD1B3B4", Offset = "0xD1B3B4", VA = "0xD1B3B4")]
		internal void WriteBinaryEnv(BinaryWriter bw, Dictionary<SymbolRef, int> symbolMap)
		{
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0xD1B448", Offset = "0xD1B448", VA = "0xD1B448")]
		internal void ReadBinaryEnv(BinaryReader br, SymbolRef[] symbolRefs)
		{
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0xD1B080", Offset = "0xD1B080", VA = "0xD1B080")]
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
			[Address(RVA = "0xD1B6A4", Offset = "0xD1B6A4", VA = "0xD1B6A4", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000041")]
		public object this[params object[] keys]
		{
			[Token(Token = "0x6000117")]
			[Address(RVA = "0xD1B7A4", Offset = "0xD1B7A4", VA = "0xD1B7A4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000118")]
			[Address(RVA = "0xD1B860", Offset = "0xD1B860", VA = "0xD1B860")]
			set
			{
			}
		}

		[Token(Token = "0x17000042")]
		public object this[object key]
		{
			[Token(Token = "0x6000119")]
			[Address(RVA = "0xD1B940", Offset = "0xD1B940", VA = "0xD1B940")]
			get
			{
				return null;
			}
			[Token(Token = "0x600011A")]
			[Address(RVA = "0xD1B9FC", Offset = "0xD1B9FC", VA = "0xD1B9FC")]
			set
			{
			}
		}

		[Token(Token = "0x17000043")]
		public int Length
		{
			[Token(Token = "0x6000137")]
			[Address(RVA = "0xD1A800", Offset = "0xD1A800", VA = "0xD1A800")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000044")]
		public Table MetaTable
		{
			[Token(Token = "0x6000139")]
			[Address(RVA = "0xD1CD3C", Offset = "0xD1CD3C", VA = "0xD1CD3C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600013A")]
			[Address(RVA = "0xD1CD44", Offset = "0xD1CD44", VA = "0xD1CD44")]
			set
			{
			}
		}

		[Token(Token = "0x17000045")]
		public IEnumerable<TablePair> Pairs
		{
			[Token(Token = "0x600013B")]
			[Address(RVA = "0xD1CD70", Offset = "0xD1CD70", VA = "0xD1CD70")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000046")]
		public IEnumerable<DynValue> Keys
		{
			[Token(Token = "0x600013C")]
			[Address(RVA = "0xD1CE6C", Offset = "0xD1CE6C", VA = "0xD1CE6C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000047")]
		public IEnumerable<DynValue> Values
		{
			[Token(Token = "0x600013D")]
			[Address(RVA = "0xD1CF68", Offset = "0xD1CF68", VA = "0xD1CF68")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0xD18868", Offset = "0xD18868", VA = "0xD18868")]
		public Table(Script owner)
		{
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0xD18AF4", Offset = "0xD18AF4", VA = "0xD18AF4")]
		public Table(Script owner, params DynValue[] arrayValues)
		{
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0xD1B6AC", Offset = "0xD1B6AC", VA = "0xD1B6AC")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0xD1B774", Offset = "0xD1B774", VA = "0xD1B774")]
		private int GetIntegralKey(double d)
		{
			return default(int);
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0xD1BBA4", Offset = "0xD1BBA4", VA = "0xD1BBA4")]
		private Table ResolveMultipleKeys(object[] keys, out object key)
		{
			return null;
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0xD1BDC4", Offset = "0xD1BDC4", VA = "0xD1BDC4")]
		public void Append(DynValue value)
		{
		}

		[Token(Token = "0x600011D")]
		private void PerformTableSet<T>(LinkedListIndex<T, TablePair> listIndex, T key, DynValue keyDynValue, DynValue value, bool isNumber, int appendKey)
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0xD1BEA0", Offset = "0xD1BEA0", VA = "0xD1BEA0")]
		public void Set(string key, DynValue value)
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0xD1BFE0", Offset = "0xD1BFE0", VA = "0xD1BFE0")]
		public void Set(int key, DynValue value)
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0xD1B514", Offset = "0xD1B514", VA = "0xD1B514")]
		public void Set(DynValue key, DynValue value)
		{
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0xD1BA7C", Offset = "0xD1BA7C", VA = "0xD1BA7C")]
		public void Set(object key, DynValue value)
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0xD1B8E0", Offset = "0xD1B8E0", VA = "0xD1B8E0")]
		public void Set(object[] keys, DynValue value)
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0xD1C0FC", Offset = "0xD1C0FC", VA = "0xD1C0FC")]
		public DynValue Get(string key)
		{
			return null;
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0xD1C19C", Offset = "0xD1C19C", VA = "0xD1C19C")]
		public DynValue Get(int key)
		{
			return null;
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0xD1C2CC", Offset = "0xD1C2CC", VA = "0xD1C2CC")]
		public DynValue Get(DynValue key)
		{
			return null;
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0xD1B95C", Offset = "0xD1B95C", VA = "0xD1B95C")]
		public DynValue Get(object key)
		{
			return null;
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0xD1B7C0", Offset = "0xD1B7C0", VA = "0xD1B7C0")]
		public DynValue Get(params object[] keys)
		{
			return null;
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0xD1C4F0", Offset = "0xD1C4F0", VA = "0xD1C4F0")]
		private static DynValue RawGetValue(LinkedListNode<TablePair> linkedListNode)
		{
			return null;
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0xD14EE0", Offset = "0xD14EE0", VA = "0xD14EE0")]
		public DynValue RawGet(string key)
		{
			return null;
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0xD1C23C", Offset = "0xD1C23C", VA = "0xD1C23C")]
		public DynValue RawGet(int key)
		{
			return null;
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0xD1C36C", Offset = "0xD1C36C", VA = "0xD1C36C")]
		public DynValue RawGet(DynValue key)
		{
			return null;
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0xD1BCCC", Offset = "0xD1BCCC", VA = "0xD1BCCC")]
		public DynValue RawGet(object key)
		{
			return null;
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0xD1C4B4", Offset = "0xD1C4B4", VA = "0xD1C4B4")]
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
		[Address(RVA = "0xD1C538", Offset = "0xD1C538", VA = "0xD1C538")]
		public bool Remove(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0xD1C598", Offset = "0xD1C598", VA = "0xD1C598")]
		public bool Remove(int key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0xD1C5F8", Offset = "0xD1C5F8", VA = "0xD1C5F8")]
		public bool Remove(DynValue key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0xD1C70C", Offset = "0xD1C70C", VA = "0xD1C70C")]
		public bool Remove(object key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0xD1C7F4", Offset = "0xD1C7F4", VA = "0xD1C7F4")]
		public bool Remove(params object[] keys)
		{
			return default(bool);
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0xD1C834", Offset = "0xD1C834", VA = "0xD1C834")]
		public void CollectDeadKeys()
		{
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0xD1C8E0", Offset = "0xD1C8E0", VA = "0xD1C8E0")]
		public TablePair? NextKey(DynValue v)
		{
			return null;
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0xD1CB44", Offset = "0xD1CB44", VA = "0xD1CB44")]
		private TablePair? GetNextOf(LinkedListNode<TablePair> linkedListNode)
		{
			return null;
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0xD1CC80", Offset = "0xD1CC80", VA = "0xD1CC80")]
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
			[Address(RVA = "0xD1D0F4", Offset = "0xD1D0F4", VA = "0xD1D0F4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000144")]
			[Address(RVA = "0xD1D0FC", Offset = "0xD1D0FC", VA = "0xD1D0FC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000049")]
		public DynValue Value
		{
			[Token(Token = "0x6000145")]
			[Address(RVA = "0xD1D100", Offset = "0xD1D100", VA = "0xD1D100")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000146")]
			[Address(RVA = "0xD1D108", Offset = "0xD1D108", VA = "0xD1D108")]
			set
			{
			}
		}

		[Token(Token = "0x1700004A")]
		public static TablePair Nil
		{
			[Token(Token = "0x6000148")]
			[Address(RVA = "0xD1D12C", Offset = "0xD1D12C", VA = "0xD1D12C")]
			get
			{
				return default(TablePair);
			}
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0xD1D0DC", Offset = "0xD1D0DC", VA = "0xD1D0DC")]
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
			[Address(RVA = "0xD1D26C", Offset = "0xD1D26C", VA = "0xD1D26C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600014B")]
			[Address(RVA = "0xD1D274", Offset = "0xD1D274", VA = "0xD1D274")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700004C")]
		public DynValue[] Args
		{
			[Token(Token = "0x600014C")]
			[Address(RVA = "0xD1D27C", Offset = "0xD1D27C", VA = "0xD1D27C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600014D")]
			[Address(RVA = "0xD1D284", Offset = "0xD1D284", VA = "0xD1D284")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700004D")]
		public CallbackFunction Continuation
		{
			[Token(Token = "0x600014E")]
			[Address(RVA = "0xD1D28C", Offset = "0xD1D28C", VA = "0xD1D28C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600014F")]
			[Address(RVA = "0xD1D294", Offset = "0xD1D294", VA = "0xD1D294")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700004E")]
		public CallbackFunction ErrorHandler
		{
			[Token(Token = "0x6000150")]
			[Address(RVA = "0xD1D29C", Offset = "0xD1D29C", VA = "0xD1D29C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000151")]
			[Address(RVA = "0xD1D2A4", Offset = "0xD1D2A4", VA = "0xD1D2A4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700004F")]
		public DynValue ErrorHandlerBeforeUnwind
		{
			[Token(Token = "0x6000152")]
			[Address(RVA = "0xD1D2AC", Offset = "0xD1D2AC", VA = "0xD1D2AC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000153")]
			[Address(RVA = "0xD1D2B4", Offset = "0xD1D2B4", VA = "0xD1D2B4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0xD18C64", Offset = "0xD18C64", VA = "0xD18C64")]
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
			[Address(RVA = "0xD1D2C0", Offset = "0xD1D2C0", VA = "0xD1D2C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000157")]
			[Address(RVA = "0xD1D2C8", Offset = "0xD1D2C8", VA = "0xD1D2C8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000051")]
		public object Object
		{
			[Token(Token = "0x6000158")]
			[Address(RVA = "0xD1D2D0", Offset = "0xD1D2D0", VA = "0xD1D2D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000159")]
			[Address(RVA = "0xD1D2D8", Offset = "0xD1D2D8", VA = "0xD1D2D8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000052")]
		public IUserDataDescriptor Descriptor
		{
			[Token(Token = "0x600015A")]
			[Address(RVA = "0xD1D2E0", Offset = "0xD1D2E0", VA = "0xD1D2E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600015B")]
			[Address(RVA = "0xD1D2E8", Offset = "0xD1D2E8", VA = "0xD1D2E8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000053")]
		public static IRegistrationPolicy RegistrationPolicy
		{
			[Token(Token = "0x600016E")]
			[Address(RVA = "0xD1DB90", Offset = "0xD1DB90", VA = "0xD1DB90")]
			get
			{
				return null;
			}
			[Token(Token = "0x600016F")]
			[Address(RVA = "0xD1D3C0", Offset = "0xD1D3C0", VA = "0xD1D3C0")]
			set
			{
			}
		}

		[Token(Token = "0x17000054")]
		public static InteropAccessMode DefaultAccessMode
		{
			[Token(Token = "0x6000170")]
			[Address(RVA = "0xD1DC18", Offset = "0xD1DC18", VA = "0xD1DC18")]
			get
			{
				return default(InteropAccessMode);
			}
			[Token(Token = "0x6000171")]
			[Address(RVA = "0xD1D44C", Offset = "0xD1D44C", VA = "0xD1D44C")]
			set
			{
			}
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0xD1D2BC", Offset = "0xD1D2BC", VA = "0xD1D2BC")]
		private UserData()
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0xD1D2F0", Offset = "0xD1D2F0", VA = "0xD1D2F0")]
		static UserData()
		{
		}

		[Token(Token = "0x600015D")]
		public static IUserDataDescriptor RegisterType<T>(InteropAccessMode accessMode = InteropAccessMode.Default, [Optional] string friendlyName)
		{
			return null;
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0xD1D4A4", Offset = "0xD1D4A4", VA = "0xD1D4A4")]
		public static IUserDataDescriptor RegisterType(Type type, InteropAccessMode accessMode = InteropAccessMode.Default, [Optional] string friendlyName)
		{
			return null;
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0xD1D518", Offset = "0xD1D518", VA = "0xD1D518")]
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
		[Address(RVA = "0xD1D588", Offset = "0xD1D588", VA = "0xD1D588")]
		public static IUserDataDescriptor RegisterType(Type type, IUserDataDescriptor customDescriptor)
		{
			return null;
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0xD1D5F8", Offset = "0xD1D5F8", VA = "0xD1D5F8")]
		public static IUserDataDescriptor RegisterType(IUserDataDescriptor customDescriptor)
		{
			return null;
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0xD1D6DC", Offset = "0xD1D6DC", VA = "0xD1D6DC")]
		public static void RegisterAssembly([Optional] Assembly asm, bool includeExtensionTypes = false)
		{
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0xD1D75C", Offset = "0xD1D75C", VA = "0xD1D75C")]
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
		[Address(RVA = "0xD1D7B4", Offset = "0xD1D7B4", VA = "0xD1D7B4")]
		public static void UnregisterType(Type t)
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0xD1D80C", Offset = "0xD1D80C", VA = "0xD1D80C")]
		public static DynValue Create(object o, IUserDataDescriptor descr)
		{
			return null;
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0xD1D89C", Offset = "0xD1D89C", VA = "0xD1D89C")]
		public static DynValue Create(object o)
		{
			return null;
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0xD1DA90", Offset = "0xD1DA90", VA = "0xD1DA90")]
		public static DynValue CreateStatic(IUserDataDescriptor descr)
		{
			return null;
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0xD1DA34", Offset = "0xD1DA34", VA = "0xD1DA34")]
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
		[Address(RVA = "0xD1DCA0", Offset = "0xD1DCA0", VA = "0xD1DCA0")]
		public static void RegisterExtensionType(Type type, InteropAccessMode mode = InteropAccessMode.Default)
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0xD1DD08", Offset = "0xD1DD08", VA = "0xD1DD08")]
		public static List<IOverloadableMemberDescriptor> GetExtensionMethodsByNameAndType(string name, Type extendedType)
		{
			return null;
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0xD1DD70", Offset = "0xD1DD70", VA = "0xD1DD70")]
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
		[Address(RVA = "0xD1DB28", Offset = "0xD1DB28", VA = "0xD1DB28")]
		public static IUserDataDescriptor GetDescriptorForType(Type type, bool searchInterfaces)
		{
			return null;
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0xD1D9BC", Offset = "0xD1D9BC", VA = "0xD1D9BC")]
		public static IUserDataDescriptor GetDescriptorForObject(object o)
		{
			return null;
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0xD1DDF8", Offset = "0xD1DDF8", VA = "0xD1DDF8")]
		public static Table GetDescriptionOfRegisteredTypes(bool useHistoricalData = false)
		{
			return null;
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0xD1E2B8", Offset = "0xD1E2B8", VA = "0xD1E2B8")]
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
			[Address(RVA = "0xD1E504", Offset = "0xD1E504", VA = "0xD1E504")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600017E")]
			[Address(RVA = "0xD1E50C", Offset = "0xD1E50C", VA = "0xD1E50C")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0xD18D6C", Offset = "0xD18D6C", VA = "0xD18D6C")]
		public YieldRequest()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002C")]
	public class DynamicExpressionException : ScriptRuntimeException
	{
		[Token(Token = "0x6000180")]
		[Address(RVA = "0xD1E518", Offset = "0xD1E518", VA = "0xD1E518")]
		public DynamicExpressionException(string format, params object[] args)
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0xD1E584", Offset = "0xD1E584", VA = "0xD1E584")]
		public DynamicExpressionException(string message)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002D")]
	public class InternalErrorException : InterpreterException
	{
		[Token(Token = "0x6000182")]
		[Address(RVA = "0xD1E5E8", Offset = "0xD1E5E8", VA = "0xD1E5E8")]
		internal InternalErrorException(string message)
		{
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0xD1AAE8", Offset = "0xD1AAE8", VA = "0xD1AAE8")]
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
			[Address(RVA = "0xD1E7C4", Offset = "0xD1E7C4", VA = "0xD1E7C4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000189")]
			[Address(RVA = "0xD1E7CC", Offset = "0xD1E7CC", VA = "0xD1E7CC")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Token(Token = "0x17000057")]
		public IList<WatchItem> CallStack
		{
			[Token(Token = "0x600018A")]
			[Address(RVA = "0xD1E7D4", Offset = "0xD1E7D4", VA = "0xD1E7D4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600018B")]
			[Address(RVA = "0xD1E7DC", Offset = "0xD1E7DC", VA = "0xD1E7DC")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Token(Token = "0x17000058")]
		public string DecoratedMessage
		{
			[Token(Token = "0x600018C")]
			[Address(RVA = "0xD1E7E4", Offset = "0xD1E7E4", VA = "0xD1E7E4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600018D")]
			[Address(RVA = "0xD1E7EC", Offset = "0xD1E7EC", VA = "0xD1E7EC")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Token(Token = "0x17000059")]
		public bool DoNotDecorateMessage
		{
			[Token(Token = "0x600018E")]
			[Address(RVA = "0xD1E7F4", Offset = "0xD1E7F4", VA = "0xD1E7F4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600018F")]
			[Address(RVA = "0xD1E7FC", Offset = "0xD1E7FC", VA = "0xD1E7FC")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0xD1E6D8", Offset = "0xD1E6D8", VA = "0xD1E6D8")]
		protected InterpreterException(Exception ex, string message)
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0xD1E748", Offset = "0xD1E748", VA = "0xD1E748")]
		protected InterpreterException(Exception ex)
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0xD1E5EC", Offset = "0xD1E5EC", VA = "0xD1E5EC")]
		protected InterpreterException(string message)
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0xD1E654", Offset = "0xD1E654", VA = "0xD1E654")]
		protected InterpreterException(string format, params object[] args)
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0xD1E808", Offset = "0xD1E808", VA = "0xD1E808")]
		internal void DecorateMessage(Script script, SourceRef sref, int ip = -1)
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0xD1E92C", Offset = "0xD1E92C", VA = "0xD1E92C", Slot = "13")]
		public virtual void Rethrow()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002F")]
	public class ScriptRuntimeException : InterpreterException
	{
		[Token(Token = "0x6000192")]
		[Address(RVA = "0xD1E930", Offset = "0xD1E930", VA = "0xD1E930")]
		public ScriptRuntimeException(Exception ex)
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0xD1E934", Offset = "0xD1E934", VA = "0xD1E934")]
		public ScriptRuntimeException(ScriptRuntimeException ex)
		{
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0xD1A674", Offset = "0xD1A674", VA = "0xD1A674")]
		public ScriptRuntimeException(string message)
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0xD15238", Offset = "0xD15238", VA = "0xD15238")]
		public ScriptRuntimeException(string format, params object[] args)
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0xD1E970", Offset = "0xD1E970", VA = "0xD1E970")]
		public static ScriptRuntimeException ArithmeticOnNonNumber(DynValue l, [Optional] DynValue r)
		{
			return null;
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0xD1EB2C", Offset = "0xD1EB2C", VA = "0xD1EB2C")]
		public static ScriptRuntimeException ConcatOnNonString(DynValue l, DynValue r)
		{
			return null;
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0xD1EC9C", Offset = "0xD1EC9C", VA = "0xD1EC9C")]
		public static ScriptRuntimeException LenOnInvalidType(DynValue r)
		{
			return null;
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0xD1ED80", Offset = "0xD1ED80", VA = "0xD1ED80")]
		public static ScriptRuntimeException CompareInvalidType(DynValue l, DynValue r)
		{
			return null;
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0xD1EF48", Offset = "0xD1EF48", VA = "0xD1EF48")]
		public static ScriptRuntimeException BadArgument(int argNum, string funcName, string message)
		{
			return null;
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0xD1F0B0", Offset = "0xD1F0B0", VA = "0xD1F0B0")]
		public static ScriptRuntimeException BadArgumentUserData(int argNum, string funcName, Type expected, object got, bool allowNil)
		{
			return null;
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0xD1AC70", Offset = "0xD1AC70", VA = "0xD1AC70")]
		public static ScriptRuntimeException BadArgument(int argNum, string funcName, DataType expected, DataType got, bool allowNil)
		{
			return null;
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0xD1F34C", Offset = "0xD1F34C", VA = "0xD1F34C")]
		public static ScriptRuntimeException BadArgument(int argNum, string funcName, string expected, string got, bool allowNil)
		{
			return null;
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0xD1AAFC", Offset = "0xD1AAFC", VA = "0xD1AAFC")]
		public static ScriptRuntimeException BadArgumentNoValue(int argNum, string funcName, DataType expected)
		{
			return null;
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0xD1F54C", Offset = "0xD1F54C", VA = "0xD1F54C")]
		public static ScriptRuntimeException BadArgumentIndexOutOfRange(string funcName, int argNum)
		{
			return null;
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0xD1F688", Offset = "0xD1F688", VA = "0xD1F688")]
		public static ScriptRuntimeException BadArgumentNoNegativeNumbers(int argNum, string funcName)
		{
			return null;
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0xD1F7C4", Offset = "0xD1F7C4", VA = "0xD1F7C4")]
		public static ScriptRuntimeException BadArgumentValueExpected(int argNum, string funcName)
		{
			return null;
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0xD1F900", Offset = "0xD1F900", VA = "0xD1F900")]
		public static ScriptRuntimeException IndexType(DynValue obj)
		{
			return null;
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0xD1F9E4", Offset = "0xD1F9E4", VA = "0xD1F9E4")]
		public static ScriptRuntimeException LoopInIndex()
		{
			return null;
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0xD1FA54", Offset = "0xD1FA54", VA = "0xD1FA54")]
		public static ScriptRuntimeException LoopInNewIndex()
		{
			return null;
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0xD1FAC4", Offset = "0xD1FAC4", VA = "0xD1FAC4")]
		public static ScriptRuntimeException LoopInCall()
		{
			return null;
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0xD1BF70", Offset = "0xD1BF70", VA = "0xD1BF70")]
		public static ScriptRuntimeException TableIndexIsNil()
		{
			return null;
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0xD1C08C", Offset = "0xD1C08C", VA = "0xD1C08C")]
		public static ScriptRuntimeException TableIndexIsNaN()
		{
			return null;
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0xD1FB34", Offset = "0xD1FB34", VA = "0xD1FB34")]
		public static ScriptRuntimeException ConvertToNumberFailed(int stage)
		{
			return null;
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0xD1FC30", Offset = "0xD1FC30", VA = "0xD1FC30")]
		public static ScriptRuntimeException ConvertObjectFailed(object obj)
		{
			return null;
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0xD1FD18", Offset = "0xD1FD18", VA = "0xD1FD18")]
		public static ScriptRuntimeException ConvertObjectFailed(DataType t)
		{
			return null;
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0xD1FE3C", Offset = "0xD1FE3C", VA = "0xD1FE3C")]
		public static ScriptRuntimeException ConvertObjectFailed(DataType t, Type t2)
		{
			return null;
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0xD1FFA8", Offset = "0xD1FFA8", VA = "0xD1FFA8")]
		public static ScriptRuntimeException UserDataArgumentTypeMismatch(DataType t, Type clrType)
		{
			return null;
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0xD20114", Offset = "0xD20114", VA = "0xD20114")]
		public static ScriptRuntimeException UserDataMissingField(string typename, string fieldname)
		{
			return null;
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0xD16B98", Offset = "0xD16B98", VA = "0xD16B98")]
		public static ScriptRuntimeException CannotResumeNotSuspended(CoroutineState state)
		{
			return null;
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0xD2021C", Offset = "0xD2021C", VA = "0xD2021C")]
		public static ScriptRuntimeException CannotYield()
		{
			return null;
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0xD2028C", Offset = "0xD2028C", VA = "0xD2028C")]
		public static ScriptRuntimeException CannotYieldMain()
		{
			return null;
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0xD202FC", Offset = "0xD202FC", VA = "0xD202FC")]
		public static ScriptRuntimeException AttemptToCallNonFunc(DataType type, [Optional] string debugText)
		{
			return null;
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0xD20474", Offset = "0xD20474", VA = "0xD20474")]
		public static ScriptRuntimeException AccessInstanceMemberOnStatics(IMemberDescriptor desc)
		{
			return null;
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0xD205C0", Offset = "0xD205C0", VA = "0xD205C0")]
		public static ScriptRuntimeException AccessInstanceMemberOnStatics(IUserDataDescriptor typeDescr, IMemberDescriptor desc)
		{
			return null;
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0xD207B4", Offset = "0xD207B4", VA = "0xD207B4", Slot = "13")]
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
			[Address(RVA = "0xD2088C", Offset = "0xD2088C", VA = "0xD2088C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001B6")]
			[Address(RVA = "0xD20894", Offset = "0xD20894", VA = "0xD20894")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700005B")]
		public bool IsPrematureStreamTermination
		{
			[Token(Token = "0x60001B7")]
			[Address(RVA = "0xD2089C", Offset = "0xD2089C", VA = "0xD2089C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001B8")]
			[Address(RVA = "0xD208A4", Offset = "0xD208A4", VA = "0xD208A4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0xD208B0", Offset = "0xD208B0", VA = "0xD208B0")]
		internal SyntaxErrorException(Token t, string format, params object[] args)
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0xD208DC", Offset = "0xD208DC", VA = "0xD208DC")]
		internal SyntaxErrorException(Token t, string message)
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0xD20904", Offset = "0xD20904", VA = "0xD20904")]
		internal SyntaxErrorException(Script script, SourceRef sref, string format, params object[] args)
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0xD20940", Offset = "0xD20940", VA = "0xD20940")]
		internal SyntaxErrorException(Script script, SourceRef sref, string message)
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0xD20978", Offset = "0xD20978", VA = "0xD20978")]
		private SyntaxErrorException(SyntaxErrorException syntaxErrorException)
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0xD209C0", Offset = "0xD209C0", VA = "0xD209C0")]
		internal void DecorateMessage(Script script)
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0xD20AA0", Offset = "0xD20AA0", VA = "0xD20AA0", Slot = "13")]
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
			[Address(RVA = "0xD20D3C", Offset = "0xD20D3C", VA = "0xD20D3C", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001C5")]
			[Address(RVA = "0xD20D44", Offset = "0xD20D44", VA = "0xD20D44")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0xD20B78", Offset = "0xD20B78", VA = "0xD20B78")]
		internal DynamicExpression(Script S, string strExpr, DynamicExprExpression expr)
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0xD20BB4", Offset = "0xD20BB4", VA = "0xD20BB4")]
		internal DynamicExpression(Script S, string strExpr, DynValue constant)
		{
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0xD20BF0", Offset = "0xD20BF0", VA = "0xD20BF0")]
		public DynValue Evaluate([Optional] ScriptExecutionContext context)
		{
			return null;
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0xD20CE8", Offset = "0xD20CE8", VA = "0xD20CE8")]
		public SymbolRef FindSymbol(ScriptExecutionContext context)
		{
			return null;
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0xD20D4C", Offset = "0xD20D4C", VA = "0xD20D4C")]
		public bool IsConstant()
		{
			return default(bool);
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0xD20D5C", Offset = "0xD20D5C", VA = "0xD20D5C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0xD20D7C", Offset = "0xD20D7C", VA = "0xD20D7C", Slot = "0")]
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
			[Address(RVA = "0xD20E60", Offset = "0xD20E60", VA = "0xD20E60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001CB")]
			[Address(RVA = "0xD20E68", Offset = "0xD20E68", VA = "0xD20E68")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700005E")]
		public SourceRef CallingLocation
		{
			[Token(Token = "0x60001CC")]
			[Address(RVA = "0xD20E74", Offset = "0xD20E74", VA = "0xD20E74")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001CD")]
			[Address(RVA = "0xD20E7C", Offset = "0xD20E7C", VA = "0xD20E7C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700005F")]
		public object AdditionalData
		{
			[Token(Token = "0x60001CE")]
			[Address(RVA = "0xD20E84", Offset = "0xD20E84", VA = "0xD20E84")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001CF")]
			[Address(RVA = "0xD20E9C", Offset = "0xD20E9C", VA = "0xD20E9C")]
			set
			{
			}
		}

		[Token(Token = "0x17000060")]
		public Table CurrentGlobalEnv
		{
			[Token(Token = "0x60001DB")]
			[Address(RVA = "0xD21360", Offset = "0xD21360", VA = "0xD21360")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000061")]
		public Script OwnerScript
		{
			[Token(Token = "0x60001DD")]
			[Address(RVA = "0xD2144C", Offset = "0xD2144C", VA = "0xD2144C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0xD20E18", Offset = "0xD20E18", VA = "0xD20E18")]
		internal ScriptExecutionContext(Processor p, CallbackFunction callBackFunction, SourceRef sourceRef, bool isDynamic = false)
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0xD20F00", Offset = "0xD20F00", VA = "0xD20F00")]
		public Table GetMetatable(DynValue value)
		{
			return null;
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0xD20F1C", Offset = "0xD20F1C", VA = "0xD20F1C")]
		public DynValue GetMetamethod(DynValue value, string metamethod)
		{
			return null;
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0xD20F38", Offset = "0xD20F38", VA = "0xD20F38")]
		public DynValue GetMetamethodTailCall(DynValue value, string metamethod, params DynValue[] args)
		{
			return null;
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0xD20FD8", Offset = "0xD20FD8", VA = "0xD20FD8")]
		public DynValue GetBinaryMetamethod(DynValue op1, DynValue op2, string eventName)
		{
			return null;
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0xD14F70", Offset = "0xD14F70", VA = "0xD14F70")]
		public Script GetScript()
		{
			return null;
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0xD20FF4", Offset = "0xD20FF4", VA = "0xD20FF4")]
		public Coroutine GetCallingCoroutine()
		{
			return null;
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0xD21010", Offset = "0xD21010", VA = "0xD21010")]
		public DynValue EmulateClassicCall(CallbackArguments args, string functionName, Func<LuaState, int> callback)
		{
			return null;
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0xD210B8", Offset = "0xD210B8", VA = "0xD210B8")]
		public DynValue Call(DynValue func, params DynValue[] args)
		{
			return null;
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0xD21264", Offset = "0xD21264", VA = "0xD21264")]
		public DynValue EvaluateSymbol(SymbolRef symref)
		{
			return null;
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0xD21318", Offset = "0xD21318", VA = "0xD21318")]
		public DynValue EvaluateSymbolByName(string symbol)
		{
			return null;
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0xD21344", Offset = "0xD21344", VA = "0xD21344")]
		public SymbolRef FindSymbolByName(string symbol)
		{
			return null;
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0xD213CC", Offset = "0xD213CC", VA = "0xD213CC")]
		public void PerformMessageDecorationBeforeUnwind(DynValue messageHandler, ScriptRuntimeException exception)
		{
		}
	}
	[Token(Token = "0x2000033")]
	[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event, Inherited = true, AllowMultiple = false)]
	public sealed class MoonSharpHiddenAttribute : Attribute
	{
		[Token(Token = "0x60001DE")]
		[Address(RVA = "0xD21468", Offset = "0xD21468", VA = "0xD21468")]
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
			[Address(RVA = "0xD21470", Offset = "0xD21470", VA = "0xD21470")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001E0")]
			[Address(RVA = "0xD21478", Offset = "0xD21478", VA = "0xD21478")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0xD21480", Offset = "0xD21480", VA = "0xD21480")]
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
			[Address(RVA = "0xD214A8", Offset = "0xD214A8", VA = "0xD214A8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001E3")]
			[Address(RVA = "0xD214B0", Offset = "0xD214B0", VA = "0xD214B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0xD214B8", Offset = "0xD214B8", VA = "0xD214B8")]
		public MoonSharpPropertyAttribute()
		{
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0xD214C0", Offset = "0xD214C0", VA = "0xD214C0")]
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
			[Address(RVA = "0xD214E8", Offset = "0xD214E8", VA = "0xD214E8")]
			[CompilerGenerated]
			get
			{
				return default(InteropAccessMode);
			}
			[Token(Token = "0x60001E7")]
			[Address(RVA = "0xD214F0", Offset = "0xD214F0", VA = "0xD214F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0xD214F8", Offset = "0xD214F8", VA = "0xD214F8")]
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
			[Address(RVA = "0xD21518", Offset = "0xD21518", VA = "0xD21518")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001EA")]
			[Address(RVA = "0xD21520", Offset = "0xD21520", VA = "0xD21520")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0xD21528", Offset = "0xD21528", VA = "0xD21528")]
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
			[Address(RVA = "0xD2157C", Offset = "0xD2157C", VA = "0xD2157C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000067")]
		public Type Type
		{
			[Token(Token = "0x60001EE")]
			[Address(RVA = "0xD21584", Offset = "0xD21584", VA = "0xD21584", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0xD21550", Offset = "0xD21550", VA = "0xD21550")]
		public AutoDescribingUserDataDescriptor(Type type, string friendlyName)
		{
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0xD2158C", Offset = "0xD2158C", VA = "0xD2158C", Slot = "6")]
		public DynValue Index(Script script, object obj, DynValue index, bool isDirectIndexing)
		{
			return null;
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0xD21670", Offset = "0xD21670", VA = "0xD21670", Slot = "7")]
		public bool SetIndex(Script script, object obj, DynValue index, DynValue value, bool isDirectIndexing)
		{
			return default(bool);
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0xD21760", Offset = "0xD21760", VA = "0xD21760", Slot = "8")]
		public string AsString(object obj)
		{
			return null;
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0xD21780", Offset = "0xD21780", VA = "0xD21780", Slot = "9")]
		public DynValue MetaIndex(Script script, object obj, string metaname)
		{
			return null;
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0xD21854", Offset = "0xD21854", VA = "0xD21854", Slot = "10")]
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
		[Address(RVA = "0xD21908", Offset = "0xD21908", VA = "0xD21908")]
		public static IEnumerable<DynValue> OfDataType(this IEnumerable<DynValue> enumerable, DataType type)
		{
			return null;
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0xD219E4", Offset = "0xD219E4", VA = "0xD219E4")]
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
		[Address(RVA = "0xD21B84", Offset = "0xD21B84", VA = "0xD21B84")]
		public static bool Has(this CoreModules val, CoreModules flag)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000042")]
	public static class ModuleRegister
	{
		[Token(Token = "0x6000206")]
		[Address(RVA = "0xD21B90", Offset = "0xD21B90", VA = "0xD21B90")]
		public static Table RegisterCoreModules(this Table table, CoreModules modules)
		{
			return null;
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0xD21F60", Offset = "0xD21F60", VA = "0xD21F60")]
		public static Table RegisterConstants(this Table table)
		{
			return null;
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0xD226A0", Offset = "0xD226A0", VA = "0xD226A0")]
		public static Table RegisterModuleType(this Table gtable, Type t)
		{
			return null;
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0xD23D60", Offset = "0xD23D60", VA = "0xD23D60")]
		private static void RegisterScriptFieldAsConst(FieldInfo fi, object o, Table table, Type t, string name)
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0xD23BCC", Offset = "0xD23BCC", VA = "0xD23BCC")]
		private static void RegisterScriptField(FieldInfo fi, object o, Table table, Type t, string name)
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0xD23888", Offset = "0xD23888", VA = "0xD23888")]
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
			[Address(RVA = "0xD243F4", Offset = "0xD243F4", VA = "0xD243F4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000213")]
			[Address(RVA = "0xD243FC", Offset = "0xD243FC", VA = "0xD243FC")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0xD24404", Offset = "0xD24404", VA = "0xD24404")]
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
			[Address(RVA = "0xD2440C", Offset = "0xD2440C", VA = "0xD2440C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000216")]
			[Address(RVA = "0xD24414", Offset = "0xD24414", VA = "0xD24414")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0xD2441C", Offset = "0xD2441C", VA = "0xD2441C")]
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
			[Address(RVA = "0xD24424", Offset = "0xD24424", VA = "0xD24424")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000219")]
			[Address(RVA = "0xD2442C", Offset = "0xD2442C", VA = "0xD2442C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0xD24434", Offset = "0xD24434", VA = "0xD24434")]
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
			[Address(RVA = "0xD2496C", Offset = "0xD2496C", VA = "0xD2496C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600021F")]
			[Address(RVA = "0xD249C4", Offset = "0xD249C4", VA = "0xD249C4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700006C")]
		public ScriptOptions Options
		{
			[Token(Token = "0x6000220")]
			[Address(RVA = "0xD24A20", Offset = "0xD24A20", VA = "0xD24A20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000221")]
			[Address(RVA = "0xD24A28", Offset = "0xD24A28", VA = "0xD24A28")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700006D")]
		public static ScriptGlobalOptions GlobalOptions
		{
			[Token(Token = "0x6000222")]
			[Address(RVA = "0xD24A30", Offset = "0xD24A30", VA = "0xD24A30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000223")]
			[Address(RVA = "0xD24A88", Offset = "0xD24A88", VA = "0xD24A88")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700006E")]
		public PerformanceStatistics PerformanceStats
		{
			[Token(Token = "0x6000224")]
			[Address(RVA = "0xD24AE4", Offset = "0xD24AE4", VA = "0xD24AE4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000225")]
			[Address(RVA = "0xD24AEC", Offset = "0xD24AEC", VA = "0xD24AEC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700006F")]
		public Table Globals
		{
			[Token(Token = "0x6000226")]
			[Address(RVA = "0xD24AF4", Offset = "0xD24AF4", VA = "0xD24AF4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000070")]
		public bool DebuggerEnabled
		{
			[Token(Token = "0x600023B")]
			[Address(RVA = "0xD264B8", Offset = "0xD264B8", VA = "0xD264B8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600023C")]
			[Address(RVA = "0xD264D4", Offset = "0xD264D4", VA = "0xD264D4")]
			set
			{
			}
		}

		[Token(Token = "0x17000071")]
		public int SourceCodeCount
		{
			[Token(Token = "0x600023F")]
			[Address(RVA = "0xD266C4", Offset = "0xD266C4", VA = "0xD266C4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000072")]
		public Table Registry
		{
			[Token(Token = "0x6000247")]
			[Address(RVA = "0xD26BAC", Offset = "0xD26BAC", VA = "0xD26BAC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000248")]
			[Address(RVA = "0xD26BB4", Offset = "0xD26BB4", VA = "0xD26BB4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000073")]
		private Script MoonSharp.Interpreter.IScriptPrivateResource.OwnerScript
		{
			[Token(Token = "0x600024A")]
			[Address(RVA = "0xD26BBC", Offset = "0xD26BBC", VA = "0xD26BBC", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0xD2443C", Offset = "0xD2443C", VA = "0xD2443C")]
		static Script()
		{
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0xD246B8", Offset = "0xD246B8", VA = "0xD246B8")]
		public Script()
		{
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0xD246C4", Offset = "0xD246C4", VA = "0xD246C4")]
		public Script(CoreModules coreModules)
		{
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0xD23FEC", Offset = "0xD23FEC", VA = "0xD23FEC")]
		public DynValue LoadFunction(string code, [Optional] Table globalTable, [Optional] string funcFriendlyName)
		{
			return null;
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0xD24BB0", Offset = "0xD24BB0", VA = "0xD24BB0")]
		private void SignalByteCodeChange()
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0xD24AFC", Offset = "0xD24AFC", VA = "0xD24AFC")]
		private void SignalSourceCodeChange(SourceCode source)
		{
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0xD25080", Offset = "0xD25080", VA = "0xD25080")]
		public DynValue LoadString(string code, [Optional] Table globalTable, [Optional] string codeFriendlyName)
		{
			return null;
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0xD2546C", Offset = "0xD2546C", VA = "0xD2546C")]
		public DynValue LoadStream(Stream stream, [Optional] Table globalTable, [Optional] string codeFriendlyName)
		{
			return null;
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0xD258B8", Offset = "0xD258B8", VA = "0xD258B8")]
		public void Dump(DynValue function, Stream stream)
		{
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0xD25A38", Offset = "0xD25A38", VA = "0xD25A38")]
		public DynValue LoadFile(string filename, [Optional] Table globalContext, [Optional] string friendlyFilename)
		{
			return null;
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0xD25FF4", Offset = "0xD25FF4", VA = "0xD25FF4")]
		public DynValue DoString(string code, [Optional] Table globalContext, [Optional] string codeFriendlyName)
		{
			return null;
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0xD26074", Offset = "0xD26074", VA = "0xD26074")]
		public DynValue DoStream(Stream stream, [Optional] Table globalContext, [Optional] string codeFriendlyName)
		{
			return null;
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0xD26090", Offset = "0xD26090", VA = "0xD26090")]
		public DynValue DoFile(string filename, [Optional] Table globalContext, [Optional] string codeFriendlyName)
		{
			return null;
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0xD260AC", Offset = "0xD260AC", VA = "0xD260AC")]
		public static DynValue RunFile(string filename)
		{
			return null;
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0xD26128", Offset = "0xD26128", VA = "0xD26128")]
		public static DynValue RunString(string code)
		{
			return null;
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0xD24D60", Offset = "0xD24D60", VA = "0xD24D60")]
		private DynValue MakeClosure(int address, [Optional] Table envTable)
		{
			return null;
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0xD26010", Offset = "0xD26010", VA = "0xD26010")]
		public DynValue Call(DynValue function)
		{
			return null;
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0xD14F8C", Offset = "0xD14F8C", VA = "0xD14F8C")]
		public DynValue Call(DynValue function, params DynValue[] args)
		{
			return null;
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0xD261A4", Offset = "0xD261A4", VA = "0xD261A4")]
		public DynValue Call(DynValue function, params object[] args)
		{
			return null;
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0xD15F6C", Offset = "0xD15F6C", VA = "0xD15F6C")]
		public DynValue Call(object function)
		{
			return null;
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0xD16004", Offset = "0xD16004", VA = "0xD16004")]
		public DynValue Call(object function, params object[] args)
		{
			return null;
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0xD262D0", Offset = "0xD262D0", VA = "0xD262D0")]
		public DynValue CreateCoroutine(DynValue function)
		{
			return null;
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0xD26444", Offset = "0xD26444", VA = "0xD26444")]
		public DynValue CreateCoroutine(object function)
		{
			return null;
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0xD264F4", Offset = "0xD264F4", VA = "0xD264F4")]
		public void AttachDebugger(IDebugger debugger)
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0xD2666C", Offset = "0xD2666C", VA = "0xD2666C")]
		public SourceCode GetSourceCode(int sourceCodeID)
		{
			return null;
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0xD2670C", Offset = "0xD2670C", VA = "0xD2670C")]
		public DynValue RequireModule(string modname, [Optional] Table globalContext)
		{
			return null;
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0xD26884", Offset = "0xD26884", VA = "0xD26884")]
		public Table GetTypeMetatable(DataType type)
		{
			return null;
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0xD268C4", Offset = "0xD268C4", VA = "0xD268C4")]
		public void SetTypeMetatable(DataType type, Table metatable)
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0xD269D0", Offset = "0xD269D0", VA = "0xD269D0")]
		public static void WarmUp()
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0xD26A4C", Offset = "0xD26A4C", VA = "0xD26A4C")]
		public DynamicExpression CreateDynamicExpression(string code)
		{
			return null;
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0xD26B28", Offset = "0xD26B28", VA = "0xD26B28")]
		public DynamicExpression CreateConstantDynamicExpression(string code, DynValue constant)
		{
			return null;
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0xD20C68", Offset = "0xD20C68", VA = "0xD20C68")]
		internal ScriptExecutionContext CreateDynamicExecutionContext([Optional] CallbackFunction func)
		{
			return null;
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0xD22468", Offset = "0xD22468", VA = "0xD22468")]
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
			[Address(RVA = "0xD26E64", Offset = "0xD26E64", VA = "0xD26E64")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000252")]
			[Address(RVA = "0xD26E6C", Offset = "0xD26E6C", VA = "0xD26E6C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000075")]
		public IPlatformAccessor Platform
		{
			[Token(Token = "0x6000253")]
			[Address(RVA = "0xD26E74", Offset = "0xD26E74", VA = "0xD26E74")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000254")]
			[Address(RVA = "0xD26E7C", Offset = "0xD26E7C", VA = "0xD26E7C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000076")]
		public bool RethrowExceptionNested
		{
			[Token(Token = "0x6000255")]
			[Address(RVA = "0xD26E84", Offset = "0xD26E84", VA = "0xD26E84")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000256")]
			[Address(RVA = "0xD26E8C", Offset = "0xD26E8C", VA = "0xD26E8C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0xD24638", Offset = "0xD24638", VA = "0xD24638")]
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
			[Address(RVA = "0xD26E98", Offset = "0xD26E98", VA = "0xD26E98")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600025A")]
			[Address(RVA = "0xD26EA0", Offset = "0xD26EA0", VA = "0xD26EA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000078")]
		public Action<string> DebugPrint
		{
			[Token(Token = "0x600025B")]
			[Address(RVA = "0xD26EA8", Offset = "0xD26EA8", VA = "0xD26EA8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600025C")]
			[Address(RVA = "0xD26EB0", Offset = "0xD26EB0", VA = "0xD26EB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000079")]
		public Func<string, string> DebugInput
		{
			[Token(Token = "0x600025D")]
			[Address(RVA = "0xD26EB8", Offset = "0xD26EB8", VA = "0xD26EB8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600025E")]
			[Address(RVA = "0xD26EC0", Offset = "0xD26EC0", VA = "0xD26EC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700007A")]
		public bool UseLuaErrorLocations
		{
			[Token(Token = "0x600025F")]
			[Address(RVA = "0xD26EC8", Offset = "0xD26EC8", VA = "0xD26EC8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000260")]
			[Address(RVA = "0xD26ED0", Offset = "0xD26ED0", VA = "0xD26ED0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700007B")]
		public ColonOperatorBehaviour ColonOperatorClrCallbackBehaviour
		{
			[Token(Token = "0x6000261")]
			[Address(RVA = "0xD26EDC", Offset = "0xD26EDC", VA = "0xD26EDC")]
			[CompilerGenerated]
			get
			{
				return default(ColonOperatorBehaviour);
			}
			[Token(Token = "0x6000262")]
			[Address(RVA = "0xD26EE4", Offset = "0xD26EE4", VA = "0xD26EE4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700007C")]
		public Stream Stdin
		{
			[Token(Token = "0x6000263")]
			[Address(RVA = "0xD26EEC", Offset = "0xD26EEC", VA = "0xD26EEC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000264")]
			[Address(RVA = "0xD26EF4", Offset = "0xD26EF4", VA = "0xD26EF4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700007D")]
		public Stream Stdout
		{
			[Token(Token = "0x6000265")]
			[Address(RVA = "0xD26EFC", Offset = "0xD26EFC", VA = "0xD26EFC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000266")]
			[Address(RVA = "0xD26F04", Offset = "0xD26F04", VA = "0xD26F04")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700007E")]
		public Stream Stderr
		{
			[Token(Token = "0x6000267")]
			[Address(RVA = "0xD26F0C", Offset = "0xD26F0C", VA = "0xD26F0C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000268")]
			[Address(RVA = "0xD26F14", Offset = "0xD26F14", VA = "0xD26F14")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700007F")]
		public int TailCallOptimizationThreshold
		{
			[Token(Token = "0x6000269")]
			[Address(RVA = "0xD26F1C", Offset = "0xD26F1C", VA = "0xD26F1C")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600026A")]
			[Address(RVA = "0xD26F24", Offset = "0xD26F24", VA = "0xD26F24")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000080")]
		public bool CheckThreadAccess
		{
			[Token(Token = "0x600026B")]
			[Address(RVA = "0xD26F2C", Offset = "0xD26F2C", VA = "0xD26F2C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600026C")]
			[Address(RVA = "0xD26F34", Offset = "0xD26F34", VA = "0xD26F34")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0xD246B0", Offset = "0xD246B0", VA = "0xD246B0")]
		internal ScriptOptions()
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0xD24908", Offset = "0xD24908", VA = "0xD24908")]
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
		[Address(RVA = "0xD26F40", Offset = "0xD26F40", VA = "0xD26F40")]
		public Expression(ScriptLoadingContext lcontext)
		{
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0xD26FA8", Offset = "0xD26FA8", VA = "0xD26FA8", Slot = "5")]
		public virtual string GetFriendlyDebugName()
		{
			return null;
		}

		[Token(Token = "0x600026F")]
		public abstract DynValue Eval(ScriptExecutionContext context);

		[Token(Token = "0x6000270")]
		[Address(RVA = "0xD26FB0", Offset = "0xD26FB0", VA = "0xD26FB0", Slot = "7")]
		public virtual SymbolRef FindDynamic(ScriptExecutionContext context)
		{
			return null;
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0xD26FB8", Offset = "0xD26FB8", VA = "0xD26FB8")]
		internal static List<Expression> ExprListAfterFirstExpr(ScriptLoadingContext lcontext, Expression expr1)
		{
			return null;
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0xD27198", Offset = "0xD27198", VA = "0xD27198")]
		internal static List<Expression> ExprList(ScriptLoadingContext lcontext)
		{
			return null;
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0xD2716C", Offset = "0xD2716C", VA = "0xD2716C")]
		internal static Expression Expr(ScriptLoadingContext lcontext)
		{
			return null;
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0xD272FC", Offset = "0xD272FC", VA = "0xD272FC")]
		internal static Expression SubExpr(ScriptLoadingContext lcontext, bool isPrimary)
		{
			return null;
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0xD277B0", Offset = "0xD277B0", VA = "0xD277B0")]
		internal static Expression SimpleExp(ScriptLoadingContext lcontext)
		{
			return null;
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0xD279E8", Offset = "0xD279E8", VA = "0xD279E8")]
		internal static Expression PrimaryExp(ScriptLoadingContext lcontext)
		{
			return null;
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0xD27C98", Offset = "0xD27C98", VA = "0xD27C98")]
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
			[Address(RVA = "0xD27174", Offset = "0xD27174", VA = "0xD27174")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0xD280EC", Offset = "0xD280EC", VA = "0xD280EC")]
		public Lexer(int sourceID, string scriptContent, bool autoSkipComments)
		{
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0xD28184", Offset = "0xD28184", VA = "0xD28184")]
		private Token FetchNewToken()
		{
			return null;
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0xD27154", Offset = "0xD27154", VA = "0xD27154")]
		public void Next()
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0xD28914", Offset = "0xD28914", VA = "0xD28914")]
		public Token PeekNext()
		{
			return null;
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0xD28964", Offset = "0xD28964", VA = "0xD28964")]
		private void CursorNext()
		{
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0xD289F4", Offset = "0xD289F4", VA = "0xD289F4")]
		private char CursorChar()
		{
			return default(char);
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0xD28A30", Offset = "0xD28A30", VA = "0xD28A30")]
		private char CursorCharNext()
		{
			return default(char);
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0xD28A48", Offset = "0xD28A48", VA = "0xD28A48")]
		private bool CursorMatches(string pattern)
		{
			return default(bool);
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0xD289CC", Offset = "0xD289CC", VA = "0xD289CC")]
		private bool CursorNotEof()
		{
			return default(bool);
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0xD28AE0", Offset = "0xD28AE0", VA = "0xD28AE0")]
		private bool IsWhiteSpace(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0xD28B38", Offset = "0xD28B38", VA = "0xD28B38")]
		private void SkipWhiteSpace()
		{
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0xD281C0", Offset = "0xD281C0", VA = "0xD281C0")]
		private Token ReadToken()
		{
			return null;
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0xD29300", Offset = "0xD29300", VA = "0xD29300")]
		private string ReadLongString(int fromLine, int fromCol, string startpattern, string subtypeforerrors)
		{
			return null;
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0xD28D3C", Offset = "0xD28D3C", VA = "0xD28D3C")]
		private Token ReadNumberToken(int fromLine, int fromCol, bool leadingDot)
		{
			return null;
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0xD28FDC", Offset = "0xD28FDC", VA = "0xD28FDC")]
		private Token CreateSingleCharToken(TokenType tokenType, int fromLine, int fromCol)
		{
			return null;
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0xD291FC", Offset = "0xD291FC", VA = "0xD291FC")]
		private Token ReadHashBang(int fromLine, int fromCol)
		{
			return null;
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0xD29044", Offset = "0xD29044", VA = "0xD29044")]
		private Token ReadComment(int fromLine, int fromCol)
		{
			return null;
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0xD29780", Offset = "0xD29780", VA = "0xD29780")]
		private Token ReadSimpleStringToken(int fromLine, int fromCol)
		{
			return null;
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0xD28C48", Offset = "0xD28C48", VA = "0xD28C48")]
		private Token PotentiallyDoubleCharOperator(char expectedSecondChar, TokenType singleCharToken, TokenType doubleCharToken, int fromLine, int fromCol)
		{
			return null;
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0xD29C38", Offset = "0xD29C38", VA = "0xD29C38")]
		private Token CreateNameToken(string name, int fromLine, int fromCol)
		{
			return null;
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0xD28B88", Offset = "0xD28B88", VA = "0xD28B88")]
		private Token CreateToken(TokenType tokenType, int fromLine, int fromCol, [Optional] string text)
		{
			return null;
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0xD29B34", Offset = "0xD29B34", VA = "0xD29B34")]
		private string ReadNameToken()
		{
			return null;
		}
	}
	[Token(Token = "0x2000050")]
	internal static class LexerUtils
	{
		[Token(Token = "0x6000290")]
		[Address(RVA = "0xD2AE70", Offset = "0xD2AE70", VA = "0xD2AE70")]
		public static double ParseNumber(Token T)
		{
			return default(double);
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0xD2AF88", Offset = "0xD2AF88", VA = "0xD2AF88")]
		public static double ParseHexInteger(Token T)
		{
			return default(double);
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0xD2B1AC", Offset = "0xD2B1AC", VA = "0xD2B1AC")]
		public static string ReadHexProgressive(string s, ref double d, out int digits)
		{
			return null;
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0xD2B3F0", Offset = "0xD2B3F0", VA = "0xD2B3F0")]
		public static double ParseHexFloat(Token T)
		{
			return default(double);
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0xD2B2EC", Offset = "0xD2B2EC", VA = "0xD2B2EC")]
		public static int HexDigit2Value(char c)
		{
			return default(int);
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0xD28D28", Offset = "0xD28D28", VA = "0xD28D28")]
		public static bool CharIsDigit(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0xD29D88", Offset = "0xD29D88", VA = "0xD29D88")]
		public static bool CharIsHexDigit(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0xD29CE0", Offset = "0xD29CE0", VA = "0xD29CE0")]
		public static string AdjustLuaLongString(string str)
		{
			return null;
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0xD29DDC", Offset = "0xD29DDC", VA = "0xD29DDC")]
		public static string UnescapeLuaString(Token token, string str)
		{
			return null;
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0xD2B920", Offset = "0xD2B920", VA = "0xD2B920")]
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
			[Address(RVA = "0xD2B978", Offset = "0xD2B978", VA = "0xD2B978")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600029B")]
			[Address(RVA = "0xD2B980", Offset = "0xD2B980", VA = "0xD2B980")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0xD2AE08", Offset = "0xD2AE08", VA = "0xD2AE08")]
		public Token(TokenType type, int sourceId, int fromLine, int fromCol, int toLine, int toCol, int prevLine, int prevCol)
		{
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0xD2B988", Offset = "0xD2B988", VA = "0xD2B988", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0xD2A718", Offset = "0xD2A718", VA = "0xD2A718")]
		public static TokenType? GetReservedTokenType(string reservedWord)
		{
			return null;
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0xD2BC18", Offset = "0xD2BC18", VA = "0xD2BC18")]
		public double GetNumberValue()
		{
			return default(double);
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0xD2BC9C", Offset = "0xD2BC9C", VA = "0xD2BC9C")]
		public bool IsEndOfBlock()
		{
			return default(bool);
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0xD27784", Offset = "0xD27784", VA = "0xD27784")]
		public bool IsUnaryOperator()
		{
			return default(bool);
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0xD279A8", Offset = "0xD279A8", VA = "0xD279A8")]
		public bool IsBinaryOperator()
		{
			return default(bool);
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0xD20A08", Offset = "0xD20A08", VA = "0xD20A08")]
		internal SourceRef GetSourceRef(bool isStepStop = true)
		{
			return null;
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0xD2BCD0", Offset = "0xD2BCD0", VA = "0xD2BCD0")]
		internal SourceRef GetSourceRef(Token to, bool isStepStop = true)
		{
			return null;
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0xD2BD74", Offset = "0xD2BD74", VA = "0xD2BD74")]
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
		[Address(RVA = "0xD2BE14", Offset = "0xD2BE14", VA = "0xD2BE14", Slot = "4")]
		public void CompileBreak(ByteCode bc)
		{
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0xD2BEEC", Offset = "0xD2BEEC", VA = "0xD2BEEC", Slot = "5")]
		public bool IsBoundary()
		{
			return default(bool);
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0xD2BEF4", Offset = "0xD2BEF4", VA = "0xD2BEF4")]
		public Loop()
		{
		}
	}
	[Token(Token = "0x2000054")]
	internal class LoopBoundary : ILoop
	{
		[Token(Token = "0x60002A9")]
		[Address(RVA = "0xD2BF70", Offset = "0xD2BF70", VA = "0xD2BF70", Slot = "4")]
		public void CompileBreak(ByteCode bc)
		{
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0xD2BFBC", Offset = "0xD2BFBC", VA = "0xD2BFBC", Slot = "5")]
		public bool IsBoundary()
		{
			return default(bool);
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0xD2BFC4", Offset = "0xD2BFC4", VA = "0xD2BFC4")]
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
			[Address(RVA = "0xD2BFCC", Offset = "0xD2BFCC", VA = "0xD2BFCC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60002AD")]
			[Address(RVA = "0xD2BFD4", Offset = "0xD2BFD4", VA = "0xD2BFD4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000084")]
		protected ScriptLoadingContext LoadingContext
		{
			[Token(Token = "0x60002AE")]
			[Address(RVA = "0xD2BFDC", Offset = "0xD2BFDC", VA = "0xD2BFDC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60002AF")]
			[Address(RVA = "0xD2BFE4", Offset = "0xD2BFE4", VA = "0xD2BFE4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0xD26F74", Offset = "0xD26F74", VA = "0xD26F74")]
		public NodeBase(ScriptLoadingContext lcontext)
		{
		}

		[Token(Token = "0x60002B1")]
		public abstract void Compile(ByteCode bc);

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0xD2BFEC", Offset = "0xD2BFEC", VA = "0xD2BFEC")]
		protected static Token UnexpectedTokenType(Token t)
		{
			return null;
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0xD27E84", Offset = "0xD27E84", VA = "0xD27E84")]
		protected static Token CheckTokenType(ScriptLoadingContext lcontext, TokenType tokenType)
		{
			return null;
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0xD2C0B0", Offset = "0xD2C0B0", VA = "0xD2C0B0")]
		protected static Token CheckTokenType(ScriptLoadingContext lcontext, TokenType tokenType1, TokenType tokenType2)
		{
			return null;
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0xD2C138", Offset = "0xD2C138", VA = "0xD2C138")]
		protected static Token CheckTokenType(ScriptLoadingContext lcontext, TokenType tokenType1, TokenType tokenType2, TokenType tokenType3)
		{
			return null;
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0xD2C1D4", Offset = "0xD2C1D4", VA = "0xD2C1D4")]
		protected static void CheckTokenTypeNotNext(ScriptLoadingContext lcontext, TokenType tokenType)
		{
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0xD27F00", Offset = "0xD27F00", VA = "0xD27F00")]
		protected static Token CheckMatch(ScriptLoadingContext lcontext, Token originalToken, TokenType expectedTokenType, string expectedTokenText)
		{
			return null;
		}
	}
	[Token(Token = "0x2000056")]
	internal abstract class Statement : NodeBase
	{
		[Token(Token = "0x60002B8")]
		[Address(RVA = "0xD2C224", Offset = "0xD2C224", VA = "0xD2C224")]
		public Statement(ScriptLoadingContext lcontext)
		{
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0xD2C258", Offset = "0xD2C258", VA = "0xD2C258")]
		protected static Statement CreateStatement(ScriptLoadingContext lcontext, out bool forceLast)
		{
			return null;
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0xD2C6C8", Offset = "0xD2C6C8", VA = "0xD2C6C8")]
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
		[Address(RVA = "0xD2C7C8", Offset = "0xD2C7C8", VA = "0xD2C7C8")]
		public AssignmentStatement(ScriptLoadingContext lcontext, Token startToken)
		{
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0xD2CD8C", Offset = "0xD2CD8C", VA = "0xD2CD8C")]
		public AssignmentStatement(ScriptLoadingContext lcontext, Expression firstExpression, Token first)
		{
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0xD2D044", Offset = "0xD2D044", VA = "0xD2D044")]
		private IVariable CheckVar(ScriptLoadingContext lcontext, Expression firstExpression)
		{
			return null;
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0xD2D170", Offset = "0xD2D170", VA = "0xD2D170", Slot = "4")]
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
		[Address(RVA = "0xD2CCA8", Offset = "0xD2CCA8", VA = "0xD2CCA8")]
		public BreakStatement(ScriptLoadingContext lcontext)
		{
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0xD2D5CC", Offset = "0xD2D5CC", VA = "0xD2D5CC", Slot = "4")]
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
		[Address(RVA = "0xD2DAA4", Offset = "0xD2DAA4", VA = "0xD2DAA4")]
		public ChunkStatement(ScriptLoadingContext lcontext)
		{
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0xD2DE0C", Offset = "0xD2DE0C", VA = "0xD2DE0C", Slot = "4")]
		public override void Compile(ByteCode bc)
		{
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0xD2DFDC", Offset = "0xD2DFDC", VA = "0xD2DFDC", Slot = "5")]
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
		[Address(RVA = "0xD2DC94", Offset = "0xD2DC94", VA = "0xD2DC94")]
		public CompositeStatement(ScriptLoadingContext lcontext)
		{
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0xD2DFE4", Offset = "0xD2DFE4", VA = "0xD2DFE4", Slot = "4")]
		public override void Compile(ByteCode bc)
		{
		}
	}
	[Token(Token = "0x200005B")]
	internal class EmptyStatement : Statement
	{
		[Token(Token = "0x60002C6")]
		[Address(RVA = "0xD2E138", Offset = "0xD2E138", VA = "0xD2E138")]
		public EmptyStatement(ScriptLoadingContext lcontext)
		{
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0xD2E140", Offset = "0xD2E140", VA = "0xD2E140", Slot = "4")]
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
		[Address(RVA = "0xD2E144", Offset = "0xD2E144", VA = "0xD2E144")]
		public ForEachLoopStatement(ScriptLoadingContext lcontext, Token firstNameToken, Token forToken)
		{
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0xD2E6CC", Offset = "0xD2E6CC", VA = "0xD2E6CC", Slot = "4")]
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
		[Address(RVA = "0xD2EC20", Offset = "0xD2EC20", VA = "0xD2EC20")]
		public ForLoopStatement(ScriptLoadingContext lcontext, Token nameToken, Token forToken)
		{
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0xD2EF44", Offset = "0xD2EF44", VA = "0xD2EF44", Slot = "4")]
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
		[Address(RVA = "0xD2F2A8", Offset = "0xD2F2A8", VA = "0xD2F2A8")]
		public FunctionCallStatement(ScriptLoadingContext lcontext, FunctionCallExpression functionCallExpression)
		{
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0xD2F384", Offset = "0xD2F384", VA = "0xD2F384", Slot = "4")]
		public override void Compile(ByteCode bc)
		{
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0xD2F544", Offset = "0xD2F544", VA = "0xD2F544")]
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
		[Address(RVA = "0xD2F55C", Offset = "0xD2F55C", VA = "0xD2F55C")]
		public FunctionDefinitionStatement(ScriptLoadingContext lcontext, bool local, Token localToken)
		{
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0xD2F9A8", Offset = "0xD2F9A8", VA = "0xD2F9A8", Slot = "4")]
		public override void Compile(ByteCode bc)
		{
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0xD2FFA8", Offset = "0xD2FFA8", VA = "0xD2FFA8")]
		private int SetMethod(ByteCode bc)
		{
			return default(int);
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0xD3019C", Offset = "0xD3019C", VA = "0xD3019C")]
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
			[Address(RVA = "0xD30258", Offset = "0xD30258", VA = "0xD30258")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60002DB")]
			[Address(RVA = "0xD30260", Offset = "0xD30260", VA = "0xD30260")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000086")]
		internal Token GotoToken
		{
			[Token(Token = "0x60002DC")]
			[Address(RVA = "0xD30268", Offset = "0xD30268", VA = "0xD30268")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60002DD")]
			[Address(RVA = "0xD30270", Offset = "0xD30270", VA = "0xD30270")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000087")]
		public string Label
		{
			[Token(Token = "0x60002DE")]
			[Address(RVA = "0xD30278", Offset = "0xD30278", VA = "0xD30278")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60002DF")]
			[Address(RVA = "0xD30280", Offset = "0xD30280", VA = "0xD30280")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000088")]
		internal int DefinedVarsCount
		{
			[Token(Token = "0x60002E0")]
			[Address(RVA = "0xD30288", Offset = "0xD30288", VA = "0xD30288")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002E1")]
			[Address(RVA = "0xD30290", Offset = "0xD30290", VA = "0xD30290")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000089")]
		internal string LastDefinedVarName
		{
			[Token(Token = "0x60002E2")]
			[Address(RVA = "0xD30298", Offset = "0xD30298", VA = "0xD30298")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60002E3")]
			[Address(RVA = "0xD302A0", Offset = "0xD302A0", VA = "0xD302A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0xD302A8", Offset = "0xD302A8", VA = "0xD302A8")]
		public GotoStatement(ScriptLoadingContext lcontext)
		{
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0xD30340", Offset = "0xD30340", VA = "0xD30340", Slot = "4")]
		public override void Compile(ByteCode bc)
		{
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0xD30378", Offset = "0xD30378", VA = "0xD30378")]
		internal void SetDefinedVars(int definedVarsCount, string lastDefinedVarsName)
		{
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0xD30384", Offset = "0xD30384", VA = "0xD30384")]
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
			[Address(RVA = "0xD308B4", Offset = "0xD308B4", VA = "0xD308B4")]
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
		[Address(RVA = "0xD30398", Offset = "0xD30398", VA = "0xD30398")]
		public IfStatement(ScriptLoadingContext lcontext)
		{
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0xD305C4", Offset = "0xD305C4", VA = "0xD305C4")]
		private IfBlock CreateIfBlock(ScriptLoadingContext lcontext)
		{
			return null;
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0xD30750", Offset = "0xD30750", VA = "0xD30750")]
		private IfBlock CreateElseBlock(ScriptLoadingContext lcontext)
		{
			return null;
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0xD308BC", Offset = "0xD308BC", VA = "0xD308BC", Slot = "4")]
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
			[Address(RVA = "0xD312EC", Offset = "0xD312EC", VA = "0xD312EC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60002EE")]
			[Address(RVA = "0xD312F4", Offset = "0xD312F4", VA = "0xD312F4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700008B")]
		public int Address
		{
			[Token(Token = "0x60002EF")]
			[Address(RVA = "0xD312FC", Offset = "0xD312FC", VA = "0xD312FC")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002F0")]
			[Address(RVA = "0xD31304", Offset = "0xD31304", VA = "0xD31304")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700008C")]
		public SourceRef SourceRef
		{
			[Token(Token = "0x60002F1")]
			[Address(RVA = "0xD3130C", Offset = "0xD3130C", VA = "0xD3130C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60002F2")]
			[Address(RVA = "0xD31314", Offset = "0xD31314", VA = "0xD31314")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700008D")]
		public Token NameToken
		{
			[Token(Token = "0x60002F3")]
			[Address(RVA = "0xD3131C", Offset = "0xD3131C", VA = "0xD3131C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60002F4")]
			[Address(RVA = "0xD31324", Offset = "0xD31324", VA = "0xD31324")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700008E")]
		internal int DefinedVarsCount
		{
			[Token(Token = "0x60002F5")]
			[Address(RVA = "0xD3132C", Offset = "0xD3132C", VA = "0xD3132C")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002F6")]
			[Address(RVA = "0xD31334", Offset = "0xD31334", VA = "0xD31334")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700008F")]
		internal string LastDefinedVarName
		{
			[Token(Token = "0x60002F7")]
			[Address(RVA = "0xD3133C", Offset = "0xD3133C", VA = "0xD3133C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60002F8")]
			[Address(RVA = "0xD31344", Offset = "0xD31344", VA = "0xD31344")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0xD3134C", Offset = "0xD3134C", VA = "0xD3134C")]
		public LabelStatement(ScriptLoadingContext lcontext)
		{
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0xD3144C", Offset = "0xD3144C", VA = "0xD3144C")]
		internal void SetDefinedVars(int definedVarsCount, string lastDefinedVarsName)
		{
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0xD31458", Offset = "0xD31458", VA = "0xD31458")]
		internal void RegisterGoto(GotoStatement gotostat)
		{
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0xD31500", Offset = "0xD31500", VA = "0xD31500", Slot = "4")]
		public override void Compile(ByteCode bc)
		{
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0xD31670", Offset = "0xD31670", VA = "0xD31670")]
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
		[Address(RVA = "0xD31678", Offset = "0xD31678", VA = "0xD31678")]
		public RepeatStatement(ScriptLoadingContext lcontext)
		{
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0xD31868", Offset = "0xD31868", VA = "0xD31868", Slot = "4")]
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
		[Address(RVA = "0xD31B00", Offset = "0xD31B00", VA = "0xD31B00")]
		public ReturnStatement(ScriptLoadingContext lcontext, Expression e, SourceRef sref)
		{
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0xD31BDC", Offset = "0xD31BDC", VA = "0xD31BDC")]
		public ReturnStatement(ScriptLoadingContext lcontext)
		{
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0xD31D98", Offset = "0xD31D98", VA = "0xD31D98", Slot = "4")]
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
		[Address(RVA = "0xD31F5C", Offset = "0xD31F5C", VA = "0xD31F5C")]
		public ScopeBlockStatement(ScriptLoadingContext lcontext)
		{
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0xD32120", Offset = "0xD32120", VA = "0xD32120", Slot = "4")]
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
		[Address(RVA = "0xD323E8", Offset = "0xD323E8", VA = "0xD323E8")]
		public WhileStatement(ScriptLoadingContext lcontext)
		{
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0xD325E8", Offset = "0xD325E8", VA = "0xD325E8", Slot = "4")]
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
		[Address(RVA = "0xD328B8", Offset = "0xD328B8", VA = "0xD328B8")]
		internal static DynamicExprExpression LoadDynamicExpr(Script script, SourceCode source)
		{
			return null;
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0xD32B80", Offset = "0xD32B80", VA = "0xD32B80")]
		private static ScriptLoadingContext CreateLoadingContext(Script script, SourceCode source)
		{
			return null;
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0xD32CA8", Offset = "0xD32CA8", VA = "0xD32CA8")]
		internal static int LoadChunk(Script script, SourceCode source, ByteCode bytecode)
		{
			return default(int);
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0xD33274", Offset = "0xD33274", VA = "0xD33274")]
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
		[Address(RVA = "0xD33B2C", Offset = "0xD33B2C", VA = "0xD33B2C")]
		public AdjustmentExpression(ScriptLoadingContext lcontext, Expression exp)
		{
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0xD33B54", Offset = "0xD33B54", VA = "0xD33B54", Slot = "4")]
		public override void Compile(ByteCode bc)
		{
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0xD33B88", Offset = "0xD33B88", VA = "0xD33B88", Slot = "6")]
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
			[Address(RVA = "0xD33CD8", Offset = "0xD33CD8", VA = "0xD33CD8")]
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
			[Address(RVA = "0xD33C10", Offset = "0xD33C10", VA = "0xD33C10")]
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
		[Address(RVA = "0xD33BB4", Offset = "0xD33BB4", VA = "0xD33BB4")]
		public static object BeginOperatorChain()
		{
			return null;
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0xD33C18", Offset = "0xD33C18", VA = "0xD33C18")]
		public static void AddExpressionToChain(object chain, Expression exp)
		{
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0xD33D34", Offset = "0xD33D34", VA = "0xD33D34")]
		public static void AddOperatorToChain(object chain, Token op)
		{
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0xD33F5C", Offset = "0xD33F5C", VA = "0xD33F5C")]
		public static Expression CommitOperatorChain(object chain, ScriptLoadingContext lcontext)
		{
			return null;
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0xD34118", Offset = "0xD34118", VA = "0xD34118")]
		public static Expression CreatePowerExpression(Expression op1, Expression op2, ScriptLoadingContext lcontext)
		{
			return null;
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0xD33CE0", Offset = "0xD33CE0", VA = "0xD33CE0")]
		private static void AddNode(LinkedList list, Node node)
		{
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0xD33FE0", Offset = "0xD33FE0", VA = "0xD33FE0")]
		private static Expression CreateSubTree(LinkedList list, ScriptLoadingContext lcontext)
		{
			return null;
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0xD342F0", Offset = "0xD342F0", VA = "0xD342F0")]
		private static Node PrioritizeLeftAssociative(Node nodes, ScriptLoadingContext lcontext, Operator operatorsToFind)
		{
			return null;
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0xD341D8", Offset = "0xD341D8", VA = "0xD341D8")]
		private static Node PrioritizeRightAssociative(Node nodes, ScriptLoadingContext lcontext, Operator operatorsToFind)
		{
			return null;
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0xD33DFC", Offset = "0xD33DFC", VA = "0xD33DFC")]
		private static Operator ParseBinaryOperator(Token token)
		{
			return default(Operator);
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0xD34198", Offset = "0xD34198", VA = "0xD34198")]
		private BinaryOperatorExpression(Expression exp1, Expression exp2, Operator op, ScriptLoadingContext lcontext)
		{
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0xD343FC", Offset = "0xD343FC", VA = "0xD343FC")]
		private static bool ShouldInvertBoolean(Operator op)
		{
			return default(bool);
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0xD34424", Offset = "0xD34424", VA = "0xD34424")]
		private static OpCode OperatorToOpCode(Operator op)
		{
			return default(OpCode);
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0xD345B4", Offset = "0xD345B4", VA = "0xD345B4", Slot = "4")]
		public override void Compile(ByteCode bc)
		{
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0xD346D0", Offset = "0xD346D0", VA = "0xD346D0", Slot = "6")]
		public override DynValue Eval(ScriptExecutionContext context)
		{
			return null;
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0xD34C20", Offset = "0xD34C20", VA = "0xD34C20")]
		private double EvalArithmetic(DynValue v1, DynValue v2)
		{
			return default(double);
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0xD34940", Offset = "0xD34940", VA = "0xD34940")]
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
		[Address(RVA = "0xD32C68", Offset = "0xD32C68", VA = "0xD32C68")]
		public DynamicExprExpression(Expression exp, ScriptLoadingContext lcontext)
		{
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0xD34E68", Offset = "0xD34E68", VA = "0xD34E68", Slot = "6")]
		public override DynValue Eval(ScriptExecutionContext context)
		{
			return null;
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0xD34E88", Offset = "0xD34E88", VA = "0xD34E88", Slot = "4")]
		public override void Compile(ByteCode bc)
		{
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0xD34EC8", Offset = "0xD34EC8", VA = "0xD34EC8", Slot = "7")]
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
		[Address(RVA = "0xD2E6A0", Offset = "0xD2E6A0", VA = "0xD2E6A0")]
		public ExprListExpression(List<Expression> exps, ScriptLoadingContext lcontext)
		{
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0xD34EE8", Offset = "0xD34EE8", VA = "0xD34EE8")]
		public Expression[] GetExpressions()
		{
			return null;
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0xD34F38", Offset = "0xD34F38", VA = "0xD34F38", Slot = "4")]
		public override void Compile(ByteCode bc)
		{
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0xD350C8", Offset = "0xD350C8", VA = "0xD350C8", Slot = "6")]
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
			[Address(RVA = "0xD351B8", Offset = "0xD351B8", VA = "0xD351B8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600032A")]
			[Address(RVA = "0xD351C0", Offset = "0xD351C0", VA = "0xD351C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0xD351C8", Offset = "0xD351C8", VA = "0xD351C8")]
		public FunctionCallExpression(ScriptLoadingContext lcontext, Expression function, Token thisCallName)
		{
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0xD35B4C", Offset = "0xD35B4C", VA = "0xD35B4C", Slot = "4")]
		public override void Compile(ByteCode bc)
		{
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0xD35CDC", Offset = "0xD35CDC", VA = "0xD35CDC", Slot = "6")]
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
		[Address(RVA = "0xD33840", Offset = "0xD33840", VA = "0xD33840")]
		public FunctionDefinitionExpression(ScriptLoadingContext lcontext, bool usesGlobalEnv)
		{
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0xD2F998", Offset = "0xD2F998", VA = "0xD2F998")]
		public FunctionDefinitionExpression(ScriptLoadingContext lcontext, bool pushSelfParam, bool isLambda)
		{
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0xD35D2C", Offset = "0xD35D2C", VA = "0xD35D2C")]
		private FunctionDefinitionExpression(ScriptLoadingContext lcontext, bool pushSelfParam, bool usesGlobalEnv, bool isLambda)
		{
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0xD364D0", Offset = "0xD364D0", VA = "0xD364D0")]
		private Statement CreateLambdaBody(ScriptLoadingContext lcontext)
		{
			return null;
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0xD3659C", Offset = "0xD3659C", VA = "0xD3659C")]
		private Statement CreateBody(ScriptLoadingContext lcontext)
		{
			return null;
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0xD35FDC", Offset = "0xD35FDC", VA = "0xD35FDC")]
		private List<string> BuildParamList(ScriptLoadingContext lcontext, bool pushSelfParam, Token openBracketToken, bool isLambda)
		{
			return null;
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0xD362B0", Offset = "0xD362B0", VA = "0xD362B0")]
		private SymbolRef[] DefineArguments(List<string> paramnames, ScriptLoadingContext lcontext)
		{
			return null;
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0xD36768", Offset = "0xD36768", VA = "0xD36768", Slot = "8")]
		public SymbolRef CreateUpvalue(BuildTimeScope scope, SymbolRef symbol)
		{
			return null;
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0xD36914", Offset = "0xD36914", VA = "0xD36914", Slot = "6")]
		public override DynValue Eval(ScriptExecutionContext context)
		{
			return null;
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0xD33850", Offset = "0xD33850", VA = "0xD33850")]
		public int CompileBody(ByteCode bc, string friendlyName)
		{
			return default(int);
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0xD2FD74", Offset = "0xD2FD74", VA = "0xD2FD74")]
		public int Compile(ByteCode bc, Func<int> afterDecl, string friendlyName)
		{
			return default(int);
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0xD36964", Offset = "0xD36964", VA = "0xD36964", Slot = "4")]
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
		[Address(RVA = "0xD36AC8", Offset = "0xD36AC8", VA = "0xD36AC8")]
		public IndexExpression(Expression baseExp, Expression indexExp, ScriptLoadingContext lcontext)
		{
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0xD36AF8", Offset = "0xD36AF8", VA = "0xD36AF8")]
		public IndexExpression(Expression baseExp, string name, ScriptLoadingContext lcontext)
		{
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0xD36B2C", Offset = "0xD36B2C", VA = "0xD36B2C", Slot = "4")]
		public override void Compile(ByteCode bc)
		{
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0xD36C98", Offset = "0xD36C98", VA = "0xD36C98", Slot = "8")]
		public void CompileAssignment(ByteCode bc, int stackofs, int tupleidx)
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0xD36E2C", Offset = "0xD36E2C", VA = "0xD36E2C", Slot = "6")]
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
			[Address(RVA = "0xD37004", Offset = "0xD37004", VA = "0xD37004")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0xD2EF1C", Offset = "0xD2EF1C", VA = "0xD2EF1C")]
		public LiteralExpression(ScriptLoadingContext lcontext, DynValue value)
		{
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0xD3567C", Offset = "0xD3567C", VA = "0xD3567C")]
		public LiteralExpression(ScriptLoadingContext lcontext, Token t)
		{
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0xD3700C", Offset = "0xD3700C", VA = "0xD3700C", Slot = "4")]
		public override void Compile(ByteCode bc)
		{
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0xD37030", Offset = "0xD37030", VA = "0xD37030", Slot = "6")]
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
		[Address(RVA = "0xD37038", Offset = "0xD37038", VA = "0xD37038")]
		public SymbolRefExpression(Token T, ScriptLoadingContext lcontext)
		{
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0xD2EB98", Offset = "0xD2EB98", VA = "0xD2EB98")]
		public SymbolRefExpression(ScriptLoadingContext lcontext, SymbolRef refr)
		{
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0xD3719C", Offset = "0xD3719C", VA = "0xD3719C", Slot = "4")]
		public override void Compile(ByteCode bc)
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0xD371C0", Offset = "0xD371C0", VA = "0xD371C0", Slot = "8")]
		public void CompileAssignment(ByteCode bc, int stackofs, int tupleidx)
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0xD371E4", Offset = "0xD371E4", VA = "0xD371E4", Slot = "6")]
		public override DynValue Eval(ScriptExecutionContext context)
		{
			return null;
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0xD37208", Offset = "0xD37208", VA = "0xD37208", Slot = "7")]
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
		[Address(RVA = "0xD35978", Offset = "0xD35978", VA = "0xD35978")]
		public TableConstructor(ScriptLoadingContext lcontext, bool shared)
		{
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0xD37480", Offset = "0xD37480", VA = "0xD37480")]
		private void MapField(ScriptLoadingContext lcontext)
		{
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0xD3722C", Offset = "0xD3722C", VA = "0xD3722C")]
		private void StructField(ScriptLoadingContext lcontext)
		{
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0xD373C8", Offset = "0xD373C8", VA = "0xD373C8")]
		private void ArrayField(ScriptLoadingContext lcontext)
		{
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0xD375B4", Offset = "0xD375B4", VA = "0xD375B4", Slot = "4")]
		public override void Compile(ByteCode bc)
		{
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0xD37810", Offset = "0xD37810", VA = "0xD37810", Slot = "6")]
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
		[Address(RVA = "0xD37BBC", Offset = "0xD37BBC", VA = "0xD37BBC")]
		public UnaryOperatorExpression(ScriptLoadingContext lcontext, Expression subExpression, Token unaryOpToken)
		{
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0xD37BF4", Offset = "0xD37BF4", VA = "0xD37BF4", Slot = "4")]
		public override void Compile(ByteCode bc)
		{
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0xD37D78", Offset = "0xD37D78", VA = "0xD37D78", Slot = "6")]
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
		[Address(RVA = "0xD37FFC", Offset = "0xD37FFC", VA = "0xD37FFC")]
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
		[Address(RVA = "0xD386A0", Offset = "0xD386A0", VA = "0xD386A0")]
		public static string Serialize(this Table table, bool prefixReturn = false, int tabs = 0)
		{
			return null;
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0xD38CA0", Offset = "0xD38CA0", VA = "0xD38CA0")]
		private static bool IsStringIdentifierValid(DynValue dynValue)
		{
			return default(bool);
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0xD38E70", Offset = "0xD38E70", VA = "0xD38E70")]
		public static string SerializeValue(this DynValue dynValue, int tabs = 0)
		{
			return null;
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0xD390D8", Offset = "0xD390D8", VA = "0xD390D8")]
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
		[Address(RVA = "0xD3974C", Offset = "0xD3974C", VA = "0xD3974C")]
		public static bool isNull()
		{
			return default(bool);
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0xD39754", Offset = "0xD39754", VA = "0xD39754")]
		[MoonSharpHidden]
		public static bool IsJsonNull(DynValue v)
		{
			return default(bool);
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0xD398A0", Offset = "0xD398A0", VA = "0xD398A0")]
		[MoonSharpHidden]
		public static DynValue Create()
		{
			return null;
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0xD39904", Offset = "0xD39904", VA = "0xD39904")]
		public JsonNull()
		{
		}
	}
	[Token(Token = "0x200007D")]
	public static class JsonTableConverter
	{
		[Token(Token = "0x6000360")]
		[Address(RVA = "0xD3990C", Offset = "0xD3990C", VA = "0xD3990C")]
		public static string TableToJson(this Table table)
		{
			return null;
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0xD39980", Offset = "0xD39980", VA = "0xD39980")]
		private static void TableToJson(StringBuilder sb, Table table)
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0xD39FF8", Offset = "0xD39FF8", VA = "0xD39FF8")]
		public static string ObjectToJson(object obj)
		{
			return null;
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0xD39E94", Offset = "0xD39E94", VA = "0xD39E94")]
		private static void ValueToJson(StringBuilder sb, DynValue value)
		{
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0xD3A02C", Offset = "0xD3A02C", VA = "0xD3A02C")]
		private static string EscapeString(string s)
		{
			return null;
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0xD39E30", Offset = "0xD39E30", VA = "0xD39E30")]
		private static bool IsValueJsonCompatible(DynValue value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0xD3A250", Offset = "0xD3A250", VA = "0xD3A250")]
		public static Table JsonToTable(string json, [Optional] Script script)
		{
			return null;
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0xD3A5F4", Offset = "0xD3A5F4", VA = "0xD3A5F4")]
		private static void AssertToken(Lexer L, TokenType type)
		{
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0xD3A510", Offset = "0xD3A510", VA = "0xD3A510")]
		private static Table ParseJsonArray(Lexer L, Script script)
		{
			return null;
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0xD3A3E4", Offset = "0xD3A3E4", VA = "0xD3A3E4")]
		private static Table ParseJsonObject(Lexer L, Script script)
		{
			return null;
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0xD3A6FC", Offset = "0xD3A6FC", VA = "0xD3A6FC")]
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
		[Address(RVA = "0xD3AA7C", Offset = "0xD3AA7C", VA = "0xD3AA7C")]
		public ReplHistoryInterpreter(Script script, int historySize)
		{
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0xD3AB5C", Offset = "0xD3AB5C", VA = "0xD3AB5C", Slot = "7")]
		public override DynValue Evaluate(string input)
		{
			return null;
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0xD3B014", Offset = "0xD3B014", VA = "0xD3B014")]
		public string HistoryPrev()
		{
			return null;
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0xD3B084", Offset = "0xD3B084", VA = "0xD3B084")]
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
			[Address(RVA = "0xD3B0DC", Offset = "0xD3B0DC", VA = "0xD3B0DC")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000371")]
			[Address(RVA = "0xD3B0E4", Offset = "0xD3B0E4", VA = "0xD3B0E4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000093")]
		public bool HandleClassicExprsSyntax
		{
			[Token(Token = "0x6000372")]
			[Address(RVA = "0xD3B0F0", Offset = "0xD3B0F0", VA = "0xD3B0F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000373")]
			[Address(RVA = "0xD3B0F8", Offset = "0xD3B0F8", VA = "0xD3B0F8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000094")]
		public virtual bool HasPendingCommand
		{
			[Token(Token = "0x6000374")]
			[Address(RVA = "0xD3B104", Offset = "0xD3B104", VA = "0xD3B104", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000095")]
		public virtual string CurrentPendingCommand
		{
			[Token(Token = "0x6000375")]
			[Address(RVA = "0xD3B128", Offset = "0xD3B128", VA = "0xD3B128", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000096")]
		public virtual string ClassicPrompt
		{
			[Token(Token = "0x6000376")]
			[Address(RVA = "0xD3B130", Offset = "0xD3B130", VA = "0xD3B130", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0xD3AAF0", Offset = "0xD3AAF0", VA = "0xD3AAF0")]
		public ReplInterpreter(Script script)
		{
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0xD3ABF0", Offset = "0xD3ABF0", VA = "0xD3ABF0", Slot = "7")]
		public virtual DynValue Evaluate(string input)
		{
			return null;
		}
	}
	[Token(Token = "0x2000081")]
	public class ReplInterpreterScriptLoader : FileSystemScriptLoader
	{
		[Token(Token = "0x6000378")]
		[Address(RVA = "0xD3B1A8", Offset = "0xD3B1A8", VA = "0xD3B1A8")]
		public ReplInterpreterScriptLoader()
		{
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0xD3B518", Offset = "0xD3B518", VA = "0xD3B518", Slot = "10")]
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
		[Address(RVA = "0xD3B678", Offset = "0xD3B678", VA = "0xD3B678", Slot = "31")]
		public override string GetEnvironmentVariable(string envvarname)
		{
			return null;
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0xD3B680", Offset = "0xD3B680", VA = "0xD3B680", Slot = "30")]
		public override CoreModules FilterSupportedCoreModules(CoreModules module)
		{
			return default(CoreModules);
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0xD3B688", Offset = "0xD3B688", VA = "0xD3B688", Slot = "22")]
		public override Stream IO_OpenFile(Script script, string filename, Encoding encoding, string mode)
		{
			return null;
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0xD3B6D8", Offset = "0xD3B6D8", VA = "0xD3B6D8", Slot = "23")]
		public override Stream IO_GetStandardStream(StandardFileType type)
		{
			return null;
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0xD3B728", Offset = "0xD3B728", VA = "0xD3B728", Slot = "24")]
		public override string IO_OS_GetTempFilename()
		{
			return null;
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0xD3B778", Offset = "0xD3B778", VA = "0xD3B778", Slot = "25")]
		public override void OS_ExitFast(int exitCode)
		{
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0xD3B7C8", Offset = "0xD3B7C8", VA = "0xD3B7C8", Slot = "26")]
		public override bool OS_FileExists(string file)
		{
			return default(bool);
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0xD3B818", Offset = "0xD3B818", VA = "0xD3B818", Slot = "27")]
		public override void OS_FileDelete(string file)
		{
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0xD3B868", Offset = "0xD3B868", VA = "0xD3B868", Slot = "28")]
		public override void OS_FileMove(string src, string dst)
		{
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0xD3B8B8", Offset = "0xD3B8B8", VA = "0xD3B8B8", Slot = "29")]
		public override int OS_Execute(string cmdline)
		{
			return default(int);
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0xD3B908", Offset = "0xD3B908", VA = "0xD3B908", Slot = "18")]
		public override string GetPlatformNamePrefix()
		{
			return null;
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0xD3B948", Offset = "0xD3B948", VA = "0xD3B948", Slot = "19")]
		public override void DefaultPrint(string content)
		{
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0xD3B94C", Offset = "0xD3B94C", VA = "0xD3B94C")]
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
		[Address(RVA = "0xD3B95C", Offset = "0xD3B95C", VA = "0xD3B95C", Slot = "7")]
		public string GetPlatformName()
		{
			return null;
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0xD3BCB4", Offset = "0xD3BCB4", VA = "0xD3BCB4")]
		private string GetUnityRuntimeName()
		{
			return null;
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0xD3BC74", Offset = "0xD3BC74", VA = "0xD3BC74")]
		private string GetUnityPlatformName()
		{
			return null;
		}

		[Token(Token = "0x6000399")]
		public abstract void DefaultPrint(string content);

		[Token(Token = "0x600039A")]
		[Address(RVA = "0xD3BCFC", Offset = "0xD3BCFC", VA = "0xD3BCFC", Slot = "20")]
		[Obsolete("Replace with DefaultInput(string)")]
		public virtual string DefaultInput()
		{
			return null;
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0xD3BD04", Offset = "0xD3BD04", VA = "0xD3BD04", Slot = "21")]
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
		[Address(RVA = "0xD3BD14", Offset = "0xD3BD14", VA = "0xD3BD14", Slot = "32")]
		public virtual bool IsRunningOnAOT()
		{
			return default(bool);
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0xD3B954", Offset = "0xD3B954", VA = "0xD3B954")]
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
			[Address(RVA = "0xD3BD1C", Offset = "0xD3BD1C", VA = "0xD3BD1C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003A9")]
			[Address(RVA = "0xD3BD64", Offset = "0xD3BD64", VA = "0xD3BD64")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000098")]
		public static bool IsRunningOnClr4
		{
			[Token(Token = "0x60003AA")]
			[Address(RVA = "0xD3BDB0", Offset = "0xD3BDB0", VA = "0xD3BDB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003AB")]
			[Address(RVA = "0xD3BDF8", Offset = "0xD3BDF8", VA = "0xD3BDF8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000099")]
		public static bool IsRunningOnUnity
		{
			[Token(Token = "0x60003AC")]
			[Address(RVA = "0xD3BE44", Offset = "0xD3BE44", VA = "0xD3BE44")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003AD")]
			[Address(RVA = "0xD3BE8C", Offset = "0xD3BE8C", VA = "0xD3BE8C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700009A")]
		public static bool IsPortableFramework
		{
			[Token(Token = "0x60003AE")]
			[Address(RVA = "0xD3BED8", Offset = "0xD3BED8", VA = "0xD3BED8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003AF")]
			[Address(RVA = "0xD3BF20", Offset = "0xD3BF20", VA = "0xD3BF20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700009B")]
		public static bool IsUnityNative
		{
			[Token(Token = "0x60003B0")]
			[Address(RVA = "0xD3BF6C", Offset = "0xD3BF6C", VA = "0xD3BF6C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003B1")]
			[Address(RVA = "0xD3BFB4", Offset = "0xD3BFB4", VA = "0xD3BFB4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700009C")]
		public static bool IsUnityIL2CPP
		{
			[Token(Token = "0x60003B2")]
			[Address(RVA = "0xD3C000", Offset = "0xD3C000", VA = "0xD3C000")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003B3")]
			[Address(RVA = "0xD3C048", Offset = "0xD3C048", VA = "0xD3C048")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700009D")]
		public static bool IsRunningOnAOT
		{
			[Token(Token = "0x60003B4")]
			[Address(RVA = "0xD3BCF4", Offset = "0xD3BCF4", VA = "0xD3BCF4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0xD3C094", Offset = "0xD3C094", VA = "0xD3C094")]
		private static void AutoDetectPlatformFlags()
		{
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0xD3C3D8", Offset = "0xD3C3D8", VA = "0xD3C3D8")]
		internal static IPlatformAccessor GetDefaultPlatform()
		{
			return null;
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0xD3C48C", Offset = "0xD3C48C", VA = "0xD3C48C")]
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
		[Address(RVA = "0xD3C814", Offset = "0xD3C814", VA = "0xD3C814")]
		public static FileAccess ParseFileAccess(string mode)
		{
			return default(FileAccess);
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0xD3C934", Offset = "0xD3C934", VA = "0xD3C934")]
		public static FileMode ParseFileMode(string mode)
		{
			return default(FileMode);
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0xD3CA64", Offset = "0xD3CA64", VA = "0xD3CA64", Slot = "22")]
		public override Stream IO_OpenFile(Script script, string filename, Encoding encoding, string mode)
		{
			return null;
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0xD3CAFC", Offset = "0xD3CAFC", VA = "0xD3CAFC", Slot = "31")]
		public override string GetEnvironmentVariable(string envvarname)
		{
			return null;
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0xD3CB08", Offset = "0xD3CB08", VA = "0xD3CB08", Slot = "23")]
		public override Stream IO_GetStandardStream(StandardFileType type)
		{
			return null;
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0xD3CBFC", Offset = "0xD3CBFC", VA = "0xD3CBFC", Slot = "19")]
		public override void DefaultPrint(string content)
		{
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0xD3CC54", Offset = "0xD3CC54", VA = "0xD3CC54", Slot = "24")]
		public override string IO_OS_GetTempFilename()
		{
			return null;
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0xD3CCA4", Offset = "0xD3CCA4", VA = "0xD3CCA4", Slot = "25")]
		public override void OS_ExitFast(int exitCode)
		{
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0xD3CCB0", Offset = "0xD3CCB0", VA = "0xD3CCB0", Slot = "26")]
		public override bool OS_FileExists(string file)
		{
			return default(bool);
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0xD3CCBC", Offset = "0xD3CCBC", VA = "0xD3CCBC", Slot = "27")]
		public override void OS_FileDelete(string file)
		{
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0xD3CCC8", Offset = "0xD3CCC8", VA = "0xD3CCC8", Slot = "28")]
		public override void OS_FileMove(string src, string dst)
		{
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0xD3CCD8", Offset = "0xD3CCD8", VA = "0xD3CCD8", Slot = "29")]
		public override int OS_Execute(string cmdline)
		{
			return default(int);
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0xD3CDAC", Offset = "0xD3CDAC", VA = "0xD3CDAC", Slot = "30")]
		public override CoreModules FilterSupportedCoreModules(CoreModules module)
		{
			return default(CoreModules);
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0xD3CDB4", Offset = "0xD3CDB4", VA = "0xD3CDB4", Slot = "18")]
		public override string GetPlatformNamePrefix()
		{
			return null;
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0xD3C484", Offset = "0xD3C484", VA = "0xD3C484")]
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
		[Address(RVA = "0xD3CDF4", Offset = "0xD3CDF4", VA = "0xD3CDF4")]
		public EmbeddedResourcesScriptLoader([Optional] Assembly resourceAssembly)
		{
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0xD3CF14", Offset = "0xD3CF14", VA = "0xD3CF14")]
		private string FileNameToResource(string file)
		{
			return null;
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0xD3CF9C", Offset = "0xD3CF9C", VA = "0xD3CF9C", Slot = "7")]
		public override bool ScriptFileExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0xD3D004", Offset = "0xD3D004", VA = "0xD3D004", Slot = "8")]
		public override object LoadFile(string file, Table globalContext)
		{
			return null;
		}
	}
	[Token(Token = "0x200008B")]
	public class FileSystemScriptLoader : ScriptLoaderBase
	{
		[Token(Token = "0x60003CF")]
		[Address(RVA = "0xD3D038", Offset = "0xD3D038", VA = "0xD3D038", Slot = "7")]
		public override bool ScriptFileExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0xD3D044", Offset = "0xD3D044", VA = "0xD3D044", Slot = "8")]
		public override object LoadFile(string file, Table globalContext)
		{
			return null;
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0xD3B2E4", Offset = "0xD3B2E4", VA = "0xD3B2E4")]
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
		[Address(RVA = "0xD3D0B4", Offset = "0xD3D0B4", VA = "0xD3D0B4")]
		internal InvalidScriptLoader(string frameworkname)
		{
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0xD3D120", Offset = "0xD3D120", VA = "0xD3D120", Slot = "4")]
		public object LoadFile(string file, Table globalContext)
		{
			return null;
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0xD3D16C", Offset = "0xD3D16C", VA = "0xD3D16C", Slot = "5")]
		public string ResolveFileName(string filename, Table globalContext)
		{
			return null;
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0xD3D174", Offset = "0xD3D174", VA = "0xD3D174", Slot = "6")]
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
			[Address(RVA = "0xD3D2A8", Offset = "0xD3D2A8", VA = "0xD3D2A8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60003DE")]
			[Address(RVA = "0xD3D2B0", Offset = "0xD3D2B0", VA = "0xD3D2B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700009F")]
		public bool IgnoreLuaPathGlobal
		{
			[Token(Token = "0x60003E2")]
			[Address(RVA = "0xD3D518", Offset = "0xD3D518", VA = "0xD3D518")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003E3")]
			[Address(RVA = "0xD3D520", Offset = "0xD3D520", VA = "0xD3D520")]
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
		[Address(RVA = "0xD3D1C0", Offset = "0xD3D1C0", VA = "0xD3D1C0", Slot = "9")]
		protected virtual string ResolveModuleName(string modname, string[] paths)
		{
			return null;
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0xD3B5CC", Offset = "0xD3B5CC", VA = "0xD3B5CC", Slot = "10")]
		public virtual string ResolveModuleName(string modname, Table globalContext)
		{
			return null;
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0xD3B2EC", Offset = "0xD3B2EC", VA = "0xD3B2EC")]
		public static string[] UnpackStringPaths(string str)
		{
			return null;
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0xD3D2B8", Offset = "0xD3D2B8", VA = "0xD3D2B8")]
		public static string[] GetDefaultEnvironmentPaths()
		{
			return null;
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0xD3D510", Offset = "0xD3D510", VA = "0xD3D510", Slot = "11")]
		public virtual string ResolveFileName(string filename, Table globalContext)
		{
			return null;
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0xD3CF0C", Offset = "0xD3CF0C", VA = "0xD3CF0C")]
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
		[Address(RVA = "0xD3C54C", Offset = "0xD3C54C", VA = "0xD3C54C")]
		public UnityAssetsScriptLoader([Optional] string assetsPath)
		{
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0xD3DD00", Offset = "0xD3DD00", VA = "0xD3DD00")]
		public UnityAssetsScriptLoader(Dictionary<string, string> scriptToCodeMap)
		{
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0xD3D5D0", Offset = "0xD3D5D0", VA = "0xD3D5D0")]
		private void LoadResourcesWithReflection(string assetsPath)
		{
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0xD3DD90", Offset = "0xD3DD90", VA = "0xD3DD90")]
		private string GetFileName(string filename)
		{
			return null;
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0xD3DE48", Offset = "0xD3DE48", VA = "0xD3DE48", Slot = "8")]
		public override object LoadFile(string file, Table globalContext)
		{
			return null;
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0xD3DF50", Offset = "0xD3DF50", VA = "0xD3DF50", Slot = "7")]
		public override bool ScriptFileExists(string file)
		{
			return default(bool);
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0xD3DFB4", Offset = "0xD3DFB4", VA = "0xD3DFB4")]
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
		[Address(RVA = "0xD3E020", Offset = "0xD3E020", VA = "0xD3E020")]
		public BinDumpBinaryReader(Stream s)
		{
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0xD3E0AC", Offset = "0xD3E0AC", VA = "0xD3E0AC")]
		public BinDumpBinaryReader(Stream s, Encoding e)
		{
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0xD3E140", Offset = "0xD3E140", VA = "0xD3E140", Slot = "15")]
		public override int ReadInt32()
		{
			return default(int);
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0xD3E194", Offset = "0xD3E194", VA = "0xD3E194", Slot = "16")]
		public override uint ReadUInt32()
		{
			return default(uint);
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0xD3E1E4", Offset = "0xD3E1E4", VA = "0xD3E1E4", Slot = "22")]
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
		[Address(RVA = "0xD3E34C", Offset = "0xD3E34C", VA = "0xD3E34C")]
		public BinDumpBinaryWriter(Stream s)
		{
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0xD3E3FC", Offset = "0xD3E3FC", VA = "0xD3E3FC")]
		public BinDumpBinaryWriter(Stream s, Encoding e)
		{
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0xD3E4B4", Offset = "0xD3E4B4", VA = "0xD3E4B4", Slot = "19")]
		public override void Write(uint value)
		{
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0xD3E548", Offset = "0xD3E548", VA = "0xD3E548", Slot = "18")]
		public override void Write(int value)
		{
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0xD3E5E4", Offset = "0xD3E5E4", VA = "0xD3E5E4", Slot = "23")]
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
			[Address(RVA = "0xD3E788", Offset = "0xD3E788", VA = "0xD3E788", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A1")]
		public override bool CanSeek
		{
			[Token(Token = "0x60003FE")]
			[Address(RVA = "0xD3E7A8", Offset = "0xD3E7A8", VA = "0xD3E7A8", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A2")]
		public override bool CanWrite
		{
			[Token(Token = "0x60003FF")]
			[Address(RVA = "0xD3E7C8", Offset = "0xD3E7C8", VA = "0xD3E7C8", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A3")]
		public override long Length
		{
			[Token(Token = "0x6000401")]
			[Address(RVA = "0xD3E80C", Offset = "0xD3E80C", VA = "0xD3E80C", Slot = "11")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x170000A4")]
		public override long Position
		{
			[Token(Token = "0x6000402")]
			[Address(RVA = "0xD3E82C", Offset = "0xD3E82C", VA = "0xD3E82C", Slot = "12")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x6000403")]
			[Address(RVA = "0xD3E84C", Offset = "0xD3E84C", VA = "0xD3E84C", Slot = "13")]
			set
			{
			}
		}

		[Token(Token = "0x170000A5")]
		public override bool CanTimeout
		{
			[Token(Token = "0x600040C")]
			[Address(RVA = "0xD3E990", Offset = "0xD3E990", VA = "0xD3E990", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A6")]
		public override int ReadTimeout
		{
			[Token(Token = "0x6000410")]
			[Address(RVA = "0xD3EA14", Offset = "0xD3EA14", VA = "0xD3EA14", Slot = "14")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000411")]
			[Address(RVA = "0xD3EA38", Offset = "0xD3EA38", VA = "0xD3EA38", Slot = "15")]
			set
			{
			}
		}

		[Token(Token = "0x170000A7")]
		public override int WriteTimeout
		{
			[Token(Token = "0x6000414")]
			[Address(RVA = "0xD3EAA0", Offset = "0xD3EAA0", VA = "0xD3EAA0", Slot = "16")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000415")]
			[Address(RVA = "0xD3EAC4", Offset = "0xD3EAC4", VA = "0xD3EAC4", Slot = "17")]
			set
			{
			}
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0xD3E714", Offset = "0xD3E714", VA = "0xD3E714")]
		public UndisposableStream(Stream stream)
		{
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0xD3E780", Offset = "0xD3E780", VA = "0xD3E780", Slot = "20")]
		protected override void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0xD3E784", Offset = "0xD3E784", VA = "0xD3E784", Slot = "19")]
		public override void Close()
		{
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0xD3E7E8", Offset = "0xD3E7E8", VA = "0xD3E7E8", Slot = "21")]
		public override void Flush()
		{
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0xD3E870", Offset = "0xD3E870", VA = "0xD3E870", Slot = "33")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return default(int);
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0xD3E894", Offset = "0xD3E894", VA = "0xD3E894", Slot = "31")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return default(long);
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0xD3E8B8", Offset = "0xD3E8B8", VA = "0xD3E8B8", Slot = "32")]
		public override void SetLength(long value)
		{
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0xD3E8DC", Offset = "0xD3E8DC", VA = "0xD3E8DC", Slot = "36")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0xD3E900", Offset = "0xD3E900", VA = "0xD3E900", Slot = "23")]
		public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			return null;
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0xD3E924", Offset = "0xD3E924", VA = "0xD3E924", Slot = "27")]
		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			return null;
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0xD3E948", Offset = "0xD3E948", VA = "0xD3E948", Slot = "28")]
		public override void EndWrite(IAsyncResult asyncResult)
		{
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0xD3E96C", Offset = "0xD3E96C", VA = "0xD3E96C", Slot = "24")]
		public override int EndRead(IAsyncResult asyncResult)
		{
			return default(int);
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0xD3E9B0", Offset = "0xD3E9B0", VA = "0xD3E9B0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0xD3E9D0", Offset = "0xD3E9D0", VA = "0xD3E9D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0xD3E9F0", Offset = "0xD3E9F0", VA = "0xD3E9F0", Slot = "35")]
		public override int ReadByte()
		{
			return default(int);
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0xD3EA5C", Offset = "0xD3EA5C", VA = "0xD3EA5C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0xD3EA7C", Offset = "0xD3EA7C", VA = "0xD3EA7C", Slot = "38")]
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
			[Address(RVA = "0xD3EAE8", Offset = "0xD3EAE8", VA = "0xD3EAE8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000417")]
			[Address(RVA = "0xD3EAF0", Offset = "0xD3EAF0", VA = "0xD3EAF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0xD3EAFC", Offset = "0xD3EAFC", VA = "0xD3EAFC")]
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
		[Address(RVA = "0xD3EB28", Offset = "0xD3EB28", VA = "0xD3EB28")]
		internal CustomConvertersCollection()
		{
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0xD3EC78", Offset = "0xD3EC78", VA = "0xD3EC78")]
		public void SetScriptToClrCustomConversion(DataType scriptDataType, Type clrDataType, [Optional] Func<DynValue, object> converter)
		{
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0xD3EDC0", Offset = "0xD3EDC0", VA = "0xD3EDC0")]
		public Func<DynValue, object> GetScriptToClrCustomConversion(DataType scriptDataType, Type clrDataType)
		{
			return null;
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0xD3EE54", Offset = "0xD3EE54", VA = "0xD3EE54")]
		public void SetClrToScriptCustomConversion(Type clrDataType, [Optional] Func<Script, object, DynValue> converter)
		{
		}

		[Token(Token = "0x600041D")]
		public void SetClrToScriptCustomConversion<T>([Optional] Func<Script, T, DynValue> converter)
		{
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0xD3EF28", Offset = "0xD3EF28", VA = "0xD3EF28")]
		public Func<Script, object, DynValue> GetClrToScriptCustomConversion(Type clrDataType)
		{
			return null;
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0xD3EF80", Offset = "0xD3EF80", VA = "0xD3EF80")]
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
		[Address(RVA = "0xD3F04C", Offset = "0xD3F04C", VA = "0xD3F04C")]
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
				[Address(RVA = "0xD40604", Offset = "0xD40604", VA = "0xD40604", Slot = "6")]
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
				[Address(RVA = "0xD4064C", Offset = "0xD4064C", VA = "0xD4064C", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600043A")]
			[Address(RVA = "0xD3FE50", Offset = "0xD3FE50", VA = "0xD3FE50")]
			[DebuggerHidden]
			public <GetAllImplementedTypes>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x600043B")]
			[Address(RVA = "0xD403FC", Offset = "0xD403FC", VA = "0xD403FC", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600043C")]
			[Address(RVA = "0xD40400", Offset = "0xD40400", VA = "0xD40400", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600043E")]
			[Address(RVA = "0xD4060C", Offset = "0xD4060C", VA = "0xD4060C", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000440")]
			[Address(RVA = "0xD40654", Offset = "0xD40654", VA = "0xD40654", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<Type> System.Collections.Generic.IEnumerable<System.Type>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000441")]
			[Address(RVA = "0xD406F8", Offset = "0xD406F8", VA = "0xD406F8", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0xD3F120", Offset = "0xD3F120", VA = "0xD3F120")]
		public static bool? GetVisibilityFromAttributes(this MemberInfo mi)
		{
			return null;
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0xD3F2F4", Offset = "0xD3F2F4", VA = "0xD3F2F4")]
		public static bool IsDelegateType(this Type t)
		{
			return default(bool);
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0xD3F3F0", Offset = "0xD3F3F0", VA = "0xD3F3F0")]
		public static string GetClrVisibility(this Type type)
		{
			return null;
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0xD3F544", Offset = "0xD3F544", VA = "0xD3F544")]
		public static string GetClrVisibility(this FieldInfo info)
		{
			return null;
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0xD3F668", Offset = "0xD3F668", VA = "0xD3F668")]
		public static string GetClrVisibility(this PropertyInfo info)
		{
			return null;
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0xD3F85C", Offset = "0xD3F85C", VA = "0xD3F85C")]
		public static string GetClrVisibility(this MethodBase info)
		{
			return null;
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0xD3F980", Offset = "0xD3F980", VA = "0xD3F980")]
		public static bool IsPropertyInfoPublic(this PropertyInfo pi)
		{
			return default(bool);
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0xD3FAEC", Offset = "0xD3FAEC", VA = "0xD3FAEC")]
		public static List<string> GetMetaNamesFromAttributes(this MethodInfo mi)
		{
			return null;
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0xD3C670", Offset = "0xD3C670", VA = "0xD3C670")]
		public static Type[] SafeGetTypes(this Assembly asm)
		{
			return null;
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0xD3FC90", Offset = "0xD3FC90", VA = "0xD3FC90")]
		public static string GetConversionMethodName(this Type type)
		{
			return null;
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0xD3FDD8", Offset = "0xD3FDD8", VA = "0xD3FDD8")]
		[IteratorStateMachine(typeof(<GetAllImplementedTypes>d__10))]
		public static IEnumerable<Type> GetAllImplementedTypes(this Type t)
		{
			return null;
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0xD3FE84", Offset = "0xD3FE84", VA = "0xD3FE84")]
		public static bool IsValidSimpleIdentifier(string str)
		{
			return default(bool);
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0xD3FFB8", Offset = "0xD3FFB8", VA = "0xD3FFB8")]
		public static string ToValidSimpleIdentifier(string str)
		{
			return null;
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0xD4017C", Offset = "0xD4017C", VA = "0xD4017C")]
		public static string Camelify(string name)
		{
			return null;
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0xD402AC", Offset = "0xD402AC", VA = "0xD402AC")]
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
			[Address(RVA = "0xD406FC", Offset = "0xD406FC", VA = "0xD406FC")]
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
			[Address(RVA = "0xD40758", Offset = "0xD40758", VA = "0xD40758")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AD")]
		public static IRegistrationPolicy Automatic
		{
			[Token(Token = "0x6000445")]
			[Address(RVA = "0xD407B4", Offset = "0xD407B4", VA = "0xD407B4")]
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
		[Address(RVA = "0xD40810", Offset = "0xD40810", VA = "0xD40810")]
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
		[Address(RVA = "0xD40818", Offset = "0xD40818", VA = "0xD40818")]
		private EnumerableWrapper(Script script, IEnumerator enumerator)
		{
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0xD408C8", Offset = "0xD408C8", VA = "0xD408C8")]
		public void Reset()
		{
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0xD40980", Offset = "0xD40980", VA = "0xD40980")]
		private DynValue GetNext(DynValue prev)
		{
			return null;
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0xD40B44", Offset = "0xD40B44", VA = "0xD40B44")]
		private DynValue LuaIteratorCallback(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0xD40B60", Offset = "0xD40B60", VA = "0xD40B60")]
		internal static DynValue ConvertIterator(Script script, IEnumerator enumerator)
		{
			return null;
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0xD40D50", Offset = "0xD40D50", VA = "0xD40D50")]
		internal static DynValue ConvertTable(Table table)
		{
			return null;
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0xD40E10", Offset = "0xD40E10", VA = "0xD40E10", Slot = "4")]
		public DynValue Index(Script script, DynValue index, bool isDirectIndexing)
		{
			return null;
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0xD410E4", Offset = "0xD410E4", VA = "0xD410E4", Slot = "5")]
		public bool SetIndex(Script script, DynValue index, DynValue value, bool isDirectIndexing)
		{
			return default(bool);
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0xD410EC", Offset = "0xD410EC", VA = "0xD410EC", Slot = "6")]
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
		[Address(RVA = "0xD41348", Offset = "0xD41348", VA = "0xD41348")]
		public PropertyTableAssigner(Type type, params string[] expectedMissingProperties)
		{
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0xD41A14", Offset = "0xD41A14", VA = "0xD41A14")]
		public void AddExpectedMissingProperty(string name)
		{
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0xD41A70", Offset = "0xD41A70", VA = "0xD41A70")]
		private bool TryAssignProperty(object obj, string name, DynValue value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0xD41D98", Offset = "0xD41D98", VA = "0xD41D98")]
		private void AssignProperty(object obj, string name, DynValue value)
		{
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0xD41EB8", Offset = "0xD41EB8", VA = "0xD41EB8")]
		public void AssignObject(object obj, Table data)
		{
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0xD42438", Offset = "0xD42438", VA = "0xD42438")]
		public void SetSubassignerForType(Type propertyType, IPropertyTableAssigner assigner)
		{
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0xD42688", Offset = "0xD42688", VA = "0xD42688", Slot = "4")]
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
			[Address(RVA = "0xD4268C", Offset = "0xD4268C", VA = "0xD4268C")]
			[CompilerGenerated]
			readonly get
			{
				return default(ReflectionSpecialNameType);
			}
			[Token(Token = "0x6000480")]
			[Address(RVA = "0xD42694", Offset = "0xD42694", VA = "0xD42694")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000BA")]
		public string Argument
		{
			[Token(Token = "0x6000481")]
			[Address(RVA = "0xD4269C", Offset = "0xD4269C", VA = "0xD4269C")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000482")]
			[Address(RVA = "0xD426A4", Offset = "0xD426A4", VA = "0xD426A4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0xD426AC", Offset = "0xD426AC", VA = "0xD426AC")]
		public ReflectionSpecialName(ReflectionSpecialNameType type, [Optional] string argument)
		{
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0xD426B8", Offset = "0xD426B8", VA = "0xD426B8")]
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
			[Address(RVA = "0xD43108", Offset = "0xD43108", VA = "0xD43108")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BC")]
		public string Name
		{
			[Token(Token = "0x6000487")]
			[Address(RVA = "0xD43110", Offset = "0xD43110", VA = "0xD43110", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BD")]
		public Type Type
		{
			[Token(Token = "0x6000488")]
			[Address(RVA = "0xD4317C", Offset = "0xD4317C", VA = "0xD4317C", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0xD430DC", Offset = "0xD430DC", VA = "0xD430DC")]
		public CompositeUserDataDescriptor(List<IUserDataDescriptor> descriptors, Type type)
		{
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0xD43184", Offset = "0xD43184", VA = "0xD43184", Slot = "6")]
		public DynValue Index(Script script, object obj, DynValue index, bool isNameIndex)
		{
			return null;
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0xD4338C", Offset = "0xD4338C", VA = "0xD4338C", Slot = "7")]
		public bool SetIndex(Script script, object obj, DynValue index, DynValue value, bool isNameIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0xD4359C", Offset = "0xD4359C", VA = "0xD4359C", Slot = "8")]
		public string AsString(object obj)
		{
			return null;
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0xD435BC", Offset = "0xD435BC", VA = "0xD435BC", Slot = "9")]
		public DynValue MetaIndex(Script script, object obj, string metaname)
		{
			return null;
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0xD437B0", Offset = "0xD437B0", VA = "0xD437B0", Slot = "10")]
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
		[Address(RVA = "0xD43864", Offset = "0xD43864", VA = "0xD43864")]
		public ArrayMemberDescriptor(string name, bool isSetter, ParameterDescriptor[] indexerParams)
		{
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0xD43990", Offset = "0xD43990", VA = "0xD43990")]
		public ArrayMemberDescriptor(string name, bool isSetter)
		{
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0xD43AD0", Offset = "0xD43AD0", VA = "0xD43AD0", Slot = "19")]
		public void PrepareForWiring(Table t)
		{
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0xD43CEC", Offset = "0xD43CEC", VA = "0xD43CEC")]
		private static int[] BuildArrayIndices(CallbackArguments args, int count)
		{
			return null;
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0xD43DBC", Offset = "0xD43DBC", VA = "0xD43DBC")]
		private static object ArrayIndexerSet(object arrayObj, ScriptExecutionContext ctx, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0xD43F24", Offset = "0xD43F24", VA = "0xD43F24")]
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
			[Address(RVA = "0xD440FC", Offset = "0xD440FC", VA = "0xD440FC", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000BF")]
		public string Name
		{
			[Token(Token = "0x6000498")]
			[Address(RVA = "0xD44104", Offset = "0xD44104", VA = "0xD44104", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000499")]
			[Address(RVA = "0xD4410C", Offset = "0xD4410C", VA = "0xD4410C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000C0")]
		public MemberDescriptorAccess MemberAccess
		{
			[Token(Token = "0x600049A")]
			[Address(RVA = "0xD44114", Offset = "0xD44114", VA = "0xD44114", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(MemberDescriptorAccess);
			}
			[Token(Token = "0x600049B")]
			[Address(RVA = "0xD4411C", Offset = "0xD4411C", VA = "0xD4411C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000C1")]
		public virtual DynValue Value
		{
			[Token(Token = "0x600049C")]
			[Address(RVA = "0xD44124", Offset = "0xD44124", VA = "0xD44124", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0xD43FC4", Offset = "0xD43FC4", VA = "0xD43FC4")]
		protected DynValueMemberDescriptor(string name, string serializedTableValue)
		{
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0xD44084", Offset = "0xD44084", VA = "0xD44084")]
		protected DynValueMemberDescriptor(string name)
		{
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0xD440B4", Offset = "0xD440B4", VA = "0xD440B4")]
		public DynValueMemberDescriptor(string name, DynValue value)
		{
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0xD4412C", Offset = "0xD4412C", VA = "0xD4412C", Slot = "7")]
		public DynValue GetValue(Script script, object obj)
		{
			return null;
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0xD44138", Offset = "0xD44138", VA = "0xD44138", Slot = "8")]
		public void SetValue(Script script, object obj, DynValue value)
		{
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0xD441D0", Offset = "0xD441D0", VA = "0xD441D0", Slot = "9")]
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
			[Address(RVA = "0xD4462C", Offset = "0xD4462C", VA = "0xD4462C", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004A1")]
			[Address(RVA = "0xD44634", Offset = "0xD44634", VA = "0xD44634")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000C3")]
		public string Name
		{
			[Token(Token = "0x60004A2")]
			[Address(RVA = "0xD44640", Offset = "0xD44640", VA = "0xD44640", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60004A3")]
			[Address(RVA = "0xD44648", Offset = "0xD44648", VA = "0xD44648")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000C4")]
		public string SortDiscriminant
		{
			[Token(Token = "0x60004A4")]
			[Address(RVA = "0xD44650", Offset = "0xD44650", VA = "0xD44650", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60004A5")]
			[Address(RVA = "0xD44658", Offset = "0xD44658", VA = "0xD44658")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000C5")]
		public ParameterDescriptor[] Parameters
		{
			[Token(Token = "0x60004A6")]
			[Address(RVA = "0xD44660", Offset = "0xD44660", VA = "0xD44660", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60004A7")]
			[Address(RVA = "0xD44668", Offset = "0xD44668", VA = "0xD44668")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000C6")]
		public Type ExtensionMethodType
		{
			[Token(Token = "0x60004A8")]
			[Address(RVA = "0xD44670", Offset = "0xD44670", VA = "0xD44670", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60004A9")]
			[Address(RVA = "0xD44678", Offset = "0xD44678", VA = "0xD44678")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000C7")]
		public Type VarArgsArrayType
		{
			[Token(Token = "0x60004AA")]
			[Address(RVA = "0xD44680", Offset = "0xD44680", VA = "0xD44680", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60004AB")]
			[Address(RVA = "0xD44688", Offset = "0xD44688", VA = "0xD44688")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000C8")]
		public Type VarArgsElementType
		{
			[Token(Token = "0x60004AC")]
			[Address(RVA = "0xD44690", Offset = "0xD44690", VA = "0xD44690", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60004AD")]
			[Address(RVA = "0xD44698", Offset = "0xD44698", VA = "0xD44698")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000C9")]
		public MemberDescriptorAccess MemberAccess
		{
			[Token(Token = "0x60004B6")]
			[Address(RVA = "0xD45538", Offset = "0xD45538", VA = "0xD45538", Slot = "12")]
			get
			{
				return default(MemberDescriptorAccess);
			}
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0xD446A0", Offset = "0xD446A0", VA = "0xD446A0")]
		protected void Initialize(string funcName, bool isStatic, ParameterDescriptor[] parameters, bool isExtensionMethod)
		{
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0xD44890", Offset = "0xD44890", VA = "0xD44890")]
		public Func<ScriptExecutionContext, CallbackArguments, DynValue> GetCallback(Script script, [Optional] object obj)
		{
			return null;
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0xD44958", Offset = "0xD44958", VA = "0xD44958")]
		public CallbackFunction GetCallbackFunction(Script script, [Optional] object obj)
		{
			return null;
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0xD449EC", Offset = "0xD449EC", VA = "0xD449EC")]
		public DynValue GetCallbackAsDynValue(Script script, [Optional] object obj)
		{
			return null;
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0xD44A6C", Offset = "0xD44A6C", VA = "0xD44A6C")]
		public static DynValue CreateCallbackDynValue(Script script, MethodInfo mi, [Optional] object obj)
		{
			return null;
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0xD44AEC", Offset = "0xD44AEC", VA = "0xD44AEC", Slot = "15")]
		protected virtual object[] BuildArgumentList(Script script, object obj, ScriptExecutionContext context, CallbackArguments args, out List<int> outParams)
		{
			return null;
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0xD452F8", Offset = "0xD452F8", VA = "0xD452F8")]
		protected static DynValue BuildReturnValue(Script script, List<int> outParams, object[] pars, object retv)
		{
			return null;
		}

		[Token(Token = "0x60004B5")]
		public abstract DynValue Execute(Script script, object obj, ScriptExecutionContext context, CallbackArguments args);

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0xD45540", Offset = "0xD45540", VA = "0xD45540", Slot = "17")]
		public virtual DynValue GetValue(Script script, object obj)
		{
			return null;
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0xD45578", Offset = "0xD45578", VA = "0xD45578", Slot = "18")]
		public virtual void SetValue(Script script, object obj, DynValue v)
		{
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0xD45584", Offset = "0xD45584", VA = "0xD45584")]
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
		[Address(RVA = "0xD45654", Offset = "0xD45654", VA = "0xD45654")]
		public ObjectCallbackMemberDescriptor(string funcName)
		{
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0xD43A4C", Offset = "0xD43A4C", VA = "0xD43A4C")]
		public ObjectCallbackMemberDescriptor(string funcName, Func<object, ScriptExecutionContext, CallbackArguments, object> callBack)
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0xD43944", Offset = "0xD43944", VA = "0xD43944")]
		public ObjectCallbackMemberDescriptor(string funcName, Func<object, ScriptExecutionContext, CallbackArguments, object> callBack, ParameterDescriptor[] parameters)
		{
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0xD45778", Offset = "0xD45778", VA = "0xD45778", Slot = "16")]
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
			[Address(RVA = "0xD45A68", Offset = "0xD45A68", VA = "0xD45A68")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CB")]
		public string Name
		{
			[Token(Token = "0x60004C8")]
			[Address(RVA = "0xD45A70", Offset = "0xD45A70", VA = "0xD45A70", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60004C9")]
			[Address(RVA = "0xD45A78", Offset = "0xD45A78", VA = "0xD45A78")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000CC")]
		public Type Type
		{
			[Token(Token = "0x60004CA")]
			[Address(RVA = "0xD45A80", Offset = "0xD45A80", VA = "0xD45A80", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0xD4595C", Offset = "0xD4595C", VA = "0xD4595C")]
		internal ProxyUserDataDescriptor(IProxyFactory proxyFactory, IUserDataDescriptor proxyDescriptor, [Optional] string friendlyName)
		{
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0xD45B24", Offset = "0xD45B24", VA = "0xD45B24")]
		private object Proxy(object obj)
		{
			return null;
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0xD45BE0", Offset = "0xD45BE0", VA = "0xD45BE0", Slot = "6")]
		public DynValue Index(Script script, object obj, DynValue index, bool isDirectIndexing)
		{
			return null;
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0xD45CC4", Offset = "0xD45CC4", VA = "0xD45CC4", Slot = "7")]
		public bool SetIndex(Script script, object obj, DynValue index, DynValue value, bool isDirectIndexing)
		{
			return default(bool);
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0xD45DB0", Offset = "0xD45DB0", VA = "0xD45DB0", Slot = "8")]
		public string AsString(object obj)
		{
			return null;
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0xD45E6C", Offset = "0xD45E6C", VA = "0xD45E6C", Slot = "9")]
		public DynValue MetaIndex(Script script, object obj, string metaname)
		{
			return null;
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0xD45F40", Offset = "0xD45F40", VA = "0xD45F40", Slot = "10")]
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
			[Address(RVA = "0xD469B4", Offset = "0xD469B4", VA = "0xD469B4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60004D5")]
			[Address(RVA = "0xD469BC", Offset = "0xD469BC", VA = "0xD469BC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000CE")]
		public bool IsStatic
		{
			[Token(Token = "0x60004D6")]
			[Address(RVA = "0xD469C4", Offset = "0xD469C4", VA = "0xD469C4", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004D7")]
			[Address(RVA = "0xD469CC", Offset = "0xD469CC", VA = "0xD469CC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000CF")]
		public string Name
		{
			[Token(Token = "0x60004DF")]
			[Address(RVA = "0xD47CA8", Offset = "0xD47CA8", VA = "0xD47CA8", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D0")]
		public MemberDescriptorAccess MemberAccess
		{
			[Token(Token = "0x60004E0")]
			[Address(RVA = "0xD47CC8", Offset = "0xD47CC8", VA = "0xD47CC8", Slot = "6")]
			get
			{
				return default(MemberDescriptorAccess);
			}
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0xD45FF4", Offset = "0xD45FF4", VA = "0xD45FF4")]
		public static EventMemberDescriptor TryCreateIfVisible(EventInfo ei, InteropAccessMode accessMode)
		{
			return null;
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0xD461DC", Offset = "0xD461DC", VA = "0xD461DC")]
		public static bool CheckEventIsCompatible(EventInfo ei, bool throwException)
		{
			return default(bool);
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0xD4676C", Offset = "0xD4676C", VA = "0xD4676C")]
		public EventMemberDescriptor(EventInfo ei, InteropAccessMode accessMode = InteropAccessMode.Default)
		{
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0xD469D8", Offset = "0xD469D8", VA = "0xD469D8", Slot = "7")]
		public DynValue GetValue(Script script, object obj)
		{
			return null;
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0xD46A90", Offset = "0xD46A90", VA = "0xD46A90")]
		internal DynValue AddCallback(object o, ScriptExecutionContext context, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0xD46DAC", Offset = "0xD46DAC", VA = "0xD46DAC")]
		internal DynValue RemoveCallback(object o, ScriptExecutionContext context, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0xD46CD0", Offset = "0xD46CD0", VA = "0xD46CD0")]
		private void RegisterCallback(object o)
		{
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0xD46FEC", Offset = "0xD46FEC", VA = "0xD46FEC")]
		private void UnregisterCallback(object o)
		{
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0xD47138", Offset = "0xD47138", VA = "0xD47138")]
		private Delegate CreateDelegate(object sender)
		{
			return null;
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0xD477E8", Offset = "0xD477E8", VA = "0xD477E8")]
		private void DispatchEvent(object sender, [Optional] object o01, [Optional] object o02, [Optional] object o03, [Optional] object o04, [Optional] object o05, [Optional] object o06, [Optional] object o07, [Optional] object o08, [Optional] object o09, [Optional] object o10, [Optional] object o11, [Optional] object o12, [Optional] object o13, [Optional] object o14, [Optional] object o15, [Optional] object o16)
		{
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0xD47CD0", Offset = "0xD47CD0", VA = "0xD47CD0", Slot = "8")]
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
			[Address(RVA = "0xD4AF64", Offset = "0xD4AF64", VA = "0xD4AF64")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600053B")]
			[Address(RVA = "0xD4AF6C", Offset = "0xD4AF6C", VA = "0xD4AF6C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000D2")]
		public InteropAccessMode AccessMode
		{
			[Token(Token = "0x600053C")]
			[Address(RVA = "0xD4AF74", Offset = "0xD4AF74", VA = "0xD4AF74")]
			[CompilerGenerated]
			get
			{
				return default(InteropAccessMode);
			}
			[Token(Token = "0x600053D")]
			[Address(RVA = "0xD4AF7C", Offset = "0xD4AF7C", VA = "0xD4AF7C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000D3")]
		public bool IsStatic
		{
			[Token(Token = "0x600053E")]
			[Address(RVA = "0xD4AF84", Offset = "0xD4AF84", VA = "0xD4AF84", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600053F")]
			[Address(RVA = "0xD4AF8C", Offset = "0xD4AF8C", VA = "0xD4AF8C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000D4")]
		public string Name
		{
			[Token(Token = "0x6000540")]
			[Address(RVA = "0xD4AF98", Offset = "0xD4AF98", VA = "0xD4AF98", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000541")]
			[Address(RVA = "0xD4AFA0", Offset = "0xD4AFA0", VA = "0xD4AFA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000D5")]
		public bool IsConst
		{
			[Token(Token = "0x6000542")]
			[Address(RVA = "0xD4AFA8", Offset = "0xD4AFA8", VA = "0xD4AFA8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000543")]
			[Address(RVA = "0xD4AFB0", Offset = "0xD4AFB0", VA = "0xD4AFB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000D6")]
		public bool IsReadonly
		{
			[Token(Token = "0x6000544")]
			[Address(RVA = "0xD4AFBC", Offset = "0xD4AFBC", VA = "0xD4AFBC")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000545")]
			[Address(RVA = "0xD4AFC4", Offset = "0xD4AFC4", VA = "0xD4AFC4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000D7")]
		public MemberDescriptorAccess MemberAccess
		{
			[Token(Token = "0x600054B")]
			[Address(RVA = "0xD4C5A8", Offset = "0xD4C5A8", VA = "0xD4C5A8", Slot = "6")]
			get
			{
				return default(MemberDescriptorAccess);
			}
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0xD4AFD0", Offset = "0xD4AFD0", VA = "0xD4AFD0")]
		public static FieldMemberDescriptor TryCreateIfVisible(FieldInfo fi, InteropAccessMode accessMode)
		{
			return null;
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0xD4B090", Offset = "0xD4B090", VA = "0xD4B090")]
		public FieldMemberDescriptor(FieldInfo fi, InteropAccessMode accessMode)
		{
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0xD4B738", Offset = "0xD4B738", VA = "0xD4B738", Slot = "7")]
		public DynValue GetValue(Script script, object obj)
		{
			return null;
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0xD4B278", Offset = "0xD4B278", VA = "0xD4B278")]
		internal void OptimizeGetter()
		{
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0xD4BC5C", Offset = "0xD4BC5C", VA = "0xD4BC5C", Slot = "8")]
		public void SetValue(Script script, object obj, DynValue v)
		{
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0xD4C5CC", Offset = "0xD4C5CC", VA = "0xD4C5CC", Slot = "9")]
		private void MoonSharp.Interpreter.Interop.BasicDescriptors.IOptimizableDescriptor.Optimize()
		{
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0xD4C5DC", Offset = "0xD4C5DC", VA = "0xD4C5DC", Slot = "10")]
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
			[Address(RVA = "0xD4C9C4", Offset = "0xD4C9C4", VA = "0xD4C9C4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600054F")]
			[Address(RVA = "0xD4C9CC", Offset = "0xD4C9CC", VA = "0xD4C9CC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000D9")]
		public InteropAccessMode AccessMode
		{
			[Token(Token = "0x6000550")]
			[Address(RVA = "0xD4C9D4", Offset = "0xD4C9D4", VA = "0xD4C9D4")]
			[CompilerGenerated]
			get
			{
				return default(InteropAccessMode);
			}
			[Token(Token = "0x6000551")]
			[Address(RVA = "0xD4C9DC", Offset = "0xD4C9DC", VA = "0xD4C9DC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000DA")]
		public bool IsConstructor
		{
			[Token(Token = "0x6000552")]
			[Address(RVA = "0xD4C9E4", Offset = "0xD4C9E4", VA = "0xD4C9E4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000553")]
			[Address(RVA = "0xD4C9EC", Offset = "0xD4C9EC", VA = "0xD4C9EC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0xD4C9F8", Offset = "0xD4C9F8", VA = "0xD4C9F8")]
		public MethodMemberDescriptor(MethodBase methodBase, InteropAccessMode accessMode = InteropAccessMode.Default)
		{
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0xD4D54C", Offset = "0xD4D54C", VA = "0xD4D54C")]
		public static MethodMemberDescriptor TryCreateIfVisible(MethodBase methodBase, InteropAccessMode accessMode, bool forceVisibility = false)
		{
			return null;
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0xD4D214", Offset = "0xD4D214", VA = "0xD4D214")]
		public static bool CheckMethodIsCompatible(MethodBase methodBase, bool throwException)
		{
			return default(bool);
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0xD4D62C", Offset = "0xD4D62C", VA = "0xD4D62C", Slot = "16")]
		public override DynValue Execute(Script script, object obj, ScriptExecutionContext context, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0xD4D8A0", Offset = "0xD4D8A0", VA = "0xD4D8A0", Slot = "19")]
		private void MoonSharp.Interpreter.Interop.BasicDescriptors.IOptimizableDescriptor.Optimize()
		{
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0xD4E0C4", Offset = "0xD4E0C4", VA = "0xD4E0C4", Slot = "20")]
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
			[Address(RVA = "0xD50D58", Offset = "0xD50D58", VA = "0xD50D58", Slot = "4")]
			public int Compare(IOverloadableMemberDescriptor x, IOverloadableMemberDescriptor y)
			{
				return default(int);
			}

			[Token(Token = "0x6000579")]
			[Address(RVA = "0xD4F008", Offset = "0xD4F008", VA = "0xD4F008")]
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
			[Address(RVA = "0xD501D4", Offset = "0xD501D4", VA = "0xD501D4")]
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
			[Address(RVA = "0xD4E76C", Offset = "0xD4E76C", VA = "0xD4E76C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000560")]
			[Address(RVA = "0xD4E774", Offset = "0xD4E774", VA = "0xD4E774")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000DC")]
		public string Name
		{
			[Token(Token = "0x6000565")]
			[Address(RVA = "0xD4E9B4", Offset = "0xD4E9B4", VA = "0xD4E9B4", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000566")]
			[Address(RVA = "0xD4E9BC", Offset = "0xD4E9BC", VA = "0xD4E9BC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000DD")]
		public Type DeclaringType
		{
			[Token(Token = "0x6000567")]
			[Address(RVA = "0xD4E9C4", Offset = "0xD4E9C4", VA = "0xD4E9C4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000568")]
			[Address(RVA = "0xD4E9CC", Offset = "0xD4E9CC", VA = "0xD4E9CC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000DE")]
		public int OverloadCount
		{
			[Token(Token = "0x600056A")]
			[Address(RVA = "0xD4EA80", Offset = "0xD4EA80", VA = "0xD4EA80")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000DF")]
		public bool IsStatic
		{
			[Token(Token = "0x6000573")]
			[Address(RVA = "0xD50764", Offset = "0xD50764", VA = "0xD50764", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000E0")]
		public MemberDescriptorAccess MemberAccess
		{
			[Token(Token = "0x6000574")]
			[Address(RVA = "0xD50860", Offset = "0xD50860", VA = "0xD50860", Slot = "7")]
			get
			{
				return default(MemberDescriptorAccess);
			}
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0xD4E780", Offset = "0xD4E780", VA = "0xD4E780")]
		public OverloadedMethodMemberDescriptor(string name, Type declaringType)
		{
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0xD4E864", Offset = "0xD4E864", VA = "0xD4E864")]
		public OverloadedMethodMemberDescriptor(string name, Type declaringType, IOverloadableMemberDescriptor descriptor)
		{
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0xD4E930", Offset = "0xD4E930", VA = "0xD4E930")]
		public OverloadedMethodMemberDescriptor(string name, Type declaringType, IEnumerable<IOverloadableMemberDescriptor> descriptors)
		{
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0xD4E9A8", Offset = "0xD4E9A8", VA = "0xD4E9A8")]
		internal void SetExtensionMethodsSnapshot(int version, List<IOverloadableMemberDescriptor> extMethods)
		{
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0xD4E9D4", Offset = "0xD4E9D4", VA = "0xD4E9D4")]
		public void AddOverload(IOverloadableMemberDescriptor overload)
		{
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0xD4EAC8", Offset = "0xD4EAC8", VA = "0xD4EAC8")]
		private DynValue PerformOverloadedCall(Script script, object obj, ScriptExecutionContext context, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0xD4FD18", Offset = "0xD4FD18", VA = "0xD4FD18")]
		private void Cache(bool hasObject, CallbackArguments args, IOverloadableMemberDescriptor bestOverload)
		{
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0xD4F010", Offset = "0xD4F010", VA = "0xD4F010")]
		private bool CheckMatch(bool hasObject, CallbackArguments args, OverloadCacheItem overloadCacheItem)
		{
			return default(bool);
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0xD4F250", Offset = "0xD4F250", VA = "0xD4F250")]
		private int CalcScoreForOverload(ScriptExecutionContext context, CallbackArguments args, IOverloadableMemberDescriptor method, bool isExtMethod)
		{
			return default(int);
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0xD501DC", Offset = "0xD501DC", VA = "0xD501DC")]
		private static int CalcScoreForSingleArgument(ParameterDescriptor desc, Type parameterType, DynValue arg, bool isOptional)
		{
			return default(int);
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0xD502A4", Offset = "0xD502A4", VA = "0xD502A4")]
		public Func<ScriptExecutionContext, CallbackArguments, DynValue> GetCallback(Script script, object obj)
		{
			return null;
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0xD5036C", Offset = "0xD5036C", VA = "0xD5036C", Slot = "4")]
		private void MoonSharp.Interpreter.Interop.BasicDescriptors.IOptimizableDescriptor.Optimize()
		{
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0xD506D0", Offset = "0xD506D0", VA = "0xD506D0")]
		public CallbackFunction GetCallbackFunction(Script script, [Optional] object obj)
		{
			return null;
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0xD50868", Offset = "0xD50868", VA = "0xD50868", Slot = "8")]
		public DynValue GetValue(Script script, object obj)
		{
			return null;
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0xD508E8", Offset = "0xD508E8", VA = "0xD508E8", Slot = "9")]
		public void SetValue(Script script, object obj, DynValue value)
		{
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0xD508F4", Offset = "0xD508F4", VA = "0xD508F4", Slot = "10")]
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
			[Address(RVA = "0xD50FA4", Offset = "0xD50FA4", VA = "0xD50FA4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000581")]
			[Address(RVA = "0xD50FAC", Offset = "0xD50FAC", VA = "0xD50FAC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000E2")]
		public InteropAccessMode AccessMode
		{
			[Token(Token = "0x6000582")]
			[Address(RVA = "0xD50FB4", Offset = "0xD50FB4", VA = "0xD50FB4")]
			[CompilerGenerated]
			get
			{
				return default(InteropAccessMode);
			}
			[Token(Token = "0x6000583")]
			[Address(RVA = "0xD50FBC", Offset = "0xD50FBC", VA = "0xD50FBC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000E3")]
		public bool IsStatic
		{
			[Token(Token = "0x6000584")]
			[Address(RVA = "0xD50FC4", Offset = "0xD50FC4", VA = "0xD50FC4", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000585")]
			[Address(RVA = "0xD50FCC", Offset = "0xD50FCC", VA = "0xD50FCC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000E4")]
		public string Name
		{
			[Token(Token = "0x6000586")]
			[Address(RVA = "0xD50FD8", Offset = "0xD50FD8", VA = "0xD50FD8", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000587")]
			[Address(RVA = "0xD50FE0", Offset = "0xD50FE0", VA = "0xD50FE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000E5")]
		public bool CanRead
		{
			[Token(Token = "0x6000588")]
			[Address(RVA = "0xD50FE8", Offset = "0xD50FE8", VA = "0xD50FE8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000E6")]
		public bool CanWrite
		{
			[Token(Token = "0x6000589")]
			[Address(RVA = "0xD50FF8", Offset = "0xD50FF8", VA = "0xD50FF8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000E7")]
		public MemberDescriptorAccess MemberAccess
		{
			[Token(Token = "0x6000592")]
			[Address(RVA = "0xD527F0", Offset = "0xD527F0", VA = "0xD527F0", Slot = "6")]
			get
			{
				return default(MemberDescriptorAccess);
			}
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0xD51008", Offset = "0xD51008", VA = "0xD51008")]
		public static PropertyMemberDescriptor TryCreateIfVisible(PropertyInfo pi, InteropAccessMode accessMode)
		{
			return null;
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0xD51244", Offset = "0xD51244", VA = "0xD51244")]
		private static PropertyMemberDescriptor TryCreate(PropertyInfo pi, InteropAccessMode accessMode, MethodInfo getter, MethodInfo setter)
		{
			return null;
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0xD51510", Offset = "0xD51510", VA = "0xD51510")]
		public PropertyMemberDescriptor(PropertyInfo pi, InteropAccessMode accessMode)
		{
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0xD512F0", Offset = "0xD512F0", VA = "0xD512F0")]
		public PropertyMemberDescriptor(PropertyInfo pi, InteropAccessMode accessMode, MethodInfo getter, MethodInfo setter)
		{
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0xD52270", Offset = "0xD52270", VA = "0xD52270", Slot = "7")]
		public DynValue GetValue(Script script, object obj)
		{
			return null;
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0xD51638", Offset = "0xD51638", VA = "0xD51638")]
		internal void OptimizeGetter()
		{
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0xD51B04", Offset = "0xD51B04", VA = "0xD51B04")]
		internal void OptimizeSetter()
		{
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0xD52404", Offset = "0xD52404", VA = "0xD52404", Slot = "8")]
		public void SetValue(Script script, object obj, DynValue v)
		{
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0xD52838", Offset = "0xD52838", VA = "0xD52838", Slot = "9")]
		private void MoonSharp.Interpreter.Interop.BasicDescriptors.IOptimizableDescriptor.Optimize()
		{
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0xD52850", Offset = "0xD52850", VA = "0xD52850", Slot = "10")]
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
			[Address(RVA = "0xD52BB8", Offset = "0xD52BB8", VA = "0xD52BB8", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000E9")]
		public string Name
		{
			[Token(Token = "0x6000596")]
			[Address(RVA = "0xD52BC0", Offset = "0xD52BC0", VA = "0xD52BC0", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000597")]
			[Address(RVA = "0xD52BC8", Offset = "0xD52BC8", VA = "0xD52BC8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000EA")]
		public Type ValueTypeDefaultCtor
		{
			[Token(Token = "0x6000598")]
			[Address(RVA = "0xD52BD0", Offset = "0xD52BD0", VA = "0xD52BD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000599")]
			[Address(RVA = "0xD52BD8", Offset = "0xD52BD8", VA = "0xD52BD8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000EB")]
		public ParameterDescriptor[] Parameters
		{
			[Token(Token = "0x600059A")]
			[Address(RVA = "0xD52BE0", Offset = "0xD52BE0", VA = "0xD52BE0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600059B")]
			[Address(RVA = "0xD52BE8", Offset = "0xD52BE8", VA = "0xD52BE8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000EC")]
		public Type ExtensionMethodType
		{
			[Token(Token = "0x600059C")]
			[Address(RVA = "0xD52BF0", Offset = "0xD52BF0", VA = "0xD52BF0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000ED")]
		public Type VarArgsArrayType
		{
			[Token(Token = "0x600059D")]
			[Address(RVA = "0xD52BF8", Offset = "0xD52BF8", VA = "0xD52BF8", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000EE")]
		public Type VarArgsElementType
		{
			[Token(Token = "0x600059E")]
			[Address(RVA = "0xD52C00", Offset = "0xD52C00", VA = "0xD52C00", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000EF")]
		public string SortDiscriminant
		{
			[Token(Token = "0x60005A1")]
			[Address(RVA = "0xD52D90", Offset = "0xD52D90", VA = "0xD52D90", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F0")]
		public MemberDescriptorAccess MemberAccess
		{
			[Token(Token = "0x60005A2")]
			[Address(RVA = "0xD52DD0", Offset = "0xD52DD0", VA = "0xD52DD0", Slot = "12")]
			get
			{
				return default(MemberDescriptorAccess);
			}
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0xD52C08", Offset = "0xD52C08", VA = "0xD52C08")]
		public ValueTypeDefaultCtorMemberDescriptor(Type valueType)
		{
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0xD52D54", Offset = "0xD52D54", VA = "0xD52D54", Slot = "4")]
		public DynValue Execute(Script script, object obj, ScriptExecutionContext context, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0xD52DD8", Offset = "0xD52DD8", VA = "0xD52DD8", Slot = "13")]
		public DynValue GetValue(Script script, object obj)
		{
			return null;
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0xD52E14", Offset = "0xD52E14", VA = "0xD52E14", Slot = "14")]
		public void SetValue(Script script, object obj, DynValue value)
		{
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0xD52E20", Offset = "0xD52E20", VA = "0xD52E20", Slot = "15")]
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
			[Address(RVA = "0xD52F58", Offset = "0xD52F58", VA = "0xD52F58")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60005A7")]
			[Address(RVA = "0xD52F60", Offset = "0xD52F60", VA = "0xD52F60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000F2")]
		public bool IsUnsigned
		{
			[Token(Token = "0x60005A8")]
			[Address(RVA = "0xD52F68", Offset = "0xD52F68", VA = "0xD52F68")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005A9")]
			[Address(RVA = "0xD52F70", Offset = "0xD52F70", VA = "0xD52F70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000F3")]
		public bool IsFlags
		{
			[Token(Token = "0x60005AA")]
			[Address(RVA = "0xD52F7C", Offset = "0xD52F7C", VA = "0xD52F7C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005AB")]
			[Address(RVA = "0xD52F84", Offset = "0xD52F84", VA = "0xD52F84")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0xD52F90", Offset = "0xD52F90", VA = "0xD52F90")]
		public StandardEnumUserDataDescriptor(Type enumType, [Optional] string friendlyName, [Optional] string[] names, [Optional] object[] values, [Optional] Type underlyingType)
		{
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0xD532EC", Offset = "0xD532EC", VA = "0xD532EC")]
		private void FillMemberList(string[] names, object[] values)
		{
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0xD5377C", Offset = "0xD5377C", VA = "0xD5377C")]
		private void AddEnumMethod(string name, DynValue dynValue)
		{
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0xD53848", Offset = "0xD53848", VA = "0xD53848")]
		private long GetValueSigned(DynValue dv)
		{
			return default(long);
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0xD53FA4", Offset = "0xD53FA4", VA = "0xD53FA4")]
		private ulong GetValueUnsigned(DynValue dv)
		{
			return default(ulong);
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0xD546F8", Offset = "0xD546F8", VA = "0xD546F8")]
		private DynValue CreateValueSigned(long value)
		{
			return null;
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0xD54788", Offset = "0xD54788", VA = "0xD54788")]
		private DynValue CreateValueUnsigned(ulong value)
		{
			return null;
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0xD53954", Offset = "0xD53954", VA = "0xD53954")]
		private void CreateSignedConversionFunctions()
		{
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0xD540A8", Offset = "0xD540A8", VA = "0xD540A8")]
		private void CreateUnsignedConversionFunctions()
		{
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0xD54818", Offset = "0xD54818", VA = "0xD54818")]
		private DynValue PerformBinaryOperationS(string funcName, ScriptExecutionContext ctx, CallbackArguments args, Func<long, long, DynValue> operation)
		{
			return null;
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0xD54934", Offset = "0xD54934", VA = "0xD54934")]
		private DynValue PerformBinaryOperationU(string funcName, ScriptExecutionContext ctx, CallbackArguments args, Func<ulong, ulong, DynValue> operation)
		{
			return null;
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0xD54A50", Offset = "0xD54A50", VA = "0xD54A50")]
		private DynValue PerformBinaryOperationS(string funcName, ScriptExecutionContext ctx, CallbackArguments args, Func<long, long, long> operation)
		{
			return null;
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0xD54B2C", Offset = "0xD54B2C", VA = "0xD54B2C")]
		private DynValue PerformBinaryOperationU(string funcName, ScriptExecutionContext ctx, CallbackArguments args, Func<ulong, ulong, ulong> operation)
		{
			return null;
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0xD54C08", Offset = "0xD54C08", VA = "0xD54C08")]
		private DynValue PerformUnaryOperationS(string funcName, ScriptExecutionContext ctx, CallbackArguments args, Func<long, long> operation)
		{
			return null;
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0xD54D00", Offset = "0xD54D00", VA = "0xD54D00")]
		private DynValue PerformUnaryOperationU(string funcName, ScriptExecutionContext ctx, CallbackArguments args, Func<ulong, ulong> operation)
		{
			return null;
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0xD54DF8", Offset = "0xD54DF8", VA = "0xD54DF8")]
		internal DynValue Callback_Or(ScriptExecutionContext ctx, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0xD54FA8", Offset = "0xD54FA8", VA = "0xD54FA8")]
		internal DynValue Callback_And(ScriptExecutionContext ctx, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0xD55158", Offset = "0xD55158", VA = "0xD55158")]
		internal DynValue Callback_Xor(ScriptExecutionContext ctx, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0xD55308", Offset = "0xD55308", VA = "0xD55308")]
		internal DynValue Callback_BwNot(ScriptExecutionContext ctx, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0xD554B8", Offset = "0xD554B8", VA = "0xD554B8")]
		internal DynValue Callback_HasAll(ScriptExecutionContext ctx, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0xD55668", Offset = "0xD55668", VA = "0xD55668")]
		internal DynValue Callback_HasAny(ScriptExecutionContext ctx, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0xD55818", Offset = "0xD55818", VA = "0xD55818", Slot = "19")]
		public override bool IsTypeCompatible(Type type, object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0xD558AC", Offset = "0xD558AC", VA = "0xD558AC", Slot = "18")]
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
			[Address(RVA = "0xD562A0", Offset = "0xD562A0", VA = "0xD562A0")]
			[CompilerGenerated]
			get
			{
				return default(InteropAccessMode);
			}
			[Token(Token = "0x60005E6")]
			[Address(RVA = "0xD562A8", Offset = "0xD562A8", VA = "0xD562A8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000F5")]
		public string Name
		{
			[Token(Token = "0x60005E8")]
			[Address(RVA = "0xD5639C", Offset = "0xD5639C", VA = "0xD5639C", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60005E9")]
			[Address(RVA = "0xD563A4", Offset = "0xD563A4", VA = "0xD563A4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000F6")]
		public Type Type
		{
			[Token(Token = "0x60005EA")]
			[Address(RVA = "0xD563AC", Offset = "0xD563AC", VA = "0xD563AC", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60005EB")]
			[Address(RVA = "0xD563B4", Offset = "0xD563B4", VA = "0xD563B4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0xD562B0", Offset = "0xD562B0", VA = "0xD562B0")]
		public StandardGenericsUserDataDescriptor(Type type, InteropAccessMode accessMode)
		{
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0xD563BC", Offset = "0xD563BC", VA = "0xD563BC", Slot = "6")]
		public DynValue Index(Script script, object obj, DynValue index, bool isDirectIndexing)
		{
			return null;
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0xD563C4", Offset = "0xD563C4", VA = "0xD563C4", Slot = "7")]
		public bool SetIndex(Script script, object obj, DynValue index, DynValue value, bool isDirectIndexing)
		{
			return default(bool);
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0xD563CC", Offset = "0xD563CC", VA = "0xD563CC", Slot = "8")]
		public string AsString(object obj)
		{
			return null;
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0xD563EC", Offset = "0xD563EC", VA = "0xD563EC", Slot = "9")]
		public DynValue MetaIndex(Script script, object obj, string metaname)
		{
			return null;
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0xD563F4", Offset = "0xD563F4", VA = "0xD563F4", Slot = "10")]
		public bool IsTypeCompatible(Type type, object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0xD564A8", Offset = "0xD564A8", VA = "0xD564A8", Slot = "11")]
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
			[Address(RVA = "0xD565C8", Offset = "0xD565C8", VA = "0xD565C8")]
			[CompilerGenerated]
			get
			{
				return default(InteropAccessMode);
			}
			[Token(Token = "0x60005F3")]
			[Address(RVA = "0xD565D0", Offset = "0xD565D0", VA = "0xD565D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0xD565D8", Offset = "0xD565D8", VA = "0xD565D8")]
		public StandardUserDataDescriptor(Type type, InteropAccessMode accessMode, [Optional] string friendlyName)
		{
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0xD567A4", Offset = "0xD567A4", VA = "0xD567A4")]
		private void FillMemberList()
		{
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0xD578A4", Offset = "0xD578A4", VA = "0xD578A4", Slot = "20")]
		public void PrepareForWiring(Table t)
		{
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0xD57B90", Offset = "0xD57B90", VA = "0xD57B90")]
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
			[Address(RVA = "0xD5889C", Offset = "0xD5889C", VA = "0xD5889C")]
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
		[Address(RVA = "0xD580C0", Offset = "0xD580C0", VA = "0xD580C0")]
		public static void RegisterExtensionType(Type type, InteropAccessMode mode = InteropAccessMode.Default)
		{
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0xD58934", Offset = "0xD58934", VA = "0xD58934")]
		private static object FrameworkGetMethods()
		{
			return null;
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0xD58974", Offset = "0xD58974", VA = "0xD58974")]
		public static IEnumerable<IOverloadableMemberDescriptor> GetExtensionMethodsByName(string name)
		{
			return null;
		}

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0xD58B14", Offset = "0xD58B14", VA = "0xD58B14")]
		public static int GetExtensionMethodsChangeVersion()
		{
			return default(int);
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0xD58B6C", Offset = "0xD58B6C", VA = "0xD58B6C")]
		public static List<IOverloadableMemberDescriptor> GetExtensionMethodsByNameAndType(string name, Type extendedType)
		{
			return null;
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0xD59580", Offset = "0xD59580", VA = "0xD59580")]
		private static MethodInfo InstantiateMethodInfo(MethodInfo mi, Type extensionType, Type genericType, Type extendedType)
		{
			return null;
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0xD59140", Offset = "0xD59140", VA = "0xD59140")]
		private static Type GetGenericMatch(Type extensionType, Type extendedType)
		{
			return null;
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0xD59694", Offset = "0xD59694", VA = "0xD59694")]
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
			[Address(RVA = "0xD5A968", Offset = "0xD5A968", VA = "0xD5A968")]
			get
			{
				return default(InteropAccessMode);
			}
			[Token(Token = "0x600060E")]
			[Address(RVA = "0xD5A9C0", Offset = "0xD5A9C0", VA = "0xD5A9C0")]
			set
			{
			}
		}

		[Token(Token = "0x170000F9")]
		public static IEnumerable<KeyValuePair<Type, IUserDataDescriptor>> RegisteredTypes
		{
			[Token(Token = "0x6000616")]
			[Address(RVA = "0xD5C2EC", Offset = "0xD5C2EC", VA = "0xD5C2EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000FA")]
		public static IEnumerable<KeyValuePair<Type, IUserDataDescriptor>> RegisteredTypesHistory
		{
			[Token(Token = "0x6000617")]
			[Address(RVA = "0xD5C428", Offset = "0xD5C428", VA = "0xD5C428")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000FB")]
		internal static IRegistrationPolicy RegistrationPolicy
		{
			[Token(Token = "0x6000618")]
			[Address(RVA = "0xD5C564", Offset = "0xD5C564", VA = "0xD5C564")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000619")]
			[Address(RVA = "0xD5C5BC", Offset = "0xD5C5BC", VA = "0xD5C5BC")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0xD59A10", Offset = "0xD59A10", VA = "0xD59A10")]
		internal static void RegisterAssembly([Optional] Assembly asm, bool includeExtensionTypes = false)
		{
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0xD5A4B0", Offset = "0xD5A4B0", VA = "0xD5A4B0")]
		internal static bool IsTypeRegistered(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0xD5A600", Offset = "0xD5A600", VA = "0xD5A600")]
		internal static void UnregisterType(Type t)
		{
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0xD5AA70", Offset = "0xD5AA70", VA = "0xD5AA70")]
		internal static IUserDataDescriptor RegisterProxyType_Impl(IProxyFactory proxyFactory, InteropAccessMode accessMode, string friendlyName)
		{
			return null;
		}

		[Token(Token = "0x6000610")]
		[Address(RVA = "0xD5AC1C", Offset = "0xD5AC1C", VA = "0xD5AC1C")]
		internal static IUserDataDescriptor RegisterType_Impl(Type type, InteropAccessMode accessMode, string friendlyName, IUserDataDescriptor descriptor)
		{
			return null;
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0xD5A7B4", Offset = "0xD5A7B4", VA = "0xD5A7B4")]
		private static IUserDataDescriptor PerformRegistration(Type type, IUserDataDescriptor newDescriptor, IUserDataDescriptor oldDescriptor)
		{
			return null;
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0xD5B2D0", Offset = "0xD5B2D0", VA = "0xD5B2D0")]
		internal static InteropAccessMode ResolveDefaultAccessModeForType(InteropAccessMode accessMode, Type type)
		{
			return default(InteropAccessMode);
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0xD5B5A0", Offset = "0xD5B5A0", VA = "0xD5B5A0")]
		internal static IUserDataDescriptor GetDescriptorForType(Type type, bool searchInterfaces)
		{
			return null;
		}

		[Token(Token = "0x6000614")]
		[Address(RVA = "0xD5C2AC", Offset = "0xD5C2AC", VA = "0xD5C2AC")]
		private static bool FrameworkIsAssignableFrom(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0xD5B404", Offset = "0xD5B404", VA = "0xD5B404")]
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
		[Address(RVA = "0xD5CD3C", Offset = "0xD5CD3C", VA = "0xD5CD3C")]
		public EventFacade(EventMemberDescriptor parent, object obj)
		{
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0xD5CE10", Offset = "0xD5CE10", VA = "0xD5CE10")]
		public EventFacade(Func<object, ScriptExecutionContext, CallbackArguments, DynValue> addCallback, Func<object, ScriptExecutionContext, CallbackArguments, DynValue> removeCallback, object obj)
		{
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0xD5CE4C", Offset = "0xD5CE4C", VA = "0xD5CE4C", Slot = "4")]
		public DynValue Index(Script script, DynValue index, bool isDirectIndexing)
		{
			return null;
		}

		[Token(Token = "0x6000629")]
		[Address(RVA = "0xD5CFE4", Offset = "0xD5CFE4", VA = "0xD5CFE4", Slot = "5")]
		public bool SetIndex(Script script, DynValue index, DynValue value, bool isDirectIndexing)
		{
			return default(bool);
		}

		[Token(Token = "0x600062A")]
		[Address(RVA = "0xD5D034", Offset = "0xD5D034", VA = "0xD5D034", Slot = "6")]
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
		[Address(RVA = "0xD5D09C", Offset = "0xD5D09C", VA = "0xD5D09C")]
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
			[Address(RVA = "0xD5D108", Offset = "0xD5D108", VA = "0xD5D108")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000630")]
			[Address(RVA = "0xD5D110", Offset = "0xD5D110", VA = "0xD5D110")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000FD")]
		public bool IsStatic
		{
			[Token(Token = "0x6000632")]
			[Address(RVA = "0xD5D164", Offset = "0xD5D164", VA = "0xD5D164", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000633")]
			[Address(RVA = "0xD5D16C", Offset = "0xD5D16C", VA = "0xD5D16C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000FE")]
		public string Name
		{
			[Token(Token = "0x6000634")]
			[Address(RVA = "0xD5D178", Offset = "0xD5D178", VA = "0xD5D178", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000635")]
			[Address(RVA = "0xD5D180", Offset = "0xD5D180", VA = "0xD5D180")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000FF")]
		public MemberDescriptorAccess MemberAccess
		{
			[Token(Token = "0x6000636")]
			[Address(RVA = "0xD5D188", Offset = "0xD5D188", VA = "0xD5D188", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(MemberDescriptorAccess);
			}
			[Token(Token = "0x6000637")]
			[Address(RVA = "0xD5D190", Offset = "0xD5D190", VA = "0xD5D190")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0xD5D118", Offset = "0xD5D118", VA = "0xD5D118")]
		protected HardwiredMemberDescriptor(Type memberType, string name, bool isStatic, MemberDescriptorAccess access)
		{
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0xD5D198", Offset = "0xD5D198", VA = "0xD5D198", Slot = "7")]
		public DynValue GetValue(Script script, object obj)
		{
			return null;
		}

		[Token(Token = "0x6000639")]
		[Address(RVA = "0xD5D1E4", Offset = "0xD5D1E4", VA = "0xD5D1E4", Slot = "8")]
		public void SetValue(Script script, object obj, DynValue value)
		{
		}

		[Token(Token = "0x600063A")]
		[Address(RVA = "0xD5D24C", Offset = "0xD5D24C", VA = "0xD5D24C", Slot = "9")]
		protected virtual object GetValueImpl(Script script, object obj)
		{
			return null;
		}

		[Token(Token = "0x600063B")]
		[Address(RVA = "0xD5D2B4", Offset = "0xD5D2B4", VA = "0xD5D2B4", Slot = "10")]
		protected virtual void SetValueImpl(Script script, object obj, object value)
		{
		}
	}
	[Token(Token = "0x20000E7")]
	public abstract class HardwiredMethodMemberDescriptor : FunctionMemberDescriptorBase
	{
		[Token(Token = "0x600063C")]
		[Address(RVA = "0xD5D31C", Offset = "0xD5D31C", VA = "0xD5D31C", Slot = "16")]
		public override DynValue Execute(Script script, object obj, ScriptExecutionContext context, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0xD5D418", Offset = "0xD5D418", VA = "0xD5D418")]
		private int CalcArgsCount(object[] pars)
		{
			return default(int);
		}

		[Token(Token = "0x600063E")]
		protected abstract object Invoke(Script script, object obj, object[] pars, int argscount);

		[Token(Token = "0x600063F")]
		[Address(RVA = "0xD5D4DC", Offset = "0xD5D4DC", VA = "0xD5D4DC")]
		protected HardwiredMethodMemberDescriptor()
		{
		}
	}
	[Token(Token = "0x20000E8")]
	public abstract class HardwiredUserDataDescriptor : DispatchingUserDataDescriptor
	{
		[Token(Token = "0x6000640")]
		[Address(RVA = "0xD5D4E4", Offset = "0xD5D4E4", VA = "0xD5D4E4")]
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
		[Address(RVA = "0xD5D564", Offset = "0xD5D564", VA = "0xD5D564", Slot = "6")]
		public override bool AllowTypeAutoRegistration(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0xD5D56C", Offset = "0xD5D56C", VA = "0xD5D56C")]
		public AutomaticRegistrationPolicy()
		{
		}
	}
	[Token(Token = "0x20000EA")]
	public class DefaultRegistrationPolicy : IRegistrationPolicy
	{
		[Token(Token = "0x6000643")]
		[Address(RVA = "0xD5D57C", Offset = "0xD5D57C", VA = "0xD5D57C", Slot = "4")]
		public IUserDataDescriptor HandleRegistration(IUserDataDescriptor newDescriptor, IUserDataDescriptor oldDescriptor)
		{
			return null;
		}

		[Token(Token = "0x6000644")]
		[Address(RVA = "0xD5D594", Offset = "0xD5D594", VA = "0xD5D594", Slot = "6")]
		public virtual bool AllowTypeAutoRegistration(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000645")]
		[Address(RVA = "0xD5D574", Offset = "0xD5D574", VA = "0xD5D574")]
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
		[Address(RVA = "0xD5D59C", Offset = "0xD5D59C", VA = "0xD5D59C", Slot = "4")]
		public IUserDataDescriptor HandleRegistration(IUserDataDescriptor newDescriptor, IUserDataDescriptor oldDescriptor)
		{
			return null;
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0xD5D5A8", Offset = "0xD5D5A8", VA = "0xD5D5A8", Slot = "5")]
		public bool AllowTypeAutoRegistration(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0xD5D5B0", Offset = "0xD5D5B0", VA = "0xD5D5B0")]
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
			[Address(RVA = "0xD5D5B8", Offset = "0xD5D5B8", VA = "0xD5D5B8")]
			get
			{
				return default(char);
			}
			[Token(Token = "0x600064C")]
			[Address(RVA = "0xD5D5F0", Offset = "0xD5D5F0", VA = "0xD5D5F0")]
			set
			{
			}
		}

		[Token(Token = "0x17000101")]
		public char this[uint offset]
		{
			[Token(Token = "0x600064D")]
			[Address(RVA = "0xD5D628", Offset = "0xD5D628", VA = "0xD5D628")]
			get
			{
				return default(char);
			}
			[Token(Token = "0x600064E")]
			[Address(RVA = "0xD5D690", Offset = "0xD5D690", VA = "0xD5D690")]
			set
			{
			}
		}

		[Token(Token = "0x17000102")]
		public char this[long offset]
		{
			[Token(Token = "0x600064F")]
			[Address(RVA = "0xD5D704", Offset = "0xD5D704", VA = "0xD5D704")]
			get
			{
				return default(char);
			}
			[Token(Token = "0x6000650")]
			[Address(RVA = "0xD5D73C", Offset = "0xD5D73C", VA = "0xD5D73C")]
			set
			{
			}
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0xD5D774", Offset = "0xD5D774", VA = "0xD5D774")]
		public static implicit operator CharPtr(string str)
		{
			return null;
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0xD5D854", Offset = "0xD5D854", VA = "0xD5D854")]
		public static implicit operator CharPtr(char[] chars)
		{
			return null;
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0xD5D8E8", Offset = "0xD5D8E8", VA = "0xD5D8E8")]
		public static implicit operator CharPtr(byte[] bytes)
		{
			return null;
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0xD5DA04", Offset = "0xD5DA04", VA = "0xD5DA04")]
		public CharPtr()
		{
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0xD5D7D4", Offset = "0xD5D7D4", VA = "0xD5D7D4")]
		public CharPtr(string str)
		{
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0xD5DA24", Offset = "0xD5DA24", VA = "0xD5DA24")]
		public CharPtr(CharPtr ptr)
		{
		}

		[Token(Token = "0x6000657")]
		[Address(RVA = "0xD5DA60", Offset = "0xD5DA60", VA = "0xD5DA60")]
		public CharPtr(CharPtr ptr, int index)
		{
		}

		[Token(Token = "0x6000658")]
		[Address(RVA = "0xD5D8BC", Offset = "0xD5D8BC", VA = "0xD5D8BC")]
		public CharPtr(char[] chars)
		{
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0xD5DA9C", Offset = "0xD5DA9C", VA = "0xD5DA9C")]
		public CharPtr(char[] chars, int index)
		{
		}

		[Token(Token = "0x600065A")]
		[Address(RVA = "0xD5D948", Offset = "0xD5D948", VA = "0xD5D948")]
		public CharPtr(byte[] bytes)
		{
		}

		[Token(Token = "0x600065B")]
		[Address(RVA = "0xD5DACC", Offset = "0xD5DACC", VA = "0xD5DACC")]
		public CharPtr(IntPtr ptr)
		{
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0xD5DB2C", Offset = "0xD5DB2C", VA = "0xD5DB2C")]
		public static CharPtr operator +(CharPtr ptr, int offset)
		{
			return null;
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0xD5DBB0", Offset = "0xD5DBB0", VA = "0xD5DBB0")]
		public static CharPtr operator -(CharPtr ptr, int offset)
		{
			return null;
		}

		[Token(Token = "0x600065E")]
		[Address(RVA = "0xD5DC34", Offset = "0xD5DC34", VA = "0xD5DC34")]
		public static CharPtr operator +(CharPtr ptr, uint offset)
		{
			return null;
		}

		[Token(Token = "0x600065F")]
		[Address(RVA = "0xD5DCB8", Offset = "0xD5DCB8", VA = "0xD5DCB8")]
		public static CharPtr operator -(CharPtr ptr, uint offset)
		{
			return null;
		}

		[Token(Token = "0x6000660")]
		[Address(RVA = "0xD5DD3C", Offset = "0xD5DD3C", VA = "0xD5DD3C")]
		public void inc()
		{
		}

		[Token(Token = "0x6000661")]
		[Address(RVA = "0xD5DD4C", Offset = "0xD5DD4C", VA = "0xD5DD4C")]
		public void dec()
		{
		}

		[Token(Token = "0x6000662")]
		[Address(RVA = "0xD5DD5C", Offset = "0xD5DD5C", VA = "0xD5DD5C")]
		public CharPtr next()
		{
			return null;
		}

		[Token(Token = "0x6000663")]
		[Address(RVA = "0xD5DDD8", Offset = "0xD5DDD8", VA = "0xD5DDD8")]
		public CharPtr prev()
		{
			return null;
		}

		[Token(Token = "0x6000664")]
		[Address(RVA = "0xD5DE54", Offset = "0xD5DE54", VA = "0xD5DE54")]
		public CharPtr add(int ofs)
		{
			return null;
		}

		[Token(Token = "0x6000665")]
		[Address(RVA = "0xD5DED4", Offset = "0xD5DED4", VA = "0xD5DED4")]
		public CharPtr sub(int ofs)
		{
			return null;
		}

		[Token(Token = "0x6000666")]
		[Address(RVA = "0xD5DF54", Offset = "0xD5DF54", VA = "0xD5DF54")]
		public static bool operator ==(CharPtr ptr, char ch)
		{
			return default(bool);
		}

		[Token(Token = "0x6000667")]
		[Address(RVA = "0xD5DF80", Offset = "0xD5DF80", VA = "0xD5DF80")]
		public static bool operator ==(char ch, CharPtr ptr)
		{
			return default(bool);
		}

		[Token(Token = "0x6000668")]
		[Address(RVA = "0xD5DFB0", Offset = "0xD5DFB0", VA = "0xD5DFB0")]
		public static bool operator !=(CharPtr ptr, char ch)
		{
			return default(bool);
		}

		[Token(Token = "0x6000669")]
		[Address(RVA = "0xD5DFDC", Offset = "0xD5DFDC", VA = "0xD5DFDC")]
		public static bool operator !=(char ch, CharPtr ptr)
		{
			return default(bool);
		}

		[Token(Token = "0x600066A")]
		[Address(RVA = "0xD5E00C", Offset = "0xD5E00C", VA = "0xD5E00C")]
		public static CharPtr operator +(CharPtr ptr1, CharPtr ptr2)
		{
			return null;
		}

		[Token(Token = "0x600066B")]
		[Address(RVA = "0xD5E15C", Offset = "0xD5E15C", VA = "0xD5E15C")]
		public static int operator -(CharPtr ptr1, CharPtr ptr2)
		{
			return default(int);
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0xD5E180", Offset = "0xD5E180", VA = "0xD5E180")]
		public static bool operator <(CharPtr ptr1, CharPtr ptr2)
		{
			return default(bool);
		}

		[Token(Token = "0x600066D")]
		[Address(RVA = "0xD5E1A8", Offset = "0xD5E1A8", VA = "0xD5E1A8")]
		public static bool operator <=(CharPtr ptr1, CharPtr ptr2)
		{
			return default(bool);
		}

		[Token(Token = "0x600066E")]
		[Address(RVA = "0xD5E1D0", Offset = "0xD5E1D0", VA = "0xD5E1D0")]
		public static bool operator >(CharPtr ptr1, CharPtr ptr2)
		{
			return default(bool);
		}

		[Token(Token = "0x600066F")]
		[Address(RVA = "0xD5E1F8", Offset = "0xD5E1F8", VA = "0xD5E1F8")]
		public static bool operator >=(CharPtr ptr1, CharPtr ptr2)
		{
			return default(bool);
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0xD5E220", Offset = "0xD5E220", VA = "0xD5E220")]
		public static bool operator ==(CharPtr ptr1, CharPtr ptr2)
		{
			return default(bool);
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0xD5E264", Offset = "0xD5E264", VA = "0xD5E264")]
		public static bool operator !=(CharPtr ptr1, CharPtr ptr2)
		{
			return default(bool);
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0xD5E2A8", Offset = "0xD5E2A8", VA = "0xD5E2A8", Slot = "0")]
		public override bool Equals(object o)
		{
			return default(bool);
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0xD5E360", Offset = "0xD5E360", VA = "0xD5E360", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0xD5E368", Offset = "0xD5E368", VA = "0xD5E368", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000675")]
		[Address(RVA = "0xD5E424", Offset = "0xD5E424", VA = "0xD5E424")]
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
		[Address(RVA = "0xD5E4EC", Offset = "0xD5E4EC", VA = "0xD5E4EC")]
		protected static DynValue GetArgument(LuaState L, int pos)
		{
			return null;
		}

		[Token(Token = "0x6000677")]
		[Address(RVA = "0xD5E5F0", Offset = "0xD5E5F0", VA = "0xD5E5F0")]
		protected static DynValue ArgAsType(LuaState L, int pos, DataType type, bool allowNil = false)
		{
			return null;
		}

		[Token(Token = "0x6000678")]
		[Address(RVA = "0xD5E648", Offset = "0xD5E648", VA = "0xD5E648")]
		protected static int LuaType(LuaState L, int p)
		{
			return default(int);
		}

		[Token(Token = "0x6000679")]
		[Address(RVA = "0xD5E6D4", Offset = "0xD5E6D4", VA = "0xD5E6D4")]
		protected static string LuaLCheckLString(LuaState L, int argNum, out uint l)
		{
			return null;
		}

		[Token(Token = "0x600067A")]
		[Address(RVA = "0xD5E70C", Offset = "0xD5E70C", VA = "0xD5E70C")]
		protected static void LuaPushInteger(LuaState L, int val)
		{
		}

		[Token(Token = "0x600067B")]
		[Address(RVA = "0xD5E82C", Offset = "0xD5E82C", VA = "0xD5E82C")]
		protected static int LuaToBoolean(LuaState L, int p)
		{
			return default(int);
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0xD5E854", Offset = "0xD5E854", VA = "0xD5E854")]
		protected static string LuaToLString(LuaState luaState, int p, out uint l)
		{
			return null;
		}

		[Token(Token = "0x600067D")]
		[Address(RVA = "0xD5E858", Offset = "0xD5E858", VA = "0xD5E858")]
		protected static string LuaToString(LuaState luaState, int p)
		{
			return null;
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0xD5E870", Offset = "0xD5E870", VA = "0xD5E870")]
		protected static void LuaLAddValue(LuaLBuffer b)
		{
		}

		[Token(Token = "0x600067F")]
		[Address(RVA = "0xD5E934", Offset = "0xD5E934", VA = "0xD5E934")]
		protected static void LuaLAddLString(LuaLBuffer b, CharPtr s, uint p)
		{
		}

		[Token(Token = "0x6000680")]
		[Address(RVA = "0xD5E96C", Offset = "0xD5E96C", VA = "0xD5E96C")]
		protected static void LuaLAddString(LuaLBuffer b, string s)
		{
		}

		[Token(Token = "0x6000681")]
		[Address(RVA = "0xD5E9AC", Offset = "0xD5E9AC", VA = "0xD5E9AC")]
		protected static int LuaLOptInteger(LuaState L, int pos, int def)
		{
			return default(int);
		}

		[Token(Token = "0x6000682")]
		[Address(RVA = "0xD5EA08", Offset = "0xD5EA08", VA = "0xD5EA08")]
		protected static int LuaLCheckInteger(LuaState L, int pos)
		{
			return default(int);
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0xD5EA44", Offset = "0xD5EA44", VA = "0xD5EA44")]
		protected static void LuaLArgCheck(LuaState L, bool condition, int argNum, string message)
		{
		}

		[Token(Token = "0x6000684")]
		[Address(RVA = "0xD5EAA4", Offset = "0xD5EAA4", VA = "0xD5EAA4")]
		protected static int LuaLCheckInt(LuaState L, int argNum)
		{
			return default(int);
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0xD5EAA8", Offset = "0xD5EAA8", VA = "0xD5EAA8")]
		protected static int LuaGetTop(LuaState L)
		{
			return default(int);
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0xD5EB00", Offset = "0xD5EB00", VA = "0xD5EB00")]
		protected static int LuaLError(LuaState luaState, string message, params object[] args)
		{
			return default(int);
		}

		[Token(Token = "0x6000687")]
		[Address(RVA = "0xD5EB54", Offset = "0xD5EB54", VA = "0xD5EB54")]
		protected static void LuaLAddChar(LuaLBuffer b, char p)
		{
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0xD5EB74", Offset = "0xD5EB74", VA = "0xD5EB74")]
		protected static void LuaLBuffInit(LuaState L, LuaLBuffer b)
		{
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0xD5EB78", Offset = "0xD5EB78", VA = "0xD5EB78")]
		protected static void LuaPushLiteral(LuaState L, string literalString)
		{
		}

		[Token(Token = "0x600068A")]
		[Address(RVA = "0xD5EBF0", Offset = "0xD5EBF0", VA = "0xD5EBF0")]
		protected static void LuaLPushResult(LuaLBuffer b)
		{
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0xD5EC28", Offset = "0xD5EC28", VA = "0xD5EC28")]
		protected static void LuaPushLString(LuaState L, CharPtr s, uint len)
		{
		}

		[Token(Token = "0x600068C")]
		[Address(RVA = "0xD5ECBC", Offset = "0xD5ECBC", VA = "0xD5ECBC")]
		protected static void LuaLCheckStack(LuaState L, int n, string message)
		{
		}

		[Token(Token = "0x600068D")]
		[Address(RVA = "0xD5ECC0", Offset = "0xD5ECC0", VA = "0xD5ECC0")]
		protected static string LUA_QL(string p)
		{
			return null;
		}

		[Token(Token = "0x600068E")]
		[Address(RVA = "0xD5ED10", Offset = "0xD5ED10", VA = "0xD5ED10")]
		protected static void LuaPushNil(LuaState L)
		{
		}

		[Token(Token = "0x600068F")]
		[Address(RVA = "0xD5EDA8", Offset = "0xD5EDA8", VA = "0xD5EDA8")]
		protected static void LuaAssert(bool p)
		{
		}

		[Token(Token = "0x6000690")]
		[Address(RVA = "0xD5EDAC", Offset = "0xD5EDAC", VA = "0xD5EDAC")]
		protected static string LuaLTypeName(LuaState L, int p)
		{
			return null;
		}

		[Token(Token = "0x6000691")]
		[Address(RVA = "0xD5EDD0", Offset = "0xD5EDD0", VA = "0xD5EDD0")]
		protected static int LuaIsString(LuaState L, int p)
		{
			return default(int);
		}

		[Token(Token = "0x6000692")]
		[Address(RVA = "0xD5EDFC", Offset = "0xD5EDFC", VA = "0xD5EDFC")]
		protected static void LuaPop(LuaState L, int p)
		{
		}

		[Token(Token = "0x6000693")]
		[Address(RVA = "0xD5EE38", Offset = "0xD5EE38", VA = "0xD5EE38")]
		protected static void LuaGetTable(LuaState L, int p)
		{
		}

		[Token(Token = "0x6000694")]
		[Address(RVA = "0xD5EEE4", Offset = "0xD5EEE4", VA = "0xD5EEE4")]
		protected static int LuaLOptInt(LuaState L, int pos, int def)
		{
			return default(int);
		}

		[Token(Token = "0x6000695")]
		[Address(RVA = "0xD5EEE8", Offset = "0xD5EEE8", VA = "0xD5EEE8")]
		protected static CharPtr LuaLCheckString(LuaState L, int p)
		{
			return null;
		}

		[Token(Token = "0x6000696")]
		[Address(RVA = "0xD5EF00", Offset = "0xD5EF00", VA = "0xD5EF00")]
		protected static string LuaLCheckStringStr(LuaState L, int p)
		{
			return null;
		}

		[Token(Token = "0x6000697")]
		[Address(RVA = "0xD5EA5C", Offset = "0xD5EA5C", VA = "0xD5EA5C")]
		protected static void LuaLArgError(LuaState L, int arg, string p)
		{
		}

		[Token(Token = "0x6000698")]
		[Address(RVA = "0xD5EF18", Offset = "0xD5EF18", VA = "0xD5EF18")]
		protected static double LuaLCheckNumber(LuaState L, int pos)
		{
			return default(double);
		}

		[Token(Token = "0x6000699")]
		[Address(RVA = "0xD5EF3C", Offset = "0xD5EF3C", VA = "0xD5EF3C")]
		protected static void LuaPushValue(LuaState L, int arg)
		{
		}

		[Token(Token = "0x600069A")]
		[Address(RVA = "0xD5EF60", Offset = "0xD5EF60", VA = "0xD5EF60")]
		protected static void LuaCall(LuaState L, int nargs, int nresults = -1)
		{
		}

		[Token(Token = "0x600069B")]
		[Address(RVA = "0xD5F2C4", Offset = "0xD5F2C4", VA = "0xD5F2C4")]
		protected static int memcmp(CharPtr ptr1, CharPtr ptr2, uint size)
		{
			return default(int);
		}

		[Token(Token = "0x600069C")]
		[Address(RVA = "0xD5F2C8", Offset = "0xD5F2C8", VA = "0xD5F2C8")]
		protected static int memcmp(CharPtr ptr1, CharPtr ptr2, int size)
		{
			return default(int);
		}

		[Token(Token = "0x600069D")]
		[Address(RVA = "0xD5F36C", Offset = "0xD5F36C", VA = "0xD5F36C")]
		protected static CharPtr memchr(CharPtr ptr, char c, uint count)
		{
			return null;
		}

		[Token(Token = "0x600069E")]
		[Address(RVA = "0xD5F428", Offset = "0xD5F428", VA = "0xD5F428")]
		protected static CharPtr strpbrk(CharPtr str, CharPtr charset)
		{
			return null;
		}

		[Token(Token = "0x600069F")]
		[Address(RVA = "0xD5F548", Offset = "0xD5F548", VA = "0xD5F548")]
		protected static bool isalpha(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x60006A0")]
		[Address(RVA = "0xD5F5A0", Offset = "0xD5F5A0", VA = "0xD5F5A0")]
		protected static bool iscntrl(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x60006A1")]
		[Address(RVA = "0xD5F5F8", Offset = "0xD5F5F8", VA = "0xD5F5F8")]
		protected static bool isdigit(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x60006A2")]
		[Address(RVA = "0xD5F650", Offset = "0xD5F650", VA = "0xD5F650")]
		protected static bool islower(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x60006A3")]
		[Address(RVA = "0xD5F6A8", Offset = "0xD5F6A8", VA = "0xD5F6A8")]
		protected static bool ispunct(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0xD5F700", Offset = "0xD5F700", VA = "0xD5F700")]
		protected static bool isspace(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0xD5F728", Offset = "0xD5F728", VA = "0xD5F728")]
		protected static bool isupper(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0xD5F780", Offset = "0xD5F780", VA = "0xD5F780")]
		protected static bool isalnum(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x60006A7")]
		[Address(RVA = "0xD5F7D8", Offset = "0xD5F7D8", VA = "0xD5F7D8")]
		protected static bool isxdigit(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x60006A8")]
		[Address(RVA = "0xD5F838", Offset = "0xD5F838", VA = "0xD5F838")]
		protected static bool isgraph(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x60006A9")]
		[Address(RVA = "0xD5F8C4", Offset = "0xD5F8C4", VA = "0xD5F8C4")]
		protected static bool isalpha(int c)
		{
			return default(bool);
		}

		[Token(Token = "0x60006AA")]
		[Address(RVA = "0xD5F91C", Offset = "0xD5F91C", VA = "0xD5F91C")]
		protected static bool iscntrl(int c)
		{
			return default(bool);
		}

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0xD5F974", Offset = "0xD5F974", VA = "0xD5F974")]
		protected static bool isdigit(int c)
		{
			return default(bool);
		}

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0xD5F9CC", Offset = "0xD5F9CC", VA = "0xD5F9CC")]
		protected static bool islower(int c)
		{
			return default(bool);
		}

		[Token(Token = "0x60006AD")]
		[Address(RVA = "0xD5FA24", Offset = "0xD5FA24", VA = "0xD5FA24")]
		protected static bool ispunct(int c)
		{
			return default(bool);
		}

		[Token(Token = "0x60006AE")]
		[Address(RVA = "0xD5FA50", Offset = "0xD5FA50", VA = "0xD5FA50")]
		protected static bool isspace(int c)
		{
			return default(bool);
		}

		[Token(Token = "0x60006AF")]
		[Address(RVA = "0xD5FA74", Offset = "0xD5FA74", VA = "0xD5FA74")]
		protected static bool isupper(int c)
		{
			return default(bool);
		}

		[Token(Token = "0x60006B0")]
		[Address(RVA = "0xD5FACC", Offset = "0xD5FACC", VA = "0xD5FACC")]
		protected static bool isalnum(int c)
		{
			return default(bool);
		}

		[Token(Token = "0x60006B1")]
		[Address(RVA = "0xD5FB24", Offset = "0xD5FB24", VA = "0xD5FB24")]
		protected static bool isgraph(int c)
		{
			return default(bool);
		}

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0xD5FBB0", Offset = "0xD5FBB0", VA = "0xD5FBB0")]
		protected static char tolower(char c)
		{
			return default(char);
		}

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0xD5FC08", Offset = "0xD5FC08", VA = "0xD5FC08")]
		protected static char toupper(char c)
		{
			return default(char);
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0xD5FC60", Offset = "0xD5FC60", VA = "0xD5FC60")]
		protected static char tolower(int c)
		{
			return default(char);
		}

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0xD5FCB8", Offset = "0xD5FCB8", VA = "0xD5FCB8")]
		protected static char toupper(int c)
		{
			return default(char);
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0xD5FD10", Offset = "0xD5FD10", VA = "0xD5FD10")]
		protected static CharPtr strchr(CharPtr str, char c)
		{
			return null;
		}

		[Token(Token = "0x60006B7")]
		[Address(RVA = "0xD5FDC4", Offset = "0xD5FDC4", VA = "0xD5FDC4")]
		protected static CharPtr strcpy(CharPtr dst, CharPtr src)
		{
			return null;
		}

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0xD5FE58", Offset = "0xD5FE58", VA = "0xD5FE58")]
		protected static CharPtr strncpy(CharPtr dst, CharPtr src, int length)
		{
			return null;
		}

		[Token(Token = "0x60006B9")]
		[Address(RVA = "0xD5FF24", Offset = "0xD5FF24", VA = "0xD5FF24")]
		protected static int strlen(CharPtr str)
		{
			return default(int);
		}

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0xD5FF64", Offset = "0xD5FF64", VA = "0xD5FF64")]
		public static void sprintf(CharPtr buffer, CharPtr str, params object[] argv)
		{
		}

		[Token(Token = "0x60006BB")]
		[Address(RVA = "0xD60F04", Offset = "0xD60F04", VA = "0xD60F04")]
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
			[Address(RVA = "0xD60F0C", Offset = "0xD60F0C", VA = "0xD60F0C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60006BD")]
			[Address(RVA = "0xD60F14", Offset = "0xD60F14", VA = "0xD60F14")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000104")]
		public LuaState LuaState
		{
			[Token(Token = "0x60006BE")]
			[Address(RVA = "0xD60F1C", Offset = "0xD60F1C", VA = "0xD60F1C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60006BF")]
			[Address(RVA = "0xD60F24", Offset = "0xD60F24", VA = "0xD60F24")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0xD60F2C", Offset = "0xD60F2C", VA = "0xD60F2C")]
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
			[Address(RVA = "0xD60FA4", Offset = "0xD60FA4", VA = "0xD60FA4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60006C2")]
			[Address(RVA = "0xD60FAC", Offset = "0xD60FAC", VA = "0xD60FAC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000106")]
		public string FunctionName
		{
			[Token(Token = "0x60006C3")]
			[Address(RVA = "0xD60FB4", Offset = "0xD60FB4", VA = "0xD60FB4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60006C4")]
			[Address(RVA = "0xD60FBC", Offset = "0xD60FBC", VA = "0xD60FBC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000107")]
		public int Count
		{
			[Token(Token = "0x60006C8")]
			[Address(RVA = "0xD5EAB8", Offset = "0xD5EAB8", VA = "0xD5EAB8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60006C5")]
		[Address(RVA = "0xD60FC4", Offset = "0xD60FC4", VA = "0xD60FC4")]
		internal LuaState(ScriptExecutionContext executionContext, CallbackArguments args, string functionName)
		{
		}

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0xD61114", Offset = "0xD61114", VA = "0xD61114")]
		public DynValue Top(int pos = 0)
		{
			return null;
		}

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0xD5E4FC", Offset = "0xD5E4FC", VA = "0xD5E4FC")]
		public DynValue At(int pos)
		{
			return null;
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0xD5E784", Offset = "0xD5E784", VA = "0xD5E784")]
		public void Push(DynValue v)
		{
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0xD5E8B4", Offset = "0xD5E8B4", VA = "0xD5E8B4")]
		public DynValue Pop()
		{
			return null;
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0xD5F16C", Offset = "0xD5F16C", VA = "0xD5F16C")]
		public DynValue[] GetTopArray(int num)
		{
			return null;
		}

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0xD61180", Offset = "0xD61180", VA = "0xD61180")]
		public DynValue GetReturnValue(int retvals)
		{
			return null;
		}

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0xD5F248", Offset = "0xD5F248", VA = "0xD5F248")]
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
		[Address(RVA = "0xD61268", Offset = "0xD61268", VA = "0xD61268")]
		public static bool IsNumericType(object o)
		{
			return default(bool);
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0xD61408", Offset = "0xD61408", VA = "0xD61408")]
		public static bool IsPositive(object Value, bool ZeroIsPositive)
		{
			return default(bool);
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0xD61B4C", Offset = "0xD61B4C", VA = "0xD61B4C")]
		public static object ToUnsigned(object Value)
		{
			return null;
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0xD62158", Offset = "0xD62158", VA = "0xD62158")]
		public static object ToInteger(object Value, bool Round)
		{
			return null;
		}

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0xD62858", Offset = "0xD62858", VA = "0xD62858")]
		public static long UnboxToLong(object Value, bool Round)
		{
			return default(long);
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0xD6307C", Offset = "0xD6307C", VA = "0xD6307C")]
		public static string ReplaceMetaChars(string input)
		{
			return null;
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0xD63144", Offset = "0xD63144", VA = "0xD63144")]
		private static string ReplaceMetaCharsMatch(Match m)
		{
			return null;
		}

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0xD6350C", Offset = "0xD6350C", VA = "0xD6350C")]
		public static void fprintf(TextWriter Destination, string Format, params object[] Parameters)
		{
		}

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0xD5FFFC", Offset = "0xD5FFFC", VA = "0xD5FFFC")]
		public static string sprintf(string Format, params object[] Parameters)
		{
			return null;
		}

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0xD63920", Offset = "0xD63920", VA = "0xD63920")]
		private static string FormatOct(string NativeFormat, bool Alternate, int FieldLength, int FieldPrecision, bool Left2Right, char Padding, object Value)
		{
			return null;
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0xD63BC8", Offset = "0xD63BC8", VA = "0xD63BC8")]
		private static string FormatHex(string NativeFormat, bool Alternate, int FieldLength, int FieldPrecision, bool Left2Right, char Padding, object Value)
		{
			return null;
		}

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0xD63594", Offset = "0xD63594", VA = "0xD63594")]
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
		[Address(RVA = "0xD63F44", Offset = "0xD63F44", VA = "0xD63F44")]
		internal static DynValue TryObjectToTrivialDynValue(Script script, object obj)
		{
			return null;
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0xD648CC", Offset = "0xD648CC", VA = "0xD648CC")]
		internal static DynValue TryObjectToSimpleDynValue(Script script, object obj)
		{
			return null;
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0xD4B7D0", Offset = "0xD4B7D0", VA = "0xD4B7D0")]
		internal static DynValue ObjectToDynValue(Script script, object obj)
		{
			return null;
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0xD64E6C", Offset = "0xD64E6C", VA = "0xD64E6C")]
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
		[Address(RVA = "0xD64FBC", Offset = "0xD64FBC", VA = "0xD64FBC")]
		static NumericConversions()
		{
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0xD4BFF0", Offset = "0xD4BFF0", VA = "0xD4BFF0")]
		internal static object DoubleToType(Type type, double d)
		{
			return null;
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0xD64268", Offset = "0xD64268", VA = "0xD64268")]
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
		[Address(RVA = "0xD66404", Offset = "0xD66404", VA = "0xD66404")]
		internal static object DynValueToObject(DynValue value)
		{
			return null;
		}

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0xD66750", Offset = "0xD66750", VA = "0xD66750")]
		internal static object DynValueToObjectOfType(DynValue value, Type desiredType, object defaultValue, bool isOptional)
		{
			return null;
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0xD680F4", Offset = "0xD680F4", VA = "0xD680F4")]
		internal static int DynValueToObjectOfTypeWeight(DynValue value, Type desiredType, bool isOptional)
		{
			return default(int);
		}

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0xD68858", Offset = "0xD68858", VA = "0xD68858")]
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
		[Address(RVA = "0xD67108", Offset = "0xD67108", VA = "0xD67108")]
		internal static StringSubtype GetStringSubtype(Type desiredType)
		{
			return default(StringSubtype);
		}

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0xD67FD4", Offset = "0xD67FD4", VA = "0xD67FD4")]
		internal static object ConvertString(StringSubtype stringSubType, string str, Type desiredType, DataType dataType)
		{
			return null;
		}
	}
	[Token(Token = "0x20000F8")]
	internal static class TableConversions
	{
		[Token(Token = "0x60006E8")]
		[Address(RVA = "0xD68FDC", Offset = "0xD68FDC", VA = "0xD68FDC")]
		internal static Table ConvertIListToTable(Script script, IList list)
		{
			return null;
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0xD691AC", Offset = "0xD691AC", VA = "0xD691AC")]
		internal static Table ConvertIDictionaryToTable(Script script, IDictionary dict)
		{
			return null;
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0xD68940", Offset = "0xD68940", VA = "0xD68940")]
		internal static bool CanConvertTableToType(Table table, Type t)
		{
			return default(bool);
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0xD67240", Offset = "0xD67240", VA = "0xD67240")]
		internal static object ConvertTableToType(Table table, Type t)
		{
			return null;
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0xD697B8", Offset = "0xD697B8", VA = "0xD697B8")]
		internal static object ConvertTableToDictionaryOfGenericType(Type dictionaryType, Type keyType, Type valueType, Table table)
		{
			return null;
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0xD69CFC", Offset = "0xD69CFC", VA = "0xD69CFC")]
		internal static object ConvertTableToArrayOfGenericType(Type arrayType, Type itemType, Table table)
		{
			return null;
		}

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0xD69544", Offset = "0xD69544", VA = "0xD69544")]
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
			[Address(RVA = "0xD6A0C8", Offset = "0xD6A0C8", VA = "0xD6A0C8", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60006FC")]
			[Address(RVA = "0xD6A0D0", Offset = "0xD6A0D0", VA = "0xD6A0D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000109")]
		public Type Type
		{
			[Token(Token = "0x60006FD")]
			[Address(RVA = "0xD6A0D8", Offset = "0xD6A0D8", VA = "0xD6A0D8", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60006FE")]
			[Address(RVA = "0xD6A0E0", Offset = "0xD6A0E0", VA = "0xD6A0E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700010A")]
		public string FriendlyName
		{
			[Token(Token = "0x60006FF")]
			[Address(RVA = "0xD6A0E8", Offset = "0xD6A0E8", VA = "0xD6A0E8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000700")]
			[Address(RVA = "0xD6A0F0", Offset = "0xD6A0F0", VA = "0xD6A0F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700010B")]
		public IEnumerable<string> MemberNames
		{
			[Token(Token = "0x6000705")]
			[Address(RVA = "0xD6A4A8", Offset = "0xD6A4A8", VA = "0xD6A4A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700010C")]
		public IEnumerable<KeyValuePair<string, IMemberDescriptor>> Members
		{
			[Token(Token = "0x6000706")]
			[Address(RVA = "0xD6A4F8", Offset = "0xD6A4F8", VA = "0xD6A4F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700010D")]
		public IEnumerable<string> MetaMemberNames
		{
			[Token(Token = "0x6000709")]
			[Address(RVA = "0xD6A5B0", Offset = "0xD6A5B0", VA = "0xD6A5B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700010E")]
		public IEnumerable<KeyValuePair<string, IMemberDescriptor>> MetaMembers
		{
			[Token(Token = "0x600070A")]
			[Address(RVA = "0xD6A600", Offset = "0xD6A600", VA = "0xD6A600")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000701")]
		[Address(RVA = "0xD6A0F8", Offset = "0xD6A0F8", VA = "0xD6A0F8")]
		protected DispatchingUserDataDescriptor(Type type, [Optional] string friendlyName)
		{
		}

		[Token(Token = "0x6000702")]
		[Address(RVA = "0xD6A1E8", Offset = "0xD6A1E8", VA = "0xD6A1E8")]
		public void AddMetaMember(string name, IMemberDescriptor desc)
		{
		}

		[Token(Token = "0x6000703")]
		[Address(RVA = "0xD6A40C", Offset = "0xD6A40C", VA = "0xD6A40C")]
		public void AddDynValue(string name, DynValue value)
		{
		}

		[Token(Token = "0x6000704")]
		[Address(RVA = "0xD6A490", Offset = "0xD6A490", VA = "0xD6A490")]
		public void AddMember(string name, IMemberDescriptor desc)
		{
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0xD6A500", Offset = "0xD6A500", VA = "0xD6A500")]
		public IMemberDescriptor FindMember(string memberName)
		{
			return null;
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0xD6A558", Offset = "0xD6A558", VA = "0xD6A558")]
		public void RemoveMember(string memberName)
		{
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0xD6A608", Offset = "0xD6A608", VA = "0xD6A608")]
		public IMemberDescriptor FindMetaMember(string memberName)
		{
			return null;
		}

		[Token(Token = "0x600070C")]
		[Address(RVA = "0xD6A660", Offset = "0xD6A660", VA = "0xD6A660")]
		public void RemoveMetaMember(string memberName)
		{
		}

		[Token(Token = "0x600070D")]
		[Address(RVA = "0xD6A200", Offset = "0xD6A200", VA = "0xD6A200")]
		private void AddMemberTo(Dictionary<string, IMemberDescriptor> members, string name, IMemberDescriptor desc)
		{
		}

		[Token(Token = "0x600070E")]
		[Address(RVA = "0xD6A6B8", Offset = "0xD6A6B8", VA = "0xD6A6B8", Slot = "12")]
		public virtual DynValue Index(Script script, object obj, DynValue index, bool isDirectIndexing)
		{
			return null;
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0xD6AA68", Offset = "0xD6AA68", VA = "0xD6AA68")]
		private DynValue TryIndexOnExtMethod(Script script, object obj, string indexName)
		{
			return null;
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0xD6AC0C", Offset = "0xD6AC0C", VA = "0xD6AC0C")]
		public bool HasMember(string exactName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0xD6AC64", Offset = "0xD6AC64", VA = "0xD6AC64")]
		public bool HasMetaMember(string exactName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000712")]
		[Address(RVA = "0xD6ACBC", Offset = "0xD6ACBC", VA = "0xD6ACBC", Slot = "13")]
		protected virtual DynValue TryIndex(Script script, object obj, string indexName)
		{
			return null;
		}

		[Token(Token = "0x6000713")]
		[Address(RVA = "0xD6ADC4", Offset = "0xD6ADC4", VA = "0xD6ADC4", Slot = "14")]
		public virtual bool SetIndex(Script script, object obj, DynValue index, DynValue value, bool isDirectIndexing)
		{
			return default(bool);
		}

		[Token(Token = "0x6000714")]
		[Address(RVA = "0xD6AFB8", Offset = "0xD6AFB8", VA = "0xD6AFB8", Slot = "15")]
		protected virtual bool TrySetIndex(Script script, object obj, string indexName, DynValue value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000715")]
		[Address(RVA = "0xD6B0B0", Offset = "0xD6B0B0", VA = "0xD6B0B0", Slot = "11")]
		private void MoonSharp.Interpreter.Interop.BasicDescriptors.IOptimizableDescriptor.Optimize()
		{
		}

		[Token(Token = "0x6000716")]
		[Address(RVA = "0xD6AA60", Offset = "0xD6AA60", VA = "0xD6AA60")]
		protected static string Camelify(string name)
		{
			return null;
		}

		[Token(Token = "0x6000717")]
		[Address(RVA = "0xD6AA58", Offset = "0xD6AA58", VA = "0xD6AA58")]
		protected static string UpperFirstLetter(string name)
		{
			return null;
		}

		[Token(Token = "0x6000718")]
		[Address(RVA = "0xD6B708", Offset = "0xD6B708", VA = "0xD6B708", Slot = "16")]
		public virtual string AsString(object obj)
		{
			return null;
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0xD6B728", Offset = "0xD6B728", VA = "0xD6B728", Slot = "17")]
		protected virtual DynValue ExecuteIndexer(IMemberDescriptor mdesc, Script script, object obj, DynValue index, DynValue value)
		{
			return null;
		}

		[Token(Token = "0x600071A")]
		[Address(RVA = "0xD6BB24", Offset = "0xD6BB24", VA = "0xD6BB24", Slot = "18")]
		public virtual DynValue MetaIndex(Script script, object obj, string metaname)
		{
			return null;
		}

		[Token(Token = "0x600071B")]
		[Address(RVA = "0xD6C788", Offset = "0xD6C788", VA = "0xD6C788")]
		private int PerformComparison(object obj, object p1, object p2)
		{
			return default(int);
		}

		[Token(Token = "0x600071C")]
		[Address(RVA = "0xD6C3B8", Offset = "0xD6C3B8", VA = "0xD6C3B8")]
		private DynValue MultiDispatchLessThanOrEqual(Script script, object obj)
		{
			return null;
		}

		[Token(Token = "0x600071D")]
		[Address(RVA = "0xD6C2A0", Offset = "0xD6C2A0", VA = "0xD6C2A0")]
		private DynValue MultiDispatchLessThan(Script script, object obj)
		{
			return null;
		}

		[Token(Token = "0x600071E")]
		[Address(RVA = "0xD6C4D0", Offset = "0xD6C4D0", VA = "0xD6C4D0")]
		private DynValue TryDispatchLength(Script script, object obj)
		{
			return null;
		}

		[Token(Token = "0x600071F")]
		[Address(RVA = "0xD6C1BC", Offset = "0xD6C1BC", VA = "0xD6C1BC")]
		private DynValue MultiDispatchEqual(Script script, object obj)
		{
			return null;
		}

		[Token(Token = "0x6000720")]
		[Address(RVA = "0xD6CB84", Offset = "0xD6CB84", VA = "0xD6CB84")]
		private bool CheckEquality(object obj, object p1, object p2)
		{
			return default(bool);
		}

		[Token(Token = "0x6000721")]
		[Address(RVA = "0xD6C0C0", Offset = "0xD6C0C0", VA = "0xD6C0C0")]
		private DynValue DispatchMetaOnMethod(Script script, object obj, string methodName)
		{
			return null;
		}

		[Token(Token = "0x6000722")]
		[Address(RVA = "0xD6C5CC", Offset = "0xD6C5CC", VA = "0xD6C5CC")]
		private DynValue TryDispatchToNumber(Script script, object obj)
		{
			return null;
		}

		[Token(Token = "0x6000723")]
		[Address(RVA = "0xD6C6A4", Offset = "0xD6C6A4", VA = "0xD6C6A4")]
		private DynValue TryDispatchToBool(Script script, object obj)
		{
			return null;
		}

		[Token(Token = "0x6000724")]
		[Address(RVA = "0xD6CBFC", Offset = "0xD6CBFC", VA = "0xD6CBFC", Slot = "19")]
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
		[Address(RVA = "0xD6CF0C", Offset = "0xD6CF0C", VA = "0xD6CF0C")]
		public static bool HasAllFlags(this MemberDescriptorAccess access, MemberDescriptorAccess flag)
		{
			return default(bool);
		}

		[Token(Token = "0x6000731")]
		[Address(RVA = "0xD6C940", Offset = "0xD6C940", VA = "0xD6C940")]
		public static bool CanRead(this IMemberDescriptor desc)
		{
			return default(bool);
		}

		[Token(Token = "0x6000732")]
		[Address(RVA = "0xD6CF18", Offset = "0xD6CF18", VA = "0xD6CF18")]
		public static bool CanWrite(this IMemberDescriptor desc)
		{
			return default(bool);
		}

		[Token(Token = "0x6000733")]
		[Address(RVA = "0xD6C9E8", Offset = "0xD6C9E8", VA = "0xD6C9E8")]
		public static bool CanExecute(this IMemberDescriptor desc)
		{
			return default(bool);
		}

		[Token(Token = "0x6000734")]
		[Address(RVA = "0xD6CA90", Offset = "0xD6CA90", VA = "0xD6CA90")]
		public static DynValue GetGetterCallbackAsDynValue(this IMemberDescriptor desc, Script script, object obj)
		{
			return null;
		}

		[Token(Token = "0x6000735")]
		[Address(RVA = "0xD6A9A4", Offset = "0xD6A9A4", VA = "0xD6A9A4")]
		public static IMemberDescriptor WithAccessOrNull(this IMemberDescriptor desc, MemberDescriptorAccess access)
		{
			return null;
		}

		[Token(Token = "0x6000736")]
		[Address(RVA = "0xD6CFC8", Offset = "0xD6CFC8", VA = "0xD6CFC8")]
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
			[Address(RVA = "0xD6D338", Offset = "0xD6D338", VA = "0xD6D338")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000741")]
			[Address(RVA = "0xD6D340", Offset = "0xD6D340", VA = "0xD6D340")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000118")]
		public Type Type
		{
			[Token(Token = "0x6000742")]
			[Address(RVA = "0xD6D348", Offset = "0xD6D348", VA = "0xD6D348")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000743")]
			[Address(RVA = "0xD6D350", Offset = "0xD6D350", VA = "0xD6D350")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000119")]
		public bool HasDefaultValue
		{
			[Token(Token = "0x6000744")]
			[Address(RVA = "0xD6D358", Offset = "0xD6D358", VA = "0xD6D358")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000745")]
			[Address(RVA = "0xD6D360", Offset = "0xD6D360", VA = "0xD6D360")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700011A")]
		public object DefaultValue
		{
			[Token(Token = "0x6000746")]
			[Address(RVA = "0xD6D36C", Offset = "0xD6D36C", VA = "0xD6D36C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000747")]
			[Address(RVA = "0xD6D374", Offset = "0xD6D374", VA = "0xD6D374")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700011B")]
		public bool IsOut
		{
			[Token(Token = "0x6000748")]
			[Address(RVA = "0xD6D37C", Offset = "0xD6D37C", VA = "0xD6D37C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000749")]
			[Address(RVA = "0xD6D384", Offset = "0xD6D384", VA = "0xD6D384")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700011C")]
		public bool IsRef
		{
			[Token(Token = "0x600074A")]
			[Address(RVA = "0xD6D390", Offset = "0xD6D390", VA = "0xD6D390")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600074B")]
			[Address(RVA = "0xD6D398", Offset = "0xD6D398", VA = "0xD6D398")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700011D")]
		public bool IsVarArgs
		{
			[Token(Token = "0x600074C")]
			[Address(RVA = "0xD6D3A4", Offset = "0xD6D3A4", VA = "0xD6D3A4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600074D")]
			[Address(RVA = "0xD6D3AC", Offset = "0xD6D3AC", VA = "0xD6D3AC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700011E")]
		public bool HasBeenRestricted
		{
			[Token(Token = "0x600074E")]
			[Address(RVA = "0xD6D3B8", Offset = "0xD6D3B8", VA = "0xD6D3B8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700011F")]
		public Type OriginalType
		{
			[Token(Token = "0x600074F")]
			[Address(RVA = "0xD6D418", Offset = "0xD6D418", VA = "0xD6D418")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000750")]
		[Address(RVA = "0xD6D430", Offset = "0xD6D430", VA = "0xD6D430")]
		public ParameterDescriptor(string name, Type type, bool hasDefaultValue = false, [Optional] object defaultValue, bool isOut = false, bool isRef = false, bool isVarArgs = false)
		{
		}

		[Token(Token = "0x6000751")]
		[Address(RVA = "0xD6D4AC", Offset = "0xD6D4AC", VA = "0xD6D4AC")]
		public ParameterDescriptor(string name, Type type, bool hasDefaultValue, object defaultValue, bool isOut, bool isRef, bool isVarArgs, Type typeRestriction)
		{
		}

		[Token(Token = "0x6000752")]
		[Address(RVA = "0xD6D6F8", Offset = "0xD6D6F8", VA = "0xD6D6F8")]
		public ParameterDescriptor(ParameterInfo pi)
		{
		}

		[Token(Token = "0x6000753")]
		[Address(RVA = "0xD6D908", Offset = "0xD6D908", VA = "0xD6D908", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000754")]
		[Address(RVA = "0xD6D5A8", Offset = "0xD6D5A8", VA = "0xD6D5A8")]
		public void RestrictType(Type type)
		{
		}

		[Token(Token = "0x6000755")]
		[Address(RVA = "0xD6D9B4", Offset = "0xD6D9B4", VA = "0xD6D9B4", Slot = "4")]
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
		[Address(RVA = "0xD6DCE0", Offset = "0xD6DCE0", VA = "0xD6DCE0")]
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
		[Address(RVA = "0xD6DD80", Offset = "0xD6DD80", VA = "0xD6DD80")]
		public void PushFunction(IClosureBuilder closureBuilder, bool hasVarArgs)
		{
		}

		[Token(Token = "0x6000759")]
		[Address(RVA = "0xD6DEDC", Offset = "0xD6DEDC", VA = "0xD6DEDC")]
		public void PushBlock()
		{
		}

		[Token(Token = "0x600075A")]
		[Address(RVA = "0xD6DF34", Offset = "0xD6DF34", VA = "0xD6DF34")]
		public RuntimeScopeBlock PopBlock()
		{
			return null;
		}

		[Token(Token = "0x600075B")]
		[Address(RVA = "0xD6DF8C", Offset = "0xD6DF8C", VA = "0xD6DF8C")]
		public RuntimeScopeFrame PopFunction()
		{
			return null;
		}

		[Token(Token = "0x600075C")]
		[Address(RVA = "0xD6E064", Offset = "0xD6E064", VA = "0xD6E064")]
		public SymbolRef Find(string name)
		{
			return null;
		}

		[Token(Token = "0x600075D")]
		[Address(RVA = "0xD6E2E8", Offset = "0xD6E2E8", VA = "0xD6E2E8")]
		public SymbolRef CreateGlobalReference(string name)
		{
			return null;
		}

		[Token(Token = "0x600075E")]
		[Address(RVA = "0xD6E3D8", Offset = "0xD6E3D8", VA = "0xD6E3D8")]
		public void ForceEnvUpValue()
		{
		}

		[Token(Token = "0x600075F")]
		[Address(RVA = "0xD6E180", Offset = "0xD6E180", VA = "0xD6E180")]
		private SymbolRef CreateUpValue(BuildTimeScope buildTimeScope, SymbolRef symb, int closuredFrame, int currentFrame)
		{
			return null;
		}

		[Token(Token = "0x6000760")]
		[Address(RVA = "0xD6E420", Offset = "0xD6E420", VA = "0xD6E420")]
		public SymbolRef DefineLocal(string name)
		{
			return null;
		}

		[Token(Token = "0x6000761")]
		[Address(RVA = "0xD6E488", Offset = "0xD6E488", VA = "0xD6E488")]
		public SymbolRef TryDefineLocal(string name)
		{
			return null;
		}

		[Token(Token = "0x6000762")]
		[Address(RVA = "0xD6E4F0", Offset = "0xD6E4F0", VA = "0xD6E4F0")]
		public bool CurrentFunctionHasVarArgs()
		{
			return default(bool);
		}

		[Token(Token = "0x6000763")]
		[Address(RVA = "0xD6E548", Offset = "0xD6E548", VA = "0xD6E548")]
		internal void DefineLabel(LabelStatement label)
		{
		}

		[Token(Token = "0x6000764")]
		[Address(RVA = "0xD6E5B0", Offset = "0xD6E5B0", VA = "0xD6E5B0")]
		internal void RegisterGoto(GotoStatement gotostat)
		{
		}

		[Token(Token = "0x6000765")]
		[Address(RVA = "0xD6E618", Offset = "0xD6E618", VA = "0xD6E618")]
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
			[Address(RVA = "0xD6E6D8", Offset = "0xD6E6D8", VA = "0xD6E6D8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000767")]
			[Address(RVA = "0xD6E6E0", Offset = "0xD6E6E0", VA = "0xD6E6E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000768")]
		[Address(RVA = "0xD6E6E8", Offset = "0xD6E6E8", VA = "0xD6E6E8")]
		internal ClosureContext(SymbolRef[] symbols, IEnumerable<DynValue> values)
		{
		}

		[Token(Token = "0x6000769")]
		[Address(RVA = "0xD6E88C", Offset = "0xD6E88C", VA = "0xD6E88C")]
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
		[Address(RVA = "0xD6E9A4", Offset = "0xD6E9A4", VA = "0xD6E9A4")]
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
			[Address(RVA = "0xD6EA24", Offset = "0xD6EA24", VA = "0xD6EA24")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000772")]
			[Address(RVA = "0xD6EA2C", Offset = "0xD6EA2C", VA = "0xD6EA2C")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Token(Token = "0x17000122")]
		public int To
		{
			[Token(Token = "0x6000773")]
			[Address(RVA = "0xD6EA34", Offset = "0xD6EA34", VA = "0xD6EA34")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000774")]
			[Address(RVA = "0xD6EA3C", Offset = "0xD6EA3C", VA = "0xD6EA3C")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Token(Token = "0x17000123")]
		public int ToInclusive
		{
			[Token(Token = "0x6000775")]
			[Address(RVA = "0xD6EA44", Offset = "0xD6EA44", VA = "0xD6EA44")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000776")]
			[Address(RVA = "0xD6EA4C", Offset = "0xD6EA4C", VA = "0xD6EA4C")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Token(Token = "0x6000777")]
		[Address(RVA = "0xD6EA54", Offset = "0xD6EA54", VA = "0xD6EA54", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000778")]
		[Address(RVA = "0xD6EB18", Offset = "0xD6EB18", VA = "0xD6EB18")]
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
			[Address(RVA = "0xD6EB20", Offset = "0xD6EB20", VA = "0xD6EB20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600077A")]
			[Address(RVA = "0xD6EB28", Offset = "0xD6EB28", VA = "0xD6EB28")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000125")]
		public int Count
		{
			[Token(Token = "0x600077B")]
			[Address(RVA = "0xD6EB30", Offset = "0xD6EB30", VA = "0xD6EB30")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000126")]
		public int ToFirstBlock
		{
			[Token(Token = "0x600077C")]
			[Address(RVA = "0xD6EB78", Offset = "0xD6EB78", VA = "0xD6EB78")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600077D")]
			[Address(RVA = "0xD6EB80", Offset = "0xD6EB80", VA = "0xD6EB80")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Token(Token = "0x600077E")]
		[Address(RVA = "0xD6EB88", Offset = "0xD6EB88", VA = "0xD6EB88")]
		public RuntimeScopeFrame()
		{
		}

		[Token(Token = "0x600077F")]
		[Address(RVA = "0xD6EC08", Offset = "0xD6EC08", VA = "0xD6EC08", Slot = "3")]
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
			[Address(RVA = "0xD6EC94", Offset = "0xD6EC94", VA = "0xD6EC94")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000781")]
			[Address(RVA = "0xD6EC9C", Offset = "0xD6EC9C", VA = "0xD6EC9C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000128")]
		public BuildTimeScope Scope
		{
			[Token(Token = "0x6000782")]
			[Address(RVA = "0xD6ECA4", Offset = "0xD6ECA4", VA = "0xD6ECA4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000783")]
			[Address(RVA = "0xD6ECAC", Offset = "0xD6ECAC", VA = "0xD6ECAC")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000129")]
		public SourceCode Source
		{
			[Token(Token = "0x6000784")]
			[Address(RVA = "0xD6ECB4", Offset = "0xD6ECB4", VA = "0xD6ECB4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000785")]
			[Address(RVA = "0xD6ECBC", Offset = "0xD6ECBC", VA = "0xD6ECBC")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700012A")]
		public bool Anonymous
		{
			[Token(Token = "0x6000786")]
			[Address(RVA = "0xD6ECC4", Offset = "0xD6ECC4", VA = "0xD6ECC4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000787")]
			[Address(RVA = "0xD6ECCC", Offset = "0xD6ECCC", VA = "0xD6ECCC")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700012B")]
		public bool IsDynamicExpression
		{
			[Token(Token = "0x6000788")]
			[Address(RVA = "0xD6ECD8", Offset = "0xD6ECD8", VA = "0xD6ECD8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000789")]
			[Address(RVA = "0xD6ECE0", Offset = "0xD6ECE0", VA = "0xD6ECE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700012C")]
		public Lexer Lexer
		{
			[Token(Token = "0x600078A")]
			[Address(RVA = "0xD6ECEC", Offset = "0xD6ECEC", VA = "0xD6ECEC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600078B")]
			[Address(RVA = "0xD6ECF4", Offset = "0xD6ECF4", VA = "0xD6ECF4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x600078C")]
		[Address(RVA = "0xD6ECFC", Offset = "0xD6ECFC", VA = "0xD6ECFC")]
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
			[Address(RVA = "0xD6EEA4", Offset = "0xD6EEA4", VA = "0xD6EEA4")]
			public SourceCodeStackGuard(SourceRef sref, ByteCode bc)
			{
			}

			[Token(Token = "0x60007BB")]
			[Address(RVA = "0xD70974", Offset = "0xD70974", VA = "0xD70974", Slot = "4")]
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
			[Address(RVA = "0xD6ED24", Offset = "0xD6ED24", VA = "0xD6ED24")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600078E")]
			[Address(RVA = "0xD6ED2C", Offset = "0xD6ED2C", VA = "0xD6ED2C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600078F")]
		[Address(RVA = "0xD6ED34", Offset = "0xD6ED34", VA = "0xD6ED34")]
		public ByteCode(Script script)
		{
		}

		[Token(Token = "0x6000790")]
		[Address(RVA = "0xD6EE34", Offset = "0xD6EE34", VA = "0xD6EE34")]
		public IDisposable EnterSource(SourceRef sref)
		{
			return null;
		}

		[Token(Token = "0x6000791")]
		[Address(RVA = "0xD6EEE0", Offset = "0xD6EEE0", VA = "0xD6EEE0")]
		public void PushSourceRef(SourceRef sref)
		{
		}

		[Token(Token = "0x6000792")]
		[Address(RVA = "0xD6EF88", Offset = "0xD6EF88", VA = "0xD6EF88")]
		public void PopSourceRef()
		{
		}

		[Token(Token = "0x6000793")]
		[Address(RVA = "0xD6F02C", Offset = "0xD6F02C", VA = "0xD6F02C")]
		public void Dump(string file)
		{
		}

		[Token(Token = "0x6000794")]
		[Address(RVA = "0xD6F1D8", Offset = "0xD6F1D8", VA = "0xD6F1D8")]
		public int GetJumpPointForNextInstruction()
		{
			return default(int);
		}

		[Token(Token = "0x6000795")]
		[Address(RVA = "0xD6F220", Offset = "0xD6F220", VA = "0xD6F220")]
		public int GetJumpPointForLastInstruction()
		{
			return default(int);
		}

		[Token(Token = "0x6000796")]
		[Address(RVA = "0xD6F26C", Offset = "0xD6F26C", VA = "0xD6F26C")]
		public Instruction GetLastInstruction()
		{
			return null;
		}

		[Token(Token = "0x6000797")]
		[Address(RVA = "0xD6F2D0", Offset = "0xD6F2D0", VA = "0xD6F2D0")]
		private Instruction AppendInstruction(Instruction c)
		{
			return null;
		}

		[Token(Token = "0x6000798")]
		[Address(RVA = "0xD6F378", Offset = "0xD6F378", VA = "0xD6F378")]
		public Instruction Emit_Nop(string comment)
		{
			return null;
		}

		[Token(Token = "0x6000799")]
		[Address(RVA = "0xD6F420", Offset = "0xD6F420", VA = "0xD6F420")]
		public Instruction Emit_Invalid(string type)
		{
			return null;
		}

		[Token(Token = "0x600079A")]
		[Address(RVA = "0xD6F4A4", Offset = "0xD6F4A4", VA = "0xD6F4A4")]
		public Instruction Emit_Pop(int num = 1)
		{
			return null;
		}

		[Token(Token = "0x600079B")]
		[Address(RVA = "0xD6F528", Offset = "0xD6F528", VA = "0xD6F528")]
		public void Emit_Call(int argCount, string debugName)
		{
		}

		[Token(Token = "0x600079C")]
		[Address(RVA = "0xD6F5B4", Offset = "0xD6F5B4", VA = "0xD6F5B4")]
		public void Emit_ThisCall(int argCount, string debugName)
		{
		}

		[Token(Token = "0x600079D")]
		[Address(RVA = "0xD6F640", Offset = "0xD6F640", VA = "0xD6F640")]
		public Instruction Emit_Literal(DynValue value)
		{
			return null;
		}

		[Token(Token = "0x600079E")]
		[Address(RVA = "0xD6F6C4", Offset = "0xD6F6C4", VA = "0xD6F6C4")]
		public Instruction Emit_Jump(OpCode jumpOpCode, int idx, int optPar = 0)
		{
			return null;
		}

		[Token(Token = "0x600079F")]
		[Address(RVA = "0xD6F754", Offset = "0xD6F754", VA = "0xD6F754")]
		public Instruction Emit_MkTuple(int cnt)
		{
			return null;
		}

		[Token(Token = "0x60007A0")]
		[Address(RVA = "0xD6F7D8", Offset = "0xD6F7D8", VA = "0xD6F7D8")]
		public Instruction Emit_Operator(OpCode opcode)
		{
			return null;
		}

		[Token(Token = "0x60007A1")]
		[Address(RVA = "0xD6F8C8", Offset = "0xD6F8C8", VA = "0xD6F8C8")]
		[Conditional("EMIT_DEBUG_OPS")]
		public void Emit_Debug(string str)
		{
		}

		[Token(Token = "0x60007A2")]
		[Address(RVA = "0xD6F99C", Offset = "0xD6F99C", VA = "0xD6F99C")]
		public Instruction Emit_Enter(RuntimeScopeBlock runtimeScopeBlock)
		{
			return null;
		}

		[Token(Token = "0x60007A3")]
		[Address(RVA = "0xD6FA30", Offset = "0xD6FA30", VA = "0xD6FA30")]
		public Instruction Emit_Leave(RuntimeScopeBlock runtimeScopeBlock)
		{
			return null;
		}

		[Token(Token = "0x60007A4")]
		[Address(RVA = "0xD6FABC", Offset = "0xD6FABC", VA = "0xD6FABC")]
		public Instruction Emit_Exit(RuntimeScopeBlock runtimeScopeBlock)
		{
			return null;
		}

		[Token(Token = "0x60007A5")]
		[Address(RVA = "0xD6FB50", Offset = "0xD6FB50", VA = "0xD6FB50")]
		public Instruction Emit_Clean(RuntimeScopeBlock runtimeScopeBlock)
		{
			return null;
		}

		[Token(Token = "0x60007A6")]
		[Address(RVA = "0xD6FBE8", Offset = "0xD6FBE8", VA = "0xD6FBE8")]
		public Instruction Emit_Closure(SymbolRef[] symbols, int jmpnum)
		{
			return null;
		}

		[Token(Token = "0x60007A7")]
		[Address(RVA = "0xD6FC74", Offset = "0xD6FC74", VA = "0xD6FC74")]
		public Instruction Emit_Args(params SymbolRef[] symbols)
		{
			return null;
		}

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0xD6FCF8", Offset = "0xD6FCF8", VA = "0xD6FCF8")]
		public Instruction Emit_Ret(int retvals)
		{
			return null;
		}

		[Token(Token = "0x60007A9")]
		[Address(RVA = "0xD6FD7C", Offset = "0xD6FD7C", VA = "0xD6FD7C")]
		public Instruction Emit_ToNum(int stage = 0)
		{
			return null;
		}

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0xD6FE00", Offset = "0xD6FE00", VA = "0xD6FE00")]
		public Instruction Emit_Incr(int i)
		{
			return null;
		}

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0xD6FE84", Offset = "0xD6FE84", VA = "0xD6FE84")]
		public Instruction Emit_NewTable(bool shared)
		{
			return null;
		}

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0xD6FF0C", Offset = "0xD6FF0C", VA = "0xD6FF0C")]
		public Instruction Emit_IterPrep()
		{
			return null;
		}

		[Token(Token = "0x60007AD")]
		[Address(RVA = "0xD6FF80", Offset = "0xD6FF80", VA = "0xD6FF80")]
		public Instruction Emit_ExpTuple(int stackOffset)
		{
			return null;
		}

		[Token(Token = "0x60007AE")]
		[Address(RVA = "0xD70004", Offset = "0xD70004", VA = "0xD70004")]
		public Instruction Emit_IterUpd()
		{
			return null;
		}

		[Token(Token = "0x60007AF")]
		[Address(RVA = "0xD70078", Offset = "0xD70078", VA = "0xD70078")]
		public Instruction Emit_Meta(string funcName, OpCodeMetadataType metaType, [Optional] DynValue value)
		{
			return null;
		}

		[Token(Token = "0x60007B0")]
		[Address(RVA = "0xD70110", Offset = "0xD70110", VA = "0xD70110")]
		public Instruction Emit_BeginFn(RuntimeScopeFrame stackFrame)
		{
			return null;
		}

		[Token(Token = "0x60007B1")]
		[Address(RVA = "0xD701D0", Offset = "0xD701D0", VA = "0xD701D0")]
		public Instruction Emit_Scalar()
		{
			return null;
		}

		[Token(Token = "0x60007B2")]
		[Address(RVA = "0xD70244", Offset = "0xD70244", VA = "0xD70244")]
		public int Emit_Load(SymbolRef sym)
		{
			return default(int);
		}

		[Token(Token = "0x60007B3")]
		[Address(RVA = "0xD70414", Offset = "0xD70414", VA = "0xD70414")]
		public int Emit_Store(SymbolRef sym, int stackofs, int tupleidx)
		{
			return default(int);
		}

		[Token(Token = "0x60007B4")]
		[Address(RVA = "0xD70600", Offset = "0xD70600", VA = "0xD70600")]
		public Instruction Emit_TblInitN()
		{
			return null;
		}

		[Token(Token = "0x60007B5")]
		[Address(RVA = "0xD70674", Offset = "0xD70674", VA = "0xD70674")]
		public Instruction Emit_TblInitI(bool lastpos)
		{
			return null;
		}

		[Token(Token = "0x60007B6")]
		[Address(RVA = "0xD706FC", Offset = "0xD706FC", VA = "0xD706FC")]
		public Instruction Emit_Index([Optional] DynValue index, bool isNameIndex = false, bool isExpList = false)
		{
			return null;
		}

		[Token(Token = "0x60007B7")]
		[Address(RVA = "0xD707A8", Offset = "0xD707A8", VA = "0xD707A8")]
		public Instruction Emit_IndexSet(int stackofs, int tupleidx, [Optional] DynValue index, bool isNameIndex = false, bool isExpList = false)
		{
			return null;
		}

		[Token(Token = "0x60007B8")]
		[Address(RVA = "0xD70868", Offset = "0xD70868", VA = "0xD70868")]
		public Instruction Emit_Copy(int numval)
		{
			return null;
		}

		[Token(Token = "0x60007B9")]
		[Address(RVA = "0xD708EC", Offset = "0xD708EC", VA = "0xD708EC")]
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
		[Address(RVA = "0xD7098C", Offset = "0xD7098C", VA = "0xD7098C")]
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
		[Address(RVA = "0xD70994", Offset = "0xD70994", VA = "0xD70994")]
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
		[Address(RVA = "0xD6F3F8", Offset = "0xD6F3F8", VA = "0xD6F3F8")]
		internal Instruction(SourceRef sourceref)
		{
		}

		[Token(Token = "0x60007BF")]
		[Address(RVA = "0xD70A64", Offset = "0xD70A64", VA = "0xD70A64", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0xD70E18", Offset = "0xD70E18", VA = "0xD70E18")]
		private string PurifyFromNewLines(DynValue Value)
		{
			return null;
		}

		[Token(Token = "0x60007C1")]
		[Address(RVA = "0xD70D8C", Offset = "0xD70D8C", VA = "0xD70D8C")]
		private string GenSpaces()
		{
			return null;
		}

		[Token(Token = "0x60007C2")]
		[Address(RVA = "0xD70EA4", Offset = "0xD70EA4", VA = "0xD70EA4")]
		internal void WriteBinary(BinaryWriter wr, int baseAddress, Dictionary<SymbolRef, int> symbolMap)
		{
		}

		[Token(Token = "0x60007C3")]
		[Address(RVA = "0xD711CC", Offset = "0xD711CC", VA = "0xD711CC")]
		private static void WriteSymbol(BinaryWriter wr, SymbolRef symbolRef, Dictionary<SymbolRef, int> symbolMap)
		{
		}

		[Token(Token = "0x60007C4")]
		[Address(RVA = "0xD71258", Offset = "0xD71258", VA = "0xD71258")]
		private static SymbolRef ReadSymbol(BinaryReader rd, SymbolRef[] deserializedSymbols)
		{
			return null;
		}

		[Token(Token = "0x60007C5")]
		[Address(RVA = "0xD712A8", Offset = "0xD712A8", VA = "0xD712A8")]
		internal static Instruction ReadBinary(SourceRef chunkRef, BinaryReader rd, int baseAddress, Table envTable, SymbolRef[] deserializedSymbols)
		{
			return null;
		}

		[Token(Token = "0x60007C6")]
		[Address(RVA = "0xD714BC", Offset = "0xD714BC", VA = "0xD714BC")]
		private static DynValue ReadValue(BinaryReader rd, Table envTable)
		{
			return null;
		}

		[Token(Token = "0x60007C7")]
		[Address(RVA = "0xD71054", Offset = "0xD71054", VA = "0xD71054")]
		private void DumpValue(BinaryWriter wr, DynValue value)
		{
		}

		[Token(Token = "0x60007C8")]
		[Address(RVA = "0xD71738", Offset = "0xD71738", VA = "0xD71738")]
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
			[Address(RVA = "0xD7E6D0", Offset = "0xD7E6D0", VA = "0xD7E6D0")]
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
			[Address(RVA = "0xD74CD4", Offset = "0xD74CD4", VA = "0xD74CD4")]
			get
			{
				return default(CoroutineState);
			}
		}

		[Token(Token = "0x1700012F")]
		public Coroutine AssociatedCoroutine
		{
			[Token(Token = "0x60007DA")]
			[Address(RVA = "0xD74CDC", Offset = "0xD74CDC", VA = "0xD74CDC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60007DB")]
			[Address(RVA = "0xD74CE4", Offset = "0xD74CE4", VA = "0xD74CE4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000130")]
		internal bool DebuggerEnabled
		{
			[Token(Token = "0x60007DF")]
			[Address(RVA = "0xD7516C", Offset = "0xD7516C", VA = "0xD7516C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007E0")]
			[Address(RVA = "0xD75188", Offset = "0xD75188", VA = "0xD75188")]
			set
			{
			}
		}

		[Token(Token = "0x60007CC")]
		[Address(RVA = "0xD7180C", Offset = "0xD7180C", VA = "0xD7180C")]
		public Processor(Script script, Table globalContext, ByteCode byteCode)
		{
		}

		[Token(Token = "0x60007CD")]
		[Address(RVA = "0xD719E4", Offset = "0xD719E4", VA = "0xD719E4")]
		private Processor(Processor parentProcessor)
		{
		}

		[Token(Token = "0x60007CE")]
		[Address(RVA = "0xD71AF4", Offset = "0xD71AF4", VA = "0xD71AF4")]
		public DynValue Call(DynValue function, DynValue[] args)
		{
			return null;
		}

		[Token(Token = "0x60007CF")]
		[Address(RVA = "0xD71F50", Offset = "0xD71F50", VA = "0xD71F50")]
		private int PushClrToScriptStackFrame(CallStackItemFlags flags, DynValue function, DynValue[] args)
		{
			return default(int);
		}

		[Token(Token = "0x60007D0")]
		[Address(RVA = "0xD73910", Offset = "0xD73910", VA = "0xD73910")]
		private void LeaveProcessor()
		{
		}

		[Token(Token = "0x60007D1")]
		[Address(RVA = "0xD73A28", Offset = "0xD73A28", VA = "0xD73A28")]
		private int GetThreadId()
		{
			return default(int);
		}

		[Token(Token = "0x60007D2")]
		[Address(RVA = "0xD71DC4", Offset = "0xD71DC4", VA = "0xD71DC4")]
		private void EnterProcessor()
		{
		}

		[Token(Token = "0x60007D3")]
		[Address(RVA = "0xD73A48", Offset = "0xD73A48", VA = "0xD73A48")]
		internal SourceRef GetCoroutineSuspendedLocation()
		{
			return null;
		}

		[Token(Token = "0x60007D4")]
		[Address(RVA = "0xD73AE0", Offset = "0xD73AE0", VA = "0xD73AE0")]
		internal static bool IsDumpStream(Stream stream)
		{
			return default(bool);
		}

		[Token(Token = "0x60007D5")]
		[Address(RVA = "0xD73D00", Offset = "0xD73D00", VA = "0xD73D00")]
		internal int Dump(Stream stream, int baseAddress, bool hasUpvalues)
		{
			return default(int);
		}

		[Token(Token = "0x60007D6")]
		[Address(RVA = "0xD745AC", Offset = "0xD745AC", VA = "0xD745AC")]
		private void AddSymbolToMap(Dictionary<SymbolRef, int> symbolMap, SymbolRef s)
		{
		}

		[Token(Token = "0x60007D7")]
		[Address(RVA = "0xD7465C", Offset = "0xD7465C", VA = "0xD7465C")]
		internal int Undump(Stream stream, int sourceID, Table envTable, out bool hasUpvalues)
		{
			return default(int);
		}

		[Token(Token = "0x60007D8")]
		[Address(RVA = "0xD74BD8", Offset = "0xD74BD8", VA = "0xD74BD8")]
		public DynValue Coroutine_Create(Closure closure)
		{
			return null;
		}

		[Token(Token = "0x60007DC")]
		[Address(RVA = "0xD74CEC", Offset = "0xD74CEC", VA = "0xD74CEC")]
		public DynValue Coroutine_Resume(DynValue[] args)
		{
			return null;
		}

		[Token(Token = "0x60007DD")]
		[Address(RVA = "0xD74518", Offset = "0xD74518", VA = "0xD74518")]
		internal Instruction FindMeta(ref int baseAddress)
		{
			return null;
		}

		[Token(Token = "0x60007DE")]
		[Address(RVA = "0xD75010", Offset = "0xD75010", VA = "0xD75010")]
		internal void AttachDebugger(IDebugger debugger)
		{
		}

		[Token(Token = "0x60007E1")]
		[Address(RVA = "0xD751A8", Offset = "0xD751A8", VA = "0xD751A8")]
		private void ListenDebugger(Instruction instr, int instructionPtr)
		{
		}

		[Token(Token = "0x60007E2")]
		[Address(RVA = "0xD75ED0", Offset = "0xD75ED0", VA = "0xD75ED0")]
		private void ResetBreakPoints(DebuggerAction action)
		{
		}

		[Token(Token = "0x60007E3")]
		[Address(RVA = "0xD75F74", Offset = "0xD75F74", VA = "0xD75F74")]
		internal HashSet<int> ResetBreakPoints(SourceCode src, HashSet<int> lines)
		{
			return null;
		}

		[Token(Token = "0x60007E4")]
		[Address(RVA = "0xD75A18", Offset = "0xD75A18", VA = "0xD75A18")]
		private bool ToggleBreakPoint(DebuggerAction action, bool? state)
		{
			return default(bool);
		}

		[Token(Token = "0x60007E5")]
		[Address(RVA = "0xD755DC", Offset = "0xD755DC", VA = "0xD755DC")]
		private void RefreshDebugger(bool hard, int instructionPtr)
		{
		}

		[Token(Token = "0x60007E6")]
		[Address(RVA = "0xD768E8", Offset = "0xD768E8", VA = "0xD768E8")]
		private List<WatchItem> Debugger_RefreshThreads(ScriptExecutionContext context)
		{
			return null;
		}

		[Token(Token = "0x60007E7")]
		[Address(RVA = "0xD76528", Offset = "0xD76528", VA = "0xD76528")]
		private List<WatchItem> Debugger_RefreshVStack()
		{
			return null;
		}

		[Token(Token = "0x60007E8")]
		[Address(RVA = "0xD76434", Offset = "0xD76434", VA = "0xD76434")]
		private List<WatchItem> Debugger_RefreshWatches(ScriptExecutionContext context, List<DynamicExpression> watchList)
		{
			return null;
		}

		[Token(Token = "0x60007E9")]
		[Address(RVA = "0xD766E0", Offset = "0xD766E0", VA = "0xD766E0")]
		private List<WatchItem> Debugger_RefreshLocals(ScriptExecutionContext context)
		{
			return null;
		}

		[Token(Token = "0x60007EA")]
		[Address(RVA = "0xD76A0C", Offset = "0xD76A0C", VA = "0xD76A0C")]
		private WatchItem Debugger_RefreshWatch(ScriptExecutionContext context, DynamicExpression dynExpr)
		{
			return null;
		}

		[Token(Token = "0x60007EB")]
		[Address(RVA = "0xD76180", Offset = "0xD76180", VA = "0xD76180")]
		internal List<WatchItem> Debugger_GetCallStack(SourceRef startingRef)
		{
			return null;
		}

		[Token(Token = "0x60007EC")]
		[Address(RVA = "0xD73A50", Offset = "0xD73A50", VA = "0xD73A50")]
		private SourceRef GetCurrentSourceRef(int instructionPtr)
		{
			return null;
		}

		[Token(Token = "0x60007ED")]
		[Address(RVA = "0xD76BBC", Offset = "0xD76BBC", VA = "0xD76BBC")]
		private void FillDebugData(InterpreterException ex, int ip)
		{
		}

		[Token(Token = "0x60007EE")]
		[Address(RVA = "0xD76C3C", Offset = "0xD76C3C", VA = "0xD76C3C")]
		internal Table GetMetatable(DynValue value)
		{
			return null;
		}

		[Token(Token = "0x60007EF")]
		[Address(RVA = "0xD76CB4", Offset = "0xD76CB4", VA = "0xD76CB4")]
		internal DynValue GetBinaryMetamethod(DynValue op1, DynValue op2, string eventName)
		{
			return null;
		}

		[Token(Token = "0x60007F0")]
		[Address(RVA = "0xD76EDC", Offset = "0xD76EDC", VA = "0xD76EDC")]
		internal DynValue GetMetamethod(DynValue value, string metamethod)
		{
			return null;
		}

		[Token(Token = "0x60007F1")]
		[Address(RVA = "0xD77004", Offset = "0xD77004", VA = "0xD77004")]
		internal DynValue GetMetamethodRaw(DynValue value, string metamethod)
		{
			return null;
		}

		[Token(Token = "0x60007F2")]
		[Address(RVA = "0xD77048", Offset = "0xD77048", VA = "0xD77048")]
		internal Script GetScript()
		{
			return null;
		}

		[Token(Token = "0x60007F3")]
		[Address(RVA = "0xD72178", Offset = "0xD72178", VA = "0xD72178")]
		private DynValue Processing_Loop(int instructionPtr)
		{
			return null;
		}

		[Token(Token = "0x60007F4")]
		[Address(RVA = "0xD7B98C", Offset = "0xD7B98C", VA = "0xD7B98C")]
		internal string PerformMessageDecorationBeforeUnwind(DynValue messageHandler, string decoratedMessage, SourceRef sourceRef)
		{
			return null;
		}

		[Token(Token = "0x60007F5")]
		[Address(RVA = "0xD7BD20", Offset = "0xD7BD20", VA = "0xD7BD20")]
		private void AssignLocal(SymbolRef symref, DynValue value)
		{
		}

		[Token(Token = "0x60007F6")]
		[Address(RVA = "0xD7ADF8", Offset = "0xD7ADF8", VA = "0xD7ADF8")]
		private void ExecStoreLcl(Instruction i)
		{
		}

		[Token(Token = "0x60007F7")]
		[Address(RVA = "0xD7ACCC", Offset = "0xD7ACCC", VA = "0xD7ACCC")]
		private void ExecStoreUpv(Instruction i)
		{
		}

		[Token(Token = "0x60007F8")]
		[Address(RVA = "0xD77050", Offset = "0xD77050", VA = "0xD77050")]
		private void ExecSwap(Instruction i)
		{
		}

		[Token(Token = "0x60007F9")]
		[Address(RVA = "0xD7BE2C", Offset = "0xD7BE2C", VA = "0xD7BE2C")]
		private DynValue GetStoreValue(Instruction i)
		{
			return null;
		}

		[Token(Token = "0x60007FA")]
		[Address(RVA = "0xD795F8", Offset = "0xD795F8", VA = "0xD795F8")]
		private void ExecClosure(Instruction i)
		{
		}

		[Token(Token = "0x60007FB")]
		[Address(RVA = "0xD7BF28", Offset = "0xD7BF28", VA = "0xD7BF28")]
		private DynValue GetUpvalueSymbol(SymbolRef s)
		{
			return null;
		}

		[Token(Token = "0x60007FC")]
		[Address(RVA = "0xD7941C", Offset = "0xD7941C", VA = "0xD7941C")]
		private void ExecMkTuple(Instruction i)
		{
		}

		[Token(Token = "0x60007FD")]
		[Address(RVA = "0xD7A0B8", Offset = "0xD7A0B8", VA = "0xD7A0B8")]
		private void ExecToNum(Instruction i)
		{
		}

		[Token(Token = "0x60007FE")]
		[Address(RVA = "0xD7AAEC", Offset = "0xD7AAEC", VA = "0xD7AAEC")]
		private void ExecIterUpd(Instruction i)
		{
		}

		[Token(Token = "0x60007FF")]
		[Address(RVA = "0xD7ABAC", Offset = "0xD7ABAC", VA = "0xD7ABAC")]
		private void ExecExpTuple(Instruction i)
		{
		}

		[Token(Token = "0x6000800")]
		[Address(RVA = "0xD7A2E0", Offset = "0xD7A2E0", VA = "0xD7A2E0")]
		private void ExecIterPrep(Instruction i)
		{
		}

		[Token(Token = "0x6000801")]
		[Address(RVA = "0xD7A204", Offset = "0xD7A204", VA = "0xD7A204")]
		private int ExecJFor(Instruction i, int instructionPtr)
		{
			return default(int);
		}

		[Token(Token = "0x6000802")]
		[Address(RVA = "0xD79FA8", Offset = "0xD79FA8", VA = "0xD79FA8")]
		private void ExecIncr(Instruction i)
		{
		}

		[Token(Token = "0x6000803")]
		[Address(RVA = "0xD79140", Offset = "0xD79140", VA = "0xD79140")]
		private void ExecCNot(Instruction i)
		{
		}

		[Token(Token = "0x6000804")]
		[Address(RVA = "0xD79070", Offset = "0xD79070", VA = "0xD79070")]
		private void ExecNot(Instruction i)
		{
		}

		[Token(Token = "0x6000805")]
		[Address(RVA = "0xD79778", Offset = "0xD79778", VA = "0xD79778")]
		private void ExecBeginFn(Instruction i)
		{
		}

		[Token(Token = "0x6000806")]
		[Address(RVA = "0xD7BC94", Offset = "0xD7BC94", VA = "0xD7BC94")]
		private CallStackItem PopToBasePointer()
		{
			return null;
		}

		[Token(Token = "0x6000807")]
		[Address(RVA = "0xD7C054", Offset = "0xD7C054", VA = "0xD7C054")]
		private int PopExecStackAndCheckVStack(int vstackguard)
		{
			return default(int);
		}

		[Token(Token = "0x6000808")]
		[Address(RVA = "0xD7C10C", Offset = "0xD7C10C", VA = "0xD7C10C")]
		private IList<DynValue> CreateArgsListForFunctionCall(int numargs, int offsFromTop)
		{
			return null;
		}

		[Token(Token = "0x6000809")]
		[Address(RVA = "0xD79814", Offset = "0xD79814", VA = "0xD79814")]
		private void ExecArgs(Instruction I)
		{
		}

		[Token(Token = "0x600080A")]
		[Address(RVA = "0xD789F4", Offset = "0xD789F4", VA = "0xD789F4")]
		private int Internal_ExecCall(int argsCount, int instructionPtr, [Optional] CallbackFunction handler, [Optional] CallbackFunction continuation, bool thisCall = false, [Optional] string debugText, [Optional] DynValue unwindHandler)
		{
			return default(int);
		}

		[Token(Token = "0x600080B")]
		[Address(RVA = "0xD7C3D8", Offset = "0xD7C3D8", VA = "0xD7C3D8")]
		private int PerformTCO(int instructionPtr, int argsCount)
		{
			return default(int);
		}

		[Token(Token = "0x600080C")]
		[Address(RVA = "0xD79C70", Offset = "0xD79C70", VA = "0xD79C70")]
		private int ExecRet(Instruction i)
		{
			return default(int);
		}

		[Token(Token = "0x600080D")]
		[Address(RVA = "0xD7C57C", Offset = "0xD7C57C", VA = "0xD7C57C")]
		private int Internal_CheckForTailRequests(Instruction i, int instructionPtr)
		{
			return default(int);
		}

		[Token(Token = "0x600080E")]
		[Address(RVA = "0xD79388", Offset = "0xD79388", VA = "0xD79388")]
		private int JumpBool(Instruction i, bool expectedValueForJump, int instructionPtr)
		{
			return default(int);
		}

		[Token(Token = "0x600080F")]
		[Address(RVA = "0xD792C0", Offset = "0xD792C0", VA = "0xD792C0")]
		private int ExecShortCircuitingOperator(Instruction i, int instructionPtr)
		{
			return default(int);
		}

		[Token(Token = "0x6000810")]
		[Address(RVA = "0xD77118", Offset = "0xD77118", VA = "0xD77118")]
		private int ExecAdd(Instruction i, int instructionPtr)
		{
			return default(int);
		}

		[Token(Token = "0x6000811")]
		[Address(RVA = "0xD77628", Offset = "0xD77628", VA = "0xD77628")]
		private int ExecSub(Instruction i, int instructionPtr)
		{
			return default(int);
		}

		[Token(Token = "0x6000812")]
		[Address(RVA = "0xD77818", Offset = "0xD77818", VA = "0xD77818")]
		private int ExecMul(Instruction i, int instructionPtr)
		{
			return default(int);
		}

		[Token(Token = "0x6000813")]
		[Address(RVA = "0xD77BF8", Offset = "0xD77BF8", VA = "0xD77BF8")]
		private int ExecMod(Instruction i, int instructionPtr)
		{
			return default(int);
		}

		[Token(Token = "0x6000814")]
		[Address(RVA = "0xD77A08", Offset = "0xD77A08", VA = "0xD77A08")]
		private int ExecDiv(Instruction i, int instructionPtr)
		{
			return default(int);
		}

		[Token(Token = "0x6000815")]
		[Address(RVA = "0xD77E38", Offset = "0xD77E38", VA = "0xD77E38")]
		private int ExecPower(Instruction i, int instructionPtr)
		{
			return default(int);
		}

		[Token(Token = "0x6000816")]
		[Address(RVA = "0xD774A4", Offset = "0xD774A4", VA = "0xD774A4")]
		private int ExecNeg(Instruction i, int instructionPtr)
		{
			return default(int);
		}

		[Token(Token = "0x6000817")]
		[Address(RVA = "0xD78060", Offset = "0xD78060", VA = "0xD78060")]
		private int ExecEq(Instruction i, int instructionPtr)
		{
			return default(int);
		}

		[Token(Token = "0x6000818")]
		[Address(RVA = "0xD78678", Offset = "0xD78678", VA = "0xD78678")]
		private int ExecLess(Instruction i, int instructionPtr)
		{
			return default(int);
		}

		[Token(Token = "0x6000819")]
		[Address(RVA = "0xD78318", Offset = "0xD78318", VA = "0xD78318")]
		private int ExecLessEq(Instruction i, int instructionPtr)
		{
			return default(int);
		}

		[Token(Token = "0x600081A")]
		[Address(RVA = "0xD78874", Offset = "0xD78874", VA = "0xD78874")]
		private int ExecLen(Instruction i, int instructionPtr)
		{
			return default(int);
		}

		[Token(Token = "0x600081B")]
		[Address(RVA = "0xD77308", Offset = "0xD77308", VA = "0xD77308")]
		private int ExecConcat(Instruction i, int instructionPtr)
		{
			return default(int);
		}

		[Token(Token = "0x600081C")]
		[Address(RVA = "0xD7AF98", Offset = "0xD7AF98", VA = "0xD7AF98")]
		private void ExecTblInitI(Instruction i)
		{
		}

		[Token(Token = "0x600081D")]
		[Address(RVA = "0xD7AE2C", Offset = "0xD7AE2C", VA = "0xD7AE2C")]
		private void ExecTblInitN(Instruction i)
		{
		}

		[Token(Token = "0x600081E")]
		[Address(RVA = "0xD7B56C", Offset = "0xD7B56C", VA = "0xD7B56C")]
		private int ExecIndexSet(Instruction i, int instructionPtr)
		{
			return default(int);
		}

		[Token(Token = "0x600081F")]
		[Address(RVA = "0xD7B0E4", Offset = "0xD7B0E4", VA = "0xD7B0E4")]
		private int ExecIndex(Instruction i, int instructionPtr)
		{
			return default(int);
		}

		[Token(Token = "0x6000820")]
		[Address(RVA = "0xD79564", Offset = "0xD79564", VA = "0xD79564")]
		private void ClearBlockData(Instruction I)
		{
		}

		[Token(Token = "0x6000821")]
		[Address(RVA = "0xD7C994", Offset = "0xD7C994", VA = "0xD7C994")]
		public DynValue GetGenericSymbol(SymbolRef symref)
		{
			return null;
		}

		[Token(Token = "0x6000822")]
		[Address(RVA = "0xD7CBB8", Offset = "0xD7CBB8", VA = "0xD7CBB8")]
		private DynValue GetGlobalSymbol(DynValue dynValue, string name)
		{
			return null;
		}

		[Token(Token = "0x6000823")]
		[Address(RVA = "0xD7CD18", Offset = "0xD7CD18", VA = "0xD7CD18")]
		private void SetGlobalSymbol(DynValue dynValue, string name, DynValue value)
		{
		}

		[Token(Token = "0x6000824")]
		[Address(RVA = "0xD7CE68", Offset = "0xD7CE68", VA = "0xD7CE68")]
		public void AssignGenericSymbol(SymbolRef symref, DynValue value)
		{
		}

		[Token(Token = "0x6000825")]
		[Address(RVA = "0xD7CC74", Offset = "0xD7CC74", VA = "0xD7CC74")]
		private CallStackItem GetTopNonClrFunction()
		{
			return null;
		}

		[Token(Token = "0x6000826")]
		[Address(RVA = "0xD7D178", Offset = "0xD7D178", VA = "0xD7D178")]
		public SymbolRef FindSymbolByName(string name)
		{
			return null;
		}

		[Token(Token = "0x6000827")]
		[Address(RVA = "0xD7314C", Offset = "0xD7314C", VA = "0xD7314C")]
		private DynValue[] Internal_AdjustTuple(IList<DynValue> values)
		{
			return null;
		}

		[Token(Token = "0x6000828")]
		[Address(RVA = "0xD7C7E4", Offset = "0xD7C7E4", VA = "0xD7C7E4")]
		private int Internal_InvokeUnaryMetaMethod(DynValue op1, string eventName, int instructionPtr)
		{
			return default(int);
		}

		[Token(Token = "0x6000829")]
		[Address(RVA = "0xD7C6D8", Offset = "0xD7C6D8", VA = "0xD7C6D8")]
		private int Internal_InvokeBinaryMetaMethod(DynValue l, DynValue r, string eventName, int instructionPtr, [Optional] DynValue extraPush)
		{
			return default(int);
		}

		[Token(Token = "0x600082A")]
		[Address(RVA = "0xD7D3B4", Offset = "0xD7D3B4", VA = "0xD7D3B4")]
		private DynValue[] StackTopToArray(int items, bool pop)
		{
			return null;
		}

		[Token(Token = "0x600082B")]
		[Address(RVA = "0xD7D544", Offset = "0xD7D544", VA = "0xD7D544")]
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
			[Address(RVA = "0xD7E8C8", Offset = "0xD7E8C8", VA = "0xD7E8C8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000834")]
			[Address(RVA = "0xD7E8D0", Offset = "0xD7E8D0", VA = "0xD7E8D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000132")]
		internal List<BuildTimeScopeBlock> ChildNodes
		{
			[Token(Token = "0x6000835")]
			[Address(RVA = "0xD7E8D8", Offset = "0xD7E8D8", VA = "0xD7E8D8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000836")]
			[Address(RVA = "0xD7E8E0", Offset = "0xD7E8E0", VA = "0xD7E8E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000133")]
		internal RuntimeScopeBlock ScopeBlock
		{
			[Token(Token = "0x6000837")]
			[Address(RVA = "0xD7E8E8", Offset = "0xD7E8E8", VA = "0xD7E8E8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000838")]
			[Address(RVA = "0xD7E8F0", Offset = "0xD7E8F0", VA = "0xD7E8F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000839")]
		[Address(RVA = "0xD7E8F8", Offset = "0xD7E8F8", VA = "0xD7E8F8")]
		internal void Rename(string name)
		{
		}

		[Token(Token = "0x600083A")]
		[Address(RVA = "0xD7EA28", Offset = "0xD7EA28", VA = "0xD7EA28")]
		internal BuildTimeScopeBlock(BuildTimeScopeBlock parent)
		{
		}

		[Token(Token = "0x600083B")]
		[Address(RVA = "0xD7EB2C", Offset = "0xD7EB2C", VA = "0xD7EB2C")]
		internal BuildTimeScopeBlock AddChild()
		{
			return null;
		}

		[Token(Token = "0x600083C")]
		[Address(RVA = "0xD7EBFC", Offset = "0xD7EBFC", VA = "0xD7EBFC")]
		internal SymbolRef Find(string name)
		{
			return null;
		}

		[Token(Token = "0x600083D")]
		[Address(RVA = "0xD7EC54", Offset = "0xD7EC54", VA = "0xD7EC54")]
		internal SymbolRef Define(string name)
		{
			return null;
		}

		[Token(Token = "0x600083E")]
		[Address(RVA = "0xD7ED00", Offset = "0xD7ED00", VA = "0xD7ED00")]
		internal int ResolveLRefs(BuildTimeScopeFrame buildTimeScopeFrame)
		{
			return default(int);
		}

		[Token(Token = "0x600083F")]
		[Address(RVA = "0xD7F280", Offset = "0xD7F280", VA = "0xD7F280")]
		internal void DefineLabel(LabelStatement label)
		{
		}

		[Token(Token = "0x6000840")]
		[Address(RVA = "0xD7F4D4", Offset = "0xD7F4D4", VA = "0xD7F4D4")]
		internal void RegisterGoto(GotoStatement gotostat)
		{
		}

		[Token(Token = "0x6000841")]
		[Address(RVA = "0xD7F5F8", Offset = "0xD7F5F8", VA = "0xD7F5F8")]
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
			[Address(RVA = "0xD7FAC0", Offset = "0xD7FAC0", VA = "0xD7FAC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000843")]
			[Address(RVA = "0xD7FAC8", Offset = "0xD7FAC8", VA = "0xD7FAC8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000844")]
		[Address(RVA = "0xD7FAD4", Offset = "0xD7FAD4", VA = "0xD7FAD4")]
		internal BuildTimeScopeFrame(bool hasVarArgs)
		{
		}

		[Token(Token = "0x6000845")]
		[Address(RVA = "0xD7FB84", Offset = "0xD7FB84", VA = "0xD7FB84")]
		internal void PushBlock()
		{
		}

		[Token(Token = "0x6000846")]
		[Address(RVA = "0xD7FBA8", Offset = "0xD7FBA8", VA = "0xD7FBA8")]
		internal RuntimeScopeBlock PopBlock()
		{
			return null;
		}

		[Token(Token = "0x6000847")]
		[Address(RVA = "0xD7FC38", Offset = "0xD7FC38", VA = "0xD7FC38")]
		internal RuntimeScopeFrame GetRuntimeFrameData()
		{
			return null;
		}

		[Token(Token = "0x6000848")]
		[Address(RVA = "0xD7FCBC", Offset = "0xD7FCBC", VA = "0xD7FCBC")]
		internal SymbolRef Find(string name)
		{
			return null;
		}

		[Token(Token = "0x6000849")]
		[Address(RVA = "0xD7FCF8", Offset = "0xD7FCF8", VA = "0xD7FCF8")]
		internal SymbolRef DefineLocal(string name)
		{
			return null;
		}

		[Token(Token = "0x600084A")]
		[Address(RVA = "0xD7FD10", Offset = "0xD7FD10", VA = "0xD7FD10")]
		internal SymbolRef TryDefineLocal(string name)
		{
			return null;
		}

		[Token(Token = "0x600084B")]
		[Address(RVA = "0xD7FD5C", Offset = "0xD7FD5C", VA = "0xD7FD5C")]
		internal void ResolveLRefs()
		{
		}

		[Token(Token = "0x600084C")]
		[Address(RVA = "0xD7F164", Offset = "0xD7F164", VA = "0xD7F164")]
		internal int AllocVar(SymbolRef var)
		{
			return default(int);
		}

		[Token(Token = "0x600084D")]
		[Address(RVA = "0xD7F230", Offset = "0xD7F230", VA = "0xD7F230")]
		internal int GetPosForNextVar()
		{
			return default(int);
		}

		[Token(Token = "0x600084E")]
		[Address(RVA = "0xD7FD88", Offset = "0xD7FD88", VA = "0xD7FD88")]
		internal void DefineLabel(LabelStatement label)
		{
		}

		[Token(Token = "0x600084F")]
		[Address(RVA = "0xD7FDA0", Offset = "0xD7FDA0", VA = "0xD7FDA0")]
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
			[Address(RVA = "0xD7FDB8", Offset = "0xD7FDB8", VA = "0xD7FDB8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000851")]
			[Address(RVA = "0xD7FDC0", Offset = "0xD7FDC0", VA = "0xD7FDC0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Token(Token = "0x17000136")]
		public long Counter
		{
			[Token(Token = "0x6000852")]
			[Address(RVA = "0xD7FDC8", Offset = "0xD7FDC8", VA = "0xD7FDC8")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Token(Token = "0x6000853")]
			[Address(RVA = "0xD7FDD0", Offset = "0xD7FDD0", VA = "0xD7FDD0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Token(Token = "0x17000137")]
		public int Instances
		{
			[Token(Token = "0x6000854")]
			[Address(RVA = "0xD7FDD8", Offset = "0xD7FDD8", VA = "0xD7FDD8")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000855")]
			[Address(RVA = "0xD7FDE0", Offset = "0xD7FDE0", VA = "0xD7FDE0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Token(Token = "0x17000138")]
		public bool Global
		{
			[Token(Token = "0x6000856")]
			[Address(RVA = "0xD7FDE8", Offset = "0xD7FDE8", VA = "0xD7FDE8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000857")]
			[Address(RVA = "0xD7FDF0", Offset = "0xD7FDF0", VA = "0xD7FDF0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Token(Token = "0x17000139")]
		public PerformanceCounterType Type
		{
			[Token(Token = "0x6000858")]
			[Address(RVA = "0xD7FDFC", Offset = "0xD7FDFC", VA = "0xD7FDFC")]
			[CompilerGenerated]
			get
			{
				return default(PerformanceCounterType);
			}
			[Token(Token = "0x6000859")]
			[Address(RVA = "0xD7FE04", Offset = "0xD7FE04", VA = "0xD7FE04")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Token(Token = "0x600085A")]
		[Address(RVA = "0xD7FE0C", Offset = "0xD7FE0C", VA = "0xD7FE0C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600085B")]
		[Address(RVA = "0xD80018", Offset = "0xD80018", VA = "0xD80018")]
		public static string PerformanceCounterTypeToString(PerformanceCounterType Type)
		{
			return null;
		}

		[Token(Token = "0x600085C")]
		[Address(RVA = "0xD8010C", Offset = "0xD8010C", VA = "0xD8010C")]
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
			[Address(RVA = "0xD80114", Offset = "0xD80114", VA = "0xD80114")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600085E")]
			[Address(RVA = "0xD8011C", Offset = "0xD8011C", VA = "0xD8011C")]
			set
			{
			}
		}

		[Token(Token = "0x600085F")]
		[Address(RVA = "0xD803E4", Offset = "0xD803E4", VA = "0xD803E4")]
		public PerformanceResult GetPerformanceCounterResult(PerformanceCounter pc)
		{
			return null;
		}

		[Token(Token = "0x6000860")]
		[Address(RVA = "0xD804B8", Offset = "0xD804B8", VA = "0xD804B8")]
		internal IDisposable StartStopwatch(PerformanceCounter pc)
		{
			return null;
		}

		[Token(Token = "0x6000861")]
		[Address(RVA = "0xD80588", Offset = "0xD80588", VA = "0xD80588")]
		internal static IDisposable StartGlobalStopwatch(PerformanceCounter pc)
		{
			return null;
		}

		[Token(Token = "0x6000862")]
		[Address(RVA = "0xD80680", Offset = "0xD80680", VA = "0xD80680")]
		public string GetPerformanceLog()
		{
			return null;
		}

		[Token(Token = "0x6000863")]
		[Address(RVA = "0xD80724", Offset = "0xD80724", VA = "0xD80724")]
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
		[Address(RVA = "0xD807E4", Offset = "0xD807E4", VA = "0xD807E4")]
		private DummyPerformanceStopwatch()
		{
		}

		[Token(Token = "0x6000866")]
		[Address(RVA = "0xD8087C", Offset = "0xD8087C", VA = "0xD8087C", Slot = "4")]
		public IDisposable Start()
		{
			return null;
		}

		[Token(Token = "0x6000867")]
		[Address(RVA = "0xD80880", Offset = "0xD80880", VA = "0xD80880", Slot = "5")]
		public PerformanceResult GetResult()
		{
			return null;
		}

		[Token(Token = "0x6000868")]
		[Address(RVA = "0xD80888", Offset = "0xD80888", VA = "0xD80888", Slot = "6")]
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
			[Address(RVA = "0xD80990", Offset = "0xD80990", VA = "0xD80990")]
			public GlobalPerformanceStopwatch_StopwatchObject(GlobalPerformanceStopwatch parent)
			{
			}

			[Token(Token = "0x600086F")]
			[Address(RVA = "0xD80AC4", Offset = "0xD80AC4", VA = "0xD80AC4", Slot = "4")]
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
		[Address(RVA = "0xD80340", Offset = "0xD80340", VA = "0xD80340")]
		public GlobalPerformanceStopwatch(PerformanceCounter perfcounter)
		{
		}

		[Token(Token = "0x600086B")]
		[Address(RVA = "0xD808EC", Offset = "0xD808EC", VA = "0xD808EC")]
		private void SignalStopwatchTerminated(Stopwatch sw)
		{
		}

		[Token(Token = "0x600086C")]
		[Address(RVA = "0xD80930", Offset = "0xD80930", VA = "0xD80930", Slot = "4")]
		public IDisposable Start()
		{
			return null;
		}

		[Token(Token = "0x600086D")]
		[Address(RVA = "0xD80A08", Offset = "0xD80A08", VA = "0xD80A08", Slot = "5")]
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
		[Address(RVA = "0xD80368", Offset = "0xD80368", VA = "0xD80368")]
		public PerformanceStopwatch(PerformanceCounter perfcounter)
		{
		}

		[Token(Token = "0x6000873")]
		[Address(RVA = "0xD80AF4", Offset = "0xD80AF4", VA = "0xD80AF4", Slot = "5")]
		public IDisposable Start()
		{
			return null;
		}

		[Token(Token = "0x6000874")]
		[Address(RVA = "0xD80B3C", Offset = "0xD80B3C", VA = "0xD80B3C", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000875")]
		[Address(RVA = "0xD80B70", Offset = "0xD80B70", VA = "0xD80B70", Slot = "6")]
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
			[Address(RVA = "0xD80C38", Offset = "0xD80C38", VA = "0xD80C38")]
			[CompilerGenerated]
			get
			{
				return default(ActionType);
			}
			[Token(Token = "0x6000877")]
			[Address(RVA = "0xD80C40", Offset = "0xD80C40", VA = "0xD80C40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700013C")]
		public DateTime TimeStampUTC
		{
			[Token(Token = "0x6000878")]
			[Address(RVA = "0xD80C48", Offset = "0xD80C48", VA = "0xD80C48")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x6000879")]
			[Address(RVA = "0xD80C50", Offset = "0xD80C50", VA = "0xD80C50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700013D")]
		public int SourceID
		{
			[Token(Token = "0x600087A")]
			[Address(RVA = "0xD80C58", Offset = "0xD80C58", VA = "0xD80C58")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600087B")]
			[Address(RVA = "0xD80C60", Offset = "0xD80C60", VA = "0xD80C60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700013E")]
		public int SourceLine
		{
			[Token(Token = "0x600087C")]
			[Address(RVA = "0xD80C68", Offset = "0xD80C68", VA = "0xD80C68")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600087D")]
			[Address(RVA = "0xD80C70", Offset = "0xD80C70", VA = "0xD80C70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700013F")]
		public int SourceCol
		{
			[Token(Token = "0x600087E")]
			[Address(RVA = "0xD80C78", Offset = "0xD80C78", VA = "0xD80C78")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600087F")]
			[Address(RVA = "0xD80C80", Offset = "0xD80C80", VA = "0xD80C80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000140")]
		public int[] Lines
		{
			[Token(Token = "0x6000880")]
			[Address(RVA = "0xD80C88", Offset = "0xD80C88", VA = "0xD80C88")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000881")]
			[Address(RVA = "0xD80C90", Offset = "0xD80C90", VA = "0xD80C90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000141")]
		public TimeSpan Age
		{
			[Token(Token = "0x6000883")]
			[Address(RVA = "0xD80D00", Offset = "0xD80D00", VA = "0xD80D00")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Token(Token = "0x6000882")]
		[Address(RVA = "0xD80C98", Offset = "0xD80C98", VA = "0xD80C98")]
		public DebuggerAction()
		{
		}

		[Token(Token = "0x6000884")]
		[Address(RVA = "0xD80D60", Offset = "0xD80D60", VA = "0xD80D60", Slot = "3")]
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
			[Address(RVA = "0xD80F7C", Offset = "0xD80F7C", VA = "0xD80F7C", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000887")]
			[Address(RVA = "0xD80F84", Offset = "0xD80F84", VA = "0xD80F84")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000885")]
		[Address(RVA = "0xD80F50", Offset = "0xD80F50", VA = "0xD80F50")]
		internal DebugService(Script script, Processor processor)
		{
		}

		[Token(Token = "0x6000888")]
		[Address(RVA = "0xD80F8C", Offset = "0xD80F8C", VA = "0xD80F8C")]
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
			[Address(RVA = "0xD80FA8", Offset = "0xD80FA8", VA = "0xD80FA8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000895")]
			[Address(RVA = "0xD80FB0", Offset = "0xD80FB0", VA = "0xD80FB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000144")]
		public string Code
		{
			[Token(Token = "0x6000896")]
			[Address(RVA = "0xD80FB8", Offset = "0xD80FB8", VA = "0xD80FB8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000897")]
			[Address(RVA = "0xD80FC0", Offset = "0xD80FC0", VA = "0xD80FC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000145")]
		public string[] Lines
		{
			[Token(Token = "0x6000898")]
			[Address(RVA = "0xD80FC8", Offset = "0xD80FC8", VA = "0xD80FC8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000899")]
			[Address(RVA = "0xD80FD0", Offset = "0xD80FD0", VA = "0xD80FD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000146")]
		public Script OwnerScript
		{
			[Token(Token = "0x600089A")]
			[Address(RVA = "0xD80FD8", Offset = "0xD80FD8", VA = "0xD80FD8", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600089B")]
			[Address(RVA = "0xD80FE0", Offset = "0xD80FE0", VA = "0xD80FE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000147")]
		public int SourceID
		{
			[Token(Token = "0x600089C")]
			[Address(RVA = "0xD80FE8", Offset = "0xD80FE8", VA = "0xD80FE8")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600089D")]
			[Address(RVA = "0xD80FF0", Offset = "0xD80FF0", VA = "0xD80FF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000148")]
		internal List<SourceRef> Refs
		{
			[Token(Token = "0x600089E")]
			[Address(RVA = "0xD80FF8", Offset = "0xD80FF8", VA = "0xD80FF8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600089F")]
			[Address(RVA = "0xD81000", Offset = "0xD81000", VA = "0xD81000")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60008A0")]
		[Address(RVA = "0xD81008", Offset = "0xD81008", VA = "0xD81008")]
		internal SourceCode(string name, string code, int sourceID, Script ownerScript)
		{
		}

		[Token(Token = "0x60008A1")]
		[Address(RVA = "0xD811E8", Offset = "0xD811E8", VA = "0xD811E8")]
		public string GetCodeSnippet(SourceRef sourceCodeRef)
		{
			return null;
		}

		[Token(Token = "0x60008A2")]
		[Address(RVA = "0xD81410", Offset = "0xD81410", VA = "0xD81410")]
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
			[Address(RVA = "0xD81488", Offset = "0xD81488", VA = "0xD81488")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008A4")]
			[Address(RVA = "0xD81490", Offset = "0xD81490", VA = "0xD81490")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700014A")]
		public int SourceIdx
		{
			[Token(Token = "0x60008A5")]
			[Address(RVA = "0xD8149C", Offset = "0xD8149C", VA = "0xD8149C")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60008A6")]
			[Address(RVA = "0xD814A4", Offset = "0xD814A4", VA = "0xD814A4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700014B")]
		public int FromChar
		{
			[Token(Token = "0x60008A7")]
			[Address(RVA = "0xD814AC", Offset = "0xD814AC", VA = "0xD814AC")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60008A8")]
			[Address(RVA = "0xD814B4", Offset = "0xD814B4", VA = "0xD814B4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700014C")]
		public int ToChar
		{
			[Token(Token = "0x60008A9")]
			[Address(RVA = "0xD814BC", Offset = "0xD814BC", VA = "0xD814BC")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60008AA")]
			[Address(RVA = "0xD814C4", Offset = "0xD814C4", VA = "0xD814C4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700014D")]
		public int FromLine
		{
			[Token(Token = "0x60008AB")]
			[Address(RVA = "0xD814CC", Offset = "0xD814CC", VA = "0xD814CC")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60008AC")]
			[Address(RVA = "0xD814D4", Offset = "0xD814D4", VA = "0xD814D4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700014E")]
		public int ToLine
		{
			[Token(Token = "0x60008AD")]
			[Address(RVA = "0xD814DC", Offset = "0xD814DC", VA = "0xD814DC")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60008AE")]
			[Address(RVA = "0xD814E4", Offset = "0xD814E4", VA = "0xD814E4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700014F")]
		public bool IsStepStop
		{
			[Token(Token = "0x60008AF")]
			[Address(RVA = "0xD814EC", Offset = "0xD814EC", VA = "0xD814EC")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008B0")]
			[Address(RVA = "0xD814F4", Offset = "0xD814F4", VA = "0xD814F4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000150")]
		public bool CannotBreakpoint
		{
			[Token(Token = "0x60008B1")]
			[Address(RVA = "0xD81500", Offset = "0xD81500", VA = "0xD81500")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008B2")]
			[Address(RVA = "0xD81508", Offset = "0xD81508", VA = "0xD81508")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60008B3")]
		[Address(RVA = "0xD81514", Offset = "0xD81514", VA = "0xD81514")]
		internal static SourceRef GetClrLocation()
		{
			return null;
		}

		[Token(Token = "0x60008B4")]
		[Address(RVA = "0xD815E0", Offset = "0xD815E0", VA = "0xD815E0")]
		public SourceRef(SourceRef src, bool isStepStop)
		{
		}

		[Token(Token = "0x60008B5")]
		[Address(RVA = "0xD81584", Offset = "0xD81584", VA = "0xD81584")]
		public SourceRef(int sourceIdx, int from, int to, int fromline, int toline, bool isStepStop)
		{
		}

		[Token(Token = "0x60008B6")]
		[Address(RVA = "0xD81628", Offset = "0xD81628", VA = "0xD81628", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60008B7")]
		[Address(RVA = "0xD81888", Offset = "0xD81888", VA = "0xD81888")]
		internal int GetLocationDistance(int sourceIdx, int line, int col)
		{
			return default(int);
		}

		[Token(Token = "0x60008B8")]
		[Address(RVA = "0xD8199C", Offset = "0xD8199C", VA = "0xD8199C")]
		public bool IncludesLocation(int sourceIdx, int line, int col)
		{
			return default(bool);
		}

		[Token(Token = "0x60008B9")]
		[Address(RVA = "0xD81A14", Offset = "0xD81A14", VA = "0xD81A14")]
		public SourceRef SetNoBreakPoint()
		{
			return null;
		}

		[Token(Token = "0x60008BA")]
		[Address(RVA = "0xD81A20", Offset = "0xD81A20", VA = "0xD81A20")]
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
			[Address(RVA = "0xD81F24", Offset = "0xD81F24", VA = "0xD81F24")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60008BC")]
			[Address(RVA = "0xD81F2C", Offset = "0xD81F2C", VA = "0xD81F2C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000152")]
		public int BasePtr
		{
			[Token(Token = "0x60008BD")]
			[Address(RVA = "0xD81F34", Offset = "0xD81F34", VA = "0xD81F34")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60008BE")]
			[Address(RVA = "0xD81F3C", Offset = "0xD81F3C", VA = "0xD81F3C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000153")]
		public int RetAddress
		{
			[Token(Token = "0x60008BF")]
			[Address(RVA = "0xD81F44", Offset = "0xD81F44", VA = "0xD81F44")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60008C0")]
			[Address(RVA = "0xD81F4C", Offset = "0xD81F4C", VA = "0xD81F4C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000154")]
		public string Name
		{
			[Token(Token = "0x60008C1")]
			[Address(RVA = "0xD81F54", Offset = "0xD81F54", VA = "0xD81F54")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60008C2")]
			[Address(RVA = "0xD81F5C", Offset = "0xD81F5C", VA = "0xD81F5C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000155")]
		public DynValue Value
		{
			[Token(Token = "0x60008C3")]
			[Address(RVA = "0xD81F64", Offset = "0xD81F64", VA = "0xD81F64")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60008C4")]
			[Address(RVA = "0xD81F6C", Offset = "0xD81F6C", VA = "0xD81F6C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000156")]
		public SymbolRef LValue
		{
			[Token(Token = "0x60008C5")]
			[Address(RVA = "0xD81F74", Offset = "0xD81F74", VA = "0xD81F74")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60008C6")]
			[Address(RVA = "0xD81F7C", Offset = "0xD81F7C", VA = "0xD81F7C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000157")]
		public bool IsError
		{
			[Token(Token = "0x60008C7")]
			[Address(RVA = "0xD81F84", Offset = "0xD81F84", VA = "0xD81F84")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008C8")]
			[Address(RVA = "0xD81F8C", Offset = "0xD81F8C", VA = "0xD81F8C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000158")]
		public SourceRef Location
		{
			[Token(Token = "0x60008C9")]
			[Address(RVA = "0xD81F98", Offset = "0xD81F98", VA = "0xD81F98")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60008CA")]
			[Address(RVA = "0xD81FA0", Offset = "0xD81FA0", VA = "0xD81FA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x60008CB")]
		[Address(RVA = "0xD81FA8", Offset = "0xD81FA8", VA = "0xD81FA8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60008CC")]
		[Address(RVA = "0xD7E890", Offset = "0xD7E890", VA = "0xD7E890")]
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
		[Address(RVA = "0xD821FC", Offset = "0xD821FC", VA = "0xD821FC", Slot = "4")]
		private bool System.Collections.Generic.IEqualityComparer<System.Object>.Equals(object x, object y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000903")]
		[Address(RVA = "0xD82208", Offset = "0xD82208", VA = "0xD82208", Slot = "5")]
		private int System.Collections.Generic.IEqualityComparer<System.Object>.GetHashCode(object obj)
		{
			return default(int);
		}

		[Token(Token = "0x6000904")]
		[Address(RVA = "0xD82228", Offset = "0xD82228", VA = "0xD82228")]
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
		[Address(RVA = "0xD82230", Offset = "0xD82230", VA = "0xD82230")]
		[MoonSharpModuleMethod]
		public static DynValue type(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000926")]
		[Address(RVA = "0xD822FC", Offset = "0xD822FC", VA = "0xD822FC")]
		[MoonSharpModuleMethod]
		public static DynValue assert(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000927")]
		[Address(RVA = "0xD82468", Offset = "0xD82468", VA = "0xD82468")]
		[MoonSharpModuleMethod]
		public static DynValue collectgarbage(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000928")]
		[Address(RVA = "0xD825A0", Offset = "0xD825A0", VA = "0xD825A0")]
		[MoonSharpModuleMethod]
		public static DynValue error(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000929")]
		[Address(RVA = "0xD82634", Offset = "0xD82634", VA = "0xD82634")]
		[MoonSharpModuleMethod]
		public static DynValue tostring(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x600092A")]
		[Address(RVA = "0xD82860", Offset = "0xD82860", VA = "0xD82860")]
		private static DynValue __tostring_continuation(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x600092B")]
		[Address(RVA = "0xD82900", Offset = "0xD82900", VA = "0xD82900")]
		[MoonSharpModuleMethod]
		public static DynValue select(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x600092C")]
		[Address(RVA = "0xD82C78", Offset = "0xD82C78", VA = "0xD82C78")]
		[MoonSharpModuleMethod]
		public static DynValue tonumber(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x600092D")]
		[Address(RVA = "0xD830A4", Offset = "0xD830A4", VA = "0xD830A4")]
		[MoonSharpModuleMethod]
		public static DynValue print(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x600092E")]
		[Address(RVA = "0xD83248", Offset = "0xD83248", VA = "0xD83248")]
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
		[Address(RVA = "0xD83250", Offset = "0xD83250", VA = "0xD83250")]
		private static uint ToUInt32(DynValue v)
		{
			return default(uint);
		}

		[Token(Token = "0x6000930")]
		[Address(RVA = "0xD832E8", Offset = "0xD832E8", VA = "0xD832E8")]
		private static int ToInt32(DynValue v)
		{
			return default(int);
		}

		[Token(Token = "0x6000931")]
		[Address(RVA = "0xD83388", Offset = "0xD83388", VA = "0xD83388")]
		private static uint NBitMask(int bits)
		{
			return default(uint);
		}

		[Token(Token = "0x6000932")]
		[Address(RVA = "0xD83434", Offset = "0xD83434", VA = "0xD83434")]
		public static uint Bitwise(string funcName, CallbackArguments args, Func<uint, uint, uint> accumFunc)
		{
			return default(uint);
		}

		[Token(Token = "0x6000933")]
		[Address(RVA = "0xD83554", Offset = "0xD83554", VA = "0xD83554")]
		[MoonSharpModuleMethod]
		public static DynValue extract(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000934")]
		[Address(RVA = "0xD83908", Offset = "0xD83908", VA = "0xD83908")]
		[MoonSharpModuleMethod]
		public static DynValue replace(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000935")]
		[Address(RVA = "0xD83700", Offset = "0xD83700", VA = "0xD83700")]
		private static void ValidatePosWidth(string func, int argPos, int pos, int width)
		{
		}

		[Token(Token = "0x6000936")]
		[Address(RVA = "0xD83ADC", Offset = "0xD83ADC", VA = "0xD83ADC")]
		[MoonSharpModuleMethod]
		public static DynValue arshift(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000937")]
		[Address(RVA = "0xD83BF4", Offset = "0xD83BF4", VA = "0xD83BF4")]
		[MoonSharpModuleMethod]
		public static DynValue rshift(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000938")]
		[Address(RVA = "0xD83D0C", Offset = "0xD83D0C", VA = "0xD83D0C")]
		[MoonSharpModuleMethod]
		public static DynValue lshift(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000939")]
		[Address(RVA = "0xD83E24", Offset = "0xD83E24", VA = "0xD83E24")]
		[MoonSharpModuleMethod]
		public static DynValue band(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x600093A")]
		[Address(RVA = "0xD83F7C", Offset = "0xD83F7C", VA = "0xD83F7C")]
		[MoonSharpModuleMethod]
		public static DynValue btest(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x600093B")]
		[Address(RVA = "0xD840D8", Offset = "0xD840D8", VA = "0xD840D8")]
		[MoonSharpModuleMethod]
		public static DynValue bor(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x600093C")]
		[Address(RVA = "0xD84230", Offset = "0xD84230", VA = "0xD84230")]
		[MoonSharpModuleMethod]
		public static DynValue bnot(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x600093D")]
		[Address(RVA = "0xD84300", Offset = "0xD84300", VA = "0xD84300")]
		[MoonSharpModuleMethod]
		public static DynValue bxor(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x600093E")]
		[Address(RVA = "0xD84458", Offset = "0xD84458", VA = "0xD84458")]
		[MoonSharpModuleMethod]
		public static DynValue lrotate(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x600093F")]
		[Address(RVA = "0xD84560", Offset = "0xD84560", VA = "0xD84560")]
		[MoonSharpModuleMethod]
		public static DynValue rrotate(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000940")]
		[Address(RVA = "0xD84668", Offset = "0xD84668", VA = "0xD84668")]
		public Bit32Module()
		{
		}
	}
	[Token(Token = "0x200013F")]
	[MoonSharpModule(Namespace = "coroutine")]
	public class CoroutineModule
	{
		[Token(Token = "0x6000948")]
		[Address(RVA = "0xD84790", Offset = "0xD84790", VA = "0xD84790")]
		[MoonSharpModuleMethod]
		public static DynValue create(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000949")]
		[Address(RVA = "0xD8486C", Offset = "0xD8486C", VA = "0xD8486C")]
		[MoonSharpModuleMethod]
		public static DynValue wrap(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x600094A")]
		[Address(RVA = "0xD849C0", Offset = "0xD849C0", VA = "0xD849C0")]
		public static DynValue __wrap_wrapper(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x600094B")]
		[Address(RVA = "0xD84A60", Offset = "0xD84A60", VA = "0xD84A60")]
		[MoonSharpModuleMethod]
		public static DynValue resume(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x600094C")]
		[Address(RVA = "0xD84FCC", Offset = "0xD84FCC", VA = "0xD84FCC")]
		[MoonSharpModuleMethod]
		public static DynValue yield(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x600094D")]
		[Address(RVA = "0xD85044", Offset = "0xD85044", VA = "0xD85044")]
		[MoonSharpModuleMethod]
		public static DynValue running(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x600094E")]
		[Address(RVA = "0xD85174", Offset = "0xD85174", VA = "0xD85174")]
		[MoonSharpModuleMethod]
		public static DynValue status(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x600094F")]
		[Address(RVA = "0xD853B4", Offset = "0xD853B4", VA = "0xD853B4")]
		public CoroutineModule()
		{
		}
	}
	[Token(Token = "0x2000140")]
	[MoonSharpModule(Namespace = "debug")]
	public class DebugModule
	{
		[Token(Token = "0x6000950")]
		[Address(RVA = "0xD853BC", Offset = "0xD853BC", VA = "0xD853BC")]
		[MoonSharpModuleMethod]
		public static DynValue debug(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000951")]
		[Address(RVA = "0xD856E8", Offset = "0xD856E8", VA = "0xD856E8")]
		[MoonSharpModuleMethod]
		public static DynValue getuservalue(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000952")]
		[Address(RVA = "0xD857B0", Offset = "0xD857B0", VA = "0xD857B0")]
		[MoonSharpModuleMethod]
		public static DynValue setuservalue(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000953")]
		[Address(RVA = "0xD85854", Offset = "0xD85854", VA = "0xD85854")]
		[MoonSharpModuleMethod]
		public static DynValue getregistry(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000954")]
		[Address(RVA = "0xD858CC", Offset = "0xD858CC", VA = "0xD858CC")]
		[MoonSharpModuleMethod]
		public static DynValue getmetatable(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000955")]
		[Address(RVA = "0xD85A04", Offset = "0xD85A04", VA = "0xD85A04")]
		[MoonSharpModuleMethod]
		public static DynValue setmetatable(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000956")]
		[Address(RVA = "0xD85BC0", Offset = "0xD85BC0", VA = "0xD85BC0")]
		[MoonSharpModuleMethod]
		public static DynValue getupvalue(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000957")]
		[Address(RVA = "0xD85E20", Offset = "0xD85E20", VA = "0xD85E20")]
		[MoonSharpModuleMethod]
		public static DynValue upvalueid(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000958")]
		[Address(RVA = "0xD85FD4", Offset = "0xD85FD4", VA = "0xD85FD4")]
		[MoonSharpModuleMethod]
		public static DynValue setupvalue(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000959")]
		[Address(RVA = "0xD861C8", Offset = "0xD861C8", VA = "0xD861C8")]
		[MoonSharpModuleMethod]
		public static DynValue upvaluejoin(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x600095A")]
		[Address(RVA = "0xD86418", Offset = "0xD86418", VA = "0xD86418")]
		[MoonSharpModuleMethod]
		public static DynValue traceback(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x600095B")]
		[Address(RVA = "0xD867BC", Offset = "0xD867BC", VA = "0xD867BC")]
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
			[Address(RVA = "0xD86CCC", Offset = "0xD86CCC", VA = "0xD86CCC")]
			public DynamicExprWrapper()
			{
			}
		}

		[Token(Token = "0x600095C")]
		[Address(RVA = "0xD867C4", Offset = "0xD867C4", VA = "0xD867C4")]
		public static void MoonSharpInit(Table globalTable, Table stringTable)
		{
		}

		[Token(Token = "0x600095D")]
		[Address(RVA = "0xD86830", Offset = "0xD86830", VA = "0xD86830")]
		[MoonSharpModuleMethod]
		public static DynValue eval(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x600095E")]
		[Address(RVA = "0xD86ADC", Offset = "0xD86ADC", VA = "0xD86ADC")]
		[MoonSharpModuleMethod]
		public static DynValue prepare(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x600095F")]
		[Address(RVA = "0xD86CD4", Offset = "0xD86CD4", VA = "0xD86CD4")]
		public DynamicModule()
		{
		}
	}
	[Token(Token = "0x2000143")]
	[MoonSharpModule]
	public class ErrorHandlingModule
	{
		[Token(Token = "0x6000961")]
		[Address(RVA = "0xD86CDC", Offset = "0xD86CDC", VA = "0xD86CDC")]
		[MoonSharpModuleMethod]
		public static DynValue pcall(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000962")]
		[Address(RVA = "0xD86D38", Offset = "0xD86D38", VA = "0xD86D38")]
		private static DynValue SetErrorHandlerStrategy(string funcName, ScriptExecutionContext executionContext, CallbackArguments args, DynValue handlerBeforeUnwind)
		{
			return null;
		}

		[Token(Token = "0x6000963")]
		[Address(RVA = "0xD87680", Offset = "0xD87680", VA = "0xD87680")]
		private static DynValue MakeReturnTuple(bool retstatus, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000964")]
		[Address(RVA = "0xD877CC", Offset = "0xD877CC", VA = "0xD877CC")]
		public static DynValue pcall_continuation(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000965")]
		[Address(RVA = "0xD877D4", Offset = "0xD877D4", VA = "0xD877D4")]
		public static DynValue pcall_onerror(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000966")]
		[Address(RVA = "0xD877DC", Offset = "0xD877DC", VA = "0xD877DC")]
		[MoonSharpModuleMethod]
		public static DynValue xpcall(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000967")]
		[Address(RVA = "0xD879EC", Offset = "0xD879EC", VA = "0xD879EC")]
		public ErrorHandlingModule()
		{
		}
	}
	[Token(Token = "0x2000144")]
	[MoonSharpModule(Namespace = "io")]
	public class IoModule
	{
		[Token(Token = "0x6000968")]
		[Address(RVA = "0xD879F4", Offset = "0xD879F4", VA = "0xD879F4")]
		public static void MoonSharpInit(Table globalTable, Table ioTable)
		{
		}

		[Token(Token = "0x6000969")]
		[Address(RVA = "0xD87E1C", Offset = "0xD87E1C", VA = "0xD87E1C")]
		private static DynValue __index_callback(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x600096A")]
		[Address(RVA = "0xD87F98", Offset = "0xD87F98", VA = "0xD87F98")]
		private static DynValue GetStandardFile(Script S, StandardFileType file)
		{
			return null;
		}

		[Token(Token = "0x600096B")]
		[Address(RVA = "0xD87C18", Offset = "0xD87C18", VA = "0xD87C18")]
		private static void SetStandardFile(Script S, StandardFileType file, Stream optionsStream)
		{
		}

		[Token(Token = "0x600096C")]
		[Address(RVA = "0xD88048", Offset = "0xD88048", VA = "0xD88048")]
		private static FileUserDataBase GetDefaultFile(ScriptExecutionContext executionContext, StandardFileType file)
		{
			return null;
		}

		[Token(Token = "0x600096D")]
		[Address(RVA = "0xD881D0", Offset = "0xD881D0", VA = "0xD881D0")]
		private static void SetDefaultFile(ScriptExecutionContext executionContext, StandardFileType file, FileUserDataBase fileHandle)
		{
		}

		[Token(Token = "0x600096E")]
		[Address(RVA = "0xD88204", Offset = "0xD88204", VA = "0xD88204")]
		internal static void SetDefaultFile(Script script, StandardFileType file, FileUserDataBase fileHandle)
		{
		}

		[Token(Token = "0x600096F")]
		[Address(RVA = "0xD882FC", Offset = "0xD882FC", VA = "0xD882FC")]
		public static void SetDefaultFile(Script script, StandardFileType file, Stream stream)
		{
		}

		[Token(Token = "0x6000970")]
		[Address(RVA = "0xD88344", Offset = "0xD88344", VA = "0xD88344")]
		[MoonSharpModuleMethod]
		public static DynValue close(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000971")]
		[Address(RVA = "0xD883DC", Offset = "0xD883DC", VA = "0xD883DC")]
		[MoonSharpModuleMethod]
		public static DynValue flush(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000972")]
		[Address(RVA = "0xD884D4", Offset = "0xD884D4", VA = "0xD884D4")]
		[MoonSharpModuleMethod]
		public static DynValue input(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000973")]
		[Address(RVA = "0xD886BC", Offset = "0xD886BC", VA = "0xD886BC")]
		[MoonSharpModuleMethod]
		public static DynValue output(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000974")]
		[Address(RVA = "0xD884DC", Offset = "0xD884DC", VA = "0xD884DC")]
		private static DynValue HandleDefaultStreamSetter(ScriptExecutionContext executionContext, CallbackArguments args, StandardFileType defaultFiles)
		{
			return null;
		}

		[Token(Token = "0x6000975")]
		[Address(RVA = "0xD886C4", Offset = "0xD886C4", VA = "0xD886C4")]
		private static Encoding GetUTF8Encoding()
		{
			return null;
		}

		[Token(Token = "0x6000976")]
		[Address(RVA = "0xD887C0", Offset = "0xD887C0", VA = "0xD887C0")]
		[MoonSharpModuleMethod]
		public static DynValue lines(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000977")]
		[Address(RVA = "0xD89080", Offset = "0xD89080", VA = "0xD89080")]
		[MoonSharpModuleMethod]
		public static DynValue open(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000978")]
		[Address(RVA = "0xD88FD4", Offset = "0xD88FD4", VA = "0xD88FD4")]
		public static string IoExceptionToLuaMessage(Exception ex, string filename)
		{
			return null;
		}

		[Token(Token = "0x6000979")]
		[Address(RVA = "0xD89678", Offset = "0xD89678", VA = "0xD89678")]
		[MoonSharpModuleMethod]
		public static DynValue type(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x600097A")]
		[Address(RVA = "0xD897F8", Offset = "0xD897F8", VA = "0xD897F8")]
		[MoonSharpModuleMethod]
		public static DynValue read(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x600097B")]
		[Address(RVA = "0xD89830", Offset = "0xD89830", VA = "0xD89830")]
		[MoonSharpModuleMethod]
		public static DynValue write(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x600097C")]
		[Address(RVA = "0xD89868", Offset = "0xD89868", VA = "0xD89868")]
		[MoonSharpModuleMethod]
		public static DynValue tmpfile(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x600097D")]
		[Address(RVA = "0xD88724", Offset = "0xD88724", VA = "0xD88724")]
		private static FileUserDataBase Open(ScriptExecutionContext executionContext, string filename, Encoding encoding, string mode)
		{
			return null;
		}

		[Token(Token = "0x600097E")]
		[Address(RVA = "0xD899E0", Offset = "0xD899E0", VA = "0xD899E0")]
		public IoModule()
		{
		}
	}
	[Token(Token = "0x2000146")]
	[MoonSharpModule(Namespace = "json")]
	public class JsonModule
	{
		[Token(Token = "0x6000982")]
		[Address(RVA = "0xD89A5C", Offset = "0xD89A5C", VA = "0xD89A5C")]
		[MoonSharpModuleMethod]
		public static DynValue parse(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000983")]
		[Address(RVA = "0xD89BF8", Offset = "0xD89BF8", VA = "0xD89BF8")]
		[MoonSharpModuleMethod]
		public static DynValue serialize(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000984")]
		[Address(RVA = "0xD89D68", Offset = "0xD89D68", VA = "0xD89D68")]
		[MoonSharpModuleMethod]
		public static DynValue isnull(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000985")]
		[Address(RVA = "0xD89E04", Offset = "0xD89E04", VA = "0xD89E04")]
		[MoonSharpModuleMethod]
		public static DynValue @null(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000986")]
		[Address(RVA = "0xD89E0C", Offset = "0xD89E0C", VA = "0xD89E0C")]
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
		[Address(RVA = "0xD89E14", Offset = "0xD89E14", VA = "0xD89E14")]
		public static void MoonSharpInit(Table globalTable, Table ioTable)
		{
		}

		[Token(Token = "0x6000988")]
		[Address(RVA = "0xD89FF8", Offset = "0xD89FF8", VA = "0xD89FF8")]
		[MoonSharpModuleMethod]
		public static DynValue load(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000989")]
		[Address(RVA = "0xD8A5B4", Offset = "0xD8A5B4", VA = "0xD8A5B4")]
		[MoonSharpModuleMethod]
		public static DynValue loadsafe(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x600098A")]
		[Address(RVA = "0xD8A000", Offset = "0xD8A000", VA = "0xD8A000")]
		public static DynValue load_impl(ScriptExecutionContext executionContext, CallbackArguments args, Table defaultEnv)
		{
			return null;
		}

		[Token(Token = "0x600098B")]
		[Address(RVA = "0xD8A64C", Offset = "0xD8A64C", VA = "0xD8A64C")]
		[MoonSharpModuleMethod]
		public static DynValue loadfile(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x600098C")]
		[Address(RVA = "0xD8A934", Offset = "0xD8A934", VA = "0xD8A934")]
		[MoonSharpModuleMethod]
		public static DynValue loadfilesafe(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x600098D")]
		[Address(RVA = "0xD8A654", Offset = "0xD8A654", VA = "0xD8A654")]
		private static DynValue loadfile_impl(ScriptExecutionContext executionContext, CallbackArguments args, Table defaultEnv)
		{
			return null;
		}

		[Token(Token = "0x600098E")]
		[Address(RVA = "0xD8A5E0", Offset = "0xD8A5E0", VA = "0xD8A5E0")]
		private static Table GetSafeDefaultEnv(ScriptExecutionContext executionContext)
		{
			return null;
		}

		[Token(Token = "0x600098F")]
		[Address(RVA = "0xD8A960", Offset = "0xD8A960", VA = "0xD8A960")]
		[MoonSharpModuleMethod]
		public static DynValue dofile(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000990")]
		[Address(RVA = "0xD8AB70", Offset = "0xD8AB70", VA = "0xD8AB70")]
		[MoonSharpModuleMethod]
		public static DynValue __require_clr_impl(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000991")]
		[Address(RVA = "0xD8AC0C", Offset = "0xD8AC0C", VA = "0xD8AC0C")]
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
		[Address(RVA = "0xD8AC14", Offset = "0xD8AC14", VA = "0xD8AC14")]
		private static Random GetRandom(Script s)
		{
			return null;
		}

		[Token(Token = "0x6000993")]
		[Address(RVA = "0xD8ACD8", Offset = "0xD8ACD8", VA = "0xD8ACD8")]
		private static void SetRandom(Script s, Random random)
		{
		}

		[Token(Token = "0x6000994")]
		[Address(RVA = "0xD8ADB4", Offset = "0xD8ADB4", VA = "0xD8ADB4")]
		public static void MoonSharpInit(Table globalTable, Table ioTable)
		{
		}

		[Token(Token = "0x6000995")]
		[Address(RVA = "0xD8AE20", Offset = "0xD8AE20", VA = "0xD8AE20")]
		private static DynValue exec1(CallbackArguments args, string funcName, Func<double, double> func)
		{
			return null;
		}

		[Token(Token = "0x6000996")]
		[Address(RVA = "0xD8AED4", Offset = "0xD8AED4", VA = "0xD8AED4")]
		private static DynValue exec2(CallbackArguments args, string funcName, Func<double, double, double> func)
		{
			return null;
		}

		[Token(Token = "0x6000997")]
		[Address(RVA = "0xD8AFB0", Offset = "0xD8AFB0", VA = "0xD8AFB0")]
		private static DynValue exec2n(CallbackArguments args, string funcName, double defVal, Func<double, double, double> func)
		{
			return null;
		}

		[Token(Token = "0x6000998")]
		[Address(RVA = "0xD8B0AC", Offset = "0xD8B0AC", VA = "0xD8B0AC")]
		private static DynValue execaccum(CallbackArguments args, string funcName, Func<double, double, double> func)
		{
			return null;
		}

		[Token(Token = "0x6000999")]
		[Address(RVA = "0xD8B230", Offset = "0xD8B230", VA = "0xD8B230")]
		[MoonSharpModuleMethod]
		public static DynValue abs(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x600099A")]
		[Address(RVA = "0xD8B32C", Offset = "0xD8B32C", VA = "0xD8B32C")]
		[MoonSharpModuleMethod]
		public static DynValue acos(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x600099B")]
		[Address(RVA = "0xD8B428", Offset = "0xD8B428", VA = "0xD8B428")]
		[MoonSharpModuleMethod]
		public static DynValue asin(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x600099C")]
		[Address(RVA = "0xD8B524", Offset = "0xD8B524", VA = "0xD8B524")]
		[MoonSharpModuleMethod]
		public static DynValue atan(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x600099D")]
		[Address(RVA = "0xD8B620", Offset = "0xD8B620", VA = "0xD8B620")]
		[MoonSharpModuleMethod]
		public static DynValue atan2(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x600099E")]
		[Address(RVA = "0xD8B71C", Offset = "0xD8B71C", VA = "0xD8B71C")]
		[MoonSharpModuleMethod]
		public static DynValue ceil(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x600099F")]
		[Address(RVA = "0xD8B818", Offset = "0xD8B818", VA = "0xD8B818")]
		[MoonSharpModuleMethod]
		public static DynValue cos(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009A0")]
		[Address(RVA = "0xD8B914", Offset = "0xD8B914", VA = "0xD8B914")]
		[MoonSharpModuleMethod]
		public static DynValue cosh(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009A1")]
		[Address(RVA = "0xD8BA10", Offset = "0xD8BA10", VA = "0xD8BA10")]
		[MoonSharpModuleMethod]
		public static DynValue deg(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009A2")]
		[Address(RVA = "0xD8BB0C", Offset = "0xD8BB0C", VA = "0xD8BB0C")]
		[MoonSharpModuleMethod]
		public static DynValue exp(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009A3")]
		[Address(RVA = "0xD8BC08", Offset = "0xD8BC08", VA = "0xD8BC08")]
		[MoonSharpModuleMethod]
		public static DynValue floor(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009A4")]
		[Address(RVA = "0xD8BD04", Offset = "0xD8BD04", VA = "0xD8BD04")]
		[MoonSharpModuleMethod]
		public static DynValue fmod(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009A5")]
		[Address(RVA = "0xD8BE00", Offset = "0xD8BE00", VA = "0xD8BE00")]
		[MoonSharpModuleMethod]
		public static DynValue frexp(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009A6")]
		[Address(RVA = "0xD8C054", Offset = "0xD8C054", VA = "0xD8C054")]
		[MoonSharpModuleMethod]
		public static DynValue ldexp(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009A7")]
		[Address(RVA = "0xD8C150", Offset = "0xD8C150", VA = "0xD8C150")]
		[MoonSharpModuleMethod]
		public static DynValue log(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009A8")]
		[Address(RVA = "0xD8C254", Offset = "0xD8C254", VA = "0xD8C254")]
		[MoonSharpModuleMethod]
		public static DynValue max(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009A9")]
		[Address(RVA = "0xD8C350", Offset = "0xD8C350", VA = "0xD8C350")]
		[MoonSharpModuleMethod]
		public static DynValue min(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009AA")]
		[Address(RVA = "0xD8C44C", Offset = "0xD8C44C", VA = "0xD8C44C")]
		[MoonSharpModuleMethod]
		public static DynValue modf(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009AB")]
		[Address(RVA = "0xD8C5C8", Offset = "0xD8C5C8", VA = "0xD8C5C8")]
		[MoonSharpModuleMethod]
		public static DynValue pow(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009AC")]
		[Address(RVA = "0xD8C6C4", Offset = "0xD8C6C4", VA = "0xD8C6C4")]
		[MoonSharpModuleMethod]
		public static DynValue rad(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009AD")]
		[Address(RVA = "0xD8C7C0", Offset = "0xD8C7C0", VA = "0xD8C7C0")]
		[MoonSharpModuleMethod]
		public static DynValue random(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009AE")]
		[Address(RVA = "0xD8C968", Offset = "0xD8C968", VA = "0xD8C968")]
		[MoonSharpModuleMethod]
		public static DynValue randomseed(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009AF")]
		[Address(RVA = "0xD8CAA8", Offset = "0xD8CAA8", VA = "0xD8CAA8")]
		[MoonSharpModuleMethod]
		public static DynValue sin(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009B0")]
		[Address(RVA = "0xD8CBA4", Offset = "0xD8CBA4", VA = "0xD8CBA4")]
		[MoonSharpModuleMethod]
		public static DynValue sinh(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009B1")]
		[Address(RVA = "0xD8CCA0", Offset = "0xD8CCA0", VA = "0xD8CCA0")]
		[MoonSharpModuleMethod]
		public static DynValue sqrt(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009B2")]
		[Address(RVA = "0xD8CD9C", Offset = "0xD8CD9C", VA = "0xD8CD9C")]
		[MoonSharpModuleMethod]
		public static DynValue tan(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009B3")]
		[Address(RVA = "0xD8CE98", Offset = "0xD8CE98", VA = "0xD8CE98")]
		[MoonSharpModuleMethod]
		public static DynValue tanh(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009B4")]
		[Address(RVA = "0xD8CF94", Offset = "0xD8CF94", VA = "0xD8CF94")]
		public MathModule()
		{
		}
	}
	[Token(Token = "0x200014A")]
	[MoonSharpModule]
	public class MetaTableModule
	{
		[Token(Token = "0x60009CE")]
		[Address(RVA = "0xD8D824", Offset = "0xD8D824", VA = "0xD8D824")]
		[MoonSharpModuleMethod]
		public static DynValue setmetatable(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009CF")]
		[Address(RVA = "0xD8D968", Offset = "0xD8D968", VA = "0xD8D968")]
		[MoonSharpModuleMethod]
		public static DynValue getmetatable(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009D0")]
		[Address(RVA = "0xD8DAD8", Offset = "0xD8DAD8", VA = "0xD8DAD8")]
		[MoonSharpModuleMethod]
		public static DynValue rawget(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009D1")]
		[Address(RVA = "0xD8DB70", Offset = "0xD8DB70", VA = "0xD8DB70")]
		[MoonSharpModuleMethod]
		public static DynValue rawset(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009D2")]
		[Address(RVA = "0xD8DC34", Offset = "0xD8DC34", VA = "0xD8DC34")]
		[MoonSharpModuleMethod]
		public static DynValue rawequal(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009D3")]
		[Address(RVA = "0xD8DCD8", Offset = "0xD8DCD8", VA = "0xD8DCD8")]
		[MoonSharpModuleMethod]
		public static DynValue rawlen(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009D4")]
		[Address(RVA = "0xD8DDD4", Offset = "0xD8DDD4", VA = "0xD8DDD4")]
		public MetaTableModule()
		{
		}
	}
	[Token(Token = "0x200014B")]
	[MoonSharpModule(Namespace = "os")]
	public class OsSystemModule
	{
		[Token(Token = "0x60009D5")]
		[Address(RVA = "0xD8DDDC", Offset = "0xD8DDDC", VA = "0xD8DDDC")]
		[MoonSharpModuleMethod]
		public static DynValue execute(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009D6")]
		[Address(RVA = "0xD8E1D8", Offset = "0xD8E1D8", VA = "0xD8E1D8")]
		[MoonSharpModuleMethod]
		public static DynValue exit(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009D7")]
		[Address(RVA = "0xD8E324", Offset = "0xD8E324", VA = "0xD8E324")]
		[MoonSharpModuleMethod]
		public static DynValue getenv(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009D8")]
		[Address(RVA = "0xD8E508", Offset = "0xD8E508", VA = "0xD8E508")]
		[MoonSharpModuleMethod]
		public static DynValue remove(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009D9")]
		[Address(RVA = "0xD8EB40", Offset = "0xD8EB40", VA = "0xD8EB40")]
		[MoonSharpModuleMethod]
		public static DynValue rename(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009DA")]
		[Address(RVA = "0xD8F1B4", Offset = "0xD8F1B4", VA = "0xD8F1B4")]
		[MoonSharpModuleMethod]
		public static DynValue setlocale(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009DB")]
		[Address(RVA = "0xD8F21C", Offset = "0xD8F21C", VA = "0xD8F21C")]
		[MoonSharpModuleMethod]
		public static DynValue tmpname(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009DC")]
		[Address(RVA = "0xD8F358", Offset = "0xD8F358", VA = "0xD8F358")]
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
		[Address(RVA = "0xD8F360", Offset = "0xD8F360", VA = "0xD8F360")]
		private static DynValue GetUnixTime(DateTime dateTime, [Optional] DateTime? epoch)
		{
			return null;
		}

		[Token(Token = "0x60009DE")]
		[Address(RVA = "0xD8F4C0", Offset = "0xD8F4C0", VA = "0xD8F4C0")]
		private static DateTime FromUnixTime(double unixtime)
		{
			return default(DateTime);
		}

		[Token(Token = "0x60009DF")]
		[Address(RVA = "0xD8F58C", Offset = "0xD8F58C", VA = "0xD8F58C")]
		[MoonSharpModuleMethod]
		public static DynValue clock(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009E0")]
		[Address(RVA = "0xD8F650", Offset = "0xD8F650", VA = "0xD8F650")]
		[MoonSharpModuleMethod]
		public static DynValue difftime(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009E1")]
		[Address(RVA = "0xD8F740", Offset = "0xD8F740", VA = "0xD8F740")]
		[MoonSharpModuleMethod]
		public static DynValue time(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009E2")]
		[Address(RVA = "0xD8F84C", Offset = "0xD8F84C", VA = "0xD8F84C")]
		private static DateTime ParseTimeTable(Table t)
		{
			return default(DateTime);
		}

		[Token(Token = "0x60009E3")]
		[Address(RVA = "0xD8FAF4", Offset = "0xD8FAF4", VA = "0xD8FAF4")]
		private static int? GetTimeTableField(Table t, string key)
		{
			return null;
		}

		[Token(Token = "0x60009E4")]
		[Address(RVA = "0xD8FBD8", Offset = "0xD8FBD8", VA = "0xD8FBD8")]
		[MoonSharpModuleMethod]
		public static DynValue date(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009E5")]
		[Address(RVA = "0xD90190", Offset = "0xD90190", VA = "0xD90190")]
		private static string StrFTime(string format, DateTime d)
		{
			return null;
		}

		[Token(Token = "0x60009E6")]
		[Address(RVA = "0xD9095C", Offset = "0xD9095C", VA = "0xD9095C")]
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
		[Address(RVA = "0xD90A18", Offset = "0xD90A18", VA = "0xD90A18")]
		public static void MoonSharpInit(Table globalTable, Table stringTable)
		{
		}

		[Token(Token = "0x60009E9")]
		[Address(RVA = "0xD90B00", Offset = "0xD90B00", VA = "0xD90B00")]
		[MoonSharpModuleMethod]
		public static DynValue dump(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009EA")]
		[Address(RVA = "0xD90EAC", Offset = "0xD90EAC", VA = "0xD90EAC")]
		[MoonSharpModuleMethod]
		public static DynValue @char(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009EB")]
		[Address(RVA = "0xD91074", Offset = "0xD91074", VA = "0xD91074")]
		[MoonSharpModuleMethod]
		public static DynValue @byte(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009EC")]
		[Address(RVA = "0xD91374", Offset = "0xD91374", VA = "0xD91374")]
		[MoonSharpModuleMethod]
		public static DynValue unicode(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009ED")]
		[Address(RVA = "0xD914E4", Offset = "0xD914E4", VA = "0xD914E4")]
		private static int Unicode2Ascii(int i)
		{
			return default(int);
		}

		[Token(Token = "0x60009EE")]
		[Address(RVA = "0xD911E4", Offset = "0xD911E4", VA = "0xD911E4")]
		private static DynValue PerformByteLike(DynValue vs, DynValue vi, DynValue vj, Func<int, int> filter)
		{
			return null;
		}

		[Token(Token = "0x60009EF")]
		[Address(RVA = "0xD916C8", Offset = "0xD916C8", VA = "0xD916C8")]
		private static int? AdjustIndex(string s, DynValue vi, int defval)
		{
			return null;
		}

		[Token(Token = "0x60009F0")]
		[Address(RVA = "0xD91818", Offset = "0xD91818", VA = "0xD91818")]
		[MoonSharpModuleMethod]
		public static DynValue len(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009F1")]
		[Address(RVA = "0xD918C0", Offset = "0xD918C0", VA = "0xD918C0")]
		[MoonSharpModuleMethod]
		public static DynValue match(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009F2")]
		[Address(RVA = "0xD91970", Offset = "0xD91970", VA = "0xD91970")]
		[MoonSharpModuleMethod]
		public static DynValue gmatch(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009F3")]
		[Address(RVA = "0xD91A20", Offset = "0xD91A20", VA = "0xD91A20")]
		[MoonSharpModuleMethod]
		public static DynValue gsub(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009F4")]
		[Address(RVA = "0xD91AD0", Offset = "0xD91AD0", VA = "0xD91AD0")]
		[MoonSharpModuleMethod]
		public static DynValue find(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009F5")]
		[Address(RVA = "0xD91B80", Offset = "0xD91B80", VA = "0xD91B80")]
		[MoonSharpModuleMethod]
		public static DynValue lower(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009F6")]
		[Address(RVA = "0xD91C30", Offset = "0xD91C30", VA = "0xD91C30")]
		[MoonSharpModuleMethod]
		public static DynValue upper(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009F7")]
		[Address(RVA = "0xD91CE0", Offset = "0xD91CE0", VA = "0xD91CE0")]
		[MoonSharpModuleMethod]
		public static DynValue rep(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009F8")]
		[Address(RVA = "0xD91F0C", Offset = "0xD91F0C", VA = "0xD91F0C")]
		[MoonSharpModuleMethod]
		public static DynValue format(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009F9")]
		[Address(RVA = "0xD91FBC", Offset = "0xD91FBC", VA = "0xD91FBC")]
		[MoonSharpModuleMethod]
		public static DynValue reverse(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009FA")]
		[Address(RVA = "0xD920E4", Offset = "0xD920E4", VA = "0xD920E4")]
		[MoonSharpModuleMethod]
		public static DynValue sub(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009FB")]
		[Address(RVA = "0xD92228", Offset = "0xD92228", VA = "0xD92228")]
		[MoonSharpModuleMethod]
		public static DynValue startsWith(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009FC")]
		[Address(RVA = "0xD92394", Offset = "0xD92394", VA = "0xD92394")]
		[MoonSharpModuleMethod]
		public static DynValue endsWith(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009FD")]
		[Address(RVA = "0xD92500", Offset = "0xD92500", VA = "0xD92500")]
		[MoonSharpModuleMethod]
		public static DynValue contains(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x60009FE")]
		[Address(RVA = "0xD9266C", Offset = "0xD9266C", VA = "0xD9266C")]
		public StringModule()
		{
		}
	}
	[Token(Token = "0x200014F")]
	[MoonSharpModule]
	public class TableIteratorsModule
	{
		[Token(Token = "0x6000A03")]
		[Address(RVA = "0xD926F8", Offset = "0xD926F8", VA = "0xD926F8")]
		[MoonSharpModuleMethod]
		public static DynValue ipairs(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000A04")]
		[Address(RVA = "0xD928E8", Offset = "0xD928E8", VA = "0xD928E8")]
		[MoonSharpModuleMethod]
		public static DynValue pairs(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000A05")]
		[Address(RVA = "0xD92AA0", Offset = "0xD92AA0", VA = "0xD92AA0")]
		[MoonSharpModuleMethod]
		public static DynValue next(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000A06")]
		[Address(RVA = "0xD92CA8", Offset = "0xD92CA8", VA = "0xD92CA8")]
		public static DynValue __next_i(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000A07")]
		[Address(RVA = "0xD92E94", Offset = "0xD92E94", VA = "0xD92E94")]
		public TableIteratorsModule()
		{
		}
	}
	[Token(Token = "0x2000150")]
	[MoonSharpModule(Namespace = "table")]
	public class TableModule
	{
		[Token(Token = "0x6000A08")]
		[Address(RVA = "0xD92E9C", Offset = "0xD92E9C", VA = "0xD92E9C")]
		[MoonSharpModuleMethod]
		public static DynValue unpack(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000A09")]
		[Address(RVA = "0xD93284", Offset = "0xD93284", VA = "0xD93284")]
		[MoonSharpModuleMethod]
		public static DynValue pack(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000A0A")]
		[Address(RVA = "0xD933D4", Offset = "0xD933D4", VA = "0xD933D4")]
		[MoonSharpModuleMethod]
		public static DynValue sort(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000A0B")]
		[Address(RVA = "0xD9379C", Offset = "0xD9379C", VA = "0xD9379C")]
		private static int SortComparer(ScriptExecutionContext executionContext, DynValue a, DynValue b, DynValue lt)
		{
			return default(int);
		}

		[Token(Token = "0x6000A0C")]
		[Address(RVA = "0xD93A50", Offset = "0xD93A50", VA = "0xD93A50")]
		private static int LuaComparerToClrComparer(DynValue dynValue1, DynValue dynValue2)
		{
			return default(int);
		}

		[Token(Token = "0x6000A0D")]
		[Address(RVA = "0xD93B08", Offset = "0xD93B08", VA = "0xD93B08")]
		[MoonSharpModuleMethod]
		public static DynValue insert(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000A0E")]
		[Address(RVA = "0xD93D58", Offset = "0xD93D58", VA = "0xD93D58")]
		[MoonSharpModuleMethod]
		public static DynValue remove(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000A0F")]
		[Address(RVA = "0xD93FB8", Offset = "0xD93FB8", VA = "0xD93FB8")]
		[MoonSharpModuleMethod]
		public static DynValue concat(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000A10")]
		[Address(RVA = "0xD930B8", Offset = "0xD930B8", VA = "0xD930B8")]
		private static int GetTableLength(ScriptExecutionContext executionContext, DynValue vlist)
		{
			return default(int);
		}

		[Token(Token = "0x6000A11")]
		[Address(RVA = "0xD94378", Offset = "0xD94378", VA = "0xD94378")]
		public TableModule()
		{
		}
	}
	[Token(Token = "0x2000152")]
	[MoonSharpModule]
	public class TableModule_Globals
	{
		[Token(Token = "0x6000A14")]
		[Address(RVA = "0xD9438C", Offset = "0xD9438C", VA = "0xD9438C")]
		[MoonSharpModuleMethod]
		public static DynValue unpack(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000A15")]
		[Address(RVA = "0xD94390", Offset = "0xD94390", VA = "0xD94390")]
		[MoonSharpModuleMethod]
		public static DynValue pack(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000A16")]
		[Address(RVA = "0xD94394", Offset = "0xD94394", VA = "0xD94394")]
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
				[Address(RVA = "0xD984C8", Offset = "0xD984C8", VA = "0xD984C8")]
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
			[Address(RVA = "0xD9663C", Offset = "0xD9663C", VA = "0xD9663C")]
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
			[Address(RVA = "0xD96C88", Offset = "0xD96C88", VA = "0xD96C88")]
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
		[Address(RVA = "0xD9439C", Offset = "0xD9439C", VA = "0xD9439C")]
		private static int posrelat(int pos, uint len)
		{
			return default(int);
		}

		[Token(Token = "0x6000A18")]
		[Address(RVA = "0xD943B0", Offset = "0xD943B0", VA = "0xD943B0")]
		private static int check_capture(MatchState ms, int l)
		{
			return default(int);
		}

		[Token(Token = "0x6000A19")]
		[Address(RVA = "0xD944EC", Offset = "0xD944EC", VA = "0xD944EC")]
		private static int capture_to_close(MatchState ms)
		{
			return default(int);
		}

		[Token(Token = "0x6000A1A")]
		[Address(RVA = "0xD945E0", Offset = "0xD945E0", VA = "0xD945E0")]
		private static CharPtr classend(MatchState ms, CharPtr p)
		{
			return null;
		}

		[Token(Token = "0x6000A1B")]
		[Address(RVA = "0xD94930", Offset = "0xD94930", VA = "0xD94930")]
		private static int match_class(char c, char cl)
		{
			return default(int);
		}

		[Token(Token = "0x6000A1C")]
		[Address(RVA = "0xD94A50", Offset = "0xD94A50", VA = "0xD94A50")]
		private static int matchbracketclass(int c, CharPtr p, CharPtr ec)
		{
			return default(int);
		}

		[Token(Token = "0x6000A1D")]
		[Address(RVA = "0xD94C34", Offset = "0xD94C34", VA = "0xD94C34")]
		private static int singlematch(int c, CharPtr p, CharPtr ep)
		{
			return default(int);
		}

		[Token(Token = "0x6000A1E")]
		[Address(RVA = "0xD94D5C", Offset = "0xD94D5C", VA = "0xD94D5C")]
		private static CharPtr matchbalance(MatchState ms, CharPtr s, CharPtr p)
		{
			return null;
		}

		[Token(Token = "0x6000A1F")]
		[Address(RVA = "0xD94F50", Offset = "0xD94F50", VA = "0xD94F50")]
		private static CharPtr max_expand(MatchState ms, CharPtr s, CharPtr p, CharPtr ep)
		{
			return null;
		}

		[Token(Token = "0x6000A20")]
		[Address(RVA = "0xD95988", Offset = "0xD95988", VA = "0xD95988")]
		private static CharPtr min_expand(MatchState ms, CharPtr s, CharPtr p, CharPtr ep)
		{
			return null;
		}

		[Token(Token = "0x6000A21")]
		[Address(RVA = "0xD95AA8", Offset = "0xD95AA8", VA = "0xD95AA8")]
		private static CharPtr start_capture(MatchState ms, CharPtr s, CharPtr p, int what)
		{
			return null;
		}

		[Token(Token = "0x6000A22")]
		[Address(RVA = "0xD95C14", Offset = "0xD95C14", VA = "0xD95C14")]
		private static CharPtr end_capture(MatchState ms, CharPtr s, CharPtr p)
		{
			return null;
		}

		[Token(Token = "0x6000A23")]
		[Address(RVA = "0xD95D1C", Offset = "0xD95D1C", VA = "0xD95D1C")]
		private static CharPtr match_capture(MatchState ms, CharPtr s, int l)
		{
			return null;
		}

		[Token(Token = "0x6000A24")]
		[Address(RVA = "0xD950B4", Offset = "0xD950B4", VA = "0xD950B4")]
		private static CharPtr match(MatchState ms, CharPtr s, CharPtr p)
		{
			return null;
		}

		[Token(Token = "0x6000A25")]
		[Address(RVA = "0xD95E30", Offset = "0xD95E30", VA = "0xD95E30")]
		private static CharPtr lmemfind(CharPtr s1, uint l1, CharPtr s2, uint l2)
		{
			return null;
		}

		[Token(Token = "0x6000A26")]
		[Address(RVA = "0xD95F28", Offset = "0xD95F28", VA = "0xD95F28")]
		private static void push_onecapture(MatchState ms, int i, CharPtr s, CharPtr e)
		{
		}

		[Token(Token = "0x6000A27")]
		[Address(RVA = "0xD9613C", Offset = "0xD9613C", VA = "0xD9613C")]
		private static int push_captures(MatchState ms, CharPtr s, CharPtr e)
		{
			return default(int);
		}

		[Token(Token = "0x6000A28")]
		[Address(RVA = "0xD9622C", Offset = "0xD9622C", VA = "0xD9622C")]
		private static int str_find_aux(LuaState L, int find)
		{
			return default(int);
		}

		[Token(Token = "0x6000A29")]
		[Address(RVA = "0xD96720", Offset = "0xD96720", VA = "0xD96720")]
		public static int str_find(LuaState L)
		{
			return default(int);
		}

		[Token(Token = "0x6000A2A")]
		[Address(RVA = "0xD96778", Offset = "0xD96778", VA = "0xD96778")]
		public static int str_match(LuaState L)
		{
			return default(int);
		}

		[Token(Token = "0x6000A2B")]
		[Address(RVA = "0xD967D0", Offset = "0xD967D0", VA = "0xD967D0")]
		private static int gmatch_aux(LuaState L, GMatchAuxData auxdata)
		{
			return default(int);
		}

		[Token(Token = "0x6000A2C")]
		[Address(RVA = "0xD96970", Offset = "0xD96970", VA = "0xD96970")]
		private static DynValue gmatch_aux_2(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000A2D")]
		[Address(RVA = "0xD96A58", Offset = "0xD96A58", VA = "0xD96A58")]
		public static int str_gmatch(LuaState L)
		{
			return default(int);
		}

		[Token(Token = "0x6000A2E")]
		[Address(RVA = "0xD96C90", Offset = "0xD96C90", VA = "0xD96C90")]
		private static int gfind_nodef(LuaState L)
		{
			return default(int);
		}

		[Token(Token = "0x6000A2F")]
		[Address(RVA = "0xD96DAC", Offset = "0xD96DAC", VA = "0xD96DAC")]
		private static void add_s(MatchState ms, LuaLBuffer b, CharPtr s, CharPtr e)
		{
		}

		[Token(Token = "0x6000A30")]
		[Address(RVA = "0xD96FE8", Offset = "0xD96FE8", VA = "0xD96FE8")]
		private static void add_value(MatchState ms, LuaLBuffer b, CharPtr s, CharPtr e)
		{
		}

		[Token(Token = "0x6000A31")]
		[Address(RVA = "0xD9722C", Offset = "0xD9722C", VA = "0xD9722C")]
		public static int str_gsub(LuaState L)
		{
			return default(int);
		}

		[Token(Token = "0x6000A32")]
		[Address(RVA = "0xD9757C", Offset = "0xD9757C", VA = "0xD9757C")]
		private static void addquoted(LuaState L, LuaLBuffer b, int arg)
		{
		}

		[Token(Token = "0x6000A33")]
		[Address(RVA = "0xD97828", Offset = "0xD97828", VA = "0xD97828")]
		private static CharPtr scanformat(LuaState L, CharPtr strfrmt, CharPtr form)
		{
			return null;
		}

		[Token(Token = "0x6000A34")]
		[Address(RVA = "0xD97BA8", Offset = "0xD97BA8", VA = "0xD97BA8")]
		private static void addintlen(CharPtr form)
		{
		}

		[Token(Token = "0x6000A35")]
		[Address(RVA = "0xD97CAC", Offset = "0xD97CAC", VA = "0xD97CAC")]
		public static int str_format(LuaState L)
		{
			return default(int);
		}

		[Token(Token = "0x6000A36")]
		[Address(RVA = "0xD965D0", Offset = "0xD965D0", VA = "0xD965D0")]
		private static string PatchPattern(string charPtr)
		{
			return null;
		}

		[Token(Token = "0x6000A37")]
		[Address(RVA = "0xD9842C", Offset = "0xD9842C", VA = "0xD9842C")]
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
			[Address(RVA = "0xD9859C", Offset = "0xD9859C", VA = "0xD9859C")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000A3F")]
			[Address(RVA = "0xD985A4", Offset = "0xD985A4", VA = "0xD985A4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000169")]
		public int End
		{
			[Token(Token = "0x6000A40")]
			[Address(RVA = "0xD985AC", Offset = "0xD985AC", VA = "0xD985AC")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000A41")]
			[Address(RVA = "0xD985B4", Offset = "0xD985B4", VA = "0xD985B4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000A42")]
		[Address(RVA = "0xD985BC", Offset = "0xD985BC", VA = "0xD985BC")]
		public StringRange()
		{
		}

		[Token(Token = "0x6000A43")]
		[Address(RVA = "0xD985D8", Offset = "0xD985D8", VA = "0xD985D8")]
		public StringRange(int start, int end)
		{
		}

		[Token(Token = "0x6000A44")]
		[Address(RVA = "0xD914F4", Offset = "0xD914F4", VA = "0xD914F4")]
		public static StringRange FromLuaRange(DynValue start, DynValue end, [Optional] int? defaultEnd)
		{
			return null;
		}

		[Token(Token = "0x6000A45")]
		[Address(RVA = "0xD915FC", Offset = "0xD915FC", VA = "0xD915FC")]
		public string ApplyToString(string value)
		{
			return null;
		}

		[Token(Token = "0x6000A46")]
		[Address(RVA = "0xD98604", Offset = "0xD98604", VA = "0xD98604")]
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
		[Address(RVA = "0xD99614", Offset = "0xD99614", VA = "0xD99614")]
		public BinaryEncoding()
		{
		}

		[Token(Token = "0x6000A48")]
		[Address(RVA = "0xD9961C", Offset = "0xD9961C", VA = "0xD9961C", Slot = "13")]
		public override int GetByteCount(char[] chars, int index, int count)
		{
			return default(int);
		}

		[Token(Token = "0x6000A49")]
		[Address(RVA = "0xD99624", Offset = "0xD99624", VA = "0xD99624", Slot = "18")]
		public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex)
		{
			return default(int);
		}

		[Token(Token = "0x6000A4A")]
		[Address(RVA = "0xD99698", Offset = "0xD99698", VA = "0xD99698", Slot = "23")]
		public override int GetCharCount(byte[] bytes, int index, int count)
		{
			return default(int);
		}

		[Token(Token = "0x6000A4B")]
		[Address(RVA = "0xD996A0", Offset = "0xD996A0", VA = "0xD996A0", Slot = "27")]
		public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex)
		{
			return default(int);
		}

		[Token(Token = "0x6000A4C")]
		[Address(RVA = "0xD99714", Offset = "0xD99714", VA = "0xD99714", Slot = "34")]
		public override int GetMaxByteCount(int charCount)
		{
			return default(int);
		}

		[Token(Token = "0x6000A4D")]
		[Address(RVA = "0xD9971C", Offset = "0xD9971C", VA = "0xD9971C", Slot = "35")]
		public override int GetMaxCharCount(int byteCount)
		{
			return default(int);
		}
	}
	[Token(Token = "0x200015B")]
	internal class FileUserData : StreamFileUserDataBase
	{
		[Token(Token = "0x6000A4E")]
		[Address(RVA = "0xD99724", Offset = "0xD99724", VA = "0xD99724")]
		public FileUserData(Script script, string filename, Encoding encoding, string mode)
		{
		}
	}
	[Token(Token = "0x200015C")]
	internal abstract class FileUserDataBase : RefIdObject
	{
		[Token(Token = "0x6000A4F")]
		[Address(RVA = "0xD9992C", Offset = "0xD9992C", VA = "0xD9992C")]
		public DynValue lines(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000A50")]
		[Address(RVA = "0xD99B70", Offset = "0xD99B70", VA = "0xD99B70")]
		public DynValue read(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000A51")]
		[Address(RVA = "0xD9A38C", Offset = "0xD9A38C", VA = "0xD9A38C")]
		public DynValue write(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000A52")]
		[Address(RVA = "0xD9A630", Offset = "0xD9A630", VA = "0xD9A630")]
		public DynValue close(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[Token(Token = "0x6000A53")]
		[Address(RVA = "0xD9A20C", Offset = "0xD9A20C", VA = "0xD9A20C")]
		private double? ReadNumber()
		{
			return null;
		}

		[Token(Token = "0x6000A54")]
		[Address(RVA = "0xD9A9A4", Offset = "0xD9A9A4", VA = "0xD9A9A4")]
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
		[Address(RVA = "0xD9ABA8", Offset = "0xD9ABA8", VA = "0xD9ABA8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000A61")]
		[Address(RVA = "0xD9AC54", Offset = "0xD9AC54", VA = "0xD9AC54")]
		protected FileUserDataBase()
		{
		}
	}
	[Token(Token = "0x200015E")]
	internal class StandardIOFileUserDataBase : StreamFileUserDataBase
	{
		[Token(Token = "0x6000A65")]
		[Address(RVA = "0xD9ACD0", Offset = "0xD9ACD0", VA = "0xD9ACD0", Slot = "11")]
		protected override string Close()
		{
			return null;
		}

		[Token(Token = "0x6000A66")]
		[Address(RVA = "0xD9AD10", Offset = "0xD9AD10", VA = "0xD9AD10")]
		public static StandardIOFileUserDataBase CreateInputStream(Stream stream)
		{
			return null;
		}

		[Token(Token = "0x6000A67")]
		[Address(RVA = "0xD9ADB0", Offset = "0xD9ADB0", VA = "0xD9ADB0")]
		public static StandardIOFileUserDataBase CreateOutputStream(Stream stream)
		{
			return null;
		}

		[Token(Token = "0x6000A68")]
		[Address(RVA = "0xD9ADA8", Offset = "0xD9ADA8", VA = "0xD9ADA8")]
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
		[Address(RVA = "0xD99920", Offset = "0xD99920", VA = "0xD99920")]
		protected void Initialize(Stream stream, StreamReader reader, StreamWriter writer)
		{
		}

		[Token(Token = "0x6000A6A")]
		[Address(RVA = "0xD9AE48", Offset = "0xD9AE48", VA = "0xD9AE48")]
		private void CheckFileIsNotClosed()
		{
		}

		[Token(Token = "0x6000A6B")]
		[Address(RVA = "0xD9AEA8", Offset = "0xD9AEA8", VA = "0xD9AEA8", Slot = "4")]
		protected override bool Eof()
		{
			return default(bool);
		}

		[Token(Token = "0x6000A6C")]
		[Address(RVA = "0xD9AED0", Offset = "0xD9AED0", VA = "0xD9AED0", Slot = "5")]
		protected override string ReadLine()
		{
			return null;
		}

		[Token(Token = "0x6000A6D")]
		[Address(RVA = "0xD9AEFC", Offset = "0xD9AEFC", VA = "0xD9AEFC", Slot = "7")]
		protected override string ReadToEnd()
		{
			return null;
		}

		[Token(Token = "0x6000A6E")]
		[Address(RVA = "0xD9AF28", Offset = "0xD9AF28", VA = "0xD9AF28", Slot = "6")]
		protected override string ReadBuffer(int p)
		{
			return null;
		}

		[Token(Token = "0x6000A6F")]
		[Address(RVA = "0xD9AFCC", Offset = "0xD9AFCC", VA = "0xD9AFCC", Slot = "8")]
		protected override char Peek()
		{
			return default(char);
		}

		[Token(Token = "0x6000A70")]
		[Address(RVA = "0xD9AFF8", Offset = "0xD9AFF8", VA = "0xD9AFF8", Slot = "9")]
		protected override void Write(string value)
		{
		}

		[Token(Token = "0x6000A71")]
		[Address(RVA = "0xD9B034", Offset = "0xD9B034", VA = "0xD9B034", Slot = "11")]
		protected override string Close()
		{
			return null;
		}

		[Token(Token = "0x6000A72")]
		[Address(RVA = "0xD9B088", Offset = "0xD9B088", VA = "0xD9B088", Slot = "12")]
		public override bool flush()
		{
			return default(bool);
		}

		[Token(Token = "0x6000A73")]
		[Address(RVA = "0xD9B0B4", Offset = "0xD9B0B4", VA = "0xD9B0B4", Slot = "13")]
		public override long seek(string whence, long offset)
		{
			return default(long);
		}

		[Token(Token = "0x6000A74")]
		[Address(RVA = "0xD9B24C", Offset = "0xD9B24C", VA = "0xD9B24C", Slot = "14")]
		public override bool setvbuf(string mode)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A75")]
		[Address(RVA = "0xD9B2FC", Offset = "0xD9B2FC", VA = "0xD9B2FC", Slot = "10")]
		protected internal override bool isopen()
		{
			return default(bool);
		}

		[Token(Token = "0x6000A76")]
		[Address(RVA = "0xD99918", Offset = "0xD99918", VA = "0xD99918")]
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
			[Address(RVA = "0xD9B30C", Offset = "0xD9B30C", VA = "0xD9B30C")]
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
		[Address(RVA = "0xD9B3FC", Offset = "0xD9B3FC", VA = "0xD9B3FC")]
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
		[Address(RVA = "0xD9B404", Offset = "0xD9B404", VA = "0xD9B404", Slot = "36")]
		public override Type GetTypeInfoFromType(Type t)
		{
			return null;
		}

		[Token(Token = "0x6000A9B")]
		[Address(RVA = "0xD9B40C", Offset = "0xD9B40C", VA = "0xD9B40C", Slot = "18")]
		public override MethodInfo GetAddMethod(EventInfo ei)
		{
			return null;
		}

		[Token(Token = "0x6000A9C")]
		[Address(RVA = "0xD9B434", Offset = "0xD9B434", VA = "0xD9B434", Slot = "27")]
		public override ConstructorInfo[] GetConstructors(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000A9D")]
		[Address(RVA = "0xD9B460", Offset = "0xD9B460", VA = "0xD9B460", Slot = "26")]
		public override EventInfo[] GetEvents(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000A9E")]
		[Address(RVA = "0xD9B48C", Offset = "0xD9B48C", VA = "0xD9B48C", Slot = "30")]
		public override FieldInfo[] GetFields(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000A9F")]
		[Address(RVA = "0xD9B4B8", Offset = "0xD9B4B8", VA = "0xD9B4B8", Slot = "32")]
		public override Type[] GetGenericArguments(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000AA0")]
		[Address(RVA = "0xD9B4DC", Offset = "0xD9B4DC", VA = "0xD9B4DC", Slot = "20")]
		public override MethodInfo GetGetMethod(PropertyInfo pi)
		{
			return null;
		}

		[Token(Token = "0x6000AA1")]
		[Address(RVA = "0xD9B504", Offset = "0xD9B504", VA = "0xD9B504", Slot = "16")]
		public override Type[] GetInterfaces(Type t)
		{
			return null;
		}

		[Token(Token = "0x6000AA2")]
		[Address(RVA = "0xD9B528", Offset = "0xD9B528", VA = "0xD9B528", Slot = "31")]
		public override MethodInfo GetMethod(Type type, string name)
		{
			return null;
		}

		[Token(Token = "0x6000AA3")]
		[Address(RVA = "0xD9B544", Offset = "0xD9B544", VA = "0xD9B544", Slot = "29")]
		public override MethodInfo[] GetMethods(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000AA4")]
		[Address(RVA = "0xD9B570", Offset = "0xD9B570", VA = "0xD9B570", Slot = "25")]
		public override Type[] GetNestedTypes(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000AA5")]
		[Address(RVA = "0xD9B59C", Offset = "0xD9B59C", VA = "0xD9B59C", Slot = "23")]
		public override PropertyInfo[] GetProperties(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000AA6")]
		[Address(RVA = "0xD9B5C8", Offset = "0xD9B5C8", VA = "0xD9B5C8", Slot = "24")]
		public override PropertyInfo GetProperty(Type type, string name)
		{
			return null;
		}

		[Token(Token = "0x6000AA7")]
		[Address(RVA = "0xD9B5E4", Offset = "0xD9B5E4", VA = "0xD9B5E4", Slot = "19")]
		public override MethodInfo GetRemoveMethod(EventInfo ei)
		{
			return null;
		}

		[Token(Token = "0x6000AA8")]
		[Address(RVA = "0xD9B60C", Offset = "0xD9B60C", VA = "0xD9B60C", Slot = "21")]
		public override MethodInfo GetSetMethod(PropertyInfo pi)
		{
			return null;
		}

		[Token(Token = "0x6000AA9")]
		[Address(RVA = "0xD9B634", Offset = "0xD9B634", VA = "0xD9B634", Slot = "33")]
		public override bool IsAssignableFrom(Type current, Type toCompare)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AAA")]
		[Address(RVA = "0xD9B660", Offset = "0xD9B660", VA = "0xD9B660", Slot = "17")]
		public override bool IsInstanceOfType(Type t, object o)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AAB")]
		[Address(RVA = "0xD9B68C", Offset = "0xD9B68C", VA = "0xD9B68C", Slot = "35")]
		public override MethodInfo GetMethod(Type resourcesType, string name, Type[] types)
		{
			return null;
		}

		[Token(Token = "0x6000AAC")]
		[Address(RVA = "0xD9B6AC", Offset = "0xD9B6AC", VA = "0xD9B6AC", Slot = "28")]
		public override Type[] GetAssemblyTypes(Assembly asm)
		{
			return null;
		}

		[Token(Token = "0x6000AAD")]
		[Address(RVA = "0xD9B6D0", Offset = "0xD9B6D0", VA = "0xD9B6D0")]
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
		[Address(RVA = "0xD9B6EC", Offset = "0xD9B6EC", VA = "0xD9B6EC", Slot = "6")]
		public override Assembly GetAssembly(Type t)
		{
			return null;
		}

		[Token(Token = "0x6000AB0")]
		[Address(RVA = "0xD9B71C", Offset = "0xD9B71C", VA = "0xD9B71C", Slot = "7")]
		public override Type GetBaseType(Type t)
		{
			return null;
		}

		[Token(Token = "0x6000AB1")]
		[Address(RVA = "0xD9B74C", Offset = "0xD9B74C", VA = "0xD9B74C", Slot = "5")]
		public override bool IsValueType(Type t)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AB2")]
		[Address(RVA = "0xD9B774", Offset = "0xD9B774", VA = "0xD9B774", Slot = "13")]
		public override bool IsInterface(Type t)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AB3")]
		[Address(RVA = "0xD9B79C", Offset = "0xD9B79C", VA = "0xD9B79C", Slot = "11")]
		public override bool IsNestedPublic(Type t)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AB4")]
		[Address(RVA = "0xD9B7C4", Offset = "0xD9B7C4", VA = "0xD9B7C4", Slot = "12")]
		public override bool IsAbstract(Type t)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AB5")]
		[Address(RVA = "0xD9B7EC", Offset = "0xD9B7EC", VA = "0xD9B7EC", Slot = "10")]
		public override bool IsEnum(Type t)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AB6")]
		[Address(RVA = "0xD9B81C", Offset = "0xD9B81C", VA = "0xD9B81C", Slot = "9")]
		public override bool IsGenericTypeDefinition(Type t)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AB7")]
		[Address(RVA = "0xD9B84C", Offset = "0xD9B84C", VA = "0xD9B84C", Slot = "8")]
		public override bool IsGenericType(Type t)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AB8")]
		[Address(RVA = "0xD9B87C", Offset = "0xD9B87C", VA = "0xD9B87C", Slot = "14")]
		public override Attribute[] GetCustomAttributes(Type t, bool inherit)
		{
			return null;
		}

		[Token(Token = "0x6000AB9")]
		[Address(RVA = "0xD9B920", Offset = "0xD9B920", VA = "0xD9B920", Slot = "15")]
		public override Attribute[] GetCustomAttributes(Type t, Type at, bool inherit)
		{
			return null;
		}

		[Token(Token = "0x6000ABA")]
		[Address(RVA = "0xD9B6E4", Offset = "0xD9B6E4", VA = "0xD9B6E4")]
		protected FrameworkReflectionBase()
		{
		}
	}
	[Token(Token = "0x2000165")]
	internal class FrameworkCurrent : FrameworkClrBase
	{
		[Token(Token = "0x6000ABB")]
		[Address(RVA = "0xD9B9CC", Offset = "0xD9B9CC", VA = "0xD9B9CC", Slot = "34")]
		public override bool IsDbNull(object o)
		{
			return default(bool);
		}

		[Token(Token = "0x6000ABC")]
		[Address(RVA = "0xD9BA38", Offset = "0xD9BA38", VA = "0xD9BA38", Slot = "4")]
		public override bool StringContainsChar(string str, char chr)
		{
			return default(bool);
		}

		[Token(Token = "0x6000ABD")]
		[Address(RVA = "0xD9BA54", Offset = "0xD9BA54", VA = "0xD9BA54", Slot = "22")]
		public override Type GetInterface(Type type, string name)
		{
			return null;
		}

		[Token(Token = "0x6000ABE")]
		[Address(RVA = "0xD9B3E8", Offset = "0xD9B3E8", VA = "0xD9B3E8")]
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
		[Address(RVA = "0xD9BA70", Offset = "0xD9BA70", VA = "0xD9BA70")]
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
			[Address(RVA = "0xD9C74C", Offset = "0xD9C74C", VA = "0xD9C74C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AC5")]
			[Address(RVA = "0xD9C85C", Offset = "0xD9C85C", VA = "0xD9C85C")]
			set
			{
			}
		}

		[Token(Token = "0x1700016C")]
		public Script Current
		{
			[Token(Token = "0x6000AC6")]
			[Address(RVA = "0xD9CA6C", Offset = "0xD9CA6C", VA = "0xD9CA6C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AC7")]
			[Address(RVA = "0xD9CB3C", Offset = "0xD9CB3C", VA = "0xD9CB3C")]
			set
			{
			}
		}

		[Token(Token = "0x1700016D")]
		public Action<string> Logger
		{
			[Token(Token = "0x6000AC9")]
			[Address(RVA = "0xD9D214", Offset = "0xD9D214", VA = "0xD9D214")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000ACA")]
			[Address(RVA = "0xD9D21C", Offset = "0xD9D21C", VA = "0xD9D21C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000AC0")]
		[Address(RVA = "0xD9BA78", Offset = "0xD9BA78", VA = "0xD9BA78")]
		public MoonSharpVsCodeDebugServer(int port = 41912)
		{
		}

		[Token(Token = "0x6000AC1")]
		[Address(RVA = "0xD9BB6C", Offset = "0xD9BB6C", VA = "0xD9BB6C")]
		[Obsolete("Use the constructor taking only a port, and the 'Attach' method instead.")]
		public MoonSharpVsCodeDebugServer(Script script, int port, [Optional] Func<SourceCode, string> sourceFinder)
		{
		}

		[Token(Token = "0x6000AC2")]
		[Address(RVA = "0xD9C0F4", Offset = "0xD9C0F4", VA = "0xD9C0F4")]
		public void AttachToScript(Script script, string name, [Optional] Func<SourceCode, string> sourceFinder)
		{
		}

		[Token(Token = "0x6000AC3")]
		[Address(RVA = "0xD9C49C", Offset = "0xD9C49C", VA = "0xD9C49C")]
		public IEnumerable<KeyValuePair<int, string>> GetAttachedDebuggersByIdAndName()
		{
			return null;
		}

		[Token(Token = "0x6000AC8")]
		[Address(RVA = "0xD9CD40", Offset = "0xD9CD40", VA = "0xD9CD40")]
		public void Detach(Script script)
		{
		}

		[Token(Token = "0x6000ACB")]
		[Address(RVA = "0xD9D224", Offset = "0xD9D224", VA = "0xD9D224")]
		[Obsolete("Use the Attach method instead.")]
		public IDebugger GetDebugger()
		{
			return null;
		}

		[Token(Token = "0x6000ACC")]
		[Address(RVA = "0xD9D2E4", Offset = "0xD9D2E4", VA = "0xD9D2E4", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000ACD")]
		[Address(RVA = "0xD9D300", Offset = "0xD9D300", VA = "0xD9D300")]
		public MoonSharpVsCodeDebugServer Start()
		{
			return null;
		}

		[Token(Token = "0x6000ACE")]
		[Address(RVA = "0xD9D6F8", Offset = "0xD9D6F8", VA = "0xD9D6F8")]
		private void ListenThread(TcpListener serverSocket)
		{
		}

		[Token(Token = "0x6000ACF")]
		[Address(RVA = "0xD9DBA4", Offset = "0xD9DBA4", VA = "0xD9DBA4")]
		private void RunSession(string sessionId, NetworkStream stream)
		{
		}

		[Token(Token = "0x6000AD0")]
		[Address(RVA = "0xD9DB64", Offset = "0xD9DB64", VA = "0xD9DB64")]
		private void Log(string format, params object[] args)
		{
		}

		[Token(Token = "0x6000AD1")]
		[Address(RVA = "0xD9D5EC", Offset = "0xD9D5EC", VA = "0xD9D5EC")]
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
			[Address(RVA = "0xD9E4EC", Offset = "0xD9E4EC", VA = "0xD9E4EC")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000AE7")]
			[Address(RVA = "0xD9E4F4", Offset = "0xD9E4F4", VA = "0xD9E4F4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700016F")]
		public string format
		{
			[Token(Token = "0x6000AE8")]
			[Address(RVA = "0xD9E4FC", Offset = "0xD9E4FC", VA = "0xD9E4FC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AE9")]
			[Address(RVA = "0xD9E504", Offset = "0xD9E504", VA = "0xD9E504")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000170")]
		public object variables
		{
			[Token(Token = "0x6000AEA")]
			[Address(RVA = "0xD9E50C", Offset = "0xD9E50C", VA = "0xD9E50C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AEB")]
			[Address(RVA = "0xD9E514", Offset = "0xD9E514", VA = "0xD9E514")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000171")]
		public object showUser
		{
			[Token(Token = "0x6000AEC")]
			[Address(RVA = "0xD9E51C", Offset = "0xD9E51C", VA = "0xD9E51C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AED")]
			[Address(RVA = "0xD9E524", Offset = "0xD9E524", VA = "0xD9E524")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000172")]
		public object sendTelemetry
		{
			[Token(Token = "0x6000AEE")]
			[Address(RVA = "0xD9E52C", Offset = "0xD9E52C", VA = "0xD9E52C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AEF")]
			[Address(RVA = "0xD9E534", Offset = "0xD9E534", VA = "0xD9E534")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000AF0")]
		[Address(RVA = "0xD9E53C", Offset = "0xD9E53C", VA = "0xD9E53C")]
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
			[Address(RVA = "0xD9E5E4", Offset = "0xD9E5E4", VA = "0xD9E5E4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000AF2")]
			[Address(RVA = "0xD9E5EC", Offset = "0xD9E5EC", VA = "0xD9E5EC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000174")]
		public Source source
		{
			[Token(Token = "0x6000AF3")]
			[Address(RVA = "0xD9E5F4", Offset = "0xD9E5F4", VA = "0xD9E5F4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AF4")]
			[Address(RVA = "0xD9E5FC", Offset = "0xD9E5FC", VA = "0xD9E5FC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000175")]
		public int line
		{
			[Token(Token = "0x6000AF5")]
			[Address(RVA = "0xD9E604", Offset = "0xD9E604", VA = "0xD9E604")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000AF6")]
			[Address(RVA = "0xD9E60C", Offset = "0xD9E60C", VA = "0xD9E60C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000176")]
		public int column
		{
			[Token(Token = "0x6000AF7")]
			[Address(RVA = "0xD9E614", Offset = "0xD9E614", VA = "0xD9E614")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000AF8")]
			[Address(RVA = "0xD9E61C", Offset = "0xD9E61C", VA = "0xD9E61C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000177")]
		public string name
		{
			[Token(Token = "0x6000AF9")]
			[Address(RVA = "0xD9E624", Offset = "0xD9E624", VA = "0xD9E624")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AFA")]
			[Address(RVA = "0xD9E62C", Offset = "0xD9E62C", VA = "0xD9E62C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000178")]
		public int? endLine
		{
			[Token(Token = "0x6000AFB")]
			[Address(RVA = "0xD9E634", Offset = "0xD9E634", VA = "0xD9E634")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AFC")]
			[Address(RVA = "0xD9E63C", Offset = "0xD9E63C", VA = "0xD9E63C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000179")]
		public int? endColumn
		{
			[Token(Token = "0x6000AFD")]
			[Address(RVA = "0xD9E644", Offset = "0xD9E644", VA = "0xD9E644")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AFE")]
			[Address(RVA = "0xD9E64C", Offset = "0xD9E64C", VA = "0xD9E64C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000AFF")]
		[Address(RVA = "0xD9E654", Offset = "0xD9E654", VA = "0xD9E654")]
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
			[Address(RVA = "0xD9E6BC", Offset = "0xD9E6BC", VA = "0xD9E6BC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B01")]
			[Address(RVA = "0xD9E6C4", Offset = "0xD9E6C4", VA = "0xD9E6C4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700017B")]
		public int variablesReference
		{
			[Token(Token = "0x6000B02")]
			[Address(RVA = "0xD9E6CC", Offset = "0xD9E6CC", VA = "0xD9E6CC")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000B03")]
			[Address(RVA = "0xD9E6D4", Offset = "0xD9E6D4", VA = "0xD9E6D4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700017C")]
		public bool expensive
		{
			[Token(Token = "0x6000B04")]
			[Address(RVA = "0xD9E6DC", Offset = "0xD9E6DC", VA = "0xD9E6DC")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000B05")]
			[Address(RVA = "0xD9E6E4", Offset = "0xD9E6E4", VA = "0xD9E6E4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000B06")]
		[Address(RVA = "0xD9E6F0", Offset = "0xD9E6F0", VA = "0xD9E6F0")]
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
			[Address(RVA = "0xD9E734", Offset = "0xD9E734", VA = "0xD9E734")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B08")]
			[Address(RVA = "0xD9E73C", Offset = "0xD9E73C", VA = "0xD9E73C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700017E")]
		public string value
		{
			[Token(Token = "0x6000B09")]
			[Address(RVA = "0xD9E744", Offset = "0xD9E744", VA = "0xD9E744")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B0A")]
			[Address(RVA = "0xD9E74C", Offset = "0xD9E74C", VA = "0xD9E74C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700017F")]
		public int variablesReference
		{
			[Token(Token = "0x6000B0B")]
			[Address(RVA = "0xD9E754", Offset = "0xD9E754", VA = "0xD9E754")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000B0C")]
			[Address(RVA = "0xD9E75C", Offset = "0xD9E75C", VA = "0xD9E75C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000B0D")]
		[Address(RVA = "0xD9E764", Offset = "0xD9E764", VA = "0xD9E764")]
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
			[Address(RVA = "0xD9E7A0", Offset = "0xD9E7A0", VA = "0xD9E7A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000B0F")]
			[Address(RVA = "0xD9E7A8", Offset = "0xD9E7A8", VA = "0xD9E7A8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000181")]
		public string name
		{
			[Token(Token = "0x6000B10")]
			[Address(RVA = "0xD9E7B0", Offset = "0xD9E7B0", VA = "0xD9E7B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B11")]
			[Address(RVA = "0xD9E7B8", Offset = "0xD9E7B8", VA = "0xD9E7B8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000B12")]
		[Address(RVA = "0xD9E7C0", Offset = "0xD9E7C0", VA = "0xD9E7C0")]
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
			[Address(RVA = "0xD9E870", Offset = "0xD9E870", VA = "0xD9E870")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B14")]
			[Address(RVA = "0xD9E878", Offset = "0xD9E878", VA = "0xD9E878")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000183")]
		public string path
		{
			[Token(Token = "0x6000B15")]
			[Address(RVA = "0xD9E880", Offset = "0xD9E880", VA = "0xD9E880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B16")]
			[Address(RVA = "0xD9E888", Offset = "0xD9E888", VA = "0xD9E888")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000184")]
		public int sourceReference
		{
			[Token(Token = "0x6000B17")]
			[Address(RVA = "0xD9E890", Offset = "0xD9E890", VA = "0xD9E890")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000B18")]
			[Address(RVA = "0xD9E898", Offset = "0xD9E898", VA = "0xD9E898")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000B19")]
		[Address(RVA = "0xD9E8A0", Offset = "0xD9E8A0", VA = "0xD9E8A0")]
		public Source(string name, string path, int sourceReference = 0)
		{
		}

		[Token(Token = "0x6000B1A")]
		[Address(RVA = "0xD9E8DC", Offset = "0xD9E8DC", VA = "0xD9E8DC")]
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
			[Address(RVA = "0xD9E95C", Offset = "0xD9E95C", VA = "0xD9E95C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000B1C")]
			[Address(RVA = "0xD9E964", Offset = "0xD9E964", VA = "0xD9E964")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000186")]
		public int line
		{
			[Token(Token = "0x6000B1D")]
			[Address(RVA = "0xD9E970", Offset = "0xD9E970", VA = "0xD9E970")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000B1E")]
			[Address(RVA = "0xD9E978", Offset = "0xD9E978", VA = "0xD9E978")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000B1F")]
		[Address(RVA = "0xD9E980", Offset = "0xD9E980", VA = "0xD9E980")]
		public Breakpoint(bool verified, int line)
		{
		}
	}
	[Token(Token = "0x2000177")]
	public class InitializedEvent : Event
	{
		[Token(Token = "0x6000B20")]
		[Address(RVA = "0xD9E9B4", Offset = "0xD9E9B4", VA = "0xD9E9B4")]
		public InitializedEvent()
		{
		}
	}
	[Token(Token = "0x2000178")]
	public class StoppedEvent : Event
	{
		[Token(Token = "0x6000B21")]
		[Address(RVA = "0xD9EA68", Offset = "0xD9EA68", VA = "0xD9EA68")]
		public StoppedEvent(int tid, string reasn, [Optional] string txt)
		{
		}
	}
	[Token(Token = "0x2000179")]
	public class ExitedEvent : Event
	{
		[Token(Token = "0x6000B22")]
		[Address(RVA = "0xD9EB20", Offset = "0xD9EB20", VA = "0xD9EB20")]
		public ExitedEvent(int exCode)
		{
		}
	}
	[Token(Token = "0x200017A")]
	public class TerminatedEvent : Event
	{
		[Token(Token = "0x6000B23")]
		[Address(RVA = "0xD9EBC0", Offset = "0xD9EBC0", VA = "0xD9EBC0")]
		public TerminatedEvent()
		{
		}
	}
	[Token(Token = "0x200017B")]
	public class ThreadEvent : Event
	{
		[Token(Token = "0x6000B24")]
		[Address(RVA = "0xD9EC0C", Offset = "0xD9EC0C", VA = "0xD9EC0C")]
		public ThreadEvent(string reasn, int tid)
		{
		}
	}
	[Token(Token = "0x200017C")]
	public class OutputEvent : Event
	{
		[Token(Token = "0x6000B25")]
		[Address(RVA = "0xD9ECB4", Offset = "0xD9ECB4", VA = "0xD9ECB4")]
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
		[Address(RVA = "0xD9ED5C", Offset = "0xD9ED5C", VA = "0xD9ED5C")]
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
			[Address(RVA = "0xD9ED6C", Offset = "0xD9ED6C", VA = "0xD9ED6C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B28")]
			[Address(RVA = "0xD9ED74", Offset = "0xD9ED74", VA = "0xD9ED74")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000B29")]
		[Address(RVA = "0xD9ED7C", Offset = "0xD9ED7C", VA = "0xD9ED7C")]
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
			[Address(RVA = "0xD9EDA4", Offset = "0xD9EDA4", VA = "0xD9EDA4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B2B")]
			[Address(RVA = "0xD9EDAC", Offset = "0xD9EDAC", VA = "0xD9EDAC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000B2C")]
		[Address(RVA = "0xD9EDB4", Offset = "0xD9EDB4", VA = "0xD9EDB4")]
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
			[Address(RVA = "0xD9EE3C", Offset = "0xD9EE3C", VA = "0xD9EE3C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B2E")]
			[Address(RVA = "0xD9EE44", Offset = "0xD9EE44", VA = "0xD9EE44")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000B2F")]
		[Address(RVA = "0xD9EE4C", Offset = "0xD9EE4C", VA = "0xD9EE4C")]
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
			[Address(RVA = "0xD9EED4", Offset = "0xD9EED4", VA = "0xD9EED4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B31")]
			[Address(RVA = "0xD9EEDC", Offset = "0xD9EEDC", VA = "0xD9EEDC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000B32")]
		[Address(RVA = "0xD9EEE4", Offset = "0xD9EEE4", VA = "0xD9EEE4")]
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
			[Address(RVA = "0xD9EF6C", Offset = "0xD9EF6C", VA = "0xD9EF6C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B34")]
			[Address(RVA = "0xD9EF74", Offset = "0xD9EF74", VA = "0xD9EF74")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000B35")]
		[Address(RVA = "0xD9EF7C", Offset = "0xD9EF7C", VA = "0xD9EF7C")]
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
			[Address(RVA = "0xD9F004", Offset = "0xD9F004", VA = "0xD9F004")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B37")]
			[Address(RVA = "0xD9F00C", Offset = "0xD9F00C", VA = "0xD9F00C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700018D")]
		public string type
		{
			[Token(Token = "0x6000B38")]
			[Address(RVA = "0xD9F014", Offset = "0xD9F014", VA = "0xD9F014")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B39")]
			[Address(RVA = "0xD9F01C", Offset = "0xD9F01C", VA = "0xD9F01C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700018E")]
		public int variablesReference
		{
			[Token(Token = "0x6000B3A")]
			[Address(RVA = "0xD9F024", Offset = "0xD9F024", VA = "0xD9F024")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000B3B")]
			[Address(RVA = "0xD9F02C", Offset = "0xD9F02C", VA = "0xD9F02C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000B3C")]
		[Address(RVA = "0xD9F034", Offset = "0xD9F034", VA = "0xD9F034")]
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
			[Address(RVA = "0xD9F064", Offset = "0xD9F064", VA = "0xD9F064")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B3E")]
			[Address(RVA = "0xD9F06C", Offset = "0xD9F06C", VA = "0xD9F06C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000B3F")]
		[Address(RVA = "0xD9F074", Offset = "0xD9F074", VA = "0xD9F074")]
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
		[Address(RVA = "0xD9F0FC", Offset = "0xD9F0FC", VA = "0xD9F0FC")]
		public DebugSession(bool debuggerLinesStartAt1, bool debuggerPathsAreURI = false)
		{
		}

		[Token(Token = "0x6000B41")]
		[Address(RVA = "0xD9F1EC", Offset = "0xD9F1EC", VA = "0xD9F1EC")]
		public void SendResponse(Response response, [Optional] ResponseBody body)
		{
		}

		[Token(Token = "0x6000B42")]
		[Address(RVA = "0xD9F564", Offset = "0xD9F564", VA = "0xD9F564")]
		public void SendErrorResponse(Response response, int id, string format, [Optional] object arguments, bool user = true, bool telemetry = false)
		{
		}

		[Token(Token = "0x6000B43")]
		[Address(RVA = "0xD9F7E8", Offset = "0xD9F7E8", VA = "0xD9F7E8", Slot = "4")]
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
		[Address(RVA = "0xDA035C", Offset = "0xDA035C", VA = "0xDA035C", Slot = "9")]
		public virtual void SetFunctionBreakpoints(Response response, Table arguments)
		{
		}

		[Token(Token = "0x6000B49")]
		[Address(RVA = "0xDA0360", Offset = "0xDA0360", VA = "0xDA0360", Slot = "10")]
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
		[Address(RVA = "0xDA0364", Offset = "0xDA0364", VA = "0xDA0364", Slot = "20")]
		public virtual void Source(Response response, Table arguments)
		{
		}

		[Token(Token = "0x6000B54")]
		public abstract void Threads(Response response, Table arguments);

		[Token(Token = "0x6000B55")]
		public abstract void Evaluate(Response response, Table arguments);

		[Token(Token = "0x6000B56")]
		[Address(RVA = "0xDA03CC", Offset = "0xDA03CC", VA = "0xDA03CC")]
		protected int ConvertDebuggerLineToClient(int line)
		{
			return default(int);
		}

		[Token(Token = "0x6000B57")]
		[Address(RVA = "0xDA03EC", Offset = "0xDA03EC", VA = "0xDA03EC")]
		protected int ConvertClientLineToDebugger(int line)
		{
			return default(int);
		}

		[Token(Token = "0x6000B58")]
		[Address(RVA = "0xDA040C", Offset = "0xDA040C", VA = "0xDA040C")]
		protected string ConvertDebuggerPathToClient(string path)
		{
			return null;
		}

		[Token(Token = "0x6000B59")]
		[Address(RVA = "0xDA0548", Offset = "0xDA0548", VA = "0xDA0548")]
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
			[Address(RVA = "0xDA06C4", Offset = "0xDA06C4", VA = "0xDA06C4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B5B")]
			[Address(RVA = "0xDA06CC", Offset = "0xDA06CC", VA = "0xDA06CC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000B5C")]
		[Address(RVA = "0xDA06D4", Offset = "0xDA06D4", VA = "0xDA06D4")]
		public ProtocolMessage(string typ)
		{
		}

		[Token(Token = "0x6000B5D")]
		[Address(RVA = "0xDA06FC", Offset = "0xDA06FC", VA = "0xDA06FC")]
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
		[Address(RVA = "0xDA072C", Offset = "0xDA072C", VA = "0xDA072C")]
		public Request(int id, string cmd, Table arg)
		{
		}
	}
	[Token(Token = "0x2000188")]
	public class ResponseBody
	{
		[Token(Token = "0x6000B5F")]
		[Address(RVA = "0xD9ED64", Offset = "0xD9ED64", VA = "0xD9ED64")]
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
			[Address(RVA = "0xDA07A4", Offset = "0xDA07A4", VA = "0xDA07A4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000B61")]
			[Address(RVA = "0xDA07AC", Offset = "0xDA07AC", VA = "0xDA07AC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000192")]
		public string message
		{
			[Token(Token = "0x6000B62")]
			[Address(RVA = "0xDA07B8", Offset = "0xDA07B8", VA = "0xDA07B8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B63")]
			[Address(RVA = "0xDA07C0", Offset = "0xDA07C0", VA = "0xDA07C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000193")]
		public int request_seq
		{
			[Token(Token = "0x6000B64")]
			[Address(RVA = "0xDA07C8", Offset = "0xDA07C8", VA = "0xDA07C8")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000B65")]
			[Address(RVA = "0xDA07D0", Offset = "0xDA07D0", VA = "0xDA07D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000194")]
		public string command
		{
			[Token(Token = "0x6000B66")]
			[Address(RVA = "0xDA07D8", Offset = "0xDA07D8", VA = "0xDA07D8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B67")]
			[Address(RVA = "0xDA07E0", Offset = "0xDA07E0", VA = "0xDA07E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000195")]
		public ResponseBody body
		{
			[Token(Token = "0x6000B68")]
			[Address(RVA = "0xDA07E8", Offset = "0xDA07E8", VA = "0xDA07E8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B69")]
			[Address(RVA = "0xDA07F0", Offset = "0xDA07F0", VA = "0xDA07F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000B6A")]
		[Address(RVA = "0xDA07F8", Offset = "0xDA07F8", VA = "0xDA07F8")]
		public Response(Table req)
		{
		}

		[Token(Token = "0x6000B6B")]
		[Address(RVA = "0xD9F210", Offset = "0xD9F210", VA = "0xD9F210")]
		public void SetBody(ResponseBody bdy)
		{
		}

		[Token(Token = "0x6000B6C")]
		[Address(RVA = "0xD9F7D8", Offset = "0xD9F7D8", VA = "0xD9F7D8")]
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
			[Address(RVA = "0xDA08F8", Offset = "0xDA08F8", VA = "0xDA08F8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B6E")]
			[Address(RVA = "0xDA0900", Offset = "0xDA0900", VA = "0xDA0900")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000197")]
		public object body
		{
			[Token(Token = "0x6000B6F")]
			[Address(RVA = "0xDA0908", Offset = "0xDA0908", VA = "0xDA0908")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B70")]
			[Address(RVA = "0xDA0910", Offset = "0xDA0910", VA = "0xDA0910")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000B71")]
		[Address(RVA = "0xD9EA00", Offset = "0xD9EA00", VA = "0xD9EA00")]
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
		[Address(RVA = "0xD9F174", Offset = "0xD9F174", VA = "0xD9F174")]
		public ProtocolServer()
		{
		}

		[Token(Token = "0x6000B73")]
		[Address(RVA = "0xD9DE40", Offset = "0xD9DE40", VA = "0xD9DE40")]
		public void ProcessLoop(Stream inputStream, Stream outputStream)
		{
		}

		[Token(Token = "0x6000B74")]
		[Address(RVA = "0xDA0350", Offset = "0xDA0350", VA = "0xDA0350")]
		public void Stop()
		{
		}

		[Token(Token = "0x6000B75")]
		[Address(RVA = "0xDA0C60", Offset = "0xDA0C60", VA = "0xDA0C60")]
		public void SendEvent(Event e)
		{
		}

		[Token(Token = "0x6000B76")]
		protected abstract void DispatchRequest(string command, Table args, Response response);

		[Token(Token = "0x6000B77")]
		[Address(RVA = "0xDA0A30", Offset = "0xDA0A30", VA = "0xDA0A30")]
		private void ProcessData()
		{
		}

		[Token(Token = "0x6000B78")]
		[Address(RVA = "0xDA0D4C", Offset = "0xDA0D4C", VA = "0xDA0D4C")]
		private void Dispatch(string req)
		{
		}

		[Token(Token = "0x6000B79")]
		[Address(RVA = "0xD9F220", Offset = "0xD9F220", VA = "0xD9F220")]
		protected void SendMessage(ProtocolMessage message)
		{
		}

		[Token(Token = "0x6000B7A")]
		[Address(RVA = "0xDA1068", Offset = "0xDA1068", VA = "0xDA1068")]
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
			[Address(RVA = "0xDA0C64", Offset = "0xDA0C64", VA = "0xDA0C64")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000B7C")]
		[Address(RVA = "0xDA0918", Offset = "0xDA0918", VA = "0xDA0918")]
		public ByteBuffer()
		{
		}

		[Token(Token = "0x6000B7E")]
		[Address(RVA = "0xDA103C", Offset = "0xDA103C", VA = "0xDA103C")]
		public string GetString(Encoding enc)
		{
			return null;
		}

		[Token(Token = "0x6000B7F")]
		[Address(RVA = "0xDA0974", Offset = "0xDA0974", VA = "0xDA0974")]
		public void Append(byte[] b, int length)
		{
		}

		[Token(Token = "0x6000B80")]
		[Address(RVA = "0xDA0C80", Offset = "0xDA0C80", VA = "0xDA0C80")]
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
		[Address(RVA = "0xD9F690", Offset = "0xD9F690", VA = "0xD9F690")]
		public static string ExpandVariables(string format, object variables, bool underscoredOnly = true)
		{
			return null;
		}

		[Token(Token = "0x6000B82")]
		[Address(RVA = "0xDA12B0", Offset = "0xDA12B0", VA = "0xDA12B0")]
		public static string MakeRelativePath(string dirPath, string absPath)
		{
			return null;
		}

		[Token(Token = "0x6000B83")]
		[Address(RVA = "0xDA1370", Offset = "0xDA1370", VA = "0xDA1370")]
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
			[Address(RVA = "0xDA15E8", Offset = "0xDA15E8", VA = "0xDA15E8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B88")]
			[Address(RVA = "0xDA15F0", Offset = "0xDA15F0", VA = "0xDA15F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700019A")]
		public Regex ErrorRegex
		{
			[Token(Token = "0x6000B89")]
			[Address(RVA = "0xDA15F8", Offset = "0xDA15F8", VA = "0xDA15F8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B8A")]
			[Address(RVA = "0xDA1600", Offset = "0xDA1600", VA = "0xDA1600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700019B")]
		public Script Script
		{
			[Token(Token = "0x6000B8B")]
			[Address(RVA = "0xDA1608", Offset = "0xDA1608", VA = "0xDA1608")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B8C")]
			[Address(RVA = "0xDA1610", Offset = "0xDA1610", VA = "0xDA1610")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700019C")]
		public bool PauseRequested
		{
			[Token(Token = "0x6000B8D")]
			[Address(RVA = "0xDA1618", Offset = "0xDA1618", VA = "0xDA1618")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000B8E")]
			[Address(RVA = "0xDA1620", Offset = "0xDA1620", VA = "0xDA1620")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700019D")]
		public string Name
		{
			[Token(Token = "0x6000B8F")]
			[Address(RVA = "0xDA162C", Offset = "0xDA162C", VA = "0xDA162C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B90")]
			[Address(RVA = "0xDA1634", Offset = "0xDA1634", VA = "0xDA1634")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700019E")]
		public int Id
		{
			[Token(Token = "0x6000B91")]
			[Address(RVA = "0xDA163C", Offset = "0xDA163C", VA = "0xDA163C")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000B92")]
			[Address(RVA = "0xDA1644", Offset = "0xDA1644", VA = "0xDA1644")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700019F")]
		public IAsyncDebuggerClient Client
		{
			[Token(Token = "0x6000B94")]
			[Address(RVA = "0xDA164C", Offset = "0xDA164C", VA = "0xDA164C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B95")]
			[Address(RVA = "0xD9CFE4", Offset = "0xD9CFE4", VA = "0xD9CFE4")]
			set
			{
			}
		}

		[Token(Token = "0x6000B93")]
		[Address(RVA = "0xD9BDDC", Offset = "0xD9BDDC", VA = "0xD9BDDC")]
		public AsyncDebugger(Script script, Func<SourceCode, string> sourceFinder, string name)
		{
		}

		[Token(Token = "0x6000B96")]
		[Address(RVA = "0xDA1654", Offset = "0xDA1654", VA = "0xDA1654", Slot = "10")]
		private DebuggerAction MoonSharp.Interpreter.Debugging.IDebugger.GetAction(int ip, SourceRef sourceref)
		{
			return null;
		}

		[Token(Token = "0x6000B97")]
		[Address(RVA = "0xDA18F4", Offset = "0xDA18F4", VA = "0xDA18F4")]
		public void QueueAction(DebuggerAction action)
		{
		}

		[Token(Token = "0x6000B98")]
		[Address(RVA = "0xDA18E8", Offset = "0xDA18E8", VA = "0xDA18E8")]
		private void Sleep(int v)
		{
		}

		[Token(Token = "0x6000B99")]
		[Address(RVA = "0xDA19F4", Offset = "0xDA19F4", VA = "0xDA19F4")]
		private DynamicExpression CreateDynExpr(string code)
		{
			return null;
		}

		[Token(Token = "0x6000B9A")]
		[Address(RVA = "0xDA1B00", Offset = "0xDA1B00", VA = "0xDA1B00", Slot = "13")]
		private List<DynamicExpression> MoonSharp.Interpreter.Debugging.IDebugger.GetWatchItems()
		{
			return null;
		}

		[Token(Token = "0x6000B9B")]
		[Address(RVA = "0xDA1B70", Offset = "0xDA1B70", VA = "0xDA1B70", Slot = "8")]
		private bool MoonSharp.Interpreter.Debugging.IDebugger.IsPauseRequested()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B9C")]
		[Address(RVA = "0xDA1B78", Offset = "0xDA1B78", VA = "0xDA1B78", Slot = "14")]
		private void MoonSharp.Interpreter.Debugging.IDebugger.RefreshBreakpoints(IEnumerable<SourceRef> refs)
		{
		}

		[Token(Token = "0x6000B9D")]
		[Address(RVA = "0xDA1B7C", Offset = "0xDA1B7C", VA = "0xDA1B7C", Slot = "7")]
		private void MoonSharp.Interpreter.Debugging.IDebugger.SetByteCode(string[] byteCode)
		{
		}

		[Token(Token = "0x6000B9E")]
		[Address(RVA = "0xDA1B80", Offset = "0xDA1B80", VA = "0xDA1B80", Slot = "6")]
		private void MoonSharp.Interpreter.Debugging.IDebugger.SetSourceCode(SourceCode sourceCode)
		{
		}

		[Token(Token = "0x6000B9F")]
		[Address(RVA = "0xDA1EE4", Offset = "0xDA1EE4", VA = "0xDA1EE4")]
		private string GetFooterForTempFile()
		{
			return null;
		}

		[Token(Token = "0x6000BA0")]
		[Address(RVA = "0xDA1F24", Offset = "0xDA1F24", VA = "0xDA1F24")]
		public string GetSourceFile(int sourceId)
		{
			return null;
		}

		[Token(Token = "0x6000BA1")]
		[Address(RVA = "0xDA2018", Offset = "0xDA2018", VA = "0xDA2018")]
		public bool IsSourceOverride(int sourceId)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BA2")]
		[Address(RVA = "0xDA2070", Offset = "0xDA2070", VA = "0xDA2070", Slot = "11")]
		private void MoonSharp.Interpreter.Debugging.IDebugger.SignalExecutionEnded()
		{
		}

		[Token(Token = "0x6000BA3")]
		[Address(RVA = "0xDA21B4", Offset = "0xDA21B4", VA = "0xDA21B4", Slot = "9")]
		private bool MoonSharp.Interpreter.Debugging.IDebugger.SignalRuntimeException(ScriptRuntimeException ex)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BA4")]
		[Address(RVA = "0xDA2368", Offset = "0xDA2368", VA = "0xDA2368", Slot = "12")]
		private void MoonSharp.Interpreter.Debugging.IDebugger.Update(WatchType watchType, IEnumerable<WatchItem> items)
		{
		}

		[Token(Token = "0x6000BA5")]
		[Address(RVA = "0xDA2540", Offset = "0xDA2540", VA = "0xDA2540")]
		public List<WatchItem> GetWatches(WatchType watchType)
		{
			return null;
		}

		[Token(Token = "0x6000BA6")]
		[Address(RVA = "0xDA2570", Offset = "0xDA2570", VA = "0xDA2570")]
		public SourceCode GetSource(int id)
		{
			return null;
		}

		[Token(Token = "0x6000BA7")]
		[Address(RVA = "0xDA2604", Offset = "0xDA2604", VA = "0xDA2604")]
		public SourceCode FindSourceByName(string path)
		{
			return null;
		}

		[Token(Token = "0x6000BA8")]
		[Address(RVA = "0xDA2920", Offset = "0xDA2920", VA = "0xDA2920", Slot = "5")]
		private void MoonSharp.Interpreter.Debugging.IDebugger.SetDebugService(DebugService debugService)
		{
		}

		[Token(Token = "0x6000BA9")]
		[Address(RVA = "0xDA2928", Offset = "0xDA2928", VA = "0xDA2928")]
		public DynValue Evaluate(string expression)
		{
			return null;
		}

		[Token(Token = "0x6000BAA")]
		[Address(RVA = "0xDA2948", Offset = "0xDA2948", VA = "0xDA2948", Slot = "4")]
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
		[Address(RVA = "0xD9DE14", Offset = "0xD9DE14", VA = "0xD9DE14")]
		internal EmptyDebugSession(MoonSharpVsCodeDebugServer server)
		{
		}

		[Token(Token = "0x6000BAF")]
		[Address(RVA = "0xDA2A18", Offset = "0xDA2A18", VA = "0xDA2A18", Slot = "5")]
		public override void Initialize(Response response, Table args)
		{
		}

		[Token(Token = "0x6000BB0")]
		[Address(RVA = "0xDA2E70", Offset = "0xDA2E70", VA = "0xDA2E70")]
		private void SendList()
		{
		}

		[Token(Token = "0x6000BB1")]
		[Address(RVA = "0xDA346C", Offset = "0xDA346C", VA = "0xDA346C", Slot = "7")]
		public override void Attach(Response response, Table arguments)
		{
		}

		[Token(Token = "0x6000BB2")]
		[Address(RVA = "0xDA3470", Offset = "0xDA3470", VA = "0xDA3470", Slot = "12")]
		public override void Continue(Response response, Table arguments)
		{
		}

		[Token(Token = "0x6000BB3")]
		[Address(RVA = "0xDA3498", Offset = "0xDA3498", VA = "0xDA3498", Slot = "8")]
		public override void Disconnect(Response response, Table arguments)
		{
		}

		[Token(Token = "0x6000BB4")]
		[Address(RVA = "0xDA349C", Offset = "0xDA349C", VA = "0xDA349C")]
		private static string getString(Table args, string property, [Optional] string dflt)
		{
			return null;
		}

		[Token(Token = "0x6000BB5")]
		[Address(RVA = "0xDA353C", Offset = "0xDA353C", VA = "0xDA353C", Slot = "22")]
		public override void Evaluate(Response response, Table args)
		{
		}

		[Token(Token = "0x6000BB6")]
		[Address(RVA = "0xDA362C", Offset = "0xDA362C", VA = "0xDA362C")]
		private void ExecuteRepl(string cmd)
		{
		}

		[Token(Token = "0x6000BB7")]
		[Address(RVA = "0xDA3818", Offset = "0xDA3818", VA = "0xDA3818", Slot = "6")]
		public override void Launch(Response response, Table arguments)
		{
		}

		[Token(Token = "0x6000BB8")]
		[Address(RVA = "0xDA381C", Offset = "0xDA381C", VA = "0xDA381C", Slot = "13")]
		public override void Next(Response response, Table arguments)
		{
		}

		[Token(Token = "0x6000BB9")]
		[Address(RVA = "0xDA3844", Offset = "0xDA3844", VA = "0xDA3844", Slot = "16")]
		public override void Pause(Response response, Table arguments)
		{
		}

		[Token(Token = "0x6000BBA")]
		[Address(RVA = "0xDA386C", Offset = "0xDA386C", VA = "0xDA386C", Slot = "18")]
		public override void Scopes(Response response, Table arguments)
		{
		}

		[Token(Token = "0x6000BBB")]
		[Address(RVA = "0xDA3870", Offset = "0xDA3870", VA = "0xDA3870", Slot = "11")]
		public override void SetBreakpoints(Response response, Table args)
		{
		}

		[Token(Token = "0x6000BBC")]
		[Address(RVA = "0xDA3874", Offset = "0xDA3874", VA = "0xDA3874", Slot = "17")]
		public override void StackTrace(Response response, Table args)
		{
		}

		[Token(Token = "0x6000BBD")]
		[Address(RVA = "0xDA3878", Offset = "0xDA3878", VA = "0xDA3878", Slot = "14")]
		public override void StepIn(Response response, Table arguments)
		{
		}

		[Token(Token = "0x6000BBE")]
		[Address(RVA = "0xDA38A0", Offset = "0xDA38A0", VA = "0xDA38A0", Slot = "15")]
		public override void StepOut(Response response, Table arguments)
		{
		}

		[Token(Token = "0x6000BBF")]
		[Address(RVA = "0xDA38C8", Offset = "0xDA38C8", VA = "0xDA38C8", Slot = "21")]
		public override void Threads(Response response, Table arguments)
		{
		}

		[Token(Token = "0x6000BC0")]
		[Address(RVA = "0xDA3A2C", Offset = "0xDA3A2C", VA = "0xDA3A2C", Slot = "19")]
		public override void Variables(Response response, Table arguments)
		{
		}

		[Token(Token = "0x6000BC1")]
		[Address(RVA = "0xDA2DA4", Offset = "0xDA2DA4", VA = "0xDA2DA4")]
		private void SendText(string msg, params object[] args)
		{
		}

		[Token(Token = "0x6000BC2")]
		[Address(RVA = "0xDA3744", Offset = "0xDA3744", VA = "0xDA3744")]
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
		[Address(RVA = "0xD9DD34", Offset = "0xD9DD34", VA = "0xD9DD34")]
		internal MoonSharpDebugSession(MoonSharpVsCodeDebugServer server, AsyncDebugger debugger)
		{
		}

		[Token(Token = "0x6000BCA")]
		[Address(RVA = "0xDA3A30", Offset = "0xDA3A30", VA = "0xDA3A30", Slot = "5")]
		public override void Initialize(Response response, Table args)
		{
		}

		[Token(Token = "0x6000BCB")]
		[Address(RVA = "0xDA3EF8", Offset = "0xDA3EF8", VA = "0xDA3EF8", Slot = "7")]
		public override void Attach(Response response, Table arguments)
		{
		}

		[Token(Token = "0x6000BCC")]
		[Address(RVA = "0xDA3EFC", Offset = "0xDA3EFC", VA = "0xDA3EFC", Slot = "12")]
		public override void Continue(Response response, Table arguments)
		{
		}

		[Token(Token = "0x6000BCD")]
		[Address(RVA = "0xDA3F88", Offset = "0xDA3F88", VA = "0xDA3F88", Slot = "8")]
		public override void Disconnect(Response response, Table arguments)
		{
		}

		[Token(Token = "0x6000BCE")]
		[Address(RVA = "0xDA3FC0", Offset = "0xDA3FC0", VA = "0xDA3FC0")]
		private static string getString(Table args, string property, [Optional] string dflt)
		{
			return null;
		}

		[Token(Token = "0x6000BCF")]
		[Address(RVA = "0xDA4060", Offset = "0xDA4060", VA = "0xDA4060", Slot = "22")]
		public override void Evaluate(Response response, Table args)
		{
		}

		[Token(Token = "0x6000BD0")]
		[Address(RVA = "0xDA445C", Offset = "0xDA445C", VA = "0xDA445C")]
		private void ExecuteRepl(string cmd)
		{
		}

		[Token(Token = "0x6000BD1")]
		[Address(RVA = "0xDA559C", Offset = "0xDA559C", VA = "0xDA559C", Slot = "6")]
		public override void Launch(Response response, Table arguments)
		{
		}

		[Token(Token = "0x6000BD2")]
		[Address(RVA = "0xDA55A0", Offset = "0xDA55A0", VA = "0xDA55A0", Slot = "13")]
		public override void Next(Response response, Table arguments)
		{
		}

		[Token(Token = "0x6000BD3")]
		[Address(RVA = "0xDA562C", Offset = "0xDA562C", VA = "0xDA562C")]
		private StoppedEvent CreateStoppedEvent(string reason, [Optional] string text)
		{
			return null;
		}

		[Token(Token = "0x6000BD4")]
		[Address(RVA = "0xDA56A0", Offset = "0xDA56A0", VA = "0xDA56A0", Slot = "16")]
		public override void Pause(Response response, Table arguments)
		{
		}

		[Token(Token = "0x6000BD5")]
		[Address(RVA = "0xDA5760", Offset = "0xDA5760", VA = "0xDA5760", Slot = "18")]
		public override void Scopes(Response response, Table arguments)
		{
		}

		[Token(Token = "0x6000BD6")]
		[Address(RVA = "0xDA5974", Offset = "0xDA5974", VA = "0xDA5974", Slot = "11")]
		public override void SetBreakpoints(Response response, Table args)
		{
		}

		[Token(Token = "0x6000BD7")]
		[Address(RVA = "0xDA5EE4", Offset = "0xDA5EE4", VA = "0xDA5EE4", Slot = "17")]
		public override void StackTrace(Response response, Table args)
		{
		}

		[Token(Token = "0x6000BD8")]
		[Address(RVA = "0xDA43CC", Offset = "0xDA43CC", VA = "0xDA43CC")]
		private int getInt(Table args, string propName, int defaultValue)
		{
			return default(int);
		}

		[Token(Token = "0x6000BD9")]
		[Address(RVA = "0xDA6584", Offset = "0xDA6584", VA = "0xDA6584", Slot = "14")]
		public override void StepIn(Response response, Table arguments)
		{
		}

		[Token(Token = "0x6000BDA")]
		[Address(RVA = "0xDA6610", Offset = "0xDA6610", VA = "0xDA6610", Slot = "15")]
		public override void StepOut(Response response, Table arguments)
		{
		}

		[Token(Token = "0x6000BDB")]
		[Address(RVA = "0xDA669C", Offset = "0xDA669C", VA = "0xDA669C", Slot = "21")]
		public override void Threads(Response response, Table arguments)
		{
		}

		[Token(Token = "0x6000BDC")]
		[Address(RVA = "0xDA6800", Offset = "0xDA6800", VA = "0xDA6800", Slot = "19")]
		public override void Variables(Response response, Table arguments)
		{
		}

		[Token(Token = "0x6000BDD")]
		[Address(RVA = "0xDA8240", Offset = "0xDA8240", VA = "0xDA8240", Slot = "23")]
		private void MoonSharp.VsCodeDebugger.DebuggerLogic.IAsyncDebuggerClient.SendStopEvent()
		{
		}

		[Token(Token = "0x6000BDE")]
		[Address(RVA = "0xDA8294", Offset = "0xDA8294", VA = "0xDA8294", Slot = "24")]
		private void MoonSharp.VsCodeDebugger.DebuggerLogic.IAsyncDebuggerClient.OnWatchesUpdated(WatchType watchType)
		{
		}

		[Token(Token = "0x6000BDF")]
		[Address(RVA = "0xDA8310", Offset = "0xDA8310", VA = "0xDA8310", Slot = "25")]
		private void MoonSharp.VsCodeDebugger.DebuggerLogic.IAsyncDebuggerClient.OnSourceCodeChanged(int sourceID)
		{
		}

		[Token(Token = "0x6000BE0")]
		[Address(RVA = "0xDA84A4", Offset = "0xDA84A4", VA = "0xDA84A4", Slot = "26")]
		public void OnExecutionEnded()
		{
		}

		[Token(Token = "0x6000BE1")]
		[Address(RVA = "0xDA3E2C", Offset = "0xDA3E2C", VA = "0xDA3E2C")]
		private void SendText(string msg, params object[] args)
		{
		}

		[Token(Token = "0x6000BE2")]
		[Address(RVA = "0xDA8554", Offset = "0xDA8554", VA = "0xDA8554", Slot = "27")]
		public void OnException(ScriptRuntimeException ex)
		{
		}

		[Token(Token = "0x6000BE3")]
		[Address(RVA = "0xDA5468", Offset = "0xDA5468", VA = "0xDA5468", Slot = "28")]
		public void Unbind()
		{
		}
	}
	[Token(Token = "0x2000194")]
	internal static class VariableInspector
	{
		[Token(Token = "0x6000BE5")]
		[Address(RVA = "0xDA6C94", Offset = "0xDA6C94", VA = "0xDA6C94")]
		internal static void InspectVariable(DynValue v, List<Variable> variables)
		{
		}
	}
}
