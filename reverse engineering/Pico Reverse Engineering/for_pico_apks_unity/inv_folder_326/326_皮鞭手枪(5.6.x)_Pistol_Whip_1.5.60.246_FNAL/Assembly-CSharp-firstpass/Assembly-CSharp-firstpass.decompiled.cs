using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
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
		[Address(RVA = "0x10C43D8", Offset = "0x10C43D8", VA = "0x10C43D8")]
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
		[Address(RVA = "0x10C4614", Offset = "0x10C4614", VA = "0x10C4614")]
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
		[Address(RVA = "0x10C49E8", Offset = "0x10C49E8", VA = "0x10C49E8")]
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
		[Address(RVA = "0x10C4B0C", Offset = "0x10C4B0C", VA = "0x10C4B0C")]
		public SmartGCHandle(GCHandle handle)
		{
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x10C4B34", Offset = "0x10C4B34", VA = "0x10C4B34", Slot = "1")]
		~SmartGCHandle()
		{
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x10C4BD4", Offset = "0x10C4BD4", VA = "0x10C4BD4")]
		public IntPtr AddrOfPinnedObject()
		{
			return default(IntPtr);
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x10C4BE0", Offset = "0x10C4BE0", VA = "0x10C4BE0", Slot = "5")]
		public virtual void Dispose()
		{
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x10C4BF0", Offset = "0x10C4BF0", VA = "0x10C4BF0", Slot = "6")]
		protected virtual void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x10C4BFC", Offset = "0x10C4BFC", VA = "0x10C4BFC")]
		public static implicit operator GCHandle(SmartGCHandle other)
		{
			return default(GCHandle);
		}
	}
	[Token(Token = "0x2000008")]
	public class ThreadSafeDictionary<TKey, TValue>
	{
		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected readonly Dictionary<TKey, TValue> _impl;

		[Token(Token = "0x17000002")]
		public TValue this[TKey key]
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
			[Address(RVA = "0x10C4C14", Offset = "0x10C4C14", VA = "0x10C4C14", Slot = "4")]
			get
			{
				return default(IntPtr);
			}
		}

		[Token(Token = "0x17000004")]
		public string PropertyName
		{
			[Token(Token = "0x6000020")]
			[Address(RVA = "0x10C4F74", Offset = "0x10C4F74", VA = "0x10C4F74")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x10C4C1C", Offset = "0x10C4C1C", VA = "0x10C4C1C")]
		internal PropertyChangedEventArgs(IntPtr pNative)
		{
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x10C4D0C", Offset = "0x10C4D0C", VA = "0x10C4D0C", Slot = "1")]
		~PropertyChangedEventArgs()
		{
		}

		[PreserveSig]
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x10C4E68", Offset = "0x10C4E68", VA = "0x10C4E68")]
		private static extern void Windows_Data_PropertyChangedEventArgs_ReleaseObject(ref IntPtr pNative);

		[PreserveSig]
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x10C4C8C", Offset = "0x10C4C8C", VA = "0x10C4C8C")]
		private static extern void Windows_Data_PropertyChangedEventArgs_AddRefObject(ref IntPtr pNative);

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x10C4DA4", Offset = "0x10C4DA4", VA = "0x10C4DA4")]
		private void Dispose(bool disposing)
		{
		}

		[PreserveSig]
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x10C4EEC", Offset = "0x10C4EEC", VA = "0x10C4EEC")]
		private static extern IntPtr Windows_Data_PropertyChangedEventArgs_get_PropertyName(IntPtr pNative);

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x10C4EE8", Offset = "0x10C4EE8", VA = "0x10C4EE8")]
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
		[Token(Token = "0x17000005")]
		public float FocalLengthX
		{
			[Token(Token = "0x6000022")]
			[Address(RVA = "0x10C5070", Offset = "0x10C5070", VA = "0x10C5070")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Token(Token = "0x6000023")]
			[Address(RVA = "0x10C5078", Offset = "0x10C5078", VA = "0x10C5078")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000006")]
		public float FocalLengthY
		{
			[Token(Token = "0x6000024")]
			[Address(RVA = "0x10C5080", Offset = "0x10C5080", VA = "0x10C5080")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Token(Token = "0x6000025")]
			[Address(RVA = "0x10C5088", Offset = "0x10C5088", VA = "0x10C5088")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000007")]
		public float PrincipalPointX
		{
			[Token(Token = "0x6000026")]
			[Address(RVA = "0x10C5090", Offset = "0x10C5090", VA = "0x10C5090")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Token(Token = "0x6000027")]
			[Address(RVA = "0x10C5098", Offset = "0x10C5098", VA = "0x10C5098")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000008")]
		public float PrincipalPointY
		{
			[Token(Token = "0x6000028")]
			[Address(RVA = "0x10C50A0", Offset = "0x10C50A0", VA = "0x10C50A0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Token(Token = "0x6000029")]
			[Address(RVA = "0x10C50A8", Offset = "0x10C50A8", VA = "0x10C50A8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000009")]
		public float RadialDistortionSecondOrder
		{
			[Token(Token = "0x600002A")]
			[Address(RVA = "0x10C50B0", Offset = "0x10C50B0", VA = "0x10C50B0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Token(Token = "0x600002B")]
			[Address(RVA = "0x10C50B8", Offset = "0x10C50B8", VA = "0x10C50B8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700000A")]
		public float RadialDistortionFourthOrder
		{
			[Token(Token = "0x600002C")]
			[Address(RVA = "0x10C50C0", Offset = "0x10C50C0", VA = "0x10C50C0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Token(Token = "0x600002D")]
			[Address(RVA = "0x10C50C8", Offset = "0x10C50C8", VA = "0x10C50C8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700000B")]
		public float RadialDistortionSixthOrder
		{
			[Token(Token = "0x600002E")]
			[Address(RVA = "0x10C50D0", Offset = "0x10C50D0", VA = "0x10C50D0")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Token(Token = "0x600002F")]
			[Address(RVA = "0x10C50D8", Offset = "0x10C50D8", VA = "0x10C50D8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x10C50E0", Offset = "0x10C50E0", VA = "0x10C50E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x10C51CC", Offset = "0x10C51CC", VA = "0x10C51CC", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x10C525C", Offset = "0x10C525C", VA = "0x10C525C")]
		public bool Equals(CameraIntrinsics obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x10C5344", Offset = "0x10C5344", VA = "0x10C5344")]
		public static bool operator ==(CameraIntrinsics a, CameraIntrinsics b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x10C5374", Offset = "0x10C5374", VA = "0x10C5374")]
		public static bool operator !=(CameraIntrinsics a, CameraIntrinsics b)
		{
			return default(bool);
		}
	}
}
