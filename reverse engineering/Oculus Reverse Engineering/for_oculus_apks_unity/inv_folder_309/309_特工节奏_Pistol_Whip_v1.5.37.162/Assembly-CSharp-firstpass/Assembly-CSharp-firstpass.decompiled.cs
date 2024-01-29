using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Helper;
using Il2CppDummyDll;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Helper
{
	[Token(Token = "0x2000002")]
	internal class CollectionMap<TKey, TValue> : ThreadSafeDictionary<TKey, TValue> where TValue : new()
	{
		[Token(Token = "0x6000001")]
		public bool TryAddDefault(TKey key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000002")]
		public CollectionMap()
		{
		}
	}
	[Token(Token = "0x2000003")]
	public static class ExceptionHelper
	{
		[Token(Token = "0x4000001")]
		private const int E_NOTIMPL = -2147467263;

		[Token(Token = "0x4000002")]
		private const int E_OUTOFMEMORY = -2147024882;

		[Token(Token = "0x4000003")]
		private const int E_INVALIDARG = -2147024809;

		[Token(Token = "0x4000004")]
		private const int E_POINTER = -2147467261;

		[Token(Token = "0x4000005")]
		private const int E_PENDING = -2147483638;

		[Token(Token = "0x4000006")]
		private const int E_FAIL = -2147467259;

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x2DC1B58", Offset = "0x2DC1B58", VA = "0x2DC1B58")]
		public static void CheckLastError()
		{
		}
	}
	[Token(Token = "0x2000004")]
	internal interface INativeWrapper
	{
		[Token(Token = "0x17000001")]
		IntPtr nativePtr
		{
			[Token(Token = "0x6000004")]
			get;
		}
	}
	[Token(Token = "0x2000005")]
	public static class NativeObjectCache
	{
		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static object _lock;

		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Dictionary<Type, Dictionary<IntPtr, WeakReference>> _objectCache;

		[Token(Token = "0x6000005")]
		public static void AddObject<T>(IntPtr nativePtr, T obj) where T : class
		{
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0x2DC1D78", Offset = "0x2DC1D78", VA = "0x2DC1D78")]
		public static void Flush()
		{
		}

		[Token(Token = "0x6000007")]
		public static void RemoveObject<T>(IntPtr nativePtr)
		{
		}

		[Token(Token = "0x6000008")]
		public static T GetObject<T>(IntPtr nativePtr) where T : class
		{
			return null;
		}

		[Token(Token = "0x6000009")]
		public static T CreateOrGetObject<T>(IntPtr nativePtr, Func<IntPtr, T> create) where T : class
		{
			return null;
		}
	}
	[Token(Token = "0x2000006")]
	public static class NativeWrapper
	{
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x2DC209C", Offset = "0x2DC209C", VA = "0x2DC209C")]
		public static IntPtr GetNativePtr(object obj)
		{
			return default(IntPtr);
		}
	}
	[Token(Token = "0x2000007")]
	public class SmartGCHandle : IDisposable
	{
		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private GCHandle handle;

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x2DC21A4", Offset = "0x2DC21A4", VA = "0x2DC21A4")]
		public SmartGCHandle(GCHandle handle)
		{
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x2DC21D0", Offset = "0x2DC21D0", VA = "0x2DC21D0", Slot = "1")]
		~SmartGCHandle()
		{
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x2DC2244", Offset = "0x2DC2244", VA = "0x2DC2244")]
		public IntPtr AddrOfPinnedObject()
		{
			return default(IntPtr);
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x2DC2250", Offset = "0x2DC2250", VA = "0x2DC2250", Slot = "5")]
		public virtual void Dispose()
		{
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x2DC2260", Offset = "0x2DC2260", VA = "0x2DC2260", Slot = "6")]
		protected virtual void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x2DC226C", Offset = "0x2DC226C", VA = "0x2DC226C")]
		public static implicit operator GCHandle(SmartGCHandle other)
		{
			return default(GCHandle);
		}
	}
	[Token(Token = "0x2000008")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x1247F24", Offset = "0x1247F24")]
	public class ThreadSafeDictionary<TKey, TValue>
	{
		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected readonly Dictionary<TKey, TValue> _impl;

		[Token(Token = "0x17000002")]
		public TValue Item
		{
			[Token(Token = "0x6000012")]
			get
			{
				return (TValue)null;
			}
			[Token(Token = "0x6000013")]
			set
			{
			}
		}

		[Token(Token = "0x6000014")]
		public void Add(TKey key, TValue value)
		{
		}

		[Token(Token = "0x6000015")]
		public bool TryGetValue(TKey key, out TValue value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000016")]
		public bool Remove(TKey key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000017")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000018")]
		public ThreadSafeDictionary()
		{
		}
	}
}
namespace Windows.Data
{
	[Token(Token = "0x2000009")]
	public sealed class PropertyChangedEventArgs : EventArgs, INativeWrapper
	{
		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal IntPtr _pNative;

		[Token(Token = "0x17000003")]
		private IntPtr Helper.INativeWrapper.nativePtr
		{
			[Token(Token = "0x6000019")]
			[Address(RVA = "0x2DC2284", Offset = "0x2DC2284", VA = "0x2DC2284", Slot = "4")]
			get
			{
				return default(IntPtr);
			}
		}

		[Token(Token = "0x17000004")]
		public string PropertyName
		{
			[Token(Token = "0x6000020")]
			[Address(RVA = "0x2DC25A8", Offset = "0x2DC25A8", VA = "0x2DC25A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x2DC228C", Offset = "0x2DC228C", VA = "0x2DC228C")]
		internal PropertyChangedEventArgs(IntPtr pNative)
		{
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x2DC2390", Offset = "0x2DC2390", VA = "0x2DC2390", Slot = "1")]
		~PropertyChangedEventArgs()
		{
		}

		[PreserveSig]
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x2DC2494", Offset = "0x2DC2494", VA = "0x2DC2494")]
		private static extern void Windows_Data_PropertyChangedEventArgs_ReleaseObject(ref IntPtr pNative);

		[PreserveSig]
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x2DC230C", Offset = "0x2DC230C", VA = "0x2DC230C")]
		private static extern void Windows_Data_PropertyChangedEventArgs_AddRefObject(ref IntPtr pNative);

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x2DC23FC", Offset = "0x2DC23FC", VA = "0x2DC23FC")]
		private void Dispose(bool disposing)
		{
		}

		[PreserveSig]
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x2DC251C", Offset = "0x2DC251C", VA = "0x2DC251C")]
		private static extern IntPtr Windows_Data_PropertyChangedEventArgs_get_PropertyName(IntPtr pNative);

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x2DC2518", Offset = "0x2DC2518", VA = "0x2DC2518")]
		private void __EventCleanup()
		{
		}
	}
}
namespace Windows.Kinect
{
	[Token(Token = "0x200000A")]
	public struct CameraIntrinsics
	{
		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1247F5C", Offset = "0x1247F5C")]
		private float <FocalLengthX>k__BackingField;

		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1247F6C", Offset = "0x1247F6C")]
		private float <FocalLengthY>k__BackingField;

		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1247F7C", Offset = "0x1247F7C")]
		private float <PrincipalPointX>k__BackingField;

		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1247F8C", Offset = "0x1247F8C")]
		private float <PrincipalPointY>k__BackingField;

		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1247F9C", Offset = "0x1247F9C")]
		private float <RadialDistortionSecondOrder>k__BackingField;

		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1247FAC", Offset = "0x1247FAC")]
		private float <RadialDistortionFourthOrder>k__BackingField;

		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1247FBC", Offset = "0x1247FBC")]
		private float <RadialDistortionSixthOrder>k__BackingField;

		[Token(Token = "0x17000005")]
		public float FocalLengthX
		{
			[Token(Token = "0x6000022")]
			[Address(RVA = "0x10E8880", Offset = "0x10E8880", VA = "0x10E8880")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1247FCC", Offset = "0x1247FCC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000023")]
			[Address(RVA = "0x10E8888", Offset = "0x10E8888", VA = "0x10E8888")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1247FDC", Offset = "0x1247FDC")]
			set
			{
			}
		}

		[Token(Token = "0x17000006")]
		public float FocalLengthY
		{
			[Token(Token = "0x6000024")]
			[Address(RVA = "0x10E8890", Offset = "0x10E8890", VA = "0x10E8890")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1247FEC", Offset = "0x1247FEC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000025")]
			[Address(RVA = "0x10E8898", Offset = "0x10E8898", VA = "0x10E8898")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1247FFC", Offset = "0x1247FFC")]
			set
			{
			}
		}

		[Token(Token = "0x17000007")]
		public float PrincipalPointX
		{
			[Token(Token = "0x6000026")]
			[Address(RVA = "0x10E88A0", Offset = "0x10E88A0", VA = "0x10E88A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x124800C", Offset = "0x124800C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000027")]
			[Address(RVA = "0x10E88A8", Offset = "0x10E88A8", VA = "0x10E88A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x124801C", Offset = "0x124801C")]
			set
			{
			}
		}

		[Token(Token = "0x17000008")]
		public float PrincipalPointY
		{
			[Token(Token = "0x6000028")]
			[Address(RVA = "0x10E88B0", Offset = "0x10E88B0", VA = "0x10E88B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x124802C", Offset = "0x124802C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000029")]
			[Address(RVA = "0x10E88B8", Offset = "0x10E88B8", VA = "0x10E88B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x124803C", Offset = "0x124803C")]
			set
			{
			}
		}

		[Token(Token = "0x17000009")]
		public float RadialDistortionSecondOrder
		{
			[Token(Token = "0x600002A")]
			[Address(RVA = "0x10E88C0", Offset = "0x10E88C0", VA = "0x10E88C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x124804C", Offset = "0x124804C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600002B")]
			[Address(RVA = "0x10E88C8", Offset = "0x10E88C8", VA = "0x10E88C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x124805C", Offset = "0x124805C")]
			set
			{
			}
		}

		[Token(Token = "0x1700000A")]
		public float RadialDistortionFourthOrder
		{
			[Token(Token = "0x600002C")]
			[Address(RVA = "0x10E88D0", Offset = "0x10E88D0", VA = "0x10E88D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x124806C", Offset = "0x124806C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600002D")]
			[Address(RVA = "0x10E88D8", Offset = "0x10E88D8", VA = "0x10E88D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x124807C", Offset = "0x124807C")]
			set
			{
			}
		}

		[Token(Token = "0x1700000B")]
		public float RadialDistortionSixthOrder
		{
			[Token(Token = "0x600002E")]
			[Address(RVA = "0x10E88E0", Offset = "0x10E88E0", VA = "0x10E88E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x124808C", Offset = "0x124808C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600002F")]
			[Address(RVA = "0x10E88E8", Offset = "0x10E88E8", VA = "0x10E88E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x124809C", Offset = "0x124809C")]
			set
			{
			}
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x10E88F0", Offset = "0x10E88F0", VA = "0x10E88F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x10E88F8", Offset = "0x10E88F8", VA = "0x10E88F8", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x10E8900", Offset = "0x10E8900", VA = "0x10E8900")]
		public bool Equals(CameraIntrinsics obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x2DC297C", Offset = "0x2DC297C", VA = "0x2DC297C")]
		public static bool operator ==(CameraIntrinsics a, CameraIntrinsics b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x2DC29B0", Offset = "0x2DC29B0", VA = "0x2DC29B0")]
		public static bool operator !=(CameraIntrinsics a, CameraIntrinsics b)
		{
			return default(bool);
		}
	}
}
